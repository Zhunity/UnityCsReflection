
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IGroupBoxOption
	/// </summary>
    public partial class RIGroupBoxOption : RMember //
    {

		/// <summary>
		/// Void SetSelected(Boolean)
		/// </summary>
		protected RMethod r_MSetSelected_Boolean;
		public virtual RMethod RMSetSelected_Boolean
		{
			get
			{
				if(r_MSetSelected_Boolean == null)
				{
					r_MSetSelected_Boolean = new(this, "SetSelected", 0, typeof(System.Boolean));
				}
				return r_MSetSelected_Boolean;
			}
		}


        public RIGroupBoxOption() : base("UnityEngine.UIElements.IGroupBoxOption")
        {
        }

        public RIGroupBoxOption(System.Object instance) : base("UnityEngine.UIElements.IGroupBoxOption")
		{
            SetInstance(instance);
		}

        public RIGroupBoxOption(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIGroupBoxOption(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetSelected(System.Boolean @selected)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@selected};
            var ___result = RMSetSelected_Boolean.Invoke(___genericsType, ___parameters);

            
        }


    }
}
