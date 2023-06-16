
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Collections.IDictionary
	/// </summary>
    public partial class RIDictionary : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Collections.IDictionary);
            }
        }

        public RIDictionary() : base("System.Collections.IDictionary")
        {
        }

        public RIDictionary(System.Object instance) : base("System.Collections.IDictionary")
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
		/// System.Object Item [System.Object]
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PItem_Object;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPItem_Object
		{
			get
			{
				if(r_PItem_Object == null)
				{
					r_PItem_Object = new(this, "Item", -1, typeof(System.Object));
				}
				return r_PItem_Object;
			}
		}

		/// <summary>
		/// System.Collections.ICollection Keys
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RICollection r_PKeys;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RICollection RPKeys
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
		/// System.Collections.ICollection Values
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RICollection r_PValues;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RICollection RPValues
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
		/// Boolean IsReadOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsReadOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsReadOnly
		{
			get
			{
				if(r_PIsReadOnly == null)
				{
					r_PIsReadOnly = new(this, "IsReadOnly", -1);
				}
				return r_PIsReadOnly;
			}
		}

		/// <summary>
		/// Boolean IsFixedSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsFixedSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsFixedSize
		{
			get
			{
				if(r_PIsFixedSize == null)
				{
					r_PIsFixedSize = new(this, "IsFixedSize", -1);
				}
				return r_PIsFixedSize;
			}
		}

		/// <summary>
		/// Boolean Contains(System.Object)
		/// </summary>
		protected RMethod r_MContains_Object;
		public virtual RMethod RMContains_Object
		{
			get
			{
				if(r_MContains_Object == null)
				{
					r_MContains_Object = new(this, "Contains", 0, typeof(System.Object));
				}
				return r_MContains_Object;
			}
		}

		/// <summary>
		/// Void Add(System.Object, System.Object)
		/// </summary>
		protected RMethod r_MAdd_Object_Object;
		public virtual RMethod RMAdd_Object_Object
		{
			get
			{
				if(r_MAdd_Object_Object == null)
				{
					r_MAdd_Object_Object = new(this, "Add", 0, typeof(System.Object), typeof(System.Object));
				}
				return r_MAdd_Object_Object;
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
		/// System.Collections.IDictionaryEnumerator GetEnumerator()
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
		/// Void Remove(System.Object)
		/// </summary>
		protected RMethod r_MRemove_Object;
		public virtual RMethod RMRemove_Object
		{
			get
			{
				if(r_MRemove_Object == null)
				{
					r_MRemove_Object = new(this, "Remove", 0, typeof(System.Object));
				}
				return r_MRemove_Object;
			}
		}


        public virtual System.Boolean Contains(System.Object @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMContains_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Add(System.Object @key, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RMAdd_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IDictionaryEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.IDictionaryEnumerator>(___result);
        }


        public virtual void Remove(System.Object @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMRemove_Object.Invoke(___genericsType, ___parameters);

            
        }


    }
}
