
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ClampedDragger`1
	/// </summary>
    public partial class RClampedDragger<T> : RMember // where T : System.IComparable<T>
    {

		/// <summary>
		/// System.Action dragging
		/// </summary>
		protected REvent r_Edragging;
		public virtual REvent REdragging
		{
			get
			{
				if(r_Edragging == null)
				{
					r_Edragging = new(this, "dragging");
				}
				return r_Edragging;
			}
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
		/// System.Action dragging
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_Fdragging;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFdragging
		{
			get
			{
				if(r_Fdragging == null)
				{
					r_Fdragging = new(this, "dragging");
				}
				return r_Fdragging;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ClampedDragger`1+DragDirection[T] <dragDirection>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RClampedDragger<Hvak.Editor.Refleaction.RField>.RDragDirection r_F__0__dragDirection__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RClampedDragger<Hvak.Editor.Refleaction.RField>.RDragDirection RF__0__dragDirection__1__k__BackingField
		{
			get
			{
				if(r_F__0__dragDirection__1__k__BackingField == null)
				{
					r_F__0__dragDirection__1__k__BackingField = new(this, "<dragDirection>k__BackingField");
				}
				return r_F__0__dragDirection__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BaseSlider`1[T] <slider>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseSlider<Hvak.Editor.Refleaction.RField> r_F__0__slider__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseSlider<Hvak.Editor.Refleaction.RField> RF__0__slider__1__k__BackingField
		{
			get
			{
				if(r_F__0__slider__1__k__BackingField == null)
				{
					r_F__0__slider__1__k__BackingField = new(this, "<slider>k__BackingField");
				}
				return r_F__0__slider__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 <startMousePosition>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_F__0__startMousePosition__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RF__0__startMousePosition__1__k__BackingField
		{
			get
			{
				if(r_F__0__startMousePosition__1__k__BackingField == null)
				{
					r_F__0__startMousePosition__1__k__BackingField = new(this, "<startMousePosition>k__BackingField");
				}
				return r_F__0__startMousePosition__1__k__BackingField;
			}
		}

		/// <summary>
		/// DragDirection dragDirection
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RClampedDragger<Hvak.Editor.Refleaction.RProperty>.RDragDirection r_PdragDirection;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RClampedDragger<Hvak.Editor.Refleaction.RProperty>.RDragDirection RPdragDirection
		{
			get
			{
				if(r_PdragDirection == null)
				{
					r_PdragDirection = new(this, "dragDirection", -1);
				}
				return r_PdragDirection;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BaseSlider`1[T] slider
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseSlider<Hvak.Editor.Refleaction.RProperty> r_Pslider;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseSlider<Hvak.Editor.Refleaction.RProperty> RPslider
		{
			get
			{
				if(r_Pslider == null)
				{
					r_Pslider = new(this, "slider", -1);
				}
				return r_Pslider;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 startMousePosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PstartMousePosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPstartMousePosition
		{
			get
			{
				if(r_PstartMousePosition == null)
				{
					r_PstartMousePosition = new(this, "startMousePosition", -1);
				}
				return r_PstartMousePosition;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 delta
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Pdelta;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPdelta
		{
			get
			{
				if(r_Pdelta == null)
				{
					r_Pdelta = new(this, "delta", -1);
				}
				return r_Pdelta;
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
            var ___result = RMProcessDownEvent_EventBase_Vector2_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessMoveEvent(UnityEngine.UIElements.EventBase @evt, UnityEngine.Vector2 @localPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @localPosition};
            var ___result = RMProcessMoveEvent_EventBase_Vector2.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Boolean CanStartManipulation(UnityEngine.UIElements.IPointerEvent @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMCanStartManipulation_IPointerEvent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CanStopManipulation(UnityEngine.UIElements.IPointerEvent @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMCanStopManipulation_IPointerEvent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CanStartManipulation(UnityEngine.UIElements.IMouseEvent @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMCanStartManipulation_IMouseEvent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CanStopManipulation(UnityEngine.UIElements.IMouseEvent @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMCanStopManipulation_IMouseEvent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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

            return (System.Int32)___result;
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
