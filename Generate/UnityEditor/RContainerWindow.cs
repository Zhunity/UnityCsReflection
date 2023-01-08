using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.ContainerWindow
	/// </summary>
    public partial class RContainerWindow : RMember //
    {

		/// <summary>
		/// System.String k_ScriptingPrefix
		/// </summary>
		protected static RField r_k_ScriptingPrefix;
		public static RField Rk_ScriptingPrefix
		{
			get
			{
				if(r_k_ScriptingPrefix == null)
				{
					r_k_ScriptingPrefix = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "k_ScriptingPrefix");
					r_k_ScriptingPrefix.SetBelong(null);
				}
				return r_k_ScriptingPrefix;
			}
		}

		/// <summary>
		/// UnityEditor.MonoReloadableIntPtr m_WindowPtr
		/// </summary>
		protected RUnityEditor.RMonoReloadableIntPtr r_m_WindowPtr;
		public virtual RUnityEditor.RMonoReloadableIntPtr Rm_WindowPtr
		{
			get
			{
				if(r_m_WindowPtr == null)
				{
					r_m_WindowPtr = new(this, "m_WindowPtr");
					r_m_WindowPtr.SetBelong(this.instance);
				}
				return r_m_WindowPtr;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_PixelRect
		/// </summary>
		protected RUnityEngine.RRect r_m_PixelRect;
		public virtual RUnityEngine.RRect Rm_PixelRect
		{
			get
			{
				if(r_m_PixelRect == null)
				{
					r_m_PixelRect = new(this, "m_PixelRect");
					r_m_PixelRect.SetBelong(this.instance);
				}
				return r_m_PixelRect;
			}
		}

		/// <summary>
		/// System.Int32 m_ShowMode
		/// </summary>
		protected RField r_m_ShowMode;
		public virtual RField Rm_ShowMode
		{
			get
			{
				if(r_m_ShowMode == null)
				{
					r_m_ShowMode = new(this, "m_ShowMode");
					r_m_ShowMode.SetBelong(this.instance);
				}
				return r_m_ShowMode;
			}
		}

		/// <summary>
		/// System.String m_Title
		/// </summary>
		protected RField r_m_Title;
		public virtual RField Rm_Title
		{
			get
			{
				if(r_m_Title == null)
				{
					r_m_Title = new(this, "m_Title");
					r_m_Title.SetBelong(this.instance);
				}
				return r_m_Title;
			}
		}

		/// <summary>
		/// UnityEditor.View m_RootView
		/// </summary>
		protected RUnityEditor.RView r_m_RootView;
		public virtual RUnityEditor.RView Rm_RootView
		{
			get
			{
				if(r_m_RootView == null)
				{
					r_m_RootView = new(this, "m_RootView");
					r_m_RootView.SetBelong(this.instance);
				}
				return r_m_RootView;
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
		/// System.Boolean m_Maximized
		/// </summary>
		protected RField r_m_Maximized;
		public virtual RField Rm_Maximized
		{
			get
			{
				if(r_m_Maximized == null)
				{
					r_m_Maximized = new(this, "m_Maximized");
					r_m_Maximized.SetBelong(this.instance);
				}
				return r_m_Maximized;
			}
		}

		/// <summary>
		/// System.Boolean m_DontSaveToLayout
		/// </summary>
		protected RField r_m_DontSaveToLayout;
		public virtual RField Rm_DontSaveToLayout
		{
			get
			{
				if(r_m_DontSaveToLayout == null)
				{
					r_m_DontSaveToLayout = new(this, "m_DontSaveToLayout");
					r_m_DontSaveToLayout.SetBelong(this.instance);
				}
				return r_m_DontSaveToLayout;
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
		/// System.Collections.Generic.List`1[UnityEditor.EditorWindow] m_UnsavedEditorWindows
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEditor.REditorWindow> r_m_UnsavedEditorWindows;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEditor.REditorWindow> Rm_UnsavedEditorWindows
		{
			get
			{
				if(r_m_UnsavedEditorWindows == null)
				{
					r_m_UnsavedEditorWindows = new(this, "m_UnsavedEditorWindows");
					r_m_UnsavedEditorWindows.SetBelong(this.instance);
				}
				return r_m_UnsavedEditorWindows;
			}
		}

		/// <summary>
		/// System.Int32 m_ButtonCount
		/// </summary>
		protected RField r_m_ButtonCount;
		public virtual RField Rm_ButtonCount
		{
			get
			{
				if(r_m_ButtonCount == null)
				{
					r_m_ButtonCount = new(this, "m_ButtonCount");
					r_m_ButtonCount.SetBelong(this.instance);
				}
				return r_m_ButtonCount;
			}
		}

		/// <summary>
		/// System.Single m_TitleBarWidth
		/// </summary>
		protected RField r_m_TitleBarWidth;
		public virtual RField Rm_TitleBarWidth
		{
			get
			{
				if(r_m_TitleBarWidth == null)
				{
					r_m_TitleBarWidth = new(this, "m_TitleBarWidth");
					r_m_TitleBarWidth.SetBelong(this.instance);
				}
				return r_m_TitleBarWidth;
			}
		}

		/// <summary>
		/// System.Single kTitleHeight
		/// </summary>
		protected static RField r_kTitleHeight;
		public static RField RkTitleHeight
		{
			get
			{
				if(r_kTitleHeight == null)
				{
					r_kTitleHeight = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "kTitleHeight");
					r_kTitleHeight.SetBelong(null);
				}
				return r_kTitleHeight;
			}
		}

		/// <summary>
		/// System.Single kButtonWidth
		/// </summary>
		protected static RField r_kButtonWidth;
		public static RField RkButtonWidth
		{
			get
			{
				if(r_kButtonWidth == null)
				{
					r_kButtonWidth = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "kButtonWidth");
					r_kButtonWidth.SetBelong(null);
				}
				return r_kButtonWidth;
			}
		}

		/// <summary>
		/// System.Single kButtonHeight
		/// </summary>
		protected static RField r_kButtonHeight;
		public static RField RkButtonHeight
		{
			get
			{
				if(r_kButtonHeight == null)
				{
					r_kButtonHeight = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "kButtonHeight");
					r_kButtonHeight.SetBelong(null);
				}
				return r_kButtonHeight;
			}
		}

		/// <summary>
		/// System.Boolean s_Modal
		/// </summary>
		protected static RField r_s_Modal;
		public static RField Rs_Modal
		{
			get
			{
				if(r_s_Modal == null)
				{
					r_s_Modal = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "s_Modal");
					r_s_Modal.SetBelong(null);
				}
				return r_s_Modal;
			}
		}

		/// <summary>
		/// UnityEditor.ContainerWindow s_MainWindow
		/// </summary>
		protected static RUnityEditor.RContainerWindow r_s_MainWindow;
		public static RUnityEditor.RContainerWindow Rs_MainWindow
		{
			get
			{
				if(r_s_MainWindow == null)
				{
					r_s_MainWindow = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "s_MainWindow");
					r_s_MainWindow.SetBelong(null);
				}
				return r_s_MainWindow;
			}
		}

		/// <summary>
		/// System.Single kButtonCountOSX
		/// </summary>
		protected static RField r_kButtonCountOSX;
		public static RField RkButtonCountOSX
		{
			get
			{
				if(r_kButtonCountOSX == null)
				{
					r_kButtonCountOSX = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "kButtonCountOSX");
					r_kButtonCountOSX.SetBelong(null);
				}
				return r_kButtonCountOSX;
			}
		}

		/// <summary>
		/// System.Single kButtonCountWin
		/// </summary>
		protected static RField r_kButtonCountWin;
		public static RField RkButtonCountWin
		{
			get
			{
				if(r_kButtonCountWin == null)
				{
					r_kButtonCountWin = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "kButtonCountWin");
					r_kButtonCountWin.SetBelong(null);
				}
				return r_kButtonCountWin;
			}
		}

		/// <summary>
		/// System.String m_WindowID
		/// </summary>
		protected RField r_m_WindowID;
		public virtual RField Rm_WindowID
		{
			get
			{
				if(r_m_WindowID == null)
				{
					r_m_WindowID = new(this, "m_WindowID");
					r_m_WindowID.SetBelong(this.instance);
				}
				return r_m_WindowID;
			}
		}

		/// <summary>
		/// UnityEngine.Color lightSkinColor
		/// </summary>
		protected static RUnityEngine.RColor r_lightSkinColor;
		public static RUnityEngine.RColor RlightSkinColor
		{
			get
			{
				if(r_lightSkinColor == null)
				{
					r_lightSkinColor = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "lightSkinColor");
					r_lightSkinColor.SetBelong(null);
				}
				return r_lightSkinColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color darkSkinColor
		/// </summary>
		protected static RUnityEngine.RColor r_darkSkinColor;
		public static RUnityEngine.RColor RdarkSkinColor
		{
			get
			{
				if(r_darkSkinColor == null)
				{
					r_darkSkinColor = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "darkSkinColor");
					r_darkSkinColor.SetBelong(null);
				}
				return r_darkSkinColor;
			}
		}

		/// <summary>
		/// System.String <displayedTitle>k__BackingField
		/// </summary>
		protected RField r___0__displayedTitle__1__k__BackingField;
		public virtual RField R__0__displayedTitle__1__k__BackingField
		{
			get
			{
				if(r___0__displayedTitle__1__k__BackingField == null)
				{
					r___0__displayedTitle__1__k__BackingField = new(this, "<displayedTitle>k__BackingField");
					r___0__displayedTitle__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__displayedTitle__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.ContainerWindow] s_AllWindows
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RList<RUnityEditor.RContainerWindow> r_s_AllWindows;
		public static RSystem.RCollections.RGeneric.RList<RUnityEditor.RContainerWindow> Rs_AllWindows
		{
			get
			{
				if(r_s_AllWindows == null)
				{
					r_s_AllWindows = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "s_AllWindows");
					r_s_AllWindows.SetBelong(null);
				}
				return r_s_AllWindows;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 s_LastDragMousePos
		/// </summary>
		protected static RUnityEngine.RVector2 r_s_LastDragMousePos;
		public static RUnityEngine.RVector2 Rs_LastDragMousePos
		{
			get
			{
				if(r_s_LastDragMousePos == null)
				{
					r_s_LastDragMousePos = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "s_LastDragMousePos");
					r_s_LastDragMousePos.SetBelong(null);
				}
				return r_s_LastDragMousePos;
			}
		}

		/// <summary>
		/// System.Single startDragDpi
		/// </summary>
		protected RField r_startDragDpi;
		public virtual RField RstartDragDpi
		{
			get
			{
				if(r_startDragDpi == null)
				{
					r_startDragDpi = new(this, "startDragDpi");
					r_startDragDpi.SetBelong(this.instance);
				}
				return r_startDragDpi;
			}
		}

		/// <summary>
		/// System.Boolean m_DraggingNativeTitleBarCaption
		/// </summary>
		protected RField r_m_DraggingNativeTitleBarCaption;
		public virtual RField Rm_DraggingNativeTitleBarCaption
		{
			get
			{
				if(r_m_DraggingNativeTitleBarCaption == null)
				{
					r_m_DraggingNativeTitleBarCaption = new(this, "m_DraggingNativeTitleBarCaption");
					r_m_DraggingNativeTitleBarCaption.SetBelong(this.instance);
				}
				return r_m_DraggingNativeTitleBarCaption;
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
		/// Boolean macEditor
		/// </summary>
		protected static RProperty r_macEditor;
		public static RProperty RmacEditor
		{
			get
			{
				if(r_macEditor == null)
				{
					r_macEditor = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "macEditor", -1);
					r_macEditor.SetBelong(null);
				}
				return r_macEditor;
			}
		}

		/// <summary>
		/// Boolean linuxEditor
		/// </summary>
		protected static RProperty r_linuxEditor;
		public static RProperty RlinuxEditor
		{
			get
			{
				if(r_linuxEditor == null)
				{
					r_linuxEditor = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "linuxEditor", -1);
					r_linuxEditor.SetBelong(null);
				}
				return r_linuxEditor;
			}
		}

		/// <summary>
		/// UnityEditor.ContainerWindow mainWindow
		/// </summary>
		protected static RUnityEditor.RContainerWindow r_mainWindow;
		public static RUnityEditor.RContainerWindow RmainWindow
		{
			get
			{
				if(r_mainWindow == null)
				{
					r_mainWindow = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "mainWindow", -1);
					r_mainWindow.SetBelong(null);
				}
				return r_mainWindow;
			}
		}

		/// <summary>
		/// Single buttonHorizontalSpace
		/// </summary>
		protected static RProperty r_buttonHorizontalSpace;
		public static RProperty RbuttonHorizontalSpace
		{
			get
			{
				if(r_buttonHorizontalSpace == null)
				{
					r_buttonHorizontalSpace = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "buttonHorizontalSpace", -1);
					r_buttonHorizontalSpace.SetBelong(null);
				}
				return r_buttonHorizontalSpace;
			}
		}

		/// <summary>
		/// Single buttonStackWidth
		/// </summary>
		protected static RProperty r_buttonStackWidth;
		public static RProperty RbuttonStackWidth
		{
			get
			{
				if(r_buttonStackWidth == null)
				{
					r_buttonStackWidth = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "buttonStackWidth", -1);
					r_buttonStackWidth.SetBelong(null);
				}
				return r_buttonStackWidth;
			}
		}

		/// <summary>
		/// UnityEditor.ShowMode showMode
		/// </summary>
		protected RProperty r_showMode;
		public virtual RProperty RshowMode
		{
			get
			{
				if(r_showMode == null)
				{
					r_showMode = new(this, "showMode", -1);
					r_showMode.SetBelong(this.instance);
				}
				return r_showMode;
			}
		}

		/// <summary>
		/// System.String windowID
		/// </summary>
		protected RProperty r_windowID;
		public virtual RProperty RwindowID
		{
			get
			{
				if(r_windowID == null)
				{
					r_windowID = new(this, "windowID", -1);
					r_windowID.SetBelong(this.instance);
				}
				return r_windowID;
			}
		}

		/// <summary>
		/// Boolean isPopup
		/// </summary>
		protected RProperty r_isPopup;
		public virtual RProperty RisPopup
		{
			get
			{
				if(r_isPopup == null)
				{
					r_isPopup = new(this, "isPopup", -1);
					r_isPopup.SetBelong(this.instance);
				}
				return r_isPopup;
			}
		}

		/// <summary>
		/// UnityEngine.Color skinBackgroundColor
		/// </summary>
		protected static RUnityEngine.RColor r_skinBackgroundColor;
		public static RUnityEngine.RColor RskinBackgroundColor
		{
			get
			{
				if(r_skinBackgroundColor == null)
				{
					r_skinBackgroundColor = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "skinBackgroundColor", -1);
					r_skinBackgroundColor.SetBelong(null);
				}
				return r_skinBackgroundColor;
			}
		}

		/// <summary>
		/// System.String displayedTitle
		/// </summary>
		protected RProperty r_displayedTitle;
		public virtual RProperty RdisplayedTitle
		{
			get
			{
				if(r_displayedTitle == null)
				{
					r_displayedTitle = new(this, "displayedTitle", -1);
					r_displayedTitle.SetBelong(this.instance);
				}
				return r_displayedTitle;
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
		/// UnityEditor.ContainerWindow[] windows
		/// </summary>
		protected static RPropertyArray<RUnityEditor.RContainerWindow> r_windows;
		public static RPropertyArray<RUnityEditor.RContainerWindow> Rwindows
		{
			get
			{
				if(r_windows == null)
				{
					r_windows = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "windows", -1);
					r_windows.SetBelong(null);
				}
				return r_windows;
			}
		}

		/// <summary>
		/// UnityEditor.View rootView
		/// </summary>
		protected RUnityEditor.RView r_rootView;
		public virtual RUnityEditor.RView RrootView
		{
			get
			{
				if(r_rootView == null)
				{
					r_rootView = new(this, "rootView", -1);
					r_rootView.SetBelong(this.instance);
				}
				return r_rootView;
			}
		}

		/// <summary>
		/// UnityEditor.SplitView rootSplitView
		/// </summary>
		protected RUnityEditor.RSplitView r_rootSplitView;
		public virtual RUnityEditor.RSplitView RrootSplitView
		{
			get
			{
				if(r_rootSplitView == null)
				{
					r_rootSplitView = new(this, "rootSplitView", -1);
					r_rootSplitView.SetBelong(this.instance);
				}
				return r_rootSplitView;
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
		/// Void SetAlpha(Single)
		/// </summary>
		protected RMethod r_SetAlpha_Single;
		public virtual RMethod RSetAlpha_Single
		{
			get
			{
				if(r_SetAlpha_Single == null)
				{
					r_SetAlpha_Single = new(this, "SetAlpha", 0, typeof(System.Single));
					r_SetAlpha_Single.SetBelong(this.instance);
				}
				return r_SetAlpha_Single;
			}
		}

		/// <summary>
		/// Void SetInvisible()
		/// </summary>
		protected RMethod r_SetInvisible;
		public virtual RMethod RSetInvisible
		{
			get
			{
				if(r_SetInvisible == null)
				{
					r_SetInvisible = new(this, "SetInvisible", 0);
					r_SetInvisible.SetBelong(this.instance);
				}
				return r_SetInvisible;
			}
		}

		/// <summary>
		/// Boolean IsZoomed()
		/// </summary>
		protected RMethod r_IsZoomed;
		public virtual RMethod RIsZoomed
		{
			get
			{
				if(r_IsZoomed == null)
				{
					r_IsZoomed = new(this, "IsZoomed", 0);
					r_IsZoomed.SetBelong(this.instance);
				}
				return r_IsZoomed;
			}
		}

		/// <summary>
		/// Void DisplayAllViews()
		/// </summary>
		protected RMethod r_DisplayAllViews;
		public virtual RMethod RDisplayAllViews
		{
			get
			{
				if(r_DisplayAllViews == null)
				{
					r_DisplayAllViews = new(this, "DisplayAllViews", 0);
					r_DisplayAllViews.SetBelong(this.instance);
				}
				return r_DisplayAllViews;
			}
		}

		/// <summary>
		/// Void Minimize()
		/// </summary>
		protected RMethod r_Minimize;
		public virtual RMethod RMinimize
		{
			get
			{
				if(r_Minimize == null)
				{
					r_Minimize = new(this, "Minimize", 0);
					r_Minimize.SetBelong(this.instance);
				}
				return r_Minimize;
			}
		}

		/// <summary>
		/// Void ToggleMaximize()
		/// </summary>
		protected RMethod r_ToggleMaximize;
		public virtual RMethod RToggleMaximize
		{
			get
			{
				if(r_ToggleMaximize == null)
				{
					r_ToggleMaximize = new(this, "ToggleMaximize", 0);
					r_ToggleMaximize.SetBelong(this.instance);
				}
				return r_ToggleMaximize;
			}
		}

		/// <summary>
		/// Void MoveInFrontOf(UnityEditor.ContainerWindow)
		/// </summary>
		protected RMethod r_MoveInFrontOf_ContainerWindow;
		public virtual RMethod RMoveInFrontOf_ContainerWindow
		{
			get
			{
				if(r_MoveInFrontOf_ContainerWindow == null)
				{
					r_MoveInFrontOf_ContainerWindow = new(this, "MoveInFrontOf", 0,  ReleactionUtils.GetType("UnityEditor.ContainerWindow"));
					r_MoveInFrontOf_ContainerWindow.SetBelong(this.instance);
				}
				return r_MoveInFrontOf_ContainerWindow;
			}
		}

		/// <summary>
		/// Void MoveBehindOf(UnityEditor.ContainerWindow)
		/// </summary>
		protected RMethod r_MoveBehindOf_ContainerWindow;
		public virtual RMethod RMoveBehindOf_ContainerWindow
		{
			get
			{
				if(r_MoveBehindOf_ContainerWindow == null)
				{
					r_MoveBehindOf_ContainerWindow = new(this, "MoveBehindOf", 0,  ReleactionUtils.GetType("UnityEditor.ContainerWindow"));
					r_MoveBehindOf_ContainerWindow.SetBelong(this.instance);
				}
				return r_MoveBehindOf_ContainerWindow;
			}
		}

		/// <summary>
		/// UnityEngine.Rect FitWindowRectToScreen(UnityEngine.Rect, Boolean, Boolean)
		/// </summary>
		protected RMethod r_FitWindowRectToScreen_Rect_Boolean_Boolean;
		public virtual RMethod RFitWindowRectToScreen_Rect_Boolean_Boolean
		{
			get
			{
				if(r_FitWindowRectToScreen_Rect_Boolean_Boolean == null)
				{
					r_FitWindowRectToScreen_Rect_Boolean_Boolean = new(this, "FitWindowRectToScreen", 0, typeof(UnityEngine.Rect), typeof(System.Boolean), typeof(System.Boolean));
					r_FitWindowRectToScreen_Rect_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_FitWindowRectToScreen_Rect_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void SendCaptionEvent(Boolean)
		/// </summary>
		protected RMethod r_SendCaptionEvent_Boolean;
		public virtual RMethod RSendCaptionEvent_Boolean
		{
			get
			{
				if(r_SendCaptionEvent_Boolean == null)
				{
					r_SendCaptionEvent_Boolean = new(this, "SendCaptionEvent", 0, typeof(System.Boolean));
					r_SendCaptionEvent_Boolean.SetBelong(this.instance);
				}
				return r_SendCaptionEvent_Boolean;
			}
		}

		/// <summary>
		/// Void InternalClose()
		/// </summary>
		protected RMethod r_InternalClose;
		public virtual RMethod RInternalClose
		{
			get
			{
				if(r_InternalClose == null)
				{
					r_InternalClose = new(this, "InternalClose", 0);
					r_InternalClose.SetBelong(this.instance);
				}
				return r_InternalClose;
			}
		}

		/// <summary>
		/// Void Internal_SetMinMaxSizes(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_Internal_SetMinMaxSizes_Vector2_Vector2;
		public virtual RMethod RInternal_SetMinMaxSizes_Vector2_Vector2
		{
			get
			{
				if(r_Internal_SetMinMaxSizes_Vector2_Vector2 == null)
				{
					r_Internal_SetMinMaxSizes_Vector2_Vector2 = new(this, "Internal_SetMinMaxSizes", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_Internal_SetMinMaxSizes_Vector2_Vector2.SetBelong(this.instance);
				}
				return r_Internal_SetMinMaxSizes_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Void Internal_Show(UnityEngine.Rect, Int32, UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_Internal_Show_Rect_Int32_Vector2_Vector2;
		public virtual RMethod RInternal_Show_Rect_Int32_Vector2_Vector2
		{
			get
			{
				if(r_Internal_Show_Rect_Int32_Vector2_Vector2 == null)
				{
					r_Internal_Show_Rect_Int32_Vector2_Vector2 = new(this, "Internal_Show", 0, typeof(UnityEngine.Rect), typeof(System.Int32), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_Internal_Show_Rect_Int32_Vector2_Vector2.SetBelong(this.instance);
				}
				return r_Internal_Show_Rect_Int32_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Void Internal_BringLiveAfterCreation(Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_Internal_BringLiveAfterCreation_Boolean_Boolean_Boolean;
		public virtual RMethod RInternal_BringLiveAfterCreation_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_Internal_BringLiveAfterCreation_Boolean_Boolean_Boolean == null)
				{
					r_Internal_BringLiveAfterCreation_Boolean_Boolean_Boolean = new(this, "Internal_BringLiveAfterCreation", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_Internal_BringLiveAfterCreation_Boolean_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_Internal_BringLiveAfterCreation_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void Internal_SetTitle(System.String)
		/// </summary>
		protected RMethod r_Internal_SetTitle_String;
		public virtual RMethod RInternal_SetTitle_String
		{
			get
			{
				if(r_Internal_SetTitle_String == null)
				{
					r_Internal_SetTitle_String = new(this, "Internal_SetTitle", 0, typeof(System.String));
					r_Internal_SetTitle_String.SetBelong(this.instance);
				}
				return r_Internal_SetTitle_String;
			}
		}

		/// <summary>
		/// Void Internal_SetHasUnsavedChanges(Boolean)
		/// </summary>
		protected RMethod r_Internal_SetHasUnsavedChanges_Boolean;
		public virtual RMethod RInternal_SetHasUnsavedChanges_Boolean
		{
			get
			{
				if(r_Internal_SetHasUnsavedChanges_Boolean == null)
				{
					r_Internal_SetHasUnsavedChanges_Boolean = new(this, "Internal_SetHasUnsavedChanges", 0, typeof(System.Boolean));
					r_Internal_SetHasUnsavedChanges_Boolean.SetBelong(this.instance);
				}
				return r_Internal_SetHasUnsavedChanges_Boolean;
			}
		}

		/// <summary>
		/// Void SetBackgroundColor(UnityEngine.Color)
		/// </summary>
		protected RMethod r_SetBackgroundColor_Color;
		public virtual RMethod RSetBackgroundColor_Color
		{
			get
			{
				if(r_SetBackgroundColor_Color == null)
				{
					r_SetBackgroundColor_Color = new(this, "SetBackgroundColor", 0, typeof(UnityEngine.Color));
					r_SetBackgroundColor_Color.SetBelong(this.instance);
				}
				return r_SetBackgroundColor_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 Internal_GetTopleftScreenPosition()
		/// </summary>
		protected RMethod r_Internal_GetTopleftScreenPosition;
		public virtual RMethod RInternal_GetTopleftScreenPosition
		{
			get
			{
				if(r_Internal_GetTopleftScreenPosition == null)
				{
					r_Internal_GetTopleftScreenPosition = new(this, "Internal_GetTopleftScreenPosition", 0);
					r_Internal_GetTopleftScreenPosition.SetBelong(this.instance);
				}
				return r_Internal_GetTopleftScreenPosition;
			}
		}

		/// <summary>
		/// Void SetFreezeDisplay(Boolean)
		/// </summary>
		protected static RMethod r_SetFreezeDisplay_Boolean;
		public static RMethod RSetFreezeDisplay_Boolean
		{
			get
			{
				if(r_SetFreezeDisplay_Boolean == null)
				{
					r_SetFreezeDisplay_Boolean = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "SetFreezeDisplay", 0, typeof(System.Boolean));
					r_SetFreezeDisplay_Boolean.SetBelong(null);
				}
				return r_SetFreezeDisplay_Boolean;
			}
		}

		/// <summary>
		/// Void GetOrderedWindowList()
		/// </summary>
		protected static RMethod r_GetOrderedWindowList;
		public static RMethod RGetOrderedWindowList
		{
			get
			{
				if(r_GetOrderedWindowList == null)
				{
					r_GetOrderedWindowList = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "GetOrderedWindowList", 0);
					r_GetOrderedWindowList.SetBelong(null);
				}
				return r_GetOrderedWindowList;
			}
		}

		/// <summary>
		/// UnityEngine.Rect FitRectToScreen(UnityEngine.Rect, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_FitRectToScreen_Rect_Boolean_Boolean;
		public static RMethod RFitRectToScreen_Rect_Boolean_Boolean
		{
			get
			{
				if(r_FitRectToScreen_Rect_Boolean_Boolean == null)
				{
					r_FitRectToScreen_Rect_Boolean_Boolean = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "FitRectToScreen", 0, typeof(UnityEngine.Rect), typeof(System.Boolean), typeof(System.Boolean));
					r_FitRectToScreen_Rect_Boolean_Boolean.SetBelong(null);
				}
				return r_FitRectToScreen_Rect_Boolean_Boolean;
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
		/// Boolean IsPopup(UnityEditor.ShowMode)
		/// </summary>
		protected static RMethod r_IsPopup_ShowMode;
		public static RMethod RIsPopup_ShowMode
		{
			get
			{
				if(r_IsPopup_ShowMode == null)
				{
					r_IsPopup_ShowMode = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "IsPopup", 0,  ReleactionUtils.GetType("UnityEditor.ShowMode"));
					r_IsPopup_ShowMode.SetBelong(null);
				}
				return r_IsPopup_ShowMode;
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
		/// Void ShowPopupWithMode(UnityEditor.ShowMode, Boolean)
		/// </summary>
		protected RMethod r_ShowPopupWithMode_ShowMode_Boolean;
		public virtual RMethod RShowPopupWithMode_ShowMode_Boolean
		{
			get
			{
				if(r_ShowPopupWithMode_ShowMode_Boolean == null)
				{
					r_ShowPopupWithMode_ShowMode_Boolean = new(this, "ShowPopupWithMode", 0,  ReleactionUtils.GetType("UnityEditor.ShowMode"), typeof(System.Boolean));
					r_ShowPopupWithMode_ShowMode_Boolean.SetBelong(this.instance);
				}
				return r_ShowPopupWithMode_ShowMode_Boolean;
			}
		}

		/// <summary>
		/// Void Show(UnityEditor.ShowMode, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_Show_ShowMode_Boolean_Boolean_Boolean;
		public virtual RMethod RShow_ShowMode_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_Show_ShowMode_Boolean_Boolean_Boolean == null)
				{
					r_Show_ShowMode_Boolean_Boolean_Boolean = new(this, "Show", 0,  ReleactionUtils.GetType("UnityEditor.ShowMode"), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_Show_ShowMode_Boolean_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_Show_ShowMode_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void FitWindowToScreen(Boolean)
		/// </summary>
		protected RMethod r_FitWindowToScreen_Boolean;
		public virtual RMethod RFitWindowToScreen_Boolean
		{
			get
			{
				if(r_FitWindowToScreen_Boolean == null)
				{
					r_FitWindowToScreen_Boolean = new(this, "FitWindowToScreen", 0, typeof(System.Boolean));
					r_FitWindowToScreen_Boolean.SetBelong(this.instance);
				}
				return r_FitWindowToScreen_Boolean;
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
		/// Boolean InternalRequestCloseAll(Boolean)
		/// </summary>
		protected static RMethod r_InternalRequestCloseAll_Boolean;
		public static RMethod RInternalRequestCloseAll_Boolean
		{
			get
			{
				if(r_InternalRequestCloseAll_Boolean == null)
				{
					r_InternalRequestCloseAll_Boolean = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "InternalRequestCloseAll", 0, typeof(System.Boolean));
					r_InternalRequestCloseAll_Boolean.SetBelong(null);
				}
				return r_InternalRequestCloseAll_Boolean;
			}
		}

		/// <summary>
		/// Boolean InternalRequestClose()
		/// </summary>
		protected RMethod r_InternalRequestClose;
		public virtual RMethod RInternalRequestClose
		{
			get
			{
				if(r_InternalRequestClose == null)
				{
					r_InternalRequestClose = new(this, "InternalRequestClose", 0);
					r_InternalRequestClose.SetBelong(this.instance);
				}
				return r_InternalRequestClose;
			}
		}

		/// <summary>
		/// Boolean InternalRequestClose(UnityEditor.EditorWindow)
		/// </summary>
		protected RMethod r_InternalRequestClose_EditorWindow;
		public virtual RMethod RInternalRequestClose_EditorWindow
		{
			get
			{
				if(r_InternalRequestClose_EditorWindow == null)
				{
					r_InternalRequestClose_EditorWindow = new(this, "InternalRequestClose", 0, typeof(UnityEditor.EditorWindow));
					r_InternalRequestClose_EditorWindow.SetBelong(this.instance);
				}
				return r_InternalRequestClose_EditorWindow;
			}
		}

		/// <summary>
		/// Boolean InternalRequestCloseAllExcept(UnityEditor.EditorWindow)
		/// </summary>
		protected RMethod r_InternalRequestCloseAllExcept_EditorWindow;
		public virtual RMethod RInternalRequestCloseAllExcept_EditorWindow
		{
			get
			{
				if(r_InternalRequestCloseAllExcept_EditorWindow == null)
				{
					r_InternalRequestCloseAllExcept_EditorWindow = new(this, "InternalRequestCloseAllExcept", 0, typeof(UnityEditor.EditorWindow));
					r_InternalRequestCloseAllExcept_EditorWindow.SetBelong(this.instance);
				}
				return r_InternalRequestCloseAllExcept_EditorWindow;
			}
		}

		/// <summary>
		/// Boolean PrivateRequestClose(System.Collections.Generic.List`1[UnityEditor.EditorWindow])
		/// </summary>
		protected static RMethod r_PrivateRequestClose_List_d_EditorWindow_p_;
		public static RMethod RPrivateRequestClose_List_d_EditorWindow_p_
		{
			get
			{
				if(r_PrivateRequestClose_List_d_EditorWindow_p_ == null)
				{
					r_PrivateRequestClose_List_d_EditorWindow_p_ = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "PrivateRequestClose", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEditor.EditorWindow)));
					r_PrivateRequestClose_List_d_EditorWindow_p_.SetBelong(null);
				}
				return r_PrivateRequestClose_List_d_EditorWindow_p_;
			}
		}

		/// <summary>
		/// Void InternalCloseWindow()
		/// </summary>
		protected RMethod r_InternalCloseWindow;
		public virtual RMethod RInternalCloseWindow
		{
			get
			{
				if(r_InternalCloseWindow == null)
				{
					r_InternalCloseWindow = new(this, "InternalCloseWindow", 0);
					r_InternalCloseWindow.SetBelong(this.instance);
				}
				return r_InternalCloseWindow;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.EditorWindow] FindUnsavedChanges(UnityEditor.View)
		/// </summary>
		protected static RMethod r_FindUnsavedChanges_View;
		public static RMethod RFindUnsavedChanges_View
		{
			get
			{
				if(r_FindUnsavedChanges_View == null)
				{
					r_FindUnsavedChanges_View = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "FindUnsavedChanges", 0,  ReleactionUtils.GetType("UnityEditor.View"));
					r_FindUnsavedChanges_View.SetBelong(null);
				}
				return r_FindUnsavedChanges_View;
			}
		}

		/// <summary>
		/// Void UnsavedStateChanged()
		/// </summary>
		protected RMethod r_UnsavedStateChanged;
		public virtual RMethod RUnsavedStateChanged
		{
			get
			{
				if(r_UnsavedStateChanged == null)
				{
					r_UnsavedStateChanged = new(this, "UnsavedStateChanged", 0);
					r_UnsavedStateChanged.SetBelong(this.instance);
				}
				return r_UnsavedStateChanged;
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
		/// Boolean IsNotDocked()
		/// </summary>
		protected RMethod r_IsNotDocked;
		public virtual RMethod RIsNotDocked
		{
			get
			{
				if(r_IsNotDocked == null)
				{
					r_IsNotDocked = new(this, "IsNotDocked", 0);
					r_IsNotDocked.SetBelong(this.instance);
				}
				return r_IsNotDocked;
			}
		}

		/// <summary>
		/// System.String GetWindowID()
		/// </summary>
		protected RMethod r_GetWindowID;
		public virtual RMethod RGetWindowID
		{
			get
			{
				if(r_GetWindowID == null)
				{
					r_GetWindowID = new(this, "GetWindowID", 0);
					r_GetWindowID.SetBelong(this.instance);
				}
				return r_GetWindowID;
			}
		}

		/// <summary>
		/// Boolean IsMainWindow()
		/// </summary>
		protected RMethod r_IsMainWindow;
		public virtual RMethod RIsMainWindow
		{
			get
			{
				if(r_IsMainWindow == null)
				{
					r_IsMainWindow = new(this, "IsMainWindow", 0);
					r_IsMainWindow.SetBelong(this.instance);
				}
				return r_IsMainWindow;
			}
		}

		/// <summary>
		/// Void SaveGeometry()
		/// </summary>
		protected RMethod r_SaveGeometry;
		public virtual RMethod RSaveGeometry
		{
			get
			{
				if(r_SaveGeometry == null)
				{
					r_SaveGeometry = new(this, "SaveGeometry", 0);
					r_SaveGeometry.SetBelong(this.instance);
				}
				return r_SaveGeometry;
			}
		}

		/// <summary>
		/// Void Save()
		/// </summary>
		protected RMethod r_Save;
		public virtual RMethod RSave
		{
			get
			{
				if(r_Save == null)
				{
					r_Save = new(this, "Save", 0);
					r_Save.SetBelong(this.instance);
				}
				return r_Save;
			}
		}

		/// <summary>
		/// Void LoadGeometry(Boolean)
		/// </summary>
		protected RMethod r_LoadGeometry_Boolean;
		public virtual RMethod RLoadGeometry_Boolean
		{
			get
			{
				if(r_LoadGeometry_Boolean == null)
				{
					r_LoadGeometry_Boolean = new(this, "LoadGeometry", 0, typeof(System.Boolean));
					r_LoadGeometry_Boolean.SetBelong(this.instance);
				}
				return r_LoadGeometry_Boolean;
			}
		}

		/// <summary>
		/// Void LoadInCurrentMousePosition()
		/// </summary>
		protected RMethod r_LoadInCurrentMousePosition;
		public virtual RMethod RLoadInCurrentMousePosition
		{
			get
			{
				if(r_LoadInCurrentMousePosition == null)
				{
					r_LoadInCurrentMousePosition = new(this, "LoadInCurrentMousePosition", 0);
					r_LoadInCurrentMousePosition.SetBelong(this.instance);
				}
				return r_LoadInCurrentMousePosition;
			}
		}

		/// <summary>
		/// Void Load(Boolean)
		/// </summary>
		protected RMethod r_Load_Boolean;
		public virtual RMethod RLoad_Boolean
		{
			get
			{
				if(r_Load_Boolean == null)
				{
					r_Load_Boolean = new(this, "Load", 0, typeof(System.Boolean));
					r_Load_Boolean.SetBelong(this.instance);
				}
				return r_Load_Boolean;
			}
		}

		/// <summary>
		/// Void OnResize()
		/// </summary>
		protected RMethod r_OnResize;
		public virtual RMethod ROnResize
		{
			get
			{
				if(r_OnResize == null)
				{
					r_OnResize = new(this, "OnResize", 0);
					r_OnResize.SetBelong(this.instance);
				}
				return r_OnResize;
			}
		}

		/// <summary>
		/// Void UpdateTitle()
		/// </summary>
		protected RMethod r_UpdateTitle;
		public virtual RMethod RUpdateTitle
		{
			get
			{
				if(r_UpdateTitle == null)
				{
					r_UpdateTitle = new(this, "UpdateTitle", 0);
					r_UpdateTitle.SetBelong(this.instance);
				}
				return r_UpdateTitle;
			}
		}

		/// <summary>
		/// Void AddToWindowList()
		/// </summary>
		protected RMethod r_AddToWindowList;
		public virtual RMethod RAddToWindowList
		{
			get
			{
				if(r_AddToWindowList == null)
				{
					r_AddToWindowList = new(this, "AddToWindowList", 0);
					r_AddToWindowList.SetBelong(this.instance);
				}
				return r_AddToWindowList;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 WindowToScreenPoint(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_WindowToScreenPoint_Vector2;
		public virtual RMethod RWindowToScreenPoint_Vector2
		{
			get
			{
				if(r_WindowToScreenPoint_Vector2 == null)
				{
					r_WindowToScreenPoint_Vector2 = new(this, "WindowToScreenPoint", 0, typeof(UnityEngine.Vector2));
					r_WindowToScreenPoint_Vector2.SetBelong(this.instance);
				}
				return r_WindowToScreenPoint_Vector2;
			}
		}

		/// <summary>
		/// System.String DebugHierarchy()
		/// </summary>
		protected RMethod r_DebugHierarchy;
		public virtual RMethod RDebugHierarchy
		{
			get
			{
				if(r_DebugHierarchy == null)
				{
					r_DebugHierarchy = new(this, "DebugHierarchy", 0);
					r_DebugHierarchy.SetBelong(this.instance);
				}
				return r_DebugHierarchy;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetDropDownRect(UnityEngine.Rect, UnityEngine.Vector2, UnityEngine.Vector2, UnityEditor.PopupLocation[])
		/// </summary>
		protected RMethod r_GetDropDownRect_Rect_Vector2_Vector2_PopupLocationArray;
		public virtual RMethod RGetDropDownRect_Rect_Vector2_Vector2_PopupLocationArray
		{
			get
			{
				if(r_GetDropDownRect_Rect_Vector2_Vector2_PopupLocationArray == null)
				{
					r_GetDropDownRect_Rect_Vector2_Vector2_PopupLocationArray = new(this, "GetDropDownRect", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2),  ReleactionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType());
					r_GetDropDownRect_Rect_Vector2_Vector2_PopupLocationArray.SetBelong(this.instance);
				}
				return r_GetDropDownRect_Rect_Vector2_Vector2_PopupLocationArray;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetDropDownRect(UnityEngine.Rect, UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_GetDropDownRect_Rect_Vector2_Vector2;
		public virtual RMethod RGetDropDownRect_Rect_Vector2_Vector2
		{
			get
			{
				if(r_GetDropDownRect_Rect_Vector2_Vector2 == null)
				{
					r_GetDropDownRect_Rect_Vector2_Vector2 = new(this, "GetDropDownRect", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_GetDropDownRect_Rect_Vector2_Vector2.SetBelong(this.instance);
				}
				return r_GetDropDownRect_Rect_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Void HandleWindowDecorationEnd(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_HandleWindowDecorationEnd_Rect;
		public virtual RMethod RHandleWindowDecorationEnd_Rect
		{
			get
			{
				if(r_HandleWindowDecorationEnd_Rect == null)
				{
					r_HandleWindowDecorationEnd_Rect = new(this, "HandleWindowDecorationEnd", 0, typeof(UnityEngine.Rect));
					r_HandleWindowDecorationEnd_Rect.SetBelong(this.instance);
				}
				return r_HandleWindowDecorationEnd_Rect;
			}
		}

		/// <summary>
		/// Void HandleWindowDecorationStart(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_HandleWindowDecorationStart_Rect;
		public virtual RMethod RHandleWindowDecorationStart_Rect
		{
			get
			{
				if(r_HandleWindowDecorationStart_Rect == null)
				{
					r_HandleWindowDecorationStart_Rect = new(this, "HandleWindowDecorationStart", 0, typeof(UnityEngine.Rect));
					r_HandleWindowDecorationStart_Rect.SetBelong(this.instance);
				}
				return r_HandleWindowDecorationStart_Rect;
			}
		}

		/// <summary>
		/// Void BeginTitleBarButtons(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_BeginTitleBarButtons_Rect;
		public virtual RMethod RBeginTitleBarButtons_Rect
		{
			get
			{
				if(r_BeginTitleBarButtons_Rect == null)
				{
					r_BeginTitleBarButtons_Rect = new(this, "BeginTitleBarButtons", 0, typeof(UnityEngine.Rect));
					r_BeginTitleBarButtons_Rect.SetBelong(this.instance);
				}
				return r_BeginTitleBarButtons_Rect;
			}
		}

		/// <summary>
		/// Boolean TitleBarButton(UnityEngine.GUIStyle)
		/// </summary>
		protected RMethod r_TitleBarButton_GUIStyle;
		public virtual RMethod RTitleBarButton_GUIStyle
		{
			get
			{
				if(r_TitleBarButton_GUIStyle == null)
				{
					r_TitleBarButton_GUIStyle = new(this, "TitleBarButton", 0, typeof(UnityEngine.GUIStyle));
					r_TitleBarButton_GUIStyle.SetBelong(this.instance);
				}
				return r_TitleBarButton_GUIStyle;
			}
		}

		/// <summary>
		/// Void DragTitleBar(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_DragTitleBar_Rect;
		public virtual RMethod RDragTitleBar_Rect
		{
			get
			{
				if(r_DragTitleBar_Rect == null)
				{
					r_DragTitleBar_Rect = new(this, "DragTitleBar", 0, typeof(UnityEngine.Rect));
					r_DragTitleBar_Rect.SetBelong(this.instance);
				}
				return r_DragTitleBar_Rect;
			}
		}

		/// <summary>
		/// Void get_position_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_get_position_Injected_Out_Rect;
		public virtual RMethod Rget_position_Injected_Out_Rect
		{
			get
			{
				if(r_get_position_Injected_Out_Rect == null)
				{
					r_get_position_Injected_Out_Rect = new(this, "get_position_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_get_position_Injected_Out_Rect.SetBelong(this.instance);
				}
				return r_get_position_Injected_Out_Rect;
			}
		}

		/// <summary>
		/// Void set_position_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_set_position_Injected_Ref_Rect;
		public virtual RMethod Rset_position_Injected_Ref_Rect
		{
			get
			{
				if(r_set_position_Injected_Ref_Rect == null)
				{
					r_set_position_Injected_Ref_Rect = new(this, "set_position_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_set_position_Injected_Ref_Rect.SetBelong(this.instance);
				}
				return r_set_position_Injected_Ref_Rect;
			}
		}

		/// <summary>
		/// Void FitWindowRectToScreen_Injected(UnityEngine.Rect ByRef, Boolean, Boolean, UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_FitWindowRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect;
		public virtual RMethod RFitWindowRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect
		{
			get
			{
				if(r_FitWindowRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect == null)
				{
					r_FitWindowRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect = new(this, "FitWindowRectToScreen_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(System.Boolean), typeof(System.Boolean), typeof(UnityEngine.Rect).MakeByRefType());
					r_FitWindowRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect.SetBelong(this.instance);
				}
				return r_FitWindowRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect;
			}
		}

		/// <summary>
		/// Void Internal_SetMinMaxSizes_Injected(UnityEngine.Vector2 ByRef, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Internal_SetMinMaxSizes_Injected_Ref_Vector2_Ref_Vector2;
		public virtual RMethod RInternal_SetMinMaxSizes_Injected_Ref_Vector2_Ref_Vector2
		{
			get
			{
				if(r_Internal_SetMinMaxSizes_Injected_Ref_Vector2_Ref_Vector2 == null)
				{
					r_Internal_SetMinMaxSizes_Injected_Ref_Vector2_Ref_Vector2 = new(this, "Internal_SetMinMaxSizes_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType(), typeof(UnityEngine.Vector2).MakeByRefType());
					r_Internal_SetMinMaxSizes_Injected_Ref_Vector2_Ref_Vector2.SetBelong(this.instance);
				}
				return r_Internal_SetMinMaxSizes_Injected_Ref_Vector2_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void Internal_Show_Injected(UnityEngine.Rect ByRef, Int32, UnityEngine.Vector2 ByRef, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Internal_Show_Injected_Ref_Rect_Int32_Ref_Vector2_Ref_Vector2;
		public virtual RMethod RInternal_Show_Injected_Ref_Rect_Int32_Ref_Vector2_Ref_Vector2
		{
			get
			{
				if(r_Internal_Show_Injected_Ref_Rect_Int32_Ref_Vector2_Ref_Vector2 == null)
				{
					r_Internal_Show_Injected_Ref_Rect_Int32_Ref_Vector2_Ref_Vector2 = new(this, "Internal_Show_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(System.Int32), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(UnityEngine.Vector2).MakeByRefType());
					r_Internal_Show_Injected_Ref_Rect_Int32_Ref_Vector2_Ref_Vector2.SetBelong(this.instance);
				}
				return r_Internal_Show_Injected_Ref_Rect_Int32_Ref_Vector2_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void SetBackgroundColor_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_SetBackgroundColor_Injected_Ref_Color;
		public virtual RMethod RSetBackgroundColor_Injected_Ref_Color
		{
			get
			{
				if(r_SetBackgroundColor_Injected_Ref_Color == null)
				{
					r_SetBackgroundColor_Injected_Ref_Color = new(this, "SetBackgroundColor_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
					r_SetBackgroundColor_Injected_Ref_Color.SetBelong(this.instance);
				}
				return r_SetBackgroundColor_Injected_Ref_Color;
			}
		}

		/// <summary>
		/// Void Internal_GetTopleftScreenPosition_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Internal_GetTopleftScreenPosition_Injected_Out_Vector2;
		public virtual RMethod RInternal_GetTopleftScreenPosition_Injected_Out_Vector2
		{
			get
			{
				if(r_Internal_GetTopleftScreenPosition_Injected_Out_Vector2 == null)
				{
					r_Internal_GetTopleftScreenPosition_Injected_Out_Vector2 = new(this, "Internal_GetTopleftScreenPosition_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_Internal_GetTopleftScreenPosition_Injected_Out_Vector2.SetBelong(this.instance);
				}
				return r_Internal_GetTopleftScreenPosition_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void FitRectToScreen_Injected(UnityEngine.Rect ByRef, Boolean, Boolean, UnityEngine.Rect ByRef)
		/// </summary>
		protected static RMethod r_FitRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect;
		public static RMethod RFitRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect
		{
			get
			{
				if(r_FitRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect == null)
				{
					r_FitRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect = new( ReleactionUtils.GetType("UnityEditor.ContainerWindow"), "FitRectToScreen_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(System.Boolean), typeof(System.Boolean), typeof(UnityEngine.Rect).MakeByRefType());
					r_FitRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect.SetBelong(null);
				}
				return r_FitRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect;
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


        public RContainerWindow() : base("UnityEditor.ContainerWindow")
        {
        }

        public RContainerWindow(System.Object instance) : base("UnityEditor.ContainerWindow")
		{
            SetInstance(instance);
		}

        public RContainerWindow(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RContainerWindow(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetAlpha(System.Single  @alpha)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alpha};
            var ___result = RSetAlpha_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInvisible()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetInvisible.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsZoomed()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsZoomed.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void DisplayAllViews()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDisplayAllViews.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Minimize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMinimize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ToggleMaximize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToggleMaximize.Invoke(___genericsType, ___parameters);

            
        }




        public virtual UnityEngine.Rect FitWindowRectToScreen(UnityEngine.Rect  @r, System.Boolean  @forceCompletelyVisible, System.Boolean  @useMouseScreen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r, @forceCompletelyVisible, @useMouseScreen};
            var ___result = RFitWindowRectToScreen_Rect_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void SendCaptionEvent(System.Boolean  @mouseDown)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mouseDown};
            var ___result = RSendCaptionEvent_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalClose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetMinMaxSizes(UnityEngine.Vector2  @minSize, UnityEngine.Vector2  @maxSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@minSize, @maxSize};
            var ___result = RInternal_SetMinMaxSizes_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_Show(UnityEngine.Rect  @r, System.Int32  @showMode, UnityEngine.Vector2  @minSize, UnityEngine.Vector2  @maxSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r, @showMode, @minSize, @maxSize};
            var ___result = RInternal_Show_Rect_Int32_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_BringLiveAfterCreation(System.Boolean  @displayImmediately, System.Boolean  @setFocus, System.Boolean  @showMaximized)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@displayImmediately, @setFocus, @showMaximized};
            var ___result = RInternal_BringLiveAfterCreation_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetTitle(System.String  @title)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@title};
            var ___result = RInternal_SetTitle_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetHasUnsavedChanges(System.Boolean  @hasUnsavedChanges)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hasUnsavedChanges};
            var ___result = RInternal_SetHasUnsavedChanges_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBackgroundColor(UnityEngine.Color  @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color};
            var ___result = RSetBackgroundColor_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 Internal_GetTopleftScreenPosition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternal_GetTopleftScreenPosition.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static void SetFreezeDisplay(System.Boolean  @freeze)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@freeze};
            var ___result = RSetFreezeDisplay_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void GetOrderedWindowList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetOrderedWindowList.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Rect FitRectToScreen(UnityEngine.Rect  @defaultRect, System.Boolean  @forceCompletelyVisible, System.Boolean  @useMouseScreen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@defaultRect, @forceCompletelyVisible, @useMouseScreen};
            var ___result = RFitRectToScreen_Rect_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void __internalAwake()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__internalAwake.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void ShowPopup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowPopup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowTooltip()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowTooltip.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void FitWindowToScreen(System.Boolean  @useMousePos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@useMousePos};
            var ___result = RFitWindowToScreen_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnEnable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnEnable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMinMaxSizes(UnityEngine.Vector2  @min, UnityEngine.Vector2  @max)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@min, @max};
            var ___result = RSetMinMaxSizes_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean InternalRequestCloseAll(System.Boolean  @keepMainWindow)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keepMainWindow};
            var ___result = RInternalRequestCloseAll_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean InternalRequestClose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalRequestClose.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean InternalRequestClose(UnityEditor.EditorWindow  @dockedTab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dockedTab};
            var ___result = RInternalRequestClose_EditorWindow.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean InternalRequestCloseAllExcept(UnityEditor.EditorWindow  @editorWindow)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editorWindow};
            var ___result = RInternalRequestCloseAllExcept_EditorWindow.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean PrivateRequestClose(System.Collections.Generic.List<UnityEditor.EditorWindow>  @allUnsaved)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@allUnsaved};
            var ___result = RPrivateRequestClose_List_d_EditorWindow_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void InternalCloseWindow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalCloseWindow.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void UnsavedStateChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnsavedStateChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsNotDocked()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsNotDocked.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String GetWindowID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetWindowID.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean IsMainWindow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsMainWindow.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SaveGeometry()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSaveGeometry.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Save()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSave.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadGeometry(System.Boolean  @loadPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@loadPosition};
            var ___result = RLoadGeometry_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadInCurrentMousePosition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLoadInCurrentMousePosition.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Load(System.Boolean  @loadPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@loadPosition};
            var ___result = RLoad_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnResize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnResize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateTitle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateTitle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddToWindowList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAddToWindowList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 WindowToScreenPoint(UnityEngine.Vector2  @windowPoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowPoint};
            var ___result = RWindowToScreenPoint_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.String DebugHierarchy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDebugHierarchy.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }



        public virtual UnityEngine.Rect GetDropDownRect(UnityEngine.Rect  @buttonRect, UnityEngine.Vector2  @minSize, UnityEngine.Vector2  @maxSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect, @minSize, @maxSize};
            var ___result = RGetDropDownRect_Rect_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void HandleWindowDecorationEnd(UnityEngine.Rect  @windowPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowPosition};
            var ___result = RHandleWindowDecorationEnd_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleWindowDecorationStart(UnityEngine.Rect  @windowPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowPosition};
            var ___result = RHandleWindowDecorationStart_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginTitleBarButtons(UnityEngine.Rect  @windowPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowPosition};
            var ___result = RBeginTitleBarButtons_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TitleBarButton(UnityEngine.GUIStyle  @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style};
            var ___result = RTitleBarButton_GUIStyle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void DragTitleBar(UnityEngine.Rect  @titleBarRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@titleBarRect};
            var ___result = RDragTitleBar_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void get_position_Injected(out UnityEngine.Rect  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_position_Injected_Out_Rect.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void set_position_Injected(ref UnityEngine.Rect  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_position_Injected_Ref_Rect.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void FitWindowRectToScreen_Injected(ref UnityEngine.Rect  @r, System.Boolean  @forceCompletelyVisible, System.Boolean  @useMouseScreen, out UnityEngine.Rect  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r, @forceCompletelyVisible, @useMouseScreen, @ret};
            var ___result = RFitWindowRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect.Invoke(___genericsType, ___parameters);
			r = (UnityEngine.Rect)___parameters[0];
			ret = (UnityEngine.Rect)___parameters[3];

            
        }


        public virtual void Internal_SetMinMaxSizes_Injected(ref UnityEngine.Vector2  @minSize, ref UnityEngine.Vector2  @maxSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@minSize, @maxSize};
            var ___result = RInternal_SetMinMaxSizes_Injected_Ref_Vector2_Ref_Vector2.Invoke(___genericsType, ___parameters);
			minSize = (UnityEngine.Vector2)___parameters[0];
			maxSize = (UnityEngine.Vector2)___parameters[1];

            
        }


        public virtual void Internal_Show_Injected(ref UnityEngine.Rect  @r, System.Int32  @showMode, ref UnityEngine.Vector2  @minSize, ref UnityEngine.Vector2  @maxSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r, @showMode, @minSize, @maxSize};
            var ___result = RInternal_Show_Injected_Ref_Rect_Int32_Ref_Vector2_Ref_Vector2.Invoke(___genericsType, ___parameters);
			r = (UnityEngine.Rect)___parameters[0];
			minSize = (UnityEngine.Vector2)___parameters[2];
			maxSize = (UnityEngine.Vector2)___parameters[3];

            
        }


        public virtual void SetBackgroundColor_Injected(ref UnityEngine.Color  @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color};
            var ___result = RSetBackgroundColor_Injected_Ref_Color.Invoke(___genericsType, ___parameters);
			color = (UnityEngine.Color)___parameters[0];

            
        }


        public virtual void Internal_GetTopleftScreenPosition_Injected(out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RInternal_GetTopleftScreenPosition_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public static void FitRectToScreen_Injected(ref UnityEngine.Rect  @defaultRect, System.Boolean  @forceCompletelyVisible, System.Boolean  @useMouseScreen, out UnityEngine.Rect  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@defaultRect, @forceCompletelyVisible, @useMouseScreen, @ret};
            var ___result = RFitRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect.Invoke(___genericsType, ___parameters);
			defaultRect = (UnityEngine.Rect)___parameters[0];
			ret = (UnityEngine.Rect)___parameters[3];

            
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
