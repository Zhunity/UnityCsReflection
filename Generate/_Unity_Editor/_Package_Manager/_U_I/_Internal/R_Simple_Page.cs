
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.SimplePage
	/// </summary>
    public partial class RSimplePage : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.SimplePage");
            }
        }

        public RSimplePage() : base("UnityEditor.PackageManager.UI.Internal.SimplePage")
        {
        }

        public RSimplePage(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.SimplePage")
		{
            SetInstance(instance);
		}

        public RSimplePage(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSimplePage(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


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
				}
				return r_EonFiltersChange;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.VisualStateList m_VisualStateList
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualStateList r_Fm_VisualStateList;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualStateList RFm_VisualStateList
		{
			get
			{
				if(r_Fm_VisualStateList == null)
				{
					r_Fm_VisualStateList = new(this, "m_VisualStateList");
				}
				return r_Fm_VisualStateList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.SubPage] m_SubPages
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RSubPage> r_Fm_SubPages;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RSubPage> RFm_SubPages
		{
			get
			{
				if(r_Fm_SubPages == null)
				{
					r_Fm_SubPages = new(this, "m_SubPages");
				}
				return r_Fm_SubPages;
			}
		}

		/// <summary>
		/// System.String m_SelectedSubPageName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_SelectedSubPageName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_SelectedSubPageName
		{
			get
			{
				if(r_Fm_SelectedSubPageName == null)
				{
					r_Fm_SelectedSubPageName = new(this, "m_SelectedSubPageName");
				}
				return r_Fm_SelectedSubPageName;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageFiltering m_PackageFiltering
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFiltering r_Fm_PackageFiltering;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFiltering RFm_PackageFiltering
		{
			get
			{
				if(r_Fm_PackageFiltering == null)
				{
					r_Fm_PackageFiltering = new(this, "m_PackageFiltering");
				}
				return r_Fm_PackageFiltering;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageFilterTab m_Tab
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab r_Fm_Tab;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab RFm_Tab
		{
			get
			{
				if(r_Fm_Tab == null)
				{
					r_Fm_Tab = new(this, "m_Tab");
				}
				return r_Fm_Tab;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PageFilters m_Filters
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageFilters r_Fm_Filters;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageFilters RFm_Filters
		{
			get
			{
				if(r_Fm_Filters == null)
				{
					r_Fm_Filters = new(this, "m_Filters");
				}
				return r_Fm_Filters;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PageCapability m_Capability
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageCapability r_Fm_Capability;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageCapability RFm_Capability
		{
			get
			{
				if(r_Fm_Capability == null)
				{
					r_Fm_Capability = new(this, "m_Capability");
				}
				return r_Fm_Capability;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageDatabase m_PackageDatabase
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDatabase r_Fm_PackageDatabase;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDatabase RFm_PackageDatabase
		{
			get
			{
				if(r_Fm_PackageDatabase == null)
				{
					r_Fm_PackageDatabase = new(this, "m_PackageDatabase");
				}
				return r_Fm_PackageDatabase;
			}
		}

		/// <summary>
		/// Int64 numTotalItems
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_PnumTotalItems;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPnumTotalItems
		{
			get
			{
				if(r_PnumTotalItems == null)
				{
					r_PnumTotalItems = new(this, "numTotalItems", -1);
				}
				return r_PnumTotalItems;
			}
		}

		/// <summary>
		/// Int64 numCurrentItems
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_PnumCurrentItems;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPnumCurrentItems
		{
			get
			{
				if(r_PnumCurrentItems == null)
				{
					r_PnumCurrentItems = new(this, "numCurrentItems", -1);
				}
				return r_PnumCurrentItems;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.VisualState] visualStates
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState> r_PvisualStates;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState> RPvisualStates
		{
			get
			{
				if(r_PvisualStates == null)
				{
					r_PvisualStates = new(this, "visualStates", -1);
				}
				return r_PvisualStates;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.SubPage] subPages
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RSubPage> r_PsubPages;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RSubPage> RPsubPages
		{
			get
			{
				if(r_PsubPages == null)
				{
					r_PsubPages = new(this, "subPages", -1);
				}
				return r_PsubPages;
			}
		}

		/// <summary>
		/// System.String contentType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PcontentType;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPcontentType
		{
			get
			{
				if(r_PcontentType == null)
				{
					r_PcontentType = new(this, "contentType", -1);
				}
				return r_PcontentType;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.SubPage currentSubPage
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RSubPage r_PcurrentSubPage;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RSubPage RPcurrentSubPage
		{
			get
			{
				if(r_PcurrentSubPage == null)
				{
					r_PcurrentSubPage = new(this, "currentSubPage", -1);
				}
				return r_PcurrentSubPage;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageFilterTab tab
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab r_Ptab;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab RPtab
		{
			get
			{
				if(r_Ptab == null)
				{
					r_Ptab = new(this, "tab", -1);
				}
				return r_Ptab;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PageFilters filters
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageFilters r_Pfilters;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageFilters RPfilters
		{
			get
			{
				if(r_Pfilters == null)
				{
					r_Pfilters = new(this, "filters", -1);
				}
				return r_Pfilters;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PageCapability capability
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageCapability r_Pcapability;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageCapability RPcapability
		{
			get
			{
				if(r_Pcapability == null)
				{
					r_Pcapability = new(this, "capability", -1);
				}
				return r_Pcapability;
			}
		}

		/// <summary>
		/// Boolean isFullyLoaded
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisFullyLoaded;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisFullyLoaded
		{
			get
			{
				if(r_PisFullyLoaded == null)
				{
					r_PisFullyLoaded = new(this, "isFullyLoaded", -1);
				}
				return r_PisFullyLoaded;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.PackageDatabase, UnityEditor.PackageManager.UI.Internal.PackageFiltering)
		/// </summary>
		protected RMethod r_MResolveDependencies_PackageDatabase_PackageFiltering;
		public virtual RMethod RMResolveDependencies_PackageDatabase_PackageFiltering
		{
			get
			{
				if(r_MResolveDependencies_PackageDatabase_PackageFiltering == null)
				{
					r_MResolveDependencies_PackageDatabase_PackageFiltering = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageDatabase"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageFiltering"));
				}
				return r_MResolveDependencies_PackageDatabase_PackageFiltering;
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
				}
				return r_MOnPackagesChanged_PackagesChangeArgs;
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
				}
				return r_MResetUserUnlockedState;
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
				}
				return r_MTriggerOnSelectionChanged;
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
				}
				return r_MRebuild;
			}
		}

		/// <summary>
		/// Void RebuildOrderedVisualStates()
		/// </summary>
		protected RMethod r_MRebuildOrderedVisualStates;
		public virtual RMethod RMRebuildOrderedVisualStates
		{
			get
			{
				if(r_MRebuildOrderedVisualStates == null)
				{
					r_MRebuildOrderedVisualStates = new(this, "RebuildOrderedVisualStates", 0);
				}
				return r_MRebuildOrderedVisualStates;
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
				}
				return r_MGetDefaultLockState_IPackage;
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
				}
				return r_MRefreshVisualStates;
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
				}
				return r_MGetVisualState_String;
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
				}
				return r_MContains_String;
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
				}
				return r_MLoadExtraItems_IEnumerable_d_IPackage_p_;
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
				}
				return r_MAddSubPage_SubPage;
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
				}
				return r_MGetGroupName_IPackage;
			}
		}

		/// <summary>
		/// Boolean <get_currentSubPage>b__15_0(UnityEditor.PackageManager.UI.Internal.SubPage)
		/// </summary>
		protected RMethod r_M__0__get_currentSubPage__1__b__15_0_SubPage;
		public virtual RMethod RM__0__get_currentSubPage__1__b__15_0_SubPage
		{
			get
			{
				if(r_M__0__get_currentSubPage__1__b__15_0_SubPage == null)
				{
					r_M__0__get_currentSubPage__1__b__15_0_SubPage = new(this, "<get_currentSubPage>b__15_0", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.SubPage"));
				}
				return r_M__0__get_currentSubPage__1__b__15_0_SubPage;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackage <TriggerOnSelectionChanged>b__24_0(UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair)
		/// </summary>
		protected RMethod r_M__0__TriggerOnSelectionChanged__1__b__24_0_PackageAndVersionIdPair;
		public virtual RMethod RM__0__TriggerOnSelectionChanged__1__b__24_0_PackageAndVersionIdPair
		{
			get
			{
				if(r_M__0__TriggerOnSelectionChanged__1__b__24_0_PackageAndVersionIdPair == null)
				{
					r_M__0__TriggerOnSelectionChanged__1__b__24_0_PackageAndVersionIdPair = new(this, "<TriggerOnSelectionChanged>b__24_0", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair"));
				}
				return r_M__0__TriggerOnSelectionChanged__1__b__24_0_PackageAndVersionIdPair;
			}
		}

		/// <summary>
		/// Boolean <TriggerOnSelectionChanged>b__24_2(UnityEditor.PackageManager.UI.Internal.IPackage)
		/// </summary>
		protected RMethod r_M__0__TriggerOnSelectionChanged__1__b__24_2_IPackage;
		public virtual RMethod RM__0__TriggerOnSelectionChanged__1__b__24_2_IPackage
		{
			get
			{
				if(r_M__0__TriggerOnSelectionChanged__1__b__24_2_IPackage == null)
				{
					r_M__0__TriggerOnSelectionChanged__1__b__24_2_IPackage = new(this, "<TriggerOnSelectionChanged>b__24_2", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"));
				}
				return r_M__0__TriggerOnSelectionChanged__1__b__24_2_IPackage;
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
				}
				return r_MTriggerOnListRebuild;
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
				}
				return r_MTriggerOnVisualStateChange_IEnumerable_d_VisualState_p_;
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
				}
				return r_MContains_IPackage;
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


        public virtual void ResolveDependencies(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDatabase @packageDatabase, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFiltering @packageFiltering)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageDatabase.Value, @packageFiltering.Value};
            var ___result = RMResolveDependencies_PackageDatabase_PackageFiltering.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean UpdateFilters(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageFilters @filters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filters.Value};
            var ___result = RMUpdateFilters_PageFilters.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnPackagesChanged(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackagesChangeArgs @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args.Value};
            var ___result = RMOnPackagesChanged_PackagesChangeArgs.Invoke(___genericsType, ___parameters);

            
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


        public virtual void TriggerOnSelectionChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTriggerOnSelectionChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Rebuild()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRebuild.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RebuildOrderedVisualStates()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRebuildOrderedVisualStates.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetDefaultLockState(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RMGetDefaultLockState_IPackage.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RefreshVisualStates()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefreshVisualStates.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState GetVisualState(System.String @packageUniqueId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueId};
            var ___result = RMGetVisualState_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState(___result);
        }


        public virtual System.Boolean Contains(System.String @packageUniqueId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueId};
            var ___result = RMContains_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void LoadMore(System.Int64 @numberOfPackages)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@numberOfPackages};
            var ___result = RMLoadMore_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Load(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value, @version.Value};
            var ___result = RMLoad_IPackage_IPackageVersion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadExtraItems(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @packages)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packages.Value};
            var ___result = RMLoadExtraItems_IEnumerable_d_IPackage_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddSubPage(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RSubPage @subPage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@subPage.Value};
            var ___result = RMAddSubPage_SubPage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetGroupName(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RMGetGroupName_IPackage.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean __0__get_currentSubPage__1__b__15_0(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RSubPage @page)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@page.Value};
            var ___result = RM__0__get_currentSubPage__1__b__15_0_SubPage.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage __0__TriggerOnSelectionChanged__1__b__24_0(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value};
            var ___result = RM__0__TriggerOnSelectionChanged__1__b__24_0_PackageAndVersionIdPair.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage(___result);
        }


        public virtual System.Boolean __0__TriggerOnSelectionChanged__1__b__24_2(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p.Value};
            var ___result = RM__0__TriggerOnSelectionChanged__1__b__24_2_IPackage.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ResolveDependencies(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDatabase @packageDatabase)
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


        public virtual void TriggerOnListUpdate(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @added, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @updated, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @removed)
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


        public virtual void TriggerOnVisualStateChange(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState> @visualStates)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@visualStates.Value};
            var ___result = RMTriggerOnVisualStateChange_IEnumerable_d_VisualState_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TriggerOnSubPageChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTriggerOnSubPageChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageSelection GetSelection()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSelection.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageSelection(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState> GetSelectedVisualStates()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSelectedVisualStates.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState>(___result);
        }


        public virtual System.Boolean SetNewSelection(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair> @packageAndVersionIds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageAndVersionIds.Value};
            var ___result = RMSetNewSelection_IEnumerable_d_PackageAndVersionIdPair_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean AmendSelection(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair> @toAddOrUpdate, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair> @toRemove)
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


        public virtual System.Boolean Contains(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RMContains_IPackage.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
