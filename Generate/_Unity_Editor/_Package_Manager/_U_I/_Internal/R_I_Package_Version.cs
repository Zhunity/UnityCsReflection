
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.IPackageVersion
	/// </summary>
    public partial class RIPackageVersion : RMember //
    {

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackage package
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage r_Ppackage;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage RPpackage
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
		/// System.String author
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pauthor;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPauthor
		{
			get
			{
				if(r_Pauthor == null)
				{
					r_Pauthor = new(this, "author", -1);
					r_Pauthor.SetBelong(this.instance);
				}
				return r_Pauthor;
			}
		}

		/// <summary>
		/// System.String localReleaseNotes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PlocalReleaseNotes;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPlocalReleaseNotes
		{
			get
			{
				if(r_PlocalReleaseNotes == null)
				{
					r_PlocalReleaseNotes = new(this, "localReleaseNotes", -1);
					r_PlocalReleaseNotes.SetBelong(this.instance);
				}
				return r_PlocalReleaseNotes;
			}
		}

		/// <summary>
		/// System.String description
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pdescription;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPdescription
		{
			get
			{
				if(r_Pdescription == null)
				{
					r_Pdescription = new(this, "description", -1);
					r_Pdescription.SetBelong(this.instance);
				}
				return r_Pdescription;
			}
		}

		/// <summary>
		/// System.String category
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pcategory;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPcategory
		{
			get
			{
				if(r_Pcategory == null)
				{
					r_Pcategory = new(this, "category", -1);
					r_Pcategory.SetBelong(this.instance);
				}
				return r_Pcategory;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IDictionary`2[System.String,System.String] categoryLinks
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString> r_PcategoryLinks;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString> RPcategoryLinks
		{
			get
			{
				if(r_PcategoryLinks == null)
				{
					r_PcategoryLinks = new(this, "categoryLinks", -1);
					r_PcategoryLinks.SetBelong(this.instance);
				}
				return r_PcategoryLinks;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.UIError] errors
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> r_Perrors;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> RPerrors
		{
			get
			{
				if(r_Perrors == null)
				{
					r_Perrors = new(this, "errors", -1);
					r_Perrors.SetBelong(this.instance);
				}
				return r_Perrors;
			}
		}

		/// <summary>
		/// Boolean hasEntitlements
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasEntitlements;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasEntitlements
		{
			get
			{
				if(r_PhasEntitlements == null)
				{
					r_PhasEntitlements = new(this, "hasEntitlements", -1);
					r_PhasEntitlements.SetBelong(this.instance);
				}
				return r_PhasEntitlements;
			}
		}

		/// <summary>
		/// Boolean hasEntitlementsError
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasEntitlementsError;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasEntitlementsError
		{
			get
			{
				if(r_PhasEntitlementsError == null)
				{
					r_PhasEntitlementsError = new(this, "hasEntitlementsError", -1);
					r_PhasEntitlementsError.SetBelong(this.instance);
				}
				return r_PhasEntitlementsError;
			}
		}

		/// <summary>
		/// System.Nullable`1[UnityEditor.Scripting.ScriptCompilation.SemVersion] version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion> r_Pversion;
		public virtual Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion> RPversion
		{
			get
			{
				if(r_Pversion == null)
				{
					r_Pversion = new(this, "version", -1);
					r_Pversion.SetBelong(this.instance);
				}
				return r_Pversion;
			}
		}

		/// <summary>
		/// System.String versionInManifest
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PversionInManifest;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPversionInManifest
		{
			get
			{
				if(r_PversionInManifest == null)
				{
					r_PversionInManifest = new(this, "versionInManifest", -1);
					r_PversionInManifest.SetBelong(this.instance);
				}
				return r_PversionInManifest;
			}
		}

		/// <summary>
		/// System.String versionId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PversionId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPversionId
		{
			get
			{
				if(r_PversionId == null)
				{
					r_PversionId = new(this, "versionId", -1);
					r_PversionId.SetBelong(this.instance);
				}
				return r_PversionId;
			}
		}

		/// <summary>
		/// System.Nullable`1[System.DateTime] publishedDate
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RSystem.RDateTime> r_PpublishedDate;
		public virtual Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RSystem.RDateTime> RPpublishedDate
		{
			get
			{
				if(r_PpublishedDate == null)
				{
					r_PpublishedDate = new(this, "publishedDate", -1);
					r_PpublishedDate.SetBelong(this.instance);
				}
				return r_PpublishedDate;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.DependencyInfo[] dependencies
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RDependencyInfo> r_Pdependencies;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RDependencyInfo> RPdependencies
		{
			get
			{
				if(r_Pdependencies == null)
				{
					r_Pdependencies = new(this, "dependencies", -1);
					r_Pdependencies.SetBelong(this.instance);
				}
				return r_Pdependencies;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.DependencyInfo[] resolvedDependencies
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RDependencyInfo> r_PresolvedDependencies;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RDependencyInfo> RPresolvedDependencies
		{
			get
			{
				if(r_PresolvedDependencies == null)
				{
					r_PresolvedDependencies = new(this, "resolvedDependencies", -1);
					r_PresolvedDependencies.SetBelong(this.instance);
				}
				return r_PresolvedDependencies;
			}
		}

		/// <summary>
		/// Boolean isFullyFetched
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisFullyFetched;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisFullyFetched
		{
			get
			{
				if(r_PisFullyFetched == null)
				{
					r_PisFullyFetched = new(this, "isFullyFetched", -1);
					r_PisFullyFetched.SetBelong(this.instance);
				}
				return r_PisFullyFetched;
			}
		}

		/// <summary>
		/// Boolean isAvailableOnDisk
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisAvailableOnDisk;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisAvailableOnDisk
		{
			get
			{
				if(r_PisAvailableOnDisk == null)
				{
					r_PisAvailableOnDisk = new(this, "isAvailableOnDisk", -1);
					r_PisAvailableOnDisk.SetBelong(this.instance);
				}
				return r_PisAvailableOnDisk;
			}
		}

		/// <summary>
		/// Boolean isDirectDependency
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisDirectDependency;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisDirectDependency
		{
			get
			{
				if(r_PisDirectDependency == null)
				{
					r_PisDirectDependency = new(this, "isDirectDependency", -1);
					r_PisDirectDependency.SetBelong(this.instance);
				}
				return r_PisDirectDependency;
			}
		}

		/// <summary>
		/// Boolean isUnityPackage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisUnityPackage;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisUnityPackage
		{
			get
			{
				if(r_PisUnityPackage == null)
				{
					r_PisUnityPackage = new(this, "isUnityPackage", -1);
					r_PisUnityPackage.SetBelong(this.instance);
				}
				return r_PisUnityPackage;
			}
		}

		/// <summary>
		/// System.String localPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PlocalPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPlocalPath
		{
			get
			{
				if(r_PlocalPath == null)
				{
					r_PlocalPath = new(this, "localPath", -1);
					r_PlocalPath.SetBelong(this.instance);
				}
				return r_PlocalPath;
			}
		}

		/// <summary>
		/// System.Nullable`1[UnityEditor.Scripting.ScriptCompilation.SemVersion] supportedVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion> r_PsupportedVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion> RPsupportedVersion
		{
			get
			{
				if(r_PsupportedVersion == null)
				{
					r_PsupportedVersion = new(this, "supportedVersion", -1);
					r_PsupportedVersion.SetBelong(this.instance);
				}
				return r_PsupportedVersion;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.Scripting.ScriptCompilation.SemVersion] supportedVersions
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion> r_PsupportedVersions;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion> RPsupportedVersions
		{
			get
			{
				if(r_PsupportedVersions == null)
				{
					r_PsupportedVersions = new(this, "supportedVersions", -1);
					r_PsupportedVersions.SetBelong(this.instance);
				}
				return r_PsupportedVersions;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.PackageSizeInfo] sizes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageSizeInfo> r_Psizes;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageSizeInfo> RPsizes
		{
			get
			{
				if(r_Psizes == null)
				{
					r_Psizes = new(this, "sizes", -1);
					r_Psizes.SetBelong(this.instance);
				}
				return r_Psizes;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.EntitlementsInfo entitlements
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.REntitlementsInfo r_Pentitlements;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.REntitlementsInfo RPentitlements
		{
			get
			{
				if(r_Pentitlements == null)
				{
					r_Pentitlements = new(this, "entitlements", -1);
					r_Pentitlements.SetBelong(this.instance);
				}
				return r_Pentitlements;
			}
		}

		/// <summary>
		/// Boolean IsDifferentVersionThanRequested
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsDifferentVersionThanRequested;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsDifferentVersionThanRequested
		{
			get
			{
				if(r_PIsDifferentVersionThanRequested == null)
				{
					r_PIsDifferentVersionThanRequested = new(this, "IsDifferentVersionThanRequested", -1);
					r_PIsDifferentVersionThanRequested.SetBelong(this.instance);
				}
				return r_PIsDifferentVersionThanRequested;
			}
		}

		/// <summary>
		/// Boolean IsRequestedButOverriddenVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsRequestedButOverriddenVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsRequestedButOverriddenVersion
		{
			get
			{
				if(r_PIsRequestedButOverriddenVersion == null)
				{
					r_PIsRequestedButOverriddenVersion = new(this, "IsRequestedButOverriddenVersion", -1);
					r_PIsRequestedButOverriddenVersion.SetBelong(this.instance);
				}
				return r_PIsRequestedButOverriddenVersion;
			}
		}

		/// <summary>
		/// Boolean isRegistryPackage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisRegistryPackage;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisRegistryPackage
		{
			get
			{
				if(r_PisRegistryPackage == null)
				{
					r_PisRegistryPackage = new(this, "isRegistryPackage", -1);
					r_PisRegistryPackage.SetBelong(this.instance);
				}
				return r_PisRegistryPackage;
			}
		}

		/// <summary>
		/// Boolean isFromScopedRegistry
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisFromScopedRegistry;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisFromScopedRegistry
		{
			get
			{
				if(r_PisFromScopedRegistry == null)
				{
					r_PisFromScopedRegistry = new(this, "isFromScopedRegistry", -1);
					r_PisFromScopedRegistry.SetBelong(this.instance);
				}
				return r_PisFromScopedRegistry;
			}
		}

		/// <summary>
		/// Boolean HasTag(UnityEditor.PackageManager.UI.Internal.PackageTag)
		/// </summary>
		protected RMethod r_MHasTag_PackageTag;
		public virtual RMethod RMHasTag_PackageTag
		{
			get
			{
				if(r_MHasTag_PackageTag == null)
				{
					r_MHasTag_PackageTag = new(this, "HasTag", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageTag"));
					r_MHasTag_PackageTag.SetBelong(this.instance);
				}
				return r_MHasTag_PackageTag;
			}
		}


        public RIPackageVersion() : base("UnityEditor.PackageManager.UI.Internal.IPackageVersion")
        {
        }

        public RIPackageVersion(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.IPackageVersion")
		{
            SetInstance(instance);
		}

        public RIPackageVersion(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIPackageVersion(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean HasTag(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag.Value};
            var ___result = RMHasTag_PackageTag.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


    }
}
