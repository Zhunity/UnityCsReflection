using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.IEquatable`1
	/// </summary>
    public partial class RIEquatable<T> : RMember //
    {

		/// <summary>
		/// Boolean Equals(T)
		/// </summary>
		protected RMethod r_MEquals_T;
		public virtual RMethod RMEquals_T
		{
			get
			{
				if(r_MEquals_T == null)
				{
					r_MEquals_T = new(this, "Equals", 0, Type.MakeGenericMethodParameter(0));
					r_MEquals_T.SetBelong(this.instance);
				}
				return r_MEquals_T;
			}
		}


        public RIEquatable() : base("System.IEquatable`1")
        {
        }

        public RIEquatable(System.Object instance) : base("System.IEquatable`1")
		{
            SetInstance(instance);
		}

        public RIEquatable(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIEquatable(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(T @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


    }
}
