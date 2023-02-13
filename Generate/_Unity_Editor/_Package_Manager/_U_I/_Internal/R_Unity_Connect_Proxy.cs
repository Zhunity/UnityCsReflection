
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.UnityConnectProxy
	/// </summary>
    public partial class RUnityConnectProxy : RMember //
    {

		/// <summary>
		/// System.Action`2[System.Boolean,System.Boolean] onUserLoginStateChange
		/// </summary>
		protected REvent r_EonUserLoginStateChange;
		public virtual REvent REonUserLoginStateChange
		{
			get
			{
				if(r_EonUserLoginStateChange == null)
				{
					r_EonUserLoginStateChange = new(this, "onUserLoginStateChange");
					r_EonUserLoginStateChange.SetBelong(this.instance);
				}
				return r_EonUserLoginStateChange;
			}
		}

		/// <summary>
		/// System.Boolean m_IsUserInfoReady
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_IsUserInfoReady;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_IsUserInfoReady
		{
			get
			{
				if(r_Fm_IsUserInfoReady == null)
				{
					r_Fm_IsUserInfoReady = new(this, "m_IsUserInfoReady");
					r_Fm_IsUserInfoReady.SetBelong(this.instance);
				}
				return r_Fm_IsUserInfoReady;
			}
		}

		/// <summary>
		/// System.Boolean m_HasAccessToken
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_HasAccessToken;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_HasAccessToken
		{
			get
			{
				if(r_Fm_HasAccessToken == null)
				{
					r_Fm_HasAccessToken = new(this, "m_HasAccessToken");
					r_Fm_HasAccessToken.SetBelong(this.instance);
				}
				return r_Fm_HasAccessToken;
			}
		}

		/// <summary>
		/// System.String m_UserId
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fm_UserId;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFm_UserId
		{
			get
			{
				if(r_Fm_UserId == null)
				{
					r_Fm_UserId = new(this, "m_UserId");
					r_Fm_UserId.SetBelong(this.instance);
				}
				return r_Fm_UserId;
			}
		}

		/// <summary>
		/// System.Action`2[System.Boolean,System.Boolean] onUserLoginStateChange
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RBoolean, SMFrame.Editor.Refleaction.RSystem.RBoolean> r_FonUserLoginStateChange;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RBoolean, SMFrame.Editor.Refleaction.RSystem.RBoolean> RFonUserLoginStateChange
		{
			get
			{
				if(r_FonUserLoginStateChange == null)
				{
					r_FonUserLoginStateChange = new(this, "onUserLoginStateChange");
					r_FonUserLoginStateChange.SetBelong(this.instance);
				}
				return r_FonUserLoginStateChange;
			}
		}

		/// <summary>
		/// Boolean isUserInfoReady
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisUserInfoReady;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisUserInfoReady
		{
			get
			{
				if(r_PisUserInfoReady == null)
				{
					r_PisUserInfoReady = new(this, "isUserInfoReady", -1);
					r_PisUserInfoReady.SetBelong(this.instance);
				}
				return r_PisUserInfoReady;
			}
		}

		/// <summary>
		/// Boolean isUserLoggedIn
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisUserLoggedIn;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisUserLoggedIn
		{
			get
			{
				if(r_PisUserLoggedIn == null)
				{
					r_PisUserLoggedIn = new(this, "isUserLoggedIn", -1);
					r_PisUserLoggedIn.SetBelong(this.instance);
				}
				return r_PisUserLoggedIn;
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
		/// System.String GetConfigurationURL(UnityEditor.Connect.CloudConfigUrl)
		/// </summary>
		protected RMethod r_MGetConfigurationURL_CloudConfigUrl;
		public virtual RMethod RMGetConfigurationURL_CloudConfigUrl
		{
			get
			{
				if(r_MGetConfigurationURL_CloudConfigUrl == null)
				{
					r_MGetConfigurationURL_CloudConfigUrl = new(this, "GetConfigurationURL", 0,  ReflectionUtils.GetType("UnityEditor.Connect.CloudConfigUrl"));
					r_MGetConfigurationURL_CloudConfigUrl.SetBelong(this.instance);
				}
				return r_MGetConfigurationURL_CloudConfigUrl;
			}
		}

		/// <summary>
		/// Void ShowLogin()
		/// </summary>
		protected RMethod r_MShowLogin;
		public virtual RMethod RMShowLogin
		{
			get
			{
				if(r_MShowLogin == null)
				{
					r_MShowLogin = new(this, "ShowLogin", 0);
					r_MShowLogin.SetBelong(this.instance);
				}
				return r_MShowLogin;
			}
		}

		/// <summary>
		/// Void OpenAuthorizedURLInWebBrowser(System.String)
		/// </summary>
		protected RMethod r_MOpenAuthorizedURLInWebBrowser_String;
		public virtual RMethod RMOpenAuthorizedURLInWebBrowser_String
		{
			get
			{
				if(r_MOpenAuthorizedURLInWebBrowser_String == null)
				{
					r_MOpenAuthorizedURLInWebBrowser_String = new(this, "OpenAuthorizedURLInWebBrowser", 0, typeof(System.String));
					r_MOpenAuthorizedURLInWebBrowser_String.SetBelong(this.instance);
				}
				return r_MOpenAuthorizedURLInWebBrowser_String;
			}
		}

		/// <summary>
		/// Void OnUserStateChanged(UnityEditor.Connect.UserInfo)
		/// </summary>
		protected RMethod r_MOnUserStateChanged_UserInfo;
		public virtual RMethod RMOnUserStateChanged_UserInfo
		{
			get
			{
				if(r_MOnUserStateChanged_UserInfo == null)
				{
					r_MOnUserStateChanged_UserInfo = new(this, "OnUserStateChanged", 0,  ReflectionUtils.GetType("UnityEditor.Connect.UserInfo"));
					r_MOnUserStateChanged_UserInfo.SetBelong(this.instance);
				}
				return r_MOnUserStateChanged_UserInfo;
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


        public RUnityConnectProxy() : base("UnityEditor.PackageManager.UI.Internal.UnityConnectProxy")
        {
        }

        public RUnityConnectProxy(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.UnityConnectProxy")
		{
            SetInstance(instance);
		}

        public RUnityConnectProxy(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUnityConnectProxy(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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


        public virtual System.String GetConfigurationURL(SMFrame.Editor.Refleaction.RUnityEditor.RConnect.RCloudConfigUrl @config)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@config.Value};
            var ___result = RMGetConfigurationURL_CloudConfigUrl.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void ShowLogin()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShowLogin.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OpenAuthorizedURLInWebBrowser(System.String @url)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@url};
            var ___result = RMOpenAuthorizedURLInWebBrowser_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnUserStateChanged(SMFrame.Editor.Refleaction.RUnityEditor.RConnect.RUserInfo @newInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newInfo.Value};
            var ___result = RMOnUserStateChanged_UserInfo.Invoke(___genericsType, ___parameters);

            
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
