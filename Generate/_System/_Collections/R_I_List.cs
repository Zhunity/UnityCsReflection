
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Collections.IList
	/// </summary>
    public partial class RIList : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Collections.IList);
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


		/// <summary>
		/// System.Object Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PItem_Int32;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPItem_Int32
		{
			get
			{
				if(r_PItem_Int32 == null)
				{
					r_PItem_Int32 = new(this, "Item", -1, typeof(System.Int32));
				}
				return r_PItem_Int32;
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
		/// Int32 Add(System.Object)
		/// </summary>
		protected RMethod r_MAdd_Object;
		public virtual RMethod RMAdd_Object
		{
			get
			{
				if(r_MAdd_Object == null)
				{
					r_MAdd_Object = new(this, "Add", 0, typeof(System.Object));
				}
				return r_MAdd_Object;
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
		/// Int32 IndexOf(System.Object)
		/// </summary>
		protected RMethod r_MIndexOf_Object;
		public virtual RMethod RMIndexOf_Object
		{
			get
			{
				if(r_MIndexOf_Object == null)
				{
					r_MIndexOf_Object = new(this, "IndexOf", 0, typeof(System.Object));
				}
				return r_MIndexOf_Object;
			}
		}

		/// <summary>
		/// Void Insert(Int32, System.Object)
		/// </summary>
		protected RMethod r_MInsert_Int32_Object;
		public virtual RMethod RMInsert_Int32_Object
		{
			get
			{
				if(r_MInsert_Int32_Object == null)
				{
					r_MInsert_Int32_Object = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Object));
				}
				return r_MInsert_Int32_Object;
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

		/// <summary>
		/// Void RemoveAt(Int32)
		/// </summary>
		protected RMethod r_MRemoveAt_Int32;
		public virtual RMethod RMRemoveAt_Int32
		{
			get
			{
				if(r_MRemoveAt_Int32 == null)
				{
					r_MRemoveAt_Int32 = new(this, "RemoveAt", 0, typeof(System.Int32));
				}
				return r_MRemoveAt_Int32;
			}
		}


        public virtual System.Int32 Add(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAdd_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Contains(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMContains_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 IndexOf(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMIndexOf_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual void Insert(System.Int32 @index, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RMInsert_Int32_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Remove(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMRemove_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMRemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


    }
}
