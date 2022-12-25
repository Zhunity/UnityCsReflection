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
		protected RField r_m_AutoRepaintOnSceneChange;
		public virtual RField Rm_AutoRepaintOnSceneChange
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
		protected RField r_m_DepthBufferBits;
		public virtual RField Rm_DepthBufferBits
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
		protected RField r_m_AntiAliasing;
		public virtual RField Rm_AntiAliasing
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
		protected RField r_m_OverlaysInitialized;
		public virtual RField Rm_OverlaysInitialized
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
		protected RField r_m_EnableViewDataPersistence;
		public virtual RField Rm_EnableViewDataPersistence
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
		protected RField r_m_RequestedViewDataSave;
		public virtual RField Rm_RequestedViewDataSave
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
		protected RField r_m_IsPlayModeView;
		public virtual RField Rm_IsPlayModeView
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
		protected RField r_m_DisableInputEvents;
		public virtual RField Rm_DisableInputEvents
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
		protected static RField r_kWarningFadeoutWait;
		public static RField RkWarningFadeoutWait
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
		protected static RField r_kWarningFadeoutTime;
		public static RField RkWarningFadeoutTime
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
		/// System.Boolean m_HasUnsavedChanges
		/// </summary>
		protected RField r_m_HasUnsavedChanges;
		public virtual RField Rm_HasUnsavedChanges
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
		protected RField r___1__saveChangesMessage__2__k__BackingField;
		public virtual RField R__1__saveChangesMessage__2__k__BackingField
		{
			get
			{
				if(r___1__saveChangesMessage__2__k__BackingField == null)
				{
					r___1__saveChangesMessage__2__k__BackingField = new(this, "<saveChangesMessage>k__BackingField");
					r___1__saveChangesMessage__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__saveChangesMessage__2__k__BackingField;
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
		/// Void Internal_MakeModal(UnityEditor.ContainerWindow)
		/// </summary>
		protected static RMethod r_RInternal_MakeModal_ContainerWindow;
		public static RMethod RInternal_MakeModal_ContainerWindow
		{
			get
			{
				if(r_RInternal_MakeModal_ContainerWindow == null)
				{
					r_RInternal_MakeModal_ContainerWindow = new(typeof(UnityEditor.EditorWindow), "Internal_MakeModal", 0,  ReleactionUtils.GetType("UnityEditor.ContainerWindow"));
					r_RInternal_MakeModal_ContainerWindow.SetBelong(null);
				}
				return r_RInternal_MakeModal_ContainerWindow;
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
		/// Void SaveViewDataToDisk()
		/// </summary>
		protected RMethod r_RSaveViewDataToDisk;
		public virtual RMethod RSaveViewDataToDisk
		{
			get
			{
				if(r_RSaveViewDataToDisk == null)
				{
					r_RSaveViewDataToDisk = new(this, "SaveViewDataToDisk", 0);
					r_RSaveViewDataToDisk.SetBelong(this.instance);
				}
				return r_RSaveViewDataToDisk;
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
		/// UnityEngine.GUIContent GetLocalizedTitleContentFromType(System.Type)
		/// </summary>
		protected static RMethod r_RGetLocalizedTitleContentFromType_Type;
		public static RMethod RGetLocalizedTitleContentFromType_Type
		{
			get
			{
				if(r_RGetLocalizedTitleContentFromType_Type == null)
				{
					r_RGetLocalizedTitleContentFromType_Type = new(typeof(UnityEditor.EditorWindow), "GetLocalizedTitleContentFromType", 0, typeof(System.Type));
					r_RGetLocalizedTitleContentFromType_Type.SetBelong(null);
				}
				return r_RGetLocalizedTitleContentFromType_Type;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindowTitleAttribute GetEditorWindowTitleAttribute(System.Type)
		/// </summary>
		protected static RMethod r_RGetEditorWindowTitleAttribute_Type;
		public static RMethod RGetEditorWindowTitleAttribute_Type
		{
			get
			{
				if(r_RGetEditorWindowTitleAttribute_Type == null)
				{
					r_RGetEditorWindowTitleAttribute_Type = new(typeof(UnityEditor.EditorWindow), "GetEditorWindowTitleAttribute", 0, typeof(System.Type));
					r_RGetEditorWindowTitleAttribute_Type.SetBelong(null);
				}
				return r_RGetEditorWindowTitleAttribute_Type;
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
		/// Void MakeModal()
		/// </summary>
		protected RMethod r_RMakeModal;
		public virtual RMethod RMakeModal
		{
			get
			{
				if(r_RMakeModal == null)
				{
					r_RMakeModal = new(this, "MakeModal", 0);
					r_RMakeModal.SetBelong(this.instance);
				}
				return r_RMakeModal;
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
		/// UnityEditor.EditorWindow GetWindowPrivate(System.Type, Boolean, System.String, Boolean)
		/// </summary>
		protected static RMethod r_RGetWindowPrivate_Type_Boolean_String_Boolean;
		public static RMethod RGetWindowPrivate_Type_Boolean_String_Boolean
		{
			get
			{
				if(r_RGetWindowPrivate_Type_Boolean_String_Boolean == null)
				{
					r_RGetWindowPrivate_Type_Boolean_String_Boolean = new(typeof(UnityEditor.EditorWindow), "GetWindowPrivate", 0, typeof(System.Type), typeof(System.Boolean), typeof(System.String), typeof(System.Boolean));
					r_RGetWindowPrivate_Type_Boolean_String_Boolean.SetBelong(null);
				}
				return r_RGetWindowPrivate_Type_Boolean_String_Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow GetWindow(System.Type, Boolean, System.String, Boolean)
		/// </summary>
		protected static RMethod r_RGetWindow_Type_Boolean_String_Boolean;
		public static RMethod RGetWindow_Type_Boolean_String_Boolean
		{
			get
			{
				if(r_RGetWindow_Type_Boolean_String_Boolean == null)
				{
					r_RGetWindow_Type_Boolean_String_Boolean = new(typeof(UnityEditor.EditorWindow), "GetWindow", 0, typeof(System.Type), typeof(System.Boolean), typeof(System.String), typeof(System.Boolean));
					r_RGetWindow_Type_Boolean_String_Boolean.SetBelong(null);
				}
				return r_RGetWindow_Type_Boolean_String_Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow GetWindow(System.Type, Boolean, System.String)
		/// </summary>
		protected static RMethod r_RGetWindow_Type_Boolean_String;
		public static RMethod RGetWindow_Type_Boolean_String
		{
			get
			{
				if(r_RGetWindow_Type_Boolean_String == null)
				{
					r_RGetWindow_Type_Boolean_String = new(typeof(UnityEditor.EditorWindow), "GetWindow", 0, typeof(System.Type), typeof(System.Boolean), typeof(System.String));
					r_RGetWindow_Type_Boolean_String.SetBelong(null);
				}
				return r_RGetWindow_Type_Boolean_String;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow GetWindow(System.Type, Boolean)
		/// </summary>
		protected static RMethod r_RGetWindow_Type_Boolean;
		public static RMethod RGetWindow_Type_Boolean
		{
			get
			{
				if(r_RGetWindow_Type_Boolean == null)
				{
					r_RGetWindow_Type_Boolean = new(typeof(UnityEditor.EditorWindow), "GetWindow", 0, typeof(System.Type), typeof(System.Boolean));
					r_RGetWindow_Type_Boolean.SetBelong(null);
				}
				return r_RGetWindow_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow GetWindow(System.Type)
		/// </summary>
		protected static RMethod r_RGetWindow_Type;
		public static RMethod RGetWindow_Type
		{
			get
			{
				if(r_RGetWindow_Type == null)
				{
					r_RGetWindow_Type = new(typeof(UnityEditor.EditorWindow), "GetWindow", 0, typeof(System.Type));
					r_RGetWindow_Type.SetBelong(null);
				}
				return r_RGetWindow_Type;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow GetWindowWithRect(System.Type, UnityEngine.Rect, Boolean, System.String)
		/// </summary>
		protected static RMethod r_RGetWindowWithRect_Type_Rect_Boolean_String;
		public static RMethod RGetWindowWithRect_Type_Rect_Boolean_String
		{
			get
			{
				if(r_RGetWindowWithRect_Type_Rect_Boolean_String == null)
				{
					r_RGetWindowWithRect_Type_Rect_Boolean_String = new(typeof(UnityEditor.EditorWindow), "GetWindowWithRect", 0, typeof(System.Type), typeof(UnityEngine.Rect), typeof(System.Boolean), typeof(System.String));
					r_RGetWindowWithRect_Type_Rect_Boolean_String.SetBelong(null);
				}
				return r_RGetWindowWithRect_Type_Rect_Boolean_String;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow GetWindowWithRect(System.Type, UnityEngine.Rect, Boolean)
		/// </summary>
		protected static RMethod r_RGetWindowWithRect_Type_Rect_Boolean;
		public static RMethod RGetWindowWithRect_Type_Rect_Boolean
		{
			get
			{
				if(r_RGetWindowWithRect_Type_Rect_Boolean == null)
				{
					r_RGetWindowWithRect_Type_Rect_Boolean = new(typeof(UnityEditor.EditorWindow), "GetWindowWithRect", 0, typeof(System.Type), typeof(UnityEngine.Rect), typeof(System.Boolean));
					r_RGetWindowWithRect_Type_Rect_Boolean.SetBelong(null);
				}
				return r_RGetWindowWithRect_Type_Rect_Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow GetWindowWithRect(System.Type, UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_RGetWindowWithRect_Type_Rect;
		public static RMethod RGetWindowWithRect_Type_Rect
		{
			get
			{
				if(r_RGetWindowWithRect_Type_Rect == null)
				{
					r_RGetWindowWithRect_Type_Rect = new(typeof(UnityEditor.EditorWindow), "GetWindowWithRect", 0, typeof(System.Type), typeof(UnityEngine.Rect));
					r_RGetWindowWithRect_Type_Rect.SetBelong(null);
				}
				return r_RGetWindowWithRect_Type_Rect;
			}
		}

		/// <summary>
		/// T GetWindow[T]()
		/// </summary>
		protected static RMethod r_RGetWindow_GT;
		public static RMethod RGetWindow_GT
		{
			get
			{
				if(r_RGetWindow_GT == null)
				{
					r_RGetWindow_GT = new(typeof(UnityEditor.EditorWindow), "GetWindow", 1);
					r_RGetWindow_GT.SetBelong(null);
				}
				return r_RGetWindow_GT;
			}
		}

		/// <summary>
		/// T GetWindow[T](Boolean)
		/// </summary>
		protected static RMethod r_RGetWindow_GT_Boolean;
		public static RMethod RGetWindow_GT_Boolean
		{
			get
			{
				if(r_RGetWindow_GT_Boolean == null)
				{
					r_RGetWindow_GT_Boolean = new(typeof(UnityEditor.EditorWindow), "GetWindow", 1, typeof(System.Boolean));
					r_RGetWindow_GT_Boolean.SetBelong(null);
				}
				return r_RGetWindow_GT_Boolean;
			}
		}

		/// <summary>
		/// T GetWindow[T](Boolean, System.String)
		/// </summary>
		protected static RMethod r_RGetWindow_GT_Boolean_String;
		public static RMethod RGetWindow_GT_Boolean_String
		{
			get
			{
				if(r_RGetWindow_GT_Boolean_String == null)
				{
					r_RGetWindow_GT_Boolean_String = new(typeof(UnityEditor.EditorWindow), "GetWindow", 1, typeof(System.Boolean), typeof(System.String));
					r_RGetWindow_GT_Boolean_String.SetBelong(null);
				}
				return r_RGetWindow_GT_Boolean_String;
			}
		}

		/// <summary>
		/// T GetWindow[T](System.String)
		/// </summary>
		protected static RMethod r_RGetWindow_GT_String;
		public static RMethod RGetWindow_GT_String
		{
			get
			{
				if(r_RGetWindow_GT_String == null)
				{
					r_RGetWindow_GT_String = new(typeof(UnityEditor.EditorWindow), "GetWindow", 1, typeof(System.String));
					r_RGetWindow_GT_String.SetBelong(null);
				}
				return r_RGetWindow_GT_String;
			}
		}

		/// <summary>
		/// T GetWindow[T](System.String, Boolean)
		/// </summary>
		protected static RMethod r_RGetWindow_GT_String_Boolean;
		public static RMethod RGetWindow_GT_String_Boolean
		{
			get
			{
				if(r_RGetWindow_GT_String_Boolean == null)
				{
					r_RGetWindow_GT_String_Boolean = new(typeof(UnityEditor.EditorWindow), "GetWindow", 1, typeof(System.String), typeof(System.Boolean));
					r_RGetWindow_GT_String_Boolean.SetBelong(null);
				}
				return r_RGetWindow_GT_String_Boolean;
			}
		}

		/// <summary>
		/// T GetWindow[T](Boolean, System.String, Boolean)
		/// </summary>
		protected static RMethod r_RGetWindow_GT_Boolean_String_Boolean;
		public static RMethod RGetWindow_GT_Boolean_String_Boolean
		{
			get
			{
				if(r_RGetWindow_GT_Boolean_String_Boolean == null)
				{
					r_RGetWindow_GT_Boolean_String_Boolean = new(typeof(UnityEditor.EditorWindow), "GetWindow", 1, typeof(System.Boolean), typeof(System.String), typeof(System.Boolean));
					r_RGetWindow_GT_Boolean_String_Boolean.SetBelong(null);
				}
				return r_RGetWindow_GT_Boolean_String_Boolean;
			}
		}

		/// <summary>
		/// T GetWindow[T](System.Type[])
		/// </summary>
		protected static RMethod r_RGetWindow_GT_TypeArray;
		public static RMethod RGetWindow_GT_TypeArray
		{
			get
			{
				if(r_RGetWindow_GT_TypeArray == null)
				{
					r_RGetWindow_GT_TypeArray = new(typeof(UnityEditor.EditorWindow), "GetWindow", 1, typeof(System.Type).MakeArrayType());
					r_RGetWindow_GT_TypeArray.SetBelong(null);
				}
				return r_RGetWindow_GT_TypeArray;
			}
		}

		/// <summary>
		/// T GetWindow[T](System.String, System.Type[])
		/// </summary>
		protected static RMethod r_RGetWindow_GT_String_TypeArray;
		public static RMethod RGetWindow_GT_String_TypeArray
		{
			get
			{
				if(r_RGetWindow_GT_String_TypeArray == null)
				{
					r_RGetWindow_GT_String_TypeArray = new(typeof(UnityEditor.EditorWindow), "GetWindow", 1, typeof(System.String), typeof(System.Type).MakeArrayType());
					r_RGetWindow_GT_String_TypeArray.SetBelong(null);
				}
				return r_RGetWindow_GT_String_TypeArray;
			}
		}

		/// <summary>
		/// T GetWindow[T](System.String, Boolean, System.Type[])
		/// </summary>
		protected static RMethod r_RGetWindow_GT_String_Boolean_TypeArray;
		public static RMethod RGetWindow_GT_String_Boolean_TypeArray
		{
			get
			{
				if(r_RGetWindow_GT_String_Boolean_TypeArray == null)
				{
					r_RGetWindow_GT_String_Boolean_TypeArray = new(typeof(UnityEditor.EditorWindow), "GetWindow", 1, typeof(System.String), typeof(System.Boolean), typeof(System.Type).MakeArrayType());
					r_RGetWindow_GT_String_Boolean_TypeArray.SetBelong(null);
				}
				return r_RGetWindow_GT_String_Boolean_TypeArray;
			}
		}

		/// <summary>
		/// T CreateWindow[T](System.Type[])
		/// </summary>
		protected static RMethod r_RCreateWindow_GT_TypeArray;
		public static RMethod RCreateWindow_GT_TypeArray
		{
			get
			{
				if(r_RCreateWindow_GT_TypeArray == null)
				{
					r_RCreateWindow_GT_TypeArray = new(typeof(UnityEditor.EditorWindow), "CreateWindow", 1, typeof(System.Type).MakeArrayType());
					r_RCreateWindow_GT_TypeArray.SetBelong(null);
				}
				return r_RCreateWindow_GT_TypeArray;
			}
		}

		/// <summary>
		/// T CreateWindow[T](System.String, System.Type[])
		/// </summary>
		protected static RMethod r_RCreateWindow_GT_String_TypeArray;
		public static RMethod RCreateWindow_GT_String_TypeArray
		{
			get
			{
				if(r_RCreateWindow_GT_String_TypeArray == null)
				{
					r_RCreateWindow_GT_String_TypeArray = new(typeof(UnityEditor.EditorWindow), "CreateWindow", 1, typeof(System.String), typeof(System.Type).MakeArrayType());
					r_RCreateWindow_GT_String_TypeArray.SetBelong(null);
				}
				return r_RCreateWindow_GT_String_TypeArray;
			}
		}

		/// <summary>
		/// Boolean HasOpenInstances[T]()
		/// </summary>
		protected static RMethod r_RHasOpenInstances_GT;
		public static RMethod RHasOpenInstances_GT
		{
			get
			{
				if(r_RHasOpenInstances_GT == null)
				{
					r_RHasOpenInstances_GT = new(typeof(UnityEditor.EditorWindow), "HasOpenInstances", 1);
					r_RHasOpenInstances_GT.SetBelong(null);
				}
				return r_RHasOpenInstances_GT;
			}
		}

		/// <summary>
		/// Void FocusWindowIfItsOpen(System.Type)
		/// </summary>
		protected static RMethod r_RFocusWindowIfItsOpen_Type;
		public static RMethod RFocusWindowIfItsOpen_Type
		{
			get
			{
				if(r_RFocusWindowIfItsOpen_Type == null)
				{
					r_RFocusWindowIfItsOpen_Type = new(typeof(UnityEditor.EditorWindow), "FocusWindowIfItsOpen", 0, typeof(System.Type));
					r_RFocusWindowIfItsOpen_Type.SetBelong(null);
				}
				return r_RFocusWindowIfItsOpen_Type;
			}
		}

		/// <summary>
		/// Void FocusWindowIfItsOpen[T]()
		/// </summary>
		protected static RMethod r_RFocusWindowIfItsOpen_GT;
		public static RMethod RFocusWindowIfItsOpen_GT
		{
			get
			{
				if(r_RFocusWindowIfItsOpen_GT == null)
				{
					r_RFocusWindowIfItsOpen_GT = new(typeof(UnityEditor.EditorWindow), "FocusWindowIfItsOpen", 1);
					r_RFocusWindowIfItsOpen_GT.SetBelong(null);
				}
				return r_RFocusWindowIfItsOpen_GT;
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
		/// UnityEditor.EditorWindow GetWindowWithRectPrivate(System.Type, UnityEngine.Rect, Boolean, System.String)
		/// </summary>
		protected static RMethod r_RGetWindowWithRectPrivate_Type_Rect_Boolean_String;
		public static RMethod RGetWindowWithRectPrivate_Type_Rect_Boolean_String
		{
			get
			{
				if(r_RGetWindowWithRectPrivate_Type_Rect_Boolean_String == null)
				{
					r_RGetWindowWithRectPrivate_Type_Rect_Boolean_String = new(typeof(UnityEditor.EditorWindow), "GetWindowWithRectPrivate", 0, typeof(System.Type), typeof(UnityEngine.Rect), typeof(System.Boolean), typeof(System.String));
					r_RGetWindowWithRectPrivate_Type_Rect_Boolean_String.SetBelong(null);
				}
				return r_RGetWindowWithRectPrivate_Type_Rect_Boolean_String;
			}
		}

		/// <summary>
		/// T GetWindowWithRect[T](UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_RGetWindowWithRect_GT_Rect;
		public static RMethod RGetWindowWithRect_GT_Rect
		{
			get
			{
				if(r_RGetWindowWithRect_GT_Rect == null)
				{
					r_RGetWindowWithRect_GT_Rect = new(typeof(UnityEditor.EditorWindow), "GetWindowWithRect", 1, typeof(UnityEngine.Rect));
					r_RGetWindowWithRect_GT_Rect.SetBelong(null);
				}
				return r_RGetWindowWithRect_GT_Rect;
			}
		}

		/// <summary>
		/// T GetWindowWithRect[T](UnityEngine.Rect, Boolean)
		/// </summary>
		protected static RMethod r_RGetWindowWithRect_GT_Rect_Boolean;
		public static RMethod RGetWindowWithRect_GT_Rect_Boolean
		{
			get
			{
				if(r_RGetWindowWithRect_GT_Rect_Boolean == null)
				{
					r_RGetWindowWithRect_GT_Rect_Boolean = new(typeof(UnityEditor.EditorWindow), "GetWindowWithRect", 1, typeof(UnityEngine.Rect), typeof(System.Boolean));
					r_RGetWindowWithRect_GT_Rect_Boolean.SetBelong(null);
				}
				return r_RGetWindowWithRect_GT_Rect_Boolean;
			}
		}

		/// <summary>
		/// T GetWindowWithRect[T](UnityEngine.Rect, Boolean, System.String)
		/// </summary>
		protected static RMethod r_RGetWindowWithRect_GT_Rect_Boolean_String;
		public static RMethod RGetWindowWithRect_GT_Rect_Boolean_String
		{
			get
			{
				if(r_RGetWindowWithRect_GT_Rect_Boolean_String == null)
				{
					r_RGetWindowWithRect_GT_Rect_Boolean_String = new(typeof(UnityEditor.EditorWindow), "GetWindowWithRect", 1, typeof(UnityEngine.Rect), typeof(System.Boolean), typeof(System.String));
					r_RGetWindowWithRect_GT_Rect_Boolean_String.SetBelong(null);
				}
				return r_RGetWindowWithRect_GT_Rect_Boolean_String;
			}
		}

		/// <summary>
		/// T GetWindowWithRect[T](UnityEngine.Rect, Boolean, System.String, Boolean)
		/// </summary>
		protected static RMethod r_RGetWindowWithRect_GT_Rect_Boolean_String_Boolean;
		public static RMethod RGetWindowWithRect_GT_Rect_Boolean_String_Boolean
		{
			get
			{
				if(r_RGetWindowWithRect_GT_Rect_Boolean_String_Boolean == null)
				{
					r_RGetWindowWithRect_GT_Rect_Boolean_String_Boolean = new(typeof(UnityEditor.EditorWindow), "GetWindowWithRect", 1, typeof(UnityEngine.Rect), typeof(System.Boolean), typeof(System.String), typeof(System.Boolean));
					r_RGetWindowWithRect_GT_Rect_Boolean_String_Boolean.SetBelong(null);
				}
				return r_RGetWindowWithRect_GT_Rect_Boolean_String_Boolean;
			}
		}

		/// <summary>
		/// T GetWindowDontShow[T]()
		/// </summary>
		protected static RMethod r_RGetWindowDontShow_GT;
		public static RMethod RGetWindowDontShow_GT
		{
			get
			{
				if(r_RGetWindowDontShow_GT == null)
				{
					r_RGetWindowDontShow_GT = new(typeof(UnityEditor.EditorWindow), "GetWindowDontShow", 1);
					r_RGetWindowDontShow_GT.SetBelong(null);
				}
				return r_RGetWindowDontShow_GT;
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
		/// Void __internalAwake()
		/// </summary>
		protected RMethod r_R__internalAwake;
		public virtual RMethod R__internalAwake
		{
			get
			{
				if(r_R__internalAwake == null)
				{
					r_R__internalAwake = new(this, "__internalAwake", 0);
					r_R__internalAwake.SetBelong(this.instance);
				}
				return r_R__internalAwake;
			}
		}

		/// <summary>
		/// Void Initialize()
		/// </summary>
		protected static RMethod r_RInitialize;
		public static RMethod RInitialize
		{
			get
			{
				if(r_RInitialize == null)
				{
					r_RInitialize = new(typeof(UnityEditor.EditorWindow), "Initialize", 0);
					r_RInitialize.SetBelong(null);
				}
				return r_RInitialize;
			}
		}

		/// <summary>
		/// Void OnDisableINTERNAL()
		/// </summary>
		protected RMethod r_ROnDisableINTERNAL;
		public virtual RMethod ROnDisableINTERNAL
		{
			get
			{
				if(r_ROnDisableINTERNAL == null)
				{
					r_ROnDisableINTERNAL = new(this, "OnDisableINTERNAL", 0);
					r_ROnDisableINTERNAL.SetBelong(this.instance);
				}
				return r_ROnDisableINTERNAL;
			}
		}

		/// <summary>
		/// Void CreateNewWindowForEditorWindow(UnityEditor.EditorWindow, Boolean, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_RCreateNewWindowForEditorWindow_EditorWindow_Boolean_Boolean_Boolean;
		public static RMethod RCreateNewWindowForEditorWindow_EditorWindow_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_RCreateNewWindowForEditorWindow_EditorWindow_Boolean_Boolean_Boolean == null)
				{
					r_RCreateNewWindowForEditorWindow_EditorWindow_Boolean_Boolean_Boolean = new(typeof(UnityEditor.EditorWindow), "CreateNewWindowForEditorWindow", 0, typeof(UnityEditor.EditorWindow), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_RCreateNewWindowForEditorWindow_EditorWindow_Boolean_Boolean_Boolean.SetBelong(null);
				}
				return r_RCreateNewWindowForEditorWindow_EditorWindow_Boolean_Boolean_Boolean;
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
		/// Void UpdateWindowMenuListing()
		/// </summary>
		protected static RMethod r_RUpdateWindowMenuListing;
		public static RMethod RUpdateWindowMenuListing
		{
			get
			{
				if(r_RUpdateWindowMenuListing == null)
				{
					r_RUpdateWindowMenuListing = new(typeof(UnityEditor.EditorWindow), "UpdateWindowMenuListing", 0);
					r_RUpdateWindowMenuListing.SetBelong(null);
				}
				return r_RUpdateWindowMenuListing;
			}
		}

		/// <summary>
		/// Void BuildWindowMenuListing()
		/// </summary>
		protected static RMethod r_RBuildWindowMenuListing;
		public static RMethod RBuildWindowMenuListing
		{
			get
			{
				if(r_RBuildWindowMenuListing == null)
				{
					r_RBuildWindowMenuListing = new(typeof(UnityEditor.EditorWindow), "BuildWindowMenuListing", 0);
					r_RBuildWindowMenuListing.SetBelong(null);
				}
				return r_RBuildWindowMenuListing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement CreateRoot()
		/// </summary>
		protected static RMethod r_RCreateRoot;
		public static RMethod RCreateRoot
		{
			get
			{
				if(r_RCreateRoot == null)
				{
					r_RCreateRoot = new(typeof(UnityEditor.EditorWindow), "CreateRoot", 0);
					r_RCreateRoot.SetBelong(null);
				}
				return r_RCreateRoot;
			}
		}

		/// <summary>
		/// Void ToggleAllOverlays(UnityEditor.ShortcutManagement.ShortcutArguments)
		/// </summary>
		protected static RMethod r_RToggleAllOverlays_ShortcutArguments;
		public static RMethod RToggleAllOverlays_ShortcutArguments
		{
			get
			{
				if(r_RToggleAllOverlays_ShortcutArguments == null)
				{
					r_RToggleAllOverlays_ShortcutArguments = new(typeof(UnityEditor.EditorWindow), "ToggleAllOverlays", 0, typeof(UnityEditor.ShortcutManagement.ShortcutArguments));
					r_RToggleAllOverlays_ShortcutArguments.SetBelong(null);
				}
				return r_RToggleAllOverlays_ShortcutArguments;
			}
		}

		/// <summary>
		/// Void HideOverlay(UnityEditor.ShortcutManagement.ShortcutArguments)
		/// </summary>
		protected static RMethod r_RHideOverlay_ShortcutArguments;
		public static RMethod RHideOverlay_ShortcutArguments
		{
			get
			{
				if(r_RHideOverlay_ShortcutArguments == null)
				{
					r_RHideOverlay_ShortcutArguments = new(typeof(UnityEditor.EditorWindow), "HideOverlay", 0, typeof(UnityEditor.ShortcutManagement.ShortcutArguments));
					r_RHideOverlay_ShortcutArguments.SetBelong(null);
				}
				return r_RHideOverlay_ShortcutArguments;
			}
		}

		/// <summary>
		/// Void ShowOverlayMenu(UnityEditor.ShortcutManagement.ShortcutArguments)
		/// </summary>
		protected static RMethod r_RShowOverlayMenu_ShortcutArguments;
		public static RMethod RShowOverlayMenu_ShortcutArguments
		{
			get
			{
				if(r_RShowOverlayMenu_ShortcutArguments == null)
				{
					r_RShowOverlayMenu_ShortcutArguments = new(typeof(UnityEditor.EditorWindow), "ShowOverlayMenu", 0, typeof(UnityEditor.ShortcutManagement.ShortcutArguments));
					r_RShowOverlayMenu_ShortcutArguments.SetBelong(null);
				}
				return r_RShowOverlayMenu_ShortcutArguments;
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


        public virtual void SaveViewDataToDisk()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSaveViewDataToDisk.Invoke(___genericsType, ___parameters);

            
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


        public static UnityEngine.GUIContent GetLocalizedTitleContentFromType(System.Type  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RGetLocalizedTitleContentFromType_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIContent)___result;
        }


        public static UnityEditor.EditorWindowTitleAttribute GetEditorWindowTitleAttribute(System.Type  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RGetEditorWindowTitleAttribute_Type.Invoke(___genericsType, ___parameters);

            return (UnityEditor.EditorWindowTitleAttribute)___result;
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


        public static UnityEditor.EditorWindow GetWindowPrivate(System.Type  @t, System.Boolean  @utility, System.String  @title, System.Boolean  @focus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @utility, @title, @focus};
            var ___result = RGetWindowPrivate_Type_Boolean_String_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEditor.EditorWindow)___result;
        }


        public static UnityEditor.EditorWindow GetWindow(System.Type  @t, System.Boolean  @utility, System.String  @title, System.Boolean  @focus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @utility, @title, @focus};
            var ___result = RGetWindow_Type_Boolean_String_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEditor.EditorWindow)___result;
        }


        public static UnityEditor.EditorWindow GetWindow(System.Type  @t, System.Boolean  @utility, System.String  @title)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @utility, @title};
            var ___result = RGetWindow_Type_Boolean_String.Invoke(___genericsType, ___parameters);

            return (UnityEditor.EditorWindow)___result;
        }


        public static UnityEditor.EditorWindow GetWindow(System.Type  @t, System.Boolean  @utility)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @utility};
            var ___result = RGetWindow_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEditor.EditorWindow)___result;
        }


        public static UnityEditor.EditorWindow GetWindow(System.Type  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RGetWindow_Type.Invoke(___genericsType, ___parameters);

            return (UnityEditor.EditorWindow)___result;
        }


        public static UnityEditor.EditorWindow GetWindowWithRect(System.Type  @t, UnityEngine.Rect  @rect, System.Boolean  @utility, System.String  @title)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @rect, @utility, @title};
            var ___result = RGetWindowWithRect_Type_Rect_Boolean_String.Invoke(___genericsType, ___parameters);

            return (UnityEditor.EditorWindow)___result;
        }


        public static UnityEditor.EditorWindow GetWindowWithRect(System.Type  @t, UnityEngine.Rect  @rect, System.Boolean  @utility)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @rect, @utility};
            var ___result = RGetWindowWithRect_Type_Rect_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEditor.EditorWindow)___result;
        }


        public static UnityEditor.EditorWindow GetWindowWithRect(System.Type  @t, UnityEngine.Rect  @rect)
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


        public static T GetWindow<T>(System.Boolean  @utility) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@utility};
            var ___result = RGetWindow_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T GetWindow<T>(System.Boolean  @utility, System.String  @title) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@utility, @title};
            var ___result = RGetWindow_GT_Boolean_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T GetWindow<T>(System.String  @title) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@title};
            var ___result = RGetWindow_GT_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T GetWindow<T>(System.String  @title, System.Boolean  @focus) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@title, @focus};
            var ___result = RGetWindow_GT_String_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T GetWindow<T>(System.Boolean  @utility, System.String  @title, System.Boolean  @focus) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@utility, @title, @focus};
            var ___result = RGetWindow_GT_Boolean_String_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T GetWindow<T>(System.Type[]  @desiredDockNextTo) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@desiredDockNextTo};
            var ___result = RGetWindow_GT_TypeArray.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T GetWindow<T>(System.String  @title, System.Type[]  @desiredDockNextTo) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@title, @desiredDockNextTo};
            var ___result = RGetWindow_GT_String_TypeArray.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T GetWindow<T>(System.String  @title, System.Boolean  @focus, System.Type[]  @desiredDockNextTo) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@title, @focus, @desiredDockNextTo};
            var ___result = RGetWindow_GT_String_Boolean_TypeArray.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T CreateWindow<T>(System.Type[]  @desiredDockNextTo) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@desiredDockNextTo};
            var ___result = RCreateWindow_GT_TypeArray.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T CreateWindow<T>(System.String  @title, System.Type[]  @desiredDockNextTo) where T : UnityEditor.EditorWindow
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


        public static void FocusWindowIfItsOpen(System.Type  @t)
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


        public static UnityEditor.EditorWindow GetWindowWithRectPrivate(System.Type  @t, UnityEngine.Rect  @rect, System.Boolean  @utility, System.String  @title)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @rect, @utility, @title};
            var ___result = RGetWindowWithRectPrivate_Type_Rect_Boolean_String.Invoke(___genericsType, ___parameters);

            return (UnityEditor.EditorWindow)___result;
        }


        public static T GetWindowWithRect<T>(UnityEngine.Rect  @rect) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@rect};
            var ___result = RGetWindowWithRect_GT_Rect.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T GetWindowWithRect<T>(UnityEngine.Rect  @rect, System.Boolean  @utility) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@rect, @utility};
            var ___result = RGetWindowWithRect_GT_Rect_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T GetWindowWithRect<T>(UnityEngine.Rect  @rect, System.Boolean  @utility, System.String  @title) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@rect, @utility, @title};
            var ___result = RGetWindowWithRect_GT_Rect_Boolean_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T GetWindowWithRect<T>(UnityEngine.Rect  @rect, System.Boolean  @utility, System.String  @title, System.Boolean  @focus) where T : UnityEditor.EditorWindow
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


        public static void CreateNewWindowForEditorWindow(UnityEditor.EditorWindow  @window, System.Boolean  @loadPosition, System.Boolean  @showImmediately, System.Boolean  @setFocus)
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


        public static void ToggleAllOverlays(UnityEditor.ShortcutManagement.ShortcutArguments  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RToggleAllOverlays_ShortcutArguments.Invoke(___genericsType, ___parameters);

            
        }


        public static void HideOverlay(UnityEditor.ShortcutManagement.ShortcutArguments  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RHideOverlay_ShortcutArguments.Invoke(___genericsType, ___parameters);

            
        }


        public static void ShowOverlayMenu(UnityEditor.ShortcutManagement.ShortcutArguments  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RShowOverlayMenu_ShortcutArguments.Invoke(___genericsType, ___parameters);

            
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
