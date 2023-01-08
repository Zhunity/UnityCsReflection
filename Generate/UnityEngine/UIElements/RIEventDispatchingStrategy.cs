using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IEventDispatchingStrategy
	/// </summary>
    public partial class RIEventDispatchingStrategy : RMember //
    {

		/// <summary>
		/// Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_CanDispatchEvent_EventBase;
		public virtual RMethod RCanDispatchEvent_EventBase
		{
			get
			{
				if(r_CanDispatchEvent_EventBase == null)
				{
					r_CanDispatchEvent_EventBase = new(this, "CanDispatchEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_CanDispatchEvent_EventBase.SetBelong(this.instance);
				}
				return r_CanDispatchEvent_EventBase;
			}
		}

		/// <summary>
		/// Void DispatchEvent(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_DispatchEvent_EventBase_IPanel;
		public virtual RMethod RDispatchEvent_EventBase_IPanel
		{
			get
			{
				if(r_DispatchEvent_EventBase_IPanel == null)
				{
					r_DispatchEvent_EventBase_IPanel = new(this, "DispatchEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.IPanel));
					r_DispatchEvent_EventBase_IPanel.SetBelong(this.instance);
				}
				return r_DispatchEvent_EventBase_IPanel;
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

        public virtual System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RCanDispatchEvent_EventBase.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void DispatchEvent(UnityEngine.UIElements.EventBase  @evt, UnityEngine.UIElements.IPanel  @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @panel};
            var ___result = RDispatchEvent_EventBase_IPanel.Invoke(___genericsType, ___parameters);

            
        }


    }
}
