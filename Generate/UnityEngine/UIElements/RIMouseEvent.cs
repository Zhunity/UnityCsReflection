using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IMouseEvent
	/// </summary>
    public partial class RIMouseEvent : RMember //
    {

		/// <summary>
		/// UnityEngine.EventModifiers modifiers
		/// </summary>
		protected RProperty r_modifiers;
		public virtual RProperty Rmodifiers
		{
			get
			{
				if(r_modifiers == null)
				{
					r_modifiers = new(this, "modifiers", -1);
					r_modifiers.SetBelong(this.instance);
				}
				return r_modifiers;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 mousePosition
		/// </summary>
		protected RUnityEngine.RVector2 r_mousePosition;
		public virtual RUnityEngine.RVector2 RmousePosition
		{
			get
			{
				if(r_mousePosition == null)
				{
					r_mousePosition = new(this, "mousePosition", -1);
					r_mousePosition.SetBelong(this.instance);
				}
				return r_mousePosition;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 localMousePosition
		/// </summary>
		protected RUnityEngine.RVector2 r_localMousePosition;
		public virtual RUnityEngine.RVector2 RlocalMousePosition
		{
			get
			{
				if(r_localMousePosition == null)
				{
					r_localMousePosition = new(this, "localMousePosition", -1);
					r_localMousePosition.SetBelong(this.instance);
				}
				return r_localMousePosition;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 mouseDelta
		/// </summary>
		protected RUnityEngine.RVector2 r_mouseDelta;
		public virtual RUnityEngine.RVector2 RmouseDelta
		{
			get
			{
				if(r_mouseDelta == null)
				{
					r_mouseDelta = new(this, "mouseDelta", -1);
					r_mouseDelta.SetBelong(this.instance);
				}
				return r_mouseDelta;
			}
		}

		/// <summary>
		/// Int32 clickCount
		/// </summary>
		protected RProperty r_clickCount;
		public virtual RProperty RclickCount
		{
			get
			{
				if(r_clickCount == null)
				{
					r_clickCount = new(this, "clickCount", -1);
					r_clickCount.SetBelong(this.instance);
				}
				return r_clickCount;
			}
		}

		/// <summary>
		/// Int32 button
		/// </summary>
		protected RProperty r_button;
		public virtual RProperty Rbutton
		{
			get
			{
				if(r_button == null)
				{
					r_button = new(this, "button", -1);
					r_button.SetBelong(this.instance);
				}
				return r_button;
			}
		}

		/// <summary>
		/// Int32 pressedButtons
		/// </summary>
		protected RProperty r_pressedButtons;
		public virtual RProperty RpressedButtons
		{
			get
			{
				if(r_pressedButtons == null)
				{
					r_pressedButtons = new(this, "pressedButtons", -1);
					r_pressedButtons.SetBelong(this.instance);
				}
				return r_pressedButtons;
			}
		}

		/// <summary>
		/// Boolean shiftKey
		/// </summary>
		protected RProperty r_shiftKey;
		public virtual RProperty RshiftKey
		{
			get
			{
				if(r_shiftKey == null)
				{
					r_shiftKey = new(this, "shiftKey", -1);
					r_shiftKey.SetBelong(this.instance);
				}
				return r_shiftKey;
			}
		}

		/// <summary>
		/// Boolean ctrlKey
		/// </summary>
		protected RProperty r_ctrlKey;
		public virtual RProperty RctrlKey
		{
			get
			{
				if(r_ctrlKey == null)
				{
					r_ctrlKey = new(this, "ctrlKey", -1);
					r_ctrlKey.SetBelong(this.instance);
				}
				return r_ctrlKey;
			}
		}

		/// <summary>
		/// Boolean commandKey
		/// </summary>
		protected RProperty r_commandKey;
		public virtual RProperty RcommandKey
		{
			get
			{
				if(r_commandKey == null)
				{
					r_commandKey = new(this, "commandKey", -1);
					r_commandKey.SetBelong(this.instance);
				}
				return r_commandKey;
			}
		}

		/// <summary>
		/// Boolean altKey
		/// </summary>
		protected RProperty r_altKey;
		public virtual RProperty RaltKey
		{
			get
			{
				if(r_altKey == null)
				{
					r_altKey = new(this, "altKey", -1);
					r_altKey.SetBelong(this.instance);
				}
				return r_altKey;
			}
		}

		/// <summary>
		/// Boolean actionKey
		/// </summary>
		protected RProperty r_actionKey;
		public virtual RProperty RactionKey
		{
			get
			{
				if(r_actionKey == null)
				{
					r_actionKey = new(this, "actionKey", -1);
					r_actionKey.SetBelong(this.instance);
				}
				return r_actionKey;
			}
		}


        public RIMouseEvent() : base("UnityEngine.UIElements.IMouseEvent")
        {
        }

        public RIMouseEvent(System.Object instance) : base("UnityEngine.UIElements.IMouseEvent")
		{
            SetInstance(instance);
		}

        public RIMouseEvent(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIMouseEvent(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

    }
}
