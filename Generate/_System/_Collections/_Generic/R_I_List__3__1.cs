
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Collections.Generic.IList`1
	/// </summary>
    public partial class RIList<T> : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Collections.Generic.IList`1").MakeGenericType(ReflectionUtils.GetType(typeof(T)));
            }
        }

        public RIList() : base("System.Collections.Generic.IList`1")
        {
        }

        public RIList(System.Object instance) : base("System.Collections.Generic.IList`1")
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
		/// T Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_PItem_Int32;
		public virtual Hvak.Editor.Refleaction.RProperty RPItem_Int32
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
		/// Int32 IndexOf(T)
		/// </summary>
		protected RMethod r_MIndexOf_T;
		public virtual RMethod RMIndexOf_T
		{
			get
			{
				if(r_MIndexOf_T == null)
				{
					r_MIndexOf_T = new(this, "IndexOf", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MIndexOf_T;
			}
		}

		/// <summary>
		/// Void Insert(Int32, T)
		/// </summary>
		protected RMethod r_MInsert_Int32_T;
		public virtual RMethod RMInsert_Int32_T
		{
			get
			{
				if(r_MInsert_Int32_T == null)
				{
					r_MInsert_Int32_T = new(this, "Insert", 0, typeof(System.Int32), Type.MakeGenericMethodParameter(0));
				}
				return r_MInsert_Int32_T;
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


        public virtual System.Int32 IndexOf(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMIndexOf_T.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual void Insert(System.Int32 @index, T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @item};
            var ___result = RMInsert_Int32_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMRemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


    }
}
