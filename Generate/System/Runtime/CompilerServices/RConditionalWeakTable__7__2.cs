using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RCompilerServices
{
	/// <summary>
	/// System.Runtime.CompilerServices.ConditionalWeakTable`2
	/// </summary>
    public partial class RConditionalWeakTable<TKey, TValue> : RMember // where TKey : class where TValue : class
    {

		/// <summary>
		/// System.Int32 INITIAL_SIZE
		/// </summary>
		protected static RField r_INITIAL_SIZE;
		public static RField RINITIAL_SIZE
		{
			get
			{
				if(r_INITIAL_SIZE == null)
				{
					r_INITIAL_SIZE = new(typeof(System.Runtime.CompilerServices.ConditionalWeakTable<, >), "INITIAL_SIZE");
					r_INITIAL_SIZE.SetBelong(null);
				}
				return r_INITIAL_SIZE;
			}
		}

		/// <summary>
		/// System.Single LOAD_FACTOR
		/// </summary>
		protected static RField r_LOAD_FACTOR;
		public static RField RLOAD_FACTOR
		{
			get
			{
				if(r_LOAD_FACTOR == null)
				{
					r_LOAD_FACTOR = new(typeof(System.Runtime.CompilerServices.ConditionalWeakTable<, >), "LOAD_FACTOR");
					r_LOAD_FACTOR.SetBelong(null);
				}
				return r_LOAD_FACTOR;
			}
		}

		/// <summary>
		/// System.Single COMPACT_FACTOR
		/// </summary>
		protected static RField r_COMPACT_FACTOR;
		public static RField RCOMPACT_FACTOR
		{
			get
			{
				if(r_COMPACT_FACTOR == null)
				{
					r_COMPACT_FACTOR = new(typeof(System.Runtime.CompilerServices.ConditionalWeakTable<, >), "COMPACT_FACTOR");
					r_COMPACT_FACTOR.SetBelong(null);
				}
				return r_COMPACT_FACTOR;
			}
		}

		/// <summary>
		/// System.Single EXPAND_FACTOR
		/// </summary>
		protected static RField r_EXPAND_FACTOR;
		public static RField REXPAND_FACTOR
		{
			get
			{
				if(r_EXPAND_FACTOR == null)
				{
					r_EXPAND_FACTOR = new(typeof(System.Runtime.CompilerServices.ConditionalWeakTable<, >), "EXPAND_FACTOR");
					r_EXPAND_FACTOR.SetBelong(null);
				}
				return r_EXPAND_FACTOR;
			}
		}

		/// <summary>
		/// System.Runtime.CompilerServices.Ephemeron[] data
		/// </summary>
		protected RFieldArray<RSystem.RRuntime.RCompilerServices.REphemeron> r_data;
		public virtual RFieldArray<RSystem.RRuntime.RCompilerServices.REphemeron> Rdata
		{
			get
			{
				if(r_data == null)
				{
					r_data = new(this, "data");
					r_data.SetBelong(this.instance);
				}
				return r_data;
			}
		}

		/// <summary>
		/// System.Object _lock
		/// </summary>
		protected RSystem.RObject r__lock;
		public virtual RSystem.RObject R_lock
		{
			get
			{
				if(r__lock == null)
				{
					r__lock = new(this, "_lock");
					r__lock.SetBelong(this.instance);
				}
				return r__lock;
			}
		}

		/// <summary>
		/// System.Int32 size
		/// </summary>
		protected RField r_size;
		public virtual RField Rsize
		{
			get
			{
				if(r_size == null)
				{
					r_size = new(this, "size");
					r_size.SetBelong(this.instance);
				}
				return r_size;
			}
		}

		/// <summary>
		/// System.Collections.Generic.ICollection`1[TKey] Keys
		/// </summary>
		protected RSystem.RCollections.RGeneric.RICollection<RProperty> r_Keys;
		public virtual RSystem.RCollections.RGeneric.RICollection<RProperty> RKeys
		{
			get
			{
				if(r_Keys == null)
				{
					r_Keys = new(this, "Keys", -1);
					r_Keys.SetBelong(this.instance);
				}
				return r_Keys;
			}
		}

		/// <summary>
		/// System.Collections.Generic.ICollection`1[TValue] Values
		/// </summary>
		protected RSystem.RCollections.RGeneric.RICollection<RProperty> r_Values;
		public virtual RSystem.RCollections.RGeneric.RICollection<RProperty> RValues
		{
			get
			{
				if(r_Values == null)
				{
					r_Values = new(this, "Values", -1);
					r_Values.SetBelong(this.instance);
				}
				return r_Values;
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
		/// Void RehashWithoutResize()
		/// </summary>
		protected RMethod r_RRehashWithoutResize;
		public virtual RMethod RRehashWithoutResize
		{
			get
			{
				if(r_RRehashWithoutResize == null)
				{
					r_RRehashWithoutResize = new(this, "RehashWithoutResize", 0);
					r_RRehashWithoutResize.SetBelong(this.instance);
				}
				return r_RRehashWithoutResize;
			}
		}

		/// <summary>
		/// Void RecomputeSize()
		/// </summary>
		protected RMethod r_RRecomputeSize;
		public virtual RMethod RRecomputeSize
		{
			get
			{
				if(r_RRecomputeSize == null)
				{
					r_RRecomputeSize = new(this, "RecomputeSize", 0);
					r_RRecomputeSize.SetBelong(this.instance);
				}
				return r_RRecomputeSize;
			}
		}

		/// <summary>
		/// Void Rehash()
		/// </summary>
		protected RMethod r_RRehash;
		public virtual RMethod RRehash
		{
			get
			{
				if(r_RRehash == null)
				{
					r_RRehash = new(this, "Rehash", 0);
					r_RRehash.SetBelong(this.instance);
				}
				return r_RRehash;
			}
		}

		/// <summary>
		/// Void AddOrUpdate(TKey, TValue)
		/// </summary>
		protected RMethod r_RAddOrUpdate_TKey_TValue;
		public virtual RMethod RAddOrUpdate_TKey_TValue
		{
			get
			{
				if(r_RAddOrUpdate_TKey_TValue == null)
				{
					r_RAddOrUpdate_TKey_TValue = new(this, "AddOrUpdate", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1));
					r_RAddOrUpdate_TKey_TValue.SetBelong(this.instance);
				}
				return r_RAddOrUpdate_TKey_TValue;
			}
		}

		/// <summary>
		/// Void Add(TKey, TValue)
		/// </summary>
		protected RMethod r_RAdd_TKey_TValue;
		public virtual RMethod RAdd_TKey_TValue
		{
			get
			{
				if(r_RAdd_TKey_TValue == null)
				{
					r_RAdd_TKey_TValue = new(this, "Add", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1));
					r_RAdd_TKey_TValue.SetBelong(this.instance);
				}
				return r_RAdd_TKey_TValue;
			}
		}

		/// <summary>
		/// Boolean Remove(TKey)
		/// </summary>
		protected RMethod r_RRemove_TKey;
		public virtual RMethod RRemove_TKey
		{
			get
			{
				if(r_RRemove_TKey == null)
				{
					r_RRemove_TKey = new(this, "Remove", 0, Type.MakeGenericMethodParameter(0));
					r_RRemove_TKey.SetBelong(this.instance);
				}
				return r_RRemove_TKey;
			}
		}

		/// <summary>
		/// Boolean TryGetValue(TKey, TValue ByRef)
		/// </summary>
		protected RMethod r_RTryGetValue_TKey_Out_TValue;
		public virtual RMethod RTryGetValue_TKey_Out_TValue
		{
			get
			{
				if(r_RTryGetValue_TKey_Out_TValue == null)
				{
					r_RTryGetValue_TKey_Out_TValue = new(this, "TryGetValue", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1).MakeByRefType());
					r_RTryGetValue_TKey_Out_TValue.SetBelong(this.instance);
				}
				return r_RTryGetValue_TKey_Out_TValue;
			}
		}

		/// <summary>
		/// TValue GetOrCreateValue(TKey)
		/// </summary>
		protected RMethod r_RGetOrCreateValue_TKey;
		public virtual RMethod RGetOrCreateValue_TKey
		{
			get
			{
				if(r_RGetOrCreateValue_TKey == null)
				{
					r_RGetOrCreateValue_TKey = new(this, "GetOrCreateValue", 0, Type.MakeGenericMethodParameter(0));
					r_RGetOrCreateValue_TKey.SetBelong(this.instance);
				}
				return r_RGetOrCreateValue_TKey;
			}
		}

		/// <summary>
		/// TValue GetValue(TKey, CreateValueCallback)
		/// </summary>
		protected RMethod r_RGetValue_TKey_CreateValueCallback;
		public virtual RMethod RGetValue_TKey_CreateValueCallback
		{
			get
			{
				if(r_RGetValue_TKey_CreateValueCallback == null)
				{
					r_RGetValue_TKey_CreateValueCallback = new(this, "GetValue", 0, Type.MakeGenericMethodParameter(0),  ReleactionUtils.GetType("System.Runtime.CompilerServices.ConditionalWeakTable`2+CreateValueCallback").MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)));
					r_RGetValue_TKey_CreateValueCallback.SetBelong(this.instance);
				}
				return r_RGetValue_TKey_CreateValueCallback;
			}
		}

		/// <summary>
		/// TKey FindEquivalentKeyUnsafe(TKey, TValue ByRef)
		/// </summary>
		protected RMethod r_RFindEquivalentKeyUnsafe_TKey_Out_TValue;
		public virtual RMethod RFindEquivalentKeyUnsafe_TKey_Out_TValue
		{
			get
			{
				if(r_RFindEquivalentKeyUnsafe_TKey_Out_TValue == null)
				{
					r_RFindEquivalentKeyUnsafe_TKey_Out_TValue = new(this, "FindEquivalentKeyUnsafe", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1).MakeByRefType());
					r_RFindEquivalentKeyUnsafe_TKey_Out_TValue.SetBelong(this.instance);
				}
				return r_RFindEquivalentKeyUnsafe_TKey_Out_TValue;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_RClear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_RClear == null)
				{
					r_RClear = new(this, "Clear", 0);
					r_RClear.SetBelong(this.instance);
				}
				return r_RClear;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[TKey,TValue]] System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator()
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__IEnumerable__1__System__0__Collections__0__Generic__0__KeyValuePair__1__TKey__4__TValue__2____2____0__GetEnumerator;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__IEnumerable__1__System__0__Collections__0__Generic__0__KeyValuePair__1__TKey__4__TValue__2____2____0__GetEnumerator
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__IEnumerable__1__System__0__Collections__0__Generic__0__KeyValuePair__1__TKey__4__TValue__2____2____0__GetEnumerator == null)
				{
					r_RSystem__0__Collections__0__Generic__0__IEnumerable__1__System__0__Collections__0__Generic__0__KeyValuePair__1__TKey__4__TValue__2____2____0__GetEnumerator = new(this, "System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator", 0);
					r_RSystem__0__Collections__0__Generic__0__IEnumerable__1__System__0__Collections__0__Generic__0__KeyValuePair__1__TKey__4__TValue__2____2____0__GetEnumerator.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__IEnumerable__1__System__0__Collections__0__Generic__0__KeyValuePair__1__TKey__4__TValue__2____2____0__GetEnumerator;
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


        public RConditionalWeakTable() : base("System.Runtime.CompilerServices.ConditionalWeakTable`2")
        {
        }

        public RConditionalWeakTable(System.Object instance) : base("System.Runtime.CompilerServices.ConditionalWeakTable`2")
		{
            SetInstance(instance);
		}

        public RConditionalWeakTable(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RConditionalWeakTable(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RehashWithoutResize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRehashWithoutResize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecomputeSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRecomputeSize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Rehash()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRehash.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddOrUpdate(TKey  @key, TValue  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RAddOrUpdate_TKey_TValue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Add(TKey  @key, TValue  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RAdd_TKey_TValue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Remove(TKey  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RRemove_TKey.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetValue(TKey  @key, out TValue  @value)
        {
			value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RTryGetValue_TKey_Out_TValue.Invoke(___genericsType, ___parameters);
			value = (TValue)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual TValue GetOrCreateValue(TKey  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RGetOrCreateValue_TKey.Invoke(___genericsType, ___parameters);

            return (TValue)___result;
        }



        public virtual TKey FindEquivalentKeyUnsafe(TKey  @key, out TValue  @value)
        {
			value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RFindEquivalentKeyUnsafe_TKey_Out_TValue.Invoke(___genericsType, ___parameters);
			value = (TValue)___parameters[1];

            return (TKey)___result;
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System__0__Collections__0__Generic__0__IEnumerable__1__System__0__Collections__0__Generic__0__KeyValuePair__1__TKey__4__TValue__2____2____0__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__0__Collections__0__Generic__0__IEnumerable__1__System__0__Collections__0__Generic__0__KeyValuePair__1__TKey__4__TValue__2____2____0__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>)___result;
        }


        public virtual System.Collections.IEnumerator System__0__Collections__0__IEnumerable__0__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__0__Collections__0__IEnumerable__0__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
