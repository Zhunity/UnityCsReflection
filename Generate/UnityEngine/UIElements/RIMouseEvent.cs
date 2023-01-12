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
		protected RUnityEngine.REventModifiers r_Pmodifiers;
		public virtual RUnityEngine.REventModifiers RPmodifiers
		{
			get
			{
				if(r_Pmodifiers == null)
				{
					r_Pmodifiers = new(this, "modifiers", -1);
					r_Pmodifiers.SetBelong(this.instance);
				}
				return r_Pmodifiers;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 mousePosition
		/// </summary>
		protected RUnityEngine.RVector2 r_PmousePosition;
		public virtual RUnityEngine.RVector2 RPmousePosition
		{
			get
			{
				if(r_PmousePosition == null)
				{
					r_PmousePosition = new(this, "mousePosition", -1);
					r_PmousePosition.SetBelong(this.instance);
				}
				return r_PmousePosition;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 localMousePosition
		/// </summary>
		protected RUnityEngine.RVector2 r_PlocalMousePosition;
		public virtual RUnityEngine.RVector2 RPlocalMousePosition
		{
			get
			{
				if(r_PlocalMousePosition == null)
				{
					r_PlocalMousePosition = new(this, "localMousePosition", -1);
					r_PlocalMousePosition.SetBelong(this.instance);
				}
				return r_PlocalMousePosition;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 mouseDelta
		/// </summary>
		protected RUnityEngine.RVector2 r_PmouseDelta;
		public virtual RUnityEngine.RVector2 RPmouseDelta
		{
			get
			{
				if(r_PmouseDelta == null)
				{
					r_PmouseDelta = new(this, "mouseDelta", -1);
					r_PmouseDelta.SetBelong(this.instance);
				}
				return r_PmouseDelta;
			}
		}

		/// <summary>
		/// Int32 clickCount
		/// </summary>
		protected RSystem.RInt32 r_PclickCount;
		public virtual RSystem.RInt32 RPclickCount
		{
			get
			{
				if(r_PclickCount == null)
				{
					r_PclickCount = new(this, "clickCount", -1);
					r_PclickCount.SetBelong(this.instance);
				}
				return r_PclickCount;
			}
		}

		/// <summary>
		/// Int32 button
		/// </summary>
		protected RSystem.RInt32 r_Pbutton;
		public virtual RSystem.RInt32 RPbutton
		{
			get
			{
				if(r_Pbutton == null)
				{
					r_Pbutton = new(this, "button", -1);
					r_Pbutton.SetBelong(this.instance);
				}
				return r_Pbutton;
			}
		}

		/// <summary>
		/// Int32 pressedButtons
		/// </summary>
		protected RSystem.RInt32 r_PpressedButtons;
		public virtual RSystem.RInt32 RPpressedButtons
		{
			get
			{
				if(r_PpressedButtons == null)
				{
					r_PpressedButtons = new(this, "pressedButtons", -1);
					r_PpressedButtons.SetBelong(this.instance);
				}
				return r_PpressedButtons;
			}
		}

		/// <summary>
		/// Boolean shiftKey
		/// </summary>
		protected RSystem.RBoolean r_PshiftKey;
		public virtual RSystem.RBoolean RPshiftKey
		{
			get
			{
				if(r_PshiftKey == null)
				{
					r_PshiftKey = new(this, "shiftKey", -1);
					r_PshiftKey.SetBelong(this.instance);
				}
				return r_PshiftKey;
			}
		}

		/// <summary>
		/// Boolean ctrlKey
		/// </summary>
		protected RSystem.RBoolean r_PctrlKey;
		public virtual RSystem.RBoolean RPctrlKey
		{
			get
			{
				if(r_PctrlKey == null)
				{
					r_PctrlKey = new(this, "ctrlKey", -1);
					r_PctrlKey.SetBelong(this.instance);
				}
				return r_PctrlKey;
			}
		}

		/// <summary>
		/// Boolean commandKey
		/// </summary>
		protected RSystem.RBoolean r_PcommandKey;
		public virtual RSystem.RBoolean RPcommandKey
		{
			get
			{
				if(r_PcommandKey == null)
				{
					r_PcommandKey = new(this, "commandKey", -1);
					r_PcommandKey.SetBelong(this.instance);
				}
				return r_PcommandKey;
			}
		}

		/// <summary>
		/// Boolean altKey
		/// </summary>
		protected RSystem.RBoolean r_PaltKey;
		public virtual RSystem.RBoolean RPaltKey
		{
			get
			{
				if(r_PaltKey == null)
				{
					r_PaltKey = new(this, "altKey", -1);
					r_PaltKey.SetBelong(this.instance);
				}
				return r_PaltKey;
			}
		}

		/// <summary>
		/// Boolean actionKey
		/// </summary>
		protected RSystem.RBoolean r_PactionKey;
		public virtual RSystem.RBoolean RPactionKey
		{
			get
			{
				if(r_PactionKey == null)
				{
					r_PactionKey = new(this, "actionKey", -1);
					r_PactionKey.SetBelong(this.instance);
				}
				return r_PactionKey;
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
