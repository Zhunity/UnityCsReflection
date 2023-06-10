
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections
{
	/// <summary>
	/// System.Collections.Hashtable
	/// </summary>
    public partial class RHashtable : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Collections.Hashtable);
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


		/// <summary>
		/// System.Int32 HashPrime
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FHashPrime;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFHashPrime
		{
			get
			{
				if(r_FHashPrime == null)
				{
					r_FHashPrime = new(typeof(System.Collections.Hashtable), "HashPrime");
				}
				return r_FHashPrime;
			}
		}

		/// <summary>
		/// System.Int32 InitialSize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FInitialSize;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFInitialSize
		{
			get
			{
				if(r_FInitialSize == null)
				{
					r_FInitialSize = new(typeof(System.Collections.Hashtable), "InitialSize");
				}
				return r_FInitialSize;
			}
		}

		/// <summary>
		/// System.String LoadFactorName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FLoadFactorName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFLoadFactorName
		{
			get
			{
				if(r_FLoadFactorName == null)
				{
					r_FLoadFactorName = new(typeof(System.Collections.Hashtable), "LoadFactorName");
				}
				return r_FLoadFactorName;
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
					r_FVersionName = new(typeof(System.Collections.Hashtable), "VersionName");
				}
				return r_FVersionName;
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
					r_FComparerName = new(typeof(System.Collections.Hashtable), "ComparerName");
				}
				return r_FComparerName;
			}
		}

		/// <summary>
		/// System.String HashCodeProviderName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FHashCodeProviderName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFHashCodeProviderName
		{
			get
			{
				if(r_FHashCodeProviderName == null)
				{
					r_FHashCodeProviderName = new(typeof(System.Collections.Hashtable), "HashCodeProviderName");
				}
				return r_FHashCodeProviderName;
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
					r_FHashSizeName = new(typeof(System.Collections.Hashtable), "HashSizeName");
				}
				return r_FHashSizeName;
			}
		}

		/// <summary>
		/// System.String KeysName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FKeysName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFKeysName
		{
			get
			{
				if(r_FKeysName == null)
				{
					r_FKeysName = new(typeof(System.Collections.Hashtable), "KeysName");
				}
				return r_FKeysName;
			}
		}

		/// <summary>
		/// System.String ValuesName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FValuesName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFValuesName
		{
			get
			{
				if(r_FValuesName == null)
				{
					r_FValuesName = new(typeof(System.Collections.Hashtable), "ValuesName");
				}
				return r_FValuesName;
			}
		}

		/// <summary>
		/// System.String KeyComparerName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FKeyComparerName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFKeyComparerName
		{
			get
			{
				if(r_FKeyComparerName == null)
				{
					r_FKeyComparerName = new(typeof(System.Collections.Hashtable), "KeyComparerName");
				}
				return r_FKeyComparerName;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable+bucket[] _buckets
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable.Rbucket> r_F_buckets;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable.Rbucket> RF_buckets
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
		/// System.Int32 _occupancy
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_occupancy;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_occupancy
		{
			get
			{
				if(r_F_occupancy == null)
				{
					r_F_occupancy = new(this, "_occupancy");
				}
				return r_F_occupancy;
			}
		}

		/// <summary>
		/// System.Int32 _loadsize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_loadsize;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_loadsize
		{
			get
			{
				if(r_F_loadsize == null)
				{
					r_F_loadsize = new(this, "_loadsize");
				}
				return r_F_loadsize;
			}
		}

		/// <summary>
		/// System.Single _loadFactor
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_F_loadFactor;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RF_loadFactor
		{
			get
			{
				if(r_F_loadFactor == null)
				{
					r_F_loadFactor = new(this, "_loadFactor");
				}
				return r_F_loadFactor;
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
		/// System.Boolean _isWriterInProgress
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F_isWriterInProgress;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF_isWriterInProgress
		{
			get
			{
				if(r_F_isWriterInProgress == null)
				{
					r_F_isWriterInProgress = new(this, "_isWriterInProgress");
				}
				return r_F_isWriterInProgress;
			}
		}

		/// <summary>
		/// System.Collections.ICollection _keys
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RICollection r_F_keys;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RICollection RF_keys
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
		/// System.Collections.ICollection _values
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RICollection r_F_values;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RICollection RF_values
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
		/// System.Collections.IEqualityComparer _keycomparer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RIEqualityComparer r_F_keycomparer;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RIEqualityComparer RF_keycomparer
		{
			get
			{
				if(r_F_keycomparer == null)
				{
					r_F_keycomparer = new(this, "_keycomparer");
				}
				return r_F_keycomparer;
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
		/// System.Runtime.CompilerServices.ConditionalWeakTable`2[System.Object,System.Runtime.Serialization.SerializationInfo] s_serializationInfoTable
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RCompilerServices.RConditionalWeakTable<Hvak.Editor.Refleaction.RSystem.RObject, Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RSerializationInfo> r_Fs_serializationInfoTable;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RCompilerServices.RConditionalWeakTable<Hvak.Editor.Refleaction.RSystem.RObject, Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RSerializationInfo> RFs_serializationInfoTable
		{
			get
			{
				if(r_Fs_serializationInfoTable == null)
				{
					r_Fs_serializationInfoTable = new(typeof(System.Collections.Hashtable), "s_serializationInfoTable");
				}
				return r_Fs_serializationInfoTable;
			}
		}

		/// <summary>
		/// System.Runtime.CompilerServices.ConditionalWeakTable`2[System.Object,System.Runtime.Serialization.SerializationInfo] SerializationInfoTable
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RCompilerServices.RConditionalWeakTable<Hvak.Editor.Refleaction.RSystem.RObject, Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RSerializationInfo> r_PSerializationInfoTable;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RCompilerServices.RConditionalWeakTable<Hvak.Editor.Refleaction.RSystem.RObject, Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RSerializationInfo> RPSerializationInfoTable
		{
			get
			{
				if(r_PSerializationInfoTable == null)
				{
					r_PSerializationInfoTable = new(typeof(System.Collections.Hashtable), "SerializationInfoTable", -1);
				}
				return r_PSerializationInfoTable;
			}
		}

		/// <summary>
		/// System.Collections.IHashCodeProvider hcp
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RIHashCodeProvider r_Phcp;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RIHashCodeProvider RPhcp
		{
			get
			{
				if(r_Phcp == null)
				{
					r_Phcp = new(this, "hcp", -1);
				}
				return r_Phcp;
			}
		}

		/// <summary>
		/// System.Collections.IComparer comparer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RIComparer r_Pcomparer;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RIComparer RPcomparer
		{
			get
			{
				if(r_Pcomparer == null)
				{
					r_Pcomparer = new(this, "comparer", -1);
				}
				return r_Pcomparer;
			}
		}

		/// <summary>
		/// System.Collections.IEqualityComparer EqualityComparer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RIEqualityComparer r_PEqualityComparer;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RIEqualityComparer RPEqualityComparer
		{
			get
			{
				if(r_PEqualityComparer == null)
				{
					r_PEqualityComparer = new(this, "EqualityComparer", -1);
				}
				return r_PEqualityComparer;
			}
		}

		/// <summary>
		/// System.Object Item [System.Object]
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PItem_Object;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPItem_Object
		{
			get
			{
				if(r_PItem_Object == null)
				{
					r_PItem_Object = new(this, "Item", -1, typeof(System.Object));
				}
				return r_PItem_Object;
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
				}
				return r_PIsReadOnly;
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
				}
				return r_PIsFixedSize;
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
				}
				return r_PIsSynchronized;
			}
		}

		/// <summary>
		/// System.Collections.ICollection Keys
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RICollection r_PKeys;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RICollection RPKeys
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
		/// System.Collections.ICollection Values
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RICollection r_PValues;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RICollection RPValues
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
				}
				return r_PSyncRoot;
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
		/// UInt32 InitHash(System.Object, Int32, UInt32 ByRef, UInt32 ByRef)
		/// </summary>
		protected RMethod r_MInitHash_Object_Int32_Out_UInt32_Out_UInt32;
		public virtual RMethod RMInitHash_Object_Int32_Out_UInt32_Out_UInt32
		{
			get
			{
				if(r_MInitHash_Object_Int32_Out_UInt32_Out_UInt32 == null)
				{
					r_MInitHash_Object_Int32_Out_UInt32_Out_UInt32 = new(this, "InitHash", 0, typeof(System.Object), typeof(System.Int32), typeof(System.UInt32).MakeByRefType(), typeof(System.UInt32).MakeByRefType());
				}
				return r_MInitHash_Object_Int32_Out_UInt32_Out_UInt32;
			}
		}

		/// <summary>
		/// Void Add(System.Object, System.Object)
		/// </summary>
		protected RMethod r_MAdd_Object_Object;
		public virtual RMethod RMAdd_Object_Object
		{
			get
			{
				if(r_MAdd_Object_Object == null)
				{
					r_MAdd_Object_Object = new(this, "Add", 0, typeof(System.Object), typeof(System.Object));
				}
				return r_MAdd_Object_Object;
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
				}
				return r_MContains_Object;
			}
		}

		/// <summary>
		/// Boolean ContainsKey(System.Object)
		/// </summary>
		protected RMethod r_MContainsKey_Object;
		public virtual RMethod RMContainsKey_Object
		{
			get
			{
				if(r_MContainsKey_Object == null)
				{
					r_MContainsKey_Object = new(this, "ContainsKey", 0, typeof(System.Object));
				}
				return r_MContainsKey_Object;
			}
		}

		/// <summary>
		/// Boolean ContainsValue(System.Object)
		/// </summary>
		protected RMethod r_MContainsValue_Object;
		public virtual RMethod RMContainsValue_Object
		{
			get
			{
				if(r_MContainsValue_Object == null)
				{
					r_MContainsValue_Object = new(this, "ContainsValue", 0, typeof(System.Object));
				}
				return r_MContainsValue_Object;
			}
		}

		/// <summary>
		/// Void CopyKeys(System.Array, Int32)
		/// </summary>
		protected RMethod r_MCopyKeys_Array_Int32;
		public virtual RMethod RMCopyKeys_Array_Int32
		{
			get
			{
				if(r_MCopyKeys_Array_Int32 == null)
				{
					r_MCopyKeys_Array_Int32 = new(this, "CopyKeys", 0, typeof(System.Array), typeof(System.Int32));
				}
				return r_MCopyKeys_Array_Int32;
			}
		}

		/// <summary>
		/// Void CopyEntries(System.Array, Int32)
		/// </summary>
		protected RMethod r_MCopyEntries_Array_Int32;
		public virtual RMethod RMCopyEntries_Array_Int32
		{
			get
			{
				if(r_MCopyEntries_Array_Int32 == null)
				{
					r_MCopyEntries_Array_Int32 = new(this, "CopyEntries", 0, typeof(System.Array), typeof(System.Int32));
				}
				return r_MCopyEntries_Array_Int32;
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
				}
				return r_MCopyTo_Array_Int32;
			}
		}

		/// <summary>
		/// System.Collections.KeyValuePairs[] ToKeyValuePairsArray()
		/// </summary>
		protected RMethod r_MToKeyValuePairsArray;
		public virtual RMethod RMToKeyValuePairsArray
		{
			get
			{
				if(r_MToKeyValuePairsArray == null)
				{
					r_MToKeyValuePairsArray = new(this, "ToKeyValuePairsArray", 0);
				}
				return r_MToKeyValuePairsArray;
			}
		}

		/// <summary>
		/// Void CopyValues(System.Array, Int32)
		/// </summary>
		protected RMethod r_MCopyValues_Array_Int32;
		public virtual RMethod RMCopyValues_Array_Int32
		{
			get
			{
				if(r_MCopyValues_Array_Int32 == null)
				{
					r_MCopyValues_Array_Int32 = new(this, "CopyValues", 0, typeof(System.Array), typeof(System.Int32));
				}
				return r_MCopyValues_Array_Int32;
			}
		}

		/// <summary>
		/// Void expand()
		/// </summary>
		protected RMethod r_Mexpand;
		public virtual RMethod RMexpand
		{
			get
			{
				if(r_Mexpand == null)
				{
					r_Mexpand = new(this, "expand", 0);
				}
				return r_Mexpand;
			}
		}

		/// <summary>
		/// Void rehash()
		/// </summary>
		protected RMethod r_Mrehash;
		public virtual RMethod RMrehash
		{
			get
			{
				if(r_Mrehash == null)
				{
					r_Mrehash = new(this, "rehash", 0);
				}
				return r_Mrehash;
			}
		}

		/// <summary>
		/// Void UpdateVersion()
		/// </summary>
		protected RMethod r_MUpdateVersion;
		public virtual RMethod RMUpdateVersion
		{
			get
			{
				if(r_MUpdateVersion == null)
				{
					r_MUpdateVersion = new(this, "UpdateVersion", 0);
				}
				return r_MUpdateVersion;
			}
		}

		/// <summary>
		/// Void rehash(Int32)
		/// </summary>
		protected RMethod r_Mrehash_Int32;
		public virtual RMethod RMrehash_Int32
		{
			get
			{
				if(r_Mrehash_Int32 == null)
				{
					r_Mrehash_Int32 = new(this, "rehash", 0, typeof(System.Int32));
				}
				return r_Mrehash_Int32;
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
		/// System.Collections.IDictionaryEnumerator GetEnumerator()
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
		/// Int32 GetHash(System.Object)
		/// </summary>
		protected RMethod r_MGetHash_Object;
		public virtual RMethod RMGetHash_Object
		{
			get
			{
				if(r_MGetHash_Object == null)
				{
					r_MGetHash_Object = new(this, "GetHash", 0, typeof(System.Object));
				}
				return r_MGetHash_Object;
			}
		}

		/// <summary>
		/// Boolean KeyEquals(System.Object, System.Object)
		/// </summary>
		protected RMethod r_MKeyEquals_Object_Object;
		public virtual RMethod RMKeyEquals_Object_Object
		{
			get
			{
				if(r_MKeyEquals_Object_Object == null)
				{
					r_MKeyEquals_Object_Object = new(this, "KeyEquals", 0, typeof(System.Object), typeof(System.Object));
				}
				return r_MKeyEquals_Object_Object;
			}
		}

		/// <summary>
		/// Void Insert(System.Object, System.Object, Boolean)
		/// </summary>
		protected RMethod r_MInsert_Object_Object_Boolean;
		public virtual RMethod RMInsert_Object_Object_Boolean
		{
			get
			{
				if(r_MInsert_Object_Object_Boolean == null)
				{
					r_MInsert_Object_Object_Boolean = new(this, "Insert", 0, typeof(System.Object), typeof(System.Object), typeof(System.Boolean));
				}
				return r_MInsert_Object_Object_Boolean;
			}
		}

		/// <summary>
		/// Void putEntry(bucket[], System.Object, System.Object, Int32)
		/// </summary>
		protected RMethod r_MputEntry_bucketArray_Object_Object_Int32;
		public virtual RMethod RMputEntry_bucketArray_Object_Object_Int32
		{
			get
			{
				if(r_MputEntry_bucketArray_Object_Object_Int32 == null)
				{
					r_MputEntry_bucketArray_Object_Object_Int32 = new(this, "putEntry", 0,  ReflectionUtils.GetType("System.Collections.Hashtable+bucket").MakeArrayType(), typeof(System.Object), typeof(System.Object), typeof(System.Int32));
				}
				return r_MputEntry_bucketArray_Object_Object_Int32;
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
				}
				return r_MRemove_Object;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable Synchronized(System.Collections.Hashtable)
		/// </summary>
		protected static RMethod r_MSynchronized_Hashtable;
		public static RMethod RMSynchronized_Hashtable
		{
			get
			{
				if(r_MSynchronized_Hashtable == null)
				{
					r_MSynchronized_Hashtable = new(typeof(System.Collections.Hashtable), "Synchronized", 0, typeof(System.Collections.Hashtable));
				}
				return r_MSynchronized_Hashtable;
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


        public virtual System.UInt32 InitHash(System.Object @key, System.Int32 @hashsize, out System.UInt32 @seed, out System.UInt32 @incr)
        {
			@seed = default;
			@incr = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @hashsize, @seed, @incr};
            var ___result = RMInitHash_Object_Int32_Out_UInt32_Out_UInt32.Invoke(___genericsType, ___parameters);
			@seed = (System.UInt32)___parameters[2];
			@incr = (System.UInt32)___parameters[3];

            return (System.UInt32)___result;
        }


        public virtual void Add(System.Object @key, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RMAdd_Object_Object.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Boolean Contains(System.Object @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMContains_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ContainsKey(System.Object @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMContainsKey_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ContainsValue(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMContainsValue_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CopyKeys(System.Array @array, System.Int32 @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RMCopyKeys_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyEntries(System.Array @array, System.Int32 @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RMCopyEntries_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Array @array, System.Int32 @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RMCopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RCollections.RKeyValuePairs> ToKeyValuePairsArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToKeyValuePairsArray.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RCollections.RKeyValuePairs>(___result);
        }


        public virtual void CopyValues(System.Array @array, System.Int32 @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RMCopyValues_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void expand()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMexpand.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void rehash()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMrehash.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateVersion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateVersion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void rehash(System.Int32 @newsize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newsize};
            var ___result = RMrehash_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator System__2__Collections__2__IEnumerable__2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Collections.IDictionaryEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IDictionaryEnumerator)___result;
        }


        public virtual System.Int32 GetHash(System.Object @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMGetHash_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean KeyEquals(System.Object @item, System.Object @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item, @key};
            var ___result = RMKeyEquals_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Insert(System.Object @key, System.Object @nvalue, System.Boolean @add)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @nvalue, @add};
            var ___result = RMInsert_Object_Object_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void putEntry(Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable.Rbucket> @newBuckets, System.Object @key, System.Object @nvalue, System.Int32 @hashcode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newBuckets.Value, @key, @nvalue, @hashcode};
            var ___result = RMputEntry_bucketArray_Object_Object_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Remove(System.Object @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMRemove_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Collections.Hashtable Synchronized(System.Collections.Hashtable @table)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@table};
            var ___result = RMSynchronized_Hashtable.Invoke(___genericsType, ___parameters);

            return (System.Collections.Hashtable)___result;
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserialization(System.Object @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = RMOnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
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
