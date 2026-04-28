
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.Internal.PackageDetails
	/// </summary>
    public partial class RPackageDetails : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageDetails");
            }
        }

        public RPackageDetails() : base("UnityEditor.PackageManager.UI.Internal.PackageDetails")
        {
        }

        public RPackageDetails(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.PackageDetails")
		{
            SetInstance(instance);
		}

        public RPackageDetails(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPackageDetails(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String k_TermsOfServicesURL
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_TermsOfServicesURL;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_TermsOfServicesURL
		{
			get
			{
				if(r_Fk_TermsOfServicesURL == null)
				{
					r_Fk_TermsOfServicesURL = new(Type, "k_TermsOfServicesURL");
				}
				return r_Fk_TermsOfServicesURL;
			}
		}

		/// <summary>
		/// System.String k_CustomizedIcon
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_CustomizedIcon;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_CustomizedIcon
		{
			get
			{
				if(r_Fk_CustomizedIcon == null)
				{
					r_Fk_CustomizedIcon = new(Type, "k_CustomizedIcon");
				}
				return r_Fk_CustomizedIcon;
			}
		}

		/// <summary>
		/// System.String k_WarningIcon
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_WarningIcon;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_WarningIcon
		{
			get
			{
				if(r_Fk_WarningIcon == null)
				{
					r_Fk_WarningIcon = new(Type, "k_WarningIcon");
				}
				return r_Fk_WarningIcon;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion m_Version
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion r_Fm_Version;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion RFm_Version
		{
			get
			{
				if(r_Fm_Version == null)
				{
					r_Fm_Version = new(this, "m_Version");
				}
				return r_Fm_Version;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackage <package>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage r_F__0__package__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage RF__0__package__1__k__BackingField
		{
			get
			{
				if(r_F__0__package__1__k__BackingField == null)
				{
					r_F__0__package__1__k__BackingField = new(this, "<package>k__BackingField");
				}
				return r_F__0__package__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackageVersion] featureSetDependents
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion> r_FfeatureSetDependents;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion> RFfeatureSetDependents
		{
			get
			{
				if(r_FfeatureSetDependents == null)
				{
					r_FfeatureSetDependents = new(this, "featureSetDependents");
				}
				return r_FfeatureSetDependents;
			}
		}

		/// <summary>
		/// System.String[] k_PackageActionVerbs
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fk_PackageActionVerbs;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFk_PackageActionVerbs
		{
			get
			{
				if(r_Fk_PackageActionVerbs == null)
				{
					r_Fk_PackageActionVerbs = new(Type, "k_PackageActionVerbs");
				}
				return r_Fk_PackageActionVerbs;
			}
		}

		/// <summary>
		/// System.String[] k_PackageActionInProgressVerbs
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fk_PackageActionInProgressVerbs;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFk_PackageActionInProgressVerbs
		{
			get
			{
				if(r_Fk_PackageActionInProgressVerbs == null)
				{
					r_Fk_PackageActionInProgressVerbs = new(Type, "k_PackageActionInProgressVerbs");
				}
				return r_Fk_PackageActionInProgressVerbs;
			}
		}

		/// <summary>
		/// System.String[] k_PackageActionTooltips
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fk_PackageActionTooltips;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFk_PackageActionTooltips
		{
			get
			{
				if(r_Fk_PackageActionTooltips == null)
				{
					r_Fk_PackageActionTooltips = new(Type, "k_PackageActionTooltips");
				}
				return r_Fk_PackageActionTooltips;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.ResourceLoader m_ResourceLoader
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RResourceLoader r_Fm_ResourceLoader;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RResourceLoader RFm_ResourceLoader
		{
			get
			{
				if(r_Fm_ResourceLoader == null)
				{
					r_Fm_ResourceLoader = new(this, "m_ResourceLoader");
				}
				return r_Fm_ResourceLoader;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.ExtensionManager m_ExtensionManager
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RExtensionManager r_Fm_ExtensionManager;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RExtensionManager RFm_ExtensionManager
		{
			get
			{
				if(r_Fm_ExtensionManager == null)
				{
					r_Fm_ExtensionManager = new(this, "m_ExtensionManager");
				}
				return r_Fm_ExtensionManager;
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
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadManager m_AssetStoreDownloadManager
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreDownloadManager r_Fm_AssetStoreDownloadManager;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreDownloadManager RFm_AssetStoreDownloadManager
		{
			get
			{
				if(r_Fm_AssetStoreDownloadManager == null)
				{
					r_Fm_AssetStoreDownloadManager = new(this, "m_AssetStoreDownloadManager");
				}
				return r_Fm_AssetStoreDownloadManager;
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
				}
				return r_Fm_UpmCache;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageManagerPrefs m_PackageManagerPrefs
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerPrefs r_Fm_PackageManagerPrefs;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerPrefs RFm_PackageManagerPrefs
		{
			get
			{
				if(r_Fm_PackageManagerPrefs == null)
				{
					r_Fm_PackageManagerPrefs = new(this, "m_PackageManagerPrefs");
				}
				return r_Fm_PackageManagerPrefs;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageDatabase m_PackageDatabase
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDatabase r_Fm_PackageDatabase;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDatabase RFm_PackageDatabase
		{
			get
			{
				if(r_Fm_PackageDatabase == null)
				{
					r_Fm_PackageDatabase = new(this, "m_PackageDatabase");
				}
				return r_Fm_PackageDatabase;
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
				}
				return r_Fm_PageManager;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UnityConnectProxy m_UnityConnectProxy
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityConnectProxy r_Fm_UnityConnectProxy;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityConnectProxy RFm_UnityConnectProxy
		{
			get
			{
				if(r_Fm_UnityConnectProxy == null)
				{
					r_Fm_UnityConnectProxy = new(this, "m_UnityConnectProxy");
				}
				return r_Fm_UnityConnectProxy;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.VisualElementCache <cache>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualElementCache r_F__0__cache__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualElementCache RF__0__cache__1__k__BackingField
		{
			get
			{
				if(r_F__0__cache__1__k__BackingField == null)
				{
					r_F__0__cache__1__k__BackingField = new(this, "<cache>k__BackingField");
				}
				return r_F__0__cache__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Rect lastLayout
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_FlastLayout;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFlastLayout
		{
			get
			{
				if(r_FlastLayout == null)
				{
					r_FlastLayout = new(this, "lastLayout");
				}
				return r_FlastLayout;
			}
		}

		/// <summary>
		/// UnityEngine.Rect lastPseudoPadding
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_FlastPseudoPadding;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFlastPseudoPadding
		{
			get
			{
				if(r_FlastPseudoPadding == null)
				{
					r_FlastPseudoPadding = new(this, "lastPseudoPadding");
				}
				return r_FlastPseudoPadding;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainVEData renderChainData
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainVEData r_FrenderChainData;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainVEData RFrenderChainData
		{
			get
			{
				if(r_FrenderChainData == null)
				{
					r_FrenderChainData = new(this, "renderChainData");
				}
				return r_FrenderChainData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PseudoStates triggerPseudoMask
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPseudoStates r_FtriggerPseudoMask;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPseudoStates RFtriggerPseudoMask
		{
			get
			{
				if(r_FtriggerPseudoMask == null)
				{
					r_FtriggerPseudoMask = new(this, "triggerPseudoMask");
				}
				return r_FtriggerPseudoMask;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PseudoStates dependencyPseudoMask
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPseudoStates r_FdependencyPseudoMask;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPseudoStates RFdependencyPseudoMask
		{
			get
			{
				if(r_FdependencyPseudoMask == null)
				{
					r_FdependencyPseudoMask = new(this, "dependencyPseudoMask");
				}
				return r_FdependencyPseudoMask;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ComputedStyle m_Style
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle r_Fm_Style;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle RFm_Style
		{
			get
			{
				if(r_Fm_Style == null)
				{
					r_Fm_Style = new(this, "m_Style");
				}
				return r_Fm_Style;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleVariableContext variableContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariableContext r_FvariableContext;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariableContext RFvariableContext
		{
			get
			{
				if(r_FvariableContext == null)
				{
					r_FvariableContext = new(this, "variableContext");
				}
				return r_FvariableContext;
			}
		}

		/// <summary>
		/// System.Int32 inheritedStylesHash
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FinheritedStylesHash;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFinheritedStylesHash
		{
			get
			{
				if(r_FinheritedStylesHash == null)
				{
					r_FinheritedStylesHash = new(this, "inheritedStylesHash");
				}
				return r_FinheritedStylesHash;
			}
		}

		/// <summary>
		/// System.UInt32 controlid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fcontrolid;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFcontrolid
		{
			get
			{
				if(r_Fcontrolid == null)
				{
					r_Fcontrolid = new(this, "controlid");
				}
				return r_Fcontrolid;
			}
		}

		/// <summary>
		/// System.Int32 imguiContainerDescendantCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FimguiContainerDescendantCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFimguiContainerDescendantCount
		{
			get
			{
				if(r_FimguiContainerDescendantCount == null)
				{
					r_FimguiContainerDescendantCount = new(this, "imguiContainerDescendantCount");
				}
				return r_FimguiContainerDescendantCount;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.InlineStyleAccess inlineStyleAccess
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RInlineStyleAccess r_FinlineStyleAccess;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RInlineStyleAccess RFinlineStyleAccess
		{
			get
			{
				if(r_FinlineStyleAccess == null)
				{
					r_FinlineStyleAccess = new(this, "inlineStyleAccess");
				}
				return r_FinlineStyleAccess;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheet] styleSheetList
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet> r_FstyleSheetList;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet> RFstyleSheetList
		{
			get
			{
				if(r_FstyleSheetList == null)
				{
					r_FstyleSheetList = new(this, "styleSheetList");
				}
				return r_FstyleSheetList;
			}
		}

		/// <summary>
		/// System.Boolean isIMGUIContainer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FisIMGUIContainer;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFisIMGUIContainer
		{
			get
			{
				if(r_FisIMGUIContainer == null)
				{
					r_FisIMGUIContainer = new(this, "isIMGUIContainer");
				}
				return r_FisIMGUIContainer;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackage package
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage r_Ppackage;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage RPpackage
		{
			get
			{
				if(r_Ppackage == null)
				{
					r_Ppackage = new(this, "package", -1);
				}
				return r_Ppackage;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion displayVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion r_PdisplayVersion;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion RPdisplayVersion
		{
			get
			{
				if(r_PdisplayVersion == null)
				{
					r_PdisplayVersion = new(this, "displayVersion", -1);
				}
				return r_PdisplayVersion;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion targetVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion r_PtargetVersion;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion RPtargetVersion
		{
			get
			{
				if(r_PtargetVersion == null)
				{
					r_PtargetVersion = new(this, "targetVersion", -1);
				}
				return r_PtargetVersion;
			}
		}

		/// <summary>
		/// Boolean isRequestedButOverriddenVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisRequestedButOverriddenVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisRequestedButOverriddenVersion
		{
			get
			{
				if(r_PisRequestedButOverriddenVersion == null)
				{
					r_PisRequestedButOverriddenVersion = new(this, "isRequestedButOverriddenVersion", -1);
				}
				return r_PisRequestedButOverriddenVersion;
			}
		}

		/// <summary>
		/// ButtonDisableCondition disableIfCompiling
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RButtonDisableCondition r_PdisableIfCompiling;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RButtonDisableCondition RPdisableIfCompiling
		{
			get
			{
				if(r_PdisableIfCompiling == null)
				{
					r_PdisableIfCompiling = new(this, "disableIfCompiling", -1);
				}
				return r_PdisableIfCompiling;
			}
		}

		/// <summary>
		/// ButtonDisableCondition disableIfInstallOrUninstallInProgress
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RButtonDisableCondition r_PdisableIfInstallOrUninstallInProgress;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RButtonDisableCondition RPdisableIfInstallOrUninstallInProgress
		{
			get
			{
				if(r_PdisableIfInstallOrUninstallInProgress == null)
				{
					r_PdisableIfInstallOrUninstallInProgress = new(this, "disableIfInstallOrUninstallInProgress", -1);
				}
				return r_PdisableIfInstallOrUninstallInProgress;
			}
		}

		/// <summary>
		/// ButtonDisableCondition disableIfNoNetwork
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RButtonDisableCondition r_PdisableIfNoNetwork;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RButtonDisableCondition RPdisableIfNoNetwork
		{
			get
			{
				if(r_PdisableIfNoNetwork == null)
				{
					r_PdisableIfNoNetwork = new(this, "disableIfNoNetwork", -1);
				}
				return r_PdisableIfNoNetwork;
			}
		}

		/// <summary>
		/// ButtonDisableCondition disableIfEntitlementsError
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RButtonDisableCondition r_PdisableIfEntitlementsError;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RButtonDisableCondition RPdisableIfEntitlementsError
		{
			get
			{
				if(r_PdisableIfEntitlementsError == null)
				{
					r_PdisableIfEntitlementsError = new(this, "disableIfEntitlementsError", -1);
				}
				return r_PdisableIfEntitlementsError;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.VisualElementCache cache
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualElementCache r_Pcache;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualElementCache RPcache
		{
			get
			{
				if(r_Pcache == null)
				{
					r_Pcache = new(this, "cache", -1);
				}
				return r_Pcache;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.InProgressView inProgressView
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RInProgressView r_PinProgressView;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RInProgressView RPinProgressView
		{
			get
			{
				if(r_PinProgressView == null)
				{
					r_PinProgressView = new(this, "inProgressView", -1);
				}
				return r_PinProgressView;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageDetailsHeader header
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetailsHeader r_Pheader;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetailsHeader RPheader
		{
			get
			{
				if(r_Pheader == null)
				{
					r_Pheader = new(this, "header", -1);
				}
				return r_Pheader;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageDetailsBody body
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetailsBody r_Pbody;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetailsBody RPbody
		{
			get
			{
				if(r_Pbody == null)
				{
					r_Pbody = new(this, "body", -1);
				}
				return r_Pbody;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.Alert detailError
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAlert r_PdetailError;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAlert RPdetailError
		{
			get
			{
				if(r_PdetailError == null)
				{
					r_PdetailError = new(this, "detailError", -1);
				}
				return r_PdetailError;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ScrollView detailScrollView
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScrollView r_PdetailScrollView;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScrollView RPdetailScrollView
		{
			get
			{
				if(r_PdetailScrollView == null)
				{
					r_PdetailScrollView = new(this, "detailScrollView", -1);
				}
				return r_PdetailScrollView;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement detail
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Pdetail;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPdetail
		{
			get
			{
				if(r_Pdetail == null)
				{
					r_Pdetail = new(this, "detail", -1);
				}
				return r_Pdetail;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement customContainer
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PcustomContainer;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPcustomContainer
		{
			get
			{
				if(r_PcustomContainer == null)
				{
					r_PcustomContainer = new(this, "customContainer", -1);
				}
				return r_PcustomContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement extensionContainer
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PextensionContainer;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPextensionContainer
		{
			get
			{
				if(r_PextensionContainer == null)
				{
					r_PextensionContainer = new(this, "extensionContainer", -1);
				}
				return r_PextensionContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement packageToolbarContainer
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PpackageToolbarContainer;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPpackageToolbarContainer
		{
			get
			{
				if(r_PpackageToolbarContainer == null)
				{
					r_PpackageToolbarContainer = new(this, "packageToolbarContainer", -1);
				}
				return r_PpackageToolbarContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement packageToolbarMainContainer
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PpackageToolbarMainContainer;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPpackageToolbarMainContainer
		{
			get
			{
				if(r_PpackageToolbarMainContainer == null)
				{
					r_PpackageToolbarMainContainer = new(this, "packageToolbarMainContainer", -1);
				}
				return r_PpackageToolbarMainContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement packageToolbarLeftArea
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PpackageToolbarLeftArea;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPpackageToolbarLeftArea
		{
			get
			{
				if(r_PpackageToolbarLeftArea == null)
				{
					r_PpackageToolbarLeftArea = new(this, "packageToolbarLeftArea", -1);
				}
				return r_PpackageToolbarLeftArea;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement toolbarExtensions
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PtoolbarExtensions;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPtoolbarExtensions
		{
			get
			{
				if(r_PtoolbarExtensions == null)
				{
					r_PtoolbarExtensions = new(this, "toolbarExtensions", -1);
				}
				return r_PtoolbarExtensions;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Button unlockButton
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton r_PunlockButton;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton RPunlockButton
		{
			get
			{
				if(r_PunlockButton == null)
				{
					r_PunlockButton = new(this, "unlockButton", -1);
				}
				return r_PunlockButton;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Button updateButton
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton r_PupdateButton;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton RPupdateButton
		{
			get
			{
				if(r_PupdateButton == null)
				{
					r_PupdateButton = new(this, "updateButton", -1);
				}
				return r_PupdateButton;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Button removeButton
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton r_PremoveButton;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton RPremoveButton
		{
			get
			{
				if(r_PremoveButton == null)
				{
					r_PremoveButton = new(this, "removeButton", -1);
				}
				return r_PremoveButton;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.DropdownButton resetButton
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDropdownButton r_PresetButton;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDropdownButton RPresetButton
		{
			get
			{
				if(r_PresetButton == null)
				{
					r_PresetButton = new(this, "resetButton", -1);
				}
				return r_PresetButton;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Button importButton
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton r_PimportButton;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton RPimportButton
		{
			get
			{
				if(r_PimportButton == null)
				{
					r_PimportButton = new(this, "importButton", -1);
				}
				return r_PimportButton;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Button downloadButton
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton r_PdownloadButton;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton RPdownloadButton
		{
			get
			{
				if(r_PdownloadButton == null)
				{
					r_PdownloadButton = new(this, "downloadButton", -1);
				}
				return r_PdownloadButton;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.DropdownButton downgradeButton
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDropdownButton r_PdowngradeButton;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDropdownButton RPdowngradeButton
		{
			get
			{
				if(r_PdowngradeButton == null)
				{
					r_PdowngradeButton = new(this, "downgradeButton", -1);
				}
				return r_PdowngradeButton;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Button redownloadButton
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton r_PredownloadButton;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton RPredownloadButton
		{
			get
			{
				if(r_PredownloadButton == null)
				{
					r_PredownloadButton = new(this, "redownloadButton", -1);
				}
				return r_PredownloadButton;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Button cancelButton
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton r_PcancelButton;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton RPcancelButton
		{
			get
			{
				if(r_PcancelButton == null)
				{
					r_PcancelButton = new(this, "cancelButton", -1);
				}
				return r_PcancelButton;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Button pauseButton
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton r_PpauseButton;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton RPpauseButton
		{
			get
			{
				if(r_PpauseButton == null)
				{
					r_PpauseButton = new(this, "pauseButton", -1);
				}
				return r_PpauseButton;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Button resumeButton
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton r_PresumeButton;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton RPresumeButton
		{
			get
			{
				if(r_PresumeButton == null)
				{
					r_PresumeButton = new(this, "resumeButton", -1);
				}
				return r_PresumeButton;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Button signInButton
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton r_PsignInButton;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton RPsignInButton
		{
			get
			{
				if(r_PsignInButton == null)
				{
					r_PsignInButton = new(this, "signInButton", -1);
				}
				return r_PsignInButton;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.ProgressBar downloadProgress
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RProgressBar r_PdownloadProgress;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RProgressBar RPdownloadProgress
		{
			get
			{
				if(r_PdownloadProgress == null)
				{
					r_PdownloadProgress = new(this, "downloadProgress", -1);
				}
				return r_PdownloadProgress;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement packageToolbarErrorContainer
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PpackageToolbarErrorContainer;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPpackageToolbarErrorContainer
		{
			get
			{
				if(r_PpackageToolbarErrorContainer == null)
				{
					r_PpackageToolbarErrorContainer = new(this, "packageToolbarErrorContainer", -1);
				}
				return r_PpackageToolbarErrorContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Label errorMessage
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLabel r_PerrorMessage;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLabel RPerrorMessage
		{
			get
			{
				if(r_PerrorMessage == null)
				{
					r_PerrorMessage = new(this, "errorMessage", -1);
				}
				return r_PerrorMessage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Label errorStatus
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLabel r_PerrorStatus;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLabel RPerrorStatus
		{
			get
			{
				if(r_PerrorStatus == null)
				{
					r_PerrorStatus = new(this, "errorStatus", -1);
				}
				return r_PerrorStatus;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Button okButton
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton r_PokButton;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton RPokButton
		{
			get
			{
				if(r_PokButton == null)
				{
					r_PokButton = new(this, "okButton", -1);
				}
				return r_PokButton;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.FeatureDependencies featureDependencies
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFeatureDependencies r_PfeatureDependencies;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFeatureDependencies RPfeatureDependencies
		{
			get
			{
				if(r_PfeatureDependencies == null)
				{
					r_PfeatureDependencies = new(this, "featureDependencies", -1);
				}
				return r_PfeatureDependencies;
			}
		}

		/// <summary>
		/// Boolean hasRunningAnimations
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasRunningAnimations;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasRunningAnimations
		{
			get
			{
				if(r_PhasRunningAnimations == null)
				{
					r_PhasRunningAnimations = new(this, "hasRunningAnimations", -1);
				}
				return r_PhasRunningAnimations;
			}
		}

		/// <summary>
		/// Boolean hasCompletedAnimations
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasCompletedAnimations;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasCompletedAnimations
		{
			get
			{
				if(r_PhasCompletedAnimations == null)
				{
					r_PhasCompletedAnimations = new(this, "hasCompletedAnimations", -1);
				}
				return r_PhasCompletedAnimations;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IStylePropertyAnimations styleAnimation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIStylePropertyAnimations r_PstyleAnimation;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIStylePropertyAnimations RPstyleAnimation
		{
			get
			{
				if(r_PstyleAnimation == null)
				{
					r_PstyleAnimation = new(this, "styleAnimation", -1);
				}
				return r_PstyleAnimation;
			}
		}

		/// <summary>
		/// Boolean isCompositeRoot
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisCompositeRoot;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisCompositeRoot
		{
			get
			{
				if(r_PisCompositeRoot == null)
				{
					r_PisCompositeRoot = new(this, "isCompositeRoot", -1);
				}
				return r_PisCompositeRoot;
			}
		}

		/// <summary>
		/// Boolean isHierarchyDisplayed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisHierarchyDisplayed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisHierarchyDisplayed
		{
			get
			{
				if(r_PisHierarchyDisplayed == null)
				{
					r_PisHierarchyDisplayed = new(this, "isHierarchyDisplayed", -1);
				}
				return r_PisHierarchyDisplayed;
			}
		}

		/// <summary>
		/// System.String viewDataKey
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PviewDataKey;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPviewDataKey
		{
			get
			{
				if(r_PviewDataKey == null)
				{
					r_PviewDataKey = new(this, "viewDataKey", -1);
				}
				return r_PviewDataKey;
			}
		}

		/// <summary>
		/// Boolean enableViewDataPersistence
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PenableViewDataPersistence;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPenableViewDataPersistence
		{
			get
			{
				if(r_PenableViewDataPersistence == null)
				{
					r_PenableViewDataPersistence = new(this, "enableViewDataPersistence", -1);
				}
				return r_PenableViewDataPersistence;
			}
		}

		/// <summary>
		/// System.Object userData
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PuserData;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPuserData
		{
			get
			{
				if(r_PuserData == null)
				{
					r_PuserData = new(this, "userData", -1);
				}
				return r_PuserData;
			}
		}

		/// <summary>
		/// Boolean canGrabFocus
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PcanGrabFocus;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPcanGrabFocus
		{
			get
			{
				if(r_PcanGrabFocus == null)
				{
					r_PcanGrabFocus = new(this, "canGrabFocus", -1);
				}
				return r_PcanGrabFocus;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FocusController focusController
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusController r_PfocusController;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusController RPfocusController
		{
			get
			{
				if(r_PfocusController == null)
				{
					r_PfocusController = new(this, "focusController", -1);
				}
				return r_PfocusController;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UsageHints usageHints
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUsageHints r_PusageHints;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUsageHints RPusageHints
		{
			get
			{
				if(r_PusageHints == null)
				{
					r_PusageHints = new(this, "usageHints", -1);
				}
				return r_PusageHints;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.RenderHints renderHints
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRenderHints r_PrenderHints;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRenderHints RPrenderHints
		{
			get
			{
				if(r_PrenderHints == null)
				{
					r_PrenderHints = new(this, "renderHints", -1);
				}
				return r_PrenderHints;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ITransform transform
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RITransform r_Ptransform;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RITransform RPtransform
		{
			get
			{
				if(r_Ptransform == null)
				{
					r_Ptransform = new(this, "transform", -1);
				}
				return r_Ptransform;
			}
		}

		/// <summary>
		/// Boolean isLayoutManual
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisLayoutManual;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisLayoutManual
		{
			get
			{
				if(r_PisLayoutManual == null)
				{
					r_PisLayoutManual = new(this, "isLayoutManual", -1);
				}
				return r_PisLayoutManual;
			}
		}

		/// <summary>
		/// Single scaledPixelsPerPoint
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PscaledPixelsPerPoint;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPscaledPixelsPerPoint
		{
			get
			{
				if(r_PscaledPixelsPerPoint == null)
				{
					r_PscaledPixelsPerPoint = new(this, "scaledPixelsPerPoint", -1);
				}
				return r_PscaledPixelsPerPoint;
			}
		}

		/// <summary>
		/// UnityEngine.Rect layout
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Playout;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPlayout
		{
			get
			{
				if(r_Playout == null)
				{
					r_Playout = new(this, "layout", -1);
				}
				return r_Playout;
			}
		}

		/// <summary>
		/// UnityEngine.Rect contentRect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PcontentRect;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPcontentRect
		{
			get
			{
				if(r_PcontentRect == null)
				{
					r_PcontentRect = new(this, "contentRect", -1);
				}
				return r_PcontentRect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect paddingRect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PpaddingRect;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPpaddingRect
		{
			get
			{
				if(r_PpaddingRect == null)
				{
					r_PpaddingRect = new(this, "paddingRect", -1);
				}
				return r_PpaddingRect;
			}
		}

		/// <summary>
		/// Boolean isBoundingBoxDirty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisBoundingBoxDirty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisBoundingBoxDirty
		{
			get
			{
				if(r_PisBoundingBoxDirty == null)
				{
					r_PisBoundingBoxDirty = new(this, "isBoundingBoxDirty", -1);
				}
				return r_PisBoundingBoxDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldBoundingBoxDirty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisWorldBoundingBoxDirty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisWorldBoundingBoxDirty
		{
			get
			{
				if(r_PisWorldBoundingBoxDirty == null)
				{
					r_PisWorldBoundingBoxDirty = new(this, "isWorldBoundingBoxDirty", -1);
				}
				return r_PisWorldBoundingBoxDirty;
			}
		}

		/// <summary>
		/// UnityEngine.Rect boundingBox
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PboundingBox;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPboundingBox
		{
			get
			{
				if(r_PboundingBox == null)
				{
					r_PboundingBox = new(this, "boundingBox", -1);
				}
				return r_PboundingBox;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldBoundingBox
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PworldBoundingBox;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPworldBoundingBox
		{
			get
			{
				if(r_PworldBoundingBox == null)
				{
					r_PworldBoundingBox = new(this, "worldBoundingBox", -1);
				}
				return r_PworldBoundingBox;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldBound
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PworldBound;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPworldBound
		{
			get
			{
				if(r_PworldBound == null)
				{
					r_PworldBound = new(this, "worldBound", -1);
				}
				return r_PworldBound;
			}
		}

		/// <summary>
		/// UnityEngine.Rect localBound
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PlocalBound;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPlocalBound
		{
			get
			{
				if(r_PlocalBound == null)
				{
					r_PlocalBound = new(this, "localBound", -1);
				}
				return r_PlocalBound;
			}
		}

		/// <summary>
		/// UnityEngine.Rect rect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Prect;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPrect
		{
			get
			{
				if(r_Prect == null)
				{
					r_Prect = new(this, "rect", -1);
				}
				return r_Prect;
			}
		}

		/// <summary>
		/// Boolean isWorldTransformDirty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisWorldTransformDirty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisWorldTransformDirty
		{
			get
			{
				if(r_PisWorldTransformDirty == null)
				{
					r_PisWorldTransformDirty = new(this, "isWorldTransformDirty", -1);
				}
				return r_PisWorldTransformDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldTransformInverseDirty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisWorldTransformInverseDirty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisWorldTransformInverseDirty
		{
			get
			{
				if(r_PisWorldTransformInverseDirty == null)
				{
					r_PisWorldTransformInverseDirty = new(this, "isWorldTransformInverseDirty", -1);
				}
				return r_PisWorldTransformInverseDirty;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 worldTransform
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_PworldTransform;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 RPworldTransform
		{
			get
			{
				if(r_PworldTransform == null)
				{
					r_PworldTransform = new(this, "worldTransform", -1);
				}
				return r_PworldTransform;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4& worldTransformRef
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_PworldTransformRef;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 RPworldTransformRef
		{
			get
			{
				if(r_PworldTransformRef == null)
				{
					r_PworldTransformRef = new(this, "worldTransformRef", -1);
				}
				return r_PworldTransformRef;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4& worldTransformInverse
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_PworldTransformInverse;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 RPworldTransformInverse
		{
			get
			{
				if(r_PworldTransformInverse == null)
				{
					r_PworldTransformInverse = new(this, "worldTransformInverse", -1);
				}
				return r_PworldTransformInverse;
			}
		}

		/// <summary>
		/// Boolean isWorldClipDirty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisWorldClipDirty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisWorldClipDirty
		{
			get
			{
				if(r_PisWorldClipDirty == null)
				{
					r_PisWorldClipDirty = new(this, "isWorldClipDirty", -1);
				}
				return r_PisWorldClipDirty;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldClip
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PworldClip;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPworldClip
		{
			get
			{
				if(r_PworldClip == null)
				{
					r_PworldClip = new(this, "worldClip", -1);
				}
				return r_PworldClip;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldClipMinusGroup
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PworldClipMinusGroup;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPworldClipMinusGroup
		{
			get
			{
				if(r_PworldClipMinusGroup == null)
				{
					r_PworldClipMinusGroup = new(this, "worldClipMinusGroup", -1);
				}
				return r_PworldClipMinusGroup;
			}
		}

		/// <summary>
		/// Boolean worldClipIsInfinite
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PworldClipIsInfinite;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPworldClipIsInfinite
		{
			get
			{
				if(r_PworldClipIsInfinite == null)
				{
					r_PworldClipIsInfinite = new(this, "worldClipIsInfinite", -1);
				}
				return r_PworldClipIsInfinite;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PseudoStates pseudoStates
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPseudoStates r_PpseudoStates;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPseudoStates RPpseudoStates
		{
			get
			{
				if(r_PpseudoStates == null)
				{
					r_PpseudoStates = new(this, "pseudoStates", -1);
				}
				return r_PpseudoStates;
			}
		}

		/// <summary>
		/// Int32 containedPointerIds
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PcontainedPointerIds;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPcontainedPointerIds
		{
			get
			{
				if(r_PcontainedPointerIds == null)
				{
					r_PcontainedPointerIds = new(this, "containedPointerIds", -1);
				}
				return r_PcontainedPointerIds;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PickingMode pickingMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPickingMode r_PpickingMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPickingMode RPpickingMode
		{
			get
			{
				if(r_PpickingMode == null)
				{
					r_PpickingMode = new(this, "pickingMode", -1);
				}
				return r_PpickingMode;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] classList
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> r_PclassList;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> RPclassList
		{
			get
			{
				if(r_PclassList == null)
				{
					r_PclassList = new(this, "classList", -1);
				}
				return r_PclassList;
			}
		}

		/// <summary>
		/// System.String fullTypeName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PfullTypeName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPfullTypeName
		{
			get
			{
				if(r_PfullTypeName == null)
				{
					r_PfullTypeName = new(this, "fullTypeName", -1);
				}
				return r_PfullTypeName;
			}
		}

		/// <summary>
		/// System.String typeName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PtypeName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtypeName
		{
			get
			{
				if(r_PtypeName == null)
				{
					r_PtypeName = new(this, "typeName", -1);
				}
				return r_PtypeName;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaNode yogaNode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaNode r_PyogaNode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaNode RPyogaNode
		{
			get
			{
				if(r_PyogaNode == null)
				{
					r_PyogaNode = new(this, "yogaNode", -1);
				}
				return r_PyogaNode;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ComputedStyle& computedStyle
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle r_PcomputedStyle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle RPcomputedStyle
		{
			get
			{
				if(r_PcomputedStyle == null)
				{
					r_PcomputedStyle = new(this, "computedStyle", -1);
				}
				return r_PcomputedStyle;
			}
		}

		/// <summary>
		/// Boolean hasInlineStyle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasInlineStyle;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasInlineStyle
		{
			get
			{
				if(r_PhasInlineStyle == null)
				{
					r_PhasInlineStyle = new(this, "hasInlineStyle", -1);
				}
				return r_PhasInlineStyle;
			}
		}

		/// <summary>
		/// Boolean styleInitialized
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PstyleInitialized;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPstyleInitialized
		{
			get
			{
				if(r_PstyleInitialized == null)
				{
					r_PstyleInitialized = new(this, "styleInitialized", -1);
				}
				return r_PstyleInitialized;
			}
		}

		/// <summary>
		/// Single opacity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Popacity;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPopacity
		{
			get
			{
				if(r_Popacity == null)
				{
					r_Popacity = new(this, "opacity", -1);
				}
				return r_Popacity;
			}
		}

		/// <summary>
		/// Boolean enabledInHierarchy
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PenabledInHierarchy;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPenabledInHierarchy
		{
			get
			{
				if(r_PenabledInHierarchy == null)
				{
					r_PenabledInHierarchy = new(this, "enabledInHierarchy", -1);
				}
				return r_PenabledInHierarchy;
			}
		}

		/// <summary>
		/// Boolean enabledSelf
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PenabledSelf;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPenabledSelf
		{
			get
			{
				if(r_PenabledSelf == null)
				{
					r_PenabledSelf = new(this, "enabledSelf", -1);
				}
				return r_PenabledSelf;
			}
		}

		/// <summary>
		/// Boolean visible
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pvisible;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPvisible
		{
			get
			{
				if(r_Pvisible == null)
				{
					r_Pvisible = new(this, "visible", -1);
				}
				return r_Pvisible;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.MeshGenerationContext] generateVisualContent
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContext> r_PgenerateVisualContent;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContext> RPgenerateVisualContent
		{
			get
			{
				if(r_PgenerateVisualContent == null)
				{
					r_PgenerateVisualContent = new(this, "generateVisualContent", -1);
				}
				return r_PgenerateVisualContent;
			}
		}

		/// <summary>
		/// Boolean requireMeasureFunction
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PrequireMeasureFunction;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPrequireMeasureFunction
		{
			get
			{
				if(r_PrequireMeasureFunction == null)
				{
					r_PrequireMeasureFunction = new(this, "requireMeasureFunction", -1);
				}
				return r_PrequireMeasureFunction;
			}
		}

		/// <summary>
		/// RenderTargetMode subRenderTargetMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RRenderTargetMode r_PsubRenderTargetMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RRenderTargetMode RPsubRenderTargetMode
		{
			get
			{
				if(r_PsubRenderTargetMode == null)
				{
					r_PsubRenderTargetMode = new(this, "subRenderTargetMode", -1);
				}
				return r_PsubRenderTargetMode;
			}
		}

		/// <summary>
		/// UnityEngine.Material defaultMaterial
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMaterial r_PdefaultMaterial;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMaterial RPdefaultMaterial
		{
			get
			{
				if(r_PdefaultMaterial == null)
				{
					r_PdefaultMaterial = new(this, "defaultMaterial", -1);
				}
				return r_PdefaultMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IExperimentalFeatures experimental
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIExperimentalFeatures r_Pexperimental;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIExperimentalFeatures RPexperimental
		{
			get
			{
				if(r_Pexperimental == null)
				{
					r_Pexperimental = new(this, "experimental", -1);
				}
				return r_Pexperimental;
			}
		}

		/// <summary>
		/// Hierarchy hierarchy
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RHierarchy r_Phierarchy;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RHierarchy RPhierarchy
		{
			get
			{
				if(r_Phierarchy == null)
				{
					r_Phierarchy = new(this, "hierarchy", -1);
				}
				return r_Phierarchy;
			}
		}

		/// <summary>
		/// Boolean isRootVisualContainer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisRootVisualContainer;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisRootVisualContainer
		{
			get
			{
				if(r_PisRootVisualContainer == null)
				{
					r_PisRootVisualContainer = new(this, "isRootVisualContainer", -1);
				}
				return r_PisRootVisualContainer;
			}
		}

		/// <summary>
		/// Boolean cacheAsBitmap
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PcacheAsBitmap;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPcacheAsBitmap
		{
			get
			{
				if(r_PcacheAsBitmap == null)
				{
					r_PcacheAsBitmap = new(this, "cacheAsBitmap", -1);
				}
				return r_PcacheAsBitmap;
			}
		}

		/// <summary>
		/// Boolean disableClipping
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PdisableClipping;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdisableClipping
		{
			get
			{
				if(r_PdisableClipping == null)
				{
					r_PdisableClipping = new(this, "disableClipping", -1);
				}
				return r_PdisableClipping;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement parent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Pparent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPparent
		{
			get
			{
				if(r_Pparent == null)
				{
					r_Pparent = new(this, "parent", -1);
				}
				return r_Pparent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BaseVisualElementPanel elementPanel
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVisualElementPanel r_PelementPanel;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVisualElementPanel RPelementPanel
		{
			get
			{
				if(r_PelementPanel == null)
				{
					r_PelementPanel = new(this, "elementPanel", -1);
				}
				return r_PelementPanel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IPanel panel
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel r_Ppanel;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel RPpanel
		{
			get
			{
				if(r_Ppanel == null)
				{
					r_Ppanel = new(this, "panel", -1);
				}
				return r_Ppanel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement contentContainer
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PcontentContainer;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPcontentContainer
		{
			get
			{
				if(r_PcontentContainer == null)
				{
					r_PcontentContainer = new(this, "contentContainer", -1);
				}
				return r_PcontentContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset visualTreeAssetSource
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset r_PvisualTreeAssetSource;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset RPvisualTreeAssetSource
		{
			get
			{
				if(r_PvisualTreeAssetSource == null)
				{
					r_PvisualTreeAssetSource = new(this, "visualTreeAssetSource", -1);
				}
				return r_PvisualTreeAssetSource;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PItem_Int32;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPItem_Int32
		{
			get
			{
				if(r_PItem_Int32 == null)
				{
					r_PItem_Int32 = new(this, "Item", -1, typeof(System.Int32));
				}
				return r_PItem_Int32;
			}
		}

		/// <summary>
		/// Int32 childCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PchildCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPchildCount
		{
			get
			{
				if(r_PchildCount == null)
				{
					r_PchildCount = new(this, "childCount", -1);
				}
				return r_PchildCount;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ILiveReloadAssetTracker`1[UnityEngine.UIElements.VisualTreeAsset] visualTreeAssetTracker
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RILiveReloadAssetTracker<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset> r_PvisualTreeAssetTracker;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RILiveReloadAssetTracker<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset> RPvisualTreeAssetTracker
		{
			get
			{
				if(r_PvisualTreeAssetTracker == null)
				{
					r_PvisualTreeAssetTracker = new(this, "visualTreeAssetTracker", -1);
				}
				return r_PvisualTreeAssetTracker;
			}
		}

		/// <summary>
		/// Boolean hasDefaultRotationAndScale
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasDefaultRotationAndScale;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasDefaultRotationAndScale
		{
			get
			{
				if(r_PhasDefaultRotationAndScale == null)
				{
					r_PhasDefaultRotationAndScale = new(this, "hasDefaultRotationAndScale", -1);
				}
				return r_PhasDefaultRotationAndScale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduler schedule
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualElementScheduler r_Pschedule;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualElementScheduler RPschedule
		{
			get
			{
				if(r_Pschedule == null)
				{
					r_Pschedule = new(this, "schedule", -1);
				}
				return r_Pschedule;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IStyle style
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIStyle r_Pstyle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIStyle RPstyle
		{
			get
			{
				if(r_Pstyle == null)
				{
					r_Pstyle = new(this, "style", -1);
				}
				return r_Pstyle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ICustomStyle customStyle
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RICustomStyle r_PcustomStyle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RICustomStyle RPcustomStyle
		{
			get
			{
				if(r_PcustomStyle == null)
				{
					r_PcustomStyle = new(this, "customStyle", -1);
				}
				return r_PcustomStyle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementStyleSheetSet styleSheets
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementStyleSheetSet r_PstyleSheets;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementStyleSheetSet RPstyleSheets
		{
			get
			{
				if(r_PstyleSheets == null)
				{
					r_PstyleSheets = new(this, "styleSheets", -1);
				}
				return r_PstyleSheets;
			}
		}

		/// <summary>
		/// System.String tooltip
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ptooltip;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtooltip
		{
			get
			{
				if(r_Ptooltip == null)
				{
					r_Ptooltip = new(this, "tooltip", -1);
				}
				return r_Ptooltip;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IResolvedStyle resolvedStyle
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIResolvedStyle r_PresolvedStyle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIResolvedStyle RPresolvedStyle
		{
			get
			{
				if(r_PresolvedStyle == null)
				{
					r_PresolvedStyle = new(this, "resolvedStyle", -1);
				}
				return r_PresolvedStyle;
			}
		}

		/// <summary>
		/// Boolean focusable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pfocusable;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPfocusable
		{
			get
			{
				if(r_Pfocusable == null)
				{
					r_Pfocusable = new(this, "focusable", -1);
				}
				return r_Pfocusable;
			}
		}

		/// <summary>
		/// Int32 tabIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PtabIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPtabIndex
		{
			get
			{
				if(r_PtabIndex == null)
				{
					r_PtabIndex = new(this, "tabIndex", -1);
				}
				return r_PtabIndex;
			}
		}

		/// <summary>
		/// Boolean delegatesFocus
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PdelegatesFocus;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdelegatesFocus
		{
			get
			{
				if(r_PdelegatesFocus == null)
				{
					r_PdelegatesFocus = new(this, "delegatesFocus", -1);
				}
				return r_PdelegatesFocus;
			}
		}

		/// <summary>
		/// Boolean excludeFromFocusRing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PexcludeFromFocusRing;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPexcludeFromFocusRing
		{
			get
			{
				if(r_PexcludeFromFocusRing == null)
				{
					r_PexcludeFromFocusRing = new(this, "excludeFromFocusRing", -1);
				}
				return r_PexcludeFromFocusRing;
			}
		}

		/// <summary>
		/// Void ResolveDependencies()
		/// </summary>
		protected RMethod r_MResolveDependencies;
		public virtual RMethod RMResolveDependencies
		{
			get
			{
				if(r_MResolveDependencies == null)
				{
					r_MResolveDependencies = new(this, "ResolveDependencies", 0);
				}
				return r_MResolveDependencies;
			}
		}

		/// <summary>
		/// Void RecalculateFillerHeight(UnityEngine.UIElements.GeometryChangedEvent)
		/// </summary>
		protected RMethod r_MRecalculateFillerHeight_GeometryChangedEvent;
		public virtual RMethod RMRecalculateFillerHeight_GeometryChangedEvent
		{
			get
			{
				if(r_MRecalculateFillerHeight_GeometryChangedEvent == null)
				{
					r_MRecalculateFillerHeight_GeometryChangedEvent = new(this, "RecalculateFillerHeight", 0, typeof(UnityEngine.UIElements.GeometryChangedEvent));
				}
				return r_MRecalculateFillerHeight_GeometryChangedEvent;
			}
		}

		/// <summary>
		/// Void OnDetailScroll(Single)
		/// </summary>
		protected RMethod r_MOnDetailScroll_Single;
		public virtual RMethod RMOnDetailScroll_Single
		{
			get
			{
				if(r_MOnDetailScroll_Single == null)
				{
					r_MOnDetailScroll_Single = new(this, "OnDetailScroll", 0, typeof(System.Single));
				}
				return r_MOnDetailScroll_Single;
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
		/// Void OnTermOfServiceAgreementStatusChange(UnityEditor.PackageManager.UI.Internal.TermOfServiceAgreementStatus)
		/// </summary>
		protected RMethod r_MOnTermOfServiceAgreementStatusChange_TermOfServiceAgreementStatus;
		public virtual RMethod RMOnTermOfServiceAgreementStatusChange_TermOfServiceAgreementStatus
		{
			get
			{
				if(r_MOnTermOfServiceAgreementStatusChange_TermOfServiceAgreementStatus == null)
				{
					r_MOnTermOfServiceAgreementStatusChange_TermOfServiceAgreementStatus = new(this, "OnTermOfServiceAgreementStatusChange", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.TermOfServiceAgreementStatus"));
				}
				return r_MOnTermOfServiceAgreementStatusChange_TermOfServiceAgreementStatus;
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
		/// Void OnInternetReachabilityChange(Boolean)
		/// </summary>
		protected RMethod r_MOnInternetReachabilityChange_Boolean;
		public virtual RMethod RMOnInternetReachabilityChange_Boolean
		{
			get
			{
				if(r_MOnInternetReachabilityChange_Boolean == null)
				{
					r_MOnInternetReachabilityChange_Boolean = new(this, "OnInternetReachabilityChange", 0, typeof(System.Boolean));
				}
				return r_MOnInternetReachabilityChange_Boolean;
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
		/// Void UpdateDownloadProgressBar(UnityEditor.PackageManager.UI.Internal.IOperation)
		/// </summary>
		protected RMethod r_MUpdateDownloadProgressBar_IOperation;
		public virtual RMethod RMUpdateDownloadProgressBar_IOperation
		{
			get
			{
				if(r_MUpdateDownloadProgressBar_IOperation == null)
				{
					r_MUpdateDownloadProgressBar_IOperation = new(this, "UpdateDownloadProgressBar", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"));
				}
				return r_MUpdateDownloadProgressBar_IOperation;
			}
		}

		/// <summary>
		/// Void StopDownloadProgressBar(UnityEditor.PackageManager.UI.Internal.IOperation)
		/// </summary>
		protected RMethod r_MStopDownloadProgressBar_IOperation;
		public virtual RMethod RMStopDownloadProgressBar_IOperation
		{
			get
			{
				if(r_MStopDownloadProgressBar_IOperation == null)
				{
					r_MStopDownloadProgressBar_IOperation = new(this, "StopDownloadProgressBar", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"));
				}
				return r_MStopDownloadProgressBar_IOperation;
			}
		}

		/// <summary>
		/// Void PauseDownloadProgressBar(UnityEditor.PackageManager.UI.Internal.IOperation)
		/// </summary>
		protected RMethod r_MPauseDownloadProgressBar_IOperation;
		public virtual RMethod RMPauseDownloadProgressBar_IOperation
		{
			get
			{
				if(r_MPauseDownloadProgressBar_IOperation == null)
				{
					r_MPauseDownloadProgressBar_IOperation = new(this, "PauseDownloadProgressBar", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"));
				}
				return r_MPauseDownloadProgressBar_IOperation;
			}
		}

		/// <summary>
		/// Void SetContentVisibility(Boolean)
		/// </summary>
		protected RMethod r_MSetContentVisibility_Boolean;
		public virtual RMethod RMSetContentVisibility_Boolean
		{
			get
			{
				if(r_MSetContentVisibility_Boolean == null)
				{
					r_MSetContentVisibility_Boolean = new(this, "SetContentVisibility", 0, typeof(System.Boolean));
				}
				return r_MSetContentVisibility_Boolean;
			}
		}

		/// <summary>
		/// Void SetToolBarVisibility(Boolean)
		/// </summary>
		protected RMethod r_MSetToolBarVisibility_Boolean;
		public virtual RMethod RMSetToolBarVisibility_Boolean
		{
			get
			{
				if(r_MSetToolBarVisibility_Boolean == null)
				{
					r_MSetToolBarVisibility_Boolean = new(this, "SetToolBarVisibility", 0, typeof(System.Boolean));
				}
				return r_MSetToolBarVisibility_Boolean;
			}
		}

		/// <summary>
		/// Void OnSelectionChanged(UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MOnSelectionChanged_IPackageVersion;
		public virtual RMethod RMOnSelectionChanged_IPackageVersion
		{
			get
			{
				if(r_MOnSelectionChanged_IPackageVersion == null)
				{
					r_MOnSelectionChanged_IPackageVersion = new(this, "OnSelectionChanged", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
				}
				return r_MOnSelectionChanged_IPackageVersion;
			}
		}

		/// <summary>
		/// Void RefreshUI(UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MRefreshUI_IPackageVersion;
		public virtual RMethod RMRefreshUI_IPackageVersion
		{
			get
			{
				if(r_MRefreshUI_IPackageVersion == null)
				{
					r_MRefreshUI_IPackageVersion = new(this, "RefreshUI", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
				}
				return r_MRefreshUI_IPackageVersion;
			}
		}

		/// <summary>
		/// Void RefreshExtensions(UnityEditor.PackageManager.UI.Internal.IPackage, UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MRefreshExtensions_IPackage_IPackageVersion;
		public virtual RMethod RMRefreshExtensions_IPackage_IPackageVersion
		{
			get
			{
				if(r_MRefreshExtensions_IPackage_IPackageVersion == null)
				{
					r_MRefreshExtensions_IPackage_IPackageVersion = new(this, "RefreshExtensions", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
				}
				return r_MRefreshExtensions_IPackage_IPackageVersion;
			}
		}

		/// <summary>
		/// Void RefreshContent()
		/// </summary>
		protected RMethod r_MRefreshContent;
		public virtual RMethod RMRefreshContent
		{
			get
			{
				if(r_MRefreshContent == null)
				{
					r_MRefreshContent = new(this, "RefreshContent", 0);
				}
				return r_MRefreshContent;
			}
		}

		/// <summary>
		/// Void RefreshEntitlement()
		/// </summary>
		protected RMethod r_MRefreshEntitlement;
		public virtual RMethod RMRefreshEntitlement
		{
			get
			{
				if(r_MRefreshEntitlement == null)
				{
					r_MRefreshEntitlement = new(this, "RefreshEntitlement", 0);
				}
				return r_MRefreshEntitlement;
			}
		}

		/// <summary>
		/// Void SetPackage(UnityEditor.PackageManager.UI.Internal.IPackage, UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MSetPackage_IPackage_IPackageVersion;
		public virtual RMethod RMSetPackage_IPackage_IPackageVersion
		{
			get
			{
				if(r_MSetPackage_IPackage_IPackageVersion == null)
				{
					r_MSetPackage_IPackage_IPackageVersion = new(this, "SetPackage", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
				}
				return r_MSetPackage_IPackage_IPackageVersion;
			}
		}

		/// <summary>
		/// Void OnVerifiedGitPackageUpToDate(UnityEditor.PackageManager.UI.Internal.IPackage)
		/// </summary>
		protected RMethod r_MOnVerifiedGitPackageUpToDate_IPackage;
		public virtual RMethod RMOnVerifiedGitPackageUpToDate_IPackage
		{
			get
			{
				if(r_MOnVerifiedGitPackageUpToDate_IPackage == null)
				{
					r_MOnVerifiedGitPackageUpToDate_IPackage = new(this, "OnVerifiedGitPackageUpToDate", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"));
				}
				return r_MOnVerifiedGitPackageUpToDate_IPackage;
			}
		}

		/// <summary>
		/// Void OnPackagesUpdated(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage])
		/// </summary>
		protected RMethod r_MOnPackagesUpdated_IEnumerable_d_IPackage_p_;
		public virtual RMethod RMOnPackagesUpdated_IEnumerable_d_IPackage_p_
		{
			get
			{
				if(r_MOnPackagesUpdated_IEnumerable_d_IPackage_p_ == null)
				{
					r_MOnPackagesUpdated_IEnumerable_d_IPackage_p_ = new(this, "OnPackagesUpdated", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage")));
				}
				return r_MOnPackagesUpdated_IEnumerable_d_IPackage_p_;
			}
		}

		/// <summary>
		/// Void OnPackagesUpdated(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage], System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage], System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage], System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage])
		/// </summary>
		protected RMethod r_MOnPackagesUpdated_IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p_;
		public virtual RMethod RMOnPackagesUpdated_IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p_
		{
			get
			{
				if(r_MOnPackagesUpdated_IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p_ == null)
				{
					r_MOnPackagesUpdated_IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p_ = new(this, "OnPackagesUpdated", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage")),  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage")),  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage")),  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage")));
				}
				return r_MOnPackagesUpdated_IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p_;
			}
		}

		/// <summary>
		/// Void RefreshErrorDisplay()
		/// </summary>
		protected RMethod r_MRefreshErrorDisplay;
		public virtual RMethod RMRefreshErrorDisplay
		{
			get
			{
				if(r_MRefreshErrorDisplay == null)
				{
					r_MRefreshErrorDisplay = new(this, "RefreshErrorDisplay", 0);
				}
				return r_MRefreshErrorDisplay;
			}
		}

		/// <summary>
		/// Void ClearError()
		/// </summary>
		protected RMethod r_MClearError;
		public virtual RMethod RMClearError
		{
			get
			{
				if(r_MClearError == null)
				{
					r_MClearError = new(this, "ClearError", 0);
				}
				return r_MClearError;
			}
		}

		/// <summary>
		/// Void SetError(System.String, UnityEditor.PackageManager.UI.Internal.PackageState)
		/// </summary>
		protected RMethod r_MSetError_String_PackageState;
		public virtual RMethod RMSetError_String_PackageState
		{
			get
			{
				if(r_MSetError_String_PackageState == null)
				{
					r_MSetError_String_PackageState = new(this, "SetError", 0, typeof(System.String),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageState"));
				}
				return r_MSetError_String_PackageState;
			}
		}

		/// <summary>
		/// Void OnPackageProgressUpdate(UnityEditor.PackageManager.UI.Internal.IPackage)
		/// </summary>
		protected RMethod r_MOnPackageProgressUpdate_IPackage;
		public virtual RMethod RMOnPackageProgressUpdate_IPackage
		{
			get
			{
				if(r_MOnPackageProgressUpdate_IPackage == null)
				{
					r_MOnPackageProgressUpdate_IPackage = new(this, "OnPackageProgressUpdate", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"));
				}
				return r_MOnPackageProgressUpdate_IPackage;
			}
		}

		/// <summary>
		/// Void RefreshPackageActionButtons()
		/// </summary>
		protected RMethod r_MRefreshPackageActionButtons;
		public virtual RMethod RMRefreshPackageActionButtons
		{
			get
			{
				if(r_MRefreshPackageActionButtons == null)
				{
					r_MRefreshPackageActionButtons = new(this, "RefreshPackageActionButtons", 0);
				}
				return r_MRefreshPackageActionButtons;
			}
		}

		/// <summary>
		/// Void RefreshAddButton()
		/// </summary>
		protected RMethod r_MRefreshAddButton;
		public virtual RMethod RMRefreshAddButton
		{
			get
			{
				if(r_MRefreshAddButton == null)
				{
					r_MRefreshAddButton = new(this, "RefreshAddButton", 0);
				}
				return r_MRefreshAddButton;
			}
		}

		/// <summary>
		/// Void RefreshToolbarExtensionsStatusAndTooltip()
		/// </summary>
		protected RMethod r_MRefreshToolbarExtensionsStatusAndTooltip;
		public virtual RMethod RMRefreshToolbarExtensionsStatusAndTooltip
		{
			get
			{
				if(r_MRefreshToolbarExtensionsStatusAndTooltip == null)
				{
					r_MRefreshToolbarExtensionsStatusAndTooltip = new(this, "RefreshToolbarExtensionsStatusAndTooltip", 0);
				}
				return r_MRefreshToolbarExtensionsStatusAndTooltip;
			}
		}

		/// <summary>
		/// Void RefreshRemoveButton()
		/// </summary>
		protected RMethod r_MRefreshRemoveButton;
		public virtual RMethod RMRefreshRemoveButton
		{
			get
			{
				if(r_MRefreshRemoveButton == null)
				{
					r_MRefreshRemoveButton = new(this, "RefreshRemoveButton", 0);
				}
				return r_MRefreshRemoveButton;
			}
		}

		/// <summary>
		/// Void RefreshResetButton()
		/// </summary>
		protected RMethod r_MRefreshResetButton;
		public virtual RMethod RMRefreshResetButton
		{
			get
			{
				if(r_MRefreshResetButton == null)
				{
					r_MRefreshResetButton = new(this, "RefreshResetButton", 0);
				}
				return r_MRefreshResetButton;
			}
		}

		/// <summary>
		/// Void RefreshDownloadStatesButtons()
		/// </summary>
		protected RMethod r_MRefreshDownloadStatesButtons;
		public virtual RMethod RMRefreshDownloadStatesButtons
		{
			get
			{
				if(r_MRefreshDownloadStatesButtons == null)
				{
					r_MRefreshDownloadStatesButtons = new(this, "RefreshDownloadStatesButtons", 0);
				}
				return r_MRefreshDownloadStatesButtons;
			}
		}

		/// <summary>
		/// Void RefreshUnlockButton()
		/// </summary>
		protected RMethod r_MRefreshUnlockButton;
		public virtual RMethod RMRefreshUnlockButton
		{
			get
			{
				if(r_MRefreshUnlockButton == null)
				{
					r_MRefreshUnlockButton = new(this, "RefreshUnlockButton", 0);
				}
				return r_MRefreshUnlockButton;
			}
		}

		/// <summary>
		/// Void RefreshButtonStatusAndTooltip(UnityEngine.UIElements.VisualElement, PackageAction, ButtonDisableCondition[])
		/// </summary>
		protected RMethod r_MRefreshButtonStatusAndTooltip_VisualElement_PackageAction_ButtonDisableConditionArray;
		public virtual RMethod RMRefreshButtonStatusAndTooltip_VisualElement_PackageAction_ButtonDisableConditionArray
		{
			get
			{
				if(r_MRefreshButtonStatusAndTooltip_VisualElement_PackageAction_ButtonDisableConditionArray == null)
				{
					r_MRefreshButtonStatusAndTooltip_VisualElement_PackageAction_ButtonDisableConditionArray = new(this, "RefreshButtonStatusAndTooltip", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageDetails+PackageAction"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageDetails+ButtonDisableCondition").MakeArrayType());
				}
				return r_MRefreshButtonStatusAndTooltip_VisualElement_PackageAction_ButtonDisableConditionArray;
			}
		}

		/// <summary>
		/// Void RefreshButtonStatusAndTooltip(UnityEngine.UIElements.VisualElement, ButtonDisableCondition[])
		/// </summary>
		protected RMethod r_MRefreshButtonStatusAndTooltip_VisualElement_ButtonDisableConditionArray;
		public virtual RMethod RMRefreshButtonStatusAndTooltip_VisualElement_ButtonDisableConditionArray
		{
			get
			{
				if(r_MRefreshButtonStatusAndTooltip_VisualElement_ButtonDisableConditionArray == null)
				{
					r_MRefreshButtonStatusAndTooltip_VisualElement_ButtonDisableConditionArray = new(this, "RefreshButtonStatusAndTooltip", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageDetails+ButtonDisableCondition").MakeArrayType());
				}
				return r_MRefreshButtonStatusAndTooltip_VisualElement_ButtonDisableConditionArray;
			}
		}

		/// <summary>
		/// System.String GetButtonText(PackageAction, Boolean, System.Nullable`1[UnityEditor.Scripting.ScriptCompilation.SemVersion])
		/// </summary>
		protected static RMethod r_MGetButtonText_PackageAction_Boolean_Nullable_d_SemVersion_p_;
		public static RMethod RMGetButtonText_PackageAction_Boolean_Nullable_d_SemVersion_p_
		{
			get
			{
				if(r_MGetButtonText_PackageAction_Boolean_Nullable_d_SemVersion_p_ == null)
				{
					r_MGetButtonText_PackageAction_Boolean_Nullable_d_SemVersion_p_ = new(Type, "GetButtonText", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageDetails+PackageAction"), typeof(System.Boolean),  ReflectionUtils.GetType("System.Nullable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.Scripting.ScriptCompilation.SemVersion")));
				}
				return r_MGetButtonText_PackageAction_Boolean_Nullable_d_SemVersion_p_;
			}
		}

		/// <summary>
		/// System.String GetButtonTooltip(PackageAction)
		/// </summary>
		protected RMethod r_MGetButtonTooltip_PackageAction;
		public virtual RMethod RMGetButtonTooltip_PackageAction
		{
			get
			{
				if(r_MGetButtonTooltip_PackageAction == null)
				{
					r_MGetButtonTooltip_PackageAction = new(this, "GetButtonTooltip", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageDetails+PackageAction"));
				}
				return r_MGetButtonTooltip_PackageAction;
			}
		}

		/// <summary>
		/// Void UpdateClick()
		/// </summary>
		protected RMethod r_MUpdateClick;
		public virtual RMethod RMUpdateClick
		{
			get
			{
				if(r_MUpdateClick == null)
				{
					r_MUpdateClick = new(this, "UpdateClick", 0);
				}
				return r_MUpdateClick;
			}
		}

		/// <summary>
		/// Void RemoveClick()
		/// </summary>
		protected RMethod r_MRemoveClick;
		public virtual RMethod RMRemoveClick
		{
			get
			{
				if(r_MRemoveClick == null)
				{
					r_MRemoveClick = new(this, "RemoveClick", 0);
				}
				return r_MRemoveClick;
			}
		}

		/// <summary>
		/// Void ResetClick()
		/// </summary>
		protected RMethod r_MResetClick;
		public virtual RMethod RMResetClick
		{
			get
			{
				if(r_MResetClick == null)
				{
					r_MResetClick = new(this, "ResetClick", 0);
				}
				return r_MResetClick;
			}
		}

		/// <summary>
		/// Void ImportClick()
		/// </summary>
		protected RMethod r_MImportClick;
		public virtual RMethod RMImportClick
		{
			get
			{
				if(r_MImportClick == null)
				{
					r_MImportClick = new(this, "ImportClick", 0);
				}
				return r_MImportClick;
			}
		}

		/// <summary>
		/// Void DownloadClick()
		/// </summary>
		protected RMethod r_MDownloadClick;
		public virtual RMethod RMDownloadClick
		{
			get
			{
				if(r_MDownloadClick == null)
				{
					r_MDownloadClick = new(this, "DownloadClick", 0);
				}
				return r_MDownloadClick;
			}
		}

		/// <summary>
		/// Void DowngradeClick()
		/// </summary>
		protected RMethod r_MDowngradeClick;
		public virtual RMethod RMDowngradeClick
		{
			get
			{
				if(r_MDowngradeClick == null)
				{
					r_MDowngradeClick = new(this, "DowngradeClick", 0);
				}
				return r_MDowngradeClick;
			}
		}

		/// <summary>
		/// Void ReDownloadClick()
		/// </summary>
		protected RMethod r_MReDownloadClick;
		public virtual RMethod RMReDownloadClick
		{
			get
			{
				if(r_MReDownloadClick == null)
				{
					r_MReDownloadClick = new(this, "ReDownloadClick", 0);
				}
				return r_MReDownloadClick;
			}
		}

		/// <summary>
		/// Void DownloadClickInternal(System.String)
		/// </summary>
		protected RMethod r_MDownloadClickInternal_String;
		public virtual RMethod RMDownloadClickInternal_String
		{
			get
			{
				if(r_MDownloadClickInternal_String == null)
				{
					r_MDownloadClickInternal_String = new(this, "DownloadClickInternal", 0, typeof(System.String));
				}
				return r_MDownloadClickInternal_String;
			}
		}

		/// <summary>
		/// Void CancelClick()
		/// </summary>
		protected RMethod r_MCancelClick;
		public virtual RMethod RMCancelClick
		{
			get
			{
				if(r_MCancelClick == null)
				{
					r_MCancelClick = new(this, "CancelClick", 0);
				}
				return r_MCancelClick;
			}
		}

		/// <summary>
		/// Void PauseClick()
		/// </summary>
		protected RMethod r_MPauseClick;
		public virtual RMethod RMPauseClick
		{
			get
			{
				if(r_MPauseClick == null)
				{
					r_MPauseClick = new(this, "PauseClick", 0);
				}
				return r_MPauseClick;
			}
		}

		/// <summary>
		/// Void ResumeClick()
		/// </summary>
		protected RMethod r_MResumeClick;
		public virtual RMethod RMResumeClick
		{
			get
			{
				if(r_MResumeClick == null)
				{
					r_MResumeClick = new(this, "ResumeClick", 0);
				}
				return r_MResumeClick;
			}
		}

		/// <summary>
		/// Void UnlockClick()
		/// </summary>
		protected RMethod r_MUnlockClick;
		public virtual RMethod RMUnlockClick
		{
			get
			{
				if(r_MUnlockClick == null)
				{
					r_MUnlockClick = new(this, "UnlockClick", 0);
				}
				return r_MUnlockClick;
			}
		}

		/// <summary>
		/// Void <.ctor>b__32_0()
		/// </summary>
		protected RMethod r_M__0____2__ctor__1__b__32_0;
		public virtual RMethod RM__0____2__ctor__1__b__32_0
		{
			get
			{
				if(r_M__0____2__ctor__1__b__32_0 == null)
				{
					r_M__0____2__ctor__1__b__32_0 = new(this, "<.ctor>b__32_0", 0);
				}
				return r_M__0____2__ctor__1__b__32_0;
			}
		}

		/// <summary>
		/// Void MarkRenderHintsClean()
		/// </summary>
		protected RMethod r_MMarkRenderHintsClean;
		public virtual RMethod RMMarkRenderHintsClean
		{
			get
			{
				if(r_MMarkRenderHintsClean == null)
				{
					r_MMarkRenderHintsClean = new(this, "MarkRenderHintsClean", 0);
				}
				return r_MMarkRenderHintsClean;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ComputeGlobalScale()
		/// </summary>
		protected RMethod r_MComputeGlobalScale;
		public virtual RMethod RMComputeGlobalScale
		{
			get
			{
				if(r_MComputeGlobalScale == null)
				{
					r_MComputeGlobalScale = new(this, "ComputeGlobalScale", 0);
				}
				return r_MComputeGlobalScale;
			}
		}

		/// <summary>
		/// Void UpdateBoundingBox()
		/// </summary>
		protected RMethod r_MUpdateBoundingBox;
		public virtual RMethod RMUpdateBoundingBox
		{
			get
			{
				if(r_MUpdateBoundingBox == null)
				{
					r_MUpdateBoundingBox = new(this, "UpdateBoundingBox", 0);
				}
				return r_MUpdateBoundingBox;
			}
		}

		/// <summary>
		/// Void UpdateWorldBoundingBox()
		/// </summary>
		protected RMethod r_MUpdateWorldBoundingBox;
		public virtual RMethod RMUpdateWorldBoundingBox
		{
			get
			{
				if(r_MUpdateWorldBoundingBox == null)
				{
					r_MUpdateWorldBoundingBox = new(this, "UpdateWorldBoundingBox", 0);
				}
				return r_MUpdateWorldBoundingBox;
			}
		}

		/// <summary>
		/// Void UpdateWorldTransform()
		/// </summary>
		protected RMethod r_MUpdateWorldTransform;
		public virtual RMethod RMUpdateWorldTransform
		{
			get
			{
				if(r_MUpdateWorldTransform == null)
				{
					r_MUpdateWorldTransform = new(this, "UpdateWorldTransform", 0);
				}
				return r_MUpdateWorldTransform;
			}
		}

		/// <summary>
		/// Void UpdateWorldTransformInverse()
		/// </summary>
		protected RMethod r_MUpdateWorldTransformInverse;
		public virtual RMethod RMUpdateWorldTransformInverse
		{
			get
			{
				if(r_MUpdateWorldTransformInverse == null)
				{
					r_MUpdateWorldTransformInverse = new(this, "UpdateWorldTransformInverse", 0);
				}
				return r_MUpdateWorldTransformInverse;
			}
		}

		/// <summary>
		/// Void EnsureWorldTransformAndClipUpToDate()
		/// </summary>
		protected RMethod r_MEnsureWorldTransformAndClipUpToDate;
		public virtual RMethod RMEnsureWorldTransformAndClipUpToDate
		{
			get
			{
				if(r_MEnsureWorldTransformAndClipUpToDate == null)
				{
					r_MEnsureWorldTransformAndClipUpToDate = new(this, "EnsureWorldTransformAndClipUpToDate", 0);
				}
				return r_MEnsureWorldTransformAndClipUpToDate;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MExecuteDefaultAction_EventBase;
		public virtual RMethod RMExecuteDefaultAction_EventBase
		{
			get
			{
				if(r_MExecuteDefaultAction_EventBase == null)
				{
					r_MExecuteDefaultAction_EventBase = new(this, "ExecuteDefaultAction", 0, typeof(UnityEngine.UIElements.EventBase));
				}
				return r_MExecuteDefaultAction_EventBase;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetTooltipRect()
		/// </summary>
		protected RMethod r_MGetTooltipRect;
		public virtual RMethod RMGetTooltipRect
		{
			get
			{
				if(r_MGetTooltipRect == null)
				{
					r_MGetTooltipRect = new(this, "GetTooltipRect", 0);
				}
				return r_MGetTooltipRect;
			}
		}

		/// <summary>
		/// Void Focus()
		/// </summary>
		protected RMethod r_MFocus;
		public virtual RMethod RMFocus
		{
			get
			{
				if(r_MFocus == null)
				{
					r_MFocus = new(this, "Focus", 0);
				}
				return r_MFocus;
			}
		}

		/// <summary>
		/// Void SetPanel(UnityEngine.UIElements.BaseVisualElementPanel)
		/// </summary>
		protected RMethod r_MSetPanel_BaseVisualElementPanel;
		public virtual RMethod RMSetPanel_BaseVisualElementPanel
		{
			get
			{
				if(r_MSetPanel_BaseVisualElementPanel == null)
				{
					r_MSetPanel_BaseVisualElementPanel = new(this, "SetPanel", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.BaseVisualElementPanel"));
				}
				return r_MSetPanel_BaseVisualElementPanel;
			}
		}

		/// <summary>
		/// Void SendEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MSendEvent_EventBase;
		public virtual RMethod RMSendEvent_EventBase
		{
			get
			{
				if(r_MSendEvent_EventBase == null)
				{
					r_MSendEvent_EventBase = new(this, "SendEvent", 0, typeof(UnityEngine.UIElements.EventBase));
				}
				return r_MSendEvent_EventBase;
			}
		}

		/// <summary>
		/// Void SendEvent(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.DispatchMode)
		/// </summary>
		protected RMethod r_MSendEvent_EventBase_DispatchMode;
		public virtual RMethod RMSendEvent_EventBase_DispatchMode
		{
			get
			{
				if(r_MSendEvent_EventBase_DispatchMode == null)
				{
					r_MSendEvent_EventBase_DispatchMode = new(this, "SendEvent", 0, typeof(UnityEngine.UIElements.EventBase),  ReflectionUtils.GetType("UnityEngine.UIElements.DispatchMode"));
				}
				return r_MSendEvent_EventBase_DispatchMode;
			}
		}

		/// <summary>
		/// Void IncrementVersion(UnityEngine.UIElements.VersionChangeType)
		/// </summary>
		protected RMethod r_MIncrementVersion_VersionChangeType;
		public virtual RMethod RMIncrementVersion_VersionChangeType
		{
			get
			{
				if(r_MIncrementVersion_VersionChangeType == null)
				{
					r_MIncrementVersion_VersionChangeType = new(this, "IncrementVersion", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VersionChangeType"));
				}
				return r_MIncrementVersion_VersionChangeType;
			}
		}

		/// <summary>
		/// Void InvokeHierarchyChanged(UnityEngine.UIElements.HierarchyChangeType)
		/// </summary>
		protected RMethod r_MInvokeHierarchyChanged_HierarchyChangeType;
		public virtual RMethod RMInvokeHierarchyChanged_HierarchyChangeType
		{
			get
			{
				if(r_MInvokeHierarchyChanged_HierarchyChangeType == null)
				{
					r_MInvokeHierarchyChanged_HierarchyChangeType = new(this, "InvokeHierarchyChanged", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.HierarchyChangeType"));
				}
				return r_MInvokeHierarchyChanged_HierarchyChangeType;
			}
		}

		/// <summary>
		/// Boolean SetEnabledFromHierarchy(Boolean)
		/// </summary>
		protected RMethod r_MSetEnabledFromHierarchy_Boolean;
		public virtual RMethod RMSetEnabledFromHierarchy_Boolean
		{
			get
			{
				if(r_MSetEnabledFromHierarchy_Boolean == null)
				{
					r_MSetEnabledFromHierarchy_Boolean = new(this, "SetEnabledFromHierarchy", 0, typeof(System.Boolean));
				}
				return r_MSetEnabledFromHierarchy_Boolean;
			}
		}

		/// <summary>
		/// Void SetEnabled(Boolean)
		/// </summary>
		protected RMethod r_MSetEnabled_Boolean;
		public virtual RMethod RMSetEnabled_Boolean
		{
			get
			{
				if(r_MSetEnabled_Boolean == null)
				{
					r_MSetEnabled_Boolean = new(this, "SetEnabled", 0, typeof(System.Boolean));
				}
				return r_MSetEnabled_Boolean;
			}
		}

		/// <summary>
		/// Void MarkDirtyRepaint()
		/// </summary>
		protected RMethod r_MMarkDirtyRepaint;
		public virtual RMethod RMMarkDirtyRepaint
		{
			get
			{
				if(r_MMarkDirtyRepaint == null)
				{
					r_MMarkDirtyRepaint = new(this, "MarkDirtyRepaint", 0);
				}
				return r_MMarkDirtyRepaint;
			}
		}

		/// <summary>
		/// Void InvokeGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext)
		/// </summary>
		protected RMethod r_MInvokeGenerateVisualContent_MeshGenerationContext;
		public virtual RMethod RMInvokeGenerateVisualContent_MeshGenerationContext
		{
			get
			{
				if(r_MInvokeGenerateVisualContent_MeshGenerationContext == null)
				{
					r_MInvokeGenerateVisualContent_MeshGenerationContext = new(this, "InvokeGenerateVisualContent", 0, typeof(UnityEngine.UIElements.MeshGenerationContext));
				}
				return r_MInvokeGenerateVisualContent_MeshGenerationContext;
			}
		}

		/// <summary>
		/// Void GetFullHierarchicalViewDataKey(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_MGetFullHierarchicalViewDataKey_StringBuilder;
		public virtual RMethod RMGetFullHierarchicalViewDataKey_StringBuilder
		{
			get
			{
				if(r_MGetFullHierarchicalViewDataKey_StringBuilder == null)
				{
					r_MGetFullHierarchicalViewDataKey_StringBuilder = new(this, "GetFullHierarchicalViewDataKey", 0, typeof(System.Text.StringBuilder));
				}
				return r_MGetFullHierarchicalViewDataKey_StringBuilder;
			}
		}

		/// <summary>
		/// System.String GetFullHierarchicalViewDataKey()
		/// </summary>
		protected RMethod r_MGetFullHierarchicalViewDataKey;
		public virtual RMethod RMGetFullHierarchicalViewDataKey
		{
			get
			{
				if(r_MGetFullHierarchicalViewDataKey == null)
				{
					r_MGetFullHierarchicalViewDataKey = new(this, "GetFullHierarchicalViewDataKey", 0);
				}
				return r_MGetFullHierarchicalViewDataKey;
			}
		}

		/// <summary>
		/// T GetOrCreateViewData[T](System.Object, System.String)
		/// </summary>
		protected RMethod r_MGetOrCreateViewData_GT_Object_String;
		public virtual RMethod RMGetOrCreateViewData_GT_Object_String
		{
			get
			{
				if(r_MGetOrCreateViewData_GT_Object_String == null)
				{
					r_MGetOrCreateViewData_GT_Object_String = new(this, "GetOrCreateViewData", 1, typeof(System.Object), typeof(System.String));
				}
				return r_MGetOrCreateViewData_GT_Object_String;
			}
		}

		/// <summary>
		/// T GetOrCreateViewData[T](UnityEngine.ScriptableObject, System.String)
		/// </summary>
		protected RMethod r_MGetOrCreateViewData_GT_ScriptableObject_String;
		public virtual RMethod RMGetOrCreateViewData_GT_ScriptableObject_String
		{
			get
			{
				if(r_MGetOrCreateViewData_GT_ScriptableObject_String == null)
				{
					r_MGetOrCreateViewData_GT_ScriptableObject_String = new(this, "GetOrCreateViewData", 1, typeof(UnityEngine.ScriptableObject), typeof(System.String));
				}
				return r_MGetOrCreateViewData_GT_ScriptableObject_String;
			}
		}

		/// <summary>
		/// Void OverwriteFromViewData(System.Object, System.String)
		/// </summary>
		protected RMethod r_MOverwriteFromViewData_Object_String;
		public virtual RMethod RMOverwriteFromViewData_Object_String
		{
			get
			{
				if(r_MOverwriteFromViewData_Object_String == null)
				{
					r_MOverwriteFromViewData_Object_String = new(this, "OverwriteFromViewData", 0, typeof(System.Object), typeof(System.String));
				}
				return r_MOverwriteFromViewData_Object_String;
			}
		}

		/// <summary>
		/// Void SaveViewData()
		/// </summary>
		protected RMethod r_MSaveViewData;
		public virtual RMethod RMSaveViewData
		{
			get
			{
				if(r_MSaveViewData == null)
				{
					r_MSaveViewData = new(this, "SaveViewData", 0);
				}
				return r_MSaveViewData;
			}
		}

		/// <summary>
		/// Boolean IsViewDataPersitenceSupportedOnChildren(Boolean)
		/// </summary>
		protected RMethod r_MIsViewDataPersitenceSupportedOnChildren_Boolean;
		public virtual RMethod RMIsViewDataPersitenceSupportedOnChildren_Boolean
		{
			get
			{
				if(r_MIsViewDataPersitenceSupportedOnChildren_Boolean == null)
				{
					r_MIsViewDataPersitenceSupportedOnChildren_Boolean = new(this, "IsViewDataPersitenceSupportedOnChildren", 0, typeof(System.Boolean));
				}
				return r_MIsViewDataPersitenceSupportedOnChildren_Boolean;
			}
		}

		/// <summary>
		/// Void OnViewDataReady(Boolean)
		/// </summary>
		protected RMethod r_MOnViewDataReady_Boolean;
		public virtual RMethod RMOnViewDataReady_Boolean
		{
			get
			{
				if(r_MOnViewDataReady_Boolean == null)
				{
					r_MOnViewDataReady_Boolean = new(this, "OnViewDataReady", 0, typeof(System.Boolean));
				}
				return r_MOnViewDataReady_Boolean;
			}
		}

		/// <summary>
		/// Void OnViewDataReady()
		/// </summary>
		protected RMethod r_MOnViewDataReady;
		public virtual RMethod RMOnViewDataReady
		{
			get
			{
				if(r_MOnViewDataReady == null)
				{
					r_MOnViewDataReady = new(this, "OnViewDataReady", 0);
				}
				return r_MOnViewDataReady;
			}
		}

		/// <summary>
		/// Boolean ContainsPoint(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MContainsPoint_Vector2;
		public virtual RMethod RMContainsPoint_Vector2
		{
			get
			{
				if(r_MContainsPoint_Vector2 == null)
				{
					r_MContainsPoint_Vector2 = new(this, "ContainsPoint", 0, typeof(UnityEngine.Vector2));
				}
				return r_MContainsPoint_Vector2;
			}
		}

		/// <summary>
		/// Boolean Overlaps(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MOverlaps_Rect;
		public virtual RMethod RMOverlaps_Rect
		{
			get
			{
				if(r_MOverlaps_Rect == null)
				{
					r_MOverlaps_Rect = new(this, "Overlaps", 0, typeof(UnityEngine.Rect));
				}
				return r_MOverlaps_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 DoMeasure(Single, MeasureMode, Single, MeasureMode)
		/// </summary>
		protected RMethod r_MDoMeasure_Single_MeasureMode_Single_MeasureMode;
		public virtual RMethod RMDoMeasure_Single_MeasureMode_Single_MeasureMode
		{
			get
			{
				if(r_MDoMeasure_Single_MeasureMode_Single_MeasureMode == null)
				{
					r_MDoMeasure_Single_MeasureMode_Single_MeasureMode = new(this, "DoMeasure", 0, typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+MeasureMode"), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+MeasureMode"));
				}
				return r_MDoMeasure_Single_MeasureMode_Single_MeasureMode;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaSize Measure(UnityEngine.Yoga.YogaNode, Single, UnityEngine.Yoga.YogaMeasureMode, Single, UnityEngine.Yoga.YogaMeasureMode)
		/// </summary>
		protected RMethod r_MMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode;
		public virtual RMethod RMMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode
		{
			get
			{
				if(r_MMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode == null)
				{
					r_MMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode = new(this, "Measure", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.YogaNode"), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Yoga.YogaMeasureMode"), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Yoga.YogaMeasureMode"));
				}
				return r_MMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode;
			}
		}

		/// <summary>
		/// Void SetSize(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetSize_Vector2;
		public virtual RMethod RMSetSize_Vector2
		{
			get
			{
				if(r_MSetSize_Vector2 == null)
				{
					r_MSetSize_Vector2 = new(this, "SetSize", 0, typeof(UnityEngine.Vector2));
				}
				return r_MSetSize_Vector2;
			}
		}

		/// <summary>
		/// Void SetInlineRule(UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleRule)
		/// </summary>
		protected RMethod r_MSetInlineRule_StyleSheet_StyleRule;
		public virtual RMethod RMSetInlineRule_StyleSheet_StyleRule
		{
			get
			{
				if(r_MSetInlineRule_StyleSheet_StyleRule == null)
				{
					r_MSetInlineRule_StyleSheet_StyleRule = new(this, "SetInlineRule", 0, typeof(UnityEngine.UIElements.StyleSheet),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleRule"));
				}
				return r_MSetInlineRule_StyleSheet_StyleRule;
			}
		}

		/// <summary>
		/// Void UpdateInlineRule(UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleRule)
		/// </summary>
		protected RMethod r_MUpdateInlineRule_StyleSheet_StyleRule;
		public virtual RMethod RMUpdateInlineRule_StyleSheet_StyleRule
		{
			get
			{
				if(r_MUpdateInlineRule_StyleSheet_StyleRule == null)
				{
					r_MUpdateInlineRule_StyleSheet_StyleRule = new(this, "UpdateInlineRule", 0, typeof(UnityEngine.UIElements.StyleSheet),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleRule"));
				}
				return r_MUpdateInlineRule_StyleSheet_StyleRule;
			}
		}

		/// <summary>
		/// Void SetComputedStyle(UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_MSetComputedStyle_Ref_ComputedStyle;
		public virtual RMethod RMSetComputedStyle_Ref_ComputedStyle
		{
			get
			{
				if(r_MSetComputedStyle_Ref_ComputedStyle == null)
				{
					r_MSetComputedStyle_Ref_ComputedStyle = new(this, "SetComputedStyle", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
				}
				return r_MSetComputedStyle_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Void ResetPositionProperties()
		/// </summary>
		protected RMethod r_MResetPositionProperties;
		public virtual RMethod RMResetPositionProperties
		{
			get
			{
				if(r_MResetPositionProperties == null)
				{
					r_MResetPositionProperties = new(this, "ResetPositionProperties", 0);
				}
				return r_MResetPositionProperties;
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

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.String] GetClasses()
		/// </summary>
		protected RMethod r_MGetClasses;
		public virtual RMethod RMGetClasses
		{
			get
			{
				if(r_MGetClasses == null)
				{
					r_MGetClasses = new(this, "GetClasses", 0);
				}
				return r_MGetClasses;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] GetClassesForIteration()
		/// </summary>
		protected RMethod r_MGetClassesForIteration;
		public virtual RMethod RMGetClassesForIteration
		{
			get
			{
				if(r_MGetClassesForIteration == null)
				{
					r_MGetClassesForIteration = new(this, "GetClassesForIteration", 0);
				}
				return r_MGetClassesForIteration;
			}
		}

		/// <summary>
		/// Void ClearClassList()
		/// </summary>
		protected RMethod r_MClearClassList;
		public virtual RMethod RMClearClassList
		{
			get
			{
				if(r_MClearClassList == null)
				{
					r_MClearClassList = new(this, "ClearClassList", 0);
				}
				return r_MClearClassList;
			}
		}

		/// <summary>
		/// Void AddToClassList(System.String)
		/// </summary>
		protected RMethod r_MAddToClassList_String;
		public virtual RMethod RMAddToClassList_String
		{
			get
			{
				if(r_MAddToClassList_String == null)
				{
					r_MAddToClassList_String = new(this, "AddToClassList", 0, typeof(System.String));
				}
				return r_MAddToClassList_String;
			}
		}

		/// <summary>
		/// Void RemoveFromClassList(System.String)
		/// </summary>
		protected RMethod r_MRemoveFromClassList_String;
		public virtual RMethod RMRemoveFromClassList_String
		{
			get
			{
				if(r_MRemoveFromClassList_String == null)
				{
					r_MRemoveFromClassList_String = new(this, "RemoveFromClassList", 0, typeof(System.String));
				}
				return r_MRemoveFromClassList_String;
			}
		}

		/// <summary>
		/// Void ToggleInClassList(System.String)
		/// </summary>
		protected RMethod r_MToggleInClassList_String;
		public virtual RMethod RMToggleInClassList_String
		{
			get
			{
				if(r_MToggleInClassList_String == null)
				{
					r_MToggleInClassList_String = new(this, "ToggleInClassList", 0, typeof(System.String));
				}
				return r_MToggleInClassList_String;
			}
		}

		/// <summary>
		/// Void EnableInClassList(System.String, Boolean)
		/// </summary>
		protected RMethod r_MEnableInClassList_String_Boolean;
		public virtual RMethod RMEnableInClassList_String_Boolean
		{
			get
			{
				if(r_MEnableInClassList_String_Boolean == null)
				{
					r_MEnableInClassList_String_Boolean = new(this, "EnableInClassList", 0, typeof(System.String), typeof(System.Boolean));
				}
				return r_MEnableInClassList_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean ClassListContains(System.String)
		/// </summary>
		protected RMethod r_MClassListContains_String;
		public virtual RMethod RMClassListContains_String
		{
			get
			{
				if(r_MClassListContains_String == null)
				{
					r_MClassListContains_String = new(this, "ClassListContains", 0, typeof(System.String));
				}
				return r_MClassListContains_String;
			}
		}

		/// <summary>
		/// System.Object FindAncestorUserData()
		/// </summary>
		protected RMethod r_MFindAncestorUserData;
		public virtual RMethod RMFindAncestorUserData
		{
			get
			{
				if(r_MFindAncestorUserData == null)
				{
					r_MFindAncestorUserData = new(this, "FindAncestorUserData", 0);
				}
				return r_MFindAncestorUserData;
			}
		}

		/// <summary>
		/// System.Object GetProperty(UnityEngine.PropertyName)
		/// </summary>
		protected RMethod r_MGetProperty_PropertyName;
		public virtual RMethod RMGetProperty_PropertyName
		{
			get
			{
				if(r_MGetProperty_PropertyName == null)
				{
					r_MGetProperty_PropertyName = new(this, "GetProperty", 0, typeof(UnityEngine.PropertyName));
				}
				return r_MGetProperty_PropertyName;
			}
		}

		/// <summary>
		/// Void SetProperty(UnityEngine.PropertyName, System.Object)
		/// </summary>
		protected RMethod r_MSetProperty_PropertyName_Object;
		public virtual RMethod RMSetProperty_PropertyName_Object
		{
			get
			{
				if(r_MSetProperty_PropertyName_Object == null)
				{
					r_MSetProperty_PropertyName_Object = new(this, "SetProperty", 0, typeof(UnityEngine.PropertyName), typeof(System.Object));
				}
				return r_MSetProperty_PropertyName_Object;
			}
		}

		/// <summary>
		/// Boolean HasProperty(UnityEngine.PropertyName)
		/// </summary>
		protected RMethod r_MHasProperty_PropertyName;
		public virtual RMethod RMHasProperty_PropertyName
		{
			get
			{
				if(r_MHasProperty_PropertyName == null)
				{
					r_MHasProperty_PropertyName = new(this, "HasProperty", 0, typeof(UnityEngine.PropertyName));
				}
				return r_MHasProperty_PropertyName;
			}
		}

		/// <summary>
		/// Void ApplyPlayerRenderingToEditorElement()
		/// </summary>
		protected RMethod r_MApplyPlayerRenderingToEditorElement;
		public virtual RMethod RMApplyPlayerRenderingToEditorElement
		{
			get
			{
				if(r_MApplyPlayerRenderingToEditorElement == null)
				{
					r_MApplyPlayerRenderingToEditorElement = new(this, "ApplyPlayerRenderingToEditorElement", 0);
				}
				return r_MApplyPlayerRenderingToEditorElement;
			}
		}

		/// <summary>
		/// Void RegisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate)
		/// </summary>
		protected RMethod r_MRegisterAnimation_IValueAnimationUpdate;
		public virtual RMethod RMRegisterAnimation_IValueAnimationUpdate
		{
			get
			{
				if(r_MRegisterAnimation_IValueAnimationUpdate == null)
				{
					r_MRegisterAnimation_IValueAnimationUpdate = new(this, "RegisterAnimation", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.Experimental.IValueAnimationUpdate"));
				}
				return r_MRegisterAnimation_IValueAnimationUpdate;
			}
		}

		/// <summary>
		/// Void UnregisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate)
		/// </summary>
		protected RMethod r_MUnregisterAnimation_IValueAnimationUpdate;
		public virtual RMethod RMUnregisterAnimation_IValueAnimationUpdate
		{
			get
			{
				if(r_MUnregisterAnimation_IValueAnimationUpdate == null)
				{
					r_MUnregisterAnimation_IValueAnimationUpdate = new(this, "UnregisterAnimation", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.Experimental.IValueAnimationUpdate"));
				}
				return r_MUnregisterAnimation_IValueAnimationUpdate;
			}
		}

		/// <summary>
		/// Boolean ShouldClip()
		/// </summary>
		protected RMethod r_MShouldClip;
		public virtual RMethod RMShouldClip
		{
			get
			{
				if(r_MShouldClip == null)
				{
					r_MShouldClip = new(this, "ShouldClip", 0);
				}
				return r_MShouldClip;
			}
		}

		/// <summary>
		/// Void Add(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MAdd_VisualElement;
		public virtual RMethod RMAdd_VisualElement
		{
			get
			{
				if(r_MAdd_VisualElement == null)
				{
					r_MAdd_VisualElement = new(this, "Add", 0, typeof(UnityEngine.UIElements.VisualElement));
				}
				return r_MAdd_VisualElement;
			}
		}

		/// <summary>
		/// Void Insert(Int32, UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MInsert_Int32_VisualElement;
		public virtual RMethod RMInsert_Int32_VisualElement
		{
			get
			{
				if(r_MInsert_Int32_VisualElement == null)
				{
					r_MInsert_Int32_VisualElement = new(this, "Insert", 0, typeof(System.Int32), typeof(UnityEngine.UIElements.VisualElement));
				}
				return r_MInsert_Int32_VisualElement;
			}
		}

		/// <summary>
		/// Void Remove(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MRemove_VisualElement;
		public virtual RMethod RMRemove_VisualElement
		{
			get
			{
				if(r_MRemove_VisualElement == null)
				{
					r_MRemove_VisualElement = new(this, "Remove", 0, typeof(UnityEngine.UIElements.VisualElement));
				}
				return r_MRemove_VisualElement;
			}
		}

		/// <summary>
		/// Void RemoveAt(Int32)
		/// </summary>
		protected RMethod r_MRemoveAt_Int32;
		public virtual RMethod RMRemoveAt_Int32
		{
			get
			{
				if(r_MRemoveAt_Int32 == null)
				{
					r_MRemoveAt_Int32 = new(this, "RemoveAt", 0, typeof(System.Int32));
				}
				return r_MRemoveAt_Int32;
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
		/// UnityEngine.UIElements.VisualElement ElementAt(Int32)
		/// </summary>
		protected RMethod r_MElementAt_Int32;
		public virtual RMethod RMElementAt_Int32
		{
			get
			{
				if(r_MElementAt_Int32 == null)
				{
					r_MElementAt_Int32 = new(this, "ElementAt", 0, typeof(System.Int32));
				}
				return r_MElementAt_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MIndexOf_VisualElement;
		public virtual RMethod RMIndexOf_VisualElement
		{
			get
			{
				if(r_MIndexOf_VisualElement == null)
				{
					r_MIndexOf_VisualElement = new(this, "IndexOf", 0, typeof(UnityEngine.UIElements.VisualElement));
				}
				return r_MIndexOf_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement ElementAtTreePath(System.Collections.Generic.List`1[System.Int32])
		/// </summary>
		protected RMethod r_MElementAtTreePath_List_d_Int32_p_;
		public virtual RMethod RMElementAtTreePath_List_d_Int32_p_
		{
			get
			{
				if(r_MElementAtTreePath_List_d_Int32_p_ == null)
				{
					r_MElementAtTreePath_List_d_Int32_p_ = new(this, "ElementAtTreePath", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.Int32)));
				}
				return r_MElementAtTreePath_List_d_Int32_p_;
			}
		}

		/// <summary>
		/// Boolean FindElementInTree(UnityEngine.UIElements.VisualElement, System.Collections.Generic.List`1[System.Int32])
		/// </summary>
		protected RMethod r_MFindElementInTree_VisualElement_List_d_Int32_p_;
		public virtual RMethod RMFindElementInTree_VisualElement_List_d_Int32_p_
		{
			get
			{
				if(r_MFindElementInTree_VisualElement_List_d_Int32_p_ == null)
				{
					r_MFindElementInTree_VisualElement_List_d_Int32_p_ = new(this, "FindElementInTree", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.Int32)));
				}
				return r_MFindElementInTree_VisualElement_List_d_Int32_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.VisualElement] Children()
		/// </summary>
		protected RMethod r_MChildren;
		public virtual RMethod RMChildren
		{
			get
			{
				if(r_MChildren == null)
				{
					r_MChildren = new(this, "Children", 0);
				}
				return r_MChildren;
			}
		}

		/// <summary>
		/// Void Sort(System.Comparison`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_MSort_Comparison_d_VisualElement_p_;
		public virtual RMethod RMSort_Comparison_d_VisualElement_p_
		{
			get
			{
				if(r_MSort_Comparison_d_VisualElement_p_ == null)
				{
					r_MSort_Comparison_d_VisualElement_p_ = new(this, "Sort", 0,  ReflectionUtils.GetType("System.Comparison`1").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
				}
				return r_MSort_Comparison_d_VisualElement_p_;
			}
		}

		/// <summary>
		/// Void BringToFront()
		/// </summary>
		protected RMethod r_MBringToFront;
		public virtual RMethod RMBringToFront
		{
			get
			{
				if(r_MBringToFront == null)
				{
					r_MBringToFront = new(this, "BringToFront", 0);
				}
				return r_MBringToFront;
			}
		}

		/// <summary>
		/// Void SendToBack()
		/// </summary>
		protected RMethod r_MSendToBack;
		public virtual RMethod RMSendToBack
		{
			get
			{
				if(r_MSendToBack == null)
				{
					r_MSendToBack = new(this, "SendToBack", 0);
				}
				return r_MSendToBack;
			}
		}

		/// <summary>
		/// Void PlaceBehind(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MPlaceBehind_VisualElement;
		public virtual RMethod RMPlaceBehind_VisualElement
		{
			get
			{
				if(r_MPlaceBehind_VisualElement == null)
				{
					r_MPlaceBehind_VisualElement = new(this, "PlaceBehind", 0, typeof(UnityEngine.UIElements.VisualElement));
				}
				return r_MPlaceBehind_VisualElement;
			}
		}

		/// <summary>
		/// Void PlaceInFront(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MPlaceInFront_VisualElement;
		public virtual RMethod RMPlaceInFront_VisualElement
		{
			get
			{
				if(r_MPlaceInFront_VisualElement == null)
				{
					r_MPlaceInFront_VisualElement = new(this, "PlaceInFront", 0, typeof(UnityEngine.UIElements.VisualElement));
				}
				return r_MPlaceInFront_VisualElement;
			}
		}

		/// <summary>
		/// Void RemoveFromHierarchy()
		/// </summary>
		protected RMethod r_MRemoveFromHierarchy;
		public virtual RMethod RMRemoveFromHierarchy
		{
			get
			{
				if(r_MRemoveFromHierarchy == null)
				{
					r_MRemoveFromHierarchy = new(this, "RemoveFromHierarchy", 0);
				}
				return r_MRemoveFromHierarchy;
			}
		}

		/// <summary>
		/// T GetFirstOfType[T]()
		/// </summary>
		protected RMethod r_MGetFirstOfType_GT;
		public virtual RMethod RMGetFirstOfType_GT
		{
			get
			{
				if(r_MGetFirstOfType_GT == null)
				{
					r_MGetFirstOfType_GT = new(this, "GetFirstOfType", 1);
				}
				return r_MGetFirstOfType_GT;
			}
		}

		/// <summary>
		/// T GetFirstAncestorOfType[T]()
		/// </summary>
		protected RMethod r_MGetFirstAncestorOfType_GT;
		public virtual RMethod RMGetFirstAncestorOfType_GT
		{
			get
			{
				if(r_MGetFirstAncestorOfType_GT == null)
				{
					r_MGetFirstAncestorOfType_GT = new(this, "GetFirstAncestorOfType", 1);
				}
				return r_MGetFirstAncestorOfType_GT;
			}
		}

		/// <summary>
		/// Boolean Contains(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MContains_VisualElement;
		public virtual RMethod RMContains_VisualElement
		{
			get
			{
				if(r_MContains_VisualElement == null)
				{
					r_MContains_VisualElement = new(this, "Contains", 0, typeof(UnityEngine.UIElements.VisualElement));
				}
				return r_MContains_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement FindCommonAncestor(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MFindCommonAncestor_VisualElement;
		public virtual RMethod RMFindCommonAncestor_VisualElement
		{
			get
			{
				if(r_MFindCommonAncestor_VisualElement == null)
				{
					r_MFindCommonAncestor_VisualElement = new(this, "FindCommonAncestor", 0, typeof(UnityEngine.UIElements.VisualElement));
				}
				return r_MFindCommonAncestor_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetRoot()
		/// </summary>
		protected RMethod r_MGetRoot;
		public virtual RMethod RMGetRoot
		{
			get
			{
				if(r_MGetRoot == null)
				{
					r_MGetRoot = new(this, "GetRoot", 0);
				}
				return r_MGetRoot;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetRootVisualContainer()
		/// </summary>
		protected RMethod r_MGetRootVisualContainer;
		public virtual RMethod RMGetRootVisualContainer
		{
			get
			{
				if(r_MGetRootVisualContainer == null)
				{
					r_MGetRootVisualContainer = new(this, "GetRootVisualContainer", 0);
				}
				return r_MGetRootVisualContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetNextElementDepthFirst()
		/// </summary>
		protected RMethod r_MGetNextElementDepthFirst;
		public virtual RMethod RMGetNextElementDepthFirst
		{
			get
			{
				if(r_MGetNextElementDepthFirst == null)
				{
					r_MGetNextElementDepthFirst = new(this, "GetNextElementDepthFirst", 0);
				}
				return r_MGetNextElementDepthFirst;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetPreviousElementDepthFirst()
		/// </summary>
		protected RMethod r_MGetPreviousElementDepthFirst;
		public virtual RMethod RMGetPreviousElementDepthFirst
		{
			get
			{
				if(r_MGetPreviousElementDepthFirst == null)
				{
					r_MGetPreviousElementDepthFirst = new(this, "GetPreviousElementDepthFirst", 0);
				}
				return r_MGetPreviousElementDepthFirst;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement RetargetElement(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MRetargetElement_VisualElement;
		public virtual RMethod RMRetargetElement_VisualElement
		{
			get
			{
				if(r_MRetargetElement_VisualElement == null)
				{
					r_MRetargetElement_VisualElement = new(this, "RetargetElement", 0, typeof(UnityEngine.UIElements.VisualElement));
				}
				return r_MRetargetElement_VisualElement;
			}
		}

		/// <summary>
		/// Void AddStyleSheetPath(System.String)
		/// </summary>
		protected RMethod r_MAddStyleSheetPath_String;
		public virtual RMethod RMAddStyleSheetPath_String
		{
			get
			{
				if(r_MAddStyleSheetPath_String == null)
				{
					r_MAddStyleSheetPath_String = new(this, "AddStyleSheetPath", 0, typeof(System.String));
				}
				return r_MAddStyleSheetPath_String;
			}
		}

		/// <summary>
		/// Boolean HasStyleSheetPath(System.String)
		/// </summary>
		protected RMethod r_MHasStyleSheetPath_String;
		public virtual RMethod RMHasStyleSheetPath_String
		{
			get
			{
				if(r_MHasStyleSheetPath_String == null)
				{
					r_MHasStyleSheetPath_String = new(this, "HasStyleSheetPath", 0, typeof(System.String));
				}
				return r_MHasStyleSheetPath_String;
			}
		}

		/// <summary>
		/// Void RemoveStyleSheetPath(System.String)
		/// </summary>
		protected RMethod r_MRemoveStyleSheetPath_String;
		public virtual RMethod RMRemoveStyleSheetPath_String
		{
			get
			{
				if(r_MRemoveStyleSheetPath_String == null)
				{
					r_MRemoveStyleSheetPath_String = new(this, "RemoveStyleSheetPath", 0, typeof(System.String));
				}
				return r_MRemoveStyleSheetPath_String;
			}
		}

		/// <summary>
		/// Void Blur()
		/// </summary>
		protected RMethod r_MBlur;
		public virtual RMethod RMBlur
		{
			get
			{
				if(r_MBlur == null)
				{
					r_MBlur = new(this, "Blur", 0);
				}
				return r_MBlur;
			}
		}

		/// <summary>
		/// Void BlurImmediately()
		/// </summary>
		protected RMethod r_MBlurImmediately;
		public virtual RMethod RMBlurImmediately
		{
			get
			{
				if(r_MBlurImmediately == null)
				{
					r_MBlurImmediately = new(this, "BlurImmediately", 0);
				}
				return r_MBlurImmediately;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultActionDisabled(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MExecuteDefaultActionDisabled_EventBase;
		public virtual RMethod RMExecuteDefaultActionDisabled_EventBase
		{
			get
			{
				if(r_MExecuteDefaultActionDisabled_EventBase == null)
				{
					r_MExecuteDefaultActionDisabled_EventBase = new(this, "ExecuteDefaultActionDisabled", 0, typeof(UnityEngine.UIElements.EventBase));
				}
				return r_MExecuteDefaultActionDisabled_EventBase;
			}
		}

		/// <summary>
		/// Void RegisterCallback[TEventType](UnityEngine.UIElements.EventCallback`1[TEventType], UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown;
		public virtual RMethod RMRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown
		{
			get
			{
				if(r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown == null)
				{
					r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown = new(this, "RegisterCallback", 1,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCallback`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(UnityEngine.UIElements.TrickleDown));
				}
				return r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown;
			}
		}

		/// <summary>
		/// Void RegisterCallback[TEventType,TUserArgsType](UnityEngine.UIElements.EventCallback`2[TEventType,TUserArgsType], TUserArgsType, UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_MRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown;
		public virtual RMethod RMRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown
		{
			get
			{
				if(r_MRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown == null)
				{
					r_MRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown = new(this, "RegisterCallback", 2,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCallback`2").MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), Type.MakeGenericMethodParameter(1), typeof(UnityEngine.UIElements.TrickleDown));
				}
				return r_MRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown;
			}
		}

		/// <summary>
		/// Void RegisterCallback[TEventType](UnityEngine.UIElements.EventCallback`1[TEventType], UnityEngine.UIElements.InvokePolicy, UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown;
		public virtual RMethod RMRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown
		{
			get
			{
				if(r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown == null)
				{
					r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown = new(this, "RegisterCallback", 1,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCallback`1").MakeGenericType(Type.MakeGenericMethodParameter(0)),  ReflectionUtils.GetType("UnityEngine.UIElements.InvokePolicy"), typeof(UnityEngine.UIElements.TrickleDown));
				}
				return r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown;
			}
		}

		/// <summary>
		/// Void UnregisterCallback[TEventType](UnityEngine.UIElements.EventCallback`1[TEventType], UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_MUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown;
		public virtual RMethod RMUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown
		{
			get
			{
				if(r_MUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown == null)
				{
					r_MUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown = new(this, "UnregisterCallback", 1,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCallback`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(UnityEngine.UIElements.TrickleDown));
				}
				return r_MUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown;
			}
		}

		/// <summary>
		/// Void UnregisterCallback[TEventType,TUserArgsType](UnityEngine.UIElements.EventCallback`2[TEventType,TUserArgsType], UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_MUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown;
		public virtual RMethod RMUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown
		{
			get
			{
				if(r_MUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown == null)
				{
					r_MUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown = new(this, "UnregisterCallback", 2,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCallback`2").MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), typeof(UnityEngine.UIElements.TrickleDown));
				}
				return r_MUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown;
			}
		}

		/// <summary>
		/// Boolean TryGetUserArgs[TEventType,TCallbackArgs](UnityEngine.UIElements.EventCallback`2[TEventType,TCallbackArgs], UnityEngine.UIElements.TrickleDown, TCallbackArgs ByRef)
		/// </summary>
		protected RMethod r_MTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs;
		public virtual RMethod RMTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs
		{
			get
			{
				if(r_MTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs == null)
				{
					r_MTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs = new(this, "TryGetUserArgs", 2,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCallback`2").MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), typeof(UnityEngine.UIElements.TrickleDown), Type.MakeGenericMethodParameter(1).MakeByRefType());
				}
				return r_MTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs;
			}
		}

		/// <summary>
		/// Void HandleEventAtTargetPhase(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MHandleEventAtTargetPhase_EventBase;
		public virtual RMethod RMHandleEventAtTargetPhase_EventBase
		{
			get
			{
				if(r_MHandleEventAtTargetPhase_EventBase == null)
				{
					r_MHandleEventAtTargetPhase_EventBase = new(this, "HandleEventAtTargetPhase", 0, typeof(UnityEngine.UIElements.EventBase));
				}
				return r_MHandleEventAtTargetPhase_EventBase;
			}
		}

		/// <summary>
		/// Void HandleEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MHandleEvent_EventBase;
		public virtual RMethod RMHandleEvent_EventBase
		{
			get
			{
				if(r_MHandleEvent_EventBase == null)
				{
					r_MHandleEvent_EventBase = new(this, "HandleEvent", 0, typeof(UnityEngine.UIElements.EventBase));
				}
				return r_MHandleEvent_EventBase;
			}
		}

		/// <summary>
		/// Boolean HasTrickleDownHandlers()
		/// </summary>
		protected RMethod r_MHasTrickleDownHandlers;
		public virtual RMethod RMHasTrickleDownHandlers
		{
			get
			{
				if(r_MHasTrickleDownHandlers == null)
				{
					r_MHasTrickleDownHandlers = new(this, "HasTrickleDownHandlers", 0);
				}
				return r_MHasTrickleDownHandlers;
			}
		}

		/// <summary>
		/// Boolean HasBubbleUpHandlers()
		/// </summary>
		protected RMethod r_MHasBubbleUpHandlers;
		public virtual RMethod RMHasBubbleUpHandlers
		{
			get
			{
				if(r_MHasBubbleUpHandlers == null)
				{
					r_MHasBubbleUpHandlers = new(this, "HasBubbleUpHandlers", 0);
				}
				return r_MHasBubbleUpHandlers;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MExecuteDefaultActionAtTarget_EventBase;
		public virtual RMethod RMExecuteDefaultActionAtTarget_EventBase
		{
			get
			{
				if(r_MExecuteDefaultActionAtTarget_EventBase == null)
				{
					r_MExecuteDefaultActionAtTarget_EventBase = new(this, "ExecuteDefaultActionAtTarget", 0, typeof(UnityEngine.UIElements.EventBase));
				}
				return r_MExecuteDefaultActionAtTarget_EventBase;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultActionDisabledAtTarget(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MExecuteDefaultActionDisabledAtTarget_EventBase;
		public virtual RMethod RMExecuteDefaultActionDisabledAtTarget_EventBase
		{
			get
			{
				if(r_MExecuteDefaultActionDisabledAtTarget_EventBase == null)
				{
					r_MExecuteDefaultActionDisabledAtTarget_EventBase = new(this, "ExecuteDefaultActionDisabledAtTarget", 0, typeof(UnityEngine.UIElements.EventBase));
				}
				return r_MExecuteDefaultActionDisabledAtTarget_EventBase;
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


        public virtual void ResolveDependencies()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResolveDependencies.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateFillerHeight(UnityEngine.UIElements.GeometryChangedEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMRecalculateFillerHeight_GeometryChangedEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDetailScroll(System.Single @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offset};
            var ___result = RMOnDetailScroll_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnEnable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnEnable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnTermOfServiceAgreementStatusChange(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RTermOfServiceAgreementStatus @status)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@status.Value};
            var ___result = RMOnTermOfServiceAgreementStatusChange_TermOfServiceAgreementStatus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDisable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnDisable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnInternetReachabilityChange(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMOnInternetReachabilityChange_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnUserLoginStateChange(System.Boolean @userInfoReady, System.Boolean @loggedIn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@userInfoReady, @loggedIn};
            var ___result = RMOnUserLoginStateChange_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateDownloadProgressBar(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @operation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@operation.Value};
            var ___result = RMUpdateDownloadProgressBar_IOperation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopDownloadProgressBar(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @operation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@operation.Value};
            var ___result = RMStopDownloadProgressBar_IOperation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PauseDownloadProgressBar(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @operation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@operation.Value};
            var ___result = RMPauseDownloadProgressBar_IOperation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetContentVisibility(System.Boolean @visible)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@visible};
            var ___result = RMSetContentVisibility_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetToolBarVisibility(System.Boolean @visible)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@visible};
            var ___result = RMSetToolBarVisibility_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnSelectionChanged(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value};
            var ___result = RMOnSelectionChanged_IPackageVersion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RefreshUI(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value};
            var ___result = RMRefreshUI_IPackageVersion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RefreshExtensions(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value, @version.Value};
            var ___result = RMRefreshExtensions_IPackage_IPackageVersion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RefreshContent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefreshContent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RefreshEntitlement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefreshEntitlement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPackage(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value, @version.Value};
            var ___result = RMSetPackage_IPackage_IPackageVersion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnVerifiedGitPackageUpToDate(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RMOnVerifiedGitPackageUpToDate_IPackage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPackagesUpdated(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @updatedPackages)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@updatedPackages.Value};
            var ___result = RMOnPackagesUpdated_IEnumerable_d_IPackage_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPackagesUpdated(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @added, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @removed, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @preUpdated, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> @postUpdated)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@added.Value, @removed.Value, @preUpdated.Value, @postUpdated.Value};
            var ___result = RMOnPackagesUpdated_IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p__IEnumerable_d_IPackage_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RefreshErrorDisplay()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefreshErrorDisplay.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearError()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearError.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetError(System.String @message, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageState @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@message, @state.Value};
            var ___result = RMSetError_String_PackageState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPackageProgressUpdate(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value};
            var ___result = RMOnPackageProgressUpdate_IPackage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RefreshPackageActionButtons()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefreshPackageActionButtons.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RefreshAddButton()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefreshAddButton.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RefreshToolbarExtensionsStatusAndTooltip()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefreshToolbarExtensionsStatusAndTooltip.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RefreshRemoveButton()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefreshRemoveButton.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RefreshResetButton()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefreshResetButton.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RefreshDownloadStatesButtons()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefreshDownloadStatesButtons.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RefreshUnlockButton()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefreshUnlockButton.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RefreshButtonStatusAndTooltip(UnityEngine.UIElements.VisualElement @button, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction @action, Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RButtonDisableCondition> @disableConditions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@button, @action.Value, @disableConditions.Value};
            var ___result = RMRefreshButtonStatusAndTooltip_VisualElement_PackageAction_ButtonDisableConditionArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RefreshButtonStatusAndTooltip(UnityEngine.UIElements.VisualElement @button, Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RButtonDisableCondition> @disableConditions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@button, @disableConditions.Value};
            var ___result = RMRefreshButtonStatusAndTooltip_VisualElement_ButtonDisableConditionArray.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String GetButtonText(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction @action, System.Boolean @inProgress, Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion> @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action.Value, @inProgress, @version.Value};
            var ___result = RMGetButtonText_PackageAction_Boolean_Nullable_d_SemVersion_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String GetButtonTooltip(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action.Value};
            var ___result = RMGetButtonTooltip_PackageAction.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual void UpdateClick()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateClick.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveClick()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRemoveClick.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetClick()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetClick.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ImportClick()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMImportClick.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DownloadClick()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDownloadClick.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DowngradeClick()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDowngradeClick.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReDownloadClick()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReDownloadClick.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DownloadClickInternal(System.String @eventName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventName};
            var ___result = RMDownloadClickInternal_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CancelClick()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCancelClick.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PauseClick()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPauseClick.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResumeClick()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResumeClick.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnlockClick()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUnlockClick.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0____2__ctor__1__b__32_0()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RM__0____2__ctor__1__b__32_0.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkRenderHintsClean()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMarkRenderHintsClean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector3 ComputeGlobalScale()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMComputeGlobalScale.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector3>(___result);
        }


        public virtual void UpdateBoundingBox()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateBoundingBox.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateWorldBoundingBox()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateWorldBoundingBox.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateWorldTransform()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateWorldTransform.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateWorldTransformInverse()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateWorldTransformInverse.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnsureWorldTransformAndClipUpToDate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEnsureWorldTransformAndClipUpToDate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteDefaultAction(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMExecuteDefaultAction_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect GetTooltipRect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTooltipRect.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rect>(___result);
        }


        public virtual void Focus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPanel(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVisualElementPanel @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p.Value};
            var ___result = RMSetPanel_BaseVisualElementPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendEvent(UnityEngine.UIElements.EventBase @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMSendEvent_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendEvent(UnityEngine.UIElements.EventBase @e, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDispatchMode @dispatchMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @dispatchMode.Value};
            var ___result = RMSendEvent_EventBase_DispatchMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IncrementVersion(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType @changeType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@changeType.Value};
            var ___result = RMIncrementVersion_VersionChangeType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeHierarchyChanged(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RHierarchyChangeType @changeType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@changeType.Value};
            var ___result = RMInvokeHierarchyChanged_HierarchyChangeType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SetEnabledFromHierarchy(System.Boolean @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RMSetEnabledFromHierarchy_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void SetEnabled(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetEnabled_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkDirtyRepaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMarkDirtyRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext @mgc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mgc};
            var ___result = RMInvokeGenerateVisualContent_MeshGenerationContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetFullHierarchicalViewDataKey(System.Text.StringBuilder @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMGetFullHierarchicalViewDataKey_StringBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetFullHierarchicalViewDataKey()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetFullHierarchicalViewDataKey.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual T GetOrCreateViewData<T>(System.Object @existing, System.String @key) where T : class, new()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@existing, @key};
            var ___result = RMGetOrCreateViewData_GT_Object_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public virtual T GetOrCreateViewData<T>(UnityEngine.ScriptableObject @existing, System.String @key) where T : UnityEngine.ScriptableObject
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@existing, @key};
            var ___result = RMGetOrCreateViewData_GT_ScriptableObject_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public virtual void OverwriteFromViewData(System.Object @obj, System.String @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @key};
            var ___result = RMOverwriteFromViewData_Object_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SaveViewData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSaveViewData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsViewDataPersitenceSupportedOnChildren(System.Boolean @existingState)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@existingState};
            var ___result = RMIsViewDataPersitenceSupportedOnChildren_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void OnViewDataReady(System.Boolean @enablePersistence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enablePersistence};
            var ___result = RMOnViewDataReady_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnViewDataReady()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnViewDataReady.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ContainsPoint(UnityEngine.Vector2 @localPoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localPoint};
            var ___result = RMContainsPoint_Vector2.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Overlaps(UnityEngine.Rect @rectangle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rectangle};
            var ___result = RMOverlaps_Rect.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual UnityEngine.Vector2 DoMeasure(System.Single @desiredWidth, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RMeasureMode @widthMode, System.Single @desiredHeight, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RMeasureMode @heightMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desiredWidth, @widthMode.Value, @desiredHeight, @heightMode.Value};
            var ___result = RMDoMeasure_Single_MeasureMode_Single_MeasureMode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector2>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaSize Measure(Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaNode @node, System.Single @width, Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaMeasureMode @widthMode, System.Single @height, Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaMeasureMode @heightMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node.Value, @width, @widthMode.Value, @height, @heightMode.Value};
            var ___result = RMMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaSize>(___result);
        }


        public virtual void SetSize(UnityEngine.Vector2 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@size};
            var ___result = RMSetSize_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInlineRule(UnityEngine.UIElements.StyleSheet @sheet, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheet, @rule.Value};
            var ___result = RMSetInlineRule_StyleSheet_StyleRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateInlineRule(UnityEngine.UIElements.StyleSheet @sheet, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheet, @rule.Value};
            var ___result = RMUpdateInlineRule_StyleSheet_StyleRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputedStyle(ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @newStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newStyle.Value};
            var ___result = RMSetComputedStyle_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@newStyle = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[0]);

            
        }


        public virtual void ResetPositionProperties()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetPositionProperties.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Collections.Generic.IEnumerable<System.String> GetClasses()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetClasses.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.IEnumerable<System.String>>(___result);
        }


        public virtual System.Collections.Generic.List<System.String> GetClassesForIteration()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetClassesForIteration.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.List<System.String>>(___result);
        }


        public virtual void ClearClassList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearClassList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddToClassList(System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RMAddToClassList_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFromClassList(System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RMRemoveFromClassList_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ToggleInClassList(System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RMToggleInClassList_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableInClassList(System.String @className, System.Boolean @enable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className, @enable};
            var ___result = RMEnableInClassList_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ClassListContains(System.String @cls)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cls};
            var ___result = RMClassListContains_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Object FindAncestorUserData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFindAncestorUserData.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Object GetProperty(UnityEngine.PropertyName @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMGetProperty_PropertyName.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual void SetProperty(UnityEngine.PropertyName @key, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RMSetProperty_PropertyName_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasProperty(UnityEngine.PropertyName @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMHasProperty_PropertyName.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void ApplyPlayerRenderingToEditorElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMApplyPlayerRenderingToEditorElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterAnimation(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate @anim)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anim.Value};
            var ___result = RMRegisterAnimation_IValueAnimationUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterAnimation(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate @anim)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anim.Value};
            var ___result = RMUnregisterAnimation_IValueAnimationUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ShouldClip()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShouldClip.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Add(UnityEngine.UIElements.VisualElement @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RMAdd_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Insert(System.Int32 @index, UnityEngine.UIElements.VisualElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @element};
            var ___result = RMInsert_Int32_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Remove(UnityEngine.UIElements.VisualElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RMRemove_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMRemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.VisualElement ElementAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMElementAt_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


        public virtual System.Int32 IndexOf(UnityEngine.UIElements.VisualElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RMIndexOf_VisualElement.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual UnityEngine.UIElements.VisualElement ElementAtTreePath(System.Collections.Generic.List<System.Int32> @childIndexes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@childIndexes};
            var ___result = RMElementAtTreePath_List_d_Int32_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


        public virtual System.Boolean FindElementInTree(UnityEngine.UIElements.VisualElement @element, System.Collections.Generic.List<System.Int32> @outChildIndexes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @outChildIndexes};
            var ___result = RMFindElementInTree_VisualElement_List_d_Int32_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement> Children()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMChildren.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement>>(___result);
        }


        public virtual void Sort(System.Comparison<UnityEngine.UIElements.VisualElement> @comp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comp};
            var ___result = RMSort_Comparison_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BringToFront()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBringToFront.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendToBack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSendToBack.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlaceBehind(UnityEngine.UIElements.VisualElement @sibling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sibling};
            var ___result = RMPlaceBehind_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlaceInFront(UnityEngine.UIElements.VisualElement @sibling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sibling};
            var ___result = RMPlaceInFront_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFromHierarchy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRemoveFromHierarchy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T GetFirstOfType<T>() where T : class
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetFirstOfType_GT.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public virtual T GetFirstAncestorOfType<T>() where T : class
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetFirstAncestorOfType_GT.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public virtual System.Boolean Contains(UnityEngine.UIElements.VisualElement @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RMContains_VisualElement.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual UnityEngine.UIElements.VisualElement FindCommonAncestor(UnityEngine.UIElements.VisualElement @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMFindCommonAncestor_VisualElement.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


        public virtual UnityEngine.UIElements.VisualElement GetRoot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRoot.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


        public virtual UnityEngine.UIElements.VisualElement GetRootVisualContainer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRootVisualContainer.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


        public virtual UnityEngine.UIElements.VisualElement GetNextElementDepthFirst()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNextElementDepthFirst.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


        public virtual UnityEngine.UIElements.VisualElement GetPreviousElementDepthFirst()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPreviousElementDepthFirst.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


        public virtual UnityEngine.UIElements.VisualElement RetargetElement(UnityEngine.UIElements.VisualElement @retargetAgainst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@retargetAgainst};
            var ___result = RMRetargetElement_VisualElement.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


        public virtual void AddStyleSheetPath(System.String @sheetPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheetPath};
            var ___result = RMAddStyleSheetPath_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasStyleSheetPath(System.String @sheetPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheetPath};
            var ___result = RMHasStyleSheetPath_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void RemoveStyleSheetPath(System.String @sheetPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheetPath};
            var ___result = RMRemoveStyleSheetPath_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blur()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBlur.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BlurImmediately()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBlurImmediately.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteDefaultActionDisabled(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMExecuteDefaultActionDisabled_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType> @callback, UnityEngine.UIElements.TrickleDown @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType)};
            var ___parameters = new object[]{@callback, @useTrickleDown};
            var ___result = RMRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterCallback<TEventType, TUserArgsType>(UnityEngine.UIElements.EventCallback<TEventType, TUserArgsType> @callback, TUserArgsType @userArgs, UnityEngine.UIElements.TrickleDown @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType), typeof(TUserArgsType)};
            var ___parameters = new object[]{@callback, @userArgs, @useTrickleDown};
            var ___result = RMRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType> @callback, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RInvokePolicy @invokePolicy, UnityEngine.UIElements.TrickleDown @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType)};
            var ___parameters = new object[]{@callback, @invokePolicy.Value, @useTrickleDown};
            var ___result = RMRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType> @callback, UnityEngine.UIElements.TrickleDown @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType)};
            var ___parameters = new object[]{@callback, @useTrickleDown};
            var ___result = RMUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterCallback<TEventType, TUserArgsType>(UnityEngine.UIElements.EventCallback<TEventType, TUserArgsType> @callback, UnityEngine.UIElements.TrickleDown @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType), typeof(TUserArgsType)};
            var ___parameters = new object[]{@callback, @useTrickleDown};
            var ___result = RMUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryGetUserArgs<TEventType, TCallbackArgs>(UnityEngine.UIElements.EventCallback<TEventType, TCallbackArgs> @callback, UnityEngine.UIElements.TrickleDown @useTrickleDown, out TCallbackArgs @userData) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {
			@userData = default;

            var ___genericsType = new Type[] {typeof(TEventType), typeof(TCallbackArgs)};
            var ___parameters = new object[]{@callback, @useTrickleDown, @userData};
            var ___result = RMTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs.Invoke(___genericsType, ___parameters);
			@userData = ReflectionUtils.Convert<TCallbackArgs>(___parameters[2]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void HandleEventAtTargetPhase(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMHandleEventAtTargetPhase_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleEvent(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMHandleEvent_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasTrickleDownHandlers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasTrickleDownHandlers.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasBubbleUpHandlers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasBubbleUpHandlers.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMExecuteDefaultActionAtTarget_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteDefaultActionDisabledAtTarget(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMExecuteDefaultActionDisabledAtTarget_EventBase.Invoke(___genericsType, ___parameters);

            
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


    }
}
