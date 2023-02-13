
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.PackageFiltering
	/// </summary>
    public partial class RPackageFiltering : RMember //
    {

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.PackageFilterTab] onFilterTabChanged
		/// </summary>
		protected REvent r_EonFilterTabChanged;
		public virtual REvent REonFilterTabChanged
		{
			get
			{
				if(r_EonFilterTabChanged == null)
				{
					r_EonFilterTabChanged = new(this, "onFilterTabChanged");
					r_EonFilterTabChanged.SetBelong(this.instance);
				}
				return r_EonFilterTabChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.String] onSearchTextChanged
		/// </summary>
		protected REvent r_EonSearchTextChanged;
		public virtual REvent REonSearchTextChanged
		{
			get
			{
				if(r_EonSearchTextChanged == null)
				{
					r_EonSearchTextChanged = new(this, "onSearchTextChanged");
					r_EonSearchTextChanged.SetBelong(this.instance);
				}
				return r_EonSearchTextChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.PackageFilterTab] onFilterTabChanged
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab> r_FonFilterTabChanged;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab> RFonFilterTabChanged
		{
			get
			{
				if(r_FonFilterTabChanged == null)
				{
					r_FonFilterTabChanged = new(this, "onFilterTabChanged");
					r_FonFilterTabChanged.SetBelong(this.instance);
				}
				return r_FonFilterTabChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.String] onSearchTextChanged
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RString> r_FonSearchTextChanged;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RString> RFonSearchTextChanged
		{
			get
			{
				if(r_FonSearchTextChanged == null)
				{
					r_FonSearchTextChanged = new(this, "onSearchTextChanged");
					r_FonSearchTextChanged.SetBelong(this.instance);
				}
				return r_FonSearchTextChanged;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageFilterTab k_DefaultFilterTab
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab r_Fk_DefaultFilterTab;
		public static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab RFk_DefaultFilterTab
		{
			get
			{
				if(r_Fk_DefaultFilterTab == null)
				{
					r_Fk_DefaultFilterTab = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageFiltering"), "k_DefaultFilterTab");
					r_Fk_DefaultFilterTab.SetBelong(null);
				}
				return r_Fk_DefaultFilterTab;
			}
		}

		/// <summary>
		/// System.Nullable`1[UnityEditor.PackageManager.UI.Internal.PackageFilterTab] <previousFilterTab>k__BackingField
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RNullable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab> r_F__0__previousFilterTab__1__k__BackingField;
		public virtual SMFrame.Editor.Refleaction.RSystem.RNullable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab> RF__0__previousFilterTab__1__k__BackingField
		{
			get
			{
				if(r_F__0__previousFilterTab__1__k__BackingField == null)
				{
					r_F__0__previousFilterTab__1__k__BackingField = new(this, "<previousFilterTab>k__BackingField");
					r_F__0__previousFilterTab__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__previousFilterTab__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageFilterTab m_CurrentFilterTab
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab r_Fm_CurrentFilterTab;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab RFm_CurrentFilterTab
		{
			get
			{
				if(r_Fm_CurrentFilterTab == null)
				{
					r_Fm_CurrentFilterTab = new(this, "m_CurrentFilterTab");
					r_Fm_CurrentFilterTab.SetBelong(this.instance);
				}
				return r_Fm_CurrentFilterTab;
			}
		}

		/// <summary>
		/// System.Boolean m_CurrentFilterTabInitialized
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_CurrentFilterTabInitialized;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_CurrentFilterTabInitialized
		{
			get
			{
				if(r_Fm_CurrentFilterTabInitialized == null)
				{
					r_Fm_CurrentFilterTabInitialized = new(this, "m_CurrentFilterTabInitialized");
					r_Fm_CurrentFilterTabInitialized.SetBelong(this.instance);
				}
				return r_Fm_CurrentFilterTabInitialized;
			}
		}

		/// <summary>
		/// System.String m_CurrentSearchText
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fm_CurrentSearchText;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFm_CurrentSearchText
		{
			get
			{
				if(r_Fm_CurrentSearchText == null)
				{
					r_Fm_CurrentSearchText = new(this, "m_CurrentSearchText");
					r_Fm_CurrentSearchText.SetBelong(this.instance);
				}
				return r_Fm_CurrentSearchText;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UnityConnectProxy m_UnityConnect
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityConnectProxy r_Fm_UnityConnect;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityConnectProxy RFm_UnityConnect
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
		/// System.Nullable`1[UnityEditor.PackageManager.UI.Internal.PackageFilterTab] previousFilterTab
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RNullable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab> r_PpreviousFilterTab;
		public virtual SMFrame.Editor.Refleaction.RSystem.RNullable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab> RPpreviousFilterTab
		{
			get
			{
				if(r_PpreviousFilterTab == null)
				{
					r_PpreviousFilterTab = new(this, "previousFilterTab", -1);
					r_PpreviousFilterTab.SetBelong(this.instance);
				}
				return r_PpreviousFilterTab;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageFilterTab currentFilterTab
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab r_PcurrentFilterTab;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab RPcurrentFilterTab
		{
			get
			{
				if(r_PcurrentFilterTab == null)
				{
					r_PcurrentFilterTab = new(this, "currentFilterTab", -1);
					r_PcurrentFilterTab.SetBelong(this.instance);
				}
				return r_PcurrentFilterTab;
			}
		}

		/// <summary>
		/// System.String currentSearchText
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PcurrentSearchText;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPcurrentSearchText
		{
			get
			{
				if(r_PcurrentSearchText == null)
				{
					r_PcurrentSearchText = new(this, "currentSearchText", -1);
					r_PcurrentSearchText.SetBelong(this.instance);
				}
				return r_PcurrentSearchText;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.UnityConnectProxy, UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettingsProxy)
		/// </summary>
		protected RMethod r_MResolveDependencies_UnityConnectProxy_PackageManagerProjectSettingsProxy;
		public virtual RMethod RMResolveDependencies_UnityConnectProxy_PackageManagerProjectSettingsProxy
		{
			get
			{
				if(r_MResolveDependencies_UnityConnectProxy_PackageManagerProjectSettingsProxy == null)
				{
					r_MResolveDependencies_UnityConnectProxy_PackageManagerProjectSettingsProxy = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UnityConnectProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettingsProxy"));
					r_MResolveDependencies_UnityConnectProxy_PackageManagerProjectSettingsProxy.SetBelong(this.instance);
				}
				return r_MResolveDependencies_UnityConnectProxy_PackageManagerProjectSettingsProxy;
			}
		}

		/// <summary>
		/// Boolean FilterByTab(UnityEditor.PackageManager.UI.Internal.IPackage, UnityEditor.PackageManager.UI.Internal.PackageFilterTab, Boolean)
		/// </summary>
		protected static RMethod r_MFilterByTab_IPackage_PackageFilterTab_Boolean;
		public static RMethod RMFilterByTab_IPackage_PackageFilterTab_Boolean
		{
			get
			{
				if(r_MFilterByTab_IPackage_PackageFilterTab_Boolean == null)
				{
					r_MFilterByTab_IPackage_PackageFilterTab_Boolean = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageFiltering"), "FilterByTab", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageFilterTab"), typeof(System.Boolean));
					r_MFilterByTab_IPackage_PackageFilterTab_Boolean.SetBelong(null);
				}
				return r_MFilterByTab_IPackage_PackageFilterTab_Boolean;
			}
		}

		/// <summary>
		/// Boolean FilterByText(UnityEditor.PackageManager.UI.Internal.IPackage, UnityEditor.PackageManager.UI.Internal.IPackageVersion, System.String)
		/// </summary>
		protected static RMethod r_MFilterByText_IPackage_IPackageVersion_String;
		public static RMethod RMFilterByText_IPackage_IPackageVersion_String
		{
			get
			{
				if(r_MFilterByText_IPackage_IPackageVersion_String == null)
				{
					r_MFilterByText_IPackage_IPackageVersion_String = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageFiltering"), "FilterByText", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"), typeof(System.String));
					r_MFilterByText_IPackage_IPackageVersion_String.SetBelong(null);
				}
				return r_MFilterByText_IPackage_IPackageVersion_String;
			}
		}

		/// <summary>
		/// Boolean FilterByCurrentSearchText(UnityEditor.PackageManager.UI.Internal.IPackage)
		/// </summary>
		protected RMethod r_MFilterByCurrentSearchText_IPackage;
		public virtual RMethod RMFilterByCurrentSearchText_IPackage
		{
			get
			{
				if(r_MFilterByCurrentSearchText_IPackage == null)
				{
					r_MFilterByCurrentSearchText_IPackage = new(this, "FilterByCurrentSearchText", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"));
					r_MFilterByCurrentSearchText_IPackage.SetBelong(this.instance);
				}
				return r_MFilterByCurrentSearchText_IPackage;
			}
		}

		/// <summary>
		/// Boolean FilterByCurrentTab(UnityEditor.PackageManager.UI.Internal.IPackage)
		/// </summary>
		protected RMethod r_MFilterByCurrentTab_IPackage;
		public virtual RMethod RMFilterByCurrentTab_IPackage
		{
			get
			{
				if(r_MFilterByCurrentTab_IPackage == null)
				{
					r_MFilterByCurrentTab_IPackage = new(this, "FilterByCurrentTab", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"));
					r_MFilterByCurrentTab_IPackage.SetBelong(this.instance);
				}
				return r_MFilterByCurrentTab_IPackage;
			}
		}

		/// <summary>
		/// Void SetCurrentFilterTabWithoutNotify(UnityEditor.PackageManager.UI.Internal.PackageFilterTab)
		/// </summary>
		protected RMethod r_MSetCurrentFilterTabWithoutNotify_PackageFilterTab;
		public virtual RMethod RMSetCurrentFilterTabWithoutNotify_PackageFilterTab
		{
			get
			{
				if(r_MSetCurrentFilterTabWithoutNotify_PackageFilterTab == null)
				{
					r_MSetCurrentFilterTabWithoutNotify_PackageFilterTab = new(this, "SetCurrentFilterTabWithoutNotify", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageFilterTab"));
					r_MSetCurrentFilterTabWithoutNotify_PackageFilterTab.SetBelong(this.instance);
				}
				return r_MSetCurrentFilterTabWithoutNotify_PackageFilterTab;
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


        public RPackageFiltering() : base("UnityEditor.PackageManager.UI.Internal.PackageFiltering")
        {
        }

        public RPackageFiltering(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.PackageFiltering")
		{
            SetInstance(instance);
		}

        public RPackageFiltering(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPackageFiltering(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void ResolveDependencies(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityConnectProxy @unityConnect, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerProjectSettingsProxy @settingsProxy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unityConnect.Value, @settingsProxy.Value};
            var ___result = RMResolveDependencies_UnityConnectProxy_PackageManagerProjectSettingsProxy.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean FilterByTab(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab @tab, System.Boolean @isLoggedIn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value, @tab.Value, @isLoggedIn};
            var ___result = RMFilterByTab_IPackage_PackageFilterTab_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean FilterByText(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version, System.String @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value, @version.Value, @text};
            var ___result = RMFilterByText_IPackage_IPackageVersion_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean FilterByCurrentSearchText(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RMFilterByCurrentSearchText_IPackage.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean FilterByCurrentTab(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RMFilterByCurrentTab_IPackage.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetCurrentFilterTabWithoutNotify(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab @tab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tab.Value};
            var ___result = RMSetCurrentFilterTabWithoutNotify_PackageFilterTab.Invoke(___genericsType, ___parameters);

            
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
