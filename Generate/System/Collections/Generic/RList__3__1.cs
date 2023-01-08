using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
	/// System.Collections.Generic.List`1
	/// </summary>
    public partial class RList<T> : RMember //
    {

		/// <summary>
		/// System.Int32 DefaultCapacity
		/// </summary>
		protected static RField r_DefaultCapacity;
		public static RField RDefaultCapacity
		{
			get
			{
				if(r_DefaultCapacity == null)
				{
					r_DefaultCapacity = new(typeof(System.Collections.Generic.List<>), "DefaultCapacity");
					r_DefaultCapacity.SetBelong(null);
				}
				return r_DefaultCapacity;
			}
		}

		/// <summary>
		/// T[] _items
		/// </summary>
		protected RFieldArray<RField> r__items;
		public virtual RFieldArray<RField> R_items
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
		protected RField r__size;
		public virtual RField R_size
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
		/// T[] s_emptyArray
		/// </summary>
		protected static RFieldArray<RField> r_s_emptyArray;
		public static RFieldArray<RField> Rs_emptyArray
		{
			get
			{
				if(r_s_emptyArray == null)
				{
					r_s_emptyArray = new(typeof(System.Collections.Generic.List<>), "s_emptyArray");
					r_s_emptyArray.SetBelong(null);
				}
				return r_s_emptyArray;
			}
		}

		/// <summary>
		/// Int32 Capacity
		/// </summary>
		protected RProperty r_Capacity;
		public virtual RProperty RCapacity
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
		/// Boolean System.Collections.IList.IsFixedSize
		/// </summary>
		protected RProperty r_System__2__Collections__2__IList__2__IsFixedSize;
		public virtual RProperty RSystem__2__Collections__2__IList__2__IsFixedSize
		{
			get
			{
				if(r_System__2__Collections__2__IList__2__IsFixedSize == null)
				{
					r_System__2__Collections__2__IList__2__IsFixedSize = new(this, "System.Collections.IList.IsFixedSize", -1);
					r_System__2__Collections__2__IList__2__IsFixedSize.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IList__2__IsFixedSize;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<T>.IsReadOnly
		/// </summary>
		protected RProperty r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__IsReadOnly;
		public virtual RProperty RSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__IsReadOnly
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
		/// Boolean System.Collections.IList.IsReadOnly
		/// </summary>
		protected RProperty r_System__2__Collections__2__IList__2__IsReadOnly;
		public virtual RProperty RSystem__2__Collections__2__IList__2__IsReadOnly
		{
			get
			{
				if(r_System__2__Collections__2__IList__2__IsReadOnly == null)
				{
					r_System__2__Collections__2__IList__2__IsReadOnly = new(this, "System.Collections.IList.IsReadOnly", -1);
					r_System__2__Collections__2__IList__2__IsReadOnly.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IList__2__IsReadOnly;
			}
		}

		/// <summary>
		/// Boolean System.Collections.ICollection.IsSynchronized
		/// </summary>
		protected RProperty r_System__2__Collections__2__ICollection__2__IsSynchronized;
		public virtual RProperty RSystem__2__Collections__2__ICollection__2__IsSynchronized
		{
			get
			{
				if(r_System__2__Collections__2__ICollection__2__IsSynchronized == null)
				{
					r_System__2__Collections__2__ICollection__2__IsSynchronized = new(this, "System.Collections.ICollection.IsSynchronized", -1);
					r_System__2__Collections__2__ICollection__2__IsSynchronized.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__ICollection__2__IsSynchronized;
			}
		}

		/// <summary>
		/// System.Object System.Collections.ICollection.SyncRoot
		/// </summary>
		protected RSystem.RObject r_System__2__Collections__2__ICollection__2__SyncRoot;
		public virtual RSystem.RObject RSystem__2__Collections__2__ICollection__2__SyncRoot
		{
			get
			{
				if(r_System__2__Collections__2__ICollection__2__SyncRoot == null)
				{
					r_System__2__Collections__2__ICollection__2__SyncRoot = new(this, "System.Collections.ICollection.SyncRoot", -1);
					r_System__2__Collections__2__ICollection__2__SyncRoot.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__ICollection__2__SyncRoot;
			}
		}

		/// <summary>
		/// T Item [Int32]
		/// </summary>
		protected RProperty r_Item_Int32;
		public virtual RProperty RItem_Int32
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
		/// System.Object System.Collections.IList.Item [Int32]
		/// </summary>
		protected RSystem.RObject r_System__2__Collections__2__IList__2__Item_Int32;
		public virtual RSystem.RObject RSystem__2__Collections__2__IList__2__Item_Int32
		{
			get
			{
				if(r_System__2__Collections__2__IList__2__Item_Int32 == null)
				{
					r_System__2__Collections__2__IList__2__Item_Int32 = new(this, "System.Collections.IList.Item", -1, typeof(System.Int32));
					r_System__2__Collections__2__IList__2__Item_Int32.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IList__2__Item_Int32;
			}
		}

		/// <summary>
		/// Boolean IsCompatibleObject(System.Object)
		/// </summary>
		protected static RMethod r_IsCompatibleObject_Object;
		public static RMethod RIsCompatibleObject_Object
		{
			get
			{
				if(r_IsCompatibleObject_Object == null)
				{
					r_IsCompatibleObject_Object = new(typeof(System.Collections.Generic.List<>), "IsCompatibleObject", 0, typeof(System.Object));
					r_IsCompatibleObject_Object.SetBelong(null);
				}
				return r_IsCompatibleObject_Object;
			}
		}

		/// <summary>
		/// Void Add(T)
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
		/// Void AddWithResize(T)
		/// </summary>
		protected RMethod r_AddWithResize_T;
		public virtual RMethod RAddWithResize_T
		{
			get
			{
				if(r_AddWithResize_T == null)
				{
					r_AddWithResize_T = new(this, "AddWithResize", 0, Type.MakeGenericMethodParameter(0));
					r_AddWithResize_T.SetBelong(this.instance);
				}
				return r_AddWithResize_T;
			}
		}

		/// <summary>
		/// Int32 System.Collections.IList.Add(System.Object)
		/// </summary>
		protected RMethod r_System__2__Collections__2__IList__2__Add_Object;
		public virtual RMethod RSystem__2__Collections__2__IList__2__Add_Object
		{
			get
			{
				if(r_System__2__Collections__2__IList__2__Add_Object == null)
				{
					r_System__2__Collections__2__IList__2__Add_Object = new(this, "System.Collections.IList.Add", 0, typeof(System.Object));
					r_System__2__Collections__2__IList__2__Add_Object.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IList__2__Add_Object;
			}
		}

		/// <summary>
		/// Void AddRange(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_AddRange_IEnumerable_d_T_p_;
		public virtual RMethod RAddRange_IEnumerable_d_T_p_
		{
			get
			{
				if(r_AddRange_IEnumerable_d_T_p_ == null)
				{
					r_AddRange_IEnumerable_d_T_p_ = new(this, "AddRange", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_AddRange_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_AddRange_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[T] AsReadOnly()
		/// </summary>
		protected RMethod r_AsReadOnly;
		public virtual RMethod RAsReadOnly
		{
			get
			{
				if(r_AsReadOnly == null)
				{
					r_AsReadOnly = new(this, "AsReadOnly", 0);
					r_AsReadOnly.SetBelong(this.instance);
				}
				return r_AsReadOnly;
			}
		}

		/// <summary>
		/// Int32 BinarySearch(Int32, Int32, T, System.Collections.Generic.IComparer`1[T])
		/// </summary>
		protected RMethod r_BinarySearch_Int32_Int32_T_IComparer_d_T_p_;
		public virtual RMethod RBinarySearch_Int32_Int32_T_IComparer_d_T_p_
		{
			get
			{
				if(r_BinarySearch_Int32_Int32_T_IComparer_d_T_p_ == null)
				{
					r_BinarySearch_Int32_Int32_T_IComparer_d_T_p_ = new(this, "BinarySearch", 0, typeof(System.Int32), typeof(System.Int32), Type.MakeGenericMethodParameter(0), typeof(System.Collections.Generic.IComparer<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_BinarySearch_Int32_Int32_T_IComparer_d_T_p_.SetBelong(this.instance);
				}
				return r_BinarySearch_Int32_Int32_T_IComparer_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 BinarySearch(T)
		/// </summary>
		protected RMethod r_BinarySearch_T;
		public virtual RMethod RBinarySearch_T
		{
			get
			{
				if(r_BinarySearch_T == null)
				{
					r_BinarySearch_T = new(this, "BinarySearch", 0, Type.MakeGenericMethodParameter(0));
					r_BinarySearch_T.SetBelong(this.instance);
				}
				return r_BinarySearch_T;
			}
		}

		/// <summary>
		/// Int32 BinarySearch(T, System.Collections.Generic.IComparer`1[T])
		/// </summary>
		protected RMethod r_BinarySearch_T_IComparer_d_T_p_;
		public virtual RMethod RBinarySearch_T_IComparer_d_T_p_
		{
			get
			{
				if(r_BinarySearch_T_IComparer_d_T_p_ == null)
				{
					r_BinarySearch_T_IComparer_d_T_p_ = new(this, "BinarySearch", 0, Type.MakeGenericMethodParameter(0), typeof(System.Collections.Generic.IComparer<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_BinarySearch_T_IComparer_d_T_p_.SetBelong(this.instance);
				}
				return r_BinarySearch_T_IComparer_d_T_p_;
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
		/// Boolean System.Collections.IList.Contains(System.Object)
		/// </summary>
		protected RMethod r_System__2__Collections__2__IList__2__Contains_Object;
		public virtual RMethod RSystem__2__Collections__2__IList__2__Contains_Object
		{
			get
			{
				if(r_System__2__Collections__2__IList__2__Contains_Object == null)
				{
					r_System__2__Collections__2__IList__2__Contains_Object = new(this, "System.Collections.IList.Contains", 0, typeof(System.Object));
					r_System__2__Collections__2__IList__2__Contains_Object.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IList__2__Contains_Object;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[TOutput] ConvertAll[TOutput](System.Converter`2[T,TOutput])
		/// </summary>
		protected RMethod r_ConvertAll_GTOutput_Converter_d_T_TOutput_p_;
		public virtual RMethod RConvertAll_GTOutput_Converter_d_T_TOutput_p_
		{
			get
			{
				if(r_ConvertAll_GTOutput_Converter_d_T_TOutput_p_ == null)
				{
					r_ConvertAll_GTOutput_Converter_d_T_TOutput_p_ = new(this, "ConvertAll", 1, typeof(System.Converter<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(0)));
					r_ConvertAll_GTOutput_Converter_d_T_TOutput_p_.SetBelong(this.instance);
				}
				return r_ConvertAll_GTOutput_Converter_d_T_TOutput_p_;
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
		/// Void System.Collections.ICollection.CopyTo(System.Array, Int32)
		/// </summary>
		protected RMethod r_System__2__Collections__2__ICollection__2__CopyTo_Array_Int32;
		public virtual RMethod RSystem__2__Collections__2__ICollection__2__CopyTo_Array_Int32
		{
			get
			{
				if(r_System__2__Collections__2__ICollection__2__CopyTo_Array_Int32 == null)
				{
					r_System__2__Collections__2__ICollection__2__CopyTo_Array_Int32 = new(this, "System.Collections.ICollection.CopyTo", 0, typeof(System.Array), typeof(System.Int32));
					r_System__2__Collections__2__ICollection__2__CopyTo_Array_Int32.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__ICollection__2__CopyTo_Array_Int32;
			}
		}

		/// <summary>
		/// Void CopyTo(Int32, T[], Int32, Int32)
		/// </summary>
		protected RMethod r_CopyTo_Int32_TArray_Int32_Int32;
		public virtual RMethod RCopyTo_Int32_TArray_Int32_Int32
		{
			get
			{
				if(r_CopyTo_Int32_TArray_Int32_Int32 == null)
				{
					r_CopyTo_Int32_TArray_Int32_Int32 = new(this, "CopyTo", 0, typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_CopyTo_Int32_TArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_CopyTo_Int32_TArray_Int32_Int32;
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
		/// Boolean Exists(System.Predicate`1[T])
		/// </summary>
		protected RMethod r_Exists_Predicate_d_T_p_;
		public virtual RMethod RExists_Predicate_d_T_p_
		{
			get
			{
				if(r_Exists_Predicate_d_T_p_ == null)
				{
					r_Exists_Predicate_d_T_p_ = new(this, "Exists", 0, typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_Exists_Predicate_d_T_p_.SetBelong(this.instance);
				}
				return r_Exists_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// T Find(System.Predicate`1[T])
		/// </summary>
		protected RMethod r_Find_Predicate_d_T_p_;
		public virtual RMethod RFind_Predicate_d_T_p_
		{
			get
			{
				if(r_Find_Predicate_d_T_p_ == null)
				{
					r_Find_Predicate_d_T_p_ = new(this, "Find", 0, typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_Find_Predicate_d_T_p_.SetBelong(this.instance);
				}
				return r_Find_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[T] FindAll(System.Predicate`1[T])
		/// </summary>
		protected RMethod r_FindAll_Predicate_d_T_p_;
		public virtual RMethod RFindAll_Predicate_d_T_p_
		{
			get
			{
				if(r_FindAll_Predicate_d_T_p_ == null)
				{
					r_FindAll_Predicate_d_T_p_ = new(this, "FindAll", 0, typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_FindAll_Predicate_d_T_p_.SetBelong(this.instance);
				}
				return r_FindAll_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 FindIndex(System.Predicate`1[T])
		/// </summary>
		protected RMethod r_FindIndex_Predicate_d_T_p_;
		public virtual RMethod RFindIndex_Predicate_d_T_p_
		{
			get
			{
				if(r_FindIndex_Predicate_d_T_p_ == null)
				{
					r_FindIndex_Predicate_d_T_p_ = new(this, "FindIndex", 0, typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_FindIndex_Predicate_d_T_p_.SetBelong(this.instance);
				}
				return r_FindIndex_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 FindIndex(Int32, System.Predicate`1[T])
		/// </summary>
		protected RMethod r_FindIndex_Int32_Predicate_d_T_p_;
		public virtual RMethod RFindIndex_Int32_Predicate_d_T_p_
		{
			get
			{
				if(r_FindIndex_Int32_Predicate_d_T_p_ == null)
				{
					r_FindIndex_Int32_Predicate_d_T_p_ = new(this, "FindIndex", 0, typeof(System.Int32), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_FindIndex_Int32_Predicate_d_T_p_.SetBelong(this.instance);
				}
				return r_FindIndex_Int32_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 FindIndex(Int32, Int32, System.Predicate`1[T])
		/// </summary>
		protected RMethod r_FindIndex_Int32_Int32_Predicate_d_T_p_;
		public virtual RMethod RFindIndex_Int32_Int32_Predicate_d_T_p_
		{
			get
			{
				if(r_FindIndex_Int32_Int32_Predicate_d_T_p_ == null)
				{
					r_FindIndex_Int32_Int32_Predicate_d_T_p_ = new(this, "FindIndex", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_FindIndex_Int32_Int32_Predicate_d_T_p_.SetBelong(this.instance);
				}
				return r_FindIndex_Int32_Int32_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// T FindLast(System.Predicate`1[T])
		/// </summary>
		protected RMethod r_FindLast_Predicate_d_T_p_;
		public virtual RMethod RFindLast_Predicate_d_T_p_
		{
			get
			{
				if(r_FindLast_Predicate_d_T_p_ == null)
				{
					r_FindLast_Predicate_d_T_p_ = new(this, "FindLast", 0, typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_FindLast_Predicate_d_T_p_.SetBelong(this.instance);
				}
				return r_FindLast_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 FindLastIndex(System.Predicate`1[T])
		/// </summary>
		protected RMethod r_FindLastIndex_Predicate_d_T_p_;
		public virtual RMethod RFindLastIndex_Predicate_d_T_p_
		{
			get
			{
				if(r_FindLastIndex_Predicate_d_T_p_ == null)
				{
					r_FindLastIndex_Predicate_d_T_p_ = new(this, "FindLastIndex", 0, typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_FindLastIndex_Predicate_d_T_p_.SetBelong(this.instance);
				}
				return r_FindLastIndex_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 FindLastIndex(Int32, System.Predicate`1[T])
		/// </summary>
		protected RMethod r_FindLastIndex_Int32_Predicate_d_T_p_;
		public virtual RMethod RFindLastIndex_Int32_Predicate_d_T_p_
		{
			get
			{
				if(r_FindLastIndex_Int32_Predicate_d_T_p_ == null)
				{
					r_FindLastIndex_Int32_Predicate_d_T_p_ = new(this, "FindLastIndex", 0, typeof(System.Int32), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_FindLastIndex_Int32_Predicate_d_T_p_.SetBelong(this.instance);
				}
				return r_FindLastIndex_Int32_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 FindLastIndex(Int32, Int32, System.Predicate`1[T])
		/// </summary>
		protected RMethod r_FindLastIndex_Int32_Int32_Predicate_d_T_p_;
		public virtual RMethod RFindLastIndex_Int32_Int32_Predicate_d_T_p_
		{
			get
			{
				if(r_FindLastIndex_Int32_Int32_Predicate_d_T_p_ == null)
				{
					r_FindLastIndex_Int32_Int32_Predicate_d_T_p_ = new(this, "FindLastIndex", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_FindLastIndex_Int32_Int32_Predicate_d_T_p_.SetBelong(this.instance);
				}
				return r_FindLastIndex_Int32_Int32_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Void ForEach(System.Action`1[T])
		/// </summary>
		protected RMethod r_ForEach_Action_d_T_p_;
		public virtual RMethod RForEach_Action_d_T_p_
		{
			get
			{
				if(r_ForEach_Action_d_T_p_ == null)
				{
					r_ForEach_Action_d_T_p_ = new(this, "ForEach", 0, typeof(System.Action<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_ForEach_Action_d_T_p_.SetBelong(this.instance);
				}
				return r_ForEach_Action_d_T_p_;
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
		/// System.Collections.Generic.List`1[T] GetRange(Int32, Int32)
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
		/// Int32 IndexOf(T)
		/// </summary>
		protected RMethod r_IndexOf_T;
		public virtual RMethod RIndexOf_T
		{
			get
			{
				if(r_IndexOf_T == null)
				{
					r_IndexOf_T = new(this, "IndexOf", 0, Type.MakeGenericMethodParameter(0));
					r_IndexOf_T.SetBelong(this.instance);
				}
				return r_IndexOf_T;
			}
		}

		/// <summary>
		/// Int32 System.Collections.IList.IndexOf(System.Object)
		/// </summary>
		protected RMethod r_System__2__Collections__2__IList__2__IndexOf_Object;
		public virtual RMethod RSystem__2__Collections__2__IList__2__IndexOf_Object
		{
			get
			{
				if(r_System__2__Collections__2__IList__2__IndexOf_Object == null)
				{
					r_System__2__Collections__2__IList__2__IndexOf_Object = new(this, "System.Collections.IList.IndexOf", 0, typeof(System.Object));
					r_System__2__Collections__2__IList__2__IndexOf_Object.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IList__2__IndexOf_Object;
			}
		}

		/// <summary>
		/// Int32 IndexOf(T, Int32)
		/// </summary>
		protected RMethod r_IndexOf_T_Int32;
		public virtual RMethod RIndexOf_T_Int32
		{
			get
			{
				if(r_IndexOf_T_Int32 == null)
				{
					r_IndexOf_T_Int32 = new(this, "IndexOf", 0, Type.MakeGenericMethodParameter(0), typeof(System.Int32));
					r_IndexOf_T_Int32.SetBelong(this.instance);
				}
				return r_IndexOf_T_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(T, Int32, Int32)
		/// </summary>
		protected RMethod r_IndexOf_T_Int32_Int32;
		public virtual RMethod RIndexOf_T_Int32_Int32
		{
			get
			{
				if(r_IndexOf_T_Int32_Int32 == null)
				{
					r_IndexOf_T_Int32_Int32 = new(this, "IndexOf", 0, Type.MakeGenericMethodParameter(0), typeof(System.Int32), typeof(System.Int32));
					r_IndexOf_T_Int32_Int32.SetBelong(this.instance);
				}
				return r_IndexOf_T_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Insert(Int32, T)
		/// </summary>
		protected RMethod r_Insert_Int32_T;
		public virtual RMethod RInsert_Int32_T
		{
			get
			{
				if(r_Insert_Int32_T == null)
				{
					r_Insert_Int32_T = new(this, "Insert", 0, typeof(System.Int32), Type.MakeGenericMethodParameter(0));
					r_Insert_Int32_T.SetBelong(this.instance);
				}
				return r_Insert_Int32_T;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.Insert(Int32, System.Object)
		/// </summary>
		protected RMethod r_System__2__Collections__2__IList__2__Insert_Int32_Object;
		public virtual RMethod RSystem__2__Collections__2__IList__2__Insert_Int32_Object
		{
			get
			{
				if(r_System__2__Collections__2__IList__2__Insert_Int32_Object == null)
				{
					r_System__2__Collections__2__IList__2__Insert_Int32_Object = new(this, "System.Collections.IList.Insert", 0, typeof(System.Int32), typeof(System.Object));
					r_System__2__Collections__2__IList__2__Insert_Int32_Object.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IList__2__Insert_Int32_Object;
			}
		}

		/// <summary>
		/// Void InsertRange(Int32, System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_InsertRange_Int32_IEnumerable_d_T_p_;
		public virtual RMethod RInsertRange_Int32_IEnumerable_d_T_p_
		{
			get
			{
				if(r_InsertRange_Int32_IEnumerable_d_T_p_ == null)
				{
					r_InsertRange_Int32_IEnumerable_d_T_p_ = new(this, "InsertRange", 0, typeof(System.Int32), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_InsertRange_Int32_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_InsertRange_Int32_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(T)
		/// </summary>
		protected RMethod r_LastIndexOf_T;
		public virtual RMethod RLastIndexOf_T
		{
			get
			{
				if(r_LastIndexOf_T == null)
				{
					r_LastIndexOf_T = new(this, "LastIndexOf", 0, Type.MakeGenericMethodParameter(0));
					r_LastIndexOf_T.SetBelong(this.instance);
				}
				return r_LastIndexOf_T;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(T, Int32)
		/// </summary>
		protected RMethod r_LastIndexOf_T_Int32;
		public virtual RMethod RLastIndexOf_T_Int32
		{
			get
			{
				if(r_LastIndexOf_T_Int32 == null)
				{
					r_LastIndexOf_T_Int32 = new(this, "LastIndexOf", 0, Type.MakeGenericMethodParameter(0), typeof(System.Int32));
					r_LastIndexOf_T_Int32.SetBelong(this.instance);
				}
				return r_LastIndexOf_T_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(T, Int32, Int32)
		/// </summary>
		protected RMethod r_LastIndexOf_T_Int32_Int32;
		public virtual RMethod RLastIndexOf_T_Int32_Int32
		{
			get
			{
				if(r_LastIndexOf_T_Int32_Int32 == null)
				{
					r_LastIndexOf_T_Int32_Int32 = new(this, "LastIndexOf", 0, Type.MakeGenericMethodParameter(0), typeof(System.Int32), typeof(System.Int32));
					r_LastIndexOf_T_Int32_Int32.SetBelong(this.instance);
				}
				return r_LastIndexOf_T_Int32_Int32;
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
		/// Void System.Collections.IList.Remove(System.Object)
		/// </summary>
		protected RMethod r_System__2__Collections__2__IList__2__Remove_Object;
		public virtual RMethod RSystem__2__Collections__2__IList__2__Remove_Object
		{
			get
			{
				if(r_System__2__Collections__2__IList__2__Remove_Object == null)
				{
					r_System__2__Collections__2__IList__2__Remove_Object = new(this, "System.Collections.IList.Remove", 0, typeof(System.Object));
					r_System__2__Collections__2__IList__2__Remove_Object.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IList__2__Remove_Object;
			}
		}

		/// <summary>
		/// Int32 RemoveAll(System.Predicate`1[T])
		/// </summary>
		protected RMethod r_RemoveAll_Predicate_d_T_p_;
		public virtual RMethod RRemoveAll_Predicate_d_T_p_
		{
			get
			{
				if(r_RemoveAll_Predicate_d_T_p_ == null)
				{
					r_RemoveAll_Predicate_d_T_p_ = new(this, "RemoveAll", 0, typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RemoveAll_Predicate_d_T_p_.SetBelong(this.instance);
				}
				return r_RemoveAll_Predicate_d_T_p_;
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
		/// Void Sort(System.Collections.Generic.IComparer`1[T])
		/// </summary>
		protected RMethod r_Sort_IComparer_d_T_p_;
		public virtual RMethod RSort_IComparer_d_T_p_
		{
			get
			{
				if(r_Sort_IComparer_d_T_p_ == null)
				{
					r_Sort_IComparer_d_T_p_ = new(this, "Sort", 0, typeof(System.Collections.Generic.IComparer<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_Sort_IComparer_d_T_p_.SetBelong(this.instance);
				}
				return r_Sort_IComparer_d_T_p_;
			}
		}

		/// <summary>
		/// Void Sort(Int32, Int32, System.Collections.Generic.IComparer`1[T])
		/// </summary>
		protected RMethod r_Sort_Int32_Int32_IComparer_d_T_p_;
		public virtual RMethod RSort_Int32_Int32_IComparer_d_T_p_
		{
			get
			{
				if(r_Sort_Int32_Int32_IComparer_d_T_p_ == null)
				{
					r_Sort_Int32_Int32_IComparer_d_T_p_ = new(this, "Sort", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Collections.Generic.IComparer<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_Sort_Int32_Int32_IComparer_d_T_p_.SetBelong(this.instance);
				}
				return r_Sort_Int32_Int32_IComparer_d_T_p_;
			}
		}

		/// <summary>
		/// Void Sort(System.Comparison`1[T])
		/// </summary>
		protected RMethod r_Sort_Comparison_d_T_p_;
		public virtual RMethod RSort_Comparison_d_T_p_
		{
			get
			{
				if(r_Sort_Comparison_d_T_p_ == null)
				{
					r_Sort_Comparison_d_T_p_ = new(this, "Sort", 0, typeof(System.Comparison<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_Sort_Comparison_d_T_p_.SetBelong(this.instance);
				}
				return r_Sort_Comparison_d_T_p_;
			}
		}

		/// <summary>
		/// T[] ToArray()
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
		/// Boolean TrueForAll(System.Predicate`1[T])
		/// </summary>
		protected RMethod r_TrueForAll_Predicate_d_T_p_;
		public virtual RMethod RTrueForAll_Predicate_d_T_p_
		{
			get
			{
				if(r_TrueForAll_Predicate_d_T_p_ == null)
				{
					r_TrueForAll_Predicate_d_T_p_ = new(this, "TrueForAll", 0, typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_TrueForAll_Predicate_d_T_p_.SetBelong(this.instance);
				}
				return r_TrueForAll_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Void AddEnumerable(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_AddEnumerable_IEnumerable_d_T_p_;
		public virtual RMethod RAddEnumerable_IEnumerable_d_T_p_
		{
			get
			{
				if(r_AddEnumerable_IEnumerable_d_T_p_ == null)
				{
					r_AddEnumerable_IEnumerable_d_T_p_ = new(this, "AddEnumerable", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_AddEnumerable_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_AddEnumerable_IEnumerable_d_T_p_;
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


        public RList() : base("System.Collections.Generic.List`1")
        {
        }

        public RList(System.Object instance) : base("System.Collections.Generic.List`1")
		{
            SetInstance(instance);
		}

        public RList(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RList(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean IsCompatibleObject(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RIsCompatibleObject_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Add(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RAdd_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddWithResize(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RAddWithResize_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 System__2__Collections__2__IList__2__Add(System.Object @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__2__Collections__2__IList__2__Add_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void AddRange(System.Collections.Generic.IEnumerable<T> @collection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@collection};
            var ___result = RAddRange_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.ObjectModel.ReadOnlyCollection<T> AsReadOnly()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAsReadOnly.Invoke(___genericsType, ___parameters);

            return (System.Collections.ObjectModel.ReadOnlyCollection<T>)___result;
        }


        public virtual System.Int32 BinarySearch(System.Int32 @index, System.Int32 @count, T @item, System.Collections.Generic.IComparer<T> @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @count, @item, @comparer};
            var ___result = RBinarySearch_Int32_Int32_T_IComparer_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 BinarySearch(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RBinarySearch_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 BinarySearch(T @item, System.Collections.Generic.IComparer<T> @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item, @comparer};
            var ___result = RBinarySearch_T_IComparer_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.Boolean System__2__Collections__2__IList__2__Contains(System.Object @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__2__Collections__2__IList__2__Contains_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.Generic.List<TOutput> ConvertAll<TOutput>(System.Converter<T, TOutput> @converter)
        {

            var ___genericsType = new Type[] {typeof(TOutput)};
            var ___parameters = new object[]{@converter};
            var ___result = RConvertAll_GTOutput_Converter_d_T_TOutput_p_.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<TOutput>)___result;
        }


        public virtual void CopyTo(T[] @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array};
            var ___result = RCopyTo_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__ICollection__2__CopyTo(System.Array @array, System.Int32 @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RSystem__2__Collections__2__ICollection__2__CopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Int32 @index, T[] @array, System.Int32 @arrayIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @array, @arrayIndex, @count};
            var ___result = RCopyTo_Int32_TArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(T[] @array, System.Int32 @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RCopyTo_TArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnsureCapacity(System.Int32 @min)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@min};
            var ___result = REnsureCapacity_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Exists(System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@match};
            var ___result = RExists_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual T Find(System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@match};
            var ___result = RFind_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual System.Collections.Generic.List<T> FindAll(System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@match};
            var ___result = RFindAll_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<T>)___result;
        }


        public virtual System.Int32 FindIndex(System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@match};
            var ___result = RFindIndex_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 FindIndex(System.Int32 @startIndex, System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @match};
            var ___result = RFindIndex_Int32_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 FindIndex(System.Int32 @startIndex, System.Int32 @count, System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @count, @match};
            var ___result = RFindIndex_Int32_Int32_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual T FindLast(System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@match};
            var ___result = RFindLast_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual System.Int32 FindLastIndex(System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@match};
            var ___result = RFindLastIndex_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 FindLastIndex(System.Int32 @startIndex, System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @match};
            var ___result = RFindLastIndex_Int32_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 FindLastIndex(System.Int32 @startIndex, System.Int32 @count, System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @count, @match};
            var ___result = RFindLastIndex_Int32_Int32_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void ForEach(System.Action<T> @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = RForEach_Action_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RSystem.RCollections.RGeneric.RList<RType>.REnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return new RSystem.RCollections.RGeneric.RList<RType>.REnumerator(___result);
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


        public virtual System.Collections.Generic.List<T> GetRange(System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @count};
            var ___result = RGetRange_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<T>)___result;
        }


        public virtual System.Int32 IndexOf(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RIndexOf_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 System__2__Collections__2__IList__2__IndexOf(System.Object @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__2__Collections__2__IList__2__IndexOf_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(T @item, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item, @index};
            var ___result = RIndexOf_T_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(T @item, System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item, @index, @count};
            var ___result = RIndexOf_T_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Insert(System.Int32 @index, T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @item};
            var ___result = RInsert_Int32_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__IList__2__Insert(System.Int32 @index, System.Object @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @item};
            var ___result = RSystem__2__Collections__2__IList__2__Insert_Int32_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertRange(System.Int32 @index, System.Collections.Generic.IEnumerable<T> @collection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @collection};
            var ___result = RInsertRange_Int32_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 LastIndexOf(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RLastIndexOf_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(T @item, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item, @index};
            var ___result = RLastIndexOf_T_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(T @item, System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item, @index, @count};
            var ___result = RLastIndexOf_T_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Remove(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RRemove_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void System__2__Collections__2__IList__2__Remove(System.Object @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__2__Collections__2__IList__2__Remove_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 RemoveAll(System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@match};
            var ___result = RRemoveAll_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual void Sort()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSort.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Sort(System.Collections.Generic.IComparer<T> @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comparer};
            var ___result = RSort_IComparer_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Sort(System.Int32 @index, System.Int32 @count, System.Collections.Generic.IComparer<T> @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @count, @comparer};
            var ___result = RSort_Int32_Int32_IComparer_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Sort(System.Comparison<T> @comparison)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comparison};
            var ___result = RSort_Comparison_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T[] ToArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToArray.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual void TrimExcess()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTrimExcess.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TrueForAll(System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@match};
            var ___result = RTrueForAll_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void AddEnumerable(System.Collections.Generic.IEnumerable<T> @enumerable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumerable};
            var ___result = RAddEnumerable_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
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
