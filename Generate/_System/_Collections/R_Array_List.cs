
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections
{
	/// <summary>
	/// System.Collections.ArrayList
	/// </summary>
    public partial class RArrayList : RMember //
    {

		/// <summary>
		/// System.Object[] _items
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> r_F_items;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> RF_items
		{
			get
			{
				if(r_F_items == null)
				{
					r_F_items = new(this, "_items");
					r_F_items.SetBelong(this.instance);
				}
				return r_F_items;
			}
		}

		/// <summary>
		/// System.Int32 _size
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_size;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_size
		{
			get
			{
				if(r_F_size == null)
				{
					r_F_size = new(this, "_size");
					r_F_size.SetBelong(this.instance);
				}
				return r_F_size;
			}
		}

		/// <summary>
		/// System.Int32 _version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_version;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_version
		{
			get
			{
				if(r_F_version == null)
				{
					r_F_version = new(this, "_version");
					r_F_version.SetBelong(this.instance);
				}
				return r_F_version;
			}
		}

		/// <summary>
		/// System.Object _syncRoot
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_F_syncRoot;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RF_syncRoot
		{
			get
			{
				if(r_F_syncRoot == null)
				{
					r_F_syncRoot = new(this, "_syncRoot");
					r_F_syncRoot.SetBelong(this.instance);
				}
				return r_F_syncRoot;
			}
		}

		/// <summary>
		/// System.Int32 _defaultCapacity
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_F_defaultCapacity;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RF_defaultCapacity
		{
			get
			{
				if(r_F_defaultCapacity == null)
				{
					r_F_defaultCapacity = new(typeof(System.Collections.ArrayList), "_defaultCapacity");
					r_F_defaultCapacity.SetBelong(null);
				}
				return r_F_defaultCapacity;
			}
		}

		/// <summary>
		/// System.Int32 MaxArrayLength
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FMaxArrayLength;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFMaxArrayLength
		{
			get
			{
				if(r_FMaxArrayLength == null)
				{
					r_FMaxArrayLength = new(typeof(System.Collections.ArrayList), "MaxArrayLength");
					r_FMaxArrayLength.SetBelong(null);
				}
				return r_FMaxArrayLength;
			}
		}

		/// <summary>
		/// Int32 Capacity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PCapacity;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPCapacity
		{
			get
			{
				if(r_PCapacity == null)
				{
					r_PCapacity = new(this, "Capacity", -1);
					r_PCapacity.SetBelong(this.instance);
				}
				return r_PCapacity;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPCount
		{
			get
			{
				if(r_PCount == null)
				{
					r_PCount = new(this, "Count", -1);
					r_PCount.SetBelong(this.instance);
				}
				return r_PCount;
			}
		}

		/// <summary>
		/// Boolean IsFixedSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsFixedSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsFixedSize
		{
			get
			{
				if(r_PIsFixedSize == null)
				{
					r_PIsFixedSize = new(this, "IsFixedSize", -1);
					r_PIsFixedSize.SetBelong(this.instance);
				}
				return r_PIsFixedSize;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsReadOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsReadOnly
		{
			get
			{
				if(r_PIsReadOnly == null)
				{
					r_PIsReadOnly = new(this, "IsReadOnly", -1);
					r_PIsReadOnly.SetBelong(this.instance);
				}
				return r_PIsReadOnly;
			}
		}

		/// <summary>
		/// Boolean IsSynchronized
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSynchronized;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSynchronized
		{
			get
			{
				if(r_PIsSynchronized == null)
				{
					r_PIsSynchronized = new(this, "IsSynchronized", -1);
					r_PIsSynchronized.SetBelong(this.instance);
				}
				return r_PIsSynchronized;
			}
		}

		/// <summary>
		/// System.Object SyncRoot
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PSyncRoot;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPSyncRoot
		{
			get
			{
				if(r_PSyncRoot == null)
				{
					r_PSyncRoot = new(this, "SyncRoot", -1);
					r_PSyncRoot.SetBelong(this.instance);
				}
				return r_PSyncRoot;
			}
		}

		/// <summary>
		/// System.Object Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PItem_Int32;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPItem_Int32
		{
			get
			{
				if(r_PItem_Int32 == null)
				{
					r_PItem_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_PItem_Int32.SetBelong(this.instance);
				}
				return r_PItem_Int32;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList Adapter(System.Collections.IList)
		/// </summary>
		protected static RMethod r_MAdapter_IList;
		public static RMethod RMAdapter_IList
		{
			get
			{
				if(r_MAdapter_IList == null)
				{
					r_MAdapter_IList = new(typeof(System.Collections.ArrayList), "Adapter", 0, typeof(System.Collections.IList));
					r_MAdapter_IList.SetBelong(null);
				}
				return r_MAdapter_IList;
			}
		}

		/// <summary>
		/// Int32 Add(System.Object)
		/// </summary>
		protected RMethod r_MAdd_Object;
		public virtual RMethod RMAdd_Object
		{
			get
			{
				if(r_MAdd_Object == null)
				{
					r_MAdd_Object = new(this, "Add", 0, typeof(System.Object));
					r_MAdd_Object.SetBelong(this.instance);
				}
				return r_MAdd_Object;
			}
		}

		/// <summary>
		/// Void AddRange(System.Collections.ICollection)
		/// </summary>
		protected RMethod r_MAddRange_ICollection;
		public virtual RMethod RMAddRange_ICollection
		{
			get
			{
				if(r_MAddRange_ICollection == null)
				{
					r_MAddRange_ICollection = new(this, "AddRange", 0, typeof(System.Collections.ICollection));
					r_MAddRange_ICollection.SetBelong(this.instance);
				}
				return r_MAddRange_ICollection;
			}
		}

		/// <summary>
		/// Int32 BinarySearch(Int32, Int32, System.Object, System.Collections.IComparer)
		/// </summary>
		protected RMethod r_MBinarySearch_Int32_Int32_Object_IComparer;
		public virtual RMethod RMBinarySearch_Int32_Int32_Object_IComparer
		{
			get
			{
				if(r_MBinarySearch_Int32_Int32_Object_IComparer == null)
				{
					r_MBinarySearch_Int32_Int32_Object_IComparer = new(this, "BinarySearch", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Object), typeof(System.Collections.IComparer));
					r_MBinarySearch_Int32_Int32_Object_IComparer.SetBelong(this.instance);
				}
				return r_MBinarySearch_Int32_Int32_Object_IComparer;
			}
		}

		/// <summary>
		/// Int32 BinarySearch(System.Object)
		/// </summary>
		protected RMethod r_MBinarySearch_Object;
		public virtual RMethod RMBinarySearch_Object
		{
			get
			{
				if(r_MBinarySearch_Object == null)
				{
					r_MBinarySearch_Object = new(this, "BinarySearch", 0, typeof(System.Object));
					r_MBinarySearch_Object.SetBelong(this.instance);
				}
				return r_MBinarySearch_Object;
			}
		}

		/// <summary>
		/// Int32 BinarySearch(System.Object, System.Collections.IComparer)
		/// </summary>
		protected RMethod r_MBinarySearch_Object_IComparer;
		public virtual RMethod RMBinarySearch_Object_IComparer
		{
			get
			{
				if(r_MBinarySearch_Object_IComparer == null)
				{
					r_MBinarySearch_Object_IComparer = new(this, "BinarySearch", 0, typeof(System.Object), typeof(System.Collections.IComparer));
					r_MBinarySearch_Object_IComparer.SetBelong(this.instance);
				}
				return r_MBinarySearch_Object_IComparer;
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
					r_MClear.SetBelong(this.instance);
				}
				return r_MClear;
			}
		}

		/// <summary>
		/// System.Object Clone()
		/// </summary>
		protected RMethod r_MClone;
		public virtual RMethod RMClone
		{
			get
			{
				if(r_MClone == null)
				{
					r_MClone = new(this, "Clone", 0);
					r_MClone.SetBelong(this.instance);
				}
				return r_MClone;
			}
		}

		/// <summary>
		/// Boolean Contains(System.Object)
		/// </summary>
		protected RMethod r_MContains_Object;
		public virtual RMethod RMContains_Object
		{
			get
			{
				if(r_MContains_Object == null)
				{
					r_MContains_Object = new(this, "Contains", 0, typeof(System.Object));
					r_MContains_Object.SetBelong(this.instance);
				}
				return r_MContains_Object;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Array)
		/// </summary>
		protected RMethod r_MCopyTo_Array;
		public virtual RMethod RMCopyTo_Array
		{
			get
			{
				if(r_MCopyTo_Array == null)
				{
					r_MCopyTo_Array = new(this, "CopyTo", 0, typeof(System.Array));
					r_MCopyTo_Array.SetBelong(this.instance);
				}
				return r_MCopyTo_Array;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Array, Int32)
		/// </summary>
		protected RMethod r_MCopyTo_Array_Int32;
		public virtual RMethod RMCopyTo_Array_Int32
		{
			get
			{
				if(r_MCopyTo_Array_Int32 == null)
				{
					r_MCopyTo_Array_Int32 = new(this, "CopyTo", 0, typeof(System.Array), typeof(System.Int32));
					r_MCopyTo_Array_Int32.SetBelong(this.instance);
				}
				return r_MCopyTo_Array_Int32;
			}
		}

		/// <summary>
		/// Void CopyTo(Int32, System.Array, Int32, Int32)
		/// </summary>
		protected RMethod r_MCopyTo_Int32_Array_Int32_Int32;
		public virtual RMethod RMCopyTo_Int32_Array_Int32_Int32
		{
			get
			{
				if(r_MCopyTo_Int32_Array_Int32_Int32 == null)
				{
					r_MCopyTo_Int32_Array_Int32_Int32 = new(this, "CopyTo", 0, typeof(System.Int32), typeof(System.Array), typeof(System.Int32), typeof(System.Int32));
					r_MCopyTo_Int32_Array_Int32_Int32.SetBelong(this.instance);
				}
				return r_MCopyTo_Int32_Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void EnsureCapacity(Int32)
		/// </summary>
		protected RMethod r_MEnsureCapacity_Int32;
		public virtual RMethod RMEnsureCapacity_Int32
		{
			get
			{
				if(r_MEnsureCapacity_Int32 == null)
				{
					r_MEnsureCapacity_Int32 = new(this, "EnsureCapacity", 0, typeof(System.Int32));
					r_MEnsureCapacity_Int32.SetBelong(this.instance);
				}
				return r_MEnsureCapacity_Int32;
			}
		}

		/// <summary>
		/// System.Collections.IList FixedSize(System.Collections.IList)
		/// </summary>
		protected static RMethod r_MFixedSize_IList;
		public static RMethod RMFixedSize_IList
		{
			get
			{
				if(r_MFixedSize_IList == null)
				{
					r_MFixedSize_IList = new(typeof(System.Collections.ArrayList), "FixedSize", 0, typeof(System.Collections.IList));
					r_MFixedSize_IList.SetBelong(null);
				}
				return r_MFixedSize_IList;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList FixedSize(System.Collections.ArrayList)
		/// </summary>
		protected static RMethod r_MFixedSize_ArrayList;
		public static RMethod RMFixedSize_ArrayList
		{
			get
			{
				if(r_MFixedSize_ArrayList == null)
				{
					r_MFixedSize_ArrayList = new(typeof(System.Collections.ArrayList), "FixedSize", 0, typeof(System.Collections.ArrayList));
					r_MFixedSize_ArrayList.SetBelong(null);
				}
				return r_MFixedSize_ArrayList;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_MGetEnumerator;
		public virtual RMethod RMGetEnumerator
		{
			get
			{
				if(r_MGetEnumerator == null)
				{
					r_MGetEnumerator = new(this, "GetEnumerator", 0);
					r_MGetEnumerator.SetBelong(this.instance);
				}
				return r_MGetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumerator(Int32, Int32)
		/// </summary>
		protected RMethod r_MGetEnumerator_Int32_Int32;
		public virtual RMethod RMGetEnumerator_Int32_Int32
		{
			get
			{
				if(r_MGetEnumerator_Int32_Int32 == null)
				{
					r_MGetEnumerator_Int32_Int32 = new(this, "GetEnumerator", 0, typeof(System.Int32), typeof(System.Int32));
					r_MGetEnumerator_Int32_Int32.SetBelong(this.instance);
				}
				return r_MGetEnumerator_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.Object)
		/// </summary>
		protected RMethod r_MIndexOf_Object;
		public virtual RMethod RMIndexOf_Object
		{
			get
			{
				if(r_MIndexOf_Object == null)
				{
					r_MIndexOf_Object = new(this, "IndexOf", 0, typeof(System.Object));
					r_MIndexOf_Object.SetBelong(this.instance);
				}
				return r_MIndexOf_Object;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.Object, Int32)
		/// </summary>
		protected RMethod r_MIndexOf_Object_Int32;
		public virtual RMethod RMIndexOf_Object_Int32
		{
			get
			{
				if(r_MIndexOf_Object_Int32 == null)
				{
					r_MIndexOf_Object_Int32 = new(this, "IndexOf", 0, typeof(System.Object), typeof(System.Int32));
					r_MIndexOf_Object_Int32.SetBelong(this.instance);
				}
				return r_MIndexOf_Object_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.Object, Int32, Int32)
		/// </summary>
		protected RMethod r_MIndexOf_Object_Int32_Int32;
		public virtual RMethod RMIndexOf_Object_Int32_Int32
		{
			get
			{
				if(r_MIndexOf_Object_Int32_Int32 == null)
				{
					r_MIndexOf_Object_Int32_Int32 = new(this, "IndexOf", 0, typeof(System.Object), typeof(System.Int32), typeof(System.Int32));
					r_MIndexOf_Object_Int32_Int32.SetBelong(this.instance);
				}
				return r_MIndexOf_Object_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Insert(Int32, System.Object)
		/// </summary>
		protected RMethod r_MInsert_Int32_Object;
		public virtual RMethod RMInsert_Int32_Object
		{
			get
			{
				if(r_MInsert_Int32_Object == null)
				{
					r_MInsert_Int32_Object = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Object));
					r_MInsert_Int32_Object.SetBelong(this.instance);
				}
				return r_MInsert_Int32_Object;
			}
		}

		/// <summary>
		/// Void InsertRange(Int32, System.Collections.ICollection)
		/// </summary>
		protected RMethod r_MInsertRange_Int32_ICollection;
		public virtual RMethod RMInsertRange_Int32_ICollection
		{
			get
			{
				if(r_MInsertRange_Int32_ICollection == null)
				{
					r_MInsertRange_Int32_ICollection = new(this, "InsertRange", 0, typeof(System.Int32), typeof(System.Collections.ICollection));
					r_MInsertRange_Int32_ICollection.SetBelong(this.instance);
				}
				return r_MInsertRange_Int32_ICollection;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.Object)
		/// </summary>
		protected RMethod r_MLastIndexOf_Object;
		public virtual RMethod RMLastIndexOf_Object
		{
			get
			{
				if(r_MLastIndexOf_Object == null)
				{
					r_MLastIndexOf_Object = new(this, "LastIndexOf", 0, typeof(System.Object));
					r_MLastIndexOf_Object.SetBelong(this.instance);
				}
				return r_MLastIndexOf_Object;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.Object, Int32)
		/// </summary>
		protected RMethod r_MLastIndexOf_Object_Int32;
		public virtual RMethod RMLastIndexOf_Object_Int32
		{
			get
			{
				if(r_MLastIndexOf_Object_Int32 == null)
				{
					r_MLastIndexOf_Object_Int32 = new(this, "LastIndexOf", 0, typeof(System.Object), typeof(System.Int32));
					r_MLastIndexOf_Object_Int32.SetBelong(this.instance);
				}
				return r_MLastIndexOf_Object_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.Object, Int32, Int32)
		/// </summary>
		protected RMethod r_MLastIndexOf_Object_Int32_Int32;
		public virtual RMethod RMLastIndexOf_Object_Int32_Int32
		{
			get
			{
				if(r_MLastIndexOf_Object_Int32_Int32 == null)
				{
					r_MLastIndexOf_Object_Int32_Int32 = new(this, "LastIndexOf", 0, typeof(System.Object), typeof(System.Int32), typeof(System.Int32));
					r_MLastIndexOf_Object_Int32_Int32.SetBelong(this.instance);
				}
				return r_MLastIndexOf_Object_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Collections.IList ReadOnly(System.Collections.IList)
		/// </summary>
		protected static RMethod r_MReadOnly_IList;
		public static RMethod RMReadOnly_IList
		{
			get
			{
				if(r_MReadOnly_IList == null)
				{
					r_MReadOnly_IList = new(typeof(System.Collections.ArrayList), "ReadOnly", 0, typeof(System.Collections.IList));
					r_MReadOnly_IList.SetBelong(null);
				}
				return r_MReadOnly_IList;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList ReadOnly(System.Collections.ArrayList)
		/// </summary>
		protected static RMethod r_MReadOnly_ArrayList;
		public static RMethod RMReadOnly_ArrayList
		{
			get
			{
				if(r_MReadOnly_ArrayList == null)
				{
					r_MReadOnly_ArrayList = new(typeof(System.Collections.ArrayList), "ReadOnly", 0, typeof(System.Collections.ArrayList));
					r_MReadOnly_ArrayList.SetBelong(null);
				}
				return r_MReadOnly_ArrayList;
			}
		}

		/// <summary>
		/// Void Remove(System.Object)
		/// </summary>
		protected RMethod r_MRemove_Object;
		public virtual RMethod RMRemove_Object
		{
			get
			{
				if(r_MRemove_Object == null)
				{
					r_MRemove_Object = new(this, "Remove", 0, typeof(System.Object));
					r_MRemove_Object.SetBelong(this.instance);
				}
				return r_MRemove_Object;
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
					r_MRemoveAt_Int32.SetBelong(this.instance);
				}
				return r_MRemoveAt_Int32;
			}
		}

		/// <summary>
		/// Void RemoveRange(Int32, Int32)
		/// </summary>
		protected RMethod r_MRemoveRange_Int32_Int32;
		public virtual RMethod RMRemoveRange_Int32_Int32
		{
			get
			{
				if(r_MRemoveRange_Int32_Int32 == null)
				{
					r_MRemoveRange_Int32_Int32 = new(this, "RemoveRange", 0, typeof(System.Int32), typeof(System.Int32));
					r_MRemoveRange_Int32_Int32.SetBelong(this.instance);
				}
				return r_MRemoveRange_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList Repeat(System.Object, Int32)
		/// </summary>
		protected static RMethod r_MRepeat_Object_Int32;
		public static RMethod RMRepeat_Object_Int32
		{
			get
			{
				if(r_MRepeat_Object_Int32 == null)
				{
					r_MRepeat_Object_Int32 = new(typeof(System.Collections.ArrayList), "Repeat", 0, typeof(System.Object), typeof(System.Int32));
					r_MRepeat_Object_Int32.SetBelong(null);
				}
				return r_MRepeat_Object_Int32;
			}
		}

		/// <summary>
		/// Void Reverse()
		/// </summary>
		protected RMethod r_MReverse;
		public virtual RMethod RMReverse
		{
			get
			{
				if(r_MReverse == null)
				{
					r_MReverse = new(this, "Reverse", 0);
					r_MReverse.SetBelong(this.instance);
				}
				return r_MReverse;
			}
		}

		/// <summary>
		/// Void Reverse(Int32, Int32)
		/// </summary>
		protected RMethod r_MReverse_Int32_Int32;
		public virtual RMethod RMReverse_Int32_Int32
		{
			get
			{
				if(r_MReverse_Int32_Int32 == null)
				{
					r_MReverse_Int32_Int32 = new(this, "Reverse", 0, typeof(System.Int32), typeof(System.Int32));
					r_MReverse_Int32_Int32.SetBelong(this.instance);
				}
				return r_MReverse_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetRange(Int32, System.Collections.ICollection)
		/// </summary>
		protected RMethod r_MSetRange_Int32_ICollection;
		public virtual RMethod RMSetRange_Int32_ICollection
		{
			get
			{
				if(r_MSetRange_Int32_ICollection == null)
				{
					r_MSetRange_Int32_ICollection = new(this, "SetRange", 0, typeof(System.Int32), typeof(System.Collections.ICollection));
					r_MSetRange_Int32_ICollection.SetBelong(this.instance);
				}
				return r_MSetRange_Int32_ICollection;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList GetRange(Int32, Int32)
		/// </summary>
		protected RMethod r_MGetRange_Int32_Int32;
		public virtual RMethod RMGetRange_Int32_Int32
		{
			get
			{
				if(r_MGetRange_Int32_Int32 == null)
				{
					r_MGetRange_Int32_Int32 = new(this, "GetRange", 0, typeof(System.Int32), typeof(System.Int32));
					r_MGetRange_Int32_Int32.SetBelong(this.instance);
				}
				return r_MGetRange_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Sort()
		/// </summary>
		protected RMethod r_MSort;
		public virtual RMethod RMSort
		{
			get
			{
				if(r_MSort == null)
				{
					r_MSort = new(this, "Sort", 0);
					r_MSort.SetBelong(this.instance);
				}
				return r_MSort;
			}
		}

		/// <summary>
		/// Void Sort(System.Collections.IComparer)
		/// </summary>
		protected RMethod r_MSort_IComparer;
		public virtual RMethod RMSort_IComparer
		{
			get
			{
				if(r_MSort_IComparer == null)
				{
					r_MSort_IComparer = new(this, "Sort", 0, typeof(System.Collections.IComparer));
					r_MSort_IComparer.SetBelong(this.instance);
				}
				return r_MSort_IComparer;
			}
		}

		/// <summary>
		/// Void Sort(Int32, Int32, System.Collections.IComparer)
		/// </summary>
		protected RMethod r_MSort_Int32_Int32_IComparer;
		public virtual RMethod RMSort_Int32_Int32_IComparer
		{
			get
			{
				if(r_MSort_Int32_Int32_IComparer == null)
				{
					r_MSort_Int32_Int32_IComparer = new(this, "Sort", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Collections.IComparer));
					r_MSort_Int32_Int32_IComparer.SetBelong(this.instance);
				}
				return r_MSort_Int32_Int32_IComparer;
			}
		}

		/// <summary>
		/// System.Collections.IList Synchronized(System.Collections.IList)
		/// </summary>
		protected static RMethod r_MSynchronized_IList;
		public static RMethod RMSynchronized_IList
		{
			get
			{
				if(r_MSynchronized_IList == null)
				{
					r_MSynchronized_IList = new(typeof(System.Collections.ArrayList), "Synchronized", 0, typeof(System.Collections.IList));
					r_MSynchronized_IList.SetBelong(null);
				}
				return r_MSynchronized_IList;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList Synchronized(System.Collections.ArrayList)
		/// </summary>
		protected static RMethod r_MSynchronized_ArrayList;
		public static RMethod RMSynchronized_ArrayList
		{
			get
			{
				if(r_MSynchronized_ArrayList == null)
				{
					r_MSynchronized_ArrayList = new(typeof(System.Collections.ArrayList), "Synchronized", 0, typeof(System.Collections.ArrayList));
					r_MSynchronized_ArrayList.SetBelong(null);
				}
				return r_MSynchronized_ArrayList;
			}
		}

		/// <summary>
		/// System.Object[] ToArray()
		/// </summary>
		protected RMethod r_MToArray;
		public virtual RMethod RMToArray
		{
			get
			{
				if(r_MToArray == null)
				{
					r_MToArray = new(this, "ToArray", 0);
					r_MToArray.SetBelong(this.instance);
				}
				return r_MToArray;
			}
		}

		/// <summary>
		/// System.Array ToArray(System.Type)
		/// </summary>
		protected RMethod r_MToArray_Type;
		public virtual RMethod RMToArray_Type
		{
			get
			{
				if(r_MToArray_Type == null)
				{
					r_MToArray_Type = new(this, "ToArray", 0, typeof(System.Type));
					r_MToArray_Type.SetBelong(this.instance);
				}
				return r_MToArray_Type;
			}
		}

		/// <summary>
		/// Void TrimToSize()
		/// </summary>
		protected RMethod r_MTrimToSize;
		public virtual RMethod RMTrimToSize
		{
			get
			{
				if(r_MTrimToSize == null)
				{
					r_MTrimToSize = new(this, "TrimToSize", 0);
					r_MTrimToSize.SetBelong(this.instance);
				}
				return r_MTrimToSize;
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
            var ___result = RMAdapter_IList.Invoke(___genericsType, ___parameters);

            return (System.Collections.ArrayList)___result;
        }


        public virtual System.Int32 Add(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAdd_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void AddRange(System.Collections.ICollection @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMAddRange_ICollection.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 BinarySearch(System.Int32 @index, System.Int32 @count, System.Object @value, System.Collections.IComparer @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @count, @value, @comparer};
            var ___result = RMBinarySearch_Int32_Int32_Object_IComparer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 BinarySearch(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMBinarySearch_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 BinarySearch(System.Object @value, System.Collections.IComparer @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @comparer};
            var ___result = RMBinarySearch_Object_IComparer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean Contains(System.Object @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMContains_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CopyTo(System.Array @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array};
            var ___result = RMCopyTo_Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Array @array, System.Int32 @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RMCopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Int32 @index, System.Array @array, System.Int32 @arrayIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @array, @arrayIndex, @count};
            var ___result = RMCopyTo_Int32_Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnsureCapacity(System.Int32 @min)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@min};
            var ___result = RMEnsureCapacity_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Collections.IList FixedSize(System.Collections.IList @list)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list};
            var ___result = RMFixedSize_IList.Invoke(___genericsType, ___parameters);

            return (System.Collections.IList)___result;
        }


        public static System.Collections.ArrayList FixedSize(System.Collections.ArrayList @list)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list};
            var ___result = RMFixedSize_ArrayList.Invoke(___genericsType, ___parameters);

            return (System.Collections.ArrayList)___result;
        }


        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Collections.IEnumerator GetEnumerator(System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @count};
            var ___result = RMGetEnumerator_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Int32 IndexOf(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMIndexOf_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.Object @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex};
            var ___result = RMIndexOf_Object_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.Object @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RMIndexOf_Object_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Insert(System.Int32 @index, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RMInsert_Int32_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertRange(System.Int32 @index, System.Collections.ICollection @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @c};
            var ___result = RMInsertRange_Int32_ICollection.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 LastIndexOf(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMLastIndexOf_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.Object @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex};
            var ___result = RMLastIndexOf_Object_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.Object @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RMLastIndexOf_Object_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Collections.IList ReadOnly(System.Collections.IList @list)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list};
            var ___result = RMReadOnly_IList.Invoke(___genericsType, ___parameters);

            return (System.Collections.IList)___result;
        }


        public static System.Collections.ArrayList ReadOnly(System.Collections.ArrayList @list)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list};
            var ___result = RMReadOnly_ArrayList.Invoke(___genericsType, ___parameters);

            return (System.Collections.ArrayList)___result;
        }


        public virtual void Remove(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMRemove_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMRemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveRange(System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @count};
            var ___result = RMRemoveRange_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Collections.ArrayList Repeat(System.Object @value, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @count};
            var ___result = RMRepeat_Object_Int32.Invoke(___genericsType, ___parameters);

            return (System.Collections.ArrayList)___result;
        }


        public virtual void Reverse()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReverse.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reverse(System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @count};
            var ___result = RMReverse_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRange(System.Int32 @index, System.Collections.ICollection @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @c};
            var ___result = RMSetRange_Int32_ICollection.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.ArrayList GetRange(System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @count};
            var ___result = RMGetRange_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Collections.ArrayList)___result;
        }


        public virtual void Sort()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSort.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Sort(System.Collections.IComparer @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comparer};
            var ___result = RMSort_IComparer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Sort(System.Int32 @index, System.Int32 @count, System.Collections.IComparer @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @count, @comparer};
            var ___result = RMSort_Int32_Int32_IComparer.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Collections.IList Synchronized(System.Collections.IList @list)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list};
            var ___result = RMSynchronized_IList.Invoke(___genericsType, ___parameters);

            return (System.Collections.IList)___result;
        }


        public static System.Collections.ArrayList Synchronized(System.Collections.ArrayList @list)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list};
            var ___result = RMSynchronized_ArrayList.Invoke(___genericsType, ___parameters);

            return (System.Collections.ArrayList)___result;
        }


        public virtual System.Object[] ToArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToArray.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Array ToArray(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMToArray_Type.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public virtual void TrimToSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTrimToSize.Invoke(___genericsType, ___parameters);

            
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
