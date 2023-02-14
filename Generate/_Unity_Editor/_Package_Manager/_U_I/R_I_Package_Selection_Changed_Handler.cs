
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.IPackageSelectionChangedHandler
	/// </summary>
    public partial class RIPackageSelectionChangedHandler : RMember //
    {

		/// <summary>
		/// Void OnPackageSelectionChanged(UnityEditor.PackageManager.UI.PackageSelectionArgs)
		/// </summary>
		protected RMethod r_MOnPackageSelectionChanged_PackageSelectionArgs;
		public virtual RMethod RMOnPackageSelectionChanged_PackageSelectionArgs
		{
			get
			{
				if(r_MOnPackageSelectionChanged_PackageSelectionArgs == null)
				{
					r_MOnPackageSelectionChanged_PackageSelectionArgs = new(this, "OnPackageSelectionChanged", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.PackageSelectionArgs"));
					r_MOnPackageSelectionChanged_PackageSelectionArgs.SetBelong(this.instance);
				}
				return r_MOnPackageSelectionChanged_PackageSelectionArgs;
			}
		}


        public RIPackageSelectionChangedHandler() : base("UnityEditor.PackageManager.UI.IPackageSelectionChangedHandler")
        {
        }

        public RIPackageSelectionChangedHandler(System.Object instance) : base("UnityEditor.PackageManager.UI.IPackageSelectionChangedHandler")
		{
            SetInstance(instance);
		}

        public RIPackageSelectionChangedHandler(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIPackageSelectionChangedHandler(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnPackageSelectionChanged(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RPackageSelectionArgs @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args.Value};
            var ___result = RMOnPackageSelectionChanged_PackageSelectionArgs.Invoke(___genericsType, ___parameters);

            
        }


    }
}
