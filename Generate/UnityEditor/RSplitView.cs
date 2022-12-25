using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.SplitView
	/// </summary>
    public partial class RSplitView : RMember //
    {

		/// <summary>
		/// System.Single kRootDropZoneThickness
		/// </summary>
		protected static RField r_kRootDropZoneThickness;
		public static RField RkRootDropZoneThickness
		{
			get
			{
				if(r_kRootDropZoneThickness == null)
				{
					r_kRootDropZoneThickness = new( ReleactionUtils.GetType("UnityEditor.SplitView"), "kRootDropZoneThickness");
					r_kRootDropZoneThickness.SetBelong(null);
				}
				return r_kRootDropZoneThickness;
			}
		}

		/// <summary>
		/// System.Single kRootDropZoneOffset
		/// </summary>
		protected static RField r_kRootDropZoneOffset;
		public static RField RkRootDropZoneOffset
		{
			get
			{
				if(r_kRootDropZoneOffset == null)
				{
					r_kRootDropZoneOffset = new( ReleactionUtils.GetType("UnityEditor.SplitView"), "kRootDropZoneOffset");
					r_kRootDropZoneOffset.SetBelong(null);
				}
				return r_kRootDropZoneOffset;
			}
		}

		/// <summary>
		/// System.Single kRootDropDestinationThickness
		/// </summary>
		protected static RField r_kRootDropDestinationThickness;
		public static RField RkRootDropDestinationThickness
		{
			get
			{
				if(r_kRootDropDestinationThickness == null)
				{
					r_kRootDropDestinationThickness = new( ReleactionUtils.GetType("UnityEditor.SplitView"), "kRootDropDestinationThickness");
					r_kRootDropDestinationThickness.SetBelong(null);
				}
				return r_kRootDropDestinationThickness;
			}
		}

		/// <summary>
		/// System.Single kMaxViewDropZoneThickness
		/// </summary>
		protected static RField r_kMaxViewDropZoneThickness;
		public static RField RkMaxViewDropZoneThickness
		{
			get
			{
				if(r_kMaxViewDropZoneThickness == null)
				{
					r_kMaxViewDropZoneThickness = new( ReleactionUtils.GetType("UnityEditor.SplitView"), "kMaxViewDropZoneThickness");
					r_kMaxViewDropZoneThickness.SetBelong(null);
				}
				return r_kMaxViewDropZoneThickness;
			}
		}

		/// <summary>
		/// System.Single kMinViewDropDestinationThickness
		/// </summary>
		protected static RField r_kMinViewDropDestinationThickness;
		public static RField RkMinViewDropDestinationThickness
		{
			get
			{
				if(r_kMinViewDropDestinationThickness == null)
				{
					r_kMinViewDropDestinationThickness = new( ReleactionUtils.GetType("UnityEditor.SplitView"), "kMinViewDropDestinationThickness");
					r_kMinViewDropDestinationThickness.SetBelong(null);
				}
				return r_kMinViewDropDestinationThickness;
			}
		}

		/// <summary>
		/// System.Boolean vertical
		/// </summary>
		protected RField r_vertical;
		public virtual RField Rvertical
		{
			get
			{
				if(r_vertical == null)
				{
					r_vertical = new(this, "vertical");
					r_vertical.SetBelong(this.instance);
				}
				return r_vertical;
			}
		}

		/// <summary>
		/// System.Int32 controlID
		/// </summary>
		protected RField r_controlID;
		public virtual RField RcontrolID
		{
			get
			{
				if(r_controlID == null)
				{
					r_controlID = new(this, "controlID");
					r_controlID.SetBelong(this.instance);
				}
				return r_controlID;
			}
		}

		/// <summary>
		/// UnityEditor.SplitterState splitState
		/// </summary>
		protected RUnityEditor.RSplitterState r_splitState;
		public virtual RUnityEditor.RSplitterState RsplitState
		{
			get
			{
				if(r_splitState == null)
				{
					r_splitState = new(this, "splitState");
					r_splitState.SetBelong(this.instance);
				}
				return r_splitState;
			}
		}

		/// <summary>
		/// System.Single kGrabDist
		/// </summary>
		protected static RField r_kGrabDist;
		public static RField RkGrabDist
		{
			get
			{
				if(r_kGrabDist == null)
				{
					r_kGrabDist = new( ReleactionUtils.GetType("UnityEditor.SplitView"), "kGrabDist");
					r_kGrabDist.SetBelong(null);
				}
				return r_kGrabDist;
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
		/// UnityEngine.Rect RectFromEdge(UnityEngine.Rect, ViewEdge, Single, Single)
		/// </summary>
		protected RMethod r_RRectFromEdge_Rect_ViewEdge_Single_Single;
		public virtual RMethod RRectFromEdge_Rect_ViewEdge_Single_Single
		{
			get
			{
				if(r_RRectFromEdge_Rect_ViewEdge_Single_Single == null)
				{
					r_RRectFromEdge_Rect_ViewEdge_Single_Single = new(this, "RectFromEdge", 0, typeof(UnityEngine.Rect),  ReleactionUtils.GetType("UnityEditor.SplitView+ViewEdge"), typeof(System.Single), typeof(System.Single));
					r_RRectFromEdge_Rect_ViewEdge_Single_Single.SetBelong(this.instance);
				}
				return r_RRectFromEdge_Rect_ViewEdge_Single_Single;
			}
		}

		/// <summary>
		/// Void SetupSplitter()
		/// </summary>
		protected RMethod r_RSetupSplitter;
		public virtual RMethod RSetupSplitter
		{
			get
			{
				if(r_RSetupSplitter == null)
				{
					r_RSetupSplitter = new(this, "SetupSplitter", 0);
					r_RSetupSplitter.SetBelong(this.instance);
				}
				return r_RSetupSplitter;
			}
		}

		/// <summary>
		/// Void SetupRectsFromSplitter()
		/// </summary>
		protected RMethod r_RSetupRectsFromSplitter;
		public virtual RMethod RSetupRectsFromSplitter
		{
			get
			{
				if(r_RSetupRectsFromSplitter == null)
				{
					r_RSetupRectsFromSplitter = new(this, "SetupRectsFromSplitter", 0);
					r_RSetupRectsFromSplitter.SetBelong(this.instance);
				}
				return r_RSetupRectsFromSplitter;
			}
		}

		/// <summary>
		/// Void RecalcMinMaxAndReflowAll(UnityEditor.SplitView)
		/// </summary>
		protected static RMethod r_RRecalcMinMaxAndReflowAll_SplitView;
		public static RMethod RRecalcMinMaxAndReflowAll_SplitView
		{
			get
			{
				if(r_RRecalcMinMaxAndReflowAll_SplitView == null)
				{
					r_RRecalcMinMaxAndReflowAll_SplitView = new( ReleactionUtils.GetType("UnityEditor.SplitView"), "RecalcMinMaxAndReflowAll", 0,  ReleactionUtils.GetType("UnityEditor.SplitView"));
					r_RRecalcMinMaxAndReflowAll_SplitView.SetBelong(null);
				}
				return r_RRecalcMinMaxAndReflowAll_SplitView;
			}
		}

		/// <summary>
		/// Void RecalcMinMaxRecurse(UnityEditor.SplitView)
		/// </summary>
		protected static RMethod r_RRecalcMinMaxRecurse_SplitView;
		public static RMethod RRecalcMinMaxRecurse_SplitView
		{
			get
			{
				if(r_RRecalcMinMaxRecurse_SplitView == null)
				{
					r_RRecalcMinMaxRecurse_SplitView = new( ReleactionUtils.GetType("UnityEditor.SplitView"), "RecalcMinMaxRecurse", 0,  ReleactionUtils.GetType("UnityEditor.SplitView"));
					r_RRecalcMinMaxRecurse_SplitView.SetBelong(null);
				}
				return r_RRecalcMinMaxRecurse_SplitView;
			}
		}

		/// <summary>
		/// Void ReflowRecurse(UnityEditor.SplitView)
		/// </summary>
		protected static RMethod r_RReflowRecurse_SplitView;
		public static RMethod RReflowRecurse_SplitView
		{
			get
			{
				if(r_RReflowRecurse_SplitView == null)
				{
					r_RReflowRecurse_SplitView = new( ReleactionUtils.GetType("UnityEditor.SplitView"), "ReflowRecurse", 0,  ReleactionUtils.GetType("UnityEditor.SplitView"));
					r_RReflowRecurse_SplitView.SetBelong(null);
				}
				return r_RReflowRecurse_SplitView;
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
		/// Single PlaceView(Int32, Single, Single)
		/// </summary>
		protected RMethod r_RPlaceView_Int32_Single_Single;
		public virtual RMethod RPlaceView_Int32_Single_Single
		{
			get
			{
				if(r_RPlaceView_Int32_Single_Single == null)
				{
					r_RPlaceView_Int32_Single_Single = new(this, "PlaceView", 0, typeof(System.Int32), typeof(System.Single), typeof(System.Single));
					r_RPlaceView_Int32_Single_Single.SetBelong(this.instance);
				}
				return r_RPlaceView_Int32_Single_Single;
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
		/// Void RemoveChildNice(UnityEditor.View)
		/// </summary>
		protected RMethod r_RRemoveChildNice_View;
		public virtual RMethod RRemoveChildNice_View
		{
			get
			{
				if(r_RRemoveChildNice_View == null)
				{
					r_RRemoveChildNice_View = new(this, "RemoveChildNice", 0,  ReleactionUtils.GetType("UnityEditor.View"));
					r_RRemoveChildNice_View.SetBelong(this.instance);
				}
				return r_RRemoveChildNice_View;
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
		/// UnityEditor.DropInfo RootViewDropZone(ViewEdge, UnityEngine.Vector2, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RRootViewDropZone_ViewEdge_Vector2_Rect;
		public virtual RMethod RRootViewDropZone_ViewEdge_Vector2_Rect
		{
			get
			{
				if(r_RRootViewDropZone_ViewEdge_Vector2_Rect == null)
				{
					r_RRootViewDropZone_ViewEdge_Vector2_Rect = new(this, "RootViewDropZone", 0,  ReleactionUtils.GetType("UnityEditor.SplitView+ViewEdge"), typeof(UnityEngine.Vector2), typeof(UnityEngine.Rect));
					r_RRootViewDropZone_ViewEdge_Vector2_Rect.SetBelong(this.instance);
				}
				return r_RRootViewDropZone_ViewEdge_Vector2_Rect;
			}
		}

		/// <summary>
		/// UnityEditor.DropInfo DragOverRootView(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RDragOverRootView_Vector2;
		public virtual RMethod RDragOverRootView_Vector2
		{
			get
			{
				if(r_RDragOverRootView_Vector2 == null)
				{
					r_RDragOverRootView_Vector2 = new(this, "DragOverRootView", 0, typeof(UnityEngine.Vector2));
					r_RDragOverRootView_Vector2.SetBelong(this.instance);
				}
				return r_RDragOverRootView_Vector2;
			}
		}

		/// <summary>
		/// UnityEditor.DropInfo DragOver(UnityEditor.EditorWindow, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RDragOver_EditorWindow_Vector2;
		public virtual RMethod RDragOver_EditorWindow_Vector2
		{
			get
			{
				if(r_RDragOver_EditorWindow_Vector2 == null)
				{
					r_RDragOver_EditorWindow_Vector2 = new(this, "DragOver", 0, typeof(UnityEditor.EditorWindow), typeof(UnityEngine.Vector2));
					r_RDragOver_EditorWindow_Vector2.SetBelong(this.instance);
				}
				return r_RDragOver_EditorWindow_Vector2;
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
		/// Boolean PerformDrop(UnityEditor.EditorWindow, UnityEditor.DropInfo, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RPerformDrop_EditorWindow_DropInfo_Vector2;
		public virtual RMethod RPerformDrop_EditorWindow_DropInfo_Vector2
		{
			get
			{
				if(r_RPerformDrop_EditorWindow_DropInfo_Vector2 == null)
				{
					r_RPerformDrop_EditorWindow_DropInfo_Vector2 = new(this, "PerformDrop", 0, typeof(UnityEditor.EditorWindow),  ReleactionUtils.GetType("UnityEditor.DropInfo"), typeof(UnityEngine.Vector2));
					r_RPerformDrop_EditorWindow_DropInfo_Vector2.SetBelong(this.instance);
				}
				return r_RPerformDrop_EditorWindow_DropInfo_Vector2;
			}
		}

		/// <summary>
		/// Void MakeRoomForRect(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RMakeRoomForRect_Rect;
		public virtual RMethod RMakeRoomForRect_Rect
		{
			get
			{
				if(r_RMakeRoomForRect_Rect == null)
				{
					r_RMakeRoomForRect_Rect = new(this, "MakeRoomForRect", 0, typeof(UnityEngine.Rect));
					r_RMakeRoomForRect_Rect.SetBelong(this.instance);
				}
				return r_RMakeRoomForRect_Rect;
			}
		}

		/// <summary>
		/// Void CalcRoomForRect(UnityEngine.Rect[], UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RCalcRoomForRect_RectArray_Rect;
		public virtual RMethod RCalcRoomForRect_RectArray_Rect
		{
			get
			{
				if(r_RCalcRoomForRect_RectArray_Rect == null)
				{
					r_RCalcRoomForRect_RectArray_Rect = new(this, "CalcRoomForRect", 0, typeof(UnityEngine.Rect).MakeArrayType(), typeof(UnityEngine.Rect));
					r_RCalcRoomForRect_RectArray_Rect.SetBelong(this.instance);
				}
				return r_RCalcRoomForRect_RectArray_Rect;
			}
		}

		/// <summary>
		/// Void Cleanup()
		/// </summary>
		protected RMethod r_RCleanup;
		public virtual RMethod RCleanup
		{
			get
			{
				if(r_RCleanup == null)
				{
					r_RCleanup = new(this, "Cleanup", 0);
					r_RCleanup.SetBelong(this.instance);
				}
				return r_RCleanup;
			}
		}

		/// <summary>
		/// Void SplitGUI(UnityEngine.Event)
		/// </summary>
		protected RMethod r_RSplitGUI_Event;
		public virtual RMethod RSplitGUI_Event
		{
			get
			{
				if(r_RSplitGUI_Event == null)
				{
					r_RSplitGUI_Event = new(this, "SplitGUI", 0, typeof(UnityEngine.Event));
					r_RSplitGUI_Event.SetBelong(this.instance);
				}
				return r_RSplitGUI_Event;
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


        public virtual void SetupSplitter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetupSplitter.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetupRectsFromSplitter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetupRectsFromSplitter.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void Reflow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReflow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single PlaceView(System.Int32  @i, System.Single  @pos, System.Single  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i, @pos, @size};
            var ___result = RPlaceView_Int32_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }






        public virtual System.Object DragOverRootView(UnityEngine.Vector2  @mouseScreenPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mouseScreenPosition};
            var ___result = RDragOverRootView_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object DragOver(UnityEditor.EditorWindow  @w, UnityEngine.Vector2  @mouseScreenPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@w, @mouseScreenPosition};
            var ___result = RDragOver_EditorWindow_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void ChildrenMinMaxChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RChildrenMinMaxChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }



        public virtual void MakeRoomForRect(UnityEngine.Rect  @r)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r};
            var ___result = RMakeRoomForRect_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CalcRoomForRect(UnityEngine.Rect[]  @sources, UnityEngine.Rect  @r)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sources, @r};
            var ___result = RCalcRoomForRect_RectArray_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Cleanup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCleanup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SplitGUI(UnityEngine.Event  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RSplitGUI_Event.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPosition(UnityEngine.Rect  @newPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newPos};
            var ___result = RSetPosition_Rect.Invoke(___genericsType, ___parameters);

            
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


        public virtual void SetPositionOnly(UnityEngine.Rect  @newPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newPos};
            var ___result = RSetPositionOnly_Rect.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void OnDestroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDestroy.Invoke(___genericsType, ___parameters);

            
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
