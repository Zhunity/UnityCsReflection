
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.ContainerWindow
	/// </summary>
    public partial class RContainerWindow : RMember //
    {

		/// <summary>
		/// System.String k_ScriptingPrefix
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_ScriptingPrefix;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_ScriptingPrefix
		{
			get
			{
				if(r_Fk_ScriptingPrefix == null)
				{
					r_Fk_ScriptingPrefix = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "k_ScriptingPrefix");
					r_Fk_ScriptingPrefix.SetBelong(null);
				}
				return r_Fk_ScriptingPrefix;
			}
		}

		/// <summary>
		/// UnityEditor.MonoReloadableIntPtr m_WindowPtr
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RMonoReloadableIntPtr r_Fm_WindowPtr;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RMonoReloadableIntPtr RFm_WindowPtr
		{
			get
			{
				if(r_Fm_WindowPtr == null)
				{
					r_Fm_WindowPtr = new(this, "m_WindowPtr");
					r_Fm_WindowPtr.SetBelong(this.instance);
				}
				return r_Fm_WindowPtr;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_PixelRect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Fm_PixelRect;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFm_PixelRect
		{
			get
			{
				if(r_Fm_PixelRect == null)
				{
					r_Fm_PixelRect = new(this, "m_PixelRect");
					r_Fm_PixelRect.SetBelong(this.instance);
				}
				return r_Fm_PixelRect;
			}
		}

		/// <summary>
		/// System.Int32 m_ShowMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_ShowMode;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_ShowMode
		{
			get
			{
				if(r_Fm_ShowMode == null)
				{
					r_Fm_ShowMode = new(this, "m_ShowMode");
					r_Fm_ShowMode.SetBelong(this.instance);
				}
				return r_Fm_ShowMode;
			}
		}

		/// <summary>
		/// System.String m_Title
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Title;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Title
		{
			get
			{
				if(r_Fm_Title == null)
				{
					r_Fm_Title = new(this, "m_Title");
					r_Fm_Title.SetBelong(this.instance);
				}
				return r_Fm_Title;
			}
		}

		/// <summary>
		/// UnityEditor.View m_RootView
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RView r_Fm_RootView;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RView RFm_RootView
		{
			get
			{
				if(r_Fm_RootView == null)
				{
					r_Fm_RootView = new(this, "m_RootView");
					r_Fm_RootView.SetBelong(this.instance);
				}
				return r_Fm_RootView;
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
					r_Fm_MinSize.SetBelong(this.instance);
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
					r_Fm_MaxSize.SetBelong(this.instance);
				}
				return r_Fm_MaxSize;
			}
		}

		/// <summary>
		/// System.Boolean m_Maximized
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_Maximized;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_Maximized
		{
			get
			{
				if(r_Fm_Maximized == null)
				{
					r_Fm_Maximized = new(this, "m_Maximized");
					r_Fm_Maximized.SetBelong(this.instance);
				}
				return r_Fm_Maximized;
			}
		}

		/// <summary>
		/// System.Boolean m_DontSaveToLayout
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_DontSaveToLayout;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_DontSaveToLayout
		{
			get
			{
				if(r_Fm_DontSaveToLayout == null)
				{
					r_Fm_DontSaveToLayout = new(this, "m_DontSaveToLayout");
					r_Fm_DontSaveToLayout.SetBelong(this.instance);
				}
				return r_Fm_DontSaveToLayout;
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
					r_Fm_HasUnsavedChanges.SetBelong(this.instance);
				}
				return r_Fm_HasUnsavedChanges;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.EditorWindow] m_UnsavedEditorWindows
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.REditorWindow> r_Fm_UnsavedEditorWindows;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.REditorWindow> RFm_UnsavedEditorWindows
		{
			get
			{
				if(r_Fm_UnsavedEditorWindows == null)
				{
					r_Fm_UnsavedEditorWindows = new(this, "m_UnsavedEditorWindows");
					r_Fm_UnsavedEditorWindows.SetBelong(this.instance);
				}
				return r_Fm_UnsavedEditorWindows;
			}
		}

		/// <summary>
		/// System.Int32 m_ButtonCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_ButtonCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_ButtonCount
		{
			get
			{
				if(r_Fm_ButtonCount == null)
				{
					r_Fm_ButtonCount = new(this, "m_ButtonCount");
					r_Fm_ButtonCount.SetBelong(this.instance);
				}
				return r_Fm_ButtonCount;
			}
		}

		/// <summary>
		/// System.Single m_TitleBarWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_TitleBarWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_TitleBarWidth
		{
			get
			{
				if(r_Fm_TitleBarWidth == null)
				{
					r_Fm_TitleBarWidth = new(this, "m_TitleBarWidth");
					r_Fm_TitleBarWidth.SetBelong(this.instance);
				}
				return r_Fm_TitleBarWidth;
			}
		}

		/// <summary>
		/// System.Single kTitleHeight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FkTitleHeight;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFkTitleHeight
		{
			get
			{
				if(r_FkTitleHeight == null)
				{
					r_FkTitleHeight = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "kTitleHeight");
					r_FkTitleHeight.SetBelong(null);
				}
				return r_FkTitleHeight;
			}
		}

		/// <summary>
		/// System.Single kButtonWidth
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FkButtonWidth;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFkButtonWidth
		{
			get
			{
				if(r_FkButtonWidth == null)
				{
					r_FkButtonWidth = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "kButtonWidth");
					r_FkButtonWidth.SetBelong(null);
				}
				return r_FkButtonWidth;
			}
		}

		/// <summary>
		/// System.Single kButtonHeight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FkButtonHeight;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFkButtonHeight
		{
			get
			{
				if(r_FkButtonHeight == null)
				{
					r_FkButtonHeight = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "kButtonHeight");
					r_FkButtonHeight.SetBelong(null);
				}
				return r_FkButtonHeight;
			}
		}

		/// <summary>
		/// System.Boolean s_Modal
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_Fs_Modal;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RFs_Modal
		{
			get
			{
				if(r_Fs_Modal == null)
				{
					r_Fs_Modal = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "s_Modal");
					r_Fs_Modal.SetBelong(null);
				}
				return r_Fs_Modal;
			}
		}

		/// <summary>
		/// UnityEditor.ContainerWindow s_MainWindow
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RContainerWindow r_Fs_MainWindow;
		public static Hvak.Editor.Refleaction.RUnityEditor.RContainerWindow RFs_MainWindow
		{
			get
			{
				if(r_Fs_MainWindow == null)
				{
					r_Fs_MainWindow = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "s_MainWindow");
					r_Fs_MainWindow.SetBelong(null);
				}
				return r_Fs_MainWindow;
			}
		}

		/// <summary>
		/// System.Single kButtonCountOSX
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FkButtonCountOSX;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFkButtonCountOSX
		{
			get
			{
				if(r_FkButtonCountOSX == null)
				{
					r_FkButtonCountOSX = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "kButtonCountOSX");
					r_FkButtonCountOSX.SetBelong(null);
				}
				return r_FkButtonCountOSX;
			}
		}

		/// <summary>
		/// System.Single kButtonCountWin
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FkButtonCountWin;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFkButtonCountWin
		{
			get
			{
				if(r_FkButtonCountWin == null)
				{
					r_FkButtonCountWin = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "kButtonCountWin");
					r_FkButtonCountWin.SetBelong(null);
				}
				return r_FkButtonCountWin;
			}
		}

		/// <summary>
		/// System.String m_WindowID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_WindowID;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_WindowID
		{
			get
			{
				if(r_Fm_WindowID == null)
				{
					r_Fm_WindowID = new(this, "m_WindowID");
					r_Fm_WindowID.SetBelong(this.instance);
				}
				return r_Fm_WindowID;
			}
		}

		/// <summary>
		/// UnityEngine.Color lightSkinColor
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RColor r_FlightSkinColor;
		public static Hvak.Editor.Refleaction.RUnityEngine.RColor RFlightSkinColor
		{
			get
			{
				if(r_FlightSkinColor == null)
				{
					r_FlightSkinColor = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "lightSkinColor");
					r_FlightSkinColor.SetBelong(null);
				}
				return r_FlightSkinColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color darkSkinColor
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RColor r_FdarkSkinColor;
		public static Hvak.Editor.Refleaction.RUnityEngine.RColor RFdarkSkinColor
		{
			get
			{
				if(r_FdarkSkinColor == null)
				{
					r_FdarkSkinColor = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "darkSkinColor");
					r_FdarkSkinColor.SetBelong(null);
				}
				return r_FdarkSkinColor;
			}
		}

		/// <summary>
		/// System.String <displayedTitle>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F__0__displayedTitle__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF__0__displayedTitle__1__k__BackingField
		{
			get
			{
				if(r_F__0__displayedTitle__1__k__BackingField == null)
				{
					r_F__0__displayedTitle__1__k__BackingField = new(this, "<displayedTitle>k__BackingField");
					r_F__0__displayedTitle__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__displayedTitle__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.ContainerWindow] s_AllWindows
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RContainerWindow> r_Fs_AllWindows;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RContainerWindow> RFs_AllWindows
		{
			get
			{
				if(r_Fs_AllWindows == null)
				{
					r_Fs_AllWindows = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "s_AllWindows");
					r_Fs_AllWindows.SetBelong(null);
				}
				return r_Fs_AllWindows;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 s_LastDragMousePos
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Fs_LastDragMousePos;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFs_LastDragMousePos
		{
			get
			{
				if(r_Fs_LastDragMousePos == null)
				{
					r_Fs_LastDragMousePos = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "s_LastDragMousePos");
					r_Fs_LastDragMousePos.SetBelong(null);
				}
				return r_Fs_LastDragMousePos;
			}
		}

		/// <summary>
		/// System.Single startDragDpi
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FstartDragDpi;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFstartDragDpi
		{
			get
			{
				if(r_FstartDragDpi == null)
				{
					r_FstartDragDpi = new(this, "startDragDpi");
					r_FstartDragDpi.SetBelong(this.instance);
				}
				return r_FstartDragDpi;
			}
		}

		/// <summary>
		/// System.Boolean m_DraggingNativeTitleBarCaption
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_DraggingNativeTitleBarCaption;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_DraggingNativeTitleBarCaption
		{
			get
			{
				if(r_Fm_DraggingNativeTitleBarCaption == null)
				{
					r_Fm_DraggingNativeTitleBarCaption = new(this, "m_DraggingNativeTitleBarCaption");
					r_Fm_DraggingNativeTitleBarCaption.SetBelong(this.instance);
				}
				return r_Fm_DraggingNativeTitleBarCaption;
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
					r_Pposition.SetBelong(this.instance);
				}
				return r_Pposition;
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
					r_Pmaximized.SetBelong(this.instance);
				}
				return r_Pmaximized;
			}
		}

		/// <summary>
		/// Boolean macEditor
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_PmacEditor;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RPmacEditor
		{
			get
			{
				if(r_PmacEditor == null)
				{
					r_PmacEditor = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "macEditor", -1);
					r_PmacEditor.SetBelong(null);
				}
				return r_PmacEditor;
			}
		}

		/// <summary>
		/// Boolean linuxEditor
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_PlinuxEditor;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RPlinuxEditor
		{
			get
			{
				if(r_PlinuxEditor == null)
				{
					r_PlinuxEditor = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "linuxEditor", -1);
					r_PlinuxEditor.SetBelong(null);
				}
				return r_PlinuxEditor;
			}
		}

		/// <summary>
		/// UnityEditor.ContainerWindow mainWindow
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RContainerWindow r_PmainWindow;
		public static Hvak.Editor.Refleaction.RUnityEditor.RContainerWindow RPmainWindow
		{
			get
			{
				if(r_PmainWindow == null)
				{
					r_PmainWindow = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "mainWindow", -1);
					r_PmainWindow.SetBelong(null);
				}
				return r_PmainWindow;
			}
		}

		/// <summary>
		/// Single buttonHorizontalSpace
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_PbuttonHorizontalSpace;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RPbuttonHorizontalSpace
		{
			get
			{
				if(r_PbuttonHorizontalSpace == null)
				{
					r_PbuttonHorizontalSpace = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "buttonHorizontalSpace", -1);
					r_PbuttonHorizontalSpace.SetBelong(null);
				}
				return r_PbuttonHorizontalSpace;
			}
		}

		/// <summary>
		/// Single buttonStackWidth
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_PbuttonStackWidth;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RPbuttonStackWidth
		{
			get
			{
				if(r_PbuttonStackWidth == null)
				{
					r_PbuttonStackWidth = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "buttonStackWidth", -1);
					r_PbuttonStackWidth.SetBelong(null);
				}
				return r_PbuttonStackWidth;
			}
		}

		/// <summary>
		/// UnityEditor.ShowMode showMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RShowMode r_PshowMode;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RShowMode RPshowMode
		{
			get
			{
				if(r_PshowMode == null)
				{
					r_PshowMode = new(this, "showMode", -1);
					r_PshowMode.SetBelong(this.instance);
				}
				return r_PshowMode;
			}
		}

		/// <summary>
		/// System.String windowID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PwindowID;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPwindowID
		{
			get
			{
				if(r_PwindowID == null)
				{
					r_PwindowID = new(this, "windowID", -1);
					r_PwindowID.SetBelong(this.instance);
				}
				return r_PwindowID;
			}
		}

		/// <summary>
		/// Boolean isPopup
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisPopup;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisPopup
		{
			get
			{
				if(r_PisPopup == null)
				{
					r_PisPopup = new(this, "isPopup", -1);
					r_PisPopup.SetBelong(this.instance);
				}
				return r_PisPopup;
			}
		}

		/// <summary>
		/// UnityEngine.Color skinBackgroundColor
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RColor r_PskinBackgroundColor;
		public static Hvak.Editor.Refleaction.RUnityEngine.RColor RPskinBackgroundColor
		{
			get
			{
				if(r_PskinBackgroundColor == null)
				{
					r_PskinBackgroundColor = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "skinBackgroundColor", -1);
					r_PskinBackgroundColor.SetBelong(null);
				}
				return r_PskinBackgroundColor;
			}
		}

		/// <summary>
		/// System.String displayedTitle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PdisplayedTitle;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPdisplayedTitle
		{
			get
			{
				if(r_PdisplayedTitle == null)
				{
					r_PdisplayedTitle = new(this, "displayedTitle", -1);
					r_PdisplayedTitle.SetBelong(this.instance);
				}
				return r_PdisplayedTitle;
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
					r_Ptitle.SetBelong(this.instance);
				}
				return r_Ptitle;
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
					r_PhasUnsavedChanges.SetBelong(this.instance);
				}
				return r_PhasUnsavedChanges;
			}
		}

		/// <summary>
		/// UnityEditor.ContainerWindow[] windows
		/// </summary>
		protected static Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.RContainerWindow> r_Pwindows;
		public static Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.RContainerWindow> RPwindows
		{
			get
			{
				if(r_Pwindows == null)
				{
					r_Pwindows = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "windows", -1);
					r_Pwindows.SetBelong(null);
				}
				return r_Pwindows;
			}
		}

		/// <summary>
		/// UnityEditor.View rootView
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RView r_ProotView;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RView RProotView
		{
			get
			{
				if(r_ProotView == null)
				{
					r_ProotView = new(this, "rootView", -1);
					r_ProotView.SetBelong(this.instance);
				}
				return r_ProotView;
			}
		}

		/// <summary>
		/// UnityEditor.SplitView rootSplitView
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RSplitView r_ProotSplitView;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RSplitView RProotSplitView
		{
			get
			{
				if(r_ProotSplitView == null)
				{
					r_ProotSplitView = new(this, "rootSplitView", -1);
					r_ProotSplitView.SetBelong(this.instance);
				}
				return r_ProotSplitView;
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
					r_Pname.SetBelong(this.instance);
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
					r_PhideFlags.SetBelong(this.instance);
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// Void SetAlpha(Single)
		/// </summary>
		protected RMethod r_MSetAlpha_Single;
		public virtual RMethod RMSetAlpha_Single
		{
			get
			{
				if(r_MSetAlpha_Single == null)
				{
					r_MSetAlpha_Single = new(this, "SetAlpha", 0, typeof(System.Single));
					r_MSetAlpha_Single.SetBelong(this.instance);
				}
				return r_MSetAlpha_Single;
			}
		}

		/// <summary>
		/// Void SetInvisible()
		/// </summary>
		protected RMethod r_MSetInvisible;
		public virtual RMethod RMSetInvisible
		{
			get
			{
				if(r_MSetInvisible == null)
				{
					r_MSetInvisible = new(this, "SetInvisible", 0);
					r_MSetInvisible.SetBelong(this.instance);
				}
				return r_MSetInvisible;
			}
		}

		/// <summary>
		/// Boolean IsZoomed()
		/// </summary>
		protected RMethod r_MIsZoomed;
		public virtual RMethod RMIsZoomed
		{
			get
			{
				if(r_MIsZoomed == null)
				{
					r_MIsZoomed = new(this, "IsZoomed", 0);
					r_MIsZoomed.SetBelong(this.instance);
				}
				return r_MIsZoomed;
			}
		}

		/// <summary>
		/// Void DisplayAllViews()
		/// </summary>
		protected RMethod r_MDisplayAllViews;
		public virtual RMethod RMDisplayAllViews
		{
			get
			{
				if(r_MDisplayAllViews == null)
				{
					r_MDisplayAllViews = new(this, "DisplayAllViews", 0);
					r_MDisplayAllViews.SetBelong(this.instance);
				}
				return r_MDisplayAllViews;
			}
		}

		/// <summary>
		/// Void Minimize()
		/// </summary>
		protected RMethod r_MMinimize;
		public virtual RMethod RMMinimize
		{
			get
			{
				if(r_MMinimize == null)
				{
					r_MMinimize = new(this, "Minimize", 0);
					r_MMinimize.SetBelong(this.instance);
				}
				return r_MMinimize;
			}
		}

		/// <summary>
		/// Void ToggleMaximize()
		/// </summary>
		protected RMethod r_MToggleMaximize;
		public virtual RMethod RMToggleMaximize
		{
			get
			{
				if(r_MToggleMaximize == null)
				{
					r_MToggleMaximize = new(this, "ToggleMaximize", 0);
					r_MToggleMaximize.SetBelong(this.instance);
				}
				return r_MToggleMaximize;
			}
		}

		/// <summary>
		/// Void MoveInFrontOf(UnityEditor.ContainerWindow)
		/// </summary>
		protected RMethod r_MMoveInFrontOf_ContainerWindow;
		public virtual RMethod RMMoveInFrontOf_ContainerWindow
		{
			get
			{
				if(r_MMoveInFrontOf_ContainerWindow == null)
				{
					r_MMoveInFrontOf_ContainerWindow = new(this, "MoveInFrontOf", 0,  ReflectionUtils.GetType("UnityEditor.ContainerWindow"));
					r_MMoveInFrontOf_ContainerWindow.SetBelong(this.instance);
				}
				return r_MMoveInFrontOf_ContainerWindow;
			}
		}

		/// <summary>
		/// Void MoveBehindOf(UnityEditor.ContainerWindow)
		/// </summary>
		protected RMethod r_MMoveBehindOf_ContainerWindow;
		public virtual RMethod RMMoveBehindOf_ContainerWindow
		{
			get
			{
				if(r_MMoveBehindOf_ContainerWindow == null)
				{
					r_MMoveBehindOf_ContainerWindow = new(this, "MoveBehindOf", 0,  ReflectionUtils.GetType("UnityEditor.ContainerWindow"));
					r_MMoveBehindOf_ContainerWindow.SetBelong(this.instance);
				}
				return r_MMoveBehindOf_ContainerWindow;
			}
		}

		/// <summary>
		/// UnityEngine.Rect FitWindowRectToScreen(UnityEngine.Rect, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MFitWindowRectToScreen_Rect_Boolean_Boolean;
		public virtual RMethod RMFitWindowRectToScreen_Rect_Boolean_Boolean
		{
			get
			{
				if(r_MFitWindowRectToScreen_Rect_Boolean_Boolean == null)
				{
					r_MFitWindowRectToScreen_Rect_Boolean_Boolean = new(this, "FitWindowRectToScreen", 0, typeof(UnityEngine.Rect), typeof(System.Boolean), typeof(System.Boolean));
					r_MFitWindowRectToScreen_Rect_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MFitWindowRectToScreen_Rect_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void SendCaptionEvent(Boolean)
		/// </summary>
		protected RMethod r_MSendCaptionEvent_Boolean;
		public virtual RMethod RMSendCaptionEvent_Boolean
		{
			get
			{
				if(r_MSendCaptionEvent_Boolean == null)
				{
					r_MSendCaptionEvent_Boolean = new(this, "SendCaptionEvent", 0, typeof(System.Boolean));
					r_MSendCaptionEvent_Boolean.SetBelong(this.instance);
				}
				return r_MSendCaptionEvent_Boolean;
			}
		}

		/// <summary>
		/// Void InternalClose()
		/// </summary>
		protected RMethod r_MInternalClose;
		public virtual RMethod RMInternalClose
		{
			get
			{
				if(r_MInternalClose == null)
				{
					r_MInternalClose = new(this, "InternalClose", 0);
					r_MInternalClose.SetBelong(this.instance);
				}
				return r_MInternalClose;
			}
		}

		/// <summary>
		/// Void Internal_SetMinMaxSizes(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MInternal_SetMinMaxSizes_Vector2_Vector2;
		public virtual RMethod RMInternal_SetMinMaxSizes_Vector2_Vector2
		{
			get
			{
				if(r_MInternal_SetMinMaxSizes_Vector2_Vector2 == null)
				{
					r_MInternal_SetMinMaxSizes_Vector2_Vector2 = new(this, "Internal_SetMinMaxSizes", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_MInternal_SetMinMaxSizes_Vector2_Vector2.SetBelong(this.instance);
				}
				return r_MInternal_SetMinMaxSizes_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Void Internal_Show(UnityEngine.Rect, Int32, UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MInternal_Show_Rect_Int32_Vector2_Vector2;
		public virtual RMethod RMInternal_Show_Rect_Int32_Vector2_Vector2
		{
			get
			{
				if(r_MInternal_Show_Rect_Int32_Vector2_Vector2 == null)
				{
					r_MInternal_Show_Rect_Int32_Vector2_Vector2 = new(this, "Internal_Show", 0, typeof(UnityEngine.Rect), typeof(System.Int32), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_MInternal_Show_Rect_Int32_Vector2_Vector2.SetBelong(this.instance);
				}
				return r_MInternal_Show_Rect_Int32_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Void Internal_BringLiveAfterCreation(Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MInternal_BringLiveAfterCreation_Boolean_Boolean_Boolean;
		public virtual RMethod RMInternal_BringLiveAfterCreation_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_MInternal_BringLiveAfterCreation_Boolean_Boolean_Boolean == null)
				{
					r_MInternal_BringLiveAfterCreation_Boolean_Boolean_Boolean = new(this, "Internal_BringLiveAfterCreation", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_MInternal_BringLiveAfterCreation_Boolean_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MInternal_BringLiveAfterCreation_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void Internal_SetTitle(System.String)
		/// </summary>
		protected RMethod r_MInternal_SetTitle_String;
		public virtual RMethod RMInternal_SetTitle_String
		{
			get
			{
				if(r_MInternal_SetTitle_String == null)
				{
					r_MInternal_SetTitle_String = new(this, "Internal_SetTitle", 0, typeof(System.String));
					r_MInternal_SetTitle_String.SetBelong(this.instance);
				}
				return r_MInternal_SetTitle_String;
			}
		}

		/// <summary>
		/// Void Internal_SetHasUnsavedChanges(Boolean)
		/// </summary>
		protected RMethod r_MInternal_SetHasUnsavedChanges_Boolean;
		public virtual RMethod RMInternal_SetHasUnsavedChanges_Boolean
		{
			get
			{
				if(r_MInternal_SetHasUnsavedChanges_Boolean == null)
				{
					r_MInternal_SetHasUnsavedChanges_Boolean = new(this, "Internal_SetHasUnsavedChanges", 0, typeof(System.Boolean));
					r_MInternal_SetHasUnsavedChanges_Boolean.SetBelong(this.instance);
				}
				return r_MInternal_SetHasUnsavedChanges_Boolean;
			}
		}

		/// <summary>
		/// Void SetBackgroundColor(UnityEngine.Color)
		/// </summary>
		protected RMethod r_MSetBackgroundColor_Color;
		public virtual RMethod RMSetBackgroundColor_Color
		{
			get
			{
				if(r_MSetBackgroundColor_Color == null)
				{
					r_MSetBackgroundColor_Color = new(this, "SetBackgroundColor", 0, typeof(UnityEngine.Color));
					r_MSetBackgroundColor_Color.SetBelong(this.instance);
				}
				return r_MSetBackgroundColor_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 Internal_GetTopleftScreenPosition()
		/// </summary>
		protected RMethod r_MInternal_GetTopleftScreenPosition;
		public virtual RMethod RMInternal_GetTopleftScreenPosition
		{
			get
			{
				if(r_MInternal_GetTopleftScreenPosition == null)
				{
					r_MInternal_GetTopleftScreenPosition = new(this, "Internal_GetTopleftScreenPosition", 0);
					r_MInternal_GetTopleftScreenPosition.SetBelong(this.instance);
				}
				return r_MInternal_GetTopleftScreenPosition;
			}
		}

		/// <summary>
		/// Void SetFreezeDisplay(Boolean)
		/// </summary>
		protected static RMethod r_MSetFreezeDisplay_Boolean;
		public static RMethod RMSetFreezeDisplay_Boolean
		{
			get
			{
				if(r_MSetFreezeDisplay_Boolean == null)
				{
					r_MSetFreezeDisplay_Boolean = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "SetFreezeDisplay", 0, typeof(System.Boolean));
					r_MSetFreezeDisplay_Boolean.SetBelong(null);
				}
				return r_MSetFreezeDisplay_Boolean;
			}
		}

		/// <summary>
		/// Void GetOrderedWindowList()
		/// </summary>
		protected static RMethod r_MGetOrderedWindowList;
		public static RMethod RMGetOrderedWindowList
		{
			get
			{
				if(r_MGetOrderedWindowList == null)
				{
					r_MGetOrderedWindowList = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "GetOrderedWindowList", 0);
					r_MGetOrderedWindowList.SetBelong(null);
				}
				return r_MGetOrderedWindowList;
			}
		}

		/// <summary>
		/// UnityEngine.Rect FitRectToScreen(UnityEngine.Rect, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_MFitRectToScreen_Rect_Boolean_Boolean;
		public static RMethod RMFitRectToScreen_Rect_Boolean_Boolean
		{
			get
			{
				if(r_MFitRectToScreen_Rect_Boolean_Boolean == null)
				{
					r_MFitRectToScreen_Rect_Boolean_Boolean = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "FitRectToScreen", 0, typeof(UnityEngine.Rect), typeof(System.Boolean), typeof(System.Boolean));
					r_MFitRectToScreen_Rect_Boolean_Boolean.SetBelong(null);
				}
				return r_MFitRectToScreen_Rect_Boolean_Boolean;
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
					r_M__internalAwake.SetBelong(this.instance);
				}
				return r_M__internalAwake;
			}
		}

		/// <summary>
		/// Boolean IsPopup(UnityEditor.ShowMode)
		/// </summary>
		protected static RMethod r_MIsPopup_ShowMode;
		public static RMethod RMIsPopup_ShowMode
		{
			get
			{
				if(r_MIsPopup_ShowMode == null)
				{
					r_MIsPopup_ShowMode = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "IsPopup", 0,  ReflectionUtils.GetType("UnityEditor.ShowMode"));
					r_MIsPopup_ShowMode.SetBelong(null);
				}
				return r_MIsPopup_ShowMode;
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
					r_MShowPopup.SetBelong(this.instance);
				}
				return r_MShowPopup;
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
					r_MShowTooltip.SetBelong(this.instance);
				}
				return r_MShowTooltip;
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
					r_MShowPopupWithMode_ShowMode_Boolean.SetBelong(this.instance);
				}
				return r_MShowPopupWithMode_ShowMode_Boolean;
			}
		}

		/// <summary>
		/// Void Show(UnityEditor.ShowMode, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MShow_ShowMode_Boolean_Boolean_Boolean;
		public virtual RMethod RMShow_ShowMode_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_MShow_ShowMode_Boolean_Boolean_Boolean == null)
				{
					r_MShow_ShowMode_Boolean_Boolean_Boolean = new(this, "Show", 0,  ReflectionUtils.GetType("UnityEditor.ShowMode"), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_MShow_ShowMode_Boolean_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MShow_ShowMode_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void FitWindowToScreen(Boolean)
		/// </summary>
		protected RMethod r_MFitWindowToScreen_Boolean;
		public virtual RMethod RMFitWindowToScreen_Boolean
		{
			get
			{
				if(r_MFitWindowToScreen_Boolean == null)
				{
					r_MFitWindowToScreen_Boolean = new(this, "FitWindowToScreen", 0, typeof(System.Boolean));
					r_MFitWindowToScreen_Boolean.SetBelong(this.instance);
				}
				return r_MFitWindowToScreen_Boolean;
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
					r_MOnEnable.SetBelong(this.instance);
				}
				return r_MOnEnable;
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
					r_MSetMinMaxSizes_Vector2_Vector2.SetBelong(this.instance);
				}
				return r_MSetMinMaxSizes_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Boolean InternalRequestCloseAll(Boolean)
		/// </summary>
		protected static RMethod r_MInternalRequestCloseAll_Boolean;
		public static RMethod RMInternalRequestCloseAll_Boolean
		{
			get
			{
				if(r_MInternalRequestCloseAll_Boolean == null)
				{
					r_MInternalRequestCloseAll_Boolean = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "InternalRequestCloseAll", 0, typeof(System.Boolean));
					r_MInternalRequestCloseAll_Boolean.SetBelong(null);
				}
				return r_MInternalRequestCloseAll_Boolean;
			}
		}

		/// <summary>
		/// Boolean InternalRequestClose()
		/// </summary>
		protected RMethod r_MInternalRequestClose;
		public virtual RMethod RMInternalRequestClose
		{
			get
			{
				if(r_MInternalRequestClose == null)
				{
					r_MInternalRequestClose = new(this, "InternalRequestClose", 0);
					r_MInternalRequestClose.SetBelong(this.instance);
				}
				return r_MInternalRequestClose;
			}
		}

		/// <summary>
		/// Boolean InternalRequestClose(UnityEditor.EditorWindow)
		/// </summary>
		protected RMethod r_MInternalRequestClose_EditorWindow;
		public virtual RMethod RMInternalRequestClose_EditorWindow
		{
			get
			{
				if(r_MInternalRequestClose_EditorWindow == null)
				{
					r_MInternalRequestClose_EditorWindow = new(this, "InternalRequestClose", 0, typeof(UnityEditor.EditorWindow));
					r_MInternalRequestClose_EditorWindow.SetBelong(this.instance);
				}
				return r_MInternalRequestClose_EditorWindow;
			}
		}

		/// <summary>
		/// Boolean InternalRequestCloseAllExcept(UnityEditor.EditorWindow)
		/// </summary>
		protected RMethod r_MInternalRequestCloseAllExcept_EditorWindow;
		public virtual RMethod RMInternalRequestCloseAllExcept_EditorWindow
		{
			get
			{
				if(r_MInternalRequestCloseAllExcept_EditorWindow == null)
				{
					r_MInternalRequestCloseAllExcept_EditorWindow = new(this, "InternalRequestCloseAllExcept", 0, typeof(UnityEditor.EditorWindow));
					r_MInternalRequestCloseAllExcept_EditorWindow.SetBelong(this.instance);
				}
				return r_MInternalRequestCloseAllExcept_EditorWindow;
			}
		}

		/// <summary>
		/// Boolean PrivateRequestClose(System.Collections.Generic.List`1[UnityEditor.EditorWindow])
		/// </summary>
		protected static RMethod r_MPrivateRequestClose_List_d_EditorWindow_p_;
		public static RMethod RMPrivateRequestClose_List_d_EditorWindow_p_
		{
			get
			{
				if(r_MPrivateRequestClose_List_d_EditorWindow_p_ == null)
				{
					r_MPrivateRequestClose_List_d_EditorWindow_p_ = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "PrivateRequestClose", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEditor.EditorWindow)));
					r_MPrivateRequestClose_List_d_EditorWindow_p_.SetBelong(null);
				}
				return r_MPrivateRequestClose_List_d_EditorWindow_p_;
			}
		}

		/// <summary>
		/// Void InternalCloseWindow()
		/// </summary>
		protected RMethod r_MInternalCloseWindow;
		public virtual RMethod RMInternalCloseWindow
		{
			get
			{
				if(r_MInternalCloseWindow == null)
				{
					r_MInternalCloseWindow = new(this, "InternalCloseWindow", 0);
					r_MInternalCloseWindow.SetBelong(this.instance);
				}
				return r_MInternalCloseWindow;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.EditorWindow] FindUnsavedChanges(UnityEditor.View)
		/// </summary>
		protected static RMethod r_MFindUnsavedChanges_View;
		public static RMethod RMFindUnsavedChanges_View
		{
			get
			{
				if(r_MFindUnsavedChanges_View == null)
				{
					r_MFindUnsavedChanges_View = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "FindUnsavedChanges", 0,  ReflectionUtils.GetType("UnityEditor.View"));
					r_MFindUnsavedChanges_View.SetBelong(null);
				}
				return r_MFindUnsavedChanges_View;
			}
		}

		/// <summary>
		/// Void UnsavedStateChanged()
		/// </summary>
		protected RMethod r_MUnsavedStateChanged;
		public virtual RMethod RMUnsavedStateChanged
		{
			get
			{
				if(r_MUnsavedStateChanged == null)
				{
					r_MUnsavedStateChanged = new(this, "UnsavedStateChanged", 0);
					r_MUnsavedStateChanged.SetBelong(this.instance);
				}
				return r_MUnsavedStateChanged;
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
					r_MClose.SetBelong(this.instance);
				}
				return r_MClose;
			}
		}

		/// <summary>
		/// Boolean IsNotDocked()
		/// </summary>
		protected RMethod r_MIsNotDocked;
		public virtual RMethod RMIsNotDocked
		{
			get
			{
				if(r_MIsNotDocked == null)
				{
					r_MIsNotDocked = new(this, "IsNotDocked", 0);
					r_MIsNotDocked.SetBelong(this.instance);
				}
				return r_MIsNotDocked;
			}
		}

		/// <summary>
		/// System.String GetWindowID()
		/// </summary>
		protected RMethod r_MGetWindowID;
		public virtual RMethod RMGetWindowID
		{
			get
			{
				if(r_MGetWindowID == null)
				{
					r_MGetWindowID = new(this, "GetWindowID", 0);
					r_MGetWindowID.SetBelong(this.instance);
				}
				return r_MGetWindowID;
			}
		}

		/// <summary>
		/// Boolean IsMainWindow()
		/// </summary>
		protected RMethod r_MIsMainWindow;
		public virtual RMethod RMIsMainWindow
		{
			get
			{
				if(r_MIsMainWindow == null)
				{
					r_MIsMainWindow = new(this, "IsMainWindow", 0);
					r_MIsMainWindow.SetBelong(this.instance);
				}
				return r_MIsMainWindow;
			}
		}

		/// <summary>
		/// Void SaveGeometry()
		/// </summary>
		protected RMethod r_MSaveGeometry;
		public virtual RMethod RMSaveGeometry
		{
			get
			{
				if(r_MSaveGeometry == null)
				{
					r_MSaveGeometry = new(this, "SaveGeometry", 0);
					r_MSaveGeometry.SetBelong(this.instance);
				}
				return r_MSaveGeometry;
			}
		}

		/// <summary>
		/// Void Save()
		/// </summary>
		protected RMethod r_MSave;
		public virtual RMethod RMSave
		{
			get
			{
				if(r_MSave == null)
				{
					r_MSave = new(this, "Save", 0);
					r_MSave.SetBelong(this.instance);
				}
				return r_MSave;
			}
		}

		/// <summary>
		/// Void LoadGeometry(Boolean)
		/// </summary>
		protected RMethod r_MLoadGeometry_Boolean;
		public virtual RMethod RMLoadGeometry_Boolean
		{
			get
			{
				if(r_MLoadGeometry_Boolean == null)
				{
					r_MLoadGeometry_Boolean = new(this, "LoadGeometry", 0, typeof(System.Boolean));
					r_MLoadGeometry_Boolean.SetBelong(this.instance);
				}
				return r_MLoadGeometry_Boolean;
			}
		}

		/// <summary>
		/// Void LoadInCurrentMousePosition()
		/// </summary>
		protected RMethod r_MLoadInCurrentMousePosition;
		public virtual RMethod RMLoadInCurrentMousePosition
		{
			get
			{
				if(r_MLoadInCurrentMousePosition == null)
				{
					r_MLoadInCurrentMousePosition = new(this, "LoadInCurrentMousePosition", 0);
					r_MLoadInCurrentMousePosition.SetBelong(this.instance);
				}
				return r_MLoadInCurrentMousePosition;
			}
		}

		/// <summary>
		/// Void Load(Boolean)
		/// </summary>
		protected RMethod r_MLoad_Boolean;
		public virtual RMethod RMLoad_Boolean
		{
			get
			{
				if(r_MLoad_Boolean == null)
				{
					r_MLoad_Boolean = new(this, "Load", 0, typeof(System.Boolean));
					r_MLoad_Boolean.SetBelong(this.instance);
				}
				return r_MLoad_Boolean;
			}
		}

		/// <summary>
		/// Void OnResize()
		/// </summary>
		protected RMethod r_MOnResize;
		public virtual RMethod RMOnResize
		{
			get
			{
				if(r_MOnResize == null)
				{
					r_MOnResize = new(this, "OnResize", 0);
					r_MOnResize.SetBelong(this.instance);
				}
				return r_MOnResize;
			}
		}

		/// <summary>
		/// Void UpdateTitle()
		/// </summary>
		protected RMethod r_MUpdateTitle;
		public virtual RMethod RMUpdateTitle
		{
			get
			{
				if(r_MUpdateTitle == null)
				{
					r_MUpdateTitle = new(this, "UpdateTitle", 0);
					r_MUpdateTitle.SetBelong(this.instance);
				}
				return r_MUpdateTitle;
			}
		}

		/// <summary>
		/// Void AddToWindowList()
		/// </summary>
		protected RMethod r_MAddToWindowList;
		public virtual RMethod RMAddToWindowList
		{
			get
			{
				if(r_MAddToWindowList == null)
				{
					r_MAddToWindowList = new(this, "AddToWindowList", 0);
					r_MAddToWindowList.SetBelong(this.instance);
				}
				return r_MAddToWindowList;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 WindowToScreenPoint(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MWindowToScreenPoint_Vector2;
		public virtual RMethod RMWindowToScreenPoint_Vector2
		{
			get
			{
				if(r_MWindowToScreenPoint_Vector2 == null)
				{
					r_MWindowToScreenPoint_Vector2 = new(this, "WindowToScreenPoint", 0, typeof(UnityEngine.Vector2));
					r_MWindowToScreenPoint_Vector2.SetBelong(this.instance);
				}
				return r_MWindowToScreenPoint_Vector2;
			}
		}

		/// <summary>
		/// System.String DebugHierarchy()
		/// </summary>
		protected RMethod r_MDebugHierarchy;
		public virtual RMethod RMDebugHierarchy
		{
			get
			{
				if(r_MDebugHierarchy == null)
				{
					r_MDebugHierarchy = new(this, "DebugHierarchy", 0);
					r_MDebugHierarchy.SetBelong(this.instance);
				}
				return r_MDebugHierarchy;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetDropDownRect(UnityEngine.Rect, UnityEngine.Vector2, UnityEngine.Vector2, UnityEditor.PopupLocation[])
		/// </summary>
		protected RMethod r_MGetDropDownRect_Rect_Vector2_Vector2_PopupLocationArray;
		public virtual RMethod RMGetDropDownRect_Rect_Vector2_Vector2_PopupLocationArray
		{
			get
			{
				if(r_MGetDropDownRect_Rect_Vector2_Vector2_PopupLocationArray == null)
				{
					r_MGetDropDownRect_Rect_Vector2_Vector2_PopupLocationArray = new(this, "GetDropDownRect", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2),  ReflectionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType());
					r_MGetDropDownRect_Rect_Vector2_Vector2_PopupLocationArray.SetBelong(this.instance);
				}
				return r_MGetDropDownRect_Rect_Vector2_Vector2_PopupLocationArray;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetDropDownRect(UnityEngine.Rect, UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MGetDropDownRect_Rect_Vector2_Vector2;
		public virtual RMethod RMGetDropDownRect_Rect_Vector2_Vector2
		{
			get
			{
				if(r_MGetDropDownRect_Rect_Vector2_Vector2 == null)
				{
					r_MGetDropDownRect_Rect_Vector2_Vector2 = new(this, "GetDropDownRect", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_MGetDropDownRect_Rect_Vector2_Vector2.SetBelong(this.instance);
				}
				return r_MGetDropDownRect_Rect_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Void HandleWindowDecorationEnd(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MHandleWindowDecorationEnd_Rect;
		public virtual RMethod RMHandleWindowDecorationEnd_Rect
		{
			get
			{
				if(r_MHandleWindowDecorationEnd_Rect == null)
				{
					r_MHandleWindowDecorationEnd_Rect = new(this, "HandleWindowDecorationEnd", 0, typeof(UnityEngine.Rect));
					r_MHandleWindowDecorationEnd_Rect.SetBelong(this.instance);
				}
				return r_MHandleWindowDecorationEnd_Rect;
			}
		}

		/// <summary>
		/// Void HandleWindowDecorationStart(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MHandleWindowDecorationStart_Rect;
		public virtual RMethod RMHandleWindowDecorationStart_Rect
		{
			get
			{
				if(r_MHandleWindowDecorationStart_Rect == null)
				{
					r_MHandleWindowDecorationStart_Rect = new(this, "HandleWindowDecorationStart", 0, typeof(UnityEngine.Rect));
					r_MHandleWindowDecorationStart_Rect.SetBelong(this.instance);
				}
				return r_MHandleWindowDecorationStart_Rect;
			}
		}

		/// <summary>
		/// Void BeginTitleBarButtons(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MBeginTitleBarButtons_Rect;
		public virtual RMethod RMBeginTitleBarButtons_Rect
		{
			get
			{
				if(r_MBeginTitleBarButtons_Rect == null)
				{
					r_MBeginTitleBarButtons_Rect = new(this, "BeginTitleBarButtons", 0, typeof(UnityEngine.Rect));
					r_MBeginTitleBarButtons_Rect.SetBelong(this.instance);
				}
				return r_MBeginTitleBarButtons_Rect;
			}
		}

		/// <summary>
		/// Boolean TitleBarButton(UnityEngine.GUIStyle)
		/// </summary>
		protected RMethod r_MTitleBarButton_GUIStyle;
		public virtual RMethod RMTitleBarButton_GUIStyle
		{
			get
			{
				if(r_MTitleBarButton_GUIStyle == null)
				{
					r_MTitleBarButton_GUIStyle = new(this, "TitleBarButton", 0, typeof(UnityEngine.GUIStyle));
					r_MTitleBarButton_GUIStyle.SetBelong(this.instance);
				}
				return r_MTitleBarButton_GUIStyle;
			}
		}

		/// <summary>
		/// Void DragTitleBar(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MDragTitleBar_Rect;
		public virtual RMethod RMDragTitleBar_Rect
		{
			get
			{
				if(r_MDragTitleBar_Rect == null)
				{
					r_MDragTitleBar_Rect = new(this, "DragTitleBar", 0, typeof(UnityEngine.Rect));
					r_MDragTitleBar_Rect.SetBelong(this.instance);
				}
				return r_MDragTitleBar_Rect;
			}
		}

		/// <summary>
		/// Void get_position_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_Mget_position_Injected_Out_Rect;
		public virtual RMethod RMget_position_Injected_Out_Rect
		{
			get
			{
				if(r_Mget_position_Injected_Out_Rect == null)
				{
					r_Mget_position_Injected_Out_Rect = new(this, "get_position_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_Mget_position_Injected_Out_Rect.SetBelong(this.instance);
				}
				return r_Mget_position_Injected_Out_Rect;
			}
		}

		/// <summary>
		/// Void set_position_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_Mset_position_Injected_Ref_Rect;
		public virtual RMethod RMset_position_Injected_Ref_Rect
		{
			get
			{
				if(r_Mset_position_Injected_Ref_Rect == null)
				{
					r_Mset_position_Injected_Ref_Rect = new(this, "set_position_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_Mset_position_Injected_Ref_Rect.SetBelong(this.instance);
				}
				return r_Mset_position_Injected_Ref_Rect;
			}
		}

		/// <summary>
		/// Void FitWindowRectToScreen_Injected(UnityEngine.Rect ByRef, Boolean, Boolean, UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_MFitWindowRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect;
		public virtual RMethod RMFitWindowRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect
		{
			get
			{
				if(r_MFitWindowRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect == null)
				{
					r_MFitWindowRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect = new(this, "FitWindowRectToScreen_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(System.Boolean), typeof(System.Boolean), typeof(UnityEngine.Rect).MakeByRefType());
					r_MFitWindowRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect.SetBelong(this.instance);
				}
				return r_MFitWindowRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect;
			}
		}

		/// <summary>
		/// Void Internal_SetMinMaxSizes_Injected(UnityEngine.Vector2 ByRef, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_MInternal_SetMinMaxSizes_Injected_Ref_Vector2_Ref_Vector2;
		public virtual RMethod RMInternal_SetMinMaxSizes_Injected_Ref_Vector2_Ref_Vector2
		{
			get
			{
				if(r_MInternal_SetMinMaxSizes_Injected_Ref_Vector2_Ref_Vector2 == null)
				{
					r_MInternal_SetMinMaxSizes_Injected_Ref_Vector2_Ref_Vector2 = new(this, "Internal_SetMinMaxSizes_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType(), typeof(UnityEngine.Vector2).MakeByRefType());
					r_MInternal_SetMinMaxSizes_Injected_Ref_Vector2_Ref_Vector2.SetBelong(this.instance);
				}
				return r_MInternal_SetMinMaxSizes_Injected_Ref_Vector2_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void Internal_Show_Injected(UnityEngine.Rect ByRef, Int32, UnityEngine.Vector2 ByRef, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_MInternal_Show_Injected_Ref_Rect_Int32_Ref_Vector2_Ref_Vector2;
		public virtual RMethod RMInternal_Show_Injected_Ref_Rect_Int32_Ref_Vector2_Ref_Vector2
		{
			get
			{
				if(r_MInternal_Show_Injected_Ref_Rect_Int32_Ref_Vector2_Ref_Vector2 == null)
				{
					r_MInternal_Show_Injected_Ref_Rect_Int32_Ref_Vector2_Ref_Vector2 = new(this, "Internal_Show_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(System.Int32), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(UnityEngine.Vector2).MakeByRefType());
					r_MInternal_Show_Injected_Ref_Rect_Int32_Ref_Vector2_Ref_Vector2.SetBelong(this.instance);
				}
				return r_MInternal_Show_Injected_Ref_Rect_Int32_Ref_Vector2_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void SetBackgroundColor_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_MSetBackgroundColor_Injected_Ref_Color;
		public virtual RMethod RMSetBackgroundColor_Injected_Ref_Color
		{
			get
			{
				if(r_MSetBackgroundColor_Injected_Ref_Color == null)
				{
					r_MSetBackgroundColor_Injected_Ref_Color = new(this, "SetBackgroundColor_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
					r_MSetBackgroundColor_Injected_Ref_Color.SetBelong(this.instance);
				}
				return r_MSetBackgroundColor_Injected_Ref_Color;
			}
		}

		/// <summary>
		/// Void Internal_GetTopleftScreenPosition_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_MInternal_GetTopleftScreenPosition_Injected_Out_Vector2;
		public virtual RMethod RMInternal_GetTopleftScreenPosition_Injected_Out_Vector2
		{
			get
			{
				if(r_MInternal_GetTopleftScreenPosition_Injected_Out_Vector2 == null)
				{
					r_MInternal_GetTopleftScreenPosition_Injected_Out_Vector2 = new(this, "Internal_GetTopleftScreenPosition_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_MInternal_GetTopleftScreenPosition_Injected_Out_Vector2.SetBelong(this.instance);
				}
				return r_MInternal_GetTopleftScreenPosition_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void FitRectToScreen_Injected(UnityEngine.Rect ByRef, Boolean, Boolean, UnityEngine.Rect ByRef)
		/// </summary>
		protected static RMethod r_MFitRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect;
		public static RMethod RMFitRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect
		{
			get
			{
				if(r_MFitRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect == null)
				{
					r_MFitRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect = new( ReflectionUtils.GetType("UnityEditor.ContainerWindow"), "FitRectToScreen_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(System.Boolean), typeof(System.Boolean), typeof(UnityEngine.Rect).MakeByRefType());
					r_MFitRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect.SetBelong(null);
				}
				return r_MFitRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect;
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
					r_MSetDirty.SetBelong(this.instance);
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
					r_MGetInstanceID.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
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

        public virtual void SetAlpha(System.Single @alpha)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alpha};
            var ___result = RMSetAlpha_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInvisible()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetInvisible.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsZoomed()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsZoomed.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void DisplayAllViews()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDisplayAllViews.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Minimize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMinimize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ToggleMaximize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToggleMaximize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveInFrontOf(Hvak.Editor.Refleaction.RUnityEditor.RContainerWindow @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMMoveInFrontOf_ContainerWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveBehindOf(Hvak.Editor.Refleaction.RUnityEditor.RContainerWindow @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMMoveBehindOf_ContainerWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect FitWindowRectToScreen(UnityEngine.Rect @r, System.Boolean @forceCompletelyVisible, System.Boolean @useMouseScreen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r, @forceCompletelyVisible, @useMouseScreen};
            var ___result = RMFitWindowRectToScreen_Rect_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void SendCaptionEvent(System.Boolean @mouseDown)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mouseDown};
            var ___result = RMSendCaptionEvent_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalClose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternalClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetMinMaxSizes(UnityEngine.Vector2 @minSize, UnityEngine.Vector2 @maxSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@minSize, @maxSize};
            var ___result = RMInternal_SetMinMaxSizes_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_Show(UnityEngine.Rect @r, System.Int32 @showMode, UnityEngine.Vector2 @minSize, UnityEngine.Vector2 @maxSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r, @showMode, @minSize, @maxSize};
            var ___result = RMInternal_Show_Rect_Int32_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_BringLiveAfterCreation(System.Boolean @displayImmediately, System.Boolean @setFocus, System.Boolean @showMaximized)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@displayImmediately, @setFocus, @showMaximized};
            var ___result = RMInternal_BringLiveAfterCreation_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetTitle(System.String @title)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@title};
            var ___result = RMInternal_SetTitle_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetHasUnsavedChanges(System.Boolean @hasUnsavedChanges)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hasUnsavedChanges};
            var ___result = RMInternal_SetHasUnsavedChanges_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBackgroundColor(UnityEngine.Color @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color};
            var ___result = RMSetBackgroundColor_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 Internal_GetTopleftScreenPosition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternal_GetTopleftScreenPosition.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static void SetFreezeDisplay(System.Boolean @freeze)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@freeze};
            var ___result = RMSetFreezeDisplay_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void GetOrderedWindowList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetOrderedWindowList.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Rect FitRectToScreen(UnityEngine.Rect @defaultRect, System.Boolean @forceCompletelyVisible, System.Boolean @useMouseScreen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@defaultRect, @forceCompletelyVisible, @useMouseScreen};
            var ___result = RMFitRectToScreen_Rect_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void __internalAwake()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RM__internalAwake.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsPopup(Hvak.Editor.Refleaction.RUnityEditor.RShowMode @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mode.Value};
            var ___result = RMIsPopup_ShowMode.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ShowPopup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShowPopup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowTooltip()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShowTooltip.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowPopupWithMode(Hvak.Editor.Refleaction.RUnityEditor.RShowMode @mode, System.Boolean @giveFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mode.Value, @giveFocus};
            var ___result = RMShowPopupWithMode_ShowMode_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Show(Hvak.Editor.Refleaction.RUnityEditor.RShowMode @showMode, System.Boolean @loadPosition, System.Boolean @displayImmediately, System.Boolean @setFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@showMode.Value, @loadPosition, @displayImmediately, @setFocus};
            var ___result = RMShow_ShowMode_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FitWindowToScreen(System.Boolean @useMousePos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@useMousePos};
            var ___result = RMFitWindowToScreen_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnEnable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnEnable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMinMaxSizes(UnityEngine.Vector2 @min, UnityEngine.Vector2 @max)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@min, @max};
            var ___result = RMSetMinMaxSizes_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean InternalRequestCloseAll(System.Boolean @keepMainWindow)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keepMainWindow};
            var ___result = RMInternalRequestCloseAll_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean InternalRequestClose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternalRequestClose.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean InternalRequestClose(UnityEditor.EditorWindow @dockedTab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dockedTab};
            var ___result = RMInternalRequestClose_EditorWindow.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean InternalRequestCloseAllExcept(UnityEditor.EditorWindow @editorWindow)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editorWindow};
            var ___result = RMInternalRequestCloseAllExcept_EditorWindow.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean PrivateRequestClose(System.Collections.Generic.List<UnityEditor.EditorWindow> @allUnsaved)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@allUnsaved};
            var ___result = RMPrivateRequestClose_List_d_EditorWindow_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void InternalCloseWindow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternalCloseWindow.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Collections.Generic.List<UnityEditor.EditorWindow> FindUnsavedChanges(Hvak.Editor.Refleaction.RUnityEditor.RView @view)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@view.Value};
            var ___result = RMFindUnsavedChanges_View.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<UnityEditor.EditorWindow>)___result;
        }


        public virtual void UnsavedStateChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUnsavedStateChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsNotDocked()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsNotDocked.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String GetWindowID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetWindowID.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean IsMainWindow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsMainWindow.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SaveGeometry()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSaveGeometry.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Save()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSave.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadGeometry(System.Boolean @loadPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@loadPosition};
            var ___result = RMLoadGeometry_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadInCurrentMousePosition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMLoadInCurrentMousePosition.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Load(System.Boolean @loadPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@loadPosition};
            var ___result = RMLoad_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnResize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnResize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateTitle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateTitle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddToWindowList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAddToWindowList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 WindowToScreenPoint(UnityEngine.Vector2 @windowPoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowPoint};
            var ___result = RMWindowToScreenPoint_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.String DebugHierarchy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDebugHierarchy.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual UnityEngine.Rect GetDropDownRect(UnityEngine.Rect @buttonRect, UnityEngine.Vector2 @minSize, UnityEngine.Vector2 @maxSize, Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.RPopupLocation> @locationPriorityOrder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect, @minSize, @maxSize, @locationPriorityOrder.Value};
            var ___result = RMGetDropDownRect_Rect_Vector2_Vector2_PopupLocationArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual UnityEngine.Rect GetDropDownRect(UnityEngine.Rect @buttonRect, UnityEngine.Vector2 @minSize, UnityEngine.Vector2 @maxSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect, @minSize, @maxSize};
            var ___result = RMGetDropDownRect_Rect_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void HandleWindowDecorationEnd(UnityEngine.Rect @windowPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowPosition};
            var ___result = RMHandleWindowDecorationEnd_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleWindowDecorationStart(UnityEngine.Rect @windowPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowPosition};
            var ___result = RMHandleWindowDecorationStart_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginTitleBarButtons(UnityEngine.Rect @windowPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowPosition};
            var ___result = RMBeginTitleBarButtons_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TitleBarButton(UnityEngine.GUIStyle @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style};
            var ___result = RMTitleBarButton_GUIStyle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void DragTitleBar(UnityEngine.Rect @titleBarRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@titleBarRect};
            var ___result = RMDragTitleBar_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void get_position_Injected(out UnityEngine.Rect @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_position_Injected_Out_Rect.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void set_position_Injected(ref UnityEngine.Rect @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_position_Injected_Ref_Rect.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void FitWindowRectToScreen_Injected(ref UnityEngine.Rect @r, System.Boolean @forceCompletelyVisible, System.Boolean @useMouseScreen, out UnityEngine.Rect @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r, @forceCompletelyVisible, @useMouseScreen, @ret};
            var ___result = RMFitWindowRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect.Invoke(___genericsType, ___parameters);
			@r = (UnityEngine.Rect)___parameters[0];
			@ret = (UnityEngine.Rect)___parameters[3];

            
        }


        public virtual void Internal_SetMinMaxSizes_Injected(ref UnityEngine.Vector2 @minSize, ref UnityEngine.Vector2 @maxSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@minSize, @maxSize};
            var ___result = RMInternal_SetMinMaxSizes_Injected_Ref_Vector2_Ref_Vector2.Invoke(___genericsType, ___parameters);
			@minSize = (UnityEngine.Vector2)___parameters[0];
			@maxSize = (UnityEngine.Vector2)___parameters[1];

            
        }


        public virtual void Internal_Show_Injected(ref UnityEngine.Rect @r, System.Int32 @showMode, ref UnityEngine.Vector2 @minSize, ref UnityEngine.Vector2 @maxSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r, @showMode, @minSize, @maxSize};
            var ___result = RMInternal_Show_Injected_Ref_Rect_Int32_Ref_Vector2_Ref_Vector2.Invoke(___genericsType, ___parameters);
			@r = (UnityEngine.Rect)___parameters[0];
			@minSize = (UnityEngine.Vector2)___parameters[2];
			@maxSize = (UnityEngine.Vector2)___parameters[3];

            
        }


        public virtual void SetBackgroundColor_Injected(ref UnityEngine.Color @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color};
            var ___result = RMSetBackgroundColor_Injected_Ref_Color.Invoke(___genericsType, ___parameters);
			@color = (UnityEngine.Color)___parameters[0];

            
        }


        public virtual void Internal_GetTopleftScreenPosition_Injected(out UnityEngine.Vector2 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMInternal_GetTopleftScreenPosition_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public static void FitRectToScreen_Injected(ref UnityEngine.Rect @defaultRect, System.Boolean @forceCompletelyVisible, System.Boolean @useMouseScreen, out UnityEngine.Rect @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@defaultRect, @forceCompletelyVisible, @useMouseScreen, @ret};
            var ___result = RMFitRectToScreen_Injected_Ref_Rect_Boolean_Boolean_Out_Rect.Invoke(___genericsType, ___parameters);
			@defaultRect = (UnityEngine.Rect)___parameters[0];
			@ret = (UnityEngine.Rect)___parameters[3];

            
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
