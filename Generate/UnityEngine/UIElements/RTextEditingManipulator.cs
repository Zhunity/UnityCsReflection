using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.TextEditingManipulator
	/// </summary>
    public partial class RTextEditingManipulator : RMember //
    {

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
		/// UnityEngine.UIElements.TextEditorEventHandler editingEventHandler
		/// </summary>
		protected RUnityEngine.RUIElements.RTextEditorEventHandler r_editingEventHandler;
		public virtual RUnityEngine.RUIElements.RTextEditorEventHandler ReditingEventHandler
		{
			get
			{
				if(r_editingEventHandler == null)
				{
					r_editingEventHandler = new(this, "editingEventHandler");
					r_editingEventHandler.SetBelong(this.instance);
				}
				return r_editingEventHandler;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditingUtilities editingUtilities
		/// </summary>
		protected RUnityEngine.RTextEditingUtilities r_editingUtilities;
		public virtual RUnityEngine.RTextEditingUtilities ReditingUtilities
		{
			get
			{
				if(r_editingUtilities == null)
				{
					r_editingUtilities = new(this, "editingUtilities");
					r_editingUtilities.SetBelong(this.instance);
				}
				return r_editingUtilities;
			}
		}

		/// <summary>
		/// System.Boolean m_TouchScreenTextFieldInitialized
		/// </summary>
		protected RField r_m_TouchScreenTextFieldInitialized;
		public virtual RField Rm_TouchScreenTextFieldInitialized
		{
			get
			{
				if(r_m_TouchScreenTextFieldInitialized == null)
				{
					r_m_TouchScreenTextFieldInitialized = new(this, "m_TouchScreenTextFieldInitialized");
					r_m_TouchScreenTextFieldInitialized.SetBelong(this.instance);
				}
				return r_m_TouchScreenTextFieldInitialized;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduledItem m_HardwareKeyboardPoller
		/// </summary>
		protected RUnityEngine.RUIElements.RIVisualElementScheduledItem r_m_HardwareKeyboardPoller;
		public virtual RUnityEngine.RUIElements.RIVisualElementScheduledItem Rm_HardwareKeyboardPoller
		{
			get
			{
				if(r_m_HardwareKeyboardPoller == null)
				{
					r_m_HardwareKeyboardPoller = new(this, "m_HardwareKeyboardPoller");
					r_m_HardwareKeyboardPoller.SetBelong(this.instance);
				}
				return r_m_HardwareKeyboardPoller;
			}
		}

		/// <summary>
		/// Boolean touchScreenTextFieldChanged
		/// </summary>
		protected RProperty r_touchScreenTextFieldChanged;
		public virtual RProperty RtouchScreenTextFieldChanged
		{
			get
			{
				if(r_touchScreenTextFieldChanged == null)
				{
					r_touchScreenTextFieldChanged = new(this, "touchScreenTextFieldChanged", -1);
					r_touchScreenTextFieldChanged.SetBelong(this.instance);
				}
				return r_touchScreenTextFieldChanged;
			}
		}

		/// <summary>
		/// Boolean touchScreenTextField
		/// </summary>
		protected RProperty r_touchScreenTextField;
		public virtual RProperty RtouchScreenTextField
		{
			get
			{
				if(r_touchScreenTextField == null)
				{
					r_touchScreenTextField = new(this, "touchScreenTextField", -1);
					r_touchScreenTextField.SetBelong(this.instance);
				}
				return r_touchScreenTextField;
			}
		}

		/// <summary>
		/// Void InitTextEditorEventHandler()
		/// </summary>
		protected RMethod r_RInitTextEditorEventHandler;
		public virtual RMethod RInitTextEditorEventHandler
		{
			get
			{
				if(r_RInitTextEditorEventHandler == null)
				{
					r_RInitTextEditorEventHandler = new(this, "InitTextEditorEventHandler", 0);
					r_RInitTextEditorEventHandler.SetBelong(this.instance);
				}
				return r_RInitTextEditorEventHandler;
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
		/// Void OnFocusInEvent(UnityEngine.UIElements.FocusInEvent)
		/// </summary>
		protected RMethod r_ROnFocusInEvent_FocusInEvent;
		public virtual RMethod ROnFocusInEvent_FocusInEvent
		{
			get
			{
				if(r_ROnFocusInEvent_FocusInEvent == null)
				{
					r_ROnFocusInEvent_FocusInEvent = new(this, "OnFocusInEvent", 0, typeof(UnityEngine.UIElements.FocusInEvent));
					r_ROnFocusInEvent_FocusInEvent.SetBelong(this.instance);
				}
				return r_ROnFocusInEvent_FocusInEvent;
			}
		}

		/// <summary>
		/// Void OnFocusOutEvent(UnityEngine.UIElements.FocusOutEvent)
		/// </summary>
		protected RMethod r_ROnFocusOutEvent_FocusOutEvent;
		public virtual RMethod ROnFocusOutEvent_FocusOutEvent
		{
			get
			{
				if(r_ROnFocusOutEvent_FocusOutEvent == null)
				{
					r_ROnFocusOutEvent_FocusOutEvent = new(this, "OnFocusOutEvent", 0, typeof(UnityEngine.UIElements.FocusOutEvent));
					r_ROnFocusOutEvent_FocusOutEvent.SetBelong(this.instance);
				}
				return r_ROnFocusOutEvent_FocusOutEvent;
			}
		}

		/// <summary>
		/// Void <OnFocusInEvent>b__12_0()
		/// </summary>
		protected RMethod r_R__1__OnFocusInEvent__2__b__12_0;
		public virtual RMethod R__1__OnFocusInEvent__2__b__12_0
		{
			get
			{
				if(r_R__1__OnFocusInEvent__2__b__12_0 == null)
				{
					r_R__1__OnFocusInEvent__2__b__12_0 = new(this, "<OnFocusInEvent>b__12_0", 0);
					r_R__1__OnFocusInEvent__2__b__12_0.SetBelong(this.instance);
				}
				return r_R__1__OnFocusInEvent__2__b__12_0;
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


        public RTextEditingManipulator() : base("UnityEngine.UIElements.TextEditingManipulator")
        {
        }

        public RTextEditingManipulator(System.Object instance) : base("UnityEngine.UIElements.TextEditingManipulator")
		{
            SetInstance(instance);
		}

        public RTextEditingManipulator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextEditingManipulator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void InitTextEditorEventHandler()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitTextEditorEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RExecuteDefaultActionAtTarget_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnFocusInEvent(UnityEngine.UIElements.FocusInEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnFocusInEvent_FocusInEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnFocusOutEvent(UnityEngine.UIElements.FocusOutEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnFocusOutEvent_FocusOutEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __1__OnFocusInEvent__2__b__12_0()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__1__OnFocusInEvent__2__b__12_0.Invoke(___genericsType, ___parameters);

            
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
