
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
	/// System.Collections.Generic.IComparer`1
	/// </summary>
    public partial class RIComparer<T> : RMember //
    {

		/// <summary>
		/// Int32 Compare(T, T)
		/// </summary>
		protected RMethod r_MCompare_T_T;
		public virtual RMethod RMCompare_T_T
		{
			get
			{
				if(r_MCompare_T_T == null)
				{
					r_MCompare_T_T = new(this, "Compare", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(0));
				}
				return r_MCompare_T_T;
			}
		}


        public RIComparer() : base("System.Collections.Generic.IComparer`1")
        {
        }

        public RIComparer(System.Object instance) : base("System.Collections.Generic.IComparer`1")
		{
            SetInstance(instance);
		}

        public RIComparer(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIComparer(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 Compare(T @x, T @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RMCompare_T_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


    }
}
