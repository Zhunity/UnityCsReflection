
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.SplitView
	/// </summary>
    public partial class RSplitView : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.SplitView");
            }
        }

        public RSplitView() : base("UnityEditor.SplitView")
        {
        }

        public RSplitView(System.Object instance) : base("UnityEditor.SplitView")
		{
            SetInstance(instance);
		}

        public RSplitView(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSplitView(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Single kRootDropZoneThickness
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FkRootDropZoneThickness;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFkRootDropZoneThickness
		{
			get
			{
				if(r_FkRootDropZoneThickness == null)
				{
					r_FkRootDropZoneThickness = new(Type, "kRootDropZoneThickness");
				}
				return r_FkRootDropZoneThickness;
			}
		}

		/// <summary>
		/// System.Single kRootDropZoneOffset
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FkRootDropZoneOffset;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFkRootDropZoneOffset
		{
			get
			{
				if(r_FkRootDropZoneOffset == null)
				{
					r_FkRootDropZoneOffset = new(Type, "kRootDropZoneOffset");
				}
				return r_FkRootDropZoneOffset;
			}
		}

		/// <summary>
		/// System.Single kRootDropDestinationThickness
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FkRootDropDestinationThickness;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFkRootDropDestinationThickness
		{
			get
			{
				if(r_FkRootDropDestinationThickness == null)
				{
					r_FkRootDropDestinationThickness = new(Type, "kRootDropDestinationThickness");
				}
				return r_FkRootDropDestinationThickness;
			}
		}

		/// <summary>
		/// System.Single kMaxViewDropZoneThickness
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FkMaxViewDropZoneThickness;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFkMaxViewDropZoneThickness
		{
			get
			{
				if(r_FkMaxViewDropZoneThickness == null)
				{
					r_FkMaxViewDropZoneThickness = new(Type, "kMaxViewDropZoneThickness");
				}
				return r_FkMaxViewDropZoneThickness;
			}
		}

		/// <summary>
		/// System.Single kMinViewDropDestinationThickness
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FkMinViewDropDestinationThickness;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFkMinViewDropDestinationThickness
		{
			get
			{
				if(r_FkMinViewDropDestinationThickness == null)
				{
					r_FkMinViewDropDestinationThickness = new(Type, "kMinViewDropDestinationThickness");
				}
				return r_FkMinViewDropDestinationThickness;
			}
		}

		/// <summary>
		/// System.Boolean vertical
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fvertical;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFvertical
		{
			get
			{
				if(r_Fvertical == null)
				{
					r_Fvertical = new(this, "vertical");
				}
				return r_Fvertical;
			}
		}

		/// <summary>
		/// System.Int32 controlID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FcontrolID;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcontrolID
		{
			get
			{
				if(r_FcontrolID == null)
				{
					r_FcontrolID = new(this, "controlID");
				}
				return r_FcontrolID;
			}
		}

		/// <summary>
		/// UnityEditor.SplitterState splitState
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RSplitterState r_FsplitState;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RSplitterState RFsplitState
		{
			get
			{
				if(r_FsplitState == null)
				{
					r_FsplitState = new(this, "splitState");
				}
				return r_FsplitState;
			}
		}

		/// <summary>
		/// System.Single kGrabDist
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FkGrabDist;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFkGrabDist
		{
			get
			{
				if(r_FkGrabDist == null)
				{
					r_FkGrabDist = new(Type, "kGrabDist");
				}
				return r_FkGrabDist;
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
		/// UnityEngine.Rect RectFromEdge(UnityEngine.Rect, ViewEdge, Single, Single)
		/// </summary>
		protected RMethod r_MRectFromEdge_Rect_ViewEdge_Single_Single;
		public virtual RMethod RMRectFromEdge_Rect_ViewEdge_Single_Single
		{
			get
			{
				if(r_MRectFromEdge_Rect_ViewEdge_Single_Single == null)
				{
					r_MRectFromEdge_Rect_ViewEdge_Single_Single = new(this, "RectFromEdge", 0, typeof(UnityEngine.Rect),  ReflectionUtils.GetType("UnityEditor.SplitView+ViewEdge"), typeof(System.Single), typeof(System.Single));
				}
				return r_MRectFromEdge_Rect_ViewEdge_Single_Single;
			}
		}

		/// <summary>
		/// Void SetupSplitter()
		/// </summary>
		protected RMethod r_MSetupSplitter;
		public virtual RMethod RMSetupSplitter
		{
			get
			{
				if(r_MSetupSplitter == null)
				{
					r_MSetupSplitter = new(this, "SetupSplitter", 0);
				}
				return r_MSetupSplitter;
			}
		}

		/// <summary>
		/// Void SetupRectsFromSplitter()
		/// </summary>
		protected RMethod r_MSetupRectsFromSplitter;
		public virtual RMethod RMSetupRectsFromSplitter
		{
			get
			{
				if(r_MSetupRectsFromSplitter == null)
				{
					r_MSetupRectsFromSplitter = new(this, "SetupRectsFromSplitter", 0);
				}
				return r_MSetupRectsFromSplitter;
			}
		}

		/// <summary>
		/// Void RecalcMinMaxAndReflowAll(UnityEditor.SplitView)
		/// </summary>
		protected static RMethod r_MRecalcMinMaxAndReflowAll_SplitView;
		public static RMethod RMRecalcMinMaxAndReflowAll_SplitView
		{
			get
			{
				if(r_MRecalcMinMaxAndReflowAll_SplitView == null)
				{
					r_MRecalcMinMaxAndReflowAll_SplitView = new(Type, "RecalcMinMaxAndReflowAll", 0,  ReflectionUtils.GetType("UnityEditor.SplitView"));
				}
				return r_MRecalcMinMaxAndReflowAll_SplitView;
			}
		}

		/// <summary>
		/// Void RecalcMinMaxRecurse(UnityEditor.SplitView)
		/// </summary>
		protected static RMethod r_MRecalcMinMaxRecurse_SplitView;
		public static RMethod RMRecalcMinMaxRecurse_SplitView
		{
			get
			{
				if(r_MRecalcMinMaxRecurse_SplitView == null)
				{
					r_MRecalcMinMaxRecurse_SplitView = new(Type, "RecalcMinMaxRecurse", 0,  ReflectionUtils.GetType("UnityEditor.SplitView"));
				}
				return r_MRecalcMinMaxRecurse_SplitView;
			}
		}

		/// <summary>
		/// Void ReflowRecurse(UnityEditor.SplitView)
		/// </summary>
		protected static RMethod r_MReflowRecurse_SplitView;
		public static RMethod RMReflowRecurse_SplitView
		{
			get
			{
				if(r_MReflowRecurse_SplitView == null)
				{
					r_MReflowRecurse_SplitView = new(Type, "ReflowRecurse", 0,  ReflectionUtils.GetType("UnityEditor.SplitView"));
				}
				return r_MReflowRecurse_SplitView;
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
		/// Single PlaceView(Int32, Single, Single)
		/// </summary>
		protected RMethod r_MPlaceView_Int32_Single_Single;
		public virtual RMethod RMPlaceView_Int32_Single_Single
		{
			get
			{
				if(r_MPlaceView_Int32_Single_Single == null)
				{
					r_MPlaceView_Int32_Single_Single = new(this, "PlaceView", 0, typeof(System.Int32), typeof(System.Single), typeof(System.Single));
				}
				return r_MPlaceView_Int32_Single_Single;
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
		/// Void RemoveChildNice(UnityEditor.View)
		/// </summary>
		protected RMethod r_MRemoveChildNice_View;
		public virtual RMethod RMRemoveChildNice_View
		{
			get
			{
				if(r_MRemoveChildNice_View == null)
				{
					r_MRemoveChildNice_View = new(this, "RemoveChildNice", 0,  ReflectionUtils.GetType("UnityEditor.View"));
				}
				return r_MRemoveChildNice_View;
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
		/// UnityEditor.DropInfo RootViewDropZone(ViewEdge, UnityEngine.Vector2, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MRootViewDropZone_ViewEdge_Vector2_Rect;
		public virtual RMethod RMRootViewDropZone_ViewEdge_Vector2_Rect
		{
			get
			{
				if(r_MRootViewDropZone_ViewEdge_Vector2_Rect == null)
				{
					r_MRootViewDropZone_ViewEdge_Vector2_Rect = new(this, "RootViewDropZone", 0,  ReflectionUtils.GetType("UnityEditor.SplitView+ViewEdge"), typeof(UnityEngine.Vector2), typeof(UnityEngine.Rect));
				}
				return r_MRootViewDropZone_ViewEdge_Vector2_Rect;
			}
		}

		/// <summary>
		/// UnityEditor.DropInfo DragOverRootView(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MDragOverRootView_Vector2;
		public virtual RMethod RMDragOverRootView_Vector2
		{
			get
			{
				if(r_MDragOverRootView_Vector2 == null)
				{
					r_MDragOverRootView_Vector2 = new(this, "DragOverRootView", 0, typeof(UnityEngine.Vector2));
				}
				return r_MDragOverRootView_Vector2;
			}
		}

		/// <summary>
		/// UnityEditor.DropInfo DragOver(UnityEditor.EditorWindow, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MDragOver_EditorWindow_Vector2;
		public virtual RMethod RMDragOver_EditorWindow_Vector2
		{
			get
			{
				if(r_MDragOver_EditorWindow_Vector2 == null)
				{
					r_MDragOver_EditorWindow_Vector2 = new(this, "DragOver", 0, typeof(UnityEditor.EditorWindow), typeof(UnityEngine.Vector2));
				}
				return r_MDragOver_EditorWindow_Vector2;
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
		/// Boolean PerformDrop(UnityEditor.EditorWindow, UnityEditor.DropInfo, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MPerformDrop_EditorWindow_DropInfo_Vector2;
		public virtual RMethod RMPerformDrop_EditorWindow_DropInfo_Vector2
		{
			get
			{
				if(r_MPerformDrop_EditorWindow_DropInfo_Vector2 == null)
				{
					r_MPerformDrop_EditorWindow_DropInfo_Vector2 = new(this, "PerformDrop", 0, typeof(UnityEditor.EditorWindow),  ReflectionUtils.GetType("UnityEditor.DropInfo"), typeof(UnityEngine.Vector2));
				}
				return r_MPerformDrop_EditorWindow_DropInfo_Vector2;
			}
		}

		/// <summary>
		/// Void MakeRoomForRect(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MMakeRoomForRect_Rect;
		public virtual RMethod RMMakeRoomForRect_Rect
		{
			get
			{
				if(r_MMakeRoomForRect_Rect == null)
				{
					r_MMakeRoomForRect_Rect = new(this, "MakeRoomForRect", 0, typeof(UnityEngine.Rect));
				}
				return r_MMakeRoomForRect_Rect;
			}
		}

		/// <summary>
		/// Void CalcRoomForRect(UnityEngine.Rect[], UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MCalcRoomForRect_RectArray_Rect;
		public virtual RMethod RMCalcRoomForRect_RectArray_Rect
		{
			get
			{
				if(r_MCalcRoomForRect_RectArray_Rect == null)
				{
					r_MCalcRoomForRect_RectArray_Rect = new(this, "CalcRoomForRect", 0, typeof(UnityEngine.Rect).MakeArrayType(), typeof(UnityEngine.Rect));
				}
				return r_MCalcRoomForRect_RectArray_Rect;
			}
		}

		/// <summary>
		/// Void Cleanup()
		/// </summary>
		protected RMethod r_MCleanup;
		public virtual RMethod RMCleanup
		{
			get
			{
				if(r_MCleanup == null)
				{
					r_MCleanup = new(this, "Cleanup", 0);
				}
				return r_MCleanup;
			}
		}

		/// <summary>
		/// Void SplitGUI(UnityEngine.Event)
		/// </summary>
		protected RMethod r_MSplitGUI_Event;
		public virtual RMethod RMSplitGUI_Event
		{
			get
			{
				if(r_MSplitGUI_Event == null)
				{
					r_MSplitGUI_Event = new(this, "SplitGUI", 0, typeof(UnityEngine.Event));
				}
				return r_MSplitGUI_Event;
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


        public virtual UnityEngine.Rect RectFromEdge(UnityEngine.Rect @rect, Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge @edge, System.Single @thickness, System.Single @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @edge.Value, @thickness, @offset};
            var ___result = RMRectFromEdge_Rect_ViewEdge_Single_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rect>(___result);
        }


        public virtual void SetupSplitter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetupSplitter.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetupRectsFromSplitter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetupRectsFromSplitter.Invoke(___genericsType, ___parameters);

            
        }


        public static void RecalcMinMaxAndReflowAll(Hvak.Editor.Refleaction.RUnityEditor.RSplitView @start)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start.Value};
            var ___result = RMRecalcMinMaxAndReflowAll_SplitView.Invoke(___genericsType, ___parameters);

            
        }


        public static void RecalcMinMaxRecurse(Hvak.Editor.Refleaction.RUnityEditor.RSplitView @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node.Value};
            var ___result = RMRecalcMinMaxRecurse_SplitView.Invoke(___genericsType, ___parameters);

            
        }


        public static void ReflowRecurse(Hvak.Editor.Refleaction.RUnityEditor.RSplitView @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node.Value};
            var ___result = RMReflowRecurse_SplitView.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reflow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReflow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single PlaceView(System.Int32 @i, System.Single @pos, System.Single @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i, @pos, @size};
            var ___result = RMPlaceView_Int32_Single_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual void AddChild(Hvak.Editor.Refleaction.RUnityEditor.RView @child, System.Int32 @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child.Value, @idx};
            var ___result = RMAddChild_View_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveChildNice(Hvak.Editor.Refleaction.RUnityEditor.RView @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child.Value};
            var ___result = RMRemoveChildNice_View.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveChild(Hvak.Editor.Refleaction.RUnityEditor.RView @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child.Value};
            var ___result = RMRemoveChild_View.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RDropInfo RootViewDropZone(Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge @edge, UnityEngine.Vector2 @mousePos, UnityEngine.Rect @screenRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@edge.Value, @mousePos, @screenRect};
            var ___result = RMRootViewDropZone_ViewEdge_Vector2_Rect.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RDropInfo>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RDropInfo DragOverRootView(UnityEngine.Vector2 @mouseScreenPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mouseScreenPosition};
            var ___result = RMDragOverRootView_Vector2.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RDropInfo>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RDropInfo DragOver(UnityEditor.EditorWindow @w, UnityEngine.Vector2 @mouseScreenPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@w, @mouseScreenPosition};
            var ___result = RMDragOver_EditorWindow_Vector2.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RDropInfo>(___result);
        }


        public virtual void ChildrenMinMaxChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMChildrenMinMaxChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean PerformDrop(UnityEditor.EditorWindow @dropWindow, Hvak.Editor.Refleaction.RUnityEditor.RDropInfo @dropInfo, UnityEngine.Vector2 @screenPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dropWindow, @dropInfo.Value, @screenPos};
            var ___result = RMPerformDrop_EditorWindow_DropInfo_Vector2.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void MakeRoomForRect(UnityEngine.Rect @r)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r};
            var ___result = RMMakeRoomForRect_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CalcRoomForRect(UnityEngine.Rect[] @sources, UnityEngine.Rect @r)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sources, @r};
            var ___result = RMCalcRoomForRect_RectArray_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Cleanup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCleanup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SplitGUI(UnityEngine.Event @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMSplitGUI_Event.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPosition(UnityEngine.Rect @newPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newPos};
            var ___result = RMSetPosition_Rect.Invoke(___genericsType, ___parameters);

            
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


        public virtual void OnDestroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnDestroy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddChild(Hvak.Editor.Refleaction.RUnityEditor.RView @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child.Value};
            var ___result = RMAddChild_View.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveChild(System.Int32 @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = RMRemoveChild_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetWindow(Hvak.Editor.Refleaction.RUnityEditor.RContainerWindow @win)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@win.Value};
            var ___result = RMSetWindow_ContainerWindow.Invoke(___genericsType, ___parameters);

            
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
