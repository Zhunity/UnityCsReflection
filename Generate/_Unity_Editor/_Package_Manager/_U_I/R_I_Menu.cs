
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.IMenu
	/// </summary>
    public partial class RIMenu : RMember //
    {

		/// <summary>
		/// UnityEditor.PackageManager.UI.IMenuDropdownItem AddDropdownItem()
		/// </summary>
		protected RMethod r_MAddDropdownItem;
		public virtual RMethod RMAddDropdownItem
		{
			get
			{
				if(r_MAddDropdownItem == null)
				{
					r_MAddDropdownItem = new(this, "AddDropdownItem", 0);
					r_MAddDropdownItem.SetBelong(this.instance);
				}
				return r_MAddDropdownItem;
			}
		}

		/// <summary>
		/// Void ShowInputDropdown(UnityEditor.PackageManager.UI.InputDropdownArgs)
		/// </summary>
		protected RMethod r_MShowInputDropdown_InputDropdownArgs;
		public virtual RMethod RMShowInputDropdown_InputDropdownArgs
		{
			get
			{
				if(r_MShowInputDropdown_InputDropdownArgs == null)
				{
					r_MShowInputDropdown_InputDropdownArgs = new(this, "ShowInputDropdown", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.InputDropdownArgs"));
					r_MShowInputDropdown_InputDropdownArgs.SetBelong(this.instance);
				}
				return r_MShowInputDropdown_InputDropdownArgs;
			}
		}


        public RIMenu() : base("UnityEditor.PackageManager.UI.IMenu")
        {
        }

        public RIMenu(System.Object instance) : base("UnityEditor.PackageManager.UI.IMenu")
		{
            SetInstance(instance);
		}

        public RIMenu(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIMenu(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIMenuDropdownItem AddDropdownItem()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAddDropdownItem.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIMenuDropdownItem(___result);
        }


        public virtual void ShowInputDropdown(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInputDropdownArgs @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args.Value};
            var ___result = RMShowInputDropdown_InputDropdownArgs.Invoke(___genericsType, ___parameters);

            
        }


    }
}
