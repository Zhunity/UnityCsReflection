using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric
{public partial class RDictionary<TKey, TValue>
{
	
	/// <summary>
	/// System.Collections.Generic.Dictionary`2+Enumerator
	/// </summary>
    public partial class REnumerator : RMember //
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
		/// System.Int32 _version
		/// </summary>
		protected RSystem.RInt32 r__version;
		public virtual RSystem.RInt32 R_version
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
		/// System.Int32 _index
		/// </summary>
		protected RSystem.RInt32 r__index;
		public virtual RSystem.RInt32 R_index
		{
			get
			{
				if(r__index == null)
				{
					r__index = new(this, "_index");
					r__index.SetBelong(this.instance);
				}
				return r__index;
			}
		}

		/// <summary>
		/// System.Collections.Generic.KeyValuePair`2[TKey,TValue] _current
		/// </summary>
		protected RSystem.RCollections.RGeneric.RKeyValuePair<RField, RField> r__current;
		public virtual RSystem.RCollections.RGeneric.RKeyValuePair<RField, RField> R_current
		{
			get
			{
				if(r__current == null)
				{
					r__current = new(this, "_current");
					r__current.SetBelong(this.instance);
				}
				return r__current;
			}
		}

		/// <summary>
		/// System.Int32 _getEnumeratorRetType
		/// </summary>
		protected RSystem.RInt32 r__getEnumeratorRetType;
		public virtual RSystem.RInt32 R_getEnumeratorRetType
		{
			get
			{
				if(r__getEnumeratorRetType == null)
				{
					r__getEnumeratorRetType = new(this, "_getEnumeratorRetType");
					r__getEnumeratorRetType.SetBelong(this.instance);
				}
				return r__getEnumeratorRetType;
			}
		}

		/// <summary>
		/// System.Int32 DictEntry
		/// </summary>
		protected static RSystem.RInt32 r_DictEntry;
		public static RSystem.RInt32 RDictEntry
		{
			get
			{
				if(r_DictEntry == null)
				{
					r_DictEntry = new( ReflectionUtils.GetType("System.Collections.Generic.Dictionary`2+Enumerator"), "DictEntry");
					r_DictEntry.SetBelong(null);
				}
				return r_DictEntry;
			}
		}

		/// <summary>
		/// System.Int32 KeyValuePair
		/// </summary>
		protected static RSystem.RInt32 r_KeyValuePair;
		public static RSystem.RInt32 RKeyValuePair
		{
			get
			{
				if(r_KeyValuePair == null)
				{
					r_KeyValuePair = new( ReflectionUtils.GetType("System.Collections.Generic.Dictionary`2+Enumerator"), "KeyValuePair");
					r_KeyValuePair.SetBelong(null);
				}
				return r_KeyValuePair;
			}
		}

		/// <summary>
		/// System.Collections.Generic.KeyValuePair`2[TKey,TValue] Current
		/// </summary>
		protected RSystem.RCollections.RGeneric.RKeyValuePair<RProperty, RProperty> r_Current;
		public virtual RSystem.RCollections.RGeneric.RKeyValuePair<RProperty, RProperty> RCurrent
		{
			get
			{
				if(r_Current == null)
				{
					r_Current = new(this, "Current", -1);
					r_Current.SetBelong(this.instance);
				}
				return r_Current;
			}
		}

		/// <summary>
		/// System.Object System.Collections.IEnumerator.Current
		/// </summary>
		protected RSystem.RObject r_System__2__Collections__2__IEnumerator__2__Current;
		public virtual RSystem.RObject RSystem__2__Collections__2__IEnumerator__2__Current
		{
			get
			{
				if(r_System__2__Collections__2__IEnumerator__2__Current == null)
				{
					r_System__2__Collections__2__IEnumerator__2__Current = new(this, "System.Collections.IEnumerator.Current", -1);
					r_System__2__Collections__2__IEnumerator__2__Current.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IEnumerator__2__Current;
			}
		}

		/// <summary>
		/// System.Collections.DictionaryEntry System.Collections.IDictionaryEnumerator.Entry
		/// </summary>
		protected RSystem.RCollections.RDictionaryEntry r_System__2__Collections__2__IDictionaryEnumerator__2__Entry;
		public virtual RSystem.RCollections.RDictionaryEntry RSystem__2__Collections__2__IDictionaryEnumerator__2__Entry
		{
			get
			{
				if(r_System__2__Collections__2__IDictionaryEnumerator__2__Entry == null)
				{
					r_System__2__Collections__2__IDictionaryEnumerator__2__Entry = new(this, "System.Collections.IDictionaryEnumerator.Entry", -1);
					r_System__2__Collections__2__IDictionaryEnumerator__2__Entry.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IDictionaryEnumerator__2__Entry;
			}
		}

		/// <summary>
		/// System.Object System.Collections.IDictionaryEnumerator.Key
		/// </summary>
		protected RSystem.RObject r_System__2__Collections__2__IDictionaryEnumerator__2__Key;
		public virtual RSystem.RObject RSystem__2__Collections__2__IDictionaryEnumerator__2__Key
		{
			get
			{
				if(r_System__2__Collections__2__IDictionaryEnumerator__2__Key == null)
				{
					r_System__2__Collections__2__IDictionaryEnumerator__2__Key = new(this, "System.Collections.IDictionaryEnumerator.Key", -1);
					r_System__2__Collections__2__IDictionaryEnumerator__2__Key.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IDictionaryEnumerator__2__Key;
			}
		}

		/// <summary>
		/// System.Object System.Collections.IDictionaryEnumerator.Value
		/// </summary>
		protected RSystem.RObject r_System__2__Collections__2__IDictionaryEnumerator__2__Value;
		public virtual RSystem.RObject RSystem__2__Collections__2__IDictionaryEnumerator__2__Value
		{
			get
			{
				if(r_System__2__Collections__2__IDictionaryEnumerator__2__Value == null)
				{
					r_System__2__Collections__2__IDictionaryEnumerator__2__Value = new(this, "System.Collections.IDictionaryEnumerator.Value", -1);
					r_System__2__Collections__2__IDictionaryEnumerator__2__Value.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IDictionaryEnumerator__2__Value;
			}
		}

		/// <summary>
		/// Boolean MoveNext()
		/// </summary>
		protected RMethod r_MoveNext;
		public virtual RMethod RMoveNext
		{
			get
			{
				if(r_MoveNext == null)
				{
					r_MoveNext = new(this, "MoveNext", 0);
					r_MoveNext.SetBelong(this.instance);
				}
				return r_MoveNext;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_Dispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_Dispose == null)
				{
					r_Dispose = new(this, "Dispose", 0);
					r_Dispose.SetBelong(this.instance);
				}
				return r_Dispose;
			}
		}

		/// <summary>
		/// Void System.Collections.IEnumerator.Reset()
		/// </summary>
		protected RMethod r_System__2__Collections__2__IEnumerator__2__Reset;
		public virtual RMethod RSystem__2__Collections__2__IEnumerator__2__Reset
		{
			get
			{
				if(r_System__2__Collections__2__IEnumerator__2__Reset == null)
				{
					r_System__2__Collections__2__IEnumerator__2__Reset = new(this, "System.Collections.IEnumerator.Reset", 0);
					r_System__2__Collections__2__IEnumerator__2__Reset.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IEnumerator__2__Reset;
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


        public REnumerator() : base("System.Collections.Generic.Dictionary`2+Enumerator")
        {
        }

        public REnumerator(System.Object instance) : base("System.Collections.Generic.Dictionary`2+Enumerator")
		{
            SetInstance(instance);
		}

        public REnumerator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REnumerator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean MoveNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveNext.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__IEnumerator__2__Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__2__Collections__2__IEnumerator__2__Reset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
}