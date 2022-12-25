using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
	/// System.Collections.Generic.IList`1
	/// </summary>
    public partial class RIList<T> : RMember //
    {

		/// <summary>
		/// T Item [Int32]
		/// </summary>
		protected RProperty r_Item_Int32;
		public virtual RProperty RItem_Int32
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
		/// Int32 IndexOf(T)
		/// </summary>
		protected RMethod r_RIndexOf_T;
		public virtual RMethod RIndexOf_T
		{
			get
			{
				if(r_RIndexOf_T == null)
				{
					r_RIndexOf_T = new(this, "IndexOf", 0, Type.MakeGenericMethodParameter(0));
					r_RIndexOf_T.SetBelong(this.instance);
				}
				return r_RIndexOf_T;
			}
		}

		/// <summary>
		/// Void Insert(Int32, T)
		/// </summary>
		protected RMethod r_RInsert_Int32_T;
		public virtual RMethod RInsert_Int32_T
		{
			get
			{
				if(r_RInsert_Int32_T == null)
				{
					r_RInsert_Int32_T = new(this, "Insert", 0, typeof(System.Int32), Type.MakeGenericMethodParameter(0));
					r_RInsert_Int32_T.SetBelong(this.instance);
				}
				return r_RInsert_Int32_T;
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

        public virtual System.Int32 IndexOf(T  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RIndexOf_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Insert(System.Int32  @index, T  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @item};
            var ___result = RInsert_Int32_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAt(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RRemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


    }
}
