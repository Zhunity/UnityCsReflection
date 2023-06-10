
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
	/// System.Collections.Generic.IEnumerable`1
	/// </summary>
    public partial class RIEnumerable<T> : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Collections.Generic.IEnumerable<>);
            }
        }

        public RIEnumerable() : base("System.Collections.Generic.IEnumerable`1")
        {
        }

        public RIEnumerable(System.Object instance) : base("System.Collections.Generic.IEnumerable`1")
		{
            SetInstance(instance);
		}

        public RIEnumerable(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIEnumerable(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Collections.Generic.IEnumerator`1[T] GetEnumerator()
		/// </summary>
		protected RMethod r_MGetEnumerator;
		public virtual RMethod RMGetEnumerator
		{
			get
			{
				if(r_MGetEnumerator == null)
				{
					r_MGetEnumerator = new(this, "GetEnumerator", 0);
				}
				return r_MGetEnumerator;
			}
		}


        public virtual System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerator<T>)___result;
        }


    }
}
