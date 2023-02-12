
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
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVisualElementPanel r_Ppanel;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVisualElementPanel RPpanel
		{
			get
			{
				if(r_Ppanel == null)
				{
					r_Ppanel = new(this, "panel", -1);
					r_Ppanel.SetBelong(this.instance);
				}
				return r_Ppanel;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker profilerMarker
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_PprofilerMarker;
		public virtual SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RPprofilerMarker
		{
			get
			{
				if(r_PprofilerMarker == null)
				{
					r_PprofilerMarker = new(this, "profilerMarker", -1);
					r_PprofilerMarker.SetBelong(this.instance);
				}
				return r_PprofilerMarker;
			}
		}

		/// <summary>
		/// Void Update()
		/// </summary>
		protected RMethod r_MUpdate;
		public virtual RMethod RMUpdate
		{
			get
			{
				if(r_MUpdate == null)
				{
					r_MUpdate = new(this, "Update", 0);
					r_MUpdate.SetBelong(this.instance);
				}
				return r_MUpdate;
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
					r_MOnVersionChanged_VisualElement_VersionChangeType.SetBelong(this.instance);
				}
				return r_MOnVersionChanged_VisualElement_VersionChangeType;
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
            var ___result = RMUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnVersionChanged(UnityEngine.UIElements.VisualElement @ve, SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType @versionChangeType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @versionChangeType.Value};
            var ___result = RMOnVersionChanged_VisualElement_VersionChangeType.Invoke(___genericsType, ___parameters);

            
        }


    }
}