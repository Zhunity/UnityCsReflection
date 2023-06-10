
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental
{
	/// <summary>
	/// UnityEngine.UIElements.Experimental.IValueAnimationUpdate
	/// </summary>
    public partial class RIValueAnimationUpdate : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.Experimental.IValueAnimationUpdate");
            }
        }

        public RIValueAnimationUpdate() : base("UnityEngine.UIElements.Experimental.IValueAnimationUpdate")
        {
        }

        public RIValueAnimationUpdate(System.Object instance) : base("UnityEngine.UIElements.Experimental.IValueAnimationUpdate")
		{
            SetInstance(instance);
		}

        public RIValueAnimationUpdate(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIValueAnimationUpdate(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// Void Tick(Int64)
		/// </summary>
		protected RMethod r_MTick_Int64;
		public virtual RMethod RMTick_Int64
		{
			get
			{
				if(r_MTick_Int64 == null)
				{
					r_MTick_Int64 = new(this, "Tick", 0, typeof(System.Int64));
				}
				return r_MTick_Int64;
			}
		}


        public virtual void Tick(System.Int64 @currentTimeMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@currentTimeMs};
            var ___result = RMTick_Int64.Invoke(___genericsType, ___parameters);

            
        }


    }
}
