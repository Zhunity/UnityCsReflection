
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEditor.PackageManager.UI.Internal.UpmAddAndRemoveOperation
	/// </summary>
    public partial class RUpmAddAndRemoveOperation : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmAddAndRemoveOperation");
            }
        }

        public RUpmAddAndRemoveOperation() : base("UnityEditor.PackageManager.UI.Internal.UpmAddAndRemoveOperation")
        {
        }

        public RUpmAddAndRemoveOperation(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.UpmAddAndRemoveOperation")
		{
            SetInstance(instance);
		}

        public RUpmAddAndRemoveOperation(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUpmAddAndRemoveOperation(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// System.Action`1[UnityEditor.PackageManager.Requests.AddAndRemoveRequest] onProcessResult
		/// </summary>
		protected REvent r_EonProcessResult;
		public virtual REvent REonProcessResult
		{
			get
			{
				if(r_EonProcessResult == null)
				{
					r_EonProcessResult = new(this, "onProcessResult");
				}
				return r_EonProcessResult;
			}
		}

		/// <summary>
		/// System.String[] m_PackageIdsToReset
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_PackageIdsToReset;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFm_PackageIdsToReset
		{
			get
			{
				if(r_Fm_PackageIdsToReset == null)
				{
					r_Fm_PackageIdsToReset = new(this, "m_PackageIdsToReset");
				}
				return r_Fm_PackageIdsToReset;
			}
		}

		/// <summary>
		/// System.String[] m_PackageIdsToAdd
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_PackageIdsToAdd;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFm_PackageIdsToAdd
		{
			get
			{
				if(r_Fm_PackageIdsToAdd == null)
				{
					r_Fm_PackageIdsToAdd = new(this, "m_PackageIdsToAdd");
				}
				return r_Fm_PackageIdsToAdd;
			}
		}

		/// <summary>
		/// System.String[] m_PackagesNamesToRemove
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_PackagesNamesToRemove;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFm_PackagesNamesToRemove
		{
			get
			{
				if(r_Fm_PackagesNamesToRemove == null)
				{
					r_Fm_PackagesNamesToRemove = new(this, "m_PackagesNamesToRemove");
				}
				return r_Fm_PackagesNamesToRemove;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.Requests.AddAndRemoveRequest m_Request
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRequests.RAddAndRemoveRequest r_Fm_Request;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRequests.RAddAndRemoveRequest RFm_Request
		{
			get
			{
				if(r_Fm_Request == null)
				{
					r_Fm_Request = new(this, "m_Request");
				}
				return r_Fm_Request;
			}
		}

		/// <summary>
		/// System.Boolean m_IsCompleted
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_IsCompleted;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_IsCompleted
		{
			get
			{
				if(r_Fm_IsCompleted == null)
				{
					r_Fm_IsCompleted = new(this, "m_IsCompleted");
				}
				return r_Fm_IsCompleted;
			}
		}

		/// <summary>
		/// System.String m_PackageName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_PackageName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_PackageName
		{
			get
			{
				if(r_Fm_PackageName == null)
				{
					r_Fm_PackageName = new(this, "m_PackageName");
				}
				return r_Fm_PackageName;
			}
		}

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
				}
				return r_Fm_PackageId;
			}
		}

		/// <summary>
		/// System.String m_PackageUniqueId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_PackageUniqueId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_PackageUniqueId
		{
			get
			{
				if(r_Fm_PackageUniqueId == null)
				{
					r_Fm_PackageUniqueId = new(this, "m_PackageUniqueId");
				}
				return r_Fm_PackageUniqueId;
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
		/// System.Int64 m_LastSuccessTimestamp
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Fm_LastSuccessTimestamp;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFm_LastSuccessTimestamp
		{
			get
			{
				if(r_Fm_LastSuccessTimestamp == null)
				{
					r_Fm_LastSuccessTimestamp = new(this, "m_LastSuccessTimestamp");
				}
				return r_Fm_LastSuccessTimestamp;
			}
		}

		/// <summary>
		/// System.Boolean m_OfflineMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_OfflineMode;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_OfflineMode
		{
			get
			{
				if(r_Fm_OfflineMode == null)
				{
					r_Fm_OfflineMode = new(this, "m_OfflineMode");
				}
				return r_Fm_OfflineMode;
			}
		}

		/// <summary>
		/// System.Boolean m_LogErrorInConsole
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_LogErrorInConsole;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_LogErrorInConsole
		{
			get
			{
				if(r_Fm_LogErrorInConsole == null)
				{
					r_Fm_LogErrorInConsole = new(this, "m_LogErrorInConsole");
				}
				return r_Fm_LogErrorInConsole;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.ClientProxy m_ClientProxy
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RClientProxy r_Fm_ClientProxy;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RClientProxy RFm_ClientProxy
		{
			get
			{
				if(r_Fm_ClientProxy == null)
				{
					r_Fm_ClientProxy = new(this, "m_ClientProxy");
				}
				return r_Fm_ClientProxy;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.ApplicationProxy m_ApplicationProxy
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RApplicationProxy r_Fm_ApplicationProxy;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RApplicationProxy RFm_ApplicationProxy
		{
			get
			{
				if(r_Fm_ApplicationProxy == null)
				{
					r_Fm_ApplicationProxy = new(this, "m_ApplicationProxy");
				}
				return r_Fm_ApplicationProxy;
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
		/// System.String operationErrorMessage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PoperationErrorMessage;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPoperationErrorMessage
		{
			get
			{
				if(r_PoperationErrorMessage == null)
				{
					r_PoperationErrorMessage = new(this, "operationErrorMessage", -1);
				}
				return r_PoperationErrorMessage;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.String] packageIdsToReset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RString> r_PpackageIdsToReset;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RString> RPpackageIdsToReset
		{
			get
			{
				if(r_PpackageIdsToReset == null)
				{
					r_PpackageIdsToReset = new(this, "packageIdsToReset", -1);
				}
				return r_PpackageIdsToReset;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.String] packageIdsToAdd
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RString> r_PpackageIdsToAdd;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RString> RPpackageIdsToAdd
		{
			get
			{
				if(r_PpackageIdsToAdd == null)
				{
					r_PpackageIdsToAdd = new(this, "packageIdsToAdd", -1);
				}
				return r_PpackageIdsToAdd;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.String] packagesNamesToRemove
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RString> r_PpackagesNamesToRemove;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RString> RPpackagesNamesToRemove
		{
			get
			{
				if(r_PpackagesNamesToRemove == null)
				{
					r_PpackagesNamesToRemove = new(this, "packagesNamesToRemove", -1);
				}
				return r_PpackagesNamesToRemove;
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
		/// System.String packageName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PpackageName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPpackageName
		{
			get
			{
				if(r_PpackageName == null)
				{
					r_PpackageName = new(this, "packageName", -1);
				}
				return r_PpackageName;
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
				}
				return r_PpackageId;
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
		/// Boolean logErrorInConsole
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PlogErrorInConsole;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPlogErrorInConsole
		{
			get
			{
				if(r_PlogErrorInConsole == null)
				{
					r_PlogErrorInConsole = new(this, "logErrorInConsole", -1);
				}
				return r_PlogErrorInConsole;
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
		/// Void AddByIds(System.Collections.Generic.IEnumerable`1[System.String])
		/// </summary>
		protected RMethod r_MAddByIds_IEnumerable_d_String_p_;
		public virtual RMethod RMAddByIds_IEnumerable_d_String_p_
		{
			get
			{
				if(r_MAddByIds_IEnumerable_d_String_p_ == null)
				{
					r_MAddByIds_IEnumerable_d_String_p_ = new(this, "AddByIds", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(typeof(System.String)));
				}
				return r_MAddByIds_IEnumerable_d_String_p_;
			}
		}

		/// <summary>
		/// Void RemoveByNames(System.Collections.Generic.IEnumerable`1[System.String])
		/// </summary>
		protected RMethod r_MRemoveByNames_IEnumerable_d_String_p_;
		public virtual RMethod RMRemoveByNames_IEnumerable_d_String_p_
		{
			get
			{
				if(r_MRemoveByNames_IEnumerable_d_String_p_ == null)
				{
					r_MRemoveByNames_IEnumerable_d_String_p_ = new(this, "RemoveByNames", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(typeof(System.String)));
				}
				return r_MRemoveByNames_IEnumerable_d_String_p_;
			}
		}

		/// <summary>
		/// Void AddAndResetDependencies(System.String, System.Collections.Generic.IEnumerable`1[System.String])
		/// </summary>
		protected RMethod r_MAddAndResetDependencies_String_IEnumerable_d_String_p_;
		public virtual RMethod RMAddAndResetDependencies_String_IEnumerable_d_String_p_
		{
			get
			{
				if(r_MAddAndResetDependencies_String_IEnumerable_d_String_p_ == null)
				{
					r_MAddAndResetDependencies_String_IEnumerable_d_String_p_ = new(this, "AddAndResetDependencies", 0, typeof(System.String),  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(typeof(System.String)));
				}
				return r_MAddAndResetDependencies_String_IEnumerable_d_String_p_;
			}
		}

		/// <summary>
		/// Void ResetDependencies(System.String, System.Collections.Generic.IEnumerable`1[System.String])
		/// </summary>
		protected RMethod r_MResetDependencies_String_IEnumerable_d_String_p_;
		public virtual RMethod RMResetDependencies_String_IEnumerable_d_String_p_
		{
			get
			{
				if(r_MResetDependencies_String_IEnumerable_d_String_p_ == null)
				{
					r_MResetDependencies_String_IEnumerable_d_String_p_ = new(this, "ResetDependencies", 0, typeof(System.String),  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(typeof(System.String)));
				}
				return r_MResetDependencies_String_IEnumerable_d_String_p_;
			}
		}

		/// <summary>
		/// Void SetPrimaryPackageNameOrId(System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_MSetPrimaryPackageNameOrId_String_String_String;
		public virtual RMethod RMSetPrimaryPackageNameOrId_String_String_String
		{
			get
			{
				if(r_MSetPrimaryPackageNameOrId_String_String_String == null)
				{
					r_MSetPrimaryPackageNameOrId_String_String_String = new(this, "SetPrimaryPackageNameOrId", 0, typeof(System.String), typeof(System.String), typeof(System.String));
				}
				return r_MSetPrimaryPackageNameOrId_String_String_String;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.Requests.AddAndRemoveRequest CreateRequest()
		/// </summary>
		protected RMethod r_MCreateRequest;
		public virtual RMethod RMCreateRequest
		{
			get
			{
				if(r_MCreateRequest == null)
				{
					r_MCreateRequest = new(this, "CreateRequest", 0);
				}
				return r_MCreateRequest;
			}
		}

		/// <summary>
		/// Void Start()
		/// </summary>
		protected RMethod r_MStart;
		public virtual RMethod RMStart
		{
			get
			{
				if(r_MStart == null)
				{
					r_MStart = new(this, "Start", 0);
				}
				return r_MStart;
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
				}
				return r_MCancel;
			}
		}

		/// <summary>
		/// Void Progress()
		/// </summary>
		protected RMethod r_MProgress;
		public virtual RMethod RMProgress
		{
			get
			{
				if(r_MProgress == null)
				{
					r_MProgress = new(this, "Progress", 0);
				}
				return r_MProgress;
			}
		}

		/// <summary>
		/// Void RestoreProgress()
		/// </summary>
		protected RMethod r_MRestoreProgress;
		public virtual RMethod RMRestoreProgress
		{
			get
			{
				if(r_MRestoreProgress == null)
				{
					r_MRestoreProgress = new(this, "RestoreProgress", 0);
				}
				return r_MRestoreProgress;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.ClientProxy, UnityEditor.PackageManager.UI.Internal.ApplicationProxy)
		/// </summary>
		protected RMethod r_MResolveDependencies_ClientProxy_ApplicationProxy;
		public virtual RMethod RMResolveDependencies_ClientProxy_ApplicationProxy
		{
			get
			{
				if(r_MResolveDependencies_ClientProxy_ApplicationProxy == null)
				{
					r_MResolveDependencies_ClientProxy_ApplicationProxy = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.ClientProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.ApplicationProxy"));
				}
				return r_MResolveDependencies_ClientProxy_ApplicationProxy;
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


        public virtual void AddByIds(System.Collections.Generic.IEnumerable<System.String> @versionIds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@versionIds};
            var ___result = RMAddByIds_IEnumerable_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveByNames(System.Collections.Generic.IEnumerable<System.String> @packagesNames)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packagesNames};
            var ___result = RMRemoveByNames_IEnumerable_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddAndResetDependencies(System.String @packageId, System.Collections.Generic.IEnumerable<System.String> @dependencyPackagesNames)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageId, @dependencyPackagesNames};
            var ___result = RMAddAndResetDependencies_String_IEnumerable_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetDependencies(System.String @packageId, System.Collections.Generic.IEnumerable<System.String> @dependencyPackagesNames)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageId, @dependencyPackagesNames};
            var ___result = RMResetDependencies_String_IEnumerable_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPrimaryPackageNameOrId(System.String @packageId, System.String @packageName, System.String @packageUniqueId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageId, @packageName, @packageUniqueId};
            var ___result = RMSetPrimaryPackageNameOrId_String_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEditor.PackageManager.Requests.AddAndRemoveRequest CreateRequest()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateRequest.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.PackageManager.Requests.AddAndRemoveRequest>(___result);
        }


        public virtual void Start()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Cancel()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCancel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Progress()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMProgress.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RestoreProgress()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRestoreProgress.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResolveDependencies(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RClientProxy @clientProxy, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RApplicationProxy @applicationProxy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clientProxy.Value, @applicationProxy.Value};
            var ___result = RMResolveDependencies_ClientProxy_ApplicationProxy.Invoke(___genericsType, ___parameters);

            
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
