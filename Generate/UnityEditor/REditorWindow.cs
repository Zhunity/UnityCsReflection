using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.EditorWindow
	/// </summary>
    public partial class REditorWindow : RMember //
    {

		/// <summary>
		/// System.Boolean m_AutoRepaintOnSceneChange
		/// </summary>
		protected RSystem.RBoolean r_m_AutoRepaintOnSceneChange;
		public virtual RSystem.RBoolean Rm_AutoRepaintOnSceneChange
		{
			get
			{
				if(r_m_AutoRepaintOnSceneChange == null)
				{
					r_m_AutoRepaintOnSceneChange = new(this, "m_AutoRepaintOnSceneChange");
					r_m_AutoRepaintOnSceneChange.SetBelong(this.instance);
				}
				return r_m_AutoRepaintOnSceneChange;
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
		/// System.Int32 m_DepthBufferBits
		/// </summary>
		protected RSystem.RInt32 r_m_DepthBufferBits;
		public virtual RSystem.RInt32 Rm_DepthBufferBits
		{
			get
			{
				if(r_m_DepthBufferBits == null)
				{
					r_m_DepthBufferBits = new(this, "m_DepthBufferBits");
					r_m_DepthBufferBits.SetBelong(this.instance);
				}
				return r_m_DepthBufferBits;
			}
		}

		/// <summary>
		/// System.Int32 m_AntiAliasing
		/// </summary>
		protected RSystem.RInt32 r_m_AntiAliasing;
		public virtual RSystem.RInt32 Rm_AntiAliasing
		{
			get
			{
				if(r_m_AntiAliasing == null)
				{
					r_m_AntiAliasing = new(this, "m_AntiAliasing");
					r_m_AntiAliasing.SetBelong(this.instance);
				}
				return r_m_AntiAliasing;
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
		/// UnityEngine.UIElements.VisualElement m_UIRootElement
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_m_UIRootElement;
		public virtual RUnityEngine.RUIElements.RVisualElement Rm_UIRootElement
		{
			get
			{
				if(r_m_UIRootElement == null)
				{
					r_m_UIRootElement = new(this, "m_UIRootElement");
					r_m_UIRootElement.SetBelong(this.instance);
				}
				return r_m_UIRootElement;
			}
		}

		/// <summary>
		/// UnityEditor.UIElements.SerializableJsonDictionary m_ViewDataDictionary
		/// </summary>
		protected RUnityEditor.RUIElements.RSerializableJsonDictionary r_m_ViewDataDictionary;
		public virtual RUnityEditor.RUIElements.RSerializableJsonDictionary Rm_ViewDataDictionary
		{
			get
			{
				if(r_m_ViewDataDictionary == null)
				{
					r_m_ViewDataDictionary = new(this, "m_ViewDataDictionary");
					r_m_ViewDataDictionary.SetBelong(this.instance);
				}
				return r_m_ViewDataDictionary;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayCanvas m_OverlayCanvas
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayCanvas r_m_OverlayCanvas;
		public virtual RUnityEditor.ROverlays.ROverlayCanvas Rm_OverlayCanvas
		{
			get
			{
				if(r_m_OverlayCanvas == null)
				{
					r_m_OverlayCanvas = new(this, "m_OverlayCanvas");
					r_m_OverlayCanvas.SetBelong(this.instance);
				}
				return r_m_OverlayCanvas;
			}
		}

		/// <summary>
		/// System.Boolean m_OverlaysInitialized
		/// </summary>
		protected RSystem.RBoolean r_m_OverlaysInitialized;
		public virtual RSystem.RBoolean Rm_OverlaysInitialized
		{
			get
			{
				if(r_m_OverlaysInitialized == null)
				{
					r_m_OverlaysInitialized = new(this, "m_OverlaysInitialized");
					r_m_OverlaysInitialized.SetBelong(this.instance);
				}
				return r_m_OverlaysInitialized;
			}
		}

		/// <summary>
		/// System.Boolean m_EnableViewDataPersistence
		/// </summary>
		protected RSystem.RBoolean r_m_EnableViewDataPersistence;
		public virtual RSystem.RBoolean Rm_EnableViewDataPersistence
		{
			get
			{
				if(r_m_EnableViewDataPersistence == null)
				{
					r_m_EnableViewDataPersistence = new(this, "m_EnableViewDataPersistence");
					r_m_EnableViewDataPersistence.SetBelong(this.instance);
				}
				return r_m_EnableViewDataPersistence;
			}
		}

		/// <summary>
		/// System.Boolean m_RequestedViewDataSave
		/// </summary>
		protected RSystem.RBoolean r_m_RequestedViewDataSave;
		public virtual RSystem.RBoolean Rm_RequestedViewDataSave
		{
			get
			{
				if(r_m_RequestedViewDataSave == null)
				{
					r_m_RequestedViewDataSave = new(this, "m_RequestedViewDataSave");
					r_m_RequestedViewDataSave.SetBelong(this.instance);
				}
				return r_m_RequestedViewDataSave;
			}
		}

		/// <summary>
		/// System.Action s_UpdateWindowMenuListingOff
		/// </summary>
		protected static RSystem.RAction r_s_UpdateWindowMenuListingOff;
		public static RSystem.RAction Rs_UpdateWindowMenuListingOff
		{
			get
			{
				if(r_s_UpdateWindowMenuListingOff == null)
				{
					r_s_UpdateWindowMenuListingOff = new(typeof(UnityEditor.EditorWindow), "s_UpdateWindowMenuListingOff");
					r_s_UpdateWindowMenuListingOff.SetBelong(null);
				}
				return r_s_UpdateWindowMenuListingOff;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_GameViewRect
		/// </summary>
		protected RUnityEngine.RRect r_m_GameViewRect;
		public virtual RUnityEngine.RRect Rm_GameViewRect
		{
			get
			{
				if(r_m_GameViewRect == null)
				{
					r_m_GameViewRect = new(this, "m_GameViewRect");
					r_m_GameViewRect.SetBelong(this.instance);
				}
				return r_m_GameViewRect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_GameViewClippedRect
		/// </summary>
		protected RUnityEngine.RRect r_m_GameViewClippedRect;
		public virtual RUnityEngine.RRect Rm_GameViewClippedRect
		{
			get
			{
				if(r_m_GameViewClippedRect == null)
				{
					r_m_GameViewClippedRect = new(this, "m_GameViewClippedRect");
					r_m_GameViewClippedRect.SetBelong(this.instance);
				}
				return r_m_GameViewClippedRect;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_GameViewTargetSize
		/// </summary>
		protected RUnityEngine.RVector2 r_m_GameViewTargetSize;
		public virtual RUnityEngine.RVector2 Rm_GameViewTargetSize
		{
			get
			{
				if(r_m_GameViewTargetSize == null)
				{
					r_m_GameViewTargetSize = new(this, "m_GameViewTargetSize");
					r_m_GameViewTargetSize.SetBelong(this.instance);
				}
				return r_m_GameViewTargetSize;
			}
		}

		/// <summary>
		/// System.Boolean m_IsPlayModeView
		/// </summary>
		protected RSystem.RBoolean r_m_IsPlayModeView;
		public virtual RSystem.RBoolean Rm_IsPlayModeView
		{
			get
			{
				if(r_m_IsPlayModeView == null)
				{
					r_m_IsPlayModeView = new(this, "m_IsPlayModeView");
					r_m_IsPlayModeView.SetBelong(this.instance);
				}
				return r_m_IsPlayModeView;
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
		/// System.Boolean m_DisableInputEvents
		/// </summary>
		protected RSystem.RBoolean r_m_DisableInputEvents;
		public virtual RSystem.RBoolean Rm_DisableInputEvents
		{
			get
			{
				if(r_m_DisableInputEvents == null)
				{
					r_m_DisableInputEvents = new(this, "m_DisableInputEvents");
					r_m_DisableInputEvents.SetBelong(this.instance);
				}
				return r_m_DisableInputEvents;
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
		/// System.Double kWarningFadeoutWait
		/// </summary>
		protected static RSystem.RDouble r_kWarningFadeoutWait;
		public static RSystem.RDouble RkWarningFadeoutWait
		{
			get
			{
				if(r_kWarningFadeoutWait == null)
				{
					r_kWarningFadeoutWait = new(typeof(UnityEditor.EditorWindow), "kWarningFadeoutWait");
					r_kWarningFadeoutWait.SetBelong(null);
				}
				return r_kWarningFadeoutWait;
			}
		}

		/// <summary>
		/// System.Double kWarningFadeoutTime
		/// </summary>
		protected static RSystem.RDouble r_kWarningFadeoutTime;
		public static RSystem.RDouble RkWarningFadeoutTime
		{
			get
			{
				if(r_kWarningFadeoutTime == null)
				{
					r_kWarningFadeoutTime = new(typeof(UnityEditor.EditorWindow), "kWarningFadeoutTime");
					r_kWarningFadeoutTime.SetBelong(null);
				}
				return r_kWarningFadeoutTime;
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
		/// UnityEngine.Vector2 m_NotificationSize
		/// </summary>
		protected RUnityEngine.RVector2 r_m_NotificationSize;
		public virtual RUnityEngine.RVector2 Rm_NotificationSize
		{
			get
			{
				if(r_m_NotificationSize == null)
				{
					r_m_NotificationSize = new(this, "m_NotificationSize");
					r_m_NotificationSize.SetBelong(this.instance);
				}
				return r_m_NotificationSize;
			}
		}

		/// <summary>
		/// System.Single m_FadeoutTime
		/// </summary>
		protected RSystem.RSingle r_m_FadeoutTime;
		public virtual RSystem.RSingle Rm_FadeoutTime
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
		/// System.Boolean m_HasUnsavedChanges
		/// </summary>
		protected RSystem.RBoolean r_m_HasUnsavedChanges;
		public virtual RSystem.RBoolean Rm_HasUnsavedChanges
		{
			get
			{
				if(r_m_HasUnsavedChanges == null)
				{
					r_m_HasUnsavedChanges = new(this, "m_HasUnsavedChanges");
					r_m_HasUnsavedChanges.SetBelong(this.instance);
				}
				return r_m_HasUnsavedChanges;
			}
		}

		/// <summary>
		/// System.String <saveChangesMessage>k__BackingField
		/// </summary>
		protected RSystem.RString r___0__saveChangesMessage__1__k__BackingField;
		public virtual RSystem.RString R__0__saveChangesMessage__1__k__BackingField
		{
			get
			{
				if(r___0__saveChangesMessage__1__k__BackingField == null)
				{
					r___0__saveChangesMessage__1__k__BackingField = new(this, "<saveChangesMessage>k__BackingField");
					r___0__saveChangesMessage__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__saveChangesMessage__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow+OverlayShortcutContext s_ShortcutContext
		/// </summary>
		protected static RUnityEditor.REditorWindow.ROverlayShortcutContext r_s_ShortcutContext;
		public static RUnityEditor.REditorWindow.ROverlayShortcutContext Rs_ShortcutContext
		{
			get
			{
				if(r_s_ShortcutContext == null)
				{
					r_s_ShortcutContext = new(typeof(UnityEditor.EditorWindow), "s_ShortcutContext");
					r_s_ShortcutContext.SetBelong(null);
				}
				return r_s_ShortcutContext;
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
		protected RSystem.RBoolean r_liveReloadPreferenceDefault;
		public virtual RSystem.RBoolean RliveReloadPreferenceDefault
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
		protected RSystem.RBoolean r_isUIToolkitWindow;
		public virtual RSystem.RBoolean RisUIToolkitWindow
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
		protected RSystem.RBoolean r_wantsMouseMove;
		public virtual RSystem.RBoolean RwantsMouseMove
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
		protected RSystem.RBoolean r_wantsMouseEnterLeaveWindow;
		public virtual RSystem.RBoolean RwantsMouseEnterLeaveWindow
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
		protected RSystem.RBoolean r_wantsLessLayoutEvents;
		public virtual RSystem.RBoolean RwantsLessLayoutEvents
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
		protected RSystem.RBoolean r_autoRepaintOnSceneChange;
		public virtual RSystem.RBoolean RautoRepaintOnSceneChange
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
		protected RSystem.RBoolean r_maximized;
		public virtual RSystem.RBoolean Rmaximized
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
		protected RSystem.RBoolean r_hasFocus;
		public virtual RSystem.RBoolean RhasFocus
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
		protected RSystem.RBoolean r_docked;
		public virtual RSystem.RBoolean Rdocked
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
		protected RSystem.RBoolean r_disableInputEvents;
		public virtual RSystem.RBoolean RdisableInputEvents
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
		/// UnityEditor.EditorWindow focusedWindow
		/// </summary>
		protected static RUnityEditor.REditorWindow r_focusedWindow;
		public static RUnityEditor.REditorWindow RfocusedWindow
		{
			get
			{
				if(r_focusedWindow == null)
				{
					r_focusedWindow = new(typeof(UnityEditor.EditorWindow), "focusedWindow", -1);
					r_focusedWindow.SetBelong(null);
				}
				return r_focusedWindow;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow mouseOverWindow
		/// </summary>
		protected static RUnityEditor.REditorWindow r_mouseOverWindow;
		public static RUnityEditor.REditorWindow RmouseOverWindow
		{
			get
			{
				if(r_mouseOverWindow == null)
				{
					r_mouseOverWindow = new(typeof(UnityEditor.EditorWindow), "mouseOverWindow", -1);
					r_mouseOverWindow.SetBelong(null);
				}
				return r_mouseOverWindow;
			}
		}

		/// <summary>
		/// Boolean hasUnsavedChanges
		/// </summary>
		protected RSystem.RBoolean r_hasUnsavedChanges;
		public virtual RSystem.RBoolean RhasUnsavedChanges
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
		protected RSystem.RString r_saveChangesMessage;
		public virtual RSystem.RString RsaveChangesMessage
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
		protected RSystem.RString r_title;
		public virtual RSystem.RString Rtitle
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
		protected RSystem.RInt32 r_depthBufferBits;
		public virtual RSystem.RInt32 RdepthBufferBits
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
		protected RSystem.RInt32 r_antiAliasing;
		public virtual RSystem.RInt32 RantiAliasing
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
		protected RSystem.RInt32 r_antiAlias;
		public virtual RSystem.RInt32 RantiAlias
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
		protected RSystem.RString r_name;
		public virtual RSystem.RString Rname
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
		/// Void Internal_MakeModal(UnityEditor.ContainerWindow)
		/// </summary>
		protected static RMethod r_Internal_MakeModal_ContainerWindow;
		public static RMethod RInternal_MakeModal_ContainerWindow
		{
			get
			{
				if(r_Internal_MakeModal_ContainerWindow == null)
				{
					r_Internal_MakeModal_ContainerWindow = new(typeof(UnityEditor.EditorWindow), "Internal_MakeModal", 0,  ReflectionUtils.GetType("UnityEditor.ContainerWindow"));
					r_Internal_MakeModal_ContainerWindow.SetBelong(null);
				}
				return r_Internal_MakeModal_ContainerWindow;
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
		/// Void SaveViewDataToDisk()
		/// </summary>
		protected RMethod r_SaveViewDataToDisk;
		public virtual RMethod RSaveViewDataToDisk
		{
			get
			{
				if(r_SaveViewDataToDisk == null)
				{
					r_SaveViewDataToDisk = new(this, "SaveViewDataToDisk", 0);
					r_SaveViewDataToDisk.SetBelong(this.instance);
				}
				return r_SaveViewDataToDisk;
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
		/// UnityEngine.GUIContent GetLocalizedTitleContentFromType(System.Type)
		/// </summary>
		protected static RMethod r_GetLocalizedTitleContentFromType_Type;
		public static RMethod RGetLocalizedTitleContentFromType_Type
		{
			get
			{
				if(r_GetLocalizedTitleContentFromType_Type == null)
				{
					r_GetLocalizedTitleContentFromType_Type = new(typeof(UnityEditor.EditorWindow), "GetLocalizedTitleContentFromType", 0, typeof(System.Type));
					r_GetLocalizedTitleContentFromType_Type.SetBelong(null);
				}
				return r_GetLocalizedTitleContentFromType_Type;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindowTitleAttribute GetEditorWindowTitleAttribute(System.Type)
		/// </summary>
		protected static RMethod r_GetEditorWindowTitleAttribute_Type;
		public static RMethod RGetEditorWindowTitleAttribute_Type
		{
			get
			{
				if(r_GetEditorWindowTitleAttribute_Type == null)
				{
					r_GetEditorWindowTitleAttribute_Type = new(typeof(UnityEditor.EditorWindow), "GetEditorWindowTitleAttribute", 0, typeof(System.Type));
					r_GetEditorWindowTitleAttribute_Type.SetBelong(null);
				}
				return r_GetEditorWindowTitleAttribute_Type;
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
		/// Void MakeModal()
		/// </summary>
		protected RMethod r_MakeModal;
		public virtual RMethod RMakeModal
		{
			get
			{
				if(r_MakeModal == null)
				{
					r_MakeModal = new(this, "MakeModal", 0);
					r_MakeModal.SetBelong(this.instance);
				}
				return r_MakeModal;
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
		/// UnityEditor.EditorWindow GetWindowPrivate(System.Type, Boolean, System.String, Boolean)
		/// </summary>
		protected static RMethod r_GetWindowPrivate_Type_Boolean_String_Boolean;
		public static RMethod RGetWindowPrivate_Type_Boolean_String_Boolean
		{
			get
			{
				if(r_GetWindowPrivate_Type_Boolean_String_Boolean == null)
				{
					r_GetWindowPrivate_Type_Boolean_String_Boolean = new(typeof(UnityEditor.EditorWindow), "GetWindowPrivate", 0, typeof(System.Type), typeof(System.Boolean), typeof(System.String), typeof(System.Boolean));
					r_GetWindowPrivate_Type_Boolean_String_Boolean.SetBelong(null);
				}
				return r_GetWindowPrivate_Type_Boolean_String_Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow GetWindow(System.Type, Boolean, System.String, Boolean)
		/// </summary>
		protected static RMethod r_GetWindow_Type_Boolean_String_Boolean;
		public static RMethod RGetWindow_Type_Boolean_String_Boolean
		{
			get
			{
				if(r_GetWindow_Type_Boolean_String_Boolean == null)
				{
					r_GetWindow_Type_Boolean_String_Boolean = new(typeof(UnityEditor.EditorWindow), "GetWindow", 0, typeof(System.Type), typeof(System.Boolean), typeof(System.String), typeof(System.Boolean));
					r_GetWindow_Type_Boolean_String_Boolean.SetBelong(null);
				}
				return r_GetWindow_Type_Boolean_String_Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow GetWindow(System.Type, Boolean, System.String)
		/// </summary>
		protected static RMethod r_GetWindow_Type_Boolean_String;
		public static RMethod RGetWindow_Type_Boolean_String
		{
			get
			{
				if(r_GetWindow_Type_Boolean_String == null)
				{
					r_GetWindow_Type_Boolean_String = new(typeof(UnityEditor.EditorWindow), "GetWindow", 0, typeof(System.Type), typeof(System.Boolean), typeof(System.String));
					r_GetWindow_Type_Boolean_String.SetBelong(null);
				}
				return r_GetWindow_Type_Boolean_String;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow GetWindow(System.Type, Boolean)
		/// </summary>
		protected static RMethod r_GetWindow_Type_Boolean;
		public static RMethod RGetWindow_Type_Boolean
		{
			get
			{
				if(r_GetWindow_Type_Boolean == null)
				{
					r_GetWindow_Type_Boolean = new(typeof(UnityEditor.EditorWindow), "GetWindow", 0, typeof(System.Type), typeof(System.Boolean));
					r_GetWindow_Type_Boolean.SetBelong(null);
				}
				return r_GetWindow_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow GetWindow(System.Type)
		/// </summary>
		protected static RMethod r_GetWindow_Type;
		public static RMethod RGetWindow_Type
		{
			get
			{
				if(r_GetWindow_Type == null)
				{
					r_GetWindow_Type = new(typeof(UnityEditor.EditorWindow), "GetWindow", 0, typeof(System.Type));
					r_GetWindow_Type.SetBelong(null);
				}
				return r_GetWindow_Type;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow GetWindowWithRect(System.Type, UnityEngine.Rect, Boolean, System.String)
		/// </summary>
		protected static RMethod r_GetWindowWithRect_Type_Rect_Boolean_String;
		public static RMethod RGetWindowWithRect_Type_Rect_Boolean_String
		{
			get
			{
				if(r_GetWindowWithRect_Type_Rect_Boolean_String == null)
				{
					r_GetWindowWithRect_Type_Rect_Boolean_String = new(typeof(UnityEditor.EditorWindow), "GetWindowWithRect", 0, typeof(System.Type), typeof(UnityEngine.Rect), typeof(System.Boolean), typeof(System.String));
					r_GetWindowWithRect_Type_Rect_Boolean_String.SetBelong(null);
				}
				return r_GetWindowWithRect_Type_Rect_Boolean_String;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow GetWindowWithRect(System.Type, UnityEngine.Rect, Boolean)
		/// </summary>
		protected static RMethod r_GetWindowWithRect_Type_Rect_Boolean;
		public static RMethod RGetWindowWithRect_Type_Rect_Boolean
		{
			get
			{
				if(r_GetWindowWithRect_Type_Rect_Boolean == null)
				{
					r_GetWindowWithRect_Type_Rect_Boolean = new(typeof(UnityEditor.EditorWindow), "GetWindowWithRect", 0, typeof(System.Type), typeof(UnityEngine.Rect), typeof(System.Boolean));
					r_GetWindowWithRect_Type_Rect_Boolean.SetBelong(null);
				}
				return r_GetWindowWithRect_Type_Rect_Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow GetWindowWithRect(System.Type, UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_GetWindowWithRect_Type_Rect;
		public static RMethod RGetWindowWithRect_Type_Rect
		{
			get
			{
				if(r_GetWindowWithRect_Type_Rect == null)
				{
					r_GetWindowWithRect_Type_Rect = new(typeof(UnityEditor.EditorWindow), "GetWindowWithRect", 0, typeof(System.Type), typeof(UnityEngine.Rect));
					r_GetWindowWithRect_Type_Rect.SetBelong(null);
				}
				return r_GetWindowWithRect_Type_Rect;
			}
		}

		/// <summary>
		/// T GetWindow[T]()
		/// </summary>
		protected static RMethod r_GetWindow_GT;
		public static RMethod RGetWindow_GT
		{
			get
			{
				if(r_GetWindow_GT == null)
				{
					r_GetWindow_GT = new(typeof(UnityEditor.EditorWindow), "GetWindow", 1);
					r_GetWindow_GT.SetBelong(null);
				}
				return r_GetWindow_GT;
			}
		}

		/// <summary>
		/// T GetWindow[T](Boolean)
		/// </summary>
		protected static RMethod r_GetWindow_GT_Boolean;
		public static RMethod RGetWindow_GT_Boolean
		{
			get
			{
				if(r_GetWindow_GT_Boolean == null)
				{
					r_GetWindow_GT_Boolean = new(typeof(UnityEditor.EditorWindow), "GetWindow", 1, typeof(System.Boolean));
					r_GetWindow_GT_Boolean.SetBelong(null);
				}
				return r_GetWindow_GT_Boolean;
			}
		}

		/// <summary>
		/// T GetWindow[T](Boolean, System.String)
		/// </summary>
		protected static RMethod r_GetWindow_GT_Boolean_String;
		public static RMethod RGetWindow_GT_Boolean_String
		{
			get
			{
				if(r_GetWindow_GT_Boolean_String == null)
				{
					r_GetWindow_GT_Boolean_String = new(typeof(UnityEditor.EditorWindow), "GetWindow", 1, typeof(System.Boolean), typeof(System.String));
					r_GetWindow_GT_Boolean_String.SetBelong(null);
				}
				return r_GetWindow_GT_Boolean_String;
			}
		}

		/// <summary>
		/// T GetWindow[T](System.String)
		/// </summary>
		protected static RMethod r_GetWindow_GT_String;
		public static RMethod RGetWindow_GT_String
		{
			get
			{
				if(r_GetWindow_GT_String == null)
				{
					r_GetWindow_GT_String = new(typeof(UnityEditor.EditorWindow), "GetWindow", 1, typeof(System.String));
					r_GetWindow_GT_String.SetBelong(null);
				}
				return r_GetWindow_GT_String;
			}
		}

		/// <summary>
		/// T GetWindow[T](System.String, Boolean)
		/// </summary>
		protected static RMethod r_GetWindow_GT_String_Boolean;
		public static RMethod RGetWindow_GT_String_Boolean
		{
			get
			{
				if(r_GetWindow_GT_String_Boolean == null)
				{
					r_GetWindow_GT_String_Boolean = new(typeof(UnityEditor.EditorWindow), "GetWindow", 1, typeof(System.String), typeof(System.Boolean));
					r_GetWindow_GT_String_Boolean.SetBelong(null);
				}
				return r_GetWindow_GT_String_Boolean;
			}
		}

		/// <summary>
		/// T GetWindow[T](Boolean, System.String, Boolean)
		/// </summary>
		protected static RMethod r_GetWindow_GT_Boolean_String_Boolean;
		public static RMethod RGetWindow_GT_Boolean_String_Boolean
		{
			get
			{
				if(r_GetWindow_GT_Boolean_String_Boolean == null)
				{
					r_GetWindow_GT_Boolean_String_Boolean = new(typeof(UnityEditor.EditorWindow), "GetWindow", 1, typeof(System.Boolean), typeof(System.String), typeof(System.Boolean));
					r_GetWindow_GT_Boolean_String_Boolean.SetBelong(null);
				}
				return r_GetWindow_GT_Boolean_String_Boolean;
			}
		}

		/// <summary>
		/// T GetWindow[T](System.Type[])
		/// </summary>
		protected static RMethod r_GetWindow_GT_TypeArray;
		public static RMethod RGetWindow_GT_TypeArray
		{
			get
			{
				if(r_GetWindow_GT_TypeArray == null)
				{
					r_GetWindow_GT_TypeArray = new(typeof(UnityEditor.EditorWindow), "GetWindow", 1, typeof(System.Type).MakeArrayType());
					r_GetWindow_GT_TypeArray.SetBelong(null);
				}
				return r_GetWindow_GT_TypeArray;
			}
		}

		/// <summary>
		/// T GetWindow[T](System.String, System.Type[])
		/// </summary>
		protected static RMethod r_GetWindow_GT_String_TypeArray;
		public static RMethod RGetWindow_GT_String_TypeArray
		{
			get
			{
				if(r_GetWindow_GT_String_TypeArray == null)
				{
					r_GetWindow_GT_String_TypeArray = new(typeof(UnityEditor.EditorWindow), "GetWindow", 1, typeof(System.String), typeof(System.Type).MakeArrayType());
					r_GetWindow_GT_String_TypeArray.SetBelong(null);
				}
				return r_GetWindow_GT_String_TypeArray;
			}
		}

		/// <summary>
		/// T GetWindow[T](System.String, Boolean, System.Type[])
		/// </summary>
		protected static RMethod r_GetWindow_GT_String_Boolean_TypeArray;
		public static RMethod RGetWindow_GT_String_Boolean_TypeArray
		{
			get
			{
				if(r_GetWindow_GT_String_Boolean_TypeArray == null)
				{
					r_GetWindow_GT_String_Boolean_TypeArray = new(typeof(UnityEditor.EditorWindow), "GetWindow", 1, typeof(System.String), typeof(System.Boolean), typeof(System.Type).MakeArrayType());
					r_GetWindow_GT_String_Boolean_TypeArray.SetBelong(null);
				}
				return r_GetWindow_GT_String_Boolean_TypeArray;
			}
		}

		/// <summary>
		/// T CreateWindow[T](System.Type[])
		/// </summary>
		protected static RMethod r_CreateWindow_GT_TypeArray;
		public static RMethod RCreateWindow_GT_TypeArray
		{
			get
			{
				if(r_CreateWindow_GT_TypeArray == null)
				{
					r_CreateWindow_GT_TypeArray = new(typeof(UnityEditor.EditorWindow), "CreateWindow", 1, typeof(System.Type).MakeArrayType());
					r_CreateWindow_GT_TypeArray.SetBelong(null);
				}
				return r_CreateWindow_GT_TypeArray;
			}
		}

		/// <summary>
		/// T CreateWindow[T](System.String, System.Type[])
		/// </summary>
		protected static RMethod r_CreateWindow_GT_String_TypeArray;
		public static RMethod RCreateWindow_GT_String_TypeArray
		{
			get
			{
				if(r_CreateWindow_GT_String_TypeArray == null)
				{
					r_CreateWindow_GT_String_TypeArray = new(typeof(UnityEditor.EditorWindow), "CreateWindow", 1, typeof(System.String), typeof(System.Type).MakeArrayType());
					r_CreateWindow_GT_String_TypeArray.SetBelong(null);
				}
				return r_CreateWindow_GT_String_TypeArray;
			}
		}

		/// <summary>
		/// Boolean HasOpenInstances[T]()
		/// </summary>
		protected static RMethod r_HasOpenInstances_GT;
		public static RMethod RHasOpenInstances_GT
		{
			get
			{
				if(r_HasOpenInstances_GT == null)
				{
					r_HasOpenInstances_GT = new(typeof(UnityEditor.EditorWindow), "HasOpenInstances", 1);
					r_HasOpenInstances_GT.SetBelong(null);
				}
				return r_HasOpenInstances_GT;
			}
		}

		/// <summary>
		/// Void FocusWindowIfItsOpen(System.Type)
		/// </summary>
		protected static RMethod r_FocusWindowIfItsOpen_Type;
		public static RMethod RFocusWindowIfItsOpen_Type
		{
			get
			{
				if(r_FocusWindowIfItsOpen_Type == null)
				{
					r_FocusWindowIfItsOpen_Type = new(typeof(UnityEditor.EditorWindow), "FocusWindowIfItsOpen", 0, typeof(System.Type));
					r_FocusWindowIfItsOpen_Type.SetBelong(null);
				}
				return r_FocusWindowIfItsOpen_Type;
			}
		}

		/// <summary>
		/// Void FocusWindowIfItsOpen[T]()
		/// </summary>
		protected static RMethod r_FocusWindowIfItsOpen_GT;
		public static RMethod RFocusWindowIfItsOpen_GT
		{
			get
			{
				if(r_FocusWindowIfItsOpen_GT == null)
				{
					r_FocusWindowIfItsOpen_GT = new(typeof(UnityEditor.EditorWindow), "FocusWindowIfItsOpen", 1);
					r_FocusWindowIfItsOpen_GT.SetBelong(null);
				}
				return r_FocusWindowIfItsOpen_GT;
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
		/// UnityEditor.EditorWindow GetWindowWithRectPrivate(System.Type, UnityEngine.Rect, Boolean, System.String)
		/// </summary>
		protected static RMethod r_GetWindowWithRectPrivate_Type_Rect_Boolean_String;
		public static RMethod RGetWindowWithRectPrivate_Type_Rect_Boolean_String
		{
			get
			{
				if(r_GetWindowWithRectPrivate_Type_Rect_Boolean_String == null)
				{
					r_GetWindowWithRectPrivate_Type_Rect_Boolean_String = new(typeof(UnityEditor.EditorWindow), "GetWindowWithRectPrivate", 0, typeof(System.Type), typeof(UnityEngine.Rect), typeof(System.Boolean), typeof(System.String));
					r_GetWindowWithRectPrivate_Type_Rect_Boolean_String.SetBelong(null);
				}
				return r_GetWindowWithRectPrivate_Type_Rect_Boolean_String;
			}
		}

		/// <summary>
		/// T GetWindowWithRect[T](UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_GetWindowWithRect_GT_Rect;
		public static RMethod RGetWindowWithRect_GT_Rect
		{
			get
			{
				if(r_GetWindowWithRect_GT_Rect == null)
				{
					r_GetWindowWithRect_GT_Rect = new(typeof(UnityEditor.EditorWindow), "GetWindowWithRect", 1, typeof(UnityEngine.Rect));
					r_GetWindowWithRect_GT_Rect.SetBelong(null);
				}
				return r_GetWindowWithRect_GT_Rect;
			}
		}

		/// <summary>
		/// T GetWindowWithRect[T](UnityEngine.Rect, Boolean)
		/// </summary>
		protected static RMethod r_GetWindowWithRect_GT_Rect_Boolean;
		public static RMethod RGetWindowWithRect_GT_Rect_Boolean
		{
			get
			{
				if(r_GetWindowWithRect_GT_Rect_Boolean == null)
				{
					r_GetWindowWithRect_GT_Rect_Boolean = new(typeof(UnityEditor.EditorWindow), "GetWindowWithRect", 1, typeof(UnityEngine.Rect), typeof(System.Boolean));
					r_GetWindowWithRect_GT_Rect_Boolean.SetBelong(null);
				}
				return r_GetWindowWithRect_GT_Rect_Boolean;
			}
		}

		/// <summary>
		/// T GetWindowWithRect[T](UnityEngine.Rect, Boolean, System.String)
		/// </summary>
		protected static RMethod r_GetWindowWithRect_GT_Rect_Boolean_String;
		public static RMethod RGetWindowWithRect_GT_Rect_Boolean_String
		{
			get
			{
				if(r_GetWindowWithRect_GT_Rect_Boolean_String == null)
				{
					r_GetWindowWithRect_GT_Rect_Boolean_String = new(typeof(UnityEditor.EditorWindow), "GetWindowWithRect", 1, typeof(UnityEngine.Rect), typeof(System.Boolean), typeof(System.String));
					r_GetWindowWithRect_GT_Rect_Boolean_String.SetBelong(null);
				}
				return r_GetWindowWithRect_GT_Rect_Boolean_String;
			}
		}

		/// <summary>
		/// T GetWindowWithRect[T](UnityEngine.Rect, Boolean, System.String, Boolean)
		/// </summary>
		protected static RMethod r_GetWindowWithRect_GT_Rect_Boolean_String_Boolean;
		public static RMethod RGetWindowWithRect_GT_Rect_Boolean_String_Boolean
		{
			get
			{
				if(r_GetWindowWithRect_GT_Rect_Boolean_String_Boolean == null)
				{
					r_GetWindowWithRect_GT_Rect_Boolean_String_Boolean = new(typeof(UnityEditor.EditorWindow), "GetWindowWithRect", 1, typeof(UnityEngine.Rect), typeof(System.Boolean), typeof(System.String), typeof(System.Boolean));
					r_GetWindowWithRect_GT_Rect_Boolean_String_Boolean.SetBelong(null);
				}
				return r_GetWindowWithRect_GT_Rect_Boolean_String_Boolean;
			}
		}

		/// <summary>
		/// T GetWindowDontShow[T]()
		/// </summary>
		protected static RMethod r_GetWindowDontShow_GT;
		public static RMethod RGetWindowDontShow_GT
		{
			get
			{
				if(r_GetWindowDontShow_GT == null)
				{
					r_GetWindowDontShow_GT = new(typeof(UnityEditor.EditorWindow), "GetWindowDontShow", 1);
					r_GetWindowDontShow_GT.SetBelong(null);
				}
				return r_GetWindowDontShow_GT;
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
		/// Void __internalAwake()
		/// </summary>
		protected RMethod r___internalAwake;
		public virtual RMethod R__internalAwake
		{
			get
			{
				if(r___internalAwake == null)
				{
					r___internalAwake = new(this, "__internalAwake", 0);
					r___internalAwake.SetBelong(this.instance);
				}
				return r___internalAwake;
			}
		}

		/// <summary>
		/// Void Initialize()
		/// </summary>
		protected static RMethod r_Initialize;
		public static RMethod RInitialize
		{
			get
			{
				if(r_Initialize == null)
				{
					r_Initialize = new(typeof(UnityEditor.EditorWindow), "Initialize", 0);
					r_Initialize.SetBelong(null);
				}
				return r_Initialize;
			}
		}

		/// <summary>
		/// Void OnDisableINTERNAL()
		/// </summary>
		protected RMethod r_OnDisableINTERNAL;
		public virtual RMethod ROnDisableINTERNAL
		{
			get
			{
				if(r_OnDisableINTERNAL == null)
				{
					r_OnDisableINTERNAL = new(this, "OnDisableINTERNAL", 0);
					r_OnDisableINTERNAL.SetBelong(this.instance);
				}
				return r_OnDisableINTERNAL;
			}
		}

		/// <summary>
		/// Void CreateNewWindowForEditorWindow(UnityEditor.EditorWindow, Boolean, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_CreateNewWindowForEditorWindow_EditorWindow_Boolean_Boolean_Boolean;
		public static RMethod RCreateNewWindowForEditorWindow_EditorWindow_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_CreateNewWindowForEditorWindow_EditorWindow_Boolean_Boolean_Boolean == null)
				{
					r_CreateNewWindowForEditorWindow_EditorWindow_Boolean_Boolean_Boolean = new(typeof(UnityEditor.EditorWindow), "CreateNewWindowForEditorWindow", 0, typeof(UnityEditor.EditorWindow), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_CreateNewWindowForEditorWindow_EditorWindow_Boolean_Boolean_Boolean.SetBelong(null);
				}
				return r_CreateNewWindowForEditorWindow_EditorWindow_Boolean_Boolean_Boolean;
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
		/// Void UpdateWindowMenuListing()
		/// </summary>
		protected static RMethod r_UpdateWindowMenuListing;
		public static RMethod RUpdateWindowMenuListing
		{
			get
			{
				if(r_UpdateWindowMenuListing == null)
				{
					r_UpdateWindowMenuListing = new(typeof(UnityEditor.EditorWindow), "UpdateWindowMenuListing", 0);
					r_UpdateWindowMenuListing.SetBelong(null);
				}
				return r_UpdateWindowMenuListing;
			}
		}

		/// <summary>
		/// Void BuildWindowMenuListing()
		/// </summary>
		protected static RMethod r_BuildWindowMenuListing;
		public static RMethod RBuildWindowMenuListing
		{
			get
			{
				if(r_BuildWindowMenuListing == null)
				{
					r_BuildWindowMenuListing = new(typeof(UnityEditor.EditorWindow), "BuildWindowMenuListing", 0);
					r_BuildWindowMenuListing.SetBelong(null);
				}
				return r_BuildWindowMenuListing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement CreateRoot()
		/// </summary>
		protected static RMethod r_CreateRoot;
		public static RMethod RCreateRoot
		{
			get
			{
				if(r_CreateRoot == null)
				{
					r_CreateRoot = new(typeof(UnityEditor.EditorWindow), "CreateRoot", 0);
					r_CreateRoot.SetBelong(null);
				}
				return r_CreateRoot;
			}
		}

		/// <summary>
		/// Void ToggleAllOverlays(UnityEditor.ShortcutManagement.ShortcutArguments)
		/// </summary>
		protected static RMethod r_ToggleAllOverlays_ShortcutArguments;
		public static RMethod RToggleAllOverlays_ShortcutArguments
		{
			get
			{
				if(r_ToggleAllOverlays_ShortcutArguments == null)
				{
					r_ToggleAllOverlays_ShortcutArguments = new(typeof(UnityEditor.EditorWindow), "ToggleAllOverlays", 0, typeof(UnityEditor.ShortcutManagement.ShortcutArguments));
					r_ToggleAllOverlays_ShortcutArguments.SetBelong(null);
				}
				return r_ToggleAllOverlays_ShortcutArguments;
			}
		}

		/// <summary>
		/// Void HideOverlay(UnityEditor.ShortcutManagement.ShortcutArguments)
		/// </summary>
		protected static RMethod r_HideOverlay_ShortcutArguments;
		public static RMethod RHideOverlay_ShortcutArguments
		{
			get
			{
				if(r_HideOverlay_ShortcutArguments == null)
				{
					r_HideOverlay_ShortcutArguments = new(typeof(UnityEditor.EditorWindow), "HideOverlay", 0, typeof(UnityEditor.ShortcutManagement.ShortcutArguments));
					r_HideOverlay_ShortcutArguments.SetBelong(null);
				}
				return r_HideOverlay_ShortcutArguments;
			}
		}

		/// <summary>
		/// Void ShowOverlayMenu(UnityEditor.ShortcutManagement.ShortcutArguments)
		/// </summary>
		protected static RMethod r_ShowOverlayMenu_ShortcutArguments;
		public static RMethod RShowOverlayMenu_ShortcutArguments
		{
			get
			{
				if(r_ShowOverlayMenu_ShortcutArguments == null)
				{
					r_ShowOverlayMenu_ShortcutArguments = new(typeof(UnityEditor.EditorWindow), "ShowOverlayMenu", 0, typeof(UnityEditor.ShortcutManagement.ShortcutArguments));
					r_ShowOverlayMenu_ShortcutArguments.SetBelong(null);
				}
				return r_ShowOverlayMenu_ShortcutArguments;
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


        public REditorWindow() : base("UnityEditor.EditorWindow")
        {
        }

        public REditorWindow(System.Object instance) : base("UnityEditor.EditorWindow")
		{
            SetInstance(instance);
		}

        public REditorWindow(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REditorWindow(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void Internal_MakeModal(RUnityEditor.RContainerWindow @win)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@win.Value};
            var ___result = RInternal_MakeModal_ContainerWindow.Invoke(___genericsType, ___parameters);

            
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


        public virtual void SaveViewDataToDisk()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSaveViewDataToDisk.Invoke(___genericsType, ___parameters);

            
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


        public static UnityEngine.GUIContent GetLocalizedTitleContentFromType(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RGetLocalizedTitleContentFromType_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIContent)___result;
        }


        public static UnityEditor.EditorWindowTitleAttribute GetEditorWindowTitleAttribute(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RGetEditorWindowTitleAttribute_Type.Invoke(___genericsType, ___parameters);

            return (UnityEditor.EditorWindowTitleAttribute)___result;
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


        public virtual void MakeModal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMakeModal.Invoke(___genericsType, ___parameters);

            
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


        public static UnityEditor.EditorWindow GetWindowPrivate(System.Type @t, System.Boolean @utility, System.String @title, System.Boolean @focus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @utility, @title, @focus};
            var ___result = RGetWindowPrivate_Type_Boolean_String_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEditor.EditorWindow)___result;
        }


        public static UnityEditor.EditorWindow GetWindow(System.Type @t, System.Boolean @utility, System.String @title, System.Boolean @focus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @utility, @title, @focus};
            var ___result = RGetWindow_Type_Boolean_String_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEditor.EditorWindow)___result;
        }


        public static UnityEditor.EditorWindow GetWindow(System.Type @t, System.Boolean @utility, System.String @title)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @utility, @title};
            var ___result = RGetWindow_Type_Boolean_String.Invoke(___genericsType, ___parameters);

            return (UnityEditor.EditorWindow)___result;
        }


        public static UnityEditor.EditorWindow GetWindow(System.Type @t, System.Boolean @utility)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @utility};
            var ___result = RGetWindow_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEditor.EditorWindow)___result;
        }


        public static UnityEditor.EditorWindow GetWindow(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RGetWindow_Type.Invoke(___genericsType, ___parameters);

            return (UnityEditor.EditorWindow)___result;
        }


        public static UnityEditor.EditorWindow GetWindowWithRect(System.Type @t, UnityEngine.Rect @rect, System.Boolean @utility, System.String @title)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @rect, @utility, @title};
            var ___result = RGetWindowWithRect_Type_Rect_Boolean_String.Invoke(___genericsType, ___parameters);

            return (UnityEditor.EditorWindow)___result;
        }


        public static UnityEditor.EditorWindow GetWindowWithRect(System.Type @t, UnityEngine.Rect @rect, System.Boolean @utility)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @rect, @utility};
            var ___result = RGetWindowWithRect_Type_Rect_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEditor.EditorWindow)___result;
        }


        public static UnityEditor.EditorWindow GetWindowWithRect(System.Type @t, UnityEngine.Rect @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @rect};
            var ___result = RGetWindowWithRect_Type_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEditor.EditorWindow)___result;
        }


        public static T GetWindow<T>() where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetWindow_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T GetWindow<T>(System.Boolean @utility) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@utility};
            var ___result = RGetWindow_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T GetWindow<T>(System.Boolean @utility, System.String @title) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@utility, @title};
            var ___result = RGetWindow_GT_Boolean_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T GetWindow<T>(System.String @title) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@title};
            var ___result = RGetWindow_GT_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T GetWindow<T>(System.String @title, System.Boolean @focus) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@title, @focus};
            var ___result = RGetWindow_GT_String_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T GetWindow<T>(System.Boolean @utility, System.String @title, System.Boolean @focus) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@utility, @title, @focus};
            var ___result = RGetWindow_GT_Boolean_String_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T GetWindow<T>(System.Type[] @desiredDockNextTo) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@desiredDockNextTo};
            var ___result = RGetWindow_GT_TypeArray.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T GetWindow<T>(System.String @title, System.Type[] @desiredDockNextTo) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@title, @desiredDockNextTo};
            var ___result = RGetWindow_GT_String_TypeArray.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T GetWindow<T>(System.String @title, System.Boolean @focus, System.Type[] @desiredDockNextTo) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@title, @focus, @desiredDockNextTo};
            var ___result = RGetWindow_GT_String_Boolean_TypeArray.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T CreateWindow<T>(System.Type[] @desiredDockNextTo) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@desiredDockNextTo};
            var ___result = RCreateWindow_GT_TypeArray.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T CreateWindow<T>(System.String @title, System.Type[] @desiredDockNextTo) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@title, @desiredDockNextTo};
            var ___result = RCreateWindow_GT_String_TypeArray.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static System.Boolean HasOpenInstances<T>() where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RHasOpenInstances_GT.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void FocusWindowIfItsOpen(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RFocusWindowIfItsOpen_Type.Invoke(___genericsType, ___parameters);

            
        }


        public static void FocusWindowIfItsOpen<T>() where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RFocusWindowIfItsOpen_GT.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFromDockArea()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRemoveFromDockArea.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEditor.EditorWindow GetWindowWithRectPrivate(System.Type @t, UnityEngine.Rect @rect, System.Boolean @utility, System.String @title)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @rect, @utility, @title};
            var ___result = RGetWindowWithRectPrivate_Type_Rect_Boolean_String.Invoke(___genericsType, ___parameters);

            return (UnityEditor.EditorWindow)___result;
        }


        public static T GetWindowWithRect<T>(UnityEngine.Rect @rect) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@rect};
            var ___result = RGetWindowWithRect_GT_Rect.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T GetWindowWithRect<T>(UnityEngine.Rect @rect, System.Boolean @utility) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@rect, @utility};
            var ___result = RGetWindowWithRect_GT_Rect_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T GetWindowWithRect<T>(UnityEngine.Rect @rect, System.Boolean @utility, System.String @title) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@rect, @utility, @title};
            var ___result = RGetWindowWithRect_GT_Rect_Boolean_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T GetWindowWithRect<T>(UnityEngine.Rect @rect, System.Boolean @utility, System.String @title, System.Boolean @focus) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@rect, @utility, @title, @focus};
            var ___result = RGetWindowWithRect_GT_Rect_Boolean_String_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T GetWindowDontShow<T>() where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetWindowDontShow_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
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


        public virtual void __internalAwake()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__internalAwake.Invoke(___genericsType, ___parameters);

            
        }


        public static void Initialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDisableINTERNAL()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDisableINTERNAL.Invoke(___genericsType, ___parameters);

            
        }


        public static void CreateNewWindowForEditorWindow(UnityEditor.EditorWindow @window, System.Boolean @loadPosition, System.Boolean @showImmediately, System.Boolean @setFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@window, @loadPosition, @showImmediately, @setFocus};
            var ___result = RCreateNewWindowForEditorWindow_EditorWindow_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
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


        public static void UpdateWindowMenuListing()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateWindowMenuListing.Invoke(___genericsType, ___parameters);

            
        }


        public static void BuildWindowMenuListing()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBuildWindowMenuListing.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.UIElements.VisualElement CreateRoot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateRoot.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public static void ToggleAllOverlays(UnityEditor.ShortcutManagement.ShortcutArguments @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RToggleAllOverlays_ShortcutArguments.Invoke(___genericsType, ___parameters);

            
        }


        public static void HideOverlay(UnityEditor.ShortcutManagement.ShortcutArguments @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RHideOverlay_ShortcutArguments.Invoke(___genericsType, ___parameters);

            
        }


        public static void ShowOverlayMenu(UnityEditor.ShortcutManagement.ShortcutArguments @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RShowOverlayMenu_ShortcutArguments.Invoke(___genericsType, ___parameters);

            
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
