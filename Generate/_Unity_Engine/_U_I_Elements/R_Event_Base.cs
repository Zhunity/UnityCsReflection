
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.UIElements.EventBase
	/// </summary>
    public partial class REventBase : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.EventBase);
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


		/// <summary>
		/// System.Int64 s_LastTypeId
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt64 r_Fs_LastTypeId;
		public static Hvak.Editor.Refleaction.RSystem.RInt64 RFs_LastTypeId
		{
			get
			{
				if(r_Fs_LastTypeId == null)
				{
					r_Fs_LastTypeId = new(Type, "s_LastTypeId");
				}
				return r_Fs_LastTypeId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCategory <eventCategory>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory r_F__0__eventCategory__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory RF__0__eventCategory__1__k__BackingField
		{
			get
			{
				if(r_F__0__eventCategory__1__k__BackingField == null)
				{
					r_F__0__eventCategory__1__k__BackingField = new(this, "<eventCategory>k__BackingField");
				}
				return r_F__0__eventCategory__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.UInt64 s_NextEventId
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt64 r_Fs_NextEventId;
		public static Hvak.Editor.Refleaction.RSystem.RUInt64 RFs_NextEventId
		{
			get
			{
				if(r_Fs_NextEventId == null)
				{
					r_Fs_NextEventId = new(Type, "s_NextEventId");
				}
				return r_Fs_NextEventId;
			}
		}

		/// <summary>
		/// System.Int64 <timestamp>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_F__0__timestamp__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RF__0__timestamp__1__k__BackingField
		{
			get
			{
				if(r_F__0__timestamp__1__k__BackingField == null)
				{
					r_F__0__timestamp__1__k__BackingField = new(this, "<timestamp>k__BackingField");
				}
				return r_F__0__timestamp__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.UInt64 <eventId>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt64 r_F__0__eventId__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt64 RF__0__eventId__1__k__BackingField
		{
			get
			{
				if(r_F__0__eventId__1__k__BackingField == null)
				{
					r_F__0__eventId__1__k__BackingField = new(this, "<eventId>k__BackingField");
				}
				return r_F__0__eventId__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.UInt64 <triggerEventId>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt64 r_F__0__triggerEventId__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt64 RF__0__triggerEventId__1__k__BackingField
		{
			get
			{
				if(r_F__0__triggerEventId__1__k__BackingField == null)
				{
					r_F__0__triggerEventId__1__k__BackingField = new(this, "<triggerEventId>k__BackingField");
				}
				return r_F__0__triggerEventId__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventBase+EventPropagation <propagation>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.REventPropagation r_F__0__propagation__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.REventPropagation RF__0__propagation__1__k__BackingField
		{
			get
			{
				if(r_F__0__propagation__1__k__BackingField == null)
				{
					r_F__0__propagation__1__k__BackingField = new(this, "<propagation>k__BackingField");
				}
				return r_F__0__propagation__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PropagationPaths <path>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPropagationPaths r_F__0__path__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPropagationPaths RF__0__path__1__k__BackingField
		{
			get
			{
				if(r_F__0__path__1__k__BackingField == null)
				{
					r_F__0__path__1__k__BackingField = new(this, "<path>k__BackingField");
				}
				return r_F__0__path__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventBase+LifeCycleStatus <lifeCycleStatus>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus r_F__0__lifeCycleStatus__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus RF__0__lifeCycleStatus__1__k__BackingField
		{
			get
			{
				if(r_F__0__lifeCycleStatus__1__k__BackingField == null)
				{
					r_F__0__lifeCycleStatus__1__k__BackingField = new(this, "<lifeCycleStatus>k__BackingField");
				}
				return r_F__0__lifeCycleStatus__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler <leafTarget>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIEventHandler r_F__0__leafTarget__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIEventHandler RF__0__leafTarget__1__k__BackingField
		{
			get
			{
				if(r_F__0__leafTarget__1__k__BackingField == null)
				{
					r_F__0__leafTarget__1__k__BackingField = new(this, "<leafTarget>k__BackingField");
				}
				return r_F__0__leafTarget__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler m_Target
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIEventHandler r_Fm_Target;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIEventHandler RFm_Target
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
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.IEventHandler] <skipElements>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIEventHandler> r_F__0__skipElements__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIEventHandler> RF__0__skipElements__1__k__BackingField
		{
			get
			{
				if(r_F__0__skipElements__1__k__BackingField == null)
				{
					r_F__0__skipElements__1__k__BackingField = new(this, "<skipElements>k__BackingField");
				}
				return r_F__0__skipElements__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PropagationPhase <propagationPhase>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPropagationPhase r_F__0__propagationPhase__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPropagationPhase RF__0__propagationPhase__1__k__BackingField
		{
			get
			{
				if(r_F__0__propagationPhase__1__k__BackingField == null)
				{
					r_F__0__propagationPhase__1__k__BackingField = new(this, "<propagationPhase>k__BackingField");
				}
				return r_F__0__propagationPhase__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler m_CurrentTarget
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIEventHandler r_Fm_CurrentTarget;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIEventHandler RFm_CurrentTarget
		{
			get
			{
				if(r_Fm_CurrentTarget == null)
				{
					r_Fm_CurrentTarget = new(this, "m_CurrentTarget");
				}
				return r_Fm_CurrentTarget;
			}
		}

		/// <summary>
		/// UnityEngine.Event m_ImguiEvent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.REvent r_Fm_ImguiEvent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.REvent RFm_ImguiEvent
		{
			get
			{
				if(r_Fm_ImguiEvent == null)
				{
					r_Fm_ImguiEvent = new(this, "m_ImguiEvent");
				}
				return r_Fm_ImguiEvent;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 <originalMousePosition>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_F__0__originalMousePosition__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RF__0__originalMousePosition__1__k__BackingField
		{
			get
			{
				if(r_F__0__originalMousePosition__1__k__BackingField == null)
				{
					r_F__0__originalMousePosition__1__k__BackingField = new(this, "<originalMousePosition>k__BackingField");
				}
				return r_F__0__originalMousePosition__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventDebugger <eventLogger>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebugger r_F__0__eventLogger__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebugger RF__0__eventLogger__1__k__BackingField
		{
			get
			{
				if(r_F__0__eventLogger__1__k__BackingField == null)
				{
					r_F__0__eventLogger__1__k__BackingField = new(this, "<eventLogger>k__BackingField");
				}
				return r_F__0__eventLogger__1__k__BackingField;
			}
		}

		/// <summary>
		/// Int64 eventTypeId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_PeventTypeId;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPeventTypeId
		{
			get
			{
				if(r_PeventTypeId == null)
				{
					r_PeventTypeId = new(this, "eventTypeId", -1);
				}
				return r_PeventTypeId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCategory eventCategory
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory r_PeventCategory;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory RPeventCategory
		{
			get
			{
				if(r_PeventCategory == null)
				{
					r_PeventCategory = new(this, "eventCategory", -1);
				}
				return r_PeventCategory;
			}
		}

		/// <summary>
		/// Int64 timestamp
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Ptimestamp;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPtimestamp
		{
			get
			{
				if(r_Ptimestamp == null)
				{
					r_Ptimestamp = new(this, "timestamp", -1);
				}
				return r_Ptimestamp;
			}
		}

		/// <summary>
		/// UInt64 eventId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt64 r_PeventId;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt64 RPeventId
		{
			get
			{
				if(r_PeventId == null)
				{
					r_PeventId = new(this, "eventId", -1);
				}
				return r_PeventId;
			}
		}

		/// <summary>
		/// UInt64 triggerEventId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt64 r_PtriggerEventId;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt64 RPtriggerEventId
		{
			get
			{
				if(r_PtriggerEventId == null)
				{
					r_PtriggerEventId = new(this, "triggerEventId", -1);
				}
				return r_PtriggerEventId;
			}
		}

		/// <summary>
		/// EventPropagation propagation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.REventPropagation r_Ppropagation;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.REventPropagation RPpropagation
		{
			get
			{
				if(r_Ppropagation == null)
				{
					r_Ppropagation = new(this, "propagation", -1);
				}
				return r_Ppropagation;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PropagationPaths path
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPropagationPaths r_Ppath;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPropagationPaths RPpath
		{
			get
			{
				if(r_Ppath == null)
				{
					r_Ppath = new(this, "path", -1);
				}
				return r_Ppath;
			}
		}

		/// <summary>
		/// LifeCycleStatus lifeCycleStatus
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus r_PlifeCycleStatus;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus RPlifeCycleStatus
		{
			get
			{
				if(r_PlifeCycleStatus == null)
				{
					r_PlifeCycleStatus = new(this, "lifeCycleStatus", -1);
				}
				return r_PlifeCycleStatus;
			}
		}

		/// <summary>
		/// Boolean bubbles
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pbubbles;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPbubbles
		{
			get
			{
				if(r_Pbubbles == null)
				{
					r_Pbubbles = new(this, "bubbles", -1);
				}
				return r_Pbubbles;
			}
		}

		/// <summary>
		/// Boolean tricklesDown
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PtricklesDown;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPtricklesDown
		{
			get
			{
				if(r_PtricklesDown == null)
				{
					r_PtricklesDown = new(this, "tricklesDown", -1);
				}
				return r_PtricklesDown;
			}
		}

		/// <summary>
		/// Boolean bubblesOrTricklesDown
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PbubblesOrTricklesDown;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPbubblesOrTricklesDown
		{
			get
			{
				if(r_PbubblesOrTricklesDown == null)
				{
					r_PbubblesOrTricklesDown = new(this, "bubblesOrTricklesDown", -1);
				}
				return r_PbubblesOrTricklesDown;
			}
		}

		/// <summary>
		/// Boolean skipDisabledElements
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PskipDisabledElements;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPskipDisabledElements
		{
			get
			{
				if(r_PskipDisabledElements == null)
				{
					r_PskipDisabledElements = new(this, "skipDisabledElements", -1);
				}
				return r_PskipDisabledElements;
			}
		}

		/// <summary>
		/// Boolean ignoreCompositeRoots
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PignoreCompositeRoots;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPignoreCompositeRoots
		{
			get
			{
				if(r_PignoreCompositeRoots == null)
				{
					r_PignoreCompositeRoots = new(this, "ignoreCompositeRoots", -1);
				}
				return r_PignoreCompositeRoots;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler leafTarget
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIEventHandler r_PleafTarget;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIEventHandler RPleafTarget
		{
			get
			{
				if(r_PleafTarget == null)
				{
					r_PleafTarget = new(this, "leafTarget", -1);
				}
				return r_PleafTarget;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler target
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIEventHandler r_Ptarget;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIEventHandler RPtarget
		{
			get
			{
				if(r_Ptarget == null)
				{
					r_Ptarget = new(this, "target", -1);
				}
				return r_Ptarget;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.IEventHandler] skipElements
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIEventHandler> r_PskipElements;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIEventHandler> RPskipElements
		{
			get
			{
				if(r_PskipElements == null)
				{
					r_PskipElements = new(this, "skipElements", -1);
				}
				return r_PskipElements;
			}
		}

		/// <summary>
		/// Boolean isPropagationStopped
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisPropagationStopped;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisPropagationStopped
		{
			get
			{
				if(r_PisPropagationStopped == null)
				{
					r_PisPropagationStopped = new(this, "isPropagationStopped", -1);
				}
				return r_PisPropagationStopped;
			}
		}

		/// <summary>
		/// Boolean isImmediatePropagationStopped
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisImmediatePropagationStopped;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisImmediatePropagationStopped
		{
			get
			{
				if(r_PisImmediatePropagationStopped == null)
				{
					r_PisImmediatePropagationStopped = new(this, "isImmediatePropagationStopped", -1);
				}
				return r_PisImmediatePropagationStopped;
			}
		}

		/// <summary>
		/// Boolean isDefaultPrevented
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisDefaultPrevented;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisDefaultPrevented
		{
			get
			{
				if(r_PisDefaultPrevented == null)
				{
					r_PisDefaultPrevented = new(this, "isDefaultPrevented", -1);
				}
				return r_PisDefaultPrevented;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PropagationPhase propagationPhase
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPropagationPhase r_PpropagationPhase;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPropagationPhase RPpropagationPhase
		{
			get
			{
				if(r_PpropagationPhase == null)
				{
					r_PpropagationPhase = new(this, "propagationPhase", -1);
				}
				return r_PpropagationPhase;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler currentTarget
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIEventHandler r_PcurrentTarget;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIEventHandler RPcurrentTarget
		{
			get
			{
				if(r_PcurrentTarget == null)
				{
					r_PcurrentTarget = new(this, "currentTarget", -1);
				}
				return r_PcurrentTarget;
			}
		}

		/// <summary>
		/// Boolean dispatch
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pdispatch;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdispatch
		{
			get
			{
				if(r_Pdispatch == null)
				{
					r_Pdispatch = new(this, "dispatch", -1);
				}
				return r_Pdispatch;
			}
		}

		/// <summary>
		/// Boolean dispatched
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pdispatched;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdispatched
		{
			get
			{
				if(r_Pdispatched == null)
				{
					r_Pdispatched = new(this, "dispatched", -1);
				}
				return r_Pdispatched;
			}
		}

		/// <summary>
		/// Boolean processed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pprocessed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPprocessed
		{
			get
			{
				if(r_Pprocessed == null)
				{
					r_Pprocessed = new(this, "processed", -1);
				}
				return r_Pprocessed;
			}
		}

		/// <summary>
		/// Boolean processedByFocusController
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PprocessedByFocusController;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPprocessedByFocusController
		{
			get
			{
				if(r_PprocessedByFocusController == null)
				{
					r_PprocessedByFocusController = new(this, "processedByFocusController", -1);
				}
				return r_PprocessedByFocusController;
			}
		}

		/// <summary>
		/// Boolean stopDispatch
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PstopDispatch;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPstopDispatch
		{
			get
			{
				if(r_PstopDispatch == null)
				{
					r_PstopDispatch = new(this, "stopDispatch", -1);
				}
				return r_PstopDispatch;
			}
		}

		/// <summary>
		/// Boolean propagateToIMGUI
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PpropagateToIMGUI;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPpropagateToIMGUI
		{
			get
			{
				if(r_PpropagateToIMGUI == null)
				{
					r_PpropagateToIMGUI = new(this, "propagateToIMGUI", -1);
				}
				return r_PpropagateToIMGUI;
			}
		}

		/// <summary>
		/// Boolean imguiEventIsValid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PimguiEventIsValid;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPimguiEventIsValid
		{
			get
			{
				if(r_PimguiEventIsValid == null)
				{
					r_PimguiEventIsValid = new(this, "imguiEventIsValid", -1);
				}
				return r_PimguiEventIsValid;
			}
		}

		/// <summary>
		/// UnityEngine.Event imguiEvent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.REvent r_PimguiEvent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.REvent RPimguiEvent
		{
			get
			{
				if(r_PimguiEvent == null)
				{
					r_PimguiEvent = new(this, "imguiEvent", -1);
				}
				return r_PimguiEvent;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 originalMousePosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PoriginalMousePosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPoriginalMousePosition
		{
			get
			{
				if(r_PoriginalMousePosition == null)
				{
					r_PoriginalMousePosition = new(this, "originalMousePosition", -1);
				}
				return r_PoriginalMousePosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventDebugger eventLogger
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebugger r_PeventLogger;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebugger RPeventLogger
		{
			get
			{
				if(r_PeventLogger == null)
				{
					r_PeventLogger = new(this, "eventLogger", -1);
				}
				return r_PeventLogger;
			}
		}

		/// <summary>
		/// Boolean log
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Plog;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPlog
		{
			get
			{
				if(r_Plog == null)
				{
					r_Plog = new(this, "log", -1);
				}
				return r_Plog;
			}
		}

		/// <summary>
		/// Boolean pooled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Ppooled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPpooled
		{
			get
			{
				if(r_Ppooled == null)
				{
					r_Ppooled = new(this, "pooled", -1);
				}
				return r_Ppooled;
			}
		}

		/// <summary>
		/// Int64 RegisterEventType()
		/// </summary>
		protected static RMethod r_MRegisterEventType;
		public static RMethod RMRegisterEventType
		{
			get
			{
				if(r_MRegisterEventType == null)
				{
					r_MRegisterEventType = new(Type, "RegisterEventType", 0);
				}
				return r_MRegisterEventType;
			}
		}

		/// <summary>
		/// Void SetTriggerEventId(UInt64)
		/// </summary>
		protected RMethod r_MSetTriggerEventId_UInt64;
		public virtual RMethod RMSetTriggerEventId_UInt64
		{
			get
			{
				if(r_MSetTriggerEventId_UInt64 == null)
				{
					r_MSetTriggerEventId_UInt64 = new(this, "SetTriggerEventId", 0, typeof(System.UInt64));
				}
				return r_MSetTriggerEventId_UInt64;
			}
		}

		/// <summary>
		/// Void PreDispatch()
		/// </summary>
		protected RMethod r_MPreDispatch;
		public virtual RMethod RMPreDispatch
		{
			get
			{
				if(r_MPreDispatch == null)
				{
					r_MPreDispatch = new(this, "PreDispatch", 0);
				}
				return r_MPreDispatch;
			}
		}

		/// <summary>
		/// Void PreDispatch(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_MPreDispatch_IPanel;
		public virtual RMethod RMPreDispatch_IPanel
		{
			get
			{
				if(r_MPreDispatch_IPanel == null)
				{
					r_MPreDispatch_IPanel = new(this, "PreDispatch", 0, typeof(UnityEngine.UIElements.IPanel));
				}
				return r_MPreDispatch_IPanel;
			}
		}

		/// <summary>
		/// Void PostDispatch()
		/// </summary>
		protected RMethod r_MPostDispatch;
		public virtual RMethod RMPostDispatch
		{
			get
			{
				if(r_MPostDispatch == null)
				{
					r_MPostDispatch = new(this, "PostDispatch", 0);
				}
				return r_MPostDispatch;
			}
		}

		/// <summary>
		/// Void PostDispatch(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_MPostDispatch_IPanel;
		public virtual RMethod RMPostDispatch_IPanel
		{
			get
			{
				if(r_MPostDispatch_IPanel == null)
				{
					r_MPostDispatch_IPanel = new(this, "PostDispatch", 0, typeof(UnityEngine.UIElements.IPanel));
				}
				return r_MPostDispatch_IPanel;
			}
		}

		/// <summary>
		/// Boolean Skip(UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_MSkip_IEventHandler;
		public virtual RMethod RMSkip_IEventHandler
		{
			get
			{
				if(r_MSkip_IEventHandler == null)
				{
					r_MSkip_IEventHandler = new(this, "Skip", 0, typeof(UnityEngine.UIElements.IEventHandler));
				}
				return r_MSkip_IEventHandler;
			}
		}

		/// <summary>
		/// Void StopPropagation()
		/// </summary>
		protected RMethod r_MStopPropagation;
		public virtual RMethod RMStopPropagation
		{
			get
			{
				if(r_MStopPropagation == null)
				{
					r_MStopPropagation = new(this, "StopPropagation", 0);
				}
				return r_MStopPropagation;
			}
		}

		/// <summary>
		/// Void StopImmediatePropagation()
		/// </summary>
		protected RMethod r_MStopImmediatePropagation;
		public virtual RMethod RMStopImmediatePropagation
		{
			get
			{
				if(r_MStopImmediatePropagation == null)
				{
					r_MStopImmediatePropagation = new(this, "StopImmediatePropagation", 0);
				}
				return r_MStopImmediatePropagation;
			}
		}

		/// <summary>
		/// Void PreventDefault()
		/// </summary>
		protected RMethod r_MPreventDefault;
		public virtual RMethod RMPreventDefault
		{
			get
			{
				if(r_MPreventDefault == null)
				{
					r_MPreventDefault = new(this, "PreventDefault", 0);
				}
				return r_MPreventDefault;
			}
		}

		/// <summary>
		/// Void MarkReceivedByDispatcher()
		/// </summary>
		protected RMethod r_MMarkReceivedByDispatcher;
		public virtual RMethod RMMarkReceivedByDispatcher
		{
			get
			{
				if(r_MMarkReceivedByDispatcher == null)
				{
					r_MMarkReceivedByDispatcher = new(this, "MarkReceivedByDispatcher", 0);
				}
				return r_MMarkReceivedByDispatcher;
			}
		}

		/// <summary>
		/// Void Init()
		/// </summary>
		protected RMethod r_MInit;
		public virtual RMethod RMInit
		{
			get
			{
				if(r_MInit == null)
				{
					r_MInit = new(this, "Init", 0);
				}
				return r_MInit;
			}
		}

		/// <summary>
		/// Void LocalInit()
		/// </summary>
		protected RMethod r_MLocalInit;
		public virtual RMethod RMLocalInit
		{
			get
			{
				if(r_MLocalInit == null)
				{
					r_MLocalInit = new(this, "LocalInit", 0);
				}
				return r_MLocalInit;
			}
		}

		/// <summary>
		/// Void Acquire()
		/// </summary>
		protected RMethod r_MAcquire;
		public virtual RMethod RMAcquire
		{
			get
			{
				if(r_MAcquire == null)
				{
					r_MAcquire = new(this, "Acquire", 0);
				}
				return r_MAcquire;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
				}
				return r_MDispose;
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


        public static System.Int64 RegisterEventType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRegisterEventType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int64>(___result);
        }


        public virtual void SetTriggerEventId(System.UInt64 @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RMSetTriggerEventId_UInt64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PreDispatch()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPreDispatch.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PreDispatch(UnityEngine.UIElements.IPanel @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RMPreDispatch_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PostDispatch()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPostDispatch.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PostDispatch(UnityEngine.UIElements.IPanel @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RMPostDispatch_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Skip(UnityEngine.UIElements.IEventHandler @h)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@h};
            var ___result = RMSkip_IEventHandler.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void StopPropagation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMStopPropagation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopImmediatePropagation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMStopImmediatePropagation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PreventDefault()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPreventDefault.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkReceivedByDispatcher()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMarkReceivedByDispatcher.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Init()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInit.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LocalInit()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMLocalInit.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Acquire()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAcquire.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
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
