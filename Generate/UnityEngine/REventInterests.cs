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
		protected RField r___0__wantsMouseMove__1__k__BackingField;
		public virtual RField R__0__wantsMouseMove__1__k__BackingField
		{
			get
			{
				if(r___0__wantsMouseMove__1__k__BackingField == null)
				{
					r___0__wantsMouseMove__1__k__BackingField = new(this, "<wantsMouseMove>k__BackingField");
					r___0__wantsMouseMove__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__wantsMouseMove__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <wantsMouseEnterLeaveWindow>k__BackingField
		/// </summary>
		protected RField r___0__wantsMouseEnterLeaveWindow__1__k__BackingField;
		public virtual RField R__0__wantsMouseEnterLeaveWindow__1__k__BackingField
		{
			get
			{
				if(r___0__wantsMouseEnterLeaveWindow__1__k__BackingField == null)
				{
					r___0__wantsMouseEnterLeaveWindow__1__k__BackingField = new(this, "<wantsMouseEnterLeaveWindow>k__BackingField");
					r___0__wantsMouseEnterLeaveWindow__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__wantsMouseEnterLeaveWindow__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <wantsLessLayoutEvents>k__BackingField
		/// </summary>
		protected RField r___0__wantsLessLayoutEvents__1__k__BackingField;
		public virtual RField R__0__wantsLessLayoutEvents__1__k__BackingField
		{
			get
			{
				if(r___0__wantsLessLayoutEvents__1__k__BackingField == null)
				{
					r___0__wantsLessLayoutEvents__1__k__BackingField = new(this, "<wantsLessLayoutEvents>k__BackingField");
					r___0__wantsLessLayoutEvents__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__wantsLessLayoutEvents__1__k__BackingField;
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
		protected RMethod r_WantsEvent_EventType;
		public virtual RMethod RWantsEvent_EventType
		{
			get
			{
				if(r_WantsEvent_EventType == null)
				{
					r_WantsEvent_EventType = new(this, "WantsEvent", 0, typeof(UnityEngine.EventType));
					r_WantsEvent_EventType.SetBelong(this.instance);
				}
				return r_WantsEvent_EventType;
			}
		}

		/// <summary>
		/// Boolean WantsLayoutPass(UnityEngine.EventType)
		/// </summary>
		protected RMethod r_WantsLayoutPass_EventType;
		public virtual RMethod RWantsLayoutPass_EventType
		{
			get
			{
				if(r_WantsLayoutPass_EventType == null)
				{
					r_WantsLayoutPass_EventType = new(this, "WantsLayoutPass", 0, typeof(UnityEngine.EventType));
					r_WantsLayoutPass_EventType.SetBelong(this.instance);
				}
				return r_WantsLayoutPass_EventType;
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
