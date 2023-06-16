
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEditor.PackageManager.UI.IMenuDropdownItem
	/// </summary>
    public partial class RIMenuDropdownItem : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.IMenuDropdownItem");
            }
        }

        public RIMenuDropdownItem() : base("UnityEditor.PackageManager.UI.IMenuDropdownItem")
        {
        }

        public RIMenuDropdownItem(System.Object instance) : base("UnityEditor.PackageManager.UI.IMenuDropdownItem")
		{
            SetInstance(instance);
		}

        public RIMenuDropdownItem(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIMenuDropdownItem(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


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
				}
				return r_PinsertSeparatorBefore;
			}
		}

		/// <summary>
		/// System.Action action
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_Paction;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RPaction
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


    }
}
