
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.PageManager
	/// </summary>
    public partial class RPageManager : RMember //
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
					r_EonSelectionChanged.SetBelong(this.GetValue());
				}
				return r_EonSelectionChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.VisualState]] onVisualStateChange
		/// </summary>
		protected REvent r_EonVisualStateChange;
		public virtual REvent REonVisualStateChange
		{
			get
			{
				if(r_EonVisualStateChange == null)
				{
					r_EonVisualStateChange = new(this, "onVisualStateChange");
					r_EonVisualStateChange.SetBelong(this.GetValue());
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
					r_EonListUpdate.SetBelong(this.GetValue());
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
					r_EonListRebuild.SetBelong(this.GetValue());
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
					r_EonSubPageChanged.SetBelong(this.GetValue());
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
					r_EonFiltersChange.SetBelong(this.GetValue());
				}
				return r_EonFiltersChange;
			}
		}

		/// <summary>
		/// System.Action onRefreshOperationStart
		/// </summary>
		protected REvent r_EonRefreshOperationStart;
		public virtual REvent REonRefreshOperationStart
		{
			get
			{
				if(r_EonRefreshOperationStart == null)
				{
					r_EonRefreshOperationStart = new(this, "onRefreshOperationStart");
					r_EonRefreshOperationStart.SetBelong(this.GetValue());
				}
				return r_EonRefreshOperationStart;
			}
		}

		/// <summary>
		/// System.Action onRefreshOperationFinish
		/// </summary>
		protected REvent r_EonRefreshOperationFinish;
		public virtual REvent REonRefreshOperationFinish
		{
			get
			{
				if(r_EonRefreshOperationFinish == null)
				{
					r_EonRefreshOperationFinish = new(this, "onRefreshOperationFinish");
					r_EonRefreshOperationFinish.SetBelong(this.GetValue());
				}
				return r_EonRefreshOperationFinish;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.UIError] onRefreshOperationError
		/// </summary>
		protected REvent r_EonRefreshOperationError;
		public virtual REvent REonRefreshOperationError
		{
			get
			{
				if(r_EonRefreshOperationError == null)
				{
					r_EonRefreshOperationError = new(this, "onRefreshOperationError");
					r_EonRefreshOperationError.SetBelong(this.GetValue());
				}
				return r_EonRefreshOperationError;
			}
		}

		/// <summary>
		/// System.String k_AssetStorePackageGroupName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_AssetStorePackageGroupName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_AssetStorePackageGroupName
		{
			get
			{
				if(r_Fk_AssetStorePackageGroupName == null)
				{
					r_Fk_AssetStorePackageGroupName = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PageManager"), "k_AssetStorePackageGroupName");
					r_Fk_AssetStorePackageGroupName.SetBelong(null);
				}
				return r_Fk_AssetStorePackageGroupName;
			}
		}

		/// <summary>
		/// System.String k_UnityPackageGroupName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_UnityPackageGroupName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_UnityPackageGroupName
		{
			get
			{
				if(r_Fk_UnityPackageGroupName == null)
				{
					r_Fk_UnityPackageGroupName = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PageManager"), "k_UnityPackageGroupName");
					r_Fk_UnityPackageGroupName.SetBelong(null);
				}
				return r_Fk_UnityPackageGroupName;
			}
		}

		/// <summary>
		/// System.String k_OtherPackageGroupName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_OtherPackageGroupName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_OtherPackageGroupName
		{
			get
			{
				if(r_Fk_OtherPackageGroupName == null)
				{
					r_Fk_OtherPackageGroupName = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PageManager"), "k_OtherPackageGroupName");
					r_Fk_OtherPackageGroupName.SetBelong(null);
				}
				return r_Fk_OtherPackageGroupName;
			}
		}

		/// <summary>
		/// System.Int32 k_DefaultPageSize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_DefaultPageSize;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_DefaultPageSize
		{
			get
			{
				if(r_Fk_DefaultPageSize == null)
				{
					r_Fk_DefaultPageSize = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PageManager"), "k_DefaultPageSize");
					r_Fk_DefaultPageSize.SetBelong(null);
				}
				return r_Fk_DefaultPageSize;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.RefreshOptions[] k_RefreshOptionsByTab
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRefreshOptions> r_Fk_RefreshOptionsByTab;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRefreshOptions> RFk_RefreshOptionsByTab
		{
			get
			{
				if(r_Fk_RefreshOptionsByTab == null)
				{
					r_Fk_RefreshOptionsByTab = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PageManager"), "k_RefreshOptionsByTab");
					r_Fk_RefreshOptionsByTab.SetBelong(null);
				}
				return r_Fk_RefreshOptionsByTab;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.PageSelection] onSelectionChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageSelection> r_FonSelectionChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageSelection> RFonSelectionChanged
		{
			get
			{
				if(r_FonSelectionChanged == null)
				{
					r_FonSelectionChanged = new(this, "onSelectionChanged");
					r_FonSelectionChanged.SetBelong(this.GetValue());
				}
				return r_FonSelectionChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.VisualState]] onVisualStateChange
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState>> r_FonVisualStateChange;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState>> RFonVisualStateChange
		{
			get
			{
				if(r_FonVisualStateChange == null)
				{
					r_FonVisualStateChange = new(this, "onVisualStateChange");
					r_FonVisualStateChange.SetBelong(this.GetValue());
				}
				return r_FonVisualStateChange;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.ListUpdateArgs] onListUpdate
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RListUpdateArgs> r_FonListUpdate;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RListUpdateArgs> RFonListUpdate
		{
			get
			{
				if(r_FonListUpdate == null)
				{
					r_FonListUpdate = new(this, "onListUpdate");
					r_FonListUpdate.SetBelong(this.GetValue());
				}
				return r_FonListUpdate;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IPage] onListRebuild
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPage> r_FonListRebuild;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPage> RFonListRebuild
		{
			get
			{
				if(r_FonListRebuild == null)
				{
					r_FonListRebuild = new(this, "onListRebuild");
					r_FonListRebuild.SetBelong(this.GetValue());
				}
				return r_FonListRebuild;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IPage] onSubPageChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPage> r_FonSubPageChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPage> RFonSubPageChanged
		{
			get
			{
				if(r_FonSubPageChanged == null)
				{
					r_FonSubPageChanged = new(this, "onSubPageChanged");
					r_FonSubPageChanged.SetBelong(this.GetValue());
				}
				return r_FonSubPageChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.PageFilters] onFiltersChange
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageFilters> r_FonFiltersChange;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageFilters> RFonFiltersChange
		{
			get
			{
				if(r_FonFiltersChange == null)
				{
					r_FonFiltersChange = new(this, "onFiltersChange");
					r_FonFiltersChange.SetBelong(this.GetValue());
				}
				return r_FonFiltersChange;
			}
		}

		/// <summary>
		/// System.Action onRefreshOperationStart
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_FonRefreshOperationStart;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFonRefreshOperationStart
		{
			get
			{
				if(r_FonRefreshOperationStart == null)
				{
					r_FonRefreshOperationStart = new(this, "onRefreshOperationStart");
					r_FonRefreshOperationStart.SetBelong(this.GetValue());
				}
				return r_FonRefreshOperationStart;
			}
		}

		/// <summary>
		/// System.Action onRefreshOperationFinish
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_FonRefreshOperationFinish;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFonRefreshOperationFinish
		{
			get
			{
				if(r_FonRefreshOperationFinish == null)
				{
					r_FonRefreshOperationFinish = new(this, "onRefreshOperationFinish");
					r_FonRefreshOperationFinish.SetBelong(this.GetValue());
				}
				return r_FonRefreshOperationFinish;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.UIError] onRefreshOperationError
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> r_FonRefreshOperationError;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> RFonRefreshOperationError
		{
			get
			{
				if(r_FonRefreshOperationError == null)
				{
					r_FonRefreshOperationError = new(this, "onRefreshOperationError");
					r_FonRefreshOperationError.SetBelong(this.GetValue());
				}
				return r_FonRefreshOperationError;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[UnityEditor.PackageManager.UI.Internal.RefreshOptions,System.Int64] m_RefreshTimestamps
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRefreshOptions, Hvak.Editor.Refleaction.RSystem.RInt64> r_Fm_RefreshTimestamps;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRefreshOptions, Hvak.Editor.Refleaction.RSystem.RInt64> RFm_RefreshTimestamps
		{
			get
			{
				if(r_Fm_RefreshTimestamps == null)
				{
					r_Fm_RefreshTimestamps = new(this, "m_RefreshTimestamps");
					r_Fm_RefreshTimestamps.SetBelong(this.GetValue());
				}
				return r_Fm_RefreshTimestamps;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[UnityEditor.PackageManager.UI.Internal.RefreshOptions,UnityEditor.PackageManager.UI.Internal.UIError] m_RefreshErrors
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRefreshOptions, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> r_Fm_RefreshErrors;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRefreshOptions, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> RFm_RefreshErrors
		{
			get
			{
				if(r_Fm_RefreshErrors == null)
				{
					r_Fm_RefreshErrors = new(this, "m_RefreshErrors");
					r_Fm_RefreshErrors.SetBelong(this.GetValue());
				}
				return r_Fm_RefreshErrors;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.IOperation] m_RefreshOperationsInProgress
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> r_Fm_RefreshOperationsInProgress;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> RFm_RefreshOperationsInProgress
		{
			get
			{
				if(r_Fm_RefreshOperationsInProgress == null)
				{
					r_Fm_RefreshOperationsInProgress = new(this, "m_RefreshOperationsInProgress");
					r_Fm_RefreshOperationsInProgress.SetBelong(this.GetValue());
				}
				return r_Fm_RefreshOperationsInProgress;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.RefreshOptions[] m_SerializedRefreshTimestampsKeys
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRefreshOptions> r_Fm_SerializedRefreshTimestampsKeys;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRefreshOptions> RFm_SerializedRefreshTimestampsKeys
		{
			get
			{
				if(r_Fm_SerializedRefreshTimestampsKeys == null)
				{
					r_Fm_SerializedRefreshTimestampsKeys = new(this, "m_SerializedRefreshTimestampsKeys");
					r_Fm_SerializedRefreshTimestampsKeys.SetBelong(this.GetValue());
				}
				return r_Fm_SerializedRefreshTimestampsKeys;
			}
		}

		/// <summary>
		/// System.Int64[] m_SerializedRefreshTimestampsValues
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt64> r_Fm_SerializedRefreshTimestampsValues;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt64> RFm_SerializedRefreshTimestampsValues
		{
			get
			{
				if(r_Fm_SerializedRefreshTimestampsValues == null)
				{
					r_Fm_SerializedRefreshTimestampsValues = new(this, "m_SerializedRefreshTimestampsValues");
					r_Fm_SerializedRefreshTimestampsValues.SetBelong(this.GetValue());
				}
				return r_Fm_SerializedRefreshTimestampsValues;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.RefreshOptions[] m_SerializedRefreshErrorsKeys
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRefreshOptions> r_Fm_SerializedRefreshErrorsKeys;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRefreshOptions> RFm_SerializedRefreshErrorsKeys
		{
			get
			{
				if(r_Fm_SerializedRefreshErrorsKeys == null)
				{
					r_Fm_SerializedRefreshErrorsKeys = new(this, "m_SerializedRefreshErrorsKeys");
					r_Fm_SerializedRefreshErrorsKeys.SetBelong(this.GetValue());
				}
				return r_Fm_SerializedRefreshErrorsKeys;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UIError[] m_SerializedRefreshErrorsValues
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> r_Fm_SerializedRefreshErrorsValues;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> RFm_SerializedRefreshErrorsValues
		{
			get
			{
				if(r_Fm_SerializedRefreshErrorsValues == null)
				{
					r_Fm_SerializedRefreshErrorsValues = new(this, "m_SerializedRefreshErrorsValues");
					r_Fm_SerializedRefreshErrorsValues.SetBelong(this.GetValue());
				}
				return r_Fm_SerializedRefreshErrorsValues;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[UnityEditor.PackageManager.UI.Internal.PackageFilterTab,UnityEditor.PackageManager.UI.Internal.IPage] m_Pages
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPage> r_Fm_Pages;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPage> RFm_Pages
		{
			get
			{
				if(r_Fm_Pages == null)
				{
					r_Fm_Pages = new(this, "m_Pages");
					r_Fm_Pages.SetBelong(this.GetValue());
				}
				return r_Fm_Pages;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.SimplePage[] m_SerializedSimplePages
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RSimplePage> r_Fm_SerializedSimplePages;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RSimplePage> RFm_SerializedSimplePages
		{
			get
			{
				if(r_Fm_SerializedSimplePages == null)
				{
					r_Fm_SerializedSimplePages = new(this, "m_SerializedSimplePages");
					r_Fm_SerializedSimplePages.SetBelong(this.GetValue());
				}
				return r_Fm_SerializedSimplePages;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PaginatedPage[] m_SerializedPaginatedPage
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPaginatedPage> r_Fm_SerializedPaginatedPage;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPaginatedPage> RFm_SerializedPaginatedPage
		{
			get
			{
				if(r_Fm_SerializedPaginatedPage == null)
				{
					r_Fm_SerializedPaginatedPage = new(this, "m_SerializedPaginatedPage");
					r_Fm_SerializedPaginatedPage.SetBelong(this.GetValue());
				}
				return r_Fm_SerializedPaginatedPage;
			}
		}

		/// <summary>
		/// System.Int32[] m_SerializedPackageSelectionInstanceIds
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_Fm_SerializedPackageSelectionInstanceIds;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFm_SerializedPackageSelectionInstanceIds
		{
			get
			{
				if(r_Fm_SerializedPackageSelectionInstanceIds == null)
				{
					r_Fm_SerializedPackageSelectionInstanceIds = new(this, "m_SerializedPackageSelectionInstanceIds");
					r_Fm_SerializedPackageSelectionInstanceIds.SetBelong(this.GetValue());
				}
				return r_Fm_SerializedPackageSelectionInstanceIds;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEditor.PackageManager.UI.Internal.PackageSelectionObject] m_PackageSelectionObjects
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageSelectionObject> r_Fm_PackageSelectionObjects;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageSelectionObject> RFm_PackageSelectionObjects
		{
			get
			{
				if(r_Fm_PackageSelectionObjects == null)
				{
					r_Fm_PackageSelectionObjects = new(this, "m_PackageSelectionObjects");
					r_Fm_PackageSelectionObjects.SetBelong(this.GetValue());
				}
				return r_Fm_PackageSelectionObjects;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.ApplicationProxy m_Application
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RApplicationProxy r_Fm_Application;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RApplicationProxy RFm_Application
		{
			get
			{
				if(r_Fm_Application == null)
				{
					r_Fm_Application = new(this, "m_Application");
					r_Fm_Application.SetBelong(this.GetValue());
				}
				return r_Fm_Application;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.SelectionProxy m_Selection
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RSelectionProxy r_Fm_Selection;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RSelectionProxy RFm_Selection
		{
			get
			{
				if(r_Fm_Selection == null)
				{
					r_Fm_Selection = new(this, "m_Selection");
					r_Fm_Selection.SetBelong(this.GetValue());
				}
				return r_Fm_Selection;
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
					r_Fm_UnityConnect.SetBelong(this.GetValue());
				}
				return r_Fm_UnityConnect;
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
					r_Fm_PackageFiltering.SetBelong(this.GetValue());
				}
				return r_Fm_PackageFiltering;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageManagerPrefs m_PackageManagerPrefs
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerPrefs r_Fm_PackageManagerPrefs;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerPrefs RFm_PackageManagerPrefs
		{
			get
			{
				if(r_Fm_PackageManagerPrefs == null)
				{
					r_Fm_PackageManagerPrefs = new(this, "m_PackageManagerPrefs");
					r_Fm_PackageManagerPrefs.SetBelong(this.GetValue());
				}
				return r_Fm_PackageManagerPrefs;
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
					r_Fm_UpmCache.SetBelong(this.GetValue());
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
					r_Fm_UpmClient.SetBelong(this.GetValue());
				}
				return r_Fm_UpmClient;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmRegistryClient m_UpmRegistryClient
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmRegistryClient r_Fm_UpmRegistryClient;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmRegistryClient RFm_UpmRegistryClient
		{
			get
			{
				if(r_Fm_UpmRegistryClient == null)
				{
					r_Fm_UpmRegistryClient = new(this, "m_UpmRegistryClient");
					r_Fm_UpmRegistryClient.SetBelong(this.GetValue());
				}
				return r_Fm_UpmRegistryClient;
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
					r_Fm_AssetStoreClient.SetBelong(this.GetValue());
				}
				return r_Fm_AssetStoreClient;
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
					r_Fm_PackageDatabase.SetBelong(this.GetValue());
				}
				return r_Fm_PackageDatabase;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettingsProxy m_SettingsProxy
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerProjectSettingsProxy r_Fm_SettingsProxy;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerProjectSettingsProxy RFm_SettingsProxy
		{
			get
			{
				if(r_Fm_SettingsProxy == null)
				{
					r_Fm_SettingsProxy = new(this, "m_SettingsProxy");
					r_Fm_SettingsProxy.SetBelong(this.GetValue());
				}
				return r_Fm_SettingsProxy;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.ApplicationProxy, UnityEditor.PackageManager.UI.Internal.SelectionProxy, UnityEditor.PackageManager.UI.Internal.UnityConnectProxy, UnityEditor.PackageManager.UI.Internal.PackageFiltering, UnityEditor.PackageManager.UI.Internal.PackageManagerPrefs, UnityEditor.PackageManager.UI.Internal.UpmCache, UnityEditor.PackageManager.UI.Internal.UpmClient, UnityEditor.PackageManager.UI.Internal.UpmRegistryClient, UnityEditor.PackageManager.UI.Internal.AssetStoreClient, UnityEditor.PackageManager.UI.Internal.PackageDatabase, UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettingsProxy)
		/// </summary>
		protected RMethod r_MResolveDependencies_ApplicationProxy_SelectionProxy_UnityConnectProxy_PackageFiltering_PackageManagerPrefs_UpmCache_UpmClient_UpmRegistryClient_AssetStoreClient_PackageDatabase_PackageManagerProjectSettingsProxy;
		public virtual RMethod RMResolveDependencies_ApplicationProxy_SelectionProxy_UnityConnectProxy_PackageFiltering_PackageManagerPrefs_UpmCache_UpmClient_UpmRegistryClient_AssetStoreClient_PackageDatabase_PackageManagerProjectSettingsProxy
		{
			get
			{
				if(r_MResolveDependencies_ApplicationProxy_SelectionProxy_UnityConnectProxy_PackageFiltering_PackageManagerPrefs_UpmCache_UpmClient_UpmRegistryClient_AssetStoreClient_PackageDatabase_PackageManagerProjectSettingsProxy == null)
				{
					r_MResolveDependencies_ApplicationProxy_SelectionProxy_UnityConnectProxy_PackageFiltering_PackageManagerPrefs_UpmCache_UpmClient_UpmRegistryClient_AssetStoreClient_PackageDatabase_PackageManagerProjectSettingsProxy = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.ApplicationProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.SelectionProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UnityConnectProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageFiltering"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageManagerPrefs"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmCache"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmClient"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmRegistryClient"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreClient"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageDatabase"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettingsProxy"));
					r_MResolveDependencies_ApplicationProxy_SelectionProxy_UnityConnectProxy_PackageFiltering_PackageManagerPrefs_UpmCache_UpmClient_UpmRegistryClient_AssetStoreClient_PackageDatabase_PackageManagerProjectSettingsProxy.SetBelong(this.GetValue());
				}
				return r_MResolveDependencies_ApplicationProxy_SelectionProxy_UnityConnectProxy_PackageFiltering_PackageManagerPrefs_UpmCache_UpmClient_UpmRegistryClient_AssetStoreClient_PackageDatabase_PackageManagerProjectSettingsProxy;
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
					r_MOnBeforeSerialize.SetBelong(this.GetValue());
				}
				return r_MOnBeforeSerialize;
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
					r_MOnAfterDeserialize.SetBelong(this.GetValue());
				}
				return r_MOnAfterDeserialize;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageSelectionObject GetPackageSelectionObject(UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair, Boolean)
		/// </summary>
		protected RMethod r_MGetPackageSelectionObject_PackageAndVersionIdPair_Boolean;
		public virtual RMethod RMGetPackageSelectionObject_PackageAndVersionIdPair_Boolean
		{
			get
			{
				if(r_MGetPackageSelectionObject_PackageAndVersionIdPair_Boolean == null)
				{
					r_MGetPackageSelectionObject_PackageAndVersionIdPair_Boolean = new(this, "GetPackageSelectionObject", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair"), typeof(System.Boolean));
					r_MGetPackageSelectionObject_PackageAndVersionIdPair_Boolean.SetBelong(this.GetValue());
				}
				return r_MGetPackageSelectionObject_PackageAndVersionIdPair_Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageSelectionObject GetPackageSelectionObject(UnityEditor.PackageManager.UI.Internal.IPackage, UnityEditor.PackageManager.UI.Internal.IPackageVersion, Boolean)
		/// </summary>
		protected RMethod r_MGetPackageSelectionObject_IPackage_IPackageVersion_Boolean;
		public virtual RMethod RMGetPackageSelectionObject_IPackage_IPackageVersion_Boolean
		{
			get
			{
				if(r_MGetPackageSelectionObject_IPackage_IPackageVersion_Boolean == null)
				{
					r_MGetPackageSelectionObject_IPackage_IPackageVersion_Boolean = new(this, "GetPackageSelectionObject", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"), typeof(System.Boolean));
					r_MGetPackageSelectionObject_IPackage_IPackageVersion_Boolean.SetBelong(this.GetValue());
				}
				return r_MGetPackageSelectionObject_IPackage_IPackageVersion_Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPage GetPageFromTab(System.Nullable`1[UnityEditor.PackageManager.UI.Internal.PackageFilterTab])
		/// </summary>
		protected RMethod r_MGetPageFromTab_Nullable_d_PackageFilterTab_p_;
		public virtual RMethod RMGetPageFromTab_Nullable_d_PackageFilterTab_p_
		{
			get
			{
				if(r_MGetPageFromTab_Nullable_d_PackageFilterTab_p_ == null)
				{
					r_MGetPageFromTab_Nullable_d_PackageFilterTab_p_ = new(this, "GetPageFromTab", 0, typeof(System.Nullable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageFilterTab")));
					r_MGetPageFromTab_Nullable_d_PackageFilterTab_p_.SetBelong(this.GetValue());
				}
				return r_MGetPageFromTab_Nullable_d_PackageFilterTab_p_;
			}
		}

		/// <summary>
		/// T GetPageFromTab[T](System.Nullable`1[UnityEditor.PackageManager.UI.Internal.PackageFilterTab])
		/// </summary>
		protected RMethod r_MGetPageFromTab_GT_Nullable_d_PackageFilterTab_p_;
		public virtual RMethod RMGetPageFromTab_GT_Nullable_d_PackageFilterTab_p_
		{
			get
			{
				if(r_MGetPageFromTab_GT_Nullable_d_PackageFilterTab_p_ == null)
				{
					r_MGetPageFromTab_GT_Nullable_d_PackageFilterTab_p_ = new(this, "GetPageFromTab", 1, typeof(System.Nullable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageFilterTab")));
					r_MGetPageFromTab_GT_Nullable_d_PackageFilterTab_p_.SetBelong(this.GetValue());
				}
				return r_MGetPageFromTab_GT_Nullable_d_PackageFilterTab_p_;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPage CreatePageFromTab(System.Nullable`1[UnityEditor.PackageManager.UI.Internal.PackageFilterTab])
		/// </summary>
		protected RMethod r_MCreatePageFromTab_Nullable_d_PackageFilterTab_p_;
		public virtual RMethod RMCreatePageFromTab_Nullable_d_PackageFilterTab_p_
		{
			get
			{
				if(r_MCreatePageFromTab_Nullable_d_PackageFilterTab_p_ == null)
				{
					r_MCreatePageFromTab_Nullable_d_PackageFilterTab_p_ = new(this, "CreatePageFromTab", 0, typeof(System.Nullable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageFilterTab")));
					r_MCreatePageFromTab_Nullable_d_PackageFilterTab_p_.SetBelong(this.GetValue());
				}
				return r_MCreatePageFromTab_Nullable_d_PackageFilterTab_p_;
			}
		}

		/// <summary>
		/// Void RegisterPageEvents(UnityEditor.PackageManager.UI.Internal.IPage)
		/// </summary>
		protected RMethod r_MRegisterPageEvents_IPage;
		public virtual RMethod RMRegisterPageEvents_IPage
		{
			get
			{
				if(r_MRegisterPageEvents_IPage == null)
				{
					r_MRegisterPageEvents_IPage = new(this, "RegisterPageEvents", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPage"));
					r_MRegisterPageEvents_IPage.SetBelong(this.GetValue());
				}
				return r_MRegisterPageEvents_IPage;
			}
		}

		/// <summary>
		/// Void UnregisterPageEvents(UnityEditor.PackageManager.UI.Internal.IPage)
		/// </summary>
		protected RMethod r_MUnregisterPageEvents_IPage;
		public virtual RMethod RMUnregisterPageEvents_IPage
		{
			get
			{
				if(r_MUnregisterPageEvents_IPage == null)
				{
					r_MUnregisterPageEvents_IPage = new(this, "UnregisterPageEvents", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPage"));
					r_MUnregisterPageEvents_IPage.SetBelong(this.GetValue());
				}
				return r_MUnregisterPageEvents_IPage;
			}
		}

		/// <summary>
		/// Void OnPageSelectionChanged(UnityEditor.PackageManager.UI.Internal.PageSelection)
		/// </summary>
		protected RMethod r_MOnPageSelectionChanged_PageSelection;
		public virtual RMethod RMOnPageSelectionChanged_PageSelection
		{
			get
			{
				if(r_MOnPageSelectionChanged_PageSelection == null)
				{
					r_MOnPageSelectionChanged_PageSelection = new(this, "OnPageSelectionChanged", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PageSelection"));
					r_MOnPageSelectionChanged_PageSelection.SetBelong(this.GetValue());
				}
				return r_MOnPageSelectionChanged_PageSelection;
			}
		}

		/// <summary>
		/// Void TriggerOnVisualStateChange(UnityEditor.PackageManager.UI.Internal.VisualStateChangeArgs)
		/// </summary>
		protected RMethod r_MTriggerOnVisualStateChange_VisualStateChangeArgs;
		public virtual RMethod RMTriggerOnVisualStateChange_VisualStateChangeArgs
		{
			get
			{
				if(r_MTriggerOnVisualStateChange_VisualStateChangeArgs == null)
				{
					r_MTriggerOnVisualStateChange_VisualStateChangeArgs = new(this, "TriggerOnVisualStateChange", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.VisualStateChangeArgs"));
					r_MTriggerOnVisualStateChange_VisualStateChangeArgs.SetBelong(this.GetValue());
				}
				return r_MTriggerOnVisualStateChange_VisualStateChangeArgs;
			}
		}

		/// <summary>
		/// Void TriggerOnPageUpdate(UnityEditor.PackageManager.UI.Internal.ListUpdateArgs)
		/// </summary>
		protected RMethod r_MTriggerOnPageUpdate_ListUpdateArgs;
		public virtual RMethod RMTriggerOnPageUpdate_ListUpdateArgs
		{
			get
			{
				if(r_MTriggerOnPageUpdate_ListUpdateArgs == null)
				{
					r_MTriggerOnPageUpdate_ListUpdateArgs = new(this, "TriggerOnPageUpdate", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.ListUpdateArgs"));
					r_MTriggerOnPageUpdate_ListUpdateArgs.SetBelong(this.GetValue());
				}
				return r_MTriggerOnPageUpdate_ListUpdateArgs;
			}
		}

		/// <summary>
		/// Void TriggerOnPageRebuild(UnityEditor.PackageManager.UI.Internal.IPage)
		/// </summary>
		protected RMethod r_MTriggerOnPageRebuild_IPage;
		public virtual RMethod RMTriggerOnPageRebuild_IPage
		{
			get
			{
				if(r_MTriggerOnPageRebuild_IPage == null)
				{
					r_MTriggerOnPageRebuild_IPage = new(this, "TriggerOnPageRebuild", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPage"));
					r_MTriggerOnPageRebuild_IPage.SetBelong(this.GetValue());
				}
				return r_MTriggerOnPageRebuild_IPage;
			}
		}

		/// <summary>
		/// Void TriggerOnSubPageChanged(UnityEditor.PackageManager.UI.Internal.IPage)
		/// </summary>
		protected RMethod r_MTriggerOnSubPageChanged_IPage;
		public virtual RMethod RMTriggerOnSubPageChanged_IPage
		{
			get
			{
				if(r_MTriggerOnSubPageChanged_IPage == null)
				{
					r_MTriggerOnSubPageChanged_IPage = new(this, "TriggerOnSubPageChanged", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPage"));
					r_MTriggerOnSubPageChanged_IPage.SetBelong(this.GetValue());
				}
				return r_MTriggerOnSubPageChanged_IPage;
			}
		}

		/// <summary>
		/// Void TriggerOnFiltersChange(UnityEditor.PackageManager.UI.Internal.PageFilters)
		/// </summary>
		protected RMethod r_MTriggerOnFiltersChange_PageFilters;
		public virtual RMethod RMTriggerOnFiltersChange_PageFilters
		{
			get
			{
				if(r_MTriggerOnFiltersChange_PageFilters == null)
				{
					r_MTriggerOnFiltersChange_PageFilters = new(this, "TriggerOnFiltersChange", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PageFilters"));
					r_MTriggerOnFiltersChange_PageFilters.SetBelong(this.GetValue());
				}
				return r_MTriggerOnFiltersChange_PageFilters;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPage GetCurrentPage()
		/// </summary>
		protected RMethod r_MGetCurrentPage;
		public virtual RMethod RMGetCurrentPage
		{
			get
			{
				if(r_MGetCurrentPage == null)
				{
					r_MGetCurrentPage = new(this, "GetCurrentPage", 0);
					r_MGetCurrentPage.SetBelong(this.GetValue());
				}
				return r_MGetCurrentPage;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPage GetPage(UnityEditor.PackageManager.UI.Internal.PackageFilterTab)
		/// </summary>
		protected RMethod r_MGetPage_PackageFilterTab;
		public virtual RMethod RMGetPage_PackageFilterTab
		{
			get
			{
				if(r_MGetPage_PackageFilterTab == null)
				{
					r_MGetPage_PackageFilterTab = new(this, "GetPage", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageFilterTab"));
					r_MGetPage_PackageFilterTab.SetBelong(this.GetValue());
				}
				return r_MGetPage_PackageFilterTab;
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
					r_MGetSelection.SetBelong(this.GetValue());
				}
				return r_MGetSelection;
			}
		}

		/// <summary>
		/// Void ClearSelection()
		/// </summary>
		protected RMethod r_MClearSelection;
		public virtual RMethod RMClearSelection
		{
			get
			{
				if(r_MClearSelection == null)
				{
					r_MClearSelection = new(this, "ClearSelection", 0);
					r_MClearSelection.SetBelong(this.GetValue());
				}
				return r_MClearSelection;
			}
		}

		/// <summary>
		/// Void SetSelected(UnityEditor.PackageManager.UI.Internal.IPackage, UnityEditor.PackageManager.UI.Internal.IPackageVersion, Boolean)
		/// </summary>
		protected RMethod r_MSetSelected_IPackage_IPackageVersion_Boolean;
		public virtual RMethod RMSetSelected_IPackage_IPackageVersion_Boolean
		{
			get
			{
				if(r_MSetSelected_IPackage_IPackageVersion_Boolean == null)
				{
					r_MSetSelected_IPackage_IPackageVersion_Boolean = new(this, "SetSelected", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"), typeof(System.Boolean));
					r_MSetSelected_IPackage_IPackageVersion_Boolean.SetBelong(this.GetValue());
				}
				return r_MSetSelected_IPackage_IPackageVersion_Boolean;
			}
		}

		/// <summary>
		/// Void SetSelected(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair], Boolean)
		/// </summary>
		protected RMethod r_MSetSelected_IEnumerable_d_PackageAndVersionIdPair_p__Boolean;
		public virtual RMethod RMSetSelected_IEnumerable_d_PackageAndVersionIdPair_p__Boolean
		{
			get
			{
				if(r_MSetSelected_IEnumerable_d_PackageAndVersionIdPair_p__Boolean == null)
				{
					r_MSetSelected_IEnumerable_d_PackageAndVersionIdPair_p__Boolean = new(this, "SetSelected", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair")), typeof(System.Boolean));
					r_MSetSelected_IEnumerable_d_PackageAndVersionIdPair_p__Boolean.SetBelong(this.GetValue());
				}
				return r_MSetSelected_IEnumerable_d_PackageAndVersionIdPair_p__Boolean;
			}
		}

		/// <summary>
		/// Void ToggleSelected(System.String, Boolean)
		/// </summary>
		protected RMethod r_MToggleSelected_String_Boolean;
		public virtual RMethod RMToggleSelected_String_Boolean
		{
			get
			{
				if(r_MToggleSelected_String_Boolean == null)
				{
					r_MToggleSelected_String_Boolean = new(this, "ToggleSelected", 0, typeof(System.String), typeof(System.Boolean));
					r_MToggleSelected_String_Boolean.SetBelong(this.GetValue());
				}
				return r_MToggleSelected_String_Boolean;
			}
		}

		/// <summary>
		/// Void AmendSelection(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair], System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair], Boolean)
		/// </summary>
		protected RMethod r_MAmendSelection_IEnumerable_d_PackageAndVersionIdPair_p__IEnumerable_d_PackageAndVersionIdPair_p__Boolean;
		public virtual RMethod RMAmendSelection_IEnumerable_d_PackageAndVersionIdPair_p__IEnumerable_d_PackageAndVersionIdPair_p__Boolean
		{
			get
			{
				if(r_MAmendSelection_IEnumerable_d_PackageAndVersionIdPair_p__IEnumerable_d_PackageAndVersionIdPair_p__Boolean == null)
				{
					r_MAmendSelection_IEnumerable_d_PackageAndVersionIdPair_p__IEnumerable_d_PackageAndVersionIdPair_p__Boolean = new(this, "AmendSelection", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair")), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair")), typeof(System.Boolean));
					r_MAmendSelection_IEnumerable_d_PackageAndVersionIdPair_p__IEnumerable_d_PackageAndVersionIdPair_p__Boolean.SetBelong(this.GetValue());
				}
				return r_MAmendSelection_IEnumerable_d_PackageAndVersionIdPair_p__IEnumerable_d_PackageAndVersionIdPair_p__Boolean;
			}
		}

		/// <summary>
		/// Void RemoveSelection(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair], Boolean)
		/// </summary>
		protected RMethod r_MRemoveSelection_IEnumerable_d_PackageAndVersionIdPair_p__Boolean;
		public virtual RMethod RMRemoveSelection_IEnumerable_d_PackageAndVersionIdPair_p__Boolean
		{
			get
			{
				if(r_MRemoveSelection_IEnumerable_d_PackageAndVersionIdPair_p__Boolean == null)
				{
					r_MRemoveSelection_IEnumerable_d_PackageAndVersionIdPair_p__Boolean = new(this, "RemoveSelection", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair")), typeof(System.Boolean));
					r_MRemoveSelection_IEnumerable_d_PackageAndVersionIdPair_p__Boolean.SetBelong(this.GetValue());
				}
				return r_MRemoveSelection_IEnumerable_d_PackageAndVersionIdPair_p__Boolean;
			}
		}

		/// <summary>
		/// Boolean UpdateSelectionIfCurrentSelectionIsInvalid()
		/// </summary>
		protected RMethod r_MUpdateSelectionIfCurrentSelectionIsInvalid;
		public virtual RMethod RMUpdateSelectionIfCurrentSelectionIsInvalid
		{
			get
			{
				if(r_MUpdateSelectionIfCurrentSelectionIsInvalid == null)
				{
					r_MUpdateSelectionIfCurrentSelectionIsInvalid = new(this, "UpdateSelectionIfCurrentSelectionIsInvalid", 0);
					r_MUpdateSelectionIfCurrentSelectionIsInvalid.SetBelong(this.GetValue());
				}
				return r_MUpdateSelectionIfCurrentSelectionIsInvalid;
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
					r_MTriggerOnSelectionChanged.SetBelong(this.GetValue());
				}
				return r_MTriggerOnSelectionChanged;
			}
		}

		/// <summary>
		/// Void SelectInInspector(UnityEditor.PackageManager.UI.Internal.PageSelection, Boolean)
		/// </summary>
		protected RMethod r_MSelectInInspector_PageSelection_Boolean;
		public virtual RMethod RMSelectInInspector_PageSelection_Boolean
		{
			get
			{
				if(r_MSelectInInspector_PageSelection_Boolean == null)
				{
					r_MSelectInInspector_PageSelection_Boolean = new(this, "SelectInInspector", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PageSelection"), typeof(System.Boolean));
					r_MSelectInInspector_PageSelection_Boolean.SetBelong(this.GetValue());
				}
				return r_MSelectInInspector_PageSelection_Boolean;
			}
		}

		/// <summary>
		/// Void SetSeeAllVersions(System.String, Boolean)
		/// </summary>
		protected RMethod r_MSetSeeAllVersions_String_Boolean;
		public virtual RMethod RMSetSeeAllVersions_String_Boolean
		{
			get
			{
				if(r_MSetSeeAllVersions_String_Boolean == null)
				{
					r_MSetSeeAllVersions_String_Boolean = new(this, "SetSeeAllVersions", 0, typeof(System.String), typeof(System.Boolean));
					r_MSetSeeAllVersions_String_Boolean.SetBelong(this.GetValue());
				}
				return r_MSetSeeAllVersions_String_Boolean;
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
					r_MIsGroupExpanded_String.SetBelong(this.GetValue());
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
					r_MSetGroupExpanded_String_Boolean.SetBelong(this.GetValue());
				}
				return r_MSetGroupExpanded_String_Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageFilterTab FindTab(UnityEditor.PackageManager.UI.Internal.IPackage, UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MFindTab_IPackage_IPackageVersion;
		public virtual RMethod RMFindTab_IPackage_IPackageVersion
		{
			get
			{
				if(r_MFindTab_IPackage_IPackageVersion == null)
				{
					r_MFindTab_IPackage_IPackageVersion = new(this, "FindTab", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
					r_MFindTab_IPackage_IPackageVersion.SetBelong(this.GetValue());
				}
				return r_MFindTab_IPackage_IPackageVersion;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageFilterTab FindTab(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackageVersion])
		/// </summary>
		protected RMethod r_MFindTab_IEnumerable_d_IPackageVersion_p_;
		public virtual RMethod RMFindTab_IEnumerable_d_IPackageVersion_p_
		{
			get
			{
				if(r_MFindTab_IEnumerable_d_IPackageVersion_p_ == null)
				{
					r_MFindTab_IEnumerable_d_IPackageVersion_p_ = new(this, "FindTab", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion")));
					r_MFindTab_IEnumerable_d_IPackageVersion_p_.SetBelong(this.GetValue());
				}
				return r_MFindTab_IEnumerable_d_IPackageVersion_p_;
			}
		}

		/// <summary>
		/// Void OnPackageUniqueIdFinalize(System.String, System.String)
		/// </summary>
		protected RMethod r_MOnPackageUniqueIdFinalize_String_String;
		public virtual RMethod RMOnPackageUniqueIdFinalize_String_String
		{
			get
			{
				if(r_MOnPackageUniqueIdFinalize_String_String == null)
				{
					r_MOnPackageUniqueIdFinalize_String_String = new(this, "OnPackageUniqueIdFinalize", 0, typeof(System.String), typeof(System.String));
					r_MOnPackageUniqueIdFinalize_String_String.SetBelong(this.GetValue());
				}
				return r_MOnPackageUniqueIdFinalize_String_String;
			}
		}

		/// <summary>
		/// Void OnSearchTextChanged(System.String)
		/// </summary>
		protected RMethod r_MOnSearchTextChanged_String;
		public virtual RMethod RMOnSearchTextChanged_String
		{
			get
			{
				if(r_MOnSearchTextChanged_String == null)
				{
					r_MOnSearchTextChanged_String = new(this, "OnSearchTextChanged", 0, typeof(System.String));
					r_MOnSearchTextChanged_String.SetBelong(this.GetValue());
				}
				return r_MOnSearchTextChanged_String;
			}
		}

		/// <summary>
		/// Void OnFilterChanged(UnityEditor.PackageManager.UI.Internal.PackageFilterTab)
		/// </summary>
		protected RMethod r_MOnFilterChanged_PackageFilterTab;
		public virtual RMethod RMOnFilterChanged_PackageFilterTab
		{
			get
			{
				if(r_MOnFilterChanged_PackageFilterTab == null)
				{
					r_MOnFilterChanged_PackageFilterTab = new(this, "OnFilterChanged", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageFilterTab"));
					r_MOnFilterChanged_PackageFilterTab.SetBelong(this.GetValue());
				}
				return r_MOnFilterChanged_PackageFilterTab;
			}
		}

		/// <summary>
		/// Void UpdateSearchTextOnPage(UnityEditor.PackageManager.UI.Internal.IPage, System.String)
		/// </summary>
		protected static RMethod r_MUpdateSearchTextOnPage_IPage_String;
		public static RMethod RMUpdateSearchTextOnPage_IPage_String
		{
			get
			{
				if(r_MUpdateSearchTextOnPage_IPage_String == null)
				{
					r_MUpdateSearchTextOnPage_IPage_String = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PageManager"), "UpdateSearchTextOnPage", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPage"), typeof(System.String));
					r_MUpdateSearchTextOnPage_IPage_String.SetBelong(null);
				}
				return r_MUpdateSearchTextOnPage_IPage_String;
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
					r_MOnPackagesChanged_PackagesChangeArgs.SetBelong(this.GetValue());
				}
				return r_MOnPackagesChanged_PackagesChangeArgs;
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
					r_MOnProductListFetched_AssetStorePurchases.SetBelong(this.GetValue());
				}
				return r_MOnProductListFetched_AssetStorePurchases;
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
					r_MOnProductExtraFetched_Int64.SetBelong(this.GetValue());
				}
				return r_MOnProductExtraFetched_Int64;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.VisualState GetVisualState(UnityEditor.PackageManager.UI.Internal.IPackage)
		/// </summary>
		protected RMethod r_MGetVisualState_IPackage;
		public virtual RMethod RMGetVisualState_IPackage
		{
			get
			{
				if(r_MGetVisualState_IPackage == null)
				{
					r_MGetVisualState_IPackage = new(this, "GetVisualState", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"));
					r_MGetVisualState_IPackage.SetBelong(this.GetValue());
				}
				return r_MGetVisualState_IPackage;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.RefreshOptions GetRefreshOptionsByTab(UnityEditor.PackageManager.UI.Internal.PackageFilterTab)
		/// </summary>
		protected static RMethod r_MGetRefreshOptionsByTab_PackageFilterTab;
		public static RMethod RMGetRefreshOptionsByTab_PackageFilterTab
		{
			get
			{
				if(r_MGetRefreshOptionsByTab_PackageFilterTab == null)
				{
					r_MGetRefreshOptionsByTab_PackageFilterTab = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PageManager"), "GetRefreshOptionsByTab", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageFilterTab"));
					r_MGetRefreshOptionsByTab_PackageFilterTab.SetBelong(null);
				}
				return r_MGetRefreshOptionsByTab_PackageFilterTab;
			}
		}

		/// <summary>
		/// Void Refresh(System.Nullable`1[UnityEditor.PackageManager.UI.Internal.PackageFilterTab])
		/// </summary>
		protected RMethod r_MRefresh_Nullable_d_PackageFilterTab_p_;
		public virtual RMethod RMRefresh_Nullable_d_PackageFilterTab_p_
		{
			get
			{
				if(r_MRefresh_Nullable_d_PackageFilterTab_p_ == null)
				{
					r_MRefresh_Nullable_d_PackageFilterTab_p_ = new(this, "Refresh", 0, typeof(System.Nullable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageFilterTab")));
					r_MRefresh_Nullable_d_PackageFilterTab_p_.SetBelong(this.GetValue());
				}
				return r_MRefresh_Nullable_d_PackageFilterTab_p_;
			}
		}

		/// <summary>
		/// Void Refresh(UnityEditor.PackageManager.UI.Internal.RefreshOptions)
		/// </summary>
		protected RMethod r_MRefresh_RefreshOptions;
		public virtual RMethod RMRefresh_RefreshOptions
		{
			get
			{
				if(r_MRefresh_RefreshOptions == null)
				{
					r_MRefresh_RefreshOptions = new(this, "Refresh", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.RefreshOptions"));
					r_MRefresh_RefreshOptions.SetBelong(this.GetValue());
				}
				return r_MRefresh_RefreshOptions;
			}
		}

		/// <summary>
		/// Void CancelRefresh(System.Nullable`1[UnityEditor.PackageManager.UI.Internal.PackageFilterTab])
		/// </summary>
		protected RMethod r_MCancelRefresh_Nullable_d_PackageFilterTab_p_;
		public virtual RMethod RMCancelRefresh_Nullable_d_PackageFilterTab_p_
		{
			get
			{
				if(r_MCancelRefresh_Nullable_d_PackageFilterTab_p_ == null)
				{
					r_MCancelRefresh_Nullable_d_PackageFilterTab_p_ = new(this, "CancelRefresh", 0, typeof(System.Nullable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageFilterTab")));
					r_MCancelRefresh_Nullable_d_PackageFilterTab_p_.SetBelong(this.GetValue());
				}
				return r_MCancelRefresh_Nullable_d_PackageFilterTab_p_;
			}
		}

		/// <summary>
		/// Void CancelRefresh(UnityEditor.PackageManager.UI.Internal.RefreshOptions)
		/// </summary>
		protected RMethod r_MCancelRefresh_RefreshOptions;
		public virtual RMethod RMCancelRefresh_RefreshOptions
		{
			get
			{
				if(r_MCancelRefresh_RefreshOptions == null)
				{
					r_MCancelRefresh_RefreshOptions = new(this, "CancelRefresh", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.RefreshOptions"));
					r_MCancelRefresh_RefreshOptions.SetBelong(this.GetValue());
				}
				return r_MCancelRefresh_RefreshOptions;
			}
		}

		/// <summary>
		/// Void Fetch(System.String)
		/// </summary>
		protected RMethod r_MFetch_String;
		public virtual RMethod RMFetch_String
		{
			get
			{
				if(r_MFetch_String == null)
				{
					r_MFetch_String = new(this, "Fetch", 0, typeof(System.String));
					r_MFetch_String.SetBelong(this.GetValue());
				}
				return r_MFetch_String;
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
					r_MLoadMore_Int64.SetBelong(this.GetValue());
				}
				return r_MLoadMore_Int64;
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
					r_MOnUserLoginStateChange_Boolean_Boolean.SetBelong(this.GetValue());
				}
				return r_MOnUserLoginStateChange_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void OnEditorSelectionChanged()
		/// </summary>
		protected RMethod r_MOnEditorSelectionChanged;
		public virtual RMethod RMOnEditorSelectionChanged
		{
			get
			{
				if(r_MOnEditorSelectionChanged == null)
				{
					r_MOnEditorSelectionChanged = new(this, "OnEditorSelectionChanged", 0);
					r_MOnEditorSelectionChanged.SetBelong(this.GetValue());
				}
				return r_MOnEditorSelectionChanged;
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
					r_MOnEnable.SetBelong(this.GetValue());
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
					r_MOnDisable.SetBelong(this.GetValue());
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
					r_MReload.SetBelong(this.GetValue());
				}
				return r_MReload;
			}
		}

		/// <summary>
		/// Void InitializeRefreshTimestamps()
		/// </summary>
		protected RMethod r_MInitializeRefreshTimestamps;
		public virtual RMethod RMInitializeRefreshTimestamps
		{
			get
			{
				if(r_MInitializeRefreshTimestamps == null)
				{
					r_MInitializeRefreshTimestamps = new(this, "InitializeRefreshTimestamps", 0);
					r_MInitializeRefreshTimestamps.SetBelong(this.GetValue());
				}
				return r_MInitializeRefreshTimestamps;
			}
		}

		/// <summary>
		/// Void InitializeSelectionObjects()
		/// </summary>
		protected RMethod r_MInitializeSelectionObjects;
		public virtual RMethod RMInitializeSelectionObjects
		{
			get
			{
				if(r_MInitializeSelectionObjects == null)
				{
					r_MInitializeSelectionObjects = new(this, "InitializeSelectionObjects", 0);
					r_MInitializeSelectionObjects.SetBelong(this.GetValue());
				}
				return r_MInitializeSelectionObjects;
			}
		}

		/// <summary>
		/// Void InitializeSubPages()
		/// </summary>
		protected RMethod r_MInitializeSubPages;
		public virtual RMethod RMInitializeSubPages
		{
			get
			{
				if(r_MInitializeSubPages == null)
				{
					r_MInitializeSubPages = new(this, "InitializeSubPages", 0);
					r_MInitializeSubPages.SetBelong(this.GetValue());
				}
				return r_MInitializeSubPages;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.SubPage AddSubPage(UnityEditor.PackageManager.UI.Internal.PackageFilterTab, System.String, System.String, System.String, Int32, System.Func`2[UnityEditor.PackageManager.UI.Internal.IPackage,System.Boolean], System.Func`2[UnityEditor.PackageManager.UI.Internal.IPackage,System.String], System.Func`3[System.String,System.String,System.Int32])
		/// </summary>
		protected RMethod r_MAddSubPage_PackageFilterTab_String_String_String_Int32_Func_d_IPackage_Boolean_p__Func_d_IPackage_String_p__Func_d_String_String_Int32_p_;
		public virtual RMethod RMAddSubPage_PackageFilterTab_String_String_String_Int32_Func_d_IPackage_Boolean_p__Func_d_IPackage_String_p__Func_d_String_String_Int32_p_
		{
			get
			{
				if(r_MAddSubPage_PackageFilterTab_String_String_String_Int32_Func_d_IPackage_Boolean_p__Func_d_IPackage_String_p__Func_d_String_String_Int32_p_ == null)
				{
					r_MAddSubPage_PackageFilterTab_String_String_String_Int32_Func_d_IPackage_Boolean_p__Func_d_IPackage_String_p__Func_d_String_String_Int32_p_ = new(this, "AddSubPage", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageFilterTab"), typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"), typeof(System.Boolean)), typeof(System.Func<, >).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"), typeof(System.String)), typeof(System.Func<, , >).MakeGenericType(typeof(System.String), typeof(System.String), typeof(System.Int32)));
					r_MAddSubPage_PackageFilterTab_String_String_String_Int32_Func_d_IPackage_Boolean_p__Func_d_IPackage_String_p__Func_d_String_String_Int32_p_.SetBelong(this.GetValue());
				}
				return r_MAddSubPage_PackageFilterTab_String_String_String_Int32_Func_d_IPackage_Boolean_p__Func_d_IPackage_String_p__Func_d_String_String_Int32_p_;
			}
		}

		/// <summary>
		/// Void ClearPages()
		/// </summary>
		protected RMethod r_MClearPages;
		public virtual RMethod RMClearPages
		{
			get
			{
				if(r_MClearPages == null)
				{
					r_MClearPages = new(this, "ClearPages", 0);
					r_MClearPages.SetBelong(this.GetValue());
				}
				return r_MClearPages;
			}
		}

		/// <summary>
		/// Void OnRegistriesModified()
		/// </summary>
		protected RMethod r_MOnRegistriesModified;
		public virtual RMethod RMOnRegistriesModified
		{
			get
			{
				if(r_MOnRegistriesModified == null)
				{
					r_MOnRegistriesModified = new(this, "OnRegistriesModified", 0);
					r_MOnRegistriesModified.SetBelong(this.GetValue());
				}
				return r_MOnRegistriesModified;
			}
		}

		/// <summary>
		/// Void OnRefreshOperation(UnityEditor.PackageManager.UI.Internal.IOperation)
		/// </summary>
		protected RMethod r_MOnRefreshOperation_IOperation;
		public virtual RMethod RMOnRefreshOperation_IOperation
		{
			get
			{
				if(r_MOnRefreshOperation_IOperation == null)
				{
					r_MOnRefreshOperation_IOperation = new(this, "OnRefreshOperation", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"));
					r_MOnRefreshOperation_IOperation.SetBelong(this.GetValue());
				}
				return r_MOnRefreshOperation_IOperation;
			}
		}

		/// <summary>
		/// Void OnRefreshOperationSuccess(UnityEditor.PackageManager.UI.Internal.IOperation)
		/// </summary>
		protected RMethod r_MOnRefreshOperationSuccess_IOperation;
		public virtual RMethod RMOnRefreshOperationSuccess_IOperation
		{
			get
			{
				if(r_MOnRefreshOperationSuccess_IOperation == null)
				{
					r_MOnRefreshOperationSuccess_IOperation = new(this, "OnRefreshOperationSuccess", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"));
					r_MOnRefreshOperationSuccess_IOperation.SetBelong(this.GetValue());
				}
				return r_MOnRefreshOperationSuccess_IOperation;
			}
		}

		/// <summary>
		/// Void OnRefreshOperationError(UnityEditor.PackageManager.UI.Internal.IOperation, UnityEditor.PackageManager.UI.Internal.UIError)
		/// </summary>
		protected RMethod r_MOnRefreshOperationError_IOperation_UIError;
		public virtual RMethod RMOnRefreshOperationError_IOperation_UIError
		{
			get
			{
				if(r_MOnRefreshOperationError_IOperation_UIError == null)
				{
					r_MOnRefreshOperationError_IOperation_UIError = new(this, "OnRefreshOperationError", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError"));
					r_MOnRefreshOperationError_IOperation_UIError.SetBelong(this.GetValue());
				}
				return r_MOnRefreshOperationError_IOperation_UIError;
			}
		}

		/// <summary>
		/// Void OnRefreshOperationFinalized(UnityEditor.PackageManager.UI.Internal.IOperation)
		/// </summary>
		protected RMethod r_MOnRefreshOperationFinalized_IOperation;
		public virtual RMethod RMOnRefreshOperationFinalized_IOperation
		{
			get
			{
				if(r_MOnRefreshOperationFinalized_IOperation == null)
				{
					r_MOnRefreshOperationFinalized_IOperation = new(this, "OnRefreshOperationFinalized", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"));
					r_MOnRefreshOperationFinalized_IOperation.SetBelong(this.GetValue());
				}
				return r_MOnRefreshOperationFinalized_IOperation;
			}
		}

		/// <summary>
		/// Boolean IsRefreshInProgress(UnityEditor.PackageManager.UI.Internal.RefreshOptions)
		/// </summary>
		protected RMethod r_MIsRefreshInProgress_RefreshOptions;
		public virtual RMethod RMIsRefreshInProgress_RefreshOptions
		{
			get
			{
				if(r_MIsRefreshInProgress_RefreshOptions == null)
				{
					r_MIsRefreshInProgress_RefreshOptions = new(this, "IsRefreshInProgress", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.RefreshOptions"));
					r_MIsRefreshInProgress_RefreshOptions.SetBelong(this.GetValue());
				}
				return r_MIsRefreshInProgress_RefreshOptions;
			}
		}

		/// <summary>
		/// Boolean IsInitialFetchingDone(UnityEditor.PackageManager.UI.Internal.RefreshOptions)
		/// </summary>
		protected RMethod r_MIsInitialFetchingDone_RefreshOptions;
		public virtual RMethod RMIsInitialFetchingDone_RefreshOptions
		{
			get
			{
				if(r_MIsInitialFetchingDone_RefreshOptions == null)
				{
					r_MIsInitialFetchingDone_RefreshOptions = new(this, "IsInitialFetchingDone", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.RefreshOptions"));
					r_MIsInitialFetchingDone_RefreshOptions.SetBelong(this.GetValue());
				}
				return r_MIsInitialFetchingDone_RefreshOptions;
			}
		}

		/// <summary>
		/// Int64 GetRefreshTimestamp(UnityEditor.PackageManager.UI.Internal.RefreshOptions)
		/// </summary>
		protected RMethod r_MGetRefreshTimestamp_RefreshOptions;
		public virtual RMethod RMGetRefreshTimestamp_RefreshOptions
		{
			get
			{
				if(r_MGetRefreshTimestamp_RefreshOptions == null)
				{
					r_MGetRefreshTimestamp_RefreshOptions = new(this, "GetRefreshTimestamp", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.RefreshOptions"));
					r_MGetRefreshTimestamp_RefreshOptions.SetBelong(this.GetValue());
				}
				return r_MGetRefreshTimestamp_RefreshOptions;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UIError GetRefreshError(UnityEditor.PackageManager.UI.Internal.RefreshOptions)
		/// </summary>
		protected RMethod r_MGetRefreshError_RefreshOptions;
		public virtual RMethod RMGetRefreshError_RefreshOptions
		{
			get
			{
				if(r_MGetRefreshError_RefreshOptions == null)
				{
					r_MGetRefreshError_RefreshOptions = new(this, "GetRefreshError", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.RefreshOptions"));
					r_MGetRefreshError_RefreshOptions.SetBelong(this.GetValue());
				}
				return r_MGetRefreshError_RefreshOptions;
			}
		}

		/// <summary>
		/// Int64 GetRefreshTimestamp(System.Nullable`1[UnityEditor.PackageManager.UI.Internal.PackageFilterTab])
		/// </summary>
		protected RMethod r_MGetRefreshTimestamp_Nullable_d_PackageFilterTab_p_;
		public virtual RMethod RMGetRefreshTimestamp_Nullable_d_PackageFilterTab_p_
		{
			get
			{
				if(r_MGetRefreshTimestamp_Nullable_d_PackageFilterTab_p_ == null)
				{
					r_MGetRefreshTimestamp_Nullable_d_PackageFilterTab_p_ = new(this, "GetRefreshTimestamp", 0, typeof(System.Nullable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageFilterTab")));
					r_MGetRefreshTimestamp_Nullable_d_PackageFilterTab_p_.SetBelong(this.GetValue());
				}
				return r_MGetRefreshTimestamp_Nullable_d_PackageFilterTab_p_;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UIError GetRefreshError(System.Nullable`1[UnityEditor.PackageManager.UI.Internal.PackageFilterTab])
		/// </summary>
		protected RMethod r_MGetRefreshError_Nullable_d_PackageFilterTab_p_;
		public virtual RMethod RMGetRefreshError_Nullable_d_PackageFilterTab_p_
		{
			get
			{
				if(r_MGetRefreshError_Nullable_d_PackageFilterTab_p_ == null)
				{
					r_MGetRefreshError_Nullable_d_PackageFilterTab_p_ = new(this, "GetRefreshError", 0, typeof(System.Nullable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageFilterTab")));
					r_MGetRefreshError_Nullable_d_PackageFilterTab_p_.SetBelong(this.GetValue());
				}
				return r_MGetRefreshError_Nullable_d_PackageFilterTab_p_;
			}
		}

		/// <summary>
		/// Boolean IsRefreshInProgress(System.Nullable`1[UnityEditor.PackageManager.UI.Internal.PackageFilterTab])
		/// </summary>
		protected RMethod r_MIsRefreshInProgress_Nullable_d_PackageFilterTab_p_;
		public virtual RMethod RMIsRefreshInProgress_Nullable_d_PackageFilterTab_p_
		{
			get
			{
				if(r_MIsRefreshInProgress_Nullable_d_PackageFilterTab_p_ == null)
				{
					r_MIsRefreshInProgress_Nullable_d_PackageFilterTab_p_ = new(this, "IsRefreshInProgress", 0, typeof(System.Nullable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageFilterTab")));
					r_MIsRefreshInProgress_Nullable_d_PackageFilterTab_p_.SetBelong(this.GetValue());
				}
				return r_MIsRefreshInProgress_Nullable_d_PackageFilterTab_p_;
			}
		}

		/// <summary>
		/// Boolean IsInitialFetchingDone(System.Nullable`1[UnityEditor.PackageManager.UI.Internal.PackageFilterTab])
		/// </summary>
		protected RMethod r_MIsInitialFetchingDone_Nullable_d_PackageFilterTab_p_;
		public virtual RMethod RMIsInitialFetchingDone_Nullable_d_PackageFilterTab_p_
		{
			get
			{
				if(r_MIsInitialFetchingDone_Nullable_d_PackageFilterTab_p_ == null)
				{
					r_MIsInitialFetchingDone_Nullable_d_PackageFilterTab_p_ = new(this, "IsInitialFetchingDone", 0, typeof(System.Nullable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageFilterTab")));
					r_MIsInitialFetchingDone_Nullable_d_PackageFilterTab_p_.SetBelong(this.GetValue());
				}
				return r_MIsInitialFetchingDone_Nullable_d_PackageFilterTab_p_;
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
					r_MSetPackagesUserUnlockedState_IEnumerable_d_String_p__Boolean.SetBelong(this.GetValue());
				}
				return r_MSetPackagesUserUnlockedState_IEnumerable_d_String_p__Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageSelectionObject <SelectInInspector>b__82_0(UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair)
		/// </summary>
		protected RMethod r_M__0__SelectInInspector__1__b__82_0_PackageAndVersionIdPair;
		public virtual RMethod RM__0__SelectInInspector__1__b__82_0_PackageAndVersionIdPair
		{
			get
			{
				if(r_M__0__SelectInInspector__1__b__82_0_PackageAndVersionIdPair == null)
				{
					r_M__0__SelectInInspector__1__b__82_0_PackageAndVersionIdPair = new(this, "<SelectInInspector>b__82_0", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair"));
					r_M__0__SelectInInspector__1__b__82_0_PackageAndVersionIdPair.SetBelong(this.GetValue());
				}
				return r_M__0__SelectInInspector__1__b__82_0_PackageAndVersionIdPair;
			}
		}

		/// <summary>
		/// Boolean <InitializeSubPages>g__FilterAllPackages|110_0(UnityEditor.PackageManager.UI.Internal.IPackage)
		/// </summary>
		protected static RMethod r_M__0__InitializeSubPages__1__g__FilterAllPackages__5__110_0_IPackage;
		public static RMethod RM__0__InitializeSubPages__1__g__FilterAllPackages__5__110_0_IPackage
		{
			get
			{
				if(r_M__0__InitializeSubPages__1__g__FilterAllPackages__5__110_0_IPackage == null)
				{
					r_M__0__InitializeSubPages__1__g__FilterAllPackages__5__110_0_IPackage = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PageManager"), "<InitializeSubPages>g__FilterAllPackages|110_0", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"));
					r_M__0__InitializeSubPages__1__g__FilterAllPackages__5__110_0_IPackage.SetBelong(null);
				}
				return r_M__0__InitializeSubPages__1__g__FilterAllPackages__5__110_0_IPackage;
			}
		}

		/// <summary>
		/// System.String <InitializeSubPages>g__GroupPackagesAndFeatures|110_1(UnityEditor.PackageManager.UI.Internal.IPackage)
		/// </summary>
		protected static RMethod r_M__0__InitializeSubPages__1__g__GroupPackagesAndFeatures__5__110_1_IPackage;
		public static RMethod RM__0__InitializeSubPages__1__g__GroupPackagesAndFeatures__5__110_1_IPackage
		{
			get
			{
				if(r_M__0__InitializeSubPages__1__g__GroupPackagesAndFeatures__5__110_1_IPackage == null)
				{
					r_M__0__InitializeSubPages__1__g__GroupPackagesAndFeatures__5__110_1_IPackage = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PageManager"), "<InitializeSubPages>g__GroupPackagesAndFeatures|110_1", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"));
					r_M__0__InitializeSubPages__1__g__GroupPackagesAndFeatures__5__110_1_IPackage.SetBelong(null);
				}
				return r_M__0__InitializeSubPages__1__g__GroupPackagesAndFeatures__5__110_1_IPackage;
			}
		}

		/// <summary>
		/// System.String <InitializeSubPages>g__GroupPackagesWithAuthorAndFeatures|110_2(UnityEditor.PackageManager.UI.Internal.IPackage)
		/// </summary>
		protected static RMethod r_M__0__InitializeSubPages__1__g__GroupPackagesWithAuthorAndFeatures__5__110_2_IPackage;
		public static RMethod RM__0__InitializeSubPages__1__g__GroupPackagesWithAuthorAndFeatures__5__110_2_IPackage
		{
			get
			{
				if(r_M__0__InitializeSubPages__1__g__GroupPackagesWithAuthorAndFeatures__5__110_2_IPackage == null)
				{
					r_M__0__InitializeSubPages__1__g__GroupPackagesWithAuthorAndFeatures__5__110_2_IPackage = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PageManager"), "<InitializeSubPages>g__GroupPackagesWithAuthorAndFeatures|110_2", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"));
					r_M__0__InitializeSubPages__1__g__GroupPackagesWithAuthorAndFeatures__5__110_2_IPackage.SetBelong(null);
				}
				return r_M__0__InitializeSubPages__1__g__GroupPackagesWithAuthorAndFeatures__5__110_2_IPackage;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
			}
		}


        public RPageManager() : base("UnityEditor.PackageManager.UI.Internal.PageManager")
        {
        }

        public RPageManager(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.PageManager")
		{
            SetInstance(instance);
		}

        public RPageManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPageManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void ResolveDependencies(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RApplicationProxy @application, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RSelectionProxy @selection, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityConnectProxy @unityConnect, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFiltering @packageFiltering, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerPrefs @packageManagerPrefs, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmCache @upmCache, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmClient @upmClient, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmRegistryClient @upmRegistryClient, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreClient @assetStoreClient, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDatabase @packageDatabase, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerProjectSettingsProxy @settingsProxy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@application.Value, @selection.Value, @unityConnect.Value, @packageFiltering.Value, @packageManagerPrefs.Value, @upmCache.Value, @upmClient.Value, @upmRegistryClient.Value, @assetStoreClient.Value, @packageDatabase.Value, @settingsProxy.Value};
            var ___result = RMResolveDependencies_ApplicationProxy_SelectionProxy_UnityConnectProxy_PackageFiltering_PackageManagerPrefs_UpmCache_UpmClient_UpmRegistryClient_AssetStoreClient_PackageDatabase_PackageManagerProjectSettingsProxy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBeforeSerialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnBeforeSerialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageSelectionObject GetPackageSelectionObject(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair @pair, System.Boolean @createIfNotFound)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pair.Value, @createIfNotFound};
            var ___result = RMGetPackageSelectionObject_PackageAndVersionIdPair_Boolean.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageSelectionObject(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageSelectionObject GetPackageSelectionObject(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version, System.Boolean @createIfNotFound)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value, @version.Value, @createIfNotFound};
            var ___result = RMGetPackageSelectionObject_IPackage_IPackageVersion_Boolean.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageSelectionObject(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPage GetPageFromTab(Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab> @tab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tab.Value};
            var ___result = RMGetPageFromTab_Nullable_d_PackageFilterTab_p_.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPage(___result);
        }


        public virtual Hvak.Editor.Refleaction.RType GetPageFromTab<T>(Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab> @tab) where T : class
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@tab.Value};
            var ___result = RMGetPageFromTab_GT_Nullable_d_PackageFilterTab_p_.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RType(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPage CreatePageFromTab(Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab> @tab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tab.Value};
            var ___result = RMCreatePageFromTab_Nullable_d_PackageFilterTab_p_.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPage(___result);
        }


        public virtual void RegisterPageEvents(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPage @page)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@page.Value};
            var ___result = RMRegisterPageEvents_IPage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterPageEvents(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPage @page)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@page.Value};
            var ___result = RMUnregisterPageEvents_IPage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPageSelectionChanged(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageSelection @selection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@selection.Value};
            var ___result = RMOnPageSelectionChanged_PageSelection.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TriggerOnVisualStateChange(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualStateChangeArgs @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args.Value};
            var ___result = RMTriggerOnVisualStateChange_VisualStateChangeArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TriggerOnPageUpdate(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RListUpdateArgs @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args.Value};
            var ___result = RMTriggerOnPageUpdate_ListUpdateArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TriggerOnPageRebuild(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPage @page)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@page.Value};
            var ___result = RMTriggerOnPageRebuild_IPage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TriggerOnSubPageChanged(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPage @page)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@page.Value};
            var ___result = RMTriggerOnSubPageChanged_IPage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TriggerOnFiltersChange(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageFilters @filters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filters.Value};
            var ___result = RMTriggerOnFiltersChange_PageFilters.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPage GetCurrentPage()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCurrentPage.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPage(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPage GetPage(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab @tab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tab.Value};
            var ___result = RMGetPage_PackageFilterTab.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPage(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageSelection GetSelection()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSelection.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageSelection(___result);
        }


        public virtual void ClearSelection()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearSelection.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSelected(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version, System.Boolean @forceSelectInInspector)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value, @version.Value, @forceSelectInInspector};
            var ___result = RMSetSelected_IPackage_IPackageVersion_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSelected(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair> @newSelection, System.Boolean @forceSelectInInspector)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newSelection.Value, @forceSelectInInspector};
            var ___result = RMSetSelected_IEnumerable_d_PackageAndVersionIdPair_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ToggleSelected(System.String @packageUniqueId, System.Boolean @forceSelectInInspector)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueId, @forceSelectInInspector};
            var ___result = RMToggleSelected_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AmendSelection(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair> @toAddOrUpdate, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair> @toRemove, System.Boolean @forceSelectInInspector)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@toAddOrUpdate.Value, @toRemove.Value, @forceSelectInInspector};
            var ___result = RMAmendSelection_IEnumerable_d_PackageAndVersionIdPair_p__IEnumerable_d_PackageAndVersionIdPair_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveSelection(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair> @toRemove, System.Boolean @forceSelectInInspector)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@toRemove.Value, @forceSelectInInspector};
            var ___result = RMRemoveSelection_IEnumerable_d_PackageAndVersionIdPair_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean UpdateSelectionIfCurrentSelectionIsInvalid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateSelectionIfCurrentSelectionIsInvalid.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void TriggerOnSelectionChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTriggerOnSelectionChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectInInspector(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageSelection @selection, System.Boolean @forceSelectInInspector)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@selection.Value, @forceSelectInInspector};
            var ___result = RMSelectInInspector_PageSelection_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSeeAllVersions(System.String @packageUniqueId, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueId, @value};
            var ___result = RMSetSeeAllVersions_String_Boolean.Invoke(___genericsType, ___parameters);

            
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


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab FindTab(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value, @version.Value};
            var ___result = RMFindTab_IPackage_IPackageVersion.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab FindTab(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion> @packageVersions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageVersions.Value};
            var ___result = RMFindTab_IEnumerable_d_IPackageVersion_p_.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab(___result);
        }


        public virtual void OnPackageUniqueIdFinalize(System.String @tempPackageUniqueId, System.String @finalPackageUniqueId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tempPackageUniqueId, @finalPackageUniqueId};
            var ___result = RMOnPackageUniqueIdFinalize_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnSearchTextChanged(System.String @searchText)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@searchText};
            var ___result = RMOnSearchTextChanged_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnFilterChanged(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab @filterTab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filterTab.Value};
            var ___result = RMOnFilterChanged_PackageFilterTab.Invoke(___genericsType, ___parameters);

            
        }


        public static void UpdateSearchTextOnPage(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPage @page, System.String @searchText)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@page.Value, @searchText};
            var ___result = RMUpdateSearchTextOnPage_IPage_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPackagesChanged(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackagesChangeArgs @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args.Value};
            var ___result = RMOnPackagesChanged_PackagesChangeArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnProductListFetched(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchases @productList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productList.Value};
            var ___result = RMOnProductListFetched_AssetStorePurchases.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnProductExtraFetched(System.Int64 @productId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productId};
            var ___result = RMOnProductExtraFetched_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState GetVisualState(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RMGetVisualState_IPackage.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRefreshOptions GetRefreshOptionsByTab(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab @tab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tab.Value};
            var ___result = RMGetRefreshOptionsByTab_PackageFilterTab.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRefreshOptions(___result);
        }


        public virtual void Refresh(Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab> @tab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tab.Value};
            var ___result = RMRefresh_Nullable_d_PackageFilterTab_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Refresh(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRefreshOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@options.Value};
            var ___result = RMRefresh_RefreshOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CancelRefresh(Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab> @tab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tab.Value};
            var ___result = RMCancelRefresh_Nullable_d_PackageFilterTab_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CancelRefresh(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRefreshOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@options.Value};
            var ___result = RMCancelRefresh_RefreshOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Fetch(System.String @uniqueId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uniqueId};
            var ___result = RMFetch_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadMore(System.Int64 @numberOfPackages)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@numberOfPackages};
            var ___result = RMLoadMore_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnUserLoginStateChange(System.Boolean @userInfoReady, System.Boolean @loggedIn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@userInfoReady, @loggedIn};
            var ___result = RMOnUserLoginStateChange_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnEditorSelectionChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnEditorSelectionChanged.Invoke(___genericsType, ___parameters);

            
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


        public virtual void InitializeRefreshTimestamps()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitializeRefreshTimestamps.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitializeSelectionObjects()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitializeSelectionObjects.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitializeSubPages()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitializeSubPages.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RSubPage AddSubPage(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab @tab, System.String @name, System.String @displayName, System.String @contentType, System.Int32 @priority, Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage, Hvak.Editor.Refleaction.RSystem.RBoolean> @filterFunction, Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage, Hvak.Editor.Refleaction.RSystem.RString> @groupNameFunction, System.Func<System.String, System.String, System.Int32> @compareGroupFunction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tab.Value, @name, @displayName, @contentType, @priority, @filterFunction.Value, @groupNameFunction.Value, @compareGroupFunction};
            var ___result = RMAddSubPage_PackageFilterTab_String_String_String_Int32_Func_d_IPackage_Boolean_p__Func_d_IPackage_String_p__Func_d_String_String_Int32_p_.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RSubPage(___result);
        }


        public virtual void ClearPages()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearPages.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnRegistriesModified()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnRegistriesModified.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnRefreshOperation(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @operation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@operation.Value};
            var ___result = RMOnRefreshOperation_IOperation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnRefreshOperationSuccess(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @operation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@operation.Value};
            var ___result = RMOnRefreshOperationSuccess_IOperation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnRefreshOperationError(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @operation, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError @error)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@operation.Value, @error.Value};
            var ___result = RMOnRefreshOperationError_IOperation_UIError.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnRefreshOperationFinalized(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @operation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@operation.Value};
            var ___result = RMOnRefreshOperationFinalized_IOperation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsRefreshInProgress(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRefreshOptions @option)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@option.Value};
            var ___result = RMIsRefreshInProgress_RefreshOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsInitialFetchingDone(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRefreshOptions @option)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@option.Value};
            var ___result = RMIsInitialFetchingDone_RefreshOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int64 GetRefreshTimestamp(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRefreshOptions @option)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@option.Value};
            var ___result = RMGetRefreshTimestamp_RefreshOptions.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError GetRefreshError(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRefreshOptions @option)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@option.Value};
            var ___result = RMGetRefreshError_RefreshOptions.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError(___result);
        }


        public virtual System.Int64 GetRefreshTimestamp(Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab> @tab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tab.Value};
            var ___result = RMGetRefreshTimestamp_Nullable_d_PackageFilterTab_p_.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError GetRefreshError(Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab> @tab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tab.Value};
            var ___result = RMGetRefreshError_Nullable_d_PackageFilterTab_p_.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError(___result);
        }


        public virtual System.Boolean IsRefreshInProgress(Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab> @tab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tab.Value};
            var ___result = RMIsRefreshInProgress_Nullable_d_PackageFilterTab_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsInitialFetchingDone(Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab> @tab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tab.Value};
            var ___result = RMIsInitialFetchingDone_Nullable_d_PackageFilterTab_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetPackagesUserUnlockedState(System.Collections.Generic.IEnumerable<System.String> @packageUniqueIds, System.Boolean @unlocked)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueIds, @unlocked};
            var ___result = RMSetPackagesUserUnlockedState_IEnumerable_d_String_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageSelectionObject __0__SelectInInspector__1__b__82_0(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s.Value};
            var ___result = RM__0__SelectInInspector__1__b__82_0_PackageAndVersionIdPair.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageSelectionObject(___result);
        }


        public static System.Boolean __0__InitializeSubPages__1__g__FilterAllPackages__5__110_0(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RM__0__InitializeSubPages__1__g__FilterAllPackages__5__110_0_IPackage.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String __0__InitializeSubPages__1__g__GroupPackagesAndFeatures__5__110_1(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RM__0__InitializeSubPages__1__g__GroupPackagesAndFeatures__5__110_1_IPackage.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String __0__InitializeSubPages__1__g__GroupPackagesWithAuthorAndFeatures__5__110_2(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RM__0__InitializeSubPages__1__g__GroupPackagesWithAuthorAndFeatures__5__110_2_IPackage.Invoke(___genericsType, ___parameters);

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
