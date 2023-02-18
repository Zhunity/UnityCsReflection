
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.IPage
	/// </summary>
    public partial class RIPage : RMember //
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


        public RIPage() : base("UnityEditor.PackageManager.UI.Internal.IPage")
        {
        }

        public RIPage(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.IPage")
		{
            SetInstance(instance);
		}

        public RIPage(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIPage(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void AddSubPage(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RSubPage @subPage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@subPage.Value};
            var ___result = RMAddSubPage_SubPage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState GetVisualState(System.String @packageUniqueId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueId};
            var ___result = RMGetVisualState_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState(___result);
        }


        public virtual void LoadMore(System.Int64 @numberOfPackages)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@numberOfPackages};
            var ___result = RMLoadMore_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ClearFilters()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearFilters.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean UpdateFilters(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageFilters @filters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filters.Value};
            var ___result = RMUpdateFilters_PageFilters.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual void OnPackagesChanged(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackagesChangeArgs @args)
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


        public virtual System.Boolean SetNewSelection(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair> @packageAndVersionIdPairs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageAndVersionIdPairs.Value};
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


        public virtual void TriggerOnSelectionChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTriggerOnSelectionChanged.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.String GetGroupName(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RMGetGroupName_IPackage.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Contains(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RMContains_IPackage.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Contains(System.String @packageUniqueId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueId};
            var ___result = RMContains_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.Boolean GetDefaultLockState(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RMGetDefaultLockState_IPackage.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


    }
}
