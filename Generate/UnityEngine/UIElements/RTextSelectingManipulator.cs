using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.TextSelectingManipulator
	/// </summary>
    public partial class RTextSelectingManipulator : RMember //
    {

		/// <summary>
		/// UnityEngine.TextSelectingUtilities m_SelectingUtilities
		/// </summary>
		protected RUnityEngine.RTextSelectingUtilities r_m_SelectingUtilities;
		public virtual RUnityEngine.RTextSelectingUtilities Rm_SelectingUtilities
		{
			get
			{
				if(r_m_SelectingUtilities == null)
				{
					r_m_SelectingUtilities = new(this, "m_SelectingUtilities");
					r_m_SelectingUtilities.SetBelong(this.instance);
				}
				return r_m_SelectingUtilities;
			}
		}

		/// <summary>
		/// System.Boolean selectAllOnMouseUp
		/// </summary>
		protected RField r_selectAllOnMouseUp;
		public virtual RField RselectAllOnMouseUp
		{
			get
			{
				if(r_selectAllOnMouseUp == null)
				{
					r_selectAllOnMouseUp = new(this, "selectAllOnMouseUp");
					r_selectAllOnMouseUp.SetBelong(this.instance);
				}
				return r_selectAllOnMouseUp;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextElement m_TextElement
		/// </summary>
		protected RUnityEngine.RUIElements.RTextElement r_m_TextElement;
		public virtual RUnityEngine.RUIElements.RTextElement Rm_TextElement
		{
			get
			{
				if(r_m_TextElement == null)
				{
					r_m_TextElement = new(this, "m_TextElement");
					r_m_TextElement.SetBelong(this.instance);
				}
				return r_m_TextElement;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_ClickStartPosition
		/// </summary>
		protected RUnityEngine.RVector2 r_m_ClickStartPosition;
		public virtual RUnityEngine.RVector2 Rm_ClickStartPosition
		{
			get
			{
				if(r_m_ClickStartPosition == null)
				{
					r_m_ClickStartPosition = new(this, "m_ClickStartPosition");
					r_m_ClickStartPosition.SetBelong(this.instance);
				}
				return r_m_ClickStartPosition;
			}
		}

		/// <summary>
		/// System.Boolean m_Dragged
		/// </summary>
		protected RField r_m_Dragged;
		public virtual RField Rm_Dragged
		{
			get
			{
				if(r_m_Dragged == null)
				{
					r_m_Dragged = new(this, "m_Dragged");
					r_m_Dragged.SetBelong(this.instance);
				}
				return r_m_Dragged;
			}
		}

		/// <summary>
		/// System.Boolean m_IsClicking
		/// </summary>
		protected RField r_m_IsClicking;
		public virtual RField Rm_IsClicking
		{
			get
			{
				if(r_m_IsClicking == null)
				{
					r_m_IsClicking = new(this, "m_IsClicking");
					r_m_IsClicking.SetBelong(this.instance);
				}
				return r_m_IsClicking;
			}
		}

		/// <summary>
		/// System.Int32 k_DragThresholdSqr
		/// </summary>
		protected static RField r_k_DragThresholdSqr;
		public static RField Rk_DragThresholdSqr
		{
			get
			{
				if(r_k_DragThresholdSqr == null)
				{
					r_k_DragThresholdSqr = new( ReleactionUtils.GetType("UnityEngine.UIElements.TextSelectingManipulator"), "k_DragThresholdSqr");
					r_k_DragThresholdSqr.SetBelong(null);
				}
				return r_k_DragThresholdSqr;
			}
		}

		/// <summary>
		/// Boolean isClicking
		/// </summary>
		protected RProperty r_isClicking;
		public virtual RProperty RisClicking
		{
			get
			{
				if(r_isClicking == null)
				{
					r_isClicking = new(this, "isClicking", -1);
					r_isClicking.SetBelong(this.instance);
				}
				return r_isClicking;
			}
		}

		/// <summary>
		/// Int32 cursorIndex
		/// </summary>
		protected RProperty r_cursorIndex;
		public virtual RProperty RcursorIndex
		{
			get
			{
				if(r_cursorIndex == null)
				{
					r_cursorIndex = new(this, "cursorIndex", -1);
					r_cursorIndex.SetBelong(this.instance);
				}
				return r_cursorIndex;
			}
		}

		/// <summary>
		/// Int32 selectIndex
		/// </summary>
		protected RProperty r_selectIndex;
		public virtual RProperty RselectIndex
		{
			get
			{
				if(r_selectIndex == null)
				{
					r_selectIndex = new(this, "selectIndex", -1);
					r_selectIndex.SetBelong(this.instance);
				}
				return r_selectIndex;
			}
		}

		/// <summary>
		/// Void OnRevealCursor()
		/// </summary>
		protected RMethod r_OnRevealCursor;
		public virtual RMethod ROnRevealCursor
		{
			get
			{
				if(r_OnRevealCursor == null)
				{
					r_OnRevealCursor = new(this, "OnRevealCursor", 0);
					r_OnRevealCursor.SetBelong(this.instance);
				}
				return r_OnRevealCursor;
			}
		}

		/// <summary>
		/// Void OnSelectIndexChange()
		/// </summary>
		protected RMethod r_OnSelectIndexChange;
		public virtual RMethod ROnSelectIndexChange
		{
			get
			{
				if(r_OnSelectIndexChange == null)
				{
					r_OnSelectIndexChange = new(this, "OnSelectIndexChange", 0);
					r_OnSelectIndexChange.SetBelong(this.instance);
				}
				return r_OnSelectIndexChange;
			}
		}

		/// <summary>
		/// Void OnCursorIndexChange()
		/// </summary>
		protected RMethod r_OnCursorIndexChange;
		public virtual RMethod ROnCursorIndexChange
		{
			get
			{
				if(r_OnCursorIndexChange == null)
				{
					r_OnCursorIndexChange = new(this, "OnCursorIndexChange", 0);
					r_OnCursorIndexChange.SetBelong(this.instance);
				}
				return r_OnCursorIndexChange;
			}
		}

		/// <summary>
		/// Boolean RevealCursor()
		/// </summary>
		protected RMethod r_RevealCursor;
		public virtual RMethod RRevealCursor
		{
			get
			{
				if(r_RevealCursor == null)
				{
					r_RevealCursor = new(this, "RevealCursor", 0);
					r_RevealCursor.SetBelong(this.instance);
				}
				return r_RevealCursor;
			}
		}

		/// <summary>
		/// Boolean HasSelection()
		/// </summary>
		protected RMethod r_HasSelection;
		public virtual RMethod RHasSelection
		{
			get
			{
				if(r_HasSelection == null)
				{
					r_HasSelection = new(this, "HasSelection", 0);
					r_HasSelection.SetBelong(this.instance);
				}
				return r_HasSelection;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_ExecuteDefaultActionAtTarget_EventBase;
		public virtual RMethod RExecuteDefaultActionAtTarget_EventBase
		{
			get
			{
				if(r_ExecuteDefaultActionAtTarget_EventBase == null)
				{
					r_ExecuteDefaultActionAtTarget_EventBase = new(this, "ExecuteDefaultActionAtTarget", 0, typeof(UnityEngine.UIElements.EventBase));
					r_ExecuteDefaultActionAtTarget_EventBase.SetBelong(this.instance);
				}
				return r_ExecuteDefaultActionAtTarget_EventBase;
			}
		}

		/// <summary>
		/// Void OnFocusEvent(UnityEngine.UIElements.FocusEvent)
		/// </summary>
		protected RMethod r_OnFocusEvent_FocusEvent;
		public virtual RMethod ROnFocusEvent_FocusEvent
		{
			get
			{
				if(r_OnFocusEvent_FocusEvent == null)
				{
					r_OnFocusEvent_FocusEvent = new(this, "OnFocusEvent", 0, typeof(UnityEngine.UIElements.FocusEvent));
					r_OnFocusEvent_FocusEvent.SetBelong(this.instance);
				}
				return r_OnFocusEvent_FocusEvent;
			}
		}

		/// <summary>
		/// Void OnBlurEvent(UnityEngine.UIElements.BlurEvent)
		/// </summary>
		protected RMethod r_OnBlurEvent_BlurEvent;
		public virtual RMethod ROnBlurEvent_BlurEvent
		{
			get
			{
				if(r_OnBlurEvent_BlurEvent == null)
				{
					r_OnBlurEvent_BlurEvent = new(this, "OnBlurEvent", 0, typeof(UnityEngine.UIElements.BlurEvent));
					r_OnBlurEvent_BlurEvent.SetBelong(this.instance);
				}
				return r_OnBlurEvent_BlurEvent;
			}
		}

		/// <summary>
		/// Void OnMouseDownEvent(UnityEngine.UIElements.MouseDownEvent)
		/// </summary>
		protected RMethod r_OnMouseDownEvent_MouseDownEvent;
		public virtual RMethod ROnMouseDownEvent_MouseDownEvent
		{
			get
			{
				if(r_OnMouseDownEvent_MouseDownEvent == null)
				{
					r_OnMouseDownEvent_MouseDownEvent = new(this, "OnMouseDownEvent", 0, typeof(UnityEngine.UIElements.MouseDownEvent));
					r_OnMouseDownEvent_MouseDownEvent.SetBelong(this.instance);
				}
				return r_OnMouseDownEvent_MouseDownEvent;
			}
		}

		/// <summary>
		/// Void OnMouseMoveEvent(UnityEngine.UIElements.MouseMoveEvent)
		/// </summary>
		protected RMethod r_OnMouseMoveEvent_MouseMoveEvent;
		public virtual RMethod ROnMouseMoveEvent_MouseMoveEvent
		{
			get
			{
				if(r_OnMouseMoveEvent_MouseMoveEvent == null)
				{
					r_OnMouseMoveEvent_MouseMoveEvent = new(this, "OnMouseMoveEvent", 0, typeof(UnityEngine.UIElements.MouseMoveEvent));
					r_OnMouseMoveEvent_MouseMoveEvent.SetBelong(this.instance);
				}
				return r_OnMouseMoveEvent_MouseMoveEvent;
			}
		}

		/// <summary>
		/// Void OnMouseUpEvent(UnityEngine.UIElements.MouseUpEvent)
		/// </summary>
		protected RMethod r_OnMouseUpEvent_MouseUpEvent;
		public virtual RMethod ROnMouseUpEvent_MouseUpEvent
		{
			get
			{
				if(r_OnMouseUpEvent_MouseUpEvent == null)
				{
					r_OnMouseUpEvent_MouseUpEvent = new(this, "OnMouseUpEvent", 0, typeof(UnityEngine.UIElements.MouseUpEvent));
					r_OnMouseUpEvent_MouseUpEvent.SetBelong(this.instance);
				}
				return r_OnMouseUpEvent_MouseUpEvent;
			}
		}

		/// <summary>
		/// Void OnValidateCommandEvent(UnityEngine.UIElements.ValidateCommandEvent)
		/// </summary>
		protected RMethod r_OnValidateCommandEvent_ValidateCommandEvent;
		public virtual RMethod ROnValidateCommandEvent_ValidateCommandEvent
		{
			get
			{
				if(r_OnValidateCommandEvent_ValidateCommandEvent == null)
				{
					r_OnValidateCommandEvent_ValidateCommandEvent = new(this, "OnValidateCommandEvent", 0, typeof(UnityEngine.UIElements.ValidateCommandEvent));
					r_OnValidateCommandEvent_ValidateCommandEvent.SetBelong(this.instance);
				}
				return r_OnValidateCommandEvent_ValidateCommandEvent;
			}
		}

		/// <summary>
		/// Void OnExecuteCommandEvent(UnityEngine.UIElements.ExecuteCommandEvent)
		/// </summary>
		protected RMethod r_OnExecuteCommandEvent_ExecuteCommandEvent;
		public virtual RMethod ROnExecuteCommandEvent_ExecuteCommandEvent
		{
			get
			{
				if(r_OnExecuteCommandEvent_ExecuteCommandEvent == null)
				{
					r_OnExecuteCommandEvent_ExecuteCommandEvent = new(this, "OnExecuteCommandEvent", 0, typeof(UnityEngine.UIElements.ExecuteCommandEvent));
					r_OnExecuteCommandEvent_ExecuteCommandEvent.SetBelong(this.instance);
				}
				return r_OnExecuteCommandEvent_ExecuteCommandEvent;
			}
		}

		/// <summary>
		/// Boolean MoveDistanceQualifiesForDrag(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MoveDistanceQualifiesForDrag_Vector2_Vector2;
		public virtual RMethod RMoveDistanceQualifiesForDrag_Vector2_Vector2
		{
			get
			{
				if(r_MoveDistanceQualifiesForDrag_Vector2_Vector2 == null)
				{
					r_MoveDistanceQualifiesForDrag_Vector2_Vector2 = new(this, "MoveDistanceQualifiesForDrag", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_MoveDistanceQualifiesForDrag_Vector2_Vector2.SetBelong(this.instance);
				}
				return r_MoveDistanceQualifiesForDrag_Vector2_Vector2;
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


        public RTextSelectingManipulator() : base("UnityEngine.UIElements.TextSelectingManipulator")
        {
        }

        public RTextSelectingManipulator(System.Object instance) : base("UnityEngine.UIElements.TextSelectingManipulator")
		{
            SetInstance(instance);
		}

        public RTextSelectingManipulator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextSelectingManipulator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnRevealCursor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnRevealCursor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnSelectIndexChange()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnSelectIndexChange.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnCursorIndexChange()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnCursorIndexChange.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean RevealCursor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRevealCursor.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasSelection()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasSelection.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RExecuteDefaultActionAtTarget_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnFocusEvent(UnityEngine.UIElements.FocusEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnFocusEvent_FocusEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBlurEvent(UnityEngine.UIElements.BlurEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnBlurEvent_BlurEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMouseDownEvent(UnityEngine.UIElements.MouseDownEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnMouseDownEvent_MouseDownEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMouseMoveEvent(UnityEngine.UIElements.MouseMoveEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnMouseMoveEvent_MouseMoveEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMouseUpEvent(UnityEngine.UIElements.MouseUpEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnMouseUpEvent_MouseUpEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnValidateCommandEvent(UnityEngine.UIElements.ValidateCommandEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnValidateCommandEvent_ValidateCommandEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnExecuteCommandEvent(UnityEngine.UIElements.ExecuteCommandEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnExecuteCommandEvent_ExecuteCommandEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean MoveDistanceQualifiesForDrag(UnityEngine.Vector2  @start, UnityEngine.Vector2  @current)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @current};
            var ___result = RMoveDistanceQualifiesForDrag_Vector2_Vector2.Invoke(___genericsType, ___parameters);

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
