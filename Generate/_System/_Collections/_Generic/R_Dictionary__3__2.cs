
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
	/// System.Collections.Generic.Dictionary`2
	/// </summary>
    public partial class RDictionary<TKey, TValue> : RMember //
    {

		/// <summary>
		/// System.Int32[] _buckets
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_F_buckets;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RF_buckets
		{
			get
			{
				if(r_F_buckets == null)
				{
					r_F_buckets = new(this, "_buckets");
				}
				return r_F_buckets;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2+Entry[TKey,TValue][] _entries
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RField, Hvak.Editor.Refleaction.RField>.REntry> r_F_entries;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RField, Hvak.Editor.Refleaction.RField>.REntry> RF_entries
		{
			get
			{
				if(r_F_entries == null)
				{
					r_F_entries = new(this, "_entries");
				}
				return r_F_entries;
			}
		}

		/// <summary>
		/// System.Int32 _count
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_count;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_count
		{
			get
			{
				if(r_F_count == null)
				{
					r_F_count = new(this, "_count");
				}
				return r_F_count;
			}
		}

		/// <summary>
		/// System.Int32 _freeList
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_freeList;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_freeList
		{
			get
			{
				if(r_F_freeList == null)
				{
					r_F_freeList = new(this, "_freeList");
				}
				return r_F_freeList;
			}
		}

		/// <summary>
		/// System.Int32 _freeCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_freeCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_freeCount
		{
			get
			{
				if(r_F_freeCount == null)
				{
					r_F_freeCount = new(this, "_freeCount");
				}
				return r_F_freeCount;
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
				}
				return r_F_version;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEqualityComparer`1[TKey] _comparer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEqualityComparer<Hvak.Editor.Refleaction.RField> r_F_comparer;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEqualityComparer<Hvak.Editor.Refleaction.RField> RF_comparer
		{
			get
			{
				if(r_F_comparer == null)
				{
					r_F_comparer = new(this, "_comparer");
				}
				return r_F_comparer;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2+KeyCollection[TKey,TValue] _keys
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RField, Hvak.Editor.Refleaction.RField>.RKeyCollection r_F_keys;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RField, Hvak.Editor.Refleaction.RField>.RKeyCollection RF_keys
		{
			get
			{
				if(r_F_keys == null)
				{
					r_F_keys = new(this, "_keys");
				}
				return r_F_keys;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2+ValueCollection[TKey,TValue] _values
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RField, Hvak.Editor.Refleaction.RField>.RValueCollection r_F_values;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RField, Hvak.Editor.Refleaction.RField>.RValueCollection RF_values
		{
			get
			{
				if(r_F_values == null)
				{
					r_F_values = new(this, "_values");
				}
				return r_F_values;
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
				}
				return r_F_syncRoot;
			}
		}

		/// <summary>
		/// System.String VersionName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FVersionName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFVersionName
		{
			get
			{
				if(r_FVersionName == null)
				{
					r_FVersionName = new(typeof(System.Collections.Generic.Dictionary<, >), "VersionName");
				}
				return r_FVersionName;
			}
		}

		/// <summary>
		/// System.String HashSizeName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FHashSizeName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFHashSizeName
		{
			get
			{
				if(r_FHashSizeName == null)
				{
					r_FHashSizeName = new(typeof(System.Collections.Generic.Dictionary<, >), "HashSizeName");
				}
				return r_FHashSizeName;
			}
		}

		/// <summary>
		/// System.String KeyValuePairsName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FKeyValuePairsName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFKeyValuePairsName
		{
			get
			{
				if(r_FKeyValuePairsName == null)
				{
					r_FKeyValuePairsName = new(typeof(System.Collections.Generic.Dictionary<, >), "KeyValuePairsName");
				}
				return r_FKeyValuePairsName;
			}
		}

		/// <summary>
		/// System.String ComparerName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FComparerName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFComparerName
		{
			get
			{
				if(r_FComparerName == null)
				{
					r_FComparerName = new(typeof(System.Collections.Generic.Dictionary<, >), "ComparerName");
				}
				return r_FComparerName;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEqualityComparer`1[TKey] Comparer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEqualityComparer<Hvak.Editor.Refleaction.RProperty> r_PComparer;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEqualityComparer<Hvak.Editor.Refleaction.RProperty> RPComparer
		{
			get
			{
				if(r_PComparer == null)
				{
					r_PComparer = new(this, "Comparer", -1);
				}
				return r_PComparer;
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
				}
				return r_PCount;
			}
		}

		/// <summary>
		/// KeyCollection Keys
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RProperty, Hvak.Editor.Refleaction.RProperty>.RKeyCollection r_PKeys;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RProperty, Hvak.Editor.Refleaction.RProperty>.RKeyCollection RPKeys
		{
			get
			{
				if(r_PKeys == null)
				{
					r_PKeys = new(this, "Keys", -1);
				}
				return r_PKeys;
			}
		}

		/// <summary>
		/// System.Collections.Generic.ICollection`1[TKey] System.Collections.Generic.IDictionary<TKey,TValue>.Keys
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RICollection<Hvak.Editor.Refleaction.RProperty> r_PSystem__2__Collections__2__Generic__2__IDictionary__0__TKey__4__TValue__1____2__Keys;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RICollection<Hvak.Editor.Refleaction.RProperty> RPSystem__2__Collections__2__Generic__2__IDictionary__0__TKey__4__TValue__1____2__Keys
		{
			get
			{
				if(r_PSystem__2__Collections__2__Generic__2__IDictionary__0__TKey__4__TValue__1____2__Keys == null)
				{
					r_PSystem__2__Collections__2__Generic__2__IDictionary__0__TKey__4__TValue__1____2__Keys = new(this, "System.Collections.Generic.IDictionary<TKey,TValue>.Keys", -1);
				}
				return r_PSystem__2__Collections__2__Generic__2__IDictionary__0__TKey__4__TValue__1____2__Keys;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[TKey] System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RProperty> r_PSystem__2__Collections__2__Generic__2__IReadOnlyDictionary__0__TKey__4__TValue__1____2__Keys;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RProperty> RPSystem__2__Collections__2__Generic__2__IReadOnlyDictionary__0__TKey__4__TValue__1____2__Keys
		{
			get
			{
				if(r_PSystem__2__Collections__2__Generic__2__IReadOnlyDictionary__0__TKey__4__TValue__1____2__Keys == null)
				{
					r_PSystem__2__Collections__2__Generic__2__IReadOnlyDictionary__0__TKey__4__TValue__1____2__Keys = new(this, "System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys", -1);
				}
				return r_PSystem__2__Collections__2__Generic__2__IReadOnlyDictionary__0__TKey__4__TValue__1____2__Keys;
			}
		}

		/// <summary>
		/// ValueCollection Values
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RProperty, Hvak.Editor.Refleaction.RProperty>.RValueCollection r_PValues;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RProperty, Hvak.Editor.Refleaction.RProperty>.RValueCollection RPValues
		{
			get
			{
				if(r_PValues == null)
				{
					r_PValues = new(this, "Values", -1);
				}
				return r_PValues;
			}
		}

		/// <summary>
		/// System.Collections.Generic.ICollection`1[TValue] System.Collections.Generic.IDictionary<TKey,TValue>.Values
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RICollection<Hvak.Editor.Refleaction.RProperty> r_PSystem__2__Collections__2__Generic__2__IDictionary__0__TKey__4__TValue__1____2__Values;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RICollection<Hvak.Editor.Refleaction.RProperty> RPSystem__2__Collections__2__Generic__2__IDictionary__0__TKey__4__TValue__1____2__Values
		{
			get
			{
				if(r_PSystem__2__Collections__2__Generic__2__IDictionary__0__TKey__4__TValue__1____2__Values == null)
				{
					r_PSystem__2__Collections__2__Generic__2__IDictionary__0__TKey__4__TValue__1____2__Values = new(this, "System.Collections.Generic.IDictionary<TKey,TValue>.Values", -1);
				}
				return r_PSystem__2__Collections__2__Generic__2__IDictionary__0__TKey__4__TValue__1____2__Values;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[TValue] System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RProperty> r_PSystem__2__Collections__2__Generic__2__IReadOnlyDictionary__0__TKey__4__TValue__1____2__Values;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RProperty> RPSystem__2__Collections__2__Generic__2__IReadOnlyDictionary__0__TKey__4__TValue__1____2__Values
		{
			get
			{
				if(r_PSystem__2__Collections__2__Generic__2__IReadOnlyDictionary__0__TKey__4__TValue__1____2__Values == null)
				{
					r_PSystem__2__Collections__2__Generic__2__IReadOnlyDictionary__0__TKey__4__TValue__1____2__Values = new(this, "System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values", -1);
				}
				return r_PSystem__2__Collections__2__Generic__2__IReadOnlyDictionary__0__TKey__4__TValue__1____2__Values;
			}
		}

		/// <summary>
		/// TValue Item [TKey]
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_PItem_TKey;
		public virtual Hvak.Editor.Refleaction.RProperty RPItem_TKey
		{
			get
			{
				if(r_PItem_TKey == null)
				{
					r_PItem_TKey = new(this, "Item", -1, Type.MakeGenericMethodParameter(0));
				}
				return r_PItem_TKey;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__IsReadOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__IsReadOnly
		{
			get
			{
				if(r_PSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__IsReadOnly == null)
				{
					r_PSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__IsReadOnly = new(this, "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly", -1);
				}
				return r_PSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__IsReadOnly;
			}
		}

		/// <summary>
		/// Boolean System.Collections.ICollection.IsSynchronized
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PSystem__2__Collections__2__ICollection__2__IsSynchronized;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPSystem__2__Collections__2__ICollection__2__IsSynchronized
		{
			get
			{
				if(r_PSystem__2__Collections__2__ICollection__2__IsSynchronized == null)
				{
					r_PSystem__2__Collections__2__ICollection__2__IsSynchronized = new(this, "System.Collections.ICollection.IsSynchronized", -1);
				}
				return r_PSystem__2__Collections__2__ICollection__2__IsSynchronized;
			}
		}

		/// <summary>
		/// System.Object System.Collections.ICollection.SyncRoot
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PSystem__2__Collections__2__ICollection__2__SyncRoot;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPSystem__2__Collections__2__ICollection__2__SyncRoot
		{
			get
			{
				if(r_PSystem__2__Collections__2__ICollection__2__SyncRoot == null)
				{
					r_PSystem__2__Collections__2__ICollection__2__SyncRoot = new(this, "System.Collections.ICollection.SyncRoot", -1);
				}
				return r_PSystem__2__Collections__2__ICollection__2__SyncRoot;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IDictionary.IsFixedSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PSystem__2__Collections__2__IDictionary__2__IsFixedSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPSystem__2__Collections__2__IDictionary__2__IsFixedSize
		{
			get
			{
				if(r_PSystem__2__Collections__2__IDictionary__2__IsFixedSize == null)
				{
					r_PSystem__2__Collections__2__IDictionary__2__IsFixedSize = new(this, "System.Collections.IDictionary.IsFixedSize", -1);
				}
				return r_PSystem__2__Collections__2__IDictionary__2__IsFixedSize;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IDictionary.IsReadOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PSystem__2__Collections__2__IDictionary__2__IsReadOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPSystem__2__Collections__2__IDictionary__2__IsReadOnly
		{
			get
			{
				if(r_PSystem__2__Collections__2__IDictionary__2__IsReadOnly == null)
				{
					r_PSystem__2__Collections__2__IDictionary__2__IsReadOnly = new(this, "System.Collections.IDictionary.IsReadOnly", -1);
				}
				return r_PSystem__2__Collections__2__IDictionary__2__IsReadOnly;
			}
		}

		/// <summary>
		/// System.Collections.ICollection System.Collections.IDictionary.Keys
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RICollection r_PSystem__2__Collections__2__IDictionary__2__Keys;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RICollection RPSystem__2__Collections__2__IDictionary__2__Keys
		{
			get
			{
				if(r_PSystem__2__Collections__2__IDictionary__2__Keys == null)
				{
					r_PSystem__2__Collections__2__IDictionary__2__Keys = new(this, "System.Collections.IDictionary.Keys", -1);
				}
				return r_PSystem__2__Collections__2__IDictionary__2__Keys;
			}
		}

		/// <summary>
		/// System.Collections.ICollection System.Collections.IDictionary.Values
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RICollection r_PSystem__2__Collections__2__IDictionary__2__Values;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RICollection RPSystem__2__Collections__2__IDictionary__2__Values
		{
			get
			{
				if(r_PSystem__2__Collections__2__IDictionary__2__Values == null)
				{
					r_PSystem__2__Collections__2__IDictionary__2__Values = new(this, "System.Collections.IDictionary.Values", -1);
				}
				return r_PSystem__2__Collections__2__IDictionary__2__Values;
			}
		}

		/// <summary>
		/// System.Object System.Collections.IDictionary.Item [System.Object]
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PSystem__2__Collections__2__IDictionary__2__Item_Object;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPSystem__2__Collections__2__IDictionary__2__Item_Object
		{
			get
			{
				if(r_PSystem__2__Collections__2__IDictionary__2__Item_Object == null)
				{
					r_PSystem__2__Collections__2__IDictionary__2__Item_Object = new(this, "System.Collections.IDictionary.Item", -1, typeof(System.Object));
				}
				return r_PSystem__2__Collections__2__IDictionary__2__Item_Object;
			}
		}

		/// <summary>
		/// Void Add(TKey, TValue)
		/// </summary>
		protected RMethod r_MAdd_TKey_TValue;
		public virtual RMethod RMAdd_TKey_TValue
		{
			get
			{
				if(r_MAdd_TKey_TValue == null)
				{
					r_MAdd_TKey_TValue = new(this, "Add", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1));
				}
				return r_MAdd_TKey_TValue;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair`2[TKey,TValue])
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__Add_KeyValuePair_d_TKey_TValue_p_;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__Add_KeyValuePair_d_TKey_TValue_p_
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__Add_KeyValuePair_d_TKey_TValue_p_ == null)
				{
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__Add_KeyValuePair_d_TKey_TValue_p_ = new(this, "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add", 0, typeof(System.Collections.Generic.KeyValuePair<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)));
				}
				return r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__Add_KeyValuePair_d_TKey_TValue_p_;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair`2[TKey,TValue])
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__Contains_KeyValuePair_d_TKey_TValue_p_;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__Contains_KeyValuePair_d_TKey_TValue_p_
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__Contains_KeyValuePair_d_TKey_TValue_p_ == null)
				{
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__Contains_KeyValuePair_d_TKey_TValue_p_ = new(this, "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains", 0, typeof(System.Collections.Generic.KeyValuePair<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)));
				}
				return r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__Contains_KeyValuePair_d_TKey_TValue_p_;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair`2[TKey,TValue])
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__Remove_KeyValuePair_d_TKey_TValue_p_;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__Remove_KeyValuePair_d_TKey_TValue_p_
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__Remove_KeyValuePair_d_TKey_TValue_p_ == null)
				{
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__Remove_KeyValuePair_d_TKey_TValue_p_ = new(this, "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove", 0, typeof(System.Collections.Generic.KeyValuePair<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)));
				}
				return r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__Remove_KeyValuePair_d_TKey_TValue_p_;
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
		/// Boolean ContainsKey(TKey)
		/// </summary>
		protected RMethod r_MContainsKey_TKey;
		public virtual RMethod RMContainsKey_TKey
		{
			get
			{
				if(r_MContainsKey_TKey == null)
				{
					r_MContainsKey_TKey = new(this, "ContainsKey", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MContainsKey_TKey;
			}
		}

		/// <summary>
		/// Boolean ContainsValue(TValue)
		/// </summary>
		protected RMethod r_MContainsValue_TValue;
		public virtual RMethod RMContainsValue_TValue
		{
			get
			{
				if(r_MContainsValue_TValue == null)
				{
					r_MContainsValue_TValue = new(this, "ContainsValue", 0, Type.MakeGenericMethodParameter(1));
				}
				return r_MContainsValue_TValue;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Collections.Generic.KeyValuePair`2[TKey,TValue][], Int32)
		/// </summary>
		protected RMethod r_MCopyTo_KeyValuePair_d_TKey_TValue_p_Array_Int32;
		public virtual RMethod RMCopyTo_KeyValuePair_d_TKey_TValue_p_Array_Int32
		{
			get
			{
				if(r_MCopyTo_KeyValuePair_d_TKey_TValue_p_Array_Int32 == null)
				{
					r_MCopyTo_KeyValuePair_d_TKey_TValue_p_Array_Int32 = new(this, "CopyTo", 0, typeof(System.Collections.Generic.KeyValuePair<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)).MakeArrayType(), typeof(System.Int32));
				}
				return r_MCopyTo_KeyValuePair_d_TKey_TValue_p_Array_Int32;
			}
		}

		/// <summary>
		/// Enumerator GetEnumerator()
		/// </summary>
		protected RMethod r_MGetEnumerator;
		public virtual RMethod RMGetEnumerator
		{
			get
			{
				if(r_MGetEnumerator == null)
				{
					r_MGetEnumerator = new(this, "GetEnumerator", 0);
				}
				return r_MGetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[TKey,TValue]] System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__GetEnumerator;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__GetEnumerator
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__GetEnumerator == null)
				{
					r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__GetEnumerator = new(this, "System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator", 0);
				}
				return r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__GetEnumerator;
			}
		}

		/// <summary>
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MGetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RMGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_MGetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_MGetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
				}
				return r_MGetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Int32 FindEntry(TKey)
		/// </summary>
		protected RMethod r_MFindEntry_TKey;
		public virtual RMethod RMFindEntry_TKey
		{
			get
			{
				if(r_MFindEntry_TKey == null)
				{
					r_MFindEntry_TKey = new(this, "FindEntry", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MFindEntry_TKey;
			}
		}

		/// <summary>
		/// Int32 Initialize(Int32)
		/// </summary>
		protected RMethod r_MInitialize_Int32;
		public virtual RMethod RMInitialize_Int32
		{
			get
			{
				if(r_MInitialize_Int32 == null)
				{
					r_MInitialize_Int32 = new(this, "Initialize", 0, typeof(System.Int32));
				}
				return r_MInitialize_Int32;
			}
		}

		/// <summary>
		/// Boolean TryInsert(TKey, TValue, System.Collections.Generic.InsertionBehavior)
		/// </summary>
		protected RMethod r_MTryInsert_TKey_TValue_InsertionBehavior;
		public virtual RMethod RMTryInsert_TKey_TValue_InsertionBehavior
		{
			get
			{
				if(r_MTryInsert_TKey_TValue_InsertionBehavior == null)
				{
					r_MTryInsert_TKey_TValue_InsertionBehavior = new(this, "TryInsert", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1),  ReflectionUtils.GetType("System.Collections.Generic.InsertionBehavior"));
				}
				return r_MTryInsert_TKey_TValue_InsertionBehavior;
			}
		}

		/// <summary>
		/// Void OnDeserialization(System.Object)
		/// </summary>
		protected RMethod r_MOnDeserialization_Object;
		public virtual RMethod RMOnDeserialization_Object
		{
			get
			{
				if(r_MOnDeserialization_Object == null)
				{
					r_MOnDeserialization_Object = new(this, "OnDeserialization", 0, typeof(System.Object));
				}
				return r_MOnDeserialization_Object;
			}
		}

		/// <summary>
		/// Void Resize()
		/// </summary>
		protected RMethod r_MResize;
		public virtual RMethod RMResize
		{
			get
			{
				if(r_MResize == null)
				{
					r_MResize = new(this, "Resize", 0);
				}
				return r_MResize;
			}
		}

		/// <summary>
		/// Void Resize(Int32, Boolean)
		/// </summary>
		protected RMethod r_MResize_Int32_Boolean;
		public virtual RMethod RMResize_Int32_Boolean
		{
			get
			{
				if(r_MResize_Int32_Boolean == null)
				{
					r_MResize_Int32_Boolean = new(this, "Resize", 0, typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MResize_Int32_Boolean;
			}
		}

		/// <summary>
		/// Boolean Remove(TKey)
		/// </summary>
		protected RMethod r_MRemove_TKey;
		public virtual RMethod RMRemove_TKey
		{
			get
			{
				if(r_MRemove_TKey == null)
				{
					r_MRemove_TKey = new(this, "Remove", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MRemove_TKey;
			}
		}

		/// <summary>
		/// Boolean Remove(TKey, TValue ByRef)
		/// </summary>
		protected RMethod r_MRemove_TKey_Out_TValue;
		public virtual RMethod RMRemove_TKey_Out_TValue
		{
			get
			{
				if(r_MRemove_TKey_Out_TValue == null)
				{
					r_MRemove_TKey_Out_TValue = new(this, "Remove", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1).MakeByRefType());
				}
				return r_MRemove_TKey_Out_TValue;
			}
		}

		/// <summary>
		/// Boolean TryGetValue(TKey, TValue ByRef)
		/// </summary>
		protected RMethod r_MTryGetValue_TKey_Out_TValue;
		public virtual RMethod RMTryGetValue_TKey_Out_TValue
		{
			get
			{
				if(r_MTryGetValue_TKey_Out_TValue == null)
				{
					r_MTryGetValue_TKey_Out_TValue = new(this, "TryGetValue", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1).MakeByRefType());
				}
				return r_MTryGetValue_TKey_Out_TValue;
			}
		}

		/// <summary>
		/// Boolean TryAdd(TKey, TValue)
		/// </summary>
		protected RMethod r_MTryAdd_TKey_TValue;
		public virtual RMethod RMTryAdd_TKey_TValue
		{
			get
			{
				if(r_MTryAdd_TKey_TValue == null)
				{
					r_MTryAdd_TKey_TValue = new(this, "TryAdd", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1));
				}
				return r_MTryAdd_TKey_TValue;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair`2[TKey,TValue][], Int32)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__CopyTo_KeyValuePair_d_TKey_TValue_p_Array_Int32;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__CopyTo_KeyValuePair_d_TKey_TValue_p_Array_Int32
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__CopyTo_KeyValuePair_d_TKey_TValue_p_Array_Int32 == null)
				{
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__CopyTo_KeyValuePair_d_TKey_TValue_p_Array_Int32 = new(this, "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo", 0, typeof(System.Collections.Generic.KeyValuePair<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)).MakeArrayType(), typeof(System.Int32));
				}
				return r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__CopyTo_KeyValuePair_d_TKey_TValue_p_Array_Int32;
			}
		}

		/// <summary>
		/// Void System.Collections.ICollection.CopyTo(System.Array, Int32)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__ICollection__2__CopyTo_Array_Int32;
		public virtual RMethod RMSystem__2__Collections__2__ICollection__2__CopyTo_Array_Int32
		{
			get
			{
				if(r_MSystem__2__Collections__2__ICollection__2__CopyTo_Array_Int32 == null)
				{
					r_MSystem__2__Collections__2__ICollection__2__CopyTo_Array_Int32 = new(this, "System.Collections.ICollection.CopyTo", 0, typeof(System.Array), typeof(System.Int32));
				}
				return r_MSystem__2__Collections__2__ICollection__2__CopyTo_Array_Int32;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator;
		public virtual RMethod RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator
		{
			get
			{
				if(r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator == null)
				{
					r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator = new(this, "System.Collections.IEnumerable.GetEnumerator", 0);
				}
				return r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator;
			}
		}

		/// <summary>
		/// Int32 EnsureCapacity(Int32)
		/// </summary>
		protected RMethod r_MEnsureCapacity_Int32;
		public virtual RMethod RMEnsureCapacity_Int32
		{
			get
			{
				if(r_MEnsureCapacity_Int32 == null)
				{
					r_MEnsureCapacity_Int32 = new(this, "EnsureCapacity", 0, typeof(System.Int32));
				}
				return r_MEnsureCapacity_Int32;
			}
		}

		/// <summary>
		/// Void TrimExcess()
		/// </summary>
		protected RMethod r_MTrimExcess;
		public virtual RMethod RMTrimExcess
		{
			get
			{
				if(r_MTrimExcess == null)
				{
					r_MTrimExcess = new(this, "TrimExcess", 0);
				}
				return r_MTrimExcess;
			}
		}

		/// <summary>
		/// Void TrimExcess(Int32)
		/// </summary>
		protected RMethod r_MTrimExcess_Int32;
		public virtual RMethod RMTrimExcess_Int32
		{
			get
			{
				if(r_MTrimExcess_Int32 == null)
				{
					r_MTrimExcess_Int32 = new(this, "TrimExcess", 0, typeof(System.Int32));
				}
				return r_MTrimExcess_Int32;
			}
		}

		/// <summary>
		/// Boolean IsCompatibleKey(System.Object)
		/// </summary>
		protected static RMethod r_MIsCompatibleKey_Object;
		public static RMethod RMIsCompatibleKey_Object
		{
			get
			{
				if(r_MIsCompatibleKey_Object == null)
				{
					r_MIsCompatibleKey_Object = new(typeof(System.Collections.Generic.Dictionary<, >), "IsCompatibleKey", 0, typeof(System.Object));
				}
				return r_MIsCompatibleKey_Object;
			}
		}

		/// <summary>
		/// Void System.Collections.IDictionary.Add(System.Object, System.Object)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IDictionary__2__Add_Object_Object;
		public virtual RMethod RMSystem__2__Collections__2__IDictionary__2__Add_Object_Object
		{
			get
			{
				if(r_MSystem__2__Collections__2__IDictionary__2__Add_Object_Object == null)
				{
					r_MSystem__2__Collections__2__IDictionary__2__Add_Object_Object = new(this, "System.Collections.IDictionary.Add", 0, typeof(System.Object), typeof(System.Object));
				}
				return r_MSystem__2__Collections__2__IDictionary__2__Add_Object_Object;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IDictionary.Contains(System.Object)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IDictionary__2__Contains_Object;
		public virtual RMethod RMSystem__2__Collections__2__IDictionary__2__Contains_Object
		{
			get
			{
				if(r_MSystem__2__Collections__2__IDictionary__2__Contains_Object == null)
				{
					r_MSystem__2__Collections__2__IDictionary__2__Contains_Object = new(this, "System.Collections.IDictionary.Contains", 0, typeof(System.Object));
				}
				return r_MSystem__2__Collections__2__IDictionary__2__Contains_Object;
			}
		}

		/// <summary>
		/// System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IDictionary__2__GetEnumerator;
		public virtual RMethod RMSystem__2__Collections__2__IDictionary__2__GetEnumerator
		{
			get
			{
				if(r_MSystem__2__Collections__2__IDictionary__2__GetEnumerator == null)
				{
					r_MSystem__2__Collections__2__IDictionary__2__GetEnumerator = new(this, "System.Collections.IDictionary.GetEnumerator", 0);
				}
				return r_MSystem__2__Collections__2__IDictionary__2__GetEnumerator;
			}
		}

		/// <summary>
		/// Void System.Collections.IDictionary.Remove(System.Object)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IDictionary__2__Remove_Object;
		public virtual RMethod RMSystem__2__Collections__2__IDictionary__2__Remove_Object
		{
			get
			{
				if(r_MSystem__2__Collections__2__IDictionary__2__Remove_Object == null)
				{
					r_MSystem__2__Collections__2__IDictionary__2__Remove_Object = new(this, "System.Collections.IDictionary.Remove", 0, typeof(System.Object));
				}
				return r_MSystem__2__Collections__2__IDictionary__2__Remove_Object;
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


        public RDictionary() : base("System.Collections.Generic.Dictionary`2")
        {
        }

        public RDictionary(System.Object instance) : base("System.Collections.Generic.Dictionary`2")
		{
            SetInstance(instance);
		}

        public RDictionary(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDictionary(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Add(TKey @key, TValue @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RMAdd_TKey_TValue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__Add(System.Collections.Generic.KeyValuePair<TKey, TValue> @keyValuePair)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyValuePair};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__Add_KeyValuePair_d_TKey_TValue_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean System__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> @keyValuePair)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyValuePair};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__Contains_KeyValuePair_d_TKey_TValue_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean System__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> @keyValuePair)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyValuePair};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__Remove_KeyValuePair_d_TKey_TValue_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ContainsKey(TKey @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMContainsKey_TKey.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ContainsValue(TValue @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMContainsValue_TValue.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue>[] @array, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RMCopyTo_KeyValuePair_d_TKey_TValue_p_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RType, Hvak.Editor.Refleaction.RType>.REnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RType, Hvak.Editor.Refleaction.RType>.REnumerator(___result);
        }


        public virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System__2__Collections__2__Generic__2__IEnumerable__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>)___result;
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 FindEntry(TKey @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMFindEntry_TKey.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Initialize(System.Int32 @capacity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@capacity};
            var ___result = RMInitialize_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean TryInsert(TKey @key, TValue @value, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RInsertionBehavior @behavior)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value, @behavior.Value};
            var ___result = RMTryInsert_TKey_TValue_InsertionBehavior.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnDeserialization(System.Object @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = RMOnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Resize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Resize(System.Int32 @newSize, System.Boolean @forceNewHashCodes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newSize, @forceNewHashCodes};
            var ___result = RMResize_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Remove(TKey @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMRemove_TKey.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Remove(TKey @key, out TValue @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RMRemove_TKey_Out_TValue.Invoke(___genericsType, ___parameters);
			@value = (TValue)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetValue(TKey @key, out TValue @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RMTryGetValue_TKey_Out_TValue.Invoke(___genericsType, ___parameters);
			@value = (TValue)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryAdd(TKey @key, TValue @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RMTryAdd_TKey_TValue.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void System__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue>[] @array, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__CopyTo_KeyValuePair_d_TKey_TValue_p_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__ICollection__2__CopyTo(System.Array @array, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RMSystem__2__Collections__2__ICollection__2__CopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator System__2__Collections__2__IEnumerable__2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Int32 EnsureCapacity(System.Int32 @capacity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@capacity};
            var ___result = RMEnsureCapacity_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void TrimExcess()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTrimExcess.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TrimExcess(System.Int32 @capacity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@capacity};
            var ___result = RMTrimExcess_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsCompatibleKey(System.Object @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMIsCompatibleKey_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void System__2__Collections__2__IDictionary__2__Add(System.Object @key, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RMSystem__2__Collections__2__IDictionary__2__Add_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean System__2__Collections__2__IDictionary__2__Contains(System.Object @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMSystem__2__Collections__2__IDictionary__2__Contains_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.IDictionaryEnumerator System__2__Collections__2__IDictionary__2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__IDictionary__2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IDictionaryEnumerator)___result;
        }


        public virtual void System__2__Collections__2__IDictionary__2__Remove(System.Object @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMSystem__2__Collections__2__IDictionary__2__Remove_Object.Invoke(___genericsType, ___parameters);

            
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
