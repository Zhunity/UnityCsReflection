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
		protected RMethod r_GetUpdater_VisualTreeEditorUpdatePhase;
		public virtual RMethod RGetUpdater_VisualTreeEditorUpdatePhase
		{
			get
			{
				if(r_GetUpdater_VisualTreeEditorUpdatePhase == null)
				{
					r_GetUpdater_VisualTreeEditorUpdatePhase = new(this, "GetUpdater", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeEditorUpdatePhase"));
					r_GetUpdater_VisualTreeEditorUpdatePhase.SetBelong(this.instance);
				}
				return r_GetUpdater_VisualTreeEditorUpdatePhase;
			}
		}

		/// <summary>
		/// Void SetUpdater(UnityEngine.UIElements.IVisualTreeUpdater, UnityEngine.UIElements.VisualTreeEditorUpdatePhase)
		/// </summary>
		protected RMethod r_SetUpdater_IVisualTreeUpdater_VisualTreeEditorUpdatePhase;
		public virtual RMethod RSetUpdater_IVisualTreeUpdater_VisualTreeEditorUpdatePhase
		{
			get
			{
				if(r_SetUpdater_IVisualTreeUpdater_VisualTreeEditorUpdatePhase == null)
				{
					r_SetUpdater_IVisualTreeUpdater_VisualTreeEditorUpdatePhase = new(this, "SetUpdater", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.IVisualTreeUpdater"),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeEditorUpdatePhase"));
					r_SetUpdater_IVisualTreeUpdater_VisualTreeEditorUpdatePhase.SetBelong(this.instance);
				}
				return r_SetUpdater_IVisualTreeUpdater_VisualTreeEditorUpdatePhase;
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
		/// Void UpdateVisualTreePhase(UnityEngine.UIElements.VisualTreeEditorUpdatePhase)
		/// </summary>
		protected RMethod r_UpdateVisualTreePhase_VisualTreeEditorUpdatePhase;
		public virtual RMethod RUpdateVisualTreePhase_VisualTreeEditorUpdatePhase
		{
			get
			{
				if(r_UpdateVisualTreePhase_VisualTreeEditorUpdatePhase == null)
				{
					r_UpdateVisualTreePhase_VisualTreeEditorUpdatePhase = new(this, "UpdateVisualTreePhase", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeEditorUpdatePhase"));
					r_UpdateVisualTreePhase_VisualTreeEditorUpdatePhase.SetBelong(this.instance);
				}
				return r_UpdateVisualTreePhase_VisualTreeEditorUpdatePhase;
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

        public virtual RUnityEngine.RUIElements.RIVisualTreeUpdater GetUpdater(RType @phase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@phase.Value};
            var ___result = RGetUpdater_VisualTreeEditorUpdatePhase.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RIVisualTreeUpdater(___result);
        }


        public virtual void SetUpdater(RUnityEngine.RUIElements.RIVisualTreeUpdater @updater, RType @phase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@updater.Value, @phase.Value};
            var ___result = RSetUpdater_IVisualTreeUpdater_VisualTreeEditorUpdatePhase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateVisualTreePhase(RType @phase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@phase.Value};
            var ___result = RUpdateVisualTreePhase_VisualTreeEditorUpdatePhase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnVersionChanged(UnityEngine.UIElements.VisualElement @ve, RType @versionChangeType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @versionChangeType.Value};
            var ___result = ROnVersionChanged_VisualElement_VersionChangeType.Invoke(___genericsType, ___parameters);

            
        }


    }
}
