using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
	/// System.Collections.Generic.Queue`1
	/// </summary>
    public partial class RQueue<T> : RMember //
    {

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
		/// System.Int32 _head
		/// </summary>
		protected RField r__head;
		public virtual RField R_head
		{
			get
			{
				if(r__head == null)
				{
					r__head = new(this, "_head");
					r__head.SetBelong(this.instance);
				}
				return r__head;
			}
		}

		/// <summary>
		/// System.Int32 _tail
		/// </summary>
		protected RField r__tail;
		public virtual RField R_tail
		{
			get
			{
				if(r__tail == null)
				{
					r__tail = new(this, "_tail");
					r__tail.SetBelong(this.instance);
				}
				return r__tail;
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
		/// System.Int32 MinimumGrow
		/// </summary>
		protected static RField r_MinimumGrow;
		public static RField RMinimumGrow
		{
			get
			{
				if(r_MinimumGrow == null)
				{
					r_MinimumGrow = new(typeof(System.Collections.Generic.Queue<>), "MinimumGrow");
					r_MinimumGrow.SetBelong(null);
				}
				return r_MinimumGrow;
			}
		}

		/// <summary>
		/// System.Int32 GrowFactor
		/// </summary>
		protected static RField r_GrowFactor;
		public static RField RGrowFactor
		{
			get
			{
				if(r_GrowFactor == null)
				{
					r_GrowFactor = new(typeof(System.Collections.Generic.Queue<>), "GrowFactor");
					r_GrowFactor.SetBelong(null);
				}
				return r_GrowFactor;
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
		/// Void Enqueue(T)
		/// </summary>
		protected RMethod r_Enqueue_T;
		public virtual RMethod REnqueue_T
		{
			get
			{
				if(r_Enqueue_T == null)
				{
					r_Enqueue_T = new(this, "Enqueue", 0, Type.MakeGenericMethodParameter(0));
					r_Enqueue_T.SetBelong(this.instance);
				}
				return r_Enqueue_T;
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
		/// T Dequeue()
		/// </summary>
		protected RMethod r_Dequeue;
		public virtual RMethod RDequeue
		{
			get
			{
				if(r_Dequeue == null)
				{
					r_Dequeue = new(this, "Dequeue", 0);
					r_Dequeue.SetBelong(this.instance);
				}
				return r_Dequeue;
			}
		}

		/// <summary>
		/// Boolean TryDequeue(T ByRef)
		/// </summary>
		protected RMethod r_TryDequeue_Out_T;
		public virtual RMethod RTryDequeue_Out_T
		{
			get
			{
				if(r_TryDequeue_Out_T == null)
				{
					r_TryDequeue_Out_T = new(this, "TryDequeue", 0, Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_TryDequeue_Out_T.SetBelong(this.instance);
				}
				return r_TryDequeue_Out_T;
			}
		}

		/// <summary>
		/// T Peek()
		/// </summary>
		protected RMethod r_Peek;
		public virtual RMethod RPeek
		{
			get
			{
				if(r_Peek == null)
				{
					r_Peek = new(this, "Peek", 0);
					r_Peek.SetBelong(this.instance);
				}
				return r_Peek;
			}
		}

		/// <summary>
		/// Boolean TryPeek(T ByRef)
		/// </summary>
		protected RMethod r_TryPeek_Out_T;
		public virtual RMethod RTryPeek_Out_T
		{
			get
			{
				if(r_TryPeek_Out_T == null)
				{
					r_TryPeek_Out_T = new(this, "TryPeek", 0, Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_TryPeek_Out_T.SetBelong(this.instance);
				}
				return r_TryPeek_Out_T;
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
		/// Void MoveNext(Int32 ByRef)
		/// </summary>
		protected RMethod r_MoveNext_Ref_Int32;
		public virtual RMethod RMoveNext_Ref_Int32
		{
			get
			{
				if(r_MoveNext_Ref_Int32 == null)
				{
					r_MoveNext_Ref_Int32 = new(this, "MoveNext", 0, typeof(System.Int32).MakeByRefType());
					r_MoveNext_Ref_Int32.SetBelong(this.instance);
				}
				return r_MoveNext_Ref_Int32;
			}
		}

		/// <summary>
		/// Void ThrowForEmptyQueue()
		/// </summary>
		protected RMethod r_ThrowForEmptyQueue;
		public virtual RMethod RThrowForEmptyQueue
		{
			get
			{
				if(r_ThrowForEmptyQueue == null)
				{
					r_ThrowForEmptyQueue = new(this, "ThrowForEmptyQueue", 0);
					r_ThrowForEmptyQueue.SetBelong(this.instance);
				}
				return r_ThrowForEmptyQueue;
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


        public RQueue() : base("System.Collections.Generic.Queue`1")
        {
        }

        public RQueue(System.Object instance) : base("System.Collections.Generic.Queue`1")
		{
            SetInstance(instance);
		}

        public RQueue(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RQueue(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(T[] @array, System.Int32 @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RCopyTo_TArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__ICollection__2__CopyTo(System.Array @array, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RSystem__2__Collections__2__ICollection__2__CopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Enqueue(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = REnqueue_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RSystem.RCollections.RGeneric.RQueue<RType>.REnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return new RSystem.RCollections.RGeneric.RQueue<RType>.REnumerator(___result);
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


        public virtual T Dequeue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDequeue.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual System.Boolean TryDequeue(out T @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = RTryDequeue_Out_T.Invoke(___genericsType, ___parameters);
			@result = (T)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual T Peek()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPeek.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual System.Boolean TryPeek(out T @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = RTryPeek_Out_T.Invoke(___genericsType, ___parameters);
			@result = (T)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Contains(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RContains_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual T[] ToArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToArray.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual void SetCapacity(System.Int32 @capacity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@capacity};
            var ___result = RSetCapacity_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveNext(ref System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMoveNext_Ref_Int32.Invoke(___genericsType, ___parameters);
			@index = (System.Int32)___parameters[0];

            
        }


        public virtual void ThrowForEmptyQueue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RThrowForEmptyQueue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TrimExcess()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTrimExcess.Invoke(___genericsType, ___parameters);

            
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
