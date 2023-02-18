
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RAddComponent
{
	/// <summary>
	/// UnityEditor.AddComponent.AddComponentWindow
	/// </summary>
    public partial class RAddComponentWindow : RMember //
    {

		/// <summary>
		/// System.Action`1[UnityEditor.IMGUI.Controls.AdvancedDropdownWindow] windowClosed
		/// </summary>
		protected REvent r_EwindowClosed;
		public virtual REvent REwindowClosed
		{
			get
			{
				if(r_EwindowClosed == null)
				{
					r_EwindowClosed = new(this, "windowClosed");
				}
				return r_EwindowClosed;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.IMGUI.Controls.AdvancedDropdownItem] selectionChanged
		/// </summary>
		protected REvent r_EselectionChanged;
		public virtual REvent REselectionChanged
		{
			get
			{
				if(r_EselectionChanged == null)
				{
					r_EselectionChanged = new(this, "selectionChanged");
				}
				return r_EselectionChanged;
			}
		}

		/// <summary>
		/// System.Action selectionCanceled
		/// </summary>
		protected REvent r_EselectionCanceled;
		public virtual REvent REselectionCanceled
		{
			get
			{
				if(r_EselectionCanceled == null)
				{
					r_EselectionCanceled = new(this, "selectionCanceled");
				}
				return r_EselectionCanceled;
			}
		}

		/// <summary>
		/// System.String OpenAddComponentDropdown
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FOpenAddComponentDropdown;
		public static Hvak.Editor.Refleaction.RSystem.RString RFOpenAddComponentDropdown
		{
			get
			{
				if(r_FOpenAddComponentDropdown == null)
				{
					r_FOpenAddComponentDropdown = new( ReflectionUtils.GetType("UnityEditor.AddComponent.AddComponentWindow"), "OpenAddComponentDropdown");
				}
				return r_FOpenAddComponentDropdown;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject[] m_GameObjects
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RGameObject> r_Fm_GameObjects;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RGameObject> RFm_GameObjects
		{
			get
			{
				if(r_Fm_GameObjects == null)
				{
					r_Fm_GameObjects = new(this, "m_GameObjects");
				}
				return r_Fm_GameObjects;
			}
		}

		/// <summary>
		/// System.DateTime m_ComponentOpenTime
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDateTime r_Fm_ComponentOpenTime;
		public virtual Hvak.Editor.Refleaction.RSystem.RDateTime RFm_ComponentOpenTime
		{
			get
			{
				if(r_Fm_ComponentOpenTime == null)
				{
					r_Fm_ComponentOpenTime = new(this, "m_ComponentOpenTime");
				}
				return r_Fm_ComponentOpenTime;
			}
		}

		/// <summary>
		/// System.String kComponentSearch
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FkComponentSearch;
		public static Hvak.Editor.Refleaction.RSystem.RString RFkComponentSearch
		{
			get
			{
				if(r_FkComponentSearch == null)
				{
					r_FkComponentSearch = new( ReflectionUtils.GetType("UnityEditor.AddComponent.AddComponentWindow"), "kComponentSearch");
				}
				return r_FkComponentSearch;
			}
		}

		/// <summary>
		/// System.Int32 kMaxWindowHeight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FkMaxWindowHeight;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFkMaxWindowHeight
		{
			get
			{
				if(r_FkMaxWindowHeight == null)
				{
					r_FkMaxWindowHeight = new( ReflectionUtils.GetType("UnityEditor.AddComponent.AddComponentWindow"), "kMaxWindowHeight");
				}
				return r_FkMaxWindowHeight;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownState s_State
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState r_Fs_State;
		public static Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState RFs_State
		{
			get
			{
				if(r_Fs_State == null)
				{
					r_Fs_State = new( ReflectionUtils.GetType("UnityEditor.AddComponent.AddComponentWindow"), "s_State");
				}
				return r_Fs_State;
			}
		}

		/// <summary>
		/// System.Boolean <setInitialSelectionPosition>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__setInitialSelectionPosition__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__setInitialSelectionPosition__1__k__BackingField
		{
			get
			{
				if(r_F__0__setInitialSelectionPosition__1__k__BackingField == null)
				{
					r_F__0__setInitialSelectionPosition__1__k__BackingField = new(this, "<setInitialSelectionPosition>k__BackingField");
				}
				return r_F__0__setInitialSelectionPosition__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Func`2[UnityEngine.Event,System.Boolean] specialKeyboardHandling
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEngine.REvent, Hvak.Editor.Refleaction.RSystem.RBoolean> r_FspecialKeyboardHandling;
		public virtual Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEngine.REvent, Hvak.Editor.Refleaction.RSystem.RBoolean> RFspecialKeyboardHandling
		{
			get
			{
				if(r_FspecialKeyboardHandling == null)
				{
					r_FspecialKeyboardHandling = new(this, "specialKeyboardHandling");
				}
				return r_FspecialKeyboardHandling;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent m_TitleContent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIContent r_Fm_TitleContent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIContent RFm_TitleContent
		{
			get
			{
				if(r_Fm_TitleContent == null)
				{
					r_Fm_TitleContent = new(this, "m_TitleContent");
				}
				return r_Fm_TitleContent;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_Pos
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Fm_Pos;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFm_Pos
		{
			get
			{
				if(r_Fm_Pos == null)
				{
					r_Fm_Pos = new(this, "m_Pos");
				}
				return r_Fm_Pos;
			}
		}

		/// <summary>
		/// UnityEditor.DataModeController m_SerializedDataModeController
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RDataModeController r_Fm_SerializedDataModeController;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RDataModeController RFm_SerializedDataModeController
		{
			get
			{
				if(r_Fm_SerializedDataModeController == null)
				{
					r_Fm_SerializedDataModeController = new(this, "m_SerializedDataModeController");
				}
				return r_Fm_SerializedDataModeController;
			}
		}

		/// <summary>
		/// UnityEditor.HostView m_Parent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RHostView r_Fm_Parent;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RHostView RFm_Parent
		{
			get
			{
				if(r_Fm_Parent == null)
				{
					r_Fm_Parent = new(this, "m_Parent");
				}
				return r_Fm_Parent;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent m_Notification
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIContent r_Fm_Notification;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIContent RFm_Notification
		{
			get
			{
				if(r_Fm_Notification == null)
				{
					r_Fm_Notification = new(this, "m_Notification");
				}
				return r_Fm_Notification;
			}
		}

		/// <summary>
		/// System.Single m_FadeoutTime
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_FadeoutTime;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_FadeoutTime
		{
			get
			{
				if(r_Fm_FadeoutTime == null)
				{
					r_Fm_FadeoutTime = new(this, "m_FadeoutTime");
				}
				return r_Fm_FadeoutTime;
			}
		}

		/// <summary>
		/// Boolean setInitialSelectionPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PsetInitialSelectionPosition;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPsetInitialSelectionPosition
		{
			get
			{
				if(r_PsetInitialSelectionPosition == null)
				{
					r_PsetInitialSelectionPosition = new(this, "setInitialSelectionPosition", -1);
				}
				return r_PsetInitialSelectionPosition;
			}
		}

		/// <summary>
		/// Boolean isSearchFieldDisabled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisSearchFieldDisabled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisSearchFieldDisabled
		{
			get
			{
				if(r_PisSearchFieldDisabled == null)
				{
					r_PisSearchFieldDisabled = new(this, "isSearchFieldDisabled", -1);
				}
				return r_PisSearchFieldDisabled;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownItem renderedTreeItem
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem r_PrenderedTreeItem;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem RPrenderedTreeItem
		{
			get
			{
				if(r_PrenderedTreeItem == null)
				{
					r_PrenderedTreeItem = new(this, "renderedTreeItem", -1);
				}
				return r_PrenderedTreeItem;
			}
		}

		/// <summary>
		/// System.String searchString
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PsearchString;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPsearchString
		{
			get
			{
				if(r_PsearchString == null)
				{
					r_PsearchString = new(this, "searchString", -1);
				}
				return r_PsearchString;
			}
		}

		/// <summary>
		/// Boolean showHeader
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PshowHeader;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPshowHeader
		{
			get
			{
				if(r_PshowHeader == null)
				{
					r_PshowHeader = new(this, "showHeader", -1);
				}
				return r_PshowHeader;
			}
		}

		/// <summary>
		/// Boolean searchable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Psearchable;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPsearchable
		{
			get
			{
				if(r_Psearchable == null)
				{
					r_Psearchable = new(this, "searchable", -1);
				}
				return r_Psearchable;
			}
		}

		/// <summary>
		/// Boolean closeOnSelection
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PcloseOnSelection;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPcloseOnSelection
		{
			get
			{
				if(r_PcloseOnSelection == null)
				{
					r_PcloseOnSelection = new(this, "closeOnSelection", -1);
				}
				return r_PcloseOnSelection;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownState state
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState r_Pstate;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState RPstate
		{
			get
			{
				if(r_Pstate == null)
				{
					r_Pstate = new(this, "state", -1);
				}
				return r_Pstate;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownGUI gui
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownGUI r_Pgui;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownGUI RPgui
		{
			get
			{
				if(r_Pgui == null)
				{
					r_Pgui = new(this, "gui", -1);
				}
				return r_Pgui;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownDataSource dataSource
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownDataSource r_PdataSource;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownDataSource RPdataSource
		{
			get
			{
				if(r_PdataSource == null)
				{
					r_PdataSource = new(this, "dataSource", -1);
				}
				return r_PdataSource;
			}
		}

		/// <summary>
		/// UnityEditor.IDataModeController dataModeController
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIDataModeController r_PdataModeController;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIDataModeController RPdataModeController
		{
			get
			{
				if(r_PdataModeController == null)
				{
					r_PdataModeController = new(this, "dataModeController", -1);
				}
				return r_PdataModeController;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement baseRootVisualElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PbaseRootVisualElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPbaseRootVisualElement
		{
			get
			{
				if(r_PbaseRootVisualElement == null)
				{
					r_PbaseRootVisualElement = new(this, "baseRootVisualElement", -1);
				}
				return r_PbaseRootVisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement rootVisualElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_ProotVisualElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RProotVisualElement
		{
			get
			{
				if(r_ProotVisualElement == null)
				{
					r_ProotVisualElement = new(this, "rootVisualElement", -1);
				}
				return r_ProotVisualElement;
			}
		}

		/// <summary>
		/// Boolean liveReloadPreferenceDefault
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PliveReloadPreferenceDefault;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPliveReloadPreferenceDefault
		{
			get
			{
				if(r_PliveReloadPreferenceDefault == null)
				{
					r_PliveReloadPreferenceDefault = new(this, "liveReloadPreferenceDefault", -1);
				}
				return r_PliveReloadPreferenceDefault;
			}
		}

		/// <summary>
		/// Boolean isUIToolkitWindow
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisUIToolkitWindow;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisUIToolkitWindow
		{
			get
			{
				if(r_PisUIToolkitWindow == null)
				{
					r_PisUIToolkitWindow = new(this, "isUIToolkitWindow", -1);
				}
				return r_PisUIToolkitWindow;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayCanvas overlayCanvas
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayCanvas r_PoverlayCanvas;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayCanvas RPoverlayCanvas
		{
			get
			{
				if(r_PoverlayCanvas == null)
				{
					r_PoverlayCanvas = new(this, "overlayCanvas", -1);
				}
				return r_PoverlayCanvas;
			}
		}

		/// <summary>
		/// UnityEditor.UIElements.SerializableJsonDictionary viewDataDictionary
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RUIElements.RSerializableJsonDictionary r_PviewDataDictionary;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RUIElements.RSerializableJsonDictionary RPviewDataDictionary
		{
			get
			{
				if(r_PviewDataDictionary == null)
				{
					r_PviewDataDictionary = new(this, "viewDataDictionary", -1);
				}
				return r_PviewDataDictionary;
			}
		}

		/// <summary>
		/// Boolean wantsMouseMove
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PwantsMouseMove;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPwantsMouseMove
		{
			get
			{
				if(r_PwantsMouseMove == null)
				{
					r_PwantsMouseMove = new(this, "wantsMouseMove", -1);
				}
				return r_PwantsMouseMove;
			}
		}

		/// <summary>
		/// Boolean wantsMouseEnterLeaveWindow
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PwantsMouseEnterLeaveWindow;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPwantsMouseEnterLeaveWindow
		{
			get
			{
				if(r_PwantsMouseEnterLeaveWindow == null)
				{
					r_PwantsMouseEnterLeaveWindow = new(this, "wantsMouseEnterLeaveWindow", -1);
				}
				return r_PwantsMouseEnterLeaveWindow;
			}
		}

		/// <summary>
		/// Boolean wantsLessLayoutEvents
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PwantsLessLayoutEvents;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPwantsLessLayoutEvents
		{
			get
			{
				if(r_PwantsLessLayoutEvents == null)
				{
					r_PwantsLessLayoutEvents = new(this, "wantsLessLayoutEvents", -1);
				}
				return r_PwantsLessLayoutEvents;
			}
		}

		/// <summary>
		/// Boolean autoRepaintOnSceneChange
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PautoRepaintOnSceneChange;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPautoRepaintOnSceneChange
		{
			get
			{
				if(r_PautoRepaintOnSceneChange == null)
				{
					r_PautoRepaintOnSceneChange = new(this, "autoRepaintOnSceneChange", -1);
				}
				return r_PautoRepaintOnSceneChange;
			}
		}

		/// <summary>
		/// Boolean maximized
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pmaximized;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPmaximized
		{
			get
			{
				if(r_Pmaximized == null)
				{
					r_Pmaximized = new(this, "maximized", -1);
				}
				return r_Pmaximized;
			}
		}

		/// <summary>
		/// Boolean hasFocus
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasFocus;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasFocus
		{
			get
			{
				if(r_PhasFocus == null)
				{
					r_PhasFocus = new(this, "hasFocus", -1);
				}
				return r_PhasFocus;
			}
		}

		/// <summary>
		/// Boolean docked
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pdocked;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdocked
		{
			get
			{
				if(r_Pdocked == null)
				{
					r_Pdocked = new(this, "docked", -1);
				}
				return r_Pdocked;
			}
		}

		/// <summary>
		/// Boolean disableInputEvents
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PdisableInputEvents;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdisableInputEvents
		{
			get
			{
				if(r_PdisableInputEvents == null)
				{
					r_PdisableInputEvents = new(this, "disableInputEvents", -1);
				}
				return r_PdisableInputEvents;
			}
		}

		/// <summary>
		/// Boolean hasUnsavedChanges
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasUnsavedChanges;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasUnsavedChanges
		{
			get
			{
				if(r_PhasUnsavedChanges == null)
				{
					r_PhasUnsavedChanges = new(this, "hasUnsavedChanges", -1);
				}
				return r_PhasUnsavedChanges;
			}
		}

		/// <summary>
		/// System.String saveChangesMessage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PsaveChangesMessage;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPsaveChangesMessage
		{
			get
			{
				if(r_PsaveChangesMessage == null)
				{
					r_PsaveChangesMessage = new(this, "saveChangesMessage", -1);
				}
				return r_PsaveChangesMessage;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 minSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PminSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPminSize
		{
			get
			{
				if(r_PminSize == null)
				{
					r_PminSize = new(this, "minSize", -1);
				}
				return r_PminSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 maxSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PmaxSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPmaxSize
		{
			get
			{
				if(r_PmaxSize == null)
				{
					r_PmaxSize = new(this, "maxSize", -1);
				}
				return r_PmaxSize;
			}
		}

		/// <summary>
		/// System.String title
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ptitle;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtitle
		{
			get
			{
				if(r_Ptitle == null)
				{
					r_Ptitle = new(this, "title", -1);
				}
				return r_Ptitle;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent titleContent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIContent r_PtitleContent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIContent RPtitleContent
		{
			get
			{
				if(r_PtitleContent == null)
				{
					r_PtitleContent = new(this, "titleContent", -1);
				}
				return r_PtitleContent;
			}
		}

		/// <summary>
		/// Int32 depthBufferBits
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PdepthBufferBits;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPdepthBufferBits
		{
			get
			{
				if(r_PdepthBufferBits == null)
				{
					r_PdepthBufferBits = new(this, "depthBufferBits", -1);
				}
				return r_PdepthBufferBits;
			}
		}

		/// <summary>
		/// Int32 antiAliasing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PantiAliasing;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPantiAliasing
		{
			get
			{
				if(r_PantiAliasing == null)
				{
					r_PantiAliasing = new(this, "antiAliasing", -1);
				}
				return r_PantiAliasing;
			}
		}

		/// <summary>
		/// Int32 antiAlias
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PantiAlias;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPantiAlias
		{
			get
			{
				if(r_PantiAlias == null)
				{
					r_PantiAlias = new(this, "antiAlias", -1);
				}
				return r_PantiAlias;
			}
		}

		/// <summary>
		/// UnityEngine.Rect position
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Pposition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPposition
		{
			get
			{
				if(r_Pposition == null)
				{
					r_Pposition = new(this, "position", -1);
				}
				return r_Pposition;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RHideFlags r_PhideFlags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RHideFlags RPhideFlags
		{
			get
			{
				if(r_PhideFlags == null)
				{
					r_PhideFlags = new(this, "hideFlags", -1);
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// Boolean Show(UnityEngine.Rect, UnityEngine.GameObject[])
		/// </summary>
		protected static RMethod r_MShow_Rect_GameObjectArray;
		public static RMethod RMShow_Rect_GameObjectArray
		{
			get
			{
				if(r_MShow_Rect_GameObjectArray == null)
				{
					r_MShow_Rect_GameObjectArray = new( ReflectionUtils.GetType("UnityEditor.AddComponent.AddComponentWindow"), "Show", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GameObject).MakeArrayType());
				}
				return r_MShow_Rect_GameObjectArray;
			}
		}

		/// <summary>
		/// Void OnEnable()
		/// </summary>
		protected RMethod r_MOnEnable;
		public virtual RMethod RMOnEnable
		{
			get
			{
				if(r_MOnEnable == null)
				{
					r_MOnEnable = new(this, "OnEnable", 0);
				}
				return r_MOnEnable;
			}
		}

		/// <summary>
		/// Void OnItemSelected(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)
		/// </summary>
		protected RMethod r_MOnItemSelected_AdvancedDropdownItem;
		public virtual RMethod RMOnItemSelected_AdvancedDropdownItem
		{
			get
			{
				if(r_MOnItemSelected_AdvancedDropdownItem == null)
				{
					r_MOnItemSelected_AdvancedDropdownItem = new(this, "OnItemSelected", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem));
				}
				return r_MOnItemSelected_AdvancedDropdownItem;
			}
		}

		/// <summary>
		/// Void OnDisable()
		/// </summary>
		protected RMethod r_MOnDisable;
		public virtual RMethod RMOnDisable
		{
			get
			{
				if(r_MOnDisable == null)
				{
					r_MOnDisable = new(this, "OnDisable", 0);
				}
				return r_MOnDisable;
			}
		}

		/// <summary>
		/// Void OnGUI()
		/// </summary>
		protected RMethod r_MOnGUI;
		public virtual RMethod RMOnGUI
		{
			get
			{
				if(r_MOnGUI == null)
				{
					r_MOnGUI = new(this, "OnGUI", 0);
				}
				return r_MOnGUI;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 CalculateWindowSize(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MCalculateWindowSize_Rect;
		public virtual RMethod RMCalculateWindowSize_Rect
		{
			get
			{
				if(r_MCalculateWindowSize_Rect == null)
				{
					r_MCalculateWindowSize_Rect = new(this, "CalculateWindowSize", 0, typeof(UnityEngine.Rect));
				}
				return r_MCalculateWindowSize_Rect;
			}
		}

		/// <summary>
		/// Boolean SpecialKeyboardHandling(UnityEngine.Event)
		/// </summary>
		protected RMethod r_MSpecialKeyboardHandling_Event;
		public virtual RMethod RMSpecialKeyboardHandling_Event
		{
			get
			{
				if(r_MSpecialKeyboardHandling_Event == null)
				{
					r_MSpecialKeyboardHandling_Event = new(this, "SpecialKeyboardHandling", 0, typeof(UnityEngine.Event));
				}
				return r_MSpecialKeyboardHandling_Event;
			}
		}

		/// <summary>
		/// Void OnCreateNewScript(UnityEditor.AddComponent.NewScriptDropdownItem)
		/// </summary>
		protected RMethod r_MOnCreateNewScript_NewScriptDropdownItem;
		public virtual RMethod RMOnCreateNewScript_NewScriptDropdownItem
		{
			get
			{
				if(r_MOnCreateNewScript_NewScriptDropdownItem == null)
				{
					r_MOnCreateNewScript_NewScriptDropdownItem = new(this, "OnCreateNewScript", 0,  ReflectionUtils.GetType("UnityEditor.AddComponent.NewScriptDropdownItem"));
				}
				return r_MOnCreateNewScript_NewScriptDropdownItem;
			}
		}

		/// <summary>
		/// Void SendUsabilityAnalyticsEvent(AnalyticsEventData)
		/// </summary>
		protected RMethod r_MSendUsabilityAnalyticsEvent_AnalyticsEventData;
		public virtual RMethod RMSendUsabilityAnalyticsEvent_AnalyticsEventData
		{
			get
			{
				if(r_MSendUsabilityAnalyticsEvent_AnalyticsEventData == null)
				{
					r_MSendUsabilityAnalyticsEvent_AnalyticsEventData = new(this, "SendUsabilityAnalyticsEvent", 0,  ReflectionUtils.GetType("UnityEditor.AddComponent.AddComponentWindow+AnalyticsEventData"));
				}
				return r_MSendUsabilityAnalyticsEvent_AnalyticsEventData;
			}
		}

		/// <summary>
		/// Boolean ValidateAddComponentMenuItem()
		/// </summary>
		protected static RMethod r_MValidateAddComponentMenuItem;
		public static RMethod RMValidateAddComponentMenuItem
		{
			get
			{
				if(r_MValidateAddComponentMenuItem == null)
				{
					r_MValidateAddComponentMenuItem = new( ReflectionUtils.GetType("UnityEditor.AddComponent.AddComponentWindow"), "ValidateAddComponentMenuItem", 0);
				}
				return r_MValidateAddComponentMenuItem;
			}
		}

		/// <summary>
		/// Void ExecuteAddComponentMenuItem()
		/// </summary>
		protected static RMethod r_MExecuteAddComponentMenuItem;
		public static RMethod RMExecuteAddComponentMenuItem
		{
			get
			{
				if(r_MExecuteAddComponentMenuItem == null)
				{
					r_MExecuteAddComponentMenuItem = new( ReflectionUtils.GetType("UnityEditor.AddComponent.AddComponentWindow"), "ExecuteAddComponentMenuItem", 0);
				}
				return r_MExecuteAddComponentMenuItem;
			}
		}

		/// <summary>
		/// UnityEditor.InspectorWindow FirstInspectorWithGameObject()
		/// </summary>
		protected static RMethod r_MFirstInspectorWithGameObject;
		public static RMethod RMFirstInspectorWithGameObject
		{
			get
			{
				if(r_MFirstInspectorWithGameObject == null)
				{
					r_MFirstInspectorWithGameObject = new( ReflectionUtils.GetType("UnityEditor.AddComponent.AddComponentWindow"), "FirstInspectorWithGameObject", 0);
				}
				return r_MFirstInspectorWithGameObject;
			}
		}

		/// <summary>
		/// Void set_isSearchFieldDisabled(Boolean)
		/// </summary>
		protected RMethod r_Mset_isSearchFieldDisabled_Boolean;
		public virtual RMethod RMset_isSearchFieldDisabled_Boolean
		{
			get
			{
				if(r_Mset_isSearchFieldDisabled_Boolean == null)
				{
					r_Mset_isSearchFieldDisabled_Boolean = new(this, "set_isSearchFieldDisabled", 0, typeof(System.Boolean));
				}
				return r_Mset_isSearchFieldDisabled_Boolean;
			}
		}

		/// <summary>
		/// Void OnDestroy()
		/// </summary>
		protected RMethod r_MOnDestroy;
		public virtual RMethod RMOnDestroy
		{
			get
			{
				if(r_MOnDestroy == null)
				{
					r_MOnDestroy = new(this, "OnDestroy", 0);
				}
				return r_MOnDestroy;
			}
		}

		/// <summary>
		/// Void Init(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MInit_Rect;
		public virtual RMethod RMInit_Rect
		{
			get
			{
				if(r_MInit_Rect == null)
				{
					r_MInit_Rect = new(this, "Init", 0, typeof(UnityEngine.Rect));
				}
				return r_MInit_Rect;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownItem GetSelectedItem()
		/// </summary>
		protected RMethod r_MGetSelectedItem;
		public virtual RMethod RMGetSelectedItem
		{
			get
			{
				if(r_MGetSelectedItem == null)
				{
					r_MGetSelectedItem = new(this, "GetSelectedItem", 0);
				}
				return r_MGetSelectedItem;
			}
		}

		/// <summary>
		/// Void GoToParent()
		/// </summary>
		protected RMethod r_MGoToParent;
		public virtual RMethod RMGoToParent
		{
			get
			{
				if(r_MGoToParent == null)
				{
					r_MGoToParent = new(this, "GoToParent", 0);
				}
				return r_MGoToParent;
			}
		}

		/// <summary>
		/// UnityEditor.DataModeController GetDataModeController_Internal()
		/// </summary>
		protected RMethod r_MGetDataModeController_Internal;
		public virtual RMethod RMGetDataModeController_Internal
		{
			get
			{
				if(r_MGetDataModeController_Internal == null)
				{
					r_MGetDataModeController_Internal = new(this, "GetDataModeController_Internal", 0);
				}
				return r_MGetDataModeController_Internal;
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
				}
				return r_MSaveViewData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ISerializableJsonDictionary GetViewDataDictionary()
		/// </summary>
		protected RMethod r_MGetViewDataDictionary;
		public virtual RMethod RMGetViewDataDictionary
		{
			get
			{
				if(r_MGetViewDataDictionary == null)
				{
					r_MGetViewDataDictionary = new(this, "GetViewDataDictionary", 0);
				}
				return r_MGetViewDataDictionary;
			}
		}

		/// <summary>
		/// Void DisableViewDataPersistence()
		/// </summary>
		protected RMethod r_MDisableViewDataPersistence;
		public virtual RMethod RMDisableViewDataPersistence
		{
			get
			{
				if(r_MDisableViewDataPersistence == null)
				{
					r_MDisableViewDataPersistence = new(this, "DisableViewDataPersistence", 0);
				}
				return r_MDisableViewDataPersistence;
			}
		}

		/// <summary>
		/// Void ClearPersistentViewData()
		/// </summary>
		protected RMethod r_MClearPersistentViewData;
		public virtual RMethod RMClearPersistentViewData
		{
			get
			{
				if(r_MClearPersistentViewData == null)
				{
					r_MClearPersistentViewData = new(this, "ClearPersistentViewData", 0);
				}
				return r_MClearPersistentViewData;
			}
		}

		/// <summary>
		/// Void BeginWindows()
		/// </summary>
		protected RMethod r_MBeginWindows;
		public virtual RMethod RMBeginWindows
		{
			get
			{
				if(r_MBeginWindows == null)
				{
					r_MBeginWindows = new(this, "BeginWindows", 0);
				}
				return r_MBeginWindows;
			}
		}

		/// <summary>
		/// Void EndWindows()
		/// </summary>
		protected RMethod r_MEndWindows;
		public virtual RMethod RMEndWindows
		{
			get
			{
				if(r_MEndWindows == null)
				{
					r_MEndWindows = new(this, "EndWindows", 0);
				}
				return r_MEndWindows;
			}
		}

		/// <summary>
		/// Void OnResized()
		/// </summary>
		protected RMethod r_MOnResized;
		public virtual RMethod RMOnResized
		{
			get
			{
				if(r_MOnResized == null)
				{
					r_MOnResized = new(this, "OnResized", 0);
				}
				return r_MOnResized;
			}
		}

		/// <summary>
		/// Void OnBackgroundViewResized(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MOnBackgroundViewResized_Rect;
		public virtual RMethod RMOnBackgroundViewResized_Rect
		{
			get
			{
				if(r_MOnBackgroundViewResized_Rect == null)
				{
					r_MOnBackgroundViewResized_Rect = new(this, "OnBackgroundViewResized", 0, typeof(UnityEngine.Rect));
				}
				return r_MOnBackgroundViewResized_Rect;
			}
		}

		/// <summary>
		/// Void CheckForWindowRepaint()
		/// </summary>
		protected RMethod r_MCheckForWindowRepaint;
		public virtual RMethod RMCheckForWindowRepaint
		{
			get
			{
				if(r_MCheckForWindowRepaint == null)
				{
					r_MCheckForWindowRepaint = new(this, "CheckForWindowRepaint", 0);
				}
				return r_MCheckForWindowRepaint;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent GetLocalizedTitleContent()
		/// </summary>
		protected RMethod r_MGetLocalizedTitleContent;
		public virtual RMethod RMGetLocalizedTitleContent
		{
			get
			{
				if(r_MGetLocalizedTitleContent == null)
				{
					r_MGetLocalizedTitleContent = new(this, "GetLocalizedTitleContent", 0);
				}
				return r_MGetLocalizedTitleContent;
			}
		}

		/// <summary>
		/// Void ShowNotification(UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_MShowNotification_GUIContent;
		public virtual RMethod RMShowNotification_GUIContent
		{
			get
			{
				if(r_MShowNotification_GUIContent == null)
				{
					r_MShowNotification_GUIContent = new(this, "ShowNotification", 0, typeof(UnityEngine.GUIContent));
				}
				return r_MShowNotification_GUIContent;
			}
		}

		/// <summary>
		/// Void ShowNotification(UnityEngine.GUIContent, Double)
		/// </summary>
		protected RMethod r_MShowNotification_GUIContent_Double;
		public virtual RMethod RMShowNotification_GUIContent_Double
		{
			get
			{
				if(r_MShowNotification_GUIContent_Double == null)
				{
					r_MShowNotification_GUIContent_Double = new(this, "ShowNotification", 0, typeof(UnityEngine.GUIContent), typeof(System.Double));
				}
				return r_MShowNotification_GUIContent_Double;
			}
		}

		/// <summary>
		/// Void RemoveNotification()
		/// </summary>
		protected RMethod r_MRemoveNotification;
		public virtual RMethod RMRemoveNotification
		{
			get
			{
				if(r_MRemoveNotification == null)
				{
					r_MRemoveNotification = new(this, "RemoveNotification", 0);
				}
				return r_MRemoveNotification;
			}
		}

		/// <summary>
		/// Void DrawNotification()
		/// </summary>
		protected RMethod r_MDrawNotification;
		public virtual RMethod RMDrawNotification
		{
			get
			{
				if(r_MDrawNotification == null)
				{
					r_MDrawNotification = new(this, "DrawNotification", 0);
				}
				return r_MDrawNotification;
			}
		}

		/// <summary>
		/// Void OnMaximized()
		/// </summary>
		protected RMethod r_MOnMaximized;
		public virtual RMethod RMOnMaximized
		{
			get
			{
				if(r_MOnMaximized == null)
				{
					r_MOnMaximized = new(this, "OnMaximized", 0);
				}
				return r_MOnMaximized;
			}
		}

		/// <summary>
		/// Boolean CanMaximize()
		/// </summary>
		protected RMethod r_MCanMaximize;
		public virtual RMethod RMCanMaximize
		{
			get
			{
				if(r_MCanMaximize == null)
				{
					r_MCanMaximize = new(this, "CanMaximize", 0);
				}
				return r_MCanMaximize;
			}
		}

		/// <summary>
		/// Int32 GetNumTabs()
		/// </summary>
		protected RMethod r_MGetNumTabs;
		public virtual RMethod RMGetNumTabs
		{
			get
			{
				if(r_MGetNumTabs == null)
				{
					r_MGetNumTabs = new(this, "GetNumTabs", 0);
				}
				return r_MGetNumTabs;
			}
		}

		/// <summary>
		/// Boolean ShowNextTabIfPossible()
		/// </summary>
		protected RMethod r_MShowNextTabIfPossible;
		public virtual RMethod RMShowNextTabIfPossible
		{
			get
			{
				if(r_MShowNextTabIfPossible == null)
				{
					r_MShowNextTabIfPossible = new(this, "ShowNextTabIfPossible", 0);
				}
				return r_MShowNextTabIfPossible;
			}
		}

		/// <summary>
		/// Void ShowTab()
		/// </summary>
		protected RMethod r_MShowTab;
		public virtual RMethod RMShowTab
		{
			get
			{
				if(r_MShowTab == null)
				{
					r_MShowTab = new(this, "ShowTab", 0);
				}
				return r_MShowTab;
			}
		}

		/// <summary>
		/// Boolean IsSelectedTab()
		/// </summary>
		protected RMethod r_MIsSelectedTab;
		public virtual RMethod RMIsSelectedTab
		{
			get
			{
				if(r_MIsSelectedTab == null)
				{
					r_MIsSelectedTab = new(this, "IsSelectedTab", 0);
				}
				return r_MIsSelectedTab;
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
				}
				return r_MFocus;
			}
		}

		/// <summary>
		/// Void MakeParentsSettingsMatchMe()
		/// </summary>
		protected RMethod r_MMakeParentsSettingsMatchMe;
		public virtual RMethod RMMakeParentsSettingsMatchMe
		{
			get
			{
				if(r_MMakeParentsSettingsMatchMe == null)
				{
					r_MMakeParentsSettingsMatchMe = new(this, "MakeParentsSettingsMatchMe", 0);
				}
				return r_MMakeParentsSettingsMatchMe;
			}
		}

		/// <summary>
		/// Void ShowUtility()
		/// </summary>
		protected RMethod r_MShowUtility;
		public virtual RMethod RMShowUtility
		{
			get
			{
				if(r_MShowUtility == null)
				{
					r_MShowUtility = new(this, "ShowUtility", 0);
				}
				return r_MShowUtility;
			}
		}

		/// <summary>
		/// Void ShowTooltip()
		/// </summary>
		protected RMethod r_MShowTooltip;
		public virtual RMethod RMShowTooltip
		{
			get
			{
				if(r_MShowTooltip == null)
				{
					r_MShowTooltip = new(this, "ShowTooltip", 0);
				}
				return r_MShowTooltip;
			}
		}

		/// <summary>
		/// Void ShowPopup()
		/// </summary>
		protected RMethod r_MShowPopup;
		public virtual RMethod RMShowPopup
		{
			get
			{
				if(r_MShowPopup == null)
				{
					r_MShowPopup = new(this, "ShowPopup", 0);
				}
				return r_MShowPopup;
			}
		}

		/// <summary>
		/// Void ShowModalUtility()
		/// </summary>
		protected RMethod r_MShowModalUtility;
		public virtual RMethod RMShowModalUtility
		{
			get
			{
				if(r_MShowModalUtility == null)
				{
					r_MShowModalUtility = new(this, "ShowModalUtility", 0);
				}
				return r_MShowModalUtility;
			}
		}

		/// <summary>
		/// Void ShowPopupWithMode(UnityEditor.ShowMode, Boolean)
		/// </summary>
		protected RMethod r_MShowPopupWithMode_ShowMode_Boolean;
		public virtual RMethod RMShowPopupWithMode_ShowMode_Boolean
		{
			get
			{
				if(r_MShowPopupWithMode_ShowMode_Boolean == null)
				{
					r_MShowPopupWithMode_ShowMode_Boolean = new(this, "ShowPopupWithMode", 0,  ReflectionUtils.GetType("UnityEditor.ShowMode"), typeof(System.Boolean));
				}
				return r_MShowPopupWithMode_ShowMode_Boolean;
			}
		}

		/// <summary>
		/// Void ShowWithMode(UnityEditor.ShowMode)
		/// </summary>
		protected RMethod r_MShowWithMode_ShowMode;
		public virtual RMethod RMShowWithMode_ShowMode
		{
			get
			{
				if(r_MShowWithMode_ShowMode == null)
				{
					r_MShowWithMode_ShowMode = new(this, "ShowWithMode", 0,  ReflectionUtils.GetType("UnityEditor.ShowMode"));
				}
				return r_MShowWithMode_ShowMode;
			}
		}

		/// <summary>
		/// Void ShowAsDropDown(UnityEngine.Rect, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MShowAsDropDown_Rect_Vector2;
		public virtual RMethod RMShowAsDropDown_Rect_Vector2
		{
			get
			{
				if(r_MShowAsDropDown_Rect_Vector2 == null)
				{
					r_MShowAsDropDown_Rect_Vector2 = new(this, "ShowAsDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2));
				}
				return r_MShowAsDropDown_Rect_Vector2;
			}
		}

		/// <summary>
		/// Void ShowAsDropDown(UnityEngine.Rect, UnityEngine.Vector2, UnityEditor.PopupLocation[])
		/// </summary>
		protected RMethod r_MShowAsDropDown_Rect_Vector2_PopupLocationArray;
		public virtual RMethod RMShowAsDropDown_Rect_Vector2_PopupLocationArray
		{
			get
			{
				if(r_MShowAsDropDown_Rect_Vector2_PopupLocationArray == null)
				{
					r_MShowAsDropDown_Rect_Vector2_PopupLocationArray = new(this, "ShowAsDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2),  ReflectionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType());
				}
				return r_MShowAsDropDown_Rect_Vector2_PopupLocationArray;
			}
		}

		/// <summary>
		/// Void ShowAsDropDown(UnityEngine.Rect, UnityEngine.Vector2, UnityEditor.PopupLocation[], UnityEditor.ShowMode)
		/// </summary>
		protected RMethod r_MShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode;
		public virtual RMethod RMShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode
		{
			get
			{
				if(r_MShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode == null)
				{
					r_MShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode = new(this, "ShowAsDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2),  ReflectionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType(),  ReflectionUtils.GetType("UnityEditor.ShowMode"));
				}
				return r_MShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode;
			}
		}

		/// <summary>
		/// Void ShowAsDropDown(UnityEngine.Rect, UnityEngine.Vector2, UnityEditor.PopupLocation[], UnityEditor.ShowMode, Boolean)
		/// </summary>
		protected RMethod r_MShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean;
		public virtual RMethod RMShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean
		{
			get
			{
				if(r_MShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean == null)
				{
					r_MShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean = new(this, "ShowAsDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2),  ReflectionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType(),  ReflectionUtils.GetType("UnityEditor.ShowMode"), typeof(System.Boolean));
				}
				return r_MShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Rect ShowAsDropDownFitToScreen(UnityEngine.Rect, UnityEngine.Vector2, UnityEditor.PopupLocation[])
		/// </summary>
		protected RMethod r_MShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray;
		public virtual RMethod RMShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray
		{
			get
			{
				if(r_MShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray == null)
				{
					r_MShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray = new(this, "ShowAsDropDownFitToScreen", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2),  ReflectionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType());
				}
				return r_MShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray;
			}
		}

		/// <summary>
		/// Void Show()
		/// </summary>
		protected RMethod r_MShow;
		public virtual RMethod RMShow
		{
			get
			{
				if(r_MShow == null)
				{
					r_MShow = new(this, "Show", 0);
				}
				return r_MShow;
			}
		}

		/// <summary>
		/// Void Show(Boolean)
		/// </summary>
		protected RMethod r_MShow_Boolean;
		public virtual RMethod RMShow_Boolean
		{
			get
			{
				if(r_MShow_Boolean == null)
				{
					r_MShow_Boolean = new(this, "Show", 0, typeof(System.Boolean));
				}
				return r_MShow_Boolean;
			}
		}

		/// <summary>
		/// Void ShowAuxWindow()
		/// </summary>
		protected RMethod r_MShowAuxWindow;
		public virtual RMethod RMShowAuxWindow
		{
			get
			{
				if(r_MShowAuxWindow == null)
				{
					r_MShowAuxWindow = new(this, "ShowAuxWindow", 0);
				}
				return r_MShowAuxWindow;
			}
		}

		/// <summary>
		/// Void ShowModal()
		/// </summary>
		protected RMethod r_MShowModal;
		public virtual RMethod RMShowModal
		{
			get
			{
				if(r_MShowModal == null)
				{
					r_MShowModal = new(this, "ShowModal", 0);
				}
				return r_MShowModal;
			}
		}

		/// <summary>
		/// Void RemoveFromDockArea()
		/// </summary>
		protected RMethod r_MRemoveFromDockArea;
		public virtual RMethod RMRemoveFromDockArea
		{
			get
			{
				if(r_MRemoveFromDockArea == null)
				{
					r_MRemoveFromDockArea = new(this, "RemoveFromDockArea", 0);
				}
				return r_MRemoveFromDockArea;
			}
		}

		/// <summary>
		/// Void SaveChanges()
		/// </summary>
		protected RMethod r_MSaveChanges;
		public virtual RMethod RMSaveChanges
		{
			get
			{
				if(r_MSaveChanges == null)
				{
					r_MSaveChanges = new(this, "SaveChanges", 0);
				}
				return r_MSaveChanges;
			}
		}

		/// <summary>
		/// Void DiscardChanges()
		/// </summary>
		protected RMethod r_MDiscardChanges;
		public virtual RMethod RMDiscardChanges
		{
			get
			{
				if(r_MDiscardChanges == null)
				{
					r_MDiscardChanges = new(this, "DiscardChanges", 0);
				}
				return r_MDiscardChanges;
			}
		}

		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_MClose;
		public virtual RMethod RMClose
		{
			get
			{
				if(r_MClose == null)
				{
					r_MClose = new(this, "Close", 0);
				}
				return r_MClose;
			}
		}

		/// <summary>
		/// Void Repaint()
		/// </summary>
		protected RMethod r_MRepaint;
		public virtual RMethod RMRepaint
		{
			get
			{
				if(r_MRepaint == null)
				{
					r_MRepaint = new(this, "Repaint", 0);
				}
				return r_MRepaint;
			}
		}

		/// <summary>
		/// Void RepaintImmediately()
		/// </summary>
		protected RMethod r_MRepaintImmediately;
		public virtual RMethod RMRepaintImmediately
		{
			get
			{
				if(r_MRepaintImmediately == null)
				{
					r_MRepaintImmediately = new(this, "RepaintImmediately", 0);
				}
				return r_MRepaintImmediately;
			}
		}

		/// <summary>
		/// Void SetParentGameViewDimensions(UnityEngine.Rect, UnityEngine.Rect, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetParentGameViewDimensions_Rect_Rect_Vector2;
		public virtual RMethod RMSetParentGameViewDimensions_Rect_Rect_Vector2
		{
			get
			{
				if(r_MSetParentGameViewDimensions_Rect_Rect_Vector2 == null)
				{
					r_MSetParentGameViewDimensions_Rect_Rect_Vector2 = new(this, "SetParentGameViewDimensions", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2));
				}
				return r_MSetParentGameViewDimensions_Rect_Rect_Vector2;
			}
		}

		/// <summary>
		/// Void SetPlayModeViewSize(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetPlayModeViewSize_Vector2;
		public virtual RMethod RMSetPlayModeViewSize_Vector2
		{
			get
			{
				if(r_MSetPlayModeViewSize_Vector2 == null)
				{
					r_MSetPlayModeViewSize_Vector2 = new(this, "SetPlayModeViewSize", 0, typeof(UnityEngine.Vector2));
				}
				return r_MSetPlayModeViewSize_Vector2;
			}
		}

		/// <summary>
		/// Void SetMainPlayModeViewSize(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetMainPlayModeViewSize_Vector2;
		public virtual RMethod RMSetMainPlayModeViewSize_Vector2
		{
			get
			{
				if(r_MSetMainPlayModeViewSize_Vector2 == null)
				{
					r_MSetMainPlayModeViewSize_Vector2 = new(this, "SetMainPlayModeViewSize", 0, typeof(UnityEngine.Vector2));
				}
				return r_MSetMainPlayModeViewSize_Vector2;
			}
		}

		/// <summary>
		/// Void SetDisplayViewSize(Int32, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetDisplayViewSize_Int32_Vector2;
		public virtual RMethod RMSetDisplayViewSize_Int32_Vector2
		{
			get
			{
				if(r_MSetDisplayViewSize_Int32_Vector2 == null)
				{
					r_MSetDisplayViewSize_Int32_Vector2 = new(this, "SetDisplayViewSize", 0, typeof(System.Int32), typeof(UnityEngine.Vector2));
				}
				return r_MSetDisplayViewSize_Int32_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetDisplayViewSize(Int32)
		/// </summary>
		protected RMethod r_MGetDisplayViewSize_Int32;
		public virtual RMethod RMGetDisplayViewSize_Int32
		{
			get
			{
				if(r_MGetDisplayViewSize_Int32 == null)
				{
					r_MGetDisplayViewSize_Int32 = new(this, "GetDisplayViewSize", 0, typeof(System.Int32));
				}
				return r_MGetDisplayViewSize_Int32;
			}
		}

		/// <summary>
		/// Void SetPlayModeView(Boolean)
		/// </summary>
		protected RMethod r_MSetPlayModeView_Boolean;
		public virtual RMethod RMSetPlayModeView_Boolean
		{
			get
			{
				if(r_MSetPlayModeView_Boolean == null)
				{
					r_MSetPlayModeView_Boolean = new(this, "SetPlayModeView", 0, typeof(System.Boolean));
				}
				return r_MSetPlayModeView_Boolean;
			}
		}

		/// <summary>
		/// Boolean SendEvent(UnityEngine.Event)
		/// </summary>
		protected RMethod r_MSendEvent_Event;
		public virtual RMethod RMSendEvent_Event
		{
			get
			{
				if(r_MSendEvent_Event == null)
				{
					r_MSendEvent_Event = new(this, "SendEvent", 0, typeof(UnityEngine.Event));
				}
				return r_MSendEvent_Event;
			}
		}

		/// <summary>
		/// Void AddSceneTab()
		/// </summary>
		protected RMethod r_MAddSceneTab;
		public virtual RMethod RMAddSceneTab
		{
			get
			{
				if(r_MAddSceneTab == null)
				{
					r_MAddSceneTab = new(this, "AddSceneTab", 0);
				}
				return r_MAddSceneTab;
			}
		}

		/// <summary>
		/// Void AddGameTab()
		/// </summary>
		protected RMethod r_MAddGameTab;
		public virtual RMethod RMAddGameTab
		{
			get
			{
				if(r_MAddGameTab == null)
				{
					r_MAddGameTab = new(this, "AddGameTab", 0);
				}
				return r_MAddGameTab;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Type] GetExtraPaneTypes()
		/// </summary>
		protected RMethod r_MGetExtraPaneTypes;
		public virtual RMethod RMGetExtraPaneTypes
		{
			get
			{
				if(r_MGetExtraPaneTypes == null)
				{
					r_MGetExtraPaneTypes = new(this, "GetExtraPaneTypes", 0);
				}
				return r_MGetExtraPaneTypes;
			}
		}

		/// <summary>
		/// Boolean TryGetOverlay(System.String, UnityEditor.Overlays.Overlay ByRef)
		/// </summary>
		protected RMethod r_MTryGetOverlay_String_Out_Overlay;
		public virtual RMethod RMTryGetOverlay_String_Out_Overlay
		{
			get
			{
				if(r_MTryGetOverlay_String_Out_Overlay == null)
				{
					r_MTryGetOverlay_String_Out_Overlay = new(this, "TryGetOverlay", 0, typeof(System.String), typeof(UnityEditor.Overlays.Overlay).MakeByRefType());
				}
				return r_MTryGetOverlay_String_Out_Overlay;
			}
		}

		/// <summary>
		/// Void OnBackingScaleFactorChangedInternal()
		/// </summary>
		protected RMethod r_MOnBackingScaleFactorChangedInternal;
		public virtual RMethod RMOnBackingScaleFactorChangedInternal
		{
			get
			{
				if(r_MOnBackingScaleFactorChangedInternal == null)
				{
					r_MOnBackingScaleFactorChangedInternal = new(this, "OnBackingScaleFactorChangedInternal", 0);
				}
				return r_MOnBackingScaleFactorChangedInternal;
			}
		}

		/// <summary>
		/// Void OnBackingScaleFactorChanged()
		/// </summary>
		protected RMethod r_MOnBackingScaleFactorChanged;
		public virtual RMethod RMOnBackingScaleFactorChanged
		{
			get
			{
				if(r_MOnBackingScaleFactorChanged == null)
				{
					r_MOnBackingScaleFactorChanged = new(this, "OnBackingScaleFactorChanged", 0);
				}
				return r_MOnBackingScaleFactorChanged;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_MSetDirty;
		public virtual RMethod RMSetDirty
		{
			get
			{
				if(r_MSetDirty == null)
				{
					r_MSetDirty = new(this, "SetDirty", 0);
				}
				return r_MSetDirty;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_MGetInstanceID;
		public virtual RMethod RMGetInstanceID
		{
			get
			{
				if(r_MGetInstanceID == null)
				{
					r_MGetInstanceID = new(this, "GetInstanceID", 0);
				}
				return r_MGetInstanceID;
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

        public static System.Boolean Show(UnityEngine.Rect @rect, UnityEngine.GameObject[] @gos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @gos};
            var ___result = RMShow_Rect_GameObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnEnable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnEnable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnItemSelected(UnityEditor.IMGUI.Controls.AdvancedDropdownItem @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMOnItemSelected_AdvancedDropdownItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDisable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnDisable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 CalculateWindowSize(UnityEngine.Rect @buttonRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect};
            var ___result = RMCalculateWindowSize_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.Boolean SpecialKeyboardHandling(UnityEngine.Event @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMSpecialKeyboardHandling_Event.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnCreateNewScript(Hvak.Editor.Refleaction.RUnityEditor.RAddComponent.RNewScriptDropdownItem @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item.Value};
            var ___result = RMOnCreateNewScript_NewScriptDropdownItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendUsabilityAnalyticsEvent(Hvak.Editor.Refleaction.RUnityEditor.RAddComponent.RAddComponentWindow.RAnalyticsEventData @eventData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventData.Value};
            var ___result = RMSendUsabilityAnalyticsEvent_AnalyticsEventData.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean ValidateAddComponentMenuItem()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMValidateAddComponentMenuItem.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void ExecuteAddComponentMenuItem()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMExecuteAddComponentMenuItem.Invoke(___genericsType, ___parameters);

            
        }


        public static Hvak.Editor.Refleaction.RUnityEditor.RInspectorWindow FirstInspectorWithGameObject()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFirstInspectorWithGameObject.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RInspectorWindow(___result);
        }


        public virtual void set_isSearchFieldDisabled(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_isSearchFieldDisabled_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDestroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnDestroy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Init(UnityEngine.Rect @buttonRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect};
            var ___result = RMInit_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEditor.IMGUI.Controls.AdvancedDropdownItem GetSelectedItem()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSelectedItem.Invoke(___genericsType, ___parameters);

            return (UnityEditor.IMGUI.Controls.AdvancedDropdownItem)___result;
        }


        public virtual void GoToParent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGoToParent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RDataModeController GetDataModeController_Internal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDataModeController_Internal.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RDataModeController(___result);
        }


        public virtual void SaveViewData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSaveViewData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RISerializableJsonDictionary GetViewDataDictionary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetViewDataDictionary.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RISerializableJsonDictionary(___result);
        }


        public virtual void DisableViewDataPersistence()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDisableViewDataPersistence.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearPersistentViewData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearPersistentViewData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginWindows()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBeginWindows.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndWindows()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEndWindows.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnResized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnResized.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBackgroundViewResized(UnityEngine.Rect @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RMOnBackgroundViewResized_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckForWindowRepaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCheckForWindowRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.GUIContent GetLocalizedTitleContent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLocalizedTitleContent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIContent)___result;
        }


        public virtual void ShowNotification(UnityEngine.GUIContent @notification)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@notification};
            var ___result = RMShowNotification_GUIContent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowNotification(UnityEngine.GUIContent @notification, System.Double @fadeoutWait)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@notification, @fadeoutWait};
            var ___result = RMShowNotification_GUIContent_Double.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveNotification()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRemoveNotification.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawNotification()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDrawNotification.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMaximized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnMaximized.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CanMaximize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCanMaximize.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetNumTabs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNumTabs.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean ShowNextTabIfPossible()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShowNextTabIfPossible.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ShowTab()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShowTab.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsSelectedTab()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsSelectedTab.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Focus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MakeParentsSettingsMatchMe()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMakeParentsSettingsMatchMe.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowUtility()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShowUtility.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowTooltip()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShowTooltip.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowPopup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShowPopup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowModalUtility()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShowModalUtility.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowPopupWithMode(Hvak.Editor.Refleaction.RUnityEditor.RShowMode @mode, System.Boolean @giveFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mode.Value, @giveFocus};
            var ___result = RMShowPopupWithMode_ShowMode_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowWithMode(Hvak.Editor.Refleaction.RUnityEditor.RShowMode @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mode.Value};
            var ___result = RMShowWithMode_ShowMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowAsDropDown(UnityEngine.Rect @buttonRect, UnityEngine.Vector2 @windowSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect, @windowSize};
            var ___result = RMShowAsDropDown_Rect_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowAsDropDown(UnityEngine.Rect @buttonRect, UnityEngine.Vector2 @windowSize, Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.RPopupLocation> @locationPriorityOrder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect, @windowSize, @locationPriorityOrder.Value};
            var ___result = RMShowAsDropDown_Rect_Vector2_PopupLocationArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowAsDropDown(UnityEngine.Rect @buttonRect, UnityEngine.Vector2 @windowSize, Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.RPopupLocation> @locationPriorityOrder, Hvak.Editor.Refleaction.RUnityEditor.RShowMode @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect, @windowSize, @locationPriorityOrder.Value, @mode.Value};
            var ___result = RMShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowAsDropDown(UnityEngine.Rect @buttonRect, UnityEngine.Vector2 @windowSize, Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.RPopupLocation> @locationPriorityOrder, Hvak.Editor.Refleaction.RUnityEditor.RShowMode @mode, System.Boolean @giveFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect, @windowSize, @locationPriorityOrder.Value, @mode.Value, @giveFocus};
            var ___result = RMShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect ShowAsDropDownFitToScreen(UnityEngine.Rect @buttonRect, UnityEngine.Vector2 @windowSize, Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.RPopupLocation> @locationPriorityOrder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect, @windowSize, @locationPriorityOrder.Value};
            var ___result = RMShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void Show()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Show(System.Boolean @immediateDisplay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@immediateDisplay};
            var ___result = RMShow_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowAuxWindow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShowAuxWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowModal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShowModal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFromDockArea()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRemoveFromDockArea.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SaveChanges()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSaveChanges.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DiscardChanges()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDiscardChanges.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Repaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RepaintImmediately()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRepaintImmediately.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetParentGameViewDimensions(UnityEngine.Rect @rect, UnityEngine.Rect @clippedRect, UnityEngine.Vector2 @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @clippedRect, @targetSize};
            var ___result = RMSetParentGameViewDimensions_Rect_Rect_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPlayModeViewSize(UnityEngine.Vector2 @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetSize};
            var ___result = RMSetPlayModeViewSize_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMainPlayModeViewSize(UnityEngine.Vector2 @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetSize};
            var ___result = RMSetMainPlayModeViewSize_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDisplayViewSize(System.Int32 @displayId, UnityEngine.Vector2 @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@displayId, @targetSize};
            var ___result = RMSetDisplayViewSize_Int32_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 GetDisplayViewSize(System.Int32 @displayId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@displayId};
            var ___result = RMGetDisplayViewSize_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void SetPlayModeView(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetPlayModeView_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SendEvent(UnityEngine.Event @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMSendEvent_Event.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void AddSceneTab()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAddSceneTab.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddGameTab()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAddGameTab.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.IEnumerable<System.Type> GetExtraPaneTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetExtraPaneTypes.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<System.Type>)___result;
        }


        public virtual System.Boolean TryGetOverlay(System.String @id, out UnityEditor.Overlays.Overlay @match)
        {
			@match = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @match};
            var ___result = RMTryGetOverlay_String_Out_Overlay.Invoke(___genericsType, ___parameters);
			@match = (UnityEditor.Overlays.Overlay)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual void OnBackingScaleFactorChangedInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnBackingScaleFactorChangedInternal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBackingScaleFactorChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnBackingScaleFactorChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

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
