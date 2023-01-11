using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.EventDebuggerEventRecord
	/// </summary>
    public partial class REventDebuggerEventRecord : RMember //
    {

		/// <summary>
		/// System.String <eventBaseName>k__BackingField
		/// </summary>
		protected RSystem.RString r___0__eventBaseName__1__k__BackingField;
		public virtual RSystem.RString R__0__eventBaseName__1__k__BackingField
		{
			get
			{
				if(r___0__eventBaseName__1__k__BackingField == null)
				{
					r___0__eventBaseName__1__k__BackingField = new(this, "<eventBaseName>k__BackingField");
					r___0__eventBaseName__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__eventBaseName__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int64 <eventTypeId>k__BackingField
		/// </summary>
		protected RSystem.RInt64 r___0__eventTypeId__1__k__BackingField;
		public virtual RSystem.RInt64 R__0__eventTypeId__1__k__BackingField
		{
			get
			{
				if(r___0__eventTypeId__1__k__BackingField == null)
				{
					r___0__eventTypeId__1__k__BackingField = new(this, "<eventTypeId>k__BackingField");
					r___0__eventTypeId__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__eventTypeId__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.UInt64 <eventId>k__BackingField
		/// </summary>
		protected RSystem.RUInt64 r___0__eventId__1__k__BackingField;
		public virtual RSystem.RUInt64 R__0__eventId__1__k__BackingField
		{
			get
			{
				if(r___0__eventId__1__k__BackingField == null)
				{
					r___0__eventId__1__k__BackingField = new(this, "<eventId>k__BackingField");
					r___0__eventId__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__eventId__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.UInt64 <triggerEventId>k__BackingField
		/// </summary>
		protected RSystem.RUInt64 r___0__triggerEventId__1__k__BackingField;
		public virtual RSystem.RUInt64 R__0__triggerEventId__1__k__BackingField
		{
			get
			{
				if(r___0__triggerEventId__1__k__BackingField == null)
				{
					r___0__triggerEventId__1__k__BackingField = new(this, "<triggerEventId>k__BackingField");
					r___0__triggerEventId__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__triggerEventId__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int64 <timestamp>k__BackingField
		/// </summary>
		protected RSystem.RInt64 r___0__timestamp__1__k__BackingField;
		public virtual RSystem.RInt64 R__0__timestamp__1__k__BackingField
		{
			get
			{
				if(r___0__timestamp__1__k__BackingField == null)
				{
					r___0__timestamp__1__k__BackingField = new(this, "<timestamp>k__BackingField");
					r___0__timestamp__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__timestamp__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler <target>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RIEventHandler r___0__target__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RIEventHandler R__0__target__1__k__BackingField
		{
			get
			{
				if(r___0__target__1__k__BackingField == null)
				{
					r___0__target__1__k__BackingField = new(this, "<target>k__BackingField");
					r___0__target__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__target__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.IEventHandler] <skipElements>k__BackingField
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RIEventHandler> r___0__skipElements__1__k__BackingField;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RIEventHandler> R__0__skipElements__1__k__BackingField
		{
			get
			{
				if(r___0__skipElements__1__k__BackingField == null)
				{
					r___0__skipElements__1__k__BackingField = new(this, "<skipElements>k__BackingField");
					r___0__skipElements__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__skipElements__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <hasUnderlyingPhysicalEvent>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r___0__hasUnderlyingPhysicalEvent__1__k__BackingField;
		public virtual RSystem.RBoolean R__0__hasUnderlyingPhysicalEvent__1__k__BackingField
		{
			get
			{
				if(r___0__hasUnderlyingPhysicalEvent__1__k__BackingField == null)
				{
					r___0__hasUnderlyingPhysicalEvent__1__k__BackingField = new(this, "<hasUnderlyingPhysicalEvent>k__BackingField");
					r___0__hasUnderlyingPhysicalEvent__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__hasUnderlyingPhysicalEvent__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <isPropagationStopped>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r___0__isPropagationStopped__1__k__BackingField;
		public virtual RSystem.RBoolean R__0__isPropagationStopped__1__k__BackingField
		{
			get
			{
				if(r___0__isPropagationStopped__1__k__BackingField == null)
				{
					r___0__isPropagationStopped__1__k__BackingField = new(this, "<isPropagationStopped>k__BackingField");
					r___0__isPropagationStopped__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__isPropagationStopped__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <isImmediatePropagationStopped>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r___0__isImmediatePropagationStopped__1__k__BackingField;
		public virtual RSystem.RBoolean R__0__isImmediatePropagationStopped__1__k__BackingField
		{
			get
			{
				if(r___0__isImmediatePropagationStopped__1__k__BackingField == null)
				{
					r___0__isImmediatePropagationStopped__1__k__BackingField = new(this, "<isImmediatePropagationStopped>k__BackingField");
					r___0__isImmediatePropagationStopped__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__isImmediatePropagationStopped__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <isDefaultPrevented>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r___0__isDefaultPrevented__1__k__BackingField;
		public virtual RSystem.RBoolean R__0__isDefaultPrevented__1__k__BackingField
		{
			get
			{
				if(r___0__isDefaultPrevented__1__k__BackingField == null)
				{
					r___0__isDefaultPrevented__1__k__BackingField = new(this, "<isDefaultPrevented>k__BackingField");
					r___0__isDefaultPrevented__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__isDefaultPrevented__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PropagationPhase <propagationPhase>k__BackingField
		/// </summary>
		protected RField r___0__propagationPhase__1__k__BackingField;
		public virtual RField R__0__propagationPhase__1__k__BackingField
		{
			get
			{
				if(r___0__propagationPhase__1__k__BackingField == null)
				{
					r___0__propagationPhase__1__k__BackingField = new(this, "<propagationPhase>k__BackingField");
					r___0__propagationPhase__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__propagationPhase__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler <currentTarget>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RIEventHandler r___0__currentTarget__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RIEventHandler R__0__currentTarget__1__k__BackingField
		{
			get
			{
				if(r___0__currentTarget__1__k__BackingField == null)
				{
					r___0__currentTarget__1__k__BackingField = new(this, "<currentTarget>k__BackingField");
					r___0__currentTarget__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__currentTarget__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <dispatch>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r___0__dispatch__1__k__BackingField;
		public virtual RSystem.RBoolean R__0__dispatch__1__k__BackingField
		{
			get
			{
				if(r___0__dispatch__1__k__BackingField == null)
				{
					r___0__dispatch__1__k__BackingField = new(this, "<dispatch>k__BackingField");
					r___0__dispatch__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__dispatch__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 <originalMousePosition>k__BackingField
		/// </summary>
		protected RUnityEngine.RVector2 r___0__originalMousePosition__1__k__BackingField;
		public virtual RUnityEngine.RVector2 R__0__originalMousePosition__1__k__BackingField
		{
			get
			{
				if(r___0__originalMousePosition__1__k__BackingField == null)
				{
					r___0__originalMousePosition__1__k__BackingField = new(this, "<originalMousePosition>k__BackingField");
					r___0__originalMousePosition__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__originalMousePosition__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.EventModifiers <modifiers>k__BackingField
		/// </summary>
		protected RField r___0__modifiers__1__k__BackingField;
		public virtual RField R__0__modifiers__1__k__BackingField
		{
			get
			{
				if(r___0__modifiers__1__k__BackingField == null)
				{
					r___0__modifiers__1__k__BackingField = new(this, "<modifiers>k__BackingField");
					r___0__modifiers__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__modifiers__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 <mousePosition>k__BackingField
		/// </summary>
		protected RUnityEngine.RVector2 r___0__mousePosition__1__k__BackingField;
		public virtual RUnityEngine.RVector2 R__0__mousePosition__1__k__BackingField
		{
			get
			{
				if(r___0__mousePosition__1__k__BackingField == null)
				{
					r___0__mousePosition__1__k__BackingField = new(this, "<mousePosition>k__BackingField");
					r___0__mousePosition__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__mousePosition__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <clickCount>k__BackingField
		/// </summary>
		protected RSystem.RInt32 r___0__clickCount__1__k__BackingField;
		public virtual RSystem.RInt32 R__0__clickCount__1__k__BackingField
		{
			get
			{
				if(r___0__clickCount__1__k__BackingField == null)
				{
					r___0__clickCount__1__k__BackingField = new(this, "<clickCount>k__BackingField");
					r___0__clickCount__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__clickCount__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <button>k__BackingField
		/// </summary>
		protected RSystem.RInt32 r___0__button__1__k__BackingField;
		public virtual RSystem.RInt32 R__0__button__1__k__BackingField
		{
			get
			{
				if(r___0__button__1__k__BackingField == null)
				{
					r___0__button__1__k__BackingField = new(this, "<button>k__BackingField");
					r___0__button__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__button__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <pressedButtons>k__BackingField
		/// </summary>
		protected RSystem.RInt32 r___0__pressedButtons__1__k__BackingField;
		public virtual RSystem.RInt32 R__0__pressedButtons__1__k__BackingField
		{
			get
			{
				if(r___0__pressedButtons__1__k__BackingField == null)
				{
					r___0__pressedButtons__1__k__BackingField = new(this, "<pressedButtons>k__BackingField");
					r___0__pressedButtons__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__pressedButtons__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 <delta>k__BackingField
		/// </summary>
		protected RUnityEngine.RVector3 r___0__delta__1__k__BackingField;
		public virtual RUnityEngine.RVector3 R__0__delta__1__k__BackingField
		{
			get
			{
				if(r___0__delta__1__k__BackingField == null)
				{
					r___0__delta__1__k__BackingField = new(this, "<delta>k__BackingField");
					r___0__delta__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__delta__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Char <character>k__BackingField
		/// </summary>
		protected RSystem.RChar r___0__character__1__k__BackingField;
		public virtual RSystem.RChar R__0__character__1__k__BackingField
		{
			get
			{
				if(r___0__character__1__k__BackingField == null)
				{
					r___0__character__1__k__BackingField = new(this, "<character>k__BackingField");
					r___0__character__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__character__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode <keyCode>k__BackingField
		/// </summary>
		protected RField r___0__keyCode__1__k__BackingField;
		public virtual RField R__0__keyCode__1__k__BackingField
		{
			get
			{
				if(r___0__keyCode__1__k__BackingField == null)
				{
					r___0__keyCode__1__k__BackingField = new(this, "<keyCode>k__BackingField");
					r___0__keyCode__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__keyCode__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <commandName>k__BackingField
		/// </summary>
		protected RSystem.RString r___0__commandName__1__k__BackingField;
		public virtual RSystem.RString R__0__commandName__1__k__BackingField
		{
			get
			{
				if(r___0__commandName__1__k__BackingField == null)
				{
					r___0__commandName__1__k__BackingField = new(this, "<commandName>k__BackingField");
					r___0__commandName__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__commandName__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.NavigationDeviceType <deviceType>k__BackingField
		/// </summary>
		protected RField r___0__deviceType__1__k__BackingField;
		public virtual RField R__0__deviceType__1__k__BackingField
		{
			get
			{
				if(r___0__deviceType__1__k__BackingField == null)
				{
					r___0__deviceType__1__k__BackingField = new(this, "<deviceType>k__BackingField");
					r___0__deviceType__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__deviceType__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.NavigationMoveEvent+Direction <navigationDirection>k__BackingField
		/// </summary>
		protected RField r___0__navigationDirection__1__k__BackingField;
		public virtual RField R__0__navigationDirection__1__k__BackingField
		{
			get
			{
				if(r___0__navigationDirection__1__k__BackingField == null)
				{
					r___0__navigationDirection__1__k__BackingField = new(this, "<navigationDirection>k__BackingField");
					r___0__navigationDirection__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__navigationDirection__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String eventBaseName
		/// </summary>
		protected RSystem.RString r_eventBaseName;
		public virtual RSystem.RString ReventBaseName
		{
			get
			{
				if(r_eventBaseName == null)
				{
					r_eventBaseName = new(this, "eventBaseName", -1);
					r_eventBaseName.SetBelong(this.instance);
				}
				return r_eventBaseName;
			}
		}

		/// <summary>
		/// Int64 eventTypeId
		/// </summary>
		protected RSystem.RInt64 r_eventTypeId;
		public virtual RSystem.RInt64 ReventTypeId
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
		/// UInt64 eventId
		/// </summary>
		protected RSystem.RUInt64 r_eventId;
		public virtual RSystem.RUInt64 ReventId
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
		protected RSystem.RUInt64 r_triggerEventId;
		public virtual RSystem.RUInt64 RtriggerEventId
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
		/// Int64 timestamp
		/// </summary>
		protected RSystem.RInt64 r_timestamp;
		public virtual RSystem.RInt64 Rtimestamp
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
		/// Boolean hasUnderlyingPhysicalEvent
		/// </summary>
		protected RSystem.RBoolean r_hasUnderlyingPhysicalEvent;
		public virtual RSystem.RBoolean RhasUnderlyingPhysicalEvent
		{
			get
			{
				if(r_hasUnderlyingPhysicalEvent == null)
				{
					r_hasUnderlyingPhysicalEvent = new(this, "hasUnderlyingPhysicalEvent", -1);
					r_hasUnderlyingPhysicalEvent.SetBelong(this.instance);
				}
				return r_hasUnderlyingPhysicalEvent;
			}
		}

		/// <summary>
		/// Boolean isPropagationStopped
		/// </summary>
		protected RSystem.RBoolean r_isPropagationStopped;
		public virtual RSystem.RBoolean RisPropagationStopped
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
		protected RSystem.RBoolean r_isImmediatePropagationStopped;
		public virtual RSystem.RBoolean RisImmediatePropagationStopped
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
		protected RSystem.RBoolean r_isDefaultPrevented;
		public virtual RSystem.RBoolean RisDefaultPrevented
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
		protected RSystem.RBoolean r_dispatch;
		public virtual RSystem.RBoolean Rdispatch
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
		/// UnityEngine.Vector2 mousePosition
		/// </summary>
		protected RUnityEngine.RVector2 r_mousePosition;
		public virtual RUnityEngine.RVector2 RmousePosition
		{
			get
			{
				if(r_mousePosition == null)
				{
					r_mousePosition = new(this, "mousePosition", -1);
					r_mousePosition.SetBelong(this.instance);
				}
				return r_mousePosition;
			}
		}

		/// <summary>
		/// Int32 clickCount
		/// </summary>
		protected RSystem.RInt32 r_clickCount;
		public virtual RSystem.RInt32 RclickCount
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
		/// Int32 button
		/// </summary>
		protected RSystem.RInt32 r_button;
		public virtual RSystem.RInt32 Rbutton
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
		protected RSystem.RInt32 r_pressedButtons;
		public virtual RSystem.RInt32 RpressedButtons
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
		/// UnityEngine.Vector3 delta
		/// </summary>
		protected RUnityEngine.RVector3 r_delta;
		public virtual RUnityEngine.RVector3 Rdelta
		{
			get
			{
				if(r_delta == null)
				{
					r_delta = new(this, "delta", -1);
					r_delta.SetBelong(this.instance);
				}
				return r_delta;
			}
		}

		/// <summary>
		/// Char character
		/// </summary>
		protected RSystem.RChar r_character;
		public virtual RSystem.RChar Rcharacter
		{
			get
			{
				if(r_character == null)
				{
					r_character = new(this, "character", -1);
					r_character.SetBelong(this.instance);
				}
				return r_character;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode keyCode
		/// </summary>
		protected RProperty r_keyCode;
		public virtual RProperty RkeyCode
		{
			get
			{
				if(r_keyCode == null)
				{
					r_keyCode = new(this, "keyCode", -1);
					r_keyCode.SetBelong(this.instance);
				}
				return r_keyCode;
			}
		}

		/// <summary>
		/// System.String commandName
		/// </summary>
		protected RSystem.RString r_commandName;
		public virtual RSystem.RString RcommandName
		{
			get
			{
				if(r_commandName == null)
				{
					r_commandName = new(this, "commandName", -1);
					r_commandName.SetBelong(this.instance);
				}
				return r_commandName;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.NavigationDeviceType deviceType
		/// </summary>
		protected RProperty r_deviceType;
		public virtual RProperty RdeviceType
		{
			get
			{
				if(r_deviceType == null)
				{
					r_deviceType = new(this, "deviceType", -1);
					r_deviceType.SetBelong(this.instance);
				}
				return r_deviceType;
			}
		}

		/// <summary>
		/// Direction navigationDirection
		/// </summary>
		protected RProperty r_navigationDirection;
		public virtual RProperty RnavigationDirection
		{
			get
			{
				if(r_navigationDirection == null)
				{
					r_navigationDirection = new(this, "navigationDirection", -1);
					r_navigationDirection.SetBelong(this.instance);
				}
				return r_navigationDirection;
			}
		}

		/// <summary>
		/// Void Init(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_Init_EventBase;
		public virtual RMethod RInit_EventBase
		{
			get
			{
				if(r_Init_EventBase == null)
				{
					r_Init_EventBase = new(this, "Init", 0, typeof(UnityEngine.UIElements.EventBase));
					r_Init_EventBase.SetBelong(this.instance);
				}
				return r_Init_EventBase;
			}
		}

		/// <summary>
		/// System.String TimestampString()
		/// </summary>
		protected RMethod r_TimestampString;
		public virtual RMethod RTimestampString
		{
			get
			{
				if(r_TimestampString == null)
				{
					r_TimestampString = new(this, "TimestampString", 0);
					r_TimestampString.SetBelong(this.instance);
				}
				return r_TimestampString;
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


        public REventDebuggerEventRecord() : base("UnityEngine.UIElements.EventDebuggerEventRecord")
        {
        }

        public REventDebuggerEventRecord(System.Object instance) : base("UnityEngine.UIElements.EventDebuggerEventRecord")
		{
            SetInstance(instance);
		}

        public REventDebuggerEventRecord(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REventDebuggerEventRecord(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Init(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RInit_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String TimestampString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTimestampString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
