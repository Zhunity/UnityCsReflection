
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.UIElements.IEventDispatchingStrategy
	/// </summary>
    public partial class RIEventDispatchingStrategy : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.IEventDispatchingStrategy");
            }
        }

        public RIEventDispatchingStrategy() : base("UnityEngine.UIElements.IEventDispatchingStrategy")
        {
        }

        public RIEventDispatchingStrategy(System.Object instance) : base("UnityEngine.UIElements.IEventDispatchingStrategy")
		{
            SetInstance(instance);
		}

        public RIEventDispatchingStrategy(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIEventDispatchingStrategy(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MCanDispatchEvent_EventBase;
		public virtual RMethod RMCanDispatchEvent_EventBase
		{
			get
			{
				if(r_MCanDispatchEvent_EventBase == null)
				{
					r_MCanDispatchEvent_EventBase = new(this, "CanDispatchEvent", 0, typeof(UnityEngine.UIElements.EventBase));
				}
				return r_MCanDispatchEvent_EventBase;
			}
		}

		/// <summary>
		/// Void DispatchEvent(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_MDispatchEvent_EventBase_IPanel;
		public virtual RMethod RMDispatchEvent_EventBase_IPanel
		{
			get
			{
				if(r_MDispatchEvent_EventBase_IPanel == null)
				{
					r_MDispatchEvent_EventBase_IPanel = new(this, "DispatchEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.IPanel));
				}
				return r_MDispatchEvent_EventBase_IPanel;
			}
		}


        public virtual System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMCanDispatchEvent_EventBase.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void DispatchEvent(UnityEngine.UIElements.EventBase @evt, UnityEngine.UIElements.IPanel @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @panel};
            var ___result = RMDispatchEvent_EventBase_IPanel.Invoke(___genericsType, ___parameters);

            
        }


    }
}
