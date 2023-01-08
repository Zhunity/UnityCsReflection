using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ElementUnderPointer
	/// </summary>
    public partial class RElementUnderPointer : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.VisualElement[] m_PendingTopElementUnderPointer
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RVisualElement> r_m_PendingTopElementUnderPointer;
		public virtual RFieldArray<RUnityEngine.RUIElements.RVisualElement> Rm_PendingTopElementUnderPointer
		{
			get
			{
				if(r_m_PendingTopElementUnderPointer == null)
				{
					r_m_PendingTopElementUnderPointer = new(this, "m_PendingTopElementUnderPointer");
					r_m_PendingTopElementUnderPointer.SetBelong(this.instance);
				}
				return r_m_PendingTopElementUnderPointer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement[] m_TopElementUnderPointer
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RVisualElement> r_m_TopElementUnderPointer;
		public virtual RFieldArray<RUnityEngine.RUIElements.RVisualElement> Rm_TopElementUnderPointer
		{
			get
			{
				if(r_m_TopElementUnderPointer == null)
				{
					r_m_TopElementUnderPointer = new(this, "m_TopElementUnderPointer");
					r_m_TopElementUnderPointer.SetBelong(this.instance);
				}
				return r_m_TopElementUnderPointer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IPointerEvent[] m_TriggerPointerEvent
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RIPointerEvent> r_m_TriggerPointerEvent;
		public virtual RFieldArray<RUnityEngine.RUIElements.RIPointerEvent> Rm_TriggerPointerEvent
		{
			get
			{
				if(r_m_TriggerPointerEvent == null)
				{
					r_m_TriggerPointerEvent = new(this, "m_TriggerPointerEvent");
					r_m_TriggerPointerEvent.SetBelong(this.instance);
				}
				return r_m_TriggerPointerEvent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IMouseEvent[] m_TriggerMouseEvent
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RIMouseEvent> r_m_TriggerMouseEvent;
		public virtual RFieldArray<RUnityEngine.RUIElements.RIMouseEvent> Rm_TriggerMouseEvent
		{
			get
			{
				if(r_m_TriggerMouseEvent == null)
				{
					r_m_TriggerMouseEvent = new(this, "m_TriggerMouseEvent");
					r_m_TriggerMouseEvent.SetBelong(this.instance);
				}
				return r_m_TriggerMouseEvent;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] m_PickingPointerPositions
		/// </summary>
		protected RFieldArray<RUnityEngine.RVector2> r_m_PickingPointerPositions;
		public virtual RFieldArray<RUnityEngine.RVector2> Rm_PickingPointerPositions
		{
			get
			{
				if(r_m_PickingPointerPositions == null)
				{
					r_m_PickingPointerPositions = new(this, "m_PickingPointerPositions");
					r_m_PickingPointerPositions.SetBelong(this.instance);
				}
				return r_m_PickingPointerPositions;
			}
		}

		/// <summary>
		/// System.Boolean[] m_IsPickingPointerTemporaries
		/// </summary>
		protected RFieldArray<RField> r_m_IsPickingPointerTemporaries;
		public virtual RFieldArray<RField> Rm_IsPickingPointerTemporaries
		{
			get
			{
				if(r_m_IsPickingPointerTemporaries == null)
				{
					r_m_IsPickingPointerTemporaries = new(this, "m_IsPickingPointerTemporaries");
					r_m_IsPickingPointerTemporaries.SetBelong(this.instance);
				}
				return r_m_IsPickingPointerTemporaries;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(Int32, UnityEngine.Vector2 ByRef, Boolean ByRef)
		/// </summary>
		protected RMethod r_GetTopElementUnderPointer_Int32_Out_Vector2_Out_Boolean;
		public virtual RMethod RGetTopElementUnderPointer_Int32_Out_Vector2_Out_Boolean
		{
			get
			{
				if(r_GetTopElementUnderPointer_Int32_Out_Vector2_Out_Boolean == null)
				{
					r_GetTopElementUnderPointer_Int32_Out_Vector2_Out_Boolean = new(this, "GetTopElementUnderPointer", 0, typeof(System.Int32), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
					r_GetTopElementUnderPointer_Int32_Out_Vector2_Out_Boolean.SetBelong(this.instance);
				}
				return r_GetTopElementUnderPointer_Int32_Out_Vector2_Out_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(Int32)
		/// </summary>
		protected RMethod r_GetTopElementUnderPointer_Int32;
		public virtual RMethod RGetTopElementUnderPointer_Int32
		{
			get
			{
				if(r_GetTopElementUnderPointer_Int32 == null)
				{
					r_GetTopElementUnderPointer_Int32 = new(this, "GetTopElementUnderPointer", 0, typeof(System.Int32));
					r_GetTopElementUnderPointer_Int32.SetBelong(this.instance);
				}
				return r_GetTopElementUnderPointer_Int32;
			}
		}

		/// <summary>
		/// Void SetElementUnderPointer(UnityEngine.UIElements.VisualElement, Int32, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_SetElementUnderPointer_VisualElement_Int32_Vector2;
		public virtual RMethod RSetElementUnderPointer_VisualElement_Int32_Vector2
		{
			get
			{
				if(r_SetElementUnderPointer_VisualElement_Int32_Vector2 == null)
				{
					r_SetElementUnderPointer_VisualElement_Int32_Vector2 = new(this, "SetElementUnderPointer", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Int32), typeof(UnityEngine.Vector2));
					r_SetElementUnderPointer_VisualElement_Int32_Vector2.SetBelong(this.instance);
				}
				return r_SetElementUnderPointer_VisualElement_Int32_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetEventPointerPosition(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_GetEventPointerPosition_EventBase;
		public virtual RMethod RGetEventPointerPosition_EventBase
		{
			get
			{
				if(r_GetEventPointerPosition_EventBase == null)
				{
					r_GetEventPointerPosition_EventBase = new(this, "GetEventPointerPosition", 0, typeof(UnityEngine.UIElements.EventBase));
					r_GetEventPointerPosition_EventBase.SetBelong(this.instance);
				}
				return r_GetEventPointerPosition_EventBase;
			}
		}

		/// <summary>
		/// Void SetTemporaryElementUnderPointer(UnityEngine.UIElements.VisualElement, Int32, UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_SetTemporaryElementUnderPointer_VisualElement_Int32_EventBase;
		public virtual RMethod RSetTemporaryElementUnderPointer_VisualElement_Int32_EventBase
		{
			get
			{
				if(r_SetTemporaryElementUnderPointer_VisualElement_Int32_EventBase == null)
				{
					r_SetTemporaryElementUnderPointer_VisualElement_Int32_EventBase = new(this, "SetTemporaryElementUnderPointer", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Int32), typeof(UnityEngine.UIElements.EventBase));
					r_SetTemporaryElementUnderPointer_VisualElement_Int32_EventBase.SetBelong(this.instance);
				}
				return r_SetTemporaryElementUnderPointer_VisualElement_Int32_EventBase;
			}
		}

		/// <summary>
		/// Void SetElementUnderPointer(UnityEngine.UIElements.VisualElement, Int32, UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_SetElementUnderPointer_VisualElement_Int32_EventBase;
		public virtual RMethod RSetElementUnderPointer_VisualElement_Int32_EventBase
		{
			get
			{
				if(r_SetElementUnderPointer_VisualElement_Int32_EventBase == null)
				{
					r_SetElementUnderPointer_VisualElement_Int32_EventBase = new(this, "SetElementUnderPointer", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Int32), typeof(UnityEngine.UIElements.EventBase));
					r_SetElementUnderPointer_VisualElement_Int32_EventBase.SetBelong(this.instance);
				}
				return r_SetElementUnderPointer_VisualElement_Int32_EventBase;
			}
		}

		/// <summary>
		/// Void SetElementUnderPointer(UnityEngine.UIElements.VisualElement, Int32, UnityEngine.UIElements.EventBase, Boolean)
		/// </summary>
		protected RMethod r_SetElementUnderPointer_VisualElement_Int32_EventBase_Boolean;
		public virtual RMethod RSetElementUnderPointer_VisualElement_Int32_EventBase_Boolean
		{
			get
			{
				if(r_SetElementUnderPointer_VisualElement_Int32_EventBase_Boolean == null)
				{
					r_SetElementUnderPointer_VisualElement_Int32_EventBase_Boolean = new(this, "SetElementUnderPointer", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Int32), typeof(UnityEngine.UIElements.EventBase), typeof(System.Boolean));
					r_SetElementUnderPointer_VisualElement_Int32_EventBase_Boolean.SetBelong(this.instance);
				}
				return r_SetElementUnderPointer_VisualElement_Int32_EventBase_Boolean;
			}
		}

		/// <summary>
		/// Void CommitElementUnderPointers(UnityEngine.UIElements.EventDispatcher, UnityEngine.UIElements.ContextType)
		/// </summary>
		protected RMethod r_CommitElementUnderPointers_EventDispatcher_ContextType;
		public virtual RMethod RCommitElementUnderPointers_EventDispatcher_ContextType
		{
			get
			{
				if(r_CommitElementUnderPointers_EventDispatcher_ContextType == null)
				{
					r_CommitElementUnderPointers_EventDispatcher_ContextType = new(this, "CommitElementUnderPointers", 0, typeof(UnityEngine.UIElements.EventDispatcher), typeof(UnityEngine.UIElements.ContextType));
					r_CommitElementUnderPointers_EventDispatcher_ContextType.SetBelong(this.instance);
				}
				return r_CommitElementUnderPointers_EventDispatcher_ContextType;
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

        public virtual UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(System.Int32  @pointerId, out UnityEngine.Vector2  @pickPosition, out System.Boolean  @isTemporary)
        {
			pickPosition = default;
			isTemporary = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId, @pickPosition, @isTemporary};
            var ___result = RGetTopElementUnderPointer_Int32_Out_Vector2_Out_Boolean.Invoke(___genericsType, ___parameters);
			pickPosition = (UnityEngine.Vector2)___parameters[1];
			isTemporary = (System.Boolean)___parameters[2];

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(System.Int32  @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId};
            var ___result = RGetTopElementUnderPointer_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual void SetElementUnderPointer(UnityEngine.UIElements.VisualElement  @newElementUnderPointer, System.Int32  @pointerId, UnityEngine.Vector2  @pointerPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newElementUnderPointer, @pointerId, @pointerPos};
            var ___result = RSetElementUnderPointer_VisualElement_Int32_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 GetEventPointerPosition(UnityEngine.UIElements.EventBase  @triggerEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triggerEvent};
            var ___result = RGetEventPointerPosition_EventBase.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void SetTemporaryElementUnderPointer(UnityEngine.UIElements.VisualElement  @newElementUnderPointer, System.Int32  @pointerId, UnityEngine.UIElements.EventBase  @triggerEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newElementUnderPointer, @pointerId, @triggerEvent};
            var ___result = RSetTemporaryElementUnderPointer_VisualElement_Int32_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetElementUnderPointer(UnityEngine.UIElements.VisualElement  @newElementUnderPointer, System.Int32  @pointerId, UnityEngine.UIElements.EventBase  @triggerEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newElementUnderPointer, @pointerId, @triggerEvent};
            var ___result = RSetElementUnderPointer_VisualElement_Int32_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetElementUnderPointer(UnityEngine.UIElements.VisualElement  @newElementUnderPointer, System.Int32  @pointerId, UnityEngine.UIElements.EventBase  @triggerEvent, System.Boolean  @temporary)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newElementUnderPointer, @pointerId, @triggerEvent, @temporary};
            var ___result = RSetElementUnderPointer_VisualElement_Int32_EventBase_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CommitElementUnderPointers(UnityEngine.UIElements.EventDispatcher  @dispatcher, UnityEngine.UIElements.ContextType  @contextType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispatcher, @contextType};
            var ___result = RCommitElementUnderPointers_EventDispatcher_ContextType.Invoke(___genericsType, ___parameters);

            
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
