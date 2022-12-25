using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.GeometryChangedEvent
	/// </summary>
    public partial class RGeometryChangedEvent : RMember //
    {

		/// <summary>
		/// UnityEngine.Rect <oldRect>k__BackingField
		/// </summary>
		protected RUnityEngine.RRect r___1__oldRect__2__k__BackingField;
		public virtual RUnityEngine.RRect R__1__oldRect__2__k__BackingField
		{
			get
			{
				if(r___1__oldRect__2__k__BackingField == null)
				{
					r___1__oldRect__2__k__BackingField = new(this, "<oldRect>k__BackingField");
					r___1__oldRect__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__oldRect__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Rect <newRect>k__BackingField
		/// </summary>
		protected RUnityEngine.RRect r___1__newRect__2__k__BackingField;
		public virtual RUnityEngine.RRect R__1__newRect__2__k__BackingField
		{
			get
			{
				if(r___1__newRect__2__k__BackingField == null)
				{
					r___1__newRect__2__k__BackingField = new(this, "<newRect>k__BackingField");
					r___1__newRect__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__newRect__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <layoutPass>k__BackingField
		/// </summary>
		protected RField r___1__layoutPass__2__k__BackingField;
		public virtual RField R__1__layoutPass__2__k__BackingField
		{
			get
			{
				if(r___1__layoutPass__2__k__BackingField == null)
				{
					r___1__layoutPass__2__k__BackingField = new(this, "<layoutPass>k__BackingField");
					r___1__layoutPass__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__layoutPass__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Rect oldRect
		/// </summary>
		protected RUnityEngine.RRect r_oldRect;
		public virtual RUnityEngine.RRect RoldRect
		{
			get
			{
				if(r_oldRect == null)
				{
					r_oldRect = new(this, "oldRect", -1);
					r_oldRect.SetBelong(this.instance);
				}
				return r_oldRect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect newRect
		/// </summary>
		protected RUnityEngine.RRect r_newRect;
		public virtual RUnityEngine.RRect RnewRect
		{
			get
			{
				if(r_newRect == null)
				{
					r_newRect = new(this, "newRect", -1);
					r_newRect.SetBelong(this.instance);
				}
				return r_newRect;
			}
		}

		/// <summary>
		/// Int32 layoutPass
		/// </summary>
		protected RProperty r_layoutPass;
		public virtual RProperty RlayoutPass
		{
			get
			{
				if(r_layoutPass == null)
				{
					r_layoutPass = new(this, "layoutPass", -1);
					r_layoutPass.SetBelong(this.instance);
				}
				return r_layoutPass;
			}
		}

		/// <summary>
		/// Int64 eventTypeId
		/// </summary>
		protected RProperty r_eventTypeId;
		public virtual RProperty ReventTypeId
		{
			get
			{
				if(r_eventTypeId == null)
				{
					r_eventTypeId = new(this, "eventTypeId", -1);
					r_eventTypeId.SetBelong(this.instance);
				}
				return r_eventTypeId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCategory eventCategory
		/// </summary>
		protected RProperty r_eventCategory;
		public virtual RProperty ReventCategory
		{
			get
			{
				if(r_eventCategory == null)
				{
					r_eventCategory = new(this, "eventCategory", -1);
					r_eventCategory.SetBelong(this.instance);
				}
				return r_eventCategory;
			}
		}

		/// <summary>
		/// Int64 timestamp
		/// </summary>
		protected RProperty r_timestamp;
		public virtual RProperty Rtimestamp
		{
			get
			{
				if(r_timestamp == null)
				{
					r_timestamp = new(this, "timestamp", -1);
					r_timestamp.SetBelong(this.instance);
				}
				return r_timestamp;
			}
		}

		/// <summary>
		/// UInt64 eventId
		/// </summary>
		protected RProperty r_eventId;
		public virtual RProperty ReventId
		{
			get
			{
				if(r_eventId == null)
				{
					r_eventId = new(this, "eventId", -1);
					r_eventId.SetBelong(this.instance);
				}
				return r_eventId;
			}
		}

		/// <summary>
		/// UInt64 triggerEventId
		/// </summary>
		protected RProperty r_triggerEventId;
		public virtual RProperty RtriggerEventId
		{
			get
			{
				if(r_triggerEventId == null)
				{
					r_triggerEventId = new(this, "triggerEventId", -1);
					r_triggerEventId.SetBelong(this.instance);
				}
				return r_triggerEventId;
			}
		}

		/// <summary>
		/// EventPropagation propagation
		/// </summary>
		protected RProperty r_propagation;
		public virtual RProperty Rpropagation
		{
			get
			{
				if(r_propagation == null)
				{
					r_propagation = new(this, "propagation", -1);
					r_propagation.SetBelong(this.instance);
				}
				return r_propagation;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PropagationPaths path
		/// </summary>
		protected RUnityEngine.RUIElements.RPropagationPaths r_path;
		public virtual RUnityEngine.RUIElements.RPropagationPaths Rpath
		{
			get
			{
				if(r_path == null)
				{
					r_path = new(this, "path", -1);
					r_path.SetBelong(this.instance);
				}
				return r_path;
			}
		}

		/// <summary>
		/// Boolean bubbles
		/// </summary>
		protected RProperty r_bubbles;
		public virtual RProperty Rbubbles
		{
			get
			{
				if(r_bubbles == null)
				{
					r_bubbles = new(this, "bubbles", -1);
					r_bubbles.SetBelong(this.instance);
				}
				return r_bubbles;
			}
		}

		/// <summary>
		/// Boolean tricklesDown
		/// </summary>
		protected RProperty r_tricklesDown;
		public virtual RProperty RtricklesDown
		{
			get
			{
				if(r_tricklesDown == null)
				{
					r_tricklesDown = new(this, "tricklesDown", -1);
					r_tricklesDown.SetBelong(this.instance);
				}
				return r_tricklesDown;
			}
		}

		/// <summary>
		/// Boolean bubblesOrTricklesDown
		/// </summary>
		protected RProperty r_bubblesOrTricklesDown;
		public virtual RProperty RbubblesOrTricklesDown
		{
			get
			{
				if(r_bubblesOrTricklesDown == null)
				{
					r_bubblesOrTricklesDown = new(this, "bubblesOrTricklesDown", -1);
					r_bubblesOrTricklesDown.SetBelong(this.instance);
				}
				return r_bubblesOrTricklesDown;
			}
		}

		/// <summary>
		/// Boolean skipDisabledElements
		/// </summary>
		protected RProperty r_skipDisabledElements;
		public virtual RProperty RskipDisabledElements
		{
			get
			{
				if(r_skipDisabledElements == null)
				{
					r_skipDisabledElements = new(this, "skipDisabledElements", -1);
					r_skipDisabledElements.SetBelong(this.instance);
				}
				return r_skipDisabledElements;
			}
		}

		/// <summary>
		/// Boolean ignoreCompositeRoots
		/// </summary>
		protected RProperty r_ignoreCompositeRoots;
		public virtual RProperty RignoreCompositeRoots
		{
			get
			{
				if(r_ignoreCompositeRoots == null)
				{
					r_ignoreCompositeRoots = new(this, "ignoreCompositeRoots", -1);
					r_ignoreCompositeRoots.SetBelong(this.instance);
				}
				return r_ignoreCompositeRoots;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler leafTarget
		/// </summary>
		protected RUnityEngine.RUIElements.RIEventHandler r_leafTarget;
		public virtual RUnityEngine.RUIElements.RIEventHandler RleafTarget
		{
			get
			{
				if(r_leafTarget == null)
				{
					r_leafTarget = new(this, "leafTarget", -1);
					r_leafTarget.SetBelong(this.instance);
				}
				return r_leafTarget;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler target
		/// </summary>
		protected RUnityEngine.RUIElements.RIEventHandler r_target;
		public virtual RUnityEngine.RUIElements.RIEventHandler Rtarget
		{
			get
			{
				if(r_target == null)
				{
					r_target = new(this, "target", -1);
					r_target.SetBelong(this.instance);
				}
				return r_target;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.IEventHandler] skipElements
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RIEventHandler> r_skipElements;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RIEventHandler> RskipElements
		{
			get
			{
				if(r_skipElements == null)
				{
					r_skipElements = new(this, "skipElements", -1);
					r_skipElements.SetBelong(this.instance);
				}
				return r_skipElements;
			}
		}

		/// <summary>
		/// Boolean isPropagationStopped
		/// </summary>
		protected RProperty r_isPropagationStopped;
		public virtual RProperty RisPropagationStopped
		{
			get
			{
				if(r_isPropagationStopped == null)
				{
					r_isPropagationStopped = new(this, "isPropagationStopped", -1);
					r_isPropagationStopped.SetBelong(this.instance);
				}
				return r_isPropagationStopped;
			}
		}

		/// <summary>
		/// Boolean isImmediatePropagationStopped
		/// </summary>
		protected RProperty r_isImmediatePropagationStopped;
		public virtual RProperty RisImmediatePropagationStopped
		{
			get
			{
				if(r_isImmediatePropagationStopped == null)
				{
					r_isImmediatePropagationStopped = new(this, "isImmediatePropagationStopped", -1);
					r_isImmediatePropagationStopped.SetBelong(this.instance);
				}
				return r_isImmediatePropagationStopped;
			}
		}

		/// <summary>
		/// Boolean isDefaultPrevented
		/// </summary>
		protected RProperty r_isDefaultPrevented;
		public virtual RProperty RisDefaultPrevented
		{
			get
			{
				if(r_isDefaultPrevented == null)
				{
					r_isDefaultPrevented = new(this, "isDefaultPrevented", -1);
					r_isDefaultPrevented.SetBelong(this.instance);
				}
				return r_isDefaultPrevented;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PropagationPhase propagationPhase
		/// </summary>
		protected RProperty r_propagationPhase;
		public virtual RProperty RpropagationPhase
		{
			get
			{
				if(r_propagationPhase == null)
				{
					r_propagationPhase = new(this, "propagationPhase", -1);
					r_propagationPhase.SetBelong(this.instance);
				}
				return r_propagationPhase;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler currentTarget
		/// </summary>
		protected RUnityEngine.RUIElements.RIEventHandler r_currentTarget;
		public virtual RUnityEngine.RUIElements.RIEventHandler RcurrentTarget
		{
			get
			{
				if(r_currentTarget == null)
				{
					r_currentTarget = new(this, "currentTarget", -1);
					r_currentTarget.SetBelong(this.instance);
				}
				return r_currentTarget;
			}
		}

		/// <summary>
		/// Boolean dispatch
		/// </summary>
		protected RProperty r_dispatch;
		public virtual RProperty Rdispatch
		{
			get
			{
				if(r_dispatch == null)
				{
					r_dispatch = new(this, "dispatch", -1);
					r_dispatch.SetBelong(this.instance);
				}
				return r_dispatch;
			}
		}

		/// <summary>
		/// Boolean processed
		/// </summary>
		protected RProperty r_processed;
		public virtual RProperty Rprocessed
		{
			get
			{
				if(r_processed == null)
				{
					r_processed = new(this, "processed", -1);
					r_processed.SetBelong(this.instance);
				}
				return r_processed;
			}
		}

		/// <summary>
		/// Boolean processedByFocusController
		/// </summary>
		protected RProperty r_processedByFocusController;
		public virtual RProperty RprocessedByFocusController
		{
			get
			{
				if(r_processedByFocusController == null)
				{
					r_processedByFocusController = new(this, "processedByFocusController", -1);
					r_processedByFocusController.SetBelong(this.instance);
				}
				return r_processedByFocusController;
			}
		}

		/// <summary>
		/// Boolean stopDispatch
		/// </summary>
		protected RProperty r_stopDispatch;
		public virtual RProperty RstopDispatch
		{
			get
			{
				if(r_stopDispatch == null)
				{
					r_stopDispatch = new(this, "stopDispatch", -1);
					r_stopDispatch.SetBelong(this.instance);
				}
				return r_stopDispatch;
			}
		}

		/// <summary>
		/// Boolean propagateToIMGUI
		/// </summary>
		protected RProperty r_propagateToIMGUI;
		public virtual RProperty RpropagateToIMGUI
		{
			get
			{
				if(r_propagateToIMGUI == null)
				{
					r_propagateToIMGUI = new(this, "propagateToIMGUI", -1);
					r_propagateToIMGUI.SetBelong(this.instance);
				}
				return r_propagateToIMGUI;
			}
		}

		/// <summary>
		/// UnityEngine.Event imguiEvent
		/// </summary>
		protected RUnityEngine.REvent r_imguiEvent;
		public virtual RUnityEngine.REvent RimguiEvent
		{
			get
			{
				if(r_imguiEvent == null)
				{
					r_imguiEvent = new(this, "imguiEvent", -1);
					r_imguiEvent.SetBelong(this.instance);
				}
				return r_imguiEvent;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 originalMousePosition
		/// </summary>
		protected RUnityEngine.RVector2 r_originalMousePosition;
		public virtual RUnityEngine.RVector2 RoriginalMousePosition
		{
			get
			{
				if(r_originalMousePosition == null)
				{
					r_originalMousePosition = new(this, "originalMousePosition", -1);
					r_originalMousePosition.SetBelong(this.instance);
				}
				return r_originalMousePosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventDebugger eventLogger
		/// </summary>
		protected RUnityEngine.RUIElements.REventDebugger r_eventLogger;
		public virtual RUnityEngine.RUIElements.REventDebugger ReventLogger
		{
			get
			{
				if(r_eventLogger == null)
				{
					r_eventLogger = new(this, "eventLogger", -1);
					r_eventLogger.SetBelong(this.instance);
				}
				return r_eventLogger;
			}
		}

		/// <summary>
		/// Boolean log
		/// </summary>
		protected RProperty r_log;
		public virtual RProperty Rlog
		{
			get
			{
				if(r_log == null)
				{
					r_log = new(this, "log", -1);
					r_log.SetBelong(this.instance);
				}
				return r_log;
			}
		}

		/// <summary>
		/// Boolean pooled
		/// </summary>
		protected RProperty r_pooled;
		public virtual RProperty Rpooled
		{
			get
			{
				if(r_pooled == null)
				{
					r_pooled = new(this, "pooled", -1);
					r_pooled.SetBelong(this.instance);
				}
				return r_pooled;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.GeometryChangedEvent GetPooled(UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_RGetPooled_Rect_Rect;
		public static RMethod RGetPooled_Rect_Rect
		{
			get
			{
				if(r_RGetPooled_Rect_Rect == null)
				{
					r_RGetPooled_Rect_Rect = new(typeof(UnityEngine.UIElements.GeometryChangedEvent), "GetPooled", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
					r_RGetPooled_Rect_Rect.SetBelong(null);
				}
				return r_RGetPooled_Rect_Rect;
			}
		}

		/// <summary>
		/// Void Init()
		/// </summary>
		protected RMethod r_RInit;
		public virtual RMethod RInit
		{
			get
			{
				if(r_RInit == null)
				{
					r_RInit = new(this, "Init", 0);
					r_RInit.SetBelong(this.instance);
				}
				return r_RInit;
			}
		}

		/// <summary>
		/// Void LocalInit()
		/// </summary>
		protected RMethod r_RLocalInit;
		public virtual RMethod RLocalInit
		{
			get
			{
				if(r_RLocalInit == null)
				{
					r_RLocalInit = new(this, "LocalInit", 0);
					r_RLocalInit.SetBelong(this.instance);
				}
				return r_RLocalInit;
			}
		}

		/// <summary>
		/// Void Acquire()
		/// </summary>
		protected RMethod r_RAcquire;
		public virtual RMethod RAcquire
		{
			get
			{
				if(r_RAcquire == null)
				{
					r_RAcquire = new(this, "Acquire", 0);
					r_RAcquire.SetBelong(this.instance);
				}
				return r_RAcquire;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Void SetTriggerEventId(UInt64)
		/// </summary>
		protected RMethod r_RSetTriggerEventId_UInt64;
		public virtual RMethod RSetTriggerEventId_UInt64
		{
			get
			{
				if(r_RSetTriggerEventId_UInt64 == null)
				{
					r_RSetTriggerEventId_UInt64 = new(this, "SetTriggerEventId", 0, typeof(System.UInt64));
					r_RSetTriggerEventId_UInt64.SetBelong(this.instance);
				}
				return r_RSetTriggerEventId_UInt64;
			}
		}

		/// <summary>
		/// Void PreDispatch()
		/// </summary>
		protected RMethod r_RPreDispatch;
		public virtual RMethod RPreDispatch
		{
			get
			{
				if(r_RPreDispatch == null)
				{
					r_RPreDispatch = new(this, "PreDispatch", 0);
					r_RPreDispatch.SetBelong(this.instance);
				}
				return r_RPreDispatch;
			}
		}

		/// <summary>
		/// Void PreDispatch(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_RPreDispatch_IPanel;
		public virtual RMethod RPreDispatch_IPanel
		{
			get
			{
				if(r_RPreDispatch_IPanel == null)
				{
					r_RPreDispatch_IPanel = new(this, "PreDispatch", 0, typeof(UnityEngine.UIElements.IPanel));
					r_RPreDispatch_IPanel.SetBelong(this.instance);
				}
				return r_RPreDispatch_IPanel;
			}
		}

		/// <summary>
		/// Void PostDispatch()
		/// </summary>
		protected RMethod r_RPostDispatch;
		public virtual RMethod RPostDispatch
		{
			get
			{
				if(r_RPostDispatch == null)
				{
					r_RPostDispatch = new(this, "PostDispatch", 0);
					r_RPostDispatch.SetBelong(this.instance);
				}
				return r_RPostDispatch;
			}
		}

		/// <summary>
		/// Void PostDispatch(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_RPostDispatch_IPanel;
		public virtual RMethod RPostDispatch_IPanel
		{
			get
			{
				if(r_RPostDispatch_IPanel == null)
				{
					r_RPostDispatch_IPanel = new(this, "PostDispatch", 0, typeof(UnityEngine.UIElements.IPanel));
					r_RPostDispatch_IPanel.SetBelong(this.instance);
				}
				return r_RPostDispatch_IPanel;
			}
		}

		/// <summary>
		/// Boolean Skip(UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_RSkip_IEventHandler;
		public virtual RMethod RSkip_IEventHandler
		{
			get
			{
				if(r_RSkip_IEventHandler == null)
				{
					r_RSkip_IEventHandler = new(this, "Skip", 0, typeof(UnityEngine.UIElements.IEventHandler));
					r_RSkip_IEventHandler.SetBelong(this.instance);
				}
				return r_RSkip_IEventHandler;
			}
		}

		/// <summary>
		/// Void StopPropagation()
		/// </summary>
		protected RMethod r_RStopPropagation;
		public virtual RMethod RStopPropagation
		{
			get
			{
				if(r_RStopPropagation == null)
				{
					r_RStopPropagation = new(this, "StopPropagation", 0);
					r_RStopPropagation.SetBelong(this.instance);
				}
				return r_RStopPropagation;
			}
		}

		/// <summary>
		/// Void StopImmediatePropagation()
		/// </summary>
		protected RMethod r_RStopImmediatePropagation;
		public virtual RMethod RStopImmediatePropagation
		{
			get
			{
				if(r_RStopImmediatePropagation == null)
				{
					r_RStopImmediatePropagation = new(this, "StopImmediatePropagation", 0);
					r_RStopImmediatePropagation.SetBelong(this.instance);
				}
				return r_RStopImmediatePropagation;
			}
		}

		/// <summary>
		/// Void PreventDefault()
		/// </summary>
		protected RMethod r_RPreventDefault;
		public virtual RMethod RPreventDefault
		{
			get
			{
				if(r_RPreventDefault == null)
				{
					r_RPreventDefault = new(this, "PreventDefault", 0);
					r_RPreventDefault.SetBelong(this.instance);
				}
				return r_RPreventDefault;
			}
		}

		/// <summary>
		/// Void MarkReceivedByDispatcher()
		/// </summary>
		protected RMethod r_RMarkReceivedByDispatcher;
		public virtual RMethod RMarkReceivedByDispatcher
		{
			get
			{
				if(r_RMarkReceivedByDispatcher == null)
				{
					r_RMarkReceivedByDispatcher = new(this, "MarkReceivedByDispatcher", 0);
					r_RMarkReceivedByDispatcher.SetBelong(this.instance);
				}
				return r_RMarkReceivedByDispatcher;
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


        public RGeometryChangedEvent() : base("UnityEngine.UIElements.GeometryChangedEvent")
        {
        }

        public RGeometryChangedEvent(System.Object instance) : base("UnityEngine.UIElements.GeometryChangedEvent")
		{
            SetInstance(instance);
		}

        public RGeometryChangedEvent(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGeometryChangedEvent(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.UIElements.GeometryChangedEvent GetPooled(UnityEngine.Rect  @oldRect, UnityEngine.Rect  @newRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldRect, @newRect};
            var ___result = RGetPooled_Rect_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.GeometryChangedEvent)___result;
        }


        public virtual void Init()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInit.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LocalInit()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLocalInit.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Acquire()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAcquire.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriggerEventId(System.UInt64  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RSetTriggerEventId_UInt64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PreDispatch()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPreDispatch.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PreDispatch(UnityEngine.UIElements.IPanel  @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RPreDispatch_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PostDispatch()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPostDispatch.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PostDispatch(UnityEngine.UIElements.IPanel  @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RPostDispatch_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Skip(UnityEngine.UIElements.IEventHandler  @h)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@h};
            var ___result = RSkip_IEventHandler.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void StopPropagation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStopPropagation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopImmediatePropagation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStopImmediatePropagation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PreventDefault()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPreventDefault.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkReceivedByDispatcher()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMarkReceivedByDispatcher.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
