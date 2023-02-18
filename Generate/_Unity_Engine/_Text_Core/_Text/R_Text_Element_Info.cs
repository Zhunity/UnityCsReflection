
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.TextElementInfo
	/// </summary>
    public partial class RTextElementInfo : RMember //
    {

		/// <summary>
		/// System.Char character
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RChar r_Fcharacter;
		public virtual Hvak.Editor.Refleaction.RSystem.RChar RFcharacter
		{
			get
			{
				if(r_Fcharacter == null)
				{
					r_Fcharacter = new(this, "character");
				}
				return r_Fcharacter;
			}
		}

		/// <summary>
		/// System.Int32 index
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Findex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFindex
		{
			get
			{
				if(r_Findex == null)
				{
					r_Findex = new(this, "index");
				}
				return r_Findex;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextElementType elementType
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextElementType r_FelementType;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextElementType RFelementType
		{
			get
			{
				if(r_FelementType == null)
				{
					r_FelementType = new(this, "elementType");
				}
				return r_FelementType;
			}
		}

		/// <summary>
		/// System.Int32 stringLength
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FstringLength;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFstringLength
		{
			get
			{
				if(r_FstringLength == null)
				{
					r_FstringLength = new(this, "stringLength");
				}
				return r_FstringLength;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextElement textElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextElement r_FtextElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextElement RFtextElement
		{
			get
			{
				if(r_FtextElement == null)
				{
					r_FtextElement = new(this, "textElement");
				}
				return r_FtextElement;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Glyph alternativeGlyph
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyph r_FalternativeGlyph;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyph RFalternativeGlyph
		{
			get
			{
				if(r_FalternativeGlyph == null)
				{
					r_FalternativeGlyph = new(this, "alternativeGlyph");
				}
				return r_FalternativeGlyph;
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
		/// System.Int32 spriteIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FspriteIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFspriteIndex
		{
			get
			{
				if(r_FspriteIndex == null)
				{
					r_FspriteIndex = new(this, "spriteIndex");
				}
				return r_FspriteIndex;
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
		/// System.Int32 materialReferenceIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FmaterialReferenceIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFmaterialReferenceIndex
		{
			get
			{
				if(r_FmaterialReferenceIndex == null)
				{
					r_FmaterialReferenceIndex = new(this, "materialReferenceIndex");
				}
				return r_FmaterialReferenceIndex;
			}
		}

		/// <summary>
		/// System.Boolean isUsingAlternateTypeface
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FisUsingAlternateTypeface;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFisUsingAlternateTypeface
		{
			get
			{
				if(r_FisUsingAlternateTypeface == null)
				{
					r_FisUsingAlternateTypeface = new(this, "isUsingAlternateTypeface");
				}
				return r_FisUsingAlternateTypeface;
			}
		}

		/// <summary>
		/// System.Single pointSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FpointSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFpointSize
		{
			get
			{
				if(r_FpointSize == null)
				{
					r_FpointSize = new(this, "pointSize");
				}
				return r_FpointSize;
			}
		}

		/// <summary>
		/// System.Int32 lineNumber
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FlineNumber;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFlineNumber
		{
			get
			{
				if(r_FlineNumber == null)
				{
					r_FlineNumber = new(this, "lineNumber");
				}
				return r_FlineNumber;
			}
		}

		/// <summary>
		/// System.Int32 pageNumber
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FpageNumber;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFpageNumber
		{
			get
			{
				if(r_FpageNumber == null)
				{
					r_FpageNumber = new(this, "pageNumber");
				}
				return r_FpageNumber;
			}
		}

		/// <summary>
		/// System.Int32 vertexIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FvertexIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFvertexIndex
		{
			get
			{
				if(r_FvertexIndex == null)
				{
					r_FvertexIndex = new(this, "vertexIndex");
				}
				return r_FvertexIndex;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextVertex vertexTopLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextVertex r_FvertexTopLeft;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextVertex RFvertexTopLeft
		{
			get
			{
				if(r_FvertexTopLeft == null)
				{
					r_FvertexTopLeft = new(this, "vertexTopLeft");
				}
				return r_FvertexTopLeft;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextVertex vertexBottomLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextVertex r_FvertexBottomLeft;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextVertex RFvertexBottomLeft
		{
			get
			{
				if(r_FvertexBottomLeft == null)
				{
					r_FvertexBottomLeft = new(this, "vertexBottomLeft");
				}
				return r_FvertexBottomLeft;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextVertex vertexTopRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextVertex r_FvertexTopRight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextVertex RFvertexTopRight
		{
			get
			{
				if(r_FvertexTopRight == null)
				{
					r_FvertexTopRight = new(this, "vertexTopRight");
				}
				return r_FvertexTopRight;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextVertex vertexBottomRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextVertex r_FvertexBottomRight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextVertex RFvertexBottomRight
		{
			get
			{
				if(r_FvertexBottomRight == null)
				{
					r_FvertexBottomRight = new(this, "vertexBottomRight");
				}
				return r_FvertexBottomRight;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 topLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_FtopLeft;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RFtopLeft
		{
			get
			{
				if(r_FtopLeft == null)
				{
					r_FtopLeft = new(this, "topLeft");
				}
				return r_FtopLeft;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 bottomLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_FbottomLeft;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RFbottomLeft
		{
			get
			{
				if(r_FbottomLeft == null)
				{
					r_FbottomLeft = new(this, "bottomLeft");
				}
				return r_FbottomLeft;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 topRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_FtopRight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RFtopRight
		{
			get
			{
				if(r_FtopRight == null)
				{
					r_FtopRight = new(this, "topRight");
				}
				return r_FtopRight;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 bottomRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_FbottomRight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RFbottomRight
		{
			get
			{
				if(r_FbottomRight == null)
				{
					r_FbottomRight = new(this, "bottomRight");
				}
				return r_FbottomRight;
			}
		}

		/// <summary>
		/// System.Single origin
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Forigin;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RForigin
		{
			get
			{
				if(r_Forigin == null)
				{
					r_Forigin = new(this, "origin");
				}
				return r_Forigin;
			}
		}

		/// <summary>
		/// System.Single ascender
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fascender;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFascender
		{
			get
			{
				if(r_Fascender == null)
				{
					r_Fascender = new(this, "ascender");
				}
				return r_Fascender;
			}
		}

		/// <summary>
		/// System.Single baseLine
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FbaseLine;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFbaseLine
		{
			get
			{
				if(r_FbaseLine == null)
				{
					r_FbaseLine = new(this, "baseLine");
				}
				return r_FbaseLine;
			}
		}

		/// <summary>
		/// System.Single descender
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fdescender;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFdescender
		{
			get
			{
				if(r_Fdescender == null)
				{
					r_Fdescender = new(this, "descender");
				}
				return r_Fdescender;
			}
		}

		/// <summary>
		/// System.Single adjustedAscender
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FadjustedAscender;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFadjustedAscender
		{
			get
			{
				if(r_FadjustedAscender == null)
				{
					r_FadjustedAscender = new(this, "adjustedAscender");
				}
				return r_FadjustedAscender;
			}
		}

		/// <summary>
		/// System.Single adjustedDescender
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FadjustedDescender;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFadjustedDescender
		{
			get
			{
				if(r_FadjustedDescender == null)
				{
					r_FadjustedDescender = new(this, "adjustedDescender");
				}
				return r_FadjustedDescender;
			}
		}

		/// <summary>
		/// System.Single adjustedHorizontalAdvance
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FadjustedHorizontalAdvance;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFadjustedHorizontalAdvance
		{
			get
			{
				if(r_FadjustedHorizontalAdvance == null)
				{
					r_FadjustedHorizontalAdvance = new(this, "adjustedHorizontalAdvance");
				}
				return r_FadjustedHorizontalAdvance;
			}
		}

		/// <summary>
		/// System.Single xAdvance
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FxAdvance;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFxAdvance
		{
			get
			{
				if(r_FxAdvance == null)
				{
					r_FxAdvance = new(this, "xAdvance");
				}
				return r_FxAdvance;
			}
		}

		/// <summary>
		/// System.Single aspectRatio
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FaspectRatio;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFaspectRatio
		{
			get
			{
				if(r_FaspectRatio == null)
				{
					r_FaspectRatio = new(this, "aspectRatio");
				}
				return r_FaspectRatio;
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
		/// UnityEngine.Color32 color
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor32 r_Fcolor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor32 RFcolor
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
		/// UnityEngine.Color32 underlineColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor32 r_FunderlineColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor32 RFunderlineColor
		{
			get
			{
				if(r_FunderlineColor == null)
				{
					r_FunderlineColor = new(this, "underlineColor");
				}
				return r_FunderlineColor;
			}
		}

		/// <summary>
		/// System.Int32 underlineVertexIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FunderlineVertexIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFunderlineVertexIndex
		{
			get
			{
				if(r_FunderlineVertexIndex == null)
				{
					r_FunderlineVertexIndex = new(this, "underlineVertexIndex");
				}
				return r_FunderlineVertexIndex;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 strikethroughColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor32 r_FstrikethroughColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor32 RFstrikethroughColor
		{
			get
			{
				if(r_FstrikethroughColor == null)
				{
					r_FstrikethroughColor = new(this, "strikethroughColor");
				}
				return r_FstrikethroughColor;
			}
		}

		/// <summary>
		/// System.Int32 strikethroughVertexIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FstrikethroughVertexIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFstrikethroughVertexIndex
		{
			get
			{
				if(r_FstrikethroughVertexIndex == null)
				{
					r_FstrikethroughVertexIndex = new(this, "strikethroughVertexIndex");
				}
				return r_FstrikethroughVertexIndex;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 highlightColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor32 r_FhighlightColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor32 RFhighlightColor
		{
			get
			{
				if(r_FhighlightColor == null)
				{
					r_FhighlightColor = new(this, "highlightColor");
				}
				return r_FhighlightColor;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.HighlightState highlightState
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RHighlightState r_FhighlightState;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RHighlightState RFhighlightState
		{
			get
			{
				if(r_FhighlightState == null)
				{
					r_FhighlightState = new(this, "highlightState");
				}
				return r_FhighlightState;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontStyles style
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles r_Fstyle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles RFstyle
		{
			get
			{
				if(r_Fstyle == null)
				{
					r_Fstyle = new(this, "style");
				}
				return r_Fstyle;
			}
		}

		/// <summary>
		/// System.Boolean isVisible
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FisVisible;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFisVisible
		{
			get
			{
				if(r_FisVisible == null)
				{
					r_FisVisible = new(this, "isVisible");
				}
				return r_FisVisible;
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
