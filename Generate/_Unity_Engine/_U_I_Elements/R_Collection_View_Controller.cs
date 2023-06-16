
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.UIElements.CollectionViewController
	/// </summary>
    public partial class RCollectionViewController : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.CollectionViewController);
            }
        }

        public RCollectionViewController() : base("UnityEngine.UIElements.CollectionViewController")
        {
        }

        public RCollectionViewController(System.Object instance) : base("UnityEngine.UIElements.CollectionViewController")
		{
            SetInstance(instance);
		}

        public RCollectionViewController(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCollectionViewController(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
		/// UnityEngine.UIElements.BaseVerticalCollectionView m_View
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVerticalCollectionView r_Fm_View;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVerticalCollectionView RFm_View
		{
			get
			{
				if(r_Fm_View == null)
				{
					r_Fm_View = new(this, "m_View");
				}
				return r_Fm_View;
			}
		}

		/// <summary>
		/// System.Collections.IList m_ItemsSource
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RIList r_Fm_ItemsSource;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RIList RFm_ItemsSource
		{
			get
			{
				if(r_Fm_ItemsSource == null)
				{
					r_Fm_ItemsSource = new(this, "m_ItemsSource");
				}
				return r_Fm_ItemsSource;
			}
		}

		/// <summary>
		/// System.Action itemsSourceChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_FitemsSourceChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFitemsSourceChanged
		{
			get
			{
				if(r_FitemsSourceChanged == null)
				{
					r_FitemsSourceChanged = new(this, "itemsSourceChanged");
				}
				return r_FitemsSourceChanged;
			}
		}

		/// <summary>
		/// System.Action`2[System.Int32,System.Int32] itemIndexChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RSystem.RInt32> r_FitemIndexChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RSystem.RInt32> RFitemIndexChanged
		{
			get
			{
				if(r_FitemIndexChanged == null)
				{
					r_FitemIndexChanged = new(this, "itemIndexChanged");
				}
				return r_FitemIndexChanged;
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


        public virtual void InvokeMakeItem(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RReusableCollectionItem @reusableItem)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reusableItem.Value};
            var ___result = RMInvokeMakeItem_ReusableCollectionItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeBindItem(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RReusableCollectionItem @reusableItem, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reusableItem.Value, @index};
            var ___result = RMInvokeBindItem_ReusableCollectionItem_Int32.Invoke(___genericsType, ___parameters);

            
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
