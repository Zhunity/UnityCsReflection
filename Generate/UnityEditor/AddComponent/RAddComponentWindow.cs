using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RAddComponent
{
	/// <summary>
	/// UnityEditor.AddComponent.AddComponentWindow
	/// </summary>
    public partial class RAddComponentWindow : RMember //
    {

		/// <summary>
		/// System.String OpenAddComponentDropdown
		/// </summary>
		protected static RField r_OpenAddComponentDropdown;
		public static RField ROpenAddComponentDropdown
		{
			get
			{
				if(r_OpenAddComponentDropdown == null)
				{
					r_OpenAddComponentDropdown = new( ReleactionUtils.GetType("UnityEditor.AddComponent.AddComponentWindow"), "OpenAddComponentDropdown");
					r_OpenAddComponentDropdown.SetBelong(null);
				}
				return r_OpenAddComponentDropdown;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject[] m_GameObjects
		/// </summary>
		protected RFieldArray<RUnityEngine.RGameObject> r_m_GameObjects;
		public virtual RFieldArray<RUnityEngine.RGameObject> Rm_GameObjects
		{
			get
			{
				if(r_m_GameObjects == null)
				{
					r_m_GameObjects = new(this, "m_GameObjects");
					r_m_GameObjects.SetBelong(this.instance);
				}
				return r_m_GameObjects;
			}
		}

		/// <summary>
		/// System.DateTime m_ComponentOpenTime
		/// </summary>
		protected RSystem.RDateTime r_m_ComponentOpenTime;
		public virtual RSystem.RDateTime Rm_ComponentOpenTime
		{
			get
			{
				if(r_m_ComponentOpenTime == null)
				{
					r_m_ComponentOpenTime = new(this, "m_ComponentOpenTime");
					r_m_ComponentOpenTime.SetBelong(this.instance);
				}
				return r_m_ComponentOpenTime;
			}
		}

		/// <summary>
		/// System.String kComponentSearch
		/// </summary>
		protected static RField r_kComponentSearch;
		public static RField RkComponentSearch
		{
			get
			{
				if(r_kComponentSearch == null)
				{
					r_kComponentSearch = new( ReleactionUtils.GetType("UnityEditor.AddComponent.AddComponentWindow"), "kComponentSearch");
					r_kComponentSearch.SetBelong(null);
				}
				return r_kComponentSearch;
			}
		}

		/// <summary>
		/// System.Int32 kMaxWindowHeight
		/// </summary>
		protected static RField r_kMaxWindowHeight;
		public static RField RkMaxWindowHeight
		{
			get
			{
				if(r_kMaxWindowHeight == null)
				{
					r_kMaxWindowHeight = new( ReleactionUtils.GetType("UnityEditor.AddComponent.AddComponentWindow"), "kMaxWindowHeight");
					r_kMaxWindowHeight.SetBelong(null);
				}
				return r_kMaxWindowHeight;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownState s_State
		/// </summary>
		protected static RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState r_s_State;
		public static RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState Rs_State
		{
			get
			{
				if(r_s_State == null)
				{
					r_s_State = new( ReleactionUtils.GetType("UnityEditor.AddComponent.AddComponentWindow"), "s_State");
					r_s_State.SetBelong(null);
				}
				return r_s_State;
			}
		}

		/// <summary>
		/// System.Boolean <setInitialSelectionPosition>k__BackingField
		/// </summary>
		protected RField r___1__setInitialSelectionPosition__2__k__BackingField;
		public virtual RField R__1__setInitialSelectionPosition__2__k__BackingField
		{
			get
			{
				if(r___1__setInitialSelectionPosition__2__k__BackingField == null)
				{
					r___1__setInitialSelectionPosition__2__k__BackingField = new(this, "<setInitialSelectionPosition>k__BackingField");
					r___1__setInitialSelectionPosition__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__setInitialSelectionPosition__2__k__BackingField;
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
		/// Boolean Show(UnityEngine.Rect, UnityEngine.GameObject[])
		/// </summary>
		protected static RMethod r_RShow_Rect_GameObjectArray;
		public static RMethod RShow_Rect_GameObjectArray
		{
			get
			{
				if(r_RShow_Rect_GameObjectArray == null)
				{
					r_RShow_Rect_GameObjectArray = new( ReleactionUtils.GetType("UnityEditor.AddComponent.AddComponentWindow"), "Show", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GameObject).MakeArrayType());
					r_RShow_Rect_GameObjectArray.SetBelong(null);
				}
				return r_RShow_Rect_GameObjectArray;
			}
		}

		/// <summary>
		/// Void OnEnable()
		/// </summary>
		protected RMethod r_ROnEnable;
		public virtual RMethod ROnEnable
		{
			get
			{
				if(r_ROnEnable == null)
				{
					r_ROnEnable = new(this, "OnEnable", 0);
					r_ROnEnable.SetBelong(this.instance);
				}
				return r_ROnEnable;
			}
		}

		/// <summary>
		/// Void OnItemSelected(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)
		/// </summary>
		protected RMethod r_ROnItemSelected_AdvancedDropdownItem;
		public virtual RMethod ROnItemSelected_AdvancedDropdownItem
		{
			get
			{
				if(r_ROnItemSelected_AdvancedDropdownItem == null)
				{
					r_ROnItemSelected_AdvancedDropdownItem = new(this, "OnItemSelected", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem));
					r_ROnItemSelected_AdvancedDropdownItem.SetBelong(this.instance);
				}
				return r_ROnItemSelected_AdvancedDropdownItem;
			}
		}

		/// <summary>
		/// Void OnDisable()
		/// </summary>
		protected RMethod r_ROnDisable;
		public virtual RMethod ROnDisable
		{
			get
			{
				if(r_ROnDisable == null)
				{
					r_ROnDisable = new(this, "OnDisable", 0);
					r_ROnDisable.SetBelong(this.instance);
				}
				return r_ROnDisable;
			}
		}

		/// <summary>
		/// Void OnGUI()
		/// </summary>
		protected RMethod r_ROnGUI;
		public virtual RMethod ROnGUI
		{
			get
			{
				if(r_ROnGUI == null)
				{
					r_ROnGUI = new(this, "OnGUI", 0);
					r_ROnGUI.SetBelong(this.instance);
				}
				return r_ROnGUI;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 CalculateWindowSize(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RCalculateWindowSize_Rect;
		public virtual RMethod RCalculateWindowSize_Rect
		{
			get
			{
				if(r_RCalculateWindowSize_Rect == null)
				{
					r_RCalculateWindowSize_Rect = new(this, "CalculateWindowSize", 0, typeof(UnityEngine.Rect));
					r_RCalculateWindowSize_Rect.SetBelong(this.instance);
				}
				return r_RCalculateWindowSize_Rect;
			}
		}

		/// <summary>
		/// Boolean SpecialKeyboardHandling(UnityEngine.Event)
		/// </summary>
		protected RMethod r_RSpecialKeyboardHandling_Event;
		public virtual RMethod RSpecialKeyboardHandling_Event
		{
			get
			{
				if(r_RSpecialKeyboardHandling_Event == null)
				{
					r_RSpecialKeyboardHandling_Event = new(this, "SpecialKeyboardHandling", 0, typeof(UnityEngine.Event));
					r_RSpecialKeyboardHandling_Event.SetBelong(this.instance);
				}
				return r_RSpecialKeyboardHandling_Event;
			}
		}

		/// <summary>
		/// Void OnCreateNewScript(UnityEditor.AddComponent.NewScriptDropdownItem)
		/// </summary>
		protected RMethod r_ROnCreateNewScript_NewScriptDropdownItem;
		public virtual RMethod ROnCreateNewScript_NewScriptDropdownItem
		{
			get
			{
				if(r_ROnCreateNewScript_NewScriptDropdownItem == null)
				{
					r_ROnCreateNewScript_NewScriptDropdownItem = new(this, "OnCreateNewScript", 0,  ReleactionUtils.GetType("UnityEditor.AddComponent.NewScriptDropdownItem"));
					r_ROnCreateNewScript_NewScriptDropdownItem.SetBelong(this.instance);
				}
				return r_ROnCreateNewScript_NewScriptDropdownItem;
			}
		}

		/// <summary>
		/// Void SendUsabilityAnalyticsEvent(AnalyticsEventData)
		/// </summary>
		protected RMethod r_RSendUsabilityAnalyticsEvent_AnalyticsEventData;
		public virtual RMethod RSendUsabilityAnalyticsEvent_AnalyticsEventData
		{
			get
			{
				if(r_RSendUsabilityAnalyticsEvent_AnalyticsEventData == null)
				{
					r_RSendUsabilityAnalyticsEvent_AnalyticsEventData = new(this, "SendUsabilityAnalyticsEvent", 0,  ReleactionUtils.GetType("UnityEditor.AddComponent.AddComponentWindow+AnalyticsEventData"));
					r_RSendUsabilityAnalyticsEvent_AnalyticsEventData.SetBelong(this.instance);
				}
				return r_RSendUsabilityAnalyticsEvent_AnalyticsEventData;
			}
		}

		/// <summary>
		/// Boolean ValidateAddComponentMenuItem()
		/// </summary>
		protected static RMethod r_RValidateAddComponentMenuItem;
		public static RMethod RValidateAddComponentMenuItem
		{
			get
			{
				if(r_RValidateAddComponentMenuItem == null)
				{
					r_RValidateAddComponentMenuItem = new( ReleactionUtils.GetType("UnityEditor.AddComponent.AddComponentWindow"), "ValidateAddComponentMenuItem", 0);
					r_RValidateAddComponentMenuItem.SetBelong(null);
				}
				return r_RValidateAddComponentMenuItem;
			}
		}

		/// <summary>
		/// Void ExecuteAddComponentMenuItem()
		/// </summary>
		protected static RMethod r_RExecuteAddComponentMenuItem;
		public static RMethod RExecuteAddComponentMenuItem
		{
			get
			{
				if(r_RExecuteAddComponentMenuItem == null)
				{
					r_RExecuteAddComponentMenuItem = new( ReleactionUtils.GetType("UnityEditor.AddComponent.AddComponentWindow"), "ExecuteAddComponentMenuItem", 0);
					r_RExecuteAddComponentMenuItem.SetBelong(null);
				}
				return r_RExecuteAddComponentMenuItem;
			}
		}

		/// <summary>
		/// UnityEditor.InspectorWindow FirstInspectorWithGameObject()
		/// </summary>
		protected static RMethod r_RFirstInspectorWithGameObject;
		public static RMethod RFirstInspectorWithGameObject
		{
			get
			{
				if(r_RFirstInspectorWithGameObject == null)
				{
					r_RFirstInspectorWithGameObject = new( ReleactionUtils.GetType("UnityEditor.AddComponent.AddComponentWindow"), "FirstInspectorWithGameObject", 0);
					r_RFirstInspectorWithGameObject.SetBelong(null);
				}
				return r_RFirstInspectorWithGameObject;
			}
		}

		/// <summary>
		/// Void set_isSearchFieldDisabled(Boolean)
		/// </summary>
		protected RMethod r_Rset_isSearchFieldDisabled_Boolean;
		public virtual RMethod Rset_isSearchFieldDisabled_Boolean
		{
			get
			{
				if(r_Rset_isSearchFieldDisabled_Boolean == null)
				{
					r_Rset_isSearchFieldDisabled_Boolean = new(this, "set_isSearchFieldDisabled", 0, typeof(System.Boolean));
					r_Rset_isSearchFieldDisabled_Boolean.SetBelong(this.instance);
				}
				return r_Rset_isSearchFieldDisabled_Boolean;
			}
		}

		/// <summary>
		/// Void OnDestroy()
		/// </summary>
		protected RMethod r_ROnDestroy;
		public virtual RMethod ROnDestroy
		{
			get
			{
				if(r_ROnDestroy == null)
				{
					r_ROnDestroy = new(this, "OnDestroy", 0);
					r_ROnDestroy.SetBelong(this.instance);
				}
				return r_ROnDestroy;
			}
		}

		/// <summary>
		/// Void Init(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RInit_Rect;
		public virtual RMethod RInit_Rect
		{
			get
			{
				if(r_RInit_Rect == null)
				{
					r_RInit_Rect = new(this, "Init", 0, typeof(UnityEngine.Rect));
					r_RInit_Rect.SetBelong(this.instance);
				}
				return r_RInit_Rect;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownItem GetSelectedItem()
		/// </summary>
		protected RMethod r_RGetSelectedItem;
		public virtual RMethod RGetSelectedItem
		{
			get
			{
				if(r_RGetSelectedItem == null)
				{
					r_RGetSelectedItem = new(this, "GetSelectedItem", 0);
					r_RGetSelectedItem.SetBelong(this.instance);
				}
				return r_RGetSelectedItem;
			}
		}

		/// <summary>
		/// Void GoToParent()
		/// </summary>
		protected RMethod r_RGoToParent;
		public virtual RMethod RGoToParent
		{
			get
			{
				if(r_RGoToParent == null)
				{
					r_RGoToParent = new(this, "GoToParent", 0);
					r_RGoToParent.SetBelong(this.instance);
				}
				return r_RGoToParent;
			}
		}

		/// <summary>
		/// UnityEditor.DataModeController GetDataModeController_Internal()
		/// </summary>
		protected RMethod r_RGetDataModeController_Internal;
		public virtual RMethod RGetDataModeController_Internal
		{
			get
			{
				if(r_RGetDataModeController_Internal == null)
				{
					r_RGetDataModeController_Internal = new(this, "GetDataModeController_Internal", 0);
					r_RGetDataModeController_Internal.SetBelong(this.instance);
				}
				return r_RGetDataModeController_Internal;
			}
		}

		/// <summary>
		/// Void SaveViewData()
		/// </summary>
		protected RMethod r_RSaveViewData;
		public virtual RMethod RSaveViewData
		{
			get
			{
				if(r_RSaveViewData == null)
				{
					r_RSaveViewData = new(this, "SaveViewData", 0);
					r_RSaveViewData.SetBelong(this.instance);
				}
				return r_RSaveViewData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ISerializableJsonDictionary GetViewDataDictionary()
		/// </summary>
		protected RMethod r_RGetViewDataDictionary;
		public virtual RMethod RGetViewDataDictionary
		{
			get
			{
				if(r_RGetViewDataDictionary == null)
				{
					r_RGetViewDataDictionary = new(this, "GetViewDataDictionary", 0);
					r_RGetViewDataDictionary.SetBelong(this.instance);
				}
				return r_RGetViewDataDictionary;
			}
		}

		/// <summary>
		/// Void DisableViewDataPersistence()
		/// </summary>
		protected RMethod r_RDisableViewDataPersistence;
		public virtual RMethod RDisableViewDataPersistence
		{
			get
			{
				if(r_RDisableViewDataPersistence == null)
				{
					r_RDisableViewDataPersistence = new(this, "DisableViewDataPersistence", 0);
					r_RDisableViewDataPersistence.SetBelong(this.instance);
				}
				return r_RDisableViewDataPersistence;
			}
		}

		/// <summary>
		/// Void ClearPersistentViewData()
		/// </summary>
		protected RMethod r_RClearPersistentViewData;
		public virtual RMethod RClearPersistentViewData
		{
			get
			{
				if(r_RClearPersistentViewData == null)
				{
					r_RClearPersistentViewData = new(this, "ClearPersistentViewData", 0);
					r_RClearPersistentViewData.SetBelong(this.instance);
				}
				return r_RClearPersistentViewData;
			}
		}

		/// <summary>
		/// Void BeginWindows()
		/// </summary>
		protected RMethod r_RBeginWindows;
		public virtual RMethod RBeginWindows
		{
			get
			{
				if(r_RBeginWindows == null)
				{
					r_RBeginWindows = new(this, "BeginWindows", 0);
					r_RBeginWindows.SetBelong(this.instance);
				}
				return r_RBeginWindows;
			}
		}

		/// <summary>
		/// Void EndWindows()
		/// </summary>
		protected RMethod r_REndWindows;
		public virtual RMethod REndWindows
		{
			get
			{
				if(r_REndWindows == null)
				{
					r_REndWindows = new(this, "EndWindows", 0);
					r_REndWindows.SetBelong(this.instance);
				}
				return r_REndWindows;
			}
		}

		/// <summary>
		/// Void OnResized()
		/// </summary>
		protected RMethod r_ROnResized;
		public virtual RMethod ROnResized
		{
			get
			{
				if(r_ROnResized == null)
				{
					r_ROnResized = new(this, "OnResized", 0);
					r_ROnResized.SetBelong(this.instance);
				}
				return r_ROnResized;
			}
		}

		/// <summary>
		/// Void OnBackgroundViewResized(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_ROnBackgroundViewResized_Rect;
		public virtual RMethod ROnBackgroundViewResized_Rect
		{
			get
			{
				if(r_ROnBackgroundViewResized_Rect == null)
				{
					r_ROnBackgroundViewResized_Rect = new(this, "OnBackgroundViewResized", 0, typeof(UnityEngine.Rect));
					r_ROnBackgroundViewResized_Rect.SetBelong(this.instance);
				}
				return r_ROnBackgroundViewResized_Rect;
			}
		}

		/// <summary>
		/// Void CheckForWindowRepaint()
		/// </summary>
		protected RMethod r_RCheckForWindowRepaint;
		public virtual RMethod RCheckForWindowRepaint
		{
			get
			{
				if(r_RCheckForWindowRepaint == null)
				{
					r_RCheckForWindowRepaint = new(this, "CheckForWindowRepaint", 0);
					r_RCheckForWindowRepaint.SetBelong(this.instance);
				}
				return r_RCheckForWindowRepaint;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent GetLocalizedTitleContent()
		/// </summary>
		protected RMethod r_RGetLocalizedTitleContent;
		public virtual RMethod RGetLocalizedTitleContent
		{
			get
			{
				if(r_RGetLocalizedTitleContent == null)
				{
					r_RGetLocalizedTitleContent = new(this, "GetLocalizedTitleContent", 0);
					r_RGetLocalizedTitleContent.SetBelong(this.instance);
				}
				return r_RGetLocalizedTitleContent;
			}
		}

		/// <summary>
		/// Void ShowNotification(UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_RShowNotification_GUIContent;
		public virtual RMethod RShowNotification_GUIContent
		{
			get
			{
				if(r_RShowNotification_GUIContent == null)
				{
					r_RShowNotification_GUIContent = new(this, "ShowNotification", 0, typeof(UnityEngine.GUIContent));
					r_RShowNotification_GUIContent.SetBelong(this.instance);
				}
				return r_RShowNotification_GUIContent;
			}
		}

		/// <summary>
		/// Void ShowNotification(UnityEngine.GUIContent, Double)
		/// </summary>
		protected RMethod r_RShowNotification_GUIContent_Double;
		public virtual RMethod RShowNotification_GUIContent_Double
		{
			get
			{
				if(r_RShowNotification_GUIContent_Double == null)
				{
					r_RShowNotification_GUIContent_Double = new(this, "ShowNotification", 0, typeof(UnityEngine.GUIContent), typeof(System.Double));
					r_RShowNotification_GUIContent_Double.SetBelong(this.instance);
				}
				return r_RShowNotification_GUIContent_Double;
			}
		}

		/// <summary>
		/// Void RemoveNotification()
		/// </summary>
		protected RMethod r_RRemoveNotification;
		public virtual RMethod RRemoveNotification
		{
			get
			{
				if(r_RRemoveNotification == null)
				{
					r_RRemoveNotification = new(this, "RemoveNotification", 0);
					r_RRemoveNotification.SetBelong(this.instance);
				}
				return r_RRemoveNotification;
			}
		}

		/// <summary>
		/// Void DrawNotification()
		/// </summary>
		protected RMethod r_RDrawNotification;
		public virtual RMethod RDrawNotification
		{
			get
			{
				if(r_RDrawNotification == null)
				{
					r_RDrawNotification = new(this, "DrawNotification", 0);
					r_RDrawNotification.SetBelong(this.instance);
				}
				return r_RDrawNotification;
			}
		}

		/// <summary>
		/// Void OnMaximized()
		/// </summary>
		protected RMethod r_ROnMaximized;
		public virtual RMethod ROnMaximized
		{
			get
			{
				if(r_ROnMaximized == null)
				{
					r_ROnMaximized = new(this, "OnMaximized", 0);
					r_ROnMaximized.SetBelong(this.instance);
				}
				return r_ROnMaximized;
			}
		}

		/// <summary>
		/// Boolean CanMaximize()
		/// </summary>
		protected RMethod r_RCanMaximize;
		public virtual RMethod RCanMaximize
		{
			get
			{
				if(r_RCanMaximize == null)
				{
					r_RCanMaximize = new(this, "CanMaximize", 0);
					r_RCanMaximize.SetBelong(this.instance);
				}
				return r_RCanMaximize;
			}
		}

		/// <summary>
		/// Int32 GetNumTabs()
		/// </summary>
		protected RMethod r_RGetNumTabs;
		public virtual RMethod RGetNumTabs
		{
			get
			{
				if(r_RGetNumTabs == null)
				{
					r_RGetNumTabs = new(this, "GetNumTabs", 0);
					r_RGetNumTabs.SetBelong(this.instance);
				}
				return r_RGetNumTabs;
			}
		}

		/// <summary>
		/// Boolean ShowNextTabIfPossible()
		/// </summary>
		protected RMethod r_RShowNextTabIfPossible;
		public virtual RMethod RShowNextTabIfPossible
		{
			get
			{
				if(r_RShowNextTabIfPossible == null)
				{
					r_RShowNextTabIfPossible = new(this, "ShowNextTabIfPossible", 0);
					r_RShowNextTabIfPossible.SetBelong(this.instance);
				}
				return r_RShowNextTabIfPossible;
			}
		}

		/// <summary>
		/// Void ShowTab()
		/// </summary>
		protected RMethod r_RShowTab;
		public virtual RMethod RShowTab
		{
			get
			{
				if(r_RShowTab == null)
				{
					r_RShowTab = new(this, "ShowTab", 0);
					r_RShowTab.SetBelong(this.instance);
				}
				return r_RShowTab;
			}
		}

		/// <summary>
		/// Boolean IsSelectedTab()
		/// </summary>
		protected RMethod r_RIsSelectedTab;
		public virtual RMethod RIsSelectedTab
		{
			get
			{
				if(r_RIsSelectedTab == null)
				{
					r_RIsSelectedTab = new(this, "IsSelectedTab", 0);
					r_RIsSelectedTab.SetBelong(this.instance);
				}
				return r_RIsSelectedTab;
			}
		}

		/// <summary>
		/// Void Focus()
		/// </summary>
		protected RMethod r_RFocus;
		public virtual RMethod RFocus
		{
			get
			{
				if(r_RFocus == null)
				{
					r_RFocus = new(this, "Focus", 0);
					r_RFocus.SetBelong(this.instance);
				}
				return r_RFocus;
			}
		}

		/// <summary>
		/// Void MakeParentsSettingsMatchMe()
		/// </summary>
		protected RMethod r_RMakeParentsSettingsMatchMe;
		public virtual RMethod RMakeParentsSettingsMatchMe
		{
			get
			{
				if(r_RMakeParentsSettingsMatchMe == null)
				{
					r_RMakeParentsSettingsMatchMe = new(this, "MakeParentsSettingsMatchMe", 0);
					r_RMakeParentsSettingsMatchMe.SetBelong(this.instance);
				}
				return r_RMakeParentsSettingsMatchMe;
			}
		}

		/// <summary>
		/// Void ShowUtility()
		/// </summary>
		protected RMethod r_RShowUtility;
		public virtual RMethod RShowUtility
		{
			get
			{
				if(r_RShowUtility == null)
				{
					r_RShowUtility = new(this, "ShowUtility", 0);
					r_RShowUtility.SetBelong(this.instance);
				}
				return r_RShowUtility;
			}
		}

		/// <summary>
		/// Void ShowTooltip()
		/// </summary>
		protected RMethod r_RShowTooltip;
		public virtual RMethod RShowTooltip
		{
			get
			{
				if(r_RShowTooltip == null)
				{
					r_RShowTooltip = new(this, "ShowTooltip", 0);
					r_RShowTooltip.SetBelong(this.instance);
				}
				return r_RShowTooltip;
			}
		}

		/// <summary>
		/// Void ShowPopup()
		/// </summary>
		protected RMethod r_RShowPopup;
		public virtual RMethod RShowPopup
		{
			get
			{
				if(r_RShowPopup == null)
				{
					r_RShowPopup = new(this, "ShowPopup", 0);
					r_RShowPopup.SetBelong(this.instance);
				}
				return r_RShowPopup;
			}
		}

		/// <summary>
		/// Void ShowModalUtility()
		/// </summary>
		protected RMethod r_RShowModalUtility;
		public virtual RMethod RShowModalUtility
		{
			get
			{
				if(r_RShowModalUtility == null)
				{
					r_RShowModalUtility = new(this, "ShowModalUtility", 0);
					r_RShowModalUtility.SetBelong(this.instance);
				}
				return r_RShowModalUtility;
			}
		}

		/// <summary>
		/// Void ShowPopupWithMode(UnityEditor.ShowMode, Boolean)
		/// </summary>
		protected RMethod r_RShowPopupWithMode_ShowMode_Boolean;
		public virtual RMethod RShowPopupWithMode_ShowMode_Boolean
		{
			get
			{
				if(r_RShowPopupWithMode_ShowMode_Boolean == null)
				{
					r_RShowPopupWithMode_ShowMode_Boolean = new(this, "ShowPopupWithMode", 0,  ReleactionUtils.GetType("UnityEditor.ShowMode"), typeof(System.Boolean));
					r_RShowPopupWithMode_ShowMode_Boolean.SetBelong(this.instance);
				}
				return r_RShowPopupWithMode_ShowMode_Boolean;
			}
		}

		/// <summary>
		/// Void ShowWithMode(UnityEditor.ShowMode)
		/// </summary>
		protected RMethod r_RShowWithMode_ShowMode;
		public virtual RMethod RShowWithMode_ShowMode
		{
			get
			{
				if(r_RShowWithMode_ShowMode == null)
				{
					r_RShowWithMode_ShowMode = new(this, "ShowWithMode", 0,  ReleactionUtils.GetType("UnityEditor.ShowMode"));
					r_RShowWithMode_ShowMode.SetBelong(this.instance);
				}
				return r_RShowWithMode_ShowMode;
			}
		}

		/// <summary>
		/// Void ShowAsDropDown(UnityEngine.Rect, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RShowAsDropDown_Rect_Vector2;
		public virtual RMethod RShowAsDropDown_Rect_Vector2
		{
			get
			{
				if(r_RShowAsDropDown_Rect_Vector2 == null)
				{
					r_RShowAsDropDown_Rect_Vector2 = new(this, "ShowAsDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2));
					r_RShowAsDropDown_Rect_Vector2.SetBelong(this.instance);
				}
				return r_RShowAsDropDown_Rect_Vector2;
			}
		}

		/// <summary>
		/// Void ShowAsDropDown(UnityEngine.Rect, UnityEngine.Vector2, UnityEditor.PopupLocation[])
		/// </summary>
		protected RMethod r_RShowAsDropDown_Rect_Vector2_PopupLocationArray;
		public virtual RMethod RShowAsDropDown_Rect_Vector2_PopupLocationArray
		{
			get
			{
				if(r_RShowAsDropDown_Rect_Vector2_PopupLocationArray == null)
				{
					r_RShowAsDropDown_Rect_Vector2_PopupLocationArray = new(this, "ShowAsDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2),  ReleactionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType());
					r_RShowAsDropDown_Rect_Vector2_PopupLocationArray.SetBelong(this.instance);
				}
				return r_RShowAsDropDown_Rect_Vector2_PopupLocationArray;
			}
		}

		/// <summary>
		/// Void ShowAsDropDown(UnityEngine.Rect, UnityEngine.Vector2, UnityEditor.PopupLocation[], UnityEditor.ShowMode)
		/// </summary>
		protected RMethod r_RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode;
		public virtual RMethod RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode
		{
			get
			{
				if(r_RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode == null)
				{
					r_RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode = new(this, "ShowAsDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2),  ReleactionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType(),  ReleactionUtils.GetType("UnityEditor.ShowMode"));
					r_RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode.SetBelong(this.instance);
				}
				return r_RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode;
			}
		}

		/// <summary>
		/// Void ShowAsDropDown(UnityEngine.Rect, UnityEngine.Vector2, UnityEditor.PopupLocation[], UnityEditor.ShowMode, Boolean)
		/// </summary>
		protected RMethod r_RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean;
		public virtual RMethod RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean
		{
			get
			{
				if(r_RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean == null)
				{
					r_RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean = new(this, "ShowAsDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2),  ReleactionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType(),  ReleactionUtils.GetType("UnityEditor.ShowMode"), typeof(System.Boolean));
					r_RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean.SetBelong(this.instance);
				}
				return r_RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Rect ShowAsDropDownFitToScreen(UnityEngine.Rect, UnityEngine.Vector2, UnityEditor.PopupLocation[])
		/// </summary>
		protected RMethod r_RShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray;
		public virtual RMethod RShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray
		{
			get
			{
				if(r_RShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray == null)
				{
					r_RShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray = new(this, "ShowAsDropDownFitToScreen", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2),  ReleactionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType());
					r_RShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray.SetBelong(this.instance);
				}
				return r_RShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray;
			}
		}

		/// <summary>
		/// Void Show()
		/// </summary>
		protected RMethod r_RShow;
		public virtual RMethod RShow
		{
			get
			{
				if(r_RShow == null)
				{
					r_RShow = new(this, "Show", 0);
					r_RShow.SetBelong(this.instance);
				}
				return r_RShow;
			}
		}

		/// <summary>
		/// Void Show(Boolean)
		/// </summary>
		protected RMethod r_RShow_Boolean;
		public virtual RMethod RShow_Boolean
		{
			get
			{
				if(r_RShow_Boolean == null)
				{
					r_RShow_Boolean = new(this, "Show", 0, typeof(System.Boolean));
					r_RShow_Boolean.SetBelong(this.instance);
				}
				return r_RShow_Boolean;
			}
		}

		/// <summary>
		/// Void ShowAuxWindow()
		/// </summary>
		protected RMethod r_RShowAuxWindow;
		public virtual RMethod RShowAuxWindow
		{
			get
			{
				if(r_RShowAuxWindow == null)
				{
					r_RShowAuxWindow = new(this, "ShowAuxWindow", 0);
					r_RShowAuxWindow.SetBelong(this.instance);
				}
				return r_RShowAuxWindow;
			}
		}

		/// <summary>
		/// Void ShowModal()
		/// </summary>
		protected RMethod r_RShowModal;
		public virtual RMethod RShowModal
		{
			get
			{
				if(r_RShowModal == null)
				{
					r_RShowModal = new(this, "ShowModal", 0);
					r_RShowModal.SetBelong(this.instance);
				}
				return r_RShowModal;
			}
		}

		/// <summary>
		/// Void RemoveFromDockArea()
		/// </summary>
		protected RMethod r_RRemoveFromDockArea;
		public virtual RMethod RRemoveFromDockArea
		{
			get
			{
				if(r_RRemoveFromDockArea == null)
				{
					r_RRemoveFromDockArea = new(this, "RemoveFromDockArea", 0);
					r_RRemoveFromDockArea.SetBelong(this.instance);
				}
				return r_RRemoveFromDockArea;
			}
		}

		/// <summary>
		/// Void SaveChanges()
		/// </summary>
		protected RMethod r_RSaveChanges;
		public virtual RMethod RSaveChanges
		{
			get
			{
				if(r_RSaveChanges == null)
				{
					r_RSaveChanges = new(this, "SaveChanges", 0);
					r_RSaveChanges.SetBelong(this.instance);
				}
				return r_RSaveChanges;
			}
		}

		/// <summary>
		/// Void DiscardChanges()
		/// </summary>
		protected RMethod r_RDiscardChanges;
		public virtual RMethod RDiscardChanges
		{
			get
			{
				if(r_RDiscardChanges == null)
				{
					r_RDiscardChanges = new(this, "DiscardChanges", 0);
					r_RDiscardChanges.SetBelong(this.instance);
				}
				return r_RDiscardChanges;
			}
		}

		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_RClose;
		public virtual RMethod RClose
		{
			get
			{
				if(r_RClose == null)
				{
					r_RClose = new(this, "Close", 0);
					r_RClose.SetBelong(this.instance);
				}
				return r_RClose;
			}
		}

		/// <summary>
		/// Void Repaint()
		/// </summary>
		protected RMethod r_RRepaint;
		public virtual RMethod RRepaint
		{
			get
			{
				if(r_RRepaint == null)
				{
					r_RRepaint = new(this, "Repaint", 0);
					r_RRepaint.SetBelong(this.instance);
				}
				return r_RRepaint;
			}
		}

		/// <summary>
		/// Void RepaintImmediately()
		/// </summary>
		protected RMethod r_RRepaintImmediately;
		public virtual RMethod RRepaintImmediately
		{
			get
			{
				if(r_RRepaintImmediately == null)
				{
					r_RRepaintImmediately = new(this, "RepaintImmediately", 0);
					r_RRepaintImmediately.SetBelong(this.instance);
				}
				return r_RRepaintImmediately;
			}
		}

		/// <summary>
		/// Void SetParentGameViewDimensions(UnityEngine.Rect, UnityEngine.Rect, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RSetParentGameViewDimensions_Rect_Rect_Vector2;
		public virtual RMethod RSetParentGameViewDimensions_Rect_Rect_Vector2
		{
			get
			{
				if(r_RSetParentGameViewDimensions_Rect_Rect_Vector2 == null)
				{
					r_RSetParentGameViewDimensions_Rect_Rect_Vector2 = new(this, "SetParentGameViewDimensions", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2));
					r_RSetParentGameViewDimensions_Rect_Rect_Vector2.SetBelong(this.instance);
				}
				return r_RSetParentGameViewDimensions_Rect_Rect_Vector2;
			}
		}

		/// <summary>
		/// Void SetPlayModeViewSize(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RSetPlayModeViewSize_Vector2;
		public virtual RMethod RSetPlayModeViewSize_Vector2
		{
			get
			{
				if(r_RSetPlayModeViewSize_Vector2 == null)
				{
					r_RSetPlayModeViewSize_Vector2 = new(this, "SetPlayModeViewSize", 0, typeof(UnityEngine.Vector2));
					r_RSetPlayModeViewSize_Vector2.SetBelong(this.instance);
				}
				return r_RSetPlayModeViewSize_Vector2;
			}
		}

		/// <summary>
		/// Void SetMainPlayModeViewSize(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RSetMainPlayModeViewSize_Vector2;
		public virtual RMethod RSetMainPlayModeViewSize_Vector2
		{
			get
			{
				if(r_RSetMainPlayModeViewSize_Vector2 == null)
				{
					r_RSetMainPlayModeViewSize_Vector2 = new(this, "SetMainPlayModeViewSize", 0, typeof(UnityEngine.Vector2));
					r_RSetMainPlayModeViewSize_Vector2.SetBelong(this.instance);
				}
				return r_RSetMainPlayModeViewSize_Vector2;
			}
		}

		/// <summary>
		/// Void SetDisplayViewSize(Int32, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RSetDisplayViewSize_Int32_Vector2;
		public virtual RMethod RSetDisplayViewSize_Int32_Vector2
		{
			get
			{
				if(r_RSetDisplayViewSize_Int32_Vector2 == null)
				{
					r_RSetDisplayViewSize_Int32_Vector2 = new(this, "SetDisplayViewSize", 0, typeof(System.Int32), typeof(UnityEngine.Vector2));
					r_RSetDisplayViewSize_Int32_Vector2.SetBelong(this.instance);
				}
				return r_RSetDisplayViewSize_Int32_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetDisplayViewSize(Int32)
		/// </summary>
		protected RMethod r_RGetDisplayViewSize_Int32;
		public virtual RMethod RGetDisplayViewSize_Int32
		{
			get
			{
				if(r_RGetDisplayViewSize_Int32 == null)
				{
					r_RGetDisplayViewSize_Int32 = new(this, "GetDisplayViewSize", 0, typeof(System.Int32));
					r_RGetDisplayViewSize_Int32.SetBelong(this.instance);
				}
				return r_RGetDisplayViewSize_Int32;
			}
		}

		/// <summary>
		/// Void SetPlayModeView(Boolean)
		/// </summary>
		protected RMethod r_RSetPlayModeView_Boolean;
		public virtual RMethod RSetPlayModeView_Boolean
		{
			get
			{
				if(r_RSetPlayModeView_Boolean == null)
				{
					r_RSetPlayModeView_Boolean = new(this, "SetPlayModeView", 0, typeof(System.Boolean));
					r_RSetPlayModeView_Boolean.SetBelong(this.instance);
				}
				return r_RSetPlayModeView_Boolean;
			}
		}

		/// <summary>
		/// Boolean SendEvent(UnityEngine.Event)
		/// </summary>
		protected RMethod r_RSendEvent_Event;
		public virtual RMethod RSendEvent_Event
		{
			get
			{
				if(r_RSendEvent_Event == null)
				{
					r_RSendEvent_Event = new(this, "SendEvent", 0, typeof(UnityEngine.Event));
					r_RSendEvent_Event.SetBelong(this.instance);
				}
				return r_RSendEvent_Event;
			}
		}

		/// <summary>
		/// Void AddSceneTab()
		/// </summary>
		protected RMethod r_RAddSceneTab;
		public virtual RMethod RAddSceneTab
		{
			get
			{
				if(r_RAddSceneTab == null)
				{
					r_RAddSceneTab = new(this, "AddSceneTab", 0);
					r_RAddSceneTab.SetBelong(this.instance);
				}
				return r_RAddSceneTab;
			}
		}

		/// <summary>
		/// Void AddGameTab()
		/// </summary>
		protected RMethod r_RAddGameTab;
		public virtual RMethod RAddGameTab
		{
			get
			{
				if(r_RAddGameTab == null)
				{
					r_RAddGameTab = new(this, "AddGameTab", 0);
					r_RAddGameTab.SetBelong(this.instance);
				}
				return r_RAddGameTab;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Type] GetExtraPaneTypes()
		/// </summary>
		protected RMethod r_RGetExtraPaneTypes;
		public virtual RMethod RGetExtraPaneTypes
		{
			get
			{
				if(r_RGetExtraPaneTypes == null)
				{
					r_RGetExtraPaneTypes = new(this, "GetExtraPaneTypes", 0);
					r_RGetExtraPaneTypes.SetBelong(this.instance);
				}
				return r_RGetExtraPaneTypes;
			}
		}

		/// <summary>
		/// Boolean TryGetOverlay(System.String, UnityEditor.Overlays.Overlay ByRef)
		/// </summary>
		protected RMethod r_RTryGetOverlay_String_Out_Overlay;
		public virtual RMethod RTryGetOverlay_String_Out_Overlay
		{
			get
			{
				if(r_RTryGetOverlay_String_Out_Overlay == null)
				{
					r_RTryGetOverlay_String_Out_Overlay = new(this, "TryGetOverlay", 0, typeof(System.String), typeof(UnityEditor.Overlays.Overlay).MakeByRefType());
					r_RTryGetOverlay_String_Out_Overlay.SetBelong(this.instance);
				}
				return r_RTryGetOverlay_String_Out_Overlay;
			}
		}

		/// <summary>
		/// Void OnBackingScaleFactorChangedInternal()
		/// </summary>
		protected RMethod r_ROnBackingScaleFactorChangedInternal;
		public virtual RMethod ROnBackingScaleFactorChangedInternal
		{
			get
			{
				if(r_ROnBackingScaleFactorChangedInternal == null)
				{
					r_ROnBackingScaleFactorChangedInternal = new(this, "OnBackingScaleFactorChangedInternal", 0);
					r_ROnBackingScaleFactorChangedInternal.SetBelong(this.instance);
				}
				return r_ROnBackingScaleFactorChangedInternal;
			}
		}

		/// <summary>
		/// Void OnBackingScaleFactorChanged()
		/// </summary>
		protected RMethod r_ROnBackingScaleFactorChanged;
		public virtual RMethod ROnBackingScaleFactorChanged
		{
			get
			{
				if(r_ROnBackingScaleFactorChanged == null)
				{
					r_ROnBackingScaleFactorChanged = new(this, "OnBackingScaleFactorChanged", 0);
					r_ROnBackingScaleFactorChanged.SetBelong(this.instance);
				}
				return r_ROnBackingScaleFactorChanged;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_RSetDirty;
		public virtual RMethod RSetDirty
		{
			get
			{
				if(r_RSetDirty == null)
				{
					r_RSetDirty = new(this, "SetDirty", 0);
					r_RSetDirty.SetBelong(this.instance);
				}
				return r_RSetDirty;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_RGetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_RGetInstanceID == null)
				{
					r_RGetInstanceID = new(this, "GetInstanceID", 0);
					r_RGetInstanceID.SetBelong(this.instance);
				}
				return r_RGetInstanceID;
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


        public RAddComponentWindow() : base("UnityEditor.AddComponent.AddComponentWindow")
        {
        }

        public RAddComponentWindow(System.Object instance) : base("UnityEditor.AddComponent.AddComponentWindow")
		{
            SetInstance(instance);
		}

        public RAddComponentWindow(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAddComponentWindow(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean Show(UnityEngine.Rect  @rect, UnityEngine.GameObject[]  @gos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @gos};
            var ___result = RShow_Rect_GameObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnEnable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnEnable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnItemSelected(UnityEditor.IMGUI.Controls.AdvancedDropdownItem  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = ROnItemSelected_AdvancedDropdownItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDisable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDisable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 CalculateWindowSize(UnityEngine.Rect  @buttonRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect};
            var ___result = RCalculateWindowSize_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.Boolean SpecialKeyboardHandling(UnityEngine.Event  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RSpecialKeyboardHandling_Event.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }




        public static System.Boolean ValidateAddComponentMenuItem()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RValidateAddComponentMenuItem.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void ExecuteAddComponentMenuItem()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RExecuteAddComponentMenuItem.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Object FirstInspectorWithGameObject()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFirstInspectorWithGameObject.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void set_isSearchFieldDisabled(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_isSearchFieldDisabled_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDestroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDestroy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Init(UnityEngine.Rect  @buttonRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect};
            var ___result = RInit_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEditor.IMGUI.Controls.AdvancedDropdownItem GetSelectedItem()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSelectedItem.Invoke(___genericsType, ___parameters);

            return (UnityEditor.IMGUI.Controls.AdvancedDropdownItem)___result;
        }


        public virtual void GoToParent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGoToParent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetDataModeController_Internal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDataModeController_Internal.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SaveViewData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSaveViewData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetViewDataDictionary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetViewDataDictionary.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public virtual void OnBackgroundViewResized(UnityEngine.Rect  @pos)
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


        public virtual void ShowNotification(UnityEngine.GUIContent  @notification)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@notification};
            var ___result = RShowNotification_GUIContent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowNotification(UnityEngine.GUIContent  @notification, System.Double  @fadeoutWait)
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




        public virtual void ShowAsDropDown(UnityEngine.Rect  @buttonRect, UnityEngine.Vector2  @windowSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect, @windowSize};
            var ___result = RShowAsDropDown_Rect_Vector2.Invoke(___genericsType, ___parameters);

            
        }






        public virtual void Show()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Show(System.Boolean  @immediateDisplay)
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


        public virtual void SetParentGameViewDimensions(UnityEngine.Rect  @rect, UnityEngine.Rect  @clippedRect, UnityEngine.Vector2  @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @clippedRect, @targetSize};
            var ___result = RSetParentGameViewDimensions_Rect_Rect_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPlayModeViewSize(UnityEngine.Vector2  @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetSize};
            var ___result = RSetPlayModeViewSize_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMainPlayModeViewSize(UnityEngine.Vector2  @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetSize};
            var ___result = RSetMainPlayModeViewSize_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDisplayViewSize(System.Int32  @displayId, UnityEngine.Vector2  @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@displayId, @targetSize};
            var ___result = RSetDisplayViewSize_Int32_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 GetDisplayViewSize(System.Int32  @displayId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@displayId};
            var ___result = RGetDisplayViewSize_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void SetPlayModeView(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetPlayModeView_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SendEvent(UnityEngine.Event  @e)
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


        public virtual System.Boolean TryGetOverlay(System.String  @id, out UnityEditor.Overlays.Overlay  @match)
        {
			match = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @match};
            var ___result = RTryGetOverlay_String_Out_Overlay.Invoke(___genericsType, ___parameters);
			match = (UnityEditor.Overlays.Overlay)___parameters[1];

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


        public virtual System.Boolean Equals(System.Object  @other)
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
