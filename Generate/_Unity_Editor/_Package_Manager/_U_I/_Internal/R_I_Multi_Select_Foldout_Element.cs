
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.IMultiSelectFoldoutElement
	/// </summary>
    public partial class RIMultiSelectFoldoutElement : RMember //
    {

		/// <summary>
		/// Void Refresh()
		/// </summary>
		protected RMethod r_MRefresh;
		public virtual RMethod RMRefresh
		{
			get
			{
				if(r_MRefresh == null)
				{
					r_MRefresh = new(this, "Refresh", 0);
				}
				return r_MRefresh;
			}
		}

		/// <summary>
		/// Boolean AddPackageVersion(UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MAddPackageVersion_IPackageVersion;
		public virtual RMethod RMAddPackageVersion_IPackageVersion
		{
			get
			{
				if(r_MAddPackageVersion_IPackageVersion == null)
				{
					r_MAddPackageVersion_IPackageVersion = new(this, "AddPackageVersion", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
				}
				return r_MAddPackageVersion_IPackageVersion;
			}
		}

		/// <summary>
		/// Void ClearVersions()
		/// </summary>
		protected RMethod r_MClearVersions;
		public virtual RMethod RMClearVersions
		{
			get
			{
				if(r_MClearVersions == null)
				{
					r_MClearVersions = new(this, "ClearVersions", 0);
				}
				return r_MClearVersions;
			}
		}


        public RIMultiSelectFoldoutElement() : base("UnityEditor.PackageManager.UI.Internal.IMultiSelectFoldoutElement")
        {
        }

        public RIMultiSelectFoldoutElement(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.IMultiSelectFoldoutElement")
		{
            SetInstance(instance);
		}

        public RIMultiSelectFoldoutElement(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIMultiSelectFoldoutElement(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Refresh()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefresh.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean AddPackageVersion(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value};
            var ___result = RMAddPackageVersion_IPackageVersion.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ClearVersions()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearVersions.Invoke(___genericsType, ___parameters);

            
        }


    }
}
