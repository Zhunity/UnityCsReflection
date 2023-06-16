
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.UIElements.BaseListViewController
	/// </summary>
    public partial class RBaseListViewController : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.BaseListViewController);
            }
        }

        public RBaseListViewController() : base("UnityEngine.UIElements.BaseListViewController")
        {
        }

        public RBaseListViewController(System.Object instance) : base("UnityEngine.UIElements.BaseListViewController")
		{
            SetInstance(instance);
		}

        public RBaseListViewController(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBaseListViewController(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Action itemsSourceSizeChanged
		/// </summary>
		protected REvent r_EitemsSourceSizeChanged;
		public virtual REvent REitemsSourceSizeChanged
		{
			get
			{
				if(r_EitemsSourceSizeChanged == null)
				{
					r_EitemsSourceSizeChanged = new(this, "itemsSourceSizeChanged");
				}
				return r_EitemsSourceSizeChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Collections.Generic.IEnumerable`1[System.Int32]] itemsAdded
		/// </summary>
		protected REvent r_EitemsAdded;
		public virtual REvent REitemsAdded
		{
			get
			{
				if(r_EitemsAdded == null)
				{
					r_EitemsAdded = new(this, "itemsAdded");
				}
				return r_EitemsAdded;
			}
		}

		/// <summary>
		/// System.Action`1[System.Collections.Generic.IEnumerable`1[System.Int32]] itemsRemoved
		/// </summary>
		protected REvent r_EitemsRemoved;
		public virtual REvent REitemsRemoved
		{
			get
			{
				if(r_EitemsRemoved == null)
				{
					r_EitemsRemoved = new(this, "itemsRemoved");
				}
				return r_EitemsRemoved;
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
		/// System.Action itemsSourceSizeChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_FitemsSourceSizeChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFitemsSourceSizeChanged
		{
			get
			{
				if(r_FitemsSourceSizeChanged == null)
				{
					r_FitemsSourceSizeChanged = new(this, "itemsSourceSizeChanged");
				}
				return r_FitemsSourceSizeChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Collections.Generic.IEnumerable`1[System.Int32]] itemsAdded
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RInt32>> r_FitemsAdded;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RInt32>> RFitemsAdded
		{
			get
			{
				if(r_FitemsAdded == null)
				{
					r_FitemsAdded = new(this, "itemsAdded");
				}
				return r_FitemsAdded;
			}
		}

		/// <summary>
		/// System.Action`1[System.Collections.Generic.IEnumerable`1[System.Int32]] itemsRemoved
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RInt32>> r_FitemsRemoved;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RInt32>> RFitemsRemoved
		{
			get
			{
				if(r_FitemsRemoved == null)
				{
					r_FitemsRemoved = new(this, "itemsRemoved");
				}
				return r_FitemsRemoved;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BaseListView baseListView
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseListView r_PbaseListView;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseListView RPbaseListView
		{
			get
			{
				if(r_PbaseListView == null)
				{
					r_PbaseListView = new(this, "baseListView", -1);
				}
				return r_PbaseListView;
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
		/// UnityEngine.UIElements.BaseVerticalCollectionView view
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVerticalCollectionView r_Pview;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVerticalCollectionView RPview
		{
			get
			{
				if(r_Pview == null)
				{
					r_Pview = new(this, "view", -1);
				}
				return r_Pview;
			}
		}

		/// <summary>
		/// Void InvokeMakeItem(UnityEngine.UIElements.ReusableCollectionItem)
		/// </summary>
		protected RMethod r_MInvokeMakeItem_ReusableCollectionItem;
		public virtual RMethod RMInvokeMakeItem_ReusableCollectionItem
		{
			get
			{
				if(r_MInvokeMakeItem_ReusableCollectionItem == null)
				{
					r_MInvokeMakeItem_ReusableCollectionItem = new(this, "InvokeMakeItem", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ReusableCollectionItem"));
				}
				return r_MInvokeMakeItem_ReusableCollectionItem;
			}
		}

		/// <summary>
		/// Void PostInitRegistration(UnityEngine.UIElements.ReusableListViewItem)
		/// </summary>
		protected RMethod r_MPostInitRegistration_ReusableListViewItem;
		public virtual RMethod RMPostInitRegistration_ReusableListViewItem
		{
			get
			{
				if(r_MPostInitRegistration_ReusableListViewItem == null)
				{
					r_MPostInitRegistration_ReusableListViewItem = new(this, "PostInitRegistration", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ReusableListViewItem"));
				}
				return r_MPostInitRegistration_ReusableListViewItem;
			}
		}

		/// <summary>
		/// Void InvokeBindItem(UnityEngine.UIElements.ReusableCollectionItem, Int32)
		/// </summary>
		protected RMethod r_MInvokeBindItem_ReusableCollectionItem_Int32;
		public virtual RMethod RMInvokeBindItem_ReusableCollectionItem_Int32
		{
			get
			{
				if(r_MInvokeBindItem_ReusableCollectionItem_Int32 == null)
				{
					r_MInvokeBindItem_ReusableCollectionItem_Int32 = new(this, "InvokeBindItem", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ReusableCollectionItem"), typeof(System.Int32));
				}
				return r_MInvokeBindItem_ReusableCollectionItem_Int32;
			}
		}

		/// <summary>
		/// Boolean NeedsDragHandle(Int32)
		/// </summary>
		protected RMethod r_MNeedsDragHandle_Int32;
		public virtual RMethod RMNeedsDragHandle_Int32
		{
			get
			{
				if(r_MNeedsDragHandle_Int32 == null)
				{
					r_MNeedsDragHandle_Int32 = new(this, "NeedsDragHandle", 0, typeof(System.Int32));
				}
				return r_MNeedsDragHandle_Int32;
			}
		}

		/// <summary>
		/// Void AddItems(Int32)
		/// </summary>
		protected RMethod r_MAddItems_Int32;
		public virtual RMethod RMAddItems_Int32
		{
			get
			{
				if(r_MAddItems_Int32 == null)
				{
					r_MAddItems_Int32 = new(this, "AddItems", 0, typeof(System.Int32));
				}
				return r_MAddItems_Int32;
			}
		}

		/// <summary>
		/// Void Move(Int32, Int32)
		/// </summary>
		protected RMethod r_MMove_Int32_Int32;
		public virtual RMethod RMMove_Int32_Int32
		{
			get
			{
				if(r_MMove_Int32_Int32 == null)
				{
					r_MMove_Int32_Int32 = new(this, "Move", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MMove_Int32_Int32;
			}
		}

		/// <summary>
		/// Void RemoveItem(Int32)
		/// </summary>
		protected RMethod r_MRemoveItem_Int32;
		public virtual RMethod RMRemoveItem_Int32
		{
			get
			{
				if(r_MRemoveItem_Int32 == null)
				{
					r_MRemoveItem_Int32 = new(this, "RemoveItem", 0, typeof(System.Int32));
				}
				return r_MRemoveItem_Int32;
			}
		}

		/// <summary>
		/// Void RemoveItems(System.Collections.Generic.List`1[System.Int32])
		/// </summary>
		protected RMethod r_MRemoveItems_List_d_Int32_p_;
		public virtual RMethod RMRemoveItems_List_d_Int32_p_
		{
			get
			{
				if(r_MRemoveItems_List_d_Int32_p_ == null)
				{
					r_MRemoveItems_List_d_Int32_p_ = new(this, "RemoveItems", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.Int32)));
				}
				return r_MRemoveItems_List_d_Int32_p_;
			}
		}

		/// <summary>
		/// Void RemoveItems(Int32)
		/// </summary>
		protected RMethod r_MRemoveItems_Int32;
		public virtual RMethod RMRemoveItems_Int32
		{
			get
			{
				if(r_MRemoveItems_Int32 == null)
				{
					r_MRemoveItems_Int32 = new(this, "RemoveItems", 0, typeof(System.Int32));
				}
				return r_MRemoveItems_Int32;
			}
		}

		/// <summary>
		/// Void ClearItems()
		/// </summary>
		protected RMethod r_MClearItems;
		public virtual RMethod RMClearItems
		{
			get
			{
				if(r_MClearItems == null)
				{
					r_MClearItems = new(this, "ClearItems", 0);
				}
				return r_MClearItems;
			}
		}

		/// <summary>
		/// Void RaiseOnSizeChanged()
		/// </summary>
		protected RMethod r_MRaiseOnSizeChanged;
		public virtual RMethod RMRaiseOnSizeChanged
		{
			get
			{
				if(r_MRaiseOnSizeChanged == null)
				{
					r_MRaiseOnSizeChanged = new(this, "RaiseOnSizeChanged", 0);
				}
				return r_MRaiseOnSizeChanged;
			}
		}

		/// <summary>
		/// Void RaiseItemsAdded(System.Collections.Generic.IEnumerable`1[System.Int32])
		/// </summary>
		protected RMethod r_MRaiseItemsAdded_IEnumerable_d_Int32_p_;
		public virtual RMethod RMRaiseItemsAdded_IEnumerable_d_Int32_p_
		{
			get
			{
				if(r_MRaiseItemsAdded_IEnumerable_d_Int32_p_ == null)
				{
					r_MRaiseItemsAdded_IEnumerable_d_Int32_p_ = new(this, "RaiseItemsAdded", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(typeof(System.Int32)));
				}
				return r_MRaiseItemsAdded_IEnumerable_d_Int32_p_;
			}
		}

		/// <summary>
		/// Void RaiseItemsRemoved(System.Collections.Generic.IEnumerable`1[System.Int32])
		/// </summary>
		protected RMethod r_MRaiseItemsRemoved_IEnumerable_d_Int32_p_;
		public virtual RMethod RMRaiseItemsRemoved_IEnumerable_d_Int32_p_
		{
			get
			{
				if(r_MRaiseItemsRemoved_IEnumerable_d_Int32_p_ == null)
				{
					r_MRaiseItemsRemoved_IEnumerable_d_Int32_p_ = new(this, "RaiseItemsRemoved", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(typeof(System.Int32)));
				}
				return r_MRaiseItemsRemoved_IEnumerable_d_Int32_p_;
			}
		}

		/// <summary>
		/// System.Array AddToArray(System.Array, Int32)
		/// </summary>
		protected static RMethod r_MAddToArray_Array_Int32;
		public static RMethod RMAddToArray_Array_Int32
		{
			get
			{
				if(r_MAddToArray_Array_Int32 == null)
				{
					r_MAddToArray_Array_Int32 = new(Type, "AddToArray", 0, typeof(System.Array), typeof(System.Int32));
				}
				return r_MAddToArray_Array_Int32;
			}
		}

		/// <summary>
		/// System.Array RemoveFromArray(System.Array, System.Collections.Generic.List`1[System.Int32])
		/// </summary>
		protected static RMethod r_MRemoveFromArray_Array_List_d_Int32_p_;
		public static RMethod RMRemoveFromArray_Array_List_d_Int32_p_
		{
			get
			{
				if(r_MRemoveFromArray_Array_List_d_Int32_p_ == null)
				{
					r_MRemoveFromArray_Array_List_d_Int32_p_ = new(Type, "RemoveFromArray", 0, typeof(System.Array),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.Int32)));
				}
				return r_MRemoveFromArray_Array_List_d_Int32_p_;
			}
		}

		/// <summary>
		/// Void Swap(Int32, Int32)
		/// </summary>
		protected RMethod r_MSwap_Int32_Int32;
		public virtual RMethod RMSwap_Int32_Int32
		{
			get
			{
				if(r_MSwap_Int32_Int32 == null)
				{
					r_MSwap_Int32_Int32 = new(this, "Swap", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSwap_Int32_Int32;
			}
		}

		/// <summary>
		/// Void EnsureItemSourceCanBeResized()
		/// </summary>
		protected RMethod r_MEnsureItemSourceCanBeResized;
		public virtual RMethod RMEnsureItemSourceCanBeResized
		{
			get
			{
				if(r_MEnsureItemSourceCanBeResized == null)
				{
					r_MEnsureItemSourceCanBeResized = new(this, "EnsureItemSourceCanBeResized", 0);
				}
				return r_MEnsureItemSourceCanBeResized;
			}
		}

		/// <summary>
		/// Void SetItemsSourceWithoutNotify(System.Collections.IList)
		/// </summary>
		protected RMethod r_MSetItemsSourceWithoutNotify_IList;
		public virtual RMethod RMSetItemsSourceWithoutNotify_IList
		{
			get
			{
				if(r_MSetItemsSourceWithoutNotify_IList == null)
				{
					r_MSetItemsSourceWithoutNotify_IList = new(this, "SetItemsSourceWithoutNotify", 0, typeof(System.Collections.IList));
				}
				return r_MSetItemsSourceWithoutNotify_IList;
			}
		}

		/// <summary>
		/// Void SetView(UnityEngine.UIElements.BaseVerticalCollectionView)
		/// </summary>
		protected RMethod r_MSetView_BaseVerticalCollectionView;
		public virtual RMethod RMSetView_BaseVerticalCollectionView
		{
			get
			{
				if(r_MSetView_BaseVerticalCollectionView == null)
				{
					r_MSetView_BaseVerticalCollectionView = new(this, "SetView", 0, typeof(UnityEngine.UIElements.BaseVerticalCollectionView));
				}
				return r_MSetView_BaseVerticalCollectionView;
			}
		}

		/// <summary>
		/// Void PrepareView()
		/// </summary>
		protected RMethod r_MPrepareView;
		public virtual RMethod RMPrepareView
		{
			get
			{
				if(r_MPrepareView == null)
				{
					r_MPrepareView = new(this, "PrepareView", 0);
				}
				return r_MPrepareView;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Int32 GetItemsCount()
		/// </summary>
		protected RMethod r_MGetItemsCount;
		public virtual RMethod RMGetItemsCount
		{
			get
			{
				if(r_MGetItemsCount == null)
				{
					r_MGetItemsCount = new(this, "GetItemsCount", 0);
				}
				return r_MGetItemsCount;
			}
		}

		/// <summary>
		/// Int32 GetItemsMinCount()
		/// </summary>
		protected RMethod r_MGetItemsMinCount;
		public virtual RMethod RMGetItemsMinCount
		{
			get
			{
				if(r_MGetItemsMinCount == null)
				{
					r_MGetItemsMinCount = new(this, "GetItemsMinCount", 0);
				}
				return r_MGetItemsMinCount;
			}
		}

		/// <summary>
		/// Int32 GetIndexForId(Int32)
		/// </summary>
		protected RMethod r_MGetIndexForId_Int32;
		public virtual RMethod RMGetIndexForId_Int32
		{
			get
			{
				if(r_MGetIndexForId_Int32 == null)
				{
					r_MGetIndexForId_Int32 = new(this, "GetIndexForId", 0, typeof(System.Int32));
				}
				return r_MGetIndexForId_Int32;
			}
		}

		/// <summary>
		/// Int32 GetIdForIndex(Int32)
		/// </summary>
		protected RMethod r_MGetIdForIndex_Int32;
		public virtual RMethod RMGetIdForIndex_Int32
		{
			get
			{
				if(r_MGetIdForIndex_Int32 == null)
				{
					r_MGetIdForIndex_Int32 = new(this, "GetIdForIndex", 0, typeof(System.Int32));
				}
				return r_MGetIdForIndex_Int32;
			}
		}

		/// <summary>
		/// System.Object GetItemForIndex(Int32)
		/// </summary>
		protected RMethod r_MGetItemForIndex_Int32;
		public virtual RMethod RMGetItemForIndex_Int32
		{
			get
			{
				if(r_MGetItemForIndex_Int32 == null)
				{
					r_MGetItemForIndex_Int32 = new(this, "GetItemForIndex", 0, typeof(System.Int32));
				}
				return r_MGetItemForIndex_Int32;
			}
		}

		/// <summary>
		/// Void InvokeUnbindItem(UnityEngine.UIElements.ReusableCollectionItem, Int32)
		/// </summary>
		protected RMethod r_MInvokeUnbindItem_ReusableCollectionItem_Int32;
		public virtual RMethod RMInvokeUnbindItem_ReusableCollectionItem_Int32
		{
			get
			{
				if(r_MInvokeUnbindItem_ReusableCollectionItem_Int32 == null)
				{
					r_MInvokeUnbindItem_ReusableCollectionItem_Int32 = new(this, "InvokeUnbindItem", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ReusableCollectionItem"), typeof(System.Int32));
				}
				return r_MInvokeUnbindItem_ReusableCollectionItem_Int32;
			}
		}

		/// <summary>
		/// Void InvokeDestroyItem(UnityEngine.UIElements.ReusableCollectionItem)
		/// </summary>
		protected RMethod r_MInvokeDestroyItem_ReusableCollectionItem;
		public virtual RMethod RMInvokeDestroyItem_ReusableCollectionItem
		{
			get
			{
				if(r_MInvokeDestroyItem_ReusableCollectionItem == null)
				{
					r_MInvokeDestroyItem_ReusableCollectionItem = new(this, "InvokeDestroyItem", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ReusableCollectionItem"));
				}
				return r_MInvokeDestroyItem_ReusableCollectionItem;
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
		/// Void DestroyItem(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MDestroyItem_VisualElement;
		public virtual RMethod RMDestroyItem_VisualElement
		{
			get
			{
				if(r_MDestroyItem_VisualElement == null)
				{
					r_MDestroyItem_VisualElement = new(this, "DestroyItem", 0, typeof(UnityEngine.UIElements.VisualElement));
				}
				return r_MDestroyItem_VisualElement;
			}
		}

		/// <summary>
		/// Void RaiseItemsSourceChanged()
		/// </summary>
		protected RMethod r_MRaiseItemsSourceChanged;
		public virtual RMethod RMRaiseItemsSourceChanged
		{
			get
			{
				if(r_MRaiseItemsSourceChanged == null)
				{
					r_MRaiseItemsSourceChanged = new(this, "RaiseItemsSourceChanged", 0);
				}
				return r_MRaiseItemsSourceChanged;
			}
		}

		/// <summary>
		/// Void RaiseItemIndexChanged(Int32, Int32)
		/// </summary>
		protected RMethod r_MRaiseItemIndexChanged_Int32_Int32;
		public virtual RMethod RMRaiseItemIndexChanged_Int32_Int32
		{
			get
			{
				if(r_MRaiseItemIndexChanged_Int32_Int32 == null)
				{
					r_MRaiseItemIndexChanged_Int32_Int32 = new(this, "RaiseItemIndexChanged", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MRaiseItemIndexChanged_Int32_Int32;
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


        public virtual void InvokeMakeItem(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RReusableCollectionItem @reusableItem)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reusableItem.Value};
            var ___result = RMInvokeMakeItem_ReusableCollectionItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PostInitRegistration(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RReusableListViewItem @listItem)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@listItem.Value};
            var ___result = RMPostInitRegistration_ReusableListViewItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeBindItem(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RReusableCollectionItem @reusableItem, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reusableItem.Value, @index};
            var ___result = RMInvokeBindItem_ReusableCollectionItem_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean NeedsDragHandle(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMNeedsDragHandle_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void AddItems(System.Int32 @itemCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@itemCount};
            var ___result = RMAddItems_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Move(System.Int32 @index, System.Int32 @newIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @newIndex};
            var ___result = RMMove_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveItem(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMRemoveItem_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveItems(System.Collections.Generic.List<System.Int32> @indices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices};
            var ___result = RMRemoveItems_List_d_Int32_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveItems(System.Int32 @itemCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@itemCount};
            var ___result = RMRemoveItems_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearItems()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearItems.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RaiseOnSizeChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRaiseOnSizeChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RaiseItemsAdded(System.Collections.Generic.IEnumerable<System.Int32> @indices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices};
            var ___result = RMRaiseItemsAdded_IEnumerable_d_Int32_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RaiseItemsRemoved(System.Collections.Generic.IEnumerable<System.Int32> @indices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices};
            var ___result = RMRaiseItemsRemoved_IEnumerable_d_Int32_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Array AddToArray(System.Array @source, System.Int32 @itemCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @itemCount};
            var ___result = RMAddToArray_Array_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Array>(___result);
        }


        public static System.Array RemoveFromArray(System.Array @source, System.Collections.Generic.List<System.Int32> @indicesToRemove)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @indicesToRemove};
            var ___result = RMRemoveFromArray_Array_List_d_Int32_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Array>(___result);
        }


        public virtual void Swap(System.Int32 @lhs, System.Int32 @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMSwap_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnsureItemSourceCanBeResized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEnsureItemSourceCanBeResized.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetItemsSourceWithoutNotify(System.Collections.IList @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source};
            var ___result = RMSetItemsSourceWithoutNotify_IList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetView(UnityEngine.UIElements.BaseVerticalCollectionView @collectionView)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@collectionView};
            var ___result = RMSetView_BaseVerticalCollectionView.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PrepareView()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPrepareView.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetItemsCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetItemsCount.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetItemsMinCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetItemsMinCount.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetIndexForId(System.Int32 @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RMGetIndexForId_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetIdForIndex(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetIdForIndex_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Object GetItemForIndex(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetItemForIndex_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual void InvokeUnbindItem(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RReusableCollectionItem @reusableItem, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reusableItem.Value, @index};
            var ___result = RMInvokeUnbindItem_ReusableCollectionItem_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeDestroyItem(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RReusableCollectionItem @reusableItem)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reusableItem.Value};
            var ___result = RMInvokeDestroyItem_ReusableCollectionItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.VisualElement MakeItem()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMakeItem.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


        public virtual void BindItem(UnityEngine.UIElements.VisualElement @element, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @index};
            var ___result = RMBindItem_VisualElement_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnbindItem(UnityEngine.UIElements.VisualElement @element, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @index};
            var ___result = RMUnbindItem_VisualElement_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DestroyItem(UnityEngine.UIElements.VisualElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RMDestroyItem_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RaiseItemsSourceChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRaiseItemsSourceChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RaiseItemIndexChanged(System.Int32 @srcIndex, System.Int32 @dstIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@srcIndex, @dstIndex};
            var ___result = RMRaiseItemIndexChanged_Int32_Int32.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
