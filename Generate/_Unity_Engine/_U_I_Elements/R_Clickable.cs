
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.Clickable
	/// </summary>
    public partial class RClickable : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.Clickable);
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


		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.EventBase] clickedWithEventInfo
		/// </summary>
		protected REvent r_EclickedWithEventInfo;
		public virtual REvent REclickedWithEventInfo
		{
			get
			{
				if(r_EclickedWithEventInfo == null)
				{
					r_EclickedWithEventInfo = new(this, "clickedWithEventInfo");
				}
				return r_EclickedWithEventInfo;
			}
		}

		/// <summary>
		/// System.Action clicked
		/// </summary>
		protected REvent r_Eclicked;
		public virtual REvent REclicked
		{
			get
			{
				if(r_Eclicked == null)
				{
					r_Eclicked = new(this, "clicked");
				}
				return r_Eclicked;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.EventBase] clickedWithEventInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase> r_FclickedWithEventInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase> RFclickedWithEventInfo
		{
			get
			{
				if(r_FclickedWithEventInfo == null)
				{
					r_FclickedWithEventInfo = new(this, "clickedWithEventInfo");
				}
				return r_FclickedWithEventInfo;
			}
		}

		/// <summary>
		/// System.Action clicked
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_Fclicked;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFclicked
		{
			get
			{
				if(r_Fclicked == null)
				{
					r_Fclicked = new(this, "clicked");
				}
				return r_Fclicked;
			}
		}

		/// <summary>
		/// System.Int64 m_Delay
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Fm_Delay;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFm_Delay
		{
			get
			{
				if(r_Fm_Delay == null)
				{
					r_Fm_Delay = new(this, "m_Delay");
				}
				return r_Fm_Delay;
			}
		}

		/// <summary>
		/// System.Int64 m_Interval
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Fm_Interval;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFm_Interval
		{
			get
			{
				if(r_Fm_Interval == null)
				{
					r_Fm_Interval = new(this, "m_Interval");
				}
				return r_Fm_Interval;
			}
		}

		/// <summary>
		/// System.Boolean <active>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__active__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__active__1__k__BackingField
		{
			get
			{
				if(r_F__0__active__1__k__BackingField == null)
				{
					r_F__0__active__1__k__BackingField = new(this, "<active>k__BackingField");
				}
				return r_F__0__active__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 <lastMousePosition>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_F__0__lastMousePosition__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RF__0__lastMousePosition__1__k__BackingField
		{
			get
			{
				if(r_F__0__lastMousePosition__1__k__BackingField == null)
				{
					r_F__0__lastMousePosition__1__k__BackingField = new(this, "<lastMousePosition>k__BackingField");
				}
				return r_F__0__lastMousePosition__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 m_ActivePointerId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_ActivePointerId;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_ActivePointerId
		{
			get
			{
				if(r_Fm_ActivePointerId == null)
				{
					r_Fm_ActivePointerId = new(this, "m_ActivePointerId");
				}
				return r_Fm_ActivePointerId;
			}
		}

		/// <summary>
		/// System.Boolean m_AcceptClicksIfDisabled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_AcceptClicksIfDisabled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_AcceptClicksIfDisabled
		{
			get
			{
				if(r_Fm_AcceptClicksIfDisabled == null)
				{
					r_Fm_AcceptClicksIfDisabled = new(this, "m_AcceptClicksIfDisabled");
				}
				return r_Fm_AcceptClicksIfDisabled;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduledItem m_Repeater
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualElementScheduledItem r_Fm_Repeater;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualElementScheduledItem RFm_Repeater
		{
			get
			{
				if(r_Fm_Repeater == null)
				{
					r_Fm_Repeater = new(this, "m_Repeater");
				}
				return r_Fm_Repeater;
			}
		}

		/// <summary>
		/// Boolean active
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pactive;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPactive
		{
			get
			{
				if(r_Pactive == null)
				{
					r_Pactive = new(this, "active", -1);
				}
				return r_Pactive;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 lastMousePosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PlastMousePosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPlastMousePosition
		{
			get
			{
				if(r_PlastMousePosition == null)
				{
					r_PlastMousePosition = new(this, "lastMousePosition", -1);
				}
				return r_PlastMousePosition;
			}
		}

		/// <summary>
		/// Boolean acceptClicksIfDisabled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PacceptClicksIfDisabled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPacceptClicksIfDisabled
		{
			get
			{
				if(r_PacceptClicksIfDisabled == null)
				{
					r_PacceptClicksIfDisabled = new(this, "acceptClicksIfDisabled", -1);
				}
				return r_PacceptClicksIfDisabled;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.InvokePolicy invokePolicy
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RInvokePolicy r_PinvokePolicy;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RInvokePolicy RPinvokePolicy
		{
			get
			{
				if(r_PinvokePolicy == null)
				{
					r_PinvokePolicy = new(this, "invokePolicy", -1);
				}
				return r_PinvokePolicy;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.ManipulatorActivationFilter] activators
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RManipulatorActivationFilter> r_Pactivators;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RManipulatorActivationFilter> RPactivators
		{
			get
			{
				if(r_Pactivators == null)
				{
					r_Pactivators = new(this, "activators", -1);
				}
				return r_Pactivators;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement target
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Ptarget;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPtarget
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
		/// Void OnTimer(UnityEngine.UIElements.TimerState)
		/// </summary>
		protected RMethod r_MOnTimer_TimerState;
		public virtual RMethod RMOnTimer_TimerState
		{
			get
			{
				if(r_MOnTimer_TimerState == null)
				{
					r_MOnTimer_TimerState = new(this, "OnTimer", 0, typeof(UnityEngine.UIElements.TimerState));
				}
				return r_MOnTimer_TimerState;
			}
		}

		/// <summary>
		/// Boolean IsRepeatable()
		/// </summary>
		protected RMethod r_MIsRepeatable;
		public virtual RMethod RMIsRepeatable
		{
			get
			{
				if(r_MIsRepeatable == null)
				{
					r_MIsRepeatable = new(this, "IsRepeatable", 0);
				}
				return r_MIsRepeatable;
			}
		}

		/// <summary>
		/// Void RegisterCallbacksOnTarget()
		/// </summary>
		protected RMethod r_MRegisterCallbacksOnTarget;
		public virtual RMethod RMRegisterCallbacksOnTarget
		{
			get
			{
				if(r_MRegisterCallbacksOnTarget == null)
				{
					r_MRegisterCallbacksOnTarget = new(this, "RegisterCallbacksOnTarget", 0);
				}
				return r_MRegisterCallbacksOnTarget;
			}
		}

		/// <summary>
		/// Void UnregisterCallbacksFromTarget()
		/// </summary>
		protected RMethod r_MUnregisterCallbacksFromTarget;
		public virtual RMethod RMUnregisterCallbacksFromTarget
		{
			get
			{
				if(r_MUnregisterCallbacksFromTarget == null)
				{
					r_MUnregisterCallbacksFromTarget = new(this, "UnregisterCallbacksFromTarget", 0);
				}
				return r_MUnregisterCallbacksFromTarget;
			}
		}

		/// <summary>
		/// Void OnMouseDown(UnityEngine.UIElements.MouseDownEvent)
		/// </summary>
		protected RMethod r_MOnMouseDown_MouseDownEvent;
		public virtual RMethod RMOnMouseDown_MouseDownEvent
		{
			get
			{
				if(r_MOnMouseDown_MouseDownEvent == null)
				{
					r_MOnMouseDown_MouseDownEvent = new(this, "OnMouseDown", 0, typeof(UnityEngine.UIElements.MouseDownEvent));
				}
				return r_MOnMouseDown_MouseDownEvent;
			}
		}

		/// <summary>
		/// Void OnMouseMove(UnityEngine.UIElements.MouseMoveEvent)
		/// </summary>
		protected RMethod r_MOnMouseMove_MouseMoveEvent;
		public virtual RMethod RMOnMouseMove_MouseMoveEvent
		{
			get
			{
				if(r_MOnMouseMove_MouseMoveEvent == null)
				{
					r_MOnMouseMove_MouseMoveEvent = new(this, "OnMouseMove", 0, typeof(UnityEngine.UIElements.MouseMoveEvent));
				}
				return r_MOnMouseMove_MouseMoveEvent;
			}
		}

		/// <summary>
		/// Void OnMouseUp(UnityEngine.UIElements.MouseUpEvent)
		/// </summary>
		protected RMethod r_MOnMouseUp_MouseUpEvent;
		public virtual RMethod RMOnMouseUp_MouseUpEvent
		{
			get
			{
				if(r_MOnMouseUp_MouseUpEvent == null)
				{
					r_MOnMouseUp_MouseUpEvent = new(this, "OnMouseUp", 0, typeof(UnityEngine.UIElements.MouseUpEvent));
				}
				return r_MOnMouseUp_MouseUpEvent;
			}
		}

		/// <summary>
		/// Void OnMouseCaptureOut(UnityEngine.UIElements.MouseCaptureOutEvent)
		/// </summary>
		protected RMethod r_MOnMouseCaptureOut_MouseCaptureOutEvent;
		public virtual RMethod RMOnMouseCaptureOut_MouseCaptureOutEvent
		{
			get
			{
				if(r_MOnMouseCaptureOut_MouseCaptureOutEvent == null)
				{
					r_MOnMouseCaptureOut_MouseCaptureOutEvent = new(this, "OnMouseCaptureOut", 0, typeof(UnityEngine.UIElements.MouseCaptureOutEvent));
				}
				return r_MOnMouseCaptureOut_MouseCaptureOutEvent;
			}
		}

		/// <summary>
		/// Void OnPointerDown(UnityEngine.UIElements.PointerDownEvent)
		/// </summary>
		protected RMethod r_MOnPointerDown_PointerDownEvent;
		public virtual RMethod RMOnPointerDown_PointerDownEvent
		{
			get
			{
				if(r_MOnPointerDown_PointerDownEvent == null)
				{
					r_MOnPointerDown_PointerDownEvent = new(this, "OnPointerDown", 0, typeof(UnityEngine.UIElements.PointerDownEvent));
				}
				return r_MOnPointerDown_PointerDownEvent;
			}
		}

		/// <summary>
		/// Void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent)
		/// </summary>
		protected RMethod r_MOnPointerMove_PointerMoveEvent;
		public virtual RMethod RMOnPointerMove_PointerMoveEvent
		{
			get
			{
				if(r_MOnPointerMove_PointerMoveEvent == null)
				{
					r_MOnPointerMove_PointerMoveEvent = new(this, "OnPointerMove", 0, typeof(UnityEngine.UIElements.PointerMoveEvent));
				}
				return r_MOnPointerMove_PointerMoveEvent;
			}
		}

		/// <summary>
		/// Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent)
		/// </summary>
		protected RMethod r_MOnPointerUp_PointerUpEvent;
		public virtual RMethod RMOnPointerUp_PointerUpEvent
		{
			get
			{
				if(r_MOnPointerUp_PointerUpEvent == null)
				{
					r_MOnPointerUp_PointerUpEvent = new(this, "OnPointerUp", 0, typeof(UnityEngine.UIElements.PointerUpEvent));
				}
				return r_MOnPointerUp_PointerUpEvent;
			}
		}

		/// <summary>
		/// Void OnPointerCancel(UnityEngine.UIElements.PointerCancelEvent)
		/// </summary>
		protected RMethod r_MOnPointerCancel_PointerCancelEvent;
		public virtual RMethod RMOnPointerCancel_PointerCancelEvent
		{
			get
			{
				if(r_MOnPointerCancel_PointerCancelEvent == null)
				{
					r_MOnPointerCancel_PointerCancelEvent = new(this, "OnPointerCancel", 0, typeof(UnityEngine.UIElements.PointerCancelEvent));
				}
				return r_MOnPointerCancel_PointerCancelEvent;
			}
		}

		/// <summary>
		/// Void OnPointerCaptureOut(UnityEngine.UIElements.PointerCaptureOutEvent)
		/// </summary>
		protected RMethod r_MOnPointerCaptureOut_PointerCaptureOutEvent;
		public virtual RMethod RMOnPointerCaptureOut_PointerCaptureOutEvent
		{
			get
			{
				if(r_MOnPointerCaptureOut_PointerCaptureOutEvent == null)
				{
					r_MOnPointerCaptureOut_PointerCaptureOutEvent = new(this, "OnPointerCaptureOut", 0, typeof(UnityEngine.UIElements.PointerCaptureOutEvent));
				}
				return r_MOnPointerCaptureOut_PointerCaptureOutEvent;
			}
		}

		/// <summary>
		/// Boolean ContainsPointer(Int32)
		/// </summary>
		protected RMethod r_MContainsPointer_Int32;
		public virtual RMethod RMContainsPointer_Int32
		{
			get
			{
				if(r_MContainsPointer_Int32 == null)
				{
					r_MContainsPointer_Int32 = new(this, "ContainsPointer", 0, typeof(System.Int32));
				}
				return r_MContainsPointer_Int32;
			}
		}

		/// <summary>
		/// Boolean IsNotMouseEvent(Int32)
		/// </summary>
		protected static RMethod r_MIsNotMouseEvent_Int32;
		public static RMethod RMIsNotMouseEvent_Int32
		{
			get
			{
				if(r_MIsNotMouseEvent_Int32 == null)
				{
					r_MIsNotMouseEvent_Int32 = new(Type, "IsNotMouseEvent", 0, typeof(System.Int32));
				}
				return r_MIsNotMouseEvent_Int32;
			}
		}

		/// <summary>
		/// Void Invoke(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MInvoke_EventBase;
		public virtual RMethod RMInvoke_EventBase
		{
			get
			{
				if(r_MInvoke_EventBase == null)
				{
					r_MInvoke_EventBase = new(this, "Invoke", 0, typeof(UnityEngine.UIElements.EventBase));
				}
				return r_MInvoke_EventBase;
			}
		}

		/// <summary>
		/// Void SimulateSingleClick(UnityEngine.UIElements.EventBase, Int32)
		/// </summary>
		protected RMethod r_MSimulateSingleClick_EventBase_Int32;
		public virtual RMethod RMSimulateSingleClick_EventBase_Int32
		{
			get
			{
				if(r_MSimulateSingleClick_EventBase_Int32 == null)
				{
					r_MSimulateSingleClick_EventBase_Int32 = new(this, "SimulateSingleClick", 0, typeof(UnityEngine.UIElements.EventBase), typeof(System.Int32));
				}
				return r_MSimulateSingleClick_EventBase_Int32;
			}
		}

		/// <summary>
		/// Void ProcessDownEvent(UnityEngine.UIElements.EventBase, UnityEngine.Vector2, Int32)
		/// </summary>
		protected RMethod r_MProcessDownEvent_EventBase_Vector2_Int32;
		public virtual RMethod RMProcessDownEvent_EventBase_Vector2_Int32
		{
			get
			{
				if(r_MProcessDownEvent_EventBase_Vector2_Int32 == null)
				{
					r_MProcessDownEvent_EventBase_Vector2_Int32 = new(this, "ProcessDownEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.Vector2), typeof(System.Int32));
				}
				return r_MProcessDownEvent_EventBase_Vector2_Int32;
			}
		}

		/// <summary>
		/// Void ProcessMoveEvent(UnityEngine.UIElements.EventBase, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MProcessMoveEvent_EventBase_Vector2;
		public virtual RMethod RMProcessMoveEvent_EventBase_Vector2
		{
			get
			{
				if(r_MProcessMoveEvent_EventBase_Vector2 == null)
				{
					r_MProcessMoveEvent_EventBase_Vector2 = new(this, "ProcessMoveEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.Vector2));
				}
				return r_MProcessMoveEvent_EventBase_Vector2;
			}
		}

		/// <summary>
		/// Void ProcessUpEvent(UnityEngine.UIElements.EventBase, UnityEngine.Vector2, Int32)
		/// </summary>
		protected RMethod r_MProcessUpEvent_EventBase_Vector2_Int32;
		public virtual RMethod RMProcessUpEvent_EventBase_Vector2_Int32
		{
			get
			{
				if(r_MProcessUpEvent_EventBase_Vector2_Int32 == null)
				{
					r_MProcessUpEvent_EventBase_Vector2_Int32 = new(this, "ProcessUpEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.Vector2), typeof(System.Int32));
				}
				return r_MProcessUpEvent_EventBase_Vector2_Int32;
			}
		}

		/// <summary>
		/// Void ProcessCancelEvent(UnityEngine.UIElements.EventBase, Int32)
		/// </summary>
		protected RMethod r_MProcessCancelEvent_EventBase_Int32;
		public virtual RMethod RMProcessCancelEvent_EventBase_Int32
		{
			get
			{
				if(r_MProcessCancelEvent_EventBase_Int32 == null)
				{
					r_MProcessCancelEvent_EventBase_Int32 = new(this, "ProcessCancelEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(System.Int32));
				}
				return r_MProcessCancelEvent_EventBase_Int32;
			}
		}

		/// <summary>
		/// Void <SimulateSingleClick>b__43_0()
		/// </summary>
		protected RMethod r_M__0__SimulateSingleClick__1__b__43_0;
		public virtual RMethod RM__0__SimulateSingleClick__1__b__43_0
		{
			get
			{
				if(r_M__0__SimulateSingleClick__1__b__43_0 == null)
				{
					r_M__0__SimulateSingleClick__1__b__43_0 = new(this, "<SimulateSingleClick>b__43_0", 0);
				}
				return r_M__0__SimulateSingleClick__1__b__43_0;
			}
		}

		/// <summary>
		/// Boolean CanStartManipulation(UnityEngine.UIElements.IPointerEvent)
		/// </summary>
		protected RMethod r_MCanStartManipulation_IPointerEvent;
		public virtual RMethod RMCanStartManipulation_IPointerEvent
		{
			get
			{
				if(r_MCanStartManipulation_IPointerEvent == null)
				{
					r_MCanStartManipulation_IPointerEvent = new(this, "CanStartManipulation", 0, typeof(UnityEngine.UIElements.IPointerEvent));
				}
				return r_MCanStartManipulation_IPointerEvent;
			}
		}

		/// <summary>
		/// Boolean CanStopManipulation(UnityEngine.UIElements.IPointerEvent)
		/// </summary>
		protected RMethod r_MCanStopManipulation_IPointerEvent;
		public virtual RMethod RMCanStopManipulation_IPointerEvent
		{
			get
			{
				if(r_MCanStopManipulation_IPointerEvent == null)
				{
					r_MCanStopManipulation_IPointerEvent = new(this, "CanStopManipulation", 0, typeof(UnityEngine.UIElements.IPointerEvent));
				}
				return r_MCanStopManipulation_IPointerEvent;
			}
		}

		/// <summary>
		/// Boolean CanStartManipulation(UnityEngine.UIElements.IMouseEvent)
		/// </summary>
		protected RMethod r_MCanStartManipulation_IMouseEvent;
		public virtual RMethod RMCanStartManipulation_IMouseEvent
		{
			get
			{
				if(r_MCanStartManipulation_IMouseEvent == null)
				{
					r_MCanStartManipulation_IMouseEvent = new(this, "CanStartManipulation", 0, typeof(UnityEngine.UIElements.IMouseEvent));
				}
				return r_MCanStartManipulation_IMouseEvent;
			}
		}

		/// <summary>
		/// Boolean CanStopManipulation(UnityEngine.UIElements.IMouseEvent)
		/// </summary>
		protected RMethod r_MCanStopManipulation_IMouseEvent;
		public virtual RMethod RMCanStopManipulation_IMouseEvent
		{
			get
			{
				if(r_MCanStopManipulation_IMouseEvent == null)
				{
					r_MCanStopManipulation_IMouseEvent = new(this, "CanStopManipulation", 0, typeof(UnityEngine.UIElements.IMouseEvent));
				}
				return r_MCanStopManipulation_IMouseEvent;
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


        public virtual void OnTimer(UnityEngine.UIElements.TimerState @timerState)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timerState};
            var ___result = RMOnTimer_TimerState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsRepeatable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsRepeatable.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void RegisterCallbacksOnTarget()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRegisterCallbacksOnTarget.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterCallbacksFromTarget()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUnregisterCallbacksFromTarget.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMouseDown(UnityEngine.UIElements.MouseDownEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnMouseDown_MouseDownEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMouseMove(UnityEngine.UIElements.MouseMoveEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnMouseMove_MouseMoveEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMouseUp(UnityEngine.UIElements.MouseUpEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnMouseUp_MouseUpEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMouseCaptureOut(UnityEngine.UIElements.MouseCaptureOutEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnMouseCaptureOut_MouseCaptureOutEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPointerDown(UnityEngine.UIElements.PointerDownEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnPointerDown_PointerDownEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnPointerMove_PointerMoveEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPointerUp(UnityEngine.UIElements.PointerUpEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnPointerUp_PointerUpEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPointerCancel(UnityEngine.UIElements.PointerCancelEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnPointerCancel_PointerCancelEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPointerCaptureOut(UnityEngine.UIElements.PointerCaptureOutEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnPointerCaptureOut_PointerCaptureOutEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ContainsPointer(System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId};
            var ___result = RMContainsPointer_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsNotMouseEvent(System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId};
            var ___result = RMIsNotMouseEvent_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Invoke(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMInvoke_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SimulateSingleClick(UnityEngine.UIElements.EventBase @evt, System.Int32 @delayMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @delayMs};
            var ___result = RMSimulateSingleClick_EventBase_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessDownEvent(UnityEngine.UIElements.EventBase @evt, UnityEngine.Vector2 @localPosition, System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @localPosition, @pointerId};
            var ___result = RMProcessDownEvent_EventBase_Vector2_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessMoveEvent(UnityEngine.UIElements.EventBase @evt, UnityEngine.Vector2 @localPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @localPosition};
            var ___result = RMProcessMoveEvent_EventBase_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessUpEvent(UnityEngine.UIElements.EventBase @evt, UnityEngine.Vector2 @localPosition, System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @localPosition, @pointerId};
            var ___result = RMProcessUpEvent_EventBase_Vector2_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessCancelEvent(UnityEngine.UIElements.EventBase @evt, System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @pointerId};
            var ___result = RMProcessCancelEvent_EventBase_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__SimulateSingleClick__1__b__43_0()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RM__0__SimulateSingleClick__1__b__43_0.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CanStartManipulation(UnityEngine.UIElements.IPointerEvent @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMCanStartManipulation_IPointerEvent.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean CanStopManipulation(UnityEngine.UIElements.IPointerEvent @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMCanStopManipulation_IPointerEvent.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean CanStartManipulation(UnityEngine.UIElements.IMouseEvent @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMCanStartManipulation_IMouseEvent.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean CanStopManipulation(UnityEngine.UIElements.IMouseEvent @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMCanStopManipulation_IMouseEvent.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
