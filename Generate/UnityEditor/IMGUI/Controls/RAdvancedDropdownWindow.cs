using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RIMGUI.RControls
{
	/// <summary>
	/// UnityEditor.IMGUI.Controls.AdvancedDropdownWindow
	/// </summary>
    public partial class RAdvancedDropdownWindow : RMember //
    {

		/// <summary>
		/// System.Action`1[UnityEditor.IMGUI.Controls.AdvancedDropdownWindow] windowClosed
		/// </summary>
		protected REvent r_windowClosed;
		public virtual REvent RwindowClosed
		{
			get
			{
				if(r_windowClosed == null)
				{
					r_windowClosed = new(this, "windowClosed");
					r_windowClosed.SetBelong(this.instance);
				}
				return r_windowClosed;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.IMGUI.Controls.AdvancedDropdownItem] selectionChanged
		/// </summary>
		protected REvent r_selectionChanged;
		public virtual REvent RselectionChanged
		{
			get
			{
				if(r_selectionChanged == null)
				{
					r_selectionChanged = new(this, "selectionChanged");
					r_selectionChanged.SetBelong(this.instance);
				}
				return r_selectionChanged;
			}
		}

		/// <summary>
		/// System.Action selectionCanceled
		/// </summary>
		protected REvent r_selectionCanceled;
		public virtual REvent RselectionCanceled
		{
			get
			{
				if(r_selectionCanceled == null)
				{
					r_selectionCanceled = new(this, "selectionCanceled");
					r_selectionCanceled.SetBelong(this.instance);
				}
				return r_selectionCanceled;
			}
		}

		/// <summary>
		/// System.Single kBorderThickness
		/// </summary>
		protected static RField r_kBorderThickness;
		public static RField RkBorderThickness
		{
			get
			{
				if(r_kBorderThickness == null)
				{
					r_kBorderThickness = new( ReflectionUtils.GetType("UnityEditor.IMGUI.Controls.AdvancedDropdownWindow"), "kBorderThickness");
					r_kBorderThickness.SetBelong(null);
				}
				return r_kBorderThickness;
			}
		}

		/// <summary>
		/// System.Single kRightMargin
		/// </summary>
		protected static RField r_kRightMargin;
		public static RField RkRightMargin
		{
			get
			{
				if(r_kRightMargin == null)
				{
					r_kRightMargin = new( ReflectionUtils.GetType("UnityEditor.IMGUI.Controls.AdvancedDropdownWindow"), "kRightMargin");
					r_kRightMargin.SetBelong(null);
				}
				return r_kRightMargin;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownGUI m_Gui
		/// </summary>
		protected RUnityEditor.RIMGUI.RControls.RAdvancedDropdownGUI r_m_Gui;
		public virtual RUnityEditor.RIMGUI.RControls.RAdvancedDropdownGUI Rm_Gui
		{
			get
			{
				if(r_m_Gui == null)
				{
					r_m_Gui = new(this, "m_Gui");
					r_m_Gui.SetBelong(this.instance);
				}
				return r_m_Gui;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownDataSource m_DataSource
		/// </summary>
		protected RUnityEditor.RIMGUI.RControls.RAdvancedDropdownDataSource r_m_DataSource;
		public virtual RUnityEditor.RIMGUI.RControls.RAdvancedDropdownDataSource Rm_DataSource
		{
			get
			{
				if(r_m_DataSource == null)
				{
					r_m_DataSource = new(this, "m_DataSource");
					r_m_DataSource.SetBelong(this.instance);
				}
				return r_m_DataSource;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownState m_State
		/// </summary>
		protected RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState r_m_State;
		public virtual RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState Rm_State
		{
			get
			{
				if(r_m_State == null)
				{
					r_m_State = new(this, "m_State");
					r_m_State.SetBelong(this.instance);
				}
				return r_m_State;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownItem m_CurrentlyRenderedTree
		/// </summary>
		protected RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem r_m_CurrentlyRenderedTree;
		public virtual RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem Rm_CurrentlyRenderedTree
		{
			get
			{
				if(r_m_CurrentlyRenderedTree == null)
				{
					r_m_CurrentlyRenderedTree = new(this, "m_CurrentlyRenderedTree");
					r_m_CurrentlyRenderedTree.SetBelong(this.instance);
				}
				return r_m_CurrentlyRenderedTree;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownItem m_AnimationTree
		/// </summary>
		protected RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem r_m_AnimationTree;
		public virtual RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem Rm_AnimationTree
		{
			get
			{
				if(r_m_AnimationTree == null)
				{
					r_m_AnimationTree = new(this, "m_AnimationTree");
					r_m_AnimationTree.SetBelong(this.instance);
				}
				return r_m_AnimationTree;
			}
		}

		/// <summary>
		/// System.Single m_NewAnimTarget
		/// </summary>
		protected RField r_m_NewAnimTarget;
		public virtual RField Rm_NewAnimTarget
		{
			get
			{
				if(r_m_NewAnimTarget == null)
				{
					r_m_NewAnimTarget = new(this, "m_NewAnimTarget");
					r_m_NewAnimTarget.SetBelong(this.instance);
				}
				return r_m_NewAnimTarget;
			}
		}

		/// <summary>
		/// System.Int64 m_LastTime
		/// </summary>
		protected RField r_m_LastTime;
		public virtual RField Rm_LastTime
		{
			get
			{
				if(r_m_LastTime == null)
				{
					r_m_LastTime = new(this, "m_LastTime");
					r_m_LastTime.SetBelong(this.instance);
				}
				return r_m_LastTime;
			}
		}

		/// <summary>
		/// System.Boolean m_ScrollToSelected
		/// </summary>
		protected RField r_m_ScrollToSelected;
		public virtual RField Rm_ScrollToSelected
		{
			get
			{
				if(r_m_ScrollToSelected == null)
				{
					r_m_ScrollToSelected = new(this, "m_ScrollToSelected");
					r_m_ScrollToSelected.SetBelong(this.instance);
				}
				return r_m_ScrollToSelected;
			}
		}

		/// <summary>
		/// System.Single m_InitialSelectionPosition
		/// </summary>
		protected RField r_m_InitialSelectionPosition;
		public virtual RField Rm_InitialSelectionPosition
		{
			get
			{
				if(r_m_InitialSelectionPosition == null)
				{
					r_m_InitialSelectionPosition = new(this, "m_InitialSelectionPosition");
					r_m_InitialSelectionPosition.SetBelong(this.instance);
				}
				return r_m_InitialSelectionPosition;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_ButtonRectScreenPos
		/// </summary>
		protected RUnityEngine.RRect r_m_ButtonRectScreenPos;
		public virtual RUnityEngine.RRect Rm_ButtonRectScreenPos
		{
			get
			{
				if(r_m_ButtonRectScreenPos == null)
				{
					r_m_ButtonRectScreenPos = new(this, "m_ButtonRectScreenPos");
					r_m_ButtonRectScreenPos.SetBelong(this.instance);
				}
				return r_m_ButtonRectScreenPos;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Stack`1[UnityEditor.IMGUI.Controls.AdvancedDropdownItem] m_ViewsStack
		/// </summary>
		protected RSystem.RCollections.RGeneric.RStack<RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem> r_m_ViewsStack;
		public virtual RSystem.RCollections.RGeneric.RStack<RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem> Rm_ViewsStack
		{
			get
			{
				if(r_m_ViewsStack == null)
				{
					r_m_ViewsStack = new(this, "m_ViewsStack");
					r_m_ViewsStack.SetBelong(this.instance);
				}
				return r_m_ViewsStack;
			}
		}

		/// <summary>
		/// System.Boolean m_DirtyList
		/// </summary>
		protected RField r_m_DirtyList;
		public virtual RField Rm_DirtyList
		{
			get
			{
				if(r_m_DirtyList == null)
				{
					r_m_DirtyList = new(this, "m_DirtyList");
					r_m_DirtyList.SetBelong(this.instance);
				}
				return r_m_DirtyList;
			}
		}

		/// <summary>
		/// System.String m_Search
		/// </summary>
		protected RField r_m_Search;
		public virtual RField Rm_Search
		{
			get
			{
				if(r_m_Search == null)
				{
					r_m_Search = new(this, "m_Search");
					r_m_Search.SetBelong(this.instance);
				}
				return r_m_Search;
			}
		}

		/// <summary>
		/// System.Boolean <showHeader>k__BackingField
		/// </summary>
		protected RField r___0__showHeader__1__k__BackingField;
		public virtual RField R__0__showHeader__1__k__BackingField
		{
			get
			{
				if(r___0__showHeader__1__k__BackingField == null)
				{
					r___0__showHeader__1__k__BackingField = new(this, "<showHeader>k__BackingField");
					r___0__showHeader__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__showHeader__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <searchable>k__BackingField
		/// </summary>
		protected RField r___0__searchable__1__k__BackingField;
		public virtual RField R__0__searchable__1__k__BackingField
		{
			get
			{
				if(r___0__searchable__1__k__BackingField == null)
				{
					r___0__searchable__1__k__BackingField = new(this, "<searchable>k__BackingField");
					r___0__searchable__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__searchable__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <closeOnSelection>k__BackingField
		/// </summary>
		protected RField r___0__closeOnSelection__1__k__BackingField;
		public virtual RField R__0__closeOnSelection__1__k__BackingField
		{
			get
			{
				if(r___0__closeOnSelection__1__k__BackingField == null)
				{
					r___0__closeOnSelection__1__k__BackingField = new(this, "<closeOnSelection>k__BackingField");
					r___0__closeOnSelection__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__closeOnSelection__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <isSearchFieldDisabled>k__BackingField
		/// </summary>
		protected RField r___0__isSearchFieldDisabled__1__k__BackingField;
		public virtual RField R__0__isSearchFieldDisabled__1__k__BackingField
		{
			get
			{
				if(r___0__isSearchFieldDisabled__1__k__BackingField == null)
				{
					r___0__isSearchFieldDisabled__1__k__BackingField = new(this, "<isSearchFieldDisabled>k__BackingField");
					r___0__isSearchFieldDisabled__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__isSearchFieldDisabled__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <setInitialSelectionPosition>k__BackingField
		/// </summary>
		protected RField r___0__setInitialSelectionPosition__1__k__BackingField;
		public virtual RField R__0__setInitialSelectionPosition__1__k__BackingField
		{
			get
			{
				if(r___0__setInitialSelectionPosition__1__k__BackingField == null)
				{
					r___0__setInitialSelectionPosition__1__k__BackingField = new(this, "<setInitialSelectionPosition>k__BackingField");
					r___0__setInitialSelectionPosition__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__setInitialSelectionPosition__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Func`2[UnityEngine.Event,System.Boolean] specialKeyboardHandling
		/// </summary>
		protected RSystem.RFunc<RUnityEngine.REvent, RField> r_specialKeyboardHandling;
		public virtual RSystem.RFunc<RUnityEngine.REvent, RField> RspecialKeyboardHandling
		{
			get
			{
				if(r_specialKeyboardHandling == null)
				{
					r_specialKeyboardHandling = new(this, "specialKeyboardHandling");
					r_specialKeyboardHandling.SetBelong(this.instance);
				}
				return r_specialKeyboardHandling;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent m_TitleContent
		/// </summary>
		protected RUnityEngine.RGUIContent r_m_TitleContent;
		public virtual RUnityEngine.RGUIContent Rm_TitleContent
		{
			get
			{
				if(r_m_TitleContent == null)
				{
					r_m_TitleContent = new(this, "m_TitleContent");
					r_m_TitleContent.SetBelong(this.instance);
				}
				return r_m_TitleContent;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_Pos
		/// </summary>
		protected RUnityEngine.RRect r_m_Pos;
		public virtual RUnityEngine.RRect Rm_Pos
		{
			get
			{
				if(r_m_Pos == null)
				{
					r_m_Pos = new(this, "m_Pos");
					r_m_Pos.SetBelong(this.instance);
				}
				return r_m_Pos;
			}
		}

		/// <summary>
		/// UnityEditor.DataModeController m_SerializedDataModeController
		/// </summary>
		protected RUnityEditor.RDataModeController r_m_SerializedDataModeController;
		public virtual RUnityEditor.RDataModeController Rm_SerializedDataModeController
		{
			get
			{
				if(r_m_SerializedDataModeController == null)
				{
					r_m_SerializedDataModeController = new(this, "m_SerializedDataModeController");
					r_m_SerializedDataModeController.SetBelong(this.instance);
				}
				return r_m_SerializedDataModeController;
			}
		}

		/// <summary>
		/// UnityEditor.HostView m_Parent
		/// </summary>
		protected RUnityEditor.RHostView r_m_Parent;
		public virtual RUnityEditor.RHostView Rm_Parent
		{
			get
			{
				if(r_m_Parent == null)
				{
					r_m_Parent = new(this, "m_Parent");
					r_m_Parent.SetBelong(this.instance);
				}
				return r_m_Parent;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent m_Notification
		/// </summary>
		protected RUnityEngine.RGUIContent r_m_Notification;
		public virtual RUnityEngine.RGUIContent Rm_Notification
		{
			get
			{
				if(r_m_Notification == null)
				{
					r_m_Notification = new(this, "m_Notification");
					r_m_Notification.SetBelong(this.instance);
				}
				return r_m_Notification;
			}
		}

		/// <summary>
		/// System.Single m_FadeoutTime
		/// </summary>
		protected RField r_m_FadeoutTime;
		public virtual RField Rm_FadeoutTime
		{
			get
			{
				if(r_m_FadeoutTime == null)
				{
					r_m_FadeoutTime = new(this, "m_FadeoutTime");
					r_m_FadeoutTime.SetBelong(this.instance);
				}
				return r_m_FadeoutTime;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownItem renderedTreeItem
		/// </summary>
		protected RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem r_renderedTreeItem;
		public virtual RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem RrenderedTreeItem
		{
			get
			{
				if(r_renderedTreeItem == null)
				{
					r_renderedTreeItem = new(this, "renderedTreeItem", -1);
					r_renderedTreeItem.SetBelong(this.instance);
				}
				return r_renderedTreeItem;
			}
		}

		/// <summary>
		/// Boolean hasSearch
		/// </summary>
		protected RProperty r_hasSearch;
		public virtual RProperty RhasSearch
		{
			get
			{
				if(r_hasSearch == null)
				{
					r_hasSearch = new(this, "hasSearch", -1);
					r_hasSearch.SetBelong(this.instance);
				}
				return r_hasSearch;
			}
		}

		/// <summary>
		/// System.String searchString
		/// </summary>
		protected RProperty r_searchString;
		public virtual RProperty RsearchString
		{
			get
			{
				if(r_searchString == null)
				{
					r_searchString = new(this, "searchString", -1);
					r_searchString.SetBelong(this.instance);
				}
				return r_searchString;
			}
		}

		/// <summary>
		/// Boolean showHeader
		/// </summary>
		protected RProperty r_showHeader;
		public virtual RProperty RshowHeader
		{
			get
			{
				if(r_showHeader == null)
				{
					r_showHeader = new(this, "showHeader", -1);
					r_showHeader.SetBelong(this.instance);
				}
				return r_showHeader;
			}
		}

		/// <summary>
		/// Boolean searchable
		/// </summary>
		protected RProperty r_searchable;
		public virtual RProperty Rsearchable
		{
			get
			{
				if(r_searchable == null)
				{
					r_searchable = new(this, "searchable", -1);
					r_searchable.SetBelong(this.instance);
				}
				return r_searchable;
			}
		}

		/// <summary>
		/// Boolean closeOnSelection
		/// </summary>
		protected RProperty r_closeOnSelection;
		public virtual RProperty RcloseOnSelection
		{
			get
			{
				if(r_closeOnSelection == null)
				{
					r_closeOnSelection = new(this, "closeOnSelection", -1);
					r_closeOnSelection.SetBelong(this.instance);
				}
				return r_closeOnSelection;
			}
		}

		/// <summary>
		/// Boolean isSearchFieldDisabled
		/// </summary>
		protected RProperty r_isSearchFieldDisabled;
		public virtual RProperty RisSearchFieldDisabled
		{
			get
			{
				if(r_isSearchFieldDisabled == null)
				{
					r_isSearchFieldDisabled = new(this, "isSearchFieldDisabled", -1);
					r_isSearchFieldDisabled.SetBelong(this.instance);
				}
				return r_isSearchFieldDisabled;
			}
		}

		/// <summary>
		/// Boolean setInitialSelectionPosition
		/// </summary>
		protected RProperty r_setInitialSelectionPosition;
		public virtual RProperty RsetInitialSelectionPosition
		{
			get
			{
				if(r_setInitialSelectionPosition == null)
				{
					r_setInitialSelectionPosition = new(this, "setInitialSelectionPosition", -1);
					r_setInitialSelectionPosition.SetBelong(this.instance);
				}
				return r_setInitialSelectionPosition;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownState state
		/// </summary>
		protected RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState r_state;
		public virtual RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState Rstate
		{
			get
			{
				if(r_state == null)
				{
					r_state = new(this, "state", -1);
					r_state.SetBelong(this.instance);
				}
				return r_state;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownGUI gui
		/// </summary>
		protected RUnityEditor.RIMGUI.RControls.RAdvancedDropdownGUI r_gui;
		public virtual RUnityEditor.RIMGUI.RControls.RAdvancedDropdownGUI Rgui
		{
			get
			{
				if(r_gui == null)
				{
					r_gui = new(this, "gui", -1);
					r_gui.SetBelong(this.instance);
				}
				return r_gui;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownDataSource dataSource
		/// </summary>
		protected RUnityEditor.RIMGUI.RControls.RAdvancedDropdownDataSource r_dataSource;
		public virtual RUnityEditor.RIMGUI.RControls.RAdvancedDropdownDataSource RdataSource
		{
			get
			{
				if(r_dataSource == null)
				{
					r_dataSource = new(this, "dataSource", -1);
					r_dataSource.SetBelong(this.instance);
				}
				return r_dataSource;
			}
		}

		/// <summary>
		/// UnityEditor.IDataModeController dataModeController
		/// </summary>
		protected RUnityEditor.RIDataModeController r_dataModeController;
		public virtual RUnityEditor.RIDataModeController RdataModeController
		{
			get
			{
				if(r_dataModeController == null)
				{
					r_dataModeController = new(this, "dataModeController", -1);
					r_dataModeController.SetBelong(this.instance);
				}
				return r_dataModeController;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement baseRootVisualElement
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_baseRootVisualElement;
		public virtual RUnityEngine.RUIElements.RVisualElement RbaseRootVisualElement
		{
			get
			{
				if(r_baseRootVisualElement == null)
				{
					r_baseRootVisualElement = new(this, "baseRootVisualElement", -1);
					r_baseRootVisualElement.SetBelong(this.instance);
				}
				return r_baseRootVisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement rootVisualElement
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_rootVisualElement;
		public virtual RUnityEngine.RUIElements.RVisualElement RrootVisualElement
		{
			get
			{
				if(r_rootVisualElement == null)
				{
					r_rootVisualElement = new(this, "rootVisualElement", -1);
					r_rootVisualElement.SetBelong(this.instance);
				}
				return r_rootVisualElement;
			}
		}

		/// <summary>
		/// Boolean liveReloadPreferenceDefault
		/// </summary>
		protected RProperty r_liveReloadPreferenceDefault;
		public virtual RProperty RliveReloadPreferenceDefault
		{
			get
			{
				if(r_liveReloadPreferenceDefault == null)
				{
					r_liveReloadPreferenceDefault = new(this, "liveReloadPreferenceDefault", -1);
					r_liveReloadPreferenceDefault.SetBelong(this.instance);
				}
				return r_liveReloadPreferenceDefault;
			}
		}

		/// <summary>
		/// Boolean isUIToolkitWindow
		/// </summary>
		protected RProperty r_isUIToolkitWindow;
		public virtual RProperty RisUIToolkitWindow
		{
			get
			{
				if(r_isUIToolkitWindow == null)
				{
					r_isUIToolkitWindow = new(this, "isUIToolkitWindow", -1);
					r_isUIToolkitWindow.SetBelong(this.instance);
				}
				return r_isUIToolkitWindow;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayCanvas overlayCanvas
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayCanvas r_overlayCanvas;
		public virtual RUnityEditor.ROverlays.ROverlayCanvas RoverlayCanvas
		{
			get
			{
				if(r_overlayCanvas == null)
				{
					r_overlayCanvas = new(this, "overlayCanvas", -1);
					r_overlayCanvas.SetBelong(this.instance);
				}
				return r_overlayCanvas;
			}
		}

		/// <summary>
		/// UnityEditor.UIElements.SerializableJsonDictionary viewDataDictionary
		/// </summary>
		protected RUnityEditor.RUIElements.RSerializableJsonDictionary r_viewDataDictionary;
		public virtual RUnityEditor.RUIElements.RSerializableJsonDictionary RviewDataDictionary
		{
			get
			{
				if(r_viewDataDictionary == null)
				{
					r_viewDataDictionary = new(this, "viewDataDictionary", -1);
					r_viewDataDictionary.SetBelong(this.instance);
				}
				return r_viewDataDictionary;
			}
		}

		/// <summary>
		/// Boolean wantsMouseMove
		/// </summary>
		protected RProperty r_wantsMouseMove;
		public virtual RProperty RwantsMouseMove
		{
			get
			{
				if(r_wantsMouseMove == null)
				{
					r_wantsMouseMove = new(this, "wantsMouseMove", -1);
					r_wantsMouseMove.SetBelong(this.instance);
				}
				return r_wantsMouseMove;
			}
		}

		/// <summary>
		/// Boolean wantsMouseEnterLeaveWindow
		/// </summary>
		protected RProperty r_wantsMouseEnterLeaveWindow;
		public virtual RProperty RwantsMouseEnterLeaveWindow
		{
			get
			{
				if(r_wantsMouseEnterLeaveWindow == null)
				{
					r_wantsMouseEnterLeaveWindow = new(this, "wantsMouseEnterLeaveWindow", -1);
					r_wantsMouseEnterLeaveWindow.SetBelong(this.instance);
				}
				return r_wantsMouseEnterLeaveWindow;
			}
		}

		/// <summary>
		/// Boolean wantsLessLayoutEvents
		/// </summary>
		protected RProperty r_wantsLessLayoutEvents;
		public virtual RProperty RwantsLessLayoutEvents
		{
			get
			{
				if(r_wantsLessLayoutEvents == null)
				{
					r_wantsLessLayoutEvents = new(this, "wantsLessLayoutEvents", -1);
					r_wantsLessLayoutEvents.SetBelong(this.instance);
				}
				return r_wantsLessLayoutEvents;
			}
		}

		/// <summary>
		/// Boolean autoRepaintOnSceneChange
		/// </summary>
		protected RProperty r_autoRepaintOnSceneChange;
		public virtual RProperty RautoRepaintOnSceneChange
		{
			get
			{
				if(r_autoRepaintOnSceneChange == null)
				{
					r_autoRepaintOnSceneChange = new(this, "autoRepaintOnSceneChange", -1);
					r_autoRepaintOnSceneChange.SetBelong(this.instance);
				}
				return r_autoRepaintOnSceneChange;
			}
		}

		/// <summary>
		/// Boolean maximized
		/// </summary>
		protected RProperty r_maximized;
		public virtual RProperty Rmaximized
		{
			get
			{
				if(r_maximized == null)
				{
					r_maximized = new(this, "maximized", -1);
					r_maximized.SetBelong(this.instance);
				}
				return r_maximized;
			}
		}

		/// <summary>
		/// Boolean hasFocus
		/// </summary>
		protected RProperty r_hasFocus;
		public virtual RProperty RhasFocus
		{
			get
			{
				if(r_hasFocus == null)
				{
					r_hasFocus = new(this, "hasFocus", -1);
					r_hasFocus.SetBelong(this.instance);
				}
				return r_hasFocus;
			}
		}

		/// <summary>
		/// Boolean docked
		/// </summary>
		protected RProperty r_docked;
		public virtual RProperty Rdocked
		{
			get
			{
				if(r_docked == null)
				{
					r_docked = new(this, "docked", -1);
					r_docked.SetBelong(this.instance);
				}
				return r_docked;
			}
		}

		/// <summary>
		/// Boolean disableInputEvents
		/// </summary>
		protected RProperty r_disableInputEvents;
		public virtual RProperty RdisableInputEvents
		{
			get
			{
				if(r_disableInputEvents == null)
				{
					r_disableInputEvents = new(this, "disableInputEvents", -1);
					r_disableInputEvents.SetBelong(this.instance);
				}
				return r_disableInputEvents;
			}
		}

		/// <summary>
		/// Boolean hasUnsavedChanges
		/// </summary>
		protected RProperty r_hasUnsavedChanges;
		public virtual RProperty RhasUnsavedChanges
		{
			get
			{
				if(r_hasUnsavedChanges == null)
				{
					r_hasUnsavedChanges = new(this, "hasUnsavedChanges", -1);
					r_hasUnsavedChanges.SetBelong(this.instance);
				}
				return r_hasUnsavedChanges;
			}
		}

		/// <summary>
		/// System.String saveChangesMessage
		/// </summary>
		protected RProperty r_saveChangesMessage;
		public virtual RProperty RsaveChangesMessage
		{
			get
			{
				if(r_saveChangesMessage == null)
				{
					r_saveChangesMessage = new(this, "saveChangesMessage", -1);
					r_saveChangesMessage.SetBelong(this.instance);
				}
				return r_saveChangesMessage;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 minSize
		/// </summary>
		protected RUnityEngine.RVector2 r_minSize;
		public virtual RUnityEngine.RVector2 RminSize
		{
			get
			{
				if(r_minSize == null)
				{
					r_minSize = new(this, "minSize", -1);
					r_minSize.SetBelong(this.instance);
				}
				return r_minSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 maxSize
		/// </summary>
		protected RUnityEngine.RVector2 r_maxSize;
		public virtual RUnityEngine.RVector2 RmaxSize
		{
			get
			{
				if(r_maxSize == null)
				{
					r_maxSize = new(this, "maxSize", -1);
					r_maxSize.SetBelong(this.instance);
				}
				return r_maxSize;
			}
		}

		/// <summary>
		/// System.String title
		/// </summary>
		protected RProperty r_title;
		public virtual RProperty Rtitle
		{
			get
			{
				if(r_title == null)
				{
					r_title = new(this, "title", -1);
					r_title.SetBelong(this.instance);
				}
				return r_title;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent titleContent
		/// </summary>
		protected RUnityEngine.RGUIContent r_titleContent;
		public virtual RUnityEngine.RGUIContent RtitleContent
		{
			get
			{
				if(r_titleContent == null)
				{
					r_titleContent = new(this, "titleContent", -1);
					r_titleContent.SetBelong(this.instance);
				}
				return r_titleContent;
			}
		}

		/// <summary>
		/// Int32 depthBufferBits
		/// </summary>
		protected RProperty r_depthBufferBits;
		public virtual RProperty RdepthBufferBits
		{
			get
			{
				if(r_depthBufferBits == null)
				{
					r_depthBufferBits = new(this, "depthBufferBits", -1);
					r_depthBufferBits.SetBelong(this.instance);
				}
				return r_depthBufferBits;
			}
		}

		/// <summary>
		/// Int32 antiAliasing
		/// </summary>
		protected RProperty r_antiAliasing;
		public virtual RProperty RantiAliasing
		{
			get
			{
				if(r_antiAliasing == null)
				{
					r_antiAliasing = new(this, "antiAliasing", -1);
					r_antiAliasing.SetBelong(this.instance);
				}
				return r_antiAliasing;
			}
		}

		/// <summary>
		/// Int32 antiAlias
		/// </summary>
		protected RProperty r_antiAlias;
		public virtual RProperty RantiAlias
		{
			get
			{
				if(r_antiAlias == null)
				{
					r_antiAlias = new(this, "antiAlias", -1);
					r_antiAlias.SetBelong(this.instance);
				}
				return r_antiAlias;
			}
		}

		/// <summary>
		/// UnityEngine.Rect position
		/// </summary>
		protected RUnityEngine.RRect r_position;
		public virtual RUnityEngine.RRect Rposition
		{
			get
			{
				if(r_position == null)
				{
					r_position = new(this, "position", -1);
					r_position.SetBelong(this.instance);
				}
				return r_position;
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
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected RProperty r_hideFlags;
		public virtual RProperty RhideFlags
		{
			get
			{
				if(r_hideFlags == null)
				{
					r_hideFlags = new(this, "hideFlags", -1);
					r_hideFlags.SetBelong(this.instance);
				}
				return r_hideFlags;
			}
		}

		/// <summary>
		/// Void OnEnable()
		/// </summary>
		protected RMethod r_OnEnable;
		public virtual RMethod ROnEnable
		{
			get
			{
				if(r_OnEnable == null)
				{
					r_OnEnable = new(this, "OnEnable", 0);
					r_OnEnable.SetBelong(this.instance);
				}
				return r_OnEnable;
			}
		}

		/// <summary>
		/// Void OnDisable()
		/// </summary>
		protected RMethod r_OnDisable;
		public virtual RMethod ROnDisable
		{
			get
			{
				if(r_OnDisable == null)
				{
					r_OnDisable = new(this, "OnDisable", 0);
					r_OnDisable.SetBelong(this.instance);
				}
				return r_OnDisable;
			}
		}

		/// <summary>
		/// Void OnDestroy()
		/// </summary>
		protected RMethod r_OnDestroy;
		public virtual RMethod ROnDestroy
		{
			get
			{
				if(r_OnDestroy == null)
				{
					r_OnDestroy = new(this, "OnDestroy", 0);
					r_OnDestroy.SetBelong(this.instance);
				}
				return r_OnDestroy;
			}
		}

		/// <summary>
		/// T CreateAndInit[T](UnityEngine.Rect, UnityEditor.IMGUI.Controls.AdvancedDropdownState)
		/// </summary>
		protected static RMethod r_CreateAndInit_GT_Rect_AdvancedDropdownState;
		public static RMethod RCreateAndInit_GT_Rect_AdvancedDropdownState
		{
			get
			{
				if(r_CreateAndInit_GT_Rect_AdvancedDropdownState == null)
				{
					r_CreateAndInit_GT_Rect_AdvancedDropdownState = new( ReflectionUtils.GetType("UnityEditor.IMGUI.Controls.AdvancedDropdownWindow"), "CreateAndInit", 1, typeof(UnityEngine.Rect), typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownState));
					r_CreateAndInit_GT_Rect_AdvancedDropdownState.SetBelong(null);
				}
				return r_CreateAndInit_GT_Rect_AdvancedDropdownState;
			}
		}

		/// <summary>
		/// Void Init(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_Init_Rect;
		public virtual RMethod RInit_Rect
		{
			get
			{
				if(r_Init_Rect == null)
				{
					r_Init_Rect = new(this, "Init", 0, typeof(UnityEngine.Rect));
					r_Init_Rect.SetBelong(this.instance);
				}
				return r_Init_Rect;
			}
		}

		/// <summary>
		/// Void SetSelectionFromState()
		/// </summary>
		protected RMethod r_SetSelectionFromState;
		public virtual RMethod RSetSelectionFromState
		{
			get
			{
				if(r_SetSelectionFromState == null)
				{
					r_SetSelectionFromState = new(this, "SetSelectionFromState", 0);
					r_SetSelectionFromState.SetBelong(this.instance);
				}
				return r_SetSelectionFromState;
			}
		}

		/// <summary>
		/// UnityEditor.PopupLocation[] GetLocationPriority()
		/// </summary>
		protected RMethod r_GetLocationPriority;
		public virtual RMethod RGetLocationPriority
		{
			get
			{
				if(r_GetLocationPriority == null)
				{
					r_GetLocationPriority = new(this, "GetLocationPriority", 0);
					r_GetLocationPriority.SetBelong(this.instance);
				}
				return r_GetLocationPriority;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 CalculateWindowSize(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_CalculateWindowSize_Rect;
		public virtual RMethod RCalculateWindowSize_Rect
		{
			get
			{
				if(r_CalculateWindowSize_Rect == null)
				{
					r_CalculateWindowSize_Rect = new(this, "CalculateWindowSize", 0, typeof(UnityEngine.Rect));
					r_CalculateWindowSize_Rect.SetBelong(this.instance);
				}
				return r_CalculateWindowSize_Rect;
			}
		}

		/// <summary>
		/// Void OnGUI()
		/// </summary>
		protected RMethod r_OnGUI;
		public virtual RMethod ROnGUI
		{
			get
			{
				if(r_OnGUI == null)
				{
					r_OnGUI = new(this, "OnGUI", 0);
					r_OnGUI.SetBelong(this.instance);
				}
				return r_OnGUI;
			}
		}

		/// <summary>
		/// Void OnDirtyList()
		/// </summary>
		protected RMethod r_OnDirtyList;
		public virtual RMethod ROnDirtyList
		{
			get
			{
				if(r_OnDirtyList == null)
				{
					r_OnDirtyList = new(this, "OnDirtyList", 0);
					r_OnDirtyList.SetBelong(this.instance);
				}
				return r_OnDirtyList;
			}
		}

		/// <summary>
		/// Void OnGUISearch()
		/// </summary>
		protected RMethod r_OnGUISearch;
		public virtual RMethod ROnGUISearch
		{
			get
			{
				if(r_OnGUISearch == null)
				{
					r_OnGUISearch = new(this, "OnGUISearch", 0);
					r_OnGUISearch.SetBelong(this.instance);
				}
				return r_OnGUISearch;
			}
		}

		/// <summary>
		/// Void HandleKeyboard()
		/// </summary>
		protected RMethod r_HandleKeyboard;
		public virtual RMethod RHandleKeyboard
		{
			get
			{
				if(r_HandleKeyboard == null)
				{
					r_HandleKeyboard = new(this, "HandleKeyboard", 0);
					r_HandleKeyboard.SetBelong(this.instance);
				}
				return r_HandleKeyboard;
			}
		}

		/// <summary>
		/// Void CloseWindow()
		/// </summary>
		protected RMethod r_CloseWindow;
		public virtual RMethod RCloseWindow
		{
			get
			{
				if(r_CloseWindow == null)
				{
					r_CloseWindow = new(this, "CloseWindow", 0);
					r_CloseWindow.SetBelong(this.instance);
				}
				return r_CloseWindow;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownItem GetSelectedItem()
		/// </summary>
		protected RMethod r_GetSelectedItem;
		public virtual RMethod RGetSelectedItem
		{
			get
			{
				if(r_GetSelectedItem == null)
				{
					r_GetSelectedItem = new(this, "GetSelectedItem", 0);
					r_GetSelectedItem.SetBelong(this.instance);
				}
				return r_GetSelectedItem;
			}
		}

		/// <summary>
		/// Boolean SpecialKeyboardHandling(UnityEngine.Event)
		/// </summary>
		protected RMethod r_SpecialKeyboardHandling_Event;
		public virtual RMethod RSpecialKeyboardHandling_Event
		{
			get
			{
				if(r_SpecialKeyboardHandling_Event == null)
				{
					r_SpecialKeyboardHandling_Event = new(this, "SpecialKeyboardHandling", 0, typeof(UnityEngine.Event));
					r_SpecialKeyboardHandling_Event.SetBelong(this.instance);
				}
				return r_SpecialKeyboardHandling_Event;
			}
		}

		/// <summary>
		/// Void DrawDropdown(Single, UnityEditor.IMGUI.Controls.AdvancedDropdownItem)
		/// </summary>
		protected RMethod r_DrawDropdown_Single_AdvancedDropdownItem;
		public virtual RMethod RDrawDropdown_Single_AdvancedDropdownItem
		{
			get
			{
				if(r_DrawDropdown_Single_AdvancedDropdownItem == null)
				{
					r_DrawDropdown_Single_AdvancedDropdownItem = new(this, "DrawDropdown", 0, typeof(System.Single), typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem));
					r_DrawDropdown_Single_AdvancedDropdownItem.SetBelong(this.instance);
				}
				return r_DrawDropdown_Single_AdvancedDropdownItem;
			}
		}

		/// <summary>
		/// Void DrawList(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)
		/// </summary>
		protected RMethod r_DrawList_AdvancedDropdownItem;
		public virtual RMethod RDrawList_AdvancedDropdownItem
		{
			get
			{
				if(r_DrawList_AdvancedDropdownItem == null)
				{
					r_DrawList_AdvancedDropdownItem = new(this, "DrawList", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem));
					r_DrawList_AdvancedDropdownItem.SetBelong(this.instance);
				}
				return r_DrawList_AdvancedDropdownItem;
			}
		}

		/// <summary>
		/// Void GoToParent()
		/// </summary>
		protected RMethod r_GoToParent;
		public virtual RMethod RGoToParent
		{
			get
			{
				if(r_GoToParent == null)
				{
					r_GoToParent = new(this, "GoToParent", 0);
					r_GoToParent.SetBelong(this.instance);
				}
				return r_GoToParent;
			}
		}

		/// <summary>
		/// Void GoToChild()
		/// </summary>
		protected RMethod r_GoToChild;
		public virtual RMethod RGoToChild
		{
			get
			{
				if(r_GoToChild == null)
				{
					r_GoToChild = new(this, "GoToChild", 0);
					r_GoToChild.SetBelong(this.instance);
				}
				return r_GoToChild;
			}
		}

		/// <summary>
		/// Void OnScriptReload()
		/// </summary>
		protected static RMethod r_OnScriptReload;
		public static RMethod ROnScriptReload
		{
			get
			{
				if(r_OnScriptReload == null)
				{
					r_OnScriptReload = new( ReflectionUtils.GetType("UnityEditor.IMGUI.Controls.AdvancedDropdownWindow"), "OnScriptReload", 0);
					r_OnScriptReload.SetBelong(null);
				}
				return r_OnScriptReload;
			}
		}

		/// <summary>
		/// Void CloseAllOpenWindows[T]()
		/// </summary>
		protected static RMethod r_CloseAllOpenWindows_GT;
		public static RMethod RCloseAllOpenWindows_GT
		{
			get
			{
				if(r_CloseAllOpenWindows_GT == null)
				{
					r_CloseAllOpenWindows_GT = new( ReflectionUtils.GetType("UnityEditor.IMGUI.Controls.AdvancedDropdownWindow"), "CloseAllOpenWindows", 1);
					r_CloseAllOpenWindows_GT.SetBelong(null);
				}
				return r_CloseAllOpenWindows_GT;
			}
		}

		/// <summary>
		/// Void <OnGUISearch>b__71_0(System.String)
		/// </summary>
		protected RMethod r___0__OnGUISearch__1__b__71_0_String;
		public virtual RMethod R__0__OnGUISearch__1__b__71_0_String
		{
			get
			{
				if(r___0__OnGUISearch__1__b__71_0_String == null)
				{
					r___0__OnGUISearch__1__b__71_0_String = new(this, "<OnGUISearch>b__71_0", 0, typeof(System.String));
					r___0__OnGUISearch__1__b__71_0_String.SetBelong(this.instance);
				}
				return r___0__OnGUISearch__1__b__71_0_String;
			}
		}

		/// <summary>
		/// UnityEditor.DataModeController GetDataModeController_Internal()
		/// </summary>
		protected RMethod r_GetDataModeController_Internal;
		public virtual RMethod RGetDataModeController_Internal
		{
			get
			{
				if(r_GetDataModeController_Internal == null)
				{
					r_GetDataModeController_Internal = new(this, "GetDataModeController_Internal", 0);
					r_GetDataModeController_Internal.SetBelong(this.instance);
				}
				return r_GetDataModeController_Internal;
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
		/// UnityEngine.UIElements.ISerializableJsonDictionary GetViewDataDictionary()
		/// </summary>
		protected RMethod r_GetViewDataDictionary;
		public virtual RMethod RGetViewDataDictionary
		{
			get
			{
				if(r_GetViewDataDictionary == null)
				{
					r_GetViewDataDictionary = new(this, "GetViewDataDictionary", 0);
					r_GetViewDataDictionary.SetBelong(this.instance);
				}
				return r_GetViewDataDictionary;
			}
		}

		/// <summary>
		/// Void DisableViewDataPersistence()
		/// </summary>
		protected RMethod r_DisableViewDataPersistence;
		public virtual RMethod RDisableViewDataPersistence
		{
			get
			{
				if(r_DisableViewDataPersistence == null)
				{
					r_DisableViewDataPersistence = new(this, "DisableViewDataPersistence", 0);
					r_DisableViewDataPersistence.SetBelong(this.instance);
				}
				return r_DisableViewDataPersistence;
			}
		}

		/// <summary>
		/// Void ClearPersistentViewData()
		/// </summary>
		protected RMethod r_ClearPersistentViewData;
		public virtual RMethod RClearPersistentViewData
		{
			get
			{
				if(r_ClearPersistentViewData == null)
				{
					r_ClearPersistentViewData = new(this, "ClearPersistentViewData", 0);
					r_ClearPersistentViewData.SetBelong(this.instance);
				}
				return r_ClearPersistentViewData;
			}
		}

		/// <summary>
		/// Void BeginWindows()
		/// </summary>
		protected RMethod r_BeginWindows;
		public virtual RMethod RBeginWindows
		{
			get
			{
				if(r_BeginWindows == null)
				{
					r_BeginWindows = new(this, "BeginWindows", 0);
					r_BeginWindows.SetBelong(this.instance);
				}
				return r_BeginWindows;
			}
		}

		/// <summary>
		/// Void EndWindows()
		/// </summary>
		protected RMethod r_EndWindows;
		public virtual RMethod REndWindows
		{
			get
			{
				if(r_EndWindows == null)
				{
					r_EndWindows = new(this, "EndWindows", 0);
					r_EndWindows.SetBelong(this.instance);
				}
				return r_EndWindows;
			}
		}

		/// <summary>
		/// Void OnResized()
		/// </summary>
		protected RMethod r_OnResized;
		public virtual RMethod ROnResized
		{
			get
			{
				if(r_OnResized == null)
				{
					r_OnResized = new(this, "OnResized", 0);
					r_OnResized.SetBelong(this.instance);
				}
				return r_OnResized;
			}
		}

		/// <summary>
		/// Void OnBackgroundViewResized(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_OnBackgroundViewResized_Rect;
		public virtual RMethod ROnBackgroundViewResized_Rect
		{
			get
			{
				if(r_OnBackgroundViewResized_Rect == null)
				{
					r_OnBackgroundViewResized_Rect = new(this, "OnBackgroundViewResized", 0, typeof(UnityEngine.Rect));
					r_OnBackgroundViewResized_Rect.SetBelong(this.instance);
				}
				return r_OnBackgroundViewResized_Rect;
			}
		}

		/// <summary>
		/// Void CheckForWindowRepaint()
		/// </summary>
		protected RMethod r_CheckForWindowRepaint;
		public virtual RMethod RCheckForWindowRepaint
		{
			get
			{
				if(r_CheckForWindowRepaint == null)
				{
					r_CheckForWindowRepaint = new(this, "CheckForWindowRepaint", 0);
					r_CheckForWindowRepaint.SetBelong(this.instance);
				}
				return r_CheckForWindowRepaint;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent GetLocalizedTitleContent()
		/// </summary>
		protected RMethod r_GetLocalizedTitleContent;
		public virtual RMethod RGetLocalizedTitleContent
		{
			get
			{
				if(r_GetLocalizedTitleContent == null)
				{
					r_GetLocalizedTitleContent = new(this, "GetLocalizedTitleContent", 0);
					r_GetLocalizedTitleContent.SetBelong(this.instance);
				}
				return r_GetLocalizedTitleContent;
			}
		}

		/// <summary>
		/// Void ShowNotification(UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_ShowNotification_GUIContent;
		public virtual RMethod RShowNotification_GUIContent
		{
			get
			{
				if(r_ShowNotification_GUIContent == null)
				{
					r_ShowNotification_GUIContent = new(this, "ShowNotification", 0, typeof(UnityEngine.GUIContent));
					r_ShowNotification_GUIContent.SetBelong(this.instance);
				}
				return r_ShowNotification_GUIContent;
			}
		}

		/// <summary>
		/// Void ShowNotification(UnityEngine.GUIContent, Double)
		/// </summary>
		protected RMethod r_ShowNotification_GUIContent_Double;
		public virtual RMethod RShowNotification_GUIContent_Double
		{
			get
			{
				if(r_ShowNotification_GUIContent_Double == null)
				{
					r_ShowNotification_GUIContent_Double = new(this, "ShowNotification", 0, typeof(UnityEngine.GUIContent), typeof(System.Double));
					r_ShowNotification_GUIContent_Double.SetBelong(this.instance);
				}
				return r_ShowNotification_GUIContent_Double;
			}
		}

		/// <summary>
		/// Void RemoveNotification()
		/// </summary>
		protected RMethod r_RemoveNotification;
		public virtual RMethod RRemoveNotification
		{
			get
			{
				if(r_RemoveNotification == null)
				{
					r_RemoveNotification = new(this, "RemoveNotification", 0);
					r_RemoveNotification.SetBelong(this.instance);
				}
				return r_RemoveNotification;
			}
		}

		/// <summary>
		/// Void DrawNotification()
		/// </summary>
		protected RMethod r_DrawNotification;
		public virtual RMethod RDrawNotification
		{
			get
			{
				if(r_DrawNotification == null)
				{
					r_DrawNotification = new(this, "DrawNotification", 0);
					r_DrawNotification.SetBelong(this.instance);
				}
				return r_DrawNotification;
			}
		}

		/// <summary>
		/// Void OnMaximized()
		/// </summary>
		protected RMethod r_OnMaximized;
		public virtual RMethod ROnMaximized
		{
			get
			{
				if(r_OnMaximized == null)
				{
					r_OnMaximized = new(this, "OnMaximized", 0);
					r_OnMaximized.SetBelong(this.instance);
				}
				return r_OnMaximized;
			}
		}

		/// <summary>
		/// Boolean CanMaximize()
		/// </summary>
		protected RMethod r_CanMaximize;
		public virtual RMethod RCanMaximize
		{
			get
			{
				if(r_CanMaximize == null)
				{
					r_CanMaximize = new(this, "CanMaximize", 0);
					r_CanMaximize.SetBelong(this.instance);
				}
				return r_CanMaximize;
			}
		}

		/// <summary>
		/// Int32 GetNumTabs()
		/// </summary>
		protected RMethod r_GetNumTabs;
		public virtual RMethod RGetNumTabs
		{
			get
			{
				if(r_GetNumTabs == null)
				{
					r_GetNumTabs = new(this, "GetNumTabs", 0);
					r_GetNumTabs.SetBelong(this.instance);
				}
				return r_GetNumTabs;
			}
		}

		/// <summary>
		/// Boolean ShowNextTabIfPossible()
		/// </summary>
		protected RMethod r_ShowNextTabIfPossible;
		public virtual RMethod RShowNextTabIfPossible
		{
			get
			{
				if(r_ShowNextTabIfPossible == null)
				{
					r_ShowNextTabIfPossible = new(this, "ShowNextTabIfPossible", 0);
					r_ShowNextTabIfPossible.SetBelong(this.instance);
				}
				return r_ShowNextTabIfPossible;
			}
		}

		/// <summary>
		/// Void ShowTab()
		/// </summary>
		protected RMethod r_ShowTab;
		public virtual RMethod RShowTab
		{
			get
			{
				if(r_ShowTab == null)
				{
					r_ShowTab = new(this, "ShowTab", 0);
					r_ShowTab.SetBelong(this.instance);
				}
				return r_ShowTab;
			}
		}

		/// <summary>
		/// Boolean IsSelectedTab()
		/// </summary>
		protected RMethod r_IsSelectedTab;
		public virtual RMethod RIsSelectedTab
		{
			get
			{
				if(r_IsSelectedTab == null)
				{
					r_IsSelectedTab = new(this, "IsSelectedTab", 0);
					r_IsSelectedTab.SetBelong(this.instance);
				}
				return r_IsSelectedTab;
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
		/// Void MakeParentsSettingsMatchMe()
		/// </summary>
		protected RMethod r_MakeParentsSettingsMatchMe;
		public virtual RMethod RMakeParentsSettingsMatchMe
		{
			get
			{
				if(r_MakeParentsSettingsMatchMe == null)
				{
					r_MakeParentsSettingsMatchMe = new(this, "MakeParentsSettingsMatchMe", 0);
					r_MakeParentsSettingsMatchMe.SetBelong(this.instance);
				}
				return r_MakeParentsSettingsMatchMe;
			}
		}

		/// <summary>
		/// Void ShowUtility()
		/// </summary>
		protected RMethod r_ShowUtility;
		public virtual RMethod RShowUtility
		{
			get
			{
				if(r_ShowUtility == null)
				{
					r_ShowUtility = new(this, "ShowUtility", 0);
					r_ShowUtility.SetBelong(this.instance);
				}
				return r_ShowUtility;
			}
		}

		/// <summary>
		/// Void ShowTooltip()
		/// </summary>
		protected RMethod r_ShowTooltip;
		public virtual RMethod RShowTooltip
		{
			get
			{
				if(r_ShowTooltip == null)
				{
					r_ShowTooltip = new(this, "ShowTooltip", 0);
					r_ShowTooltip.SetBelong(this.instance);
				}
				return r_ShowTooltip;
			}
		}

		/// <summary>
		/// Void ShowPopup()
		/// </summary>
		protected RMethod r_ShowPopup;
		public virtual RMethod RShowPopup
		{
			get
			{
				if(r_ShowPopup == null)
				{
					r_ShowPopup = new(this, "ShowPopup", 0);
					r_ShowPopup.SetBelong(this.instance);
				}
				return r_ShowPopup;
			}
		}

		/// <summary>
		/// Void ShowModalUtility()
		/// </summary>
		protected RMethod r_ShowModalUtility;
		public virtual RMethod RShowModalUtility
		{
			get
			{
				if(r_ShowModalUtility == null)
				{
					r_ShowModalUtility = new(this, "ShowModalUtility", 0);
					r_ShowModalUtility.SetBelong(this.instance);
				}
				return r_ShowModalUtility;
			}
		}

		/// <summary>
		/// Void ShowPopupWithMode(UnityEditor.ShowMode, Boolean)
		/// </summary>
		protected RMethod r_ShowPopupWithMode_ShowMode_Boolean;
		public virtual RMethod RShowPopupWithMode_ShowMode_Boolean
		{
			get
			{
				if(r_ShowPopupWithMode_ShowMode_Boolean == null)
				{
					r_ShowPopupWithMode_ShowMode_Boolean = new(this, "ShowPopupWithMode", 0,  ReflectionUtils.GetType("UnityEditor.ShowMode"), typeof(System.Boolean));
					r_ShowPopupWithMode_ShowMode_Boolean.SetBelong(this.instance);
				}
				return r_ShowPopupWithMode_ShowMode_Boolean;
			}
		}

		/// <summary>
		/// Void ShowWithMode(UnityEditor.ShowMode)
		/// </summary>
		protected RMethod r_ShowWithMode_ShowMode;
		public virtual RMethod RShowWithMode_ShowMode
		{
			get
			{
				if(r_ShowWithMode_ShowMode == null)
				{
					r_ShowWithMode_ShowMode = new(this, "ShowWithMode", 0,  ReflectionUtils.GetType("UnityEditor.ShowMode"));
					r_ShowWithMode_ShowMode.SetBelong(this.instance);
				}
				return r_ShowWithMode_ShowMode;
			}
		}

		/// <summary>
		/// Void ShowAsDropDown(UnityEngine.Rect, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_ShowAsDropDown_Rect_Vector2;
		public virtual RMethod RShowAsDropDown_Rect_Vector2
		{
			get
			{
				if(r_ShowAsDropDown_Rect_Vector2 == null)
				{
					r_ShowAsDropDown_Rect_Vector2 = new(this, "ShowAsDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2));
					r_ShowAsDropDown_Rect_Vector2.SetBelong(this.instance);
				}
				return r_ShowAsDropDown_Rect_Vector2;
			}
		}

		/// <summary>
		/// Void ShowAsDropDown(UnityEngine.Rect, UnityEngine.Vector2, UnityEditor.PopupLocation[])
		/// </summary>
		protected RMethod r_ShowAsDropDown_Rect_Vector2_PopupLocationArray;
		public virtual RMethod RShowAsDropDown_Rect_Vector2_PopupLocationArray
		{
			get
			{
				if(r_ShowAsDropDown_Rect_Vector2_PopupLocationArray == null)
				{
					r_ShowAsDropDown_Rect_Vector2_PopupLocationArray = new(this, "ShowAsDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2),  ReflectionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType());
					r_ShowAsDropDown_Rect_Vector2_PopupLocationArray.SetBelong(this.instance);
				}
				return r_ShowAsDropDown_Rect_Vector2_PopupLocationArray;
			}
		}

		/// <summary>
		/// Void ShowAsDropDown(UnityEngine.Rect, UnityEngine.Vector2, UnityEditor.PopupLocation[], UnityEditor.ShowMode)
		/// </summary>
		protected RMethod r_ShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode;
		public virtual RMethod RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode
		{
			get
			{
				if(r_ShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode == null)
				{
					r_ShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode = new(this, "ShowAsDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2),  ReflectionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType(),  ReflectionUtils.GetType("UnityEditor.ShowMode"));
					r_ShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode.SetBelong(this.instance);
				}
				return r_ShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode;
			}
		}

		/// <summary>
		/// Void ShowAsDropDown(UnityEngine.Rect, UnityEngine.Vector2, UnityEditor.PopupLocation[], UnityEditor.ShowMode, Boolean)
		/// </summary>
		protected RMethod r_ShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean;
		public virtual RMethod RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean
		{
			get
			{
				if(r_ShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean == null)
				{
					r_ShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean = new(this, "ShowAsDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2),  ReflectionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType(),  ReflectionUtils.GetType("UnityEditor.ShowMode"), typeof(System.Boolean));
					r_ShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean.SetBelong(this.instance);
				}
				return r_ShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Rect ShowAsDropDownFitToScreen(UnityEngine.Rect, UnityEngine.Vector2, UnityEditor.PopupLocation[])
		/// </summary>
		protected RMethod r_ShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray;
		public virtual RMethod RShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray
		{
			get
			{
				if(r_ShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray == null)
				{
					r_ShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray = new(this, "ShowAsDropDownFitToScreen", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2),  ReflectionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType());
					r_ShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray.SetBelong(this.instance);
				}
				return r_ShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray;
			}
		}

		/// <summary>
		/// Void Show()
		/// </summary>
		protected RMethod r_Show;
		public virtual RMethod RShow
		{
			get
			{
				if(r_Show == null)
				{
					r_Show = new(this, "Show", 0);
					r_Show.SetBelong(this.instance);
				}
				return r_Show;
			}
		}

		/// <summary>
		/// Void Show(Boolean)
		/// </summary>
		protected RMethod r_Show_Boolean;
		public virtual RMethod RShow_Boolean
		{
			get
			{
				if(r_Show_Boolean == null)
				{
					r_Show_Boolean = new(this, "Show", 0, typeof(System.Boolean));
					r_Show_Boolean.SetBelong(this.instance);
				}
				return r_Show_Boolean;
			}
		}

		/// <summary>
		/// Void ShowAuxWindow()
		/// </summary>
		protected RMethod r_ShowAuxWindow;
		public virtual RMethod RShowAuxWindow
		{
			get
			{
				if(r_ShowAuxWindow == null)
				{
					r_ShowAuxWindow = new(this, "ShowAuxWindow", 0);
					r_ShowAuxWindow.SetBelong(this.instance);
				}
				return r_ShowAuxWindow;
			}
		}

		/// <summary>
		/// Void ShowModal()
		/// </summary>
		protected RMethod r_ShowModal;
		public virtual RMethod RShowModal
		{
			get
			{
				if(r_ShowModal == null)
				{
					r_ShowModal = new(this, "ShowModal", 0);
					r_ShowModal.SetBelong(this.instance);
				}
				return r_ShowModal;
			}
		}

		/// <summary>
		/// Void RemoveFromDockArea()
		/// </summary>
		protected RMethod r_RemoveFromDockArea;
		public virtual RMethod RRemoveFromDockArea
		{
			get
			{
				if(r_RemoveFromDockArea == null)
				{
					r_RemoveFromDockArea = new(this, "RemoveFromDockArea", 0);
					r_RemoveFromDockArea.SetBelong(this.instance);
				}
				return r_RemoveFromDockArea;
			}
		}

		/// <summary>
		/// Void SaveChanges()
		/// </summary>
		protected RMethod r_SaveChanges;
		public virtual RMethod RSaveChanges
		{
			get
			{
				if(r_SaveChanges == null)
				{
					r_SaveChanges = new(this, "SaveChanges", 0);
					r_SaveChanges.SetBelong(this.instance);
				}
				return r_SaveChanges;
			}
		}

		/// <summary>
		/// Void DiscardChanges()
		/// </summary>
		protected RMethod r_DiscardChanges;
		public virtual RMethod RDiscardChanges
		{
			get
			{
				if(r_DiscardChanges == null)
				{
					r_DiscardChanges = new(this, "DiscardChanges", 0);
					r_DiscardChanges.SetBelong(this.instance);
				}
				return r_DiscardChanges;
			}
		}

		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_Close;
		public virtual RMethod RClose
		{
			get
			{
				if(r_Close == null)
				{
					r_Close = new(this, "Close", 0);
					r_Close.SetBelong(this.instance);
				}
				return r_Close;
			}
		}

		/// <summary>
		/// Void Repaint()
		/// </summary>
		protected RMethod r_Repaint;
		public virtual RMethod RRepaint
		{
			get
			{
				if(r_Repaint == null)
				{
					r_Repaint = new(this, "Repaint", 0);
					r_Repaint.SetBelong(this.instance);
				}
				return r_Repaint;
			}
		}

		/// <summary>
		/// Void RepaintImmediately()
		/// </summary>
		protected RMethod r_RepaintImmediately;
		public virtual RMethod RRepaintImmediately
		{
			get
			{
				if(r_RepaintImmediately == null)
				{
					r_RepaintImmediately = new(this, "RepaintImmediately", 0);
					r_RepaintImmediately.SetBelong(this.instance);
				}
				return r_RepaintImmediately;
			}
		}

		/// <summary>
		/// Void SetParentGameViewDimensions(UnityEngine.Rect, UnityEngine.Rect, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_SetParentGameViewDimensions_Rect_Rect_Vector2;
		public virtual RMethod RSetParentGameViewDimensions_Rect_Rect_Vector2
		{
			get
			{
				if(r_SetParentGameViewDimensions_Rect_Rect_Vector2 == null)
				{
					r_SetParentGameViewDimensions_Rect_Rect_Vector2 = new(this, "SetParentGameViewDimensions", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2));
					r_SetParentGameViewDimensions_Rect_Rect_Vector2.SetBelong(this.instance);
				}
				return r_SetParentGameViewDimensions_Rect_Rect_Vector2;
			}
		}

		/// <summary>
		/// Void SetPlayModeViewSize(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_SetPlayModeViewSize_Vector2;
		public virtual RMethod RSetPlayModeViewSize_Vector2
		{
			get
			{
				if(r_SetPlayModeViewSize_Vector2 == null)
				{
					r_SetPlayModeViewSize_Vector2 = new(this, "SetPlayModeViewSize", 0, typeof(UnityEngine.Vector2));
					r_SetPlayModeViewSize_Vector2.SetBelong(this.instance);
				}
				return r_SetPlayModeViewSize_Vector2;
			}
		}

		/// <summary>
		/// Void SetMainPlayModeViewSize(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_SetMainPlayModeViewSize_Vector2;
		public virtual RMethod RSetMainPlayModeViewSize_Vector2
		{
			get
			{
				if(r_SetMainPlayModeViewSize_Vector2 == null)
				{
					r_SetMainPlayModeViewSize_Vector2 = new(this, "SetMainPlayModeViewSize", 0, typeof(UnityEngine.Vector2));
					r_SetMainPlayModeViewSize_Vector2.SetBelong(this.instance);
				}
				return r_SetMainPlayModeViewSize_Vector2;
			}
		}

		/// <summary>
		/// Void SetDisplayViewSize(Int32, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_SetDisplayViewSize_Int32_Vector2;
		public virtual RMethod RSetDisplayViewSize_Int32_Vector2
		{
			get
			{
				if(r_SetDisplayViewSize_Int32_Vector2 == null)
				{
					r_SetDisplayViewSize_Int32_Vector2 = new(this, "SetDisplayViewSize", 0, typeof(System.Int32), typeof(UnityEngine.Vector2));
					r_SetDisplayViewSize_Int32_Vector2.SetBelong(this.instance);
				}
				return r_SetDisplayViewSize_Int32_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetDisplayViewSize(Int32)
		/// </summary>
		protected RMethod r_GetDisplayViewSize_Int32;
		public virtual RMethod RGetDisplayViewSize_Int32
		{
			get
			{
				if(r_GetDisplayViewSize_Int32 == null)
				{
					r_GetDisplayViewSize_Int32 = new(this, "GetDisplayViewSize", 0, typeof(System.Int32));
					r_GetDisplayViewSize_Int32.SetBelong(this.instance);
				}
				return r_GetDisplayViewSize_Int32;
			}
		}

		/// <summary>
		/// Void SetPlayModeView(Boolean)
		/// </summary>
		protected RMethod r_SetPlayModeView_Boolean;
		public virtual RMethod RSetPlayModeView_Boolean
		{
			get
			{
				if(r_SetPlayModeView_Boolean == null)
				{
					r_SetPlayModeView_Boolean = new(this, "SetPlayModeView", 0, typeof(System.Boolean));
					r_SetPlayModeView_Boolean.SetBelong(this.instance);
				}
				return r_SetPlayModeView_Boolean;
			}
		}

		/// <summary>
		/// Boolean SendEvent(UnityEngine.Event)
		/// </summary>
		protected RMethod r_SendEvent_Event;
		public virtual RMethod RSendEvent_Event
		{
			get
			{
				if(r_SendEvent_Event == null)
				{
					r_SendEvent_Event = new(this, "SendEvent", 0, typeof(UnityEngine.Event));
					r_SendEvent_Event.SetBelong(this.instance);
				}
				return r_SendEvent_Event;
			}
		}

		/// <summary>
		/// Void AddSceneTab()
		/// </summary>
		protected RMethod r_AddSceneTab;
		public virtual RMethod RAddSceneTab
		{
			get
			{
				if(r_AddSceneTab == null)
				{
					r_AddSceneTab = new(this, "AddSceneTab", 0);
					r_AddSceneTab.SetBelong(this.instance);
				}
				return r_AddSceneTab;
			}
		}

		/// <summary>
		/// Void AddGameTab()
		/// </summary>
		protected RMethod r_AddGameTab;
		public virtual RMethod RAddGameTab
		{
			get
			{
				if(r_AddGameTab == null)
				{
					r_AddGameTab = new(this, "AddGameTab", 0);
					r_AddGameTab.SetBelong(this.instance);
				}
				return r_AddGameTab;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Type] GetExtraPaneTypes()
		/// </summary>
		protected RMethod r_GetExtraPaneTypes;
		public virtual RMethod RGetExtraPaneTypes
		{
			get
			{
				if(r_GetExtraPaneTypes == null)
				{
					r_GetExtraPaneTypes = new(this, "GetExtraPaneTypes", 0);
					r_GetExtraPaneTypes.SetBelong(this.instance);
				}
				return r_GetExtraPaneTypes;
			}
		}

		/// <summary>
		/// Boolean TryGetOverlay(System.String, UnityEditor.Overlays.Overlay ByRef)
		/// </summary>
		protected RMethod r_TryGetOverlay_String_Out_Overlay;
		public virtual RMethod RTryGetOverlay_String_Out_Overlay
		{
			get
			{
				if(r_TryGetOverlay_String_Out_Overlay == null)
				{
					r_TryGetOverlay_String_Out_Overlay = new(this, "TryGetOverlay", 0, typeof(System.String), typeof(UnityEditor.Overlays.Overlay).MakeByRefType());
					r_TryGetOverlay_String_Out_Overlay.SetBelong(this.instance);
				}
				return r_TryGetOverlay_String_Out_Overlay;
			}
		}

		/// <summary>
		/// Void OnBackingScaleFactorChangedInternal()
		/// </summary>
		protected RMethod r_OnBackingScaleFactorChangedInternal;
		public virtual RMethod ROnBackingScaleFactorChangedInternal
		{
			get
			{
				if(r_OnBackingScaleFactorChangedInternal == null)
				{
					r_OnBackingScaleFactorChangedInternal = new(this, "OnBackingScaleFactorChangedInternal", 0);
					r_OnBackingScaleFactorChangedInternal.SetBelong(this.instance);
				}
				return r_OnBackingScaleFactorChangedInternal;
			}
		}

		/// <summary>
		/// Void OnBackingScaleFactorChanged()
		/// </summary>
		protected RMethod r_OnBackingScaleFactorChanged;
		public virtual RMethod ROnBackingScaleFactorChanged
		{
			get
			{
				if(r_OnBackingScaleFactorChanged == null)
				{
					r_OnBackingScaleFactorChanged = new(this, "OnBackingScaleFactorChanged", 0);
					r_OnBackingScaleFactorChanged.SetBelong(this.instance);
				}
				return r_OnBackingScaleFactorChanged;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_SetDirty;
		public virtual RMethod RSetDirty
		{
			get
			{
				if(r_SetDirty == null)
				{
					r_SetDirty = new(this, "SetDirty", 0);
					r_SetDirty.SetBelong(this.instance);
				}
				return r_SetDirty;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_GetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_GetInstanceID == null)
				{
					r_GetInstanceID = new(this, "GetInstanceID", 0);
					r_GetInstanceID.SetBelong(this.instance);
				}
				return r_GetInstanceID;
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


        public RAdvancedDropdownWindow() : base("UnityEditor.IMGUI.Controls.AdvancedDropdownWindow")
        {
        }

        public RAdvancedDropdownWindow(System.Object instance) : base("UnityEditor.IMGUI.Controls.AdvancedDropdownWindow")
		{
            SetInstance(instance);
		}

        public RAdvancedDropdownWindow(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAdvancedDropdownWindow(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnEnable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnEnable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDisable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDisable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDestroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDestroy.Invoke(___genericsType, ___parameters);

            
        }


        public static RType CreateAndInit<T>(UnityEngine.Rect @rect, UnityEditor.IMGUI.Controls.AdvancedDropdownState @state)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@rect, @state};
            var ___result = RCreateAndInit_GT_Rect_AdvancedDropdownState.Invoke(___genericsType, ___parameters);

            return new RType(___result);
        }


        public virtual void Init(UnityEngine.Rect @buttonRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect};
            var ___result = RInit_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSelectionFromState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetSelectionFromState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RTypeArray<RType> GetLocationPriority()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLocationPriority.Invoke(___genericsType, ___parameters);

            return new RTypeArray<RType>(___result);
        }


        public virtual UnityEngine.Vector2 CalculateWindowSize(UnityEngine.Rect @buttonRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect};
            var ___result = RCalculateWindowSize_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void OnGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDirtyList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDirtyList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnGUISearch()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnGUISearch.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleKeyboard()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHandleKeyboard.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CloseWindow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCloseWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEditor.IMGUI.Controls.AdvancedDropdownItem GetSelectedItem()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSelectedItem.Invoke(___genericsType, ___parameters);

            return (UnityEditor.IMGUI.Controls.AdvancedDropdownItem)___result;
        }


        public virtual System.Boolean SpecialKeyboardHandling(UnityEngine.Event @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RSpecialKeyboardHandling_Event.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void DrawDropdown(System.Single @anim, UnityEditor.IMGUI.Controls.AdvancedDropdownItem @group)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anim, @group};
            var ___result = RDrawDropdown_Single_AdvancedDropdownItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawList(UnityEditor.IMGUI.Controls.AdvancedDropdownItem @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RDrawList_AdvancedDropdownItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GoToParent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGoToParent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GoToChild()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGoToChild.Invoke(___genericsType, ___parameters);

            
        }


        public static void OnScriptReload()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnScriptReload.Invoke(___genericsType, ___parameters);

            
        }


        public static void CloseAllOpenWindows<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RCloseAllOpenWindows_GT.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__OnGUISearch__1__b__71_0(System.String @newSearch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newSearch};
            var ___result = R__0__OnGUISearch__1__b__71_0_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RUnityEditor.RDataModeController GetDataModeController_Internal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDataModeController_Internal.Invoke(___genericsType, ___parameters);

            return new RUnityEditor.RDataModeController(___result);
        }


        public virtual void SaveViewData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSaveViewData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RUnityEngine.RUIElements.RISerializableJsonDictionary GetViewDataDictionary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetViewDataDictionary.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RISerializableJsonDictionary(___result);
        }


        public virtual void DisableViewDataPersistence()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDisableViewDataPersistence.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearPersistentViewData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearPersistentViewData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginWindows()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBeginWindows.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndWindows()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REndWindows.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnResized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnResized.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBackgroundViewResized(UnityEngine.Rect @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = ROnBackgroundViewResized_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckForWindowRepaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckForWindowRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.GUIContent GetLocalizedTitleContent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLocalizedTitleContent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIContent)___result;
        }


        public virtual void ShowNotification(UnityEngine.GUIContent @notification)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@notification};
            var ___result = RShowNotification_GUIContent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowNotification(UnityEngine.GUIContent @notification, System.Double @fadeoutWait)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@notification, @fadeoutWait};
            var ___result = RShowNotification_GUIContent_Double.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveNotification()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRemoveNotification.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawNotification()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDrawNotification.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMaximized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnMaximized.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CanMaximize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCanMaximize.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetNumTabs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNumTabs.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean ShowNextTabIfPossible()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowNextTabIfPossible.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ShowTab()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowTab.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsSelectedTab()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsSelectedTab.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Focus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MakeParentsSettingsMatchMe()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMakeParentsSettingsMatchMe.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowUtility()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowUtility.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowTooltip()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowTooltip.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowPopup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowPopup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowModalUtility()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowModalUtility.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowPopupWithMode(RType @mode, System.Boolean @giveFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mode.Value, @giveFocus};
            var ___result = RShowPopupWithMode_ShowMode_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowWithMode(RType @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mode.Value};
            var ___result = RShowWithMode_ShowMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowAsDropDown(UnityEngine.Rect @buttonRect, UnityEngine.Vector2 @windowSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect, @windowSize};
            var ___result = RShowAsDropDown_Rect_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowAsDropDown(UnityEngine.Rect @buttonRect, UnityEngine.Vector2 @windowSize, RTypeArray<RType> @locationPriorityOrder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect, @windowSize, @locationPriorityOrder.Value};
            var ___result = RShowAsDropDown_Rect_Vector2_PopupLocationArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowAsDropDown(UnityEngine.Rect @buttonRect, UnityEngine.Vector2 @windowSize, RTypeArray<RType> @locationPriorityOrder, RType @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect, @windowSize, @locationPriorityOrder.Value, @mode.Value};
            var ___result = RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowAsDropDown(UnityEngine.Rect @buttonRect, UnityEngine.Vector2 @windowSize, RTypeArray<RType> @locationPriorityOrder, RType @mode, System.Boolean @giveFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect, @windowSize, @locationPriorityOrder.Value, @mode.Value, @giveFocus};
            var ___result = RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect ShowAsDropDownFitToScreen(UnityEngine.Rect @buttonRect, UnityEngine.Vector2 @windowSize, RTypeArray<RType> @locationPriorityOrder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect, @windowSize, @locationPriorityOrder.Value};
            var ___result = RShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void Show()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Show(System.Boolean @immediateDisplay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@immediateDisplay};
            var ___result = RShow_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowAuxWindow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowAuxWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowModal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowModal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFromDockArea()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRemoveFromDockArea.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SaveChanges()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSaveChanges.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DiscardChanges()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDiscardChanges.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Repaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RepaintImmediately()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRepaintImmediately.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetParentGameViewDimensions(UnityEngine.Rect @rect, UnityEngine.Rect @clippedRect, UnityEngine.Vector2 @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @clippedRect, @targetSize};
            var ___result = RSetParentGameViewDimensions_Rect_Rect_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPlayModeViewSize(UnityEngine.Vector2 @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetSize};
            var ___result = RSetPlayModeViewSize_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMainPlayModeViewSize(UnityEngine.Vector2 @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetSize};
            var ___result = RSetMainPlayModeViewSize_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDisplayViewSize(System.Int32 @displayId, UnityEngine.Vector2 @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@displayId, @targetSize};
            var ___result = RSetDisplayViewSize_Int32_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 GetDisplayViewSize(System.Int32 @displayId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@displayId};
            var ___result = RGetDisplayViewSize_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void SetPlayModeView(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetPlayModeView_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SendEvent(UnityEngine.Event @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RSendEvent_Event.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void AddSceneTab()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAddSceneTab.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddGameTab()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAddGameTab.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.IEnumerable<System.Type> GetExtraPaneTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetExtraPaneTypes.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<System.Type>)___result;
        }


        public virtual System.Boolean TryGetOverlay(System.String @id, out UnityEditor.Overlays.Overlay @match)
        {
			@match = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @match};
            var ___result = RTryGetOverlay_String_Out_Overlay.Invoke(___genericsType, ___parameters);
			@match = (UnityEditor.Overlays.Overlay)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual void OnBackingScaleFactorChangedInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnBackingScaleFactorChangedInternal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBackingScaleFactorChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnBackingScaleFactorChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
