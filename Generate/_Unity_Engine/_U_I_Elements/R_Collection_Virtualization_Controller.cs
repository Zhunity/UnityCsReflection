
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.CollectionVirtualizationController
	/// </summary>
    public partial class RCollectionVirtualizationController : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.CollectionVirtualizationController");
            }
        }

        public RCollectionVirtualizationController() : base("UnityEngine.UIElements.CollectionVirtualizationController")
        {
        }

        public RCollectionVirtualizationController(System.Object instance) : base("UnityEngine.UIElements.CollectionVirtualizationController")
		{
            SetInstance(instance);
		}

        public RCollectionVirtualizationController(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCollectionVirtualizationController(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.UIElements.ScrollView m_ScrollView
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScrollView r_Fm_ScrollView;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScrollView RFm_ScrollView
		{
			get
			{
				if(r_Fm_ScrollView == null)
				{
					r_Fm_ScrollView = new(this, "m_ScrollView");
				}
				return r_Fm_ScrollView;
			}
		}

		/// <summary>
		/// Int32 firstVisibleIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PfirstVisibleIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPfirstVisibleIndex
		{
			get
			{
				if(r_PfirstVisibleIndex == null)
				{
					r_PfirstVisibleIndex = new(this, "firstVisibleIndex", -1);
				}
				return r_PfirstVisibleIndex;
			}
		}

		/// <summary>
		/// Int32 visibleItemCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PvisibleItemCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPvisibleItemCount
		{
			get
			{
				if(r_PvisibleItemCount == null)
				{
					r_PvisibleItemCount = new(this, "visibleItemCount", -1);
				}
				return r_PvisibleItemCount;
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
		/// Void Refresh(Boolean)
		/// </summary>
		protected RMethod r_MRefresh_Boolean;
		public virtual RMethod RMRefresh_Boolean
		{
			get
			{
				if(r_MRefresh_Boolean == null)
				{
					r_MRefresh_Boolean = new(this, "Refresh", 0, typeof(System.Boolean));
				}
				return r_MRefresh_Boolean;
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
		/// Void Resize(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MResize_Vector2;
		public virtual RMethod RMResize_Vector2
		{
			get
			{
				if(r_MResize_Vector2 == null)
				{
					r_MResize_Vector2 = new(this, "Resize", 0, typeof(UnityEngine.Vector2));
				}
				return r_MResize_Vector2;
			}
		}

		/// <summary>
		/// Void OnScroll(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MOnScroll_Vector2;
		public virtual RMethod RMOnScroll_Vector2
		{
			get
			{
				if(r_MOnScroll_Vector2 == null)
				{
					r_MOnScroll_Vector2 = new(this, "OnScroll", 0, typeof(UnityEngine.Vector2));
				}
				return r_MOnScroll_Vector2;
			}
		}

		/// <summary>
		/// Int32 GetIndexFromPosition(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MGetIndexFromPosition_Vector2;
		public virtual RMethod RMGetIndexFromPosition_Vector2
		{
			get
			{
				if(r_MGetIndexFromPosition_Vector2 == null)
				{
					r_MGetIndexFromPosition_Vector2 = new(this, "GetIndexFromPosition", 0, typeof(UnityEngine.Vector2));
				}
				return r_MGetIndexFromPosition_Vector2;
			}
		}

		/// <summary>
		/// Single GetExpectedItemHeight(Int32)
		/// </summary>
		protected RMethod r_MGetExpectedItemHeight_Int32;
		public virtual RMethod RMGetExpectedItemHeight_Int32
		{
			get
			{
				if(r_MGetExpectedItemHeight_Int32 == null)
				{
					r_MGetExpectedItemHeight_Int32 = new(this, "GetExpectedItemHeight", 0, typeof(System.Int32));
				}
				return r_MGetExpectedItemHeight_Int32;
			}
		}

		/// <summary>
		/// Single GetExpectedContentHeight()
		/// </summary>
		protected RMethod r_MGetExpectedContentHeight;
		public virtual RMethod RMGetExpectedContentHeight
		{
			get
			{
				if(r_MGetExpectedContentHeight == null)
				{
					r_MGetExpectedContentHeight = new(this, "GetExpectedContentHeight", 0);
				}
				return r_MGetExpectedContentHeight;
			}
		}

		/// <summary>
		/// Void OnFocus(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MOnFocus_VisualElement;
		public virtual RMethod RMOnFocus_VisualElement
		{
			get
			{
				if(r_MOnFocus_VisualElement == null)
				{
					r_MOnFocus_VisualElement = new(this, "OnFocus", 0, typeof(UnityEngine.UIElements.VisualElement));
				}
				return r_MOnFocus_VisualElement;
			}
		}

		/// <summary>
		/// Void OnBlur(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MOnBlur_VisualElement;
		public virtual RMethod RMOnBlur_VisualElement
		{
			get
			{
				if(r_MOnBlur_VisualElement == null)
				{
					r_MOnBlur_VisualElement = new(this, "OnBlur", 0, typeof(UnityEngine.UIElements.VisualElement));
				}
				return r_MOnBlur_VisualElement;
			}
		}

		/// <summary>
		/// Void UpdateBackground()
		/// </summary>
		protected RMethod r_MUpdateBackground;
		public virtual RMethod RMUpdateBackground
		{
			get
			{
				if(r_MUpdateBackground == null)
				{
					r_MUpdateBackground = new(this, "UpdateBackground", 0);
				}
				return r_MUpdateBackground;
			}
		}

		/// <summary>
		/// Void StartDragItem(UnityEngine.UIElements.ReusableCollectionItem)
		/// </summary>
		protected RMethod r_MStartDragItem_ReusableCollectionItem;
		public virtual RMethod RMStartDragItem_ReusableCollectionItem
		{
			get
			{
				if(r_MStartDragItem_ReusableCollectionItem == null)
				{
					r_MStartDragItem_ReusableCollectionItem = new(this, "StartDragItem", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ReusableCollectionItem"));
				}
				return r_MStartDragItem_ReusableCollectionItem;
			}
		}

		/// <summary>
		/// Void EndDrag(Int32)
		/// </summary>
		protected RMethod r_MEndDrag_Int32;
		public virtual RMethod RMEndDrag_Int32
		{
			get
			{
				if(r_MEndDrag_Int32 == null)
				{
					r_MEndDrag_Int32 = new(this, "EndDrag", 0, typeof(System.Int32));
				}
				return r_MEndDrag_Int32;
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


        public virtual void Refresh(System.Boolean @rebuild)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rebuild};
            var ___result = RMRefresh_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ScrollToItem(System.Int32 @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RMScrollToItem_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Resize(UnityEngine.Vector2 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@size};
            var ___result = RMResize_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnScroll(UnityEngine.Vector2 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offset};
            var ___result = RMOnScroll_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetIndexFromPosition(UnityEngine.Vector2 @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RMGetIndexFromPosition_Vector2.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Single GetExpectedItemHeight(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetExpectedItemHeight_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual System.Single GetExpectedContentHeight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetExpectedContentHeight.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual void OnFocus(UnityEngine.UIElements.VisualElement @leafTarget)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@leafTarget};
            var ___result = RMOnFocus_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBlur(UnityEngine.UIElements.VisualElement @willFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@willFocus};
            var ___result = RMOnBlur_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateBackground()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateBackground.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StartDragItem(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RReusableCollectionItem @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item.Value};
            var ___result = RMStartDragItem_ReusableCollectionItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndDrag(System.Int32 @dropIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dropIndex};
            var ___result = RMEndDrag_Int32.Invoke(___genericsType, ___parameters);

            
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
