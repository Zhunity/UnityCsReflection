using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.TextElementInfo
	/// </summary>
    public partial class RTextElementInfo : RMember //
    {

		/// <summary>
		/// System.Char character
		/// </summary>
		protected RField r_character;
		public virtual RField Rcharacter
		{
			get
			{
				if(r_character == null)
				{
					r_character = new(this, "character");
					r_character.SetBelong(this.instance);
				}
				return r_character;
			}
		}

		/// <summary>
		/// System.Int32 index
		/// </summary>
		protected RField r_index;
		public virtual RField Rindex
		{
			get
			{
				if(r_index == null)
				{
					r_index = new(this, "index");
					r_index.SetBelong(this.instance);
				}
				return r_index;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextElementType elementType
		/// </summary>
		protected RField r_elementType;
		public virtual RField RelementType
		{
			get
			{
				if(r_elementType == null)
				{
					r_elementType = new(this, "elementType");
					r_elementType.SetBelong(this.instance);
				}
				return r_elementType;
			}
		}

		/// <summary>
		/// System.Int32 stringLength
		/// </summary>
		protected RField r_stringLength;
		public virtual RField RstringLength
		{
			get
			{
				if(r_stringLength == null)
				{
					r_stringLength = new(this, "stringLength");
					r_stringLength.SetBelong(this.instance);
				}
				return r_stringLength;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextElement textElement
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RTextElement r_textElement;
		public virtual RUnityEngine.RTextCore.RText.RTextElement RtextElement
		{
			get
			{
				if(r_textElement == null)
				{
					r_textElement = new(this, "textElement");
					r_textElement.SetBelong(this.instance);
				}
				return r_textElement;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Glyph alternativeGlyph
		/// </summary>
		protected RUnityEngine.RTextCore.RGlyph r_alternativeGlyph;
		public virtual RUnityEngine.RTextCore.RGlyph RalternativeGlyph
		{
			get
			{
				if(r_alternativeGlyph == null)
				{
					r_alternativeGlyph = new(this, "alternativeGlyph");
					r_alternativeGlyph.SetBelong(this.instance);
				}
				return r_alternativeGlyph;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAsset fontAsset
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RFontAsset r_fontAsset;
		public virtual RUnityEngine.RTextCore.RText.RFontAsset RfontAsset
		{
			get
			{
				if(r_fontAsset == null)
				{
					r_fontAsset = new(this, "fontAsset");
					r_fontAsset.SetBelong(this.instance);
				}
				return r_fontAsset;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.SpriteAsset spriteAsset
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RSpriteAsset r_spriteAsset;
		public virtual RUnityEngine.RTextCore.RText.RSpriteAsset RspriteAsset
		{
			get
			{
				if(r_spriteAsset == null)
				{
					r_spriteAsset = new(this, "spriteAsset");
					r_spriteAsset.SetBelong(this.instance);
				}
				return r_spriteAsset;
			}
		}

		/// <summary>
		/// System.Int32 spriteIndex
		/// </summary>
		protected RField r_spriteIndex;
		public virtual RField RspriteIndex
		{
			get
			{
				if(r_spriteIndex == null)
				{
					r_spriteIndex = new(this, "spriteIndex");
					r_spriteIndex.SetBelong(this.instance);
				}
				return r_spriteIndex;
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
					r_material = new(this, "material");
					r_material.SetBelong(this.instance);
				}
				return r_material;
			}
		}

		/// <summary>
		/// System.Int32 materialReferenceIndex
		/// </summary>
		protected RField r_materialReferenceIndex;
		public virtual RField RmaterialReferenceIndex
		{
			get
			{
				if(r_materialReferenceIndex == null)
				{
					r_materialReferenceIndex = new(this, "materialReferenceIndex");
					r_materialReferenceIndex.SetBelong(this.instance);
				}
				return r_materialReferenceIndex;
			}
		}

		/// <summary>
		/// System.Boolean isUsingAlternateTypeface
		/// </summary>
		protected RField r_isUsingAlternateTypeface;
		public virtual RField RisUsingAlternateTypeface
		{
			get
			{
				if(r_isUsingAlternateTypeface == null)
				{
					r_isUsingAlternateTypeface = new(this, "isUsingAlternateTypeface");
					r_isUsingAlternateTypeface.SetBelong(this.instance);
				}
				return r_isUsingAlternateTypeface;
			}
		}

		/// <summary>
		/// System.Single pointSize
		/// </summary>
		protected RField r_pointSize;
		public virtual RField RpointSize
		{
			get
			{
				if(r_pointSize == null)
				{
					r_pointSize = new(this, "pointSize");
					r_pointSize.SetBelong(this.instance);
				}
				return r_pointSize;
			}
		}

		/// <summary>
		/// System.Int32 lineNumber
		/// </summary>
		protected RField r_lineNumber;
		public virtual RField RlineNumber
		{
			get
			{
				if(r_lineNumber == null)
				{
					r_lineNumber = new(this, "lineNumber");
					r_lineNumber.SetBelong(this.instance);
				}
				return r_lineNumber;
			}
		}

		/// <summary>
		/// System.Int32 pageNumber
		/// </summary>
		protected RField r_pageNumber;
		public virtual RField RpageNumber
		{
			get
			{
				if(r_pageNumber == null)
				{
					r_pageNumber = new(this, "pageNumber");
					r_pageNumber.SetBelong(this.instance);
				}
				return r_pageNumber;
			}
		}

		/// <summary>
		/// System.Int32 vertexIndex
		/// </summary>
		protected RField r_vertexIndex;
		public virtual RField RvertexIndex
		{
			get
			{
				if(r_vertexIndex == null)
				{
					r_vertexIndex = new(this, "vertexIndex");
					r_vertexIndex.SetBelong(this.instance);
				}
				return r_vertexIndex;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextVertex vertexTopLeft
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RTextVertex r_vertexTopLeft;
		public virtual RUnityEngine.RTextCore.RText.RTextVertex RvertexTopLeft
		{
			get
			{
				if(r_vertexTopLeft == null)
				{
					r_vertexTopLeft = new(this, "vertexTopLeft");
					r_vertexTopLeft.SetBelong(this.instance);
				}
				return r_vertexTopLeft;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextVertex vertexBottomLeft
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RTextVertex r_vertexBottomLeft;
		public virtual RUnityEngine.RTextCore.RText.RTextVertex RvertexBottomLeft
		{
			get
			{
				if(r_vertexBottomLeft == null)
				{
					r_vertexBottomLeft = new(this, "vertexBottomLeft");
					r_vertexBottomLeft.SetBelong(this.instance);
				}
				return r_vertexBottomLeft;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextVertex vertexTopRight
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RTextVertex r_vertexTopRight;
		public virtual RUnityEngine.RTextCore.RText.RTextVertex RvertexTopRight
		{
			get
			{
				if(r_vertexTopRight == null)
				{
					r_vertexTopRight = new(this, "vertexTopRight");
					r_vertexTopRight.SetBelong(this.instance);
				}
				return r_vertexTopRight;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextVertex vertexBottomRight
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RTextVertex r_vertexBottomRight;
		public virtual RUnityEngine.RTextCore.RText.RTextVertex RvertexBottomRight
		{
			get
			{
				if(r_vertexBottomRight == null)
				{
					r_vertexBottomRight = new(this, "vertexBottomRight");
					r_vertexBottomRight.SetBelong(this.instance);
				}
				return r_vertexBottomRight;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 topLeft
		/// </summary>
		protected RUnityEngine.RVector3 r_topLeft;
		public virtual RUnityEngine.RVector3 RtopLeft
		{
			get
			{
				if(r_topLeft == null)
				{
					r_topLeft = new(this, "topLeft");
					r_topLeft.SetBelong(this.instance);
				}
				return r_topLeft;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 bottomLeft
		/// </summary>
		protected RUnityEngine.RVector3 r_bottomLeft;
		public virtual RUnityEngine.RVector3 RbottomLeft
		{
			get
			{
				if(r_bottomLeft == null)
				{
					r_bottomLeft = new(this, "bottomLeft");
					r_bottomLeft.SetBelong(this.instance);
				}
				return r_bottomLeft;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 topRight
		/// </summary>
		protected RUnityEngine.RVector3 r_topRight;
		public virtual RUnityEngine.RVector3 RtopRight
		{
			get
			{
				if(r_topRight == null)
				{
					r_topRight = new(this, "topRight");
					r_topRight.SetBelong(this.instance);
				}
				return r_topRight;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 bottomRight
		/// </summary>
		protected RUnityEngine.RVector3 r_bottomRight;
		public virtual RUnityEngine.RVector3 RbottomRight
		{
			get
			{
				if(r_bottomRight == null)
				{
					r_bottomRight = new(this, "bottomRight");
					r_bottomRight.SetBelong(this.instance);
				}
				return r_bottomRight;
			}
		}

		/// <summary>
		/// System.Single origin
		/// </summary>
		protected RField r_origin;
		public virtual RField Rorigin
		{
			get
			{
				if(r_origin == null)
				{
					r_origin = new(this, "origin");
					r_origin.SetBelong(this.instance);
				}
				return r_origin;
			}
		}

		/// <summary>
		/// System.Single ascender
		/// </summary>
		protected RField r_ascender;
		public virtual RField Rascender
		{
			get
			{
				if(r_ascender == null)
				{
					r_ascender = new(this, "ascender");
					r_ascender.SetBelong(this.instance);
				}
				return r_ascender;
			}
		}

		/// <summary>
		/// System.Single baseLine
		/// </summary>
		protected RField r_baseLine;
		public virtual RField RbaseLine
		{
			get
			{
				if(r_baseLine == null)
				{
					r_baseLine = new(this, "baseLine");
					r_baseLine.SetBelong(this.instance);
				}
				return r_baseLine;
			}
		}

		/// <summary>
		/// System.Single descender
		/// </summary>
		protected RField r_descender;
		public virtual RField Rdescender
		{
			get
			{
				if(r_descender == null)
				{
					r_descender = new(this, "descender");
					r_descender.SetBelong(this.instance);
				}
				return r_descender;
			}
		}

		/// <summary>
		/// System.Single adjustedAscender
		/// </summary>
		protected RField r_adjustedAscender;
		public virtual RField RadjustedAscender
		{
			get
			{
				if(r_adjustedAscender == null)
				{
					r_adjustedAscender = new(this, "adjustedAscender");
					r_adjustedAscender.SetBelong(this.instance);
				}
				return r_adjustedAscender;
			}
		}

		/// <summary>
		/// System.Single adjustedDescender
		/// </summary>
		protected RField r_adjustedDescender;
		public virtual RField RadjustedDescender
		{
			get
			{
				if(r_adjustedDescender == null)
				{
					r_adjustedDescender = new(this, "adjustedDescender");
					r_adjustedDescender.SetBelong(this.instance);
				}
				return r_adjustedDescender;
			}
		}

		/// <summary>
		/// System.Single adjustedHorizontalAdvance
		/// </summary>
		protected RField r_adjustedHorizontalAdvance;
		public virtual RField RadjustedHorizontalAdvance
		{
			get
			{
				if(r_adjustedHorizontalAdvance == null)
				{
					r_adjustedHorizontalAdvance = new(this, "adjustedHorizontalAdvance");
					r_adjustedHorizontalAdvance.SetBelong(this.instance);
				}
				return r_adjustedHorizontalAdvance;
			}
		}

		/// <summary>
		/// System.Single xAdvance
		/// </summary>
		protected RField r_xAdvance;
		public virtual RField RxAdvance
		{
			get
			{
				if(r_xAdvance == null)
				{
					r_xAdvance = new(this, "xAdvance");
					r_xAdvance.SetBelong(this.instance);
				}
				return r_xAdvance;
			}
		}

		/// <summary>
		/// System.Single aspectRatio
		/// </summary>
		protected RField r_aspectRatio;
		public virtual RField RaspectRatio
		{
			get
			{
				if(r_aspectRatio == null)
				{
					r_aspectRatio = new(this, "aspectRatio");
					r_aspectRatio.SetBelong(this.instance);
				}
				return r_aspectRatio;
			}
		}

		/// <summary>
		/// System.Single scale
		/// </summary>
		protected RField r_scale;
		public virtual RField Rscale
		{
			get
			{
				if(r_scale == null)
				{
					r_scale = new(this, "scale");
					r_scale.SetBelong(this.instance);
				}
				return r_scale;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 color
		/// </summary>
		protected RUnityEngine.RColor32 r_color;
		public virtual RUnityEngine.RColor32 Rcolor
		{
			get
			{
				if(r_color == null)
				{
					r_color = new(this, "color");
					r_color.SetBelong(this.instance);
				}
				return r_color;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 underlineColor
		/// </summary>
		protected RUnityEngine.RColor32 r_underlineColor;
		public virtual RUnityEngine.RColor32 RunderlineColor
		{
			get
			{
				if(r_underlineColor == null)
				{
					r_underlineColor = new(this, "underlineColor");
					r_underlineColor.SetBelong(this.instance);
				}
				return r_underlineColor;
			}
		}

		/// <summary>
		/// System.Int32 underlineVertexIndex
		/// </summary>
		protected RField r_underlineVertexIndex;
		public virtual RField RunderlineVertexIndex
		{
			get
			{
				if(r_underlineVertexIndex == null)
				{
					r_underlineVertexIndex = new(this, "underlineVertexIndex");
					r_underlineVertexIndex.SetBelong(this.instance);
				}
				return r_underlineVertexIndex;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 strikethroughColor
		/// </summary>
		protected RUnityEngine.RColor32 r_strikethroughColor;
		public virtual RUnityEngine.RColor32 RstrikethroughColor
		{
			get
			{
				if(r_strikethroughColor == null)
				{
					r_strikethroughColor = new(this, "strikethroughColor");
					r_strikethroughColor.SetBelong(this.instance);
				}
				return r_strikethroughColor;
			}
		}

		/// <summary>
		/// System.Int32 strikethroughVertexIndex
		/// </summary>
		protected RField r_strikethroughVertexIndex;
		public virtual RField RstrikethroughVertexIndex
		{
			get
			{
				if(r_strikethroughVertexIndex == null)
				{
					r_strikethroughVertexIndex = new(this, "strikethroughVertexIndex");
					r_strikethroughVertexIndex.SetBelong(this.instance);
				}
				return r_strikethroughVertexIndex;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 highlightColor
		/// </summary>
		protected RUnityEngine.RColor32 r_highlightColor;
		public virtual RUnityEngine.RColor32 RhighlightColor
		{
			get
			{
				if(r_highlightColor == null)
				{
					r_highlightColor = new(this, "highlightColor");
					r_highlightColor.SetBelong(this.instance);
				}
				return r_highlightColor;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.HighlightState highlightState
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RHighlightState r_highlightState;
		public virtual RUnityEngine.RTextCore.RText.RHighlightState RhighlightState
		{
			get
			{
				if(r_highlightState == null)
				{
					r_highlightState = new(this, "highlightState");
					r_highlightState.SetBelong(this.instance);
				}
				return r_highlightState;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontStyles style
		/// </summary>
		protected RField r_style;
		public virtual RField Rstyle
		{
			get
			{
				if(r_style == null)
				{
					r_style = new(this, "style");
					r_style.SetBelong(this.instance);
				}
				return r_style;
			}
		}

		/// <summary>
		/// System.Boolean isVisible
		/// </summary>
		protected RField r_isVisible;
		public virtual RField RisVisible
		{
			get
			{
				if(r_isVisible == null)
				{
					r_isVisible = new(this, "isVisible");
					r_isVisible.SetBelong(this.instance);
				}
				return r_isVisible;
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


        public RTextElementInfo() : base("UnityEngine.TextCore.Text.TextElementInfo")
        {
        }

        public RTextElementInfo(System.Object instance) : base("UnityEngine.TextCore.Text.TextElementInfo")
		{
            SetInstance(instance);
		}

        public RTextElementInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextElementInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
