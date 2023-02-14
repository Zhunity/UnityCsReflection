
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.ISelectableItem
	/// </summary>
    public partial class RISelectableItem : RMember //
    {

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackage package
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage r_Ppackage;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage RPpackage
		{
			get
			{
				if(r_Ppackage == null)
				{
					r_Ppackage = new(this, "package", -1);
					r_Ppackage.SetBelong(this.instance);
				}
				return r_Ppackage;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion targetVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion r_PtargetVersion;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion RPtargetVersion
		{
			get
			{
				if(r_PtargetVersion == null)
				{
					r_PtargetVersion = new(this, "targetVersion", -1);
					r_PtargetVersion.SetBelong(this.instance);
				}
				return r_PtargetVersion;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement element
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Pelement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPelement
		{
			get
			{
				if(r_Pelement == null)
				{
					r_Pelement = new(this, "element", -1);
					r_Pelement.SetBelong(this.instance);
				}
				return r_Pelement;
			}
		}


        public RISelectableItem() : base("UnityEditor.PackageManager.UI.Internal.ISelectableItem")
        {
        }

        public RISelectableItem(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.ISelectableItem")
		{
            SetInstance(instance);
		}

        public RISelectableItem(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RISelectableItem(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

    }
}
