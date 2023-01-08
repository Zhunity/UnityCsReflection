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
		protected RField r___0__showGenericMenu__1__k__BackingField;
		public virtual RField R__0__showGenericMenu__1__k__BackingField
		{
			get
			{
				if(r___0__showGenericMenu__1__k__BackingField == null)
				{
					r___0__showGenericMenu__1__k__BackingField = new(this, "<showGenericMenu>k__BackingField");
					r___0__showGenericMenu__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__showGenericMenu__1__k__BackingField;
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
		protected RSystem.RAction r___0__UnityEditor__2__IEditorWindowModel__2__onSplitterGUIHandler__1__k__BackingField;
		public virtual RSystem.RAction R__0__UnityEditor__2__IEditorWindowModel__2__onSplitterGUIHandler__1__k__BackingField
		{
			get
			{
				if(r___0__UnityEditor__2__IEditorWindowModel__2__onSplitterGUIHandler__1__k__BackingField == null)
				{
					r___0__UnityEditor__2__IEditorWindowModel__2__onSplitterGUIHandler__1__k__BackingField = new(this, "<UnityEditor.IEditorWindowModel.onSplitterGUIHandler>k__BackingField");
					r___0__UnityEditor__2__IEditorWindowModel__2__onSplitterGUIHandler__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__UnityEditor__2__IEditorWindowModel__2__onSplitterGUIHandler__1__k__BackingField;
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
		protected RUnityEngine.RRectOffset r_UnityEditor__2__IEditorWindowModel__2__viewMargins;
		public virtual RUnityEngine.RRectOffset RUnityEditor__2__IEditorWindowModel__2__viewMargins
		{
			get
			{
				if(r_UnityEditor__2__IEditorWindowModel__2__viewMargins == null)
				{
					r_UnityEditor__2__IEditorWindowModel__2__viewMargins = new(this, "UnityEditor.IEditorWindowModel.viewMargins", -1);
					r_UnityEditor__2__IEditorWindowModel__2__viewMargins.SetBelong(this.instance);
				}
				return r_UnityEditor__2__IEditorWindowModel__2__viewMargins;
			}
		}

		/// <summary>
		/// System.Action UnityEditor.IEditorWindowModel.onSplitterGUIHandler
		/// </summary>
		protected RSystem.RAction r_UnityEditor__2__IEditorWindowModel__2__onSplitterGUIHandler;
		public virtual RSystem.RAction RUnityEditor__2__IEditorWindowModel__2__onSplitterGUIHandler
		{
			get
			{
				if(r_UnityEditor__2__IEditorWindowModel__2__onSplitterGUIHandler == null)
				{
					r_UnityEditor__2__IEditorWindowModel__2__onSplitterGUIHandler = new(this, "UnityEditor.IEditorWindowModel.onSplitterGUIHandler", -1);
					r_UnityEditor__2__IEditorWindowModel__2__onSplitterGUIHandler.SetBelong(this.instance);
				}
				return r_UnityEditor__2__IEditorWindowModel__2__onSplitterGUIHandler;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow UnityEditor.IEditorWindowModel.window
		/// </summary>
		protected RUnityEditor.REditorWindow r_UnityEditor__2__IEditorWindowModel__2__window;
		public virtual RUnityEditor.REditorWindow RUnityEditor__2__IEditorWindowModel__2__window
		{
			get
			{
				if(r_UnityEditor__2__IEditorWindowModel__2__window == null)
				{
					r_UnityEditor__2__IEditorWindowModel__2__window = new(this, "UnityEditor.IEditorWindowModel.window", -1);
					r_UnityEditor__2__IEditorWindowModel__2__window.SetBelong(this.instance);
				}
				return r_UnityEditor__2__IEditorWindowModel__2__window;
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
		protected RProperty r_UnityEditor__2__IEditorWindowModel__2__notificationVisible;
		public virtual RProperty RUnityEditor__2__IEditorWindowModel__2__notificationVisible
		{
			get
			{
				if(r_UnityEditor__2__IEditorWindowModel__2__notificationVisible == null)
				{
					r_UnityEditor__2__IEditorWindowModel__2__notificationVisible = new(this, "UnityEditor.IEditorWindowModel.notificationVisible", -1);
					r_UnityEditor__2__IEditorWindowModel__2__notificationVisible.SetBelong(this.instance);
				}
				return r_UnityEditor__2__IEditorWindowModel__2__notificationVisible;
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
		protected RUnityEngine.RColor r_UnityEditor__2__IEditorWindowModel__2__playModeTintColor;
		public virtual RUnityEngine.RColor RUnityEditor__2__IEditorWindowModel__2__playModeTintColor
		{
			get
			{
				if(r_UnityEditor__2__IEditorWindowModel__2__playModeTintColor == null)
				{
					r_UnityEditor__2__IEditorWindowModel__2__playModeTintColor = new(this, "UnityEditor.IEditorWindowModel.playModeTintColor", -1);
					r_UnityEditor__2__IEditorWindowModel__2__playModeTintColor.SetBelong(this.instance);
				}
				return r_UnityEditor__2__IEditorWindowModel__2__playModeTintColor;
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
		protected RMethod r_SetActualViewInternal_EditorWindow_Boolean;
		public virtual RMethod RSetActualViewInternal_EditorWindow_Boolean
		{
			get
			{
				if(r_SetActualViewInternal_EditorWindow_Boolean == null)
				{
					r_SetActualViewInternal_EditorWindow_Boolean = new(this, "SetActualViewInternal", 0, typeof(UnityEditor.EditorWindow), typeof(System.Boolean));
					r_SetActualViewInternal_EditorWindow_Boolean.SetBelong(this.instance);
				}
				return r_SetActualViewInternal_EditorWindow_Boolean;
			}
		}

		/// <summary>
		/// Void CreateDelegates()
		/// </summary>
		protected RMethod r_CreateDelegates;
		public virtual RMethod RCreateDelegates
		{
			get
			{
				if(r_CreateDelegates == null)
				{
					r_CreateDelegates = new(this, "CreateDelegates", 0);
					r_CreateDelegates.SetBelong(this.instance);
				}
				return r_CreateDelegates;
			}
		}

		/// <summary>
		/// Void ClearDelegates()
		/// </summary>
		protected RMethod r_ClearDelegates;
		public virtual RMethod RClearDelegates
		{
			get
			{
				if(r_ClearDelegates == null)
				{
					r_ClearDelegates = new(this, "ClearDelegates", 0);
					r_ClearDelegates.SetBelong(this.instance);
				}
				return r_ClearDelegates;
			}
		}

		/// <summary>
		/// Void ResetActiveView()
		/// </summary>
		protected RMethod r_ResetActiveView;
		public virtual RMethod RResetActiveView
		{
			get
			{
				if(r_ResetActiveView == null)
				{
					r_ResetActiveView = new(this, "ResetActiveView", 0);
					r_ResetActiveView.SetBelong(this.instance);
				}
				return r_ResetActiveView;
			}
		}

		/// <summary>
		/// Void UpdateMargins(UnityEditor.EditorWindow)
		/// </summary>
		protected RMethod r_UpdateMargins_EditorWindow;
		public virtual RMethod RUpdateMargins_EditorWindow
		{
			get
			{
				if(r_UpdateMargins_EditorWindow == null)
				{
					r_UpdateMargins_EditorWindow = new(this, "UpdateMargins", 0, typeof(UnityEditor.EditorWindow));
					r_UpdateMargins_EditorWindow.SetBelong(this.instance);
				}
				return r_UpdateMargins_EditorWindow;
			}
		}

		/// <summary>
		/// Void UpdateViewMargins(UnityEditor.EditorWindow)
		/// </summary>
		protected RMethod r_UpdateViewMargins_EditorWindow;
		public virtual RMethod RUpdateViewMargins_EditorWindow
		{
			get
			{
				if(r_UpdateViewMargins_EditorWindow == null)
				{
					r_UpdateViewMargins_EditorWindow = new(this, "UpdateViewMargins", 0, typeof(UnityEditor.EditorWindow));
					r_UpdateViewMargins_EditorWindow.SetBelong(this.instance);
				}
				return r_UpdateViewMargins_EditorWindow;
			}
		}

		/// <summary>
		/// Void SetPosition(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_SetPosition_Rect;
		public virtual RMethod RSetPosition_Rect
		{
			get
			{
				if(r_SetPosition_Rect == null)
				{
					r_SetPosition_Rect = new(this, "SetPosition", 0, typeof(UnityEngine.Rect));
					r_SetPosition_Rect.SetBelong(this.instance);
				}
				return r_SetPosition_Rect;
			}
		}

		/// <summary>
		/// Void SetActualViewPosition(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_SetActualViewPosition_Rect;
		public virtual RMethod RSetActualViewPosition_Rect
		{
			get
			{
				if(r_SetActualViewPosition_Rect == null)
				{
					r_SetActualViewPosition_Rect = new(this, "SetActualViewPosition", 0, typeof(UnityEngine.Rect));
					r_SetActualViewPosition_Rect.SetBelong(this.instance);
				}
				return r_SetActualViewPosition_Rect;
			}
		}

		/// <summary>
		/// Void SetWindow(UnityEditor.ContainerWindow)
		/// </summary>
		protected RMethod r_SetWindow_ContainerWindow;
		public virtual RMethod RSetWindow_ContainerWindow
		{
			get
			{
				if(r_SetWindow_ContainerWindow == null)
				{
					r_SetWindow_ContainerWindow = new(this, "SetWindow", 0,  ReleactionUtils.GetType("UnityEditor.ContainerWindow"));
					r_SetWindow_ContainerWindow.SetBelong(this.instance);
				}
				return r_SetWindow_ContainerWindow;
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
		/// Void OnEditorModeChanged(ModeChangedArgs)
		/// </summary>
		protected RMethod r_OnEditorModeChanged_ModeChangedArgs;
		public virtual RMethod ROnEditorModeChanged_ModeChangedArgs
		{
			get
			{
				if(r_OnEditorModeChanged_ModeChangedArgs == null)
				{
					r_OnEditorModeChanged_ModeChangedArgs = new(this, "OnEditorModeChanged", 0,  ReleactionUtils.GetType("UnityEditor.ModeService+ModeChangedArgs"));
					r_OnEditorModeChanged_ModeChangedArgs.SetBelong(this.instance);
				}
				return r_OnEditorModeChanged_ModeChangedArgs;
			}
		}

		/// <summary>
		/// Void HandleSplitView()
		/// </summary>
		protected RMethod r_HandleSplitView;
		public virtual RMethod RHandleSplitView
		{
			get
			{
				if(r_HandleSplitView == null)
				{
					r_HandleSplitView = new(this, "HandleSplitView", 0);
					r_HandleSplitView.SetBelong(this.instance);
				}
				return r_HandleSplitView;
			}
		}

		/// <summary>
		/// Void OldOnGUI()
		/// </summary>
		protected RMethod r_OldOnGUI;
		public virtual RMethod ROldOnGUI
		{
			get
			{
				if(r_OldOnGUI == null)
				{
					r_OldOnGUI = new(this, "OldOnGUI", 0);
					r_OldOnGUI.SetBelong(this.instance);
				}
				return r_OldOnGUI;
			}
		}

		/// <summary>
		/// Boolean OnFocus()
		/// </summary>
		protected RMethod r_OnFocus;
		public virtual RMethod ROnFocus
		{
			get
			{
				if(r_OnFocus == null)
				{
					r_OnFocus = new(this, "OnFocus", 0);
					r_OnFocus.SetBelong(this.instance);
				}
				return r_OnFocus;
			}
		}

		/// <summary>
		/// Void OnLostFocus()
		/// </summary>
		protected RMethod r_OnLostFocus;
		public virtual RMethod ROnLostFocus
		{
			get
			{
				if(r_OnLostFocus == null)
				{
					r_OnLostFocus = new(this, "OnLostFocus", 0);
					r_OnLostFocus.SetBelong(this.instance);
				}
				return r_OnLostFocus;
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
		/// System.Collections.Generic.IEnumerable`1[System.Type] GetCurrentModePaneTypes(System.String)
		/// </summary>
		protected static RMethod r_GetCurrentModePaneTypes_String;
		public static RMethod RGetCurrentModePaneTypes_String
		{
			get
			{
				if(r_GetCurrentModePaneTypes_String == null)
				{
					r_GetCurrentModePaneTypes_String = new( ReleactionUtils.GetType("UnityEditor.HostView"), "GetCurrentModePaneTypes", 0, typeof(System.String));
					r_GetCurrentModePaneTypes_String.SetBelong(null);
				}
				return r_GetCurrentModePaneTypes_String;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Type] GetDefaultPaneTypes()
		/// </summary>
		protected static RMethod r_GetDefaultPaneTypes;
		public static RMethod RGetDefaultPaneTypes
		{
			get
			{
				if(r_GetDefaultPaneTypes == null)
				{
					r_GetDefaultPaneTypes = new( ReleactionUtils.GetType("UnityEditor.HostView"), "GetDefaultPaneTypes", 0);
					r_GetDefaultPaneTypes.SetBelong(null);
				}
				return r_GetDefaultPaneTypes;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Type] GetPaneTypes()
		/// </summary>
		protected RMethod r_GetPaneTypes;
		public virtual RMethod RGetPaneTypes
		{
			get
			{
				if(r_GetPaneTypes == null)
				{
					r_GetPaneTypes = new(this, "GetPaneTypes", 0);
					r_GetPaneTypes.SetBelong(this.instance);
				}
				return r_GetPaneTypes;
			}
		}

		/// <summary>
		/// Void OnProjectChange()
		/// </summary>
		protected RMethod r_OnProjectChange;
		public virtual RMethod ROnProjectChange
		{
			get
			{
				if(r_OnProjectChange == null)
				{
					r_OnProjectChange = new(this, "OnProjectChange", 0);
					r_OnProjectChange.SetBelong(this.instance);
				}
				return r_OnProjectChange;
			}
		}

		/// <summary>
		/// Void OnSelectionChange()
		/// </summary>
		protected RMethod r_OnSelectionChange;
		public virtual RMethod ROnSelectionChange
		{
			get
			{
				if(r_OnSelectionChange == null)
				{
					r_OnSelectionChange = new(this, "OnSelectionChange", 0);
					r_OnSelectionChange.SetBelong(this.instance);
				}
				return r_OnSelectionChange;
			}
		}

		/// <summary>
		/// Void OnDidOpenScene()
		/// </summary>
		protected RMethod r_OnDidOpenScene;
		public virtual RMethod ROnDidOpenScene
		{
			get
			{
				if(r_OnDidOpenScene == null)
				{
					r_OnDidOpenScene = new(this, "OnDidOpenScene", 0);
					r_OnDidOpenScene.SetBelong(this.instance);
				}
				return r_OnDidOpenScene;
			}
		}

		/// <summary>
		/// Void OnInspectorUpdate()
		/// </summary>
		protected RMethod r_OnInspectorUpdate;
		public virtual RMethod ROnInspectorUpdate
		{
			get
			{
				if(r_OnInspectorUpdate == null)
				{
					r_OnInspectorUpdate = new(this, "OnInspectorUpdate", 0);
					r_OnInspectorUpdate.SetBelong(this.instance);
				}
				return r_OnInspectorUpdate;
			}
		}

		/// <summary>
		/// Void OnHierarchyChange()
		/// </summary>
		protected RMethod r_OnHierarchyChange;
		public virtual RMethod ROnHierarchyChange
		{
			get
			{
				if(r_OnHierarchyChange == null)
				{
					r_OnHierarchyChange = new(this, "OnHierarchyChange", 0);
					r_OnHierarchyChange.SetBelong(this.instance);
				}
				return r_OnHierarchyChange;
			}
		}

		/// <summary>
		/// EditorWindowDelegate CreateDelegate(System.String)
		/// </summary>
		protected RMethod r_CreateDelegate_String;
		public virtual RMethod RCreateDelegate_String
		{
			get
			{
				if(r_CreateDelegate_String == null)
				{
					r_CreateDelegate_String = new(this, "CreateDelegate", 0, typeof(System.String));
					r_CreateDelegate_String.SetBelong(this.instance);
				}
				return r_CreateDelegate_String;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetPaneMethod(System.String)
		/// </summary>
		protected RMethod r_GetPaneMethod_String;
		public virtual RMethod RGetPaneMethod_String
		{
			get
			{
				if(r_GetPaneMethod_String == null)
				{
					r_GetPaneMethod_String = new(this, "GetPaneMethod", 0, typeof(System.String));
					r_GetPaneMethod_String.SetBelong(this.instance);
				}
				return r_GetPaneMethod_String;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetPaneMethod(System.String, System.Object)
		/// </summary>
		protected RMethod r_GetPaneMethod_String_Object;
		public virtual RMethod RGetPaneMethod_String_Object
		{
			get
			{
				if(r_GetPaneMethod_String_Object == null)
				{
					r_GetPaneMethod_String_Object = new(this, "GetPaneMethod", 0, typeof(System.String), typeof(System.Object));
					r_GetPaneMethod_String_Object.SetBelong(this.instance);
				}
				return r_GetPaneMethod_String_Object;
			}
		}

		/// <summary>
		/// System.String GetActualViewName()
		/// </summary>
		protected RMethod r_GetActualViewName;
		public virtual RMethod RGetActualViewName
		{
			get
			{
				if(r_GetActualViewName == null)
				{
					r_GetActualViewName = new(this, "GetActualViewName", 0);
					r_GetActualViewName.SetBelong(this.instance);
				}
				return r_GetActualViewName;
			}
		}

		/// <summary>
		/// Void InvokeOnGUI(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_InvokeOnGUI_Rect;
		public virtual RMethod RInvokeOnGUI_Rect
		{
			get
			{
				if(r_InvokeOnGUI_Rect == null)
				{
					r_InvokeOnGUI_Rect = new(this, "InvokeOnGUI", 0, typeof(UnityEngine.Rect));
					r_InvokeOnGUI_Rect.SetBelong(this.instance);
				}
				return r_InvokeOnGUI_Rect;
			}
		}

		/// <summary>
		/// Void Invoke(System.String)
		/// </summary>
		protected RMethod r_Invoke_String;
		public virtual RMethod RInvoke_String
		{
			get
			{
				if(r_Invoke_String == null)
				{
					r_Invoke_String = new(this, "Invoke", 0, typeof(System.String));
					r_Invoke_String.SetBelong(this.instance);
				}
				return r_Invoke_String;
			}
		}

		/// <summary>
		/// Void Invoke(System.String, System.Object)
		/// </summary>
		protected RMethod r_Invoke_String_Object;
		public virtual RMethod RInvoke_String_Object
		{
			get
			{
				if(r_Invoke_String_Object == null)
				{
					r_Invoke_String_Object = new(this, "Invoke", 0, typeof(System.String), typeof(System.Object));
					r_Invoke_String_Object.SetBelong(this.instance);
				}
				return r_Invoke_String_Object;
			}
		}

		/// <summary>
		/// Void RegisterSelectedPane(Boolean)
		/// </summary>
		protected RMethod r_RegisterSelectedPane_Boolean;
		public virtual RMethod RRegisterSelectedPane_Boolean
		{
			get
			{
				if(r_RegisterSelectedPane_Boolean == null)
				{
					r_RegisterSelectedPane_Boolean = new(this, "RegisterSelectedPane", 0, typeof(System.Boolean));
					r_RegisterSelectedPane_Boolean.SetBelong(this.instance);
				}
				return r_RegisterSelectedPane_Boolean;
			}
		}

		/// <summary>
		/// Void DeregisterSelectedPane(Boolean, Boolean)
		/// </summary>
		protected RMethod r_DeregisterSelectedPane_Boolean_Boolean;
		public virtual RMethod RDeregisterSelectedPane_Boolean_Boolean
		{
			get
			{
				if(r_DeregisterSelectedPane_Boolean_Boolean == null)
				{
					r_DeregisterSelectedPane_Boolean_Boolean = new(this, "DeregisterSelectedPane", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_DeregisterSelectedPane_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_DeregisterSelectedPane_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void CheckNotificationStatus()
		/// </summary>
		protected RMethod r_CheckNotificationStatus;
		public virtual RMethod RCheckNotificationStatus
		{
			get
			{
				if(r_CheckNotificationStatus == null)
				{
					r_CheckNotificationStatus = new(this, "CheckNotificationStatus", 0);
					r_CheckNotificationStatus.SetBelong(this.instance);
				}
				return r_CheckNotificationStatus;
			}
		}

		/// <summary>
		/// Void SendUpdate()
		/// </summary>
		protected RMethod r_SendUpdate;
		public virtual RMethod RSendUpdate
		{
			get
			{
				if(r_SendUpdate == null)
				{
					r_SendUpdate = new(this, "SendUpdate", 0);
					r_SendUpdate.SetBelong(this.instance);
				}
				return r_SendUpdate;
			}
		}

		/// <summary>
		/// Void SendModKeysChanged()
		/// </summary>
		protected RMethod r_SendModKeysChanged;
		public virtual RMethod RSendModKeysChanged
		{
			get
			{
				if(r_SendModKeysChanged == null)
				{
					r_SendModKeysChanged = new(this, "SendModKeysChanged", 0);
					r_SendModKeysChanged.SetBelong(this.instance);
				}
				return r_SendModKeysChanged;
			}
		}

		/// <summary>
		/// UnityEngine.RectOffset GetBorderSize()
		/// </summary>
		protected RMethod r_GetBorderSize;
		public virtual RMethod RGetBorderSize
		{
			get
			{
				if(r_GetBorderSize == null)
				{
					r_GetBorderSize = new(this, "GetBorderSize", 0);
					r_GetBorderSize.SetBelong(this.instance);
				}
				return r_GetBorderSize;
			}
		}

		/// <summary>
		/// Single GetGenericMenuLeftOffset(Boolean)
		/// </summary>
		protected static RMethod r_GetGenericMenuLeftOffset_Boolean;
		public static RMethod RGetGenericMenuLeftOffset_Boolean
		{
			get
			{
				if(r_GetGenericMenuLeftOffset_Boolean == null)
				{
					r_GetGenericMenuLeftOffset_Boolean = new( ReleactionUtils.GetType("UnityEditor.HostView"), "GetGenericMenuLeftOffset", 0, typeof(System.Boolean));
					r_GetGenericMenuLeftOffset_Boolean.SetBelong(null);
				}
				return r_GetGenericMenuLeftOffset_Boolean;
			}
		}

		/// <summary>
		/// Single GetExtraButtonsWidth()
		/// </summary>
		protected RMethod r_GetExtraButtonsWidth;
		public virtual RMethod RGetExtraButtonsWidth
		{
			get
			{
				if(r_GetExtraButtonsWidth == null)
				{
					r_GetExtraButtonsWidth = new(this, "GetExtraButtonsWidth", 0);
					r_GetExtraButtonsWidth.SetBelong(this.instance);
				}
				return r_GetExtraButtonsWidth;
			}
		}

		/// <summary>
		/// Void ShowGenericMenu(Single, Single)
		/// </summary>
		protected RMethod r_ShowGenericMenu_Single_Single;
		public virtual RMethod RShowGenericMenu_Single_Single
		{
			get
			{
				if(r_ShowGenericMenu_Single_Single == null)
				{
					r_ShowGenericMenu_Single_Single = new(this, "ShowGenericMenu", 0, typeof(System.Single), typeof(System.Single));
					r_ShowGenericMenu_Single_Single.SetBelong(this.instance);
				}
				return r_ShowGenericMenu_Single_Single;
			}
		}

		/// <summary>
		/// Void PopulateDataModeDropdown(UnityEditor.DataModeController, UnityEditor.GenericMenu)
		/// </summary>
		protected RMethod r_PopulateDataModeDropdown_DataModeController_GenericMenu;
		public virtual RMethod RPopulateDataModeDropdown_DataModeController_GenericMenu
		{
			get
			{
				if(r_PopulateDataModeDropdown_DataModeController_GenericMenu == null)
				{
					r_PopulateDataModeDropdown_DataModeController_GenericMenu = new(this, "PopulateDataModeDropdown", 0,  ReleactionUtils.GetType("UnityEditor.DataModeController"), typeof(UnityEditor.GenericMenu));
					r_PopulateDataModeDropdown_DataModeController_GenericMenu.SetBelong(this.instance);
				}
				return r_PopulateDataModeDropdown_DataModeController_GenericMenu;
			}
		}

		/// <summary>
		/// UnityEditor.WindowAction[] FetchWindowActionFromAttribute()
		/// </summary>
		protected static RMethod r_FetchWindowActionFromAttribute;
		public static RMethod RFetchWindowActionFromAttribute
		{
			get
			{
				if(r_FetchWindowActionFromAttribute == null)
				{
					r_FetchWindowActionFromAttribute = new( ReleactionUtils.GetType("UnityEditor.HostView"), "FetchWindowActionFromAttribute", 0);
					r_FetchWindowActionFromAttribute.SetBelong(null);
				}
				return r_FetchWindowActionFromAttribute;
			}
		}

		/// <summary>
		/// Void FlushView(UnityEditor.EditorWindow)
		/// </summary>
		protected static RMethod r_FlushView_EditorWindow;
		public static RMethod RFlushView_EditorWindow
		{
			get
			{
				if(r_FlushView_EditorWindow == null)
				{
					r_FlushView_EditorWindow = new( ReleactionUtils.GetType("UnityEditor.HostView"), "FlushView", 0, typeof(UnityEditor.EditorWindow));
					r_FlushView_EditorWindow.SetBelong(null);
				}
				return r_FlushView_EditorWindow;
			}
		}

		/// <summary>
		/// Void PopupGenericMenu(UnityEditor.EditorWindow, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_PopupGenericMenu_EditorWindow_Rect;
		public virtual RMethod RPopupGenericMenu_EditorWindow_Rect
		{
			get
			{
				if(r_PopupGenericMenu_EditorWindow_Rect == null)
				{
					r_PopupGenericMenu_EditorWindow_Rect = new(this, "PopupGenericMenu", 0, typeof(UnityEditor.EditorWindow), typeof(UnityEngine.Rect));
					r_PopupGenericMenu_EditorWindow_Rect.SetBelong(this.instance);
				}
				return r_PopupGenericMenu_EditorWindow_Rect;
			}
		}

		/// <summary>
		/// Void AddWindowActionMenu(UnityEditor.GenericMenu, UnityEditor.EditorWindow)
		/// </summary>
		protected static RMethod r_AddWindowActionMenu_GenericMenu_EditorWindow;
		public static RMethod RAddWindowActionMenu_GenericMenu_EditorWindow
		{
			get
			{
				if(r_AddWindowActionMenu_GenericMenu_EditorWindow == null)
				{
					r_AddWindowActionMenu_GenericMenu_EditorWindow = new( ReleactionUtils.GetType("UnityEditor.HostView"), "AddWindowActionMenu", 0, typeof(UnityEditor.GenericMenu), typeof(UnityEditor.EditorWindow));
					r_AddWindowActionMenu_GenericMenu_EditorWindow.SetBelong(null);
				}
				return r_AddWindowActionMenu_GenericMenu_EditorWindow;
			}
		}

		/// <summary>
		/// Void Inspect(System.Object)
		/// </summary>
		protected RMethod r_Inspect_Object;
		public virtual RMethod RInspect_Object
		{
			get
			{
				if(r_Inspect_Object == null)
				{
					r_Inspect_Object = new(this, "Inspect", 0, typeof(System.Object));
					r_Inspect_Object.SetBelong(this.instance);
				}
				return r_Inspect_Object;
			}
		}

		/// <summary>
		/// Void Reload(System.Object)
		/// </summary>
		protected RMethod r_Reload_Object;
		public virtual RMethod RReload_Object
		{
			get
			{
				if(r_Reload_Object == null)
				{
					r_Reload_Object = new(this, "Reload", 0, typeof(System.Object));
					r_Reload_Object.SetBelong(this.instance);
				}
				return r_Reload_Object;
			}
		}

		/// <summary>
		/// Void AddDefaultItemsToMenu(UnityEditor.GenericMenu, UnityEditor.EditorWindow)
		/// </summary>
		protected RMethod r_AddDefaultItemsToMenu_GenericMenu_EditorWindow;
		public virtual RMethod RAddDefaultItemsToMenu_GenericMenu_EditorWindow
		{
			get
			{
				if(r_AddDefaultItemsToMenu_GenericMenu_EditorWindow == null)
				{
					r_AddDefaultItemsToMenu_GenericMenu_EditorWindow = new(this, "AddDefaultItemsToMenu", 0, typeof(UnityEditor.GenericMenu), typeof(UnityEditor.EditorWindow));
					r_AddDefaultItemsToMenu_GenericMenu_EditorWindow.SetBelong(this.instance);
				}
				return r_AddDefaultItemsToMenu_GenericMenu_EditorWindow;
			}
		}

		/// <summary>
		/// Void PlayModeTintColorChangedCallback(System.String)
		/// </summary>
		protected RMethod r_PlayModeTintColorChangedCallback_String;
		public virtual RMethod RPlayModeTintColorChangedCallback_String
		{
			get
			{
				if(r_PlayModeTintColorChangedCallback_String == null)
				{
					r_PlayModeTintColorChangedCallback_String = new(this, "PlayModeTintColorChangedCallback", 0, typeof(System.String));
					r_PlayModeTintColorChangedCallback_String.SetBelong(this.instance);
				}
				return r_PlayModeTintColorChangedCallback_String;
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
		/// Void CaptureRenderDocScene()
		/// </summary>
		protected RMethod r_CaptureRenderDocScene;
		public virtual RMethod RCaptureRenderDocScene
		{
			get
			{
				if(r_CaptureRenderDocScene == null)
				{
					r_CaptureRenderDocScene = new(this, "CaptureRenderDocScene", 0);
					r_CaptureRenderDocScene.SetBelong(this.instance);
				}
				return r_CaptureRenderDocScene;
			}
		}

		/// <summary>
		/// Void CaptureRenderDocFullContent()
		/// </summary>
		protected RMethod r_CaptureRenderDocFullContent;
		public virtual RMethod RCaptureRenderDocFullContent
		{
			get
			{
				if(r_CaptureRenderDocFullContent == null)
				{
					r_CaptureRenderDocFullContent = new(this, "CaptureRenderDocFullContent", 0);
					r_CaptureRenderDocFullContent.SetBelong(this.instance);
				}
				return r_CaptureRenderDocFullContent;
			}
		}

		/// <summary>
		/// Void BeginCaptureRenderDoc()
		/// </summary>
		protected RMethod r_BeginCaptureRenderDoc;
		public virtual RMethod RBeginCaptureRenderDoc
		{
			get
			{
				if(r_BeginCaptureRenderDoc == null)
				{
					r_BeginCaptureRenderDoc = new(this, "BeginCaptureRenderDoc", 0);
					r_BeginCaptureRenderDoc.SetBelong(this.instance);
				}
				return r_BeginCaptureRenderDoc;
			}
		}

		/// <summary>
		/// Void EndCaptureRenderDoc()
		/// </summary>
		protected RMethod r_EndCaptureRenderDoc;
		public virtual RMethod REndCaptureRenderDoc
		{
			get
			{
				if(r_EndCaptureRenderDoc == null)
				{
					r_EndCaptureRenderDoc = new(this, "EndCaptureRenderDoc", 0);
					r_EndCaptureRenderDoc.SetBelong(this.instance);
				}
				return r_EndCaptureRenderDoc;
			}
		}

		/// <summary>
		/// Void RenderCurrentSceneForCapture()
		/// </summary>
		protected RMethod r_RenderCurrentSceneForCapture;
		public virtual RMethod RRenderCurrentSceneForCapture
		{
			get
			{
				if(r_RenderCurrentSceneForCapture == null)
				{
					r_RenderCurrentSceneForCapture = new(this, "RenderCurrentSceneForCapture", 0);
					r_RenderCurrentSceneForCapture.SetBelong(this.instance);
				}
				return r_RenderCurrentSceneForCapture;
			}
		}

		/// <summary>
		/// Void SetTitle(System.String)
		/// </summary>
		protected RMethod r_SetTitle_String;
		public virtual RMethod RSetTitle_String
		{
			get
			{
				if(r_SetTitle_String == null)
				{
					r_SetTitle_String = new(this, "SetTitle", 0, typeof(System.String));
					r_SetTitle_String.SetBelong(this.instance);
				}
				return r_SetTitle_String;
			}
		}

		/// <summary>
		/// Void AddToAuxWindowList()
		/// </summary>
		protected RMethod r_AddToAuxWindowList;
		public virtual RMethod RAddToAuxWindowList
		{
			get
			{
				if(r_AddToAuxWindowList == null)
				{
					r_AddToAuxWindowList = new(this, "AddToAuxWindowList", 0);
					r_AddToAuxWindowList.SetBelong(this.instance);
				}
				return r_AddToAuxWindowList;
			}
		}

		/// <summary>
		/// Void SetInternalGameViewDimensions(UnityEngine.Rect, UnityEngine.Rect, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_SetInternalGameViewDimensions_Rect_Rect_Vector2;
		public virtual RMethod RSetInternalGameViewDimensions_Rect_Rect_Vector2
		{
			get
			{
				if(r_SetInternalGameViewDimensions_Rect_Rect_Vector2 == null)
				{
					r_SetInternalGameViewDimensions_Rect_Rect_Vector2 = new(this, "SetInternalGameViewDimensions", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2));
					r_SetInternalGameViewDimensions_Rect_Rect_Vector2.SetBelong(this.instance);
				}
				return r_SetInternalGameViewDimensions_Rect_Rect_Vector2;
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
		/// Void SetAsStartView()
		/// </summary>
		protected RMethod r_SetAsStartView;
		public virtual RMethod RSetAsStartView
		{
			get
			{
				if(r_SetAsStartView == null)
				{
					r_SetAsStartView = new(this, "SetAsStartView", 0);
					r_SetAsStartView.SetBelong(this.instance);
				}
				return r_SetAsStartView;
			}
		}

		/// <summary>
		/// Void SetAsLastPlayModeView()
		/// </summary>
		protected RMethod r_SetAsLastPlayModeView;
		public virtual RMethod RSetAsLastPlayModeView
		{
			get
			{
				if(r_SetAsLastPlayModeView == null)
				{
					r_SetAsLastPlayModeView = new(this, "SetAsLastPlayModeView", 0);
					r_SetAsLastPlayModeView.SetBelong(this.instance);
				}
				return r_SetAsLastPlayModeView;
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
		/// Void ClearStartView()
		/// </summary>
		protected RMethod r_ClearStartView;
		public virtual RMethod RClearStartView
		{
			get
			{
				if(r_ClearStartView == null)
				{
					r_ClearStartView = new(this, "ClearStartView", 0);
					r_ClearStartView.SetBelong(this.instance);
				}
				return r_ClearStartView;
			}
		}

		/// <summary>
		/// Void MakeVistaDWMHappyDance()
		/// </summary>
		protected RMethod r_MakeVistaDWMHappyDance;
		public virtual RMethod RMakeVistaDWMHappyDance
		{
			get
			{
				if(r_MakeVistaDWMHappyDance == null)
				{
					r_MakeVistaDWMHappyDance = new(this, "MakeVistaDWMHappyDance", 0);
					r_MakeVistaDWMHappyDance.SetBelong(this.instance);
				}
				return r_MakeVistaDWMHappyDance;
			}
		}

		/// <summary>
		/// Void SetEyeDropperOpen(Boolean)
		/// </summary>
		protected RMethod r_SetEyeDropperOpen_Boolean;
		public virtual RMethod RSetEyeDropperOpen_Boolean
		{
			get
			{
				if(r_SetEyeDropperOpen_Boolean == null)
				{
					r_SetEyeDropperOpen_Boolean = new(this, "SetEyeDropperOpen", 0, typeof(System.Boolean));
					r_SetEyeDropperOpen_Boolean.SetBelong(this.instance);
				}
				return r_SetEyeDropperOpen_Boolean;
			}
		}

		/// <summary>
		/// Void StealMouseCapture()
		/// </summary>
		protected RMethod r_StealMouseCapture;
		public virtual RMethod RStealMouseCapture
		{
			get
			{
				if(r_StealMouseCapture == null)
				{
					r_StealMouseCapture = new(this, "StealMouseCapture", 0);
					r_StealMouseCapture.SetBelong(this.instance);
				}
				return r_StealMouseCapture;
			}
		}

		/// <summary>
		/// Void ClearKeyboardControl()
		/// </summary>
		protected RMethod r_ClearKeyboardControl;
		public virtual RMethod RClearKeyboardControl
		{
			get
			{
				if(r_ClearKeyboardControl == null)
				{
					r_ClearKeyboardControl = new(this, "ClearKeyboardControl", 0);
					r_ClearKeyboardControl.SetBelong(this.instance);
				}
				return r_ClearKeyboardControl;
			}
		}

		/// <summary>
		/// Void SetKeyboardControl(Int32)
		/// </summary>
		protected RMethod r_SetKeyboardControl_Int32;
		public virtual RMethod RSetKeyboardControl_Int32
		{
			get
			{
				if(r_SetKeyboardControl_Int32 == null)
				{
					r_SetKeyboardControl_Int32 = new(this, "SetKeyboardControl", 0, typeof(System.Int32));
					r_SetKeyboardControl_Int32.SetBelong(this.instance);
				}
				return r_SetKeyboardControl_Int32;
			}
		}

		/// <summary>
		/// Int32 GetKeyboardControl()
		/// </summary>
		protected RMethod r_GetKeyboardControl;
		public virtual RMethod RGetKeyboardControl
		{
			get
			{
				if(r_GetKeyboardControl == null)
				{
					r_GetKeyboardControl = new(this, "GetKeyboardControl", 0);
					r_GetKeyboardControl.SetBelong(this.instance);
				}
				return r_GetKeyboardControl;
			}
		}

		/// <summary>
		/// Void GrabPixels(UnityEngine.RenderTexture, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_GrabPixels_RenderTexture_Rect;
		public virtual RMethod RGrabPixels_RenderTexture_Rect
		{
			get
			{
				if(r_GrabPixels_RenderTexture_Rect == null)
				{
					r_GrabPixels_RenderTexture_Rect = new(this, "GrabPixels", 0, typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Rect));
					r_GrabPixels_RenderTexture_Rect.SetBelong(this.instance);
				}
				return r_GrabPixels_RenderTexture_Rect;
			}
		}

		/// <summary>
		/// Void MarkHotRegion(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MarkHotRegion_Rect;
		public virtual RMethod RMarkHotRegion_Rect
		{
			get
			{
				if(r_MarkHotRegion_Rect == null)
				{
					r_MarkHotRegion_Rect = new(this, "MarkHotRegion", 0, typeof(UnityEngine.Rect));
					r_MarkHotRegion_Rect.SetBelong(this.instance);
				}
				return r_MarkHotRegion_Rect;
			}
		}

		/// <summary>
		/// Void EnableVSync(Boolean)
		/// </summary>
		protected RMethod r_EnableVSync_Boolean;
		public virtual RMethod REnableVSync_Boolean
		{
			get
			{
				if(r_EnableVSync_Boolean == null)
				{
					r_EnableVSync_Boolean = new(this, "EnableVSync", 0, typeof(System.Boolean));
					r_EnableVSync_Boolean.SetBelong(this.instance);
				}
				return r_EnableVSync_Boolean;
			}
		}

		/// <summary>
		/// Void SetActualViewName(System.String)
		/// </summary>
		protected RMethod r_SetActualViewName_String;
		public virtual RMethod RSetActualViewName_String
		{
			get
			{
				if(r_SetActualViewName_String == null)
				{
					r_SetActualViewName_String = new(this, "SetActualViewName", 0, typeof(System.String));
					r_SetActualViewName_String.SetBelong(this.instance);
				}
				return r_SetActualViewName_String;
			}
		}

		/// <summary>
		/// Void Internal_SetAsActiveWindow()
		/// </summary>
		protected RMethod r_Internal_SetAsActiveWindow;
		public virtual RMethod RInternal_SetAsActiveWindow
		{
			get
			{
				if(r_Internal_SetAsActiveWindow == null)
				{
					r_Internal_SetAsActiveWindow = new(this, "Internal_SetAsActiveWindow", 0);
					r_Internal_SetAsActiveWindow.SetBelong(this.instance);
				}
				return r_Internal_SetAsActiveWindow;
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
		/// Void RecreateContext()
		/// </summary>
		protected RMethod r_RecreateContext;
		public virtual RMethod RRecreateContext
		{
			get
			{
				if(r_RecreateContext == null)
				{
					r_RecreateContext = new(this, "RecreateContext", 0);
					r_RecreateContext.SetBelong(this.instance);
				}
				return r_RecreateContext;
			}
		}

		/// <summary>
		/// Void ValidateWindowBackendForCurrentView()
		/// </summary>
		protected RMethod r_ValidateWindowBackendForCurrentView;
		public virtual RMethod RValidateWindowBackendForCurrentView
		{
			get
			{
				if(r_ValidateWindowBackendForCurrentView == null)
				{
					r_ValidateWindowBackendForCurrentView = new(this, "ValidateWindowBackendForCurrentView", 0);
					r_ValidateWindowBackendForCurrentView.SetBelong(this.instance);
				}
				return r_ValidateWindowBackendForCurrentView;
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
		/// Void DoWindowDecorationStart()
		/// </summary>
		protected RMethod r_DoWindowDecorationStart;
		public virtual RMethod RDoWindowDecorationStart
		{
			get
			{
				if(r_DoWindowDecorationStart == null)
				{
					r_DoWindowDecorationStart = new(this, "DoWindowDecorationStart", 0);
					r_DoWindowDecorationStart.SetBelong(this.instance);
				}
				return r_DoWindowDecorationStart;
			}
		}

		/// <summary>
		/// Void DoWindowDecorationEnd()
		/// </summary>
		protected RMethod r_DoWindowDecorationEnd;
		public virtual RMethod RDoWindowDecorationEnd
		{
			get
			{
				if(r_DoWindowDecorationEnd == null)
				{
					r_DoWindowDecorationEnd = new(this, "DoWindowDecorationEnd", 0);
					r_DoWindowDecorationEnd.SetBelong(this.instance);
				}
				return r_DoWindowDecorationEnd;
			}
		}

		/// <summary>
		/// System.String GetViewName()
		/// </summary>
		protected RMethod r_GetViewName;
		public virtual RMethod RGetViewName
		{
			get
			{
				if(r_GetViewName == null)
				{
					r_GetViewName = new(this, "GetViewName", 0);
					r_GetViewName.SetBelong(this.instance);
				}
				return r_GetViewName;
			}
		}

		/// <summary>
		/// Void CaptureMetalScene()
		/// </summary>
		protected RMethod r_CaptureMetalScene;
		public virtual RMethod RCaptureMetalScene
		{
			get
			{
				if(r_CaptureMetalScene == null)
				{
					r_CaptureMetalScene = new(this, "CaptureMetalScene", 0);
					r_CaptureMetalScene.SetBelong(this.instance);
				}
				return r_CaptureMetalScene;
			}
		}

		/// <summary>
		/// Void Reflow()
		/// </summary>
		protected RMethod r_Reflow;
		public virtual RMethod RReflow
		{
			get
			{
				if(r_Reflow == null)
				{
					r_Reflow = new(this, "Reflow", 0);
					r_Reflow.SetBelong(this.instance);
				}
				return r_Reflow;
			}
		}

		/// <summary>
		/// System.String DebugHierarchy(Int32)
		/// </summary>
		protected RMethod r_DebugHierarchy_Int32;
		public virtual RMethod RDebugHierarchy_Int32
		{
			get
			{
				if(r_DebugHierarchy_Int32 == null)
				{
					r_DebugHierarchy_Int32 = new(this, "DebugHierarchy", 0, typeof(System.Int32));
					r_DebugHierarchy_Int32.SetBelong(this.instance);
				}
				return r_DebugHierarchy_Int32;
			}
		}

		/// <summary>
		/// Void Initialize(UnityEditor.ContainerWindow)
		/// </summary>
		protected RMethod r_Initialize_ContainerWindow;
		public virtual RMethod RInitialize_ContainerWindow
		{
			get
			{
				if(r_Initialize_ContainerWindow == null)
				{
					r_Initialize_ContainerWindow = new(this, "Initialize", 0,  ReleactionUtils.GetType("UnityEditor.ContainerWindow"));
					r_Initialize_ContainerWindow.SetBelong(this.instance);
				}
				return r_Initialize_ContainerWindow;
			}
		}

		/// <summary>
		/// Void SetMinMaxSizes(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_SetMinMaxSizes_Vector2_Vector2;
		public virtual RMethod RSetMinMaxSizes_Vector2_Vector2
		{
			get
			{
				if(r_SetMinMaxSizes_Vector2_Vector2 == null)
				{
					r_SetMinMaxSizes_Vector2_Vector2 = new(this, "SetMinMaxSizes", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_SetMinMaxSizes_Vector2_Vector2.SetBelong(this.instance);
				}
				return r_SetMinMaxSizes_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Void ChildrenMinMaxChanged()
		/// </summary>
		protected RMethod r_ChildrenMinMaxChanged;
		public virtual RMethod RChildrenMinMaxChanged
		{
			get
			{
				if(r_ChildrenMinMaxChanged == null)
				{
					r_ChildrenMinMaxChanged = new(this, "ChildrenMinMaxChanged", 0);
					r_ChildrenMinMaxChanged.SetBelong(this.instance);
				}
				return r_ChildrenMinMaxChanged;
			}
		}

		/// <summary>
		/// Void SetPositionOnly(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_SetPositionOnly_Rect;
		public virtual RMethod RSetPositionOnly_Rect
		{
			get
			{
				if(r_SetPositionOnly_Rect == null)
				{
					r_SetPositionOnly_Rect = new(this, "SetPositionOnly", 0, typeof(UnityEngine.Rect));
					r_SetPositionOnly_Rect.SetBelong(this.instance);
				}
				return r_SetPositionOnly_Rect;
			}
		}

		/// <summary>
		/// Int32 IndexOfChild(UnityEditor.View)
		/// </summary>
		protected RMethod r_IndexOfChild_View;
		public virtual RMethod RIndexOfChild_View
		{
			get
			{
				if(r_IndexOfChild_View == null)
				{
					r_IndexOfChild_View = new(this, "IndexOfChild", 0,  ReleactionUtils.GetType("UnityEditor.View"));
					r_IndexOfChild_View.SetBelong(this.instance);
				}
				return r_IndexOfChild_View;
			}
		}

		/// <summary>
		/// Void AddChild(UnityEditor.View)
		/// </summary>
		protected RMethod r_AddChild_View;
		public virtual RMethod RAddChild_View
		{
			get
			{
				if(r_AddChild_View == null)
				{
					r_AddChild_View = new(this, "AddChild", 0,  ReleactionUtils.GetType("UnityEditor.View"));
					r_AddChild_View.SetBelong(this.instance);
				}
				return r_AddChild_View;
			}
		}

		/// <summary>
		/// Void AddChild(UnityEditor.View, Int32)
		/// </summary>
		protected RMethod r_AddChild_View_Int32;
		public virtual RMethod RAddChild_View_Int32
		{
			get
			{
				if(r_AddChild_View_Int32 == null)
				{
					r_AddChild_View_Int32 = new(this, "AddChild", 0,  ReleactionUtils.GetType("UnityEditor.View"), typeof(System.Int32));
					r_AddChild_View_Int32.SetBelong(this.instance);
				}
				return r_AddChild_View_Int32;
			}
		}

		/// <summary>
		/// Void RemoveChild(UnityEditor.View)
		/// </summary>
		protected RMethod r_RemoveChild_View;
		public virtual RMethod RRemoveChild_View
		{
			get
			{
				if(r_RemoveChild_View == null)
				{
					r_RemoveChild_View = new(this, "RemoveChild", 0,  ReleactionUtils.GetType("UnityEditor.View"));
					r_RemoveChild_View.SetBelong(this.instance);
				}
				return r_RemoveChild_View;
			}
		}

		/// <summary>
		/// Void RemoveChild(Int32)
		/// </summary>
		protected RMethod r_RemoveChild_Int32;
		public virtual RMethod RRemoveChild_Int32
		{
			get
			{
				if(r_RemoveChild_Int32 == null)
				{
					r_RemoveChild_Int32 = new(this, "RemoveChild", 0, typeof(System.Int32));
					r_RemoveChild_Int32.SetBelong(this.instance);
				}
				return r_RemoveChild_Int32;
			}
		}

		/// <summary>
		/// Void SetWindowRecurse(UnityEditor.ContainerWindow)
		/// </summary>
		protected RMethod r_SetWindowRecurse_ContainerWindow;
		public virtual RMethod RSetWindowRecurse_ContainerWindow
		{
			get
			{
				if(r_SetWindowRecurse_ContainerWindow == null)
				{
					r_SetWindowRecurse_ContainerWindow = new(this, "SetWindowRecurse", 0,  ReleactionUtils.GetType("UnityEditor.ContainerWindow"));
					r_SetWindowRecurse_ContainerWindow.SetBelong(this.instance);
				}
				return r_SetWindowRecurse_ContainerWindow;
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
