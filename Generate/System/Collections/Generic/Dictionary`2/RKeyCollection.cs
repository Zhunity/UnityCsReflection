using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric
{public partial class RDictionary<TKey, TValue>
{
	
	/// <summary>
	/// System.Collections.Generic.Dictionary`2+KeyCollection
	/// </summary>
    public partial class RKeyCollection : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[TKey,TValue] _dictionary
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RField> r__dictionary;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RField> R_dictionary
		{
			get
			{
				if(r__dictionary == null)
				{
					r__dictionary = new(this, "_dictionary");
					r__dictionary.SetBelong(this.instance);
				}
				return r__dictionary;
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
		/// Boolean System.Collections.Generic.ICollection<TKey>.IsReadOnly
		/// </summary>
		protected RProperty r_RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__get_IsReadOnly;
		public virtual RProperty RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__get_IsReadOnly
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__get_IsReadOnly == null)
				{
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__get_IsReadOnly = new(this, "System.Collections.Generic.ICollection<TKey>.IsReadOnly", -1);
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__get_IsReadOnly.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__get_IsReadOnly;
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
		/// Void CopyTo(TKey[], Int32)
		/// </summary>
		protected RMethod r_RCopyTo_TKeyArray_Int32;
		public virtual RMethod RCopyTo_TKeyArray_Int32
		{
			get
			{
				if(r_RCopyTo_TKeyArray_Int32 == null)
				{
					r_RCopyTo_TKeyArray_Int32 = new(this, "CopyTo", 0, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32));
					r_RCopyTo_TKeyArray_Int32.SetBelong(this.instance);
				}
				return r_RCopyTo_TKeyArray_Int32;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.ICollection<TKey>.Add(TKey)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Add_TKey;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Add_TKey
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Add_TKey == null)
				{
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Add_TKey = new(this, "System.Collections.Generic.ICollection<TKey>.Add", 0, Type.MakeGenericMethodParameter(0));
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Add_TKey.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Add_TKey;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.ICollection<TKey>.Clear()
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Clear;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Clear
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Clear == null)
				{
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Clear = new(this, "System.Collections.Generic.ICollection<TKey>.Clear", 0);
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Clear.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Clear;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<TKey>.Contains(TKey)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Contains_TKey;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Contains_TKey
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Contains_TKey == null)
				{
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Contains_TKey = new(this, "System.Collections.Generic.ICollection<TKey>.Contains", 0, Type.MakeGenericMethodParameter(0));
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Contains_TKey.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Contains_TKey;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<TKey>.Remove(TKey)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Remove_TKey;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Remove_TKey
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Remove_TKey == null)
				{
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Remove_TKey = new(this, "System.Collections.Generic.ICollection<TKey>.Remove", 0, Type.MakeGenericMethodParameter(0));
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Remove_TKey.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Remove_TKey;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerator`1[TKey] System.Collections.Generic.IEnumerable<TKey>.GetEnumerator()
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__IEnumerable__1__TKey__2____0__GetEnumerator;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__IEnumerable__1__TKey__2____0__GetEnumerator
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__IEnumerable__1__TKey__2____0__GetEnumerator == null)
				{
					r_RSystem__0__Collections__0__Generic__0__IEnumerable__1__TKey__2____0__GetEnumerator = new(this, "System.Collections.Generic.IEnumerable<TKey>.GetEnumerator", 0);
					r_RSystem__0__Collections__0__Generic__0__IEnumerable__1__TKey__2____0__GetEnumerator.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__IEnumerable__1__TKey__2____0__GetEnumerator;
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


        public RKeyCollection() : base("System.Collections.Generic.Dictionary`2+KeyCollection")
        {
        }

        public RKeyCollection(System.Object instance) : base("System.Collections.Generic.Dictionary`2+KeyCollection")
		{
            SetInstance(instance);
		}

        public RKeyCollection(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RKeyCollection(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void CopyTo(TKey[]  @array, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RCopyTo_TKeyArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Add(TKey  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Add_TKey.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Clear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean System__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Contains(TKey  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Contains_TKey.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean System__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Remove(TKey  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__0__Collections__0__Generic__0__ICollection__1__TKey__2____0__Remove_TKey.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.Generic.IEnumerator<TKey> System__0__Collections__0__Generic__0__IEnumerable__1__TKey__2____0__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__0__Collections__0__Generic__0__IEnumerable__1__TKey__2____0__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerator<TKey>)___result;
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
}