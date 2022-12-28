using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.FocusController
	/// </summary>
    public partial class RFocusController : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.IFocusRing <focusRing>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RIFocusRing r___1__focusRing__2__k__BackingField;
		public virtual RUnityEngine.RUIElements.RIFocusRing R__1__focusRing__2__k__BackingField
		{
			get
			{
				if(r___1__focusRing__2__k__BackingField == null)
				{
					r___1__focusRing__2__k__BackingField = new(this, "<focusRing>k__BackingField");
					r___1__focusRing__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__focusRing__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextElement m_SelectedTextElement
		/// </summary>
		protected RUnityEngine.RUIElements.RTextElement r_m_SelectedTextElement;
		public virtual RUnityEngine.RUIElements.RTextElement Rm_SelectedTextElement
		{
			get
			{
				if(r_m_SelectedTextElement == null)
				{
					r_m_SelectedTextElement = new(this, "m_SelectedTextElement");
					r_m_SelectedTextElement.SetBelong(this.instance);
				}
				return r_m_SelectedTextElement;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.FocusController+FocusedElement] m_FocusedElements
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RFocusController.RFocusedElement> r_m_FocusedElements;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RFocusController.RFocusedElement> Rm_FocusedElements
		{
			get
			{
				if(r_m_FocusedElements == null)
				{
					r_m_FocusedElements = new(this, "m_FocusedElements");
					r_m_FocusedElements.SetBelong(this.instance);
				}
				return r_m_FocusedElements;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Focusable m_LastFocusedElement
		/// </summary>
		protected RUnityEngine.RUIElements.RFocusable r_m_LastFocusedElement;
		public virtual RUnityEngine.RUIElements.RFocusable Rm_LastFocusedElement
		{
			get
			{
				if(r_m_LastFocusedElement == null)
				{
					r_m_LastFocusedElement = new(this, "m_LastFocusedElement");
					r_m_LastFocusedElement.SetBelong(this.instance);
				}
				return r_m_LastFocusedElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Focusable m_LastPendingFocusedElement
		/// </summary>
		protected RUnityEngine.RUIElements.RFocusable r_m_LastPendingFocusedElement;
		public virtual RUnityEngine.RUIElements.RFocusable Rm_LastPendingFocusedElement
		{
			get
			{
				if(r_m_LastPendingFocusedElement == null)
				{
					r_m_LastPendingFocusedElement = new(this, "m_LastPendingFocusedElement");
					r_m_LastPendingFocusedElement.SetBelong(this.instance);
				}
				return r_m_LastPendingFocusedElement;
			}
		}

		/// <summary>
		/// System.Int32 m_PendingFocusCount
		/// </summary>
		protected RField r_m_PendingFocusCount;
		public virtual RField Rm_PendingFocusCount
		{
			get
			{
				if(r_m_PendingFocusCount == null)
				{
					r_m_PendingFocusCount = new(this, "m_PendingFocusCount");
					r_m_PendingFocusCount.SetBelong(this.instance);
				}
				return r_m_PendingFocusCount;
			}
		}

		/// <summary>
		/// System.Int32 <imguiKeyboardControl>k__BackingField
		/// </summary>
		protected RField r___1__imguiKeyboardControl__2__k__BackingField;
		public virtual RField R__1__imguiKeyboardControl__2__k__BackingField
		{
			get
			{
				if(r___1__imguiKeyboardControl__2__k__BackingField == null)
				{
					r___1__imguiKeyboardControl__2__k__BackingField = new(this, "<imguiKeyboardControl>k__BackingField");
					r___1__imguiKeyboardControl__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__imguiKeyboardControl__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IFocusRing focusRing
		/// </summary>
		protected RUnityEngine.RUIElements.RIFocusRing r_focusRing;
		public virtual RUnityEngine.RUIElements.RIFocusRing RfocusRing
		{
			get
			{
				if(r_focusRing == null)
				{
					r_focusRing = new(this, "focusRing", -1);
					r_focusRing.SetBelong(this.instance);
				}
				return r_focusRing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextElement selectedTextElement
		/// </summary>
		protected RUnityEngine.RUIElements.RTextElement r_selectedTextElement;
		public virtual RUnityEngine.RUIElements.RTextElement RselectedTextElement
		{
			get
			{
				if(r_selectedTextElement == null)
				{
					r_selectedTextElement = new(this, "selectedTextElement", -1);
					r_selectedTextElement.SetBelong(this.instance);
				}
				return r_selectedTextElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Focusable focusedElement
		/// </summary>
		protected RUnityEngine.RUIElements.RFocusable r_focusedElement;
		public virtual RUnityEngine.RUIElements.RFocusable RfocusedElement
		{
			get
			{
				if(r_focusedElement == null)
				{
					r_focusedElement = new(this, "focusedElement", -1);
					r_focusedElement.SetBelong(this.instance);
				}
				return r_focusedElement;
			}
		}

		/// <summary>
		/// Int32 imguiKeyboardControl
		/// </summary>
		protected RProperty r_imguiKeyboardControl;
		public virtual RProperty RimguiKeyboardControl
		{
			get
			{
				if(r_imguiKeyboardControl == null)
				{
					r_imguiKeyboardControl = new(this, "imguiKeyboardControl", -1);
					r_imguiKeyboardControl.SetBelong(this.instance);
				}
				return r_imguiKeyboardControl;
			}
		}

		/// <summary>
		/// Boolean IsFocused(UnityEngine.UIElements.Focusable)
		/// </summary>
		protected RMethod r_RIsFocused_Focusable;
		public virtual RMethod RIsFocused_Focusable
		{
			get
			{
				if(r_RIsFocused_Focusable == null)
				{
					r_RIsFocused_Focusable = new(this, "IsFocused", 0, typeof(UnityEngine.UIElements.Focusable));
					r_RIsFocused_Focusable.SetBelong(this.instance);
				}
				return r_RIsFocused_Focusable;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Focusable GetRetargetedFocusedElement(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RGetRetargetedFocusedElement_VisualElement;
		public virtual RMethod RGetRetargetedFocusedElement_VisualElement
		{
			get
			{
				if(r_RGetRetargetedFocusedElement_VisualElement == null)
				{
					r_RGetRetargetedFocusedElement_VisualElement = new(this, "GetRetargetedFocusedElement", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RGetRetargetedFocusedElement_VisualElement.SetBelong(this.instance);
				}
				return r_RGetRetargetedFocusedElement_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Focusable GetLeafFocusedElement()
		/// </summary>
		protected RMethod r_RGetLeafFocusedElement;
		public virtual RMethod RGetLeafFocusedElement
		{
			get
			{
				if(r_RGetLeafFocusedElement == null)
				{
					r_RGetLeafFocusedElement = new(this, "GetLeafFocusedElement", 0);
					r_RGetLeafFocusedElement.SetBelong(this.instance);
				}
				return r_RGetLeafFocusedElement;
			}
		}

		/// <summary>
		/// Boolean IsLocalElement(UnityEngine.UIElements.Focusable)
		/// </summary>
		protected RMethod r_RIsLocalElement_Focusable;
		public virtual RMethod RIsLocalElement_Focusable
		{
			get
			{
				if(r_RIsLocalElement_Focusable == null)
				{
					r_RIsLocalElement_Focusable = new(this, "IsLocalElement", 0, typeof(UnityEngine.UIElements.Focusable));
					r_RIsLocalElement_Focusable.SetBelong(this.instance);
				}
				return r_RIsLocalElement_Focusable;
			}
		}

		/// <summary>
		/// Void ValidateInternalState(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_RValidateInternalState_IPanel;
		public virtual RMethod RValidateInternalState_IPanel
		{
			get
			{
				if(r_RValidateInternalState_IPanel == null)
				{
					r_RValidateInternalState_IPanel = new(this, "ValidateInternalState", 0, typeof(UnityEngine.UIElements.IPanel));
					r_RValidateInternalState_IPanel.SetBelong(this.instance);
				}
				return r_RValidateInternalState_IPanel;
			}
		}

		/// <summary>
		/// Void ClearPendingFocusEvents()
		/// </summary>
		protected RMethod r_RClearPendingFocusEvents;
		public virtual RMethod RClearPendingFocusEvents
		{
			get
			{
				if(r_RClearPendingFocusEvents == null)
				{
					r_RClearPendingFocusEvents = new(this, "ClearPendingFocusEvents", 0);
					r_RClearPendingFocusEvents.SetBelong(this.instance);
				}
				return r_RClearPendingFocusEvents;
			}
		}

		/// <summary>
		/// Boolean IsPendingFocus(UnityEngine.UIElements.Focusable)
		/// </summary>
		protected RMethod r_RIsPendingFocus_Focusable;
		public virtual RMethod RIsPendingFocus_Focusable
		{
			get
			{
				if(r_RIsPendingFocus_Focusable == null)
				{
					r_RIsPendingFocus_Focusable = new(this, "IsPendingFocus", 0, typeof(UnityEngine.UIElements.Focusable));
					r_RIsPendingFocus_Focusable.SetBelong(this.instance);
				}
				return r_RIsPendingFocus_Focusable;
			}
		}

		/// <summary>
		/// Void SetFocusToLastFocusedElement()
		/// </summary>
		protected RMethod r_RSetFocusToLastFocusedElement;
		public virtual RMethod RSetFocusToLastFocusedElement
		{
			get
			{
				if(r_RSetFocusToLastFocusedElement == null)
				{
					r_RSetFocusToLastFocusedElement = new(this, "SetFocusToLastFocusedElement", 0);
					r_RSetFocusToLastFocusedElement.SetBelong(this.instance);
				}
				return r_RSetFocusToLastFocusedElement;
			}
		}

		/// <summary>
		/// Void BlurLastFocusedElement()
		/// </summary>
		protected RMethod r_RBlurLastFocusedElement;
		public virtual RMethod RBlurLastFocusedElement
		{
			get
			{
				if(r_RBlurLastFocusedElement == null)
				{
					r_RBlurLastFocusedElement = new(this, "BlurLastFocusedElement", 0);
					r_RBlurLastFocusedElement.SetBelong(this.instance);
				}
				return r_RBlurLastFocusedElement;
			}
		}

		/// <summary>
		/// Void DoFocusChange(UnityEngine.UIElements.Focusable)
		/// </summary>
		protected RMethod r_RDoFocusChange_Focusable;
		public virtual RMethod RDoFocusChange_Focusable
		{
			get
			{
				if(r_RDoFocusChange_Focusable == null)
				{
					r_RDoFocusChange_Focusable = new(this, "DoFocusChange", 0, typeof(UnityEngine.UIElements.Focusable));
					r_RDoFocusChange_Focusable.SetBelong(this.instance);
				}
				return r_RDoFocusChange_Focusable;
			}
		}

		/// <summary>
		/// Void ProcessPendingFocusChange(UnityEngine.UIElements.Focusable)
		/// </summary>
		protected RMethod r_RProcessPendingFocusChange_Focusable;
		public virtual RMethod RProcessPendingFocusChange_Focusable
		{
			get
			{
				if(r_RProcessPendingFocusChange_Focusable == null)
				{
					r_RProcessPendingFocusChange_Focusable = new(this, "ProcessPendingFocusChange", 0, typeof(UnityEngine.UIElements.Focusable));
					r_RProcessPendingFocusChange_Focusable.SetBelong(this.instance);
				}
				return r_RProcessPendingFocusChange_Focusable;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Focusable FocusNextInDirection(UnityEngine.UIElements.FocusChangeDirection)
		/// </summary>
		protected RMethod r_RFocusNextInDirection_FocusChangeDirection;
		public virtual RMethod RFocusNextInDirection_FocusChangeDirection
		{
			get
			{
				if(r_RFocusNextInDirection_FocusChangeDirection == null)
				{
					r_RFocusNextInDirection_FocusChangeDirection = new(this, "FocusNextInDirection", 0, typeof(UnityEngine.UIElements.FocusChangeDirection));
					r_RFocusNextInDirection_FocusChangeDirection.SetBelong(this.instance);
				}
				return r_RFocusNextInDirection_FocusChangeDirection;
			}
		}

		/// <summary>
		/// Void AboutToReleaseFocus(UnityEngine.UIElements.Focusable, UnityEngine.UIElements.Focusable, UnityEngine.UIElements.FocusChangeDirection, UnityEngine.UIElements.DispatchMode)
		/// </summary>
		protected RMethod r_RAboutToReleaseFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode;
		public virtual RMethod RAboutToReleaseFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode
		{
			get
			{
				if(r_RAboutToReleaseFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode == null)
				{
					r_RAboutToReleaseFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode = new(this, "AboutToReleaseFocus", 0, typeof(UnityEngine.UIElements.Focusable), typeof(UnityEngine.UIElements.Focusable), typeof(UnityEngine.UIElements.FocusChangeDirection),  ReleactionUtils.GetType("UnityEngine.UIElements.DispatchMode"));
					r_RAboutToReleaseFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode.SetBelong(this.instance);
				}
				return r_RAboutToReleaseFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode;
			}
		}

		/// <summary>
		/// Void ReleaseFocus(UnityEngine.UIElements.Focusable, UnityEngine.UIElements.Focusable, UnityEngine.UIElements.FocusChangeDirection, UnityEngine.UIElements.DispatchMode)
		/// </summary>
		protected RMethod r_RReleaseFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode;
		public virtual RMethod RReleaseFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode
		{
			get
			{
				if(r_RReleaseFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode == null)
				{
					r_RReleaseFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode = new(this, "ReleaseFocus", 0, typeof(UnityEngine.UIElements.Focusable), typeof(UnityEngine.UIElements.Focusable), typeof(UnityEngine.UIElements.FocusChangeDirection),  ReleactionUtils.GetType("UnityEngine.UIElements.DispatchMode"));
					r_RReleaseFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode.SetBelong(this.instance);
				}
				return r_RReleaseFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode;
			}
		}

		/// <summary>
		/// Void AboutToGrabFocus(UnityEngine.UIElements.Focusable, UnityEngine.UIElements.Focusable, UnityEngine.UIElements.FocusChangeDirection, UnityEngine.UIElements.DispatchMode)
		/// </summary>
		protected RMethod r_RAboutToGrabFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode;
		public virtual RMethod RAboutToGrabFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode
		{
			get
			{
				if(r_RAboutToGrabFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode == null)
				{
					r_RAboutToGrabFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode = new(this, "AboutToGrabFocus", 0, typeof(UnityEngine.UIElements.Focusable), typeof(UnityEngine.UIElements.Focusable), typeof(UnityEngine.UIElements.FocusChangeDirection),  ReleactionUtils.GetType("UnityEngine.UIElements.DispatchMode"));
					r_RAboutToGrabFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode.SetBelong(this.instance);
				}
				return r_RAboutToGrabFocus_Focusable_Focusable_FocusChangeDirection_DispatchMode;
			}
		}

		/// <summary>
		/// Void GrabFocus(UnityEngine.UIElements.Focusable, UnityEngine.UIElements.Focusable, UnityEngine.UIElements.FocusChangeDirection, Boolean, UnityEngine.UIElements.DispatchMode)
		/// </summary>
		protected RMethod r_RGrabFocus_Focusable_Focusable_FocusChangeDirection_Boolean_DispatchMode;
		public virtual RMethod RGrabFocus_Focusable_Focusable_FocusChangeDirection_Boolean_DispatchMode
		{
			get
			{
				if(r_RGrabFocus_Focusable_Focusable_FocusChangeDirection_Boolean_DispatchMode == null)
				{
					r_RGrabFocus_Focusable_Focusable_FocusChangeDirection_Boolean_DispatchMode = new(this, "GrabFocus", 0, typeof(UnityEngine.UIElements.Focusable), typeof(UnityEngine.UIElements.Focusable), typeof(UnityEngine.UIElements.FocusChangeDirection), typeof(System.Boolean),  ReleactionUtils.GetType("UnityEngine.UIElements.DispatchMode"));
					r_RGrabFocus_Focusable_Focusable_FocusChangeDirection_Boolean_DispatchMode.SetBelong(this.instance);
				}
				return r_RGrabFocus_Focusable_Focusable_FocusChangeDirection_Boolean_DispatchMode;
			}
		}

		/// <summary>
		/// Void Blur(UnityEngine.UIElements.Focusable, Boolean, UnityEngine.UIElements.DispatchMode)
		/// </summary>
		protected RMethod r_RBlur_Focusable_Boolean_DispatchMode;
		public virtual RMethod RBlur_Focusable_Boolean_DispatchMode
		{
			get
			{
				if(r_RBlur_Focusable_Boolean_DispatchMode == null)
				{
					r_RBlur_Focusable_Boolean_DispatchMode = new(this, "Blur", 0, typeof(UnityEngine.UIElements.Focusable), typeof(System.Boolean),  ReleactionUtils.GetType("UnityEngine.UIElements.DispatchMode"));
					r_RBlur_Focusable_Boolean_DispatchMode.SetBelong(this.instance);
				}
				return r_RBlur_Focusable_Boolean_DispatchMode;
			}
		}

		/// <summary>
		/// Void SwitchFocus(UnityEngine.UIElements.Focusable, Boolean, UnityEngine.UIElements.DispatchMode)
		/// </summary>
		protected RMethod r_RSwitchFocus_Focusable_Boolean_DispatchMode;
		public virtual RMethod RSwitchFocus_Focusable_Boolean_DispatchMode
		{
			get
			{
				if(r_RSwitchFocus_Focusable_Boolean_DispatchMode == null)
				{
					r_RSwitchFocus_Focusable_Boolean_DispatchMode = new(this, "SwitchFocus", 0, typeof(UnityEngine.UIElements.Focusable), typeof(System.Boolean),  ReleactionUtils.GetType("UnityEngine.UIElements.DispatchMode"));
					r_RSwitchFocus_Focusable_Boolean_DispatchMode.SetBelong(this.instance);
				}
				return r_RSwitchFocus_Focusable_Boolean_DispatchMode;
			}
		}

		/// <summary>
		/// Void SwitchFocus(UnityEngine.UIElements.Focusable, UnityEngine.UIElements.FocusChangeDirection, Boolean, UnityEngine.UIElements.DispatchMode)
		/// </summary>
		protected RMethod r_RSwitchFocus_Focusable_FocusChangeDirection_Boolean_DispatchMode;
		public virtual RMethod RSwitchFocus_Focusable_FocusChangeDirection_Boolean_DispatchMode
		{
			get
			{
				if(r_RSwitchFocus_Focusable_FocusChangeDirection_Boolean_DispatchMode == null)
				{
					r_RSwitchFocus_Focusable_FocusChangeDirection_Boolean_DispatchMode = new(this, "SwitchFocus", 0, typeof(UnityEngine.UIElements.Focusable), typeof(UnityEngine.UIElements.FocusChangeDirection), typeof(System.Boolean),  ReleactionUtils.GetType("UnityEngine.UIElements.DispatchMode"));
					r_RSwitchFocus_Focusable_FocusChangeDirection_Boolean_DispatchMode.SetBelong(this.instance);
				}
				return r_RSwitchFocus_Focusable_FocusChangeDirection_Boolean_DispatchMode;
			}
		}

		/// <summary>
		/// Void SwitchFocusOnEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RSwitchFocusOnEvent_EventBase;
		public virtual RMethod RSwitchFocusOnEvent_EventBase
		{
			get
			{
				if(r_RSwitchFocusOnEvent_EventBase == null)
				{
					r_RSwitchFocusOnEvent_EventBase = new(this, "SwitchFocusOnEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_RSwitchFocusOnEvent_EventBase.SetBelong(this.instance);
				}
				return r_RSwitchFocusOnEvent_EventBase;
			}
		}

		/// <summary>
		/// Void ReevaluateFocus()
		/// </summary>
		protected RMethod r_RReevaluateFocus;
		public virtual RMethod RReevaluateFocus
		{
			get
			{
				if(r_RReevaluateFocus == null)
				{
					r_RReevaluateFocus = new(this, "ReevaluateFocus", 0);
					r_RReevaluateFocus.SetBelong(this.instance);
				}
				return r_RReevaluateFocus;
			}
		}

		/// <summary>
		/// Boolean GetFocusableParentForPointerEvent(UnityEngine.UIElements.Focusable, UnityEngine.UIElements.Focusable ByRef)
		/// </summary>
		protected RMethod r_RGetFocusableParentForPointerEvent_Focusable_Out_Focusable;
		public virtual RMethod RGetFocusableParentForPointerEvent_Focusable_Out_Focusable
		{
			get
			{
				if(r_RGetFocusableParentForPointerEvent_Focusable_Out_Focusable == null)
				{
					r_RGetFocusableParentForPointerEvent_Focusable_Out_Focusable = new(this, "GetFocusableParentForPointerEvent", 0, typeof(UnityEngine.UIElements.Focusable), typeof(UnityEngine.UIElements.Focusable).MakeByRefType());
					r_RGetFocusableParentForPointerEvent_Focusable_Out_Focusable.SetBelong(this.instance);
				}
				return r_RGetFocusableParentForPointerEvent_Focusable_Out_Focusable;
			}
		}

		/// <summary>
		/// Void SyncIMGUIFocus(Int32, UnityEngine.UIElements.Focusable, Boolean)
		/// </summary>
		protected RMethod r_RSyncIMGUIFocus_Int32_Focusable_Boolean;
		public virtual RMethod RSyncIMGUIFocus_Int32_Focusable_Boolean
		{
			get
			{
				if(r_RSyncIMGUIFocus_Int32_Focusable_Boolean == null)
				{
					r_RSyncIMGUIFocus_Int32_Focusable_Boolean = new(this, "SyncIMGUIFocus", 0, typeof(System.Int32), typeof(UnityEngine.UIElements.Focusable), typeof(System.Boolean));
					r_RSyncIMGUIFocus_Int32_Focusable_Boolean.SetBelong(this.instance);
				}
				return r_RSyncIMGUIFocus_Int32_Focusable_Boolean;
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

        public virtual System.Boolean IsFocused(UnityEngine.UIElements.Focusable  @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RIsFocused_Focusable.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.UIElements.Focusable GetRetargetedFocusedElement(UnityEngine.UIElements.VisualElement  @retargetAgainst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@retargetAgainst};
            var ___result = RGetRetargetedFocusedElement_VisualElement.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Focusable)___result;
        }


        public virtual UnityEngine.UIElements.Focusable GetLeafFocusedElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLeafFocusedElement.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Focusable)___result;
        }


        public virtual System.Boolean IsLocalElement(UnityEngine.UIElements.Focusable  @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RIsLocalElement_Focusable.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ValidateInternalState(UnityEngine.UIElements.IPanel  @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RValidateInternalState_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearPendingFocusEvents()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearPendingFocusEvents.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsPendingFocus(UnityEngine.UIElements.Focusable  @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RIsPendingFocus_Focusable.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetFocusToLastFocusedElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetFocusToLastFocusedElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BlurLastFocusedElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBlurLastFocusedElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoFocusChange(UnityEngine.UIElements.Focusable  @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RDoFocusChange_Focusable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessPendingFocusChange(UnityEngine.UIElements.Focusable  @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RProcessPendingFocusChange_Focusable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.Focusable FocusNextInDirection(UnityEngine.UIElements.FocusChangeDirection  @direction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@direction};
            var ___result = RFocusNextInDirection_FocusChangeDirection.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Focusable)___result;
        }









        public virtual void SwitchFocusOnEvent(UnityEngine.UIElements.EventBase  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RSwitchFocusOnEvent_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReevaluateFocus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReevaluateFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetFocusableParentForPointerEvent(UnityEngine.UIElements.Focusable  @target, out UnityEngine.UIElements.Focusable  @effectiveTarget)
        {
			effectiveTarget = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @effectiveTarget};
            var ___result = RGetFocusableParentForPointerEvent_Focusable_Out_Focusable.Invoke(___genericsType, ___parameters);
			effectiveTarget = (UnityEngine.UIElements.Focusable)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual void SyncIMGUIFocus(System.Int32  @imguiKeyboardControlID, UnityEngine.UIElements.Focusable  @imguiContainerHavingKeyboardControl, System.Boolean  @forceSwitch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@imguiKeyboardControlID, @imguiContainerHavingKeyboardControl, @forceSwitch};
            var ___result = RSyncIMGUIFocus_Int32_Focusable_Boolean.Invoke(___genericsType, ___parameters);

            
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