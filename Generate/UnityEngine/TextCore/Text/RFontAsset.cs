using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.FontAsset
	/// </summary>
    public partial class RFontAsset : RMember //
    {

		/// <summary>
		/// System.String m_SourceFontFileGUID
		/// </summary>
		protected RField r_m_SourceFontFileGUID;
		public virtual RField Rm_SourceFontFileGUID
		{
			get
			{
				if(r_m_SourceFontFileGUID == null)
				{
					r_m_SourceFontFileGUID = new(this, "m_SourceFontFileGUID");
					r_m_SourceFontFileGUID.SetBelong(this.instance);
				}
				return r_m_SourceFontFileGUID;
			}
		}

		/// <summary>
		/// UnityEngine.Font m_SourceFontFile_EditorRef
		/// </summary>
		protected RUnityEngine.RFont r_m_SourceFontFile_EditorRef;
		public virtual RUnityEngine.RFont Rm_SourceFontFile_EditorRef
		{
			get
			{
				if(r_m_SourceFontFile_EditorRef == null)
				{
					r_m_SourceFontFile_EditorRef = new(this, "m_SourceFontFile_EditorRef");
					r_m_SourceFontFile_EditorRef.SetBelong(this.instance);
				}
				return r_m_SourceFontFile_EditorRef;
			}
		}

		/// <summary>
		/// UnityEngine.Font m_SourceFontFile
		/// </summary>
		protected RUnityEngine.RFont r_m_SourceFontFile;
		public virtual RUnityEngine.RFont Rm_SourceFontFile
		{
			get
			{
				if(r_m_SourceFontFile == null)
				{
					r_m_SourceFontFile = new(this, "m_SourceFontFile");
					r_m_SourceFontFile.SetBelong(this.instance);
				}
				return r_m_SourceFontFile;
			}
		}

		/// <summary>
		/// System.String m_SourceFontFilePath
		/// </summary>
		protected RField r_m_SourceFontFilePath;
		public virtual RField Rm_SourceFontFilePath
		{
			get
			{
				if(r_m_SourceFontFilePath == null)
				{
					r_m_SourceFontFilePath = new(this, "m_SourceFontFilePath");
					r_m_SourceFontFilePath.SetBelong(this.instance);
				}
				return r_m_SourceFontFilePath;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.AtlasPopulationMode m_AtlasPopulationMode
		/// </summary>
		protected RField r_m_AtlasPopulationMode;
		public virtual RField Rm_AtlasPopulationMode
		{
			get
			{
				if(r_m_AtlasPopulationMode == null)
				{
					r_m_AtlasPopulationMode = new(this, "m_AtlasPopulationMode");
					r_m_AtlasPopulationMode.SetBelong(this.instance);
				}
				return r_m_AtlasPopulationMode;
			}
		}

		/// <summary>
		/// System.Boolean InternalDynamicOS
		/// </summary>
		protected RField r_InternalDynamicOS;
		public virtual RField RInternalDynamicOS
		{
			get
			{
				if(r_InternalDynamicOS == null)
				{
					r_InternalDynamicOS = new(this, "InternalDynamicOS");
					r_InternalDynamicOS.SetBelong(this.instance);
				}
				return r_InternalDynamicOS;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.FaceInfo m_FaceInfo
		/// </summary>
		protected RUnityEngine.RTextCore.RFaceInfo r_m_FaceInfo;
		public virtual RUnityEngine.RTextCore.RFaceInfo Rm_FaceInfo
		{
			get
			{
				if(r_m_FaceInfo == null)
				{
					r_m_FaceInfo = new(this, "m_FaceInfo");
					r_m_FaceInfo.SetBelong(this.instance);
				}
				return r_m_FaceInfo;
			}
		}

		/// <summary>
		/// System.Int32 m_FamilyNameHashCode
		/// </summary>
		protected RField r_m_FamilyNameHashCode;
		public virtual RField Rm_FamilyNameHashCode
		{
			get
			{
				if(r_m_FamilyNameHashCode == null)
				{
					r_m_FamilyNameHashCode = new(this, "m_FamilyNameHashCode");
					r_m_FamilyNameHashCode.SetBelong(this.instance);
				}
				return r_m_FamilyNameHashCode;
			}
		}

		/// <summary>
		/// System.Int32 m_StyleNameHashCode
		/// </summary>
		protected RField r_m_StyleNameHashCode;
		public virtual RField Rm_StyleNameHashCode
		{
			get
			{
				if(r_m_StyleNameHashCode == null)
				{
					r_m_StyleNameHashCode = new(this, "m_StyleNameHashCode");
					r_m_StyleNameHashCode.SetBelong(this.instance);
				}
				return r_m_StyleNameHashCode;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Glyph] m_GlyphTable
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyph> r_m_GlyphTable;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyph> Rm_GlyphTable
		{
			get
			{
				if(r_m_GlyphTable == null)
				{
					r_m_GlyphTable = new(this, "m_GlyphTable");
					r_m_GlyphTable.SetBelong(this.instance);
				}
				return r_m_GlyphTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.Glyph] m_GlyphLookupDictionary
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RTextCore.RGlyph> r_m_GlyphLookupDictionary;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RTextCore.RGlyph> Rm_GlyphLookupDictionary
		{
			get
			{
				if(r_m_GlyphLookupDictionary == null)
				{
					r_m_GlyphLookupDictionary = new(this, "m_GlyphLookupDictionary");
					r_m_GlyphLookupDictionary.SetBelong(this.instance);
				}
				return r_m_GlyphLookupDictionary;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.Character] m_CharacterTable
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RCharacter> r_m_CharacterTable;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RCharacter> Rm_CharacterTable
		{
			get
			{
				if(r_m_CharacterTable == null)
				{
					r_m_CharacterTable = new(this, "m_CharacterTable");
					r_m_CharacterTable.SetBelong(this.instance);
				}
				return r_m_CharacterTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.Text.Character] m_CharacterLookupDictionary
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RTextCore.RText.RCharacter> r_m_CharacterLookupDictionary;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RTextCore.RText.RCharacter> Rm_CharacterLookupDictionary
		{
			get
			{
				if(r_m_CharacterLookupDictionary == null)
				{
					r_m_CharacterLookupDictionary = new(this, "m_CharacterLookupDictionary");
					r_m_CharacterLookupDictionary.SetBelong(this.instance);
				}
				return r_m_CharacterLookupDictionary;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D m_AtlasTexture
		/// </summary>
		protected RUnityEngine.RTexture2D r_m_AtlasTexture;
		public virtual RUnityEngine.RTexture2D Rm_AtlasTexture
		{
			get
			{
				if(r_m_AtlasTexture == null)
				{
					r_m_AtlasTexture = new(this, "m_AtlasTexture");
					r_m_AtlasTexture.SetBelong(this.instance);
				}
				return r_m_AtlasTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D[] m_AtlasTextures
		/// </summary>
		protected RFieldArray<RUnityEngine.RTexture2D> r_m_AtlasTextures;
		public virtual RFieldArray<RUnityEngine.RTexture2D> Rm_AtlasTextures
		{
			get
			{
				if(r_m_AtlasTextures == null)
				{
					r_m_AtlasTextures = new(this, "m_AtlasTextures");
					r_m_AtlasTextures.SetBelong(this.instance);
				}
				return r_m_AtlasTextures;
			}
		}

		/// <summary>
		/// System.Int32 m_AtlasTextureIndex
		/// </summary>
		protected RField r_m_AtlasTextureIndex;
		public virtual RField Rm_AtlasTextureIndex
		{
			get
			{
				if(r_m_AtlasTextureIndex == null)
				{
					r_m_AtlasTextureIndex = new(this, "m_AtlasTextureIndex");
					r_m_AtlasTextureIndex.SetBelong(this.instance);
				}
				return r_m_AtlasTextureIndex;
			}
		}

		/// <summary>
		/// System.Boolean m_IsMultiAtlasTexturesEnabled
		/// </summary>
		protected RField r_m_IsMultiAtlasTexturesEnabled;
		public virtual RField Rm_IsMultiAtlasTexturesEnabled
		{
			get
			{
				if(r_m_IsMultiAtlasTexturesEnabled == null)
				{
					r_m_IsMultiAtlasTexturesEnabled = new(this, "m_IsMultiAtlasTexturesEnabled");
					r_m_IsMultiAtlasTexturesEnabled.SetBelong(this.instance);
				}
				return r_m_IsMultiAtlasTexturesEnabled;
			}
		}

		/// <summary>
		/// System.Boolean m_ClearDynamicDataOnBuild
		/// </summary>
		protected RField r_m_ClearDynamicDataOnBuild;
		public virtual RField Rm_ClearDynamicDataOnBuild
		{
			get
			{
				if(r_m_ClearDynamicDataOnBuild == null)
				{
					r_m_ClearDynamicDataOnBuild = new(this, "m_ClearDynamicDataOnBuild");
					r_m_ClearDynamicDataOnBuild.SetBelong(this.instance);
				}
				return r_m_ClearDynamicDataOnBuild;
			}
		}

		/// <summary>
		/// System.Int32 m_AtlasWidth
		/// </summary>
		protected RField r_m_AtlasWidth;
		public virtual RField Rm_AtlasWidth
		{
			get
			{
				if(r_m_AtlasWidth == null)
				{
					r_m_AtlasWidth = new(this, "m_AtlasWidth");
					r_m_AtlasWidth.SetBelong(this.instance);
				}
				return r_m_AtlasWidth;
			}
		}

		/// <summary>
		/// System.Int32 m_AtlasHeight
		/// </summary>
		protected RField r_m_AtlasHeight;
		public virtual RField Rm_AtlasHeight
		{
			get
			{
				if(r_m_AtlasHeight == null)
				{
					r_m_AtlasHeight = new(this, "m_AtlasHeight");
					r_m_AtlasHeight.SetBelong(this.instance);
				}
				return r_m_AtlasHeight;
			}
		}

		/// <summary>
		/// System.Int32 m_AtlasPadding
		/// </summary>
		protected RField r_m_AtlasPadding;
		public virtual RField Rm_AtlasPadding
		{
			get
			{
				if(r_m_AtlasPadding == null)
				{
					r_m_AtlasPadding = new(this, "m_AtlasPadding");
					r_m_AtlasPadding.SetBelong(this.instance);
				}
				return r_m_AtlasPadding;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphRenderMode m_AtlasRenderMode
		/// </summary>
		protected RField r_m_AtlasRenderMode;
		public virtual RField Rm_AtlasRenderMode
		{
			get
			{
				if(r_m_AtlasRenderMode == null)
				{
					r_m_AtlasRenderMode = new(this, "m_AtlasRenderMode");
					r_m_AtlasRenderMode.SetBelong(this.instance);
				}
				return r_m_AtlasRenderMode;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.GlyphRect] m_UsedGlyphRects
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyphRect> r_m_UsedGlyphRects;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyphRect> Rm_UsedGlyphRects
		{
			get
			{
				if(r_m_UsedGlyphRects == null)
				{
					r_m_UsedGlyphRects = new(this, "m_UsedGlyphRects");
					r_m_UsedGlyphRects.SetBelong(this.instance);
				}
				return r_m_UsedGlyphRects;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.GlyphRect] m_FreeGlyphRects
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyphRect> r_m_FreeGlyphRects;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyphRect> Rm_FreeGlyphRects
		{
			get
			{
				if(r_m_FreeGlyphRects == null)
				{
					r_m_FreeGlyphRects = new(this, "m_FreeGlyphRects");
					r_m_FreeGlyphRects.SetBelong(this.instance);
				}
				return r_m_FreeGlyphRects;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontFeatureTable m_FontFeatureTable
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RFontFeatureTable r_m_FontFeatureTable;
		public virtual RUnityEngine.RTextCore.RText.RFontFeatureTable Rm_FontFeatureTable
		{
			get
			{
				if(r_m_FontFeatureTable == null)
				{
					r_m_FontFeatureTable = new(this, "m_FontFeatureTable");
					r_m_FontFeatureTable.SetBelong(this.instance);
				}
				return r_m_FontFeatureTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.FontAsset] m_FallbackFontAssetTable
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RFontAsset> r_m_FallbackFontAssetTable;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RFontAsset> Rm_FallbackFontAssetTable
		{
			get
			{
				if(r_m_FallbackFontAssetTable == null)
				{
					r_m_FallbackFontAssetTable = new(this, "m_FallbackFontAssetTable");
					r_m_FallbackFontAssetTable.SetBelong(this.instance);
				}
				return r_m_FallbackFontAssetTable;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RFontAssetCreationEditorSettings r_m_fontAssetCreationEditorSettings;
		public virtual RUnityEngine.RTextCore.RText.RFontAssetCreationEditorSettings Rm_fontAssetCreationEditorSettings
		{
			get
			{
				if(r_m_fontAssetCreationEditorSettings == null)
				{
					r_m_fontAssetCreationEditorSettings = new(this, "m_fontAssetCreationEditorSettings");
					r_m_fontAssetCreationEditorSettings.SetBelong(this.instance);
				}
				return r_m_fontAssetCreationEditorSettings;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontWeightPair[] m_FontWeightTable
		/// </summary>
		protected RFieldArray<RUnityEngine.RTextCore.RText.RFontWeightPair> r_m_FontWeightTable;
		public virtual RFieldArray<RUnityEngine.RTextCore.RText.RFontWeightPair> Rm_FontWeightTable
		{
			get
			{
				if(r_m_FontWeightTable == null)
				{
					r_m_FontWeightTable = new(this, "m_FontWeightTable");
					r_m_FontWeightTable.SetBelong(this.instance);
				}
				return r_m_FontWeightTable;
			}
		}

		/// <summary>
		/// System.Single m_RegularStyleWeight
		/// </summary>
		protected RField r_m_RegularStyleWeight;
		public virtual RField Rm_RegularStyleWeight
		{
			get
			{
				if(r_m_RegularStyleWeight == null)
				{
					r_m_RegularStyleWeight = new(this, "m_RegularStyleWeight");
					r_m_RegularStyleWeight.SetBelong(this.instance);
				}
				return r_m_RegularStyleWeight;
			}
		}

		/// <summary>
		/// System.Single m_RegularStyleSpacing
		/// </summary>
		protected RField r_m_RegularStyleSpacing;
		public virtual RField Rm_RegularStyleSpacing
		{
			get
			{
				if(r_m_RegularStyleSpacing == null)
				{
					r_m_RegularStyleSpacing = new(this, "m_RegularStyleSpacing");
					r_m_RegularStyleSpacing.SetBelong(this.instance);
				}
				return r_m_RegularStyleSpacing;
			}
		}

		/// <summary>
		/// System.Single m_BoldStyleWeight
		/// </summary>
		protected RField r_m_BoldStyleWeight;
		public virtual RField Rm_BoldStyleWeight
		{
			get
			{
				if(r_m_BoldStyleWeight == null)
				{
					r_m_BoldStyleWeight = new(this, "m_BoldStyleWeight");
					r_m_BoldStyleWeight.SetBelong(this.instance);
				}
				return r_m_BoldStyleWeight;
			}
		}

		/// <summary>
		/// System.Single m_BoldStyleSpacing
		/// </summary>
		protected RField r_m_BoldStyleSpacing;
		public virtual RField Rm_BoldStyleSpacing
		{
			get
			{
				if(r_m_BoldStyleSpacing == null)
				{
					r_m_BoldStyleSpacing = new(this, "m_BoldStyleSpacing");
					r_m_BoldStyleSpacing.SetBelong(this.instance);
				}
				return r_m_BoldStyleSpacing;
			}
		}

		/// <summary>
		/// System.Byte m_ItalicStyleSlant
		/// </summary>
		protected RField r_m_ItalicStyleSlant;
		public virtual RField Rm_ItalicStyleSlant
		{
			get
			{
				if(r_m_ItalicStyleSlant == null)
				{
					r_m_ItalicStyleSlant = new(this, "m_ItalicStyleSlant");
					r_m_ItalicStyleSlant.SetBelong(this.instance);
				}
				return r_m_ItalicStyleSlant;
			}
		}

		/// <summary>
		/// System.Byte m_TabMultiple
		/// </summary>
		protected RField r_m_TabMultiple;
		public virtual RField Rm_TabMultiple
		{
			get
			{
				if(r_m_TabMultiple == null)
				{
					r_m_TabMultiple = new(this, "m_TabMultiple");
					r_m_TabMultiple.SetBelong(this.instance);
				}
				return r_m_TabMultiple;
			}
		}

		/// <summary>
		/// System.Boolean IsFontAssetLookupTablesDirty
		/// </summary>
		protected RField r_IsFontAssetLookupTablesDirty;
		public virtual RField RIsFontAssetLookupTablesDirty
		{
			get
			{
				if(r_IsFontAssetLookupTablesDirty == null)
				{
					r_IsFontAssetLookupTablesDirty = new(this, "IsFontAssetLookupTablesDirty");
					r_IsFontAssetLookupTablesDirty.SetBelong(this.instance);
				}
				return r_IsFontAssetLookupTablesDirty;
			}
		}

		/// <summary>
		/// System.Action`2[UnityEngine.Texture,UnityEngine.TextCore.Text.FontAsset] OnFontAssetTextureChanged
		/// </summary>
		protected static RSystem.RAction<RUnityEngine.RTexture, RUnityEngine.RTextCore.RText.RFontAsset> r_OnFontAssetTextureChanged;
		public static RSystem.RAction<RUnityEngine.RTexture, RUnityEngine.RTextCore.RText.RFontAsset> ROnFontAssetTextureChanged
		{
			get
			{
				if(r_OnFontAssetTextureChanged == null)
				{
					r_OnFontAssetTextureChanged = new(typeof(UnityEngine.TextCore.Text.FontAsset), "OnFontAssetTextureChanged");
					r_OnFontAssetTextureChanged.SetBelong(null);
				}
				return r_OnFontAssetTextureChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.TextCore.Text.FontAsset] RegisterResourceForUpdate
		/// </summary>
		protected static RSystem.RAction<RUnityEngine.RTextCore.RText.RFontAsset> r_RegisterResourceForUpdate;
		public static RSystem.RAction<RUnityEngine.RTextCore.RText.RFontAsset> RegisterResourceForUpdate
		{
			get
			{
				if(r_RegisterResourceForUpdate == null)
				{
					r_RegisterResourceForUpdate = new(typeof(UnityEngine.TextCore.Text.FontAsset), "RegisterResourceForUpdate");
					r_RegisterResourceForUpdate.SetBelong(null);
				}
				return r_RegisterResourceForUpdate;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.TextCore.Text.FontAsset] RegisterResourceForReimport
		/// </summary>
		protected static RSystem.RAction<RUnityEngine.RTextCore.RText.RFontAsset> r_RegisterResourceForReimport;
		public static RSystem.RAction<RUnityEngine.RTextCore.RText.RFontAsset> RegisterResourceForReimport
		{
			get
			{
				if(r_RegisterResourceForReimport == null)
				{
					r_RegisterResourceForReimport = new(typeof(UnityEngine.TextCore.Text.FontAsset), "RegisterResourceForReimport");
					r_RegisterResourceForReimport.SetBelong(null);
				}
				return r_RegisterResourceForReimport;
			}
		}

		/// <summary>
		/// System.Action`2[UnityEngine.Texture2D,System.Boolean] SetAtlasTextureIsReadable
		/// </summary>
		protected static RSystem.RAction<RUnityEngine.RTexture2D, RField> r_SetAtlasTextureIsReadable;
		public static RSystem.RAction<RUnityEngine.RTexture2D, RField> RSetAtlasTextureIsReadable
		{
			get
			{
				if(r_SetAtlasTextureIsReadable == null)
				{
					r_SetAtlasTextureIsReadable = new(typeof(UnityEngine.TextCore.Text.FontAsset), "SetAtlasTextureIsReadable");
					r_SetAtlasTextureIsReadable.SetBelong(null);
				}
				return r_SetAtlasTextureIsReadable;
			}
		}

		/// <summary>
		/// System.Func`2[System.String,UnityEngine.Font] GetSourceFontRef
		/// </summary>
		protected static RSystem.RFunc<RField, RUnityEngine.RFont> r_GetSourceFontRef;
		public static RSystem.RFunc<RField, RUnityEngine.RFont> RGetSourceFontRef
		{
			get
			{
				if(r_GetSourceFontRef == null)
				{
					r_GetSourceFontRef = new(typeof(UnityEngine.TextCore.Text.FontAsset), "GetSourceFontRef");
					r_GetSourceFontRef.SetBelong(null);
				}
				return r_GetSourceFontRef;
			}
		}

		/// <summary>
		/// System.Func`2[UnityEngine.Font,System.String] SetSourceFontGUID
		/// </summary>
		protected static RSystem.RFunc<RUnityEngine.RFont, RField> r_SetSourceFontGUID;
		public static RSystem.RFunc<RUnityEngine.RFont, RField> RSetSourceFontGUID
		{
			get
			{
				if(r_SetSourceFontGUID == null)
				{
					r_SetSourceFontGUID = new(typeof(UnityEngine.TextCore.Text.FontAsset), "SetSourceFontGUID");
					r_SetSourceFontGUID.SetBelong(null);
				}
				return r_SetSourceFontGUID;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_ReadFontAssetDefinitionMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_k_ReadFontAssetDefinitionMarker;
		public static RUnity.RProfiling.RProfilerMarker Rk_ReadFontAssetDefinitionMarker
		{
			get
			{
				if(r_k_ReadFontAssetDefinitionMarker == null)
				{
					r_k_ReadFontAssetDefinitionMarker = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_ReadFontAssetDefinitionMarker");
					r_k_ReadFontAssetDefinitionMarker.SetBelong(null);
				}
				return r_k_ReadFontAssetDefinitionMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_AddSynthesizedCharactersMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_k_AddSynthesizedCharactersMarker;
		public static RUnity.RProfiling.RProfilerMarker Rk_AddSynthesizedCharactersMarker
		{
			get
			{
				if(r_k_AddSynthesizedCharactersMarker == null)
				{
					r_k_AddSynthesizedCharactersMarker = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_AddSynthesizedCharactersMarker");
					r_k_AddSynthesizedCharactersMarker.SetBelong(null);
				}
				return r_k_AddSynthesizedCharactersMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_TryAddCharacterMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_k_TryAddCharacterMarker;
		public static RUnity.RProfiling.RProfilerMarker Rk_TryAddCharacterMarker
		{
			get
			{
				if(r_k_TryAddCharacterMarker == null)
				{
					r_k_TryAddCharacterMarker = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_TryAddCharacterMarker");
					r_k_TryAddCharacterMarker.SetBelong(null);
				}
				return r_k_TryAddCharacterMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_TryAddCharactersMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_k_TryAddCharactersMarker;
		public static RUnity.RProfiling.RProfilerMarker Rk_TryAddCharactersMarker
		{
			get
			{
				if(r_k_TryAddCharactersMarker == null)
				{
					r_k_TryAddCharactersMarker = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_TryAddCharactersMarker");
					r_k_TryAddCharactersMarker.SetBelong(null);
				}
				return r_k_TryAddCharactersMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_k_UpdateGlyphAdjustmentRecordsMarker;
		public static RUnity.RProfiling.RProfilerMarker Rk_UpdateGlyphAdjustmentRecordsMarker
		{
			get
			{
				if(r_k_UpdateGlyphAdjustmentRecordsMarker == null)
				{
					r_k_UpdateGlyphAdjustmentRecordsMarker = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_UpdateGlyphAdjustmentRecordsMarker");
					r_k_UpdateGlyphAdjustmentRecordsMarker.SetBelong(null);
				}
				return r_k_UpdateGlyphAdjustmentRecordsMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_k_UpdateDiacriticalMarkAdjustmentRecordsMarker;
		public static RUnity.RProfiling.RProfilerMarker Rk_UpdateDiacriticalMarkAdjustmentRecordsMarker
		{
			get
			{
				if(r_k_UpdateDiacriticalMarkAdjustmentRecordsMarker == null)
				{
					r_k_UpdateDiacriticalMarkAdjustmentRecordsMarker = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_UpdateDiacriticalMarkAdjustmentRecordsMarker");
					r_k_UpdateDiacriticalMarkAdjustmentRecordsMarker.SetBelong(null);
				}
				return r_k_UpdateDiacriticalMarkAdjustmentRecordsMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_ClearFontAssetDataMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_k_ClearFontAssetDataMarker;
		public static RUnity.RProfiling.RProfilerMarker Rk_ClearFontAssetDataMarker
		{
			get
			{
				if(r_k_ClearFontAssetDataMarker == null)
				{
					r_k_ClearFontAssetDataMarker = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_ClearFontAssetDataMarker");
					r_k_ClearFontAssetDataMarker.SetBelong(null);
				}
				return r_k_ClearFontAssetDataMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_UpdateFontAssetDataMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_k_UpdateFontAssetDataMarker;
		public static RUnity.RProfiling.RProfilerMarker Rk_UpdateFontAssetDataMarker
		{
			get
			{
				if(r_k_UpdateFontAssetDataMarker == null)
				{
					r_k_UpdateFontAssetDataMarker = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_UpdateFontAssetDataMarker");
					r_k_UpdateFontAssetDataMarker.SetBelong(null);
				}
				return r_k_UpdateFontAssetDataMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_TryAddGlyphMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_k_TryAddGlyphMarker;
		public static RUnity.RProfiling.RProfilerMarker Rk_TryAddGlyphMarker
		{
			get
			{
				if(r_k_TryAddGlyphMarker == null)
				{
					r_k_TryAddGlyphMarker = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_TryAddGlyphMarker");
					r_k_TryAddGlyphMarker.SetBelong(null);
				}
				return r_k_TryAddGlyphMarker;
			}
		}

		/// <summary>
		/// System.String s_DefaultMaterialSuffix
		/// </summary>
		protected static RField r_s_DefaultMaterialSuffix;
		public static RField Rs_DefaultMaterialSuffix
		{
			get
			{
				if(r_s_DefaultMaterialSuffix == null)
				{
					r_s_DefaultMaterialSuffix = new(typeof(UnityEngine.TextCore.Text.FontAsset), "s_DefaultMaterialSuffix");
					r_s_DefaultMaterialSuffix.SetBelong(null);
				}
				return r_s_DefaultMaterialSuffix;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.Int32] k_SearchedFontAssetLookup
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RHashSet<RField> r_k_SearchedFontAssetLookup;
		public static RSystem.RCollections.RGeneric.RHashSet<RField> Rk_SearchedFontAssetLookup
		{
			get
			{
				if(r_k_SearchedFontAssetLookup == null)
				{
					r_k_SearchedFontAssetLookup = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_SearchedFontAssetLookup");
					r_k_SearchedFontAssetLookup.SetBelong(null);
				}
				return r_k_SearchedFontAssetLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.FontAsset] k_FontAssets_FontFeaturesUpdateQueue
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RFontAsset> r_k_FontAssets_FontFeaturesUpdateQueue;
		public static RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RFontAsset> Rk_FontAssets_FontFeaturesUpdateQueue
		{
			get
			{
				if(r_k_FontAssets_FontFeaturesUpdateQueue == null)
				{
					r_k_FontAssets_FontFeaturesUpdateQueue = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_FontAssets_FontFeaturesUpdateQueue");
					r_k_FontAssets_FontFeaturesUpdateQueue.SetBelong(null);
				}
				return r_k_FontAssets_FontFeaturesUpdateQueue;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.Int32] k_FontAssets_FontFeaturesUpdateQueueLookup
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RHashSet<RField> r_k_FontAssets_FontFeaturesUpdateQueueLookup;
		public static RSystem.RCollections.RGeneric.RHashSet<RField> Rk_FontAssets_FontFeaturesUpdateQueueLookup
		{
			get
			{
				if(r_k_FontAssets_FontFeaturesUpdateQueueLookup == null)
				{
					r_k_FontAssets_FontFeaturesUpdateQueueLookup = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_FontAssets_FontFeaturesUpdateQueueLookup");
					r_k_FontAssets_FontFeaturesUpdateQueueLookup.SetBelong(null);
				}
				return r_k_FontAssets_FontFeaturesUpdateQueueLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Texture2D] k_FontAssets_AtlasTexturesUpdateQueue
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RList<RUnityEngine.RTexture2D> r_k_FontAssets_AtlasTexturesUpdateQueue;
		public static RSystem.RCollections.RGeneric.RList<RUnityEngine.RTexture2D> Rk_FontAssets_AtlasTexturesUpdateQueue
		{
			get
			{
				if(r_k_FontAssets_AtlasTexturesUpdateQueue == null)
				{
					r_k_FontAssets_AtlasTexturesUpdateQueue = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_FontAssets_AtlasTexturesUpdateQueue");
					r_k_FontAssets_AtlasTexturesUpdateQueue.SetBelong(null);
				}
				return r_k_FontAssets_AtlasTexturesUpdateQueue;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.Int32] k_FontAssets_AtlasTexturesUpdateQueueLookup
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RHashSet<RField> r_k_FontAssets_AtlasTexturesUpdateQueueLookup;
		public static RSystem.RCollections.RGeneric.RHashSet<RField> Rk_FontAssets_AtlasTexturesUpdateQueueLookup
		{
			get
			{
				if(r_k_FontAssets_AtlasTexturesUpdateQueueLookup == null)
				{
					r_k_FontAssets_AtlasTexturesUpdateQueueLookup = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_FontAssets_AtlasTexturesUpdateQueueLookup");
					r_k_FontAssets_AtlasTexturesUpdateQueueLookup.SetBelong(null);
				}
				return r_k_FontAssets_AtlasTexturesUpdateQueueLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Glyph] m_GlyphsToRender
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyph> r_m_GlyphsToRender;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyph> Rm_GlyphsToRender
		{
			get
			{
				if(r_m_GlyphsToRender == null)
				{
					r_m_GlyphsToRender = new(this, "m_GlyphsToRender");
					r_m_GlyphsToRender.SetBelong(this.instance);
				}
				return r_m_GlyphsToRender;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Glyph] m_GlyphsRendered
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyph> r_m_GlyphsRendered;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyph> Rm_GlyphsRendered
		{
			get
			{
				if(r_m_GlyphsRendered == null)
				{
					r_m_GlyphsRendered = new(this, "m_GlyphsRendered");
					r_m_GlyphsRendered.SetBelong(this.instance);
				}
				return r_m_GlyphsRendered;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.UInt32] m_GlyphIndexList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_GlyphIndexList;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_GlyphIndexList
		{
			get
			{
				if(r_m_GlyphIndexList == null)
				{
					r_m_GlyphIndexList = new(this, "m_GlyphIndexList");
					r_m_GlyphIndexList.SetBelong(this.instance);
				}
				return r_m_GlyphIndexList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.UInt32] m_GlyphIndexListNewlyAdded
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_GlyphIndexListNewlyAdded;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_GlyphIndexListNewlyAdded
		{
			get
			{
				if(r_m_GlyphIndexListNewlyAdded == null)
				{
					r_m_GlyphIndexListNewlyAdded = new(this, "m_GlyphIndexListNewlyAdded");
					r_m_GlyphIndexListNewlyAdded.SetBelong(this.instance);
				}
				return r_m_GlyphIndexListNewlyAdded;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.UInt32] m_GlyphsToAdd
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_GlyphsToAdd;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_GlyphsToAdd
		{
			get
			{
				if(r_m_GlyphsToAdd == null)
				{
					r_m_GlyphsToAdd = new(this, "m_GlyphsToAdd");
					r_m_GlyphsToAdd.SetBelong(this.instance);
				}
				return r_m_GlyphsToAdd;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.UInt32] m_GlyphsToAddLookup
		/// </summary>
		protected RSystem.RCollections.RGeneric.RHashSet<RField> r_m_GlyphsToAddLookup;
		public virtual RSystem.RCollections.RGeneric.RHashSet<RField> Rm_GlyphsToAddLookup
		{
			get
			{
				if(r_m_GlyphsToAddLookup == null)
				{
					r_m_GlyphsToAddLookup = new(this, "m_GlyphsToAddLookup");
					r_m_GlyphsToAddLookup.SetBelong(this.instance);
				}
				return r_m_GlyphsToAddLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.Character] m_CharactersToAdd
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RCharacter> r_m_CharactersToAdd;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RCharacter> Rm_CharactersToAdd
		{
			get
			{
				if(r_m_CharactersToAdd == null)
				{
					r_m_CharactersToAdd = new(this, "m_CharactersToAdd");
					r_m_CharactersToAdd.SetBelong(this.instance);
				}
				return r_m_CharactersToAdd;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.UInt32] m_CharactersToAddLookup
		/// </summary>
		protected RSystem.RCollections.RGeneric.RHashSet<RField> r_m_CharactersToAddLookup;
		public virtual RSystem.RCollections.RGeneric.RHashSet<RField> Rm_CharactersToAddLookup
		{
			get
			{
				if(r_m_CharactersToAddLookup == null)
				{
					r_m_CharactersToAddLookup = new(this, "m_CharactersToAddLookup");
					r_m_CharactersToAddLookup.SetBelong(this.instance);
				}
				return r_m_CharactersToAddLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.UInt32] s_MissingCharacterList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_s_MissingCharacterList;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rs_MissingCharacterList
		{
			get
			{
				if(r_s_MissingCharacterList == null)
				{
					r_s_MissingCharacterList = new(this, "s_MissingCharacterList");
					r_s_MissingCharacterList.SetBelong(this.instance);
				}
				return r_s_MissingCharacterList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.UInt32] m_MissingUnicodesFromFontFile
		/// </summary>
		protected RSystem.RCollections.RGeneric.RHashSet<RField> r_m_MissingUnicodesFromFontFile;
		public virtual RSystem.RCollections.RGeneric.RHashSet<RField> Rm_MissingUnicodesFromFontFile
		{
			get
			{
				if(r_m_MissingUnicodesFromFontFile == null)
				{
					r_m_MissingUnicodesFromFontFile = new(this, "m_MissingUnicodesFromFontFile");
					r_m_MissingUnicodesFromFontFile.SetBelong(this.instance);
				}
				return r_m_MissingUnicodesFromFontFile;
			}
		}

		/// <summary>
		/// System.UInt32[] k_GlyphIndexArray
		/// </summary>
		protected static RFieldArray<RField> r_k_GlyphIndexArray;
		public static RFieldArray<RField> Rk_GlyphIndexArray
		{
			get
			{
				if(r_k_GlyphIndexArray == null)
				{
					r_k_GlyphIndexArray = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_GlyphIndexArray");
					r_k_GlyphIndexArray.SetBelong(null);
				}
				return r_k_GlyphIndexArray;
			}
		}

		/// <summary>
		/// System.String m_Version
		/// </summary>
		protected RField r_m_Version;
		public virtual RField Rm_Version
		{
			get
			{
				if(r_m_Version == null)
				{
					r_m_Version = new(this, "m_Version");
					r_m_Version.SetBelong(this.instance);
				}
				return r_m_Version;
			}
		}

		/// <summary>
		/// System.Int32 m_InstanceID
		/// </summary>
		protected RField r_m_InstanceID;
		public virtual RField Rm_InstanceID
		{
			get
			{
				if(r_m_InstanceID == null)
				{
					r_m_InstanceID = new(this, "m_InstanceID");
					r_m_InstanceID.SetBelong(this.instance);
				}
				return r_m_InstanceID;
			}
		}

		/// <summary>
		/// System.Int32 m_HashCode
		/// </summary>
		protected RField r_m_HashCode;
		public virtual RField Rm_HashCode
		{
			get
			{
				if(r_m_HashCode == null)
				{
					r_m_HashCode = new(this, "m_HashCode");
					r_m_HashCode.SetBelong(this.instance);
				}
				return r_m_HashCode;
			}
		}

		/// <summary>
		/// UnityEngine.Material m_Material
		/// </summary>
		protected RUnityEngine.RMaterial r_m_Material;
		public virtual RUnityEngine.RMaterial Rm_Material
		{
			get
			{
				if(r_m_Material == null)
				{
					r_m_Material = new(this, "m_Material");
					r_m_Material.SetBelong(this.instance);
				}
				return r_m_Material;
			}
		}

		/// <summary>
		/// System.Int32 m_MaterialHashCode
		/// </summary>
		protected RField r_m_MaterialHashCode;
		public virtual RField Rm_MaterialHashCode
		{
			get
			{
				if(r_m_MaterialHashCode == null)
				{
					r_m_MaterialHashCode = new(this, "m_MaterialHashCode");
					r_m_MaterialHashCode.SetBelong(this.instance);
				}
				return r_m_MaterialHashCode;
			}
		}

		/// <summary>
		/// UnityEngine.Font SourceFont_EditorRef
		/// </summary>
		protected RUnityEngine.RFont r_SourceFont_EditorRef;
		public virtual RUnityEngine.RFont RSourceFont_EditorRef
		{
			get
			{
				if(r_SourceFont_EditorRef == null)
				{
					r_SourceFont_EditorRef = new(this, "SourceFont_EditorRef", -1);
					r_SourceFont_EditorRef.SetBelong(this.instance);
				}
				return r_SourceFont_EditorRef;
			}
		}

		/// <summary>
		/// UnityEngine.Font sourceFontFile
		/// </summary>
		protected RUnityEngine.RFont r_sourceFontFile;
		public virtual RUnityEngine.RFont RsourceFontFile
		{
			get
			{
				if(r_sourceFontFile == null)
				{
					r_sourceFontFile = new(this, "sourceFontFile", -1);
					r_sourceFontFile.SetBelong(this.instance);
				}
				return r_sourceFontFile;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode
		/// </summary>
		protected RProperty r_atlasPopulationMode;
		public virtual RProperty RatlasPopulationMode
		{
			get
			{
				if(r_atlasPopulationMode == null)
				{
					r_atlasPopulationMode = new(this, "atlasPopulationMode", -1);
					r_atlasPopulationMode.SetBelong(this.instance);
				}
				return r_atlasPopulationMode;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.FaceInfo faceInfo
		/// </summary>
		protected RUnityEngine.RTextCore.RFaceInfo r_faceInfo;
		public virtual RUnityEngine.RTextCore.RFaceInfo RfaceInfo
		{
			get
			{
				if(r_faceInfo == null)
				{
					r_faceInfo = new(this, "faceInfo", -1);
					r_faceInfo.SetBelong(this.instance);
				}
				return r_faceInfo;
			}
		}

		/// <summary>
		/// Int32 familyNameHashCode
		/// </summary>
		protected RProperty r_familyNameHashCode;
		public virtual RProperty RfamilyNameHashCode
		{
			get
			{
				if(r_familyNameHashCode == null)
				{
					r_familyNameHashCode = new(this, "familyNameHashCode", -1);
					r_familyNameHashCode.SetBelong(this.instance);
				}
				return r_familyNameHashCode;
			}
		}

		/// <summary>
		/// Int32 styleNameHashCode
		/// </summary>
		protected RProperty r_styleNameHashCode;
		public virtual RProperty RstyleNameHashCode
		{
			get
			{
				if(r_styleNameHashCode == null)
				{
					r_styleNameHashCode = new(this, "styleNameHashCode", -1);
					r_styleNameHashCode.SetBelong(this.instance);
				}
				return r_styleNameHashCode;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Glyph] glyphTable
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyph> r_glyphTable;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyph> RglyphTable
		{
			get
			{
				if(r_glyphTable == null)
				{
					r_glyphTable = new(this, "glyphTable", -1);
					r_glyphTable.SetBelong(this.instance);
				}
				return r_glyphTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.Glyph] glyphLookupTable
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RProperty, RUnityEngine.RTextCore.RGlyph> r_glyphLookupTable;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RProperty, RUnityEngine.RTextCore.RGlyph> RglyphLookupTable
		{
			get
			{
				if(r_glyphLookupTable == null)
				{
					r_glyphLookupTable = new(this, "glyphLookupTable", -1);
					r_glyphLookupTable.SetBelong(this.instance);
				}
				return r_glyphLookupTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.Character] characterTable
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RCharacter> r_characterTable;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RCharacter> RcharacterTable
		{
			get
			{
				if(r_characterTable == null)
				{
					r_characterTable = new(this, "characterTable", -1);
					r_characterTable.SetBelong(this.instance);
				}
				return r_characterTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.Text.Character] characterLookupTable
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RProperty, RUnityEngine.RTextCore.RText.RCharacter> r_characterLookupTable;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RProperty, RUnityEngine.RTextCore.RText.RCharacter> RcharacterLookupTable
		{
			get
			{
				if(r_characterLookupTable == null)
				{
					r_characterLookupTable = new(this, "characterLookupTable", -1);
					r_characterLookupTable.SetBelong(this.instance);
				}
				return r_characterLookupTable;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D atlasTexture
		/// </summary>
		protected RUnityEngine.RTexture2D r_atlasTexture;
		public virtual RUnityEngine.RTexture2D RatlasTexture
		{
			get
			{
				if(r_atlasTexture == null)
				{
					r_atlasTexture = new(this, "atlasTexture", -1);
					r_atlasTexture.SetBelong(this.instance);
				}
				return r_atlasTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D[] atlasTextures
		/// </summary>
		protected RPropertyArray<RUnityEngine.RTexture2D> r_atlasTextures;
		public virtual RPropertyArray<RUnityEngine.RTexture2D> RatlasTextures
		{
			get
			{
				if(r_atlasTextures == null)
				{
					r_atlasTextures = new(this, "atlasTextures", -1);
					r_atlasTextures.SetBelong(this.instance);
				}
				return r_atlasTextures;
			}
		}

		/// <summary>
		/// Int32 atlasTextureCount
		/// </summary>
		protected RProperty r_atlasTextureCount;
		public virtual RProperty RatlasTextureCount
		{
			get
			{
				if(r_atlasTextureCount == null)
				{
					r_atlasTextureCount = new(this, "atlasTextureCount", -1);
					r_atlasTextureCount.SetBelong(this.instance);
				}
				return r_atlasTextureCount;
			}
		}

		/// <summary>
		/// Boolean isMultiAtlasTexturesEnabled
		/// </summary>
		protected RProperty r_isMultiAtlasTexturesEnabled;
		public virtual RProperty RisMultiAtlasTexturesEnabled
		{
			get
			{
				if(r_isMultiAtlasTexturesEnabled == null)
				{
					r_isMultiAtlasTexturesEnabled = new(this, "isMultiAtlasTexturesEnabled", -1);
					r_isMultiAtlasTexturesEnabled.SetBelong(this.instance);
				}
				return r_isMultiAtlasTexturesEnabled;
			}
		}

		/// <summary>
		/// Boolean clearDynamicDataOnBuild
		/// </summary>
		protected RProperty r_clearDynamicDataOnBuild;
		public virtual RProperty RclearDynamicDataOnBuild
		{
			get
			{
				if(r_clearDynamicDataOnBuild == null)
				{
					r_clearDynamicDataOnBuild = new(this, "clearDynamicDataOnBuild", -1);
					r_clearDynamicDataOnBuild.SetBelong(this.instance);
				}
				return r_clearDynamicDataOnBuild;
			}
		}

		/// <summary>
		/// Int32 atlasWidth
		/// </summary>
		protected RProperty r_atlasWidth;
		public virtual RProperty RatlasWidth
		{
			get
			{
				if(r_atlasWidth == null)
				{
					r_atlasWidth = new(this, "atlasWidth", -1);
					r_atlasWidth.SetBelong(this.instance);
				}
				return r_atlasWidth;
			}
		}

		/// <summary>
		/// Int32 atlasHeight
		/// </summary>
		protected RProperty r_atlasHeight;
		public virtual RProperty RatlasHeight
		{
			get
			{
				if(r_atlasHeight == null)
				{
					r_atlasHeight = new(this, "atlasHeight", -1);
					r_atlasHeight.SetBelong(this.instance);
				}
				return r_atlasHeight;
			}
		}

		/// <summary>
		/// Int32 atlasPadding
		/// </summary>
		protected RProperty r_atlasPadding;
		public virtual RProperty RatlasPadding
		{
			get
			{
				if(r_atlasPadding == null)
				{
					r_atlasPadding = new(this, "atlasPadding", -1);
					r_atlasPadding.SetBelong(this.instance);
				}
				return r_atlasPadding;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphRenderMode atlasRenderMode
		/// </summary>
		protected RProperty r_atlasRenderMode;
		public virtual RProperty RatlasRenderMode
		{
			get
			{
				if(r_atlasRenderMode == null)
				{
					r_atlasRenderMode = new(this, "atlasRenderMode", -1);
					r_atlasRenderMode.SetBelong(this.instance);
				}
				return r_atlasRenderMode;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.GlyphRect] usedGlyphRects
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyphRect> r_usedGlyphRects;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyphRect> RusedGlyphRects
		{
			get
			{
				if(r_usedGlyphRects == null)
				{
					r_usedGlyphRects = new(this, "usedGlyphRects", -1);
					r_usedGlyphRects.SetBelong(this.instance);
				}
				return r_usedGlyphRects;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.GlyphRect] freeGlyphRects
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyphRect> r_freeGlyphRects;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyphRect> RfreeGlyphRects
		{
			get
			{
				if(r_freeGlyphRects == null)
				{
					r_freeGlyphRects = new(this, "freeGlyphRects", -1);
					r_freeGlyphRects.SetBelong(this.instance);
				}
				return r_freeGlyphRects;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontFeatureTable fontFeatureTable
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RFontFeatureTable r_fontFeatureTable;
		public virtual RUnityEngine.RTextCore.RText.RFontFeatureTable RfontFeatureTable
		{
			get
			{
				if(r_fontFeatureTable == null)
				{
					r_fontFeatureTable = new(this, "fontFeatureTable", -1);
					r_fontFeatureTable.SetBelong(this.instance);
				}
				return r_fontFeatureTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.FontAsset] fallbackFontAssetTable
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RFontAsset> r_fallbackFontAssetTable;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RFontAsset> RfallbackFontAssetTable
		{
			get
			{
				if(r_fallbackFontAssetTable == null)
				{
					r_fallbackFontAssetTable = new(this, "fallbackFontAssetTable", -1);
					r_fallbackFontAssetTable.SetBelong(this.instance);
				}
				return r_fallbackFontAssetTable;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAssetCreationEditorSettings fontAssetCreationEditorSettings
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RFontAssetCreationEditorSettings r_fontAssetCreationEditorSettings;
		public virtual RUnityEngine.RTextCore.RText.RFontAssetCreationEditorSettings RfontAssetCreationEditorSettings
		{
			get
			{
				if(r_fontAssetCreationEditorSettings == null)
				{
					r_fontAssetCreationEditorSettings = new(this, "fontAssetCreationEditorSettings", -1);
					r_fontAssetCreationEditorSettings.SetBelong(this.instance);
				}
				return r_fontAssetCreationEditorSettings;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontWeightPair[] fontWeightTable
		/// </summary>
		protected RPropertyArray<RUnityEngine.RTextCore.RText.RFontWeightPair> r_fontWeightTable;
		public virtual RPropertyArray<RUnityEngine.RTextCore.RText.RFontWeightPair> RfontWeightTable
		{
			get
			{
				if(r_fontWeightTable == null)
				{
					r_fontWeightTable = new(this, "fontWeightTable", -1);
					r_fontWeightTable.SetBelong(this.instance);
				}
				return r_fontWeightTable;
			}
		}

		/// <summary>
		/// Single regularStyleWeight
		/// </summary>
		protected RProperty r_regularStyleWeight;
		public virtual RProperty RregularStyleWeight
		{
			get
			{
				if(r_regularStyleWeight == null)
				{
					r_regularStyleWeight = new(this, "regularStyleWeight", -1);
					r_regularStyleWeight.SetBelong(this.instance);
				}
				return r_regularStyleWeight;
			}
		}

		/// <summary>
		/// Single regularStyleSpacing
		/// </summary>
		protected RProperty r_regularStyleSpacing;
		public virtual RProperty RregularStyleSpacing
		{
			get
			{
				if(r_regularStyleSpacing == null)
				{
					r_regularStyleSpacing = new(this, "regularStyleSpacing", -1);
					r_regularStyleSpacing.SetBelong(this.instance);
				}
				return r_regularStyleSpacing;
			}
		}

		/// <summary>
		/// Single boldStyleWeight
		/// </summary>
		protected RProperty r_boldStyleWeight;
		public virtual RProperty RboldStyleWeight
		{
			get
			{
				if(r_boldStyleWeight == null)
				{
					r_boldStyleWeight = new(this, "boldStyleWeight", -1);
					r_boldStyleWeight.SetBelong(this.instance);
				}
				return r_boldStyleWeight;
			}
		}

		/// <summary>
		/// Single boldStyleSpacing
		/// </summary>
		protected RProperty r_boldStyleSpacing;
		public virtual RProperty RboldStyleSpacing
		{
			get
			{
				if(r_boldStyleSpacing == null)
				{
					r_boldStyleSpacing = new(this, "boldStyleSpacing", -1);
					r_boldStyleSpacing.SetBelong(this.instance);
				}
				return r_boldStyleSpacing;
			}
		}

		/// <summary>
		/// Byte italicStyleSlant
		/// </summary>
		protected RProperty r_italicStyleSlant;
		public virtual RProperty RitalicStyleSlant
		{
			get
			{
				if(r_italicStyleSlant == null)
				{
					r_italicStyleSlant = new(this, "italicStyleSlant", -1);
					r_italicStyleSlant.SetBelong(this.instance);
				}
				return r_italicStyleSlant;
			}
		}

		/// <summary>
		/// Byte tabMultiple
		/// </summary>
		protected RProperty r_tabMultiple;
		public virtual RProperty RtabMultiple
		{
			get
			{
				if(r_tabMultiple == null)
				{
					r_tabMultiple = new(this, "tabMultiple", -1);
					r_tabMultiple.SetBelong(this.instance);
				}
				return r_tabMultiple;
			}
		}

		/// <summary>
		/// System.String version
		/// </summary>
		protected RProperty r_version;
		public virtual RProperty Rversion
		{
			get
			{
				if(r_version == null)
				{
					r_version = new(this, "version", -1);
					r_version.SetBelong(this.instance);
				}
				return r_version;
			}
		}

		/// <summary>
		/// Int32 instanceID
		/// </summary>
		protected RProperty r_instanceID;
		public virtual RProperty RinstanceID
		{
			get
			{
				if(r_instanceID == null)
				{
					r_instanceID = new(this, "instanceID", -1);
					r_instanceID.SetBelong(this.instance);
				}
				return r_instanceID;
			}
		}

		/// <summary>
		/// Int32 hashCode
		/// </summary>
		protected RProperty r_hashCode;
		public virtual RProperty RhashCode
		{
			get
			{
				if(r_hashCode == null)
				{
					r_hashCode = new(this, "hashCode", -1);
					r_hashCode.SetBelong(this.instance);
				}
				return r_hashCode;
			}
		}

		/// <summary>
		/// UnityEngine.Material material
		/// </summary>
		protected RUnityEngine.RMaterial r_material;
		public virtual RUnityEngine.RMaterial Rmaterial
		{
			get
			{
				if(r_material == null)
				{
					r_material = new(this, "material", -1);
					r_material.SetBelong(this.instance);
				}
				return r_material;
			}
		}

		/// <summary>
		/// Int32 materialHashCode
		/// </summary>
		protected RProperty r_materialHashCode;
		public virtual RProperty RmaterialHashCode
		{
			get
			{
				if(r_materialHashCode == null)
				{
					r_materialHashCode = new(this, "materialHashCode", -1);
					r_materialHashCode.SetBelong(this.instance);
				}
				return r_materialHashCode;
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
		/// UnityEngine.TextCore.Text.FontAsset CreateFontAsset(System.String, System.String, Int32)
		/// </summary>
		protected static RMethod r_RCreateFontAsset_String_String_Int32;
		public static RMethod RCreateFontAsset_String_String_Int32
		{
			get
			{
				if(r_RCreateFontAsset_String_String_Int32 == null)
				{
					r_RCreateFontAsset_String_String_Int32 = new(typeof(UnityEngine.TextCore.Text.FontAsset), "CreateFontAsset", 0, typeof(System.String), typeof(System.String), typeof(System.Int32));
					r_RCreateFontAsset_String_String_Int32.SetBelong(null);
				}
				return r_RCreateFontAsset_String_String_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAsset CreateFontAsset(System.String, Int32, Int32, Int32, UnityEngine.TextCore.LowLevel.GlyphRenderMode, Int32, Int32)
		/// </summary>
		protected static RMethod r_RCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32;
		public static RMethod RCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32
		{
			get
			{
				if(r_RCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32 == null)
				{
					r_RCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32 = new(typeof(UnityEngine.TextCore.Text.FontAsset), "CreateFontAsset", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), typeof(System.Int32), typeof(System.Int32));
					r_RCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32.SetBelong(null);
				}
				return r_RCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAsset CreateFontAsset(System.String, Int32, Int32, Int32, UnityEngine.TextCore.LowLevel.GlyphRenderMode, Int32, Int32, UnityEngine.TextCore.Text.AtlasPopulationMode, Boolean)
		/// </summary>
		protected static RMethod r_RCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean;
		public static RMethod RCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean
		{
			get
			{
				if(r_RCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean == null)
				{
					r_RCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean = new(typeof(UnityEngine.TextCore.Text.FontAsset), "CreateFontAsset", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextCore.Text.AtlasPopulationMode), typeof(System.Boolean));
					r_RCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean.SetBelong(null);
				}
				return r_RCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font)
		/// </summary>
		protected static RMethod r_RCreateFontAsset_Font;
		public static RMethod RCreateFontAsset_Font
		{
			get
			{
				if(r_RCreateFontAsset_Font == null)
				{
					r_RCreateFontAsset_Font = new(typeof(UnityEngine.TextCore.Text.FontAsset), "CreateFontAsset", 0, typeof(UnityEngine.Font));
					r_RCreateFontAsset_Font.SetBelong(null);
				}
				return r_RCreateFontAsset_Font;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font, Int32, Int32, UnityEngine.TextCore.LowLevel.GlyphRenderMode, Int32, Int32, UnityEngine.TextCore.Text.AtlasPopulationMode, Boolean)
		/// </summary>
		protected static RMethod r_RCreateFontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean;
		public static RMethod RCreateFontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean
		{
			get
			{
				if(r_RCreateFontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean == null)
				{
					r_RCreateFontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean = new(typeof(UnityEngine.TextCore.Text.FontAsset), "CreateFontAsset", 0, typeof(UnityEngine.Font), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextCore.Text.AtlasPopulationMode), typeof(System.Boolean));
					r_RCreateFontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean.SetBelong(null);
				}
				return r_RCreateFontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font, Int32, Int32, Int32, UnityEngine.TextCore.LowLevel.GlyphRenderMode, Int32, Int32, UnityEngine.TextCore.Text.AtlasPopulationMode, Boolean)
		/// </summary>
		protected static RMethod r_RCreateFontAsset_Font_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean;
		public static RMethod RCreateFontAsset_Font_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean
		{
			get
			{
				if(r_RCreateFontAsset_Font_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean == null)
				{
					r_RCreateFontAsset_Font_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean = new(typeof(UnityEngine.TextCore.Text.FontAsset), "CreateFontAsset", 0, typeof(UnityEngine.Font), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextCore.Text.AtlasPopulationMode), typeof(System.Boolean));
					r_RCreateFontAsset_Font_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean.SetBelong(null);
				}
				return r_RCreateFontAsset_Font_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAsset CreateFontAssetInstance(UnityEngine.Font, Int32, UnityEngine.TextCore.LowLevel.GlyphRenderMode, Int32, Int32, UnityEngine.TextCore.Text.AtlasPopulationMode, Boolean)
		/// </summary>
		protected static RMethod r_RCreateFontAssetInstance_Font_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean;
		public static RMethod RCreateFontAssetInstance_Font_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean
		{
			get
			{
				if(r_RCreateFontAssetInstance_Font_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean == null)
				{
					r_RCreateFontAssetInstance_Font_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean = new(typeof(UnityEngine.TextCore.Text.FontAsset), "CreateFontAssetInstance", 0, typeof(UnityEngine.Font), typeof(System.Int32), typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextCore.Text.AtlasPopulationMode), typeof(System.Boolean));
					r_RCreateFontAssetInstance_Font_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean.SetBelong(null);
				}
				return r_RCreateFontAssetInstance_Font_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean;
			}
		}

		/// <summary>
		/// Void Awake()
		/// </summary>
		protected RMethod r_RAwake;
		public virtual RMethod RAwake
		{
			get
			{
				if(r_RAwake == null)
				{
					r_RAwake = new(this, "Awake", 0);
					r_RAwake.SetBelong(this.instance);
				}
				return r_RAwake;
			}
		}

		/// <summary>
		/// Void OnDestroy()
		/// </summary>
		protected RMethod r_ROnDestroy;
		public virtual RMethod ROnDestroy
		{
			get
			{
				if(r_ROnDestroy == null)
				{
					r_ROnDestroy = new(this, "OnDestroy", 0);
					r_ROnDestroy.SetBelong(this.instance);
				}
				return r_ROnDestroy;
			}
		}

		/// <summary>
		/// Void OnValidate()
		/// </summary>
		protected RMethod r_ROnValidate;
		public virtual RMethod ROnValidate
		{
			get
			{
				if(r_ROnValidate == null)
				{
					r_ROnValidate = new(this, "OnValidate", 0);
					r_ROnValidate.SetBelong(this.instance);
				}
				return r_ROnValidate;
			}
		}

		/// <summary>
		/// Void ReadFontAssetDefinition()
		/// </summary>
		protected RMethod r_RReadFontAssetDefinition;
		public virtual RMethod RReadFontAssetDefinition
		{
			get
			{
				if(r_RReadFontAssetDefinition == null)
				{
					r_RReadFontAssetDefinition = new(this, "ReadFontAssetDefinition", 0);
					r_RReadFontAssetDefinition.SetBelong(this.instance);
				}
				return r_RReadFontAssetDefinition;
			}
		}

		/// <summary>
		/// Void InitializeDictionaryLookupTables()
		/// </summary>
		protected RMethod r_RInitializeDictionaryLookupTables;
		public virtual RMethod RInitializeDictionaryLookupTables
		{
			get
			{
				if(r_RInitializeDictionaryLookupTables == null)
				{
					r_RInitializeDictionaryLookupTables = new(this, "InitializeDictionaryLookupTables", 0);
					r_RInitializeDictionaryLookupTables.SetBelong(this.instance);
				}
				return r_RInitializeDictionaryLookupTables;
			}
		}

		/// <summary>
		/// Void InitializeGlyphLookupDictionary()
		/// </summary>
		protected RMethod r_RInitializeGlyphLookupDictionary;
		public virtual RMethod RInitializeGlyphLookupDictionary
		{
			get
			{
				if(r_RInitializeGlyphLookupDictionary == null)
				{
					r_RInitializeGlyphLookupDictionary = new(this, "InitializeGlyphLookupDictionary", 0);
					r_RInitializeGlyphLookupDictionary.SetBelong(this.instance);
				}
				return r_RInitializeGlyphLookupDictionary;
			}
		}

		/// <summary>
		/// Void InitializeCharacterLookupDictionary()
		/// </summary>
		protected RMethod r_RInitializeCharacterLookupDictionary;
		public virtual RMethod RInitializeCharacterLookupDictionary
		{
			get
			{
				if(r_RInitializeCharacterLookupDictionary == null)
				{
					r_RInitializeCharacterLookupDictionary = new(this, "InitializeCharacterLookupDictionary", 0);
					r_RInitializeCharacterLookupDictionary.SetBelong(this.instance);
				}
				return r_RInitializeCharacterLookupDictionary;
			}
		}

		/// <summary>
		/// Void InitializeLigatureSubstitutionLookupDictionary()
		/// </summary>
		protected RMethod r_RInitializeLigatureSubstitutionLookupDictionary;
		public virtual RMethod RInitializeLigatureSubstitutionLookupDictionary
		{
			get
			{
				if(r_RInitializeLigatureSubstitutionLookupDictionary == null)
				{
					r_RInitializeLigatureSubstitutionLookupDictionary = new(this, "InitializeLigatureSubstitutionLookupDictionary", 0);
					r_RInitializeLigatureSubstitutionLookupDictionary.SetBelong(this.instance);
				}
				return r_RInitializeLigatureSubstitutionLookupDictionary;
			}
		}

		/// <summary>
		/// Void InitializeGlyphPaidAdjustmentRecordsLookupDictionary()
		/// </summary>
		protected RMethod r_RInitializeGlyphPaidAdjustmentRecordsLookupDictionary;
		public virtual RMethod RInitializeGlyphPaidAdjustmentRecordsLookupDictionary
		{
			get
			{
				if(r_RInitializeGlyphPaidAdjustmentRecordsLookupDictionary == null)
				{
					r_RInitializeGlyphPaidAdjustmentRecordsLookupDictionary = new(this, "InitializeGlyphPaidAdjustmentRecordsLookupDictionary", 0);
					r_RInitializeGlyphPaidAdjustmentRecordsLookupDictionary.SetBelong(this.instance);
				}
				return r_RInitializeGlyphPaidAdjustmentRecordsLookupDictionary;
			}
		}

		/// <summary>
		/// Void InitializeMarkToBaseAdjustmentRecordsLookupDictionary()
		/// </summary>
		protected RMethod r_RInitializeMarkToBaseAdjustmentRecordsLookupDictionary;
		public virtual RMethod RInitializeMarkToBaseAdjustmentRecordsLookupDictionary
		{
			get
			{
				if(r_RInitializeMarkToBaseAdjustmentRecordsLookupDictionary == null)
				{
					r_RInitializeMarkToBaseAdjustmentRecordsLookupDictionary = new(this, "InitializeMarkToBaseAdjustmentRecordsLookupDictionary", 0);
					r_RInitializeMarkToBaseAdjustmentRecordsLookupDictionary.SetBelong(this.instance);
				}
				return r_RInitializeMarkToBaseAdjustmentRecordsLookupDictionary;
			}
		}

		/// <summary>
		/// Void InitializeMarkToMarkAdjustmentRecordsLookupDictionary()
		/// </summary>
		protected RMethod r_RInitializeMarkToMarkAdjustmentRecordsLookupDictionary;
		public virtual RMethod RInitializeMarkToMarkAdjustmentRecordsLookupDictionary
		{
			get
			{
				if(r_RInitializeMarkToMarkAdjustmentRecordsLookupDictionary == null)
				{
					r_RInitializeMarkToMarkAdjustmentRecordsLookupDictionary = new(this, "InitializeMarkToMarkAdjustmentRecordsLookupDictionary", 0);
					r_RInitializeMarkToMarkAdjustmentRecordsLookupDictionary.SetBelong(this.instance);
				}
				return r_RInitializeMarkToMarkAdjustmentRecordsLookupDictionary;
			}
		}

		/// <summary>
		/// Void AddSynthesizedCharactersAndFaceMetrics()
		/// </summary>
		protected RMethod r_RAddSynthesizedCharactersAndFaceMetrics;
		public virtual RMethod RAddSynthesizedCharactersAndFaceMetrics
		{
			get
			{
				if(r_RAddSynthesizedCharactersAndFaceMetrics == null)
				{
					r_RAddSynthesizedCharactersAndFaceMetrics = new(this, "AddSynthesizedCharactersAndFaceMetrics", 0);
					r_RAddSynthesizedCharactersAndFaceMetrics.SetBelong(this.instance);
				}
				return r_RAddSynthesizedCharactersAndFaceMetrics;
			}
		}

		/// <summary>
		/// Void AddSynthesizedCharacter(UInt32, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RAddSynthesizedCharacter_UInt32_Boolean_Boolean;
		public virtual RMethod RAddSynthesizedCharacter_UInt32_Boolean_Boolean
		{
			get
			{
				if(r_RAddSynthesizedCharacter_UInt32_Boolean_Boolean == null)
				{
					r_RAddSynthesizedCharacter_UInt32_Boolean_Boolean = new(this, "AddSynthesizedCharacter", 0, typeof(System.UInt32), typeof(System.Boolean), typeof(System.Boolean));
					r_RAddSynthesizedCharacter_UInt32_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RAddSynthesizedCharacter_UInt32_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void AddCharacterToLookupCache(UInt32, UnityEngine.TextCore.Text.Character)
		/// </summary>
		protected RMethod r_RAddCharacterToLookupCache_UInt32_Character;
		public virtual RMethod RAddCharacterToLookupCache_UInt32_Character
		{
			get
			{
				if(r_RAddCharacterToLookupCache_UInt32_Character == null)
				{
					r_RAddCharacterToLookupCache_UInt32_Character = new(this, "AddCharacterToLookupCache", 0, typeof(System.UInt32), typeof(UnityEngine.TextCore.Text.Character));
					r_RAddCharacterToLookupCache_UInt32_Character.SetBelong(this.instance);
				}
				return r_RAddCharacterToLookupCache_UInt32_Character;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace()
		/// </summary>
		protected RMethod r_RLoadFontFace;
		public virtual RMethod RLoadFontFace
		{
			get
			{
				if(r_RLoadFontFace == null)
				{
					r_RLoadFontFace = new(this, "LoadFontFace", 0);
					r_RLoadFontFace.SetBelong(this.instance);
				}
				return r_RLoadFontFace;
			}
		}

		/// <summary>
		/// Void SortCharacterTable()
		/// </summary>
		protected RMethod r_RSortCharacterTable;
		public virtual RMethod RSortCharacterTable
		{
			get
			{
				if(r_RSortCharacterTable == null)
				{
					r_RSortCharacterTable = new(this, "SortCharacterTable", 0);
					r_RSortCharacterTable.SetBelong(this.instance);
				}
				return r_RSortCharacterTable;
			}
		}

		/// <summary>
		/// Void SortGlyphTable()
		/// </summary>
		protected RMethod r_RSortGlyphTable;
		public virtual RMethod RSortGlyphTable
		{
			get
			{
				if(r_RSortGlyphTable == null)
				{
					r_RSortGlyphTable = new(this, "SortGlyphTable", 0);
					r_RSortGlyphTable.SetBelong(this.instance);
				}
				return r_RSortGlyphTable;
			}
		}

		/// <summary>
		/// Void SortFontFeatureTable()
		/// </summary>
		protected RMethod r_RSortFontFeatureTable;
		public virtual RMethod RSortFontFeatureTable
		{
			get
			{
				if(r_RSortFontFeatureTable == null)
				{
					r_RSortFontFeatureTable = new(this, "SortFontFeatureTable", 0);
					r_RSortFontFeatureTable.SetBelong(this.instance);
				}
				return r_RSortFontFeatureTable;
			}
		}

		/// <summary>
		/// Void SortAllTables()
		/// </summary>
		protected RMethod r_RSortAllTables;
		public virtual RMethod RSortAllTables
		{
			get
			{
				if(r_RSortAllTables == null)
				{
					r_RSortAllTables = new(this, "SortAllTables", 0);
					r_RSortAllTables.SetBelong(this.instance);
				}
				return r_RSortAllTables;
			}
		}

		/// <summary>
		/// Boolean HasCharacter(Int32)
		/// </summary>
		protected RMethod r_RHasCharacter_Int32;
		public virtual RMethod RHasCharacter_Int32
		{
			get
			{
				if(r_RHasCharacter_Int32 == null)
				{
					r_RHasCharacter_Int32 = new(this, "HasCharacter", 0, typeof(System.Int32));
					r_RHasCharacter_Int32.SetBelong(this.instance);
				}
				return r_RHasCharacter_Int32;
			}
		}

		/// <summary>
		/// Boolean HasCharacter(Char, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RHasCharacter_Char_Boolean_Boolean;
		public virtual RMethod RHasCharacter_Char_Boolean_Boolean
		{
			get
			{
				if(r_RHasCharacter_Char_Boolean_Boolean == null)
				{
					r_RHasCharacter_Char_Boolean_Boolean = new(this, "HasCharacter", 0, typeof(System.Char), typeof(System.Boolean), typeof(System.Boolean));
					r_RHasCharacter_Char_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RHasCharacter_Char_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Boolean HasCharacter_Internal(UInt32, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RHasCharacter_Internal_UInt32_Boolean_Boolean;
		public virtual RMethod RHasCharacter_Internal_UInt32_Boolean_Boolean
		{
			get
			{
				if(r_RHasCharacter_Internal_UInt32_Boolean_Boolean == null)
				{
					r_RHasCharacter_Internal_UInt32_Boolean_Boolean = new(this, "HasCharacter_Internal", 0, typeof(System.UInt32), typeof(System.Boolean), typeof(System.Boolean));
					r_RHasCharacter_Internal_UInt32_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RHasCharacter_Internal_UInt32_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Boolean HasCharacters(System.String, System.Collections.Generic.List`1[System.Char] ByRef)
		/// </summary>
		protected RMethod r_RHasCharacters_String_Out_List_d_Char_p_;
		public virtual RMethod RHasCharacters_String_Out_List_d_Char_p_
		{
			get
			{
				if(r_RHasCharacters_String_Out_List_d_Char_p_ == null)
				{
					r_RHasCharacters_String_Out_List_d_Char_p_ = new(this, "HasCharacters", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Char)).MakeByRefType());
					r_RHasCharacters_String_Out_List_d_Char_p_.SetBelong(this.instance);
				}
				return r_RHasCharacters_String_Out_List_d_Char_p_;
			}
		}

		/// <summary>
		/// Boolean HasCharacters(System.String, UInt32[] ByRef, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RHasCharacters_String_Out_UInt32Array_Boolean_Boolean;
		public virtual RMethod RHasCharacters_String_Out_UInt32Array_Boolean_Boolean
		{
			get
			{
				if(r_RHasCharacters_String_Out_UInt32Array_Boolean_Boolean == null)
				{
					r_RHasCharacters_String_Out_UInt32Array_Boolean_Boolean = new(this, "HasCharacters", 0, typeof(System.String), typeof(System.UInt32).MakeArrayType().MakeByRefType(), typeof(System.Boolean), typeof(System.Boolean));
					r_RHasCharacters_String_Out_UInt32Array_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RHasCharacters_String_Out_UInt32Array_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Boolean HasCharacters(System.String)
		/// </summary>
		protected RMethod r_RHasCharacters_String;
		public virtual RMethod RHasCharacters_String
		{
			get
			{
				if(r_RHasCharacters_String == null)
				{
					r_RHasCharacters_String = new(this, "HasCharacters", 0, typeof(System.String));
					r_RHasCharacters_String.SetBelong(this.instance);
				}
				return r_RHasCharacters_String;
			}
		}

		/// <summary>
		/// System.String GetCharacters(UnityEngine.TextCore.Text.FontAsset)
		/// </summary>
		protected static RMethod r_RGetCharacters_FontAsset;
		public static RMethod RGetCharacters_FontAsset
		{
			get
			{
				if(r_RGetCharacters_FontAsset == null)
				{
					r_RGetCharacters_FontAsset = new(typeof(UnityEngine.TextCore.Text.FontAsset), "GetCharacters", 0, typeof(UnityEngine.TextCore.Text.FontAsset));
					r_RGetCharacters_FontAsset.SetBelong(null);
				}
				return r_RGetCharacters_FontAsset;
			}
		}

		/// <summary>
		/// Int32[] GetCharactersArray(UnityEngine.TextCore.Text.FontAsset)
		/// </summary>
		protected static RMethod r_RGetCharactersArray_FontAsset;
		public static RMethod RGetCharactersArray_FontAsset
		{
			get
			{
				if(r_RGetCharactersArray_FontAsset == null)
				{
					r_RGetCharactersArray_FontAsset = new(typeof(UnityEngine.TextCore.Text.FontAsset), "GetCharactersArray", 0, typeof(UnityEngine.TextCore.Text.FontAsset));
					r_RGetCharactersArray_FontAsset.SetBelong(null);
				}
				return r_RGetCharactersArray_FontAsset;
			}
		}

		/// <summary>
		/// UInt32 GetGlyphIndex(UInt32)
		/// </summary>
		protected RMethod r_RGetGlyphIndex_UInt32;
		public virtual RMethod RGetGlyphIndex_UInt32
		{
			get
			{
				if(r_RGetGlyphIndex_UInt32 == null)
				{
					r_RGetGlyphIndex_UInt32 = new(this, "GetGlyphIndex", 0, typeof(System.UInt32));
					r_RGetGlyphIndex_UInt32.SetBelong(this.instance);
				}
				return r_RGetGlyphIndex_UInt32;
			}
		}

		/// <summary>
		/// Void RegisterFontAssetForFontFeatureUpdate(UnityEngine.TextCore.Text.FontAsset)
		/// </summary>
		protected static RMethod r_RRegisterFontAssetForFontFeatureUpdate_FontAsset;
		public static RMethod RRegisterFontAssetForFontFeatureUpdate_FontAsset
		{
			get
			{
				if(r_RRegisterFontAssetForFontFeatureUpdate_FontAsset == null)
				{
					r_RRegisterFontAssetForFontFeatureUpdate_FontAsset = new(typeof(UnityEngine.TextCore.Text.FontAsset), "RegisterFontAssetForFontFeatureUpdate", 0, typeof(UnityEngine.TextCore.Text.FontAsset));
					r_RRegisterFontAssetForFontFeatureUpdate_FontAsset.SetBelong(null);
				}
				return r_RRegisterFontAssetForFontFeatureUpdate_FontAsset;
			}
		}

		/// <summary>
		/// Void UpdateFontFeaturesForFontAssetsInQueue()
		/// </summary>
		protected static RMethod r_RUpdateFontFeaturesForFontAssetsInQueue;
		public static RMethod RUpdateFontFeaturesForFontAssetsInQueue
		{
			get
			{
				if(r_RUpdateFontFeaturesForFontAssetsInQueue == null)
				{
					r_RUpdateFontFeaturesForFontAssetsInQueue = new(typeof(UnityEngine.TextCore.Text.FontAsset), "UpdateFontFeaturesForFontAssetsInQueue", 0);
					r_RUpdateFontFeaturesForFontAssetsInQueue.SetBelong(null);
				}
				return r_RUpdateFontFeaturesForFontAssetsInQueue;
			}
		}

		/// <summary>
		/// Void RegisterAtlasTextureForApply(UnityEngine.Texture2D)
		/// </summary>
		protected static RMethod r_RRegisterAtlasTextureForApply_Texture2D;
		public static RMethod RRegisterAtlasTextureForApply_Texture2D
		{
			get
			{
				if(r_RRegisterAtlasTextureForApply_Texture2D == null)
				{
					r_RRegisterAtlasTextureForApply_Texture2D = new(typeof(UnityEngine.TextCore.Text.FontAsset), "RegisterAtlasTextureForApply", 0, typeof(UnityEngine.Texture2D));
					r_RRegisterAtlasTextureForApply_Texture2D.SetBelong(null);
				}
				return r_RRegisterAtlasTextureForApply_Texture2D;
			}
		}

		/// <summary>
		/// Void UpdateAtlasTexturesInQueue()
		/// </summary>
		protected static RMethod r_RUpdateAtlasTexturesInQueue;
		public static RMethod RUpdateAtlasTexturesInQueue
		{
			get
			{
				if(r_RUpdateAtlasTexturesInQueue == null)
				{
					r_RUpdateAtlasTexturesInQueue = new(typeof(UnityEngine.TextCore.Text.FontAsset), "UpdateAtlasTexturesInQueue", 0);
					r_RUpdateAtlasTexturesInQueue.SetBelong(null);
				}
				return r_RUpdateAtlasTexturesInQueue;
			}
		}

		/// <summary>
		/// Void UpdateFontAssetsInUpdateQueue()
		/// </summary>
		protected static RMethod r_RUpdateFontAssetsInUpdateQueue;
		public static RMethod RUpdateFontAssetsInUpdateQueue
		{
			get
			{
				if(r_RUpdateFontAssetsInUpdateQueue == null)
				{
					r_RUpdateFontAssetsInUpdateQueue = new(typeof(UnityEngine.TextCore.Text.FontAsset), "UpdateFontAssetsInUpdateQueue", 0);
					r_RUpdateFontAssetsInUpdateQueue.SetBelong(null);
				}
				return r_RUpdateFontAssetsInUpdateQueue;
			}
		}

		/// <summary>
		/// Boolean TryAddCharacters(UInt32[], Boolean)
		/// </summary>
		protected RMethod r_RTryAddCharacters_UInt32Array_Boolean;
		public virtual RMethod RTryAddCharacters_UInt32Array_Boolean
		{
			get
			{
				if(r_RTryAddCharacters_UInt32Array_Boolean == null)
				{
					r_RTryAddCharacters_UInt32Array_Boolean = new(this, "TryAddCharacters", 0, typeof(System.UInt32).MakeArrayType(), typeof(System.Boolean));
					r_RTryAddCharacters_UInt32Array_Boolean.SetBelong(this.instance);
				}
				return r_RTryAddCharacters_UInt32Array_Boolean;
			}
		}

		/// <summary>
		/// Boolean TryAddCharacters(UInt32[], UInt32[] ByRef, Boolean)
		/// </summary>
		protected RMethod r_RTryAddCharacters_UInt32Array_Out_UInt32Array_Boolean;
		public virtual RMethod RTryAddCharacters_UInt32Array_Out_UInt32Array_Boolean
		{
			get
			{
				if(r_RTryAddCharacters_UInt32Array_Out_UInt32Array_Boolean == null)
				{
					r_RTryAddCharacters_UInt32Array_Out_UInt32Array_Boolean = new(this, "TryAddCharacters", 0, typeof(System.UInt32).MakeArrayType(), typeof(System.UInt32).MakeArrayType().MakeByRefType(), typeof(System.Boolean));
					r_RTryAddCharacters_UInt32Array_Out_UInt32Array_Boolean.SetBelong(this.instance);
				}
				return r_RTryAddCharacters_UInt32Array_Out_UInt32Array_Boolean;
			}
		}

		/// <summary>
		/// Boolean TryAddCharacters(System.String, Boolean)
		/// </summary>
		protected RMethod r_RTryAddCharacters_String_Boolean;
		public virtual RMethod RTryAddCharacters_String_Boolean
		{
			get
			{
				if(r_RTryAddCharacters_String_Boolean == null)
				{
					r_RTryAddCharacters_String_Boolean = new(this, "TryAddCharacters", 0, typeof(System.String), typeof(System.Boolean));
					r_RTryAddCharacters_String_Boolean.SetBelong(this.instance);
				}
				return r_RTryAddCharacters_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean TryAddCharacters(System.String, System.String ByRef, Boolean)
		/// </summary>
		protected RMethod r_RTryAddCharacters_String_Out_String_Boolean;
		public virtual RMethod RTryAddCharacters_String_Out_String_Boolean
		{
			get
			{
				if(r_RTryAddCharacters_String_Out_String_Boolean == null)
				{
					r_RTryAddCharacters_String_Out_String_Boolean = new(this, "TryAddCharacters", 0, typeof(System.String), typeof(System.String).MakeByRefType(), typeof(System.Boolean));
					r_RTryAddCharacters_String_Out_String_Boolean.SetBelong(this.instance);
				}
				return r_RTryAddCharacters_String_Out_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean TryAddGlyphInternal(UInt32, UnityEngine.TextCore.Glyph ByRef)
		/// </summary>
		protected RMethod r_RTryAddGlyphInternal_UInt32_Out_Glyph;
		public virtual RMethod RTryAddGlyphInternal_UInt32_Out_Glyph
		{
			get
			{
				if(r_RTryAddGlyphInternal_UInt32_Out_Glyph == null)
				{
					r_RTryAddGlyphInternal_UInt32_Out_Glyph = new(this, "TryAddGlyphInternal", 0, typeof(System.UInt32), typeof(UnityEngine.TextCore.Glyph).MakeByRefType());
					r_RTryAddGlyphInternal_UInt32_Out_Glyph.SetBelong(this.instance);
				}
				return r_RTryAddGlyphInternal_UInt32_Out_Glyph;
			}
		}

		/// <summary>
		/// Boolean TryAddCharacterInternal(UInt32, UnityEngine.TextCore.Text.Character ByRef, Boolean)
		/// </summary>
		protected RMethod r_RTryAddCharacterInternal_UInt32_Out_Character_Boolean;
		public virtual RMethod RTryAddCharacterInternal_UInt32_Out_Character_Boolean
		{
			get
			{
				if(r_RTryAddCharacterInternal_UInt32_Out_Character_Boolean == null)
				{
					r_RTryAddCharacterInternal_UInt32_Out_Character_Boolean = new(this, "TryAddCharacterInternal", 0, typeof(System.UInt32), typeof(UnityEngine.TextCore.Text.Character).MakeByRefType(), typeof(System.Boolean));
					r_RTryAddCharacterInternal_UInt32_Out_Character_Boolean.SetBelong(this.instance);
				}
				return r_RTryAddCharacterInternal_UInt32_Out_Character_Boolean;
			}
		}

		/// <summary>
		/// Boolean TryGetCharacter_and_QueueRenderToTexture(UInt32, UnityEngine.TextCore.Text.Character ByRef, Boolean)
		/// </summary>
		protected RMethod r_RTryGetCharacter_and_QueueRenderToTexture_UInt32_Out_Character_Boolean;
		public virtual RMethod RTryGetCharacter_and_QueueRenderToTexture_UInt32_Out_Character_Boolean
		{
			get
			{
				if(r_RTryGetCharacter_and_QueueRenderToTexture_UInt32_Out_Character_Boolean == null)
				{
					r_RTryGetCharacter_and_QueueRenderToTexture_UInt32_Out_Character_Boolean = new(this, "TryGetCharacter_and_QueueRenderToTexture", 0, typeof(System.UInt32), typeof(UnityEngine.TextCore.Text.Character).MakeByRefType(), typeof(System.Boolean));
					r_RTryGetCharacter_and_QueueRenderToTexture_UInt32_Out_Character_Boolean.SetBelong(this.instance);
				}
				return r_RTryGetCharacter_and_QueueRenderToTexture_UInt32_Out_Character_Boolean;
			}
		}

		/// <summary>
		/// Void TryAddGlyphsToAtlasTextures()
		/// </summary>
		protected RMethod r_RTryAddGlyphsToAtlasTextures;
		public virtual RMethod RTryAddGlyphsToAtlasTextures
		{
			get
			{
				if(r_RTryAddGlyphsToAtlasTextures == null)
				{
					r_RTryAddGlyphsToAtlasTextures = new(this, "TryAddGlyphsToAtlasTextures", 0);
					r_RTryAddGlyphsToAtlasTextures.SetBelong(this.instance);
				}
				return r_RTryAddGlyphsToAtlasTextures;
			}
		}

		/// <summary>
		/// Boolean TryAddGlyphsToNewAtlasTexture()
		/// </summary>
		protected RMethod r_RTryAddGlyphsToNewAtlasTexture;
		public virtual RMethod RTryAddGlyphsToNewAtlasTexture
		{
			get
			{
				if(r_RTryAddGlyphsToNewAtlasTexture == null)
				{
					r_RTryAddGlyphsToNewAtlasTexture = new(this, "TryAddGlyphsToNewAtlasTexture", 0);
					r_RTryAddGlyphsToNewAtlasTexture.SetBelong(this.instance);
				}
				return r_RTryAddGlyphsToNewAtlasTexture;
			}
		}

		/// <summary>
		/// Void SetupNewAtlasTexture()
		/// </summary>
		protected RMethod r_RSetupNewAtlasTexture;
		public virtual RMethod RSetupNewAtlasTexture
		{
			get
			{
				if(r_RSetupNewAtlasTexture == null)
				{
					r_RSetupNewAtlasTexture = new(this, "SetupNewAtlasTexture", 0);
					r_RSetupNewAtlasTexture.SetBelong(this.instance);
				}
				return r_RSetupNewAtlasTexture;
			}
		}

		/// <summary>
		/// Void UpdateAllFontFeatures()
		/// </summary>
		protected RMethod r_RUpdateAllFontFeatures;
		public virtual RMethod RUpdateAllFontFeatures
		{
			get
			{
				if(r_RUpdateAllFontFeatures == null)
				{
					r_RUpdateAllFontFeatures = new(this, "UpdateAllFontFeatures", 0);
					r_RUpdateAllFontFeatures.SetBelong(this.instance);
				}
				return r_RUpdateAllFontFeatures;
			}
		}

		/// <summary>
		/// Void UpdateGlyphAdjustmentRecords()
		/// </summary>
		protected RMethod r_RUpdateGlyphAdjustmentRecords;
		public virtual RMethod RUpdateGlyphAdjustmentRecords
		{
			get
			{
				if(r_RUpdateGlyphAdjustmentRecords == null)
				{
					r_RUpdateGlyphAdjustmentRecords = new(this, "UpdateGlyphAdjustmentRecords", 0);
					r_RUpdateGlyphAdjustmentRecords.SetBelong(this.instance);
				}
				return r_RUpdateGlyphAdjustmentRecords;
			}
		}

		/// <summary>
		/// Void UpdateGlyphAdjustmentRecords(UInt32[])
		/// </summary>
		protected RMethod r_RUpdateGlyphAdjustmentRecords_UInt32Array;
		public virtual RMethod RUpdateGlyphAdjustmentRecords_UInt32Array
		{
			get
			{
				if(r_RUpdateGlyphAdjustmentRecords_UInt32Array == null)
				{
					r_RUpdateGlyphAdjustmentRecords_UInt32Array = new(this, "UpdateGlyphAdjustmentRecords", 0, typeof(System.UInt32).MakeArrayType());
					r_RUpdateGlyphAdjustmentRecords_UInt32Array.SetBelong(this.instance);
				}
				return r_RUpdateGlyphAdjustmentRecords_UInt32Array;
			}
		}

		/// <summary>
		/// Void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List`1[System.UInt32])
		/// </summary>
		protected RMethod r_RUpdateGlyphAdjustmentRecords_List_d_UInt32_p_;
		public virtual RMethod RUpdateGlyphAdjustmentRecords_List_d_UInt32_p_
		{
			get
			{
				if(r_RUpdateGlyphAdjustmentRecords_List_d_UInt32_p_ == null)
				{
					r_RUpdateGlyphAdjustmentRecords_List_d_UInt32_p_ = new(this, "UpdateGlyphAdjustmentRecords", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.UInt32)));
					r_RUpdateGlyphAdjustmentRecords_List_d_UInt32_p_.SetBelong(this.instance);
				}
				return r_RUpdateGlyphAdjustmentRecords_List_d_UInt32_p_;
			}
		}

		/// <summary>
		/// Void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List`1[System.UInt32], System.Collections.Generic.List`1[System.UInt32])
		/// </summary>
		protected RMethod r_RUpdateGlyphAdjustmentRecords_List_d_UInt32_p__List_d_UInt32_p_;
		public virtual RMethod RUpdateGlyphAdjustmentRecords_List_d_UInt32_p__List_d_UInt32_p_
		{
			get
			{
				if(r_RUpdateGlyphAdjustmentRecords_List_d_UInt32_p__List_d_UInt32_p_ == null)
				{
					r_RUpdateGlyphAdjustmentRecords_List_d_UInt32_p__List_d_UInt32_p_ = new(this, "UpdateGlyphAdjustmentRecords", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.UInt32)), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.UInt32)));
					r_RUpdateGlyphAdjustmentRecords_List_d_UInt32_p__List_d_UInt32_p_.SetBelong(this.instance);
				}
				return r_RUpdateGlyphAdjustmentRecords_List_d_UInt32_p__List_d_UInt32_p_;
			}
		}

		/// <summary>
		/// Void CopyListDataToArray[T](System.Collections.Generic.List`1[T], T[] ByRef)
		/// </summary>
		protected RMethod r_RCopyListDataToArray_GT_List_d_T_p__Ref_TArray;
		public virtual RMethod RCopyListDataToArray_GT_List_d_T_p__Ref_TArray
		{
			get
			{
				if(r_RCopyListDataToArray_GT_List_d_T_p__Ref_TArray == null)
				{
					r_RCopyListDataToArray_GT_List_d_T_p__Ref_TArray = new(this, "CopyListDataToArray", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0).MakeArrayType().MakeByRefType());
					r_RCopyListDataToArray_GT_List_d_T_p__Ref_TArray.SetBelong(this.instance);
				}
				return r_RCopyListDataToArray_GT_List_d_T_p__Ref_TArray;
			}
		}

		/// <summary>
		/// Void ClearFontAssetData(Boolean)
		/// </summary>
		protected RMethod r_RClearFontAssetData_Boolean;
		public virtual RMethod RClearFontAssetData_Boolean
		{
			get
			{
				if(r_RClearFontAssetData_Boolean == null)
				{
					r_RClearFontAssetData_Boolean = new(this, "ClearFontAssetData", 0, typeof(System.Boolean));
					r_RClearFontAssetData_Boolean.SetBelong(this.instance);
				}
				return r_RClearFontAssetData_Boolean;
			}
		}

		/// <summary>
		/// Void ClearFontAssetDataInternal(Boolean)
		/// </summary>
		protected RMethod r_RClearFontAssetDataInternal_Boolean;
		public virtual RMethod RClearFontAssetDataInternal_Boolean
		{
			get
			{
				if(r_RClearFontAssetDataInternal_Boolean == null)
				{
					r_RClearFontAssetDataInternal_Boolean = new(this, "ClearFontAssetDataInternal", 0, typeof(System.Boolean));
					r_RClearFontAssetDataInternal_Boolean.SetBelong(this.instance);
				}
				return r_RClearFontAssetDataInternal_Boolean;
			}
		}

		/// <summary>
		/// Void UpdateFontAssetData()
		/// </summary>
		protected RMethod r_RUpdateFontAssetData;
		public virtual RMethod RUpdateFontAssetData
		{
			get
			{
				if(r_RUpdateFontAssetData == null)
				{
					r_RUpdateFontAssetData = new(this, "UpdateFontAssetData", 0);
					r_RUpdateFontAssetData.SetBelong(this.instance);
				}
				return r_RUpdateFontAssetData;
			}
		}

		/// <summary>
		/// Void ClearFontAssetTables(Boolean)
		/// </summary>
		protected RMethod r_RClearFontAssetTables_Boolean;
		public virtual RMethod RClearFontAssetTables_Boolean
		{
			get
			{
				if(r_RClearFontAssetTables_Boolean == null)
				{
					r_RClearFontAssetTables_Boolean = new(this, "ClearFontAssetTables", 0, typeof(System.Boolean));
					r_RClearFontAssetTables_Boolean.SetBelong(this.instance);
				}
				return r_RClearFontAssetTables_Boolean;
			}
		}

		/// <summary>
		/// Void ClearAtlasTextures(Boolean)
		/// </summary>
		protected RMethod r_RClearAtlasTextures_Boolean;
		public virtual RMethod RClearAtlasTextures_Boolean
		{
			get
			{
				if(r_RClearAtlasTextures_Boolean == null)
				{
					r_RClearAtlasTextures_Boolean = new(this, "ClearAtlasTextures", 0, typeof(System.Boolean));
					r_RClearAtlasTextures_Boolean.SetBelong(this.instance);
				}
				return r_RClearAtlasTextures_Boolean;
			}
		}

		/// <summary>
		/// Void DestroyAtlasTextures()
		/// </summary>
		protected RMethod r_RDestroyAtlasTextures;
		public virtual RMethod RDestroyAtlasTextures
		{
			get
			{
				if(r_RDestroyAtlasTextures == null)
				{
					r_RDestroyAtlasTextures = new(this, "DestroyAtlasTextures", 0);
					r_RDestroyAtlasTextures.SetBelong(this.instance);
				}
				return r_RDestroyAtlasTextures;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_RSetDirty;
		public virtual RMethod RSetDirty
		{
			get
			{
				if(r_RSetDirty == null)
				{
					r_RSetDirty = new(this, "SetDirty", 0);
					r_RSetDirty.SetBelong(this.instance);
				}
				return r_RSetDirty;
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


        public RFontAsset() : base("UnityEngine.TextCore.Text.FontAsset")
        {
        }

        public RFontAsset(System.Object instance) : base("UnityEngine.TextCore.Text.FontAsset")
		{
            SetInstance(instance);
		}

        public RFontAsset(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFontAsset(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.TextCore.Text.FontAsset CreateFontAsset(System.String  @familyName, System.String  @styleName, System.Int32  @pointSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@familyName, @styleName, @pointSize};
            var ___result = RCreateFontAsset_String_String_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TextCore.Text.FontAsset)___result;
        }


        public static UnityEngine.TextCore.Text.FontAsset CreateFontAsset(System.String  @fontFilePath, System.Int32  @faceIndex, System.Int32  @samplingPointSize, System.Int32  @atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode  @renderMode, System.Int32  @atlasWidth, System.Int32  @atlasHeight)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fontFilePath, @faceIndex, @samplingPointSize, @atlasPadding, @renderMode, @atlasWidth, @atlasHeight};
            var ___result = RCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TextCore.Text.FontAsset)___result;
        }


        public static UnityEngine.TextCore.Text.FontAsset CreateFontAsset(System.String  @fontFilePath, System.Int32  @faceIndex, System.Int32  @samplingPointSize, System.Int32  @atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode  @renderMode, System.Int32  @atlasWidth, System.Int32  @atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode  @atlasPopulationMode, System.Boolean  @enableMultiAtlasSupport)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fontFilePath, @faceIndex, @samplingPointSize, @atlasPadding, @renderMode, @atlasWidth, @atlasHeight, @atlasPopulationMode, @enableMultiAtlasSupport};
            var ___result = RCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TextCore.Text.FontAsset)___result;
        }


        public static UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font  @font)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@font};
            var ___result = RCreateFontAsset_Font.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TextCore.Text.FontAsset)___result;
        }


        public static UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font  @font, System.Int32  @samplingPointSize, System.Int32  @atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode  @renderMode, System.Int32  @atlasWidth, System.Int32  @atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode  @atlasPopulationMode, System.Boolean  @enableMultiAtlasSupport)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@font, @samplingPointSize, @atlasPadding, @renderMode, @atlasWidth, @atlasHeight, @atlasPopulationMode, @enableMultiAtlasSupport};
            var ___result = RCreateFontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TextCore.Text.FontAsset)___result;
        }


        public static UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font  @font, System.Int32  @faceIndex, System.Int32  @samplingPointSize, System.Int32  @atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode  @renderMode, System.Int32  @atlasWidth, System.Int32  @atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode  @atlasPopulationMode, System.Boolean  @enableMultiAtlasSupport)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@font, @faceIndex, @samplingPointSize, @atlasPadding, @renderMode, @atlasWidth, @atlasHeight, @atlasPopulationMode, @enableMultiAtlasSupport};
            var ___result = RCreateFontAsset_Font_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TextCore.Text.FontAsset)___result;
        }


        public static UnityEngine.TextCore.Text.FontAsset CreateFontAssetInstance(UnityEngine.Font  @font, System.Int32  @atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode  @renderMode, System.Int32  @atlasWidth, System.Int32  @atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode  @atlasPopulationMode, System.Boolean  @enableMultiAtlasSupport)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@font, @atlasPadding, @renderMode, @atlasWidth, @atlasHeight, @atlasPopulationMode, @enableMultiAtlasSupport};
            var ___result = RCreateFontAssetInstance_Font_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TextCore.Text.FontAsset)___result;
        }


        public virtual void Awake()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAwake.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDestroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDestroy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnValidate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnValidate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReadFontAssetDefinition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadFontAssetDefinition.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitializeDictionaryLookupTables()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitializeDictionaryLookupTables.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitializeGlyphLookupDictionary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitializeGlyphLookupDictionary.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitializeCharacterLookupDictionary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitializeCharacterLookupDictionary.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitializeLigatureSubstitutionLookupDictionary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitializeLigatureSubstitutionLookupDictionary.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitializeGlyphPaidAdjustmentRecordsLookupDictionary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitializeGlyphPaidAdjustmentRecordsLookupDictionary.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitializeMarkToBaseAdjustmentRecordsLookupDictionary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitializeMarkToBaseAdjustmentRecordsLookupDictionary.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitializeMarkToMarkAdjustmentRecordsLookupDictionary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitializeMarkToMarkAdjustmentRecordsLookupDictionary.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddSynthesizedCharactersAndFaceMetrics()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAddSynthesizedCharactersAndFaceMetrics.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddSynthesizedCharacter(System.UInt32  @unicode, System.Boolean  @isFontFaceLoaded, System.Boolean  @addImmediately)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unicode, @isFontFaceLoaded, @addImmediately};
            var ___result = RAddSynthesizedCharacter_UInt32_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddCharacterToLookupCache(System.UInt32  @unicode, UnityEngine.TextCore.Text.Character  @character)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unicode, @character};
            var ___result = RAddCharacterToLookupCache_UInt32_Character.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLoadFontFace.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TextCore.LowLevel.FontEngineError)___result;
        }


        public virtual void SortCharacterTable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSortCharacterTable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SortGlyphTable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSortGlyphTable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SortFontFeatureTable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSortFontFeatureTable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SortAllTables()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSortAllTables.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasCharacter(System.Int32  @character)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@character};
            var ___result = RHasCharacter_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasCharacter(System.Char  @character, System.Boolean  @searchFallbacks, System.Boolean  @tryAddCharacter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@character, @searchFallbacks, @tryAddCharacter};
            var ___result = RHasCharacter_Char_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasCharacter_Internal(System.UInt32  @character, System.Boolean  @searchFallbacks, System.Boolean  @tryAddCharacter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@character, @searchFallbacks, @tryAddCharacter};
            var ___result = RHasCharacter_Internal_UInt32_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasCharacters(System.String  @text, out System.Collections.Generic.List<System.Char>  @missingCharacters)
        {
			missingCharacters = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @missingCharacters};
            var ___result = RHasCharacters_String_Out_List_d_Char_p_.Invoke(___genericsType, ___parameters);
			missingCharacters = (System.Collections.Generic.List<System.Char>)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasCharacters(System.String  @text, out System.UInt32[]  @missingCharacters, System.Boolean  @searchFallbacks, System.Boolean  @tryAddCharacter)
        {
			missingCharacters = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @missingCharacters, @searchFallbacks, @tryAddCharacter};
            var ___result = RHasCharacters_String_Out_UInt32Array_Boolean_Boolean.Invoke(___genericsType, ___parameters);
			missingCharacters = (System.UInt32[])___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasCharacters(System.String  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RHasCharacters_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String GetCharacters(UnityEngine.TextCore.Text.FontAsset  @fontAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fontAsset};
            var ___result = RGetCharacters_FontAsset.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Int32[] GetCharactersArray(UnityEngine.TextCore.Text.FontAsset  @fontAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fontAsset};
            var ___result = RGetCharactersArray_FontAsset.Invoke(___genericsType, ___parameters);

            return (System.Int32[])___result;
        }


        public virtual System.UInt32 GetGlyphIndex(System.UInt32  @unicode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unicode};
            var ___result = RGetGlyphIndex_UInt32.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public static void RegisterFontAssetForFontFeatureUpdate(UnityEngine.TextCore.Text.FontAsset  @fontAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fontAsset};
            var ___result = RRegisterFontAssetForFontFeatureUpdate_FontAsset.Invoke(___genericsType, ___parameters);

            
        }


        public static void UpdateFontFeaturesForFontAssetsInQueue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateFontFeaturesForFontAssetsInQueue.Invoke(___genericsType, ___parameters);

            
        }


        public static void RegisterAtlasTextureForApply(UnityEngine.Texture2D  @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture};
            var ___result = RRegisterAtlasTextureForApply_Texture2D.Invoke(___genericsType, ___parameters);

            
        }


        public static void UpdateAtlasTexturesInQueue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateAtlasTexturesInQueue.Invoke(___genericsType, ___parameters);

            
        }


        public static void UpdateFontAssetsInUpdateQueue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateFontAssetsInUpdateQueue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryAddCharacters(System.UInt32[]  @unicodes, System.Boolean  @includeFontFeatures)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unicodes, @includeFontFeatures};
            var ___result = RTryAddCharacters_UInt32Array_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryAddCharacters(System.UInt32[]  @unicodes, out System.UInt32[]  @missingUnicodes, System.Boolean  @includeFontFeatures)
        {
			missingUnicodes = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unicodes, @missingUnicodes, @includeFontFeatures};
            var ___result = RTryAddCharacters_UInt32Array_Out_UInt32Array_Boolean.Invoke(___genericsType, ___parameters);
			missingUnicodes = (System.UInt32[])___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryAddCharacters(System.String  @characters, System.Boolean  @includeFontFeatures)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@characters, @includeFontFeatures};
            var ___result = RTryAddCharacters_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryAddCharacters(System.String  @characters, out System.String  @missingCharacters, System.Boolean  @includeFontFeatures)
        {
			missingCharacters = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@characters, @missingCharacters, @includeFontFeatures};
            var ___result = RTryAddCharacters_String_Out_String_Boolean.Invoke(___genericsType, ___parameters);
			missingCharacters = (System.String)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryAddGlyphInternal(System.UInt32  @glyphIndex, out UnityEngine.TextCore.Glyph  @glyph)
        {
			glyph = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@glyphIndex, @glyph};
            var ___result = RTryAddGlyphInternal_UInt32_Out_Glyph.Invoke(___genericsType, ___parameters);
			glyph = (UnityEngine.TextCore.Glyph)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryAddCharacterInternal(System.UInt32  @unicode, out UnityEngine.TextCore.Text.Character  @character, System.Boolean  @shouldGetFontFeatures)
        {
			character = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unicode, @character, @shouldGetFontFeatures};
            var ___result = RTryAddCharacterInternal_UInt32_Out_Character_Boolean.Invoke(___genericsType, ___parameters);
			character = (UnityEngine.TextCore.Text.Character)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetCharacter_and_QueueRenderToTexture(System.UInt32  @unicode, out UnityEngine.TextCore.Text.Character  @character, System.Boolean  @shouldGetFontFeatures)
        {
			character = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unicode, @character, @shouldGetFontFeatures};
            var ___result = RTryGetCharacter_and_QueueRenderToTexture_UInt32_Out_Character_Boolean.Invoke(___genericsType, ___parameters);
			character = (UnityEngine.TextCore.Text.Character)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual void TryAddGlyphsToAtlasTextures()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTryAddGlyphsToAtlasTextures.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryAddGlyphsToNewAtlasTexture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTryAddGlyphsToNewAtlasTexture.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetupNewAtlasTexture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetupNewAtlasTexture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateAllFontFeatures()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateAllFontFeatures.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateGlyphAdjustmentRecords()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateGlyphAdjustmentRecords.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateGlyphAdjustmentRecords(System.UInt32[]  @glyphIndexes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@glyphIndexes};
            var ___result = RUpdateGlyphAdjustmentRecords_UInt32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<System.UInt32>  @glyphIndexes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@glyphIndexes};
            var ___result = RUpdateGlyphAdjustmentRecords_List_d_UInt32_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<System.UInt32>  @newGlyphIndexes, System.Collections.Generic.List<System.UInt32>  @allGlyphIndexes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newGlyphIndexes, @allGlyphIndexes};
            var ___result = RUpdateGlyphAdjustmentRecords_List_d_UInt32_p__List_d_UInt32_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyListDataToArray<T>(System.Collections.Generic.List<T>  @srcList, ref T[]  @dstArray)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@srcList, @dstArray};
            var ___result = RCopyListDataToArray_GT_List_d_T_p__Ref_TArray.Invoke(___genericsType, ___parameters);
			dstArray = (T[])___parameters[1];

            
        }


        public virtual void ClearFontAssetData(System.Boolean  @setAtlasSizeToZero)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@setAtlasSizeToZero};
            var ___result = RClearFontAssetData_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearFontAssetDataInternal(System.Boolean  @clearFontFeatures)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clearFontFeatures};
            var ___result = RClearFontAssetDataInternal_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateFontAssetData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateFontAssetData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearFontAssetTables(System.Boolean  @clearFontFeatures)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clearFontFeatures};
            var ___result = RClearFontAssetTables_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearAtlasTextures(System.Boolean  @setAtlasSizeToZero)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@setAtlasSizeToZero};
            var ___result = RClearAtlasTextures_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DestroyAtlasTextures()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDestroyAtlasTextures.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetDirty.Invoke(___genericsType, ___parameters);

            
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
