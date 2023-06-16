
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.TextCore.Text.TextSettings
	/// </summary>
    public partial class RTextSettings : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.TextCore.Text.TextSettings);
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
		/// UnityEngine.TextCore.Text.FontAsset m_DefaultFontAsset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset r_Fm_DefaultFontAsset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset RFm_DefaultFontAsset
		{
			get
			{
				if(r_Fm_DefaultFontAsset == null)
				{
					r_Fm_DefaultFontAsset = new(this, "m_DefaultFontAsset");
				}
				return r_Fm_DefaultFontAsset;
			}
		}

		/// <summary>
		/// System.String m_DefaultFontAssetPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_DefaultFontAssetPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_DefaultFontAssetPath
		{
			get
			{
				if(r_Fm_DefaultFontAssetPath == null)
				{
					r_Fm_DefaultFontAssetPath = new(this, "m_DefaultFontAssetPath");
				}
				return r_Fm_DefaultFontAssetPath;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.FontAsset] m_FallbackFontAssets
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset> r_Fm_FallbackFontAssets;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset> RFm_FallbackFontAssets
		{
			get
			{
				if(r_Fm_FallbackFontAssets == null)
				{
					r_Fm_FallbackFontAssets = new(this, "m_FallbackFontAssets");
				}
				return r_Fm_FallbackFontAssets;
			}
		}

		/// <summary>
		/// System.Boolean m_MatchMaterialPreset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_MatchMaterialPreset;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_MatchMaterialPreset
		{
			get
			{
				if(r_Fm_MatchMaterialPreset == null)
				{
					r_Fm_MatchMaterialPreset = new(this, "m_MatchMaterialPreset");
				}
				return r_Fm_MatchMaterialPreset;
			}
		}

		/// <summary>
		/// System.Int32 m_MissingCharacterUnicode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_MissingCharacterUnicode;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_MissingCharacterUnicode
		{
			get
			{
				if(r_Fm_MissingCharacterUnicode == null)
				{
					r_Fm_MissingCharacterUnicode = new(this, "m_MissingCharacterUnicode");
				}
				return r_Fm_MissingCharacterUnicode;
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
		/// UnityEngine.TextCore.Text.SpriteAsset m_DefaultSpriteAsset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteAsset r_Fm_DefaultSpriteAsset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteAsset RFm_DefaultSpriteAsset
		{
			get
			{
				if(r_Fm_DefaultSpriteAsset == null)
				{
					r_Fm_DefaultSpriteAsset = new(this, "m_DefaultSpriteAsset");
				}
				return r_Fm_DefaultSpriteAsset;
			}
		}

		/// <summary>
		/// System.String m_DefaultSpriteAssetPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_DefaultSpriteAssetPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_DefaultSpriteAssetPath
		{
			get
			{
				if(r_Fm_DefaultSpriteAssetPath == null)
				{
					r_Fm_DefaultSpriteAssetPath = new(this, "m_DefaultSpriteAssetPath");
				}
				return r_Fm_DefaultSpriteAssetPath;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.SpriteAsset] m_FallbackSpriteAssets
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteAsset> r_Fm_FallbackSpriteAssets;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteAsset> RFm_FallbackSpriteAssets
		{
			get
			{
				if(r_Fm_FallbackSpriteAssets == null)
				{
					r_Fm_FallbackSpriteAssets = new(this, "m_FallbackSpriteAssets");
				}
				return r_Fm_FallbackSpriteAssets;
			}
		}

		/// <summary>
		/// System.UInt32 m_MissingSpriteCharacterUnicode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fm_MissingSpriteCharacterUnicode;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFm_MissingSpriteCharacterUnicode
		{
			get
			{
				if(r_Fm_MissingSpriteCharacterUnicode == null)
				{
					r_Fm_MissingSpriteCharacterUnicode = new(this, "m_MissingSpriteCharacterUnicode");
				}
				return r_Fm_MissingSpriteCharacterUnicode;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextStyleSheet m_DefaultStyleSheet
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextStyleSheet r_Fm_DefaultStyleSheet;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextStyleSheet RFm_DefaultStyleSheet
		{
			get
			{
				if(r_Fm_DefaultStyleSheet == null)
				{
					r_Fm_DefaultStyleSheet = new(this, "m_DefaultStyleSheet");
				}
				return r_Fm_DefaultStyleSheet;
			}
		}

		/// <summary>
		/// System.String m_StyleSheetsResourcePath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_StyleSheetsResourcePath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_StyleSheetsResourcePath
		{
			get
			{
				if(r_Fm_StyleSheetsResourcePath == null)
				{
					r_Fm_StyleSheetsResourcePath = new(this, "m_StyleSheetsResourcePath");
				}
				return r_Fm_StyleSheetsResourcePath;
			}
		}

		/// <summary>
		/// System.String m_DefaultColorGradientPresetsPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_DefaultColorGradientPresetsPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_DefaultColorGradientPresetsPath
		{
			get
			{
				if(r_Fm_DefaultColorGradientPresetsPath == null)
				{
					r_Fm_DefaultColorGradientPresetsPath = new(this, "m_DefaultColorGradientPresetsPath");
				}
				return r_Fm_DefaultColorGradientPresetsPath;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.UnicodeLineBreakingRules m_UnicodeLineBreakingRules
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RUnicodeLineBreakingRules r_Fm_UnicodeLineBreakingRules;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RUnicodeLineBreakingRules RFm_UnicodeLineBreakingRules
		{
			get
			{
				if(r_Fm_UnicodeLineBreakingRules == null)
				{
					r_Fm_UnicodeLineBreakingRules = new(this, "m_UnicodeLineBreakingRules");
				}
				return r_Fm_UnicodeLineBreakingRules;
			}
		}

		/// <summary>
		/// System.Boolean m_UseModernHangulLineBreakingRules
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_UseModernHangulLineBreakingRules;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_UseModernHangulLineBreakingRules
		{
			get
			{
				if(r_Fm_UseModernHangulLineBreakingRules == null)
				{
					r_Fm_UseModernHangulLineBreakingRules = new(this, "m_UseModernHangulLineBreakingRules");
				}
				return r_Fm_UseModernHangulLineBreakingRules;
			}
		}

		/// <summary>
		/// System.Boolean m_DisplayWarnings
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_DisplayWarnings;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_DisplayWarnings
		{
			get
			{
				if(r_Fm_DisplayWarnings == null)
				{
					r_Fm_DisplayWarnings = new(this, "m_DisplayWarnings");
				}
				return r_Fm_DisplayWarnings;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,UnityEngine.TextCore.Text.FontAsset] m_FontLookup
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset> r_Fm_FontLookup;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset> RFm_FontLookup
		{
			get
			{
				if(r_Fm_FontLookup == null)
				{
					r_Fm_FontLookup = new(this, "m_FontLookup");
				}
				return r_Fm_FontLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.TextSettings+FontReferenceMap] m_FontReferences
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextSettings.RFontReferenceMap> r_Fm_FontReferences;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextSettings.RFontReferenceMap> RFm_FontReferences
		{
			get
			{
				if(r_Fm_FontReferences == null)
				{
					r_Fm_FontReferences = new(this, "m_FontReferences");
				}
				return r_Fm_FontReferences;
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
		/// UnityEngine.TextCore.Text.FontAsset defaultFontAsset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset r_PdefaultFontAsset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset RPdefaultFontAsset
		{
			get
			{
				if(r_PdefaultFontAsset == null)
				{
					r_PdefaultFontAsset = new(this, "defaultFontAsset", -1);
				}
				return r_PdefaultFontAsset;
			}
		}

		/// <summary>
		/// System.String defaultFontAssetPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PdefaultFontAssetPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPdefaultFontAssetPath
		{
			get
			{
				if(r_PdefaultFontAssetPath == null)
				{
					r_PdefaultFontAssetPath = new(this, "defaultFontAssetPath", -1);
				}
				return r_PdefaultFontAssetPath;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.FontAsset] fallbackFontAssets
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset> r_PfallbackFontAssets;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset> RPfallbackFontAssets
		{
			get
			{
				if(r_PfallbackFontAssets == null)
				{
					r_PfallbackFontAssets = new(this, "fallbackFontAssets", -1);
				}
				return r_PfallbackFontAssets;
			}
		}

		/// <summary>
		/// Boolean matchMaterialPreset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PmatchMaterialPreset;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPmatchMaterialPreset
		{
			get
			{
				if(r_PmatchMaterialPreset == null)
				{
					r_PmatchMaterialPreset = new(this, "matchMaterialPreset", -1);
				}
				return r_PmatchMaterialPreset;
			}
		}

		/// <summary>
		/// Int32 missingCharacterUnicode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PmissingCharacterUnicode;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPmissingCharacterUnicode
		{
			get
			{
				if(r_PmissingCharacterUnicode == null)
				{
					r_PmissingCharacterUnicode = new(this, "missingCharacterUnicode", -1);
				}
				return r_PmissingCharacterUnicode;
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
		/// UnityEngine.TextCore.Text.SpriteAsset defaultSpriteAsset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteAsset r_PdefaultSpriteAsset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteAsset RPdefaultSpriteAsset
		{
			get
			{
				if(r_PdefaultSpriteAsset == null)
				{
					r_PdefaultSpriteAsset = new(this, "defaultSpriteAsset", -1);
				}
				return r_PdefaultSpriteAsset;
			}
		}

		/// <summary>
		/// System.String defaultSpriteAssetPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PdefaultSpriteAssetPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPdefaultSpriteAssetPath
		{
			get
			{
				if(r_PdefaultSpriteAssetPath == null)
				{
					r_PdefaultSpriteAssetPath = new(this, "defaultSpriteAssetPath", -1);
				}
				return r_PdefaultSpriteAssetPath;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.SpriteAsset] fallbackSpriteAssets
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteAsset> r_PfallbackSpriteAssets;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteAsset> RPfallbackSpriteAssets
		{
			get
			{
				if(r_PfallbackSpriteAssets == null)
				{
					r_PfallbackSpriteAssets = new(this, "fallbackSpriteAssets", -1);
				}
				return r_PfallbackSpriteAssets;
			}
		}

		/// <summary>
		/// UInt32 missingSpriteCharacterUnicode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_PmissingSpriteCharacterUnicode;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RPmissingSpriteCharacterUnicode
		{
			get
			{
				if(r_PmissingSpriteCharacterUnicode == null)
				{
					r_PmissingSpriteCharacterUnicode = new(this, "missingSpriteCharacterUnicode", -1);
				}
				return r_PmissingSpriteCharacterUnicode;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextStyleSheet defaultStyleSheet
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextStyleSheet r_PdefaultStyleSheet;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextStyleSheet RPdefaultStyleSheet
		{
			get
			{
				if(r_PdefaultStyleSheet == null)
				{
					r_PdefaultStyleSheet = new(this, "defaultStyleSheet", -1);
				}
				return r_PdefaultStyleSheet;
			}
		}

		/// <summary>
		/// System.String styleSheetsResourcePath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PstyleSheetsResourcePath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPstyleSheetsResourcePath
		{
			get
			{
				if(r_PstyleSheetsResourcePath == null)
				{
					r_PstyleSheetsResourcePath = new(this, "styleSheetsResourcePath", -1);
				}
				return r_PstyleSheetsResourcePath;
			}
		}

		/// <summary>
		/// System.String defaultColorGradientPresetsPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PdefaultColorGradientPresetsPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPdefaultColorGradientPresetsPath
		{
			get
			{
				if(r_PdefaultColorGradientPresetsPath == null)
				{
					r_PdefaultColorGradientPresetsPath = new(this, "defaultColorGradientPresetsPath", -1);
				}
				return r_PdefaultColorGradientPresetsPath;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.UnicodeLineBreakingRules lineBreakingRules
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RUnicodeLineBreakingRules r_PlineBreakingRules;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RUnicodeLineBreakingRules RPlineBreakingRules
		{
			get
			{
				if(r_PlineBreakingRules == null)
				{
					r_PlineBreakingRules = new(this, "lineBreakingRules", -1);
				}
				return r_PlineBreakingRules;
			}
		}

		/// <summary>
		/// Boolean useModernHangulLineBreakingRules
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PuseModernHangulLineBreakingRules;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPuseModernHangulLineBreakingRules
		{
			get
			{
				if(r_PuseModernHangulLineBreakingRules == null)
				{
					r_PuseModernHangulLineBreakingRules = new(this, "useModernHangulLineBreakingRules", -1);
				}
				return r_PuseModernHangulLineBreakingRules;
			}
		}

		/// <summary>
		/// Boolean displayWarnings
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PdisplayWarnings;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdisplayWarnings
		{
			get
			{
				if(r_PdisplayWarnings == null)
				{
					r_PdisplayWarnings = new(this, "displayWarnings", -1);
				}
				return r_PdisplayWarnings;
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
		/// Void InitializeFontReferenceLookup()
		/// </summary>
		protected RMethod r_MInitializeFontReferenceLookup;
		public virtual RMethod RMInitializeFontReferenceLookup
		{
			get
			{
				if(r_MInitializeFontReferenceLookup == null)
				{
					r_MInitializeFontReferenceLookup = new(this, "InitializeFontReferenceLookup", 0);
				}
				return r_MInitializeFontReferenceLookup;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAsset GetCachedFontAssetInternal(UnityEngine.Font)
		/// </summary>
		protected RMethod r_MGetCachedFontAssetInternal_Font;
		public virtual RMethod RMGetCachedFontAssetInternal_Font
		{
			get
			{
				if(r_MGetCachedFontAssetInternal_Font == null)
				{
					r_MGetCachedFontAssetInternal_Font = new(this, "GetCachedFontAssetInternal", 0, typeof(UnityEngine.Font));
				}
				return r_MGetCachedFontAssetInternal_Font;
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


        public virtual void InitializeFontReferenceLookup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitializeFontReferenceLookup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.TextCore.Text.FontAsset GetCachedFontAssetInternal(UnityEngine.Font @font)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@font};
            var ___result = RMGetCachedFontAssetInternal_Font.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.TextCore.Text.FontAsset>(___result);
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
