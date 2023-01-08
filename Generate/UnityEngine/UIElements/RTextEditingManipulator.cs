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
		protected RMethod r_InitTextEditorEventHandler;
		public virtual RMethod RInitTextEditorEventHandler
		{
			get
			{
				if(r_InitTextEditorEventHandler == null)
				{
					r_InitTextEditorEventHandler = new(this, "InitTextEditorEventHandler", 0);
					r_InitTextEditorEventHandler.SetBelong(this.instance);
				}
				return r_InitTextEditorEventHandler;
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
		/// Void OnFocusInEvent(UnityEngine.UIElements.FocusInEvent)
		/// </summary>
		protected RMethod r_OnFocusInEvent_FocusInEvent;
		public virtual RMethod ROnFocusInEvent_FocusInEvent
		{
			get
			{
				if(r_OnFocusInEvent_FocusInEvent == null)
				{
					r_OnFocusInEvent_FocusInEvent = new(this, "OnFocusInEvent", 0, typeof(UnityEngine.UIElements.FocusInEvent));
					r_OnFocusInEvent_FocusInEvent.SetBelong(this.instance);
				}
				return r_OnFocusInEvent_FocusInEvent;
			}
		}

		/// <summary>
		/// Void OnFocusOutEvent(UnityEngine.UIElements.FocusOutEvent)
		/// </summary>
		protected RMethod r_OnFocusOutEvent_FocusOutEvent;
		public virtual RMethod ROnFocusOutEvent_FocusOutEvent
		{
			get
			{
				if(r_OnFocusOutEvent_FocusOutEvent == null)
				{
					r_OnFocusOutEvent_FocusOutEvent = new(this, "OnFocusOutEvent", 0, typeof(UnityEngine.UIElements.FocusOutEvent));
					r_OnFocusOutEvent_FocusOutEvent.SetBelong(this.instance);
				}
				return r_OnFocusOutEvent_FocusOutEvent;
			}
		}

		/// <summary>
		/// Void <OnFocusInEvent>b__12_0()
		/// </summary>
		protected RMethod r___0__OnFocusInEvent__1__b__12_0;
		public virtual RMethod R__0__OnFocusInEvent__1__b__12_0
		{
			get
			{
				if(r___0__OnFocusInEvent__1__b__12_0 == null)
				{
					r___0__OnFocusInEvent__1__b__12_0 = new(this, "<OnFocusInEvent>b__12_0", 0);
					r___0__OnFocusInEvent__1__b__12_0.SetBelong(this.instance);
				}
				return r___0__OnFocusInEvent__1__b__12_0;
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


        public virtual void __0__OnFocusInEvent__1__b__12_0()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__OnFocusInEvent__1__b__12_0.Invoke(___genericsType, ___parameters);

            
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
