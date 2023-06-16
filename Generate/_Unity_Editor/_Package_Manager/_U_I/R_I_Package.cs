
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.IPackage
	/// </summary>
    public partial class RIPackage : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.IPackage");
            }
        }

        public RIPackage() : base("UnityEditor.PackageManager.UI.IPackage")
        {
        }

        public RIPackage(System.Object instance) : base("UnityEditor.PackageManager.UI.IPackage")
		{
            SetInstance(instance);
		}

        public RIPackage(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIPackage(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String uniqueId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PuniqueId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPuniqueId
		{
			get
			{
				if(r_PuniqueId == null)
				{
					r_PuniqueId = new(this, "uniqueId", -1);
				}
				return r_PuniqueId;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.IPackageVersion] versions
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackageVersion> r_Pversions;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackageVersion> RPversions
		{
			get
			{
				if(r_Pversions == null)
				{
					r_Pversions = new(this, "versions", -1);
				}
				return r_Pversions;
			}
		}


    }
}
