
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.Internal.AssetStoreCallQueue
	/// </summary>
    public partial class RAssetStoreCallQueue : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreCallQueue");
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
					r_Fk_CheckUpdateChunkSize = new(Type, "k_CheckUpdateChunkSize");
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
					r_Fk_FetchDetailsCountPerUpdate = new(Type, "k_FetchDetailsCountPerUpdate");
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
					r_Fk_MaxFetchDetailsCount = new(Type, "k_MaxFetchDetailsCount");
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
				}
				return r_Fm_AssetStoreCache;
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
				}
				return r_Fm_DetailsToFetch;
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
				}
				return r_Fm_SerializedCheckUpdateStack;
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
				}
				return r_Fm_CheckUpdateStack;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.ApplicationProxy, UnityEditor.PackageManager.UI.Internal.UnityConnectProxy, UnityEditor.PackageManager.UI.Internal.PackageFiltering, UnityEditor.PackageManager.UI.Internal.AssetStoreClient, UnityEditor.PackageManager.UI.Internal.AssetStoreCache)
		/// </summary>
		protected RMethod r_MResolveDependencies_ApplicationProxy_UnityConnectProxy_PackageFiltering_AssetStoreClient_AssetStoreCache;
		public virtual RMethod RMResolveDependencies_ApplicationProxy_UnityConnectProxy_PackageFiltering_AssetStoreClient_AssetStoreCache
		{
			get
			{
				if(r_MResolveDependencies_ApplicationProxy_UnityConnectProxy_PackageFiltering_AssetStoreClient_AssetStoreCache == null)
				{
					r_MResolveDependencies_ApplicationProxy_UnityConnectProxy_PackageFiltering_AssetStoreClient_AssetStoreCache = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.ApplicationProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UnityConnectProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageFiltering"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreClient"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreCache"));
				}
				return r_MResolveDependencies_ApplicationProxy_UnityConnectProxy_PackageFiltering_AssetStoreClient_AssetStoreCache;
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
					r_MOnLocalInfosChanged_IEnumerable_d_AssetStoreLocalInfo_p__IEnumerable_d_AssetStoreLocalInfo_p_ = new(this, "OnLocalInfosChanged", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo")),  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo")));
				}
				return r_MOnLocalInfosChanged_IEnumerable_d_AssetStoreLocalInfo_p__IEnumerable_d_AssetStoreLocalInfo_p_;
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
				}
				return r_MRemoveFromFetchDetailsQueue_String;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_MClear;
		public virtual RMethod RMClear
		{
			get
			{
				if(r_MClear == null)
				{
					r_MClear = new(this, "Clear", 0);
				}
				return r_MClear;
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
				}
				return r_MCheckUpdateFromStack;
			}
		}

		/// <summary>
		/// Void InsertToCheckUpdateQueue(System.String)
		/// </summary>
		protected RMethod r_MInsertToCheckUpdateQueue_String;
		public virtual RMethod RMInsertToCheckUpdateQueue_String
		{
			get
			{
				if(r_MInsertToCheckUpdateQueue_String == null)
				{
					r_MInsertToCheckUpdateQueue_String = new(this, "InsertToCheckUpdateQueue", 0, typeof(System.String));
				}
				return r_MInsertToCheckUpdateQueue_String;
			}
		}

		/// <summary>
		/// Void InsertToCheckUpdateQueue(System.Collections.Generic.IEnumerable`1[System.String])
		/// </summary>
		protected RMethod r_MInsertToCheckUpdateQueue_IEnumerable_d_String_p_;
		public virtual RMethod RMInsertToCheckUpdateQueue_IEnumerable_d_String_p_
		{
			get
			{
				if(r_MInsertToCheckUpdateQueue_IEnumerable_d_String_p_ == null)
				{
					r_MInsertToCheckUpdateQueue_IEnumerable_d_String_p_ = new(this, "InsertToCheckUpdateQueue", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(typeof(System.String)));
				}
				return r_MInsertToCheckUpdateQueue_IEnumerable_d_String_p_;
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
				}
				return r_MProcessCallQueue;
			}
		}

		/// <summary>
		/// Boolean <OnLocalInfosChanged>b__20_0(UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo)
		/// </summary>
		protected RMethod r_M__0__OnLocalInfosChanged__1__b__20_0_AssetStoreLocalInfo;
		public virtual RMethod RM__0__OnLocalInfosChanged__1__b__20_0_AssetStoreLocalInfo
		{
			get
			{
				if(r_M__0__OnLocalInfosChanged__1__b__20_0_AssetStoreLocalInfo == null)
				{
					r_M__0__OnLocalInfosChanged__1__b__20_0_AssetStoreLocalInfo = new(this, "<OnLocalInfosChanged>b__20_0", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo"));
				}
				return r_M__0__OnLocalInfosChanged__1__b__20_0_AssetStoreLocalInfo;
			}
		}

		/// <summary>
		/// Void <CheckUpdateFromStack>b__25_0()
		/// </summary>
		protected RMethod r_M__0__CheckUpdateFromStack__1__b__25_0;
		public virtual RMethod RM__0__CheckUpdateFromStack__1__b__25_0
		{
			get
			{
				if(r_M__0__CheckUpdateFromStack__1__b__25_0 == null)
				{
					r_M__0__CheckUpdateFromStack__1__b__25_0 = new(this, "<CheckUpdateFromStack>b__25_0", 0);
				}
				return r_M__0__CheckUpdateFromStack__1__b__25_0;
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


        public virtual void ResolveDependencies(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RApplicationProxy @application, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityConnectProxy @unityConnect, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFiltering @packageFiltering, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreClient @assetStoreClient, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreCache @assetStoreCache)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@application.Value, @unityConnect.Value, @packageFiltering.Value, @assetStoreClient.Value, @assetStoreCache.Value};
            var ___result = RMResolveDependencies_ApplicationProxy_UnityConnectProxy_PackageFiltering_AssetStoreClient_AssetStoreCache.Invoke(___genericsType, ___parameters);

            
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


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
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


        public virtual void InsertToCheckUpdateQueue(System.String @productId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productId};
            var ___result = RMInsertToCheckUpdateQueue_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertToCheckUpdateQueue(System.Collections.Generic.IEnumerable<System.String> @productIds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productIds};
            var ___result = RMInsertToCheckUpdateQueue_IEnumerable_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessCallQueue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMProcessCallQueue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__OnLocalInfosChanged__1__b__20_0(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreLocalInfo @info)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info.Value};
            var ___result = RM__0__OnLocalInfosChanged__1__b__20_0_AssetStoreLocalInfo.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void __0__CheckUpdateFromStack__1__b__25_0()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RM__0__CheckUpdateFromStack__1__b__25_0.Invoke(___genericsType, ___parameters);

            
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
