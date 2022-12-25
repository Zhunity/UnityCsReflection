using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
	/// System.Collections.Generic.IEqualityComparer`1
	/// </summary>
    public partial class RIEqualityComparer<T> : RMember //
    {

		/// <summary>
		/// Boolean Equals(T, T)
		/// </summary>
		protected RMethod r_REquals_T_T;
		public virtual RMethod REquals_T_T
		{
			get
			{
				if(r_REquals_T_T == null)
				{
					r_REquals_T_T = new(this, "Equals", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(0));
					r_REquals_T_T.SetBelong(this.instance);
				}
				return r_REquals_T_T;
			}
		}

		/// <summary>
		/// Int32 GetHashCode(T)
		/// </summary>
		protected RMethod r_RGetHashCode_T;
		public virtual RMethod RGetHashCode_T
		{
			get
			{
				if(r_RGetHashCode_T == null)
				{
					r_RGetHashCode_T = new(this, "GetHashCode", 0, Type.MakeGenericMethodParameter(0));
					r_RGetHashCode_T.SetBelong(this.instance);
				}
				return r_RGetHashCode_T;
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

        public virtual System.Boolean Equals(T  @x, T  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = REquals_T_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode(T  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RGetHashCode_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


    }
}
