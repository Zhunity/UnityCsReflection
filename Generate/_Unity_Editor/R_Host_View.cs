
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.HostView
	/// </summary>
    public partial class RHostView : RMember //
    {

		/// <summary>
		/// System.Action`1[UnityEditor.HostView] actualViewChanged
		/// </summary>
		protected static REvent r_EactualViewChanged;
		public static REvent REactualViewChanged
		{
			get
			{
				if(r_EactualViewChanged == null)
				{
					r_EactualViewChanged = new( ReflectionUtils.GetType("UnityEditor.HostView"), "actualViewChanged");
					r_EactualViewChanged.SetBelong(null);
				}
				return r_EactualViewChanged;
			}
		}

		/// <summary>
		/// System.String kPlayModeDarkenKey
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FkPlayModeDarkenKey;
		public static Hvak.Editor.Refleaction.RSystem.RString RFkPlayModeDarkenKey
		{
			get
			{
				if(r_FkPlayModeDarkenKey == null)
				{
					r_FkPlayModeDarkenKey = new( ReflectionUtils.GetType("UnityEditor.HostView"), "kPlayModeDarkenKey");
					r_FkPlayModeDarkenKey.SetBelong(null);
				}
				return r_FkPlayModeDarkenKey;
			}
		}

		/// <summary>
		/// UnityEditor.PrefColor kPlayModeDarken
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPrefColor r_FkPlayModeDarken;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPrefColor RFkPlayModeDarken
		{
			get
			{
				if(r_FkPlayModeDarken == null)
				{
					r_FkPlayModeDarken = new( ReflectionUtils.GetType("UnityEditor.HostView"), "kPlayModeDarken");
					r_FkPlayModeDarken.SetBelong(null);
				}
				return r_FkPlayModeDarken;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.HostView] actualViewChanged
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RHostView> r_FactualViewChanged;
		public static Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RHostView> RFactualViewChanged
		{
			get
			{
				if(r_FactualViewChanged == null)
				{
					r_FactualViewChanged = new( ReflectionUtils.GetType("UnityEditor.HostView"), "actualViewChanged");
					r_FactualViewChanged.SetBelong(null);
				}
				return r_FactualViewChanged;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow m_ActualView
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.REditorWindow r_Fm_ActualView;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.REditorWindow RFm_ActualView
		{
			get
			{
				if(r_Fm_ActualView == null)
				{
					r_Fm_ActualView = new(this, "m_ActualView");
					r_Fm_ActualView.SetBelong(this.GetValue());
				}
				return r_Fm_ActualView;
			}
		}

		/// <summary>
		/// UnityEngine.RectOffset m_BorderSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRectOffset r_Fm_BorderSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRectOffset RFm_BorderSize
		{
			get
			{
				if(r_Fm_BorderSize == null)
				{
					r_Fm_BorderSize = new(this, "m_BorderSize");
					r_Fm_BorderSize.SetBelong(this.GetValue());
				}
				return r_Fm_BorderSize;
			}
		}

		/// <summary>
		/// System.Boolean <showGenericMenu>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__showGenericMenu__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__showGenericMenu__1__k__BackingField
		{
			get
			{
				if(r_F__0__showGenericMenu__1__k__BackingField == null)
				{
					r_F__0__showGenericMenu__1__k__BackingField = new(this, "<showGenericMenu>k__BackingField");
					r_F__0__showGenericMenu__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__showGenericMenu__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowDelegate m_OnGUI
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate r_Fm_OnGUI;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate RFm_OnGUI
		{
			get
			{
				if(r_Fm_OnGUI == null)
				{
					r_Fm_OnGUI = new(this, "m_OnGUI");
					r_Fm_OnGUI.SetBelong(this.GetValue());
				}
				return r_Fm_OnGUI;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowDelegate m_OnFocus
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate r_Fm_OnFocus;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate RFm_OnFocus
		{
			get
			{
				if(r_Fm_OnFocus == null)
				{
					r_Fm_OnFocus = new(this, "m_OnFocus");
					r_Fm_OnFocus.SetBelong(this.GetValue());
				}
				return r_Fm_OnFocus;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowDelegate m_OnLostFocus
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate r_Fm_OnLostFocus;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate RFm_OnLostFocus
		{
			get
			{
				if(r_Fm_OnLostFocus == null)
				{
					r_Fm_OnLostFocus = new(this, "m_OnLostFocus");
					r_Fm_OnLostFocus.SetBelong(this.GetValue());
				}
				return r_Fm_OnLostFocus;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowDelegate m_OnProjectChange
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate r_Fm_OnProjectChange;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate RFm_OnProjectChange
		{
			get
			{
				if(r_Fm_OnProjectChange == null)
				{
					r_Fm_OnProjectChange = new(this, "m_OnProjectChange");
					r_Fm_OnProjectChange.SetBelong(this.GetValue());
				}
				return r_Fm_OnProjectChange;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowDelegate m_OnSelectionChange
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate r_Fm_OnSelectionChange;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate RFm_OnSelectionChange
		{
			get
			{
				if(r_Fm_OnSelectionChange == null)
				{
					r_Fm_OnSelectionChange = new(this, "m_OnSelectionChange");
					r_Fm_OnSelectionChange.SetBelong(this.GetValue());
				}
				return r_Fm_OnSelectionChange;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowDelegate m_OnDidOpenScene
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate r_Fm_OnDidOpenScene;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate RFm_OnDidOpenScene
		{
			get
			{
				if(r_Fm_OnDidOpenScene == null)
				{
					r_Fm_OnDidOpenScene = new(this, "m_OnDidOpenScene");
					r_Fm_OnDidOpenScene.SetBelong(this.GetValue());
				}
				return r_Fm_OnDidOpenScene;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowDelegate m_OnInspectorUpdate
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate r_Fm_OnInspectorUpdate;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate RFm_OnInspectorUpdate
		{
			get
			{
				if(r_Fm_OnInspectorUpdate == null)
				{
					r_Fm_OnInspectorUpdate = new(this, "m_OnInspectorUpdate");
					r_Fm_OnInspectorUpdate.SetBelong(this.GetValue());
				}
				return r_Fm_OnInspectorUpdate;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowDelegate m_OnHierarchyChange
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate r_Fm_OnHierarchyChange;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate RFm_OnHierarchyChange
		{
			get
			{
				if(r_Fm_OnHierarchyChange == null)
				{
					r_Fm_OnHierarchyChange = new(this, "m_OnHierarchyChange");
					r_Fm_OnHierarchyChange.SetBelong(this.GetValue());
				}
				return r_Fm_OnHierarchyChange;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowDelegate m_OnBecameVisible
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate r_Fm_OnBecameVisible;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate RFm_OnBecameVisible
		{
			get
			{
				if(r_Fm_OnBecameVisible == null)
				{
					r_Fm_OnBecameVisible = new(this, "m_OnBecameVisible");
					r_Fm_OnBecameVisible.SetBelong(this.GetValue());
				}
				return r_Fm_OnBecameVisible;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowDelegate m_OnBecameInvisible
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate r_Fm_OnBecameInvisible;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate RFm_OnBecameInvisible
		{
			get
			{
				if(r_Fm_OnBecameInvisible == null)
				{
					r_Fm_OnBecameInvisible = new(this, "m_OnBecameInvisible");
					r_Fm_OnBecameInvisible.SetBelong(this.GetValue());
				}
				return r_Fm_OnBecameInvisible;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowDelegate m_Update
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate r_Fm_Update;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate RFm_Update
		{
			get
			{
				if(r_Fm_Update == null)
				{
					r_Fm_Update = new(this, "m_Update");
					r_Fm_Update.SetBelong(this.GetValue());
				}
				return r_Fm_Update;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowDelegate m_ModifierKeysChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate r_Fm_ModifierKeysChanged;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate RFm_ModifierKeysChanged
		{
			get
			{
				if(r_Fm_ModifierKeysChanged == null)
				{
					r_Fm_ModifierKeysChanged = new(this, "m_ModifierKeysChanged");
					r_Fm_ModifierKeysChanged.SetBelong(this.GetValue());
				}
				return r_Fm_ModifierKeysChanged;
			}
		}

		/// <summary>
		/// UnityEditor.HostView+EditorWindowShowButtonDelegate m_ShowButton
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowShowButtonDelegate r_Fm_ShowButton;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowShowButtonDelegate RFm_ShowButton
		{
			get
			{
				if(r_Fm_ShowButton == null)
				{
					r_Fm_ShowButton = new(this, "m_ShowButton");
					r_Fm_ShowButton.SetBelong(this.GetValue());
				}
				return r_Fm_ShowButton;
			}
		}

		/// <summary>
		/// System.Boolean m_IsLosingFocus
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_IsLosingFocus;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_IsLosingFocus
		{
			get
			{
				if(r_Fm_IsLosingFocus == null)
				{
					r_Fm_IsLosingFocus = new(this, "m_IsLosingFocus");
					r_Fm_IsLosingFocus.SetBelong(this.GetValue());
				}
				return r_Fm_IsLosingFocus;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 k_DockedMinSize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Fk_DockedMinSize;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFk_DockedMinSize
		{
			get
			{
				if(r_Fk_DockedMinSize == null)
				{
					r_Fk_DockedMinSize = new( ReflectionUtils.GetType("UnityEditor.HostView"), "k_DockedMinSize");
					r_Fk_DockedMinSize.SetBelong(null);
				}
				return r_Fk_DockedMinSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 k_DockedMaxSize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Fk_DockedMaxSize;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFk_DockedMaxSize
		{
			get
			{
				if(r_Fk_DockedMaxSize == null)
				{
					r_Fk_DockedMaxSize = new( ReflectionUtils.GetType("UnityEditor.HostView"), "k_DockedMaxSize");
					r_Fk_DockedMaxSize.SetBelong(null);
				}
				return r_Fk_DockedMaxSize;
			}
		}

		/// <summary>
		/// System.Action <UnityEditor.IEditorWindowModel.onSplitterGUIHandler>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_F__0__UnityEditor__2__IEditorWindowModel__2__onSplitterGUIHandler__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RF__0__UnityEditor__2__IEditorWindowModel__2__onSplitterGUIHandler__1__k__BackingField
		{
			get
			{
				if(r_F__0__UnityEditor__2__IEditorWindowModel__2__onSplitterGUIHandler__1__k__BackingField == null)
				{
					r_F__0__UnityEditor__2__IEditorWindowModel__2__onSplitterGUIHandler__1__k__BackingField = new(this, "<UnityEditor.IEditorWindowModel.onSplitterGUIHandler>k__BackingField");
					r_F__0__UnityEditor__2__IEditorWindowModel__2__onSplitterGUIHandler__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__UnityEditor__2__IEditorWindowModel__2__onSplitterGUIHandler__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Type[] k_PaneTypes
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType> r_Fk_PaneTypes;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType> RFk_PaneTypes
		{
			get
			{
				if(r_Fk_PaneTypes == null)
				{
					r_Fk_PaneTypes = new( ReflectionUtils.GetType("UnityEditor.HostView"), "k_PaneTypes");
					r_Fk_PaneTypes.SetBelong(null);
				}
				return r_Fk_PaneTypes;
			}
		}

		/// <summary>
		/// System.String m_ActualViewName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_ActualViewName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_ActualViewName
		{
			get
			{
				if(r_Fm_ActualViewName == null)
				{
					r_Fm_ActualViewName = new(this, "m_ActualViewName");
					r_Fm_ActualViewName.SetBelong(this.GetValue());
				}
				return r_Fm_ActualViewName;
			}
		}

		/// <summary>
		/// System.Boolean m_NotificationIsVisible
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_NotificationIsVisible;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_NotificationIsVisible
		{
			get
			{
				if(r_Fm_NotificationIsVisible == null)
				{
					r_Fm_NotificationIsVisible = new(this, "m_NotificationIsVisible");
					r_Fm_NotificationIsVisible.SetBelong(this.GetValue());
				}
				return r_Fm_NotificationIsVisible;
			}
		}

		/// <summary>
		/// UnityEditor.WindowAction[] s_windowActions
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RWindowAction> r_Fs_windowActions;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RWindowAction> RFs_windowActions
		{
			get
			{
				if(r_Fs_windowActions == null)
				{
					r_Fs_windowActions = new( ReflectionUtils.GetType("UnityEditor.HostView"), "s_windowActions");
					r_Fs_windowActions.SetBelong(null);
				}
				return r_Fs_windowActions;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.SVC`1[System.Single] genericMenuLeftOffset
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RSVC<Hvak.Editor.Refleaction.RSystem.RSingle> r_FgenericMenuLeftOffset;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RSVC<Hvak.Editor.Refleaction.RSystem.RSingle> RFgenericMenuLeftOffset
		{
			get
			{
				if(r_FgenericMenuLeftOffset == null)
				{
					r_FgenericMenuLeftOffset = new( ReflectionUtils.GetType("UnityEditor.HostView"), "genericMenuLeftOffset");
					r_FgenericMenuLeftOffset.SetBelong(null);
				}
				return r_FgenericMenuLeftOffset;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.SVC`1[System.Single] genericMenuFloatingLeftOffset
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RSVC<Hvak.Editor.Refleaction.RSystem.RSingle> r_FgenericMenuFloatingLeftOffset;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RSVC<Hvak.Editor.Refleaction.RSystem.RSingle> RFgenericMenuFloatingLeftOffset
		{
			get
			{
				if(r_FgenericMenuFloatingLeftOffset == null)
				{
					r_FgenericMenuFloatingLeftOffset = new( ReflectionUtils.GetType("UnityEditor.HostView"), "genericMenuFloatingLeftOffset");
					r_FgenericMenuFloatingLeftOffset.SetBelong(null);
				}
				return r_FgenericMenuFloatingLeftOffset;
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
					r_Fm_EventInterests.SetBelong(this.GetValue());
				}
				return r_Fm_EventInterests;
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
					r_Fm_MinSize.SetBelong(this.GetValue());
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
					r_Fm_MaxSize.SetBelong(this.GetValue());
				}
				return r_Fm_MaxSize;
			}
		}

		/// <summary>
		/// Boolean showGenericMenu
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PshowGenericMenu;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPshowGenericMenu
		{
			get
			{
				if(r_PshowGenericMenu == null)
				{
					r_PshowGenericMenu = new(this, "showGenericMenu", -1);
					r_PshowGenericMenu.SetBelong(this.GetValue());
				}
				return r_PshowGenericMenu;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow actualView
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.REditorWindow r_PactualView;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.REditorWindow RPactualView
		{
			get
			{
				if(r_PactualView == null)
				{
					r_PactualView = new(this, "actualView", -1);
					r_PactualView.SetBelong(this.GetValue());
				}
				return r_PactualView;
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
					r_PminSize.SetBelong(this.GetValue());
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
					r_PmaxSize.SetBelong(this.GetValue());
				}
				return r_PmaxSize;
			}
		}

		/// <summary>
		/// UnityEngine.RectOffset UnityEditor.IEditorWindowModel.viewMargins
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRectOffset r_PUnityEditor__2__IEditorWindowModel__2__viewMargins;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRectOffset RPUnityEditor__2__IEditorWindowModel__2__viewMargins
		{
			get
			{
				if(r_PUnityEditor__2__IEditorWindowModel__2__viewMargins == null)
				{
					r_PUnityEditor__2__IEditorWindowModel__2__viewMargins = new(this, "UnityEditor.IEditorWindowModel.viewMargins", -1);
					r_PUnityEditor__2__IEditorWindowModel__2__viewMargins.SetBelong(this.GetValue());
				}
				return r_PUnityEditor__2__IEditorWindowModel__2__viewMargins;
			}
		}

		/// <summary>
		/// System.Action UnityEditor.IEditorWindowModel.onSplitterGUIHandler
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_PUnityEditor__2__IEditorWindowModel__2__onSplitterGUIHandler;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RPUnityEditor__2__IEditorWindowModel__2__onSplitterGUIHandler
		{
			get
			{
				if(r_PUnityEditor__2__IEditorWindowModel__2__onSplitterGUIHandler == null)
				{
					r_PUnityEditor__2__IEditorWindowModel__2__onSplitterGUIHandler = new(this, "UnityEditor.IEditorWindowModel.onSplitterGUIHandler", -1);
					r_PUnityEditor__2__IEditorWindowModel__2__onSplitterGUIHandler.SetBelong(this.GetValue());
				}
				return r_PUnityEditor__2__IEditorWindowModel__2__onSplitterGUIHandler;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow UnityEditor.IEditorWindowModel.window
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.REditorWindow r_PUnityEditor__2__IEditorWindowModel__2__window;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.REditorWindow RPUnityEditor__2__IEditorWindowModel__2__window
		{
			get
			{
				if(r_PUnityEditor__2__IEditorWindowModel__2__window == null)
				{
					r_PUnityEditor__2__IEditorWindowModel__2__window = new(this, "UnityEditor.IEditorWindowModel.window", -1);
					r_PUnityEditor__2__IEditorWindowModel__2__window.SetBelong(this.GetValue());
				}
				return r_PUnityEditor__2__IEditorWindowModel__2__window;
			}
		}

		/// <summary>
		/// UnityEditor.IEditorWindowBackend editorWindowBackend
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIEditorWindowBackend r_PeditorWindowBackend;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIEditorWindowBackend RPeditorWindowBackend
		{
			get
			{
				if(r_PeditorWindowBackend == null)
				{
					r_PeditorWindowBackend = new(this, "editorWindowBackend", -1);
					r_PeditorWindowBackend.SetBelong(this.GetValue());
				}
				return r_PeditorWindowBackend;
			}
		}

		/// <summary>
		/// Boolean UnityEditor.IEditorWindowModel.notificationVisible
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PUnityEditor__2__IEditorWindowModel__2__notificationVisible;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPUnityEditor__2__IEditorWindowModel__2__notificationVisible
		{
			get
			{
				if(r_PUnityEditor__2__IEditorWindowModel__2__notificationVisible == null)
				{
					r_PUnityEditor__2__IEditorWindowModel__2__notificationVisible = new(this, "UnityEditor.IEditorWindowModel.notificationVisible", -1);
					r_PUnityEditor__2__IEditorWindowModel__2__notificationVisible.SetBelong(this.GetValue());
				}
				return r_PUnityEditor__2__IEditorWindowModel__2__notificationVisible;
			}
		}

		/// <summary>
		/// UnityEngine.RectOffset borderSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRectOffset r_PborderSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRectOffset RPborderSize
		{
			get
			{
				if(r_PborderSize == null)
				{
					r_PborderSize = new(this, "borderSize", -1);
					r_PborderSize.SetBelong(this.GetValue());
				}
				return r_PborderSize;
			}
		}

		/// <summary>
		/// UnityEditor.WindowAction[] windowActions
		/// </summary>
		protected static Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.RWindowAction> r_PwindowActions;
		public static Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.RWindowAction> RPwindowActions
		{
			get
			{
				if(r_PwindowActions == null)
				{
					r_PwindowActions = new( ReflectionUtils.GetType("UnityEditor.HostView"), "windowActions", -1);
					r_PwindowActions.SetBelong(null);
				}
				return r_PwindowActions;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEditor.IEditorWindowModel.playModeTintColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_PUnityEditor__2__IEditorWindowModel__2__playModeTintColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPUnityEditor__2__IEditorWindowModel__2__playModeTintColor
		{
			get
			{
				if(r_PUnityEditor__2__IEditorWindowModel__2__playModeTintColor == null)
				{
					r_PUnityEditor__2__IEditorWindowModel__2__playModeTintColor = new(this, "UnityEditor.IEditorWindowModel.playModeTintColor", -1);
					r_PUnityEditor__2__IEditorWindowModel__2__playModeTintColor.SetBelong(this.GetValue());
				}
				return r_PUnityEditor__2__IEditorWindowModel__2__playModeTintColor;
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
					r_PhasFocus.SetBelong(this.GetValue());
				}
				return r_PhasFocus;
			}
		}

		/// <summary>
		/// Boolean mouseRayInvisible
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PmouseRayInvisible;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPmouseRayInvisible
		{
			get
			{
				if(r_PmouseRayInvisible == null)
				{
					r_PmouseRayInvisible = new(this, "mouseRayInvisible", -1);
					r_PmouseRayInvisible.SetBelong(this.GetValue());
				}
				return r_PmouseRayInvisible;
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
					r_PdisableInputEvents.SetBelong(this.GetValue());
				}
				return r_PdisableInputEvents;
			}
		}

		/// <summary>
		/// Boolean hdrActive
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhdrActive;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhdrActive
		{
			get
			{
				if(r_PhdrActive == null)
				{
					r_PhdrActive = new(this, "hdrActive", -1);
					r_PhdrActive.SetBelong(this.GetValue());
				}
				return r_PhdrActive;
			}
		}

		/// <summary>
		/// IntPtr nativeHandle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_PnativeHandle;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RPnativeHandle
		{
			get
			{
				if(r_PnativeHandle == null)
				{
					r_PnativeHandle = new(this, "nativeHandle", -1);
					r_PnativeHandle.SetBelong(this.GetValue());
				}
				return r_PnativeHandle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement visualTree
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PvisualTree;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPvisualTree
		{
			get
			{
				if(r_PvisualTree == null)
				{
					r_PvisualTree = new(this, "visualTree", -1);
					r_PvisualTree.SetBelong(this.GetValue());
				}
				return r_PvisualTree;
			}
		}

		/// <summary>
		/// UnityEngine.EventInterests eventInterests
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.REventInterests r_PeventInterests;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.REventInterests RPeventInterests
		{
			get
			{
				if(r_PeventInterests == null)
				{
					r_PeventInterests = new(this, "eventInterests", -1);
					r_PeventInterests.SetBelong(this.GetValue());
				}
				return r_PeventInterests;
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
					r_PwantsMouseMove.SetBelong(this.GetValue());
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
					r_PwantsMouseEnterLeaveWindow.SetBelong(this.GetValue());
				}
				return r_PwantsMouseEnterLeaveWindow;
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
					r_PautoRepaintOnSceneChange.SetBelong(this.GetValue());
				}
				return r_PautoRepaintOnSceneChange;
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
					r_PdepthBufferBits.SetBelong(this.GetValue());
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
					r_PantiAliasing.SetBelong(this.GetValue());
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
					r_PantiAlias.SetBelong(this.GetValue());
				}
				return r_PantiAlias;
			}
		}

		/// <summary>
		/// UnityEditor.IWindowBackend windowBackend
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIWindowBackend r_PwindowBackend;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIWindowBackend RPwindowBackend
		{
			get
			{
				if(r_PwindowBackend == null)
				{
					r_PwindowBackend = new(this, "windowBackend", -1);
					r_PwindowBackend.SetBelong(this.GetValue());
				}
				return r_PwindowBackend;
			}
		}

		/// <summary>
		/// UnityEditor.View[] allChildren
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.RView> r_PallChildren;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.RView> RPallChildren
		{
			get
			{
				if(r_PallChildren == null)
				{
					r_PallChildren = new(this, "allChildren", -1);
					r_PallChildren.SetBelong(this.GetValue());
				}
				return r_PallChildren;
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
					r_Pposition.SetBelong(this.GetValue());
				}
				return r_Pposition;
			}
		}

		/// <summary>
		/// UnityEngine.Rect windowPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PwindowPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPwindowPosition
		{
			get
			{
				if(r_PwindowPosition == null)
				{
					r_PwindowPosition = new(this, "windowPosition", -1);
					r_PwindowPosition.SetBelong(this.GetValue());
				}
				return r_PwindowPosition;
			}
		}

		/// <summary>
		/// UnityEngine.Rect screenPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PscreenPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPscreenPosition
		{
			get
			{
				if(r_PscreenPosition == null)
				{
					r_PscreenPosition = new(this, "screenPosition", -1);
					r_PscreenPosition.SetBelong(this.GetValue());
				}
				return r_PscreenPosition;
			}
		}

		/// <summary>
		/// UnityEditor.ContainerWindow window
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RContainerWindow r_Pwindow;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RContainerWindow RPwindow
		{
			get
			{
				if(r_Pwindow == null)
				{
					r_Pwindow = new(this, "window", -1);
					r_Pwindow.SetBelong(this.GetValue());
				}
				return r_Pwindow;
			}
		}

		/// <summary>
		/// UnityEditor.View parent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RView r_Pparent;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RView RPparent
		{
			get
			{
				if(r_Pparent == null)
				{
					r_Pparent = new(this, "parent", -1);
					r_Pparent.SetBelong(this.GetValue());
				}
				return r_Pparent;
			}
		}

		/// <summary>
		/// UnityEditor.View[] children
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.RView> r_Pchildren;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.RView> RPchildren
		{
			get
			{
				if(r_Pchildren == null)
				{
					r_Pchildren = new(this, "children", -1);
					r_Pchildren.SetBelong(this.GetValue());
				}
				return r_Pchildren;
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
					r_Pname.SetBelong(this.GetValue());
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
					r_PhideFlags.SetBelong(this.GetValue());
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// Void SetActualViewInternal(UnityEditor.EditorWindow, Boolean)
		/// </summary>
		protected RMethod r_MSetActualViewInternal_EditorWindow_Boolean;
		public virtual RMethod RMSetActualViewInternal_EditorWindow_Boolean
		{
			get
			{
				if(r_MSetActualViewInternal_EditorWindow_Boolean == null)
				{
					r_MSetActualViewInternal_EditorWindow_Boolean = new(this, "SetActualViewInternal", 0, typeof(UnityEditor.EditorWindow), typeof(System.Boolean));
					r_MSetActualViewInternal_EditorWindow_Boolean.SetBelong(this.GetValue());
				}
				return r_MSetActualViewInternal_EditorWindow_Boolean;
			}
		}

		/// <summary>
		/// Void CreateDelegates()
		/// </summary>
		protected RMethod r_MCreateDelegates;
		public virtual RMethod RMCreateDelegates
		{
			get
			{
				if(r_MCreateDelegates == null)
				{
					r_MCreateDelegates = new(this, "CreateDelegates", 0);
					r_MCreateDelegates.SetBelong(this.GetValue());
				}
				return r_MCreateDelegates;
			}
		}

		/// <summary>
		/// Void ClearDelegates()
		/// </summary>
		protected RMethod r_MClearDelegates;
		public virtual RMethod RMClearDelegates
		{
			get
			{
				if(r_MClearDelegates == null)
				{
					r_MClearDelegates = new(this, "ClearDelegates", 0);
					r_MClearDelegates.SetBelong(this.GetValue());
				}
				return r_MClearDelegates;
			}
		}

		/// <summary>
		/// Void ResetActiveView()
		/// </summary>
		protected RMethod r_MResetActiveView;
		public virtual RMethod RMResetActiveView
		{
			get
			{
				if(r_MResetActiveView == null)
				{
					r_MResetActiveView = new(this, "ResetActiveView", 0);
					r_MResetActiveView.SetBelong(this.GetValue());
				}
				return r_MResetActiveView;
			}
		}

		/// <summary>
		/// Void UpdateMargins(UnityEditor.EditorWindow)
		/// </summary>
		protected RMethod r_MUpdateMargins_EditorWindow;
		public virtual RMethod RMUpdateMargins_EditorWindow
		{
			get
			{
				if(r_MUpdateMargins_EditorWindow == null)
				{
					r_MUpdateMargins_EditorWindow = new(this, "UpdateMargins", 0, typeof(UnityEditor.EditorWindow));
					r_MUpdateMargins_EditorWindow.SetBelong(this.GetValue());
				}
				return r_MUpdateMargins_EditorWindow;
			}
		}

		/// <summary>
		/// Void UpdateViewMargins(UnityEditor.EditorWindow)
		/// </summary>
		protected RMethod r_MUpdateViewMargins_EditorWindow;
		public virtual RMethod RMUpdateViewMargins_EditorWindow
		{
			get
			{
				if(r_MUpdateViewMargins_EditorWindow == null)
				{
					r_MUpdateViewMargins_EditorWindow = new(this, "UpdateViewMargins", 0, typeof(UnityEditor.EditorWindow));
					r_MUpdateViewMargins_EditorWindow.SetBelong(this.GetValue());
				}
				return r_MUpdateViewMargins_EditorWindow;
			}
		}

		/// <summary>
		/// Void SetPosition(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MSetPosition_Rect;
		public virtual RMethod RMSetPosition_Rect
		{
			get
			{
				if(r_MSetPosition_Rect == null)
				{
					r_MSetPosition_Rect = new(this, "SetPosition", 0, typeof(UnityEngine.Rect));
					r_MSetPosition_Rect.SetBelong(this.GetValue());
				}
				return r_MSetPosition_Rect;
			}
		}

		/// <summary>
		/// Void SetActualViewPosition(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MSetActualViewPosition_Rect;
		public virtual RMethod RMSetActualViewPosition_Rect
		{
			get
			{
				if(r_MSetActualViewPosition_Rect == null)
				{
					r_MSetActualViewPosition_Rect = new(this, "SetActualViewPosition", 0, typeof(UnityEngine.Rect));
					r_MSetActualViewPosition_Rect.SetBelong(this.GetValue());
				}
				return r_MSetActualViewPosition_Rect;
			}
		}

		/// <summary>
		/// Void SetWindow(UnityEditor.ContainerWindow)
		/// </summary>
		protected RMethod r_MSetWindow_ContainerWindow;
		public virtual RMethod RMSetWindow_ContainerWindow
		{
			get
			{
				if(r_MSetWindow_ContainerWindow == null)
				{
					r_MSetWindow_ContainerWindow = new(this, "SetWindow", 0,  ReflectionUtils.GetType("UnityEditor.ContainerWindow"));
					r_MSetWindow_ContainerWindow.SetBelong(this.GetValue());
				}
				return r_MSetWindow_ContainerWindow;
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
					r_MOnEnable.SetBelong(this.GetValue());
				}
				return r_MOnEnable;
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
					r_MOnDisable.SetBelong(this.GetValue());
				}
				return r_MOnDisable;
			}
		}

		/// <summary>
		/// Void OnEditorModeChanged(ModeChangedArgs)
		/// </summary>
		protected RMethod r_MOnEditorModeChanged_ModeChangedArgs;
		public virtual RMethod RMOnEditorModeChanged_ModeChangedArgs
		{
			get
			{
				if(r_MOnEditorModeChanged_ModeChangedArgs == null)
				{
					r_MOnEditorModeChanged_ModeChangedArgs = new(this, "OnEditorModeChanged", 0,  ReflectionUtils.GetType("UnityEditor.ModeService+ModeChangedArgs"));
					r_MOnEditorModeChanged_ModeChangedArgs.SetBelong(this.GetValue());
				}
				return r_MOnEditorModeChanged_ModeChangedArgs;
			}
		}

		/// <summary>
		/// Void HandleSplitView()
		/// </summary>
		protected RMethod r_MHandleSplitView;
		public virtual RMethod RMHandleSplitView
		{
			get
			{
				if(r_MHandleSplitView == null)
				{
					r_MHandleSplitView = new(this, "HandleSplitView", 0);
					r_MHandleSplitView.SetBelong(this.GetValue());
				}
				return r_MHandleSplitView;
			}
		}

		/// <summary>
		/// Void OldOnGUI()
		/// </summary>
		protected RMethod r_MOldOnGUI;
		public virtual RMethod RMOldOnGUI
		{
			get
			{
				if(r_MOldOnGUI == null)
				{
					r_MOldOnGUI = new(this, "OldOnGUI", 0);
					r_MOldOnGUI.SetBelong(this.GetValue());
				}
				return r_MOldOnGUI;
			}
		}

		/// <summary>
		/// Boolean OnFocus()
		/// </summary>
		protected RMethod r_MOnFocus;
		public virtual RMethod RMOnFocus
		{
			get
			{
				if(r_MOnFocus == null)
				{
					r_MOnFocus = new(this, "OnFocus", 0);
					r_MOnFocus.SetBelong(this.GetValue());
				}
				return r_MOnFocus;
			}
		}

		/// <summary>
		/// Void OnLostFocus()
		/// </summary>
		protected RMethod r_MOnLostFocus;
		public virtual RMethod RMOnLostFocus
		{
			get
			{
				if(r_MOnLostFocus == null)
				{
					r_MOnLostFocus = new(this, "OnLostFocus", 0);
					r_MOnLostFocus.SetBelong(this.GetValue());
				}
				return r_MOnLostFocus;
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
					r_MOnBackingScaleFactorChanged.SetBelong(this.GetValue());
				}
				return r_MOnBackingScaleFactorChanged;
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
					r_MOnDestroy.SetBelong(this.GetValue());
				}
				return r_MOnDestroy;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Type] GetCurrentModePaneTypes(System.String)
		/// </summary>
		protected static RMethod r_MGetCurrentModePaneTypes_String;
		public static RMethod RMGetCurrentModePaneTypes_String
		{
			get
			{
				if(r_MGetCurrentModePaneTypes_String == null)
				{
					r_MGetCurrentModePaneTypes_String = new( ReflectionUtils.GetType("UnityEditor.HostView"), "GetCurrentModePaneTypes", 0, typeof(System.String));
					r_MGetCurrentModePaneTypes_String.SetBelong(null);
				}
				return r_MGetCurrentModePaneTypes_String;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Type] GetDefaultPaneTypes()
		/// </summary>
		protected static RMethod r_MGetDefaultPaneTypes;
		public static RMethod RMGetDefaultPaneTypes
		{
			get
			{
				if(r_MGetDefaultPaneTypes == null)
				{
					r_MGetDefaultPaneTypes = new( ReflectionUtils.GetType("UnityEditor.HostView"), "GetDefaultPaneTypes", 0);
					r_MGetDefaultPaneTypes.SetBelong(null);
				}
				return r_MGetDefaultPaneTypes;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Type] GetPaneTypes()
		/// </summary>
		protected RMethod r_MGetPaneTypes;
		public virtual RMethod RMGetPaneTypes
		{
			get
			{
				if(r_MGetPaneTypes == null)
				{
					r_MGetPaneTypes = new(this, "GetPaneTypes", 0);
					r_MGetPaneTypes.SetBelong(this.GetValue());
				}
				return r_MGetPaneTypes;
			}
		}

		/// <summary>
		/// Void OnProjectChange()
		/// </summary>
		protected RMethod r_MOnProjectChange;
		public virtual RMethod RMOnProjectChange
		{
			get
			{
				if(r_MOnProjectChange == null)
				{
					r_MOnProjectChange = new(this, "OnProjectChange", 0);
					r_MOnProjectChange.SetBelong(this.GetValue());
				}
				return r_MOnProjectChange;
			}
		}

		/// <summary>
		/// Void OnSelectionChange()
		/// </summary>
		protected RMethod r_MOnSelectionChange;
		public virtual RMethod RMOnSelectionChange
		{
			get
			{
				if(r_MOnSelectionChange == null)
				{
					r_MOnSelectionChange = new(this, "OnSelectionChange", 0);
					r_MOnSelectionChange.SetBelong(this.GetValue());
				}
				return r_MOnSelectionChange;
			}
		}

		/// <summary>
		/// Void OnDidOpenScene()
		/// </summary>
		protected RMethod r_MOnDidOpenScene;
		public virtual RMethod RMOnDidOpenScene
		{
			get
			{
				if(r_MOnDidOpenScene == null)
				{
					r_MOnDidOpenScene = new(this, "OnDidOpenScene", 0);
					r_MOnDidOpenScene.SetBelong(this.GetValue());
				}
				return r_MOnDidOpenScene;
			}
		}

		/// <summary>
		/// Void OnInspectorUpdate()
		/// </summary>
		protected RMethod r_MOnInspectorUpdate;
		public virtual RMethod RMOnInspectorUpdate
		{
			get
			{
				if(r_MOnInspectorUpdate == null)
				{
					r_MOnInspectorUpdate = new(this, "OnInspectorUpdate", 0);
					r_MOnInspectorUpdate.SetBelong(this.GetValue());
				}
				return r_MOnInspectorUpdate;
			}
		}

		/// <summary>
		/// Void OnHierarchyChange()
		/// </summary>
		protected RMethod r_MOnHierarchyChange;
		public virtual RMethod RMOnHierarchyChange
		{
			get
			{
				if(r_MOnHierarchyChange == null)
				{
					r_MOnHierarchyChange = new(this, "OnHierarchyChange", 0);
					r_MOnHierarchyChange.SetBelong(this.GetValue());
				}
				return r_MOnHierarchyChange;
			}
		}

		/// <summary>
		/// EditorWindowDelegate CreateDelegate(System.String)
		/// </summary>
		protected RMethod r_MCreateDelegate_String;
		public virtual RMethod RMCreateDelegate_String
		{
			get
			{
				if(r_MCreateDelegate_String == null)
				{
					r_MCreateDelegate_String = new(this, "CreateDelegate", 0, typeof(System.String));
					r_MCreateDelegate_String.SetBelong(this.GetValue());
				}
				return r_MCreateDelegate_String;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetPaneMethod(System.String)
		/// </summary>
		protected RMethod r_MGetPaneMethod_String;
		public virtual RMethod RMGetPaneMethod_String
		{
			get
			{
				if(r_MGetPaneMethod_String == null)
				{
					r_MGetPaneMethod_String = new(this, "GetPaneMethod", 0, typeof(System.String));
					r_MGetPaneMethod_String.SetBelong(this.GetValue());
				}
				return r_MGetPaneMethod_String;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetPaneMethod(System.String, System.Object)
		/// </summary>
		protected RMethod r_MGetPaneMethod_String_Object;
		public virtual RMethod RMGetPaneMethod_String_Object
		{
			get
			{
				if(r_MGetPaneMethod_String_Object == null)
				{
					r_MGetPaneMethod_String_Object = new(this, "GetPaneMethod", 0, typeof(System.String), typeof(System.Object));
					r_MGetPaneMethod_String_Object.SetBelong(this.GetValue());
				}
				return r_MGetPaneMethod_String_Object;
			}
		}

		/// <summary>
		/// System.String GetActualViewName()
		/// </summary>
		protected RMethod r_MGetActualViewName;
		public virtual RMethod RMGetActualViewName
		{
			get
			{
				if(r_MGetActualViewName == null)
				{
					r_MGetActualViewName = new(this, "GetActualViewName", 0);
					r_MGetActualViewName.SetBelong(this.GetValue());
				}
				return r_MGetActualViewName;
			}
		}

		/// <summary>
		/// Void InvokeOnGUI(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MInvokeOnGUI_Rect;
		public virtual RMethod RMInvokeOnGUI_Rect
		{
			get
			{
				if(r_MInvokeOnGUI_Rect == null)
				{
					r_MInvokeOnGUI_Rect = new(this, "InvokeOnGUI", 0, typeof(UnityEngine.Rect));
					r_MInvokeOnGUI_Rect.SetBelong(this.GetValue());
				}
				return r_MInvokeOnGUI_Rect;
			}
		}

		/// <summary>
		/// Void Invoke(System.String)
		/// </summary>
		protected RMethod r_MInvoke_String;
		public virtual RMethod RMInvoke_String
		{
			get
			{
				if(r_MInvoke_String == null)
				{
					r_MInvoke_String = new(this, "Invoke", 0, typeof(System.String));
					r_MInvoke_String.SetBelong(this.GetValue());
				}
				return r_MInvoke_String;
			}
		}

		/// <summary>
		/// Void Invoke(System.String, System.Object)
		/// </summary>
		protected RMethod r_MInvoke_String_Object;
		public virtual RMethod RMInvoke_String_Object
		{
			get
			{
				if(r_MInvoke_String_Object == null)
				{
					r_MInvoke_String_Object = new(this, "Invoke", 0, typeof(System.String), typeof(System.Object));
					r_MInvoke_String_Object.SetBelong(this.GetValue());
				}
				return r_MInvoke_String_Object;
			}
		}

		/// <summary>
		/// Void RegisterSelectedPane(Boolean)
		/// </summary>
		protected RMethod r_MRegisterSelectedPane_Boolean;
		public virtual RMethod RMRegisterSelectedPane_Boolean
		{
			get
			{
				if(r_MRegisterSelectedPane_Boolean == null)
				{
					r_MRegisterSelectedPane_Boolean = new(this, "RegisterSelectedPane", 0, typeof(System.Boolean));
					r_MRegisterSelectedPane_Boolean.SetBelong(this.GetValue());
				}
				return r_MRegisterSelectedPane_Boolean;
			}
		}

		/// <summary>
		/// Void DeregisterSelectedPane(Boolean, Boolean)
		/// </summary>
		protected RMethod r_MDeregisterSelectedPane_Boolean_Boolean;
		public virtual RMethod RMDeregisterSelectedPane_Boolean_Boolean
		{
			get
			{
				if(r_MDeregisterSelectedPane_Boolean_Boolean == null)
				{
					r_MDeregisterSelectedPane_Boolean_Boolean = new(this, "DeregisterSelectedPane", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_MDeregisterSelectedPane_Boolean_Boolean.SetBelong(this.GetValue());
				}
				return r_MDeregisterSelectedPane_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void CheckNotificationStatus()
		/// </summary>
		protected RMethod r_MCheckNotificationStatus;
		public virtual RMethod RMCheckNotificationStatus
		{
			get
			{
				if(r_MCheckNotificationStatus == null)
				{
					r_MCheckNotificationStatus = new(this, "CheckNotificationStatus", 0);
					r_MCheckNotificationStatus.SetBelong(this.GetValue());
				}
				return r_MCheckNotificationStatus;
			}
		}

		/// <summary>
		/// Void SendUpdate()
		/// </summary>
		protected RMethod r_MSendUpdate;
		public virtual RMethod RMSendUpdate
		{
			get
			{
				if(r_MSendUpdate == null)
				{
					r_MSendUpdate = new(this, "SendUpdate", 0);
					r_MSendUpdate.SetBelong(this.GetValue());
				}
				return r_MSendUpdate;
			}
		}

		/// <summary>
		/// Void SendModKeysChanged()
		/// </summary>
		protected RMethod r_MSendModKeysChanged;
		public virtual RMethod RMSendModKeysChanged
		{
			get
			{
				if(r_MSendModKeysChanged == null)
				{
					r_MSendModKeysChanged = new(this, "SendModKeysChanged", 0);
					r_MSendModKeysChanged.SetBelong(this.GetValue());
				}
				return r_MSendModKeysChanged;
			}
		}

		/// <summary>
		/// UnityEngine.RectOffset GetBorderSize()
		/// </summary>
		protected RMethod r_MGetBorderSize;
		public virtual RMethod RMGetBorderSize
		{
			get
			{
				if(r_MGetBorderSize == null)
				{
					r_MGetBorderSize = new(this, "GetBorderSize", 0);
					r_MGetBorderSize.SetBelong(this.GetValue());
				}
				return r_MGetBorderSize;
			}
		}

		/// <summary>
		/// Single GetGenericMenuLeftOffset(Boolean)
		/// </summary>
		protected static RMethod r_MGetGenericMenuLeftOffset_Boolean;
		public static RMethod RMGetGenericMenuLeftOffset_Boolean
		{
			get
			{
				if(r_MGetGenericMenuLeftOffset_Boolean == null)
				{
					r_MGetGenericMenuLeftOffset_Boolean = new( ReflectionUtils.GetType("UnityEditor.HostView"), "GetGenericMenuLeftOffset", 0, typeof(System.Boolean));
					r_MGetGenericMenuLeftOffset_Boolean.SetBelong(null);
				}
				return r_MGetGenericMenuLeftOffset_Boolean;
			}
		}

		/// <summary>
		/// Single GetExtraButtonsWidth()
		/// </summary>
		protected RMethod r_MGetExtraButtonsWidth;
		public virtual RMethod RMGetExtraButtonsWidth
		{
			get
			{
				if(r_MGetExtraButtonsWidth == null)
				{
					r_MGetExtraButtonsWidth = new(this, "GetExtraButtonsWidth", 0);
					r_MGetExtraButtonsWidth.SetBelong(this.GetValue());
				}
				return r_MGetExtraButtonsWidth;
			}
		}

		/// <summary>
		/// Void ShowGenericMenu(Single, Single)
		/// </summary>
		protected RMethod r_MShowGenericMenu_Single_Single;
		public virtual RMethod RMShowGenericMenu_Single_Single
		{
			get
			{
				if(r_MShowGenericMenu_Single_Single == null)
				{
					r_MShowGenericMenu_Single_Single = new(this, "ShowGenericMenu", 0, typeof(System.Single), typeof(System.Single));
					r_MShowGenericMenu_Single_Single.SetBelong(this.GetValue());
				}
				return r_MShowGenericMenu_Single_Single;
			}
		}

		/// <summary>
		/// Void PopulateDataModeDropdown(UnityEditor.DataModeController, UnityEditor.GenericMenu)
		/// </summary>
		protected RMethod r_MPopulateDataModeDropdown_DataModeController_GenericMenu;
		public virtual RMethod RMPopulateDataModeDropdown_DataModeController_GenericMenu
		{
			get
			{
				if(r_MPopulateDataModeDropdown_DataModeController_GenericMenu == null)
				{
					r_MPopulateDataModeDropdown_DataModeController_GenericMenu = new(this, "PopulateDataModeDropdown", 0,  ReflectionUtils.GetType("UnityEditor.DataModeController"), typeof(UnityEditor.GenericMenu));
					r_MPopulateDataModeDropdown_DataModeController_GenericMenu.SetBelong(this.GetValue());
				}
				return r_MPopulateDataModeDropdown_DataModeController_GenericMenu;
			}
		}

		/// <summary>
		/// UnityEditor.WindowAction[] FetchWindowActionFromAttribute()
		/// </summary>
		protected static RMethod r_MFetchWindowActionFromAttribute;
		public static RMethod RMFetchWindowActionFromAttribute
		{
			get
			{
				if(r_MFetchWindowActionFromAttribute == null)
				{
					r_MFetchWindowActionFromAttribute = new( ReflectionUtils.GetType("UnityEditor.HostView"), "FetchWindowActionFromAttribute", 0);
					r_MFetchWindowActionFromAttribute.SetBelong(null);
				}
				return r_MFetchWindowActionFromAttribute;
			}
		}

		/// <summary>
		/// Void FlushView(UnityEditor.EditorWindow)
		/// </summary>
		protected static RMethod r_MFlushView_EditorWindow;
		public static RMethod RMFlushView_EditorWindow
		{
			get
			{
				if(r_MFlushView_EditorWindow == null)
				{
					r_MFlushView_EditorWindow = new( ReflectionUtils.GetType("UnityEditor.HostView"), "FlushView", 0, typeof(UnityEditor.EditorWindow));
					r_MFlushView_EditorWindow.SetBelong(null);
				}
				return r_MFlushView_EditorWindow;
			}
		}

		/// <summary>
		/// Void PopupGenericMenu(UnityEditor.EditorWindow, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MPopupGenericMenu_EditorWindow_Rect;
		public virtual RMethod RMPopupGenericMenu_EditorWindow_Rect
		{
			get
			{
				if(r_MPopupGenericMenu_EditorWindow_Rect == null)
				{
					r_MPopupGenericMenu_EditorWindow_Rect = new(this, "PopupGenericMenu", 0, typeof(UnityEditor.EditorWindow), typeof(UnityEngine.Rect));
					r_MPopupGenericMenu_EditorWindow_Rect.SetBelong(this.GetValue());
				}
				return r_MPopupGenericMenu_EditorWindow_Rect;
			}
		}

		/// <summary>
		/// Void AddWindowActionMenu(UnityEditor.GenericMenu, UnityEditor.EditorWindow)
		/// </summary>
		protected static RMethod r_MAddWindowActionMenu_GenericMenu_EditorWindow;
		public static RMethod RMAddWindowActionMenu_GenericMenu_EditorWindow
		{
			get
			{
				if(r_MAddWindowActionMenu_GenericMenu_EditorWindow == null)
				{
					r_MAddWindowActionMenu_GenericMenu_EditorWindow = new( ReflectionUtils.GetType("UnityEditor.HostView"), "AddWindowActionMenu", 0, typeof(UnityEditor.GenericMenu), typeof(UnityEditor.EditorWindow));
					r_MAddWindowActionMenu_GenericMenu_EditorWindow.SetBelong(null);
				}
				return r_MAddWindowActionMenu_GenericMenu_EditorWindow;
			}
		}

		/// <summary>
		/// Void Inspect(System.Object)
		/// </summary>
		protected RMethod r_MInspect_Object;
		public virtual RMethod RMInspect_Object
		{
			get
			{
				if(r_MInspect_Object == null)
				{
					r_MInspect_Object = new(this, "Inspect", 0, typeof(System.Object));
					r_MInspect_Object.SetBelong(this.GetValue());
				}
				return r_MInspect_Object;
			}
		}

		/// <summary>
		/// Void Reload(System.Object)
		/// </summary>
		protected RMethod r_MReload_Object;
		public virtual RMethod RMReload_Object
		{
			get
			{
				if(r_MReload_Object == null)
				{
					r_MReload_Object = new(this, "Reload", 0, typeof(System.Object));
					r_MReload_Object.SetBelong(this.GetValue());
				}
				return r_MReload_Object;
			}
		}

		/// <summary>
		/// Void AddDefaultItemsToMenu(UnityEditor.GenericMenu, UnityEditor.EditorWindow)
		/// </summary>
		protected RMethod r_MAddDefaultItemsToMenu_GenericMenu_EditorWindow;
		public virtual RMethod RMAddDefaultItemsToMenu_GenericMenu_EditorWindow
		{
			get
			{
				if(r_MAddDefaultItemsToMenu_GenericMenu_EditorWindow == null)
				{
					r_MAddDefaultItemsToMenu_GenericMenu_EditorWindow = new(this, "AddDefaultItemsToMenu", 0, typeof(UnityEditor.GenericMenu), typeof(UnityEditor.EditorWindow));
					r_MAddDefaultItemsToMenu_GenericMenu_EditorWindow.SetBelong(this.GetValue());
				}
				return r_MAddDefaultItemsToMenu_GenericMenu_EditorWindow;
			}
		}

		/// <summary>
		/// Void PlayModeTintColorChangedCallback(System.String)
		/// </summary>
		protected RMethod r_MPlayModeTintColorChangedCallback_String;
		public virtual RMethod RMPlayModeTintColorChangedCallback_String
		{
			get
			{
				if(r_MPlayModeTintColorChangedCallback_String == null)
				{
					r_MPlayModeTintColorChangedCallback_String = new(this, "PlayModeTintColorChangedCallback", 0, typeof(System.String));
					r_MPlayModeTintColorChangedCallback_String.SetBelong(this.GetValue());
				}
				return r_MPlayModeTintColorChangedCallback_String;
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
					r_MRepaint.SetBelong(this.GetValue());
				}
				return r_MRepaint;
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
					r_MFocus.SetBelong(this.GetValue());
				}
				return r_MFocus;
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
					r_MRepaintImmediately.SetBelong(this.GetValue());
				}
				return r_MRepaintImmediately;
			}
		}

		/// <summary>
		/// Void CaptureRenderDocScene()
		/// </summary>
		protected RMethod r_MCaptureRenderDocScene;
		public virtual RMethod RMCaptureRenderDocScene
		{
			get
			{
				if(r_MCaptureRenderDocScene == null)
				{
					r_MCaptureRenderDocScene = new(this, "CaptureRenderDocScene", 0);
					r_MCaptureRenderDocScene.SetBelong(this.GetValue());
				}
				return r_MCaptureRenderDocScene;
			}
		}

		/// <summary>
		/// Void CaptureRenderDocFullContent()
		/// </summary>
		protected RMethod r_MCaptureRenderDocFullContent;
		public virtual RMethod RMCaptureRenderDocFullContent
		{
			get
			{
				if(r_MCaptureRenderDocFullContent == null)
				{
					r_MCaptureRenderDocFullContent = new(this, "CaptureRenderDocFullContent", 0);
					r_MCaptureRenderDocFullContent.SetBelong(this.GetValue());
				}
				return r_MCaptureRenderDocFullContent;
			}
		}

		/// <summary>
		/// Void BeginCaptureRenderDoc()
		/// </summary>
		protected RMethod r_MBeginCaptureRenderDoc;
		public virtual RMethod RMBeginCaptureRenderDoc
		{
			get
			{
				if(r_MBeginCaptureRenderDoc == null)
				{
					r_MBeginCaptureRenderDoc = new(this, "BeginCaptureRenderDoc", 0);
					r_MBeginCaptureRenderDoc.SetBelong(this.GetValue());
				}
				return r_MBeginCaptureRenderDoc;
			}
		}

		/// <summary>
		/// Void EndCaptureRenderDoc()
		/// </summary>
		protected RMethod r_MEndCaptureRenderDoc;
		public virtual RMethod RMEndCaptureRenderDoc
		{
			get
			{
				if(r_MEndCaptureRenderDoc == null)
				{
					r_MEndCaptureRenderDoc = new(this, "EndCaptureRenderDoc", 0);
					r_MEndCaptureRenderDoc.SetBelong(this.GetValue());
				}
				return r_MEndCaptureRenderDoc;
			}
		}

		/// <summary>
		/// Void RenderCurrentSceneForCapture()
		/// </summary>
		protected RMethod r_MRenderCurrentSceneForCapture;
		public virtual RMethod RMRenderCurrentSceneForCapture
		{
			get
			{
				if(r_MRenderCurrentSceneForCapture == null)
				{
					r_MRenderCurrentSceneForCapture = new(this, "RenderCurrentSceneForCapture", 0);
					r_MRenderCurrentSceneForCapture.SetBelong(this.GetValue());
				}
				return r_MRenderCurrentSceneForCapture;
			}
		}

		/// <summary>
		/// Void SetTitle(System.String)
		/// </summary>
		protected RMethod r_MSetTitle_String;
		public virtual RMethod RMSetTitle_String
		{
			get
			{
				if(r_MSetTitle_String == null)
				{
					r_MSetTitle_String = new(this, "SetTitle", 0, typeof(System.String));
					r_MSetTitle_String.SetBelong(this.GetValue());
				}
				return r_MSetTitle_String;
			}
		}

		/// <summary>
		/// Void AddToAuxWindowList()
		/// </summary>
		protected RMethod r_MAddToAuxWindowList;
		public virtual RMethod RMAddToAuxWindowList
		{
			get
			{
				if(r_MAddToAuxWindowList == null)
				{
					r_MAddToAuxWindowList = new(this, "AddToAuxWindowList", 0);
					r_MAddToAuxWindowList.SetBelong(this.GetValue());
				}
				return r_MAddToAuxWindowList;
			}
		}

		/// <summary>
		/// Void SetInternalGameViewDimensions(UnityEngine.Rect, UnityEngine.Rect, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetInternalGameViewDimensions_Rect_Rect_Vector2;
		public virtual RMethod RMSetInternalGameViewDimensions_Rect_Rect_Vector2
		{
			get
			{
				if(r_MSetInternalGameViewDimensions_Rect_Rect_Vector2 == null)
				{
					r_MSetInternalGameViewDimensions_Rect_Rect_Vector2 = new(this, "SetInternalGameViewDimensions", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2));
					r_MSetInternalGameViewDimensions_Rect_Rect_Vector2.SetBelong(this.GetValue());
				}
				return r_MSetInternalGameViewDimensions_Rect_Rect_Vector2;
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
					r_MSetMainPlayModeViewSize_Vector2.SetBelong(this.GetValue());
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
					r_MSetDisplayViewSize_Int32_Vector2.SetBelong(this.GetValue());
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
					r_MGetDisplayViewSize_Int32.SetBelong(this.GetValue());
				}
				return r_MGetDisplayViewSize_Int32;
			}
		}

		/// <summary>
		/// Void SetAsStartView()
		/// </summary>
		protected RMethod r_MSetAsStartView;
		public virtual RMethod RMSetAsStartView
		{
			get
			{
				if(r_MSetAsStartView == null)
				{
					r_MSetAsStartView = new(this, "SetAsStartView", 0);
					r_MSetAsStartView.SetBelong(this.GetValue());
				}
				return r_MSetAsStartView;
			}
		}

		/// <summary>
		/// Void SetAsLastPlayModeView()
		/// </summary>
		protected RMethod r_MSetAsLastPlayModeView;
		public virtual RMethod RMSetAsLastPlayModeView
		{
			get
			{
				if(r_MSetAsLastPlayModeView == null)
				{
					r_MSetAsLastPlayModeView = new(this, "SetAsLastPlayModeView", 0);
					r_MSetAsLastPlayModeView.SetBelong(this.GetValue());
				}
				return r_MSetAsLastPlayModeView;
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
					r_MSetPlayModeView_Boolean.SetBelong(this.GetValue());
				}
				return r_MSetPlayModeView_Boolean;
			}
		}

		/// <summary>
		/// Void ClearStartView()
		/// </summary>
		protected RMethod r_MClearStartView;
		public virtual RMethod RMClearStartView
		{
			get
			{
				if(r_MClearStartView == null)
				{
					r_MClearStartView = new(this, "ClearStartView", 0);
					r_MClearStartView.SetBelong(this.GetValue());
				}
				return r_MClearStartView;
			}
		}

		/// <summary>
		/// Void MakeVistaDWMHappyDance()
		/// </summary>
		protected RMethod r_MMakeVistaDWMHappyDance;
		public virtual RMethod RMMakeVistaDWMHappyDance
		{
			get
			{
				if(r_MMakeVistaDWMHappyDance == null)
				{
					r_MMakeVistaDWMHappyDance = new(this, "MakeVistaDWMHappyDance", 0);
					r_MMakeVistaDWMHappyDance.SetBelong(this.GetValue());
				}
				return r_MMakeVistaDWMHappyDance;
			}
		}

		/// <summary>
		/// Void SetEyeDropperOpen(Boolean)
		/// </summary>
		protected RMethod r_MSetEyeDropperOpen_Boolean;
		public virtual RMethod RMSetEyeDropperOpen_Boolean
		{
			get
			{
				if(r_MSetEyeDropperOpen_Boolean == null)
				{
					r_MSetEyeDropperOpen_Boolean = new(this, "SetEyeDropperOpen", 0, typeof(System.Boolean));
					r_MSetEyeDropperOpen_Boolean.SetBelong(this.GetValue());
				}
				return r_MSetEyeDropperOpen_Boolean;
			}
		}

		/// <summary>
		/// Void StealMouseCapture()
		/// </summary>
		protected RMethod r_MStealMouseCapture;
		public virtual RMethod RMStealMouseCapture
		{
			get
			{
				if(r_MStealMouseCapture == null)
				{
					r_MStealMouseCapture = new(this, "StealMouseCapture", 0);
					r_MStealMouseCapture.SetBelong(this.GetValue());
				}
				return r_MStealMouseCapture;
			}
		}

		/// <summary>
		/// Void ClearKeyboardControl()
		/// </summary>
		protected RMethod r_MClearKeyboardControl;
		public virtual RMethod RMClearKeyboardControl
		{
			get
			{
				if(r_MClearKeyboardControl == null)
				{
					r_MClearKeyboardControl = new(this, "ClearKeyboardControl", 0);
					r_MClearKeyboardControl.SetBelong(this.GetValue());
				}
				return r_MClearKeyboardControl;
			}
		}

		/// <summary>
		/// Void SetKeyboardControl(Int32)
		/// </summary>
		protected RMethod r_MSetKeyboardControl_Int32;
		public virtual RMethod RMSetKeyboardControl_Int32
		{
			get
			{
				if(r_MSetKeyboardControl_Int32 == null)
				{
					r_MSetKeyboardControl_Int32 = new(this, "SetKeyboardControl", 0, typeof(System.Int32));
					r_MSetKeyboardControl_Int32.SetBelong(this.GetValue());
				}
				return r_MSetKeyboardControl_Int32;
			}
		}

		/// <summary>
		/// Int32 GetKeyboardControl()
		/// </summary>
		protected RMethod r_MGetKeyboardControl;
		public virtual RMethod RMGetKeyboardControl
		{
			get
			{
				if(r_MGetKeyboardControl == null)
				{
					r_MGetKeyboardControl = new(this, "GetKeyboardControl", 0);
					r_MGetKeyboardControl.SetBelong(this.GetValue());
				}
				return r_MGetKeyboardControl;
			}
		}

		/// <summary>
		/// Void GrabPixels(UnityEngine.RenderTexture, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MGrabPixels_RenderTexture_Rect;
		public virtual RMethod RMGrabPixels_RenderTexture_Rect
		{
			get
			{
				if(r_MGrabPixels_RenderTexture_Rect == null)
				{
					r_MGrabPixels_RenderTexture_Rect = new(this, "GrabPixels", 0, typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Rect));
					r_MGrabPixels_RenderTexture_Rect.SetBelong(this.GetValue());
				}
				return r_MGrabPixels_RenderTexture_Rect;
			}
		}

		/// <summary>
		/// Void MarkHotRegion(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MMarkHotRegion_Rect;
		public virtual RMethod RMMarkHotRegion_Rect
		{
			get
			{
				if(r_MMarkHotRegion_Rect == null)
				{
					r_MMarkHotRegion_Rect = new(this, "MarkHotRegion", 0, typeof(UnityEngine.Rect));
					r_MMarkHotRegion_Rect.SetBelong(this.GetValue());
				}
				return r_MMarkHotRegion_Rect;
			}
		}

		/// <summary>
		/// Void EnableVSync(Boolean)
		/// </summary>
		protected RMethod r_MEnableVSync_Boolean;
		public virtual RMethod RMEnableVSync_Boolean
		{
			get
			{
				if(r_MEnableVSync_Boolean == null)
				{
					r_MEnableVSync_Boolean = new(this, "EnableVSync", 0, typeof(System.Boolean));
					r_MEnableVSync_Boolean.SetBelong(this.GetValue());
				}
				return r_MEnableVSync_Boolean;
			}
		}

		/// <summary>
		/// Void SetActualViewName(System.String)
		/// </summary>
		protected RMethod r_MSetActualViewName_String;
		public virtual RMethod RMSetActualViewName_String
		{
			get
			{
				if(r_MSetActualViewName_String == null)
				{
					r_MSetActualViewName_String = new(this, "SetActualViewName", 0, typeof(System.String));
					r_MSetActualViewName_String.SetBelong(this.GetValue());
				}
				return r_MSetActualViewName_String;
			}
		}

		/// <summary>
		/// Void Internal_SetAsActiveWindow()
		/// </summary>
		protected RMethod r_MInternal_SetAsActiveWindow;
		public virtual RMethod RMInternal_SetAsActiveWindow
		{
			get
			{
				if(r_MInternal_SetAsActiveWindow == null)
				{
					r_MInternal_SetAsActiveWindow = new(this, "Internal_SetAsActiveWindow", 0);
					r_MInternal_SetAsActiveWindow.SetBelong(this.GetValue());
				}
				return r_MInternal_SetAsActiveWindow;
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
					r_MSendEvent_Event.SetBelong(this.GetValue());
				}
				return r_MSendEvent_Event;
			}
		}

		/// <summary>
		/// Void RecreateContext()
		/// </summary>
		protected RMethod r_MRecreateContext;
		public virtual RMethod RMRecreateContext
		{
			get
			{
				if(r_MRecreateContext == null)
				{
					r_MRecreateContext = new(this, "RecreateContext", 0);
					r_MRecreateContext.SetBelong(this.GetValue());
				}
				return r_MRecreateContext;
			}
		}

		/// <summary>
		/// Void ValidateWindowBackendForCurrentView()
		/// </summary>
		protected RMethod r_MValidateWindowBackendForCurrentView;
		public virtual RMethod RMValidateWindowBackendForCurrentView
		{
			get
			{
				if(r_MValidateWindowBackendForCurrentView == null)
				{
					r_MValidateWindowBackendForCurrentView = new(this, "ValidateWindowBackendForCurrentView", 0);
					r_MValidateWindowBackendForCurrentView.SetBelong(this.GetValue());
				}
				return r_MValidateWindowBackendForCurrentView;
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
					r_MOnGUI.SetBelong(this.GetValue());
				}
				return r_MOnGUI;
			}
		}

		/// <summary>
		/// Void DoWindowDecorationStart()
		/// </summary>
		protected RMethod r_MDoWindowDecorationStart;
		public virtual RMethod RMDoWindowDecorationStart
		{
			get
			{
				if(r_MDoWindowDecorationStart == null)
				{
					r_MDoWindowDecorationStart = new(this, "DoWindowDecorationStart", 0);
					r_MDoWindowDecorationStart.SetBelong(this.GetValue());
				}
				return r_MDoWindowDecorationStart;
			}
		}

		/// <summary>
		/// Void DoWindowDecorationEnd()
		/// </summary>
		protected RMethod r_MDoWindowDecorationEnd;
		public virtual RMethod RMDoWindowDecorationEnd
		{
			get
			{
				if(r_MDoWindowDecorationEnd == null)
				{
					r_MDoWindowDecorationEnd = new(this, "DoWindowDecorationEnd", 0);
					r_MDoWindowDecorationEnd.SetBelong(this.GetValue());
				}
				return r_MDoWindowDecorationEnd;
			}
		}

		/// <summary>
		/// System.String GetViewName()
		/// </summary>
		protected RMethod r_MGetViewName;
		public virtual RMethod RMGetViewName
		{
			get
			{
				if(r_MGetViewName == null)
				{
					r_MGetViewName = new(this, "GetViewName", 0);
					r_MGetViewName.SetBelong(this.GetValue());
				}
				return r_MGetViewName;
			}
		}

		/// <summary>
		/// Void CaptureMetalScene()
		/// </summary>
		protected RMethod r_MCaptureMetalScene;
		public virtual RMethod RMCaptureMetalScene
		{
			get
			{
				if(r_MCaptureMetalScene == null)
				{
					r_MCaptureMetalScene = new(this, "CaptureMetalScene", 0);
					r_MCaptureMetalScene.SetBelong(this.GetValue());
				}
				return r_MCaptureMetalScene;
			}
		}

		/// <summary>
		/// Void Reflow()
		/// </summary>
		protected RMethod r_MReflow;
		public virtual RMethod RMReflow
		{
			get
			{
				if(r_MReflow == null)
				{
					r_MReflow = new(this, "Reflow", 0);
					r_MReflow.SetBelong(this.GetValue());
				}
				return r_MReflow;
			}
		}

		/// <summary>
		/// System.String DebugHierarchy(Int32)
		/// </summary>
		protected RMethod r_MDebugHierarchy_Int32;
		public virtual RMethod RMDebugHierarchy_Int32
		{
			get
			{
				if(r_MDebugHierarchy_Int32 == null)
				{
					r_MDebugHierarchy_Int32 = new(this, "DebugHierarchy", 0, typeof(System.Int32));
					r_MDebugHierarchy_Int32.SetBelong(this.GetValue());
				}
				return r_MDebugHierarchy_Int32;
			}
		}

		/// <summary>
		/// Void Initialize(UnityEditor.ContainerWindow)
		/// </summary>
		protected RMethod r_MInitialize_ContainerWindow;
		public virtual RMethod RMInitialize_ContainerWindow
		{
			get
			{
				if(r_MInitialize_ContainerWindow == null)
				{
					r_MInitialize_ContainerWindow = new(this, "Initialize", 0,  ReflectionUtils.GetType("UnityEditor.ContainerWindow"));
					r_MInitialize_ContainerWindow.SetBelong(this.GetValue());
				}
				return r_MInitialize_ContainerWindow;
			}
		}

		/// <summary>
		/// Void SetMinMaxSizes(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetMinMaxSizes_Vector2_Vector2;
		public virtual RMethod RMSetMinMaxSizes_Vector2_Vector2
		{
			get
			{
				if(r_MSetMinMaxSizes_Vector2_Vector2 == null)
				{
					r_MSetMinMaxSizes_Vector2_Vector2 = new(this, "SetMinMaxSizes", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_MSetMinMaxSizes_Vector2_Vector2.SetBelong(this.GetValue());
				}
				return r_MSetMinMaxSizes_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Void ChildrenMinMaxChanged()
		/// </summary>
		protected RMethod r_MChildrenMinMaxChanged;
		public virtual RMethod RMChildrenMinMaxChanged
		{
			get
			{
				if(r_MChildrenMinMaxChanged == null)
				{
					r_MChildrenMinMaxChanged = new(this, "ChildrenMinMaxChanged", 0);
					r_MChildrenMinMaxChanged.SetBelong(this.GetValue());
				}
				return r_MChildrenMinMaxChanged;
			}
		}

		/// <summary>
		/// Void SetPositionOnly(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MSetPositionOnly_Rect;
		public virtual RMethod RMSetPositionOnly_Rect
		{
			get
			{
				if(r_MSetPositionOnly_Rect == null)
				{
					r_MSetPositionOnly_Rect = new(this, "SetPositionOnly", 0, typeof(UnityEngine.Rect));
					r_MSetPositionOnly_Rect.SetBelong(this.GetValue());
				}
				return r_MSetPositionOnly_Rect;
			}
		}

		/// <summary>
		/// Int32 IndexOfChild(UnityEditor.View)
		/// </summary>
		protected RMethod r_MIndexOfChild_View;
		public virtual RMethod RMIndexOfChild_View
		{
			get
			{
				if(r_MIndexOfChild_View == null)
				{
					r_MIndexOfChild_View = new(this, "IndexOfChild", 0,  ReflectionUtils.GetType("UnityEditor.View"));
					r_MIndexOfChild_View.SetBelong(this.GetValue());
				}
				return r_MIndexOfChild_View;
			}
		}

		/// <summary>
		/// Void AddChild(UnityEditor.View)
		/// </summary>
		protected RMethod r_MAddChild_View;
		public virtual RMethod RMAddChild_View
		{
			get
			{
				if(r_MAddChild_View == null)
				{
					r_MAddChild_View = new(this, "AddChild", 0,  ReflectionUtils.GetType("UnityEditor.View"));
					r_MAddChild_View.SetBelong(this.GetValue());
				}
				return r_MAddChild_View;
			}
		}

		/// <summary>
		/// Void AddChild(UnityEditor.View, Int32)
		/// </summary>
		protected RMethod r_MAddChild_View_Int32;
		public virtual RMethod RMAddChild_View_Int32
		{
			get
			{
				if(r_MAddChild_View_Int32 == null)
				{
					r_MAddChild_View_Int32 = new(this, "AddChild", 0,  ReflectionUtils.GetType("UnityEditor.View"), typeof(System.Int32));
					r_MAddChild_View_Int32.SetBelong(this.GetValue());
				}
				return r_MAddChild_View_Int32;
			}
		}

		/// <summary>
		/// Void RemoveChild(UnityEditor.View)
		/// </summary>
		protected RMethod r_MRemoveChild_View;
		public virtual RMethod RMRemoveChild_View
		{
			get
			{
				if(r_MRemoveChild_View == null)
				{
					r_MRemoveChild_View = new(this, "RemoveChild", 0,  ReflectionUtils.GetType("UnityEditor.View"));
					r_MRemoveChild_View.SetBelong(this.GetValue());
				}
				return r_MRemoveChild_View;
			}
		}

		/// <summary>
		/// Void RemoveChild(Int32)
		/// </summary>
		protected RMethod r_MRemoveChild_Int32;
		public virtual RMethod RMRemoveChild_Int32
		{
			get
			{
				if(r_MRemoveChild_Int32 == null)
				{
					r_MRemoveChild_Int32 = new(this, "RemoveChild", 0, typeof(System.Int32));
					r_MRemoveChild_Int32.SetBelong(this.GetValue());
				}
				return r_MRemoveChild_Int32;
			}
		}

		/// <summary>
		/// Void SetWindowRecurse(UnityEditor.ContainerWindow)
		/// </summary>
		protected RMethod r_MSetWindowRecurse_ContainerWindow;
		public virtual RMethod RMSetWindowRecurse_ContainerWindow
		{
			get
			{
				if(r_MSetWindowRecurse_ContainerWindow == null)
				{
					r_MSetWindowRecurse_ContainerWindow = new(this, "SetWindowRecurse", 0,  ReflectionUtils.GetType("UnityEditor.ContainerWindow"));
					r_MSetWindowRecurse_ContainerWindow.SetBelong(this.GetValue());
				}
				return r_MSetWindowRecurse_ContainerWindow;
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
					r_MSetDirty.SetBelong(this.GetValue());
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
					r_MGetInstanceID.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
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

        public virtual void SetActualViewInternal(UnityEditor.EditorWindow @value, System.Boolean @sendEvents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @sendEvents};
            var ___result = RMSetActualViewInternal_EditorWindow_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CreateDelegates()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateDelegates.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearDelegates()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearDelegates.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetActiveView()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetActiveView.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateMargins(UnityEditor.EditorWindow @window)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@window};
            var ___result = RMUpdateMargins_EditorWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateViewMargins(UnityEditor.EditorWindow @view)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@view};
            var ___result = RMUpdateViewMargins_EditorWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPosition(UnityEngine.Rect @newPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newPos};
            var ___result = RMSetPosition_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetActualViewPosition(UnityEngine.Rect @newPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newPos};
            var ___result = RMSetActualViewPosition_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetWindow(Hvak.Editor.Refleaction.RUnityEditor.RContainerWindow @win)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@win.Value};
            var ___result = RMSetWindow_ContainerWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnEnable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnEnable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDisable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnDisable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnEditorModeChanged(Hvak.Editor.Refleaction.RUnityEditor.RModeService.RModeChangedArgs @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args.Value};
            var ___result = RMOnEditorModeChanged_ModeChangedArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleSplitView()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHandleSplitView.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OldOnGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOldOnGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean OnFocus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnFocus.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnLostFocus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnLostFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBackingScaleFactorChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnBackingScaleFactorChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDestroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnDestroy.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Collections.Generic.IEnumerable<System.Type> GetCurrentModePaneTypes(System.String @modePaneTypeSectionName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@modePaneTypeSectionName};
            var ___result = RMGetCurrentModePaneTypes_String.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<System.Type>)___result;
        }


        public static System.Collections.Generic.IEnumerable<System.Type> GetDefaultPaneTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDefaultPaneTypes.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<System.Type>)___result;
        }


        public virtual System.Collections.Generic.IEnumerable<System.Type> GetPaneTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPaneTypes.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<System.Type>)___result;
        }


        public virtual void OnProjectChange()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnProjectChange.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnSelectionChange()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnSelectionChange.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDidOpenScene()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnDidOpenScene.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnInspectorUpdate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnInspectorUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnHierarchyChange()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnHierarchyChange.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate CreateDelegate(System.String @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RMCreateDelegate_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RHostView.REditorWindowDelegate(___result);
        }


        public virtual System.Reflection.MethodInfo GetPaneMethod(System.String @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RMGetPaneMethod_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetPaneMethod(System.String @methodName, System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @obj};
            var ___result = RMGetPaneMethod_String_Object.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.String GetActualViewName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetActualViewName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void InvokeOnGUI(UnityEngine.Rect @onGUIPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@onGUIPosition};
            var ___result = RMInvokeOnGUI_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Invoke(System.String @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RMInvoke_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Invoke(System.String @methodName, System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @obj};
            var ___result = RMInvoke_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterSelectedPane(System.Boolean @sendEvents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sendEvents};
            var ___result = RMRegisterSelectedPane_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DeregisterSelectedPane(System.Boolean @clearActualView, System.Boolean @sendEvents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clearActualView, @sendEvents};
            var ___result = RMDeregisterSelectedPane_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckNotificationStatus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCheckNotificationStatus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendUpdate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSendUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendModKeysChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSendModKeysChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.RectOffset GetBorderSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetBorderSize.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RectOffset)___result;
        }


        public static System.Single GetGenericMenuLeftOffset(System.Boolean @addFloatingWindowButtonsTopRight)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@addFloatingWindowButtonsTopRight};
            var ___result = RMGetGenericMenuLeftOffset_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single GetExtraButtonsWidth()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetExtraButtonsWidth.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void ShowGenericMenu(System.Single @leftOffset, System.Single @topOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@leftOffset, @topOffset};
            var ___result = RMShowGenericMenu_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PopulateDataModeDropdown(Hvak.Editor.Refleaction.RUnityEditor.RDataModeController @clientDataModeController, UnityEditor.GenericMenu @menu)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clientDataModeController.Value, @menu};
            var ___result = RMPopulateDataModeDropdown_DataModeController_GenericMenu.Invoke(___genericsType, ___parameters);

            
        }


        public static Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.RWindowAction> FetchWindowActionFromAttribute()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFetchWindowActionFromAttribute.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.RWindowAction>(___result);
        }


        public static void FlushView(UnityEditor.EditorWindow @view)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@view};
            var ___result = RMFlushView_EditorWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PopupGenericMenu(UnityEditor.EditorWindow @view, UnityEngine.Rect @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@view, @pos};
            var ___result = RMPopupGenericMenu_EditorWindow_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public static void AddWindowActionMenu(UnityEditor.GenericMenu @menu, UnityEditor.EditorWindow @view)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@menu, @view};
            var ___result = RMAddWindowActionMenu_GenericMenu_EditorWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Inspect(System.Object @userData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@userData};
            var ___result = RMInspect_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reload(System.Object @userData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@userData};
            var ___result = RMReload_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddDefaultItemsToMenu(UnityEditor.GenericMenu @menu, UnityEditor.EditorWindow @window)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@menu, @window};
            var ___result = RMAddDefaultItemsToMenu_GenericMenu_EditorWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlayModeTintColorChangedCallback(System.String @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMPlayModeTintColorChangedCallback_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Repaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Focus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RepaintImmediately()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRepaintImmediately.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CaptureRenderDocScene()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCaptureRenderDocScene.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CaptureRenderDocFullContent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCaptureRenderDocFullContent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginCaptureRenderDoc()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBeginCaptureRenderDoc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndCaptureRenderDoc()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEndCaptureRenderDoc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RenderCurrentSceneForCapture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRenderCurrentSceneForCapture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTitle(System.String @title)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@title};
            var ___result = RMSetTitle_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddToAuxWindowList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAddToAuxWindowList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInternalGameViewDimensions(UnityEngine.Rect @rect, UnityEngine.Rect @clippedRect, UnityEngine.Vector2 @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @clippedRect, @targetSize};
            var ___result = RMSetInternalGameViewDimensions_Rect_Rect_Vector2.Invoke(___genericsType, ___parameters);

            
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


        public virtual void SetAsStartView()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetAsStartView.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAsLastPlayModeView()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetAsLastPlayModeView.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPlayModeView(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetPlayModeView_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearStartView()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearStartView.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MakeVistaDWMHappyDance()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMakeVistaDWMHappyDance.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetEyeDropperOpen(System.Boolean @isOpen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isOpen};
            var ___result = RMSetEyeDropperOpen_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StealMouseCapture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMStealMouseCapture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearKeyboardControl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearKeyboardControl.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetKeyboardControl(System.Int32 @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RMSetKeyboardControl_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetKeyboardControl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetKeyboardControl.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void GrabPixels(UnityEngine.RenderTexture @rd, UnityEngine.Rect @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rd, @rect};
            var ___result = RMGrabPixels_RenderTexture_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkHotRegion(UnityEngine.Rect @hotRegionRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hotRegionRect};
            var ___result = RMMarkHotRegion_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableVSync(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMEnableVSync_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetActualViewName(System.String @viewName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@viewName};
            var ___result = RMSetActualViewName_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetAsActiveWindow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternal_SetAsActiveWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SendEvent(UnityEngine.Event @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMSendEvent_Event.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RecreateContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRecreateContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ValidateWindowBackendForCurrentView()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMValidateWindowBackendForCurrentView.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoWindowDecorationStart()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDoWindowDecorationStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoWindowDecorationEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDoWindowDecorationEnd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetViewName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetViewName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void CaptureMetalScene()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCaptureMetalScene.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reflow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReflow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String DebugHierarchy(System.Int32 @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = RMDebugHierarchy_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Initialize(Hvak.Editor.Refleaction.RUnityEditor.RContainerWindow @win)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@win.Value};
            var ___result = RMInitialize_ContainerWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMinMaxSizes(UnityEngine.Vector2 @min, UnityEngine.Vector2 @max)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@min, @max};
            var ___result = RMSetMinMaxSizes_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ChildrenMinMaxChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMChildrenMinMaxChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPositionOnly(UnityEngine.Rect @newPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newPos};
            var ___result = RMSetPositionOnly_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 IndexOfChild(Hvak.Editor.Refleaction.RUnityEditor.RView @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child.Value};
            var ___result = RMIndexOfChild_View.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void AddChild(Hvak.Editor.Refleaction.RUnityEditor.RView @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child.Value};
            var ___result = RMAddChild_View.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddChild(Hvak.Editor.Refleaction.RUnityEditor.RView @child, System.Int32 @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child.Value, @idx};
            var ___result = RMAddChild_View_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveChild(Hvak.Editor.Refleaction.RUnityEditor.RView @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child.Value};
            var ___result = RMRemoveChild_View.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveChild(System.Int32 @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = RMRemoveChild_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetWindowRecurse(Hvak.Editor.Refleaction.RUnityEditor.RContainerWindow @win)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@win.Value};
            var ___result = RMSetWindowRecurse_ContainerWindow.Invoke(___genericsType, ___parameters);

            
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
