
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.AssetStoreCache
	/// </summary>
    public partial class RAssetStoreCache : RMember //
    {

		/// <summary>
		/// System.Action`2[System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo],System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo]] onLocalInfosChanged
		/// </summary>
		protected REvent r_EonLocalInfosChanged;
		public virtual REvent REonLocalInfosChanged
		{
			get
			{
				if(r_EonLocalInfosChanged == null)
				{
					r_EonLocalInfosChanged = new(this, "onLocalInfosChanged");
					r_EonLocalInfosChanged.SetBelong(this.GetValue());
				}
				return r_EonLocalInfosChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.AssetStoreProductInfo] onProductInfoChanged
		/// </summary>
		protected REvent r_EonProductInfoChanged;
		public virtual REvent REonProductInfoChanged
		{
			get
			{
				if(r_EonProductInfoChanged == null)
				{
					r_EonProductInfoChanged = new(this, "onProductInfoChanged");
					r_EonProductInfoChanged.SetBelong(this.GetValue());
				}
				return r_EonProductInfoChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.AssetStorePurchaseInfo]] onPurchaseInfosChanged
		/// </summary>
		protected REvent r_EonPurchaseInfosChanged;
		public virtual REvent REonPurchaseInfosChanged
		{
			get
			{
				if(r_EonPurchaseInfosChanged == null)
				{
					r_EonPurchaseInfosChanged = new(this, "onPurchaseInfosChanged");
					r_EonPurchaseInfosChanged.SetBelong(this.GetValue());
				}
				return r_EonPurchaseInfosChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.AssetStoreUpdateInfo]] onUpdatesFound
		/// </summary>
		protected REvent r_EonUpdatesFound;
		public virtual REvent REonUpdatesFound
		{
			get
			{
				if(r_EonUpdatesFound == null)
				{
					r_EonUpdatesFound = new(this, "onUpdatesFound");
					r_EonUpdatesFound.SetBelong(this.GetValue());
				}
				return r_EonUpdatesFound;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.String] m_ETags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString> r_Fm_ETags;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString> RFm_ETags
		{
			get
			{
				if(r_Fm_ETags == null)
				{
					r_Fm_ETags = new(this, "m_ETags");
					r_Fm_ETags.SetBelong(this.GetValue());
				}
				return r_Fm_ETags;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int64] m_Categories
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RInt64> r_Fm_Categories;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RInt64> RFm_Categories
		{
			get
			{
				if(r_Fm_Categories == null)
				{
					r_Fm_Categories = new(this, "m_Categories");
					r_Fm_Categories.SetBelong(this.GetValue());
				}
				return r_Fm_Categories;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEditor.PackageManager.UI.Internal.AssetStorePurchaseInfo] m_PurchaseInfos
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchaseInfo> r_Fm_PurchaseInfos;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchaseInfo> RFm_PurchaseInfos
		{
			get
			{
				if(r_Fm_PurchaseInfos == null)
				{
					r_Fm_PurchaseInfos = new(this, "m_PurchaseInfos");
					r_Fm_PurchaseInfos.SetBelong(this.GetValue());
				}
				return r_Fm_PurchaseInfos;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEditor.PackageManager.UI.Internal.AssetStoreProductInfo] m_ProductInfos
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreProductInfo> r_Fm_ProductInfos;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreProductInfo> RFm_ProductInfos
		{
			get
			{
				if(r_Fm_ProductInfos == null)
				{
					r_Fm_ProductInfos = new(this, "m_ProductInfos");
					r_Fm_ProductInfos.SetBelong(this.GetValue());
				}
				return r_Fm_ProductInfos;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo] m_LocalInfos
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreLocalInfo> r_Fm_LocalInfos;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreLocalInfo> RFm_LocalInfos
		{
			get
			{
				if(r_Fm_LocalInfos == null)
				{
					r_Fm_LocalInfos = new(this, "m_LocalInfos");
					r_Fm_LocalInfos.SetBelong(this.GetValue());
				}
				return r_Fm_LocalInfos;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEditor.PackageManager.UI.Internal.AssetStoreUpdateInfo] m_UpdateInfos
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUpdateInfo> r_Fm_UpdateInfos;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUpdateInfo> RFm_UpdateInfos
		{
			get
			{
				if(r_Fm_UpdateInfos == null)
				{
					r_Fm_UpdateInfos = new(this, "m_UpdateInfos");
					r_Fm_UpdateInfos.SetBelong(this.GetValue());
				}
				return r_Fm_UpdateInfos;
			}
		}

		/// <summary>
		/// System.String[] m_SerializedKeys
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_SerializedKeys;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFm_SerializedKeys
		{
			get
			{
				if(r_Fm_SerializedKeys == null)
				{
					r_Fm_SerializedKeys = new(this, "m_SerializedKeys");
					r_Fm_SerializedKeys.SetBelong(this.GetValue());
				}
				return r_Fm_SerializedKeys;
			}
		}

		/// <summary>
		/// System.String[] m_SerializedETags
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_SerializedETags;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFm_SerializedETags
		{
			get
			{
				if(r_Fm_SerializedETags == null)
				{
					r_Fm_SerializedETags = new(this, "m_SerializedETags");
					r_Fm_SerializedETags.SetBelong(this.GetValue());
				}
				return r_Fm_SerializedETags;
			}
		}

		/// <summary>
		/// System.String[] m_SerializedCategories
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_SerializedCategories;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFm_SerializedCategories
		{
			get
			{
				if(r_Fm_SerializedCategories == null)
				{
					r_Fm_SerializedCategories = new(this, "m_SerializedCategories");
					r_Fm_SerializedCategories.SetBelong(this.GetValue());
				}
				return r_Fm_SerializedCategories;
			}
		}

		/// <summary>
		/// System.Int64[] m_SerializedCategoryCounts
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt64> r_Fm_SerializedCategoryCounts;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt64> RFm_SerializedCategoryCounts
		{
			get
			{
				if(r_Fm_SerializedCategoryCounts == null)
				{
					r_Fm_SerializedCategoryCounts = new(this, "m_SerializedCategoryCounts");
					r_Fm_SerializedCategoryCounts.SetBelong(this.GetValue());
				}
				return r_Fm_SerializedCategoryCounts;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStorePurchaseInfo[] m_SerializedPurchaseInfos
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchaseInfo> r_Fm_SerializedPurchaseInfos;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchaseInfo> RFm_SerializedPurchaseInfos
		{
			get
			{
				if(r_Fm_SerializedPurchaseInfos == null)
				{
					r_Fm_SerializedPurchaseInfos = new(this, "m_SerializedPurchaseInfos");
					r_Fm_SerializedPurchaseInfos.SetBelong(this.GetValue());
				}
				return r_Fm_SerializedPurchaseInfos;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreProductInfo[] m_SerializedProductInfos
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreProductInfo> r_Fm_SerializedProductInfos;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreProductInfo> RFm_SerializedProductInfos
		{
			get
			{
				if(r_Fm_SerializedProductInfos == null)
				{
					r_Fm_SerializedProductInfos = new(this, "m_SerializedProductInfos");
					r_Fm_SerializedProductInfos.SetBelong(this.GetValue());
				}
				return r_Fm_SerializedProductInfos;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo[] m_SerializedLocalInfos
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreLocalInfo> r_Fm_SerializedLocalInfos;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreLocalInfo> RFm_SerializedLocalInfos
		{
			get
			{
				if(r_Fm_SerializedLocalInfos == null)
				{
					r_Fm_SerializedLocalInfos = new(this, "m_SerializedLocalInfos");
					r_Fm_SerializedLocalInfos.SetBelong(this.GetValue());
				}
				return r_Fm_SerializedLocalInfos;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreUpdateInfo[] m_SerializedUpdateInfos
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUpdateInfo> r_Fm_SerializedUpdateInfos;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUpdateInfo> RFm_SerializedUpdateInfos
		{
			get
			{
				if(r_Fm_SerializedUpdateInfos == null)
				{
					r_Fm_SerializedUpdateInfos = new(this, "m_SerializedUpdateInfos");
					r_Fm_SerializedUpdateInfos.SetBelong(this.GetValue());
				}
				return r_Fm_SerializedUpdateInfos;
			}
		}

		/// <summary>
		/// System.Action`2[System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo],System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo]] onLocalInfosChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreLocalInfo>, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreLocalInfo>> r_FonLocalInfosChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreLocalInfo>, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreLocalInfo>> RFonLocalInfosChanged
		{
			get
			{
				if(r_FonLocalInfosChanged == null)
				{
					r_FonLocalInfosChanged = new(this, "onLocalInfosChanged");
					r_FonLocalInfosChanged.SetBelong(this.GetValue());
				}
				return r_FonLocalInfosChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.AssetStoreProductInfo] onProductInfoChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreProductInfo> r_FonProductInfoChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreProductInfo> RFonProductInfoChanged
		{
			get
			{
				if(r_FonProductInfoChanged == null)
				{
					r_FonProductInfoChanged = new(this, "onProductInfoChanged");
					r_FonProductInfoChanged.SetBelong(this.GetValue());
				}
				return r_FonProductInfoChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.AssetStorePurchaseInfo]] onPurchaseInfosChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchaseInfo>> r_FonPurchaseInfosChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchaseInfo>> RFonPurchaseInfosChanged
		{
			get
			{
				if(r_FonPurchaseInfosChanged == null)
				{
					r_FonPurchaseInfosChanged = new(this, "onPurchaseInfosChanged");
					r_FonPurchaseInfosChanged.SetBelong(this.GetValue());
				}
				return r_FonPurchaseInfosChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.AssetStoreUpdateInfo]] onUpdatesFound
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUpdateInfo>> r_FonUpdatesFound;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUpdateInfo>> RFonUpdatesFound
		{
			get
			{
				if(r_FonUpdatesFound == null)
				{
					r_FonUpdatesFound = new(this, "onUpdatesFound");
					r_FonUpdatesFound.SetBelong(this.GetValue());
				}
				return r_FonUpdatesFound;
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
		/// UnityEditor.PackageManager.UI.Internal.HttpClientFactory m_HttpClientFactory
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RHttpClientFactory r_Fm_HttpClientFactory;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RHttpClientFactory RFm_HttpClientFactory
		{
			get
			{
				if(r_Fm_HttpClientFactory == null)
				{
					r_Fm_HttpClientFactory = new(this, "m_HttpClientFactory");
					r_Fm_HttpClientFactory.SetBelong(this.GetValue());
				}
				return r_Fm_HttpClientFactory;
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
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo] localInfos
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreLocalInfo> r_PlocalInfos;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreLocalInfo> RPlocalInfos
		{
			get
			{
				if(r_PlocalInfos == null)
				{
					r_PlocalInfos = new(this, "localInfos", -1);
					r_PlocalInfos.SetBelong(this.GetValue());
				}
				return r_PlocalInfos;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.ApplicationProxy, UnityEditor.PackageManager.UI.Internal.AssetStoreUtils, UnityEditor.PackageManager.UI.Internal.HttpClientFactory, UnityEditor.PackageManager.UI.Internal.IOProxy)
		/// </summary>
		protected RMethod r_MResolveDependencies_ApplicationProxy_AssetStoreUtils_HttpClientFactory_IOProxy;
		public virtual RMethod RMResolveDependencies_ApplicationProxy_AssetStoreUtils_HttpClientFactory_IOProxy
		{
			get
			{
				if(r_MResolveDependencies_ApplicationProxy_AssetStoreUtils_HttpClientFactory_IOProxy == null)
				{
					r_MResolveDependencies_ApplicationProxy_AssetStoreUtils_HttpClientFactory_IOProxy = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.ApplicationProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreUtils"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.HttpClientFactory"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOProxy"));
					r_MResolveDependencies_ApplicationProxy_AssetStoreUtils_HttpClientFactory_IOProxy.SetBelong(this.GetValue());
				}
				return r_MResolveDependencies_ApplicationProxy_AssetStoreUtils_HttpClientFactory_IOProxy;
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
		/// System.String GetLastETag(System.String)
		/// </summary>
		protected RMethod r_MGetLastETag_String;
		public virtual RMethod RMGetLastETag_String
		{
			get
			{
				if(r_MGetLastETag_String == null)
				{
					r_MGetLastETag_String = new(this, "GetLastETag", 0, typeof(System.String));
					r_MGetLastETag_String.SetBelong(this.GetValue());
				}
				return r_MGetLastETag_String;
			}
		}

		/// <summary>
		/// Void SetLastETag(System.String, System.String)
		/// </summary>
		protected RMethod r_MSetLastETag_String_String;
		public virtual RMethod RMSetLastETag_String_String
		{
			get
			{
				if(r_MSetLastETag_String_String == null)
				{
					r_MSetLastETag_String_String = new(this, "SetLastETag", 0, typeof(System.String), typeof(System.String));
					r_MSetLastETag_String_String.SetBelong(this.GetValue());
				}
				return r_MSetLastETag_String_String;
			}
		}

		/// <summary>
		/// Void SetCategory(System.String, Int64)
		/// </summary>
		protected RMethod r_MSetCategory_String_Int64;
		public virtual RMethod RMSetCategory_String_Int64
		{
			get
			{
				if(r_MSetCategory_String_Int64 == null)
				{
					r_MSetCategory_String_Int64 = new(this, "SetCategory", 0, typeof(System.String), typeof(System.Int64));
					r_MSetCategory_String_Int64.SetBelong(this.GetValue());
				}
				return r_MSetCategory_String_Int64;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D LoadImage(Int64, System.String)
		/// </summary>
		protected RMethod r_MLoadImage_Int64_String;
		public virtual RMethod RMLoadImage_Int64_String
		{
			get
			{
				if(r_MLoadImage_Int64_String == null)
				{
					r_MLoadImage_Int64_String = new(this, "LoadImage", 0, typeof(System.Int64), typeof(System.String));
					r_MLoadImage_Int64_String.SetBelong(this.GetValue());
				}
				return r_MLoadImage_Int64_String;
			}
		}

		/// <summary>
		/// Void SaveImage(Int64, System.String, UnityEngine.Texture2D)
		/// </summary>
		protected RMethod r_MSaveImage_Int64_String_Texture2D;
		public virtual RMethod RMSaveImage_Int64_String_Texture2D
		{
			get
			{
				if(r_MSaveImage_Int64_String_Texture2D == null)
				{
					r_MSaveImage_Int64_String_Texture2D = new(this, "SaveImage", 0, typeof(System.Int64), typeof(System.String), typeof(UnityEngine.Texture2D));
					r_MSaveImage_Int64_String_Texture2D.SetBelong(this.GetValue());
				}
				return r_MSaveImage_Int64_String_Texture2D;
			}
		}

		/// <summary>
		/// Void DownloadImageAsync(Int64, System.String, System.Action`2[System.Int64,UnityEngine.Texture2D])
		/// </summary>
		protected RMethod r_MDownloadImageAsync_Int64_String_Action_d_Int64_Texture2D_p_;
		public virtual RMethod RMDownloadImageAsync_Int64_String_Action_d_Int64_Texture2D_p_
		{
			get
			{
				if(r_MDownloadImageAsync_Int64_String_Action_d_Int64_Texture2D_p_ == null)
				{
					r_MDownloadImageAsync_Int64_String_Action_d_Int64_Texture2D_p_ = new(this, "DownloadImageAsync", 0, typeof(System.Int64), typeof(System.String), typeof(System.Action<, >).MakeGenericType(typeof(System.Int64), typeof(UnityEngine.Texture2D)));
					r_MDownloadImageAsync_Int64_String_Action_d_Int64_Texture2D_p_.SetBelong(this.GetValue());
				}
				return r_MDownloadImageAsync_Int64_String_Action_d_Int64_Texture2D_p_;
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
					r_MClearCache.SetBelong(this.GetValue());
				}
				return r_MClearCache;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStorePurchaseInfo GetPurchaseInfo(System.String)
		/// </summary>
		protected RMethod r_MGetPurchaseInfo_String;
		public virtual RMethod RMGetPurchaseInfo_String
		{
			get
			{
				if(r_MGetPurchaseInfo_String == null)
				{
					r_MGetPurchaseInfo_String = new(this, "GetPurchaseInfo", 0, typeof(System.String));
					r_MGetPurchaseInfo_String.SetBelong(this.GetValue());
				}
				return r_MGetPurchaseInfo_String;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreProductInfo GetProductInfo(System.String)
		/// </summary>
		protected RMethod r_MGetProductInfo_String;
		public virtual RMethod RMGetProductInfo_String
		{
			get
			{
				if(r_MGetProductInfo_String == null)
				{
					r_MGetProductInfo_String = new(this, "GetProductInfo", 0, typeof(System.String));
					r_MGetProductInfo_String.SetBelong(this.GetValue());
				}
				return r_MGetProductInfo_String;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo GetLocalInfo(System.String)
		/// </summary>
		protected RMethod r_MGetLocalInfo_String;
		public virtual RMethod RMGetLocalInfo_String
		{
			get
			{
				if(r_MGetLocalInfo_String == null)
				{
					r_MGetLocalInfo_String = new(this, "GetLocalInfo", 0, typeof(System.String));
					r_MGetLocalInfo_String.SetBelong(this.GetValue());
				}
				return r_MGetLocalInfo_String;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreUpdateInfo GetUpdateInfo(System.String)
		/// </summary>
		protected RMethod r_MGetUpdateInfo_String;
		public virtual RMethod RMGetUpdateInfo_String
		{
			get
			{
				if(r_MGetUpdateInfo_String == null)
				{
					r_MGetUpdateInfo_String = new(this, "GetUpdateInfo", 0, typeof(System.String));
					r_MGetUpdateInfo_String.SetBelong(this.GetValue());
				}
				return r_MGetUpdateInfo_String;
			}
		}

		/// <summary>
		/// Void SetPurchaseInfos(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.AssetStorePurchaseInfo])
		/// </summary>
		protected RMethod r_MSetPurchaseInfos_IEnumerable_d_AssetStorePurchaseInfo_p_;
		public virtual RMethod RMSetPurchaseInfos_IEnumerable_d_AssetStorePurchaseInfo_p_
		{
			get
			{
				if(r_MSetPurchaseInfos_IEnumerable_d_AssetStorePurchaseInfo_p_ == null)
				{
					r_MSetPurchaseInfos_IEnumerable_d_AssetStorePurchaseInfo_p_ = new(this, "SetPurchaseInfos", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStorePurchaseInfo")));
					r_MSetPurchaseInfos_IEnumerable_d_AssetStorePurchaseInfo_p_.SetBelong(this.GetValue());
				}
				return r_MSetPurchaseInfos_IEnumerable_d_AssetStorePurchaseInfo_p_;
			}
		}

		/// <summary>
		/// Void SetProductInfo(UnityEditor.PackageManager.UI.Internal.AssetStoreProductInfo)
		/// </summary>
		protected RMethod r_MSetProductInfo_AssetStoreProductInfo;
		public virtual RMethod RMSetProductInfo_AssetStoreProductInfo
		{
			get
			{
				if(r_MSetProductInfo_AssetStoreProductInfo == null)
				{
					r_MSetProductInfo_AssetStoreProductInfo = new(this, "SetProductInfo", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreProductInfo"));
					r_MSetProductInfo_AssetStoreProductInfo.SetBelong(this.GetValue());
				}
				return r_MSetProductInfo_AssetStoreProductInfo;
			}
		}

		/// <summary>
		/// Void SetLocalInfos(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo])
		/// </summary>
		protected RMethod r_MSetLocalInfos_IEnumerable_d_AssetStoreLocalInfo_p_;
		public virtual RMethod RMSetLocalInfos_IEnumerable_d_AssetStoreLocalInfo_p_
		{
			get
			{
				if(r_MSetLocalInfos_IEnumerable_d_AssetStoreLocalInfo_p_ == null)
				{
					r_MSetLocalInfos_IEnumerable_d_AssetStoreLocalInfo_p_ = new(this, "SetLocalInfos", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo")));
					r_MSetLocalInfos_IEnumerable_d_AssetStoreLocalInfo_p_.SetBelong(this.GetValue());
				}
				return r_MSetLocalInfos_IEnumerable_d_AssetStoreLocalInfo_p_;
			}
		}

		/// <summary>
		/// Void SetUpdateInfos(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.AssetStoreUpdateInfo])
		/// </summary>
		protected RMethod r_MSetUpdateInfos_IEnumerable_d_AssetStoreUpdateInfo_p_;
		public virtual RMethod RMSetUpdateInfos_IEnumerable_d_AssetStoreUpdateInfo_p_
		{
			get
			{
				if(r_MSetUpdateInfos_IEnumerable_d_AssetStoreUpdateInfo_p_ == null)
				{
					r_MSetUpdateInfos_IEnumerable_d_AssetStoreUpdateInfo_p_ = new(this, "SetUpdateInfos", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreUpdateInfo")));
					r_MSetUpdateInfos_IEnumerable_d_AssetStoreUpdateInfo_p_.SetBelong(this.GetValue());
				}
				return r_MSetUpdateInfos_IEnumerable_d_AssetStoreUpdateInfo_p_;
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


        public RAssetStoreCache() : base("UnityEditor.PackageManager.UI.Internal.AssetStoreCache")
        {
        }

        public RAssetStoreCache(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.AssetStoreCache")
		{
            SetInstance(instance);
		}

        public RAssetStoreCache(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssetStoreCache(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void ResolveDependencies(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RApplicationProxy @application, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUtils @assetStoreUtils, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RHttpClientFactory @httpClientFactory, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOProxy @systemIOProxy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@application.Value, @assetStoreUtils.Value, @httpClientFactory.Value, @systemIOProxy.Value};
            var ___result = RMResolveDependencies_ApplicationProxy_AssetStoreUtils_HttpClientFactory_IOProxy.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.String GetLastETag(System.String @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMGetLastETag_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void SetLastETag(System.String @key, System.String @etag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @etag};
            var ___result = RMSetLastETag_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCategory(System.String @category, System.Int64 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@category, @count};
            var ___result = RMSetCategory_String_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Texture2D LoadImage(System.Int64 @productId, System.String @url)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productId, @url};
            var ___result = RMLoadImage_Int64_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture2D)___result;
        }


        public virtual void SaveImage(System.Int64 @productId, System.String @url, UnityEngine.Texture2D @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productId, @url, @texture};
            var ___result = RMSaveImage_Int64_String_Texture2D.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DownloadImageAsync(System.Int64 @productID, System.String @url, System.Action<System.Int64, UnityEngine.Texture2D> @doneCallbackAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productID, @url, @doneCallbackAction};
            var ___result = RMDownloadImageAsync_Int64_String_Action_d_Int64_Texture2D_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearCache()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearCache.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchaseInfo GetPurchaseInfo(System.String @productIdString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productIdString};
            var ___result = RMGetPurchaseInfo_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchaseInfo(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreProductInfo GetProductInfo(System.String @productIdString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productIdString};
            var ___result = RMGetProductInfo_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreProductInfo(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreLocalInfo GetLocalInfo(System.String @productIdString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productIdString};
            var ___result = RMGetLocalInfo_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreLocalInfo(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUpdateInfo GetUpdateInfo(System.String @uploadIdString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uploadIdString};
            var ___result = RMGetUpdateInfo_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUpdateInfo(___result);
        }


        public virtual void SetPurchaseInfos(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchaseInfo> @purchaseInfos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@purchaseInfos.Value};
            var ___result = RMSetPurchaseInfos_IEnumerable_d_AssetStorePurchaseInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetProductInfo(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreProductInfo @productInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productInfo.Value};
            var ___result = RMSetProductInfo_AssetStoreProductInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetLocalInfos(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreLocalInfo> @localInfos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localInfos.Value};
            var ___result = RMSetLocalInfos_IEnumerable_d_AssetStoreLocalInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUpdateInfos(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUpdateInfo> @updateInfos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@updateInfos.Value};
            var ___result = RMSetUpdateInfos_IEnumerable_d_AssetStoreUpdateInfo_p_.Invoke(___genericsType, ___parameters);

            
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
