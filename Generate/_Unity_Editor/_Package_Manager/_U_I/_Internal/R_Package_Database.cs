
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.Internal.PackageDatabase
	/// </summary>
    public partial class RPackageDatabase : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageDatabase");
            }
        }

        public RPackageDatabase() : base("UnityEditor.PackageManager.UI.Internal.PackageDatabase")
        {
        }

        public RPackageDatabase(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.PackageDatabase")
		{
            SetInstance(instance);
		}

        public RPackageDatabase(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPackageDatabase(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Action`2[System.String,System.String] onPackageUniqueIdFinalize
		/// </summary>
		protected REvent r_EonPackageUniqueIdFinalize;
		public virtual REvent REonPackageUniqueIdFinalize
		{
			get
			{
				if(r_EonPackageUniqueIdFinalize == null)
				{
					r_EonPackageUniqueIdFinalize = new(this, "onPackageUniqueIdFinalize");
				}
				return r_EonPackageUniqueIdFinalize;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IPackage] onVerifiedGitPackageUpToDate
		/// </summary>
		protected REvent r_EonVerifiedGitPackageUpToDate;
		public virtual REvent REonVerifiedGitPackageUpToDate
		{
			get
			{
				if(r_EonVerifiedGitPackageUpToDate == null)
				{
					r_EonVerifiedGitPackageUpToDate = new(this, "onVerifiedGitPackageUpToDate");
				}
				return r_EonVerifiedGitPackageUpToDate;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.PackagesChangeArgs] onPackagesChanged
		/// </summary>
		protected REvent r_EonPackagesChanged;
		public virtual REvent REonPackagesChanged
		{
			get
			{
				if(r_EonPackagesChanged == null)
				{
					r_EonPackagesChanged = new(this, "onPackagesChanged");
				}
				return r_EonPackagesChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.TermOfServiceAgreementStatus] onTermOfServiceAgreementStatusChange
		/// </summary>
		protected REvent r_EonTermOfServiceAgreementStatusChange;
		public virtual REvent REonTermOfServiceAgreementStatusChange
		{
			get
			{
				if(r_EonTermOfServiceAgreementStatusChange == null)
				{
					r_EonTermOfServiceAgreementStatusChange = new(this, "onTermOfServiceAgreementStatusChange");
				}
				return r_EonTermOfServiceAgreementStatusChange;
			}
		}

		/// <summary>
		/// System.Action`2[System.String,System.String] onPackageUniqueIdFinalize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString> r_FonPackageUniqueIdFinalize;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString> RFonPackageUniqueIdFinalize
		{
			get
			{
				if(r_FonPackageUniqueIdFinalize == null)
				{
					r_FonPackageUniqueIdFinalize = new(this, "onPackageUniqueIdFinalize");
				}
				return r_FonPackageUniqueIdFinalize;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IPackage] onVerifiedGitPackageUpToDate
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> r_FonVerifiedGitPackageUpToDate;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> RFonVerifiedGitPackageUpToDate
		{
			get
			{
				if(r_FonVerifiedGitPackageUpToDate == null)
				{
					r_FonVerifiedGitPackageUpToDate = new(this, "onVerifiedGitPackageUpToDate");
				}
				return r_FonVerifiedGitPackageUpToDate;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.PackagesChangeArgs] onPackagesChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackagesChangeArgs> r_FonPackagesChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackagesChangeArgs> RFonPackagesChanged
		{
			get
			{
				if(r_FonPackagesChanged == null)
				{
					r_FonPackagesChanged = new(this, "onPackagesChanged");
				}
				return r_FonPackagesChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.TermOfServiceAgreementStatus] onTermOfServiceAgreementStatusChange
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RTermOfServiceAgreementStatus> r_FonTermOfServiceAgreementStatusChange;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RTermOfServiceAgreementStatus> RFonTermOfServiceAgreementStatusChange
		{
			get
			{
				if(r_FonTermOfServiceAgreementStatusChange == null)
				{
					r_FonTermOfServiceAgreementStatusChange = new(this, "onTermOfServiceAgreementStatusChange");
				}
				return r_FonTermOfServiceAgreementStatusChange;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEditor.PackageManager.UI.Internal.IPackage] m_Packages
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> r_Fm_Packages;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> RFm_Packages
		{
			get
			{
				if(r_Fm_Packages == null)
				{
					r_Fm_Packages = new(this, "m_Packages");
				}
				return r_Fm_Packages;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEditor.PackageManager.UI.Internal.IPackage] m_Features
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> r_Fm_Features;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> RFm_Features
		{
			get
			{
				if(r_Fm_Features == null)
				{
					r_Fm_Features = new(this, "m_Features");
				}
				return r_Fm_Features;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Sample]] m_ParsedSamples
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RSample>> r_Fm_ParsedSamples;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RSample>> RFm_ParsedSamples
		{
			get
			{
				if(r_Fm_ParsedSamples == null)
				{
					r_Fm_ParsedSamples = new(this, "m_ParsedSamples");
				}
				return r_Fm_ParsedSamples;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.TermOfServiceAgreementStatus m_TermOfServiceAgreementStatus
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RTermOfServiceAgreementStatus r_Fm_TermOfServiceAgreementStatus;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RTermOfServiceAgreementStatus RFm_TermOfServiceAgreementStatus
		{
			get
			{
				if(r_Fm_TermOfServiceAgreementStatus == null)
				{
					r_Fm_TermOfServiceAgreementStatus = new(this, "m_TermOfServiceAgreementStatus");
				}
				return r_Fm_TermOfServiceAgreementStatus;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.UpmPackage] m_SerializedUpmPackages
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmPackage> r_Fm_SerializedUpmPackages;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmPackage> RFm_SerializedUpmPackages
		{
			get
			{
				if(r_Fm_SerializedUpmPackages == null)
				{
					r_Fm_SerializedUpmPackages = new(this, "m_SerializedUpmPackages");
				}
				return r_Fm_SerializedUpmPackages;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.AssetStorePackage] m_SerializedAssetStorePackages
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePackage> r_Fm_SerializedAssetStorePackages;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePackage> RFm_SerializedAssetStorePackages
		{
			get
			{
				if(r_Fm_SerializedAssetStorePackages == null)
				{
					r_Fm_SerializedAssetStorePackages = new(this, "m_SerializedAssetStorePackages");
				}
				return r_Fm_SerializedAssetStorePackages;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.PlaceholderPackage] m_SerializedPlaceholderPackages
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPlaceholderPackage> r_Fm_SerializedPlaceholderPackages;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPlaceholderPackage> RFm_SerializedPlaceholderPackages
		{
			get
			{
				if(r_Fm_SerializedPlaceholderPackages == null)
				{
					r_Fm_SerializedPlaceholderPackages = new(this, "m_SerializedPlaceholderPackages");
				}
				return r_Fm_SerializedPlaceholderPackages;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UnityConnectProxy m_UnityConnect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityConnectProxy r_Fm_UnityConnect;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityConnectProxy RFm_UnityConnect
		{
			get
			{
				if(r_Fm_UnityConnect == null)
				{
					r_Fm_UnityConnect = new(this, "m_UnityConnect");
				}
				return r_Fm_UnityConnect;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetDatabaseProxy m_AssetDatabase
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetDatabaseProxy r_Fm_AssetDatabase;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetDatabaseProxy RFm_AssetDatabase
		{
			get
			{
				if(r_Fm_AssetDatabase == null)
				{
					r_Fm_AssetDatabase = new(this, "m_AssetDatabase");
				}
				return r_Fm_AssetDatabase;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreClient m_AssetStoreClient
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreClient r_Fm_AssetStoreClient;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreClient RFm_AssetStoreClient
		{
			get
			{
				if(r_Fm_AssetStoreClient == null)
				{
					r_Fm_AssetStoreClient = new(this, "m_AssetStoreClient");
				}
				return r_Fm_AssetStoreClient;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadManager m_AssetStoreDownloadManager
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreDownloadManager r_Fm_AssetStoreDownloadManager;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreDownloadManager RFm_AssetStoreDownloadManager
		{
			get
			{
				if(r_Fm_AssetStoreDownloadManager == null)
				{
					r_Fm_AssetStoreDownloadManager = new(this, "m_AssetStoreDownloadManager");
				}
				return r_Fm_AssetStoreDownloadManager;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmCache m_UpmCache
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmCache r_Fm_UpmCache;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmCache RFm_UpmCache
		{
			get
			{
				if(r_Fm_UpmCache == null)
				{
					r_Fm_UpmCache = new(this, "m_UpmCache");
				}
				return r_Fm_UpmCache;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmClient m_UpmClient
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmClient r_Fm_UpmClient;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmClient RFm_UpmClient
		{
			get
			{
				if(r_Fm_UpmClient == null)
				{
					r_Fm_UpmClient = new(this, "m_UpmClient");
				}
				return r_Fm_UpmClient;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IOProxy m_IOProxy
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOProxy r_Fm_IOProxy;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOProxy RFm_IOProxy
		{
			get
			{
				if(r_Fm_IOProxy == null)
				{
					r_Fm_IOProxy = new(this, "m_IOProxy");
				}
				return r_Fm_IOProxy;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreUtils m_AssetStoreUtils
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUtils r_Fm_AssetStoreUtils;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUtils RFm_AssetStoreUtils
		{
			get
			{
				if(r_Fm_AssetStoreUtils == null)
				{
					r_Fm_AssetStoreUtils = new(this, "m_AssetStoreUtils");
				}
				return r_Fm_AssetStoreUtils;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackage[] k_EmptyList
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> r_Fk_EmptyList;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> RFk_EmptyList
		{
			get
			{
				if(r_Fk_EmptyList == null)
				{
					r_Fk_EmptyList = new(Type, "k_EmptyList");
				}
				return r_Fk_EmptyList;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.TermOfServiceAgreementStatus termOfServiceAgreementStatus
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RTermOfServiceAgreementStatus r_PtermOfServiceAgreementStatus;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RTermOfServiceAgreementStatus RPtermOfServiceAgreementStatus
		{
			get
			{
				if(r_PtermOfServiceAgreementStatus == null)
				{
					r_PtermOfServiceAgreementStatus = new(this, "termOfServiceAgreementStatus", -1);
				}
				return r_PtermOfServiceAgreementStatus;
			}
		}

		/// <summary>
		/// Boolean isEmpty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisEmpty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisEmpty
		{
			get
			{
				if(r_PisEmpty == null)
				{
					r_PisEmpty = new(this, "isEmpty", -1);
				}
				return r_PisEmpty;
			}
		}

		/// <summary>
		/// Boolean isInstallOrUninstallInProgress
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisInstallOrUninstallInProgress;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisInstallOrUninstallInProgress
		{
			get
			{
				if(r_PisInstallOrUninstallInProgress == null)
				{
					r_PisInstallOrUninstallInProgress = new(this, "isInstallOrUninstallInProgress", -1);
				}
				return r_PisInstallOrUninstallInProgress;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage] allPackages
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> r_PallPackages;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> RPallPackages
		{
			get
			{
				if(r_PallPackages == null)
				{
					r_PallPackages = new(this, "allPackages", -1);
				}
				return r_PallPackages;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage] packagesInError
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> r_PpackagesInError;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> RPpackagesInError
		{
			get
			{
				if(r_PpackagesInError == null)
				{
					r_PpackagesInError = new(this, "packagesInError", -1);
				}
				return r_PpackagesInError;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.UnityConnectProxy, UnityEditor.PackageManager.UI.Internal.AssetDatabaseProxy, UnityEditor.PackageManager.UI.Internal.AssetStoreUtils, UnityEditor.PackageManager.UI.Internal.AssetStoreClient, UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadManager, UnityEditor.PackageManager.UI.Internal.UpmCache, UnityEditor.PackageManager.UI.Internal.UpmClient, UnityEditor.PackageManager.UI.Internal.IOProxy)
		/// </summary>
		protected RMethod r_MResolveDependencies_UnityConnectProxy_AssetDatabaseProxy_AssetStoreUtils_AssetStoreClient_AssetStoreDownloadManager_UpmCache_UpmClient_IOProxy;
		public virtual RMethod RMResolveDependencies_UnityConnectProxy_AssetDatabaseProxy_AssetStoreUtils_AssetStoreClient_AssetStoreDownloadManager_UpmCache_UpmClient_IOProxy
		{
			get
			{
				if(r_MResolveDependencies_UnityConnectProxy_AssetDatabaseProxy_AssetStoreUtils_AssetStoreClient_AssetStoreDownloadManager_UpmCache_UpmClient_IOProxy == null)
				{
					r_MResolveDependencies_UnityConnectProxy_AssetDatabaseProxy_AssetStoreUtils_AssetStoreClient_AssetStoreDownloadManager_UpmCache_UpmClient_IOProxy = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UnityConnectProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetDatabaseProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreUtils"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreClient"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadManager"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmCache"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmClient"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOProxy"));
				}
				return r_MResolveDependencies_UnityConnectProxy_AssetDatabaseProxy_AssetStoreUtils_AssetStoreClient_AssetStoreDownloadManager_UpmCache_UpmClient_IOProxy;
			}
		}

		/// <summary>
		/// Boolean IsUninstallInProgress(UnityEditor.PackageManager.UI.Internal.IPackage)
		/// </summary>
		protected RMethod r_MIsUninstallInProgress_IPackage;
		public virtual RMethod RMIsUninstallInProgress_IPackage
		{
			get
			{
				if(r_MIsUninstallInProgress_IPackage == null)
				{
					r_MIsUninstallInProgress_IPackage = new(this, "IsUninstallInProgress", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"));
				}
				return r_MIsUninstallInProgress_IPackage;
			}
		}

		/// <summary>
		/// Boolean IsInstallInProgress(UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MIsInstallInProgress_IPackageVersion;
		public virtual RMethod RMIsInstallInProgress_IPackageVersion
		{
			get
			{
				if(r_MIsInstallInProgress_IPackageVersion == null)
				{
					r_MIsInstallInProgress_IPackageVersion = new(this, "IsInstallInProgress", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
				}
				return r_MIsInstallInProgress_IPackageVersion;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackage GetPackage(System.String)
		/// </summary>
		protected RMethod r_MGetPackage_String;
		public virtual RMethod RMGetPackage_String
		{
			get
			{
				if(r_MGetPackage_String == null)
				{
					r_MGetPackage_String = new(this, "GetPackage", 0, typeof(System.String));
				}
				return r_MGetPackage_String;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackage GetPackage(UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MGetPackage_IPackageVersion;
		public virtual RMethod RMGetPackage_IPackageVersion
		{
			get
			{
				if(r_MGetPackage_IPackageVersion == null)
				{
					r_MGetPackage_IPackageVersion = new(this, "GetPackage", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
				}
				return r_MGetPackage_IPackageVersion;
			}
		}

		/// <summary>
		/// Void GetPackageAndVersionByIdOrName(System.String, UnityEditor.PackageManager.UI.Internal.IPackage ByRef, UnityEditor.PackageManager.UI.Internal.IPackageVersion ByRef)
		/// </summary>
		protected RMethod r_MGetPackageAndVersionByIdOrName_String_Out_IPackage_Out_IPackageVersion;
		public virtual RMethod RMGetPackageAndVersionByIdOrName_String_Out_IPackage_Out_IPackageVersion
		{
			get
			{
				if(r_MGetPackageAndVersionByIdOrName_String_Out_IPackage_Out_IPackageVersion == null)
				{
					r_MGetPackageAndVersionByIdOrName_String_Out_IPackage_Out_IPackageVersion = new(this, "GetPackageAndVersionByIdOrName", 0, typeof(System.String),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage").MakeByRefType(),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion").MakeByRefType());
				}
				return r_MGetPackageAndVersionByIdOrName_String_Out_IPackage_Out_IPackageVersion;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackage GetPackageByIdOrName(System.String)
		/// </summary>
		protected RMethod r_MGetPackageByIdOrName_String;
		public virtual RMethod RMGetPackageByIdOrName_String
		{
			get
			{
				if(r_MGetPackageByIdOrName_String == null)
				{
					r_MGetPackageByIdOrName_String = new(this, "GetPackageByIdOrName", 0, typeof(System.String));
				}
				return r_MGetPackageByIdOrName_String;
			}
		}

		/// <summary>
		/// Void GetPackageAndVersion(System.String, System.String, UnityEditor.PackageManager.UI.Internal.IPackage ByRef, UnityEditor.PackageManager.UI.Internal.IPackageVersion ByRef)
		/// </summary>
		protected RMethod r_MGetPackageAndVersion_String_String_Out_IPackage_Out_IPackageVersion;
		public virtual RMethod RMGetPackageAndVersion_String_String_Out_IPackage_Out_IPackageVersion
		{
			get
			{
				if(r_MGetPackageAndVersion_String_String_Out_IPackage_Out_IPackageVersion == null)
				{
					r_MGetPackageAndVersion_String_String_Out_IPackage_Out_IPackageVersion = new(this, "GetPackageAndVersion", 0, typeof(System.String), typeof(System.String),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage").MakeByRefType(),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion").MakeByRefType());
				}
				return r_MGetPackageAndVersion_String_String_Out_IPackage_Out_IPackageVersion;
			}
		}

		/// <summary>
		/// Void GetPackageAndVersion(UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair, UnityEditor.PackageManager.UI.Internal.IPackage ByRef, UnityEditor.PackageManager.UI.Internal.IPackageVersion ByRef)
		/// </summary>
		protected RMethod r_MGetPackageAndVersion_PackageAndVersionIdPair_Out_IPackage_Out_IPackageVersion;
		public virtual RMethod RMGetPackageAndVersion_PackageAndVersionIdPair_Out_IPackage_Out_IPackageVersion
		{
			get
			{
				if(r_MGetPackageAndVersion_PackageAndVersionIdPair_Out_IPackage_Out_IPackageVersion == null)
				{
					r_MGetPackageAndVersion_PackageAndVersionIdPair_Out_IPackage_Out_IPackageVersion = new(this, "GetPackageAndVersion", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage").MakeByRefType(),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion").MakeByRefType());
				}
				return r_MGetPackageAndVersion_PackageAndVersionIdPair_Out_IPackage_Out_IPackageVersion;
			}
		}

		/// <summary>
		/// Void GetPackageAndVersion(UnityEditor.PackageManager.DependencyInfo, UnityEditor.PackageManager.UI.Internal.IPackage ByRef, UnityEditor.PackageManager.UI.Internal.IPackageVersion ByRef)
		/// </summary>
		protected RMethod r_MGetPackageAndVersion_DependencyInfo_Out_IPackage_Out_IPackageVersion;
		public virtual RMethod RMGetPackageAndVersion_DependencyInfo_Out_IPackage_Out_IPackageVersion
		{
			get
			{
				if(r_MGetPackageAndVersion_DependencyInfo_Out_IPackage_Out_IPackageVersion == null)
				{
					r_MGetPackageAndVersion_DependencyInfo_Out_IPackage_Out_IPackageVersion = new(this, "GetPackageAndVersion", 0, typeof(UnityEditor.PackageManager.DependencyInfo),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage").MakeByRefType(),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion").MakeByRefType());
				}
				return r_MGetPackageAndVersion_DependencyInfo_Out_IPackage_Out_IPackageVersion;
			}
		}

		/// <summary>
		/// Void GetUpmPackageAndVersion(System.String, System.String, UnityEditor.PackageManager.UI.Internal.IPackage ByRef, UnityEditor.PackageManager.UI.Internal.IPackageVersion ByRef)
		/// </summary>
		protected RMethod r_MGetUpmPackageAndVersion_String_String_Out_IPackage_Out_IPackageVersion;
		public virtual RMethod RMGetUpmPackageAndVersion_String_String_Out_IPackage_Out_IPackageVersion
		{
			get
			{
				if(r_MGetUpmPackageAndVersion_String_String_Out_IPackage_Out_IPackageVersion == null)
				{
					r_MGetUpmPackageAndVersion_String_String_Out_IPackage_Out_IPackageVersion = new(this, "GetUpmPackageAndVersion", 0, typeof(System.String), typeof(System.String),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage").MakeByRefType(),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion").MakeByRefType());
				}
				return r_MGetUpmPackageAndVersion_String_String_Out_IPackage_Out_IPackageVersion;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackageVersion] GetReverseDependencies(UnityEditor.PackageManager.UI.Internal.IPackageVersion, Boolean)
		/// </summary>
		protected RMethod r_MGetReverseDependencies_IPackageVersion_Boolean;
		public virtual RMethod RMGetReverseDependencies_IPackageVersion_Boolean
		{
			get
			{
				if(r_MGetReverseDependencies_IPackageVersion_Boolean == null)
				{
					r_MGetReverseDependencies_IPackageVersion_Boolean = new(this, "GetReverseDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"), typeof(System.Boolean));
				}
				return r_MGetReverseDependencies_IPackageVersion_Boolean;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackageVersion] GetFeaturesThatUseThisPackage(UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MGetFeaturesThatUseThisPackage_IPackageVersion;
		public virtual RMethod RMGetFeaturesThatUseThisPackage_IPackageVersion
		{
			get
			{
				if(r_MGetFeaturesThatUseThisPackage_IPackageVersion == null)
				{
					r_MGetFeaturesThatUseThisPackage_IPackageVersion = new(this, "GetFeaturesThatUseThisPackage", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
				}
				return r_MGetFeaturesThatUseThisPackage_IPackageVersion;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackage[] GetCustomizedDependencies(UnityEditor.PackageManager.UI.Internal.IPackageVersion, System.Nullable`1[System.Boolean])
		/// </summary>
		protected RMethod r_MGetCustomizedDependencies_IPackageVersion_Nullable_d_Boolean_p_;
		public virtual RMethod RMGetCustomizedDependencies_IPackageVersion_Nullable_d_Boolean_p_
		{
			get
			{
				if(r_MGetCustomizedDependencies_IPackageVersion_Nullable_d_Boolean_p_ == null)
				{
					r_MGetCustomizedDependencies_IPackageVersion_Nullable_d_Boolean_p_ = new(this, "GetCustomizedDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"),  ReflectionUtils.GetType("System.Nullable`1").MakeGenericType(typeof(System.Boolean)));
				}
				return r_MGetCustomizedDependencies_IPackageVersion_Nullable_d_Boolean_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Sample] GetSamples(UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MGetSamples_IPackageVersion;
		public virtual RMethod RMGetSamples_IPackageVersion
		{
			get
			{
				if(r_MGetSamples_IPackageVersion == null)
				{
					r_MGetSamples_IPackageVersion = new(this, "GetSamples", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
				}
				return r_MGetSamples_IPackageVersion;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion GetPackageInFeatureVersion(System.String)
		/// </summary>
		protected RMethod r_MGetPackageInFeatureVersion_String;
		public virtual RMethod RMGetPackageInFeatureVersion_String
		{
			get
			{
				if(r_MGetPackageInFeatureVersion_String == null)
				{
					r_MGetPackageInFeatureVersion_String = new(this, "GetPackageInFeatureVersion", 0, typeof(System.String));
				}
				return r_MGetPackageInFeatureVersion_String;
			}
		}

		/// <summary>
		/// Void OnAfterDeserialize()
		/// </summary>
		protected RMethod r_MOnAfterDeserialize;
		public virtual RMethod RMOnAfterDeserialize
		{
			get
			{
				if(r_MOnAfterDeserialize == null)
				{
					r_MOnAfterDeserialize = new(this, "OnAfterDeserialize", 0);
				}
				return r_MOnAfterDeserialize;
			}
		}

		/// <summary>
		/// Void OnBeforeSerialize()
		/// </summary>
		protected RMethod r_MOnBeforeSerialize;
		public virtual RMethod RMOnBeforeSerialize
		{
			get
			{
				if(r_MOnBeforeSerialize == null)
				{
					r_MOnBeforeSerialize = new(this, "OnBeforeSerialize", 0);
				}
				return r_MOnBeforeSerialize;
			}
		}

		/// <summary>
		/// Void TriggerOnPackagesChanged(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage], System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage], System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage], System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage], System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage])
		/// </summary>
		protected RMethod r_MTriggerOnPackagesChanged_IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p_;
		public virtual RMethod RMTriggerOnPackagesChanged_IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p_
		{
			get
			{
				if(r_MTriggerOnPackagesChanged_IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p_ == null)
				{
					r_MTriggerOnPackagesChanged_IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p_ = new(this, "TriggerOnPackagesChanged", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage")),  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage")),  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage")),  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage")),  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage")));
				}
				return r_MTriggerOnPackagesChanged_IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p_;
			}
		}

		/// <summary>
		/// Void AddPackageError(UnityEditor.PackageManager.UI.Internal.IPackage, UnityEditor.PackageManager.UI.Internal.UIError)
		/// </summary>
		protected RMethod r_MAddPackageError_IPackage_UIError;
		public virtual RMethod RMAddPackageError_IPackage_UIError
		{
			get
			{
				if(r_MAddPackageError_IPackage_UIError == null)
				{
					r_MAddPackageError_IPackage_UIError = new(this, "AddPackageError", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError"));
				}
				return r_MAddPackageError_IPackage_UIError;
			}
		}

		/// <summary>
		/// Void ClearPackageErrors(UnityEditor.PackageManager.UI.Internal.IPackage, System.Predicate`1[UnityEditor.PackageManager.UI.Internal.UIError])
		/// </summary>
		protected RMethod r_MClearPackageErrors_IPackage_Predicate_d_UIError_p_;
		public virtual RMethod RMClearPackageErrors_IPackage_Predicate_d_UIError_p_
		{
			get
			{
				if(r_MClearPackageErrors_IPackage_Predicate_d_UIError_p_ == null)
				{
					r_MClearPackageErrors_IPackage_Predicate_d_UIError_p_ = new(this, "ClearPackageErrors", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"),  ReflectionUtils.GetType("System.Predicate`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError")));
				}
				return r_MClearPackageErrors_IPackage_Predicate_d_UIError_p_;
			}
		}

		/// <summary>
		/// Void SetPackagesProgress(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage], UnityEditor.PackageManager.UI.Internal.PackageProgress)
		/// </summary>
		protected RMethod r_MSetPackagesProgress_IEnumerable_d_IPackage_p__PackageProgress;
		public virtual RMethod RMSetPackagesProgress_IEnumerable_d_IPackage_p__PackageProgress
		{
			get
			{
				if(r_MSetPackagesProgress_IEnumerable_d_IPackage_p__PackageProgress == null)
				{
					r_MSetPackagesProgress_IEnumerable_d_IPackage_p__PackageProgress = new(this, "SetPackagesProgress", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage")),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageProgress"));
				}
				return r_MSetPackagesProgress_IEnumerable_d_IPackage_p__PackageProgress;
			}
		}

		/// <summary>
		/// Void SetPackageProgress(UnityEditor.PackageManager.UI.Internal.IPackage, UnityEditor.PackageManager.UI.Internal.PackageProgress)
		/// </summary>
		protected RMethod r_MSetPackageProgress_IPackage_PackageProgress;
		public virtual RMethod RMSetPackageProgress_IPackage_PackageProgress
		{
			get
			{
				if(r_MSetPackageProgress_IPackage_PackageProgress == null)
				{
					r_MSetPackageProgress_IPackage_PackageProgress = new(this, "SetPackageProgress", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageProgress"));
				}
				return r_MSetPackageProgress_IPackage_PackageProgress;
			}
		}

		/// <summary>
		/// Void OnEnable()
		/// </summary>
		protected RMethod r_MOnEnable;
		public virtual RMethod RMOnEnable
		{
			get
			{
				if(r_MOnEnable == null)
				{
					r_MOnEnable = new(this, "OnEnable", 0);
				}
				return r_MOnEnable;
			}
		}

		/// <summary>
		/// Void OnDisable()
		/// </summary>
		protected RMethod r_MOnDisable;
		public virtual RMethod RMOnDisable
		{
			get
			{
				if(r_MOnDisable == null)
				{
					r_MOnDisable = new(this, "OnDisable", 0);
				}
				return r_MOnDisable;
			}
		}

		/// <summary>
		/// Void Reload()
		/// </summary>
		protected RMethod r_MReload;
		public virtual RMethod RMReload
		{
			get
			{
				if(r_MReload == null)
				{
					r_MReload = new(this, "Reload", 0);
				}
				return r_MReload;
			}
		}

		/// <summary>
		/// Void OnDownloadProgress(UnityEditor.PackageManager.UI.Internal.IOperation)
		/// </summary>
		protected RMethod r_MOnDownloadProgress_IOperation;
		public virtual RMethod RMOnDownloadProgress_IOperation
		{
			get
			{
				if(r_MOnDownloadProgress_IOperation == null)
				{
					r_MOnDownloadProgress_IOperation = new(this, "OnDownloadProgress", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"));
				}
				return r_MOnDownloadProgress_IOperation;
			}
		}

		/// <summary>
		/// Void OnDownloadFinalized(UnityEditor.PackageManager.UI.Internal.IOperation)
		/// </summary>
		protected RMethod r_MOnDownloadFinalized_IOperation;
		public virtual RMethod RMOnDownloadFinalized_IOperation
		{
			get
			{
				if(r_MOnDownloadFinalized_IOperation == null)
				{
					r_MOnDownloadFinalized_IOperation = new(this, "OnDownloadFinalized", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"));
				}
				return r_MOnDownloadFinalized_IOperation;
			}
		}

		/// <summary>
		/// Void OnDownloadError(UnityEditor.PackageManager.UI.Internal.IOperation, UnityEditor.PackageManager.UI.Internal.UIError)
		/// </summary>
		protected RMethod r_MOnDownloadError_IOperation_UIError;
		public virtual RMethod RMOnDownloadError_IOperation_UIError
		{
			get
			{
				if(r_MOnDownloadError_IOperation_UIError == null)
				{
					r_MOnDownloadError_IOperation_UIError = new(this, "OnDownloadError", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError"));
				}
				return r_MOnDownloadError_IOperation_UIError;
			}
		}

		/// <summary>
		/// Void OnDownloadPaused(UnityEditor.PackageManager.UI.Internal.IOperation)
		/// </summary>
		protected RMethod r_MOnDownloadPaused_IOperation;
		public virtual RMethod RMOnDownloadPaused_IOperation
		{
			get
			{
				if(r_MOnDownloadPaused_IOperation == null)
				{
					r_MOnDownloadPaused_IOperation = new(this, "OnDownloadPaused", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"));
				}
				return r_MOnDownloadPaused_IOperation;
			}
		}

		/// <summary>
		/// Void OnUserLoginStateChange(Boolean, Boolean)
		/// </summary>
		protected RMethod r_MOnUserLoginStateChange_Boolean_Boolean;
		public virtual RMethod RMOnUserLoginStateChange_Boolean_Boolean
		{
			get
			{
				if(r_MOnUserLoginStateChange_Boolean_Boolean == null)
				{
					r_MOnUserLoginStateChange_Boolean_Boolean = new(this, "OnUserLoginStateChange", 0, typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MOnUserLoginStateChange_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void OnVerifiedGitPackageUpToDate(System.String)
		/// </summary>
		protected RMethod r_MOnVerifiedGitPackageUpToDate_String;
		public virtual RMethod RMOnVerifiedGitPackageUpToDate_String
		{
			get
			{
				if(r_MOnVerifiedGitPackageUpToDate_String == null)
				{
					r_MOnVerifiedGitPackageUpToDate_String = new(this, "OnVerifiedGitPackageUpToDate", 0, typeof(System.String));
				}
				return r_MOnVerifiedGitPackageUpToDate_String;
			}
		}

		/// <summary>
		/// Void OnAssetStorePackagesChanged(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage])
		/// </summary>
		protected RMethod r_MOnAssetStorePackagesChanged_IEnumerable_d_IPackage_p_;
		public virtual RMethod RMOnAssetStorePackagesChanged_IEnumerable_d_IPackage_p_
		{
			get
			{
				if(r_MOnAssetStorePackagesChanged_IEnumerable_d_IPackage_p_ == null)
				{
					r_MOnAssetStorePackagesChanged_IEnumerable_d_IPackage_p_ = new(this, "OnAssetStorePackagesChanged", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage")));
				}
				return r_MOnAssetStorePackagesChanged_IEnumerable_d_IPackage_p_;
			}
		}

		/// <summary>
		/// Void OnPackagesChanged(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage])
		/// </summary>
		protected RMethod r_MOnPackagesChanged_IEnumerable_d_IPackage_p_;
		public virtual RMethod RMOnPackagesChanged_IEnumerable_d_IPackage_p_
		{
			get
			{
				if(r_MOnPackagesChanged_IEnumerable_d_IPackage_p_ == null)
				{
					r_MOnPackagesChanged_IEnumerable_d_IPackage_p_ = new(this, "OnPackagesChanged", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage")));
				}
				return r_MOnPackagesChanged_IEnumerable_d_IPackage_p_;
			}
		}

		/// <summary>
		/// Void RemovePackage(System.String)
		/// </summary>
		protected RMethod r_MRemovePackage_String;
		public virtual RMethod RMRemovePackage_String
		{
			get
			{
				if(r_MRemovePackage_String == null)
				{
					r_MRemovePackage_String = new(this, "RemovePackage", 0, typeof(System.String));
				}
				return r_MRemovePackage_String;
			}
		}

		/// <summary>
		/// Void AddPackage(System.String, UnityEditor.PackageManager.UI.Internal.IPackage)
		/// </summary>
		protected RMethod r_MAddPackage_String_IPackage;
		public virtual RMethod RMAddPackage_String_IPackage
		{
			get
			{
				if(r_MAddPackage_String_IPackage == null)
				{
					r_MAddPackage_String_IPackage = new(this, "AddPackage", 0, typeof(System.String),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"));
				}
				return r_MAddPackage_String_IPackage;
			}
		}

		/// <summary>
		/// Void OnUpmAddAndRemoveOperation(UnityEditor.PackageManager.UI.Internal.UpmAddAndRemoveOperation)
		/// </summary>
		protected RMethod r_MOnUpmAddAndRemoveOperation_UpmAddAndRemoveOperation;
		public virtual RMethod RMOnUpmAddAndRemoveOperation_UpmAddAndRemoveOperation
		{
			get
			{
				if(r_MOnUpmAddAndRemoveOperation_UpmAddAndRemoveOperation == null)
				{
					r_MOnUpmAddAndRemoveOperation_UpmAddAndRemoveOperation = new(this, "OnUpmAddAndRemoveOperation", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmAddAndRemoveOperation"));
				}
				return r_MOnUpmAddAndRemoveOperation_UpmAddAndRemoveOperation;
			}
		}

		/// <summary>
		/// Void OnUpmAddOperation(UnityEditor.PackageManager.UI.Internal.IOperation)
		/// </summary>
		protected RMethod r_MOnUpmAddOperation_IOperation;
		public virtual RMethod RMOnUpmAddOperation_IOperation
		{
			get
			{
				if(r_MOnUpmAddOperation_IOperation == null)
				{
					r_MOnUpmAddOperation_IOperation = new(this, "OnUpmAddOperation", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"));
				}
				return r_MOnUpmAddOperation_IOperation;
			}
		}

		/// <summary>
		/// Void RemoveSpecialInstallation(System.String)
		/// </summary>
		protected RMethod r_MRemoveSpecialInstallation_String;
		public virtual RMethod RMRemoveSpecialInstallation_String
		{
			get
			{
				if(r_MRemoveSpecialInstallation_String == null)
				{
					r_MRemoveSpecialInstallation_String = new(this, "RemoveSpecialInstallation", 0, typeof(System.String));
				}
				return r_MRemoveSpecialInstallation_String;
			}
		}

		/// <summary>
		/// Void OnUpmEmbedOperation(UnityEditor.PackageManager.UI.Internal.IOperation)
		/// </summary>
		protected RMethod r_MOnUpmEmbedOperation_IOperation;
		public virtual RMethod RMOnUpmEmbedOperation_IOperation
		{
			get
			{
				if(r_MOnUpmEmbedOperation_IOperation == null)
				{
					r_MOnUpmEmbedOperation_IOperation = new(this, "OnUpmEmbedOperation", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"));
				}
				return r_MOnUpmEmbedOperation_IOperation;
			}
		}

		/// <summary>
		/// Void OnUpmRemoveOperation(UnityEditor.PackageManager.UI.Internal.IOperation)
		/// </summary>
		protected RMethod r_MOnUpmRemoveOperation_IOperation;
		public virtual RMethod RMOnUpmRemoveOperation_IOperation
		{
			get
			{
				if(r_MOnUpmRemoveOperation_IOperation == null)
				{
					r_MOnUpmRemoveOperation_IOperation = new(this, "OnUpmRemoveOperation", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"));
				}
				return r_MOnUpmRemoveOperation_IOperation;
			}
		}

		/// <summary>
		/// Void OnUpmOperationError(UnityEditor.PackageManager.UI.Internal.IOperation, UnityEditor.PackageManager.UI.Internal.UIError)
		/// </summary>
		protected RMethod r_MOnUpmOperationError_IOperation_UIError;
		public virtual RMethod RMOnUpmOperationError_IOperation_UIError
		{
			get
			{
				if(r_MOnUpmOperationError_IOperation_UIError == null)
				{
					r_MOnUpmOperationError_IOperation_UIError = new(this, "OnUpmOperationError", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError"));
				}
				return r_MOnUpmOperationError_IOperation_UIError;
			}
		}

		/// <summary>
		/// Void OnUpmOperationFinalized(UnityEditor.PackageManager.UI.Internal.IOperation)
		/// </summary>
		protected RMethod r_MOnUpmOperationFinalized_IOperation;
		public virtual RMethod RMOnUpmOperationFinalized_IOperation
		{
			get
			{
				if(r_MOnUpmOperationFinalized_IOperation == null)
				{
					r_MOnUpmOperationFinalized_IOperation = new(this, "OnUpmOperationFinalized", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"));
				}
				return r_MOnUpmOperationFinalized_IOperation;
			}
		}

		/// <summary>
		/// Void ClearSamplesCache()
		/// </summary>
		protected RMethod r_MClearSamplesCache;
		public virtual RMethod RMClearSamplesCache
		{
			get
			{
				if(r_MClearSamplesCache == null)
				{
					r_MClearSamplesCache = new(this, "ClearSamplesCache", 0);
				}
				return r_MClearSamplesCache;
			}
		}

		/// <summary>
		/// Void Install(UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MInstall_IPackageVersion;
		public virtual RMethod RMInstall_IPackageVersion
		{
			get
			{
				if(r_MInstall_IPackageVersion == null)
				{
					r_MInstall_IPackageVersion = new(this, "Install", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
				}
				return r_MInstall_IPackageVersion;
			}
		}

		/// <summary>
		/// Void Install(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackageVersion])
		/// </summary>
		protected RMethod r_MInstall_IEnumerable_d_IPackageVersion_p_;
		public virtual RMethod RMInstall_IEnumerable_d_IPackageVersion_p_
		{
			get
			{
				if(r_MInstall_IEnumerable_d_IPackageVersion_p_ == null)
				{
					r_MInstall_IEnumerable_d_IPackageVersion_p_ = new(this, "Install", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion")));
				}
				return r_MInstall_IEnumerable_d_IPackageVersion_p_;
			}
		}

		/// <summary>
		/// Void Install(System.String)
		/// </summary>
		protected RMethod r_MInstall_String;
		public virtual RMethod RMInstall_String
		{
			get
			{
				if(r_MInstall_String == null)
				{
					r_MInstall_String = new(this, "Install", 0, typeof(System.String));
				}
				return r_MInstall_String;
			}
		}

		/// <summary>
		/// Void InstallFromUrl(System.String)
		/// </summary>
		protected RMethod r_MInstallFromUrl_String;
		public virtual RMethod RMInstallFromUrl_String
		{
			get
			{
				if(r_MInstallFromUrl_String == null)
				{
					r_MInstallFromUrl_String = new(this, "InstallFromUrl", 0, typeof(System.String));
				}
				return r_MInstallFromUrl_String;
			}
		}

		/// <summary>
		/// Boolean InstallFromPath(System.String, System.String ByRef)
		/// </summary>
		protected RMethod r_MInstallFromPath_String_Out_String;
		public virtual RMethod RMInstallFromPath_String_Out_String
		{
			get
			{
				if(r_MInstallFromPath_String_Out_String == null)
				{
					r_MInstallFromPath_String_Out_String = new(this, "InstallFromPath", 0, typeof(System.String), typeof(System.String).MakeByRefType());
				}
				return r_MInstallFromPath_String_Out_String;
			}
		}

		/// <summary>
		/// Void Uninstall(UnityEditor.PackageManager.UI.Internal.IPackage)
		/// </summary>
		protected RMethod r_MUninstall_IPackage;
		public virtual RMethod RMUninstall_IPackage
		{
			get
			{
				if(r_MUninstall_IPackage == null)
				{
					r_MUninstall_IPackage = new(this, "Uninstall", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"));
				}
				return r_MUninstall_IPackage;
			}
		}

		/// <summary>
		/// Void Uninstall(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage])
		/// </summary>
		protected RMethod r_MUninstall_IEnumerable_d_IPackage_p_;
		public virtual RMethod RMUninstall_IEnumerable_d_IPackage_p_
		{
			get
			{
				if(r_MUninstall_IEnumerable_d_IPackage_p_ == null)
				{
					r_MUninstall_IEnumerable_d_IPackage_p_ = new(this, "Uninstall", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage")));
				}
				return r_MUninstall_IEnumerable_d_IPackage_p_;
			}
		}

		/// <summary>
		/// Void InstallAndResetDependencies(UnityEditor.PackageManager.UI.Internal.IPackageVersion, System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage])
		/// </summary>
		protected RMethod r_MInstallAndResetDependencies_IPackageVersion_IEnumerable_d_IPackage_p_;
		public virtual RMethod RMInstallAndResetDependencies_IPackageVersion_IEnumerable_d_IPackage_p_
		{
			get
			{
				if(r_MInstallAndResetDependencies_IPackageVersion_IEnumerable_d_IPackage_p_ == null)
				{
					r_MInstallAndResetDependencies_IPackageVersion_IEnumerable_d_IPackage_p_ = new(this, "InstallAndResetDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"),  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage")));
				}
				return r_MInstallAndResetDependencies_IPackageVersion_IEnumerable_d_IPackage_p_;
			}
		}

		/// <summary>
		/// Void ResetDependencies(UnityEditor.PackageManager.UI.Internal.IPackageVersion, System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage])
		/// </summary>
		protected RMethod r_MResetDependencies_IPackageVersion_IEnumerable_d_IPackage_p_;
		public virtual RMethod RMResetDependencies_IPackageVersion_IEnumerable_d_IPackage_p_
		{
			get
			{
				if(r_MResetDependencies_IPackageVersion_IEnumerable_d_IPackage_p_ == null)
				{
					r_MResetDependencies_IPackageVersion_IEnumerable_d_IPackage_p_ = new(this, "ResetDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"),  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage")));
				}
				return r_MResetDependencies_IPackageVersion_IEnumerable_d_IPackage_p_;
			}
		}

		/// <summary>
		/// Void Embed(UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MEmbed_IPackageVersion;
		public virtual RMethod RMEmbed_IPackageVersion
		{
			get
			{
				if(r_MEmbed_IPackageVersion == null)
				{
					r_MEmbed_IPackageVersion = new(this, "Embed", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
				}
				return r_MEmbed_IPackageVersion;
			}
		}

		/// <summary>
		/// Void RemoveEmbedded(UnityEditor.PackageManager.UI.Internal.IPackage)
		/// </summary>
		protected RMethod r_MRemoveEmbedded_IPackage;
		public virtual RMethod RMRemoveEmbedded_IPackage
		{
			get
			{
				if(r_MRemoveEmbedded_IPackage == null)
				{
					r_MRemoveEmbedded_IPackage = new(this, "RemoveEmbedded", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"));
				}
				return r_MRemoveEmbedded_IPackage;
			}
		}

		/// <summary>
		/// Void FetchExtraInfo(UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MFetchExtraInfo_IPackageVersion;
		public virtual RMethod RMFetchExtraInfo_IPackageVersion
		{
			get
			{
				if(r_MFetchExtraInfo_IPackageVersion == null)
				{
					r_MFetchExtraInfo_IPackageVersion = new(this, "FetchExtraInfo", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
				}
				return r_MFetchExtraInfo_IPackageVersion;
			}
		}

		/// <summary>
		/// Boolean CheckTermOfServiceAgreement(System.Action, System.Action`1[UnityEditor.PackageManager.UI.Internal.UIError])
		/// </summary>
		protected RMethod r_MCheckTermOfServiceAgreement_Action_Action_d_UIError_p_;
		public virtual RMethod RMCheckTermOfServiceAgreement_Action_Action_d_UIError_p_
		{
			get
			{
				if(r_MCheckTermOfServiceAgreement_Action_Action_d_UIError_p_ == null)
				{
					r_MCheckTermOfServiceAgreement_Action_Action_d_UIError_p_ = new(this, "CheckTermOfServiceAgreement", 0, typeof(System.Action),  ReflectionUtils.GetType("System.Action`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError")));
				}
				return r_MCheckTermOfServiceAgreement_Action_Action_d_UIError_p_;
			}
		}

		/// <summary>
		/// Boolean Download(UnityEditor.PackageManager.UI.Internal.IPackage)
		/// </summary>
		protected RMethod r_MDownload_IPackage;
		public virtual RMethod RMDownload_IPackage
		{
			get
			{
				if(r_MDownload_IPackage == null)
				{
					r_MDownload_IPackage = new(this, "Download", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"));
				}
				return r_MDownload_IPackage;
			}
		}

		/// <summary>
		/// Boolean Download(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage])
		/// </summary>
		protected RMethod r_MDownload_IEnumerable_d_IPackage_p_;
		public virtual RMethod RMDownload_IEnumerable_d_IPackage_p_
		{
			get
			{
				if(r_MDownload_IEnumerable_d_IPackage_p_ == null)
				{
					r_MDownload_IEnumerable_d_IPackage_p_ = new(this, "Download", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage")));
				}
				return r_MDownload_IEnumerable_d_IPackage_p_;
			}
		}

		/// <summary>
		/// Void Download_Internal(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage])
		/// </summary>
		protected RMethod r_MDownload_Internal_IEnumerable_d_IPackage_p_;
		public virtual RMethod RMDownload_Internal_IEnumerable_d_IPackage_p_
		{
			get
			{
				if(r_MDownload_Internal_IEnumerable_d_IPackage_p_ == null)
				{
					r_MDownload_Internal_IEnumerable_d_IPackage_p_ = new(this, "Download_Internal", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage")));
				}
				return r_MDownload_Internal_IEnumerable_d_IPackage_p_;
			}
		}

		/// <summary>
		/// Void AbortDownload(UnityEditor.PackageManager.UI.Internal.IPackage)
		/// </summary>
		protected RMethod r_MAbortDownload_IPackage;
		public virtual RMethod RMAbortDownload_IPackage
		{
			get
			{
				if(r_MAbortDownload_IPackage == null)
				{
					r_MAbortDownload_IPackage = new(this, "AbortDownload", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"));
				}
				return r_MAbortDownload_IPackage;
			}
		}

		/// <summary>
		/// Void AbortDownload(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage])
		/// </summary>
		protected RMethod r_MAbortDownload_IEnumerable_d_IPackage_p_;
		public virtual RMethod RMAbortDownload_IEnumerable_d_IPackage_p_
		{
			get
			{
				if(r_MAbortDownload_IEnumerable_d_IPackage_p_ == null)
				{
					r_MAbortDownload_IEnumerable_d_IPackage_p_ = new(this, "AbortDownload", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage")));
				}
				return r_MAbortDownload_IEnumerable_d_IPackage_p_;
			}
		}

		/// <summary>
		/// Void PauseDownload(UnityEditor.PackageManager.UI.Internal.IPackage)
		/// </summary>
		protected RMethod r_MPauseDownload_IPackage;
		public virtual RMethod RMPauseDownload_IPackage
		{
			get
			{
				if(r_MPauseDownload_IPackage == null)
				{
					r_MPauseDownload_IPackage = new(this, "PauseDownload", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"));
				}
				return r_MPauseDownload_IPackage;
			}
		}

		/// <summary>
		/// Void ResumeDownload(UnityEditor.PackageManager.UI.Internal.IPackage)
		/// </summary>
		protected RMethod r_MResumeDownload_IPackage;
		public virtual RMethod RMResumeDownload_IPackage
		{
			get
			{
				if(r_MResumeDownload_IPackage == null)
				{
					r_MResumeDownload_IPackage = new(this, "ResumeDownload", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"));
				}
				return r_MResumeDownload_IPackage;
			}
		}

		/// <summary>
		/// Void Import(UnityEditor.PackageManager.UI.Internal.IPackage)
		/// </summary>
		protected RMethod r_MImport_IPackage;
		public virtual RMethod RMImport_IPackage
		{
			get
			{
				if(r_MImport_IPackage == null)
				{
					r_MImport_IPackage = new(this, "Import", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"));
				}
				return r_MImport_IPackage;
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
				}
				return r_MToString;
			}
		}


        public virtual void ResolveDependencies(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityConnectProxy @unityConnect, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetDatabaseProxy @assetDatabase, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUtils @assetStoreUtils, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreClient @assetStoreClient, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreDownloadManager @assetStoreDownloadManager, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmCache @upmCache, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmClient @upmClient, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOProxy @ioProxy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unityConnect.Value, @assetDatabase.Value, @assetStoreUtils.Value, @assetStoreClient.Value, @assetStoreDownloadManager.Value, @upmCache.Value, @upmClient.Value, @ioProxy.Value};
            var ___result = RMResolveDependencies_UnityConnectProxy_AssetDatabaseProxy_AssetStoreUtils_AssetStoreClient_AssetStoreDownloadManager_UpmCache_UpmClient_IOProxy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsUninstallInProgress(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RMIsUninstallInProgress_IPackage.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsInstallInProgress(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value};
            var ___result = RMIsInstallInProgress_IPackageVersion.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage GetPackage(System.String @uniqueId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uniqueId};
            var ___result = RMGetPackage_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage GetPackage(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value};
            var ___result = RMGetPackage_IPackageVersion.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage>(___result);
        }


        public virtual void GetPackageAndVersionByIdOrName(System.String @idOrName, out Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package, out Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {
			@package = default;
			@version = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idOrName, @package.Value, @version.Value};
            var ___result = RMGetPackageAndVersionByIdOrName_String_Out_IPackage_Out_IPackageVersion.Invoke(___genericsType, ___parameters);
			@package = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage>(___parameters[1]);
			@version = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion>(___parameters[2]);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage GetPackageByIdOrName(System.String @idOrName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idOrName};
            var ___result = RMGetPackageByIdOrName_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage>(___result);
        }


        public virtual void GetPackageAndVersion(System.String @packageUniqueId, System.String @versionUniqueId, out Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package, out Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {
			@package = default;
			@version = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueId, @versionUniqueId, @package.Value, @version.Value};
            var ___result = RMGetPackageAndVersion_String_String_Out_IPackage_Out_IPackageVersion.Invoke(___genericsType, ___parameters);
			@package = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage>(___parameters[2]);
			@version = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion>(___parameters[3]);

            
        }


        public virtual void GetPackageAndVersion(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair @pair, out Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package, out Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {
			@package = default;
			@version = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pair.Value, @package.Value, @version.Value};
            var ___result = RMGetPackageAndVersion_PackageAndVersionIdPair_Out_IPackage_Out_IPackageVersion.Invoke(___genericsType, ___parameters);
			@package = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage>(___parameters[1]);
			@version = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion>(___parameters[2]);

            
        }


        public virtual void GetPackageAndVersion(UnityEditor.PackageManager.DependencyInfo @info, out Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package, out Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {
			@package = default;
			@version = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @package.Value, @version.Value};
            var ___result = RMGetPackageAndVersion_DependencyInfo_Out_IPackage_Out_IPackageVersion.Invoke(___genericsType, ___parameters);
			@package = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage>(___parameters[1]);
			@version = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion>(___parameters[2]);

            
        }


        public virtual void GetUpmPackageAndVersion(System.String @name, System.String @versionIdentifier, out Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package, out Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {
			@package = default;
			@version = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @versionIdentifier, @package.Value, @version.Value};
            var ___result = RMGetUpmPackageAndVersion_String_String_Out_IPackage_Out_IPackageVersion.Invoke(___genericsType, ___parameters);
			@package = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage>(___parameters[2]);
			@version = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion>(___parameters[3]);

            
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion> GetReverseDependencies(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version, System.Boolean @directDependenciesOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value, @directDependenciesOnly};
            var ___result = RMGetReverseDependencies_IPackageVersion_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion>>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion> GetFeaturesThatUseThisPackage(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value};
            var ___result = RMGetFeaturesThatUseThisPackage_IPackageVersion.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion>>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> GetCustomizedDependencies(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version, Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RSystem.RBoolean> @rootDependenciesOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value, @rootDependenciesOnly.Value};
            var ___result = RMGetCustomizedDependencies_IPackageVersion_Nullable_d_Boolean_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage>>(___result);
        }


        public virtual System.Collections.Generic.IEnumerable<UnityEditor.PackageManager.UI.Sample> GetSamples(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value};
            var ___result = RMGetSamples_IPackageVersion.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.IEnumerable<UnityEditor.PackageManager.UI.Sample>>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion GetPackageInFeatureVersion(System.String @packageId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageId};
            var ___result = RMGetPackageInFeatureVersion_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion>(___result);
        }


        public virtual void OnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBeforeSerialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnBeforeSerialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TriggerOnPackagesChanged(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @added, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @removed, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @updated, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @preUpdate, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @progressUpdated)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@added.Value, @removed.Value, @updated.Value, @preUpdate.Value, @progressUpdated.Value};
            var ___result = RMTriggerOnPackagesChanged_IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddPackageError(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError @error)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value, @error.Value};
            var ___result = RMAddPackageError_IPackage_UIError.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearPackageErrors(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package, Hvak.Editor.Refleaction.RSystem.RPredicate<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value, @match.Value};
            var ___result = RMClearPackageErrors_IPackage_Predicate_d_UIError_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPackagesProgress(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @packages, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageProgress @progress)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packages.Value, @progress.Value};
            var ___result = RMSetPackagesProgress_IEnumerable_d_IPackage_p__PackageProgress.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPackageProgress(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageProgress @progress)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value, @progress.Value};
            var ___result = RMSetPackageProgress_IPackage_PackageProgress.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnEnable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnEnable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDisable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnDisable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reload()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReload.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDownloadProgress(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @operation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@operation.Value};
            var ___result = RMOnDownloadProgress_IOperation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDownloadFinalized(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @operation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@operation.Value};
            var ___result = RMOnDownloadFinalized_IOperation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDownloadError(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @operation, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError @error)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@operation.Value, @error.Value};
            var ___result = RMOnDownloadError_IOperation_UIError.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDownloadPaused(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @operation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@operation.Value};
            var ___result = RMOnDownloadPaused_IOperation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnUserLoginStateChange(System.Boolean @userInfoReady, System.Boolean @loggedIn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@userInfoReady, @loggedIn};
            var ___result = RMOnUserLoginStateChange_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnVerifiedGitPackageUpToDate(System.String @packageId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageId};
            var ___result = RMOnVerifiedGitPackageUpToDate_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAssetStorePackagesChanged(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @packages)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packages.Value};
            var ___result = RMOnAssetStorePackagesChanged_IEnumerable_d_IPackage_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPackagesChanged(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @packages)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packages.Value};
            var ___result = RMOnPackagesChanged_IEnumerable_d_IPackage_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemovePackage(System.String @packageUniqueId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueId};
            var ___result = RMRemovePackage_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddPackage(System.String @packageUniqueId, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueId, @package.Value};
            var ___result = RMAddPackage_String_IPackage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnUpmAddAndRemoveOperation(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmAddAndRemoveOperation @operation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@operation.Value};
            var ___result = RMOnUpmAddAndRemoveOperation_UpmAddAndRemoveOperation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnUpmAddOperation(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @operation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@operation.Value};
            var ___result = RMOnUpmAddOperation_IOperation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveSpecialInstallation(System.String @specialUniqueId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@specialUniqueId};
            var ___result = RMRemoveSpecialInstallation_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnUpmEmbedOperation(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @operation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@operation.Value};
            var ___result = RMOnUpmEmbedOperation_IOperation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnUpmRemoveOperation(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @operation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@operation.Value};
            var ___result = RMOnUpmRemoveOperation_IOperation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnUpmOperationError(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @operation, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError @error)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@operation.Value, @error.Value};
            var ___result = RMOnUpmOperationError_IOperation_UIError.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnUpmOperationFinalized(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @operation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@operation.Value};
            var ___result = RMOnUpmOperationFinalized_IOperation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearSamplesCache()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearSamplesCache.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Install(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value};
            var ___result = RMInstall_IPackageVersion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Install(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion> @versions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@versions.Value};
            var ___result = RMInstall_IEnumerable_d_IPackageVersion_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Install(System.String @packageId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageId};
            var ___result = RMInstall_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InstallFromUrl(System.String @url)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@url};
            var ___result = RMInstallFromUrl_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean InstallFromPath(System.String @path, out System.String @tempPackageId)
        {
			@tempPackageId = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path, @tempPackageId};
            var ___result = RMInstallFromPath_String_Out_String.Invoke(___genericsType, ___parameters);
			@tempPackageId = ReflectionUtils.Convert<System.String>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Uninstall(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RMUninstall_IPackage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Uninstall(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @packages)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packages.Value};
            var ___result = RMUninstall_IEnumerable_d_IPackage_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InstallAndResetDependencies(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @dependenciesToReset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value, @dependenciesToReset.Value};
            var ___result = RMInstallAndResetDependencies_IPackageVersion_IEnumerable_d_IPackage_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetDependencies(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @dependenciesToReset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value, @dependenciesToReset.Value};
            var ___result = RMResetDependencies_IPackageVersion_IEnumerable_d_IPackage_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Embed(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @packageVersion)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageVersion.Value};
            var ___result = RMEmbed_IPackageVersion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveEmbedded(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RMRemoveEmbedded_IPackage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FetchExtraInfo(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value};
            var ___result = RMFetchExtraInfo_IPackageVersion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CheckTermOfServiceAgreement(System.Action @onTosAccepted, Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> @onError)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@onTosAccepted, @onError.Value};
            var ___result = RMCheckTermOfServiceAgreement_Action_Action_d_UIError_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Download(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RMDownload_IPackage.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Download(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @packages)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packages.Value};
            var ___result = RMDownload_IEnumerable_d_IPackage_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Download_Internal(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @packages)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packages.Value};
            var ___result = RMDownload_Internal_IEnumerable_d_IPackage_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AbortDownload(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RMAbortDownload_IPackage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AbortDownload(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @packages)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packages.Value};
            var ___result = RMAbortDownload_IEnumerable_d_IPackage_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PauseDownload(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RMPauseDownload_IPackage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResumeDownload(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RMResumeDownload_IPackage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Import(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RMImport_IPackage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
