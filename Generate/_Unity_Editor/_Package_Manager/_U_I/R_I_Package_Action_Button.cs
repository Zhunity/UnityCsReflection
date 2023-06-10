
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.IPackageActionButton
	/// </summary>
    public partial class RIPackageActionButton : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.IPackageActionButton");
            }
        }

        public RIPackageActionButton() : base("UnityEditor.PackageManager.UI.IPackageActionButton")
        {
        }

        public RIPackageActionButton(System.Object instance) : base("UnityEditor.PackageManager.UI.IPackageActionButton")
		{
            SetInstance(instance);
		}

        public RIPackageActionButton(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIPackageActionButton(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


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
				}
				return r_Ptooltip;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.PackageSelectionArgs] action
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RPackageSelectionArgs> r_Paction;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RPackageSelectionArgs> RPaction
		{
			get
			{
				if(r_Paction == null)
				{
					r_Paction = new(this, "action", -1);
				}
				return r_Paction;
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
				}
				return r_MAddDropdownItem;
			}
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
