
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.IWindow
	/// </summary>
    public partial class RIWindow : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.IWindow");
            }
        }

        public RIWindow() : base("UnityEditor.PackageManager.UI.IWindow")
        {
        }

        public RIWindow(System.Object instance) : base("UnityEditor.PackageManager.UI.IWindow")
		{
            SetInstance(instance);
		}

        public RIWindow(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIWindow(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEditor.PackageManager.UI.PackageSelectionArgs activeSelection
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RPackageSelectionArgs r_PactiveSelection;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RPackageSelectionArgs RPactiveSelection
		{
			get
			{
				if(r_PactiveSelection == null)
				{
					r_PactiveSelection = new(this, "activeSelection", -1);
				}
				return r_PactiveSelection;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.IMenu addMenu
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIMenu r_PaddMenu;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIMenu RPaddMenu
		{
			get
			{
				if(r_PaddMenu == null)
				{
					r_PaddMenu = new(this, "addMenu", -1);
				}
				return r_PaddMenu;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.IMenu advancedMenu
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIMenu r_PadvancedMenu;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIMenu RPadvancedMenu
		{
			get
			{
				if(r_PadvancedMenu == null)
				{
					r_PadvancedMenu = new(this, "advancedMenu", -1);
				}
				return r_PadvancedMenu;
			}
		}

		/// <summary>
		/// Void Select(System.String)
		/// </summary>
		protected RMethod r_MSelect_String;
		public virtual RMethod RMSelect_String
		{
			get
			{
				if(r_MSelect_String == null)
				{
					r_MSelect_String = new(this, "Select", 0, typeof(System.String));
				}
				return r_MSelect_String;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.IDetailsExtension AddDetailsExtension()
		/// </summary>
		protected RMethod r_MAddDetailsExtension;
		public virtual RMethod RMAddDetailsExtension
		{
			get
			{
				if(r_MAddDetailsExtension == null)
				{
					r_MAddDetailsExtension = new(this, "AddDetailsExtension", 0);
				}
				return r_MAddDetailsExtension;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.IPackageActionMenu AddPackageActionMenu()
		/// </summary>
		protected RMethod r_MAddPackageActionMenu;
		public virtual RMethod RMAddPackageActionMenu
		{
			get
			{
				if(r_MAddPackageActionMenu == null)
				{
					r_MAddPackageActionMenu = new(this, "AddPackageActionMenu", 0);
				}
				return r_MAddPackageActionMenu;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.IPackageActionButton AddPackageActionButton()
		/// </summary>
		protected RMethod r_MAddPackageActionButton;
		public virtual RMethod RMAddPackageActionButton
		{
			get
			{
				if(r_MAddPackageActionButton == null)
				{
					r_MAddPackageActionButton = new(this, "AddPackageActionButton", 0);
				}
				return r_MAddPackageActionButton;
			}
		}


        public virtual void Select(System.String @identifier)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@identifier};
            var ___result = RMSelect_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIDetailsExtension AddDetailsExtension()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAddDetailsExtension.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIDetailsExtension(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackageActionMenu AddPackageActionMenu()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAddPackageActionMenu.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackageActionMenu(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackageActionButton AddPackageActionButton()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAddPackageActionButton.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackageActionButton(___result);
        }


    }
}
