
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI
	/// </summary>
    public partial class RAssetStoreRestAPI : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI");
            }
        }

        public RAssetStoreRestAPI() : base("UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI")
        {
        }

        public RAssetStoreRestAPI(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI")
		{
            SetInstance(instance);
		}

        public RAssetStoreRestAPI(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssetStoreRestAPI(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String k_PurchasesUri
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_PurchasesUri;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_PurchasesUri
		{
			get
			{
				if(r_Fk_PurchasesUri == null)
				{
					r_Fk_PurchasesUri = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI"), "k_PurchasesUri");
				}
				return r_Fk_PurchasesUri;
			}
		}

		/// <summary>
		/// System.String k_TaggingsUri
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_TaggingsUri;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_TaggingsUri
		{
			get
			{
				if(r_Fk_TaggingsUri == null)
				{
					r_Fk_TaggingsUri = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI"), "k_TaggingsUri");
				}
				return r_Fk_TaggingsUri;
			}
		}

		/// <summary>
		/// System.String k_ProductInfoUri
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_ProductInfoUri;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_ProductInfoUri
		{
			get
			{
				if(r_Fk_ProductInfoUri == null)
				{
					r_Fk_ProductInfoUri = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI"), "k_ProductInfoUri");
				}
				return r_Fk_ProductInfoUri;
			}
		}

		/// <summary>
		/// System.String k_UpdateInfoUri
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_UpdateInfoUri;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_UpdateInfoUri
		{
			get
			{
				if(r_Fk_UpdateInfoUri == null)
				{
					r_Fk_UpdateInfoUri = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI"), "k_UpdateInfoUri");
				}
				return r_Fk_UpdateInfoUri;
			}
		}

		/// <summary>
		/// System.String k_DownloadInfoUri
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_DownloadInfoUri;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_DownloadInfoUri
		{
			get
			{
				if(r_Fk_DownloadInfoUri == null)
				{
					r_Fk_DownloadInfoUri = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI"), "k_DownloadInfoUri");
				}
				return r_Fk_DownloadInfoUri;
			}
		}

		/// <summary>
		/// System.String k_TermsCheckUri
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_TermsCheckUri;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_TermsCheckUri
		{
			get
			{
				if(r_Fk_TermsCheckUri == null)
				{
					r_Fk_TermsCheckUri = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI"), "k_TermsCheckUri");
				}
				return r_Fk_TermsCheckUri;
			}
		}

		/// <summary>
		/// System.String k_TermsAcceptUri
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_TermsAcceptUri;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_TermsAcceptUri
		{
			get
			{
				if(r_Fk_TermsAcceptUri == null)
				{
					r_Fk_TermsAcceptUri = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI"), "k_TermsAcceptUri");
				}
				return r_Fk_TermsAcceptUri;
			}
		}

		/// <summary>
		/// System.Int32 k_MaxRetries
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_MaxRetries;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_MaxRetries
		{
			get
			{
				if(r_Fk_MaxRetries == null)
				{
					r_Fk_MaxRetries = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI"), "k_MaxRetries");
				}
				return r_Fk_MaxRetries;
			}
		}

		/// <summary>
		/// System.Int32 k_ClientErrorResponseCode
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_ClientErrorResponseCode;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_ClientErrorResponseCode
		{
			get
			{
				if(r_Fk_ClientErrorResponseCode == null)
				{
					r_Fk_ClientErrorResponseCode = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI"), "k_ClientErrorResponseCode");
				}
				return r_Fk_ClientErrorResponseCode;
			}
		}

		/// <summary>
		/// System.Int32 k_ServerErrorResponseCode
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_ServerErrorResponseCode;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_ServerErrorResponseCode
		{
			get
			{
				if(r_Fk_ServerErrorResponseCode == null)
				{
					r_Fk_ServerErrorResponseCode = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI"), "k_ServerErrorResponseCode");
				}
				return r_Fk_ServerErrorResponseCode;
			}
		}

		/// <summary>
		/// System.String k_ErrorMessage
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_ErrorMessage;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_ErrorMessage
		{
			get
			{
				if(r_Fk_ErrorMessage == null)
				{
					r_Fk_ErrorMessage = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI"), "k_ErrorMessage");
				}
				return r_Fk_ErrorMessage;
			}
		}

		/// <summary>
		/// System.Int32 k_GeneralServerError
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_GeneralServerError;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_GeneralServerError
		{
			get
			{
				if(r_Fk_GeneralServerError == null)
				{
					r_Fk_GeneralServerError = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI"), "k_GeneralServerError");
				}
				return r_Fk_GeneralServerError;
			}
		}

		/// <summary>
		/// System.Int32 k_GeneralClientError
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_GeneralClientError;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_GeneralClientError
		{
			get
			{
				if(r_Fk_GeneralClientError == null)
				{
					r_Fk_GeneralClientError = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI"), "k_GeneralClientError");
				}
				return r_Fk_GeneralClientError;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,System.String] k_KnownErrors
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RSystem.RString> r_Fk_KnownErrors;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RSystem.RString> RFk_KnownErrors
		{
			get
			{
				if(r_Fk_KnownErrors == null)
				{
					r_Fk_KnownErrors = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI"), "k_KnownErrors");
				}
				return r_Fk_KnownErrors;
			}
		}

		/// <summary>
		/// System.String[] k_Categories
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fk_Categories;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFk_Categories
		{
			get
			{
				if(r_Fk_Categories == null)
				{
					r_Fk_Categories = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI"), "k_Categories");
				}
				return r_Fk_Categories;
			}
		}

		/// <summary>
		/// System.String m_Host
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Host;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Host
		{
			get
			{
				if(r_Fm_Host == null)
				{
					r_Fm_Host = new(this, "m_Host");
				}
				return r_Fm_Host;
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
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth m_AssetStoreOAuth
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreOAuth r_Fm_AssetStoreOAuth;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreOAuth RFm_AssetStoreOAuth
		{
			get
			{
				if(r_Fm_AssetStoreOAuth == null)
				{
					r_Fm_AssetStoreOAuth = new(this, "m_AssetStoreOAuth");
				}
				return r_Fm_AssetStoreOAuth;
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
				}
				return r_Fm_HttpClientFactory;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI instance
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreRestAPI r_Pinstance;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreRestAPI RPinstance
		{
			get
			{
				if(r_Pinstance == null)
				{
					r_Pinstance = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreRestAPI"), "instance", -1);
				}
				return r_Pinstance;
			}
		}

		/// <summary>
		/// System.String host
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Phost;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPhost
		{
			get
			{
				if(r_Phost == null)
				{
					r_Phost = new(this, "host", -1);
				}
				return r_Phost;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.UnityConnectProxy, UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth, UnityEditor.PackageManager.UI.Internal.AssetStoreCache, UnityEditor.PackageManager.UI.Internal.HttpClientFactory)
		/// </summary>
		protected RMethod r_MResolveDependencies_UnityConnectProxy_AssetStoreOAuth_AssetStoreCache_HttpClientFactory;
		public virtual RMethod RMResolveDependencies_UnityConnectProxy_AssetStoreOAuth_AssetStoreCache_HttpClientFactory
		{
			get
			{
				if(r_MResolveDependencies_UnityConnectProxy_AssetStoreOAuth_AssetStoreCache_HttpClientFactory == null)
				{
					r_MResolveDependencies_UnityConnectProxy_AssetStoreOAuth_AssetStoreCache_HttpClientFactory = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UnityConnectProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreCache"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.HttpClientFactory"));
				}
				return r_MResolveDependencies_UnityConnectProxy_AssetStoreOAuth_AssetStoreCache_HttpClientFactory;
			}
		}

		/// <summary>
		/// Void GetPurchases(System.String, System.Action`1[System.Collections.Generic.Dictionary`2[System.String,System.Object]], System.Action`1[UnityEditor.PackageManager.UI.Internal.UIError])
		/// </summary>
		protected RMethod r_MGetPurchases_String_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_;
		public virtual RMethod RMGetPurchases_String_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_
		{
			get
			{
				if(r_MGetPurchases_String_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_ == null)
				{
					r_MGetPurchases_String_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_ = new(this, "GetPurchases", 0, typeof(System.String), typeof(System.Action<>).MakeGenericType(typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String), typeof(System.Object))), typeof(System.Action<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError")));
				}
				return r_MGetPurchases_String_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_;
			}
		}

		/// <summary>
		/// Void AbortGetPurchases(System.String)
		/// </summary>
		protected RMethod r_MAbortGetPurchases_String;
		public virtual RMethod RMAbortGetPurchases_String
		{
			get
			{
				if(r_MAbortGetPurchases_String == null)
				{
					r_MAbortGetPurchases_String = new(this, "AbortGetPurchases", 0, typeof(System.String));
				}
				return r_MAbortGetPurchases_String;
			}
		}

		/// <summary>
		/// Void GetCategories(System.Action`1[System.Collections.Generic.Dictionary`2[System.String,System.Object]], System.Action`1[UnityEditor.PackageManager.UI.Internal.UIError])
		/// </summary>
		protected RMethod r_MGetCategories_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_;
		public virtual RMethod RMGetCategories_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_
		{
			get
			{
				if(r_MGetCategories_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_ == null)
				{
					r_MGetCategories_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_ = new(this, "GetCategories", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String), typeof(System.Object))), typeof(System.Action<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError")));
				}
				return r_MGetCategories_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_;
			}
		}

		/// <summary>
		/// Void GetTaggings(System.Action`1[System.Collections.Generic.Dictionary`2[System.String,System.Object]], System.Action`1[UnityEditor.PackageManager.UI.Internal.UIError])
		/// </summary>
		protected RMethod r_MGetTaggings_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_;
		public virtual RMethod RMGetTaggings_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_
		{
			get
			{
				if(r_MGetTaggings_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_ == null)
				{
					r_MGetTaggings_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_ = new(this, "GetTaggings", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String), typeof(System.Object))), typeof(System.Action<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError")));
				}
				return r_MGetTaggings_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_;
			}
		}

		/// <summary>
		/// Void GetProductDetail(Int64, System.Action`1[System.Collections.Generic.Dictionary`2[System.String,System.Object]])
		/// </summary>
		protected RMethod r_MGetProductDetail_Int64_Action_d_Dictionary_d_String_Object_p__p_;
		public virtual RMethod RMGetProductDetail_Int64_Action_d_Dictionary_d_String_Object_p__p_
		{
			get
			{
				if(r_MGetProductDetail_Int64_Action_d_Dictionary_d_String_Object_p__p_ == null)
				{
					r_MGetProductDetail_Int64_Action_d_Dictionary_d_String_Object_p__p_ = new(this, "GetProductDetail", 0, typeof(System.Int64), typeof(System.Action<>).MakeGenericType(typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String), typeof(System.Object))));
				}
				return r_MGetProductDetail_Int64_Action_d_Dictionary_d_String_Object_p__p_;
			}
		}

		/// <summary>
		/// Void GetDownloadDetail(Int64, System.Action`1[UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadInfo])
		/// </summary>
		protected RMethod r_MGetDownloadDetail_Int64_Action_d_AssetStoreDownloadInfo_p_;
		public virtual RMethod RMGetDownloadDetail_Int64_Action_d_AssetStoreDownloadInfo_p_
		{
			get
			{
				if(r_MGetDownloadDetail_Int64_Action_d_AssetStoreDownloadInfo_p_ == null)
				{
					r_MGetDownloadDetail_Int64_Action_d_AssetStoreDownloadInfo_p_ = new(this, "GetDownloadDetail", 0, typeof(System.Int64), typeof(System.Action<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadInfo")));
				}
				return r_MGetDownloadDetail_Int64_Action_d_AssetStoreDownloadInfo_p_;
			}
		}

		/// <summary>
		/// Void GetProductUpdateDetail(System.Collections.Generic.IEnumerable`1[System.String], System.Action`1[System.Collections.Generic.Dictionary`2[System.String,System.Object]])
		/// </summary>
		protected RMethod r_MGetProductUpdateDetail_IEnumerable_d_String_p__Action_d_Dictionary_d_String_Object_p__p_;
		public virtual RMethod RMGetProductUpdateDetail_IEnumerable_d_String_p__Action_d_Dictionary_d_String_Object_p__p_
		{
			get
			{
				if(r_MGetProductUpdateDetail_IEnumerable_d_String_p__Action_d_Dictionary_d_String_Object_p__p_ == null)
				{
					r_MGetProductUpdateDetail_IEnumerable_d_String_p__Action_d_Dictionary_d_String_Object_p__p_ = new(this, "GetProductUpdateDetail", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.String)), typeof(System.Action<>).MakeGenericType(typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String), typeof(System.Object))));
				}
				return r_MGetProductUpdateDetail_IEnumerable_d_String_p__Action_d_Dictionary_d_String_Object_p__p_;
			}
		}

		/// <summary>
		/// Void CheckTermsAndConditions(System.Action`1[System.Collections.Generic.Dictionary`2[System.String,System.Object]], System.Action`1[UnityEditor.PackageManager.UI.Internal.UIError])
		/// </summary>
		protected RMethod r_MCheckTermsAndConditions_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_;
		public virtual RMethod RMCheckTermsAndConditions_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_
		{
			get
			{
				if(r_MCheckTermsAndConditions_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_ == null)
				{
					r_MCheckTermsAndConditions_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_ = new(this, "CheckTermsAndConditions", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String), typeof(System.Object))), typeof(System.Action<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError")));
				}
				return r_MCheckTermsAndConditions_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_;
			}
		}

		/// <summary>
		/// Void HandleHttpRequest(UnityEditor.IAsyncHTTPClient, System.Action`1[System.Collections.Generic.Dictionary`2[System.String,System.Object]], System.Action`1[UnityEditor.PackageManager.UI.Internal.UIError])
		/// </summary>
		protected RMethod r_MHandleHttpRequest_IAsyncHTTPClient_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_;
		public virtual RMethod RMHandleHttpRequest_IAsyncHTTPClient_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_
		{
			get
			{
				if(r_MHandleHttpRequest_IAsyncHTTPClient_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_ == null)
				{
					r_MHandleHttpRequest_IAsyncHTTPClient_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_ = new(this, "HandleHttpRequest", 0,  ReflectionUtils.GetType("UnityEditor.IAsyncHTTPClient"), typeof(System.Action<>).MakeGenericType(typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String), typeof(System.Object))), typeof(System.Action<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError")));
				}
				return r_MHandleHttpRequest_IAsyncHTTPClient_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_;
			}
		}

		/// <summary>
		/// Void HandleHttpRequest(System.Func`1[UnityEditor.IAsyncHTTPClient], System.Action`1[System.Collections.Generic.Dictionary`2[System.String,System.Object]], System.Action`1[UnityEditor.PackageManager.UI.Internal.UIError])
		/// </summary>
		protected RMethod r_MHandleHttpRequest_Func_d_IAsyncHTTPClient_p__Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_;
		public virtual RMethod RMHandleHttpRequest_Func_d_IAsyncHTTPClient_p__Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_
		{
			get
			{
				if(r_MHandleHttpRequest_Func_d_IAsyncHTTPClient_p__Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_ == null)
				{
					r_MHandleHttpRequest_Func_d_IAsyncHTTPClient_p__Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_ = new(this, "HandleHttpRequest", 0, typeof(System.Func<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.IAsyncHTTPClient")), typeof(System.Action<>).MakeGenericType(typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String), typeof(System.Object))), typeof(System.Action<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError")));
				}
				return r_MHandleHttpRequest_Func_d_IAsyncHTTPClient_p__Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_;
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


        public virtual void ResolveDependencies(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityConnectProxy @unityConnect, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreOAuth @assetStoreOAuth, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreCache @assetStoreCache, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RHttpClientFactory @httpClientFactory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unityConnect.Value, @assetStoreOAuth.Value, @assetStoreCache.Value, @httpClientFactory.Value};
            var ___result = RMResolveDependencies_UnityConnectProxy_AssetStoreOAuth_AssetStoreCache_HttpClientFactory.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetPurchases(System.String @query, System.Action<System.Collections.Generic.Dictionary<System.String, System.Object>> @doneCallbackAction, Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> @errorCallbackAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@query, @doneCallbackAction, @errorCallbackAction.Value};
            var ___result = RMGetPurchases_String_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AbortGetPurchases(System.String @query)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@query};
            var ___result = RMAbortGetPurchases_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetCategories(System.Action<System.Collections.Generic.Dictionary<System.String, System.Object>> @doneCallbackAction, Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> @errorCallbackAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@doneCallbackAction, @errorCallbackAction.Value};
            var ___result = RMGetCategories_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTaggings(System.Action<System.Collections.Generic.Dictionary<System.String, System.Object>> @doneCallbackAction, Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> @errorCallbackAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@doneCallbackAction, @errorCallbackAction.Value};
            var ___result = RMGetTaggings_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetProductDetail(System.Int64 @productID, System.Action<System.Collections.Generic.Dictionary<System.String, System.Object>> @doneCallbackAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productID, @doneCallbackAction};
            var ___result = RMGetProductDetail_Int64_Action_d_Dictionary_d_String_Object_p__p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetDownloadDetail(System.Int64 @productID, Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreDownloadInfo> @doneCallbackAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productID, @doneCallbackAction.Value};
            var ___result = RMGetDownloadDetail_Int64_Action_d_AssetStoreDownloadInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetProductUpdateDetail(System.Collections.Generic.IEnumerable<System.String> @productIds, System.Action<System.Collections.Generic.Dictionary<System.String, System.Object>> @doneCallbackAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productIds, @doneCallbackAction};
            var ___result = RMGetProductUpdateDetail_IEnumerable_d_String_p__Action_d_Dictionary_d_String_Object_p__p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckTermsAndConditions(System.Action<System.Collections.Generic.Dictionary<System.String, System.Object>> @doneCallbackAction, Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> @errorCallbackAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@doneCallbackAction, @errorCallbackAction.Value};
            var ___result = RMCheckTermsAndConditions_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleHttpRequest(Hvak.Editor.Refleaction.RUnityEditor.RIAsyncHTTPClient @httpRequest, System.Action<System.Collections.Generic.Dictionary<System.String, System.Object>> @doneCallbackAction, Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> @errorCallbackAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@httpRequest.Value, @doneCallbackAction, @errorCallbackAction.Value};
            var ___result = RMHandleHttpRequest_IAsyncHTTPClient_Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleHttpRequest(Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEditor.RIAsyncHTTPClient> @httpRequestCreate, System.Action<System.Collections.Generic.Dictionary<System.String, System.Object>> @doneCallbackAction, Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> @errorCallbackAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@httpRequestCreate.Value, @doneCallbackAction, @errorCallbackAction.Value};
            var ___result = RMHandleHttpRequest_Func_d_IAsyncHTTPClient_p__Action_d_Dictionary_d_String_Object_p__p__Action_d_UIError_p_.Invoke(___genericsType, ___parameters);

            
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
