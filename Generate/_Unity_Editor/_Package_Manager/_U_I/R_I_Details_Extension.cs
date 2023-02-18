
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.IDetailsExtension
	/// </summary>
    public partial class RIDetailsExtension : RMember //
    {

		/// <summary>
		/// Boolean expanded
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pexpanded;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPexpanded
		{
			get
			{
				if(r_Pexpanded == null)
				{
					r_Pexpanded = new(this, "expanded", -1);
					r_Pexpanded.SetBelong(this.GetValue());
				}
				return r_Pexpanded;
			}
		}

		/// <summary>
		/// System.String title
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ptitle;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtitle
		{
			get
			{
				if(r_Ptitle == null)
				{
					r_Ptitle = new(this, "title", -1);
					r_Ptitle.SetBelong(this.GetValue());
				}
				return r_Ptitle;
			}
		}

		/// <summary>
		/// Void Add(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MAdd_VisualElement;
		public virtual RMethod RMAdd_VisualElement
		{
			get
			{
				if(r_MAdd_VisualElement == null)
				{
					r_MAdd_VisualElement = new(this, "Add", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MAdd_VisualElement.SetBelong(this.GetValue());
				}
				return r_MAdd_VisualElement;
			}
		}


        public RIDetailsExtension() : base("UnityEditor.PackageManager.UI.IDetailsExtension")
        {
        }

        public RIDetailsExtension(System.Object instance) : base("UnityEditor.PackageManager.UI.IDetailsExtension")
		{
            SetInstance(instance);
		}

        public RIDetailsExtension(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIDetailsExtension(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Add(UnityEngine.UIElements.VisualElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RMAdd_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


    }
}
