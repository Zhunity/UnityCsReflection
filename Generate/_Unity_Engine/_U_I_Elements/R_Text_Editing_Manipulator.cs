
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.TextEditingManipulator
	/// </summary>
    public partial class RTextEditingManipulator : RMember //
    {

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
					r_Fm_TextElement.SetBelong(this.instance);
				}
				return r_Fm_TextElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextEditorEventHandler editingEventHandler
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextEditorEventHandler r_FeditingEventHandler;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextEditorEventHandler RFeditingEventHandler
		{
			get
			{
				if(r_FeditingEventHandler == null)
				{
					r_FeditingEventHandler = new(this, "editingEventHandler");
					r_FeditingEventHandler.SetBelong(this.instance);
				}
				return r_FeditingEventHandler;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditingUtilities editingUtilities
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextEditingUtilities r_FeditingUtilities;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextEditingUtilities RFeditingUtilities
		{
			get
			{
				if(r_FeditingUtilities == null)
				{
					r_FeditingUtilities = new(this, "editingUtilities");
					r_FeditingUtilities.SetBelong(this.instance);
				}
				return r_FeditingUtilities;
			}
		}

		/// <summary>
		/// System.Boolean m_TouchScreenTextFieldInitialized
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_TouchScreenTextFieldInitialized;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_TouchScreenTextFieldInitialized
		{
			get
			{
				if(r_Fm_TouchScreenTextFieldInitialized == null)
				{
					r_Fm_TouchScreenTextFieldInitialized = new(this, "m_TouchScreenTextFieldInitialized");
					r_Fm_TouchScreenTextFieldInitialized.SetBelong(this.instance);
				}
				return r_Fm_TouchScreenTextFieldInitialized;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduledItem m_HardwareKeyboardPoller
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualElementScheduledItem r_Fm_HardwareKeyboardPoller;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualElementScheduledItem RFm_HardwareKeyboardPoller
		{
			get
			{
				if(r_Fm_HardwareKeyboardPoller == null)
				{
					r_Fm_HardwareKeyboardPoller = new(this, "m_HardwareKeyboardPoller");
					r_Fm_HardwareKeyboardPoller.SetBelong(this.instance);
				}
				return r_Fm_HardwareKeyboardPoller;
			}
		}

		/// <summary>
		/// Boolean touchScreenTextFieldChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PtouchScreenTextFieldChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPtouchScreenTextFieldChanged
		{
			get
			{
				if(r_PtouchScreenTextFieldChanged == null)
				{
					r_PtouchScreenTextFieldChanged = new(this, "touchScreenTextFieldChanged", -1);
					r_PtouchScreenTextFieldChanged.SetBelong(this.instance);
				}
				return r_PtouchScreenTextFieldChanged;
			}
		}

		/// <summary>
		/// Void InitTextEditorEventHandler()
		/// </summary>
		protected RMethod r_MInitTextEditorEventHandler;
		public virtual RMethod RMInitTextEditorEventHandler
		{
			get
			{
				if(r_MInitTextEditorEventHandler == null)
				{
					r_MInitTextEditorEventHandler = new(this, "InitTextEditorEventHandler", 0);
					r_MInitTextEditorEventHandler.SetBelong(this.instance);
				}
				return r_MInitTextEditorEventHandler;
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
					r_MExecuteDefaultActionAtTarget_EventBase.SetBelong(this.instance);
				}
				return r_MExecuteDefaultActionAtTarget_EventBase;
			}
		}

		/// <summary>
		/// Void OnFocusInEvent(UnityEngine.UIElements.FocusInEvent)
		/// </summary>
		protected RMethod r_MOnFocusInEvent_FocusInEvent;
		public virtual RMethod RMOnFocusInEvent_FocusInEvent
		{
			get
			{
				if(r_MOnFocusInEvent_FocusInEvent == null)
				{
					r_MOnFocusInEvent_FocusInEvent = new(this, "OnFocusInEvent", 0, typeof(UnityEngine.UIElements.FocusInEvent));
					r_MOnFocusInEvent_FocusInEvent.SetBelong(this.instance);
				}
				return r_MOnFocusInEvent_FocusInEvent;
			}
		}

		/// <summary>
		/// Void OnFocusOutEvent(UnityEngine.UIElements.FocusOutEvent)
		/// </summary>
		protected RMethod r_MOnFocusOutEvent_FocusOutEvent;
		public virtual RMethod RMOnFocusOutEvent_FocusOutEvent
		{
			get
			{
				if(r_MOnFocusOutEvent_FocusOutEvent == null)
				{
					r_MOnFocusOutEvent_FocusOutEvent = new(this, "OnFocusOutEvent", 0, typeof(UnityEngine.UIElements.FocusOutEvent));
					r_MOnFocusOutEvent_FocusOutEvent.SetBelong(this.instance);
				}
				return r_MOnFocusOutEvent_FocusOutEvent;
			}
		}

		/// <summary>
		/// Void <OnFocusInEvent>b__10_0()
		/// </summary>
		protected RMethod r_M__0__OnFocusInEvent__1__b__10_0;
		public virtual RMethod RM__0__OnFocusInEvent__1__b__10_0
		{
			get
			{
				if(r_M__0__OnFocusInEvent__1__b__10_0 == null)
				{
					r_M__0__OnFocusInEvent__1__b__10_0 = new(this, "<OnFocusInEvent>b__10_0", 0);
					r_M__0__OnFocusInEvent__1__b__10_0.SetBelong(this.instance);
				}
				return r_M__0__OnFocusInEvent__1__b__10_0;
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
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
            var ___result = RMInitTextEditorEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMExecuteDefaultActionAtTarget_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnFocusInEvent(UnityEngine.UIElements.FocusInEvent @_)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_};
            var ___result = RMOnFocusInEvent_FocusInEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnFocusOutEvent(UnityEngine.UIElements.FocusOutEvent @_)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_};
            var ___result = RMOnFocusOutEvent_FocusOutEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__OnFocusInEvent__1__b__10_0()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RM__0__OnFocusInEvent__1__b__10_0.Invoke(___genericsType, ___parameters);

            
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
