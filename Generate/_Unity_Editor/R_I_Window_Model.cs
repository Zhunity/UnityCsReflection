
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.IWindowModel
	/// </summary>
    public partial class RIWindowModel : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.IWindowModel");
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


		/// <summary>
		/// UnityEngine.Vector2 size
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Psize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPsize
		{
			get
			{
				if(r_Psize == null)
				{
					r_Psize = new(this, "size", -1);
				}
				return r_Psize;
			}
		}

		/// <summary>
		/// UnityEngine.EventInterests eventInterests
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.REventInterests r_PeventInterests;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.REventInterests RPeventInterests
		{
			get
			{
				if(r_PeventInterests == null)
				{
					r_PeventInterests = new(this, "eventInterests", -1);
				}
				return r_PeventInterests;
			}
		}

		/// <summary>
		/// System.Action onGUIHandler
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_PonGUIHandler;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RPonGUIHandler
		{
			get
			{
				if(r_PonGUIHandler == null)
				{
					r_PonGUIHandler = new(this, "onGUIHandler", -1);
				}
				return r_PonGUIHandler;
			}
		}

		/// <summary>
		/// UnityEditor.IWindowBackend windowBackend
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIWindowBackend r_PwindowBackend;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIWindowBackend RPwindowBackend
		{
			get
			{
				if(r_PwindowBackend == null)
				{
					r_PwindowBackend = new(this, "windowBackend", -1);
				}
				return r_PwindowBackend;
			}
		}


    }
}
