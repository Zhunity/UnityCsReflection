
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Collections.Generic.List`1
	/// </summary>
    public partial class RList<T> : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(ReflectionUtils.GetType(typeof(T)));
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


		/// <summary>
		/// System.Int32 DefaultCapacity
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FDefaultCapacity;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFDefaultCapacity
		{
			get
			{
				if(r_FDefaultCapacity == null)
				{
					r_FDefaultCapacity = new(Type, "DefaultCapacity");
				}
				return r_FDefaultCapacity;
			}
		}

		/// <summary>
		/// T[] _items
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RField> r_F_items;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RField> RF_items
		{
			get
			{
				if(r_F_items == null)
				{
					r_F_items = new(this, "_items");
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
				}
				return r_F_syncRoot;
			}
		}

		/// <summary>
		/// T[] s_emptyArray
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RField> r_Fs_emptyArray;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RField> RFs_emptyArray
		{
			get
			{
				if(r_Fs_emptyArray == null)
				{
					r_Fs_emptyArray = new(Type, "s_emptyArray");
				}
				return r_Fs_emptyArray;
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
				}
				return r_PCount;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IList.IsFixedSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PSystem__2__Collections__2__IList__2__IsFixedSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPSystem__2__Collections__2__IList__2__IsFixedSize
		{
			get
			{
				if(r_PSystem__2__Collections__2__IList__2__IsFixedSize == null)
				{
					r_PSystem__2__Collections__2__IList__2__IsFixedSize = new(this, "System.Collections.IList.IsFixedSize", -1);
				}
				return r_PSystem__2__Collections__2__IList__2__IsFixedSize;
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
				}
				return r_PSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__IsReadOnly;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IList.IsReadOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PSystem__2__Collections__2__IList__2__IsReadOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPSystem__2__Collections__2__IList__2__IsReadOnly
		{
			get
			{
				if(r_PSystem__2__Collections__2__IList__2__IsReadOnly == null)
				{
					r_PSystem__2__Collections__2__IList__2__IsReadOnly = new(this, "System.Collections.IList.IsReadOnly", -1);
				}
				return r_PSystem__2__Collections__2__IList__2__IsReadOnly;
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
		/// T Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_PItem_Int32;
		public virtual Hvak.Editor.Refleaction.RProperty RPItem_Int32
		{
			get
			{
				if(r_PItem_Int32 == null)
				{
					r_PItem_Int32 = new(this, "Item", -1, typeof(System.Int32));
				}
				return r_PItem_Int32;
			}
		}

		/// <summary>
		/// System.Object System.Collections.IList.Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PSystem__2__Collections__2__IList__2__Item_Int32;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPSystem__2__Collections__2__IList__2__Item_Int32
		{
			get
			{
				if(r_PSystem__2__Collections__2__IList__2__Item_Int32 == null)
				{
					r_PSystem__2__Collections__2__IList__2__Item_Int32 = new(this, "System.Collections.IList.Item", -1, typeof(System.Int32));
				}
				return r_PSystem__2__Collections__2__IList__2__Item_Int32;
			}
		}

		/// <summary>
		/// Boolean IsCompatibleObject(System.Object)
		/// </summary>
		protected static RMethod r_MIsCompatibleObject_Object;
		public static RMethod RMIsCompatibleObject_Object
		{
			get
			{
				if(r_MIsCompatibleObject_Object == null)
				{
					r_MIsCompatibleObject_Object = new(Type, "IsCompatibleObject", 0, typeof(System.Object));
				}
				return r_MIsCompatibleObject_Object;
			}
		}

		/// <summary>
		/// Void Add(T)
		/// </summary>
		protected RMethod r_MAdd_T;
		public virtual RMethod RMAdd_T
		{
			get
			{
				if(r_MAdd_T == null)
				{
					r_MAdd_T = new(this, "Add", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MAdd_T;
			}
		}

		/// <summary>
		/// Void AddWithResize(T)
		/// </summary>
		protected RMethod r_MAddWithResize_T;
		public virtual RMethod RMAddWithResize_T
		{
			get
			{
				if(r_MAddWithResize_T == null)
				{
					r_MAddWithResize_T = new(this, "AddWithResize", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MAddWithResize_T;
			}
		}

		/// <summary>
		/// Int32 System.Collections.IList.Add(System.Object)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IList__2__Add_Object;
		public virtual RMethod RMSystem__2__Collections__2__IList__2__Add_Object
		{
			get
			{
				if(r_MSystem__2__Collections__2__IList__2__Add_Object == null)
				{
					r_MSystem__2__Collections__2__IList__2__Add_Object = new(this, "System.Collections.IList.Add", 0, typeof(System.Object));
				}
				return r_MSystem__2__Collections__2__IList__2__Add_Object;
			}
		}

		/// <summary>
		/// Void AddRange(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_MAddRange_IEnumerable_d_T_p_;
		public virtual RMethod RMAddRange_IEnumerable_d_T_p_
		{
			get
			{
				if(r_MAddRange_IEnumerable_d_T_p_ == null)
				{
					r_MAddRange_IEnumerable_d_T_p_ = new(this, "AddRange", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MAddRange_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[T] AsReadOnly()
		/// </summary>
		protected RMethod r_MAsReadOnly;
		public virtual RMethod RMAsReadOnly
		{
			get
			{
				if(r_MAsReadOnly == null)
				{
					r_MAsReadOnly = new(this, "AsReadOnly", 0);
				}
				return r_MAsReadOnly;
			}
		}

		/// <summary>
		/// Int32 BinarySearch(Int32, Int32, T, System.Collections.Generic.IComparer`1[T])
		/// </summary>
		protected RMethod r_MBinarySearch_Int32_Int32_T_IComparer_d_T_p_;
		public virtual RMethod RMBinarySearch_Int32_Int32_T_IComparer_d_T_p_
		{
			get
			{
				if(r_MBinarySearch_Int32_Int32_T_IComparer_d_T_p_ == null)
				{
					r_MBinarySearch_Int32_Int32_T_IComparer_d_T_p_ = new(this, "BinarySearch", 0, typeof(System.Int32), typeof(System.Int32), Type.MakeGenericMethodParameter(0),  ReflectionUtils.GetType("System.Collections.Generic.IComparer`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MBinarySearch_Int32_Int32_T_IComparer_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 BinarySearch(T)
		/// </summary>
		protected RMethod r_MBinarySearch_T;
		public virtual RMethod RMBinarySearch_T
		{
			get
			{
				if(r_MBinarySearch_T == null)
				{
					r_MBinarySearch_T = new(this, "BinarySearch", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MBinarySearch_T;
			}
		}

		/// <summary>
		/// Int32 BinarySearch(T, System.Collections.Generic.IComparer`1[T])
		/// </summary>
		protected RMethod r_MBinarySearch_T_IComparer_d_T_p_;
		public virtual RMethod RMBinarySearch_T_IComparer_d_T_p_
		{
			get
			{
				if(r_MBinarySearch_T_IComparer_d_T_p_ == null)
				{
					r_MBinarySearch_T_IComparer_d_T_p_ = new(this, "BinarySearch", 0, Type.MakeGenericMethodParameter(0),  ReflectionUtils.GetType("System.Collections.Generic.IComparer`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MBinarySearch_T_IComparer_d_T_p_;
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
				}
				return r_MContains_T;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IList.Contains(System.Object)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IList__2__Contains_Object;
		public virtual RMethod RMSystem__2__Collections__2__IList__2__Contains_Object
		{
			get
			{
				if(r_MSystem__2__Collections__2__IList__2__Contains_Object == null)
				{
					r_MSystem__2__Collections__2__IList__2__Contains_Object = new(this, "System.Collections.IList.Contains", 0, typeof(System.Object));
				}
				return r_MSystem__2__Collections__2__IList__2__Contains_Object;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[TOutput] ConvertAll[TOutput](System.Converter`2[T,TOutput])
		/// </summary>
		protected RMethod r_MConvertAll_GTOutput_Converter_d_T_TOutput_p_;
		public virtual RMethod RMConvertAll_GTOutput_Converter_d_T_TOutput_p_
		{
			get
			{
				if(r_MConvertAll_GTOutput_Converter_d_T_TOutput_p_ == null)
				{
					r_MConvertAll_GTOutput_Converter_d_T_TOutput_p_ = new(this, "ConvertAll", 1,  ReflectionUtils.GetType("System.Converter`2").MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(0)));
				}
				return r_MConvertAll_GTOutput_Converter_d_T_TOutput_p_;
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
				}
				return r_MCopyTo_TArray;
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
		/// Void CopyTo(Int32, T[], Int32, Int32)
		/// </summary>
		protected RMethod r_MCopyTo_Int32_TArray_Int32_Int32;
		public virtual RMethod RMCopyTo_Int32_TArray_Int32_Int32
		{
			get
			{
				if(r_MCopyTo_Int32_TArray_Int32_Int32 == null)
				{
					r_MCopyTo_Int32_TArray_Int32_Int32 = new(this, "CopyTo", 0, typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MCopyTo_Int32_TArray_Int32_Int32;
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
				}
				return r_MCopyTo_TArray_Int32;
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
				}
				return r_MEnsureCapacity_Int32;
			}
		}

		/// <summary>
		/// Boolean Exists(System.Predicate`1[T])
		/// </summary>
		protected RMethod r_MExists_Predicate_d_T_p_;
		public virtual RMethod RMExists_Predicate_d_T_p_
		{
			get
			{
				if(r_MExists_Predicate_d_T_p_ == null)
				{
					r_MExists_Predicate_d_T_p_ = new(this, "Exists", 0,  ReflectionUtils.GetType("System.Predicate`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MExists_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// T Find(System.Predicate`1[T])
		/// </summary>
		protected RMethod r_MFind_Predicate_d_T_p_;
		public virtual RMethod RMFind_Predicate_d_T_p_
		{
			get
			{
				if(r_MFind_Predicate_d_T_p_ == null)
				{
					r_MFind_Predicate_d_T_p_ = new(this, "Find", 0,  ReflectionUtils.GetType("System.Predicate`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MFind_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[T] FindAll(System.Predicate`1[T])
		/// </summary>
		protected RMethod r_MFindAll_Predicate_d_T_p_;
		public virtual RMethod RMFindAll_Predicate_d_T_p_
		{
			get
			{
				if(r_MFindAll_Predicate_d_T_p_ == null)
				{
					r_MFindAll_Predicate_d_T_p_ = new(this, "FindAll", 0,  ReflectionUtils.GetType("System.Predicate`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MFindAll_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 FindIndex(System.Predicate`1[T])
		/// </summary>
		protected RMethod r_MFindIndex_Predicate_d_T_p_;
		public virtual RMethod RMFindIndex_Predicate_d_T_p_
		{
			get
			{
				if(r_MFindIndex_Predicate_d_T_p_ == null)
				{
					r_MFindIndex_Predicate_d_T_p_ = new(this, "FindIndex", 0,  ReflectionUtils.GetType("System.Predicate`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MFindIndex_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 FindIndex(Int32, System.Predicate`1[T])
		/// </summary>
		protected RMethod r_MFindIndex_Int32_Predicate_d_T_p_;
		public virtual RMethod RMFindIndex_Int32_Predicate_d_T_p_
		{
			get
			{
				if(r_MFindIndex_Int32_Predicate_d_T_p_ == null)
				{
					r_MFindIndex_Int32_Predicate_d_T_p_ = new(this, "FindIndex", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Predicate`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MFindIndex_Int32_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 FindIndex(Int32, Int32, System.Predicate`1[T])
		/// </summary>
		protected RMethod r_MFindIndex_Int32_Int32_Predicate_d_T_p_;
		public virtual RMethod RMFindIndex_Int32_Int32_Predicate_d_T_p_
		{
			get
			{
				if(r_MFindIndex_Int32_Int32_Predicate_d_T_p_ == null)
				{
					r_MFindIndex_Int32_Int32_Predicate_d_T_p_ = new(this, "FindIndex", 0, typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Predicate`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MFindIndex_Int32_Int32_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// T FindLast(System.Predicate`1[T])
		/// </summary>
		protected RMethod r_MFindLast_Predicate_d_T_p_;
		public virtual RMethod RMFindLast_Predicate_d_T_p_
		{
			get
			{
				if(r_MFindLast_Predicate_d_T_p_ == null)
				{
					r_MFindLast_Predicate_d_T_p_ = new(this, "FindLast", 0,  ReflectionUtils.GetType("System.Predicate`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MFindLast_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 FindLastIndex(System.Predicate`1[T])
		/// </summary>
		protected RMethod r_MFindLastIndex_Predicate_d_T_p_;
		public virtual RMethod RMFindLastIndex_Predicate_d_T_p_
		{
			get
			{
				if(r_MFindLastIndex_Predicate_d_T_p_ == null)
				{
					r_MFindLastIndex_Predicate_d_T_p_ = new(this, "FindLastIndex", 0,  ReflectionUtils.GetType("System.Predicate`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MFindLastIndex_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 FindLastIndex(Int32, System.Predicate`1[T])
		/// </summary>
		protected RMethod r_MFindLastIndex_Int32_Predicate_d_T_p_;
		public virtual RMethod RMFindLastIndex_Int32_Predicate_d_T_p_
		{
			get
			{
				if(r_MFindLastIndex_Int32_Predicate_d_T_p_ == null)
				{
					r_MFindLastIndex_Int32_Predicate_d_T_p_ = new(this, "FindLastIndex", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Predicate`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MFindLastIndex_Int32_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 FindLastIndex(Int32, Int32, System.Predicate`1[T])
		/// </summary>
		protected RMethod r_MFindLastIndex_Int32_Int32_Predicate_d_T_p_;
		public virtual RMethod RMFindLastIndex_Int32_Int32_Predicate_d_T_p_
		{
			get
			{
				if(r_MFindLastIndex_Int32_Int32_Predicate_d_T_p_ == null)
				{
					r_MFindLastIndex_Int32_Int32_Predicate_d_T_p_ = new(this, "FindLastIndex", 0, typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Predicate`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MFindLastIndex_Int32_Int32_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Void ForEach(System.Action`1[T])
		/// </summary>
		protected RMethod r_MForEach_Action_d_T_p_;
		public virtual RMethod RMForEach_Action_d_T_p_
		{
			get
			{
				if(r_MForEach_Action_d_T_p_ == null)
				{
					r_MForEach_Action_d_T_p_ = new(this, "ForEach", 0,  ReflectionUtils.GetType("System.Action`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MForEach_Action_d_T_p_;
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
				}
				return r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[T] GetRange(Int32, Int32)
		/// </summary>
		protected RMethod r_MGetRange_Int32_Int32;
		public virtual RMethod RMGetRange_Int32_Int32
		{
			get
			{
				if(r_MGetRange_Int32_Int32 == null)
				{
					r_MGetRange_Int32_Int32 = new(this, "GetRange", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MGetRange_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(T)
		/// </summary>
		protected RMethod r_MIndexOf_T;
		public virtual RMethod RMIndexOf_T
		{
			get
			{
				if(r_MIndexOf_T == null)
				{
					r_MIndexOf_T = new(this, "IndexOf", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MIndexOf_T;
			}
		}

		/// <summary>
		/// Int32 System.Collections.IList.IndexOf(System.Object)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IList__2__IndexOf_Object;
		public virtual RMethod RMSystem__2__Collections__2__IList__2__IndexOf_Object
		{
			get
			{
				if(r_MSystem__2__Collections__2__IList__2__IndexOf_Object == null)
				{
					r_MSystem__2__Collections__2__IList__2__IndexOf_Object = new(this, "System.Collections.IList.IndexOf", 0, typeof(System.Object));
				}
				return r_MSystem__2__Collections__2__IList__2__IndexOf_Object;
			}
		}

		/// <summary>
		/// Int32 IndexOf(T, Int32)
		/// </summary>
		protected RMethod r_MIndexOf_T_Int32;
		public virtual RMethod RMIndexOf_T_Int32
		{
			get
			{
				if(r_MIndexOf_T_Int32 == null)
				{
					r_MIndexOf_T_Int32 = new(this, "IndexOf", 0, Type.MakeGenericMethodParameter(0), typeof(System.Int32));
				}
				return r_MIndexOf_T_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(T, Int32, Int32)
		/// </summary>
		protected RMethod r_MIndexOf_T_Int32_Int32;
		public virtual RMethod RMIndexOf_T_Int32_Int32
		{
			get
			{
				if(r_MIndexOf_T_Int32_Int32 == null)
				{
					r_MIndexOf_T_Int32_Int32 = new(this, "IndexOf", 0, Type.MakeGenericMethodParameter(0), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MIndexOf_T_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Insert(Int32, T)
		/// </summary>
		protected RMethod r_MInsert_Int32_T;
		public virtual RMethod RMInsert_Int32_T
		{
			get
			{
				if(r_MInsert_Int32_T == null)
				{
					r_MInsert_Int32_T = new(this, "Insert", 0, typeof(System.Int32), Type.MakeGenericMethodParameter(0));
				}
				return r_MInsert_Int32_T;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.Insert(Int32, System.Object)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IList__2__Insert_Int32_Object;
		public virtual RMethod RMSystem__2__Collections__2__IList__2__Insert_Int32_Object
		{
			get
			{
				if(r_MSystem__2__Collections__2__IList__2__Insert_Int32_Object == null)
				{
					r_MSystem__2__Collections__2__IList__2__Insert_Int32_Object = new(this, "System.Collections.IList.Insert", 0, typeof(System.Int32), typeof(System.Object));
				}
				return r_MSystem__2__Collections__2__IList__2__Insert_Int32_Object;
			}
		}

		/// <summary>
		/// Void InsertRange(Int32, System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_MInsertRange_Int32_IEnumerable_d_T_p_;
		public virtual RMethod RMInsertRange_Int32_IEnumerable_d_T_p_
		{
			get
			{
				if(r_MInsertRange_Int32_IEnumerable_d_T_p_ == null)
				{
					r_MInsertRange_Int32_IEnumerable_d_T_p_ = new(this, "InsertRange", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MInsertRange_Int32_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(T)
		/// </summary>
		protected RMethod r_MLastIndexOf_T;
		public virtual RMethod RMLastIndexOf_T
		{
			get
			{
				if(r_MLastIndexOf_T == null)
				{
					r_MLastIndexOf_T = new(this, "LastIndexOf", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MLastIndexOf_T;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(T, Int32)
		/// </summary>
		protected RMethod r_MLastIndexOf_T_Int32;
		public virtual RMethod RMLastIndexOf_T_Int32
		{
			get
			{
				if(r_MLastIndexOf_T_Int32 == null)
				{
					r_MLastIndexOf_T_Int32 = new(this, "LastIndexOf", 0, Type.MakeGenericMethodParameter(0), typeof(System.Int32));
				}
				return r_MLastIndexOf_T_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(T, Int32, Int32)
		/// </summary>
		protected RMethod r_MLastIndexOf_T_Int32_Int32;
		public virtual RMethod RMLastIndexOf_T_Int32_Int32
		{
			get
			{
				if(r_MLastIndexOf_T_Int32_Int32 == null)
				{
					r_MLastIndexOf_T_Int32_Int32 = new(this, "LastIndexOf", 0, Type.MakeGenericMethodParameter(0), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MLastIndexOf_T_Int32_Int32;
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
				}
				return r_MRemove_T;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.Remove(System.Object)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IList__2__Remove_Object;
		public virtual RMethod RMSystem__2__Collections__2__IList__2__Remove_Object
		{
			get
			{
				if(r_MSystem__2__Collections__2__IList__2__Remove_Object == null)
				{
					r_MSystem__2__Collections__2__IList__2__Remove_Object = new(this, "System.Collections.IList.Remove", 0, typeof(System.Object));
				}
				return r_MSystem__2__Collections__2__IList__2__Remove_Object;
			}
		}

		/// <summary>
		/// Int32 RemoveAll(System.Predicate`1[T])
		/// </summary>
		protected RMethod r_MRemoveAll_Predicate_d_T_p_;
		public virtual RMethod RMRemoveAll_Predicate_d_T_p_
		{
			get
			{
				if(r_MRemoveAll_Predicate_d_T_p_ == null)
				{
					r_MRemoveAll_Predicate_d_T_p_ = new(this, "RemoveAll", 0,  ReflectionUtils.GetType("System.Predicate`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MRemoveAll_Predicate_d_T_p_;
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
				}
				return r_MRemoveRange_Int32_Int32;
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
				}
				return r_MReverse_Int32_Int32;
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
				}
				return r_MSort;
			}
		}

		/// <summary>
		/// Void Sort(System.Collections.Generic.IComparer`1[T])
		/// </summary>
		protected RMethod r_MSort_IComparer_d_T_p_;
		public virtual RMethod RMSort_IComparer_d_T_p_
		{
			get
			{
				if(r_MSort_IComparer_d_T_p_ == null)
				{
					r_MSort_IComparer_d_T_p_ = new(this, "Sort", 0,  ReflectionUtils.GetType("System.Collections.Generic.IComparer`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MSort_IComparer_d_T_p_;
			}
		}

		/// <summary>
		/// Void Sort(Int32, Int32, System.Collections.Generic.IComparer`1[T])
		/// </summary>
		protected RMethod r_MSort_Int32_Int32_IComparer_d_T_p_;
		public virtual RMethod RMSort_Int32_Int32_IComparer_d_T_p_
		{
			get
			{
				if(r_MSort_Int32_Int32_IComparer_d_T_p_ == null)
				{
					r_MSort_Int32_Int32_IComparer_d_T_p_ = new(this, "Sort", 0, typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.IComparer`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MSort_Int32_Int32_IComparer_d_T_p_;
			}
		}

		/// <summary>
		/// Void Sort(System.Comparison`1[T])
		/// </summary>
		protected RMethod r_MSort_Comparison_d_T_p_;
		public virtual RMethod RMSort_Comparison_d_T_p_
		{
			get
			{
				if(r_MSort_Comparison_d_T_p_ == null)
				{
					r_MSort_Comparison_d_T_p_ = new(this, "Sort", 0,  ReflectionUtils.GetType("System.Comparison`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MSort_Comparison_d_T_p_;
			}
		}

		/// <summary>
		/// T[] ToArray()
		/// </summary>
		protected RMethod r_MToArray;
		public virtual RMethod RMToArray
		{
			get
			{
				if(r_MToArray == null)
				{
					r_MToArray = new(this, "ToArray", 0);
				}
				return r_MToArray;
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
		/// Boolean TrueForAll(System.Predicate`1[T])
		/// </summary>
		protected RMethod r_MTrueForAll_Predicate_d_T_p_;
		public virtual RMethod RMTrueForAll_Predicate_d_T_p_
		{
			get
			{
				if(r_MTrueForAll_Predicate_d_T_p_ == null)
				{
					r_MTrueForAll_Predicate_d_T_p_ = new(this, "TrueForAll", 0,  ReflectionUtils.GetType("System.Predicate`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MTrueForAll_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Void AddEnumerable(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_MAddEnumerable_IEnumerable_d_T_p_;
		public virtual RMethod RMAddEnumerable_IEnumerable_d_T_p_
		{
			get
			{
				if(r_MAddEnumerable_IEnumerable_d_T_p_ == null)
				{
					r_MAddEnumerable_IEnumerable_d_T_p_ = new(this, "AddEnumerable", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MAddEnumerable_IEnumerable_d_T_p_;
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


        public static System.Boolean IsCompatibleObject(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMIsCompatibleObject_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Add(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMAdd_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddWithResize(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMAddWithResize_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 System__2__Collections__2__IList__2__Add(System.Object @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMSystem__2__Collections__2__IList__2__Add_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual void AddRange(System.Collections.Generic.IEnumerable<T> @collection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@collection};
            var ___result = RMAddRange_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.ObjectModel.ReadOnlyCollection<T> AsReadOnly()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAsReadOnly.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.ObjectModel.ReadOnlyCollection<T>>(___result);
        }


        public virtual System.Int32 BinarySearch(System.Int32 @index, System.Int32 @count, T @item, System.Collections.Generic.IComparer<T> @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @count, @item, @comparer};
            var ___result = RMBinarySearch_Int32_Int32_T_IComparer_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 BinarySearch(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMBinarySearch_T.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 BinarySearch(T @item, System.Collections.Generic.IComparer<T> @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item, @comparer};
            var ___result = RMBinarySearch_T_IComparer_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
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

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean System__2__Collections__2__IList__2__Contains(System.Object @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMSystem__2__Collections__2__IList__2__Contains_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Collections.Generic.List<TOutput> ConvertAll<TOutput>(System.Converter<T, TOutput> @converter)
        {

            var ___genericsType = new Type[] {typeof(TOutput)};
            var ___parameters = new object[]{@converter};
            var ___result = RMConvertAll_GTOutput_Converter_d_T_TOutput_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.List<TOutput>>(___result);
        }


        public virtual void CopyTo(T[] @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array};
            var ___result = RMCopyTo_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__ICollection__2__CopyTo(System.Array @array, System.Int32 @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RMSystem__2__Collections__2__ICollection__2__CopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Int32 @index, T[] @array, System.Int32 @arrayIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @array, @arrayIndex, @count};
            var ___result = RMCopyTo_Int32_TArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(T[] @array, System.Int32 @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RMCopyTo_TArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnsureCapacity(System.Int32 @min)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@min};
            var ___result = RMEnsureCapacity_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Exists(System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@match};
            var ___result = RMExists_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual T Find(System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@match};
            var ___result = RMFind_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public virtual System.Collections.Generic.List<T> FindAll(System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@match};
            var ___result = RMFindAll_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.List<T>>(___result);
        }


        public virtual System.Int32 FindIndex(System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@match};
            var ___result = RMFindIndex_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 FindIndex(System.Int32 @startIndex, System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @match};
            var ___result = RMFindIndex_Int32_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 FindIndex(System.Int32 @startIndex, System.Int32 @count, System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @count, @match};
            var ___result = RMFindIndex_Int32_Int32_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual T FindLast(System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@match};
            var ___result = RMFindLast_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public virtual System.Int32 FindLastIndex(System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@match};
            var ___result = RMFindLastIndex_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 FindLastIndex(System.Int32 @startIndex, System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @match};
            var ___result = RMFindLastIndex_Int32_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 FindLastIndex(System.Int32 @startIndex, System.Int32 @count, System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @count, @match};
            var ___result = RMFindLastIndex_Int32_Int32_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual void ForEach(System.Action<T> @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = RMForEach_Action_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RType>.REnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RType>.REnumerator>(___result);
        }


        public virtual System.Collections.Generic.IEnumerator<T> System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.IEnumerator<T>>(___result);
        }


        public virtual System.Collections.IEnumerator System__2__Collections__2__IEnumerable__2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.IEnumerator>(___result);
        }


        public virtual System.Collections.Generic.List<T> GetRange(System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @count};
            var ___result = RMGetRange_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.List<T>>(___result);
        }


        public virtual System.Int32 IndexOf(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMIndexOf_T.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 System__2__Collections__2__IList__2__IndexOf(System.Object @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMSystem__2__Collections__2__IList__2__IndexOf_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 IndexOf(T @item, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item, @index};
            var ___result = RMIndexOf_T_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 IndexOf(T @item, System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item, @index, @count};
            var ___result = RMIndexOf_T_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual void Insert(System.Int32 @index, T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @item};
            var ___result = RMInsert_Int32_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__IList__2__Insert(System.Int32 @index, System.Object @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @item};
            var ___result = RMSystem__2__Collections__2__IList__2__Insert_Int32_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertRange(System.Int32 @index, System.Collections.Generic.IEnumerable<T> @collection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @collection};
            var ___result = RMInsertRange_Int32_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 LastIndexOf(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMLastIndexOf_T.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 LastIndexOf(T @item, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item, @index};
            var ___result = RMLastIndexOf_T_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 LastIndexOf(T @item, System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item, @index, @count};
            var ___result = RMLastIndexOf_T_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Remove(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMRemove_T.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void System__2__Collections__2__IList__2__Remove(System.Object @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMSystem__2__Collections__2__IList__2__Remove_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 RemoveAll(System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@match};
            var ___result = RMRemoveAll_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
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


        public virtual void Sort()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSort.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Sort(System.Collections.Generic.IComparer<T> @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comparer};
            var ___result = RMSort_IComparer_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Sort(System.Int32 @index, System.Int32 @count, System.Collections.Generic.IComparer<T> @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @count, @comparer};
            var ___result = RMSort_Int32_Int32_IComparer_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Sort(System.Comparison<T> @comparison)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comparison};
            var ___result = RMSort_Comparison_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T[] ToArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T[]>(___result);
        }


        public virtual void TrimExcess()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTrimExcess.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TrueForAll(System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@match};
            var ___result = RMTrueForAll_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void AddEnumerable(System.Collections.Generic.IEnumerable<T> @enumerable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumerable};
            var ___result = RMAddEnumerable_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
