
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
	/// System.Collections.Generic.Stack`1
	/// </summary>
    public partial class RStack<T> : RMember //
    {

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
		/// System.Int32 DefaultCapacity
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FDefaultCapacity;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFDefaultCapacity
		{
			get
			{
				if(r_FDefaultCapacity == null)
				{
					r_FDefaultCapacity = new(typeof(System.Collections.Generic.Stack<>), "DefaultCapacity");
				}
				return r_FDefaultCapacity;
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
		/// T Peek()
		/// </summary>
		protected RMethod r_MPeek;
		public virtual RMethod RMPeek
		{
			get
			{
				if(r_MPeek == null)
				{
					r_MPeek = new(this, "Peek", 0);
				}
				return r_MPeek;
			}
		}

		/// <summary>
		/// Boolean TryPeek(T ByRef)
		/// </summary>
		protected RMethod r_MTryPeek_Out_T;
		public virtual RMethod RMTryPeek_Out_T
		{
			get
			{
				if(r_MTryPeek_Out_T == null)
				{
					r_MTryPeek_Out_T = new(this, "TryPeek", 0, Type.MakeGenericMethodParameter(0).MakeByRefType());
				}
				return r_MTryPeek_Out_T;
			}
		}

		/// <summary>
		/// T Pop()
		/// </summary>
		protected RMethod r_MPop;
		public virtual RMethod RMPop
		{
			get
			{
				if(r_MPop == null)
				{
					r_MPop = new(this, "Pop", 0);
				}
				return r_MPop;
			}
		}

		/// <summary>
		/// Boolean TryPop(T ByRef)
		/// </summary>
		protected RMethod r_MTryPop_Out_T;
		public virtual RMethod RMTryPop_Out_T
		{
			get
			{
				if(r_MTryPop_Out_T == null)
				{
					r_MTryPop_Out_T = new(this, "TryPop", 0, Type.MakeGenericMethodParameter(0).MakeByRefType());
				}
				return r_MTryPop_Out_T;
			}
		}

		/// <summary>
		/// Void Push(T)
		/// </summary>
		protected RMethod r_MPush_T;
		public virtual RMethod RMPush_T
		{
			get
			{
				if(r_MPush_T == null)
				{
					r_MPush_T = new(this, "Push", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MPush_T;
			}
		}

		/// <summary>
		/// Void PushWithResize(T)
		/// </summary>
		protected RMethod r_MPushWithResize_T;
		public virtual RMethod RMPushWithResize_T
		{
			get
			{
				if(r_MPushWithResize_T == null)
				{
					r_MPushWithResize_T = new(this, "PushWithResize", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MPushWithResize_T;
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
		/// Void ThrowForEmptyStack()
		/// </summary>
		protected RMethod r_MThrowForEmptyStack;
		public virtual RMethod RMThrowForEmptyStack
		{
			get
			{
				if(r_MThrowForEmptyStack == null)
				{
					r_MThrowForEmptyStack = new(this, "ThrowForEmptyStack", 0);
				}
				return r_MThrowForEmptyStack;
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


        public RStack() : base("System.Collections.Generic.Stack`1")
        {
        }

        public RStack(System.Object instance) : base("System.Collections.Generic.Stack`1")
		{
            SetInstance(instance);
		}

        public RStack(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStack(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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

            return (System.Boolean)___result;
        }


        public virtual void CopyTo(T[] @array, System.Int32 @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RMCopyTo_TArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__ICollection__2__CopyTo(System.Array @array, System.Int32 @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RMSystem__2__Collections__2__ICollection__2__CopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RStack<Hvak.Editor.Refleaction.RType>.REnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RStack<Hvak.Editor.Refleaction.RType>.REnumerator(___result);
        }


        public virtual System.Collections.Generic.IEnumerator<T> System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerator<T>)___result;
        }


        public virtual System.Collections.IEnumerator System__2__Collections__2__IEnumerable__2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void TrimExcess()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTrimExcess.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T Peek()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPeek.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual System.Boolean TryPeek(out T @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = RMTryPeek_Out_T.Invoke(___genericsType, ___parameters);
			@result = (T)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual T Pop()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPop.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual System.Boolean TryPop(out T @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = RMTryPop_Out_T.Invoke(___genericsType, ___parameters);
			@result = (T)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual void Push(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMPush_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PushWithResize(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMPushWithResize_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T[] ToArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToArray.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual void ThrowForEmptyStack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMThrowForEmptyStack.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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

            return (System.Int32)___result;
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
