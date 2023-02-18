
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ElementUnderPointer
	/// </summary>
    public partial class RElementUnderPointer : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.VisualElement[] m_PendingTopElementUnderPointer
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> r_Fm_PendingTopElementUnderPointer;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> RFm_PendingTopElementUnderPointer
		{
			get
			{
				if(r_Fm_PendingTopElementUnderPointer == null)
				{
					r_Fm_PendingTopElementUnderPointer = new(this, "m_PendingTopElementUnderPointer");
					r_Fm_PendingTopElementUnderPointer.SetBelong(this.GetValue());
				}
				return r_Fm_PendingTopElementUnderPointer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement[] m_TopElementUnderPointer
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> r_Fm_TopElementUnderPointer;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> RFm_TopElementUnderPointer
		{
			get
			{
				if(r_Fm_TopElementUnderPointer == null)
				{
					r_Fm_TopElementUnderPointer = new(this, "m_TopElementUnderPointer");
					r_Fm_TopElementUnderPointer.SetBelong(this.GetValue());
				}
				return r_Fm_TopElementUnderPointer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IPointerEvent[] m_TriggerPointerEvent
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPointerEvent> r_Fm_TriggerPointerEvent;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPointerEvent> RFm_TriggerPointerEvent
		{
			get
			{
				if(r_Fm_TriggerPointerEvent == null)
				{
					r_Fm_TriggerPointerEvent = new(this, "m_TriggerPointerEvent");
					r_Fm_TriggerPointerEvent.SetBelong(this.GetValue());
				}
				return r_Fm_TriggerPointerEvent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IMouseEvent[] m_TriggerMouseEvent
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIMouseEvent> r_Fm_TriggerMouseEvent;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIMouseEvent> RFm_TriggerMouseEvent
		{
			get
			{
				if(r_Fm_TriggerMouseEvent == null)
				{
					r_Fm_TriggerMouseEvent = new(this, "m_TriggerMouseEvent");
					r_Fm_TriggerMouseEvent.SetBelong(this.GetValue());
				}
				return r_Fm_TriggerMouseEvent;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] m_PickingPointerPositions
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RVector2> r_Fm_PickingPointerPositions;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RVector2> RFm_PickingPointerPositions
		{
			get
			{
				if(r_Fm_PickingPointerPositions == null)
				{
					r_Fm_PickingPointerPositions = new(this, "m_PickingPointerPositions");
					r_Fm_PickingPointerPositions.SetBelong(this.GetValue());
				}
				return r_Fm_PickingPointerPositions;
			}
		}

		/// <summary>
		/// System.Boolean[] m_IsPickingPointerTemporaries
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RBoolean> r_Fm_IsPickingPointerTemporaries;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RBoolean> RFm_IsPickingPointerTemporaries
		{
			get
			{
				if(r_Fm_IsPickingPointerTemporaries == null)
				{
					r_Fm_IsPickingPointerTemporaries = new(this, "m_IsPickingPointerTemporaries");
					r_Fm_IsPickingPointerTemporaries.SetBelong(this.GetValue());
				}
				return r_Fm_IsPickingPointerTemporaries;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(Int32, UnityEngine.Vector2 ByRef, Boolean ByRef)
		/// </summary>
		protected RMethod r_MGetTopElementUnderPointer_Int32_Out_Vector2_Out_Boolean;
		public virtual RMethod RMGetTopElementUnderPointer_Int32_Out_Vector2_Out_Boolean
		{
			get
			{
				if(r_MGetTopElementUnderPointer_Int32_Out_Vector2_Out_Boolean == null)
				{
					r_MGetTopElementUnderPointer_Int32_Out_Vector2_Out_Boolean = new(this, "GetTopElementUnderPointer", 0, typeof(System.Int32), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
					r_MGetTopElementUnderPointer_Int32_Out_Vector2_Out_Boolean.SetBelong(this.GetValue());
				}
				return r_MGetTopElementUnderPointer_Int32_Out_Vector2_Out_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(Int32)
		/// </summary>
		protected RMethod r_MGetTopElementUnderPointer_Int32;
		public virtual RMethod RMGetTopElementUnderPointer_Int32
		{
			get
			{
				if(r_MGetTopElementUnderPointer_Int32 == null)
				{
					r_MGetTopElementUnderPointer_Int32 = new(this, "GetTopElementUnderPointer", 0, typeof(System.Int32));
					r_MGetTopElementUnderPointer_Int32.SetBelong(this.GetValue());
				}
				return r_MGetTopElementUnderPointer_Int32;
			}
		}

		/// <summary>
		/// Void SetElementUnderPointer(UnityEngine.UIElements.VisualElement, Int32, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetElementUnderPointer_VisualElement_Int32_Vector2;
		public virtual RMethod RMSetElementUnderPointer_VisualElement_Int32_Vector2
		{
			get
			{
				if(r_MSetElementUnderPointer_VisualElement_Int32_Vector2 == null)
				{
					r_MSetElementUnderPointer_VisualElement_Int32_Vector2 = new(this, "SetElementUnderPointer", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Int32), typeof(UnityEngine.Vector2));
					r_MSetElementUnderPointer_VisualElement_Int32_Vector2.SetBelong(this.GetValue());
				}
				return r_MSetElementUnderPointer_VisualElement_Int32_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetEventPointerPosition(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MGetEventPointerPosition_EventBase;
		public virtual RMethod RMGetEventPointerPosition_EventBase
		{
			get
			{
				if(r_MGetEventPointerPosition_EventBase == null)
				{
					r_MGetEventPointerPosition_EventBase = new(this, "GetEventPointerPosition", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MGetEventPointerPosition_EventBase.SetBelong(this.GetValue());
				}
				return r_MGetEventPointerPosition_EventBase;
			}
		}

		/// <summary>
		/// Void SetTemporaryElementUnderPointer(UnityEngine.UIElements.VisualElement, Int32, UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MSetTemporaryElementUnderPointer_VisualElement_Int32_EventBase;
		public virtual RMethod RMSetTemporaryElementUnderPointer_VisualElement_Int32_EventBase
		{
			get
			{
				if(r_MSetTemporaryElementUnderPointer_VisualElement_Int32_EventBase == null)
				{
					r_MSetTemporaryElementUnderPointer_VisualElement_Int32_EventBase = new(this, "SetTemporaryElementUnderPointer", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Int32), typeof(UnityEngine.UIElements.EventBase));
					r_MSetTemporaryElementUnderPointer_VisualElement_Int32_EventBase.SetBelong(this.GetValue());
				}
				return r_MSetTemporaryElementUnderPointer_VisualElement_Int32_EventBase;
			}
		}

		/// <summary>
		/// Void SetElementUnderPointer(UnityEngine.UIElements.VisualElement, Int32, UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MSetElementUnderPointer_VisualElement_Int32_EventBase;
		public virtual RMethod RMSetElementUnderPointer_VisualElement_Int32_EventBase
		{
			get
			{
				if(r_MSetElementUnderPointer_VisualElement_Int32_EventBase == null)
				{
					r_MSetElementUnderPointer_VisualElement_Int32_EventBase = new(this, "SetElementUnderPointer", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Int32), typeof(UnityEngine.UIElements.EventBase));
					r_MSetElementUnderPointer_VisualElement_Int32_EventBase.SetBelong(this.GetValue());
				}
				return r_MSetElementUnderPointer_VisualElement_Int32_EventBase;
			}
		}

		/// <summary>
		/// Void SetElementUnderPointer(UnityEngine.UIElements.VisualElement, Int32, UnityEngine.UIElements.EventBase, Boolean)
		/// </summary>
		protected RMethod r_MSetElementUnderPointer_VisualElement_Int32_EventBase_Boolean;
		public virtual RMethod RMSetElementUnderPointer_VisualElement_Int32_EventBase_Boolean
		{
			get
			{
				if(r_MSetElementUnderPointer_VisualElement_Int32_EventBase_Boolean == null)
				{
					r_MSetElementUnderPointer_VisualElement_Int32_EventBase_Boolean = new(this, "SetElementUnderPointer", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Int32), typeof(UnityEngine.UIElements.EventBase), typeof(System.Boolean));
					r_MSetElementUnderPointer_VisualElement_Int32_EventBase_Boolean.SetBelong(this.GetValue());
				}
				return r_MSetElementUnderPointer_VisualElement_Int32_EventBase_Boolean;
			}
		}

		/// <summary>
		/// Void CommitElementUnderPointers(UnityEngine.UIElements.EventDispatcher, UnityEngine.UIElements.ContextType)
		/// </summary>
		protected RMethod r_MCommitElementUnderPointers_EventDispatcher_ContextType;
		public virtual RMethod RMCommitElementUnderPointers_EventDispatcher_ContextType
		{
			get
			{
				if(r_MCommitElementUnderPointers_EventDispatcher_ContextType == null)
				{
					r_MCommitElementUnderPointers_EventDispatcher_ContextType = new(this, "CommitElementUnderPointers", 0, typeof(UnityEngine.UIElements.EventDispatcher), typeof(UnityEngine.UIElements.ContextType));
					r_MCommitElementUnderPointers_EventDispatcher_ContextType.SetBelong(this.GetValue());
				}
				return r_MCommitElementUnderPointers_EventDispatcher_ContextType;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
			}
		}


        public RElementUnderPointer() : base("UnityEngine.UIElements.ElementUnderPointer")
        {
        }

        public RElementUnderPointer(System.Object instance) : base("UnityEngine.UIElements.ElementUnderPointer")
		{
            SetInstance(instance);
		}

        public RElementUnderPointer(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RElementUnderPointer(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(System.Int32 @pointerId, out UnityEngine.Vector2 @pickPosition, out System.Boolean @isTemporary)
        {
			@pickPosition = default;
			@isTemporary = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId, @pickPosition, @isTemporary};
            var ___result = RMGetTopElementUnderPointer_Int32_Out_Vector2_Out_Boolean.Invoke(___genericsType, ___parameters);
			@pickPosition = (UnityEngine.Vector2)___parameters[1];
			@isTemporary = (System.Boolean)___parameters[2];

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId};
            var ___result = RMGetTopElementUnderPointer_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual void SetElementUnderPointer(UnityEngine.UIElements.VisualElement @newElementUnderPointer, System.Int32 @pointerId, UnityEngine.Vector2 @pointerPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newElementUnderPointer, @pointerId, @pointerPos};
            var ___result = RMSetElementUnderPointer_VisualElement_Int32_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 GetEventPointerPosition(UnityEngine.UIElements.EventBase @triggerEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triggerEvent};
            var ___result = RMGetEventPointerPosition_EventBase.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void SetTemporaryElementUnderPointer(UnityEngine.UIElements.VisualElement @newElementUnderPointer, System.Int32 @pointerId, UnityEngine.UIElements.EventBase @triggerEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newElementUnderPointer, @pointerId, @triggerEvent};
            var ___result = RMSetTemporaryElementUnderPointer_VisualElement_Int32_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetElementUnderPointer(UnityEngine.UIElements.VisualElement @newElementUnderPointer, System.Int32 @pointerId, UnityEngine.UIElements.EventBase @triggerEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newElementUnderPointer, @pointerId, @triggerEvent};
            var ___result = RMSetElementUnderPointer_VisualElement_Int32_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetElementUnderPointer(UnityEngine.UIElements.VisualElement @newElementUnderPointer, System.Int32 @pointerId, UnityEngine.UIElements.EventBase @triggerEvent, System.Boolean @temporary)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newElementUnderPointer, @pointerId, @triggerEvent, @temporary};
            var ___result = RMSetElementUnderPointer_VisualElement_Int32_EventBase_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CommitElementUnderPointers(UnityEngine.UIElements.EventDispatcher @dispatcher, UnityEngine.UIElements.ContextType @contextType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispatcher, @contextType};
            var ___result = RMCommitElementUnderPointers_EventDispatcher_ContextType.Invoke(___genericsType, ___parameters);

            
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
