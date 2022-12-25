using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.IWindowModel
	/// </summary>
    public partial class RIWindowModel : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector2 size
		/// </summary>
		protected RUnityEngine.RVector2 r_size;
		public virtual RUnityEngine.RVector2 Rsize
		{
			get
			{
				if(r_size == null)
				{
					r_size = new(this, "size", -1);
					r_size.SetBelong(this.instance);
				}
				return r_size;
			}
		}

		/// <summary>
		/// UnityEngine.EventInterests eventInterests
		/// </summary>
		protected RUnityEngine.REventInterests r_eventInterests;
		public virtual RUnityEngine.REventInterests ReventInterests
		{
			get
			{
				if(r_eventInterests == null)
				{
					r_eventInterests = new(this, "eventInterests", -1);
					r_eventInterests.SetBelong(this.instance);
				}
				return r_eventInterests;
			}
		}

		/// <summary>
		/// System.Action onGUIHandler
		/// </summary>
		protected RSystem.RAction r_onGUIHandler;
		public virtual RSystem.RAction RonGUIHandler
		{
			get
			{
				if(r_onGUIHandler == null)
				{
					r_onGUIHandler = new(this, "onGUIHandler", -1);
					r_onGUIHandler.SetBelong(this.instance);
				}
				return r_onGUIHandler;
			}
		}

		/// <summary>
		/// UnityEditor.IWindowBackend windowBackend
		/// </summary>
		protected RUnityEditor.RIWindowBackend r_windowBackend;
		public virtual RUnityEditor.RIWindowBackend RwindowBackend
		{
			get
			{
				if(r_windowBackend == null)
				{
					r_windowBackend = new(this, "windowBackend", -1);
					r_windowBackend.SetBelong(this.instance);
				}
				return r_windowBackend;
			}
		}


        public RIWindowModel() : base("UnityEditor.IWindowModel")
        {
        }

        public RIWindowModel(System.Object instance) : base("UnityEditor.IWindowModel")
		{
            SetInstance(instance);
		}

        public RIWindowModel(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIWindowModel(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

    }
}
