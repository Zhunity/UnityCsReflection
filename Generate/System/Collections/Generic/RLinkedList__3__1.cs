using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
	/// System.Collections.Generic.LinkedList`1
	/// </summary>
    public partial class RLinkedList<T> : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] head
		/// </summary>
		protected RSystem.RCollections.RGeneric.RLinkedListNode<RField> r_head;
		public virtual RSystem.RCollections.RGeneric.RLinkedListNode<RField> Rhead
		{
			get
			{
				if(r_head == null)
				{
					r_head = new(this, "head");
					r_head.SetBelong(this.instance);
				}
				return r_head;
			}
		}

		/// <summary>
		/// System.Int32 count
		/// </summary>
		protected RSystem.RInt32 r_count;
		public virtual RSystem.RInt32 Rcount
		{
			get
			{
				if(r_count == null)
				{
					r_count = new(this, "count");
					r_count.SetBelong(this.instance);
				}
				return r_count;
			}
		}

		/// <summary>
		/// System.Int32 version
		/// </summary>
		protected RSystem.RInt32 r_version;
		public virtual RSystem.RInt32 Rversion
		{
			get
			{
				if(r_version == null)
				{
					r_version = new(this, "version");
					r_version.SetBelong(this.instance);
				}
				return r_version;
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
		/// System.String VersionName
		/// </summary>
		protected static RSystem.RString r_VersionName;
		public static RSystem.RString RVersionName
		{
			get
			{
				if(r_VersionName == null)
				{
					r_VersionName = new(typeof(System.Collections.Generic.LinkedList<>), "VersionName");
					r_VersionName.SetBelong(null);
				}
				return r_VersionName;
			}
		}

		/// <summary>
		/// System.String CountName
		/// </summary>
		protected static RSystem.RString r_CountName;
		public static RSystem.RString RCountName
		{
			get
			{
				if(r_CountName == null)
				{
					r_CountName = new(typeof(System.Collections.Generic.LinkedList<>), "CountName");
					r_CountName.SetBelong(null);
				}
				return r_CountName;
			}
		}

		/// <summary>
		/// System.String ValuesName
		/// </summary>
		protected static RSystem.RString r_ValuesName;
		public static RSystem.RString RValuesName
		{
			get
			{
				if(r_ValuesName == null)
				{
					r_ValuesName = new(typeof(System.Collections.Generic.LinkedList<>), "ValuesName");
					r_ValuesName.SetBelong(null);
				}
				return r_ValuesName;
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
		/// System.Collections.Generic.LinkedListNode`1[T] First
		/// </summary>
		protected RSystem.RCollections.RGeneric.RLinkedListNode<RProperty> r_First;
		public virtual RSystem.RCollections.RGeneric.RLinkedListNode<RProperty> RFirst
		{
			get
			{
				if(r_First == null)
				{
					r_First = new(this, "First", -1);
					r_First.SetBelong(this.instance);
				}
				return r_First;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] Last
		/// </summary>
		protected RSystem.RCollections.RGeneric.RLinkedListNode<RProperty> r_Last;
		public virtual RSystem.RCollections.RGeneric.RLinkedListNode<RProperty> RLast
		{
			get
			{
				if(r_Last == null)
				{
					r_Last = new(this, "Last", -1);
					r_Last.SetBelong(this.instance);
				}
				return r_Last;
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
		/// Boolean System.Collections.ICollection.IsSynchronized
		/// </summary>
		protected RSystem.RBoolean r_System__2__Collections__2__ICollection__2__IsSynchronized;
		public virtual RSystem.RBoolean RSystem__2__Collections__2__ICollection__2__IsSynchronized
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
		/// System.Collections.Generic.LinkedListNode`1[T] AddAfter(System.Collections.Generic.LinkedListNode`1[T], T)
		/// </summary>
		protected RMethod r_AddAfter_LinkedListNode_d_T_p__T;
		public virtual RMethod RAddAfter_LinkedListNode_d_T_p__T
		{
			get
			{
				if(r_AddAfter_LinkedListNode_d_T_p__T == null)
				{
					r_AddAfter_LinkedListNode_d_T_p__T = new(this, "AddAfter", 0, typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0));
					r_AddAfter_LinkedListNode_d_T_p__T.SetBelong(this.instance);
				}
				return r_AddAfter_LinkedListNode_d_T_p__T;
			}
		}

		/// <summary>
		/// Void AddAfter(System.Collections.Generic.LinkedListNode`1[T], System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_AddAfter_LinkedListNode_d_T_p__LinkedListNode_d_T_p_;
		public virtual RMethod RAddAfter_LinkedListNode_d_T_p__LinkedListNode_d_T_p_
		{
			get
			{
				if(r_AddAfter_LinkedListNode_d_T_p__LinkedListNode_d_T_p_ == null)
				{
					r_AddAfter_LinkedListNode_d_T_p__LinkedListNode_d_T_p_ = new(this, "AddAfter", 0, typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_AddAfter_LinkedListNode_d_T_p__LinkedListNode_d_T_p_.SetBelong(this.instance);
				}
				return r_AddAfter_LinkedListNode_d_T_p__LinkedListNode_d_T_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] AddBefore(System.Collections.Generic.LinkedListNode`1[T], T)
		/// </summary>
		protected RMethod r_AddBefore_LinkedListNode_d_T_p__T;
		public virtual RMethod RAddBefore_LinkedListNode_d_T_p__T
		{
			get
			{
				if(r_AddBefore_LinkedListNode_d_T_p__T == null)
				{
					r_AddBefore_LinkedListNode_d_T_p__T = new(this, "AddBefore", 0, typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0));
					r_AddBefore_LinkedListNode_d_T_p__T.SetBelong(this.instance);
				}
				return r_AddBefore_LinkedListNode_d_T_p__T;
			}
		}

		/// <summary>
		/// Void AddBefore(System.Collections.Generic.LinkedListNode`1[T], System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_AddBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_;
		public virtual RMethod RAddBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_
		{
			get
			{
				if(r_AddBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_ == null)
				{
					r_AddBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_ = new(this, "AddBefore", 0, typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_AddBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_.SetBelong(this.instance);
				}
				return r_AddBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] AddFirst(T)
		/// </summary>
		protected RMethod r_AddFirst_T;
		public virtual RMethod RAddFirst_T
		{
			get
			{
				if(r_AddFirst_T == null)
				{
					r_AddFirst_T = new(this, "AddFirst", 0, Type.MakeGenericMethodParameter(0));
					r_AddFirst_T.SetBelong(this.instance);
				}
				return r_AddFirst_T;
			}
		}

		/// <summary>
		/// Void AddFirst(System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_AddFirst_LinkedListNode_d_T_p_;
		public virtual RMethod RAddFirst_LinkedListNode_d_T_p_
		{
			get
			{
				if(r_AddFirst_LinkedListNode_d_T_p_ == null)
				{
					r_AddFirst_LinkedListNode_d_T_p_ = new(this, "AddFirst", 0, typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_AddFirst_LinkedListNode_d_T_p_.SetBelong(this.instance);
				}
				return r_AddFirst_LinkedListNode_d_T_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] AddLast(T)
		/// </summary>
		protected RMethod r_AddLast_T;
		public virtual RMethod RAddLast_T
		{
			get
			{
				if(r_AddLast_T == null)
				{
					r_AddLast_T = new(this, "AddLast", 0, Type.MakeGenericMethodParameter(0));
					r_AddLast_T.SetBelong(this.instance);
				}
				return r_AddLast_T;
			}
		}

		/// <summary>
		/// Void AddLast(System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_AddLast_LinkedListNode_d_T_p_;
		public virtual RMethod RAddLast_LinkedListNode_d_T_p_
		{
			get
			{
				if(r_AddLast_LinkedListNode_d_T_p_ == null)
				{
					r_AddLast_LinkedListNode_d_T_p_ = new(this, "AddLast", 0, typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_AddLast_LinkedListNode_d_T_p_.SetBelong(this.instance);
				}
				return r_AddLast_LinkedListNode_d_T_p_;
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
		/// System.Collections.Generic.LinkedListNode`1[T] Find(T)
		/// </summary>
		protected RMethod r_Find_T;
		public virtual RMethod RFind_T
		{
			get
			{
				if(r_Find_T == null)
				{
					r_Find_T = new(this, "Find", 0, Type.MakeGenericMethodParameter(0));
					r_Find_T.SetBelong(this.instance);
				}
				return r_Find_T;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] FindLast(T)
		/// </summary>
		protected RMethod r_FindLast_T;
		public virtual RMethod RFindLast_T
		{
			get
			{
				if(r_FindLast_T == null)
				{
					r_FindLast_T = new(this, "FindLast", 0, Type.MakeGenericMethodParameter(0));
					r_FindLast_T.SetBelong(this.instance);
				}
				return r_FindLast_T;
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
		/// Void Remove(System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_Remove_LinkedListNode_d_T_p_;
		public virtual RMethod RRemove_LinkedListNode_d_T_p_
		{
			get
			{
				if(r_Remove_LinkedListNode_d_T_p_ == null)
				{
					r_Remove_LinkedListNode_d_T_p_ = new(this, "Remove", 0, typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_Remove_LinkedListNode_d_T_p_.SetBelong(this.instance);
				}
				return r_Remove_LinkedListNode_d_T_p_;
			}
		}

		/// <summary>
		/// Void RemoveFirst()
		/// </summary>
		protected RMethod r_RemoveFirst;
		public virtual RMethod RRemoveFirst
		{
			get
			{
				if(r_RemoveFirst == null)
				{
					r_RemoveFirst = new(this, "RemoveFirst", 0);
					r_RemoveFirst.SetBelong(this.instance);
				}
				return r_RemoveFirst;
			}
		}

		/// <summary>
		/// Void RemoveLast()
		/// </summary>
		protected RMethod r_RemoveLast;
		public virtual RMethod RRemoveLast
		{
			get
			{
				if(r_RemoveLast == null)
				{
					r_RemoveLast = new(this, "RemoveLast", 0);
					r_RemoveLast.SetBelong(this.instance);
				}
				return r_RemoveLast;
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
		/// Void InternalInsertNodeBefore(System.Collections.Generic.LinkedListNode`1[T], System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_InternalInsertNodeBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_;
		public virtual RMethod RInternalInsertNodeBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_
		{
			get
			{
				if(r_InternalInsertNodeBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_ == null)
				{
					r_InternalInsertNodeBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_ = new(this, "InternalInsertNodeBefore", 0, typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_InternalInsertNodeBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_.SetBelong(this.instance);
				}
				return r_InternalInsertNodeBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_;
			}
		}

		/// <summary>
		/// Void InternalInsertNodeToEmptyList(System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_InternalInsertNodeToEmptyList_LinkedListNode_d_T_p_;
		public virtual RMethod RInternalInsertNodeToEmptyList_LinkedListNode_d_T_p_
		{
			get
			{
				if(r_InternalInsertNodeToEmptyList_LinkedListNode_d_T_p_ == null)
				{
					r_InternalInsertNodeToEmptyList_LinkedListNode_d_T_p_ = new(this, "InternalInsertNodeToEmptyList", 0, typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_InternalInsertNodeToEmptyList_LinkedListNode_d_T_p_.SetBelong(this.instance);
				}
				return r_InternalInsertNodeToEmptyList_LinkedListNode_d_T_p_;
			}
		}

		/// <summary>
		/// Void InternalRemoveNode(System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_InternalRemoveNode_LinkedListNode_d_T_p_;
		public virtual RMethod RInternalRemoveNode_LinkedListNode_d_T_p_
		{
			get
			{
				if(r_InternalRemoveNode_LinkedListNode_d_T_p_ == null)
				{
					r_InternalRemoveNode_LinkedListNode_d_T_p_ = new(this, "InternalRemoveNode", 0, typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_InternalRemoveNode_LinkedListNode_d_T_p_.SetBelong(this.instance);
				}
				return r_InternalRemoveNode_LinkedListNode_d_T_p_;
			}
		}

		/// <summary>
		/// Void ValidateNewNode(System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_ValidateNewNode_LinkedListNode_d_T_p_;
		public virtual RMethod RValidateNewNode_LinkedListNode_d_T_p_
		{
			get
			{
				if(r_ValidateNewNode_LinkedListNode_d_T_p_ == null)
				{
					r_ValidateNewNode_LinkedListNode_d_T_p_ = new(this, "ValidateNewNode", 0, typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_ValidateNewNode_LinkedListNode_d_T_p_.SetBelong(this.instance);
				}
				return r_ValidateNewNode_LinkedListNode_d_T_p_;
			}
		}

		/// <summary>
		/// Void ValidateNode(System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_ValidateNode_LinkedListNode_d_T_p_;
		public virtual RMethod RValidateNode_LinkedListNode_d_T_p_
		{
			get
			{
				if(r_ValidateNode_LinkedListNode_d_T_p_ == null)
				{
					r_ValidateNode_LinkedListNode_d_T_p_ = new(this, "ValidateNode", 0, typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_ValidateNode_LinkedListNode_d_T_p_.SetBelong(this.instance);
				}
				return r_ValidateNode_LinkedListNode_d_T_p_;
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


        public RLinkedList() : base("System.Collections.Generic.LinkedList`1")
        {
        }

        public RLinkedList(System.Object instance) : base("System.Collections.Generic.LinkedList`1")
		{
            SetInstance(instance);
		}

        public RLinkedList(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLinkedList(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Add(T @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Add_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.LinkedListNode<T> AddAfter(System.Collections.Generic.LinkedListNode<T> @node, T @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @value};
            var ___result = RAddAfter_LinkedListNode_d_T_p__T.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.LinkedListNode<T>)___result;
        }


        public virtual void AddAfter(System.Collections.Generic.LinkedListNode<T> @node, System.Collections.Generic.LinkedListNode<T> @newNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @newNode};
            var ___result = RAddAfter_LinkedListNode_d_T_p__LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.LinkedListNode<T> AddBefore(System.Collections.Generic.LinkedListNode<T> @node, T @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @value};
            var ___result = RAddBefore_LinkedListNode_d_T_p__T.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.LinkedListNode<T>)___result;
        }


        public virtual void AddBefore(System.Collections.Generic.LinkedListNode<T> @node, System.Collections.Generic.LinkedListNode<T> @newNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @newNode};
            var ___result = RAddBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.LinkedListNode<T> AddFirst(T @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAddFirst_T.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.LinkedListNode<T>)___result;
        }


        public virtual void AddFirst(System.Collections.Generic.LinkedListNode<T> @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RAddFirst_LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.LinkedListNode<T> AddLast(T @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAddLast_T.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.LinkedListNode<T>)___result;
        }


        public virtual void AddLast(System.Collections.Generic.LinkedListNode<T> @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RAddLast_LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Contains(T @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RContains_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CopyTo(T[] @array, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RCopyTo_TArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.LinkedListNode<T> Find(T @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RFind_T.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.LinkedListNode<T>)___result;
        }


        public virtual System.Collections.Generic.LinkedListNode<T> FindLast(T @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RFindLast_T.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.LinkedListNode<T>)___result;
        }


        public virtual RSystem.RCollections.RGeneric.RLinkedList<RType>.REnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return new RSystem.RCollections.RGeneric.RLinkedList<RType>.REnumerator(___result);
        }


        public virtual System.Collections.Generic.IEnumerator<T> System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerator<T>)___result;
        }


        public virtual System.Boolean Remove(T @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RRemove_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Remove(System.Collections.Generic.LinkedListNode<T> @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RRemove_LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFirst()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRemoveFirst.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveLast()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRemoveLast.Invoke(___genericsType, ___parameters);

            
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


        public virtual void InternalInsertNodeBefore(System.Collections.Generic.LinkedListNode<T> @node, System.Collections.Generic.LinkedListNode<T> @newNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @newNode};
            var ___result = RInternalInsertNodeBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalInsertNodeToEmptyList(System.Collections.Generic.LinkedListNode<T> @newNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newNode};
            var ___result = RInternalInsertNodeToEmptyList_LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalRemoveNode(System.Collections.Generic.LinkedListNode<T> @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RInternalRemoveNode_LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ValidateNewNode(System.Collections.Generic.LinkedListNode<T> @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RValidateNewNode_LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ValidateNode(System.Collections.Generic.LinkedListNode<T> @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RValidateNode_LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__ICollection__2__CopyTo(System.Array @array, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RSystem__2__Collections__2__ICollection__2__CopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator System__2__Collections__2__IEnumerable__2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__2__Collections__2__IEnumerable__2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
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
