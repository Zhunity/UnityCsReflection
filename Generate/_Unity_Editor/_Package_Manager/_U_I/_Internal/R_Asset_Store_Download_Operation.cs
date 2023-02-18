
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadOperation
	/// </summary>
    public partial class RAssetStoreDownloadOperation : RMember //
    {

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
					r_EonOperationError.SetBelong(this.GetValue());
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
					r_EonOperationSuccess.SetBelong(this.GetValue());
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
					r_EonOperationFinalized.SetBelong(this.GetValue());
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
					r_EonOperationProgress.SetBelong(this.GetValue());
				}
				return r_EonOperationProgress;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onOperationPaused
		/// </summary>
		protected REvent r_EonOperationPaused;
		public virtual REvent REonOperationPaused
		{
			get
			{
				if(r_EonOperationPaused == null)
				{
					r_EonOperationPaused = new(this, "onOperationPaused");
					r_EonOperationPaused.SetBelong(this.GetValue());
				}
				return r_EonOperationPaused;
			}
		}

		/// <summary>
		/// System.String k_DownloadErrorMessage
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_DownloadErrorMessage;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_DownloadErrorMessage
		{
			get
			{
				if(r_Fk_DownloadErrorMessage == null)
				{
					r_Fk_DownloadErrorMessage = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadOperation"), "k_DownloadErrorMessage");
					r_Fk_DownloadErrorMessage.SetBelong(null);
				}
				return r_Fk_DownloadErrorMessage;
			}
		}

		/// <summary>
		/// System.String k_AbortErrorMessage
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_AbortErrorMessage;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_AbortErrorMessage
		{
			get
			{
				if(r_Fk_AbortErrorMessage == null)
				{
					r_Fk_AbortErrorMessage = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadOperation"), "k_AbortErrorMessage");
					r_Fk_AbortErrorMessage.SetBelong(null);
				}
				return r_Fk_AbortErrorMessage;
			}
		}

		/// <summary>
		/// System.String k_AssetStoreDownloadPrefix
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_AssetStoreDownloadPrefix;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_AssetStoreDownloadPrefix
		{
			get
			{
				if(r_Fk_AssetStoreDownloadPrefix == null)
				{
					r_Fk_AssetStoreDownloadPrefix = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadOperation"), "k_AssetStoreDownloadPrefix");
					r_Fk_AssetStoreDownloadPrefix.SetBelong(null);
				}
				return r_Fk_AssetStoreDownloadPrefix;
			}
		}

		/// <summary>
		/// System.String k_ForbiddenErrorMessage
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_ForbiddenErrorMessage;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_ForbiddenErrorMessage
		{
			get
			{
				if(r_Fk_ForbiddenErrorMessage == null)
				{
					r_Fk_ForbiddenErrorMessage = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadOperation"), "k_ForbiddenErrorMessage");
					r_Fk_ForbiddenErrorMessage.SetBelong(null);
				}
				return r_Fk_ForbiddenErrorMessage;
			}
		}

		/// <summary>
		/// System.String k_ConsoleLogPrefix
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_ConsoleLogPrefix;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_ConsoleLogPrefix
		{
			get
			{
				if(r_Fk_ConsoleLogPrefix == null)
				{
					r_Fk_ConsoleLogPrefix = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadOperation"), "k_ConsoleLogPrefix");
					r_Fk_ConsoleLogPrefix.SetBelong(null);
				}
				return r_Fk_ConsoleLogPrefix;
			}
		}

		/// <summary>
		/// System.String m_ProductId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_ProductId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_ProductId
		{
			get
			{
				if(r_Fm_ProductId == null)
				{
					r_Fm_ProductId = new(this, "m_ProductId");
					r_Fm_ProductId.SetBelong(this.GetValue());
				}
				return r_Fm_ProductId;
			}
		}

		/// <summary>
		/// System.String m_ProductOldPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_ProductOldPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_ProductOldPath
		{
			get
			{
				if(r_Fm_ProductOldPath == null)
				{
					r_Fm_ProductOldPath = new(this, "m_ProductOldPath");
					r_Fm_ProductOldPath.SetBelong(this.GetValue());
				}
				return r_Fm_ProductOldPath;
			}
		}

		/// <summary>
		/// System.String m_ProductNewPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_ProductNewPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_ProductNewPath
		{
			get
			{
				if(r_Fm_ProductNewPath == null)
				{
					r_Fm_ProductNewPath = new(this, "m_ProductNewPath");
					r_Fm_ProductNewPath.SetBelong(this.GetValue());
				}
				return r_Fm_ProductNewPath;
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
					r_FonOperationError.SetBelong(this.GetValue());
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
					r_FonOperationSuccess.SetBelong(this.GetValue());
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
					r_FonOperationFinalized.SetBelong(this.GetValue());
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
					r_FonOperationProgress.SetBelong(this.GetValue());
				}
				return r_FonOperationProgress;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onOperationPaused
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> r_FonOperationPaused;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> RFonOperationPaused
		{
			get
			{
				if(r_FonOperationPaused == null)
				{
					r_FonOperationPaused = new(this, "onOperationPaused");
					r_FonOperationPaused.SetBelong(this.GetValue());
				}
				return r_FonOperationPaused;
			}
		}

		/// <summary>
		/// System.UInt64 m_DownloadedBytes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt64 r_Fm_DownloadedBytes;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt64 RFm_DownloadedBytes
		{
			get
			{
				if(r_Fm_DownloadedBytes == null)
				{
					r_Fm_DownloadedBytes = new(this, "m_DownloadedBytes");
					r_Fm_DownloadedBytes.SetBelong(this.GetValue());
				}
				return r_Fm_DownloadedBytes;
			}
		}

		/// <summary>
		/// System.UInt64 m_TotalBytes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt64 r_Fm_TotalBytes;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt64 RFm_TotalBytes
		{
			get
			{
				if(r_Fm_TotalBytes == null)
				{
					r_Fm_TotalBytes = new(this, "m_TotalBytes");
					r_Fm_TotalBytes.SetBelong(this.GetValue());
				}
				return r_Fm_TotalBytes;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.DownloadState m_State
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState r_Fm_State;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState RFm_State
		{
			get
			{
				if(r_Fm_State == null)
				{
					r_Fm_State = new(this, "m_State");
					r_Fm_State.SetBelong(this.GetValue());
				}
				return r_Fm_State;
			}
		}

		/// <summary>
		/// System.String m_ErrorMessage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_ErrorMessage;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_ErrorMessage
		{
			get
			{
				if(r_Fm_ErrorMessage == null)
				{
					r_Fm_ErrorMessage = new(this, "m_ErrorMessage");
					r_Fm_ErrorMessage.SetBelong(this.GetValue());
				}
				return r_Fm_ErrorMessage;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadInfo m_DownloadInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreDownloadInfo r_Fm_DownloadInfo;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreDownloadInfo RFm_DownloadInfo
		{
			get
			{
				if(r_Fm_DownloadInfo == null)
				{
					r_Fm_DownloadInfo = new(this, "m_DownloadInfo");
					r_Fm_DownloadInfo.SetBelong(this.GetValue());
				}
				return r_Fm_DownloadInfo;
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
					r_Fm_AssetStoreUtils.SetBelong(this.GetValue());
				}
				return r_Fm_AssetStoreUtils;
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
					r_Fm_AssetStoreRestAPI.SetBelong(this.GetValue());
				}
				return r_Fm_AssetStoreRestAPI;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreCachePathProxy m_AssetStoreCachePathProxy
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreCachePathProxy r_Fm_AssetStoreCachePathProxy;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreCachePathProxy RFm_AssetStoreCachePathProxy
		{
			get
			{
				if(r_Fm_AssetStoreCachePathProxy == null)
				{
					r_Fm_AssetStoreCachePathProxy = new(this, "m_AssetStoreCachePathProxy");
					r_Fm_AssetStoreCachePathProxy.SetBelong(this.GetValue());
				}
				return r_Fm_AssetStoreCachePathProxy;
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
					r_PpackageUniqueId.SetBelong(this.GetValue());
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
					r_PversionUniqueId.SetBelong(this.GetValue());
				}
				return r_PversionUniqueId;
			}
		}

		/// <summary>
		/// System.String packageOldPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PpackageOldPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPpackageOldPath
		{
			get
			{
				if(r_PpackageOldPath == null)
				{
					r_PpackageOldPath = new(this, "packageOldPath", -1);
					r_PpackageOldPath.SetBelong(this.GetValue());
				}
				return r_PpackageOldPath;
			}
		}

		/// <summary>
		/// System.String packageNewPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PpackageNewPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPpackageNewPath
		{
			get
			{
				if(r_PpackageNewPath == null)
				{
					r_PpackageNewPath = new(this, "packageNewPath", -1);
					r_PpackageNewPath.SetBelong(this.GetValue());
				}
				return r_PpackageNewPath;
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
					r_Ptimestamp.SetBelong(this.GetValue());
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
					r_PlastSuccessTimestamp.SetBelong(this.GetValue());
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
					r_PisOfflineMode.SetBelong(this.GetValue());
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
					r_PisInProgress.SetBelong(this.GetValue());
				}
				return r_PisInProgress;
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
					r_PisInPause.SetBelong(this.GetValue());
				}
				return r_PisInPause;
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
					r_PisProgressVisible.SetBelong(this.GetValue());
				}
				return r_PisProgressVisible;
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
					r_PisProgressTrackable.SetBelong(this.GetValue());
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
					r_PprogressPercentage.SetBelong(this.GetValue());
				}
				return r_PprogressPercentage;
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
					r_PrefreshOptions.SetBelong(this.GetValue());
				}
				return r_PrefreshOptions;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.DownloadState state
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState r_Pstate;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState RPstate
		{
			get
			{
				if(r_Pstate == null)
				{
					r_Pstate = new(this, "state", -1);
					r_Pstate.SetBelong(this.GetValue());
				}
				return r_Pstate;
			}
		}

		/// <summary>
		/// System.String errorMessage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PerrorMessage;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPerrorMessage
		{
			get
			{
				if(r_PerrorMessage == null)
				{
					r_PerrorMessage = new(this, "errorMessage", -1);
					r_PerrorMessage.SetBelong(this.GetValue());
				}
				return r_PerrorMessage;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadInfo downloadInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreDownloadInfo r_PdownloadInfo;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreDownloadInfo RPdownloadInfo
		{
			get
			{
				if(r_PdownloadInfo == null)
				{
					r_PdownloadInfo = new(this, "downloadInfo", -1);
					r_PdownloadInfo.SetBelong(this.GetValue());
				}
				return r_PdownloadInfo;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.AssetStoreUtils, UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI, UnityEditor.PackageManager.UI.Internal.AssetStoreCachePathProxy)
		/// </summary>
		protected RMethod r_MResolveDependencies_AssetStoreUtils_AssetStoreRestAPI_AssetStoreCachePathProxy;
		public virtual RMethod RMResolveDependencies_AssetStoreUtils_AssetStoreRestAPI_AssetStoreCachePathProxy
		{
			get
			{
				if(r_MResolveDependencies_AssetStoreUtils_AssetStoreRestAPI_AssetStoreCachePathProxy == null)
				{
					r_MResolveDependencies_AssetStoreUtils_AssetStoreRestAPI_AssetStoreCachePathProxy = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreUtils"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreCachePathProxy"));
					r_MResolveDependencies_AssetStoreUtils_AssetStoreRestAPI_AssetStoreCachePathProxy.SetBelong(this.GetValue());
				}
				return r_MResolveDependencies_AssetStoreUtils_AssetStoreRestAPI_AssetStoreCachePathProxy;
			}
		}

		/// <summary>
		/// Void OnDownloadProgress(System.String, UInt64, UInt64, Int32)
		/// </summary>
		protected RMethod r_MOnDownloadProgress_String_UInt64_UInt64_Int32;
		public virtual RMethod RMOnDownloadProgress_String_UInt64_UInt64_Int32
		{
			get
			{
				if(r_MOnDownloadProgress_String_UInt64_UInt64_Int32 == null)
				{
					r_MOnDownloadProgress_String_UInt64_UInt64_Int32 = new(this, "OnDownloadProgress", 0, typeof(System.String), typeof(System.UInt64), typeof(System.UInt64), typeof(System.Int32));
					r_MOnDownloadProgress_String_UInt64_UInt64_Int32.SetBelong(this.GetValue());
				}
				return r_MOnDownloadProgress_String_UInt64_UInt64_Int32;
			}
		}

		/// <summary>
		/// Void OnErrorMessage(System.String, Int32, Attribute)
		/// </summary>
		protected RMethod r_MOnErrorMessage_String_Int32_Attribute;
		public virtual RMethod RMOnErrorMessage_String_Int32_Attribute
		{
			get
			{
				if(r_MOnErrorMessage_String_Int32_Attribute == null)
				{
					r_MOnErrorMessage_String_Int32_Attribute = new(this, "OnErrorMessage", 0, typeof(System.String), typeof(System.Int32),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError+Attribute"));
					r_MOnErrorMessage_String_Int32_Attribute.SetBelong(this.GetValue());
				}
				return r_MOnErrorMessage_String_Int32_Attribute;
			}
		}

		/// <summary>
		/// Void Pause()
		/// </summary>
		protected RMethod r_MPause;
		public virtual RMethod RMPause
		{
			get
			{
				if(r_MPause == null)
				{
					r_MPause = new(this, "Pause", 0);
					r_MPause.SetBelong(this.GetValue());
				}
				return r_MPause;
			}
		}

		/// <summary>
		/// Void Cancel()
		/// </summary>
		protected RMethod r_MCancel;
		public virtual RMethod RMCancel
		{
			get
			{
				if(r_MCancel == null)
				{
					r_MCancel = new(this, "Cancel", 0);
					r_MCancel.SetBelong(this.GetValue());
				}
				return r_MCancel;
			}
		}

		/// <summary>
		/// Void Abort()
		/// </summary>
		protected RMethod r_MAbort;
		public virtual RMethod RMAbort
		{
			get
			{
				if(r_MAbort == null)
				{
					r_MAbort = new(this, "Abort", 0);
					r_MAbort.SetBelong(this.GetValue());
				}
				return r_MAbort;
			}
		}

		/// <summary>
		/// Void Download(Boolean)
		/// </summary>
		protected RMethod r_MDownload_Boolean;
		public virtual RMethod RMDownload_Boolean
		{
			get
			{
				if(r_MDownload_Boolean == null)
				{
					r_MDownload_Boolean = new(this, "Download", 0, typeof(System.Boolean));
					r_MDownload_Boolean.SetBelong(this.GetValue());
				}
				return r_MDownload_Boolean;
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


        public RAssetStoreDownloadOperation() : base("UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadOperation")
        {
        }

        public RAssetStoreDownloadOperation(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadOperation")
		{
            SetInstance(instance);
		}

        public RAssetStoreDownloadOperation(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssetStoreDownloadOperation(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void ResolveDependencies(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUtils @assetStoreUtils, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreRestAPI @assetStoreRestAPI, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreCachePathProxy @assetStoreCachePathProxy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assetStoreUtils.Value, @assetStoreRestAPI.Value, @assetStoreCachePathProxy.Value};
            var ___result = RMResolveDependencies_AssetStoreUtils_AssetStoreRestAPI_AssetStoreCachePathProxy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDownloadProgress(System.String @message, System.UInt64 @bytes, System.UInt64 @total, System.Int32 @errorCode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@message, @bytes, @total, @errorCode};
            var ___result = RMOnDownloadProgress_String_UInt64_UInt64_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnErrorMessage(System.String @errorMessage, System.Int32 @operationErrorCode, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError.RAttribute @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@errorMessage, @operationErrorCode, @attr.Value};
            var ___result = RMOnErrorMessage_String_Int32_Attribute.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Pause()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPause.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Cancel()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCancel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Abort()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAbort.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Download(System.Boolean @resume)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resume};
            var ___result = RMDownload_Boolean.Invoke(___genericsType, ___parameters);

            
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
