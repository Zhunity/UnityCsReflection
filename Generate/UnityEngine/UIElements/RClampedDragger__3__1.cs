using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ClampedDragger`1
	/// </summary>
    public partial class RClampedDragger<T> : RMember // where T : System.IComparable<T>
    {

		/// <summary>
		/// System.Action dragging
		/// </summary>
		protected RSystem.RAction r_dragging;
		public virtual RSystem.RAction Rdragging
		{
			get
			{
				if(r_dragging == null)
				{
					r_dragging = new(this, "dragging");
					r_dragging.SetBelong(this.instance);
				}
				return r_dragging;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ClampedDragger`1+DragDirection[T] <dragDirection>k__BackingField
		/// </summary>
		protected RField r___0__dragDirection__1__k__BackingField;
		public virtual RField R__0__dragDirection__1__k__BackingField
		{
			get
			{
				if(r___0__dragDirection__1__k__BackingField == null)
				{
					r___0__dragDirection__1__k__BackingField = new(this, "<dragDirection>k__BackingField");
					r___0__dragDirection__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__dragDirection__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BaseSlider`1[T] <slider>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RBaseSlider<RField> r___0__slider__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RBaseSlider<RField> R__0__slider__1__k__BackingField
		{
			get
			{
				if(r___0__slider__1__k__BackingField == null)
				{
					r___0__slider__1__k__BackingField = new(this, "<slider>k__BackingField");
					r___0__slider__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__slider__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 <startMousePosition>k__BackingField
		/// </summary>
		protected RUnityEngine.RVector2 r___0__startMousePosition__1__k__BackingField;
		public virtual RUnityEngine.RVector2 R__0__startMousePosition__1__k__BackingField
		{
			get
			{
				if(r___0__startMousePosition__1__k__BackingField == null)
				{
					r___0__startMousePosition__1__k__BackingField = new(this, "<startMousePosition>k__BackingField");
					r___0__startMousePosition__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__startMousePosition__1__k__BackingField;
			}
		}

		/// <summary>
		/// DragDirection dragDirection
		/// </summary>
		protected RProperty r_dragDirection;
		public virtual RProperty RdragDirection
		{
			get
			{
				if(r_dragDirection == null)
				{
					r_dragDirection = new(this, "dragDirection", -1);
					r_dragDirection.SetBelong(this.instance);
				}
				return r_dragDirection;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BaseSlider`1[T] slider
		/// </summary>
		protected RUnityEngine.RUIElements.RBaseSlider<RProperty> r_slider;
		public virtual RUnityEngine.RUIElements.RBaseSlider<RProperty> Rslider
		{
			get
			{
				if(r_slider == null)
				{
					r_slider = new(this, "slider", -1);
					r_slider.SetBelong(this.instance);
				}
				return r_slider;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 startMousePosition
		/// </summary>
		protected RUnityEngine.RVector2 r_startMousePosition;
		public virtual RUnityEngine.RVector2 RstartMousePosition
		{
			get
			{
				if(r_startMousePosition == null)
				{
					r_startMousePosition = new(this, "startMousePosition", -1);
					r_startMousePosition.SetBelong(this.instance);
				}
				return r_startMousePosition;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 delta
		/// </summary>
		protected RUnityEngine.RVector2 r_delta;
		public virtual RUnityEngine.RVector2 Rdelta
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
		/// System.Action`1[UnityEngine.UIElements.EventBase] clickedWithEventInfo
		/// </summary>
		protected REvent r_clickedWithEventInfo;
		public virtual REvent RclickedWithEventInfo
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
		protected REvent r_clicked;
		public virtual REvent Rclicked
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
		/// Void ProcessDownEvent(UnityEngine.UIElements.EventBase, UnityEngine.Vector2, Int32)
		/// </summary>
		protected RMethod r_ProcessDownEvent_EventBase_Vector2_Int32;
		public virtual RMethod RProcessDownEvent_EventBase_Vector2_Int32
		{
			get
			{
				if(r_ProcessDownEvent_EventBase_Vector2_Int32 == null)
				{
					r_ProcessDownEvent_EventBase_Vector2_Int32 = new(this, "ProcessDownEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.Vector2), typeof(System.Int32));
					r_ProcessDownEvent_EventBase_Vector2_Int32.SetBelong(this.instance);
				}
				return r_ProcessDownEvent_EventBase_Vector2_Int32;
			}
		}

		/// <summary>
		/// Void ProcessMoveEvent(UnityEngine.UIElements.EventBase, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_ProcessMoveEvent_EventBase_Vector2;
		public virtual RMethod RProcessMoveEvent_EventBase_Vector2
		{
			get
			{
				if(r_ProcessMoveEvent_EventBase_Vector2 == null)
				{
					r_ProcessMoveEvent_EventBase_Vector2 = new(this, "ProcessMoveEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.Vector2));
					r_ProcessMoveEvent_EventBase_Vector2.SetBelong(this.instance);
				}
				return r_ProcessMoveEvent_EventBase_Vector2;
			}
		}

		/// <summary>
		/// Void RegisterCallbacksOnTarget()
		/// </summary>
		protected RMethod r_RegisterCallbacksOnTarget;
		public virtual RMethod RRegisterCallbacksOnTarget
		{
			get
			{
				if(r_RegisterCallbacksOnTarget == null)
				{
					r_RegisterCallbacksOnTarget = new(this, "RegisterCallbacksOnTarget", 0);
					r_RegisterCallbacksOnTarget.SetBelong(this.instance);
				}
				return r_RegisterCallbacksOnTarget;
			}
		}

		/// <summary>
		/// Void UnregisterCallbacksFromTarget()
		/// </summary>
		protected RMethod r_UnregisterCallbacksFromTarget;
		public virtual RMethod RUnregisterCallbacksFromTarget
		{
			get
			{
				if(r_UnregisterCallbacksFromTarget == null)
				{
					r_UnregisterCallbacksFromTarget = new(this, "UnregisterCallbacksFromTarget", 0);
					r_UnregisterCallbacksFromTarget.SetBelong(this.instance);
				}
				return r_UnregisterCallbacksFromTarget;
			}
		}

		/// <summary>
		/// Void OnMouseDown(UnityEngine.UIElements.MouseDownEvent)
		/// </summary>
		protected RMethod r_OnMouseDown_MouseDownEvent;
		public virtual RMethod ROnMouseDown_MouseDownEvent
		{
			get
			{
				if(r_OnMouseDown_MouseDownEvent == null)
				{
					r_OnMouseDown_MouseDownEvent = new(this, "OnMouseDown", 0, typeof(UnityEngine.UIElements.MouseDownEvent));
					r_OnMouseDown_MouseDownEvent.SetBelong(this.instance);
				}
				return r_OnMouseDown_MouseDownEvent;
			}
		}

		/// <summary>
		/// Void OnMouseMove(UnityEngine.UIElements.MouseMoveEvent)
		/// </summary>
		protected RMethod r_OnMouseMove_MouseMoveEvent;
		public virtual RMethod ROnMouseMove_MouseMoveEvent
		{
			get
			{
				if(r_OnMouseMove_MouseMoveEvent == null)
				{
					r_OnMouseMove_MouseMoveEvent = new(this, "OnMouseMove", 0, typeof(UnityEngine.UIElements.MouseMoveEvent));
					r_OnMouseMove_MouseMoveEvent.SetBelong(this.instance);
				}
				return r_OnMouseMove_MouseMoveEvent;
			}
		}

		/// <summary>
		/// Void OnMouseUp(UnityEngine.UIElements.MouseUpEvent)
		/// </summary>
		protected RMethod r_OnMouseUp_MouseUpEvent;
		public virtual RMethod ROnMouseUp_MouseUpEvent
		{
			get
			{
				if(r_OnMouseUp_MouseUpEvent == null)
				{
					r_OnMouseUp_MouseUpEvent = new(this, "OnMouseUp", 0, typeof(UnityEngine.UIElements.MouseUpEvent));
					r_OnMouseUp_MouseUpEvent.SetBelong(this.instance);
				}
				return r_OnMouseUp_MouseUpEvent;
			}
		}

		/// <summary>
		/// Void Invoke(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_Invoke_EventBase;
		public virtual RMethod RInvoke_EventBase
		{
			get
			{
				if(r_Invoke_EventBase == null)
				{
					r_Invoke_EventBase = new(this, "Invoke", 0, typeof(UnityEngine.UIElements.EventBase));
					r_Invoke_EventBase.SetBelong(this.instance);
				}
				return r_Invoke_EventBase;
			}
		}

		/// <summary>
		/// Void SimulateSingleClick(UnityEngine.UIElements.EventBase, Int32)
		/// </summary>
		protected RMethod r_SimulateSingleClick_EventBase_Int32;
		public virtual RMethod RSimulateSingleClick_EventBase_Int32
		{
			get
			{
				if(r_SimulateSingleClick_EventBase_Int32 == null)
				{
					r_SimulateSingleClick_EventBase_Int32 = new(this, "SimulateSingleClick", 0, typeof(UnityEngine.UIElements.EventBase), typeof(System.Int32));
					r_SimulateSingleClick_EventBase_Int32.SetBelong(this.instance);
				}
				return r_SimulateSingleClick_EventBase_Int32;
			}
		}

		/// <summary>
		/// Void ProcessUpEvent(UnityEngine.UIElements.EventBase, UnityEngine.Vector2, Int32)
		/// </summary>
		protected RMethod r_ProcessUpEvent_EventBase_Vector2_Int32;
		public virtual RMethod RProcessUpEvent_EventBase_Vector2_Int32
		{
			get
			{
				if(r_ProcessUpEvent_EventBase_Vector2_Int32 == null)
				{
					r_ProcessUpEvent_EventBase_Vector2_Int32 = new(this, "ProcessUpEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.Vector2), typeof(System.Int32));
					r_ProcessUpEvent_EventBase_Vector2_Int32.SetBelong(this.instance);
				}
				return r_ProcessUpEvent_EventBase_Vector2_Int32;
			}
		}

		/// <summary>
		/// Void ProcessCancelEvent(UnityEngine.UIElements.EventBase, Int32)
		/// </summary>
		protected RMethod r_ProcessCancelEvent_EventBase_Int32;
		public virtual RMethod RProcessCancelEvent_EventBase_Int32
		{
			get
			{
				if(r_ProcessCancelEvent_EventBase_Int32 == null)
				{
					r_ProcessCancelEvent_EventBase_Int32 = new(this, "ProcessCancelEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(System.Int32));
					r_ProcessCancelEvent_EventBase_Int32.SetBelong(this.instance);
				}
				return r_ProcessCancelEvent_EventBase_Int32;
			}
		}

		/// <summary>
		/// Boolean CanStartManipulation(UnityEngine.UIElements.IPointerEvent)
		/// </summary>
		protected RMethod r_CanStartManipulation_IPointerEvent;
		public virtual RMethod RCanStartManipulation_IPointerEvent
		{
			get
			{
				if(r_CanStartManipulation_IPointerEvent == null)
				{
					r_CanStartManipulation_IPointerEvent = new(this, "CanStartManipulation", 0, typeof(UnityEngine.UIElements.IPointerEvent));
					r_CanStartManipulation_IPointerEvent.SetBelong(this.instance);
				}
				return r_CanStartManipulation_IPointerEvent;
			}
		}

		/// <summary>
		/// Boolean CanStopManipulation(UnityEngine.UIElements.IPointerEvent)
		/// </summary>
		protected RMethod r_CanStopManipulation_IPointerEvent;
		public virtual RMethod RCanStopManipulation_IPointerEvent
		{
			get
			{
				if(r_CanStopManipulation_IPointerEvent == null)
				{
					r_CanStopManipulation_IPointerEvent = new(this, "CanStopManipulation", 0, typeof(UnityEngine.UIElements.IPointerEvent));
					r_CanStopManipulation_IPointerEvent.SetBelong(this.instance);
				}
				return r_CanStopManipulation_IPointerEvent;
			}
		}

		/// <summary>
		/// Boolean CanStartManipulation(UnityEngine.UIElements.IMouseEvent)
		/// </summary>
		protected RMethod r_CanStartManipulation_IMouseEvent;
		public virtual RMethod RCanStartManipulation_IMouseEvent
		{
			get
			{
				if(r_CanStartManipulation_IMouseEvent == null)
				{
					r_CanStartManipulation_IMouseEvent = new(this, "CanStartManipulation", 0, typeof(UnityEngine.UIElements.IMouseEvent));
					r_CanStartManipulation_IMouseEvent.SetBelong(this.instance);
				}
				return r_CanStartManipulation_IMouseEvent;
			}
		}

		/// <summary>
		/// Boolean CanStopManipulation(UnityEngine.UIElements.IMouseEvent)
		/// </summary>
		protected RMethod r_CanStopManipulation_IMouseEvent;
		public virtual RMethod RCanStopManipulation_IMouseEvent
		{
			get
			{
				if(r_CanStopManipulation_IMouseEvent == null)
				{
					r_CanStopManipulation_IMouseEvent = new(this, "CanStopManipulation", 0, typeof(UnityEngine.UIElements.IMouseEvent));
					r_CanStopManipulation_IMouseEvent.SetBelong(this.instance);
				}
				return r_CanStopManipulation_IMouseEvent;
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


        public RClampedDragger() : base("UnityEngine.UIElements.ClampedDragger`1")
        {
        }

        public RClampedDragger(System.Object instance) : base("UnityEngine.UIElements.ClampedDragger`1")
		{
            SetInstance(instance);
		}

        public RClampedDragger(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RClampedDragger(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void ProcessDownEvent(UnityEngine.UIElements.EventBase @evt, UnityEngine.Vector2 @localPosition, System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @localPosition, @pointerId};
            var ___result = RProcessDownEvent_EventBase_Vector2_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessMoveEvent(UnityEngine.UIElements.EventBase @evt, UnityEngine.Vector2 @localPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @localPosition};
            var ___result = RProcessMoveEvent_EventBase_Vector2.Invoke(___genericsType, ___parameters);

            
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


        public virtual void OnMouseDown(UnityEngine.UIElements.MouseDownEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnMouseDown_MouseDownEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMouseMove(UnityEngine.UIElements.MouseMoveEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnMouseMove_MouseMoveEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMouseUp(UnityEngine.UIElements.MouseUpEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnMouseUp_MouseUpEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Invoke(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RInvoke_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SimulateSingleClick(UnityEngine.UIElements.EventBase @evt, System.Int32 @delayMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @delayMs};
            var ___result = RSimulateSingleClick_EventBase_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessUpEvent(UnityEngine.UIElements.EventBase @evt, UnityEngine.Vector2 @localPosition, System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @localPosition, @pointerId};
            var ___result = RProcessUpEvent_EventBase_Vector2_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessCancelEvent(UnityEngine.UIElements.EventBase @evt, System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @pointerId};
            var ___result = RProcessCancelEvent_EventBase_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CanStartManipulation(UnityEngine.UIElements.IPointerEvent @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RCanStartManipulation_IPointerEvent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CanStopManipulation(UnityEngine.UIElements.IPointerEvent @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RCanStopManipulation_IPointerEvent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CanStartManipulation(UnityEngine.UIElements.IMouseEvent @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RCanStartManipulation_IMouseEvent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CanStopManipulation(UnityEngine.UIElements.IMouseEvent @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RCanStopManipulation_IMouseEvent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
