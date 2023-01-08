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
					r_k_InvalidHierarchyChangeMsg = new( ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+Hierarchy"), "k_InvalidHierarchyChangeMsg");
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
		protected RMethod r_Add_VisualElement;
		public virtual RMethod RAdd_VisualElement
		{
			get
			{
				if(r_Add_VisualElement == null)
				{
					r_Add_VisualElement = new(this, "Add", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_Add_VisualElement.SetBelong(this.instance);
				}
				return r_Add_VisualElement;
			}
		}

		/// <summary>
		/// Void Insert(Int32, UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_Insert_Int32_VisualElement;
		public virtual RMethod RInsert_Int32_VisualElement
		{
			get
			{
				if(r_Insert_Int32_VisualElement == null)
				{
					r_Insert_Int32_VisualElement = new(this, "Insert", 0, typeof(System.Int32), typeof(UnityEngine.UIElements.VisualElement));
					r_Insert_Int32_VisualElement.SetBelong(this.instance);
				}
				return r_Insert_Int32_VisualElement;
			}
		}

		/// <summary>
		/// Void Remove(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_Remove_VisualElement;
		public virtual RMethod RRemove_VisualElement
		{
			get
			{
				if(r_Remove_VisualElement == null)
				{
					r_Remove_VisualElement = new(this, "Remove", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_Remove_VisualElement.SetBelong(this.instance);
				}
				return r_Remove_VisualElement;
			}
		}

		/// <summary>
		/// Void RemoveAt(Int32)
		/// </summary>
		protected RMethod r_RemoveAt_Int32;
		public virtual RMethod RRemoveAt_Int32
		{
			get
			{
				if(r_RemoveAt_Int32 == null)
				{
					r_RemoveAt_Int32 = new(this, "RemoveAt", 0, typeof(System.Int32));
					r_RemoveAt_Int32.SetBelong(this.instance);
				}
				return r_RemoveAt_Int32;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_Clear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_Clear == null)
				{
					r_Clear = new(this, "Clear", 0);
					r_Clear.SetBelong(this.instance);
				}
				return r_Clear;
			}
		}

		/// <summary>
		/// Void BringToFront(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_BringToFront_VisualElement;
		public virtual RMethod RBringToFront_VisualElement
		{
			get
			{
				if(r_BringToFront_VisualElement == null)
				{
					r_BringToFront_VisualElement = new(this, "BringToFront", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_BringToFront_VisualElement.SetBelong(this.instance);
				}
				return r_BringToFront_VisualElement;
			}
		}

		/// <summary>
		/// Void SendToBack(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_SendToBack_VisualElement;
		public virtual RMethod RSendToBack_VisualElement
		{
			get
			{
				if(r_SendToBack_VisualElement == null)
				{
					r_SendToBack_VisualElement = new(this, "SendToBack", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_SendToBack_VisualElement.SetBelong(this.instance);
				}
				return r_SendToBack_VisualElement;
			}
		}

		/// <summary>
		/// Void PlaceBehind(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_PlaceBehind_VisualElement_VisualElement;
		public virtual RMethod RPlaceBehind_VisualElement_VisualElement
		{
			get
			{
				if(r_PlaceBehind_VisualElement_VisualElement == null)
				{
					r_PlaceBehind_VisualElement_VisualElement = new(this, "PlaceBehind", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.UIElements.VisualElement));
					r_PlaceBehind_VisualElement_VisualElement.SetBelong(this.instance);
				}
				return r_PlaceBehind_VisualElement_VisualElement;
			}
		}

		/// <summary>
		/// Void PlaceInFront(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_PlaceInFront_VisualElement_VisualElement;
		public virtual RMethod RPlaceInFront_VisualElement_VisualElement
		{
			get
			{
				if(r_PlaceInFront_VisualElement_VisualElement == null)
				{
					r_PlaceInFront_VisualElement_VisualElement = new(this, "PlaceInFront", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.UIElements.VisualElement));
					r_PlaceInFront_VisualElement_VisualElement.SetBelong(this.instance);
				}
				return r_PlaceInFront_VisualElement_VisualElement;
			}
		}

		/// <summary>
		/// Void MoveChildElement(UnityEngine.UIElements.VisualElement, Int32, Int32)
		/// </summary>
		protected RMethod r_MoveChildElement_VisualElement_Int32_Int32;
		public virtual RMethod RMoveChildElement_VisualElement_Int32_Int32
		{
			get
			{
				if(r_MoveChildElement_VisualElement_Int32_Int32 == null)
				{
					r_MoveChildElement_VisualElement_Int32_Int32 = new(this, "MoveChildElement", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Int32), typeof(System.Int32));
					r_MoveChildElement_VisualElement_Int32_Int32.SetBelong(this.instance);
				}
				return r_MoveChildElement_VisualElement_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_IndexOf_VisualElement;
		public virtual RMethod RIndexOf_VisualElement
		{
			get
			{
				if(r_IndexOf_VisualElement == null)
				{
					r_IndexOf_VisualElement = new(this, "IndexOf", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_IndexOf_VisualElement.SetBelong(this.instance);
				}
				return r_IndexOf_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement ElementAt(Int32)
		/// </summary>
		protected RMethod r_ElementAt_Int32;
		public virtual RMethod RElementAt_Int32
		{
			get
			{
				if(r_ElementAt_Int32 == null)
				{
					r_ElementAt_Int32 = new(this, "ElementAt", 0, typeof(System.Int32));
					r_ElementAt_Int32.SetBelong(this.instance);
				}
				return r_ElementAt_Int32;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.VisualElement] Children()
		/// </summary>
		protected RMethod r_Children;
		public virtual RMethod RChildren
		{
			get
			{
				if(r_Children == null)
				{
					r_Children = new(this, "Children", 0);
					r_Children.SetBelong(this.instance);
				}
				return r_Children;
			}
		}

		/// <summary>
		/// Void SetParent(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_SetParent_VisualElement;
		public virtual RMethod RSetParent_VisualElement
		{
			get
			{
				if(r_SetParent_VisualElement == null)
				{
					r_SetParent_VisualElement = new(this, "SetParent", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_SetParent_VisualElement.SetBelong(this.instance);
				}
				return r_SetParent_VisualElement;
			}
		}

		/// <summary>
		/// Void Sort(System.Comparison`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_Sort_Comparison_d_VisualElement_p_;
		public virtual RMethod RSort_Comparison_d_VisualElement_p_
		{
			get
			{
				if(r_Sort_Comparison_d_VisualElement_p_ == null)
				{
					r_Sort_Comparison_d_VisualElement_p_ = new(this, "Sort", 0, typeof(System.Comparison<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
					r_Sort_Comparison_d_VisualElement_p_.SetBelong(this.instance);
				}
				return r_Sort_Comparison_d_VisualElement_p_;
			}
		}

		/// <summary>
		/// Void PutChildAtIndex(UnityEngine.UIElements.VisualElement, Int32)
		/// </summary>
		protected RMethod r_PutChildAtIndex_VisualElement_Int32;
		public virtual RMethod RPutChildAtIndex_VisualElement_Int32
		{
			get
			{
				if(r_PutChildAtIndex_VisualElement_Int32 == null)
				{
					r_PutChildAtIndex_VisualElement_Int32 = new(this, "PutChildAtIndex", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Int32));
					r_PutChildAtIndex_VisualElement_Int32.SetBelong(this.instance);
				}
				return r_PutChildAtIndex_VisualElement_Int32;
			}
		}

		/// <summary>
		/// Void RemoveChildAtIndex(Int32)
		/// </summary>
		protected RMethod r_RemoveChildAtIndex_Int32;
		public virtual RMethod RRemoveChildAtIndex_Int32
		{
			get
			{
				if(r_RemoveChildAtIndex_Int32 == null)
				{
					r_RemoveChildAtIndex_Int32 = new(this, "RemoveChildAtIndex", 0, typeof(System.Int32));
					r_RemoveChildAtIndex_Int32.SetBelong(this.instance);
				}
				return r_RemoveChildAtIndex_Int32;
			}
		}

		/// <summary>
		/// Void ReleaseChildList()
		/// </summary>
		protected RMethod r_ReleaseChildList;
		public virtual RMethod RReleaseChildList
		{
			get
			{
				if(r_ReleaseChildList == null)
				{
					r_ReleaseChildList = new(this, "ReleaseChildList", 0);
					r_ReleaseChildList.SetBelong(this.instance);
				}
				return r_ReleaseChildList;
			}
		}

		/// <summary>
		/// Boolean Equals(Hierarchy)
		/// </summary>
		protected RMethod r_Equals_Hierarchy;
		public virtual RMethod REquals_Hierarchy
		{
			get
			{
				if(r_Equals_Hierarchy == null)
				{
					r_Equals_Hierarchy = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+Hierarchy"));
					r_Equals_Hierarchy.SetBelong(this.instance);
				}
				return r_Equals_Hierarchy;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// Boolean op_Equality(Hierarchy, Hierarchy)
		/// </summary>
		protected static RMethod r_op_Equality_Hierarchy_Hierarchy;
		public static RMethod Rop_Equality_Hierarchy_Hierarchy
		{
			get
			{
				if(r_op_Equality_Hierarchy_Hierarchy == null)
				{
					r_op_Equality_Hierarchy_Hierarchy = new( ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+Hierarchy"), "op_Equality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+Hierarchy"),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+Hierarchy"));
					r_op_Equality_Hierarchy_Hierarchy.SetBelong(null);
				}
				return r_op_Equality_Hierarchy_Hierarchy;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(Hierarchy, Hierarchy)
		/// </summary>
		protected static RMethod r_op_Inequality_Hierarchy_Hierarchy;
		public static RMethod Rop_Inequality_Hierarchy_Hierarchy
		{
			get
			{
				if(r_op_Inequality_Hierarchy_Hierarchy == null)
				{
					r_op_Inequality_Hierarchy_Hierarchy = new( ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+Hierarchy"), "op_Inequality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+Hierarchy"),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+Hierarchy"));
					r_op_Inequality_Hierarchy_Hierarchy.SetBelong(null);
				}
				return r_op_Inequality_Hierarchy_Hierarchy;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
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


        public virtual System.Boolean Equals(RUnityEngine.RUIElements.RVisualElement.RHierarchy  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = REquals_Hierarchy.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public static System.Boolean op_Equality(RUnityEngine.RUIElements.RVisualElement.RHierarchy  @x, RUnityEngine.RUIElements.RVisualElement.RHierarchy  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x.Value, @y.Value};
            var ___result = Rop_Equality_Hierarchy_Hierarchy.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(RUnityEngine.RUIElements.RVisualElement.RHierarchy  @x, RUnityEngine.RUIElements.RVisualElement.RHierarchy  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x.Value, @y.Value};
            var ___result = Rop_Inequality_Hierarchy_Hierarchy.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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