using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.HostView
	/// </summary>
    public partial class RHostView : RMember //
    {

		/// <summary>
		/// System.String kPlayModeDarkenKey
		/// </summary>
		protected static RField r_kPlayModeDarkenKey;
		public static RField RkPlayModeDarkenKey
		{
			get
			{
				if(r_kPlayModeDarkenKey == null)
				{
					r_kPlayModeDarkenKey = new( ReleactionUtils.GetType("UnityEditor.HostView"), "kPlayModeDarkenKey");
					r_kPlayModeDarkenKey.SetBelong(null);
				}
				return r_kPlayModeDarkenKey;
			}
		}

		/// <summary>
		/// UnityEditor.PrefColor kPlayModeDarken
		/// </summary>
		protected static RUnityEditor.RPrefColor r_kPlayModeDarken;
		public static RUnityEditor.RPrefColor RkPlayModeDarken
		{
			get
			{
				if(r_kPlayModeDarken == null)
				{
					r_kPlayModeDarken = new( ReleactionUtils.GetType("UnityEditor.HostView"), "kPlayModeDarken");
					r_kPlayModeDarken.SetBelong(null);
				}
				return r_kPlayModeDarken;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.HostView] actualViewChanged
		/// </summary>
		protected static RSystem.RAction<RUnityEditor.RHostView> r_actualViewChanged;
		public static RSystem.RAction<RUnityEditor.RHostView> RactualViewChanged
		{
			get
			{
				if(r_actualViewChanged == null)
				{
					r_actualViewChanged = new( ReleactionUtils.GetType("UnityEditor.HostView"), "actualViewChanged");
					r_actualViewChanged.SetBelong(null);
				}
				return r_actualViewChanged;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow m_ActualView
		/// </summary>
		protected RUnityEditor.REditorWindow r_m_ActualView;
		public virtual RUnityEditor.REditorWindow Rm_ActualView
		{
			get
			{
				if(r_m_ActualView == null)
				{
					r_m_ActualView = new(this, "m_ActualView");
					r_m_ActualView.SetBelong(this.instance);
				}
				return r_m_ActualView;
			}
		}

		/// <summary>
		/// UnityEngine.RectOffset m_BorderSize
		/// </summary>
		protected RUnityEngine.RRectOffset r_m_BorderSize;
		public virtual RUnityEngine.RRectOffset Rm_BorderSize
		{
			get
			{
				if(r_m_BorderSize == null)
				{
					r_m_BorderSize = new(this, "m_BorderSize");
					r_m_BorderSize.SetBelong(this.instance);
				}
				return r_m_BorderSize;
			}
		}

		/// <summary>
		/// System.Boolean <showGenericMenu>k__BackingField
		/// </summary>
		protected RField r___1__showGenericMenu__2__k__BackingField;
		public virtual RField R__1__showGenericMenu__2__k__BackingField
		{
			get
			{
				if(r___1__showGenericMenu__2__k__BackingField == null)
				{
					r___1__showGenericMenu__2__k__BackingField = new(this, "<showGenericMenu>k__BackingField");
					r___1__showGenericMenu__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__showGenericMenu__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowDelegate m_OnGUI
		/// </summary>
		protected RUnityEditor.RHostView.REditorWindowDelegate r_m_OnGUI;
		public virtual RUnityEditor.RHostView.REditorWindowDelegate Rm_OnGUI
		{
			get
			{
				if(r_m_OnGUI == null)
				{
					r_m_OnGUI = new(this, "m_OnGUI");
					r_m_OnGUI.SetBelong(this.instance);
				}
				return r_m_OnGUI;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowDelegate m_OnFocus
		/// </summary>
		protected RUnityEditor.RHostView.REditorWindowDelegate r_m_OnFocus;
		public virtual RUnityEditor.RHostView.REditorWindowDelegate Rm_OnFocus
		{
			get
			{
				if(r_m_OnFocus == null)
				{
					r_m_OnFocus = new(this, "m_OnFocus");
					r_m_OnFocus.SetBelong(this.instance);
				}
				return r_m_OnFocus;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowDelegate m_OnLostFocus
		/// </summary>
		protected RUnityEditor.RHostView.REditorWindowDelegate r_m_OnLostFocus;
		public virtual RUnityEditor.RHostView.REditorWindowDelegate Rm_OnLostFocus
		{
			get
			{
				if(r_m_OnLostFocus == null)
				{
					r_m_OnLostFocus = new(this, "m_OnLostFocus");
					r_m_OnLostFocus.SetBelong(this.instance);
				}
				return r_m_OnLostFocus;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowDelegate m_OnProjectChange
		/// </summary>
		protected RUnityEditor.RHostView.REditorWindowDelegate r_m_OnProjectChange;
		public virtual RUnityEditor.RHostView.REditorWindowDelegate Rm_OnProjectChange
		{
			get
			{
				if(r_m_OnProjectChange == null)
				{
					r_m_OnProjectChange = new(this, "m_OnProjectChange");
					r_m_OnProjectChange.SetBelong(this.instance);
				}
				return r_m_OnProjectChange;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowDelegate m_OnSelectionChange
		/// </summary>
		protected RUnityEditor.RHostView.REditorWindowDelegate r_m_OnSelectionChange;
		public virtual RUnityEditor.RHostView.REditorWindowDelegate Rm_OnSelectionChange
		{
			get
			{
				if(r_m_OnSelectionChange == null)
				{
					r_m_OnSelectionChange = new(this, "m_OnSelectionChange");
					r_m_OnSelectionChange.SetBelong(this.instance);
				}
				return r_m_OnSelectionChange;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowDelegate m_OnDidOpenScene
		/// </summary>
		protected RUnityEditor.RHostView.REditorWindowDelegate r_m_OnDidOpenScene;
		public virtual RUnityEditor.RHostView.REditorWindowDelegate Rm_OnDidOpenScene
		{
			get
			{
				if(r_m_OnDidOpenScene == null)
				{
					r_m_OnDidOpenScene = new(this, "m_OnDidOpenScene");
					r_m_OnDidOpenScene.SetBelong(this.instance);
				}
				return r_m_OnDidOpenScene;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowDelegate m_OnInspectorUpdate
		/// </summary>
		protected RUnityEditor.RHostView.REditorWindowDelegate r_m_OnInspectorUpdate;
		public virtual RUnityEditor.RHostView.REditorWindowDelegate Rm_OnInspectorUpdate
		{
			get
			{
				if(r_m_OnInspectorUpdate == null)
				{
					r_m_OnInspectorUpdate = new(this, "m_OnInspectorUpdate");
					r_m_OnInspectorUpdate.SetBelong(this.instance);
				}
				return r_m_OnInspectorUpdate;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowDelegate m_OnHierarchyChange
		/// </summary>
		protected RUnityEditor.RHostView.REditorWindowDelegate r_m_OnHierarchyChange;
		public virtual RUnityEditor.RHostView.REditorWindowDelegate Rm_OnHierarchyChange
		{
			get
			{
				if(r_m_OnHierarchyChange == null)
				{
					r_m_OnHierarchyChange = new(this, "m_OnHierarchyChange");
					r_m_OnHierarchyChange.SetBelong(this.instance);
				}
				return r_m_OnHierarchyChange;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowDelegate m_OnBecameVisible
		/// </summary>
		protected RUnityEditor.RHostView.REditorWindowDelegate r_m_OnBecameVisible;
		public virtual RUnityEditor.RHostView.REditorWindowDelegate Rm_OnBecameVisible
		{
			get
			{
				if(r_m_OnBecameVisible == null)
				{
					r_m_OnBecameVisible = new(this, "m_OnBecameVisible");
					r_m_OnBecameVisible.SetBelong(this.instance);
				}
				return r_m_OnBecameVisible;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowDelegate m_OnBecameInvisible
		/// </summary>
		protected RUnityEditor.RHostView.REditorWindowDelegate r_m_OnBecameInvisible;
		public virtual RUnityEditor.RHostView.REditorWindowDelegate Rm_OnBecameInvisible
		{
			get
			{
				if(r_m_OnBecameInvisible == null)
				{
					r_m_OnBecameInvisible = new(this, "m_OnBecameInvisible");
					r_m_OnBecameInvisible.SetBelong(this.instance);
				}
				return r_m_OnBecameInvisible;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowDelegate m_Update
		/// </summary>
		protected RUnityEditor.RHostView.REditorWindowDelegate r_m_Update;
		public virtual RUnityEditor.RHostView.REditorWindowDelegate Rm_Update
		{
			get
			{
				if(r_m_Update == null)
				{
					r_m_Update = new(this, "m_Update");
					r_m_Update.SetBelong(this.instance);
				}
				return r_m_Update;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowDelegate m_ModifierKeysChanged
		/// </summary>
		protected RUnityEditor.RHostView.REditorWindowDelegate r_m_ModifierKeysChanged;
		public virtual RUnityEditor.RHostView.REditorWindowDelegate Rm_ModifierKeysChanged
		{
			get
			{
				if(r_m_ModifierKeysChanged == null)
				{
					r_m_ModifierKeysChanged = new(this, "m_ModifierKeysChanged");
					r_m_ModifierKeysChanged.SetBelong(this.instance);
				}
				return r_m_ModifierKeysChanged;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowShowButtonDelegate m_ShowButton
		/// </summary>
		protected RUnityEditor.RHostView.REditorWindowShowButtonDelegate r_m_ShowButton;
		public virtual RUnityEditor.RHostView.REditorWindowShowButtonDelegate Rm_ShowButton
		{
			get
			{
				if(r_m_ShowButton == null)
				{
					r_m_ShowButton = new(this, "m_ShowButton");
					r_m_ShowButton.SetBelong(this.instance);
				}
				return r_m_ShowButton;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 k_DockedMinSize
		/// </summary>
		protected static RUnityEngine.RVector2 r_k_DockedMinSize;
		public static RUnityEngine.RVector2 Rk_DockedMinSize
		{
			get
			{
				if(r_k_DockedMinSize == null)
				{
					r_k_DockedMinSize = new( ReleactionUtils.GetType("UnityEditor.HostView"), "k_DockedMinSize");
					r_k_DockedMinSize.SetBelong(null);
				}
				return r_k_DockedMinSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 k_DockedMaxSize
		/// </summary>
		protected static RUnityEngine.RVector2 r_k_DockedMaxSize;
		public static RUnityEngine.RVector2 Rk_DockedMaxSize
		{
			get
			{
				if(r_k_DockedMaxSize == null)
				{
					r_k_DockedMaxSize = new( ReleactionUtils.GetType("UnityEditor.HostView"), "k_DockedMaxSize");
					r_k_DockedMaxSize.SetBelong(null);
				}
				return r_k_DockedMaxSize;
			}
		}

		/// <summary>
		/// System.Action <UnityEditor.IEditorWindowModel.onSplitterGUIHandler>k__BackingField
		/// </summary>
		protected RSystem.RAction r___1__UnityEditor__0__IEditorWindowModel__0__onSplitterGUIHandler__2__k__BackingField;
		public virtual RSystem.RAction R__1__UnityEditor__0__IEditorWindowModel__0__onSplitterGUIHandler__2__k__BackingField
		{
			get
			{
				if(r___1__UnityEditor__0__IEditorWindowModel__0__onSplitterGUIHandler__2__k__BackingField == null)
				{
					r___1__UnityEditor__0__IEditorWindowModel__0__onSplitterGUIHandler__2__k__BackingField = new(this, "<UnityEditor.IEditorWindowModel.onSplitterGUIHandler>k__BackingField");
					r___1__UnityEditor__0__IEditorWindowModel__0__onSplitterGUIHandler__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__UnityEditor__0__IEditorWindowModel__0__onSplitterGUIHandler__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Type[] k_PaneTypes
		/// </summary>
		protected static RFieldArray<RSystem.RType> r_k_PaneTypes;
		public static RFieldArray<RSystem.RType> Rk_PaneTypes
		{
			get
			{
				if(r_k_PaneTypes == null)
				{
					r_k_PaneTypes = new( ReleactionUtils.GetType("UnityEditor.HostView"), "k_PaneTypes");
					r_k_PaneTypes.SetBelong(null);
				}
				return r_k_PaneTypes;
			}
		}

		/// <summary>
		/// System.String m_ActualViewName
		/// </summary>
		protected RField r_m_ActualViewName;
		public virtual RField Rm_ActualViewName
		{
			get
			{
				if(r_m_ActualViewName == null)
				{
					r_m_ActualViewName = new(this, "m_ActualViewName");
					r_m_ActualViewName.SetBelong(this.instance);
				}
				return r_m_ActualViewName;
			}
		}

		/// <summary>
		/// System.Boolean m_NotificationIsVisible
		/// </summary>
		protected RField r_m_NotificationIsVisible;
		public virtual RField Rm_NotificationIsVisible
		{
			get
			{
				if(r_m_NotificationIsVisible == null)
				{
					r_m_NotificationIsVisible = new(this, "m_NotificationIsVisible");
					r_m_NotificationIsVisible.SetBelong(this.instance);
				}
				return r_m_NotificationIsVisible;
			}
		}

		/// <summary>
		/// UnityEditor.WindowAction[] s_windowActions
		/// </summary>
		protected static RFieldArray<RUnityEditor.RWindowAction> r_s_windowActions;
		public static RFieldArray<RUnityEditor.RWindowAction> Rs_windowActions
		{
			get
			{
				if(r_s_windowActions == null)
				{
					r_s_windowActions = new( ReleactionUtils.GetType("UnityEditor.HostView"), "s_windowActions");
					r_s_windowActions.SetBelong(null);
				}
				return r_s_windowActions;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.SVC`1[System.Single] genericMenuLeftOffset
		/// </summary>
		protected static RUnityEditor.RStyleSheets.RSVC<RField> r_genericMenuLeftOffset;
		public static RUnityEditor.RStyleSheets.RSVC<RField> RgenericMenuLeftOffset
		{
			get
			{
				if(r_genericMenuLeftOffset == null)
				{
					r_genericMenuLeftOffset = new( ReleactionUtils.GetType("UnityEditor.HostView"), "genericMenuLeftOffset");
					r_genericMenuLeftOffset.SetBelong(null);
				}
				return r_genericMenuLeftOffset;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.SVC`1[System.Single] genericMenuFloatingLeftOffset
		/// </summary>
		protected static RUnityEditor.RStyleSheets.RSVC<RField> r_genericMenuFloatingLeftOffset;
		public static RUnityEditor.RStyleSheets.RSVC<RField> RgenericMenuFloatingLeftOffset
		{
			get
			{
				if(r_genericMenuFloatingLeftOffset == null)
				{
					r_genericMenuFloatingLeftOffset = new( ReleactionUtils.GetType("UnityEditor.HostView"), "genericMenuFloatingLeftOffset");
					r_genericMenuFloatingLeftOffset.SetBelong(null);
				}
				return r_genericMenuFloatingLeftOffset;
			}
		}

		/// <summary>
		/// UnityEngine.EventInterests m_EventInterests
		/// </summary>
		protected RUnityEngine.REventInterests r_m_EventInterests;
		public virtual RUnityEngine.REventInterests Rm_EventInterests
		{
			get
			{
				if(r_m_EventInterests == null)
				{
					r_m_EventInterests = new(this, "m_EventInterests");
					r_m_EventInterests.SetBelong(this.instance);
				}
				return r_m_EventInterests;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_MinSize
		/// </summary>
		protected RUnityEngine.RVector2 r_m_MinSize;
		public virtual RUnityEngine.RVector2 Rm_MinSize
		{
			get
			{
				if(r_m_MinSize == null)
				{
					r_m_MinSize = new(this, "m_MinSize");
					r_m_MinSize.SetBelong(this.instance);
				}
				return r_m_MinSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_MaxSize
		/// </summary>
		protected RUnityEngine.RVector2 r_m_MaxSize;
		public virtual RUnityEngine.RVector2 Rm_MaxSize
		{
			get
			{
				if(r_m_MaxSize == null)
				{
					r_m_MaxSize = new(this, "m_MaxSize");
					r_m_MaxSize.SetBelong(this.instance);
				}
				return r_m_MaxSize;
			}
		}

		/// <summary>
		/// Boolean showGenericMenu
		/// </summary>
		protected RProperty r_showGenericMenu;
		public virtual RProperty RshowGenericMenu
		{
			get
			{
				if(r_showGenericMenu == null)
				{
					r_showGenericMenu = new(this, "showGenericMenu", -1);
					r_showGenericMenu.SetBelong(this.instance);
				}
				return r_showGenericMenu;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow actualView
		/// </summary>
		protected RUnityEditor.REditorWindow r_actualView;
		public virtual RUnityEditor.REditorWindow RactualView
		{
			get
			{
				if(r_actualView == null)
				{
					r_actualView = new(this, "actualView", -1);
					r_actualView.SetBelong(this.instance);
				}
				return r_actualView;
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
		/// UnityEngine.RectOffset UnityEditor.IEditorWindowModel.viewMargins
		/// </summary>
		protected RUnityEngine.RRectOffset r_RUnityEditor__0__IEditorWindowModel__0__get_viewMargins;
		public virtual RUnityEngine.RRectOffset RUnityEditor__0__IEditorWindowModel__0__get_viewMargins
		{
			get
			{
				if(r_RUnityEditor__0__IEditorWindowModel__0__get_viewMargins == null)
				{
					r_RUnityEditor__0__IEditorWindowModel__0__get_viewMargins = new(this, "UnityEditor.IEditorWindowModel.viewMargins", -1);
					r_RUnityEditor__0__IEditorWindowModel__0__get_viewMargins.SetBelong(this.instance);
				}
				return r_RUnityEditor__0__IEditorWindowModel__0__get_viewMargins;
			}
		}

		/// <summary>
		/// System.Action UnityEditor.IEditorWindowModel.onSplitterGUIHandler
		/// </summary>
		protected RSystem.RAction r_RUnityEditor__0__IEditorWindowModel__0__get_onSplitterGUIHandler;
		public virtual RSystem.RAction RUnityEditor__0__IEditorWindowModel__0__get_onSplitterGUIHandler
		{
			get
			{
				if(r_RUnityEditor__0__IEditorWindowModel__0__get_onSplitterGUIHandler == null)
				{
					r_RUnityEditor__0__IEditorWindowModel__0__get_onSplitterGUIHandler = new(this, "UnityEditor.IEditorWindowModel.onSplitterGUIHandler", -1);
					r_RUnityEditor__0__IEditorWindowModel__0__get_onSplitterGUIHandler.SetBelong(this.instance);
				}
				return r_RUnityEditor__0__IEditorWindowModel__0__get_onSplitterGUIHandler;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow UnityEditor.IEditorWindowModel.window
		/// </summary>
		protected RUnityEditor.REditorWindow r_RUnityEditor__0__IEditorWindowModel__0__get_window;
		public virtual RUnityEditor.REditorWindow RUnityEditor__0__IEditorWindowModel__0__get_window
		{
			get
			{
				if(r_RUnityEditor__0__IEditorWindowModel__0__get_window == null)
				{
					r_RUnityEditor__0__IEditorWindowModel__0__get_window = new(this, "UnityEditor.IEditorWindowModel.window", -1);
					r_RUnityEditor__0__IEditorWindowModel__0__get_window.SetBelong(this.instance);
				}
				return r_RUnityEditor__0__IEditorWindowModel__0__get_window;
			}
		}

		/// <summary>
		/// UnityEditor.IEditorWindowBackend editorWindowBackend
		/// </summary>
		protected RUnityEditor.RIEditorWindowBackend r_editorWindowBackend;
		public virtual RUnityEditor.RIEditorWindowBackend ReditorWindowBackend
		{
			get
			{
				if(r_editorWindowBackend == null)
				{
					r_editorWindowBackend = new(this, "editorWindowBackend", -1);
					r_editorWindowBackend.SetBelong(this.instance);
				}
				return r_editorWindowBackend;
			}
		}

		/// <summary>
		/// Boolean UnityEditor.IEditorWindowModel.notificationVisible
		/// </summary>
		protected RProperty r_RUnityEditor__0__IEditorWindowModel__0__get_notificationVisible;
		public virtual RProperty RUnityEditor__0__IEditorWindowModel__0__get_notificationVisible
		{
			get
			{
				if(r_RUnityEditor__0__IEditorWindowModel__0__get_notificationVisible == null)
				{
					r_RUnityEditor__0__IEditorWindowModel__0__get_notificationVisible = new(this, "UnityEditor.IEditorWindowModel.notificationVisible", -1);
					r_RUnityEditor__0__IEditorWindowModel__0__get_notificationVisible.SetBelong(this.instance);
				}
				return r_RUnityEditor__0__IEditorWindowModel__0__get_notificationVisible;
			}
		}

		/// <summary>
		/// UnityEngine.RectOffset borderSize
		/// </summary>
		protected RUnityEngine.RRectOffset r_borderSize;
		public virtual RUnityEngine.RRectOffset RborderSize
		{
			get
			{
				if(r_borderSize == null)
				{
					r_borderSize = new(this, "borderSize", -1);
					r_borderSize.SetBelong(this.instance);
				}
				return r_borderSize;
			}
		}

		/// <summary>
		/// UnityEditor.WindowAction[] windowActions
		/// </summary>
		protected static RPropertyArray<RUnityEditor.RWindowAction> r_windowActions;
		public static RPropertyArray<RUnityEditor.RWindowAction> RwindowActions
		{
			get
			{
				if(r_windowActions == null)
				{
					r_windowActions = new( ReleactionUtils.GetType("UnityEditor.HostView"), "windowActions", -1);
					r_windowActions.SetBelong(null);
				}
				return r_windowActions;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEditor.IEditorWindowModel.playModeTintColor
		/// </summary>
		protected RUnityEngine.RColor r_RUnityEditor__0__IEditorWindowModel__0__get_playModeTintColor;
		public virtual RUnityEngine.RColor RUnityEditor__0__IEditorWindowModel__0__get_playModeTintColor
		{
			get
			{
				if(r_RUnityEditor__0__IEditorWindowModel__0__get_playModeTintColor == null)
				{
					r_RUnityEditor__0__IEditorWindowModel__0__get_playModeTintColor = new(this, "UnityEditor.IEditorWindowModel.playModeTintColor", -1);
					r_RUnityEditor__0__IEditorWindowModel__0__get_playModeTintColor.SetBelong(this.instance);
				}
				return r_RUnityEditor__0__IEditorWindowModel__0__get_playModeTintColor;
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
		/// Boolean mouseRayInvisible
		/// </summary>
		protected RProperty r_mouseRayInvisible;
		public virtual RProperty RmouseRayInvisible
		{
			get
			{
				if(r_mouseRayInvisible == null)
				{
					r_mouseRayInvisible = new(this, "mouseRayInvisible", -1);
					r_mouseRayInvisible.SetBelong(this.instance);
				}
				return r_mouseRayInvisible;
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
		/// Boolean hdrActive
		/// </summary>
		protected RProperty r_hdrActive;
		public virtual RProperty RhdrActive
		{
			get
			{
				if(r_hdrActive == null)
				{
					r_hdrActive = new(this, "hdrActive", -1);
					r_hdrActive.SetBelong(this.instance);
				}
				return r_hdrActive;
			}
		}

		/// <summary>
		/// IntPtr nativeHandle
		/// </summary>
		protected RProperty r_nativeHandle;
		public virtual RProperty RnativeHandle
		{
			get
			{
				if(r_nativeHandle == null)
				{
					r_nativeHandle = new(this, "nativeHandle", -1);
					r_nativeHandle.SetBelong(this.instance);
				}
				return r_nativeHandle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement visualTree
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_visualTree;
		public virtual RUnityEngine.RUIElements.RVisualElement RvisualTree
		{
			get
			{
				if(r_visualTree == null)
				{
					r_visualTree = new(this, "visualTree", -1);
					r_visualTree.SetBelong(this.instance);
				}
				return r_visualTree;
			}
		}

		/// <summary>
		/// UnityEngine.EventInterests eventInterests
		/// </summary>
		protected RUnityEngine.REventInterests r_eventInterests;
		public virtual RUnityEngine.REventInterests ReventInterests
		{
			get
			{
				if(r_eventInterests == null)
				{
					r_eventInterests = new(this, "eventInterests", -1);
					r_eventInterests.SetBelong(this.instance);
				}
				return r_eventInterests;
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
		/// UnityEditor.IWindowBackend windowBackend
		/// </summary>
		protected RUnityEditor.RIWindowBackend r_windowBackend;
		public virtual RUnityEditor.RIWindowBackend RwindowBackend
		{
			get
			{
				if(r_windowBackend == null)
				{
					r_windowBackend = new(this, "windowBackend", -1);
					r_windowBackend.SetBelong(this.instance);
				}
				return r_windowBackend;
			}
		}

		/// <summary>
		/// UnityEditor.View[] allChildren
		/// </summary>
		protected RPropertyArray<RUnityEditor.RView> r_allChildren;
		public virtual RPropertyArray<RUnityEditor.RView> RallChildren
		{
			get
			{
				if(r_allChildren == null)
				{
					r_allChildren = new(this, "allChildren", -1);
					r_allChildren.SetBelong(this.instance);
				}
				return r_allChildren;
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
		/// UnityEngine.Rect windowPosition
		/// </summary>
		protected RUnityEngine.RRect r_windowPosition;
		public virtual RUnityEngine.RRect RwindowPosition
		{
			get
			{
				if(r_windowPosition == null)
				{
					r_windowPosition = new(this, "windowPosition", -1);
					r_windowPosition.SetBelong(this.instance);
				}
				return r_windowPosition;
			}
		}

		/// <summary>
		/// UnityEngine.Rect screenPosition
		/// </summary>
		protected RUnityEngine.RRect r_screenPosition;
		public virtual RUnityEngine.RRect RscreenPosition
		{
			get
			{
				if(r_screenPosition == null)
				{
					r_screenPosition = new(this, "screenPosition", -1);
					r_screenPosition.SetBelong(this.instance);
				}
				return r_screenPosition;
			}
		}

		/// <summary>
		/// UnityEditor.ContainerWindow window
		/// </summary>
		protected RUnityEditor.RContainerWindow r_window;
		public virtual RUnityEditor.RContainerWindow Rwindow
		{
			get
			{
				if(r_window == null)
				{
					r_window = new(this, "window", -1);
					r_window.SetBelong(this.instance);
				}
				return r_window;
			}
		}

		/// <summary>
		/// UnityEditor.View parent
		/// </summary>
		protected RUnityEditor.RView r_parent;
		public virtual RUnityEditor.RView Rparent
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
		/// UnityEditor.View[] children
		/// </summary>
		protected RPropertyArray<RUnityEditor.RView> r_children;
		public virtual RPropertyArray<RUnityEditor.RView> Rchildren
		{
			get
			{
				if(r_children == null)
				{
					r_children = new(this, "children", -1);
					r_children.SetBelong(this.instance);
				}
				return r_children;
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
		/// Void SetActualViewInternal(UnityEditor.EditorWindow, Boolean)
		/// </summary>
		protected RMethod r_RSetActualViewInternal_EditorWindow_Boolean;
		public virtual RMethod RSetActualViewInternal_EditorWindow_Boolean
		{
			get
			{
				if(r_RSetActualViewInternal_EditorWindow_Boolean == null)
				{
					r_RSetActualViewInternal_EditorWindow_Boolean = new(this, "SetActualViewInternal", 0, typeof(UnityEditor.EditorWindow), typeof(System.Boolean));
					r_RSetActualViewInternal_EditorWindow_Boolean.SetBelong(this.instance);
				}
				return r_RSetActualViewInternal_EditorWindow_Boolean;
			}
		}

		/// <summary>
		/// Void CreateDelegates()
		/// </summary>
		protected RMethod r_RCreateDelegates;
		public virtual RMethod RCreateDelegates
		{
			get
			{
				if(r_RCreateDelegates == null)
				{
					r_RCreateDelegates = new(this, "CreateDelegates", 0);
					r_RCreateDelegates.SetBelong(this.instance);
				}
				return r_RCreateDelegates;
			}
		}

		/// <summary>
		/// Void ClearDelegates()
		/// </summary>
		protected RMethod r_RClearDelegates;
		public virtual RMethod RClearDelegates
		{
			get
			{
				if(r_RClearDelegates == null)
				{
					r_RClearDelegates = new(this, "ClearDelegates", 0);
					r_RClearDelegates.SetBelong(this.instance);
				}
				return r_RClearDelegates;
			}
		}

		/// <summary>
		/// Void ResetActiveView()
		/// </summary>
		protected RMethod r_RResetActiveView;
		public virtual RMethod RResetActiveView
		{
			get
			{
				if(r_RResetActiveView == null)
				{
					r_RResetActiveView = new(this, "ResetActiveView", 0);
					r_RResetActiveView.SetBelong(this.instance);
				}
				return r_RResetActiveView;
			}
		}

		/// <summary>
		/// Void UpdateMargins(UnityEditor.EditorWindow)
		/// </summary>
		protected RMethod r_RUpdateMargins_EditorWindow;
		public virtual RMethod RUpdateMargins_EditorWindow
		{
			get
			{
				if(r_RUpdateMargins_EditorWindow == null)
				{
					r_RUpdateMargins_EditorWindow = new(this, "UpdateMargins", 0, typeof(UnityEditor.EditorWindow));
					r_RUpdateMargins_EditorWindow.SetBelong(this.instance);
				}
				return r_RUpdateMargins_EditorWindow;
			}
		}

		/// <summary>
		/// Void UpdateViewMargins(UnityEditor.EditorWindow)
		/// </summary>
		protected RMethod r_RUpdateViewMargins_EditorWindow;
		public virtual RMethod RUpdateViewMargins_EditorWindow
		{
			get
			{
				if(r_RUpdateViewMargins_EditorWindow == null)
				{
					r_RUpdateViewMargins_EditorWindow = new(this, "UpdateViewMargins", 0, typeof(UnityEditor.EditorWindow));
					r_RUpdateViewMargins_EditorWindow.SetBelong(this.instance);
				}
				return r_RUpdateViewMargins_EditorWindow;
			}
		}

		/// <summary>
		/// Void SetPosition(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RSetPosition_Rect;
		public virtual RMethod RSetPosition_Rect
		{
			get
			{
				if(r_RSetPosition_Rect == null)
				{
					r_RSetPosition_Rect = new(this, "SetPosition", 0, typeof(UnityEngine.Rect));
					r_RSetPosition_Rect.SetBelong(this.instance);
				}
				return r_RSetPosition_Rect;
			}
		}

		/// <summary>
		/// Void SetActualViewPosition(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RSetActualViewPosition_Rect;
		public virtual RMethod RSetActualViewPosition_Rect
		{
			get
			{
				if(r_RSetActualViewPosition_Rect == null)
				{
					r_RSetActualViewPosition_Rect = new(this, "SetActualViewPosition", 0, typeof(UnityEngine.Rect));
					r_RSetActualViewPosition_Rect.SetBelong(this.instance);
				}
				return r_RSetActualViewPosition_Rect;
			}
		}

		/// <summary>
		/// Void SetWindow(UnityEditor.ContainerWindow)
		/// </summary>
		protected RMethod r_RSetWindow_ContainerWindow;
		public virtual RMethod RSetWindow_ContainerWindow
		{
			get
			{
				if(r_RSetWindow_ContainerWindow == null)
				{
					r_RSetWindow_ContainerWindow = new(this, "SetWindow", 0,  ReleactionUtils.GetType("UnityEditor.ContainerWindow"));
					r_RSetWindow_ContainerWindow.SetBelong(this.instance);
				}
				return r_RSetWindow_ContainerWindow;
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
		/// Void OnEditorModeChanged(ModeChangedArgs)
		/// </summary>
		protected RMethod r_ROnEditorModeChanged_ModeChangedArgs;
		public virtual RMethod ROnEditorModeChanged_ModeChangedArgs
		{
			get
			{
				if(r_ROnEditorModeChanged_ModeChangedArgs == null)
				{
					r_ROnEditorModeChanged_ModeChangedArgs = new(this, "OnEditorModeChanged", 0,  ReleactionUtils.GetType("UnityEditor.ModeService+ModeChangedArgs"));
					r_ROnEditorModeChanged_ModeChangedArgs.SetBelong(this.instance);
				}
				return r_ROnEditorModeChanged_ModeChangedArgs;
			}
		}

		/// <summary>
		/// Void HandleSplitView()
		/// </summary>
		protected RMethod r_RHandleSplitView;
		public virtual RMethod RHandleSplitView
		{
			get
			{
				if(r_RHandleSplitView == null)
				{
					r_RHandleSplitView = new(this, "HandleSplitView", 0);
					r_RHandleSplitView.SetBelong(this.instance);
				}
				return r_RHandleSplitView;
			}
		}

		/// <summary>
		/// Void OldOnGUI()
		/// </summary>
		protected RMethod r_ROldOnGUI;
		public virtual RMethod ROldOnGUI
		{
			get
			{
				if(r_ROldOnGUI == null)
				{
					r_ROldOnGUI = new(this, "OldOnGUI", 0);
					r_ROldOnGUI.SetBelong(this.instance);
				}
				return r_ROldOnGUI;
			}
		}

		/// <summary>
		/// Boolean OnFocus()
		/// </summary>
		protected RMethod r_ROnFocus;
		public virtual RMethod ROnFocus
		{
			get
			{
				if(r_ROnFocus == null)
				{
					r_ROnFocus = new(this, "OnFocus", 0);
					r_ROnFocus.SetBelong(this.instance);
				}
				return r_ROnFocus;
			}
		}

		/// <summary>
		/// Void OnLostFocus()
		/// </summary>
		protected RMethod r_ROnLostFocus;
		public virtual RMethod ROnLostFocus
		{
			get
			{
				if(r_ROnLostFocus == null)
				{
					r_ROnLostFocus = new(this, "OnLostFocus", 0);
					r_ROnLostFocus.SetBelong(this.instance);
				}
				return r_ROnLostFocus;
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
		/// System.Collections.Generic.IEnumerable`1[System.Type] GetCurrentModePaneTypes(System.String)
		/// </summary>
		protected static RMethod r_RGetCurrentModePaneTypes_String;
		public static RMethod RGetCurrentModePaneTypes_String
		{
			get
			{
				if(r_RGetCurrentModePaneTypes_String == null)
				{
					r_RGetCurrentModePaneTypes_String = new( ReleactionUtils.GetType("UnityEditor.HostView"), "GetCurrentModePaneTypes", 0, typeof(System.String));
					r_RGetCurrentModePaneTypes_String.SetBelong(null);
				}
				return r_RGetCurrentModePaneTypes_String;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Type] GetDefaultPaneTypes()
		/// </summary>
		protected static RMethod r_RGetDefaultPaneTypes;
		public static RMethod RGetDefaultPaneTypes
		{
			get
			{
				if(r_RGetDefaultPaneTypes == null)
				{
					r_RGetDefaultPaneTypes = new( ReleactionUtils.GetType("UnityEditor.HostView"), "GetDefaultPaneTypes", 0);
					r_RGetDefaultPaneTypes.SetBelong(null);
				}
				return r_RGetDefaultPaneTypes;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Type] GetPaneTypes()
		/// </summary>
		protected RMethod r_RGetPaneTypes;
		public virtual RMethod RGetPaneTypes
		{
			get
			{
				if(r_RGetPaneTypes == null)
				{
					r_RGetPaneTypes = new(this, "GetPaneTypes", 0);
					r_RGetPaneTypes.SetBelong(this.instance);
				}
				return r_RGetPaneTypes;
			}
		}

		/// <summary>
		/// Void OnProjectChange()
		/// </summary>
		protected RMethod r_ROnProjectChange;
		public virtual RMethod ROnProjectChange
		{
			get
			{
				if(r_ROnProjectChange == null)
				{
					r_ROnProjectChange = new(this, "OnProjectChange", 0);
					r_ROnProjectChange.SetBelong(this.instance);
				}
				return r_ROnProjectChange;
			}
		}

		/// <summary>
		/// Void OnSelectionChange()
		/// </summary>
		protected RMethod r_ROnSelectionChange;
		public virtual RMethod ROnSelectionChange
		{
			get
			{
				if(r_ROnSelectionChange == null)
				{
					r_ROnSelectionChange = new(this, "OnSelectionChange", 0);
					r_ROnSelectionChange.SetBelong(this.instance);
				}
				return r_ROnSelectionChange;
			}
		}

		/// <summary>
		/// Void OnDidOpenScene()
		/// </summary>
		protected RMethod r_ROnDidOpenScene;
		public virtual RMethod ROnDidOpenScene
		{
			get
			{
				if(r_ROnDidOpenScene == null)
				{
					r_ROnDidOpenScene = new(this, "OnDidOpenScene", 0);
					r_ROnDidOpenScene.SetBelong(this.instance);
				}
				return r_ROnDidOpenScene;
			}
		}

		/// <summary>
		/// Void OnInspectorUpdate()
		/// </summary>
		protected RMethod r_ROnInspectorUpdate;
		public virtual RMethod ROnInspectorUpdate
		{
			get
			{
				if(r_ROnInspectorUpdate == null)
				{
					r_ROnInspectorUpdate = new(this, "OnInspectorUpdate", 0);
					r_ROnInspectorUpdate.SetBelong(this.instance);
				}
				return r_ROnInspectorUpdate;
			}
		}

		/// <summary>
		/// Void OnHierarchyChange()
		/// </summary>
		protected RMethod r_ROnHierarchyChange;
		public virtual RMethod ROnHierarchyChange
		{
			get
			{
				if(r_ROnHierarchyChange == null)
				{
					r_ROnHierarchyChange = new(this, "OnHierarchyChange", 0);
					r_ROnHierarchyChange.SetBelong(this.instance);
				}
				return r_ROnHierarchyChange;
			}
		}

		/// <summary>
		/// EditorWindowDelegate CreateDelegate(System.String)
		/// </summary>
		protected RMethod r_RCreateDelegate_String;
		public virtual RMethod RCreateDelegate_String
		{
			get
			{
				if(r_RCreateDelegate_String == null)
				{
					r_RCreateDelegate_String = new(this, "CreateDelegate", 0, typeof(System.String));
					r_RCreateDelegate_String.SetBelong(this.instance);
				}
				return r_RCreateDelegate_String;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetPaneMethod(System.String)
		/// </summary>
		protected RMethod r_RGetPaneMethod_String;
		public virtual RMethod RGetPaneMethod_String
		{
			get
			{
				if(r_RGetPaneMethod_String == null)
				{
					r_RGetPaneMethod_String = new(this, "GetPaneMethod", 0, typeof(System.String));
					r_RGetPaneMethod_String.SetBelong(this.instance);
				}
				return r_RGetPaneMethod_String;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetPaneMethod(System.String, System.Object)
		/// </summary>
		protected RMethod r_RGetPaneMethod_String_Object;
		public virtual RMethod RGetPaneMethod_String_Object
		{
			get
			{
				if(r_RGetPaneMethod_String_Object == null)
				{
					r_RGetPaneMethod_String_Object = new(this, "GetPaneMethod", 0, typeof(System.String), typeof(System.Object));
					r_RGetPaneMethod_String_Object.SetBelong(this.instance);
				}
				return r_RGetPaneMethod_String_Object;
			}
		}

		/// <summary>
		/// System.String GetActualViewName()
		/// </summary>
		protected RMethod r_RGetActualViewName;
		public virtual RMethod RGetActualViewName
		{
			get
			{
				if(r_RGetActualViewName == null)
				{
					r_RGetActualViewName = new(this, "GetActualViewName", 0);
					r_RGetActualViewName.SetBelong(this.instance);
				}
				return r_RGetActualViewName;
			}
		}

		/// <summary>
		/// Void InvokeOnGUI(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RInvokeOnGUI_Rect;
		public virtual RMethod RInvokeOnGUI_Rect
		{
			get
			{
				if(r_RInvokeOnGUI_Rect == null)
				{
					r_RInvokeOnGUI_Rect = new(this, "InvokeOnGUI", 0, typeof(UnityEngine.Rect));
					r_RInvokeOnGUI_Rect.SetBelong(this.instance);
				}
				return r_RInvokeOnGUI_Rect;
			}
		}

		/// <summary>
		/// Void Invoke(System.String)
		/// </summary>
		protected RMethod r_RInvoke_String;
		public virtual RMethod RInvoke_String
		{
			get
			{
				if(r_RInvoke_String == null)
				{
					r_RInvoke_String = new(this, "Invoke", 0, typeof(System.String));
					r_RInvoke_String.SetBelong(this.instance);
				}
				return r_RInvoke_String;
			}
		}

		/// <summary>
		/// Void Invoke(System.String, System.Object)
		/// </summary>
		protected RMethod r_RInvoke_String_Object;
		public virtual RMethod RInvoke_String_Object
		{
			get
			{
				if(r_RInvoke_String_Object == null)
				{
					r_RInvoke_String_Object = new(this, "Invoke", 0, typeof(System.String), typeof(System.Object));
					r_RInvoke_String_Object.SetBelong(this.instance);
				}
				return r_RInvoke_String_Object;
			}
		}

		/// <summary>
		/// Void RegisterSelectedPane(Boolean)
		/// </summary>
		protected RMethod r_RRegisterSelectedPane_Boolean;
		public virtual RMethod RRegisterSelectedPane_Boolean
		{
			get
			{
				if(r_RRegisterSelectedPane_Boolean == null)
				{
					r_RRegisterSelectedPane_Boolean = new(this, "RegisterSelectedPane", 0, typeof(System.Boolean));
					r_RRegisterSelectedPane_Boolean.SetBelong(this.instance);
				}
				return r_RRegisterSelectedPane_Boolean;
			}
		}

		/// <summary>
		/// Void DeregisterSelectedPane(Boolean, Boolean)
		/// </summary>
		protected RMethod r_RDeregisterSelectedPane_Boolean_Boolean;
		public virtual RMethod RDeregisterSelectedPane_Boolean_Boolean
		{
			get
			{
				if(r_RDeregisterSelectedPane_Boolean_Boolean == null)
				{
					r_RDeregisterSelectedPane_Boolean_Boolean = new(this, "DeregisterSelectedPane", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_RDeregisterSelectedPane_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RDeregisterSelectedPane_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void CheckNotificationStatus()
		/// </summary>
		protected RMethod r_RCheckNotificationStatus;
		public virtual RMethod RCheckNotificationStatus
		{
			get
			{
				if(r_RCheckNotificationStatus == null)
				{
					r_RCheckNotificationStatus = new(this, "CheckNotificationStatus", 0);
					r_RCheckNotificationStatus.SetBelong(this.instance);
				}
				return r_RCheckNotificationStatus;
			}
		}

		/// <summary>
		/// Void SendUpdate()
		/// </summary>
		protected RMethod r_RSendUpdate;
		public virtual RMethod RSendUpdate
		{
			get
			{
				if(r_RSendUpdate == null)
				{
					r_RSendUpdate = new(this, "SendUpdate", 0);
					r_RSendUpdate.SetBelong(this.instance);
				}
				return r_RSendUpdate;
			}
		}

		/// <summary>
		/// Void SendModKeysChanged()
		/// </summary>
		protected RMethod r_RSendModKeysChanged;
		public virtual RMethod RSendModKeysChanged
		{
			get
			{
				if(r_RSendModKeysChanged == null)
				{
					r_RSendModKeysChanged = new(this, "SendModKeysChanged", 0);
					r_RSendModKeysChanged.SetBelong(this.instance);
				}
				return r_RSendModKeysChanged;
			}
		}

		/// <summary>
		/// UnityEngine.RectOffset GetBorderSize()
		/// </summary>
		protected RMethod r_RGetBorderSize;
		public virtual RMethod RGetBorderSize
		{
			get
			{
				if(r_RGetBorderSize == null)
				{
					r_RGetBorderSize = new(this, "GetBorderSize", 0);
					r_RGetBorderSize.SetBelong(this.instance);
				}
				return r_RGetBorderSize;
			}
		}

		/// <summary>
		/// Single GetGenericMenuLeftOffset(Boolean)
		/// </summary>
		protected static RMethod r_RGetGenericMenuLeftOffset_Boolean;
		public static RMethod RGetGenericMenuLeftOffset_Boolean
		{
			get
			{
				if(r_RGetGenericMenuLeftOffset_Boolean == null)
				{
					r_RGetGenericMenuLeftOffset_Boolean = new( ReleactionUtils.GetType("UnityEditor.HostView"), "GetGenericMenuLeftOffset", 0, typeof(System.Boolean));
					r_RGetGenericMenuLeftOffset_Boolean.SetBelong(null);
				}
				return r_RGetGenericMenuLeftOffset_Boolean;
			}
		}

		/// <summary>
		/// Single GetExtraButtonsWidth()
		/// </summary>
		protected RMethod r_RGetExtraButtonsWidth;
		public virtual RMethod RGetExtraButtonsWidth
		{
			get
			{
				if(r_RGetExtraButtonsWidth == null)
				{
					r_RGetExtraButtonsWidth = new(this, "GetExtraButtonsWidth", 0);
					r_RGetExtraButtonsWidth.SetBelong(this.instance);
				}
				return r_RGetExtraButtonsWidth;
			}
		}

		/// <summary>
		/// Void ShowGenericMenu(Single, Single)
		/// </summary>
		protected RMethod r_RShowGenericMenu_Single_Single;
		public virtual RMethod RShowGenericMenu_Single_Single
		{
			get
			{
				if(r_RShowGenericMenu_Single_Single == null)
				{
					r_RShowGenericMenu_Single_Single = new(this, "ShowGenericMenu", 0, typeof(System.Single), typeof(System.Single));
					r_RShowGenericMenu_Single_Single.SetBelong(this.instance);
				}
				return r_RShowGenericMenu_Single_Single;
			}
		}

		/// <summary>
		/// Void PopulateDataModeDropdown(UnityEditor.DataModeController, UnityEditor.GenericMenu)
		/// </summary>
		protected RMethod r_RPopulateDataModeDropdown_DataModeController_GenericMenu;
		public virtual RMethod RPopulateDataModeDropdown_DataModeController_GenericMenu
		{
			get
			{
				if(r_RPopulateDataModeDropdown_DataModeController_GenericMenu == null)
				{
					r_RPopulateDataModeDropdown_DataModeController_GenericMenu = new(this, "PopulateDataModeDropdown", 0,  ReleactionUtils.GetType("UnityEditor.DataModeController"), typeof(UnityEditor.GenericMenu));
					r_RPopulateDataModeDropdown_DataModeController_GenericMenu.SetBelong(this.instance);
				}
				return r_RPopulateDataModeDropdown_DataModeController_GenericMenu;
			}
		}

		/// <summary>
		/// UnityEditor.WindowAction[] FetchWindowActionFromAttribute()
		/// </summary>
		protected static RMethod r_RFetchWindowActionFromAttribute;
		public static RMethod RFetchWindowActionFromAttribute
		{
			get
			{
				if(r_RFetchWindowActionFromAttribute == null)
				{
					r_RFetchWindowActionFromAttribute = new( ReleactionUtils.GetType("UnityEditor.HostView"), "FetchWindowActionFromAttribute", 0);
					r_RFetchWindowActionFromAttribute.SetBelong(null);
				}
				return r_RFetchWindowActionFromAttribute;
			}
		}

		/// <summary>
		/// Void FlushView(UnityEditor.EditorWindow)
		/// </summary>
		protected static RMethod r_RFlushView_EditorWindow;
		public static RMethod RFlushView_EditorWindow
		{
			get
			{
				if(r_RFlushView_EditorWindow == null)
				{
					r_RFlushView_EditorWindow = new( ReleactionUtils.GetType("UnityEditor.HostView"), "FlushView", 0, typeof(UnityEditor.EditorWindow));
					r_RFlushView_EditorWindow.SetBelong(null);
				}
				return r_RFlushView_EditorWindow;
			}
		}

		/// <summary>
		/// Void PopupGenericMenu(UnityEditor.EditorWindow, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RPopupGenericMenu_EditorWindow_Rect;
		public virtual RMethod RPopupGenericMenu_EditorWindow_Rect
		{
			get
			{
				if(r_RPopupGenericMenu_EditorWindow_Rect == null)
				{
					r_RPopupGenericMenu_EditorWindow_Rect = new(this, "PopupGenericMenu", 0, typeof(UnityEditor.EditorWindow), typeof(UnityEngine.Rect));
					r_RPopupGenericMenu_EditorWindow_Rect.SetBelong(this.instance);
				}
				return r_RPopupGenericMenu_EditorWindow_Rect;
			}
		}

		/// <summary>
		/// Void AddWindowActionMenu(UnityEditor.GenericMenu, UnityEditor.EditorWindow)
		/// </summary>
		protected static RMethod r_RAddWindowActionMenu_GenericMenu_EditorWindow;
		public static RMethod RAddWindowActionMenu_GenericMenu_EditorWindow
		{
			get
			{
				if(r_RAddWindowActionMenu_GenericMenu_EditorWindow == null)
				{
					r_RAddWindowActionMenu_GenericMenu_EditorWindow = new( ReleactionUtils.GetType("UnityEditor.HostView"), "AddWindowActionMenu", 0, typeof(UnityEditor.GenericMenu), typeof(UnityEditor.EditorWindow));
					r_RAddWindowActionMenu_GenericMenu_EditorWindow.SetBelong(null);
				}
				return r_RAddWindowActionMenu_GenericMenu_EditorWindow;
			}
		}

		/// <summary>
		/// Void Inspect(System.Object)
		/// </summary>
		protected RMethod r_RInspect_Object;
		public virtual RMethod RInspect_Object
		{
			get
			{
				if(r_RInspect_Object == null)
				{
					r_RInspect_Object = new(this, "Inspect", 0, typeof(System.Object));
					r_RInspect_Object.SetBelong(this.instance);
				}
				return r_RInspect_Object;
			}
		}

		/// <summary>
		/// Void Reload(System.Object)
		/// </summary>
		protected RMethod r_RReload_Object;
		public virtual RMethod RReload_Object
		{
			get
			{
				if(r_RReload_Object == null)
				{
					r_RReload_Object = new(this, "Reload", 0, typeof(System.Object));
					r_RReload_Object.SetBelong(this.instance);
				}
				return r_RReload_Object;
			}
		}

		/// <summary>
		/// Void AddDefaultItemsToMenu(UnityEditor.GenericMenu, UnityEditor.EditorWindow)
		/// </summary>
		protected RMethod r_RAddDefaultItemsToMenu_GenericMenu_EditorWindow;
		public virtual RMethod RAddDefaultItemsToMenu_GenericMenu_EditorWindow
		{
			get
			{
				if(r_RAddDefaultItemsToMenu_GenericMenu_EditorWindow == null)
				{
					r_RAddDefaultItemsToMenu_GenericMenu_EditorWindow = new(this, "AddDefaultItemsToMenu", 0, typeof(UnityEditor.GenericMenu), typeof(UnityEditor.EditorWindow));
					r_RAddDefaultItemsToMenu_GenericMenu_EditorWindow.SetBelong(this.instance);
				}
				return r_RAddDefaultItemsToMenu_GenericMenu_EditorWindow;
			}
		}

		/// <summary>
		/// Void PlayModeTintColorChangedCallback(System.String)
		/// </summary>
		protected RMethod r_RPlayModeTintColorChangedCallback_String;
		public virtual RMethod RPlayModeTintColorChangedCallback_String
		{
			get
			{
				if(r_RPlayModeTintColorChangedCallback_String == null)
				{
					r_RPlayModeTintColorChangedCallback_String = new(this, "PlayModeTintColorChangedCallback", 0, typeof(System.String));
					r_RPlayModeTintColorChangedCallback_String.SetBelong(this.instance);
				}
				return r_RPlayModeTintColorChangedCallback_String;
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
		/// Void CaptureRenderDocScene()
		/// </summary>
		protected RMethod r_RCaptureRenderDocScene;
		public virtual RMethod RCaptureRenderDocScene
		{
			get
			{
				if(r_RCaptureRenderDocScene == null)
				{
					r_RCaptureRenderDocScene = new(this, "CaptureRenderDocScene", 0);
					r_RCaptureRenderDocScene.SetBelong(this.instance);
				}
				return r_RCaptureRenderDocScene;
			}
		}

		/// <summary>
		/// Void CaptureRenderDocFullContent()
		/// </summary>
		protected RMethod r_RCaptureRenderDocFullContent;
		public virtual RMethod RCaptureRenderDocFullContent
		{
			get
			{
				if(r_RCaptureRenderDocFullContent == null)
				{
					r_RCaptureRenderDocFullContent = new(this, "CaptureRenderDocFullContent", 0);
					r_RCaptureRenderDocFullContent.SetBelong(this.instance);
				}
				return r_RCaptureRenderDocFullContent;
			}
		}

		/// <summary>
		/// Void BeginCaptureRenderDoc()
		/// </summary>
		protected RMethod r_RBeginCaptureRenderDoc;
		public virtual RMethod RBeginCaptureRenderDoc
		{
			get
			{
				if(r_RBeginCaptureRenderDoc == null)
				{
					r_RBeginCaptureRenderDoc = new(this, "BeginCaptureRenderDoc", 0);
					r_RBeginCaptureRenderDoc.SetBelong(this.instance);
				}
				return r_RBeginCaptureRenderDoc;
			}
		}

		/// <summary>
		/// Void EndCaptureRenderDoc()
		/// </summary>
		protected RMethod r_REndCaptureRenderDoc;
		public virtual RMethod REndCaptureRenderDoc
		{
			get
			{
				if(r_REndCaptureRenderDoc == null)
				{
					r_REndCaptureRenderDoc = new(this, "EndCaptureRenderDoc", 0);
					r_REndCaptureRenderDoc.SetBelong(this.instance);
				}
				return r_REndCaptureRenderDoc;
			}
		}

		/// <summary>
		/// Void RenderCurrentSceneForCapture()
		/// </summary>
		protected RMethod r_RRenderCurrentSceneForCapture;
		public virtual RMethod RRenderCurrentSceneForCapture
		{
			get
			{
				if(r_RRenderCurrentSceneForCapture == null)
				{
					r_RRenderCurrentSceneForCapture = new(this, "RenderCurrentSceneForCapture", 0);
					r_RRenderCurrentSceneForCapture.SetBelong(this.instance);
				}
				return r_RRenderCurrentSceneForCapture;
			}
		}

		/// <summary>
		/// Void SetTitle(System.String)
		/// </summary>
		protected RMethod r_RSetTitle_String;
		public virtual RMethod RSetTitle_String
		{
			get
			{
				if(r_RSetTitle_String == null)
				{
					r_RSetTitle_String = new(this, "SetTitle", 0, typeof(System.String));
					r_RSetTitle_String.SetBelong(this.instance);
				}
				return r_RSetTitle_String;
			}
		}

		/// <summary>
		/// Void AddToAuxWindowList()
		/// </summary>
		protected RMethod r_RAddToAuxWindowList;
		public virtual RMethod RAddToAuxWindowList
		{
			get
			{
				if(r_RAddToAuxWindowList == null)
				{
					r_RAddToAuxWindowList = new(this, "AddToAuxWindowList", 0);
					r_RAddToAuxWindowList.SetBelong(this.instance);
				}
				return r_RAddToAuxWindowList;
			}
		}

		/// <summary>
		/// Void SetInternalGameViewDimensions(UnityEngine.Rect, UnityEngine.Rect, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RSetInternalGameViewDimensions_Rect_Rect_Vector2;
		public virtual RMethod RSetInternalGameViewDimensions_Rect_Rect_Vector2
		{
			get
			{
				if(r_RSetInternalGameViewDimensions_Rect_Rect_Vector2 == null)
				{
					r_RSetInternalGameViewDimensions_Rect_Rect_Vector2 = new(this, "SetInternalGameViewDimensions", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2));
					r_RSetInternalGameViewDimensions_Rect_Rect_Vector2.SetBelong(this.instance);
				}
				return r_RSetInternalGameViewDimensions_Rect_Rect_Vector2;
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
		/// Void SetAsStartView()
		/// </summary>
		protected RMethod r_RSetAsStartView;
		public virtual RMethod RSetAsStartView
		{
			get
			{
				if(r_RSetAsStartView == null)
				{
					r_RSetAsStartView = new(this, "SetAsStartView", 0);
					r_RSetAsStartView.SetBelong(this.instance);
				}
				return r_RSetAsStartView;
			}
		}

		/// <summary>
		/// Void SetAsLastPlayModeView()
		/// </summary>
		protected RMethod r_RSetAsLastPlayModeView;
		public virtual RMethod RSetAsLastPlayModeView
		{
			get
			{
				if(r_RSetAsLastPlayModeView == null)
				{
					r_RSetAsLastPlayModeView = new(this, "SetAsLastPlayModeView", 0);
					r_RSetAsLastPlayModeView.SetBelong(this.instance);
				}
				return r_RSetAsLastPlayModeView;
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
		/// Void ClearStartView()
		/// </summary>
		protected RMethod r_RClearStartView;
		public virtual RMethod RClearStartView
		{
			get
			{
				if(r_RClearStartView == null)
				{
					r_RClearStartView = new(this, "ClearStartView", 0);
					r_RClearStartView.SetBelong(this.instance);
				}
				return r_RClearStartView;
			}
		}

		/// <summary>
		/// Void MakeVistaDWMHappyDance()
		/// </summary>
		protected RMethod r_RMakeVistaDWMHappyDance;
		public virtual RMethod RMakeVistaDWMHappyDance
		{
			get
			{
				if(r_RMakeVistaDWMHappyDance == null)
				{
					r_RMakeVistaDWMHappyDance = new(this, "MakeVistaDWMHappyDance", 0);
					r_RMakeVistaDWMHappyDance.SetBelong(this.instance);
				}
				return r_RMakeVistaDWMHappyDance;
			}
		}

		/// <summary>
		/// Void SetEyeDropperOpen(Boolean)
		/// </summary>
		protected RMethod r_RSetEyeDropperOpen_Boolean;
		public virtual RMethod RSetEyeDropperOpen_Boolean
		{
			get
			{
				if(r_RSetEyeDropperOpen_Boolean == null)
				{
					r_RSetEyeDropperOpen_Boolean = new(this, "SetEyeDropperOpen", 0, typeof(System.Boolean));
					r_RSetEyeDropperOpen_Boolean.SetBelong(this.instance);
				}
				return r_RSetEyeDropperOpen_Boolean;
			}
		}

		/// <summary>
		/// Void StealMouseCapture()
		/// </summary>
		protected RMethod r_RStealMouseCapture;
		public virtual RMethod RStealMouseCapture
		{
			get
			{
				if(r_RStealMouseCapture == null)
				{
					r_RStealMouseCapture = new(this, "StealMouseCapture", 0);
					r_RStealMouseCapture.SetBelong(this.instance);
				}
				return r_RStealMouseCapture;
			}
		}

		/// <summary>
		/// Void ClearKeyboardControl()
		/// </summary>
		protected RMethod r_RClearKeyboardControl;
		public virtual RMethod RClearKeyboardControl
		{
			get
			{
				if(r_RClearKeyboardControl == null)
				{
					r_RClearKeyboardControl = new(this, "ClearKeyboardControl", 0);
					r_RClearKeyboardControl.SetBelong(this.instance);
				}
				return r_RClearKeyboardControl;
			}
		}

		/// <summary>
		/// Void SetKeyboardControl(Int32)
		/// </summary>
		protected RMethod r_RSetKeyboardControl_Int32;
		public virtual RMethod RSetKeyboardControl_Int32
		{
			get
			{
				if(r_RSetKeyboardControl_Int32 == null)
				{
					r_RSetKeyboardControl_Int32 = new(this, "SetKeyboardControl", 0, typeof(System.Int32));
					r_RSetKeyboardControl_Int32.SetBelong(this.instance);
				}
				return r_RSetKeyboardControl_Int32;
			}
		}

		/// <summary>
		/// Int32 GetKeyboardControl()
		/// </summary>
		protected RMethod r_RGetKeyboardControl;
		public virtual RMethod RGetKeyboardControl
		{
			get
			{
				if(r_RGetKeyboardControl == null)
				{
					r_RGetKeyboardControl = new(this, "GetKeyboardControl", 0);
					r_RGetKeyboardControl.SetBelong(this.instance);
				}
				return r_RGetKeyboardControl;
			}
		}

		/// <summary>
		/// Void GrabPixels(UnityEngine.RenderTexture, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RGrabPixels_RenderTexture_Rect;
		public virtual RMethod RGrabPixels_RenderTexture_Rect
		{
			get
			{
				if(r_RGrabPixels_RenderTexture_Rect == null)
				{
					r_RGrabPixels_RenderTexture_Rect = new(this, "GrabPixels", 0, typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Rect));
					r_RGrabPixels_RenderTexture_Rect.SetBelong(this.instance);
				}
				return r_RGrabPixels_RenderTexture_Rect;
			}
		}

		/// <summary>
		/// Void MarkHotRegion(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RMarkHotRegion_Rect;
		public virtual RMethod RMarkHotRegion_Rect
		{
			get
			{
				if(r_RMarkHotRegion_Rect == null)
				{
					r_RMarkHotRegion_Rect = new(this, "MarkHotRegion", 0, typeof(UnityEngine.Rect));
					r_RMarkHotRegion_Rect.SetBelong(this.instance);
				}
				return r_RMarkHotRegion_Rect;
			}
		}

		/// <summary>
		/// Void EnableVSync(Boolean)
		/// </summary>
		protected RMethod r_REnableVSync_Boolean;
		public virtual RMethod REnableVSync_Boolean
		{
			get
			{
				if(r_REnableVSync_Boolean == null)
				{
					r_REnableVSync_Boolean = new(this, "EnableVSync", 0, typeof(System.Boolean));
					r_REnableVSync_Boolean.SetBelong(this.instance);
				}
				return r_REnableVSync_Boolean;
			}
		}

		/// <summary>
		/// Void SetActualViewName(System.String)
		/// </summary>
		protected RMethod r_RSetActualViewName_String;
		public virtual RMethod RSetActualViewName_String
		{
			get
			{
				if(r_RSetActualViewName_String == null)
				{
					r_RSetActualViewName_String = new(this, "SetActualViewName", 0, typeof(System.String));
					r_RSetActualViewName_String.SetBelong(this.instance);
				}
				return r_RSetActualViewName_String;
			}
		}

		/// <summary>
		/// Void Internal_SetAsActiveWindow()
		/// </summary>
		protected RMethod r_RInternal_SetAsActiveWindow;
		public virtual RMethod RInternal_SetAsActiveWindow
		{
			get
			{
				if(r_RInternal_SetAsActiveWindow == null)
				{
					r_RInternal_SetAsActiveWindow = new(this, "Internal_SetAsActiveWindow", 0);
					r_RInternal_SetAsActiveWindow.SetBelong(this.instance);
				}
				return r_RInternal_SetAsActiveWindow;
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
		/// Void RecreateContext()
		/// </summary>
		protected RMethod r_RRecreateContext;
		public virtual RMethod RRecreateContext
		{
			get
			{
				if(r_RRecreateContext == null)
				{
					r_RRecreateContext = new(this, "RecreateContext", 0);
					r_RRecreateContext.SetBelong(this.instance);
				}
				return r_RRecreateContext;
			}
		}

		/// <summary>
		/// Void ValidateWindowBackendForCurrentView()
		/// </summary>
		protected RMethod r_RValidateWindowBackendForCurrentView;
		public virtual RMethod RValidateWindowBackendForCurrentView
		{
			get
			{
				if(r_RValidateWindowBackendForCurrentView == null)
				{
					r_RValidateWindowBackendForCurrentView = new(this, "ValidateWindowBackendForCurrentView", 0);
					r_RValidateWindowBackendForCurrentView.SetBelong(this.instance);
				}
				return r_RValidateWindowBackendForCurrentView;
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
		/// Void DoWindowDecorationStart()
		/// </summary>
		protected RMethod r_RDoWindowDecorationStart;
		public virtual RMethod RDoWindowDecorationStart
		{
			get
			{
				if(r_RDoWindowDecorationStart == null)
				{
					r_RDoWindowDecorationStart = new(this, "DoWindowDecorationStart", 0);
					r_RDoWindowDecorationStart.SetBelong(this.instance);
				}
				return r_RDoWindowDecorationStart;
			}
		}

		/// <summary>
		/// Void DoWindowDecorationEnd()
		/// </summary>
		protected RMethod r_RDoWindowDecorationEnd;
		public virtual RMethod RDoWindowDecorationEnd
		{
			get
			{
				if(r_RDoWindowDecorationEnd == null)
				{
					r_RDoWindowDecorationEnd = new(this, "DoWindowDecorationEnd", 0);
					r_RDoWindowDecorationEnd.SetBelong(this.instance);
				}
				return r_RDoWindowDecorationEnd;
			}
		}

		/// <summary>
		/// System.String GetViewName()
		/// </summary>
		protected RMethod r_RGetViewName;
		public virtual RMethod RGetViewName
		{
			get
			{
				if(r_RGetViewName == null)
				{
					r_RGetViewName = new(this, "GetViewName", 0);
					r_RGetViewName.SetBelong(this.instance);
				}
				return r_RGetViewName;
			}
		}

		/// <summary>
		/// Void CaptureMetalScene()
		/// </summary>
		protected RMethod r_RCaptureMetalScene;
		public virtual RMethod RCaptureMetalScene
		{
			get
			{
				if(r_RCaptureMetalScene == null)
				{
					r_RCaptureMetalScene = new(this, "CaptureMetalScene", 0);
					r_RCaptureMetalScene.SetBelong(this.instance);
				}
				return r_RCaptureMetalScene;
			}
		}

		/// <summary>
		/// Void Reflow()
		/// </summary>
		protected RMethod r_RReflow;
		public virtual RMethod RReflow
		{
			get
			{
				if(r_RReflow == null)
				{
					r_RReflow = new(this, "Reflow", 0);
					r_RReflow.SetBelong(this.instance);
				}
				return r_RReflow;
			}
		}

		/// <summary>
		/// System.String DebugHierarchy(Int32)
		/// </summary>
		protected RMethod r_RDebugHierarchy_Int32;
		public virtual RMethod RDebugHierarchy_Int32
		{
			get
			{
				if(r_RDebugHierarchy_Int32 == null)
				{
					r_RDebugHierarchy_Int32 = new(this, "DebugHierarchy", 0, typeof(System.Int32));
					r_RDebugHierarchy_Int32.SetBelong(this.instance);
				}
				return r_RDebugHierarchy_Int32;
			}
		}

		/// <summary>
		/// Void Initialize(UnityEditor.ContainerWindow)
		/// </summary>
		protected RMethod r_RInitialize_ContainerWindow;
		public virtual RMethod RInitialize_ContainerWindow
		{
			get
			{
				if(r_RInitialize_ContainerWindow == null)
				{
					r_RInitialize_ContainerWindow = new(this, "Initialize", 0,  ReleactionUtils.GetType("UnityEditor.ContainerWindow"));
					r_RInitialize_ContainerWindow.SetBelong(this.instance);
				}
				return r_RInitialize_ContainerWindow;
			}
		}

		/// <summary>
		/// Void SetMinMaxSizes(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RSetMinMaxSizes_Vector2_Vector2;
		public virtual RMethod RSetMinMaxSizes_Vector2_Vector2
		{
			get
			{
				if(r_RSetMinMaxSizes_Vector2_Vector2 == null)
				{
					r_RSetMinMaxSizes_Vector2_Vector2 = new(this, "SetMinMaxSizes", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_RSetMinMaxSizes_Vector2_Vector2.SetBelong(this.instance);
				}
				return r_RSetMinMaxSizes_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Void ChildrenMinMaxChanged()
		/// </summary>
		protected RMethod r_RChildrenMinMaxChanged;
		public virtual RMethod RChildrenMinMaxChanged
		{
			get
			{
				if(r_RChildrenMinMaxChanged == null)
				{
					r_RChildrenMinMaxChanged = new(this, "ChildrenMinMaxChanged", 0);
					r_RChildrenMinMaxChanged.SetBelong(this.instance);
				}
				return r_RChildrenMinMaxChanged;
			}
		}

		/// <summary>
		/// Void SetPositionOnly(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RSetPositionOnly_Rect;
		public virtual RMethod RSetPositionOnly_Rect
		{
			get
			{
				if(r_RSetPositionOnly_Rect == null)
				{
					r_RSetPositionOnly_Rect = new(this, "SetPositionOnly", 0, typeof(UnityEngine.Rect));
					r_RSetPositionOnly_Rect.SetBelong(this.instance);
				}
				return r_RSetPositionOnly_Rect;
			}
		}

		/// <summary>
		/// Int32 IndexOfChild(UnityEditor.View)
		/// </summary>
		protected RMethod r_RIndexOfChild_View;
		public virtual RMethod RIndexOfChild_View
		{
			get
			{
				if(r_RIndexOfChild_View == null)
				{
					r_RIndexOfChild_View = new(this, "IndexOfChild", 0,  ReleactionUtils.GetType("UnityEditor.View"));
					r_RIndexOfChild_View.SetBelong(this.instance);
				}
				return r_RIndexOfChild_View;
			}
		}

		/// <summary>
		/// Void AddChild(UnityEditor.View)
		/// </summary>
		protected RMethod r_RAddChild_View;
		public virtual RMethod RAddChild_View
		{
			get
			{
				if(r_RAddChild_View == null)
				{
					r_RAddChild_View = new(this, "AddChild", 0,  ReleactionUtils.GetType("UnityEditor.View"));
					r_RAddChild_View.SetBelong(this.instance);
				}
				return r_RAddChild_View;
			}
		}

		/// <summary>
		/// Void AddChild(UnityEditor.View, Int32)
		/// </summary>
		protected RMethod r_RAddChild_View_Int32;
		public virtual RMethod RAddChild_View_Int32
		{
			get
			{
				if(r_RAddChild_View_Int32 == null)
				{
					r_RAddChild_View_Int32 = new(this, "AddChild", 0,  ReleactionUtils.GetType("UnityEditor.View"), typeof(System.Int32));
					r_RAddChild_View_Int32.SetBelong(this.instance);
				}
				return r_RAddChild_View_Int32;
			}
		}

		/// <summary>
		/// Void RemoveChild(UnityEditor.View)
		/// </summary>
		protected RMethod r_RRemoveChild_View;
		public virtual RMethod RRemoveChild_View
		{
			get
			{
				if(r_RRemoveChild_View == null)
				{
					r_RRemoveChild_View = new(this, "RemoveChild", 0,  ReleactionUtils.GetType("UnityEditor.View"));
					r_RRemoveChild_View.SetBelong(this.instance);
				}
				return r_RRemoveChild_View;
			}
		}

		/// <summary>
		/// Void RemoveChild(Int32)
		/// </summary>
		protected RMethod r_RRemoveChild_Int32;
		public virtual RMethod RRemoveChild_Int32
		{
			get
			{
				if(r_RRemoveChild_Int32 == null)
				{
					r_RRemoveChild_Int32 = new(this, "RemoveChild", 0, typeof(System.Int32));
					r_RRemoveChild_Int32.SetBelong(this.instance);
				}
				return r_RRemoveChild_Int32;
			}
		}

		/// <summary>
		/// Void SetWindowRecurse(UnityEditor.ContainerWindow)
		/// </summary>
		protected RMethod r_RSetWindowRecurse_ContainerWindow;
		public virtual RMethod RSetWindowRecurse_ContainerWindow
		{
			get
			{
				if(r_RSetWindowRecurse_ContainerWindow == null)
				{
					r_RSetWindowRecurse_ContainerWindow = new(this, "SetWindowRecurse", 0,  ReleactionUtils.GetType("UnityEditor.ContainerWindow"));
					r_RSetWindowRecurse_ContainerWindow.SetBelong(this.instance);
				}
				return r_RSetWindowRecurse_ContainerWindow;
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


        public RHostView() : base("UnityEditor.HostView")
        {
        }

        public RHostView(System.Object instance) : base("UnityEditor.HostView")
		{
            SetInstance(instance);
		}

        public RHostView(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RHostView(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetActualViewInternal(UnityEditor.EditorWindow  @value, System.Boolean  @sendEvents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @sendEvents};
            var ___result = RSetActualViewInternal_EditorWindow_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CreateDelegates()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateDelegates.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearDelegates()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearDelegates.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetActiveView()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetActiveView.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateMargins(UnityEditor.EditorWindow  @window)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@window};
            var ___result = RUpdateMargins_EditorWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateViewMargins(UnityEditor.EditorWindow  @view)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@view};
            var ___result = RUpdateViewMargins_EditorWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPosition(UnityEngine.Rect  @newPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newPos};
            var ___result = RSetPosition_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetActualViewPosition(UnityEngine.Rect  @newPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newPos};
            var ___result = RSetActualViewPosition_Rect.Invoke(___genericsType, ___parameters);

            
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



        public virtual void HandleSplitView()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHandleSplitView.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OldOnGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROldOnGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean OnFocus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnFocus.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnLostFocus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnLostFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBackingScaleFactorChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnBackingScaleFactorChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDestroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDestroy.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Collections.Generic.IEnumerable<System.Type> GetCurrentModePaneTypes(System.String  @modePaneTypeSectionName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@modePaneTypeSectionName};
            var ___result = RGetCurrentModePaneTypes_String.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<System.Type>)___result;
        }


        public static System.Collections.Generic.IEnumerable<System.Type> GetDefaultPaneTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDefaultPaneTypes.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<System.Type>)___result;
        }


        public virtual System.Collections.Generic.IEnumerable<System.Type> GetPaneTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPaneTypes.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<System.Type>)___result;
        }


        public virtual void OnProjectChange()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnProjectChange.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnSelectionChange()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnSelectionChange.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDidOpenScene()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDidOpenScene.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnInspectorUpdate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnInspectorUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnHierarchyChange()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnHierarchyChange.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object CreateDelegate(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RCreateDelegate_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Reflection.MethodInfo GetPaneMethod(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RGetPaneMethod_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetPaneMethod(System.String  @methodName, System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @obj};
            var ___result = RGetPaneMethod_String_Object.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.String GetActualViewName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetActualViewName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void InvokeOnGUI(UnityEngine.Rect  @onGUIPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@onGUIPosition};
            var ___result = RInvokeOnGUI_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Invoke(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RInvoke_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Invoke(System.String  @methodName, System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @obj};
            var ___result = RInvoke_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterSelectedPane(System.Boolean  @sendEvents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sendEvents};
            var ___result = RRegisterSelectedPane_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DeregisterSelectedPane(System.Boolean  @clearActualView, System.Boolean  @sendEvents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clearActualView, @sendEvents};
            var ___result = RDeregisterSelectedPane_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckNotificationStatus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckNotificationStatus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendUpdate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendModKeysChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendModKeysChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.RectOffset GetBorderSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetBorderSize.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RectOffset)___result;
        }


        public static System.Single GetGenericMenuLeftOffset(System.Boolean  @addFloatingWindowButtonsTopRight)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@addFloatingWindowButtonsTopRight};
            var ___result = RGetGenericMenuLeftOffset_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single GetExtraButtonsWidth()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetExtraButtonsWidth.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void ShowGenericMenu(System.Single  @leftOffset, System.Single  @topOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@leftOffset, @topOffset};
            var ___result = RShowGenericMenu_Single_Single.Invoke(___genericsType, ___parameters);

            
        }



        public static System.Object FetchWindowActionFromAttribute()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFetchWindowActionFromAttribute.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static void FlushView(UnityEditor.EditorWindow  @view)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@view};
            var ___result = RFlushView_EditorWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PopupGenericMenu(UnityEditor.EditorWindow  @view, UnityEngine.Rect  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@view, @pos};
            var ___result = RPopupGenericMenu_EditorWindow_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public static void AddWindowActionMenu(UnityEditor.GenericMenu  @menu, UnityEditor.EditorWindow  @view)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@menu, @view};
            var ___result = RAddWindowActionMenu_GenericMenu_EditorWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Inspect(System.Object  @userData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@userData};
            var ___result = RInspect_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reload(System.Object  @userData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@userData};
            var ___result = RReload_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddDefaultItemsToMenu(UnityEditor.GenericMenu  @menu, UnityEditor.EditorWindow  @window)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@menu, @window};
            var ___result = RAddDefaultItemsToMenu_GenericMenu_EditorWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlayModeTintColorChangedCallback(System.String  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RPlayModeTintColorChangedCallback_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Repaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Focus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RepaintImmediately()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRepaintImmediately.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CaptureRenderDocScene()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCaptureRenderDocScene.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CaptureRenderDocFullContent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCaptureRenderDocFullContent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginCaptureRenderDoc()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBeginCaptureRenderDoc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndCaptureRenderDoc()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REndCaptureRenderDoc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RenderCurrentSceneForCapture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRenderCurrentSceneForCapture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTitle(System.String  @title)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@title};
            var ___result = RSetTitle_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddToAuxWindowList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAddToAuxWindowList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInternalGameViewDimensions(UnityEngine.Rect  @rect, UnityEngine.Rect  @clippedRect, UnityEngine.Vector2  @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @clippedRect, @targetSize};
            var ___result = RSetInternalGameViewDimensions_Rect_Rect_Vector2.Invoke(___genericsType, ___parameters);

            
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


        public virtual void SetAsStartView()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetAsStartView.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAsLastPlayModeView()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetAsLastPlayModeView.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPlayModeView(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetPlayModeView_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearStartView()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearStartView.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MakeVistaDWMHappyDance()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMakeVistaDWMHappyDance.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetEyeDropperOpen(System.Boolean  @isOpen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isOpen};
            var ___result = RSetEyeDropperOpen_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StealMouseCapture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStealMouseCapture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearKeyboardControl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearKeyboardControl.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetKeyboardControl(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RSetKeyboardControl_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetKeyboardControl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetKeyboardControl.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void GrabPixels(UnityEngine.RenderTexture  @rd, UnityEngine.Rect  @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rd, @rect};
            var ___result = RGrabPixels_RenderTexture_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkHotRegion(UnityEngine.Rect  @hotRegionRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hotRegionRect};
            var ___result = RMarkHotRegion_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableVSync(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = REnableVSync_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetActualViewName(System.String  @viewName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@viewName};
            var ___result = RSetActualViewName_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetAsActiveWindow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternal_SetAsActiveWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SendEvent(UnityEngine.Event  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RSendEvent_Event.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RecreateContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRecreateContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ValidateWindowBackendForCurrentView()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RValidateWindowBackendForCurrentView.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoWindowDecorationStart()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDoWindowDecorationStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoWindowDecorationEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDoWindowDecorationEnd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetViewName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetViewName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void CaptureMetalScene()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCaptureMetalScene.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reflow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReflow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String DebugHierarchy(System.Int32  @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = RDebugHierarchy_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }



        public virtual void SetMinMaxSizes(UnityEngine.Vector2  @min, UnityEngine.Vector2  @max)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@min, @max};
            var ___result = RSetMinMaxSizes_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ChildrenMinMaxChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RChildrenMinMaxChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPositionOnly(UnityEngine.Rect  @newPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newPos};
            var ___result = RSetPositionOnly_Rect.Invoke(___genericsType, ___parameters);

            
        }






        public virtual void RemoveChild(System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = RRemoveChild_Int32.Invoke(___genericsType, ___parameters);

            
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
