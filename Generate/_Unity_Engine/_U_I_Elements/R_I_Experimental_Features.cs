
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.IExperimentalFeatures
	/// </summary>
    public partial class RIExperimentalFeatures : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.IExperimentalFeatures);
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


		/// <summary>
		/// UnityEngine.UIElements.Experimental.ITransitionAnimations animation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RITransitionAnimations r_Panimation;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RITransitionAnimations RPanimation
		{
			get
			{
				if(r_Panimation == null)
				{
					r_Panimation = new(this, "animation", -1);
				}
				return r_Panimation;
			}
		}


    }
}
