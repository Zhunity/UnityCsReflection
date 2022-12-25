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
		protected RField r_count;
		public virtual RField Rcount
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
		protected RField r_version;
		public virtual RField Rversion
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
		protected static RField r_VersionName;
		public static RField RVersionName
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
		protected static RField r_CountName;
		public static RField RCountName
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
		protected static RField r_ValuesName;
		public static RField RValuesName
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
		/// Boolean System.Collections.ICollection.IsSynchronized
		/// </summary>
		protected RProperty r_RSystem__0__Collections__0__ICollection__0__get_IsSynchronized;
		public virtual RProperty RSystem__0__Collections__0__ICollection__0__get_IsSynchronized
		{
			get
			{
				if(r_RSystem__0__Collections__0__ICollection__0__get_IsSynchronized == null)
				{
					r_RSystem__0__Collections__0__ICollection__0__get_IsSynchronized = new(this, "System.Collections.ICollection.IsSynchronized", -1);
					r_RSystem__0__Collections__0__ICollection__0__get_IsSynchronized.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__ICollection__0__get_IsSynchronized;
			}
		}

		/// <summary>
		/// System.Object System.Collections.ICollection.SyncRoot
		/// </summary>
		protected RSystem.RObject r_RSystem__0__Collections__0__ICollection__0__get_SyncRoot;
		public virtual RSystem.RObject RSystem__0__Collections__0__ICollection__0__get_SyncRoot
		{
			get
			{
				if(r_RSystem__0__Collections__0__ICollection__0__get_SyncRoot == null)
				{
					r_RSystem__0__Collections__0__ICollection__0__get_SyncRoot = new(this, "System.Collections.ICollection.SyncRoot", -1);
					r_RSystem__0__Collections__0__ICollection__0__get_SyncRoot.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__ICollection__0__get_SyncRoot;
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
		/// System.Collections.Generic.LinkedListNode`1[T] AddAfter(System.Collections.Generic.LinkedListNode`1[T], T)
		/// </summary>
		protected RMethod r_RAddAfter_LinkedListNode_d_T_p__T;
		public virtual RMethod RAddAfter_LinkedListNode_d_T_p__T
		{
			get
			{
				if(r_RAddAfter_LinkedListNode_d_T_p__T == null)
				{
					r_RAddAfter_LinkedListNode_d_T_p__T = new(this, "AddAfter", 0, typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0));
					r_RAddAfter_LinkedListNode_d_T_p__T.SetBelong(this.instance);
				}
				return r_RAddAfter_LinkedListNode_d_T_p__T;
			}
		}

		/// <summary>
		/// Void AddAfter(System.Collections.Generic.LinkedListNode`1[T], System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_RAddAfter_LinkedListNode_d_T_p__LinkedListNode_d_T_p_;
		public virtual RMethod RAddAfter_LinkedListNode_d_T_p__LinkedListNode_d_T_p_
		{
			get
			{
				if(r_RAddAfter_LinkedListNode_d_T_p__LinkedListNode_d_T_p_ == null)
				{
					r_RAddAfter_LinkedListNode_d_T_p__LinkedListNode_d_T_p_ = new(this, "AddAfter", 0, typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RAddAfter_LinkedListNode_d_T_p__LinkedListNode_d_T_p_.SetBelong(this.instance);
				}
				return r_RAddAfter_LinkedListNode_d_T_p__LinkedListNode_d_T_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] AddBefore(System.Collections.Generic.LinkedListNode`1[T], T)
		/// </summary>
		protected RMethod r_RAddBefore_LinkedListNode_d_T_p__T;
		public virtual RMethod RAddBefore_LinkedListNode_d_T_p__T
		{
			get
			{
				if(r_RAddBefore_LinkedListNode_d_T_p__T == null)
				{
					r_RAddBefore_LinkedListNode_d_T_p__T = new(this, "AddBefore", 0, typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0));
					r_RAddBefore_LinkedListNode_d_T_p__T.SetBelong(this.instance);
				}
				return r_RAddBefore_LinkedListNode_d_T_p__T;
			}
		}

		/// <summary>
		/// Void AddBefore(System.Collections.Generic.LinkedListNode`1[T], System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_RAddBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_;
		public virtual RMethod RAddBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_
		{
			get
			{
				if(r_RAddBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_ == null)
				{
					r_RAddBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_ = new(this, "AddBefore", 0, typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RAddBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_.SetBelong(this.instance);
				}
				return r_RAddBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] AddFirst(T)
		/// </summary>
		protected RMethod r_RAddFirst_T;
		public virtual RMethod RAddFirst_T
		{
			get
			{
				if(r_RAddFirst_T == null)
				{
					r_RAddFirst_T = new(this, "AddFirst", 0, Type.MakeGenericMethodParameter(0));
					r_RAddFirst_T.SetBelong(this.instance);
				}
				return r_RAddFirst_T;
			}
		}

		/// <summary>
		/// Void AddFirst(System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_RAddFirst_LinkedListNode_d_T_p_;
		public virtual RMethod RAddFirst_LinkedListNode_d_T_p_
		{
			get
			{
				if(r_RAddFirst_LinkedListNode_d_T_p_ == null)
				{
					r_RAddFirst_LinkedListNode_d_T_p_ = new(this, "AddFirst", 0, typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RAddFirst_LinkedListNode_d_T_p_.SetBelong(this.instance);
				}
				return r_RAddFirst_LinkedListNode_d_T_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] AddLast(T)
		/// </summary>
		protected RMethod r_RAddLast_T;
		public virtual RMethod RAddLast_T
		{
			get
			{
				if(r_RAddLast_T == null)
				{
					r_RAddLast_T = new(this, "AddLast", 0, Type.MakeGenericMethodParameter(0));
					r_RAddLast_T.SetBelong(this.instance);
				}
				return r_RAddLast_T;
			}
		}

		/// <summary>
		/// Void AddLast(System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_RAddLast_LinkedListNode_d_T_p_;
		public virtual RMethod RAddLast_LinkedListNode_d_T_p_
		{
			get
			{
				if(r_RAddLast_LinkedListNode_d_T_p_ == null)
				{
					r_RAddLast_LinkedListNode_d_T_p_ = new(this, "AddLast", 0, typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RAddLast_LinkedListNode_d_T_p_.SetBelong(this.instance);
				}
				return r_RAddLast_LinkedListNode_d_T_p_;
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
		/// System.Collections.Generic.LinkedListNode`1[T] Find(T)
		/// </summary>
		protected RMethod r_RFind_T;
		public virtual RMethod RFind_T
		{
			get
			{
				if(r_RFind_T == null)
				{
					r_RFind_T = new(this, "Find", 0, Type.MakeGenericMethodParameter(0));
					r_RFind_T.SetBelong(this.instance);
				}
				return r_RFind_T;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] FindLast(T)
		/// </summary>
		protected RMethod r_RFindLast_T;
		public virtual RMethod RFindLast_T
		{
			get
			{
				if(r_RFindLast_T == null)
				{
					r_RFindLast_T = new(this, "FindLast", 0, Type.MakeGenericMethodParameter(0));
					r_RFindLast_T.SetBelong(this.instance);
				}
				return r_RFindLast_T;
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
		/// Void Remove(System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_RRemove_LinkedListNode_d_T_p_;
		public virtual RMethod RRemove_LinkedListNode_d_T_p_
		{
			get
			{
				if(r_RRemove_LinkedListNode_d_T_p_ == null)
				{
					r_RRemove_LinkedListNode_d_T_p_ = new(this, "Remove", 0, typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RRemove_LinkedListNode_d_T_p_.SetBelong(this.instance);
				}
				return r_RRemove_LinkedListNode_d_T_p_;
			}
		}

		/// <summary>
		/// Void RemoveFirst()
		/// </summary>
		protected RMethod r_RRemoveFirst;
		public virtual RMethod RRemoveFirst
		{
			get
			{
				if(r_RRemoveFirst == null)
				{
					r_RRemoveFirst = new(this, "RemoveFirst", 0);
					r_RRemoveFirst.SetBelong(this.instance);
				}
				return r_RRemoveFirst;
			}
		}

		/// <summary>
		/// Void RemoveLast()
		/// </summary>
		protected RMethod r_RRemoveLast;
		public virtual RMethod RRemoveLast
		{
			get
			{
				if(r_RRemoveLast == null)
				{
					r_RRemoveLast = new(this, "RemoveLast", 0);
					r_RRemoveLast.SetBelong(this.instance);
				}
				return r_RRemoveLast;
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
		/// Void InternalInsertNodeBefore(System.Collections.Generic.LinkedListNode`1[T], System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_RInternalInsertNodeBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_;
		public virtual RMethod RInternalInsertNodeBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_
		{
			get
			{
				if(r_RInternalInsertNodeBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_ == null)
				{
					r_RInternalInsertNodeBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_ = new(this, "InternalInsertNodeBefore", 0, typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RInternalInsertNodeBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_.SetBelong(this.instance);
				}
				return r_RInternalInsertNodeBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_;
			}
		}

		/// <summary>
		/// Void InternalInsertNodeToEmptyList(System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_RInternalInsertNodeToEmptyList_LinkedListNode_d_T_p_;
		public virtual RMethod RInternalInsertNodeToEmptyList_LinkedListNode_d_T_p_
		{
			get
			{
				if(r_RInternalInsertNodeToEmptyList_LinkedListNode_d_T_p_ == null)
				{
					r_RInternalInsertNodeToEmptyList_LinkedListNode_d_T_p_ = new(this, "InternalInsertNodeToEmptyList", 0, typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RInternalInsertNodeToEmptyList_LinkedListNode_d_T_p_.SetBelong(this.instance);
				}
				return r_RInternalInsertNodeToEmptyList_LinkedListNode_d_T_p_;
			}
		}

		/// <summary>
		/// Void InternalRemoveNode(System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_RInternalRemoveNode_LinkedListNode_d_T_p_;
		public virtual RMethod RInternalRemoveNode_LinkedListNode_d_T_p_
		{
			get
			{
				if(r_RInternalRemoveNode_LinkedListNode_d_T_p_ == null)
				{
					r_RInternalRemoveNode_LinkedListNode_d_T_p_ = new(this, "InternalRemoveNode", 0, typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RInternalRemoveNode_LinkedListNode_d_T_p_.SetBelong(this.instance);
				}
				return r_RInternalRemoveNode_LinkedListNode_d_T_p_;
			}
		}

		/// <summary>
		/// Void ValidateNewNode(System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_RValidateNewNode_LinkedListNode_d_T_p_;
		public virtual RMethod RValidateNewNode_LinkedListNode_d_T_p_
		{
			get
			{
				if(r_RValidateNewNode_LinkedListNode_d_T_p_ == null)
				{
					r_RValidateNewNode_LinkedListNode_d_T_p_ = new(this, "ValidateNewNode", 0, typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RValidateNewNode_LinkedListNode_d_T_p_.SetBelong(this.instance);
				}
				return r_RValidateNewNode_LinkedListNode_d_T_p_;
			}
		}

		/// <summary>
		/// Void ValidateNode(System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_RValidateNode_LinkedListNode_d_T_p_;
		public virtual RMethod RValidateNode_LinkedListNode_d_T_p_
		{
			get
			{
				if(r_RValidateNode_LinkedListNode_d_T_p_ == null)
				{
					r_RValidateNode_LinkedListNode_d_T_p_ = new(this, "ValidateNode", 0, typeof(System.Collections.Generic.LinkedListNode<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RValidateNode_LinkedListNode_d_T_p_.SetBelong(this.instance);
				}
				return r_RValidateNode_LinkedListNode_d_T_p_;
			}
		}

		/// <summary>
		/// Void System.Collections.ICollection.CopyTo(System.Array, Int32)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__ICollection__0__CopyTo_Array_Int32;
		public virtual RMethod RSystem__0__Collections__0__ICollection__0__CopyTo_Array_Int32
		{
			get
			{
				if(r_RSystem__0__Collections__0__ICollection__0__CopyTo_Array_Int32 == null)
				{
					r_RSystem__0__Collections__0__ICollection__0__CopyTo_Array_Int32 = new(this, "System.Collections.ICollection.CopyTo", 0, typeof(System.Array), typeof(System.Int32));
					r_RSystem__0__Collections__0__ICollection__0__CopyTo_Array_Int32.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__ICollection__0__CopyTo_Array_Int32;
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

        public virtual void System__0__Collections__0__Generic__0__ICollection__1__T__2____0__Add(T  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Add_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.LinkedListNode<T> AddAfter(System.Collections.Generic.LinkedListNode<T>  @node, T  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @value};
            var ___result = RAddAfter_LinkedListNode_d_T_p__T.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.LinkedListNode<T>)___result;
        }


        public virtual void AddAfter(System.Collections.Generic.LinkedListNode<T>  @node, System.Collections.Generic.LinkedListNode<T>  @newNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @newNode};
            var ___result = RAddAfter_LinkedListNode_d_T_p__LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.LinkedListNode<T> AddBefore(System.Collections.Generic.LinkedListNode<T>  @node, T  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @value};
            var ___result = RAddBefore_LinkedListNode_d_T_p__T.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.LinkedListNode<T>)___result;
        }


        public virtual void AddBefore(System.Collections.Generic.LinkedListNode<T>  @node, System.Collections.Generic.LinkedListNode<T>  @newNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @newNode};
            var ___result = RAddBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.LinkedListNode<T> AddFirst(T  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAddFirst_T.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.LinkedListNode<T>)___result;
        }


        public virtual void AddFirst(System.Collections.Generic.LinkedListNode<T>  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RAddFirst_LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.LinkedListNode<T> AddLast(T  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAddLast_T.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.LinkedListNode<T>)___result;
        }


        public virtual void AddLast(System.Collections.Generic.LinkedListNode<T>  @node)
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


        public virtual System.Boolean Contains(T  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RContains_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CopyTo(T[]  @array, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RCopyTo_TArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.LinkedListNode<T> Find(T  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RFind_T.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.LinkedListNode<T>)___result;
        }


        public virtual System.Collections.Generic.LinkedListNode<T> FindLast(T  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RFindLast_T.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.LinkedListNode<T>)___result;
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


        public virtual System.Boolean Remove(T  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RRemove_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Remove(System.Collections.Generic.LinkedListNode<T>  @node)
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


        public virtual void InternalInsertNodeBefore(System.Collections.Generic.LinkedListNode<T>  @node, System.Collections.Generic.LinkedListNode<T>  @newNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @newNode};
            var ___result = RInternalInsertNodeBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalInsertNodeToEmptyList(System.Collections.Generic.LinkedListNode<T>  @newNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newNode};
            var ___result = RInternalInsertNodeToEmptyList_LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalRemoveNode(System.Collections.Generic.LinkedListNode<T>  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RInternalRemoveNode_LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ValidateNewNode(System.Collections.Generic.LinkedListNode<T>  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RValidateNewNode_LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ValidateNode(System.Collections.Generic.LinkedListNode<T>  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RValidateNode_LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Collections__0__ICollection__0__CopyTo(System.Array  @array, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RSystem__0__Collections__0__ICollection__0__CopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator System__0__Collections__0__IEnumerable__0__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__0__Collections__0__IEnumerable__0__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
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
