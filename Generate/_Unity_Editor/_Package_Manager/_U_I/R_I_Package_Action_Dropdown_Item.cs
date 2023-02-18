
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.IPackageActionDropdownItem
	/// </summary>
    public partial class RIPackageActionDropdownItem : RMember //
    {

		/// <summary>
		/// Boolean isChecked
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisChecked;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisChecked
		{
			get
			{
				if(r_PisChecked == null)
				{
					r_PisChecked = new(this, "isChecked", -1);
					r_PisChecked.SetBelong(this.GetValue());
				}
				return r_PisChecked;
			}
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
					r_Ptext.SetBelong(this.GetValue());
				}
				return r_Ptext;
			}
		}

		/// <summary>
		/// Boolean insertSeparatorBefore
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PinsertSeparatorBefore;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPinsertSeparatorBefore
		{
			get
			{
				if(r_PinsertSeparatorBefore == null)
				{
					r_PinsertSeparatorBefore = new(this, "insertSeparatorBefore", -1);
					r_PinsertSeparatorBefore.SetBelong(this.GetValue());
				}
				return r_PinsertSeparatorBefore;
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
					r_Paction.SetBelong(this.GetValue());
				}
				return r_Paction;
			}
		}


        public RIPackageActionDropdownItem() : base("UnityEditor.PackageManager.UI.IPackageActionDropdownItem")
        {
        }

        public RIPackageActionDropdownItem(System.Object instance) : base("UnityEditor.PackageManager.UI.IPackageActionDropdownItem")
		{
            SetInstance(instance);
		}

        public RIPackageActionDropdownItem(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIPackageActionDropdownItem(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

    }
}
