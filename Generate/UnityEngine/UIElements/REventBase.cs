using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.EventBase
	/// </summary>
    public partial class REventBase : RMember //
    {

		/// <summary>
		/// System.Int64 s_LastTypeId
		/// </summary>
		protected static RField r_s_LastTypeId;
		public static RField Rs_LastTypeId
		{
			get
			{
				if(r_s_LastTypeId == null)
				{
					r_s_LastTypeId = new(typeof(UnityEngine.UIElements.EventBase), "s_LastTypeId");
					r_s_LastTypeId.SetBelong(null);
				}
				return r_s_LastTypeId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCategory <eventCategory>k__BackingField
		/// </summary>
		protected RField r___1__eventCategory__2__k__BackingField;
		public virtual RField R__1__eventCategory__2__k__BackingField
		{
			get
			{
				if(r___1__eventCategory__2__k__BackingField == null)
				{
					r___1__eventCategory__2__k__BackingField = new(this, "<eventCategory>k__BackingField");
					r___1__eventCategory__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__eventCategory__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.UInt64 s_NextEventId
		/// </summary>
		protected static RField r_s_NextEventId;
		public static RField Rs_NextEventId
		{
			get
			{
				if(r_s_NextEventId == null)
				{
					r_s_NextEventId = new(typeof(UnityEngine.UIElements.EventBase), "s_NextEventId");
					r_s_NextEventId.SetBelong(null);
				}
				return r_s_NextEventId;
			}
		}

		/// <summary>
		/// System.Int64 <timestamp>k__BackingField
		/// </summary>
		protected RField r___1__timestamp__2__k__BackingField;
		public virtual RField R__1__timestamp__2__k__BackingField
		{
			get
			{
				if(r___1__timestamp__2__k__BackingField == null)
				{
					r___1__timestamp__2__k__BackingField = new(this, "<timestamp>k__BackingField");
					r___1__timestamp__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__timestamp__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.UInt64 <eventId>k__BackingField
		/// </summary>
		protected RField r___1__eventId__2__k__BackingField;
		public virtual RField R__1__eventId__2__k__BackingField
		{
			get
			{
				if(r___1__eventId__2__k__BackingField == null)
				{
					r___1__eventId__2__k__BackingField = new(this, "<eventId>k__BackingField");
					r___1__eventId__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__eventId__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.UInt64 <triggerEventId>k__BackingField
		/// </summary>
		protected RField r___1__triggerEventId__2__k__BackingField;
		public virtual RField R__1__triggerEventId__2__k__BackingField
		{
			get
			{
				if(r___1__triggerEventId__2__k__BackingField == null)
				{
					r___1__triggerEventId__2__k__BackingField = new(this, "<triggerEventId>k__BackingField");
					r___1__triggerEventId__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__triggerEventId__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventBase+EventPropagation <propagation>k__BackingField
		/// </summary>
		protected RField r___1__propagation__2__k__BackingField;
		public virtual RField R__1__propagation__2__k__BackingField
		{
			get
			{
				if(r___1__propagation__2__k__BackingField == null)
				{
					r___1__propagation__2__k__BackingField = new(this, "<propagation>k__BackingField");
					r___1__propagation__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__propagation__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PropagationPaths <path>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RPropagationPaths r___1__path__2__k__BackingField;
		public virtual RUnityEngine.RUIElements.RPropagationPaths R__1__path__2__k__BackingField
		{
			get
			{
				if(r___1__path__2__k__BackingField == null)
				{
					r___1__path__2__k__BackingField = new(this, "<path>k__BackingField");
					r___1__path__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__path__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventBase+LifeCycleStatus <lifeCycleStatus>k__BackingField
		/// </summary>
		protected RField r___1__lifeCycleStatus__2__k__BackingField;
		public virtual RField R__1__lifeCycleStatus__2__k__BackingField
		{
			get
			{
				if(r___1__lifeCycleStatus__2__k__BackingField == null)
				{
					r___1__lifeCycleStatus__2__k__BackingField = new(this, "<lifeCycleStatus>k__BackingField");
					r___1__lifeCycleStatus__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__lifeCycleStatus__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler <leafTarget>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RIEventHandler r___1__leafTarget__2__k__BackingField;
		public virtual RUnityEngine.RUIElements.RIEventHandler R__1__leafTarget__2__k__BackingField
		{
			get
			{
				if(r___1__leafTarget__2__k__BackingField == null)
				{
					r___1__leafTarget__2__k__BackingField = new(this, "<leafTarget>k__BackingField");
					r___1__leafTarget__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__leafTarget__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler m_Target
		/// </summary>
		protected RUnityEngine.RUIElements.RIEventHandler r_m_Target;
		public virtual RUnityEngine.RUIElements.RIEventHandler Rm_Target
		{
			get
			{
				if(r_m_Target == null)
				{
					r_m_Target = new(this, "m_Target");
					r_m_Target.SetBelong(this.instance);
				}
				return r_m_Target;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.IEventHandler] <skipElements>k__BackingField
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RIEventHandler> r___1__skipElements__2__k__BackingField;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RIEventHandler> R__1__skipElements__2__k__BackingField
		{
			get
			{
				if(r___1__skipElements__2__k__BackingField == null)
				{
					r___1__skipElements__2__k__BackingField = new(this, "<skipElements>k__BackingField");
					r___1__skipElements__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__skipElements__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PropagationPhase <propagationPhase>k__BackingField
		/// </summary>
		protected RField r___1__propagationPhase__2__k__BackingField;
		public virtual RField R__1__propagationPhase__2__k__BackingField
		{
			get
			{
				if(r___1__propagationPhase__2__k__BackingField == null)
				{
					r___1__propagationPhase__2__k__BackingField = new(this, "<propagationPhase>k__BackingField");
					r___1__propagationPhase__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__propagationPhase__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler m_CurrentTarget
		/// </summary>
		protected RUnityEngine.RUIElements.RIEventHandler r_m_CurrentTarget;
		public virtual RUnityEngine.RUIElements.RIEventHandler Rm_CurrentTarget
		{
			get
			{
				if(r_m_CurrentTarget == null)
				{
					r_m_CurrentTarget = new(this, "m_CurrentTarget");
					r_m_CurrentTarget.SetBelong(this.instance);
				}
				return r_m_CurrentTarget;
			}
		}

		/// <summary>
		/// UnityEngine.Event m_ImguiEvent
		/// </summary>
		protected RUnityEngine.REvent r_m_ImguiEvent;
		public virtual RUnityEngine.REvent Rm_ImguiEvent
		{
			get
			{
				if(r_m_ImguiEvent == null)
				{
					r_m_ImguiEvent = new(this, "m_ImguiEvent");
					r_m_ImguiEvent.SetBelong(this.instance);
				}
				return r_m_ImguiEvent;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 <originalMousePosition>k__BackingField
		/// </summary>
		protected RUnityEngine.RVector2 r___1__originalMousePosition__2__k__BackingField;
		public virtual RUnityEngine.RVector2 R__1__originalMousePosition__2__k__BackingField
		{
			get
			{
				if(r___1__originalMousePosition__2__k__BackingField == null)
				{
					r___1__originalMousePosition__2__k__BackingField = new(this, "<originalMousePosition>k__BackingField");
					r___1__originalMousePosition__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__originalMousePosition__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventDebugger <eventLogger>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.REventDebugger r___1__eventLogger__2__k__BackingField;
		public virtual RUnityEngine.RUIElements.REventDebugger R__1__eventLogger__2__k__BackingField
		{
			get
			{
				if(r___1__eventLogger__2__k__BackingField == null)
				{
					r___1__eventLogger__2__k__BackingField = new(this, "<eventLogger>k__BackingField");
					r___1__eventLogger__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__eventLogger__2__k__BackingField;
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
		/// LifeCycleStatus lifeCycleStatus
		/// </summary>
		protected RProperty r_lifeCycleStatus;
		public virtual RProperty RlifeCycleStatus
		{
			get
			{
				if(r_lifeCycleStatus == null)
				{
					r_lifeCycleStatus = new(this, "lifeCycleStatus", -1);
					r_lifeCycleStatus.SetBelong(this.instance);
				}
				return r_lifeCycleStatus;
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
		/// Boolean dispatched
		/// </summary>
		protected RProperty r_dispatched;
		public virtual RProperty Rdispatched
		{
			get
			{
				if(r_dispatched == null)
				{
					r_dispatched = new(this, "dispatched", -1);
					r_dispatched.SetBelong(this.instance);
				}
				return r_dispatched;
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
		/// Boolean imguiEventIsValid
		/// </summary>
		protected RProperty r_imguiEventIsValid;
		public virtual RProperty RimguiEventIsValid
		{
			get
			{
				if(r_imguiEventIsValid == null)
				{
					r_imguiEventIsValid = new(this, "imguiEventIsValid", -1);
					r_imguiEventIsValid.SetBelong(this.instance);
				}
				return r_imguiEventIsValid;
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
		/// Int64 RegisterEventType()
		/// </summary>
		protected static RMethod r_RRegisterEventType;
		public static RMethod RRegisterEventType
		{
			get
			{
				if(r_RRegisterEventType == null)
				{
					r_RRegisterEventType = new(typeof(UnityEngine.UIElements.EventBase), "RegisterEventType", 0);
					r_RRegisterEventType.SetBelong(null);
				}
				return r_RRegisterEventType;
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


        public REventBase() : base("UnityEngine.UIElements.EventBase")
        {
        }

        public REventBase(System.Object instance) : base("UnityEngine.UIElements.EventBase")
		{
            SetInstance(instance);
		}

        public REventBase(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REventBase(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Int64 RegisterEventType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRegisterEventType.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
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