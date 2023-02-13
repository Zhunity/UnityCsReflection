
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{public partial class RUpmClient
{
	
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.UpmClient+UpmPackageFactory
	/// </summary>
    public partial class RUpmPackageFactory : RMember //
    {

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
		/// UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettingsProxy m_SettingsProxy
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerProjectSettingsProxy r_Fm_SettingsProxy;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerProjectSettingsProxy RFm_SettingsProxy
		{
			get
			{
				if(r_Fm_SettingsProxy == null)
				{
					r_Fm_SettingsProxy = new(this, "m_SettingsProxy");
					r_Fm_SettingsProxy.SetBelong(this.instance);
				}
				return r_Fm_SettingsProxy;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.UpmCache, UnityEditor.PackageManager.UI.Internal.UpmClient, UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettingsProxy)
		/// </summary>
		protected RMethod r_MResolveDependencies_UpmCache_UpmClient_PackageManagerProjectSettingsProxy;
		public virtual RMethod RMResolveDependencies_UpmCache_UpmClient_PackageManagerProjectSettingsProxy
		{
			get
			{
				if(r_MResolveDependencies_UpmCache_UpmClient_PackageManagerProjectSettingsProxy == null)
				{
					r_MResolveDependencies_UpmCache_UpmClient_PackageManagerProjectSettingsProxy = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmCache"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmClient"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettingsProxy"));
					r_MResolveDependencies_UpmCache_UpmClient_PackageManagerProjectSettingsProxy.SetBelong(this.instance);
				}
				return r_MResolveDependencies_UpmCache_UpmClient_PackageManagerProjectSettingsProxy;
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
		/// Void OnShowPreReleasePackagesesOrSeeAllVersionsChanged(Boolean)
		/// </summary>
		protected RMethod r_MOnShowPreReleasePackagesesOrSeeAllVersionsChanged_Boolean;
		public virtual RMethod RMOnShowPreReleasePackagesesOrSeeAllVersionsChanged_Boolean
		{
			get
			{
				if(r_MOnShowPreReleasePackagesesOrSeeAllVersionsChanged_Boolean == null)
				{
					r_MOnShowPreReleasePackagesesOrSeeAllVersionsChanged_Boolean = new(this, "OnShowPreReleasePackagesesOrSeeAllVersionsChanged", 0, typeof(System.Boolean));
					r_MOnShowPreReleasePackagesesOrSeeAllVersionsChanged_Boolean.SetBelong(this.instance);
				}
				return r_MOnShowPreReleasePackagesesOrSeeAllVersionsChanged_Boolean;
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


        public RUpmPackageFactory() : base("UnityEditor.PackageManager.UI.Internal.UpmClient+UpmPackageFactory")
        {
        }

        public RUpmPackageFactory(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.UpmClient+UpmPackageFactory")
		{
            SetInstance(instance);
		}

        public RUpmPackageFactory(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUpmPackageFactory(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void ResolveDependencies(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmCache @upmCache, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmClient @upmClient, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerProjectSettingsProxy @settingsProxy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@upmCache.Value, @upmClient.Value, @settingsProxy.Value};
            var ___result = RMResolveDependencies_UpmCache_UpmClient_PackageManagerProjectSettingsProxy.Invoke(___genericsType, ___parameters);

            
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


        public virtual void OnExtraPackageInfoFetched(UnityEditor.PackageManager.PackageInfo @packageInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageInfo};
            var ___result = RMOnExtraPackageInfoFetched_PackageInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GeneratePackagesAndTriggerChangeEvent(System.Collections.Generic.IEnumerable<System.String> @packageNames)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageNames};
            var ___result = RMGeneratePackagesAndTriggerChangeEvent_IEnumerable_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPackageInfosUpdated(System.Collections.Generic.IEnumerable<UnityEditor.PackageManager.PackageInfo> @packageInfos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageInfos};
            var ___result = RMOnPackageInfosUpdated_IEnumerable_d_PackageInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadAllVersionsChanged(System.String @packageUniqueId, System.Boolean @_)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueId, @_};
            var ___result = RMOnLoadAllVersionsChanged_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnShowPreReleasePackagesesOrSeeAllVersionsChanged(System.Boolean @_)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_};
            var ___result = RMOnShowPreReleasePackagesesOrSeeAllVersionsChanged_Boolean.Invoke(___genericsType, ___parameters);

            
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