
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IGlobalPanelDebugger
	/// </summary>
    public partial class RIGlobalPanelDebugger : RMember //
    {

		/// <summary>
		/// Boolean InterceptMouseEvent(UnityEngine.UIElements.IPanel, UnityEngine.UIElements.IMouseEvent)
		/// </summary>
		protected RMethod r_MInterceptMouseEvent_IPanel_IMouseEvent;
		public virtual RMethod RMInterceptMouseEvent_IPanel_IMouseEvent
		{
			get
			{
				if(r_MInterceptMouseEvent_IPanel_IMouseEvent == null)
				{
					r_MInterceptMouseEvent_IPanel_IMouseEvent = new(this, "InterceptMouseEvent", 0, typeof(UnityEngine.UIElements.IPanel), typeof(UnityEngine.UIElements.IMouseEvent));
				}
				return r_MInterceptMouseEvent_IPanel_IMouseEvent;
			}
		}

		/// <summary>
		/// Void OnContextClick(UnityEngine.UIElements.IPanel, UnityEngine.UIElements.ContextClickEvent)
		/// </summary>
		protected RMethod r_MOnContextClick_IPanel_ContextClickEvent;
		public virtual RMethod RMOnContextClick_IPanel_ContextClickEvent
		{
			get
			{
				if(r_MOnContextClick_IPanel_ContextClickEvent == null)
				{
					r_MOnContextClick_IPanel_ContextClickEvent = new(this, "OnContextClick", 0, typeof(UnityEngine.UIElements.IPanel), typeof(UnityEngine.UIElements.ContextClickEvent));
				}
				return r_MOnContextClick_IPanel_ContextClickEvent;
			}
		}


        public RIGlobalPanelDebugger() : base("UnityEngine.UIElements.IGlobalPanelDebugger")
        {
        }

        public RIGlobalPanelDebugger(System.Object instance) : base("UnityEngine.UIElements.IGlobalPanelDebugger")
		{
            SetInstance(instance);
		}

        public RIGlobalPanelDebugger(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIGlobalPanelDebugger(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean InterceptMouseEvent(UnityEngine.UIElements.IPanel @panel, UnityEngine.UIElements.IMouseEvent @ev)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel, @ev};
            var ___result = RMInterceptMouseEvent_IPanel_IMouseEvent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnContextClick(UnityEngine.UIElements.IPanel @panel, UnityEngine.UIElements.ContextClickEvent @ev)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel, @ev};
            var ___result = RMOnContextClick_IPanel_ContextClickEvent.Invoke(___genericsType, ___parameters);

            
        }


    }
}
