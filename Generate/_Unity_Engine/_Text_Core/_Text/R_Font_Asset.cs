
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.TextCore.Text.FontAsset
	/// </summary>
    public partial class RFontAsset : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.TextCore.Text.FontAsset);
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


		/// <summary>
		/// System.String m_SourceFontFileGUID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_SourceFontFileGUID;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_SourceFontFileGUID
		{
			get
			{
				if(r_Fm_SourceFontFileGUID == null)
				{
					r_Fm_SourceFontFileGUID = new(this, "m_SourceFontFileGUID");
				}
				return r_Fm_SourceFontFileGUID;
			}
		}

		/// <summary>
		/// UnityEngine.Font m_SourceFontFile_EditorRef
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RFont r_Fm_SourceFontFile_EditorRef;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RFont RFm_SourceFontFile_EditorRef
		{
			get
			{
				if(r_Fm_SourceFontFile_EditorRef == null)
				{
					r_Fm_SourceFontFile_EditorRef = new(this, "m_SourceFontFile_EditorRef");
				}
				return r_Fm_SourceFontFile_EditorRef;
			}
		}

		/// <summary>
		/// UnityEngine.Font m_SourceFontFile
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RFont r_Fm_SourceFontFile;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RFont RFm_SourceFontFile
		{
			get
			{
				if(r_Fm_SourceFontFile == null)
				{
					r_Fm_SourceFontFile = new(this, "m_SourceFontFile");
				}
				return r_Fm_SourceFontFile;
			}
		}

		/// <summary>
		/// System.String m_SourceFontFilePath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_SourceFontFilePath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_SourceFontFilePath
		{
			get
			{
				if(r_Fm_SourceFontFilePath == null)
				{
					r_Fm_SourceFontFilePath = new(this, "m_SourceFontFilePath");
				}
				return r_Fm_SourceFontFilePath;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.AtlasPopulationMode m_AtlasPopulationMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RAtlasPopulationMode r_Fm_AtlasPopulationMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RAtlasPopulationMode RFm_AtlasPopulationMode
		{
			get
			{
				if(r_Fm_AtlasPopulationMode == null)
				{
					r_Fm_AtlasPopulationMode = new(this, "m_AtlasPopulationMode");
				}
				return r_Fm_AtlasPopulationMode;
			}
		}

		/// <summary>
		/// System.Boolean InternalDynamicOS
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FInternalDynamicOS;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFInternalDynamicOS
		{
			get
			{
				if(r_FInternalDynamicOS == null)
				{
					r_FInternalDynamicOS = new(this, "InternalDynamicOS");
				}
				return r_FInternalDynamicOS;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.FaceInfo m_FaceInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RFaceInfo r_Fm_FaceInfo;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RFaceInfo RFm_FaceInfo
		{
			get
			{
				if(r_Fm_FaceInfo == null)
				{
					r_Fm_FaceInfo = new(this, "m_FaceInfo");
				}
				return r_Fm_FaceInfo;
			}
		}

		/// <summary>
		/// System.Int32 m_FamilyNameHashCode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_FamilyNameHashCode;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_FamilyNameHashCode
		{
			get
			{
				if(r_Fm_FamilyNameHashCode == null)
				{
					r_Fm_FamilyNameHashCode = new(this, "m_FamilyNameHashCode");
				}
				return r_Fm_FamilyNameHashCode;
			}
		}

		/// <summary>
		/// System.Int32 m_StyleNameHashCode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_StyleNameHashCode;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_StyleNameHashCode
		{
			get
			{
				if(r_Fm_StyleNameHashCode == null)
				{
					r_Fm_StyleNameHashCode = new(this, "m_StyleNameHashCode");
				}
				return r_Fm_StyleNameHashCode;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Glyph] m_GlyphTable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyph> r_Fm_GlyphTable;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyph> RFm_GlyphTable
		{
			get
			{
				if(r_Fm_GlyphTable == null)
				{
					r_Fm_GlyphTable = new(this, "m_GlyphTable");
				}
				return r_Fm_GlyphTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.Glyph] m_GlyphLookupDictionary
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RUInt32, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyph> r_Fm_GlyphLookupDictionary;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RUInt32, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyph> RFm_GlyphLookupDictionary
		{
			get
			{
				if(r_Fm_GlyphLookupDictionary == null)
				{
					r_Fm_GlyphLookupDictionary = new(this, "m_GlyphLookupDictionary");
				}
				return r_Fm_GlyphLookupDictionary;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.Character] m_CharacterTable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RCharacter> r_Fm_CharacterTable;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RCharacter> RFm_CharacterTable
		{
			get
			{
				if(r_Fm_CharacterTable == null)
				{
					r_Fm_CharacterTable = new(this, "m_CharacterTable");
				}
				return r_Fm_CharacterTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.Text.Character] m_CharacterLookupDictionary
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RUInt32, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RCharacter> r_Fm_CharacterLookupDictionary;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RUInt32, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RCharacter> RFm_CharacterLookupDictionary
		{
			get
			{
				if(r_Fm_CharacterLookupDictionary == null)
				{
					r_Fm_CharacterLookupDictionary = new(this, "m_CharacterLookupDictionary");
				}
				return r_Fm_CharacterLookupDictionary;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D m_AtlasTexture
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture2D r_Fm_AtlasTexture;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture2D RFm_AtlasTexture
		{
			get
			{
				if(r_Fm_AtlasTexture == null)
				{
					r_Fm_AtlasTexture = new(this, "m_AtlasTexture");
				}
				return r_Fm_AtlasTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D[] m_AtlasTextures
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RTexture2D> r_Fm_AtlasTextures;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RTexture2D> RFm_AtlasTextures
		{
			get
			{
				if(r_Fm_AtlasTextures == null)
				{
					r_Fm_AtlasTextures = new(this, "m_AtlasTextures");
				}
				return r_Fm_AtlasTextures;
			}
		}

		/// <summary>
		/// System.Int32 m_AtlasTextureIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_AtlasTextureIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_AtlasTextureIndex
		{
			get
			{
				if(r_Fm_AtlasTextureIndex == null)
				{
					r_Fm_AtlasTextureIndex = new(this, "m_AtlasTextureIndex");
				}
				return r_Fm_AtlasTextureIndex;
			}
		}

		/// <summary>
		/// System.Boolean m_IsMultiAtlasTexturesEnabled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_IsMultiAtlasTexturesEnabled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_IsMultiAtlasTexturesEnabled
		{
			get
			{
				if(r_Fm_IsMultiAtlasTexturesEnabled == null)
				{
					r_Fm_IsMultiAtlasTexturesEnabled = new(this, "m_IsMultiAtlasTexturesEnabled");
				}
				return r_Fm_IsMultiAtlasTexturesEnabled;
			}
		}

		/// <summary>
		/// System.Boolean m_ClearDynamicDataOnBuild
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_ClearDynamicDataOnBuild;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_ClearDynamicDataOnBuild
		{
			get
			{
				if(r_Fm_ClearDynamicDataOnBuild == null)
				{
					r_Fm_ClearDynamicDataOnBuild = new(this, "m_ClearDynamicDataOnBuild");
				}
				return r_Fm_ClearDynamicDataOnBuild;
			}
		}

		/// <summary>
		/// System.Int32 m_AtlasWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_AtlasWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_AtlasWidth
		{
			get
			{
				if(r_Fm_AtlasWidth == null)
				{
					r_Fm_AtlasWidth = new(this, "m_AtlasWidth");
				}
				return r_Fm_AtlasWidth;
			}
		}

		/// <summary>
		/// System.Int32 m_AtlasHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_AtlasHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_AtlasHeight
		{
			get
			{
				if(r_Fm_AtlasHeight == null)
				{
					r_Fm_AtlasHeight = new(this, "m_AtlasHeight");
				}
				return r_Fm_AtlasHeight;
			}
		}

		/// <summary>
		/// System.Int32 m_AtlasPadding
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_AtlasPadding;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_AtlasPadding
		{
			get
			{
				if(r_Fm_AtlasPadding == null)
				{
					r_Fm_AtlasPadding = new(this, "m_AtlasPadding");
				}
				return r_Fm_AtlasPadding;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphRenderMode m_AtlasRenderMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode r_Fm_AtlasRenderMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode RFm_AtlasRenderMode
		{
			get
			{
				if(r_Fm_AtlasRenderMode == null)
				{
					r_Fm_AtlasRenderMode = new(this, "m_AtlasRenderMode");
				}
				return r_Fm_AtlasRenderMode;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.GlyphRect] m_UsedGlyphRects
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyphRect> r_Fm_UsedGlyphRects;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyphRect> RFm_UsedGlyphRects
		{
			get
			{
				if(r_Fm_UsedGlyphRects == null)
				{
					r_Fm_UsedGlyphRects = new(this, "m_UsedGlyphRects");
				}
				return r_Fm_UsedGlyphRects;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.GlyphRect] m_FreeGlyphRects
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyphRect> r_Fm_FreeGlyphRects;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyphRect> RFm_FreeGlyphRects
		{
			get
			{
				if(r_Fm_FreeGlyphRects == null)
				{
					r_Fm_FreeGlyphRects = new(this, "m_FreeGlyphRects");
				}
				return r_Fm_FreeGlyphRects;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontFeatureTable m_FontFeatureTable
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontFeatureTable r_Fm_FontFeatureTable;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontFeatureTable RFm_FontFeatureTable
		{
			get
			{
				if(r_Fm_FontFeatureTable == null)
				{
					r_Fm_FontFeatureTable = new(this, "m_FontFeatureTable");
				}
				return r_Fm_FontFeatureTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.FontAsset] m_FallbackFontAssetTable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset> r_Fm_FallbackFontAssetTable;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset> RFm_FallbackFontAssetTable
		{
			get
			{
				if(r_Fm_FallbackFontAssetTable == null)
				{
					r_Fm_FallbackFontAssetTable = new(this, "m_FallbackFontAssetTable");
				}
				return r_Fm_FallbackFontAssetTable;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAssetCreationEditorSettings r_Fm_fontAssetCreationEditorSettings;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAssetCreationEditorSettings RFm_fontAssetCreationEditorSettings
		{
			get
			{
				if(r_Fm_fontAssetCreationEditorSettings == null)
				{
					r_Fm_fontAssetCreationEditorSettings = new(this, "m_fontAssetCreationEditorSettings");
				}
				return r_Fm_fontAssetCreationEditorSettings;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontWeightPair[] m_FontWeightTable
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontWeightPair> r_Fm_FontWeightTable;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontWeightPair> RFm_FontWeightTable
		{
			get
			{
				if(r_Fm_FontWeightTable == null)
				{
					r_Fm_FontWeightTable = new(this, "m_FontWeightTable");
				}
				return r_Fm_FontWeightTable;
			}
		}

		/// <summary>
		/// System.Single m_RegularStyleWeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_RegularStyleWeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_RegularStyleWeight
		{
			get
			{
				if(r_Fm_RegularStyleWeight == null)
				{
					r_Fm_RegularStyleWeight = new(this, "m_RegularStyleWeight");
				}
				return r_Fm_RegularStyleWeight;
			}
		}

		/// <summary>
		/// System.Single m_RegularStyleSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_RegularStyleSpacing;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_RegularStyleSpacing
		{
			get
			{
				if(r_Fm_RegularStyleSpacing == null)
				{
					r_Fm_RegularStyleSpacing = new(this, "m_RegularStyleSpacing");
				}
				return r_Fm_RegularStyleSpacing;
			}
		}

		/// <summary>
		/// System.Single m_BoldStyleWeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_BoldStyleWeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_BoldStyleWeight
		{
			get
			{
				if(r_Fm_BoldStyleWeight == null)
				{
					r_Fm_BoldStyleWeight = new(this, "m_BoldStyleWeight");
				}
				return r_Fm_BoldStyleWeight;
			}
		}

		/// <summary>
		/// System.Single m_BoldStyleSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_BoldStyleSpacing;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_BoldStyleSpacing
		{
			get
			{
				if(r_Fm_BoldStyleSpacing == null)
				{
					r_Fm_BoldStyleSpacing = new(this, "m_BoldStyleSpacing");
				}
				return r_Fm_BoldStyleSpacing;
			}
		}

		/// <summary>
		/// System.Byte m_ItalicStyleSlant
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_Fm_ItalicStyleSlant;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RFm_ItalicStyleSlant
		{
			get
			{
				if(r_Fm_ItalicStyleSlant == null)
				{
					r_Fm_ItalicStyleSlant = new(this, "m_ItalicStyleSlant");
				}
				return r_Fm_ItalicStyleSlant;
			}
		}

		/// <summary>
		/// System.Byte m_TabMultiple
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_Fm_TabMultiple;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RFm_TabMultiple
		{
			get
			{
				if(r_Fm_TabMultiple == null)
				{
					r_Fm_TabMultiple = new(this, "m_TabMultiple");
				}
				return r_Fm_TabMultiple;
			}
		}

		/// <summary>
		/// System.Boolean IsFontAssetLookupTablesDirty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FIsFontAssetLookupTablesDirty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFIsFontAssetLookupTablesDirty
		{
			get
			{
				if(r_FIsFontAssetLookupTablesDirty == null)
				{
					r_FIsFontAssetLookupTablesDirty = new(this, "IsFontAssetLookupTablesDirty");
				}
				return r_FIsFontAssetLookupTablesDirty;
			}
		}

		/// <summary>
		/// System.Action`2[UnityEngine.Texture,UnityEngine.TextCore.Text.FontAsset] OnFontAssetTextureChanged
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RTexture, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset> r_FOnFontAssetTextureChanged;
		public static Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RTexture, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset> RFOnFontAssetTextureChanged
		{
			get
			{
				if(r_FOnFontAssetTextureChanged == null)
				{
					r_FOnFontAssetTextureChanged = new(Type, "OnFontAssetTextureChanged");
				}
				return r_FOnFontAssetTextureChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.TextCore.Text.FontAsset] RegisterResourceForUpdate
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset> r_FRegisterResourceForUpdate;
		public static Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset> RFRegisterResourceForUpdate
		{
			get
			{
				if(r_FRegisterResourceForUpdate == null)
				{
					r_FRegisterResourceForUpdate = new(Type, "RegisterResourceForUpdate");
				}
				return r_FRegisterResourceForUpdate;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.TextCore.Text.FontAsset] RegisterResourceForReimport
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset> r_FRegisterResourceForReimport;
		public static Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset> RFRegisterResourceForReimport
		{
			get
			{
				if(r_FRegisterResourceForReimport == null)
				{
					r_FRegisterResourceForReimport = new(Type, "RegisterResourceForReimport");
				}
				return r_FRegisterResourceForReimport;
			}
		}

		/// <summary>
		/// System.Action`2[UnityEngine.Texture2D,System.Boolean] SetAtlasTextureIsReadable
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RTexture2D, Hvak.Editor.Refleaction.RSystem.RBoolean> r_FSetAtlasTextureIsReadable;
		public static Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RTexture2D, Hvak.Editor.Refleaction.RSystem.RBoolean> RFSetAtlasTextureIsReadable
		{
			get
			{
				if(r_FSetAtlasTextureIsReadable == null)
				{
					r_FSetAtlasTextureIsReadable = new(Type, "SetAtlasTextureIsReadable");
				}
				return r_FSetAtlasTextureIsReadable;
			}
		}

		/// <summary>
		/// System.Func`2[System.String,UnityEngine.Font] GetSourceFontRef
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEngine.RFont> r_FGetSourceFontRef;
		public static Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEngine.RFont> RFGetSourceFontRef
		{
			get
			{
				if(r_FGetSourceFontRef == null)
				{
					r_FGetSourceFontRef = new(Type, "GetSourceFontRef");
				}
				return r_FGetSourceFontRef;
			}
		}

		/// <summary>
		/// System.Func`2[UnityEngine.Font,System.String] SetSourceFontGUID
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEngine.RFont, Hvak.Editor.Refleaction.RSystem.RString> r_FSetSourceFontGUID;
		public static Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEngine.RFont, Hvak.Editor.Refleaction.RSystem.RString> RFSetSourceFontGUID
		{
			get
			{
				if(r_FSetSourceFontGUID == null)
				{
					r_FSetSourceFontGUID = new(Type, "SetSourceFontGUID");
				}
				return r_FSetSourceFontGUID;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_ReadFontAssetDefinitionMarker
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fk_ReadFontAssetDefinitionMarker;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFk_ReadFontAssetDefinitionMarker
		{
			get
			{
				if(r_Fk_ReadFontAssetDefinitionMarker == null)
				{
					r_Fk_ReadFontAssetDefinitionMarker = new(Type, "k_ReadFontAssetDefinitionMarker");
				}
				return r_Fk_ReadFontAssetDefinitionMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_AddSynthesizedCharactersMarker
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fk_AddSynthesizedCharactersMarker;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFk_AddSynthesizedCharactersMarker
		{
			get
			{
				if(r_Fk_AddSynthesizedCharactersMarker == null)
				{
					r_Fk_AddSynthesizedCharactersMarker = new(Type, "k_AddSynthesizedCharactersMarker");
				}
				return r_Fk_AddSynthesizedCharactersMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_TryAddCharacterMarker
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fk_TryAddCharacterMarker;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFk_TryAddCharacterMarker
		{
			get
			{
				if(r_Fk_TryAddCharacterMarker == null)
				{
					r_Fk_TryAddCharacterMarker = new(Type, "k_TryAddCharacterMarker");
				}
				return r_Fk_TryAddCharacterMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_TryAddCharactersMarker
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fk_TryAddCharactersMarker;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFk_TryAddCharactersMarker
		{
			get
			{
				if(r_Fk_TryAddCharactersMarker == null)
				{
					r_Fk_TryAddCharactersMarker = new(Type, "k_TryAddCharactersMarker");
				}
				return r_Fk_TryAddCharactersMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fk_UpdateGlyphAdjustmentRecordsMarker;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFk_UpdateGlyphAdjustmentRecordsMarker
		{
			get
			{
				if(r_Fk_UpdateGlyphAdjustmentRecordsMarker == null)
				{
					r_Fk_UpdateGlyphAdjustmentRecordsMarker = new(Type, "k_UpdateGlyphAdjustmentRecordsMarker");
				}
				return r_Fk_UpdateGlyphAdjustmentRecordsMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fk_UpdateDiacriticalMarkAdjustmentRecordsMarker;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFk_UpdateDiacriticalMarkAdjustmentRecordsMarker
		{
			get
			{
				if(r_Fk_UpdateDiacriticalMarkAdjustmentRecordsMarker == null)
				{
					r_Fk_UpdateDiacriticalMarkAdjustmentRecordsMarker = new(Type, "k_UpdateDiacriticalMarkAdjustmentRecordsMarker");
				}
				return r_Fk_UpdateDiacriticalMarkAdjustmentRecordsMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_ClearFontAssetDataMarker
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fk_ClearFontAssetDataMarker;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFk_ClearFontAssetDataMarker
		{
			get
			{
				if(r_Fk_ClearFontAssetDataMarker == null)
				{
					r_Fk_ClearFontAssetDataMarker = new(Type, "k_ClearFontAssetDataMarker");
				}
				return r_Fk_ClearFontAssetDataMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_UpdateFontAssetDataMarker
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fk_UpdateFontAssetDataMarker;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFk_UpdateFontAssetDataMarker
		{
			get
			{
				if(r_Fk_UpdateFontAssetDataMarker == null)
				{
					r_Fk_UpdateFontAssetDataMarker = new(Type, "k_UpdateFontAssetDataMarker");
				}
				return r_Fk_UpdateFontAssetDataMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_TryAddGlyphMarker
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fk_TryAddGlyphMarker;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFk_TryAddGlyphMarker
		{
			get
			{
				if(r_Fk_TryAddGlyphMarker == null)
				{
					r_Fk_TryAddGlyphMarker = new(Type, "k_TryAddGlyphMarker");
				}
				return r_Fk_TryAddGlyphMarker;
			}
		}

		/// <summary>
		/// System.String s_DefaultMaterialSuffix
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fs_DefaultMaterialSuffix;
		public static Hvak.Editor.Refleaction.RSystem.RString RFs_DefaultMaterialSuffix
		{
			get
			{
				if(r_Fs_DefaultMaterialSuffix == null)
				{
					r_Fs_DefaultMaterialSuffix = new(Type, "s_DefaultMaterialSuffix");
				}
				return r_Fs_DefaultMaterialSuffix;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.Int32] k_SearchedFontAssetLookup
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RInt32> r_Fk_SearchedFontAssetLookup;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RInt32> RFk_SearchedFontAssetLookup
		{
			get
			{
				if(r_Fk_SearchedFontAssetLookup == null)
				{
					r_Fk_SearchedFontAssetLookup = new(Type, "k_SearchedFontAssetLookup");
				}
				return r_Fk_SearchedFontAssetLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.FontAsset] k_FontAssets_FontFeaturesUpdateQueue
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset> r_Fk_FontAssets_FontFeaturesUpdateQueue;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset> RFk_FontAssets_FontFeaturesUpdateQueue
		{
			get
			{
				if(r_Fk_FontAssets_FontFeaturesUpdateQueue == null)
				{
					r_Fk_FontAssets_FontFeaturesUpdateQueue = new(Type, "k_FontAssets_FontFeaturesUpdateQueue");
				}
				return r_Fk_FontAssets_FontFeaturesUpdateQueue;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.Int32] k_FontAssets_FontFeaturesUpdateQueueLookup
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RInt32> r_Fk_FontAssets_FontFeaturesUpdateQueueLookup;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RInt32> RFk_FontAssets_FontFeaturesUpdateQueueLookup
		{
			get
			{
				if(r_Fk_FontAssets_FontFeaturesUpdateQueueLookup == null)
				{
					r_Fk_FontAssets_FontFeaturesUpdateQueueLookup = new(Type, "k_FontAssets_FontFeaturesUpdateQueueLookup");
				}
				return r_Fk_FontAssets_FontFeaturesUpdateQueueLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Texture2D] k_FontAssets_AtlasTexturesUpdateQueue
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTexture2D> r_Fk_FontAssets_AtlasTexturesUpdateQueue;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTexture2D> RFk_FontAssets_AtlasTexturesUpdateQueue
		{
			get
			{
				if(r_Fk_FontAssets_AtlasTexturesUpdateQueue == null)
				{
					r_Fk_FontAssets_AtlasTexturesUpdateQueue = new(Type, "k_FontAssets_AtlasTexturesUpdateQueue");
				}
				return r_Fk_FontAssets_AtlasTexturesUpdateQueue;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.Int32] k_FontAssets_AtlasTexturesUpdateQueueLookup
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RInt32> r_Fk_FontAssets_AtlasTexturesUpdateQueueLookup;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RInt32> RFk_FontAssets_AtlasTexturesUpdateQueueLookup
		{
			get
			{
				if(r_Fk_FontAssets_AtlasTexturesUpdateQueueLookup == null)
				{
					r_Fk_FontAssets_AtlasTexturesUpdateQueueLookup = new(Type, "k_FontAssets_AtlasTexturesUpdateQueueLookup");
				}
				return r_Fk_FontAssets_AtlasTexturesUpdateQueueLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Glyph] m_GlyphsToRender
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyph> r_Fm_GlyphsToRender;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyph> RFm_GlyphsToRender
		{
			get
			{
				if(r_Fm_GlyphsToRender == null)
				{
					r_Fm_GlyphsToRender = new(this, "m_GlyphsToRender");
				}
				return r_Fm_GlyphsToRender;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Glyph] m_GlyphsRendered
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyph> r_Fm_GlyphsRendered;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyph> RFm_GlyphsRendered
		{
			get
			{
				if(r_Fm_GlyphsRendered == null)
				{
					r_Fm_GlyphsRendered = new(this, "m_GlyphsRendered");
				}
				return r_Fm_GlyphsRendered;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.UInt32] m_GlyphIndexList
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RUInt32> r_Fm_GlyphIndexList;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RUInt32> RFm_GlyphIndexList
		{
			get
			{
				if(r_Fm_GlyphIndexList == null)
				{
					r_Fm_GlyphIndexList = new(this, "m_GlyphIndexList");
				}
				return r_Fm_GlyphIndexList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.UInt32] m_GlyphIndexListNewlyAdded
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RUInt32> r_Fm_GlyphIndexListNewlyAdded;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RUInt32> RFm_GlyphIndexListNewlyAdded
		{
			get
			{
				if(r_Fm_GlyphIndexListNewlyAdded == null)
				{
					r_Fm_GlyphIndexListNewlyAdded = new(this, "m_GlyphIndexListNewlyAdded");
				}
				return r_Fm_GlyphIndexListNewlyAdded;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.UInt32] m_GlyphsToAdd
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RUInt32> r_Fm_GlyphsToAdd;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RUInt32> RFm_GlyphsToAdd
		{
			get
			{
				if(r_Fm_GlyphsToAdd == null)
				{
					r_Fm_GlyphsToAdd = new(this, "m_GlyphsToAdd");
				}
				return r_Fm_GlyphsToAdd;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.UInt32] m_GlyphsToAddLookup
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RUInt32> r_Fm_GlyphsToAddLookup;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RUInt32> RFm_GlyphsToAddLookup
		{
			get
			{
				if(r_Fm_GlyphsToAddLookup == null)
				{
					r_Fm_GlyphsToAddLookup = new(this, "m_GlyphsToAddLookup");
				}
				return r_Fm_GlyphsToAddLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.Character] m_CharactersToAdd
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RCharacter> r_Fm_CharactersToAdd;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RCharacter> RFm_CharactersToAdd
		{
			get
			{
				if(r_Fm_CharactersToAdd == null)
				{
					r_Fm_CharactersToAdd = new(this, "m_CharactersToAdd");
				}
				return r_Fm_CharactersToAdd;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.UInt32] m_CharactersToAddLookup
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RUInt32> r_Fm_CharactersToAddLookup;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RUInt32> RFm_CharactersToAddLookup
		{
			get
			{
				if(r_Fm_CharactersToAddLookup == null)
				{
					r_Fm_CharactersToAddLookup = new(this, "m_CharactersToAddLookup");
				}
				return r_Fm_CharactersToAddLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.UInt32] s_MissingCharacterList
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RUInt32> r_Fs_MissingCharacterList;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RUInt32> RFs_MissingCharacterList
		{
			get
			{
				if(r_Fs_MissingCharacterList == null)
				{
					r_Fs_MissingCharacterList = new(this, "s_MissingCharacterList");
				}
				return r_Fs_MissingCharacterList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.UInt32] m_MissingUnicodesFromFontFile
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RUInt32> r_Fm_MissingUnicodesFromFontFile;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RUInt32> RFm_MissingUnicodesFromFontFile
		{
			get
			{
				if(r_Fm_MissingUnicodesFromFontFile == null)
				{
					r_Fm_MissingUnicodesFromFontFile = new(this, "m_MissingUnicodesFromFontFile");
				}
				return r_Fm_MissingUnicodesFromFontFile;
			}
		}

		/// <summary>
		/// System.UInt32[] k_GlyphIndexArray
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RUInt32> r_Fk_GlyphIndexArray;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RUInt32> RFk_GlyphIndexArray
		{
			get
			{
				if(r_Fk_GlyphIndexArray == null)
				{
					r_Fk_GlyphIndexArray = new(Type, "k_GlyphIndexArray");
				}
				return r_Fk_GlyphIndexArray;
			}
		}

		/// <summary>
		/// System.String m_Version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Version;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Version
		{
			get
			{
				if(r_Fm_Version == null)
				{
					r_Fm_Version = new(this, "m_Version");
				}
				return r_Fm_Version;
			}
		}

		/// <summary>
		/// System.Int32 m_InstanceID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_InstanceID;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_InstanceID
		{
			get
			{
				if(r_Fm_InstanceID == null)
				{
					r_Fm_InstanceID = new(this, "m_InstanceID");
				}
				return r_Fm_InstanceID;
			}
		}

		/// <summary>
		/// System.Int32 m_HashCode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_HashCode;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_HashCode
		{
			get
			{
				if(r_Fm_HashCode == null)
				{
					r_Fm_HashCode = new(this, "m_HashCode");
				}
				return r_Fm_HashCode;
			}
		}

		/// <summary>
		/// UnityEngine.Material m_Material
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMaterial r_Fm_Material;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMaterial RFm_Material
		{
			get
			{
				if(r_Fm_Material == null)
				{
					r_Fm_Material = new(this, "m_Material");
				}
				return r_Fm_Material;
			}
		}

		/// <summary>
		/// System.Int32 m_MaterialHashCode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_MaterialHashCode;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_MaterialHashCode
		{
			get
			{
				if(r_Fm_MaterialHashCode == null)
				{
					r_Fm_MaterialHashCode = new(this, "m_MaterialHashCode");
				}
				return r_Fm_MaterialHashCode;
			}
		}

		/// <summary>
		/// UnityEngine.Font SourceFont_EditorRef
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RFont r_PSourceFont_EditorRef;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RFont RPSourceFont_EditorRef
		{
			get
			{
				if(r_PSourceFont_EditorRef == null)
				{
					r_PSourceFont_EditorRef = new(this, "SourceFont_EditorRef", -1);
				}
				return r_PSourceFont_EditorRef;
			}
		}

		/// <summary>
		/// UnityEngine.Font sourceFontFile
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RFont r_PsourceFontFile;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RFont RPsourceFontFile
		{
			get
			{
				if(r_PsourceFontFile == null)
				{
					r_PsourceFontFile = new(this, "sourceFontFile", -1);
				}
				return r_PsourceFontFile;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RAtlasPopulationMode r_PatlasPopulationMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RAtlasPopulationMode RPatlasPopulationMode
		{
			get
			{
				if(r_PatlasPopulationMode == null)
				{
					r_PatlasPopulationMode = new(this, "atlasPopulationMode", -1);
				}
				return r_PatlasPopulationMode;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.FaceInfo faceInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RFaceInfo r_PfaceInfo;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RFaceInfo RPfaceInfo
		{
			get
			{
				if(r_PfaceInfo == null)
				{
					r_PfaceInfo = new(this, "faceInfo", -1);
				}
				return r_PfaceInfo;
			}
		}

		/// <summary>
		/// Int32 familyNameHashCode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PfamilyNameHashCode;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPfamilyNameHashCode
		{
			get
			{
				if(r_PfamilyNameHashCode == null)
				{
					r_PfamilyNameHashCode = new(this, "familyNameHashCode", -1);
				}
				return r_PfamilyNameHashCode;
			}
		}

		/// <summary>
		/// Int32 styleNameHashCode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PstyleNameHashCode;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPstyleNameHashCode
		{
			get
			{
				if(r_PstyleNameHashCode == null)
				{
					r_PstyleNameHashCode = new(this, "styleNameHashCode", -1);
				}
				return r_PstyleNameHashCode;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Glyph] glyphTable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyph> r_PglyphTable;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyph> RPglyphTable
		{
			get
			{
				if(r_PglyphTable == null)
				{
					r_PglyphTable = new(this, "glyphTable", -1);
				}
				return r_PglyphTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.Glyph] glyphLookupTable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RUInt32, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyph> r_PglyphLookupTable;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RUInt32, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyph> RPglyphLookupTable
		{
			get
			{
				if(r_PglyphLookupTable == null)
				{
					r_PglyphLookupTable = new(this, "glyphLookupTable", -1);
				}
				return r_PglyphLookupTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.Character] characterTable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RCharacter> r_PcharacterTable;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RCharacter> RPcharacterTable
		{
			get
			{
				if(r_PcharacterTable == null)
				{
					r_PcharacterTable = new(this, "characterTable", -1);
				}
				return r_PcharacterTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.Text.Character] characterLookupTable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RUInt32, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RCharacter> r_PcharacterLookupTable;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RUInt32, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RCharacter> RPcharacterLookupTable
		{
			get
			{
				if(r_PcharacterLookupTable == null)
				{
					r_PcharacterLookupTable = new(this, "characterLookupTable", -1);
				}
				return r_PcharacterLookupTable;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D atlasTexture
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture2D r_PatlasTexture;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture2D RPatlasTexture
		{
			get
			{
				if(r_PatlasTexture == null)
				{
					r_PatlasTexture = new(this, "atlasTexture", -1);
				}
				return r_PatlasTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D[] atlasTextures
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RTexture2D> r_PatlasTextures;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RTexture2D> RPatlasTextures
		{
			get
			{
				if(r_PatlasTextures == null)
				{
					r_PatlasTextures = new(this, "atlasTextures", -1);
				}
				return r_PatlasTextures;
			}
		}

		/// <summary>
		/// Int32 atlasTextureCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PatlasTextureCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPatlasTextureCount
		{
			get
			{
				if(r_PatlasTextureCount == null)
				{
					r_PatlasTextureCount = new(this, "atlasTextureCount", -1);
				}
				return r_PatlasTextureCount;
			}
		}

		/// <summary>
		/// Boolean isMultiAtlasTexturesEnabled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisMultiAtlasTexturesEnabled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisMultiAtlasTexturesEnabled
		{
			get
			{
				if(r_PisMultiAtlasTexturesEnabled == null)
				{
					r_PisMultiAtlasTexturesEnabled = new(this, "isMultiAtlasTexturesEnabled", -1);
				}
				return r_PisMultiAtlasTexturesEnabled;
			}
		}

		/// <summary>
		/// Boolean clearDynamicDataOnBuild
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PclearDynamicDataOnBuild;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPclearDynamicDataOnBuild
		{
			get
			{
				if(r_PclearDynamicDataOnBuild == null)
				{
					r_PclearDynamicDataOnBuild = new(this, "clearDynamicDataOnBuild", -1);
				}
				return r_PclearDynamicDataOnBuild;
			}
		}

		/// <summary>
		/// Int32 atlasWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PatlasWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPatlasWidth
		{
			get
			{
				if(r_PatlasWidth == null)
				{
					r_PatlasWidth = new(this, "atlasWidth", -1);
				}
				return r_PatlasWidth;
			}
		}

		/// <summary>
		/// Int32 atlasHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PatlasHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPatlasHeight
		{
			get
			{
				if(r_PatlasHeight == null)
				{
					r_PatlasHeight = new(this, "atlasHeight", -1);
				}
				return r_PatlasHeight;
			}
		}

		/// <summary>
		/// Int32 atlasPadding
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PatlasPadding;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPatlasPadding
		{
			get
			{
				if(r_PatlasPadding == null)
				{
					r_PatlasPadding = new(this, "atlasPadding", -1);
				}
				return r_PatlasPadding;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphRenderMode atlasRenderMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode r_PatlasRenderMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphRenderMode RPatlasRenderMode
		{
			get
			{
				if(r_PatlasRenderMode == null)
				{
					r_PatlasRenderMode = new(this, "atlasRenderMode", -1);
				}
				return r_PatlasRenderMode;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.GlyphRect] usedGlyphRects
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyphRect> r_PusedGlyphRects;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyphRect> RPusedGlyphRects
		{
			get
			{
				if(r_PusedGlyphRects == null)
				{
					r_PusedGlyphRects = new(this, "usedGlyphRects", -1);
				}
				return r_PusedGlyphRects;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.GlyphRect] freeGlyphRects
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyphRect> r_PfreeGlyphRects;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyphRect> RPfreeGlyphRects
		{
			get
			{
				if(r_PfreeGlyphRects == null)
				{
					r_PfreeGlyphRects = new(this, "freeGlyphRects", -1);
				}
				return r_PfreeGlyphRects;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontFeatureTable fontFeatureTable
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontFeatureTable r_PfontFeatureTable;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontFeatureTable RPfontFeatureTable
		{
			get
			{
				if(r_PfontFeatureTable == null)
				{
					r_PfontFeatureTable = new(this, "fontFeatureTable", -1);
				}
				return r_PfontFeatureTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.FontAsset] fallbackFontAssetTable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset> r_PfallbackFontAssetTable;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset> RPfallbackFontAssetTable
		{
			get
			{
				if(r_PfallbackFontAssetTable == null)
				{
					r_PfallbackFontAssetTable = new(this, "fallbackFontAssetTable", -1);
				}
				return r_PfallbackFontAssetTable;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAssetCreationEditorSettings fontAssetCreationEditorSettings
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAssetCreationEditorSettings r_PfontAssetCreationEditorSettings;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAssetCreationEditorSettings RPfontAssetCreationEditorSettings
		{
			get
			{
				if(r_PfontAssetCreationEditorSettings == null)
				{
					r_PfontAssetCreationEditorSettings = new(this, "fontAssetCreationEditorSettings", -1);
				}
				return r_PfontAssetCreationEditorSettings;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontWeightPair[] fontWeightTable
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontWeightPair> r_PfontWeightTable;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontWeightPair> RPfontWeightTable
		{
			get
			{
				if(r_PfontWeightTable == null)
				{
					r_PfontWeightTable = new(this, "fontWeightTable", -1);
				}
				return r_PfontWeightTable;
			}
		}

		/// <summary>
		/// Single regularStyleWeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PregularStyleWeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPregularStyleWeight
		{
			get
			{
				if(r_PregularStyleWeight == null)
				{
					r_PregularStyleWeight = new(this, "regularStyleWeight", -1);
				}
				return r_PregularStyleWeight;
			}
		}

		/// <summary>
		/// Single regularStyleSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PregularStyleSpacing;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPregularStyleSpacing
		{
			get
			{
				if(r_PregularStyleSpacing == null)
				{
					r_PregularStyleSpacing = new(this, "regularStyleSpacing", -1);
				}
				return r_PregularStyleSpacing;
			}
		}

		/// <summary>
		/// Single boldStyleWeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PboldStyleWeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPboldStyleWeight
		{
			get
			{
				if(r_PboldStyleWeight == null)
				{
					r_PboldStyleWeight = new(this, "boldStyleWeight", -1);
				}
				return r_PboldStyleWeight;
			}
		}

		/// <summary>
		/// Single boldStyleSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PboldStyleSpacing;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPboldStyleSpacing
		{
			get
			{
				if(r_PboldStyleSpacing == null)
				{
					r_PboldStyleSpacing = new(this, "boldStyleSpacing", -1);
				}
				return r_PboldStyleSpacing;
			}
		}

		/// <summary>
		/// Byte italicStyleSlant
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_PitalicStyleSlant;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RPitalicStyleSlant
		{
			get
			{
				if(r_PitalicStyleSlant == null)
				{
					r_PitalicStyleSlant = new(this, "italicStyleSlant", -1);
				}
				return r_PitalicStyleSlant;
			}
		}

		/// <summary>
		/// Byte tabMultiple
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_PtabMultiple;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RPtabMultiple
		{
			get
			{
				if(r_PtabMultiple == null)
				{
					r_PtabMultiple = new(this, "tabMultiple", -1);
				}
				return r_PtabMultiple;
			}
		}

		/// <summary>
		/// System.String version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pversion;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPversion
		{
			get
			{
				if(r_Pversion == null)
				{
					r_Pversion = new(this, "version", -1);
				}
				return r_Pversion;
			}
		}

		/// <summary>
		/// Int32 instanceID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PinstanceID;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPinstanceID
		{
			get
			{
				if(r_PinstanceID == null)
				{
					r_PinstanceID = new(this, "instanceID", -1);
				}
				return r_PinstanceID;
			}
		}

		/// <summary>
		/// Int32 hashCode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PhashCode;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPhashCode
		{
			get
			{
				if(r_PhashCode == null)
				{
					r_PhashCode = new(this, "hashCode", -1);
				}
				return r_PhashCode;
			}
		}

		/// <summary>
		/// UnityEngine.Material material
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMaterial r_Pmaterial;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMaterial RPmaterial
		{
			get
			{
				if(r_Pmaterial == null)
				{
					r_Pmaterial = new(this, "material", -1);
				}
				return r_Pmaterial;
			}
		}

		/// <summary>
		/// Int32 materialHashCode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PmaterialHashCode;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPmaterialHashCode
		{
			get
			{
				if(r_PmaterialHashCode == null)
				{
					r_PmaterialHashCode = new(this, "materialHashCode", -1);
				}
				return r_PmaterialHashCode;
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
		/// UnityEngine.TextCore.Text.FontAsset CreateFontAsset(System.String, System.String, Int32)
		/// </summary>
		protected static RMethod r_MCreateFontAsset_String_String_Int32;
		public static RMethod RMCreateFontAsset_String_String_Int32
		{
			get
			{
				if(r_MCreateFontAsset_String_String_Int32 == null)
				{
					r_MCreateFontAsset_String_String_Int32 = new(Type, "CreateFontAsset", 0, typeof(System.String), typeof(System.String), typeof(System.Int32));
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
					r_MCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32 = new(Type, "CreateFontAsset", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), typeof(System.Int32), typeof(System.Int32));
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
					r_MCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean = new(Type, "CreateFontAsset", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextCore.Text.AtlasPopulationMode), typeof(System.Boolean));
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
					r_MCreateFontAsset_Font = new(Type, "CreateFontAsset", 0, typeof(UnityEngine.Font));
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
					r_MCreateFontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean = new(Type, "CreateFontAsset", 0, typeof(UnityEngine.Font), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextCore.Text.AtlasPopulationMode), typeof(System.Boolean));
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
					r_MCreateFontAsset_Font_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean = new(Type, "CreateFontAsset", 0, typeof(UnityEngine.Font), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextCore.Text.AtlasPopulationMode), typeof(System.Boolean));
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
					r_MCreateFontAssetInstance_Font_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean = new(Type, "CreateFontAssetInstance", 0, typeof(UnityEngine.Font), typeof(System.Int32), typeof(UnityEngine.TextCore.LowLevel.GlyphRenderMode), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextCore.Text.AtlasPopulationMode), typeof(System.Boolean));
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
					r_MHasCharacters_String_Out_List_d_Char_p_ = new(this, "HasCharacters", 0, typeof(System.String),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.Char)).MakeByRefType());
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
					r_MGetCharacters_FontAsset = new(Type, "GetCharacters", 0, typeof(UnityEngine.TextCore.Text.FontAsset));
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
					r_MGetCharactersArray_FontAsset = new(Type, "GetCharactersArray", 0, typeof(UnityEngine.TextCore.Text.FontAsset));
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
					r_MRegisterFontAssetForFontFeatureUpdate_FontAsset = new(Type, "RegisterFontAssetForFontFeatureUpdate", 0, typeof(UnityEngine.TextCore.Text.FontAsset));
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
					r_MUpdateFontFeaturesForFontAssetsInQueue = new(Type, "UpdateFontFeaturesForFontAssetsInQueue", 0);
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
					r_MRegisterAtlasTextureForApply_Texture2D = new(Type, "RegisterAtlasTextureForApply", 0, typeof(UnityEngine.Texture2D));
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
					r_MUpdateAtlasTexturesInQueue = new(Type, "UpdateAtlasTexturesInQueue", 0);
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
					r_MUpdateFontAssetsInUpdateQueue = new(Type, "UpdateFontAssetsInUpdateQueue", 0);
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
					r_MUpdateGlyphAdjustmentRecords_List_d_UInt32_p_ = new(this, "UpdateGlyphAdjustmentRecords", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.UInt32)));
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
					r_MUpdateGlyphAdjustmentRecords_List_d_UInt32_p__List_d_UInt32_p_ = new(this, "UpdateGlyphAdjustmentRecords", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.UInt32)),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.UInt32)));
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
					r_MCopyListDataToArray_GT_List_d_T_p__Ref_TArray = new(this, "CopyListDataToArray", 1,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0).MakeArrayType().MakeByRefType());
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


        public static UnityEngine.TextCore.Text.FontAsset CreateFontAsset(System.String @familyName, System.String @styleName, System.Int32 @pointSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@familyName, @styleName, @pointSize};
            var ___result = RMCreateFontAsset_String_String_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.TextCore.Text.FontAsset>(___result);
        }


        public static UnityEngine.TextCore.Text.FontAsset CreateFontAsset(System.String @fontFilePath, System.Int32 @faceIndex, System.Int32 @samplingPointSize, System.Int32 @atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode @renderMode, System.Int32 @atlasWidth, System.Int32 @atlasHeight)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fontFilePath, @faceIndex, @samplingPointSize, @atlasPadding, @renderMode, @atlasWidth, @atlasHeight};
            var ___result = RMCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.TextCore.Text.FontAsset>(___result);
        }


        public static UnityEngine.TextCore.Text.FontAsset CreateFontAsset(System.String @fontFilePath, System.Int32 @faceIndex, System.Int32 @samplingPointSize, System.Int32 @atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode @renderMode, System.Int32 @atlasWidth, System.Int32 @atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode @atlasPopulationMode, System.Boolean @enableMultiAtlasSupport)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fontFilePath, @faceIndex, @samplingPointSize, @atlasPadding, @renderMode, @atlasWidth, @atlasHeight, @atlasPopulationMode, @enableMultiAtlasSupport};
            var ___result = RMCreateFontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.TextCore.Text.FontAsset>(___result);
        }


        public static UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font @font)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@font};
            var ___result = RMCreateFontAsset_Font.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.TextCore.Text.FontAsset>(___result);
        }


        public static UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font @font, System.Int32 @samplingPointSize, System.Int32 @atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode @renderMode, System.Int32 @atlasWidth, System.Int32 @atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode @atlasPopulationMode, System.Boolean @enableMultiAtlasSupport)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@font, @samplingPointSize, @atlasPadding, @renderMode, @atlasWidth, @atlasHeight, @atlasPopulationMode, @enableMultiAtlasSupport};
            var ___result = RMCreateFontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.TextCore.Text.FontAsset>(___result);
        }


        public static UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font @font, System.Int32 @faceIndex, System.Int32 @samplingPointSize, System.Int32 @atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode @renderMode, System.Int32 @atlasWidth, System.Int32 @atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode @atlasPopulationMode, System.Boolean @enableMultiAtlasSupport)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@font, @faceIndex, @samplingPointSize, @atlasPadding, @renderMode, @atlasWidth, @atlasHeight, @atlasPopulationMode, @enableMultiAtlasSupport};
            var ___result = RMCreateFontAsset_Font_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.TextCore.Text.FontAsset>(___result);
        }


        public static UnityEngine.TextCore.Text.FontAsset CreateFontAssetInstance(UnityEngine.Font @font, System.Int32 @atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode @renderMode, System.Int32 @atlasWidth, System.Int32 @atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode @atlasPopulationMode, System.Boolean @enableMultiAtlasSupport)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@font, @atlasPadding, @renderMode, @atlasWidth, @atlasHeight, @atlasPopulationMode, @enableMultiAtlasSupport};
            var ___result = RMCreateFontAssetInstance_Font_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.TextCore.Text.FontAsset>(___result);
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

            return ReflectionUtils.Convert<UnityEngine.TextCore.LowLevel.FontEngineError>(___result);
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

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasCharacter(System.Char @character, System.Boolean @searchFallbacks, System.Boolean @tryAddCharacter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@character, @searchFallbacks, @tryAddCharacter};
            var ___result = RMHasCharacter_Char_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasCharacter_Internal(System.UInt32 @character, System.Boolean @searchFallbacks, System.Boolean @tryAddCharacter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@character, @searchFallbacks, @tryAddCharacter};
            var ___result = RMHasCharacter_Internal_UInt32_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasCharacters(System.String @text, out System.Collections.Generic.List<System.Char> @missingCharacters)
        {
			@missingCharacters = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @missingCharacters};
            var ___result = RMHasCharacters_String_Out_List_d_Char_p_.Invoke(___genericsType, ___parameters);
			@missingCharacters = ReflectionUtils.Convert<System.Collections.Generic.List<System.Char>>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasCharacters(System.String @text, out System.UInt32[] @missingCharacters, System.Boolean @searchFallbacks, System.Boolean @tryAddCharacter)
        {
			@missingCharacters = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @missingCharacters, @searchFallbacks, @tryAddCharacter};
            var ___result = RMHasCharacters_String_Out_UInt32Array_Boolean_Boolean.Invoke(___genericsType, ___parameters);
			@missingCharacters = ReflectionUtils.Convert<System.UInt32[]>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasCharacters(System.String @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RMHasCharacters_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.String GetCharacters(UnityEngine.TextCore.Text.FontAsset @fontAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fontAsset};
            var ___result = RMGetCharacters_FontAsset.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static System.Int32[] GetCharactersArray(UnityEngine.TextCore.Text.FontAsset @fontAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fontAsset};
            var ___result = RMGetCharactersArray_FontAsset.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32[]>(___result);
        }


        public virtual System.UInt32 GetGlyphIndex(System.UInt32 @unicode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unicode};
            var ___result = RMGetGlyphIndex_UInt32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.UInt32>(___result);
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

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean TryAddCharacters(System.UInt32[] @unicodes, out System.UInt32[] @missingUnicodes, System.Boolean @includeFontFeatures)
        {
			@missingUnicodes = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unicodes, @missingUnicodes, @includeFontFeatures};
            var ___result = RMTryAddCharacters_UInt32Array_Out_UInt32Array_Boolean.Invoke(___genericsType, ___parameters);
			@missingUnicodes = ReflectionUtils.Convert<System.UInt32[]>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean TryAddCharacters(System.String @characters, System.Boolean @includeFontFeatures)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@characters, @includeFontFeatures};
            var ___result = RMTryAddCharacters_String_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean TryAddCharacters(System.String @characters, out System.String @missingCharacters, System.Boolean @includeFontFeatures)
        {
			@missingCharacters = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@characters, @missingCharacters, @includeFontFeatures};
            var ___result = RMTryAddCharacters_String_Out_String_Boolean.Invoke(___genericsType, ___parameters);
			@missingCharacters = ReflectionUtils.Convert<System.String>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean TryAddGlyphInternal(System.UInt32 @glyphIndex, out UnityEngine.TextCore.Glyph @glyph)
        {
			@glyph = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@glyphIndex, @glyph};
            var ___result = RMTryAddGlyphInternal_UInt32_Out_Glyph.Invoke(___genericsType, ___parameters);
			@glyph = ReflectionUtils.Convert<UnityEngine.TextCore.Glyph>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean TryAddCharacterInternal(System.UInt32 @unicode, out UnityEngine.TextCore.Text.Character @character, System.Boolean @shouldGetFontFeatures)
        {
			@character = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unicode, @character, @shouldGetFontFeatures};
            var ___result = RMTryAddCharacterInternal_UInt32_Out_Character_Boolean.Invoke(___genericsType, ___parameters);
			@character = ReflectionUtils.Convert<UnityEngine.TextCore.Text.Character>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean TryGetCharacter_and_QueueRenderToTexture(System.UInt32 @unicode, out UnityEngine.TextCore.Text.Character @character, System.Boolean @shouldGetFontFeatures)
        {
			@character = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unicode, @character, @shouldGetFontFeatures};
            var ___result = RMTryGetCharacter_and_QueueRenderToTexture_UInt32_Out_Character_Boolean.Invoke(___genericsType, ___parameters);
			@character = ReflectionUtils.Convert<UnityEngine.TextCore.Text.Character>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
			@dstArray = ReflectionUtils.Convert<T[]>(___parameters[1]);

            
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
