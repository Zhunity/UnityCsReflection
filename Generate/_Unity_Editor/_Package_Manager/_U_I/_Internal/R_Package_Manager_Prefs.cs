
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.PackageManagerPrefs
	/// </summary>
    public partial class RPackageManagerPrefs : RMember //
    {

		/// <summary>
		/// System.String k_SkipRemoveConfirmationPrefs
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RString r_Fk_SkipRemoveConfirmationPrefs;
		public static SMFrame.Editor.Refleaction.RSystem.RString RFk_SkipRemoveConfirmationPrefs
		{
			get
			{
				if(r_Fk_SkipRemoveConfirmationPrefs == null)
				{
					r_Fk_SkipRemoveConfirmationPrefs = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageManagerPrefs"), "k_SkipRemoveConfirmationPrefs");
					r_Fk_SkipRemoveConfirmationPrefs.SetBelong(null);
				}
				return r_Fk_SkipRemoveConfirmationPrefs;
			}
		}

		/// <summary>
		/// System.String k_SkipMultiSelectRemoveConfirmationPrefs
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RString r_Fk_SkipMultiSelectRemoveConfirmationPrefs;
		public static SMFrame.Editor.Refleaction.RSystem.RString RFk_SkipMultiSelectRemoveConfirmationPrefs
		{
			get
			{
				if(r_Fk_SkipMultiSelectRemoveConfirmationPrefs == null)
				{
					r_Fk_SkipMultiSelectRemoveConfirmationPrefs = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageManagerPrefs"), "k_SkipMultiSelectRemoveConfirmationPrefs");
					r_Fk_SkipMultiSelectRemoveConfirmationPrefs.SetBelong(null);
				}
				return r_Fk_SkipMultiSelectRemoveConfirmationPrefs;
			}
		}

		/// <summary>
		/// System.String k_SkipDisableConfirmationPrefs
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RString r_Fk_SkipDisableConfirmationPrefs;
		public static SMFrame.Editor.Refleaction.RSystem.RString RFk_SkipDisableConfirmationPrefs
		{
			get
			{
				if(r_Fk_SkipDisableConfirmationPrefs == null)
				{
					r_Fk_SkipDisableConfirmationPrefs = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageManagerPrefs"), "k_SkipDisableConfirmationPrefs");
					r_Fk_SkipDisableConfirmationPrefs.SetBelong(null);
				}
				return r_Fk_SkipDisableConfirmationPrefs;
			}
		}

		/// <summary>
		/// System.String k_SplitterFlexGrowPrefs
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RString r_Fk_SplitterFlexGrowPrefs;
		public static SMFrame.Editor.Refleaction.RSystem.RString RFk_SplitterFlexGrowPrefs
		{
			get
			{
				if(r_Fk_SplitterFlexGrowPrefs == null)
				{
					r_Fk_SplitterFlexGrowPrefs = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageManagerPrefs"), "k_SplitterFlexGrowPrefs");
					r_Fk_SplitterFlexGrowPrefs.SetBelong(null);
				}
				return r_Fk_SplitterFlexGrowPrefs;
			}
		}

		/// <summary>
		/// System.String k_LastUsedFilterPrefsPrefix
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RString r_Fk_LastUsedFilterPrefsPrefix;
		public static SMFrame.Editor.Refleaction.RSystem.RString RFk_LastUsedFilterPrefsPrefix
		{
			get
			{
				if(r_Fk_LastUsedFilterPrefsPrefix == null)
				{
					r_Fk_LastUsedFilterPrefsPrefix = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageManagerPrefs"), "k_LastUsedFilterPrefsPrefix");
					r_Fk_LastUsedFilterPrefsPrefix.SetBelong(null);
				}
				return r_Fk_LastUsedFilterPrefsPrefix;
			}
		}

		/// <summary>
		/// System.Int32 m_NumItemsPerPage
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_NumItemsPerPage;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_NumItemsPerPage
		{
			get
			{
				if(r_Fm_NumItemsPerPage == null)
				{
					r_Fm_NumItemsPerPage = new(this, "m_NumItemsPerPage");
					r_Fm_NumItemsPerPage.SetBelong(this.instance);
				}
				return r_Fm_NumItemsPerPage;
			}
		}

		/// <summary>
		/// System.Boolean m_DependenciesExpanded
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_DependenciesExpanded;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_DependenciesExpanded
		{
			get
			{
				if(r_Fm_DependenciesExpanded == null)
				{
					r_Fm_DependenciesExpanded = new(this, "m_DependenciesExpanded");
					r_Fm_DependenciesExpanded.SetBelong(this.instance);
				}
				return r_Fm_DependenciesExpanded;
			}
		}

		/// <summary>
		/// System.String m_SelectedFeatureDependency
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fm_SelectedFeatureDependency;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFm_SelectedFeatureDependency
		{
			get
			{
				if(r_Fm_SelectedFeatureDependency == null)
				{
					r_Fm_SelectedFeatureDependency = new(this, "m_SelectedFeatureDependency");
					r_Fm_SelectedFeatureDependency.SetBelong(this.instance);
				}
				return r_Fm_SelectedFeatureDependency;
			}
		}

		/// <summary>
		/// System.Boolean m_SamplesExpanded
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_SamplesExpanded;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_SamplesExpanded
		{
			get
			{
				if(r_Fm_SamplesExpanded == null)
				{
					r_Fm_SamplesExpanded = new(this, "m_SamplesExpanded");
					r_Fm_SamplesExpanded.SetBelong(this.instance);
				}
				return r_Fm_SamplesExpanded;
			}
		}

		/// <summary>
		/// System.Boolean m_OverviewFoldoutExpanded
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_OverviewFoldoutExpanded;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_OverviewFoldoutExpanded
		{
			get
			{
				if(r_Fm_OverviewFoldoutExpanded == null)
				{
					r_Fm_OverviewFoldoutExpanded = new(this, "m_OverviewFoldoutExpanded");
					r_Fm_OverviewFoldoutExpanded.SetBelong(this.instance);
				}
				return r_Fm_OverviewFoldoutExpanded;
			}
		}

		/// <summary>
		/// System.Single m_PackageDetailVerticalScrollOffset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_Fm_PackageDetailVerticalScrollOffset;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFm_PackageDetailVerticalScrollOffset
		{
			get
			{
				if(r_Fm_PackageDetailVerticalScrollOffset == null)
				{
					r_Fm_PackageDetailVerticalScrollOffset = new(this, "m_PackageDetailVerticalScrollOffset");
					r_Fm_PackageDetailVerticalScrollOffset.SetBelong(this.instance);
				}
				return r_Fm_PackageDetailVerticalScrollOffset;
			}
		}

		/// <summary>
		/// System.String m_SelectedPackageDetailsTabIdentifier
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fm_SelectedPackageDetailsTabIdentifier;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFm_SelectedPackageDetailsTabIdentifier
		{
			get
			{
				if(r_Fm_SelectedPackageDetailsTabIdentifier == null)
				{
					r_Fm_SelectedPackageDetailsTabIdentifier = new(this, "m_SelectedPackageDetailsTabIdentifier");
					r_Fm_SelectedPackageDetailsTabIdentifier.SetBelong(this.instance);
				}
				return r_Fm_SelectedPackageDetailsTabIdentifier;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_ExpandedDetailsExtensions
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RSystem.RString> r_Fm_ExpandedDetailsExtensions;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RSystem.RString> RFm_ExpandedDetailsExtensions
		{
			get
			{
				if(r_Fm_ExpandedDetailsExtensions == null)
				{
					r_Fm_ExpandedDetailsExtensions = new(this, "m_ExpandedDetailsExtensions");
					r_Fm_ExpandedDetailsExtensions.SetBelong(this.instance);
				}
				return r_Fm_ExpandedDetailsExtensions;
			}
		}

		/// <summary>
		/// System.String m_PackageDisplayedInVersionHistoryTab
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fm_PackageDisplayedInVersionHistoryTab;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFm_PackageDisplayedInVersionHistoryTab
		{
			get
			{
				if(r_Fm_PackageDisplayedInVersionHistoryTab == null)
				{
					r_Fm_PackageDisplayedInVersionHistoryTab = new(this, "m_PackageDisplayedInVersionHistoryTab");
					r_Fm_PackageDisplayedInVersionHistoryTab.SetBelong(this.instance);
				}
				return r_Fm_PackageDisplayedInVersionHistoryTab;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_ExpandedVersionHistoryItems
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RSystem.RString> r_Fm_ExpandedVersionHistoryItems;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RSystem.RString> RFm_ExpandedVersionHistoryItems
		{
			get
			{
				if(r_Fm_ExpandedVersionHistoryItems == null)
				{
					r_Fm_ExpandedVersionHistoryItems = new(this, "m_ExpandedVersionHistoryItems");
					r_Fm_ExpandedVersionHistoryItems.SetBelong(this.instance);
				}
				return r_Fm_ExpandedVersionHistoryItems;
			}
		}

		/// <summary>
		/// System.String projectIdentifier
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RString r_PprojectIdentifier;
		public static SMFrame.Editor.Refleaction.RSystem.RString RPprojectIdentifier
		{
			get
			{
				if(r_PprojectIdentifier == null)
				{
					r_PprojectIdentifier = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageManagerPrefs"), "projectIdentifier", -1);
					r_PprojectIdentifier.SetBelong(null);
				}
				return r_PprojectIdentifier;
			}
		}

		/// <summary>
		/// System.String lastUsedFilterForProjectPerfs
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RString r_PlastUsedFilterForProjectPerfs;
		public static SMFrame.Editor.Refleaction.RSystem.RString RPlastUsedFilterForProjectPerfs
		{
			get
			{
				if(r_PlastUsedFilterForProjectPerfs == null)
				{
					r_PlastUsedFilterForProjectPerfs = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageManagerPrefs"), "lastUsedFilterForProjectPerfs", -1);
					r_PlastUsedFilterForProjectPerfs.SetBelong(null);
				}
				return r_PlastUsedFilterForProjectPerfs;
			}
		}

		/// <summary>
		/// Boolean skipRemoveConfirmation
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PskipRemoveConfirmation;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPskipRemoveConfirmation
		{
			get
			{
				if(r_PskipRemoveConfirmation == null)
				{
					r_PskipRemoveConfirmation = new(this, "skipRemoveConfirmation", -1);
					r_PskipRemoveConfirmation.SetBelong(this.instance);
				}
				return r_PskipRemoveConfirmation;
			}
		}

		/// <summary>
		/// Boolean skipMultiSelectRemoveConfirmation
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PskipMultiSelectRemoveConfirmation;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPskipMultiSelectRemoveConfirmation
		{
			get
			{
				if(r_PskipMultiSelectRemoveConfirmation == null)
				{
					r_PskipMultiSelectRemoveConfirmation = new(this, "skipMultiSelectRemoveConfirmation", -1);
					r_PskipMultiSelectRemoveConfirmation.SetBelong(this.instance);
				}
				return r_PskipMultiSelectRemoveConfirmation;
			}
		}

		/// <summary>
		/// Boolean skipDisableConfirmation
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PskipDisableConfirmation;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPskipDisableConfirmation
		{
			get
			{
				if(r_PskipDisableConfirmation == null)
				{
					r_PskipDisableConfirmation = new(this, "skipDisableConfirmation", -1);
					r_PskipDisableConfirmation.SetBelong(this.instance);
				}
				return r_PskipDisableConfirmation;
			}
		}

		/// <summary>
		/// Single splitterFlexGrow
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_PsplitterFlexGrow;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RPsplitterFlexGrow
		{
			get
			{
				if(r_PsplitterFlexGrow == null)
				{
					r_PsplitterFlexGrow = new(this, "splitterFlexGrow", -1);
					r_PsplitterFlexGrow.SetBelong(this.instance);
				}
				return r_PsplitterFlexGrow;
			}
		}

		/// <summary>
		/// System.Nullable`1[UnityEditor.PackageManager.UI.Internal.PackageFilterTab] lastUsedPackageFilter
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RNullable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab> r_PlastUsedPackageFilter;
		public virtual SMFrame.Editor.Refleaction.RSystem.RNullable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab> RPlastUsedPackageFilter
		{
			get
			{
				if(r_PlastUsedPackageFilter == null)
				{
					r_PlastUsedPackageFilter = new(this, "lastUsedPackageFilter", -1);
					r_PlastUsedPackageFilter.SetBelong(this.instance);
				}
				return r_PlastUsedPackageFilter;
			}
		}

		/// <summary>
		/// System.Nullable`1[System.Int32] numItemsPerPage
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RNullable<SMFrame.Editor.Refleaction.RSystem.RInt32> r_PnumItemsPerPage;
		public virtual SMFrame.Editor.Refleaction.RSystem.RNullable<SMFrame.Editor.Refleaction.RSystem.RInt32> RPnumItemsPerPage
		{
			get
			{
				if(r_PnumItemsPerPage == null)
				{
					r_PnumItemsPerPage = new(this, "numItemsPerPage", -1);
					r_PnumItemsPerPage.SetBelong(this.instance);
				}
				return r_PnumItemsPerPage;
			}
		}

		/// <summary>
		/// Boolean dependenciesExpanded
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PdependenciesExpanded;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPdependenciesExpanded
		{
			get
			{
				if(r_PdependenciesExpanded == null)
				{
					r_PdependenciesExpanded = new(this, "dependenciesExpanded", -1);
					r_PdependenciesExpanded.SetBelong(this.instance);
				}
				return r_PdependenciesExpanded;
			}
		}

		/// <summary>
		/// System.String selectedFeatureDependency
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PselectedFeatureDependency;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPselectedFeatureDependency
		{
			get
			{
				if(r_PselectedFeatureDependency == null)
				{
					r_PselectedFeatureDependency = new(this, "selectedFeatureDependency", -1);
					r_PselectedFeatureDependency.SetBelong(this.instance);
				}
				return r_PselectedFeatureDependency;
			}
		}

		/// <summary>
		/// Boolean samplesExpanded
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PsamplesExpanded;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPsamplesExpanded
		{
			get
			{
				if(r_PsamplesExpanded == null)
				{
					r_PsamplesExpanded = new(this, "samplesExpanded", -1);
					r_PsamplesExpanded.SetBelong(this.instance);
				}
				return r_PsamplesExpanded;
			}
		}

		/// <summary>
		/// Boolean overviewFoldoutExpanded
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PoverviewFoldoutExpanded;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPoverviewFoldoutExpanded
		{
			get
			{
				if(r_PoverviewFoldoutExpanded == null)
				{
					r_PoverviewFoldoutExpanded = new(this, "overviewFoldoutExpanded", -1);
					r_PoverviewFoldoutExpanded.SetBelong(this.instance);
				}
				return r_PoverviewFoldoutExpanded;
			}
		}

		/// <summary>
		/// Single packageDetailVerticalScrollOffset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_PpackageDetailVerticalScrollOffset;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RPpackageDetailVerticalScrollOffset
		{
			get
			{
				if(r_PpackageDetailVerticalScrollOffset == null)
				{
					r_PpackageDetailVerticalScrollOffset = new(this, "packageDetailVerticalScrollOffset", -1);
					r_PpackageDetailVerticalScrollOffset.SetBelong(this.instance);
				}
				return r_PpackageDetailVerticalScrollOffset;
			}
		}

		/// <summary>
		/// System.String selectedPackageDetailsTabIdentifier
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PselectedPackageDetailsTabIdentifier;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPselectedPackageDetailsTabIdentifier
		{
			get
			{
				if(r_PselectedPackageDetailsTabIdentifier == null)
				{
					r_PselectedPackageDetailsTabIdentifier = new(this, "selectedPackageDetailsTabIdentifier", -1);
					r_PselectedPackageDetailsTabIdentifier.SetBelong(this.instance);
				}
				return r_PselectedPackageDetailsTabIdentifier;
			}
		}

		/// <summary>
		/// System.String packageDisplayedInVersionHistoryTab
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PpackageDisplayedInVersionHistoryTab;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPpackageDisplayedInVersionHistoryTab
		{
			get
			{
				if(r_PpackageDisplayedInVersionHistoryTab == null)
				{
					r_PpackageDisplayedInVersionHistoryTab = new(this, "packageDisplayedInVersionHistoryTab", -1);
					r_PpackageDisplayedInVersionHistoryTab.SetBelong(this.instance);
				}
				return r_PpackageDisplayedInVersionHistoryTab;
			}
		}

		/// <summary>
		/// Boolean IsDetailsExtensionExpanded(System.String)
		/// </summary>
		protected RMethod r_MIsDetailsExtensionExpanded_String;
		public virtual RMethod RMIsDetailsExtensionExpanded_String
		{
			get
			{
				if(r_MIsDetailsExtensionExpanded_String == null)
				{
					r_MIsDetailsExtensionExpanded_String = new(this, "IsDetailsExtensionExpanded", 0, typeof(System.String));
					r_MIsDetailsExtensionExpanded_String.SetBelong(this.instance);
				}
				return r_MIsDetailsExtensionExpanded_String;
			}
		}

		/// <summary>
		/// Void SetDetailsExtensionExpanded(System.String, Boolean)
		/// </summary>
		protected RMethod r_MSetDetailsExtensionExpanded_String_Boolean;
		public virtual RMethod RMSetDetailsExtensionExpanded_String_Boolean
		{
			get
			{
				if(r_MSetDetailsExtensionExpanded_String_Boolean == null)
				{
					r_MSetDetailsExtensionExpanded_String_Boolean = new(this, "SetDetailsExtensionExpanded", 0, typeof(System.String), typeof(System.Boolean));
					r_MSetDetailsExtensionExpanded_String_Boolean.SetBelong(this.instance);
				}
				return r_MSetDetailsExtensionExpanded_String_Boolean;
			}
		}

		/// <summary>
		/// Void SetVersionHistoryItemExpanded(System.String, Boolean)
		/// </summary>
		protected RMethod r_MSetVersionHistoryItemExpanded_String_Boolean;
		public virtual RMethod RMSetVersionHistoryItemExpanded_String_Boolean
		{
			get
			{
				if(r_MSetVersionHistoryItemExpanded_String_Boolean == null)
				{
					r_MSetVersionHistoryItemExpanded_String_Boolean = new(this, "SetVersionHistoryItemExpanded", 0, typeof(System.String), typeof(System.Boolean));
					r_MSetVersionHistoryItemExpanded_String_Boolean.SetBelong(this.instance);
				}
				return r_MSetVersionHistoryItemExpanded_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsVersionHistoryItemExpanded(System.String)
		/// </summary>
		protected RMethod r_MIsVersionHistoryItemExpanded_String;
		public virtual RMethod RMIsVersionHistoryItemExpanded_String
		{
			get
			{
				if(r_MIsVersionHistoryItemExpanded_String == null)
				{
					r_MIsVersionHistoryItemExpanded_String = new(this, "IsVersionHistoryItemExpanded", 0, typeof(System.String));
					r_MIsVersionHistoryItemExpanded_String.SetBelong(this.instance);
				}
				return r_MIsVersionHistoryItemExpanded_String;
			}
		}

		/// <summary>
		/// Void ClearExpandedVersionHistoryItems()
		/// </summary>
		protected RMethod r_MClearExpandedVersionHistoryItems;
		public virtual RMethod RMClearExpandedVersionHistoryItems
		{
			get
			{
				if(r_MClearExpandedVersionHistoryItems == null)
				{
					r_MClearExpandedVersionHistoryItems = new(this, "ClearExpandedVersionHistoryItems", 0);
					r_MClearExpandedVersionHistoryItems.SetBelong(this.instance);
				}
				return r_MClearExpandedVersionHistoryItems;
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


        public RPackageManagerPrefs() : base("UnityEditor.PackageManager.UI.Internal.PackageManagerPrefs")
        {
        }

        public RPackageManagerPrefs(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.PackageManagerPrefs")
		{
            SetInstance(instance);
		}

        public RPackageManagerPrefs(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPackageManagerPrefs(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean IsDetailsExtensionExpanded(System.String @extensionTitle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@extensionTitle};
            var ___result = RMIsDetailsExtensionExpanded_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetDetailsExtensionExpanded(System.String @extensionTitle, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@extensionTitle, @value};
            var ___result = RMSetDetailsExtensionExpanded_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVersionHistoryItemExpanded(System.String @uniqueId, System.Boolean @expanded)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uniqueId, @expanded};
            var ___result = RMSetVersionHistoryItemExpanded_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsVersionHistoryItemExpanded(System.String @uniqueId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uniqueId};
            var ___result = RMIsVersionHistoryItemExpanded_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ClearExpandedVersionHistoryItems()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearExpandedVersionHistoryItems.Invoke(___genericsType, ___parameters);

            
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
