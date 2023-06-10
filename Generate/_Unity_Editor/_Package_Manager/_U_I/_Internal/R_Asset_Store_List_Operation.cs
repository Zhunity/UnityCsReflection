
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.AssetStoreListOperation
	/// </summary>
    public partial class RAssetStoreListOperation : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreListOperation");
            }
        }

        public RAssetStoreListOperation() : base("UnityEditor.PackageManager.UI.Internal.AssetStoreListOperation")
        {
        }

        public RAssetStoreListOperation(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.AssetStoreListOperation")
		{
            SetInstance(instance);
		}

        public RAssetStoreListOperation(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssetStoreListOperation(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Action`2[UnityEditor.PackageManager.UI.Internal.IOperation,UnityEditor.PackageManager.UI.Internal.UIError] onOperationError
		/// </summary>
		protected REvent r_EonOperationError;
		public virtual REvent REonOperationError
		{
			get
			{
				if(r_EonOperationError == null)
				{
					r_EonOperationError = new(this, "onOperationError");
				}
				return r_EonOperationError;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onOperationSuccess
		/// </summary>
		protected REvent r_EonOperationSuccess;
		public virtual REvent REonOperationSuccess
		{
			get
			{
				if(r_EonOperationSuccess == null)
				{
					r_EonOperationSuccess = new(this, "onOperationSuccess");
				}
				return r_EonOperationSuccess;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onOperationFinalized
		/// </summary>
		protected REvent r_EonOperationFinalized;
		public virtual REvent REonOperationFinalized
		{
			get
			{
				if(r_EonOperationFinalized == null)
				{
					r_EonOperationFinalized = new(this, "onOperationFinalized");
				}
				return r_EonOperationFinalized;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onOperationProgress
		/// </summary>
		protected REvent r_EonOperationProgress;
		public virtual REvent REonOperationProgress
		{
			get
			{
				if(r_EonOperationProgress == null)
				{
					r_EonOperationProgress = new(this, "onOperationProgress");
				}
				return r_EonOperationProgress;
			}
		}

		/// <summary>
		/// System.Int32 k_QueryLimit
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_QueryLimit;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_QueryLimit
		{
			get
			{
				if(r_Fk_QueryLimit == null)
				{
					r_Fk_QueryLimit = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreListOperation"), "k_QueryLimit");
				}
				return r_Fk_QueryLimit;
			}
		}

		/// <summary>
		/// System.String k_UserNotLoggedInErrorMessage
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_UserNotLoggedInErrorMessage;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_UserNotLoggedInErrorMessage
		{
			get
			{
				if(r_Fk_UserNotLoggedInErrorMessage == null)
				{
					r_Fk_UserNotLoggedInErrorMessage = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreListOperation"), "k_UserNotLoggedInErrorMessage");
				}
				return r_Fk_UserNotLoggedInErrorMessage;
			}
		}

		/// <summary>
		/// System.Int64 m_Timestamp
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Fm_Timestamp;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFm_Timestamp
		{
			get
			{
				if(r_Fm_Timestamp == null)
				{
					r_Fm_Timestamp = new(this, "m_Timestamp");
				}
				return r_Fm_Timestamp;
			}
		}

		/// <summary>
		/// System.Boolean m_IsInProgress
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_IsInProgress;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_IsInProgress
		{
			get
			{
				if(r_Fm_IsInProgress == null)
				{
					r_Fm_IsInProgress = new(this, "m_IsInProgress");
				}
				return r_Fm_IsInProgress;
			}
		}

		/// <summary>
		/// System.Action`2[UnityEditor.PackageManager.UI.Internal.IOperation,UnityEditor.PackageManager.UI.Internal.UIError] onOperationError
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> r_FonOperationError;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> RFonOperationError
		{
			get
			{
				if(r_FonOperationError == null)
				{
					r_FonOperationError = new(this, "onOperationError");
				}
				return r_FonOperationError;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onOperationSuccess
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> r_FonOperationSuccess;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> RFonOperationSuccess
		{
			get
			{
				if(r_FonOperationSuccess == null)
				{
					r_FonOperationSuccess = new(this, "onOperationSuccess");
				}
				return r_FonOperationSuccess;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onOperationFinalized
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> r_FonOperationFinalized;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> RFonOperationFinalized
		{
			get
			{
				if(r_FonOperationFinalized == null)
				{
					r_FonOperationFinalized = new(this, "onOperationFinalized");
				}
				return r_FonOperationFinalized;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onOperationProgress
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> r_FonOperationProgress;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> RFonOperationProgress
		{
			get
			{
				if(r_FonOperationProgress == null)
				{
					r_FonOperationProgress = new(this, "onOperationProgress");
				}
				return r_FonOperationProgress;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PurchasesQueryArgs m_OriginalQueryArgs
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPurchasesQueryArgs r_Fm_OriginalQueryArgs;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPurchasesQueryArgs RFm_OriginalQueryArgs
		{
			get
			{
				if(r_Fm_OriginalQueryArgs == null)
				{
					r_Fm_OriginalQueryArgs = new(this, "m_OriginalQueryArgs");
				}
				return r_Fm_OriginalQueryArgs;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PurchasesQueryArgs m_AdjustedQueryArgs
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPurchasesQueryArgs r_Fm_AdjustedQueryArgs;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPurchasesQueryArgs RFm_AdjustedQueryArgs
		{
			get
			{
				if(r_Fm_AdjustedQueryArgs == null)
				{
					r_Fm_AdjustedQueryArgs = new(this, "m_AdjustedQueryArgs");
				}
				return r_Fm_AdjustedQueryArgs;
			}
		}

		/// <summary>
		/// System.Boolean m_DownloadedAssetsOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_DownloadedAssetsOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_DownloadedAssetsOnly
		{
			get
			{
				if(r_Fm_DownloadedAssetsOnly == null)
				{
					r_Fm_DownloadedAssetsOnly = new(this, "m_DownloadedAssetsOnly");
				}
				return r_Fm_DownloadedAssetsOnly;
			}
		}

		/// <summary>
		/// System.Boolean m_UpdateAvailableOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_UpdateAvailableOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_UpdateAvailableOnly
		{
			get
			{
				if(r_Fm_UpdateAvailableOnly == null)
				{
					r_Fm_UpdateAvailableOnly = new(this, "m_UpdateAvailableOnly");
				}
				return r_Fm_UpdateAvailableOnly;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStorePurchases m_Result
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchases r_Fm_Result;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchases RFm_Result
		{
			get
			{
				if(r_Fm_Result == null)
				{
					r_Fm_Result = new(this, "m_Result");
				}
				return r_Fm_Result;
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
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI m_AssetStoreRestAPI
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreRestAPI r_Fm_AssetStoreRestAPI;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreRestAPI RFm_AssetStoreRestAPI
		{
			get
			{
				if(r_Fm_AssetStoreRestAPI == null)
				{
					r_Fm_AssetStoreRestAPI = new(this, "m_AssetStoreRestAPI");
				}
				return r_Fm_AssetStoreRestAPI;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreCache m_AssetStoreCache
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreCache r_Fm_AssetStoreCache;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreCache RFm_AssetStoreCache
		{
			get
			{
				if(r_Fm_AssetStoreCache == null)
				{
					r_Fm_AssetStoreCache = new(this, "m_AssetStoreCache");
				}
				return r_Fm_AssetStoreCache;
			}
		}

		/// <summary>
		/// System.String packageUniqueId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PpackageUniqueId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPpackageUniqueId
		{
			get
			{
				if(r_PpackageUniqueId == null)
				{
					r_PpackageUniqueId = new(this, "packageUniqueId", -1);
				}
				return r_PpackageUniqueId;
			}
		}

		/// <summary>
		/// System.String versionUniqueId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PversionUniqueId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPversionUniqueId
		{
			get
			{
				if(r_PversionUniqueId == null)
				{
					r_PversionUniqueId = new(this, "versionUniqueId", -1);
				}
				return r_PversionUniqueId;
			}
		}

		/// <summary>
		/// Int64 timestamp
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Ptimestamp;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPtimestamp
		{
			get
			{
				if(r_Ptimestamp == null)
				{
					r_Ptimestamp = new(this, "timestamp", -1);
				}
				return r_Ptimestamp;
			}
		}

		/// <summary>
		/// Int64 lastSuccessTimestamp
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_PlastSuccessTimestamp;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPlastSuccessTimestamp
		{
			get
			{
				if(r_PlastSuccessTimestamp == null)
				{
					r_PlastSuccessTimestamp = new(this, "lastSuccessTimestamp", -1);
				}
				return r_PlastSuccessTimestamp;
			}
		}

		/// <summary>
		/// Boolean isOfflineMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisOfflineMode;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisOfflineMode
		{
			get
			{
				if(r_PisOfflineMode == null)
				{
					r_PisOfflineMode = new(this, "isOfflineMode", -1);
				}
				return r_PisOfflineMode;
			}
		}

		/// <summary>
		/// Boolean isInProgress
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisInProgress;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisInProgress
		{
			get
			{
				if(r_PisInProgress == null)
				{
					r_PisInProgress = new(this, "isInProgress", -1);
				}
				return r_PisInProgress;
			}
		}

		/// <summary>
		/// Boolean isProgressVisible
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisProgressVisible;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisProgressVisible
		{
			get
			{
				if(r_PisProgressVisible == null)
				{
					r_PisProgressVisible = new(this, "isProgressVisible", -1);
				}
				return r_PisProgressVisible;
			}
		}

		/// <summary>
		/// Boolean isInPause
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisInPause;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisInPause
		{
			get
			{
				if(r_PisInPause == null)
				{
					r_PisInPause = new(this, "isInPause", -1);
				}
				return r_PisInPause;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.RefreshOptions refreshOptions
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRefreshOptions r_PrefreshOptions;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRefreshOptions RPrefreshOptions
		{
			get
			{
				if(r_PrefreshOptions == null)
				{
					r_PrefreshOptions = new(this, "refreshOptions", -1);
				}
				return r_PrefreshOptions;
			}
		}

		/// <summary>
		/// Boolean isProgressTrackable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisProgressTrackable;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisProgressTrackable
		{
			get
			{
				if(r_PisProgressTrackable == null)
				{
					r_PisProgressTrackable = new(this, "isProgressTrackable", -1);
				}
				return r_PisProgressTrackable;
			}
		}

		/// <summary>
		/// Single progressPercentage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PprogressPercentage;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPprogressPercentage
		{
			get
			{
				if(r_PprogressPercentage == null)
				{
					r_PprogressPercentage = new(this, "progressPercentage", -1);
				}
				return r_PprogressPercentage;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStorePurchases result
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchases r_Presult;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchases RPresult
		{
			get
			{
				if(r_Presult == null)
				{
					r_Presult = new(this, "result", -1);
				}
				return r_Presult;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.UnityConnectProxy, UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI, UnityEditor.PackageManager.UI.Internal.AssetStoreCache)
		/// </summary>
		protected RMethod r_MResolveDependencies_UnityConnectProxy_AssetStoreRestAPI_AssetStoreCache;
		public virtual RMethod RMResolveDependencies_UnityConnectProxy_AssetStoreRestAPI_AssetStoreCache
		{
			get
			{
				if(r_MResolveDependencies_UnityConnectProxy_AssetStoreRestAPI_AssetStoreCache == null)
				{
					r_MResolveDependencies_UnityConnectProxy_AssetStoreRestAPI_AssetStoreCache = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UnityConnectProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreCache"));
				}
				return r_MResolveDependencies_UnityConnectProxy_AssetStoreRestAPI_AssetStoreCache;
			}
		}

		/// <summary>
		/// System.String QueryToString(UnityEditor.PackageManager.UI.Internal.PurchasesQueryArgs)
		/// </summary>
		protected static RMethod r_MQueryToString_PurchasesQueryArgs;
		public static RMethod RMQueryToString_PurchasesQueryArgs
		{
			get
			{
				if(r_MQueryToString_PurchasesQueryArgs == null)
				{
					r_MQueryToString_PurchasesQueryArgs = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreListOperation"), "QueryToString", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PurchasesQueryArgs"));
				}
				return r_MQueryToString_PurchasesQueryArgs;
			}
		}

		/// <summary>
		/// Void Start(UnityEditor.PackageManager.UI.Internal.PurchasesQueryArgs)
		/// </summary>
		protected RMethod r_MStart_PurchasesQueryArgs;
		public virtual RMethod RMStart_PurchasesQueryArgs
		{
			get
			{
				if(r_MStart_PurchasesQueryArgs == null)
				{
					r_MStart_PurchasesQueryArgs = new(this, "Start", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PurchasesQueryArgs"));
				}
				return r_MStart_PurchasesQueryArgs;
			}
		}

		/// <summary>
		/// Void Stop()
		/// </summary>
		protected RMethod r_MStop;
		public virtual RMethod RMStop
		{
			get
			{
				if(r_MStop == null)
				{
					r_MStop = new(this, "Stop", 0);
				}
				return r_MStop;
			}
		}

		/// <summary>
		/// Void SetQueryArgs(UnityEditor.PackageManager.UI.Internal.PurchasesQueryArgs)
		/// </summary>
		protected RMethod r_MSetQueryArgs_PurchasesQueryArgs;
		public virtual RMethod RMSetQueryArgs_PurchasesQueryArgs
		{
			get
			{
				if(r_MSetQueryArgs_PurchasesQueryArgs == null)
				{
					r_MSetQueryArgs_PurchasesQueryArgs = new(this, "SetQueryArgs", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PurchasesQueryArgs"));
				}
				return r_MSetQueryArgs_PurchasesQueryArgs;
			}
		}

		/// <summary>
		/// Void GetPurchasesCallback(System.Collections.Generic.IDictionary`2[System.String,System.Object], Int64)
		/// </summary>
		protected RMethod r_MGetPurchasesCallback_IDictionary_d_String_Object_p__Int64;
		public virtual RMethod RMGetPurchasesCallback_IDictionary_d_String_Object_p__Int64
		{
			get
			{
				if(r_MGetPurchasesCallback_IDictionary_d_String_Object_p__Int64 == null)
				{
					r_MGetPurchasesCallback_IDictionary_d_String_Object_p__Int64 = new(this, "GetPurchasesCallback", 0, typeof(System.Collections.Generic.IDictionary<, >).MakeGenericType(typeof(System.String), typeof(System.Object)), typeof(System.Int64));
				}
				return r_MGetPurchasesCallback_IDictionary_d_String_Object_p__Int64;
			}
		}

		/// <summary>
		/// Void OnOperationError(UnityEditor.PackageManager.UI.Internal.UIError)
		/// </summary>
		protected RMethod r_MOnOperationError_UIError;
		public virtual RMethod RMOnOperationError_UIError
		{
			get
			{
				if(r_MOnOperationError_UIError == null)
				{
					r_MOnOperationError_UIError = new(this, "OnOperationError", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError"));
				}
				return r_MOnOperationError_UIError;
			}
		}

		/// <summary>
		/// Void FinalizedOperation()
		/// </summary>
		protected RMethod r_MFinalizedOperation;
		public virtual RMethod RMFinalizedOperation
		{
			get
			{
				if(r_MFinalizedOperation == null)
				{
					r_MFinalizedOperation = new(this, "FinalizedOperation", 0);
				}
				return r_MFinalizedOperation;
			}
		}

		/// <summary>
		/// Boolean <SetQueryArgs>b__54_1(UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo)
		/// </summary>
		protected RMethod r_M__0__SetQueryArgs__1__b__54_1_AssetStoreLocalInfo;
		public virtual RMethod RM__0__SetQueryArgs__1__b__54_1_AssetStoreLocalInfo
		{
			get
			{
				if(r_M__0__SetQueryArgs__1__b__54_1_AssetStoreLocalInfo == null)
				{
					r_M__0__SetQueryArgs__1__b__54_1_AssetStoreLocalInfo = new(this, "<SetQueryArgs>b__54_1", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo"));
				}
				return r_M__0__SetQueryArgs__1__b__54_1_AssetStoreLocalInfo;
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


        public virtual void ResolveDependencies(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityConnectProxy @unityConnect, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreRestAPI @assetStoreRestAPI, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreCache @assetStoreCache)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unityConnect.Value, @assetStoreRestAPI.Value, @assetStoreCache.Value};
            var ___result = RMResolveDependencies_UnityConnectProxy_AssetStoreRestAPI_AssetStoreCache.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String QueryToString(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPurchasesQueryArgs @queryArgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@queryArgs.Value};
            var ___result = RMQueryToString_PurchasesQueryArgs.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Start(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPurchasesQueryArgs @queryArgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@queryArgs.Value};
            var ___result = RMStart_PurchasesQueryArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Stop()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMStop.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetQueryArgs(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPurchasesQueryArgs @queryArgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@queryArgs.Value};
            var ___result = RMSetQueryArgs_PurchasesQueryArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetPurchasesCallback(System.Collections.Generic.IDictionary<System.String, System.Object> @result, System.Int64 @operationTimestamp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result, @operationTimestamp};
            var ___result = RMGetPurchasesCallback_IDictionary_d_String_Object_p__Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnOperationError(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError @error)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@error.Value};
            var ___result = RMOnOperationError_UIError.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FinalizedOperation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalizedOperation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__SetQueryArgs__1__b__54_1(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreLocalInfo @info)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info.Value};
            var ___result = RM__0__SetQueryArgs__1__b__54_1_AssetStoreLocalInfo.Invoke(___genericsType, ___parameters);

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
