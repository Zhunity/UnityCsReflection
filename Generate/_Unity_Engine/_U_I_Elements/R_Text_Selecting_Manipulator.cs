
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.UIElements.TextSelectingManipulator
	/// </summary>
    public partial class RTextSelectingManipulator : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.TextSelectingManipulator");
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


		/// <summary>
		/// UnityEngine.TextSelectingUtilities m_SelectingUtilities
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextSelectingUtilities r_Fm_SelectingUtilities;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextSelectingUtilities RFm_SelectingUtilities
		{
			get
			{
				if(r_Fm_SelectingUtilities == null)
				{
					r_Fm_SelectingUtilities = new(this, "m_SelectingUtilities");
				}
				return r_Fm_SelectingUtilities;
			}
		}

		/// <summary>
		/// System.Boolean selectAllOnMouseUp
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FselectAllOnMouseUp;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFselectAllOnMouseUp
		{
			get
			{
				if(r_FselectAllOnMouseUp == null)
				{
					r_FselectAllOnMouseUp = new(this, "selectAllOnMouseUp");
				}
				return r_FselectAllOnMouseUp;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextElement m_TextElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextElement r_Fm_TextElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextElement RFm_TextElement
		{
			get
			{
				if(r_Fm_TextElement == null)
				{
					r_Fm_TextElement = new(this, "m_TextElement");
				}
				return r_Fm_TextElement;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_ClickStartPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Fm_ClickStartPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFm_ClickStartPosition
		{
			get
			{
				if(r_Fm_ClickStartPosition == null)
				{
					r_Fm_ClickStartPosition = new(this, "m_ClickStartPosition");
				}
				return r_Fm_ClickStartPosition;
			}
		}

		/// <summary>
		/// System.Boolean m_Dragged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_Dragged;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_Dragged
		{
			get
			{
				if(r_Fm_Dragged == null)
				{
					r_Fm_Dragged = new(this, "m_Dragged");
				}
				return r_Fm_Dragged;
			}
		}

		/// <summary>
		/// System.Boolean m_IsClicking
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_IsClicking;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_IsClicking
		{
			get
			{
				if(r_Fm_IsClicking == null)
				{
					r_Fm_IsClicking = new(this, "m_IsClicking");
				}
				return r_Fm_IsClicking;
			}
		}

		/// <summary>
		/// System.Int32 k_DragThresholdSqr
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_DragThresholdSqr;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_DragThresholdSqr
		{
			get
			{
				if(r_Fk_DragThresholdSqr == null)
				{
					r_Fk_DragThresholdSqr = new(Type, "k_DragThresholdSqr");
				}
				return r_Fk_DragThresholdSqr;
			}
		}

		/// <summary>
		/// UnityEngine.Event m_ImguiEvent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.REvent r_Fm_ImguiEvent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.REvent RFm_ImguiEvent
		{
			get
			{
				if(r_Fm_ImguiEvent == null)
				{
					r_Fm_ImguiEvent = new(this, "m_ImguiEvent");
				}
				return r_Fm_ImguiEvent;
			}
		}

		/// <summary>
		/// Boolean isClicking
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisClicking;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisClicking
		{
			get
			{
				if(r_PisClicking == null)
				{
					r_PisClicking = new(this, "isClicking", -1);
				}
				return r_PisClicking;
			}
		}

		/// <summary>
		/// Int32 cursorIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PcursorIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPcursorIndex
		{
			get
			{
				if(r_PcursorIndex == null)
				{
					r_PcursorIndex = new(this, "cursorIndex", -1);
				}
				return r_PcursorIndex;
			}
		}

		/// <summary>
		/// Int32 selectIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PselectIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPselectIndex
		{
			get
			{
				if(r_PselectIndex == null)
				{
					r_PselectIndex = new(this, "selectIndex", -1);
				}
				return r_PselectIndex;
			}
		}

		/// <summary>
		/// Void OnRevealCursor()
		/// </summary>
		protected RMethod r_MOnRevealCursor;
		public virtual RMethod RMOnRevealCursor
		{
			get
			{
				if(r_MOnRevealCursor == null)
				{
					r_MOnRevealCursor = new(this, "OnRevealCursor", 0);
				}
				return r_MOnRevealCursor;
			}
		}

		/// <summary>
		/// Void OnSelectIndexChange()
		/// </summary>
		protected RMethod r_MOnSelectIndexChange;
		public virtual RMethod RMOnSelectIndexChange
		{
			get
			{
				if(r_MOnSelectIndexChange == null)
				{
					r_MOnSelectIndexChange = new(this, "OnSelectIndexChange", 0);
				}
				return r_MOnSelectIndexChange;
			}
		}

		/// <summary>
		/// Void OnCursorIndexChange()
		/// </summary>
		protected RMethod r_MOnCursorIndexChange;
		public virtual RMethod RMOnCursorIndexChange
		{
			get
			{
				if(r_MOnCursorIndexChange == null)
				{
					r_MOnCursorIndexChange = new(this, "OnCursorIndexChange", 0);
				}
				return r_MOnCursorIndexChange;
			}
		}

		/// <summary>
		/// Boolean RevealCursor()
		/// </summary>
		protected RMethod r_MRevealCursor;
		public virtual RMethod RMRevealCursor
		{
			get
			{
				if(r_MRevealCursor == null)
				{
					r_MRevealCursor = new(this, "RevealCursor", 0);
				}
				return r_MRevealCursor;
			}
		}

		/// <summary>
		/// Boolean HasSelection()
		/// </summary>
		protected RMethod r_MHasSelection;
		public virtual RMethod RMHasSelection
		{
			get
			{
				if(r_MHasSelection == null)
				{
					r_MHasSelection = new(this, "HasSelection", 0);
				}
				return r_MHasSelection;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MExecuteDefaultActionAtTarget_EventBase;
		public virtual RMethod RMExecuteDefaultActionAtTarget_EventBase
		{
			get
			{
				if(r_MExecuteDefaultActionAtTarget_EventBase == null)
				{
					r_MExecuteDefaultActionAtTarget_EventBase = new(this, "ExecuteDefaultActionAtTarget", 0, typeof(UnityEngine.UIElements.EventBase));
				}
				return r_MExecuteDefaultActionAtTarget_EventBase;
			}
		}

		/// <summary>
		/// Void OnFocusEvent(UnityEngine.UIElements.FocusEvent)
		/// </summary>
		protected RMethod r_MOnFocusEvent_FocusEvent;
		public virtual RMethod RMOnFocusEvent_FocusEvent
		{
			get
			{
				if(r_MOnFocusEvent_FocusEvent == null)
				{
					r_MOnFocusEvent_FocusEvent = new(this, "OnFocusEvent", 0, typeof(UnityEngine.UIElements.FocusEvent));
				}
				return r_MOnFocusEvent_FocusEvent;
			}
		}

		/// <summary>
		/// Void OnBlurEvent(UnityEngine.UIElements.BlurEvent)
		/// </summary>
		protected RMethod r_MOnBlurEvent_BlurEvent;
		public virtual RMethod RMOnBlurEvent_BlurEvent
		{
			get
			{
				if(r_MOnBlurEvent_BlurEvent == null)
				{
					r_MOnBlurEvent_BlurEvent = new(this, "OnBlurEvent", 0, typeof(UnityEngine.UIElements.BlurEvent));
				}
				return r_MOnBlurEvent_BlurEvent;
			}
		}

		/// <summary>
		/// Void OnKeyDown(UnityEngine.UIElements.KeyDownEvent)
		/// </summary>
		protected RMethod r_MOnKeyDown_KeyDownEvent;
		public virtual RMethod RMOnKeyDown_KeyDownEvent
		{
			get
			{
				if(r_MOnKeyDown_KeyDownEvent == null)
				{
					r_MOnKeyDown_KeyDownEvent = new(this, "OnKeyDown", 0, typeof(UnityEngine.UIElements.KeyDownEvent));
				}
				return r_MOnKeyDown_KeyDownEvent;
			}
		}

		/// <summary>
		/// Void OnPointerDownEvent(UnityEngine.UIElements.PointerDownEvent)
		/// </summary>
		protected RMethod r_MOnPointerDownEvent_PointerDownEvent;
		public virtual RMethod RMOnPointerDownEvent_PointerDownEvent
		{
			get
			{
				if(r_MOnPointerDownEvent_PointerDownEvent == null)
				{
					r_MOnPointerDownEvent_PointerDownEvent = new(this, "OnPointerDownEvent", 0, typeof(UnityEngine.UIElements.PointerDownEvent));
				}
				return r_MOnPointerDownEvent_PointerDownEvent;
			}
		}

		/// <summary>
		/// Void OnPointerMoveEvent(UnityEngine.UIElements.PointerMoveEvent)
		/// </summary>
		protected RMethod r_MOnPointerMoveEvent_PointerMoveEvent;
		public virtual RMethod RMOnPointerMoveEvent_PointerMoveEvent
		{
			get
			{
				if(r_MOnPointerMoveEvent_PointerMoveEvent == null)
				{
					r_MOnPointerMoveEvent_PointerMoveEvent = new(this, "OnPointerMoveEvent", 0, typeof(UnityEngine.UIElements.PointerMoveEvent));
				}
				return r_MOnPointerMoveEvent_PointerMoveEvent;
			}
		}

		/// <summary>
		/// Void OnPointerUpEvent(UnityEngine.UIElements.PointerUpEvent)
		/// </summary>
		protected RMethod r_MOnPointerUpEvent_PointerUpEvent;
		public virtual RMethod RMOnPointerUpEvent_PointerUpEvent
		{
			get
			{
				if(r_MOnPointerUpEvent_PointerUpEvent == null)
				{
					r_MOnPointerUpEvent_PointerUpEvent = new(this, "OnPointerUpEvent", 0, typeof(UnityEngine.UIElements.PointerUpEvent));
				}
				return r_MOnPointerUpEvent_PointerUpEvent;
			}
		}

		/// <summary>
		/// Void OnValidateCommandEvent(UnityEngine.UIElements.ValidateCommandEvent)
		/// </summary>
		protected RMethod r_MOnValidateCommandEvent_ValidateCommandEvent;
		public virtual RMethod RMOnValidateCommandEvent_ValidateCommandEvent
		{
			get
			{
				if(r_MOnValidateCommandEvent_ValidateCommandEvent == null)
				{
					r_MOnValidateCommandEvent_ValidateCommandEvent = new(this, "OnValidateCommandEvent", 0, typeof(UnityEngine.UIElements.ValidateCommandEvent));
				}
				return r_MOnValidateCommandEvent_ValidateCommandEvent;
			}
		}

		/// <summary>
		/// Void OnExecuteCommandEvent(UnityEngine.UIElements.ExecuteCommandEvent)
		/// </summary>
		protected RMethod r_MOnExecuteCommandEvent_ExecuteCommandEvent;
		public virtual RMethod RMOnExecuteCommandEvent_ExecuteCommandEvent
		{
			get
			{
				if(r_MOnExecuteCommandEvent_ExecuteCommandEvent == null)
				{
					r_MOnExecuteCommandEvent_ExecuteCommandEvent = new(this, "OnExecuteCommandEvent", 0, typeof(UnityEngine.UIElements.ExecuteCommandEvent));
				}
				return r_MOnExecuteCommandEvent_ExecuteCommandEvent;
			}
		}

		/// <summary>
		/// Boolean MoveDistanceQualifiesForDrag(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MMoveDistanceQualifiesForDrag_Vector2_Vector2;
		public virtual RMethod RMMoveDistanceQualifiesForDrag_Vector2_Vector2
		{
			get
			{
				if(r_MMoveDistanceQualifiesForDrag_Vector2_Vector2 == null)
				{
					r_MMoveDistanceQualifiesForDrag_Vector2_Vector2 = new(this, "MoveDistanceQualifiesForDrag", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
				}
				return r_MMoveDistanceQualifiesForDrag_Vector2_Vector2;
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


        public virtual void OnRevealCursor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnRevealCursor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnSelectIndexChange()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnSelectIndexChange.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnCursorIndexChange()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnCursorIndexChange.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean RevealCursor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRevealCursor.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasSelection()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasSelection.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMExecuteDefaultActionAtTarget_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnFocusEvent(UnityEngine.UIElements.FocusEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnFocusEvent_FocusEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBlurEvent(UnityEngine.UIElements.BlurEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnBlurEvent_BlurEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnKeyDown(UnityEngine.UIElements.KeyDownEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnKeyDown_KeyDownEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPointerDownEvent(UnityEngine.UIElements.PointerDownEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnPointerDownEvent_PointerDownEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPointerMoveEvent(UnityEngine.UIElements.PointerMoveEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnPointerMoveEvent_PointerMoveEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPointerUpEvent(UnityEngine.UIElements.PointerUpEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnPointerUpEvent_PointerUpEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnValidateCommandEvent(UnityEngine.UIElements.ValidateCommandEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnValidateCommandEvent_ValidateCommandEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnExecuteCommandEvent(UnityEngine.UIElements.ExecuteCommandEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnExecuteCommandEvent_ExecuteCommandEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean MoveDistanceQualifiesForDrag(UnityEngine.Vector2 @start, UnityEngine.Vector2 @current)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @current};
            var ___result = RMMoveDistanceQualifiesForDrag_Vector2_Vector2.Invoke(___genericsType, ___parameters);

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
