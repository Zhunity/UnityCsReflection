using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.InlineStyleAccess
	/// </summary>
    public partial class RInlineStyleAccess : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyReader s_StylePropertyReader
		/// </summary>
		protected static RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader r_s_StylePropertyReader;
		public static RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader Rs_StylePropertyReader
		{
			get
			{
				if(r_s_StylePropertyReader == null)
				{
					r_s_StylePropertyReader = new( ReleactionUtils.GetType("UnityEngine.UIElements.InlineStyleAccess"), "s_StylePropertyReader");
					r_s_StylePropertyReader.SetBelong(null);
				}
				return r_s_StylePropertyReader;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheets.StyleValueManaged] m_ValuesManaged
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheets.RStyleValueManaged> r_m_ValuesManaged;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheets.RStyleValueManaged> Rm_ValuesManaged
		{
			get
			{
				if(r_m_ValuesManaged == null)
				{
					r_m_ValuesManaged = new(this, "m_ValuesManaged");
					r_m_ValuesManaged.SetBelong(this.instance);
				}
				return r_m_ValuesManaged;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement <ve>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r___1__ve__2__k__BackingField;
		public virtual RUnityEngine.RUIElements.RVisualElement R__1__ve__2__k__BackingField
		{
			get
			{
				if(r___1__ve__2__k__BackingField == null)
				{
					r___1__ve__2__k__BackingField = new(this, "<ve>k__BackingField");
					r___1__ve__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__ve__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean m_HasInlineCursor
		/// </summary>
		protected RField r_m_HasInlineCursor;
		public virtual RField Rm_HasInlineCursor
		{
			get
			{
				if(r_m_HasInlineCursor == null)
				{
					r_m_HasInlineCursor = new(this, "m_HasInlineCursor");
					r_m_HasInlineCursor.SetBelong(this.instance);
				}
				return r_m_HasInlineCursor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleCursor m_InlineCursor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleCursor r_m_InlineCursor;
		public virtual RUnityEngine.RUIElements.RStyleCursor Rm_InlineCursor
		{
			get
			{
				if(r_m_InlineCursor == null)
				{
					r_m_InlineCursor = new(this, "m_InlineCursor");
					r_m_InlineCursor.SetBelong(this.instance);
				}
				return r_m_InlineCursor;
			}
		}

		/// <summary>
		/// System.Boolean m_HasInlineTextShadow
		/// </summary>
		protected RField r_m_HasInlineTextShadow;
		public virtual RField Rm_HasInlineTextShadow
		{
			get
			{
				if(r_m_HasInlineTextShadow == null)
				{
					r_m_HasInlineTextShadow = new(this, "m_HasInlineTextShadow");
					r_m_HasInlineTextShadow.SetBelong(this.instance);
				}
				return r_m_HasInlineTextShadow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleTextShadow m_InlineTextShadow
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleTextShadow r_m_InlineTextShadow;
		public virtual RUnityEngine.RUIElements.RStyleTextShadow Rm_InlineTextShadow
		{
			get
			{
				if(r_m_InlineTextShadow == null)
				{
					r_m_InlineTextShadow = new(this, "m_InlineTextShadow");
					r_m_InlineTextShadow.SetBelong(this.instance);
				}
				return r_m_InlineTextShadow;
			}
		}

		/// <summary>
		/// System.Boolean m_HasInlineTransformOrigin
		/// </summary>
		protected RField r_m_HasInlineTransformOrigin;
		public virtual RField Rm_HasInlineTransformOrigin
		{
			get
			{
				if(r_m_HasInlineTransformOrigin == null)
				{
					r_m_HasInlineTransformOrigin = new(this, "m_HasInlineTransformOrigin");
					r_m_HasInlineTransformOrigin.SetBelong(this.instance);
				}
				return r_m_HasInlineTransformOrigin;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleTransformOrigin m_InlineTransformOrigin
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleTransformOrigin r_m_InlineTransformOrigin;
		public virtual RUnityEngine.RUIElements.RStyleTransformOrigin Rm_InlineTransformOrigin
		{
			get
			{
				if(r_m_InlineTransformOrigin == null)
				{
					r_m_InlineTransformOrigin = new(this, "m_InlineTransformOrigin");
					r_m_InlineTransformOrigin.SetBelong(this.instance);
				}
				return r_m_InlineTransformOrigin;
			}
		}

		/// <summary>
		/// System.Boolean m_HasInlineTranslate
		/// </summary>
		protected RField r_m_HasInlineTranslate;
		public virtual RField Rm_HasInlineTranslate
		{
			get
			{
				if(r_m_HasInlineTranslate == null)
				{
					r_m_HasInlineTranslate = new(this, "m_HasInlineTranslate");
					r_m_HasInlineTranslate.SetBelong(this.instance);
				}
				return r_m_HasInlineTranslate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleTranslate m_InlineTranslateOperation
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleTranslate r_m_InlineTranslateOperation;
		public virtual RUnityEngine.RUIElements.RStyleTranslate Rm_InlineTranslateOperation
		{
			get
			{
				if(r_m_InlineTranslateOperation == null)
				{
					r_m_InlineTranslateOperation = new(this, "m_InlineTranslateOperation");
					r_m_InlineTranslateOperation.SetBelong(this.instance);
				}
				return r_m_InlineTranslateOperation;
			}
		}

		/// <summary>
		/// System.Boolean m_HasInlineRotate
		/// </summary>
		protected RField r_m_HasInlineRotate;
		public virtual RField Rm_HasInlineRotate
		{
			get
			{
				if(r_m_HasInlineRotate == null)
				{
					r_m_HasInlineRotate = new(this, "m_HasInlineRotate");
					r_m_HasInlineRotate.SetBelong(this.instance);
				}
				return r_m_HasInlineRotate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleRotate m_InlineRotateOperation
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleRotate r_m_InlineRotateOperation;
		public virtual RUnityEngine.RUIElements.RStyleRotate Rm_InlineRotateOperation
		{
			get
			{
				if(r_m_InlineRotateOperation == null)
				{
					r_m_InlineRotateOperation = new(this, "m_InlineRotateOperation");
					r_m_InlineRotateOperation.SetBelong(this.instance);
				}
				return r_m_InlineRotateOperation;
			}
		}

		/// <summary>
		/// System.Boolean m_HasInlineScale
		/// </summary>
		protected RField r_m_HasInlineScale;
		public virtual RField Rm_HasInlineScale
		{
			get
			{
				if(r_m_HasInlineScale == null)
				{
					r_m_HasInlineScale = new(this, "m_HasInlineScale");
					r_m_HasInlineScale.SetBelong(this.instance);
				}
				return r_m_HasInlineScale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleScale m_InlineScale
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleScale r_m_InlineScale;
		public virtual RUnityEngine.RUIElements.RStyleScale Rm_InlineScale
		{
			get
			{
				if(r_m_InlineScale == null)
				{
					r_m_InlineScale = new(this, "m_InlineScale");
					r_m_InlineScale.SetBelong(this.instance);
				}
				return r_m_InlineScale;
			}
		}

		/// <summary>
		/// System.Boolean m_HasInlineBackgroundSize
		/// </summary>
		protected RField r_m_HasInlineBackgroundSize;
		public virtual RField Rm_HasInlineBackgroundSize
		{
			get
			{
				if(r_m_HasInlineBackgroundSize == null)
				{
					r_m_HasInlineBackgroundSize = new(this, "m_HasInlineBackgroundSize");
					r_m_HasInlineBackgroundSize.SetBelong(this.instance);
				}
				return r_m_HasInlineBackgroundSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundSize m_InlineBackgroundSize
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleBackgroundSize r_m_InlineBackgroundSize;
		public virtual RUnityEngine.RUIElements.RStyleBackgroundSize Rm_InlineBackgroundSize
		{
			get
			{
				if(r_m_InlineBackgroundSize == null)
				{
					r_m_InlineBackgroundSize = new(this, "m_InlineBackgroundSize");
					r_m_InlineBackgroundSize.SetBelong(this.instance);
				}
				return r_m_InlineBackgroundSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.InlineStyleAccess+InlineRule m_InlineRule
		/// </summary>
		protected RUnityEngine.RUIElements.RInlineStyleAccess.RInlineRule r_m_InlineRule;
		public virtual RUnityEngine.RUIElements.RInlineStyleAccess.RInlineRule Rm_InlineRule
		{
			get
			{
				if(r_m_InlineRule == null)
				{
					r_m_InlineRule = new(this, "m_InlineRule");
					r_m_InlineRule.SetBelong(this.instance);
				}
				return r_m_InlineRule;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheets.StyleValue] m_Values
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheets.RStyleValue> r_m_Values;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheets.RStyleValue> Rm_Values
		{
			get
			{
				if(r_m_Values == null)
				{
					r_m_Values = new(this, "m_Values");
					r_m_Values.SetBelong(this.instance);
				}
				return r_m_Values;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Align] UnityEngine.UIElements.IStyle.alignContent
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IStyle__0__get_alignContent;
		public virtual RProperty RUnityEngine__0__UIElements__0__IStyle__0__get_alignContent
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_alignContent == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_alignContent = new(this, "UnityEngine.UIElements.IStyle.alignContent", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_alignContent.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_alignContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Align] UnityEngine.UIElements.IStyle.alignItems
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IStyle__0__get_alignItems;
		public virtual RProperty RUnityEngine__0__UIElements__0__IStyle__0__get_alignItems
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_alignItems == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_alignItems = new(this, "UnityEngine.UIElements.IStyle.alignItems", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_alignItems.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_alignItems;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Align] UnityEngine.UIElements.IStyle.alignSelf
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IStyle__0__get_alignSelf;
		public virtual RProperty RUnityEngine__0__UIElements__0__IStyle__0__get_alignSelf
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_alignSelf == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_alignSelf = new(this, "UnityEngine.UIElements.IStyle.alignSelf", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_alignSelf.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_alignSelf;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor UnityEngine.UIElements.IStyle.backgroundColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundColor
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundColor == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundColor = new(this, "UnityEngine.UIElements.IStyle.backgroundColor", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundColor.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackground UnityEngine.UIElements.IStyle.backgroundImage
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleBackground r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundImage;
		public virtual RUnityEngine.RUIElements.RStyleBackground RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundImage
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundImage == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundImage = new(this, "UnityEngine.UIElements.IStyle.backgroundImage", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundImage.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundImage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundPosition UnityEngine.UIElements.IStyle.backgroundPositionX
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleBackgroundPosition r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundPositionX;
		public virtual RUnityEngine.RUIElements.RStyleBackgroundPosition RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundPositionX
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundPositionX == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundPositionX = new(this, "UnityEngine.UIElements.IStyle.backgroundPositionX", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundPositionX.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundPositionX;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundPosition UnityEngine.UIElements.IStyle.backgroundPositionY
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleBackgroundPosition r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundPositionY;
		public virtual RUnityEngine.RUIElements.RStyleBackgroundPosition RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundPositionY
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundPositionY == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundPositionY = new(this, "UnityEngine.UIElements.IStyle.backgroundPositionY", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundPositionY.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundPositionY;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundRepeat UnityEngine.UIElements.IStyle.backgroundRepeat
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleBackgroundRepeat r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundRepeat;
		public virtual RUnityEngine.RUIElements.RStyleBackgroundRepeat RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundRepeat
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundRepeat == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundRepeat = new(this, "UnityEngine.UIElements.IStyle.backgroundRepeat", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundRepeat.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundRepeat;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor UnityEngine.UIElements.IStyle.borderBottomColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderBottomColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RUnityEngine__0__UIElements__0__IStyle__0__get_borderBottomColor
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderBottomColor == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderBottomColor = new(this, "UnityEngine.UIElements.IStyle.borderBottomColor", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderBottomColor.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderBottomColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.borderBottomLeftRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderBottomLeftRadius;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_borderBottomLeftRadius
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderBottomLeftRadius == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderBottomLeftRadius = new(this, "UnityEngine.UIElements.IStyle.borderBottomLeftRadius", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderBottomLeftRadius.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderBottomLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.borderBottomRightRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderBottomRightRadius;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_borderBottomRightRadius
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderBottomRightRadius == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderBottomRightRadius = new(this, "UnityEngine.UIElements.IStyle.borderBottomRightRadius", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderBottomRightRadius.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderBottomRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.borderBottomWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderBottomWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RUnityEngine__0__UIElements__0__IStyle__0__get_borderBottomWidth
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderBottomWidth == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderBottomWidth = new(this, "UnityEngine.UIElements.IStyle.borderBottomWidth", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderBottomWidth.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderBottomWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor UnityEngine.UIElements.IStyle.borderLeftColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderLeftColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RUnityEngine__0__UIElements__0__IStyle__0__get_borderLeftColor
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderLeftColor == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderLeftColor = new(this, "UnityEngine.UIElements.IStyle.borderLeftColor", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderLeftColor.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderLeftColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.borderLeftWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderLeftWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RUnityEngine__0__UIElements__0__IStyle__0__get_borderLeftWidth
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderLeftWidth == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderLeftWidth = new(this, "UnityEngine.UIElements.IStyle.borderLeftWidth", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderLeftWidth.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderLeftWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor UnityEngine.UIElements.IStyle.borderRightColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderRightColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RUnityEngine__0__UIElements__0__IStyle__0__get_borderRightColor
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderRightColor == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderRightColor = new(this, "UnityEngine.UIElements.IStyle.borderRightColor", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderRightColor.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderRightColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.borderRightWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderRightWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RUnityEngine__0__UIElements__0__IStyle__0__get_borderRightWidth
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderRightWidth == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderRightWidth = new(this, "UnityEngine.UIElements.IStyle.borderRightWidth", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderRightWidth.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderRightWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor UnityEngine.UIElements.IStyle.borderTopColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderTopColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RUnityEngine__0__UIElements__0__IStyle__0__get_borderTopColor
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderTopColor == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderTopColor = new(this, "UnityEngine.UIElements.IStyle.borderTopColor", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderTopColor.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderTopColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.borderTopLeftRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderTopLeftRadius;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_borderTopLeftRadius
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderTopLeftRadius == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderTopLeftRadius = new(this, "UnityEngine.UIElements.IStyle.borderTopLeftRadius", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderTopLeftRadius.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderTopLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.borderTopRightRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderTopRightRadius;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_borderTopRightRadius
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderTopRightRadius == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderTopRightRadius = new(this, "UnityEngine.UIElements.IStyle.borderTopRightRadius", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderTopRightRadius.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderTopRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.borderTopWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderTopWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RUnityEngine__0__UIElements__0__IStyle__0__get_borderTopWidth
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderTopWidth == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderTopWidth = new(this, "UnityEngine.UIElements.IStyle.borderTopWidth", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderTopWidth.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_borderTopWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.bottom
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_bottom;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_bottom
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_bottom == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_bottom = new(this, "UnityEngine.UIElements.IStyle.bottom", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_bottom.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_bottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor UnityEngine.UIElements.IStyle.color
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_RUnityEngine__0__UIElements__0__IStyle__0__get_color;
		public virtual RUnityEngine.RUIElements.RStyleColor RUnityEngine__0__UIElements__0__IStyle__0__get_color
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_color == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_color = new(this, "UnityEngine.UIElements.IStyle.color", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_color.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_color;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.DisplayStyle] UnityEngine.UIElements.IStyle.display
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IStyle__0__get_display;
		public virtual RProperty RUnityEngine__0__UIElements__0__IStyle__0__get_display
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_display == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_display = new(this, "UnityEngine.UIElements.IStyle.display", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_display.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_display;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.flexBasis
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_flexBasis;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_flexBasis
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_flexBasis == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_flexBasis = new(this, "UnityEngine.UIElements.IStyle.flexBasis", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_flexBasis.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_flexBasis;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.FlexDirection] UnityEngine.UIElements.IStyle.flexDirection
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IStyle__0__get_flexDirection;
		public virtual RProperty RUnityEngine__0__UIElements__0__IStyle__0__get_flexDirection
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_flexDirection == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_flexDirection = new(this, "UnityEngine.UIElements.IStyle.flexDirection", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_flexDirection.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_flexDirection;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.flexGrow
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_RUnityEngine__0__UIElements__0__IStyle__0__get_flexGrow;
		public virtual RUnityEngine.RUIElements.RStyleFloat RUnityEngine__0__UIElements__0__IStyle__0__get_flexGrow
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_flexGrow == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_flexGrow = new(this, "UnityEngine.UIElements.IStyle.flexGrow", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_flexGrow.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_flexGrow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.flexShrink
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_RUnityEngine__0__UIElements__0__IStyle__0__get_flexShrink;
		public virtual RUnityEngine.RUIElements.RStyleFloat RUnityEngine__0__UIElements__0__IStyle__0__get_flexShrink
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_flexShrink == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_flexShrink = new(this, "UnityEngine.UIElements.IStyle.flexShrink", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_flexShrink.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_flexShrink;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Wrap] UnityEngine.UIElements.IStyle.flexWrap
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IStyle__0__get_flexWrap;
		public virtual RProperty RUnityEngine__0__UIElements__0__IStyle__0__get_flexWrap
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_flexWrap == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_flexWrap = new(this, "UnityEngine.UIElements.IStyle.flexWrap", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_flexWrap.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_flexWrap;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.fontSize
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_fontSize;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_fontSize
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_fontSize == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_fontSize = new(this, "UnityEngine.UIElements.IStyle.fontSize", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_fontSize.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_fontSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.height
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_height;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_height
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_height == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_height = new(this, "UnityEngine.UIElements.IStyle.height", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_height.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_height;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Justify] UnityEngine.UIElements.IStyle.justifyContent
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IStyle__0__get_justifyContent;
		public virtual RProperty RUnityEngine__0__UIElements__0__IStyle__0__get_justifyContent
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_justifyContent == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_justifyContent = new(this, "UnityEngine.UIElements.IStyle.justifyContent", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_justifyContent.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_justifyContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.left
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_left;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_left
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_left == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_left = new(this, "UnityEngine.UIElements.IStyle.left", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_left.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_left;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.letterSpacing
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_letterSpacing;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_letterSpacing
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_letterSpacing == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_letterSpacing = new(this, "UnityEngine.UIElements.IStyle.letterSpacing", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_letterSpacing.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_letterSpacing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.marginBottom
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_marginBottom;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_marginBottom
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_marginBottom == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_marginBottom = new(this, "UnityEngine.UIElements.IStyle.marginBottom", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_marginBottom.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_marginBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.marginLeft
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_marginLeft;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_marginLeft
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_marginLeft == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_marginLeft = new(this, "UnityEngine.UIElements.IStyle.marginLeft", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_marginLeft.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_marginLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.marginRight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_marginRight;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_marginRight
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_marginRight == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_marginRight = new(this, "UnityEngine.UIElements.IStyle.marginRight", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_marginRight.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_marginRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.marginTop
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_marginTop;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_marginTop
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_marginTop == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_marginTop = new(this, "UnityEngine.UIElements.IStyle.marginTop", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_marginTop.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_marginTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.maxHeight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_maxHeight;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_maxHeight
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_maxHeight == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_maxHeight = new(this, "UnityEngine.UIElements.IStyle.maxHeight", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_maxHeight.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_maxHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.maxWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_maxWidth;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_maxWidth
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_maxWidth == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_maxWidth = new(this, "UnityEngine.UIElements.IStyle.maxWidth", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_maxWidth.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_maxWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.minHeight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_minHeight;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_minHeight
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_minHeight == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_minHeight = new(this, "UnityEngine.UIElements.IStyle.minHeight", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_minHeight.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_minHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.minWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_minWidth;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_minWidth
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_minWidth == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_minWidth = new(this, "UnityEngine.UIElements.IStyle.minWidth", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_minWidth.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_minWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.opacity
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_RUnityEngine__0__UIElements__0__IStyle__0__get_opacity;
		public virtual RUnityEngine.RUIElements.RStyleFloat RUnityEngine__0__UIElements__0__IStyle__0__get_opacity
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_opacity == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_opacity = new(this, "UnityEngine.UIElements.IStyle.opacity", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_opacity.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_opacity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Overflow] UnityEngine.UIElements.IStyle.overflow
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IStyle__0__get_overflow;
		public virtual RProperty RUnityEngine__0__UIElements__0__IStyle__0__get_overflow
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_overflow == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_overflow = new(this, "UnityEngine.UIElements.IStyle.overflow", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_overflow.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_overflow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.paddingBottom
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_paddingBottom;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_paddingBottom
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_paddingBottom == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_paddingBottom = new(this, "UnityEngine.UIElements.IStyle.paddingBottom", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_paddingBottom.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_paddingBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.paddingLeft
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_paddingLeft;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_paddingLeft
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_paddingLeft == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_paddingLeft = new(this, "UnityEngine.UIElements.IStyle.paddingLeft", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_paddingLeft.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_paddingLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.paddingRight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_paddingRight;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_paddingRight
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_paddingRight == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_paddingRight = new(this, "UnityEngine.UIElements.IStyle.paddingRight", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_paddingRight.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_paddingRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.paddingTop
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_paddingTop;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_paddingTop
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_paddingTop == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_paddingTop = new(this, "UnityEngine.UIElements.IStyle.paddingTop", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_paddingTop.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_paddingTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Position] UnityEngine.UIElements.IStyle.position
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IStyle__0__get_position;
		public virtual RProperty RUnityEngine__0__UIElements__0__IStyle__0__get_position
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_position == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_position = new(this, "UnityEngine.UIElements.IStyle.position", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_position.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_position;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.right
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_right;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_right
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_right == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_right = new(this, "UnityEngine.UIElements.IStyle.right", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_right.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_right;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.TextOverflow] UnityEngine.UIElements.IStyle.textOverflow
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IStyle__0__get_textOverflow;
		public virtual RProperty RUnityEngine__0__UIElements__0__IStyle__0__get_textOverflow
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_textOverflow == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_textOverflow = new(this, "UnityEngine.UIElements.IStyle.textOverflow", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_textOverflow.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_textOverflow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.top
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_top;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_top
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_top == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_top = new(this, "UnityEngine.UIElements.IStyle.top", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_top.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_top;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[UnityEngine.UIElements.TimeValue] UnityEngine.UIElements.IStyle.transitionDelay
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.RTimeValue> r_RUnityEngine__0__UIElements__0__IStyle__0__get_transitionDelay;
		public virtual RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.RTimeValue> RUnityEngine__0__UIElements__0__IStyle__0__get_transitionDelay
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_transitionDelay == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_transitionDelay = new(this, "UnityEngine.UIElements.IStyle.transitionDelay", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_transitionDelay.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_transitionDelay;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[UnityEngine.UIElements.TimeValue] UnityEngine.UIElements.IStyle.transitionDuration
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.RTimeValue> r_RUnityEngine__0__UIElements__0__IStyle__0__get_transitionDuration;
		public virtual RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.RTimeValue> RUnityEngine__0__UIElements__0__IStyle__0__get_transitionDuration
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_transitionDuration == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_transitionDuration = new(this, "UnityEngine.UIElements.IStyle.transitionDuration", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_transitionDuration.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_transitionDuration;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[UnityEngine.UIElements.StylePropertyName] UnityEngine.UIElements.IStyle.transitionProperty
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.RStylePropertyName> r_RUnityEngine__0__UIElements__0__IStyle__0__get_transitionProperty;
		public virtual RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.RStylePropertyName> RUnityEngine__0__UIElements__0__IStyle__0__get_transitionProperty
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_transitionProperty == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_transitionProperty = new(this, "UnityEngine.UIElements.IStyle.transitionProperty", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_transitionProperty.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_transitionProperty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[UnityEngine.UIElements.EasingFunction] UnityEngine.UIElements.IStyle.transitionTimingFunction
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.REasingFunction> r_RUnityEngine__0__UIElements__0__IStyle__0__get_transitionTimingFunction;
		public virtual RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.REasingFunction> RUnityEngine__0__UIElements__0__IStyle__0__get_transitionTimingFunction
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_transitionTimingFunction == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_transitionTimingFunction = new(this, "UnityEngine.UIElements.IStyle.transitionTimingFunction", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_transitionTimingFunction.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_transitionTimingFunction;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor UnityEngine.UIElements.IStyle.unityBackgroundImageTintColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityBackgroundImageTintColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RUnityEngine__0__UIElements__0__IStyle__0__get_unityBackgroundImageTintColor
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityBackgroundImageTintColor == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityBackgroundImageTintColor = new(this, "UnityEngine.UIElements.IStyle.unityBackgroundImageTintColor", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityBackgroundImageTintColor.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityBackgroundImageTintColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFont UnityEngine.UIElements.IStyle.unityFont
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFont r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityFont;
		public virtual RUnityEngine.RUIElements.RStyleFont RUnityEngine__0__UIElements__0__IStyle__0__get_unityFont
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityFont == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityFont = new(this, "UnityEngine.UIElements.IStyle.unityFont", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityFont.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityFont;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFontDefinition UnityEngine.UIElements.IStyle.unityFontDefinition
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFontDefinition r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityFontDefinition;
		public virtual RUnityEngine.RUIElements.RStyleFontDefinition RUnityEngine__0__UIElements__0__IStyle__0__get_unityFontDefinition
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityFontDefinition == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityFontDefinition = new(this, "UnityEngine.UIElements.IStyle.unityFontDefinition", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityFontDefinition.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityFontDefinition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.FontStyle] UnityEngine.UIElements.IStyle.unityFontStyleAndWeight
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityFontStyleAndWeight;
		public virtual RProperty RUnityEngine__0__UIElements__0__IStyle__0__get_unityFontStyleAndWeight
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityFontStyleAndWeight == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityFontStyleAndWeight = new(this, "UnityEngine.UIElements.IStyle.unityFontStyleAndWeight", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityFontStyleAndWeight.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityFontStyleAndWeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.OverflowClipBox] UnityEngine.UIElements.IStyle.unityOverflowClipBox
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityOverflowClipBox;
		public virtual RProperty RUnityEngine__0__UIElements__0__IStyle__0__get_unityOverflowClipBox
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityOverflowClipBox == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityOverflowClipBox = new(this, "UnityEngine.UIElements.IStyle.unityOverflowClipBox", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityOverflowClipBox.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityOverflowClipBox;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.unityParagraphSpacing
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityParagraphSpacing;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_unityParagraphSpacing
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityParagraphSpacing == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityParagraphSpacing = new(this, "UnityEngine.UIElements.IStyle.unityParagraphSpacing", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityParagraphSpacing.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityParagraphSpacing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt UnityEngine.UIElements.IStyle.unitySliceBottom
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleInt r_RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceBottom;
		public virtual RUnityEngine.RUIElements.RStyleInt RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceBottom
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceBottom == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceBottom = new(this, "UnityEngine.UIElements.IStyle.unitySliceBottom", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceBottom.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt UnityEngine.UIElements.IStyle.unitySliceLeft
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleInt r_RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceLeft;
		public virtual RUnityEngine.RUIElements.RStyleInt RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceLeft
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceLeft == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceLeft = new(this, "UnityEngine.UIElements.IStyle.unitySliceLeft", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceLeft.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt UnityEngine.UIElements.IStyle.unitySliceRight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleInt r_RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceRight;
		public virtual RUnityEngine.RUIElements.RStyleInt RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceRight
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceRight == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceRight = new(this, "UnityEngine.UIElements.IStyle.unitySliceRight", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceRight.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.unitySliceScale
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceScale;
		public virtual RUnityEngine.RUIElements.RStyleFloat RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceScale
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceScale == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceScale = new(this, "UnityEngine.UIElements.IStyle.unitySliceScale", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceScale.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceScale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt UnityEngine.UIElements.IStyle.unitySliceTop
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleInt r_RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceTop;
		public virtual RUnityEngine.RUIElements.RStyleInt RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceTop
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceTop == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceTop = new(this, "UnityEngine.UIElements.IStyle.unitySliceTop", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceTop.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_unitySliceTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.TextAnchor] UnityEngine.UIElements.IStyle.unityTextAlign
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityTextAlign;
		public virtual RProperty RUnityEngine__0__UIElements__0__IStyle__0__get_unityTextAlign
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityTextAlign == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityTextAlign = new(this, "UnityEngine.UIElements.IStyle.unityTextAlign", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityTextAlign.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityTextAlign;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor UnityEngine.UIElements.IStyle.unityTextOutlineColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityTextOutlineColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RUnityEngine__0__UIElements__0__IStyle__0__get_unityTextOutlineColor
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityTextOutlineColor == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityTextOutlineColor = new(this, "UnityEngine.UIElements.IStyle.unityTextOutlineColor", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityTextOutlineColor.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityTextOutlineColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.unityTextOutlineWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityTextOutlineWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RUnityEngine__0__UIElements__0__IStyle__0__get_unityTextOutlineWidth
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityTextOutlineWidth == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityTextOutlineWidth = new(this, "UnityEngine.UIElements.IStyle.unityTextOutlineWidth", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityTextOutlineWidth.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityTextOutlineWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.TextOverflowPosition] UnityEngine.UIElements.IStyle.unityTextOverflowPosition
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityTextOverflowPosition;
		public virtual RProperty RUnityEngine__0__UIElements__0__IStyle__0__get_unityTextOverflowPosition
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityTextOverflowPosition == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityTextOverflowPosition = new(this, "UnityEngine.UIElements.IStyle.unityTextOverflowPosition", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityTextOverflowPosition.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityTextOverflowPosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Visibility] UnityEngine.UIElements.IStyle.visibility
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IStyle__0__get_visibility;
		public virtual RProperty RUnityEngine__0__UIElements__0__IStyle__0__get_visibility
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_visibility == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_visibility = new(this, "UnityEngine.UIElements.IStyle.visibility", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_visibility.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_visibility;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.WhiteSpace] UnityEngine.UIElements.IStyle.whiteSpace
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IStyle__0__get_whiteSpace;
		public virtual RProperty RUnityEngine__0__UIElements__0__IStyle__0__get_whiteSpace
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_whiteSpace == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_whiteSpace = new(this, "UnityEngine.UIElements.IStyle.whiteSpace", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_whiteSpace.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_whiteSpace;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.width
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_width;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_width
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_width == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_width = new(this, "UnityEngine.UIElements.IStyle.width", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_width.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_width;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.wordSpacing
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_RUnityEngine__0__UIElements__0__IStyle__0__get_wordSpacing;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__0__UIElements__0__IStyle__0__get_wordSpacing
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_wordSpacing == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_wordSpacing = new(this, "UnityEngine.UIElements.IStyle.wordSpacing", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_wordSpacing.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_wordSpacing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement ve
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_ve;
		public virtual RUnityEngine.RUIElements.RVisualElement Rve
		{
			get
			{
				if(r_ve == null)
				{
					r_ve = new(this, "ve", -1);
					r_ve.SetBelong(this.instance);
				}
				return r_ve;
			}
		}

		/// <summary>
		/// InlineRule inlineRule
		/// </summary>
		protected RUnityEngine.RUIElements.RInlineStyleAccess.RInlineRule r_inlineRule;
		public virtual RUnityEngine.RUIElements.RInlineStyleAccess.RInlineRule RinlineRule
		{
			get
			{
				if(r_inlineRule == null)
				{
					r_inlineRule = new(this, "inlineRule", -1);
					r_inlineRule.SetBelong(this.instance);
				}
				return r_inlineRule;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleCursor UnityEngine.UIElements.IStyle.cursor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleCursor r_RUnityEngine__0__UIElements__0__IStyle__0__get_cursor;
		public virtual RUnityEngine.RUIElements.RStyleCursor RUnityEngine__0__UIElements__0__IStyle__0__get_cursor
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_cursor == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_cursor = new(this, "UnityEngine.UIElements.IStyle.cursor", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_cursor.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_cursor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleTextShadow UnityEngine.UIElements.IStyle.textShadow
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleTextShadow r_RUnityEngine__0__UIElements__0__IStyle__0__get_textShadow;
		public virtual RUnityEngine.RUIElements.RStyleTextShadow RUnityEngine__0__UIElements__0__IStyle__0__get_textShadow
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_textShadow == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_textShadow = new(this, "UnityEngine.UIElements.IStyle.textShadow", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_textShadow.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_textShadow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundSize UnityEngine.UIElements.IStyle.backgroundSize
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleBackgroundSize r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundSize;
		public virtual RUnityEngine.RUIElements.RStyleBackgroundSize RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundSize
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundSize == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundSize = new(this, "UnityEngine.UIElements.IStyle.backgroundSize", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundSize.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_backgroundSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleTransformOrigin UnityEngine.UIElements.IStyle.transformOrigin
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleTransformOrigin r_RUnityEngine__0__UIElements__0__IStyle__0__get_transformOrigin;
		public virtual RUnityEngine.RUIElements.RStyleTransformOrigin RUnityEngine__0__UIElements__0__IStyle__0__get_transformOrigin
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_transformOrigin == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_transformOrigin = new(this, "UnityEngine.UIElements.IStyle.transformOrigin", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_transformOrigin.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_transformOrigin;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleTranslate UnityEngine.UIElements.IStyle.translate
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleTranslate r_RUnityEngine__0__UIElements__0__IStyle__0__get_translate;
		public virtual RUnityEngine.RUIElements.RStyleTranslate RUnityEngine__0__UIElements__0__IStyle__0__get_translate
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_translate == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_translate = new(this, "UnityEngine.UIElements.IStyle.translate", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_translate.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_translate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleRotate UnityEngine.UIElements.IStyle.rotate
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleRotate r_RUnityEngine__0__UIElements__0__IStyle__0__get_rotate;
		public virtual RUnityEngine.RUIElements.RStyleRotate RUnityEngine__0__UIElements__0__IStyle__0__get_rotate
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_rotate == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_rotate = new(this, "UnityEngine.UIElements.IStyle.rotate", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_rotate.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_rotate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleScale UnityEngine.UIElements.IStyle.scale
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleScale r_RUnityEngine__0__UIElements__0__IStyle__0__get_scale;
		public virtual RUnityEngine.RUIElements.RStyleScale RUnityEngine__0__UIElements__0__IStyle__0__get_scale
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_scale == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_scale = new(this, "UnityEngine.UIElements.IStyle.scale", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_scale.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_scale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.ScaleMode] UnityEngine.UIElements.IStyle.unityBackgroundScaleMode
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityBackgroundScaleMode;
		public virtual RProperty RUnityEngine__0__UIElements__0__IStyle__0__get_unityBackgroundScaleMode
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityBackgroundScaleMode == null)
				{
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityBackgroundScaleMode = new(this, "UnityEngine.UIElements.IStyle.unityBackgroundScaleMode", -1);
					r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityBackgroundScaleMode.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStyle__0__get_unityBackgroundScaleMode;
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
		/// Void SetInlineRule(UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleRule)
		/// </summary>
		protected RMethod r_RSetInlineRule_StyleSheet_StyleRule;
		public virtual RMethod RSetInlineRule_StyleSheet_StyleRule
		{
			get
			{
				if(r_RSetInlineRule_StyleSheet_StyleRule == null)
				{
					r_RSetInlineRule_StyleSheet_StyleRule = new(this, "SetInlineRule", 0, typeof(UnityEngine.UIElements.StyleSheet),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleRule"));
					r_RSetInlineRule_StyleSheet_StyleRule.SetBelong(this.instance);
				}
				return r_RSetInlineRule_StyleSheet_StyleRule;
			}
		}

		/// <summary>
		/// Boolean IsValueSet(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_RIsValueSet_StylePropertyId;
		public virtual RMethod RIsValueSet_StylePropertyId
		{
			get
			{
				if(r_RIsValueSet_StylePropertyId == null)
				{
					r_RIsValueSet_StylePropertyId = new(this, "IsValueSet", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_RIsValueSet_StylePropertyId.SetBelong(this.instance);
				}
				return r_RIsValueSet_StylePropertyId;
			}
		}

		/// <summary>
		/// Void ApplyInlineStyles(UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_RApplyInlineStyles_Ref_ComputedStyle;
		public virtual RMethod RApplyInlineStyles_Ref_ComputedStyle
		{
			get
			{
				if(r_RApplyInlineStyles_Ref_ComputedStyle == null)
				{
					r_RApplyInlineStyles_Ref_ComputedStyle = new(this, "ApplyInlineStyles", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_RApplyInlineStyles_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_RApplyInlineStyles_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[T] GetStyleList[T](UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_RGetStyleList_GT_StylePropertyId;
		public virtual RMethod RGetStyleList_GT_StylePropertyId
		{
			get
			{
				if(r_RGetStyleList_GT_StylePropertyId == null)
				{
					r_RGetStyleList_GT_StylePropertyId = new(this, "GetStyleList", 1,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_RGetStyleList_GT_StylePropertyId.SetBelong(this.instance);
				}
				return r_RGetStyleList_GT_StylePropertyId;
			}
		}

		/// <summary>
		/// Void SetStyleValueManaged(UnityEngine.UIElements.StyleSheets.StyleValueManaged)
		/// </summary>
		protected RMethod r_RSetStyleValueManaged_StyleValueManaged;
		public virtual RMethod RSetStyleValueManaged_StyleValueManaged
		{
			get
			{
				if(r_RSetStyleValueManaged_StyleValueManaged == null)
				{
					r_RSetStyleValueManaged_StyleValueManaged = new(this, "SetStyleValueManaged", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValueManaged"));
					r_RSetStyleValueManaged_StyleValueManaged.SetBelong(this.instance);
				}
				return r_RSetStyleValueManaged_StyleValueManaged;
			}
		}

		/// <summary>
		/// Boolean TryGetStyleValueManaged(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleSheets.StyleValueManaged ByRef)
		/// </summary>
		protected RMethod r_RTryGetStyleValueManaged_StylePropertyId_Ref_StyleValueManaged;
		public virtual RMethod RTryGetStyleValueManaged_StylePropertyId_Ref_StyleValueManaged
		{
			get
			{
				if(r_RTryGetStyleValueManaged_StylePropertyId_Ref_StyleValueManaged == null)
				{
					r_RTryGetStyleValueManaged_StylePropertyId_Ref_StyleValueManaged = new(this, "TryGetStyleValueManaged", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValueManaged").MakeByRefType());
					r_RTryGetStyleValueManaged_StylePropertyId_Ref_StyleValueManaged.SetBelong(this.instance);
				}
				return r_RTryGetStyleValueManaged_StylePropertyId_Ref_StyleValueManaged;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleBackgroundPosition)
		/// </summary>
		protected RMethod r_RSetStyleValue_StylePropertyId_StyleBackgroundPosition;
		public virtual RMethod RSetStyleValue_StylePropertyId_StyleBackgroundPosition
		{
			get
			{
				if(r_RSetStyleValue_StylePropertyId_StyleBackgroundPosition == null)
				{
					r_RSetStyleValue_StylePropertyId_StyleBackgroundPosition = new(this, "SetStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleBackgroundPosition));
					r_RSetStyleValue_StylePropertyId_StyleBackgroundPosition.SetBelong(this.instance);
				}
				return r_RSetStyleValue_StylePropertyId_StyleBackgroundPosition;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleBackgroundRepeat)
		/// </summary>
		protected RMethod r_RSetStyleValue_StylePropertyId_StyleBackgroundRepeat;
		public virtual RMethod RSetStyleValue_StylePropertyId_StyleBackgroundRepeat
		{
			get
			{
				if(r_RSetStyleValue_StylePropertyId_StyleBackgroundRepeat == null)
				{
					r_RSetStyleValue_StylePropertyId_StyleBackgroundRepeat = new(this, "SetStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleBackgroundRepeat));
					r_RSetStyleValue_StylePropertyId_StyleBackgroundRepeat.SetBelong(this.instance);
				}
				return r_RSetStyleValue_StylePropertyId_StyleBackgroundRepeat;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleLength)
		/// </summary>
		protected RMethod r_RSetStyleValue_StylePropertyId_StyleLength;
		public virtual RMethod RSetStyleValue_StylePropertyId_StyleLength
		{
			get
			{
				if(r_RSetStyleValue_StylePropertyId_StyleLength == null)
				{
					r_RSetStyleValue_StylePropertyId_StyleLength = new(this, "SetStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleLength));
					r_RSetStyleValue_StylePropertyId_StyleLength.SetBelong(this.instance);
				}
				return r_RSetStyleValue_StylePropertyId_StyleLength;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleFloat)
		/// </summary>
		protected RMethod r_RSetStyleValue_StylePropertyId_StyleFloat;
		public virtual RMethod RSetStyleValue_StylePropertyId_StyleFloat
		{
			get
			{
				if(r_RSetStyleValue_StylePropertyId_StyleFloat == null)
				{
					r_RSetStyleValue_StylePropertyId_StyleFloat = new(this, "SetStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleFloat));
					r_RSetStyleValue_StylePropertyId_StyleFloat.SetBelong(this.instance);
				}
				return r_RSetStyleValue_StylePropertyId_StyleFloat;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleInt)
		/// </summary>
		protected RMethod r_RSetStyleValue_StylePropertyId_StyleInt;
		public virtual RMethod RSetStyleValue_StylePropertyId_StyleInt
		{
			get
			{
				if(r_RSetStyleValue_StylePropertyId_StyleInt == null)
				{
					r_RSetStyleValue_StylePropertyId_StyleInt = new(this, "SetStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleInt));
					r_RSetStyleValue_StylePropertyId_StyleInt.SetBelong(this.instance);
				}
				return r_RSetStyleValue_StylePropertyId_StyleInt;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleColor)
		/// </summary>
		protected RMethod r_RSetStyleValue_StylePropertyId_StyleColor;
		public virtual RMethod RSetStyleValue_StylePropertyId_StyleColor
		{
			get
			{
				if(r_RSetStyleValue_StylePropertyId_StyleColor == null)
				{
					r_RSetStyleValue_StylePropertyId_StyleColor = new(this, "SetStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleColor));
					r_RSetStyleValue_StylePropertyId_StyleColor.SetBelong(this.instance);
				}
				return r_RSetStyleValue_StylePropertyId_StyleColor;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue[T](UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleEnum`1[T])
		/// </summary>
		protected RMethod r_RSetStyleValue_GT_StylePropertyId_StyleEnum_d_T_p_;
		public virtual RMethod RSetStyleValue_GT_StylePropertyId_StyleEnum_d_T_p_
		{
			get
			{
				if(r_RSetStyleValue_GT_StylePropertyId_StyleEnum_d_T_p_ == null)
				{
					r_RSetStyleValue_GT_StylePropertyId_StyleEnum_d_T_p_ = new(this, "SetStyleValue", 1,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleEnum<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RSetStyleValue_GT_StylePropertyId_StyleEnum_d_T_p_.SetBelong(this.instance);
				}
				return r_RSetStyleValue_GT_StylePropertyId_StyleEnum_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleBackground)
		/// </summary>
		protected RMethod r_RSetStyleValue_StylePropertyId_StyleBackground;
		public virtual RMethod RSetStyleValue_StylePropertyId_StyleBackground
		{
			get
			{
				if(r_RSetStyleValue_StylePropertyId_StyleBackground == null)
				{
					r_RSetStyleValue_StylePropertyId_StyleBackground = new(this, "SetStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleBackground));
					r_RSetStyleValue_StylePropertyId_StyleBackground.SetBelong(this.instance);
				}
				return r_RSetStyleValue_StylePropertyId_StyleBackground;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleFontDefinition)
		/// </summary>
		protected RMethod r_RSetStyleValue_StylePropertyId_StyleFontDefinition;
		public virtual RMethod RSetStyleValue_StylePropertyId_StyleFontDefinition
		{
			get
			{
				if(r_RSetStyleValue_StylePropertyId_StyleFontDefinition == null)
				{
					r_RSetStyleValue_StylePropertyId_StyleFontDefinition = new(this, "SetStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleFontDefinition));
					r_RSetStyleValue_StylePropertyId_StyleFontDefinition.SetBelong(this.instance);
				}
				return r_RSetStyleValue_StylePropertyId_StyleFontDefinition;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleFont)
		/// </summary>
		protected RMethod r_RSetStyleValue_StylePropertyId_StyleFont;
		public virtual RMethod RSetStyleValue_StylePropertyId_StyleFont
		{
			get
			{
				if(r_RSetStyleValue_StylePropertyId_StyleFont == null)
				{
					r_RSetStyleValue_StylePropertyId_StyleFont = new(this, "SetStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleFont));
					r_RSetStyleValue_StylePropertyId_StyleFont.SetBelong(this.instance);
				}
				return r_RSetStyleValue_StylePropertyId_StyleFont;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue[T](UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleList`1[T])
		/// </summary>
		protected RMethod r_RSetStyleValue_GT_StylePropertyId_StyleList_d_T_p_;
		public virtual RMethod RSetStyleValue_GT_StylePropertyId_StyleList_d_T_p_
		{
			get
			{
				if(r_RSetStyleValue_GT_StylePropertyId_StyleList_d_T_p_ == null)
				{
					r_RSetStyleValue_GT_StylePropertyId_StyleList_d_T_p_ = new(this, "SetStyleValue", 1,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleList<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RSetStyleValue_GT_StylePropertyId_StyleList_d_T_p_.SetBelong(this.instance);
				}
				return r_RSetStyleValue_GT_StylePropertyId_StyleList_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean SetInlineCursor(UnityEngine.UIElements.StyleCursor)
		/// </summary>
		protected RMethod r_RSetInlineCursor_StyleCursor;
		public virtual RMethod RSetInlineCursor_StyleCursor
		{
			get
			{
				if(r_RSetInlineCursor_StyleCursor == null)
				{
					r_RSetInlineCursor_StyleCursor = new(this, "SetInlineCursor", 0, typeof(UnityEngine.UIElements.StyleCursor));
					r_RSetInlineCursor_StyleCursor.SetBelong(this.instance);
				}
				return r_RSetInlineCursor_StyleCursor;
			}
		}

		/// <summary>
		/// Void ApplyStyleCursor(UnityEngine.UIElements.StyleCursor)
		/// </summary>
		protected RMethod r_RApplyStyleCursor_StyleCursor;
		public virtual RMethod RApplyStyleCursor_StyleCursor
		{
			get
			{
				if(r_RApplyStyleCursor_StyleCursor == null)
				{
					r_RApplyStyleCursor_StyleCursor = new(this, "ApplyStyleCursor", 0, typeof(UnityEngine.UIElements.StyleCursor));
					r_RApplyStyleCursor_StyleCursor.SetBelong(this.instance);
				}
				return r_RApplyStyleCursor_StyleCursor;
			}
		}

		/// <summary>
		/// Boolean SetInlineTextShadow(UnityEngine.UIElements.StyleTextShadow)
		/// </summary>
		protected RMethod r_RSetInlineTextShadow_StyleTextShadow;
		public virtual RMethod RSetInlineTextShadow_StyleTextShadow
		{
			get
			{
				if(r_RSetInlineTextShadow_StyleTextShadow == null)
				{
					r_RSetInlineTextShadow_StyleTextShadow = new(this, "SetInlineTextShadow", 0, typeof(UnityEngine.UIElements.StyleTextShadow));
					r_RSetInlineTextShadow_StyleTextShadow.SetBelong(this.instance);
				}
				return r_RSetInlineTextShadow_StyleTextShadow;
			}
		}

		/// <summary>
		/// Void ApplyStyleTextShadow(UnityEngine.UIElements.StyleTextShadow)
		/// </summary>
		protected RMethod r_RApplyStyleTextShadow_StyleTextShadow;
		public virtual RMethod RApplyStyleTextShadow_StyleTextShadow
		{
			get
			{
				if(r_RApplyStyleTextShadow_StyleTextShadow == null)
				{
					r_RApplyStyleTextShadow_StyleTextShadow = new(this, "ApplyStyleTextShadow", 0, typeof(UnityEngine.UIElements.StyleTextShadow));
					r_RApplyStyleTextShadow_StyleTextShadow.SetBelong(this.instance);
				}
				return r_RApplyStyleTextShadow_StyleTextShadow;
			}
		}

		/// <summary>
		/// Boolean SetInlineTransformOrigin(UnityEngine.UIElements.StyleTransformOrigin)
		/// </summary>
		protected RMethod r_RSetInlineTransformOrigin_StyleTransformOrigin;
		public virtual RMethod RSetInlineTransformOrigin_StyleTransformOrigin
		{
			get
			{
				if(r_RSetInlineTransformOrigin_StyleTransformOrigin == null)
				{
					r_RSetInlineTransformOrigin_StyleTransformOrigin = new(this, "SetInlineTransformOrigin", 0, typeof(UnityEngine.UIElements.StyleTransformOrigin));
					r_RSetInlineTransformOrigin_StyleTransformOrigin.SetBelong(this.instance);
				}
				return r_RSetInlineTransformOrigin_StyleTransformOrigin;
			}
		}

		/// <summary>
		/// Void ApplyStyleTransformOrigin(UnityEngine.UIElements.StyleTransformOrigin)
		/// </summary>
		protected RMethod r_RApplyStyleTransformOrigin_StyleTransformOrigin;
		public virtual RMethod RApplyStyleTransformOrigin_StyleTransformOrigin
		{
			get
			{
				if(r_RApplyStyleTransformOrigin_StyleTransformOrigin == null)
				{
					r_RApplyStyleTransformOrigin_StyleTransformOrigin = new(this, "ApplyStyleTransformOrigin", 0, typeof(UnityEngine.UIElements.StyleTransformOrigin));
					r_RApplyStyleTransformOrigin_StyleTransformOrigin.SetBelong(this.instance);
				}
				return r_RApplyStyleTransformOrigin_StyleTransformOrigin;
			}
		}

		/// <summary>
		/// Boolean SetInlineTranslate(UnityEngine.UIElements.StyleTranslate)
		/// </summary>
		protected RMethod r_RSetInlineTranslate_StyleTranslate;
		public virtual RMethod RSetInlineTranslate_StyleTranslate
		{
			get
			{
				if(r_RSetInlineTranslate_StyleTranslate == null)
				{
					r_RSetInlineTranslate_StyleTranslate = new(this, "SetInlineTranslate", 0, typeof(UnityEngine.UIElements.StyleTranslate));
					r_RSetInlineTranslate_StyleTranslate.SetBelong(this.instance);
				}
				return r_RSetInlineTranslate_StyleTranslate;
			}
		}

		/// <summary>
		/// Void ApplyStyleTranslate(UnityEngine.UIElements.StyleTranslate)
		/// </summary>
		protected RMethod r_RApplyStyleTranslate_StyleTranslate;
		public virtual RMethod RApplyStyleTranslate_StyleTranslate
		{
			get
			{
				if(r_RApplyStyleTranslate_StyleTranslate == null)
				{
					r_RApplyStyleTranslate_StyleTranslate = new(this, "ApplyStyleTranslate", 0, typeof(UnityEngine.UIElements.StyleTranslate));
					r_RApplyStyleTranslate_StyleTranslate.SetBelong(this.instance);
				}
				return r_RApplyStyleTranslate_StyleTranslate;
			}
		}

		/// <summary>
		/// Boolean SetInlineScale(UnityEngine.UIElements.StyleScale)
		/// </summary>
		protected RMethod r_RSetInlineScale_StyleScale;
		public virtual RMethod RSetInlineScale_StyleScale
		{
			get
			{
				if(r_RSetInlineScale_StyleScale == null)
				{
					r_RSetInlineScale_StyleScale = new(this, "SetInlineScale", 0, typeof(UnityEngine.UIElements.StyleScale));
					r_RSetInlineScale_StyleScale.SetBelong(this.instance);
				}
				return r_RSetInlineScale_StyleScale;
			}
		}

		/// <summary>
		/// Void ApplyStyleScale(UnityEngine.UIElements.StyleScale)
		/// </summary>
		protected RMethod r_RApplyStyleScale_StyleScale;
		public virtual RMethod RApplyStyleScale_StyleScale
		{
			get
			{
				if(r_RApplyStyleScale_StyleScale == null)
				{
					r_RApplyStyleScale_StyleScale = new(this, "ApplyStyleScale", 0, typeof(UnityEngine.UIElements.StyleScale));
					r_RApplyStyleScale_StyleScale.SetBelong(this.instance);
				}
				return r_RApplyStyleScale_StyleScale;
			}
		}

		/// <summary>
		/// Boolean SetInlineRotate(UnityEngine.UIElements.StyleRotate)
		/// </summary>
		protected RMethod r_RSetInlineRotate_StyleRotate;
		public virtual RMethod RSetInlineRotate_StyleRotate
		{
			get
			{
				if(r_RSetInlineRotate_StyleRotate == null)
				{
					r_RSetInlineRotate_StyleRotate = new(this, "SetInlineRotate", 0, typeof(UnityEngine.UIElements.StyleRotate));
					r_RSetInlineRotate_StyleRotate.SetBelong(this.instance);
				}
				return r_RSetInlineRotate_StyleRotate;
			}
		}

		/// <summary>
		/// Void ApplyStyleRotate(UnityEngine.UIElements.StyleRotate)
		/// </summary>
		protected RMethod r_RApplyStyleRotate_StyleRotate;
		public virtual RMethod RApplyStyleRotate_StyleRotate
		{
			get
			{
				if(r_RApplyStyleRotate_StyleRotate == null)
				{
					r_RApplyStyleRotate_StyleRotate = new(this, "ApplyStyleRotate", 0, typeof(UnityEngine.UIElements.StyleRotate));
					r_RApplyStyleRotate_StyleRotate.SetBelong(this.instance);
				}
				return r_RApplyStyleRotate_StyleRotate;
			}
		}

		/// <summary>
		/// Boolean SetInlineBackgroundSize(UnityEngine.UIElements.StyleBackgroundSize)
		/// </summary>
		protected RMethod r_RSetInlineBackgroundSize_StyleBackgroundSize;
		public virtual RMethod RSetInlineBackgroundSize_StyleBackgroundSize
		{
			get
			{
				if(r_RSetInlineBackgroundSize_StyleBackgroundSize == null)
				{
					r_RSetInlineBackgroundSize_StyleBackgroundSize = new(this, "SetInlineBackgroundSize", 0, typeof(UnityEngine.UIElements.StyleBackgroundSize));
					r_RSetInlineBackgroundSize_StyleBackgroundSize.SetBelong(this.instance);
				}
				return r_RSetInlineBackgroundSize_StyleBackgroundSize;
			}
		}

		/// <summary>
		/// Void ApplyStyleBackgroundSize(UnityEngine.UIElements.StyleBackgroundSize)
		/// </summary>
		protected RMethod r_RApplyStyleBackgroundSize_StyleBackgroundSize;
		public virtual RMethod RApplyStyleBackgroundSize_StyleBackgroundSize
		{
			get
			{
				if(r_RApplyStyleBackgroundSize_StyleBackgroundSize == null)
				{
					r_RApplyStyleBackgroundSize_StyleBackgroundSize = new(this, "ApplyStyleBackgroundSize", 0, typeof(UnityEngine.UIElements.StyleBackgroundSize));
					r_RApplyStyleBackgroundSize_StyleBackgroundSize.SetBelong(this.instance);
				}
				return r_RApplyStyleBackgroundSize_StyleBackgroundSize;
			}
		}

		/// <summary>
		/// Void ApplyStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue)
		/// </summary>
		protected RMethod r_RApplyStyleValue_StyleValue;
		public virtual RMethod RApplyStyleValue_StyleValue
		{
			get
			{
				if(r_RApplyStyleValue_StyleValue == null)
				{
					r_RApplyStyleValue_StyleValue = new(this, "ApplyStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValue"));
					r_RApplyStyleValue_StyleValue.SetBelong(this.instance);
				}
				return r_RApplyStyleValue_StyleValue;
			}
		}

		/// <summary>
		/// Void ApplyStyleValue(UnityEngine.UIElements.StyleSheets.StyleValueManaged)
		/// </summary>
		protected RMethod r_RApplyStyleValue_StyleValueManaged;
		public virtual RMethod RApplyStyleValue_StyleValueManaged
		{
			get
			{
				if(r_RApplyStyleValue_StyleValueManaged == null)
				{
					r_RApplyStyleValue_StyleValueManaged = new(this, "ApplyStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValueManaged"));
					r_RApplyStyleValue_StyleValueManaged.SetBelong(this.instance);
				}
				return r_RApplyStyleValue_StyleValueManaged;
			}
		}

		/// <summary>
		/// Boolean RemoveInlineStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_RRemoveInlineStyle_StylePropertyId;
		public virtual RMethod RRemoveInlineStyle_StylePropertyId
		{
			get
			{
				if(r_RRemoveInlineStyle_StylePropertyId == null)
				{
					r_RRemoveInlineStyle_StylePropertyId = new(this, "RemoveInlineStyle", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_RRemoveInlineStyle_StylePropertyId.SetBelong(this.instance);
				}
				return r_RRemoveInlineStyle_StylePropertyId;
			}
		}

		/// <summary>
		/// Void ApplyFromComputedStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_RApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle;
		public virtual RMethod RApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle
		{
			get
			{
				if(r_RApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle == null)
				{
					r_RApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle = new(this, "ApplyFromComputedStyle", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"),  ReleactionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_RApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_RApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Boolean TryGetInlineCursor(UnityEngine.UIElements.StyleCursor ByRef)
		/// </summary>
		protected RMethod r_RTryGetInlineCursor_Ref_StyleCursor;
		public virtual RMethod RTryGetInlineCursor_Ref_StyleCursor
		{
			get
			{
				if(r_RTryGetInlineCursor_Ref_StyleCursor == null)
				{
					r_RTryGetInlineCursor_Ref_StyleCursor = new(this, "TryGetInlineCursor", 0, typeof(UnityEngine.UIElements.StyleCursor).MakeByRefType());
					r_RTryGetInlineCursor_Ref_StyleCursor.SetBelong(this.instance);
				}
				return r_RTryGetInlineCursor_Ref_StyleCursor;
			}
		}

		/// <summary>
		/// Boolean TryGetInlineTextShadow(UnityEngine.UIElements.StyleTextShadow ByRef)
		/// </summary>
		protected RMethod r_RTryGetInlineTextShadow_Ref_StyleTextShadow;
		public virtual RMethod RTryGetInlineTextShadow_Ref_StyleTextShadow
		{
			get
			{
				if(r_RTryGetInlineTextShadow_Ref_StyleTextShadow == null)
				{
					r_RTryGetInlineTextShadow_Ref_StyleTextShadow = new(this, "TryGetInlineTextShadow", 0, typeof(UnityEngine.UIElements.StyleTextShadow).MakeByRefType());
					r_RTryGetInlineTextShadow_Ref_StyleTextShadow.SetBelong(this.instance);
				}
				return r_RTryGetInlineTextShadow_Ref_StyleTextShadow;
			}
		}

		/// <summary>
		/// Boolean TryGetInlineTransformOrigin(UnityEngine.UIElements.StyleTransformOrigin ByRef)
		/// </summary>
		protected RMethod r_RTryGetInlineTransformOrigin_Ref_StyleTransformOrigin;
		public virtual RMethod RTryGetInlineTransformOrigin_Ref_StyleTransformOrigin
		{
			get
			{
				if(r_RTryGetInlineTransformOrigin_Ref_StyleTransformOrigin == null)
				{
					r_RTryGetInlineTransformOrigin_Ref_StyleTransformOrigin = new(this, "TryGetInlineTransformOrigin", 0, typeof(UnityEngine.UIElements.StyleTransformOrigin).MakeByRefType());
					r_RTryGetInlineTransformOrigin_Ref_StyleTransformOrigin.SetBelong(this.instance);
				}
				return r_RTryGetInlineTransformOrigin_Ref_StyleTransformOrigin;
			}
		}

		/// <summary>
		/// Boolean TryGetInlineTranslate(UnityEngine.UIElements.StyleTranslate ByRef)
		/// </summary>
		protected RMethod r_RTryGetInlineTranslate_Ref_StyleTranslate;
		public virtual RMethod RTryGetInlineTranslate_Ref_StyleTranslate
		{
			get
			{
				if(r_RTryGetInlineTranslate_Ref_StyleTranslate == null)
				{
					r_RTryGetInlineTranslate_Ref_StyleTranslate = new(this, "TryGetInlineTranslate", 0, typeof(UnityEngine.UIElements.StyleTranslate).MakeByRefType());
					r_RTryGetInlineTranslate_Ref_StyleTranslate.SetBelong(this.instance);
				}
				return r_RTryGetInlineTranslate_Ref_StyleTranslate;
			}
		}

		/// <summary>
		/// Boolean TryGetInlineRotate(UnityEngine.UIElements.StyleRotate ByRef)
		/// </summary>
		protected RMethod r_RTryGetInlineRotate_Ref_StyleRotate;
		public virtual RMethod RTryGetInlineRotate_Ref_StyleRotate
		{
			get
			{
				if(r_RTryGetInlineRotate_Ref_StyleRotate == null)
				{
					r_RTryGetInlineRotate_Ref_StyleRotate = new(this, "TryGetInlineRotate", 0, typeof(UnityEngine.UIElements.StyleRotate).MakeByRefType());
					r_RTryGetInlineRotate_Ref_StyleRotate.SetBelong(this.instance);
				}
				return r_RTryGetInlineRotate_Ref_StyleRotate;
			}
		}

		/// <summary>
		/// Boolean TryGetInlineScale(UnityEngine.UIElements.StyleScale ByRef)
		/// </summary>
		protected RMethod r_RTryGetInlineScale_Ref_StyleScale;
		public virtual RMethod RTryGetInlineScale_Ref_StyleScale
		{
			get
			{
				if(r_RTryGetInlineScale_Ref_StyleScale == null)
				{
					r_RTryGetInlineScale_Ref_StyleScale = new(this, "TryGetInlineScale", 0, typeof(UnityEngine.UIElements.StyleScale).MakeByRefType());
					r_RTryGetInlineScale_Ref_StyleScale.SetBelong(this.instance);
				}
				return r_RTryGetInlineScale_Ref_StyleScale;
			}
		}

		/// <summary>
		/// Boolean TryGetInlineBackgroundSize(UnityEngine.UIElements.StyleBackgroundSize ByRef)
		/// </summary>
		protected RMethod r_RTryGetInlineBackgroundSize_Ref_StyleBackgroundSize;
		public virtual RMethod RTryGetInlineBackgroundSize_Ref_StyleBackgroundSize
		{
			get
			{
				if(r_RTryGetInlineBackgroundSize_Ref_StyleBackgroundSize == null)
				{
					r_RTryGetInlineBackgroundSize_Ref_StyleBackgroundSize = new(this, "TryGetInlineBackgroundSize", 0, typeof(UnityEngine.UIElements.StyleBackgroundSize).MakeByRefType());
					r_RTryGetInlineBackgroundSize_Ref_StyleBackgroundSize.SetBelong(this.instance);
				}
				return r_RTryGetInlineBackgroundSize_Ref_StyleBackgroundSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_RGetStyleLength_StylePropertyId;
		public virtual RMethod RGetStyleLength_StylePropertyId
		{
			get
			{
				if(r_RGetStyleLength_StylePropertyId == null)
				{
					r_RGetStyleLength_StylePropertyId = new(this, "GetStyleLength", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_RGetStyleLength_StylePropertyId.SetBelong(this.instance);
				}
				return r_RGetStyleLength_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_RGetStyleFloat_StylePropertyId;
		public virtual RMethod RGetStyleFloat_StylePropertyId
		{
			get
			{
				if(r_RGetStyleFloat_StylePropertyId == null)
				{
					r_RGetStyleFloat_StylePropertyId = new(this, "GetStyleFloat", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_RGetStyleFloat_StylePropertyId.SetBelong(this.instance);
				}
				return r_RGetStyleFloat_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_RGetStyleInt_StylePropertyId;
		public virtual RMethod RGetStyleInt_StylePropertyId
		{
			get
			{
				if(r_RGetStyleInt_StylePropertyId == null)
				{
					r_RGetStyleInt_StylePropertyId = new(this, "GetStyleInt", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_RGetStyleInt_StylePropertyId.SetBelong(this.instance);
				}
				return r_RGetStyleInt_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_RGetStyleColor_StylePropertyId;
		public virtual RMethod RGetStyleColor_StylePropertyId
		{
			get
			{
				if(r_RGetStyleColor_StylePropertyId == null)
				{
					r_RGetStyleColor_StylePropertyId = new(this, "GetStyleColor", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_RGetStyleColor_StylePropertyId.SetBelong(this.instance);
				}
				return r_RGetStyleColor_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackground GetStyleBackground(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_RGetStyleBackground_StylePropertyId;
		public virtual RMethod RGetStyleBackground_StylePropertyId
		{
			get
			{
				if(r_RGetStyleBackground_StylePropertyId == null)
				{
					r_RGetStyleBackground_StylePropertyId = new(this, "GetStyleBackground", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_RGetStyleBackground_StylePropertyId.SetBelong(this.instance);
				}
				return r_RGetStyleBackground_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundPosition GetStyleBackgroundPosition(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_RGetStyleBackgroundPosition_StylePropertyId;
		public virtual RMethod RGetStyleBackgroundPosition_StylePropertyId
		{
			get
			{
				if(r_RGetStyleBackgroundPosition_StylePropertyId == null)
				{
					r_RGetStyleBackgroundPosition_StylePropertyId = new(this, "GetStyleBackgroundPosition", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_RGetStyleBackgroundPosition_StylePropertyId.SetBelong(this.instance);
				}
				return r_RGetStyleBackgroundPosition_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundRepeat GetStyleBackgroundRepeat(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_RGetStyleBackgroundRepeat_StylePropertyId;
		public virtual RMethod RGetStyleBackgroundRepeat_StylePropertyId
		{
			get
			{
				if(r_RGetStyleBackgroundRepeat_StylePropertyId == null)
				{
					r_RGetStyleBackgroundRepeat_StylePropertyId = new(this, "GetStyleBackgroundRepeat", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_RGetStyleBackgroundRepeat_StylePropertyId.SetBelong(this.instance);
				}
				return r_RGetStyleBackgroundRepeat_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFont GetStyleFont(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_RGetStyleFont_StylePropertyId;
		public virtual RMethod RGetStyleFont_StylePropertyId
		{
			get
			{
				if(r_RGetStyleFont_StylePropertyId == null)
				{
					r_RGetStyleFont_StylePropertyId = new(this, "GetStyleFont", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_RGetStyleFont_StylePropertyId.SetBelong(this.instance);
				}
				return r_RGetStyleFont_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFontDefinition GetStyleFontDefinition(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_RGetStyleFontDefinition_StylePropertyId;
		public virtual RMethod RGetStyleFontDefinition_StylePropertyId
		{
			get
			{
				if(r_RGetStyleFontDefinition_StylePropertyId == null)
				{
					r_RGetStyleFontDefinition_StylePropertyId = new(this, "GetStyleFontDefinition", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_RGetStyleFontDefinition_StylePropertyId.SetBelong(this.instance);
				}
				return r_RGetStyleFontDefinition_StylePropertyId;
			}
		}

		/// <summary>
		/// Boolean TryGetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleSheets.StyleValue ByRef)
		/// </summary>
		protected RMethod r_RTryGetStyleValue_StylePropertyId_Ref_StyleValue;
		public virtual RMethod RTryGetStyleValue_StylePropertyId_Ref_StyleValue
		{
			get
			{
				if(r_RTryGetStyleValue_StylePropertyId_Ref_StyleValue == null)
				{
					r_RTryGetStyleValue_StylePropertyId_Ref_StyleValue = new(this, "TryGetStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValue").MakeByRefType());
					r_RTryGetStyleValue_StylePropertyId_Ref_StyleValue.SetBelong(this.instance);
				}
				return r_RTryGetStyleValue_StylePropertyId_Ref_StyleValue;
			}
		}

		/// <summary>
		/// Void SetStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue)
		/// </summary>
		protected RMethod r_RSetStyleValue_StyleValue;
		public virtual RMethod RSetStyleValue_StyleValue
		{
			get
			{
				if(r_RSetStyleValue_StyleValue == null)
				{
					r_RSetStyleValue_StyleValue = new(this, "SetStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValue"));
					r_RSetStyleValue_StyleValue.SetBelong(this.instance);
				}
				return r_RSetStyleValue_StyleValue;
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


        public RInlineStyleAccess() : base("UnityEngine.UIElements.InlineStyleAccess")
        {
        }

        public RInlineStyleAccess(System.Object instance) : base("UnityEngine.UIElements.InlineStyleAccess")
		{
            SetInstance(instance);
		}

        public RInlineStyleAccess(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RInlineStyleAccess(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }



















        public virtual System.Boolean SetInlineCursor(UnityEngine.UIElements.StyleCursor  @inlineValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inlineValue};
            var ___result = RSetInlineCursor_StyleCursor.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ApplyStyleCursor(UnityEngine.UIElements.StyleCursor  @cursor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cursor};
            var ___result = RApplyStyleCursor_StyleCursor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SetInlineTextShadow(UnityEngine.UIElements.StyleTextShadow  @inlineValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inlineValue};
            var ___result = RSetInlineTextShadow_StyleTextShadow.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ApplyStyleTextShadow(UnityEngine.UIElements.StyleTextShadow  @textShadow)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textShadow};
            var ___result = RApplyStyleTextShadow_StyleTextShadow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SetInlineTransformOrigin(UnityEngine.UIElements.StyleTransformOrigin  @inlineValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inlineValue};
            var ___result = RSetInlineTransformOrigin_StyleTransformOrigin.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ApplyStyleTransformOrigin(UnityEngine.UIElements.StyleTransformOrigin  @transformOrigin)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@transformOrigin};
            var ___result = RApplyStyleTransformOrigin_StyleTransformOrigin.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SetInlineTranslate(UnityEngine.UIElements.StyleTranslate  @inlineValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inlineValue};
            var ___result = RSetInlineTranslate_StyleTranslate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ApplyStyleTranslate(UnityEngine.UIElements.StyleTranslate  @translate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@translate};
            var ___result = RApplyStyleTranslate_StyleTranslate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SetInlineScale(UnityEngine.UIElements.StyleScale  @inlineValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inlineValue};
            var ___result = RSetInlineScale_StyleScale.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ApplyStyleScale(UnityEngine.UIElements.StyleScale  @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scale};
            var ___result = RApplyStyleScale_StyleScale.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SetInlineRotate(UnityEngine.UIElements.StyleRotate  @inlineValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inlineValue};
            var ___result = RSetInlineRotate_StyleRotate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ApplyStyleRotate(UnityEngine.UIElements.StyleRotate  @rotate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rotate};
            var ___result = RApplyStyleRotate_StyleRotate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SetInlineBackgroundSize(UnityEngine.UIElements.StyleBackgroundSize  @inlineValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inlineValue};
            var ___result = RSetInlineBackgroundSize_StyleBackgroundSize.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ApplyStyleBackgroundSize(UnityEngine.UIElements.StyleBackgroundSize  @backgroundSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@backgroundSize};
            var ___result = RApplyStyleBackgroundSize_StyleBackgroundSize.Invoke(___genericsType, ___parameters);

            
        }






        public virtual System.Boolean TryGetInlineCursor(ref UnityEngine.UIElements.StyleCursor  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RTryGetInlineCursor_Ref_StyleCursor.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.UIElements.StyleCursor)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetInlineTextShadow(ref UnityEngine.UIElements.StyleTextShadow  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RTryGetInlineTextShadow_Ref_StyleTextShadow.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.UIElements.StyleTextShadow)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetInlineTransformOrigin(ref UnityEngine.UIElements.StyleTransformOrigin  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RTryGetInlineTransformOrigin_Ref_StyleTransformOrigin.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.UIElements.StyleTransformOrigin)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetInlineTranslate(ref UnityEngine.UIElements.StyleTranslate  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RTryGetInlineTranslate_Ref_StyleTranslate.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.UIElements.StyleTranslate)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetInlineRotate(ref UnityEngine.UIElements.StyleRotate  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RTryGetInlineRotate_Ref_StyleRotate.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.UIElements.StyleRotate)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetInlineScale(ref UnityEngine.UIElements.StyleScale  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RTryGetInlineScale_Ref_StyleScale.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.UIElements.StyleScale)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetInlineBackgroundSize(ref UnityEngine.UIElements.StyleBackgroundSize  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RTryGetInlineBackgroundSize_Ref_StyleBackgroundSize.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.UIElements.StyleBackgroundSize)___parameters[0];

            return (System.Boolean)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
