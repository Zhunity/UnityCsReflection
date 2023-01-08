using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.TextSettings
	/// </summary>
    public partial class RTextSettings : RMember //
    {

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
		/// UnityEngine.TextCore.Text.FontAsset m_DefaultFontAsset
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RFontAsset r_m_DefaultFontAsset;
		public virtual RUnityEngine.RTextCore.RText.RFontAsset Rm_DefaultFontAsset
		{
			get
			{
				if(r_m_DefaultFontAsset == null)
				{
					r_m_DefaultFontAsset = new(this, "m_DefaultFontAsset");
					r_m_DefaultFontAsset.SetBelong(this.instance);
				}
				return r_m_DefaultFontAsset;
			}
		}

		/// <summary>
		/// System.String m_DefaultFontAssetPath
		/// </summary>
		protected RField r_m_DefaultFontAssetPath;
		public virtual RField Rm_DefaultFontAssetPath
		{
			get
			{
				if(r_m_DefaultFontAssetPath == null)
				{
					r_m_DefaultFontAssetPath = new(this, "m_DefaultFontAssetPath");
					r_m_DefaultFontAssetPath.SetBelong(this.instance);
				}
				return r_m_DefaultFontAssetPath;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.FontAsset] m_FallbackFontAssets
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RFontAsset> r_m_FallbackFontAssets;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RFontAsset> Rm_FallbackFontAssets
		{
			get
			{
				if(r_m_FallbackFontAssets == null)
				{
					r_m_FallbackFontAssets = new(this, "m_FallbackFontAssets");
					r_m_FallbackFontAssets.SetBelong(this.instance);
				}
				return r_m_FallbackFontAssets;
			}
		}

		/// <summary>
		/// System.Boolean m_MatchMaterialPreset
		/// </summary>
		protected RField r_m_MatchMaterialPreset;
		public virtual RField Rm_MatchMaterialPreset
		{
			get
			{
				if(r_m_MatchMaterialPreset == null)
				{
					r_m_MatchMaterialPreset = new(this, "m_MatchMaterialPreset");
					r_m_MatchMaterialPreset.SetBelong(this.instance);
				}
				return r_m_MatchMaterialPreset;
			}
		}

		/// <summary>
		/// System.Int32 m_MissingCharacterUnicode
		/// </summary>
		protected RField r_m_MissingCharacterUnicode;
		public virtual RField Rm_MissingCharacterUnicode
		{
			get
			{
				if(r_m_MissingCharacterUnicode == null)
				{
					r_m_MissingCharacterUnicode = new(this, "m_MissingCharacterUnicode");
					r_m_MissingCharacterUnicode.SetBelong(this.instance);
				}
				return r_m_MissingCharacterUnicode;
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
		/// UnityEngine.TextCore.Text.SpriteAsset m_DefaultSpriteAsset
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RSpriteAsset r_m_DefaultSpriteAsset;
		public virtual RUnityEngine.RTextCore.RText.RSpriteAsset Rm_DefaultSpriteAsset
		{
			get
			{
				if(r_m_DefaultSpriteAsset == null)
				{
					r_m_DefaultSpriteAsset = new(this, "m_DefaultSpriteAsset");
					r_m_DefaultSpriteAsset.SetBelong(this.instance);
				}
				return r_m_DefaultSpriteAsset;
			}
		}

		/// <summary>
		/// System.String m_DefaultSpriteAssetPath
		/// </summary>
		protected RField r_m_DefaultSpriteAssetPath;
		public virtual RField Rm_DefaultSpriteAssetPath
		{
			get
			{
				if(r_m_DefaultSpriteAssetPath == null)
				{
					r_m_DefaultSpriteAssetPath = new(this, "m_DefaultSpriteAssetPath");
					r_m_DefaultSpriteAssetPath.SetBelong(this.instance);
				}
				return r_m_DefaultSpriteAssetPath;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.SpriteAsset] m_FallbackSpriteAssets
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RSpriteAsset> r_m_FallbackSpriteAssets;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RSpriteAsset> Rm_FallbackSpriteAssets
		{
			get
			{
				if(r_m_FallbackSpriteAssets == null)
				{
					r_m_FallbackSpriteAssets = new(this, "m_FallbackSpriteAssets");
					r_m_FallbackSpriteAssets.SetBelong(this.instance);
				}
				return r_m_FallbackSpriteAssets;
			}
		}

		/// <summary>
		/// System.UInt32 m_MissingSpriteCharacterUnicode
		/// </summary>
		protected RField r_m_MissingSpriteCharacterUnicode;
		public virtual RField Rm_MissingSpriteCharacterUnicode
		{
			get
			{
				if(r_m_MissingSpriteCharacterUnicode == null)
				{
					r_m_MissingSpriteCharacterUnicode = new(this, "m_MissingSpriteCharacterUnicode");
					r_m_MissingSpriteCharacterUnicode.SetBelong(this.instance);
				}
				return r_m_MissingSpriteCharacterUnicode;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextStyleSheet m_DefaultStyleSheet
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RTextStyleSheet r_m_DefaultStyleSheet;
		public virtual RUnityEngine.RTextCore.RText.RTextStyleSheet Rm_DefaultStyleSheet
		{
			get
			{
				if(r_m_DefaultStyleSheet == null)
				{
					r_m_DefaultStyleSheet = new(this, "m_DefaultStyleSheet");
					r_m_DefaultStyleSheet.SetBelong(this.instance);
				}
				return r_m_DefaultStyleSheet;
			}
		}

		/// <summary>
		/// System.String m_StyleSheetsResourcePath
		/// </summary>
		protected RField r_m_StyleSheetsResourcePath;
		public virtual RField Rm_StyleSheetsResourcePath
		{
			get
			{
				if(r_m_StyleSheetsResourcePath == null)
				{
					r_m_StyleSheetsResourcePath = new(this, "m_StyleSheetsResourcePath");
					r_m_StyleSheetsResourcePath.SetBelong(this.instance);
				}
				return r_m_StyleSheetsResourcePath;
			}
		}

		/// <summary>
		/// System.String m_DefaultColorGradientPresetsPath
		/// </summary>
		protected RField r_m_DefaultColorGradientPresetsPath;
		public virtual RField Rm_DefaultColorGradientPresetsPath
		{
			get
			{
				if(r_m_DefaultColorGradientPresetsPath == null)
				{
					r_m_DefaultColorGradientPresetsPath = new(this, "m_DefaultColorGradientPresetsPath");
					r_m_DefaultColorGradientPresetsPath.SetBelong(this.instance);
				}
				return r_m_DefaultColorGradientPresetsPath;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.UnicodeLineBreakingRules m_UnicodeLineBreakingRules
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RUnicodeLineBreakingRules r_m_UnicodeLineBreakingRules;
		public virtual RUnityEngine.RTextCore.RText.RUnicodeLineBreakingRules Rm_UnicodeLineBreakingRules
		{
			get
			{
				if(r_m_UnicodeLineBreakingRules == null)
				{
					r_m_UnicodeLineBreakingRules = new(this, "m_UnicodeLineBreakingRules");
					r_m_UnicodeLineBreakingRules.SetBelong(this.instance);
				}
				return r_m_UnicodeLineBreakingRules;
			}
		}

		/// <summary>
		/// System.Boolean m_UseModernHangulLineBreakingRules
		/// </summary>
		protected RField r_m_UseModernHangulLineBreakingRules;
		public virtual RField Rm_UseModernHangulLineBreakingRules
		{
			get
			{
				if(r_m_UseModernHangulLineBreakingRules == null)
				{
					r_m_UseModernHangulLineBreakingRules = new(this, "m_UseModernHangulLineBreakingRules");
					r_m_UseModernHangulLineBreakingRules.SetBelong(this.instance);
				}
				return r_m_UseModernHangulLineBreakingRules;
			}
		}

		/// <summary>
		/// System.Boolean m_DisplayWarnings
		/// </summary>
		protected RField r_m_DisplayWarnings;
		public virtual RField Rm_DisplayWarnings
		{
			get
			{
				if(r_m_DisplayWarnings == null)
				{
					r_m_DisplayWarnings = new(this, "m_DisplayWarnings");
					r_m_DisplayWarnings.SetBelong(this.instance);
				}
				return r_m_DisplayWarnings;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,UnityEngine.TextCore.Text.FontAsset] m_FontLookup
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RTextCore.RText.RFontAsset> r_m_FontLookup;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RTextCore.RText.RFontAsset> Rm_FontLookup
		{
			get
			{
				if(r_m_FontLookup == null)
				{
					r_m_FontLookup = new(this, "m_FontLookup");
					r_m_FontLookup.SetBelong(this.instance);
				}
				return r_m_FontLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.TextSettings+FontReferenceMap] m_FontReferences
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RTextSettings.RFontReferenceMap> r_m_FontReferences;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RTextSettings.RFontReferenceMap> Rm_FontReferences
		{
			get
			{
				if(r_m_FontReferences == null)
				{
					r_m_FontReferences = new(this, "m_FontReferences");
					r_m_FontReferences.SetBelong(this.instance);
				}
				return r_m_FontReferences;
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
		/// UnityEngine.TextCore.Text.FontAsset defaultFontAsset
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RFontAsset r_defaultFontAsset;
		public virtual RUnityEngine.RTextCore.RText.RFontAsset RdefaultFontAsset
		{
			get
			{
				if(r_defaultFontAsset == null)
				{
					r_defaultFontAsset = new(this, "defaultFontAsset", -1);
					r_defaultFontAsset.SetBelong(this.instance);
				}
				return r_defaultFontAsset;
			}
		}

		/// <summary>
		/// System.String defaultFontAssetPath
		/// </summary>
		protected RProperty r_defaultFontAssetPath;
		public virtual RProperty RdefaultFontAssetPath
		{
			get
			{
				if(r_defaultFontAssetPath == null)
				{
					r_defaultFontAssetPath = new(this, "defaultFontAssetPath", -1);
					r_defaultFontAssetPath.SetBelong(this.instance);
				}
				return r_defaultFontAssetPath;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.FontAsset] fallbackFontAssets
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RFontAsset> r_fallbackFontAssets;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RFontAsset> RfallbackFontAssets
		{
			get
			{
				if(r_fallbackFontAssets == null)
				{
					r_fallbackFontAssets = new(this, "fallbackFontAssets", -1);
					r_fallbackFontAssets.SetBelong(this.instance);
				}
				return r_fallbackFontAssets;
			}
		}

		/// <summary>
		/// Boolean matchMaterialPreset
		/// </summary>
		protected RProperty r_matchMaterialPreset;
		public virtual RProperty RmatchMaterialPreset
		{
			get
			{
				if(r_matchMaterialPreset == null)
				{
					r_matchMaterialPreset = new(this, "matchMaterialPreset", -1);
					r_matchMaterialPreset.SetBelong(this.instance);
				}
				return r_matchMaterialPreset;
			}
		}

		/// <summary>
		/// Int32 missingCharacterUnicode
		/// </summary>
		protected RProperty r_missingCharacterUnicode;
		public virtual RProperty RmissingCharacterUnicode
		{
			get
			{
				if(r_missingCharacterUnicode == null)
				{
					r_missingCharacterUnicode = new(this, "missingCharacterUnicode", -1);
					r_missingCharacterUnicode.SetBelong(this.instance);
				}
				return r_missingCharacterUnicode;
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
		/// UnityEngine.TextCore.Text.SpriteAsset defaultSpriteAsset
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RSpriteAsset r_defaultSpriteAsset;
		public virtual RUnityEngine.RTextCore.RText.RSpriteAsset RdefaultSpriteAsset
		{
			get
			{
				if(r_defaultSpriteAsset == null)
				{
					r_defaultSpriteAsset = new(this, "defaultSpriteAsset", -1);
					r_defaultSpriteAsset.SetBelong(this.instance);
				}
				return r_defaultSpriteAsset;
			}
		}

		/// <summary>
		/// System.String defaultSpriteAssetPath
		/// </summary>
		protected RProperty r_defaultSpriteAssetPath;
		public virtual RProperty RdefaultSpriteAssetPath
		{
			get
			{
				if(r_defaultSpriteAssetPath == null)
				{
					r_defaultSpriteAssetPath = new(this, "defaultSpriteAssetPath", -1);
					r_defaultSpriteAssetPath.SetBelong(this.instance);
				}
				return r_defaultSpriteAssetPath;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.SpriteAsset] fallbackSpriteAssets
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RSpriteAsset> r_fallbackSpriteAssets;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RSpriteAsset> RfallbackSpriteAssets
		{
			get
			{
				if(r_fallbackSpriteAssets == null)
				{
					r_fallbackSpriteAssets = new(this, "fallbackSpriteAssets", -1);
					r_fallbackSpriteAssets.SetBelong(this.instance);
				}
				return r_fallbackSpriteAssets;
			}
		}

		/// <summary>
		/// UInt32 missingSpriteCharacterUnicode
		/// </summary>
		protected RProperty r_missingSpriteCharacterUnicode;
		public virtual RProperty RmissingSpriteCharacterUnicode
		{
			get
			{
				if(r_missingSpriteCharacterUnicode == null)
				{
					r_missingSpriteCharacterUnicode = new(this, "missingSpriteCharacterUnicode", -1);
					r_missingSpriteCharacterUnicode.SetBelong(this.instance);
				}
				return r_missingSpriteCharacterUnicode;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextStyleSheet defaultStyleSheet
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RTextStyleSheet r_defaultStyleSheet;
		public virtual RUnityEngine.RTextCore.RText.RTextStyleSheet RdefaultStyleSheet
		{
			get
			{
				if(r_defaultStyleSheet == null)
				{
					r_defaultStyleSheet = new(this, "defaultStyleSheet", -1);
					r_defaultStyleSheet.SetBelong(this.instance);
				}
				return r_defaultStyleSheet;
			}
		}

		/// <summary>
		/// System.String styleSheetsResourcePath
		/// </summary>
		protected RProperty r_styleSheetsResourcePath;
		public virtual RProperty RstyleSheetsResourcePath
		{
			get
			{
				if(r_styleSheetsResourcePath == null)
				{
					r_styleSheetsResourcePath = new(this, "styleSheetsResourcePath", -1);
					r_styleSheetsResourcePath.SetBelong(this.instance);
				}
				return r_styleSheetsResourcePath;
			}
		}

		/// <summary>
		/// System.String defaultColorGradientPresetsPath
		/// </summary>
		protected RProperty r_defaultColorGradientPresetsPath;
		public virtual RProperty RdefaultColorGradientPresetsPath
		{
			get
			{
				if(r_defaultColorGradientPresetsPath == null)
				{
					r_defaultColorGradientPresetsPath = new(this, "defaultColorGradientPresetsPath", -1);
					r_defaultColorGradientPresetsPath.SetBelong(this.instance);
				}
				return r_defaultColorGradientPresetsPath;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.UnicodeLineBreakingRules lineBreakingRules
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RUnicodeLineBreakingRules r_lineBreakingRules;
		public virtual RUnityEngine.RTextCore.RText.RUnicodeLineBreakingRules RlineBreakingRules
		{
			get
			{
				if(r_lineBreakingRules == null)
				{
					r_lineBreakingRules = new(this, "lineBreakingRules", -1);
					r_lineBreakingRules.SetBelong(this.instance);
				}
				return r_lineBreakingRules;
			}
		}

		/// <summary>
		/// Boolean useModernHangulLineBreakingRules
		/// </summary>
		protected RProperty r_useModernHangulLineBreakingRules;
		public virtual RProperty RuseModernHangulLineBreakingRules
		{
			get
			{
				if(r_useModernHangulLineBreakingRules == null)
				{
					r_useModernHangulLineBreakingRules = new(this, "useModernHangulLineBreakingRules", -1);
					r_useModernHangulLineBreakingRules.SetBelong(this.instance);
				}
				return r_useModernHangulLineBreakingRules;
			}
		}

		/// <summary>
		/// Boolean displayWarnings
		/// </summary>
		protected RProperty r_displayWarnings;
		public virtual RProperty RdisplayWarnings
		{
			get
			{
				if(r_displayWarnings == null)
				{
					r_displayWarnings = new(this, "displayWarnings", -1);
					r_displayWarnings.SetBelong(this.instance);
				}
				return r_displayWarnings;
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
		/// Void InitializeFontReferenceLookup()
		/// </summary>
		protected RMethod r_InitializeFontReferenceLookup;
		public virtual RMethod RInitializeFontReferenceLookup
		{
			get
			{
				if(r_InitializeFontReferenceLookup == null)
				{
					r_InitializeFontReferenceLookup = new(this, "InitializeFontReferenceLookup", 0);
					r_InitializeFontReferenceLookup.SetBelong(this.instance);
				}
				return r_InitializeFontReferenceLookup;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAsset GetCachedFontAssetInternal(UnityEngine.Font)
		/// </summary>
		protected RMethod r_GetCachedFontAssetInternal_Font;
		public virtual RMethod RGetCachedFontAssetInternal_Font
		{
			get
			{
				if(r_GetCachedFontAssetInternal_Font == null)
				{
					r_GetCachedFontAssetInternal_Font = new(this, "GetCachedFontAssetInternal", 0, typeof(UnityEngine.Font));
					r_GetCachedFontAssetInternal_Font.SetBelong(this.instance);
				}
				return r_GetCachedFontAssetInternal_Font;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_SetDirty;
		public virtual RMethod RSetDirty
		{
			get
			{
				if(r_SetDirty == null)
				{
					r_SetDirty = new(this, "SetDirty", 0);
					r_SetDirty.SetBelong(this.instance);
				}
				return r_SetDirty;
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


        public RTextSettings() : base("UnityEngine.TextCore.Text.TextSettings")
        {
        }

        public RTextSettings(System.Object instance) : base("UnityEngine.TextCore.Text.TextSettings")
		{
            SetInstance(instance);
		}

        public RTextSettings(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextSettings(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void InitializeFontReferenceLookup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitializeFontReferenceLookup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.TextCore.Text.FontAsset GetCachedFontAssetInternal(UnityEngine.Font  @font)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@font};
            var ___result = RGetCachedFontAssetInternal_Font.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TextCore.Text.FontAsset)___result;
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
