
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.ClickDetector
	/// </summary>
    public partial class RClickDetector : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.ClickDetector");
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


		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.ClickDetector+ButtonClickStatus] m_ClickStatus
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RClickDetector.RButtonClickStatus> r_Fm_ClickStatus;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RClickDetector.RButtonClickStatus> RFm_ClickStatus
		{
			get
			{
				if(r_Fm_ClickStatus == null)
				{
					r_Fm_ClickStatus = new(this, "m_ClickStatus");
				}
				return r_Fm_ClickStatus;
			}
		}

		/// <summary>
		/// System.Int32 <s_DoubleClickTime>k__BackingField
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__s_DoubleClickTime__1__k__BackingField;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__s_DoubleClickTime__1__k__BackingField
		{
			get
			{
				if(r_F__0__s_DoubleClickTime__1__k__BackingField == null)
				{
					r_F__0__s_DoubleClickTime__1__k__BackingField = new(Type, "<s_DoubleClickTime>k__BackingField");
				}
				return r_F__0__s_DoubleClickTime__1__k__BackingField;
			}
		}

		/// <summary>
		/// Int32 s_DoubleClickTime
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Ps_DoubleClickTime;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RPs_DoubleClickTime
		{
			get
			{
				if(r_Ps_DoubleClickTime == null)
				{
					r_Ps_DoubleClickTime = new(Type, "s_DoubleClickTime", -1);
				}
				return r_Ps_DoubleClickTime;
			}
		}

		/// <summary>
		/// Void StartClickTracking(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MStartClickTracking_EventBase;
		public virtual RMethod RMStartClickTracking_EventBase
		{
			get
			{
				if(r_MStartClickTracking_EventBase == null)
				{
					r_MStartClickTracking_EventBase = new(this, "StartClickTracking", 0, typeof(UnityEngine.UIElements.EventBase));
				}
				return r_MStartClickTracking_EventBase;
			}
		}

		/// <summary>
		/// Void SendClickEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MSendClickEvent_EventBase;
		public virtual RMethod RMSendClickEvent_EventBase
		{
			get
			{
				if(r_MSendClickEvent_EventBase == null)
				{
					r_MSendClickEvent_EventBase = new(this, "SendClickEvent", 0, typeof(UnityEngine.UIElements.EventBase));
				}
				return r_MSendClickEvent_EventBase;
			}
		}

		/// <summary>
		/// Void CancelClickTracking(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MCancelClickTracking_EventBase;
		public virtual RMethod RMCancelClickTracking_EventBase
		{
			get
			{
				if(r_MCancelClickTracking_EventBase == null)
				{
					r_MCancelClickTracking_EventBase = new(this, "CancelClickTracking", 0, typeof(UnityEngine.UIElements.EventBase));
				}
				return r_MCancelClickTracking_EventBase;
			}
		}

		/// <summary>
		/// Void ProcessEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MProcessEvent_EventBase;
		public virtual RMethod RMProcessEvent_EventBase
		{
			get
			{
				if(r_MProcessEvent_EventBase == null)
				{
					r_MProcessEvent_EventBase = new(this, "ProcessEvent", 0, typeof(UnityEngine.UIElements.EventBase));
				}
				return r_MProcessEvent_EventBase;
			}
		}

		/// <summary>
		/// Boolean ContainsPointer(UnityEngine.UIElements.VisualElement, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_MContainsPointer_VisualElement_Vector2;
		public static RMethod RMContainsPointer_VisualElement_Vector2
		{
			get
			{
				if(r_MContainsPointer_VisualElement_Vector2 == null)
				{
					r_MContainsPointer_VisualElement_Vector2 = new(Type, "ContainsPointer", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector2));
				}
				return r_MContainsPointer_VisualElement_Vector2;
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
				}
				return r_MToString;
			}
		}


        public virtual void StartClickTracking(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMStartClickTracking_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendClickEvent(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMSendClickEvent_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CancelClickTracking(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMCancelClickTracking_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessEvent(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMProcessEvent_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean ContainsPointer(UnityEngine.UIElements.VisualElement @element, UnityEngine.Vector2 @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @position};
            var ___result = RMContainsPointer_VisualElement_Vector2.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
