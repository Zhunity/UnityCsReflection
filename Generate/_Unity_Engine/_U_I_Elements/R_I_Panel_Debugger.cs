
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IPanelDebugger
	/// </summary>
    public partial class RIPanelDebugger : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.IPanelDebug panelDebug
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanelDebug r_PpanelDebug;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanelDebug RPpanelDebug
		{
			get
			{
				if(r_PpanelDebug == null)
				{
					r_PpanelDebug = new(this, "panelDebug", -1);
				}
				return r_PpanelDebug;
			}
		}

		/// <summary>
		/// Void Disconnect()
		/// </summary>
		protected RMethod r_MDisconnect;
		public virtual RMethod RMDisconnect
		{
			get
			{
				if(r_MDisconnect == null)
				{
					r_MDisconnect = new(this, "Disconnect", 0);
				}
				return r_MDisconnect;
			}
		}

		/// <summary>
		/// Void Refresh()
		/// </summary>
		protected RMethod r_MRefresh;
		public virtual RMethod RMRefresh
		{
			get
			{
				if(r_MRefresh == null)
				{
					r_MRefresh = new(this, "Refresh", 0);
				}
				return r_MRefresh;
			}
		}

		/// <summary>
		/// Void OnVersionChanged(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.VersionChangeType)
		/// </summary>
		protected RMethod r_MOnVersionChanged_VisualElement_VersionChangeType;
		public virtual RMethod RMOnVersionChanged_VisualElement_VersionChangeType
		{
			get
			{
				if(r_MOnVersionChanged_VisualElement_VersionChangeType == null)
				{
					r_MOnVersionChanged_VisualElement_VersionChangeType = new(this, "OnVersionChanged", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.VersionChangeType"));
				}
				return r_MOnVersionChanged_VisualElement_VersionChangeType;
			}
		}

		/// <summary>
		/// Boolean InterceptEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MInterceptEvent_EventBase;
		public virtual RMethod RMInterceptEvent_EventBase
		{
			get
			{
				if(r_MInterceptEvent_EventBase == null)
				{
					r_MInterceptEvent_EventBase = new(this, "InterceptEvent", 0, typeof(UnityEngine.UIElements.EventBase));
				}
				return r_MInterceptEvent_EventBase;
			}
		}

		/// <summary>
		/// Void PostProcessEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MPostProcessEvent_EventBase;
		public virtual RMethod RMPostProcessEvent_EventBase
		{
			get
			{
				if(r_MPostProcessEvent_EventBase == null)
				{
					r_MPostProcessEvent_EventBase = new(this, "PostProcessEvent", 0, typeof(UnityEngine.UIElements.EventBase));
				}
				return r_MPostProcessEvent_EventBase;
			}
		}


        public RIPanelDebugger() : base("UnityEngine.UIElements.IPanelDebugger")
        {
        }

        public RIPanelDebugger(System.Object instance) : base("UnityEngine.UIElements.IPanelDebugger")
		{
            SetInstance(instance);
		}

        public RIPanelDebugger(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIPanelDebugger(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Disconnect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDisconnect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Refresh()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefresh.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnVersionChanged(UnityEngine.UIElements.VisualElement @ele, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType @changeTypeFlag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ele, @changeTypeFlag.Value};
            var ___result = RMOnVersionChanged_VisualElement_VersionChangeType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean InterceptEvent(UnityEngine.UIElements.EventBase @ev)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ev};
            var ___result = RMInterceptEvent_EventBase.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void PostProcessEvent(UnityEngine.UIElements.EventBase @ev)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ev};
            var ___result = RMPostProcessEvent_EventBase.Invoke(___genericsType, ___parameters);

            
        }


    }
}
