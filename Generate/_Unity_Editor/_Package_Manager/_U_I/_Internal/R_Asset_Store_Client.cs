
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.AssetStoreClient
	/// </summary>
    public partial class RAssetStoreClient : RMember //
    {

		/// <summary>
		/// System.Action`1[System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage]] onPackagesChanged
		/// </summary>
		protected REvent r_EonPackagesChanged;
		public virtual REvent REonPackagesChanged
		{
			get
			{
				if(r_EonPackagesChanged == null)
				{
					r_EonPackagesChanged = new(this, "onPackagesChanged");
					r_EonPackagesChanged.SetBelong(this.instance);
				}
				return r_EonPackagesChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.AssetStorePurchases] onProductListFetched
		/// </summary>
		protected REvent r_EonProductListFetched;
		public virtual REvent REonProductListFetched
		{
			get
			{
				if(r_EonProductListFetched == null)
				{
					r_EonProductListFetched = new(this, "onProductListFetched");
					r_EonProductListFetched.SetBelong(this.instance);
				}
				return r_EonProductListFetched;
			}
		}

		/// <summary>
		/// System.Action`1[System.Int64] onProductExtraFetched
		/// </summary>
		protected REvent r_EonProductExtraFetched;
		public virtual REvent REonProductExtraFetched
		{
			get
			{
				if(r_EonProductExtraFetched == null)
				{
					r_EonProductExtraFetched = new(this, "onProductExtraFetched");
					r_EonProductExtraFetched.SetBelong(this.instance);
				}
				return r_EonProductExtraFetched;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onListOperation
		/// </summary>
		protected REvent r_EonListOperation;
		public virtual REvent REonListOperation
		{
			get
			{
				if(r_EonListOperation == null)
				{
					r_EonListOperation = new(this, "onListOperation");
					r_EonListOperation.SetBelong(this.instance);
				}
				return r_EonListOperation;
			}
		}

		/// <summary>
		/// System.Action`1[System.Collections.Generic.IEnumerable`1[System.String]] onUpdateChecked
		/// </summary>
		protected REvent r_EonUpdateChecked;
		public virtual REvent REonUpdateChecked
		{
			get
			{
				if(r_EonUpdateChecked == null)
				{
					r_EonUpdateChecked = new(this, "onUpdateChecked");
					r_EonUpdateChecked.SetBelong(this.instance);
				}
				return r_EonUpdateChecked;
			}
		}

		/// <summary>
		/// System.Action`1[System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage]] onPackagesChanged
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage>> r_FonPackagesChanged;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage>> RFonPackagesChanged
		{
			get
			{
				if(r_FonPackagesChanged == null)
				{
					r_FonPackagesChanged = new(this, "onPackagesChanged");
					r_FonPackagesChanged.SetBelong(this.instance);
				}
				return r_FonPackagesChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.AssetStorePurchases] onProductListFetched
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchases> r_FonProductListFetched;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchases> RFonProductListFetched
		{
			get
			{
				if(r_FonProductListFetched == null)
				{
					r_FonProductListFetched = new(this, "onProductListFetched");
					r_FonProductListFetched.SetBelong(this.instance);
				}
				return r_FonProductListFetched;
			}
		}

		/// <summary>
		/// System.Action`1[System.Int64] onProductExtraFetched
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RInt64> r_FonProductExtraFetched;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RInt64> RFonProductExtraFetched
		{
			get
			{
				if(r_FonProductExtraFetched == null)
				{
					r_FonProductExtraFetched = new(this, "onProductExtraFetched");
					r_FonProductExtraFetched.SetBelong(this.instance);
				}
				return r_FonProductExtraFetched;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onListOperation
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> r_FonListOperation;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> RFonListOperation
		{
			get
			{
				if(r_FonListOperation == null)
				{
					r_FonListOperation = new(this, "onListOperation");
					r_FonListOperation.SetBelong(this.instance);
				}
				return r_FonListOperation;
			}
		}

		/// <summary>
		/// System.Action`1[System.Collections.Generic.IEnumerable`1[System.String]] onUpdateChecked
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RSystem.RString>> r_FonUpdateChecked;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RSystem.RString>> RFonUpdateChecked
		{
			get
			{
				if(r_FonUpdateChecked == null)
				{
					r_FonUpdateChecked = new(this, "onUpdateChecked");
					r_FonUpdateChecked.SetBelong(this.instance);
				}
				return r_FonUpdateChecked;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreListOperation m_ListOperation
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreListOperation r_Fm_ListOperation;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreListOperation RFm_ListOperation
		{
			get
			{
				if(r_Fm_ListOperation == null)
				{
					r_Fm_ListOperation = new(this, "m_ListOperation");
					r_Fm_ListOperation.SetBelong(this.instance);
				}
				return r_Fm_ListOperation;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreClient+AssetStorePackageFactory m_AssetStorePackageFactory
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreClient.RAssetStorePackageFactory r_Fm_AssetStorePackageFactory;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreClient.RAssetStorePackageFactory RFm_AssetStorePackageFactory
		{
			get
			{
				if(r_Fm_AssetStorePackageFactory == null)
				{
					r_Fm_AssetStorePackageFactory = new(this, "m_AssetStorePackageFactory");
					r_Fm_AssetStorePackageFactory.SetBelong(this.instance);
				}
				return r_Fm_AssetStorePackageFactory;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreClient+UpmOnAssetStorePackageFactory m_UpmOnAssetStorePackageFactory
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreClient.RUpmOnAssetStorePackageFactory r_Fm_UpmOnAssetStorePackageFactory;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreClient.RUpmOnAssetStorePackageFactory RFm_UpmOnAssetStorePackageFactory
		{
			get
			{
				if(r_Fm_UpmOnAssetStorePackageFactory == null)
				{
					r_Fm_UpmOnAssetStorePackageFactory = new(this, "m_UpmOnAssetStorePackageFactory");
					r_Fm_UpmOnAssetStorePackageFactory.SetBelong(this.instance);
				}
				return r_Fm_UpmOnAssetStorePackageFactory;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UnityConnectProxy m_UnityConnect
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityConnectProxy r_Fm_UnityConnect;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityConnectProxy RFm_UnityConnect
		{
			get
			{
				if(r_Fm_UnityConnect == null)
				{
					r_Fm_UnityConnect = new(this, "m_UnityConnect");
					r_Fm_UnityConnect.SetBelong(this.instance);
				}
				return r_Fm_UnityConnect;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreCache m_AssetStoreCache
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreCache r_Fm_AssetStoreCache;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreCache RFm_AssetStoreCache
		{
			get
			{
				if(r_Fm_AssetStoreCache == null)
				{
					r_Fm_AssetStoreCache = new(this, "m_AssetStoreCache");
					r_Fm_AssetStoreCache.SetBelong(this.instance);
				}
				return r_Fm_AssetStoreCache;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreUtils m_AssetStoreUtils
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUtils r_Fm_AssetStoreUtils;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUtils RFm_AssetStoreUtils
		{
			get
			{
				if(r_Fm_AssetStoreUtils == null)
				{
					r_Fm_AssetStoreUtils = new(this, "m_AssetStoreUtils");
					r_Fm_AssetStoreUtils.SetBelong(this.instance);
				}
				return r_Fm_AssetStoreUtils;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI m_AssetStoreRestAPI
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreRestAPI r_Fm_AssetStoreRestAPI;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreRestAPI RFm_AssetStoreRestAPI
		{
			get
			{
				if(r_Fm_AssetStoreRestAPI == null)
				{
					r_Fm_AssetStoreRestAPI = new(this, "m_AssetStoreRestAPI");
					r_Fm_AssetStoreRestAPI.SetBelong(this.instance);
				}
				return r_Fm_AssetStoreRestAPI;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.FetchStatusTracker m_FetchStatusTracker
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchStatusTracker r_Fm_FetchStatusTracker;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchStatusTracker RFm_FetchStatusTracker
		{
			get
			{
				if(r_Fm_FetchStatusTracker == null)
				{
					r_Fm_FetchStatusTracker = new(this, "m_FetchStatusTracker");
					r_Fm_FetchStatusTracker.SetBelong(this.instance);
				}
				return r_Fm_FetchStatusTracker;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmCache m_UpmCache
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmCache r_Fm_UpmCache;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmCache RFm_UpmCache
		{
			get
			{
				if(r_Fm_UpmCache == null)
				{
					r_Fm_UpmCache = new(this, "m_UpmCache");
					r_Fm_UpmCache.SetBelong(this.instance);
				}
				return r_Fm_UpmCache;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.UnityConnectProxy, UnityEditor.PackageManager.UI.Internal.AssetStoreCache, UnityEditor.PackageManager.UI.Internal.AssetStoreUtils, UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI, UnityEditor.PackageManager.UI.Internal.FetchStatusTracker, UnityEditor.PackageManager.UI.Internal.UpmCache, UnityEditor.PackageManager.UI.Internal.UpmClient, UnityEditor.PackageManager.UI.Internal.IOProxy)
		/// </summary>
		protected RMethod r_MResolveDependencies_UnityConnectProxy_AssetStoreCache_AssetStoreUtils_AssetStoreRestAPI_FetchStatusTracker_UpmCache_UpmClient_IOProxy;
		public virtual RMethod RMResolveDependencies_UnityConnectProxy_AssetStoreCache_AssetStoreUtils_AssetStoreRestAPI_FetchStatusTracker_UpmCache_UpmClient_IOProxy
		{
			get
			{
				if(r_MResolveDependencies_UnityConnectProxy_AssetStoreCache_AssetStoreUtils_AssetStoreRestAPI_FetchStatusTracker_UpmCache_UpmClient_IOProxy == null)
				{
					r_MResolveDependencies_UnityConnectProxy_AssetStoreCache_AssetStoreUtils_AssetStoreRestAPI_FetchStatusTracker_UpmCache_UpmClient_IOProxy = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UnityConnectProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreCache"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreUtils"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.FetchStatusTracker"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmCache"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmClient"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOProxy"));
					r_MResolveDependencies_UnityConnectProxy_AssetStoreCache_AssetStoreUtils_AssetStoreRestAPI_FetchStatusTracker_UpmCache_UpmClient_IOProxy.SetBelong(this.instance);
				}
				return r_MResolveDependencies_UnityConnectProxy_AssetStoreCache_AssetStoreUtils_AssetStoreRestAPI_FetchStatusTracker_UpmCache_UpmClient_IOProxy;
			}
		}

		/// <summary>
		/// Void ListCategories(System.Action`1[System.Collections.Generic.List`1[System.String]])
		/// </summary>
		protected RMethod r_MListCategories_Action_d_List_d_String_p__p_;
		public virtual RMethod RMListCategories_Action_d_List_d_String_p__p_
		{
			get
			{
				if(r_MListCategories_Action_d_List_d_String_p__p_ == null)
				{
					r_MListCategories_Action_d_List_d_String_p__p_ = new(this, "ListCategories", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.String))));
					r_MListCategories_Action_d_List_d_String_p__p_.SetBelong(this.instance);
				}
				return r_MListCategories_Action_d_List_d_String_p__p_;
			}
		}

		/// <summary>
		/// Void ListLabels(System.Action`1[System.Collections.Generic.List`1[System.String]])
		/// </summary>
		protected RMethod r_MListLabels_Action_d_List_d_String_p__p_;
		public virtual RMethod RMListLabels_Action_d_List_d_String_p__p_
		{
			get
			{
				if(r_MListLabels_Action_d_List_d_String_p__p_ == null)
				{
					r_MListLabels_Action_d_List_d_String_p__p_ = new(this, "ListLabels", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.String))));
					r_MListLabels_Action_d_List_d_String_p__p_.SetBelong(this.instance);
				}
				return r_MListLabels_Action_d_List_d_String_p__p_;
			}
		}

		/// <summary>
		/// Void ExtraFetch(Int64)
		/// </summary>
		protected RMethod r_MExtraFetch_Int64;
		public virtual RMethod RMExtraFetch_Int64
		{
			get
			{
				if(r_MExtraFetch_Int64 == null)
				{
					r_MExtraFetch_Int64 = new(this, "ExtraFetch", 0, typeof(System.Int64));
					r_MExtraFetch_Int64.SetBelong(this.instance);
				}
				return r_MExtraFetch_Int64;
			}
		}

		/// <summary>
		/// Void FetchPurchaseInfoWithRetry(Int64, Boolean)
		/// </summary>
		protected RMethod r_MFetchPurchaseInfoWithRetry_Int64_Boolean;
		public virtual RMethod RMFetchPurchaseInfoWithRetry_Int64_Boolean
		{
			get
			{
				if(r_MFetchPurchaseInfoWithRetry_Int64_Boolean == null)
				{
					r_MFetchPurchaseInfoWithRetry_Int64_Boolean = new(this, "FetchPurchaseInfoWithRetry", 0, typeof(System.Int64), typeof(System.Boolean));
					r_MFetchPurchaseInfoWithRetry_Int64_Boolean.SetBelong(this.instance);
				}
				return r_MFetchPurchaseInfoWithRetry_Int64_Boolean;
			}
		}

		/// <summary>
		/// Void ListPurchases(UnityEditor.PackageManager.UI.Internal.PurchasesQueryArgs)
		/// </summary>
		protected RMethod r_MListPurchases_PurchasesQueryArgs;
		public virtual RMethod RMListPurchases_PurchasesQueryArgs
		{
			get
			{
				if(r_MListPurchases_PurchasesQueryArgs == null)
				{
					r_MListPurchases_PurchasesQueryArgs = new(this, "ListPurchases", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PurchasesQueryArgs"));
					r_MListPurchases_PurchasesQueryArgs.SetBelong(this.instance);
				}
				return r_MListPurchases_PurchasesQueryArgs;
			}
		}

		/// <summary>
		/// Void CancelListPurchases()
		/// </summary>
		protected RMethod r_MCancelListPurchases;
		public virtual RMethod RMCancelListPurchases
		{
			get
			{
				if(r_MCancelListPurchases == null)
				{
					r_MCancelListPurchases = new(this, "CancelListPurchases", 0);
					r_MCancelListPurchases.SetBelong(this.instance);
				}
				return r_MCancelListPurchases;
			}
		}

		/// <summary>
		/// Void FetchDetail(Int64, System.Action)
		/// </summary>
		protected RMethod r_MFetchDetail_Int64_Action;
		public virtual RMethod RMFetchDetail_Int64_Action
		{
			get
			{
				if(r_MFetchDetail_Int64_Action == null)
				{
					r_MFetchDetail_Int64_Action = new(this, "FetchDetail", 0, typeof(System.Int64), typeof(System.Action));
					r_MFetchDetail_Int64_Action.SetBelong(this.instance);
				}
				return r_MFetchDetail_Int64_Action;
			}
		}

		/// <summary>
		/// Void RefreshLocal()
		/// </summary>
		protected RMethod r_MRefreshLocal;
		public virtual RMethod RMRefreshLocal
		{
			get
			{
				if(r_MRefreshLocal == null)
				{
					r_MRefreshLocal = new(this, "RefreshLocal", 0);
					r_MRefreshLocal.SetBelong(this.instance);
				}
				return r_MRefreshLocal;
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
					r_MOnEnable.SetBelong(this.instance);
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
					r_MOnDisable.SetBelong(this.instance);
				}
				return r_MOnDisable;
			}
		}

		/// <summary>
		/// Void ClearCache()
		/// </summary>
		protected RMethod r_MClearCache;
		public virtual RMethod RMClearCache
		{
			get
			{
				if(r_MClearCache == null)
				{
					r_MClearCache = new(this, "ClearCache", 0);
					r_MClearCache.SetBelong(this.instance);
				}
				return r_MClearCache;
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
					r_MOnUserLoginStateChange_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MOnUserLoginStateChange_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void CheckUpdate(System.Collections.Generic.IEnumerable`1[System.String], System.Action)
		/// </summary>
		protected RMethod r_MCheckUpdate_IEnumerable_d_String_p__Action;
		public virtual RMethod RMCheckUpdate_IEnumerable_d_String_p__Action
		{
			get
			{
				if(r_MCheckUpdate_IEnumerable_d_String_p__Action == null)
				{
					r_MCheckUpdate_IEnumerable_d_String_p__Action = new(this, "CheckUpdate", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.String)), typeof(System.Action));
					r_MCheckUpdate_IEnumerable_d_String_p__Action.SetBelong(this.instance);
				}
				return r_MCheckUpdate_IEnumerable_d_String_p__Action;
			}
		}

		/// <summary>
		/// Void CheckTermOfServiceAgreement(System.Action`1[UnityEditor.PackageManager.UI.Internal.TermOfServiceAgreementStatus], System.Action`1[UnityEditor.PackageManager.UI.Internal.UIError])
		/// </summary>
		protected RMethod r_MCheckTermOfServiceAgreement_Action_d_TermOfServiceAgreementStatus_p__Action_d_UIError_p_;
		public virtual RMethod RMCheckTermOfServiceAgreement_Action_d_TermOfServiceAgreementStatus_p__Action_d_UIError_p_
		{
			get
			{
				if(r_MCheckTermOfServiceAgreement_Action_d_TermOfServiceAgreementStatus_p__Action_d_UIError_p_ == null)
				{
					r_MCheckTermOfServiceAgreement_Action_d_TermOfServiceAgreementStatus_p__Action_d_UIError_p_ = new(this, "CheckTermOfServiceAgreement", 0, typeof(System.Action<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.TermOfServiceAgreementStatus")), typeof(System.Action<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError")));
					r_MCheckTermOfServiceAgreement_Action_d_TermOfServiceAgreementStatus_p__Action_d_UIError_p_.SetBelong(this.instance);
				}
				return r_MCheckTermOfServiceAgreement_Action_d_TermOfServiceAgreementStatus_p__Action_d_UIError_p_;
			}
		}

		/// <summary>
		/// Void <ListPurchases>b__29_0(UnityEditor.PackageManager.UI.Internal.IOperation)
		/// </summary>
		protected RMethod r_M__0__ListPurchases__1__b__29_0_IOperation;
		public virtual RMethod RM__0__ListPurchases__1__b__29_0_IOperation
		{
			get
			{
				if(r_M__0__ListPurchases__1__b__29_0_IOperation == null)
				{
					r_M__0__ListPurchases__1__b__29_0_IOperation = new(this, "<ListPurchases>b__29_0", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"));
					r_M__0__ListPurchases__1__b__29_0_IOperation.SetBelong(this.instance);
				}
				return r_M__0__ListPurchases__1__b__29_0_IOperation;
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


        public RAssetStoreClient() : base("UnityEditor.PackageManager.UI.Internal.AssetStoreClient")
        {
        }

        public RAssetStoreClient(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.AssetStoreClient")
		{
            SetInstance(instance);
		}

        public RAssetStoreClient(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssetStoreClient(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void ResolveDependencies(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityConnectProxy @unityConnect, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreCache @assetStoreCache, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUtils @assetStoreUtils, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreRestAPI @assetStoreRestAPI, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchStatusTracker @fetchStatusTracker, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmCache @upmCache, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmClient @upmClient, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOProxy @ioProxy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unityConnect.Value, @assetStoreCache.Value, @assetStoreUtils.Value, @assetStoreRestAPI.Value, @fetchStatusTracker.Value, @upmCache.Value, @upmClient.Value, @ioProxy.Value};
            var ___result = RMResolveDependencies_UnityConnectProxy_AssetStoreCache_AssetStoreUtils_AssetStoreRestAPI_FetchStatusTracker_UpmCache_UpmClient_IOProxy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ListCategories(System.Action<System.Collections.Generic.List<System.String>> @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback};
            var ___result = RMListCategories_Action_d_List_d_String_p__p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ListLabels(System.Action<System.Collections.Generic.List<System.String>> @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback};
            var ___result = RMListLabels_Action_d_List_d_String_p__p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExtraFetch(System.Int64 @productId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productId};
            var ___result = RMExtraFetch_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FetchPurchaseInfoWithRetry(System.Int64 @productId, System.Boolean @checkHiddenPurchases)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productId, @checkHiddenPurchases};
            var ___result = RMFetchPurchaseInfoWithRetry_Int64_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ListPurchases(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPurchasesQueryArgs @queryArgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@queryArgs.Value};
            var ___result = RMListPurchases_PurchasesQueryArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CancelListPurchases()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCancelListPurchases.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FetchDetail(System.Int64 @productId, System.Action @doneCallbackAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productId, @doneCallbackAction};
            var ___result = RMFetchDetail_Int64_Action.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RefreshLocal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefreshLocal.Invoke(___genericsType, ___parameters);

            
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


        public virtual void ClearCache()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearCache.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnUserLoginStateChange(System.Boolean @userInfoReady, System.Boolean @loggedIn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@userInfoReady, @loggedIn};
            var ___result = RMOnUserLoginStateChange_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckUpdate(System.Collections.Generic.IEnumerable<System.String> @productIds, System.Action @doneCallbackAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productIds, @doneCallbackAction};
            var ___result = RMCheckUpdate_IEnumerable_d_String_p__Action.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckTermOfServiceAgreement(SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RTermOfServiceAgreementStatus> @agreementStatusCallback, SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> @errorCallback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@agreementStatusCallback.Value, @errorCallback.Value};
            var ___result = RMCheckTermOfServiceAgreement_Action_d_TermOfServiceAgreementStatus_p__Action_d_UIError_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__ListPurchases__1__b__29_0(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @op)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@op.Value};
            var ___result = RM__0__ListPurchases__1__b__29_0_IOperation.Invoke(___genericsType, ___parameters);

            
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
