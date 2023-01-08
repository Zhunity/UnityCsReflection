using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections
{
	/// <summary>
	/// System.Collections.IDictionary
	/// </summary>
    public partial class RIDictionary : RMember //
    {

		/// <summary>
		/// System.Object Item [System.Object]
		/// </summary>
		protected RSystem.RObject r_Item_Object;
		public virtual RSystem.RObject RItem_Object
		{
			get
			{
				if(r_Item_Object == null)
				{
					r_Item_Object = new(this, "Item", -1, typeof(System.Object));
					r_Item_Object.SetBelong(this.instance);
				}
				return r_Item_Object;
			}
		}

		/// <summary>
		/// System.Collections.ICollection Keys
		/// </summary>
		protected RSystem.RCollections.RICollection r_Keys;
		public virtual RSystem.RCollections.RICollection RKeys
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
		/// System.Collections.ICollection Values
		/// </summary>
		protected RSystem.RCollections.RICollection r_Values;
		public virtual RSystem.RCollections.RICollection RValues
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
		/// Boolean IsReadOnly
		/// </summary>
		protected RProperty r_IsReadOnly;
		public virtual RProperty RIsReadOnly
		{
			get
			{
				if(r_IsReadOnly == null)
				{
					r_IsReadOnly = new(this, "IsReadOnly", -1);
					r_IsReadOnly.SetBelong(this.instance);
				}
				return r_IsReadOnly;
			}
		}

		/// <summary>
		/// Boolean IsFixedSize
		/// </summary>
		protected RProperty r_IsFixedSize;
		public virtual RProperty RIsFixedSize
		{
			get
			{
				if(r_IsFixedSize == null)
				{
					r_IsFixedSize = new(this, "IsFixedSize", -1);
					r_IsFixedSize.SetBelong(this.instance);
				}
				return r_IsFixedSize;
			}
		}

		/// <summary>
		/// Boolean Contains(System.Object)
		/// </summary>
		protected RMethod r_Contains_Object;
		public virtual RMethod RContains_Object
		{
			get
			{
				if(r_Contains_Object == null)
				{
					r_Contains_Object = new(this, "Contains", 0, typeof(System.Object));
					r_Contains_Object.SetBelong(this.instance);
				}
				return r_Contains_Object;
			}
		}

		/// <summary>
		/// Void Add(System.Object, System.Object)
		/// </summary>
		protected RMethod r_Add_Object_Object;
		public virtual RMethod RAdd_Object_Object
		{
			get
			{
				if(r_Add_Object_Object == null)
				{
					r_Add_Object_Object = new(this, "Add", 0, typeof(System.Object), typeof(System.Object));
					r_Add_Object_Object.SetBelong(this.instance);
				}
				return r_Add_Object_Object;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_Clear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_Clear == null)
				{
					r_Clear = new(this, "Clear", 0);
					r_Clear.SetBelong(this.instance);
				}
				return r_Clear;
			}
		}

		/// <summary>
		/// System.Collections.IDictionaryEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_GetEnumerator;
		public virtual RMethod RGetEnumerator
		{
			get
			{
				if(r_GetEnumerator == null)
				{
					r_GetEnumerator = new(this, "GetEnumerator", 0);
					r_GetEnumerator.SetBelong(this.instance);
				}
				return r_GetEnumerator;
			}
		}

		/// <summary>
		/// Void Remove(System.Object)
		/// </summary>
		protected RMethod r_Remove_Object;
		public virtual RMethod RRemove_Object
		{
			get
			{
				if(r_Remove_Object == null)
				{
					r_Remove_Object = new(this, "Remove", 0, typeof(System.Object));
					r_Remove_Object.SetBelong(this.instance);
				}
				return r_Remove_Object;
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

        public virtual System.Boolean Contains(System.Object @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RContains_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Add(System.Object @key, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RAdd_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IDictionaryEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IDictionaryEnumerator)___result;
        }


        public virtual void Remove(System.Object @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RRemove_Object.Invoke(___genericsType, ___parameters);

            
        }


    }
}
