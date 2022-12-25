using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IPointerEvent
	/// </summary>
    public partial class RIPointerEvent : RMember //
    {

		/// <summary>
		/// Int32 pointerId
		/// </summary>
		protected RProperty r_pointerId;
		public virtual RProperty RpointerId
		{
			get
			{
				if(r_pointerId == null)
				{
					r_pointerId = new(this, "pointerId", -1);
					r_pointerId.SetBelong(this.instance);
				}
				return r_pointerId;
			}
		}

		/// <summary>
		/// System.String pointerType
		/// </summary>
		protected RProperty r_pointerType;
		public virtual RProperty RpointerType
		{
			get
			{
				if(r_pointerType == null)
				{
					r_pointerType = new(this, "pointerType", -1);
					r_pointerType.SetBelong(this.instance);
				}
				return r_pointerType;
			}
		}

		/// <summary>
		/// Boolean isPrimary
		/// </summary>
		protected RProperty r_isPrimary;
		public virtual RProperty RisPrimary
		{
			get
			{
				if(r_isPrimary == null)
				{
					r_isPrimary = new(this, "isPrimary", -1);
					r_isPrimary.SetBelong(this.instance);
				}
				return r_isPrimary;
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
		/// UnityEngine.Vector3 position
		/// </summary>
		protected RUnityEngine.RVector3 r_position;
		public virtual RUnityEngine.RVector3 Rposition
		{
			get
			{
				if(r_position == null)
				{
					r_position = new(this, "position", -1);
					r_position.SetBelong(this.instance);
				}
				return r_position;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 localPosition
		/// </summary>
		protected RUnityEngine.RVector3 r_localPosition;
		public virtual RUnityEngine.RVector3 RlocalPosition
		{
			get
			{
				if(r_localPosition == null)
				{
					r_localPosition = new(this, "localPosition", -1);
					r_localPosition.SetBelong(this.instance);
				}
				return r_localPosition;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 deltaPosition
		/// </summary>
		protected RUnityEngine.RVector3 r_deltaPosition;
		public virtual RUnityEngine.RVector3 RdeltaPosition
		{
			get
			{
				if(r_deltaPosition == null)
				{
					r_deltaPosition = new(this, "deltaPosition", -1);
					r_deltaPosition.SetBelong(this.instance);
				}
				return r_deltaPosition;
			}
		}

		/// <summary>
		/// Single deltaTime
		/// </summary>
		protected RProperty r_deltaTime;
		public virtual RProperty RdeltaTime
		{
			get
			{
				if(r_deltaTime == null)
				{
					r_deltaTime = new(this, "deltaTime", -1);
					r_deltaTime.SetBelong(this.instance);
				}
				return r_deltaTime;
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
		/// Single pressure
		/// </summary>
		protected RProperty r_pressure;
		public virtual RProperty Rpressure
		{
			get
			{
				if(r_pressure == null)
				{
					r_pressure = new(this, "pressure", -1);
					r_pressure.SetBelong(this.instance);
				}
				return r_pressure;
			}
		}

		/// <summary>
		/// Single tangentialPressure
		/// </summary>
		protected RProperty r_tangentialPressure;
		public virtual RProperty RtangentialPressure
		{
			get
			{
				if(r_tangentialPressure == null)
				{
					r_tangentialPressure = new(this, "tangentialPressure", -1);
					r_tangentialPressure.SetBelong(this.instance);
				}
				return r_tangentialPressure;
			}
		}

		/// <summary>
		/// Single altitudeAngle
		/// </summary>
		protected RProperty r_altitudeAngle;
		public virtual RProperty RaltitudeAngle
		{
			get
			{
				if(r_altitudeAngle == null)
				{
					r_altitudeAngle = new(this, "altitudeAngle", -1);
					r_altitudeAngle.SetBelong(this.instance);
				}
				return r_altitudeAngle;
			}
		}

		/// <summary>
		/// Single azimuthAngle
		/// </summary>
		protected RProperty r_azimuthAngle;
		public virtual RProperty RazimuthAngle
		{
			get
			{
				if(r_azimuthAngle == null)
				{
					r_azimuthAngle = new(this, "azimuthAngle", -1);
					r_azimuthAngle.SetBelong(this.instance);
				}
				return r_azimuthAngle;
			}
		}

		/// <summary>
		/// Single twist
		/// </summary>
		protected RProperty r_twist;
		public virtual RProperty Rtwist
		{
			get
			{
				if(r_twist == null)
				{
					r_twist = new(this, "twist", -1);
					r_twist.SetBelong(this.instance);
				}
				return r_twist;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 tilt
		/// </summary>
		protected RUnityEngine.RVector2 r_tilt;
		public virtual RUnityEngine.RVector2 Rtilt
		{
			get
			{
				if(r_tilt == null)
				{
					r_tilt = new(this, "tilt", -1);
					r_tilt.SetBelong(this.instance);
				}
				return r_tilt;
			}
		}

		/// <summary>
		/// UnityEngine.PenStatus penStatus
		/// </summary>
		protected RProperty r_penStatus;
		public virtual RProperty RpenStatus
		{
			get
			{
				if(r_penStatus == null)
				{
					r_penStatus = new(this, "penStatus", -1);
					r_penStatus.SetBelong(this.instance);
				}
				return r_penStatus;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 radius
		/// </summary>
		protected RUnityEngine.RVector2 r_radius;
		public virtual RUnityEngine.RVector2 Rradius
		{
			get
			{
				if(r_radius == null)
				{
					r_radius = new(this, "radius", -1);
					r_radius.SetBelong(this.instance);
				}
				return r_radius;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 radiusVariance
		/// </summary>
		protected RUnityEngine.RVector2 r_radiusVariance;
		public virtual RUnityEngine.RVector2 RradiusVariance
		{
			get
			{
				if(r_radiusVariance == null)
				{
					r_radiusVariance = new(this, "radiusVariance", -1);
					r_radiusVariance.SetBelong(this.instance);
				}
				return r_radiusVariance;
			}
		}

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

    }
}
