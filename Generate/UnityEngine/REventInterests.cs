using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.EventInterests
	/// </summary>
    public partial class REventInterests : RMember //
    {

		/// <summary>
		/// System.Boolean <wantsMouseMove>k__BackingField
		/// </summary>
		protected RField r___1__wantsMouseMove__2__k__BackingField;
		public virtual RField R__1__wantsMouseMove__2__k__BackingField
		{
			get
			{
				if(r___1__wantsMouseMove__2__k__BackingField == null)
				{
					r___1__wantsMouseMove__2__k__BackingField = new(this, "<wantsMouseMove>k__BackingField");
					r___1__wantsMouseMove__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__wantsMouseMove__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <wantsMouseEnterLeaveWindow>k__BackingField
		/// </summary>
		protected RField r___1__wantsMouseEnterLeaveWindow__2__k__BackingField;
		public virtual RField R__1__wantsMouseEnterLeaveWindow__2__k__BackingField
		{
			get
			{
				if(r___1__wantsMouseEnterLeaveWindow__2__k__BackingField == null)
				{
					r___1__wantsMouseEnterLeaveWindow__2__k__BackingField = new(this, "<wantsMouseEnterLeaveWindow>k__BackingField");
					r___1__wantsMouseEnterLeaveWindow__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__wantsMouseEnterLeaveWindow__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <wantsLessLayoutEvents>k__BackingField
		/// </summary>
		protected RField r___1__wantsLessLayoutEvents__2__k__BackingField;
		public virtual RField R__1__wantsLessLayoutEvents__2__k__BackingField
		{
			get
			{
				if(r___1__wantsLessLayoutEvents__2__k__BackingField == null)
				{
					r___1__wantsLessLayoutEvents__2__k__BackingField = new(this, "<wantsLessLayoutEvents>k__BackingField");
					r___1__wantsLessLayoutEvents__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__wantsLessLayoutEvents__2__k__BackingField;
			}
		}

		/// <summary>
		/// Boolean wantsMouseMove
		/// </summary>
		protected RProperty r_wantsMouseMove;
		public virtual RProperty RwantsMouseMove
		{
			get
			{
				if(r_wantsMouseMove == null)
				{
					r_wantsMouseMove = new(this, "wantsMouseMove", -1);
					r_wantsMouseMove.SetBelong(this.instance);
				}
				return r_wantsMouseMove;
			}
		}

		/// <summary>
		/// Boolean wantsMouseEnterLeaveWindow
		/// </summary>
		protected RProperty r_wantsMouseEnterLeaveWindow;
		public virtual RProperty RwantsMouseEnterLeaveWindow
		{
			get
			{
				if(r_wantsMouseEnterLeaveWindow == null)
				{
					r_wantsMouseEnterLeaveWindow = new(this, "wantsMouseEnterLeaveWindow", -1);
					r_wantsMouseEnterLeaveWindow.SetBelong(this.instance);
				}
				return r_wantsMouseEnterLeaveWindow;
			}
		}

		/// <summary>
		/// Boolean wantsLessLayoutEvents
		/// </summary>
		protected RProperty r_wantsLessLayoutEvents;
		public virtual RProperty RwantsLessLayoutEvents
		{
			get
			{
				if(r_wantsLessLayoutEvents == null)
				{
					r_wantsLessLayoutEvents = new(this, "wantsLessLayoutEvents", -1);
					r_wantsLessLayoutEvents.SetBelong(this.instance);
				}
				return r_wantsLessLayoutEvents;
			}
		}

		/// <summary>
		/// Boolean WantsEvent(UnityEngine.EventType)
		/// </summary>
		protected RMethod r_RWantsEvent_EventType;
		public virtual RMethod RWantsEvent_EventType
		{
			get
			{
				if(r_RWantsEvent_EventType == null)
				{
					r_RWantsEvent_EventType = new(this, "WantsEvent", 0, typeof(UnityEngine.EventType));
					r_RWantsEvent_EventType.SetBelong(this.instance);
				}
				return r_RWantsEvent_EventType;
			}
		}

		/// <summary>
		/// Boolean WantsLayoutPass(UnityEngine.EventType)
		/// </summary>
		protected RMethod r_RWantsLayoutPass_EventType;
		public virtual RMethod RWantsLayoutPass_EventType
		{
			get
			{
				if(r_RWantsLayoutPass_EventType == null)
				{
					r_RWantsLayoutPass_EventType = new(this, "WantsLayoutPass", 0, typeof(UnityEngine.EventType));
					r_RWantsLayoutPass_EventType.SetBelong(this.instance);
				}
				return r_RWantsLayoutPass_EventType;
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


        public REventInterests() : base("UnityEngine.EventInterests")
        {
        }

        public REventInterests(System.Object instance) : base("UnityEngine.EventInterests")
		{
            SetInstance(instance);
		}

        public REventInterests(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REventInterests(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean WantsEvent(UnityEngine.EventType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RWantsEvent_EventType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean WantsLayoutPass(UnityEngine.EventType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RWantsLayoutPass_EventType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
