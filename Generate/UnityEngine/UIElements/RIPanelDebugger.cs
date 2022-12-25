using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IPanelDebugger
	/// </summary>
    public partial class RIPanelDebugger : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.IPanelDebug panelDebug
		/// </summary>
		protected RUnityEngine.RUIElements.RIPanelDebug r_panelDebug;
		public virtual RUnityEngine.RUIElements.RIPanelDebug RpanelDebug
		{
			get
			{
				if(r_panelDebug == null)
				{
					r_panelDebug = new(this, "panelDebug", -1);
					r_panelDebug.SetBelong(this.instance);
				}
				return r_panelDebug;
			}
		}

		/// <summary>
		/// Void Disconnect()
		/// </summary>
		protected RMethod r_RDisconnect;
		public virtual RMethod RDisconnect
		{
			get
			{
				if(r_RDisconnect == null)
				{
					r_RDisconnect = new(this, "Disconnect", 0);
					r_RDisconnect.SetBelong(this.instance);
				}
				return r_RDisconnect;
			}
		}

		/// <summary>
		/// Void Refresh()
		/// </summary>
		protected RMethod r_RRefresh;
		public virtual RMethod RRefresh
		{
			get
			{
				if(r_RRefresh == null)
				{
					r_RRefresh = new(this, "Refresh", 0);
					r_RRefresh.SetBelong(this.instance);
				}
				return r_RRefresh;
			}
		}

		/// <summary>
		/// Void OnVersionChanged(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.VersionChangeType)
		/// </summary>
		protected RMethod r_ROnVersionChanged_VisualElement_VersionChangeType;
		public virtual RMethod ROnVersionChanged_VisualElement_VersionChangeType
		{
			get
			{
				if(r_ROnVersionChanged_VisualElement_VersionChangeType == null)
				{
					r_ROnVersionChanged_VisualElement_VersionChangeType = new(this, "OnVersionChanged", 0, typeof(UnityEngine.UIElements.VisualElement),  ReleactionUtils.GetType("UnityEngine.UIElements.VersionChangeType"));
					r_ROnVersionChanged_VisualElement_VersionChangeType.SetBelong(this.instance);
				}
				return r_ROnVersionChanged_VisualElement_VersionChangeType;
			}
		}

		/// <summary>
		/// Boolean InterceptEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RInterceptEvent_EventBase;
		public virtual RMethod RInterceptEvent_EventBase
		{
			get
			{
				if(r_RInterceptEvent_EventBase == null)
				{
					r_RInterceptEvent_EventBase = new(this, "InterceptEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_RInterceptEvent_EventBase.SetBelong(this.instance);
				}
				return r_RInterceptEvent_EventBase;
			}
		}

		/// <summary>
		/// Void PostProcessEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RPostProcessEvent_EventBase;
		public virtual RMethod RPostProcessEvent_EventBase
		{
			get
			{
				if(r_RPostProcessEvent_EventBase == null)
				{
					r_RPostProcessEvent_EventBase = new(this, "PostProcessEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_RPostProcessEvent_EventBase.SetBelong(this.instance);
				}
				return r_RPostProcessEvent_EventBase;
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
            var ___result = RDisconnect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Refresh()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRefresh.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Boolean InterceptEvent(UnityEngine.UIElements.EventBase  @ev)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ev};
            var ___result = RInterceptEvent_EventBase.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void PostProcessEvent(UnityEngine.UIElements.EventBase  @ev)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ev};
            var ___result = RPostProcessEvent_EventBase.Invoke(___genericsType, ___parameters);

            
        }


    }
}
