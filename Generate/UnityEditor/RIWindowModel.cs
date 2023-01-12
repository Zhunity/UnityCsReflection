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
		protected RUnityEngine.RVector2 r_Psize;
		public virtual RUnityEngine.RVector2 RPsize
		{
			get
			{
				if(r_Psize == null)
				{
					r_Psize = new(this, "size", -1);
					r_Psize.SetBelong(this.instance);
				}
				return r_Psize;
			}
		}

		/// <summary>
		/// UnityEngine.EventInterests eventInterests
		/// </summary>
		protected RUnityEngine.REventInterests r_PeventInterests;
		public virtual RUnityEngine.REventInterests RPeventInterests
		{
			get
			{
				if(r_PeventInterests == null)
				{
					r_PeventInterests = new(this, "eventInterests", -1);
					r_PeventInterests.SetBelong(this.instance);
				}
				return r_PeventInterests;
			}
		}

		/// <summary>
		/// System.Action onGUIHandler
		/// </summary>
		protected RSystem.RAction r_PonGUIHandler;
		public virtual RSystem.RAction RPonGUIHandler
		{
			get
			{
				if(r_PonGUIHandler == null)
				{
					r_PonGUIHandler = new(this, "onGUIHandler", -1);
					r_PonGUIHandler.SetBelong(this.instance);
				}
				return r_PonGUIHandler;
			}
		}

		/// <summary>
		/// UnityEditor.IWindowBackend windowBackend
		/// </summary>
		protected RUnityEditor.RIWindowBackend r_PwindowBackend;
		public virtual RUnityEditor.RIWindowBackend RPwindowBackend
		{
			get
			{
				if(r_PwindowBackend == null)
				{
					r_PwindowBackend = new(this, "windowBackend", -1);
					r_PwindowBackend.SetBelong(this.instance);
				}
				return r_PwindowBackend;
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
