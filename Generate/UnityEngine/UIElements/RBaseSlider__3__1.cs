using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.BaseSlider`1
	/// </summary>
    public partial class RBaseSlider<TValueType> : RMember // where TValueType : System.IComparable<TValueType>
    {

		/// <summary>
		/// UnityEngine.UIElements.VisualElement <dragContainer>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r___0__dragContainer__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RVisualElement R__0__dragContainer__1__k__BackingField
		{
			get
			{
				if(r___0__dragContainer__1__k__BackingField == null)
				{
					r___0__dragContainer__1__k__BackingField = new(this, "<dragContainer>k__BackingField");
					r___0__dragContainer__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__dragContainer__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement <dragElement>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r___0__dragElement__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RVisualElement R__0__dragElement__1__k__BackingField
		{
			get
			{
				if(r___0__dragElement__1__k__BackingField == null)
				{
					r___0__dragElement__1__k__BackingField = new(this, "<dragElement>k__BackingField");
					r___0__dragElement__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__dragElement__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement <trackElement>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r___0__trackElement__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RVisualElement R__0__trackElement__1__k__BackingField
		{
			get
			{
				if(r___0__trackElement__1__k__BackingField == null)
				{
					r___0__trackElement__1__k__BackingField = new(this, "<trackElement>k__BackingField");
					r___0__trackElement__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__trackElement__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement <dragBorderElement>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r___0__dragBorderElement__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RVisualElement R__0__dragBorderElement__1__k__BackingField
		{
			get
			{
				if(r___0__dragBorderElement__1__k__BackingField == null)
				{
					r___0__dragBorderElement__1__k__BackingField = new(this, "<dragBorderElement>k__BackingField");
					r___0__dragBorderElement__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__dragBorderElement__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextField <inputTextField>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RTextField r___0__inputTextField__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RTextField R__0__inputTextField__1__k__BackingField
		{
			get
			{
				if(r___0__inputTextField__1__k__BackingField == null)
				{
					r___0__inputTextField__1__k__BackingField = new(this, "<inputTextField>k__BackingField");
					r___0__inputTextField__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__inputTextField__1__k__BackingField;
			}
		}

		/// <summary>
		/// TValueType m_LowValue
		/// </summary>
		protected RField r_m_LowValue;
		public virtual RField Rm_LowValue
		{
			get
			{
				if(r_m_LowValue == null)
				{
					r_m_LowValue = new(this, "m_LowValue");
					r_m_LowValue.SetBelong(this.instance);
				}
				return r_m_LowValue;
			}
		}

		/// <summary>
		/// TValueType m_HighValue
		/// </summary>
		protected RField r_m_HighValue;
		public virtual RField Rm_HighValue
		{
			get
			{
				if(r_m_HighValue == null)
				{
					r_m_HighValue = new(this, "m_HighValue");
					r_m_HighValue.SetBelong(this.instance);
				}
				return r_m_HighValue;
			}
		}

		/// <summary>
		/// System.Single m_PageSize
		/// </summary>
		protected RField r_m_PageSize;
		public virtual RField Rm_PageSize
		{
			get
			{
				if(r_m_PageSize == null)
				{
					r_m_PageSize = new(this, "m_PageSize");
					r_m_PageSize.SetBelong(this.instance);
				}
				return r_m_PageSize;
			}
		}

		/// <summary>
		/// System.Boolean m_ShowInputField
		/// </summary>
		protected RField r_m_ShowInputField;
		public virtual RField Rm_ShowInputField
		{
			get
			{
				if(r_m_ShowInputField == null)
				{
					r_m_ShowInputField = new(this, "m_ShowInputField");
					r_m_ShowInputField.SetBelong(this.instance);
				}
				return r_m_ShowInputField;
			}
		}

		/// <summary>
		/// System.Boolean <clamped>k__BackingField
		/// </summary>
		protected RField r___0__clamped__1__k__BackingField;
		public virtual RField R__0__clamped__1__k__BackingField
		{
			get
			{
				if(r___0__clamped__1__k__BackingField == null)
				{
					r___0__clamped__1__k__BackingField = new(this, "<clamped>k__BackingField");
					r___0__clamped__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__clamped__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ClampedDragger`1[TValueType] <clampedDragger>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RClampedDragger<RField> r___0__clampedDragger__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RClampedDragger<RField> R__0__clampedDragger__1__k__BackingField
		{
			get
			{
				if(r___0__clampedDragger__1__k__BackingField == null)
				{
					r___0__clampedDragger__1__k__BackingField = new(this, "<clampedDragger>k__BackingField");
					r___0__clampedDragger__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__clampedDragger__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_DragElementStartPos
		/// </summary>
		protected RUnityEngine.RRect r_m_DragElementStartPos;
		public virtual RUnityEngine.RRect Rm_DragElementStartPos
		{
			get
			{
				if(r_m_DragElementStartPos == null)
				{
					r_m_DragElementStartPos = new(this, "m_DragElementStartPos");
					r_m_DragElementStartPos.SetBelong(this.instance);
				}
				return r_m_DragElementStartPos;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.SliderDirection m_Direction
		/// </summary>
		protected RField r_m_Direction;
		public virtual RField Rm_Direction
		{
			get
			{
				if(r_m_Direction == null)
				{
					r_m_Direction = new(this, "m_Direction");
					r_m_Direction.SetBelong(this.instance);
				}
				return r_m_Direction;
			}
		}

		/// <summary>
		/// System.Boolean m_Inverted
		/// </summary>
		protected RField r_m_Inverted;
		public virtual RField Rm_Inverted
		{
			get
			{
				if(r_m_Inverted == null)
				{
					r_m_Inverted = new(this, "m_Inverted");
					r_m_Inverted.SetBelong(this.instance);
				}
				return r_m_Inverted;
			}
		}

		/// <summary>
		/// System.Single kDefaultPageSize
		/// </summary>
		protected static RField r_kDefaultPageSize;
		public static RField RkDefaultPageSize
		{
			get
			{
				if(r_kDefaultPageSize == null)
				{
					r_kDefaultPageSize = new(typeof(UnityEngine.UIElements.BaseSlider<>), "kDefaultPageSize");
					r_kDefaultPageSize.SetBelong(null);
				}
				return r_kDefaultPageSize;
			}
		}

		/// <summary>
		/// System.Boolean kDefaultShowInputField
		/// </summary>
		protected static RField r_kDefaultShowInputField;
		public static RField RkDefaultShowInputField
		{
			get
			{
				if(r_kDefaultShowInputField == null)
				{
					r_kDefaultShowInputField = new(typeof(UnityEngine.UIElements.BaseSlider<>), "kDefaultShowInputField");
					r_kDefaultShowInputField.SetBelong(null);
				}
				return r_kDefaultShowInputField;
			}
		}

		/// <summary>
		/// System.Boolean kDefaultInverted
		/// </summary>
		protected static RField r_kDefaultInverted;
		public static RField RkDefaultInverted
		{
			get
			{
				if(r_kDefaultInverted == null)
				{
					r_kDefaultInverted = new(typeof(UnityEngine.UIElements.BaseSlider<>), "kDefaultInverted");
					r_kDefaultInverted.SetBelong(null);
				}
				return r_kDefaultInverted;
			}
		}

		/// <summary>
		/// System.String ussClassName
		/// </summary>
		protected static RField r_ussClassName;
		public static RField RussClassName
		{
			get
			{
				if(r_ussClassName == null)
				{
					r_ussClassName = new(typeof(UnityEngine.UIElements.BaseSlider<>), "ussClassName");
					r_ussClassName.SetBelong(null);
				}
				return r_ussClassName;
			}
		}

		/// <summary>
		/// System.String labelUssClassName
		/// </summary>
		protected static RField r_labelUssClassName;
		public static RField RlabelUssClassName
		{
			get
			{
				if(r_labelUssClassName == null)
				{
					r_labelUssClassName = new(typeof(UnityEngine.UIElements.BaseSlider<>), "labelUssClassName");
					r_labelUssClassName.SetBelong(null);
				}
				return r_labelUssClassName;
			}
		}

		/// <summary>
		/// System.String inputUssClassName
		/// </summary>
		protected static RField r_inputUssClassName;
		public static RField RinputUssClassName
		{
			get
			{
				if(r_inputUssClassName == null)
				{
					r_inputUssClassName = new(typeof(UnityEngine.UIElements.BaseSlider<>), "inputUssClassName");
					r_inputUssClassName.SetBelong(null);
				}
				return r_inputUssClassName;
			}
		}

		/// <summary>
		/// System.String horizontalVariantUssClassName
		/// </summary>
		protected static RField r_horizontalVariantUssClassName;
		public static RField RhorizontalVariantUssClassName
		{
			get
			{
				if(r_horizontalVariantUssClassName == null)
				{
					r_horizontalVariantUssClassName = new(typeof(UnityEngine.UIElements.BaseSlider<>), "horizontalVariantUssClassName");
					r_horizontalVariantUssClassName.SetBelong(null);
				}
				return r_horizontalVariantUssClassName;
			}
		}

		/// <summary>
		/// System.String verticalVariantUssClassName
		/// </summary>
		protected static RField r_verticalVariantUssClassName;
		public static RField RverticalVariantUssClassName
		{
			get
			{
				if(r_verticalVariantUssClassName == null)
				{
					r_verticalVariantUssClassName = new(typeof(UnityEngine.UIElements.BaseSlider<>), "verticalVariantUssClassName");
					r_verticalVariantUssClassName.SetBelong(null);
				}
				return r_verticalVariantUssClassName;
			}
		}

		/// <summary>
		/// System.String dragContainerUssClassName
		/// </summary>
		protected static RField r_dragContainerUssClassName;
		public static RField RdragContainerUssClassName
		{
			get
			{
				if(r_dragContainerUssClassName == null)
				{
					r_dragContainerUssClassName = new(typeof(UnityEngine.UIElements.BaseSlider<>), "dragContainerUssClassName");
					r_dragContainerUssClassName.SetBelong(null);
				}
				return r_dragContainerUssClassName;
			}
		}

		/// <summary>
		/// System.String trackerUssClassName
		/// </summary>
		protected static RField r_trackerUssClassName;
		public static RField RtrackerUssClassName
		{
			get
			{
				if(r_trackerUssClassName == null)
				{
					r_trackerUssClassName = new(typeof(UnityEngine.UIElements.BaseSlider<>), "trackerUssClassName");
					r_trackerUssClassName.SetBelong(null);
				}
				return r_trackerUssClassName;
			}
		}

		/// <summary>
		/// System.String draggerUssClassName
		/// </summary>
		protected static RField r_draggerUssClassName;
		public static RField RdraggerUssClassName
		{
			get
			{
				if(r_draggerUssClassName == null)
				{
					r_draggerUssClassName = new(typeof(UnityEngine.UIElements.BaseSlider<>), "draggerUssClassName");
					r_draggerUssClassName.SetBelong(null);
				}
				return r_draggerUssClassName;
			}
		}

		/// <summary>
		/// System.String draggerBorderUssClassName
		/// </summary>
		protected static RField r_draggerBorderUssClassName;
		public static RField RdraggerBorderUssClassName
		{
			get
			{
				if(r_draggerBorderUssClassName == null)
				{
					r_draggerBorderUssClassName = new(typeof(UnityEngine.UIElements.BaseSlider<>), "draggerBorderUssClassName");
					r_draggerBorderUssClassName.SetBelong(null);
				}
				return r_draggerBorderUssClassName;
			}
		}

		/// <summary>
		/// System.String textFieldClassName
		/// </summary>
		protected static RField r_textFieldClassName;
		public static RField RtextFieldClassName
		{
			get
			{
				if(r_textFieldClassName == null)
				{
					r_textFieldClassName = new(typeof(UnityEngine.UIElements.BaseSlider<>), "textFieldClassName");
					r_textFieldClassName.SetBelong(null);
				}
				return r_textFieldClassName;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags m_Flags
		/// </summary>
		protected RField r_m_Flags;
		public virtual RField Rm_Flags
		{
			get
			{
				if(r_m_Flags == null)
				{
					r_m_Flags = new(this, "m_Flags");
					r_m_Flags.SetBelong(this.instance);
				}
				return r_m_Flags;
			}
		}

		/// <summary>
		/// UnityEngine.Rect lastLayout
		/// </summary>
		protected RUnityEngine.RRect r_lastLayout;
		public virtual RUnityEngine.RRect RlastLayout
		{
			get
			{
				if(r_lastLayout == null)
				{
					r_lastLayout = new(this, "lastLayout");
					r_lastLayout.SetBelong(this.instance);
				}
				return r_lastLayout;
			}
		}

		/// <summary>
		/// UnityEngine.Rect lastPseudoPadding
		/// </summary>
		protected RUnityEngine.RRect r_lastPseudoPadding;
		public virtual RUnityEngine.RRect RlastPseudoPadding
		{
			get
			{
				if(r_lastPseudoPadding == null)
				{
					r_lastPseudoPadding = new(this, "lastPseudoPadding");
					r_lastPseudoPadding.SetBelong(this.instance);
				}
				return r_lastPseudoPadding;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainVEData renderChainData
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChainVEData r_renderChainData;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChainVEData RrenderChainData
		{
			get
			{
				if(r_renderChainData == null)
				{
					r_renderChainData = new(this, "renderChainData");
					r_renderChainData.SetBelong(this.instance);
				}
				return r_renderChainData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PseudoStates triggerPseudoMask
		/// </summary>
		protected RField r_triggerPseudoMask;
		public virtual RField RtriggerPseudoMask
		{
			get
			{
				if(r_triggerPseudoMask == null)
				{
					r_triggerPseudoMask = new(this, "triggerPseudoMask");
					r_triggerPseudoMask.SetBelong(this.instance);
				}
				return r_triggerPseudoMask;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PseudoStates dependencyPseudoMask
		/// </summary>
		protected RField r_dependencyPseudoMask;
		public virtual RField RdependencyPseudoMask
		{
			get
			{
				if(r_dependencyPseudoMask == null)
				{
					r_dependencyPseudoMask = new(this, "dependencyPseudoMask");
					r_dependencyPseudoMask.SetBelong(this.instance);
				}
				return r_dependencyPseudoMask;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ComputedStyle m_Style
		/// </summary>
		protected RUnityEngine.RUIElements.RComputedStyle r_m_Style;
		public virtual RUnityEngine.RUIElements.RComputedStyle Rm_Style
		{
			get
			{
				if(r_m_Style == null)
				{
					r_m_Style = new(this, "m_Style");
					r_m_Style.SetBelong(this.instance);
				}
				return r_m_Style;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleVariableContext variableContext
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleVariableContext r_variableContext;
		public virtual RUnityEngine.RUIElements.RStyleVariableContext RvariableContext
		{
			get
			{
				if(r_variableContext == null)
				{
					r_variableContext = new(this, "variableContext");
					r_variableContext.SetBelong(this.instance);
				}
				return r_variableContext;
			}
		}

		/// <summary>
		/// System.Int32 inheritedStylesHash
		/// </summary>
		protected RField r_inheritedStylesHash;
		public virtual RField RinheritedStylesHash
		{
			get
			{
				if(r_inheritedStylesHash == null)
				{
					r_inheritedStylesHash = new(this, "inheritedStylesHash");
					r_inheritedStylesHash.SetBelong(this.instance);
				}
				return r_inheritedStylesHash;
			}
		}

		/// <summary>
		/// System.UInt32 controlid
		/// </summary>
		protected RField r_controlid;
		public virtual RField Rcontrolid
		{
			get
			{
				if(r_controlid == null)
				{
					r_controlid = new(this, "controlid");
					r_controlid.SetBelong(this.instance);
				}
				return r_controlid;
			}
		}

		/// <summary>
		/// System.Int32 imguiContainerDescendantCount
		/// </summary>
		protected RField r_imguiContainerDescendantCount;
		public virtual RField RimguiContainerDescendantCount
		{
			get
			{
				if(r_imguiContainerDescendantCount == null)
				{
					r_imguiContainerDescendantCount = new(this, "imguiContainerDescendantCount");
					r_imguiContainerDescendantCount.SetBelong(this.instance);
				}
				return r_imguiContainerDescendantCount;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.InlineStyleAccess inlineStyleAccess
		/// </summary>
		protected RUnityEngine.RUIElements.RInlineStyleAccess r_inlineStyleAccess;
		public virtual RUnityEngine.RUIElements.RInlineStyleAccess RinlineStyleAccess
		{
			get
			{
				if(r_inlineStyleAccess == null)
				{
					r_inlineStyleAccess = new(this, "inlineStyleAccess");
					r_inlineStyleAccess.SetBelong(this.instance);
				}
				return r_inlineStyleAccess;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheet] styleSheetList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheet> r_styleSheetList;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheet> RstyleSheetList
		{
			get
			{
				if(r_styleSheetList == null)
				{
					r_styleSheetList = new(this, "styleSheetList");
					r_styleSheetList.SetBelong(this.instance);
				}
				return r_styleSheetList;
			}
		}

		/// <summary>
		/// System.Boolean isIMGUIContainer
		/// </summary>
		protected RField r_isIMGUIContainer;
		public virtual RField RisIMGUIContainer
		{
			get
			{
				if(r_isIMGUIContainer == null)
				{
					r_isIMGUIContainer = new(this, "isIMGUIContainer");
					r_isIMGUIContainer.SetBelong(this.instance);
				}
				return r_isIMGUIContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement dragContainer
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_dragContainer;
		public virtual RUnityEngine.RUIElements.RVisualElement RdragContainer
		{
			get
			{
				if(r_dragContainer == null)
				{
					r_dragContainer = new(this, "dragContainer", -1);
					r_dragContainer.SetBelong(this.instance);
				}
				return r_dragContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement dragElement
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_dragElement;
		public virtual RUnityEngine.RUIElements.RVisualElement RdragElement
		{
			get
			{
				if(r_dragElement == null)
				{
					r_dragElement = new(this, "dragElement", -1);
					r_dragElement.SetBelong(this.instance);
				}
				return r_dragElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement trackElement
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_trackElement;
		public virtual RUnityEngine.RUIElements.RVisualElement RtrackElement
		{
			get
			{
				if(r_trackElement == null)
				{
					r_trackElement = new(this, "trackElement", -1);
					r_trackElement.SetBelong(this.instance);
				}
				return r_trackElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement dragBorderElement
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_dragBorderElement;
		public virtual RUnityEngine.RUIElements.RVisualElement RdragBorderElement
		{
			get
			{
				if(r_dragBorderElement == null)
				{
					r_dragBorderElement = new(this, "dragBorderElement", -1);
					r_dragBorderElement.SetBelong(this.instance);
				}
				return r_dragBorderElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextField inputTextField
		/// </summary>
		protected RUnityEngine.RUIElements.RTextField r_inputTextField;
		public virtual RUnityEngine.RUIElements.RTextField RinputTextField
		{
			get
			{
				if(r_inputTextField == null)
				{
					r_inputTextField = new(this, "inputTextField", -1);
					r_inputTextField.SetBelong(this.instance);
				}
				return r_inputTextField;
			}
		}

		/// <summary>
		/// TValueType lowValue
		/// </summary>
		protected RProperty r_lowValue;
		public virtual RProperty RlowValue
		{
			get
			{
				if(r_lowValue == null)
				{
					r_lowValue = new(this, "lowValue", -1);
					r_lowValue.SetBelong(this.instance);
				}
				return r_lowValue;
			}
		}

		/// <summary>
		/// TValueType highValue
		/// </summary>
		protected RProperty r_highValue;
		public virtual RProperty RhighValue
		{
			get
			{
				if(r_highValue == null)
				{
					r_highValue = new(this, "highValue", -1);
					r_highValue.SetBelong(this.instance);
				}
				return r_highValue;
			}
		}

		/// <summary>
		/// TValueType range
		/// </summary>
		protected RProperty r_range;
		public virtual RProperty Rrange
		{
			get
			{
				if(r_range == null)
				{
					r_range = new(this, "range", -1);
					r_range.SetBelong(this.instance);
				}
				return r_range;
			}
		}

		/// <summary>
		/// Single pageSize
		/// </summary>
		protected RProperty r_pageSize;
		public virtual RProperty RpageSize
		{
			get
			{
				if(r_pageSize == null)
				{
					r_pageSize = new(this, "pageSize", -1);
					r_pageSize.SetBelong(this.instance);
				}
				return r_pageSize;
			}
		}

		/// <summary>
		/// Boolean showInputField
		/// </summary>
		protected RProperty r_showInputField;
		public virtual RProperty RshowInputField
		{
			get
			{
				if(r_showInputField == null)
				{
					r_showInputField = new(this, "showInputField", -1);
					r_showInputField.SetBelong(this.instance);
				}
				return r_showInputField;
			}
		}

		/// <summary>
		/// Boolean clamped
		/// </summary>
		protected RProperty r_clamped;
		public virtual RProperty Rclamped
		{
			get
			{
				if(r_clamped == null)
				{
					r_clamped = new(this, "clamped", -1);
					r_clamped.SetBelong(this.instance);
				}
				return r_clamped;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ClampedDragger`1[TValueType] clampedDragger
		/// </summary>
		protected RUnityEngine.RUIElements.RClampedDragger<RProperty> r_clampedDragger;
		public virtual RUnityEngine.RUIElements.RClampedDragger<RProperty> RclampedDragger
		{
			get
			{
				if(r_clampedDragger == null)
				{
					r_clampedDragger = new(this, "clampedDragger", -1);
					r_clampedDragger.SetBelong(this.instance);
				}
				return r_clampedDragger;
			}
		}

		/// <summary>
		/// TValueType value
		/// </summary>
		protected RProperty r_value;
		public virtual RProperty Rvalue
		{
			get
			{
				if(r_value == null)
				{
					r_value = new(this, "value", -1);
					r_value.SetBelong(this.instance);
				}
				return r_value;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.SliderDirection direction
		/// </summary>
		protected RProperty r_direction;
		public virtual RProperty Rdirection
		{
			get
			{
				if(r_direction == null)
				{
					r_direction = new(this, "direction", -1);
					r_direction.SetBelong(this.instance);
				}
				return r_direction;
			}
		}

		/// <summary>
		/// Boolean inverted
		/// </summary>
		protected RProperty r_inverted;
		public virtual RProperty Rinverted
		{
			get
			{
				if(r_inverted == null)
				{
					r_inverted = new(this, "inverted", -1);
					r_inverted.SetBelong(this.instance);
				}
				return r_inverted;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement visualInput
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_visualInput;
		public virtual RUnityEngine.RUIElements.RVisualElement RvisualInput
		{
			get
			{
				if(r_visualInput == null)
				{
					r_visualInput = new(this, "visualInput", -1);
					r_visualInput.SetBelong(this.instance);
				}
				return r_visualInput;
			}
		}

		/// <summary>
		/// TValueType rawValue
		/// </summary>
		protected RProperty r_rawValue;
		public virtual RProperty RrawValue
		{
			get
			{
				if(r_rawValue == null)
				{
					r_rawValue = new(this, "rawValue", -1);
					r_rawValue.SetBelong(this.instance);
				}
				return r_rawValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Label labelElement
		/// </summary>
		protected RUnityEngine.RUIElements.RLabel r_labelElement;
		public virtual RUnityEngine.RUIElements.RLabel RlabelElement
		{
			get
			{
				if(r_labelElement == null)
				{
					r_labelElement = new(this, "labelElement", -1);
					r_labelElement.SetBelong(this.instance);
				}
				return r_labelElement;
			}
		}

		/// <summary>
		/// System.String label
		/// </summary>
		protected RProperty r_label;
		public virtual RProperty Rlabel
		{
			get
			{
				if(r_label == null)
				{
					r_label = new(this, "label", -1);
					r_label.SetBelong(this.instance);
				}
				return r_label;
			}
		}

		/// <summary>
		/// Boolean showMixedValue
		/// </summary>
		protected RProperty r_showMixedValue;
		public virtual RProperty RshowMixedValue
		{
			get
			{
				if(r_showMixedValue == null)
				{
					r_showMixedValue = new(this, "showMixedValue", -1);
					r_showMixedValue.SetBelong(this.instance);
				}
				return r_showMixedValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Label mixedValueLabel
		/// </summary>
		protected RUnityEngine.RUIElements.RLabel r_mixedValueLabel;
		public virtual RUnityEngine.RUIElements.RLabel RmixedValueLabel
		{
			get
			{
				if(r_mixedValueLabel == null)
				{
					r_mixedValueLabel = new(this, "mixedValueLabel", -1);
					r_mixedValueLabel.SetBelong(this.instance);
				}
				return r_mixedValueLabel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IBinding binding
		/// </summary>
		protected RUnityEngine.RUIElements.RIBinding r_binding;
		public virtual RUnityEngine.RUIElements.RIBinding Rbinding
		{
			get
			{
				if(r_binding == null)
				{
					r_binding = new(this, "binding", -1);
					r_binding.SetBelong(this.instance);
				}
				return r_binding;
			}
		}

		/// <summary>
		/// System.String bindingPath
		/// </summary>
		protected RProperty r_bindingPath;
		public virtual RProperty RbindingPath
		{
			get
			{
				if(r_bindingPath == null)
				{
					r_bindingPath = new(this, "bindingPath", -1);
					r_bindingPath.SetBelong(this.instance);
				}
				return r_bindingPath;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IResolvedStyle resolvedStyle
		/// </summary>
		protected RUnityEngine.RUIElements.RIResolvedStyle r_resolvedStyle;
		public virtual RUnityEngine.RUIElements.RIResolvedStyle RresolvedStyle
		{
			get
			{
				if(r_resolvedStyle == null)
				{
					r_resolvedStyle = new(this, "resolvedStyle", -1);
					r_resolvedStyle.SetBelong(this.instance);
				}
				return r_resolvedStyle;
			}
		}

		/// <summary>
		/// Boolean hasRunningAnimations
		/// </summary>
		protected RProperty r_hasRunningAnimations;
		public virtual RProperty RhasRunningAnimations
		{
			get
			{
				if(r_hasRunningAnimations == null)
				{
					r_hasRunningAnimations = new(this, "hasRunningAnimations", -1);
					r_hasRunningAnimations.SetBelong(this.instance);
				}
				return r_hasRunningAnimations;
			}
		}

		/// <summary>
		/// Boolean hasCompletedAnimations
		/// </summary>
		protected RProperty r_hasCompletedAnimations;
		public virtual RProperty RhasCompletedAnimations
		{
			get
			{
				if(r_hasCompletedAnimations == null)
				{
					r_hasCompletedAnimations = new(this, "hasCompletedAnimations", -1);
					r_hasCompletedAnimations.SetBelong(this.instance);
				}
				return r_hasCompletedAnimations;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IStylePropertyAnimations styleAnimation
		/// </summary>
		protected RUnityEngine.RUIElements.RIStylePropertyAnimations r_styleAnimation;
		public virtual RUnityEngine.RUIElements.RIStylePropertyAnimations RstyleAnimation
		{
			get
			{
				if(r_styleAnimation == null)
				{
					r_styleAnimation = new(this, "styleAnimation", -1);
					r_styleAnimation.SetBelong(this.instance);
				}
				return r_styleAnimation;
			}
		}

		/// <summary>
		/// Boolean isCompositeRoot
		/// </summary>
		protected RProperty r_isCompositeRoot;
		public virtual RProperty RisCompositeRoot
		{
			get
			{
				if(r_isCompositeRoot == null)
				{
					r_isCompositeRoot = new(this, "isCompositeRoot", -1);
					r_isCompositeRoot.SetBelong(this.instance);
				}
				return r_isCompositeRoot;
			}
		}

		/// <summary>
		/// Boolean isHierarchyDisplayed
		/// </summary>
		protected RProperty r_isHierarchyDisplayed;
		public virtual RProperty RisHierarchyDisplayed
		{
			get
			{
				if(r_isHierarchyDisplayed == null)
				{
					r_isHierarchyDisplayed = new(this, "isHierarchyDisplayed", -1);
					r_isHierarchyDisplayed.SetBelong(this.instance);
				}
				return r_isHierarchyDisplayed;
			}
		}

		/// <summary>
		/// System.String viewDataKey
		/// </summary>
		protected RProperty r_viewDataKey;
		public virtual RProperty RviewDataKey
		{
			get
			{
				if(r_viewDataKey == null)
				{
					r_viewDataKey = new(this, "viewDataKey", -1);
					r_viewDataKey.SetBelong(this.instance);
				}
				return r_viewDataKey;
			}
		}

		/// <summary>
		/// Boolean enableViewDataPersistence
		/// </summary>
		protected RProperty r_enableViewDataPersistence;
		public virtual RProperty RenableViewDataPersistence
		{
			get
			{
				if(r_enableViewDataPersistence == null)
				{
					r_enableViewDataPersistence = new(this, "enableViewDataPersistence", -1);
					r_enableViewDataPersistence.SetBelong(this.instance);
				}
				return r_enableViewDataPersistence;
			}
		}

		/// <summary>
		/// System.Object userData
		/// </summary>
		protected RSystem.RObject r_userData;
		public virtual RSystem.RObject RuserData
		{
			get
			{
				if(r_userData == null)
				{
					r_userData = new(this, "userData", -1);
					r_userData.SetBelong(this.instance);
				}
				return r_userData;
			}
		}

		/// <summary>
		/// Boolean canGrabFocus
		/// </summary>
		protected RProperty r_canGrabFocus;
		public virtual RProperty RcanGrabFocus
		{
			get
			{
				if(r_canGrabFocus == null)
				{
					r_canGrabFocus = new(this, "canGrabFocus", -1);
					r_canGrabFocus.SetBelong(this.instance);
				}
				return r_canGrabFocus;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FocusController focusController
		/// </summary>
		protected RUnityEngine.RUIElements.RFocusController r_focusController;
		public virtual RUnityEngine.RUIElements.RFocusController RfocusController
		{
			get
			{
				if(r_focusController == null)
				{
					r_focusController = new(this, "focusController", -1);
					r_focusController.SetBelong(this.instance);
				}
				return r_focusController;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UsageHints usageHints
		/// </summary>
		protected RProperty r_usageHints;
		public virtual RProperty RusageHints
		{
			get
			{
				if(r_usageHints == null)
				{
					r_usageHints = new(this, "usageHints", -1);
					r_usageHints.SetBelong(this.instance);
				}
				return r_usageHints;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.RenderHints renderHints
		/// </summary>
		protected RProperty r_renderHints;
		public virtual RProperty RrenderHints
		{
			get
			{
				if(r_renderHints == null)
				{
					r_renderHints = new(this, "renderHints", -1);
					r_renderHints.SetBelong(this.instance);
				}
				return r_renderHints;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ITransform transform
		/// </summary>
		protected RUnityEngine.RUIElements.RITransform r_transform;
		public virtual RUnityEngine.RUIElements.RITransform Rtransform
		{
			get
			{
				if(r_transform == null)
				{
					r_transform = new(this, "transform", -1);
					r_transform.SetBelong(this.instance);
				}
				return r_transform;
			}
		}

		/// <summary>
		/// Boolean isLayoutManual
		/// </summary>
		protected RProperty r_isLayoutManual;
		public virtual RProperty RisLayoutManual
		{
			get
			{
				if(r_isLayoutManual == null)
				{
					r_isLayoutManual = new(this, "isLayoutManual", -1);
					r_isLayoutManual.SetBelong(this.instance);
				}
				return r_isLayoutManual;
			}
		}

		/// <summary>
		/// Single scaledPixelsPerPoint
		/// </summary>
		protected RProperty r_scaledPixelsPerPoint;
		public virtual RProperty RscaledPixelsPerPoint
		{
			get
			{
				if(r_scaledPixelsPerPoint == null)
				{
					r_scaledPixelsPerPoint = new(this, "scaledPixelsPerPoint", -1);
					r_scaledPixelsPerPoint.SetBelong(this.instance);
				}
				return r_scaledPixelsPerPoint;
			}
		}

		/// <summary>
		/// UnityEngine.Rect layout
		/// </summary>
		protected RUnityEngine.RRect r_layout;
		public virtual RUnityEngine.RRect Rlayout
		{
			get
			{
				if(r_layout == null)
				{
					r_layout = new(this, "layout", -1);
					r_layout.SetBelong(this.instance);
				}
				return r_layout;
			}
		}

		/// <summary>
		/// UnityEngine.Rect contentRect
		/// </summary>
		protected RUnityEngine.RRect r_contentRect;
		public virtual RUnityEngine.RRect RcontentRect
		{
			get
			{
				if(r_contentRect == null)
				{
					r_contentRect = new(this, "contentRect", -1);
					r_contentRect.SetBelong(this.instance);
				}
				return r_contentRect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect paddingRect
		/// </summary>
		protected RUnityEngine.RRect r_paddingRect;
		public virtual RUnityEngine.RRect RpaddingRect
		{
			get
			{
				if(r_paddingRect == null)
				{
					r_paddingRect = new(this, "paddingRect", -1);
					r_paddingRect.SetBelong(this.instance);
				}
				return r_paddingRect;
			}
		}

		/// <summary>
		/// Boolean isBoundingBoxDirty
		/// </summary>
		protected RProperty r_isBoundingBoxDirty;
		public virtual RProperty RisBoundingBoxDirty
		{
			get
			{
				if(r_isBoundingBoxDirty == null)
				{
					r_isBoundingBoxDirty = new(this, "isBoundingBoxDirty", -1);
					r_isBoundingBoxDirty.SetBelong(this.instance);
				}
				return r_isBoundingBoxDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldBoundingBoxDirty
		/// </summary>
		protected RProperty r_isWorldBoundingBoxDirty;
		public virtual RProperty RisWorldBoundingBoxDirty
		{
			get
			{
				if(r_isWorldBoundingBoxDirty == null)
				{
					r_isWorldBoundingBoxDirty = new(this, "isWorldBoundingBoxDirty", -1);
					r_isWorldBoundingBoxDirty.SetBelong(this.instance);
				}
				return r_isWorldBoundingBoxDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldBoundingBoxOrDependenciesDirty
		/// </summary>
		protected RProperty r_isWorldBoundingBoxOrDependenciesDirty;
		public virtual RProperty RisWorldBoundingBoxOrDependenciesDirty
		{
			get
			{
				if(r_isWorldBoundingBoxOrDependenciesDirty == null)
				{
					r_isWorldBoundingBoxOrDependenciesDirty = new(this, "isWorldBoundingBoxOrDependenciesDirty", -1);
					r_isWorldBoundingBoxOrDependenciesDirty.SetBelong(this.instance);
				}
				return r_isWorldBoundingBoxOrDependenciesDirty;
			}
		}

		/// <summary>
		/// UnityEngine.Rect boundingBox
		/// </summary>
		protected RUnityEngine.RRect r_boundingBox;
		public virtual RUnityEngine.RRect RboundingBox
		{
			get
			{
				if(r_boundingBox == null)
				{
					r_boundingBox = new(this, "boundingBox", -1);
					r_boundingBox.SetBelong(this.instance);
				}
				return r_boundingBox;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldBoundingBox
		/// </summary>
		protected RUnityEngine.RRect r_worldBoundingBox;
		public virtual RUnityEngine.RRect RworldBoundingBox
		{
			get
			{
				if(r_worldBoundingBox == null)
				{
					r_worldBoundingBox = new(this, "worldBoundingBox", -1);
					r_worldBoundingBox.SetBelong(this.instance);
				}
				return r_worldBoundingBox;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldBound
		/// </summary>
		protected RUnityEngine.RRect r_worldBound;
		public virtual RUnityEngine.RRect RworldBound
		{
			get
			{
				if(r_worldBound == null)
				{
					r_worldBound = new(this, "worldBound", -1);
					r_worldBound.SetBelong(this.instance);
				}
				return r_worldBound;
			}
		}

		/// <summary>
		/// UnityEngine.Rect localBound
		/// </summary>
		protected RUnityEngine.RRect r_localBound;
		public virtual RUnityEngine.RRect RlocalBound
		{
			get
			{
				if(r_localBound == null)
				{
					r_localBound = new(this, "localBound", -1);
					r_localBound.SetBelong(this.instance);
				}
				return r_localBound;
			}
		}

		/// <summary>
		/// UnityEngine.Rect rect
		/// </summary>
		protected RUnityEngine.RRect r_rect;
		public virtual RUnityEngine.RRect Rrect
		{
			get
			{
				if(r_rect == null)
				{
					r_rect = new(this, "rect", -1);
					r_rect.SetBelong(this.instance);
				}
				return r_rect;
			}
		}

		/// <summary>
		/// Boolean isWorldTransformDirty
		/// </summary>
		protected RProperty r_isWorldTransformDirty;
		public virtual RProperty RisWorldTransformDirty
		{
			get
			{
				if(r_isWorldTransformDirty == null)
				{
					r_isWorldTransformDirty = new(this, "isWorldTransformDirty", -1);
					r_isWorldTransformDirty.SetBelong(this.instance);
				}
				return r_isWorldTransformDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldTransformInverseDirty
		/// </summary>
		protected RProperty r_isWorldTransformInverseDirty;
		public virtual RProperty RisWorldTransformInverseDirty
		{
			get
			{
				if(r_isWorldTransformInverseDirty == null)
				{
					r_isWorldTransformInverseDirty = new(this, "isWorldTransformInverseDirty", -1);
					r_isWorldTransformInverseDirty.SetBelong(this.instance);
				}
				return r_isWorldTransformInverseDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldTransformInverseOrDependenciesDirty
		/// </summary>
		protected RProperty r_isWorldTransformInverseOrDependenciesDirty;
		public virtual RProperty RisWorldTransformInverseOrDependenciesDirty
		{
			get
			{
				if(r_isWorldTransformInverseOrDependenciesDirty == null)
				{
					r_isWorldTransformInverseOrDependenciesDirty = new(this, "isWorldTransformInverseOrDependenciesDirty", -1);
					r_isWorldTransformInverseOrDependenciesDirty.SetBelong(this.instance);
				}
				return r_isWorldTransformInverseOrDependenciesDirty;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 worldTransform
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_worldTransform;
		public virtual RUnityEngine.RMatrix4x4 RworldTransform
		{
			get
			{
				if(r_worldTransform == null)
				{
					r_worldTransform = new(this, "worldTransform", -1);
					r_worldTransform.SetBelong(this.instance);
				}
				return r_worldTransform;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4& worldTransformRef
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_worldTransformRef;
		public virtual RUnityEngine.RMatrix4x4 RworldTransformRef
		{
			get
			{
				if(r_worldTransformRef == null)
				{
					r_worldTransformRef = new(this, "worldTransformRef", -1);
					r_worldTransformRef.SetBelong(this.instance);
				}
				return r_worldTransformRef;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4& worldTransformInverse
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_worldTransformInverse;
		public virtual RUnityEngine.RMatrix4x4 RworldTransformInverse
		{
			get
			{
				if(r_worldTransformInverse == null)
				{
					r_worldTransformInverse = new(this, "worldTransformInverse", -1);
					r_worldTransformInverse.SetBelong(this.instance);
				}
				return r_worldTransformInverse;
			}
		}

		/// <summary>
		/// Boolean isWorldClipDirty
		/// </summary>
		protected RProperty r_isWorldClipDirty;
		public virtual RProperty RisWorldClipDirty
		{
			get
			{
				if(r_isWorldClipDirty == null)
				{
					r_isWorldClipDirty = new(this, "isWorldClipDirty", -1);
					r_isWorldClipDirty.SetBelong(this.instance);
				}
				return r_isWorldClipDirty;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldClip
		/// </summary>
		protected RUnityEngine.RRect r_worldClip;
		public virtual RUnityEngine.RRect RworldClip
		{
			get
			{
				if(r_worldClip == null)
				{
					r_worldClip = new(this, "worldClip", -1);
					r_worldClip.SetBelong(this.instance);
				}
				return r_worldClip;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldClipMinusGroup
		/// </summary>
		protected RUnityEngine.RRect r_worldClipMinusGroup;
		public virtual RUnityEngine.RRect RworldClipMinusGroup
		{
			get
			{
				if(r_worldClipMinusGroup == null)
				{
					r_worldClipMinusGroup = new(this, "worldClipMinusGroup", -1);
					r_worldClipMinusGroup.SetBelong(this.instance);
				}
				return r_worldClipMinusGroup;
			}
		}

		/// <summary>
		/// Boolean worldClipIsInfinite
		/// </summary>
		protected RProperty r_worldClipIsInfinite;
		public virtual RProperty RworldClipIsInfinite
		{
			get
			{
				if(r_worldClipIsInfinite == null)
				{
					r_worldClipIsInfinite = new(this, "worldClipIsInfinite", -1);
					r_worldClipIsInfinite.SetBelong(this.instance);
				}
				return r_worldClipIsInfinite;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PseudoStates pseudoStates
		/// </summary>
		protected RProperty r_pseudoStates;
		public virtual RProperty RpseudoStates
		{
			get
			{
				if(r_pseudoStates == null)
				{
					r_pseudoStates = new(this, "pseudoStates", -1);
					r_pseudoStates.SetBelong(this.instance);
				}
				return r_pseudoStates;
			}
		}

		/// <summary>
		/// Int32 containedPointerIds
		/// </summary>
		protected RProperty r_containedPointerIds;
		public virtual RProperty RcontainedPointerIds
		{
			get
			{
				if(r_containedPointerIds == null)
				{
					r_containedPointerIds = new(this, "containedPointerIds", -1);
					r_containedPointerIds.SetBelong(this.instance);
				}
				return r_containedPointerIds;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PickingMode pickingMode
		/// </summary>
		protected RProperty r_pickingMode;
		public virtual RProperty RpickingMode
		{
			get
			{
				if(r_pickingMode == null)
				{
					r_pickingMode = new(this, "pickingMode", -1);
					r_pickingMode.SetBelong(this.instance);
				}
				return r_pickingMode;
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
		/// System.Collections.Generic.List`1[System.String] classList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RProperty> r_classList;
		public virtual RSystem.RCollections.RGeneric.RList<RProperty> RclassList
		{
			get
			{
				if(r_classList == null)
				{
					r_classList = new(this, "classList", -1);
					r_classList.SetBelong(this.instance);
				}
				return r_classList;
			}
		}

		/// <summary>
		/// System.String fullTypeName
		/// </summary>
		protected RProperty r_fullTypeName;
		public virtual RProperty RfullTypeName
		{
			get
			{
				if(r_fullTypeName == null)
				{
					r_fullTypeName = new(this, "fullTypeName", -1);
					r_fullTypeName.SetBelong(this.instance);
				}
				return r_fullTypeName;
			}
		}

		/// <summary>
		/// System.String typeName
		/// </summary>
		protected RProperty r_typeName;
		public virtual RProperty RtypeName
		{
			get
			{
				if(r_typeName == null)
				{
					r_typeName = new(this, "typeName", -1);
					r_typeName.SetBelong(this.instance);
				}
				return r_typeName;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaNode yogaNode
		/// </summary>
		protected RUnityEngine.RYoga.RYogaNode r_yogaNode;
		public virtual RUnityEngine.RYoga.RYogaNode RyogaNode
		{
			get
			{
				if(r_yogaNode == null)
				{
					r_yogaNode = new(this, "yogaNode", -1);
					r_yogaNode.SetBelong(this.instance);
				}
				return r_yogaNode;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ComputedStyle& computedStyle
		/// </summary>
		protected RUnityEngine.RUIElements.RComputedStyle r_computedStyle;
		public virtual RUnityEngine.RUIElements.RComputedStyle RcomputedStyle
		{
			get
			{
				if(r_computedStyle == null)
				{
					r_computedStyle = new(this, "computedStyle", -1);
					r_computedStyle.SetBelong(this.instance);
				}
				return r_computedStyle;
			}
		}

		/// <summary>
		/// Boolean hasInlineStyle
		/// </summary>
		protected RProperty r_hasInlineStyle;
		public virtual RProperty RhasInlineStyle
		{
			get
			{
				if(r_hasInlineStyle == null)
				{
					r_hasInlineStyle = new(this, "hasInlineStyle", -1);
					r_hasInlineStyle.SetBelong(this.instance);
				}
				return r_hasInlineStyle;
			}
		}

		/// <summary>
		/// Boolean styleInitialized
		/// </summary>
		protected RProperty r_styleInitialized;
		public virtual RProperty RstyleInitialized
		{
			get
			{
				if(r_styleInitialized == null)
				{
					r_styleInitialized = new(this, "styleInitialized", -1);
					r_styleInitialized.SetBelong(this.instance);
				}
				return r_styleInitialized;
			}
		}

		/// <summary>
		/// Single opacity
		/// </summary>
		protected RProperty r_opacity;
		public virtual RProperty Ropacity
		{
			get
			{
				if(r_opacity == null)
				{
					r_opacity = new(this, "opacity", -1);
					r_opacity.SetBelong(this.instance);
				}
				return r_opacity;
			}
		}

		/// <summary>
		/// Boolean enabledInHierarchy
		/// </summary>
		protected RProperty r_enabledInHierarchy;
		public virtual RProperty RenabledInHierarchy
		{
			get
			{
				if(r_enabledInHierarchy == null)
				{
					r_enabledInHierarchy = new(this, "enabledInHierarchy", -1);
					r_enabledInHierarchy.SetBelong(this.instance);
				}
				return r_enabledInHierarchy;
			}
		}

		/// <summary>
		/// Boolean enabledSelf
		/// </summary>
		protected RProperty r_enabledSelf;
		public virtual RProperty RenabledSelf
		{
			get
			{
				if(r_enabledSelf == null)
				{
					r_enabledSelf = new(this, "enabledSelf", -1);
					r_enabledSelf.SetBelong(this.instance);
				}
				return r_enabledSelf;
			}
		}

		/// <summary>
		/// Boolean visible
		/// </summary>
		protected RProperty r_visible;
		public virtual RProperty Rvisible
		{
			get
			{
				if(r_visible == null)
				{
					r_visible = new(this, "visible", -1);
					r_visible.SetBelong(this.instance);
				}
				return r_visible;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.MeshGenerationContext] generateVisualContent
		/// </summary>
		protected RSystem.RAction<RUnityEngine.RUIElements.RMeshGenerationContext> r_generateVisualContent;
		public virtual RSystem.RAction<RUnityEngine.RUIElements.RMeshGenerationContext> RgenerateVisualContent
		{
			get
			{
				if(r_generateVisualContent == null)
				{
					r_generateVisualContent = new(this, "generateVisualContent", -1);
					r_generateVisualContent.SetBelong(this.instance);
				}
				return r_generateVisualContent;
			}
		}

		/// <summary>
		/// Boolean requireMeasureFunction
		/// </summary>
		protected RProperty r_requireMeasureFunction;
		public virtual RProperty RrequireMeasureFunction
		{
			get
			{
				if(r_requireMeasureFunction == null)
				{
					r_requireMeasureFunction = new(this, "requireMeasureFunction", -1);
					r_requireMeasureFunction.SetBelong(this.instance);
				}
				return r_requireMeasureFunction;
			}
		}

		/// <summary>
		/// RenderTargetMode subRenderTargetMode
		/// </summary>
		protected RProperty r_subRenderTargetMode;
		public virtual RProperty RsubRenderTargetMode
		{
			get
			{
				if(r_subRenderTargetMode == null)
				{
					r_subRenderTargetMode = new(this, "subRenderTargetMode", -1);
					r_subRenderTargetMode.SetBelong(this.instance);
				}
				return r_subRenderTargetMode;
			}
		}

		/// <summary>
		/// UnityEngine.Material defaultMaterial
		/// </summary>
		protected RUnityEngine.RMaterial r_defaultMaterial;
		public virtual RUnityEngine.RMaterial RdefaultMaterial
		{
			get
			{
				if(r_defaultMaterial == null)
				{
					r_defaultMaterial = new(this, "defaultMaterial", -1);
					r_defaultMaterial.SetBelong(this.instance);
				}
				return r_defaultMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement nextParentWithEventCallback
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_nextParentWithEventCallback;
		public virtual RUnityEngine.RUIElements.RVisualElement RnextParentWithEventCallback
		{
			get
			{
				if(r_nextParentWithEventCallback == null)
				{
					r_nextParentWithEventCallback = new(this, "nextParentWithEventCallback", -1);
					r_nextParentWithEventCallback.SetBelong(this.instance);
				}
				return r_nextParentWithEventCallback;
			}
		}

		/// <summary>
		/// Int32 eventCallbackCategories
		/// </summary>
		protected RProperty r_eventCallbackCategories;
		public virtual RProperty ReventCallbackCategories
		{
			get
			{
				if(r_eventCallbackCategories == null)
				{
					r_eventCallbackCategories = new(this, "eventCallbackCategories", -1);
					r_eventCallbackCategories.SetBelong(this.instance);
				}
				return r_eventCallbackCategories;
			}
		}

		/// <summary>
		/// Int32 eventCallbackParentCategories
		/// </summary>
		protected RProperty r_eventCallbackParentCategories;
		public virtual RProperty ReventCallbackParentCategories
		{
			get
			{
				if(r_eventCallbackParentCategories == null)
				{
					r_eventCallbackParentCategories = new(this, "eventCallbackParentCategories", -1);
					r_eventCallbackParentCategories.SetBelong(this.instance);
				}
				return r_eventCallbackParentCategories;
			}
		}

		/// <summary>
		/// Boolean isEventCallbackParentCategoriesDirty
		/// </summary>
		protected RProperty r_isEventCallbackParentCategoriesDirty;
		public virtual RProperty RisEventCallbackParentCategoriesDirty
		{
			get
			{
				if(r_isEventCallbackParentCategoriesDirty == null)
				{
					r_isEventCallbackParentCategoriesDirty = new(this, "isEventCallbackParentCategoriesDirty", -1);
					r_isEventCallbackParentCategoriesDirty.SetBelong(this.instance);
				}
				return r_isEventCallbackParentCategoriesDirty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IExperimentalFeatures experimental
		/// </summary>
		protected RUnityEngine.RUIElements.RIExperimentalFeatures r_experimental;
		public virtual RUnityEngine.RUIElements.RIExperimentalFeatures Rexperimental
		{
			get
			{
				if(r_experimental == null)
				{
					r_experimental = new(this, "experimental", -1);
					r_experimental.SetBelong(this.instance);
				}
				return r_experimental;
			}
		}

		/// <summary>
		/// Hierarchy hierarchy
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement.RHierarchy r_hierarchy;
		public virtual RUnityEngine.RUIElements.RVisualElement.RHierarchy Rhierarchy
		{
			get
			{
				if(r_hierarchy == null)
				{
					r_hierarchy = new(this, "hierarchy", -1);
					r_hierarchy.SetBelong(this.instance);
				}
				return r_hierarchy;
			}
		}

		/// <summary>
		/// Boolean isRootVisualContainer
		/// </summary>
		protected RProperty r_isRootVisualContainer;
		public virtual RProperty RisRootVisualContainer
		{
			get
			{
				if(r_isRootVisualContainer == null)
				{
					r_isRootVisualContainer = new(this, "isRootVisualContainer", -1);
					r_isRootVisualContainer.SetBelong(this.instance);
				}
				return r_isRootVisualContainer;
			}
		}

		/// <summary>
		/// Boolean cacheAsBitmap
		/// </summary>
		protected RProperty r_cacheAsBitmap;
		public virtual RProperty RcacheAsBitmap
		{
			get
			{
				if(r_cacheAsBitmap == null)
				{
					r_cacheAsBitmap = new(this, "cacheAsBitmap", -1);
					r_cacheAsBitmap.SetBelong(this.instance);
				}
				return r_cacheAsBitmap;
			}
		}

		/// <summary>
		/// Boolean disableClipping
		/// </summary>
		protected RProperty r_disableClipping;
		public virtual RProperty RdisableClipping
		{
			get
			{
				if(r_disableClipping == null)
				{
					r_disableClipping = new(this, "disableClipping", -1);
					r_disableClipping.SetBelong(this.instance);
				}
				return r_disableClipping;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement parent
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_parent;
		public virtual RUnityEngine.RUIElements.RVisualElement Rparent
		{
			get
			{
				if(r_parent == null)
				{
					r_parent = new(this, "parent", -1);
					r_parent.SetBelong(this.instance);
				}
				return r_parent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BaseVisualElementPanel elementPanel
		/// </summary>
		protected RUnityEngine.RUIElements.RBaseVisualElementPanel r_elementPanel;
		public virtual RUnityEngine.RUIElements.RBaseVisualElementPanel RelementPanel
		{
			get
			{
				if(r_elementPanel == null)
				{
					r_elementPanel = new(this, "elementPanel", -1);
					r_elementPanel.SetBelong(this.instance);
				}
				return r_elementPanel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IPanel panel
		/// </summary>
		protected RUnityEngine.RUIElements.RIPanel r_panel;
		public virtual RUnityEngine.RUIElements.RIPanel Rpanel
		{
			get
			{
				if(r_panel == null)
				{
					r_panel = new(this, "panel", -1);
					r_panel.SetBelong(this.instance);
				}
				return r_panel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement contentContainer
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_contentContainer;
		public virtual RUnityEngine.RUIElements.RVisualElement RcontentContainer
		{
			get
			{
				if(r_contentContainer == null)
				{
					r_contentContainer = new(this, "contentContainer", -1);
					r_contentContainer.SetBelong(this.instance);
				}
				return r_contentContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset visualTreeAssetSource
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualTreeAsset r_visualTreeAssetSource;
		public virtual RUnityEngine.RUIElements.RVisualTreeAsset RvisualTreeAssetSource
		{
			get
			{
				if(r_visualTreeAssetSource == null)
				{
					r_visualTreeAssetSource = new(this, "visualTreeAssetSource", -1);
					r_visualTreeAssetSource.SetBelong(this.instance);
				}
				return r_visualTreeAssetSource;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement Item [Int32]
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_Item_Int32;
		public virtual RUnityEngine.RUIElements.RVisualElement RItem_Int32
		{
			get
			{
				if(r_Item_Int32 == null)
				{
					r_Item_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_Item_Int32.SetBelong(this.instance);
				}
				return r_Item_Int32;
			}
		}

		/// <summary>
		/// Int32 childCount
		/// </summary>
		protected RProperty r_childCount;
		public virtual RProperty RchildCount
		{
			get
			{
				if(r_childCount == null)
				{
					r_childCount = new(this, "childCount", -1);
					r_childCount.SetBelong(this.instance);
				}
				return r_childCount;
			}
		}

		/// <summary>
		/// Boolean hasDefaultRotationAndScale
		/// </summary>
		protected RProperty r_hasDefaultRotationAndScale;
		public virtual RProperty RhasDefaultRotationAndScale
		{
			get
			{
				if(r_hasDefaultRotationAndScale == null)
				{
					r_hasDefaultRotationAndScale = new(this, "hasDefaultRotationAndScale", -1);
					r_hasDefaultRotationAndScale.SetBelong(this.instance);
				}
				return r_hasDefaultRotationAndScale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduler schedule
		/// </summary>
		protected RUnityEngine.RUIElements.RIVisualElementScheduler r_schedule;
		public virtual RUnityEngine.RUIElements.RIVisualElementScheduler Rschedule
		{
			get
			{
				if(r_schedule == null)
				{
					r_schedule = new(this, "schedule", -1);
					r_schedule.SetBelong(this.instance);
				}
				return r_schedule;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IStyle style
		/// </summary>
		protected RUnityEngine.RUIElements.RIStyle r_style;
		public virtual RUnityEngine.RUIElements.RIStyle Rstyle
		{
			get
			{
				if(r_style == null)
				{
					r_style = new(this, "style", -1);
					r_style.SetBelong(this.instance);
				}
				return r_style;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ICustomStyle customStyle
		/// </summary>
		protected RUnityEngine.RUIElements.RICustomStyle r_customStyle;
		public virtual RUnityEngine.RUIElements.RICustomStyle RcustomStyle
		{
			get
			{
				if(r_customStyle == null)
				{
					r_customStyle = new(this, "customStyle", -1);
					r_customStyle.SetBelong(this.instance);
				}
				return r_customStyle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementStyleSheetSet styleSheets
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElementStyleSheetSet r_styleSheets;
		public virtual RUnityEngine.RUIElements.RVisualElementStyleSheetSet RstyleSheets
		{
			get
			{
				if(r_styleSheets == null)
				{
					r_styleSheets = new(this, "styleSheets", -1);
					r_styleSheets.SetBelong(this.instance);
				}
				return r_styleSheets;
			}
		}

		/// <summary>
		/// System.String tooltip
		/// </summary>
		protected RProperty r_tooltip;
		public virtual RProperty Rtooltip
		{
			get
			{
				if(r_tooltip == null)
				{
					r_tooltip = new(this, "tooltip", -1);
					r_tooltip.SetBelong(this.instance);
				}
				return r_tooltip;
			}
		}

		/// <summary>
		/// Boolean focusable
		/// </summary>
		protected RProperty r_focusable;
		public virtual RProperty Rfocusable
		{
			get
			{
				if(r_focusable == null)
				{
					r_focusable = new(this, "focusable", -1);
					r_focusable.SetBelong(this.instance);
				}
				return r_focusable;
			}
		}

		/// <summary>
		/// Int32 tabIndex
		/// </summary>
		protected RProperty r_tabIndex;
		public virtual RProperty RtabIndex
		{
			get
			{
				if(r_tabIndex == null)
				{
					r_tabIndex = new(this, "tabIndex", -1);
					r_tabIndex.SetBelong(this.instance);
				}
				return r_tabIndex;
			}
		}

		/// <summary>
		/// Boolean delegatesFocus
		/// </summary>
		protected RProperty r_delegatesFocus;
		public virtual RProperty RdelegatesFocus
		{
			get
			{
				if(r_delegatesFocus == null)
				{
					r_delegatesFocus = new(this, "delegatesFocus", -1);
					r_delegatesFocus.SetBelong(this.instance);
				}
				return r_delegatesFocus;
			}
		}

		/// <summary>
		/// Boolean excludeFromFocusRing
		/// </summary>
		protected RProperty r_excludeFromFocusRing;
		public virtual RProperty RexcludeFromFocusRing
		{
			get
			{
				if(r_excludeFromFocusRing == null)
				{
					r_excludeFromFocusRing = new(this, "excludeFromFocusRing", -1);
					r_excludeFromFocusRing.SetBelong(this.instance);
				}
				return r_excludeFromFocusRing;
			}
		}

		/// <summary>
		/// System.Func`2[TValueType,TValueType] onValidateValue
		/// </summary>
		protected REvent r_onValidateValue;
		public virtual REvent RonValidateValue
		{
			get
			{
				if(r_onValidateValue == null)
				{
					r_onValidateValue = new(this, "onValidateValue");
					r_onValidateValue.SetBelong(this.instance);
				}
				return r_onValidateValue;
			}
		}

		/// <summary>
		/// Void SetHighValueWithoutNotify(TValueType)
		/// </summary>
		protected RMethod r_SetHighValueWithoutNotify_TValueType;
		public virtual RMethod RSetHighValueWithoutNotify_TValueType
		{
			get
			{
				if(r_SetHighValueWithoutNotify_TValueType == null)
				{
					r_SetHighValueWithoutNotify_TValueType = new(this, "SetHighValueWithoutNotify", 0, Type.MakeGenericMethodParameter(0));
					r_SetHighValueWithoutNotify_TValueType.SetBelong(this.instance);
				}
				return r_SetHighValueWithoutNotify_TValueType;
			}
		}

		/// <summary>
		/// TValueType Clamp(TValueType, TValueType, TValueType)
		/// </summary>
		protected RMethod r_Clamp_TValueType_TValueType_TValueType;
		public virtual RMethod RClamp_TValueType_TValueType_TValueType
		{
			get
			{
				if(r_Clamp_TValueType_TValueType_TValueType == null)
				{
					r_Clamp_TValueType_TValueType_TValueType = new(this, "Clamp", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(0));
					r_Clamp_TValueType_TValueType_TValueType.SetBelong(this.instance);
				}
				return r_Clamp_TValueType_TValueType_TValueType;
			}
		}

		/// <summary>
		/// TValueType GetClampedValue(TValueType)
		/// </summary>
		protected RMethod r_GetClampedValue_TValueType;
		public virtual RMethod RGetClampedValue_TValueType
		{
			get
			{
				if(r_GetClampedValue_TValueType == null)
				{
					r_GetClampedValue_TValueType = new(this, "GetClampedValue", 0, Type.MakeGenericMethodParameter(0));
					r_GetClampedValue_TValueType.SetBelong(this.instance);
				}
				return r_GetClampedValue_TValueType;
			}
		}

		/// <summary>
		/// Void ApplyInputDeviceDelta(UnityEngine.Vector3, UnityEngine.UIElements.DeltaSpeed, TValueType)
		/// </summary>
		protected RMethod r_ApplyInputDeviceDelta_Vector3_DeltaSpeed_TValueType;
		public virtual RMethod RApplyInputDeviceDelta_Vector3_DeltaSpeed_TValueType
		{
			get
			{
				if(r_ApplyInputDeviceDelta_Vector3_DeltaSpeed_TValueType == null)
				{
					r_ApplyInputDeviceDelta_Vector3_DeltaSpeed_TValueType = new(this, "ApplyInputDeviceDelta", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.UIElements.DeltaSpeed), Type.MakeGenericMethodParameter(0));
					r_ApplyInputDeviceDelta_Vector3_DeltaSpeed_TValueType.SetBelong(this.instance);
				}
				return r_ApplyInputDeviceDelta_Vector3_DeltaSpeed_TValueType;
			}
		}

		/// <summary>
		/// Void UnityEngine.UIElements.IValueField<TValueType>.StartDragging()
		/// </summary>
		protected RMethod r_UnityEngine__2__UIElements__2__IValueField__0__TValueType__1____2__StartDragging;
		public virtual RMethod RUnityEngine__2__UIElements__2__IValueField__0__TValueType__1____2__StartDragging
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IValueField__0__TValueType__1____2__StartDragging == null)
				{
					r_UnityEngine__2__UIElements__2__IValueField__0__TValueType__1____2__StartDragging = new(this, "UnityEngine.UIElements.IValueField<TValueType>.StartDragging", 0);
					r_UnityEngine__2__UIElements__2__IValueField__0__TValueType__1____2__StartDragging.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IValueField__0__TValueType__1____2__StartDragging;
			}
		}

		/// <summary>
		/// Void UnityEngine.UIElements.IValueField<TValueType>.StopDragging()
		/// </summary>
		protected RMethod r_UnityEngine__2__UIElements__2__IValueField__0__TValueType__1____2__StopDragging;
		public virtual RMethod RUnityEngine__2__UIElements__2__IValueField__0__TValueType__1____2__StopDragging
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IValueField__0__TValueType__1____2__StopDragging == null)
				{
					r_UnityEngine__2__UIElements__2__IValueField__0__TValueType__1____2__StopDragging = new(this, "UnityEngine.UIElements.IValueField<TValueType>.StopDragging", 0);
					r_UnityEngine__2__UIElements__2__IValueField__0__TValueType__1____2__StopDragging.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IValueField__0__TValueType__1____2__StopDragging;
			}
		}

		/// <summary>
		/// Void SetValueWithoutNotify(TValueType)
		/// </summary>
		protected RMethod r_SetValueWithoutNotify_TValueType;
		public virtual RMethod RSetValueWithoutNotify_TValueType
		{
			get
			{
				if(r_SetValueWithoutNotify_TValueType == null)
				{
					r_SetValueWithoutNotify_TValueType = new(this, "SetValueWithoutNotify", 0, Type.MakeGenericMethodParameter(0));
					r_SetValueWithoutNotify_TValueType.SetBelong(this.instance);
				}
				return r_SetValueWithoutNotify_TValueType;
			}
		}

		/// <summary>
		/// Single GetClosestPowerOfTen(Single)
		/// </summary>
		protected static RMethod r_GetClosestPowerOfTen_Single;
		public static RMethod RGetClosestPowerOfTen_Single
		{
			get
			{
				if(r_GetClosestPowerOfTen_Single == null)
				{
					r_GetClosestPowerOfTen_Single = new(typeof(UnityEngine.UIElements.BaseSlider<>), "GetClosestPowerOfTen", 0, typeof(System.Single));
					r_GetClosestPowerOfTen_Single.SetBelong(null);
				}
				return r_GetClosestPowerOfTen_Single;
			}
		}

		/// <summary>
		/// Single RoundToMultipleOf(Single, Single)
		/// </summary>
		protected static RMethod r_RoundToMultipleOf_Single_Single;
		public static RMethod RRoundToMultipleOf_Single_Single
		{
			get
			{
				if(r_RoundToMultipleOf_Single_Single == null)
				{
					r_RoundToMultipleOf_Single_Single = new(typeof(UnityEngine.UIElements.BaseSlider<>), "RoundToMultipleOf", 0, typeof(System.Single), typeof(System.Single));
					r_RoundToMultipleOf_Single_Single.SetBelong(null);
				}
				return r_RoundToMultipleOf_Single_Single;
			}
		}

		/// <summary>
		/// Void ClampValue()
		/// </summary>
		protected RMethod r_ClampValue;
		public virtual RMethod RClampValue
		{
			get
			{
				if(r_ClampValue == null)
				{
					r_ClampValue = new(this, "ClampValue", 0);
					r_ClampValue.SetBelong(this.instance);
				}
				return r_ClampValue;
			}
		}

		/// <summary>
		/// TValueType SliderLerpUnclamped(TValueType, TValueType, Single)
		/// </summary>
		protected RMethod r_SliderLerpUnclamped_TValueType_TValueType_Single;
		public virtual RMethod RSliderLerpUnclamped_TValueType_TValueType_Single
		{
			get
			{
				if(r_SliderLerpUnclamped_TValueType_TValueType_Single == null)
				{
					r_SliderLerpUnclamped_TValueType_TValueType_Single = new(this, "SliderLerpUnclamped", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(0), typeof(System.Single));
					r_SliderLerpUnclamped_TValueType_TValueType_Single.SetBelong(this.instance);
				}
				return r_SliderLerpUnclamped_TValueType_TValueType_Single;
			}
		}

		/// <summary>
		/// Single SliderNormalizeValue(TValueType, TValueType, TValueType)
		/// </summary>
		protected RMethod r_SliderNormalizeValue_TValueType_TValueType_TValueType;
		public virtual RMethod RSliderNormalizeValue_TValueType_TValueType_TValueType
		{
			get
			{
				if(r_SliderNormalizeValue_TValueType_TValueType_TValueType == null)
				{
					r_SliderNormalizeValue_TValueType_TValueType_TValueType = new(this, "SliderNormalizeValue", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(0));
					r_SliderNormalizeValue_TValueType_TValueType_TValueType.SetBelong(this.instance);
				}
				return r_SliderNormalizeValue_TValueType_TValueType_TValueType;
			}
		}

		/// <summary>
		/// TValueType SliderRange()
		/// </summary>
		protected RMethod r_SliderRange;
		public virtual RMethod RSliderRange
		{
			get
			{
				if(r_SliderRange == null)
				{
					r_SliderRange = new(this, "SliderRange", 0);
					r_SliderRange.SetBelong(this.instance);
				}
				return r_SliderRange;
			}
		}

		/// <summary>
		/// TValueType ParseStringToValue(System.String)
		/// </summary>
		protected RMethod r_ParseStringToValue_String;
		public virtual RMethod RParseStringToValue_String
		{
			get
			{
				if(r_ParseStringToValue_String == null)
				{
					r_ParseStringToValue_String = new(this, "ParseStringToValue", 0, typeof(System.String));
					r_ParseStringToValue_String.SetBelong(this.instance);
				}
				return r_ParseStringToValue_String;
			}
		}

		/// <summary>
		/// Void ComputeValueFromKey(SliderKey, Boolean)
		/// </summary>
		protected RMethod r_ComputeValueFromKey_SliderKey_Boolean;
		public virtual RMethod RComputeValueFromKey_SliderKey_Boolean
		{
			get
			{
				if(r_ComputeValueFromKey_SliderKey_Boolean == null)
				{
					r_ComputeValueFromKey_SliderKey_Boolean = new(this, "ComputeValueFromKey", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.BaseSlider`1+SliderKey").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Boolean));
					r_ComputeValueFromKey_SliderKey_Boolean.SetBelong(this.instance);
				}
				return r_ComputeValueFromKey_SliderKey_Boolean;
			}
		}

		/// <summary>
		/// TValueType SliderLerpDirectionalUnclamped(TValueType, TValueType, Single)
		/// </summary>
		protected RMethod r_SliderLerpDirectionalUnclamped_TValueType_TValueType_Single;
		public virtual RMethod RSliderLerpDirectionalUnclamped_TValueType_TValueType_Single
		{
			get
			{
				if(r_SliderLerpDirectionalUnclamped_TValueType_TValueType_Single == null)
				{
					r_SliderLerpDirectionalUnclamped_TValueType_TValueType_Single = new(this, "SliderLerpDirectionalUnclamped", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(0), typeof(System.Single));
					r_SliderLerpDirectionalUnclamped_TValueType_TValueType_Single.SetBelong(this.instance);
				}
				return r_SliderLerpDirectionalUnclamped_TValueType_TValueType_Single;
			}
		}

		/// <summary>
		/// Void SetSliderValueFromDrag()
		/// </summary>
		protected RMethod r_SetSliderValueFromDrag;
		public virtual RMethod RSetSliderValueFromDrag
		{
			get
			{
				if(r_SetSliderValueFromDrag == null)
				{
					r_SetSliderValueFromDrag = new(this, "SetSliderValueFromDrag", 0);
					r_SetSliderValueFromDrag.SetBelong(this.instance);
				}
				return r_SetSliderValueFromDrag;
			}
		}

		/// <summary>
		/// Void ComputeValueAndDirectionFromDrag(Single, Single, Single)
		/// </summary>
		protected RMethod r_ComputeValueAndDirectionFromDrag_Single_Single_Single;
		public virtual RMethod RComputeValueAndDirectionFromDrag_Single_Single_Single
		{
			get
			{
				if(r_ComputeValueAndDirectionFromDrag_Single_Single_Single == null)
				{
					r_ComputeValueAndDirectionFromDrag_Single_Single_Single = new(this, "ComputeValueAndDirectionFromDrag", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_ComputeValueAndDirectionFromDrag_Single_Single_Single.SetBelong(this.instance);
				}
				return r_ComputeValueAndDirectionFromDrag_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void SetSliderValueFromClick()
		/// </summary>
		protected RMethod r_SetSliderValueFromClick;
		public virtual RMethod RSetSliderValueFromClick
		{
			get
			{
				if(r_SetSliderValueFromClick == null)
				{
					r_SetSliderValueFromClick = new(this, "SetSliderValueFromClick", 0);
					r_SetSliderValueFromClick.SetBelong(this.instance);
				}
				return r_SetSliderValueFromClick;
			}
		}

		/// <summary>
		/// Void OnKeyDown(UnityEngine.UIElements.KeyDownEvent)
		/// </summary>
		protected RMethod r_OnKeyDown_KeyDownEvent;
		public virtual RMethod ROnKeyDown_KeyDownEvent
		{
			get
			{
				if(r_OnKeyDown_KeyDownEvent == null)
				{
					r_OnKeyDown_KeyDownEvent = new(this, "OnKeyDown", 0, typeof(UnityEngine.UIElements.KeyDownEvent));
					r_OnKeyDown_KeyDownEvent.SetBelong(this.instance);
				}
				return r_OnKeyDown_KeyDownEvent;
			}
		}

		/// <summary>
		/// Void OnNavigationMove(UnityEngine.UIElements.NavigationMoveEvent)
		/// </summary>
		protected RMethod r_OnNavigationMove_NavigationMoveEvent;
		public virtual RMethod ROnNavigationMove_NavigationMoveEvent
		{
			get
			{
				if(r_OnNavigationMove_NavigationMoveEvent == null)
				{
					r_OnNavigationMove_NavigationMoveEvent = new(this, "OnNavigationMove", 0, typeof(UnityEngine.UIElements.NavigationMoveEvent));
					r_OnNavigationMove_NavigationMoveEvent.SetBelong(this.instance);
				}
				return r_OnNavigationMove_NavigationMoveEvent;
			}
		}

		/// <summary>
		/// Void ComputeValueAndDirectionFromClick(Single, Single, Single, Single)
		/// </summary>
		protected RMethod r_ComputeValueAndDirectionFromClick_Single_Single_Single_Single;
		public virtual RMethod RComputeValueAndDirectionFromClick_Single_Single_Single_Single
		{
			get
			{
				if(r_ComputeValueAndDirectionFromClick_Single_Single_Single_Single == null)
				{
					r_ComputeValueAndDirectionFromClick_Single_Single_Single_Single = new(this, "ComputeValueAndDirectionFromClick", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_ComputeValueAndDirectionFromClick_Single_Single_Single_Single.SetBelong(this.instance);
				}
				return r_ComputeValueAndDirectionFromClick_Single_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void AdjustDragElement(Single)
		/// </summary>
		protected RMethod r_AdjustDragElement_Single;
		public virtual RMethod RAdjustDragElement_Single
		{
			get
			{
				if(r_AdjustDragElement_Single == null)
				{
					r_AdjustDragElement_Single = new(this, "AdjustDragElement", 0, typeof(System.Single));
					r_AdjustDragElement_Single.SetBelong(this.instance);
				}
				return r_AdjustDragElement_Single;
			}
		}

		/// <summary>
		/// Void UpdateDragElementPosition(UnityEngine.UIElements.GeometryChangedEvent)
		/// </summary>
		protected RMethod r_UpdateDragElementPosition_GeometryChangedEvent;
		public virtual RMethod RUpdateDragElementPosition_GeometryChangedEvent
		{
			get
			{
				if(r_UpdateDragElementPosition_GeometryChangedEvent == null)
				{
					r_UpdateDragElementPosition_GeometryChangedEvent = new(this, "UpdateDragElementPosition", 0, typeof(UnityEngine.UIElements.GeometryChangedEvent));
					r_UpdateDragElementPosition_GeometryChangedEvent.SetBelong(this.instance);
				}
				return r_UpdateDragElementPosition_GeometryChangedEvent;
			}
		}

		/// <summary>
		/// Void OnViewDataReady()
		/// </summary>
		protected RMethod r_OnViewDataReady;
		public virtual RMethod ROnViewDataReady
		{
			get
			{
				if(r_OnViewDataReady == null)
				{
					r_OnViewDataReady = new(this, "OnViewDataReady", 0);
					r_OnViewDataReady.SetBelong(this.instance);
				}
				return r_OnViewDataReady;
			}
		}

		/// <summary>
		/// Boolean SameValues(Single, Single, Single)
		/// </summary>
		protected RMethod r_SameValues_Single_Single_Single;
		public virtual RMethod RSameValues_Single_Single_Single
		{
			get
			{
				if(r_SameValues_Single_Single_Single == null)
				{
					r_SameValues_Single_Single_Single = new(this, "SameValues", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_SameValues_Single_Single_Single.SetBelong(this.instance);
				}
				return r_SameValues_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void UpdateDragElementPosition()
		/// </summary>
		protected RMethod r_UpdateDragElementPosition;
		public virtual RMethod RUpdateDragElementPosition
		{
			get
			{
				if(r_UpdateDragElementPosition == null)
				{
					r_UpdateDragElementPosition = new(this, "UpdateDragElementPosition", 0);
					r_UpdateDragElementPosition.SetBelong(this.instance);
				}
				return r_UpdateDragElementPosition;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_ExecuteDefaultAction_EventBase;
		public virtual RMethod RExecuteDefaultAction_EventBase
		{
			get
			{
				if(r_ExecuteDefaultAction_EventBase == null)
				{
					r_ExecuteDefaultAction_EventBase = new(this, "ExecuteDefaultAction", 0, typeof(UnityEngine.UIElements.EventBase));
					r_ExecuteDefaultAction_EventBase.SetBelong(this.instance);
				}
				return r_ExecuteDefaultAction_EventBase;
			}
		}

		/// <summary>
		/// Void UpdateTextFieldVisibility()
		/// </summary>
		protected RMethod r_UpdateTextFieldVisibility;
		public virtual RMethod RUpdateTextFieldVisibility
		{
			get
			{
				if(r_UpdateTextFieldVisibility == null)
				{
					r_UpdateTextFieldVisibility = new(this, "UpdateTextFieldVisibility", 0);
					r_UpdateTextFieldVisibility.SetBelong(this.instance);
				}
				return r_UpdateTextFieldVisibility;
			}
		}

		/// <summary>
		/// Void UpdateTextFieldValue()
		/// </summary>
		protected RMethod r_UpdateTextFieldValue;
		public virtual RMethod RUpdateTextFieldValue
		{
			get
			{
				if(r_UpdateTextFieldValue == null)
				{
					r_UpdateTextFieldValue = new(this, "UpdateTextFieldValue", 0);
					r_UpdateTextFieldValue.SetBelong(this.instance);
				}
				return r_UpdateTextFieldValue;
			}
		}

		/// <summary>
		/// Void OnTextFieldFocusOut(UnityEngine.UIElements.FocusOutEvent)
		/// </summary>
		protected RMethod r_OnTextFieldFocusOut_FocusOutEvent;
		public virtual RMethod ROnTextFieldFocusOut_FocusOutEvent
		{
			get
			{
				if(r_OnTextFieldFocusOut_FocusOutEvent == null)
				{
					r_OnTextFieldFocusOut_FocusOutEvent = new(this, "OnTextFieldFocusOut", 0, typeof(UnityEngine.UIElements.FocusOutEvent));
					r_OnTextFieldFocusOut_FocusOutEvent.SetBelong(this.instance);
				}
				return r_OnTextFieldFocusOut_FocusOutEvent;
			}
		}

		/// <summary>
		/// Void OnInputNavigationMoveEvent(UnityEngine.UIElements.NavigationMoveEvent)
		/// </summary>
		protected RMethod r_OnInputNavigationMoveEvent_NavigationMoveEvent;
		public virtual RMethod ROnInputNavigationMoveEvent_NavigationMoveEvent
		{
			get
			{
				if(r_OnInputNavigationMoveEvent_NavigationMoveEvent == null)
				{
					r_OnInputNavigationMoveEvent_NavigationMoveEvent = new(this, "OnInputNavigationMoveEvent", 0, typeof(UnityEngine.UIElements.NavigationMoveEvent));
					r_OnInputNavigationMoveEvent_NavigationMoveEvent.SetBelong(this.instance);
				}
				return r_OnInputNavigationMoveEvent_NavigationMoveEvent;
			}
		}

		/// <summary>
		/// Void OnTextFieldValueChange(UnityEngine.UIElements.ChangeEvent`1[System.String])
		/// </summary>
		protected RMethod r_OnTextFieldValueChange_ChangeEvent_d_String_p_;
		public virtual RMethod ROnTextFieldValueChange_ChangeEvent_d_String_p_
		{
			get
			{
				if(r_OnTextFieldValueChange_ChangeEvent_d_String_p_ == null)
				{
					r_OnTextFieldValueChange_ChangeEvent_d_String_p_ = new(this, "OnTextFieldValueChange", 0, typeof(UnityEngine.UIElements.ChangeEvent<>).MakeGenericType(typeof(System.String)));
					r_OnTextFieldValueChange_ChangeEvent_d_String_p_.SetBelong(this.instance);
				}
				return r_OnTextFieldValueChange_ChangeEvent_d_String_p_;
			}
		}

		/// <summary>
		/// Void UpdateMixedValueContent()
		/// </summary>
		protected RMethod r_UpdateMixedValueContent;
		public virtual RMethod RUpdateMixedValueContent
		{
			get
			{
				if(r_UpdateMixedValueContent == null)
				{
					r_UpdateMixedValueContent = new(this, "UpdateMixedValueContent", 0);
					r_UpdateMixedValueContent.SetBelong(this.instance);
				}
				return r_UpdateMixedValueContent;
			}
		}

		/// <summary>
		/// TValueType ValidatedValue(TValueType)
		/// </summary>
		protected RMethod r_ValidatedValue_TValueType;
		public virtual RMethod RValidatedValue_TValueType
		{
			get
			{
				if(r_ValidatedValue_TValueType == null)
				{
					r_ValidatedValue_TValueType = new(this, "ValidatedValue", 0, Type.MakeGenericMethodParameter(0));
					r_ValidatedValue_TValueType.SetBelong(this.instance);
				}
				return r_ValidatedValue_TValueType;
			}
		}

		/// <summary>
		/// Void SetValueWithoutValidation(TValueType)
		/// </summary>
		protected RMethod r_SetValueWithoutValidation_TValueType;
		public virtual RMethod RSetValueWithoutValidation_TValueType
		{
			get
			{
				if(r_SetValueWithoutValidation_TValueType == null)
				{
					r_SetValueWithoutValidation_TValueType = new(this, "SetValueWithoutValidation", 0, Type.MakeGenericMethodParameter(0));
					r_SetValueWithoutValidation_TValueType.SetBelong(this.instance);
				}
				return r_SetValueWithoutValidation_TValueType;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetTooltipRect()
		/// </summary>
		protected RMethod r_GetTooltipRect;
		public virtual RMethod RGetTooltipRect
		{
			get
			{
				if(r_GetTooltipRect == null)
				{
					r_GetTooltipRect = new(this, "GetTooltipRect", 0);
					r_GetTooltipRect.SetBelong(this.instance);
				}
				return r_GetTooltipRect;
			}
		}

		/// <summary>
		/// Boolean TryConvertLengthUnits(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Length ByRef, UnityEngine.UIElements.Length ByRef, Int32)
		/// </summary>
		protected RMethod r_TryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32;
		public virtual RMethod RTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32
		{
			get
			{
				if(r_TryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32 == null)
				{
					r_TryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32 = new(this, "TryConvertLengthUnits", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Length).MakeByRefType(), typeof(UnityEngine.UIElements.Length).MakeByRefType(), typeof(System.Int32));
					r_TryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32.SetBelong(this.instance);
				}
				return r_TryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32;
			}
		}

		/// <summary>
		/// Boolean TryConvertTransformOriginUnits(UnityEngine.UIElements.TransformOrigin ByRef, UnityEngine.UIElements.TransformOrigin ByRef)
		/// </summary>
		protected RMethod r_TryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin;
		public virtual RMethod RTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin
		{
			get
			{
				if(r_TryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin == null)
				{
					r_TryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin = new(this, "TryConvertTransformOriginUnits", 0, typeof(UnityEngine.UIElements.TransformOrigin).MakeByRefType(), typeof(UnityEngine.UIElements.TransformOrigin).MakeByRefType());
					r_TryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin.SetBelong(this.instance);
				}
				return r_TryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin;
			}
		}

		/// <summary>
		/// Boolean TryConvertTranslateUnits(UnityEngine.UIElements.Translate ByRef, UnityEngine.UIElements.Translate ByRef)
		/// </summary>
		protected RMethod r_TryConvertTranslateUnits_Ref_Translate_Ref_Translate;
		public virtual RMethod RTryConvertTranslateUnits_Ref_Translate_Ref_Translate
		{
			get
			{
				if(r_TryConvertTranslateUnits_Ref_Translate_Ref_Translate == null)
				{
					r_TryConvertTranslateUnits_Ref_Translate_Ref_Translate = new(this, "TryConvertTranslateUnits", 0, typeof(UnityEngine.UIElements.Translate).MakeByRefType(), typeof(UnityEngine.UIElements.Translate).MakeByRefType());
					r_TryConvertTranslateUnits_Ref_Translate_Ref_Translate.SetBelong(this.instance);
				}
				return r_TryConvertTranslateUnits_Ref_Translate_Ref_Translate;
			}
		}

		/// <summary>
		/// Boolean TryConvertBackgroundPositionUnits(UnityEngine.UIElements.BackgroundPosition ByRef, UnityEngine.UIElements.BackgroundPosition ByRef)
		/// </summary>
		protected RMethod r_TryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition;
		public virtual RMethod RTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition
		{
			get
			{
				if(r_TryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition == null)
				{
					r_TryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition = new(this, "TryConvertBackgroundPositionUnits", 0, typeof(UnityEngine.UIElements.BackgroundPosition).MakeByRefType(), typeof(UnityEngine.UIElements.BackgroundPosition).MakeByRefType());
					r_TryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition.SetBelong(this.instance);
				}
				return r_TryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition;
			}
		}

		/// <summary>
		/// Boolean TryConvertBackgroundSizeUnits(UnityEngine.UIElements.BackgroundSize ByRef, UnityEngine.UIElements.BackgroundSize ByRef)
		/// </summary>
		protected RMethod r_TryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize;
		public virtual RMethod RTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize
		{
			get
			{
				if(r_TryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize == null)
				{
					r_TryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize = new(this, "TryConvertBackgroundSizeUnits", 0, typeof(UnityEngine.UIElements.BackgroundSize).MakeByRefType(), typeof(UnityEngine.UIElements.BackgroundSize).MakeByRefType());
					r_TryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize.SetBelong(this.instance);
				}
				return r_TryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize;
			}
		}

		/// <summary>
		/// Void MarkRenderHintsClean()
		/// </summary>
		protected RMethod r_MarkRenderHintsClean;
		public virtual RMethod RMarkRenderHintsClean
		{
			get
			{
				if(r_MarkRenderHintsClean == null)
				{
					r_MarkRenderHintsClean = new(this, "MarkRenderHintsClean", 0);
					r_MarkRenderHintsClean.SetBelong(this.instance);
				}
				return r_MarkRenderHintsClean;
			}
		}

		/// <summary>
		/// Void UpdateBoundingBox()
		/// </summary>
		protected RMethod r_UpdateBoundingBox;
		public virtual RMethod RUpdateBoundingBox
		{
			get
			{
				if(r_UpdateBoundingBox == null)
				{
					r_UpdateBoundingBox = new(this, "UpdateBoundingBox", 0);
					r_UpdateBoundingBox.SetBelong(this.instance);
				}
				return r_UpdateBoundingBox;
			}
		}

		/// <summary>
		/// Void UpdateWorldBoundingBox()
		/// </summary>
		protected RMethod r_UpdateWorldBoundingBox;
		public virtual RMethod RUpdateWorldBoundingBox
		{
			get
			{
				if(r_UpdateWorldBoundingBox == null)
				{
					r_UpdateWorldBoundingBox = new(this, "UpdateWorldBoundingBox", 0);
					r_UpdateWorldBoundingBox.SetBelong(this.instance);
				}
				return r_UpdateWorldBoundingBox;
			}
		}

		/// <summary>
		/// Void UpdateWorldTransform()
		/// </summary>
		protected RMethod r_UpdateWorldTransform;
		public virtual RMethod RUpdateWorldTransform
		{
			get
			{
				if(r_UpdateWorldTransform == null)
				{
					r_UpdateWorldTransform = new(this, "UpdateWorldTransform", 0);
					r_UpdateWorldTransform.SetBelong(this.instance);
				}
				return r_UpdateWorldTransform;
			}
		}

		/// <summary>
		/// Void UpdateWorldTransformInverse()
		/// </summary>
		protected RMethod r_UpdateWorldTransformInverse;
		public virtual RMethod RUpdateWorldTransformInverse
		{
			get
			{
				if(r_UpdateWorldTransformInverse == null)
				{
					r_UpdateWorldTransformInverse = new(this, "UpdateWorldTransformInverse", 0);
					r_UpdateWorldTransformInverse.SetBelong(this.instance);
				}
				return r_UpdateWorldTransformInverse;
			}
		}

		/// <summary>
		/// Void EnsureWorldTransformAndClipUpToDate()
		/// </summary>
		protected RMethod r_EnsureWorldTransformAndClipUpToDate;
		public virtual RMethod REnsureWorldTransformAndClipUpToDate
		{
			get
			{
				if(r_EnsureWorldTransformAndClipUpToDate == null)
				{
					r_EnsureWorldTransformAndClipUpToDate = new(this, "EnsureWorldTransformAndClipUpToDate", 0);
					r_EnsureWorldTransformAndClipUpToDate.SetBelong(this.instance);
				}
				return r_EnsureWorldTransformAndClipUpToDate;
			}
		}

		/// <summary>
		/// Void Focus()
		/// </summary>
		protected RMethod r_Focus;
		public virtual RMethod RFocus
		{
			get
			{
				if(r_Focus == null)
				{
					r_Focus = new(this, "Focus", 0);
					r_Focus.SetBelong(this.instance);
				}
				return r_Focus;
			}
		}

		/// <summary>
		/// Void SetPanel(UnityEngine.UIElements.BaseVisualElementPanel)
		/// </summary>
		protected RMethod r_SetPanel_BaseVisualElementPanel;
		public virtual RMethod RSetPanel_BaseVisualElementPanel
		{
			get
			{
				if(r_SetPanel_BaseVisualElementPanel == null)
				{
					r_SetPanel_BaseVisualElementPanel = new(this, "SetPanel", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.BaseVisualElementPanel"));
					r_SetPanel_BaseVisualElementPanel.SetBelong(this.instance);
				}
				return r_SetPanel_BaseVisualElementPanel;
			}
		}

		/// <summary>
		/// Void SendEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_SendEvent_EventBase;
		public virtual RMethod RSendEvent_EventBase
		{
			get
			{
				if(r_SendEvent_EventBase == null)
				{
					r_SendEvent_EventBase = new(this, "SendEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_SendEvent_EventBase.SetBelong(this.instance);
				}
				return r_SendEvent_EventBase;
			}
		}

		/// <summary>
		/// Void SendEvent(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.DispatchMode)
		/// </summary>
		protected RMethod r_SendEvent_EventBase_DispatchMode;
		public virtual RMethod RSendEvent_EventBase_DispatchMode
		{
			get
			{
				if(r_SendEvent_EventBase_DispatchMode == null)
				{
					r_SendEvent_EventBase_DispatchMode = new(this, "SendEvent", 0, typeof(UnityEngine.UIElements.EventBase),  ReflectionUtils.GetType("UnityEngine.UIElements.DispatchMode"));
					r_SendEvent_EventBase_DispatchMode.SetBelong(this.instance);
				}
				return r_SendEvent_EventBase_DispatchMode;
			}
		}

		/// <summary>
		/// Void IncrementVersion(UnityEngine.UIElements.VersionChangeType)
		/// </summary>
		protected RMethod r_IncrementVersion_VersionChangeType;
		public virtual RMethod RIncrementVersion_VersionChangeType
		{
			get
			{
				if(r_IncrementVersion_VersionChangeType == null)
				{
					r_IncrementVersion_VersionChangeType = new(this, "IncrementVersion", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VersionChangeType"));
					r_IncrementVersion_VersionChangeType.SetBelong(this.instance);
				}
				return r_IncrementVersion_VersionChangeType;
			}
		}

		/// <summary>
		/// Void InvokeHierarchyChanged(UnityEngine.UIElements.HierarchyChangeType)
		/// </summary>
		protected RMethod r_InvokeHierarchyChanged_HierarchyChangeType;
		public virtual RMethod RInvokeHierarchyChanged_HierarchyChangeType
		{
			get
			{
				if(r_InvokeHierarchyChanged_HierarchyChangeType == null)
				{
					r_InvokeHierarchyChanged_HierarchyChangeType = new(this, "InvokeHierarchyChanged", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.HierarchyChangeType"));
					r_InvokeHierarchyChanged_HierarchyChangeType.SetBelong(this.instance);
				}
				return r_InvokeHierarchyChanged_HierarchyChangeType;
			}
		}

		/// <summary>
		/// Boolean SetEnabledFromHierarchy(Boolean)
		/// </summary>
		protected RMethod r_SetEnabledFromHierarchy_Boolean;
		public virtual RMethod RSetEnabledFromHierarchy_Boolean
		{
			get
			{
				if(r_SetEnabledFromHierarchy_Boolean == null)
				{
					r_SetEnabledFromHierarchy_Boolean = new(this, "SetEnabledFromHierarchy", 0, typeof(System.Boolean));
					r_SetEnabledFromHierarchy_Boolean.SetBelong(this.instance);
				}
				return r_SetEnabledFromHierarchy_Boolean;
			}
		}

		/// <summary>
		/// Void SetEnabled(Boolean)
		/// </summary>
		protected RMethod r_SetEnabled_Boolean;
		public virtual RMethod RSetEnabled_Boolean
		{
			get
			{
				if(r_SetEnabled_Boolean == null)
				{
					r_SetEnabled_Boolean = new(this, "SetEnabled", 0, typeof(System.Boolean));
					r_SetEnabled_Boolean.SetBelong(this.instance);
				}
				return r_SetEnabled_Boolean;
			}
		}

		/// <summary>
		/// Void MarkDirtyRepaint()
		/// </summary>
		protected RMethod r_MarkDirtyRepaint;
		public virtual RMethod RMarkDirtyRepaint
		{
			get
			{
				if(r_MarkDirtyRepaint == null)
				{
					r_MarkDirtyRepaint = new(this, "MarkDirtyRepaint", 0);
					r_MarkDirtyRepaint.SetBelong(this.instance);
				}
				return r_MarkDirtyRepaint;
			}
		}

		/// <summary>
		/// Void InvokeGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext)
		/// </summary>
		protected RMethod r_InvokeGenerateVisualContent_MeshGenerationContext;
		public virtual RMethod RInvokeGenerateVisualContent_MeshGenerationContext
		{
			get
			{
				if(r_InvokeGenerateVisualContent_MeshGenerationContext == null)
				{
					r_InvokeGenerateVisualContent_MeshGenerationContext = new(this, "InvokeGenerateVisualContent", 0, typeof(UnityEngine.UIElements.MeshGenerationContext));
					r_InvokeGenerateVisualContent_MeshGenerationContext.SetBelong(this.instance);
				}
				return r_InvokeGenerateVisualContent_MeshGenerationContext;
			}
		}

		/// <summary>
		/// Void GetFullHierarchicalViewDataKey(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_GetFullHierarchicalViewDataKey_StringBuilder;
		public virtual RMethod RGetFullHierarchicalViewDataKey_StringBuilder
		{
			get
			{
				if(r_GetFullHierarchicalViewDataKey_StringBuilder == null)
				{
					r_GetFullHierarchicalViewDataKey_StringBuilder = new(this, "GetFullHierarchicalViewDataKey", 0, typeof(System.Text.StringBuilder));
					r_GetFullHierarchicalViewDataKey_StringBuilder.SetBelong(this.instance);
				}
				return r_GetFullHierarchicalViewDataKey_StringBuilder;
			}
		}

		/// <summary>
		/// System.String GetFullHierarchicalViewDataKey()
		/// </summary>
		protected RMethod r_GetFullHierarchicalViewDataKey;
		public virtual RMethod RGetFullHierarchicalViewDataKey
		{
			get
			{
				if(r_GetFullHierarchicalViewDataKey == null)
				{
					r_GetFullHierarchicalViewDataKey = new(this, "GetFullHierarchicalViewDataKey", 0);
					r_GetFullHierarchicalViewDataKey.SetBelong(this.instance);
				}
				return r_GetFullHierarchicalViewDataKey;
			}
		}

		/// <summary>
		/// T GetOrCreateViewData[T](System.Object, System.String)
		/// </summary>
		protected RMethod r_GetOrCreateViewData_GT_Object_String;
		public virtual RMethod RGetOrCreateViewData_GT_Object_String
		{
			get
			{
				if(r_GetOrCreateViewData_GT_Object_String == null)
				{
					r_GetOrCreateViewData_GT_Object_String = new(this, "GetOrCreateViewData", 1, typeof(System.Object), typeof(System.String));
					r_GetOrCreateViewData_GT_Object_String.SetBelong(this.instance);
				}
				return r_GetOrCreateViewData_GT_Object_String;
			}
		}

		/// <summary>
		/// T GetOrCreateViewData[T](UnityEngine.ScriptableObject, System.String)
		/// </summary>
		protected RMethod r_GetOrCreateViewData_GT_ScriptableObject_String;
		public virtual RMethod RGetOrCreateViewData_GT_ScriptableObject_String
		{
			get
			{
				if(r_GetOrCreateViewData_GT_ScriptableObject_String == null)
				{
					r_GetOrCreateViewData_GT_ScriptableObject_String = new(this, "GetOrCreateViewData", 1, typeof(UnityEngine.ScriptableObject), typeof(System.String));
					r_GetOrCreateViewData_GT_ScriptableObject_String.SetBelong(this.instance);
				}
				return r_GetOrCreateViewData_GT_ScriptableObject_String;
			}
		}

		/// <summary>
		/// Void OverwriteFromViewData(System.Object, System.String)
		/// </summary>
		protected RMethod r_OverwriteFromViewData_Object_String;
		public virtual RMethod ROverwriteFromViewData_Object_String
		{
			get
			{
				if(r_OverwriteFromViewData_Object_String == null)
				{
					r_OverwriteFromViewData_Object_String = new(this, "OverwriteFromViewData", 0, typeof(System.Object), typeof(System.String));
					r_OverwriteFromViewData_Object_String.SetBelong(this.instance);
				}
				return r_OverwriteFromViewData_Object_String;
			}
		}

		/// <summary>
		/// Void SaveViewData()
		/// </summary>
		protected RMethod r_SaveViewData;
		public virtual RMethod RSaveViewData
		{
			get
			{
				if(r_SaveViewData == null)
				{
					r_SaveViewData = new(this, "SaveViewData", 0);
					r_SaveViewData.SetBelong(this.instance);
				}
				return r_SaveViewData;
			}
		}

		/// <summary>
		/// Boolean IsViewDataPersitenceSupportedOnChildren(Boolean)
		/// </summary>
		protected RMethod r_IsViewDataPersitenceSupportedOnChildren_Boolean;
		public virtual RMethod RIsViewDataPersitenceSupportedOnChildren_Boolean
		{
			get
			{
				if(r_IsViewDataPersitenceSupportedOnChildren_Boolean == null)
				{
					r_IsViewDataPersitenceSupportedOnChildren_Boolean = new(this, "IsViewDataPersitenceSupportedOnChildren", 0, typeof(System.Boolean));
					r_IsViewDataPersitenceSupportedOnChildren_Boolean.SetBelong(this.instance);
				}
				return r_IsViewDataPersitenceSupportedOnChildren_Boolean;
			}
		}

		/// <summary>
		/// Void OnViewDataReady(Boolean)
		/// </summary>
		protected RMethod r_OnViewDataReady_Boolean;
		public virtual RMethod ROnViewDataReady_Boolean
		{
			get
			{
				if(r_OnViewDataReady_Boolean == null)
				{
					r_OnViewDataReady_Boolean = new(this, "OnViewDataReady", 0, typeof(System.Boolean));
					r_OnViewDataReady_Boolean.SetBelong(this.instance);
				}
				return r_OnViewDataReady_Boolean;
			}
		}

		/// <summary>
		/// Boolean ContainsPoint(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_ContainsPoint_Vector2;
		public virtual RMethod RContainsPoint_Vector2
		{
			get
			{
				if(r_ContainsPoint_Vector2 == null)
				{
					r_ContainsPoint_Vector2 = new(this, "ContainsPoint", 0, typeof(UnityEngine.Vector2));
					r_ContainsPoint_Vector2.SetBelong(this.instance);
				}
				return r_ContainsPoint_Vector2;
			}
		}

		/// <summary>
		/// Boolean Overlaps(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_Overlaps_Rect;
		public virtual RMethod ROverlaps_Rect
		{
			get
			{
				if(r_Overlaps_Rect == null)
				{
					r_Overlaps_Rect = new(this, "Overlaps", 0, typeof(UnityEngine.Rect));
					r_Overlaps_Rect.SetBelong(this.instance);
				}
				return r_Overlaps_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 DoMeasure(Single, MeasureMode, Single, MeasureMode)
		/// </summary>
		protected RMethod r_DoMeasure_Single_MeasureMode_Single_MeasureMode;
		public virtual RMethod RDoMeasure_Single_MeasureMode_Single_MeasureMode
		{
			get
			{
				if(r_DoMeasure_Single_MeasureMode_Single_MeasureMode == null)
				{
					r_DoMeasure_Single_MeasureMode_Single_MeasureMode = new(this, "DoMeasure", 0, typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+MeasureMode"), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+MeasureMode"));
					r_DoMeasure_Single_MeasureMode_Single_MeasureMode.SetBelong(this.instance);
				}
				return r_DoMeasure_Single_MeasureMode_Single_MeasureMode;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaSize Measure(UnityEngine.Yoga.YogaNode, Single, UnityEngine.Yoga.YogaMeasureMode, Single, UnityEngine.Yoga.YogaMeasureMode)
		/// </summary>
		protected RMethod r_Measure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode;
		public virtual RMethod RMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode
		{
			get
			{
				if(r_Measure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode == null)
				{
					r_Measure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode = new(this, "Measure", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.YogaNode"), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Yoga.YogaMeasureMode"), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Yoga.YogaMeasureMode"));
					r_Measure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode.SetBelong(this.instance);
				}
				return r_Measure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode;
			}
		}

		/// <summary>
		/// Void SetSize(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_SetSize_Vector2;
		public virtual RMethod RSetSize_Vector2
		{
			get
			{
				if(r_SetSize_Vector2 == null)
				{
					r_SetSize_Vector2 = new(this, "SetSize", 0, typeof(UnityEngine.Vector2));
					r_SetSize_Vector2.SetBelong(this.instance);
				}
				return r_SetSize_Vector2;
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
					r_SetInlineRule_StyleSheet_StyleRule = new(this, "SetInlineRule", 0, typeof(UnityEngine.UIElements.StyleSheet),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleRule"));
					r_SetInlineRule_StyleSheet_StyleRule.SetBelong(this.instance);
				}
				return r_SetInlineRule_StyleSheet_StyleRule;
			}
		}

		/// <summary>
		/// Void UpdateInlineRule(UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleRule)
		/// </summary>
		protected RMethod r_UpdateInlineRule_StyleSheet_StyleRule;
		public virtual RMethod RUpdateInlineRule_StyleSheet_StyleRule
		{
			get
			{
				if(r_UpdateInlineRule_StyleSheet_StyleRule == null)
				{
					r_UpdateInlineRule_StyleSheet_StyleRule = new(this, "UpdateInlineRule", 0, typeof(UnityEngine.UIElements.StyleSheet),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleRule"));
					r_UpdateInlineRule_StyleSheet_StyleRule.SetBelong(this.instance);
				}
				return r_UpdateInlineRule_StyleSheet_StyleRule;
			}
		}

		/// <summary>
		/// Void SetComputedStyle(UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_SetComputedStyle_Ref_ComputedStyle;
		public virtual RMethod RSetComputedStyle_Ref_ComputedStyle
		{
			get
			{
				if(r_SetComputedStyle_Ref_ComputedStyle == null)
				{
					r_SetComputedStyle_Ref_ComputedStyle = new(this, "SetComputedStyle", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_SetComputedStyle_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_SetComputedStyle_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Void ResetPositionProperties()
		/// </summary>
		protected RMethod r_ResetPositionProperties;
		public virtual RMethod RResetPositionProperties
		{
			get
			{
				if(r_ResetPositionProperties == null)
				{
					r_ResetPositionProperties = new(this, "ResetPositionProperties", 0);
					r_ResetPositionProperties.SetBelong(this.instance);
				}
				return r_ResetPositionProperties;
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
		/// System.Collections.Generic.IEnumerable`1[System.String] GetClasses()
		/// </summary>
		protected RMethod r_GetClasses;
		public virtual RMethod RGetClasses
		{
			get
			{
				if(r_GetClasses == null)
				{
					r_GetClasses = new(this, "GetClasses", 0);
					r_GetClasses.SetBelong(this.instance);
				}
				return r_GetClasses;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] GetClassesForIteration()
		/// </summary>
		protected RMethod r_GetClassesForIteration;
		public virtual RMethod RGetClassesForIteration
		{
			get
			{
				if(r_GetClassesForIteration == null)
				{
					r_GetClassesForIteration = new(this, "GetClassesForIteration", 0);
					r_GetClassesForIteration.SetBelong(this.instance);
				}
				return r_GetClassesForIteration;
			}
		}

		/// <summary>
		/// Void ClearClassList()
		/// </summary>
		protected RMethod r_ClearClassList;
		public virtual RMethod RClearClassList
		{
			get
			{
				if(r_ClearClassList == null)
				{
					r_ClearClassList = new(this, "ClearClassList", 0);
					r_ClearClassList.SetBelong(this.instance);
				}
				return r_ClearClassList;
			}
		}

		/// <summary>
		/// Void AddToClassList(System.String)
		/// </summary>
		protected RMethod r_AddToClassList_String;
		public virtual RMethod RAddToClassList_String
		{
			get
			{
				if(r_AddToClassList_String == null)
				{
					r_AddToClassList_String = new(this, "AddToClassList", 0, typeof(System.String));
					r_AddToClassList_String.SetBelong(this.instance);
				}
				return r_AddToClassList_String;
			}
		}

		/// <summary>
		/// Void RemoveFromClassList(System.String)
		/// </summary>
		protected RMethod r_RemoveFromClassList_String;
		public virtual RMethod RRemoveFromClassList_String
		{
			get
			{
				if(r_RemoveFromClassList_String == null)
				{
					r_RemoveFromClassList_String = new(this, "RemoveFromClassList", 0, typeof(System.String));
					r_RemoveFromClassList_String.SetBelong(this.instance);
				}
				return r_RemoveFromClassList_String;
			}
		}

		/// <summary>
		/// Void ToggleInClassList(System.String)
		/// </summary>
		protected RMethod r_ToggleInClassList_String;
		public virtual RMethod RToggleInClassList_String
		{
			get
			{
				if(r_ToggleInClassList_String == null)
				{
					r_ToggleInClassList_String = new(this, "ToggleInClassList", 0, typeof(System.String));
					r_ToggleInClassList_String.SetBelong(this.instance);
				}
				return r_ToggleInClassList_String;
			}
		}

		/// <summary>
		/// Void EnableInClassList(System.String, Boolean)
		/// </summary>
		protected RMethod r_EnableInClassList_String_Boolean;
		public virtual RMethod REnableInClassList_String_Boolean
		{
			get
			{
				if(r_EnableInClassList_String_Boolean == null)
				{
					r_EnableInClassList_String_Boolean = new(this, "EnableInClassList", 0, typeof(System.String), typeof(System.Boolean));
					r_EnableInClassList_String_Boolean.SetBelong(this.instance);
				}
				return r_EnableInClassList_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean ClassListContains(System.String)
		/// </summary>
		protected RMethod r_ClassListContains_String;
		public virtual RMethod RClassListContains_String
		{
			get
			{
				if(r_ClassListContains_String == null)
				{
					r_ClassListContains_String = new(this, "ClassListContains", 0, typeof(System.String));
					r_ClassListContains_String.SetBelong(this.instance);
				}
				return r_ClassListContains_String;
			}
		}

		/// <summary>
		/// System.Object FindAncestorUserData()
		/// </summary>
		protected RMethod r_FindAncestorUserData;
		public virtual RMethod RFindAncestorUserData
		{
			get
			{
				if(r_FindAncestorUserData == null)
				{
					r_FindAncestorUserData = new(this, "FindAncestorUserData", 0);
					r_FindAncestorUserData.SetBelong(this.instance);
				}
				return r_FindAncestorUserData;
			}
		}

		/// <summary>
		/// System.Object GetProperty(UnityEngine.PropertyName)
		/// </summary>
		protected RMethod r_GetProperty_PropertyName;
		public virtual RMethod RGetProperty_PropertyName
		{
			get
			{
				if(r_GetProperty_PropertyName == null)
				{
					r_GetProperty_PropertyName = new(this, "GetProperty", 0, typeof(UnityEngine.PropertyName));
					r_GetProperty_PropertyName.SetBelong(this.instance);
				}
				return r_GetProperty_PropertyName;
			}
		}

		/// <summary>
		/// Void SetProperty(UnityEngine.PropertyName, System.Object)
		/// </summary>
		protected RMethod r_SetProperty_PropertyName_Object;
		public virtual RMethod RSetProperty_PropertyName_Object
		{
			get
			{
				if(r_SetProperty_PropertyName_Object == null)
				{
					r_SetProperty_PropertyName_Object = new(this, "SetProperty", 0, typeof(UnityEngine.PropertyName), typeof(System.Object));
					r_SetProperty_PropertyName_Object.SetBelong(this.instance);
				}
				return r_SetProperty_PropertyName_Object;
			}
		}

		/// <summary>
		/// Boolean HasProperty(UnityEngine.PropertyName)
		/// </summary>
		protected RMethod r_HasProperty_PropertyName;
		public virtual RMethod RHasProperty_PropertyName
		{
			get
			{
				if(r_HasProperty_PropertyName == null)
				{
					r_HasProperty_PropertyName = new(this, "HasProperty", 0, typeof(UnityEngine.PropertyName));
					r_HasProperty_PropertyName.SetBelong(this.instance);
				}
				return r_HasProperty_PropertyName;
			}
		}

		/// <summary>
		/// Void ApplyPlayerRenderingToEditorElement()
		/// </summary>
		protected RMethod r_ApplyPlayerRenderingToEditorElement;
		public virtual RMethod RApplyPlayerRenderingToEditorElement
		{
			get
			{
				if(r_ApplyPlayerRenderingToEditorElement == null)
				{
					r_ApplyPlayerRenderingToEditorElement = new(this, "ApplyPlayerRenderingToEditorElement", 0);
					r_ApplyPlayerRenderingToEditorElement.SetBelong(this.instance);
				}
				return r_ApplyPlayerRenderingToEditorElement;
			}
		}

		/// <summary>
		/// Void RegisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate)
		/// </summary>
		protected RMethod r_RegisterAnimation_IValueAnimationUpdate;
		public virtual RMethod RRegisterAnimation_IValueAnimationUpdate
		{
			get
			{
				if(r_RegisterAnimation_IValueAnimationUpdate == null)
				{
					r_RegisterAnimation_IValueAnimationUpdate = new(this, "RegisterAnimation", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.Experimental.IValueAnimationUpdate"));
					r_RegisterAnimation_IValueAnimationUpdate.SetBelong(this.instance);
				}
				return r_RegisterAnimation_IValueAnimationUpdate;
			}
		}

		/// <summary>
		/// Void UnregisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate)
		/// </summary>
		protected RMethod r_UnregisterAnimation_IValueAnimationUpdate;
		public virtual RMethod RUnregisterAnimation_IValueAnimationUpdate
		{
			get
			{
				if(r_UnregisterAnimation_IValueAnimationUpdate == null)
				{
					r_UnregisterAnimation_IValueAnimationUpdate = new(this, "UnregisterAnimation", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.Experimental.IValueAnimationUpdate"));
					r_UnregisterAnimation_IValueAnimationUpdate.SetBelong(this.instance);
				}
				return r_UnregisterAnimation_IValueAnimationUpdate;
			}
		}

		/// <summary>
		/// Boolean GetCachedNextParentWithEventCallback(UnityEngine.UIElements.VisualElement ByRef)
		/// </summary>
		protected RMethod r_GetCachedNextParentWithEventCallback_Out_VisualElement;
		public virtual RMethod RGetCachedNextParentWithEventCallback_Out_VisualElement
		{
			get
			{
				if(r_GetCachedNextParentWithEventCallback_Out_VisualElement == null)
				{
					r_GetCachedNextParentWithEventCallback_Out_VisualElement = new(this, "GetCachedNextParentWithEventCallback", 0, typeof(UnityEngine.UIElements.VisualElement).MakeByRefType());
					r_GetCachedNextParentWithEventCallback_Out_VisualElement.SetBelong(this.instance);
				}
				return r_GetCachedNextParentWithEventCallback_Out_VisualElement;
			}
		}

		/// <summary>
		/// Boolean HasEventCallbacks(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_HasEventCallbacks_EventCategory;
		public virtual RMethod RHasEventCallbacks_EventCategory
		{
			get
			{
				if(r_HasEventCallbacks_EventCategory == null)
				{
					r_HasEventCallbacks_EventCategory = new(this, "HasEventCallbacks", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_HasEventCallbacks_EventCategory.SetBelong(this.instance);
				}
				return r_HasEventCallbacks_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasParentEventCallbacks(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_HasParentEventCallbacks_EventCategory;
		public virtual RMethod RHasParentEventCallbacks_EventCategory
		{
			get
			{
				if(r_HasParentEventCallbacks_EventCategory == null)
				{
					r_HasParentEventCallbacks_EventCategory = new(this, "HasParentEventCallbacks", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_HasParentEventCallbacks_EventCategory.SetBelong(this.instance);
				}
				return r_HasParentEventCallbacks_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasParentEventCallbacksOrDefaultActions(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_HasParentEventCallbacksOrDefaultActions_EventCategory;
		public virtual RMethod RHasParentEventCallbacksOrDefaultActions_EventCategory
		{
			get
			{
				if(r_HasParentEventCallbacksOrDefaultActions_EventCategory == null)
				{
					r_HasParentEventCallbacksOrDefaultActions_EventCategory = new(this, "HasParentEventCallbacksOrDefaultActions", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_HasParentEventCallbacksOrDefaultActions_EventCategory.SetBelong(this.instance);
				}
				return r_HasParentEventCallbacksOrDefaultActions_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasEventCallbacksOrDefaultActions(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_HasEventCallbacksOrDefaultActions_EventCategory;
		public virtual RMethod RHasEventCallbacksOrDefaultActions_EventCategory
		{
			get
			{
				if(r_HasEventCallbacksOrDefaultActions_EventCategory == null)
				{
					r_HasEventCallbacksOrDefaultActions_EventCategory = new(this, "HasEventCallbacksOrDefaultActions", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_HasEventCallbacksOrDefaultActions_EventCategory.SetBelong(this.instance);
				}
				return r_HasEventCallbacksOrDefaultActions_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasParentEventCallbacksOrDefaultActionAtTarget(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_HasParentEventCallbacksOrDefaultActionAtTarget_EventCategory;
		public virtual RMethod RHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory
		{
			get
			{
				if(r_HasParentEventCallbacksOrDefaultActionAtTarget_EventCategory == null)
				{
					r_HasParentEventCallbacksOrDefaultActionAtTarget_EventCategory = new(this, "HasParentEventCallbacksOrDefaultActionAtTarget", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_HasParentEventCallbacksOrDefaultActionAtTarget_EventCategory.SetBelong(this.instance);
				}
				return r_HasParentEventCallbacksOrDefaultActionAtTarget_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasEventCallbacksOrDefaultActionAtTarget(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_HasEventCallbacksOrDefaultActionAtTarget_EventCategory;
		public virtual RMethod RHasEventCallbacksOrDefaultActionAtTarget_EventCategory
		{
			get
			{
				if(r_HasEventCallbacksOrDefaultActionAtTarget_EventCategory == null)
				{
					r_HasEventCallbacksOrDefaultActionAtTarget_EventCategory = new(this, "HasEventCallbacksOrDefaultActionAtTarget", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_HasEventCallbacksOrDefaultActionAtTarget_EventCategory.SetBelong(this.instance);
				}
				return r_HasEventCallbacksOrDefaultActionAtTarget_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasDefaultAction(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_HasDefaultAction_EventCategory;
		public virtual RMethod RHasDefaultAction_EventCategory
		{
			get
			{
				if(r_HasDefaultAction_EventCategory == null)
				{
					r_HasDefaultAction_EventCategory = new(this, "HasDefaultAction", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_HasDefaultAction_EventCategory.SetBelong(this.instance);
				}
				return r_HasDefaultAction_EventCategory;
			}
		}

		/// <summary>
		/// Boolean ShouldClip()
		/// </summary>
		protected RMethod r_ShouldClip;
		public virtual RMethod RShouldClip
		{
			get
			{
				if(r_ShouldClip == null)
				{
					r_ShouldClip = new(this, "ShouldClip", 0);
					r_ShouldClip.SetBelong(this.instance);
				}
				return r_ShouldClip;
			}
		}

		/// <summary>
		/// Void Add(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_Add_VisualElement;
		public virtual RMethod RAdd_VisualElement
		{
			get
			{
				if(r_Add_VisualElement == null)
				{
					r_Add_VisualElement = new(this, "Add", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_Add_VisualElement.SetBelong(this.instance);
				}
				return r_Add_VisualElement;
			}
		}

		/// <summary>
		/// Void Insert(Int32, UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_Insert_Int32_VisualElement;
		public virtual RMethod RInsert_Int32_VisualElement
		{
			get
			{
				if(r_Insert_Int32_VisualElement == null)
				{
					r_Insert_Int32_VisualElement = new(this, "Insert", 0, typeof(System.Int32), typeof(UnityEngine.UIElements.VisualElement));
					r_Insert_Int32_VisualElement.SetBelong(this.instance);
				}
				return r_Insert_Int32_VisualElement;
			}
		}

		/// <summary>
		/// Void Remove(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_Remove_VisualElement;
		public virtual RMethod RRemove_VisualElement
		{
			get
			{
				if(r_Remove_VisualElement == null)
				{
					r_Remove_VisualElement = new(this, "Remove", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_Remove_VisualElement.SetBelong(this.instance);
				}
				return r_Remove_VisualElement;
			}
		}

		/// <summary>
		/// Void RemoveAt(Int32)
		/// </summary>
		protected RMethod r_RemoveAt_Int32;
		public virtual RMethod RRemoveAt_Int32
		{
			get
			{
				if(r_RemoveAt_Int32 == null)
				{
					r_RemoveAt_Int32 = new(this, "RemoveAt", 0, typeof(System.Int32));
					r_RemoveAt_Int32.SetBelong(this.instance);
				}
				return r_RemoveAt_Int32;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_Clear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_Clear == null)
				{
					r_Clear = new(this, "Clear", 0);
					r_Clear.SetBelong(this.instance);
				}
				return r_Clear;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement ElementAt(Int32)
		/// </summary>
		protected RMethod r_ElementAt_Int32;
		public virtual RMethod RElementAt_Int32
		{
			get
			{
				if(r_ElementAt_Int32 == null)
				{
					r_ElementAt_Int32 = new(this, "ElementAt", 0, typeof(System.Int32));
					r_ElementAt_Int32.SetBelong(this.instance);
				}
				return r_ElementAt_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_IndexOf_VisualElement;
		public virtual RMethod RIndexOf_VisualElement
		{
			get
			{
				if(r_IndexOf_VisualElement == null)
				{
					r_IndexOf_VisualElement = new(this, "IndexOf", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_IndexOf_VisualElement.SetBelong(this.instance);
				}
				return r_IndexOf_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement ElementAtTreePath(System.Collections.Generic.List`1[System.Int32])
		/// </summary>
		protected RMethod r_ElementAtTreePath_List_d_Int32_p_;
		public virtual RMethod RElementAtTreePath_List_d_Int32_p_
		{
			get
			{
				if(r_ElementAtTreePath_List_d_Int32_p_ == null)
				{
					r_ElementAtTreePath_List_d_Int32_p_ = new(this, "ElementAtTreePath", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)));
					r_ElementAtTreePath_List_d_Int32_p_.SetBelong(this.instance);
				}
				return r_ElementAtTreePath_List_d_Int32_p_;
			}
		}

		/// <summary>
		/// Boolean FindElementInTree(UnityEngine.UIElements.VisualElement, System.Collections.Generic.List`1[System.Int32])
		/// </summary>
		protected RMethod r_FindElementInTree_VisualElement_List_d_Int32_p_;
		public virtual RMethod RFindElementInTree_VisualElement_List_d_Int32_p_
		{
			get
			{
				if(r_FindElementInTree_VisualElement_List_d_Int32_p_ == null)
				{
					r_FindElementInTree_VisualElement_List_d_Int32_p_ = new(this, "FindElementInTree", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)));
					r_FindElementInTree_VisualElement_List_d_Int32_p_.SetBelong(this.instance);
				}
				return r_FindElementInTree_VisualElement_List_d_Int32_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.VisualElement] Children()
		/// </summary>
		protected RMethod r_Children;
		public virtual RMethod RChildren
		{
			get
			{
				if(r_Children == null)
				{
					r_Children = new(this, "Children", 0);
					r_Children.SetBelong(this.instance);
				}
				return r_Children;
			}
		}

		/// <summary>
		/// Void Sort(System.Comparison`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_Sort_Comparison_d_VisualElement_p_;
		public virtual RMethod RSort_Comparison_d_VisualElement_p_
		{
			get
			{
				if(r_Sort_Comparison_d_VisualElement_p_ == null)
				{
					r_Sort_Comparison_d_VisualElement_p_ = new(this, "Sort", 0, typeof(System.Comparison<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
					r_Sort_Comparison_d_VisualElement_p_.SetBelong(this.instance);
				}
				return r_Sort_Comparison_d_VisualElement_p_;
			}
		}

		/// <summary>
		/// Void BringToFront()
		/// </summary>
		protected RMethod r_BringToFront;
		public virtual RMethod RBringToFront
		{
			get
			{
				if(r_BringToFront == null)
				{
					r_BringToFront = new(this, "BringToFront", 0);
					r_BringToFront.SetBelong(this.instance);
				}
				return r_BringToFront;
			}
		}

		/// <summary>
		/// Void SendToBack()
		/// </summary>
		protected RMethod r_SendToBack;
		public virtual RMethod RSendToBack
		{
			get
			{
				if(r_SendToBack == null)
				{
					r_SendToBack = new(this, "SendToBack", 0);
					r_SendToBack.SetBelong(this.instance);
				}
				return r_SendToBack;
			}
		}

		/// <summary>
		/// Void PlaceBehind(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_PlaceBehind_VisualElement;
		public virtual RMethod RPlaceBehind_VisualElement
		{
			get
			{
				if(r_PlaceBehind_VisualElement == null)
				{
					r_PlaceBehind_VisualElement = new(this, "PlaceBehind", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_PlaceBehind_VisualElement.SetBelong(this.instance);
				}
				return r_PlaceBehind_VisualElement;
			}
		}

		/// <summary>
		/// Void PlaceInFront(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_PlaceInFront_VisualElement;
		public virtual RMethod RPlaceInFront_VisualElement
		{
			get
			{
				if(r_PlaceInFront_VisualElement == null)
				{
					r_PlaceInFront_VisualElement = new(this, "PlaceInFront", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_PlaceInFront_VisualElement.SetBelong(this.instance);
				}
				return r_PlaceInFront_VisualElement;
			}
		}

		/// <summary>
		/// Void RemoveFromHierarchy()
		/// </summary>
		protected RMethod r_RemoveFromHierarchy;
		public virtual RMethod RRemoveFromHierarchy
		{
			get
			{
				if(r_RemoveFromHierarchy == null)
				{
					r_RemoveFromHierarchy = new(this, "RemoveFromHierarchy", 0);
					r_RemoveFromHierarchy.SetBelong(this.instance);
				}
				return r_RemoveFromHierarchy;
			}
		}

		/// <summary>
		/// T GetFirstOfType[T]()
		/// </summary>
		protected RMethod r_GetFirstOfType_GT;
		public virtual RMethod RGetFirstOfType_GT
		{
			get
			{
				if(r_GetFirstOfType_GT == null)
				{
					r_GetFirstOfType_GT = new(this, "GetFirstOfType", 1);
					r_GetFirstOfType_GT.SetBelong(this.instance);
				}
				return r_GetFirstOfType_GT;
			}
		}

		/// <summary>
		/// T GetFirstAncestorOfType[T]()
		/// </summary>
		protected RMethod r_GetFirstAncestorOfType_GT;
		public virtual RMethod RGetFirstAncestorOfType_GT
		{
			get
			{
				if(r_GetFirstAncestorOfType_GT == null)
				{
					r_GetFirstAncestorOfType_GT = new(this, "GetFirstAncestorOfType", 1);
					r_GetFirstAncestorOfType_GT.SetBelong(this.instance);
				}
				return r_GetFirstAncestorOfType_GT;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetFirstAncestorWhere(System.Predicate`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_GetFirstAncestorWhere_Predicate_d_VisualElement_p_;
		public virtual RMethod RGetFirstAncestorWhere_Predicate_d_VisualElement_p_
		{
			get
			{
				if(r_GetFirstAncestorWhere_Predicate_d_VisualElement_p_ == null)
				{
					r_GetFirstAncestorWhere_Predicate_d_VisualElement_p_ = new(this, "GetFirstAncestorWhere", 0, typeof(System.Predicate<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
					r_GetFirstAncestorWhere_Predicate_d_VisualElement_p_.SetBelong(this.instance);
				}
				return r_GetFirstAncestorWhere_Predicate_d_VisualElement_p_;
			}
		}

		/// <summary>
		/// Boolean Contains(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_Contains_VisualElement;
		public virtual RMethod RContains_VisualElement
		{
			get
			{
				if(r_Contains_VisualElement == null)
				{
					r_Contains_VisualElement = new(this, "Contains", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_Contains_VisualElement.SetBelong(this.instance);
				}
				return r_Contains_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement FindCommonAncestor(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_FindCommonAncestor_VisualElement;
		public virtual RMethod RFindCommonAncestor_VisualElement
		{
			get
			{
				if(r_FindCommonAncestor_VisualElement == null)
				{
					r_FindCommonAncestor_VisualElement = new(this, "FindCommonAncestor", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_FindCommonAncestor_VisualElement.SetBelong(this.instance);
				}
				return r_FindCommonAncestor_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetRoot()
		/// </summary>
		protected RMethod r_GetRoot;
		public virtual RMethod RGetRoot
		{
			get
			{
				if(r_GetRoot == null)
				{
					r_GetRoot = new(this, "GetRoot", 0);
					r_GetRoot.SetBelong(this.instance);
				}
				return r_GetRoot;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetRootVisualContainer()
		/// </summary>
		protected RMethod r_GetRootVisualContainer;
		public virtual RMethod RGetRootVisualContainer
		{
			get
			{
				if(r_GetRootVisualContainer == null)
				{
					r_GetRootVisualContainer = new(this, "GetRootVisualContainer", 0);
					r_GetRootVisualContainer.SetBelong(this.instance);
				}
				return r_GetRootVisualContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetNextElementDepthFirst()
		/// </summary>
		protected RMethod r_GetNextElementDepthFirst;
		public virtual RMethod RGetNextElementDepthFirst
		{
			get
			{
				if(r_GetNextElementDepthFirst == null)
				{
					r_GetNextElementDepthFirst = new(this, "GetNextElementDepthFirst", 0);
					r_GetNextElementDepthFirst.SetBelong(this.instance);
				}
				return r_GetNextElementDepthFirst;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetPreviousElementDepthFirst()
		/// </summary>
		protected RMethod r_GetPreviousElementDepthFirst;
		public virtual RMethod RGetPreviousElementDepthFirst
		{
			get
			{
				if(r_GetPreviousElementDepthFirst == null)
				{
					r_GetPreviousElementDepthFirst = new(this, "GetPreviousElementDepthFirst", 0);
					r_GetPreviousElementDepthFirst.SetBelong(this.instance);
				}
				return r_GetPreviousElementDepthFirst;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement RetargetElement(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RetargetElement_VisualElement;
		public virtual RMethod RRetargetElement_VisualElement
		{
			get
			{
				if(r_RetargetElement_VisualElement == null)
				{
					r_RetargetElement_VisualElement = new(this, "RetargetElement", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RetargetElement_VisualElement.SetBelong(this.instance);
				}
				return r_RetargetElement_VisualElement;
			}
		}

		/// <summary>
		/// Void GetPivotedMatrixWithLayout(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_GetPivotedMatrixWithLayout_Out_Matrix4x4;
		public virtual RMethod RGetPivotedMatrixWithLayout_Out_Matrix4x4
		{
			get
			{
				if(r_GetPivotedMatrixWithLayout_Out_Matrix4x4 == null)
				{
					r_GetPivotedMatrixWithLayout_Out_Matrix4x4 = new(this, "GetPivotedMatrixWithLayout", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_GetPivotedMatrixWithLayout_Out_Matrix4x4.SetBelong(this.instance);
				}
				return r_GetPivotedMatrixWithLayout_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void AddStyleSheetPath(System.String)
		/// </summary>
		protected RMethod r_AddStyleSheetPath_String;
		public virtual RMethod RAddStyleSheetPath_String
		{
			get
			{
				if(r_AddStyleSheetPath_String == null)
				{
					r_AddStyleSheetPath_String = new(this, "AddStyleSheetPath", 0, typeof(System.String));
					r_AddStyleSheetPath_String.SetBelong(this.instance);
				}
				return r_AddStyleSheetPath_String;
			}
		}

		/// <summary>
		/// Boolean HasStyleSheetPath(System.String)
		/// </summary>
		protected RMethod r_HasStyleSheetPath_String;
		public virtual RMethod RHasStyleSheetPath_String
		{
			get
			{
				if(r_HasStyleSheetPath_String == null)
				{
					r_HasStyleSheetPath_String = new(this, "HasStyleSheetPath", 0, typeof(System.String));
					r_HasStyleSheetPath_String.SetBelong(this.instance);
				}
				return r_HasStyleSheetPath_String;
			}
		}

		/// <summary>
		/// Void RemoveStyleSheetPath(System.String)
		/// </summary>
		protected RMethod r_RemoveStyleSheetPath_String;
		public virtual RMethod RRemoveStyleSheetPath_String
		{
			get
			{
				if(r_RemoveStyleSheetPath_String == null)
				{
					r_RemoveStyleSheetPath_String = new(this, "RemoveStyleSheetPath", 0, typeof(System.String));
					r_RemoveStyleSheetPath_String.SetBelong(this.instance);
				}
				return r_RemoveStyleSheetPath_String;
			}
		}

		/// <summary>
		/// Void Blur()
		/// </summary>
		protected RMethod r_Blur;
		public virtual RMethod RBlur
		{
			get
			{
				if(r_Blur == null)
				{
					r_Blur = new(this, "Blur", 0);
					r_Blur.SetBelong(this.instance);
				}
				return r_Blur;
			}
		}

		/// <summary>
		/// Void BlurImmediately()
		/// </summary>
		protected RMethod r_BlurImmediately;
		public virtual RMethod RBlurImmediately
		{
			get
			{
				if(r_BlurImmediately == null)
				{
					r_BlurImmediately = new(this, "BlurImmediately", 0);
					r_BlurImmediately.SetBelong(this.instance);
				}
				return r_BlurImmediately;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultActionDisabled(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_ExecuteDefaultActionDisabled_EventBase;
		public virtual RMethod RExecuteDefaultActionDisabled_EventBase
		{
			get
			{
				if(r_ExecuteDefaultActionDisabled_EventBase == null)
				{
					r_ExecuteDefaultActionDisabled_EventBase = new(this, "ExecuteDefaultActionDisabled", 0, typeof(UnityEngine.UIElements.EventBase));
					r_ExecuteDefaultActionDisabled_EventBase.SetBelong(this.instance);
				}
				return r_ExecuteDefaultActionDisabled_EventBase;
			}
		}

		/// <summary>
		/// Void RegisterCallback[TEventType](UnityEngine.UIElements.EventCallback`1[TEventType], UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_RegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown;
		public virtual RMethod RRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown
		{
			get
			{
				if(r_RegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown == null)
				{
					r_RegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown = new(this, "RegisterCallback", 1, typeof(UnityEngine.UIElements.EventCallback<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(UnityEngine.UIElements.TrickleDown));
					r_RegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown.SetBelong(this.instance);
				}
				return r_RegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown;
			}
		}

		/// <summary>
		/// Void RegisterCallback[TEventType,TUserArgsType](UnityEngine.UIElements.EventCallback`2[TEventType,TUserArgsType], TUserArgsType, UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_RegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown;
		public virtual RMethod RRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown
		{
			get
			{
				if(r_RegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown == null)
				{
					r_RegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown = new(this, "RegisterCallback", 2, typeof(UnityEngine.UIElements.EventCallback<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), Type.MakeGenericMethodParameter(1), typeof(UnityEngine.UIElements.TrickleDown));
					r_RegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown.SetBelong(this.instance);
				}
				return r_RegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown;
			}
		}

		/// <summary>
		/// Void RegisterCallback[TEventType](UnityEngine.UIElements.EventCallback`1[TEventType], UnityEngine.UIElements.InvokePolicy, UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_RegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown;
		public virtual RMethod RRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown
		{
			get
			{
				if(r_RegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown == null)
				{
					r_RegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown = new(this, "RegisterCallback", 1, typeof(UnityEngine.UIElements.EventCallback<>).MakeGenericType(Type.MakeGenericMethodParameter(0)),  ReflectionUtils.GetType("UnityEngine.UIElements.InvokePolicy"), typeof(UnityEngine.UIElements.TrickleDown));
					r_RegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown.SetBelong(this.instance);
				}
				return r_RegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown;
			}
		}

		/// <summary>
		/// Void UnregisterCallback[TEventType](UnityEngine.UIElements.EventCallback`1[TEventType], UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_UnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown;
		public virtual RMethod RUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown
		{
			get
			{
				if(r_UnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown == null)
				{
					r_UnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown = new(this, "UnregisterCallback", 1, typeof(UnityEngine.UIElements.EventCallback<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(UnityEngine.UIElements.TrickleDown));
					r_UnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown.SetBelong(this.instance);
				}
				return r_UnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown;
			}
		}

		/// <summary>
		/// Void UnregisterCallback[TEventType,TUserArgsType](UnityEngine.UIElements.EventCallback`2[TEventType,TUserArgsType], UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_UnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown;
		public virtual RMethod RUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown
		{
			get
			{
				if(r_UnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown == null)
				{
					r_UnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown = new(this, "UnregisterCallback", 2, typeof(UnityEngine.UIElements.EventCallback<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), typeof(UnityEngine.UIElements.TrickleDown));
					r_UnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown.SetBelong(this.instance);
				}
				return r_UnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown;
			}
		}

		/// <summary>
		/// Boolean TryGetUserArgs[TEventType,TCallbackArgs](UnityEngine.UIElements.EventCallback`2[TEventType,TCallbackArgs], UnityEngine.UIElements.TrickleDown, TCallbackArgs ByRef)
		/// </summary>
		protected RMethod r_TryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs;
		public virtual RMethod RTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs
		{
			get
			{
				if(r_TryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs == null)
				{
					r_TryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs = new(this, "TryGetUserArgs", 2, typeof(UnityEngine.UIElements.EventCallback<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), typeof(UnityEngine.UIElements.TrickleDown), Type.MakeGenericMethodParameter(1).MakeByRefType());
					r_TryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs.SetBelong(this.instance);
				}
				return r_TryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs;
			}
		}

		/// <summary>
		/// Void HandleEventAtTargetPhase(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_HandleEventAtTargetPhase_EventBase;
		public virtual RMethod RHandleEventAtTargetPhase_EventBase
		{
			get
			{
				if(r_HandleEventAtTargetPhase_EventBase == null)
				{
					r_HandleEventAtTargetPhase_EventBase = new(this, "HandleEventAtTargetPhase", 0, typeof(UnityEngine.UIElements.EventBase));
					r_HandleEventAtTargetPhase_EventBase.SetBelong(this.instance);
				}
				return r_HandleEventAtTargetPhase_EventBase;
			}
		}

		/// <summary>
		/// Void HandleEventAtTargetAndDefaultPhase(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_HandleEventAtTargetAndDefaultPhase_EventBase;
		public virtual RMethod RHandleEventAtTargetAndDefaultPhase_EventBase
		{
			get
			{
				if(r_HandleEventAtTargetAndDefaultPhase_EventBase == null)
				{
					r_HandleEventAtTargetAndDefaultPhase_EventBase = new(this, "HandleEventAtTargetAndDefaultPhase", 0, typeof(UnityEngine.UIElements.EventBase));
					r_HandleEventAtTargetAndDefaultPhase_EventBase.SetBelong(this.instance);
				}
				return r_HandleEventAtTargetAndDefaultPhase_EventBase;
			}
		}

		/// <summary>
		/// Void HandleEventAtCurrentTargetAndPhase(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_HandleEventAtCurrentTargetAndPhase_EventBase;
		public virtual RMethod RHandleEventAtCurrentTargetAndPhase_EventBase
		{
			get
			{
				if(r_HandleEventAtCurrentTargetAndPhase_EventBase == null)
				{
					r_HandleEventAtCurrentTargetAndPhase_EventBase = new(this, "HandleEventAtCurrentTargetAndPhase", 0, typeof(UnityEngine.UIElements.EventBase));
					r_HandleEventAtCurrentTargetAndPhase_EventBase.SetBelong(this.instance);
				}
				return r_HandleEventAtCurrentTargetAndPhase_EventBase;
			}
		}

		/// <summary>
		/// Void HandleEventEditorInternal(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_HandleEventEditorInternal_EventBase;
		public virtual RMethod RHandleEventEditorInternal_EventBase
		{
			get
			{
				if(r_HandleEventEditorInternal_EventBase == null)
				{
					r_HandleEventEditorInternal_EventBase = new(this, "HandleEventEditorInternal", 0, typeof(UnityEngine.UIElements.EventBase));
					r_HandleEventEditorInternal_EventBase.SetBelong(this.instance);
				}
				return r_HandleEventEditorInternal_EventBase;
			}
		}

		/// <summary>
		/// Void HandleEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_HandleEvent_EventBase;
		public virtual RMethod RHandleEvent_EventBase
		{
			get
			{
				if(r_HandleEvent_EventBase == null)
				{
					r_HandleEvent_EventBase = new(this, "HandleEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_HandleEvent_EventBase.SetBelong(this.instance);
				}
				return r_HandleEvent_EventBase;
			}
		}

		/// <summary>
		/// Boolean HasTrickleDownHandlers()
		/// </summary>
		protected RMethod r_HasTrickleDownHandlers;
		public virtual RMethod RHasTrickleDownHandlers
		{
			get
			{
				if(r_HasTrickleDownHandlers == null)
				{
					r_HasTrickleDownHandlers = new(this, "HasTrickleDownHandlers", 0);
					r_HasTrickleDownHandlers.SetBelong(this.instance);
				}
				return r_HasTrickleDownHandlers;
			}
		}

		/// <summary>
		/// Boolean HasBubbleUpHandlers()
		/// </summary>
		protected RMethod r_HasBubbleUpHandlers;
		public virtual RMethod RHasBubbleUpHandlers
		{
			get
			{
				if(r_HasBubbleUpHandlers == null)
				{
					r_HasBubbleUpHandlers = new(this, "HasBubbleUpHandlers", 0);
					r_HasBubbleUpHandlers.SetBelong(this.instance);
				}
				return r_HasBubbleUpHandlers;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_ExecuteDefaultActionAtTarget_EventBase;
		public virtual RMethod RExecuteDefaultActionAtTarget_EventBase
		{
			get
			{
				if(r_ExecuteDefaultActionAtTarget_EventBase == null)
				{
					r_ExecuteDefaultActionAtTarget_EventBase = new(this, "ExecuteDefaultActionAtTarget", 0, typeof(UnityEngine.UIElements.EventBase));
					r_ExecuteDefaultActionAtTarget_EventBase.SetBelong(this.instance);
				}
				return r_ExecuteDefaultActionAtTarget_EventBase;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultActionDisabledAtTarget(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_ExecuteDefaultActionDisabledAtTarget_EventBase;
		public virtual RMethod RExecuteDefaultActionDisabledAtTarget_EventBase
		{
			get
			{
				if(r_ExecuteDefaultActionDisabledAtTarget_EventBase == null)
				{
					r_ExecuteDefaultActionDisabledAtTarget_EventBase = new(this, "ExecuteDefaultActionDisabledAtTarget", 0, typeof(UnityEngine.UIElements.EventBase));
					r_ExecuteDefaultActionDisabledAtTarget_EventBase.SetBelong(this.instance);
				}
				return r_ExecuteDefaultActionDisabledAtTarget_EventBase;
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


        public RBaseSlider() : base("UnityEngine.UIElements.BaseSlider`1")
        {
        }

        public RBaseSlider(System.Object instance) : base("UnityEngine.UIElements.BaseSlider`1")
		{
            SetInstance(instance);
		}

        public RBaseSlider(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBaseSlider(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetHighValueWithoutNotify(TValueType  @newHighValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newHighValue};
            var ___result = RSetHighValueWithoutNotify_TValueType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual TValueType Clamp(TValueType  @value, TValueType  @lowBound, TValueType  @highBound)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @lowBound, @highBound};
            var ___result = RClamp_TValueType_TValueType_TValueType.Invoke(___genericsType, ___parameters);

            return (TValueType)___result;
        }


        public virtual TValueType GetClampedValue(TValueType  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newValue};
            var ___result = RGetClampedValue_TValueType.Invoke(___genericsType, ___parameters);

            return (TValueType)___result;
        }


        public virtual void ApplyInputDeviceDelta(UnityEngine.Vector3  @delta, UnityEngine.UIElements.DeltaSpeed  @speed, TValueType  @startValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delta, @speed, @startValue};
            var ___result = RApplyInputDeviceDelta_Vector3_DeltaSpeed_TValueType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnityEngine__2__UIElements__2__IValueField__0__TValueType__1____2__StartDragging()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnityEngine__2__UIElements__2__IValueField__0__TValueType__1____2__StartDragging.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnityEngine__2__UIElements__2__IValueField__0__TValueType__1____2__StopDragging()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnityEngine__2__UIElements__2__IValueField__0__TValueType__1____2__StopDragging.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValueWithoutNotify(TValueType  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newValue};
            var ___result = RSetValueWithoutNotify_TValueType.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Single GetClosestPowerOfTen(System.Single  @positiveNumber)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@positiveNumber};
            var ___result = RGetClosestPowerOfTen_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single RoundToMultipleOf(System.Single  @value, System.Single  @roundingValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @roundingValue};
            var ___result = RRoundToMultipleOf_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void ClampValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClampValue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual TValueType SliderLerpUnclamped(TValueType  @a, TValueType  @b, System.Single  @interpolant)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @interpolant};
            var ___result = RSliderLerpUnclamped_TValueType_TValueType_Single.Invoke(___genericsType, ___parameters);

            return (TValueType)___result;
        }


        public virtual System.Single SliderNormalizeValue(TValueType  @currentValue, TValueType  @lowerValue, TValueType  @higherValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@currentValue, @lowerValue, @higherValue};
            var ___result = RSliderNormalizeValue_TValueType_TValueType_TValueType.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual TValueType SliderRange()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSliderRange.Invoke(___genericsType, ___parameters);

            return (TValueType)___result;
        }


        public virtual TValueType ParseStringToValue(System.String  @stringValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stringValue};
            var ___result = RParseStringToValue_String.Invoke(___genericsType, ___parameters);

            return (TValueType)___result;
        }


        public virtual void ComputeValueFromKey(RType  @sliderKey, System.Boolean  @isShift)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sliderKey.Value, @isShift};
            var ___result = RComputeValueFromKey_SliderKey_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual TValueType SliderLerpDirectionalUnclamped(TValueType  @a, TValueType  @b, System.Single  @positionInterpolant)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @positionInterpolant};
            var ___result = RSliderLerpDirectionalUnclamped_TValueType_TValueType_Single.Invoke(___genericsType, ___parameters);

            return (TValueType)___result;
        }


        public virtual void SetSliderValueFromDrag()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetSliderValueFromDrag.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ComputeValueAndDirectionFromDrag(System.Single  @sliderLength, System.Single  @dragElementLength, System.Single  @dragElementPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sliderLength, @dragElementLength, @dragElementPos};
            var ___result = RComputeValueAndDirectionFromDrag_Single_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSliderValueFromClick()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetSliderValueFromClick.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnKeyDown(UnityEngine.UIElements.KeyDownEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnKeyDown_KeyDownEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnNavigationMove(UnityEngine.UIElements.NavigationMoveEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnNavigationMove_NavigationMoveEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ComputeValueAndDirectionFromClick(System.Single  @sliderLength, System.Single  @dragElementLength, System.Single  @dragElementPos, System.Single  @dragElementLastPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sliderLength, @dragElementLength, @dragElementPos, @dragElementLastPos};
            var ___result = RComputeValueAndDirectionFromClick_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AdjustDragElement(System.Single  @factor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@factor};
            var ___result = RAdjustDragElement_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateDragElementPosition(UnityEngine.UIElements.GeometryChangedEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RUpdateDragElementPosition_GeometryChangedEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnViewDataReady()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnViewDataReady.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SameValues(System.Single  @a, System.Single  @b, System.Single  @epsilon)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @epsilon};
            var ___result = RSameValues_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void UpdateDragElementPosition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateDragElementPosition.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteDefaultAction(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RExecuteDefaultAction_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateTextFieldVisibility()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateTextFieldVisibility.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateTextFieldValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateTextFieldValue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnTextFieldFocusOut(UnityEngine.UIElements.FocusOutEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnTextFieldFocusOut_FocusOutEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnInputNavigationMoveEvent(UnityEngine.UIElements.NavigationMoveEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnInputNavigationMoveEvent_NavigationMoveEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnTextFieldValueChange(UnityEngine.UIElements.ChangeEvent<System.String>  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnTextFieldValueChange_ChangeEvent_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateMixedValueContent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateMixedValueContent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual TValueType ValidatedValue(TValueType  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RValidatedValue_TValueType.Invoke(___genericsType, ___parameters);

            return (TValueType)___result;
        }


        public virtual void SetValueWithoutValidation(TValueType  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newValue};
            var ___result = RSetValueWithoutValidation_TValueType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect GetTooltipRect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTooltipRect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual System.Boolean TryConvertLengthUnits(RType  @id, ref UnityEngine.UIElements.Length  @from, ref UnityEngine.UIElements.Length  @to, System.Int32  @subPropertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @subPropertyIndex};
            var ___result = RTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32.Invoke(___genericsType, ___parameters);
			@from = (UnityEngine.UIElements.Length)___parameters[1];
			@to = (UnityEngine.UIElements.Length)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryConvertTransformOriginUnits(ref UnityEngine.UIElements.TransformOrigin  @from, ref UnityEngine.UIElements.TransformOrigin  @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin.Invoke(___genericsType, ___parameters);
			@from = (UnityEngine.UIElements.TransformOrigin)___parameters[0];
			@to = (UnityEngine.UIElements.TransformOrigin)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryConvertTranslateUnits(ref UnityEngine.UIElements.Translate  @from, ref UnityEngine.UIElements.Translate  @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RTryConvertTranslateUnits_Ref_Translate_Ref_Translate.Invoke(___genericsType, ___parameters);
			@from = (UnityEngine.UIElements.Translate)___parameters[0];
			@to = (UnityEngine.UIElements.Translate)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryConvertBackgroundPositionUnits(ref UnityEngine.UIElements.BackgroundPosition  @from, ref UnityEngine.UIElements.BackgroundPosition  @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition.Invoke(___genericsType, ___parameters);
			@from = (UnityEngine.UIElements.BackgroundPosition)___parameters[0];
			@to = (UnityEngine.UIElements.BackgroundPosition)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryConvertBackgroundSizeUnits(ref UnityEngine.UIElements.BackgroundSize  @from, ref UnityEngine.UIElements.BackgroundSize  @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize.Invoke(___genericsType, ___parameters);
			@from = (UnityEngine.UIElements.BackgroundSize)___parameters[0];
			@to = (UnityEngine.UIElements.BackgroundSize)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual void MarkRenderHintsClean()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMarkRenderHintsClean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateBoundingBox()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateBoundingBox.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateWorldBoundingBox()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateWorldBoundingBox.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateWorldTransform()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateWorldTransform.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateWorldTransformInverse()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateWorldTransformInverse.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnsureWorldTransformAndClipUpToDate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REnsureWorldTransformAndClipUpToDate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Focus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPanel(RUnityEngine.RUIElements.RBaseVisualElementPanel  @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p.Value};
            var ___result = RSetPanel_BaseVisualElementPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendEvent(UnityEngine.UIElements.EventBase  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RSendEvent_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendEvent(UnityEngine.UIElements.EventBase  @e, RType  @dispatchMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @dispatchMode.Value};
            var ___result = RSendEvent_EventBase_DispatchMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IncrementVersion(RType  @changeType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@changeType.Value};
            var ___result = RIncrementVersion_VersionChangeType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeHierarchyChanged(RType  @changeType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@changeType.Value};
            var ___result = RInvokeHierarchyChanged_HierarchyChangeType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SetEnabledFromHierarchy(System.Boolean  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RSetEnabledFromHierarchy_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetEnabled(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetEnabled_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkDirtyRepaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMarkDirtyRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext  @mgc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mgc};
            var ___result = RInvokeGenerateVisualContent_MeshGenerationContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetFullHierarchicalViewDataKey(System.Text.StringBuilder  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RGetFullHierarchicalViewDataKey_StringBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetFullHierarchicalViewDataKey()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetFullHierarchicalViewDataKey.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual T GetOrCreateViewData<T>(System.Object  @existing, System.String  @key) where T : class, new()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@existing, @key};
            var ___result = RGetOrCreateViewData_GT_Object_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T GetOrCreateViewData<T>(UnityEngine.ScriptableObject  @existing, System.String  @key) where T : UnityEngine.ScriptableObject
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@existing, @key};
            var ___result = RGetOrCreateViewData_GT_ScriptableObject_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual void OverwriteFromViewData(System.Object  @obj, System.String  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @key};
            var ___result = ROverwriteFromViewData_Object_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SaveViewData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSaveViewData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsViewDataPersitenceSupportedOnChildren(System.Boolean  @existingState)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@existingState};
            var ___result = RIsViewDataPersitenceSupportedOnChildren_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnViewDataReady(System.Boolean  @enablePersistence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enablePersistence};
            var ___result = ROnViewDataReady_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ContainsPoint(UnityEngine.Vector2  @localPoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localPoint};
            var ___result = RContainsPoint_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Overlaps(UnityEngine.Rect  @rectangle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rectangle};
            var ___result = ROverlaps_Rect.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Vector2 DoMeasure(System.Single  @desiredWidth, RType  @widthMode, System.Single  @desiredHeight, RType  @heightMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desiredWidth, @widthMode.Value, @desiredHeight, @heightMode.Value};
            var ___result = RDoMeasure_Single_MeasureMode_Single_MeasureMode.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.Object Measure(RUnityEngine.RYoga.RYogaNode  @node, System.Single  @width, RType  @widthMode, System.Single  @height, RType  @heightMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node.Value, @width, @widthMode.Value, @height, @heightMode.Value};
            var ___result = RMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetSize(UnityEngine.Vector2  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@size};
            var ___result = RSetSize_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInlineRule(UnityEngine.UIElements.StyleSheet  @sheet, RUnityEngine.RUIElements.RStyleRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheet, @rule.Value};
            var ___result = RSetInlineRule_StyleSheet_StyleRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateInlineRule(UnityEngine.UIElements.StyleSheet  @sheet, RUnityEngine.RUIElements.RStyleRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheet, @rule.Value};
            var ___result = RUpdateInlineRule_StyleSheet_StyleRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputedStyle(ref RUnityEngine.RUIElements.RComputedStyle  @newStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newStyle.Value};
            var ___result = RSetComputedStyle_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@newStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[0]);

            
        }


        public virtual void ResetPositionProperties()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetPositionProperties.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Collections.Generic.IEnumerable<System.String> GetClasses()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetClasses.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<System.String>)___result;
        }


        public virtual System.Collections.Generic.List<System.String> GetClassesForIteration()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetClassesForIteration.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<System.String>)___result;
        }


        public virtual void ClearClassList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearClassList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddToClassList(System.String  @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RAddToClassList_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFromClassList(System.String  @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RRemoveFromClassList_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ToggleInClassList(System.String  @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RToggleInClassList_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableInClassList(System.String  @className, System.Boolean  @enable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className, @enable};
            var ___result = REnableInClassList_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ClassListContains(System.String  @cls)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cls};
            var ___result = RClassListContains_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object FindAncestorUserData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFindAncestorUserData.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetProperty(UnityEngine.PropertyName  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RGetProperty_PropertyName.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetProperty(UnityEngine.PropertyName  @key, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RSetProperty_PropertyName_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasProperty(UnityEngine.PropertyName  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RHasProperty_PropertyName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ApplyPlayerRenderingToEditorElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RApplyPlayerRenderingToEditorElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterAnimation(RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate  @anim)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anim.Value};
            var ___result = RRegisterAnimation_IValueAnimationUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterAnimation(RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate  @anim)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anim.Value};
            var ___result = RUnregisterAnimation_IValueAnimationUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetCachedNextParentWithEventCallback(out UnityEngine.UIElements.VisualElement  @nextParent)
        {
			@nextParent = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nextParent};
            var ___result = RGetCachedNextParentWithEventCallback_Out_VisualElement.Invoke(___genericsType, ___parameters);
			@nextParent = (UnityEngine.UIElements.VisualElement)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasEventCallbacks(RType  @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RHasEventCallbacks_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasParentEventCallbacks(RType  @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RHasParentEventCallbacks_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasParentEventCallbacksOrDefaultActions(RType  @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RHasParentEventCallbacksOrDefaultActions_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasEventCallbacksOrDefaultActions(RType  @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RHasEventCallbacksOrDefaultActions_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasParentEventCallbacksOrDefaultActionAtTarget(RType  @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasEventCallbacksOrDefaultActionAtTarget(RType  @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RHasEventCallbacksOrDefaultActionAtTarget_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasDefaultAction(RType  @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RHasDefaultAction_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ShouldClip()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShouldClip.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Add(UnityEngine.UIElements.VisualElement  @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RAdd_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Insert(System.Int32  @index, UnityEngine.UIElements.VisualElement  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @element};
            var ___result = RInsert_Int32_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Remove(UnityEngine.UIElements.VisualElement  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RRemove_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAt(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RRemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.VisualElement ElementAt(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RElementAt_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual System.Int32 IndexOf(UnityEngine.UIElements.VisualElement  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RIndexOf_VisualElement.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement ElementAtTreePath(System.Collections.Generic.List<System.Int32>  @childIndexes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@childIndexes};
            var ___result = RElementAtTreePath_List_d_Int32_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual System.Boolean FindElementInTree(UnityEngine.UIElements.VisualElement  @element, System.Collections.Generic.List<System.Int32>  @outChildIndexes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @outChildIndexes};
            var ___result = RFindElementInTree_VisualElement_List_d_Int32_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement> Children()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RChildren.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement>)___result;
        }


        public virtual void Sort(System.Comparison<UnityEngine.UIElements.VisualElement>  @comp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comp};
            var ___result = RSort_Comparison_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BringToFront()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBringToFront.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendToBack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendToBack.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlaceBehind(UnityEngine.UIElements.VisualElement  @sibling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sibling};
            var ___result = RPlaceBehind_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlaceInFront(UnityEngine.UIElements.VisualElement  @sibling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sibling};
            var ___result = RPlaceInFront_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFromHierarchy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRemoveFromHierarchy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T GetFirstOfType<T>() where T : class
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetFirstOfType_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T GetFirstAncestorOfType<T>() where T : class
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetFirstAncestorOfType_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetFirstAncestorWhere(System.Predicate<UnityEngine.UIElements.VisualElement>  @predicate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@predicate};
            var ___result = RGetFirstAncestorWhere_Predicate_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual System.Boolean Contains(UnityEngine.UIElements.VisualElement  @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RContains_VisualElement.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement FindCommonAncestor(UnityEngine.UIElements.VisualElement  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RFindCommonAncestor_VisualElement.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetRoot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRoot.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetRootVisualContainer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRootVisualContainer.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetNextElementDepthFirst()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNextElementDepthFirst.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetPreviousElementDepthFirst()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPreviousElementDepthFirst.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement RetargetElement(UnityEngine.UIElements.VisualElement  @retargetAgainst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@retargetAgainst};
            var ___result = RRetargetElement_VisualElement.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual void GetPivotedMatrixWithLayout(out UnityEngine.Matrix4x4  @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = RGetPivotedMatrixWithLayout_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@result = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void AddStyleSheetPath(System.String  @sheetPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheetPath};
            var ___result = RAddStyleSheetPath_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasStyleSheetPath(System.String  @sheetPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheetPath};
            var ___result = RHasStyleSheetPath_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RemoveStyleSheetPath(System.String  @sheetPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheetPath};
            var ___result = RRemoveStyleSheetPath_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blur()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBlur.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BlurImmediately()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBlurImmediately.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteDefaultActionDisabled(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RExecuteDefaultActionDisabled_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType>  @callback, UnityEngine.UIElements.TrickleDown  @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType)};
            var ___parameters = new object[]{@callback, @useTrickleDown};
            var ___result = RRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterCallback<TEventType, TUserArgsType>(UnityEngine.UIElements.EventCallback<TEventType, TUserArgsType>  @callback, TUserArgsType  @userArgs, UnityEngine.UIElements.TrickleDown  @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType), typeof(TUserArgsType)};
            var ___parameters = new object[]{@callback, @userArgs, @useTrickleDown};
            var ___result = RRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType>  @callback, RType  @invokePolicy, UnityEngine.UIElements.TrickleDown  @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType)};
            var ___parameters = new object[]{@callback, @invokePolicy.Value, @useTrickleDown};
            var ___result = RRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType>  @callback, UnityEngine.UIElements.TrickleDown  @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType)};
            var ___parameters = new object[]{@callback, @useTrickleDown};
            var ___result = RUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterCallback<TEventType, TUserArgsType>(UnityEngine.UIElements.EventCallback<TEventType, TUserArgsType>  @callback, UnityEngine.UIElements.TrickleDown  @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType), typeof(TUserArgsType)};
            var ___parameters = new object[]{@callback, @useTrickleDown};
            var ___result = RUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryGetUserArgs<TEventType, TCallbackArgs>(UnityEngine.UIElements.EventCallback<TEventType, TCallbackArgs>  @callback, UnityEngine.UIElements.TrickleDown  @useTrickleDown, out TCallbackArgs  @userData) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {
			@userData = default;

            var ___genericsType = new Type[] {typeof(TEventType), typeof(TCallbackArgs)};
            var ___parameters = new object[]{@callback, @useTrickleDown, @userData};
            var ___result = RTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs.Invoke(___genericsType, ___parameters);
			@userData = (TCallbackArgs)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual void HandleEventAtTargetPhase(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RHandleEventAtTargetPhase_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleEventAtTargetAndDefaultPhase(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RHandleEventAtTargetAndDefaultPhase_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleEventAtCurrentTargetAndPhase(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RHandleEventAtCurrentTargetAndPhase_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleEventEditorInternal(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RHandleEventEditorInternal_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleEvent(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RHandleEvent_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasTrickleDownHandlers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasTrickleDownHandlers.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasBubbleUpHandlers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasBubbleUpHandlers.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RExecuteDefaultActionAtTarget_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteDefaultActionDisabledAtTarget(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RExecuteDefaultActionDisabledAtTarget_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
