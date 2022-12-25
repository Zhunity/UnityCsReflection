using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections
{
	/// <summary>
	/// System.Collections.IEqualityComparer
	/// </summary>
    public partial class RIEqualityComparer : RMember //
    {

		/// <summary>
		/// Boolean Equals(System.Object, System.Object)
		/// </summary>
		protected RMethod r_REquals_Object_Object;
		public virtual RMethod REquals_Object_Object
		{
			get
			{
				if(r_REquals_Object_Object == null)
				{
					r_REquals_Object_Object = new(this, "Equals", 0, typeof(System.Object), typeof(System.Object));
					r_REquals_Object_Object.SetBelong(this.instance);
				}
				return r_REquals_Object_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode(System.Object)
		/// </summary>
		protected RMethod r_RGetHashCode_Object;
		public virtual RMethod RGetHashCode_Object
		{
			get
			{
				if(r_RGetHashCode_Object == null)
				{
					r_RGetHashCode_Object = new(this, "GetHashCode", 0, typeof(System.Object));
					r_RGetHashCode_Object.SetBelong(this.instance);
				}
				return r_RGetHashCode_Object;
			}
		}


        public RIEqualityComparer() : base("System.Collections.IEqualityComparer")
        {
        }

        public RIEqualityComparer(System.Object instance) : base("System.Collections.IEqualityComparer")
		{
            SetInstance(instance);
		}

        public RIEqualityComparer(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIEqualityComparer(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @x, System.Object  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = REquals_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RGetHashCode_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


    }
}
