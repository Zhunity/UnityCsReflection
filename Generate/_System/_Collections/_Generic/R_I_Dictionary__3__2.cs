
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
	/// System.Collections.Generic.IDictionary`2
	/// </summary>
    public partial class RIDictionary<TKey, TValue> : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Collections.Generic.IDictionary<, >).MakeGenericType(TypeToString.GetType(typeof(TKey)), TypeToString.GetType(typeof(TValue)));
            }
        }

        public RIDictionary() : base("System.Collections.Generic.IDictionary`2")
        {
        }

        public RIDictionary(System.Object instance) : base("System.Collections.Generic.IDictionary`2")
		{
            SetInstance(instance);
		}

        public RIDictionary(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIDictionary(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// TValue Item [TKey]
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_PItem_TKey;
		public virtual Hvak.Editor.Refleaction.RProperty RPItem_TKey
		{
			get
			{
				if(r_PItem_TKey == null)
				{
					r_PItem_TKey = new(this, "Item", -1, Type.MakeGenericMethodParameter(0));
				}
				return r_PItem_TKey;
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
		/// Boolean ContainsKey(TKey)
		/// </summary>
		protected RMethod r_MContainsKey_TKey;
		public virtual RMethod RMContainsKey_TKey
		{
			get
			{
				if(r_MContainsKey_TKey == null)
				{
					r_MContainsKey_TKey = new(this, "ContainsKey", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MContainsKey_TKey;
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


        public virtual System.Boolean ContainsKey(TKey @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMContainsKey_TKey.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


    }
}
