using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IExperimentalFeatures
	/// </summary>
    public partial class RIExperimentalFeatures : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ITransitionAnimations animation
		/// </summary>
		protected RUnityEngine.RUIElements.RExperimental.RITransitionAnimations r_animation;
		public virtual RUnityEngine.RUIElements.RExperimental.RITransitionAnimations Ranimation
		{
			get
			{
				if(r_animation == null)
				{
					r_animation = new(this, "animation", -1);
					r_animation.SetBelong(this.instance);
				}
				return r_animation;
			}
		}


        public RIExperimentalFeatures() : base("UnityEngine.UIElements.IExperimentalFeatures")
        {
        }

        public RIExperimentalFeatures(System.Object instance) : base("UnityEngine.UIElements.IExperimentalFeatures")
		{
            SetInstance(instance);
		}

        public RIExperimentalFeatures(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIExperimentalFeatures(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

    }
}
