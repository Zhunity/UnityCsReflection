using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
	/// System.Collections.Generic.HashSet`1
	/// </summary>
    public partial class RHashSet<T> : RMember //
    {

		/// <summary>
		/// System.Int32 Lower31BitMask
		/// </summary>
		protected static RField r_Lower31BitMask;
		public static RField RLower31BitMask
		{
			get
			{
				if(r_Lower31BitMask == null)
				{
					r_Lower31BitMask = new(typeof(System.Collections.Generic.HashSet<>), "Lower31BitMask");
					r_Lower31BitMask.SetBelong(null);
				}
				return r_Lower31BitMask;
			}
		}

		/// <summary>
		/// System.Int32 StackAllocThreshold
		/// </summary>
		protected static RField r_StackAllocThreshold;
		public static RField RStackAllocThreshold
		{
			get
			{
				if(r_StackAllocThreshold == null)
				{
					r_StackAllocThreshold = new(typeof(System.Collections.Generic.HashSet<>), "StackAllocThreshold");
					r_StackAllocThreshold.SetBelong(null);
				}
				return r_StackAllocThreshold;
			}
		}

		/// <summary>
		/// System.Int32 ShrinkThreshold
		/// </summary>
		protected static RField r_ShrinkThreshold;
		public static RField RShrinkThreshold
		{
			get
			{
				if(r_ShrinkThreshold == null)
				{
					r_ShrinkThreshold = new(typeof(System.Collections.Generic.HashSet<>), "ShrinkThreshold");
					r_ShrinkThreshold.SetBelong(null);
				}
				return r_ShrinkThreshold;
			}
		}

		/// <summary>
		/// System.String CapacityName
		/// </summary>
		protected static RField r_CapacityName;
		public static RField RCapacityName
		{
			get
			{
				if(r_CapacityName == null)
				{
					r_CapacityName = new(typeof(System.Collections.Generic.HashSet<>), "CapacityName");
					r_CapacityName.SetBelong(null);
				}
				return r_CapacityName;
			}
		}

		/// <summary>
		/// System.String ElementsName
		/// </summary>
		protected static RField r_ElementsName;
		public static RField RElementsName
		{
			get
			{
				if(r_ElementsName == null)
				{
					r_ElementsName = new(typeof(System.Collections.Generic.HashSet<>), "ElementsName");
					r_ElementsName.SetBelong(null);
				}
				return r_ElementsName;
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
					r_ComparerName = new(typeof(System.Collections.Generic.HashSet<>), "ComparerName");
					r_ComparerName.SetBelong(null);
				}
				return r_ComparerName;
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
					r_VersionName = new(typeof(System.Collections.Generic.HashSet<>), "VersionName");
					r_VersionName.SetBelong(null);
				}
				return r_VersionName;
			}
		}

		/// <summary>
		/// System.Int32[] _buckets
		/// </summary>
		protected RFieldArray<RField> r__buckets;
		public virtual RFieldArray<RField> R_buckets
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
		/// System.Collections.Generic.HashSet`1+Slot[T][] _slots
		/// </summary>
		protected RFieldArray<RSystem.RCollections.RGeneric.RHashSet<RField>.RSlot> r__slots;
		public virtual RFieldArray<RSystem.RCollections.RGeneric.RHashSet<RField>.RSlot> R_slots
		{
			get
			{
				if(r__slots == null)
				{
					r__slots = new(this, "_slots");
					r__slots.SetBelong(this.instance);
				}
				return r__slots;
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
		/// System.Int32 _lastIndex
		/// </summary>
		protected RField r__lastIndex;
		public virtual RField R_lastIndex
		{
			get
			{
				if(r__lastIndex == null)
				{
					r__lastIndex = new(this, "_lastIndex");
					r__lastIndex.SetBelong(this.instance);
				}
				return r__lastIndex;
			}
		}

		/// <summary>
		/// System.Int32 _freeList
		/// </summary>
		protected RField r__freeList;
		public virtual RField R_freeList
		{
			get
			{
				if(r__freeList == null)
				{
					r__freeList = new(this, "_freeList");
					r__freeList.SetBelong(this.instance);
				}
				return r__freeList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEqualityComparer`1[T] _comparer
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEqualityComparer<RField> r__comparer;
		public virtual RSystem.RCollections.RGeneric.RIEqualityComparer<RField> R_comparer
		{
			get
			{
				if(r__comparer == null)
				{
					r__comparer = new(this, "_comparer");
					r__comparer.SetBelong(this.instance);
				}
				return r__comparer;
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
		/// System.Runtime.Serialization.SerializationInfo _siInfo
		/// </summary>
		protected RSystem.RRuntime.RSerialization.RSerializationInfo r__siInfo;
		public virtual RSystem.RRuntime.RSerialization.RSerializationInfo R_siInfo
		{
			get
			{
				if(r__siInfo == null)
				{
					r__siInfo = new(this, "_siInfo");
					r__siInfo.SetBelong(this.instance);
				}
				return r__siInfo;
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
		/// Boolean System.Collections.Generic.ICollection<T>.IsReadOnly
		/// </summary>
		protected RProperty r_RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__get_IsReadOnly;
		public virtual RProperty RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__get_IsReadOnly
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__get_IsReadOnly == null)
				{
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__get_IsReadOnly = new(this, "System.Collections.Generic.ICollection<T>.IsReadOnly", -1);
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__get_IsReadOnly.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__get_IsReadOnly;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEqualityComparer`1[T] Comparer
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEqualityComparer<RProperty> r_Comparer;
		public virtual RSystem.RCollections.RGeneric.RIEqualityComparer<RProperty> RComparer
		{
			get
			{
				if(r_Comparer == null)
				{
					r_Comparer = new(this, "Comparer", -1);
					r_Comparer.SetBelong(this.instance);
				}
				return r_Comparer;
			}
		}

		/// <summary>
		/// Void CopyFrom(System.Collections.Generic.HashSet`1[T])
		/// </summary>
		protected RMethod r_RCopyFrom_HashSet_d_T_p_;
		public virtual RMethod RCopyFrom_HashSet_d_T_p_
		{
			get
			{
				if(r_RCopyFrom_HashSet_d_T_p_ == null)
				{
					r_RCopyFrom_HashSet_d_T_p_ = new(this, "CopyFrom", 0, typeof(System.Collections.Generic.HashSet<>));
					r_RCopyFrom_HashSet_d_T_p_.SetBelong(this.instance);
				}
				return r_RCopyFrom_HashSet_d_T_p_;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.ICollection<T>.Add(T)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Add_T;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Add_T
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Add_T == null)
				{
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Add_T = new(this, "System.Collections.Generic.ICollection<T>.Add", 0, Type.MakeGenericMethodParameter(0));
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Add_T.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Add_T;
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
		/// Boolean Contains(T)
		/// </summary>
		protected RMethod r_RContains_T;
		public virtual RMethod RContains_T
		{
			get
			{
				if(r_RContains_T == null)
				{
					r_RContains_T = new(this, "Contains", 0, Type.MakeGenericMethodParameter(0));
					r_RContains_T.SetBelong(this.instance);
				}
				return r_RContains_T;
			}
		}

		/// <summary>
		/// Void CopyTo(T[], Int32)
		/// </summary>
		protected RMethod r_RCopyTo_TArray_Int32;
		public virtual RMethod RCopyTo_TArray_Int32
		{
			get
			{
				if(r_RCopyTo_TArray_Int32 == null)
				{
					r_RCopyTo_TArray_Int32 = new(this, "CopyTo", 0, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32));
					r_RCopyTo_TArray_Int32.SetBelong(this.instance);
				}
				return r_RCopyTo_TArray_Int32;
			}
		}

		/// <summary>
		/// Boolean Remove(T)
		/// </summary>
		protected RMethod r_RRemove_T;
		public virtual RMethod RRemove_T
		{
			get
			{
				if(r_RRemove_T == null)
				{
					r_RRemove_T = new(this, "Remove", 0, Type.MakeGenericMethodParameter(0));
					r_RRemove_T.SetBelong(this.instance);
				}
				return r_RRemove_T;
			}
		}

		/// <summary>
		/// Enumerator GetEnumerator()
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
		/// System.Collections.Generic.IEnumerator`1[T] System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__IEnumerable__1__T__2____0__GetEnumerator;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__IEnumerable__1__T__2____0__GetEnumerator
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__IEnumerable__1__T__2____0__GetEnumerator == null)
				{
					r_RSystem__0__Collections__0__Generic__0__IEnumerable__1__T__2____0__GetEnumerator = new(this, "System.Collections.Generic.IEnumerable<T>.GetEnumerator", 0);
					r_RSystem__0__Collections__0__Generic__0__IEnumerable__1__T__2____0__GetEnumerator.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__IEnumerable__1__T__2____0__GetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__IEnumerable__0__GetEnumerator;
		public virtual RMethod RSystem__0__Collections__0__IEnumerable__0__GetEnumerator
		{
			get
			{
				if(r_RSystem__0__Collections__0__IEnumerable__0__GetEnumerator == null)
				{
					r_RSystem__0__Collections__0__IEnumerable__0__GetEnumerator = new(this, "System.Collections.IEnumerable.GetEnumerator", 0);
					r_RSystem__0__Collections__0__IEnumerable__0__GetEnumerator.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IEnumerable__0__GetEnumerator;
			}
		}

		/// <summary>
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_RGetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_RGetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_RGetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_RGetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_RGetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Void OnDeserialization(System.Object)
		/// </summary>
		protected RMethod r_ROnDeserialization_Object;
		public virtual RMethod ROnDeserialization_Object
		{
			get
			{
				if(r_ROnDeserialization_Object == null)
				{
					r_ROnDeserialization_Object = new(this, "OnDeserialization", 0, typeof(System.Object));
					r_ROnDeserialization_Object.SetBelong(this.instance);
				}
				return r_ROnDeserialization_Object;
			}
		}

		/// <summary>
		/// Boolean Add(T)
		/// </summary>
		protected RMethod r_RAdd_T;
		public virtual RMethod RAdd_T
		{
			get
			{
				if(r_RAdd_T == null)
				{
					r_RAdd_T = new(this, "Add", 0, Type.MakeGenericMethodParameter(0));
					r_RAdd_T.SetBelong(this.instance);
				}
				return r_RAdd_T;
			}
		}

		/// <summary>
		/// Boolean TryGetValue(T, T ByRef)
		/// </summary>
		protected RMethod r_RTryGetValue_T_Out_T;
		public virtual RMethod RTryGetValue_T_Out_T
		{
			get
			{
				if(r_RTryGetValue_T_Out_T == null)
				{
					r_RTryGetValue_T_Out_T = new(this, "TryGetValue", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_RTryGetValue_T_Out_T.SetBelong(this.instance);
				}
				return r_RTryGetValue_T_Out_T;
			}
		}

		/// <summary>
		/// Void UnionWith(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RUnionWith_IEnumerable_d_T_p_;
		public virtual RMethod RUnionWith_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RUnionWith_IEnumerable_d_T_p_ == null)
				{
					r_RUnionWith_IEnumerable_d_T_p_ = new(this, "UnionWith", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RUnionWith_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RUnionWith_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Void IntersectWith(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RIntersectWith_IEnumerable_d_T_p_;
		public virtual RMethod RIntersectWith_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RIntersectWith_IEnumerable_d_T_p_ == null)
				{
					r_RIntersectWith_IEnumerable_d_T_p_ = new(this, "IntersectWith", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RIntersectWith_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RIntersectWith_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Void ExceptWith(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RExceptWith_IEnumerable_d_T_p_;
		public virtual RMethod RExceptWith_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RExceptWith_IEnumerable_d_T_p_ == null)
				{
					r_RExceptWith_IEnumerable_d_T_p_ = new(this, "ExceptWith", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RExceptWith_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RExceptWith_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Void SymmetricExceptWith(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RSymmetricExceptWith_IEnumerable_d_T_p_;
		public virtual RMethod RSymmetricExceptWith_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RSymmetricExceptWith_IEnumerable_d_T_p_ == null)
				{
					r_RSymmetricExceptWith_IEnumerable_d_T_p_ = new(this, "SymmetricExceptWith", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RSymmetricExceptWith_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RSymmetricExceptWith_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean IsSubsetOf(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RIsSubsetOf_IEnumerable_d_T_p_;
		public virtual RMethod RIsSubsetOf_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RIsSubsetOf_IEnumerable_d_T_p_ == null)
				{
					r_RIsSubsetOf_IEnumerable_d_T_p_ = new(this, "IsSubsetOf", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RIsSubsetOf_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RIsSubsetOf_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean IsProperSubsetOf(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RIsProperSubsetOf_IEnumerable_d_T_p_;
		public virtual RMethod RIsProperSubsetOf_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RIsProperSubsetOf_IEnumerable_d_T_p_ == null)
				{
					r_RIsProperSubsetOf_IEnumerable_d_T_p_ = new(this, "IsProperSubsetOf", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RIsProperSubsetOf_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RIsProperSubsetOf_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean IsSupersetOf(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RIsSupersetOf_IEnumerable_d_T_p_;
		public virtual RMethod RIsSupersetOf_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RIsSupersetOf_IEnumerable_d_T_p_ == null)
				{
					r_RIsSupersetOf_IEnumerable_d_T_p_ = new(this, "IsSupersetOf", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RIsSupersetOf_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RIsSupersetOf_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean IsProperSupersetOf(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RIsProperSupersetOf_IEnumerable_d_T_p_;
		public virtual RMethod RIsProperSupersetOf_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RIsProperSupersetOf_IEnumerable_d_T_p_ == null)
				{
					r_RIsProperSupersetOf_IEnumerable_d_T_p_ = new(this, "IsProperSupersetOf", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RIsProperSupersetOf_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RIsProperSupersetOf_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean Overlaps(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_ROverlaps_IEnumerable_d_T_p_;
		public virtual RMethod ROverlaps_IEnumerable_d_T_p_
		{
			get
			{
				if(r_ROverlaps_IEnumerable_d_T_p_ == null)
				{
					r_ROverlaps_IEnumerable_d_T_p_ = new(this, "Overlaps", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_ROverlaps_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_ROverlaps_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean SetEquals(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RSetEquals_IEnumerable_d_T_p_;
		public virtual RMethod RSetEquals_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RSetEquals_IEnumerable_d_T_p_ == null)
				{
					r_RSetEquals_IEnumerable_d_T_p_ = new(this, "SetEquals", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RSetEquals_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RSetEquals_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Void CopyTo(T[])
		/// </summary>
		protected RMethod r_RCopyTo_TArray;
		public virtual RMethod RCopyTo_TArray
		{
			get
			{
				if(r_RCopyTo_TArray == null)
				{
					r_RCopyTo_TArray = new(this, "CopyTo", 0, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_RCopyTo_TArray.SetBelong(this.instance);
				}
				return r_RCopyTo_TArray;
			}
		}

		/// <summary>
		/// Void CopyTo(T[], Int32, Int32)
		/// </summary>
		protected RMethod r_RCopyTo_TArray_Int32_Int32;
		public virtual RMethod RCopyTo_TArray_Int32_Int32
		{
			get
			{
				if(r_RCopyTo_TArray_Int32_Int32 == null)
				{
					r_RCopyTo_TArray_Int32_Int32 = new(this, "CopyTo", 0, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RCopyTo_TArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RCopyTo_TArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 RemoveWhere(System.Predicate`1[T])
		/// </summary>
		protected RMethod r_RRemoveWhere_Predicate_d_T_p_;
		public virtual RMethod RRemoveWhere_Predicate_d_T_p_
		{
			get
			{
				if(r_RRemoveWhere_Predicate_d_T_p_ == null)
				{
					r_RRemoveWhere_Predicate_d_T_p_ = new(this, "RemoveWhere", 0, typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RRemoveWhere_Predicate_d_T_p_.SetBelong(this.instance);
				}
				return r_RRemoveWhere_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 EnsureCapacity(Int32)
		/// </summary>
		protected RMethod r_REnsureCapacity_Int32;
		public virtual RMethod REnsureCapacity_Int32
		{
			get
			{
				if(r_REnsureCapacity_Int32 == null)
				{
					r_REnsureCapacity_Int32 = new(this, "EnsureCapacity", 0, typeof(System.Int32));
					r_REnsureCapacity_Int32.SetBelong(this.instance);
				}
				return r_REnsureCapacity_Int32;
			}
		}

		/// <summary>
		/// Void TrimExcess()
		/// </summary>
		protected RMethod r_RTrimExcess;
		public virtual RMethod RTrimExcess
		{
			get
			{
				if(r_RTrimExcess == null)
				{
					r_RTrimExcess = new(this, "TrimExcess", 0);
					r_RTrimExcess.SetBelong(this.instance);
				}
				return r_RTrimExcess;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEqualityComparer`1[System.Collections.Generic.HashSet`1[T]] CreateSetComparer()
		/// </summary>
		protected static RMethod r_RCreateSetComparer;
		public static RMethod RCreateSetComparer
		{
			get
			{
				if(r_RCreateSetComparer == null)
				{
					r_RCreateSetComparer = new(typeof(System.Collections.Generic.HashSet<>), "CreateSetComparer", 0);
					r_RCreateSetComparer.SetBelong(null);
				}
				return r_RCreateSetComparer;
			}
		}

		/// <summary>
		/// Int32 Initialize(Int32)
		/// </summary>
		protected RMethod r_RInitialize_Int32;
		public virtual RMethod RInitialize_Int32
		{
			get
			{
				if(r_RInitialize_Int32 == null)
				{
					r_RInitialize_Int32 = new(this, "Initialize", 0, typeof(System.Int32));
					r_RInitialize_Int32.SetBelong(this.instance);
				}
				return r_RInitialize_Int32;
			}
		}

		/// <summary>
		/// Void IncreaseCapacity()
		/// </summary>
		protected RMethod r_RIncreaseCapacity;
		public virtual RMethod RIncreaseCapacity
		{
			get
			{
				if(r_RIncreaseCapacity == null)
				{
					r_RIncreaseCapacity = new(this, "IncreaseCapacity", 0);
					r_RIncreaseCapacity.SetBelong(this.instance);
				}
				return r_RIncreaseCapacity;
			}
		}

		/// <summary>
		/// Void SetCapacity(Int32)
		/// </summary>
		protected RMethod r_RSetCapacity_Int32;
		public virtual RMethod RSetCapacity_Int32
		{
			get
			{
				if(r_RSetCapacity_Int32 == null)
				{
					r_RSetCapacity_Int32 = new(this, "SetCapacity", 0, typeof(System.Int32));
					r_RSetCapacity_Int32.SetBelong(this.instance);
				}
				return r_RSetCapacity_Int32;
			}
		}

		/// <summary>
		/// Boolean AddIfNotPresent(T)
		/// </summary>
		protected RMethod r_RAddIfNotPresent_T;
		public virtual RMethod RAddIfNotPresent_T
		{
			get
			{
				if(r_RAddIfNotPresent_T == null)
				{
					r_RAddIfNotPresent_T = new(this, "AddIfNotPresent", 0, Type.MakeGenericMethodParameter(0));
					r_RAddIfNotPresent_T.SetBelong(this.instance);
				}
				return r_RAddIfNotPresent_T;
			}
		}

		/// <summary>
		/// Void AddValue(Int32, Int32, T)
		/// </summary>
		protected RMethod r_RAddValue_Int32_Int32_T;
		public virtual RMethod RAddValue_Int32_Int32_T
		{
			get
			{
				if(r_RAddValue_Int32_Int32_T == null)
				{
					r_RAddValue_Int32_Int32_T = new(this, "AddValue", 0, typeof(System.Int32), typeof(System.Int32), Type.MakeGenericMethodParameter(0));
					r_RAddValue_Int32_Int32_T.SetBelong(this.instance);
				}
				return r_RAddValue_Int32_Int32_T;
			}
		}

		/// <summary>
		/// Boolean ContainsAllElements(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RContainsAllElements_IEnumerable_d_T_p_;
		public virtual RMethod RContainsAllElements_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RContainsAllElements_IEnumerable_d_T_p_ == null)
				{
					r_RContainsAllElements_IEnumerable_d_T_p_ = new(this, "ContainsAllElements", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RContainsAllElements_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RContainsAllElements_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean IsSubsetOfHashSetWithSameEC(System.Collections.Generic.HashSet`1[T])
		/// </summary>
		protected RMethod r_RIsSubsetOfHashSetWithSameEC_HashSet_d_T_p_;
		public virtual RMethod RIsSubsetOfHashSetWithSameEC_HashSet_d_T_p_
		{
			get
			{
				if(r_RIsSubsetOfHashSetWithSameEC_HashSet_d_T_p_ == null)
				{
					r_RIsSubsetOfHashSetWithSameEC_HashSet_d_T_p_ = new(this, "IsSubsetOfHashSetWithSameEC", 0, typeof(System.Collections.Generic.HashSet<>));
					r_RIsSubsetOfHashSetWithSameEC_HashSet_d_T_p_.SetBelong(this.instance);
				}
				return r_RIsSubsetOfHashSetWithSameEC_HashSet_d_T_p_;
			}
		}

		/// <summary>
		/// Void IntersectWithHashSetWithSameEC(System.Collections.Generic.HashSet`1[T])
		/// </summary>
		protected RMethod r_RIntersectWithHashSetWithSameEC_HashSet_d_T_p_;
		public virtual RMethod RIntersectWithHashSetWithSameEC_HashSet_d_T_p_
		{
			get
			{
				if(r_RIntersectWithHashSetWithSameEC_HashSet_d_T_p_ == null)
				{
					r_RIntersectWithHashSetWithSameEC_HashSet_d_T_p_ = new(this, "IntersectWithHashSetWithSameEC", 0, typeof(System.Collections.Generic.HashSet<>));
					r_RIntersectWithHashSetWithSameEC_HashSet_d_T_p_.SetBelong(this.instance);
				}
				return r_RIntersectWithHashSetWithSameEC_HashSet_d_T_p_;
			}
		}

		/// <summary>
		/// Void IntersectWithEnumerable(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RIntersectWithEnumerable_IEnumerable_d_T_p_;
		public virtual RMethod RIntersectWithEnumerable_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RIntersectWithEnumerable_IEnumerable_d_T_p_ == null)
				{
					r_RIntersectWithEnumerable_IEnumerable_d_T_p_ = new(this, "IntersectWithEnumerable", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RIntersectWithEnumerable_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RIntersectWithEnumerable_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 InternalIndexOf(T)
		/// </summary>
		protected RMethod r_RInternalIndexOf_T;
		public virtual RMethod RInternalIndexOf_T
		{
			get
			{
				if(r_RInternalIndexOf_T == null)
				{
					r_RInternalIndexOf_T = new(this, "InternalIndexOf", 0, Type.MakeGenericMethodParameter(0));
					r_RInternalIndexOf_T.SetBelong(this.instance);
				}
				return r_RInternalIndexOf_T;
			}
		}

		/// <summary>
		/// Void SymmetricExceptWithUniqueHashSet(System.Collections.Generic.HashSet`1[T])
		/// </summary>
		protected RMethod r_RSymmetricExceptWithUniqueHashSet_HashSet_d_T_p_;
		public virtual RMethod RSymmetricExceptWithUniqueHashSet_HashSet_d_T_p_
		{
			get
			{
				if(r_RSymmetricExceptWithUniqueHashSet_HashSet_d_T_p_ == null)
				{
					r_RSymmetricExceptWithUniqueHashSet_HashSet_d_T_p_ = new(this, "SymmetricExceptWithUniqueHashSet", 0, typeof(System.Collections.Generic.HashSet<>));
					r_RSymmetricExceptWithUniqueHashSet_HashSet_d_T_p_.SetBelong(this.instance);
				}
				return r_RSymmetricExceptWithUniqueHashSet_HashSet_d_T_p_;
			}
		}

		/// <summary>
		/// Void SymmetricExceptWithEnumerable(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RSymmetricExceptWithEnumerable_IEnumerable_d_T_p_;
		public virtual RMethod RSymmetricExceptWithEnumerable_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RSymmetricExceptWithEnumerable_IEnumerable_d_T_p_ == null)
				{
					r_RSymmetricExceptWithEnumerable_IEnumerable_d_T_p_ = new(this, "SymmetricExceptWithEnumerable", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RSymmetricExceptWithEnumerable_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RSymmetricExceptWithEnumerable_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean AddOrGetLocation(T, Int32 ByRef)
		/// </summary>
		protected RMethod r_RAddOrGetLocation_T_Out_Int32;
		public virtual RMethod RAddOrGetLocation_T_Out_Int32
		{
			get
			{
				if(r_RAddOrGetLocation_T_Out_Int32 == null)
				{
					r_RAddOrGetLocation_T_Out_Int32 = new(this, "AddOrGetLocation", 0, Type.MakeGenericMethodParameter(0), typeof(System.Int32).MakeByRefType());
					r_RAddOrGetLocation_T_Out_Int32.SetBelong(this.instance);
				}
				return r_RAddOrGetLocation_T_Out_Int32;
			}
		}

		/// <summary>
		/// ElementCount CheckUniqueAndUnfoundElements(System.Collections.Generic.IEnumerable`1[T], Boolean)
		/// </summary>
		protected RMethod r_RCheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean;
		public virtual RMethod RCheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean
		{
			get
			{
				if(r_RCheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean == null)
				{
					r_RCheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean = new(this, "CheckUniqueAndUnfoundElements", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Boolean));
					r_RCheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean.SetBelong(this.instance);
				}
				return r_RCheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean;
			}
		}

		/// <summary>
		/// Boolean HashSetEquals(System.Collections.Generic.HashSet`1[T], System.Collections.Generic.HashSet`1[T], System.Collections.Generic.IEqualityComparer`1[T])
		/// </summary>
		protected static RMethod r_RHashSetEquals_HashSet_d_T_p__HashSet_d_T_p__IEqualityComparer_d_T_p_;
		public static RMethod RHashSetEquals_HashSet_d_T_p__HashSet_d_T_p__IEqualityComparer_d_T_p_
		{
			get
			{
				if(r_RHashSetEquals_HashSet_d_T_p__HashSet_d_T_p__IEqualityComparer_d_T_p_ == null)
				{
					r_RHashSetEquals_HashSet_d_T_p__HashSet_d_T_p__IEqualityComparer_d_T_p_ = new(typeof(System.Collections.Generic.HashSet<>), "HashSetEquals", 0, typeof(System.Collections.Generic.HashSet<>), typeof(System.Collections.Generic.HashSet<>), typeof(System.Collections.Generic.IEqualityComparer<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RHashSetEquals_HashSet_d_T_p__HashSet_d_T_p__IEqualityComparer_d_T_p_.SetBelong(null);
				}
				return r_RHashSetEquals_HashSet_d_T_p__HashSet_d_T_p__IEqualityComparer_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean AreEqualityComparersEqual(System.Collections.Generic.HashSet`1[T], System.Collections.Generic.HashSet`1[T])
		/// </summary>
		protected static RMethod r_RAreEqualityComparersEqual_HashSet_d_T_p__HashSet_d_T_p_;
		public static RMethod RAreEqualityComparersEqual_HashSet_d_T_p__HashSet_d_T_p_
		{
			get
			{
				if(r_RAreEqualityComparersEqual_HashSet_d_T_p__HashSet_d_T_p_ == null)
				{
					r_RAreEqualityComparersEqual_HashSet_d_T_p__HashSet_d_T_p_ = new(typeof(System.Collections.Generic.HashSet<>), "AreEqualityComparersEqual", 0, typeof(System.Collections.Generic.HashSet<>), typeof(System.Collections.Generic.HashSet<>));
					r_RAreEqualityComparersEqual_HashSet_d_T_p__HashSet_d_T_p_.SetBelong(null);
				}
				return r_RAreEqualityComparersEqual_HashSet_d_T_p__HashSet_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 InternalGetHashCode(T)
		/// </summary>
		protected RMethod r_RInternalGetHashCode_T;
		public virtual RMethod RInternalGetHashCode_T
		{
			get
			{
				if(r_RInternalGetHashCode_T == null)
				{
					r_RInternalGetHashCode_T = new(this, "InternalGetHashCode", 0, Type.MakeGenericMethodParameter(0));
					r_RInternalGetHashCode_T.SetBelong(this.instance);
				}
				return r_RInternalGetHashCode_T;
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

        public virtual void CopyFrom(System.Collections.Generic.HashSet<T>  @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source};
            var ___result = RCopyFrom_HashSet_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Collections__0__Generic__0__ICollection__1__T__2____0__Add(T  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Add_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Contains(T  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RContains_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CopyTo(T[]  @array, System.Int32  @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RCopyTo_TArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Remove(T  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RRemove_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Collections.Generic.IEnumerator<T> System__0__Collections__0__Generic__0__IEnumerable__1__T__2____0__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__0__Collections__0__Generic__0__IEnumerable__1__T__2____0__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerator<T>)___result;
        }


        public virtual System.Collections.IEnumerator System__0__Collections__0__IEnumerable__0__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__0__Collections__0__IEnumerable__0__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
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


        public virtual System.Boolean Add(T  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RAdd_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetValue(T  @equalValue, out T  @actualValue)
        {
			actualValue = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@equalValue, @actualValue};
            var ___result = RTryGetValue_T_Out_T.Invoke(___genericsType, ___parameters);
			actualValue = (T)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual void UnionWith(System.Collections.Generic.IEnumerable<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RUnionWith_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IntersectWith(System.Collections.Generic.IEnumerable<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIntersectWith_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExceptWith(System.Collections.Generic.IEnumerable<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RExceptWith_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SymmetricExceptWith(System.Collections.Generic.IEnumerable<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RSymmetricExceptWith_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsSubsetOf(System.Collections.Generic.IEnumerable<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIsSubsetOf_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsProperSubsetOf(System.Collections.Generic.IEnumerable<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIsProperSubsetOf_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsSupersetOf(System.Collections.Generic.IEnumerable<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIsSupersetOf_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsProperSupersetOf(System.Collections.Generic.IEnumerable<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIsProperSupersetOf_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Overlaps(System.Collections.Generic.IEnumerable<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = ROverlaps_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SetEquals(System.Collections.Generic.IEnumerable<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RSetEquals_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CopyTo(T[]  @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array};
            var ___result = RCopyTo_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(T[]  @array, System.Int32  @arrayIndex, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex, @count};
            var ___result = RCopyTo_TArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 RemoveWhere(System.Predicate<T>  @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@match};
            var ___result = RRemoveWhere_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 EnsureCapacity(System.Int32  @capacity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@capacity};
            var ___result = REnsureCapacity_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void TrimExcess()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTrimExcess.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Collections.Generic.IEqualityComparer<System.Collections.Generic.HashSet<T>> CreateSetComparer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateSetComparer.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEqualityComparer<System.Collections.Generic.HashSet<T>>)___result;
        }


        public virtual System.Int32 Initialize(System.Int32  @capacity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@capacity};
            var ___result = RInitialize_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void IncreaseCapacity()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIncreaseCapacity.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCapacity(System.Int32  @newSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newSize};
            var ___result = RSetCapacity_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean AddIfNotPresent(T  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAddIfNotPresent_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void AddValue(System.Int32  @index, System.Int32  @hashCode, T  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @hashCode, @value};
            var ___result = RAddValue_Int32_Int32_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ContainsAllElements(System.Collections.Generic.IEnumerable<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RContainsAllElements_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsSubsetOfHashSetWithSameEC(System.Collections.Generic.HashSet<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIsSubsetOfHashSetWithSameEC_HashSet_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void IntersectWithHashSetWithSameEC(System.Collections.Generic.HashSet<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIntersectWithHashSetWithSameEC_HashSet_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IntersectWithEnumerable(System.Collections.Generic.IEnumerable<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIntersectWithEnumerable_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 InternalIndexOf(T  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RInternalIndexOf_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SymmetricExceptWithUniqueHashSet(System.Collections.Generic.HashSet<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RSymmetricExceptWithUniqueHashSet_HashSet_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SymmetricExceptWithEnumerable(System.Collections.Generic.IEnumerable<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RSymmetricExceptWithEnumerable_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean AddOrGetLocation(T  @value, out System.Int32  @location)
        {
			location = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @location};
            var ___result = RAddOrGetLocation_T_Out_Int32.Invoke(___genericsType, ___parameters);
			location = (System.Int32)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Object CheckUniqueAndUnfoundElements(System.Collections.Generic.IEnumerable<T>  @other, System.Boolean  @returnIfUnfound)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other, @returnIfUnfound};
            var ___result = RCheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Boolean HashSetEquals(System.Collections.Generic.HashSet<T>  @set1, System.Collections.Generic.HashSet<T>  @set2, System.Collections.Generic.IEqualityComparer<T>  @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@set1, @set2, @comparer};
            var ___result = RHashSetEquals_HashSet_d_T_p__HashSet_d_T_p__IEqualityComparer_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean AreEqualityComparersEqual(System.Collections.Generic.HashSet<T>  @set1, System.Collections.Generic.HashSet<T>  @set2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@set1, @set2};
            var ___result = RAreEqualityComparersEqual_HashSet_d_T_p__HashSet_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 InternalGetHashCode(T  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RInternalGetHashCode_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
