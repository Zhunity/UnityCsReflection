
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.ArraySegment`1
	/// </summary>
    public partial class RArraySegment<T> : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.ArraySegment`1").MakeGenericType(ReflectionUtils.GetType(typeof(T)));
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


		/// <summary>
		/// System.ArraySegment`1[T] <Empty>k__BackingField
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RArraySegment<Hvak.Editor.Refleaction.RField> r_F__0__Empty__1__k__BackingField;
		public static Hvak.Editor.Refleaction.RSystem.RArraySegment<Hvak.Editor.Refleaction.RField> RF__0__Empty__1__k__BackingField
		{
			get
			{
				if(r_F__0__Empty__1__k__BackingField == null)
				{
					r_F__0__Empty__1__k__BackingField = new(Type, "<Empty>k__BackingField");
				}
				return r_F__0__Empty__1__k__BackingField;
			}
		}

		/// <summary>
		/// T[] _array
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RField> r_F_array;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RField> RF_array
		{
			get
			{
				if(r_F_array == null)
				{
					r_F_array = new(this, "_array");
				}
				return r_F_array;
			}
		}

		/// <summary>
		/// System.Int32 _offset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_offset;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_offset
		{
			get
			{
				if(r_F_offset == null)
				{
					r_F_offset = new(this, "_offset");
				}
				return r_F_offset;
			}
		}

		/// <summary>
		/// System.Int32 _count
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_count;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_count
		{
			get
			{
				if(r_F_count == null)
				{
					r_F_count = new(this, "_count");
				}
				return r_F_count;
			}
		}

		/// <summary>
		/// System.ArraySegment`1[T] Empty
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RArraySegment<Hvak.Editor.Refleaction.RProperty> r_PEmpty;
		public static Hvak.Editor.Refleaction.RSystem.RArraySegment<Hvak.Editor.Refleaction.RProperty> RPEmpty
		{
			get
			{
				if(r_PEmpty == null)
				{
					r_PEmpty = new(Type, "Empty", -1);
				}
				return r_PEmpty;
			}
		}

		/// <summary>
		/// T[] Array
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RProperty> r_PArray;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RProperty> RPArray
		{
			get
			{
				if(r_PArray == null)
				{
					r_PArray = new(this, "Array", -1);
				}
				return r_PArray;
			}
		}

		/// <summary>
		/// Int32 Offset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_POffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPOffset
		{
			get
			{
				if(r_POffset == null)
				{
					r_POffset = new(this, "Offset", -1);
				}
				return r_POffset;
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
		/// T System.Collections.Generic.IList<T>.Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_PSystem__2__Collections__2__Generic__2__IList__0__T__1____2__Item_Int32;
		public virtual Hvak.Editor.Refleaction.RProperty RPSystem__2__Collections__2__Generic__2__IList__0__T__1____2__Item_Int32
		{
			get
			{
				if(r_PSystem__2__Collections__2__Generic__2__IList__0__T__1____2__Item_Int32 == null)
				{
					r_PSystem__2__Collections__2__Generic__2__IList__0__T__1____2__Item_Int32 = new(this, "System.Collections.Generic.IList<T>.Item", -1, typeof(System.Int32));
				}
				return r_PSystem__2__Collections__2__Generic__2__IList__0__T__1____2__Item_Int32;
			}
		}

		/// <summary>
		/// T System.Collections.Generic.IReadOnlyList<T>.Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_PSystem__2__Collections__2__Generic__2__IReadOnlyList__0__T__1____2__Item_Int32;
		public virtual Hvak.Editor.Refleaction.RProperty RPSystem__2__Collections__2__Generic__2__IReadOnlyList__0__T__1____2__Item_Int32
		{
			get
			{
				if(r_PSystem__2__Collections__2__Generic__2__IReadOnlyList__0__T__1____2__Item_Int32 == null)
				{
					r_PSystem__2__Collections__2__Generic__2__IReadOnlyList__0__T__1____2__Item_Int32 = new(this, "System.Collections.Generic.IReadOnlyList<T>.Item", -1, typeof(System.Int32));
				}
				return r_PSystem__2__Collections__2__Generic__2__IReadOnlyList__0__T__1____2__Item_Int32;
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
		/// Void CopyTo(System.ArraySegment`1[T])
		/// </summary>
		protected RMethod r_MCopyTo_ArraySegment_d_T_p_;
		public virtual RMethod RMCopyTo_ArraySegment_d_T_p_
		{
			get
			{
				if(r_MCopyTo_ArraySegment_d_T_p_ == null)
				{
					r_MCopyTo_ArraySegment_d_T_p_ = new(this, "CopyTo", 0,  ReflectionUtils.GetType("System.ArraySegment`1"));
				}
				return r_MCopyTo_ArraySegment_d_T_p_;
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
		/// Boolean Equals(System.ArraySegment`1[T])
		/// </summary>
		protected RMethod r_MEquals_ArraySegment_d_T_p_;
		public virtual RMethod RMEquals_ArraySegment_d_T_p_
		{
			get
			{
				if(r_MEquals_ArraySegment_d_T_p_ == null)
				{
					r_MEquals_ArraySegment_d_T_p_ = new(this, "Equals", 0,  ReflectionUtils.GetType("System.ArraySegment`1"));
				}
				return r_MEquals_ArraySegment_d_T_p_;
			}
		}

		/// <summary>
		/// System.ArraySegment`1[T] Slice(Int32)
		/// </summary>
		protected RMethod r_MSlice_Int32;
		public virtual RMethod RMSlice_Int32
		{
			get
			{
				if(r_MSlice_Int32 == null)
				{
					r_MSlice_Int32 = new(this, "Slice", 0, typeof(System.Int32));
				}
				return r_MSlice_Int32;
			}
		}

		/// <summary>
		/// System.ArraySegment`1[T] Slice(Int32, Int32)
		/// </summary>
		protected RMethod r_MSlice_Int32_Int32;
		public virtual RMethod RMSlice_Int32_Int32
		{
			get
			{
				if(r_MSlice_Int32_Int32 == null)
				{
					r_MSlice_Int32_Int32 = new(this, "Slice", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSlice_Int32_Int32;
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
		/// Boolean op_Equality(System.ArraySegment`1[T], System.ArraySegment`1[T])
		/// </summary>
		protected static RMethod r_Mop_Equality_ArraySegment_d_T_p__ArraySegment_d_T_p_;
		public static RMethod RMop_Equality_ArraySegment_d_T_p__ArraySegment_d_T_p_
		{
			get
			{
				if(r_Mop_Equality_ArraySegment_d_T_p__ArraySegment_d_T_p_ == null)
				{
					r_Mop_Equality_ArraySegment_d_T_p__ArraySegment_d_T_p_ = new(Type, "op_Equality", 0,  ReflectionUtils.GetType("System.ArraySegment`1"),  ReflectionUtils.GetType("System.ArraySegment`1"));
				}
				return r_Mop_Equality_ArraySegment_d_T_p__ArraySegment_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.ArraySegment`1[T], System.ArraySegment`1[T])
		/// </summary>
		protected static RMethod r_Mop_Inequality_ArraySegment_d_T_p__ArraySegment_d_T_p_;
		public static RMethod RMop_Inequality_ArraySegment_d_T_p__ArraySegment_d_T_p_
		{
			get
			{
				if(r_Mop_Inequality_ArraySegment_d_T_p__ArraySegment_d_T_p_ == null)
				{
					r_Mop_Inequality_ArraySegment_d_T_p__ArraySegment_d_T_p_ = new(Type, "op_Inequality", 0,  ReflectionUtils.GetType("System.ArraySegment`1"),  ReflectionUtils.GetType("System.ArraySegment`1"));
				}
				return r_Mop_Inequality_ArraySegment_d_T_p__ArraySegment_d_T_p_;
			}
		}

		/// <summary>
		/// System.ArraySegment`1[T] op_Implicit(T[])
		/// </summary>
		protected static RMethod r_Mop_Implicit_TArray;
		public static RMethod RMop_Implicit_TArray
		{
			get
			{
				if(r_Mop_Implicit_TArray == null)
				{
					r_Mop_Implicit_TArray = new(Type, "op_Implicit", 0, Type.MakeGenericMethodParameter(0).MakeArrayType());
				}
				return r_Mop_Implicit_TArray;
			}
		}

		/// <summary>
		/// Int32 System.Collections.Generic.IList<T>.IndexOf(T)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__IList__0__T__1____2__IndexOf_T;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__IList__0__T__1____2__IndexOf_T
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__IList__0__T__1____2__IndexOf_T == null)
				{
					r_MSystem__2__Collections__2__Generic__2__IList__0__T__1____2__IndexOf_T = new(this, "System.Collections.Generic.IList<T>.IndexOf", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MSystem__2__Collections__2__Generic__2__IList__0__T__1____2__IndexOf_T;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.IList<T>.Insert(Int32, T)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__IList__0__T__1____2__Insert_Int32_T;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__IList__0__T__1____2__Insert_Int32_T
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__IList__0__T__1____2__Insert_Int32_T == null)
				{
					r_MSystem__2__Collections__2__Generic__2__IList__0__T__1____2__Insert_Int32_T = new(this, "System.Collections.Generic.IList<T>.Insert", 0, typeof(System.Int32), Type.MakeGenericMethodParameter(0));
				}
				return r_MSystem__2__Collections__2__Generic__2__IList__0__T__1____2__Insert_Int32_T;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.IList<T>.RemoveAt(Int32)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__IList__0__T__1____2__RemoveAt_Int32;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__IList__0__T__1____2__RemoveAt_Int32
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__IList__0__T__1____2__RemoveAt_Int32 == null)
				{
					r_MSystem__2__Collections__2__Generic__2__IList__0__T__1____2__RemoveAt_Int32 = new(this, "System.Collections.Generic.IList<T>.RemoveAt", 0, typeof(System.Int32));
				}
				return r_MSystem__2__Collections__2__Generic__2__IList__0__T__1____2__RemoveAt_Int32;
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
		/// Void System.Collections.Generic.ICollection<T>.Clear()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Clear;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Clear
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Clear == null)
				{
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Clear = new(this, "System.Collections.Generic.ICollection<T>.Clear", 0);
				}
				return r_MSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Clear;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<T>.Contains(T)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Contains_T;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Contains_T
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Contains_T == null)
				{
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Contains_T = new(this, "System.Collections.Generic.ICollection<T>.Contains", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Contains_T;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<T>.Remove(T)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Remove_T;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Remove_T
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Remove_T == null)
				{
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Remove_T = new(this, "System.Collections.Generic.ICollection<T>.Remove", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Remove_T;
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
		/// Void ThrowInvalidOperationIfDefault()
		/// </summary>
		protected RMethod r_MThrowInvalidOperationIfDefault;
		public virtual RMethod RMThrowInvalidOperationIfDefault
		{
			get
			{
				if(r_MThrowInvalidOperationIfDefault == null)
				{
					r_MThrowInvalidOperationIfDefault = new(this, "ThrowInvalidOperationIfDefault", 0);
				}
				return r_MThrowInvalidOperationIfDefault;
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


        public virtual Hvak.Editor.Refleaction.RSystem.RArraySegment<Hvak.Editor.Refleaction.RType>.REnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RArraySegment<Hvak.Editor.Refleaction.RType>.REnumerator>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual void CopyTo(T[] @destination)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination};
            var ___result = RMCopyTo_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(T[] @destination, System.Int32 @destinationIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination, @destinationIndex};
            var ___result = RMCopyTo_TArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.ArraySegment<T> @destination)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination};
            var ___result = RMCopyTo_ArraySegment_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.ArraySegment<T> @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_ArraySegment_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.ArraySegment<T> Slice(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMSlice_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.ArraySegment<T>>(___result);
        }


        public virtual System.ArraySegment<T> Slice(System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @count};
            var ___result = RMSlice_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.ArraySegment<T>>(___result);
        }


        public virtual T[] ToArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T[]>(___result);
        }


        public static System.Boolean op_Equality(System.ArraySegment<T> @a, System.ArraySegment<T> @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Equality_ArraySegment_d_T_p__ArraySegment_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(System.ArraySegment<T> @a, System.ArraySegment<T> @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Inequality_ArraySegment_d_T_p__ArraySegment_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.ArraySegment<T> op_Implicit(T[] @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array};
            var ___result = RMop_Implicit_TArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.ArraySegment<T>>(___result);
        }


        public virtual System.Int32 System__2__Collections__2__Generic__2__IList__0__T__1____2__IndexOf(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMSystem__2__Collections__2__Generic__2__IList__0__T__1____2__IndexOf_T.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual void System__2__Collections__2__Generic__2__IList__0__T__1____2__Insert(System.Int32 @index, T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @item};
            var ___result = RMSystem__2__Collections__2__Generic__2__IList__0__T__1____2__Insert_Int32_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__Generic__2__IList__0__T__1____2__RemoveAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMSystem__2__Collections__2__Generic__2__IList__0__T__1____2__RemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Add(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Add_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Clear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Contains(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Contains_T.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean System__2__Collections__2__Generic__2__ICollection__0__T__1____2__Remove(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__T__1____2__Remove_T.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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


        public virtual void ThrowInvalidOperationIfDefault()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMThrowInvalidOperationIfDefault.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
