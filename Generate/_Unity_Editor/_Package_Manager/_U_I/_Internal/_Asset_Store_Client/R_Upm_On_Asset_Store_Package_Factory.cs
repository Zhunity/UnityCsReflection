
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{public partial class RAssetStoreClient
{
	
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.AssetStoreClient+UpmOnAssetStorePackageFactory
	/// </summary>
    public partial class RUpmOnAssetStorePackageFactory : RMember //
    {

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
		/// UnityEditor.PackageManager.UI.Internal.UpmClient m_UpmClient
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmClient r_Fm_UpmClient;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmClient RFm_UpmClient
		{
			get
			{
				if(r_Fm_UpmClient == null)
				{
					r_Fm_UpmClient = new(this, "m_UpmClient");
					r_Fm_UpmClient.SetBelong(this.instance);
				}
				return r_Fm_UpmClient;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.AssetStoreCache, UnityEditor.PackageManager.UI.Internal.AssetStoreClient, UnityEditor.PackageManager.UI.Internal.FetchStatusTracker, UnityEditor.PackageManager.UI.Internal.UpmCache, UnityEditor.PackageManager.UI.Internal.UpmClient)
		/// </summary>
		protected RMethod r_MResolveDependencies_AssetStoreCache_AssetStoreClient_FetchStatusTracker_UpmCache_UpmClient;
		public virtual RMethod RMResolveDependencies_AssetStoreCache_AssetStoreClient_FetchStatusTracker_UpmCache_UpmClient
		{
			get
			{
				if(r_MResolveDependencies_AssetStoreCache_AssetStoreClient_FetchStatusTracker_UpmCache_UpmClient == null)
				{
					r_MResolveDependencies_AssetStoreCache_AssetStoreClient_FetchStatusTracker_UpmCache_UpmClient = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreCache"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreClient"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.FetchStatusTracker"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmCache"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmClient"));
					r_MResolveDependencies_AssetStoreCache_AssetStoreClient_FetchStatusTracker_UpmCache_UpmClient.SetBelong(this.instance);
				}
				return r_MResolveDependencies_AssetStoreCache_AssetStoreClient_FetchStatusTracker_UpmCache_UpmClient;
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
		/// Void FetchPurchaseAndProductInfo(System.String)
		/// </summary>
		protected RMethod r_MFetchPurchaseAndProductInfo_String;
		public virtual RMethod RMFetchPurchaseAndProductInfo_String
		{
			get
			{
				if(r_MFetchPurchaseAndProductInfo_String == null)
				{
					r_MFetchPurchaseAndProductInfo_String = new(this, "FetchPurchaseAndProductInfo", 0, typeof(System.String));
					r_MFetchPurchaseAndProductInfo_String.SetBelong(this.instance);
				}
				return r_MFetchPurchaseAndProductInfo_String;
			}
		}

		/// <summary>
		/// Void RestartInProgressFetches()
		/// </summary>
		protected RMethod r_MRestartInProgressFetches;
		public virtual RMethod RMRestartInProgressFetches
		{
			get
			{
				if(r_MRestartInProgressFetches == null)
				{
					r_MRestartInProgressFetches = new(this, "RestartInProgressFetches", 0);
					r_MRestartInProgressFetches.SetBelong(this.instance);
				}
				return r_MRestartInProgressFetches;
			}
		}

		/// <summary>
		/// Void GeneratePackagesAndTriggerChangeEvent(System.Collections.Generic.IEnumerable`1[System.String])
		/// </summary>
		protected RMethod r_MGeneratePackagesAndTriggerChangeEvent_IEnumerable_d_String_p_;
		public virtual RMethod RMGeneratePackagesAndTriggerChangeEvent_IEnumerable_d_String_p_
		{
			get
			{
				if(r_MGeneratePackagesAndTriggerChangeEvent_IEnumerable_d_String_p_ == null)
				{
					r_MGeneratePackagesAndTriggerChangeEvent_IEnumerable_d_String_p_ = new(this, "GeneratePackagesAndTriggerChangeEvent", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.String)));
					r_MGeneratePackagesAndTriggerChangeEvent_IEnumerable_d_String_p_.SetBelong(this.instance);
				}
				return r_MGeneratePackagesAndTriggerChangeEvent_IEnumerable_d_String_p_;
			}
		}

		/// <summary>
		/// Void OnProductInfoChanged(UnityEditor.PackageManager.UI.Internal.AssetStoreProductInfo)
		/// </summary>
		protected RMethod r_MOnProductInfoChanged_AssetStoreProductInfo;
		public virtual RMethod RMOnProductInfoChanged_AssetStoreProductInfo
		{
			get
			{
				if(r_MOnProductInfoChanged_AssetStoreProductInfo == null)
				{
					r_MOnProductInfoChanged_AssetStoreProductInfo = new(this, "OnProductInfoChanged", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreProductInfo"));
					r_MOnProductInfoChanged_AssetStoreProductInfo.SetBelong(this.instance);
				}
				return r_MOnProductInfoChanged_AssetStoreProductInfo;
			}
		}

		/// <summary>
		/// Void OnPurchaseInfosChanged(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.AssetStorePurchaseInfo])
		/// </summary>
		protected RMethod r_MOnPurchaseInfosChanged_IEnumerable_d_AssetStorePurchaseInfo_p_;
		public virtual RMethod RMOnPurchaseInfosChanged_IEnumerable_d_AssetStorePurchaseInfo_p_
		{
			get
			{
				if(r_MOnPurchaseInfosChanged_IEnumerable_d_AssetStorePurchaseInfo_p_ == null)
				{
					r_MOnPurchaseInfosChanged_IEnumerable_d_AssetStorePurchaseInfo_p_ = new(this, "OnPurchaseInfosChanged", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStorePurchaseInfo")));
					r_MOnPurchaseInfosChanged_IEnumerable_d_AssetStorePurchaseInfo_p_.SetBelong(this.instance);
				}
				return r_MOnPurchaseInfosChanged_IEnumerable_d_AssetStorePurchaseInfo_p_;
			}
		}

		/// <summary>
		/// Void OnPackageInfosUpdated(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.PackageInfo])
		/// </summary>
		protected RMethod r_MOnPackageInfosUpdated_IEnumerable_d_PackageInfo_p_;
		public virtual RMethod RMOnPackageInfosUpdated_IEnumerable_d_PackageInfo_p_
		{
			get
			{
				if(r_MOnPackageInfosUpdated_IEnumerable_d_PackageInfo_p_ == null)
				{
					r_MOnPackageInfosUpdated_IEnumerable_d_PackageInfo_p_ = new(this, "OnPackageInfosUpdated", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(UnityEditor.PackageManager.PackageInfo)));
					r_MOnPackageInfosUpdated_IEnumerable_d_PackageInfo_p_.SetBelong(this.instance);
				}
				return r_MOnPackageInfosUpdated_IEnumerable_d_PackageInfo_p_;
			}
		}

		/// <summary>
		/// Void OnExtraPackageInfoFetched(UnityEditor.PackageManager.PackageInfo)
		/// </summary>
		protected RMethod r_MOnExtraPackageInfoFetched_PackageInfo;
		public virtual RMethod RMOnExtraPackageInfoFetched_PackageInfo
		{
			get
			{
				if(r_MOnExtraPackageInfoFetched_PackageInfo == null)
				{
					r_MOnExtraPackageInfoFetched_PackageInfo = new(this, "OnExtraPackageInfoFetched", 0, typeof(UnityEditor.PackageManager.PackageInfo));
					r_MOnExtraPackageInfoFetched_PackageInfo.SetBelong(this.instance);
				}
				return r_MOnExtraPackageInfoFetched_PackageInfo;
			}
		}

		/// <summary>
		/// Void OnLoadAllVersionsChanged(System.String, Boolean)
		/// </summary>
		protected RMethod r_MOnLoadAllVersionsChanged_String_Boolean;
		public virtual RMethod RMOnLoadAllVersionsChanged_String_Boolean
		{
			get
			{
				if(r_MOnLoadAllVersionsChanged_String_Boolean == null)
				{
					r_MOnLoadAllVersionsChanged_String_Boolean = new(this, "OnLoadAllVersionsChanged", 0, typeof(System.String), typeof(System.Boolean));
					r_MOnLoadAllVersionsChanged_String_Boolean.SetBelong(this.instance);
				}
				return r_MOnLoadAllVersionsChanged_String_Boolean;
			}
		}

		/// <summary>
		/// Void OnFetchStatusChanged(UnityEditor.PackageManager.UI.Internal.FetchStatus)
		/// </summary>
		protected RMethod r_MOnFetchStatusChanged_FetchStatus;
		public virtual RMethod RMOnFetchStatusChanged_FetchStatus
		{
			get
			{
				if(r_MOnFetchStatusChanged_FetchStatus == null)
				{
					r_MOnFetchStatusChanged_FetchStatus = new(this, "OnFetchStatusChanged", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.FetchStatus"));
					r_MOnFetchStatusChanged_FetchStatus.SetBelong(this.instance);
				}
				return r_MOnFetchStatusChanged_FetchStatus;
			}
		}

		/// <summary>
		/// Void OnUserLogOut()
		/// </summary>
		protected RMethod r_MOnUserLogOut;
		public virtual RMethod RMOnUserLogOut
		{
			get
			{
				if(r_MOnUserLogOut == null)
				{
					r_MOnUserLogOut = new(this, "OnUserLogOut", 0);
					r_MOnUserLogOut.SetBelong(this.instance);
				}
				return r_MOnUserLogOut;
			}
		}

		/// <summary>
		/// System.String <OnPackageInfosUpdated>b__13_0(UnityEditor.PackageManager.PackageInfo)
		/// </summary>
		protected RMethod r_M__0__OnPackageInfosUpdated__1__b__13_0_PackageInfo;
		public virtual RMethod RM__0__OnPackageInfosUpdated__1__b__13_0_PackageInfo
		{
			get
			{
				if(r_M__0__OnPackageInfosUpdated__1__b__13_0_PackageInfo == null)
				{
					r_M__0__OnPackageInfosUpdated__1__b__13_0_PackageInfo = new(this, "<OnPackageInfosUpdated>b__13_0", 0, typeof(UnityEditor.PackageManager.PackageInfo));
					r_M__0__OnPackageInfosUpdated__1__b__13_0_PackageInfo.SetBelong(this.instance);
				}
				return r_M__0__OnPackageInfosUpdated__1__b__13_0_PackageInfo;
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


        public RUpmOnAssetStorePackageFactory() : base("UnityEditor.PackageManager.UI.Internal.AssetStoreClient+UpmOnAssetStorePackageFactory")
        {
        }

        public RUpmOnAssetStorePackageFactory(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.AssetStoreClient+UpmOnAssetStorePackageFactory")
		{
            SetInstance(instance);
		}

        public RUpmOnAssetStorePackageFactory(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUpmOnAssetStorePackageFactory(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void ResolveDependencies(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreCache @assetStoreCache, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreClient @assetStoreClient, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchStatusTracker @fetchStatusTracker, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmCache @upmCache, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmClient @upmClient)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assetStoreCache.Value, @assetStoreClient.Value, @fetchStatusTracker.Value, @upmCache.Value, @upmClient.Value};
            var ___result = RMResolveDependencies_AssetStoreCache_AssetStoreClient_FetchStatusTracker_UpmCache_UpmClient.Invoke(___genericsType, ___parameters);

            
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


        public virtual void FetchPurchaseAndProductInfo(System.String @productId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productId};
            var ___result = RMFetchPurchaseAndProductInfo_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RestartInProgressFetches()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRestartInProgressFetches.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GeneratePackagesAndTriggerChangeEvent(System.Collections.Generic.IEnumerable<System.String> @productIds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productIds};
            var ___result = RMGeneratePackagesAndTriggerChangeEvent_IEnumerable_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnProductInfoChanged(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreProductInfo @productInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productInfo.Value};
            var ___result = RMOnProductInfoChanged_AssetStoreProductInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPurchaseInfosChanged(SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchaseInfo> @purchaseInfos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@purchaseInfos.Value};
            var ___result = RMOnPurchaseInfosChanged_IEnumerable_d_AssetStorePurchaseInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPackageInfosUpdated(System.Collections.Generic.IEnumerable<UnityEditor.PackageManager.PackageInfo> @packageInfos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageInfos};
            var ___result = RMOnPackageInfosUpdated_IEnumerable_d_PackageInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnExtraPackageInfoFetched(UnityEditor.PackageManager.PackageInfo @packageInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageInfo};
            var ___result = RMOnExtraPackageInfoFetched_PackageInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadAllVersionsChanged(System.String @packageUniqueId, System.Boolean @_)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueId, @_};
            var ___result = RMOnLoadAllVersionsChanged_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnFetchStatusChanged(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchStatus @fetchStatus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fetchStatus.Value};
            var ___result = RMOnFetchStatusChanged_FetchStatus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnUserLogOut()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnUserLogOut.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String __0__OnPackageInfosUpdated__1__b__13_0(UnityEditor.PackageManager.PackageInfo @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p};
            var ___result = RM__0__OnPackageInfosUpdated__1__b__13_0_PackageInfo.Invoke(___genericsType, ___parameters);

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
}