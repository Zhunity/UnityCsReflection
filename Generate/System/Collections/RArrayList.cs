using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections
{
	/// <summary>
	/// System.Collections.ArrayList
	/// </summary>
    public partial class RArrayList : RMember //
    {

		/// <summary>
		/// System.Object[] _items
		/// </summary>
		protected RFieldArray<RSystem.RObject> r__items;
		public virtual RFieldArray<RSystem.RObject> R_items
		{
			get
			{
				if(r__items == null)
				{
					r__items = new(this, "_items");
					r__items.SetBelong(this.instance);
				}
				return r__items;
			}
		}

		/// <summary>
		/// System.Int32 _size
		/// </summary>
		protected RSystem.RInt32 r__size;
		public virtual RSystem.RInt32 R_size
		{
			get
			{
				if(r__size == null)
				{
					r__size = new(this, "_size");
					r__size.SetBelong(this.instance);
				}
				return r__size;
			}
		}

		/// <summary>
		/// System.Int32 _version
		/// </summary>
		protected RSystem.RInt32 r__version;
		public virtual RSystem.RInt32 R_version
		{
			get
			{
				if(r__version == null)
				{
					r__version = new(this, "_version");
					r__version.SetBelong(this.instance);
				}
				return r__version;
			}
		}

		/// <summary>
		/// System.Object _syncRoot
		/// </summary>
		protected RSystem.RObject r__syncRoot;
		public virtual RSystem.RObject R_syncRoot
		{
			get
			{
				if(r__syncRoot == null)
				{
					r__syncRoot = new(this, "_syncRoot");
					r__syncRoot.SetBelong(this.instance);
				}
				return r__syncRoot;
			}
		}

		/// <summary>
		/// System.Int32 _defaultCapacity
		/// </summary>
		protected static RSystem.RInt32 r__defaultCapacity;
		public static RSystem.RInt32 R_defaultCapacity
		{
			get
			{
				if(r__defaultCapacity == null)
				{
					r__defaultCapacity = new(typeof(System.Collections.ArrayList), "_defaultCapacity");
					r__defaultCapacity.SetBelong(null);
				}
				return r__defaultCapacity;
			}
		}

		/// <summary>
		/// System.Int32 MaxArrayLength
		/// </summary>
		protected static RSystem.RInt32 r_MaxArrayLength;
		public static RSystem.RInt32 RMaxArrayLength
		{
			get
			{
				if(r_MaxArrayLength == null)
				{
					r_MaxArrayLength = new(typeof(System.Collections.ArrayList), "MaxArrayLength");
					r_MaxArrayLength.SetBelong(null);
				}
				return r_MaxArrayLength;
			}
		}

		/// <summary>
		/// Int32 Capacity
		/// </summary>
		protected RSystem.RInt32 r_Capacity;
		public virtual RSystem.RInt32 RCapacity
		{
			get
			{
				if(r_Capacity == null)
				{
					r_Capacity = new(this, "Capacity", -1);
					r_Capacity.SetBelong(this.instance);
				}
				return r_Capacity;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected RSystem.RInt32 r_Count;
		public virtual RSystem.RInt32 RCount
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
		/// Boolean IsFixedSize
		/// </summary>
		protected RSystem.RBoolean r_IsFixedSize;
		public virtual RSystem.RBoolean RIsFixedSize
		{
			get
			{
				if(r_IsFixedSize == null)
				{
					r_IsFixedSize = new(this, "IsFixedSize", -1);
					r_IsFixedSize.SetBelong(this.instance);
				}
				return r_IsFixedSize;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected RSystem.RBoolean r_IsReadOnly;
		public virtual RSystem.RBoolean RIsReadOnly
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
		/// Boolean IsSynchronized
		/// </summary>
		protected RSystem.RBoolean r_IsSynchronized;
		public virtual RSystem.RBoolean RIsSynchronized
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
		/// System.Object Item [Int32]
		/// </summary>
		protected RSystem.RObject r_Item_Int32;
		public virtual RSystem.RObject RItem_Int32
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
		/// System.Collections.ArrayList Adapter(System.Collections.IList)
		/// </summary>
		protected static RMethod r_Adapter_IList;
		public static RMethod RAdapter_IList
		{
			get
			{
				if(r_Adapter_IList == null)
				{
					r_Adapter_IList = new(typeof(System.Collections.ArrayList), "Adapter", 0, typeof(System.Collections.IList));
					r_Adapter_IList.SetBelong(null);
				}
				return r_Adapter_IList;
			}
		}

		/// <summary>
		/// Int32 Add(System.Object)
		/// </summary>
		protected RMethod r_Add_Object;
		public virtual RMethod RAdd_Object
		{
			get
			{
				if(r_Add_Object == null)
				{
					r_Add_Object = new(this, "Add", 0, typeof(System.Object));
					r_Add_Object.SetBelong(this.instance);
				}
				return r_Add_Object;
			}
		}

		/// <summary>
		/// Void AddRange(System.Collections.ICollection)
		/// </summary>
		protected RMethod r_AddRange_ICollection;
		public virtual RMethod RAddRange_ICollection
		{
			get
			{
				if(r_AddRange_ICollection == null)
				{
					r_AddRange_ICollection = new(this, "AddRange", 0, typeof(System.Collections.ICollection));
					r_AddRange_ICollection.SetBelong(this.instance);
				}
				return r_AddRange_ICollection;
			}
		}

		/// <summary>
		/// Int32 BinarySearch(Int32, Int32, System.Object, System.Collections.IComparer)
		/// </summary>
		protected RMethod r_BinarySearch_Int32_Int32_Object_IComparer;
		public virtual RMethod RBinarySearch_Int32_Int32_Object_IComparer
		{
			get
			{
				if(r_BinarySearch_Int32_Int32_Object_IComparer == null)
				{
					r_BinarySearch_Int32_Int32_Object_IComparer = new(this, "BinarySearch", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Object), typeof(System.Collections.IComparer));
					r_BinarySearch_Int32_Int32_Object_IComparer.SetBelong(this.instance);
				}
				return r_BinarySearch_Int32_Int32_Object_IComparer;
			}
		}

		/// <summary>
		/// Int32 BinarySearch(System.Object)
		/// </summary>
		protected RMethod r_BinarySearch_Object;
		public virtual RMethod RBinarySearch_Object
		{
			get
			{
				if(r_BinarySearch_Object == null)
				{
					r_BinarySearch_Object = new(this, "BinarySearch", 0, typeof(System.Object));
					r_BinarySearch_Object.SetBelong(this.instance);
				}
				return r_BinarySearch_Object;
			}
		}

		/// <summary>
		/// Int32 BinarySearch(System.Object, System.Collections.IComparer)
		/// </summary>
		protected RMethod r_BinarySearch_Object_IComparer;
		public virtual RMethod RBinarySearch_Object_IComparer
		{
			get
			{
				if(r_BinarySearch_Object_IComparer == null)
				{
					r_BinarySearch_Object_IComparer = new(this, "BinarySearch", 0, typeof(System.Object), typeof(System.Collections.IComparer));
					r_BinarySearch_Object_IComparer.SetBelong(this.instance);
				}
				return r_BinarySearch_Object_IComparer;
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
		/// System.Object Clone()
		/// </summary>
		protected RMethod r_Clone;
		public virtual RMethod RClone
		{
			get
			{
				if(r_Clone == null)
				{
					r_Clone = new(this, "Clone", 0);
					r_Clone.SetBelong(this.instance);
				}
				return r_Clone;
			}
		}

		/// <summary>
		/// Boolean Contains(System.Object)
		/// </summary>
		protected RMethod r_Contains_Object;
		public virtual RMethod RContains_Object
		{
			get
			{
				if(r_Contains_Object == null)
				{
					r_Contains_Object = new(this, "Contains", 0, typeof(System.Object));
					r_Contains_Object.SetBelong(this.instance);
				}
				return r_Contains_Object;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Array)
		/// </summary>
		protected RMethod r_CopyTo_Array;
		public virtual RMethod RCopyTo_Array
		{
			get
			{
				if(r_CopyTo_Array == null)
				{
					r_CopyTo_Array = new(this, "CopyTo", 0, typeof(System.Array));
					r_CopyTo_Array.SetBelong(this.instance);
				}
				return r_CopyTo_Array;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Array, Int32)
		/// </summary>
		protected RMethod r_CopyTo_Array_Int32;
		public virtual RMethod RCopyTo_Array_Int32
		{
			get
			{
				if(r_CopyTo_Array_Int32 == null)
				{
					r_CopyTo_Array_Int32 = new(this, "CopyTo", 0, typeof(System.Array), typeof(System.Int32));
					r_CopyTo_Array_Int32.SetBelong(this.instance);
				}
				return r_CopyTo_Array_Int32;
			}
		}

		/// <summary>
		/// Void CopyTo(Int32, System.Array, Int32, Int32)
		/// </summary>
		protected RMethod r_CopyTo_Int32_Array_Int32_Int32;
		public virtual RMethod RCopyTo_Int32_Array_Int32_Int32
		{
			get
			{
				if(r_CopyTo_Int32_Array_Int32_Int32 == null)
				{
					r_CopyTo_Int32_Array_Int32_Int32 = new(this, "CopyTo", 0, typeof(System.Int32), typeof(System.Array), typeof(System.Int32), typeof(System.Int32));
					r_CopyTo_Int32_Array_Int32_Int32.SetBelong(this.instance);
				}
				return r_CopyTo_Int32_Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void EnsureCapacity(Int32)
		/// </summary>
		protected RMethod r_EnsureCapacity_Int32;
		public virtual RMethod REnsureCapacity_Int32
		{
			get
			{
				if(r_EnsureCapacity_Int32 == null)
				{
					r_EnsureCapacity_Int32 = new(this, "EnsureCapacity", 0, typeof(System.Int32));
					r_EnsureCapacity_Int32.SetBelong(this.instance);
				}
				return r_EnsureCapacity_Int32;
			}
		}

		/// <summary>
		/// System.Collections.IList FixedSize(System.Collections.IList)
		/// </summary>
		protected static RMethod r_FixedSize_IList;
		public static RMethod RFixedSize_IList
		{
			get
			{
				if(r_FixedSize_IList == null)
				{
					r_FixedSize_IList = new(typeof(System.Collections.ArrayList), "FixedSize", 0, typeof(System.Collections.IList));
					r_FixedSize_IList.SetBelong(null);
				}
				return r_FixedSize_IList;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList FixedSize(System.Collections.ArrayList)
		/// </summary>
		protected static RMethod r_FixedSize_ArrayList;
		public static RMethod RFixedSize_ArrayList
		{
			get
			{
				if(r_FixedSize_ArrayList == null)
				{
					r_FixedSize_ArrayList = new(typeof(System.Collections.ArrayList), "FixedSize", 0, typeof(System.Collections.ArrayList));
					r_FixedSize_ArrayList.SetBelong(null);
				}
				return r_FixedSize_ArrayList;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_GetEnumerator;
		public virtual RMethod RGetEnumerator
		{
			get
			{
				if(r_GetEnumerator == null)
				{
					r_GetEnumerator = new(this, "GetEnumerator", 0);
					r_GetEnumerator.SetBelong(this.instance);
				}
				return r_GetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumerator(Int32, Int32)
		/// </summary>
		protected RMethod r_GetEnumerator_Int32_Int32;
		public virtual RMethod RGetEnumerator_Int32_Int32
		{
			get
			{
				if(r_GetEnumerator_Int32_Int32 == null)
				{
					r_GetEnumerator_Int32_Int32 = new(this, "GetEnumerator", 0, typeof(System.Int32), typeof(System.Int32));
					r_GetEnumerator_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetEnumerator_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.Object)
		/// </summary>
		protected RMethod r_IndexOf_Object;
		public virtual RMethod RIndexOf_Object
		{
			get
			{
				if(r_IndexOf_Object == null)
				{
					r_IndexOf_Object = new(this, "IndexOf", 0, typeof(System.Object));
					r_IndexOf_Object.SetBelong(this.instance);
				}
				return r_IndexOf_Object;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.Object, Int32)
		/// </summary>
		protected RMethod r_IndexOf_Object_Int32;
		public virtual RMethod RIndexOf_Object_Int32
		{
			get
			{
				if(r_IndexOf_Object_Int32 == null)
				{
					r_IndexOf_Object_Int32 = new(this, "IndexOf", 0, typeof(System.Object), typeof(System.Int32));
					r_IndexOf_Object_Int32.SetBelong(this.instance);
				}
				return r_IndexOf_Object_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.Object, Int32, Int32)
		/// </summary>
		protected RMethod r_IndexOf_Object_Int32_Int32;
		public virtual RMethod RIndexOf_Object_Int32_Int32
		{
			get
			{
				if(r_IndexOf_Object_Int32_Int32 == null)
				{
					r_IndexOf_Object_Int32_Int32 = new(this, "IndexOf", 0, typeof(System.Object), typeof(System.Int32), typeof(System.Int32));
					r_IndexOf_Object_Int32_Int32.SetBelong(this.instance);
				}
				return r_IndexOf_Object_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Insert(Int32, System.Object)
		/// </summary>
		protected RMethod r_Insert_Int32_Object;
		public virtual RMethod RInsert_Int32_Object
		{
			get
			{
				if(r_Insert_Int32_Object == null)
				{
					r_Insert_Int32_Object = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Object));
					r_Insert_Int32_Object.SetBelong(this.instance);
				}
				return r_Insert_Int32_Object;
			}
		}

		/// <summary>
		/// Void InsertRange(Int32, System.Collections.ICollection)
		/// </summary>
		protected RMethod r_InsertRange_Int32_ICollection;
		public virtual RMethod RInsertRange_Int32_ICollection
		{
			get
			{
				if(r_InsertRange_Int32_ICollection == null)
				{
					r_InsertRange_Int32_ICollection = new(this, "InsertRange", 0, typeof(System.Int32), typeof(System.Collections.ICollection));
					r_InsertRange_Int32_ICollection.SetBelong(this.instance);
				}
				return r_InsertRange_Int32_ICollection;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.Object)
		/// </summary>
		protected RMethod r_LastIndexOf_Object;
		public virtual RMethod RLastIndexOf_Object
		{
			get
			{
				if(r_LastIndexOf_Object == null)
				{
					r_LastIndexOf_Object = new(this, "LastIndexOf", 0, typeof(System.Object));
					r_LastIndexOf_Object.SetBelong(this.instance);
				}
				return r_LastIndexOf_Object;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.Object, Int32)
		/// </summary>
		protected RMethod r_LastIndexOf_Object_Int32;
		public virtual RMethod RLastIndexOf_Object_Int32
		{
			get
			{
				if(r_LastIndexOf_Object_Int32 == null)
				{
					r_LastIndexOf_Object_Int32 = new(this, "LastIndexOf", 0, typeof(System.Object), typeof(System.Int32));
					r_LastIndexOf_Object_Int32.SetBelong(this.instance);
				}
				return r_LastIndexOf_Object_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.Object, Int32, Int32)
		/// </summary>
		protected RMethod r_LastIndexOf_Object_Int32_Int32;
		public virtual RMethod RLastIndexOf_Object_Int32_Int32
		{
			get
			{
				if(r_LastIndexOf_Object_Int32_Int32 == null)
				{
					r_LastIndexOf_Object_Int32_Int32 = new(this, "LastIndexOf", 0, typeof(System.Object), typeof(System.Int32), typeof(System.Int32));
					r_LastIndexOf_Object_Int32_Int32.SetBelong(this.instance);
				}
				return r_LastIndexOf_Object_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Collections.IList ReadOnly(System.Collections.IList)
		/// </summary>
		protected static RMethod r_ReadOnly_IList;
		public static RMethod RReadOnly_IList
		{
			get
			{
				if(r_ReadOnly_IList == null)
				{
					r_ReadOnly_IList = new(typeof(System.Collections.ArrayList), "ReadOnly", 0, typeof(System.Collections.IList));
					r_ReadOnly_IList.SetBelong(null);
				}
				return r_ReadOnly_IList;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList ReadOnly(System.Collections.ArrayList)
		/// </summary>
		protected static RMethod r_ReadOnly_ArrayList;
		public static RMethod RReadOnly_ArrayList
		{
			get
			{
				if(r_ReadOnly_ArrayList == null)
				{
					r_ReadOnly_ArrayList = new(typeof(System.Collections.ArrayList), "ReadOnly", 0, typeof(System.Collections.ArrayList));
					r_ReadOnly_ArrayList.SetBelong(null);
				}
				return r_ReadOnly_ArrayList;
			}
		}

		/// <summary>
		/// Void Remove(System.Object)
		/// </summary>
		protected RMethod r_Remove_Object;
		public virtual RMethod RRemove_Object
		{
			get
			{
				if(r_Remove_Object == null)
				{
					r_Remove_Object = new(this, "Remove", 0, typeof(System.Object));
					r_Remove_Object.SetBelong(this.instance);
				}
				return r_Remove_Object;
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
		/// Void RemoveRange(Int32, Int32)
		/// </summary>
		protected RMethod r_RemoveRange_Int32_Int32;
		public virtual RMethod RRemoveRange_Int32_Int32
		{
			get
			{
				if(r_RemoveRange_Int32_Int32 == null)
				{
					r_RemoveRange_Int32_Int32 = new(this, "RemoveRange", 0, typeof(System.Int32), typeof(System.Int32));
					r_RemoveRange_Int32_Int32.SetBelong(this.instance);
				}
				return r_RemoveRange_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList Repeat(System.Object, Int32)
		/// </summary>
		protected static RMethod r_Repeat_Object_Int32;
		public static RMethod RRepeat_Object_Int32
		{
			get
			{
				if(r_Repeat_Object_Int32 == null)
				{
					r_Repeat_Object_Int32 = new(typeof(System.Collections.ArrayList), "Repeat", 0, typeof(System.Object), typeof(System.Int32));
					r_Repeat_Object_Int32.SetBelong(null);
				}
				return r_Repeat_Object_Int32;
			}
		}

		/// <summary>
		/// Void Reverse()
		/// </summary>
		protected RMethod r_Reverse;
		public virtual RMethod RReverse
		{
			get
			{
				if(r_Reverse == null)
				{
					r_Reverse = new(this, "Reverse", 0);
					r_Reverse.SetBelong(this.instance);
				}
				return r_Reverse;
			}
		}

		/// <summary>
		/// Void Reverse(Int32, Int32)
		/// </summary>
		protected RMethod r_Reverse_Int32_Int32;
		public virtual RMethod RReverse_Int32_Int32
		{
			get
			{
				if(r_Reverse_Int32_Int32 == null)
				{
					r_Reverse_Int32_Int32 = new(this, "Reverse", 0, typeof(System.Int32), typeof(System.Int32));
					r_Reverse_Int32_Int32.SetBelong(this.instance);
				}
				return r_Reverse_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetRange(Int32, System.Collections.ICollection)
		/// </summary>
		protected RMethod r_SetRange_Int32_ICollection;
		public virtual RMethod RSetRange_Int32_ICollection
		{
			get
			{
				if(r_SetRange_Int32_ICollection == null)
				{
					r_SetRange_Int32_ICollection = new(this, "SetRange", 0, typeof(System.Int32), typeof(System.Collections.ICollection));
					r_SetRange_Int32_ICollection.SetBelong(this.instance);
				}
				return r_SetRange_Int32_ICollection;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList GetRange(Int32, Int32)
		/// </summary>
		protected RMethod r_GetRange_Int32_Int32;
		public virtual RMethod RGetRange_Int32_Int32
		{
			get
			{
				if(r_GetRange_Int32_Int32 == null)
				{
					r_GetRange_Int32_Int32 = new(this, "GetRange", 0, typeof(System.Int32), typeof(System.Int32));
					r_GetRange_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetRange_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Sort()
		/// </summary>
		protected RMethod r_Sort;
		public virtual RMethod RSort
		{
			get
			{
				if(r_Sort == null)
				{
					r_Sort = new(this, "Sort", 0);
					r_Sort.SetBelong(this.instance);
				}
				return r_Sort;
			}
		}

		/// <summary>
		/// Void Sort(System.Collections.IComparer)
		/// </summary>
		protected RMethod r_Sort_IComparer;
		public virtual RMethod RSort_IComparer
		{
			get
			{
				if(r_Sort_IComparer == null)
				{
					r_Sort_IComparer = new(this, "Sort", 0, typeof(System.Collections.IComparer));
					r_Sort_IComparer.SetBelong(this.instance);
				}
				return r_Sort_IComparer;
			}
		}

		/// <summary>
		/// Void Sort(Int32, Int32, System.Collections.IComparer)
		/// </summary>
		protected RMethod r_Sort_Int32_Int32_IComparer;
		public virtual RMethod RSort_Int32_Int32_IComparer
		{
			get
			{
				if(r_Sort_Int32_Int32_IComparer == null)
				{
					r_Sort_Int32_Int32_IComparer = new(this, "Sort", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Collections.IComparer));
					r_Sort_Int32_Int32_IComparer.SetBelong(this.instance);
				}
				return r_Sort_Int32_Int32_IComparer;
			}
		}

		/// <summary>
		/// System.Collections.IList Synchronized(System.Collections.IList)
		/// </summary>
		protected static RMethod r_Synchronized_IList;
		public static RMethod RSynchronized_IList
		{
			get
			{
				if(r_Synchronized_IList == null)
				{
					r_Synchronized_IList = new(typeof(System.Collections.ArrayList), "Synchronized", 0, typeof(System.Collections.IList));
					r_Synchronized_IList.SetBelong(null);
				}
				return r_Synchronized_IList;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList Synchronized(System.Collections.ArrayList)
		/// </summary>
		protected static RMethod r_Synchronized_ArrayList;
		public static RMethod RSynchronized_ArrayList
		{
			get
			{
				if(r_Synchronized_ArrayList == null)
				{
					r_Synchronized_ArrayList = new(typeof(System.Collections.ArrayList), "Synchronized", 0, typeof(System.Collections.ArrayList));
					r_Synchronized_ArrayList.SetBelong(null);
				}
				return r_Synchronized_ArrayList;
			}
		}

		/// <summary>
		/// System.Object[] ToArray()
		/// </summary>
		protected RMethod r_ToArray;
		public virtual RMethod RToArray
		{
			get
			{
				if(r_ToArray == null)
				{
					r_ToArray = new(this, "ToArray", 0);
					r_ToArray.SetBelong(this.instance);
				}
				return r_ToArray;
			}
		}

		/// <summary>
		/// System.Array ToArray(System.Type)
		/// </summary>
		protected RMethod r_ToArray_Type;
		public virtual RMethod RToArray_Type
		{
			get
			{
				if(r_ToArray_Type == null)
				{
					r_ToArray_Type = new(this, "ToArray", 0, typeof(System.Type));
					r_ToArray_Type.SetBelong(this.instance);
				}
				return r_ToArray_Type;
			}
		}

		/// <summary>
		/// Void TrimToSize()
		/// </summary>
		protected RMethod r_TrimToSize;
		public virtual RMethod RTrimToSize
		{
			get
			{
				if(r_TrimToSize == null)
				{
					r_TrimToSize = new(this, "TrimToSize", 0);
					r_TrimToSize.SetBelong(this.instance);
				}
				return r_TrimToSize;
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


        public RArrayList() : base("System.Collections.ArrayList")
        {
        }

        public RArrayList(System.Object instance) : base("System.Collections.ArrayList")
		{
            SetInstance(instance);
		}

        public RArrayList(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RArrayList(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Collections.ArrayList Adapter(System.Collections.IList @list)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list};
            var ___result = RAdapter_IList.Invoke(___genericsType, ___parameters);

            return (System.Collections.ArrayList)___result;
        }


        public virtual System.Int32 Add(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAdd_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void AddRange(System.Collections.ICollection @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RAddRange_ICollection.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 BinarySearch(System.Int32 @index, System.Int32 @count, System.Object @value, System.Collections.IComparer @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @count, @value, @comparer};
            var ___result = RBinarySearch_Int32_Int32_Object_IComparer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 BinarySearch(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RBinarySearch_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 BinarySearch(System.Object @value, System.Collections.IComparer @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @comparer};
            var ___result = RBinarySearch_Object_IComparer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean Contains(System.Object @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RContains_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CopyTo(System.Array @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array};
            var ___result = RCopyTo_Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Array @array, System.Int32 @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RCopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Int32 @index, System.Array @array, System.Int32 @arrayIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @array, @arrayIndex, @count};
            var ___result = RCopyTo_Int32_Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnsureCapacity(System.Int32 @min)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@min};
            var ___result = REnsureCapacity_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Collections.IList FixedSize(System.Collections.IList @list)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list};
            var ___result = RFixedSize_IList.Invoke(___genericsType, ___parameters);

            return (System.Collections.IList)___result;
        }


        public static System.Collections.ArrayList FixedSize(System.Collections.ArrayList @list)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list};
            var ___result = RFixedSize_ArrayList.Invoke(___genericsType, ___parameters);

            return (System.Collections.ArrayList)___result;
        }


        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Collections.IEnumerator GetEnumerator(System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @count};
            var ___result = RGetEnumerator_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Int32 IndexOf(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RIndexOf_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.Object @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex};
            var ___result = RIndexOf_Object_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.Object @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RIndexOf_Object_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Insert(System.Int32 @index, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertRange(System.Int32 @index, System.Collections.ICollection @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @c};
            var ___result = RInsertRange_Int32_ICollection.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 LastIndexOf(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RLastIndexOf_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.Object @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex};
            var ___result = RLastIndexOf_Object_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.Object @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RLastIndexOf_Object_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Collections.IList ReadOnly(System.Collections.IList @list)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list};
            var ___result = RReadOnly_IList.Invoke(___genericsType, ___parameters);

            return (System.Collections.IList)___result;
        }


        public static System.Collections.ArrayList ReadOnly(System.Collections.ArrayList @list)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list};
            var ___result = RReadOnly_ArrayList.Invoke(___genericsType, ___parameters);

            return (System.Collections.ArrayList)___result;
        }


        public virtual void Remove(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RRemove_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RRemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveRange(System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @count};
            var ___result = RRemoveRange_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Collections.ArrayList Repeat(System.Object @value, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @count};
            var ___result = RRepeat_Object_Int32.Invoke(___genericsType, ___parameters);

            return (System.Collections.ArrayList)___result;
        }


        public virtual void Reverse()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReverse.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reverse(System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @count};
            var ___result = RReverse_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRange(System.Int32 @index, System.Collections.ICollection @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @c};
            var ___result = RSetRange_Int32_ICollection.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.ArrayList GetRange(System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @count};
            var ___result = RGetRange_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Collections.ArrayList)___result;
        }


        public virtual void Sort()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSort.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Sort(System.Collections.IComparer @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comparer};
            var ___result = RSort_IComparer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Sort(System.Int32 @index, System.Int32 @count, System.Collections.IComparer @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @count, @comparer};
            var ___result = RSort_Int32_Int32_IComparer.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Collections.IList Synchronized(System.Collections.IList @list)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list};
            var ___result = RSynchronized_IList.Invoke(___genericsType, ___parameters);

            return (System.Collections.IList)___result;
        }


        public static System.Collections.ArrayList Synchronized(System.Collections.ArrayList @list)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list};
            var ___result = RSynchronized_ArrayList.Invoke(___genericsType, ___parameters);

            return (System.Collections.ArrayList)___result;
        }


        public virtual System.Object[] ToArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToArray.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Array ToArray(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RToArray_Type.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public virtual void TrimToSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTrimToSize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
