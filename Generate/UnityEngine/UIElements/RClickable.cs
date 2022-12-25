using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.Clickable
	/// </summary>
    public partial class RClickable : RMember //
    {

		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.EventBase] clickedWithEventInfo
		/// </summary>
		protected RSystem.RAction<RUnityEngine.RUIElements.REventBase> r_clickedWithEventInfo;
		public virtual RSystem.RAction<RUnityEngine.RUIElements.REventBase> RclickedWithEventInfo
		{
			get
			{
				if(r_clickedWithEventInfo == null)
				{
					r_clickedWithEventInfo = new(this, "clickedWithEventInfo");
					r_clickedWithEventInfo.SetBelong(this.instance);
				}
				return r_clickedWithEventInfo;
			}
		}

		/// <summary>
		/// System.Action clicked
		/// </summary>
		protected RSystem.RAction r_clicked;
		public virtual RSystem.RAction Rclicked
		{
			get
			{
				if(r_clicked == null)
				{
					r_clicked = new(this, "clicked");
					r_clicked.SetBelong(this.instance);
				}
				return r_clicked;
			}
		}

		/// <summary>
		/// System.Int64 m_Delay
		/// </summary>
		protected RField r_m_Delay;
		public virtual RField Rm_Delay
		{
			get
			{
				if(r_m_Delay == null)
				{
					r_m_Delay = new(this, "m_Delay");
					r_m_Delay.SetBelong(this.instance);
				}
				return r_m_Delay;
			}
		}

		/// <summary>
		/// System.Int64 m_Interval
		/// </summary>
		protected RField r_m_Interval;
		public virtual RField Rm_Interval
		{
			get
			{
				if(r_m_Interval == null)
				{
					r_m_Interval = new(this, "m_Interval");
					r_m_Interval.SetBelong(this.instance);
				}
				return r_m_Interval;
			}
		}

		/// <summary>
		/// System.Boolean <active>k__BackingField
		/// </summary>
		protected RField r___1__active__2__k__BackingField;
		public virtual RField R__1__active__2__k__BackingField
		{
			get
			{
				if(r___1__active__2__k__BackingField == null)
				{
					r___1__active__2__k__BackingField = new(this, "<active>k__BackingField");
					r___1__active__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__active__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 <lastMousePosition>k__BackingField
		/// </summary>
		protected RUnityEngine.RVector2 r___1__lastMousePosition__2__k__BackingField;
		public virtual RUnityEngine.RVector2 R__1__lastMousePosition__2__k__BackingField
		{
			get
			{
				if(r___1__lastMousePosition__2__k__BackingField == null)
				{
					r___1__lastMousePosition__2__k__BackingField = new(this, "<lastMousePosition>k__BackingField");
					r___1__lastMousePosition__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__lastMousePosition__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 m_ActivePointerId
		/// </summary>
		protected RField r_m_ActivePointerId;
		public virtual RField Rm_ActivePointerId
		{
			get
			{
				if(r_m_ActivePointerId == null)
				{
					r_m_ActivePointerId = new(this, "m_ActivePointerId");
					r_m_ActivePointerId.SetBelong(this.instance);
				}
				return r_m_ActivePointerId;
			}
		}

		/// <summary>
		/// System.Boolean m_AcceptClicksIfDisabled
		/// </summary>
		protected RField r_m_AcceptClicksIfDisabled;
		public virtual RField Rm_AcceptClicksIfDisabled
		{
			get
			{
				if(r_m_AcceptClicksIfDisabled == null)
				{
					r_m_AcceptClicksIfDisabled = new(this, "m_AcceptClicksIfDisabled");
					r_m_AcceptClicksIfDisabled.SetBelong(this.instance);
				}
				return r_m_AcceptClicksIfDisabled;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduledItem m_Repeater
		/// </summary>
		protected RUnityEngine.RUIElements.RIVisualElementScheduledItem r_m_Repeater;
		public virtual RUnityEngine.RUIElements.RIVisualElementScheduledItem Rm_Repeater
		{
			get
			{
				if(r_m_Repeater == null)
				{
					r_m_Repeater = new(this, "m_Repeater");
					r_m_Repeater.SetBelong(this.instance);
				}
				return r_m_Repeater;
			}
		}

		/// <summary>
		/// Boolean active
		/// </summary>
		protected RProperty r_active;
		public virtual RProperty Ractive
		{
			get
			{
				if(r_active == null)
				{
					r_active = new(this, "active", -1);
					r_active.SetBelong(this.instance);
				}
				return r_active;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 lastMousePosition
		/// </summary>
		protected RUnityEngine.RVector2 r_lastMousePosition;
		public virtual RUnityEngine.RVector2 RlastMousePosition
		{
			get
			{
				if(r_lastMousePosition == null)
				{
					r_lastMousePosition = new(this, "lastMousePosition", -1);
					r_lastMousePosition.SetBelong(this.instance);
				}
				return r_lastMousePosition;
			}
		}

		/// <summary>
		/// Boolean acceptClicksIfDisabled
		/// </summary>
		protected RProperty r_acceptClicksIfDisabled;
		public virtual RProperty RacceptClicksIfDisabled
		{
			get
			{
				if(r_acceptClicksIfDisabled == null)
				{
					r_acceptClicksIfDisabled = new(this, "acceptClicksIfDisabled", -1);
					r_acceptClicksIfDisabled.SetBelong(this.instance);
				}
				return r_acceptClicksIfDisabled;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.InvokePolicy invokePolicy
		/// </summary>
		protected RProperty r_invokePolicy;
		public virtual RProperty RinvokePolicy
		{
			get
			{
				if(r_invokePolicy == null)
				{
					r_invokePolicy = new(this, "invokePolicy", -1);
					r_invokePolicy.SetBelong(this.instance);
				}
				return r_invokePolicy;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.ManipulatorActivationFilter] activators
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RManipulatorActivationFilter> r_activators;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RManipulatorActivationFilter> Ractivators
		{
			get
			{
				if(r_activators == null)
				{
					r_activators = new(this, "activators", -1);
					r_activators.SetBelong(this.instance);
				}
				return r_activators;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement target
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_target;
		public virtual RUnityEngine.RUIElements.RVisualElement Rtarget
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
		/// Void OnTimer(UnityEngine.UIElements.TimerState)
		/// </summary>
		protected RMethod r_ROnTimer_TimerState;
		public virtual RMethod ROnTimer_TimerState
		{
			get
			{
				if(r_ROnTimer_TimerState == null)
				{
					r_ROnTimer_TimerState = new(this, "OnTimer", 0, typeof(UnityEngine.UIElements.TimerState));
					r_ROnTimer_TimerState.SetBelong(this.instance);
				}
				return r_ROnTimer_TimerState;
			}
		}

		/// <summary>
		/// Boolean IsRepeatable()
		/// </summary>
		protected RMethod r_RIsRepeatable;
		public virtual RMethod RIsRepeatable
		{
			get
			{
				if(r_RIsRepeatable == null)
				{
					r_RIsRepeatable = new(this, "IsRepeatable", 0);
					r_RIsRepeatable.SetBelong(this.instance);
				}
				return r_RIsRepeatable;
			}
		}

		/// <summary>
		/// Void RegisterCallbacksOnTarget()
		/// </summary>
		protected RMethod r_RRegisterCallbacksOnTarget;
		public virtual RMethod RRegisterCallbacksOnTarget
		{
			get
			{
				if(r_RRegisterCallbacksOnTarget == null)
				{
					r_RRegisterCallbacksOnTarget = new(this, "RegisterCallbacksOnTarget", 0);
					r_RRegisterCallbacksOnTarget.SetBelong(this.instance);
				}
				return r_RRegisterCallbacksOnTarget;
			}
		}

		/// <summary>
		/// Void UnregisterCallbacksFromTarget()
		/// </summary>
		protected RMethod r_RUnregisterCallbacksFromTarget;
		public virtual RMethod RUnregisterCallbacksFromTarget
		{
			get
			{
				if(r_RUnregisterCallbacksFromTarget == null)
				{
					r_RUnregisterCallbacksFromTarget = new(this, "UnregisterCallbacksFromTarget", 0);
					r_RUnregisterCallbacksFromTarget.SetBelong(this.instance);
				}
				return r_RUnregisterCallbacksFromTarget;
			}
		}

		/// <summary>
		/// Void OnMouseDown(UnityEngine.UIElements.MouseDownEvent)
		/// </summary>
		protected RMethod r_ROnMouseDown_MouseDownEvent;
		public virtual RMethod ROnMouseDown_MouseDownEvent
		{
			get
			{
				if(r_ROnMouseDown_MouseDownEvent == null)
				{
					r_ROnMouseDown_MouseDownEvent = new(this, "OnMouseDown", 0, typeof(UnityEngine.UIElements.MouseDownEvent));
					r_ROnMouseDown_MouseDownEvent.SetBelong(this.instance);
				}
				return r_ROnMouseDown_MouseDownEvent;
			}
		}

		/// <summary>
		/// Void OnMouseMove(UnityEngine.UIElements.MouseMoveEvent)
		/// </summary>
		protected RMethod r_ROnMouseMove_MouseMoveEvent;
		public virtual RMethod ROnMouseMove_MouseMoveEvent
		{
			get
			{
				if(r_ROnMouseMove_MouseMoveEvent == null)
				{
					r_ROnMouseMove_MouseMoveEvent = new(this, "OnMouseMove", 0, typeof(UnityEngine.UIElements.MouseMoveEvent));
					r_ROnMouseMove_MouseMoveEvent.SetBelong(this.instance);
				}
				return r_ROnMouseMove_MouseMoveEvent;
			}
		}

		/// <summary>
		/// Void OnMouseUp(UnityEngine.UIElements.MouseUpEvent)
		/// </summary>
		protected RMethod r_ROnMouseUp_MouseUpEvent;
		public virtual RMethod ROnMouseUp_MouseUpEvent
		{
			get
			{
				if(r_ROnMouseUp_MouseUpEvent == null)
				{
					r_ROnMouseUp_MouseUpEvent = new(this, "OnMouseUp", 0, typeof(UnityEngine.UIElements.MouseUpEvent));
					r_ROnMouseUp_MouseUpEvent.SetBelong(this.instance);
				}
				return r_ROnMouseUp_MouseUpEvent;
			}
		}

		/// <summary>
		/// Void OnMouseCaptureOut(UnityEngine.UIElements.MouseCaptureOutEvent)
		/// </summary>
		protected RMethod r_ROnMouseCaptureOut_MouseCaptureOutEvent;
		public virtual RMethod ROnMouseCaptureOut_MouseCaptureOutEvent
		{
			get
			{
				if(r_ROnMouseCaptureOut_MouseCaptureOutEvent == null)
				{
					r_ROnMouseCaptureOut_MouseCaptureOutEvent = new(this, "OnMouseCaptureOut", 0, typeof(UnityEngine.UIElements.MouseCaptureOutEvent));
					r_ROnMouseCaptureOut_MouseCaptureOutEvent.SetBelong(this.instance);
				}
				return r_ROnMouseCaptureOut_MouseCaptureOutEvent;
			}
		}

		/// <summary>
		/// Void OnPointerDown(UnityEngine.UIElements.PointerDownEvent)
		/// </summary>
		protected RMethod r_ROnPointerDown_PointerDownEvent;
		public virtual RMethod ROnPointerDown_PointerDownEvent
		{
			get
			{
				if(r_ROnPointerDown_PointerDownEvent == null)
				{
					r_ROnPointerDown_PointerDownEvent = new(this, "OnPointerDown", 0, typeof(UnityEngine.UIElements.PointerDownEvent));
					r_ROnPointerDown_PointerDownEvent.SetBelong(this.instance);
				}
				return r_ROnPointerDown_PointerDownEvent;
			}
		}

		/// <summary>
		/// Void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent)
		/// </summary>
		protected RMethod r_ROnPointerMove_PointerMoveEvent;
		public virtual RMethod ROnPointerMove_PointerMoveEvent
		{
			get
			{
				if(r_ROnPointerMove_PointerMoveEvent == null)
				{
					r_ROnPointerMove_PointerMoveEvent = new(this, "OnPointerMove", 0, typeof(UnityEngine.UIElements.PointerMoveEvent));
					r_ROnPointerMove_PointerMoveEvent.SetBelong(this.instance);
				}
				return r_ROnPointerMove_PointerMoveEvent;
			}
		}

		/// <summary>
		/// Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent)
		/// </summary>
		protected RMethod r_ROnPointerUp_PointerUpEvent;
		public virtual RMethod ROnPointerUp_PointerUpEvent
		{
			get
			{
				if(r_ROnPointerUp_PointerUpEvent == null)
				{
					r_ROnPointerUp_PointerUpEvent = new(this, "OnPointerUp", 0, typeof(UnityEngine.UIElements.PointerUpEvent));
					r_ROnPointerUp_PointerUpEvent.SetBelong(this.instance);
				}
				return r_ROnPointerUp_PointerUpEvent;
			}
		}

		/// <summary>
		/// Void OnPointerCancel(UnityEngine.UIElements.PointerCancelEvent)
		/// </summary>
		protected RMethod r_ROnPointerCancel_PointerCancelEvent;
		public virtual RMethod ROnPointerCancel_PointerCancelEvent
		{
			get
			{
				if(r_ROnPointerCancel_PointerCancelEvent == null)
				{
					r_ROnPointerCancel_PointerCancelEvent = new(this, "OnPointerCancel", 0, typeof(UnityEngine.UIElements.PointerCancelEvent));
					r_ROnPointerCancel_PointerCancelEvent.SetBelong(this.instance);
				}
				return r_ROnPointerCancel_PointerCancelEvent;
			}
		}

		/// <summary>
		/// Void OnPointerCaptureOut(UnityEngine.UIElements.PointerCaptureOutEvent)
		/// </summary>
		protected RMethod r_ROnPointerCaptureOut_PointerCaptureOutEvent;
		public virtual RMethod ROnPointerCaptureOut_PointerCaptureOutEvent
		{
			get
			{
				if(r_ROnPointerCaptureOut_PointerCaptureOutEvent == null)
				{
					r_ROnPointerCaptureOut_PointerCaptureOutEvent = new(this, "OnPointerCaptureOut", 0, typeof(UnityEngine.UIElements.PointerCaptureOutEvent));
					r_ROnPointerCaptureOut_PointerCaptureOutEvent.SetBelong(this.instance);
				}
				return r_ROnPointerCaptureOut_PointerCaptureOutEvent;
			}
		}

		/// <summary>
		/// Boolean ContainsPointer(Int32)
		/// </summary>
		protected RMethod r_RContainsPointer_Int32;
		public virtual RMethod RContainsPointer_Int32
		{
			get
			{
				if(r_RContainsPointer_Int32 == null)
				{
					r_RContainsPointer_Int32 = new(this, "ContainsPointer", 0, typeof(System.Int32));
					r_RContainsPointer_Int32.SetBelong(this.instance);
				}
				return r_RContainsPointer_Int32;
			}
		}

		/// <summary>
		/// Boolean IsNotMouseEvent(Int32)
		/// </summary>
		protected static RMethod r_RIsNotMouseEvent_Int32;
		public static RMethod RIsNotMouseEvent_Int32
		{
			get
			{
				if(r_RIsNotMouseEvent_Int32 == null)
				{
					r_RIsNotMouseEvent_Int32 = new(typeof(UnityEngine.UIElements.Clickable), "IsNotMouseEvent", 0, typeof(System.Int32));
					r_RIsNotMouseEvent_Int32.SetBelong(null);
				}
				return r_RIsNotMouseEvent_Int32;
			}
		}

		/// <summary>
		/// Void Invoke(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RInvoke_EventBase;
		public virtual RMethod RInvoke_EventBase
		{
			get
			{
				if(r_RInvoke_EventBase == null)
				{
					r_RInvoke_EventBase = new(this, "Invoke", 0, typeof(UnityEngine.UIElements.EventBase));
					r_RInvoke_EventBase.SetBelong(this.instance);
				}
				return r_RInvoke_EventBase;
			}
		}

		/// <summary>
		/// Void SimulateSingleClick(UnityEngine.UIElements.EventBase, Int32)
		/// </summary>
		protected RMethod r_RSimulateSingleClick_EventBase_Int32;
		public virtual RMethod RSimulateSingleClick_EventBase_Int32
		{
			get
			{
				if(r_RSimulateSingleClick_EventBase_Int32 == null)
				{
					r_RSimulateSingleClick_EventBase_Int32 = new(this, "SimulateSingleClick", 0, typeof(UnityEngine.UIElements.EventBase), typeof(System.Int32));
					r_RSimulateSingleClick_EventBase_Int32.SetBelong(this.instance);
				}
				return r_RSimulateSingleClick_EventBase_Int32;
			}
		}

		/// <summary>
		/// Void ProcessDownEvent(UnityEngine.UIElements.EventBase, UnityEngine.Vector2, Int32)
		/// </summary>
		protected RMethod r_RProcessDownEvent_EventBase_Vector2_Int32;
		public virtual RMethod RProcessDownEvent_EventBase_Vector2_Int32
		{
			get
			{
				if(r_RProcessDownEvent_EventBase_Vector2_Int32 == null)
				{
					r_RProcessDownEvent_EventBase_Vector2_Int32 = new(this, "ProcessDownEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.Vector2), typeof(System.Int32));
					r_RProcessDownEvent_EventBase_Vector2_Int32.SetBelong(this.instance);
				}
				return r_RProcessDownEvent_EventBase_Vector2_Int32;
			}
		}

		/// <summary>
		/// Void ProcessMoveEvent(UnityEngine.UIElements.EventBase, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RProcessMoveEvent_EventBase_Vector2;
		public virtual RMethod RProcessMoveEvent_EventBase_Vector2
		{
			get
			{
				if(r_RProcessMoveEvent_EventBase_Vector2 == null)
				{
					r_RProcessMoveEvent_EventBase_Vector2 = new(this, "ProcessMoveEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.Vector2));
					r_RProcessMoveEvent_EventBase_Vector2.SetBelong(this.instance);
				}
				return r_RProcessMoveEvent_EventBase_Vector2;
			}
		}

		/// <summary>
		/// Void ProcessUpEvent(UnityEngine.UIElements.EventBase, UnityEngine.Vector2, Int32)
		/// </summary>
		protected RMethod r_RProcessUpEvent_EventBase_Vector2_Int32;
		public virtual RMethod RProcessUpEvent_EventBase_Vector2_Int32
		{
			get
			{
				if(r_RProcessUpEvent_EventBase_Vector2_Int32 == null)
				{
					r_RProcessUpEvent_EventBase_Vector2_Int32 = new(this, "ProcessUpEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.Vector2), typeof(System.Int32));
					r_RProcessUpEvent_EventBase_Vector2_Int32.SetBelong(this.instance);
				}
				return r_RProcessUpEvent_EventBase_Vector2_Int32;
			}
		}

		/// <summary>
		/// Void ProcessCancelEvent(UnityEngine.UIElements.EventBase, Int32)
		/// </summary>
		protected RMethod r_RProcessCancelEvent_EventBase_Int32;
		public virtual RMethod RProcessCancelEvent_EventBase_Int32
		{
			get
			{
				if(r_RProcessCancelEvent_EventBase_Int32 == null)
				{
					r_RProcessCancelEvent_EventBase_Int32 = new(this, "ProcessCancelEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(System.Int32));
					r_RProcessCancelEvent_EventBase_Int32.SetBelong(this.instance);
				}
				return r_RProcessCancelEvent_EventBase_Int32;
			}
		}

		/// <summary>
		/// Void <SimulateSingleClick>b__43_0()
		/// </summary>
		protected RMethod r_R__1__SimulateSingleClick__2__b__43_0;
		public virtual RMethod R__1__SimulateSingleClick__2__b__43_0
		{
			get
			{
				if(r_R__1__SimulateSingleClick__2__b__43_0 == null)
				{
					r_R__1__SimulateSingleClick__2__b__43_0 = new(this, "<SimulateSingleClick>b__43_0", 0);
					r_R__1__SimulateSingleClick__2__b__43_0.SetBelong(this.instance);
				}
				return r_R__1__SimulateSingleClick__2__b__43_0;
			}
		}

		/// <summary>
		/// Boolean CanStartManipulation(UnityEngine.UIElements.IPointerEvent)
		/// </summary>
		protected RMethod r_RCanStartManipulation_IPointerEvent;
		public virtual RMethod RCanStartManipulation_IPointerEvent
		{
			get
			{
				if(r_RCanStartManipulation_IPointerEvent == null)
				{
					r_RCanStartManipulation_IPointerEvent = new(this, "CanStartManipulation", 0, typeof(UnityEngine.UIElements.IPointerEvent));
					r_RCanStartManipulation_IPointerEvent.SetBelong(this.instance);
				}
				return r_RCanStartManipulation_IPointerEvent;
			}
		}

		/// <summary>
		/// Boolean CanStopManipulation(UnityEngine.UIElements.IPointerEvent)
		/// </summary>
		protected RMethod r_RCanStopManipulation_IPointerEvent;
		public virtual RMethod RCanStopManipulation_IPointerEvent
		{
			get
			{
				if(r_RCanStopManipulation_IPointerEvent == null)
				{
					r_RCanStopManipulation_IPointerEvent = new(this, "CanStopManipulation", 0, typeof(UnityEngine.UIElements.IPointerEvent));
					r_RCanStopManipulation_IPointerEvent.SetBelong(this.instance);
				}
				return r_RCanStopManipulation_IPointerEvent;
			}
		}

		/// <summary>
		/// Boolean CanStartManipulation(UnityEngine.UIElements.IMouseEvent)
		/// </summary>
		protected RMethod r_RCanStartManipulation_IMouseEvent;
		public virtual RMethod RCanStartManipulation_IMouseEvent
		{
			get
			{
				if(r_RCanStartManipulation_IMouseEvent == null)
				{
					r_RCanStartManipulation_IMouseEvent = new(this, "CanStartManipulation", 0, typeof(UnityEngine.UIElements.IMouseEvent));
					r_RCanStartManipulation_IMouseEvent.SetBelong(this.instance);
				}
				return r_RCanStartManipulation_IMouseEvent;
			}
		}

		/// <summary>
		/// Boolean CanStopManipulation(UnityEngine.UIElements.IMouseEvent)
		/// </summary>
		protected RMethod r_RCanStopManipulation_IMouseEvent;
		public virtual RMethod RCanStopManipulation_IMouseEvent
		{
			get
			{
				if(r_RCanStopManipulation_IMouseEvent == null)
				{
					r_RCanStopManipulation_IMouseEvent = new(this, "CanStopManipulation", 0, typeof(UnityEngine.UIElements.IMouseEvent));
					r_RCanStopManipulation_IMouseEvent.SetBelong(this.instance);
				}
				return r_RCanStopManipulation_IMouseEvent;
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


        public RClickable() : base("UnityEngine.UIElements.Clickable")
        {
        }

        public RClickable(System.Object instance) : base("UnityEngine.UIElements.Clickable")
		{
            SetInstance(instance);
		}

        public RClickable(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RClickable(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnTimer(UnityEngine.UIElements.TimerState  @timerState)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timerState};
            var ___result = ROnTimer_TimerState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsRepeatable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsRepeatable.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RegisterCallbacksOnTarget()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRegisterCallbacksOnTarget.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterCallbacksFromTarget()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnregisterCallbacksFromTarget.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMouseDown(UnityEngine.UIElements.MouseDownEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnMouseDown_MouseDownEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMouseMove(UnityEngine.UIElements.MouseMoveEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnMouseMove_MouseMoveEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMouseUp(UnityEngine.UIElements.MouseUpEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnMouseUp_MouseUpEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMouseCaptureOut(UnityEngine.UIElements.MouseCaptureOutEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnMouseCaptureOut_MouseCaptureOutEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPointerDown(UnityEngine.UIElements.PointerDownEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnPointerDown_PointerDownEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnPointerMove_PointerMoveEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPointerUp(UnityEngine.UIElements.PointerUpEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnPointerUp_PointerUpEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPointerCancel(UnityEngine.UIElements.PointerCancelEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnPointerCancel_PointerCancelEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPointerCaptureOut(UnityEngine.UIElements.PointerCaptureOutEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnPointerCaptureOut_PointerCaptureOutEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ContainsPointer(System.Int32  @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId};
            var ___result = RContainsPointer_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsNotMouseEvent(System.Int32  @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId};
            var ___result = RIsNotMouseEvent_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Invoke(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RInvoke_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SimulateSingleClick(UnityEngine.UIElements.EventBase  @evt, System.Int32  @delayMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @delayMs};
            var ___result = RSimulateSingleClick_EventBase_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessDownEvent(UnityEngine.UIElements.EventBase  @evt, UnityEngine.Vector2  @localPosition, System.Int32  @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @localPosition, @pointerId};
            var ___result = RProcessDownEvent_EventBase_Vector2_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessMoveEvent(UnityEngine.UIElements.EventBase  @evt, UnityEngine.Vector2  @localPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @localPosition};
            var ___result = RProcessMoveEvent_EventBase_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessUpEvent(UnityEngine.UIElements.EventBase  @evt, UnityEngine.Vector2  @localPosition, System.Int32  @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @localPosition, @pointerId};
            var ___result = RProcessUpEvent_EventBase_Vector2_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessCancelEvent(UnityEngine.UIElements.EventBase  @evt, System.Int32  @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @pointerId};
            var ___result = RProcessCancelEvent_EventBase_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __1__SimulateSingleClick__2__b__43_0()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__1__SimulateSingleClick__2__b__43_0.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CanStartManipulation(UnityEngine.UIElements.IPointerEvent  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RCanStartManipulation_IPointerEvent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CanStopManipulation(UnityEngine.UIElements.IPointerEvent  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RCanStopManipulation_IPointerEvent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CanStartManipulation(UnityEngine.UIElements.IMouseEvent  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RCanStartManipulation_IMouseEvent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CanStopManipulation(UnityEngine.UIElements.IMouseEvent  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RCanStopManipulation_IMouseEvent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
