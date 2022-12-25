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
		protected RMethod r_ROnRevealCursor;
		public virtual RMethod ROnRevealCursor
		{
			get
			{
				if(r_ROnRevealCursor == null)
				{
					r_ROnRevealCursor = new(this, "OnRevealCursor", 0);
					r_ROnRevealCursor.SetBelong(this.instance);
				}
				return r_ROnRevealCursor;
			}
		}

		/// <summary>
		/// Void OnSelectIndexChange()
		/// </summary>
		protected RMethod r_ROnSelectIndexChange;
		public virtual RMethod ROnSelectIndexChange
		{
			get
			{
				if(r_ROnSelectIndexChange == null)
				{
					r_ROnSelectIndexChange = new(this, "OnSelectIndexChange", 0);
					r_ROnSelectIndexChange.SetBelong(this.instance);
				}
				return r_ROnSelectIndexChange;
			}
		}

		/// <summary>
		/// Void OnCursorIndexChange()
		/// </summary>
		protected RMethod r_ROnCursorIndexChange;
		public virtual RMethod ROnCursorIndexChange
		{
			get
			{
				if(r_ROnCursorIndexChange == null)
				{
					r_ROnCursorIndexChange = new(this, "OnCursorIndexChange", 0);
					r_ROnCursorIndexChange.SetBelong(this.instance);
				}
				return r_ROnCursorIndexChange;
			}
		}

		/// <summary>
		/// Boolean RevealCursor()
		/// </summary>
		protected RMethod r_RRevealCursor;
		public virtual RMethod RRevealCursor
		{
			get
			{
				if(r_RRevealCursor == null)
				{
					r_RRevealCursor = new(this, "RevealCursor", 0);
					r_RRevealCursor.SetBelong(this.instance);
				}
				return r_RRevealCursor;
			}
		}

		/// <summary>
		/// Boolean HasSelection()
		/// </summary>
		protected RMethod r_RHasSelection;
		public virtual RMethod RHasSelection
		{
			get
			{
				if(r_RHasSelection == null)
				{
					r_RHasSelection = new(this, "HasSelection", 0);
					r_RHasSelection.SetBelong(this.instance);
				}
				return r_RHasSelection;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RExecuteDefaultActionAtTarget_EventBase;
		public virtual RMethod RExecuteDefaultActionAtTarget_EventBase
		{
			get
			{
				if(r_RExecuteDefaultActionAtTarget_EventBase == null)
				{
					r_RExecuteDefaultActionAtTarget_EventBase = new(this, "ExecuteDefaultActionAtTarget", 0, typeof(UnityEngine.UIElements.EventBase));
					r_RExecuteDefaultActionAtTarget_EventBase.SetBelong(this.instance);
				}
				return r_RExecuteDefaultActionAtTarget_EventBase;
			}
		}

		/// <summary>
		/// Void OnFocusEvent(UnityEngine.UIElements.FocusEvent)
		/// </summary>
		protected RMethod r_ROnFocusEvent_FocusEvent;
		public virtual RMethod ROnFocusEvent_FocusEvent
		{
			get
			{
				if(r_ROnFocusEvent_FocusEvent == null)
				{
					r_ROnFocusEvent_FocusEvent = new(this, "OnFocusEvent", 0, typeof(UnityEngine.UIElements.FocusEvent));
					r_ROnFocusEvent_FocusEvent.SetBelong(this.instance);
				}
				return r_ROnFocusEvent_FocusEvent;
			}
		}

		/// <summary>
		/// Void OnBlurEvent(UnityEngine.UIElements.BlurEvent)
		/// </summary>
		protected RMethod r_ROnBlurEvent_BlurEvent;
		public virtual RMethod ROnBlurEvent_BlurEvent
		{
			get
			{
				if(r_ROnBlurEvent_BlurEvent == null)
				{
					r_ROnBlurEvent_BlurEvent = new(this, "OnBlurEvent", 0, typeof(UnityEngine.UIElements.BlurEvent));
					r_ROnBlurEvent_BlurEvent.SetBelong(this.instance);
				}
				return r_ROnBlurEvent_BlurEvent;
			}
		}

		/// <summary>
		/// Void OnMouseDownEvent(UnityEngine.UIElements.MouseDownEvent)
		/// </summary>
		protected RMethod r_ROnMouseDownEvent_MouseDownEvent;
		public virtual RMethod ROnMouseDownEvent_MouseDownEvent
		{
			get
			{
				if(r_ROnMouseDownEvent_MouseDownEvent == null)
				{
					r_ROnMouseDownEvent_MouseDownEvent = new(this, "OnMouseDownEvent", 0, typeof(UnityEngine.UIElements.MouseDownEvent));
					r_ROnMouseDownEvent_MouseDownEvent.SetBelong(this.instance);
				}
				return r_ROnMouseDownEvent_MouseDownEvent;
			}
		}

		/// <summary>
		/// Void OnMouseMoveEvent(UnityEngine.UIElements.MouseMoveEvent)
		/// </summary>
		protected RMethod r_ROnMouseMoveEvent_MouseMoveEvent;
		public virtual RMethod ROnMouseMoveEvent_MouseMoveEvent
		{
			get
			{
				if(r_ROnMouseMoveEvent_MouseMoveEvent == null)
				{
					r_ROnMouseMoveEvent_MouseMoveEvent = new(this, "OnMouseMoveEvent", 0, typeof(UnityEngine.UIElements.MouseMoveEvent));
					r_ROnMouseMoveEvent_MouseMoveEvent.SetBelong(this.instance);
				}
				return r_ROnMouseMoveEvent_MouseMoveEvent;
			}
		}

		/// <summary>
		/// Void OnMouseUpEvent(UnityEngine.UIElements.MouseUpEvent)
		/// </summary>
		protected RMethod r_ROnMouseUpEvent_MouseUpEvent;
		public virtual RMethod ROnMouseUpEvent_MouseUpEvent
		{
			get
			{
				if(r_ROnMouseUpEvent_MouseUpEvent == null)
				{
					r_ROnMouseUpEvent_MouseUpEvent = new(this, "OnMouseUpEvent", 0, typeof(UnityEngine.UIElements.MouseUpEvent));
					r_ROnMouseUpEvent_MouseUpEvent.SetBelong(this.instance);
				}
				return r_ROnMouseUpEvent_MouseUpEvent;
			}
		}

		/// <summary>
		/// Void OnValidateCommandEvent(UnityEngine.UIElements.ValidateCommandEvent)
		/// </summary>
		protected RMethod r_ROnValidateCommandEvent_ValidateCommandEvent;
		public virtual RMethod ROnValidateCommandEvent_ValidateCommandEvent
		{
			get
			{
				if(r_ROnValidateCommandEvent_ValidateCommandEvent == null)
				{
					r_ROnValidateCommandEvent_ValidateCommandEvent = new(this, "OnValidateCommandEvent", 0, typeof(UnityEngine.UIElements.ValidateCommandEvent));
					r_ROnValidateCommandEvent_ValidateCommandEvent.SetBelong(this.instance);
				}
				return r_ROnValidateCommandEvent_ValidateCommandEvent;
			}
		}

		/// <summary>
		/// Void OnExecuteCommandEvent(UnityEngine.UIElements.ExecuteCommandEvent)
		/// </summary>
		protected RMethod r_ROnExecuteCommandEvent_ExecuteCommandEvent;
		public virtual RMethod ROnExecuteCommandEvent_ExecuteCommandEvent
		{
			get
			{
				if(r_ROnExecuteCommandEvent_ExecuteCommandEvent == null)
				{
					r_ROnExecuteCommandEvent_ExecuteCommandEvent = new(this, "OnExecuteCommandEvent", 0, typeof(UnityEngine.UIElements.ExecuteCommandEvent));
					r_ROnExecuteCommandEvent_ExecuteCommandEvent.SetBelong(this.instance);
				}
				return r_ROnExecuteCommandEvent_ExecuteCommandEvent;
			}
		}

		/// <summary>
		/// Boolean MoveDistanceQualifiesForDrag(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RMoveDistanceQualifiesForDrag_Vector2_Vector2;
		public virtual RMethod RMoveDistanceQualifiesForDrag_Vector2_Vector2
		{
			get
			{
				if(r_RMoveDistanceQualifiesForDrag_Vector2_Vector2 == null)
				{
					r_RMoveDistanceQualifiesForDrag_Vector2_Vector2 = new(this, "MoveDistanceQualifiesForDrag", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_RMoveDistanceQualifiesForDrag_Vector2_Vector2.SetBelong(this.instance);
				}
				return r_RMoveDistanceQualifiesForDrag_Vector2_Vector2;
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
