
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.IPackageActionMenu
	/// </summary>
    public partial class RIPackageActionMenu : RMember //
    {

		/// <summary>
		/// System.String text
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ptext;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtext
		{
			get
			{
				if(r_Ptext == null)
				{
					r_Ptext = new(this, "text", -1);
					r_Ptext.SetBelong(this.GetValue());
				}
				return r_Ptext;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D icon
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture2D r_Picon;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture2D RPicon
		{
			get
			{
				if(r_Picon == null)
				{
					r_Picon = new(this, "icon", -1);
					r_Picon.SetBelong(this.GetValue());
				}
				return r_Picon;
			}
		}

		/// <summary>
		/// System.String tooltip
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ptooltip;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtooltip
		{
			get
			{
				if(r_Ptooltip == null)
				{
					r_Ptooltip = new(this, "tooltip", -1);
					r_Ptooltip.SetBelong(this.GetValue());
				}
				return r_Ptooltip;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.IPackageActionDropdownItem AddDropdownItem()
		/// </summary>
		protected RMethod r_MAddDropdownItem;
		public virtual RMethod RMAddDropdownItem
		{
			get
			{
				if(r_MAddDropdownItem == null)
				{
					r_MAddDropdownItem = new(this, "AddDropdownItem", 0);
					r_MAddDropdownItem.SetBelong(this.GetValue());
				}
				return r_MAddDropdownItem;
			}
		}


        public RIPackageActionMenu() : base("UnityEditor.PackageManager.UI.IPackageActionMenu")
        {
        }

        public RIPackageActionMenu(System.Object instance) : base("UnityEditor.PackageManager.UI.IPackageActionMenu")
		{
            SetInstance(instance);
		}

        public RIPackageActionMenu(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIPackageActionMenu(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackageActionDropdownItem AddDropdownItem()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAddDropdownItem.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackageActionDropdownItem(___result);
        }


    }
}
