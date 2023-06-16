
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Collections.Generic.IEnumerator`1
	/// </summary>
    public partial class RIEnumerator<T> : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Collections.Generic.IEnumerator`1").MakeGenericType(ReflectionUtils.GetType(typeof(T)));
            }
        }

        public RIEnumerator() : base("System.Collections.Generic.IEnumerator`1")
        {
        }

        public RIEnumerator(System.Object instance) : base("System.Collections.Generic.IEnumerator`1")
		{
            SetInstance(instance);
		}

        public RIEnumerator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIEnumerator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// T Current
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_PCurrent;
		public virtual Hvak.Editor.Refleaction.RProperty RPCurrent
		{
			get
			{
				if(r_PCurrent == null)
				{
					r_PCurrent = new(this, "Current", -1);
				}
				return r_PCurrent;
			}
		}


    }
}
