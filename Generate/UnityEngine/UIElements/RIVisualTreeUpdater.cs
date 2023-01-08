using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IVisualTreeUpdater
	/// </summary>
    public partial class RIVisualTreeUpdater : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.BaseVisualElementPanel panel
		/// </summary>
		protected RUnityEngine.RUIElements.RBaseVisualElementPanel r_panel;
		public virtual RUnityEngine.RUIElements.RBaseVisualElementPanel Rpanel
		{
			get
			{
				if(r_panel == null)
				{
					r_panel = new(this, "panel", -1);
					r_panel.SetBelong(this.instance);
				}
				return r_panel;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker profilerMarker
		/// </summary>
		protected RUnity.RProfiling.RProfilerMarker r_profilerMarker;
		public virtual RUnity.RProfiling.RProfilerMarker RprofilerMarker
		{
			get
			{
				if(r_profilerMarker == null)
				{
					r_profilerMarker = new(this, "profilerMarker", -1);
					r_profilerMarker.SetBelong(this.instance);
				}
				return r_profilerMarker;
			}
		}

		/// <summary>
		/// Void Update()
		/// </summary>
		protected RMethod r_Update;
		public virtual RMethod RUpdate
		{
			get
			{
				if(r_Update == null)
				{
					r_Update = new(this, "Update", 0);
					r_Update.SetBelong(this.instance);
				}
				return r_Update;
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


        public RIVisualTreeUpdater() : base("UnityEngine.UIElements.IVisualTreeUpdater")
        {
        }

        public RIVisualTreeUpdater(System.Object instance) : base("UnityEngine.UIElements.IVisualTreeUpdater")
		{
            SetInstance(instance);
		}

        public RIVisualTreeUpdater(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIVisualTreeUpdater(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
        }



    }
}
