
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.ListViewDragger
	/// </summary>
    public partial class RListViewDragger : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.ListViewDragger");
            }
        }

        public RListViewDragger() : base("UnityEngine.UIElements.ListViewDragger")
        {
        }

        public RListViewDragger(System.Object instance) : base("UnityEngine.UIElements.ListViewDragger")
		{
            SetInstance(instance);
		}

        public RListViewDragger(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RListViewDragger(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.UIElements.ListViewDragger+DragPosition m_LastDragPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RListViewDragger.RDragPosition r_Fm_LastDragPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RListViewDragger.RDragPosition RFm_LastDragPosition
		{
			get
			{
				if(r_Fm_LastDragPosition == null)
				{
					r_Fm_LastDragPosition = new(this, "m_LastDragPosition");
				}
				return r_Fm_LastDragPosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_DragHoverBar
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_DragHoverBar;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_DragHoverBar
		{
			get
			{
				if(r_Fm_DragHoverBar == null)
				{
					r_Fm_DragHoverBar = new(this, "m_DragHoverBar");
				}
				return r_Fm_DragHoverBar;
			}
		}

		/// <summary>
		/// System.Int32 k_AutoScrollAreaSize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_AutoScrollAreaSize;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_AutoScrollAreaSize
		{
			get
			{
				if(r_Fk_AutoScrollAreaSize == null)
				{
					r_Fk_AutoScrollAreaSize = new(Type, "k_AutoScrollAreaSize");
				}
				return r_Fk_AutoScrollAreaSize;
			}
		}

		/// <summary>
		/// System.Int32 k_BetweenElementsAreaSize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_BetweenElementsAreaSize;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_BetweenElementsAreaSize
		{
			get
			{
				if(r_Fk_BetweenElementsAreaSize == null)
				{
					r_Fk_BetweenElementsAreaSize = new(Type, "k_BetweenElementsAreaSize");
				}
				return r_Fk_BetweenElementsAreaSize;
			}
		}

		/// <summary>
		/// System.Int32 k_PanSpeed
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_PanSpeed;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_PanSpeed
		{
			get
			{
				if(r_Fk_PanSpeed == null)
				{
					r_Fk_PanSpeed = new(Type, "k_PanSpeed");
				}
				return r_Fk_PanSpeed;
			}
		}

		/// <summary>
		/// System.Int32 k_DragHoverBarHeight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_DragHoverBarHeight;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_DragHoverBarHeight
		{
			get
			{
				if(r_Fk_DragHoverBarHeight == null)
				{
					r_Fk_DragHoverBarHeight = new(Type, "k_DragHoverBarHeight");
				}
				return r_Fk_DragHoverBarHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ICollectionDragAndDropController <dragAndDropController>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RICollectionDragAndDropController r_F__0__dragAndDropController__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RICollectionDragAndDropController RF__0__dragAndDropController__1__k__BackingField
		{
			get
			{
				if(r_F__0__dragAndDropController__1__k__BackingField == null)
				{
					r_F__0__dragAndDropController__1__k__BackingField = new(this, "<dragAndDropController>k__BackingField");
				}
				return r_F__0__dragAndDropController__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DragEventsProcessor+DragState m_DragState
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDragEventsProcessor.RDragState r_Fm_DragState;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDragEventsProcessor.RDragState RFm_DragState
		{
			get
			{
				if(r_Fm_DragState == null)
				{
					r_Fm_DragState = new(this, "m_DragState");
				}
				return r_Fm_DragState;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_Target
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_Target;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_Target
		{
			get
			{
				if(r_Fm_Target == null)
				{
					r_Fm_Target = new(this, "m_Target");
				}
				return r_Fm_Target;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DefaultDragAndDropClient dragAndDropClient
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDefaultDragAndDropClient r_FdragAndDropClient;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDefaultDragAndDropClient RFdragAndDropClient
		{
			get
			{
				if(r_FdragAndDropClient == null)
				{
					r_FdragAndDropClient = new(this, "dragAndDropClient");
				}
				return r_FdragAndDropClient;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BaseVerticalCollectionView targetListView
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVerticalCollectionView r_PtargetListView;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVerticalCollectionView RPtargetListView
		{
			get
			{
				if(r_PtargetListView == null)
				{
					r_PtargetListView = new(this, "targetListView", -1);
				}
				return r_PtargetListView;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ScrollView targetScrollView
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScrollView r_PtargetScrollView;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScrollView RPtargetScrollView
		{
			get
			{
				if(r_PtargetScrollView == null)
				{
					r_PtargetScrollView = new(this, "targetScrollView", -1);
				}
				return r_PtargetScrollView;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ICollectionDragAndDropController dragAndDropController
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RICollectionDragAndDropController r_PdragAndDropController;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RICollectionDragAndDropController RPdragAndDropController
		{
			get
			{
				if(r_PdragAndDropController == null)
				{
					r_PdragAndDropController = new(this, "dragAndDropController", -1);
				}
				return r_PdragAndDropController;
			}
		}

		/// <summary>
		/// Boolean isRegistered
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisRegistered;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisRegistered
		{
			get
			{
				if(r_PisRegistered == null)
				{
					r_PisRegistered = new(this, "isRegistered", -1);
				}
				return r_PisRegistered;
			}
		}

		/// <summary>
		/// Boolean supportsDragEvents
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PsupportsDragEvents;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPsupportsDragEvents
		{
			get
			{
				if(r_PsupportsDragEvents == null)
				{
					r_PsupportsDragEvents = new(this, "supportsDragEvents", -1);
				}
				return r_PsupportsDragEvents;
			}
		}

		/// <summary>
		/// Boolean useDragEvents
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PuseDragEvents;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPuseDragEvents
		{
			get
			{
				if(r_PuseDragEvents == null)
				{
					r_PuseDragEvents = new(this, "useDragEvents", -1);
				}
				return r_PuseDragEvents;
			}
		}

		/// <summary>
		/// Boolean CanStartDrag(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MCanStartDrag_Vector3;
		public virtual RMethod RMCanStartDrag_Vector3
		{
			get
			{
				if(r_MCanStartDrag_Vector3 == null)
				{
					r_MCanStartDrag_Vector3 = new(this, "CanStartDrag", 0, typeof(UnityEngine.Vector3));
				}
				return r_MCanStartDrag_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StartDragArgs StartDrag(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MStartDrag_Vector3;
		public virtual RMethod RMStartDrag_Vector3
		{
			get
			{
				if(r_MStartDrag_Vector3 == null)
				{
					r_MStartDrag_Vector3 = new(this, "StartDrag", 0, typeof(UnityEngine.Vector3));
				}
				return r_MStartDrag_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DragVisualMode UpdateDrag(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MUpdateDrag_Vector3;
		public virtual RMethod RMUpdateDrag_Vector3
		{
			get
			{
				if(r_MUpdateDrag_Vector3 == null)
				{
					r_MUpdateDrag_Vector3 = new(this, "UpdateDrag", 0, typeof(UnityEngine.Vector3));
				}
				return r_MUpdateDrag_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DragVisualMode GetVisualMode(UnityEngine.Vector3, DragPosition ByRef)
		/// </summary>
		protected RMethod r_MGetVisualMode_Vector3_Ref_DragPosition;
		public virtual RMethod RMGetVisualMode_Vector3_Ref_DragPosition
		{
			get
			{
				if(r_MGetVisualMode_Vector3_Ref_DragPosition == null)
				{
					r_MGetVisualMode_Vector3_Ref_DragPosition = new(this, "GetVisualMode", 0, typeof(UnityEngine.Vector3),  ReflectionUtils.GetType("UnityEngine.UIElements.ListViewDragger+DragPosition").MakeByRefType());
				}
				return r_MGetVisualMode_Vector3_Ref_DragPosition;
			}
		}

		/// <summary>
		/// Void OnDrop(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MOnDrop_Vector3;
		public virtual RMethod RMOnDrop_Vector3
		{
			get
			{
				if(r_MOnDrop_Vector3 == null)
				{
					r_MOnDrop_Vector3 = new(this, "OnDrop", 0, typeof(UnityEngine.Vector3));
				}
				return r_MOnDrop_Vector3;
			}
		}

		/// <summary>
		/// Void HandleDragAndScroll(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MHandleDragAndScroll_Vector2;
		public virtual RMethod RMHandleDragAndScroll_Vector2
		{
			get
			{
				if(r_MHandleDragAndScroll_Vector2 == null)
				{
					r_MHandleDragAndScroll_Vector2 = new(this, "HandleDragAndScroll", 0, typeof(UnityEngine.Vector2));
				}
				return r_MHandleDragAndScroll_Vector2;
			}
		}

		/// <summary>
		/// Void ApplyDragAndDropUI(DragPosition)
		/// </summary>
		protected RMethod r_MApplyDragAndDropUI_DragPosition;
		public virtual RMethod RMApplyDragAndDropUI_DragPosition
		{
			get
			{
				if(r_MApplyDragAndDropUI_DragPosition == null)
				{
					r_MApplyDragAndDropUI_DragPosition = new(this, "ApplyDragAndDropUI", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ListViewDragger+DragPosition"));
				}
				return r_MApplyDragAndDropUI_DragPosition;
			}
		}

		/// <summary>
		/// Boolean TryGetDragPosition(UnityEngine.Vector2, DragPosition ByRef)
		/// </summary>
		protected RMethod r_MTryGetDragPosition_Vector2_Ref_DragPosition;
		public virtual RMethod RMTryGetDragPosition_Vector2_Ref_DragPosition
		{
			get
			{
				if(r_MTryGetDragPosition_Vector2_Ref_DragPosition == null)
				{
					r_MTryGetDragPosition_Vector2_Ref_DragPosition = new(this, "TryGetDragPosition", 0, typeof(UnityEngine.Vector2),  ReflectionUtils.GetType("UnityEngine.UIElements.ListViewDragger+DragPosition").MakeByRefType());
				}
				return r_MTryGetDragPosition_Vector2_Ref_DragPosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ListDragAndDropArgs MakeDragAndDropArgs(DragPosition)
		/// </summary>
		protected RMethod r_MMakeDragAndDropArgs_DragPosition;
		public virtual RMethod RMMakeDragAndDropArgs_DragPosition
		{
			get
			{
				if(r_MMakeDragAndDropArgs_DragPosition == null)
				{
					r_MMakeDragAndDropArgs_DragPosition = new(this, "MakeDragAndDropArgs", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ListViewDragger+DragPosition"));
				}
				return r_MMakeDragAndDropArgs_DragPosition;
			}
		}

		/// <summary>
		/// Void PlaceHoverBarAtElement(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MPlaceHoverBarAtElement_VisualElement;
		public virtual RMethod RMPlaceHoverBarAtElement_VisualElement
		{
			get
			{
				if(r_MPlaceHoverBarAtElement_VisualElement == null)
				{
					r_MPlaceHoverBarAtElement_VisualElement = new(this, "PlaceHoverBarAtElement", 0, typeof(UnityEngine.UIElements.VisualElement));
				}
				return r_MPlaceHoverBarAtElement_VisualElement;
			}
		}

		/// <summary>
		/// Void PlaceHoverBarAt(Single)
		/// </summary>
		protected RMethod r_MPlaceHoverBarAt_Single;
		public virtual RMethod RMPlaceHoverBarAt_Single
		{
			get
			{
				if(r_MPlaceHoverBarAt_Single == null)
				{
					r_MPlaceHoverBarAt_Single = new(this, "PlaceHoverBarAt", 0, typeof(System.Single));
				}
				return r_MPlaceHoverBarAt_Single;
			}
		}

		/// <summary>
		/// Void ClearDragAndDropUI()
		/// </summary>
		protected RMethod r_MClearDragAndDropUI;
		public virtual RMethod RMClearDragAndDropUI
		{
			get
			{
				if(r_MClearDragAndDropUI == null)
				{
					r_MClearDragAndDropUI = new(this, "ClearDragAndDropUI", 0);
				}
				return r_MClearDragAndDropUI;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ReusableCollectionItem GetRecycledItem(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MGetRecycledItem_Vector3;
		public virtual RMethod RMGetRecycledItem_Vector3
		{
			get
			{
				if(r_MGetRecycledItem_Vector3 == null)
				{
					r_MGetRecycledItem_Vector3 = new(this, "GetRecycledItem", 0, typeof(UnityEngine.Vector3));
				}
				return r_MGetRecycledItem_Vector3;
			}
		}

		/// <summary>
		/// Void <ApplyDragAndDropUI>b__22_0(UnityEngine.UIElements.GeometryChangedEvent)
		/// </summary>
		protected RMethod r_M__0__ApplyDragAndDropUI__1__b__22_0_GeometryChangedEvent;
		public virtual RMethod RM__0__ApplyDragAndDropUI__1__b__22_0_GeometryChangedEvent
		{
			get
			{
				if(r_M__0__ApplyDragAndDropUI__1__b__22_0_GeometryChangedEvent == null)
				{
					r_M__0__ApplyDragAndDropUI__1__b__22_0_GeometryChangedEvent = new(this, "<ApplyDragAndDropUI>b__22_0", 0, typeof(UnityEngine.UIElements.GeometryChangedEvent));
				}
				return r_M__0__ApplyDragAndDropUI__1__b__22_0_GeometryChangedEvent;
			}
		}

		/// <summary>
		/// Void UnregisterCallbacksFromTarget(Boolean)
		/// </summary>
		protected RMethod r_MUnregisterCallbacksFromTarget_Boolean;
		public virtual RMethod RMUnregisterCallbacksFromTarget_Boolean
		{
			get
			{
				if(r_MUnregisterCallbacksFromTarget_Boolean == null)
				{
					r_MUnregisterCallbacksFromTarget_Boolean = new(this, "UnregisterCallbacksFromTarget", 0, typeof(System.Boolean));
				}
				return r_MUnregisterCallbacksFromTarget_Boolean;
			}
		}

		/// <summary>
		/// Void OnPointerUpEvent(UnityEngine.UIElements.PointerUpEvent)
		/// </summary>
		protected RMethod r_MOnPointerUpEvent_PointerUpEvent;
		public virtual RMethod RMOnPointerUpEvent_PointerUpEvent
		{
			get
			{
				if(r_MOnPointerUpEvent_PointerUpEvent == null)
				{
					r_MOnPointerUpEvent_PointerUpEvent = new(this, "OnPointerUpEvent", 0, typeof(UnityEngine.UIElements.PointerUpEvent));
				}
				return r_MOnPointerUpEvent_PointerUpEvent;
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


        public virtual System.Boolean CanStartDrag(UnityEngine.Vector3 @pointerPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerPosition};
            var ___result = RMCanStartDrag_Vector3.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStartDragArgs StartDrag(UnityEngine.Vector3 @pointerPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerPosition};
            var ___result = RMStartDrag_Vector3.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStartDragArgs>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDragVisualMode UpdateDrag(UnityEngine.Vector3 @pointerPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerPosition};
            var ___result = RMUpdateDrag_Vector3.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDragVisualMode>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDragVisualMode GetVisualMode(UnityEngine.Vector3 @pointerPosition, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RListViewDragger.RDragPosition @dragPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerPosition, @dragPosition.Value};
            var ___result = RMGetVisualMode_Vector3_Ref_DragPosition.Invoke(___genericsType, ___parameters);
			@dragPosition = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RListViewDragger.RDragPosition>(___parameters[1]);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDragVisualMode>(___result);
        }


        public virtual void OnDrop(UnityEngine.Vector3 @pointerPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerPosition};
            var ___result = RMOnDrop_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleDragAndScroll(UnityEngine.Vector2 @pointerPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerPosition};
            var ___result = RMHandleDragAndScroll_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyDragAndDropUI(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RListViewDragger.RDragPosition @dragPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dragPosition.Value};
            var ___result = RMApplyDragAndDropUI_DragPosition.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryGetDragPosition(UnityEngine.Vector2 @pointerPosition, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RListViewDragger.RDragPosition @dragPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerPosition, @dragPosition.Value};
            var ___result = RMTryGetDragPosition_Vector2_Ref_DragPosition.Invoke(___genericsType, ___parameters);
			@dragPosition = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RListViewDragger.RDragPosition>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RListDragAndDropArgs MakeDragAndDropArgs(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RListViewDragger.RDragPosition @dragPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dragPosition.Value};
            var ___result = RMMakeDragAndDropArgs_DragPosition.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RListDragAndDropArgs>(___result);
        }


        public virtual void PlaceHoverBarAtElement(UnityEngine.UIElements.VisualElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RMPlaceHoverBarAtElement_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlaceHoverBarAt(System.Single @top)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@top};
            var ___result = RMPlaceHoverBarAt_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearDragAndDropUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearDragAndDropUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RReusableCollectionItem GetRecycledItem(UnityEngine.Vector3 @pointerPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerPosition};
            var ___result = RMGetRecycledItem_Vector3.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RReusableCollectionItem>(___result);
        }


        public virtual void __0__ApplyDragAndDropUI__1__b__22_0(UnityEngine.UIElements.GeometryChangedEvent @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RM__0__ApplyDragAndDropUI__1__b__22_0_GeometryChangedEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterCallbacksFromTarget(System.Boolean @unregisterPanelEvents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unregisterPanelEvents};
            var ___result = RMUnregisterCallbacksFromTarget_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPointerUpEvent(UnityEngine.UIElements.PointerUpEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnPointerUpEvent_PointerUpEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
