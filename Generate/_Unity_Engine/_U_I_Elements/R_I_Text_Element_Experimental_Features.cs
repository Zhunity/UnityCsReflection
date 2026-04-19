
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.ITextElementExperimentalFeatures
	/// </summary>
    public partial class RITextElementExperimentalFeatures : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.ITextElementExperimentalFeatures);
            }
        }

        public RITextElementExperimentalFeatures() : base("UnityEngine.UIElements.ITextElementExperimentalFeatures")
        {
        }

        public RITextElementExperimentalFeatures(System.Object instance) : base("UnityEngine.UIElements.ITextElementExperimentalFeatures")
		{
            SetInstance(instance);
		}

        public RITextElementExperimentalFeatures(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RITextElementExperimentalFeatures(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// Void SetRenderedText(System.String)
		/// </summary>
		protected RMethod r_MSetRenderedText_String;
		public virtual RMethod RMSetRenderedText_String
		{
			get
			{
				if(r_MSetRenderedText_String == null)
				{
					r_MSetRenderedText_String = new(this, "SetRenderedText", 0, typeof(System.String));
				}
				return r_MSetRenderedText_String;
			}
		}


        public virtual void SetRenderedText(System.String @renderedText)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderedText};
            var ___result = RMSetRenderedText_String.Invoke(___genericsType, ___parameters);

            
        }


    }
}
