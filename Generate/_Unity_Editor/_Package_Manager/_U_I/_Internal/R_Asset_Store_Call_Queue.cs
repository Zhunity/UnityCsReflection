
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.AssetStoreCallQueue
	/// </summary>
    public partial class RAssetStoreCallQueue : RMember //
    {

		/// <summary>
		/// System.Action onCheckUpdateProgress
		/// </summary>
		protected REvent r_EonCheckUpdateProgress;
		public virtual REvent REonCheckUpdateProgress
		{
			get
			{
				if(r_EonCheckUpdateProgress == null)
				{
					r_EonCheckUpdateProgress = new(this, "onCheckUpdateProgress");
					r_EonCheckUpdateProgress.SetBelong(this.instance);
				}
				return r_EonCheckUpdateProgress;
			}
		}

		/// <summary>
		/// System.Action onCheckUpdateProgress
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_FonCheckUpdateProgress;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFonCheckUpdateProgress
		{
			get
			{
				if(r_FonCheckUpdateProgress == null)
				{
					r_FonCheckUpdateProgress = new(this, "onCheckUpdateProgress");
					r_FonCheckUpdateProgress.SetBelong(this.instance);
				}
				return r_FonCheckUpdateProgress;
			}
		}

		/// <summary>
		/// System.Int32 k_CheckUpdateChunkSize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_CheckUpdateChunkSize;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_CheckUpdateChunkSize
		{
			get
			{
				if(r_Fk_CheckUpdateChunkSize == null)
				{
					r_Fk_CheckUpdateChunkSize = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreCallQueue"), "k_CheckUpdateChunkSize");
					r_Fk_CheckUpdateChunkSize.SetBelong(null);
				}
				return r_Fk_CheckUpdateChunkSize;
			}
		}

		/// <summary>
		/// System.Int32 k_FetchDetailsCountPerUpdate
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_FetchDetailsCountPerUpdate;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_FetchDetailsCountPerUpdate
		{
			get
			{
				if(r_Fk_FetchDetailsCountPerUpdate == null)
				{
					r_Fk_FetchDetailsCountPerUpdate = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreCallQueue"), "k_FetchDetailsCountPerUpdate");
					r_Fk_FetchDetailsCountPerUpdate.SetBelong(null);
				}
				return r_Fk_FetchDetailsCountPerUpdate;
			}
		}

		/// <summary>
		/// System.Int32 k_MaxFetchDetailsCount
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_MaxFetchDetailsCount;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_MaxFetchDetailsCount
		{
			get
			{
				if(r_Fk_MaxFetchDetailsCount == null)
				{
					r_Fk_MaxFetchDetailsCount = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreCallQueue"), "k_MaxFetchDetailsCount");
					r_Fk_MaxFetchDetailsCount.SetBelong(null);
				}
				return r_Fk_MaxFetchDetailsCount;
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
					r_Fm_Application.SetBelong(this.instance);
				}
				return r_Fm_Application;
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
					r_Fm_UnityConnect.SetBelong(this.instance);
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
					r_Fm_PackageFiltering.SetBelong(this.instance);
				}
				return r_Fm_PackageFiltering;
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
					r_Fm_AssetStoreClient.SetBelong(this.instance);
				}
				return r_Fm_AssetStoreClient;
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
					r_Fm_AssetStoreCache.SetBelong(this.instance);
				}
				return r_Fm_AssetStoreCache;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PageManager m_PageManager
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageManager r_Fm_PageManager;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageManager RFm_PageManager
		{
			get
			{
				if(r_Fm_PageManager == null)
				{
					r_Fm_PageManager = new(this, "m_PageManager");
					r_Fm_PageManager.SetBelong(this.instance);
				}
				return r_Fm_PageManager;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.String] m_CurrentFetchDetails
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_CurrentFetchDetails;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RString> RFm_CurrentFetchDetails
		{
			get
			{
				if(r_Fm_CurrentFetchDetails == null)
				{
					r_Fm_CurrentFetchDetails = new(this, "m_CurrentFetchDetails");
					r_Fm_CurrentFetchDetails.SetBelong(this.instance);
				}
				return r_Fm_CurrentFetchDetails;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Queue`1[System.String] m_FetchDetailsQueue
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RQueue<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_FetchDetailsQueue;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RQueue<Hvak.Editor.Refleaction.RSystem.RString> RFm_FetchDetailsQueue
		{
			get
			{
				if(r_Fm_FetchDetailsQueue == null)
				{
					r_Fm_FetchDetailsQueue = new(this, "m_FetchDetailsQueue");
					r_Fm_FetchDetailsQueue.SetBelong(this.instance);
				}
				return r_Fm_FetchDetailsQueue;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.String] m_DetailsToFetch
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_DetailsToFetch;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RString> RFm_DetailsToFetch
		{
			get
			{
				if(r_Fm_DetailsToFetch == null)
				{
					r_Fm_DetailsToFetch = new(this, "m_DetailsToFetch");
					r_Fm_DetailsToFetch.SetBelong(this.instance);
				}
				return r_Fm_DetailsToFetch;
			}
		}

		/// <summary>
		/// System.Boolean m_RefreshAfterCheckUpdates
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_RefreshAfterCheckUpdates;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_RefreshAfterCheckUpdates
		{
			get
			{
				if(r_Fm_RefreshAfterCheckUpdates == null)
				{
					r_Fm_RefreshAfterCheckUpdates = new(this, "m_RefreshAfterCheckUpdates");
					r_Fm_RefreshAfterCheckUpdates.SetBelong(this.instance);
				}
				return r_Fm_RefreshAfterCheckUpdates;
			}
		}

		/// <summary>
		/// System.String[] m_SerializedCheckUpdateStack
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_SerializedCheckUpdateStack;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFm_SerializedCheckUpdateStack
		{
			get
			{
				if(r_Fm_SerializedCheckUpdateStack == null)
				{
					r_Fm_SerializedCheckUpdateStack = new(this, "m_SerializedCheckUpdateStack");
					r_Fm_SerializedCheckUpdateStack.SetBelong(this.instance);
				}
				return r_Fm_SerializedCheckUpdateStack;
			}
		}

		/// <summary>
		/// System.String[] m_SerializedForceCheckUpdateLookupKeys
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_SerializedForceCheckUpdateLookupKeys;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFm_SerializedForceCheckUpdateLookupKeys
		{
			get
			{
				if(r_Fm_SerializedForceCheckUpdateLookupKeys == null)
				{
					r_Fm_SerializedForceCheckUpdateLookupKeys = new(this, "m_SerializedForceCheckUpdateLookupKeys");
					r_Fm_SerializedForceCheckUpdateLookupKeys.SetBelong(this.instance);
				}
				return r_Fm_SerializedForceCheckUpdateLookupKeys;
			}
		}

		/// <summary>
		/// System.Boolean[] m_SerializedForceCheckUpdateLookupValues
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RBoolean> r_Fm_SerializedForceCheckUpdateLookupValues;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RBoolean> RFm_SerializedForceCheckUpdateLookupValues
		{
			get
			{
				if(r_Fm_SerializedForceCheckUpdateLookupValues == null)
				{
					r_Fm_SerializedForceCheckUpdateLookupValues = new(this, "m_SerializedForceCheckUpdateLookupValues");
					r_Fm_SerializedForceCheckUpdateLookupValues.SetBelong(this.instance);
				}
				return r_Fm_SerializedForceCheckUpdateLookupValues;
			}
		}

		/// <summary>
		/// System.Boolean m_CheckUpdateInProgress
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_CheckUpdateInProgress;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_CheckUpdateInProgress
		{
			get
			{
				if(r_Fm_CheckUpdateInProgress == null)
				{
					r_Fm_CheckUpdateInProgress = new(this, "m_CheckUpdateInProgress");
					r_Fm_CheckUpdateInProgress.SetBelong(this.instance);
				}
				return r_Fm_CheckUpdateInProgress;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Stack`1[System.String] m_CheckUpdateStack
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RStack<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_CheckUpdateStack;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RStack<Hvak.Editor.Refleaction.RSystem.RString> RFm_CheckUpdateStack
		{
			get
			{
				if(r_Fm_CheckUpdateStack == null)
				{
					r_Fm_CheckUpdateStack = new(this, "m_CheckUpdateStack");
					r_Fm_CheckUpdateStack.SetBelong(this.instance);
				}
				return r_Fm_CheckUpdateStack;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Boolean] m_ForceCheckUpdateLookup
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RBoolean> r_Fm_ForceCheckUpdateLookup;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RBoolean> RFm_ForceCheckUpdateLookup
		{
			get
			{
				if(r_Fm_ForceCheckUpdateLookup == null)
				{
					r_Fm_ForceCheckUpdateLookup = new(this, "m_ForceCheckUpdateLookup");
					r_Fm_ForceCheckUpdateLookup.SetBelong(this.instance);
				}
				return r_Fm_ForceCheckUpdateLookup;
			}
		}

		/// <summary>
		/// Boolean isCheckUpdateInProgress
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisCheckUpdateInProgress;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisCheckUpdateInProgress
		{
			get
			{
				if(r_PisCheckUpdateInProgress == null)
				{
					r_PisCheckUpdateInProgress = new(this, "isCheckUpdateInProgress", -1);
					r_PisCheckUpdateInProgress.SetBelong(this.instance);
				}
				return r_PisCheckUpdateInProgress;
			}
		}

		/// <summary>
		/// Int32 checkUpdatePercentage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PcheckUpdatePercentage;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPcheckUpdatePercentage
		{
			get
			{
				if(r_PcheckUpdatePercentage == null)
				{
					r_PcheckUpdatePercentage = new(this, "checkUpdatePercentage", -1);
					r_PcheckUpdatePercentage.SetBelong(this.instance);
				}
				return r_PcheckUpdatePercentage;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.ApplicationProxy, UnityEditor.PackageManager.UI.Internal.UnityConnectProxy, UnityEditor.PackageManager.UI.Internal.PackageFiltering, UnityEditor.PackageManager.UI.Internal.AssetStoreClient, UnityEditor.PackageManager.UI.Internal.AssetStoreCache, UnityEditor.PackageManager.UI.Internal.PageManager)
		/// </summary>
		protected RMethod r_MResolveDependencies_ApplicationProxy_UnityConnectProxy_PackageFiltering_AssetStoreClient_AssetStoreCache_PageManager;
		public virtual RMethod RMResolveDependencies_ApplicationProxy_UnityConnectProxy_PackageFiltering_AssetStoreClient_AssetStoreCache_PageManager
		{
			get
			{
				if(r_MResolveDependencies_ApplicationProxy_UnityConnectProxy_PackageFiltering_AssetStoreClient_AssetStoreCache_PageManager == null)
				{
					r_MResolveDependencies_ApplicationProxy_UnityConnectProxy_PackageFiltering_AssetStoreClient_AssetStoreCache_PageManager = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.ApplicationProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UnityConnectProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageFiltering"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreClient"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreCache"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PageManager"));
					r_MResolveDependencies_ApplicationProxy_UnityConnectProxy_PackageFiltering_AssetStoreClient_AssetStoreCache_PageManager.SetBelong(this.instance);
				}
				return r_MResolveDependencies_ApplicationProxy_UnityConnectProxy_PackageFiltering_AssetStoreClient_AssetStoreCache_PageManager;
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
					r_MOnBeforeSerialize.SetBelong(this.instance);
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
					r_MOnAfterDeserialize.SetBelong(this.instance);
				}
				return r_MOnAfterDeserialize;
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
					r_MOnFilterChanged_PackageFilterTab.SetBelong(this.instance);
				}
				return r_MOnFilterChanged_PackageFilterTab;
			}
		}

		/// <summary>
		/// Void OnLocalInfosChanged(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo], System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo])
		/// </summary>
		protected RMethod r_MOnLocalInfosChanged_IEnumerable_d_AssetStoreLocalInfo_p__IEnumerable_d_AssetStoreLocalInfo_p_;
		public virtual RMethod RMOnLocalInfosChanged_IEnumerable_d_AssetStoreLocalInfo_p__IEnumerable_d_AssetStoreLocalInfo_p_
		{
			get
			{
				if(r_MOnLocalInfosChanged_IEnumerable_d_AssetStoreLocalInfo_p__IEnumerable_d_AssetStoreLocalInfo_p_ == null)
				{
					r_MOnLocalInfosChanged_IEnumerable_d_AssetStoreLocalInfo_p__IEnumerable_d_AssetStoreLocalInfo_p_ = new(this, "OnLocalInfosChanged", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo")), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo")));
					r_MOnLocalInfosChanged_IEnumerable_d_AssetStoreLocalInfo_p__IEnumerable_d_AssetStoreLocalInfo_p_.SetBelong(this.instance);
				}
				return r_MOnLocalInfosChanged_IEnumerable_d_AssetStoreLocalInfo_p__IEnumerable_d_AssetStoreLocalInfo_p_;
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
		/// Void AddToFetchDetailsQueue(System.String)
		/// </summary>
		protected RMethod r_MAddToFetchDetailsQueue_String;
		public virtual RMethod RMAddToFetchDetailsQueue_String
		{
			get
			{
				if(r_MAddToFetchDetailsQueue_String == null)
				{
					r_MAddToFetchDetailsQueue_String = new(this, "AddToFetchDetailsQueue", 0, typeof(System.String));
					r_MAddToFetchDetailsQueue_String.SetBelong(this.instance);
				}
				return r_MAddToFetchDetailsQueue_String;
			}
		}

		/// <summary>
		/// Void RemoveFromFetchDetailsQueue(System.String)
		/// </summary>
		protected RMethod r_MRemoveFromFetchDetailsQueue_String;
		public virtual RMethod RMRemoveFromFetchDetailsQueue_String
		{
			get
			{
				if(r_MRemoveFromFetchDetailsQueue_String == null)
				{
					r_MRemoveFromFetchDetailsQueue_String = new(this, "RemoveFromFetchDetailsQueue", 0, typeof(System.String));
					r_MRemoveFromFetchDetailsQueue_String.SetBelong(this.instance);
				}
				return r_MRemoveFromFetchDetailsQueue_String;
			}
		}

		/// <summary>
		/// Void ClearFetchDetails()
		/// </summary>
		protected RMethod r_MClearFetchDetails;
		public virtual RMethod RMClearFetchDetails
		{
			get
			{
				if(r_MClearFetchDetails == null)
				{
					r_MClearFetchDetails = new(this, "ClearFetchDetails", 0);
					r_MClearFetchDetails.SetBelong(this.instance);
				}
				return r_MClearFetchDetails;
			}
		}

		/// <summary>
		/// Void FetchDetailsFromQueue()
		/// </summary>
		protected RMethod r_MFetchDetailsFromQueue;
		public virtual RMethod RMFetchDetailsFromQueue
		{
			get
			{
				if(r_MFetchDetailsFromQueue == null)
				{
					r_MFetchDetailsFromQueue = new(this, "FetchDetailsFromQueue", 0);
					r_MFetchDetailsFromQueue.SetBelong(this.instance);
				}
				return r_MFetchDetailsFromQueue;
			}
		}

		/// <summary>
		/// Void CheckUpdateFromStack()
		/// </summary>
		protected RMethod r_MCheckUpdateFromStack;
		public virtual RMethod RMCheckUpdateFromStack
		{
			get
			{
				if(r_MCheckUpdateFromStack == null)
				{
					r_MCheckUpdateFromStack = new(this, "CheckUpdateFromStack", 0);
					r_MCheckUpdateFromStack.SetBelong(this.instance);
				}
				return r_MCheckUpdateFromStack;
			}
		}

		/// <summary>
		/// Void InsertToCheckUpdateQueue(System.String, Boolean)
		/// </summary>
		protected RMethod r_MInsertToCheckUpdateQueue_String_Boolean;
		public virtual RMethod RMInsertToCheckUpdateQueue_String_Boolean
		{
			get
			{
				if(r_MInsertToCheckUpdateQueue_String_Boolean == null)
				{
					r_MInsertToCheckUpdateQueue_String_Boolean = new(this, "InsertToCheckUpdateQueue", 0, typeof(System.String), typeof(System.Boolean));
					r_MInsertToCheckUpdateQueue_String_Boolean.SetBelong(this.instance);
				}
				return r_MInsertToCheckUpdateQueue_String_Boolean;
			}
		}

		/// <summary>
		/// Void InsertToCheckUpdateQueue(System.Collections.Generic.IEnumerable`1[System.String], Boolean)
		/// </summary>
		protected RMethod r_MInsertToCheckUpdateQueue_IEnumerable_d_String_p__Boolean;
		public virtual RMethod RMInsertToCheckUpdateQueue_IEnumerable_d_String_p__Boolean
		{
			get
			{
				if(r_MInsertToCheckUpdateQueue_IEnumerable_d_String_p__Boolean == null)
				{
					r_MInsertToCheckUpdateQueue_IEnumerable_d_String_p__Boolean = new(this, "InsertToCheckUpdateQueue", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.String)), typeof(System.Boolean));
					r_MInsertToCheckUpdateQueue_IEnumerable_d_String_p__Boolean.SetBelong(this.instance);
				}
				return r_MInsertToCheckUpdateQueue_IEnumerable_d_String_p__Boolean;
			}
		}

		/// <summary>
		/// Void ForceCheckUpdateForAllLocalInfos()
		/// </summary>
		protected RMethod r_MForceCheckUpdateForAllLocalInfos;
		public virtual RMethod RMForceCheckUpdateForAllLocalInfos
		{
			get
			{
				if(r_MForceCheckUpdateForAllLocalInfos == null)
				{
					r_MForceCheckUpdateForAllLocalInfos = new(this, "ForceCheckUpdateForAllLocalInfos", 0);
					r_MForceCheckUpdateForAllLocalInfos.SetBelong(this.instance);
				}
				return r_MForceCheckUpdateForAllLocalInfos;
			}
		}

		/// <summary>
		/// Void CancelCheckUpdates()
		/// </summary>
		protected RMethod r_MCancelCheckUpdates;
		public virtual RMethod RMCancelCheckUpdates
		{
			get
			{
				if(r_MCancelCheckUpdates == null)
				{
					r_MCancelCheckUpdates = new(this, "CancelCheckUpdates", 0);
					r_MCancelCheckUpdates.SetBelong(this.instance);
				}
				return r_MCancelCheckUpdates;
			}
		}

		/// <summary>
		/// Void CheckUpdateForUncheckedLocalInfos()
		/// </summary>
		protected RMethod r_MCheckUpdateForUncheckedLocalInfos;
		public virtual RMethod RMCheckUpdateForUncheckedLocalInfos
		{
			get
			{
				if(r_MCheckUpdateForUncheckedLocalInfos == null)
				{
					r_MCheckUpdateForUncheckedLocalInfos = new(this, "CheckUpdateForUncheckedLocalInfos", 0);
					r_MCheckUpdateForUncheckedLocalInfos.SetBelong(this.instance);
				}
				return r_MCheckUpdateForUncheckedLocalInfos;
			}
		}

		/// <summary>
		/// Void ProcessCallQueue()
		/// </summary>
		protected RMethod r_MProcessCallQueue;
		public virtual RMethod RMProcessCallQueue
		{
			get
			{
				if(r_MProcessCallQueue == null)
				{
					r_MProcessCallQueue = new(this, "ProcessCallQueue", 0);
					r_MProcessCallQueue.SetBelong(this.instance);
				}
				return r_MProcessCallQueue;
			}
		}

		/// <summary>
		/// Boolean <OnLocalInfosChanged>b__32_0(UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo)
		/// </summary>
		protected RMethod r_M__0__OnLocalInfosChanged__1__b__32_0_AssetStoreLocalInfo;
		public virtual RMethod RM__0__OnLocalInfosChanged__1__b__32_0_AssetStoreLocalInfo
		{
			get
			{
				if(r_M__0__OnLocalInfosChanged__1__b__32_0_AssetStoreLocalInfo == null)
				{
					r_M__0__OnLocalInfosChanged__1__b__32_0_AssetStoreLocalInfo = new(this, "<OnLocalInfosChanged>b__32_0", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo"));
					r_M__0__OnLocalInfosChanged__1__b__32_0_AssetStoreLocalInfo.SetBelong(this.instance);
				}
				return r_M__0__OnLocalInfosChanged__1__b__32_0_AssetStoreLocalInfo;
			}
		}

		/// <summary>
		/// Void <CheckUpdateFromStack>b__38_0()
		/// </summary>
		protected RMethod r_M__0__CheckUpdateFromStack__1__b__38_0;
		public virtual RMethod RM__0__CheckUpdateFromStack__1__b__38_0
		{
			get
			{
				if(r_M__0__CheckUpdateFromStack__1__b__38_0 == null)
				{
					r_M__0__CheckUpdateFromStack__1__b__38_0 = new(this, "<CheckUpdateFromStack>b__38_0", 0);
					r_M__0__CheckUpdateFromStack__1__b__38_0.SetBelong(this.instance);
				}
				return r_M__0__CheckUpdateFromStack__1__b__38_0;
			}
		}

		/// <summary>
		/// Boolean <CheckUpdateForUncheckedLocalInfos>b__43_0(UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo)
		/// </summary>
		protected RMethod r_M__0__CheckUpdateForUncheckedLocalInfos__1__b__43_0_AssetStoreLocalInfo;
		public virtual RMethod RM__0__CheckUpdateForUncheckedLocalInfos__1__b__43_0_AssetStoreLocalInfo
		{
			get
			{
				if(r_M__0__CheckUpdateForUncheckedLocalInfos__1__b__43_0_AssetStoreLocalInfo == null)
				{
					r_M__0__CheckUpdateForUncheckedLocalInfos__1__b__43_0_AssetStoreLocalInfo = new(this, "<CheckUpdateForUncheckedLocalInfos>b__43_0", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo"));
					r_M__0__CheckUpdateForUncheckedLocalInfos__1__b__43_0_AssetStoreLocalInfo.SetBelong(this.instance);
				}
				return r_M__0__CheckUpdateForUncheckedLocalInfos__1__b__43_0_AssetStoreLocalInfo;
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


        public RAssetStoreCallQueue() : base("UnityEditor.PackageManager.UI.Internal.AssetStoreCallQueue")
        {
        }

        public RAssetStoreCallQueue(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.AssetStoreCallQueue")
		{
            SetInstance(instance);
		}

        public RAssetStoreCallQueue(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssetStoreCallQueue(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void ResolveDependencies(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RApplicationProxy @application, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityConnectProxy @unityConnect, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFiltering @packageFiltering, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreClient @assetStoreClient, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreCache @assetStoreCache, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageManager @pageManager)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@application.Value, @unityConnect.Value, @packageFiltering.Value, @assetStoreClient.Value, @assetStoreCache.Value, @pageManager.Value};
            var ___result = RMResolveDependencies_ApplicationProxy_UnityConnectProxy_PackageFiltering_AssetStoreClient_AssetStoreCache_PageManager.Invoke(___genericsType, ___parameters);

            
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


        public virtual void OnFilterChanged(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab @filterTab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filterTab.Value};
            var ___result = RMOnFilterChanged_PackageFilterTab.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLocalInfosChanged(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreLocalInfo> @addedOrUpdated, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreLocalInfo> @removed)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@addedOrUpdated.Value, @removed.Value};
            var ___result = RMOnLocalInfosChanged_IEnumerable_d_AssetStoreLocalInfo_p__IEnumerable_d_AssetStoreLocalInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnUserLoginStateChange(System.Boolean @isUserInfoReady, System.Boolean @isUserLoggedIn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isUserInfoReady, @isUserLoggedIn};
            var ___result = RMOnUserLoginStateChange_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddToFetchDetailsQueue(System.String @packageUniqueId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueId};
            var ___result = RMAddToFetchDetailsQueue_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFromFetchDetailsQueue(System.String @packageUniqueId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueId};
            var ___result = RMRemoveFromFetchDetailsQueue_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearFetchDetails()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearFetchDetails.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FetchDetailsFromQueue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFetchDetailsFromQueue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckUpdateFromStack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCheckUpdateFromStack.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertToCheckUpdateQueue(System.String @productId, System.Boolean @forceCheckUpdate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productId, @forceCheckUpdate};
            var ___result = RMInsertToCheckUpdateQueue_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertToCheckUpdateQueue(System.Collections.Generic.IEnumerable<System.String> @productIds, System.Boolean @forceCheckUpdate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productIds, @forceCheckUpdate};
            var ___result = RMInsertToCheckUpdateQueue_IEnumerable_d_String_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ForceCheckUpdateForAllLocalInfos()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMForceCheckUpdateForAllLocalInfos.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CancelCheckUpdates()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCancelCheckUpdates.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckUpdateForUncheckedLocalInfos()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCheckUpdateForUncheckedLocalInfos.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessCallQueue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMProcessCallQueue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__OnLocalInfosChanged__1__b__32_0(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreLocalInfo @info)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info.Value};
            var ___result = RM__0__OnLocalInfosChanged__1__b__32_0_AssetStoreLocalInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void __0__CheckUpdateFromStack__1__b__38_0()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RM__0__CheckUpdateFromStack__1__b__38_0.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__CheckUpdateForUncheckedLocalInfos__1__b__43_0(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreLocalInfo @info)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info.Value};
            var ___result = RM__0__CheckUpdateForUncheckedLocalInfos__1__b__43_0_AssetStoreLocalInfo.Invoke(___genericsType, ___parameters);

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
