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
		protected RMethod r_Disconnect;
		public virtual RMethod RDisconnect
		{
			get
			{
				if(r_Disconnect == null)
				{
					r_Disconnect = new(this, "Disconnect", 0);
					r_Disconnect.SetBelong(this.instance);
				}
				return r_Disconnect;
			}
		}

		/// <summary>
		/// Void Refresh()
		/// </summary>
		protected RMethod r_Refresh;
		public virtual RMethod RRefresh
		{
			get
			{
				if(r_Refresh == null)
				{
					r_Refresh = new(this, "Refresh", 0);
					r_Refresh.SetBelong(this.instance);
				}
				return r_Refresh;
			}
		}

		/// <summary>
		/// Void OnVersionChanged(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.VersionChangeType)
		/// </summary>
		protected RMethod r_OnVersionChanged_VisualElement_VersionChangeType;
		public virtual RMethod ROnVersionChanged_VisualElement_VersionChangeType
		{
			get
			{
				if(r_OnVersionChanged_VisualElement_VersionChangeType == null)
				{
					r_OnVersionChanged_VisualElement_VersionChangeType = new(this, "OnVersionChanged", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.VersionChangeType"));
					r_OnVersionChanged_VisualElement_VersionChangeType.SetBelong(this.instance);
				}
				return r_OnVersionChanged_VisualElement_VersionChangeType;
			}
		}

		/// <summary>
		/// Boolean InterceptEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_InterceptEvent_EventBase;
		public virtual RMethod RInterceptEvent_EventBase
		{
			get
			{
				if(r_InterceptEvent_EventBase == null)
				{
					r_InterceptEvent_EventBase = new(this, "InterceptEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_InterceptEvent_EventBase.SetBelong(this.instance);
				}
				return r_InterceptEvent_EventBase;
			}
		}

		/// <summary>
		/// Void PostProcessEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_PostProcessEvent_EventBase;
		public virtual RMethod RPostProcessEvent_EventBase
		{
			get
			{
				if(r_PostProcessEvent_EventBase == null)
				{
					r_PostProcessEvent_EventBase = new(this, "PostProcessEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_PostProcessEvent_EventBase.SetBelong(this.instance);
				}
				return r_PostProcessEvent_EventBase;
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


        public virtual void OnVersionChanged(UnityEngine.UIElements.VisualElement @ele, RType @changeTypeFlag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ele, @changeTypeFlag.Value};
            var ___result = ROnVersionChanged_VisualElement_VersionChangeType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean InterceptEvent(UnityEngine.UIElements.EventBase @ev)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ev};
            var ___result = RInterceptEvent_EventBase.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void PostProcessEvent(UnityEngine.UIElements.EventBase @ev)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ev};
            var ___result = RPostProcessEvent_EventBase.Invoke(___genericsType, ___parameters);

            
        }


    }
}
