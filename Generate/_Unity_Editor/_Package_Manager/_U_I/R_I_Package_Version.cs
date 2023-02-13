
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.IPackageVersion
	/// </summary>
    public partial class RIPackageVersion : RMember //
    {

		/// <summary>
		/// System.String name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
					r_Pname.SetBelong(this.instance);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// System.String displayName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PdisplayName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPdisplayName
		{
			get
			{
				if(r_PdisplayName == null)
				{
					r_PdisplayName = new(this, "displayName", -1);
					r_PdisplayName.SetBelong(this.instance);
				}
				return r_PdisplayName;
			}
		}

		/// <summary>
		/// System.String versionString
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PversionString;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPversionString
		{
			get
			{
				if(r_PversionString == null)
				{
					r_PversionString = new(this, "versionString", -1);
					r_PversionString.SetBelong(this.instance);
				}
				return r_PversionString;
			}
		}

		/// <summary>
		/// System.String uniqueId
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PuniqueId;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPuniqueId
		{
			get
			{
				if(r_PuniqueId == null)
				{
					r_PuniqueId = new(this, "uniqueId", -1);
					r_PuniqueId.SetBelong(this.instance);
				}
				return r_PuniqueId;
			}
		}

		/// <summary>
		/// System.String packageUniqueId
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PpackageUniqueId;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPpackageUniqueId
		{
			get
			{
				if(r_PpackageUniqueId == null)
				{
					r_PpackageUniqueId = new(this, "packageUniqueId", -1);
					r_PpackageUniqueId.SetBelong(this.instance);
				}
				return r_PpackageUniqueId;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.IPackage package
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackage r_Ppackage;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackage RPpackage
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
		/// Boolean isInstalled
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisInstalled;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisInstalled
		{
			get
			{
				if(r_PisInstalled == null)
				{
					r_PisInstalled = new(this, "isInstalled", -1);
					r_PisInstalled.SetBelong(this.instance);
				}
				return r_PisInstalled;
			}
		}


        public RIPackageVersion() : base("UnityEditor.PackageManager.UI.IPackageVersion")
        {
        }

        public RIPackageVersion(System.Object instance) : base("UnityEditor.PackageManager.UI.IPackageVersion")
		{
            SetInstance(instance);
		}

        public RIPackageVersion(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIPackageVersion(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

    }
}
