
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
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<SMFrame.Editor.Refleaction.RField, SMFrame.Editor.Refleaction.RField> r_F_dictionary;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<SMFrame.Editor.Refleaction.RField, SMFrame.Editor.Refleaction.RField> RF_dictionary
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
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPCount
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
		/// Boolean System.Collections.Generic.ICollection<TKey>.IsReadOnly
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__IsReadOnly;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__IsReadOnly
		{
			get
			{
				if(r_PSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__IsReadOnly == null)
				{
					r_PSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__IsReadOnly = new(this, "System.Collections.Generic.ICollection<TKey>.IsReadOnly", -1);
					r_PSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__IsReadOnly.SetBelong(this.instance);
				}
				return r_PSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__IsReadOnly;
			}
		}

		/// <summary>
		/// Boolean System.Collections.ICollection.IsSynchronized
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PSystem__2__Collections__2__ICollection__2__IsSynchronized;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPSystem__2__Collections__2__ICollection__2__IsSynchronized
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
		protected SMFrame.Editor.Refleaction.RSystem.RObject r_PSystem__2__Collections__2__ICollection__2__SyncRoot;
		public virtual SMFrame.Editor.Refleaction.RSystem.RObject RPSystem__2__Collections__2__ICollection__2__SyncRoot
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
		/// Void CopyTo(TKey[], Int32)
		/// </summary>
		protected RMethod r_MCopyTo_TKeyArray_Int32;
		public virtual RMethod RMCopyTo_TKeyArray_Int32
		{
			get
			{
				if(r_MCopyTo_TKeyArray_Int32 == null)
				{
					r_MCopyTo_TKeyArray_Int32 = new(this, "CopyTo", 0, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32));
					r_MCopyTo_TKeyArray_Int32.SetBelong(this.instance);
				}
				return r_MCopyTo_TKeyArray_Int32;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.ICollection<TKey>.Add(TKey)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Add_TKey;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Add_TKey
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Add_TKey == null)
				{
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Add_TKey = new(this, "System.Collections.Generic.ICollection<TKey>.Add", 0, Type.MakeGenericMethodParameter(0));
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Add_TKey.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Add_TKey;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.ICollection<TKey>.Clear()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Clear;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Clear
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Clear == null)
				{
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Clear = new(this, "System.Collections.Generic.ICollection<TKey>.Clear", 0);
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Clear.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Clear;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<TKey>.Contains(TKey)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Contains_TKey;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Contains_TKey
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Contains_TKey == null)
				{
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Contains_TKey = new(this, "System.Collections.Generic.ICollection<TKey>.Contains", 0, Type.MakeGenericMethodParameter(0));
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Contains_TKey.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Contains_TKey;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<TKey>.Remove(TKey)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Remove_TKey;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Remove_TKey
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Remove_TKey == null)
				{
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Remove_TKey = new(this, "System.Collections.Generic.ICollection<TKey>.Remove", 0, Type.MakeGenericMethodParameter(0));
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Remove_TKey.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Remove_TKey;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerator`1[TKey] System.Collections.Generic.IEnumerable<TKey>.GetEnumerator()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__TKey__1____2__GetEnumerator;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__IEnumerable__0__TKey__1____2__GetEnumerator
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__TKey__1____2__GetEnumerator == null)
				{
					r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__TKey__1____2__GetEnumerator = new(this, "System.Collections.Generic.IEnumerable<TKey>.GetEnumerator", 0);
					r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__TKey__1____2__GetEnumerator.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__TKey__1____2__GetEnumerator;
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

        public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<SMFrame.Editor.Refleaction.RType, SMFrame.Editor.Refleaction.RType>.RKeyCollection.REnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<SMFrame.Editor.Refleaction.RType, SMFrame.Editor.Refleaction.RType>.RKeyCollection.REnumerator(___result);
        }


        public virtual void CopyTo(TKey[] @array, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RMCopyTo_TKeyArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Add(TKey @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Add_TKey.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Clear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean System__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Contains(TKey @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Contains_TKey.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean System__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Remove(TKey @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__TKey__1____2__Remove_TKey.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.Generic.IEnumerator<TKey> System__2__Collections__2__Generic__2__IEnumerable__0__TKey__1____2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__Generic__2__IEnumerable__0__TKey__1____2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerator<TKey>)___result;
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