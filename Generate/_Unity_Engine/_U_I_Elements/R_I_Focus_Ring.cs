
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.IFocusRing
	/// </summary>
    public partial class RIFocusRing : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.IFocusRing);
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


		/// <summary>
		/// UnityEngine.UIElements.FocusChangeDirection GetFocusChangeDirection(UnityEngine.UIElements.Focusable, UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MGetFocusChangeDirection_Focusable_EventBase;
		public virtual RMethod RMGetFocusChangeDirection_Focusable_EventBase
		{
			get
			{
				if(r_MGetFocusChangeDirection_Focusable_EventBase == null)
				{
					r_MGetFocusChangeDirection_Focusable_EventBase = new(this, "GetFocusChangeDirection", 0, typeof(UnityEngine.UIElements.Focusable), typeof(UnityEngine.UIElements.EventBase));
				}
				return r_MGetFocusChangeDirection_Focusable_EventBase;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Focusable GetNextFocusable(UnityEngine.UIElements.Focusable, UnityEngine.UIElements.FocusChangeDirection)
		/// </summary>
		protected RMethod r_MGetNextFocusable_Focusable_FocusChangeDirection;
		public virtual RMethod RMGetNextFocusable_Focusable_FocusChangeDirection
		{
			get
			{
				if(r_MGetNextFocusable_Focusable_FocusChangeDirection == null)
				{
					r_MGetNextFocusable_Focusable_FocusChangeDirection = new(this, "GetNextFocusable", 0, typeof(UnityEngine.UIElements.Focusable), typeof(UnityEngine.UIElements.FocusChangeDirection));
				}
				return r_MGetNextFocusable_Focusable_FocusChangeDirection;
			}
		}


        public virtual UnityEngine.UIElements.FocusChangeDirection GetFocusChangeDirection(UnityEngine.UIElements.Focusable @currentFocusable, UnityEngine.UIElements.EventBase @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@currentFocusable, @e};
            var ___result = RMGetFocusChangeDirection_Focusable_EventBase.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.FocusChangeDirection>(___result);
        }


        public virtual UnityEngine.UIElements.Focusable GetNextFocusable(UnityEngine.UIElements.Focusable @currentFocusable, UnityEngine.UIElements.FocusChangeDirection @direction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@currentFocusable, @direction};
            var ___result = RMGetNextFocusable_Focusable_FocusChangeDirection.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Focusable>(___result);
        }


    }
}
