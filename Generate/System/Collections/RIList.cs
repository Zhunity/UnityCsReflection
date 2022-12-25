using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections
{
	/// <summary>
	/// System.Collections.IList
	/// </summary>
    public partial class RIList : RMember //
    {

		/// <summary>
		/// System.Object Item [Int32]
		/// </summary>
		protected RSystem.RObject r_Item_Int32;
		public virtual RSystem.RObject RItem_Int32
		{
			get
			{
				if(r_Item_Int32 == null)
				{
					r_Item_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_Item_Int32.SetBelong(this.instance);
				}
				return r_Item_Int32;
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
		/// Int32 Add(System.Object)
		/// </summary>
		protected RMethod r_RAdd_Object;
		public virtual RMethod RAdd_Object
		{
			get
			{
				if(r_RAdd_Object == null)
				{
					r_RAdd_Object = new(this, "Add", 0, typeof(System.Object));
					r_RAdd_Object.SetBelong(this.instance);
				}
				return r_RAdd_Object;
			}
		}

		/// <summary>
		/// Boolean Contains(System.Object)
		/// </summary>
		protected RMethod r_RContains_Object;
		public virtual RMethod RContains_Object
		{
			get
			{
				if(r_RContains_Object == null)
				{
					r_RContains_Object = new(this, "Contains", 0, typeof(System.Object));
					r_RContains_Object.SetBelong(this.instance);
				}
				return r_RContains_Object;
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
		/// Int32 IndexOf(System.Object)
		/// </summary>
		protected RMethod r_RIndexOf_Object;
		public virtual RMethod RIndexOf_Object
		{
			get
			{
				if(r_RIndexOf_Object == null)
				{
					r_RIndexOf_Object = new(this, "IndexOf", 0, typeof(System.Object));
					r_RIndexOf_Object.SetBelong(this.instance);
				}
				return r_RIndexOf_Object;
			}
		}

		/// <summary>
		/// Void Insert(Int32, System.Object)
		/// </summary>
		protected RMethod r_RInsert_Int32_Object;
		public virtual RMethod RInsert_Int32_Object
		{
			get
			{
				if(r_RInsert_Int32_Object == null)
				{
					r_RInsert_Int32_Object = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Object));
					r_RInsert_Int32_Object.SetBelong(this.instance);
				}
				return r_RInsert_Int32_Object;
			}
		}

		/// <summary>
		/// Void Remove(System.Object)
		/// </summary>
		protected RMethod r_RRemove_Object;
		public virtual RMethod RRemove_Object
		{
			get
			{
				if(r_RRemove_Object == null)
				{
					r_RRemove_Object = new(this, "Remove", 0, typeof(System.Object));
					r_RRemove_Object.SetBelong(this.instance);
				}
				return r_RRemove_Object;
			}
		}

		/// <summary>
		/// Void RemoveAt(Int32)
		/// </summary>
		protected RMethod r_RRemoveAt_Int32;
		public virtual RMethod RRemoveAt_Int32
		{
			get
			{
				if(r_RRemoveAt_Int32 == null)
				{
					r_RRemoveAt_Int32 = new(this, "RemoveAt", 0, typeof(System.Int32));
					r_RRemoveAt_Int32.SetBelong(this.instance);
				}
				return r_RRemoveAt_Int32;
			}
		}


        public RIList() : base("System.Collections.IList")
        {
        }

        public RIList(System.Object instance) : base("System.Collections.IList")
		{
            SetInstance(instance);
		}

        public RIList(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIList(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 Add(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAdd_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Contains(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RContains_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 IndexOf(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RIndexOf_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Insert(System.Int32  @index, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Remove(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RRemove_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAt(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RRemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


    }
}
