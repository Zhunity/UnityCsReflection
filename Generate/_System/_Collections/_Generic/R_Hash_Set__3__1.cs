
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
	/// System.Collections.Generic.HashSet`1
	/// </summary>
    public partial class RHashSet<T> : RMember //
    {

		/// <summary>
		/// System.Int32 Lower31BitMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FLower31BitMask;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFLower31BitMask
		{
			get
			{
				if(r_FLower31BitMask == null)
				{
					r_FLower31BitMask = new(typeof(System.Collections.Generic.HashSet<>), "Lower31BitMask");
					r_FLower31BitMask.SetBelong(null);
				}
				return r_FLower31BitMask;
			}
		}

		/// <summary>
		/// System.Int32 StackAllocThreshold
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FStackAllocThreshold;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFStackAllocThreshold
		{
			get
			{
				if(r_FStackAllocThreshold == null)
				{
					r_FStackAllocThreshold = new(typeof(System.Collections.Generic.HashSet<>), "StackAllocThreshold");
					r_FStackAllocThreshold.SetBelong(null);
				}
				return r_FStackAllocThreshold;
			}
		}

		/// <summary>
		/// System.Int32 ShrinkThreshold
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FShrinkThreshold;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFShrinkThreshold
		{
			get
			{
				if(r_FShrinkThreshold == null)
				{
					r_FShrinkThreshold = new(typeof(System.Collections.Generic.HashSet<>), "ShrinkThreshold");
					r_FShrinkThreshold.SetBelong(null);
				}
				return r_FShrinkThreshold;
			}
		}

		/// <summary>
		/// System.String CapacityName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FCapacityName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFCapacityName
		{
			get
			{
				if(r_FCapacityName == null)
				{
					r_FCapacityName = new(typeof(System.Collections.Generic.HashSet<>), "CapacityName");
					r_FCapacityName.SetBelong(null);
				}
				return r_FCapacityName;
			}
		}

		/// <summary>
		/// System.String ElementsName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FElementsName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFElementsName
		{
			get
			{
				if(r_FElementsName == null)
				{
					r_FElementsName = new(typeof(System.Collections.Generic.HashSet<>), "ElementsName");
					r_FElementsName.SetBelong(null);
				}
				return r_FElementsName;
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
					r_FComparerName = new(typeof(System.Collections.Generic.HashSet<>), "ComparerName");
					r_FComparerName.SetBelong(null);
				}
				return r_FComparerName;
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
					r_FVersionName = new(typeof(System.Collections.Generic.HashSet<>), "VersionName");
					r_FVersionName.SetBelong(null);
				}
				return r_FVersionName;
			}
		}

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
					r_F_buckets.SetBelong(this.instance);
				}
				return r_F_buckets;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1+Slot[T][] _slots
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RField>.RSlot> r_F_slots;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RField>.RSlot> RF_slots
		{
			get
			{
				if(r_F_slots == null)
				{
					r_F_slots = new(this, "_slots");
					r_F_slots.SetBelong(this.instance);
				}
				return r_F_slots;
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
					r_F_count.SetBelong(this.instance);
				}
				return r_F_count;
			}
		}

		/// <summary>
		/// System.Int32 _lastIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_lastIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_lastIndex
		{
			get
			{
				if(r_F_lastIndex == null)
				{
					r_F_lastIndex = new(this, "_lastIndex");
					r_F_lastIndex.SetBelong(this.instance);
				}
				return r_F_lastIndex;
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
					r_F_freeList.SetBelong(this.instance);
				}
				return r_F_freeList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEqualityComparer`1[T] _comparer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEqualityComparer<Hvak.Editor.Refleaction.RField> r_F_comparer;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEqualityComparer<Hvak.Editor.Refleaction.RField> RF_comparer
		{
			get
			{
				if(r_F_comparer == null)
				{
					r_F_comparer = new(this, "_comparer");
					r_F_comparer.SetBelong(this.instance);
				}
				return r_F_comparer;
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
		/// System.Runtime.Serialization.SerializationInfo _siInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RSerializationInfo r_F_siInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RSerializationInfo RF_siInfo
		{
			get
			{
				if(r_F_siInfo == null)
				{
					r_F_siInfo = new(this, "_siInfo");
					r_F_siInfo.SetBelong(this.instance);
				}
				return r_F_siInfo;
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
		/// Boolean System.Collections.Generic.ICollection<T>.IsReadOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__IsReadOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__IsReadOnly
		{
			get
			{
				if(r_PSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__IsReadOnly == null)
				{
					r_PSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__IsReadOnly = new(this, "System.Collections.Generic.ICollection<T>.IsReadOnly", -1);
					r_PSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__IsReadOnly.SetBelong(this.instance);
				}
				return r_PSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__IsReadOnly;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEqualityComparer`1[T] Comparer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEqualityComparer<Hvak.Editor.Refleaction.RProperty> r_PComparer;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEqualityComparer<Hvak.Editor.Refleaction.RProperty> RPComparer
		{
			get
			{
				if(r_PComparer == null)
				{
					r_PComparer = new(this, "Comparer", -1);
					r_PComparer.SetBelong(this.instance);
				}
				return r_PComparer;
			}
		}

		/// <summary>
		/// Void CopyFrom(System.Collections.Generic.HashSet`1[T])
		/// </summary>
		protected RMethod r_MCopyFrom_HashSet_d_T_p_;
		public virtual RMethod RMCopyFrom_HashSet_d_T_p_
		{
			get
			{
				if(r_MCopyFrom_HashSet_d_T_p_ == null)
				{
					r_MCopyFrom_HashSet_d_T_p_ = new(this, "CopyFrom", 0, typeof(System.Collections.Generic.HashSet<>));
					r_MCopyFrom_HashSet_d_T_p_.SetBelong(this.instance);
				}
				return r_MCopyFrom_HashSet_d_T_p_;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.ICollection<T>.Add(T)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Add_T;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Add_T
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Add_T == null)
				{
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Add_T = new(this, "System.Collections.Generic.ICollection<T>.Add", 0, Type.MakeGenericMethodParameter(0));
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Add_T.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Add_T;
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
		/// Boolean Contains(T)
		/// </summary>
		protected RMethod r_MContains_T;
		public virtual RMethod RMContains_T
		{
			get
			{
				if(r_MContains_T == null)
				{
					r_MContains_T = new(this, "Contains", 0, Type.MakeGenericMethodParameter(0));
					r_MContains_T.SetBelong(this.instance);
				}
				return r_MContains_T;
			}
		}

		/// <summary>
		/// Void CopyTo(T[], Int32)
		/// </summary>
		protected RMethod r_MCopyTo_TArray_Int32;
		public virtual RMethod RMCopyTo_TArray_Int32
		{
			get
			{
				if(r_MCopyTo_TArray_Int32 == null)
				{
					r_MCopyTo_TArray_Int32 = new(this, "CopyTo", 0, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32));
					r_MCopyTo_TArray_Int32.SetBelong(this.instance);
				}
				return r_MCopyTo_TArray_Int32;
			}
		}

		/// <summary>
		/// Boolean Remove(T)
		/// </summary>
		protected RMethod r_MRemove_T;
		public virtual RMethod RMRemove_T
		{
			get
			{
				if(r_MRemove_T == null)
				{
					r_MRemove_T = new(this, "Remove", 0, Type.MakeGenericMethodParameter(0));
					r_MRemove_T.SetBelong(this.instance);
				}
				return r_MRemove_T;
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
					r_MGetEnumerator.SetBelong(this.instance);
				}
				return r_MGetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerator`1[T] System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator == null)
				{
					r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator = new(this, "System.Collections.Generic.IEnumerable<T>.GetEnumerator", 0);
					r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator;
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
					r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator;
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
					r_MGetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
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
					r_MOnDeserialization_Object.SetBelong(this.instance);
				}
				return r_MOnDeserialization_Object;
			}
		}

		/// <summary>
		/// Boolean Add(T)
		/// </summary>
		protected RMethod r_MAdd_T;
		public virtual RMethod RMAdd_T
		{
			get
			{
				if(r_MAdd_T == null)
				{
					r_MAdd_T = new(this, "Add", 0, Type.MakeGenericMethodParameter(0));
					r_MAdd_T.SetBelong(this.instance);
				}
				return r_MAdd_T;
			}
		}

		/// <summary>
		/// Boolean TryGetValue(T, T ByRef)
		/// </summary>
		protected RMethod r_MTryGetValue_T_Out_T;
		public virtual RMethod RMTryGetValue_T_Out_T
		{
			get
			{
				if(r_MTryGetValue_T_Out_T == null)
				{
					r_MTryGetValue_T_Out_T = new(this, "TryGetValue", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_MTryGetValue_T_Out_T.SetBelong(this.instance);
				}
				return r_MTryGetValue_T_Out_T;
			}
		}

		/// <summary>
		/// Void UnionWith(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_MUnionWith_IEnumerable_d_T_p_;
		public virtual RMethod RMUnionWith_IEnumerable_d_T_p_
		{
			get
			{
				if(r_MUnionWith_IEnumerable_d_T_p_ == null)
				{
					r_MUnionWith_IEnumerable_d_T_p_ = new(this, "UnionWith", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MUnionWith_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_MUnionWith_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Void IntersectWith(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_MIntersectWith_IEnumerable_d_T_p_;
		public virtual RMethod RMIntersectWith_IEnumerable_d_T_p_
		{
			get
			{
				if(r_MIntersectWith_IEnumerable_d_T_p_ == null)
				{
					r_MIntersectWith_IEnumerable_d_T_p_ = new(this, "IntersectWith", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MIntersectWith_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_MIntersectWith_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Void ExceptWith(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_MExceptWith_IEnumerable_d_T_p_;
		public virtual RMethod RMExceptWith_IEnumerable_d_T_p_
		{
			get
			{
				if(r_MExceptWith_IEnumerable_d_T_p_ == null)
				{
					r_MExceptWith_IEnumerable_d_T_p_ = new(this, "ExceptWith", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MExceptWith_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_MExceptWith_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Void SymmetricExceptWith(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_MSymmetricExceptWith_IEnumerable_d_T_p_;
		public virtual RMethod RMSymmetricExceptWith_IEnumerable_d_T_p_
		{
			get
			{
				if(r_MSymmetricExceptWith_IEnumerable_d_T_p_ == null)
				{
					r_MSymmetricExceptWith_IEnumerable_d_T_p_ = new(this, "SymmetricExceptWith", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MSymmetricExceptWith_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_MSymmetricExceptWith_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean IsSubsetOf(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_MIsSubsetOf_IEnumerable_d_T_p_;
		public virtual RMethod RMIsSubsetOf_IEnumerable_d_T_p_
		{
			get
			{
				if(r_MIsSubsetOf_IEnumerable_d_T_p_ == null)
				{
					r_MIsSubsetOf_IEnumerable_d_T_p_ = new(this, "IsSubsetOf", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MIsSubsetOf_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_MIsSubsetOf_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean IsProperSubsetOf(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_MIsProperSubsetOf_IEnumerable_d_T_p_;
		public virtual RMethod RMIsProperSubsetOf_IEnumerable_d_T_p_
		{
			get
			{
				if(r_MIsProperSubsetOf_IEnumerable_d_T_p_ == null)
				{
					r_MIsProperSubsetOf_IEnumerable_d_T_p_ = new(this, "IsProperSubsetOf", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MIsProperSubsetOf_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_MIsProperSubsetOf_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean IsSupersetOf(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_MIsSupersetOf_IEnumerable_d_T_p_;
		public virtual RMethod RMIsSupersetOf_IEnumerable_d_T_p_
		{
			get
			{
				if(r_MIsSupersetOf_IEnumerable_d_T_p_ == null)
				{
					r_MIsSupersetOf_IEnumerable_d_T_p_ = new(this, "IsSupersetOf", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MIsSupersetOf_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_MIsSupersetOf_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean IsProperSupersetOf(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_MIsProperSupersetOf_IEnumerable_d_T_p_;
		public virtual RMethod RMIsProperSupersetOf_IEnumerable_d_T_p_
		{
			get
			{
				if(r_MIsProperSupersetOf_IEnumerable_d_T_p_ == null)
				{
					r_MIsProperSupersetOf_IEnumerable_d_T_p_ = new(this, "IsProperSupersetOf", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MIsProperSupersetOf_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_MIsProperSupersetOf_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean Overlaps(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_MOverlaps_IEnumerable_d_T_p_;
		public virtual RMethod RMOverlaps_IEnumerable_d_T_p_
		{
			get
			{
				if(r_MOverlaps_IEnumerable_d_T_p_ == null)
				{
					r_MOverlaps_IEnumerable_d_T_p_ = new(this, "Overlaps", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MOverlaps_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_MOverlaps_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean SetEquals(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_MSetEquals_IEnumerable_d_T_p_;
		public virtual RMethod RMSetEquals_IEnumerable_d_T_p_
		{
			get
			{
				if(r_MSetEquals_IEnumerable_d_T_p_ == null)
				{
					r_MSetEquals_IEnumerable_d_T_p_ = new(this, "SetEquals", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MSetEquals_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_MSetEquals_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Void CopyTo(T[])
		/// </summary>
		protected RMethod r_MCopyTo_TArray;
		public virtual RMethod RMCopyTo_TArray
		{
			get
			{
				if(r_MCopyTo_TArray == null)
				{
					r_MCopyTo_TArray = new(this, "CopyTo", 0, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_MCopyTo_TArray.SetBelong(this.instance);
				}
				return r_MCopyTo_TArray;
			}
		}

		/// <summary>
		/// Void CopyTo(T[], Int32, Int32)
		/// </summary>
		protected RMethod r_MCopyTo_TArray_Int32_Int32;
		public virtual RMethod RMCopyTo_TArray_Int32_Int32
		{
			get
			{
				if(r_MCopyTo_TArray_Int32_Int32 == null)
				{
					r_MCopyTo_TArray_Int32_Int32 = new(this, "CopyTo", 0, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MCopyTo_TArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_MCopyTo_TArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 RemoveWhere(System.Predicate`1[T])
		/// </summary>
		protected RMethod r_MRemoveWhere_Predicate_d_T_p_;
		public virtual RMethod RMRemoveWhere_Predicate_d_T_p_
		{
			get
			{
				if(r_MRemoveWhere_Predicate_d_T_p_ == null)
				{
					r_MRemoveWhere_Predicate_d_T_p_ = new(this, "RemoveWhere", 0, typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MRemoveWhere_Predicate_d_T_p_.SetBelong(this.instance);
				}
				return r_MRemoveWhere_Predicate_d_T_p_;
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
					r_MEnsureCapacity_Int32.SetBelong(this.instance);
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
					r_MTrimExcess.SetBelong(this.instance);
				}
				return r_MTrimExcess;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEqualityComparer`1[System.Collections.Generic.HashSet`1[T]] CreateSetComparer()
		/// </summary>
		protected static RMethod r_MCreateSetComparer;
		public static RMethod RMCreateSetComparer
		{
			get
			{
				if(r_MCreateSetComparer == null)
				{
					r_MCreateSetComparer = new(typeof(System.Collections.Generic.HashSet<>), "CreateSetComparer", 0);
					r_MCreateSetComparer.SetBelong(null);
				}
				return r_MCreateSetComparer;
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
					r_MInitialize_Int32.SetBelong(this.instance);
				}
				return r_MInitialize_Int32;
			}
		}

		/// <summary>
		/// Void IncreaseCapacity()
		/// </summary>
		protected RMethod r_MIncreaseCapacity;
		public virtual RMethod RMIncreaseCapacity
		{
			get
			{
				if(r_MIncreaseCapacity == null)
				{
					r_MIncreaseCapacity = new(this, "IncreaseCapacity", 0);
					r_MIncreaseCapacity.SetBelong(this.instance);
				}
				return r_MIncreaseCapacity;
			}
		}

		/// <summary>
		/// Void SetCapacity(Int32)
		/// </summary>
		protected RMethod r_MSetCapacity_Int32;
		public virtual RMethod RMSetCapacity_Int32
		{
			get
			{
				if(r_MSetCapacity_Int32 == null)
				{
					r_MSetCapacity_Int32 = new(this, "SetCapacity", 0, typeof(System.Int32));
					r_MSetCapacity_Int32.SetBelong(this.instance);
				}
				return r_MSetCapacity_Int32;
			}
		}

		/// <summary>
		/// Boolean AddIfNotPresent(T)
		/// </summary>
		protected RMethod r_MAddIfNotPresent_T;
		public virtual RMethod RMAddIfNotPresent_T
		{
			get
			{
				if(r_MAddIfNotPresent_T == null)
				{
					r_MAddIfNotPresent_T = new(this, "AddIfNotPresent", 0, Type.MakeGenericMethodParameter(0));
					r_MAddIfNotPresent_T.SetBelong(this.instance);
				}
				return r_MAddIfNotPresent_T;
			}
		}

		/// <summary>
		/// Void AddValue(Int32, Int32, T)
		/// </summary>
		protected RMethod r_MAddValue_Int32_Int32_T;
		public virtual RMethod RMAddValue_Int32_Int32_T
		{
			get
			{
				if(r_MAddValue_Int32_Int32_T == null)
				{
					r_MAddValue_Int32_Int32_T = new(this, "AddValue", 0, typeof(System.Int32), typeof(System.Int32), Type.MakeGenericMethodParameter(0));
					r_MAddValue_Int32_Int32_T.SetBelong(this.instance);
				}
				return r_MAddValue_Int32_Int32_T;
			}
		}

		/// <summary>
		/// Boolean ContainsAllElements(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_MContainsAllElements_IEnumerable_d_T_p_;
		public virtual RMethod RMContainsAllElements_IEnumerable_d_T_p_
		{
			get
			{
				if(r_MContainsAllElements_IEnumerable_d_T_p_ == null)
				{
					r_MContainsAllElements_IEnumerable_d_T_p_ = new(this, "ContainsAllElements", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MContainsAllElements_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_MContainsAllElements_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean IsSubsetOfHashSetWithSameEC(System.Collections.Generic.HashSet`1[T])
		/// </summary>
		protected RMethod r_MIsSubsetOfHashSetWithSameEC_HashSet_d_T_p_;
		public virtual RMethod RMIsSubsetOfHashSetWithSameEC_HashSet_d_T_p_
		{
			get
			{
				if(r_MIsSubsetOfHashSetWithSameEC_HashSet_d_T_p_ == null)
				{
					r_MIsSubsetOfHashSetWithSameEC_HashSet_d_T_p_ = new(this, "IsSubsetOfHashSetWithSameEC", 0, typeof(System.Collections.Generic.HashSet<>));
					r_MIsSubsetOfHashSetWithSameEC_HashSet_d_T_p_.SetBelong(this.instance);
				}
				return r_MIsSubsetOfHashSetWithSameEC_HashSet_d_T_p_;
			}
		}

		/// <summary>
		/// Void IntersectWithHashSetWithSameEC(System.Collections.Generic.HashSet`1[T])
		/// </summary>
		protected RMethod r_MIntersectWithHashSetWithSameEC_HashSet_d_T_p_;
		public virtual RMethod RMIntersectWithHashSetWithSameEC_HashSet_d_T_p_
		{
			get
			{
				if(r_MIntersectWithHashSetWithSameEC_HashSet_d_T_p_ == null)
				{
					r_MIntersectWithHashSetWithSameEC_HashSet_d_T_p_ = new(this, "IntersectWithHashSetWithSameEC", 0, typeof(System.Collections.Generic.HashSet<>));
					r_MIntersectWithHashSetWithSameEC_HashSet_d_T_p_.SetBelong(this.instance);
				}
				return r_MIntersectWithHashSetWithSameEC_HashSet_d_T_p_;
			}
		}

		/// <summary>
		/// Void IntersectWithEnumerable(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_MIntersectWithEnumerable_IEnumerable_d_T_p_;
		public virtual RMethod RMIntersectWithEnumerable_IEnumerable_d_T_p_
		{
			get
			{
				if(r_MIntersectWithEnumerable_IEnumerable_d_T_p_ == null)
				{
					r_MIntersectWithEnumerable_IEnumerable_d_T_p_ = new(this, "IntersectWithEnumerable", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MIntersectWithEnumerable_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_MIntersectWithEnumerable_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 InternalIndexOf(T)
		/// </summary>
		protected RMethod r_MInternalIndexOf_T;
		public virtual RMethod RMInternalIndexOf_T
		{
			get
			{
				if(r_MInternalIndexOf_T == null)
				{
					r_MInternalIndexOf_T = new(this, "InternalIndexOf", 0, Type.MakeGenericMethodParameter(0));
					r_MInternalIndexOf_T.SetBelong(this.instance);
				}
				return r_MInternalIndexOf_T;
			}
		}

		/// <summary>
		/// Void SymmetricExceptWithUniqueHashSet(System.Collections.Generic.HashSet`1[T])
		/// </summary>
		protected RMethod r_MSymmetricExceptWithUniqueHashSet_HashSet_d_T_p_;
		public virtual RMethod RMSymmetricExceptWithUniqueHashSet_HashSet_d_T_p_
		{
			get
			{
				if(r_MSymmetricExceptWithUniqueHashSet_HashSet_d_T_p_ == null)
				{
					r_MSymmetricExceptWithUniqueHashSet_HashSet_d_T_p_ = new(this, "SymmetricExceptWithUniqueHashSet", 0, typeof(System.Collections.Generic.HashSet<>));
					r_MSymmetricExceptWithUniqueHashSet_HashSet_d_T_p_.SetBelong(this.instance);
				}
				return r_MSymmetricExceptWithUniqueHashSet_HashSet_d_T_p_;
			}
		}

		/// <summary>
		/// Void SymmetricExceptWithEnumerable(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_MSymmetricExceptWithEnumerable_IEnumerable_d_T_p_;
		public virtual RMethod RMSymmetricExceptWithEnumerable_IEnumerable_d_T_p_
		{
			get
			{
				if(r_MSymmetricExceptWithEnumerable_IEnumerable_d_T_p_ == null)
				{
					r_MSymmetricExceptWithEnumerable_IEnumerable_d_T_p_ = new(this, "SymmetricExceptWithEnumerable", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MSymmetricExceptWithEnumerable_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_MSymmetricExceptWithEnumerable_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean AddOrGetLocation(T, Int32 ByRef)
		/// </summary>
		protected RMethod r_MAddOrGetLocation_T_Out_Int32;
		public virtual RMethod RMAddOrGetLocation_T_Out_Int32
		{
			get
			{
				if(r_MAddOrGetLocation_T_Out_Int32 == null)
				{
					r_MAddOrGetLocation_T_Out_Int32 = new(this, "AddOrGetLocation", 0, Type.MakeGenericMethodParameter(0), typeof(System.Int32).MakeByRefType());
					r_MAddOrGetLocation_T_Out_Int32.SetBelong(this.instance);
				}
				return r_MAddOrGetLocation_T_Out_Int32;
			}
		}

		/// <summary>
		/// ElementCount CheckUniqueAndUnfoundElements(System.Collections.Generic.IEnumerable`1[T], Boolean)
		/// </summary>
		protected RMethod r_MCheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean;
		public virtual RMethod RMCheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean
		{
			get
			{
				if(r_MCheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean == null)
				{
					r_MCheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean = new(this, "CheckUniqueAndUnfoundElements", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Boolean));
					r_MCheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean.SetBelong(this.instance);
				}
				return r_MCheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean;
			}
		}

		/// <summary>
		/// Boolean HashSetEquals(System.Collections.Generic.HashSet`1[T], System.Collections.Generic.HashSet`1[T], System.Collections.Generic.IEqualityComparer`1[T])
		/// </summary>
		protected static RMethod r_MHashSetEquals_HashSet_d_T_p__HashSet_d_T_p__IEqualityComparer_d_T_p_;
		public static RMethod RMHashSetEquals_HashSet_d_T_p__HashSet_d_T_p__IEqualityComparer_d_T_p_
		{
			get
			{
				if(r_MHashSetEquals_HashSet_d_T_p__HashSet_d_T_p__IEqualityComparer_d_T_p_ == null)
				{
					r_MHashSetEquals_HashSet_d_T_p__HashSet_d_T_p__IEqualityComparer_d_T_p_ = new(typeof(System.Collections.Generic.HashSet<>), "HashSetEquals", 0, typeof(System.Collections.Generic.HashSet<>), typeof(System.Collections.Generic.HashSet<>), typeof(System.Collections.Generic.IEqualityComparer<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MHashSetEquals_HashSet_d_T_p__HashSet_d_T_p__IEqualityComparer_d_T_p_.SetBelong(null);
				}
				return r_MHashSetEquals_HashSet_d_T_p__HashSet_d_T_p__IEqualityComparer_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean AreEqualityComparersEqual(System.Collections.Generic.HashSet`1[T], System.Collections.Generic.HashSet`1[T])
		/// </summary>
		protected static RMethod r_MAreEqualityComparersEqual_HashSet_d_T_p__HashSet_d_T_p_;
		public static RMethod RMAreEqualityComparersEqual_HashSet_d_T_p__HashSet_d_T_p_
		{
			get
			{
				if(r_MAreEqualityComparersEqual_HashSet_d_T_p__HashSet_d_T_p_ == null)
				{
					r_MAreEqualityComparersEqual_HashSet_d_T_p__HashSet_d_T_p_ = new(typeof(System.Collections.Generic.HashSet<>), "AreEqualityComparersEqual", 0, typeof(System.Collections.Generic.HashSet<>), typeof(System.Collections.Generic.HashSet<>));
					r_MAreEqualityComparersEqual_HashSet_d_T_p__HashSet_d_T_p_.SetBelong(null);
				}
				return r_MAreEqualityComparersEqual_HashSet_d_T_p__HashSet_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 InternalGetHashCode(T)
		/// </summary>
		protected RMethod r_MInternalGetHashCode_T;
		public virtual RMethod RMInternalGetHashCode_T
		{
			get
			{
				if(r_MInternalGetHashCode_T == null)
				{
					r_MInternalGetHashCode_T = new(this, "InternalGetHashCode", 0, Type.MakeGenericMethodParameter(0));
					r_MInternalGetHashCode_T.SetBelong(this.instance);
				}
				return r_MInternalGetHashCode_T;
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


        public RHashSet() : base("System.Collections.Generic.HashSet`1")
        {
        }

        public RHashSet(System.Object instance) : base("System.Collections.Generic.HashSet`1")
		{
            SetInstance(instance);
		}

        public RHashSet(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RHashSet(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void CopyFrom(System.Collections.Generic.HashSet<T> @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source};
            var ___result = RMCopyFrom_HashSet_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Add(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Add_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Contains(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMContains_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CopyTo(T[] @array, System.Int32 @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RMCopyTo_TArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Remove(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMRemove_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RType>.REnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RType>.REnumerator(___result);
        }


        public virtual System.Collections.Generic.IEnumerator<T> System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerator<T>)___result;
        }


        public virtual System.Collections.IEnumerator System__2__Collections__2__IEnumerable__2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
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


        public virtual System.Boolean Add(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMAdd_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetValue(T @equalValue, out T @actualValue)
        {
			@actualValue = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@equalValue, @actualValue};
            var ___result = RMTryGetValue_T_Out_T.Invoke(___genericsType, ___parameters);
			@actualValue = (T)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual void UnionWith(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMUnionWith_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IntersectWith(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMIntersectWith_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExceptWith(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMExceptWith_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SymmetricExceptWith(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMSymmetricExceptWith_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsSubsetOf(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMIsSubsetOf_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsProperSubsetOf(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMIsProperSubsetOf_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsSupersetOf(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMIsSupersetOf_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsProperSupersetOf(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMIsProperSupersetOf_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Overlaps(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMOverlaps_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SetEquals(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMSetEquals_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CopyTo(T[] @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array};
            var ___result = RMCopyTo_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(T[] @array, System.Int32 @arrayIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex, @count};
            var ___result = RMCopyTo_TArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 RemoveWhere(System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@match};
            var ___result = RMRemoveWhere_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public static System.Collections.Generic.IEqualityComparer<System.Collections.Generic.HashSet<T>> CreateSetComparer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateSetComparer.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEqualityComparer<System.Collections.Generic.HashSet<T>>)___result;
        }


        public virtual System.Int32 Initialize(System.Int32 @capacity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@capacity};
            var ___result = RMInitialize_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void IncreaseCapacity()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIncreaseCapacity.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCapacity(System.Int32 @newSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newSize};
            var ___result = RMSetCapacity_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean AddIfNotPresent(T @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAddIfNotPresent_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void AddValue(System.Int32 @index, System.Int32 @hashCode, T @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @hashCode, @value};
            var ___result = RMAddValue_Int32_Int32_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ContainsAllElements(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMContainsAllElements_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsSubsetOfHashSetWithSameEC(System.Collections.Generic.HashSet<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMIsSubsetOfHashSetWithSameEC_HashSet_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void IntersectWithHashSetWithSameEC(System.Collections.Generic.HashSet<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMIntersectWithHashSetWithSameEC_HashSet_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IntersectWithEnumerable(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMIntersectWithEnumerable_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 InternalIndexOf(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMInternalIndexOf_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SymmetricExceptWithUniqueHashSet(System.Collections.Generic.HashSet<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMSymmetricExceptWithUniqueHashSet_HashSet_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SymmetricExceptWithEnumerable(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMSymmetricExceptWithEnumerable_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean AddOrGetLocation(T @value, out System.Int32 @location)
        {
			@location = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @location};
            var ___result = RMAddOrGetLocation_T_Out_Int32.Invoke(___genericsType, ___parameters);
			@location = (System.Int32)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RType>.RElementCount CheckUniqueAndUnfoundElements(System.Collections.Generic.IEnumerable<T> @other, System.Boolean @returnIfUnfound)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other, @returnIfUnfound};
            var ___result = RMCheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RType>.RElementCount(___result);
        }


        public static System.Boolean HashSetEquals(System.Collections.Generic.HashSet<T> @set1, System.Collections.Generic.HashSet<T> @set2, System.Collections.Generic.IEqualityComparer<T> @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@set1, @set2, @comparer};
            var ___result = RMHashSetEquals_HashSet_d_T_p__HashSet_d_T_p__IEqualityComparer_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean AreEqualityComparersEqual(System.Collections.Generic.HashSet<T> @set1, System.Collections.Generic.HashSet<T> @set2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@set1, @set2};
            var ___result = RMAreEqualityComparersEqual_HashSet_d_T_p__HashSet_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 InternalGetHashCode(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMInternalGetHashCode_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
