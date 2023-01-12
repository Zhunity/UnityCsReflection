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
		protected RSystem.RString r_Fm_SourceFontFileGUID;
		public virtual RSystem.RString RFm_SourceFontFileGUID
		{
			get
			{
				if(r_Fm_SourceFontFileGUID == null)
				{
					r_Fm_SourceFontFileGUID = new(this, "m_SourceFontFileGUID");
					r_Fm_SourceFontFileGUID.SetBelong(this.instance);
				}
				return r_Fm_SourceFontFileGUID;
			}
		}

		/// <summary>
		/// UnityEngine.Font m_SourceFontFile_EditorRef
		/// </summary>
		protected RUnityEngine.RFont r_Fm_SourceFontFile_EditorRef;
		public virtual RUnityEngine.RFont RFm_SourceFontFile_EditorRef
		{
			get
			{
				if(r_Fm_SourceFontFile_EditorRef == null)
				{
					r_Fm_SourceFontFile_EditorRef = new(this, "m_SourceFontFile_EditorRef");
					r_Fm_SourceFontFile_EditorRef.SetBelong(this.instance);
				}
				return r_Fm_SourceFontFile_EditorRef;
			}
		}

		/// <summary>
		/// UnityEngine.Font m_SourceFontFile
		/// </summary>
		protected RUnityEngine.RFont r_Fm_SourceFontFile;
		public virtual RUnityEngine.RFont RFm_SourceFontFile
		{
			get
			{
				if(r_Fm_SourceFontFile == null)
				{
					r_Fm_SourceFontFile = new(this, "m_SourceFontFile");
					r_Fm_SourceFontFile.SetBelong(this.instance);
				}
				return r_Fm_SourceFontFile;
			}
		}

		/// <summary>
		/// System.String m_SourceFontFilePath
		/// </summary>
		protected RSystem.RString r_Fm_SourceFontFilePath;
		public virtual RSystem.RString RFm_SourceFontFilePath
		{
			get
			{
				if(r_Fm_SourceFontFilePath == null)
				{
					r_Fm_SourceFontFilePath = new(this, "m_SourceFontFilePath");
					r_Fm_SourceFontFilePath.SetBelong(this.instance);
				}
				return r_Fm_SourceFontFilePath;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.AtlasPopulationMode m_AtlasPopulationMode
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RAtlasPopulationMode r_Fm_AtlasPopulationMode;
		public virtual RUnityEngine.RTextCore.RText.RAtlasPopulationMode RFm_AtlasPopulationMode
		{
			get
			{
				if(r_Fm_AtlasPopulationMode == null)
				{
					r_Fm_AtlasPopulationMode = new(this, "m_AtlasPopulationMode");
					r_Fm_AtlasPopulationMode.SetBelong(this.instance);
				}
				return r_Fm_AtlasPopulationMode;
			}
		}

		/// <summary>
		/// System.Boolean InternalDynamicOS
		/// </summary>
		protected RSystem.RBoolean r_FInternalDynamicOS;
		public virtual RSystem.RBoolean RFInternalDynamicOS
		{
			get
			{
				if(r_FInternalDynamicOS == null)
				{
					r_FInternalDynamicOS = new(this, "InternalDynamicOS");
					r_FInternalDynamicOS.SetBelong(this.instance);
				}
				return r_FInternalDynamicOS;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.FaceInfo m_FaceInfo
		/// </summary>
		protected RUnityEngine.RTextCore.RFaceInfo r_Fm_FaceInfo;
		public virtual RUnityEngine.RTextCore.RFaceInfo RFm_FaceInfo
		{
			get
			{
				if(r_Fm_FaceInfo == null)
				{
					r_Fm_FaceInfo = new(this, "m_FaceInfo");
					r_Fm_FaceInfo.SetBelong(this.instance);
				}
				return r_Fm_FaceInfo;
			}
		}

		/// <summary>
		/// System.Int32 m_FamilyNameHashCode
		/// </summary>
		protected RSystem.RInt32 r_Fm_FamilyNameHashCode;
		public virtual RSystem.RInt32 RFm_FamilyNameHashCode
		{
			get
			{
				if(r_Fm_FamilyNameHashCode == null)
				{
					r_Fm_FamilyNameHashCode = new(this, "m_FamilyNameHashCode");
					r_Fm_FamilyNameHashCode.SetBelong(this.instance);
				}
				return r_Fm_FamilyNameHashCode;
			}
		}

		/// <summary>
		/// System.Int32 m_StyleNameHashCode
		/// </summary>
		protected RSystem.RInt32 r_Fm_StyleNameHashCode;
		public virtual RSystem.RInt32 RFm_StyleNameHashCode
		{
			get
			{
				if(r_Fm_StyleNameHashCode == null)
				{
					r_Fm_StyleNameHashCode = new(this, "m_StyleNameHashCode");
					r_Fm_StyleNameHashCode.SetBelong(this.instance);
				}
				return r_Fm_StyleNameHashCode;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Glyph] m_GlyphTable
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyph> r_Fm_GlyphTable;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyph> RFm_GlyphTable
		{
			get
			{
				if(r_Fm_GlyphTable == null)
				{
					r_Fm_GlyphTable = new(this, "m_GlyphTable");
					r_Fm_GlyphTable.SetBelong(this.instance);
				}
				return r_Fm_GlyphTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.Glyph] m_GlyphLookupDictionary
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RUInt32, RUnityEngine.RTextCore.RGlyph> r_Fm_GlyphLookupDictionary;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RUInt32, RUnityEngine.RTextCore.RGlyph> RFm_GlyphLookupDictionary
		{
			get
			{
				if(r_Fm_GlyphLookupDictionary == null)
				{
					r_Fm_GlyphLookupDictionary = new(this, "m_GlyphLookupDictionary");
					r_Fm_GlyphLookupDictionary.SetBelong(this.instance);
				}
				return r_Fm_GlyphLookupDictionary;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.Character] m_CharacterTable
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RCharacter> r_Fm_CharacterTable;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RCharacter> RFm_CharacterTable
		{
			get
			{
				if(r_Fm_CharacterTable == null)
				{
					r_Fm_CharacterTable = new(this, "m_CharacterTable");
					r_Fm_CharacterTable.SetBelong(this.instance);
				}
				return r_Fm_CharacterTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.Text.Character] m_CharacterLookupDictionary
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RUInt32, RUnityEngine.RTextCore.RText.RCharacter> r_Fm_CharacterLookupDictionary;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RUInt32, RUnityEngine.RTextCore.RText.RCharacter> RFm_CharacterLookupDictionary
		{
			get
			{
				if(r_Fm_CharacterLookupDictionary == null)
				{
					r_Fm_CharacterLookupDictionary = new(this, "m_CharacterLookupDictionary");
					r_Fm_CharacterLookupDictionary.SetBelong(this.instance);
				}
				return r_Fm_CharacterLookupDictionary;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D m_AtlasTexture
		/// </summary>
		protected RUnityEngine.RTexture2D r_Fm_AtlasTexture;
		public virtual RUnityEngine.RTexture2D RFm_AtlasTexture
		{
			get
			{
				if(r_Fm_AtlasTexture == null)
				{
					r_Fm_AtlasTexture = new(this, "m_AtlasTexture");
					r_Fm_AtlasTexture.SetBelong(this.instance);
				}
				return r_Fm_AtlasTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D[] m_AtlasTextures
		/// </summary>
		protected RFieldArray<RUnityEngine.RTexture2D> r_Fm_AtlasTextures;
		public virtual RFieldArray<RUnityEngine.RTexture2D> RFm_AtlasTextures
		{
			get
			{
				if(r_Fm_AtlasTextures == null)
				{
					r_Fm_AtlasTextures = new(this, "m_AtlasTextures");
					r_Fm_AtlasTextures.SetBelong(this.instance);
				}
				return r_Fm_AtlasTextures;
			}
		}

		/// <summary>
		/// System.Int32 m_AtlasTextureIndex
		/// </summary>
		protected RSystem.RInt32 r_Fm_AtlasTextureIndex;
		public virtual RSystem.RInt32 RFm_AtlasTextureIndex
		{
			get
			{
				if(r_Fm_AtlasTextureIndex == null)
				{
					r_Fm_AtlasTextureIndex = new(this, "m_AtlasTextureIndex");
					r_Fm_AtlasTextureIndex.SetBelong(this.instance);
				}
				return r_Fm_AtlasTextureIndex;
			}
		}

		/// <summary>
		/// System.Boolean m_IsMultiAtlasTexturesEnabled
		/// </summary>
		protected RSystem.RBoolean r_Fm_IsMultiAtlasTexturesEnabled;
		public virtual RSystem.RBoolean RFm_IsMultiAtlasTexturesEnabled
		{
			get
			{
				if(r_Fm_IsMultiAtlasTexturesEnabled == null)
				{
					r_Fm_IsMultiAtlasTexturesEnabled = new(this, "m_IsMultiAtlasTexturesEnabled");
					r_Fm_IsMultiAtlasTexturesEnabled.SetBelong(this.instance);
				}
				return r_Fm_IsMultiAtlasTexturesEnabled;
			}
		}

		/// <summary>
		/// System.Boolean m_ClearDynamicDataOnBuild
		/// </summary>
		protected RSystem.RBoolean r_Fm_ClearDynamicDataOnBuild;
		public virtual RSystem.RBoolean RFm_ClearDynamicDataOnBuild
		{
			get
			{
				if(r_Fm_ClearDynamicDataOnBuild == null)
				{
					r_Fm_ClearDynamicDataOnBuild = new(this, "m_ClearDynamicDataOnBuild");
					r_Fm_ClearDynamicDataOnBuild.SetBelong(this.instance);
				}
				return r_Fm_ClearDynamicDataOnBuild;
			}
		}

		/// <summary>
		/// System.Int32 m_AtlasWidth
		/// </summary>
		protected RSystem.RInt32 r_Fm_AtlasWidth;
		public virtual RSystem.RInt32 RFm_AtlasWidth
		{
			get
			{
				if(r_Fm_AtlasWidth == null)
				{
					r_Fm_AtlasWidth = new(this, "m_AtlasWidth");
					r_Fm_AtlasWidth.SetBelong(this.instance);
				}
				return r_Fm_AtlasWidth;
			}
		}

		/// <summary>
		/// System.Int32 m_AtlasHeight
		/// </summary>
		protected RSystem.RInt32 r_Fm_AtlasHeight;
		public virtual RSystem.RInt32 RFm_AtlasHeight
		{
			get
			{
				if(r_Fm_AtlasHeight == null)
				{
					r_Fm_AtlasHeight = new(this, "m_AtlasHeight");
					r_Fm_AtlasHeight.SetBelong(this.instance);
				}
				return r_Fm_AtlasHeight;
			}
		}

		/// <summary>
		/// System.Int32 m_AtlasPadding
		/// </summary>
		protected RSystem.RInt32 r_Fm_AtlasPadding;
		public virtual RSystem.RInt32 RFm_AtlasPadding
		{
			get
			{
				if(r_Fm_AtlasPadding == null)
				{
					r_Fm_AtlasPadding = new(this, "m_AtlasPadding");
					r_Fm_AtlasPadding.SetBelong(this.instance);
				}
				return r_Fm_AtlasPadding;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphRenderMode m_AtlasRenderMode
		/// </summary>
		protected RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode r_Fm_AtlasRenderMode;
		public virtual RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode RFm_AtlasRenderMode
		{
			get
			{
				if(r_Fm_AtlasRenderMode == null)
				{
					r_Fm_AtlasRenderMode = new(this, "m_AtlasRenderMode");
					r_Fm_AtlasRenderMode.SetBelong(this.instance);
				}
				return r_Fm_AtlasRenderMode;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.GlyphRect] m_UsedGlyphRects
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyphRect> r_Fm_UsedGlyphRects;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyphRect> RFm_UsedGlyphRects
		{
			get
			{
				if(r_Fm_UsedGlyphRects == null)
				{
					r_Fm_UsedGlyphRects = new(this, "m_UsedGlyphRects");
					r_Fm_UsedGlyphRects.SetBelong(this.instance);
				}
				return r_Fm_UsedGlyphRects;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.GlyphRect] m_FreeGlyphRects
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyphRect> r_Fm_FreeGlyphRects;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyphRect> RFm_FreeGlyphRects
		{
			get
			{
				if(r_Fm_FreeGlyphRects == null)
				{
					r_Fm_FreeGlyphRects = new(this, "m_FreeGlyphRects");
					r_Fm_FreeGlyphRects.SetBelong(this.instance);
				}
				return r_Fm_FreeGlyphRects;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontFeatureTable m_FontFeatureTable
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RFontFeatureTable r_Fm_FontFeatureTable;
		public virtual RUnityEngine.RTextCore.RText.RFontFeatureTable RFm_FontFeatureTable
		{
			get
			{
				if(r_Fm_FontFeatureTable == null)
				{
					r_Fm_FontFeatureTable = new(this, "m_FontFeatureTable");
					r_Fm_FontFeatureTable.SetBelong(this.instance);
				}
				return r_Fm_FontFeatureTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.FontAsset] m_FallbackFontAssetTable
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RFontAsset> r_Fm_FallbackFontAssetTable;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RFontAsset> RFm_FallbackFontAssetTable
		{
			get
			{
				if(r_Fm_FallbackFontAssetTable == null)
				{
					r_Fm_FallbackFontAssetTable = new(this, "m_FallbackFontAssetTable");
					r_Fm_FallbackFontAssetTable.SetBelong(this.instance);
				}
				return r_Fm_FallbackFontAssetTable;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RFontAssetCreationEditorSettings r_Fm_fontAssetCreationEditorSettings;
		public virtual RUnityEngine.RTextCore.RText.RFontAssetCreationEditorSettings RFm_fontAssetCreationEditorSettings
		{
			get
			{
				if(r_Fm_fontAssetCreationEditorSettings == null)
				{
					r_Fm_fontAssetCreationEditorSettings = new(this, "m_fontAssetCreationEditorSettings");
					r_Fm_fontAssetCreationEditorSettings.SetBelong(this.instance);
				}
				return r_Fm_fontAssetCreationEditorSettings;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontWeightPair[] m_FontWeightTable
		/// </summary>
		protected RFieldArray<RUnityEngine.RTextCore.RText.RFontWeightPair> r_Fm_FontWeightTable;
		public virtual RFieldArray<RUnityEngine.RTextCore.RText.RFontWeightPair> RFm_FontWeightTable
		{
			get
			{
				if(r_Fm_FontWeightTable == null)
				{
					r_Fm_FontWeightTable = new(this, "m_FontWeightTable");
					r_Fm_FontWeightTable.SetBelong(this.instance);
				}
				return r_Fm_FontWeightTable;
			}
		}

		/// <summary>
		/// System.Single m_RegularStyleWeight
		/// </summary>
		protected RSystem.RSingle r_Fm_RegularStyleWeight;
		public virtual RSystem.RSingle RFm_RegularStyleWeight
		{
			get
			{
				if(r_Fm_RegularStyleWeight == null)
				{
					r_Fm_RegularStyleWeight = new(this, "m_RegularStyleWeight");
					r_Fm_RegularStyleWeight.SetBelong(this.instance);
				}
				return r_Fm_RegularStyleWeight;
			}
		}

		/// <summary>
		/// System.Single m_RegularStyleSpacing
		/// </summary>
		protected RSystem.RSingle r_Fm_RegularStyleSpacing;
		public virtual RSystem.RSingle RFm_RegularStyleSpacing
		{
			get
			{
				if(r_Fm_RegularStyleSpacing == null)
				{
					r_Fm_RegularStyleSpacing = new(this, "m_RegularStyleSpacing");
					r_Fm_RegularStyleSpacing.SetBelong(this.instance);
				}
				return r_Fm_RegularStyleSpacing;
			}
		}

		/// <summary>
		/// System.Single m_BoldStyleWeight
		/// </summary>
		protected RSystem.RSingle r_Fm_BoldStyleWeight;
		public virtual RSystem.RSingle RFm_BoldStyleWeight
		{
			get
			{
				if(r_Fm_BoldStyleWeight == null)
				{
					r_Fm_BoldStyleWeight = new(this, "m_BoldStyleWeight");
					r_Fm_BoldStyleWeight.SetBelong(this.instance);
				}
				return r_Fm_BoldStyleWeight;
			}
		}

		/// <summary>
		/// System.Single m_BoldStyleSpacing
		/// </summary>
		protected RSystem.RSingle r_Fm_BoldStyleSpacing;
		public virtual RSystem.RSingle RFm_BoldStyleSpacing
		{
			get
			{
				if(r_Fm_BoldStyleSpacing == null)
				{
					r_Fm_BoldStyleSpacing = new(this, "m_BoldStyleSpacing");
					r_Fm_BoldStyleSpacing.SetBelong(this.instance);
				}
				return r_Fm_BoldStyleSpacing;
			}
		}

		/// <summary>
		/// System.Byte m_ItalicStyleSlant
		/// </summary>
		protected RSystem.RByte r_Fm_ItalicStyleSlant;
		public virtual RSystem.RByte RFm_ItalicStyleSlant
		{
			get
			{
				if(r_Fm_ItalicStyleSlant == null)
				{
					r_Fm_ItalicStyleSlant = new(this, "m_ItalicStyleSlant");
					r_Fm_ItalicStyleSlant.SetBelong(this.instance);
				}
				return r_Fm_ItalicStyleSlant;
			}
		}

		/// <summary>
		/// System.Byte m_TabMultiple
		/// </summary>
		protected RSystem.RByte r_Fm_TabMultiple;
		public virtual RSystem.RByte RFm_TabMultiple
		{
			get
			{
				if(r_Fm_TabMultiple == null)
				{
					r_Fm_TabMultiple = new(this, "m_TabMultiple");
					r_Fm_TabMultiple.SetBelong(this.instance);
				}
				return r_Fm_TabMultiple;
			}
		}

		/// <summary>
		/// System.Boolean IsFontAssetLookupTablesDirty
		/// </summary>
		protected RSystem.RBoolean r_FIsFontAssetLookupTablesDirty;
		public virtual RSystem.RBoolean RFIsFontAssetLookupTablesDirty
		{
			get
			{
				if(r_FIsFontAssetLookupTablesDirty == null)
				{
					r_FIsFontAssetLookupTablesDirty = new(this, "IsFontAssetLookupTablesDirty");
					r_FIsFontAssetLookupTablesDirty.SetBelong(this.instance);
				}
				return r_FIsFontAssetLookupTablesDirty;
			}
		}

		/// <summary>
		/// System.Action`2[UnityEngine.Texture,UnityEngine.TextCore.Text.FontAsset] OnFontAssetTextureChanged
		/// </summary>
		protected static RSystem.RAction<RUnityEngine.RTexture, RUnityEngine.RTextCore.RText.RFontAsset> r_FOnFontAssetTextureChanged;
		public static RSystem.RAction<RUnityEngine.RTexture, RUnityEngine.RTextCore.RText.RFontAsset> RFOnFontAssetTextureChanged
		{
			get
			{
				if(r_FOnFontAssetTextureChanged == null)
				{
					r_FOnFontAssetTextureChanged = new(typeof(UnityEngine.TextCore.Text.FontAsset), "OnFontAssetTextureChanged");
					r_FOnFontAssetTextureChanged.SetBelong(null);
				}
				return r_FOnFontAssetTextureChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.TextCore.Text.FontAsset] RegisterResourceForUpdate
		/// </summary>
		protected static RSystem.RAction<RUnityEngine.RTextCore.RText.RFontAsset> r_FRegisterResourceForUpdate;
		public static RSystem.RAction<RUnityEngine.RTextCore.RText.RFontAsset> RFRegisterResourceForUpdate
		{
			get
			{
				if(r_FRegisterResourceForUpdate == null)
				{
					r_FRegisterResourceForUpdate = new(typeof(UnityEngine.TextCore.Text.FontAsset), "RegisterResourceForUpdate");
					r_FRegisterResourceForUpdate.SetBelong(null);
				}
				return r_FRegisterResourceForUpdate;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.TextCore.Text.FontAsset] RegisterResourceForReimport
		/// </summary>
		protected static RSystem.RAction<RUnityEngine.RTextCore.RText.RFontAsset> r_FRegisterResourceForReimport;
		public static RSystem.RAction<RUnityEngine.RTextCore.RText.RFontAsset> RFRegisterResourceForReimport
		{
			get
			{
				if(r_FRegisterResourceForReimport == null)
				{
					r_FRegisterResourceForReimport = new(typeof(UnityEngine.TextCore.Text.FontAsset), "RegisterResourceForReimport");
					r_FRegisterResourceForReimport.SetBelong(null);
				}
				return r_FRegisterResourceForReimport;
			}
		}

		/// <summary>
		/// System.Action`2[UnityEngine.Texture2D,System.Boolean] SetAtlasTextureIsReadable
		/// </summary>
		protected static RSystem.RAction<RUnityEngine.RTexture2D, RSystem.RBoolean> r_FSetAtlasTextureIsReadable;
		public static RSystem.RAction<RUnityEngine.RTexture2D, RSystem.RBoolean> RFSetAtlasTextureIsReadable
		{
			get
			{
				if(r_FSetAtlasTextureIsReadable == null)
				{
					r_FSetAtlasTextureIsReadable = new(typeof(UnityEngine.TextCore.Text.FontAsset), "SetAtlasTextureIsReadable");
					r_FSetAtlasTextureIsReadable.SetBelong(null);
				}
				return r_FSetAtlasTextureIsReadable;
			}
		}

		/// <summary>
		/// System.Func`2[System.String,UnityEngine.Font] GetSourceFontRef
		/// </summary>
		protected static RSystem.RFunc<RSystem.RString, RUnityEngine.RFont> r_FGetSourceFontRef;
		public static RSystem.RFunc<RSystem.RString, RUnityEngine.RFont> RFGetSourceFontRef
		{
			get
			{
				if(r_FGetSourceFontRef == null)
				{
					r_FGetSourceFontRef = new(typeof(UnityEngine.TextCore.Text.FontAsset), "GetSourceFontRef");
					r_FGetSourceFontRef.SetBelong(null);
				}
				return r_FGetSourceFontRef;
			}
		}

		/// <summary>
		/// System.Func`2[UnityEngine.Font,System.String] SetSourceFontGUID
		/// </summary>
		protected static RSystem.RFunc<RUnityEngine.RFont, RSystem.RString> r_FSetSourceFontGUID;
		public static RSystem.RFunc<RUnityEngine.RFont, RSystem.RString> RFSetSourceFontGUID
		{
			get
			{
				if(r_FSetSourceFontGUID == null)
				{
					r_FSetSourceFontGUID = new(typeof(UnityEngine.TextCore.Text.FontAsset), "SetSourceFontGUID");
					r_FSetSourceFontGUID.SetBelong(null);
				}
				return r_FSetSourceFontGUID;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_ReadFontAssetDefinitionMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_Fk_ReadFontAssetDefinitionMarker;
		public static RUnity.RProfiling.RProfilerMarker RFk_ReadFontAssetDefinitionMarker
		{
			get
			{
				if(r_Fk_ReadFontAssetDefinitionMarker == null)
				{
					r_Fk_ReadFontAssetDefinitionMarker = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_ReadFontAssetDefinitionMarker");
					r_Fk_ReadFontAssetDefinitionMarker.SetBelong(null);
				}
				return r_Fk_ReadFontAssetDefinitionMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_AddSynthesizedCharactersMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_Fk_AddSynthesizedCharactersMarker;
		public static RUnity.RProfiling.RProfilerMarker RFk_AddSynthesizedCharactersMarker
		{
			get
			{
				if(r_Fk_AddSynthesizedCharactersMarker == null)
				{
					r_Fk_AddSynthesizedCharactersMarker = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_AddSynthesizedCharactersMarker");
					r_Fk_AddSynthesizedCharactersMarker.SetBelong(null);
				}
				return r_Fk_AddSynthesizedCharactersMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_TryAddCharacterMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_Fk_TryAddCharacterMarker;
		public static RUnity.RProfiling.RProfilerMarker RFk_TryAddCharacterMarker
		{
			get
			{
				if(r_Fk_TryAddCharacterMarker == null)
				{
					r_Fk_TryAddCharacterMarker = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_TryAddCharacterMarker");
					r_Fk_TryAddCharacterMarker.SetBelong(null);
				}
				return r_Fk_TryAddCharacterMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_TryAddCharactersMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_Fk_TryAddCharactersMarker;
		public static RUnity.RProfiling.RProfilerMarker RFk_TryAddCharactersMarker
		{
			get
			{
				if(r_Fk_TryAddCharactersMarker == null)
				{
					r_Fk_TryAddCharactersMarker = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_TryAddCharactersMarker");
					r_Fk_TryAddCharactersMarker.SetBelong(null);
				}
				return r_Fk_TryAddCharactersMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_Fk_UpdateGlyphAdjustmentRecordsMarker;
		public static RUnity.RProfiling.RProfilerMarker RFk_UpdateGlyphAdjustmentRecordsMarker
		{
			get
			{
				if(r_Fk_UpdateGlyphAdjustmentRecordsMarker == null)
				{
					r_Fk_UpdateGlyphAdjustmentRecordsMarker = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_UpdateGlyphAdjustmentRecordsMarker");
					r_Fk_UpdateGlyphAdjustmentRecordsMarker.SetBelong(null);
				}
				return r_Fk_UpdateGlyphAdjustmentRecordsMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_Fk_UpdateDiacriticalMarkAdjustmentRecordsMarker;
		public static RUnity.RProfiling.RProfilerMarker RFk_UpdateDiacriticalMarkAdjustmentRecordsMarker
		{
			get
			{
				if(r_Fk_UpdateDiacriticalMarkAdjustmentRecordsMarker == null)
				{
					r_Fk_UpdateDiacriticalMarkAdjustmentRecordsMarker = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_UpdateDiacriticalMarkAdjustmentRecordsMarker");
					r_Fk_UpdateDiacriticalMarkAdjustmentRecordsMarker.SetBelong(null);
				}
				return r_Fk_UpdateDiacriticalMarkAdjustmentRecordsMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_ClearFontAssetDataMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_Fk_ClearFontAssetDataMarker;
		public static RUnity.RProfiling.RProfilerMarker RFk_ClearFontAssetDataMarker
		{
			get
			{
				if(r_Fk_ClearFontAssetDataMarker == null)
				{
					r_Fk_ClearFontAssetDataMarker = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_ClearFontAssetDataMarker");
					r_Fk_ClearFontAssetDataMarker.SetBelong(null);
				}
				return r_Fk_ClearFontAssetDataMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_UpdateFontAssetDataMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_Fk_UpdateFontAssetDataMarker;
		public static RUnity.RProfiling.RProfilerMarker RFk_UpdateFontAssetDataMarker
		{
			get
			{
				if(r_Fk_UpdateFontAssetDataMarker == null)
				{
					r_Fk_UpdateFontAssetDataMarker = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_UpdateFontAssetDataMarker");
					r_Fk_UpdateFontAssetDataMarker.SetBelong(null);
				}
				return r_Fk_UpdateFontAssetDataMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_TryAddGlyphMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_Fk_TryAddGlyphMarker;
		public static RUnity.RProfiling.RProfilerMarker RFk_TryAddGlyphMarker
		{
			get
			{
				if(r_Fk_TryAddGlyphMarker == null)
				{
					r_Fk_TryAddGlyphMarker = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_TryAddGlyphMarker");
					r_Fk_TryAddGlyphMarker.SetBelong(null);
				}
				return r_Fk_TryAddGlyphMarker;
			}
		}

		/// <summary>
		/// System.String s_DefaultMaterialSuffix
		/// </summary>
		protected static RSystem.RString r_Fs_DefaultMaterialSuffix;
		public static RSystem.RString RFs_DefaultMaterialSuffix
		{
			get
			{
				if(r_Fs_DefaultMaterialSuffix == null)
				{
					r_Fs_DefaultMaterialSuffix = new(typeof(UnityEngine.TextCore.Text.FontAsset), "s_DefaultMaterialSuffix");
					r_Fs_DefaultMaterialSuffix.SetBelong(null);
				}
				return r_Fs_DefaultMaterialSuffix;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.Int32] k_SearchedFontAssetLookup
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RHashSet<RSystem.RInt32> r_Fk_SearchedFontAssetLookup;
		public static RSystem.RCollections.RGeneric.RHashSet<RSystem.RInt32> RFk_SearchedFontAssetLookup
		{
			get
			{
				if(r_Fk_SearchedFontAssetLookup == null)
				{
					r_Fk_SearchedFontAssetLookup = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_SearchedFontAssetLookup");
					r_Fk_SearchedFontAssetLookup.SetBelong(null);
				}
				return r_Fk_SearchedFontAssetLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.FontAsset] k_FontAssets_FontFeaturesUpdateQueue
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RFontAsset> r_Fk_FontAssets_FontFeaturesUpdateQueue;
		public static RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RFontAsset> RFk_FontAssets_FontFeaturesUpdateQueue
		{
			get
			{
				if(r_Fk_FontAssets_FontFeaturesUpdateQueue == null)
				{
					r_Fk_FontAssets_FontFeaturesUpdateQueue = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_FontAssets_FontFeaturesUpdateQueue");
					r_Fk_FontAssets_FontFeaturesUpdateQueue.SetBelong(null);
				}
				return r_Fk_FontAssets_FontFeaturesUpdateQueue;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.Int32] k_FontAssets_FontFeaturesUpdateQueueLookup
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RHashSet<RSystem.RInt32> r_Fk_FontAssets_FontFeaturesUpdateQueueLookup;
		public static RSystem.RCollections.RGeneric.RHashSet<RSystem.RInt32> RFk_FontAssets_FontFeaturesUpdateQueueLookup
		{
			get
			{
				if(r_Fk_FontAssets_FontFeaturesUpdateQueueLookup == null)
				{
					r_Fk_FontAssets_FontFeaturesUpdateQueueLookup = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_FontAssets_FontFeaturesUpdateQueueLookup");
					r_Fk_FontAssets_FontFeaturesUpdateQueueLookup.SetBelong(null);
				}
				return r_Fk_FontAssets_FontFeaturesUpdateQueueLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Texture2D] k_FontAssets_AtlasTexturesUpdateQueue
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RList<RUnityEngine.RTexture2D> r_Fk_FontAssets_AtlasTexturesUpdateQueue;
		public static RSystem.RCollections.RGeneric.RList<RUnityEngine.RTexture2D> RFk_FontAssets_AtlasTexturesUpdateQueue
		{
			get
			{
				if(r_Fk_FontAssets_AtlasTexturesUpdateQueue == null)
				{
					r_Fk_FontAssets_AtlasTexturesUpdateQueue = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_FontAssets_AtlasTexturesUpdateQueue");
					r_Fk_FontAssets_AtlasTexturesUpdateQueue.SetBelong(null);
				}
				return r_Fk_FontAssets_AtlasTexturesUpdateQueue;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.Int32] k_FontAssets_AtlasTexturesUpdateQueueLookup
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RHashSet<RSystem.RInt32> r_Fk_FontAssets_AtlasTexturesUpdateQueueLookup;
		public static RSystem.RCollections.RGeneric.RHashSet<RSystem.RInt32> RFk_FontAssets_AtlasTexturesUpdateQueueLookup
		{
			get
			{
				if(r_Fk_FontAssets_AtlasTexturesUpdateQueueLookup == null)
				{
					r_Fk_FontAssets_AtlasTexturesUpdateQueueLookup = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_FontAssets_AtlasTexturesUpdateQueueLookup");
					r_Fk_FontAssets_AtlasTexturesUpdateQueueLookup.SetBelong(null);
				}
				return r_Fk_FontAssets_AtlasTexturesUpdateQueueLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Glyph] m_GlyphsToRender
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyph> r_Fm_GlyphsToRender;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyph> RFm_GlyphsToRender
		{
			get
			{
				if(r_Fm_GlyphsToRender == null)
				{
					r_Fm_GlyphsToRender = new(this, "m_GlyphsToRender");
					r_Fm_GlyphsToRender.SetBelong(this.instance);
				}
				return r_Fm_GlyphsToRender;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Glyph] m_GlyphsRendered
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyph> r_Fm_GlyphsRendered;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyph> RFm_GlyphsRendered
		{
			get
			{
				if(r_Fm_GlyphsRendered == null)
				{
					r_Fm_GlyphsRendered = new(this, "m_GlyphsRendered");
					r_Fm_GlyphsRendered.SetBelong(this.instance);
				}
				return r_Fm_GlyphsRendered;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.UInt32] m_GlyphIndexList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RUInt32> r_Fm_GlyphIndexList;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RUInt32> RFm_GlyphIndexList
		{
			get
			{
				if(r_Fm_GlyphIndexList == null)
				{
					r_Fm_GlyphIndexList = new(this, "m_GlyphIndexList");
					r_Fm_GlyphIndexList.SetBelong(this.instance);
				}
				return r_Fm_GlyphIndexList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.UInt32] m_GlyphIndexListNewlyAdded
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RUInt32> r_Fm_GlyphIndexListNewlyAdded;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RUInt32> RFm_GlyphIndexListNewlyAdded
		{
			get
			{
				if(r_Fm_GlyphIndexListNewlyAdded == null)
				{
					r_Fm_GlyphIndexListNewlyAdded = new(this, "m_GlyphIndexListNewlyAdded");
					r_Fm_GlyphIndexListNewlyAdded.SetBelong(this.instance);
				}
				return r_Fm_GlyphIndexListNewlyAdded;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.UInt32] m_GlyphsToAdd
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RUInt32> r_Fm_GlyphsToAdd;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RUInt32> RFm_GlyphsToAdd
		{
			get
			{
				if(r_Fm_GlyphsToAdd == null)
				{
					r_Fm_GlyphsToAdd = new(this, "m_GlyphsToAdd");
					r_Fm_GlyphsToAdd.SetBelong(this.instance);
				}
				return r_Fm_GlyphsToAdd;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.UInt32] m_GlyphsToAddLookup
		/// </summary>
		protected RSystem.RCollections.RGeneric.RHashSet<RSystem.RUInt32> r_Fm_GlyphsToAddLookup;
		public virtual RSystem.RCollections.RGeneric.RHashSet<RSystem.RUInt32> RFm_GlyphsToAddLookup
		{
			get
			{
				if(r_Fm_GlyphsToAddLookup == null)
				{
					r_Fm_GlyphsToAddLookup = new(this, "m_GlyphsToAddLookup");
					r_Fm_GlyphsToAddLookup.SetBelong(this.instance);
				}
				return r_Fm_GlyphsToAddLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.Character] m_CharactersToAdd
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RCharacter> r_Fm_CharactersToAdd;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RCharacter> RFm_CharactersToAdd
		{
			get
			{
				if(r_Fm_CharactersToAdd == null)
				{
					r_Fm_CharactersToAdd = new(this, "m_CharactersToAdd");
					r_Fm_CharactersToAdd.SetBelong(this.instance);
				}
				return r_Fm_CharactersToAdd;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.UInt32] m_CharactersToAddLookup
		/// </summary>
		protected RSystem.RCollections.RGeneric.RHashSet<RSystem.RUInt32> r_Fm_CharactersToAddLookup;
		public virtual RSystem.RCollections.RGeneric.RHashSet<RSystem.RUInt32> RFm_CharactersToAddLookup
		{
			get
			{
				if(r_Fm_CharactersToAddLookup == null)
				{
					r_Fm_CharactersToAddLookup = new(this, "m_CharactersToAddLookup");
					r_Fm_CharactersToAddLookup.SetBelong(this.instance);
				}
				return r_Fm_CharactersToAddLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.UInt32] s_MissingCharacterList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RUInt32> r_Fs_MissingCharacterList;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RUInt32> RFs_MissingCharacterList
		{
			get
			{
				if(r_Fs_MissingCharacterList == null)
				{
					r_Fs_MissingCharacterList = new(this, "s_MissingCharacterList");
					r_Fs_MissingCharacterList.SetBelong(this.instance);
				}
				return r_Fs_MissingCharacterList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.UInt32] m_MissingUnicodesFromFontFile
		/// </summary>
		protected RSystem.RCollections.RGeneric.RHashSet<RSystem.RUInt32> r_Fm_MissingUnicodesFromFontFile;
		public virtual RSystem.RCollections.RGeneric.RHashSet<RSystem.RUInt32> RFm_MissingUnicodesFromFontFile
		{
			get
			{
				if(r_Fm_MissingUnicodesFromFontFile == null)
				{
					r_Fm_MissingUnicodesFromFontFile = new(this, "m_MissingUnicodesFromFontFile");
					r_Fm_MissingUnicodesFromFontFile.SetBelong(this.instance);
				}
				return r_Fm_MissingUnicodesFromFontFile;
			}
		}

		/// <summary>
		/// System.UInt32[] k_GlyphIndexArray
		/// </summary>
		protected static RFieldArray<RSystem.RUInt32> r_Fk_GlyphIndexArray;
		public static RFieldArray<RSystem.RUInt32> RFk_GlyphIndexArray
		{
			get
			{
				if(r_Fk_GlyphIndexArray == null)
				{
					r_Fk_GlyphIndexArray = new(typeof(UnityEngine.TextCore.Text.FontAsset), "k_GlyphIndexArray");
					r_Fk_GlyphIndexArray.SetBelong(null);
				}
				return r_Fk_GlyphIndexArray;
			}
		}

		/// <summary>
		/// System.String m_Version
		/// </summary>
		protected RSystem.RString r_Fm_Version;
		public virtual RSystem.RString RFm_Version
		{
			get
			{
				if(r_Fm_Version == null)
				{
					r_Fm_Version = new(this, "m_Version");
					r_Fm_Version.SetBelong(this.instance);
				}
				return r_Fm_Version;
			}
		}

		/// <summary>
		/// System.Int32 m_InstanceID
		/// </summary>
		protected RSystem.RInt32 r_Fm_InstanceID;
		public virtual RSystem.RInt32 RFm_InstanceID
		{
			get
			{
				if(r_Fm_InstanceID == null)
				{
					r_Fm_InstanceID = new(this, "m_InstanceID");
					r_Fm_InstanceID.SetBelong(this.instance);
				}
				return r_Fm_InstanceID;
			}
		}

		/// <summary>
		/// System.Int32 m_HashCode
		/// </summary>
		protected RSystem.RInt32 r_Fm_HashCode;
		public virtual RSystem.RInt32 RFm_HashCode
		{
			get
			{
				if(r_Fm_HashCode == null)
				{
					r_Fm_HashCode = new(this, "m_HashCode");
					r_Fm_HashCode.SetBelong(this.instance);
				}
				return r_Fm_HashCode;
			}
		}

		/// <summary>
		/// UnityEngine.Material m_Material
		/// </summary>
		protected RUnityEngine.RMaterial r_Fm_Material;
		public virtual RUnityEngine.RMaterial RFm_Material
		{
			get
			{
				if(r_Fm_Material == null)
				{
					r_Fm_Material = new(this, "m_Material");
					r_Fm_Material.SetBelong(this.instance);
				}
				return r_Fm_Material;
			}
		}

		/// <summary>
		/// System.Int32 m_MaterialHashCode
		/// </summary>
		protected RSystem.RInt32 r_Fm_MaterialHashCode;
		public virtual RSystem.RInt32 RFm_MaterialHashCode
		{
			get
			{
				if(r_Fm_MaterialHashCode == null)
				{
					r_Fm_MaterialHashCode = new(this, "m_MaterialHashCode");
					r_Fm_MaterialHashCode.SetBelong(this.instance);
				}
				return r_Fm_MaterialHashCode;
			}
		}

		/// <summary>
		/// UnityEngine.Font SourceFont_EditorRef
		/// </summary>
		protected RUnityEngine.RFont r_PSourceFont_EditorRef;
		public virtual RUnityEngine.RFont RPSourceFont_EditorRef
		{
			get
			{
				if(r_PSourceFont_EditorRef == null)
				{
					r_PSourceFont_EditorRef = new(this, "SourceFont_EditorRef", -1);
					r_PSourceFont_EditorRef.SetBelong(this.instance);
				}
				return r_PSourceFont_EditorRef;
			}
		}

		/// <summary>
		/// UnityEngine.Font sourceFontFile
		/// </summary>
		protected RUnityEngine.RFont r_PsourceFontFile;
		public virtual RUnityEngine.RFont RPsourceFontFile
		{
			get
			{
				if(r_PsourceFontFile == null)
				{
					r_PsourceFontFile = new(this, "sourceFontFile", -1);
					r_PsourceFontFile.SetBelong(this.instance);
				}
				return r_PsourceFontFile;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RAtlasPopulationMode r_PatlasPopulationMode;
		public virtual RUnityEngine.RTextCore.RText.RAtlasPopulationMode RPatlasPopulationMode
		{
			get
			{
				if(r_PatlasPopulationMode == null)
				{
					r_PatlasPopulationMode = new(this, "atlasPopulationMode", -1);
					r_PatlasPopulationMode.SetBelong(this.instance);
				}
				return r_PatlasPopulationMode;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.FaceInfo faceInfo
		/// </summary>
		protected RUnityEngine.RTextCore.RFaceInfo r_PfaceInfo;
		public virtual RUnityEngine.RTextCore.RFaceInfo RPfaceInfo
		{
			get
			{
				if(r_PfaceInfo == null)
				{
					r_PfaceInfo = new(this, "faceInfo", -1);
					r_PfaceInfo.SetBelong(this.instance);
				}
				return r_PfaceInfo;
			}
		}

		/// <summary>
		/// Int32 familyNameHashCode
		/// </summary>
		protected RSystem.RInt32 r_PfamilyNameHashCode;
		public virtual RSystem.RInt32 RPfamilyNameHashCode
		{
			get
			{
				if(r_PfamilyNameHashCode == null)
				{
					r_PfamilyNameHashCode = new(this, "familyNameHashCode", -1);
					r_PfamilyNameHashCode.SetBelong(this.instance);
				}
				return r_PfamilyNameHashCode;
			}
		}

		/// <summary>
		/// Int32 styleNameHashCode
		/// </summary>
		protected RSystem.RInt32 r_PstyleNameHashCode;
		public virtual RSystem.RInt32 RPstyleNameHashCode
		{
			get
			{
				if(r_PstyleNameHashCode == null)
				{
					r_PstyleNameHashCode = new(this, "styleNameHashCode", -1);
					r_PstyleNameHashCode.SetBelong(this.instance);
				}
				return r_PstyleNameHashCode;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Glyph] glyphTable
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyph> r_PglyphTable;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyph> RPglyphTable
		{
			get
			{
				if(r_PglyphTable == null)
				{
					r_PglyphTable = new(this, "glyphTable", -1);
					r_PglyphTable.SetBelong(this.instance);
				}
				return r_PglyphTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.Glyph] glyphLookupTable
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RUInt32, RUnityEngine.RTextCore.RGlyph> r_PglyphLookupTable;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RUInt32, RUnityEngine.RTextCore.RGlyph> RPglyphLookupTable
		{
			get
			{
				if(r_PglyphLookupTable == null)
				{
					r_PglyphLookupTable = new(this, "glyphLookupTable", -1);
					r_PglyphLookupTable.SetBelong(this.instance);
				}
				return r_PglyphLookupTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.Character] characterTable
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RCharacter> r_PcharacterTable;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RCharacter> RPcharacterTable
		{
			get
			{
				if(r_PcharacterTable == null)
				{
					r_PcharacterTable = new(this, "characterTable", -1);
					r_PcharacterTable.SetBelong(this.instance);
				}
				return r_PcharacterTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.Text.Character] characterLookupTable
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RUInt32, RUnityEngine.RTextCore.RText.RCharacter> r_PcharacterLookupTable;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RUInt32, RUnityEngine.RTextCore.RText.RCharacter> RPcharacterLookupTable
		{
			get
			{
				if(r_PcharacterLookupTable == null)
				{
					r_PcharacterLookupTable = new(this, "characterLookupTable", -1);
					r_PcharacterLookupTable.SetBelong(this.instance);
				}
				return r_PcharacterLookupTable;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D atlasTexture
		/// </summary>
		protected RUnityEngine.RTexture2D r_PatlasTexture;
		public virtual RUnityEngine.RTexture2D RPatlasTexture
		{
			get
			{
				if(r_PatlasTexture == null)
				{
					r_PatlasTexture = new(this, "atlasTexture", -1);
					r_PatlasTexture.SetBelong(this.instance);
				}
				return r_PatlasTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D[] atlasTextures
		/// </summary>
		protected RPropertyArray<RUnityEngine.RTexture2D> r_PatlasTextures;
		public virtual RPropertyArray<RUnityEngine.RTexture2D> RPatlasTextures
		{
			get
			{
				if(r_PatlasTextures == null)
				{
					r_PatlasTextures = new(this, "atlasTextures", -1);
					r_PatlasTextures.SetBelong(this.instance);
				}
				return r_PatlasTextures;
			}
		}

		/// <summary>
		/// Int32 atlasTextureCount
		/// </summary>
		protected RSystem.RInt32 r_PatlasTextureCount;
		public virtual RSystem.RInt32 RPatlasTextureCount
		{
			get
			{
				if(r_PatlasTextureCount == null)
				{
					r_PatlasTextureCount = new(this, "atlasTextureCount", -1);
					r_PatlasTextureCount.SetBelong(this.instance);
				}
				return r_PatlasTextureCount;
			}
		}

		/// <summary>
		/// Boolean isMultiAtlasTexturesEnabled
		/// </summary>
		protected RSystem.RBoolean r_PisMultiAtlasTexturesEnabled;
		public virtual RSystem.RBoolean RPisMultiAtlasTexturesEnabled
		{
			get
			{
				if(r_PisMultiAtlasTexturesEnabled == null)
				{
					r_PisMultiAtlasTexturesEnabled = new(this, "isMultiAtlasTexturesEnabled", -1);
					r_PisMultiAtlasTexturesEnabled.SetBelong(this.instance);
				}
				return r_PisMultiAtlasTexturesEnabled;
			}
		}

		/// <summary>
		/// Boolean clearDynamicDataOnBuild
		/// </summary>
		protected RSystem.RBoolean r_PclearDynamicDataOnBuild;
		public virtual RSystem.RBoolean RPclearDynamicDataOnBuild
		{
			get
			{
				if(r_PclearDynamicDataOnBuild == null)
				{
					r_PclearDynamicDataOnBuild = new(this, "clearDynamicDataOnBuild", -1);
					r_PclearDynamicDataOnBuild.SetBelong(this.instance);
				}
				return r_PclearDynamicDataOnBuild;
			}
		}

		/// <summary>
		/// Int32 atlasWidth
		/// </summary>
		protected RSystem.RInt32 r_PatlasWidth;
		public virtual RSystem.RInt32 RPatlasWidth
		{
			get
			{
				if(r_PatlasWidth == null)
				{
					r_PatlasWidth = new(this, "atlasWidth", -1);
					r_PatlasWidth.SetBelong(this.instance);
				}
				return r_PatlasWidth;
			}
		}

		/// <summary>
		/// Int32 atlasHeight
		/// </summary>
		protected RSystem.RInt32 r_PatlasHeight;
		public virtual RSystem.RInt32 RPatlasHeight
		{
			get
			{
				if(r_PatlasHeight == null)
				{
					r_PatlasHeight = new(this, "atlasHeight", -1);
					r_PatlasHeight.SetBelong(this.instance);
				}
				return r_PatlasHeight;
			}
		}

		/// <summary>
		/// Int32 atlasPadding
		/// </summary>
		protected RSystem.RInt32 r_PatlasPadding;
		public virtual RSystem.RInt32 RPatlasPadding
		{
			get
			{
				if(r_PatlasPadding == null)
				{
					r_PatlasPadding = new(this, "atlasPadding", -1);
					r_PatlasPadding.SetBelong(this.instance);
				}
				return r_PatlasPadding;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphRenderMode atlasRenderMode
		/// </summary>
		protected RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode r_PatlasRenderMode;
		public virtual RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode RPatlasRenderMode
		{
			get
			{
				if(r_PatlasRenderMode == null)
				{
					r_PatlasRenderMode = new(this, "atlasRenderMode", -1);
					r_PatlasRenderMode.SetBelong(this.instance);
				}
				return r_PatlasRenderMode;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.GlyphRect] usedGlyphRects
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyphRect> r_PusedGlyphRects;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyphRect> RPusedGlyphRects
		{
			get
			{
				if(r_PusedGlyphRects == null)
				{
					r_PusedGlyphRects = new(this, "usedGlyphRects", -1);
					r_PusedGlyphRects.SetBelong(this.instance);
				}
				return r_PusedGlyphRects;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.GlyphRect] freeGlyphRects
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyphRect> r_PfreeGlyphRects;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RGlyphRect> RPfreeGlyphRects
		{
			get
			{
				if(r_PfreeGlyphRects == null)
				{
					r_PfreeGlyphRects = new(this, "freeGlyphRects", -1);
					r_PfreeGlyphRects.SetBelong(this.instance);
				}
				return r_PfreeGlyphRects;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontFeatureTable fontFeatureTable
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RFontFeatureTable r_PfontFeatureTable;
		public virtual RUnityEngine.RTextCore.RText.RFontFeatureTable RPfontFeatureTable
		{
			get
			{
				if(r_PfontFeatureTable == null)
				{
					r_PfontFeatureTable = new(this, "fontFeatureTable", -1);
					r_PfontFeatureTable.SetBelong(this.instance);
				}
				return r_PfontFeatureTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.FontAsset] fallbackFontAssetTable
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RFontAsset> r_PfallbackFontAssetTable;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RFontAsset> RPfallbackFontAssetTable
		{
			get
			{
				if(r_PfallbackFontAssetTable == null)
				{
					r_PfallbackFontAssetTable = new(this, "fallbackFontAssetTable", -1);
					r_PfallbackFontAssetTable.SetBelong(this.instance);
				}
				return r_PfallbackFontAssetTable;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAssetCreationEditorSettings fontAssetCreationEditorSettings
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RFontAssetCreationEditorSettings r_PfontAssetCreationEditorSettings;
		public virtual RUnityEngine.RTextCore.RText.RFontAssetCreationEditorSettings RPfontAssetCreationEditorSettings
		{
			get
			{
				if(r_PfontAssetCreationEditorSettings == null)
				{
					r_PfontAssetCreationEditorSettings = new(this, "fontAssetCreationEditorSettings", -1);
					r_PfontAssetCreationEditorSettings.SetBelong(this.instance);
				}
				return r_PfontAssetCreationEditorSettings;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontWeightPair[] fontWeightTable
		/// </summary>
		protected RPropertyArray<RUnityEngine.RTextCore.RText.RFontWeightPair> r_PfontWeightTable;
		public virtual RPropertyArray<RUnityEngine.RTextCore.RText.RFontWeightPair> RPfontWeightTable
		{
			get
			{
				if(r_PfontWeightTable == null)
				{
					r_PfontWeightTable = new(this, "fontWeightTable", -1);
					r_PfontWeightTable.SetBelong(this.instance);
				}
				return r_PfontWeightTable;
			}
		}

		/// <summary>
		/// Single regularStyleWeight
		/// </summary>
		protected RSystem.RSingle r_PregularStyleWeight;
		public virtual RSystem.RSingle RPregularStyleWeight
		{
			get
			{
				if(r_PregularStyleWeight == null)
				{
					r_PregularStyleWeight = new(this, "regularStyleWeight", -1);
					r_PregularStyleWeight.SetBelong(this.instance);
				}
				return r_PregularStyleWeight;
			}
		}

		/// <summary>
		/// Single regularStyleSpacing
		/// </summary>
		protected RSystem.RSingle r_PregularStyleSpacing;
		public virtual RSystem.RSingle RPregularStyleSpacing
		{
			get
			{
				if(r_PregularStyleSpacing == null)
				{
					r_PregularStyleSpacing = new(this, "regularStyleSpacing", -1);
					r_PregularStyleSpacing.SetBelong(this.instance);
				}
				return r_PregularStyleSpacing;
			}
		}

		/// <summary>
		/// Single boldStyleWeight
		/// </summary>
		protected RSystem.RSingle r_PboldStyleWeight;
		public virtual RSystem.RSingle RPboldStyleWeight
		{
			get
			{
				if(r_PboldStyleWeight == null)
				{
					r_PboldStyleWeight = new(this, "boldStyleWeight", -1);
					r_PboldStyleWeight.SetBelong(this.instance);
				}
				return r_PboldStyleWeight;
			}
		}

		/// <summary>
		/// Single boldStyleSpacing
		/// </summary>
		protected RSystem.RSingle r_PboldStyleSpacing;
		public virtual RSystem.RSingle RPboldStyleSpacing
		{
			get
			{
				if(r_PboldStyleSpacing == null)
				{
					r_PboldStyleSpacing = new(this, "boldStyleSpacing", -1);
					r_PboldStyleSpacing.SetBelong(this.instance);
				}
				return r_PboldStyleSpacing;
			}
		}

		/// <summary>
		/// Byte italicStyleSlant
		/// </summary>
		protected RSystem.RByte r_PitalicStyleSlant;
		public virtual RSystem.RByte RPitalicStyleSlant
		{
			get
			{
				if(r_PitalicStyleSlant == null)
				{
					r_PitalicStyleSlant = new(this, "italicStyleSlant", -1);
					r_PitalicStyleSlant.SetBelong(this.instance);
				}
				return r_PitalicStyleSlant;
			}
		}

		/// <summary>
		/// Byte tabMultiple
		/// </summary>
		protected RSystem.RByte r_PtabMultiple;
		public virtual RSystem.RByte RPtabMultiple
		{
			get
			{
				if(r_PtabMultiple == null)
				{
					r_PtabMultiple = new(this, "tabMultiple", -1);
					r_PtabMultiple.SetBelong(this.instance);
				}
				return r_PtabMultiple;
			}
		}

		/// <summary>
		/// System.String version
		/// </summary>
		protected RSystem.RString r_Pversion;
		public virtual RSystem.RString RPversion
		{
			get
			{
				if(r_Pversion == null)
				{
					r_Pversion = new(this, "version", -1);
					r_Pversion.SetBelong(this.instance);
				}
				return r_Pversion;
			}
		}

		/// <summary>
		/// Int32 instanceID
		/// </summary>
		protected RSystem.RInt32 r_PinstanceID;
		public virtual RSystem.RInt32 RPinstanceID
		{
			get
			{
				if(r_PinstanceID == null)
				{
					r_PinstanceID = new(this, "instanceID", -1);
					r_PinstanceID.SetBelong(this.instance);
				}
				return r_PinstanceID;
			}
		}

		/// <summary>
		/// Int32 hashCode
		/// </summary>
		protected RSystem.RInt32 r_PhashCode;
		public virtual RSystem.RInt32 RPhashCode
		{
			get
			{
				if(r_PhashCode == null)
				{
					r_PhashCode = new(this, "hashCode", -1);
					r_PhashCode.SetBelong(this.instance);
				}
				return r_PhashCode;
			}
		}

		/// <summary>
		/// UnityEngine.Material material
		/// </summary>
		protected RUnityEngine.RMaterial r_Pmaterial;
		public virtual RUnityEngine.RMaterial RPmaterial
		{
			get
			{
				if(r_Pmaterial == null)
				{
					r_Pmaterial = new(this, "material", -1);
					r_Pmaterial.SetBelong(this.instance);
				}
				return r_Pmaterial;
			}
		}

		/// <summary>
		/// Int32 materialHashCode
		/// </summary>
		protected RSystem.RInt32 r_PmaterialHashCode;
		public virtual RSystem.RInt32 RPmaterialHashCode
		{
			get
			{
				if(r_PmaterialHashCode == null)
				{
					r_PmaterialHashCode = new(this, "materialHashCode", -1);
					r_PmaterialHashCode.SetBelong(this.instance);
				}
				return r_PmaterialHashCode;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RSystem.RString r_Pname;
		public virtual RSystem.RString RPname
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
		protected RUnityEngine.RHideFlags r_PhideFlags;
		public virtual RUnityEngine.RHideFlags RPhideFlags
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
		/// UnityEngine.TextCore.Text.FontAsset CreateFontAsset(System.String, System.String, Int32)
		/// </summary>
		protected static RMethod r_MCreateFontAsset_String_String_Int32;
		public static RMethod RMCreateFontAsset_String_String_Int32
		{
			get
			{
				if(r_MCreateFontAsset_String_String_Int32 == null)
				{
					r_MCreateFontAsset_String_String_Int32 = new(typeof(UnityEngine.TextCore.Text.FontAsset), "CreateFontAsset", 0, typeof(System.String), typeof(System.String), typeof(System.Int32));
					r_MCreateFontAsset_String_String_Int32.SetBelong(null);
				}
				return r_MCreateFontAsset_String_String_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAsset CreateFontAsset(System.String, Int32, Int32, Int32, UnityEngine.TextCore.LowLevel.GlyphRenderMode, Int32, Int32)
		/// </summary>
		protected static RMethod r_MCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32;
		public static RMethod RMCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32
		{
			get
			{
				if(r_MCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32 == null)
				{
					r_MCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32 = new(typeof(UnityEngine.TextCore.Text.FontAsset), "CreateFontAsset", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), typeof(System.Int32), typeof(System.Int32));
					r_MCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32.SetBelong(null);
				}
				return r_MCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAsset CreateFontAsset(System.String, Int32, Int32, Int32, UnityEngine.TextCore.LowLevel.GlyphRenderMode, Int32, Int32, UnityEngine.TextCore.Text.AtlasPopulationMode, Boolean)
		/// </summary>
		protected static RMethod r_MCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean;
		public static RMethod RMCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean
		{
			get
			{
				if(r_MCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean == null)
				{
					r_MCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean = new(typeof(UnityEngine.TextCore.Text.FontAsset), "CreateFontAsset", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextCore.Text.AtlasPopulationMode), typeof(System.Boolean));
					r_MCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean.SetBelong(null);
				}
				return r_MCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font)
		/// </summary>
		protected static RMethod r_MCreateFontAsset_Font;
		public static RMethod RMCreateFontAsset_Font
		{
			get
			{
				if(r_MCreateFontAsset_Font == null)
				{
					r_MCreateFontAsset_Font = new(typeof(UnityEngine.TextCore.Text.FontAsset), "CreateFontAsset", 0, typeof(UnityEngine.Font));
					r_MCreateFontAsset_Font.SetBelong(null);
				}
				return r_MCreateFontAsset_Font;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font, Int32, Int32, UnityEngine.TextCore.LowLevel.GlyphRenderMode, Int32, Int32, UnityEngine.TextCore.Text.AtlasPopulationMode, Boolean)
		/// </summary>
		protected static RMethod r_MCreateFontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean;
		public static RMethod RMCreateFontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean
		{
			get
			{
				if(r_MCreateFontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean == null)
				{
					r_MCreateFontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean = new(typeof(UnityEngine.TextCore.Text.FontAsset), "CreateFontAsset", 0, typeof(UnityEngine.Font), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextCore.Text.AtlasPopulationMode), typeof(System.Boolean));
					r_MCreateFontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean.SetBelong(null);
				}
				return r_MCreateFontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font, Int32, Int32, Int32, UnityEngine.TextCore.LowLevel.GlyphRenderMode, Int32, Int32, UnityEngine.TextCore.Text.AtlasPopulationMode, Boolean)
		/// </summary>
		protected static RMethod r_MCreateFontAsset_Font_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean;
		public static RMethod RMCreateFontAsset_Font_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean
		{
			get
			{
				if(r_MCreateFontAsset_Font_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean == null)
				{
					r_MCreateFontAsset_Font_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean = new(typeof(UnityEngine.TextCore.Text.FontAsset), "CreateFontAsset", 0, typeof(UnityEngine.Font), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextCore.Text.AtlasPopulationMode), typeof(System.Boolean));
					r_MCreateFontAsset_Font_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean.SetBelong(null);
				}
				return r_MCreateFontAsset_Font_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAsset CreateFontAssetInstance(UnityEngine.Font, Int32, UnityEngine.TextCore.LowLevel.GlyphRenderMode, Int32, Int32, UnityEngine.TextCore.Text.AtlasPopulationMode, Boolean)
		/// </summary>
		protected static RMethod r_MCreateFontAssetInstance_Font_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean;
		public static RMethod RMCreateFontAssetInstance_Font_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean
		{
			get
			{
				if(r_MCreateFontAssetInstance_Font_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean == null)
				{
					r_MCreateFontAssetInstance_Font_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean = new(typeof(UnityEngine.TextCore.Text.FontAsset), "CreateFontAssetInstance", 0, typeof(UnityEngine.Font), typeof(System.Int32), typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextCore.Text.AtlasPopulationMode), typeof(System.Boolean));
					r_MCreateFontAssetInstance_Font_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean.SetBelong(null);
				}
				return r_MCreateFontAssetInstance_Font_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean;
			}
		}

		/// <summary>
		/// Void Awake()
		/// </summary>
		protected RMethod r_MAwake;
		public virtual RMethod RMAwake
		{
			get
			{
				if(r_MAwake == null)
				{
					r_MAwake = new(this, "Awake", 0);
					r_MAwake.SetBelong(this.instance);
				}
				return r_MAwake;
			}
		}

		/// <summary>
		/// Void OnDestroy()
		/// </summary>
		protected RMethod r_MOnDestroy;
		public virtual RMethod RMOnDestroy
		{
			get
			{
				if(r_MOnDestroy == null)
				{
					r_MOnDestroy = new(this, "OnDestroy", 0);
					r_MOnDestroy.SetBelong(this.instance);
				}
				return r_MOnDestroy;
			}
		}

		/// <summary>
		/// Void OnValidate()
		/// </summary>
		protected RMethod r_MOnValidate;
		public virtual RMethod RMOnValidate
		{
			get
			{
				if(r_MOnValidate == null)
				{
					r_MOnValidate = new(this, "OnValidate", 0);
					r_MOnValidate.SetBelong(this.instance);
				}
				return r_MOnValidate;
			}
		}

		/// <summary>
		/// Void ReadFontAssetDefinition()
		/// </summary>
		protected RMethod r_MReadFontAssetDefinition;
		public virtual RMethod RMReadFontAssetDefinition
		{
			get
			{
				if(r_MReadFontAssetDefinition == null)
				{
					r_MReadFontAssetDefinition = new(this, "ReadFontAssetDefinition", 0);
					r_MReadFontAssetDefinition.SetBelong(this.instance);
				}
				return r_MReadFontAssetDefinition;
			}
		}

		/// <summary>
		/// Void InitializeDictionaryLookupTables()
		/// </summary>
		protected RMethod r_MInitializeDictionaryLookupTables;
		public virtual RMethod RMInitializeDictionaryLookupTables
		{
			get
			{
				if(r_MInitializeDictionaryLookupTables == null)
				{
					r_MInitializeDictionaryLookupTables = new(this, "InitializeDictionaryLookupTables", 0);
					r_MInitializeDictionaryLookupTables.SetBelong(this.instance);
				}
				return r_MInitializeDictionaryLookupTables;
			}
		}

		/// <summary>
		/// Void InitializeGlyphLookupDictionary()
		/// </summary>
		protected RMethod r_MInitializeGlyphLookupDictionary;
		public virtual RMethod RMInitializeGlyphLookupDictionary
		{
			get
			{
				if(r_MInitializeGlyphLookupDictionary == null)
				{
					r_MInitializeGlyphLookupDictionary = new(this, "InitializeGlyphLookupDictionary", 0);
					r_MInitializeGlyphLookupDictionary.SetBelong(this.instance);
				}
				return r_MInitializeGlyphLookupDictionary;
			}
		}

		/// <summary>
		/// Void InitializeCharacterLookupDictionary()
		/// </summary>
		protected RMethod r_MInitializeCharacterLookupDictionary;
		public virtual RMethod RMInitializeCharacterLookupDictionary
		{
			get
			{
				if(r_MInitializeCharacterLookupDictionary == null)
				{
					r_MInitializeCharacterLookupDictionary = new(this, "InitializeCharacterLookupDictionary", 0);
					r_MInitializeCharacterLookupDictionary.SetBelong(this.instance);
				}
				return r_MInitializeCharacterLookupDictionary;
			}
		}

		/// <summary>
		/// Void InitializeLigatureSubstitutionLookupDictionary()
		/// </summary>
		protected RMethod r_MInitializeLigatureSubstitutionLookupDictionary;
		public virtual RMethod RMInitializeLigatureSubstitutionLookupDictionary
		{
			get
			{
				if(r_MInitializeLigatureSubstitutionLookupDictionary == null)
				{
					r_MInitializeLigatureSubstitutionLookupDictionary = new(this, "InitializeLigatureSubstitutionLookupDictionary", 0);
					r_MInitializeLigatureSubstitutionLookupDictionary.SetBelong(this.instance);
				}
				return r_MInitializeLigatureSubstitutionLookupDictionary;
			}
		}

		/// <summary>
		/// Void InitializeGlyphPaidAdjustmentRecordsLookupDictionary()
		/// </summary>
		protected RMethod r_MInitializeGlyphPaidAdjustmentRecordsLookupDictionary;
		public virtual RMethod RMInitializeGlyphPaidAdjustmentRecordsLookupDictionary
		{
			get
			{
				if(r_MInitializeGlyphPaidAdjustmentRecordsLookupDictionary == null)
				{
					r_MInitializeGlyphPaidAdjustmentRecordsLookupDictionary = new(this, "InitializeGlyphPaidAdjustmentRecordsLookupDictionary", 0);
					r_MInitializeGlyphPaidAdjustmentRecordsLookupDictionary.SetBelong(this.instance);
				}
				return r_MInitializeGlyphPaidAdjustmentRecordsLookupDictionary;
			}
		}

		/// <summary>
		/// Void InitializeMarkToBaseAdjustmentRecordsLookupDictionary()
		/// </summary>
		protected RMethod r_MInitializeMarkToBaseAdjustmentRecordsLookupDictionary;
		public virtual RMethod RMInitializeMarkToBaseAdjustmentRecordsLookupDictionary
		{
			get
			{
				if(r_MInitializeMarkToBaseAdjustmentRecordsLookupDictionary == null)
				{
					r_MInitializeMarkToBaseAdjustmentRecordsLookupDictionary = new(this, "InitializeMarkToBaseAdjustmentRecordsLookupDictionary", 0);
					r_MInitializeMarkToBaseAdjustmentRecordsLookupDictionary.SetBelong(this.instance);
				}
				return r_MInitializeMarkToBaseAdjustmentRecordsLookupDictionary;
			}
		}

		/// <summary>
		/// Void InitializeMarkToMarkAdjustmentRecordsLookupDictionary()
		/// </summary>
		protected RMethod r_MInitializeMarkToMarkAdjustmentRecordsLookupDictionary;
		public virtual RMethod RMInitializeMarkToMarkAdjustmentRecordsLookupDictionary
		{
			get
			{
				if(r_MInitializeMarkToMarkAdjustmentRecordsLookupDictionary == null)
				{
					r_MInitializeMarkToMarkAdjustmentRecordsLookupDictionary = new(this, "InitializeMarkToMarkAdjustmentRecordsLookupDictionary", 0);
					r_MInitializeMarkToMarkAdjustmentRecordsLookupDictionary.SetBelong(this.instance);
				}
				return r_MInitializeMarkToMarkAdjustmentRecordsLookupDictionary;
			}
		}

		/// <summary>
		/// Void AddSynthesizedCharactersAndFaceMetrics()
		/// </summary>
		protected RMethod r_MAddSynthesizedCharactersAndFaceMetrics;
		public virtual RMethod RMAddSynthesizedCharactersAndFaceMetrics
		{
			get
			{
				if(r_MAddSynthesizedCharactersAndFaceMetrics == null)
				{
					r_MAddSynthesizedCharactersAndFaceMetrics = new(this, "AddSynthesizedCharactersAndFaceMetrics", 0);
					r_MAddSynthesizedCharactersAndFaceMetrics.SetBelong(this.instance);
				}
				return r_MAddSynthesizedCharactersAndFaceMetrics;
			}
		}

		/// <summary>
		/// Void AddSynthesizedCharacter(UInt32, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MAddSynthesizedCharacter_UInt32_Boolean_Boolean;
		public virtual RMethod RMAddSynthesizedCharacter_UInt32_Boolean_Boolean
		{
			get
			{
				if(r_MAddSynthesizedCharacter_UInt32_Boolean_Boolean == null)
				{
					r_MAddSynthesizedCharacter_UInt32_Boolean_Boolean = new(this, "AddSynthesizedCharacter", 0, typeof(System.UInt32), typeof(System.Boolean), typeof(System.Boolean));
					r_MAddSynthesizedCharacter_UInt32_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MAddSynthesizedCharacter_UInt32_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void AddCharacterToLookupCache(UInt32, UnityEngine.TextCore.Text.Character)
		/// </summary>
		protected RMethod r_MAddCharacterToLookupCache_UInt32_Character;
		public virtual RMethod RMAddCharacterToLookupCache_UInt32_Character
		{
			get
			{
				if(r_MAddCharacterToLookupCache_UInt32_Character == null)
				{
					r_MAddCharacterToLookupCache_UInt32_Character = new(this, "AddCharacterToLookupCache", 0, typeof(System.UInt32), typeof(UnityEngine.TextCore.Text.Character));
					r_MAddCharacterToLookupCache_UInt32_Character.SetBelong(this.instance);
				}
				return r_MAddCharacterToLookupCache_UInt32_Character;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace()
		/// </summary>
		protected RMethod r_MLoadFontFace;
		public virtual RMethod RMLoadFontFace
		{
			get
			{
				if(r_MLoadFontFace == null)
				{
					r_MLoadFontFace = new(this, "LoadFontFace", 0);
					r_MLoadFontFace.SetBelong(this.instance);
				}
				return r_MLoadFontFace;
			}
		}

		/// <summary>
		/// Void SortCharacterTable()
		/// </summary>
		protected RMethod r_MSortCharacterTable;
		public virtual RMethod RMSortCharacterTable
		{
			get
			{
				if(r_MSortCharacterTable == null)
				{
					r_MSortCharacterTable = new(this, "SortCharacterTable", 0);
					r_MSortCharacterTable.SetBelong(this.instance);
				}
				return r_MSortCharacterTable;
			}
		}

		/// <summary>
		/// Void SortGlyphTable()
		/// </summary>
		protected RMethod r_MSortGlyphTable;
		public virtual RMethod RMSortGlyphTable
		{
			get
			{
				if(r_MSortGlyphTable == null)
				{
					r_MSortGlyphTable = new(this, "SortGlyphTable", 0);
					r_MSortGlyphTable.SetBelong(this.instance);
				}
				return r_MSortGlyphTable;
			}
		}

		/// <summary>
		/// Void SortFontFeatureTable()
		/// </summary>
		protected RMethod r_MSortFontFeatureTable;
		public virtual RMethod RMSortFontFeatureTable
		{
			get
			{
				if(r_MSortFontFeatureTable == null)
				{
					r_MSortFontFeatureTable = new(this, "SortFontFeatureTable", 0);
					r_MSortFontFeatureTable.SetBelong(this.instance);
				}
				return r_MSortFontFeatureTable;
			}
		}

		/// <summary>
		/// Void SortAllTables()
		/// </summary>
		protected RMethod r_MSortAllTables;
		public virtual RMethod RMSortAllTables
		{
			get
			{
				if(r_MSortAllTables == null)
				{
					r_MSortAllTables = new(this, "SortAllTables", 0);
					r_MSortAllTables.SetBelong(this.instance);
				}
				return r_MSortAllTables;
			}
		}

		/// <summary>
		/// Boolean HasCharacter(Int32)
		/// </summary>
		protected RMethod r_MHasCharacter_Int32;
		public virtual RMethod RMHasCharacter_Int32
		{
			get
			{
				if(r_MHasCharacter_Int32 == null)
				{
					r_MHasCharacter_Int32 = new(this, "HasCharacter", 0, typeof(System.Int32));
					r_MHasCharacter_Int32.SetBelong(this.instance);
				}
				return r_MHasCharacter_Int32;
			}
		}

		/// <summary>
		/// Boolean HasCharacter(Char, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MHasCharacter_Char_Boolean_Boolean;
		public virtual RMethod RMHasCharacter_Char_Boolean_Boolean
		{
			get
			{
				if(r_MHasCharacter_Char_Boolean_Boolean == null)
				{
					r_MHasCharacter_Char_Boolean_Boolean = new(this, "HasCharacter", 0, typeof(System.Char), typeof(System.Boolean), typeof(System.Boolean));
					r_MHasCharacter_Char_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MHasCharacter_Char_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Boolean HasCharacter_Internal(UInt32, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MHasCharacter_Internal_UInt32_Boolean_Boolean;
		public virtual RMethod RMHasCharacter_Internal_UInt32_Boolean_Boolean
		{
			get
			{
				if(r_MHasCharacter_Internal_UInt32_Boolean_Boolean == null)
				{
					r_MHasCharacter_Internal_UInt32_Boolean_Boolean = new(this, "HasCharacter_Internal", 0, typeof(System.UInt32), typeof(System.Boolean), typeof(System.Boolean));
					r_MHasCharacter_Internal_UInt32_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MHasCharacter_Internal_UInt32_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Boolean HasCharacters(System.String, System.Collections.Generic.List`1[System.Char] ByRef)
		/// </summary>
		protected RMethod r_MHasCharacters_String_Out_List_d_Char_p_;
		public virtual RMethod RMHasCharacters_String_Out_List_d_Char_p_
		{
			get
			{
				if(r_MHasCharacters_String_Out_List_d_Char_p_ == null)
				{
					r_MHasCharacters_String_Out_List_d_Char_p_ = new(this, "HasCharacters", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Char)).MakeByRefType());
					r_MHasCharacters_String_Out_List_d_Char_p_.SetBelong(this.instance);
				}
				return r_MHasCharacters_String_Out_List_d_Char_p_;
			}
		}

		/// <summary>
		/// Boolean HasCharacters(System.String, UInt32[] ByRef, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MHasCharacters_String_Out_UInt32Array_Boolean_Boolean;
		public virtual RMethod RMHasCharacters_String_Out_UInt32Array_Boolean_Boolean
		{
			get
			{
				if(r_MHasCharacters_String_Out_UInt32Array_Boolean_Boolean == null)
				{
					r_MHasCharacters_String_Out_UInt32Array_Boolean_Boolean = new(this, "HasCharacters", 0, typeof(System.String), typeof(System.UInt32).MakeArrayType().MakeByRefType(), typeof(System.Boolean), typeof(System.Boolean));
					r_MHasCharacters_String_Out_UInt32Array_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MHasCharacters_String_Out_UInt32Array_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Boolean HasCharacters(System.String)
		/// </summary>
		protected RMethod r_MHasCharacters_String;
		public virtual RMethod RMHasCharacters_String
		{
			get
			{
				if(r_MHasCharacters_String == null)
				{
					r_MHasCharacters_String = new(this, "HasCharacters", 0, typeof(System.String));
					r_MHasCharacters_String.SetBelong(this.instance);
				}
				return r_MHasCharacters_String;
			}
		}

		/// <summary>
		/// System.String GetCharacters(UnityEngine.TextCore.Text.FontAsset)
		/// </summary>
		protected static RMethod r_MGetCharacters_FontAsset;
		public static RMethod RMGetCharacters_FontAsset
		{
			get
			{
				if(r_MGetCharacters_FontAsset == null)
				{
					r_MGetCharacters_FontAsset = new(typeof(UnityEngine.TextCore.Text.FontAsset), "GetCharacters", 0, typeof(UnityEngine.TextCore.Text.FontAsset));
					r_MGetCharacters_FontAsset.SetBelong(null);
				}
				return r_MGetCharacters_FontAsset;
			}
		}

		/// <summary>
		/// Int32[] GetCharactersArray(UnityEngine.TextCore.Text.FontAsset)
		/// </summary>
		protected static RMethod r_MGetCharactersArray_FontAsset;
		public static RMethod RMGetCharactersArray_FontAsset
		{
			get
			{
				if(r_MGetCharactersArray_FontAsset == null)
				{
					r_MGetCharactersArray_FontAsset = new(typeof(UnityEngine.TextCore.Text.FontAsset), "GetCharactersArray", 0, typeof(UnityEngine.TextCore.Text.FontAsset));
					r_MGetCharactersArray_FontAsset.SetBelong(null);
				}
				return r_MGetCharactersArray_FontAsset;
			}
		}

		/// <summary>
		/// UInt32 GetGlyphIndex(UInt32)
		/// </summary>
		protected RMethod r_MGetGlyphIndex_UInt32;
		public virtual RMethod RMGetGlyphIndex_UInt32
		{
			get
			{
				if(r_MGetGlyphIndex_UInt32 == null)
				{
					r_MGetGlyphIndex_UInt32 = new(this, "GetGlyphIndex", 0, typeof(System.UInt32));
					r_MGetGlyphIndex_UInt32.SetBelong(this.instance);
				}
				return r_MGetGlyphIndex_UInt32;
			}
		}

		/// <summary>
		/// Void RegisterFontAssetForFontFeatureUpdate(UnityEngine.TextCore.Text.FontAsset)
		/// </summary>
		protected static RMethod r_MRegisterFontAssetForFontFeatureUpdate_FontAsset;
		public static RMethod RMRegisterFontAssetForFontFeatureUpdate_FontAsset
		{
			get
			{
				if(r_MRegisterFontAssetForFontFeatureUpdate_FontAsset == null)
				{
					r_MRegisterFontAssetForFontFeatureUpdate_FontAsset = new(typeof(UnityEngine.TextCore.Text.FontAsset), "RegisterFontAssetForFontFeatureUpdate", 0, typeof(UnityEngine.TextCore.Text.FontAsset));
					r_MRegisterFontAssetForFontFeatureUpdate_FontAsset.SetBelong(null);
				}
				return r_MRegisterFontAssetForFontFeatureUpdate_FontAsset;
			}
		}

		/// <summary>
		/// Void UpdateFontFeaturesForFontAssetsInQueue()
		/// </summary>
		protected static RMethod r_MUpdateFontFeaturesForFontAssetsInQueue;
		public static RMethod RMUpdateFontFeaturesForFontAssetsInQueue
		{
			get
			{
				if(r_MUpdateFontFeaturesForFontAssetsInQueue == null)
				{
					r_MUpdateFontFeaturesForFontAssetsInQueue = new(typeof(UnityEngine.TextCore.Text.FontAsset), "UpdateFontFeaturesForFontAssetsInQueue", 0);
					r_MUpdateFontFeaturesForFontAssetsInQueue.SetBelong(null);
				}
				return r_MUpdateFontFeaturesForFontAssetsInQueue;
			}
		}

		/// <summary>
		/// Void RegisterAtlasTextureForApply(UnityEngine.Texture2D)
		/// </summary>
		protected static RMethod r_MRegisterAtlasTextureForApply_Texture2D;
		public static RMethod RMRegisterAtlasTextureForApply_Texture2D
		{
			get
			{
				if(r_MRegisterAtlasTextureForApply_Texture2D == null)
				{
					r_MRegisterAtlasTextureForApply_Texture2D = new(typeof(UnityEngine.TextCore.Text.FontAsset), "RegisterAtlasTextureForApply", 0, typeof(UnityEngine.Texture2D));
					r_MRegisterAtlasTextureForApply_Texture2D.SetBelong(null);
				}
				return r_MRegisterAtlasTextureForApply_Texture2D;
			}
		}

		/// <summary>
		/// Void UpdateAtlasTexturesInQueue()
		/// </summary>
		protected static RMethod r_MUpdateAtlasTexturesInQueue;
		public static RMethod RMUpdateAtlasTexturesInQueue
		{
			get
			{
				if(r_MUpdateAtlasTexturesInQueue == null)
				{
					r_MUpdateAtlasTexturesInQueue = new(typeof(UnityEngine.TextCore.Text.FontAsset), "UpdateAtlasTexturesInQueue", 0);
					r_MUpdateAtlasTexturesInQueue.SetBelong(null);
				}
				return r_MUpdateAtlasTexturesInQueue;
			}
		}

		/// <summary>
		/// Void UpdateFontAssetsInUpdateQueue()
		/// </summary>
		protected static RMethod r_MUpdateFontAssetsInUpdateQueue;
		public static RMethod RMUpdateFontAssetsInUpdateQueue
		{
			get
			{
				if(r_MUpdateFontAssetsInUpdateQueue == null)
				{
					r_MUpdateFontAssetsInUpdateQueue = new(typeof(UnityEngine.TextCore.Text.FontAsset), "UpdateFontAssetsInUpdateQueue", 0);
					r_MUpdateFontAssetsInUpdateQueue.SetBelong(null);
				}
				return r_MUpdateFontAssetsInUpdateQueue;
			}
		}

		/// <summary>
		/// Boolean TryAddCharacters(UInt32[], Boolean)
		/// </summary>
		protected RMethod r_MTryAddCharacters_UInt32Array_Boolean;
		public virtual RMethod RMTryAddCharacters_UInt32Array_Boolean
		{
			get
			{
				if(r_MTryAddCharacters_UInt32Array_Boolean == null)
				{
					r_MTryAddCharacters_UInt32Array_Boolean = new(this, "TryAddCharacters", 0, typeof(System.UInt32).MakeArrayType(), typeof(System.Boolean));
					r_MTryAddCharacters_UInt32Array_Boolean.SetBelong(this.instance);
				}
				return r_MTryAddCharacters_UInt32Array_Boolean;
			}
		}

		/// <summary>
		/// Boolean TryAddCharacters(UInt32[], UInt32[] ByRef, Boolean)
		/// </summary>
		protected RMethod r_MTryAddCharacters_UInt32Array_Out_UInt32Array_Boolean;
		public virtual RMethod RMTryAddCharacters_UInt32Array_Out_UInt32Array_Boolean
		{
			get
			{
				if(r_MTryAddCharacters_UInt32Array_Out_UInt32Array_Boolean == null)
				{
					r_MTryAddCharacters_UInt32Array_Out_UInt32Array_Boolean = new(this, "TryAddCharacters", 0, typeof(System.UInt32).MakeArrayType(), typeof(System.UInt32).MakeArrayType().MakeByRefType(), typeof(System.Boolean));
					r_MTryAddCharacters_UInt32Array_Out_UInt32Array_Boolean.SetBelong(this.instance);
				}
				return r_MTryAddCharacters_UInt32Array_Out_UInt32Array_Boolean;
			}
		}

		/// <summary>
		/// Boolean TryAddCharacters(System.String, Boolean)
		/// </summary>
		protected RMethod r_MTryAddCharacters_String_Boolean;
		public virtual RMethod RMTryAddCharacters_String_Boolean
		{
			get
			{
				if(r_MTryAddCharacters_String_Boolean == null)
				{
					r_MTryAddCharacters_String_Boolean = new(this, "TryAddCharacters", 0, typeof(System.String), typeof(System.Boolean));
					r_MTryAddCharacters_String_Boolean.SetBelong(this.instance);
				}
				return r_MTryAddCharacters_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean TryAddCharacters(System.String, System.String ByRef, Boolean)
		/// </summary>
		protected RMethod r_MTryAddCharacters_String_Out_String_Boolean;
		public virtual RMethod RMTryAddCharacters_String_Out_String_Boolean
		{
			get
			{
				if(r_MTryAddCharacters_String_Out_String_Boolean == null)
				{
					r_MTryAddCharacters_String_Out_String_Boolean = new(this, "TryAddCharacters", 0, typeof(System.String), typeof(System.String).MakeByRefType(), typeof(System.Boolean));
					r_MTryAddCharacters_String_Out_String_Boolean.SetBelong(this.instance);
				}
				return r_MTryAddCharacters_String_Out_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean TryAddGlyphInternal(UInt32, UnityEngine.TextCore.Glyph ByRef)
		/// </summary>
		protected RMethod r_MTryAddGlyphInternal_UInt32_Out_Glyph;
		public virtual RMethod RMTryAddGlyphInternal_UInt32_Out_Glyph
		{
			get
			{
				if(r_MTryAddGlyphInternal_UInt32_Out_Glyph == null)
				{
					r_MTryAddGlyphInternal_UInt32_Out_Glyph = new(this, "TryAddGlyphInternal", 0, typeof(System.UInt32), typeof(UnityEngine.TextCore.Glyph).MakeByRefType());
					r_MTryAddGlyphInternal_UInt32_Out_Glyph.SetBelong(this.instance);
				}
				return r_MTryAddGlyphInternal_UInt32_Out_Glyph;
			}
		}

		/// <summary>
		/// Boolean TryAddCharacterInternal(UInt32, UnityEngine.TextCore.Text.Character ByRef, Boolean)
		/// </summary>
		protected RMethod r_MTryAddCharacterInternal_UInt32_Out_Character_Boolean;
		public virtual RMethod RMTryAddCharacterInternal_UInt32_Out_Character_Boolean
		{
			get
			{
				if(r_MTryAddCharacterInternal_UInt32_Out_Character_Boolean == null)
				{
					r_MTryAddCharacterInternal_UInt32_Out_Character_Boolean = new(this, "TryAddCharacterInternal", 0, typeof(System.UInt32), typeof(UnityEngine.TextCore.Text.Character).MakeByRefType(), typeof(System.Boolean));
					r_MTryAddCharacterInternal_UInt32_Out_Character_Boolean.SetBelong(this.instance);
				}
				return r_MTryAddCharacterInternal_UInt32_Out_Character_Boolean;
			}
		}

		/// <summary>
		/// Boolean TryGetCharacter_and_QueueRenderToTexture(UInt32, UnityEngine.TextCore.Text.Character ByRef, Boolean)
		/// </summary>
		protected RMethod r_MTryGetCharacter_and_QueueRenderToTexture_UInt32_Out_Character_Boolean;
		public virtual RMethod RMTryGetCharacter_and_QueueRenderToTexture_UInt32_Out_Character_Boolean
		{
			get
			{
				if(r_MTryGetCharacter_and_QueueRenderToTexture_UInt32_Out_Character_Boolean == null)
				{
					r_MTryGetCharacter_and_QueueRenderToTexture_UInt32_Out_Character_Boolean = new(this, "TryGetCharacter_and_QueueRenderToTexture", 0, typeof(System.UInt32), typeof(UnityEngine.TextCore.Text.Character).MakeByRefType(), typeof(System.Boolean));
					r_MTryGetCharacter_and_QueueRenderToTexture_UInt32_Out_Character_Boolean.SetBelong(this.instance);
				}
				return r_MTryGetCharacter_and_QueueRenderToTexture_UInt32_Out_Character_Boolean;
			}
		}

		/// <summary>
		/// Void TryAddGlyphsToAtlasTextures()
		/// </summary>
		protected RMethod r_MTryAddGlyphsToAtlasTextures;
		public virtual RMethod RMTryAddGlyphsToAtlasTextures
		{
			get
			{
				if(r_MTryAddGlyphsToAtlasTextures == null)
				{
					r_MTryAddGlyphsToAtlasTextures = new(this, "TryAddGlyphsToAtlasTextures", 0);
					r_MTryAddGlyphsToAtlasTextures.SetBelong(this.instance);
				}
				return r_MTryAddGlyphsToAtlasTextures;
			}
		}

		/// <summary>
		/// Boolean TryAddGlyphsToNewAtlasTexture()
		/// </summary>
		protected RMethod r_MTryAddGlyphsToNewAtlasTexture;
		public virtual RMethod RMTryAddGlyphsToNewAtlasTexture
		{
			get
			{
				if(r_MTryAddGlyphsToNewAtlasTexture == null)
				{
					r_MTryAddGlyphsToNewAtlasTexture = new(this, "TryAddGlyphsToNewAtlasTexture", 0);
					r_MTryAddGlyphsToNewAtlasTexture.SetBelong(this.instance);
				}
				return r_MTryAddGlyphsToNewAtlasTexture;
			}
		}

		/// <summary>
		/// Void SetupNewAtlasTexture()
		/// </summary>
		protected RMethod r_MSetupNewAtlasTexture;
		public virtual RMethod RMSetupNewAtlasTexture
		{
			get
			{
				if(r_MSetupNewAtlasTexture == null)
				{
					r_MSetupNewAtlasTexture = new(this, "SetupNewAtlasTexture", 0);
					r_MSetupNewAtlasTexture.SetBelong(this.instance);
				}
				return r_MSetupNewAtlasTexture;
			}
		}

		/// <summary>
		/// Void UpdateAllFontFeatures()
		/// </summary>
		protected RMethod r_MUpdateAllFontFeatures;
		public virtual RMethod RMUpdateAllFontFeatures
		{
			get
			{
				if(r_MUpdateAllFontFeatures == null)
				{
					r_MUpdateAllFontFeatures = new(this, "UpdateAllFontFeatures", 0);
					r_MUpdateAllFontFeatures.SetBelong(this.instance);
				}
				return r_MUpdateAllFontFeatures;
			}
		}

		/// <summary>
		/// Void UpdateGlyphAdjustmentRecords()
		/// </summary>
		protected RMethod r_MUpdateGlyphAdjustmentRecords;
		public virtual RMethod RMUpdateGlyphAdjustmentRecords
		{
			get
			{
				if(r_MUpdateGlyphAdjustmentRecords == null)
				{
					r_MUpdateGlyphAdjustmentRecords = new(this, "UpdateGlyphAdjustmentRecords", 0);
					r_MUpdateGlyphAdjustmentRecords.SetBelong(this.instance);
				}
				return r_MUpdateGlyphAdjustmentRecords;
			}
		}

		/// <summary>
		/// Void UpdateGlyphAdjustmentRecords(UInt32[])
		/// </summary>
		protected RMethod r_MUpdateGlyphAdjustmentRecords_UInt32Array;
		public virtual RMethod RMUpdateGlyphAdjustmentRecords_UInt32Array
		{
			get
			{
				if(r_MUpdateGlyphAdjustmentRecords_UInt32Array == null)
				{
					r_MUpdateGlyphAdjustmentRecords_UInt32Array = new(this, "UpdateGlyphAdjustmentRecords", 0, typeof(System.UInt32).MakeArrayType());
					r_MUpdateGlyphAdjustmentRecords_UInt32Array.SetBelong(this.instance);
				}
				return r_MUpdateGlyphAdjustmentRecords_UInt32Array;
			}
		}

		/// <summary>
		/// Void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List`1[System.UInt32])
		/// </summary>
		protected RMethod r_MUpdateGlyphAdjustmentRecords_List_d_UInt32_p_;
		public virtual RMethod RMUpdateGlyphAdjustmentRecords_List_d_UInt32_p_
		{
			get
			{
				if(r_MUpdateGlyphAdjustmentRecords_List_d_UInt32_p_ == null)
				{
					r_MUpdateGlyphAdjustmentRecords_List_d_UInt32_p_ = new(this, "UpdateGlyphAdjustmentRecords", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.UInt32)));
					r_MUpdateGlyphAdjustmentRecords_List_d_UInt32_p_.SetBelong(this.instance);
				}
				return r_MUpdateGlyphAdjustmentRecords_List_d_UInt32_p_;
			}
		}

		/// <summary>
		/// Void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List`1[System.UInt32], System.Collections.Generic.List`1[System.UInt32])
		/// </summary>
		protected RMethod r_MUpdateGlyphAdjustmentRecords_List_d_UInt32_p__List_d_UInt32_p_;
		public virtual RMethod RMUpdateGlyphAdjustmentRecords_List_d_UInt32_p__List_d_UInt32_p_
		{
			get
			{
				if(r_MUpdateGlyphAdjustmentRecords_List_d_UInt32_p__List_d_UInt32_p_ == null)
				{
					r_MUpdateGlyphAdjustmentRecords_List_d_UInt32_p__List_d_UInt32_p_ = new(this, "UpdateGlyphAdjustmentRecords", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.UInt32)), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.UInt32)));
					r_MUpdateGlyphAdjustmentRecords_List_d_UInt32_p__List_d_UInt32_p_.SetBelong(this.instance);
				}
				return r_MUpdateGlyphAdjustmentRecords_List_d_UInt32_p__List_d_UInt32_p_;
			}
		}

		/// <summary>
		/// Void CopyListDataToArray[T](System.Collections.Generic.List`1[T], T[] ByRef)
		/// </summary>
		protected RMethod r_MCopyListDataToArray_GT_List_d_T_p__Ref_TArray;
		public virtual RMethod RMCopyListDataToArray_GT_List_d_T_p__Ref_TArray
		{
			get
			{
				if(r_MCopyListDataToArray_GT_List_d_T_p__Ref_TArray == null)
				{
					r_MCopyListDataToArray_GT_List_d_T_p__Ref_TArray = new(this, "CopyListDataToArray", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0).MakeArrayType().MakeByRefType());
					r_MCopyListDataToArray_GT_List_d_T_p__Ref_TArray.SetBelong(this.instance);
				}
				return r_MCopyListDataToArray_GT_List_d_T_p__Ref_TArray;
			}
		}

		/// <summary>
		/// Void ClearFontAssetData(Boolean)
		/// </summary>
		protected RMethod r_MClearFontAssetData_Boolean;
		public virtual RMethod RMClearFontAssetData_Boolean
		{
			get
			{
				if(r_MClearFontAssetData_Boolean == null)
				{
					r_MClearFontAssetData_Boolean = new(this, "ClearFontAssetData", 0, typeof(System.Boolean));
					r_MClearFontAssetData_Boolean.SetBelong(this.instance);
				}
				return r_MClearFontAssetData_Boolean;
			}
		}

		/// <summary>
		/// Void ClearFontAssetDataInternal(Boolean)
		/// </summary>
		protected RMethod r_MClearFontAssetDataInternal_Boolean;
		public virtual RMethod RMClearFontAssetDataInternal_Boolean
		{
			get
			{
				if(r_MClearFontAssetDataInternal_Boolean == null)
				{
					r_MClearFontAssetDataInternal_Boolean = new(this, "ClearFontAssetDataInternal", 0, typeof(System.Boolean));
					r_MClearFontAssetDataInternal_Boolean.SetBelong(this.instance);
				}
				return r_MClearFontAssetDataInternal_Boolean;
			}
		}

		/// <summary>
		/// Void UpdateFontAssetData()
		/// </summary>
		protected RMethod r_MUpdateFontAssetData;
		public virtual RMethod RMUpdateFontAssetData
		{
			get
			{
				if(r_MUpdateFontAssetData == null)
				{
					r_MUpdateFontAssetData = new(this, "UpdateFontAssetData", 0);
					r_MUpdateFontAssetData.SetBelong(this.instance);
				}
				return r_MUpdateFontAssetData;
			}
		}

		/// <summary>
		/// Void ClearFontAssetTables(Boolean)
		/// </summary>
		protected RMethod r_MClearFontAssetTables_Boolean;
		public virtual RMethod RMClearFontAssetTables_Boolean
		{
			get
			{
				if(r_MClearFontAssetTables_Boolean == null)
				{
					r_MClearFontAssetTables_Boolean = new(this, "ClearFontAssetTables", 0, typeof(System.Boolean));
					r_MClearFontAssetTables_Boolean.SetBelong(this.instance);
				}
				return r_MClearFontAssetTables_Boolean;
			}
		}

		/// <summary>
		/// Void ClearAtlasTextures(Boolean)
		/// </summary>
		protected RMethod r_MClearAtlasTextures_Boolean;
		public virtual RMethod RMClearAtlasTextures_Boolean
		{
			get
			{
				if(r_MClearAtlasTextures_Boolean == null)
				{
					r_MClearAtlasTextures_Boolean = new(this, "ClearAtlasTextures", 0, typeof(System.Boolean));
					r_MClearAtlasTextures_Boolean.SetBelong(this.instance);
				}
				return r_MClearAtlasTextures_Boolean;
			}
		}

		/// <summary>
		/// Void DestroyAtlasTextures()
		/// </summary>
		protected RMethod r_MDestroyAtlasTextures;
		public virtual RMethod RMDestroyAtlasTextures
		{
			get
			{
				if(r_MDestroyAtlasTextures == null)
				{
					r_MDestroyAtlasTextures = new(this, "DestroyAtlasTextures", 0);
					r_MDestroyAtlasTextures.SetBelong(this.instance);
				}
				return r_MDestroyAtlasTextures;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_MSetDirty;
		public virtual RMethod RMSetDirty
		{
			get
			{
				if(r_MSetDirty == null)
				{
					r_MSetDirty = new(this, "SetDirty", 0);
					r_MSetDirty.SetBelong(this.instance);
				}
				return r_MSetDirty;
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

        public static UnityEngine.TextCore.Text.FontAsset CreateFontAsset(System.String @familyName, System.String @styleName, System.Int32 @pointSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@familyName, @styleName, @pointSize};
            var ___result = RMCreateFontAsset_String_String_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TextCore.Text.FontAsset)___result;
        }


        public static UnityEngine.TextCore.Text.FontAsset CreateFontAsset(System.String @fontFilePath, System.Int32 @faceIndex, System.Int32 @samplingPointSize, System.Int32 @atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode @renderMode, System.Int32 @atlasWidth, System.Int32 @atlasHeight)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fontFilePath, @faceIndex, @samplingPointSize, @atlasPadding, @renderMode, @atlasWidth, @atlasHeight};
            var ___result = RMCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TextCore.Text.FontAsset)___result;
        }


        public static UnityEngine.TextCore.Text.FontAsset CreateFontAsset(System.String @fontFilePath, System.Int32 @faceIndex, System.Int32 @samplingPointSize, System.Int32 @atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode @renderMode, System.Int32 @atlasWidth, System.Int32 @atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode @atlasPopulationMode, System.Boolean @enableMultiAtlasSupport)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fontFilePath, @faceIndex, @samplingPointSize, @atlasPadding, @renderMode, @atlasWidth, @atlasHeight, @atlasPopulationMode, @enableMultiAtlasSupport};
            var ___result = RMCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TextCore.Text.FontAsset)___result;
        }


        public static UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font @font)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@font};
            var ___result = RMCreateFontAsset_Font.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TextCore.Text.FontAsset)___result;
        }


        public static UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font @font, System.Int32 @samplingPointSize, System.Int32 @atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode @renderMode, System.Int32 @atlasWidth, System.Int32 @atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode @atlasPopulationMode, System.Boolean @enableMultiAtlasSupport)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@font, @samplingPointSize, @atlasPadding, @renderMode, @atlasWidth, @atlasHeight, @atlasPopulationMode, @enableMultiAtlasSupport};
            var ___result = RMCreateFontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TextCore.Text.FontAsset)___result;
        }


        public static UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font @font, System.Int32 @faceIndex, System.Int32 @samplingPointSize, System.Int32 @atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode @renderMode, System.Int32 @atlasWidth, System.Int32 @atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode @atlasPopulationMode, System.Boolean @enableMultiAtlasSupport)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@font, @faceIndex, @samplingPointSize, @atlasPadding, @renderMode, @atlasWidth, @atlasHeight, @atlasPopulationMode, @enableMultiAtlasSupport};
            var ___result = RMCreateFontAsset_Font_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TextCore.Text.FontAsset)___result;
        }


        public static UnityEngine.TextCore.Text.FontAsset CreateFontAssetInstance(UnityEngine.Font @font, System.Int32 @atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode @renderMode, System.Int32 @atlasWidth, System.Int32 @atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode @atlasPopulationMode, System.Boolean @enableMultiAtlasSupport)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@font, @atlasPadding, @renderMode, @atlasWidth, @atlasHeight, @atlasPopulationMode, @enableMultiAtlasSupport};
            var ___result = RMCreateFontAssetInstance_Font_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TextCore.Text.FontAsset)___result;
        }


        public virtual void Awake()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAwake.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDestroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnDestroy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnValidate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnValidate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReadFontAssetDefinition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReadFontAssetDefinition.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitializeDictionaryLookupTables()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitializeDictionaryLookupTables.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitializeGlyphLookupDictionary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitializeGlyphLookupDictionary.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitializeCharacterLookupDictionary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitializeCharacterLookupDictionary.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitializeLigatureSubstitutionLookupDictionary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitializeLigatureSubstitutionLookupDictionary.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitializeGlyphPaidAdjustmentRecordsLookupDictionary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitializeGlyphPaidAdjustmentRecordsLookupDictionary.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitializeMarkToBaseAdjustmentRecordsLookupDictionary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitializeMarkToBaseAdjustmentRecordsLookupDictionary.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitializeMarkToMarkAdjustmentRecordsLookupDictionary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitializeMarkToMarkAdjustmentRecordsLookupDictionary.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddSynthesizedCharactersAndFaceMetrics()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAddSynthesizedCharactersAndFaceMetrics.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddSynthesizedCharacter(System.UInt32 @unicode, System.Boolean @isFontFaceLoaded, System.Boolean @addImmediately)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unicode, @isFontFaceLoaded, @addImmediately};
            var ___result = RMAddSynthesizedCharacter_UInt32_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddCharacterToLookupCache(System.UInt32 @unicode, UnityEngine.TextCore.Text.Character @character)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unicode, @character};
            var ___result = RMAddCharacterToLookupCache_UInt32_Character.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMLoadFontFace.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TextCore.LowLevel.FontEngineError)___result;
        }


        public virtual void SortCharacterTable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSortCharacterTable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SortGlyphTable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSortGlyphTable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SortFontFeatureTable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSortFontFeatureTable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SortAllTables()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSortAllTables.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasCharacter(System.Int32 @character)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@character};
            var ___result = RMHasCharacter_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasCharacter(System.Char @character, System.Boolean @searchFallbacks, System.Boolean @tryAddCharacter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@character, @searchFallbacks, @tryAddCharacter};
            var ___result = RMHasCharacter_Char_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasCharacter_Internal(System.UInt32 @character, System.Boolean @searchFallbacks, System.Boolean @tryAddCharacter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@character, @searchFallbacks, @tryAddCharacter};
            var ___result = RMHasCharacter_Internal_UInt32_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasCharacters(System.String @text, out System.Collections.Generic.List<System.Char> @missingCharacters)
        {
			@missingCharacters = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @missingCharacters};
            var ___result = RMHasCharacters_String_Out_List_d_Char_p_.Invoke(___genericsType, ___parameters);
			@missingCharacters = (System.Collections.Generic.List<System.Char>)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasCharacters(System.String @text, out System.UInt32[] @missingCharacters, System.Boolean @searchFallbacks, System.Boolean @tryAddCharacter)
        {
			@missingCharacters = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @missingCharacters, @searchFallbacks, @tryAddCharacter};
            var ___result = RMHasCharacters_String_Out_UInt32Array_Boolean_Boolean.Invoke(___genericsType, ___parameters);
			@missingCharacters = (System.UInt32[])___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasCharacters(System.String @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RMHasCharacters_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String GetCharacters(UnityEngine.TextCore.Text.FontAsset @fontAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fontAsset};
            var ___result = RMGetCharacters_FontAsset.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Int32[] GetCharactersArray(UnityEngine.TextCore.Text.FontAsset @fontAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fontAsset};
            var ___result = RMGetCharactersArray_FontAsset.Invoke(___genericsType, ___parameters);

            return (System.Int32[])___result;
        }


        public virtual System.UInt32 GetGlyphIndex(System.UInt32 @unicode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unicode};
            var ___result = RMGetGlyphIndex_UInt32.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public static void RegisterFontAssetForFontFeatureUpdate(UnityEngine.TextCore.Text.FontAsset @fontAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fontAsset};
            var ___result = RMRegisterFontAssetForFontFeatureUpdate_FontAsset.Invoke(___genericsType, ___parameters);

            
        }


        public static void UpdateFontFeaturesForFontAssetsInQueue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateFontFeaturesForFontAssetsInQueue.Invoke(___genericsType, ___parameters);

            
        }


        public static void RegisterAtlasTextureForApply(UnityEngine.Texture2D @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture};
            var ___result = RMRegisterAtlasTextureForApply_Texture2D.Invoke(___genericsType, ___parameters);

            
        }


        public static void UpdateAtlasTexturesInQueue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateAtlasTexturesInQueue.Invoke(___genericsType, ___parameters);

            
        }


        public static void UpdateFontAssetsInUpdateQueue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateFontAssetsInUpdateQueue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryAddCharacters(System.UInt32[] @unicodes, System.Boolean @includeFontFeatures)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unicodes, @includeFontFeatures};
            var ___result = RMTryAddCharacters_UInt32Array_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryAddCharacters(System.UInt32[] @unicodes, out System.UInt32[] @missingUnicodes, System.Boolean @includeFontFeatures)
        {
			@missingUnicodes = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unicodes, @missingUnicodes, @includeFontFeatures};
            var ___result = RMTryAddCharacters_UInt32Array_Out_UInt32Array_Boolean.Invoke(___genericsType, ___parameters);
			@missingUnicodes = (System.UInt32[])___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryAddCharacters(System.String @characters, System.Boolean @includeFontFeatures)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@characters, @includeFontFeatures};
            var ___result = RMTryAddCharacters_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryAddCharacters(System.String @characters, out System.String @missingCharacters, System.Boolean @includeFontFeatures)
        {
			@missingCharacters = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@characters, @missingCharacters, @includeFontFeatures};
            var ___result = RMTryAddCharacters_String_Out_String_Boolean.Invoke(___genericsType, ___parameters);
			@missingCharacters = (System.String)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryAddGlyphInternal(System.UInt32 @glyphIndex, out UnityEngine.TextCore.Glyph @glyph)
        {
			@glyph = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@glyphIndex, @glyph};
            var ___result = RMTryAddGlyphInternal_UInt32_Out_Glyph.Invoke(___genericsType, ___parameters);
			@glyph = (UnityEngine.TextCore.Glyph)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryAddCharacterInternal(System.UInt32 @unicode, out UnityEngine.TextCore.Text.Character @character, System.Boolean @shouldGetFontFeatures)
        {
			@character = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unicode, @character, @shouldGetFontFeatures};
            var ___result = RMTryAddCharacterInternal_UInt32_Out_Character_Boolean.Invoke(___genericsType, ___parameters);
			@character = (UnityEngine.TextCore.Text.Character)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetCharacter_and_QueueRenderToTexture(System.UInt32 @unicode, out UnityEngine.TextCore.Text.Character @character, System.Boolean @shouldGetFontFeatures)
        {
			@character = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unicode, @character, @shouldGetFontFeatures};
            var ___result = RMTryGetCharacter_and_QueueRenderToTexture_UInt32_Out_Character_Boolean.Invoke(___genericsType, ___parameters);
			@character = (UnityEngine.TextCore.Text.Character)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual void TryAddGlyphsToAtlasTextures()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTryAddGlyphsToAtlasTextures.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryAddGlyphsToNewAtlasTexture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTryAddGlyphsToNewAtlasTexture.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetupNewAtlasTexture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetupNewAtlasTexture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateAllFontFeatures()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateAllFontFeatures.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateGlyphAdjustmentRecords()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateGlyphAdjustmentRecords.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateGlyphAdjustmentRecords(System.UInt32[] @glyphIndexes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@glyphIndexes};
            var ___result = RMUpdateGlyphAdjustmentRecords_UInt32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<System.UInt32> @glyphIndexes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@glyphIndexes};
            var ___result = RMUpdateGlyphAdjustmentRecords_List_d_UInt32_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<System.UInt32> @newGlyphIndexes, System.Collections.Generic.List<System.UInt32> @allGlyphIndexes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newGlyphIndexes, @allGlyphIndexes};
            var ___result = RMUpdateGlyphAdjustmentRecords_List_d_UInt32_p__List_d_UInt32_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyListDataToArray<T>(System.Collections.Generic.List<T> @srcList, ref T[] @dstArray)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@srcList, @dstArray};
            var ___result = RMCopyListDataToArray_GT_List_d_T_p__Ref_TArray.Invoke(___genericsType, ___parameters);
			@dstArray = (T[])___parameters[1];

            
        }


        public virtual void ClearFontAssetData(System.Boolean @setAtlasSizeToZero)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@setAtlasSizeToZero};
            var ___result = RMClearFontAssetData_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearFontAssetDataInternal(System.Boolean @clearFontFeatures)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clearFontFeatures};
            var ___result = RMClearFontAssetDataInternal_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateFontAssetData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateFontAssetData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearFontAssetTables(System.Boolean @clearFontFeatures)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clearFontFeatures};
            var ___result = RMClearFontAssetTables_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearAtlasTextures(System.Boolean @setAtlasSizeToZero)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@setAtlasSizeToZero};
            var ___result = RMClearAtlasTextures_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DestroyAtlasTextures()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDestroyAtlasTextures.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetDirty.Invoke(___genericsType, ___parameters);

            
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
