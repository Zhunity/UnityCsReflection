
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.IComparable`1
	/// </summary>
    public partial class RIComparable<T> : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.IComparable<>);
            }
        }

        public RIComparable() : base("System.IComparable`1")
        {
        }

        public RIComparable(System.Object instance) : base("System.IComparable`1")
		{
            SetInstance(instance);
		}

        public RIComparable(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIComparable(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// Int32 CompareTo(T)
		/// </summary>
		protected RMethod r_MCompareTo_T;
		public virtual RMethod RMCompareTo_T
		{
			get
			{
				if(r_MCompareTo_T == null)
				{
					r_MCompareTo_T = new(this, "CompareTo", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MCompareTo_T;
			}
		}


        public virtual System.Int32 CompareTo(T @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMCompareTo_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


    }
}
