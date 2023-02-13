
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.PaginatedPage
	/// </summary>
    public partial class RPaginatedPage : RMember //
    {

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.PageSelection] onSelectionChanged
		/// </summary>
		protected REvent r_EonSelectionChanged;
		public virtual REvent REonSelectionChanged
		{
			get
			{
				if(r_EonSelectionChanged == null)
				{
					r_EonSelectionChanged = new(this, "onSelectionChanged");
					r_EonSelectionChanged.SetBelong(this.instance);
				}
				return r_EonSelectionChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.VisualStateChangeArgs] onVisualStateChange
		/// </summary>
		protected REvent r_EonVisualStateChange;
		public virtual REvent REonVisualStateChange
		{
			get
			{
				if(r_EonVisualStateChange == null)
				{
					r_EonVisualStateChange = new(this, "onVisualStateChange");
					r_EonVisualStateChange.SetBelong(this.instance);
				}
				return r_EonVisualStateChange;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.ListUpdateArgs] onListUpdate
		/// </summary>
		protected REvent r_EonListUpdate;
		public virtual REvent REonListUpdate
		{
			get
			{
				if(r_EonListUpdate == null)
				{
					r_EonListUpdate = new(this, "onListUpdate");
					r_EonListUpdate.SetBelong(this.instance);
				}
				return r_EonListUpdate;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IPage] onListRebuild
		/// </summary>
		protected REvent r_EonListRebuild;
		public virtual REvent REonListRebuild
		{
			get
			{
				if(r_EonListRebuild == null)
				{
					r_EonListRebuild = new(this, "onListRebuild");
					r_EonListRebuild.SetBelong(this.instance);
				}
				return r_EonListRebuild;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IPage] onSubPageChanged
		/// </summary>
		protected REvent r_EonSubPageChanged;
		public virtual REvent REonSubPageChanged
		{
			get
			{
				if(r_EonSubPageChanged == null)
				{
					r_EonSubPageChanged = new(this, "onSubPageChanged");
					r_EonSubPageChanged.SetBelong(this.instance);
				}
				return r_EonSubPageChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.PageFilters] onFiltersChange
		/// </summary>
		protected REvent r_EonFiltersChange;
		public virtual REvent REonFiltersChange
		{
			get
			{
				if(r_EonFiltersChange == null)
				{
					r_EonFiltersChange = new(this, "onFiltersChange");
					r_EonFiltersChange.SetBelong(this.instance);
				}
				return r_EonFiltersChange;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PaginatedVisualStateList m_VisualStateList
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPaginatedVisualStateList r_Fm_VisualStateList;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPaginatedVisualStateList RFm_VisualStateList
		{
			get
			{
				if(r_Fm_VisualStateList == null)
				{
					r_Fm_VisualStateList = new(this, "m_VisualStateList");
					r_Fm_VisualStateList.SetBelong(this.instance);
				}
				return r_Fm_VisualStateList;
			}
		}

		/// <summary>
		/// System.String <contentType>k__BackingField
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_F__0__contentType__1__k__BackingField;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RF__0__contentType__1__k__BackingField
		{
			get
			{
				if(r_F__0__contentType__1__k__BackingField == null)
				{
					r_F__0__contentType__1__k__BackingField = new(this, "<contentType>k__BackingField");
					r_F__0__contentType__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__contentType__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreClient m_AssetStoreClient
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreClient r_Fm_AssetStoreClient;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreClient RFm_AssetStoreClient
		{
			get
			{
				if(r_Fm_AssetStoreClient == null)
				{
					r_Fm_AssetStoreClient = new(this, "m_AssetStoreClient");
					r_Fm_AssetStoreClient.SetBelong(this.instance);
				}
				return r_Fm_AssetStoreClient;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageFiltering m_PackageFiltering
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFiltering r_Fm_PackageFiltering;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFiltering RFm_PackageFiltering
		{
			get
			{
				if(r_Fm_PackageFiltering == null)
				{
					r_Fm_PackageFiltering = new(this, "m_PackageFiltering");
					r_Fm_PackageFiltering.SetBelong(this.instance);
				}
				return r_Fm_PackageFiltering;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageManagerPrefs m_PackageManagerPrefs
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerPrefs r_Fm_PackageManagerPrefs;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerPrefs RFm_PackageManagerPrefs
		{
			get
			{
				if(r_Fm_PackageManagerPrefs == null)
				{
					r_Fm_PackageManagerPrefs = new(this, "m_PackageManagerPrefs");
					r_Fm_PackageManagerPrefs.SetBelong(this.instance);
				}
				return r_Fm_PackageManagerPrefs;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageFilterTab m_Tab
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab r_Fm_Tab;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab RFm_Tab
		{
			get
			{
				if(r_Fm_Tab == null)
				{
					r_Fm_Tab = new(this, "m_Tab");
					r_Fm_Tab.SetBelong(this.instance);
				}
				return r_Fm_Tab;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PageFilters m_Filters
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageFilters r_Fm_Filters;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageFilters RFm_Filters
		{
			get
			{
				if(r_Fm_Filters == null)
				{
					r_Fm_Filters = new(this, "m_Filters");
					r_Fm_Filters.SetBelong(this.instance);
				}
				return r_Fm_Filters;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PageCapability m_Capability
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageCapability r_Fm_Capability;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageCapability RFm_Capability
		{
			get
			{
				if(r_Fm_Capability == null)
				{
					r_Fm_Capability = new(this, "m_Capability");
					r_Fm_Capability.SetBelong(this.instance);
				}
				return r_Fm_Capability;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageDatabase m_PackageDatabase
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDatabase r_Fm_PackageDatabase;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDatabase RFm_PackageDatabase
		{
			get
			{
				if(r_Fm_PackageDatabase == null)
				{
					r_Fm_PackageDatabase = new(this, "m_PackageDatabase");
					r_Fm_PackageDatabase.SetBelong(this.instance);
				}
				return r_Fm_PackageDatabase;
			}
		}

		/// <summary>
		/// Int64 numTotalItems
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt64 r_PnumTotalItems;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt64 RPnumTotalItems
		{
			get
			{
				if(r_PnumTotalItems == null)
				{
					r_PnumTotalItems = new(this, "numTotalItems", -1);
					r_PnumTotalItems.SetBelong(this.instance);
				}
				return r_PnumTotalItems;
			}
		}

		/// <summary>
		/// Int64 numCurrentItems
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt64 r_PnumCurrentItems;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt64 RPnumCurrentItems
		{
			get
			{
				if(r_PnumCurrentItems == null)
				{
					r_PnumCurrentItems = new(this, "numCurrentItems", -1);
					r_PnumCurrentItems.SetBelong(this.instance);
				}
				return r_PnumCurrentItems;
			}
		}

		/// <summary>
		/// Boolean morePackagesToFetch
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PmorePackagesToFetch;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPmorePackagesToFetch
		{
			get
			{
				if(r_PmorePackagesToFetch == null)
				{
					r_PmorePackagesToFetch = new(this, "morePackagesToFetch", -1);
					r_PmorePackagesToFetch.SetBelong(this.instance);
				}
				return r_PmorePackagesToFetch;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.VisualState] visualStates
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState> r_PvisualStates;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState> RPvisualStates
		{
			get
			{
				if(r_PvisualStates == null)
				{
					r_PvisualStates = new(this, "visualStates", -1);
					r_PvisualStates.SetBelong(this.instance);
				}
				return r_PvisualStates;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.SubPage] subPages
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RSubPage> r_PsubPages;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RSubPage> RPsubPages
		{
			get
			{
				if(r_PsubPages == null)
				{
					r_PsubPages = new(this, "subPages", -1);
					r_PsubPages.SetBelong(this.instance);
				}
				return r_PsubPages;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.SubPage currentSubPage
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RSubPage r_PcurrentSubPage;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RSubPage RPcurrentSubPage
		{
			get
			{
				if(r_PcurrentSubPage == null)
				{
					r_PcurrentSubPage = new(this, "currentSubPage", -1);
					r_PcurrentSubPage.SetBelong(this.instance);
				}
				return r_PcurrentSubPage;
			}
		}

		/// <summary>
		/// System.String contentType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PcontentType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPcontentType
		{
			get
			{
				if(r_PcontentType == null)
				{
					r_PcontentType = new(this, "contentType", -1);
					r_PcontentType.SetBelong(this.instance);
				}
				return r_PcontentType;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageFilterTab tab
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab r_Ptab;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab RPtab
		{
			get
			{
				if(r_Ptab == null)
				{
					r_Ptab = new(this, "tab", -1);
					r_Ptab.SetBelong(this.instance);
				}
				return r_Ptab;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PageFilters filters
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageFilters r_Pfilters;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageFilters RPfilters
		{
			get
			{
				if(r_Pfilters == null)
				{
					r_Pfilters = new(this, "filters", -1);
					r_Pfilters.SetBelong(this.instance);
				}
				return r_Pfilters;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PageCapability capability
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageCapability r_Pcapability;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageCapability RPcapability
		{
			get
			{
				if(r_Pcapability == null)
				{
					r_Pcapability = new(this, "capability", -1);
					r_Pcapability.SetBelong(this.instance);
				}
				return r_Pcapability;
			}
		}

		/// <summary>
		/// Boolean isFullyLoaded
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisFullyLoaded;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisFullyLoaded
		{
			get
			{
				if(r_PisFullyLoaded == null)
				{
					r_PisFullyLoaded = new(this, "isFullyLoaded", -1);
					r_PisFullyLoaded.SetBelong(this.instance);
				}
				return r_PisFullyLoaded;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.PackageDatabase, UnityEditor.PackageManager.UI.Internal.AssetStoreClient, UnityEditor.PackageManager.UI.Internal.PackageFiltering, UnityEditor.PackageManager.UI.Internal.PackageManagerPrefs)
		/// </summary>
		protected RMethod r_MResolveDependencies_PackageDatabase_AssetStoreClient_PackageFiltering_PackageManagerPrefs;
		public virtual RMethod RMResolveDependencies_PackageDatabase_AssetStoreClient_PackageFiltering_PackageManagerPrefs
		{
			get
			{
				if(r_MResolveDependencies_PackageDatabase_AssetStoreClient_PackageFiltering_PackageManagerPrefs == null)
				{
					r_MResolveDependencies_PackageDatabase_AssetStoreClient_PackageFiltering_PackageManagerPrefs = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageDatabase"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreClient"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageFiltering"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageManagerPrefs"));
					r_MResolveDependencies_PackageDatabase_AssetStoreClient_PackageFiltering_PackageManagerPrefs.SetBelong(this.instance);
				}
				return r_MResolveDependencies_PackageDatabase_AssetStoreClient_PackageFiltering_PackageManagerPrefs;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.VisualState GetVisualState(System.String)
		/// </summary>
		protected RMethod r_MGetVisualState_String;
		public virtual RMethod RMGetVisualState_String
		{
			get
			{
				if(r_MGetVisualState_String == null)
				{
					r_MGetVisualState_String = new(this, "GetVisualState", 0, typeof(System.String));
					r_MGetVisualState_String.SetBelong(this.instance);
				}
				return r_MGetVisualState_String;
			}
		}

		/// <summary>
		/// Boolean UpdateFilters(UnityEditor.PackageManager.UI.Internal.PageFilters)
		/// </summary>
		protected RMethod r_MUpdateFilters_PageFilters;
		public virtual RMethod RMUpdateFilters_PageFilters
		{
			get
			{
				if(r_MUpdateFilters_PageFilters == null)
				{
					r_MUpdateFilters_PageFilters = new(this, "UpdateFilters", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PageFilters"));
					r_MUpdateFilters_PageFilters.SetBelong(this.instance);
				}
				return r_MUpdateFilters_PageFilters;
			}
		}

		/// <summary>
		/// Void OnPackagesChanged(UnityEditor.PackageManager.UI.Internal.PackagesChangeArgs)
		/// </summary>
		protected RMethod r_MOnPackagesChanged_PackagesChangeArgs;
		public virtual RMethod RMOnPackagesChanged_PackagesChangeArgs
		{
			get
			{
				if(r_MOnPackagesChanged_PackagesChangeArgs == null)
				{
					r_MOnPackagesChanged_PackagesChangeArgs = new(this, "OnPackagesChanged", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackagesChangeArgs"));
					r_MOnPackagesChanged_PackagesChangeArgs.SetBelong(this.instance);
				}
				return r_MOnPackagesChanged_PackagesChangeArgs;
			}
		}

		/// <summary>
		/// Void Rebuild()
		/// </summary>
		protected RMethod r_MRebuild;
		public virtual RMethod RMRebuild
		{
			get
			{
				if(r_MRebuild == null)
				{
					r_MRebuild = new(this, "Rebuild", 0);
					r_MRebuild.SetBelong(this.instance);
				}
				return r_MRebuild;
			}
		}

		/// <summary>
		/// Void RefreshVisualStates()
		/// </summary>
		protected RMethod r_MRefreshVisualStates;
		public virtual RMethod RMRefreshVisualStates
		{
			get
			{
				if(r_MRefreshVisualStates == null)
				{
					r_MRefreshVisualStates = new(this, "RefreshVisualStates", 0);
					r_MRefreshVisualStates.SetBelong(this.instance);
				}
				return r_MRefreshVisualStates;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PurchasesQueryArgs BuildQueryFromFilter(Int32, Int32)
		/// </summary>
		protected RMethod r_MBuildQueryFromFilter_Int32_Int32;
		public virtual RMethod RMBuildQueryFromFilter_Int32_Int32
		{
			get
			{
				if(r_MBuildQueryFromFilter_Int32_Int32 == null)
				{
					r_MBuildQueryFromFilter_Int32_Int32 = new(this, "BuildQueryFromFilter", 0, typeof(System.Int32), typeof(System.Int32));
					r_MBuildQueryFromFilter_Int32_Int32.SetBelong(this.instance);
				}
				return r_MBuildQueryFromFilter_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ClearAndRebuild()
		/// </summary>
		protected RMethod r_MClearAndRebuild;
		public virtual RMethod RMClearAndRebuild
		{
			get
			{
				if(r_MClearAndRebuild == null)
				{
					r_MClearAndRebuild = new(this, "ClearAndRebuild", 0);
					r_MClearAndRebuild.SetBelong(this.instance);
				}
				return r_MClearAndRebuild;
			}
		}

		/// <summary>
		/// Void LoadMore(Int64)
		/// </summary>
		protected RMethod r_MLoadMore_Int64;
		public virtual RMethod RMLoadMore_Int64
		{
			get
			{
				if(r_MLoadMore_Int64 == null)
				{
					r_MLoadMore_Int64 = new(this, "LoadMore", 0, typeof(System.Int64));
					r_MLoadMore_Int64.SetBelong(this.instance);
				}
				return r_MLoadMore_Int64;
			}
		}

		/// <summary>
		/// Void Load(UnityEditor.PackageManager.UI.Internal.IPackage, UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MLoad_IPackage_IPackageVersion;
		public virtual RMethod RMLoad_IPackage_IPackageVersion
		{
			get
			{
				if(r_MLoad_IPackage_IPackageVersion == null)
				{
					r_MLoad_IPackage_IPackageVersion = new(this, "Load", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
					r_MLoad_IPackage_IPackageVersion.SetBelong(this.instance);
				}
				return r_MLoad_IPackage_IPackageVersion;
			}
		}

		/// <summary>
		/// Void LoadExtraItems(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage])
		/// </summary>
		protected RMethod r_MLoadExtraItems_IEnumerable_d_IPackage_p_;
		public virtual RMethod RMLoadExtraItems_IEnumerable_d_IPackage_p_
		{
			get
			{
				if(r_MLoadExtraItems_IEnumerable_d_IPackage_p_ == null)
				{
					r_MLoadExtraItems_IEnumerable_d_IPackage_p_ = new(this, "LoadExtraItems", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage")));
					r_MLoadExtraItems_IEnumerable_d_IPackage_p_.SetBelong(this.instance);
				}
				return r_MLoadExtraItems_IEnumerable_d_IPackage_p_;
			}
		}

		/// <summary>
		/// Void OnProductExtraFetched(Int64)
		/// </summary>
		protected RMethod r_MOnProductExtraFetched_Int64;
		public virtual RMethod RMOnProductExtraFetched_Int64
		{
			get
			{
				if(r_MOnProductExtraFetched_Int64 == null)
				{
					r_MOnProductExtraFetched_Int64 = new(this, "OnProductExtraFetched", 0, typeof(System.Int64));
					r_MOnProductExtraFetched_Int64.SetBelong(this.instance);
				}
				return r_MOnProductExtraFetched_Int64;
			}
		}

		/// <summary>
		/// Void OnProductListFetched(UnityEditor.PackageManager.UI.Internal.AssetStorePurchases)
		/// </summary>
		protected RMethod r_MOnProductListFetched_AssetStorePurchases;
		public virtual RMethod RMOnProductListFetched_AssetStorePurchases
		{
			get
			{
				if(r_MOnProductListFetched_AssetStorePurchases == null)
				{
					r_MOnProductListFetched_AssetStorePurchases = new(this, "OnProductListFetched", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStorePurchases"));
					r_MOnProductListFetched_AssetStorePurchases.SetBelong(this.instance);
				}
				return r_MOnProductListFetched_AssetStorePurchases;
			}
		}

		/// <summary>
		/// Boolean Contains(System.String)
		/// </summary>
		protected RMethod r_MContains_String;
		public virtual RMethod RMContains_String
		{
			get
			{
				if(r_MContains_String == null)
				{
					r_MContains_String = new(this, "Contains", 0, typeof(System.String));
					r_MContains_String.SetBelong(this.instance);
				}
				return r_MContains_String;
			}
		}

		/// <summary>
		/// Void AddSubPage(UnityEditor.PackageManager.UI.Internal.SubPage)
		/// </summary>
		protected RMethod r_MAddSubPage_SubPage;
		public virtual RMethod RMAddSubPage_SubPage
		{
			get
			{
				if(r_MAddSubPage_SubPage == null)
				{
					r_MAddSubPage_SubPage = new(this, "AddSubPage", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.SubPage"));
					r_MAddSubPage_SubPage.SetBelong(this.instance);
				}
				return r_MAddSubPage_SubPage;
			}
		}

		/// <summary>
		/// Boolean <LoadExtraItems>b__32_0(UnityEditor.PackageManager.UI.Internal.IPackage)
		/// </summary>
		protected RMethod r_M__0__LoadExtraItems__1__b__32_0_IPackage;
		public virtual RMethod RM__0__LoadExtraItems__1__b__32_0_IPackage
		{
			get
			{
				if(r_M__0__LoadExtraItems__1__b__32_0_IPackage == null)
				{
					r_M__0__LoadExtraItems__1__b__32_0_IPackage = new(this, "<LoadExtraItems>b__32_0", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"));
					r_M__0__LoadExtraItems__1__b__32_0_IPackage.SetBelong(this.instance);
				}
				return r_M__0__LoadExtraItems__1__b__32_0_IPackage;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackage <OnProductListFetched>b__34_2(System.String)
		/// </summary>
		protected RMethod r_M__0__OnProductListFetched__1__b__34_2_String;
		public virtual RMethod RM__0__OnProductListFetched__1__b__34_2_String
		{
			get
			{
				if(r_M__0__OnProductListFetched__1__b__34_2_String == null)
				{
					r_M__0__OnProductListFetched__1__b__34_2_String = new(this, "<OnProductListFetched>b__34_2", 0, typeof(System.String));
					r_M__0__OnProductListFetched__1__b__34_2_String.SetBelong(this.instance);
				}
				return r_M__0__OnProductListFetched__1__b__34_2_String;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackage <OnProductListFetched>b__34_3(System.String)
		/// </summary>
		protected RMethod r_M__0__OnProductListFetched__1__b__34_3_String;
		public virtual RMethod RM__0__OnProductListFetched__1__b__34_3_String
		{
			get
			{
				if(r_M__0__OnProductListFetched__1__b__34_3_String == null)
				{
					r_M__0__OnProductListFetched__1__b__34_3_String = new(this, "<OnProductListFetched>b__34_3", 0, typeof(System.String));
					r_M__0__OnProductListFetched__1__b__34_3_String.SetBelong(this.instance);
				}
				return r_M__0__OnProductListFetched__1__b__34_3_String;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.PackageDatabase)
		/// </summary>
		protected RMethod r_MResolveDependencies_PackageDatabase;
		public virtual RMethod RMResolveDependencies_PackageDatabase
		{
			get
			{
				if(r_MResolveDependencies_PackageDatabase == null)
				{
					r_MResolveDependencies_PackageDatabase = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageDatabase"));
					r_MResolveDependencies_PackageDatabase.SetBelong(this.instance);
				}
				return r_MResolveDependencies_PackageDatabase;
			}
		}

		/// <summary>
		/// Boolean ClearFilters()
		/// </summary>
		protected RMethod r_MClearFilters;
		public virtual RMethod RMClearFilters
		{
			get
			{
				if(r_MClearFilters == null)
				{
					r_MClearFilters = new(this, "ClearFilters", 0);
					r_MClearFilters.SetBelong(this.instance);
				}
				return r_MClearFilters;
			}
		}

		/// <summary>
		/// Void TriggerOnListUpdate(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage], System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage], System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage])
		/// </summary>
		protected RMethod r_MTriggerOnListUpdate_IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p_;
		public virtual RMethod RMTriggerOnListUpdate_IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p_
		{
			get
			{
				if(r_MTriggerOnListUpdate_IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p_ == null)
				{
					r_MTriggerOnListUpdate_IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p_ = new(this, "TriggerOnListUpdate", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage")), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage")), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage")));
					r_MTriggerOnListUpdate_IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p_.SetBelong(this.instance);
				}
				return r_MTriggerOnListUpdate_IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p_;
			}
		}

		/// <summary>
		/// Void TriggerOnListRebuild()
		/// </summary>
		protected RMethod r_MTriggerOnListRebuild;
		public virtual RMethod RMTriggerOnListRebuild
		{
			get
			{
				if(r_MTriggerOnListRebuild == null)
				{
					r_MTriggerOnListRebuild = new(this, "TriggerOnListRebuild", 0);
					r_MTriggerOnListRebuild.SetBelong(this.instance);
				}
				return r_MTriggerOnListRebuild;
			}
		}

		/// <summary>
		/// Void SetPackagesUserUnlockedState(System.Collections.Generic.IEnumerable`1[System.String], Boolean)
		/// </summary>
		protected RMethod r_MSetPackagesUserUnlockedState_IEnumerable_d_String_p__Boolean;
		public virtual RMethod RMSetPackagesUserUnlockedState_IEnumerable_d_String_p__Boolean
		{
			get
			{
				if(r_MSetPackagesUserUnlockedState_IEnumerable_d_String_p__Boolean == null)
				{
					r_MSetPackagesUserUnlockedState_IEnumerable_d_String_p__Boolean = new(this, "SetPackagesUserUnlockedState", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.String)), typeof(System.Boolean));
					r_MSetPackagesUserUnlockedState_IEnumerable_d_String_p__Boolean.SetBelong(this.instance);
				}
				return r_MSetPackagesUserUnlockedState_IEnumerable_d_String_p__Boolean;
			}
		}

		/// <summary>
		/// Void ResetUserUnlockedState()
		/// </summary>
		protected RMethod r_MResetUserUnlockedState;
		public virtual RMethod RMResetUserUnlockedState
		{
			get
			{
				if(r_MResetUserUnlockedState == null)
				{
					r_MResetUserUnlockedState = new(this, "ResetUserUnlockedState", 0);
					r_MResetUserUnlockedState.SetBelong(this.instance);
				}
				return r_MResetUserUnlockedState;
			}
		}

		/// <summary>
		/// Boolean GetDefaultLockState(UnityEditor.PackageManager.UI.Internal.IPackage)
		/// </summary>
		protected RMethod r_MGetDefaultLockState_IPackage;
		public virtual RMethod RMGetDefaultLockState_IPackage
		{
			get
			{
				if(r_MGetDefaultLockState_IPackage == null)
				{
					r_MGetDefaultLockState_IPackage = new(this, "GetDefaultLockState", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"));
					r_MGetDefaultLockState_IPackage.SetBelong(this.instance);
				}
				return r_MGetDefaultLockState_IPackage;
			}
		}

		/// <summary>
		/// Void TriggerOnVisualStateChange(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.VisualState])
		/// </summary>
		protected RMethod r_MTriggerOnVisualStateChange_IEnumerable_d_VisualState_p_;
		public virtual RMethod RMTriggerOnVisualStateChange_IEnumerable_d_VisualState_p_
		{
			get
			{
				if(r_MTriggerOnVisualStateChange_IEnumerable_d_VisualState_p_ == null)
				{
					r_MTriggerOnVisualStateChange_IEnumerable_d_VisualState_p_ = new(this, "TriggerOnVisualStateChange", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.VisualState")));
					r_MTriggerOnVisualStateChange_IEnumerable_d_VisualState_p_.SetBelong(this.instance);
				}
				return r_MTriggerOnVisualStateChange_IEnumerable_d_VisualState_p_;
			}
		}

		/// <summary>
		/// Void TriggerOnSelectionChanged()
		/// </summary>
		protected RMethod r_MTriggerOnSelectionChanged;
		public virtual RMethod RMTriggerOnSelectionChanged
		{
			get
			{
				if(r_MTriggerOnSelectionChanged == null)
				{
					r_MTriggerOnSelectionChanged = new(this, "TriggerOnSelectionChanged", 0);
					r_MTriggerOnSelectionChanged.SetBelong(this.instance);
				}
				return r_MTriggerOnSelectionChanged;
			}
		}

		/// <summary>
		/// Void TriggerOnSubPageChanged()
		/// </summary>
		protected RMethod r_MTriggerOnSubPageChanged;
		public virtual RMethod RMTriggerOnSubPageChanged
		{
			get
			{
				if(r_MTriggerOnSubPageChanged == null)
				{
					r_MTriggerOnSubPageChanged = new(this, "TriggerOnSubPageChanged", 0);
					r_MTriggerOnSubPageChanged.SetBelong(this.instance);
				}
				return r_MTriggerOnSubPageChanged;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PageSelection GetSelection()
		/// </summary>
		protected RMethod r_MGetSelection;
		public virtual RMethod RMGetSelection
		{
			get
			{
				if(r_MGetSelection == null)
				{
					r_MGetSelection = new(this, "GetSelection", 0);
					r_MGetSelection.SetBelong(this.instance);
				}
				return r_MGetSelection;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.VisualState] GetSelectedVisualStates()
		/// </summary>
		protected RMethod r_MGetSelectedVisualStates;
		public virtual RMethod RMGetSelectedVisualStates
		{
			get
			{
				if(r_MGetSelectedVisualStates == null)
				{
					r_MGetSelectedVisualStates = new(this, "GetSelectedVisualStates", 0);
					r_MGetSelectedVisualStates.SetBelong(this.instance);
				}
				return r_MGetSelectedVisualStates;
			}
		}

		/// <summary>
		/// Boolean SetNewSelection(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair])
		/// </summary>
		protected RMethod r_MSetNewSelection_IEnumerable_d_PackageAndVersionIdPair_p_;
		public virtual RMethod RMSetNewSelection_IEnumerable_d_PackageAndVersionIdPair_p_
		{
			get
			{
				if(r_MSetNewSelection_IEnumerable_d_PackageAndVersionIdPair_p_ == null)
				{
					r_MSetNewSelection_IEnumerable_d_PackageAndVersionIdPair_p_ = new(this, "SetNewSelection", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair")));
					r_MSetNewSelection_IEnumerable_d_PackageAndVersionIdPair_p_.SetBelong(this.instance);
				}
				return r_MSetNewSelection_IEnumerable_d_PackageAndVersionIdPair_p_;
			}
		}

		/// <summary>
		/// Boolean AmendSelection(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair], System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair])
		/// </summary>
		protected RMethod r_MAmendSelection_IEnumerable_d_PackageAndVersionIdPair_p__IEnumerable_d_PackageAndVersionIdPair_p_;
		public virtual RMethod RMAmendSelection_IEnumerable_d_PackageAndVersionIdPair_p__IEnumerable_d_PackageAndVersionIdPair_p_
		{
			get
			{
				if(r_MAmendSelection_IEnumerable_d_PackageAndVersionIdPair_p__IEnumerable_d_PackageAndVersionIdPair_p_ == null)
				{
					r_MAmendSelection_IEnumerable_d_PackageAndVersionIdPair_p__IEnumerable_d_PackageAndVersionIdPair_p_ = new(this, "AmendSelection", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair")), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair")));
					r_MAmendSelection_IEnumerable_d_PackageAndVersionIdPair_p__IEnumerable_d_PackageAndVersionIdPair_p_.SetBelong(this.instance);
				}
				return r_MAmendSelection_IEnumerable_d_PackageAndVersionIdPair_p__IEnumerable_d_PackageAndVersionIdPair_p_;
			}
		}

		/// <summary>
		/// Boolean ToggleSelection(System.String)
		/// </summary>
		protected RMethod r_MToggleSelection_String;
		public virtual RMethod RMToggleSelection_String
		{
			get
			{
				if(r_MToggleSelection_String == null)
				{
					r_MToggleSelection_String = new(this, "ToggleSelection", 0, typeof(System.String));
					r_MToggleSelection_String.SetBelong(this.instance);
				}
				return r_MToggleSelection_String;
			}
		}

		/// <summary>
		/// Boolean IsGroupExpanded(System.String)
		/// </summary>
		protected RMethod r_MIsGroupExpanded_String;
		public virtual RMethod RMIsGroupExpanded_String
		{
			get
			{
				if(r_MIsGroupExpanded_String == null)
				{
					r_MIsGroupExpanded_String = new(this, "IsGroupExpanded", 0, typeof(System.String));
					r_MIsGroupExpanded_String.SetBelong(this.instance);
				}
				return r_MIsGroupExpanded_String;
			}
		}

		/// <summary>
		/// Void SetGroupExpanded(System.String, Boolean)
		/// </summary>
		protected RMethod r_MSetGroupExpanded_String_Boolean;
		public virtual RMethod RMSetGroupExpanded_String_Boolean
		{
			get
			{
				if(r_MSetGroupExpanded_String_Boolean == null)
				{
					r_MSetGroupExpanded_String_Boolean = new(this, "SetGroupExpanded", 0, typeof(System.String), typeof(System.Boolean));
					r_MSetGroupExpanded_String_Boolean.SetBelong(this.instance);
				}
				return r_MSetGroupExpanded_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean Contains(UnityEditor.PackageManager.UI.Internal.IPackage)
		/// </summary>
		protected RMethod r_MContains_IPackage;
		public virtual RMethod RMContains_IPackage
		{
			get
			{
				if(r_MContains_IPackage == null)
				{
					r_MContains_IPackage = new(this, "Contains", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"));
					r_MContains_IPackage.SetBelong(this.instance);
				}
				return r_MContains_IPackage;
			}
		}

		/// <summary>
		/// System.String GetGroupName(UnityEditor.PackageManager.UI.Internal.IPackage)
		/// </summary>
		protected RMethod r_MGetGroupName_IPackage;
		public virtual RMethod RMGetGroupName_IPackage
		{
			get
			{
				if(r_MGetGroupName_IPackage == null)
				{
					r_MGetGroupName_IPackage = new(this, "GetGroupName", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"));
					r_MGetGroupName_IPackage.SetBelong(this.instance);
				}
				return r_MGetGroupName_IPackage;
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


        public RPaginatedPage() : base("UnityEditor.PackageManager.UI.Internal.PaginatedPage")
        {
        }

        public RPaginatedPage(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.PaginatedPage")
		{
            SetInstance(instance);
		}

        public RPaginatedPage(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPaginatedPage(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void ResolveDependencies(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDatabase @packageDatabase, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreClient @assetStoreClient, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFiltering @packageFiltering, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerPrefs @packageManagerPrefs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageDatabase.Value, @assetStoreClient.Value, @packageFiltering.Value, @packageManagerPrefs.Value};
            var ___result = RMResolveDependencies_PackageDatabase_AssetStoreClient_PackageFiltering_PackageManagerPrefs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState GetVisualState(System.String @packageUniqueId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueId};
            var ___result = RMGetVisualState_String.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState(___result);
        }


        public virtual System.Boolean UpdateFilters(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageFilters @filters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filters.Value};
            var ___result = RMUpdateFilters_PageFilters.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnPackagesChanged(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackagesChangeArgs @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args.Value};
            var ___result = RMOnPackagesChanged_PackagesChangeArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Rebuild()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRebuild.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RefreshVisualStates()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefreshVisualStates.Invoke(___genericsType, ___parameters);

            
        }


        public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPurchasesQueryArgs BuildQueryFromFilter(System.Int32 @startIndex, System.Int32 @limit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @limit};
            var ___result = RMBuildQueryFromFilter_Int32_Int32.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPurchasesQueryArgs(___result);
        }


        public virtual void ClearAndRebuild()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearAndRebuild.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadMore(System.Int64 @numberOfPackages)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@numberOfPackages};
            var ___result = RMLoadMore_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Load(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value, @version.Value};
            var ___result = RMLoad_IPackage_IPackageVersion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadExtraItems(SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @packages)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packages.Value};
            var ___result = RMLoadExtraItems_IEnumerable_d_IPackage_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnProductExtraFetched(System.Int64 @productId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productId};
            var ___result = RMOnProductExtraFetched_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnProductListFetched(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchases @purchases)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@purchases.Value};
            var ___result = RMOnProductListFetched_AssetStorePurchases.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Contains(System.String @packageUniqueId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueId};
            var ___result = RMContains_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void AddSubPage(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RSubPage @subPage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@subPage.Value};
            var ___result = RMAddSubPage_SubPage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__LoadExtraItems__1__b__32_0(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p.Value};
            var ___result = RM__0__LoadExtraItems__1__b__32_0_IPackage.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage __0__OnProductListFetched__1__b__34_2(System.String @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RM__0__OnProductListFetched__1__b__34_2_String.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage(___result);
        }


        public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage __0__OnProductListFetched__1__b__34_3(System.String @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RM__0__OnProductListFetched__1__b__34_3_String.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage(___result);
        }


        public virtual void ResolveDependencies(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDatabase @packageDatabase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageDatabase.Value};
            var ___result = RMResolveDependencies_PackageDatabase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ClearFilters()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearFilters.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void TriggerOnListUpdate(SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @added, SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @updated, SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @removed)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@added.Value, @updated.Value, @removed.Value};
            var ___result = RMTriggerOnListUpdate_IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TriggerOnListRebuild()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTriggerOnListRebuild.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPackagesUserUnlockedState(System.Collections.Generic.IEnumerable<System.String> @packageUniqueIds, System.Boolean @unlocked)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueIds, @unlocked};
            var ___result = RMSetPackagesUserUnlockedState_IEnumerable_d_String_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetUserUnlockedState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetUserUnlockedState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetDefaultLockState(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RMGetDefaultLockState_IPackage.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void TriggerOnVisualStateChange(SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState> @visualStates)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@visualStates.Value};
            var ___result = RMTriggerOnVisualStateChange_IEnumerable_d_VisualState_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TriggerOnSelectionChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTriggerOnSelectionChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TriggerOnSubPageChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTriggerOnSubPageChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageSelection GetSelection()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSelection.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageSelection(___result);
        }


        public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState> GetSelectedVisualStates()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSelectedVisualStates.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState>(___result);
        }


        public virtual System.Boolean SetNewSelection(SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair> @packageAndVersionIds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageAndVersionIds.Value};
            var ___result = RMSetNewSelection_IEnumerable_d_PackageAndVersionIdPair_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean AmendSelection(SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair> @toAddOrUpdate, SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair> @toRemove)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@toAddOrUpdate.Value, @toRemove.Value};
            var ___result = RMAmendSelection_IEnumerable_d_PackageAndVersionIdPair_p__IEnumerable_d_PackageAndVersionIdPair_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ToggleSelection(System.String @packageUniqueId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueId};
            var ___result = RMToggleSelection_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsGroupExpanded(System.String @groupName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@groupName};
            var ___result = RMIsGroupExpanded_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetGroupExpanded(System.String @groupName, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@groupName, @value};
            var ___result = RMSetGroupExpanded_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Contains(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RMContains_IPackage.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String GetGroupName(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RMGetGroupName_IPackage.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
