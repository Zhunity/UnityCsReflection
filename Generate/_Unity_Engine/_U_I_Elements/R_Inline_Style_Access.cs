
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.InlineStyleAccess
	/// </summary>
    public partial class RInlineStyleAccess : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.InlineStyleAccess");
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


		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyReader s_StylePropertyReader
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader r_Fs_StylePropertyReader;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader RFs_StylePropertyReader
		{
			get
			{
				if(r_Fs_StylePropertyReader == null)
				{
					r_Fs_StylePropertyReader = new(Type, "s_StylePropertyReader");
				}
				return r_Fs_StylePropertyReader;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheets.StyleValueManaged] m_ValuesManaged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleValueManaged> r_Fm_ValuesManaged;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleValueManaged> RFm_ValuesManaged
		{
			get
			{
				if(r_Fm_ValuesManaged == null)
				{
					r_Fm_ValuesManaged = new(this, "m_ValuesManaged");
				}
				return r_Fm_ValuesManaged;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement <ve>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_F__0__ve__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RF__0__ve__1__k__BackingField
		{
			get
			{
				if(r_F__0__ve__1__k__BackingField == null)
				{
					r_F__0__ve__1__k__BackingField = new(this, "<ve>k__BackingField");
				}
				return r_F__0__ve__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean m_HasInlineCursor
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_HasInlineCursor;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_HasInlineCursor
		{
			get
			{
				if(r_Fm_HasInlineCursor == null)
				{
					r_Fm_HasInlineCursor = new(this, "m_HasInlineCursor");
				}
				return r_Fm_HasInlineCursor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleCursor m_InlineCursor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleCursor r_Fm_InlineCursor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleCursor RFm_InlineCursor
		{
			get
			{
				if(r_Fm_InlineCursor == null)
				{
					r_Fm_InlineCursor = new(this, "m_InlineCursor");
				}
				return r_Fm_InlineCursor;
			}
		}

		/// <summary>
		/// System.Boolean m_HasInlineTextShadow
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_HasInlineTextShadow;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_HasInlineTextShadow
		{
			get
			{
				if(r_Fm_HasInlineTextShadow == null)
				{
					r_Fm_HasInlineTextShadow = new(this, "m_HasInlineTextShadow");
				}
				return r_Fm_HasInlineTextShadow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleTextShadow m_InlineTextShadow
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleTextShadow r_Fm_InlineTextShadow;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleTextShadow RFm_InlineTextShadow
		{
			get
			{
				if(r_Fm_InlineTextShadow == null)
				{
					r_Fm_InlineTextShadow = new(this, "m_InlineTextShadow");
				}
				return r_Fm_InlineTextShadow;
			}
		}

		/// <summary>
		/// System.Boolean m_HasInlineTransformOrigin
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_HasInlineTransformOrigin;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_HasInlineTransformOrigin
		{
			get
			{
				if(r_Fm_HasInlineTransformOrigin == null)
				{
					r_Fm_HasInlineTransformOrigin = new(this, "m_HasInlineTransformOrigin");
				}
				return r_Fm_HasInlineTransformOrigin;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleTransformOrigin m_InlineTransformOrigin
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleTransformOrigin r_Fm_InlineTransformOrigin;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleTransformOrigin RFm_InlineTransformOrigin
		{
			get
			{
				if(r_Fm_InlineTransformOrigin == null)
				{
					r_Fm_InlineTransformOrigin = new(this, "m_InlineTransformOrigin");
				}
				return r_Fm_InlineTransformOrigin;
			}
		}

		/// <summary>
		/// System.Boolean m_HasInlineTranslate
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_HasInlineTranslate;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_HasInlineTranslate
		{
			get
			{
				if(r_Fm_HasInlineTranslate == null)
				{
					r_Fm_HasInlineTranslate = new(this, "m_HasInlineTranslate");
				}
				return r_Fm_HasInlineTranslate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleTranslate m_InlineTranslateOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleTranslate r_Fm_InlineTranslateOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleTranslate RFm_InlineTranslateOperation
		{
			get
			{
				if(r_Fm_InlineTranslateOperation == null)
				{
					r_Fm_InlineTranslateOperation = new(this, "m_InlineTranslateOperation");
				}
				return r_Fm_InlineTranslateOperation;
			}
		}

		/// <summary>
		/// System.Boolean m_HasInlineRotate
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_HasInlineRotate;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_HasInlineRotate
		{
			get
			{
				if(r_Fm_HasInlineRotate == null)
				{
					r_Fm_HasInlineRotate = new(this, "m_HasInlineRotate");
				}
				return r_Fm_HasInlineRotate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleRotate m_InlineRotateOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleRotate r_Fm_InlineRotateOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleRotate RFm_InlineRotateOperation
		{
			get
			{
				if(r_Fm_InlineRotateOperation == null)
				{
					r_Fm_InlineRotateOperation = new(this, "m_InlineRotateOperation");
				}
				return r_Fm_InlineRotateOperation;
			}
		}

		/// <summary>
		/// System.Boolean m_HasInlineScale
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_HasInlineScale;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_HasInlineScale
		{
			get
			{
				if(r_Fm_HasInlineScale == null)
				{
					r_Fm_HasInlineScale = new(this, "m_HasInlineScale");
				}
				return r_Fm_HasInlineScale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleScale m_InlineScale
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleScale r_Fm_InlineScale;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleScale RFm_InlineScale
		{
			get
			{
				if(r_Fm_InlineScale == null)
				{
					r_Fm_InlineScale = new(this, "m_InlineScale");
				}
				return r_Fm_InlineScale;
			}
		}

		/// <summary>
		/// System.Boolean m_HasInlineBackgroundSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_HasInlineBackgroundSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_HasInlineBackgroundSize
		{
			get
			{
				if(r_Fm_HasInlineBackgroundSize == null)
				{
					r_Fm_HasInlineBackgroundSize = new(this, "m_HasInlineBackgroundSize");
				}
				return r_Fm_HasInlineBackgroundSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundSize m_InlineBackgroundSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleBackgroundSize r_Fm_InlineBackgroundSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleBackgroundSize RFm_InlineBackgroundSize
		{
			get
			{
				if(r_Fm_InlineBackgroundSize == null)
				{
					r_Fm_InlineBackgroundSize = new(this, "m_InlineBackgroundSize");
				}
				return r_Fm_InlineBackgroundSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.InlineStyleAccess+InlineRule m_InlineRule
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RInlineStyleAccess.RInlineRule r_Fm_InlineRule;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RInlineStyleAccess.RInlineRule RFm_InlineRule
		{
			get
			{
				if(r_Fm_InlineRule == null)
				{
					r_Fm_InlineRule = new(this, "m_InlineRule");
				}
				return r_Fm_InlineRule;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheets.StyleValue] m_Values
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleValue> r_Fm_Values;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleValue> RFm_Values
		{
			get
			{
				if(r_Fm_Values == null)
				{
					r_Fm_Values = new(this, "m_Values");
				}
				return r_Fm_Values;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Align] UnityEngine.UIElements.IStyle.alignContent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign> r_PUnityEngine__2__UIElements__2__IStyle__2__alignContent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign> RPUnityEngine__2__UIElements__2__IStyle__2__alignContent
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__alignContent == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__alignContent = new(this, "UnityEngine.UIElements.IStyle.alignContent", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__alignContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Align] UnityEngine.UIElements.IStyle.alignItems
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign> r_PUnityEngine__2__UIElements__2__IStyle__2__alignItems;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign> RPUnityEngine__2__UIElements__2__IStyle__2__alignItems
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__alignItems == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__alignItems = new(this, "UnityEngine.UIElements.IStyle.alignItems", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__alignItems;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Align] UnityEngine.UIElements.IStyle.alignSelf
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign> r_PUnityEngine__2__UIElements__2__IStyle__2__alignSelf;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign> RPUnityEngine__2__UIElements__2__IStyle__2__alignSelf
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__alignSelf == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__alignSelf = new(this, "UnityEngine.UIElements.IStyle.alignSelf", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__alignSelf;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor UnityEngine.UIElements.IStyle.backgroundColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor r_PUnityEngine__2__UIElements__2__IStyle__2__backgroundColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor RPUnityEngine__2__UIElements__2__IStyle__2__backgroundColor
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__backgroundColor == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__backgroundColor = new(this, "UnityEngine.UIElements.IStyle.backgroundColor", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__backgroundColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackground UnityEngine.UIElements.IStyle.backgroundImage
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleBackground r_PUnityEngine__2__UIElements__2__IStyle__2__backgroundImage;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleBackground RPUnityEngine__2__UIElements__2__IStyle__2__backgroundImage
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__backgroundImage == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__backgroundImage = new(this, "UnityEngine.UIElements.IStyle.backgroundImage", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__backgroundImage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundPosition UnityEngine.UIElements.IStyle.backgroundPositionX
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleBackgroundPosition r_PUnityEngine__2__UIElements__2__IStyle__2__backgroundPositionX;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleBackgroundPosition RPUnityEngine__2__UIElements__2__IStyle__2__backgroundPositionX
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__backgroundPositionX == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__backgroundPositionX = new(this, "UnityEngine.UIElements.IStyle.backgroundPositionX", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__backgroundPositionX;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundPosition UnityEngine.UIElements.IStyle.backgroundPositionY
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleBackgroundPosition r_PUnityEngine__2__UIElements__2__IStyle__2__backgroundPositionY;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleBackgroundPosition RPUnityEngine__2__UIElements__2__IStyle__2__backgroundPositionY
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__backgroundPositionY == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__backgroundPositionY = new(this, "UnityEngine.UIElements.IStyle.backgroundPositionY", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__backgroundPositionY;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundRepeat UnityEngine.UIElements.IStyle.backgroundRepeat
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleBackgroundRepeat r_PUnityEngine__2__UIElements__2__IStyle__2__backgroundRepeat;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleBackgroundRepeat RPUnityEngine__2__UIElements__2__IStyle__2__backgroundRepeat
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__backgroundRepeat == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__backgroundRepeat = new(this, "UnityEngine.UIElements.IStyle.backgroundRepeat", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__backgroundRepeat;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor UnityEngine.UIElements.IStyle.borderBottomColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor r_PUnityEngine__2__UIElements__2__IStyle__2__borderBottomColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor RPUnityEngine__2__UIElements__2__IStyle__2__borderBottomColor
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__borderBottomColor == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__borderBottomColor = new(this, "UnityEngine.UIElements.IStyle.borderBottomColor", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__borderBottomColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.borderBottomLeftRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__borderBottomLeftRadius;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__borderBottomLeftRadius
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__borderBottomLeftRadius == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__borderBottomLeftRadius = new(this, "UnityEngine.UIElements.IStyle.borderBottomLeftRadius", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__borderBottomLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.borderBottomRightRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__borderBottomRightRadius;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__borderBottomRightRadius
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__borderBottomRightRadius == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__borderBottomRightRadius = new(this, "UnityEngine.UIElements.IStyle.borderBottomRightRadius", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__borderBottomRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.borderBottomWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PUnityEngine__2__UIElements__2__IStyle__2__borderBottomWidth;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPUnityEngine__2__UIElements__2__IStyle__2__borderBottomWidth
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__borderBottomWidth == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__borderBottomWidth = new(this, "UnityEngine.UIElements.IStyle.borderBottomWidth", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__borderBottomWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor UnityEngine.UIElements.IStyle.borderLeftColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor r_PUnityEngine__2__UIElements__2__IStyle__2__borderLeftColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor RPUnityEngine__2__UIElements__2__IStyle__2__borderLeftColor
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__borderLeftColor == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__borderLeftColor = new(this, "UnityEngine.UIElements.IStyle.borderLeftColor", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__borderLeftColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.borderLeftWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PUnityEngine__2__UIElements__2__IStyle__2__borderLeftWidth;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPUnityEngine__2__UIElements__2__IStyle__2__borderLeftWidth
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__borderLeftWidth == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__borderLeftWidth = new(this, "UnityEngine.UIElements.IStyle.borderLeftWidth", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__borderLeftWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor UnityEngine.UIElements.IStyle.borderRightColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor r_PUnityEngine__2__UIElements__2__IStyle__2__borderRightColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor RPUnityEngine__2__UIElements__2__IStyle__2__borderRightColor
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__borderRightColor == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__borderRightColor = new(this, "UnityEngine.UIElements.IStyle.borderRightColor", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__borderRightColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.borderRightWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PUnityEngine__2__UIElements__2__IStyle__2__borderRightWidth;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPUnityEngine__2__UIElements__2__IStyle__2__borderRightWidth
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__borderRightWidth == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__borderRightWidth = new(this, "UnityEngine.UIElements.IStyle.borderRightWidth", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__borderRightWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor UnityEngine.UIElements.IStyle.borderTopColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor r_PUnityEngine__2__UIElements__2__IStyle__2__borderTopColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor RPUnityEngine__2__UIElements__2__IStyle__2__borderTopColor
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__borderTopColor == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__borderTopColor = new(this, "UnityEngine.UIElements.IStyle.borderTopColor", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__borderTopColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.borderTopLeftRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__borderTopLeftRadius;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__borderTopLeftRadius
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__borderTopLeftRadius == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__borderTopLeftRadius = new(this, "UnityEngine.UIElements.IStyle.borderTopLeftRadius", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__borderTopLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.borderTopRightRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__borderTopRightRadius;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__borderTopRightRadius
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__borderTopRightRadius == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__borderTopRightRadius = new(this, "UnityEngine.UIElements.IStyle.borderTopRightRadius", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__borderTopRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.borderTopWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PUnityEngine__2__UIElements__2__IStyle__2__borderTopWidth;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPUnityEngine__2__UIElements__2__IStyle__2__borderTopWidth
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__borderTopWidth == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__borderTopWidth = new(this, "UnityEngine.UIElements.IStyle.borderTopWidth", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__borderTopWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.bottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__bottom;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__bottom
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__bottom == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__bottom = new(this, "UnityEngine.UIElements.IStyle.bottom", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__bottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor UnityEngine.UIElements.IStyle.color
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor r_PUnityEngine__2__UIElements__2__IStyle__2__color;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor RPUnityEngine__2__UIElements__2__IStyle__2__color
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__color == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__color = new(this, "UnityEngine.UIElements.IStyle.color", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__color;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.DisplayStyle] UnityEngine.UIElements.IStyle.display
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDisplayStyle> r_PUnityEngine__2__UIElements__2__IStyle__2__display;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDisplayStyle> RPUnityEngine__2__UIElements__2__IStyle__2__display
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__display == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__display = new(this, "UnityEngine.UIElements.IStyle.display", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__display;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.flexBasis
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__flexBasis;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__flexBasis
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__flexBasis == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__flexBasis = new(this, "UnityEngine.UIElements.IStyle.flexBasis", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__flexBasis;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.FlexDirection] UnityEngine.UIElements.IStyle.flexDirection
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFlexDirection> r_PUnityEngine__2__UIElements__2__IStyle__2__flexDirection;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFlexDirection> RPUnityEngine__2__UIElements__2__IStyle__2__flexDirection
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__flexDirection == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__flexDirection = new(this, "UnityEngine.UIElements.IStyle.flexDirection", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__flexDirection;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.flexGrow
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PUnityEngine__2__UIElements__2__IStyle__2__flexGrow;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPUnityEngine__2__UIElements__2__IStyle__2__flexGrow
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__flexGrow == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__flexGrow = new(this, "UnityEngine.UIElements.IStyle.flexGrow", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__flexGrow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.flexShrink
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PUnityEngine__2__UIElements__2__IStyle__2__flexShrink;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPUnityEngine__2__UIElements__2__IStyle__2__flexShrink
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__flexShrink == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__flexShrink = new(this, "UnityEngine.UIElements.IStyle.flexShrink", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__flexShrink;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Wrap] UnityEngine.UIElements.IStyle.flexWrap
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RWrap> r_PUnityEngine__2__UIElements__2__IStyle__2__flexWrap;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RWrap> RPUnityEngine__2__UIElements__2__IStyle__2__flexWrap
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__flexWrap == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__flexWrap = new(this, "UnityEngine.UIElements.IStyle.flexWrap", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__flexWrap;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.fontSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__fontSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__fontSize
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__fontSize == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__fontSize = new(this, "UnityEngine.UIElements.IStyle.fontSize", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__fontSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.height
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__height;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__height
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__height == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__height = new(this, "UnityEngine.UIElements.IStyle.height", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__height;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Justify] UnityEngine.UIElements.IStyle.justifyContent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RJustify> r_PUnityEngine__2__UIElements__2__IStyle__2__justifyContent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RJustify> RPUnityEngine__2__UIElements__2__IStyle__2__justifyContent
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__justifyContent == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__justifyContent = new(this, "UnityEngine.UIElements.IStyle.justifyContent", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__justifyContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.left
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__left;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__left
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__left == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__left = new(this, "UnityEngine.UIElements.IStyle.left", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__left;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.letterSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__letterSpacing;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__letterSpacing
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__letterSpacing == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__letterSpacing = new(this, "UnityEngine.UIElements.IStyle.letterSpacing", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__letterSpacing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.marginBottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__marginBottom;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__marginBottom
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__marginBottom == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__marginBottom = new(this, "UnityEngine.UIElements.IStyle.marginBottom", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__marginBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.marginLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__marginLeft;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__marginLeft
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__marginLeft == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__marginLeft = new(this, "UnityEngine.UIElements.IStyle.marginLeft", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__marginLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.marginRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__marginRight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__marginRight
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__marginRight == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__marginRight = new(this, "UnityEngine.UIElements.IStyle.marginRight", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__marginRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.marginTop
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__marginTop;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__marginTop
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__marginTop == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__marginTop = new(this, "UnityEngine.UIElements.IStyle.marginTop", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__marginTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.maxHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__maxHeight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__maxHeight
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__maxHeight == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__maxHeight = new(this, "UnityEngine.UIElements.IStyle.maxHeight", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__maxHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.maxWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__maxWidth;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__maxWidth
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__maxWidth == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__maxWidth = new(this, "UnityEngine.UIElements.IStyle.maxWidth", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__maxWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.minHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__minHeight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__minHeight
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__minHeight == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__minHeight = new(this, "UnityEngine.UIElements.IStyle.minHeight", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__minHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.minWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__minWidth;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__minWidth
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__minWidth == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__minWidth = new(this, "UnityEngine.UIElements.IStyle.minWidth", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__minWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.opacity
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PUnityEngine__2__UIElements__2__IStyle__2__opacity;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPUnityEngine__2__UIElements__2__IStyle__2__opacity
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__opacity == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__opacity = new(this, "UnityEngine.UIElements.IStyle.opacity", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__opacity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Overflow] UnityEngine.UIElements.IStyle.overflow
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.ROverflow> r_PUnityEngine__2__UIElements__2__IStyle__2__overflow;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.ROverflow> RPUnityEngine__2__UIElements__2__IStyle__2__overflow
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__overflow == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__overflow = new(this, "UnityEngine.UIElements.IStyle.overflow", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__overflow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.paddingBottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__paddingBottom;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__paddingBottom
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__paddingBottom == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__paddingBottom = new(this, "UnityEngine.UIElements.IStyle.paddingBottom", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__paddingBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.paddingLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__paddingLeft;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__paddingLeft
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__paddingLeft == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__paddingLeft = new(this, "UnityEngine.UIElements.IStyle.paddingLeft", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__paddingLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.paddingRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__paddingRight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__paddingRight
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__paddingRight == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__paddingRight = new(this, "UnityEngine.UIElements.IStyle.paddingRight", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__paddingRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.paddingTop
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__paddingTop;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__paddingTop
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__paddingTop == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__paddingTop = new(this, "UnityEngine.UIElements.IStyle.paddingTop", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__paddingTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Position] UnityEngine.UIElements.IStyle.position
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPosition> r_PUnityEngine__2__UIElements__2__IStyle__2__position;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPosition> RPUnityEngine__2__UIElements__2__IStyle__2__position
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__position == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__position = new(this, "UnityEngine.UIElements.IStyle.position", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__position;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.right
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__right;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__right
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__right == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__right = new(this, "UnityEngine.UIElements.IStyle.right", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__right;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.TextOverflow] UnityEngine.UIElements.IStyle.textOverflow
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextOverflow> r_PUnityEngine__2__UIElements__2__IStyle__2__textOverflow;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextOverflow> RPUnityEngine__2__UIElements__2__IStyle__2__textOverflow
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__textOverflow == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__textOverflow = new(this, "UnityEngine.UIElements.IStyle.textOverflow", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__textOverflow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.top
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__top;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__top
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__top == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__top = new(this, "UnityEngine.UIElements.IStyle.top", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__top;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[UnityEngine.UIElements.TimeValue] UnityEngine.UIElements.IStyle.transitionDelay
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeValue> r_PUnityEngine__2__UIElements__2__IStyle__2__transitionDelay;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeValue> RPUnityEngine__2__UIElements__2__IStyle__2__transitionDelay
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__transitionDelay == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__transitionDelay = new(this, "UnityEngine.UIElements.IStyle.transitionDelay", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__transitionDelay;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[UnityEngine.UIElements.TimeValue] UnityEngine.UIElements.IStyle.transitionDuration
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeValue> r_PUnityEngine__2__UIElements__2__IStyle__2__transitionDuration;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeValue> RPUnityEngine__2__UIElements__2__IStyle__2__transitionDuration
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__transitionDuration == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__transitionDuration = new(this, "UnityEngine.UIElements.IStyle.transitionDuration", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__transitionDuration;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[UnityEngine.UIElements.StylePropertyName] UnityEngine.UIElements.IStyle.transitionProperty
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStylePropertyName> r_PUnityEngine__2__UIElements__2__IStyle__2__transitionProperty;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStylePropertyName> RPUnityEngine__2__UIElements__2__IStyle__2__transitionProperty
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__transitionProperty == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__transitionProperty = new(this, "UnityEngine.UIElements.IStyle.transitionProperty", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__transitionProperty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[UnityEngine.UIElements.EasingFunction] UnityEngine.UIElements.IStyle.transitionTimingFunction
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REasingFunction> r_PUnityEngine__2__UIElements__2__IStyle__2__transitionTimingFunction;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REasingFunction> RPUnityEngine__2__UIElements__2__IStyle__2__transitionTimingFunction
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__transitionTimingFunction == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__transitionTimingFunction = new(this, "UnityEngine.UIElements.IStyle.transitionTimingFunction", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__transitionTimingFunction;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor UnityEngine.UIElements.IStyle.unityBackgroundImageTintColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor r_PUnityEngine__2__UIElements__2__IStyle__2__unityBackgroundImageTintColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor RPUnityEngine__2__UIElements__2__IStyle__2__unityBackgroundImageTintColor
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__unityBackgroundImageTintColor == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__unityBackgroundImageTintColor = new(this, "UnityEngine.UIElements.IStyle.unityBackgroundImageTintColor", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__unityBackgroundImageTintColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFont UnityEngine.UIElements.IStyle.unityFont
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFont r_PUnityEngine__2__UIElements__2__IStyle__2__unityFont;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFont RPUnityEngine__2__UIElements__2__IStyle__2__unityFont
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__unityFont == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__unityFont = new(this, "UnityEngine.UIElements.IStyle.unityFont", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__unityFont;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFontDefinition UnityEngine.UIElements.IStyle.unityFontDefinition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFontDefinition r_PUnityEngine__2__UIElements__2__IStyle__2__unityFontDefinition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFontDefinition RPUnityEngine__2__UIElements__2__IStyle__2__unityFontDefinition
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__unityFontDefinition == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__unityFontDefinition = new(this, "UnityEngine.UIElements.IStyle.unityFontDefinition", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__unityFontDefinition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.FontStyle] UnityEngine.UIElements.IStyle.unityFontStyleAndWeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RFontStyle> r_PUnityEngine__2__UIElements__2__IStyle__2__unityFontStyleAndWeight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RFontStyle> RPUnityEngine__2__UIElements__2__IStyle__2__unityFontStyleAndWeight
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__unityFontStyleAndWeight == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__unityFontStyleAndWeight = new(this, "UnityEngine.UIElements.IStyle.unityFontStyleAndWeight", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__unityFontStyleAndWeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.OverflowClipBox] UnityEngine.UIElements.IStyle.unityOverflowClipBox
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.ROverflowClipBox> r_PUnityEngine__2__UIElements__2__IStyle__2__unityOverflowClipBox;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.ROverflowClipBox> RPUnityEngine__2__UIElements__2__IStyle__2__unityOverflowClipBox
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__unityOverflowClipBox == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__unityOverflowClipBox = new(this, "UnityEngine.UIElements.IStyle.unityOverflowClipBox", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__unityOverflowClipBox;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.unityParagraphSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__unityParagraphSpacing;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__unityParagraphSpacing
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__unityParagraphSpacing == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__unityParagraphSpacing = new(this, "UnityEngine.UIElements.IStyle.unityParagraphSpacing", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__unityParagraphSpacing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt UnityEngine.UIElements.IStyle.unitySliceBottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleInt r_PUnityEngine__2__UIElements__2__IStyle__2__unitySliceBottom;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleInt RPUnityEngine__2__UIElements__2__IStyle__2__unitySliceBottom
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__unitySliceBottom == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__unitySliceBottom = new(this, "UnityEngine.UIElements.IStyle.unitySliceBottom", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__unitySliceBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt UnityEngine.UIElements.IStyle.unitySliceLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleInt r_PUnityEngine__2__UIElements__2__IStyle__2__unitySliceLeft;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleInt RPUnityEngine__2__UIElements__2__IStyle__2__unitySliceLeft
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__unitySliceLeft == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__unitySliceLeft = new(this, "UnityEngine.UIElements.IStyle.unitySliceLeft", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__unitySliceLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt UnityEngine.UIElements.IStyle.unitySliceRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleInt r_PUnityEngine__2__UIElements__2__IStyle__2__unitySliceRight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleInt RPUnityEngine__2__UIElements__2__IStyle__2__unitySliceRight
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__unitySliceRight == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__unitySliceRight = new(this, "UnityEngine.UIElements.IStyle.unitySliceRight", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__unitySliceRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.unitySliceScale
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PUnityEngine__2__UIElements__2__IStyle__2__unitySliceScale;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPUnityEngine__2__UIElements__2__IStyle__2__unitySliceScale
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__unitySliceScale == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__unitySliceScale = new(this, "UnityEngine.UIElements.IStyle.unitySliceScale", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__unitySliceScale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt UnityEngine.UIElements.IStyle.unitySliceTop
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleInt r_PUnityEngine__2__UIElements__2__IStyle__2__unitySliceTop;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleInt RPUnityEngine__2__UIElements__2__IStyle__2__unitySliceTop
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__unitySliceTop == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__unitySliceTop = new(this, "UnityEngine.UIElements.IStyle.unitySliceTop", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__unitySliceTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.TextAnchor] UnityEngine.UIElements.IStyle.unityTextAlign
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RTextAnchor> r_PUnityEngine__2__UIElements__2__IStyle__2__unityTextAlign;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RTextAnchor> RPUnityEngine__2__UIElements__2__IStyle__2__unityTextAlign
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__unityTextAlign == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__unityTextAlign = new(this, "UnityEngine.UIElements.IStyle.unityTextAlign", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__unityTextAlign;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor UnityEngine.UIElements.IStyle.unityTextOutlineColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor r_PUnityEngine__2__UIElements__2__IStyle__2__unityTextOutlineColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor RPUnityEngine__2__UIElements__2__IStyle__2__unityTextOutlineColor
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__unityTextOutlineColor == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__unityTextOutlineColor = new(this, "UnityEngine.UIElements.IStyle.unityTextOutlineColor", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__unityTextOutlineColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IStyle.unityTextOutlineWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PUnityEngine__2__UIElements__2__IStyle__2__unityTextOutlineWidth;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPUnityEngine__2__UIElements__2__IStyle__2__unityTextOutlineWidth
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__unityTextOutlineWidth == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__unityTextOutlineWidth = new(this, "UnityEngine.UIElements.IStyle.unityTextOutlineWidth", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__unityTextOutlineWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.TextOverflowPosition] UnityEngine.UIElements.IStyle.unityTextOverflowPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextOverflowPosition> r_PUnityEngine__2__UIElements__2__IStyle__2__unityTextOverflowPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextOverflowPosition> RPUnityEngine__2__UIElements__2__IStyle__2__unityTextOverflowPosition
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__unityTextOverflowPosition == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__unityTextOverflowPosition = new(this, "UnityEngine.UIElements.IStyle.unityTextOverflowPosition", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__unityTextOverflowPosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Visibility] UnityEngine.UIElements.IStyle.visibility
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisibility> r_PUnityEngine__2__UIElements__2__IStyle__2__visibility;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisibility> RPUnityEngine__2__UIElements__2__IStyle__2__visibility
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__visibility == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__visibility = new(this, "UnityEngine.UIElements.IStyle.visibility", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__visibility;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.WhiteSpace] UnityEngine.UIElements.IStyle.whiteSpace
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RWhiteSpace> r_PUnityEngine__2__UIElements__2__IStyle__2__whiteSpace;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RWhiteSpace> RPUnityEngine__2__UIElements__2__IStyle__2__whiteSpace
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__whiteSpace == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__whiteSpace = new(this, "UnityEngine.UIElements.IStyle.whiteSpace", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__whiteSpace;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.width
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__width;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__width
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__width == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__width = new(this, "UnityEngine.UIElements.IStyle.width", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__width;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.wordSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PUnityEngine__2__UIElements__2__IStyle__2__wordSpacing;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPUnityEngine__2__UIElements__2__IStyle__2__wordSpacing
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__wordSpacing == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__wordSpacing = new(this, "UnityEngine.UIElements.IStyle.wordSpacing", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__wordSpacing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement ve
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Pve;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPve
		{
			get
			{
				if(r_Pve == null)
				{
					r_Pve = new(this, "ve", -1);
				}
				return r_Pve;
			}
		}

		/// <summary>
		/// InlineRule inlineRule
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RInlineStyleAccess.RInlineRule r_PinlineRule;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RInlineStyleAccess.RInlineRule RPinlineRule
		{
			get
			{
				if(r_PinlineRule == null)
				{
					r_PinlineRule = new(this, "inlineRule", -1);
				}
				return r_PinlineRule;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleCursor UnityEngine.UIElements.IStyle.cursor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleCursor r_PUnityEngine__2__UIElements__2__IStyle__2__cursor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleCursor RPUnityEngine__2__UIElements__2__IStyle__2__cursor
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__cursor == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__cursor = new(this, "UnityEngine.UIElements.IStyle.cursor", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__cursor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleTextShadow UnityEngine.UIElements.IStyle.textShadow
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleTextShadow r_PUnityEngine__2__UIElements__2__IStyle__2__textShadow;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleTextShadow RPUnityEngine__2__UIElements__2__IStyle__2__textShadow
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__textShadow == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__textShadow = new(this, "UnityEngine.UIElements.IStyle.textShadow", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__textShadow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundSize UnityEngine.UIElements.IStyle.backgroundSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleBackgroundSize r_PUnityEngine__2__UIElements__2__IStyle__2__backgroundSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleBackgroundSize RPUnityEngine__2__UIElements__2__IStyle__2__backgroundSize
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__backgroundSize == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__backgroundSize = new(this, "UnityEngine.UIElements.IStyle.backgroundSize", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__backgroundSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleTransformOrigin UnityEngine.UIElements.IStyle.transformOrigin
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleTransformOrigin r_PUnityEngine__2__UIElements__2__IStyle__2__transformOrigin;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleTransformOrigin RPUnityEngine__2__UIElements__2__IStyle__2__transformOrigin
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__transformOrigin == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__transformOrigin = new(this, "UnityEngine.UIElements.IStyle.transformOrigin", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__transformOrigin;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleTranslate UnityEngine.UIElements.IStyle.translate
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleTranslate r_PUnityEngine__2__UIElements__2__IStyle__2__translate;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleTranslate RPUnityEngine__2__UIElements__2__IStyle__2__translate
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__translate == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__translate = new(this, "UnityEngine.UIElements.IStyle.translate", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__translate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleRotate UnityEngine.UIElements.IStyle.rotate
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleRotate r_PUnityEngine__2__UIElements__2__IStyle__2__rotate;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleRotate RPUnityEngine__2__UIElements__2__IStyle__2__rotate
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__rotate == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__rotate = new(this, "UnityEngine.UIElements.IStyle.rotate", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__rotate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleScale UnityEngine.UIElements.IStyle.scale
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleScale r_PUnityEngine__2__UIElements__2__IStyle__2__scale;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleScale RPUnityEngine__2__UIElements__2__IStyle__2__scale
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__scale == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__scale = new(this, "UnityEngine.UIElements.IStyle.scale", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__scale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.ScaleMode] UnityEngine.UIElements.IStyle.unityBackgroundScaleMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RScaleMode> r_PUnityEngine__2__UIElements__2__IStyle__2__unityBackgroundScaleMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RScaleMode> RPUnityEngine__2__UIElements__2__IStyle__2__unityBackgroundScaleMode
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStyle__2__unityBackgroundScaleMode == null)
				{
					r_PUnityEngine__2__UIElements__2__IStyle__2__unityBackgroundScaleMode = new(this, "UnityEngine.UIElements.IStyle.unityBackgroundScaleMode", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStyle__2__unityBackgroundScaleMode;
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
		/// Void SetInlineRule(UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleRule)
		/// </summary>
		protected RMethod r_MSetInlineRule_StyleSheet_StyleRule;
		public virtual RMethod RMSetInlineRule_StyleSheet_StyleRule
		{
			get
			{
				if(r_MSetInlineRule_StyleSheet_StyleRule == null)
				{
					r_MSetInlineRule_StyleSheet_StyleRule = new(this, "SetInlineRule", 0, typeof(UnityEngine.UIElements.StyleSheet),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleRule"));
				}
				return r_MSetInlineRule_StyleSheet_StyleRule;
			}
		}

		/// <summary>
		/// Boolean IsValueSet(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_MIsValueSet_StylePropertyId;
		public virtual RMethod RMIsValueSet_StylePropertyId
		{
			get
			{
				if(r_MIsValueSet_StylePropertyId == null)
				{
					r_MIsValueSet_StylePropertyId = new(this, "IsValueSet", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
				}
				return r_MIsValueSet_StylePropertyId;
			}
		}

		/// <summary>
		/// Void ApplyInlineStyles(UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_MApplyInlineStyles_Ref_ComputedStyle;
		public virtual RMethod RMApplyInlineStyles_Ref_ComputedStyle
		{
			get
			{
				if(r_MApplyInlineStyles_Ref_ComputedStyle == null)
				{
					r_MApplyInlineStyles_Ref_ComputedStyle = new(this, "ApplyInlineStyles", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
				}
				return r_MApplyInlineStyles_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[T] GetStyleList[T](UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_MGetStyleList_GT_StylePropertyId;
		public virtual RMethod RMGetStyleList_GT_StylePropertyId
		{
			get
			{
				if(r_MGetStyleList_GT_StylePropertyId == null)
				{
					r_MGetStyleList_GT_StylePropertyId = new(this, "GetStyleList", 1,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
				}
				return r_MGetStyleList_GT_StylePropertyId;
			}
		}

		/// <summary>
		/// Void SetStyleValueManaged(UnityEngine.UIElements.StyleSheets.StyleValueManaged)
		/// </summary>
		protected RMethod r_MSetStyleValueManaged_StyleValueManaged;
		public virtual RMethod RMSetStyleValueManaged_StyleValueManaged
		{
			get
			{
				if(r_MSetStyleValueManaged_StyleValueManaged == null)
				{
					r_MSetStyleValueManaged_StyleValueManaged = new(this, "SetStyleValueManaged", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValueManaged"));
				}
				return r_MSetStyleValueManaged_StyleValueManaged;
			}
		}

		/// <summary>
		/// Boolean TryGetStyleValueManaged(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleSheets.StyleValueManaged ByRef)
		/// </summary>
		protected RMethod r_MTryGetStyleValueManaged_StylePropertyId_Ref_StyleValueManaged;
		public virtual RMethod RMTryGetStyleValueManaged_StylePropertyId_Ref_StyleValueManaged
		{
			get
			{
				if(r_MTryGetStyleValueManaged_StylePropertyId_Ref_StyleValueManaged == null)
				{
					r_MTryGetStyleValueManaged_StylePropertyId_Ref_StyleValueManaged = new(this, "TryGetStyleValueManaged", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValueManaged").MakeByRefType());
				}
				return r_MTryGetStyleValueManaged_StylePropertyId_Ref_StyleValueManaged;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleBackgroundPosition)
		/// </summary>
		protected RMethod r_MSetStyleValue_StylePropertyId_StyleBackgroundPosition;
		public virtual RMethod RMSetStyleValue_StylePropertyId_StyleBackgroundPosition
		{
			get
			{
				if(r_MSetStyleValue_StylePropertyId_StyleBackgroundPosition == null)
				{
					r_MSetStyleValue_StylePropertyId_StyleBackgroundPosition = new(this, "SetStyleValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleBackgroundPosition));
				}
				return r_MSetStyleValue_StylePropertyId_StyleBackgroundPosition;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleBackgroundRepeat)
		/// </summary>
		protected RMethod r_MSetStyleValue_StylePropertyId_StyleBackgroundRepeat;
		public virtual RMethod RMSetStyleValue_StylePropertyId_StyleBackgroundRepeat
		{
			get
			{
				if(r_MSetStyleValue_StylePropertyId_StyleBackgroundRepeat == null)
				{
					r_MSetStyleValue_StylePropertyId_StyleBackgroundRepeat = new(this, "SetStyleValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleBackgroundRepeat));
				}
				return r_MSetStyleValue_StylePropertyId_StyleBackgroundRepeat;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleLength)
		/// </summary>
		protected RMethod r_MSetStyleValue_StylePropertyId_StyleLength;
		public virtual RMethod RMSetStyleValue_StylePropertyId_StyleLength
		{
			get
			{
				if(r_MSetStyleValue_StylePropertyId_StyleLength == null)
				{
					r_MSetStyleValue_StylePropertyId_StyleLength = new(this, "SetStyleValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleLength));
				}
				return r_MSetStyleValue_StylePropertyId_StyleLength;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleFloat)
		/// </summary>
		protected RMethod r_MSetStyleValue_StylePropertyId_StyleFloat;
		public virtual RMethod RMSetStyleValue_StylePropertyId_StyleFloat
		{
			get
			{
				if(r_MSetStyleValue_StylePropertyId_StyleFloat == null)
				{
					r_MSetStyleValue_StylePropertyId_StyleFloat = new(this, "SetStyleValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleFloat));
				}
				return r_MSetStyleValue_StylePropertyId_StyleFloat;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleInt)
		/// </summary>
		protected RMethod r_MSetStyleValue_StylePropertyId_StyleInt;
		public virtual RMethod RMSetStyleValue_StylePropertyId_StyleInt
		{
			get
			{
				if(r_MSetStyleValue_StylePropertyId_StyleInt == null)
				{
					r_MSetStyleValue_StylePropertyId_StyleInt = new(this, "SetStyleValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleInt));
				}
				return r_MSetStyleValue_StylePropertyId_StyleInt;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleColor)
		/// </summary>
		protected RMethod r_MSetStyleValue_StylePropertyId_StyleColor;
		public virtual RMethod RMSetStyleValue_StylePropertyId_StyleColor
		{
			get
			{
				if(r_MSetStyleValue_StylePropertyId_StyleColor == null)
				{
					r_MSetStyleValue_StylePropertyId_StyleColor = new(this, "SetStyleValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleColor));
				}
				return r_MSetStyleValue_StylePropertyId_StyleColor;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue[T](UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleEnum`1[T])
		/// </summary>
		protected RMethod r_MSetStyleValue_GT_StylePropertyId_StyleEnum_d_T_p_;
		public virtual RMethod RMSetStyleValue_GT_StylePropertyId_StyleEnum_d_T_p_
		{
			get
			{
				if(r_MSetStyleValue_GT_StylePropertyId_StyleEnum_d_T_p_ == null)
				{
					r_MSetStyleValue_GT_StylePropertyId_StyleEnum_d_T_p_ = new(this, "SetStyleValue", 1,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleEnum`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MSetStyleValue_GT_StylePropertyId_StyleEnum_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleBackground)
		/// </summary>
		protected RMethod r_MSetStyleValue_StylePropertyId_StyleBackground;
		public virtual RMethod RMSetStyleValue_StylePropertyId_StyleBackground
		{
			get
			{
				if(r_MSetStyleValue_StylePropertyId_StyleBackground == null)
				{
					r_MSetStyleValue_StylePropertyId_StyleBackground = new(this, "SetStyleValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleBackground));
				}
				return r_MSetStyleValue_StylePropertyId_StyleBackground;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleFontDefinition)
		/// </summary>
		protected RMethod r_MSetStyleValue_StylePropertyId_StyleFontDefinition;
		public virtual RMethod RMSetStyleValue_StylePropertyId_StyleFontDefinition
		{
			get
			{
				if(r_MSetStyleValue_StylePropertyId_StyleFontDefinition == null)
				{
					r_MSetStyleValue_StylePropertyId_StyleFontDefinition = new(this, "SetStyleValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleFontDefinition));
				}
				return r_MSetStyleValue_StylePropertyId_StyleFontDefinition;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleFont)
		/// </summary>
		protected RMethod r_MSetStyleValue_StylePropertyId_StyleFont;
		public virtual RMethod RMSetStyleValue_StylePropertyId_StyleFont
		{
			get
			{
				if(r_MSetStyleValue_StylePropertyId_StyleFont == null)
				{
					r_MSetStyleValue_StylePropertyId_StyleFont = new(this, "SetStyleValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleFont));
				}
				return r_MSetStyleValue_StylePropertyId_StyleFont;
			}
		}

		/// <summary>
		/// Boolean SetStyleValue[T](UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleList`1[T])
		/// </summary>
		protected RMethod r_MSetStyleValue_GT_StylePropertyId_StyleList_d_T_p_;
		public virtual RMethod RMSetStyleValue_GT_StylePropertyId_StyleList_d_T_p_
		{
			get
			{
				if(r_MSetStyleValue_GT_StylePropertyId_StyleList_d_T_p_ == null)
				{
					r_MSetStyleValue_GT_StylePropertyId_StyleList_d_T_p_ = new(this, "SetStyleValue", 1,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleList`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MSetStyleValue_GT_StylePropertyId_StyleList_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean SetInlineCursor(UnityEngine.UIElements.StyleCursor)
		/// </summary>
		protected RMethod r_MSetInlineCursor_StyleCursor;
		public virtual RMethod RMSetInlineCursor_StyleCursor
		{
			get
			{
				if(r_MSetInlineCursor_StyleCursor == null)
				{
					r_MSetInlineCursor_StyleCursor = new(this, "SetInlineCursor", 0, typeof(UnityEngine.UIElements.StyleCursor));
				}
				return r_MSetInlineCursor_StyleCursor;
			}
		}

		/// <summary>
		/// Void ApplyStyleCursor(UnityEngine.UIElements.StyleCursor)
		/// </summary>
		protected RMethod r_MApplyStyleCursor_StyleCursor;
		public virtual RMethod RMApplyStyleCursor_StyleCursor
		{
			get
			{
				if(r_MApplyStyleCursor_StyleCursor == null)
				{
					r_MApplyStyleCursor_StyleCursor = new(this, "ApplyStyleCursor", 0, typeof(UnityEngine.UIElements.StyleCursor));
				}
				return r_MApplyStyleCursor_StyleCursor;
			}
		}

		/// <summary>
		/// Boolean SetInlineTextShadow(UnityEngine.UIElements.StyleTextShadow)
		/// </summary>
		protected RMethod r_MSetInlineTextShadow_StyleTextShadow;
		public virtual RMethod RMSetInlineTextShadow_StyleTextShadow
		{
			get
			{
				if(r_MSetInlineTextShadow_StyleTextShadow == null)
				{
					r_MSetInlineTextShadow_StyleTextShadow = new(this, "SetInlineTextShadow", 0, typeof(UnityEngine.UIElements.StyleTextShadow));
				}
				return r_MSetInlineTextShadow_StyleTextShadow;
			}
		}

		/// <summary>
		/// Void ApplyStyleTextShadow(UnityEngine.UIElements.StyleTextShadow)
		/// </summary>
		protected RMethod r_MApplyStyleTextShadow_StyleTextShadow;
		public virtual RMethod RMApplyStyleTextShadow_StyleTextShadow
		{
			get
			{
				if(r_MApplyStyleTextShadow_StyleTextShadow == null)
				{
					r_MApplyStyleTextShadow_StyleTextShadow = new(this, "ApplyStyleTextShadow", 0, typeof(UnityEngine.UIElements.StyleTextShadow));
				}
				return r_MApplyStyleTextShadow_StyleTextShadow;
			}
		}

		/// <summary>
		/// Boolean SetInlineTransformOrigin(UnityEngine.UIElements.StyleTransformOrigin)
		/// </summary>
		protected RMethod r_MSetInlineTransformOrigin_StyleTransformOrigin;
		public virtual RMethod RMSetInlineTransformOrigin_StyleTransformOrigin
		{
			get
			{
				if(r_MSetInlineTransformOrigin_StyleTransformOrigin == null)
				{
					r_MSetInlineTransformOrigin_StyleTransformOrigin = new(this, "SetInlineTransformOrigin", 0, typeof(UnityEngine.UIElements.StyleTransformOrigin));
				}
				return r_MSetInlineTransformOrigin_StyleTransformOrigin;
			}
		}

		/// <summary>
		/// Void ApplyStyleTransformOrigin(UnityEngine.UIElements.StyleTransformOrigin)
		/// </summary>
		protected RMethod r_MApplyStyleTransformOrigin_StyleTransformOrigin;
		public virtual RMethod RMApplyStyleTransformOrigin_StyleTransformOrigin
		{
			get
			{
				if(r_MApplyStyleTransformOrigin_StyleTransformOrigin == null)
				{
					r_MApplyStyleTransformOrigin_StyleTransformOrigin = new(this, "ApplyStyleTransformOrigin", 0, typeof(UnityEngine.UIElements.StyleTransformOrigin));
				}
				return r_MApplyStyleTransformOrigin_StyleTransformOrigin;
			}
		}

		/// <summary>
		/// Boolean SetInlineTranslate(UnityEngine.UIElements.StyleTranslate)
		/// </summary>
		protected RMethod r_MSetInlineTranslate_StyleTranslate;
		public virtual RMethod RMSetInlineTranslate_StyleTranslate
		{
			get
			{
				if(r_MSetInlineTranslate_StyleTranslate == null)
				{
					r_MSetInlineTranslate_StyleTranslate = new(this, "SetInlineTranslate", 0, typeof(UnityEngine.UIElements.StyleTranslate));
				}
				return r_MSetInlineTranslate_StyleTranslate;
			}
		}

		/// <summary>
		/// Void ApplyStyleTranslate(UnityEngine.UIElements.StyleTranslate)
		/// </summary>
		protected RMethod r_MApplyStyleTranslate_StyleTranslate;
		public virtual RMethod RMApplyStyleTranslate_StyleTranslate
		{
			get
			{
				if(r_MApplyStyleTranslate_StyleTranslate == null)
				{
					r_MApplyStyleTranslate_StyleTranslate = new(this, "ApplyStyleTranslate", 0, typeof(UnityEngine.UIElements.StyleTranslate));
				}
				return r_MApplyStyleTranslate_StyleTranslate;
			}
		}

		/// <summary>
		/// Boolean SetInlineScale(UnityEngine.UIElements.StyleScale)
		/// </summary>
		protected RMethod r_MSetInlineScale_StyleScale;
		public virtual RMethod RMSetInlineScale_StyleScale
		{
			get
			{
				if(r_MSetInlineScale_StyleScale == null)
				{
					r_MSetInlineScale_StyleScale = new(this, "SetInlineScale", 0, typeof(UnityEngine.UIElements.StyleScale));
				}
				return r_MSetInlineScale_StyleScale;
			}
		}

		/// <summary>
		/// Void ApplyStyleScale(UnityEngine.UIElements.StyleScale)
		/// </summary>
		protected RMethod r_MApplyStyleScale_StyleScale;
		public virtual RMethod RMApplyStyleScale_StyleScale
		{
			get
			{
				if(r_MApplyStyleScale_StyleScale == null)
				{
					r_MApplyStyleScale_StyleScale = new(this, "ApplyStyleScale", 0, typeof(UnityEngine.UIElements.StyleScale));
				}
				return r_MApplyStyleScale_StyleScale;
			}
		}

		/// <summary>
		/// Boolean SetInlineRotate(UnityEngine.UIElements.StyleRotate)
		/// </summary>
		protected RMethod r_MSetInlineRotate_StyleRotate;
		public virtual RMethod RMSetInlineRotate_StyleRotate
		{
			get
			{
				if(r_MSetInlineRotate_StyleRotate == null)
				{
					r_MSetInlineRotate_StyleRotate = new(this, "SetInlineRotate", 0, typeof(UnityEngine.UIElements.StyleRotate));
				}
				return r_MSetInlineRotate_StyleRotate;
			}
		}

		/// <summary>
		/// Void ApplyStyleRotate(UnityEngine.UIElements.StyleRotate)
		/// </summary>
		protected RMethod r_MApplyStyleRotate_StyleRotate;
		public virtual RMethod RMApplyStyleRotate_StyleRotate
		{
			get
			{
				if(r_MApplyStyleRotate_StyleRotate == null)
				{
					r_MApplyStyleRotate_StyleRotate = new(this, "ApplyStyleRotate", 0, typeof(UnityEngine.UIElements.StyleRotate));
				}
				return r_MApplyStyleRotate_StyleRotate;
			}
		}

		/// <summary>
		/// Boolean SetInlineBackgroundSize(UnityEngine.UIElements.StyleBackgroundSize)
		/// </summary>
		protected RMethod r_MSetInlineBackgroundSize_StyleBackgroundSize;
		public virtual RMethod RMSetInlineBackgroundSize_StyleBackgroundSize
		{
			get
			{
				if(r_MSetInlineBackgroundSize_StyleBackgroundSize == null)
				{
					r_MSetInlineBackgroundSize_StyleBackgroundSize = new(this, "SetInlineBackgroundSize", 0, typeof(UnityEngine.UIElements.StyleBackgroundSize));
				}
				return r_MSetInlineBackgroundSize_StyleBackgroundSize;
			}
		}

		/// <summary>
		/// Void ApplyStyleBackgroundSize(UnityEngine.UIElements.StyleBackgroundSize)
		/// </summary>
		protected RMethod r_MApplyStyleBackgroundSize_StyleBackgroundSize;
		public virtual RMethod RMApplyStyleBackgroundSize_StyleBackgroundSize
		{
			get
			{
				if(r_MApplyStyleBackgroundSize_StyleBackgroundSize == null)
				{
					r_MApplyStyleBackgroundSize_StyleBackgroundSize = new(this, "ApplyStyleBackgroundSize", 0, typeof(UnityEngine.UIElements.StyleBackgroundSize));
				}
				return r_MApplyStyleBackgroundSize_StyleBackgroundSize;
			}
		}

		/// <summary>
		/// Void ApplyStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue)
		/// </summary>
		protected RMethod r_MApplyStyleValue_StyleValue;
		public virtual RMethod RMApplyStyleValue_StyleValue
		{
			get
			{
				if(r_MApplyStyleValue_StyleValue == null)
				{
					r_MApplyStyleValue_StyleValue = new(this, "ApplyStyleValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValue"));
				}
				return r_MApplyStyleValue_StyleValue;
			}
		}

		/// <summary>
		/// Void ApplyStyleValue(UnityEngine.UIElements.StyleSheets.StyleValueManaged)
		/// </summary>
		protected RMethod r_MApplyStyleValue_StyleValueManaged;
		public virtual RMethod RMApplyStyleValue_StyleValueManaged
		{
			get
			{
				if(r_MApplyStyleValue_StyleValueManaged == null)
				{
					r_MApplyStyleValue_StyleValueManaged = new(this, "ApplyStyleValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValueManaged"));
				}
				return r_MApplyStyleValue_StyleValueManaged;
			}
		}

		/// <summary>
		/// Boolean RemoveInlineStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_MRemoveInlineStyle_StylePropertyId;
		public virtual RMethod RMRemoveInlineStyle_StylePropertyId
		{
			get
			{
				if(r_MRemoveInlineStyle_StylePropertyId == null)
				{
					r_MRemoveInlineStyle_StylePropertyId = new(this, "RemoveInlineStyle", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
				}
				return r_MRemoveInlineStyle_StylePropertyId;
			}
		}

		/// <summary>
		/// Void ApplyFromComputedStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_MApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle;
		public virtual RMethod RMApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle
		{
			get
			{
				if(r_MApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle == null)
				{
					r_MApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle = new(this, "ApplyFromComputedStyle", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
				}
				return r_MApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Boolean TryGetInlineCursor(UnityEngine.UIElements.StyleCursor ByRef)
		/// </summary>
		protected RMethod r_MTryGetInlineCursor_Ref_StyleCursor;
		public virtual RMethod RMTryGetInlineCursor_Ref_StyleCursor
		{
			get
			{
				if(r_MTryGetInlineCursor_Ref_StyleCursor == null)
				{
					r_MTryGetInlineCursor_Ref_StyleCursor = new(this, "TryGetInlineCursor", 0, typeof(UnityEngine.UIElements.StyleCursor).MakeByRefType());
				}
				return r_MTryGetInlineCursor_Ref_StyleCursor;
			}
		}

		/// <summary>
		/// Boolean TryGetInlineTextShadow(UnityEngine.UIElements.StyleTextShadow ByRef)
		/// </summary>
		protected RMethod r_MTryGetInlineTextShadow_Ref_StyleTextShadow;
		public virtual RMethod RMTryGetInlineTextShadow_Ref_StyleTextShadow
		{
			get
			{
				if(r_MTryGetInlineTextShadow_Ref_StyleTextShadow == null)
				{
					r_MTryGetInlineTextShadow_Ref_StyleTextShadow = new(this, "TryGetInlineTextShadow", 0, typeof(UnityEngine.UIElements.StyleTextShadow).MakeByRefType());
				}
				return r_MTryGetInlineTextShadow_Ref_StyleTextShadow;
			}
		}

		/// <summary>
		/// Boolean TryGetInlineTransformOrigin(UnityEngine.UIElements.StyleTransformOrigin ByRef)
		/// </summary>
		protected RMethod r_MTryGetInlineTransformOrigin_Ref_StyleTransformOrigin;
		public virtual RMethod RMTryGetInlineTransformOrigin_Ref_StyleTransformOrigin
		{
			get
			{
				if(r_MTryGetInlineTransformOrigin_Ref_StyleTransformOrigin == null)
				{
					r_MTryGetInlineTransformOrigin_Ref_StyleTransformOrigin = new(this, "TryGetInlineTransformOrigin", 0, typeof(UnityEngine.UIElements.StyleTransformOrigin).MakeByRefType());
				}
				return r_MTryGetInlineTransformOrigin_Ref_StyleTransformOrigin;
			}
		}

		/// <summary>
		/// Boolean TryGetInlineTranslate(UnityEngine.UIElements.StyleTranslate ByRef)
		/// </summary>
		protected RMethod r_MTryGetInlineTranslate_Ref_StyleTranslate;
		public virtual RMethod RMTryGetInlineTranslate_Ref_StyleTranslate
		{
			get
			{
				if(r_MTryGetInlineTranslate_Ref_StyleTranslate == null)
				{
					r_MTryGetInlineTranslate_Ref_StyleTranslate = new(this, "TryGetInlineTranslate", 0, typeof(UnityEngine.UIElements.StyleTranslate).MakeByRefType());
				}
				return r_MTryGetInlineTranslate_Ref_StyleTranslate;
			}
		}

		/// <summary>
		/// Boolean TryGetInlineRotate(UnityEngine.UIElements.StyleRotate ByRef)
		/// </summary>
		protected RMethod r_MTryGetInlineRotate_Ref_StyleRotate;
		public virtual RMethod RMTryGetInlineRotate_Ref_StyleRotate
		{
			get
			{
				if(r_MTryGetInlineRotate_Ref_StyleRotate == null)
				{
					r_MTryGetInlineRotate_Ref_StyleRotate = new(this, "TryGetInlineRotate", 0, typeof(UnityEngine.UIElements.StyleRotate).MakeByRefType());
				}
				return r_MTryGetInlineRotate_Ref_StyleRotate;
			}
		}

		/// <summary>
		/// Boolean TryGetInlineScale(UnityEngine.UIElements.StyleScale ByRef)
		/// </summary>
		protected RMethod r_MTryGetInlineScale_Ref_StyleScale;
		public virtual RMethod RMTryGetInlineScale_Ref_StyleScale
		{
			get
			{
				if(r_MTryGetInlineScale_Ref_StyleScale == null)
				{
					r_MTryGetInlineScale_Ref_StyleScale = new(this, "TryGetInlineScale", 0, typeof(UnityEngine.UIElements.StyleScale).MakeByRefType());
				}
				return r_MTryGetInlineScale_Ref_StyleScale;
			}
		}

		/// <summary>
		/// Boolean TryGetInlineBackgroundSize(UnityEngine.UIElements.StyleBackgroundSize ByRef)
		/// </summary>
		protected RMethod r_MTryGetInlineBackgroundSize_Ref_StyleBackgroundSize;
		public virtual RMethod RMTryGetInlineBackgroundSize_Ref_StyleBackgroundSize
		{
			get
			{
				if(r_MTryGetInlineBackgroundSize_Ref_StyleBackgroundSize == null)
				{
					r_MTryGetInlineBackgroundSize_Ref_StyleBackgroundSize = new(this, "TryGetInlineBackgroundSize", 0, typeof(UnityEngine.UIElements.StyleBackgroundSize).MakeByRefType());
				}
				return r_MTryGetInlineBackgroundSize_Ref_StyleBackgroundSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_MGetStyleLength_StylePropertyId;
		public virtual RMethod RMGetStyleLength_StylePropertyId
		{
			get
			{
				if(r_MGetStyleLength_StylePropertyId == null)
				{
					r_MGetStyleLength_StylePropertyId = new(this, "GetStyleLength", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
				}
				return r_MGetStyleLength_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_MGetStyleFloat_StylePropertyId;
		public virtual RMethod RMGetStyleFloat_StylePropertyId
		{
			get
			{
				if(r_MGetStyleFloat_StylePropertyId == null)
				{
					r_MGetStyleFloat_StylePropertyId = new(this, "GetStyleFloat", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
				}
				return r_MGetStyleFloat_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_MGetStyleInt_StylePropertyId;
		public virtual RMethod RMGetStyleInt_StylePropertyId
		{
			get
			{
				if(r_MGetStyleInt_StylePropertyId == null)
				{
					r_MGetStyleInt_StylePropertyId = new(this, "GetStyleInt", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
				}
				return r_MGetStyleInt_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_MGetStyleColor_StylePropertyId;
		public virtual RMethod RMGetStyleColor_StylePropertyId
		{
			get
			{
				if(r_MGetStyleColor_StylePropertyId == null)
				{
					r_MGetStyleColor_StylePropertyId = new(this, "GetStyleColor", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
				}
				return r_MGetStyleColor_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackground GetStyleBackground(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_MGetStyleBackground_StylePropertyId;
		public virtual RMethod RMGetStyleBackground_StylePropertyId
		{
			get
			{
				if(r_MGetStyleBackground_StylePropertyId == null)
				{
					r_MGetStyleBackground_StylePropertyId = new(this, "GetStyleBackground", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
				}
				return r_MGetStyleBackground_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundPosition GetStyleBackgroundPosition(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_MGetStyleBackgroundPosition_StylePropertyId;
		public virtual RMethod RMGetStyleBackgroundPosition_StylePropertyId
		{
			get
			{
				if(r_MGetStyleBackgroundPosition_StylePropertyId == null)
				{
					r_MGetStyleBackgroundPosition_StylePropertyId = new(this, "GetStyleBackgroundPosition", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
				}
				return r_MGetStyleBackgroundPosition_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundRepeat GetStyleBackgroundRepeat(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_MGetStyleBackgroundRepeat_StylePropertyId;
		public virtual RMethod RMGetStyleBackgroundRepeat_StylePropertyId
		{
			get
			{
				if(r_MGetStyleBackgroundRepeat_StylePropertyId == null)
				{
					r_MGetStyleBackgroundRepeat_StylePropertyId = new(this, "GetStyleBackgroundRepeat", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
				}
				return r_MGetStyleBackgroundRepeat_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFont GetStyleFont(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_MGetStyleFont_StylePropertyId;
		public virtual RMethod RMGetStyleFont_StylePropertyId
		{
			get
			{
				if(r_MGetStyleFont_StylePropertyId == null)
				{
					r_MGetStyleFont_StylePropertyId = new(this, "GetStyleFont", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
				}
				return r_MGetStyleFont_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFontDefinition GetStyleFontDefinition(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_MGetStyleFontDefinition_StylePropertyId;
		public virtual RMethod RMGetStyleFontDefinition_StylePropertyId
		{
			get
			{
				if(r_MGetStyleFontDefinition_StylePropertyId == null)
				{
					r_MGetStyleFontDefinition_StylePropertyId = new(this, "GetStyleFontDefinition", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
				}
				return r_MGetStyleFontDefinition_StylePropertyId;
			}
		}

		/// <summary>
		/// Boolean TryGetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleSheets.StyleValue ByRef)
		/// </summary>
		protected RMethod r_MTryGetStyleValue_StylePropertyId_Ref_StyleValue;
		public virtual RMethod RMTryGetStyleValue_StylePropertyId_Ref_StyleValue
		{
			get
			{
				if(r_MTryGetStyleValue_StylePropertyId_Ref_StyleValue == null)
				{
					r_MTryGetStyleValue_StylePropertyId_Ref_StyleValue = new(this, "TryGetStyleValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValue").MakeByRefType());
				}
				return r_MTryGetStyleValue_StylePropertyId_Ref_StyleValue;
			}
		}

		/// <summary>
		/// Void SetStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue)
		/// </summary>
		protected RMethod r_MSetStyleValue_StyleValue;
		public virtual RMethod RMSetStyleValue_StyleValue
		{
			get
			{
				if(r_MSetStyleValue_StyleValue == null)
				{
					r_MSetStyleValue_StyleValue = new(this, "SetStyleValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValue"));
				}
				return r_MSetStyleValue_StyleValue;
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


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInlineRule(UnityEngine.UIElements.StyleSheet @sheet, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheet, @rule.Value};
            var ___result = RMSetInlineRule_StyleSheet_StyleRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsValueSet(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMIsValueSet_StylePropertyId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void ApplyInlineStyles(ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @computedStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@computedStyle.Value};
            var ___result = RMApplyInlineStyles_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@computedStyle = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[0]);

            
        }


        public virtual UnityEngine.UIElements.StyleList<T> GetStyleList<T>(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMGetStyleList_GT_StylePropertyId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleList<T>>(___result);
        }


        public virtual void SetStyleValueManaged(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleValueManaged @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RMSetStyleValueManaged_StyleValueManaged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryGetStyleValueManaged(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleValueManaged @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @value.Value};
            var ___result = RMTryGetStyleValueManaged_StylePropertyId_Ref_StyleValueManaged.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleValueManaged>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean SetStyleValue(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.StyleBackgroundPosition @inlineValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @inlineValue};
            var ___result = RMSetStyleValue_StylePropertyId_StyleBackgroundPosition.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean SetStyleValue(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.StyleBackgroundRepeat @inlineValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @inlineValue};
            var ___result = RMSetStyleValue_StylePropertyId_StyleBackgroundRepeat.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean SetStyleValue(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.StyleLength @inlineValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @inlineValue};
            var ___result = RMSetStyleValue_StylePropertyId_StyleLength.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean SetStyleValue(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.StyleFloat @inlineValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @inlineValue};
            var ___result = RMSetStyleValue_StylePropertyId_StyleFloat.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean SetStyleValue(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.StyleInt @inlineValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @inlineValue};
            var ___result = RMSetStyleValue_StylePropertyId_StyleInt.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean SetStyleValue(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.StyleColor @inlineValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @inlineValue};
            var ___result = RMSetStyleValue_StylePropertyId_StyleColor.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean SetStyleValue<T>(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RType> @inlineValue) where T : struct, System.IConvertible
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@id.Value, @inlineValue.Value};
            var ___result = RMSetStyleValue_GT_StylePropertyId_StyleEnum_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean SetStyleValue(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.StyleBackground @inlineValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @inlineValue};
            var ___result = RMSetStyleValue_StylePropertyId_StyleBackground.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean SetStyleValue(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.StyleFontDefinition @inlineValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @inlineValue};
            var ___result = RMSetStyleValue_StylePropertyId_StyleFontDefinition.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean SetStyleValue(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.StyleFont @inlineValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @inlineValue};
            var ___result = RMSetStyleValue_StylePropertyId_StyleFont.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean SetStyleValue<T>(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.StyleList<T> @inlineValue)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@id.Value, @inlineValue};
            var ___result = RMSetStyleValue_GT_StylePropertyId_StyleList_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean SetInlineCursor(UnityEngine.UIElements.StyleCursor @inlineValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inlineValue};
            var ___result = RMSetInlineCursor_StyleCursor.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void ApplyStyleCursor(UnityEngine.UIElements.StyleCursor @cursor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cursor};
            var ___result = RMApplyStyleCursor_StyleCursor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SetInlineTextShadow(UnityEngine.UIElements.StyleTextShadow @inlineValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inlineValue};
            var ___result = RMSetInlineTextShadow_StyleTextShadow.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void ApplyStyleTextShadow(UnityEngine.UIElements.StyleTextShadow @textShadow)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textShadow};
            var ___result = RMApplyStyleTextShadow_StyleTextShadow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SetInlineTransformOrigin(UnityEngine.UIElements.StyleTransformOrigin @inlineValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inlineValue};
            var ___result = RMSetInlineTransformOrigin_StyleTransformOrigin.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void ApplyStyleTransformOrigin(UnityEngine.UIElements.StyleTransformOrigin @transformOrigin)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@transformOrigin};
            var ___result = RMApplyStyleTransformOrigin_StyleTransformOrigin.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SetInlineTranslate(UnityEngine.UIElements.StyleTranslate @inlineValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inlineValue};
            var ___result = RMSetInlineTranslate_StyleTranslate.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void ApplyStyleTranslate(UnityEngine.UIElements.StyleTranslate @translate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@translate};
            var ___result = RMApplyStyleTranslate_StyleTranslate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SetInlineScale(UnityEngine.UIElements.StyleScale @inlineValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inlineValue};
            var ___result = RMSetInlineScale_StyleScale.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void ApplyStyleScale(UnityEngine.UIElements.StyleScale @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scale};
            var ___result = RMApplyStyleScale_StyleScale.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SetInlineRotate(UnityEngine.UIElements.StyleRotate @inlineValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inlineValue};
            var ___result = RMSetInlineRotate_StyleRotate.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void ApplyStyleRotate(UnityEngine.UIElements.StyleRotate @rotate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rotate};
            var ___result = RMApplyStyleRotate_StyleRotate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SetInlineBackgroundSize(UnityEngine.UIElements.StyleBackgroundSize @inlineValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inlineValue};
            var ___result = RMSetInlineBackgroundSize_StyleBackgroundSize.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void ApplyStyleBackgroundSize(UnityEngine.UIElements.StyleBackgroundSize @backgroundSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@backgroundSize};
            var ___result = RMApplyStyleBackgroundSize_StyleBackgroundSize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyStyleValue(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleValue @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RMApplyStyleValue_StyleValue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyStyleValue(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleValueManaged @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RMApplyStyleValue_StyleValueManaged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean RemoveInlineStyle(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMRemoveInlineStyle_StylePropertyId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void ApplyFromComputedStyle(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @newStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @newStyle.Value};
            var ___result = RMApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@newStyle = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[1]);

            
        }


        public virtual System.Boolean TryGetInlineCursor(ref UnityEngine.UIElements.StyleCursor @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMTryGetInlineCursor_Ref_StyleCursor.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<UnityEngine.UIElements.StyleCursor>(___parameters[0]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean TryGetInlineTextShadow(ref UnityEngine.UIElements.StyleTextShadow @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMTryGetInlineTextShadow_Ref_StyleTextShadow.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<UnityEngine.UIElements.StyleTextShadow>(___parameters[0]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean TryGetInlineTransformOrigin(ref UnityEngine.UIElements.StyleTransformOrigin @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMTryGetInlineTransformOrigin_Ref_StyleTransformOrigin.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<UnityEngine.UIElements.StyleTransformOrigin>(___parameters[0]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean TryGetInlineTranslate(ref UnityEngine.UIElements.StyleTranslate @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMTryGetInlineTranslate_Ref_StyleTranslate.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<UnityEngine.UIElements.StyleTranslate>(___parameters[0]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean TryGetInlineRotate(ref UnityEngine.UIElements.StyleRotate @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMTryGetInlineRotate_Ref_StyleRotate.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<UnityEngine.UIElements.StyleRotate>(___parameters[0]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean TryGetInlineScale(ref UnityEngine.UIElements.StyleScale @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMTryGetInlineScale_Ref_StyleScale.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<UnityEngine.UIElements.StyleScale>(___parameters[0]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean TryGetInlineBackgroundSize(ref UnityEngine.UIElements.StyleBackgroundSize @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMTryGetInlineBackgroundSize_Ref_StyleBackgroundSize.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<UnityEngine.UIElements.StyleBackgroundSize>(___parameters[0]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual UnityEngine.UIElements.StyleLength GetStyleLength(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMGetStyleLength_StylePropertyId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleLength>(___result);
        }


        public virtual UnityEngine.UIElements.StyleFloat GetStyleFloat(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMGetStyleFloat_StylePropertyId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleFloat>(___result);
        }


        public virtual UnityEngine.UIElements.StyleInt GetStyleInt(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMGetStyleInt_StylePropertyId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleInt>(___result);
        }


        public virtual UnityEngine.UIElements.StyleColor GetStyleColor(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMGetStyleColor_StylePropertyId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleColor>(___result);
        }


        public virtual UnityEngine.UIElements.StyleBackground GetStyleBackground(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMGetStyleBackground_StylePropertyId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleBackground>(___result);
        }


        public virtual UnityEngine.UIElements.StyleBackgroundPosition GetStyleBackgroundPosition(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMGetStyleBackgroundPosition_StylePropertyId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleBackgroundPosition>(___result);
        }


        public virtual UnityEngine.UIElements.StyleBackgroundRepeat GetStyleBackgroundRepeat(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMGetStyleBackgroundRepeat_StylePropertyId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleBackgroundRepeat>(___result);
        }


        public virtual UnityEngine.UIElements.StyleFont GetStyleFont(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMGetStyleFont_StylePropertyId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleFont>(___result);
        }


        public virtual UnityEngine.UIElements.StyleFontDefinition GetStyleFontDefinition(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMGetStyleFontDefinition_StylePropertyId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleFontDefinition>(___result);
        }


        public virtual System.Boolean TryGetStyleValue(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleValue @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @value.Value};
            var ___result = RMTryGetStyleValue_StylePropertyId_Ref_StyleValue.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleValue>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void SetStyleValue(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleValue @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RMSetStyleValue_StyleValue.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
