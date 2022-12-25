using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IVisualTreeEditorUpdater
	/// </summary>
    public partial class RIVisualTreeEditorUpdater : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.IVisualTreeUpdater GetUpdater(UnityEngine.UIElements.VisualTreeEditorUpdatePhase)
		/// </summary>
		protected RMethod r_RGetUpdater_VisualTreeEditorUpdatePhase;
		public virtual RMethod RGetUpdater_VisualTreeEditorUpdatePhase
		{
			get
			{
				if(r_RGetUpdater_VisualTreeEditorUpdatePhase == null)
				{
					r_RGetUpdater_VisualTreeEditorUpdatePhase = new(this, "GetUpdater", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.VisualTreeEditorUpdatePhase"));
					r_RGetUpdater_VisualTreeEditorUpdatePhase.SetBelong(this.instance);
				}
				return r_RGetUpdater_VisualTreeEditorUpdatePhase;
			}
		}

		/// <summary>
		/// Void SetUpdater(UnityEngine.UIElements.IVisualTreeUpdater, UnityEngine.UIElements.VisualTreeEditorUpdatePhase)
		/// </summary>
		protected RMethod r_RSetUpdater_IVisualTreeUpdater_VisualTreeEditorUpdatePhase;
		public virtual RMethod RSetUpdater_IVisualTreeUpdater_VisualTreeEditorUpdatePhase
		{
			get
			{
				if(r_RSetUpdater_IVisualTreeUpdater_VisualTreeEditorUpdatePhase == null)
				{
					r_RSetUpdater_IVisualTreeUpdater_VisualTreeEditorUpdatePhase = new(this, "SetUpdater", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.IVisualTreeUpdater"),  ReleactionUtils.GetType("UnityEngine.UIElements.VisualTreeEditorUpdatePhase"));
					r_RSetUpdater_IVisualTreeUpdater_VisualTreeEditorUpdatePhase.SetBelong(this.instance);
				}
				return r_RSetUpdater_IVisualTreeUpdater_VisualTreeEditorUpdatePhase;
			}
		}

		/// <summary>
		/// Void Update()
		/// </summary>
		protected RMethod r_RUpdate;
		public virtual RMethod RUpdate
		{
			get
			{
				if(r_RUpdate == null)
				{
					r_RUpdate = new(this, "Update", 0);
					r_RUpdate.SetBelong(this.instance);
				}
				return r_RUpdate;
			}
		}

		/// <summary>
		/// Void UpdateVisualTreePhase(UnityEngine.UIElements.VisualTreeEditorUpdatePhase)
		/// </summary>
		protected RMethod r_RUpdateVisualTreePhase_VisualTreeEditorUpdatePhase;
		public virtual RMethod RUpdateVisualTreePhase_VisualTreeEditorUpdatePhase
		{
			get
			{
				if(r_RUpdateVisualTreePhase_VisualTreeEditorUpdatePhase == null)
				{
					r_RUpdateVisualTreePhase_VisualTreeEditorUpdatePhase = new(this, "UpdateVisualTreePhase", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.VisualTreeEditorUpdatePhase"));
					r_RUpdateVisualTreePhase_VisualTreeEditorUpdatePhase.SetBelong(this.instance);
				}
				return r_RUpdateVisualTreePhase_VisualTreeEditorUpdatePhase;
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


        public RIVisualTreeEditorUpdater() : base("UnityEngine.UIElements.IVisualTreeEditorUpdater")
        {
        }

        public RIVisualTreeEditorUpdater(System.Object instance) : base("UnityEngine.UIElements.IVisualTreeEditorUpdater")
		{
            SetInstance(instance);
		}

        public RIVisualTreeEditorUpdater(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIVisualTreeEditorUpdater(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
