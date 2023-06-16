
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Collections.Generic.LinkedList`1
	/// </summary>
    public partial class RLinkedList<T> : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Collections.Generic.LinkedList`1").MakeGenericType(ReflectionUtils.GetType(typeof(T)));
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


		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] head
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLinkedListNode<Hvak.Editor.Refleaction.RField> r_Fhead;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLinkedListNode<Hvak.Editor.Refleaction.RField> RFhead
		{
			get
			{
				if(r_Fhead == null)
				{
					r_Fhead = new(this, "head");
				}
				return r_Fhead;
			}
		}

		/// <summary>
		/// System.Int32 count
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fcount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcount
		{
			get
			{
				if(r_Fcount == null)
				{
					r_Fcount = new(this, "count");
				}
				return r_Fcount;
			}
		}

		/// <summary>
		/// System.Int32 version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fversion;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFversion
		{
			get
			{
				if(r_Fversion == null)
				{
					r_Fversion = new(this, "version");
				}
				return r_Fversion;
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
				}
				return r_F_siInfo;
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
					r_FVersionName = new(Type, "VersionName");
				}
				return r_FVersionName;
			}
		}

		/// <summary>
		/// System.String CountName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FCountName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFCountName
		{
			get
			{
				if(r_FCountName == null)
				{
					r_FCountName = new(Type, "CountName");
				}
				return r_FCountName;
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
					r_FValuesName = new(Type, "ValuesName");
				}
				return r_FValuesName;
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
		/// System.Collections.Generic.LinkedListNode`1[T] First
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLinkedListNode<Hvak.Editor.Refleaction.RProperty> r_PFirst;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLinkedListNode<Hvak.Editor.Refleaction.RProperty> RPFirst
		{
			get
			{
				if(r_PFirst == null)
				{
					r_PFirst = new(this, "First", -1);
				}
				return r_PFirst;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] Last
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLinkedListNode<Hvak.Editor.Refleaction.RProperty> r_PLast;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLinkedListNode<Hvak.Editor.Refleaction.RProperty> RPLast
		{
			get
			{
				if(r_PLast == null)
				{
					r_PLast = new(this, "Last", -1);
				}
				return r_PLast;
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
				}
				return r_MSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Add_T;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] AddAfter(System.Collections.Generic.LinkedListNode`1[T], T)
		/// </summary>
		protected RMethod r_MAddAfter_LinkedListNode_d_T_p__T;
		public virtual RMethod RMAddAfter_LinkedListNode_d_T_p__T
		{
			get
			{
				if(r_MAddAfter_LinkedListNode_d_T_p__T == null)
				{
					r_MAddAfter_LinkedListNode_d_T_p__T = new(this, "AddAfter", 0,  ReflectionUtils.GetType("System.Collections.Generic.LinkedListNode`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0));
				}
				return r_MAddAfter_LinkedListNode_d_T_p__T;
			}
		}

		/// <summary>
		/// Void AddAfter(System.Collections.Generic.LinkedListNode`1[T], System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_MAddAfter_LinkedListNode_d_T_p__LinkedListNode_d_T_p_;
		public virtual RMethod RMAddAfter_LinkedListNode_d_T_p__LinkedListNode_d_T_p_
		{
			get
			{
				if(r_MAddAfter_LinkedListNode_d_T_p__LinkedListNode_d_T_p_ == null)
				{
					r_MAddAfter_LinkedListNode_d_T_p__LinkedListNode_d_T_p_ = new(this, "AddAfter", 0,  ReflectionUtils.GetType("System.Collections.Generic.LinkedListNode`1").MakeGenericType(Type.MakeGenericMethodParameter(0)),  ReflectionUtils.GetType("System.Collections.Generic.LinkedListNode`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MAddAfter_LinkedListNode_d_T_p__LinkedListNode_d_T_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] AddBefore(System.Collections.Generic.LinkedListNode`1[T], T)
		/// </summary>
		protected RMethod r_MAddBefore_LinkedListNode_d_T_p__T;
		public virtual RMethod RMAddBefore_LinkedListNode_d_T_p__T
		{
			get
			{
				if(r_MAddBefore_LinkedListNode_d_T_p__T == null)
				{
					r_MAddBefore_LinkedListNode_d_T_p__T = new(this, "AddBefore", 0,  ReflectionUtils.GetType("System.Collections.Generic.LinkedListNode`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0));
				}
				return r_MAddBefore_LinkedListNode_d_T_p__T;
			}
		}

		/// <summary>
		/// Void AddBefore(System.Collections.Generic.LinkedListNode`1[T], System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_MAddBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_;
		public virtual RMethod RMAddBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_
		{
			get
			{
				if(r_MAddBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_ == null)
				{
					r_MAddBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_ = new(this, "AddBefore", 0,  ReflectionUtils.GetType("System.Collections.Generic.LinkedListNode`1").MakeGenericType(Type.MakeGenericMethodParameter(0)),  ReflectionUtils.GetType("System.Collections.Generic.LinkedListNode`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MAddBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] AddFirst(T)
		/// </summary>
		protected RMethod r_MAddFirst_T;
		public virtual RMethod RMAddFirst_T
		{
			get
			{
				if(r_MAddFirst_T == null)
				{
					r_MAddFirst_T = new(this, "AddFirst", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MAddFirst_T;
			}
		}

		/// <summary>
		/// Void AddFirst(System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_MAddFirst_LinkedListNode_d_T_p_;
		public virtual RMethod RMAddFirst_LinkedListNode_d_T_p_
		{
			get
			{
				if(r_MAddFirst_LinkedListNode_d_T_p_ == null)
				{
					r_MAddFirst_LinkedListNode_d_T_p_ = new(this, "AddFirst", 0,  ReflectionUtils.GetType("System.Collections.Generic.LinkedListNode`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MAddFirst_LinkedListNode_d_T_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] AddLast(T)
		/// </summary>
		protected RMethod r_MAddLast_T;
		public virtual RMethod RMAddLast_T
		{
			get
			{
				if(r_MAddLast_T == null)
				{
					r_MAddLast_T = new(this, "AddLast", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MAddLast_T;
			}
		}

		/// <summary>
		/// Void AddLast(System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_MAddLast_LinkedListNode_d_T_p_;
		public virtual RMethod RMAddLast_LinkedListNode_d_T_p_
		{
			get
			{
				if(r_MAddLast_LinkedListNode_d_T_p_ == null)
				{
					r_MAddLast_LinkedListNode_d_T_p_ = new(this, "AddLast", 0,  ReflectionUtils.GetType("System.Collections.Generic.LinkedListNode`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MAddLast_LinkedListNode_d_T_p_;
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
		/// System.Collections.Generic.LinkedListNode`1[T] Find(T)
		/// </summary>
		protected RMethod r_MFind_T;
		public virtual RMethod RMFind_T
		{
			get
			{
				if(r_MFind_T == null)
				{
					r_MFind_T = new(this, "Find", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MFind_T;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] FindLast(T)
		/// </summary>
		protected RMethod r_MFindLast_T;
		public virtual RMethod RMFindLast_T
		{
			get
			{
				if(r_MFindLast_T == null)
				{
					r_MFindLast_T = new(this, "FindLast", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MFindLast_T;
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
		/// Void Remove(System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_MRemove_LinkedListNode_d_T_p_;
		public virtual RMethod RMRemove_LinkedListNode_d_T_p_
		{
			get
			{
				if(r_MRemove_LinkedListNode_d_T_p_ == null)
				{
					r_MRemove_LinkedListNode_d_T_p_ = new(this, "Remove", 0,  ReflectionUtils.GetType("System.Collections.Generic.LinkedListNode`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MRemove_LinkedListNode_d_T_p_;
			}
		}

		/// <summary>
		/// Void RemoveFirst()
		/// </summary>
		protected RMethod r_MRemoveFirst;
		public virtual RMethod RMRemoveFirst
		{
			get
			{
				if(r_MRemoveFirst == null)
				{
					r_MRemoveFirst = new(this, "RemoveFirst", 0);
				}
				return r_MRemoveFirst;
			}
		}

		/// <summary>
		/// Void RemoveLast()
		/// </summary>
		protected RMethod r_MRemoveLast;
		public virtual RMethod RMRemoveLast
		{
			get
			{
				if(r_MRemoveLast == null)
				{
					r_MRemoveLast = new(this, "RemoveLast", 0);
				}
				return r_MRemoveLast;
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
		/// Void InternalInsertNodeBefore(System.Collections.Generic.LinkedListNode`1[T], System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_MInternalInsertNodeBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_;
		public virtual RMethod RMInternalInsertNodeBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_
		{
			get
			{
				if(r_MInternalInsertNodeBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_ == null)
				{
					r_MInternalInsertNodeBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_ = new(this, "InternalInsertNodeBefore", 0,  ReflectionUtils.GetType("System.Collections.Generic.LinkedListNode`1").MakeGenericType(Type.MakeGenericMethodParameter(0)),  ReflectionUtils.GetType("System.Collections.Generic.LinkedListNode`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MInternalInsertNodeBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_;
			}
		}

		/// <summary>
		/// Void InternalInsertNodeToEmptyList(System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_MInternalInsertNodeToEmptyList_LinkedListNode_d_T_p_;
		public virtual RMethod RMInternalInsertNodeToEmptyList_LinkedListNode_d_T_p_
		{
			get
			{
				if(r_MInternalInsertNodeToEmptyList_LinkedListNode_d_T_p_ == null)
				{
					r_MInternalInsertNodeToEmptyList_LinkedListNode_d_T_p_ = new(this, "InternalInsertNodeToEmptyList", 0,  ReflectionUtils.GetType("System.Collections.Generic.LinkedListNode`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MInternalInsertNodeToEmptyList_LinkedListNode_d_T_p_;
			}
		}

		/// <summary>
		/// Void InternalRemoveNode(System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_MInternalRemoveNode_LinkedListNode_d_T_p_;
		public virtual RMethod RMInternalRemoveNode_LinkedListNode_d_T_p_
		{
			get
			{
				if(r_MInternalRemoveNode_LinkedListNode_d_T_p_ == null)
				{
					r_MInternalRemoveNode_LinkedListNode_d_T_p_ = new(this, "InternalRemoveNode", 0,  ReflectionUtils.GetType("System.Collections.Generic.LinkedListNode`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MInternalRemoveNode_LinkedListNode_d_T_p_;
			}
		}

		/// <summary>
		/// Void ValidateNewNode(System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_MValidateNewNode_LinkedListNode_d_T_p_;
		public virtual RMethod RMValidateNewNode_LinkedListNode_d_T_p_
		{
			get
			{
				if(r_MValidateNewNode_LinkedListNode_d_T_p_ == null)
				{
					r_MValidateNewNode_LinkedListNode_d_T_p_ = new(this, "ValidateNewNode", 0,  ReflectionUtils.GetType("System.Collections.Generic.LinkedListNode`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MValidateNewNode_LinkedListNode_d_T_p_;
			}
		}

		/// <summary>
		/// Void ValidateNode(System.Collections.Generic.LinkedListNode`1[T])
		/// </summary>
		protected RMethod r_MValidateNode_LinkedListNode_d_T_p_;
		public virtual RMethod RMValidateNode_LinkedListNode_d_T_p_
		{
			get
			{
				if(r_MValidateNode_LinkedListNode_d_T_p_ == null)
				{
					r_MValidateNode_LinkedListNode_d_T_p_ = new(this, "ValidateNode", 0,  ReflectionUtils.GetType("System.Collections.Generic.LinkedListNode`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MValidateNode_LinkedListNode_d_T_p_;
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


        public virtual void System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Add(T @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Add_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.LinkedListNode<T> AddAfter(System.Collections.Generic.LinkedListNode<T> @node, T @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @value};
            var ___result = RMAddAfter_LinkedListNode_d_T_p__T.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.LinkedListNode<T>>(___result);
        }


        public virtual void AddAfter(System.Collections.Generic.LinkedListNode<T> @node, System.Collections.Generic.LinkedListNode<T> @newNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @newNode};
            var ___result = RMAddAfter_LinkedListNode_d_T_p__LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.LinkedListNode<T> AddBefore(System.Collections.Generic.LinkedListNode<T> @node, T @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @value};
            var ___result = RMAddBefore_LinkedListNode_d_T_p__T.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.LinkedListNode<T>>(___result);
        }


        public virtual void AddBefore(System.Collections.Generic.LinkedListNode<T> @node, System.Collections.Generic.LinkedListNode<T> @newNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @newNode};
            var ___result = RMAddBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.LinkedListNode<T> AddFirst(T @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAddFirst_T.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.LinkedListNode<T>>(___result);
        }


        public virtual void AddFirst(System.Collections.Generic.LinkedListNode<T> @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RMAddFirst_LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.LinkedListNode<T> AddLast(T @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAddLast_T.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.LinkedListNode<T>>(___result);
        }


        public virtual void AddLast(System.Collections.Generic.LinkedListNode<T> @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RMAddLast_LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Contains(T @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMContains_T.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void CopyTo(T[] @array, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RMCopyTo_TArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.LinkedListNode<T> Find(T @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMFind_T.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.LinkedListNode<T>>(___result);
        }


        public virtual System.Collections.Generic.LinkedListNode<T> FindLast(T @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMFindLast_T.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.LinkedListNode<T>>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLinkedList<Hvak.Editor.Refleaction.RType>.REnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLinkedList<Hvak.Editor.Refleaction.RType>.REnumerator>(___result);
        }


        public virtual System.Collections.Generic.IEnumerator<T> System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.IEnumerator<T>>(___result);
        }


        public virtual System.Boolean Remove(T @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMRemove_T.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Remove(System.Collections.Generic.LinkedListNode<T> @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RMRemove_LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFirst()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRemoveFirst.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveLast()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRemoveLast.Invoke(___genericsType, ___parameters);

            
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


        public virtual void InternalInsertNodeBefore(System.Collections.Generic.LinkedListNode<T> @node, System.Collections.Generic.LinkedListNode<T> @newNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @newNode};
            var ___result = RMInternalInsertNodeBefore_LinkedListNode_d_T_p__LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalInsertNodeToEmptyList(System.Collections.Generic.LinkedListNode<T> @newNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newNode};
            var ___result = RMInternalInsertNodeToEmptyList_LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalRemoveNode(System.Collections.Generic.LinkedListNode<T> @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RMInternalRemoveNode_LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ValidateNewNode(System.Collections.Generic.LinkedListNode<T> @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RMValidateNewNode_LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ValidateNode(System.Collections.Generic.LinkedListNode<T> @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RMValidateNode_LinkedListNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
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

            return ReflectionUtils.Convert<System.Collections.IEnumerator>(___result);
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
