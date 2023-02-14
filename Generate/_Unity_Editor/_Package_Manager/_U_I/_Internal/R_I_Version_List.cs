
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.IVersionList
	/// </summary>
    public partial class RIVersionList : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackageVersion] key
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion> r_Pkey;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion> RPkey
		{
			get
			{
				if(r_Pkey == null)
				{
					r_Pkey = new(this, "key", -1);
					r_Pkey.SetBelong(this.instance);
				}
				return r_Pkey;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion installed
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion r_Pinstalled;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion RPinstalled
		{
			get
			{
				if(r_Pinstalled == null)
				{
					r_Pinstalled = new(this, "installed", -1);
					r_Pinstalled.SetBelong(this.instance);
				}
				return r_Pinstalled;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion latest
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion r_Platest;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion RPlatest
		{
			get
			{
				if(r_Platest == null)
				{
					r_Platest = new(this, "latest", -1);
					r_Platest.SetBelong(this.instance);
				}
				return r_Platest;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion importAvailable
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion r_PimportAvailable;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion RPimportAvailable
		{
			get
			{
				if(r_PimportAvailable == null)
				{
					r_PimportAvailable = new(this, "importAvailable", -1);
					r_PimportAvailable.SetBelong(this.instance);
				}
				return r_PimportAvailable;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion recommended
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion r_Precommended;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion RPrecommended
		{
			get
			{
				if(r_Precommended == null)
				{
					r_Precommended = new(this, "recommended", -1);
					r_Precommended.SetBelong(this.instance);
				}
				return r_Precommended;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion primary
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion r_Pprimary;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion RPprimary
		{
			get
			{
				if(r_Pprimary == null)
				{
					r_Pprimary = new(this, "primary", -1);
					r_Pprimary.SetBelong(this.instance);
				}
				return r_Pprimary;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion lifecycleVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion r_PlifecycleVersion;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion RPlifecycleVersion
		{
			get
			{
				if(r_PlifecycleVersion == null)
				{
					r_PlifecycleVersion = new(this, "lifecycleVersion", -1);
					r_PlifecycleVersion.SetBelong(this.instance);
				}
				return r_PlifecycleVersion;
			}
		}

		/// <summary>
		/// Boolean isNonLifecycleVersionInstalled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisNonLifecycleVersionInstalled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisNonLifecycleVersionInstalled
		{
			get
			{
				if(r_PisNonLifecycleVersionInstalled == null)
				{
					r_PisNonLifecycleVersionInstalled = new(this, "isNonLifecycleVersionInstalled", -1);
					r_PisNonLifecycleVersionInstalled.SetBelong(this.instance);
				}
				return r_PisNonLifecycleVersionInstalled;
			}
		}

		/// <summary>
		/// Boolean hasLifecycleVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasLifecycleVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasLifecycleVersion
		{
			get
			{
				if(r_PhasLifecycleVersion == null)
				{
					r_PhasLifecycleVersion = new(this, "hasLifecycleVersion", -1);
					r_PhasLifecycleVersion.SetBelong(this.instance);
				}
				return r_PhasLifecycleVersion;
			}
		}

		/// <summary>
		/// Int32 numUnloadedVersions
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PnumUnloadedVersions;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPnumUnloadedVersions
		{
			get
			{
				if(r_PnumUnloadedVersions == null)
				{
					r_PnumUnloadedVersions = new(this, "numUnloadedVersions", -1);
					r_PnumUnloadedVersions.SetBelong(this.instance);
				}
				return r_PnumUnloadedVersions;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion GetUpdateTarget(UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MGetUpdateTarget_IPackageVersion;
		public virtual RMethod RMGetUpdateTarget_IPackageVersion
		{
			get
			{
				if(r_MGetUpdateTarget_IPackageVersion == null)
				{
					r_MGetUpdateTarget_IPackageVersion = new(this, "GetUpdateTarget", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
					r_MGetUpdateTarget_IPackageVersion.SetBelong(this.instance);
				}
				return r_MGetUpdateTarget_IPackageVersion;
			}
		}


        public RIVersionList() : base("UnityEditor.PackageManager.UI.Internal.IVersionList")
        {
        }

        public RIVersionList(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.IVersionList")
		{
            SetInstance(instance);
		}

        public RIVersionList(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIVersionList(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion GetUpdateTarget(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value};
            var ___result = RMGetUpdateTarget_IPackageVersion.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion(___result);
        }


    }
}
