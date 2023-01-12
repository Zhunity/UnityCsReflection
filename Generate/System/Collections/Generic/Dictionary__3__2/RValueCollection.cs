using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric
{public partial class RDictionary<TKey, TValue>
{
	
	/// <summary>
	/// System.Collections.Generic.Dictionary`2+ValueCollection
	/// </summary>
    public partial class RValueCollection : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[TKey,TValue] _dictionary
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RField> r_F_dictionary;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RField> RF_dictionary
		{
			get
			{
				if(r_F_dictionary == null)
				{
					r_F_dictionary = new(this, "_dictionary");
					r_F_dictionary.SetBelong(this.instance);
				}
				return r_F_dictionary;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected RSystem.RInt32 r_PCount;
		public virtual RSystem.RInt32 RPCount
		{
			get
			{
				if(r_PCount == null)
				{
					r_PCount = new(this, "Count", -1);
					r_PCount.SetBelong(this.instance);
				}
				return r_PCount;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<TValue>.IsReadOnly
		/// </summary>
		protected RSystem.RBoolean r_PSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__IsReadOnly;
		public virtual RSystem.RBoolean RPSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__IsReadOnly
		{
			get
			{
				if(r_PSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__IsReadOnly == null)
				{
					r_PSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__IsReadOnly = new(this, "System.Collections.Generic.ICollection<TValue>.IsReadOnly", -1);
					r_PSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__IsReadOnly.SetBelong(this.instance);
				}
				return r_PSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__IsReadOnly;
			}
		}

		/// <summary>
		/// Boolean System.Collections.ICollection.IsSynchronized
		/// </summary>
		protected RSystem.RBoolean r_PSystem__2__Collections__2__ICollection__2__IsSynchronized;
		public virtual RSystem.RBoolean RPSystem__2__Collections__2__ICollection__2__IsSynchronized
		{
			get
			{
				if(r_PSystem__2__Collections__2__ICollection__2__IsSynchronized == null)
				{
					r_PSystem__2__Collections__2__ICollection__2__IsSynchronized = new(this, "System.Collections.ICollection.IsSynchronized", -1);
					r_PSystem__2__Collections__2__ICollection__2__IsSynchronized.SetBelong(this.instance);
				}
				return r_PSystem__2__Collections__2__ICollection__2__IsSynchronized;
			}
		}

		/// <summary>
		/// System.Object System.Collections.ICollection.SyncRoot
		/// </summary>
		protected RSystem.RObject r_PSystem__2__Collections__2__ICollection__2__SyncRoot;
		public virtual RSystem.RObject RPSystem__2__Collections__2__ICollection__2__SyncRoot
		{
			get
			{
				if(r_PSystem__2__Collections__2__ICollection__2__SyncRoot == null)
				{
					r_PSystem__2__Collections__2__ICollection__2__SyncRoot = new(this, "System.Collections.ICollection.SyncRoot", -1);
					r_PSystem__2__Collections__2__ICollection__2__SyncRoot.SetBelong(this.instance);
				}
				return r_PSystem__2__Collections__2__ICollection__2__SyncRoot;
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
					r_MGetEnumerator.SetBelong(this.instance);
				}
				return r_MGetEnumerator;
			}
		}

		/// <summary>
		/// Void CopyTo(TValue[], Int32)
		/// </summary>
		protected RMethod r_MCopyTo_TValueArray_Int32;
		public virtual RMethod RMCopyTo_TValueArray_Int32
		{
			get
			{
				if(r_MCopyTo_TValueArray_Int32 == null)
				{
					r_MCopyTo_TValueArray_Int32 = new(this, "CopyTo", 0, Type.MakeGenericMethodParameter(1).MakeArrayType(), typeof(System.Int32));
					r_MCopyTo_TValueArray_Int32.SetBelong(this.instance);
				}
				return r_MCopyTo_TValueArray_Int32;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.ICollection<TValue>.Add(TValue)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Add_TValue;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Add_TValue
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Add_TValue == null)
				{
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Add_TValue = new(this, "System.Collections.Generic.ICollection<TValue>.Add", 0, Type.MakeGenericMethodParameter(1));
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Add_TValue.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Add_TValue;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<TValue>.Remove(TValue)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Remove_TValue;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Remove_TValue
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Remove_TValue == null)
				{
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Remove_TValue = new(this, "System.Collections.Generic.ICollection<TValue>.Remove", 0, Type.MakeGenericMethodParameter(1));
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Remove_TValue.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Remove_TValue;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.ICollection<TValue>.Clear()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Clear;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Clear
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Clear == null)
				{
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Clear = new(this, "System.Collections.Generic.ICollection<TValue>.Clear", 0);
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Clear.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Clear;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<TValue>.Contains(TValue)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Contains_TValue;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Contains_TValue
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Contains_TValue == null)
				{
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Contains_TValue = new(this, "System.Collections.Generic.ICollection<TValue>.Contains", 0, Type.MakeGenericMethodParameter(1));
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Contains_TValue.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Contains_TValue;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerator`1[TValue] System.Collections.Generic.IEnumerable<TValue>.GetEnumerator()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__TValue__1____2__GetEnumerator;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__IEnumerable__0__TValue__1____2__GetEnumerator
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__TValue__1____2__GetEnumerator == null)
				{
					r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__TValue__1____2__GetEnumerator = new(this, "System.Collections.Generic.IEnumerable<TValue>.GetEnumerator", 0);
					r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__TValue__1____2__GetEnumerator.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__TValue__1____2__GetEnumerator;
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
					r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator;
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
					r_MSystem__2__Collections__2__ICollection__2__CopyTo_Array_Int32.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__ICollection__2__CopyTo_Array_Int32;
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
			}
		}


        public RValueCollection() : base("System.Collections.Generic.Dictionary`2+ValueCollection")
        {
        }

        public RValueCollection(System.Object instance) : base("System.Collections.Generic.Dictionary`2+ValueCollection")
		{
            SetInstance(instance);
		}

        public RValueCollection(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RValueCollection(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual RSystem.RCollections.RGeneric.RDictionary<RType, RType>.RValueCollection.REnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return new RSystem.RCollections.RGeneric.RDictionary<RType, RType>.RValueCollection.REnumerator(___result);
        }


        public virtual void CopyTo(TValue[] @array, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RMCopyTo_TValueArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Add(TValue @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Add_TValue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean System__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Remove(TValue @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Remove_TValue.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void System__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Clear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean System__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Contains(TValue @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__TValue__1____2__Contains_TValue.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.Generic.IEnumerator<TValue> System__2__Collections__2__Generic__2__IEnumerable__0__TValue__1____2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__Generic__2__IEnumerable__0__TValue__1____2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerator<TValue>)___result;
        }


        public virtual System.Collections.IEnumerator System__2__Collections__2__IEnumerable__2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void System__2__Collections__2__ICollection__2__CopyTo(System.Array @array, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RMSystem__2__Collections__2__ICollection__2__CopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
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
}