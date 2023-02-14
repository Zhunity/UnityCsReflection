
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager
{
	/// <summary>
	/// UnityEditor.PackageManager.PackageInfo
	/// </summary>
    public partial class RPackageInfo : RMember //
    {

		/// <summary>
		/// System.String m_PackageId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_PackageId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_PackageId
		{
			get
			{
				if(r_Fm_PackageId == null)
				{
					r_Fm_PackageId = new(this, "m_PackageId");
					r_Fm_PackageId.SetBelong(this.instance);
				}
				return r_Fm_PackageId;
			}
		}

		/// <summary>
		/// System.Boolean m_IsDirectDependency
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_IsDirectDependency;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_IsDirectDependency
		{
			get
			{
				if(r_Fm_IsDirectDependency == null)
				{
					r_Fm_IsDirectDependency = new(this, "m_IsDirectDependency");
					r_Fm_IsDirectDependency.SetBelong(this.instance);
				}
				return r_Fm_IsDirectDependency;
			}
		}

		/// <summary>
		/// System.String m_ProjectDependenciesEntry
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_ProjectDependenciesEntry;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_ProjectDependenciesEntry
		{
			get
			{
				if(r_Fm_ProjectDependenciesEntry == null)
				{
					r_Fm_ProjectDependenciesEntry = new(this, "m_ProjectDependenciesEntry");
					r_Fm_ProjectDependenciesEntry.SetBelong(this.instance);
				}
				return r_Fm_ProjectDependenciesEntry;
			}
		}

		/// <summary>
		/// System.String m_Version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Version;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Version
		{
			get
			{
				if(r_Fm_Version == null)
				{
					r_Fm_Version = new(this, "m_Version");
					r_Fm_Version.SetBelong(this.instance);
				}
				return r_Fm_Version;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.PackageSource m_Source
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageSource r_Fm_Source;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageSource RFm_Source
		{
			get
			{
				if(r_Fm_Source == null)
				{
					r_Fm_Source = new(this, "m_Source");
					r_Fm_Source.SetBelong(this.instance);
				}
				return r_Fm_Source;
			}
		}

		/// <summary>
		/// System.String m_ResolvedPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_ResolvedPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_ResolvedPath
		{
			get
			{
				if(r_Fm_ResolvedPath == null)
				{
					r_Fm_ResolvedPath = new(this, "m_ResolvedPath");
					r_Fm_ResolvedPath.SetBelong(this.instance);
				}
				return r_Fm_ResolvedPath;
			}
		}

		/// <summary>
		/// System.String m_AssetPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_AssetPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_AssetPath
		{
			get
			{
				if(r_Fm_AssetPath == null)
				{
					r_Fm_AssetPath = new(this, "m_AssetPath");
					r_Fm_AssetPath.SetBelong(this.instance);
				}
				return r_Fm_AssetPath;
			}
		}

		/// <summary>
		/// System.String m_Name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Name;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Name
		{
			get
			{
				if(r_Fm_Name == null)
				{
					r_Fm_Name = new(this, "m_Name");
					r_Fm_Name.SetBelong(this.instance);
				}
				return r_Fm_Name;
			}
		}

		/// <summary>
		/// System.String m_DisplayName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_DisplayName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_DisplayName
		{
			get
			{
				if(r_Fm_DisplayName == null)
				{
					r_Fm_DisplayName = new(this, "m_DisplayName");
					r_Fm_DisplayName.SetBelong(this.instance);
				}
				return r_Fm_DisplayName;
			}
		}

		/// <summary>
		/// System.String m_Category
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Category;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Category
		{
			get
			{
				if(r_Fm_Category == null)
				{
					r_Fm_Category = new(this, "m_Category");
					r_Fm_Category.SetBelong(this.instance);
				}
				return r_Fm_Category;
			}
		}

		/// <summary>
		/// System.String m_Type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Type;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Type
		{
			get
			{
				if(r_Fm_Type == null)
				{
					r_Fm_Type = new(this, "m_Type");
					r_Fm_Type.SetBelong(this.instance);
				}
				return r_Fm_Type;
			}
		}

		/// <summary>
		/// System.String m_Description
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Description;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Description
		{
			get
			{
				if(r_Fm_Description == null)
				{
					r_Fm_Description = new(this, "m_Description");
					r_Fm_Description.SetBelong(this.instance);
				}
				return r_Fm_Description;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.PackageStatus m_Status
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageStatus r_Fm_Status;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageStatus RFm_Status
		{
			get
			{
				if(r_Fm_Status == null)
				{
					r_Fm_Status = new(this, "m_Status");
					r_Fm_Status.SetBelong(this.instance);
				}
				return r_Fm_Status;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.Error[] m_Errors
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RError> r_Fm_Errors;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RError> RFm_Errors
		{
			get
			{
				if(r_Fm_Errors == null)
				{
					r_Fm_Errors = new(this, "m_Errors");
					r_Fm_Errors.SetBelong(this.instance);
				}
				return r_Fm_Errors;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.VersionsInfo m_Versions
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RVersionsInfo r_Fm_Versions;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RVersionsInfo RFm_Versions
		{
			get
			{
				if(r_Fm_Versions == null)
				{
					r_Fm_Versions = new(this, "m_Versions");
					r_Fm_Versions.SetBelong(this.instance);
				}
				return r_Fm_Versions;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.DependencyInfo[] m_Dependencies
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RDependencyInfo> r_Fm_Dependencies;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RDependencyInfo> RFm_Dependencies
		{
			get
			{
				if(r_Fm_Dependencies == null)
				{
					r_Fm_Dependencies = new(this, "m_Dependencies");
					r_Fm_Dependencies.SetBelong(this.instance);
				}
				return r_Fm_Dependencies;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.DependencyInfo[] m_ResolvedDependencies
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RDependencyInfo> r_Fm_ResolvedDependencies;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RDependencyInfo> RFm_ResolvedDependencies
		{
			get
			{
				if(r_Fm_ResolvedDependencies == null)
				{
					r_Fm_ResolvedDependencies = new(this, "m_ResolvedDependencies");
					r_Fm_ResolvedDependencies.SetBelong(this.instance);
				}
				return r_Fm_ResolvedDependencies;
			}
		}

		/// <summary>
		/// System.String[] m_Keywords
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_Keywords;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFm_Keywords
		{
			get
			{
				if(r_Fm_Keywords == null)
				{
					r_Fm_Keywords = new(this, "m_Keywords");
					r_Fm_Keywords.SetBelong(this.instance);
				}
				return r_Fm_Keywords;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.AuthorInfo m_Author
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RAuthorInfo r_Fm_Author;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RAuthorInfo RFm_Author
		{
			get
			{
				if(r_Fm_Author == null)
				{
					r_Fm_Author = new(this, "m_Author");
					r_Fm_Author.SetBelong(this.instance);
				}
				return r_Fm_Author;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.RegistryInfo m_Registry
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRegistryInfo r_Fm_Registry;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRegistryInfo RFm_Registry
		{
			get
			{
				if(r_Fm_Registry == null)
				{
					r_Fm_Registry = new(this, "m_Registry");
					r_Fm_Registry.SetBelong(this.instance);
				}
				return r_Fm_Registry;
			}
		}

		/// <summary>
		/// System.Boolean m_HideInEditor
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_HideInEditor;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_HideInEditor
		{
			get
			{
				if(r_Fm_HideInEditor == null)
				{
					r_Fm_HideInEditor = new(this, "m_HideInEditor");
					r_Fm_HideInEditor.SetBelong(this.instance);
				}
				return r_Fm_HideInEditor;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.EntitlementsInfo m_Entitlements
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.REntitlementsInfo r_Fm_Entitlements;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.REntitlementsInfo RFm_Entitlements
		{
			get
			{
				if(r_Fm_Entitlements == null)
				{
					r_Fm_Entitlements = new(this, "m_Entitlements");
					r_Fm_Entitlements.SetBelong(this.instance);
				}
				return r_Fm_Entitlements;
			}
		}

		/// <summary>
		/// System.Int64 m_DatePublishedTicks
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Fm_DatePublishedTicks;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFm_DatePublishedTicks
		{
			get
			{
				if(r_Fm_DatePublishedTicks == null)
				{
					r_Fm_DatePublishedTicks = new(this, "m_DatePublishedTicks");
					r_Fm_DatePublishedTicks.SetBelong(this.instance);
				}
				return r_Fm_DatePublishedTicks;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.GitInfo m_Git
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RGitInfo r_Fm_Git;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RGitInfo RFm_Git
		{
			get
			{
				if(r_Fm_Git == null)
				{
					r_Fm_Git = new(this, "m_Git");
					r_Fm_Git.SetBelong(this.instance);
				}
				return r_Fm_Git;
			}
		}

		/// <summary>
		/// System.Boolean m_IsAssetStorePackage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_IsAssetStorePackage;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_IsAssetStorePackage
		{
			get
			{
				if(r_Fm_IsAssetStorePackage == null)
				{
					r_Fm_IsAssetStorePackage = new(this, "m_IsAssetStorePackage");
					r_Fm_IsAssetStorePackage.SetBelong(this.instance);
				}
				return r_Fm_IsAssetStorePackage;
			}
		}

		/// <summary>
		/// System.String m_DocumentationUrl
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_DocumentationUrl;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_DocumentationUrl
		{
			get
			{
				if(r_Fm_DocumentationUrl == null)
				{
					r_Fm_DocumentationUrl = new(this, "m_DocumentationUrl");
					r_Fm_DocumentationUrl.SetBelong(this.instance);
				}
				return r_Fm_DocumentationUrl;
			}
		}

		/// <summary>
		/// System.String m_ChangelogUrl
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_ChangelogUrl;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_ChangelogUrl
		{
			get
			{
				if(r_Fm_ChangelogUrl == null)
				{
					r_Fm_ChangelogUrl = new(this, "m_ChangelogUrl");
					r_Fm_ChangelogUrl.SetBelong(this.instance);
				}
				return r_Fm_ChangelogUrl;
			}
		}

		/// <summary>
		/// System.String m_LicensesUrl
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_LicensesUrl;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_LicensesUrl
		{
			get
			{
				if(r_Fm_LicensesUrl == null)
				{
					r_Fm_LicensesUrl = new(this, "m_LicensesUrl");
					r_Fm_LicensesUrl.SetBelong(this.instance);
				}
				return r_Fm_LicensesUrl;
			}
		}

		/// <summary>
		/// System.Boolean m_HasRepository
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_HasRepository;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_HasRepository
		{
			get
			{
				if(r_Fm_HasRepository == null)
				{
					r_Fm_HasRepository = new(this, "m_HasRepository");
					r_Fm_HasRepository.SetBelong(this.instance);
				}
				return r_Fm_HasRepository;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.RepositoryInfo m_Repository
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRepositoryInfo r_Fm_Repository;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRepositoryInfo RFm_Repository
		{
			get
			{
				if(r_Fm_Repository == null)
				{
					r_Fm_Repository = new(this, "m_Repository");
					r_Fm_Repository.SetBelong(this.instance);
				}
				return r_Fm_Repository;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UnityLifecycle.UnityLifecycleInfo m_UnityLifecycle
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUnityLifecycle.RUnityLifecycleInfo r_Fm_UnityLifecycle;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUnityLifecycle.RUnityLifecycleInfo RFm_UnityLifecycle
		{
			get
			{
				if(r_Fm_UnityLifecycle == null)
				{
					r_Fm_UnityLifecycle = new(this, "m_UnityLifecycle");
					r_Fm_UnityLifecycle.SetBelong(this.instance);
				}
				return r_Fm_UnityLifecycle;
			}
		}

		/// <summary>
		/// System.String m_UpmReserved
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_UpmReserved;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_UpmReserved
		{
			get
			{
				if(r_Fm_UpmReserved == null)
				{
					r_Fm_UpmReserved = new(this, "m_UpmReserved");
					r_Fm_UpmReserved.SetBelong(this.instance);
				}
				return r_Fm_UpmReserved;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.SignatureInfo m_Signature
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RSignatureInfo r_Fm_Signature;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RSignatureInfo RFm_Signature
		{
			get
			{
				if(r_Fm_Signature == null)
				{
					r_Fm_Signature = new(this, "m_Signature");
					r_Fm_Signature.SetBelong(this.instance);
				}
				return r_Fm_Signature;
			}
		}

		/// <summary>
		/// System.Boolean m_IsDeprecated
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_IsDeprecated;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_IsDeprecated
		{
			get
			{
				if(r_Fm_IsDeprecated == null)
				{
					r_Fm_IsDeprecated = new(this, "m_IsDeprecated");
					r_Fm_IsDeprecated.SetBelong(this.instance);
				}
				return r_Fm_IsDeprecated;
			}
		}

		/// <summary>
		/// System.String m_DeprecationMessage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_DeprecationMessage;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_DeprecationMessage
		{
			get
			{
				if(r_Fm_DeprecationMessage == null)
				{
					r_Fm_DeprecationMessage = new(this, "m_DeprecationMessage");
					r_Fm_DeprecationMessage.SetBelong(this.instance);
				}
				return r_Fm_DeprecationMessage;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.AssetStoreInfo m_AssetStore
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RAssetStoreInfo r_Fm_AssetStore;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RAssetStoreInfo RFm_AssetStore
		{
			get
			{
				if(r_Fm_AssetStore == null)
				{
					r_Fm_AssetStore = new(this, "m_AssetStore");
					r_Fm_AssetStore.SetBelong(this.instance);
				}
				return r_Fm_AssetStore;
			}
		}

		/// <summary>
		/// System.String packageId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PpackageId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPpackageId
		{
			get
			{
				if(r_PpackageId == null)
				{
					r_PpackageId = new(this, "packageId", -1);
					r_PpackageId.SetBelong(this.instance);
				}
				return r_PpackageId;
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
		/// System.String version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pversion;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPversion
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
		/// UnityEditor.PackageManager.PackageSource source
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageSource r_Psource;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageSource RPsource
		{
			get
			{
				if(r_Psource == null)
				{
					r_Psource = new(this, "source", -1);
					r_Psource.SetBelong(this.instance);
				}
				return r_Psource;
			}
		}

		/// <summary>
		/// System.String resolvedPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PresolvedPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPresolvedPath
		{
			get
			{
				if(r_PresolvedPath == null)
				{
					r_PresolvedPath = new(this, "resolvedPath", -1);
					r_PresolvedPath.SetBelong(this.instance);
				}
				return r_PresolvedPath;
			}
		}

		/// <summary>
		/// System.String assetPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PassetPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPassetPath
		{
			get
			{
				if(r_PassetPath == null)
				{
					r_PassetPath = new(this, "assetPath", -1);
					r_PassetPath.SetBelong(this.instance);
				}
				return r_PassetPath;
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
					r_Pname.SetBelong(this.instance);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// System.String displayName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PdisplayName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPdisplayName
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
		/// System.String type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ptype;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtype
		{
			get
			{
				if(r_Ptype == null)
				{
					r_Ptype = new(this, "type", -1);
					r_Ptype.SetBelong(this.instance);
				}
				return r_Ptype;
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
		/// UnityEditor.PackageManager.PackageStatus status
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageStatus r_Pstatus;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageStatus RPstatus
		{
			get
			{
				if(r_Pstatus == null)
				{
					r_Pstatus = new(this, "status", -1);
					r_Pstatus.SetBelong(this.instance);
				}
				return r_Pstatus;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.Error[] errors
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RError> r_Perrors;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RError> RPerrors
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
		/// UnityEditor.PackageManager.VersionsInfo versions
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RVersionsInfo r_Pversions;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RVersionsInfo RPversions
		{
			get
			{
				if(r_Pversions == null)
				{
					r_Pversions = new(this, "versions", -1);
					r_Pversions.SetBelong(this.instance);
				}
				return r_Pversions;
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
		/// System.String[] keywords
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_Pkeywords;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPkeywords
		{
			get
			{
				if(r_Pkeywords == null)
				{
					r_Pkeywords = new(this, "keywords", -1);
					r_Pkeywords.SetBelong(this.instance);
				}
				return r_Pkeywords;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.AuthorInfo author
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RAuthorInfo r_Pauthor;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RAuthorInfo RPauthor
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
		/// Boolean hideInEditor
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhideInEditor;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhideInEditor
		{
			get
			{
				if(r_PhideInEditor == null)
				{
					r_PhideInEditor = new(this, "hideInEditor", -1);
					r_PhideInEditor.SetBelong(this.instance);
				}
				return r_PhideInEditor;
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
		/// Boolean isAssetStorePackage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisAssetStorePackage;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisAssetStorePackage
		{
			get
			{
				if(r_PisAssetStorePackage == null)
				{
					r_PisAssetStorePackage = new(this, "isAssetStorePackage", -1);
					r_PisAssetStorePackage.SetBelong(this.instance);
				}
				return r_PisAssetStorePackage;
			}
		}

		/// <summary>
		/// System.String documentationUrl
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PdocumentationUrl;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPdocumentationUrl
		{
			get
			{
				if(r_PdocumentationUrl == null)
				{
					r_PdocumentationUrl = new(this, "documentationUrl", -1);
					r_PdocumentationUrl.SetBelong(this.instance);
				}
				return r_PdocumentationUrl;
			}
		}

		/// <summary>
		/// System.String changelogUrl
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PchangelogUrl;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPchangelogUrl
		{
			get
			{
				if(r_PchangelogUrl == null)
				{
					r_PchangelogUrl = new(this, "changelogUrl", -1);
					r_PchangelogUrl.SetBelong(this.instance);
				}
				return r_PchangelogUrl;
			}
		}

		/// <summary>
		/// System.String licensesUrl
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PlicensesUrl;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPlicensesUrl
		{
			get
			{
				if(r_PlicensesUrl == null)
				{
					r_PlicensesUrl = new(this, "licensesUrl", -1);
					r_PlicensesUrl.SetBelong(this.instance);
				}
				return r_PlicensesUrl;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UnityLifecycle.UnityLifecycleInfo unityLifecycle
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUnityLifecycle.RUnityLifecycleInfo r_PunityLifecycle;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUnityLifecycle.RUnityLifecycleInfo RPunityLifecycle
		{
			get
			{
				if(r_PunityLifecycle == null)
				{
					r_PunityLifecycle = new(this, "unityLifecycle", -1);
					r_PunityLifecycle.SetBelong(this.instance);
				}
				return r_PunityLifecycle;
			}
		}

		/// <summary>
		/// System.String projectDependenciesEntry
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PprojectDependenciesEntry;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPprojectDependenciesEntry
		{
			get
			{
				if(r_PprojectDependenciesEntry == null)
				{
					r_PprojectDependenciesEntry = new(this, "projectDependenciesEntry", -1);
					r_PprojectDependenciesEntry.SetBelong(this.instance);
				}
				return r_PprojectDependenciesEntry;
			}
		}

		/// <summary>
		/// System.String upmReserved
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PupmReserved;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPupmReserved
		{
			get
			{
				if(r_PupmReserved == null)
				{
					r_PupmReserved = new(this, "upmReserved", -1);
					r_PupmReserved.SetBelong(this.instance);
				}
				return r_PupmReserved;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.RegistryInfo registry
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRegistryInfo r_Pregistry;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRegistryInfo RPregistry
		{
			get
			{
				if(r_Pregistry == null)
				{
					r_Pregistry = new(this, "registry", -1);
					r_Pregistry.SetBelong(this.instance);
				}
				return r_Pregistry;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.SignatureInfo signature
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RSignatureInfo r_Psignature;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RSignatureInfo RPsignature
		{
			get
			{
				if(r_Psignature == null)
				{
					r_Psignature = new(this, "signature", -1);
					r_Psignature.SetBelong(this.instance);
				}
				return r_Psignature;
			}
		}

		/// <summary>
		/// Boolean isDeprecated
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisDeprecated;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisDeprecated
		{
			get
			{
				if(r_PisDeprecated == null)
				{
					r_PisDeprecated = new(this, "isDeprecated", -1);
					r_PisDeprecated.SetBelong(this.instance);
				}
				return r_PisDeprecated;
			}
		}

		/// <summary>
		/// System.String deprecationMessage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PdeprecationMessage;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPdeprecationMessage
		{
			get
			{
				if(r_PdeprecationMessage == null)
				{
					r_PdeprecationMessage = new(this, "deprecationMessage", -1);
					r_PdeprecationMessage.SetBelong(this.instance);
				}
				return r_PdeprecationMessage;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.AssetStoreInfo assetStore
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RAssetStoreInfo r_PassetStore;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RAssetStoreInfo RPassetStore
		{
			get
			{
				if(r_PassetStore == null)
				{
					r_PassetStore = new(this, "assetStore", -1);
					r_PassetStore.SetBelong(this.instance);
				}
				return r_PassetStore;
			}
		}

		/// <summary>
		/// System.Nullable`1[System.DateTime] datePublished
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RSystem.RDateTime> r_PdatePublished;
		public virtual Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RSystem.RDateTime> RPdatePublished
		{
			get
			{
				if(r_PdatePublished == null)
				{
					r_PdatePublished = new(this, "datePublished", -1);
					r_PdatePublished.SetBelong(this.instance);
				}
				return r_PdatePublished;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.GitInfo git
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RGitInfo r_Pgit;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RGitInfo RPgit
		{
			get
			{
				if(r_Pgit == null)
				{
					r_Pgit = new(this, "git", -1);
					r_Pgit.SetBelong(this.instance);
				}
				return r_Pgit;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.RepositoryInfo repository
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRepositoryInfo r_Prepository;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRepositoryInfo RPrepository
		{
			get
			{
				if(r_Prepository == null)
				{
					r_Prepository = new(this, "repository", -1);
					r_Prepository.SetBelong(this.instance);
				}
				return r_Prepository;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.PackageInfo FindForAssetPath(System.String)
		/// </summary>
		protected static RMethod r_MFindForAssetPath_String;
		public static RMethod RMFindForAssetPath_String
		{
			get
			{
				if(r_MFindForAssetPath_String == null)
				{
					r_MFindForAssetPath_String = new(typeof(UnityEditor.PackageManager.PackageInfo), "FindForAssetPath", 0, typeof(System.String));
					r_MFindForAssetPath_String.SetBelong(null);
				}
				return r_MFindForAssetPath_String;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.PackageInfo FindForAssembly(System.Reflection.Assembly)
		/// </summary>
		protected static RMethod r_MFindForAssembly_Assembly;
		public static RMethod RMFindForAssembly_Assembly
		{
			get
			{
				if(r_MFindForAssembly_Assembly == null)
				{
					r_MFindForAssembly_Assembly = new(typeof(UnityEditor.PackageManager.PackageInfo), "FindForAssembly", 0, typeof(System.Reflection.Assembly));
					r_MFindForAssembly_Assembly.SetBelong(null);
				}
				return r_MFindForAssembly_Assembly;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.PackageInfo] GetForAssemblyFilePaths(System.Collections.Generic.List`1[System.String])
		/// </summary>
		protected static RMethod r_MGetForAssemblyFilePaths_List_d_String_p_;
		public static RMethod RMGetForAssemblyFilePaths_List_d_String_p_
		{
			get
			{
				if(r_MGetForAssemblyFilePaths_List_d_String_p_ == null)
				{
					r_MGetForAssemblyFilePaths_List_d_String_p_ = new(typeof(UnityEditor.PackageManager.PackageInfo), "GetForAssemblyFilePaths", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.String)));
					r_MGetForAssemblyFilePaths_List_d_String_p_.SetBelong(null);
				}
				return r_MGetForAssemblyFilePaths_List_d_String_p_;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.PackageInfo[] GetAllRegisteredPackages()
		/// </summary>
		protected static RMethod r_MGetAllRegisteredPackages;
		public static RMethod RMGetAllRegisteredPackages
		{
			get
			{
				if(r_MGetAllRegisteredPackages == null)
				{
					r_MGetAllRegisteredPackages = new(typeof(UnityEditor.PackageManager.PackageInfo), "GetAllRegisteredPackages", 0);
					r_MGetAllRegisteredPackages.SetBelong(null);
				}
				return r_MGetAllRegisteredPackages;
			}
		}

		/// <summary>
		/// System.String[] GetPredefinedPackageTypes()
		/// </summary>
		protected static RMethod r_MGetPredefinedPackageTypes;
		public static RMethod RMGetPredefinedPackageTypes
		{
			get
			{
				if(r_MGetPredefinedPackageTypes == null)
				{
					r_MGetPredefinedPackageTypes = new(typeof(UnityEditor.PackageManager.PackageInfo), "GetPredefinedPackageTypes", 0);
					r_MGetPredefinedPackageTypes.SetBelong(null);
				}
				return r_MGetPredefinedPackageTypes;
			}
		}

		/// <summary>
		/// System.String[] GetPredefinedHiddenByDefaultPackageTypes()
		/// </summary>
		protected static RMethod r_MGetPredefinedHiddenByDefaultPackageTypes;
		public static RMethod RMGetPredefinedHiddenByDefaultPackageTypes
		{
			get
			{
				if(r_MGetPredefinedHiddenByDefaultPackageTypes == null)
				{
					r_MGetPredefinedHiddenByDefaultPackageTypes = new(typeof(UnityEditor.PackageManager.PackageInfo), "GetPredefinedHiddenByDefaultPackageTypes", 0);
					r_MGetPredefinedHiddenByDefaultPackageTypes.SetBelong(null);
				}
				return r_MGetPredefinedHiddenByDefaultPackageTypes;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.PackageInfo GetPackageByAssetPath(System.String)
		/// </summary>
		protected static RMethod r_MGetPackageByAssetPath_String;
		public static RMethod RMGetPackageByAssetPath_String
		{
			get
			{
				if(r_MGetPackageByAssetPath_String == null)
				{
					r_MGetPackageByAssetPath_String = new(typeof(UnityEditor.PackageManager.PackageInfo), "GetPackageByAssetPath", 0, typeof(System.String));
					r_MGetPackageByAssetPath_String.SetBelong(null);
				}
				return r_MGetPackageByAssetPath_String;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_MEquals_Object;
		public virtual RMethod RMEquals_Object
		{
			get
			{
				if(r_MEquals_Object == null)
				{
					r_MEquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_MEquals_Object.SetBelong(this.instance);
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_MFinalize;
		public virtual RMethod RMFinalize
		{
			get
			{
				if(r_MFinalize == null)
				{
					r_MFinalize = new(this, "Finalize", 0);
					r_MFinalize.SetBelong(this.instance);
				}
				return r_MFinalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_MGetHashCode;
		public virtual RMethod RMGetHashCode
		{
			get
			{
				if(r_MGetHashCode == null)
				{
					r_MGetHashCode = new(this, "GetHashCode", 0);
					r_MGetHashCode.SetBelong(this.instance);
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_MGetType;
		public virtual RMethod RMGetType
		{
			get
			{
				if(r_MGetType == null)
				{
					r_MGetType = new(this, "GetType", 0);
					r_MGetType.SetBelong(this.instance);
				}
				return r_MGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MMemberwiseClone;
		public virtual RMethod RMMemberwiseClone
		{
			get
			{
				if(r_MMemberwiseClone == null)
				{
					r_MMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_MToString;
		public virtual RMethod RMToString
		{
			get
			{
				if(r_MToString == null)
				{
					r_MToString = new(this, "ToString", 0);
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
			}
		}


        public RPackageInfo() : base("UnityEditor.PackageManager.PackageInfo")
        {
        }

        public RPackageInfo(System.Object instance) : base("UnityEditor.PackageManager.PackageInfo")
		{
            SetInstance(instance);
		}

        public RPackageInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPackageInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEditor.PackageManager.PackageInfo FindForAssetPath(System.String @assetPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assetPath};
            var ___result = RMFindForAssetPath_String.Invoke(___genericsType, ___parameters);

            return (UnityEditor.PackageManager.PackageInfo)___result;
        }


        public static UnityEditor.PackageManager.PackageInfo FindForAssembly(System.Reflection.Assembly @assembly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assembly};
            var ___result = RMFindForAssembly_Assembly.Invoke(___genericsType, ___parameters);

            return (UnityEditor.PackageManager.PackageInfo)___result;
        }


        public static System.Collections.Generic.List<UnityEditor.PackageManager.PackageInfo> GetForAssemblyFilePaths(System.Collections.Generic.List<System.String> @assemblyPaths)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyPaths};
            var ___result = RMGetForAssemblyFilePaths_List_d_String_p_.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<UnityEditor.PackageManager.PackageInfo>)___result;
        }


        public static UnityEditor.PackageManager.PackageInfo[] GetAllRegisteredPackages()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAllRegisteredPackages.Invoke(___genericsType, ___parameters);

            return (UnityEditor.PackageManager.PackageInfo[])___result;
        }


        public static System.String[] GetPredefinedPackageTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPredefinedPackageTypes.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public static System.String[] GetPredefinedHiddenByDefaultPackageTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPredefinedHiddenByDefaultPackageTypes.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public static UnityEditor.PackageManager.PackageInfo GetPackageByAssetPath(System.String @assetPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assetPath};
            var ___result = RMGetPackageByAssetPath_String.Invoke(___genericsType, ___parameters);

            return (UnityEditor.PackageManager.PackageInfo)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
