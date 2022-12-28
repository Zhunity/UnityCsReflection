using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.GUIView
	/// </summary>
    public partial class RGUIView : RMember //
    {

		/// <summary>
		/// System.Action`1[UnityEditor.GUIView] positionChanged
		/// </summary>
		protected static RSystem.RAction<RUnityEditor.RGUIView> r_positionChanged;
		public static RSystem.RAction<RUnityEditor.RGUIView> RpositionChanged
		{
			get
			{
				if(r_positionChanged == null)
				{
					r_positionChanged = new( ReleactionUtils.GetType("UnityEditor.GUIView"), "positionChanged");
					r_positionChanged.SetBelong(null);
				}
				return r_positionChanged;
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
		/// UnityEditor.IWindowBackend m_WindowBackend
		/// </summary>
		protected RUnityEditor.RIWindowBackend r_m_WindowBackend;
		public virtual RUnityEditor.RIWindowBackend Rm_WindowBackend
		{
			get
			{
				if(r_m_WindowBackend == null)
				{
					r_m_WindowBackend = new(this, "m_WindowBackend");
					r_m_WindowBackend.SetBelong(this.instance);
				}
				return r_m_WindowBackend;
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
		/// UnityEditor.GUIView current
		/// </summary>
		protected static RUnityEditor.RGUIView r_current;
		public static RUnityEditor.RGUIView Rcurrent
		{
			get
			{
				if(r_current == null)
				{
					r_current = new( ReleactionUtils.GetType("UnityEditor.GUIView"), "current", -1);
					r_current.SetBelong(null);
				}
				return r_current;
			}
		}

		/// <summary>
		/// UnityEditor.GUIView focusedView
		/// </summary>
		protected static RUnityEditor.RGUIView r_focusedView;
		public static RUnityEditor.RGUIView RfocusedView
		{
			get
			{
				if(r_focusedView == null)
				{
					r_focusedView = new( ReleactionUtils.GetType("UnityEditor.GUIView"), "focusedView", -1);
					r_focusedView.SetBelong(null);
				}
				return r_focusedView;
			}
		}

		/// <summary>
		/// UnityEditor.GUIView mouseOverView
		/// </summary>
		protected static RUnityEditor.RGUIView r_mouseOverView;
		public static RUnityEditor.RGUIView RmouseOverView
		{
			get
			{
				if(r_mouseOverView == null)
				{
					r_mouseOverView = new( ReleactionUtils.GetType("UnityEditor.GUIView"), "mouseOverView", -1);
					r_mouseOverView.SetBelong(null);
				}
				return r_mouseOverView;
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
		/// UnityEngine.Vector2 UnityEditor.IWindowModel.size
		/// </summary>
		protected RUnityEngine.RVector2 r_RUnityEditor__0__IWindowModel__0__get_size;
		public virtual RUnityEngine.RVector2 RUnityEditor__0__IWindowModel__0__get_size
		{
			get
			{
				if(r_RUnityEditor__0__IWindowModel__0__get_size == null)
				{
					r_RUnityEditor__0__IWindowModel__0__get_size = new(this, "UnityEditor.IWindowModel.size", -1);
					r_RUnityEditor__0__IWindowModel__0__get_size.SetBelong(this.instance);
				}
				return r_RUnityEditor__0__IWindowModel__0__get_size;
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
		/// System.Action UnityEditor.IWindowModel.onGUIHandler
		/// </summary>
		protected RSystem.RAction r_RUnityEditor__0__IWindowModel__0__get_onGUIHandler;
		public virtual RSystem.RAction RUnityEditor__0__IWindowModel__0__get_onGUIHandler
		{
			get
			{
				if(r_RUnityEditor__0__IWindowModel__0__get_onGUIHandler == null)
				{
					r_RUnityEditor__0__IWindowModel__0__get_onGUIHandler = new(this, "UnityEditor.IWindowModel.onGUIHandler", -1);
					r_RUnityEditor__0__IWindowModel__0__get_onGUIHandler.SetBelong(this.instance);
				}
				return r_RUnityEditor__0__IWindowModel__0__get_onGUIHandler;
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
		/// UnityEditor.IWindowBackend UnityEditor.IWindowModel.windowBackend
		/// </summary>
		protected RUnityEditor.RIWindowBackend r_RUnityEditor__0__IWindowModel__0__get_windowBackend;
		public virtual RUnityEditor.RIWindowBackend RUnityEditor__0__IWindowModel__0__get_windowBackend
		{
			get
			{
				if(r_RUnityEditor__0__IWindowModel__0__get_windowBackend == null)
				{
					r_RUnityEditor__0__IWindowModel__0__get_windowBackend = new(this, "UnityEditor.IWindowModel.windowBackend", -1);
					r_RUnityEditor__0__IWindowModel__0__get_windowBackend.SetBelong(this.instance);
				}
				return r_RUnityEditor__0__IWindowModel__0__get_windowBackend;
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
		/// Void Internal_Init(Int32, Int32)
		/// </summary>
		protected RMethod r_RInternal_Init_Int32_Int32;
		public virtual RMethod RInternal_Init_Int32_Int32
		{
			get
			{
				if(r_RInternal_Init_Int32_Int32 == null)
				{
					r_RInternal_Init_Int32_Int32 = new(this, "Internal_Init", 0, typeof(System.Int32), typeof(System.Int32));
					r_RInternal_Init_Int32_Int32.SetBelong(this.instance);
				}
				return r_RInternal_Init_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_Recreate(Int32, Int32)
		/// </summary>
		protected RMethod r_RInternal_Recreate_Int32_Int32;
		public virtual RMethod RInternal_Recreate_Int32_Int32
		{
			get
			{
				if(r_RInternal_Recreate_Int32_Int32 == null)
				{
					r_RInternal_Recreate_Int32_Int32 = new(this, "Internal_Recreate", 0, typeof(System.Int32), typeof(System.Int32));
					r_RInternal_Recreate_Int32_Int32.SetBelong(this.instance);
				}
				return r_RInternal_Recreate_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_Close()
		/// </summary>
		protected RMethod r_RInternal_Close;
		public virtual RMethod RInternal_Close
		{
			get
			{
				if(r_RInternal_Close == null)
				{
					r_RInternal_Close = new(this, "Internal_Close", 0);
					r_RInternal_Close.SetBelong(this.instance);
				}
				return r_RInternal_Close;
			}
		}

		/// <summary>
		/// Boolean Internal_SendEvent(UnityEngine.Event)
		/// </summary>
		protected RMethod r_RInternal_SendEvent_Event;
		public virtual RMethod RInternal_SendEvent_Event
		{
			get
			{
				if(r_RInternal_SendEvent_Event == null)
				{
					r_RInternal_SendEvent_Event = new(this, "Internal_SendEvent", 0, typeof(UnityEngine.Event));
					r_RInternal_SendEvent_Event.SetBelong(this.instance);
				}
				return r_RInternal_SendEvent_Event;
			}
		}

		/// <summary>
		/// Void Internal_SetWantsMouseMove(Boolean)
		/// </summary>
		protected RMethod r_RInternal_SetWantsMouseMove_Boolean;
		public virtual RMethod RInternal_SetWantsMouseMove_Boolean
		{
			get
			{
				if(r_RInternal_SetWantsMouseMove_Boolean == null)
				{
					r_RInternal_SetWantsMouseMove_Boolean = new(this, "Internal_SetWantsMouseMove", 0, typeof(System.Boolean));
					r_RInternal_SetWantsMouseMove_Boolean.SetBelong(this.instance);
				}
				return r_RInternal_SetWantsMouseMove_Boolean;
			}
		}

		/// <summary>
		/// Void Internal_SetWantsMouseEnterLeaveWindow(Boolean)
		/// </summary>
		protected RMethod r_RInternal_SetWantsMouseEnterLeaveWindow_Boolean;
		public virtual RMethod RInternal_SetWantsMouseEnterLeaveWindow_Boolean
		{
			get
			{
				if(r_RInternal_SetWantsMouseEnterLeaveWindow_Boolean == null)
				{
					r_RInternal_SetWantsMouseEnterLeaveWindow_Boolean = new(this, "Internal_SetWantsMouseEnterLeaveWindow", 0, typeof(System.Boolean));
					r_RInternal_SetWantsMouseEnterLeaveWindow_Boolean.SetBelong(this.instance);
				}
				return r_RInternal_SetWantsMouseEnterLeaveWindow_Boolean;
			}
		}

		/// <summary>
		/// Void Internal_SetAutoRepaint(Boolean)
		/// </summary>
		protected RMethod r_RInternal_SetAutoRepaint_Boolean;
		public virtual RMethod RInternal_SetAutoRepaint_Boolean
		{
			get
			{
				if(r_RInternal_SetAutoRepaint_Boolean == null)
				{
					r_RInternal_SetAutoRepaint_Boolean = new(this, "Internal_SetAutoRepaint", 0, typeof(System.Boolean));
					r_RInternal_SetAutoRepaint_Boolean.SetBelong(this.instance);
				}
				return r_RInternal_SetAutoRepaint_Boolean;
			}
		}

		/// <summary>
		/// Void Internal_SetWindow(UnityEngine.ScriptableObject)
		/// </summary>
		protected RMethod r_RInternal_SetWindow_ScriptableObject;
		public virtual RMethod RInternal_SetWindow_ScriptableObject
		{
			get
			{
				if(r_RInternal_SetWindow_ScriptableObject == null)
				{
					r_RInternal_SetWindow_ScriptableObject = new(this, "Internal_SetWindow", 0, typeof(UnityEngine.ScriptableObject));
					r_RInternal_SetWindow_ScriptableObject.SetBelong(this.instance);
				}
				return r_RInternal_SetWindow_ScriptableObject;
			}
		}

		/// <summary>
		/// Void Internal_UnsetWindow(UnityEngine.ScriptableObject)
		/// </summary>
		protected RMethod r_RInternal_UnsetWindow_ScriptableObject;
		public virtual RMethod RInternal_UnsetWindow_ScriptableObject
		{
			get
			{
				if(r_RInternal_UnsetWindow_ScriptableObject == null)
				{
					r_RInternal_UnsetWindow_ScriptableObject = new(this, "Internal_UnsetWindow", 0, typeof(UnityEngine.ScriptableObject));
					r_RInternal_UnsetWindow_ScriptableObject.SetBelong(this.instance);
				}
				return r_RInternal_UnsetWindow_ScriptableObject;
			}
		}

		/// <summary>
		/// Void Internal_SetPosition(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RInternal_SetPosition_Rect;
		public virtual RMethod RInternal_SetPosition_Rect
		{
			get
			{
				if(r_RInternal_SetPosition_Rect == null)
				{
					r_RInternal_SetPosition_Rect = new(this, "Internal_SetPosition", 0, typeof(UnityEngine.Rect));
					r_RInternal_SetPosition_Rect.SetBelong(this.instance);
				}
				return r_RInternal_SetPosition_Rect;
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
		/// System.String GetTypeNameOfMostSpecificActiveView()
		/// </summary>
		protected static RMethod r_RGetTypeNameOfMostSpecificActiveView;
		public static RMethod RGetTypeNameOfMostSpecificActiveView
		{
			get
			{
				if(r_RGetTypeNameOfMostSpecificActiveView == null)
				{
					r_RGetTypeNameOfMostSpecificActiveView = new( ReleactionUtils.GetType("UnityEditor.GUIView"), "GetTypeNameOfMostSpecificActiveView", 0);
					r_RGetTypeNameOfMostSpecificActiveView.SetBelong(null);
				}
				return r_RGetTypeNameOfMostSpecificActiveView;
			}
		}

		/// <summary>
		/// Void BeginOffsetArea(UnityEngine.Rect, UnityEngine.GUIContent, UnityEngine.GUIStyle)
		/// </summary>
		protected static RMethod r_RBeginOffsetArea_Rect_GUIContent_GUIStyle;
		public static RMethod RBeginOffsetArea_Rect_GUIContent_GUIStyle
		{
			get
			{
				if(r_RBeginOffsetArea_Rect_GUIContent_GUIStyle == null)
				{
					r_RBeginOffsetArea_Rect_GUIContent_GUIStyle = new( ReleactionUtils.GetType("UnityEditor.GUIView"), "BeginOffsetArea", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(UnityEngine.GUIStyle));
					r_RBeginOffsetArea_Rect_GUIContent_GUIStyle.SetBelong(null);
				}
				return r_RBeginOffsetArea_Rect_GUIContent_GUIStyle;
			}
		}

		/// <summary>
		/// Void EndOffsetArea()
		/// </summary>
		protected static RMethod r_REndOffsetArea;
		public static RMethod REndOffsetArea
		{
			get
			{
				if(r_REndOffsetArea == null)
				{
					r_REndOffsetArea = new( ReleactionUtils.GetType("UnityEditor.GUIView"), "EndOffsetArea", 0);
					r_REndOffsetArea.SetBelong(null);
				}
				return r_REndOffsetArea;
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
		/// Void SetInternalGameViewDimensions_Injected(UnityEngine.Rect ByRef, UnityEngine.Rect ByRef, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_RSetInternalGameViewDimensions_Injected_Ref_Rect_Ref_Rect_Ref_Vector2;
		public virtual RMethod RSetInternalGameViewDimensions_Injected_Ref_Rect_Ref_Rect_Ref_Vector2
		{
			get
			{
				if(r_RSetInternalGameViewDimensions_Injected_Ref_Rect_Ref_Rect_Ref_Vector2 == null)
				{
					r_RSetInternalGameViewDimensions_Injected_Ref_Rect_Ref_Rect_Ref_Vector2 = new(this, "SetInternalGameViewDimensions_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.Vector2).MakeByRefType());
					r_RSetInternalGameViewDimensions_Injected_Ref_Rect_Ref_Rect_Ref_Vector2.SetBelong(this.instance);
				}
				return r_RSetInternalGameViewDimensions_Injected_Ref_Rect_Ref_Rect_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void SetMainPlayModeViewSize_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_RSetMainPlayModeViewSize_Injected_Ref_Vector2;
		public virtual RMethod RSetMainPlayModeViewSize_Injected_Ref_Vector2
		{
			get
			{
				if(r_RSetMainPlayModeViewSize_Injected_Ref_Vector2 == null)
				{
					r_RSetMainPlayModeViewSize_Injected_Ref_Vector2 = new(this, "SetMainPlayModeViewSize_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_RSetMainPlayModeViewSize_Injected_Ref_Vector2.SetBelong(this.instance);
				}
				return r_RSetMainPlayModeViewSize_Injected_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void SetDisplayViewSize_Injected(Int32, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_RSetDisplayViewSize_Injected_Int32_Ref_Vector2;
		public virtual RMethod RSetDisplayViewSize_Injected_Int32_Ref_Vector2
		{
			get
			{
				if(r_RSetDisplayViewSize_Injected_Int32_Ref_Vector2 == null)
				{
					r_RSetDisplayViewSize_Injected_Int32_Ref_Vector2 = new(this, "SetDisplayViewSize_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector2).MakeByRefType());
					r_RSetDisplayViewSize_Injected_Int32_Ref_Vector2.SetBelong(this.instance);
				}
				return r_RSetDisplayViewSize_Injected_Int32_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void GetDisplayViewSize_Injected(Int32, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_RGetDisplayViewSize_Injected_Int32_Out_Vector2;
		public virtual RMethod RGetDisplayViewSize_Injected_Int32_Out_Vector2
		{
			get
			{
				if(r_RGetDisplayViewSize_Injected_Int32_Out_Vector2 == null)
				{
					r_RGetDisplayViewSize_Injected_Int32_Out_Vector2 = new(this, "GetDisplayViewSize_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector2).MakeByRefType());
					r_RGetDisplayViewSize_Injected_Int32_Out_Vector2.SetBelong(this.instance);
				}
				return r_RGetDisplayViewSize_Injected_Int32_Out_Vector2;
			}
		}

		/// <summary>
		/// Void GrabPixels_Injected(UnityEngine.RenderTexture, UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_RGrabPixels_Injected_RenderTexture_Ref_Rect;
		public virtual RMethod RGrabPixels_Injected_RenderTexture_Ref_Rect
		{
			get
			{
				if(r_RGrabPixels_Injected_RenderTexture_Ref_Rect == null)
				{
					r_RGrabPixels_Injected_RenderTexture_Ref_Rect = new(this, "GrabPixels_Injected", 0, typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Rect).MakeByRefType());
					r_RGrabPixels_Injected_RenderTexture_Ref_Rect.SetBelong(this.instance);
				}
				return r_RGrabPixels_Injected_RenderTexture_Ref_Rect;
			}
		}

		/// <summary>
		/// Void MarkHotRegion_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_RMarkHotRegion_Injected_Ref_Rect;
		public virtual RMethod RMarkHotRegion_Injected_Ref_Rect
		{
			get
			{
				if(r_RMarkHotRegion_Injected_Ref_Rect == null)
				{
					r_RMarkHotRegion_Injected_Ref_Rect = new(this, "MarkHotRegion_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_RMarkHotRegion_Injected_Ref_Rect.SetBelong(this.instance);
				}
				return r_RMarkHotRegion_Injected_Ref_Rect;
			}
		}

		/// <summary>
		/// Void Internal_SetPosition_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_RInternal_SetPosition_Injected_Ref_Rect;
		public virtual RMethod RInternal_SetPosition_Injected_Ref_Rect
		{
			get
			{
				if(r_RInternal_SetPosition_Injected_Ref_Rect == null)
				{
					r_RInternal_SetPosition_Injected_Ref_Rect = new(this, "Internal_SetPosition_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_RInternal_SetPosition_Injected_Ref_Rect.SetBelong(this.instance);
				}
				return r_RInternal_SetPosition_Injected_Ref_Rect;
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


        public RGUIView() : base("UnityEditor.GUIView")
        {
        }

        public RGUIView(System.Object instance) : base("UnityEditor.GUIView")
		{
            SetInstance(instance);
		}

        public RGUIView(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGUIView(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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


        public virtual void Internal_Init(System.Int32  @depthBits, System.Int32  @antiAliasing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@depthBits, @antiAliasing};
            var ___result = RInternal_Init_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_Recreate(System.Int32  @depthBits, System.Int32  @antiAliasing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@depthBits, @antiAliasing};
            var ___result = RInternal_Recreate_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternal_Close.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Internal_SendEvent(UnityEngine.Event  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RInternal_SendEvent_Event.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Internal_SetWantsMouseMove(System.Boolean  @wantIt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@wantIt};
            var ___result = RInternal_SetWantsMouseMove_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetWantsMouseEnterLeaveWindow(System.Boolean  @wantIt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@wantIt};
            var ___result = RInternal_SetWantsMouseEnterLeaveWindow_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetAutoRepaint(System.Boolean  @doit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@doit};
            var ___result = RInternal_SetAutoRepaint_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetWindow(UnityEngine.ScriptableObject  @win)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@win};
            var ___result = RInternal_SetWindow_ScriptableObject.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_UnsetWindow(UnityEngine.ScriptableObject  @win)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@win};
            var ___result = RInternal_UnsetWindow_ScriptableObject.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetPosition(UnityEngine.Rect  @windowPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowPosition};
            var ___result = RInternal_SetPosition_Rect.Invoke(___genericsType, ___parameters);

            
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


        public virtual void ValidateWindowBackendForCurrentView()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RValidateWindowBackendForCurrentView.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OldOnGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROldOnGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBackingScaleFactorChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnBackingScaleFactorChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPosition(UnityEngine.Rect  @newPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newPos};
            var ___result = RSetPosition_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDestroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDestroy.Invoke(___genericsType, ___parameters);

            
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


        public static System.String GetTypeNameOfMostSpecificActiveView()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTypeNameOfMostSpecificActiveView.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static void BeginOffsetArea(UnityEngine.Rect  @screenRect, UnityEngine.GUIContent  @content, UnityEngine.GUIStyle  @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@screenRect, @content, @style};
            var ___result = RBeginOffsetArea_Rect_GUIContent_GUIStyle.Invoke(___genericsType, ___parameters);

            
        }


        public static void EndOffsetArea()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REndOffsetArea.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CaptureMetalScene()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCaptureMetalScene.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInternalGameViewDimensions_Injected(ref UnityEngine.Rect  @rect, ref UnityEngine.Rect  @clippedRect, ref UnityEngine.Vector2  @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @clippedRect, @targetSize};
            var ___result = RSetInternalGameViewDimensions_Injected_Ref_Rect_Ref_Rect_Ref_Vector2.Invoke(___genericsType, ___parameters);
			rect = (UnityEngine.Rect)___parameters[0];
			clippedRect = (UnityEngine.Rect)___parameters[1];
			targetSize = (UnityEngine.Vector2)___parameters[2];

            
        }


        public virtual void SetMainPlayModeViewSize_Injected(ref UnityEngine.Vector2  @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetSize};
            var ___result = RSetMainPlayModeViewSize_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			targetSize = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void SetDisplayViewSize_Injected(System.Int32  @displayId, ref UnityEngine.Vector2  @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@displayId, @targetSize};
            var ___result = RSetDisplayViewSize_Injected_Int32_Ref_Vector2.Invoke(___genericsType, ___parameters);
			targetSize = (UnityEngine.Vector2)___parameters[1];

            
        }


        public virtual void GetDisplayViewSize_Injected(System.Int32  @displayId, out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@displayId, @ret};
            var ___result = RGetDisplayViewSize_Injected_Int32_Out_Vector2.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector2)___parameters[1];

            
        }


        public virtual void GrabPixels_Injected(UnityEngine.RenderTexture  @rd, ref UnityEngine.Rect  @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rd, @rect};
            var ___result = RGrabPixels_Injected_RenderTexture_Ref_Rect.Invoke(___genericsType, ___parameters);
			rect = (UnityEngine.Rect)___parameters[1];

            
        }


        public virtual void MarkHotRegion_Injected(ref UnityEngine.Rect  @hotRegionRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hotRegionRect};
            var ___result = RMarkHotRegion_Injected_Ref_Rect.Invoke(___genericsType, ___parameters);
			hotRegionRect = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void Internal_SetPosition_Injected(ref UnityEngine.Rect  @windowPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowPosition};
            var ___result = RInternal_SetPosition_Injected_Ref_Rect.Invoke(___genericsType, ___parameters);
			windowPosition = (UnityEngine.Rect)___parameters[0];

            
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



        public virtual System.Boolean OnFocus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnFocus.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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