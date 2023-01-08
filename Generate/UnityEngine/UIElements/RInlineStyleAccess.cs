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
		protected RUnityEngine.RUIElements.RVisualElement r___0__ve__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RVisualElement R__0__ve__1__k__BackingField
		{
			get
			{
				if(r___0__ve__1__k__BackingField == null)
				{
					r___0__ve__1__k__BackingField = new(this, "<ve>k__BackingField");
					r___0__ve__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__ve__1__k__BackingField;
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
		protected RProperty r_UnityEngine__2__UIElements__2__IStyle__2__alignContent;
		public virtual RProperty RUnityEngine__2__UIElements__2__IStyle__2__alignContent
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__alignContent == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__alignContent = new(this, "UnityEngine.UIElements.IStyle.alignContent", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__alignContent.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__alignContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Align] UnityEngine.UIElements.IStyle.alignItems
		/// </summary>
		protected RProperty r_UnityEngine__2__UIElements__2__IStyle__2__alignItems;
		public virtual RProperty RUnityEngine__2__UIElements__2__IStyle__2__alignItems
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__alignItems == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__alignItems = new(this, "UnityEngine.UIElements.IStyle.alignItems", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__alignItems.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__alignItems;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Align] UnityEngine.UIElements.IStyle.alignSelf
		/// </summary>
		protected RProperty r_UnityEngine__2__UIElements__2__IStyle__2__alignSelf;
		public virtual RProperty RUnityEngine__2__UIElements__2__IStyle__2__alignSelf
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__alignSelf == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__alignSelf = new(this, "UnityEngine.UIElements.IStyle.alignSelf", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__alignSelf.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__alignSelf;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor UnityEngine.UIElements.IStyle.backgroundColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_UnityEngine__2__UIElements__2__IStyle__2__backgroundColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RUnityEngine__2__UIElements__2__IStyle__2__backgroundColor
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__backgroundColor == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__backgroundColor = new(this, "UnityEngine.UIElements.IStyle.backgroundColor", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__backgroundColor.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__backgroundColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackground UnityEngine.UIElements.IStyle.backgroundImage
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleBackground r_UnityEngine__2__UIElements__2__IStyle__2__backgroundImage;
		public virtual RUnityEngine.RUIElements.RStyleBackground RUnityEngine__2__UIElements__2__IStyle__2__backgroundImage
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__backgroundImage == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__backgroundImage = new(this, "UnityEngine.UIElements.IStyle.backgroundImage", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__backgroundImage.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__backgroundImage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundPosition UnityEngine.UIElements.IStyle.backgroundPositionX
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleBackgroundPosition r_UnityEngine__2__UIElements__2__IStyle__2__backgroundPositionX;
		public virtual RUnityEngine.RUIElements.RStyleBackgroundPosition RUnityEngine__2__UIElements__2__IStyle__2__backgroundPositionX
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__backgroundPositionX == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__backgroundPositionX = new(this, "UnityEngine.UIElements.IStyle.backgroundPositionX", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__backgroundPositionX.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__backgroundPositionX;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundPosition UnityEngine.UIElements.IStyle.backgroundPositionY
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleBackgroundPosition r_UnityEngine__2__UIElements__2__IStyle__2__backgroundPositionY;
		public virtual RUnityEngine.RUIElements.RStyleBackgroundPosition RUnityEngine__2__UIElements__2__IStyle__2__backgroundPositionY
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__backgroundPositionY == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__backgroundPositionY = new(this, "UnityEngine.UIElements.IStyle.backgroundPositionY", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__backgroundPositionY.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__backgroundPositionY;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundRepeat UnityEngine.UIElements.IStyle.backgroundRepeat
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleBackgroundRepeat r_UnityEngine__2__UIElements__2__IStyle__2__backgroundRepeat;
		public virtual RUnityEngine.RUIElements.RStyleBackgroundRepeat RUnityEngine__2__UIElements__2__IStyle__2__backgroundRepeat
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__backgroundRepeat == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__backgroundRepeat = new(this, "UnityEngine.UIElements.IStyle.backgroundRepeat", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__backgroundRepeat.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__backgroundRepeat;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor UnityEngine.UIElements.IStyle.borderBottomColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_UnityEngine__2__UIElements__2__IStyle__2__borderBottomColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RUnityEngine__2__UIElements__2__IStyle__2__borderBottomColor
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__borderBottomColor == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__borderBottomColor = new(this, "UnityEngine.UIElements.IStyle.borderBottomColor", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__borderBottomColor.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__borderBottomColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.borderBottomLeftRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__borderBottomLeftRadius;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__borderBottomLeftRadius
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__borderBottomLeftRadius == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__borderBottomLeftRadius = new(this, "UnityEngine.UIElements.IStyle.borderBottomLeftRadius", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__borderBottomLeftRadius.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__borderBottomLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.borderBottomRightRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__borderBottomRightRadius;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__borderBottomRightRadius
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__borderBottomRightRadius == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__borderBottomRightRadius = new(this, "UnityEngine.UIElements.IStyle.borderBottomRightRadius", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__borderBottomRightRadius.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__borderBottomRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.borderBottomWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_UnityEngine__2__UIElements__2__IStyle__2__borderBottomWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RUnityEngine__2__UIElements__2__IStyle__2__borderBottomWidth
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__borderBottomWidth == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__borderBottomWidth = new(this, "UnityEngine.UIElements.IStyle.borderBottomWidth", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__borderBottomWidth.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__borderBottomWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor UnityEngine.UIElements.IStyle.borderLeftColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_UnityEngine__2__UIElements__2__IStyle__2__borderLeftColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RUnityEngine__2__UIElements__2__IStyle__2__borderLeftColor
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__borderLeftColor == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__borderLeftColor = new(this, "UnityEngine.UIElements.IStyle.borderLeftColor", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__borderLeftColor.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__borderLeftColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.borderLeftWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_UnityEngine__2__UIElements__2__IStyle__2__borderLeftWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RUnityEngine__2__UIElements__2__IStyle__2__borderLeftWidth
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__borderLeftWidth == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__borderLeftWidth = new(this, "UnityEngine.UIElements.IStyle.borderLeftWidth", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__borderLeftWidth.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__borderLeftWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor UnityEngine.UIElements.IStyle.borderRightColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_UnityEngine__2__UIElements__2__IStyle__2__borderRightColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RUnityEngine__2__UIElements__2__IStyle__2__borderRightColor
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__borderRightColor == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__borderRightColor = new(this, "UnityEngine.UIElements.IStyle.borderRightColor", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__borderRightColor.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__borderRightColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.borderRightWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_UnityEngine__2__UIElements__2__IStyle__2__borderRightWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RUnityEngine__2__UIElements__2__IStyle__2__borderRightWidth
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__borderRightWidth == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__borderRightWidth = new(this, "UnityEngine.UIElements.IStyle.borderRightWidth", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__borderRightWidth.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__borderRightWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor UnityEngine.UIElements.IStyle.borderTopColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_UnityEngine__2__UIElements__2__IStyle__2__borderTopColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RUnityEngine__2__UIElements__2__IStyle__2__borderTopColor
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__borderTopColor == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__borderTopColor = new(this, "UnityEngine.UIElements.IStyle.borderTopColor", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__borderTopColor.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__borderTopColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.borderTopLeftRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__borderTopLeftRadius;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__borderTopLeftRadius
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__borderTopLeftRadius == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__borderTopLeftRadius = new(this, "UnityEngine.UIElements.IStyle.borderTopLeftRadius", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__borderTopLeftRadius.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__borderTopLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.borderTopRightRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__borderTopRightRadius;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__borderTopRightRadius
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__borderTopRightRadius == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__borderTopRightRadius = new(this, "UnityEngine.UIElements.IStyle.borderTopRightRadius", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__borderTopRightRadius.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__borderTopRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.borderTopWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_UnityEngine__2__UIElements__2__IStyle__2__borderTopWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RUnityEngine__2__UIElements__2__IStyle__2__borderTopWidth
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__borderTopWidth == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__borderTopWidth = new(this, "UnityEngine.UIElements.IStyle.borderTopWidth", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__borderTopWidth.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__borderTopWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.bottom
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__bottom;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__bottom
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__bottom == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__bottom = new(this, "UnityEngine.UIElements.IStyle.bottom", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__bottom.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__bottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor UnityEngine.UIElements.IStyle.color
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_UnityEngine__2__UIElements__2__IStyle__2__color;
		public virtual RUnityEngine.RUIElements.RStyleColor RUnityEngine__2__UIElements__2__IStyle__2__color
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__color == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__color = new(this, "UnityEngine.UIElements.IStyle.color", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__color.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__color;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.DisplayStyle] UnityEngine.UIElements.IStyle.display
		/// </summary>
		protected RProperty r_UnityEngine__2__UIElements__2__IStyle__2__display;
		public virtual RProperty RUnityEngine__2__UIElements__2__IStyle__2__display
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__display == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__display = new(this, "UnityEngine.UIElements.IStyle.display", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__display.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__display;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.flexBasis
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__flexBasis;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__flexBasis
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__flexBasis == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__flexBasis = new(this, "UnityEngine.UIElements.IStyle.flexBasis", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__flexBasis.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__flexBasis;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.FlexDirection] UnityEngine.UIElements.IStyle.flexDirection
		/// </summary>
		protected RProperty r_UnityEngine__2__UIElements__2__IStyle__2__flexDirection;
		public virtual RProperty RUnityEngine__2__UIElements__2__IStyle__2__flexDirection
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__flexDirection == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__flexDirection = new(this, "UnityEngine.UIElements.IStyle.flexDirection", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__flexDirection.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__flexDirection;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.flexGrow
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_UnityEngine__2__UIElements__2__IStyle__2__flexGrow;
		public virtual RUnityEngine.RUIElements.RStyleFloat RUnityEngine__2__UIElements__2__IStyle__2__flexGrow
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__flexGrow == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__flexGrow = new(this, "UnityEngine.UIElements.IStyle.flexGrow", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__flexGrow.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__flexGrow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.flexShrink
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_UnityEngine__2__UIElements__2__IStyle__2__flexShrink;
		public virtual RUnityEngine.RUIElements.RStyleFloat RUnityEngine__2__UIElements__2__IStyle__2__flexShrink
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__flexShrink == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__flexShrink = new(this, "UnityEngine.UIElements.IStyle.flexShrink", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__flexShrink.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__flexShrink;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Wrap] UnityEngine.UIElements.IStyle.flexWrap
		/// </summary>
		protected RProperty r_UnityEngine__2__UIElements__2__IStyle__2__flexWrap;
		public virtual RProperty RUnityEngine__2__UIElements__2__IStyle__2__flexWrap
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__flexWrap == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__flexWrap = new(this, "UnityEngine.UIElements.IStyle.flexWrap", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__flexWrap.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__flexWrap;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.fontSize
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__fontSize;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__fontSize
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__fontSize == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__fontSize = new(this, "UnityEngine.UIElements.IStyle.fontSize", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__fontSize.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__fontSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.height
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__height;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__height
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__height == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__height = new(this, "UnityEngine.UIElements.IStyle.height", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__height.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__height;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Justify] UnityEngine.UIElements.IStyle.justifyContent
		/// </summary>
		protected RProperty r_UnityEngine__2__UIElements__2__IStyle__2__justifyContent;
		public virtual RProperty RUnityEngine__2__UIElements__2__IStyle__2__justifyContent
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__justifyContent == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__justifyContent = new(this, "UnityEngine.UIElements.IStyle.justifyContent", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__justifyContent.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__justifyContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.left
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__left;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__left
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__left == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__left = new(this, "UnityEngine.UIElements.IStyle.left", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__left.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__left;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.letterSpacing
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__letterSpacing;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__letterSpacing
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__letterSpacing == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__letterSpacing = new(this, "UnityEngine.UIElements.IStyle.letterSpacing", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__letterSpacing.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__letterSpacing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.marginBottom
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__marginBottom;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__marginBottom
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__marginBottom == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__marginBottom = new(this, "UnityEngine.UIElements.IStyle.marginBottom", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__marginBottom.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__marginBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.marginLeft
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__marginLeft;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__marginLeft
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__marginLeft == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__marginLeft = new(this, "UnityEngine.UIElements.IStyle.marginLeft", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__marginLeft.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__marginLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.marginRight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__marginRight;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__marginRight
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__marginRight == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__marginRight = new(this, "UnityEngine.UIElements.IStyle.marginRight", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__marginRight.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__marginRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.marginTop
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__marginTop;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__marginTop
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__marginTop == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__marginTop = new(this, "UnityEngine.UIElements.IStyle.marginTop", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__marginTop.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__marginTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.maxHeight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__maxHeight;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__maxHeight
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__maxHeight == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__maxHeight = new(this, "UnityEngine.UIElements.IStyle.maxHeight", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__maxHeight.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__maxHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.maxWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__maxWidth;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__maxWidth
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__maxWidth == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__maxWidth = new(this, "UnityEngine.UIElements.IStyle.maxWidth", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__maxWidth.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__maxWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.minHeight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__minHeight;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__minHeight
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__minHeight == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__minHeight = new(this, "UnityEngine.UIElements.IStyle.minHeight", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__minHeight.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__minHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.minWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__minWidth;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__minWidth
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__minWidth == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__minWidth = new(this, "UnityEngine.UIElements.IStyle.minWidth", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__minWidth.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__minWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.opacity
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_UnityEngine__2__UIElements__2__IStyle__2__opacity;
		public virtual RUnityEngine.RUIElements.RStyleFloat RUnityEngine__2__UIElements__2__IStyle__2__opacity
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__opacity == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__opacity = new(this, "UnityEngine.UIElements.IStyle.opacity", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__opacity.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__opacity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Overflow] UnityEngine.UIElements.IStyle.overflow
		/// </summary>
		protected RProperty r_UnityEngine__2__UIElements__2__IStyle__2__overflow;
		public virtual RProperty RUnityEngine__2__UIElements__2__IStyle__2__overflow
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__overflow == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__overflow = new(this, "UnityEngine.UIElements.IStyle.overflow", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__overflow.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__overflow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.paddingBottom
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__paddingBottom;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__paddingBottom
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__paddingBottom == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__paddingBottom = new(this, "UnityEngine.UIElements.IStyle.paddingBottom", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__paddingBottom.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__paddingBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.paddingLeft
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__paddingLeft;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__paddingLeft
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__paddingLeft == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__paddingLeft = new(this, "UnityEngine.UIElements.IStyle.paddingLeft", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__paddingLeft.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__paddingLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.paddingRight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__paddingRight;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__paddingRight
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__paddingRight == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__paddingRight = new(this, "UnityEngine.UIElements.IStyle.paddingRight", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__paddingRight.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__paddingRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.paddingTop
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__paddingTop;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__paddingTop
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__paddingTop == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__paddingTop = new(this, "UnityEngine.UIElements.IStyle.paddingTop", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__paddingTop.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__paddingTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Position] UnityEngine.UIElements.IStyle.position
		/// </summary>
		protected RProperty r_UnityEngine__2__UIElements__2__IStyle__2__position;
		public virtual RProperty RUnityEngine__2__UIElements__2__IStyle__2__position
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__position == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__position = new(this, "UnityEngine.UIElements.IStyle.position", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__position.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__position;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.right
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__right;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__right
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__right == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__right = new(this, "UnityEngine.UIElements.IStyle.right", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__right.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__right;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.TextOverflow] UnityEngine.UIElements.IStyle.textOverflow
		/// </summary>
		protected RProperty r_UnityEngine__2__UIElements__2__IStyle__2__textOverflow;
		public virtual RProperty RUnityEngine__2__UIElements__2__IStyle__2__textOverflow
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__textOverflow == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__textOverflow = new(this, "UnityEngine.UIElements.IStyle.textOverflow", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__textOverflow.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__textOverflow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.top
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__top;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__top
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__top == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__top = new(this, "UnityEngine.UIElements.IStyle.top", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__top.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__top;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[UnityEngine.UIElements.TimeValue] UnityEngine.UIElements.IStyle.transitionDelay
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.RTimeValue> r_UnityEngine__2__UIElements__2__IStyle__2__transitionDelay;
		public virtual RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.RTimeValue> RUnityEngine__2__UIElements__2__IStyle__2__transitionDelay
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__transitionDelay == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__transitionDelay = new(this, "UnityEngine.UIElements.IStyle.transitionDelay", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__transitionDelay.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__transitionDelay;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[UnityEngine.UIElements.TimeValue] UnityEngine.UIElements.IStyle.transitionDuration
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.RTimeValue> r_UnityEngine__2__UIElements__2__IStyle__2__transitionDuration;
		public virtual RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.RTimeValue> RUnityEngine__2__UIElements__2__IStyle__2__transitionDuration
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__transitionDuration == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__transitionDuration = new(this, "UnityEngine.UIElements.IStyle.transitionDuration", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__transitionDuration.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__transitionDuration;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[UnityEngine.UIElements.StylePropertyName] UnityEngine.UIElements.IStyle.transitionProperty
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.RStylePropertyName> r_UnityEngine__2__UIElements__2__IStyle__2__transitionProperty;
		public virtual RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.RStylePropertyName> RUnityEngine__2__UIElements__2__IStyle__2__transitionProperty
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__transitionProperty == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__transitionProperty = new(this, "UnityEngine.UIElements.IStyle.transitionProperty", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__transitionProperty.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__transitionProperty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[UnityEngine.UIElements.EasingFunction] UnityEngine.UIElements.IStyle.transitionTimingFunction
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.REasingFunction> r_UnityEngine__2__UIElements__2__IStyle__2__transitionTimingFunction;
		public virtual RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.REasingFunction> RUnityEngine__2__UIElements__2__IStyle__2__transitionTimingFunction
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__transitionTimingFunction == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__transitionTimingFunction = new(this, "UnityEngine.UIElements.IStyle.transitionTimingFunction", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__transitionTimingFunction.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__transitionTimingFunction;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor UnityEngine.UIElements.IStyle.unityBackgroundImageTintColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_UnityEngine__2__UIElements__2__IStyle__2__unityBackgroundImageTintColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RUnityEngine__2__UIElements__2__IStyle__2__unityBackgroundImageTintColor
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__unityBackgroundImageTintColor == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__unityBackgroundImageTintColor = new(this, "UnityEngine.UIElements.IStyle.unityBackgroundImageTintColor", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__unityBackgroundImageTintColor.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__unityBackgroundImageTintColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFont UnityEngine.UIElements.IStyle.unityFont
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFont r_UnityEngine__2__UIElements__2__IStyle__2__unityFont;
		public virtual RUnityEngine.RUIElements.RStyleFont RUnityEngine__2__UIElements__2__IStyle__2__unityFont
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__unityFont == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__unityFont = new(this, "UnityEngine.UIElements.IStyle.unityFont", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__unityFont.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__unityFont;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFontDefinition UnityEngine.UIElements.IStyle.unityFontDefinition
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFontDefinition r_UnityEngine__2__UIElements__2__IStyle__2__unityFontDefinition;
		public virtual RUnityEngine.RUIElements.RStyleFontDefinition RUnityEngine__2__UIElements__2__IStyle__2__unityFontDefinition
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__unityFontDefinition == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__unityFontDefinition = new(this, "UnityEngine.UIElements.IStyle.unityFontDefinition", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__unityFontDefinition.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__unityFontDefinition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.FontStyle] UnityEngine.UIElements.IStyle.unityFontStyleAndWeight
		/// </summary>
		protected RProperty r_UnityEngine__2__UIElements__2__IStyle__2__unityFontStyleAndWeight;
		public virtual RProperty RUnityEngine__2__UIElements__2__IStyle__2__unityFontStyleAndWeight
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__unityFontStyleAndWeight == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__unityFontStyleAndWeight = new(this, "UnityEngine.UIElements.IStyle.unityFontStyleAndWeight", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__unityFontStyleAndWeight.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__unityFontStyleAndWeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.OverflowClipBox] UnityEngine.UIElements.IStyle.unityOverflowClipBox
		/// </summary>
		protected RProperty r_UnityEngine__2__UIElements__2__IStyle__2__unityOverflowClipBox;
		public virtual RProperty RUnityEngine__2__UIElements__2__IStyle__2__unityOverflowClipBox
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__unityOverflowClipBox == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__unityOverflowClipBox = new(this, "UnityEngine.UIElements.IStyle.unityOverflowClipBox", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__unityOverflowClipBox.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__unityOverflowClipBox;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.unityParagraphSpacing
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__unityParagraphSpacing;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__unityParagraphSpacing
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__unityParagraphSpacing == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__unityParagraphSpacing = new(this, "UnityEngine.UIElements.IStyle.unityParagraphSpacing", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__unityParagraphSpacing.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__unityParagraphSpacing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt UnityEngine.UIElements.IStyle.unitySliceBottom
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleInt r_UnityEngine__2__UIElements__2__IStyle__2__unitySliceBottom;
		public virtual RUnityEngine.RUIElements.RStyleInt RUnityEngine__2__UIElements__2__IStyle__2__unitySliceBottom
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__unitySliceBottom == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__unitySliceBottom = new(this, "UnityEngine.UIElements.IStyle.unitySliceBottom", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__unitySliceBottom.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__unitySliceBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt UnityEngine.UIElements.IStyle.unitySliceLeft
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleInt r_UnityEngine__2__UIElements__2__IStyle__2__unitySliceLeft;
		public virtual RUnityEngine.RUIElements.RStyleInt RUnityEngine__2__UIElements__2__IStyle__2__unitySliceLeft
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__unitySliceLeft == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__unitySliceLeft = new(this, "UnityEngine.UIElements.IStyle.unitySliceLeft", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__unitySliceLeft.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__unitySliceLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt UnityEngine.UIElements.IStyle.unitySliceRight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleInt r_UnityEngine__2__UIElements__2__IStyle__2__unitySliceRight;
		public virtual RUnityEngine.RUIElements.RStyleInt RUnityEngine__2__UIElements__2__IStyle__2__unitySliceRight
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__unitySliceRight == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__unitySliceRight = new(this, "UnityEngine.UIElements.IStyle.unitySliceRight", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__unitySliceRight.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__unitySliceRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.unitySliceScale
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_UnityEngine__2__UIElements__2__IStyle__2__unitySliceScale;
		public virtual RUnityEngine.RUIElements.RStyleFloat RUnityEngine__2__UIElements__2__IStyle__2__unitySliceScale
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__unitySliceScale == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__unitySliceScale = new(this, "UnityEngine.UIElements.IStyle.unitySliceScale", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__unitySliceScale.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__unitySliceScale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt UnityEngine.UIElements.IStyle.unitySliceTop
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleInt r_UnityEngine__2__UIElements__2__IStyle__2__unitySliceTop;
		public virtual RUnityEngine.RUIElements.RStyleInt RUnityEngine__2__UIElements__2__IStyle__2__unitySliceTop
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__unitySliceTop == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__unitySliceTop = new(this, "UnityEngine.UIElements.IStyle.unitySliceTop", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__unitySliceTop.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__unitySliceTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.TextAnchor] UnityEngine.UIElements.IStyle.unityTextAlign
		/// </summary>
		protected RProperty r_UnityEngine__2__UIElements__2__IStyle__2__unityTextAlign;
		public virtual RProperty RUnityEngine__2__UIElements__2__IStyle__2__unityTextAlign
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__unityTextAlign == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__unityTextAlign = new(this, "UnityEngine.UIElements.IStyle.unityTextAlign", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__unityTextAlign.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__unityTextAlign;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor UnityEngine.UIElements.IStyle.unityTextOutlineColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_UnityEngine__2__UIElements__2__IStyle__2__unityTextOutlineColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RUnityEngine__2__UIElements__2__IStyle__2__unityTextOutlineColor
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__unityTextOutlineColor == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__unityTextOutlineColor = new(this, "UnityEngine.UIElements.IStyle.unityTextOutlineColor", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__unityTextOutlineColor.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__unityTextOutlineColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.unityTextOutlineWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_UnityEngine__2__UIElements__2__IStyle__2__unityTextOutlineWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RUnityEngine__2__UIElements__2__IStyle__2__unityTextOutlineWidth
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__unityTextOutlineWidth == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__unityTextOutlineWidth = new(this, "UnityEngine.UIElements.IStyle.unityTextOutlineWidth", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__unityTextOutlineWidth.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__unityTextOutlineWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.TextOverflowPosition] UnityEngine.UIElements.IStyle.unityTextOverflowPosition
		/// </summary>
		protected RProperty r_UnityEngine__2__UIElements__2__IStyle__2__unityTextOverflowPosition;
		public virtual RProperty RUnityEngine__2__UIElements__2__IStyle__2__unityTextOverflowPosition
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__unityTextOverflowPosition == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__unityTextOverflowPosition = new(this, "UnityEngine.UIElements.IStyle.unityTextOverflowPosition", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__unityTextOverflowPosition.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__unityTextOverflowPosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Visibility] UnityEngine.UIElements.IStyle.visibility
		/// </summary>
		protected RProperty r_UnityEngine__2__UIElements__2__IStyle__2__visibility;
		public virtual RProperty RUnityEngine__2__UIElements__2__IStyle__2__visibility
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__visibility == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__visibility = new(this, "UnityEngine.UIElements.IStyle.visibility", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__visibility.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__visibility;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.WhiteSpace] UnityEngine.UIElements.IStyle.whiteSpace
		/// </summary>
		protected RProperty r_UnityEngine__2__UIElements__2__IStyle__2__whiteSpace;
		public virtual RProperty RUnityEngine__2__UIElements__2__IStyle__2__whiteSpace
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__whiteSpace == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__whiteSpace = new(this, "UnityEngine.UIElements.IStyle.whiteSpace", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__whiteSpace.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__whiteSpace;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.width
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__width;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__width
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__width == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__width = new(this, "UnityEngine.UIElements.IStyle.width", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__width.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__width;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.wordSpacing
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_UnityEngine__2__UIElements__2__IStyle__2__wordSpacing;
		public virtual RUnityEngine.RUIElements.RStyleLength RUnityEngine__2__UIElements__2__IStyle__2__wordSpacing
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__wordSpacing == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__wordSpacing = new(this, "UnityEngine.UIElements.IStyle.wordSpacing", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__wordSpacing.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__wordSpacing;
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
		protected RUnityEngine.RUIElements.RStyleCursor r_UnityEngine__2__UIElements__2__IStyle__2__cursor;
		public virtual RUnityEngine.RUIElements.RStyleCursor RUnityEngine__2__UIElements__2__IStyle__2__cursor
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__cursor == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__cursor = new(this, "UnityEngine.UIElements.IStyle.cursor", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__cursor.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__cursor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleTextShadow UnityEngine.UIElements.IStyle.textShadow
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleTextShadow r_UnityEngine__2__UIElements__2__IStyle__2__textShadow;
		public virtual RUnityEngine.RUIElements.RStyleTextShadow RUnityEngine__2__UIElements__2__IStyle__2__textShadow
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__textShadow == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__textShadow = new(this, "UnityEngine.UIElements.IStyle.textShadow", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__textShadow.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__textShadow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundSize UnityEngine.UIElements.IStyle.backgroundSize
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleBackgroundSize r_UnityEngine__2__UIElements__2__IStyle__2__backgroundSize;
		public virtual RUnityEngine.RUIElements.RStyleBackgroundSize RUnityEngine__2__UIElements__2__IStyle__2__backgroundSize
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__backgroundSize == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__backgroundSize = new(this, "UnityEngine.UIElements.IStyle.backgroundSize", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__backgroundSize.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__backgroundSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleTransformOrigin UnityEngine.UIElements.IStyle.transformOrigin
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleTransformOrigin r_UnityEngine__2__UIElements__2__IStyle__2__transformOrigin;
		public virtual RUnityEngine.RUIElements.RStyleTransformOrigin RUnityEngine__2__UIElements__2__IStyle__2__transformOrigin
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__transformOrigin == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__transformOrigin = new(this, "UnityEngine.UIElements.IStyle.transformOrigin", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__transformOrigin.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__transformOrigin;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleTranslate UnityEngine.UIElements.IStyle.translate
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleTranslate r_UnityEngine__2__UIElements__2__IStyle__2__translate;
		public virtual RUnityEngine.RUIElements.RStyleTranslate RUnityEngine__2__UIElements__2__IStyle__2__translate
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__translate == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__translate = new(this, "UnityEngine.UIElements.IStyle.translate", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__translate.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__translate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleRotate UnityEngine.UIElements.IStyle.rotate
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleRotate r_UnityEngine__2__UIElements__2__IStyle__2__rotate;
		public virtual RUnityEngine.RUIElements.RStyleRotate RUnityEngine__2__UIElements__2__IStyle__2__rotate
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__rotate == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__rotate = new(this, "UnityEngine.UIElements.IStyle.rotate", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__rotate.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__rotate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleScale UnityEngine.UIElements.IStyle.scale
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleScale r_UnityEngine__2__UIElements__2__IStyle__2__scale;
		public virtual RUnityEngine.RUIElements.RStyleScale RUnityEngine__2__UIElements__2__IStyle__2__scale
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__scale == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__scale = new(this, "UnityEngine.UIElements.IStyle.scale", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__scale.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__scale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.ScaleMode] UnityEngine.UIElements.IStyle.unityBackgroundScaleMode
		/// </summary>
		protected RProperty r_UnityEngine__2__UIElements__2__IStyle__2__unityBackgroundScaleMode;
		public virtual RProperty RUnityEngine__2__UIElements__2__IStyle__2__unityBackgroundScaleMode
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IStyle__2__unityBackgroundScaleMode == null)
				{
					r_UnityEngine__2__UIElements__2__IStyle__2__unityBackgroundScaleMode = new(this, "UnityEngine.UIElements.IStyle.unityBackgroundScaleMode", -1);
					r_UnityEngine__2__UIElements__2__IStyle__2__unityBackgroundScaleMode.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IStyle__2__unityBackgroundScaleMode;
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
		/// Void SetInlineRule(UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleRule)
		/// </summary>
		protected RMethod r_SetInlineRule_StyleSheet_StyleRule;
		public virtual RMethod RSetInlineRule_StyleSheet_StyleRule
		{
			get
			{
				if(r_SetInlineRule_StyleSheet_StyleRule == null)
				{
					r_SetInlineRule_StyleSheet_StyleRule = new(this, "SetInlineRule", 0, typeof(UnityEngine.UIElements.StyleSheet),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleRule"));
					r_SetInlineRule_StyleSheet_StyleRule.SetBelong(this.instance);
				}
				return r_SetInlineRule_StyleSheet_StyleRule;
			}
		}

		/// <summary>
		/// Boolean IsValueSet(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_IsValueSet_StylePropertyId;
		public virtual RMethod RIsValueSet_StylePropertyId
		{
			get
			{
				if(r_IsValueSet_StylePropertyId == null)
				{
					r_IsValueSet_StylePropertyId = new(this, "IsValueSet", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_IsValueSet_StylePropertyId.SetBelong(this.instance);
				}
				return r_IsValueSet_StylePropertyId;
			}
		}

		/// <summary>
		/// Void ApplyInlineStyles(UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_ApplyInlineStyles_Ref_ComputedStyle;
		public virtual RMethod RApplyInlineStyles_Ref_ComputedStyle
		{
			get
			{
				if(r_ApplyInlineStyles_Ref_ComputedStyle == null)
				{
					r_ApplyInlineStyles_Ref_ComputedStyle = new(this, "ApplyInlineStyles", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_ApplyInlineStyles_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_ApplyInlineStyles_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[T] GetStyleList[T](UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_GetStyleList_GT_StylePropertyId;
		public virtual RMethod RGetStyleList_GT_StylePropertyId
		{
			get
			{
				if(r_GetStyleList_GT_StylePropertyId == null)
				{
					r_GetStyleList_GT_StylePropertyId = new(this, "GetStyleList", 1,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_GetStyleList_GT_StylePropertyId.SetBelong(this.instance);
				}
				return r_GetStyleList_GT_StylePropertyId;
			}
		}

		/// <summary>
		/// Void SetStyleValueManaged(UnityEngine.UIElements.StyleSheets.StyleValueManaged)
		/// </summary>
		protected RMethod r_SetStyleValueManaged_StyleValueManaged;
		public virtual RMethod RSetStyleValueManaged_StyleValueManaged
		{
			get
			{
				if(r_SetStyleValueManaged_StyleValueManaged == null)
				{
					r_SetStyleValueManaged_StyleValueManaged = new(this, "SetStyleValueManaged", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValueManaged"));
					r_SetStyleValueManaged_StyleValueManaged.SetBelong(this.instance);
				}
				return r_SetStyleValueManaged_StyleValueManaged;
			}
		}

		/// <summary>
		/// Boolean TryGetStyleValueManaged(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleSheets.StyleValueManaged ByRef)
		/// </summary>
		protected RMethod r_TryGetStyleValueManaged_StylePropertyId_Ref_StyleValueManaged;
		public virtual RMethod RTryGetStyleValueManaged_StylePropertyId_Ref_StyleValueManaged
		{
			get
			{
				if(r_TryGetStyleValueManaged_StylePropertyId_Ref_StyleValueManaged == null)
				{
					r_TryGetStyleValueManaged_StylePropertyId_Ref_StyleValueManaged = new(this, "TryGetStyleValueManaged", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValueManaged").MakeByRefType());
					r_TryGetStyleValueManaged_StylePropertyId_Ref_StyleValueManaged.SetBelong(this.instance);
				}
				return r_TryGetStyleValueManaged_StylePropertyId_Ref_StyleValueManaged;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleBackgroundPosition)
		/// </summary>
		protected RMethod r_SetStyleValue_StylePropertyId_StyleBackgroundPosition;
		public virtual RMethod RSetStyleValue_StylePropertyId_StyleBackgroundPosition
		{
			get
			{
				if(r_SetStyleValue_StylePropertyId_StyleBackgroundPosition == null)
				{
					r_SetStyleValue_StylePropertyId_StyleBackgroundPosition = new(this, "SetStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleBackgroundPosition));
					r_SetStyleValue_StylePropertyId_StyleBackgroundPosition.SetBelong(this.instance);
				}
				return r_SetStyleValue_StylePropertyId_StyleBackgroundPosition;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleBackgroundRepeat)
		/// </summary>
		protected RMethod r_SetStyleValue_StylePropertyId_StyleBackgroundRepeat;
		public virtual RMethod RSetStyleValue_StylePropertyId_StyleBackgroundRepeat
		{
			get
			{
				if(r_SetStyleValue_StylePropertyId_StyleBackgroundRepeat == null)
				{
					r_SetStyleValue_StylePropertyId_StyleBackgroundRepeat = new(this, "SetStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleBackgroundRepeat));
					r_SetStyleValue_StylePropertyId_StyleBackgroundRepeat.SetBelong(this.instance);
				}
				return r_SetStyleValue_StylePropertyId_StyleBackgroundRepeat;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleLength)
		/// </summary>
		protected RMethod r_SetStyleValue_StylePropertyId_StyleLength;
		public virtual RMethod RSetStyleValue_StylePropertyId_StyleLength
		{
			get
			{
				if(r_SetStyleValue_StylePropertyId_StyleLength == null)
				{
					r_SetStyleValue_StylePropertyId_StyleLength = new(this, "SetStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleLength));
					r_SetStyleValue_StylePropertyId_StyleLength.SetBelong(this.instance);
				}
				return r_SetStyleValue_StylePropertyId_StyleLength;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleFloat)
		/// </summary>
		protected RMethod r_SetStyleValue_StylePropertyId_StyleFloat;
		public virtual RMethod RSetStyleValue_StylePropertyId_StyleFloat
		{
			get
			{
				if(r_SetStyleValue_StylePropertyId_StyleFloat == null)
				{
					r_SetStyleValue_StylePropertyId_StyleFloat = new(this, "SetStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleFloat));
					r_SetStyleValue_StylePropertyId_StyleFloat.SetBelong(this.instance);
				}
				return r_SetStyleValue_StylePropertyId_StyleFloat;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleInt)
		/// </summary>
		protected RMethod r_SetStyleValue_StylePropertyId_StyleInt;
		public virtual RMethod RSetStyleValue_StylePropertyId_StyleInt
		{
			get
			{
				if(r_SetStyleValue_StylePropertyId_StyleInt == null)
				{
					r_SetStyleValue_StylePropertyId_StyleInt = new(this, "SetStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleInt));
					r_SetStyleValue_StylePropertyId_StyleInt.SetBelong(this.instance);
				}
				return r_SetStyleValue_StylePropertyId_StyleInt;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleColor)
		/// </summary>
		protected RMethod r_SetStyleValue_StylePropertyId_StyleColor;
		public virtual RMethod RSetStyleValue_StylePropertyId_StyleColor
		{
			get
			{
				if(r_SetStyleValue_StylePropertyId_StyleColor == null)
				{
					r_SetStyleValue_StylePropertyId_StyleColor = new(this, "SetStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleColor));
					r_SetStyleValue_StylePropertyId_StyleColor.SetBelong(this.instance);
				}
				return r_SetStyleValue_StylePropertyId_StyleColor;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue[T](UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleEnum`1[T])
		/// </summary>
		protected RMethod r_SetStyleValue_GT_StylePropertyId_StyleEnum_d_T_p_;
		public virtual RMethod RSetStyleValue_GT_StylePropertyId_StyleEnum_d_T_p_
		{
			get
			{
				if(r_SetStyleValue_GT_StylePropertyId_StyleEnum_d_T_p_ == null)
				{
					r_SetStyleValue_GT_StylePropertyId_StyleEnum_d_T_p_ = new(this, "SetStyleValue", 1,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleEnum<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_SetStyleValue_GT_StylePropertyId_StyleEnum_d_T_p_.SetBelong(this.instance);
				}
				return r_SetStyleValue_GT_StylePropertyId_StyleEnum_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleBackground)
		/// </summary>
		protected RMethod r_SetStyleValue_StylePropertyId_StyleBackground;
		public virtual RMethod RSetStyleValue_StylePropertyId_StyleBackground
		{
			get
			{
				if(r_SetStyleValue_StylePropertyId_StyleBackground == null)
				{
					r_SetStyleValue_StylePropertyId_StyleBackground = new(this, "SetStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleBackground));
					r_SetStyleValue_StylePropertyId_StyleBackground.SetBelong(this.instance);
				}
				return r_SetStyleValue_StylePropertyId_StyleBackground;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleFontDefinition)
		/// </summary>
		protected RMethod r_SetStyleValue_StylePropertyId_StyleFontDefinition;
		public virtual RMethod RSetStyleValue_StylePropertyId_StyleFontDefinition
		{
			get
			{
				if(r_SetStyleValue_StylePropertyId_StyleFontDefinition == null)
				{
					r_SetStyleValue_StylePropertyId_StyleFontDefinition = new(this, "SetStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleFontDefinition));
					r_SetStyleValue_StylePropertyId_StyleFontDefinition.SetBelong(this.instance);
				}
				return r_SetStyleValue_StylePropertyId_StyleFontDefinition;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleFont)
		/// </summary>
		protected RMethod r_SetStyleValue_StylePropertyId_StyleFont;
		public virtual RMethod RSetStyleValue_StylePropertyId_StyleFont
		{
			get
			{
				if(r_SetStyleValue_StylePropertyId_StyleFont == null)
				{
					r_SetStyleValue_StylePropertyId_StyleFont = new(this, "SetStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleFont));
					r_SetStyleValue_StylePropertyId_StyleFont.SetBelong(this.instance);
				}
				return r_SetStyleValue_StylePropertyId_StyleFont;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue[T](UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleList`1[T])
		/// </summary>
		protected RMethod r_SetStyleValue_GT_StylePropertyId_StyleList_d_T_p_;
		public virtual RMethod RSetStyleValue_GT_StylePropertyId_StyleList_d_T_p_
		{
			get
			{
				if(r_SetStyleValue_GT_StylePropertyId_StyleList_d_T_p_ == null)
				{
					r_SetStyleValue_GT_StylePropertyId_StyleList_d_T_p_ = new(this, "SetStyleValue", 1,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleList<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_SetStyleValue_GT_StylePropertyId_StyleList_d_T_p_.SetBelong(this.instance);
				}
				return r_SetStyleValue_GT_StylePropertyId_StyleList_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean SetInlineCursor(UnityEngine.UIElements.StyleCursor)
		/// </summary>
		protected RMethod r_SetInlineCursor_StyleCursor;
		public virtual RMethod RSetInlineCursor_StyleCursor
		{
			get
			{
				if(r_SetInlineCursor_StyleCursor == null)
				{
					r_SetInlineCursor_StyleCursor = new(this, "SetInlineCursor", 0, typeof(UnityEngine.UIElements.StyleCursor));
					r_SetInlineCursor_StyleCursor.SetBelong(this.instance);
				}
				return r_SetInlineCursor_StyleCursor;
			}
		}

		/// <summary>
		/// Void ApplyStyleCursor(UnityEngine.UIElements.StyleCursor)
		/// </summary>
		protected RMethod r_ApplyStyleCursor_StyleCursor;
		public virtual RMethod RApplyStyleCursor_StyleCursor
		{
			get
			{
				if(r_ApplyStyleCursor_StyleCursor == null)
				{
					r_ApplyStyleCursor_StyleCursor = new(this, "ApplyStyleCursor", 0, typeof(UnityEngine.UIElements.StyleCursor));
					r_ApplyStyleCursor_StyleCursor.SetBelong(this.instance);
				}
				return r_ApplyStyleCursor_StyleCursor;
			}
		}

		/// <summary>
		/// Boolean SetInlineTextShadow(UnityEngine.UIElements.StyleTextShadow)
		/// </summary>
		protected RMethod r_SetInlineTextShadow_StyleTextShadow;
		public virtual RMethod RSetInlineTextShadow_StyleTextShadow
		{
			get
			{
				if(r_SetInlineTextShadow_StyleTextShadow == null)
				{
					r_SetInlineTextShadow_StyleTextShadow = new(this, "SetInlineTextShadow", 0, typeof(UnityEngine.UIElements.StyleTextShadow));
					r_SetInlineTextShadow_StyleTextShadow.SetBelong(this.instance);
				}
				return r_SetInlineTextShadow_StyleTextShadow;
			}
		}

		/// <summary>
		/// Void ApplyStyleTextShadow(UnityEngine.UIElements.StyleTextShadow)
		/// </summary>
		protected RMethod r_ApplyStyleTextShadow_StyleTextShadow;
		public virtual RMethod RApplyStyleTextShadow_StyleTextShadow
		{
			get
			{
				if(r_ApplyStyleTextShadow_StyleTextShadow == null)
				{
					r_ApplyStyleTextShadow_StyleTextShadow = new(this, "ApplyStyleTextShadow", 0, typeof(UnityEngine.UIElements.StyleTextShadow));
					r_ApplyStyleTextShadow_StyleTextShadow.SetBelong(this.instance);
				}
				return r_ApplyStyleTextShadow_StyleTextShadow;
			}
		}

		/// <summary>
		/// Boolean SetInlineTransformOrigin(UnityEngine.UIElements.StyleTransformOrigin)
		/// </summary>
		protected RMethod r_SetInlineTransformOrigin_StyleTransformOrigin;
		public virtual RMethod RSetInlineTransformOrigin_StyleTransformOrigin
		{
			get
			{
				if(r_SetInlineTransformOrigin_StyleTransformOrigin == null)
				{
					r_SetInlineTransformOrigin_StyleTransformOrigin = new(this, "SetInlineTransformOrigin", 0, typeof(UnityEngine.UIElements.StyleTransformOrigin));
					r_SetInlineTransformOrigin_StyleTransformOrigin.SetBelong(this.instance);
				}
				return r_SetInlineTransformOrigin_StyleTransformOrigin;
			}
		}

		/// <summary>
		/// Void ApplyStyleTransformOrigin(UnityEngine.UIElements.StyleTransformOrigin)
		/// </summary>
		protected RMethod r_ApplyStyleTransformOrigin_StyleTransformOrigin;
		public virtual RMethod RApplyStyleTransformOrigin_StyleTransformOrigin
		{
			get
			{
				if(r_ApplyStyleTransformOrigin_StyleTransformOrigin == null)
				{
					r_ApplyStyleTransformOrigin_StyleTransformOrigin = new(this, "ApplyStyleTransformOrigin", 0, typeof(UnityEngine.UIElements.StyleTransformOrigin));
					r_ApplyStyleTransformOrigin_StyleTransformOrigin.SetBelong(this.instance);
				}
				return r_ApplyStyleTransformOrigin_StyleTransformOrigin;
			}
		}

		/// <summary>
		/// Boolean SetInlineTranslate(UnityEngine.UIElements.StyleTranslate)
		/// </summary>
		protected RMethod r_SetInlineTranslate_StyleTranslate;
		public virtual RMethod RSetInlineTranslate_StyleTranslate
		{
			get
			{
				if(r_SetInlineTranslate_StyleTranslate == null)
				{
					r_SetInlineTranslate_StyleTranslate = new(this, "SetInlineTranslate", 0, typeof(UnityEngine.UIElements.StyleTranslate));
					r_SetInlineTranslate_StyleTranslate.SetBelong(this.instance);
				}
				return r_SetInlineTranslate_StyleTranslate;
			}
		}

		/// <summary>
		/// Void ApplyStyleTranslate(UnityEngine.UIElements.StyleTranslate)
		/// </summary>
		protected RMethod r_ApplyStyleTranslate_StyleTranslate;
		public virtual RMethod RApplyStyleTranslate_StyleTranslate
		{
			get
			{
				if(r_ApplyStyleTranslate_StyleTranslate == null)
				{
					r_ApplyStyleTranslate_StyleTranslate = new(this, "ApplyStyleTranslate", 0, typeof(UnityEngine.UIElements.StyleTranslate));
					r_ApplyStyleTranslate_StyleTranslate.SetBelong(this.instance);
				}
				return r_ApplyStyleTranslate_StyleTranslate;
			}
		}

		/// <summary>
		/// Boolean SetInlineScale(UnityEngine.UIElements.StyleScale)
		/// </summary>
		protected RMethod r_SetInlineScale_StyleScale;
		public virtual RMethod RSetInlineScale_StyleScale
		{
			get
			{
				if(r_SetInlineScale_StyleScale == null)
				{
					r_SetInlineScale_StyleScale = new(this, "SetInlineScale", 0, typeof(UnityEngine.UIElements.StyleScale));
					r_SetInlineScale_StyleScale.SetBelong(this.instance);
				}
				return r_SetInlineScale_StyleScale;
			}
		}

		/// <summary>
		/// Void ApplyStyleScale(UnityEngine.UIElements.StyleScale)
		/// </summary>
		protected RMethod r_ApplyStyleScale_StyleScale;
		public virtual RMethod RApplyStyleScale_StyleScale
		{
			get
			{
				if(r_ApplyStyleScale_StyleScale == null)
				{
					r_ApplyStyleScale_StyleScale = new(this, "ApplyStyleScale", 0, typeof(UnityEngine.UIElements.StyleScale));
					r_ApplyStyleScale_StyleScale.SetBelong(this.instance);
				}
				return r_ApplyStyleScale_StyleScale;
			}
		}

		/// <summary>
		/// Boolean SetInlineRotate(UnityEngine.UIElements.StyleRotate)
		/// </summary>
		protected RMethod r_SetInlineRotate_StyleRotate;
		public virtual RMethod RSetInlineRotate_StyleRotate
		{
			get
			{
				if(r_SetInlineRotate_StyleRotate == null)
				{
					r_SetInlineRotate_StyleRotate = new(this, "SetInlineRotate", 0, typeof(UnityEngine.UIElements.StyleRotate));
					r_SetInlineRotate_StyleRotate.SetBelong(this.instance);
				}
				return r_SetInlineRotate_StyleRotate;
			}
		}

		/// <summary>
		/// Void ApplyStyleRotate(UnityEngine.UIElements.StyleRotate)
		/// </summary>
		protected RMethod r_ApplyStyleRotate_StyleRotate;
		public virtual RMethod RApplyStyleRotate_StyleRotate
		{
			get
			{
				if(r_ApplyStyleRotate_StyleRotate == null)
				{
					r_ApplyStyleRotate_StyleRotate = new(this, "ApplyStyleRotate", 0, typeof(UnityEngine.UIElements.StyleRotate));
					r_ApplyStyleRotate_StyleRotate.SetBelong(this.instance);
				}
				return r_ApplyStyleRotate_StyleRotate;
			}
		}

		/// <summary>
		/// Boolean SetInlineBackgroundSize(UnityEngine.UIElements.StyleBackgroundSize)
		/// </summary>
		protected RMethod r_SetInlineBackgroundSize_StyleBackgroundSize;
		public virtual RMethod RSetInlineBackgroundSize_StyleBackgroundSize
		{
			get
			{
				if(r_SetInlineBackgroundSize_StyleBackgroundSize == null)
				{
					r_SetInlineBackgroundSize_StyleBackgroundSize = new(this, "SetInlineBackgroundSize", 0, typeof(UnityEngine.UIElements.StyleBackgroundSize));
					r_SetInlineBackgroundSize_StyleBackgroundSize.SetBelong(this.instance);
				}
				return r_SetInlineBackgroundSize_StyleBackgroundSize;
			}
		}

		/// <summary>
		/// Void ApplyStyleBackgroundSize(UnityEngine.UIElements.StyleBackgroundSize)
		/// </summary>
		protected RMethod r_ApplyStyleBackgroundSize_StyleBackgroundSize;
		public virtual RMethod RApplyStyleBackgroundSize_StyleBackgroundSize
		{
			get
			{
				if(r_ApplyStyleBackgroundSize_StyleBackgroundSize == null)
				{
					r_ApplyStyleBackgroundSize_StyleBackgroundSize = new(this, "ApplyStyleBackgroundSize", 0, typeof(UnityEngine.UIElements.StyleBackgroundSize));
					r_ApplyStyleBackgroundSize_StyleBackgroundSize.SetBelong(this.instance);
				}
				return r_ApplyStyleBackgroundSize_StyleBackgroundSize;
			}
		}

		/// <summary>
		/// Void ApplyStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue)
		/// </summary>
		protected RMethod r_ApplyStyleValue_StyleValue;
		public virtual RMethod RApplyStyleValue_StyleValue
		{
			get
			{
				if(r_ApplyStyleValue_StyleValue == null)
				{
					r_ApplyStyleValue_StyleValue = new(this, "ApplyStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValue"));
					r_ApplyStyleValue_StyleValue.SetBelong(this.instance);
				}
				return r_ApplyStyleValue_StyleValue;
			}
		}

		/// <summary>
		/// Void ApplyStyleValue(UnityEngine.UIElements.StyleSheets.StyleValueManaged)
		/// </summary>
		protected RMethod r_ApplyStyleValue_StyleValueManaged;
		public virtual RMethod RApplyStyleValue_StyleValueManaged
		{
			get
			{
				if(r_ApplyStyleValue_StyleValueManaged == null)
				{
					r_ApplyStyleValue_StyleValueManaged = new(this, "ApplyStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValueManaged"));
					r_ApplyStyleValue_StyleValueManaged.SetBelong(this.instance);
				}
				return r_ApplyStyleValue_StyleValueManaged;
			}
		}

		/// <summary>
		/// Boolean RemoveInlineStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_RemoveInlineStyle_StylePropertyId;
		public virtual RMethod RRemoveInlineStyle_StylePropertyId
		{
			get
			{
				if(r_RemoveInlineStyle_StylePropertyId == null)
				{
					r_RemoveInlineStyle_StylePropertyId = new(this, "RemoveInlineStyle", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_RemoveInlineStyle_StylePropertyId.SetBelong(this.instance);
				}
				return r_RemoveInlineStyle_StylePropertyId;
			}
		}

		/// <summary>
		/// Void ApplyFromComputedStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_ApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle;
		public virtual RMethod RApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle
		{
			get
			{
				if(r_ApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle == null)
				{
					r_ApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle = new(this, "ApplyFromComputedStyle", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"),  ReleactionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_ApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_ApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Boolean TryGetInlineCursor(UnityEngine.UIElements.StyleCursor ByRef)
		/// </summary>
		protected RMethod r_TryGetInlineCursor_Ref_StyleCursor;
		public virtual RMethod RTryGetInlineCursor_Ref_StyleCursor
		{
			get
			{
				if(r_TryGetInlineCursor_Ref_StyleCursor == null)
				{
					r_TryGetInlineCursor_Ref_StyleCursor = new(this, "TryGetInlineCursor", 0, typeof(UnityEngine.UIElements.StyleCursor).MakeByRefType());
					r_TryGetInlineCursor_Ref_StyleCursor.SetBelong(this.instance);
				}
				return r_TryGetInlineCursor_Ref_StyleCursor;
			}
		}

		/// <summary>
		/// Boolean TryGetInlineTextShadow(UnityEngine.UIElements.StyleTextShadow ByRef)
		/// </summary>
		protected RMethod r_TryGetInlineTextShadow_Ref_StyleTextShadow;
		public virtual RMethod RTryGetInlineTextShadow_Ref_StyleTextShadow
		{
			get
			{
				if(r_TryGetInlineTextShadow_Ref_StyleTextShadow == null)
				{
					r_TryGetInlineTextShadow_Ref_StyleTextShadow = new(this, "TryGetInlineTextShadow", 0, typeof(UnityEngine.UIElements.StyleTextShadow).MakeByRefType());
					r_TryGetInlineTextShadow_Ref_StyleTextShadow.SetBelong(this.instance);
				}
				return r_TryGetInlineTextShadow_Ref_StyleTextShadow;
			}
		}

		/// <summary>
		/// Boolean TryGetInlineTransformOrigin(UnityEngine.UIElements.StyleTransformOrigin ByRef)
		/// </summary>
		protected RMethod r_TryGetInlineTransformOrigin_Ref_StyleTransformOrigin;
		public virtual RMethod RTryGetInlineTransformOrigin_Ref_StyleTransformOrigin
		{
			get
			{
				if(r_TryGetInlineTransformOrigin_Ref_StyleTransformOrigin == null)
				{
					r_TryGetInlineTransformOrigin_Ref_StyleTransformOrigin = new(this, "TryGetInlineTransformOrigin", 0, typeof(UnityEngine.UIElements.StyleTransformOrigin).MakeByRefType());
					r_TryGetInlineTransformOrigin_Ref_StyleTransformOrigin.SetBelong(this.instance);
				}
				return r_TryGetInlineTransformOrigin_Ref_StyleTransformOrigin;
			}
		}

		/// <summary>
		/// Boolean TryGetInlineTranslate(UnityEngine.UIElements.StyleTranslate ByRef)
		/// </summary>
		protected RMethod r_TryGetInlineTranslate_Ref_StyleTranslate;
		public virtual RMethod RTryGetInlineTranslate_Ref_StyleTranslate
		{
			get
			{
				if(r_TryGetInlineTranslate_Ref_StyleTranslate == null)
				{
					r_TryGetInlineTranslate_Ref_StyleTranslate = new(this, "TryGetInlineTranslate", 0, typeof(UnityEngine.UIElements.StyleTranslate).MakeByRefType());
					r_TryGetInlineTranslate_Ref_StyleTranslate.SetBelong(this.instance);
				}
				return r_TryGetInlineTranslate_Ref_StyleTranslate;
			}
		}

		/// <summary>
		/// Boolean TryGetInlineRotate(UnityEngine.UIElements.StyleRotate ByRef)
		/// </summary>
		protected RMethod r_TryGetInlineRotate_Ref_StyleRotate;
		public virtual RMethod RTryGetInlineRotate_Ref_StyleRotate
		{
			get
			{
				if(r_TryGetInlineRotate_Ref_StyleRotate == null)
				{
					r_TryGetInlineRotate_Ref_StyleRotate = new(this, "TryGetInlineRotate", 0, typeof(UnityEngine.UIElements.StyleRotate).MakeByRefType());
					r_TryGetInlineRotate_Ref_StyleRotate.SetBelong(this.instance);
				}
				return r_TryGetInlineRotate_Ref_StyleRotate;
			}
		}

		/// <summary>
		/// Boolean TryGetInlineScale(UnityEngine.UIElements.StyleScale ByRef)
		/// </summary>
		protected RMethod r_TryGetInlineScale_Ref_StyleScale;
		public virtual RMethod RTryGetInlineScale_Ref_StyleScale
		{
			get
			{
				if(r_TryGetInlineScale_Ref_StyleScale == null)
				{
					r_TryGetInlineScale_Ref_StyleScale = new(this, "TryGetInlineScale", 0, typeof(UnityEngine.UIElements.StyleScale).MakeByRefType());
					r_TryGetInlineScale_Ref_StyleScale.SetBelong(this.instance);
				}
				return r_TryGetInlineScale_Ref_StyleScale;
			}
		}

		/// <summary>
		/// Boolean TryGetInlineBackgroundSize(UnityEngine.UIElements.StyleBackgroundSize ByRef)
		/// </summary>
		protected RMethod r_TryGetInlineBackgroundSize_Ref_StyleBackgroundSize;
		public virtual RMethod RTryGetInlineBackgroundSize_Ref_StyleBackgroundSize
		{
			get
			{
				if(r_TryGetInlineBackgroundSize_Ref_StyleBackgroundSize == null)
				{
					r_TryGetInlineBackgroundSize_Ref_StyleBackgroundSize = new(this, "TryGetInlineBackgroundSize", 0, typeof(UnityEngine.UIElements.StyleBackgroundSize).MakeByRefType());
					r_TryGetInlineBackgroundSize_Ref_StyleBackgroundSize.SetBelong(this.instance);
				}
				return r_TryGetInlineBackgroundSize_Ref_StyleBackgroundSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_GetStyleLength_StylePropertyId;
		public virtual RMethod RGetStyleLength_StylePropertyId
		{
			get
			{
				if(r_GetStyleLength_StylePropertyId == null)
				{
					r_GetStyleLength_StylePropertyId = new(this, "GetStyleLength", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_GetStyleLength_StylePropertyId.SetBelong(this.instance);
				}
				return r_GetStyleLength_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_GetStyleFloat_StylePropertyId;
		public virtual RMethod RGetStyleFloat_StylePropertyId
		{
			get
			{
				if(r_GetStyleFloat_StylePropertyId == null)
				{
					r_GetStyleFloat_StylePropertyId = new(this, "GetStyleFloat", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_GetStyleFloat_StylePropertyId.SetBelong(this.instance);
				}
				return r_GetStyleFloat_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_GetStyleInt_StylePropertyId;
		public virtual RMethod RGetStyleInt_StylePropertyId
		{
			get
			{
				if(r_GetStyleInt_StylePropertyId == null)
				{
					r_GetStyleInt_StylePropertyId = new(this, "GetStyleInt", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_GetStyleInt_StylePropertyId.SetBelong(this.instance);
				}
				return r_GetStyleInt_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_GetStyleColor_StylePropertyId;
		public virtual RMethod RGetStyleColor_StylePropertyId
		{
			get
			{
				if(r_GetStyleColor_StylePropertyId == null)
				{
					r_GetStyleColor_StylePropertyId = new(this, "GetStyleColor", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_GetStyleColor_StylePropertyId.SetBelong(this.instance);
				}
				return r_GetStyleColor_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackground GetStyleBackground(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_GetStyleBackground_StylePropertyId;
		public virtual RMethod RGetStyleBackground_StylePropertyId
		{
			get
			{
				if(r_GetStyleBackground_StylePropertyId == null)
				{
					r_GetStyleBackground_StylePropertyId = new(this, "GetStyleBackground", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_GetStyleBackground_StylePropertyId.SetBelong(this.instance);
				}
				return r_GetStyleBackground_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundPosition GetStyleBackgroundPosition(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_GetStyleBackgroundPosition_StylePropertyId;
		public virtual RMethod RGetStyleBackgroundPosition_StylePropertyId
		{
			get
			{
				if(r_GetStyleBackgroundPosition_StylePropertyId == null)
				{
					r_GetStyleBackgroundPosition_StylePropertyId = new(this, "GetStyleBackgroundPosition", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_GetStyleBackgroundPosition_StylePropertyId.SetBelong(this.instance);
				}
				return r_GetStyleBackgroundPosition_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundRepeat GetStyleBackgroundRepeat(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_GetStyleBackgroundRepeat_StylePropertyId;
		public virtual RMethod RGetStyleBackgroundRepeat_StylePropertyId
		{
			get
			{
				if(r_GetStyleBackgroundRepeat_StylePropertyId == null)
				{
					r_GetStyleBackgroundRepeat_StylePropertyId = new(this, "GetStyleBackgroundRepeat", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_GetStyleBackgroundRepeat_StylePropertyId.SetBelong(this.instance);
				}
				return r_GetStyleBackgroundRepeat_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFont GetStyleFont(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_GetStyleFont_StylePropertyId;
		public virtual RMethod RGetStyleFont_StylePropertyId
		{
			get
			{
				if(r_GetStyleFont_StylePropertyId == null)
				{
					r_GetStyleFont_StylePropertyId = new(this, "GetStyleFont", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_GetStyleFont_StylePropertyId.SetBelong(this.instance);
				}
				return r_GetStyleFont_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFontDefinition GetStyleFontDefinition(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_GetStyleFontDefinition_StylePropertyId;
		public virtual RMethod RGetStyleFontDefinition_StylePropertyId
		{
			get
			{
				if(r_GetStyleFontDefinition_StylePropertyId == null)
				{
					r_GetStyleFontDefinition_StylePropertyId = new(this, "GetStyleFontDefinition", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_GetStyleFontDefinition_StylePropertyId.SetBelong(this.instance);
				}
				return r_GetStyleFontDefinition_StylePropertyId;
			}
		}

		/// <summary>
		/// Boolean TryGetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleSheets.StyleValue ByRef)
		/// </summary>
		protected RMethod r_TryGetStyleValue_StylePropertyId_Ref_StyleValue;
		public virtual RMethod RTryGetStyleValue_StylePropertyId_Ref_StyleValue
		{
			get
			{
				if(r_TryGetStyleValue_StylePropertyId_Ref_StyleValue == null)
				{
					r_TryGetStyleValue_StylePropertyId_Ref_StyleValue = new(this, "TryGetStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValue").MakeByRefType());
					r_TryGetStyleValue_StylePropertyId_Ref_StyleValue.SetBelong(this.instance);
				}
				return r_TryGetStyleValue_StylePropertyId_Ref_StyleValue;
			}
		}

		/// <summary>
		/// Void SetStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue)
		/// </summary>
		protected RMethod r_SetStyleValue_StyleValue;
		public virtual RMethod RSetStyleValue_StyleValue
		{
			get
			{
				if(r_SetStyleValue_StyleValue == null)
				{
					r_SetStyleValue_StyleValue = new(this, "SetStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValue"));
					r_SetStyleValue_StyleValue.SetBelong(this.instance);
				}
				return r_SetStyleValue_StyleValue;
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
