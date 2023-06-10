
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RCompilerServices
{
	/// <summary>
	/// System.Runtime.CompilerServices.ConditionalWeakTable`2
	/// </summary>
    public partial class RConditionalWeakTable<TKey, TValue> : RMember // where TKey : class where TValue : class
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Runtime.CompilerServices.ConditionalWeakTable<, >);
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


		/// <summary>
		/// System.Int32 INITIAL_SIZE
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FINITIAL_SIZE;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFINITIAL_SIZE
		{
			get
			{
				if(r_FINITIAL_SIZE == null)
				{
					r_FINITIAL_SIZE = new(typeof(System.Runtime.CompilerServices.ConditionalWeakTable<, >), "INITIAL_SIZE");
				}
				return r_FINITIAL_SIZE;
			}
		}

		/// <summary>
		/// System.Single LOAD_FACTOR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FLOAD_FACTOR;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFLOAD_FACTOR
		{
			get
			{
				if(r_FLOAD_FACTOR == null)
				{
					r_FLOAD_FACTOR = new(typeof(System.Runtime.CompilerServices.ConditionalWeakTable<, >), "LOAD_FACTOR");
				}
				return r_FLOAD_FACTOR;
			}
		}

		/// <summary>
		/// System.Single COMPACT_FACTOR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FCOMPACT_FACTOR;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFCOMPACT_FACTOR
		{
			get
			{
				if(r_FCOMPACT_FACTOR == null)
				{
					r_FCOMPACT_FACTOR = new(typeof(System.Runtime.CompilerServices.ConditionalWeakTable<, >), "COMPACT_FACTOR");
				}
				return r_FCOMPACT_FACTOR;
			}
		}

		/// <summary>
		/// System.Single EXPAND_FACTOR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FEXPAND_FACTOR;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFEXPAND_FACTOR
		{
			get
			{
				if(r_FEXPAND_FACTOR == null)
				{
					r_FEXPAND_FACTOR = new(typeof(System.Runtime.CompilerServices.ConditionalWeakTable<, >), "EXPAND_FACTOR");
				}
				return r_FEXPAND_FACTOR;
			}
		}

		/// <summary>
		/// System.Runtime.CompilerServices.Ephemeron[] data
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RRuntime.RCompilerServices.REphemeron> r_Fdata;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RRuntime.RCompilerServices.REphemeron> RFdata
		{
			get
			{
				if(r_Fdata == null)
				{
					r_Fdata = new(this, "data");
				}
				return r_Fdata;
			}
		}

		/// <summary>
		/// System.Object _lock
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_F_lock;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RF_lock
		{
			get
			{
				if(r_F_lock == null)
				{
					r_F_lock = new(this, "_lock");
				}
				return r_F_lock;
			}
		}

		/// <summary>
		/// System.Int32 size
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fsize;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFsize
		{
			get
			{
				if(r_Fsize == null)
				{
					r_Fsize = new(this, "size");
				}
				return r_Fsize;
			}
		}

		/// <summary>
		/// System.Collections.Generic.ICollection`1[TKey] Keys
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RICollection<Hvak.Editor.Refleaction.RProperty> r_PKeys;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RICollection<Hvak.Editor.Refleaction.RProperty> RPKeys
		{
			get
			{
				if(r_PKeys == null)
				{
					r_PKeys = new(this, "Keys", -1);
				}
				return r_PKeys;
			}
		}

		/// <summary>
		/// System.Collections.Generic.ICollection`1[TValue] Values
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RICollection<Hvak.Editor.Refleaction.RProperty> r_PValues;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RICollection<Hvak.Editor.Refleaction.RProperty> RPValues
		{
			get
			{
				if(r_PValues == null)
				{
					r_PValues = new(this, "Values", -1);
				}
				return r_PValues;
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
		/// Void RehashWithoutResize()
		/// </summary>
		protected RMethod r_MRehashWithoutResize;
		public virtual RMethod RMRehashWithoutResize
		{
			get
			{
				if(r_MRehashWithoutResize == null)
				{
					r_MRehashWithoutResize = new(this, "RehashWithoutResize", 0);
				}
				return r_MRehashWithoutResize;
			}
		}

		/// <summary>
		/// Void RecomputeSize()
		/// </summary>
		protected RMethod r_MRecomputeSize;
		public virtual RMethod RMRecomputeSize
		{
			get
			{
				if(r_MRecomputeSize == null)
				{
					r_MRecomputeSize = new(this, "RecomputeSize", 0);
				}
				return r_MRecomputeSize;
			}
		}

		/// <summary>
		/// Void Rehash()
		/// </summary>
		protected RMethod r_MRehash;
		public virtual RMethod RMRehash
		{
			get
			{
				if(r_MRehash == null)
				{
					r_MRehash = new(this, "Rehash", 0);
				}
				return r_MRehash;
			}
		}

		/// <summary>
		/// Void AddOrUpdate(TKey, TValue)
		/// </summary>
		protected RMethod r_MAddOrUpdate_TKey_TValue;
		public virtual RMethod RMAddOrUpdate_TKey_TValue
		{
			get
			{
				if(r_MAddOrUpdate_TKey_TValue == null)
				{
					r_MAddOrUpdate_TKey_TValue = new(this, "AddOrUpdate", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1));
				}
				return r_MAddOrUpdate_TKey_TValue;
			}
		}

		/// <summary>
		/// Void Add(TKey, TValue)
		/// </summary>
		protected RMethod r_MAdd_TKey_TValue;
		public virtual RMethod RMAdd_TKey_TValue
		{
			get
			{
				if(r_MAdd_TKey_TValue == null)
				{
					r_MAdd_TKey_TValue = new(this, "Add", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1));
				}
				return r_MAdd_TKey_TValue;
			}
		}

		/// <summary>
		/// Boolean Remove(TKey)
		/// </summary>
		protected RMethod r_MRemove_TKey;
		public virtual RMethod RMRemove_TKey
		{
			get
			{
				if(r_MRemove_TKey == null)
				{
					r_MRemove_TKey = new(this, "Remove", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MRemove_TKey;
			}
		}

		/// <summary>
		/// Boolean TryGetValue(TKey, TValue ByRef)
		/// </summary>
		protected RMethod r_MTryGetValue_TKey_Out_TValue;
		public virtual RMethod RMTryGetValue_TKey_Out_TValue
		{
			get
			{
				if(r_MTryGetValue_TKey_Out_TValue == null)
				{
					r_MTryGetValue_TKey_Out_TValue = new(this, "TryGetValue", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1).MakeByRefType());
				}
				return r_MTryGetValue_TKey_Out_TValue;
			}
		}

		/// <summary>
		/// TValue GetOrCreateValue(TKey)
		/// </summary>
		protected RMethod r_MGetOrCreateValue_TKey;
		public virtual RMethod RMGetOrCreateValue_TKey
		{
			get
			{
				if(r_MGetOrCreateValue_TKey == null)
				{
					r_MGetOrCreateValue_TKey = new(this, "GetOrCreateValue", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MGetOrCreateValue_TKey;
			}
		}

		/// <summary>
		/// TValue GetValue(TKey, CreateValueCallback)
		/// </summary>
		protected RMethod r_MGetValue_TKey_CreateValueCallback;
		public virtual RMethod RMGetValue_TKey_CreateValueCallback
		{
			get
			{
				if(r_MGetValue_TKey_CreateValueCallback == null)
				{
					r_MGetValue_TKey_CreateValueCallback = new(this, "GetValue", 0, Type.MakeGenericMethodParameter(0),  ReflectionUtils.GetType("System.Runtime.CompilerServices.ConditionalWeakTable`2+CreateValueCallback").MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)));
				}
				return r_MGetValue_TKey_CreateValueCallback;
			}
		}

		/// <summary>
		/// TKey FindEquivalentKeyUnsafe(TKey, TValue ByRef)
		/// </summary>
		protected RMethod r_MFindEquivalentKeyUnsafe_TKey_Out_TValue;
		public virtual RMethod RMFindEquivalentKeyUnsafe_TKey_Out_TValue
		{
			get
			{
				if(r_MFindEquivalentKeyUnsafe_TKey_Out_TValue == null)
				{
					r_MFindEquivalentKeyUnsafe_TKey_Out_TValue = new(this, "FindEquivalentKeyUnsafe", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1).MakeByRefType());
				}
				return r_MFindEquivalentKeyUnsafe_TKey_Out_TValue;
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
		/// System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[TKey,TValue]] System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__GetEnumerator;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__GetEnumerator
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__GetEnumerator == null)
				{
					r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__GetEnumerator = new(this, "System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator", 0);
				}
				return r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__GetEnumerator;
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


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RehashWithoutResize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRehashWithoutResize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecomputeSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRecomputeSize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Rehash()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRehash.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddOrUpdate(TKey @key, TValue @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RMAddOrUpdate_TKey_TValue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Add(TKey @key, TValue @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RMAdd_TKey_TValue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Remove(TKey @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMRemove_TKey.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetValue(TKey @key, out TValue @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RMTryGetValue_TKey_Out_TValue.Invoke(___genericsType, ___parameters);
			@value = (TValue)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual TValue GetOrCreateValue(TKey @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMGetOrCreateValue_TKey.Invoke(___genericsType, ___parameters);

            return (TValue)___result;
        }


        public virtual TValue GetValue(TKey @key, Hvak.Editor.Refleaction.RSystem.RRuntime.RCompilerServices.RConditionalWeakTable<Hvak.Editor.Refleaction.RType, Hvak.Editor.Refleaction.RType>.RCreateValueCallback @createValueCallback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @createValueCallback.Value};
            var ___result = RMGetValue_TKey_CreateValueCallback.Invoke(___genericsType, ___parameters);

            return (TValue)___result;
        }


        public virtual TKey FindEquivalentKeyUnsafe(TKey @key, out TValue @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RMFindEquivalentKeyUnsafe_TKey_Out_TValue.Invoke(___genericsType, ___parameters);
			@value = (TValue)___parameters[1];

            return (TKey)___result;
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System__2__Collections__2__Generic__2__IEnumerable__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Collections__2__Generic__2__KeyValuePair__0__TKey__4__TValue__1____1____2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>)___result;
        }


        public virtual System.Collections.IEnumerator System__2__Collections__2__IEnumerable__2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
