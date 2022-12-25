using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IFocusRing
	/// </summary>
    public partial class RIFocusRing : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.FocusChangeDirection GetFocusChangeDirection(UnityEngine.UIElements.Focusable, UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RGetFocusChangeDirection_Focusable_EventBase;
		public virtual RMethod RGetFocusChangeDirection_Focusable_EventBase
		{
			get
			{
				if(r_RGetFocusChangeDirection_Focusable_EventBase == null)
				{
					r_RGetFocusChangeDirection_Focusable_EventBase = new(this, "GetFocusChangeDirection", 0, typeof(UnityEngine.UIElements.Focusable), typeof(UnityEngine.UIElements.EventBase));
					r_RGetFocusChangeDirection_Focusable_EventBase.SetBelong(this.instance);
				}
				return r_RGetFocusChangeDirection_Focusable_EventBase;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Focusable GetNextFocusable(UnityEngine.UIElements.Focusable, UnityEngine.UIElements.FocusChangeDirection)
		/// </summary>
		protected RMethod r_RGetNextFocusable_Focusable_FocusChangeDirection;
		public virtual RMethod RGetNextFocusable_Focusable_FocusChangeDirection
		{
			get
			{
				if(r_RGetNextFocusable_Focusable_FocusChangeDirection == null)
				{
					r_RGetNextFocusable_Focusable_FocusChangeDirection = new(this, "GetNextFocusable", 0, typeof(UnityEngine.UIElements.Focusable), typeof(UnityEngine.UIElements.FocusChangeDirection));
					r_RGetNextFocusable_Focusable_FocusChangeDirection.SetBelong(this.instance);
				}
				return r_RGetNextFocusable_Focusable_FocusChangeDirection;
			}
		}


        public RIFocusRing() : base("UnityEngine.UIElements.IFocusRing")
        {
        }

        public RIFocusRing(System.Object instance) : base("UnityEngine.UIElements.IFocusRing")
		{
            SetInstance(instance);
		}

        public RIFocusRing(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIFocusRing(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual UnityEngine.UIElements.FocusChangeDirection GetFocusChangeDirection(UnityEngine.UIElements.Focusable  @currentFocusable, UnityEngine.UIElements.EventBase  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@currentFocusable, @e};
            var ___result = RGetFocusChangeDirection_Focusable_EventBase.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.FocusChangeDirection)___result;
        }


        public virtual UnityEngine.UIElements.Focusable GetNextFocusable(UnityEngine.UIElements.Focusable  @currentFocusable, UnityEngine.UIElements.FocusChangeDirection  @direction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@currentFocusable, @direction};
            var ___result = RGetNextFocusable_Focusable_FocusChangeDirection.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Focusable)___result;
        }


    }
}
