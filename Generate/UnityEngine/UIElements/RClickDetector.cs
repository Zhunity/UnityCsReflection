using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ClickDetector
	/// </summary>
    public partial class RClickDetector : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.ClickDetector+ButtonClickStatus] m_ClickStatus
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RClickDetector.RButtonClickStatus> r_m_ClickStatus;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RClickDetector.RButtonClickStatus> Rm_ClickStatus
		{
			get
			{
				if(r_m_ClickStatus == null)
				{
					r_m_ClickStatus = new(this, "m_ClickStatus");
					r_m_ClickStatus.SetBelong(this.instance);
				}
				return r_m_ClickStatus;
			}
		}

		/// <summary>
		/// System.Int32 <s_DoubleClickTime>k__BackingField
		/// </summary>
		protected static RField r___1__s_DoubleClickTime__2__k__BackingField;
		public static RField R__1__s_DoubleClickTime__2__k__BackingField
		{
			get
			{
				if(r___1__s_DoubleClickTime__2__k__BackingField == null)
				{
					r___1__s_DoubleClickTime__2__k__BackingField = new( ReleactionUtils.GetType("UnityEngine.UIElements.ClickDetector"), "<s_DoubleClickTime>k__BackingField");
					r___1__s_DoubleClickTime__2__k__BackingField.SetBelong(null);
				}
				return r___1__s_DoubleClickTime__2__k__BackingField;
			}
		}

		/// <summary>
		/// Int32 s_DoubleClickTime
		/// </summary>
		protected static RProperty r_s_DoubleClickTime;
		public static RProperty Rs_DoubleClickTime
		{
			get
			{
				if(r_s_DoubleClickTime == null)
				{
					r_s_DoubleClickTime = new( ReleactionUtils.GetType("UnityEngine.UIElements.ClickDetector"), "s_DoubleClickTime", -1);
					r_s_DoubleClickTime.SetBelong(null);
				}
				return r_s_DoubleClickTime;
			}
		}

		/// <summary>
		/// Void StartClickTracking(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RStartClickTracking_EventBase;
		public virtual RMethod RStartClickTracking_EventBase
		{
			get
			{
				if(r_RStartClickTracking_EventBase == null)
				{
					r_RStartClickTracking_EventBase = new(this, "StartClickTracking", 0, typeof(UnityEngine.UIElements.EventBase));
					r_RStartClickTracking_EventBase.SetBelong(this.instance);
				}
				return r_RStartClickTracking_EventBase;
			}
		}

		/// <summary>
		/// Void SendClickEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RSendClickEvent_EventBase;
		public virtual RMethod RSendClickEvent_EventBase
		{
			get
			{
				if(r_RSendClickEvent_EventBase == null)
				{
					r_RSendClickEvent_EventBase = new(this, "SendClickEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_RSendClickEvent_EventBase.SetBelong(this.instance);
				}
				return r_RSendClickEvent_EventBase;
			}
		}

		/// <summary>
		/// Void CancelClickTracking(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RCancelClickTracking_EventBase;
		public virtual RMethod RCancelClickTracking_EventBase
		{
			get
			{
				if(r_RCancelClickTracking_EventBase == null)
				{
					r_RCancelClickTracking_EventBase = new(this, "CancelClickTracking", 0, typeof(UnityEngine.UIElements.EventBase));
					r_RCancelClickTracking_EventBase.SetBelong(this.instance);
				}
				return r_RCancelClickTracking_EventBase;
			}
		}

		/// <summary>
		/// Void ProcessEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RProcessEvent_EventBase;
		public virtual RMethod RProcessEvent_EventBase
		{
			get
			{
				if(r_RProcessEvent_EventBase == null)
				{
					r_RProcessEvent_EventBase = new(this, "ProcessEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_RProcessEvent_EventBase.SetBelong(this.instance);
				}
				return r_RProcessEvent_EventBase;
			}
		}

		/// <summary>
		/// Boolean ContainsPointer(UnityEngine.UIElements.VisualElement, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_RContainsPointer_VisualElement_Vector2;
		public static RMethod RContainsPointer_VisualElement_Vector2
		{
			get
			{
				if(r_RContainsPointer_VisualElement_Vector2 == null)
				{
					r_RContainsPointer_VisualElement_Vector2 = new( ReleactionUtils.GetType("UnityEngine.UIElements.ClickDetector"), "ContainsPointer", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector2));
					r_RContainsPointer_VisualElement_Vector2.SetBelong(null);
				}
				return r_RContainsPointer_VisualElement_Vector2;
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


        public RClickDetector() : base("UnityEngine.UIElements.ClickDetector")
        {
        }

        public RClickDetector(System.Object instance) : base("UnityEngine.UIElements.ClickDetector")
		{
            SetInstance(instance);
		}

        public RClickDetector(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RClickDetector(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void StartClickTracking(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RStartClickTracking_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendClickEvent(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RSendClickEvent_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CancelClickTracking(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RCancelClickTracking_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessEvent(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RProcessEvent_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean ContainsPointer(UnityEngine.UIElements.VisualElement  @element, UnityEngine.Vector2  @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @position};
            var ___result = RContainsPointer_VisualElement_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
