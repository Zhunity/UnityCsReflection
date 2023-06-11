
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth
	/// </summary>
    public partial class RAssetStoreOAuth : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth");
            }
        }

        public RAssetStoreOAuth() : base("UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth")
        {
        }

        public RAssetStoreOAuth(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth")
		{
            SetInstance(instance);
		}

        public RAssetStoreOAuth(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssetStoreOAuth(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Action`1[System.String] m_OnAuthCodeFetched
		/// </summary>
		protected REvent r_Em_OnAuthCodeFetched;
		public virtual REvent REm_OnAuthCodeFetched
		{
			get
			{
				if(r_Em_OnAuthCodeFetched == null)
				{
					r_Em_OnAuthCodeFetched = new(this, "m_OnAuthCodeFetched");
				}
				return r_Em_OnAuthCodeFetched;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+AccessToken] m_OnAccessTokenFetched
		/// </summary>
		protected REvent r_Em_OnAccessTokenFetched;
		public virtual REvent REm_OnAccessTokenFetched
		{
			get
			{
				if(r_Em_OnAccessTokenFetched == null)
				{
					r_Em_OnAccessTokenFetched = new(this, "m_OnAccessTokenFetched");
				}
				return r_Em_OnAccessTokenFetched;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+TokenInfo] m_OnTokenInfoFetched
		/// </summary>
		protected REvent r_Em_OnTokenInfoFetched;
		public virtual REvent REm_OnTokenInfoFetched
		{
			get
			{
				if(r_Em_OnTokenInfoFetched == null)
				{
					r_Em_OnTokenInfoFetched = new(this, "m_OnTokenInfoFetched");
				}
				return r_Em_OnTokenInfoFetched;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+UserInfo] m_OnUserInfoFetched
		/// </summary>
		protected REvent r_Em_OnUserInfoFetched;
		public virtual REvent REm_OnUserInfoFetched
		{
			get
			{
				if(r_Em_OnUserInfoFetched == null)
				{
					r_Em_OnUserInfoFetched = new(this, "m_OnUserInfoFetched");
				}
				return r_Em_OnUserInfoFetched;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.UIError] m_OnError
		/// </summary>
		protected REvent r_Em_OnError;
		public virtual REvent REm_OnError
		{
			get
			{
				if(r_Em_OnError == null)
				{
					r_Em_OnError = new(this, "m_OnError");
				}
				return r_Em_OnError;
			}
		}

		/// <summary>
		/// System.String k_OAuthUri
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_OAuthUri;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_OAuthUri
		{
			get
			{
				if(r_Fk_OAuthUri == null)
				{
					r_Fk_OAuthUri = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth"), "k_OAuthUri");
				}
				return r_Fk_OAuthUri;
			}
		}

		/// <summary>
		/// System.String k_TokenInfoUri
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_TokenInfoUri;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_TokenInfoUri
		{
			get
			{
				if(r_Fk_TokenInfoUri == null)
				{
					r_Fk_TokenInfoUri = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth"), "k_TokenInfoUri");
				}
				return r_Fk_TokenInfoUri;
			}
		}

		/// <summary>
		/// System.String k_UserInfoUri
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_UserInfoUri;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_UserInfoUri
		{
			get
			{
				if(r_Fk_UserInfoUri == null)
				{
					r_Fk_UserInfoUri = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth"), "k_UserInfoUri");
				}
				return r_Fk_UserInfoUri;
			}
		}

		/// <summary>
		/// System.String k_ServiceId
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_ServiceId;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_ServiceId
		{
			get
			{
				if(r_Fk_ServiceId == null)
				{
					r_Fk_ServiceId = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth"), "k_ServiceId");
				}
				return r_Fk_ServiceId;
			}
		}

		/// <summary>
		/// UnityEditor.IAsyncHTTPClient m_UserInfoRequest
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIAsyncHTTPClient r_Fm_UserInfoRequest;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIAsyncHTTPClient RFm_UserInfoRequest
		{
			get
			{
				if(r_Fm_UserInfoRequest == null)
				{
					r_Fm_UserInfoRequest = new(this, "m_UserInfoRequest");
				}
				return r_Fm_UserInfoRequest;
			}
		}

		/// <summary>
		/// UnityEditor.IAsyncHTTPClient m_AccessTokenRequest
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIAsyncHTTPClient r_Fm_AccessTokenRequest;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIAsyncHTTPClient RFm_AccessTokenRequest
		{
			get
			{
				if(r_Fm_AccessTokenRequest == null)
				{
					r_Fm_AccessTokenRequest = new(this, "m_AccessTokenRequest");
				}
				return r_Fm_AccessTokenRequest;
			}
		}

		/// <summary>
		/// UnityEditor.IAsyncHTTPClient m_TokenRequest
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIAsyncHTTPClient r_Fm_TokenRequest;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIAsyncHTTPClient RFm_TokenRequest
		{
			get
			{
				if(r_Fm_TokenRequest == null)
				{
					r_Fm_TokenRequest = new(this, "m_TokenRequest");
				}
				return r_Fm_TokenRequest;
			}
		}

		/// <summary>
		/// System.Boolean m_AuthCodeRequested
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_AuthCodeRequested;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_AuthCodeRequested
		{
			get
			{
				if(r_Fm_AuthCodeRequested == null)
				{
					r_Fm_AuthCodeRequested = new(this, "m_AuthCodeRequested");
				}
				return r_Fm_AuthCodeRequested;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+UserInfo m_UserInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreOAuth.RUserInfo r_Fm_UserInfo;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreOAuth.RUserInfo RFm_UserInfo
		{
			get
			{
				if(r_Fm_UserInfo == null)
				{
					r_Fm_UserInfo = new(this, "m_UserInfo");
				}
				return r_Fm_UserInfo;
			}
		}

		/// <summary>
		/// System.String m_AuthCode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_AuthCode;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_AuthCode
		{
			get
			{
				if(r_Fm_AuthCode == null)
				{
					r_Fm_AuthCode = new(this, "m_AuthCode");
				}
				return r_Fm_AuthCode;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+AccessToken m_AccessToken
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreOAuth.RAccessToken r_Fm_AccessToken;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreOAuth.RAccessToken RFm_AccessToken
		{
			get
			{
				if(r_Fm_AccessToken == null)
				{
					r_Fm_AccessToken = new(this, "m_AccessToken");
				}
				return r_Fm_AccessToken;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+TokenInfo m_TokenInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreOAuth.RTokenInfo r_Fm_TokenInfo;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreOAuth.RTokenInfo RFm_TokenInfo
		{
			get
			{
				if(r_Fm_TokenInfo == null)
				{
					r_Fm_TokenInfo = new(this, "m_TokenInfo");
				}
				return r_Fm_TokenInfo;
			}
		}

		/// <summary>
		/// System.Action`1[System.String] m_OnAuthCodeFetched
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_OnAuthCodeFetched;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RString> RFm_OnAuthCodeFetched
		{
			get
			{
				if(r_Fm_OnAuthCodeFetched == null)
				{
					r_Fm_OnAuthCodeFetched = new(this, "m_OnAuthCodeFetched");
				}
				return r_Fm_OnAuthCodeFetched;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+AccessToken] m_OnAccessTokenFetched
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreOAuth.RAccessToken> r_Fm_OnAccessTokenFetched;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreOAuth.RAccessToken> RFm_OnAccessTokenFetched
		{
			get
			{
				if(r_Fm_OnAccessTokenFetched == null)
				{
					r_Fm_OnAccessTokenFetched = new(this, "m_OnAccessTokenFetched");
				}
				return r_Fm_OnAccessTokenFetched;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+TokenInfo] m_OnTokenInfoFetched
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreOAuth.RTokenInfo> r_Fm_OnTokenInfoFetched;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreOAuth.RTokenInfo> RFm_OnTokenInfoFetched
		{
			get
			{
				if(r_Fm_OnTokenInfoFetched == null)
				{
					r_Fm_OnTokenInfoFetched = new(this, "m_OnTokenInfoFetched");
				}
				return r_Fm_OnTokenInfoFetched;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+UserInfo] m_OnUserInfoFetched
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreOAuth.RUserInfo> r_Fm_OnUserInfoFetched;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreOAuth.RUserInfo> RFm_OnUserInfoFetched
		{
			get
			{
				if(r_Fm_OnUserInfoFetched == null)
				{
					r_Fm_OnUserInfoFetched = new(this, "m_OnUserInfoFetched");
				}
				return r_Fm_OnUserInfoFetched;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.UIError] m_OnError
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> r_Fm_OnError;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> RFm_OnError
		{
			get
			{
				if(r_Fm_OnError == null)
				{
					r_Fm_OnError = new(this, "m_OnError");
				}
				return r_Fm_OnError;
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
		/// System.String m_Secret
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Secret;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Secret
		{
			get
			{
				if(r_Fm_Secret == null)
				{
					r_Fm_Secret = new(this, "m_Secret");
				}
				return r_Fm_Secret;
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
		/// UnityEditor.PackageManager.UI.Internal.UnityOAuthProxy m_UnityOAuth
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityOAuthProxy r_Fm_UnityOAuth;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityOAuthProxy RFm_UnityOAuth
		{
			get
			{
				if(r_Fm_UnityOAuth == null)
				{
					r_Fm_UnityOAuth = new(this, "m_UnityOAuth");
				}
				return r_Fm_UnityOAuth;
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
		/// System.String secret
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Psecret;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPsecret
		{
			get
			{
				if(r_Psecret == null)
				{
					r_Psecret = new(this, "secret", -1);
				}
				return r_Psecret;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.UnityConnectProxy, UnityEditor.PackageManager.UI.Internal.UnityOAuthProxy, UnityEditor.PackageManager.UI.Internal.HttpClientFactory)
		/// </summary>
		protected RMethod r_MResolveDependencies_UnityConnectProxy_UnityOAuthProxy_HttpClientFactory;
		public virtual RMethod RMResolveDependencies_UnityConnectProxy_UnityOAuthProxy_HttpClientFactory
		{
			get
			{
				if(r_MResolveDependencies_UnityConnectProxy_UnityOAuthProxy_HttpClientFactory == null)
				{
					r_MResolveDependencies_UnityConnectProxy_UnityOAuthProxy_HttpClientFactory = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UnityConnectProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UnityOAuthProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.HttpClientFactory"));
				}
				return r_MResolveDependencies_UnityConnectProxy_UnityOAuthProxy_HttpClientFactory;
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
				}
				return r_MOnUserLoginStateChange_Boolean_Boolean;
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
				}
				return r_MClearCache;
			}
		}

		/// <summary>
		/// Void FetchUserInfo(System.Action`1[UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+UserInfo], System.Action`1[UnityEditor.PackageManager.UI.Internal.UIError])
		/// </summary>
		protected RMethod r_MFetchUserInfo_Action_d_UserInfo_p__Action_d_UIError_p_;
		public virtual RMethod RMFetchUserInfo_Action_d_UserInfo_p__Action_d_UIError_p_
		{
			get
			{
				if(r_MFetchUserInfo_Action_d_UserInfo_p__Action_d_UIError_p_ == null)
				{
					r_MFetchUserInfo_Action_d_UserInfo_p__Action_d_UIError_p_ = new(this, "FetchUserInfo", 0,  ReflectionUtils.GetType("System.Action`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+UserInfo")),  ReflectionUtils.GetType("System.Action`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError")));
				}
				return r_MFetchUserInfo_Action_d_UserInfo_p__Action_d_UIError_p_;
			}
		}

		/// <summary>
		/// Void GetAuthCode(System.Action`1[System.String])
		/// </summary>
		protected RMethod r_MGetAuthCode_Action_d_String_p_;
		public virtual RMethod RMGetAuthCode_Action_d_String_p_
		{
			get
			{
				if(r_MGetAuthCode_Action_d_String_p_ == null)
				{
					r_MGetAuthCode_Action_d_String_p_ = new(this, "GetAuthCode", 0,  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(System.String)));
				}
				return r_MGetAuthCode_Action_d_String_p_;
			}
		}

		/// <summary>
		/// Void GetAccessToken(System.Action`1[UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+AccessToken])
		/// </summary>
		protected RMethod r_MGetAccessToken_Action_d_AccessToken_p_;
		public virtual RMethod RMGetAccessToken_Action_d_AccessToken_p_
		{
			get
			{
				if(r_MGetAccessToken_Action_d_AccessToken_p_ == null)
				{
					r_MGetAccessToken_Action_d_AccessToken_p_ = new(this, "GetAccessToken", 0,  ReflectionUtils.GetType("System.Action`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+AccessToken")));
				}
				return r_MGetAccessToken_Action_d_AccessToken_p_;
			}
		}

		/// <summary>
		/// Void GetAccessToken(System.Action`1[UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+AccessToken], System.String, System.String)
		/// </summary>
		protected RMethod r_MGetAccessToken_Action_d_AccessToken_p__String_String;
		public virtual RMethod RMGetAccessToken_Action_d_AccessToken_p__String_String
		{
			get
			{
				if(r_MGetAccessToken_Action_d_AccessToken_p__String_String == null)
				{
					r_MGetAccessToken_Action_d_AccessToken_p__String_String = new(this, "GetAccessToken", 0,  ReflectionUtils.GetType("System.Action`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+AccessToken")), typeof(System.String), typeof(System.String));
				}
				return r_MGetAccessToken_Action_d_AccessToken_p__String_String;
			}
		}

		/// <summary>
		/// Void GetTokenInfo(System.Action`1[UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+TokenInfo])
		/// </summary>
		protected RMethod r_MGetTokenInfo_Action_d_TokenInfo_p_;
		public virtual RMethod RMGetTokenInfo_Action_d_TokenInfo_p_
		{
			get
			{
				if(r_MGetTokenInfo_Action_d_TokenInfo_p_ == null)
				{
					r_MGetTokenInfo_Action_d_TokenInfo_p_ = new(this, "GetTokenInfo", 0,  ReflectionUtils.GetType("System.Action`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+TokenInfo")));
				}
				return r_MGetTokenInfo_Action_d_TokenInfo_p_;
			}
		}

		/// <summary>
		/// Void GetUserInfo(System.Action`1[UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+UserInfo])
		/// </summary>
		protected RMethod r_MGetUserInfo_Action_d_UserInfo_p_;
		public virtual RMethod RMGetUserInfo_Action_d_UserInfo_p_
		{
			get
			{
				if(r_MGetUserInfo_Action_d_UserInfo_p_ == null)
				{
					r_MGetUserInfo_Action_d_UserInfo_p_ = new(this, "GetUserInfo", 0,  ReflectionUtils.GetType("System.Action`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+UserInfo")));
				}
				return r_MGetUserInfo_Action_d_UserInfo_p_;
			}
		}

		/// <summary>
		/// Void OnGetAccessTokenError(System.String)
		/// </summary>
		protected RMethod r_MOnGetAccessTokenError_String;
		public virtual RMethod RMOnGetAccessTokenError_String
		{
			get
			{
				if(r_MOnGetAccessTokenError_String == null)
				{
					r_MOnGetAccessTokenError_String = new(this, "OnGetAccessTokenError", 0, typeof(System.String));
				}
				return r_MOnGetAccessTokenError_String;
			}
		}

		/// <summary>
		/// Void OnOperationError(System.String)
		/// </summary>
		protected RMethod r_MOnOperationError_String;
		public virtual RMethod RMOnOperationError_String
		{
			get
			{
				if(r_MOnOperationError_String == null)
				{
					r_MOnOperationError_String = new(this, "OnOperationError", 0, typeof(System.String));
				}
				return r_MOnOperationError_String;
			}
		}

		/// <summary>
		/// Void <GetAuthCode>b__46_0(AuthCodeResponse)
		/// </summary>
		protected RMethod r_M__0__GetAuthCode__1__b__46_0_AuthCodeResponse;
		public virtual RMethod RM__0__GetAuthCode__1__b__46_0_AuthCodeResponse
		{
			get
			{
				if(r_M__0__GetAuthCode__1__b__46_0_AuthCodeResponse == null)
				{
					r_M__0__GetAuthCode__1__b__46_0_AuthCodeResponse = new(this, "<GetAuthCode>b__46_0", 0,  ReflectionUtils.GetType("UnityEditor.Connect.UnityOAuth+AuthCodeResponse"));
				}
				return r_M__0__GetAuthCode__1__b__46_0_AuthCodeResponse;
			}
		}

		/// <summary>
		/// Void <GetAccessToken>b__48_0(UnityEditor.IAsyncHTTPClient)
		/// </summary>
		protected RMethod r_M__0__GetAccessToken__1__b__48_0_IAsyncHTTPClient;
		public virtual RMethod RM__0__GetAccessToken__1__b__48_0_IAsyncHTTPClient
		{
			get
			{
				if(r_M__0__GetAccessToken__1__b__48_0_IAsyncHTTPClient == null)
				{
					r_M__0__GetAccessToken__1__b__48_0_IAsyncHTTPClient = new(this, "<GetAccessToken>b__48_0", 0,  ReflectionUtils.GetType("UnityEditor.IAsyncHTTPClient"));
				}
				return r_M__0__GetAccessToken__1__b__48_0_IAsyncHTTPClient;
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


        public virtual void ResolveDependencies(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityConnectProxy @unityConnect, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityOAuthProxy @unityOAuth, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RHttpClientFactory @httpClientFactory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unityConnect.Value, @unityOAuth.Value, @httpClientFactory.Value};
            var ___result = RMResolveDependencies_UnityConnectProxy_UnityOAuthProxy_HttpClientFactory.Invoke(___genericsType, ___parameters);

            
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


        public virtual void OnUserLoginStateChange(System.Boolean @userInfoReady, System.Boolean @loggedIn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@userInfoReady, @loggedIn};
            var ___result = RMOnUserLoginStateChange_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearCache()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearCache.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FetchUserInfo(Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreOAuth.RUserInfo> @doneCallback, Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> @errorCallback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@doneCallback.Value, @errorCallback.Value};
            var ___result = RMFetchUserInfo_Action_d_UserInfo_p__Action_d_UIError_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetAuthCode(System.Action<System.String> @doneCallback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@doneCallback};
            var ___result = RMGetAuthCode_Action_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetAccessToken(Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreOAuth.RAccessToken> @doneCallback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@doneCallback.Value};
            var ___result = RMGetAccessToken_Action_d_AccessToken_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetAccessToken(Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreOAuth.RAccessToken> @doneCallback, System.String @authCode, System.String @refreshToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@doneCallback.Value, @authCode, @refreshToken};
            var ___result = RMGetAccessToken_Action_d_AccessToken_p__String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTokenInfo(Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreOAuth.RTokenInfo> @doneCallback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@doneCallback.Value};
            var ___result = RMGetTokenInfo_Action_d_TokenInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetUserInfo(Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreOAuth.RUserInfo> @doneCallback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@doneCallback.Value};
            var ___result = RMGetUserInfo_Action_d_UserInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnGetAccessTokenError(System.String @errorMessage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@errorMessage};
            var ___result = RMOnGetAccessTokenError_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnOperationError(System.String @errorMessage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@errorMessage};
            var ___result = RMOnOperationError_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__GetAuthCode__1__b__46_0(Hvak.Editor.Refleaction.RUnityEditor.RConnect.RUnityOAuth.RAuthCodeResponse @authCodeResponse)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@authCodeResponse.Value};
            var ___result = RM__0__GetAuthCode__1__b__46_0_AuthCodeResponse.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__GetAccessToken__1__b__48_0(Hvak.Editor.Refleaction.RUnityEditor.RIAsyncHTTPClient @httpClient)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@httpClient.Value};
            var ___result = RM__0__GetAccessToken__1__b__48_0_IAsyncHTTPClient.Invoke(___genericsType, ___parameters);

            
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
