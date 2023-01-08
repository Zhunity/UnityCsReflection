using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections
{
	/// <summary>
	/// System.Collections.Hashtable
	/// </summary>
    public partial class RHashtable : RMember //
    {

		/// <summary>
		/// System.Int32 HashPrime
		/// </summary>
		protected static RField r_HashPrime;
		public static RField RHashPrime
		{
			get
			{
				if(r_HashPrime == null)
				{
					r_HashPrime = new(typeof(System.Collections.Hashtable), "HashPrime");
					r_HashPrime.SetBelong(null);
				}
				return r_HashPrime;
			}
		}

		/// <summary>
		/// System.Int32 InitialSize
		/// </summary>
		protected static RField r_InitialSize;
		public static RField RInitialSize
		{
			get
			{
				if(r_InitialSize == null)
				{
					r_InitialSize = new(typeof(System.Collections.Hashtable), "InitialSize");
					r_InitialSize.SetBelong(null);
				}
				return r_InitialSize;
			}
		}

		/// <summary>
		/// System.String LoadFactorName
		/// </summary>
		protected static RField r_LoadFactorName;
		public static RField RLoadFactorName
		{
			get
			{
				if(r_LoadFactorName == null)
				{
					r_LoadFactorName = new(typeof(System.Collections.Hashtable), "LoadFactorName");
					r_LoadFactorName.SetBelong(null);
				}
				return r_LoadFactorName;
			}
		}

		/// <summary>
		/// System.String VersionName
		/// </summary>
		protected static RField r_VersionName;
		public static RField RVersionName
		{
			get
			{
				if(r_VersionName == null)
				{
					r_VersionName = new(typeof(System.Collections.Hashtable), "VersionName");
					r_VersionName.SetBelong(null);
				}
				return r_VersionName;
			}
		}

		/// <summary>
		/// System.String ComparerName
		/// </summary>
		protected static RField r_ComparerName;
		public static RField RComparerName
		{
			get
			{
				if(r_ComparerName == null)
				{
					r_ComparerName = new(typeof(System.Collections.Hashtable), "ComparerName");
					r_ComparerName.SetBelong(null);
				}
				return r_ComparerName;
			}
		}

		/// <summary>
		/// System.String HashCodeProviderName
		/// </summary>
		protected static RField r_HashCodeProviderName;
		public static RField RHashCodeProviderName
		{
			get
			{
				if(r_HashCodeProviderName == null)
				{
					r_HashCodeProviderName = new(typeof(System.Collections.Hashtable), "HashCodeProviderName");
					r_HashCodeProviderName.SetBelong(null);
				}
				return r_HashCodeProviderName;
			}
		}

		/// <summary>
		/// System.String HashSizeName
		/// </summary>
		protected static RField r_HashSizeName;
		public static RField RHashSizeName
		{
			get
			{
				if(r_HashSizeName == null)
				{
					r_HashSizeName = new(typeof(System.Collections.Hashtable), "HashSizeName");
					r_HashSizeName.SetBelong(null);
				}
				return r_HashSizeName;
			}
		}

		/// <summary>
		/// System.String KeysName
		/// </summary>
		protected static RField r_KeysName;
		public static RField RKeysName
		{
			get
			{
				if(r_KeysName == null)
				{
					r_KeysName = new(typeof(System.Collections.Hashtable), "KeysName");
					r_KeysName.SetBelong(null);
				}
				return r_KeysName;
			}
		}

		/// <summary>
		/// System.String ValuesName
		/// </summary>
		protected static RField r_ValuesName;
		public static RField RValuesName
		{
			get
			{
				if(r_ValuesName == null)
				{
					r_ValuesName = new(typeof(System.Collections.Hashtable), "ValuesName");
					r_ValuesName.SetBelong(null);
				}
				return r_ValuesName;
			}
		}

		/// <summary>
		/// System.String KeyComparerName
		/// </summary>
		protected static RField r_KeyComparerName;
		public static RField RKeyComparerName
		{
			get
			{
				if(r_KeyComparerName == null)
				{
					r_KeyComparerName = new(typeof(System.Collections.Hashtable), "KeyComparerName");
					r_KeyComparerName.SetBelong(null);
				}
				return r_KeyComparerName;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable+bucket[] _buckets
		/// </summary>
		protected RFieldArray<RSystem.RCollections.RHashtable.Rbucket> r__buckets;
		public virtual RFieldArray<RSystem.RCollections.RHashtable.Rbucket> R_buckets
		{
			get
			{
				if(r__buckets == null)
				{
					r__buckets = new(this, "_buckets");
					r__buckets.SetBelong(this.instance);
				}
				return r__buckets;
			}
		}

		/// <summary>
		/// System.Int32 _count
		/// </summary>
		protected RField r__count;
		public virtual RField R_count
		{
			get
			{
				if(r__count == null)
				{
					r__count = new(this, "_count");
					r__count.SetBelong(this.instance);
				}
				return r__count;
			}
		}

		/// <summary>
		/// System.Int32 _occupancy
		/// </summary>
		protected RField r__occupancy;
		public virtual RField R_occupancy
		{
			get
			{
				if(r__occupancy == null)
				{
					r__occupancy = new(this, "_occupancy");
					r__occupancy.SetBelong(this.instance);
				}
				return r__occupancy;
			}
		}

		/// <summary>
		/// System.Int32 _loadsize
		/// </summary>
		protected RField r__loadsize;
		public virtual RField R_loadsize
		{
			get
			{
				if(r__loadsize == null)
				{
					r__loadsize = new(this, "_loadsize");
					r__loadsize.SetBelong(this.instance);
				}
				return r__loadsize;
			}
		}

		/// <summary>
		/// System.Single _loadFactor
		/// </summary>
		protected RField r__loadFactor;
		public virtual RField R_loadFactor
		{
			get
			{
				if(r__loadFactor == null)
				{
					r__loadFactor = new(this, "_loadFactor");
					r__loadFactor.SetBelong(this.instance);
				}
				return r__loadFactor;
			}
		}

		/// <summary>
		/// System.Int32 _version
		/// </summary>
		protected RField r__version;
		public virtual RField R_version
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
		/// System.Boolean _isWriterInProgress
		/// </summary>
		protected RField r__isWriterInProgress;
		public virtual RField R_isWriterInProgress
		{
			get
			{
				if(r__isWriterInProgress == null)
				{
					r__isWriterInProgress = new(this, "_isWriterInProgress");
					r__isWriterInProgress.SetBelong(this.instance);
				}
				return r__isWriterInProgress;
			}
		}

		/// <summary>
		/// System.Collections.ICollection _keys
		/// </summary>
		protected RSystem.RCollections.RICollection r__keys;
		public virtual RSystem.RCollections.RICollection R_keys
		{
			get
			{
				if(r__keys == null)
				{
					r__keys = new(this, "_keys");
					r__keys.SetBelong(this.instance);
				}
				return r__keys;
			}
		}

		/// <summary>
		/// System.Collections.ICollection _values
		/// </summary>
		protected RSystem.RCollections.RICollection r__values;
		public virtual RSystem.RCollections.RICollection R_values
		{
			get
			{
				if(r__values == null)
				{
					r__values = new(this, "_values");
					r__values.SetBelong(this.instance);
				}
				return r__values;
			}
		}

		/// <summary>
		/// System.Collections.IEqualityComparer _keycomparer
		/// </summary>
		protected RSystem.RCollections.RIEqualityComparer r__keycomparer;
		public virtual RSystem.RCollections.RIEqualityComparer R_keycomparer
		{
			get
			{
				if(r__keycomparer == null)
				{
					r__keycomparer = new(this, "_keycomparer");
					r__keycomparer.SetBelong(this.instance);
				}
				return r__keycomparer;
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
		/// System.Runtime.CompilerServices.ConditionalWeakTable`2[System.Object,System.Runtime.Serialization.SerializationInfo] s_serializationInfoTable
		/// </summary>
		protected static RSystem.RRuntime.RCompilerServices.RConditionalWeakTable<RSystem.RObject, RSystem.RRuntime.RSerialization.RSerializationInfo> r_s_serializationInfoTable;
		public static RSystem.RRuntime.RCompilerServices.RConditionalWeakTable<RSystem.RObject, RSystem.RRuntime.RSerialization.RSerializationInfo> Rs_serializationInfoTable
		{
			get
			{
				if(r_s_serializationInfoTable == null)
				{
					r_s_serializationInfoTable = new(typeof(System.Collections.Hashtable), "s_serializationInfoTable");
					r_s_serializationInfoTable.SetBelong(null);
				}
				return r_s_serializationInfoTable;
			}
		}

		/// <summary>
		/// System.Runtime.CompilerServices.ConditionalWeakTable`2[System.Object,System.Runtime.Serialization.SerializationInfo] SerializationInfoTable
		/// </summary>
		protected static RSystem.RRuntime.RCompilerServices.RConditionalWeakTable<RSystem.RObject, RSystem.RRuntime.RSerialization.RSerializationInfo> r_SerializationInfoTable;
		public static RSystem.RRuntime.RCompilerServices.RConditionalWeakTable<RSystem.RObject, RSystem.RRuntime.RSerialization.RSerializationInfo> RSerializationInfoTable
		{
			get
			{
				if(r_SerializationInfoTable == null)
				{
					r_SerializationInfoTable = new(typeof(System.Collections.Hashtable), "SerializationInfoTable", -1);
					r_SerializationInfoTable.SetBelong(null);
				}
				return r_SerializationInfoTable;
			}
		}

		/// <summary>
		/// System.Collections.IHashCodeProvider hcp
		/// </summary>
		protected RSystem.RCollections.RIHashCodeProvider r_hcp;
		public virtual RSystem.RCollections.RIHashCodeProvider Rhcp
		{
			get
			{
				if(r_hcp == null)
				{
					r_hcp = new(this, "hcp", -1);
					r_hcp.SetBelong(this.instance);
				}
				return r_hcp;
			}
		}

		/// <summary>
		/// System.Collections.IComparer comparer
		/// </summary>
		protected RSystem.RCollections.RIComparer r_comparer;
		public virtual RSystem.RCollections.RIComparer Rcomparer
		{
			get
			{
				if(r_comparer == null)
				{
					r_comparer = new(this, "comparer", -1);
					r_comparer.SetBelong(this.instance);
				}
				return r_comparer;
			}
		}

		/// <summary>
		/// System.Collections.IEqualityComparer EqualityComparer
		/// </summary>
		protected RSystem.RCollections.RIEqualityComparer r_EqualityComparer;
		public virtual RSystem.RCollections.RIEqualityComparer REqualityComparer
		{
			get
			{
				if(r_EqualityComparer == null)
				{
					r_EqualityComparer = new(this, "EqualityComparer", -1);
					r_EqualityComparer.SetBelong(this.instance);
				}
				return r_EqualityComparer;
			}
		}

		/// <summary>
		/// System.Object Item [System.Object]
		/// </summary>
		protected RSystem.RObject r_Item_Object;
		public virtual RSystem.RObject RItem_Object
		{
			get
			{
				if(r_Item_Object == null)
				{
					r_Item_Object = new(this, "Item", -1, typeof(System.Object));
					r_Item_Object.SetBelong(this.instance);
				}
				return r_Item_Object;
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
		/// Boolean IsFixedSize
		/// </summary>
		protected RProperty r_IsFixedSize;
		public virtual RProperty RIsFixedSize
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
		/// System.Collections.ICollection Keys
		/// </summary>
		protected RSystem.RCollections.RICollection r_Keys;
		public virtual RSystem.RCollections.RICollection RKeys
		{
			get
			{
				if(r_Keys == null)
				{
					r_Keys = new(this, "Keys", -1);
					r_Keys.SetBelong(this.instance);
				}
				return r_Keys;
			}
		}

		/// <summary>
		/// System.Collections.ICollection Values
		/// </summary>
		protected RSystem.RCollections.RICollection r_Values;
		public virtual RSystem.RCollections.RICollection RValues
		{
			get
			{
				if(r_Values == null)
				{
					r_Values = new(this, "Values", -1);
					r_Values.SetBelong(this.instance);
				}
				return r_Values;
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
		/// UInt32 InitHash(System.Object, Int32, UInt32 ByRef, UInt32 ByRef)
		/// </summary>
		protected RMethod r_InitHash_Object_Int32_Out_UInt32_Out_UInt32;
		public virtual RMethod RInitHash_Object_Int32_Out_UInt32_Out_UInt32
		{
			get
			{
				if(r_InitHash_Object_Int32_Out_UInt32_Out_UInt32 == null)
				{
					r_InitHash_Object_Int32_Out_UInt32_Out_UInt32 = new(this, "InitHash", 0, typeof(System.Object), typeof(System.Int32), typeof(System.UInt32).MakeByRefType(), typeof(System.UInt32).MakeByRefType());
					r_InitHash_Object_Int32_Out_UInt32_Out_UInt32.SetBelong(this.instance);
				}
				return r_InitHash_Object_Int32_Out_UInt32_Out_UInt32;
			}
		}

		/// <summary>
		/// Void Add(System.Object, System.Object)
		/// </summary>
		protected RMethod r_Add_Object_Object;
		public virtual RMethod RAdd_Object_Object
		{
			get
			{
				if(r_Add_Object_Object == null)
				{
					r_Add_Object_Object = new(this, "Add", 0, typeof(System.Object), typeof(System.Object));
					r_Add_Object_Object.SetBelong(this.instance);
				}
				return r_Add_Object_Object;
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
		/// Boolean ContainsKey(System.Object)
		/// </summary>
		protected RMethod r_ContainsKey_Object;
		public virtual RMethod RContainsKey_Object
		{
			get
			{
				if(r_ContainsKey_Object == null)
				{
					r_ContainsKey_Object = new(this, "ContainsKey", 0, typeof(System.Object));
					r_ContainsKey_Object.SetBelong(this.instance);
				}
				return r_ContainsKey_Object;
			}
		}

		/// <summary>
		/// Boolean ContainsValue(System.Object)
		/// </summary>
		protected RMethod r_ContainsValue_Object;
		public virtual RMethod RContainsValue_Object
		{
			get
			{
				if(r_ContainsValue_Object == null)
				{
					r_ContainsValue_Object = new(this, "ContainsValue", 0, typeof(System.Object));
					r_ContainsValue_Object.SetBelong(this.instance);
				}
				return r_ContainsValue_Object;
			}
		}

		/// <summary>
		/// Void CopyKeys(System.Array, Int32)
		/// </summary>
		protected RMethod r_CopyKeys_Array_Int32;
		public virtual RMethod RCopyKeys_Array_Int32
		{
			get
			{
				if(r_CopyKeys_Array_Int32 == null)
				{
					r_CopyKeys_Array_Int32 = new(this, "CopyKeys", 0, typeof(System.Array), typeof(System.Int32));
					r_CopyKeys_Array_Int32.SetBelong(this.instance);
				}
				return r_CopyKeys_Array_Int32;
			}
		}

		/// <summary>
		/// Void CopyEntries(System.Array, Int32)
		/// </summary>
		protected RMethod r_CopyEntries_Array_Int32;
		public virtual RMethod RCopyEntries_Array_Int32
		{
			get
			{
				if(r_CopyEntries_Array_Int32 == null)
				{
					r_CopyEntries_Array_Int32 = new(this, "CopyEntries", 0, typeof(System.Array), typeof(System.Int32));
					r_CopyEntries_Array_Int32.SetBelong(this.instance);
				}
				return r_CopyEntries_Array_Int32;
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
		/// System.Collections.KeyValuePairs[] ToKeyValuePairsArray()
		/// </summary>
		protected RMethod r_ToKeyValuePairsArray;
		public virtual RMethod RToKeyValuePairsArray
		{
			get
			{
				if(r_ToKeyValuePairsArray == null)
				{
					r_ToKeyValuePairsArray = new(this, "ToKeyValuePairsArray", 0);
					r_ToKeyValuePairsArray.SetBelong(this.instance);
				}
				return r_ToKeyValuePairsArray;
			}
		}

		/// <summary>
		/// Void CopyValues(System.Array, Int32)
		/// </summary>
		protected RMethod r_CopyValues_Array_Int32;
		public virtual RMethod RCopyValues_Array_Int32
		{
			get
			{
				if(r_CopyValues_Array_Int32 == null)
				{
					r_CopyValues_Array_Int32 = new(this, "CopyValues", 0, typeof(System.Array), typeof(System.Int32));
					r_CopyValues_Array_Int32.SetBelong(this.instance);
				}
				return r_CopyValues_Array_Int32;
			}
		}

		/// <summary>
		/// Void expand()
		/// </summary>
		protected RMethod r_expand;
		public virtual RMethod Rexpand
		{
			get
			{
				if(r_expand == null)
				{
					r_expand = new(this, "expand", 0);
					r_expand.SetBelong(this.instance);
				}
				return r_expand;
			}
		}

		/// <summary>
		/// Void rehash()
		/// </summary>
		protected RMethod r_rehash;
		public virtual RMethod Rrehash
		{
			get
			{
				if(r_rehash == null)
				{
					r_rehash = new(this, "rehash", 0);
					r_rehash.SetBelong(this.instance);
				}
				return r_rehash;
			}
		}

		/// <summary>
		/// Void UpdateVersion()
		/// </summary>
		protected RMethod r_UpdateVersion;
		public virtual RMethod RUpdateVersion
		{
			get
			{
				if(r_UpdateVersion == null)
				{
					r_UpdateVersion = new(this, "UpdateVersion", 0);
					r_UpdateVersion.SetBelong(this.instance);
				}
				return r_UpdateVersion;
			}
		}

		/// <summary>
		/// Void rehash(Int32)
		/// </summary>
		protected RMethod r_rehash_Int32;
		public virtual RMethod Rrehash_Int32
		{
			get
			{
				if(r_rehash_Int32 == null)
				{
					r_rehash_Int32 = new(this, "rehash", 0, typeof(System.Int32));
					r_rehash_Int32.SetBelong(this.instance);
				}
				return r_rehash_Int32;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		/// </summary>
		protected RMethod r_System__2__Collections__2__IEnumerable__2__GetEnumerator;
		public virtual RMethod RSystem__2__Collections__2__IEnumerable__2__GetEnumerator
		{
			get
			{
				if(r_System__2__Collections__2__IEnumerable__2__GetEnumerator == null)
				{
					r_System__2__Collections__2__IEnumerable__2__GetEnumerator = new(this, "System.Collections.IEnumerable.GetEnumerator", 0);
					r_System__2__Collections__2__IEnumerable__2__GetEnumerator.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IEnumerable__2__GetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.IDictionaryEnumerator GetEnumerator()
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
		/// Int32 GetHash(System.Object)
		/// </summary>
		protected RMethod r_GetHash_Object;
		public virtual RMethod RGetHash_Object
		{
			get
			{
				if(r_GetHash_Object == null)
				{
					r_GetHash_Object = new(this, "GetHash", 0, typeof(System.Object));
					r_GetHash_Object.SetBelong(this.instance);
				}
				return r_GetHash_Object;
			}
		}

		/// <summary>
		/// Boolean KeyEquals(System.Object, System.Object)
		/// </summary>
		protected RMethod r_KeyEquals_Object_Object;
		public virtual RMethod RKeyEquals_Object_Object
		{
			get
			{
				if(r_KeyEquals_Object_Object == null)
				{
					r_KeyEquals_Object_Object = new(this, "KeyEquals", 0, typeof(System.Object), typeof(System.Object));
					r_KeyEquals_Object_Object.SetBelong(this.instance);
				}
				return r_KeyEquals_Object_Object;
			}
		}

		/// <summary>
		/// Void Insert(System.Object, System.Object, Boolean)
		/// </summary>
		protected RMethod r_Insert_Object_Object_Boolean;
		public virtual RMethod RInsert_Object_Object_Boolean
		{
			get
			{
				if(r_Insert_Object_Object_Boolean == null)
				{
					r_Insert_Object_Object_Boolean = new(this, "Insert", 0, typeof(System.Object), typeof(System.Object), typeof(System.Boolean));
					r_Insert_Object_Object_Boolean.SetBelong(this.instance);
				}
				return r_Insert_Object_Object_Boolean;
			}
		}

		/// <summary>
		/// Void putEntry(bucket[], System.Object, System.Object, Int32)
		/// </summary>
		protected RMethod r_putEntry_bucketArray_Object_Object_Int32;
		public virtual RMethod RputEntry_bucketArray_Object_Object_Int32
		{
			get
			{
				if(r_putEntry_bucketArray_Object_Object_Int32 == null)
				{
					r_putEntry_bucketArray_Object_Object_Int32 = new(this, "putEntry", 0,  ReflectionUtils.GetType("System.Collections.Hashtable+bucket").MakeArrayType(), typeof(System.Object), typeof(System.Object), typeof(System.Int32));
					r_putEntry_bucketArray_Object_Object_Int32.SetBelong(this.instance);
				}
				return r_putEntry_bucketArray_Object_Object_Int32;
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
		/// System.Collections.Hashtable Synchronized(System.Collections.Hashtable)
		/// </summary>
		protected static RMethod r_Synchronized_Hashtable;
		public static RMethod RSynchronized_Hashtable
		{
			get
			{
				if(r_Synchronized_Hashtable == null)
				{
					r_Synchronized_Hashtable = new(typeof(System.Collections.Hashtable), "Synchronized", 0, typeof(System.Collections.Hashtable));
					r_Synchronized_Hashtable.SetBelong(null);
				}
				return r_Synchronized_Hashtable;
			}
		}

		/// <summary>
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_GetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_GetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Void OnDeserialization(System.Object)
		/// </summary>
		protected RMethod r_OnDeserialization_Object;
		public virtual RMethod ROnDeserialization_Object
		{
			get
			{
				if(r_OnDeserialization_Object == null)
				{
					r_OnDeserialization_Object = new(this, "OnDeserialization", 0, typeof(System.Object));
					r_OnDeserialization_Object.SetBelong(this.instance);
				}
				return r_OnDeserialization_Object;
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


        public RHashtable() : base("System.Collections.Hashtable")
        {
        }

        public RHashtable(System.Object instance) : base("System.Collections.Hashtable")
		{
            SetInstance(instance);
		}

        public RHashtable(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RHashtable(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.UInt32 InitHash(System.Object  @key, System.Int32  @hashsize, out System.UInt32  @seed, out System.UInt32  @incr)
        {
			@seed = default;
			@incr = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @hashsize, @seed, @incr};
            var ___result = RInitHash_Object_Int32_Out_UInt32_Out_UInt32.Invoke(___genericsType, ___parameters);
			@seed = (System.UInt32)___parameters[2];
			@incr = (System.UInt32)___parameters[3];

            return (System.UInt32)___result;
        }


        public virtual void Add(System.Object  @key, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RAdd_Object_Object.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Boolean Contains(System.Object  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RContains_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ContainsKey(System.Object  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RContainsKey_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ContainsValue(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RContainsValue_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CopyKeys(System.Array  @array, System.Int32  @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RCopyKeys_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyEntries(System.Array  @array, System.Int32  @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RCopyEntries_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Array  @array, System.Int32  @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RCopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object ToKeyValuePairsArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToKeyValuePairsArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void CopyValues(System.Array  @array, System.Int32  @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RCopyValues_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void expand()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rexpand.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void rehash()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rrehash.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateVersion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateVersion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void rehash(System.Int32  @newsize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newsize};
            var ___result = Rrehash_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator System__2__Collections__2__IEnumerable__2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__2__Collections__2__IEnumerable__2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Collections.IDictionaryEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IDictionaryEnumerator)___result;
        }


        public virtual System.Int32 GetHash(System.Object  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RGetHash_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean KeyEquals(System.Object  @item, System.Object  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item, @key};
            var ___result = RKeyEquals_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Insert(System.Object  @key, System.Object  @nvalue, System.Boolean  @add)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @nvalue, @add};
            var ___result = RInsert_Object_Object_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void putEntry(RTypeArray<RSystem.RCollections.RHashtable.Rbucket>  @newBuckets, System.Object  @key, System.Object  @nvalue, System.Int32  @hashcode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newBuckets.Value, @key, @nvalue, @hashcode};
            var ___result = RputEntry_bucketArray_Object_Object_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Remove(System.Object  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RRemove_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Collections.Hashtable Synchronized(System.Collections.Hashtable  @table)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@table};
            var ___result = RSynchronized_Hashtable.Invoke(___genericsType, ___parameters);

            return (System.Collections.Hashtable)___result;
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserialization(System.Object  @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = ROnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
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
