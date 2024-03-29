
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Collections.IHashCodeProvider
	/// </summary>
    public partial class RIHashCodeProvider : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Collections.IHashCodeProvider);
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


        public virtual System.Int32 GetHashCode(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMGetHashCode_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


    }
}
