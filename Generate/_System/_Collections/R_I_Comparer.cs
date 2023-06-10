
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections
{
	/// <summary>
	/// System.Collections.IComparer
	/// </summary>
    public partial class RIComparer : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Collections.IComparer);
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


		/// <summary>
		/// Int32 Compare(System.Object, System.Object)
		/// </summary>
		protected RMethod r_MCompare_Object_Object;
		public virtual RMethod RMCompare_Object_Object
		{
			get
			{
				if(r_MCompare_Object_Object == null)
				{
					r_MCompare_Object_Object = new(this, "Compare", 0, typeof(System.Object), typeof(System.Object));
				}
				return r_MCompare_Object_Object;
			}
		}


        public virtual System.Int32 Compare(System.Object @x, System.Object @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RMCompare_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


    }
}
