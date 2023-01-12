using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.TextElement
	/// </summary>
    public partial class RTextElement : RMember //
    {

		/// <summary>
		/// System.String ussClassName
		/// </summary>
		protected static RSystem.RString r_FussClassName;
		public static RSystem.RString RFussClassName
		{
			get
			{
				if(r_FussClassName == null)
				{
					r_FussClassName = new(typeof(UnityEngine.UIElements.TextElement), "ussClassName");
					r_FussClassName.SetBelong(null);
				}
				return r_FussClassName;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UITKTextHandle <uitkTextHandle>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RUITKTextHandle r_F__0__uitkTextHandle__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RUITKTextHandle RF__0__uitkTextHandle__1__k__BackingField
		{
			get
			{
				if(r_F__0__uitkTextHandle__1__k__BackingField == null)
				{
					r_F__0__uitkTextHandle__1__k__BackingField = new(this, "<uitkTextHandle>k__BackingField");
					r_F__0__uitkTextHandle__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__uitkTextHandle__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String m_Text
		/// </summary>
		protected RSystem.RString r_Fm_Text;
		public virtual RSystem.RString RFm_Text
		{
			get
			{
				if(r_Fm_Text == null)
				{
					r_Fm_Text = new(this, "m_Text");
					r_Fm_Text.SetBelong(this.instance);
				}
				return r_Fm_Text;
			}
		}

		/// <summary>
		/// System.Boolean m_EnableRichText
		/// </summary>
		protected RSystem.RBoolean r_Fm_EnableRichText;
		public virtual RSystem.RBoolean RFm_EnableRichText
		{
			get
			{
				if(r_Fm_EnableRichText == null)
				{
					r_Fm_EnableRichText = new(this, "m_EnableRichText");
					r_Fm_EnableRichText.SetBelong(this.instance);
				}
				return r_Fm_EnableRichText;
			}
		}

		/// <summary>
		/// System.Boolean m_DisplayTooltipWhenElided
		/// </summary>
		protected RSystem.RBoolean r_Fm_DisplayTooltipWhenElided;
		public virtual RSystem.RBoolean RFm_DisplayTooltipWhenElided
		{
			get
			{
				if(r_Fm_DisplayTooltipWhenElided == null)
				{
					r_Fm_DisplayTooltipWhenElided = new(this, "m_DisplayTooltipWhenElided");
					r_Fm_DisplayTooltipWhenElided.SetBelong(this.instance);
				}
				return r_Fm_DisplayTooltipWhenElided;
			}
		}

		/// <summary>
		/// System.Boolean <isElided>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r_F__0__isElided__1__k__BackingField;
		public virtual RSystem.RBoolean RF__0__isElided__1__k__BackingField
		{
			get
			{
				if(r_F__0__isElided__1__k__BackingField == null)
				{
					r_F__0__isElided__1__k__BackingField = new(this, "<isElided>k__BackingField");
					r_F__0__isElided__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__isElided__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String k_EllipsisText
		/// </summary>
		protected static RSystem.RString r_Fk_EllipsisText;
		public static RSystem.RString RFk_EllipsisText
		{
			get
			{
				if(r_Fk_EllipsisText == null)
				{
					r_Fk_EllipsisText = new(typeof(UnityEngine.UIElements.TextElement), "k_EllipsisText");
					r_Fk_EllipsisText.SetBelong(null);
				}
				return r_Fk_EllipsisText;
			}
		}

		/// <summary>
		/// System.String elidedText
		/// </summary>
		protected RSystem.RString r_FelidedText;
		public virtual RSystem.RString RFelidedText
		{
			get
			{
				if(r_FelidedText == null)
				{
					r_FelidedText = new(this, "elidedText");
					r_FelidedText.SetBelong(this.instance);
				}
				return r_FelidedText;
			}
		}

		/// <summary>
		/// System.Boolean m_WasElided
		/// </summary>
		protected RSystem.RBoolean r_Fm_WasElided;
		public virtual RSystem.RBoolean RFm_WasElided
		{
			get
			{
				if(r_Fm_WasElided == null)
				{
					r_Fm_WasElided = new(this, "m_WasElided");
					r_Fm_WasElided.SetBelong(this.instance);
				}
				return r_Fm_WasElided;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextEditingManipulator editingManipulator
		/// </summary>
		protected RUnityEngine.RUIElements.RTextEditingManipulator r_FeditingManipulator;
		public virtual RUnityEngine.RUIElements.RTextEditingManipulator RFeditingManipulator
		{
			get
			{
				if(r_FeditingManipulator == null)
				{
					r_FeditingManipulator = new(this, "editingManipulator");
					r_FeditingManipulator.SetBelong(this.instance);
				}
				return r_FeditingManipulator;
			}
		}

		/// <summary>
		/// System.Boolean m_Multiline
		/// </summary>
		protected RSystem.RBoolean r_Fm_Multiline;
		public virtual RSystem.RBoolean RFm_Multiline
		{
			get
			{
				if(r_Fm_Multiline == null)
				{
					r_Fm_Multiline = new(this, "m_Multiline");
					r_Fm_Multiline.SetBelong(this.instance);
				}
				return r_Fm_Multiline;
			}
		}

		/// <summary>
		/// System.Boolean m_IsReadOnly
		/// </summary>
		protected RSystem.RBoolean r_Fm_IsReadOnly;
		public virtual RSystem.RBoolean RFm_IsReadOnly
		{
			get
			{
				if(r_Fm_IsReadOnly == null)
				{
					r_Fm_IsReadOnly = new(this, "m_IsReadOnly");
					r_Fm_IsReadOnly.SetBelong(this.instance);
				}
				return r_Fm_IsReadOnly;
			}
		}

		/// <summary>
		/// System.Int32 m_MaxLength
		/// </summary>
		protected RSystem.RInt32 r_Fm_MaxLength;
		public virtual RSystem.RInt32 RFm_MaxLength
		{
			get
			{
				if(r_Fm_MaxLength == null)
				{
					r_Fm_MaxLength = new(this, "m_MaxLength");
					r_Fm_MaxLength.SetBelong(this.instance);
				}
				return r_Fm_MaxLength;
			}
		}

		/// <summary>
		/// System.Boolean <UnityEngine.UIElements.ITextEdition.isDelayed>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__isDelayed__1__k__BackingField;
		public virtual RSystem.RBoolean RF__0__UnityEngine__2__UIElements__2__ITextEdition__2__isDelayed__1__k__BackingField
		{
			get
			{
				if(r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__isDelayed__1__k__BackingField == null)
				{
					r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__isDelayed__1__k__BackingField = new(this, "<UnityEngine.UIElements.ITextEdition.isDelayed>k__BackingField");
					r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__isDelayed__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__isDelayed__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Func`2[System.Char,System.Boolean] <UnityEngine.UIElements.ITextEdition.AcceptCharacter>k__BackingField
		/// </summary>
		protected RSystem.RFunc<RSystem.RChar, RSystem.RBoolean> r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__AcceptCharacter__1__k__BackingField;
		public virtual RSystem.RFunc<RSystem.RChar, RSystem.RBoolean> RF__0__UnityEngine__2__UIElements__2__ITextEdition__2__AcceptCharacter__1__k__BackingField
		{
			get
			{
				if(r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__AcceptCharacter__1__k__BackingField == null)
				{
					r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__AcceptCharacter__1__k__BackingField = new(this, "<UnityEngine.UIElements.ITextEdition.AcceptCharacter>k__BackingField");
					r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__AcceptCharacter__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__AcceptCharacter__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] <UnityEngine.UIElements.ITextEdition.UpdateScrollOffset>k__BackingField
		/// </summary>
		protected RSystem.RAction<RSystem.RBoolean> r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__UpdateScrollOffset__1__k__BackingField;
		public virtual RSystem.RAction<RSystem.RBoolean> RF__0__UnityEngine__2__UIElements__2__ITextEdition__2__UpdateScrollOffset__1__k__BackingField
		{
			get
			{
				if(r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__UpdateScrollOffset__1__k__BackingField == null)
				{
					r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__UpdateScrollOffset__1__k__BackingField = new(this, "<UnityEngine.UIElements.ITextEdition.UpdateScrollOffset>k__BackingField");
					r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__UpdateScrollOffset__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__UpdateScrollOffset__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Action <UnityEngine.UIElements.ITextEdition.UpdateValueFromText>k__BackingField
		/// </summary>
		protected RSystem.RAction r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__UpdateValueFromText__1__k__BackingField;
		public virtual RSystem.RAction RF__0__UnityEngine__2__UIElements__2__ITextEdition__2__UpdateValueFromText__1__k__BackingField
		{
			get
			{
				if(r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__UpdateValueFromText__1__k__BackingField == null)
				{
					r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__UpdateValueFromText__1__k__BackingField = new(this, "<UnityEngine.UIElements.ITextEdition.UpdateValueFromText>k__BackingField");
					r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__UpdateValueFromText__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__UpdateValueFromText__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Action <UnityEngine.UIElements.ITextEdition.UpdateTextFromValue>k__BackingField
		/// </summary>
		protected RSystem.RAction r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__UpdateTextFromValue__1__k__BackingField;
		public virtual RSystem.RAction RF__0__UnityEngine__2__UIElements__2__ITextEdition__2__UpdateTextFromValue__1__k__BackingField
		{
			get
			{
				if(r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__UpdateTextFromValue__1__k__BackingField == null)
				{
					r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__UpdateTextFromValue__1__k__BackingField = new(this, "<UnityEngine.UIElements.ITextEdition.UpdateTextFromValue>k__BackingField");
					r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__UpdateTextFromValue__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__UpdateTextFromValue__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Action <UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot>k__BackingField
		/// </summary>
		protected RSystem.RAction r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__MoveFocusToCompositeRoot__1__k__BackingField;
		public virtual RSystem.RAction RF__0__UnityEngine__2__UIElements__2__ITextEdition__2__MoveFocusToCompositeRoot__1__k__BackingField
		{
			get
			{
				if(r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__MoveFocusToCompositeRoot__1__k__BackingField == null)
				{
					r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__MoveFocusToCompositeRoot__1__k__BackingField = new(this, "<UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot>k__BackingField");
					r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__MoveFocusToCompositeRoot__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__UnityEngine__2__UIElements__2__ITextEdition__2__MoveFocusToCompositeRoot__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String m_RenderedText
		/// </summary>
		protected RSystem.RString r_Fm_RenderedText;
		public virtual RSystem.RString RFm_RenderedText
		{
			get
			{
				if(r_Fm_RenderedText == null)
				{
					r_Fm_RenderedText = new(this, "m_RenderedText");
					r_Fm_RenderedText.SetBelong(this.instance);
				}
				return r_Fm_RenderedText;
			}
		}

		/// <summary>
		/// System.String m_OriginalText
		/// </summary>
		protected RSystem.RString r_Fm_OriginalText;
		public virtual RSystem.RString RFm_OriginalText
		{
			get
			{
				if(r_Fm_OriginalText == null)
				{
					r_Fm_OriginalText = new(this, "m_OriginalText");
					r_Fm_OriginalText.SetBelong(this.instance);
				}
				return r_Fm_OriginalText;
			}
		}

		/// <summary>
		/// System.Char m_MaskChar
		/// </summary>
		protected RSystem.RChar r_Fm_MaskChar;
		public virtual RSystem.RChar RFm_MaskChar
		{
			get
			{
				if(r_Fm_MaskChar == null)
				{
					r_Fm_MaskChar = new(this, "m_MaskChar");
					r_Fm_MaskChar.SetBelong(this.instance);
				}
				return r_Fm_MaskChar;
			}
		}

		/// <summary>
		/// System.Boolean m_IsPassword
		/// </summary>
		protected RSystem.RBoolean r_Fm_IsPassword;
		public virtual RSystem.RBoolean RFm_IsPassword
		{
			get
			{
				if(r_Fm_IsPassword == null)
				{
					r_Fm_IsPassword = new(this, "m_IsPassword");
					r_Fm_IsPassword.SetBelong(this.instance);
				}
				return r_Fm_IsPassword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextSelectingManipulator m_SelectingManipulator
		/// </summary>
		protected RUnityEngine.RUIElements.RTextSelectingManipulator r_Fm_SelectingManipulator;
		public virtual RUnityEngine.RUIElements.RTextSelectingManipulator RFm_SelectingManipulator
		{
			get
			{
				if(r_Fm_SelectingManipulator == null)
				{
					r_Fm_SelectingManipulator = new(this, "m_SelectingManipulator");
					r_Fm_SelectingManipulator.SetBelong(this.instance);
				}
				return r_Fm_SelectingManipulator;
			}
		}

		/// <summary>
		/// System.Boolean m_IsSelectable
		/// </summary>
		protected RSystem.RBoolean r_Fm_IsSelectable;
		public virtual RSystem.RBoolean RFm_IsSelectable
		{
			get
			{
				if(r_Fm_IsSelectable == null)
				{
					r_Fm_IsSelectable = new(this, "m_IsSelectable");
					r_Fm_IsSelectable.SetBelong(this.instance);
				}
				return r_Fm_IsSelectable;
			}
		}

		/// <summary>
		/// System.Boolean <UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__doubleClickSelectsWord__1__k__BackingField;
		public virtual RSystem.RBoolean RF__0__UnityEngine__2__UIElements__2__ITextSelection__2__doubleClickSelectsWord__1__k__BackingField
		{
			get
			{
				if(r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__doubleClickSelectsWord__1__k__BackingField == null)
				{
					r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__doubleClickSelectsWord__1__k__BackingField = new(this, "<UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord>k__BackingField");
					r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__doubleClickSelectsWord__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__doubleClickSelectsWord__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__tripleClickSelectsLine__1__k__BackingField;
		public virtual RSystem.RBoolean RF__0__UnityEngine__2__UIElements__2__ITextSelection__2__tripleClickSelectsLine__1__k__BackingField
		{
			get
			{
				if(r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__tripleClickSelectsLine__1__k__BackingField == null)
				{
					r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__tripleClickSelectsLine__1__k__BackingField = new(this, "<UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine>k__BackingField");
					r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__tripleClickSelectsLine__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__tripleClickSelectsLine__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <UnityEngine.UIElements.ITextSelection.selectAllOnFocus>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__selectAllOnFocus__1__k__BackingField;
		public virtual RSystem.RBoolean RF__0__UnityEngine__2__UIElements__2__ITextSelection__2__selectAllOnFocus__1__k__BackingField
		{
			get
			{
				if(r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__selectAllOnFocus__1__k__BackingField == null)
				{
					r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__selectAllOnFocus__1__k__BackingField = new(this, "<UnityEngine.UIElements.ITextSelection.selectAllOnFocus>k__BackingField");
					r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__selectAllOnFocus__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__selectAllOnFocus__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__selectAllOnMouseUp__1__k__BackingField;
		public virtual RSystem.RBoolean RF__0__UnityEngine__2__UIElements__2__ITextSelection__2__selectAllOnMouseUp__1__k__BackingField
		{
			get
			{
				if(r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__selectAllOnMouseUp__1__k__BackingField == null)
				{
					r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__selectAllOnMouseUp__1__k__BackingField = new(this, "<UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp>k__BackingField");
					r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__selectAllOnMouseUp__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__selectAllOnMouseUp__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Color <UnityEngine.UIElements.ITextSelection.selectionColor>k__BackingField
		/// </summary>
		protected RUnityEngine.RColor r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__selectionColor__1__k__BackingField;
		public virtual RUnityEngine.RColor RF__0__UnityEngine__2__UIElements__2__ITextSelection__2__selectionColor__1__k__BackingField
		{
			get
			{
				if(r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__selectionColor__1__k__BackingField == null)
				{
					r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__selectionColor__1__k__BackingField = new(this, "<UnityEngine.UIElements.ITextSelection.selectionColor>k__BackingField");
					r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__selectionColor__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__selectionColor__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Color <UnityEngine.UIElements.ITextSelection.cursorColor>k__BackingField
		/// </summary>
		protected RUnityEngine.RColor r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__cursorColor__1__k__BackingField;
		public virtual RUnityEngine.RColor RF__0__UnityEngine__2__UIElements__2__ITextSelection__2__cursorColor__1__k__BackingField
		{
			get
			{
				if(r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__cursorColor__1__k__BackingField == null)
				{
					r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__cursorColor__1__k__BackingField = new(this, "<UnityEngine.UIElements.ITextSelection.cursorColor>k__BackingField");
					r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__cursorColor__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__cursorColor__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Single <UnityEngine.UIElements.ITextSelection.cursorWidth>k__BackingField
		/// </summary>
		protected RSystem.RSingle r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__cursorWidth__1__k__BackingField;
		public virtual RSystem.RSingle RF__0__UnityEngine__2__UIElements__2__ITextSelection__2__cursorWidth__1__k__BackingField
		{
			get
			{
				if(r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__cursorWidth__1__k__BackingField == null)
				{
					r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__cursorWidth__1__k__BackingField = new(this, "<UnityEngine.UIElements.ITextSelection.cursorWidth>k__BackingField");
					r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__cursorWidth__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__UnityEngine__2__UIElements__2__ITextSelection__2__cursorWidth__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags m_Flags
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElementFlags r_Fm_Flags;
		public virtual RUnityEngine.RUIElements.RVisualElementFlags RFm_Flags
		{
			get
			{
				if(r_Fm_Flags == null)
				{
					r_Fm_Flags = new(this, "m_Flags");
					r_Fm_Flags.SetBelong(this.instance);
				}
				return r_Fm_Flags;
			}
		}

		/// <summary>
		/// UnityEngine.Rect lastLayout
		/// </summary>
		protected RUnityEngine.RRect r_FlastLayout;
		public virtual RUnityEngine.RRect RFlastLayout
		{
			get
			{
				if(r_FlastLayout == null)
				{
					r_FlastLayout = new(this, "lastLayout");
					r_FlastLayout.SetBelong(this.instance);
				}
				return r_FlastLayout;
			}
		}

		/// <summary>
		/// UnityEngine.Rect lastPseudoPadding
		/// </summary>
		protected RUnityEngine.RRect r_FlastPseudoPadding;
		public virtual RUnityEngine.RRect RFlastPseudoPadding
		{
			get
			{
				if(r_FlastPseudoPadding == null)
				{
					r_FlastPseudoPadding = new(this, "lastPseudoPadding");
					r_FlastPseudoPadding.SetBelong(this.instance);
				}
				return r_FlastPseudoPadding;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainVEData renderChainData
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChainVEData r_FrenderChainData;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChainVEData RFrenderChainData
		{
			get
			{
				if(r_FrenderChainData == null)
				{
					r_FrenderChainData = new(this, "renderChainData");
					r_FrenderChainData.SetBelong(this.instance);
				}
				return r_FrenderChainData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PseudoStates triggerPseudoMask
		/// </summary>
		protected RUnityEngine.RUIElements.RPseudoStates r_FtriggerPseudoMask;
		public virtual RUnityEngine.RUIElements.RPseudoStates RFtriggerPseudoMask
		{
			get
			{
				if(r_FtriggerPseudoMask == null)
				{
					r_FtriggerPseudoMask = new(this, "triggerPseudoMask");
					r_FtriggerPseudoMask.SetBelong(this.instance);
				}
				return r_FtriggerPseudoMask;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PseudoStates dependencyPseudoMask
		/// </summary>
		protected RUnityEngine.RUIElements.RPseudoStates r_FdependencyPseudoMask;
		public virtual RUnityEngine.RUIElements.RPseudoStates RFdependencyPseudoMask
		{
			get
			{
				if(r_FdependencyPseudoMask == null)
				{
					r_FdependencyPseudoMask = new(this, "dependencyPseudoMask");
					r_FdependencyPseudoMask.SetBelong(this.instance);
				}
				return r_FdependencyPseudoMask;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ComputedStyle m_Style
		/// </summary>
		protected RUnityEngine.RUIElements.RComputedStyle r_Fm_Style;
		public virtual RUnityEngine.RUIElements.RComputedStyle RFm_Style
		{
			get
			{
				if(r_Fm_Style == null)
				{
					r_Fm_Style = new(this, "m_Style");
					r_Fm_Style.SetBelong(this.instance);
				}
				return r_Fm_Style;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleVariableContext variableContext
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleVariableContext r_FvariableContext;
		public virtual RUnityEngine.RUIElements.RStyleVariableContext RFvariableContext
		{
			get
			{
				if(r_FvariableContext == null)
				{
					r_FvariableContext = new(this, "variableContext");
					r_FvariableContext.SetBelong(this.instance);
				}
				return r_FvariableContext;
			}
		}

		/// <summary>
		/// System.Int32 inheritedStylesHash
		/// </summary>
		protected RSystem.RInt32 r_FinheritedStylesHash;
		public virtual RSystem.RInt32 RFinheritedStylesHash
		{
			get
			{
				if(r_FinheritedStylesHash == null)
				{
					r_FinheritedStylesHash = new(this, "inheritedStylesHash");
					r_FinheritedStylesHash.SetBelong(this.instance);
				}
				return r_FinheritedStylesHash;
			}
		}

		/// <summary>
		/// System.UInt32 controlid
		/// </summary>
		protected RSystem.RUInt32 r_Fcontrolid;
		public virtual RSystem.RUInt32 RFcontrolid
		{
			get
			{
				if(r_Fcontrolid == null)
				{
					r_Fcontrolid = new(this, "controlid");
					r_Fcontrolid.SetBelong(this.instance);
				}
				return r_Fcontrolid;
			}
		}

		/// <summary>
		/// System.Int32 imguiContainerDescendantCount
		/// </summary>
		protected RSystem.RInt32 r_FimguiContainerDescendantCount;
		public virtual RSystem.RInt32 RFimguiContainerDescendantCount
		{
			get
			{
				if(r_FimguiContainerDescendantCount == null)
				{
					r_FimguiContainerDescendantCount = new(this, "imguiContainerDescendantCount");
					r_FimguiContainerDescendantCount.SetBelong(this.instance);
				}
				return r_FimguiContainerDescendantCount;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.InlineStyleAccess inlineStyleAccess
		/// </summary>
		protected RUnityEngine.RUIElements.RInlineStyleAccess r_FinlineStyleAccess;
		public virtual RUnityEngine.RUIElements.RInlineStyleAccess RFinlineStyleAccess
		{
			get
			{
				if(r_FinlineStyleAccess == null)
				{
					r_FinlineStyleAccess = new(this, "inlineStyleAccess");
					r_FinlineStyleAccess.SetBelong(this.instance);
				}
				return r_FinlineStyleAccess;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheet] styleSheetList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheet> r_FstyleSheetList;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheet> RFstyleSheetList
		{
			get
			{
				if(r_FstyleSheetList == null)
				{
					r_FstyleSheetList = new(this, "styleSheetList");
					r_FstyleSheetList.SetBelong(this.instance);
				}
				return r_FstyleSheetList;
			}
		}

		/// <summary>
		/// System.Boolean isIMGUIContainer
		/// </summary>
		protected RSystem.RBoolean r_FisIMGUIContainer;
		public virtual RSystem.RBoolean RFisIMGUIContainer
		{
			get
			{
				if(r_FisIMGUIContainer == null)
				{
					r_FisIMGUIContainer = new(this, "isIMGUIContainer");
					r_FisIMGUIContainer.SetBelong(this.instance);
				}
				return r_FisIMGUIContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UITKTextHandle uitkTextHandle
		/// </summary>
		protected RUnityEngine.RUIElements.RUITKTextHandle r_PuitkTextHandle;
		public virtual RUnityEngine.RUIElements.RUITKTextHandle RPuitkTextHandle
		{
			get
			{
				if(r_PuitkTextHandle == null)
				{
					r_PuitkTextHandle = new(this, "uitkTextHandle", -1);
					r_PuitkTextHandle.SetBelong(this.instance);
				}
				return r_PuitkTextHandle;
			}
		}

		/// <summary>
		/// System.String text
		/// </summary>
		protected RSystem.RString r_Ptext;
		public virtual RSystem.RString RPtext
		{
			get
			{
				if(r_Ptext == null)
				{
					r_Ptext = new(this, "text", -1);
					r_Ptext.SetBelong(this.instance);
				}
				return r_Ptext;
			}
		}

		/// <summary>
		/// Boolean enableRichText
		/// </summary>
		protected RSystem.RBoolean r_PenableRichText;
		public virtual RSystem.RBoolean RPenableRichText
		{
			get
			{
				if(r_PenableRichText == null)
				{
					r_PenableRichText = new(this, "enableRichText", -1);
					r_PenableRichText.SetBelong(this.instance);
				}
				return r_PenableRichText;
			}
		}

		/// <summary>
		/// Boolean displayTooltipWhenElided
		/// </summary>
		protected RSystem.RBoolean r_PdisplayTooltipWhenElided;
		public virtual RSystem.RBoolean RPdisplayTooltipWhenElided
		{
			get
			{
				if(r_PdisplayTooltipWhenElided == null)
				{
					r_PdisplayTooltipWhenElided = new(this, "displayTooltipWhenElided", -1);
					r_PdisplayTooltipWhenElided.SetBelong(this.instance);
				}
				return r_PdisplayTooltipWhenElided;
			}
		}

		/// <summary>
		/// Boolean isElided
		/// </summary>
		protected RSystem.RBoolean r_PisElided;
		public virtual RSystem.RBoolean RPisElided
		{
			get
			{
				if(r_PisElided == null)
				{
					r_PisElided = new(this, "isElided", -1);
					r_PisElided.SetBelong(this.instance);
				}
				return r_PisElided;
			}
		}

		/// <summary>
		/// System.String UnityEngine.UIElements.INotifyValueChanged<System.String>.value
		/// </summary>
		protected RSystem.RString r_PUnityEngine__2__UIElements__2__INotifyValueChanged__0__System__2__String__1____2__value;
		public virtual RSystem.RString RPUnityEngine__2__UIElements__2__INotifyValueChanged__0__System__2__String__1____2__value
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__INotifyValueChanged__0__System__2__String__1____2__value == null)
				{
					r_PUnityEngine__2__UIElements__2__INotifyValueChanged__0__System__2__String__1____2__value = new(this, "UnityEngine.UIElements.INotifyValueChanged<System.String>.value", -1);
					r_PUnityEngine__2__UIElements__2__INotifyValueChanged__0__System__2__String__1____2__value.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__INotifyValueChanged__0__System__2__String__1____2__value;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ITextEdition edition
		/// </summary>
		protected RUnityEngine.RUIElements.RITextEdition r_Pedition;
		public virtual RUnityEngine.RUIElements.RITextEdition RPedition
		{
			get
			{
				if(r_Pedition == null)
				{
					r_Pedition = new(this, "edition", -1);
					r_Pedition.SetBelong(this.instance);
				}
				return r_Pedition;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.ITextEdition.multiline
		/// </summary>
		protected RSystem.RBoolean r_PUnityEngine__2__UIElements__2__ITextEdition__2__multiline;
		public virtual RSystem.RBoolean RPUnityEngine__2__UIElements__2__ITextEdition__2__multiline
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITextEdition__2__multiline == null)
				{
					r_PUnityEngine__2__UIElements__2__ITextEdition__2__multiline = new(this, "UnityEngine.UIElements.ITextEdition.multiline", -1);
					r_PUnityEngine__2__UIElements__2__ITextEdition__2__multiline.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITextEdition__2__multiline;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.ITextEdition.isReadOnly
		/// </summary>
		protected RSystem.RBoolean r_PUnityEngine__2__UIElements__2__ITextEdition__2__isReadOnly;
		public virtual RSystem.RBoolean RPUnityEngine__2__UIElements__2__ITextEdition__2__isReadOnly
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITextEdition__2__isReadOnly == null)
				{
					r_PUnityEngine__2__UIElements__2__ITextEdition__2__isReadOnly = new(this, "UnityEngine.UIElements.ITextEdition.isReadOnly", -1);
					r_PUnityEngine__2__UIElements__2__ITextEdition__2__isReadOnly.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITextEdition__2__isReadOnly;
			}
		}

		/// <summary>
		/// Int32 UnityEngine.UIElements.ITextEdition.maxLength
		/// </summary>
		protected RSystem.RInt32 r_PUnityEngine__2__UIElements__2__ITextEdition__2__maxLength;
		public virtual RSystem.RInt32 RPUnityEngine__2__UIElements__2__ITextEdition__2__maxLength
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITextEdition__2__maxLength == null)
				{
					r_PUnityEngine__2__UIElements__2__ITextEdition__2__maxLength = new(this, "UnityEngine.UIElements.ITextEdition.maxLength", -1);
					r_PUnityEngine__2__UIElements__2__ITextEdition__2__maxLength.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITextEdition__2__maxLength;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.ITextEdition.isDelayed
		/// </summary>
		protected RSystem.RBoolean r_PUnityEngine__2__UIElements__2__ITextEdition__2__isDelayed;
		public virtual RSystem.RBoolean RPUnityEngine__2__UIElements__2__ITextEdition__2__isDelayed
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITextEdition__2__isDelayed == null)
				{
					r_PUnityEngine__2__UIElements__2__ITextEdition__2__isDelayed = new(this, "UnityEngine.UIElements.ITextEdition.isDelayed", -1);
					r_PUnityEngine__2__UIElements__2__ITextEdition__2__isDelayed.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITextEdition__2__isDelayed;
			}
		}

		/// <summary>
		/// System.Func`2[System.Char,System.Boolean] UnityEngine.UIElements.ITextEdition.AcceptCharacter
		/// </summary>
		protected RSystem.RFunc<RSystem.RChar, RSystem.RBoolean> r_PUnityEngine__2__UIElements__2__ITextEdition__2__AcceptCharacter;
		public virtual RSystem.RFunc<RSystem.RChar, RSystem.RBoolean> RPUnityEngine__2__UIElements__2__ITextEdition__2__AcceptCharacter
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITextEdition__2__AcceptCharacter == null)
				{
					r_PUnityEngine__2__UIElements__2__ITextEdition__2__AcceptCharacter = new(this, "UnityEngine.UIElements.ITextEdition.AcceptCharacter", -1);
					r_PUnityEngine__2__UIElements__2__ITextEdition__2__AcceptCharacter.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITextEdition__2__AcceptCharacter;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] UnityEngine.UIElements.ITextEdition.UpdateScrollOffset
		/// </summary>
		protected RSystem.RAction<RSystem.RBoolean> r_PUnityEngine__2__UIElements__2__ITextEdition__2__UpdateScrollOffset;
		public virtual RSystem.RAction<RSystem.RBoolean> RPUnityEngine__2__UIElements__2__ITextEdition__2__UpdateScrollOffset
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITextEdition__2__UpdateScrollOffset == null)
				{
					r_PUnityEngine__2__UIElements__2__ITextEdition__2__UpdateScrollOffset = new(this, "UnityEngine.UIElements.ITextEdition.UpdateScrollOffset", -1);
					r_PUnityEngine__2__UIElements__2__ITextEdition__2__UpdateScrollOffset.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITextEdition__2__UpdateScrollOffset;
			}
		}

		/// <summary>
		/// System.Action UnityEngine.UIElements.ITextEdition.UpdateValueFromText
		/// </summary>
		protected RSystem.RAction r_PUnityEngine__2__UIElements__2__ITextEdition__2__UpdateValueFromText;
		public virtual RSystem.RAction RPUnityEngine__2__UIElements__2__ITextEdition__2__UpdateValueFromText
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITextEdition__2__UpdateValueFromText == null)
				{
					r_PUnityEngine__2__UIElements__2__ITextEdition__2__UpdateValueFromText = new(this, "UnityEngine.UIElements.ITextEdition.UpdateValueFromText", -1);
					r_PUnityEngine__2__UIElements__2__ITextEdition__2__UpdateValueFromText.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITextEdition__2__UpdateValueFromText;
			}
		}

		/// <summary>
		/// System.Action UnityEngine.UIElements.ITextEdition.UpdateTextFromValue
		/// </summary>
		protected RSystem.RAction r_PUnityEngine__2__UIElements__2__ITextEdition__2__UpdateTextFromValue;
		public virtual RSystem.RAction RPUnityEngine__2__UIElements__2__ITextEdition__2__UpdateTextFromValue
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITextEdition__2__UpdateTextFromValue == null)
				{
					r_PUnityEngine__2__UIElements__2__ITextEdition__2__UpdateTextFromValue = new(this, "UnityEngine.UIElements.ITextEdition.UpdateTextFromValue", -1);
					r_PUnityEngine__2__UIElements__2__ITextEdition__2__UpdateTextFromValue.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITextEdition__2__UpdateTextFromValue;
			}
		}

		/// <summary>
		/// System.Action UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot
		/// </summary>
		protected RSystem.RAction r_PUnityEngine__2__UIElements__2__ITextEdition__2__MoveFocusToCompositeRoot;
		public virtual RSystem.RAction RPUnityEngine__2__UIElements__2__ITextEdition__2__MoveFocusToCompositeRoot
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITextEdition__2__MoveFocusToCompositeRoot == null)
				{
					r_PUnityEngine__2__UIElements__2__ITextEdition__2__MoveFocusToCompositeRoot = new(this, "UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot", -1);
					r_PUnityEngine__2__UIElements__2__ITextEdition__2__MoveFocusToCompositeRoot.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITextEdition__2__MoveFocusToCompositeRoot;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.ITextEdition.hasFocus
		/// </summary>
		protected RSystem.RBoolean r_PUnityEngine__2__UIElements__2__ITextEdition__2__hasFocus;
		public virtual RSystem.RBoolean RPUnityEngine__2__UIElements__2__ITextEdition__2__hasFocus
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITextEdition__2__hasFocus == null)
				{
					r_PUnityEngine__2__UIElements__2__ITextEdition__2__hasFocus = new(this, "UnityEngine.UIElements.ITextEdition.hasFocus", -1);
					r_PUnityEngine__2__UIElements__2__ITextEdition__2__hasFocus.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITextEdition__2__hasFocus;
			}
		}

		/// <summary>
		/// Char UnityEngine.UIElements.ITextEdition.maskChar
		/// </summary>
		protected RSystem.RChar r_PUnityEngine__2__UIElements__2__ITextEdition__2__maskChar;
		public virtual RSystem.RChar RPUnityEngine__2__UIElements__2__ITextEdition__2__maskChar
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITextEdition__2__maskChar == null)
				{
					r_PUnityEngine__2__UIElements__2__ITextEdition__2__maskChar = new(this, "UnityEngine.UIElements.ITextEdition.maskChar", -1);
					r_PUnityEngine__2__UIElements__2__ITextEdition__2__maskChar.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITextEdition__2__maskChar;
			}
		}

		/// <summary>
		/// Char effectiveMaskChar
		/// </summary>
		protected RSystem.RChar r_PeffectiveMaskChar;
		public virtual RSystem.RChar RPeffectiveMaskChar
		{
			get
			{
				if(r_PeffectiveMaskChar == null)
				{
					r_PeffectiveMaskChar = new(this, "effectiveMaskChar", -1);
					r_PeffectiveMaskChar.SetBelong(this.instance);
				}
				return r_PeffectiveMaskChar;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.ITextEdition.isPassword
		/// </summary>
		protected RSystem.RBoolean r_PUnityEngine__2__UIElements__2__ITextEdition__2__isPassword;
		public virtual RSystem.RBoolean RPUnityEngine__2__UIElements__2__ITextEdition__2__isPassword
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITextEdition__2__isPassword == null)
				{
					r_PUnityEngine__2__UIElements__2__ITextEdition__2__isPassword = new(this, "UnityEngine.UIElements.ITextEdition.isPassword", -1);
					r_PUnityEngine__2__UIElements__2__ITextEdition__2__isPassword.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITextEdition__2__isPassword;
			}
		}

		/// <summary>
		/// System.String renderedText
		/// </summary>
		protected RSystem.RString r_PrenderedText;
		public virtual RSystem.RString RPrenderedText
		{
			get
			{
				if(r_PrenderedText == null)
				{
					r_PrenderedText = new(this, "renderedText", -1);
					r_PrenderedText.SetBelong(this.instance);
				}
				return r_PrenderedText;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ITextSelection selection
		/// </summary>
		protected RUnityEngine.RUIElements.RITextSelection r_Pselection;
		public virtual RUnityEngine.RUIElements.RITextSelection RPselection
		{
			get
			{
				if(r_Pselection == null)
				{
					r_Pselection = new(this, "selection", -1);
					r_Pselection.SetBelong(this.instance);
				}
				return r_Pselection;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.ITextSelection.isSelectable
		/// </summary>
		protected RSystem.RBoolean r_PUnityEngine__2__UIElements__2__ITextSelection__2__isSelectable;
		public virtual RSystem.RBoolean RPUnityEngine__2__UIElements__2__ITextSelection__2__isSelectable
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITextSelection__2__isSelectable == null)
				{
					r_PUnityEngine__2__UIElements__2__ITextSelection__2__isSelectable = new(this, "UnityEngine.UIElements.ITextSelection.isSelectable", -1);
					r_PUnityEngine__2__UIElements__2__ITextSelection__2__isSelectable.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITextSelection__2__isSelectable;
			}
		}

		/// <summary>
		/// Int32 UnityEngine.UIElements.ITextSelection.cursorIndex
		/// </summary>
		protected RSystem.RInt32 r_PUnityEngine__2__UIElements__2__ITextSelection__2__cursorIndex;
		public virtual RSystem.RInt32 RPUnityEngine__2__UIElements__2__ITextSelection__2__cursorIndex
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITextSelection__2__cursorIndex == null)
				{
					r_PUnityEngine__2__UIElements__2__ITextSelection__2__cursorIndex = new(this, "UnityEngine.UIElements.ITextSelection.cursorIndex", -1);
					r_PUnityEngine__2__UIElements__2__ITextSelection__2__cursorIndex.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITextSelection__2__cursorIndex;
			}
		}

		/// <summary>
		/// Int32 UnityEngine.UIElements.ITextSelection.selectIndex
		/// </summary>
		protected RSystem.RInt32 r_PUnityEngine__2__UIElements__2__ITextSelection__2__selectIndex;
		public virtual RSystem.RInt32 RPUnityEngine__2__UIElements__2__ITextSelection__2__selectIndex
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITextSelection__2__selectIndex == null)
				{
					r_PUnityEngine__2__UIElements__2__ITextSelection__2__selectIndex = new(this, "UnityEngine.UIElements.ITextSelection.selectIndex", -1);
					r_PUnityEngine__2__UIElements__2__ITextSelection__2__selectIndex.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITextSelection__2__selectIndex;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord
		/// </summary>
		protected RSystem.RBoolean r_PUnityEngine__2__UIElements__2__ITextSelection__2__doubleClickSelectsWord;
		public virtual RSystem.RBoolean RPUnityEngine__2__UIElements__2__ITextSelection__2__doubleClickSelectsWord
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITextSelection__2__doubleClickSelectsWord == null)
				{
					r_PUnityEngine__2__UIElements__2__ITextSelection__2__doubleClickSelectsWord = new(this, "UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord", -1);
					r_PUnityEngine__2__UIElements__2__ITextSelection__2__doubleClickSelectsWord.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITextSelection__2__doubleClickSelectsWord;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine
		/// </summary>
		protected RSystem.RBoolean r_PUnityEngine__2__UIElements__2__ITextSelection__2__tripleClickSelectsLine;
		public virtual RSystem.RBoolean RPUnityEngine__2__UIElements__2__ITextSelection__2__tripleClickSelectsLine
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITextSelection__2__tripleClickSelectsLine == null)
				{
					r_PUnityEngine__2__UIElements__2__ITextSelection__2__tripleClickSelectsLine = new(this, "UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine", -1);
					r_PUnityEngine__2__UIElements__2__ITextSelection__2__tripleClickSelectsLine.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITextSelection__2__tripleClickSelectsLine;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.ITextSelection.selectAllOnFocus
		/// </summary>
		protected RSystem.RBoolean r_PUnityEngine__2__UIElements__2__ITextSelection__2__selectAllOnFocus;
		public virtual RSystem.RBoolean RPUnityEngine__2__UIElements__2__ITextSelection__2__selectAllOnFocus
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITextSelection__2__selectAllOnFocus == null)
				{
					r_PUnityEngine__2__UIElements__2__ITextSelection__2__selectAllOnFocus = new(this, "UnityEngine.UIElements.ITextSelection.selectAllOnFocus", -1);
					r_PUnityEngine__2__UIElements__2__ITextSelection__2__selectAllOnFocus.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITextSelection__2__selectAllOnFocus;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp
		/// </summary>
		protected RSystem.RBoolean r_PUnityEngine__2__UIElements__2__ITextSelection__2__selectAllOnMouseUp;
		public virtual RSystem.RBoolean RPUnityEngine__2__UIElements__2__ITextSelection__2__selectAllOnMouseUp
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITextSelection__2__selectAllOnMouseUp == null)
				{
					r_PUnityEngine__2__UIElements__2__ITextSelection__2__selectAllOnMouseUp = new(this, "UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp", -1);
					r_PUnityEngine__2__UIElements__2__ITextSelection__2__selectAllOnMouseUp.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITextSelection__2__selectAllOnMouseUp;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 UnityEngine.UIElements.ITextSelection.cursorPosition
		/// </summary>
		protected RUnityEngine.RVector2 r_PUnityEngine__2__UIElements__2__ITextSelection__2__cursorPosition;
		public virtual RUnityEngine.RVector2 RPUnityEngine__2__UIElements__2__ITextSelection__2__cursorPosition
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITextSelection__2__cursorPosition == null)
				{
					r_PUnityEngine__2__UIElements__2__ITextSelection__2__cursorPosition = new(this, "UnityEngine.UIElements.ITextSelection.cursorPosition", -1);
					r_PUnityEngine__2__UIElements__2__ITextSelection__2__cursorPosition.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITextSelection__2__cursorPosition;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.ITextSelection.lineHeightAtCursorPosition
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__ITextSelection__2__lineHeightAtCursorPosition;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__ITextSelection__2__lineHeightAtCursorPosition
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITextSelection__2__lineHeightAtCursorPosition == null)
				{
					r_PUnityEngine__2__UIElements__2__ITextSelection__2__lineHeightAtCursorPosition = new(this, "UnityEngine.UIElements.ITextSelection.lineHeightAtCursorPosition", -1);
					r_PUnityEngine__2__UIElements__2__ITextSelection__2__lineHeightAtCursorPosition.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITextSelection__2__lineHeightAtCursorPosition;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.ITextSelection.selectionColor
		/// </summary>
		protected RUnityEngine.RColor r_PUnityEngine__2__UIElements__2__ITextSelection__2__selectionColor;
		public virtual RUnityEngine.RColor RPUnityEngine__2__UIElements__2__ITextSelection__2__selectionColor
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITextSelection__2__selectionColor == null)
				{
					r_PUnityEngine__2__UIElements__2__ITextSelection__2__selectionColor = new(this, "UnityEngine.UIElements.ITextSelection.selectionColor", -1);
					r_PUnityEngine__2__UIElements__2__ITextSelection__2__selectionColor.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITextSelection__2__selectionColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.ITextSelection.cursorColor
		/// </summary>
		protected RUnityEngine.RColor r_PUnityEngine__2__UIElements__2__ITextSelection__2__cursorColor;
		public virtual RUnityEngine.RColor RPUnityEngine__2__UIElements__2__ITextSelection__2__cursorColor
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITextSelection__2__cursorColor == null)
				{
					r_PUnityEngine__2__UIElements__2__ITextSelection__2__cursorColor = new(this, "UnityEngine.UIElements.ITextSelection.cursorColor", -1);
					r_PUnityEngine__2__UIElements__2__ITextSelection__2__cursorColor.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITextSelection__2__cursorColor;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.ITextSelection.cursorWidth
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__ITextSelection__2__cursorWidth;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__ITextSelection__2__cursorWidth
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITextSelection__2__cursorWidth == null)
				{
					r_PUnityEngine__2__UIElements__2__ITextSelection__2__cursorWidth = new(this, "UnityEngine.UIElements.ITextSelection.cursorWidth", -1);
					r_PUnityEngine__2__UIElements__2__ITextSelection__2__cursorWidth.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITextSelection__2__cursorWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextSelectingManipulator selectingManipulator
		/// </summary>
		protected RUnityEngine.RUIElements.RTextSelectingManipulator r_PselectingManipulator;
		public virtual RUnityEngine.RUIElements.RTextSelectingManipulator RPselectingManipulator
		{
			get
			{
				if(r_PselectingManipulator == null)
				{
					r_PselectingManipulator = new(this, "selectingManipulator", -1);
					r_PselectingManipulator.SetBelong(this.instance);
				}
				return r_PselectingManipulator;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IBinding binding
		/// </summary>
		protected RUnityEngine.RUIElements.RIBinding r_Pbinding;
		public virtual RUnityEngine.RUIElements.RIBinding RPbinding
		{
			get
			{
				if(r_Pbinding == null)
				{
					r_Pbinding = new(this, "binding", -1);
					r_Pbinding.SetBelong(this.instance);
				}
				return r_Pbinding;
			}
		}

		/// <summary>
		/// System.String bindingPath
		/// </summary>
		protected RSystem.RString r_PbindingPath;
		public virtual RSystem.RString RPbindingPath
		{
			get
			{
				if(r_PbindingPath == null)
				{
					r_PbindingPath = new(this, "bindingPath", -1);
					r_PbindingPath.SetBelong(this.instance);
				}
				return r_PbindingPath;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IResolvedStyle resolvedStyle
		/// </summary>
		protected RUnityEngine.RUIElements.RIResolvedStyle r_PresolvedStyle;
		public virtual RUnityEngine.RUIElements.RIResolvedStyle RPresolvedStyle
		{
			get
			{
				if(r_PresolvedStyle == null)
				{
					r_PresolvedStyle = new(this, "resolvedStyle", -1);
					r_PresolvedStyle.SetBelong(this.instance);
				}
				return r_PresolvedStyle;
			}
		}

		/// <summary>
		/// Boolean hasRunningAnimations
		/// </summary>
		protected RSystem.RBoolean r_PhasRunningAnimations;
		public virtual RSystem.RBoolean RPhasRunningAnimations
		{
			get
			{
				if(r_PhasRunningAnimations == null)
				{
					r_PhasRunningAnimations = new(this, "hasRunningAnimations", -1);
					r_PhasRunningAnimations.SetBelong(this.instance);
				}
				return r_PhasRunningAnimations;
			}
		}

		/// <summary>
		/// Boolean hasCompletedAnimations
		/// </summary>
		protected RSystem.RBoolean r_PhasCompletedAnimations;
		public virtual RSystem.RBoolean RPhasCompletedAnimations
		{
			get
			{
				if(r_PhasCompletedAnimations == null)
				{
					r_PhasCompletedAnimations = new(this, "hasCompletedAnimations", -1);
					r_PhasCompletedAnimations.SetBelong(this.instance);
				}
				return r_PhasCompletedAnimations;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IStylePropertyAnimations styleAnimation
		/// </summary>
		protected RUnityEngine.RUIElements.RIStylePropertyAnimations r_PstyleAnimation;
		public virtual RUnityEngine.RUIElements.RIStylePropertyAnimations RPstyleAnimation
		{
			get
			{
				if(r_PstyleAnimation == null)
				{
					r_PstyleAnimation = new(this, "styleAnimation", -1);
					r_PstyleAnimation.SetBelong(this.instance);
				}
				return r_PstyleAnimation;
			}
		}

		/// <summary>
		/// Boolean isCompositeRoot
		/// </summary>
		protected RSystem.RBoolean r_PisCompositeRoot;
		public virtual RSystem.RBoolean RPisCompositeRoot
		{
			get
			{
				if(r_PisCompositeRoot == null)
				{
					r_PisCompositeRoot = new(this, "isCompositeRoot", -1);
					r_PisCompositeRoot.SetBelong(this.instance);
				}
				return r_PisCompositeRoot;
			}
		}

		/// <summary>
		/// Boolean isHierarchyDisplayed
		/// </summary>
		protected RSystem.RBoolean r_PisHierarchyDisplayed;
		public virtual RSystem.RBoolean RPisHierarchyDisplayed
		{
			get
			{
				if(r_PisHierarchyDisplayed == null)
				{
					r_PisHierarchyDisplayed = new(this, "isHierarchyDisplayed", -1);
					r_PisHierarchyDisplayed.SetBelong(this.instance);
				}
				return r_PisHierarchyDisplayed;
			}
		}

		/// <summary>
		/// System.String viewDataKey
		/// </summary>
		protected RSystem.RString r_PviewDataKey;
		public virtual RSystem.RString RPviewDataKey
		{
			get
			{
				if(r_PviewDataKey == null)
				{
					r_PviewDataKey = new(this, "viewDataKey", -1);
					r_PviewDataKey.SetBelong(this.instance);
				}
				return r_PviewDataKey;
			}
		}

		/// <summary>
		/// Boolean enableViewDataPersistence
		/// </summary>
		protected RSystem.RBoolean r_PenableViewDataPersistence;
		public virtual RSystem.RBoolean RPenableViewDataPersistence
		{
			get
			{
				if(r_PenableViewDataPersistence == null)
				{
					r_PenableViewDataPersistence = new(this, "enableViewDataPersistence", -1);
					r_PenableViewDataPersistence.SetBelong(this.instance);
				}
				return r_PenableViewDataPersistence;
			}
		}

		/// <summary>
		/// System.Object userData
		/// </summary>
		protected RSystem.RObject r_PuserData;
		public virtual RSystem.RObject RPuserData
		{
			get
			{
				if(r_PuserData == null)
				{
					r_PuserData = new(this, "userData", -1);
					r_PuserData.SetBelong(this.instance);
				}
				return r_PuserData;
			}
		}

		/// <summary>
		/// Boolean canGrabFocus
		/// </summary>
		protected RSystem.RBoolean r_PcanGrabFocus;
		public virtual RSystem.RBoolean RPcanGrabFocus
		{
			get
			{
				if(r_PcanGrabFocus == null)
				{
					r_PcanGrabFocus = new(this, "canGrabFocus", -1);
					r_PcanGrabFocus.SetBelong(this.instance);
				}
				return r_PcanGrabFocus;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FocusController focusController
		/// </summary>
		protected RUnityEngine.RUIElements.RFocusController r_PfocusController;
		public virtual RUnityEngine.RUIElements.RFocusController RPfocusController
		{
			get
			{
				if(r_PfocusController == null)
				{
					r_PfocusController = new(this, "focusController", -1);
					r_PfocusController.SetBelong(this.instance);
				}
				return r_PfocusController;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UsageHints usageHints
		/// </summary>
		protected RUnityEngine.RUIElements.RUsageHints r_PusageHints;
		public virtual RUnityEngine.RUIElements.RUsageHints RPusageHints
		{
			get
			{
				if(r_PusageHints == null)
				{
					r_PusageHints = new(this, "usageHints", -1);
					r_PusageHints.SetBelong(this.instance);
				}
				return r_PusageHints;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.RenderHints renderHints
		/// </summary>
		protected RUnityEngine.RUIElements.RRenderHints r_PrenderHints;
		public virtual RUnityEngine.RUIElements.RRenderHints RPrenderHints
		{
			get
			{
				if(r_PrenderHints == null)
				{
					r_PrenderHints = new(this, "renderHints", -1);
					r_PrenderHints.SetBelong(this.instance);
				}
				return r_PrenderHints;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ITransform transform
		/// </summary>
		protected RUnityEngine.RUIElements.RITransform r_Ptransform;
		public virtual RUnityEngine.RUIElements.RITransform RPtransform
		{
			get
			{
				if(r_Ptransform == null)
				{
					r_Ptransform = new(this, "transform", -1);
					r_Ptransform.SetBelong(this.instance);
				}
				return r_Ptransform;
			}
		}

		/// <summary>
		/// Boolean isLayoutManual
		/// </summary>
		protected RSystem.RBoolean r_PisLayoutManual;
		public virtual RSystem.RBoolean RPisLayoutManual
		{
			get
			{
				if(r_PisLayoutManual == null)
				{
					r_PisLayoutManual = new(this, "isLayoutManual", -1);
					r_PisLayoutManual.SetBelong(this.instance);
				}
				return r_PisLayoutManual;
			}
		}

		/// <summary>
		/// Single scaledPixelsPerPoint
		/// </summary>
		protected RSystem.RSingle r_PscaledPixelsPerPoint;
		public virtual RSystem.RSingle RPscaledPixelsPerPoint
		{
			get
			{
				if(r_PscaledPixelsPerPoint == null)
				{
					r_PscaledPixelsPerPoint = new(this, "scaledPixelsPerPoint", -1);
					r_PscaledPixelsPerPoint.SetBelong(this.instance);
				}
				return r_PscaledPixelsPerPoint;
			}
		}

		/// <summary>
		/// UnityEngine.Rect layout
		/// </summary>
		protected RUnityEngine.RRect r_Playout;
		public virtual RUnityEngine.RRect RPlayout
		{
			get
			{
				if(r_Playout == null)
				{
					r_Playout = new(this, "layout", -1);
					r_Playout.SetBelong(this.instance);
				}
				return r_Playout;
			}
		}

		/// <summary>
		/// UnityEngine.Rect contentRect
		/// </summary>
		protected RUnityEngine.RRect r_PcontentRect;
		public virtual RUnityEngine.RRect RPcontentRect
		{
			get
			{
				if(r_PcontentRect == null)
				{
					r_PcontentRect = new(this, "contentRect", -1);
					r_PcontentRect.SetBelong(this.instance);
				}
				return r_PcontentRect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect paddingRect
		/// </summary>
		protected RUnityEngine.RRect r_PpaddingRect;
		public virtual RUnityEngine.RRect RPpaddingRect
		{
			get
			{
				if(r_PpaddingRect == null)
				{
					r_PpaddingRect = new(this, "paddingRect", -1);
					r_PpaddingRect.SetBelong(this.instance);
				}
				return r_PpaddingRect;
			}
		}

		/// <summary>
		/// Boolean isBoundingBoxDirty
		/// </summary>
		protected RSystem.RBoolean r_PisBoundingBoxDirty;
		public virtual RSystem.RBoolean RPisBoundingBoxDirty
		{
			get
			{
				if(r_PisBoundingBoxDirty == null)
				{
					r_PisBoundingBoxDirty = new(this, "isBoundingBoxDirty", -1);
					r_PisBoundingBoxDirty.SetBelong(this.instance);
				}
				return r_PisBoundingBoxDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldBoundingBoxDirty
		/// </summary>
		protected RSystem.RBoolean r_PisWorldBoundingBoxDirty;
		public virtual RSystem.RBoolean RPisWorldBoundingBoxDirty
		{
			get
			{
				if(r_PisWorldBoundingBoxDirty == null)
				{
					r_PisWorldBoundingBoxDirty = new(this, "isWorldBoundingBoxDirty", -1);
					r_PisWorldBoundingBoxDirty.SetBelong(this.instance);
				}
				return r_PisWorldBoundingBoxDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldBoundingBoxOrDependenciesDirty
		/// </summary>
		protected RSystem.RBoolean r_PisWorldBoundingBoxOrDependenciesDirty;
		public virtual RSystem.RBoolean RPisWorldBoundingBoxOrDependenciesDirty
		{
			get
			{
				if(r_PisWorldBoundingBoxOrDependenciesDirty == null)
				{
					r_PisWorldBoundingBoxOrDependenciesDirty = new(this, "isWorldBoundingBoxOrDependenciesDirty", -1);
					r_PisWorldBoundingBoxOrDependenciesDirty.SetBelong(this.instance);
				}
				return r_PisWorldBoundingBoxOrDependenciesDirty;
			}
		}

		/// <summary>
		/// UnityEngine.Rect boundingBox
		/// </summary>
		protected RUnityEngine.RRect r_PboundingBox;
		public virtual RUnityEngine.RRect RPboundingBox
		{
			get
			{
				if(r_PboundingBox == null)
				{
					r_PboundingBox = new(this, "boundingBox", -1);
					r_PboundingBox.SetBelong(this.instance);
				}
				return r_PboundingBox;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldBoundingBox
		/// </summary>
		protected RUnityEngine.RRect r_PworldBoundingBox;
		public virtual RUnityEngine.RRect RPworldBoundingBox
		{
			get
			{
				if(r_PworldBoundingBox == null)
				{
					r_PworldBoundingBox = new(this, "worldBoundingBox", -1);
					r_PworldBoundingBox.SetBelong(this.instance);
				}
				return r_PworldBoundingBox;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldBound
		/// </summary>
		protected RUnityEngine.RRect r_PworldBound;
		public virtual RUnityEngine.RRect RPworldBound
		{
			get
			{
				if(r_PworldBound == null)
				{
					r_PworldBound = new(this, "worldBound", -1);
					r_PworldBound.SetBelong(this.instance);
				}
				return r_PworldBound;
			}
		}

		/// <summary>
		/// UnityEngine.Rect localBound
		/// </summary>
		protected RUnityEngine.RRect r_PlocalBound;
		public virtual RUnityEngine.RRect RPlocalBound
		{
			get
			{
				if(r_PlocalBound == null)
				{
					r_PlocalBound = new(this, "localBound", -1);
					r_PlocalBound.SetBelong(this.instance);
				}
				return r_PlocalBound;
			}
		}

		/// <summary>
		/// UnityEngine.Rect rect
		/// </summary>
		protected RUnityEngine.RRect r_Prect;
		public virtual RUnityEngine.RRect RPrect
		{
			get
			{
				if(r_Prect == null)
				{
					r_Prect = new(this, "rect", -1);
					r_Prect.SetBelong(this.instance);
				}
				return r_Prect;
			}
		}

		/// <summary>
		/// Boolean isWorldTransformDirty
		/// </summary>
		protected RSystem.RBoolean r_PisWorldTransformDirty;
		public virtual RSystem.RBoolean RPisWorldTransformDirty
		{
			get
			{
				if(r_PisWorldTransformDirty == null)
				{
					r_PisWorldTransformDirty = new(this, "isWorldTransformDirty", -1);
					r_PisWorldTransformDirty.SetBelong(this.instance);
				}
				return r_PisWorldTransformDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldTransformInverseDirty
		/// </summary>
		protected RSystem.RBoolean r_PisWorldTransformInverseDirty;
		public virtual RSystem.RBoolean RPisWorldTransformInverseDirty
		{
			get
			{
				if(r_PisWorldTransformInverseDirty == null)
				{
					r_PisWorldTransformInverseDirty = new(this, "isWorldTransformInverseDirty", -1);
					r_PisWorldTransformInverseDirty.SetBelong(this.instance);
				}
				return r_PisWorldTransformInverseDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldTransformInverseOrDependenciesDirty
		/// </summary>
		protected RSystem.RBoolean r_PisWorldTransformInverseOrDependenciesDirty;
		public virtual RSystem.RBoolean RPisWorldTransformInverseOrDependenciesDirty
		{
			get
			{
				if(r_PisWorldTransformInverseOrDependenciesDirty == null)
				{
					r_PisWorldTransformInverseOrDependenciesDirty = new(this, "isWorldTransformInverseOrDependenciesDirty", -1);
					r_PisWorldTransformInverseOrDependenciesDirty.SetBelong(this.instance);
				}
				return r_PisWorldTransformInverseOrDependenciesDirty;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 worldTransform
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_PworldTransform;
		public virtual RUnityEngine.RMatrix4x4 RPworldTransform
		{
			get
			{
				if(r_PworldTransform == null)
				{
					r_PworldTransform = new(this, "worldTransform", -1);
					r_PworldTransform.SetBelong(this.instance);
				}
				return r_PworldTransform;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4& worldTransformRef
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_PworldTransformRef;
		public virtual RUnityEngine.RMatrix4x4 RPworldTransformRef
		{
			get
			{
				if(r_PworldTransformRef == null)
				{
					r_PworldTransformRef = new(this, "worldTransformRef", -1);
					r_PworldTransformRef.SetBelong(this.instance);
				}
				return r_PworldTransformRef;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4& worldTransformInverse
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_PworldTransformInverse;
		public virtual RUnityEngine.RMatrix4x4 RPworldTransformInverse
		{
			get
			{
				if(r_PworldTransformInverse == null)
				{
					r_PworldTransformInverse = new(this, "worldTransformInverse", -1);
					r_PworldTransformInverse.SetBelong(this.instance);
				}
				return r_PworldTransformInverse;
			}
		}

		/// <summary>
		/// Boolean isWorldClipDirty
		/// </summary>
		protected RSystem.RBoolean r_PisWorldClipDirty;
		public virtual RSystem.RBoolean RPisWorldClipDirty
		{
			get
			{
				if(r_PisWorldClipDirty == null)
				{
					r_PisWorldClipDirty = new(this, "isWorldClipDirty", -1);
					r_PisWorldClipDirty.SetBelong(this.instance);
				}
				return r_PisWorldClipDirty;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldClip
		/// </summary>
		protected RUnityEngine.RRect r_PworldClip;
		public virtual RUnityEngine.RRect RPworldClip
		{
			get
			{
				if(r_PworldClip == null)
				{
					r_PworldClip = new(this, "worldClip", -1);
					r_PworldClip.SetBelong(this.instance);
				}
				return r_PworldClip;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldClipMinusGroup
		/// </summary>
		protected RUnityEngine.RRect r_PworldClipMinusGroup;
		public virtual RUnityEngine.RRect RPworldClipMinusGroup
		{
			get
			{
				if(r_PworldClipMinusGroup == null)
				{
					r_PworldClipMinusGroup = new(this, "worldClipMinusGroup", -1);
					r_PworldClipMinusGroup.SetBelong(this.instance);
				}
				return r_PworldClipMinusGroup;
			}
		}

		/// <summary>
		/// Boolean worldClipIsInfinite
		/// </summary>
		protected RSystem.RBoolean r_PworldClipIsInfinite;
		public virtual RSystem.RBoolean RPworldClipIsInfinite
		{
			get
			{
				if(r_PworldClipIsInfinite == null)
				{
					r_PworldClipIsInfinite = new(this, "worldClipIsInfinite", -1);
					r_PworldClipIsInfinite.SetBelong(this.instance);
				}
				return r_PworldClipIsInfinite;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PseudoStates pseudoStates
		/// </summary>
		protected RUnityEngine.RUIElements.RPseudoStates r_PpseudoStates;
		public virtual RUnityEngine.RUIElements.RPseudoStates RPpseudoStates
		{
			get
			{
				if(r_PpseudoStates == null)
				{
					r_PpseudoStates = new(this, "pseudoStates", -1);
					r_PpseudoStates.SetBelong(this.instance);
				}
				return r_PpseudoStates;
			}
		}

		/// <summary>
		/// Int32 containedPointerIds
		/// </summary>
		protected RSystem.RInt32 r_PcontainedPointerIds;
		public virtual RSystem.RInt32 RPcontainedPointerIds
		{
			get
			{
				if(r_PcontainedPointerIds == null)
				{
					r_PcontainedPointerIds = new(this, "containedPointerIds", -1);
					r_PcontainedPointerIds.SetBelong(this.instance);
				}
				return r_PcontainedPointerIds;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PickingMode pickingMode
		/// </summary>
		protected RUnityEngine.RUIElements.RPickingMode r_PpickingMode;
		public virtual RUnityEngine.RUIElements.RPickingMode RPpickingMode
		{
			get
			{
				if(r_PpickingMode == null)
				{
					r_PpickingMode = new(this, "pickingMode", -1);
					r_PpickingMode.SetBelong(this.instance);
				}
				return r_PpickingMode;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RSystem.RString r_Pname;
		public virtual RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
					r_Pname.SetBelong(this.instance);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] classList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RString> r_PclassList;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RString> RPclassList
		{
			get
			{
				if(r_PclassList == null)
				{
					r_PclassList = new(this, "classList", -1);
					r_PclassList.SetBelong(this.instance);
				}
				return r_PclassList;
			}
		}

		/// <summary>
		/// System.String fullTypeName
		/// </summary>
		protected RSystem.RString r_PfullTypeName;
		public virtual RSystem.RString RPfullTypeName
		{
			get
			{
				if(r_PfullTypeName == null)
				{
					r_PfullTypeName = new(this, "fullTypeName", -1);
					r_PfullTypeName.SetBelong(this.instance);
				}
				return r_PfullTypeName;
			}
		}

		/// <summary>
		/// System.String typeName
		/// </summary>
		protected RSystem.RString r_PtypeName;
		public virtual RSystem.RString RPtypeName
		{
			get
			{
				if(r_PtypeName == null)
				{
					r_PtypeName = new(this, "typeName", -1);
					r_PtypeName.SetBelong(this.instance);
				}
				return r_PtypeName;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaNode yogaNode
		/// </summary>
		protected RUnityEngine.RYoga.RYogaNode r_PyogaNode;
		public virtual RUnityEngine.RYoga.RYogaNode RPyogaNode
		{
			get
			{
				if(r_PyogaNode == null)
				{
					r_PyogaNode = new(this, "yogaNode", -1);
					r_PyogaNode.SetBelong(this.instance);
				}
				return r_PyogaNode;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ComputedStyle& computedStyle
		/// </summary>
		protected RUnityEngine.RUIElements.RComputedStyle r_PcomputedStyle;
		public virtual RUnityEngine.RUIElements.RComputedStyle RPcomputedStyle
		{
			get
			{
				if(r_PcomputedStyle == null)
				{
					r_PcomputedStyle = new(this, "computedStyle", -1);
					r_PcomputedStyle.SetBelong(this.instance);
				}
				return r_PcomputedStyle;
			}
		}

		/// <summary>
		/// Boolean hasInlineStyle
		/// </summary>
		protected RSystem.RBoolean r_PhasInlineStyle;
		public virtual RSystem.RBoolean RPhasInlineStyle
		{
			get
			{
				if(r_PhasInlineStyle == null)
				{
					r_PhasInlineStyle = new(this, "hasInlineStyle", -1);
					r_PhasInlineStyle.SetBelong(this.instance);
				}
				return r_PhasInlineStyle;
			}
		}

		/// <summary>
		/// Boolean styleInitialized
		/// </summary>
		protected RSystem.RBoolean r_PstyleInitialized;
		public virtual RSystem.RBoolean RPstyleInitialized
		{
			get
			{
				if(r_PstyleInitialized == null)
				{
					r_PstyleInitialized = new(this, "styleInitialized", -1);
					r_PstyleInitialized.SetBelong(this.instance);
				}
				return r_PstyleInitialized;
			}
		}

		/// <summary>
		/// Single opacity
		/// </summary>
		protected RSystem.RSingle r_Popacity;
		public virtual RSystem.RSingle RPopacity
		{
			get
			{
				if(r_Popacity == null)
				{
					r_Popacity = new(this, "opacity", -1);
					r_Popacity.SetBelong(this.instance);
				}
				return r_Popacity;
			}
		}

		/// <summary>
		/// Boolean enabledInHierarchy
		/// </summary>
		protected RSystem.RBoolean r_PenabledInHierarchy;
		public virtual RSystem.RBoolean RPenabledInHierarchy
		{
			get
			{
				if(r_PenabledInHierarchy == null)
				{
					r_PenabledInHierarchy = new(this, "enabledInHierarchy", -1);
					r_PenabledInHierarchy.SetBelong(this.instance);
				}
				return r_PenabledInHierarchy;
			}
		}

		/// <summary>
		/// Boolean enabledSelf
		/// </summary>
		protected RSystem.RBoolean r_PenabledSelf;
		public virtual RSystem.RBoolean RPenabledSelf
		{
			get
			{
				if(r_PenabledSelf == null)
				{
					r_PenabledSelf = new(this, "enabledSelf", -1);
					r_PenabledSelf.SetBelong(this.instance);
				}
				return r_PenabledSelf;
			}
		}

		/// <summary>
		/// Boolean visible
		/// </summary>
		protected RSystem.RBoolean r_Pvisible;
		public virtual RSystem.RBoolean RPvisible
		{
			get
			{
				if(r_Pvisible == null)
				{
					r_Pvisible = new(this, "visible", -1);
					r_Pvisible.SetBelong(this.instance);
				}
				return r_Pvisible;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.MeshGenerationContext] generateVisualContent
		/// </summary>
		protected RSystem.RAction<RUnityEngine.RUIElements.RMeshGenerationContext> r_PgenerateVisualContent;
		public virtual RSystem.RAction<RUnityEngine.RUIElements.RMeshGenerationContext> RPgenerateVisualContent
		{
			get
			{
				if(r_PgenerateVisualContent == null)
				{
					r_PgenerateVisualContent = new(this, "generateVisualContent", -1);
					r_PgenerateVisualContent.SetBelong(this.instance);
				}
				return r_PgenerateVisualContent;
			}
		}

		/// <summary>
		/// Boolean requireMeasureFunction
		/// </summary>
		protected RSystem.RBoolean r_PrequireMeasureFunction;
		public virtual RSystem.RBoolean RPrequireMeasureFunction
		{
			get
			{
				if(r_PrequireMeasureFunction == null)
				{
					r_PrequireMeasureFunction = new(this, "requireMeasureFunction", -1);
					r_PrequireMeasureFunction.SetBelong(this.instance);
				}
				return r_PrequireMeasureFunction;
			}
		}

		/// <summary>
		/// RenderTargetMode subRenderTargetMode
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement.RRenderTargetMode r_PsubRenderTargetMode;
		public virtual RUnityEngine.RUIElements.RVisualElement.RRenderTargetMode RPsubRenderTargetMode
		{
			get
			{
				if(r_PsubRenderTargetMode == null)
				{
					r_PsubRenderTargetMode = new(this, "subRenderTargetMode", -1);
					r_PsubRenderTargetMode.SetBelong(this.instance);
				}
				return r_PsubRenderTargetMode;
			}
		}

		/// <summary>
		/// UnityEngine.Material defaultMaterial
		/// </summary>
		protected RUnityEngine.RMaterial r_PdefaultMaterial;
		public virtual RUnityEngine.RMaterial RPdefaultMaterial
		{
			get
			{
				if(r_PdefaultMaterial == null)
				{
					r_PdefaultMaterial = new(this, "defaultMaterial", -1);
					r_PdefaultMaterial.SetBelong(this.instance);
				}
				return r_PdefaultMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement nextParentWithEventCallback
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_PnextParentWithEventCallback;
		public virtual RUnityEngine.RUIElements.RVisualElement RPnextParentWithEventCallback
		{
			get
			{
				if(r_PnextParentWithEventCallback == null)
				{
					r_PnextParentWithEventCallback = new(this, "nextParentWithEventCallback", -1);
					r_PnextParentWithEventCallback.SetBelong(this.instance);
				}
				return r_PnextParentWithEventCallback;
			}
		}

		/// <summary>
		/// Int32 eventCallbackCategories
		/// </summary>
		protected RSystem.RInt32 r_PeventCallbackCategories;
		public virtual RSystem.RInt32 RPeventCallbackCategories
		{
			get
			{
				if(r_PeventCallbackCategories == null)
				{
					r_PeventCallbackCategories = new(this, "eventCallbackCategories", -1);
					r_PeventCallbackCategories.SetBelong(this.instance);
				}
				return r_PeventCallbackCategories;
			}
		}

		/// <summary>
		/// Int32 eventCallbackParentCategories
		/// </summary>
		protected RSystem.RInt32 r_PeventCallbackParentCategories;
		public virtual RSystem.RInt32 RPeventCallbackParentCategories
		{
			get
			{
				if(r_PeventCallbackParentCategories == null)
				{
					r_PeventCallbackParentCategories = new(this, "eventCallbackParentCategories", -1);
					r_PeventCallbackParentCategories.SetBelong(this.instance);
				}
				return r_PeventCallbackParentCategories;
			}
		}

		/// <summary>
		/// Boolean isEventCallbackParentCategoriesDirty
		/// </summary>
		protected RSystem.RBoolean r_PisEventCallbackParentCategoriesDirty;
		public virtual RSystem.RBoolean RPisEventCallbackParentCategoriesDirty
		{
			get
			{
				if(r_PisEventCallbackParentCategoriesDirty == null)
				{
					r_PisEventCallbackParentCategoriesDirty = new(this, "isEventCallbackParentCategoriesDirty", -1);
					r_PisEventCallbackParentCategoriesDirty.SetBelong(this.instance);
				}
				return r_PisEventCallbackParentCategoriesDirty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IExperimentalFeatures experimental
		/// </summary>
		protected RUnityEngine.RUIElements.RIExperimentalFeatures r_Pexperimental;
		public virtual RUnityEngine.RUIElements.RIExperimentalFeatures RPexperimental
		{
			get
			{
				if(r_Pexperimental == null)
				{
					r_Pexperimental = new(this, "experimental", -1);
					r_Pexperimental.SetBelong(this.instance);
				}
				return r_Pexperimental;
			}
		}

		/// <summary>
		/// Hierarchy hierarchy
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement.RHierarchy r_Phierarchy;
		public virtual RUnityEngine.RUIElements.RVisualElement.RHierarchy RPhierarchy
		{
			get
			{
				if(r_Phierarchy == null)
				{
					r_Phierarchy = new(this, "hierarchy", -1);
					r_Phierarchy.SetBelong(this.instance);
				}
				return r_Phierarchy;
			}
		}

		/// <summary>
		/// Boolean isRootVisualContainer
		/// </summary>
		protected RSystem.RBoolean r_PisRootVisualContainer;
		public virtual RSystem.RBoolean RPisRootVisualContainer
		{
			get
			{
				if(r_PisRootVisualContainer == null)
				{
					r_PisRootVisualContainer = new(this, "isRootVisualContainer", -1);
					r_PisRootVisualContainer.SetBelong(this.instance);
				}
				return r_PisRootVisualContainer;
			}
		}

		/// <summary>
		/// Boolean cacheAsBitmap
		/// </summary>
		protected RSystem.RBoolean r_PcacheAsBitmap;
		public virtual RSystem.RBoolean RPcacheAsBitmap
		{
			get
			{
				if(r_PcacheAsBitmap == null)
				{
					r_PcacheAsBitmap = new(this, "cacheAsBitmap", -1);
					r_PcacheAsBitmap.SetBelong(this.instance);
				}
				return r_PcacheAsBitmap;
			}
		}

		/// <summary>
		/// Boolean disableClipping
		/// </summary>
		protected RSystem.RBoolean r_PdisableClipping;
		public virtual RSystem.RBoolean RPdisableClipping
		{
			get
			{
				if(r_PdisableClipping == null)
				{
					r_PdisableClipping = new(this, "disableClipping", -1);
					r_PdisableClipping.SetBelong(this.instance);
				}
				return r_PdisableClipping;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement parent
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_Pparent;
		public virtual RUnityEngine.RUIElements.RVisualElement RPparent
		{
			get
			{
				if(r_Pparent == null)
				{
					r_Pparent = new(this, "parent", -1);
					r_Pparent.SetBelong(this.instance);
				}
				return r_Pparent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BaseVisualElementPanel elementPanel
		/// </summary>
		protected RUnityEngine.RUIElements.RBaseVisualElementPanel r_PelementPanel;
		public virtual RUnityEngine.RUIElements.RBaseVisualElementPanel RPelementPanel
		{
			get
			{
				if(r_PelementPanel == null)
				{
					r_PelementPanel = new(this, "elementPanel", -1);
					r_PelementPanel.SetBelong(this.instance);
				}
				return r_PelementPanel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IPanel panel
		/// </summary>
		protected RUnityEngine.RUIElements.RIPanel r_Ppanel;
		public virtual RUnityEngine.RUIElements.RIPanel RPpanel
		{
			get
			{
				if(r_Ppanel == null)
				{
					r_Ppanel = new(this, "panel", -1);
					r_Ppanel.SetBelong(this.instance);
				}
				return r_Ppanel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement contentContainer
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_PcontentContainer;
		public virtual RUnityEngine.RUIElements.RVisualElement RPcontentContainer
		{
			get
			{
				if(r_PcontentContainer == null)
				{
					r_PcontentContainer = new(this, "contentContainer", -1);
					r_PcontentContainer.SetBelong(this.instance);
				}
				return r_PcontentContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset visualTreeAssetSource
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualTreeAsset r_PvisualTreeAssetSource;
		public virtual RUnityEngine.RUIElements.RVisualTreeAsset RPvisualTreeAssetSource
		{
			get
			{
				if(r_PvisualTreeAssetSource == null)
				{
					r_PvisualTreeAssetSource = new(this, "visualTreeAssetSource", -1);
					r_PvisualTreeAssetSource.SetBelong(this.instance);
				}
				return r_PvisualTreeAssetSource;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement Item [Int32]
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_PItem_Int32;
		public virtual RUnityEngine.RUIElements.RVisualElement RPItem_Int32
		{
			get
			{
				if(r_PItem_Int32 == null)
				{
					r_PItem_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_PItem_Int32.SetBelong(this.instance);
				}
				return r_PItem_Int32;
			}
		}

		/// <summary>
		/// Int32 childCount
		/// </summary>
		protected RSystem.RInt32 r_PchildCount;
		public virtual RSystem.RInt32 RPchildCount
		{
			get
			{
				if(r_PchildCount == null)
				{
					r_PchildCount = new(this, "childCount", -1);
					r_PchildCount.SetBelong(this.instance);
				}
				return r_PchildCount;
			}
		}

		/// <summary>
		/// Boolean hasDefaultRotationAndScale
		/// </summary>
		protected RSystem.RBoolean r_PhasDefaultRotationAndScale;
		public virtual RSystem.RBoolean RPhasDefaultRotationAndScale
		{
			get
			{
				if(r_PhasDefaultRotationAndScale == null)
				{
					r_PhasDefaultRotationAndScale = new(this, "hasDefaultRotationAndScale", -1);
					r_PhasDefaultRotationAndScale.SetBelong(this.instance);
				}
				return r_PhasDefaultRotationAndScale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduler schedule
		/// </summary>
		protected RUnityEngine.RUIElements.RIVisualElementScheduler r_Pschedule;
		public virtual RUnityEngine.RUIElements.RIVisualElementScheduler RPschedule
		{
			get
			{
				if(r_Pschedule == null)
				{
					r_Pschedule = new(this, "schedule", -1);
					r_Pschedule.SetBelong(this.instance);
				}
				return r_Pschedule;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IStyle style
		/// </summary>
		protected RUnityEngine.RUIElements.RIStyle r_Pstyle;
		public virtual RUnityEngine.RUIElements.RIStyle RPstyle
		{
			get
			{
				if(r_Pstyle == null)
				{
					r_Pstyle = new(this, "style", -1);
					r_Pstyle.SetBelong(this.instance);
				}
				return r_Pstyle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ICustomStyle customStyle
		/// </summary>
		protected RUnityEngine.RUIElements.RICustomStyle r_PcustomStyle;
		public virtual RUnityEngine.RUIElements.RICustomStyle RPcustomStyle
		{
			get
			{
				if(r_PcustomStyle == null)
				{
					r_PcustomStyle = new(this, "customStyle", -1);
					r_PcustomStyle.SetBelong(this.instance);
				}
				return r_PcustomStyle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementStyleSheetSet styleSheets
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElementStyleSheetSet r_PstyleSheets;
		public virtual RUnityEngine.RUIElements.RVisualElementStyleSheetSet RPstyleSheets
		{
			get
			{
				if(r_PstyleSheets == null)
				{
					r_PstyleSheets = new(this, "styleSheets", -1);
					r_PstyleSheets.SetBelong(this.instance);
				}
				return r_PstyleSheets;
			}
		}

		/// <summary>
		/// System.String tooltip
		/// </summary>
		protected RSystem.RString r_Ptooltip;
		public virtual RSystem.RString RPtooltip
		{
			get
			{
				if(r_Ptooltip == null)
				{
					r_Ptooltip = new(this, "tooltip", -1);
					r_Ptooltip.SetBelong(this.instance);
				}
				return r_Ptooltip;
			}
		}

		/// <summary>
		/// Boolean focusable
		/// </summary>
		protected RSystem.RBoolean r_Pfocusable;
		public virtual RSystem.RBoolean RPfocusable
		{
			get
			{
				if(r_Pfocusable == null)
				{
					r_Pfocusable = new(this, "focusable", -1);
					r_Pfocusable.SetBelong(this.instance);
				}
				return r_Pfocusable;
			}
		}

		/// <summary>
		/// Int32 tabIndex
		/// </summary>
		protected RSystem.RInt32 r_PtabIndex;
		public virtual RSystem.RInt32 RPtabIndex
		{
			get
			{
				if(r_PtabIndex == null)
				{
					r_PtabIndex = new(this, "tabIndex", -1);
					r_PtabIndex.SetBelong(this.instance);
				}
				return r_PtabIndex;
			}
		}

		/// <summary>
		/// Boolean delegatesFocus
		/// </summary>
		protected RSystem.RBoolean r_PdelegatesFocus;
		public virtual RSystem.RBoolean RPdelegatesFocus
		{
			get
			{
				if(r_PdelegatesFocus == null)
				{
					r_PdelegatesFocus = new(this, "delegatesFocus", -1);
					r_PdelegatesFocus.SetBelong(this.instance);
				}
				return r_PdelegatesFocus;
			}
		}

		/// <summary>
		/// Boolean excludeFromFocusRing
		/// </summary>
		protected RSystem.RBoolean r_PexcludeFromFocusRing;
		public virtual RSystem.RBoolean RPexcludeFromFocusRing
		{
			get
			{
				if(r_PexcludeFromFocusRing == null)
				{
					r_PexcludeFromFocusRing = new(this, "excludeFromFocusRing", -1);
					r_PexcludeFromFocusRing.SetBelong(this.instance);
				}
				return r_PexcludeFromFocusRing;
			}
		}

		/// <summary>
		/// Void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent)
		/// </summary>
		protected RMethod r_MOnGeometryChanged_GeometryChangedEvent;
		public virtual RMethod RMOnGeometryChanged_GeometryChangedEvent
		{
			get
			{
				if(r_MOnGeometryChanged_GeometryChangedEvent == null)
				{
					r_MOnGeometryChanged_GeometryChangedEvent = new(this, "OnGeometryChanged", 0, typeof(UnityEngine.UIElements.GeometryChangedEvent));
					r_MOnGeometryChanged_GeometryChangedEvent.SetBelong(this.instance);
				}
				return r_MOnGeometryChanged_GeometryChangedEvent;
			}
		}

		/// <summary>
		/// Void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent)
		/// </summary>
		protected RMethod r_MOnAttachToPanel_AttachToPanelEvent;
		public virtual RMethod RMOnAttachToPanel_AttachToPanelEvent
		{
			get
			{
				if(r_MOnAttachToPanel_AttachToPanelEvent == null)
				{
					r_MOnAttachToPanel_AttachToPanelEvent = new(this, "OnAttachToPanel", 0, typeof(UnityEngine.UIElements.AttachToPanelEvent));
					r_MOnAttachToPanel_AttachToPanelEvent.SetBelong(this.instance);
				}
				return r_MOnAttachToPanel_AttachToPanelEvent;
			}
		}

		/// <summary>
		/// Void OnDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent)
		/// </summary>
		protected RMethod r_MOnDetachFromPanel_DetachFromPanelEvent;
		public virtual RMethod RMOnDetachFromPanel_DetachFromPanelEvent
		{
			get
			{
				if(r_MOnDetachFromPanel_DetachFromPanelEvent == null)
				{
					r_MOnDetachFromPanel_DetachFromPanelEvent = new(this, "OnDetachFromPanel", 0, typeof(UnityEngine.UIElements.DetachFromPanelEvent));
					r_MOnDetachFromPanel_DetachFromPanelEvent.SetBelong(this.instance);
				}
				return r_MOnDetachFromPanel_DetachFromPanelEvent;
			}
		}

		/// <summary>
		/// Void OnGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext)
		/// </summary>
		protected RMethod r_MOnGenerateVisualContent_MeshGenerationContext;
		public virtual RMethod RMOnGenerateVisualContent_MeshGenerationContext
		{
			get
			{
				if(r_MOnGenerateVisualContent_MeshGenerationContext == null)
				{
					r_MOnGenerateVisualContent_MeshGenerationContext = new(this, "OnGenerateVisualContent", 0, typeof(UnityEngine.UIElements.MeshGenerationContext));
					r_MOnGenerateVisualContent_MeshGenerationContext.SetBelong(this.instance);
				}
				return r_MOnGenerateVisualContent_MeshGenerationContext;
			}
		}

		/// <summary>
		/// System.String ElideText(System.String, System.String, Single, UnityEngine.UIElements.TextOverflowPosition)
		/// </summary>
		protected RMethod r_MElideText_String_String_Single_TextOverflowPosition;
		public virtual RMethod RMElideText_String_String_Single_TextOverflowPosition
		{
			get
			{
				if(r_MElideText_String_String_Single_TextOverflowPosition == null)
				{
					r_MElideText_String_String_Single_TextOverflowPosition = new(this, "ElideText", 0, typeof(System.String), typeof(System.String), typeof(System.Single), typeof(UnityEngine.UIElements.TextOverflowPosition));
					r_MElideText_String_String_Single_TextOverflowPosition.SetBelong(this.instance);
				}
				return r_MElideText_String_String_Single_TextOverflowPosition;
			}
		}

		/// <summary>
		/// Void UpdateTooltip()
		/// </summary>
		protected RMethod r_MUpdateTooltip;
		public virtual RMethod RMUpdateTooltip
		{
			get
			{
				if(r_MUpdateTooltip == null)
				{
					r_MUpdateTooltip = new(this, "UpdateTooltip", 0);
					r_MUpdateTooltip.SetBelong(this.instance);
				}
				return r_MUpdateTooltip;
			}
		}

		/// <summary>
		/// Void UpdateVisibleText()
		/// </summary>
		protected RMethod r_MUpdateVisibleText;
		public virtual RMethod RMUpdateVisibleText
		{
			get
			{
				if(r_MUpdateVisibleText == null)
				{
					r_MUpdateVisibleText = new(this, "UpdateVisibleText", 0);
					r_MUpdateVisibleText.SetBelong(this.instance);
				}
				return r_MUpdateVisibleText;
			}
		}

		/// <summary>
		/// Boolean ShouldElide()
		/// </summary>
		protected RMethod r_MShouldElide;
		public virtual RMethod RMShouldElide
		{
			get
			{
				if(r_MShouldElide == null)
				{
					r_MShouldElide = new(this, "ShouldElide", 0);
					r_MShouldElide.SetBelong(this.instance);
				}
				return r_MShouldElide;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 MeasureTextSize(System.String, Single, MeasureMode, Single, MeasureMode)
		/// </summary>
		protected RMethod r_MMeasureTextSize_String_Single_MeasureMode_Single_MeasureMode;
		public virtual RMethod RMMeasureTextSize_String_Single_MeasureMode_Single_MeasureMode
		{
			get
			{
				if(r_MMeasureTextSize_String_Single_MeasureMode_Single_MeasureMode == null)
				{
					r_MMeasureTextSize_String_Single_MeasureMode_Single_MeasureMode = new(this, "MeasureTextSize", 0, typeof(System.String), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+MeasureMode"), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+MeasureMode"));
					r_MMeasureTextSize_String_Single_MeasureMode_Single_MeasureMode.SetBelong(this.instance);
				}
				return r_MMeasureTextSize_String_Single_MeasureMode_Single_MeasureMode;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 DoMeasure(Single, MeasureMode, Single, MeasureMode)
		/// </summary>
		protected RMethod r_MDoMeasure_Single_MeasureMode_Single_MeasureMode;
		public virtual RMethod RMDoMeasure_Single_MeasureMode_Single_MeasureMode
		{
			get
			{
				if(r_MDoMeasure_Single_MeasureMode_Single_MeasureMode == null)
				{
					r_MDoMeasure_Single_MeasureMode_Single_MeasureMode = new(this, "DoMeasure", 0, typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+MeasureMode"), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+MeasureMode"));
					r_MDoMeasure_Single_MeasureMode_Single_MeasureMode.SetBelong(this.instance);
				}
				return r_MDoMeasure_Single_MeasureMode_Single_MeasureMode;
			}
		}

		/// <summary>
		/// Void UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify(System.String)
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__INotifyValueChanged__0__System__2__String__1____2__SetValueWithoutNotify_String;
		public virtual RMethod RMUnityEngine__2__UIElements__2__INotifyValueChanged__0__System__2__String__1____2__SetValueWithoutNotify_String
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__INotifyValueChanged__0__System__2__String__1____2__SetValueWithoutNotify_String == null)
				{
					r_MUnityEngine__2__UIElements__2__INotifyValueChanged__0__System__2__String__1____2__SetValueWithoutNotify_String = new(this, "UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify", 0, typeof(System.String));
					r_MUnityEngine__2__UIElements__2__INotifyValueChanged__0__System__2__String__1____2__SetValueWithoutNotify_String.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__INotifyValueChanged__0__System__2__String__1____2__SetValueWithoutNotify_String;
			}
		}

		/// <summary>
		/// Void ProcessMenuCommand(System.String)
		/// </summary>
		protected RMethod r_MProcessMenuCommand_String;
		public virtual RMethod RMProcessMenuCommand_String
		{
			get
			{
				if(r_MProcessMenuCommand_String == null)
				{
					r_MProcessMenuCommand_String = new(this, "ProcessMenuCommand", 0, typeof(System.String));
					r_MProcessMenuCommand_String.SetBelong(this.instance);
				}
				return r_MProcessMenuCommand_String;
			}
		}

		/// <summary>
		/// Void Cut(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r_MCut_DropdownMenuAction;
		public virtual RMethod RMCut_DropdownMenuAction
		{
			get
			{
				if(r_MCut_DropdownMenuAction == null)
				{
					r_MCut_DropdownMenuAction = new(this, "Cut", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r_MCut_DropdownMenuAction.SetBelong(this.instance);
				}
				return r_MCut_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Void Copy(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r_MCopy_DropdownMenuAction;
		public virtual RMethod RMCopy_DropdownMenuAction
		{
			get
			{
				if(r_MCopy_DropdownMenuAction == null)
				{
					r_MCopy_DropdownMenuAction = new(this, "Copy", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r_MCopy_DropdownMenuAction.SetBelong(this.instance);
				}
				return r_MCopy_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Void Paste(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r_MPaste_DropdownMenuAction;
		public virtual RMethod RMPaste_DropdownMenuAction
		{
			get
			{
				if(r_MPaste_DropdownMenuAction == null)
				{
					r_MPaste_DropdownMenuAction = new(this, "Paste", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r_MPaste_DropdownMenuAction.SetBelong(this.instance);
				}
				return r_MPaste_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Void BuildContextualMenu(UnityEngine.UIElements.ContextualMenuPopulateEvent)
		/// </summary>
		protected RMethod r_MBuildContextualMenu_ContextualMenuPopulateEvent;
		public virtual RMethod RMBuildContextualMenu_ContextualMenuPopulateEvent
		{
			get
			{
				if(r_MBuildContextualMenu_ContextualMenuPopulateEvent == null)
				{
					r_MBuildContextualMenu_ContextualMenuPopulateEvent = new(this, "BuildContextualMenu", 0, typeof(UnityEngine.UIElements.ContextualMenuPopulateEvent));
					r_MBuildContextualMenu_ContextualMenuPopulateEvent.SetBelong(this.instance);
				}
				return r_MBuildContextualMenu_ContextualMenuPopulateEvent;
			}
		}

		/// <summary>
		/// Status CutActionStatus(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r_MCutActionStatus_DropdownMenuAction;
		public virtual RMethod RMCutActionStatus_DropdownMenuAction
		{
			get
			{
				if(r_MCutActionStatus_DropdownMenuAction == null)
				{
					r_MCutActionStatus_DropdownMenuAction = new(this, "CutActionStatus", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r_MCutActionStatus_DropdownMenuAction.SetBelong(this.instance);
				}
				return r_MCutActionStatus_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Status CopyActionStatus(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r_MCopyActionStatus_DropdownMenuAction;
		public virtual RMethod RMCopyActionStatus_DropdownMenuAction
		{
			get
			{
				if(r_MCopyActionStatus_DropdownMenuAction == null)
				{
					r_MCopyActionStatus_DropdownMenuAction = new(this, "CopyActionStatus", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r_MCopyActionStatus_DropdownMenuAction.SetBelong(this.instance);
				}
				return r_MCopyActionStatus_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Status PasteActionStatus(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r_MPasteActionStatus_DropdownMenuAction;
		public virtual RMethod RMPasteActionStatus_DropdownMenuAction
		{
			get
			{
				if(r_MPasteActionStatus_DropdownMenuAction == null)
				{
					r_MPasteActionStatus_DropdownMenuAction = new(this, "PasteActionStatus", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r_MPasteActionStatus_DropdownMenuAction.SetBelong(this.instance);
				}
				return r_MPasteActionStatus_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MExecuteDefaultActionAtTarget_EventBase;
		public virtual RMethod RMExecuteDefaultActionAtTarget_EventBase
		{
			get
			{
				if(r_MExecuteDefaultActionAtTarget_EventBase == null)
				{
					r_MExecuteDefaultActionAtTarget_EventBase = new(this, "ExecuteDefaultActionAtTarget", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MExecuteDefaultActionAtTarget_EventBase.SetBelong(this.instance);
				}
				return r_MExecuteDefaultActionAtTarget_EventBase;
			}
		}

		/// <summary>
		/// Void UnityEngine.UIElements.ITextEdition.ResetValueAndText()
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__ITextEdition__2__ResetValueAndText;
		public virtual RMethod RMUnityEngine__2__UIElements__2__ITextEdition__2__ResetValueAndText
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__ITextEdition__2__ResetValueAndText == null)
				{
					r_MUnityEngine__2__UIElements__2__ITextEdition__2__ResetValueAndText = new(this, "UnityEngine.UIElements.ITextEdition.ResetValueAndText", 0);
					r_MUnityEngine__2__UIElements__2__ITextEdition__2__ResetValueAndText.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__ITextEdition__2__ResetValueAndText;
			}
		}

		/// <summary>
		/// Void UnityEngine.UIElements.ITextEdition.SaveValueAndText()
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__ITextEdition__2__SaveValueAndText;
		public virtual RMethod RMUnityEngine__2__UIElements__2__ITextEdition__2__SaveValueAndText
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__ITextEdition__2__SaveValueAndText == null)
				{
					r_MUnityEngine__2__UIElements__2__ITextEdition__2__SaveValueAndText = new(this, "UnityEngine.UIElements.ITextEdition.SaveValueAndText", 0);
					r_MUnityEngine__2__UIElements__2__ITextEdition__2__SaveValueAndText.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__ITextEdition__2__SaveValueAndText;
			}
		}

		/// <summary>
		/// Void UnityEngine.UIElements.ITextEdition.RestoreValueAndText()
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__ITextEdition__2__RestoreValueAndText;
		public virtual RMethod RMUnityEngine__2__UIElements__2__ITextEdition__2__RestoreValueAndText
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__ITextEdition__2__RestoreValueAndText == null)
				{
					r_MUnityEngine__2__UIElements__2__ITextEdition__2__RestoreValueAndText = new(this, "UnityEngine.UIElements.ITextEdition.RestoreValueAndText", 0);
					r_MUnityEngine__2__UIElements__2__ITextEdition__2__RestoreValueAndText.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__ITextEdition__2__RestoreValueAndText;
			}
		}

		/// <summary>
		/// Void UnityEngine.UIElements.ITextEdition.UpdateText(System.String)
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__ITextEdition__2__UpdateText_String;
		public virtual RMethod RMUnityEngine__2__UIElements__2__ITextEdition__2__UpdateText_String
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__ITextEdition__2__UpdateText_String == null)
				{
					r_MUnityEngine__2__UIElements__2__ITextEdition__2__UpdateText_String = new(this, "UnityEngine.UIElements.ITextEdition.UpdateText", 0, typeof(System.String));
					r_MUnityEngine__2__UIElements__2__ITextEdition__2__UpdateText_String.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__ITextEdition__2__UpdateText_String;
			}
		}

		/// <summary>
		/// System.String UnityEngine.UIElements.ITextEdition.CullString(System.String)
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__ITextEdition__2__CullString_String;
		public virtual RMethod RMUnityEngine__2__UIElements__2__ITextEdition__2__CullString_String
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__ITextEdition__2__CullString_String == null)
				{
					r_MUnityEngine__2__UIElements__2__ITextEdition__2__CullString_String = new(this, "UnityEngine.UIElements.ITextEdition.CullString", 0, typeof(System.String));
					r_MUnityEngine__2__UIElements__2__ITextEdition__2__CullString_String.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__ITextEdition__2__CullString_String;
			}
		}

		/// <summary>
		/// Void UnityEngine.UIElements.ITextSelection.SelectAll()
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__ITextSelection__2__SelectAll;
		public virtual RMethod RMUnityEngine__2__UIElements__2__ITextSelection__2__SelectAll
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__ITextSelection__2__SelectAll == null)
				{
					r_MUnityEngine__2__UIElements__2__ITextSelection__2__SelectAll = new(this, "UnityEngine.UIElements.ITextSelection.SelectAll", 0);
					r_MUnityEngine__2__UIElements__2__ITextSelection__2__SelectAll.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__ITextSelection__2__SelectAll;
			}
		}

		/// <summary>
		/// Void UnityEngine.UIElements.ITextSelection.SelectNone()
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__ITextSelection__2__SelectNone;
		public virtual RMethod RMUnityEngine__2__UIElements__2__ITextSelection__2__SelectNone
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__ITextSelection__2__SelectNone == null)
				{
					r_MUnityEngine__2__UIElements__2__ITextSelection__2__SelectNone = new(this, "UnityEngine.UIElements.ITextSelection.SelectNone", 0);
					r_MUnityEngine__2__UIElements__2__ITextSelection__2__SelectNone.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__ITextSelection__2__SelectNone;
			}
		}

		/// <summary>
		/// Void UnityEngine.UIElements.ITextSelection.SelectRange(Int32, Int32)
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__ITextSelection__2__SelectRange_Int32_Int32;
		public virtual RMethod RMUnityEngine__2__UIElements__2__ITextSelection__2__SelectRange_Int32_Int32
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__ITextSelection__2__SelectRange_Int32_Int32 == null)
				{
					r_MUnityEngine__2__UIElements__2__ITextSelection__2__SelectRange_Int32_Int32 = new(this, "UnityEngine.UIElements.ITextSelection.SelectRange", 0, typeof(System.Int32), typeof(System.Int32));
					r_MUnityEngine__2__UIElements__2__ITextSelection__2__SelectRange_Int32_Int32.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__ITextSelection__2__SelectRange_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.ITextSelection.HasSelection()
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__ITextSelection__2__HasSelection;
		public virtual RMethod RMUnityEngine__2__UIElements__2__ITextSelection__2__HasSelection
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__ITextSelection__2__HasSelection == null)
				{
					r_MUnityEngine__2__UIElements__2__ITextSelection__2__HasSelection = new(this, "UnityEngine.UIElements.ITextSelection.HasSelection", 0);
					r_MUnityEngine__2__UIElements__2__ITextSelection__2__HasSelection.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__ITextSelection__2__HasSelection;
			}
		}

		/// <summary>
		/// Void UnityEngine.UIElements.ITextSelection.MoveTextEnd()
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__ITextSelection__2__MoveTextEnd;
		public virtual RMethod RMUnityEngine__2__UIElements__2__ITextSelection__2__MoveTextEnd
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__ITextSelection__2__MoveTextEnd == null)
				{
					r_MUnityEngine__2__UIElements__2__ITextSelection__2__MoveTextEnd = new(this, "UnityEngine.UIElements.ITextSelection.MoveTextEnd", 0);
					r_MUnityEngine__2__UIElements__2__ITextSelection__2__MoveTextEnd.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__ITextSelection__2__MoveTextEnd;
			}
		}

		/// <summary>
		/// Void DrawHighlighting(UnityEngine.UIElements.MeshGenerationContext)
		/// </summary>
		protected RMethod r_MDrawHighlighting_MeshGenerationContext;
		public virtual RMethod RMDrawHighlighting_MeshGenerationContext
		{
			get
			{
				if(r_MDrawHighlighting_MeshGenerationContext == null)
				{
					r_MDrawHighlighting_MeshGenerationContext = new(this, "DrawHighlighting", 0, typeof(UnityEngine.UIElements.MeshGenerationContext));
					r_MDrawHighlighting_MeshGenerationContext.SetBelong(this.instance);
				}
				return r_MDrawHighlighting_MeshGenerationContext;
			}
		}

		/// <summary>
		/// Void DrawCaret(UnityEngine.UIElements.MeshGenerationContext)
		/// </summary>
		protected RMethod r_MDrawCaret_MeshGenerationContext;
		public virtual RMethod RMDrawCaret_MeshGenerationContext
		{
			get
			{
				if(r_MDrawCaret_MeshGenerationContext == null)
				{
					r_MDrawCaret_MeshGenerationContext = new(this, "DrawCaret", 0, typeof(UnityEngine.UIElements.MeshGenerationContext));
					r_MDrawCaret_MeshGenerationContext.SetBelong(this.instance);
				}
				return r_MDrawCaret_MeshGenerationContext;
			}
		}

		/// <summary>
		/// Boolean TryConvertLengthUnits(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Length ByRef, UnityEngine.UIElements.Length ByRef, Int32)
		/// </summary>
		protected RMethod r_MTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32;
		public virtual RMethod RMTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32
		{
			get
			{
				if(r_MTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32 == null)
				{
					r_MTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32 = new(this, "TryConvertLengthUnits", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Length).MakeByRefType(), typeof(UnityEngine.UIElements.Length).MakeByRefType(), typeof(System.Int32));
					r_MTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32.SetBelong(this.instance);
				}
				return r_MTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32;
			}
		}

		/// <summary>
		/// Boolean TryConvertTransformOriginUnits(UnityEngine.UIElements.TransformOrigin ByRef, UnityEngine.UIElements.TransformOrigin ByRef)
		/// </summary>
		protected RMethod r_MTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin;
		public virtual RMethod RMTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin
		{
			get
			{
				if(r_MTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin == null)
				{
					r_MTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin = new(this, "TryConvertTransformOriginUnits", 0, typeof(UnityEngine.UIElements.TransformOrigin).MakeByRefType(), typeof(UnityEngine.UIElements.TransformOrigin).MakeByRefType());
					r_MTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin.SetBelong(this.instance);
				}
				return r_MTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin;
			}
		}

		/// <summary>
		/// Boolean TryConvertTranslateUnits(UnityEngine.UIElements.Translate ByRef, UnityEngine.UIElements.Translate ByRef)
		/// </summary>
		protected RMethod r_MTryConvertTranslateUnits_Ref_Translate_Ref_Translate;
		public virtual RMethod RMTryConvertTranslateUnits_Ref_Translate_Ref_Translate
		{
			get
			{
				if(r_MTryConvertTranslateUnits_Ref_Translate_Ref_Translate == null)
				{
					r_MTryConvertTranslateUnits_Ref_Translate_Ref_Translate = new(this, "TryConvertTranslateUnits", 0, typeof(UnityEngine.UIElements.Translate).MakeByRefType(), typeof(UnityEngine.UIElements.Translate).MakeByRefType());
					r_MTryConvertTranslateUnits_Ref_Translate_Ref_Translate.SetBelong(this.instance);
				}
				return r_MTryConvertTranslateUnits_Ref_Translate_Ref_Translate;
			}
		}

		/// <summary>
		/// Boolean TryConvertBackgroundPositionUnits(UnityEngine.UIElements.BackgroundPosition ByRef, UnityEngine.UIElements.BackgroundPosition ByRef)
		/// </summary>
		protected RMethod r_MTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition;
		public virtual RMethod RMTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition
		{
			get
			{
				if(r_MTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition == null)
				{
					r_MTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition = new(this, "TryConvertBackgroundPositionUnits", 0, typeof(UnityEngine.UIElements.BackgroundPosition).MakeByRefType(), typeof(UnityEngine.UIElements.BackgroundPosition).MakeByRefType());
					r_MTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition.SetBelong(this.instance);
				}
				return r_MTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition;
			}
		}

		/// <summary>
		/// Boolean TryConvertBackgroundSizeUnits(UnityEngine.UIElements.BackgroundSize ByRef, UnityEngine.UIElements.BackgroundSize ByRef)
		/// </summary>
		protected RMethod r_MTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize;
		public virtual RMethod RMTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize
		{
			get
			{
				if(r_MTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize == null)
				{
					r_MTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize = new(this, "TryConvertBackgroundSizeUnits", 0, typeof(UnityEngine.UIElements.BackgroundSize).MakeByRefType(), typeof(UnityEngine.UIElements.BackgroundSize).MakeByRefType());
					r_MTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize.SetBelong(this.instance);
				}
				return r_MTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize;
			}
		}

		/// <summary>
		/// Void MarkRenderHintsClean()
		/// </summary>
		protected RMethod r_MMarkRenderHintsClean;
		public virtual RMethod RMMarkRenderHintsClean
		{
			get
			{
				if(r_MMarkRenderHintsClean == null)
				{
					r_MMarkRenderHintsClean = new(this, "MarkRenderHintsClean", 0);
					r_MMarkRenderHintsClean.SetBelong(this.instance);
				}
				return r_MMarkRenderHintsClean;
			}
		}

		/// <summary>
		/// Void UpdateBoundingBox()
		/// </summary>
		protected RMethod r_MUpdateBoundingBox;
		public virtual RMethod RMUpdateBoundingBox
		{
			get
			{
				if(r_MUpdateBoundingBox == null)
				{
					r_MUpdateBoundingBox = new(this, "UpdateBoundingBox", 0);
					r_MUpdateBoundingBox.SetBelong(this.instance);
				}
				return r_MUpdateBoundingBox;
			}
		}

		/// <summary>
		/// Void UpdateWorldBoundingBox()
		/// </summary>
		protected RMethod r_MUpdateWorldBoundingBox;
		public virtual RMethod RMUpdateWorldBoundingBox
		{
			get
			{
				if(r_MUpdateWorldBoundingBox == null)
				{
					r_MUpdateWorldBoundingBox = new(this, "UpdateWorldBoundingBox", 0);
					r_MUpdateWorldBoundingBox.SetBelong(this.instance);
				}
				return r_MUpdateWorldBoundingBox;
			}
		}

		/// <summary>
		/// Void UpdateWorldTransform()
		/// </summary>
		protected RMethod r_MUpdateWorldTransform;
		public virtual RMethod RMUpdateWorldTransform
		{
			get
			{
				if(r_MUpdateWorldTransform == null)
				{
					r_MUpdateWorldTransform = new(this, "UpdateWorldTransform", 0);
					r_MUpdateWorldTransform.SetBelong(this.instance);
				}
				return r_MUpdateWorldTransform;
			}
		}

		/// <summary>
		/// Void UpdateWorldTransformInverse()
		/// </summary>
		protected RMethod r_MUpdateWorldTransformInverse;
		public virtual RMethod RMUpdateWorldTransformInverse
		{
			get
			{
				if(r_MUpdateWorldTransformInverse == null)
				{
					r_MUpdateWorldTransformInverse = new(this, "UpdateWorldTransformInverse", 0);
					r_MUpdateWorldTransformInverse.SetBelong(this.instance);
				}
				return r_MUpdateWorldTransformInverse;
			}
		}

		/// <summary>
		/// Void EnsureWorldTransformAndClipUpToDate()
		/// </summary>
		protected RMethod r_MEnsureWorldTransformAndClipUpToDate;
		public virtual RMethod RMEnsureWorldTransformAndClipUpToDate
		{
			get
			{
				if(r_MEnsureWorldTransformAndClipUpToDate == null)
				{
					r_MEnsureWorldTransformAndClipUpToDate = new(this, "EnsureWorldTransformAndClipUpToDate", 0);
					r_MEnsureWorldTransformAndClipUpToDate.SetBelong(this.instance);
				}
				return r_MEnsureWorldTransformAndClipUpToDate;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MExecuteDefaultAction_EventBase;
		public virtual RMethod RMExecuteDefaultAction_EventBase
		{
			get
			{
				if(r_MExecuteDefaultAction_EventBase == null)
				{
					r_MExecuteDefaultAction_EventBase = new(this, "ExecuteDefaultAction", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MExecuteDefaultAction_EventBase.SetBelong(this.instance);
				}
				return r_MExecuteDefaultAction_EventBase;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetTooltipRect()
		/// </summary>
		protected RMethod r_MGetTooltipRect;
		public virtual RMethod RMGetTooltipRect
		{
			get
			{
				if(r_MGetTooltipRect == null)
				{
					r_MGetTooltipRect = new(this, "GetTooltipRect", 0);
					r_MGetTooltipRect.SetBelong(this.instance);
				}
				return r_MGetTooltipRect;
			}
		}

		/// <summary>
		/// Void Focus()
		/// </summary>
		protected RMethod r_MFocus;
		public virtual RMethod RMFocus
		{
			get
			{
				if(r_MFocus == null)
				{
					r_MFocus = new(this, "Focus", 0);
					r_MFocus.SetBelong(this.instance);
				}
				return r_MFocus;
			}
		}

		/// <summary>
		/// Void SetPanel(UnityEngine.UIElements.BaseVisualElementPanel)
		/// </summary>
		protected RMethod r_MSetPanel_BaseVisualElementPanel;
		public virtual RMethod RMSetPanel_BaseVisualElementPanel
		{
			get
			{
				if(r_MSetPanel_BaseVisualElementPanel == null)
				{
					r_MSetPanel_BaseVisualElementPanel = new(this, "SetPanel", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.BaseVisualElementPanel"));
					r_MSetPanel_BaseVisualElementPanel.SetBelong(this.instance);
				}
				return r_MSetPanel_BaseVisualElementPanel;
			}
		}

		/// <summary>
		/// Void SendEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MSendEvent_EventBase;
		public virtual RMethod RMSendEvent_EventBase
		{
			get
			{
				if(r_MSendEvent_EventBase == null)
				{
					r_MSendEvent_EventBase = new(this, "SendEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MSendEvent_EventBase.SetBelong(this.instance);
				}
				return r_MSendEvent_EventBase;
			}
		}

		/// <summary>
		/// Void SendEvent(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.DispatchMode)
		/// </summary>
		protected RMethod r_MSendEvent_EventBase_DispatchMode;
		public virtual RMethod RMSendEvent_EventBase_DispatchMode
		{
			get
			{
				if(r_MSendEvent_EventBase_DispatchMode == null)
				{
					r_MSendEvent_EventBase_DispatchMode = new(this, "SendEvent", 0, typeof(UnityEngine.UIElements.EventBase),  ReflectionUtils.GetType("UnityEngine.UIElements.DispatchMode"));
					r_MSendEvent_EventBase_DispatchMode.SetBelong(this.instance);
				}
				return r_MSendEvent_EventBase_DispatchMode;
			}
		}

		/// <summary>
		/// Void IncrementVersion(UnityEngine.UIElements.VersionChangeType)
		/// </summary>
		protected RMethod r_MIncrementVersion_VersionChangeType;
		public virtual RMethod RMIncrementVersion_VersionChangeType
		{
			get
			{
				if(r_MIncrementVersion_VersionChangeType == null)
				{
					r_MIncrementVersion_VersionChangeType = new(this, "IncrementVersion", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VersionChangeType"));
					r_MIncrementVersion_VersionChangeType.SetBelong(this.instance);
				}
				return r_MIncrementVersion_VersionChangeType;
			}
		}

		/// <summary>
		/// Void InvokeHierarchyChanged(UnityEngine.UIElements.HierarchyChangeType)
		/// </summary>
		protected RMethod r_MInvokeHierarchyChanged_HierarchyChangeType;
		public virtual RMethod RMInvokeHierarchyChanged_HierarchyChangeType
		{
			get
			{
				if(r_MInvokeHierarchyChanged_HierarchyChangeType == null)
				{
					r_MInvokeHierarchyChanged_HierarchyChangeType = new(this, "InvokeHierarchyChanged", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.HierarchyChangeType"));
					r_MInvokeHierarchyChanged_HierarchyChangeType.SetBelong(this.instance);
				}
				return r_MInvokeHierarchyChanged_HierarchyChangeType;
			}
		}

		/// <summary>
		/// Boolean SetEnabledFromHierarchy(Boolean)
		/// </summary>
		protected RMethod r_MSetEnabledFromHierarchy_Boolean;
		public virtual RMethod RMSetEnabledFromHierarchy_Boolean
		{
			get
			{
				if(r_MSetEnabledFromHierarchy_Boolean == null)
				{
					r_MSetEnabledFromHierarchy_Boolean = new(this, "SetEnabledFromHierarchy", 0, typeof(System.Boolean));
					r_MSetEnabledFromHierarchy_Boolean.SetBelong(this.instance);
				}
				return r_MSetEnabledFromHierarchy_Boolean;
			}
		}

		/// <summary>
		/// Void SetEnabled(Boolean)
		/// </summary>
		protected RMethod r_MSetEnabled_Boolean;
		public virtual RMethod RMSetEnabled_Boolean
		{
			get
			{
				if(r_MSetEnabled_Boolean == null)
				{
					r_MSetEnabled_Boolean = new(this, "SetEnabled", 0, typeof(System.Boolean));
					r_MSetEnabled_Boolean.SetBelong(this.instance);
				}
				return r_MSetEnabled_Boolean;
			}
		}

		/// <summary>
		/// Void MarkDirtyRepaint()
		/// </summary>
		protected RMethod r_MMarkDirtyRepaint;
		public virtual RMethod RMMarkDirtyRepaint
		{
			get
			{
				if(r_MMarkDirtyRepaint == null)
				{
					r_MMarkDirtyRepaint = new(this, "MarkDirtyRepaint", 0);
					r_MMarkDirtyRepaint.SetBelong(this.instance);
				}
				return r_MMarkDirtyRepaint;
			}
		}

		/// <summary>
		/// Void InvokeGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext)
		/// </summary>
		protected RMethod r_MInvokeGenerateVisualContent_MeshGenerationContext;
		public virtual RMethod RMInvokeGenerateVisualContent_MeshGenerationContext
		{
			get
			{
				if(r_MInvokeGenerateVisualContent_MeshGenerationContext == null)
				{
					r_MInvokeGenerateVisualContent_MeshGenerationContext = new(this, "InvokeGenerateVisualContent", 0, typeof(UnityEngine.UIElements.MeshGenerationContext));
					r_MInvokeGenerateVisualContent_MeshGenerationContext.SetBelong(this.instance);
				}
				return r_MInvokeGenerateVisualContent_MeshGenerationContext;
			}
		}

		/// <summary>
		/// Void GetFullHierarchicalViewDataKey(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_MGetFullHierarchicalViewDataKey_StringBuilder;
		public virtual RMethod RMGetFullHierarchicalViewDataKey_StringBuilder
		{
			get
			{
				if(r_MGetFullHierarchicalViewDataKey_StringBuilder == null)
				{
					r_MGetFullHierarchicalViewDataKey_StringBuilder = new(this, "GetFullHierarchicalViewDataKey", 0, typeof(System.Text.StringBuilder));
					r_MGetFullHierarchicalViewDataKey_StringBuilder.SetBelong(this.instance);
				}
				return r_MGetFullHierarchicalViewDataKey_StringBuilder;
			}
		}

		/// <summary>
		/// System.String GetFullHierarchicalViewDataKey()
		/// </summary>
		protected RMethod r_MGetFullHierarchicalViewDataKey;
		public virtual RMethod RMGetFullHierarchicalViewDataKey
		{
			get
			{
				if(r_MGetFullHierarchicalViewDataKey == null)
				{
					r_MGetFullHierarchicalViewDataKey = new(this, "GetFullHierarchicalViewDataKey", 0);
					r_MGetFullHierarchicalViewDataKey.SetBelong(this.instance);
				}
				return r_MGetFullHierarchicalViewDataKey;
			}
		}

		/// <summary>
		/// T GetOrCreateViewData[T](System.Object, System.String)
		/// </summary>
		protected RMethod r_MGetOrCreateViewData_GT_Object_String;
		public virtual RMethod RMGetOrCreateViewData_GT_Object_String
		{
			get
			{
				if(r_MGetOrCreateViewData_GT_Object_String == null)
				{
					r_MGetOrCreateViewData_GT_Object_String = new(this, "GetOrCreateViewData", 1, typeof(System.Object), typeof(System.String));
					r_MGetOrCreateViewData_GT_Object_String.SetBelong(this.instance);
				}
				return r_MGetOrCreateViewData_GT_Object_String;
			}
		}

		/// <summary>
		/// T GetOrCreateViewData[T](UnityEngine.ScriptableObject, System.String)
		/// </summary>
		protected RMethod r_MGetOrCreateViewData_GT_ScriptableObject_String;
		public virtual RMethod RMGetOrCreateViewData_GT_ScriptableObject_String
		{
			get
			{
				if(r_MGetOrCreateViewData_GT_ScriptableObject_String == null)
				{
					r_MGetOrCreateViewData_GT_ScriptableObject_String = new(this, "GetOrCreateViewData", 1, typeof(UnityEngine.ScriptableObject), typeof(System.String));
					r_MGetOrCreateViewData_GT_ScriptableObject_String.SetBelong(this.instance);
				}
				return r_MGetOrCreateViewData_GT_ScriptableObject_String;
			}
		}

		/// <summary>
		/// Void OverwriteFromViewData(System.Object, System.String)
		/// </summary>
		protected RMethod r_MOverwriteFromViewData_Object_String;
		public virtual RMethod RMOverwriteFromViewData_Object_String
		{
			get
			{
				if(r_MOverwriteFromViewData_Object_String == null)
				{
					r_MOverwriteFromViewData_Object_String = new(this, "OverwriteFromViewData", 0, typeof(System.Object), typeof(System.String));
					r_MOverwriteFromViewData_Object_String.SetBelong(this.instance);
				}
				return r_MOverwriteFromViewData_Object_String;
			}
		}

		/// <summary>
		/// Void SaveViewData()
		/// </summary>
		protected RMethod r_MSaveViewData;
		public virtual RMethod RMSaveViewData
		{
			get
			{
				if(r_MSaveViewData == null)
				{
					r_MSaveViewData = new(this, "SaveViewData", 0);
					r_MSaveViewData.SetBelong(this.instance);
				}
				return r_MSaveViewData;
			}
		}

		/// <summary>
		/// Boolean IsViewDataPersitenceSupportedOnChildren(Boolean)
		/// </summary>
		protected RMethod r_MIsViewDataPersitenceSupportedOnChildren_Boolean;
		public virtual RMethod RMIsViewDataPersitenceSupportedOnChildren_Boolean
		{
			get
			{
				if(r_MIsViewDataPersitenceSupportedOnChildren_Boolean == null)
				{
					r_MIsViewDataPersitenceSupportedOnChildren_Boolean = new(this, "IsViewDataPersitenceSupportedOnChildren", 0, typeof(System.Boolean));
					r_MIsViewDataPersitenceSupportedOnChildren_Boolean.SetBelong(this.instance);
				}
				return r_MIsViewDataPersitenceSupportedOnChildren_Boolean;
			}
		}

		/// <summary>
		/// Void OnViewDataReady(Boolean)
		/// </summary>
		protected RMethod r_MOnViewDataReady_Boolean;
		public virtual RMethod RMOnViewDataReady_Boolean
		{
			get
			{
				if(r_MOnViewDataReady_Boolean == null)
				{
					r_MOnViewDataReady_Boolean = new(this, "OnViewDataReady", 0, typeof(System.Boolean));
					r_MOnViewDataReady_Boolean.SetBelong(this.instance);
				}
				return r_MOnViewDataReady_Boolean;
			}
		}

		/// <summary>
		/// Void OnViewDataReady()
		/// </summary>
		protected RMethod r_MOnViewDataReady;
		public virtual RMethod RMOnViewDataReady
		{
			get
			{
				if(r_MOnViewDataReady == null)
				{
					r_MOnViewDataReady = new(this, "OnViewDataReady", 0);
					r_MOnViewDataReady.SetBelong(this.instance);
				}
				return r_MOnViewDataReady;
			}
		}

		/// <summary>
		/// Boolean ContainsPoint(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MContainsPoint_Vector2;
		public virtual RMethod RMContainsPoint_Vector2
		{
			get
			{
				if(r_MContainsPoint_Vector2 == null)
				{
					r_MContainsPoint_Vector2 = new(this, "ContainsPoint", 0, typeof(UnityEngine.Vector2));
					r_MContainsPoint_Vector2.SetBelong(this.instance);
				}
				return r_MContainsPoint_Vector2;
			}
		}

		/// <summary>
		/// Boolean Overlaps(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MOverlaps_Rect;
		public virtual RMethod RMOverlaps_Rect
		{
			get
			{
				if(r_MOverlaps_Rect == null)
				{
					r_MOverlaps_Rect = new(this, "Overlaps", 0, typeof(UnityEngine.Rect));
					r_MOverlaps_Rect.SetBelong(this.instance);
				}
				return r_MOverlaps_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaSize Measure(UnityEngine.Yoga.YogaNode, Single, UnityEngine.Yoga.YogaMeasureMode, Single, UnityEngine.Yoga.YogaMeasureMode)
		/// </summary>
		protected RMethod r_MMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode;
		public virtual RMethod RMMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode
		{
			get
			{
				if(r_MMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode == null)
				{
					r_MMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode = new(this, "Measure", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.YogaNode"), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Yoga.YogaMeasureMode"), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Yoga.YogaMeasureMode"));
					r_MMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode.SetBelong(this.instance);
				}
				return r_MMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode;
			}
		}

		/// <summary>
		/// Void SetSize(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetSize_Vector2;
		public virtual RMethod RMSetSize_Vector2
		{
			get
			{
				if(r_MSetSize_Vector2 == null)
				{
					r_MSetSize_Vector2 = new(this, "SetSize", 0, typeof(UnityEngine.Vector2));
					r_MSetSize_Vector2.SetBelong(this.instance);
				}
				return r_MSetSize_Vector2;
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
					r_MSetInlineRule_StyleSheet_StyleRule.SetBelong(this.instance);
				}
				return r_MSetInlineRule_StyleSheet_StyleRule;
			}
		}

		/// <summary>
		/// Void UpdateInlineRule(UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleRule)
		/// </summary>
		protected RMethod r_MUpdateInlineRule_StyleSheet_StyleRule;
		public virtual RMethod RMUpdateInlineRule_StyleSheet_StyleRule
		{
			get
			{
				if(r_MUpdateInlineRule_StyleSheet_StyleRule == null)
				{
					r_MUpdateInlineRule_StyleSheet_StyleRule = new(this, "UpdateInlineRule", 0, typeof(UnityEngine.UIElements.StyleSheet),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleRule"));
					r_MUpdateInlineRule_StyleSheet_StyleRule.SetBelong(this.instance);
				}
				return r_MUpdateInlineRule_StyleSheet_StyleRule;
			}
		}

		/// <summary>
		/// Void SetComputedStyle(UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_MSetComputedStyle_Ref_ComputedStyle;
		public virtual RMethod RMSetComputedStyle_Ref_ComputedStyle
		{
			get
			{
				if(r_MSetComputedStyle_Ref_ComputedStyle == null)
				{
					r_MSetComputedStyle_Ref_ComputedStyle = new(this, "SetComputedStyle", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_MSetComputedStyle_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_MSetComputedStyle_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Void ResetPositionProperties()
		/// </summary>
		protected RMethod r_MResetPositionProperties;
		public virtual RMethod RMResetPositionProperties
		{
			get
			{
				if(r_MResetPositionProperties == null)
				{
					r_MResetPositionProperties = new(this, "ResetPositionProperties", 0);
					r_MResetPositionProperties.SetBelong(this.instance);
				}
				return r_MResetPositionProperties;
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
		/// System.Collections.Generic.IEnumerable`1[System.String] GetClasses()
		/// </summary>
		protected RMethod r_MGetClasses;
		public virtual RMethod RMGetClasses
		{
			get
			{
				if(r_MGetClasses == null)
				{
					r_MGetClasses = new(this, "GetClasses", 0);
					r_MGetClasses.SetBelong(this.instance);
				}
				return r_MGetClasses;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] GetClassesForIteration()
		/// </summary>
		protected RMethod r_MGetClassesForIteration;
		public virtual RMethod RMGetClassesForIteration
		{
			get
			{
				if(r_MGetClassesForIteration == null)
				{
					r_MGetClassesForIteration = new(this, "GetClassesForIteration", 0);
					r_MGetClassesForIteration.SetBelong(this.instance);
				}
				return r_MGetClassesForIteration;
			}
		}

		/// <summary>
		/// Void ClearClassList()
		/// </summary>
		protected RMethod r_MClearClassList;
		public virtual RMethod RMClearClassList
		{
			get
			{
				if(r_MClearClassList == null)
				{
					r_MClearClassList = new(this, "ClearClassList", 0);
					r_MClearClassList.SetBelong(this.instance);
				}
				return r_MClearClassList;
			}
		}

		/// <summary>
		/// Void AddToClassList(System.String)
		/// </summary>
		protected RMethod r_MAddToClassList_String;
		public virtual RMethod RMAddToClassList_String
		{
			get
			{
				if(r_MAddToClassList_String == null)
				{
					r_MAddToClassList_String = new(this, "AddToClassList", 0, typeof(System.String));
					r_MAddToClassList_String.SetBelong(this.instance);
				}
				return r_MAddToClassList_String;
			}
		}

		/// <summary>
		/// Void RemoveFromClassList(System.String)
		/// </summary>
		protected RMethod r_MRemoveFromClassList_String;
		public virtual RMethod RMRemoveFromClassList_String
		{
			get
			{
				if(r_MRemoveFromClassList_String == null)
				{
					r_MRemoveFromClassList_String = new(this, "RemoveFromClassList", 0, typeof(System.String));
					r_MRemoveFromClassList_String.SetBelong(this.instance);
				}
				return r_MRemoveFromClassList_String;
			}
		}

		/// <summary>
		/// Void ToggleInClassList(System.String)
		/// </summary>
		protected RMethod r_MToggleInClassList_String;
		public virtual RMethod RMToggleInClassList_String
		{
			get
			{
				if(r_MToggleInClassList_String == null)
				{
					r_MToggleInClassList_String = new(this, "ToggleInClassList", 0, typeof(System.String));
					r_MToggleInClassList_String.SetBelong(this.instance);
				}
				return r_MToggleInClassList_String;
			}
		}

		/// <summary>
		/// Void EnableInClassList(System.String, Boolean)
		/// </summary>
		protected RMethod r_MEnableInClassList_String_Boolean;
		public virtual RMethod RMEnableInClassList_String_Boolean
		{
			get
			{
				if(r_MEnableInClassList_String_Boolean == null)
				{
					r_MEnableInClassList_String_Boolean = new(this, "EnableInClassList", 0, typeof(System.String), typeof(System.Boolean));
					r_MEnableInClassList_String_Boolean.SetBelong(this.instance);
				}
				return r_MEnableInClassList_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean ClassListContains(System.String)
		/// </summary>
		protected RMethod r_MClassListContains_String;
		public virtual RMethod RMClassListContains_String
		{
			get
			{
				if(r_MClassListContains_String == null)
				{
					r_MClassListContains_String = new(this, "ClassListContains", 0, typeof(System.String));
					r_MClassListContains_String.SetBelong(this.instance);
				}
				return r_MClassListContains_String;
			}
		}

		/// <summary>
		/// System.Object FindAncestorUserData()
		/// </summary>
		protected RMethod r_MFindAncestorUserData;
		public virtual RMethod RMFindAncestorUserData
		{
			get
			{
				if(r_MFindAncestorUserData == null)
				{
					r_MFindAncestorUserData = new(this, "FindAncestorUserData", 0);
					r_MFindAncestorUserData.SetBelong(this.instance);
				}
				return r_MFindAncestorUserData;
			}
		}

		/// <summary>
		/// System.Object GetProperty(UnityEngine.PropertyName)
		/// </summary>
		protected RMethod r_MGetProperty_PropertyName;
		public virtual RMethod RMGetProperty_PropertyName
		{
			get
			{
				if(r_MGetProperty_PropertyName == null)
				{
					r_MGetProperty_PropertyName = new(this, "GetProperty", 0, typeof(UnityEngine.PropertyName));
					r_MGetProperty_PropertyName.SetBelong(this.instance);
				}
				return r_MGetProperty_PropertyName;
			}
		}

		/// <summary>
		/// Void SetProperty(UnityEngine.PropertyName, System.Object)
		/// </summary>
		protected RMethod r_MSetProperty_PropertyName_Object;
		public virtual RMethod RMSetProperty_PropertyName_Object
		{
			get
			{
				if(r_MSetProperty_PropertyName_Object == null)
				{
					r_MSetProperty_PropertyName_Object = new(this, "SetProperty", 0, typeof(UnityEngine.PropertyName), typeof(System.Object));
					r_MSetProperty_PropertyName_Object.SetBelong(this.instance);
				}
				return r_MSetProperty_PropertyName_Object;
			}
		}

		/// <summary>
		/// Boolean HasProperty(UnityEngine.PropertyName)
		/// </summary>
		protected RMethod r_MHasProperty_PropertyName;
		public virtual RMethod RMHasProperty_PropertyName
		{
			get
			{
				if(r_MHasProperty_PropertyName == null)
				{
					r_MHasProperty_PropertyName = new(this, "HasProperty", 0, typeof(UnityEngine.PropertyName));
					r_MHasProperty_PropertyName.SetBelong(this.instance);
				}
				return r_MHasProperty_PropertyName;
			}
		}

		/// <summary>
		/// Void ApplyPlayerRenderingToEditorElement()
		/// </summary>
		protected RMethod r_MApplyPlayerRenderingToEditorElement;
		public virtual RMethod RMApplyPlayerRenderingToEditorElement
		{
			get
			{
				if(r_MApplyPlayerRenderingToEditorElement == null)
				{
					r_MApplyPlayerRenderingToEditorElement = new(this, "ApplyPlayerRenderingToEditorElement", 0);
					r_MApplyPlayerRenderingToEditorElement.SetBelong(this.instance);
				}
				return r_MApplyPlayerRenderingToEditorElement;
			}
		}

		/// <summary>
		/// Void RegisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate)
		/// </summary>
		protected RMethod r_MRegisterAnimation_IValueAnimationUpdate;
		public virtual RMethod RMRegisterAnimation_IValueAnimationUpdate
		{
			get
			{
				if(r_MRegisterAnimation_IValueAnimationUpdate == null)
				{
					r_MRegisterAnimation_IValueAnimationUpdate = new(this, "RegisterAnimation", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.Experimental.IValueAnimationUpdate"));
					r_MRegisterAnimation_IValueAnimationUpdate.SetBelong(this.instance);
				}
				return r_MRegisterAnimation_IValueAnimationUpdate;
			}
		}

		/// <summary>
		/// Void UnregisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate)
		/// </summary>
		protected RMethod r_MUnregisterAnimation_IValueAnimationUpdate;
		public virtual RMethod RMUnregisterAnimation_IValueAnimationUpdate
		{
			get
			{
				if(r_MUnregisterAnimation_IValueAnimationUpdate == null)
				{
					r_MUnregisterAnimation_IValueAnimationUpdate = new(this, "UnregisterAnimation", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.Experimental.IValueAnimationUpdate"));
					r_MUnregisterAnimation_IValueAnimationUpdate.SetBelong(this.instance);
				}
				return r_MUnregisterAnimation_IValueAnimationUpdate;
			}
		}

		/// <summary>
		/// Boolean GetCachedNextParentWithEventCallback(UnityEngine.UIElements.VisualElement ByRef)
		/// </summary>
		protected RMethod r_MGetCachedNextParentWithEventCallback_Out_VisualElement;
		public virtual RMethod RMGetCachedNextParentWithEventCallback_Out_VisualElement
		{
			get
			{
				if(r_MGetCachedNextParentWithEventCallback_Out_VisualElement == null)
				{
					r_MGetCachedNextParentWithEventCallback_Out_VisualElement = new(this, "GetCachedNextParentWithEventCallback", 0, typeof(UnityEngine.UIElements.VisualElement).MakeByRefType());
					r_MGetCachedNextParentWithEventCallback_Out_VisualElement.SetBelong(this.instance);
				}
				return r_MGetCachedNextParentWithEventCallback_Out_VisualElement;
			}
		}

		/// <summary>
		/// Boolean HasEventCallbacks(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_MHasEventCallbacks_EventCategory;
		public virtual RMethod RMHasEventCallbacks_EventCategory
		{
			get
			{
				if(r_MHasEventCallbacks_EventCategory == null)
				{
					r_MHasEventCallbacks_EventCategory = new(this, "HasEventCallbacks", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_MHasEventCallbacks_EventCategory.SetBelong(this.instance);
				}
				return r_MHasEventCallbacks_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasParentEventCallbacks(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_MHasParentEventCallbacks_EventCategory;
		public virtual RMethod RMHasParentEventCallbacks_EventCategory
		{
			get
			{
				if(r_MHasParentEventCallbacks_EventCategory == null)
				{
					r_MHasParentEventCallbacks_EventCategory = new(this, "HasParentEventCallbacks", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_MHasParentEventCallbacks_EventCategory.SetBelong(this.instance);
				}
				return r_MHasParentEventCallbacks_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasParentEventCallbacksOrDefaultActions(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_MHasParentEventCallbacksOrDefaultActions_EventCategory;
		public virtual RMethod RMHasParentEventCallbacksOrDefaultActions_EventCategory
		{
			get
			{
				if(r_MHasParentEventCallbacksOrDefaultActions_EventCategory == null)
				{
					r_MHasParentEventCallbacksOrDefaultActions_EventCategory = new(this, "HasParentEventCallbacksOrDefaultActions", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_MHasParentEventCallbacksOrDefaultActions_EventCategory.SetBelong(this.instance);
				}
				return r_MHasParentEventCallbacksOrDefaultActions_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasEventCallbacksOrDefaultActions(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_MHasEventCallbacksOrDefaultActions_EventCategory;
		public virtual RMethod RMHasEventCallbacksOrDefaultActions_EventCategory
		{
			get
			{
				if(r_MHasEventCallbacksOrDefaultActions_EventCategory == null)
				{
					r_MHasEventCallbacksOrDefaultActions_EventCategory = new(this, "HasEventCallbacksOrDefaultActions", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_MHasEventCallbacksOrDefaultActions_EventCategory.SetBelong(this.instance);
				}
				return r_MHasEventCallbacksOrDefaultActions_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasParentEventCallbacksOrDefaultActionAtTarget(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_MHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory;
		public virtual RMethod RMHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory
		{
			get
			{
				if(r_MHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory == null)
				{
					r_MHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory = new(this, "HasParentEventCallbacksOrDefaultActionAtTarget", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_MHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory.SetBelong(this.instance);
				}
				return r_MHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasEventCallbacksOrDefaultActionAtTarget(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_MHasEventCallbacksOrDefaultActionAtTarget_EventCategory;
		public virtual RMethod RMHasEventCallbacksOrDefaultActionAtTarget_EventCategory
		{
			get
			{
				if(r_MHasEventCallbacksOrDefaultActionAtTarget_EventCategory == null)
				{
					r_MHasEventCallbacksOrDefaultActionAtTarget_EventCategory = new(this, "HasEventCallbacksOrDefaultActionAtTarget", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_MHasEventCallbacksOrDefaultActionAtTarget_EventCategory.SetBelong(this.instance);
				}
				return r_MHasEventCallbacksOrDefaultActionAtTarget_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasDefaultAction(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_MHasDefaultAction_EventCategory;
		public virtual RMethod RMHasDefaultAction_EventCategory
		{
			get
			{
				if(r_MHasDefaultAction_EventCategory == null)
				{
					r_MHasDefaultAction_EventCategory = new(this, "HasDefaultAction", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_MHasDefaultAction_EventCategory.SetBelong(this.instance);
				}
				return r_MHasDefaultAction_EventCategory;
			}
		}

		/// <summary>
		/// Boolean ShouldClip()
		/// </summary>
		protected RMethod r_MShouldClip;
		public virtual RMethod RMShouldClip
		{
			get
			{
				if(r_MShouldClip == null)
				{
					r_MShouldClip = new(this, "ShouldClip", 0);
					r_MShouldClip.SetBelong(this.instance);
				}
				return r_MShouldClip;
			}
		}

		/// <summary>
		/// Void Add(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MAdd_VisualElement;
		public virtual RMethod RMAdd_VisualElement
		{
			get
			{
				if(r_MAdd_VisualElement == null)
				{
					r_MAdd_VisualElement = new(this, "Add", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MAdd_VisualElement.SetBelong(this.instance);
				}
				return r_MAdd_VisualElement;
			}
		}

		/// <summary>
		/// Void Insert(Int32, UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MInsert_Int32_VisualElement;
		public virtual RMethod RMInsert_Int32_VisualElement
		{
			get
			{
				if(r_MInsert_Int32_VisualElement == null)
				{
					r_MInsert_Int32_VisualElement = new(this, "Insert", 0, typeof(System.Int32), typeof(UnityEngine.UIElements.VisualElement));
					r_MInsert_Int32_VisualElement.SetBelong(this.instance);
				}
				return r_MInsert_Int32_VisualElement;
			}
		}

		/// <summary>
		/// Void Remove(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MRemove_VisualElement;
		public virtual RMethod RMRemove_VisualElement
		{
			get
			{
				if(r_MRemove_VisualElement == null)
				{
					r_MRemove_VisualElement = new(this, "Remove", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MRemove_VisualElement.SetBelong(this.instance);
				}
				return r_MRemove_VisualElement;
			}
		}

		/// <summary>
		/// Void RemoveAt(Int32)
		/// </summary>
		protected RMethod r_MRemoveAt_Int32;
		public virtual RMethod RMRemoveAt_Int32
		{
			get
			{
				if(r_MRemoveAt_Int32 == null)
				{
					r_MRemoveAt_Int32 = new(this, "RemoveAt", 0, typeof(System.Int32));
					r_MRemoveAt_Int32.SetBelong(this.instance);
				}
				return r_MRemoveAt_Int32;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_MClear;
		public virtual RMethod RMClear
		{
			get
			{
				if(r_MClear == null)
				{
					r_MClear = new(this, "Clear", 0);
					r_MClear.SetBelong(this.instance);
				}
				return r_MClear;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement ElementAt(Int32)
		/// </summary>
		protected RMethod r_MElementAt_Int32;
		public virtual RMethod RMElementAt_Int32
		{
			get
			{
				if(r_MElementAt_Int32 == null)
				{
					r_MElementAt_Int32 = new(this, "ElementAt", 0, typeof(System.Int32));
					r_MElementAt_Int32.SetBelong(this.instance);
				}
				return r_MElementAt_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MIndexOf_VisualElement;
		public virtual RMethod RMIndexOf_VisualElement
		{
			get
			{
				if(r_MIndexOf_VisualElement == null)
				{
					r_MIndexOf_VisualElement = new(this, "IndexOf", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MIndexOf_VisualElement.SetBelong(this.instance);
				}
				return r_MIndexOf_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement ElementAtTreePath(System.Collections.Generic.List`1[System.Int32])
		/// </summary>
		protected RMethod r_MElementAtTreePath_List_d_Int32_p_;
		public virtual RMethod RMElementAtTreePath_List_d_Int32_p_
		{
			get
			{
				if(r_MElementAtTreePath_List_d_Int32_p_ == null)
				{
					r_MElementAtTreePath_List_d_Int32_p_ = new(this, "ElementAtTreePath", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)));
					r_MElementAtTreePath_List_d_Int32_p_.SetBelong(this.instance);
				}
				return r_MElementAtTreePath_List_d_Int32_p_;
			}
		}

		/// <summary>
		/// Boolean FindElementInTree(UnityEngine.UIElements.VisualElement, System.Collections.Generic.List`1[System.Int32])
		/// </summary>
		protected RMethod r_MFindElementInTree_VisualElement_List_d_Int32_p_;
		public virtual RMethod RMFindElementInTree_VisualElement_List_d_Int32_p_
		{
			get
			{
				if(r_MFindElementInTree_VisualElement_List_d_Int32_p_ == null)
				{
					r_MFindElementInTree_VisualElement_List_d_Int32_p_ = new(this, "FindElementInTree", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)));
					r_MFindElementInTree_VisualElement_List_d_Int32_p_.SetBelong(this.instance);
				}
				return r_MFindElementInTree_VisualElement_List_d_Int32_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.VisualElement] Children()
		/// </summary>
		protected RMethod r_MChildren;
		public virtual RMethod RMChildren
		{
			get
			{
				if(r_MChildren == null)
				{
					r_MChildren = new(this, "Children", 0);
					r_MChildren.SetBelong(this.instance);
				}
				return r_MChildren;
			}
		}

		/// <summary>
		/// Void Sort(System.Comparison`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_MSort_Comparison_d_VisualElement_p_;
		public virtual RMethod RMSort_Comparison_d_VisualElement_p_
		{
			get
			{
				if(r_MSort_Comparison_d_VisualElement_p_ == null)
				{
					r_MSort_Comparison_d_VisualElement_p_ = new(this, "Sort", 0, typeof(System.Comparison<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
					r_MSort_Comparison_d_VisualElement_p_.SetBelong(this.instance);
				}
				return r_MSort_Comparison_d_VisualElement_p_;
			}
		}

		/// <summary>
		/// Void BringToFront()
		/// </summary>
		protected RMethod r_MBringToFront;
		public virtual RMethod RMBringToFront
		{
			get
			{
				if(r_MBringToFront == null)
				{
					r_MBringToFront = new(this, "BringToFront", 0);
					r_MBringToFront.SetBelong(this.instance);
				}
				return r_MBringToFront;
			}
		}

		/// <summary>
		/// Void SendToBack()
		/// </summary>
		protected RMethod r_MSendToBack;
		public virtual RMethod RMSendToBack
		{
			get
			{
				if(r_MSendToBack == null)
				{
					r_MSendToBack = new(this, "SendToBack", 0);
					r_MSendToBack.SetBelong(this.instance);
				}
				return r_MSendToBack;
			}
		}

		/// <summary>
		/// Void PlaceBehind(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MPlaceBehind_VisualElement;
		public virtual RMethod RMPlaceBehind_VisualElement
		{
			get
			{
				if(r_MPlaceBehind_VisualElement == null)
				{
					r_MPlaceBehind_VisualElement = new(this, "PlaceBehind", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MPlaceBehind_VisualElement.SetBelong(this.instance);
				}
				return r_MPlaceBehind_VisualElement;
			}
		}

		/// <summary>
		/// Void PlaceInFront(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MPlaceInFront_VisualElement;
		public virtual RMethod RMPlaceInFront_VisualElement
		{
			get
			{
				if(r_MPlaceInFront_VisualElement == null)
				{
					r_MPlaceInFront_VisualElement = new(this, "PlaceInFront", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MPlaceInFront_VisualElement.SetBelong(this.instance);
				}
				return r_MPlaceInFront_VisualElement;
			}
		}

		/// <summary>
		/// Void RemoveFromHierarchy()
		/// </summary>
		protected RMethod r_MRemoveFromHierarchy;
		public virtual RMethod RMRemoveFromHierarchy
		{
			get
			{
				if(r_MRemoveFromHierarchy == null)
				{
					r_MRemoveFromHierarchy = new(this, "RemoveFromHierarchy", 0);
					r_MRemoveFromHierarchy.SetBelong(this.instance);
				}
				return r_MRemoveFromHierarchy;
			}
		}

		/// <summary>
		/// T GetFirstOfType[T]()
		/// </summary>
		protected RMethod r_MGetFirstOfType_GT;
		public virtual RMethod RMGetFirstOfType_GT
		{
			get
			{
				if(r_MGetFirstOfType_GT == null)
				{
					r_MGetFirstOfType_GT = new(this, "GetFirstOfType", 1);
					r_MGetFirstOfType_GT.SetBelong(this.instance);
				}
				return r_MGetFirstOfType_GT;
			}
		}

		/// <summary>
		/// T GetFirstAncestorOfType[T]()
		/// </summary>
		protected RMethod r_MGetFirstAncestorOfType_GT;
		public virtual RMethod RMGetFirstAncestorOfType_GT
		{
			get
			{
				if(r_MGetFirstAncestorOfType_GT == null)
				{
					r_MGetFirstAncestorOfType_GT = new(this, "GetFirstAncestorOfType", 1);
					r_MGetFirstAncestorOfType_GT.SetBelong(this.instance);
				}
				return r_MGetFirstAncestorOfType_GT;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetFirstAncestorWhere(System.Predicate`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_MGetFirstAncestorWhere_Predicate_d_VisualElement_p_;
		public virtual RMethod RMGetFirstAncestorWhere_Predicate_d_VisualElement_p_
		{
			get
			{
				if(r_MGetFirstAncestorWhere_Predicate_d_VisualElement_p_ == null)
				{
					r_MGetFirstAncestorWhere_Predicate_d_VisualElement_p_ = new(this, "GetFirstAncestorWhere", 0, typeof(System.Predicate<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
					r_MGetFirstAncestorWhere_Predicate_d_VisualElement_p_.SetBelong(this.instance);
				}
				return r_MGetFirstAncestorWhere_Predicate_d_VisualElement_p_;
			}
		}

		/// <summary>
		/// Boolean Contains(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MContains_VisualElement;
		public virtual RMethod RMContains_VisualElement
		{
			get
			{
				if(r_MContains_VisualElement == null)
				{
					r_MContains_VisualElement = new(this, "Contains", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MContains_VisualElement.SetBelong(this.instance);
				}
				return r_MContains_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement FindCommonAncestor(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MFindCommonAncestor_VisualElement;
		public virtual RMethod RMFindCommonAncestor_VisualElement
		{
			get
			{
				if(r_MFindCommonAncestor_VisualElement == null)
				{
					r_MFindCommonAncestor_VisualElement = new(this, "FindCommonAncestor", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MFindCommonAncestor_VisualElement.SetBelong(this.instance);
				}
				return r_MFindCommonAncestor_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetRoot()
		/// </summary>
		protected RMethod r_MGetRoot;
		public virtual RMethod RMGetRoot
		{
			get
			{
				if(r_MGetRoot == null)
				{
					r_MGetRoot = new(this, "GetRoot", 0);
					r_MGetRoot.SetBelong(this.instance);
				}
				return r_MGetRoot;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetRootVisualContainer()
		/// </summary>
		protected RMethod r_MGetRootVisualContainer;
		public virtual RMethod RMGetRootVisualContainer
		{
			get
			{
				if(r_MGetRootVisualContainer == null)
				{
					r_MGetRootVisualContainer = new(this, "GetRootVisualContainer", 0);
					r_MGetRootVisualContainer.SetBelong(this.instance);
				}
				return r_MGetRootVisualContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetNextElementDepthFirst()
		/// </summary>
		protected RMethod r_MGetNextElementDepthFirst;
		public virtual RMethod RMGetNextElementDepthFirst
		{
			get
			{
				if(r_MGetNextElementDepthFirst == null)
				{
					r_MGetNextElementDepthFirst = new(this, "GetNextElementDepthFirst", 0);
					r_MGetNextElementDepthFirst.SetBelong(this.instance);
				}
				return r_MGetNextElementDepthFirst;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetPreviousElementDepthFirst()
		/// </summary>
		protected RMethod r_MGetPreviousElementDepthFirst;
		public virtual RMethod RMGetPreviousElementDepthFirst
		{
			get
			{
				if(r_MGetPreviousElementDepthFirst == null)
				{
					r_MGetPreviousElementDepthFirst = new(this, "GetPreviousElementDepthFirst", 0);
					r_MGetPreviousElementDepthFirst.SetBelong(this.instance);
				}
				return r_MGetPreviousElementDepthFirst;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement RetargetElement(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MRetargetElement_VisualElement;
		public virtual RMethod RMRetargetElement_VisualElement
		{
			get
			{
				if(r_MRetargetElement_VisualElement == null)
				{
					r_MRetargetElement_VisualElement = new(this, "RetargetElement", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MRetargetElement_VisualElement.SetBelong(this.instance);
				}
				return r_MRetargetElement_VisualElement;
			}
		}

		/// <summary>
		/// Void GetPivotedMatrixWithLayout(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_MGetPivotedMatrixWithLayout_Out_Matrix4x4;
		public virtual RMethod RMGetPivotedMatrixWithLayout_Out_Matrix4x4
		{
			get
			{
				if(r_MGetPivotedMatrixWithLayout_Out_Matrix4x4 == null)
				{
					r_MGetPivotedMatrixWithLayout_Out_Matrix4x4 = new(this, "GetPivotedMatrixWithLayout", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_MGetPivotedMatrixWithLayout_Out_Matrix4x4.SetBelong(this.instance);
				}
				return r_MGetPivotedMatrixWithLayout_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void AddStyleSheetPath(System.String)
		/// </summary>
		protected RMethod r_MAddStyleSheetPath_String;
		public virtual RMethod RMAddStyleSheetPath_String
		{
			get
			{
				if(r_MAddStyleSheetPath_String == null)
				{
					r_MAddStyleSheetPath_String = new(this, "AddStyleSheetPath", 0, typeof(System.String));
					r_MAddStyleSheetPath_String.SetBelong(this.instance);
				}
				return r_MAddStyleSheetPath_String;
			}
		}

		/// <summary>
		/// Boolean HasStyleSheetPath(System.String)
		/// </summary>
		protected RMethod r_MHasStyleSheetPath_String;
		public virtual RMethod RMHasStyleSheetPath_String
		{
			get
			{
				if(r_MHasStyleSheetPath_String == null)
				{
					r_MHasStyleSheetPath_String = new(this, "HasStyleSheetPath", 0, typeof(System.String));
					r_MHasStyleSheetPath_String.SetBelong(this.instance);
				}
				return r_MHasStyleSheetPath_String;
			}
		}

		/// <summary>
		/// Void RemoveStyleSheetPath(System.String)
		/// </summary>
		protected RMethod r_MRemoveStyleSheetPath_String;
		public virtual RMethod RMRemoveStyleSheetPath_String
		{
			get
			{
				if(r_MRemoveStyleSheetPath_String == null)
				{
					r_MRemoveStyleSheetPath_String = new(this, "RemoveStyleSheetPath", 0, typeof(System.String));
					r_MRemoveStyleSheetPath_String.SetBelong(this.instance);
				}
				return r_MRemoveStyleSheetPath_String;
			}
		}

		/// <summary>
		/// Void Blur()
		/// </summary>
		protected RMethod r_MBlur;
		public virtual RMethod RMBlur
		{
			get
			{
				if(r_MBlur == null)
				{
					r_MBlur = new(this, "Blur", 0);
					r_MBlur.SetBelong(this.instance);
				}
				return r_MBlur;
			}
		}

		/// <summary>
		/// Void BlurImmediately()
		/// </summary>
		protected RMethod r_MBlurImmediately;
		public virtual RMethod RMBlurImmediately
		{
			get
			{
				if(r_MBlurImmediately == null)
				{
					r_MBlurImmediately = new(this, "BlurImmediately", 0);
					r_MBlurImmediately.SetBelong(this.instance);
				}
				return r_MBlurImmediately;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultActionDisabled(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MExecuteDefaultActionDisabled_EventBase;
		public virtual RMethod RMExecuteDefaultActionDisabled_EventBase
		{
			get
			{
				if(r_MExecuteDefaultActionDisabled_EventBase == null)
				{
					r_MExecuteDefaultActionDisabled_EventBase = new(this, "ExecuteDefaultActionDisabled", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MExecuteDefaultActionDisabled_EventBase.SetBelong(this.instance);
				}
				return r_MExecuteDefaultActionDisabled_EventBase;
			}
		}

		/// <summary>
		/// Void RegisterCallback[TEventType](UnityEngine.UIElements.EventCallback`1[TEventType], UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown;
		public virtual RMethod RMRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown
		{
			get
			{
				if(r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown == null)
				{
					r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown = new(this, "RegisterCallback", 1, typeof(UnityEngine.UIElements.EventCallback<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(UnityEngine.UIElements.TrickleDown));
					r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown.SetBelong(this.instance);
				}
				return r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown;
			}
		}

		/// <summary>
		/// Void RegisterCallback[TEventType,TUserArgsType](UnityEngine.UIElements.EventCallback`2[TEventType,TUserArgsType], TUserArgsType, UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_MRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown;
		public virtual RMethod RMRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown
		{
			get
			{
				if(r_MRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown == null)
				{
					r_MRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown = new(this, "RegisterCallback", 2, typeof(UnityEngine.UIElements.EventCallback<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), Type.MakeGenericMethodParameter(1), typeof(UnityEngine.UIElements.TrickleDown));
					r_MRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown.SetBelong(this.instance);
				}
				return r_MRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown;
			}
		}

		/// <summary>
		/// Void RegisterCallback[TEventType](UnityEngine.UIElements.EventCallback`1[TEventType], UnityEngine.UIElements.InvokePolicy, UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown;
		public virtual RMethod RMRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown
		{
			get
			{
				if(r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown == null)
				{
					r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown = new(this, "RegisterCallback", 1, typeof(UnityEngine.UIElements.EventCallback<>).MakeGenericType(Type.MakeGenericMethodParameter(0)),  ReflectionUtils.GetType("UnityEngine.UIElements.InvokePolicy"), typeof(UnityEngine.UIElements.TrickleDown));
					r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown.SetBelong(this.instance);
				}
				return r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown;
			}
		}

		/// <summary>
		/// Void UnregisterCallback[TEventType](UnityEngine.UIElements.EventCallback`1[TEventType], UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_MUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown;
		public virtual RMethod RMUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown
		{
			get
			{
				if(r_MUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown == null)
				{
					r_MUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown = new(this, "UnregisterCallback", 1, typeof(UnityEngine.UIElements.EventCallback<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(UnityEngine.UIElements.TrickleDown));
					r_MUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown.SetBelong(this.instance);
				}
				return r_MUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown;
			}
		}

		/// <summary>
		/// Void UnregisterCallback[TEventType,TUserArgsType](UnityEngine.UIElements.EventCallback`2[TEventType,TUserArgsType], UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_MUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown;
		public virtual RMethod RMUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown
		{
			get
			{
				if(r_MUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown == null)
				{
					r_MUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown = new(this, "UnregisterCallback", 2, typeof(UnityEngine.UIElements.EventCallback<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), typeof(UnityEngine.UIElements.TrickleDown));
					r_MUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown.SetBelong(this.instance);
				}
				return r_MUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown;
			}
		}

		/// <summary>
		/// Boolean TryGetUserArgs[TEventType,TCallbackArgs](UnityEngine.UIElements.EventCallback`2[TEventType,TCallbackArgs], UnityEngine.UIElements.TrickleDown, TCallbackArgs ByRef)
		/// </summary>
		protected RMethod r_MTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs;
		public virtual RMethod RMTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs
		{
			get
			{
				if(r_MTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs == null)
				{
					r_MTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs = new(this, "TryGetUserArgs", 2, typeof(UnityEngine.UIElements.EventCallback<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), typeof(UnityEngine.UIElements.TrickleDown), Type.MakeGenericMethodParameter(1).MakeByRefType());
					r_MTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs.SetBelong(this.instance);
				}
				return r_MTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs;
			}
		}

		/// <summary>
		/// Void HandleEventAtTargetPhase(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MHandleEventAtTargetPhase_EventBase;
		public virtual RMethod RMHandleEventAtTargetPhase_EventBase
		{
			get
			{
				if(r_MHandleEventAtTargetPhase_EventBase == null)
				{
					r_MHandleEventAtTargetPhase_EventBase = new(this, "HandleEventAtTargetPhase", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MHandleEventAtTargetPhase_EventBase.SetBelong(this.instance);
				}
				return r_MHandleEventAtTargetPhase_EventBase;
			}
		}

		/// <summary>
		/// Void HandleEventAtTargetAndDefaultPhase(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MHandleEventAtTargetAndDefaultPhase_EventBase;
		public virtual RMethod RMHandleEventAtTargetAndDefaultPhase_EventBase
		{
			get
			{
				if(r_MHandleEventAtTargetAndDefaultPhase_EventBase == null)
				{
					r_MHandleEventAtTargetAndDefaultPhase_EventBase = new(this, "HandleEventAtTargetAndDefaultPhase", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MHandleEventAtTargetAndDefaultPhase_EventBase.SetBelong(this.instance);
				}
				return r_MHandleEventAtTargetAndDefaultPhase_EventBase;
			}
		}

		/// <summary>
		/// Void HandleEventAtCurrentTargetAndPhase(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MHandleEventAtCurrentTargetAndPhase_EventBase;
		public virtual RMethod RMHandleEventAtCurrentTargetAndPhase_EventBase
		{
			get
			{
				if(r_MHandleEventAtCurrentTargetAndPhase_EventBase == null)
				{
					r_MHandleEventAtCurrentTargetAndPhase_EventBase = new(this, "HandleEventAtCurrentTargetAndPhase", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MHandleEventAtCurrentTargetAndPhase_EventBase.SetBelong(this.instance);
				}
				return r_MHandleEventAtCurrentTargetAndPhase_EventBase;
			}
		}

		/// <summary>
		/// Void HandleEventEditorInternal(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MHandleEventEditorInternal_EventBase;
		public virtual RMethod RMHandleEventEditorInternal_EventBase
		{
			get
			{
				if(r_MHandleEventEditorInternal_EventBase == null)
				{
					r_MHandleEventEditorInternal_EventBase = new(this, "HandleEventEditorInternal", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MHandleEventEditorInternal_EventBase.SetBelong(this.instance);
				}
				return r_MHandleEventEditorInternal_EventBase;
			}
		}

		/// <summary>
		/// Void HandleEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MHandleEvent_EventBase;
		public virtual RMethod RMHandleEvent_EventBase
		{
			get
			{
				if(r_MHandleEvent_EventBase == null)
				{
					r_MHandleEvent_EventBase = new(this, "HandleEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MHandleEvent_EventBase.SetBelong(this.instance);
				}
				return r_MHandleEvent_EventBase;
			}
		}

		/// <summary>
		/// Boolean HasTrickleDownHandlers()
		/// </summary>
		protected RMethod r_MHasTrickleDownHandlers;
		public virtual RMethod RMHasTrickleDownHandlers
		{
			get
			{
				if(r_MHasTrickleDownHandlers == null)
				{
					r_MHasTrickleDownHandlers = new(this, "HasTrickleDownHandlers", 0);
					r_MHasTrickleDownHandlers.SetBelong(this.instance);
				}
				return r_MHasTrickleDownHandlers;
			}
		}

		/// <summary>
		/// Boolean HasBubbleUpHandlers()
		/// </summary>
		protected RMethod r_MHasBubbleUpHandlers;
		public virtual RMethod RMHasBubbleUpHandlers
		{
			get
			{
				if(r_MHasBubbleUpHandlers == null)
				{
					r_MHasBubbleUpHandlers = new(this, "HasBubbleUpHandlers", 0);
					r_MHasBubbleUpHandlers.SetBelong(this.instance);
				}
				return r_MHasBubbleUpHandlers;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultActionDisabledAtTarget(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MExecuteDefaultActionDisabledAtTarget_EventBase;
		public virtual RMethod RMExecuteDefaultActionDisabledAtTarget_EventBase
		{
			get
			{
				if(r_MExecuteDefaultActionDisabledAtTarget_EventBase == null)
				{
					r_MExecuteDefaultActionDisabledAtTarget_EventBase = new(this, "ExecuteDefaultActionDisabledAtTarget", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MExecuteDefaultActionDisabledAtTarget_EventBase.SetBelong(this.instance);
				}
				return r_MExecuteDefaultActionDisabledAtTarget_EventBase;
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


        public RTextElement() : base("UnityEngine.UIElements.TextElement")
        {
        }

        public RTextElement(System.Object instance) : base("UnityEngine.UIElements.TextElement")
		{
            SetInstance(instance);
		}

        public RTextElement(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextElement(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMOnGeometryChanged_GeometryChangedEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent @attachEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attachEvent};
            var ___result = RMOnAttachToPanel_AttachToPanelEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent @detachEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@detachEvent};
            var ___result = RMOnDetachFromPanel_DetachFromPanelEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext @mgc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mgc};
            var ___result = RMOnGenerateVisualContent_MeshGenerationContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ElideText(System.String @drawText, System.String @ellipsisText, System.Single @width, UnityEngine.UIElements.TextOverflowPosition @textOverflowPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@drawText, @ellipsisText, @width, @textOverflowPosition};
            var ___result = RMElideText_String_String_Single_TextOverflowPosition.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void UpdateTooltip()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateTooltip.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateVisibleText()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateVisibleText.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ShouldElide()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShouldElide.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Vector2 MeasureTextSize(System.String @textToMeasure, System.Single @width, RUnityEngine.RUIElements.RVisualElement.RMeasureMode @widthMode, System.Single @height, RUnityEngine.RUIElements.RVisualElement.RMeasureMode @heightMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textToMeasure, @width, @widthMode.Value, @height, @heightMode.Value};
            var ___result = RMMeasureTextSize_String_Single_MeasureMode_Single_MeasureMode.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual UnityEngine.Vector2 DoMeasure(System.Single @desiredWidth, RUnityEngine.RUIElements.RVisualElement.RMeasureMode @widthMode, System.Single @desiredHeight, RUnityEngine.RUIElements.RVisualElement.RMeasureMode @heightMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desiredWidth, @widthMode.Value, @desiredHeight, @heightMode.Value};
            var ___result = RMDoMeasure_Single_MeasureMode_Single_MeasureMode.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void UnityEngine__2__UIElements__2__INotifyValueChanged__0__System__2__String__1____2__SetValueWithoutNotify(System.String @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newValue};
            var ___result = RMUnityEngine__2__UIElements__2__INotifyValueChanged__0__System__2__String__1____2__SetValueWithoutNotify_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessMenuCommand(System.String @command)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@command};
            var ___result = RMProcessMenuCommand_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Cut(UnityEngine.UIElements.DropdownMenuAction @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RMCut_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Copy(UnityEngine.UIElements.DropdownMenuAction @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RMCopy_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Paste(UnityEngine.UIElements.DropdownMenuAction @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RMPaste_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BuildContextualMenu(UnityEngine.UIElements.ContextualMenuPopulateEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMBuildContextualMenu_ContextualMenuPopulateEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RUnityEngine.RUIElements.RDropdownMenuAction.RStatus CutActionStatus(UnityEngine.UIElements.DropdownMenuAction @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RMCutActionStatus_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RDropdownMenuAction.RStatus(___result);
        }


        public virtual RUnityEngine.RUIElements.RDropdownMenuAction.RStatus CopyActionStatus(UnityEngine.UIElements.DropdownMenuAction @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RMCopyActionStatus_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RDropdownMenuAction.RStatus(___result);
        }


        public virtual RUnityEngine.RUIElements.RDropdownMenuAction.RStatus PasteActionStatus(UnityEngine.UIElements.DropdownMenuAction @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RMPasteActionStatus_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RDropdownMenuAction.RStatus(___result);
        }


        public virtual void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMExecuteDefaultActionAtTarget_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnityEngine__2__UIElements__2__ITextEdition__2__ResetValueAndText()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUnityEngine__2__UIElements__2__ITextEdition__2__ResetValueAndText.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnityEngine__2__UIElements__2__ITextEdition__2__SaveValueAndText()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUnityEngine__2__UIElements__2__ITextEdition__2__SaveValueAndText.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnityEngine__2__UIElements__2__ITextEdition__2__RestoreValueAndText()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUnityEngine__2__UIElements__2__ITextEdition__2__RestoreValueAndText.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnityEngine__2__UIElements__2__ITextEdition__2__UpdateText(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMUnityEngine__2__UIElements__2__ITextEdition__2__UpdateText_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String UnityEngine__2__UIElements__2__ITextEdition__2__CullString(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RMUnityEngine__2__UIElements__2__ITextEdition__2__CullString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void UnityEngine__2__UIElements__2__ITextSelection__2__SelectAll()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUnityEngine__2__UIElements__2__ITextSelection__2__SelectAll.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnityEngine__2__UIElements__2__ITextSelection__2__SelectNone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUnityEngine__2__UIElements__2__ITextSelection__2__SelectNone.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnityEngine__2__UIElements__2__ITextSelection__2__SelectRange(System.Int32 @cursorIndex, System.Int32 @selectionIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cursorIndex, @selectionIndex};
            var ___result = RMUnityEngine__2__UIElements__2__ITextSelection__2__SelectRange_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__ITextSelection__2__HasSelection()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUnityEngine__2__UIElements__2__ITextSelection__2__HasSelection.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void UnityEngine__2__UIElements__2__ITextSelection__2__MoveTextEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUnityEngine__2__UIElements__2__ITextSelection__2__MoveTextEnd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawHighlighting(UnityEngine.UIElements.MeshGenerationContext @mgc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mgc};
            var ___result = RMDrawHighlighting_MeshGenerationContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawCaret(UnityEngine.UIElements.MeshGenerationContext @mgc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mgc};
            var ___result = RMDrawCaret_MeshGenerationContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryConvertLengthUnits(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, ref UnityEngine.UIElements.Length @from, ref UnityEngine.UIElements.Length @to, System.Int32 @subPropertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @subPropertyIndex};
            var ___result = RMTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32.Invoke(___genericsType, ___parameters);
			@from = (UnityEngine.UIElements.Length)___parameters[1];
			@to = (UnityEngine.UIElements.Length)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryConvertTransformOriginUnits(ref UnityEngine.UIElements.TransformOrigin @from, ref UnityEngine.UIElements.TransformOrigin @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RMTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin.Invoke(___genericsType, ___parameters);
			@from = (UnityEngine.UIElements.TransformOrigin)___parameters[0];
			@to = (UnityEngine.UIElements.TransformOrigin)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryConvertTranslateUnits(ref UnityEngine.UIElements.Translate @from, ref UnityEngine.UIElements.Translate @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RMTryConvertTranslateUnits_Ref_Translate_Ref_Translate.Invoke(___genericsType, ___parameters);
			@from = (UnityEngine.UIElements.Translate)___parameters[0];
			@to = (UnityEngine.UIElements.Translate)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryConvertBackgroundPositionUnits(ref UnityEngine.UIElements.BackgroundPosition @from, ref UnityEngine.UIElements.BackgroundPosition @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RMTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition.Invoke(___genericsType, ___parameters);
			@from = (UnityEngine.UIElements.BackgroundPosition)___parameters[0];
			@to = (UnityEngine.UIElements.BackgroundPosition)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryConvertBackgroundSizeUnits(ref UnityEngine.UIElements.BackgroundSize @from, ref UnityEngine.UIElements.BackgroundSize @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RMTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize.Invoke(___genericsType, ___parameters);
			@from = (UnityEngine.UIElements.BackgroundSize)___parameters[0];
			@to = (UnityEngine.UIElements.BackgroundSize)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual void MarkRenderHintsClean()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMarkRenderHintsClean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateBoundingBox()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateBoundingBox.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateWorldBoundingBox()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateWorldBoundingBox.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateWorldTransform()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateWorldTransform.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateWorldTransformInverse()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateWorldTransformInverse.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnsureWorldTransformAndClipUpToDate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEnsureWorldTransformAndClipUpToDate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteDefaultAction(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMExecuteDefaultAction_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect GetTooltipRect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTooltipRect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void Focus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPanel(RUnityEngine.RUIElements.RBaseVisualElementPanel @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p.Value};
            var ___result = RMSetPanel_BaseVisualElementPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendEvent(UnityEngine.UIElements.EventBase @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMSendEvent_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendEvent(UnityEngine.UIElements.EventBase @e, RUnityEngine.RUIElements.RDispatchMode @dispatchMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @dispatchMode.Value};
            var ___result = RMSendEvent_EventBase_DispatchMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IncrementVersion(RUnityEngine.RUIElements.RVersionChangeType @changeType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@changeType.Value};
            var ___result = RMIncrementVersion_VersionChangeType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeHierarchyChanged(RUnityEngine.RUIElements.RHierarchyChangeType @changeType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@changeType.Value};
            var ___result = RMInvokeHierarchyChanged_HierarchyChangeType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SetEnabledFromHierarchy(System.Boolean @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RMSetEnabledFromHierarchy_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetEnabled(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetEnabled_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkDirtyRepaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMarkDirtyRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext @mgc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mgc};
            var ___result = RMInvokeGenerateVisualContent_MeshGenerationContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetFullHierarchicalViewDataKey(System.Text.StringBuilder @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMGetFullHierarchicalViewDataKey_StringBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetFullHierarchicalViewDataKey()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetFullHierarchicalViewDataKey.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual T GetOrCreateViewData<T>(System.Object @existing, System.String @key) where T : class, new()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@existing, @key};
            var ___result = RMGetOrCreateViewData_GT_Object_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T GetOrCreateViewData<T>(UnityEngine.ScriptableObject @existing, System.String @key) where T : UnityEngine.ScriptableObject
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@existing, @key};
            var ___result = RMGetOrCreateViewData_GT_ScriptableObject_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual void OverwriteFromViewData(System.Object @obj, System.String @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @key};
            var ___result = RMOverwriteFromViewData_Object_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SaveViewData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSaveViewData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsViewDataPersitenceSupportedOnChildren(System.Boolean @existingState)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@existingState};
            var ___result = RMIsViewDataPersitenceSupportedOnChildren_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnViewDataReady(System.Boolean @enablePersistence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enablePersistence};
            var ___result = RMOnViewDataReady_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnViewDataReady()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnViewDataReady.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ContainsPoint(UnityEngine.Vector2 @localPoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localPoint};
            var ___result = RMContainsPoint_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Overlaps(UnityEngine.Rect @rectangle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rectangle};
            var ___result = RMOverlaps_Rect.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual RUnityEngine.RYoga.RYogaSize Measure(RUnityEngine.RYoga.RYogaNode @node, System.Single @width, RUnityEngine.RYoga.RYogaMeasureMode @widthMode, System.Single @height, RUnityEngine.RYoga.RYogaMeasureMode @heightMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node.Value, @width, @widthMode.Value, @height, @heightMode.Value};
            var ___result = RMMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RYoga.RYogaSize(___result);
        }


        public virtual void SetSize(UnityEngine.Vector2 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@size};
            var ___result = RMSetSize_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInlineRule(UnityEngine.UIElements.StyleSheet @sheet, RUnityEngine.RUIElements.RStyleRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheet, @rule.Value};
            var ___result = RMSetInlineRule_StyleSheet_StyleRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateInlineRule(UnityEngine.UIElements.StyleSheet @sheet, RUnityEngine.RUIElements.RStyleRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheet, @rule.Value};
            var ___result = RMUpdateInlineRule_StyleSheet_StyleRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputedStyle(ref RUnityEngine.RUIElements.RComputedStyle @newStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newStyle.Value};
            var ___result = RMSetComputedStyle_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@newStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[0]);

            
        }


        public virtual void ResetPositionProperties()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetPositionProperties.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Collections.Generic.IEnumerable<System.String> GetClasses()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetClasses.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<System.String>)___result;
        }


        public virtual System.Collections.Generic.List<System.String> GetClassesForIteration()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetClassesForIteration.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<System.String>)___result;
        }


        public virtual void ClearClassList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearClassList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddToClassList(System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RMAddToClassList_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFromClassList(System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RMRemoveFromClassList_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ToggleInClassList(System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RMToggleInClassList_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableInClassList(System.String @className, System.Boolean @enable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className, @enable};
            var ___result = RMEnableInClassList_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ClassListContains(System.String @cls)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cls};
            var ___result = RMClassListContains_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object FindAncestorUserData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFindAncestorUserData.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetProperty(UnityEngine.PropertyName @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMGetProperty_PropertyName.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetProperty(UnityEngine.PropertyName @key, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RMSetProperty_PropertyName_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasProperty(UnityEngine.PropertyName @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMHasProperty_PropertyName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ApplyPlayerRenderingToEditorElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMApplyPlayerRenderingToEditorElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterAnimation(RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate @anim)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anim.Value};
            var ___result = RMRegisterAnimation_IValueAnimationUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterAnimation(RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate @anim)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anim.Value};
            var ___result = RMUnregisterAnimation_IValueAnimationUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetCachedNextParentWithEventCallback(out UnityEngine.UIElements.VisualElement @nextParent)
        {
			@nextParent = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nextParent};
            var ___result = RMGetCachedNextParentWithEventCallback_Out_VisualElement.Invoke(___genericsType, ___parameters);
			@nextParent = (UnityEngine.UIElements.VisualElement)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasEventCallbacks(RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasEventCallbacks_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasParentEventCallbacks(RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasParentEventCallbacks_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasParentEventCallbacksOrDefaultActions(RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasParentEventCallbacksOrDefaultActions_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasEventCallbacksOrDefaultActions(RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasEventCallbacksOrDefaultActions_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasParentEventCallbacksOrDefaultActionAtTarget(RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasEventCallbacksOrDefaultActionAtTarget(RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasEventCallbacksOrDefaultActionAtTarget_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasDefaultAction(RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasDefaultAction_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ShouldClip()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShouldClip.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Add(UnityEngine.UIElements.VisualElement @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RMAdd_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Insert(System.Int32 @index, UnityEngine.UIElements.VisualElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @element};
            var ___result = RMInsert_Int32_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Remove(UnityEngine.UIElements.VisualElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RMRemove_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMRemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.VisualElement ElementAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMElementAt_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual System.Int32 IndexOf(UnityEngine.UIElements.VisualElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RMIndexOf_VisualElement.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement ElementAtTreePath(System.Collections.Generic.List<System.Int32> @childIndexes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@childIndexes};
            var ___result = RMElementAtTreePath_List_d_Int32_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual System.Boolean FindElementInTree(UnityEngine.UIElements.VisualElement @element, System.Collections.Generic.List<System.Int32> @outChildIndexes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @outChildIndexes};
            var ___result = RMFindElementInTree_VisualElement_List_d_Int32_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement> Children()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMChildren.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement>)___result;
        }


        public virtual void Sort(System.Comparison<UnityEngine.UIElements.VisualElement> @comp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comp};
            var ___result = RMSort_Comparison_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BringToFront()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBringToFront.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendToBack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSendToBack.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlaceBehind(UnityEngine.UIElements.VisualElement @sibling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sibling};
            var ___result = RMPlaceBehind_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlaceInFront(UnityEngine.UIElements.VisualElement @sibling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sibling};
            var ___result = RMPlaceInFront_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFromHierarchy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRemoveFromHierarchy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T GetFirstOfType<T>() where T : class
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetFirstOfType_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T GetFirstAncestorOfType<T>() where T : class
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetFirstAncestorOfType_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetFirstAncestorWhere(System.Predicate<UnityEngine.UIElements.VisualElement> @predicate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@predicate};
            var ___result = RMGetFirstAncestorWhere_Predicate_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual System.Boolean Contains(UnityEngine.UIElements.VisualElement @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RMContains_VisualElement.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement FindCommonAncestor(UnityEngine.UIElements.VisualElement @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMFindCommonAncestor_VisualElement.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetRoot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRoot.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetRootVisualContainer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRootVisualContainer.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetNextElementDepthFirst()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNextElementDepthFirst.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetPreviousElementDepthFirst()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPreviousElementDepthFirst.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement RetargetElement(UnityEngine.UIElements.VisualElement @retargetAgainst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@retargetAgainst};
            var ___result = RMRetargetElement_VisualElement.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual void GetPivotedMatrixWithLayout(out UnityEngine.Matrix4x4 @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = RMGetPivotedMatrixWithLayout_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@result = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void AddStyleSheetPath(System.String @sheetPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheetPath};
            var ___result = RMAddStyleSheetPath_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasStyleSheetPath(System.String @sheetPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheetPath};
            var ___result = RMHasStyleSheetPath_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RemoveStyleSheetPath(System.String @sheetPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheetPath};
            var ___result = RMRemoveStyleSheetPath_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blur()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBlur.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BlurImmediately()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBlurImmediately.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteDefaultActionDisabled(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMExecuteDefaultActionDisabled_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType> @callback, UnityEngine.UIElements.TrickleDown @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType)};
            var ___parameters = new object[]{@callback, @useTrickleDown};
            var ___result = RMRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterCallback<TEventType, TUserArgsType>(UnityEngine.UIElements.EventCallback<TEventType, TUserArgsType> @callback, TUserArgsType @userArgs, UnityEngine.UIElements.TrickleDown @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType), typeof(TUserArgsType)};
            var ___parameters = new object[]{@callback, @userArgs, @useTrickleDown};
            var ___result = RMRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType> @callback, RUnityEngine.RUIElements.RInvokePolicy @invokePolicy, UnityEngine.UIElements.TrickleDown @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType)};
            var ___parameters = new object[]{@callback, @invokePolicy.Value, @useTrickleDown};
            var ___result = RMRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType> @callback, UnityEngine.UIElements.TrickleDown @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType)};
            var ___parameters = new object[]{@callback, @useTrickleDown};
            var ___result = RMUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterCallback<TEventType, TUserArgsType>(UnityEngine.UIElements.EventCallback<TEventType, TUserArgsType> @callback, UnityEngine.UIElements.TrickleDown @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType), typeof(TUserArgsType)};
            var ___parameters = new object[]{@callback, @useTrickleDown};
            var ___result = RMUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryGetUserArgs<TEventType, TCallbackArgs>(UnityEngine.UIElements.EventCallback<TEventType, TCallbackArgs> @callback, UnityEngine.UIElements.TrickleDown @useTrickleDown, out TCallbackArgs @userData) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {
			@userData = default;

            var ___genericsType = new Type[] {typeof(TEventType), typeof(TCallbackArgs)};
            var ___parameters = new object[]{@callback, @useTrickleDown, @userData};
            var ___result = RMTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs.Invoke(___genericsType, ___parameters);
			@userData = (TCallbackArgs)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual void HandleEventAtTargetPhase(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMHandleEventAtTargetPhase_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleEventAtTargetAndDefaultPhase(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMHandleEventAtTargetAndDefaultPhase_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleEventAtCurrentTargetAndPhase(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMHandleEventAtCurrentTargetAndPhase_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleEventEditorInternal(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMHandleEventEditorInternal_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleEvent(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMHandleEvent_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasTrickleDownHandlers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasTrickleDownHandlers.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasBubbleUpHandlers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasBubbleUpHandlers.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ExecuteDefaultActionDisabledAtTarget(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMExecuteDefaultActionDisabledAtTarget_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
