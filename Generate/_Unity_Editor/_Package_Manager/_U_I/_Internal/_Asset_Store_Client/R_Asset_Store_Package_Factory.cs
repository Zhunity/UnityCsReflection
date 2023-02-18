
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{public partial class RAssetStoreClient
{
	
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.AssetStoreClient+AssetStorePackageFactory
	/// </summary>
    public partial class RAssetStorePackageFactory : RMember //
    {

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
					r_Fm_AssetStoreCache.SetBelong(this.GetValue());
				}
				return r_Fm_AssetStoreCache;
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
		/// UnityEditor.PackageManager.UI.Internal.FetchStatusTracker m_FetchStatusTracker
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchStatusTracker r_Fm_FetchStatusTracker;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchStatusTracker RFm_FetchStatusTracker
		{
			get
			{
				if(r_Fm_FetchStatusTracker == null)
				{
					r_Fm_FetchStatusTracker = new(this, "m_FetchStatusTracker");
					r_Fm_FetchStatusTracker.SetBelong(this.GetValue());
				}
				return r_Fm_FetchStatusTracker;
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
		/// UnityEditor.PackageManager.UI.Internal.IOProxy m_IOProxy
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOProxy r_Fm_IOProxy;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOProxy RFm_IOProxy
		{
			get
			{
				if(r_Fm_IOProxy == null)
				{
					r_Fm_IOProxy = new(this, "m_IOProxy");
					r_Fm_IOProxy.SetBelong(this.GetValue());
				}
				return r_Fm_IOProxy;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.AssetStoreCache, UnityEditor.PackageManager.UI.Internal.AssetStoreClient, UnityEditor.PackageManager.UI.Internal.AssetStoreUtils, UnityEditor.PackageManager.UI.Internal.FetchStatusTracker, UnityEditor.PackageManager.UI.Internal.UpmCache, UnityEditor.PackageManager.UI.Internal.IOProxy)
		/// </summary>
		protected RMethod r_MResolveDependencies_AssetStoreCache_AssetStoreClient_AssetStoreUtils_FetchStatusTracker_UpmCache_IOProxy;
		public virtual RMethod RMResolveDependencies_AssetStoreCache_AssetStoreClient_AssetStoreUtils_FetchStatusTracker_UpmCache_IOProxy
		{
			get
			{
				if(r_MResolveDependencies_AssetStoreCache_AssetStoreClient_AssetStoreUtils_FetchStatusTracker_UpmCache_IOProxy == null)
				{
					r_MResolveDependencies_AssetStoreCache_AssetStoreClient_AssetStoreUtils_FetchStatusTracker_UpmCache_IOProxy = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreCache"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreClient"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreUtils"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.FetchStatusTracker"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmCache"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOProxy"));
					r_MResolveDependencies_AssetStoreCache_AssetStoreClient_AssetStoreUtils_FetchStatusTracker_UpmCache_IOProxy.SetBelong(this.GetValue());
				}
				return r_MResolveDependencies_AssetStoreCache_AssetStoreClient_AssetStoreUtils_FetchStatusTracker_UpmCache_IOProxy;
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
					r_MGeneratePackagesAndTriggerChangeEvent_IEnumerable_d_String_p_.SetBelong(this.GetValue());
				}
				return r_MGeneratePackagesAndTriggerChangeEvent_IEnumerable_d_String_p_;
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
					r_MOnLocalInfosChanged_IEnumerable_d_AssetStoreLocalInfo_p__IEnumerable_d_AssetStoreLocalInfo_p_.SetBelong(this.GetValue());
				}
				return r_MOnLocalInfosChanged_IEnumerable_d_AssetStoreLocalInfo_p__IEnumerable_d_AssetStoreLocalInfo_p_;
			}
		}

		/// <summary>
		/// Void OnUpdatesFound(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.AssetStoreUpdateInfo])
		/// </summary>
		protected RMethod r_MOnUpdatesFound_IEnumerable_d_AssetStoreUpdateInfo_p_;
		public virtual RMethod RMOnUpdatesFound_IEnumerable_d_AssetStoreUpdateInfo_p_
		{
			get
			{
				if(r_MOnUpdatesFound_IEnumerable_d_AssetStoreUpdateInfo_p_ == null)
				{
					r_MOnUpdatesFound_IEnumerable_d_AssetStoreUpdateInfo_p_ = new(this, "OnUpdatesFound", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreUpdateInfo")));
					r_MOnUpdatesFound_IEnumerable_d_AssetStoreUpdateInfo_p_.SetBelong(this.GetValue());
				}
				return r_MOnUpdatesFound_IEnumerable_d_AssetStoreUpdateInfo_p_;
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
					r_MOnProductInfoChanged_AssetStoreProductInfo.SetBelong(this.GetValue());
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
					r_MOnPurchaseInfosChanged_IEnumerable_d_AssetStorePurchaseInfo_p_.SetBelong(this.GetValue());
				}
				return r_MOnPurchaseInfosChanged_IEnumerable_d_AssetStorePurchaseInfo_p_;
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
					r_MOnFetchStatusChanged_FetchStatus.SetBelong(this.GetValue());
				}
				return r_MOnFetchStatusChanged_FetchStatus;
			}
		}

		/// <summary>
		/// Boolean <OnLocalInfosChanged>b__10_2(System.String)
		/// </summary>
		protected RMethod r_M__0__OnLocalInfosChanged__1__b__10_2_String;
		public virtual RMethod RM__0__OnLocalInfosChanged__1__b__10_2_String
		{
			get
			{
				if(r_M__0__OnLocalInfosChanged__1__b__10_2_String == null)
				{
					r_M__0__OnLocalInfosChanged__1__b__10_2_String = new(this, "<OnLocalInfosChanged>b__10_2", 0, typeof(System.String));
					r_M__0__OnLocalInfosChanged__1__b__10_2_String.SetBelong(this.GetValue());
				}
				return r_M__0__OnLocalInfosChanged__1__b__10_2_String;
			}
		}

		/// <summary>
		/// Boolean <OnUpdatesFound>b__11_1(System.String)
		/// </summary>
		protected RMethod r_M__0__OnUpdatesFound__1__b__11_1_String;
		public virtual RMethod RM__0__OnUpdatesFound__1__b__11_1_String
		{
			get
			{
				if(r_M__0__OnUpdatesFound__1__b__11_1_String == null)
				{
					r_M__0__OnUpdatesFound__1__b__11_1_String = new(this, "<OnUpdatesFound>b__11_1", 0, typeof(System.String));
					r_M__0__OnUpdatesFound__1__b__11_1_String.SetBelong(this.GetValue());
				}
				return r_M__0__OnUpdatesFound__1__b__11_1_String;
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


        public RAssetStorePackageFactory() : base("UnityEditor.PackageManager.UI.Internal.AssetStoreClient+AssetStorePackageFactory")
        {
        }

        public RAssetStorePackageFactory(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.AssetStoreClient+AssetStorePackageFactory")
		{
            SetInstance(instance);
		}

        public RAssetStorePackageFactory(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssetStorePackageFactory(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void ResolveDependencies(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreCache @assetStoreCache, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreClient @assetStoreClient, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUtils @assetStoreUtils, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchStatusTracker @fetchStatusTracker, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmCache @upmCache, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOProxy @ioProxy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assetStoreCache.Value, @assetStoreClient.Value, @assetStoreUtils.Value, @fetchStatusTracker.Value, @upmCache.Value, @ioProxy.Value};
            var ___result = RMResolveDependencies_AssetStoreCache_AssetStoreClient_AssetStoreUtils_FetchStatusTracker_UpmCache_IOProxy.Invoke(___genericsType, ___parameters);

            
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


        public virtual void GeneratePackagesAndTriggerChangeEvent(System.Collections.Generic.IEnumerable<System.String> @productIds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productIds};
            var ___result = RMGeneratePackagesAndTriggerChangeEvent_IEnumerable_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLocalInfosChanged(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreLocalInfo> @addedOrUpdated, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreLocalInfo> @removed)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@addedOrUpdated.Value, @removed.Value};
            var ___result = RMOnLocalInfosChanged_IEnumerable_d_AssetStoreLocalInfo_p__IEnumerable_d_AssetStoreLocalInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnUpdatesFound(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUpdateInfo> @updateInfos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@updateInfos.Value};
            var ___result = RMOnUpdatesFound_IEnumerable_d_AssetStoreUpdateInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnProductInfoChanged(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreProductInfo @productInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productInfo.Value};
            var ___result = RMOnProductInfoChanged_AssetStoreProductInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPurchaseInfosChanged(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchaseInfo> @purchaseInfos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@purchaseInfos.Value};
            var ___result = RMOnPurchaseInfosChanged_IEnumerable_d_AssetStorePurchaseInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnFetchStatusChanged(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchStatus @fetchStatus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fetchStatus.Value};
            var ___result = RMOnFetchStatusChanged_FetchStatus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__OnLocalInfosChanged__1__b__10_2(System.String @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RM__0__OnLocalInfosChanged__1__b__10_2_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean __0__OnUpdatesFound__1__b__11_1(System.String @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RM__0__OnUpdatesFound__1__b__11_1_String.Invoke(___genericsType, ___parameters);

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
}