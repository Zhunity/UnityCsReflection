
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
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
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_InvalidHierarchyChangeMsg;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_InvalidHierarchyChangeMsg
		{
			get
			{
				if(r_Fk_InvalidHierarchyChangeMsg == null)
				{
					r_Fk_InvalidHierarchyChangeMsg = new( ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+Hierarchy"), "k_InvalidHierarchyChangeMsg");
					r_Fk_InvalidHierarchyChangeMsg.SetBelong(null);
				}
				return r_Fk_InvalidHierarchyChangeMsg;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_Owner
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_Owner;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_Owner
		{
			get
			{
				if(r_Fm_Owner == null)
				{
					r_Fm_Owner = new(this, "m_Owner");
					r_Fm_Owner.SetBelong(this.GetValue());
				}
				return r_Fm_Owner;
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
					r_Pparent.SetBelong(this.GetValue());
				}
				return r_Pparent;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement] children
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> r_Pchildren;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> RPchildren
		{
			get
			{
				if(r_Pchildren == null)
				{
					r_Pchildren = new(this, "children", -1);
					r_Pchildren.SetBelong(this.GetValue());
				}
				return r_Pchildren;
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
					r_PchildCount.SetBelong(this.GetValue());
				}
				return r_PchildCount;
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
					r_PItem_Int32.SetBelong(this.GetValue());
				}
				return r_PItem_Int32;
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
					r_MAdd_VisualElement.SetBelong(this.GetValue());
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
					r_MInsert_Int32_VisualElement.SetBelong(this.GetValue());
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
					r_MRemove_VisualElement.SetBelong(this.GetValue());
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
					r_MRemoveAt_Int32.SetBelong(this.GetValue());
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
					r_MClear.SetBelong(this.GetValue());
				}
				return r_MClear;
			}
		}

		/// <summary>
		/// Void BringToFront(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MBringToFront_VisualElement;
		public virtual RMethod RMBringToFront_VisualElement
		{
			get
			{
				if(r_MBringToFront_VisualElement == null)
				{
					r_MBringToFront_VisualElement = new(this, "BringToFront", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MBringToFront_VisualElement.SetBelong(this.GetValue());
				}
				return r_MBringToFront_VisualElement;
			}
		}

		/// <summary>
		/// Void SendToBack(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MSendToBack_VisualElement;
		public virtual RMethod RMSendToBack_VisualElement
		{
			get
			{
				if(r_MSendToBack_VisualElement == null)
				{
					r_MSendToBack_VisualElement = new(this, "SendToBack", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MSendToBack_VisualElement.SetBelong(this.GetValue());
				}
				return r_MSendToBack_VisualElement;
			}
		}

		/// <summary>
		/// Void PlaceBehind(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MPlaceBehind_VisualElement_VisualElement;
		public virtual RMethod RMPlaceBehind_VisualElement_VisualElement
		{
			get
			{
				if(r_MPlaceBehind_VisualElement_VisualElement == null)
				{
					r_MPlaceBehind_VisualElement_VisualElement = new(this, "PlaceBehind", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.UIElements.VisualElement));
					r_MPlaceBehind_VisualElement_VisualElement.SetBelong(this.GetValue());
				}
				return r_MPlaceBehind_VisualElement_VisualElement;
			}
		}

		/// <summary>
		/// Void PlaceInFront(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MPlaceInFront_VisualElement_VisualElement;
		public virtual RMethod RMPlaceInFront_VisualElement_VisualElement
		{
			get
			{
				if(r_MPlaceInFront_VisualElement_VisualElement == null)
				{
					r_MPlaceInFront_VisualElement_VisualElement = new(this, "PlaceInFront", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.UIElements.VisualElement));
					r_MPlaceInFront_VisualElement_VisualElement.SetBelong(this.GetValue());
				}
				return r_MPlaceInFront_VisualElement_VisualElement;
			}
		}

		/// <summary>
		/// Void MoveChildElement(UnityEngine.UIElements.VisualElement, Int32, Int32)
		/// </summary>
		protected RMethod r_MMoveChildElement_VisualElement_Int32_Int32;
		public virtual RMethod RMMoveChildElement_VisualElement_Int32_Int32
		{
			get
			{
				if(r_MMoveChildElement_VisualElement_Int32_Int32 == null)
				{
					r_MMoveChildElement_VisualElement_Int32_Int32 = new(this, "MoveChildElement", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Int32), typeof(System.Int32));
					r_MMoveChildElement_VisualElement_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MMoveChildElement_VisualElement_Int32_Int32;
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
					r_MIndexOf_VisualElement.SetBelong(this.GetValue());
				}
				return r_MIndexOf_VisualElement;
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
					r_MElementAt_Int32.SetBelong(this.GetValue());
				}
				return r_MElementAt_Int32;
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
					r_MChildren.SetBelong(this.GetValue());
				}
				return r_MChildren;
			}
		}

		/// <summary>
		/// Void SetParent(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MSetParent_VisualElement;
		public virtual RMethod RMSetParent_VisualElement
		{
			get
			{
				if(r_MSetParent_VisualElement == null)
				{
					r_MSetParent_VisualElement = new(this, "SetParent", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MSetParent_VisualElement.SetBelong(this.GetValue());
				}
				return r_MSetParent_VisualElement;
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
					r_MSort_Comparison_d_VisualElement_p_ = new(this, "Sort", 0, typeof(System.Comparison<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
					r_MSort_Comparison_d_VisualElement_p_.SetBelong(this.GetValue());
				}
				return r_MSort_Comparison_d_VisualElement_p_;
			}
		}

		/// <summary>
		/// Void PutChildAtIndex(UnityEngine.UIElements.VisualElement, Int32)
		/// </summary>
		protected RMethod r_MPutChildAtIndex_VisualElement_Int32;
		public virtual RMethod RMPutChildAtIndex_VisualElement_Int32
		{
			get
			{
				if(r_MPutChildAtIndex_VisualElement_Int32 == null)
				{
					r_MPutChildAtIndex_VisualElement_Int32 = new(this, "PutChildAtIndex", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Int32));
					r_MPutChildAtIndex_VisualElement_Int32.SetBelong(this.GetValue());
				}
				return r_MPutChildAtIndex_VisualElement_Int32;
			}
		}

		/// <summary>
		/// Void RemoveChildAtIndex(Int32)
		/// </summary>
		protected RMethod r_MRemoveChildAtIndex_Int32;
		public virtual RMethod RMRemoveChildAtIndex_Int32
		{
			get
			{
				if(r_MRemoveChildAtIndex_Int32 == null)
				{
					r_MRemoveChildAtIndex_Int32 = new(this, "RemoveChildAtIndex", 0, typeof(System.Int32));
					r_MRemoveChildAtIndex_Int32.SetBelong(this.GetValue());
				}
				return r_MRemoveChildAtIndex_Int32;
			}
		}

		/// <summary>
		/// Void ReleaseChildList()
		/// </summary>
		protected RMethod r_MReleaseChildList;
		public virtual RMethod RMReleaseChildList
		{
			get
			{
				if(r_MReleaseChildList == null)
				{
					r_MReleaseChildList = new(this, "ReleaseChildList", 0);
					r_MReleaseChildList.SetBelong(this.GetValue());
				}
				return r_MReleaseChildList;
			}
		}

		/// <summary>
		/// Boolean Equals(Hierarchy)
		/// </summary>
		protected RMethod r_MEquals_Hierarchy;
		public virtual RMethod RMEquals_Hierarchy
		{
			get
			{
				if(r_MEquals_Hierarchy == null)
				{
					r_MEquals_Hierarchy = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+Hierarchy"));
					r_MEquals_Hierarchy.SetBelong(this.GetValue());
				}
				return r_MEquals_Hierarchy;
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
					r_MEquals_Object.SetBelong(this.GetValue());
				}
				return r_MEquals_Object;
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
					r_MGetHashCode.SetBelong(this.GetValue());
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// Boolean op_Equality(Hierarchy, Hierarchy)
		/// </summary>
		protected static RMethod r_Mop_Equality_Hierarchy_Hierarchy;
		public static RMethod RMop_Equality_Hierarchy_Hierarchy
		{
			get
			{
				if(r_Mop_Equality_Hierarchy_Hierarchy == null)
				{
					r_Mop_Equality_Hierarchy_Hierarchy = new( ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+Hierarchy"), "op_Equality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+Hierarchy"),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+Hierarchy"));
					r_Mop_Equality_Hierarchy_Hierarchy.SetBelong(null);
				}
				return r_Mop_Equality_Hierarchy_Hierarchy;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(Hierarchy, Hierarchy)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Hierarchy_Hierarchy;
		public static RMethod RMop_Inequality_Hierarchy_Hierarchy
		{
			get
			{
				if(r_Mop_Inequality_Hierarchy_Hierarchy == null)
				{
					r_Mop_Inequality_Hierarchy_Hierarchy = new( ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+Hierarchy"), "op_Inequality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+Hierarchy"),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+Hierarchy"));
					r_Mop_Inequality_Hierarchy_Hierarchy.SetBelong(null);
				}
				return r_Mop_Inequality_Hierarchy_Hierarchy;
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
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
					r_MFinalize.SetBelong(this.GetValue());
				}
				return r_MFinalize;
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
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

        public virtual void Add(UnityEngine.UIElements.VisualElement @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RMAdd_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Insert(System.Int32 @index, UnityEngine.UIElements.VisualElement @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @child};
            var ___result = RMInsert_Int32_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Remove(UnityEngine.UIElements.VisualElement @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
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


        public virtual void BringToFront(UnityEngine.UIElements.VisualElement @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RMBringToFront_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendToBack(UnityEngine.UIElements.VisualElement @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RMSendToBack_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlaceBehind(UnityEngine.UIElements.VisualElement @child, UnityEngine.UIElements.VisualElement @over)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child, @over};
            var ___result = RMPlaceBehind_VisualElement_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlaceInFront(UnityEngine.UIElements.VisualElement @child, UnityEngine.UIElements.VisualElement @under)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child, @under};
            var ___result = RMPlaceInFront_VisualElement_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveChildElement(UnityEngine.UIElements.VisualElement @child, System.Int32 @currentIndex, System.Int32 @nextIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child, @currentIndex, @nextIndex};
            var ___result = RMMoveChildElement_VisualElement_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 IndexOf(UnityEngine.UIElements.VisualElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RMIndexOf_VisualElement.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement ElementAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMElementAt_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement> Children()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMChildren.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement>)___result;
        }


        public virtual void SetParent(UnityEngine.UIElements.VisualElement @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetParent_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Sort(System.Comparison<UnityEngine.UIElements.VisualElement> @comp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comp};
            var ___result = RMSort_Comparison_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PutChildAtIndex(UnityEngine.UIElements.VisualElement @child, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child, @index};
            var ___result = RMPutChildAtIndex_VisualElement_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveChildAtIndex(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMRemoveChildAtIndex_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReleaseChildList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReleaseChildList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RHierarchy @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_Hierarchy.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RHierarchy @x, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RHierarchy @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x.Value, @y.Value};
            var ___result = RMop_Equality_Hierarchy_Hierarchy.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RHierarchy @x, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RHierarchy @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x.Value, @y.Value};
            var ___result = RMop_Inequality_Hierarchy_Hierarchy.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
}