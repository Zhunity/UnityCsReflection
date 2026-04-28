
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.Internal.PackageListView
	/// </summary>
    public partial class RPackageListView : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageListView");
            }
        }

        public RPackageListView() : base("UnityEditor.PackageManager.UI.Internal.PackageListView")
        {
        }

        public RPackageListView(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.PackageListView")
		{
            SetInstance(instance);
		}

        public RPackageListView(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPackageListView(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Action`1[System.Object] onItemChosen
		/// </summary>
		protected REvent r_EonItemChosen;
		public virtual REvent REonItemChosen
		{
			get
			{
				if(r_EonItemChosen == null)
				{
					r_EonItemChosen = new(this, "onItemChosen");
				}
				return r_EonItemChosen;
			}
		}

		/// <summary>
		/// System.Action`1[System.Collections.Generic.IEnumerable`1[System.Object]] onItemsChosen
		/// </summary>
		protected REvent r_EonItemsChosen;
		public virtual REvent REonItemsChosen
		{
			get
			{
				if(r_EonItemsChosen == null)
				{
					r_EonItemsChosen = new(this, "onItemsChosen");
				}
				return r_EonItemsChosen;
			}
		}

		/// <summary>
		/// System.Action`1[System.Collections.Generic.List`1[System.Object]] onSelectionChanged
		/// </summary>
		protected REvent r_EonSelectionChanged;
		public virtual REvent REonSelectionChanged
		{
			get
			{
				if(r_EonSelectionChanged == null)
				{
					r_EonSelectionChanged = new(this, "onSelectionChanged");
				}
				return r_EonSelectionChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Collections.Generic.IEnumerable`1[System.Object]] onSelectionChange
		/// </summary>
		protected REvent r_EonSelectionChange;
		public virtual REvent REonSelectionChange
		{
			get
			{
				if(r_EonSelectionChange == null)
				{
					r_EonSelectionChange = new(this, "onSelectionChange");
				}
				return r_EonSelectionChange;
			}
		}

		/// <summary>
		/// System.Action`1[System.Collections.Generic.IEnumerable`1[System.Int32]] onSelectedIndicesChange
		/// </summary>
		protected REvent r_EonSelectedIndicesChange;
		public virtual REvent REonSelectedIndicesChange
		{
			get
			{
				if(r_EonSelectedIndicesChange == null)
				{
					r_EonSelectedIndicesChange = new(this, "onSelectedIndicesChange");
				}
				return r_EonSelectedIndicesChange;
			}
		}

		/// <summary>
		/// System.Action`2[System.Int32,System.Int32] itemIndexChanged
		/// </summary>
		protected REvent r_EitemIndexChanged;
		public virtual REvent REitemIndexChanged
		{
			get
			{
				if(r_EitemIndexChanged == null)
				{
					r_EitemIndexChanged = new(this, "itemIndexChanged");
				}
				return r_EitemIndexChanged;
			}
		}

		/// <summary>
		/// System.Action itemsSourceChanged
		/// </summary>
		protected REvent r_EitemsSourceChanged;
		public virtual REvent REitemsSourceChanged
		{
			get
			{
				if(r_EitemsSourceChanged == null)
				{
					r_EitemsSourceChanged = new(this, "itemsSourceChanged");
				}
				return r_EitemsSourceChanged;
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
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreCallQueue m_AssetStoreCallQueue
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreCallQueue r_Fm_AssetStoreCallQueue;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreCallQueue RFm_AssetStoreCallQueue
		{
			get
			{
				if(r_Fm_AssetStoreCallQueue == null)
				{
					r_Fm_AssetStoreCallQueue = new(this, "m_AssetStoreCallQueue");
				}
				return r_Fm_AssetStoreCallQueue;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettingsProxy m_SettingsProxy
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerProjectSettingsProxy r_Fm_SettingsProxy;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerProjectSettingsProxy RFm_SettingsProxy
		{
			get
			{
				if(r_Fm_SettingsProxy == null)
				{
					r_Fm_SettingsProxy = new(this, "m_SettingsProxy");
				}
				return r_Fm_SettingsProxy;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEditor.PackageManager.UI.Internal.PackageItem] m_PackageItemsLookup
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageItem> r_Fm_PackageItemsLookup;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageItem> RFm_PackageItemsLookup
		{
			get
			{
				if(r_Fm_PackageItemsLookup == null)
				{
					r_Fm_PackageItemsLookup = new(this, "m_PackageItemsLookup");
				}
				return r_Fm_PackageItemsLookup;
			}
		}

		/// <summary>
		/// System.Single m_FixedItemHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_FixedItemHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_FixedItemHeight
		{
			get
			{
				if(r_Fm_FixedItemHeight == null)
				{
					r_Fm_FixedItemHeight = new(this, "m_FixedItemHeight");
				}
				return r_Fm_FixedItemHeight;
			}
		}

		/// <summary>
		/// System.Boolean m_ItemHeightIsInline
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_ItemHeightIsInline;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_ItemHeightIsInline
		{
			get
			{
				if(r_Fm_ItemHeightIsInline == null)
				{
					r_Fm_ItemHeightIsInline = new(this, "m_ItemHeightIsInline");
				}
				return r_Fm_ItemHeightIsInline;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_ScrollOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Fm_ScrollOffset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFm_ScrollOffset
		{
			get
			{
				if(r_Fm_ScrollOffset == null)
				{
					r_Fm_ScrollOffset = new(this, "m_ScrollOffset");
				}
				return r_Fm_ScrollOffset;
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
		/// System.Func`2[System.Int32,System.Int32] getItemId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RSystem.RInt32> r_PgetItemId;
		public virtual Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RSystem.RInt32> RPgetItemId
		{
			get
			{
				if(r_PgetItemId == null)
				{
					r_PgetItemId = new(this, "getItemId", -1);
				}
				return r_PgetItemId;
			}
		}

		/// <summary>
		/// System.Collections.IList itemsSource
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RIList r_PitemsSource;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RIList RPitemsSource
		{
			get
			{
				if(r_PitemsSource == null)
				{
					r_PitemsSource = new(this, "itemsSource", -1);
				}
				return r_PitemsSource;
			}
		}

		/// <summary>
		/// Boolean sourceIncludesArraySize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PsourceIncludesArraySize;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPsourceIncludesArraySize
		{
			get
			{
				if(r_PsourceIncludesArraySize == null)
				{
					r_PsourceIncludesArraySize = new(this, "sourceIncludesArraySize", -1);
				}
				return r_PsourceIncludesArraySize;
			}
		}

		/// <summary>
		/// System.Func`1[UnityEngine.UIElements.VisualElement] makeItem
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> r_PmakeItem;
		public virtual Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> RPmakeItem
		{
			get
			{
				if(r_PmakeItem == null)
				{
					r_PmakeItem = new(this, "makeItem", -1);
				}
				return r_PmakeItem;
			}
		}

		/// <summary>
		/// System.Action`2[UnityEngine.UIElements.VisualElement,System.Int32] bindItem
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement, Hvak.Editor.Refleaction.RSystem.RInt32> r_PbindItem;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement, Hvak.Editor.Refleaction.RSystem.RInt32> RPbindItem
		{
			get
			{
				if(r_PbindItem == null)
				{
					r_PbindItem = new(this, "bindItem", -1);
				}
				return r_PbindItem;
			}
		}

		/// <summary>
		/// System.Action`2[UnityEngine.UIElements.VisualElement,System.Int32] unbindItem
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement, Hvak.Editor.Refleaction.RSystem.RInt32> r_PunbindItem;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement, Hvak.Editor.Refleaction.RSystem.RInt32> RPunbindItem
		{
			get
			{
				if(r_PunbindItem == null)
				{
					r_PunbindItem = new(this, "unbindItem", -1);
				}
				return r_PunbindItem;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.VisualElement] destroyItem
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> r_PdestroyItem;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> RPdestroyItem
		{
			get
			{
				if(r_PdestroyItem == null)
				{
					r_PdestroyItem = new(this, "destroyItem", -1);
				}
				return r_PdestroyItem;
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
		/// UnityEngine.UIElements.SelectionType selectionType
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RSelectionType r_PselectionType;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RSelectionType RPselectionType
		{
			get
			{
				if(r_PselectionType == null)
				{
					r_PselectionType = new(this, "selectionType", -1);
				}
				return r_PselectionType;
			}
		}

		/// <summary>
		/// System.Object selectedItem
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PselectedItem;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPselectedItem
		{
			get
			{
				if(r_PselectedItem == null)
				{
					r_PselectedItem = new(this, "selectedItem", -1);
				}
				return r_PselectedItem;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Object] selectedItems
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RObject> r_PselectedItems;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RObject> RPselectedItems
		{
			get
			{
				if(r_PselectedItems == null)
				{
					r_PselectedItems = new(this, "selectedItems", -1);
				}
				return r_PselectedItems;
			}
		}

		/// <summary>
		/// Int32 selectedIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PselectedIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPselectedIndex
		{
			get
			{
				if(r_PselectedIndex == null)
				{
					r_PselectedIndex = new(this, "selectedIndex", -1);
				}
				return r_PselectedIndex;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Int32] selectedIndices
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RInt32> r_PselectedIndices;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RInt32> RPselectedIndices
		{
			get
			{
				if(r_PselectedIndices == null)
				{
					r_PselectedIndices = new(this, "selectedIndices", -1);
				}
				return r_PselectedIndices;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] currentSelectionIds
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RInt32> r_PcurrentSelectionIds;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RInt32> RPcurrentSelectionIds
		{
			get
			{
				if(r_PcurrentSelectionIds == null)
				{
					r_PcurrentSelectionIds = new(this, "currentSelectionIds", -1);
				}
				return r_PcurrentSelectionIds;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.ReusableCollectionItem] activeItems
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RReusableCollectionItem> r_PactiveItems;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RReusableCollectionItem> RPactiveItems
		{
			get
			{
				if(r_PactiveItems == null)
				{
					r_PactiveItems = new(this, "activeItems", -1);
				}
				return r_PactiveItems;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ScrollView scrollView
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScrollView r_PscrollView;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScrollView RPscrollView
		{
			get
			{
				if(r_PscrollView == null)
				{
					r_PscrollView = new(this, "scrollView", -1);
				}
				return r_PscrollView;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ListViewDragger dragger
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RListViewDragger r_Pdragger;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RListViewDragger RPdragger
		{
			get
			{
				if(r_Pdragger == null)
				{
					r_Pdragger = new(this, "dragger", -1);
				}
				return r_Pdragger;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.CollectionViewController viewController
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RCollectionViewController r_PviewController;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RCollectionViewController RPviewController
		{
			get
			{
				if(r_PviewController == null)
				{
					r_PviewController = new(this, "viewController", -1);
				}
				return r_PviewController;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.CollectionVirtualizationController virtualizationController
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RCollectionVirtualizationController r_PvirtualizationController;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RCollectionVirtualizationController RPvirtualizationController
		{
			get
			{
				if(r_PvirtualizationController == null)
				{
					r_PvirtualizationController = new(this, "virtualizationController", -1);
				}
				return r_PvirtualizationController;
			}
		}

		/// <summary>
		/// Single resolvedItemHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PresolvedItemHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPresolvedItemHeight
		{
			get
			{
				if(r_PresolvedItemHeight == null)
				{
					r_PresolvedItemHeight = new(this, "resolvedItemHeight", -1);
				}
				return r_PresolvedItemHeight;
			}
		}

		/// <summary>
		/// Boolean showBorder
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PshowBorder;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPshowBorder
		{
			get
			{
				if(r_PshowBorder == null)
				{
					r_PshowBorder = new(this, "showBorder", -1);
				}
				return r_PshowBorder;
			}
		}

		/// <summary>
		/// Boolean reorderable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Preorderable;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPreorderable
		{
			get
			{
				if(r_Preorderable == null)
				{
					r_Preorderable = new(this, "reorderable", -1);
				}
				return r_Preorderable;
			}
		}

		/// <summary>
		/// Boolean horizontalScrollingEnabled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhorizontalScrollingEnabled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhorizontalScrollingEnabled
		{
			get
			{
				if(r_PhorizontalScrollingEnabled == null)
				{
					r_PhorizontalScrollingEnabled = new(this, "horizontalScrollingEnabled", -1);
				}
				return r_PhorizontalScrollingEnabled;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.AlternatingRowBackground showAlternatingRowBackgrounds
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlternatingRowBackground r_PshowAlternatingRowBackgrounds;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlternatingRowBackground RPshowAlternatingRowBackgrounds
		{
			get
			{
				if(r_PshowAlternatingRowBackgrounds == null)
				{
					r_PshowAlternatingRowBackgrounds = new(this, "showAlternatingRowBackgrounds", -1);
				}
				return r_PshowAlternatingRowBackgrounds;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.CollectionVirtualizationMethod virtualizationMethod
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RCollectionVirtualizationMethod r_PvirtualizationMethod;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RCollectionVirtualizationMethod RPvirtualizationMethod
		{
			get
			{
				if(r_PvirtualizationMethod == null)
				{
					r_PvirtualizationMethod = new(this, "virtualizationMethod", -1);
				}
				return r_PvirtualizationMethod;
			}
		}

		/// <summary>
		/// Int32 itemHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PitemHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPitemHeight
		{
			get
			{
				if(r_PitemHeight == null)
				{
					r_PitemHeight = new(this, "itemHeight", -1);
				}
				return r_PitemHeight;
			}
		}

		/// <summary>
		/// Single fixedItemHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PfixedItemHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPfixedItemHeight
		{
			get
			{
				if(r_PfixedItemHeight == null)
				{
					r_PfixedItemHeight = new(this, "fixedItemHeight", -1);
				}
				return r_PfixedItemHeight;
			}
		}

		/// <summary>
		/// Single lastHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PlastHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPlastHeight
		{
			get
			{
				if(r_PlastHeight == null)
				{
					r_PlastHeight = new(this, "lastHeight", -1);
				}
				return r_PlastHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IBinding binding
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIBinding r_Pbinding;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIBinding RPbinding
		{
			get
			{
				if(r_Pbinding == null)
				{
					r_Pbinding = new(this, "binding", -1);
				}
				return r_Pbinding;
			}
		}

		/// <summary>
		/// System.String bindingPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PbindingPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPbindingPath
		{
			get
			{
				if(r_PbindingPath == null)
				{
					r_PbindingPath = new(this, "bindingPath", -1);
				}
				return r_PbindingPath;
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
		/// Void SyncPageManagerSelectionToListView(UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MSyncPageManagerSelectionToListView_IPackageVersion;
		public virtual RMethod RMSyncPageManagerSelectionToListView_IPackageVersion
		{
			get
			{
				if(r_MSyncPageManagerSelectionToListView_IPackageVersion == null)
				{
					r_MSyncPageManagerSelectionToListView_IPackageVersion = new(this, "SyncPageManagerSelectionToListView", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
				}
				return r_MSyncPageManagerSelectionToListView_IPackageVersion;
			}
		}

		/// <summary>
		/// Void SyncListViewSelectionToPageManager(System.Collections.Generic.IEnumerable`1[System.Object])
		/// </summary>
		protected RMethod r_MSyncListViewSelectionToPageManager_IEnumerable_d_Object_p_;
		public virtual RMethod RMSyncListViewSelectionToPageManager_IEnumerable_d_Object_p_
		{
			get
			{
				if(r_MSyncListViewSelectionToPageManager_IEnumerable_d_Object_p_ == null)
				{
					r_MSyncListViewSelectionToPageManager_IEnumerable_d_Object_p_ = new(this, "SyncListViewSelectionToPageManager", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(typeof(System.Object)));
				}
				return r_MSyncListViewSelectionToPageManager_IEnumerable_d_Object_p_;
			}
		}

		/// <summary>
		/// Void UnbindItem(UnityEngine.UIElements.VisualElement, Int32)
		/// </summary>
		protected RMethod r_MUnbindItem_VisualElement_Int32;
		public virtual RMethod RMUnbindItem_VisualElement_Int32
		{
			get
			{
				if(r_MUnbindItem_VisualElement_Int32 == null)
				{
					r_MUnbindItem_VisualElement_Int32 = new(this, "UnbindItem", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Int32));
				}
				return r_MUnbindItem_VisualElement_Int32;
			}
		}

		/// <summary>
		/// Void BindItem(UnityEngine.UIElements.VisualElement, Int32)
		/// </summary>
		protected RMethod r_MBindItem_VisualElement_Int32;
		public virtual RMethod RMBindItem_VisualElement_Int32
		{
			get
			{
				if(r_MBindItem_VisualElement_Int32 == null)
				{
					r_MBindItem_VisualElement_Int32 = new(this, "BindItem", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Int32));
				}
				return r_MBindItem_VisualElement_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement MakeItem()
		/// </summary>
		protected RMethod r_MMakeItem;
		public virtual RMethod RMMakeItem
		{
			get
			{
				if(r_MMakeItem == null)
				{
					r_MMakeItem = new(this, "MakeItem", 0);
				}
				return r_MMakeItem;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageItem GetPackageItem(System.String)
		/// </summary>
		protected RMethod r_MGetPackageItem_String;
		public virtual RMethod RMGetPackageItem_String
		{
			get
			{
				if(r_MGetPackageItem_String == null)
				{
					r_MGetPackageItem_String = new(this, "GetPackageItem", 0, typeof(System.String));
				}
				return r_MGetPackageItem_String;
			}
		}

		/// <summary>
		/// Boolean UpdateItemsSource(System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.VisualState], Boolean)
		/// </summary>
		protected RMethod r_MUpdateItemsSource_List_d_VisualState_p__Boolean;
		public virtual RMethod RMUpdateItemsSource_List_d_VisualState_p__Boolean
		{
			get
			{
				if(r_MUpdateItemsSource_List_d_VisualState_p__Boolean == null)
				{
					r_MUpdateItemsSource_List_d_VisualState_p__Boolean = new(this, "UpdateItemsSource", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.VisualState")), typeof(System.Boolean));
				}
				return r_MUpdateItemsSource_List_d_VisualState_p__Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.VisualState GetVisualStateByIndex(Int32)
		/// </summary>
		protected RMethod r_MGetVisualStateByIndex_Int32;
		public virtual RMethod RMGetVisualStateByIndex_Int32
		{
			get
			{
				if(r_MGetVisualStateByIndex_Int32 == null)
				{
					r_MGetVisualStateByIndex_Int32 = new(this, "GetVisualStateByIndex", 0, typeof(System.Int32));
				}
				return r_MGetVisualStateByIndex_Int32;
			}
		}

		/// <summary>
		/// Void SyncSelectionIndex(System.String)
		/// </summary>
		protected RMethod r_MSyncSelectionIndex_String;
		public virtual RMethod RMSyncSelectionIndex_String
		{
			get
			{
				if(r_MSyncSelectionIndex_String == null)
				{
					r_MSyncSelectionIndex_String = new(this, "SyncSelectionIndex", 0, typeof(System.String));
				}
				return r_MSyncSelectionIndex_String;
			}
		}

		/// <summary>
		/// Void ScrollToSelection()
		/// </summary>
		protected RMethod r_MScrollToSelection;
		public virtual RMethod RMScrollToSelection
		{
			get
			{
				if(r_MScrollToSelection == null)
				{
					r_MScrollToSelection = new(this, "ScrollToSelection", 0);
				}
				return r_MScrollToSelection;
			}
		}

		/// <summary>
		/// Void OnVisualStateChange(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.VisualState])
		/// </summary>
		protected RMethod r_MOnVisualStateChange_IEnumerable_d_VisualState_p_;
		public virtual RMethod RMOnVisualStateChange_IEnumerable_d_VisualState_p_
		{
			get
			{
				if(r_MOnVisualStateChange_IEnumerable_d_VisualState_p_ == null)
				{
					r_MOnVisualStateChange_IEnumerable_d_VisualState_p_ = new(this, "OnVisualStateChange", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.VisualState")));
				}
				return r_MOnVisualStateChange_IEnumerable_d_VisualState_p_;
			}
		}

		/// <summary>
		/// Void OnListRebuild(UnityEditor.PackageManager.UI.Internal.IPage)
		/// </summary>
		protected RMethod r_MOnListRebuild_IPage;
		public virtual RMethod RMOnListRebuild_IPage
		{
			get
			{
				if(r_MOnListRebuild_IPage == null)
				{
					r_MOnListRebuild_IPage = new(this, "OnListRebuild", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPage"));
				}
				return r_MOnListRebuild_IPage;
			}
		}

		/// <summary>
		/// Void OnListUpdate(UnityEditor.PackageManager.UI.Internal.ListUpdateArgs)
		/// </summary>
		protected RMethod r_MOnListUpdate_ListUpdateArgs;
		public virtual RMethod RMOnListUpdate_ListUpdateArgs
		{
			get
			{
				if(r_MOnListUpdate_ListUpdateArgs == null)
				{
					r_MOnListUpdate_ListUpdateArgs = new(this, "OnListUpdate", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.ListUpdateArgs"));
				}
				return r_MOnListUpdate_ListUpdateArgs;
			}
		}

		/// <summary>
		/// Void OnFilterTabChanged(UnityEditor.PackageManager.UI.Internal.PackageFilterTab)
		/// </summary>
		protected RMethod r_MOnFilterTabChanged_PackageFilterTab;
		public virtual RMethod RMOnFilterTabChanged_PackageFilterTab
		{
			get
			{
				if(r_MOnFilterTabChanged_PackageFilterTab == null)
				{
					r_MOnFilterTabChanged_PackageFilterTab = new(this, "OnFilterTabChanged", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageFilterTab"));
				}
				return r_MOnFilterTabChanged_PackageFilterTab;
			}
		}

		/// <summary>
		/// Void OnSeeAllPackageVersionsChanged(Boolean)
		/// </summary>
		protected RMethod r_MOnSeeAllPackageVersionsChanged_Boolean;
		public virtual RMethod RMOnSeeAllPackageVersionsChanged_Boolean
		{
			get
			{
				if(r_MOnSeeAllPackageVersionsChanged_Boolean == null)
				{
					r_MOnSeeAllPackageVersionsChanged_Boolean = new(this, "OnSeeAllPackageVersionsChanged", 0, typeof(System.Boolean));
				}
				return r_MOnSeeAllPackageVersionsChanged_Boolean;
			}
		}

		/// <summary>
		/// Void OnKeyDownShortcut(UnityEngine.UIElements.KeyDownEvent)
		/// </summary>
		protected RMethod r_MOnKeyDownShortcut_KeyDownEvent;
		public virtual RMethod RMOnKeyDownShortcut_KeyDownEvent
		{
			get
			{
				if(r_MOnKeyDownShortcut_KeyDownEvent == null)
				{
					r_MOnKeyDownShortcut_KeyDownEvent = new(this, "OnKeyDownShortcut", 0, typeof(UnityEngine.UIElements.KeyDownEvent));
				}
				return r_MOnKeyDownShortcut_KeyDownEvent;
			}
		}

		/// <summary>
		/// Boolean SelectNext(Boolean)
		/// </summary>
		protected RMethod r_MSelectNext_Boolean;
		public virtual RMethod RMSelectNext_Boolean
		{
			get
			{
				if(r_MSelectNext_Boolean == null)
				{
					r_MSelectNext_Boolean = new(this, "SelectNext", 0, typeof(System.Boolean));
				}
				return r_MSelectNext_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ICollectionDragAndDropController CreateDragAndDropController()
		/// </summary>
		protected RMethod r_MCreateDragAndDropController;
		public virtual RMethod RMCreateDragAndDropController
		{
			get
			{
				if(r_MCreateDragAndDropController == null)
				{
					r_MCreateDragAndDropController = new(this, "CreateDragAndDropController", 0);
				}
				return r_MCreateDragAndDropController;
			}
		}

		/// <summary>
		/// Void SetMakeItemWithoutNotify(System.Func`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_MSetMakeItemWithoutNotify_Func_d_VisualElement_p_;
		public virtual RMethod RMSetMakeItemWithoutNotify_Func_d_VisualElement_p_
		{
			get
			{
				if(r_MSetMakeItemWithoutNotify_Func_d_VisualElement_p_ == null)
				{
					r_MSetMakeItemWithoutNotify_Func_d_VisualElement_p_ = new(this, "SetMakeItemWithoutNotify", 0,  ReflectionUtils.GetType("System.Func`1").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
				}
				return r_MSetMakeItemWithoutNotify_Func_d_VisualElement_p_;
			}
		}

		/// <summary>
		/// Void SetBindItemWithoutNotify(System.Action`2[UnityEngine.UIElements.VisualElement,System.Int32])
		/// </summary>
		protected RMethod r_MSetBindItemWithoutNotify_Action_d_VisualElement_Int32_p_;
		public virtual RMethod RMSetBindItemWithoutNotify_Action_d_VisualElement_Int32_p_
		{
			get
			{
				if(r_MSetBindItemWithoutNotify_Action_d_VisualElement_Int32_p_ == null)
				{
					r_MSetBindItemWithoutNotify_Action_d_VisualElement_Int32_p_ = new(this, "SetBindItemWithoutNotify", 0,  ReflectionUtils.GetType("System.Action`2").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(System.Int32)));
				}
				return r_MSetBindItemWithoutNotify_Action_d_VisualElement_Int32_p_;
			}
		}

		/// <summary>
		/// Single ResolveItemHeight(Single)
		/// </summary>
		protected RMethod r_MResolveItemHeight_Single;
		public virtual RMethod RMResolveItemHeight_Single
		{
			get
			{
				if(r_MResolveItemHeight_Single == null)
				{
					r_MResolveItemHeight_Single = new(this, "ResolveItemHeight", 0, typeof(System.Single));
				}
				return r_MResolveItemHeight_Single;
			}
		}

		/// <summary>
		/// Void CreateVirtualizationController()
		/// </summary>
		protected RMethod r_MCreateVirtualizationController;
		public virtual RMethod RMCreateVirtualizationController
		{
			get
			{
				if(r_MCreateVirtualizationController == null)
				{
					r_MCreateVirtualizationController = new(this, "CreateVirtualizationController", 0);
				}
				return r_MCreateVirtualizationController;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.CollectionVirtualizationController GetOrCreateVirtualizationController()
		/// </summary>
		protected RMethod r_MGetOrCreateVirtualizationController;
		public virtual RMethod RMGetOrCreateVirtualizationController
		{
			get
			{
				if(r_MGetOrCreateVirtualizationController == null)
				{
					r_MGetOrCreateVirtualizationController = new(this, "GetOrCreateVirtualizationController", 0);
				}
				return r_MGetOrCreateVirtualizationController;
			}
		}

		/// <summary>
		/// Void CreateVirtualizationController[T]()
		/// </summary>
		protected RMethod r_MCreateVirtualizationController_GT;
		public virtual RMethod RMCreateVirtualizationController_GT
		{
			get
			{
				if(r_MCreateVirtualizationController_GT == null)
				{
					r_MCreateVirtualizationController_GT = new(this, "CreateVirtualizationController", 1);
				}
				return r_MCreateVirtualizationController_GT;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.CollectionViewController GetOrCreateViewController()
		/// </summary>
		protected RMethod r_MGetOrCreateViewController;
		public virtual RMethod RMGetOrCreateViewController
		{
			get
			{
				if(r_MGetOrCreateViewController == null)
				{
					r_MGetOrCreateViewController = new(this, "GetOrCreateViewController", 0);
				}
				return r_MGetOrCreateViewController;
			}
		}

		/// <summary>
		/// Void CreateViewController()
		/// </summary>
		protected RMethod r_MCreateViewController;
		public virtual RMethod RMCreateViewController
		{
			get
			{
				if(r_MCreateViewController == null)
				{
					r_MCreateViewController = new(this, "CreateViewController", 0);
				}
				return r_MCreateViewController;
			}
		}

		/// <summary>
		/// Void SetViewController(UnityEngine.UIElements.CollectionViewController)
		/// </summary>
		protected RMethod r_MSetViewController_CollectionViewController;
		public virtual RMethod RMSetViewController_CollectionViewController
		{
			get
			{
				if(r_MSetViewController_CollectionViewController == null)
				{
					r_MSetViewController_CollectionViewController = new(this, "SetViewController", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.CollectionViewController"));
				}
				return r_MSetViewController_CollectionViewController;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ListViewDragger CreateDragger()
		/// </summary>
		protected RMethod r_MCreateDragger;
		public virtual RMethod RMCreateDragger
		{
			get
			{
				if(r_MCreateDragger == null)
				{
					r_MCreateDragger = new(this, "CreateDragger", 0);
				}
				return r_MCreateDragger;
			}
		}

		/// <summary>
		/// Void InitializeDragAndDropController()
		/// </summary>
		protected RMethod r_MInitializeDragAndDropController;
		public virtual RMethod RMInitializeDragAndDropController
		{
			get
			{
				if(r_MInitializeDragAndDropController == null)
				{
					r_MInitializeDragAndDropController = new(this, "InitializeDragAndDropController", 0);
				}
				return r_MInitializeDragAndDropController;
			}
		}

		/// <summary>
		/// Void SetDragAndDropController(UnityEngine.UIElements.ICollectionDragAndDropController)
		/// </summary>
		protected RMethod r_MSetDragAndDropController_ICollectionDragAndDropController;
		public virtual RMethod RMSetDragAndDropController_ICollectionDragAndDropController
		{
			get
			{
				if(r_MSetDragAndDropController_ICollectionDragAndDropController == null)
				{
					r_MSetDragAndDropController_ICollectionDragAndDropController = new(this, "SetDragAndDropController", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ICollectionDragAndDropController"));
				}
				return r_MSetDragAndDropController_ICollectionDragAndDropController;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ICollectionDragAndDropController GetDragAndDropController()
		/// </summary>
		protected RMethod r_MGetDragAndDropController;
		public virtual RMethod RMGetDragAndDropController
		{
			get
			{
				if(r_MGetDragAndDropController == null)
				{
					r_MGetDragAndDropController = new(this, "GetDragAndDropController", 0);
				}
				return r_MGetDragAndDropController;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetRootElementForId(Int32)
		/// </summary>
		protected RMethod r_MGetRootElementForId_Int32;
		public virtual RMethod RMGetRootElementForId_Int32
		{
			get
			{
				if(r_MGetRootElementForId_Int32 == null)
				{
					r_MGetRootElementForId_Int32 = new(this, "GetRootElementForId", 0, typeof(System.Int32));
				}
				return r_MGetRootElementForId_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetRootElementForIndex(Int32)
		/// </summary>
		protected RMethod r_MGetRootElementForIndex_Int32;
		public virtual RMethod RMGetRootElementForIndex_Int32
		{
			get
			{
				if(r_MGetRootElementForIndex_Int32 == null)
				{
					r_MGetRootElementForIndex_Int32 = new(this, "GetRootElementForIndex", 0, typeof(System.Int32));
				}
				return r_MGetRootElementForIndex_Int32;
			}
		}

		/// <summary>
		/// Boolean HasValidDataAndBindings()
		/// </summary>
		protected RMethod r_MHasValidDataAndBindings;
		public virtual RMethod RMHasValidDataAndBindings
		{
			get
			{
				if(r_MHasValidDataAndBindings == null)
				{
					r_MHasValidDataAndBindings = new(this, "HasValidDataAndBindings", 0);
				}
				return r_MHasValidDataAndBindings;
			}
		}

		/// <summary>
		/// Void RefreshItem(Int32)
		/// </summary>
		protected RMethod r_MRefreshItem_Int32;
		public virtual RMethod RMRefreshItem_Int32
		{
			get
			{
				if(r_MRefreshItem_Int32 == null)
				{
					r_MRefreshItem_Int32 = new(this, "RefreshItem", 0, typeof(System.Int32));
				}
				return r_MRefreshItem_Int32;
			}
		}

		/// <summary>
		/// Void RefreshItems()
		/// </summary>
		protected RMethod r_MRefreshItems;
		public virtual RMethod RMRefreshItems
		{
			get
			{
				if(r_MRefreshItems == null)
				{
					r_MRefreshItems = new(this, "RefreshItems", 0);
				}
				return r_MRefreshItems;
			}
		}

		/// <summary>
		/// Void Refresh()
		/// </summary>
		protected RMethod r_MRefresh;
		public virtual RMethod RMRefresh
		{
			get
			{
				if(r_MRefresh == null)
				{
					r_MRefresh = new(this, "Refresh", 0);
				}
				return r_MRefresh;
			}
		}

		/// <summary>
		/// Void Rebuild()
		/// </summary>
		protected RMethod r_MRebuild;
		public virtual RMethod RMRebuild
		{
			get
			{
				if(r_MRebuild == null)
				{
					r_MRebuild = new(this, "Rebuild", 0);
				}
				return r_MRebuild;
			}
		}

		/// <summary>
		/// Void PostRefresh()
		/// </summary>
		protected RMethod r_MPostRefresh;
		public virtual RMethod RMPostRefresh
		{
			get
			{
				if(r_MPostRefresh == null)
				{
					r_MPostRefresh = new(this, "PostRefresh", 0);
				}
				return r_MPostRefresh;
			}
		}

		/// <summary>
		/// Void ScrollTo(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MScrollTo_VisualElement;
		public virtual RMethod RMScrollTo_VisualElement
		{
			get
			{
				if(r_MScrollTo_VisualElement == null)
				{
					r_MScrollTo_VisualElement = new(this, "ScrollTo", 0, typeof(UnityEngine.UIElements.VisualElement));
				}
				return r_MScrollTo_VisualElement;
			}
		}

		/// <summary>
		/// Void ScrollToItem(Int32)
		/// </summary>
		protected RMethod r_MScrollToItem_Int32;
		public virtual RMethod RMScrollToItem_Int32
		{
			get
			{
				if(r_MScrollToItem_Int32 == null)
				{
					r_MScrollToItem_Int32 = new(this, "ScrollToItem", 0, typeof(System.Int32));
				}
				return r_MScrollToItem_Int32;
			}
		}

		/// <summary>
		/// Void ScrollToId(Int32)
		/// </summary>
		protected RMethod r_MScrollToId_Int32;
		public virtual RMethod RMScrollToId_Int32
		{
			get
			{
				if(r_MScrollToId_Int32 == null)
				{
					r_MScrollToId_Int32 = new(this, "ScrollToId", 0, typeof(System.Int32));
				}
				return r_MScrollToId_Int32;
			}
		}

		/// <summary>
		/// Void OnKeyDown(UnityEngine.UIElements.KeyDownEvent)
		/// </summary>
		protected RMethod r_MOnKeyDown_KeyDownEvent;
		public virtual RMethod RMOnKeyDown_KeyDownEvent
		{
			get
			{
				if(r_MOnKeyDown_KeyDownEvent == null)
				{
					r_MOnKeyDown_KeyDownEvent = new(this, "OnKeyDown", 0, typeof(UnityEngine.UIElements.KeyDownEvent));
				}
				return r_MOnKeyDown_KeyDownEvent;
			}
		}

		/// <summary>
		/// Void SelectAll()
		/// </summary>
		protected RMethod r_MSelectAll;
		public virtual RMethod RMSelectAll
		{
			get
			{
				if(r_MSelectAll == null)
				{
					r_MSelectAll = new(this, "SelectAll", 0);
				}
				return r_MSelectAll;
			}
		}

		/// <summary>
		/// Void AddToSelection(Int32)
		/// </summary>
		protected RMethod r_MAddToSelection_Int32;
		public virtual RMethod RMAddToSelection_Int32
		{
			get
			{
				if(r_MAddToSelection_Int32 == null)
				{
					r_MAddToSelection_Int32 = new(this, "AddToSelection", 0, typeof(System.Int32));
				}
				return r_MAddToSelection_Int32;
			}
		}

		/// <summary>
		/// Void AddToSelection(System.Collections.Generic.IList`1[System.Int32])
		/// </summary>
		protected RMethod r_MAddToSelection_IList_d_Int32_p_;
		public virtual RMethod RMAddToSelection_IList_d_Int32_p_
		{
			get
			{
				if(r_MAddToSelection_IList_d_Int32_p_ == null)
				{
					r_MAddToSelection_IList_d_Int32_p_ = new(this, "AddToSelection", 0,  ReflectionUtils.GetType("System.Collections.Generic.IList`1").MakeGenericType(typeof(System.Int32)));
				}
				return r_MAddToSelection_IList_d_Int32_p_;
			}
		}

		/// <summary>
		/// Void RemoveFromSelection(Int32)
		/// </summary>
		protected RMethod r_MRemoveFromSelection_Int32;
		public virtual RMethod RMRemoveFromSelection_Int32
		{
			get
			{
				if(r_MRemoveFromSelection_Int32 == null)
				{
					r_MRemoveFromSelection_Int32 = new(this, "RemoveFromSelection", 0, typeof(System.Int32));
				}
				return r_MRemoveFromSelection_Int32;
			}
		}

		/// <summary>
		/// Void SetSelection(Int32)
		/// </summary>
		protected RMethod r_MSetSelection_Int32;
		public virtual RMethod RMSetSelection_Int32
		{
			get
			{
				if(r_MSetSelection_Int32 == null)
				{
					r_MSetSelection_Int32 = new(this, "SetSelection", 0, typeof(System.Int32));
				}
				return r_MSetSelection_Int32;
			}
		}

		/// <summary>
		/// Void SetSelection(System.Collections.Generic.IEnumerable`1[System.Int32])
		/// </summary>
		protected RMethod r_MSetSelection_IEnumerable_d_Int32_p_;
		public virtual RMethod RMSetSelection_IEnumerable_d_Int32_p_
		{
			get
			{
				if(r_MSetSelection_IEnumerable_d_Int32_p_ == null)
				{
					r_MSetSelection_IEnumerable_d_Int32_p_ = new(this, "SetSelection", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(typeof(System.Int32)));
				}
				return r_MSetSelection_IEnumerable_d_Int32_p_;
			}
		}

		/// <summary>
		/// Void SetSelectionWithoutNotify(System.Collections.Generic.IEnumerable`1[System.Int32])
		/// </summary>
		protected RMethod r_MSetSelectionWithoutNotify_IEnumerable_d_Int32_p_;
		public virtual RMethod RMSetSelectionWithoutNotify_IEnumerable_d_Int32_p_
		{
			get
			{
				if(r_MSetSelectionWithoutNotify_IEnumerable_d_Int32_p_ == null)
				{
					r_MSetSelectionWithoutNotify_IEnumerable_d_Int32_p_ = new(this, "SetSelectionWithoutNotify", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(typeof(System.Int32)));
				}
				return r_MSetSelectionWithoutNotify_IEnumerable_d_Int32_p_;
			}
		}

		/// <summary>
		/// Void SetSelectionInternal(System.Collections.Generic.IEnumerable`1[System.Int32], Boolean)
		/// </summary>
		protected RMethod r_MSetSelectionInternal_IEnumerable_d_Int32_p__Boolean;
		public virtual RMethod RMSetSelectionInternal_IEnumerable_d_Int32_p__Boolean
		{
			get
			{
				if(r_MSetSelectionInternal_IEnumerable_d_Int32_p__Boolean == null)
				{
					r_MSetSelectionInternal_IEnumerable_d_Int32_p__Boolean = new(this, "SetSelectionInternal", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(typeof(System.Int32)), typeof(System.Boolean));
				}
				return r_MSetSelectionInternal_IEnumerable_d_Int32_p__Boolean;
			}
		}

		/// <summary>
		/// Void ClearSelection()
		/// </summary>
		protected RMethod r_MClearSelection;
		public virtual RMethod RMClearSelection
		{
			get
			{
				if(r_MClearSelection == null)
				{
					r_MClearSelection = new(this, "ClearSelection", 0);
				}
				return r_MClearSelection;
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


        public virtual void SyncPageManagerSelectionToListView(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value};
            var ___result = RMSyncPageManagerSelectionToListView_IPackageVersion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SyncListViewSelectionToPageManager(System.Collections.Generic.IEnumerable<System.Object> @items)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@items};
            var ___result = RMSyncListViewSelectionToPageManager_IEnumerable_d_Object_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnbindItem(UnityEngine.UIElements.VisualElement @item, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item, @index};
            var ___result = RMUnbindItem_VisualElement_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BindItem(UnityEngine.UIElements.VisualElement @item, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item, @index};
            var ___result = RMBindItem_VisualElement_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.VisualElement MakeItem()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMakeItem.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageItem GetPackageItem(System.String @packageUniqueId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueId};
            var ___result = RMGetPackageItem_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageItem>(___result);
        }


        public virtual System.Boolean UpdateItemsSource(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState> @visualStates, System.Boolean @forceRefesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@visualStates.Value, @forceRefesh};
            var ___result = RMUpdateItemsSource_List_d_VisualState_p__Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState GetVisualStateByIndex(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetVisualStateByIndex_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState>(___result);
        }


        public virtual void SyncSelectionIndex(System.String @selectedPackageUniqueIdInPageManager)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@selectedPackageUniqueIdInPageManager};
            var ___result = RMSyncSelectionIndex_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ScrollToSelection()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMScrollToSelection.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnVisualStateChange(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState> @visualStates)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@visualStates.Value};
            var ___result = RMOnVisualStateChange_IEnumerable_d_VisualState_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnListRebuild(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPage @page)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@page.Value};
            var ___result = RMOnListRebuild_IPage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnListUpdate(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RListUpdateArgs @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args.Value};
            var ___result = RMOnListUpdate_ListUpdateArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnFilterTabChanged(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab @filterTab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filterTab.Value};
            var ___result = RMOnFilterTabChanged_PackageFilterTab.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnSeeAllPackageVersionsChanged(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMOnSeeAllPackageVersionsChanged_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnKeyDownShortcut(UnityEngine.UIElements.KeyDownEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnKeyDownShortcut_KeyDownEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SelectNext(System.Boolean @reverseOrder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reverseOrder};
            var ___result = RMSelectNext_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RICollectionDragAndDropController CreateDragAndDropController()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateDragAndDropController.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RICollectionDragAndDropController>(___result);
        }


        public virtual void SetMakeItemWithoutNotify(System.Func<UnityEngine.UIElements.VisualElement> @func)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@func};
            var ___result = RMSetMakeItemWithoutNotify_Func_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBindItemWithoutNotify(System.Action<UnityEngine.UIElements.VisualElement, System.Int32> @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback};
            var ___result = RMSetBindItemWithoutNotify_Action_d_VisualElement_Int32_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single ResolveItemHeight(System.Single @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@height};
            var ___result = RMResolveItemHeight_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual void CreateVirtualizationController()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateVirtualizationController.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RCollectionVirtualizationController GetOrCreateVirtualizationController()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetOrCreateVirtualizationController.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RCollectionVirtualizationController>(___result);
        }


        public virtual void CreateVirtualizationController<T>() where T : new()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMCreateVirtualizationController_GT.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RCollectionViewController GetOrCreateViewController()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetOrCreateViewController.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RCollectionViewController>(___result);
        }


        public virtual void CreateViewController()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateViewController.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetViewController(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RCollectionViewController @controller)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@controller.Value};
            var ___result = RMSetViewController_CollectionViewController.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RListViewDragger CreateDragger()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateDragger.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RListViewDragger>(___result);
        }


        public virtual void InitializeDragAndDropController()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitializeDragAndDropController.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDragAndDropController(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RICollectionDragAndDropController @dragAndDropController)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dragAndDropController.Value};
            var ___result = RMSetDragAndDropController_ICollectionDragAndDropController.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RICollectionDragAndDropController GetDragAndDropController()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDragAndDropController.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RICollectionDragAndDropController>(___result);
        }


        public virtual UnityEngine.UIElements.VisualElement GetRootElementForId(System.Int32 @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RMGetRootElementForId_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


        public virtual UnityEngine.UIElements.VisualElement GetRootElementForIndex(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetRootElementForIndex_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


        public virtual System.Boolean HasValidDataAndBindings()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasValidDataAndBindings.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void RefreshItem(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMRefreshItem_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RefreshItems()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefreshItems.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Refresh()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefresh.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Rebuild()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRebuild.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PostRefresh()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPostRefresh.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ScrollTo(UnityEngine.UIElements.VisualElement @visualElement)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@visualElement};
            var ___result = RMScrollTo_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ScrollToItem(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMScrollToItem_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ScrollToId(System.Int32 @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RMScrollToId_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnKeyDown(UnityEngine.UIElements.KeyDownEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnKeyDown_KeyDownEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectAll()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSelectAll.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddToSelection(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMAddToSelection_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddToSelection(System.Collections.Generic.IList<System.Int32> @indexes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexes};
            var ___result = RMAddToSelection_IList_d_Int32_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFromSelection(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMRemoveFromSelection_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSelection(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMSetSelection_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSelection(System.Collections.Generic.IEnumerable<System.Int32> @indices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices};
            var ___result = RMSetSelection_IEnumerable_d_Int32_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSelectionWithoutNotify(System.Collections.Generic.IEnumerable<System.Int32> @indices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices};
            var ___result = RMSetSelectionWithoutNotify_IEnumerable_d_Int32_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSelectionInternal(System.Collections.Generic.IEnumerable<System.Int32> @indices, System.Boolean @sendNotification)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @sendNotification};
            var ___result = RMSetSelectionInternal_IEnumerable_d_Int32_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearSelection()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearSelection.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnViewDataReady()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnViewDataReady.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteDefaultAction(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMExecuteDefaultAction_EventBase.Invoke(___genericsType, ___parameters);

            
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
