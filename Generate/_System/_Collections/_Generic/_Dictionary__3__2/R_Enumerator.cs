
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric
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
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RField, Hvak.Editor.Refleaction.RField> r_F_dictionary;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RField, Hvak.Editor.Refleaction.RField> RF_dictionary
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
					r_F_version.SetBelong(this.instance);
				}
				return r_F_version;
			}
		}

		/// <summary>
		/// System.Int32 _index
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_index;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_index
		{
			get
			{
				if(r_F_index == null)
				{
					r_F_index = new(this, "_index");
					r_F_index.SetBelong(this.instance);
				}
				return r_F_index;
			}
		}

		/// <summary>
		/// System.Collections.Generic.KeyValuePair`2[TKey,TValue] _current
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RKeyValuePair<Hvak.Editor.Refleaction.RField, Hvak.Editor.Refleaction.RField> r_F_current;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RKeyValuePair<Hvak.Editor.Refleaction.RField, Hvak.Editor.Refleaction.RField> RF_current
		{
			get
			{
				if(r_F_current == null)
				{
					r_F_current = new(this, "_current");
					r_F_current.SetBelong(this.instance);
				}
				return r_F_current;
			}
		}

		/// <summary>
		/// System.Int32 _getEnumeratorRetType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_getEnumeratorRetType;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_getEnumeratorRetType
		{
			get
			{
				if(r_F_getEnumeratorRetType == null)
				{
					r_F_getEnumeratorRetType = new(this, "_getEnumeratorRetType");
					r_F_getEnumeratorRetType.SetBelong(this.instance);
				}
				return r_F_getEnumeratorRetType;
			}
		}

		/// <summary>
		/// System.Int32 DictEntry
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FDictEntry;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFDictEntry
		{
			get
			{
				if(r_FDictEntry == null)
				{
					r_FDictEntry = new( ReflectionUtils.GetType("System.Collections.Generic.Dictionary`2+Enumerator"), "DictEntry");
					r_FDictEntry.SetBelong(null);
				}
				return r_FDictEntry;
			}
		}

		/// <summary>
		/// System.Int32 KeyValuePair
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FKeyValuePair;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFKeyValuePair
		{
			get
			{
				if(r_FKeyValuePair == null)
				{
					r_FKeyValuePair = new( ReflectionUtils.GetType("System.Collections.Generic.Dictionary`2+Enumerator"), "KeyValuePair");
					r_FKeyValuePair.SetBelong(null);
				}
				return r_FKeyValuePair;
			}
		}

		/// <summary>
		/// System.Collections.Generic.KeyValuePair`2[TKey,TValue] Current
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RKeyValuePair<Hvak.Editor.Refleaction.RProperty, Hvak.Editor.Refleaction.RProperty> r_PCurrent;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RKeyValuePair<Hvak.Editor.Refleaction.RProperty, Hvak.Editor.Refleaction.RProperty> RPCurrent
		{
			get
			{
				if(r_PCurrent == null)
				{
					r_PCurrent = new(this, "Current", -1);
					r_PCurrent.SetBelong(this.instance);
				}
				return r_PCurrent;
			}
		}

		/// <summary>
		/// System.Object System.Collections.IEnumerator.Current
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PSystem__2__Collections__2__IEnumerator__2__Current;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPSystem__2__Collections__2__IEnumerator__2__Current
		{
			get
			{
				if(r_PSystem__2__Collections__2__IEnumerator__2__Current == null)
				{
					r_PSystem__2__Collections__2__IEnumerator__2__Current = new(this, "System.Collections.IEnumerator.Current", -1);
					r_PSystem__2__Collections__2__IEnumerator__2__Current.SetBelong(this.instance);
				}
				return r_PSystem__2__Collections__2__IEnumerator__2__Current;
			}
		}

		/// <summary>
		/// System.Collections.DictionaryEntry System.Collections.IDictionaryEnumerator.Entry
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RDictionaryEntry r_PSystem__2__Collections__2__IDictionaryEnumerator__2__Entry;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RDictionaryEntry RPSystem__2__Collections__2__IDictionaryEnumerator__2__Entry
		{
			get
			{
				if(r_PSystem__2__Collections__2__IDictionaryEnumerator__2__Entry == null)
				{
					r_PSystem__2__Collections__2__IDictionaryEnumerator__2__Entry = new(this, "System.Collections.IDictionaryEnumerator.Entry", -1);
					r_PSystem__2__Collections__2__IDictionaryEnumerator__2__Entry.SetBelong(this.instance);
				}
				return r_PSystem__2__Collections__2__IDictionaryEnumerator__2__Entry;
			}
		}

		/// <summary>
		/// System.Object System.Collections.IDictionaryEnumerator.Key
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PSystem__2__Collections__2__IDictionaryEnumerator__2__Key;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPSystem__2__Collections__2__IDictionaryEnumerator__2__Key
		{
			get
			{
				if(r_PSystem__2__Collections__2__IDictionaryEnumerator__2__Key == null)
				{
					r_PSystem__2__Collections__2__IDictionaryEnumerator__2__Key = new(this, "System.Collections.IDictionaryEnumerator.Key", -1);
					r_PSystem__2__Collections__2__IDictionaryEnumerator__2__Key.SetBelong(this.instance);
				}
				return r_PSystem__2__Collections__2__IDictionaryEnumerator__2__Key;
			}
		}

		/// <summary>
		/// System.Object System.Collections.IDictionaryEnumerator.Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PSystem__2__Collections__2__IDictionaryEnumerator__2__Value;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPSystem__2__Collections__2__IDictionaryEnumerator__2__Value
		{
			get
			{
				if(r_PSystem__2__Collections__2__IDictionaryEnumerator__2__Value == null)
				{
					r_PSystem__2__Collections__2__IDictionaryEnumerator__2__Value = new(this, "System.Collections.IDictionaryEnumerator.Value", -1);
					r_PSystem__2__Collections__2__IDictionaryEnumerator__2__Value.SetBelong(this.instance);
				}
				return r_PSystem__2__Collections__2__IDictionaryEnumerator__2__Value;
			}
		}

		/// <summary>
		/// Boolean MoveNext()
		/// </summary>
		protected RMethod r_MMoveNext;
		public virtual RMethod RMMoveNext
		{
			get
			{
				if(r_MMoveNext == null)
				{
					r_MMoveNext = new(this, "MoveNext", 0);
					r_MMoveNext.SetBelong(this.instance);
				}
				return r_MMoveNext;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
					r_MDispose.SetBelong(this.instance);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void System.Collections.IEnumerator.Reset()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IEnumerator__2__Reset;
		public virtual RMethod RMSystem__2__Collections__2__IEnumerator__2__Reset
		{
			get
			{
				if(r_MSystem__2__Collections__2__IEnumerator__2__Reset == null)
				{
					r_MSystem__2__Collections__2__IEnumerator__2__Reset = new(this, "System.Collections.IEnumerator.Reset", 0);
					r_MSystem__2__Collections__2__IEnumerator__2__Reset.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__IEnumerator__2__Reset;
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
            var ___result = RMMoveNext.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__IEnumerator__2__Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__IEnumerator__2__Reset.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
}