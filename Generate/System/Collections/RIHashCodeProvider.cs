using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections
{
	/// <summary>
	/// System.Collections.IHashCodeProvider
	/// </summary>
    public partial class RIHashCodeProvider : RMember //
    {

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


        public RIHashCodeProvider() : base("System.Collections.IHashCodeProvider")
        {
        }

        public RIHashCodeProvider(System.Object instance) : base("System.Collections.IHashCodeProvider")
		{
            SetInstance(instance);
		}

        public RIHashCodeProvider(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIHashCodeProvider(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
