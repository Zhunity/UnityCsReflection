
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.TextGenerationSettings
	/// </summary>
    public partial class RTextGenerationSettings : RMember //
    {

		/// <summary>
		/// System.String text
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Ftext;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFtext
		{
			get
			{
				if(r_Ftext == null)
				{
					r_Ftext = new(this, "text");
					r_Ftext.SetBelong(this.instance);
				}
				return r_Ftext;
			}
		}

		/// <summary>
		/// UnityEngine.Rect screenRect
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RRect r_FscreenRect;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RRect RFscreenRect
		{
			get
			{
				if(r_FscreenRect == null)
				{
					r_FscreenRect = new(this, "screenRect");
					r_FscreenRect.SetBelong(this.instance);
				}
				return r_FscreenRect;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 margins
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector4 r_Fmargins;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector4 RFmargins
		{
			get
			{
				if(r_Fmargins == null)
				{
					r_Fmargins = new(this, "margins");
					r_Fmargins.SetBelong(this.instance);
				}
				return r_Fmargins;
			}
		}

		/// <summary>
		/// System.Single scale
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_Fscale;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFscale
		{
			get
			{
				if(r_Fscale == null)
				{
					r_Fscale = new(this, "scale");
					r_Fscale.SetBelong(this.instance);
				}
				return r_Fscale;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAsset fontAsset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset r_FfontAsset;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset RFfontAsset
		{
			get
			{
				if(r_FfontAsset == null)
				{
					r_FfontAsset = new(this, "fontAsset");
					r_FfontAsset.SetBelong(this.instance);
				}
				return r_FfontAsset;
			}
		}

		/// <summary>
		/// UnityEngine.Material material
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RMaterial r_Fmaterial;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RMaterial RFmaterial
		{
			get
			{
				if(r_Fmaterial == null)
				{
					r_Fmaterial = new(this, "material");
					r_Fmaterial.SetBelong(this.instance);
				}
				return r_Fmaterial;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.SpriteAsset spriteAsset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteAsset r_FspriteAsset;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteAsset RFspriteAsset
		{
			get
			{
				if(r_FspriteAsset == null)
				{
					r_FspriteAsset = new(this, "spriteAsset");
					r_FspriteAsset.SetBelong(this.instance);
				}
				return r_FspriteAsset;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextStyleSheet styleSheet
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextStyleSheet r_FstyleSheet;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextStyleSheet RFstyleSheet
		{
			get
			{
				if(r_FstyleSheet == null)
				{
					r_FstyleSheet = new(this, "styleSheet");
					r_FstyleSheet.SetBelong(this.instance);
				}
				return r_FstyleSheet;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontStyles fontStyle
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles r_FfontStyle;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles RFfontStyle
		{
			get
			{
				if(r_FfontStyle == null)
				{
					r_FfontStyle = new(this, "fontStyle");
					r_FfontStyle.SetBelong(this.instance);
				}
				return r_FfontStyle;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextSettings textSettings
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextSettings r_FtextSettings;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextSettings RFtextSettings
		{
			get
			{
				if(r_FtextSettings == null)
				{
					r_FtextSettings = new(this, "textSettings");
					r_FtextSettings.SetBelong(this.instance);
				}
				return r_FtextSettings;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment textAlignment
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FtextAlignment;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFtextAlignment
		{
			get
			{
				if(r_FtextAlignment == null)
				{
					r_FtextAlignment = new(this, "textAlignment");
					r_FtextAlignment.SetBelong(this.instance);
				}
				return r_FtextAlignment;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextOverflowMode overflowMode
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextOverflowMode r_FoverflowMode;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextOverflowMode RFoverflowMode
		{
			get
			{
				if(r_FoverflowMode == null)
				{
					r_FoverflowMode = new(this, "overflowMode");
					r_FoverflowMode.SetBelong(this.instance);
				}
				return r_FoverflowMode;
			}
		}

		/// <summary>
		/// System.Boolean wordWrap
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_FwordWrap;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFwordWrap
		{
			get
			{
				if(r_FwordWrap == null)
				{
					r_FwordWrap = new(this, "wordWrap");
					r_FwordWrap.SetBelong(this.instance);
				}
				return r_FwordWrap;
			}
		}

		/// <summary>
		/// System.Single wordWrappingRatio
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FwordWrappingRatio;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFwordWrappingRatio
		{
			get
			{
				if(r_FwordWrappingRatio == null)
				{
					r_FwordWrappingRatio = new(this, "wordWrappingRatio");
					r_FwordWrappingRatio.SetBelong(this.instance);
				}
				return r_FwordWrappingRatio;
			}
		}

		/// <summary>
		/// UnityEngine.Color color
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RColor r_Fcolor;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RColor RFcolor
		{
			get
			{
				if(r_Fcolor == null)
				{
					r_Fcolor = new(this, "color");
					r_Fcolor.SetBelong(this.instance);
				}
				return r_Fcolor;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextColorGradient fontColorGradient
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextColorGradient r_FfontColorGradient;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextColorGradient RFfontColorGradient
		{
			get
			{
				if(r_FfontColorGradient == null)
				{
					r_FfontColorGradient = new(this, "fontColorGradient");
					r_FfontColorGradient.SetBelong(this.instance);
				}
				return r_FfontColorGradient;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextColorGradient fontColorGradientPreset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextColorGradient r_FfontColorGradientPreset;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextColorGradient RFfontColorGradientPreset
		{
			get
			{
				if(r_FfontColorGradientPreset == null)
				{
					r_FfontColorGradientPreset = new(this, "fontColorGradientPreset");
					r_FfontColorGradientPreset.SetBelong(this.instance);
				}
				return r_FfontColorGradientPreset;
			}
		}

		/// <summary>
		/// System.Boolean tintSprites
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_FtintSprites;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFtintSprites
		{
			get
			{
				if(r_FtintSprites == null)
				{
					r_FtintSprites = new(this, "tintSprites");
					r_FtintSprites.SetBelong(this.instance);
				}
				return r_FtintSprites;
			}
		}

		/// <summary>
		/// System.Boolean overrideRichTextColors
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_FoverrideRichTextColors;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFoverrideRichTextColors
		{
			get
			{
				if(r_FoverrideRichTextColors == null)
				{
					r_FoverrideRichTextColors = new(this, "overrideRichTextColors");
					r_FoverrideRichTextColors.SetBelong(this.instance);
				}
				return r_FoverrideRichTextColors;
			}
		}

		/// <summary>
		/// System.Boolean shouldConvertToLinearSpace
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_FshouldConvertToLinearSpace;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFshouldConvertToLinearSpace
		{
			get
			{
				if(r_FshouldConvertToLinearSpace == null)
				{
					r_FshouldConvertToLinearSpace = new(this, "shouldConvertToLinearSpace");
					r_FshouldConvertToLinearSpace.SetBelong(this.instance);
				}
				return r_FshouldConvertToLinearSpace;
			}
		}

		/// <summary>
		/// System.Single fontSize
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FfontSize;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFfontSize
		{
			get
			{
				if(r_FfontSize == null)
				{
					r_FfontSize = new(this, "fontSize");
					r_FfontSize.SetBelong(this.instance);
				}
				return r_FfontSize;
			}
		}

		/// <summary>
		/// System.Boolean autoSize
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_FautoSize;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFautoSize
		{
			get
			{
				if(r_FautoSize == null)
				{
					r_FautoSize = new(this, "autoSize");
					r_FautoSize.SetBelong(this.instance);
				}
				return r_FautoSize;
			}
		}

		/// <summary>
		/// System.Single fontSizeMin
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FfontSizeMin;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFfontSizeMin
		{
			get
			{
				if(r_FfontSizeMin == null)
				{
					r_FfontSizeMin = new(this, "fontSizeMin");
					r_FfontSizeMin.SetBelong(this.instance);
				}
				return r_FfontSizeMin;
			}
		}

		/// <summary>
		/// System.Single fontSizeMax
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FfontSizeMax;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFfontSizeMax
		{
			get
			{
				if(r_FfontSizeMax == null)
				{
					r_FfontSizeMax = new(this, "fontSizeMax");
					r_FfontSizeMax.SetBelong(this.instance);
				}
				return r_FfontSizeMax;
			}
		}

		/// <summary>
		/// System.Boolean enableKerning
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_FenableKerning;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFenableKerning
		{
			get
			{
				if(r_FenableKerning == null)
				{
					r_FenableKerning = new(this, "enableKerning");
					r_FenableKerning.SetBelong(this.instance);
				}
				return r_FenableKerning;
			}
		}

		/// <summary>
		/// System.Boolean richText
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_FrichText;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFrichText
		{
			get
			{
				if(r_FrichText == null)
				{
					r_FrichText = new(this, "richText");
					r_FrichText.SetBelong(this.instance);
				}
				return r_FrichText;
			}
		}

		/// <summary>
		/// System.Boolean isRightToLeft
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_FisRightToLeft;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFisRightToLeft
		{
			get
			{
				if(r_FisRightToLeft == null)
				{
					r_FisRightToLeft = new(this, "isRightToLeft");
					r_FisRightToLeft.SetBelong(this.instance);
				}
				return r_FisRightToLeft;
			}
		}

		/// <summary>
		/// System.Boolean extraPadding
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_FextraPadding;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFextraPadding
		{
			get
			{
				if(r_FextraPadding == null)
				{
					r_FextraPadding = new(this, "extraPadding");
					r_FextraPadding.SetBelong(this.instance);
				}
				return r_FextraPadding;
			}
		}

		/// <summary>
		/// System.Boolean parseControlCharacters
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_FparseControlCharacters;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFparseControlCharacters
		{
			get
			{
				if(r_FparseControlCharacters == null)
				{
					r_FparseControlCharacters = new(this, "parseControlCharacters");
					r_FparseControlCharacters.SetBelong(this.instance);
				}
				return r_FparseControlCharacters;
			}
		}

		/// <summary>
		/// System.Boolean isOrthographic
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_FisOrthographic;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFisOrthographic
		{
			get
			{
				if(r_FisOrthographic == null)
				{
					r_FisOrthographic = new(this, "isOrthographic");
					r_FisOrthographic.SetBelong(this.instance);
				}
				return r_FisOrthographic;
			}
		}

		/// <summary>
		/// System.Boolean tagNoParsing
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_FtagNoParsing;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFtagNoParsing
		{
			get
			{
				if(r_FtagNoParsing == null)
				{
					r_FtagNoParsing = new(this, "tagNoParsing");
					r_FtagNoParsing.SetBelong(this.instance);
				}
				return r_FtagNoParsing;
			}
		}

		/// <summary>
		/// System.Single characterSpacing
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FcharacterSpacing;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFcharacterSpacing
		{
			get
			{
				if(r_FcharacterSpacing == null)
				{
					r_FcharacterSpacing = new(this, "characterSpacing");
					r_FcharacterSpacing.SetBelong(this.instance);
				}
				return r_FcharacterSpacing;
			}
		}

		/// <summary>
		/// System.Single wordSpacing
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FwordSpacing;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFwordSpacing
		{
			get
			{
				if(r_FwordSpacing == null)
				{
					r_FwordSpacing = new(this, "wordSpacing");
					r_FwordSpacing.SetBelong(this.instance);
				}
				return r_FwordSpacing;
			}
		}

		/// <summary>
		/// System.Single lineSpacing
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FlineSpacing;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFlineSpacing
		{
			get
			{
				if(r_FlineSpacing == null)
				{
					r_FlineSpacing = new(this, "lineSpacing");
					r_FlineSpacing.SetBelong(this.instance);
				}
				return r_FlineSpacing;
			}
		}

		/// <summary>
		/// System.Single paragraphSpacing
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FparagraphSpacing;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFparagraphSpacing
		{
			get
			{
				if(r_FparagraphSpacing == null)
				{
					r_FparagraphSpacing = new(this, "paragraphSpacing");
					r_FparagraphSpacing.SetBelong(this.instance);
				}
				return r_FparagraphSpacing;
			}
		}

		/// <summary>
		/// System.Single lineSpacingMax
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FlineSpacingMax;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFlineSpacingMax
		{
			get
			{
				if(r_FlineSpacingMax == null)
				{
					r_FlineSpacingMax = new(this, "lineSpacingMax");
					r_FlineSpacingMax.SetBelong(this.instance);
				}
				return r_FlineSpacingMax;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextWrappingMode textWrappingMode
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextWrappingMode r_FtextWrappingMode;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextWrappingMode RFtextWrappingMode
		{
			get
			{
				if(r_FtextWrappingMode == null)
				{
					r_FtextWrappingMode = new(this, "textWrappingMode");
					r_FtextWrappingMode.SetBelong(this.instance);
				}
				return r_FtextWrappingMode;
			}
		}

		/// <summary>
		/// System.Int32 maxVisibleCharacters
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FmaxVisibleCharacters;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFmaxVisibleCharacters
		{
			get
			{
				if(r_FmaxVisibleCharacters == null)
				{
					r_FmaxVisibleCharacters = new(this, "maxVisibleCharacters");
					r_FmaxVisibleCharacters.SetBelong(this.instance);
				}
				return r_FmaxVisibleCharacters;
			}
		}

		/// <summary>
		/// System.Int32 maxVisibleWords
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FmaxVisibleWords;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFmaxVisibleWords
		{
			get
			{
				if(r_FmaxVisibleWords == null)
				{
					r_FmaxVisibleWords = new(this, "maxVisibleWords");
					r_FmaxVisibleWords.SetBelong(this.instance);
				}
				return r_FmaxVisibleWords;
			}
		}

		/// <summary>
		/// System.Int32 maxVisibleLines
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FmaxVisibleLines;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFmaxVisibleLines
		{
			get
			{
				if(r_FmaxVisibleLines == null)
				{
					r_FmaxVisibleLines = new(this, "maxVisibleLines");
					r_FmaxVisibleLines.SetBelong(this.instance);
				}
				return r_FmaxVisibleLines;
			}
		}

		/// <summary>
		/// System.Int32 firstVisibleCharacter
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FfirstVisibleCharacter;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFfirstVisibleCharacter
		{
			get
			{
				if(r_FfirstVisibleCharacter == null)
				{
					r_FfirstVisibleCharacter = new(this, "firstVisibleCharacter");
					r_FfirstVisibleCharacter.SetBelong(this.instance);
				}
				return r_FfirstVisibleCharacter;
			}
		}

		/// <summary>
		/// System.Boolean useMaxVisibleDescender
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_FuseMaxVisibleDescender;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFuseMaxVisibleDescender
		{
			get
			{
				if(r_FuseMaxVisibleDescender == null)
				{
					r_FuseMaxVisibleDescender = new(this, "useMaxVisibleDescender");
					r_FuseMaxVisibleDescender.SetBelong(this.instance);
				}
				return r_FuseMaxVisibleDescender;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextFontWeight fontWeight
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextFontWeight r_FfontWeight;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextFontWeight RFfontWeight
		{
			get
			{
				if(r_FfontWeight == null)
				{
					r_FfontWeight = new(this, "fontWeight");
					r_FfontWeight.SetBelong(this.instance);
				}
				return r_FfontWeight;
			}
		}

		/// <summary>
		/// System.Int32 pageToDisplay
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FpageToDisplay;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFpageToDisplay
		{
			get
			{
				if(r_FpageToDisplay == null)
				{
					r_FpageToDisplay = new(this, "pageToDisplay");
					r_FpageToDisplay.SetBelong(this.instance);
				}
				return r_FpageToDisplay;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextureMapping horizontalMapping
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextureMapping r_FhorizontalMapping;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextureMapping RFhorizontalMapping
		{
			get
			{
				if(r_FhorizontalMapping == null)
				{
					r_FhorizontalMapping = new(this, "horizontalMapping");
					r_FhorizontalMapping.SetBelong(this.instance);
				}
				return r_FhorizontalMapping;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextureMapping verticalMapping
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextureMapping r_FverticalMapping;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextureMapping RFverticalMapping
		{
			get
			{
				if(r_FverticalMapping == null)
				{
					r_FverticalMapping = new(this, "verticalMapping");
					r_FverticalMapping.SetBelong(this.instance);
				}
				return r_FverticalMapping;
			}
		}

		/// <summary>
		/// System.Single uvLineOffset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FuvLineOffset;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFuvLineOffset
		{
			get
			{
				if(r_FuvLineOffset == null)
				{
					r_FuvLineOffset = new(this, "uvLineOffset");
					r_FuvLineOffset.SetBelong(this.instance);
				}
				return r_FuvLineOffset;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.VertexSortingOrder geometrySortingOrder
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RVertexSortingOrder r_FgeometrySortingOrder;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RVertexSortingOrder RFgeometrySortingOrder
		{
			get
			{
				if(r_FgeometrySortingOrder == null)
				{
					r_FgeometrySortingOrder = new(this, "geometrySortingOrder");
					r_FgeometrySortingOrder.SetBelong(this.instance);
				}
				return r_FgeometrySortingOrder;
			}
		}

		/// <summary>
		/// System.Boolean inverseYAxis
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_FinverseYAxis;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFinverseYAxis
		{
			get
			{
				if(r_FinverseYAxis == null)
				{
					r_FinverseYAxis = new(this, "inverseYAxis");
					r_FinverseYAxis.SetBelong(this.instance);
				}
				return r_FinverseYAxis;
			}
		}

		/// <summary>
		/// System.Single charWidthMaxAdj
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FcharWidthMaxAdj;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFcharWidthMaxAdj
		{
			get
			{
				if(r_FcharWidthMaxAdj == null)
				{
					r_FcharWidthMaxAdj = new(this, "charWidthMaxAdj");
					r_FcharWidthMaxAdj.SetBelong(this.instance);
				}
				return r_FcharWidthMaxAdj;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextInputSource inputSource
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInputSource r_FinputSource;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInputSource RFinputSource
		{
			get
			{
				if(r_FinputSource == null)
				{
					r_FinputSource = new(this, "inputSource");
					r_FinputSource.SetBelong(this.instance);
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
					r_MEquals_TextGenerationSettings.SetBelong(this.instance);
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_Mop_Equality_TextGenerationSettings_TextGenerationSettings = new( ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"), "op_Equality", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"),  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"));
					r_Mop_Equality_TextGenerationSettings_TextGenerationSettings.SetBelong(null);
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
					r_Mop_Inequality_TextGenerationSettings_TextGenerationSettings = new( ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"), "op_Inequality", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"),  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"));
					r_Mop_Inequality_TextGenerationSettings_TextGenerationSettings.SetBelong(null);
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

        public virtual System.Boolean Equals(SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextGenerationSettings @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_TextGenerationSettings.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextGenerationSettings @left, SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextGenerationSettings @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Equality_TextGenerationSettings_TextGenerationSettings.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextGenerationSettings @left, SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextGenerationSettings @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Inequality_TextGenerationSettings_TextGenerationSettings.Invoke(___genericsType, ___parameters);

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