using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections.RObjectModel
{
	/// <summary>
	/// System.Collections.ObjectModel.ReadOnlyCollection`1
	/// </summary>
    public partial class RReadOnlyCollection<T> : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.IList`1[T] list
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIList<RField> r_list;
		public virtual RSystem.RCollections.RGeneric.RIList<RField> Rlist
		{
			get
			{
				if(r_list == null)
				{
					r_list = new(this, "list");
					r_list.SetBelong(this.instance);
				}
				return r_list;
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
		/// System.Collections.Generic.IList`1[T] Items
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIList<RProperty> r_Items;
		public virtual RSystem.RCollections.RGeneric.RIList<RProperty> RItems
		{
			get
			{
				if(r_Items == null)
				{
					r_Items = new(this, "Items", -1);
					r_Items.SetBelong(this.instance);
				}
				return r_Items;
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
		/// T System.Collections.Generic.IList<T>.Item [Int32]
		/// </summary>
		protected RProperty r_RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__get_Item_Int32;
		public virtual RProperty RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__get_Item_Int32
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__get_Item_Int32 == null)
				{
					r_RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__get_Item_Int32 = new(this, "System.Collections.Generic.IList<T>.Item", -1, typeof(System.Int32));
					r_RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__get_Item_Int32.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__get_Item_Int32;
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
		/// Boolean System.Collections.IList.IsFixedSize
		/// </summary>
		protected RProperty r_RSystem__0__Collections__0__IList__0__get_IsFixedSize;
		public virtual RProperty RSystem__0__Collections__0__IList__0__get_IsFixedSize
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__get_IsFixedSize == null)
				{
					r_RSystem__0__Collections__0__IList__0__get_IsFixedSize = new(this, "System.Collections.IList.IsFixedSize", -1);
					r_RSystem__0__Collections__0__IList__0__get_IsFixedSize.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__get_IsFixedSize;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IList.IsReadOnly
		/// </summary>
		protected RProperty r_RSystem__0__Collections__0__IList__0__get_IsReadOnly;
		public virtual RProperty RSystem__0__Collections__0__IList__0__get_IsReadOnly
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__get_IsReadOnly == null)
				{
					r_RSystem__0__Collections__0__IList__0__get_IsReadOnly = new(this, "System.Collections.IList.IsReadOnly", -1);
					r_RSystem__0__Collections__0__IList__0__get_IsReadOnly.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__get_IsReadOnly;
			}
		}

		/// <summary>
		/// System.Object System.Collections.IList.Item [Int32]
		/// </summary>
		protected RSystem.RObject r_RSystem__0__Collections__0__IList__0__get_Item_Int32;
		public virtual RSystem.RObject RSystem__0__Collections__0__IList__0__get_Item_Int32
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__get_Item_Int32 == null)
				{
					r_RSystem__0__Collections__0__IList__0__get_Item_Int32 = new(this, "System.Collections.IList.Item", -1, typeof(System.Int32));
					r_RSystem__0__Collections__0__IList__0__get_Item_Int32.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__get_Item_Int32;
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
		/// System.Collections.Generic.IEnumerator`1[T] GetEnumerator()
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
		/// Int32 IndexOf(T)
		/// </summary>
		protected RMethod r_RIndexOf_T;
		public virtual RMethod RIndexOf_T
		{
			get
			{
				if(r_RIndexOf_T == null)
				{
					r_RIndexOf_T = new(this, "IndexOf", 0, Type.MakeGenericMethodParameter(0));
					r_RIndexOf_T.SetBelong(this.instance);
				}
				return r_RIndexOf_T;
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
		/// Void System.Collections.Generic.ICollection<T>.Clear()
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Clear;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Clear
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Clear == null)
				{
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Clear = new(this, "System.Collections.Generic.ICollection<T>.Clear", 0);
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Clear.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Clear;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.IList<T>.Insert(Int32, T)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__Insert_Int32_T;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__Insert_Int32_T
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__Insert_Int32_T == null)
				{
					r_RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__Insert_Int32_T = new(this, "System.Collections.Generic.IList<T>.Insert", 0, typeof(System.Int32), Type.MakeGenericMethodParameter(0));
					r_RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__Insert_Int32_T.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__Insert_Int32_T;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<T>.Remove(T)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Remove_T;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Remove_T
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Remove_T == null)
				{
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Remove_T = new(this, "System.Collections.Generic.ICollection<T>.Remove", 0, Type.MakeGenericMethodParameter(0));
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Remove_T.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Remove_T;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.IList<T>.RemoveAt(Int32)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__RemoveAt_Int32;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__RemoveAt_Int32
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__RemoveAt_Int32 == null)
				{
					r_RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__RemoveAt_Int32 = new(this, "System.Collections.Generic.IList<T>.RemoveAt", 0, typeof(System.Int32));
					r_RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__RemoveAt_Int32.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__RemoveAt_Int32;
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
		/// Int32 System.Collections.IList.Add(System.Object)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__IList__0__Add_Object;
		public virtual RMethod RSystem__0__Collections__0__IList__0__Add_Object
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__Add_Object == null)
				{
					r_RSystem__0__Collections__0__IList__0__Add_Object = new(this, "System.Collections.IList.Add", 0, typeof(System.Object));
					r_RSystem__0__Collections__0__IList__0__Add_Object.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__Add_Object;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.Clear()
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__IList__0__Clear;
		public virtual RMethod RSystem__0__Collections__0__IList__0__Clear
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__Clear == null)
				{
					r_RSystem__0__Collections__0__IList__0__Clear = new(this, "System.Collections.IList.Clear", 0);
					r_RSystem__0__Collections__0__IList__0__Clear.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__Clear;
			}
		}

		/// <summary>
		/// Boolean IsCompatibleObject(System.Object)
		/// </summary>
		protected static RMethod r_RIsCompatibleObject_Object;
		public static RMethod RIsCompatibleObject_Object
		{
			get
			{
				if(r_RIsCompatibleObject_Object == null)
				{
					r_RIsCompatibleObject_Object = new(typeof(System.Collections.ObjectModel.ReadOnlyCollection<>), "IsCompatibleObject", 0, typeof(System.Object));
					r_RIsCompatibleObject_Object.SetBelong(null);
				}
				return r_RIsCompatibleObject_Object;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IList.Contains(System.Object)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__IList__0__Contains_Object;
		public virtual RMethod RSystem__0__Collections__0__IList__0__Contains_Object
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__Contains_Object == null)
				{
					r_RSystem__0__Collections__0__IList__0__Contains_Object = new(this, "System.Collections.IList.Contains", 0, typeof(System.Object));
					r_RSystem__0__Collections__0__IList__0__Contains_Object.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__Contains_Object;
			}
		}

		/// <summary>
		/// Int32 System.Collections.IList.IndexOf(System.Object)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__IList__0__IndexOf_Object;
		public virtual RMethod RSystem__0__Collections__0__IList__0__IndexOf_Object
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__IndexOf_Object == null)
				{
					r_RSystem__0__Collections__0__IList__0__IndexOf_Object = new(this, "System.Collections.IList.IndexOf", 0, typeof(System.Object));
					r_RSystem__0__Collections__0__IList__0__IndexOf_Object.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__IndexOf_Object;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.Insert(Int32, System.Object)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__IList__0__Insert_Int32_Object;
		public virtual RMethod RSystem__0__Collections__0__IList__0__Insert_Int32_Object
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__Insert_Int32_Object == null)
				{
					r_RSystem__0__Collections__0__IList__0__Insert_Int32_Object = new(this, "System.Collections.IList.Insert", 0, typeof(System.Int32), typeof(System.Object));
					r_RSystem__0__Collections__0__IList__0__Insert_Int32_Object.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__Insert_Int32_Object;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.Remove(System.Object)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__IList__0__Remove_Object;
		public virtual RMethod RSystem__0__Collections__0__IList__0__Remove_Object
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__Remove_Object == null)
				{
					r_RSystem__0__Collections__0__IList__0__Remove_Object = new(this, "System.Collections.IList.Remove", 0, typeof(System.Object));
					r_RSystem__0__Collections__0__IList__0__Remove_Object.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__Remove_Object;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.RemoveAt(Int32)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__IList__0__RemoveAt_Int32;
		public virtual RMethod RSystem__0__Collections__0__IList__0__RemoveAt_Int32
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__RemoveAt_Int32 == null)
				{
					r_RSystem__0__Collections__0__IList__0__RemoveAt_Int32 = new(this, "System.Collections.IList.RemoveAt", 0, typeof(System.Int32));
					r_RSystem__0__Collections__0__IList__0__RemoveAt_Int32.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__RemoveAt_Int32;
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


        public RReadOnlyCollection() : base("System.Collections.ObjectModel.ReadOnlyCollection`1")
        {
        }

        public RReadOnlyCollection(System.Object instance) : base("System.Collections.ObjectModel.ReadOnlyCollection`1")
		{
            SetInstance(instance);
		}

        public RReadOnlyCollection(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RReadOnlyCollection(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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


        public virtual System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerator<T>)___result;
        }


        public virtual System.Int32 IndexOf(T  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RIndexOf_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void System__0__Collections__0__Generic__0__ICollection__1__T__2____0__Add(T  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Add_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Collections__0__Generic__0__ICollection__1__T__2____0__Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Clear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Collections__0__Generic__0__IList__1__T__2____0__Insert(System.Int32  @index, T  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__Insert_Int32_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean System__0__Collections__0__Generic__0__ICollection__1__T__2____0__Remove(T  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Remove_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void System__0__Collections__0__Generic__0__IList__1__T__2____0__RemoveAt(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__RemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator System__0__Collections__0__IEnumerable__0__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__0__Collections__0__IEnumerable__0__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void System__0__Collections__0__ICollection__0__CopyTo(System.Array  @array, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RSystem__0__Collections__0__ICollection__0__CopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 System__0__Collections__0__IList__0__Add(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSystem__0__Collections__0__IList__0__Add_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void System__0__Collections__0__IList__0__Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__0__Collections__0__IList__0__Clear.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsCompatibleObject(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RIsCompatibleObject_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean System__0__Collections__0__IList__0__Contains(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSystem__0__Collections__0__IList__0__Contains_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 System__0__Collections__0__IList__0__IndexOf(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSystem__0__Collections__0__IList__0__IndexOf_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void System__0__Collections__0__IList__0__Insert(System.Int32  @index, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RSystem__0__Collections__0__IList__0__Insert_Int32_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Collections__0__IList__0__Remove(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSystem__0__Collections__0__IList__0__Remove_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Collections__0__IList__0__RemoveAt(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RSystem__0__Collections__0__IList__0__RemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
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
