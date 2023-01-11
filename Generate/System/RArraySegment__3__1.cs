using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.ArraySegment`1
	/// </summary>
    public partial class RArraySegment<T> : RMember //
    {

		/// <summary>
		/// System.ArraySegment`1[T] <Empty>k__BackingField
		/// </summary>
		protected static RSystem.RArraySegment<RField> r___0__Empty__1__k__BackingField;
		public static RSystem.RArraySegment<RField> R__0__Empty__1__k__BackingField
		{
			get
			{
				if(r___0__Empty__1__k__BackingField == null)
				{
					r___0__Empty__1__k__BackingField = new(typeof(System.ArraySegment<>), "<Empty>k__BackingField");
					r___0__Empty__1__k__BackingField.SetBelong(null);
				}
				return r___0__Empty__1__k__BackingField;
			}
		}

		/// <summary>
		/// T[] _array
		/// </summary>
		protected RFieldArray<RField> r__array;
		public virtual RFieldArray<RField> R_array
		{
			get
			{
				if(r__array == null)
				{
					r__array = new(this, "_array");
					r__array.SetBelong(this.instance);
				}
				return r__array;
			}
		}

		/// <summary>
		/// System.Int32 _offset
		/// </summary>
		protected RSystem.RInt32 r__offset;
		public virtual RSystem.RInt32 R_offset
		{
			get
			{
				if(r__offset == null)
				{
					r__offset = new(this, "_offset");
					r__offset.SetBelong(this.instance);
				}
				return r__offset;
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
		/// System.ArraySegment`1[T] Empty
		/// </summary>
		protected static RSystem.RArraySegment<RProperty> r_Empty;
		public static RSystem.RArraySegment<RProperty> REmpty
		{
			get
			{
				if(r_Empty == null)
				{
					r_Empty = new(typeof(System.ArraySegment<>), "Empty", -1);
					r_Empty.SetBelong(null);
				}
				return r_Empty;
			}
		}

		/// <summary>
		/// T[] Array
		/// </summary>
		protected RPropertyArray<RProperty> r_Array;
		public virtual RPropertyArray<RProperty> RArray
		{
			get
			{
				if(r_Array == null)
				{
					r_Array = new(this, "Array", -1);
					r_Array.SetBelong(this.instance);
				}
				return r_Array;
			}
		}

		/// <summary>
		/// Int32 Offset
		/// </summary>
		protected RSystem.RInt32 r_Offset;
		public virtual RSystem.RInt32 ROffset
		{
			get
			{
				if(r_Offset == null)
				{
					r_Offset = new(this, "Offset", -1);
					r_Offset.SetBelong(this.instance);
				}
				return r_Offset;
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
		/// T System.Collections.Generic.IList<T>.Item [Int32]
		/// </summary>
		protected RProperty r_System__2__Collections__2__Generic__2__IList__0__T__1____2__Item_Int32;
		public virtual RProperty RSystem__2__Collections__2__Generic__2__IList__0__T__1____2__Item_Int32
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__IList__0__T__1____2__Item_Int32 == null)
				{
					r_System__2__Collections__2__Generic__2__IList__0__T__1____2__Item_Int32 = new(this, "System.Collections.Generic.IList<T>.Item", -1, typeof(System.Int32));
					r_System__2__Collections__2__Generic__2__IList__0__T__1____2__Item_Int32.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__IList__0__T__1____2__Item_Int32;
			}
		}

		/// <summary>
		/// T System.Collections.Generic.IReadOnlyList<T>.Item [Int32]
		/// </summary>
		protected RProperty r_System__2__Collections__2__Generic__2__IReadOnlyList__0__T__1____2__Item_Int32;
		public virtual RProperty RSystem__2__Collections__2__Generic__2__IReadOnlyList__0__T__1____2__Item_Int32
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__IReadOnlyList__0__T__1____2__Item_Int32 == null)
				{
					r_System__2__Collections__2__Generic__2__IReadOnlyList__0__T__1____2__Item_Int32 = new(this, "System.Collections.Generic.IReadOnlyList<T>.Item", -1, typeof(System.Int32));
					r_System__2__Collections__2__Generic__2__IReadOnlyList__0__T__1____2__Item_Int32.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__IReadOnlyList__0__T__1____2__Item_Int32;
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
		/// Void CopyTo(System.ArraySegment`1[T])
		/// </summary>
		protected RMethod r_CopyTo_ArraySegment_d_T_p_;
		public virtual RMethod RCopyTo_ArraySegment_d_T_p_
		{
			get
			{
				if(r_CopyTo_ArraySegment_d_T_p_ == null)
				{
					r_CopyTo_ArraySegment_d_T_p_ = new(this, "CopyTo", 0, typeof(System.ArraySegment<>));
					r_CopyTo_ArraySegment_d_T_p_.SetBelong(this.instance);
				}
				return r_CopyTo_ArraySegment_d_T_p_;
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
		/// Boolean Equals(System.ArraySegment`1[T])
		/// </summary>
		protected RMethod r_Equals_ArraySegment_d_T_p_;
		public virtual RMethod REquals_ArraySegment_d_T_p_
		{
			get
			{
				if(r_Equals_ArraySegment_d_T_p_ == null)
				{
					r_Equals_ArraySegment_d_T_p_ = new(this, "Equals", 0, typeof(System.ArraySegment<>));
					r_Equals_ArraySegment_d_T_p_.SetBelong(this.instance);
				}
				return r_Equals_ArraySegment_d_T_p_;
			}
		}

		/// <summary>
		/// System.ArraySegment`1[T] Slice(Int32)
		/// </summary>
		protected RMethod r_Slice_Int32;
		public virtual RMethod RSlice_Int32
		{
			get
			{
				if(r_Slice_Int32 == null)
				{
					r_Slice_Int32 = new(this, "Slice", 0, typeof(System.Int32));
					r_Slice_Int32.SetBelong(this.instance);
				}
				return r_Slice_Int32;
			}
		}

		/// <summary>
		/// System.ArraySegment`1[T] Slice(Int32, Int32)
		/// </summary>
		protected RMethod r_Slice_Int32_Int32;
		public virtual RMethod RSlice_Int32_Int32
		{
			get
			{
				if(r_Slice_Int32_Int32 == null)
				{
					r_Slice_Int32_Int32 = new(this, "Slice", 0, typeof(System.Int32), typeof(System.Int32));
					r_Slice_Int32_Int32.SetBelong(this.instance);
				}
				return r_Slice_Int32_Int32;
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
		/// Boolean op_Equality(System.ArraySegment`1[T], System.ArraySegment`1[T])
		/// </summary>
		protected static RMethod r_op_Equality_ArraySegment_d_T_p__ArraySegment_d_T_p_;
		public static RMethod Rop_Equality_ArraySegment_d_T_p__ArraySegment_d_T_p_
		{
			get
			{
				if(r_op_Equality_ArraySegment_d_T_p__ArraySegment_d_T_p_ == null)
				{
					r_op_Equality_ArraySegment_d_T_p__ArraySegment_d_T_p_ = new(typeof(System.ArraySegment<>), "op_Equality", 0, typeof(System.ArraySegment<>), typeof(System.ArraySegment<>));
					r_op_Equality_ArraySegment_d_T_p__ArraySegment_d_T_p_.SetBelong(null);
				}
				return r_op_Equality_ArraySegment_d_T_p__ArraySegment_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.ArraySegment`1[T], System.ArraySegment`1[T])
		/// </summary>
		protected static RMethod r_op_Inequality_ArraySegment_d_T_p__ArraySegment_d_T_p_;
		public static RMethod Rop_Inequality_ArraySegment_d_T_p__ArraySegment_d_T_p_
		{
			get
			{
				if(r_op_Inequality_ArraySegment_d_T_p__ArraySegment_d_T_p_ == null)
				{
					r_op_Inequality_ArraySegment_d_T_p__ArraySegment_d_T_p_ = new(typeof(System.ArraySegment<>), "op_Inequality", 0, typeof(System.ArraySegment<>), typeof(System.ArraySegment<>));
					r_op_Inequality_ArraySegment_d_T_p__ArraySegment_d_T_p_.SetBelong(null);
				}
				return r_op_Inequality_ArraySegment_d_T_p__ArraySegment_d_T_p_;
			}
		}

		/// <summary>
		/// System.ArraySegment`1[T] op_Implicit(T[])
		/// </summary>
		protected static RMethod r_op_Implicit_TArray;
		public static RMethod Rop_Implicit_TArray
		{
			get
			{
				if(r_op_Implicit_TArray == null)
				{
					r_op_Implicit_TArray = new(typeof(System.ArraySegment<>), "op_Implicit", 0, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_op_Implicit_TArray.SetBelong(null);
				}
				return r_op_Implicit_TArray;
			}
		}

		/// <summary>
		/// Int32 System.Collections.Generic.IList<T>.IndexOf(T)
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__IList__0__T__1____2__IndexOf_T;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__IList__0__T__1____2__IndexOf_T
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__IList__0__T__1____2__IndexOf_T == null)
				{
					r_System__2__Collections__2__Generic__2__IList__0__T__1____2__IndexOf_T = new(this, "System.Collections.Generic.IList<T>.IndexOf", 0, Type.MakeGenericMethodParameter(0));
					r_System__2__Collections__2__Generic__2__IList__0__T__1____2__IndexOf_T.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__IList__0__T__1____2__IndexOf_T;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.IList<T>.Insert(Int32, T)
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__IList__0__T__1____2__Insert_Int32_T;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__IList__0__T__1____2__Insert_Int32_T
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__IList__0__T__1____2__Insert_Int32_T == null)
				{
					r_System__2__Collections__2__Generic__2__IList__0__T__1____2__Insert_Int32_T = new(this, "System.Collections.Generic.IList<T>.Insert", 0, typeof(System.Int32), Type.MakeGenericMethodParameter(0));
					r_System__2__Collections__2__Generic__2__IList__0__T__1____2__Insert_Int32_T.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__IList__0__T__1____2__Insert_Int32_T;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.IList<T>.RemoveAt(Int32)
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__IList__0__T__1____2__RemoveAt_Int32;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__IList__0__T__1____2__RemoveAt_Int32
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__IList__0__T__1____2__RemoveAt_Int32 == null)
				{
					r_System__2__Collections__2__Generic__2__IList__0__T__1____2__RemoveAt_Int32 = new(this, "System.Collections.Generic.IList<T>.RemoveAt", 0, typeof(System.Int32));
					r_System__2__Collections__2__Generic__2__IList__0__T__1____2__RemoveAt_Int32.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__IList__0__T__1____2__RemoveAt_Int32;
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
		/// Void System.Collections.Generic.ICollection<T>.Clear()
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Clear;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Clear
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Clear == null)
				{
					r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Clear = new(this, "System.Collections.Generic.ICollection<T>.Clear", 0);
					r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Clear.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Clear;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<T>.Contains(T)
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Contains_T;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Contains_T
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Contains_T == null)
				{
					r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Contains_T = new(this, "System.Collections.Generic.ICollection<T>.Contains", 0, Type.MakeGenericMethodParameter(0));
					r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Contains_T.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Contains_T;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<T>.Remove(T)
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Remove_T;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Remove_T
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Remove_T == null)
				{
					r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Remove_T = new(this, "System.Collections.Generic.ICollection<T>.Remove", 0, Type.MakeGenericMethodParameter(0));
					r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Remove_T.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Remove_T;
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
		/// Void ThrowInvalidOperationIfDefault()
		/// </summary>
		protected RMethod r_ThrowInvalidOperationIfDefault;
		public virtual RMethod RThrowInvalidOperationIfDefault
		{
			get
			{
				if(r_ThrowInvalidOperationIfDefault == null)
				{
					r_ThrowInvalidOperationIfDefault = new(this, "ThrowInvalidOperationIfDefault", 0);
					r_ThrowInvalidOperationIfDefault.SetBelong(this.instance);
				}
				return r_ThrowInvalidOperationIfDefault;
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


        public RArraySegment() : base("System.ArraySegment`1")
        {
        }

        public RArraySegment(System.Object instance) : base("System.ArraySegment`1")
		{
            SetInstance(instance);
		}

        public RArraySegment(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RArraySegment(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual RSystem.RArraySegment<RType>.REnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return new RSystem.RArraySegment<RType>.REnumerator(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void CopyTo(T[] @destination)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination};
            var ___result = RCopyTo_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(T[] @destination, System.Int32 @destinationIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination, @destinationIndex};
            var ___result = RCopyTo_TArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.ArraySegment<T> @destination)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination};
            var ___result = RCopyTo_ArraySegment_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.ArraySegment<T> @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_ArraySegment_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.ArraySegment<T> Slice(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RSlice_Int32.Invoke(___genericsType, ___parameters);

            return (System.ArraySegment<T>)___result;
        }


        public virtual System.ArraySegment<T> Slice(System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @count};
            var ___result = RSlice_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.ArraySegment<T>)___result;
        }


        public virtual T[] ToArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToArray.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public static System.Boolean op_Equality(System.ArraySegment<T> @a, System.ArraySegment<T> @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Equality_ArraySegment_d_T_p__ArraySegment_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.ArraySegment<T> @a, System.ArraySegment<T> @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Inequality_ArraySegment_d_T_p__ArraySegment_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.ArraySegment<T> op_Implicit(T[] @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array};
            var ___result = Rop_Implicit_TArray.Invoke(___genericsType, ___parameters);

            return (System.ArraySegment<T>)___result;
        }


        public virtual System.Int32 System__2__Collections__2__Generic__2__IList__0__T__1____2__IndexOf(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__2__Collections__2__Generic__2__IList__0__T__1____2__IndexOf_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void System__2__Collections__2__Generic__2__IList__0__T__1____2__Insert(System.Int32 @index, T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @item};
            var ___result = RSystem__2__Collections__2__Generic__2__IList__0__T__1____2__Insert_Int32_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__Generic__2__IList__0__T__1____2__RemoveAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RSystem__2__Collections__2__Generic__2__IList__0__T__1____2__RemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Add(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Add_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Clear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Contains(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Contains_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Remove(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Remove_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual void ThrowInvalidOperationIfDefault()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RThrowInvalidOperationIfDefault.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
