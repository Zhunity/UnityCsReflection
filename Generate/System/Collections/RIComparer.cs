using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections
{
	/// <summary>
	/// System.Collections.IComparer
	/// </summary>
    public partial class RIComparer : RMember //
    {

		/// <summary>
		/// Int32 Compare(System.Object, System.Object)
		/// </summary>
		protected RMethod r_RCompare_Object_Object;
		public virtual RMethod RCompare_Object_Object
		{
			get
			{
				if(r_RCompare_Object_Object == null)
				{
					r_RCompare_Object_Object = new(this, "Compare", 0, typeof(System.Object), typeof(System.Object));
					r_RCompare_Object_Object.SetBelong(this.instance);
				}
				return r_RCompare_Object_Object;
			}
		}


        public RIComparer() : base("System.Collections.IComparer")
        {
        }

        public RIComparer(System.Object instance) : base("System.Collections.IComparer")
		{
            SetInstance(instance);
		}

        public RIComparer(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIComparer(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 Compare(System.Object  @x, System.Object  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RCompare_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


    }
}
