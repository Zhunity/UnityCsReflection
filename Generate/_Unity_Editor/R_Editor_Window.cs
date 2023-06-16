
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEditor.EditorWindow
	/// </summary>
    public partial class REditorWindow : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEditor.EditorWindow);
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


		/// <summary>
		/// System.Boolean m_AutoRepaintOnSceneChange
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_AutoRepaintOnSceneChange;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_AutoRepaintOnSceneChange
		{
			get
			{
				if(r_Fm_AutoRepaintOnSceneChange == null)
				{
					r_Fm_AutoRepaintOnSceneChange = new(this, "m_AutoRepaintOnSceneChange");
				}
				return r_Fm_AutoRepaintOnSceneChange;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_MinSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Fm_MinSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFm_MinSize
		{
			get
			{
				if(r_Fm_MinSize == null)
				{
					r_Fm_MinSize = new(this, "m_MinSize");
				}
				return r_Fm_MinSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_MaxSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Fm_MaxSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFm_MaxSize
		{
			get
			{
				if(r_Fm_MaxSize == null)
				{
					r_Fm_MaxSize = new(this, "m_MaxSize");
				}
				return r_Fm_MaxSize;
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
		/// System.Int32 m_DepthBufferBits
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_DepthBufferBits;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_DepthBufferBits
		{
			get
			{
				if(r_Fm_DepthBufferBits == null)
				{
					r_Fm_DepthBufferBits = new(this, "m_DepthBufferBits");
				}
				return r_Fm_DepthBufferBits;
			}
		}

		/// <summary>
		/// System.Int32 m_AntiAliasing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_AntiAliasing;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_AntiAliasing
		{
			get
			{
				if(r_Fm_AntiAliasing == null)
				{
					r_Fm_AntiAliasing = new(this, "m_AntiAliasing");
				}
				return r_Fm_AntiAliasing;
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
		/// UnityEngine.UIElements.VisualElement m_UIRootElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_UIRootElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_UIRootElement
		{
			get
			{
				if(r_Fm_UIRootElement == null)
				{
					r_Fm_UIRootElement = new(this, "m_UIRootElement");
				}
				return r_Fm_UIRootElement;
			}
		}

		/// <summary>
		/// UnityEditor.UIElements.SerializableJsonDictionary m_ViewDataDictionary
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RUIElements.RSerializableJsonDictionary r_Fm_ViewDataDictionary;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RUIElements.RSerializableJsonDictionary RFm_ViewDataDictionary
		{
			get
			{
				if(r_Fm_ViewDataDictionary == null)
				{
					r_Fm_ViewDataDictionary = new(this, "m_ViewDataDictionary");
				}
				return r_Fm_ViewDataDictionary;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayCanvas m_OverlayCanvas
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayCanvas r_Fm_OverlayCanvas;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayCanvas RFm_OverlayCanvas
		{
			get
			{
				if(r_Fm_OverlayCanvas == null)
				{
					r_Fm_OverlayCanvas = new(this, "m_OverlayCanvas");
				}
				return r_Fm_OverlayCanvas;
			}
		}

		/// <summary>
		/// System.Boolean m_OverlaysInitialized
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_OverlaysInitialized;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_OverlaysInitialized
		{
			get
			{
				if(r_Fm_OverlaysInitialized == null)
				{
					r_Fm_OverlaysInitialized = new(this, "m_OverlaysInitialized");
				}
				return r_Fm_OverlaysInitialized;
			}
		}

		/// <summary>
		/// System.Boolean m_EnableViewDataPersistence
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_EnableViewDataPersistence;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_EnableViewDataPersistence
		{
			get
			{
				if(r_Fm_EnableViewDataPersistence == null)
				{
					r_Fm_EnableViewDataPersistence = new(this, "m_EnableViewDataPersistence");
				}
				return r_Fm_EnableViewDataPersistence;
			}
		}

		/// <summary>
		/// System.Boolean m_RequestedViewDataSave
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_RequestedViewDataSave;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_RequestedViewDataSave
		{
			get
			{
				if(r_Fm_RequestedViewDataSave == null)
				{
					r_Fm_RequestedViewDataSave = new(this, "m_RequestedViewDataSave");
				}
				return r_Fm_RequestedViewDataSave;
			}
		}

		/// <summary>
		/// System.Action s_UpdateWindowMenuListingOff
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RAction r_Fs_UpdateWindowMenuListingOff;
		public static Hvak.Editor.Refleaction.RSystem.RAction RFs_UpdateWindowMenuListingOff
		{
			get
			{
				if(r_Fs_UpdateWindowMenuListingOff == null)
				{
					r_Fs_UpdateWindowMenuListingOff = new(Type, "s_UpdateWindowMenuListingOff");
				}
				return r_Fs_UpdateWindowMenuListingOff;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_GameViewRect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Fm_GameViewRect;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFm_GameViewRect
		{
			get
			{
				if(r_Fm_GameViewRect == null)
				{
					r_Fm_GameViewRect = new(this, "m_GameViewRect");
				}
				return r_Fm_GameViewRect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_GameViewClippedRect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Fm_GameViewClippedRect;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFm_GameViewClippedRect
		{
			get
			{
				if(r_Fm_GameViewClippedRect == null)
				{
					r_Fm_GameViewClippedRect = new(this, "m_GameViewClippedRect");
				}
				return r_Fm_GameViewClippedRect;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_GameViewTargetSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Fm_GameViewTargetSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFm_GameViewTargetSize
		{
			get
			{
				if(r_Fm_GameViewTargetSize == null)
				{
					r_Fm_GameViewTargetSize = new(this, "m_GameViewTargetSize");
				}
				return r_Fm_GameViewTargetSize;
			}
		}

		/// <summary>
		/// System.Boolean m_IsPlayModeView
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_IsPlayModeView;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_IsPlayModeView
		{
			get
			{
				if(r_Fm_IsPlayModeView == null)
				{
					r_Fm_IsPlayModeView = new(this, "m_IsPlayModeView");
				}
				return r_Fm_IsPlayModeView;
			}
		}

		/// <summary>
		/// UnityEngine.EventInterests m_EventInterests
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.REventInterests r_Fm_EventInterests;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.REventInterests RFm_EventInterests
		{
			get
			{
				if(r_Fm_EventInterests == null)
				{
					r_Fm_EventInterests = new(this, "m_EventInterests");
				}
				return r_Fm_EventInterests;
			}
		}

		/// <summary>
		/// System.Boolean m_DisableInputEvents
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_DisableInputEvents;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_DisableInputEvents
		{
			get
			{
				if(r_Fm_DisableInputEvents == null)
				{
					r_Fm_DisableInputEvents = new(this, "m_DisableInputEvents");
				}
				return r_Fm_DisableInputEvents;
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
		/// System.Double kWarningFadeoutWait
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDouble r_FkWarningFadeoutWait;
		public static Hvak.Editor.Refleaction.RSystem.RDouble RFkWarningFadeoutWait
		{
			get
			{
				if(r_FkWarningFadeoutWait == null)
				{
					r_FkWarningFadeoutWait = new(Type, "kWarningFadeoutWait");
				}
				return r_FkWarningFadeoutWait;
			}
		}

		/// <summary>
		/// System.Double kWarningFadeoutTime
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDouble r_FkWarningFadeoutTime;
		public static Hvak.Editor.Refleaction.RSystem.RDouble RFkWarningFadeoutTime
		{
			get
			{
				if(r_FkWarningFadeoutTime == null)
				{
					r_FkWarningFadeoutTime = new(Type, "kWarningFadeoutTime");
				}
				return r_FkWarningFadeoutTime;
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
		/// UnityEngine.Vector2 m_NotificationSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Fm_NotificationSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFm_NotificationSize
		{
			get
			{
				if(r_Fm_NotificationSize == null)
				{
					r_Fm_NotificationSize = new(this, "m_NotificationSize");
				}
				return r_Fm_NotificationSize;
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
		/// System.Boolean m_HasUnsavedChanges
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_HasUnsavedChanges;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_HasUnsavedChanges
		{
			get
			{
				if(r_Fm_HasUnsavedChanges == null)
				{
					r_Fm_HasUnsavedChanges = new(this, "m_HasUnsavedChanges");
				}
				return r_Fm_HasUnsavedChanges;
			}
		}

		/// <summary>
		/// System.String <saveChangesMessage>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F__0__saveChangesMessage__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF__0__saveChangesMessage__1__k__BackingField
		{
			get
			{
				if(r_F__0__saveChangesMessage__1__k__BackingField == null)
				{
					r_F__0__saveChangesMessage__1__k__BackingField = new(this, "<saveChangesMessage>k__BackingField");
				}
				return r_F__0__saveChangesMessage__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow+OverlayShortcutContext s_ShortcutContext
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.REditorWindow.ROverlayShortcutContext r_Fs_ShortcutContext;
		public static Hvak.Editor.Refleaction.RUnityEditor.REditorWindow.ROverlayShortcutContext RFs_ShortcutContext
		{
			get
			{
				if(r_Fs_ShortcutContext == null)
				{
					r_Fs_ShortcutContext = new(Type, "s_ShortcutContext");
				}
				return r_Fs_ShortcutContext;
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
		/// UnityEditor.EditorWindow focusedWindow
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.REditorWindow r_PfocusedWindow;
		public static Hvak.Editor.Refleaction.RUnityEditor.REditorWindow RPfocusedWindow
		{
			get
			{
				if(r_PfocusedWindow == null)
				{
					r_PfocusedWindow = new(Type, "focusedWindow", -1);
				}
				return r_PfocusedWindow;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow mouseOverWindow
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.REditorWindow r_PmouseOverWindow;
		public static Hvak.Editor.Refleaction.RUnityEditor.REditorWindow RPmouseOverWindow
		{
			get
			{
				if(r_PmouseOverWindow == null)
				{
					r_PmouseOverWindow = new(Type, "mouseOverWindow", -1);
				}
				return r_PmouseOverWindow;
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
		/// Void Internal_MakeModal(UnityEditor.ContainerWindow)
		/// </summary>
		protected static RMethod r_MInternal_MakeModal_ContainerWindow;
		public static RMethod RMInternal_MakeModal_ContainerWindow
		{
			get
			{
				if(r_MInternal_MakeModal_ContainerWindow == null)
				{
					r_MInternal_MakeModal_ContainerWindow = new(Type, "Internal_MakeModal", 0,  ReflectionUtils.GetType("UnityEditor.ContainerWindow"));
				}
				return r_MInternal_MakeModal_ContainerWindow;
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
		/// Void SaveViewDataToDisk()
		/// </summary>
		protected RMethod r_MSaveViewDataToDisk;
		public virtual RMethod RMSaveViewDataToDisk
		{
			get
			{
				if(r_MSaveViewDataToDisk == null)
				{
					r_MSaveViewDataToDisk = new(this, "SaveViewDataToDisk", 0);
				}
				return r_MSaveViewDataToDisk;
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
		/// UnityEngine.GUIContent GetLocalizedTitleContentFromType(System.Type)
		/// </summary>
		protected static RMethod r_MGetLocalizedTitleContentFromType_Type;
		public static RMethod RMGetLocalizedTitleContentFromType_Type
		{
			get
			{
				if(r_MGetLocalizedTitleContentFromType_Type == null)
				{
					r_MGetLocalizedTitleContentFromType_Type = new(Type, "GetLocalizedTitleContentFromType", 0, typeof(System.Type));
				}
				return r_MGetLocalizedTitleContentFromType_Type;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindowTitleAttribute GetEditorWindowTitleAttribute(System.Type)
		/// </summary>
		protected static RMethod r_MGetEditorWindowTitleAttribute_Type;
		public static RMethod RMGetEditorWindowTitleAttribute_Type
		{
			get
			{
				if(r_MGetEditorWindowTitleAttribute_Type == null)
				{
					r_MGetEditorWindowTitleAttribute_Type = new(Type, "GetEditorWindowTitleAttribute", 0, typeof(System.Type));
				}
				return r_MGetEditorWindowTitleAttribute_Type;
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
		/// Void MakeModal()
		/// </summary>
		protected RMethod r_MMakeModal;
		public virtual RMethod RMMakeModal
		{
			get
			{
				if(r_MMakeModal == null)
				{
					r_MMakeModal = new(this, "MakeModal", 0);
				}
				return r_MMakeModal;
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
		/// UnityEditor.EditorWindow GetWindowPrivate(System.Type, Boolean, System.String, Boolean)
		/// </summary>
		protected static RMethod r_MGetWindowPrivate_Type_Boolean_String_Boolean;
		public static RMethod RMGetWindowPrivate_Type_Boolean_String_Boolean
		{
			get
			{
				if(r_MGetWindowPrivate_Type_Boolean_String_Boolean == null)
				{
					r_MGetWindowPrivate_Type_Boolean_String_Boolean = new(Type, "GetWindowPrivate", 0, typeof(System.Type), typeof(System.Boolean), typeof(System.String), typeof(System.Boolean));
				}
				return r_MGetWindowPrivate_Type_Boolean_String_Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow GetWindow(System.Type, Boolean, System.String, Boolean)
		/// </summary>
		protected static RMethod r_MGetWindow_Type_Boolean_String_Boolean;
		public static RMethod RMGetWindow_Type_Boolean_String_Boolean
		{
			get
			{
				if(r_MGetWindow_Type_Boolean_String_Boolean == null)
				{
					r_MGetWindow_Type_Boolean_String_Boolean = new(Type, "GetWindow", 0, typeof(System.Type), typeof(System.Boolean), typeof(System.String), typeof(System.Boolean));
				}
				return r_MGetWindow_Type_Boolean_String_Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow GetWindow(System.Type, Boolean, System.String)
		/// </summary>
		protected static RMethod r_MGetWindow_Type_Boolean_String;
		public static RMethod RMGetWindow_Type_Boolean_String
		{
			get
			{
				if(r_MGetWindow_Type_Boolean_String == null)
				{
					r_MGetWindow_Type_Boolean_String = new(Type, "GetWindow", 0, typeof(System.Type), typeof(System.Boolean), typeof(System.String));
				}
				return r_MGetWindow_Type_Boolean_String;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow GetWindow(System.Type, Boolean)
		/// </summary>
		protected static RMethod r_MGetWindow_Type_Boolean;
		public static RMethod RMGetWindow_Type_Boolean
		{
			get
			{
				if(r_MGetWindow_Type_Boolean == null)
				{
					r_MGetWindow_Type_Boolean = new(Type, "GetWindow", 0, typeof(System.Type), typeof(System.Boolean));
				}
				return r_MGetWindow_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow GetWindow(System.Type)
		/// </summary>
		protected static RMethod r_MGetWindow_Type;
		public static RMethod RMGetWindow_Type
		{
			get
			{
				if(r_MGetWindow_Type == null)
				{
					r_MGetWindow_Type = new(Type, "GetWindow", 0, typeof(System.Type));
				}
				return r_MGetWindow_Type;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow GetWindowWithRect(System.Type, UnityEngine.Rect, Boolean, System.String)
		/// </summary>
		protected static RMethod r_MGetWindowWithRect_Type_Rect_Boolean_String;
		public static RMethod RMGetWindowWithRect_Type_Rect_Boolean_String
		{
			get
			{
				if(r_MGetWindowWithRect_Type_Rect_Boolean_String == null)
				{
					r_MGetWindowWithRect_Type_Rect_Boolean_String = new(Type, "GetWindowWithRect", 0, typeof(System.Type), typeof(UnityEngine.Rect), typeof(System.Boolean), typeof(System.String));
				}
				return r_MGetWindowWithRect_Type_Rect_Boolean_String;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow GetWindowWithRect(System.Type, UnityEngine.Rect, Boolean)
		/// </summary>
		protected static RMethod r_MGetWindowWithRect_Type_Rect_Boolean;
		public static RMethod RMGetWindowWithRect_Type_Rect_Boolean
		{
			get
			{
				if(r_MGetWindowWithRect_Type_Rect_Boolean == null)
				{
					r_MGetWindowWithRect_Type_Rect_Boolean = new(Type, "GetWindowWithRect", 0, typeof(System.Type), typeof(UnityEngine.Rect), typeof(System.Boolean));
				}
				return r_MGetWindowWithRect_Type_Rect_Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow GetWindowWithRect(System.Type, UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_MGetWindowWithRect_Type_Rect;
		public static RMethod RMGetWindowWithRect_Type_Rect
		{
			get
			{
				if(r_MGetWindowWithRect_Type_Rect == null)
				{
					r_MGetWindowWithRect_Type_Rect = new(Type, "GetWindowWithRect", 0, typeof(System.Type), typeof(UnityEngine.Rect));
				}
				return r_MGetWindowWithRect_Type_Rect;
			}
		}

		/// <summary>
		/// T GetWindow[T]()
		/// </summary>
		protected static RMethod r_MGetWindow_GT;
		public static RMethod RMGetWindow_GT
		{
			get
			{
				if(r_MGetWindow_GT == null)
				{
					r_MGetWindow_GT = new(Type, "GetWindow", 1);
				}
				return r_MGetWindow_GT;
			}
		}

		/// <summary>
		/// T GetWindow[T](Boolean)
		/// </summary>
		protected static RMethod r_MGetWindow_GT_Boolean;
		public static RMethod RMGetWindow_GT_Boolean
		{
			get
			{
				if(r_MGetWindow_GT_Boolean == null)
				{
					r_MGetWindow_GT_Boolean = new(Type, "GetWindow", 1, typeof(System.Boolean));
				}
				return r_MGetWindow_GT_Boolean;
			}
		}

		/// <summary>
		/// T GetWindow[T](Boolean, System.String)
		/// </summary>
		protected static RMethod r_MGetWindow_GT_Boolean_String;
		public static RMethod RMGetWindow_GT_Boolean_String
		{
			get
			{
				if(r_MGetWindow_GT_Boolean_String == null)
				{
					r_MGetWindow_GT_Boolean_String = new(Type, "GetWindow", 1, typeof(System.Boolean), typeof(System.String));
				}
				return r_MGetWindow_GT_Boolean_String;
			}
		}

		/// <summary>
		/// T GetWindow[T](System.String)
		/// </summary>
		protected static RMethod r_MGetWindow_GT_String;
		public static RMethod RMGetWindow_GT_String
		{
			get
			{
				if(r_MGetWindow_GT_String == null)
				{
					r_MGetWindow_GT_String = new(Type, "GetWindow", 1, typeof(System.String));
				}
				return r_MGetWindow_GT_String;
			}
		}

		/// <summary>
		/// T GetWindow[T](System.String, Boolean)
		/// </summary>
		protected static RMethod r_MGetWindow_GT_String_Boolean;
		public static RMethod RMGetWindow_GT_String_Boolean
		{
			get
			{
				if(r_MGetWindow_GT_String_Boolean == null)
				{
					r_MGetWindow_GT_String_Boolean = new(Type, "GetWindow", 1, typeof(System.String), typeof(System.Boolean));
				}
				return r_MGetWindow_GT_String_Boolean;
			}
		}

		/// <summary>
		/// T GetWindow[T](Boolean, System.String, Boolean)
		/// </summary>
		protected static RMethod r_MGetWindow_GT_Boolean_String_Boolean;
		public static RMethod RMGetWindow_GT_Boolean_String_Boolean
		{
			get
			{
				if(r_MGetWindow_GT_Boolean_String_Boolean == null)
				{
					r_MGetWindow_GT_Boolean_String_Boolean = new(Type, "GetWindow", 1, typeof(System.Boolean), typeof(System.String), typeof(System.Boolean));
				}
				return r_MGetWindow_GT_Boolean_String_Boolean;
			}
		}

		/// <summary>
		/// T GetWindow[T](System.Type[])
		/// </summary>
		protected static RMethod r_MGetWindow_GT_TypeArray;
		public static RMethod RMGetWindow_GT_TypeArray
		{
			get
			{
				if(r_MGetWindow_GT_TypeArray == null)
				{
					r_MGetWindow_GT_TypeArray = new(Type, "GetWindow", 1, typeof(System.Type).MakeArrayType());
				}
				return r_MGetWindow_GT_TypeArray;
			}
		}

		/// <summary>
		/// T GetWindow[T](System.String, System.Type[])
		/// </summary>
		protected static RMethod r_MGetWindow_GT_String_TypeArray;
		public static RMethod RMGetWindow_GT_String_TypeArray
		{
			get
			{
				if(r_MGetWindow_GT_String_TypeArray == null)
				{
					r_MGetWindow_GT_String_TypeArray = new(Type, "GetWindow", 1, typeof(System.String), typeof(System.Type).MakeArrayType());
				}
				return r_MGetWindow_GT_String_TypeArray;
			}
		}

		/// <summary>
		/// T GetWindow[T](System.String, Boolean, System.Type[])
		/// </summary>
		protected static RMethod r_MGetWindow_GT_String_Boolean_TypeArray;
		public static RMethod RMGetWindow_GT_String_Boolean_TypeArray
		{
			get
			{
				if(r_MGetWindow_GT_String_Boolean_TypeArray == null)
				{
					r_MGetWindow_GT_String_Boolean_TypeArray = new(Type, "GetWindow", 1, typeof(System.String), typeof(System.Boolean), typeof(System.Type).MakeArrayType());
				}
				return r_MGetWindow_GT_String_Boolean_TypeArray;
			}
		}

		/// <summary>
		/// T CreateWindow[T](System.Type[])
		/// </summary>
		protected static RMethod r_MCreateWindow_GT_TypeArray;
		public static RMethod RMCreateWindow_GT_TypeArray
		{
			get
			{
				if(r_MCreateWindow_GT_TypeArray == null)
				{
					r_MCreateWindow_GT_TypeArray = new(Type, "CreateWindow", 1, typeof(System.Type).MakeArrayType());
				}
				return r_MCreateWindow_GT_TypeArray;
			}
		}

		/// <summary>
		/// T CreateWindow[T](System.String, System.Type[])
		/// </summary>
		protected static RMethod r_MCreateWindow_GT_String_TypeArray;
		public static RMethod RMCreateWindow_GT_String_TypeArray
		{
			get
			{
				if(r_MCreateWindow_GT_String_TypeArray == null)
				{
					r_MCreateWindow_GT_String_TypeArray = new(Type, "CreateWindow", 1, typeof(System.String), typeof(System.Type).MakeArrayType());
				}
				return r_MCreateWindow_GT_String_TypeArray;
			}
		}

		/// <summary>
		/// Boolean HasOpenInstances[T]()
		/// </summary>
		protected static RMethod r_MHasOpenInstances_GT;
		public static RMethod RMHasOpenInstances_GT
		{
			get
			{
				if(r_MHasOpenInstances_GT == null)
				{
					r_MHasOpenInstances_GT = new(Type, "HasOpenInstances", 1);
				}
				return r_MHasOpenInstances_GT;
			}
		}

		/// <summary>
		/// Void FocusWindowIfItsOpen(System.Type)
		/// </summary>
		protected static RMethod r_MFocusWindowIfItsOpen_Type;
		public static RMethod RMFocusWindowIfItsOpen_Type
		{
			get
			{
				if(r_MFocusWindowIfItsOpen_Type == null)
				{
					r_MFocusWindowIfItsOpen_Type = new(Type, "FocusWindowIfItsOpen", 0, typeof(System.Type));
				}
				return r_MFocusWindowIfItsOpen_Type;
			}
		}

		/// <summary>
		/// Void FocusWindowIfItsOpen[T]()
		/// </summary>
		protected static RMethod r_MFocusWindowIfItsOpen_GT;
		public static RMethod RMFocusWindowIfItsOpen_GT
		{
			get
			{
				if(r_MFocusWindowIfItsOpen_GT == null)
				{
					r_MFocusWindowIfItsOpen_GT = new(Type, "FocusWindowIfItsOpen", 1);
				}
				return r_MFocusWindowIfItsOpen_GT;
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
		/// UnityEditor.EditorWindow GetWindowWithRectPrivate(System.Type, UnityEngine.Rect, Boolean, System.String)
		/// </summary>
		protected static RMethod r_MGetWindowWithRectPrivate_Type_Rect_Boolean_String;
		public static RMethod RMGetWindowWithRectPrivate_Type_Rect_Boolean_String
		{
			get
			{
				if(r_MGetWindowWithRectPrivate_Type_Rect_Boolean_String == null)
				{
					r_MGetWindowWithRectPrivate_Type_Rect_Boolean_String = new(Type, "GetWindowWithRectPrivate", 0, typeof(System.Type), typeof(UnityEngine.Rect), typeof(System.Boolean), typeof(System.String));
				}
				return r_MGetWindowWithRectPrivate_Type_Rect_Boolean_String;
			}
		}

		/// <summary>
		/// T GetWindowWithRect[T](UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_MGetWindowWithRect_GT_Rect;
		public static RMethod RMGetWindowWithRect_GT_Rect
		{
			get
			{
				if(r_MGetWindowWithRect_GT_Rect == null)
				{
					r_MGetWindowWithRect_GT_Rect = new(Type, "GetWindowWithRect", 1, typeof(UnityEngine.Rect));
				}
				return r_MGetWindowWithRect_GT_Rect;
			}
		}

		/// <summary>
		/// T GetWindowWithRect[T](UnityEngine.Rect, Boolean)
		/// </summary>
		protected static RMethod r_MGetWindowWithRect_GT_Rect_Boolean;
		public static RMethod RMGetWindowWithRect_GT_Rect_Boolean
		{
			get
			{
				if(r_MGetWindowWithRect_GT_Rect_Boolean == null)
				{
					r_MGetWindowWithRect_GT_Rect_Boolean = new(Type, "GetWindowWithRect", 1, typeof(UnityEngine.Rect), typeof(System.Boolean));
				}
				return r_MGetWindowWithRect_GT_Rect_Boolean;
			}
		}

		/// <summary>
		/// T GetWindowWithRect[T](UnityEngine.Rect, Boolean, System.String)
		/// </summary>
		protected static RMethod r_MGetWindowWithRect_GT_Rect_Boolean_String;
		public static RMethod RMGetWindowWithRect_GT_Rect_Boolean_String
		{
			get
			{
				if(r_MGetWindowWithRect_GT_Rect_Boolean_String == null)
				{
					r_MGetWindowWithRect_GT_Rect_Boolean_String = new(Type, "GetWindowWithRect", 1, typeof(UnityEngine.Rect), typeof(System.Boolean), typeof(System.String));
				}
				return r_MGetWindowWithRect_GT_Rect_Boolean_String;
			}
		}

		/// <summary>
		/// T GetWindowWithRect[T](UnityEngine.Rect, Boolean, System.String, Boolean)
		/// </summary>
		protected static RMethod r_MGetWindowWithRect_GT_Rect_Boolean_String_Boolean;
		public static RMethod RMGetWindowWithRect_GT_Rect_Boolean_String_Boolean
		{
			get
			{
				if(r_MGetWindowWithRect_GT_Rect_Boolean_String_Boolean == null)
				{
					r_MGetWindowWithRect_GT_Rect_Boolean_String_Boolean = new(Type, "GetWindowWithRect", 1, typeof(UnityEngine.Rect), typeof(System.Boolean), typeof(System.String), typeof(System.Boolean));
				}
				return r_MGetWindowWithRect_GT_Rect_Boolean_String_Boolean;
			}
		}

		/// <summary>
		/// T GetWindowDontShow[T]()
		/// </summary>
		protected static RMethod r_MGetWindowDontShow_GT;
		public static RMethod RMGetWindowDontShow_GT
		{
			get
			{
				if(r_MGetWindowDontShow_GT == null)
				{
					r_MGetWindowDontShow_GT = new(Type, "GetWindowDontShow", 1);
				}
				return r_MGetWindowDontShow_GT;
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
		/// Void __internalAwake()
		/// </summary>
		protected RMethod r_M__internalAwake;
		public virtual RMethod RM__internalAwake
		{
			get
			{
				if(r_M__internalAwake == null)
				{
					r_M__internalAwake = new(this, "__internalAwake", 0);
				}
				return r_M__internalAwake;
			}
		}

		/// <summary>
		/// Void Initialize()
		/// </summary>
		protected static RMethod r_MInitialize;
		public static RMethod RMInitialize
		{
			get
			{
				if(r_MInitialize == null)
				{
					r_MInitialize = new(Type, "Initialize", 0);
				}
				return r_MInitialize;
			}
		}

		/// <summary>
		/// Void OnDisableINTERNAL()
		/// </summary>
		protected RMethod r_MOnDisableINTERNAL;
		public virtual RMethod RMOnDisableINTERNAL
		{
			get
			{
				if(r_MOnDisableINTERNAL == null)
				{
					r_MOnDisableINTERNAL = new(this, "OnDisableINTERNAL", 0);
				}
				return r_MOnDisableINTERNAL;
			}
		}

		/// <summary>
		/// Void CreateNewWindowForEditorWindow(UnityEditor.EditorWindow, Boolean, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_MCreateNewWindowForEditorWindow_EditorWindow_Boolean_Boolean_Boolean;
		public static RMethod RMCreateNewWindowForEditorWindow_EditorWindow_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_MCreateNewWindowForEditorWindow_EditorWindow_Boolean_Boolean_Boolean == null)
				{
					r_MCreateNewWindowForEditorWindow_EditorWindow_Boolean_Boolean_Boolean = new(Type, "CreateNewWindowForEditorWindow", 0, typeof(UnityEditor.EditorWindow), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MCreateNewWindowForEditorWindow_EditorWindow_Boolean_Boolean_Boolean;
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
		/// Void UpdateWindowMenuListing()
		/// </summary>
		protected static RMethod r_MUpdateWindowMenuListing;
		public static RMethod RMUpdateWindowMenuListing
		{
			get
			{
				if(r_MUpdateWindowMenuListing == null)
				{
					r_MUpdateWindowMenuListing = new(Type, "UpdateWindowMenuListing", 0);
				}
				return r_MUpdateWindowMenuListing;
			}
		}

		/// <summary>
		/// Void BuildWindowMenuListing()
		/// </summary>
		protected static RMethod r_MBuildWindowMenuListing;
		public static RMethod RMBuildWindowMenuListing
		{
			get
			{
				if(r_MBuildWindowMenuListing == null)
				{
					r_MBuildWindowMenuListing = new(Type, "BuildWindowMenuListing", 0);
				}
				return r_MBuildWindowMenuListing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement CreateRoot()
		/// </summary>
		protected static RMethod r_MCreateRoot;
		public static RMethod RMCreateRoot
		{
			get
			{
				if(r_MCreateRoot == null)
				{
					r_MCreateRoot = new(Type, "CreateRoot", 0);
				}
				return r_MCreateRoot;
			}
		}

		/// <summary>
		/// Void ToggleAllOverlays(UnityEditor.ShortcutManagement.ShortcutArguments)
		/// </summary>
		protected static RMethod r_MToggleAllOverlays_ShortcutArguments;
		public static RMethod RMToggleAllOverlays_ShortcutArguments
		{
			get
			{
				if(r_MToggleAllOverlays_ShortcutArguments == null)
				{
					r_MToggleAllOverlays_ShortcutArguments = new(Type, "ToggleAllOverlays", 0, typeof(UnityEditor.ShortcutManagement.ShortcutArguments));
				}
				return r_MToggleAllOverlays_ShortcutArguments;
			}
		}

		/// <summary>
		/// Void HideOverlay(UnityEditor.ShortcutManagement.ShortcutArguments)
		/// </summary>
		protected static RMethod r_MHideOverlay_ShortcutArguments;
		public static RMethod RMHideOverlay_ShortcutArguments
		{
			get
			{
				if(r_MHideOverlay_ShortcutArguments == null)
				{
					r_MHideOverlay_ShortcutArguments = new(Type, "HideOverlay", 0, typeof(UnityEditor.ShortcutManagement.ShortcutArguments));
				}
				return r_MHideOverlay_ShortcutArguments;
			}
		}

		/// <summary>
		/// Void ShowOverlayMenu(UnityEditor.ShortcutManagement.ShortcutArguments)
		/// </summary>
		protected static RMethod r_MShowOverlayMenu_ShortcutArguments;
		public static RMethod RMShowOverlayMenu_ShortcutArguments
		{
			get
			{
				if(r_MShowOverlayMenu_ShortcutArguments == null)
				{
					r_MShowOverlayMenu_ShortcutArguments = new(Type, "ShowOverlayMenu", 0, typeof(UnityEditor.ShortcutManagement.ShortcutArguments));
				}
				return r_MShowOverlayMenu_ShortcutArguments;
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


        public static void Internal_MakeModal(Hvak.Editor.Refleaction.RUnityEditor.RContainerWindow @win)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@win.Value};
            var ___result = RMInternal_MakeModal_ContainerWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RDataModeController GetDataModeController_Internal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDataModeController_Internal.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RDataModeController>(___result);
        }


        public virtual void SaveViewData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSaveViewData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SaveViewDataToDisk()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSaveViewDataToDisk.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RISerializableJsonDictionary GetViewDataDictionary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetViewDataDictionary.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RISerializableJsonDictionary>(___result);
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

            return ReflectionUtils.Convert<UnityEngine.GUIContent>(___result);
        }


        public static UnityEngine.GUIContent GetLocalizedTitleContentFromType(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMGetLocalizedTitleContentFromType_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.GUIContent>(___result);
        }


        public static UnityEditor.EditorWindowTitleAttribute GetEditorWindowTitleAttribute(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMGetEditorWindowTitleAttribute_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.EditorWindowTitleAttribute>(___result);
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

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetNumTabs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNumTabs.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean ShowNextTabIfPossible()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShowNextTabIfPossible.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Boolean>(___result);
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


        public virtual void MakeModal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMakeModal.Invoke(___genericsType, ___parameters);

            
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

            return ReflectionUtils.Convert<UnityEngine.Rect>(___result);
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


        public static UnityEditor.EditorWindow GetWindowPrivate(System.Type @t, System.Boolean @utility, System.String @title, System.Boolean @focus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @utility, @title, @focus};
            var ___result = RMGetWindowPrivate_Type_Boolean_String_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.EditorWindow>(___result);
        }


        public static UnityEditor.EditorWindow GetWindow(System.Type @t, System.Boolean @utility, System.String @title, System.Boolean @focus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @utility, @title, @focus};
            var ___result = RMGetWindow_Type_Boolean_String_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.EditorWindow>(___result);
        }


        public static UnityEditor.EditorWindow GetWindow(System.Type @t, System.Boolean @utility, System.String @title)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @utility, @title};
            var ___result = RMGetWindow_Type_Boolean_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.EditorWindow>(___result);
        }


        public static UnityEditor.EditorWindow GetWindow(System.Type @t, System.Boolean @utility)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @utility};
            var ___result = RMGetWindow_Type_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.EditorWindow>(___result);
        }


        public static UnityEditor.EditorWindow GetWindow(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMGetWindow_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.EditorWindow>(___result);
        }


        public static UnityEditor.EditorWindow GetWindowWithRect(System.Type @t, UnityEngine.Rect @rect, System.Boolean @utility, System.String @title)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @rect, @utility, @title};
            var ___result = RMGetWindowWithRect_Type_Rect_Boolean_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.EditorWindow>(___result);
        }


        public static UnityEditor.EditorWindow GetWindowWithRect(System.Type @t, UnityEngine.Rect @rect, System.Boolean @utility)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @rect, @utility};
            var ___result = RMGetWindowWithRect_Type_Rect_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.EditorWindow>(___result);
        }


        public static UnityEditor.EditorWindow GetWindowWithRect(System.Type @t, UnityEngine.Rect @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @rect};
            var ___result = RMGetWindowWithRect_Type_Rect.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.EditorWindow>(___result);
        }


        public static T GetWindow<T>() where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetWindow_GT.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public static T GetWindow<T>(System.Boolean @utility) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@utility};
            var ___result = RMGetWindow_GT_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public static T GetWindow<T>(System.Boolean @utility, System.String @title) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@utility, @title};
            var ___result = RMGetWindow_GT_Boolean_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public static T GetWindow<T>(System.String @title) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@title};
            var ___result = RMGetWindow_GT_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public static T GetWindow<T>(System.String @title, System.Boolean @focus) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@title, @focus};
            var ___result = RMGetWindow_GT_String_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public static T GetWindow<T>(System.Boolean @utility, System.String @title, System.Boolean @focus) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@utility, @title, @focus};
            var ___result = RMGetWindow_GT_Boolean_String_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public static T GetWindow<T>(System.Type[] @desiredDockNextTo) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@desiredDockNextTo};
            var ___result = RMGetWindow_GT_TypeArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public static T GetWindow<T>(System.String @title, System.Type[] @desiredDockNextTo) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@title, @desiredDockNextTo};
            var ___result = RMGetWindow_GT_String_TypeArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public static T GetWindow<T>(System.String @title, System.Boolean @focus, System.Type[] @desiredDockNextTo) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@title, @focus, @desiredDockNextTo};
            var ___result = RMGetWindow_GT_String_Boolean_TypeArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public static T CreateWindow<T>(System.Type[] @desiredDockNextTo) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@desiredDockNextTo};
            var ___result = RMCreateWindow_GT_TypeArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public static T CreateWindow<T>(System.String @title, System.Type[] @desiredDockNextTo) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@title, @desiredDockNextTo};
            var ___result = RMCreateWindow_GT_String_TypeArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public static System.Boolean HasOpenInstances<T>() where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMHasOpenInstances_GT.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static void FocusWindowIfItsOpen(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMFocusWindowIfItsOpen_Type.Invoke(___genericsType, ___parameters);

            
        }


        public static void FocusWindowIfItsOpen<T>() where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMFocusWindowIfItsOpen_GT.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFromDockArea()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRemoveFromDockArea.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEditor.EditorWindow GetWindowWithRectPrivate(System.Type @t, UnityEngine.Rect @rect, System.Boolean @utility, System.String @title)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @rect, @utility, @title};
            var ___result = RMGetWindowWithRectPrivate_Type_Rect_Boolean_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.EditorWindow>(___result);
        }


        public static T GetWindowWithRect<T>(UnityEngine.Rect @rect) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@rect};
            var ___result = RMGetWindowWithRect_GT_Rect.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public static T GetWindowWithRect<T>(UnityEngine.Rect @rect, System.Boolean @utility) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@rect, @utility};
            var ___result = RMGetWindowWithRect_GT_Rect_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public static T GetWindowWithRect<T>(UnityEngine.Rect @rect, System.Boolean @utility, System.String @title) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@rect, @utility, @title};
            var ___result = RMGetWindowWithRect_GT_Rect_Boolean_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public static T GetWindowWithRect<T>(UnityEngine.Rect @rect, System.Boolean @utility, System.String @title, System.Boolean @focus) where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@rect, @utility, @title, @focus};
            var ___result = RMGetWindowWithRect_GT_Rect_Boolean_String_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public static T GetWindowDontShow<T>() where T : UnityEditor.EditorWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetWindowDontShow_GT.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
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

            return ReflectionUtils.Convert<UnityEngine.Vector2>(___result);
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

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void __internalAwake()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RM__internalAwake.Invoke(___genericsType, ___parameters);

            
        }


        public static void Initialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDisableINTERNAL()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnDisableINTERNAL.Invoke(___genericsType, ___parameters);

            
        }


        public static void CreateNewWindowForEditorWindow(UnityEditor.EditorWindow @window, System.Boolean @loadPosition, System.Boolean @showImmediately, System.Boolean @setFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@window, @loadPosition, @showImmediately, @setFocus};
            var ___result = RMCreateNewWindowForEditorWindow_EditorWindow_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
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

            return ReflectionUtils.Convert<System.Collections.Generic.IEnumerable<System.Type>>(___result);
        }


        public static void UpdateWindowMenuListing()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateWindowMenuListing.Invoke(___genericsType, ___parameters);

            
        }


        public static void BuildWindowMenuListing()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBuildWindowMenuListing.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.UIElements.VisualElement CreateRoot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateRoot.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


        public static void ToggleAllOverlays(UnityEditor.ShortcutManagement.ShortcutArguments @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RMToggleAllOverlays_ShortcutArguments.Invoke(___genericsType, ___parameters);

            
        }


        public static void HideOverlay(UnityEditor.ShortcutManagement.ShortcutArguments @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RMHideOverlay_ShortcutArguments.Invoke(___genericsType, ___parameters);

            
        }


        public static void ShowOverlayMenu(UnityEditor.ShortcutManagement.ShortcutArguments @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RMShowOverlayMenu_ShortcutArguments.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryGetOverlay(System.String @id, out UnityEditor.Overlays.Overlay @match)
        {
			@match = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @match};
            var ___result = RMTryGetOverlay_String_Out_Overlay.Invoke(___genericsType, ___parameters);
			@match = (UnityEditor.Overlays.Overlay)___parameters[1];

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
