
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.IPointerEvent
	/// </summary>
    public partial class RIPointerEvent : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.IPointerEvent);
            }
        }

        public RIPointerEvent() : base("UnityEngine.UIElements.IPointerEvent")
        {
        }

        public RIPointerEvent(System.Object instance) : base("UnityEngine.UIElements.IPointerEvent")
		{
            SetInstance(instance);
		}

        public RIPointerEvent(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIPointerEvent(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// Int32 pointerId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PpointerId;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPpointerId
		{
			get
			{
				if(r_PpointerId == null)
				{
					r_PpointerId = new(this, "pointerId", -1);
				}
				return r_PpointerId;
			}
		}

		/// <summary>
		/// System.String pointerType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PpointerType;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPpointerType
		{
			get
			{
				if(r_PpointerType == null)
				{
					r_PpointerType = new(this, "pointerType", -1);
				}
				return r_PpointerType;
			}
		}

		/// <summary>
		/// Boolean isPrimary
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisPrimary;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisPrimary
		{
			get
			{
				if(r_PisPrimary == null)
				{
					r_PisPrimary = new(this, "isPrimary", -1);
				}
				return r_PisPrimary;
			}
		}

		/// <summary>
		/// Int32 button
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pbutton;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPbutton
		{
			get
			{
				if(r_Pbutton == null)
				{
					r_Pbutton = new(this, "button", -1);
				}
				return r_Pbutton;
			}
		}

		/// <summary>
		/// Int32 pressedButtons
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PpressedButtons;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPpressedButtons
		{
			get
			{
				if(r_PpressedButtons == null)
				{
					r_PpressedButtons = new(this, "pressedButtons", -1);
				}
				return r_PpressedButtons;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 position
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Pposition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPposition
		{
			get
			{
				if(r_Pposition == null)
				{
					r_Pposition = new(this, "position", -1);
				}
				return r_Pposition;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 localPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_PlocalPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPlocalPosition
		{
			get
			{
				if(r_PlocalPosition == null)
				{
					r_PlocalPosition = new(this, "localPosition", -1);
				}
				return r_PlocalPosition;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 deltaPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_PdeltaPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPdeltaPosition
		{
			get
			{
				if(r_PdeltaPosition == null)
				{
					r_PdeltaPosition = new(this, "deltaPosition", -1);
				}
				return r_PdeltaPosition;
			}
		}

		/// <summary>
		/// Single deltaTime
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PdeltaTime;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPdeltaTime
		{
			get
			{
				if(r_PdeltaTime == null)
				{
					r_PdeltaTime = new(this, "deltaTime", -1);
				}
				return r_PdeltaTime;
			}
		}

		/// <summary>
		/// Int32 clickCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PclickCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPclickCount
		{
			get
			{
				if(r_PclickCount == null)
				{
					r_PclickCount = new(this, "clickCount", -1);
				}
				return r_PclickCount;
			}
		}

		/// <summary>
		/// Single pressure
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Ppressure;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPpressure
		{
			get
			{
				if(r_Ppressure == null)
				{
					r_Ppressure = new(this, "pressure", -1);
				}
				return r_Ppressure;
			}
		}

		/// <summary>
		/// Single tangentialPressure
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PtangentialPressure;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPtangentialPressure
		{
			get
			{
				if(r_PtangentialPressure == null)
				{
					r_PtangentialPressure = new(this, "tangentialPressure", -1);
				}
				return r_PtangentialPressure;
			}
		}

		/// <summary>
		/// Single altitudeAngle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PaltitudeAngle;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPaltitudeAngle
		{
			get
			{
				if(r_PaltitudeAngle == null)
				{
					r_PaltitudeAngle = new(this, "altitudeAngle", -1);
				}
				return r_PaltitudeAngle;
			}
		}

		/// <summary>
		/// Single azimuthAngle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PazimuthAngle;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPazimuthAngle
		{
			get
			{
				if(r_PazimuthAngle == null)
				{
					r_PazimuthAngle = new(this, "azimuthAngle", -1);
				}
				return r_PazimuthAngle;
			}
		}

		/// <summary>
		/// Single twist
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Ptwist;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPtwist
		{
			get
			{
				if(r_Ptwist == null)
				{
					r_Ptwist = new(this, "twist", -1);
				}
				return r_Ptwist;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 tilt
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Ptilt;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPtilt
		{
			get
			{
				if(r_Ptilt == null)
				{
					r_Ptilt = new(this, "tilt", -1);
				}
				return r_Ptilt;
			}
		}

		/// <summary>
		/// UnityEngine.PenStatus penStatus
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RPenStatus r_PpenStatus;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RPenStatus RPpenStatus
		{
			get
			{
				if(r_PpenStatus == null)
				{
					r_PpenStatus = new(this, "penStatus", -1);
				}
				return r_PpenStatus;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 radius
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Pradius;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPradius
		{
			get
			{
				if(r_Pradius == null)
				{
					r_Pradius = new(this, "radius", -1);
				}
				return r_Pradius;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 radiusVariance
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PradiusVariance;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPradiusVariance
		{
			get
			{
				if(r_PradiusVariance == null)
				{
					r_PradiusVariance = new(this, "radiusVariance", -1);
				}
				return r_PradiusVariance;
			}
		}

		/// <summary>
		/// UnityEngine.EventModifiers modifiers
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.REventModifiers r_Pmodifiers;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.REventModifiers RPmodifiers
		{
			get
			{
				if(r_Pmodifiers == null)
				{
					r_Pmodifiers = new(this, "modifiers", -1);
				}
				return r_Pmodifiers;
			}
		}

		/// <summary>
		/// Boolean shiftKey
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PshiftKey;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPshiftKey
		{
			get
			{
				if(r_PshiftKey == null)
				{
					r_PshiftKey = new(this, "shiftKey", -1);
				}
				return r_PshiftKey;
			}
		}

		/// <summary>
		/// Boolean ctrlKey
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PctrlKey;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPctrlKey
		{
			get
			{
				if(r_PctrlKey == null)
				{
					r_PctrlKey = new(this, "ctrlKey", -1);
				}
				return r_PctrlKey;
			}
		}

		/// <summary>
		/// Boolean commandKey
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PcommandKey;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPcommandKey
		{
			get
			{
				if(r_PcommandKey == null)
				{
					r_PcommandKey = new(this, "commandKey", -1);
				}
				return r_PcommandKey;
			}
		}

		/// <summary>
		/// Boolean altKey
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PaltKey;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPaltKey
		{
			get
			{
				if(r_PaltKey == null)
				{
					r_PaltKey = new(this, "altKey", -1);
				}
				return r_PaltKey;
			}
		}

		/// <summary>
		/// Boolean actionKey
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PactionKey;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPactionKey
		{
			get
			{
				if(r_PactionKey == null)
				{
					r_PactionKey = new(this, "actionKey", -1);
				}
				return r_PactionKey;
			}
		}


    }
}
