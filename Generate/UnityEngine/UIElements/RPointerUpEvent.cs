using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.PointerUpEvent
	/// </summary>
    public partial class RPointerUpEvent : RMember //
    {

		/// <summary>
		/// Int32 pointerId
		/// </summary>
		protected RProperty r_pointerId;
		public virtual RProperty RpointerId
		{
			get
			{
				if(r_pointerId == null)
				{
					r_pointerId = new(this, "pointerId", -1);
					r_pointerId.SetBelong(this.instance);
				}
				return r_pointerId;
			}
		}

		/// <summary>
		/// System.String pointerType
		/// </summary>
		protected RProperty r_pointerType;
		public virtual RProperty RpointerType
		{
			get
			{
				if(r_pointerType == null)
				{
					r_pointerType = new(this, "pointerType", -1);
					r_pointerType.SetBelong(this.instance);
				}
				return r_pointerType;
			}
		}

		/// <summary>
		/// Boolean isPrimary
		/// </summary>
		protected RProperty r_isPrimary;
		public virtual RProperty RisPrimary
		{
			get
			{
				if(r_isPrimary == null)
				{
					r_isPrimary = new(this, "isPrimary", -1);
					r_isPrimary.SetBelong(this.instance);
				}
				return r_isPrimary;
			}
		}

		/// <summary>
		/// Int32 button
		/// </summary>
		protected RProperty r_button;
		public virtual RProperty Rbutton
		{
			get
			{
				if(r_button == null)
				{
					r_button = new(this, "button", -1);
					r_button.SetBelong(this.instance);
				}
				return r_button;
			}
		}

		/// <summary>
		/// Int32 pressedButtons
		/// </summary>
		protected RProperty r_pressedButtons;
		public virtual RProperty RpressedButtons
		{
			get
			{
				if(r_pressedButtons == null)
				{
					r_pressedButtons = new(this, "pressedButtons", -1);
					r_pressedButtons.SetBelong(this.instance);
				}
				return r_pressedButtons;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 position
		/// </summary>
		protected RUnityEngine.RVector3 r_position;
		public virtual RUnityEngine.RVector3 Rposition
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
		/// UnityEngine.Vector3 localPosition
		/// </summary>
		protected RUnityEngine.RVector3 r_localPosition;
		public virtual RUnityEngine.RVector3 RlocalPosition
		{
			get
			{
				if(r_localPosition == null)
				{
					r_localPosition = new(this, "localPosition", -1);
					r_localPosition.SetBelong(this.instance);
				}
				return r_localPosition;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 deltaPosition
		/// </summary>
		protected RUnityEngine.RVector3 r_deltaPosition;
		public virtual RUnityEngine.RVector3 RdeltaPosition
		{
			get
			{
				if(r_deltaPosition == null)
				{
					r_deltaPosition = new(this, "deltaPosition", -1);
					r_deltaPosition.SetBelong(this.instance);
				}
				return r_deltaPosition;
			}
		}

		/// <summary>
		/// Single deltaTime
		/// </summary>
		protected RProperty r_deltaTime;
		public virtual RProperty RdeltaTime
		{
			get
			{
				if(r_deltaTime == null)
				{
					r_deltaTime = new(this, "deltaTime", -1);
					r_deltaTime.SetBelong(this.instance);
				}
				return r_deltaTime;
			}
		}

		/// <summary>
		/// Int32 clickCount
		/// </summary>
		protected RProperty r_clickCount;
		public virtual RProperty RclickCount
		{
			get
			{
				if(r_clickCount == null)
				{
					r_clickCount = new(this, "clickCount", -1);
					r_clickCount.SetBelong(this.instance);
				}
				return r_clickCount;
			}
		}

		/// <summary>
		/// Single pressure
		/// </summary>
		protected RProperty r_pressure;
		public virtual RProperty Rpressure
		{
			get
			{
				if(r_pressure == null)
				{
					r_pressure = new(this, "pressure", -1);
					r_pressure.SetBelong(this.instance);
				}
				return r_pressure;
			}
		}

		/// <summary>
		/// Single tangentialPressure
		/// </summary>
		protected RProperty r_tangentialPressure;
		public virtual RProperty RtangentialPressure
		{
			get
			{
				if(r_tangentialPressure == null)
				{
					r_tangentialPressure = new(this, "tangentialPressure", -1);
					r_tangentialPressure.SetBelong(this.instance);
				}
				return r_tangentialPressure;
			}
		}

		/// <summary>
		/// Single altitudeAngle
		/// </summary>
		protected RProperty r_altitudeAngle;
		public virtual RProperty RaltitudeAngle
		{
			get
			{
				if(r_altitudeAngle == null)
				{
					r_altitudeAngle = new(this, "altitudeAngle", -1);
					r_altitudeAngle.SetBelong(this.instance);
				}
				return r_altitudeAngle;
			}
		}

		/// <summary>
		/// Single azimuthAngle
		/// </summary>
		protected RProperty r_azimuthAngle;
		public virtual RProperty RazimuthAngle
		{
			get
			{
				if(r_azimuthAngle == null)
				{
					r_azimuthAngle = new(this, "azimuthAngle", -1);
					r_azimuthAngle.SetBelong(this.instance);
				}
				return r_azimuthAngle;
			}
		}

		/// <summary>
		/// Single twist
		/// </summary>
		protected RProperty r_twist;
		public virtual RProperty Rtwist
		{
			get
			{
				if(r_twist == null)
				{
					r_twist = new(this, "twist", -1);
					r_twist.SetBelong(this.instance);
				}
				return r_twist;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 tilt
		/// </summary>
		protected RUnityEngine.RVector2 r_tilt;
		public virtual RUnityEngine.RVector2 Rtilt
		{
			get
			{
				if(r_tilt == null)
				{
					r_tilt = new(this, "tilt", -1);
					r_tilt.SetBelong(this.instance);
				}
				return r_tilt;
			}
		}

		/// <summary>
		/// UnityEngine.PenStatus penStatus
		/// </summary>
		protected RProperty r_penStatus;
		public virtual RProperty RpenStatus
		{
			get
			{
				if(r_penStatus == null)
				{
					r_penStatus = new(this, "penStatus", -1);
					r_penStatus.SetBelong(this.instance);
				}
				return r_penStatus;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 radius
		/// </summary>
		protected RUnityEngine.RVector2 r_radius;
		public virtual RUnityEngine.RVector2 Rradius
		{
			get
			{
				if(r_radius == null)
				{
					r_radius = new(this, "radius", -1);
					r_radius.SetBelong(this.instance);
				}
				return r_radius;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 radiusVariance
		/// </summary>
		protected RUnityEngine.RVector2 r_radiusVariance;
		public virtual RUnityEngine.RVector2 RradiusVariance
		{
			get
			{
				if(r_radiusVariance == null)
				{
					r_radiusVariance = new(this, "radiusVariance", -1);
					r_radiusVariance.SetBelong(this.instance);
				}
				return r_radiusVariance;
			}
		}

		/// <summary>
		/// UnityEngine.EventModifiers modifiers
		/// </summary>
		protected RProperty r_modifiers;
		public virtual RProperty Rmodifiers
		{
			get
			{
				if(r_modifiers == null)
				{
					r_modifiers = new(this, "modifiers", -1);
					r_modifiers.SetBelong(this.instance);
				}
				return r_modifiers;
			}
		}

		/// <summary>
		/// Boolean shiftKey
		/// </summary>
		protected RProperty r_shiftKey;
		public virtual RProperty RshiftKey
		{
			get
			{
				if(r_shiftKey == null)
				{
					r_shiftKey = new(this, "shiftKey", -1);
					r_shiftKey.SetBelong(this.instance);
				}
				return r_shiftKey;
			}
		}

		/// <summary>
		/// Boolean ctrlKey
		/// </summary>
		protected RProperty r_ctrlKey;
		public virtual RProperty RctrlKey
		{
			get
			{
				if(r_ctrlKey == null)
				{
					r_ctrlKey = new(this, "ctrlKey", -1);
					r_ctrlKey.SetBelong(this.instance);
				}
				return r_ctrlKey;
			}
		}

		/// <summary>
		/// Boolean commandKey
		/// </summary>
		protected RProperty r_commandKey;
		public virtual RProperty RcommandKey
		{
			get
			{
				if(r_commandKey == null)
				{
					r_commandKey = new(this, "commandKey", -1);
					r_commandKey.SetBelong(this.instance);
				}
				return r_commandKey;
			}
		}

		/// <summary>
		/// Boolean altKey
		/// </summary>
		protected RProperty r_altKey;
		public virtual RProperty RaltKey
		{
			get
			{
				if(r_altKey == null)
				{
					r_altKey = new(this, "altKey", -1);
					r_altKey.SetBelong(this.instance);
				}
				return r_altKey;
			}
		}

		/// <summary>
		/// Boolean actionKey
		/// </summary>
		protected RProperty r_actionKey;
		public virtual RProperty RactionKey
		{
			get
			{
				if(r_actionKey == null)
				{
					r_actionKey = new(this, "actionKey", -1);
					r_actionKey.SetBelong(this.instance);
				}
				return r_actionKey;
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
		/// Void Init()
		/// </summary>
		protected RMethod r_Init;
		public virtual RMethod RInit
		{
			get
			{
				if(r_Init == null)
				{
					r_Init = new(this, "Init", 0);
					r_Init.SetBelong(this.instance);
				}
				return r_Init;
			}
		}

		/// <summary>
		/// Void LocalInit()
		/// </summary>
		protected RMethod r_LocalInit;
		public virtual RMethod RLocalInit
		{
			get
			{
				if(r_LocalInit == null)
				{
					r_LocalInit = new(this, "LocalInit", 0);
					r_LocalInit.SetBelong(this.instance);
				}
				return r_LocalInit;
			}
		}

		/// <summary>
		/// Void PostDispatch(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_PostDispatch_IPanel;
		public virtual RMethod RPostDispatch_IPanel
		{
			get
			{
				if(r_PostDispatch_IPanel == null)
				{
					r_PostDispatch_IPanel = new(this, "PostDispatch", 0, typeof(UnityEngine.UIElements.IPanel));
					r_PostDispatch_IPanel.SetBelong(this.instance);
				}
				return r_PostDispatch_IPanel;
			}
		}

		/// <summary>
		/// Void PreDispatch(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_PreDispatch_IPanel;
		public virtual RMethod RPreDispatch_IPanel
		{
			get
			{
				if(r_PreDispatch_IPanel == null)
				{
					r_PreDispatch_IPanel = new(this, "PreDispatch", 0, typeof(UnityEngine.UIElements.IPanel));
					r_PreDispatch_IPanel.SetBelong(this.instance);
				}
				return r_PreDispatch_IPanel;
			}
		}

		/// <summary>
		/// Void Acquire()
		/// </summary>
		protected RMethod r_Acquire;
		public virtual RMethod RAcquire
		{
			get
			{
				if(r_Acquire == null)
				{
					r_Acquire = new(this, "Acquire", 0);
					r_Acquire.SetBelong(this.instance);
				}
				return r_Acquire;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_Dispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_Dispose == null)
				{
					r_Dispose = new(this, "Dispose", 0);
					r_Dispose.SetBelong(this.instance);
				}
				return r_Dispose;
			}
		}

		/// <summary>
		/// Void SetTriggerEventId(UInt64)
		/// </summary>
		protected RMethod r_SetTriggerEventId_UInt64;
		public virtual RMethod RSetTriggerEventId_UInt64
		{
			get
			{
				if(r_SetTriggerEventId_UInt64 == null)
				{
					r_SetTriggerEventId_UInt64 = new(this, "SetTriggerEventId", 0, typeof(System.UInt64));
					r_SetTriggerEventId_UInt64.SetBelong(this.instance);
				}
				return r_SetTriggerEventId_UInt64;
			}
		}

		/// <summary>
		/// Void PreDispatch()
		/// </summary>
		protected RMethod r_PreDispatch;
		public virtual RMethod RPreDispatch
		{
			get
			{
				if(r_PreDispatch == null)
				{
					r_PreDispatch = new(this, "PreDispatch", 0);
					r_PreDispatch.SetBelong(this.instance);
				}
				return r_PreDispatch;
			}
		}

		/// <summary>
		/// Void PostDispatch()
		/// </summary>
		protected RMethod r_PostDispatch;
		public virtual RMethod RPostDispatch
		{
			get
			{
				if(r_PostDispatch == null)
				{
					r_PostDispatch = new(this, "PostDispatch", 0);
					r_PostDispatch.SetBelong(this.instance);
				}
				return r_PostDispatch;
			}
		}

		/// <summary>
		/// Boolean Skip(UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_Skip_IEventHandler;
		public virtual RMethod RSkip_IEventHandler
		{
			get
			{
				if(r_Skip_IEventHandler == null)
				{
					r_Skip_IEventHandler = new(this, "Skip", 0, typeof(UnityEngine.UIElements.IEventHandler));
					r_Skip_IEventHandler.SetBelong(this.instance);
				}
				return r_Skip_IEventHandler;
			}
		}

		/// <summary>
		/// Void StopPropagation()
		/// </summary>
		protected RMethod r_StopPropagation;
		public virtual RMethod RStopPropagation
		{
			get
			{
				if(r_StopPropagation == null)
				{
					r_StopPropagation = new(this, "StopPropagation", 0);
					r_StopPropagation.SetBelong(this.instance);
				}
				return r_StopPropagation;
			}
		}

		/// <summary>
		/// Void StopImmediatePropagation()
		/// </summary>
		protected RMethod r_StopImmediatePropagation;
		public virtual RMethod RStopImmediatePropagation
		{
			get
			{
				if(r_StopImmediatePropagation == null)
				{
					r_StopImmediatePropagation = new(this, "StopImmediatePropagation", 0);
					r_StopImmediatePropagation.SetBelong(this.instance);
				}
				return r_StopImmediatePropagation;
			}
		}

		/// <summary>
		/// Void PreventDefault()
		/// </summary>
		protected RMethod r_PreventDefault;
		public virtual RMethod RPreventDefault
		{
			get
			{
				if(r_PreventDefault == null)
				{
					r_PreventDefault = new(this, "PreventDefault", 0);
					r_PreventDefault.SetBelong(this.instance);
				}
				return r_PreventDefault;
			}
		}

		/// <summary>
		/// Void MarkReceivedByDispatcher()
		/// </summary>
		protected RMethod r_MarkReceivedByDispatcher;
		public virtual RMethod RMarkReceivedByDispatcher
		{
			get
			{
				if(r_MarkReceivedByDispatcher == null)
				{
					r_MarkReceivedByDispatcher = new(this, "MarkReceivedByDispatcher", 0);
					r_MarkReceivedByDispatcher.SetBelong(this.instance);
				}
				return r_MarkReceivedByDispatcher;
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


        public RPointerUpEvent() : base("UnityEngine.UIElements.PointerUpEvent")
        {
        }

        public RPointerUpEvent(System.Object instance) : base("UnityEngine.UIElements.PointerUpEvent")
		{
            SetInstance(instance);
		}

        public RPointerUpEvent(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPointerUpEvent(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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


        public virtual void PostDispatch(UnityEngine.UIElements.IPanel @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RPostDispatch_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PreDispatch(UnityEngine.UIElements.IPanel @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RPreDispatch_IPanel.Invoke(___genericsType, ___parameters);

            
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


        public virtual void SetTriggerEventId(System.UInt64 @id)
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


        public virtual void PostDispatch()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPostDispatch.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Skip(UnityEngine.UIElements.IEventHandler @h)
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


        public virtual System.Boolean Equals(System.Object @obj)
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
