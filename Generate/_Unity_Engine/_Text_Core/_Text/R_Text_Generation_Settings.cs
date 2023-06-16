
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.TextCore.Text.TextGenerationSettings
	/// </summary>
    public partial class RTextGenerationSettings : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings");
            }
        }

        public RTextGenerationSettings() : base("UnityEngine.TextCore.Text.TextGenerationSettings")
        {
        }

        public RTextGenerationSettings(System.Object instance) : base("UnityEngine.TextCore.Text.TextGenerationSettings")
		{
            SetInstance(instance);
		}

        public RTextGenerationSettings(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextGenerationSettings(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String text
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ftext;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFtext
		{
			get
			{
				if(r_Ftext == null)
				{
					r_Ftext = new(this, "text");
				}
				return r_Ftext;
			}
		}

		/// <summary>
		/// UnityEngine.Rect screenRect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_FscreenRect;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFscreenRect
		{
			get
			{
				if(r_FscreenRect == null)
				{
					r_FscreenRect = new(this, "screenRect");
				}
				return r_FscreenRect;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 margins
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector4 r_Fmargins;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector4 RFmargins
		{
			get
			{
				if(r_Fmargins == null)
				{
					r_Fmargins = new(this, "margins");
				}
				return r_Fmargins;
			}
		}

		/// <summary>
		/// System.Single scale
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fscale;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFscale
		{
			get
			{
				if(r_Fscale == null)
				{
					r_Fscale = new(this, "scale");
				}
				return r_Fscale;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAsset fontAsset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset r_FfontAsset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset RFfontAsset
		{
			get
			{
				if(r_FfontAsset == null)
				{
					r_FfontAsset = new(this, "fontAsset");
				}
				return r_FfontAsset;
			}
		}

		/// <summary>
		/// UnityEngine.Material material
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMaterial r_Fmaterial;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMaterial RFmaterial
		{
			get
			{
				if(r_Fmaterial == null)
				{
					r_Fmaterial = new(this, "material");
				}
				return r_Fmaterial;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.SpriteAsset spriteAsset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteAsset r_FspriteAsset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteAsset RFspriteAsset
		{
			get
			{
				if(r_FspriteAsset == null)
				{
					r_FspriteAsset = new(this, "spriteAsset");
				}
				return r_FspriteAsset;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextStyleSheet styleSheet
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextStyleSheet r_FstyleSheet;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextStyleSheet RFstyleSheet
		{
			get
			{
				if(r_FstyleSheet == null)
				{
					r_FstyleSheet = new(this, "styleSheet");
				}
				return r_FstyleSheet;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontStyles fontStyle
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles r_FfontStyle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles RFfontStyle
		{
			get
			{
				if(r_FfontStyle == null)
				{
					r_FfontStyle = new(this, "fontStyle");
				}
				return r_FfontStyle;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextSettings textSettings
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextSettings r_FtextSettings;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextSettings RFtextSettings
		{
			get
			{
				if(r_FtextSettings == null)
				{
					r_FtextSettings = new(this, "textSettings");
				}
				return r_FtextSettings;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment textAlignment
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FtextAlignment;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFtextAlignment
		{
			get
			{
				if(r_FtextAlignment == null)
				{
					r_FtextAlignment = new(this, "textAlignment");
				}
				return r_FtextAlignment;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextOverflowMode overflowMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextOverflowMode r_FoverflowMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextOverflowMode RFoverflowMode
		{
			get
			{
				if(r_FoverflowMode == null)
				{
					r_FoverflowMode = new(this, "overflowMode");
				}
				return r_FoverflowMode;
			}
		}

		/// <summary>
		/// System.Boolean wordWrap
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FwordWrap;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFwordWrap
		{
			get
			{
				if(r_FwordWrap == null)
				{
					r_FwordWrap = new(this, "wordWrap");
				}
				return r_FwordWrap;
			}
		}

		/// <summary>
		/// System.Single wordWrappingRatio
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FwordWrappingRatio;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFwordWrappingRatio
		{
			get
			{
				if(r_FwordWrappingRatio == null)
				{
					r_FwordWrappingRatio = new(this, "wordWrappingRatio");
				}
				return r_FwordWrappingRatio;
			}
		}

		/// <summary>
		/// UnityEngine.Color color
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_Fcolor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RFcolor
		{
			get
			{
				if(r_Fcolor == null)
				{
					r_Fcolor = new(this, "color");
				}
				return r_Fcolor;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextColorGradient fontColorGradient
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextColorGradient r_FfontColorGradient;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextColorGradient RFfontColorGradient
		{
			get
			{
				if(r_FfontColorGradient == null)
				{
					r_FfontColorGradient = new(this, "fontColorGradient");
				}
				return r_FfontColorGradient;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextColorGradient fontColorGradientPreset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextColorGradient r_FfontColorGradientPreset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextColorGradient RFfontColorGradientPreset
		{
			get
			{
				if(r_FfontColorGradientPreset == null)
				{
					r_FfontColorGradientPreset = new(this, "fontColorGradientPreset");
				}
				return r_FfontColorGradientPreset;
			}
		}

		/// <summary>
		/// System.Boolean tintSprites
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FtintSprites;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFtintSprites
		{
			get
			{
				if(r_FtintSprites == null)
				{
					r_FtintSprites = new(this, "tintSprites");
				}
				return r_FtintSprites;
			}
		}

		/// <summary>
		/// System.Boolean overrideRichTextColors
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FoverrideRichTextColors;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFoverrideRichTextColors
		{
			get
			{
				if(r_FoverrideRichTextColors == null)
				{
					r_FoverrideRichTextColors = new(this, "overrideRichTextColors");
				}
				return r_FoverrideRichTextColors;
			}
		}

		/// <summary>
		/// System.Boolean shouldConvertToLinearSpace
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FshouldConvertToLinearSpace;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFshouldConvertToLinearSpace
		{
			get
			{
				if(r_FshouldConvertToLinearSpace == null)
				{
					r_FshouldConvertToLinearSpace = new(this, "shouldConvertToLinearSpace");
				}
				return r_FshouldConvertToLinearSpace;
			}
		}

		/// <summary>
		/// System.Single fontSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FfontSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFfontSize
		{
			get
			{
				if(r_FfontSize == null)
				{
					r_FfontSize = new(this, "fontSize");
				}
				return r_FfontSize;
			}
		}

		/// <summary>
		/// System.Boolean autoSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FautoSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFautoSize
		{
			get
			{
				if(r_FautoSize == null)
				{
					r_FautoSize = new(this, "autoSize");
				}
				return r_FautoSize;
			}
		}

		/// <summary>
		/// System.Single fontSizeMin
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FfontSizeMin;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFfontSizeMin
		{
			get
			{
				if(r_FfontSizeMin == null)
				{
					r_FfontSizeMin = new(this, "fontSizeMin");
				}
				return r_FfontSizeMin;
			}
		}

		/// <summary>
		/// System.Single fontSizeMax
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FfontSizeMax;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFfontSizeMax
		{
			get
			{
				if(r_FfontSizeMax == null)
				{
					r_FfontSizeMax = new(this, "fontSizeMax");
				}
				return r_FfontSizeMax;
			}
		}

		/// <summary>
		/// System.Boolean enableKerning
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FenableKerning;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFenableKerning
		{
			get
			{
				if(r_FenableKerning == null)
				{
					r_FenableKerning = new(this, "enableKerning");
				}
				return r_FenableKerning;
			}
		}

		/// <summary>
		/// System.Boolean richText
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FrichText;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFrichText
		{
			get
			{
				if(r_FrichText == null)
				{
					r_FrichText = new(this, "richText");
				}
				return r_FrichText;
			}
		}

		/// <summary>
		/// System.Boolean isRightToLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FisRightToLeft;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFisRightToLeft
		{
			get
			{
				if(r_FisRightToLeft == null)
				{
					r_FisRightToLeft = new(this, "isRightToLeft");
				}
				return r_FisRightToLeft;
			}
		}

		/// <summary>
		/// System.Boolean extraPadding
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FextraPadding;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFextraPadding
		{
			get
			{
				if(r_FextraPadding == null)
				{
					r_FextraPadding = new(this, "extraPadding");
				}
				return r_FextraPadding;
			}
		}

		/// <summary>
		/// System.Boolean parseControlCharacters
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FparseControlCharacters;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFparseControlCharacters
		{
			get
			{
				if(r_FparseControlCharacters == null)
				{
					r_FparseControlCharacters = new(this, "parseControlCharacters");
				}
				return r_FparseControlCharacters;
			}
		}

		/// <summary>
		/// System.Boolean isOrthographic
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FisOrthographic;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFisOrthographic
		{
			get
			{
				if(r_FisOrthographic == null)
				{
					r_FisOrthographic = new(this, "isOrthographic");
				}
				return r_FisOrthographic;
			}
		}

		/// <summary>
		/// System.Boolean tagNoParsing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FtagNoParsing;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFtagNoParsing
		{
			get
			{
				if(r_FtagNoParsing == null)
				{
					r_FtagNoParsing = new(this, "tagNoParsing");
				}
				return r_FtagNoParsing;
			}
		}

		/// <summary>
		/// System.Single characterSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FcharacterSpacing;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFcharacterSpacing
		{
			get
			{
				if(r_FcharacterSpacing == null)
				{
					r_FcharacterSpacing = new(this, "characterSpacing");
				}
				return r_FcharacterSpacing;
			}
		}

		/// <summary>
		/// System.Single wordSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FwordSpacing;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFwordSpacing
		{
			get
			{
				if(r_FwordSpacing == null)
				{
					r_FwordSpacing = new(this, "wordSpacing");
				}
				return r_FwordSpacing;
			}
		}

		/// <summary>
		/// System.Single lineSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FlineSpacing;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFlineSpacing
		{
			get
			{
				if(r_FlineSpacing == null)
				{
					r_FlineSpacing = new(this, "lineSpacing");
				}
				return r_FlineSpacing;
			}
		}

		/// <summary>
		/// System.Single paragraphSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FparagraphSpacing;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFparagraphSpacing
		{
			get
			{
				if(r_FparagraphSpacing == null)
				{
					r_FparagraphSpacing = new(this, "paragraphSpacing");
				}
				return r_FparagraphSpacing;
			}
		}

		/// <summary>
		/// System.Single lineSpacingMax
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FlineSpacingMax;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFlineSpacingMax
		{
			get
			{
				if(r_FlineSpacingMax == null)
				{
					r_FlineSpacingMax = new(this, "lineSpacingMax");
				}
				return r_FlineSpacingMax;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextWrappingMode textWrappingMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextWrappingMode r_FtextWrappingMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextWrappingMode RFtextWrappingMode
		{
			get
			{
				if(r_FtextWrappingMode == null)
				{
					r_FtextWrappingMode = new(this, "textWrappingMode");
				}
				return r_FtextWrappingMode;
			}
		}

		/// <summary>
		/// System.Int32 maxVisibleCharacters
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FmaxVisibleCharacters;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFmaxVisibleCharacters
		{
			get
			{
				if(r_FmaxVisibleCharacters == null)
				{
					r_FmaxVisibleCharacters = new(this, "maxVisibleCharacters");
				}
				return r_FmaxVisibleCharacters;
			}
		}

		/// <summary>
		/// System.Int32 maxVisibleWords
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FmaxVisibleWords;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFmaxVisibleWords
		{
			get
			{
				if(r_FmaxVisibleWords == null)
				{
					r_FmaxVisibleWords = new(this, "maxVisibleWords");
				}
				return r_FmaxVisibleWords;
			}
		}

		/// <summary>
		/// System.Int32 maxVisibleLines
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FmaxVisibleLines;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFmaxVisibleLines
		{
			get
			{
				if(r_FmaxVisibleLines == null)
				{
					r_FmaxVisibleLines = new(this, "maxVisibleLines");
				}
				return r_FmaxVisibleLines;
			}
		}

		/// <summary>
		/// System.Int32 firstVisibleCharacter
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FfirstVisibleCharacter;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFfirstVisibleCharacter
		{
			get
			{
				if(r_FfirstVisibleCharacter == null)
				{
					r_FfirstVisibleCharacter = new(this, "firstVisibleCharacter");
				}
				return r_FfirstVisibleCharacter;
			}
		}

		/// <summary>
		/// System.Boolean useMaxVisibleDescender
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FuseMaxVisibleDescender;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFuseMaxVisibleDescender
		{
			get
			{
				if(r_FuseMaxVisibleDescender == null)
				{
					r_FuseMaxVisibleDescender = new(this, "useMaxVisibleDescender");
				}
				return r_FuseMaxVisibleDescender;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextFontWeight fontWeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextFontWeight r_FfontWeight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextFontWeight RFfontWeight
		{
			get
			{
				if(r_FfontWeight == null)
				{
					r_FfontWeight = new(this, "fontWeight");
				}
				return r_FfontWeight;
			}
		}

		/// <summary>
		/// System.Int32 pageToDisplay
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FpageToDisplay;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFpageToDisplay
		{
			get
			{
				if(r_FpageToDisplay == null)
				{
					r_FpageToDisplay = new(this, "pageToDisplay");
				}
				return r_FpageToDisplay;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextureMapping horizontalMapping
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextureMapping r_FhorizontalMapping;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextureMapping RFhorizontalMapping
		{
			get
			{
				if(r_FhorizontalMapping == null)
				{
					r_FhorizontalMapping = new(this, "horizontalMapping");
				}
				return r_FhorizontalMapping;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextureMapping verticalMapping
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextureMapping r_FverticalMapping;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextureMapping RFverticalMapping
		{
			get
			{
				if(r_FverticalMapping == null)
				{
					r_FverticalMapping = new(this, "verticalMapping");
				}
				return r_FverticalMapping;
			}
		}

		/// <summary>
		/// System.Single uvLineOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FuvLineOffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFuvLineOffset
		{
			get
			{
				if(r_FuvLineOffset == null)
				{
					r_FuvLineOffset = new(this, "uvLineOffset");
				}
				return r_FuvLineOffset;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.VertexSortingOrder geometrySortingOrder
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RVertexSortingOrder r_FgeometrySortingOrder;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RVertexSortingOrder RFgeometrySortingOrder
		{
			get
			{
				if(r_FgeometrySortingOrder == null)
				{
					r_FgeometrySortingOrder = new(this, "geometrySortingOrder");
				}
				return r_FgeometrySortingOrder;
			}
		}

		/// <summary>
		/// System.Boolean inverseYAxis
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FinverseYAxis;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFinverseYAxis
		{
			get
			{
				if(r_FinverseYAxis == null)
				{
					r_FinverseYAxis = new(this, "inverseYAxis");
				}
				return r_FinverseYAxis;
			}
		}

		/// <summary>
		/// System.Single charWidthMaxAdj
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FcharWidthMaxAdj;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFcharWidthMaxAdj
		{
			get
			{
				if(r_FcharWidthMaxAdj == null)
				{
					r_FcharWidthMaxAdj = new(this, "charWidthMaxAdj");
				}
				return r_FcharWidthMaxAdj;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextInputSource inputSource
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInputSource r_FinputSource;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInputSource RFinputSource
		{
			get
			{
				if(r_FinputSource == null)
				{
					r_FinputSource = new(this, "inputSource");
				}
				return r_FinputSource;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.TextCore.Text.TextGenerationSettings)
		/// </summary>
		protected RMethod r_MEquals_TextGenerationSettings;
		public virtual RMethod RMEquals_TextGenerationSettings
		{
			get
			{
				if(r_MEquals_TextGenerationSettings == null)
				{
					r_MEquals_TextGenerationSettings = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"));
				}
				return r_MEquals_TextGenerationSettings;
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
		/// Boolean op_Equality(UnityEngine.TextCore.Text.TextGenerationSettings, UnityEngine.TextCore.Text.TextGenerationSettings)
		/// </summary>
		protected static RMethod r_Mop_Equality_TextGenerationSettings_TextGenerationSettings;
		public static RMethod RMop_Equality_TextGenerationSettings_TextGenerationSettings
		{
			get
			{
				if(r_Mop_Equality_TextGenerationSettings_TextGenerationSettings == null)
				{
					r_Mop_Equality_TextGenerationSettings_TextGenerationSettings = new(Type, "op_Equality", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"),  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"));
				}
				return r_Mop_Equality_TextGenerationSettings_TextGenerationSettings;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.TextCore.Text.TextGenerationSettings, UnityEngine.TextCore.Text.TextGenerationSettings)
		/// </summary>
		protected static RMethod r_Mop_Inequality_TextGenerationSettings_TextGenerationSettings;
		public static RMethod RMop_Inequality_TextGenerationSettings_TextGenerationSettings
		{
			get
			{
				if(r_Mop_Inequality_TextGenerationSettings_TextGenerationSettings == null)
				{
					r_Mop_Inequality_TextGenerationSettings_TextGenerationSettings = new(Type, "op_Inequality", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"),  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"));
				}
				return r_Mop_Inequality_TextGenerationSettings_TextGenerationSettings;
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


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextGenerationSettings @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_TextGenerationSettings.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Boolean op_Equality(Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextGenerationSettings @left, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextGenerationSettings @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Equality_TextGenerationSettings_TextGenerationSettings.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextGenerationSettings @left, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextGenerationSettings @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Inequality_TextGenerationSettings_TextGenerationSettings.Invoke(___genericsType, ___parameters);

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
