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
		protected static RSystem.RInt32 r_Lower31BitMask;
		public static RSystem.RInt32 RLower31BitMask
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
		protected static RSystem.RInt32 r_StackAllocThreshold;
		public static RSystem.RInt32 RStackAllocThreshold
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
		protected static RSystem.RInt32 r_ShrinkThreshold;
		public static RSystem.RInt32 RShrinkThreshold
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
		protected static RSystem.RString r_CapacityName;
		public static RSystem.RString RCapacityName
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
		protected static RSystem.RString r_ElementsName;
		public static RSystem.RString RElementsName
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
		protected static RSystem.RString r_ComparerName;
		public static RSystem.RString RComparerName
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
		protected static RSystem.RString r_VersionName;
		public static RSystem.RString RVersionName
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
		protected RFieldArray<RSystem.RInt32> r__buckets;
		public virtual RFieldArray<RSystem.RInt32> R_buckets
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
		protected RSystem.RInt32 r__count;
		public virtual RSystem.RInt32 R_count
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
		protected RSystem.RInt32 r__lastIndex;
		public virtual RSystem.RInt32 R_lastIndex
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
		protected RSystem.RInt32 r__freeList;
		public virtual RSystem.RInt32 R_freeList
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
		/// Boolean System.Collections.Generic.ICollection<T>.IsReadOnly
		/// </summary>
		protected RSystem.RBoolean r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__IsReadOnly;
		public virtual RSystem.RBoolean RSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__IsReadOnly
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__IsReadOnly == null)
				{
					r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__IsReadOnly = new(this, "System.Collections.Generic.ICollection<T>.IsReadOnly", -1);
					r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__IsReadOnly.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__IsReadOnly;
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
		protected RMethod r_CopyFrom_HashSet_d_T_p_;
		public virtual RMethod RCopyFrom_HashSet_d_T_p_
		{
			get
			{
				if(r_CopyFrom_HashSet_d_T_p_ == null)
				{
					r_CopyFrom_HashSet_d_T_p_ = new(this, "CopyFrom", 0, typeof(System.Collections.Generic.HashSet<>));
					r_CopyFrom_HashSet_d_T_p_.SetBelong(this.instance);
				}
				return r_CopyFrom_HashSet_d_T_p_;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.ICollection<T>.Add(T)
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Add_T;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Add_T
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Add_T == null)
				{
					r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Add_T = new(this, "System.Collections.Generic.ICollection<T>.Add", 0, Type.MakeGenericMethodParameter(0));
					r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Add_T.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Add_T;
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
		/// Boolean Contains(T)
		/// </summary>
		protected RMethod r_Contains_T;
		public virtual RMethod RContains_T
		{
			get
			{
				if(r_Contains_T == null)
				{
					r_Contains_T = new(this, "Contains", 0, Type.MakeGenericMethodParameter(0));
					r_Contains_T.SetBelong(this.instance);
				}
				return r_Contains_T;
			}
		}

		/// <summary>
		/// Void CopyTo(T[], Int32)
		/// </summary>
		protected RMethod r_CopyTo_TArray_Int32;
		public virtual RMethod RCopyTo_TArray_Int32
		{
			get
			{
				if(r_CopyTo_TArray_Int32 == null)
				{
					r_CopyTo_TArray_Int32 = new(this, "CopyTo", 0, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32));
					r_CopyTo_TArray_Int32.SetBelong(this.instance);
				}
				return r_CopyTo_TArray_Int32;
			}
		}

		/// <summary>
		/// Boolean Remove(T)
		/// </summary>
		protected RMethod r_Remove_T;
		public virtual RMethod RRemove_T
		{
			get
			{
				if(r_Remove_T == null)
				{
					r_Remove_T = new(this, "Remove", 0, Type.MakeGenericMethodParameter(0));
					r_Remove_T.SetBelong(this.instance);
				}
				return r_Remove_T;
			}
		}

		/// <summary>
		/// Enumerator GetEnumerator()
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
		/// System.Collections.Generic.IEnumerator`1[T] System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator == null)
				{
					r_System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator = new(this, "System.Collections.Generic.IEnumerable<T>.GetEnumerator", 0);
					r_System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator;
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
		/// Boolean Add(T)
		/// </summary>
		protected RMethod r_Add_T;
		public virtual RMethod RAdd_T
		{
			get
			{
				if(r_Add_T == null)
				{
					r_Add_T = new(this, "Add", 0, Type.MakeGenericMethodParameter(0));
					r_Add_T.SetBelong(this.instance);
				}
				return r_Add_T;
			}
		}

		/// <summary>
		/// Boolean TryGetValue(T, T ByRef)
		/// </summary>
		protected RMethod r_TryGetValue_T_Out_T;
		public virtual RMethod RTryGetValue_T_Out_T
		{
			get
			{
				if(r_TryGetValue_T_Out_T == null)
				{
					r_TryGetValue_T_Out_T = new(this, "TryGetValue", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_TryGetValue_T_Out_T.SetBelong(this.instance);
				}
				return r_TryGetValue_T_Out_T;
			}
		}

		/// <summary>
		/// Void UnionWith(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_UnionWith_IEnumerable_d_T_p_;
		public virtual RMethod RUnionWith_IEnumerable_d_T_p_
		{
			get
			{
				if(r_UnionWith_IEnumerable_d_T_p_ == null)
				{
					r_UnionWith_IEnumerable_d_T_p_ = new(this, "UnionWith", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_UnionWith_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_UnionWith_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Void IntersectWith(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_IntersectWith_IEnumerable_d_T_p_;
		public virtual RMethod RIntersectWith_IEnumerable_d_T_p_
		{
			get
			{
				if(r_IntersectWith_IEnumerable_d_T_p_ == null)
				{
					r_IntersectWith_IEnumerable_d_T_p_ = new(this, "IntersectWith", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_IntersectWith_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_IntersectWith_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Void ExceptWith(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_ExceptWith_IEnumerable_d_T_p_;
		public virtual RMethod RExceptWith_IEnumerable_d_T_p_
		{
			get
			{
				if(r_ExceptWith_IEnumerable_d_T_p_ == null)
				{
					r_ExceptWith_IEnumerable_d_T_p_ = new(this, "ExceptWith", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_ExceptWith_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_ExceptWith_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Void SymmetricExceptWith(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_SymmetricExceptWith_IEnumerable_d_T_p_;
		public virtual RMethod RSymmetricExceptWith_IEnumerable_d_T_p_
		{
			get
			{
				if(r_SymmetricExceptWith_IEnumerable_d_T_p_ == null)
				{
					r_SymmetricExceptWith_IEnumerable_d_T_p_ = new(this, "SymmetricExceptWith", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_SymmetricExceptWith_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_SymmetricExceptWith_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean IsSubsetOf(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_IsSubsetOf_IEnumerable_d_T_p_;
		public virtual RMethod RIsSubsetOf_IEnumerable_d_T_p_
		{
			get
			{
				if(r_IsSubsetOf_IEnumerable_d_T_p_ == null)
				{
					r_IsSubsetOf_IEnumerable_d_T_p_ = new(this, "IsSubsetOf", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_IsSubsetOf_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_IsSubsetOf_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean IsProperSubsetOf(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_IsProperSubsetOf_IEnumerable_d_T_p_;
		public virtual RMethod RIsProperSubsetOf_IEnumerable_d_T_p_
		{
			get
			{
				if(r_IsProperSubsetOf_IEnumerable_d_T_p_ == null)
				{
					r_IsProperSubsetOf_IEnumerable_d_T_p_ = new(this, "IsProperSubsetOf", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_IsProperSubsetOf_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_IsProperSubsetOf_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean IsSupersetOf(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_IsSupersetOf_IEnumerable_d_T_p_;
		public virtual RMethod RIsSupersetOf_IEnumerable_d_T_p_
		{
			get
			{
				if(r_IsSupersetOf_IEnumerable_d_T_p_ == null)
				{
					r_IsSupersetOf_IEnumerable_d_T_p_ = new(this, "IsSupersetOf", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_IsSupersetOf_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_IsSupersetOf_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean IsProperSupersetOf(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_IsProperSupersetOf_IEnumerable_d_T_p_;
		public virtual RMethod RIsProperSupersetOf_IEnumerable_d_T_p_
		{
			get
			{
				if(r_IsProperSupersetOf_IEnumerable_d_T_p_ == null)
				{
					r_IsProperSupersetOf_IEnumerable_d_T_p_ = new(this, "IsProperSupersetOf", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_IsProperSupersetOf_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_IsProperSupersetOf_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean Overlaps(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_Overlaps_IEnumerable_d_T_p_;
		public virtual RMethod ROverlaps_IEnumerable_d_T_p_
		{
			get
			{
				if(r_Overlaps_IEnumerable_d_T_p_ == null)
				{
					r_Overlaps_IEnumerable_d_T_p_ = new(this, "Overlaps", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_Overlaps_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_Overlaps_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean SetEquals(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_SetEquals_IEnumerable_d_T_p_;
		public virtual RMethod RSetEquals_IEnumerable_d_T_p_
		{
			get
			{
				if(r_SetEquals_IEnumerable_d_T_p_ == null)
				{
					r_SetEquals_IEnumerable_d_T_p_ = new(this, "SetEquals", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_SetEquals_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_SetEquals_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Void CopyTo(T[])
		/// </summary>
		protected RMethod r_CopyTo_TArray;
		public virtual RMethod RCopyTo_TArray
		{
			get
			{
				if(r_CopyTo_TArray == null)
				{
					r_CopyTo_TArray = new(this, "CopyTo", 0, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_CopyTo_TArray.SetBelong(this.instance);
				}
				return r_CopyTo_TArray;
			}
		}

		/// <summary>
		/// Void CopyTo(T[], Int32, Int32)
		/// </summary>
		protected RMethod r_CopyTo_TArray_Int32_Int32;
		public virtual RMethod RCopyTo_TArray_Int32_Int32
		{
			get
			{
				if(r_CopyTo_TArray_Int32_Int32 == null)
				{
					r_CopyTo_TArray_Int32_Int32 = new(this, "CopyTo", 0, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_CopyTo_TArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_CopyTo_TArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 RemoveWhere(System.Predicate`1[T])
		/// </summary>
		protected RMethod r_RemoveWhere_Predicate_d_T_p_;
		public virtual RMethod RRemoveWhere_Predicate_d_T_p_
		{
			get
			{
				if(r_RemoveWhere_Predicate_d_T_p_ == null)
				{
					r_RemoveWhere_Predicate_d_T_p_ = new(this, "RemoveWhere", 0, typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RemoveWhere_Predicate_d_T_p_.SetBelong(this.instance);
				}
				return r_RemoveWhere_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 EnsureCapacity(Int32)
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
		/// Void TrimExcess()
		/// </summary>
		protected RMethod r_TrimExcess;
		public virtual RMethod RTrimExcess
		{
			get
			{
				if(r_TrimExcess == null)
				{
					r_TrimExcess = new(this, "TrimExcess", 0);
					r_TrimExcess.SetBelong(this.instance);
				}
				return r_TrimExcess;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEqualityComparer`1[System.Collections.Generic.HashSet`1[T]] CreateSetComparer()
		/// </summary>
		protected static RMethod r_CreateSetComparer;
		public static RMethod RCreateSetComparer
		{
			get
			{
				if(r_CreateSetComparer == null)
				{
					r_CreateSetComparer = new(typeof(System.Collections.Generic.HashSet<>), "CreateSetComparer", 0);
					r_CreateSetComparer.SetBelong(null);
				}
				return r_CreateSetComparer;
			}
		}

		/// <summary>
		/// Int32 Initialize(Int32)
		/// </summary>
		protected RMethod r_Initialize_Int32;
		public virtual RMethod RInitialize_Int32
		{
			get
			{
				if(r_Initialize_Int32 == null)
				{
					r_Initialize_Int32 = new(this, "Initialize", 0, typeof(System.Int32));
					r_Initialize_Int32.SetBelong(this.instance);
				}
				return r_Initialize_Int32;
			}
		}

		/// <summary>
		/// Void IncreaseCapacity()
		/// </summary>
		protected RMethod r_IncreaseCapacity;
		public virtual RMethod RIncreaseCapacity
		{
			get
			{
				if(r_IncreaseCapacity == null)
				{
					r_IncreaseCapacity = new(this, "IncreaseCapacity", 0);
					r_IncreaseCapacity.SetBelong(this.instance);
				}
				return r_IncreaseCapacity;
			}
		}

		/// <summary>
		/// Void SetCapacity(Int32)
		/// </summary>
		protected RMethod r_SetCapacity_Int32;
		public virtual RMethod RSetCapacity_Int32
		{
			get
			{
				if(r_SetCapacity_Int32 == null)
				{
					r_SetCapacity_Int32 = new(this, "SetCapacity", 0, typeof(System.Int32));
					r_SetCapacity_Int32.SetBelong(this.instance);
				}
				return r_SetCapacity_Int32;
			}
		}

		/// <summary>
		/// Boolean AddIfNotPresent(T)
		/// </summary>
		protected RMethod r_AddIfNotPresent_T;
		public virtual RMethod RAddIfNotPresent_T
		{
			get
			{
				if(r_AddIfNotPresent_T == null)
				{
					r_AddIfNotPresent_T = new(this, "AddIfNotPresent", 0, Type.MakeGenericMethodParameter(0));
					r_AddIfNotPresent_T.SetBelong(this.instance);
				}
				return r_AddIfNotPresent_T;
			}
		}

		/// <summary>
		/// Void AddValue(Int32, Int32, T)
		/// </summary>
		protected RMethod r_AddValue_Int32_Int32_T;
		public virtual RMethod RAddValue_Int32_Int32_T
		{
			get
			{
				if(r_AddValue_Int32_Int32_T == null)
				{
					r_AddValue_Int32_Int32_T = new(this, "AddValue", 0, typeof(System.Int32), typeof(System.Int32), Type.MakeGenericMethodParameter(0));
					r_AddValue_Int32_Int32_T.SetBelong(this.instance);
				}
				return r_AddValue_Int32_Int32_T;
			}
		}

		/// <summary>
		/// Boolean ContainsAllElements(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_ContainsAllElements_IEnumerable_d_T_p_;
		public virtual RMethod RContainsAllElements_IEnumerable_d_T_p_
		{
			get
			{
				if(r_ContainsAllElements_IEnumerable_d_T_p_ == null)
				{
					r_ContainsAllElements_IEnumerable_d_T_p_ = new(this, "ContainsAllElements", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_ContainsAllElements_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_ContainsAllElements_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean IsSubsetOfHashSetWithSameEC(System.Collections.Generic.HashSet`1[T])
		/// </summary>
		protected RMethod r_IsSubsetOfHashSetWithSameEC_HashSet_d_T_p_;
		public virtual RMethod RIsSubsetOfHashSetWithSameEC_HashSet_d_T_p_
		{
			get
			{
				if(r_IsSubsetOfHashSetWithSameEC_HashSet_d_T_p_ == null)
				{
					r_IsSubsetOfHashSetWithSameEC_HashSet_d_T_p_ = new(this, "IsSubsetOfHashSetWithSameEC", 0, typeof(System.Collections.Generic.HashSet<>));
					r_IsSubsetOfHashSetWithSameEC_HashSet_d_T_p_.SetBelong(this.instance);
				}
				return r_IsSubsetOfHashSetWithSameEC_HashSet_d_T_p_;
			}
		}

		/// <summary>
		/// Void IntersectWithHashSetWithSameEC(System.Collections.Generic.HashSet`1[T])
		/// </summary>
		protected RMethod r_IntersectWithHashSetWithSameEC_HashSet_d_T_p_;
		public virtual RMethod RIntersectWithHashSetWithSameEC_HashSet_d_T_p_
		{
			get
			{
				if(r_IntersectWithHashSetWithSameEC_HashSet_d_T_p_ == null)
				{
					r_IntersectWithHashSetWithSameEC_HashSet_d_T_p_ = new(this, "IntersectWithHashSetWithSameEC", 0, typeof(System.Collections.Generic.HashSet<>));
					r_IntersectWithHashSetWithSameEC_HashSet_d_T_p_.SetBelong(this.instance);
				}
				return r_IntersectWithHashSetWithSameEC_HashSet_d_T_p_;
			}
		}

		/// <summary>
		/// Void IntersectWithEnumerable(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_IntersectWithEnumerable_IEnumerable_d_T_p_;
		public virtual RMethod RIntersectWithEnumerable_IEnumerable_d_T_p_
		{
			get
			{
				if(r_IntersectWithEnumerable_IEnumerable_d_T_p_ == null)
				{
					r_IntersectWithEnumerable_IEnumerable_d_T_p_ = new(this, "IntersectWithEnumerable", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_IntersectWithEnumerable_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_IntersectWithEnumerable_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 InternalIndexOf(T)
		/// </summary>
		protected RMethod r_InternalIndexOf_T;
		public virtual RMethod RInternalIndexOf_T
		{
			get
			{
				if(r_InternalIndexOf_T == null)
				{
					r_InternalIndexOf_T = new(this, "InternalIndexOf", 0, Type.MakeGenericMethodParameter(0));
					r_InternalIndexOf_T.SetBelong(this.instance);
				}
				return r_InternalIndexOf_T;
			}
		}

		/// <summary>
		/// Void SymmetricExceptWithUniqueHashSet(System.Collections.Generic.HashSet`1[T])
		/// </summary>
		protected RMethod r_SymmetricExceptWithUniqueHashSet_HashSet_d_T_p_;
		public virtual RMethod RSymmetricExceptWithUniqueHashSet_HashSet_d_T_p_
		{
			get
			{
				if(r_SymmetricExceptWithUniqueHashSet_HashSet_d_T_p_ == null)
				{
					r_SymmetricExceptWithUniqueHashSet_HashSet_d_T_p_ = new(this, "SymmetricExceptWithUniqueHashSet", 0, typeof(System.Collections.Generic.HashSet<>));
					r_SymmetricExceptWithUniqueHashSet_HashSet_d_T_p_.SetBelong(this.instance);
				}
				return r_SymmetricExceptWithUniqueHashSet_HashSet_d_T_p_;
			}
		}

		/// <summary>
		/// Void SymmetricExceptWithEnumerable(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_SymmetricExceptWithEnumerable_IEnumerable_d_T_p_;
		public virtual RMethod RSymmetricExceptWithEnumerable_IEnumerable_d_T_p_
		{
			get
			{
				if(r_SymmetricExceptWithEnumerable_IEnumerable_d_T_p_ == null)
				{
					r_SymmetricExceptWithEnumerable_IEnumerable_d_T_p_ = new(this, "SymmetricExceptWithEnumerable", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_SymmetricExceptWithEnumerable_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_SymmetricExceptWithEnumerable_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean AddOrGetLocation(T, Int32 ByRef)
		/// </summary>
		protected RMethod r_AddOrGetLocation_T_Out_Int32;
		public virtual RMethod RAddOrGetLocation_T_Out_Int32
		{
			get
			{
				if(r_AddOrGetLocation_T_Out_Int32 == null)
				{
					r_AddOrGetLocation_T_Out_Int32 = new(this, "AddOrGetLocation", 0, Type.MakeGenericMethodParameter(0), typeof(System.Int32).MakeByRefType());
					r_AddOrGetLocation_T_Out_Int32.SetBelong(this.instance);
				}
				return r_AddOrGetLocation_T_Out_Int32;
			}
		}

		/// <summary>
		/// ElementCount CheckUniqueAndUnfoundElements(System.Collections.Generic.IEnumerable`1[T], Boolean)
		/// </summary>
		protected RMethod r_CheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean;
		public virtual RMethod RCheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean
		{
			get
			{
				if(r_CheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean == null)
				{
					r_CheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean = new(this, "CheckUniqueAndUnfoundElements", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Boolean));
					r_CheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean.SetBelong(this.instance);
				}
				return r_CheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean;
			}
		}

		/// <summary>
		/// Boolean HashSetEquals(System.Collections.Generic.HashSet`1[T], System.Collections.Generic.HashSet`1[T], System.Collections.Generic.IEqualityComparer`1[T])
		/// </summary>
		protected static RMethod r_HashSetEquals_HashSet_d_T_p__HashSet_d_T_p__IEqualityComparer_d_T_p_;
		public static RMethod RHashSetEquals_HashSet_d_T_p__HashSet_d_T_p__IEqualityComparer_d_T_p_
		{
			get
			{
				if(r_HashSetEquals_HashSet_d_T_p__HashSet_d_T_p__IEqualityComparer_d_T_p_ == null)
				{
					r_HashSetEquals_HashSet_d_T_p__HashSet_d_T_p__IEqualityComparer_d_T_p_ = new(typeof(System.Collections.Generic.HashSet<>), "HashSetEquals", 0, typeof(System.Collections.Generic.HashSet<>), typeof(System.Collections.Generic.HashSet<>), typeof(System.Collections.Generic.IEqualityComparer<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_HashSetEquals_HashSet_d_T_p__HashSet_d_T_p__IEqualityComparer_d_T_p_.SetBelong(null);
				}
				return r_HashSetEquals_HashSet_d_T_p__HashSet_d_T_p__IEqualityComparer_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean AreEqualityComparersEqual(System.Collections.Generic.HashSet`1[T], System.Collections.Generic.HashSet`1[T])
		/// </summary>
		protected static RMethod r_AreEqualityComparersEqual_HashSet_d_T_p__HashSet_d_T_p_;
		public static RMethod RAreEqualityComparersEqual_HashSet_d_T_p__HashSet_d_T_p_
		{
			get
			{
				if(r_AreEqualityComparersEqual_HashSet_d_T_p__HashSet_d_T_p_ == null)
				{
					r_AreEqualityComparersEqual_HashSet_d_T_p__HashSet_d_T_p_ = new(typeof(System.Collections.Generic.HashSet<>), "AreEqualityComparersEqual", 0, typeof(System.Collections.Generic.HashSet<>), typeof(System.Collections.Generic.HashSet<>));
					r_AreEqualityComparersEqual_HashSet_d_T_p__HashSet_d_T_p_.SetBelong(null);
				}
				return r_AreEqualityComparersEqual_HashSet_d_T_p__HashSet_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 InternalGetHashCode(T)
		/// </summary>
		protected RMethod r_InternalGetHashCode_T;
		public virtual RMethod RInternalGetHashCode_T
		{
			get
			{
				if(r_InternalGetHashCode_T == null)
				{
					r_InternalGetHashCode_T = new(this, "InternalGetHashCode", 0, Type.MakeGenericMethodParameter(0));
					r_InternalGetHashCode_T.SetBelong(this.instance);
				}
				return r_InternalGetHashCode_T;
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
            var ___result = RCopyFrom_HashSet_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Add(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Add_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Contains(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RContains_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CopyTo(T[] @array, System.Int32 @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RCopyTo_TArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Remove(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RRemove_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual RSystem.RCollections.RGeneric.RHashSet<RType>.REnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return new RSystem.RCollections.RGeneric.RHashSet<RType>.REnumerator(___result);
        }


        public virtual System.Collections.Generic.IEnumerator<T> System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerator<T>)___result;
        }


        public virtual System.Collections.IEnumerator System__2__Collections__2__IEnumerable__2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__2__Collections__2__IEnumerable__2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserialization(System.Object @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = ROnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Add(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RAdd_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetValue(T @equalValue, out T @actualValue)
        {
			@actualValue = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@equalValue, @actualValue};
            var ___result = RTryGetValue_T_Out_T.Invoke(___genericsType, ___parameters);
			@actualValue = (T)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual void UnionWith(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RUnionWith_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IntersectWith(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIntersectWith_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExceptWith(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RExceptWith_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SymmetricExceptWith(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RSymmetricExceptWith_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsSubsetOf(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIsSubsetOf_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsProperSubsetOf(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIsProperSubsetOf_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsSupersetOf(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIsSupersetOf_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsProperSupersetOf(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIsProperSupersetOf_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Overlaps(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = ROverlaps_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SetEquals(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RSetEquals_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CopyTo(T[] @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array};
            var ___result = RCopyTo_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(T[] @array, System.Int32 @arrayIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex, @count};
            var ___result = RCopyTo_TArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 RemoveWhere(System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@match};
            var ___result = RRemoveWhere_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 EnsureCapacity(System.Int32 @capacity)
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


        public virtual System.Int32 Initialize(System.Int32 @capacity)
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


        public virtual void SetCapacity(System.Int32 @newSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newSize};
            var ___result = RSetCapacity_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean AddIfNotPresent(T @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAddIfNotPresent_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void AddValue(System.Int32 @index, System.Int32 @hashCode, T @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @hashCode, @value};
            var ___result = RAddValue_Int32_Int32_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ContainsAllElements(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RContainsAllElements_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsSubsetOfHashSetWithSameEC(System.Collections.Generic.HashSet<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIsSubsetOfHashSetWithSameEC_HashSet_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void IntersectWithHashSetWithSameEC(System.Collections.Generic.HashSet<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIntersectWithHashSetWithSameEC_HashSet_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IntersectWithEnumerable(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIntersectWithEnumerable_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 InternalIndexOf(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RInternalIndexOf_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SymmetricExceptWithUniqueHashSet(System.Collections.Generic.HashSet<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RSymmetricExceptWithUniqueHashSet_HashSet_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SymmetricExceptWithEnumerable(System.Collections.Generic.IEnumerable<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RSymmetricExceptWithEnumerable_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean AddOrGetLocation(T @value, out System.Int32 @location)
        {
			@location = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @location};
            var ___result = RAddOrGetLocation_T_Out_Int32.Invoke(___genericsType, ___parameters);
			@location = (System.Int32)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual RSystem.RCollections.RGeneric.RHashSet<RType>.RElementCount CheckUniqueAndUnfoundElements(System.Collections.Generic.IEnumerable<T> @other, System.Boolean @returnIfUnfound)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other, @returnIfUnfound};
            var ___result = RCheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean.Invoke(___genericsType, ___parameters);

            return new RSystem.RCollections.RGeneric.RHashSet<RType>.RElementCount(___result);
        }


        public static System.Boolean HashSetEquals(System.Collections.Generic.HashSet<T> @set1, System.Collections.Generic.HashSet<T> @set2, System.Collections.Generic.IEqualityComparer<T> @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@set1, @set2, @comparer};
            var ___result = RHashSetEquals_HashSet_d_T_p__HashSet_d_T_p__IEqualityComparer_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean AreEqualityComparersEqual(System.Collections.Generic.HashSet<T> @set1, System.Collections.Generic.HashSet<T> @set2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@set1, @set2};
            var ___result = RAreEqualityComparersEqual_HashSet_d_T_p__HashSet_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 InternalGetHashCode(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RInternalGetHashCode_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
