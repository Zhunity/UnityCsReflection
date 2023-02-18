
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.FocusController
	/// </summary>
    public partial class RFocusController : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.IFocusRing <focusRing>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIFocusRing r_F__0__focusRing__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIFocusRing RF__0__focusRing__1__k__BackingField
		{
			get
			{
				if(r_F__0__focusRing__1__k__BackingField == null)
				{
					r_F__0__focusRing__1__k__BackingField = new(this, "<focusRing>k__BackingField");
				}
				return r_F__0__focusRing__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextElement m_SelectedTextElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextElement r_Fm_SelectedTextElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextElement RFm_SelectedTextElement
		{
			get
			{
				if(r_Fm_SelectedTextElement == null)
				{
					r_Fm_SelectedTextElement = new(this, "m_SelectedTextElement");
				}
				return r_Fm_SelectedTextElement;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.FocusController+FocusedElement] m_FocusedElements
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusController.RFocusedElement> r_Fm_FocusedElements;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusController.RFocusedElement> RFm_FocusedElements
		{
			get
			{
				if(r_Fm_FocusedElements == null)
				{
					r_Fm_FocusedElements = new(this, "m_FocusedElements");
				}
				return r_Fm_FocusedElements;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Focusable m_LastFocusedElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusable r_Fm_LastFocusedElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusable RFm_LastFocusedElement
		{
			get
			{
				if(r_Fm_LastFocusedElement == null)
				{
					r_Fm_LastFocusedElement = new(this, "m_LastFocusedElement");
				}
				return r_Fm_LastFocusedElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Focusable m_LastPendingFocusedElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusable r_Fm_LastPendingFocusedElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusable RFm_LastPendingFocusedElement
		{
			get
			{
				if(r_Fm_LastPendingFocusedElement == null)
				{
					r_Fm_LastPendingFocusedElement = new(this, "m_LastPendingFocusedElement");
				}
				return r_Fm_LastPendingFocusedElement;
			}
		}

		/// <summary>
		/// System.Int32 m_PendingFocusCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_PendingFocusCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_PendingFocusCount
		{
			get
			{
				if(r_Fm_PendingFocusCount == null)
				{
					r_Fm_PendingFocusCount = new(this, "m_PendingFocusCount");
				}
				return r_Fm_PendingFocusCount;
			}
		}

		/// <summary>
		/// System.Int32 <imguiKeyboardControl>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__imguiKeyboardControl__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__imguiKeyboardControl__1__k__BackingField
		{
			get
			{
				if(r_F__0__imguiKeyboardControl__1__k__BackingField == null)
				{
					r_F__0__imguiKeyboardControl__1__k__BackingField = new(this, "<imguiKeyboardControl>k__BackingField");
				}
				return r_F__0__imguiKeyboardControl__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IFocusRing focusRing
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIFocusRing r_PfocusRing;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIFocusRing RPfocusRing
		{
			get
			{
				if(r_PfocusRing == null)
				{
					r_PfocusRing = new(this, "focusRing", -1);
				}
				return r_PfocusRing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextElement selectedTextElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextElement r_PselectedTextElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextElement RPselectedTextElement
		{
			get
			{
				if(r_PselectedTextElement == null)
				{
					r_PselectedTextElement = new(this, "selectedTextElement", -1);
				}
				return r_PselectedTextElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Focusable focusedElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusable r_PfocusedElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusable RPfocusedElement
		{
			get
			{
				if(r_PfocusedElement == null)
				{
					r_PfocusedElement = new(this, "focusedElement", -1);
				}
				return r_PfocusedElement;
			}
		}

		/// <summary>
		/// Int32 imguiKeyboardControl
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PimguiKeyboardControl;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPimguiKeyboardControl
		{
			get
			{
				if(r_PimguiKeyboardControl == null)
				{
					r_PimguiKeyboardControl = new(this, "imguiKeyboardControl", -1);
				}
				return r_PimguiKeyboardControl;
			}
		}

		/// <summary>
		/// Boolean IsFocused(UnityEngine.UIElements.Focusable)
		/// </summary>
		protected RMethod r_MIsFocused_Focusable;
		public virtual RMethod RMIsFocused_Focusable
		{
			get
			{
				if(r_MIsFocused_Focusable == null)
				{
					r_MIsFocused_Focusable = new(this, "IsFocused", 0, typeof(UnityEngine.UIElements.Focusable));
				}
				return r_MIsFocused_Focusable;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Focusable GetRetargetedFocusedElement(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MGetRetargetedFocusedElement_VisualElement;
		public virtual RMethod RMGetRetargetedFocusedElement_VisualElement
		{
			get
			{
				if(r_MGetRetargetedFocusedElement_VisualElement == null)
				{
					r_MGetRetargetedFocusedElement_VisualElement = new(this, "GetRetargetedFocusedElement", 0, typeof(UnityEngine.UIElements.VisualElement));
				}
				return r_MGetRetargetedFocusedElement_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Focusable GetLeafFocusedElement()
		/// </summary>
		protected RMethod r_MGetLeafFocusedElement;
		public virtual RMethod RMGetLeafFocusedElement
		{
			get
			{
				if(r_MGetLeafFocusedElement == null)
				{
					r_MGetLeafFocusedElement = new(this, "GetLeafFocusedElement", 0);
				}
				return r_MGetLeafFocusedElement;
			}
		}

		/// <summary>
		/// Boolean IsLocalElement(UnityEngine.UIElements.Focusable)
		/// </summary>
		protected RMethod r_MIsLocalElement_Focusable;
		public virtual RMethod RMIsLocalElement_Focusable
		{
			get
			{
				if(r_MIsLocalElement_Focusable == null)
				{
					r_MIsLocalElement_Focusable = new(this, "IsLocalElement", 0, typeof(UnityEngine.UIElements.Focusable));
				}
				return r_MIsLocalElement_Focusable;
			}
		}

		/// <summary>
		/// Void ValidateInternalState(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_MValidateInternalState_IPanel;
		public virtual RMethod RMValidateInternalState_IPanel
		{
			get
			{
				if(r_MValidateInternalState_IPanel == null)
				{
					r_MValidateInternalState_IPanel = new(this, "ValidateInternalState", 0, typeof(UnityEngine.UIElements.IPanel));
				}
				return r_MValidateInternalState_IPanel;
			}
		}

		/// <summary>
		/// Void ClearPendingFocusEvents()
		/// </summary>
		protected RMethod r_MClearPendingFocusEvents;
		public virtual RMethod RMClearPendingFocusEvents
		{
			get
			{
				if(r_MClearPendingFocusEvents == null)
				{
					r_MClearPendingFocusEvents = new(this, "ClearPendingFocusEvents", 0);
				}
				return r_MClearPendingFocusEvents;
			}
		}

		/// <summary>
		/// Boolean IsPendingFocus(UnityEngine.UIElements.Focusable)
		/// </summary>
		protected RMethod r_MIsPendingFocus_Focusable;
		public virtual RMethod RMIsPendingFocus_Focusable
		{
			get
			{
				if(r_MIsPendingFocus_Focusable == null)
				{
					r_MIsPendingFocus_Focusable = new(this, "IsPendingFocus", 0, typeof(UnityEngine.UIElements.Focusable));
				}
				return r_MIsPendingFocus_Focusable;
			}
		}

		/// <summary>
		/// Void SetFocusToLastFocusedElement()
		/// </summary>
		protected RMethod r_MSetFocusToLastFocusedElement;
		public virtual RMethod RMSetFocusToLastFocusedElement
		{
			get
			{
				if(r_MSetFocusToLastFocusedElement == null)
				{
					r_MSetFocusToLastFocusedElement = new(this, "SetFocusToLastFocusedElement", 0);
				}
				return r_MSetFocusToLastFocusedElement;
			}
		}

		/// <summary>
		/// Void BlurLastFocusedElement()
		/// </summary>
		protected RMethod r_MBlurLastFocusedElement;
		public virtual RMethod RMBlurLastFocusedElement
		{
			get
			{
				if(r_MBlurLastFocusedElement == null)
				{
					r_MBlurLastFocusedElement = new(this, "BlurLastFocusedElement", 0);
				}
				return r_MBlurLastFocusedElement;
			}
		}

		/// <summary>
		/// Void DoFocusChange(UnityEngine.UIElements.Focusable)
		/// </summary>
		protected RMethod r_MDoFocusChange_Focusable;
		public virtual RMethod RMDoFocusChange_Focusable
		{
			get
			{
				if(r_MDoFocusChange_Focusable == null)
				{
					r_MDoFocusChange_Focusable = new(this, "DoFocusChange", 0, typeof(UnityEngine.UIElements.Focusable));
				}
				return r_MDoFocusChange_Focusable;
			}
		}

		/// <summary>
		/// Void ProcessPendingFocusChange(UnityEngine.UIElements.Focusable)
		/// </summary>
		protected RMethod r_MProcessPendingFocusChange_Focusable;
		public virtual RMethod RMProcessPendingFocusChange_Focusable
		{
			get
			{
				if(r_MProcessPendingFocusChange_Focusable == null)
				{
					r_MProcessPendingFocusChange_Focusable = new(this, "ProcessPendingFocusChange", 0, typeof(UnityEngine.UIElements.Focusable));
				}
				return r_MProcessPendingFocusChange_Focusable;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Focusable FocusNextInDirection(UnityEngine.UIElements.FocusChangeDirection)
		/// </summary>
		protected RMethod r_MFocusNextInDirection_FocusChangeDirection;
		public virtual RMethod RMFocusNextInDirection_FocusChangeDirection
		{
			get
			{
				if(r_MFocusNextInDirection_FocusChangeDirection == null)
				{
					r_MFocusNextInDirection_FocusChangeDirection = new(this, "FocusNextInDirection", 0, typeof(UnityEngine.UIElements.FocusChangeDirection));
				}
				return r_MFocusNextInDirection_FocusChangeDirection;
			}
		}

		/// <summary>
		/// Void AboutToReleaseFocus(UnityEngine.UIElements.Focusable, UnityEngine.UIElements.Focusable, UnityEngine.UIElements.FocusChangeDirection, UnityEngine.UIElements.DispatchMode)
		/// </summary>
		protected RMethod r_MAboutToReleaseFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode;
		public virtual RMethod RMAboutToReleaseFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode
		{
			get
			{
				if(r_MAboutToReleaseFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode == null)
				{
					r_MAboutToReleaseFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode = new(this, "AboutToReleaseFocus", 0, typeof(UnityEngine.UIElements.Focusable), typeof(UnityEngine.UIElements.Focusable), typeof(UnityEngine.UIElements.FocusChangeDirection),  ReflectionUtils.GetType("UnityEngine.UIElements.DispatchMode"));
				}
				return r_MAboutToReleaseFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode;
			}
		}

		/// <summary>
		/// Void ReleaseFocus(UnityEngine.UIElements.Focusable, UnityEngine.UIElements.Focusable, UnityEngine.UIElements.FocusChangeDirection, UnityEngine.UIElements.DispatchMode)
		/// </summary>
		protected RMethod r_MReleaseFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode;
		public virtual RMethod RMReleaseFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode
		{
			get
			{
				if(r_MReleaseFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode == null)
				{
					r_MReleaseFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode = new(this, "ReleaseFocus", 0, typeof(UnityEngine.UIElements.Focusable), typeof(UnityEngine.UIElements.Focusable), typeof(UnityEngine.UIElements.FocusChangeDirection),  ReflectionUtils.GetType("UnityEngine.UIElements.DispatchMode"));
				}
				return r_MReleaseFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode;
			}
		}

		/// <summary>
		/// Void AboutToGrabFocus(UnityEngine.UIElements.Focusable, UnityEngine.UIElements.Focusable, UnityEngine.UIElements.FocusChangeDirection, UnityEngine.UIElements.DispatchMode)
		/// </summary>
		protected RMethod r_MAboutToGrabFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode;
		public virtual RMethod RMAboutToGrabFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode
		{
			get
			{
				if(r_MAboutToGrabFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode == null)
				{
					r_MAboutToGrabFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode = new(this, "AboutToGrabFocus", 0, typeof(UnityEngine.UIElements.Focusable), typeof(UnityEngine.UIElements.Focusable), typeof(UnityEngine.UIElements.FocusChangeDirection),  ReflectionUtils.GetType("UnityEngine.UIElements.DispatchMode"));
				}
				return r_MAboutToGrabFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode;
			}
		}

		/// <summary>
		/// Void GrabFocus(UnityEngine.UIElements.Focusable, UnityEngine.UIElements.Focusable, UnityEngine.UIElements.FocusChangeDirection, Boolean, UnityEngine.UIElements.DispatchMode)
		/// </summary>
		protected RMethod r_MGrabFocus_Focusable_Focusable_FocusChangeDirection_Boolean_DispatchMode;
		public virtual RMethod RMGrabFocus_Focusable_Focusable_FocusChangeDirection_Boolean_DispatchMode
		{
			get
			{
				if(r_MGrabFocus_Focusable_Focusable_FocusChangeDirection_Boolean_DispatchMode == null)
				{
					r_MGrabFocus_Focusable_Focusable_FocusChangeDirection_Boolean_DispatchMode = new(this, "GrabFocus", 0, typeof(UnityEngine.UIElements.Focusable), typeof(UnityEngine.UIElements.Focusable), typeof(UnityEngine.UIElements.FocusChangeDirection), typeof(System.Boolean),  ReflectionUtils.GetType("UnityEngine.UIElements.DispatchMode"));
				}
				return r_MGrabFocus_Focusable_Focusable_FocusChangeDirection_Boolean_DispatchMode;
			}
		}

		/// <summary>
		/// Void Blur(UnityEngine.UIElements.Focusable, Boolean, UnityEngine.UIElements.DispatchMode)
		/// </summary>
		protected RMethod r_MBlur_Focusable_Boolean_DispatchMode;
		public virtual RMethod RMBlur_Focusable_Boolean_DispatchMode
		{
			get
			{
				if(r_MBlur_Focusable_Boolean_DispatchMode == null)
				{
					r_MBlur_Focusable_Boolean_DispatchMode = new(this, "Blur", 0, typeof(UnityEngine.UIElements.Focusable), typeof(System.Boolean),  ReflectionUtils.GetType("UnityEngine.UIElements.DispatchMode"));
				}
				return r_MBlur_Focusable_Boolean_DispatchMode;
			}
		}

		/// <summary>
		/// Void SwitchFocus(UnityEngine.UIElements.Focusable, Boolean, UnityEngine.UIElements.DispatchMode)
		/// </summary>
		protected RMethod r_MSwitchFocus_Focusable_Boolean_DispatchMode;
		public virtual RMethod RMSwitchFocus_Focusable_Boolean_DispatchMode
		{
			get
			{
				if(r_MSwitchFocus_Focusable_Boolean_DispatchMode == null)
				{
					r_MSwitchFocus_Focusable_Boolean_DispatchMode = new(this, "SwitchFocus", 0, typeof(UnityEngine.UIElements.Focusable), typeof(System.Boolean),  ReflectionUtils.GetType("UnityEngine.UIElements.DispatchMode"));
				}
				return r_MSwitchFocus_Focusable_Boolean_DispatchMode;
			}
		}

		/// <summary>
		/// Void SwitchFocus(UnityEngine.UIElements.Focusable, UnityEngine.UIElements.FocusChangeDirection, Boolean, UnityEngine.UIElements.DispatchMode)
		/// </summary>
		protected RMethod r_MSwitchFocus_Focusable_FocusChangeDirection_Boolean_DispatchMode;
		public virtual RMethod RMSwitchFocus_Focusable_FocusChangeDirection_Boolean_DispatchMode
		{
			get
			{
				if(r_MSwitchFocus_Focusable_FocusChangeDirection_Boolean_DispatchMode == null)
				{
					r_MSwitchFocus_Focusable_FocusChangeDirection_Boolean_DispatchMode = new(this, "SwitchFocus", 0, typeof(UnityEngine.UIElements.Focusable), typeof(UnityEngine.UIElements.FocusChangeDirection), typeof(System.Boolean),  ReflectionUtils.GetType("UnityEngine.UIElements.DispatchMode"));
				}
				return r_MSwitchFocus_Focusable_FocusChangeDirection_Boolean_DispatchMode;
			}
		}

		/// <summary>
		/// Void SwitchFocusOnEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MSwitchFocusOnEvent_EventBase;
		public virtual RMethod RMSwitchFocusOnEvent_EventBase
		{
			get
			{
				if(r_MSwitchFocusOnEvent_EventBase == null)
				{
					r_MSwitchFocusOnEvent_EventBase = new(this, "SwitchFocusOnEvent", 0, typeof(UnityEngine.UIElements.EventBase));
				}
				return r_MSwitchFocusOnEvent_EventBase;
			}
		}

		/// <summary>
		/// Void ReevaluateFocus()
		/// </summary>
		protected RMethod r_MReevaluateFocus;
		public virtual RMethod RMReevaluateFocus
		{
			get
			{
				if(r_MReevaluateFocus == null)
				{
					r_MReevaluateFocus = new(this, "ReevaluateFocus", 0);
				}
				return r_MReevaluateFocus;
			}
		}

		/// <summary>
		/// Boolean GetFocusableParentForPointerEvent(UnityEngine.UIElements.Focusable, UnityEngine.UIElements.Focusable ByRef)
		/// </summary>
		protected RMethod r_MGetFocusableParentForPointerEvent_Focusable_Out_Focusable;
		public virtual RMethod RMGetFocusableParentForPointerEvent_Focusable_Out_Focusable
		{
			get
			{
				if(r_MGetFocusableParentForPointerEvent_Focusable_Out_Focusable == null)
				{
					r_MGetFocusableParentForPointerEvent_Focusable_Out_Focusable = new(this, "GetFocusableParentForPointerEvent", 0, typeof(UnityEngine.UIElements.Focusable), typeof(UnityEngine.UIElements.Focusable).MakeByRefType());
				}
				return r_MGetFocusableParentForPointerEvent_Focusable_Out_Focusable;
			}
		}

		/// <summary>
		/// Void SyncIMGUIFocus(Int32, UnityEngine.UIElements.Focusable, Boolean)
		/// </summary>
		protected RMethod r_MSyncIMGUIFocus_Int32_Focusable_Boolean;
		public virtual RMethod RMSyncIMGUIFocus_Int32_Focusable_Boolean
		{
			get
			{
				if(r_MSyncIMGUIFocus_Int32_Focusable_Boolean == null)
				{
					r_MSyncIMGUIFocus_Int32_Focusable_Boolean = new(this, "SyncIMGUIFocus", 0, typeof(System.Int32), typeof(UnityEngine.UIElements.Focusable), typeof(System.Boolean));
				}
				return r_MSyncIMGUIFocus_Int32_Focusable_Boolean;
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


        public RFocusController() : base("UnityEngine.UIElements.FocusController")
        {
        }

        public RFocusController(System.Object instance) : base("UnityEngine.UIElements.FocusController")
		{
            SetInstance(instance);
		}

        public RFocusController(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFocusController(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean IsFocused(UnityEngine.UIElements.Focusable @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RMIsFocused_Focusable.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.UIElements.Focusable GetRetargetedFocusedElement(UnityEngine.UIElements.VisualElement @retargetAgainst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@retargetAgainst};
            var ___result = RMGetRetargetedFocusedElement_VisualElement.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Focusable)___result;
        }


        public virtual UnityEngine.UIElements.Focusable GetLeafFocusedElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLeafFocusedElement.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Focusable)___result;
        }


        public virtual System.Boolean IsLocalElement(UnityEngine.UIElements.Focusable @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RMIsLocalElement_Focusable.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ValidateInternalState(UnityEngine.UIElements.IPanel @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RMValidateInternalState_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearPendingFocusEvents()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearPendingFocusEvents.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsPendingFocus(UnityEngine.UIElements.Focusable @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RMIsPendingFocus_Focusable.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetFocusToLastFocusedElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetFocusToLastFocusedElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BlurLastFocusedElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBlurLastFocusedElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoFocusChange(UnityEngine.UIElements.Focusable @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RMDoFocusChange_Focusable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessPendingFocusChange(UnityEngine.UIElements.Focusable @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RMProcessPendingFocusChange_Focusable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.Focusable FocusNextInDirection(UnityEngine.UIElements.FocusChangeDirection @direction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@direction};
            var ___result = RMFocusNextInDirection_FocusChangeDirection.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Focusable)___result;
        }


        public virtual void AboutToReleaseFocus(UnityEngine.UIElements.Focusable @focusable, UnityEngine.UIElements.Focusable @willGiveFocusTo, UnityEngine.UIElements.FocusChangeDirection @direction, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDispatchMode @dispatchMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@focusable, @willGiveFocusTo, @direction, @dispatchMode.Value};
            var ___result = RMAboutToReleaseFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReleaseFocus(UnityEngine.UIElements.Focusable @focusable, UnityEngine.UIElements.Focusable @willGiveFocusTo, UnityEngine.UIElements.FocusChangeDirection @direction, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDispatchMode @dispatchMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@focusable, @willGiveFocusTo, @direction, @dispatchMode.Value};
            var ___result = RMReleaseFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AboutToGrabFocus(UnityEngine.UIElements.Focusable @focusable, UnityEngine.UIElements.Focusable @willTakeFocusFrom, UnityEngine.UIElements.FocusChangeDirection @direction, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDispatchMode @dispatchMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@focusable, @willTakeFocusFrom, @direction, @dispatchMode.Value};
            var ___result = RMAboutToGrabFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GrabFocus(UnityEngine.UIElements.Focusable @focusable, UnityEngine.UIElements.Focusable @willTakeFocusFrom, UnityEngine.UIElements.FocusChangeDirection @direction, System.Boolean @bIsFocusDelegated, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDispatchMode @dispatchMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@focusable, @willTakeFocusFrom, @direction, @bIsFocusDelegated, @dispatchMode.Value};
            var ___result = RMGrabFocus_Focusable_Focusable_FocusChangeDirection_Boolean_DispatchMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blur(UnityEngine.UIElements.Focusable @focusable, System.Boolean @bIsFocusDelegated, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDispatchMode @dispatchMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@focusable, @bIsFocusDelegated, @dispatchMode.Value};
            var ___result = RMBlur_Focusable_Boolean_DispatchMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SwitchFocus(UnityEngine.UIElements.Focusable @newFocusedElement, System.Boolean @bIsFocusDelegated, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDispatchMode @dispatchMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newFocusedElement, @bIsFocusDelegated, @dispatchMode.Value};
            var ___result = RMSwitchFocus_Focusable_Boolean_DispatchMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SwitchFocus(UnityEngine.UIElements.Focusable @newFocusedElement, UnityEngine.UIElements.FocusChangeDirection @direction, System.Boolean @bIsFocusDelegated, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDispatchMode @dispatchMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newFocusedElement, @direction, @bIsFocusDelegated, @dispatchMode.Value};
            var ___result = RMSwitchFocus_Focusable_FocusChangeDirection_Boolean_DispatchMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SwitchFocusOnEvent(UnityEngine.UIElements.EventBase @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMSwitchFocusOnEvent_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReevaluateFocus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReevaluateFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetFocusableParentForPointerEvent(UnityEngine.UIElements.Focusable @target, out UnityEngine.UIElements.Focusable @effectiveTarget)
        {
			@effectiveTarget = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @effectiveTarget};
            var ___result = RMGetFocusableParentForPointerEvent_Focusable_Out_Focusable.Invoke(___genericsType, ___parameters);
			@effectiveTarget = (UnityEngine.UIElements.Focusable)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual void SyncIMGUIFocus(System.Int32 @imguiKeyboardControlID, UnityEngine.UIElements.Focusable @imguiContainerHavingKeyboardControl, System.Boolean @forceSwitch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@imguiKeyboardControlID, @imguiContainerHavingKeyboardControl, @forceSwitch};
            var ___result = RMSyncIMGUIFocus_Int32_Focusable_Boolean.Invoke(___genericsType, ___parameters);

            
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
