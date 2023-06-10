
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
	/// System.Collections.Generic.IEqualityComparer`1
	/// </summary>
    public partial class RIEqualityComparer<T> : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Collections.Generic.IEqualityComparer<>).MakeGenericType(TypeToString.GetType(typeof(T)));
            }
        }

        public RIEqualityComparer() : base("System.Collections.Generic.IEqualityComparer`1")
        {
        }

        public RIEqualityComparer(System.Object instance) : base("System.Collections.Generic.IEqualityComparer`1")
		{
            SetInstance(instance);
		}

        public RIEqualityComparer(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIEqualityComparer(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// Boolean Equals(T, T)
		/// </summary>
		protected RMethod r_MEquals_T_T;
		public virtual RMethod RMEquals_T_T
		{
			get
			{
				if(r_MEquals_T_T == null)
				{
					r_MEquals_T_T = new(this, "Equals", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(0));
				}
				return r_MEquals_T_T;
			}
		}

		/// <summary>
		/// Int32 GetHashCode(T)
		/// </summary>
		protected RMethod r_MGetHashCode_T;
		public virtual RMethod RMGetHashCode_T
		{
			get
			{
				if(r_MGetHashCode_T == null)
				{
					r_MGetHashCode_T = new(this, "GetHashCode", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MGetHashCode_T;
			}
		}


        public virtual System.Boolean Equals(T @x, T @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RMEquals_T_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode(T @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMGetHashCode_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


    }
}
