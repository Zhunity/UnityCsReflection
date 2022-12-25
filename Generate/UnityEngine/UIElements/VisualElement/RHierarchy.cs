using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{public partial class RVisualElement
{
	
	/// <summary>
	/// UnityEngine.UIElements.VisualElement+Hierarchy
	/// </summary>
    public partial class RHierarchy : RMember //
    {

		/// <summary>
		/// System.String k_InvalidHierarchyChangeMsg
		/// </summary>
		protected static RField r_k_InvalidHierarchyChangeMsg;
		public static RField Rk_InvalidHierarchyChangeMsg
		{
			get
			{
				if(r_k_InvalidHierarchyChangeMsg == null)
				{
					r_k_InvalidHierarchyChangeMsg = new( ReleactionUtils.GetType("UnityEngine.UIElements.VisualElement+Hierarchy"), "k_InvalidHierarchyChangeMsg");
					r_k_InvalidHierarchyChangeMsg.SetBelong(null);
				}
				return r_k_InvalidHierarchyChangeMsg;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_Owner
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_m_Owner;
		public virtual RUnityEngine.RUIElements.RVisualElement Rm_Owner
		{
			get
			{
				if(r_m_Owner == null)
				{
					r_m_Owner = new(this, "m_Owner");
					r_m_Owner.SetBelong(this.instance);
				}
				return r_m_Owner;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement parent
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_parent;
		public virtual RUnityEngine.RUIElements.RVisualElement Rparent
		{
			get
			{
				if(r_parent == null)
				{
					r_parent = new(this, "parent", -1);
					r_parent.SetBelong(this.instance);
				}
				return r_parent;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement] children
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualElement> r_children;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualElement> Rchildren
		{
			get
			{
				if(r_children == null)
				{
					r_children = new(this, "children", -1);
					r_children.SetBelong(this.instance);
				}
				return r_children;
			}
		}

		/// <summary>
		/// Int32 childCount
		/// </summary>
		protected RProperty r_childCount;
		public virtual RProperty RchildCount
		{
			get
			{
				if(r_childCount == null)
				{
					r_childCount = new(this, "childCount", -1);
					r_childCount.SetBelong(this.instance);
				}
				return r_childCount;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement Item [Int32]
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_Item_Int32;
		public virtual RUnityEngine.RUIElements.RVisualElement RItem_Int32
		{
			get
			{
				if(r_Item_Int32 == null)
				{
					r_Item_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_Item_Int32.SetBelong(this.instance);
				}
				return r_Item_Int32;
			}
		}

		/// <summary>
		/// Void Add(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RAdd_VisualElement;
		public virtual RMethod RAdd_VisualElement
		{
			get
			{
				if(r_RAdd_VisualElement == null)
				{
					r_RAdd_VisualElement = new(this, "Add", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RAdd_VisualElement.SetBelong(this.instance);
				}
				return r_RAdd_VisualElement;
			}
		}

		/// <summary>
		/// Void Insert(Int32, UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RInsert_Int32_VisualElement;
		public virtual RMethod RInsert_Int32_VisualElement
		{
			get
			{
				if(r_RInsert_Int32_VisualElement == null)
				{
					r_RInsert_Int32_VisualElement = new(this, "Insert", 0, typeof(System.Int32), typeof(UnityEngine.UIElements.VisualElement));
					r_RInsert_Int32_VisualElement.SetBelong(this.instance);
				}
				return r_RInsert_Int32_VisualElement;
			}
		}

		/// <summary>
		/// Void Remove(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RRemove_VisualElement;
		public virtual RMethod RRemove_VisualElement
		{
			get
			{
				if(r_RRemove_VisualElement == null)
				{
					r_RRemove_VisualElement = new(this, "Remove", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RRemove_VisualElement.SetBelong(this.instance);
				}
				return r_RRemove_VisualElement;
			}
		}

		/// <summary>
		/// Void RemoveAt(Int32)
		/// </summary>
		protected RMethod r_RRemoveAt_Int32;
		public virtual RMethod RRemoveAt_Int32
		{
			get
			{
				if(r_RRemoveAt_Int32 == null)
				{
					r_RRemoveAt_Int32 = new(this, "RemoveAt", 0, typeof(System.Int32));
					r_RRemoveAt_Int32.SetBelong(this.instance);
				}
				return r_RRemoveAt_Int32;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_RClear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_RClear == null)
				{
					r_RClear = new(this, "Clear", 0);
					r_RClear.SetBelong(this.instance);
				}
				return r_RClear;
			}
		}

		/// <summary>
		/// Void BringToFront(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RBringToFront_VisualElement;
		public virtual RMethod RBringToFront_VisualElement
		{
			get
			{
				if(r_RBringToFront_VisualElement == null)
				{
					r_RBringToFront_VisualElement = new(this, "BringToFront", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RBringToFront_VisualElement.SetBelong(this.instance);
				}
				return r_RBringToFront_VisualElement;
			}
		}

		/// <summary>
		/// Void SendToBack(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RSendToBack_VisualElement;
		public virtual RMethod RSendToBack_VisualElement
		{
			get
			{
				if(r_RSendToBack_VisualElement == null)
				{
					r_RSendToBack_VisualElement = new(this, "SendToBack", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RSendToBack_VisualElement.SetBelong(this.instance);
				}
				return r_RSendToBack_VisualElement;
			}
		}

		/// <summary>
		/// Void PlaceBehind(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RPlaceBehind_VisualElement_VisualElement;
		public virtual RMethod RPlaceBehind_VisualElement_VisualElement
		{
			get
			{
				if(r_RPlaceBehind_VisualElement_VisualElement == null)
				{
					r_RPlaceBehind_VisualElement_VisualElement = new(this, "PlaceBehind", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.UIElements.VisualElement));
					r_RPlaceBehind_VisualElement_VisualElement.SetBelong(this.instance);
				}
				return r_RPlaceBehind_VisualElement_VisualElement;
			}
		}

		/// <summary>
		/// Void PlaceInFront(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RPlaceInFront_VisualElement_VisualElement;
		public virtual RMethod RPlaceInFront_VisualElement_VisualElement
		{
			get
			{
				if(r_RPlaceInFront_VisualElement_VisualElement == null)
				{
					r_RPlaceInFront_VisualElement_VisualElement = new(this, "PlaceInFront", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.UIElements.VisualElement));
					r_RPlaceInFront_VisualElement_VisualElement.SetBelong(this.instance);
				}
				return r_RPlaceInFront_VisualElement_VisualElement;
			}
		}

		/// <summary>
		/// Void MoveChildElement(UnityEngine.UIElements.VisualElement, Int32, Int32)
		/// </summary>
		protected RMethod r_RMoveChildElement_VisualElement_Int32_Int32;
		public virtual RMethod RMoveChildElement_VisualElement_Int32_Int32
		{
			get
			{
				if(r_RMoveChildElement_VisualElement_Int32_Int32 == null)
				{
					r_RMoveChildElement_VisualElement_Int32_Int32 = new(this, "MoveChildElement", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Int32), typeof(System.Int32));
					r_RMoveChildElement_VisualElement_Int32_Int32.SetBelong(this.instance);
				}
				return r_RMoveChildElement_VisualElement_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RIndexOf_VisualElement;
		public virtual RMethod RIndexOf_VisualElement
		{
			get
			{
				if(r_RIndexOf_VisualElement == null)
				{
					r_RIndexOf_VisualElement = new(this, "IndexOf", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RIndexOf_VisualElement.SetBelong(this.instance);
				}
				return r_RIndexOf_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement ElementAt(Int32)
		/// </summary>
		protected RMethod r_RElementAt_Int32;
		public virtual RMethod RElementAt_Int32
		{
			get
			{
				if(r_RElementAt_Int32 == null)
				{
					r_RElementAt_Int32 = new(this, "ElementAt", 0, typeof(System.Int32));
					r_RElementAt_Int32.SetBelong(this.instance);
				}
				return r_RElementAt_Int32;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.VisualElement] Children()
		/// </summary>
		protected RMethod r_RChildren;
		public virtual RMethod RChildren
		{
			get
			{
				if(r_RChildren == null)
				{
					r_RChildren = new(this, "Children", 0);
					r_RChildren.SetBelong(this.instance);
				}
				return r_RChildren;
			}
		}

		/// <summary>
		/// Void SetParent(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RSetParent_VisualElement;
		public virtual RMethod RSetParent_VisualElement
		{
			get
			{
				if(r_RSetParent_VisualElement == null)
				{
					r_RSetParent_VisualElement = new(this, "SetParent", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RSetParent_VisualElement.SetBelong(this.instance);
				}
				return r_RSetParent_VisualElement;
			}
		}

		/// <summary>
		/// Void Sort(System.Comparison`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_RSort_Comparison_d_VisualElement_p_;
		public virtual RMethod RSort_Comparison_d_VisualElement_p_
		{
			get
			{
				if(r_RSort_Comparison_d_VisualElement_p_ == null)
				{
					r_RSort_Comparison_d_VisualElement_p_ = new(this, "Sort", 0, typeof(System.Comparison<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
					r_RSort_Comparison_d_VisualElement_p_.SetBelong(this.instance);
				}
				return r_RSort_Comparison_d_VisualElement_p_;
			}
		}

		/// <summary>
		/// Void PutChildAtIndex(UnityEngine.UIElements.VisualElement, Int32)
		/// </summary>
		protected RMethod r_RPutChildAtIndex_VisualElement_Int32;
		public virtual RMethod RPutChildAtIndex_VisualElement_Int32
		{
			get
			{
				if(r_RPutChildAtIndex_VisualElement_Int32 == null)
				{
					r_RPutChildAtIndex_VisualElement_Int32 = new(this, "PutChildAtIndex", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Int32));
					r_RPutChildAtIndex_VisualElement_Int32.SetBelong(this.instance);
				}
				return r_RPutChildAtIndex_VisualElement_Int32;
			}
		}

		/// <summary>
		/// Void RemoveChildAtIndex(Int32)
		/// </summary>
		protected RMethod r_RRemoveChildAtIndex_Int32;
		public virtual RMethod RRemoveChildAtIndex_Int32
		{
			get
			{
				if(r_RRemoveChildAtIndex_Int32 == null)
				{
					r_RRemoveChildAtIndex_Int32 = new(this, "RemoveChildAtIndex", 0, typeof(System.Int32));
					r_RRemoveChildAtIndex_Int32.SetBelong(this.instance);
				}
				return r_RRemoveChildAtIndex_Int32;
			}
		}

		/// <summary>
		/// Void ReleaseChildList()
		/// </summary>
		protected RMethod r_RReleaseChildList;
		public virtual RMethod RReleaseChildList
		{
			get
			{
				if(r_RReleaseChildList == null)
				{
					r_RReleaseChildList = new(this, "ReleaseChildList", 0);
					r_RReleaseChildList.SetBelong(this.instance);
				}
				return r_RReleaseChildList;
			}
		}

		/// <summary>
		/// Boolean Equals(Hierarchy)
		/// </summary>
		protected RMethod r_REquals_Hierarchy;
		public virtual RMethod REquals_Hierarchy
		{
			get
			{
				if(r_REquals_Hierarchy == null)
				{
					r_REquals_Hierarchy = new(this, "Equals", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.VisualElement+Hierarchy"));
					r_REquals_Hierarchy.SetBelong(this.instance);
				}
				return r_REquals_Hierarchy;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// Boolean op_Equality(Hierarchy, Hierarchy)
		/// </summary>
		protected static RMethod r_Rop_Equality_Hierarchy_Hierarchy;
		public static RMethod Rop_Equality_Hierarchy_Hierarchy
		{
			get
			{
				if(r_Rop_Equality_Hierarchy_Hierarchy == null)
				{
					r_Rop_Equality_Hierarchy_Hierarchy = new( ReleactionUtils.GetType("UnityEngine.UIElements.VisualElement+Hierarchy"), "op_Equality", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.VisualElement+Hierarchy"),  ReleactionUtils.GetType("UnityEngine.UIElements.VisualElement+Hierarchy"));
					r_Rop_Equality_Hierarchy_Hierarchy.SetBelong(null);
				}
				return r_Rop_Equality_Hierarchy_Hierarchy;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(Hierarchy, Hierarchy)
		/// </summary>
		protected static RMethod r_Rop_Inequality_Hierarchy_Hierarchy;
		public static RMethod Rop_Inequality_Hierarchy_Hierarchy
		{
			get
			{
				if(r_Rop_Inequality_Hierarchy_Hierarchy == null)
				{
					r_Rop_Inequality_Hierarchy_Hierarchy = new( ReleactionUtils.GetType("UnityEngine.UIElements.VisualElement+Hierarchy"), "op_Inequality", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.VisualElement+Hierarchy"),  ReleactionUtils.GetType("UnityEngine.UIElements.VisualElement+Hierarchy"));
					r_Rop_Inequality_Hierarchy_Hierarchy.SetBelong(null);
				}
				return r_Rop_Inequality_Hierarchy_Hierarchy;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}


        public RHierarchy() : base("UnityEngine.UIElements.VisualElement+Hierarchy")
        {
        }

        public RHierarchy(System.Object instance) : base("UnityEngine.UIElements.VisualElement+Hierarchy")
		{
            SetInstance(instance);
		}

        public RHierarchy(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RHierarchy(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Add(UnityEngine.UIElements.VisualElement  @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RAdd_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Insert(System.Int32  @index, UnityEngine.UIElements.VisualElement  @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @child};
            var ___result = RInsert_Int32_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Remove(UnityEngine.UIElements.VisualElement  @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RRemove_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAt(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RRemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BringToFront(UnityEngine.UIElements.VisualElement  @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RBringToFront_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendToBack(UnityEngine.UIElements.VisualElement  @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RSendToBack_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlaceBehind(UnityEngine.UIElements.VisualElement  @child, UnityEngine.UIElements.VisualElement  @over)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child, @over};
            var ___result = RPlaceBehind_VisualElement_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlaceInFront(UnityEngine.UIElements.VisualElement  @child, UnityEngine.UIElements.VisualElement  @under)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child, @under};
            var ___result = RPlaceInFront_VisualElement_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveChildElement(UnityEngine.UIElements.VisualElement  @child, System.Int32  @currentIndex, System.Int32  @nextIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child, @currentIndex, @nextIndex};
            var ___result = RMoveChildElement_VisualElement_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 IndexOf(UnityEngine.UIElements.VisualElement  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RIndexOf_VisualElement.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement ElementAt(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RElementAt_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement> Children()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RChildren.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement>)___result;
        }


        public virtual void SetParent(UnityEngine.UIElements.VisualElement  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetParent_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Sort(System.Comparison<UnityEngine.UIElements.VisualElement>  @comp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comp};
            var ___result = RSort_Comparison_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PutChildAtIndex(UnityEngine.UIElements.VisualElement  @child, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child, @index};
            var ___result = RPutChildAtIndex_VisualElement_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveChildAtIndex(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RRemoveChildAtIndex_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReleaseChildList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReleaseChildList.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }




        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
}