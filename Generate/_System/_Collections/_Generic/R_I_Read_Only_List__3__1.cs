
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Collections.Generic.IReadOnlyList`1
	/// </summary>
    public partial class RIReadOnlyList<T> : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Collections.Generic.IReadOnlyList`1").MakeGenericType(ReflectionUtils.GetType(typeof(T)));
            }
        }

        public RIReadOnlyList() : base("System.Collections.Generic.IReadOnlyList`1")
        {
        }

        public RIReadOnlyList(System.Object instance) : base("System.Collections.Generic.IReadOnlyList`1")
		{
            SetInstance(instance);
		}

        public RIReadOnlyList(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIReadOnlyList(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// T Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_PItem_Int32;
		public virtual Hvak.Editor.Refleaction.RProperty RPItem_Int32
		{
			get
			{
				if(r_PItem_Int32 == null)
				{
					r_PItem_Int32 = new(this, "Item", -1, typeof(System.Int32));
				}
				return r_PItem_Int32;
			}
		}


    }
}
