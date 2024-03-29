
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Collections.IEqualityComparer
	/// </summary>
    public partial class RIEqualityComparer : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Collections.IEqualityComparer);
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


		/// <summary>
		/// Boolean Equals(System.Object, System.Object)
		/// </summary>
		protected RMethod r_MEquals_Object_Object;
		public virtual RMethod RMEquals_Object_Object
		{
			get
			{
				if(r_MEquals_Object_Object == null)
				{
					r_MEquals_Object_Object = new(this, "Equals", 0, typeof(System.Object), typeof(System.Object));
				}
				return r_MEquals_Object_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode(System.Object)
		/// </summary>
		protected RMethod r_MGetHashCode_Object;
		public virtual RMethod RMGetHashCode_Object
		{
			get
			{
				if(r_MGetHashCode_Object == null)
				{
					r_MGetHashCode_Object = new(this, "GetHashCode", 0, typeof(System.Object));
				}
				return r_MGetHashCode_Object;
			}
		}


        public virtual System.Boolean Equals(System.Object @x, System.Object @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RMEquals_Object_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMGetHashCode_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


    }
}
