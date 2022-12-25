using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
	/// System.Text.RegularExpressions.GroupCollection
	/// </summary>
    public partial class RGroupCollection : RMember //
    {

		/// <summary>
		/// System.Text.RegularExpressions.Match _match
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RMatch r__match;
		public virtual RSystem.RText.RRegularExpressions.RMatch R_match
		{
			get
			{
				if(r__match == null)
				{
					r__match = new(this, "_match");
					r__match.SetBelong(this.instance);
				}
				return r__match;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable _captureMap
		/// </summary>
		protected RSystem.RCollections.RHashtable r__captureMap;
		public virtual RSystem.RCollections.RHashtable R_captureMap
		{
			get
			{
				if(r__captureMap == null)
				{
					r__captureMap = new(this, "_captureMap");
					r__captureMap.SetBelong(this.instance);
				}
				return r__captureMap;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Group[] _groups
		/// </summary>
		protected RFieldArray<RSystem.RText.RRegularExpressions.RGroup> r__groups;
		public virtual RFieldArray<RSystem.RText.RRegularExpressions.RGroup> R_groups
		{
			get
			{
				if(r__groups == null)
				{
					r__groups = new(this, "_groups");
					r__groups.SetBelong(this.instance);
				}
				return r__groups;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected RProperty r_IsReadOnly;
		public virtual RProperty RIsReadOnly
		{
			get
			{
				if(r_IsReadOnly == null)
				{
					r_IsReadOnly = new(this, "IsReadOnly", -1);
					r_IsReadOnly.SetBelong(this.instance);
				}
				return r_IsReadOnly;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected RProperty r_Count;
		public virtual RProperty RCount
		{
			get
			{
				if(r_Count == null)
				{
					r_Count = new(this, "Count", -1);
					r_Count.SetBelong(this.instance);
				}
				return r_Count;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Group Item [Int32]
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RGroup r_Item_Int32;
		public virtual RSystem.RText.RRegularExpressions.RGroup RItem_Int32
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
		/// System.Text.RegularExpressions.Group Item [System.String]
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RGroup r_Item_String;
		public virtual RSystem.RText.RRegularExpressions.RGroup RItem_String
		{
			get
			{
				if(r_Item_String == null)
				{
					r_Item_String = new(this, "Item", -1, typeof(System.String));
					r_Item_String.SetBelong(this.instance);
				}
				return r_Item_String;
			}
		}

		/// <summary>
		/// Boolean IsSynchronized
		/// </summary>
		protected RProperty r_IsSynchronized;
		public virtual RProperty RIsSynchronized
		{
			get
			{
				if(r_IsSynchronized == null)
				{
					r_IsSynchronized = new(this, "IsSynchronized", -1);
					r_IsSynchronized.SetBelong(this.instance);
				}
				return r_IsSynchronized;
			}
		}

		/// <summary>
		/// System.Object SyncRoot
		/// </summary>
		protected RSystem.RObject r_SyncRoot;
		public virtual RSystem.RObject RSyncRoot
		{
			get
			{
				if(r_SyncRoot == null)
				{
					r_SyncRoot = new(this, "SyncRoot", -1);
					r_SyncRoot.SetBelong(this.instance);
				}
				return r_SyncRoot;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Item [Int32]
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RGroup r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__get_Item_Int32;
		public virtual RSystem.RText.RRegularExpressions.RGroup RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__get_Item_Int32
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__get_Item_Int32 == null)
				{
					r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__get_Item_Int32 = new(this, "System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Item", -1, typeof(System.Int32));
					r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__get_Item_Int32.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__get_Item_Int32;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IList.IsFixedSize
		/// </summary>
		protected RProperty r_RSystem__0__Collections__0__IList__0__get_IsFixedSize;
		public virtual RProperty RSystem__0__Collections__0__IList__0__get_IsFixedSize
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__get_IsFixedSize == null)
				{
					r_RSystem__0__Collections__0__IList__0__get_IsFixedSize = new(this, "System.Collections.IList.IsFixedSize", -1);
					r_RSystem__0__Collections__0__IList__0__get_IsFixedSize.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__get_IsFixedSize;
			}
		}

		/// <summary>
		/// System.Object System.Collections.IList.Item [Int32]
		/// </summary>
		protected RSystem.RObject r_RSystem__0__Collections__0__IList__0__get_Item_Int32;
		public virtual RSystem.RObject RSystem__0__Collections__0__IList__0__get_Item_Int32
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__get_Item_Int32 == null)
				{
					r_RSystem__0__Collections__0__IList__0__get_Item_Int32 = new(this, "System.Collections.IList.Item", -1, typeof(System.Int32));
					r_RSystem__0__Collections__0__IList__0__get_Item_Int32.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__get_Item_Int32;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_RGetEnumerator;
		public virtual RMethod RGetEnumerator
		{
			get
			{
				if(r_RGetEnumerator == null)
				{
					r_RGetEnumerator = new(this, "GetEnumerator", 0);
					r_RGetEnumerator.SetBelong(this.instance);
				}
				return r_RGetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerator`1[System.Text.RegularExpressions.Group] System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator()
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__IEnumerable__1__System__0__Text__0__RegularExpressions__0__Group__2____0__GetEnumerator;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__IEnumerable__1__System__0__Text__0__RegularExpressions__0__Group__2____0__GetEnumerator
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__IEnumerable__1__System__0__Text__0__RegularExpressions__0__Group__2____0__GetEnumerator == null)
				{
					r_RSystem__0__Collections__0__Generic__0__IEnumerable__1__System__0__Text__0__RegularExpressions__0__Group__2____0__GetEnumerator = new(this, "System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator", 0);
					r_RSystem__0__Collections__0__Generic__0__IEnumerable__1__System__0__Text__0__RegularExpressions__0__Group__2____0__GetEnumerator.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__IEnumerable__1__System__0__Text__0__RegularExpressions__0__Group__2____0__GetEnumerator;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Group GetGroup(Int32)
		/// </summary>
		protected RMethod r_RGetGroup_Int32;
		public virtual RMethod RGetGroup_Int32
		{
			get
			{
				if(r_RGetGroup_Int32 == null)
				{
					r_RGetGroup_Int32 = new(this, "GetGroup", 0, typeof(System.Int32));
					r_RGetGroup_Int32.SetBelong(this.instance);
				}
				return r_RGetGroup_Int32;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Group GetGroupImpl(Int32)
		/// </summary>
		protected RMethod r_RGetGroupImpl_Int32;
		public virtual RMethod RGetGroupImpl_Int32
		{
			get
			{
				if(r_RGetGroupImpl_Int32 == null)
				{
					r_RGetGroupImpl_Int32 = new(this, "GetGroupImpl", 0, typeof(System.Int32));
					r_RGetGroupImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetGroupImpl_Int32;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Array, Int32)
		/// </summary>
		protected RMethod r_RCopyTo_Array_Int32;
		public virtual RMethod RCopyTo_Array_Int32
		{
			get
			{
				if(r_RCopyTo_Array_Int32 == null)
				{
					r_RCopyTo_Array_Int32 = new(this, "CopyTo", 0, typeof(System.Array), typeof(System.Int32));
					r_RCopyTo_Array_Int32.SetBelong(this.instance);
				}
				return r_RCopyTo_Array_Int32;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Text.RegularExpressions.Group[], Int32)
		/// </summary>
		protected RMethod r_RCopyTo_GroupArray_Int32;
		public virtual RMethod RCopyTo_GroupArray_Int32
		{
			get
			{
				if(r_RCopyTo_GroupArray_Int32 == null)
				{
					r_RCopyTo_GroupArray_Int32 = new(this, "CopyTo", 0, typeof(System.Text.RegularExpressions.Group).MakeArrayType(), typeof(System.Int32));
					r_RCopyTo_GroupArray_Int32.SetBelong(this.instance);
				}
				return r_RCopyTo_GroupArray_Int32;
			}
		}

		/// <summary>
		/// Int32 System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(System.Text.RegularExpressions.Group)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__IndexOf_Group;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__IndexOf_Group
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__IndexOf_Group == null)
				{
					r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__IndexOf_Group = new(this, "System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf", 0, typeof(System.Text.RegularExpressions.Group));
					r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__IndexOf_Group.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__IndexOf_Group;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(Int32, System.Text.RegularExpressions.Group)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Insert_Int32_Group;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Insert_Int32_Group
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Insert_Int32_Group == null)
				{
					r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Insert_Int32_Group = new(this, "System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert", 0, typeof(System.Int32), typeof(System.Text.RegularExpressions.Group));
					r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Insert_Int32_Group.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Insert_Int32_Group;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(Int32)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__RemoveAt_Int32;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__RemoveAt_Int32
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__RemoveAt_Int32 == null)
				{
					r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__RemoveAt_Int32 = new(this, "System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt", 0, typeof(System.Int32));
					r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__RemoveAt_Int32.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__RemoveAt_Int32;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(System.Text.RegularExpressions.Group)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Add_Group;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Add_Group
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Add_Group == null)
				{
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Add_Group = new(this, "System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add", 0, typeof(System.Text.RegularExpressions.Group));
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Add_Group.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Add_Group;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear()
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Clear;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Clear
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Clear == null)
				{
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Clear = new(this, "System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear", 0);
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Clear.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Clear;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(System.Text.RegularExpressions.Group)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Contains_Group;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Contains_Group
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Contains_Group == null)
				{
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Contains_Group = new(this, "System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains", 0, typeof(System.Text.RegularExpressions.Group));
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Contains_Group.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Contains_Group;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(System.Text.RegularExpressions.Group)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Remove_Group;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Remove_Group
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Remove_Group == null)
				{
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Remove_Group = new(this, "System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove", 0, typeof(System.Text.RegularExpressions.Group));
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Remove_Group.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Remove_Group;
			}
		}

		/// <summary>
		/// Int32 System.Collections.IList.Add(System.Object)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__IList__0__Add_Object;
		public virtual RMethod RSystem__0__Collections__0__IList__0__Add_Object
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__Add_Object == null)
				{
					r_RSystem__0__Collections__0__IList__0__Add_Object = new(this, "System.Collections.IList.Add", 0, typeof(System.Object));
					r_RSystem__0__Collections__0__IList__0__Add_Object.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__Add_Object;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.Clear()
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__IList__0__Clear;
		public virtual RMethod RSystem__0__Collections__0__IList__0__Clear
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__Clear == null)
				{
					r_RSystem__0__Collections__0__IList__0__Clear = new(this, "System.Collections.IList.Clear", 0);
					r_RSystem__0__Collections__0__IList__0__Clear.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__Clear;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IList.Contains(System.Object)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__IList__0__Contains_Object;
		public virtual RMethod RSystem__0__Collections__0__IList__0__Contains_Object
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__Contains_Object == null)
				{
					r_RSystem__0__Collections__0__IList__0__Contains_Object = new(this, "System.Collections.IList.Contains", 0, typeof(System.Object));
					r_RSystem__0__Collections__0__IList__0__Contains_Object.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__Contains_Object;
			}
		}

		/// <summary>
		/// Int32 System.Collections.IList.IndexOf(System.Object)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__IList__0__IndexOf_Object;
		public virtual RMethod RSystem__0__Collections__0__IList__0__IndexOf_Object
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__IndexOf_Object == null)
				{
					r_RSystem__0__Collections__0__IList__0__IndexOf_Object = new(this, "System.Collections.IList.IndexOf", 0, typeof(System.Object));
					r_RSystem__0__Collections__0__IList__0__IndexOf_Object.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__IndexOf_Object;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.Insert(Int32, System.Object)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__IList__0__Insert_Int32_Object;
		public virtual RMethod RSystem__0__Collections__0__IList__0__Insert_Int32_Object
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__Insert_Int32_Object == null)
				{
					r_RSystem__0__Collections__0__IList__0__Insert_Int32_Object = new(this, "System.Collections.IList.Insert", 0, typeof(System.Int32), typeof(System.Object));
					r_RSystem__0__Collections__0__IList__0__Insert_Int32_Object.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__Insert_Int32_Object;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.Remove(System.Object)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__IList__0__Remove_Object;
		public virtual RMethod RSystem__0__Collections__0__IList__0__Remove_Object
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__Remove_Object == null)
				{
					r_RSystem__0__Collections__0__IList__0__Remove_Object = new(this, "System.Collections.IList.Remove", 0, typeof(System.Object));
					r_RSystem__0__Collections__0__IList__0__Remove_Object.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__Remove_Object;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.RemoveAt(Int32)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__IList__0__RemoveAt_Int32;
		public virtual RMethod RSystem__0__Collections__0__IList__0__RemoveAt_Int32
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__RemoveAt_Int32 == null)
				{
					r_RSystem__0__Collections__0__IList__0__RemoveAt_Int32 = new(this, "System.Collections.IList.RemoveAt", 0, typeof(System.Int32));
					r_RSystem__0__Collections__0__IList__0__RemoveAt_Int32.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__RemoveAt_Int32;
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


        public RGroupCollection() : base("System.Text.RegularExpressions.GroupCollection")
        {
        }

        public RGroupCollection(System.Object instance) : base("System.Text.RegularExpressions.GroupCollection")
		{
            SetInstance(instance);
		}

        public RGroupCollection(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGroupCollection(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Group> System__0__Collections__0__Generic__0__IEnumerable__1__System__0__Text__0__RegularExpressions__0__Group__2____0__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__0__Collections__0__Generic__0__IEnumerable__1__System__0__Text__0__RegularExpressions__0__Group__2____0__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Group>)___result;
        }


        public virtual System.Text.RegularExpressions.Group GetGroup(System.Int32  @groupnum)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@groupnum};
            var ___result = RGetGroup_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Group)___result;
        }


        public virtual System.Text.RegularExpressions.Group GetGroupImpl(System.Int32  @groupnum)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@groupnum};
            var ___result = RGetGroupImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Group)___result;
        }


        public virtual void CopyTo(System.Array  @array, System.Int32  @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RCopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Text.RegularExpressions.Group[]  @array, System.Int32  @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RCopyTo_GroupArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 System__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__IndexOf(System.Text.RegularExpressions.Group  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__IndexOf_Group.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void System__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Insert(System.Int32  @index, System.Text.RegularExpressions.Group  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @item};
            var ___result = RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Insert_Int32_Group.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__RemoveAt(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Group__2____0__RemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Add(System.Text.RegularExpressions.Group  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Add_Group.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Clear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean System__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Contains(System.Text.RegularExpressions.Group  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Contains_Group.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean System__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Remove(System.Text.RegularExpressions.Group  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Group__2____0__Remove_Group.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 System__0__Collections__0__IList__0__Add(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSystem__0__Collections__0__IList__0__Add_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void System__0__Collections__0__IList__0__Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__0__Collections__0__IList__0__Clear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean System__0__Collections__0__IList__0__Contains(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSystem__0__Collections__0__IList__0__Contains_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 System__0__Collections__0__IList__0__IndexOf(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSystem__0__Collections__0__IList__0__IndexOf_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void System__0__Collections__0__IList__0__Insert(System.Int32  @index, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RSystem__0__Collections__0__IList__0__Insert_Int32_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Collections__0__IList__0__Remove(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSystem__0__Collections__0__IList__0__Remove_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Collections__0__IList__0__RemoveAt(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RSystem__0__Collections__0__IList__0__RemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
