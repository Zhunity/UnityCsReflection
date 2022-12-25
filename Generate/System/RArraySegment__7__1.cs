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
		protected static RSystem.RArraySegment<RField> r___1__Empty__2__k__BackingField;
		public static RSystem.RArraySegment<RField> R__1__Empty__2__k__BackingField
		{
			get
			{
				if(r___1__Empty__2__k__BackingField == null)
				{
					r___1__Empty__2__k__BackingField = new(typeof(System.ArraySegment<>), "<Empty>k__BackingField");
					r___1__Empty__2__k__BackingField.SetBelong(null);
				}
				return r___1__Empty__2__k__BackingField;
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
		protected RField r__offset;
		public virtual RField R_offset
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
		protected RProperty r_Offset;
		public virtual RProperty ROffset
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
		/// T System.Collections.Generic.IReadOnlyList<T>.Item [Int32]
		/// </summary>
		protected RProperty r_RSystem__0__Collections__0__Generic__0__IReadOnlyList__1__T__2____0__get_Item_Int32;
		public virtual RProperty RSystem__0__Collections__0__Generic__0__IReadOnlyList__1__T__2____0__get_Item_Int32
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__IReadOnlyList__1__T__2____0__get_Item_Int32 == null)
				{
					r_RSystem__0__Collections__0__Generic__0__IReadOnlyList__1__T__2____0__get_Item_Int32 = new(this, "System.Collections.Generic.IReadOnlyList<T>.Item", -1, typeof(System.Int32));
					r_RSystem__0__Collections__0__Generic__0__IReadOnlyList__1__T__2____0__get_Item_Int32.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__IReadOnlyList__1__T__2____0__get_Item_Int32;
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
		/// Void CopyTo(System.ArraySegment`1[T])
		/// </summary>
		protected RMethod r_RCopyTo_ArraySegment_d_T_p_;
		public virtual RMethod RCopyTo_ArraySegment_d_T_p_
		{
			get
			{
				if(r_RCopyTo_ArraySegment_d_T_p_ == null)
				{
					r_RCopyTo_ArraySegment_d_T_p_ = new(this, "CopyTo", 0, typeof(System.ArraySegment<>));
					r_RCopyTo_ArraySegment_d_T_p_.SetBelong(this.instance);
				}
				return r_RCopyTo_ArraySegment_d_T_p_;
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
		/// Boolean Equals(System.ArraySegment`1[T])
		/// </summary>
		protected RMethod r_REquals_ArraySegment_d_T_p_;
		public virtual RMethod REquals_ArraySegment_d_T_p_
		{
			get
			{
				if(r_REquals_ArraySegment_d_T_p_ == null)
				{
					r_REquals_ArraySegment_d_T_p_ = new(this, "Equals", 0, typeof(System.ArraySegment<>));
					r_REquals_ArraySegment_d_T_p_.SetBelong(this.instance);
				}
				return r_REquals_ArraySegment_d_T_p_;
			}
		}

		/// <summary>
		/// System.ArraySegment`1[T] Slice(Int32)
		/// </summary>
		protected RMethod r_RSlice_Int32;
		public virtual RMethod RSlice_Int32
		{
			get
			{
				if(r_RSlice_Int32 == null)
				{
					r_RSlice_Int32 = new(this, "Slice", 0, typeof(System.Int32));
					r_RSlice_Int32.SetBelong(this.instance);
				}
				return r_RSlice_Int32;
			}
		}

		/// <summary>
		/// System.ArraySegment`1[T] Slice(Int32, Int32)
		/// </summary>
		protected RMethod r_RSlice_Int32_Int32;
		public virtual RMethod RSlice_Int32_Int32
		{
			get
			{
				if(r_RSlice_Int32_Int32 == null)
				{
					r_RSlice_Int32_Int32 = new(this, "Slice", 0, typeof(System.Int32), typeof(System.Int32));
					r_RSlice_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSlice_Int32_Int32;
			}
		}

		/// <summary>
		/// T[] ToArray()
		/// </summary>
		protected RMethod r_RToArray;
		public virtual RMethod RToArray
		{
			get
			{
				if(r_RToArray == null)
				{
					r_RToArray = new(this, "ToArray", 0);
					r_RToArray.SetBelong(this.instance);
				}
				return r_RToArray;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.ArraySegment`1[T], System.ArraySegment`1[T])
		/// </summary>
		protected static RMethod r_Rop_Equality_ArraySegment_d_T_p__ArraySegment_d_T_p_;
		public static RMethod Rop_Equality_ArraySegment_d_T_p__ArraySegment_d_T_p_
		{
			get
			{
				if(r_Rop_Equality_ArraySegment_d_T_p__ArraySegment_d_T_p_ == null)
				{
					r_Rop_Equality_ArraySegment_d_T_p__ArraySegment_d_T_p_ = new(typeof(System.ArraySegment<>), "op_Equality", 0, typeof(System.ArraySegment<>), typeof(System.ArraySegment<>));
					r_Rop_Equality_ArraySegment_d_T_p__ArraySegment_d_T_p_.SetBelong(null);
				}
				return r_Rop_Equality_ArraySegment_d_T_p__ArraySegment_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.ArraySegment`1[T], System.ArraySegment`1[T])
		/// </summary>
		protected static RMethod r_Rop_Inequality_ArraySegment_d_T_p__ArraySegment_d_T_p_;
		public static RMethod Rop_Inequality_ArraySegment_d_T_p__ArraySegment_d_T_p_
		{
			get
			{
				if(r_Rop_Inequality_ArraySegment_d_T_p__ArraySegment_d_T_p_ == null)
				{
					r_Rop_Inequality_ArraySegment_d_T_p__ArraySegment_d_T_p_ = new(typeof(System.ArraySegment<>), "op_Inequality", 0, typeof(System.ArraySegment<>), typeof(System.ArraySegment<>));
					r_Rop_Inequality_ArraySegment_d_T_p__ArraySegment_d_T_p_.SetBelong(null);
				}
				return r_Rop_Inequality_ArraySegment_d_T_p__ArraySegment_d_T_p_;
			}
		}

		/// <summary>
		/// System.ArraySegment`1[T] op_Implicit(T[])
		/// </summary>
		protected static RMethod r_Rop_Implicit_TArray;
		public static RMethod Rop_Implicit_TArray
		{
			get
			{
				if(r_Rop_Implicit_TArray == null)
				{
					r_Rop_Implicit_TArray = new(typeof(System.ArraySegment<>), "op_Implicit", 0, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_Rop_Implicit_TArray.SetBelong(null);
				}
				return r_Rop_Implicit_TArray;
			}
		}

		/// <summary>
		/// Int32 System.Collections.Generic.IList<T>.IndexOf(T)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__IndexOf_T;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__IndexOf_T
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__IndexOf_T == null)
				{
					r_RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__IndexOf_T = new(this, "System.Collections.Generic.IList<T>.IndexOf", 0, Type.MakeGenericMethodParameter(0));
					r_RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__IndexOf_T.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__IndexOf_T;
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
		/// Boolean System.Collections.Generic.ICollection<T>.Contains(T)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Contains_T;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Contains_T
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Contains_T == null)
				{
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Contains_T = new(this, "System.Collections.Generic.ICollection<T>.Contains", 0, Type.MakeGenericMethodParameter(0));
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Contains_T.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Contains_T;
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
		/// Void ThrowInvalidOperationIfDefault()
		/// </summary>
		protected RMethod r_RThrowInvalidOperationIfDefault;
		public virtual RMethod RThrowInvalidOperationIfDefault
		{
			get
			{
				if(r_RThrowInvalidOperationIfDefault == null)
				{
					r_RThrowInvalidOperationIfDefault = new(this, "ThrowInvalidOperationIfDefault", 0);
					r_RThrowInvalidOperationIfDefault.SetBelong(this.instance);
				}
				return r_RThrowInvalidOperationIfDefault;
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

        public virtual System.Object GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void CopyTo(T[]  @destination)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination};
            var ___result = RCopyTo_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(T[]  @destination, System.Int32  @destinationIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination, @destinationIndex};
            var ___result = RCopyTo_TArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.ArraySegment<T>  @destination)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination};
            var ___result = RCopyTo_ArraySegment_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.ArraySegment<T>  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_ArraySegment_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.ArraySegment<T> Slice(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RSlice_Int32.Invoke(___genericsType, ___parameters);

            return (System.ArraySegment<T>)___result;
        }


        public virtual System.ArraySegment<T> Slice(System.Int32  @index, System.Int32  @count)
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


        public static System.Boolean op_Equality(System.ArraySegment<T>  @a, System.ArraySegment<T>  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Equality_ArraySegment_d_T_p__ArraySegment_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.ArraySegment<T>  @a, System.ArraySegment<T>  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Inequality_ArraySegment_d_T_p__ArraySegment_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.ArraySegment<T> op_Implicit(T[]  @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array};
            var ___result = Rop_Implicit_TArray.Invoke(___genericsType, ___parameters);

            return (System.ArraySegment<T>)___result;
        }


        public virtual System.Int32 System__0__Collections__0__Generic__0__IList__1__T__2____0__IndexOf(T  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__IndexOf_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void System__0__Collections__0__Generic__0__IList__1__T__2____0__Insert(System.Int32  @index, T  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @item};
            var ___result = RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__Insert_Int32_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Collections__0__Generic__0__IList__1__T__2____0__RemoveAt(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RSystem__0__Collections__0__Generic__0__IList__1__T__2____0__RemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Collections__0__Generic__0__ICollection__1__T__2____0__Add(T  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Add_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Collections__0__Generic__0__ICollection__1__T__2____0__Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Clear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean System__0__Collections__0__Generic__0__ICollection__1__T__2____0__Contains(T  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Contains_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean System__0__Collections__0__Generic__0__ICollection__1__T__2____0__Remove(T  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__0__Collections__0__Generic__0__ICollection__1__T__2____0__Remove_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
