using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
	/// System.Collections.Generic.IReadOnlyList`1
	/// </summary>
    public partial class RIReadOnlyList<T> : RMember //
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


        public RIReadOnlyList() : base("System.Collections.Generic.IReadOnlyList`1")
        {
        }

        public RIReadOnlyList(System.Object instance) : base("System.Collections.Generic.IReadOnlyList`1")
		{
            SetInstance(instance);
		}

        public RIReadOnlyList(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIReadOnlyList(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

    }
}
