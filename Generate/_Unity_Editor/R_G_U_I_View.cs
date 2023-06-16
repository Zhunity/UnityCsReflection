
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEditor.GUIView
	/// </summary>
    public partial class RGUIView : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.GUIView");
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


		/// <summary>
		/// System.Action`1[UnityEditor.GUIView] positionChanged
		/// </summary>
		protected static REvent r_EpositionChanged;
		public static REvent REpositionChanged
		{
			get
			{
				if(r_EpositionChanged == null)
				{
					r_EpositionChanged = new(Type, "positionChanged");
				}
				return r_EpositionChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.GUIView] positionChanged
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RGUIView> r_FpositionChanged;
		public static Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RGUIView> RFpositionChanged
		{
			get
			{
				if(r_FpositionChanged == null)
				{
					r_FpositionChanged = new(Type, "positionChanged");
				}
				return r_FpositionChanged;
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
		/// UnityEditor.IWindowBackend m_WindowBackend
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIWindowBackend r_Fm_WindowBackend;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIWindowBackend RFm_WindowBackend
		{
			get
			{
				if(r_Fm_WindowBackend == null)
				{
					r_Fm_WindowBackend = new(this, "m_WindowBackend");
				}
				return r_Fm_WindowBackend;
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
		/// UnityEditor.GUIView current
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RGUIView r_Pcurrent;
		public static Hvak.Editor.Refleaction.RUnityEditor.RGUIView RPcurrent
		{
			get
			{
				if(r_Pcurrent == null)
				{
					r_Pcurrent = new(Type, "current", -1);
				}
				return r_Pcurrent;
			}
		}

		/// <summary>
		/// UnityEditor.GUIView focusedView
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RGUIView r_PfocusedView;
		public static Hvak.Editor.Refleaction.RUnityEditor.RGUIView RPfocusedView
		{
			get
			{
				if(r_PfocusedView == null)
				{
					r_PfocusedView = new(Type, "focusedView", -1);
				}
				return r_PfocusedView;
			}
		}

		/// <summary>
		/// UnityEditor.GUIView mouseOverView
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RGUIView r_PmouseOverView;
		public static Hvak.Editor.Refleaction.RUnityEditor.RGUIView RPmouseOverView
		{
			get
			{
				if(r_PmouseOverView == null)
				{
					r_PmouseOverView = new(Type, "mouseOverView", -1);
				}
				return r_PmouseOverView;
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
				}
				return r_PnativeHandle;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 UnityEditor.IWindowModel.size
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PUnityEditor__2__IWindowModel__2__size;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPUnityEditor__2__IWindowModel__2__size
		{
			get
			{
				if(r_PUnityEditor__2__IWindowModel__2__size == null)
				{
					r_PUnityEditor__2__IWindowModel__2__size = new(this, "UnityEditor.IWindowModel.size", -1);
				}
				return r_PUnityEditor__2__IWindowModel__2__size;
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
				}
				return r_PeventInterests;
			}
		}

		/// <summary>
		/// System.Action UnityEditor.IWindowModel.onGUIHandler
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_PUnityEditor__2__IWindowModel__2__onGUIHandler;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RPUnityEditor__2__IWindowModel__2__onGUIHandler
		{
			get
			{
				if(r_PUnityEditor__2__IWindowModel__2__onGUIHandler == null)
				{
					r_PUnityEditor__2__IWindowModel__2__onGUIHandler = new(this, "UnityEditor.IWindowModel.onGUIHandler", -1);
				}
				return r_PUnityEditor__2__IWindowModel__2__onGUIHandler;
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
				}
				return r_PwindowBackend;
			}
		}

		/// <summary>
		/// UnityEditor.IWindowBackend UnityEditor.IWindowModel.windowBackend
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIWindowBackend r_PUnityEditor__2__IWindowModel__2__windowBackend;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIWindowBackend RPUnityEditor__2__IWindowModel__2__windowBackend
		{
			get
			{
				if(r_PUnityEditor__2__IWindowModel__2__windowBackend == null)
				{
					r_PUnityEditor__2__IWindowModel__2__windowBackend = new(this, "UnityEditor.IWindowModel.windowBackend", -1);
				}
				return r_PUnityEditor__2__IWindowModel__2__windowBackend;
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
				}
				return r_MInternal_SetAsActiveWindow;
			}
		}

		/// <summary>
		/// Void Internal_Init(Int32, Int32)
		/// </summary>
		protected RMethod r_MInternal_Init_Int32_Int32;
		public virtual RMethod RMInternal_Init_Int32_Int32
		{
			get
			{
				if(r_MInternal_Init_Int32_Int32 == null)
				{
					r_MInternal_Init_Int32_Int32 = new(this, "Internal_Init", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MInternal_Init_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_Recreate(Int32, Int32)
		/// </summary>
		protected RMethod r_MInternal_Recreate_Int32_Int32;
		public virtual RMethod RMInternal_Recreate_Int32_Int32
		{
			get
			{
				if(r_MInternal_Recreate_Int32_Int32 == null)
				{
					r_MInternal_Recreate_Int32_Int32 = new(this, "Internal_Recreate", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MInternal_Recreate_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Internal_Close()
		/// </summary>
		protected RMethod r_MInternal_Close;
		public virtual RMethod RMInternal_Close
		{
			get
			{
				if(r_MInternal_Close == null)
				{
					r_MInternal_Close = new(this, "Internal_Close", 0);
				}
				return r_MInternal_Close;
			}
		}

		/// <summary>
		/// Boolean Internal_SendEvent(UnityEngine.Event)
		/// </summary>
		protected RMethod r_MInternal_SendEvent_Event;
		public virtual RMethod RMInternal_SendEvent_Event
		{
			get
			{
				if(r_MInternal_SendEvent_Event == null)
				{
					r_MInternal_SendEvent_Event = new(this, "Internal_SendEvent", 0, typeof(UnityEngine.Event));
				}
				return r_MInternal_SendEvent_Event;
			}
		}

		/// <summary>
		/// Void Internal_SetWantsMouseMove(Boolean)
		/// </summary>
		protected RMethod r_MInternal_SetWantsMouseMove_Boolean;
		public virtual RMethod RMInternal_SetWantsMouseMove_Boolean
		{
			get
			{
				if(r_MInternal_SetWantsMouseMove_Boolean == null)
				{
					r_MInternal_SetWantsMouseMove_Boolean = new(this, "Internal_SetWantsMouseMove", 0, typeof(System.Boolean));
				}
				return r_MInternal_SetWantsMouseMove_Boolean;
			}
		}

		/// <summary>
		/// Void Internal_SetWantsMouseEnterLeaveWindow(Boolean)
		/// </summary>
		protected RMethod r_MInternal_SetWantsMouseEnterLeaveWindow_Boolean;
		public virtual RMethod RMInternal_SetWantsMouseEnterLeaveWindow_Boolean
		{
			get
			{
				if(r_MInternal_SetWantsMouseEnterLeaveWindow_Boolean == null)
				{
					r_MInternal_SetWantsMouseEnterLeaveWindow_Boolean = new(this, "Internal_SetWantsMouseEnterLeaveWindow", 0, typeof(System.Boolean));
				}
				return r_MInternal_SetWantsMouseEnterLeaveWindow_Boolean;
			}
		}

		/// <summary>
		/// Void Internal_SetAutoRepaint(Boolean)
		/// </summary>
		protected RMethod r_MInternal_SetAutoRepaint_Boolean;
		public virtual RMethod RMInternal_SetAutoRepaint_Boolean
		{
			get
			{
				if(r_MInternal_SetAutoRepaint_Boolean == null)
				{
					r_MInternal_SetAutoRepaint_Boolean = new(this, "Internal_SetAutoRepaint", 0, typeof(System.Boolean));
				}
				return r_MInternal_SetAutoRepaint_Boolean;
			}
		}

		/// <summary>
		/// Void Internal_SetWindow(UnityEngine.ScriptableObject)
		/// </summary>
		protected RMethod r_MInternal_SetWindow_ScriptableObject;
		public virtual RMethod RMInternal_SetWindow_ScriptableObject
		{
			get
			{
				if(r_MInternal_SetWindow_ScriptableObject == null)
				{
					r_MInternal_SetWindow_ScriptableObject = new(this, "Internal_SetWindow", 0, typeof(UnityEngine.ScriptableObject));
				}
				return r_MInternal_SetWindow_ScriptableObject;
			}
		}

		/// <summary>
		/// Void Internal_UnsetWindow(UnityEngine.ScriptableObject)
		/// </summary>
		protected RMethod r_MInternal_UnsetWindow_ScriptableObject;
		public virtual RMethod RMInternal_UnsetWindow_ScriptableObject
		{
			get
			{
				if(r_MInternal_UnsetWindow_ScriptableObject == null)
				{
					r_MInternal_UnsetWindow_ScriptableObject = new(this, "Internal_UnsetWindow", 0, typeof(UnityEngine.ScriptableObject));
				}
				return r_MInternal_UnsetWindow_ScriptableObject;
			}
		}

		/// <summary>
		/// Void Internal_SetPosition(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MInternal_SetPosition_Rect;
		public virtual RMethod RMInternal_SetPosition_Rect
		{
			get
			{
				if(r_MInternal_SetPosition_Rect == null)
				{
					r_MInternal_SetPosition_Rect = new(this, "Internal_SetPosition", 0, typeof(UnityEngine.Rect));
				}
				return r_MInternal_SetPosition_Rect;
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
				}
				return r_MSetWindow_ContainerWindow;
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
				}
				return r_MRecreateContext;
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
				}
				return r_MValidateWindowBackendForCurrentView;
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
				}
				return r_MOldOnGUI;
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
				}
				return r_MSetPosition_Rect;
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
				}
				return r_MGetViewName;
			}
		}

		/// <summary>
		/// System.String GetTypeNameOfMostSpecificActiveView()
		/// </summary>
		protected static RMethod r_MGetTypeNameOfMostSpecificActiveView;
		public static RMethod RMGetTypeNameOfMostSpecificActiveView
		{
			get
			{
				if(r_MGetTypeNameOfMostSpecificActiveView == null)
				{
					r_MGetTypeNameOfMostSpecificActiveView = new(Type, "GetTypeNameOfMostSpecificActiveView", 0);
				}
				return r_MGetTypeNameOfMostSpecificActiveView;
			}
		}

		/// <summary>
		/// Void BeginOffsetArea(UnityEngine.Rect, UnityEngine.GUIContent, UnityEngine.GUIStyle)
		/// </summary>
		protected static RMethod r_MBeginOffsetArea_Rect_GUIContent_GUIStyle;
		public static RMethod RMBeginOffsetArea_Rect_GUIContent_GUIStyle
		{
			get
			{
				if(r_MBeginOffsetArea_Rect_GUIContent_GUIStyle == null)
				{
					r_MBeginOffsetArea_Rect_GUIContent_GUIStyle = new(Type, "BeginOffsetArea", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(UnityEngine.GUIStyle));
				}
				return r_MBeginOffsetArea_Rect_GUIContent_GUIStyle;
			}
		}

		/// <summary>
		/// Void EndOffsetArea()
		/// </summary>
		protected static RMethod r_MEndOffsetArea;
		public static RMethod RMEndOffsetArea
		{
			get
			{
				if(r_MEndOffsetArea == null)
				{
					r_MEndOffsetArea = new(Type, "EndOffsetArea", 0);
				}
				return r_MEndOffsetArea;
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
				}
				return r_MCaptureMetalScene;
			}
		}

		/// <summary>
		/// Void SetInternalGameViewDimensions_Injected(UnityEngine.Rect ByRef, UnityEngine.Rect ByRef, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_MSetInternalGameViewDimensions_Injected_Ref_Rect_Ref_Rect_Ref_Vector2;
		public virtual RMethod RMSetInternalGameViewDimensions_Injected_Ref_Rect_Ref_Rect_Ref_Vector2
		{
			get
			{
				if(r_MSetInternalGameViewDimensions_Injected_Ref_Rect_Ref_Rect_Ref_Vector2 == null)
				{
					r_MSetInternalGameViewDimensions_Injected_Ref_Rect_Ref_Rect_Ref_Vector2 = new(this, "SetInternalGameViewDimensions_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_MSetInternalGameViewDimensions_Injected_Ref_Rect_Ref_Rect_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void SetMainPlayModeViewSize_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_MSetMainPlayModeViewSize_Injected_Ref_Vector2;
		public virtual RMethod RMSetMainPlayModeViewSize_Injected_Ref_Vector2
		{
			get
			{
				if(r_MSetMainPlayModeViewSize_Injected_Ref_Vector2 == null)
				{
					r_MSetMainPlayModeViewSize_Injected_Ref_Vector2 = new(this, "SetMainPlayModeViewSize_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_MSetMainPlayModeViewSize_Injected_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void SetDisplayViewSize_Injected(Int32, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_MSetDisplayViewSize_Injected_Int32_Ref_Vector2;
		public virtual RMethod RMSetDisplayViewSize_Injected_Int32_Ref_Vector2
		{
			get
			{
				if(r_MSetDisplayViewSize_Injected_Int32_Ref_Vector2 == null)
				{
					r_MSetDisplayViewSize_Injected_Int32_Ref_Vector2 = new(this, "SetDisplayViewSize_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_MSetDisplayViewSize_Injected_Int32_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void GetDisplayViewSize_Injected(Int32, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_MGetDisplayViewSize_Injected_Int32_Out_Vector2;
		public virtual RMethod RMGetDisplayViewSize_Injected_Int32_Out_Vector2
		{
			get
			{
				if(r_MGetDisplayViewSize_Injected_Int32_Out_Vector2 == null)
				{
					r_MGetDisplayViewSize_Injected_Int32_Out_Vector2 = new(this, "GetDisplayViewSize_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_MGetDisplayViewSize_Injected_Int32_Out_Vector2;
			}
		}

		/// <summary>
		/// Void GrabPixels_Injected(UnityEngine.RenderTexture, UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_MGrabPixels_Injected_RenderTexture_Ref_Rect;
		public virtual RMethod RMGrabPixels_Injected_RenderTexture_Ref_Rect
		{
			get
			{
				if(r_MGrabPixels_Injected_RenderTexture_Ref_Rect == null)
				{
					r_MGrabPixels_Injected_RenderTexture_Ref_Rect = new(this, "GrabPixels_Injected", 0, typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Rect).MakeByRefType());
				}
				return r_MGrabPixels_Injected_RenderTexture_Ref_Rect;
			}
		}

		/// <summary>
		/// Void MarkHotRegion_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_MMarkHotRegion_Injected_Ref_Rect;
		public virtual RMethod RMMarkHotRegion_Injected_Ref_Rect
		{
			get
			{
				if(r_MMarkHotRegion_Injected_Ref_Rect == null)
				{
					r_MMarkHotRegion_Injected_Ref_Rect = new(this, "MarkHotRegion_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
				}
				return r_MMarkHotRegion_Injected_Ref_Rect;
			}
		}

		/// <summary>
		/// Void Internal_SetPosition_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_MInternal_SetPosition_Injected_Ref_Rect;
		public virtual RMethod RMInternal_SetPosition_Injected_Ref_Rect
		{
			get
			{
				if(r_MInternal_SetPosition_Injected_Ref_Rect == null)
				{
					r_MInternal_SetPosition_Injected_Ref_Rect = new(this, "Internal_SetPosition_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
				}
				return r_MInternal_SetPosition_Injected_Ref_Rect;
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
				}
				return r_MSetWindowRecurse_ContainerWindow;
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
				}
				return r_MOnFocus;
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

            return ReflectionUtils.Convert<UnityEngine.Vector2>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
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


        public virtual void Internal_Init(System.Int32 @depthBits, System.Int32 @antiAliasing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@depthBits, @antiAliasing};
            var ___result = RMInternal_Init_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_Recreate(System.Int32 @depthBits, System.Int32 @antiAliasing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@depthBits, @antiAliasing};
            var ___result = RMInternal_Recreate_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternal_Close.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Internal_SendEvent(UnityEngine.Event @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMInternal_SendEvent_Event.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Internal_SetWantsMouseMove(System.Boolean @wantIt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@wantIt};
            var ___result = RMInternal_SetWantsMouseMove_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetWantsMouseEnterLeaveWindow(System.Boolean @wantIt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@wantIt};
            var ___result = RMInternal_SetWantsMouseEnterLeaveWindow_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetAutoRepaint(System.Boolean @doit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@doit};
            var ___result = RMInternal_SetAutoRepaint_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetWindow(UnityEngine.ScriptableObject @win)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@win};
            var ___result = RMInternal_SetWindow_ScriptableObject.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_UnsetWindow(UnityEngine.ScriptableObject @win)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@win};
            var ___result = RMInternal_UnsetWindow_ScriptableObject.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetPosition(UnityEngine.Rect @windowPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowPosition};
            var ___result = RMInternal_SetPosition_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SendEvent(UnityEngine.Event @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMSendEvent_Event.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void SetWindow(Hvak.Editor.Refleaction.RUnityEditor.RContainerWindow @win)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@win.Value};
            var ___result = RMSetWindow_ContainerWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecreateContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRecreateContext.Invoke(___genericsType, ___parameters);

            
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


        public virtual void ValidateWindowBackendForCurrentView()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMValidateWindowBackendForCurrentView.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OldOnGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOldOnGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBackingScaleFactorChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnBackingScaleFactorChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPosition(UnityEngine.Rect @newPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newPos};
            var ___result = RMSetPosition_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDestroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnDestroy.Invoke(___genericsType, ___parameters);

            
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

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static System.String GetTypeNameOfMostSpecificActiveView()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeNameOfMostSpecificActiveView.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static void BeginOffsetArea(UnityEngine.Rect @screenRect, UnityEngine.GUIContent @content, UnityEngine.GUIStyle @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@screenRect, @content, @style};
            var ___result = RMBeginOffsetArea_Rect_GUIContent_GUIStyle.Invoke(___genericsType, ___parameters);

            
        }


        public static void EndOffsetArea()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEndOffsetArea.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CaptureMetalScene()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCaptureMetalScene.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInternalGameViewDimensions_Injected(ref UnityEngine.Rect @rect, ref UnityEngine.Rect @clippedRect, ref UnityEngine.Vector2 @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @clippedRect, @targetSize};
            var ___result = RMSetInternalGameViewDimensions_Injected_Ref_Rect_Ref_Rect_Ref_Vector2.Invoke(___genericsType, ___parameters);
			@rect = (UnityEngine.Rect)___parameters[0];
			@clippedRect = (UnityEngine.Rect)___parameters[1];
			@targetSize = (UnityEngine.Vector2)___parameters[2];

            
        }


        public virtual void SetMainPlayModeViewSize_Injected(ref UnityEngine.Vector2 @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetSize};
            var ___result = RMSetMainPlayModeViewSize_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			@targetSize = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void SetDisplayViewSize_Injected(System.Int32 @displayId, ref UnityEngine.Vector2 @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@displayId, @targetSize};
            var ___result = RMSetDisplayViewSize_Injected_Int32_Ref_Vector2.Invoke(___genericsType, ___parameters);
			@targetSize = (UnityEngine.Vector2)___parameters[1];

            
        }


        public virtual void GetDisplayViewSize_Injected(System.Int32 @displayId, out UnityEngine.Vector2 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@displayId, @ret};
            var ___result = RMGetDisplayViewSize_Injected_Int32_Out_Vector2.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector2)___parameters[1];

            
        }


        public virtual void GrabPixels_Injected(UnityEngine.RenderTexture @rd, ref UnityEngine.Rect @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rd, @rect};
            var ___result = RMGrabPixels_Injected_RenderTexture_Ref_Rect.Invoke(___genericsType, ___parameters);
			@rect = (UnityEngine.Rect)___parameters[1];

            
        }


        public virtual void MarkHotRegion_Injected(ref UnityEngine.Rect @hotRegionRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hotRegionRect};
            var ___result = RMMarkHotRegion_Injected_Ref_Rect.Invoke(___genericsType, ___parameters);
			@hotRegionRect = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void Internal_SetPosition_Injected(ref UnityEngine.Rect @windowPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowPosition};
            var ___result = RMInternal_SetPosition_Injected_Ref_Rect.Invoke(___genericsType, ___parameters);
			@windowPosition = (UnityEngine.Rect)___parameters[0];

            
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

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
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


        public virtual System.Boolean OnFocus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnFocus.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
