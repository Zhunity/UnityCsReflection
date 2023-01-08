using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental
{
	/// <summary>
	/// UnityEngine.UIElements.Experimental.IValueAnimationUpdate
	/// </summary>
    public partial class RIValueAnimationUpdate : RMember //
    {

		/// <summary>
		/// Void Tick(Int64)
		/// </summary>
		protected RMethod r_Tick_Int64;
		public virtual RMethod RTick_Int64
		{
			get
			{
				if(r_Tick_Int64 == null)
				{
					r_Tick_Int64 = new(this, "Tick", 0, typeof(System.Int64));
					r_Tick_Int64.SetBelong(this.instance);
				}
				return r_Tick_Int64;
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

        public virtual void Tick(System.Int64  @currentTimeMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@currentTimeMs};
            var ___result = RTick_Int64.Invoke(___genericsType, ___parameters);

            
        }


    }
}
