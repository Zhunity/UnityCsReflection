
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.UIElements.IVisualElementScheduler
	/// </summary>
    public partial class RIVisualElementScheduler : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.IVisualElementScheduler);
            }
        }

        public RIVisualElementScheduler() : base("UnityEngine.UIElements.IVisualElementScheduler")
        {
        }

        public RIVisualElementScheduler(System.Object instance) : base("UnityEngine.UIElements.IVisualElementScheduler")
		{
            SetInstance(instance);
		}

        public RIVisualElementScheduler(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIVisualElementScheduler(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduledItem Execute(System.Action`1[UnityEngine.UIElements.TimerState])
		/// </summary>
		protected RMethod r_MExecute_Action_d_TimerState_p_;
		public virtual RMethod RMExecute_Action_d_TimerState_p_
		{
			get
			{
				if(r_MExecute_Action_d_TimerState_p_ == null)
				{
					r_MExecute_Action_d_TimerState_p_ = new(this, "Execute", 0,  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.UIElements.TimerState)));
				}
				return r_MExecute_Action_d_TimerState_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduledItem Execute(System.Action)
		/// </summary>
		protected RMethod r_MExecute_Action;
		public virtual RMethod RMExecute_Action
		{
			get
			{
				if(r_MExecute_Action == null)
				{
					r_MExecute_Action = new(this, "Execute", 0, typeof(System.Action));
				}
				return r_MExecute_Action;
			}
		}


        public virtual UnityEngine.UIElements.IVisualElementScheduledItem Execute(System.Action<UnityEngine.UIElements.TimerState> @timerUpdateEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timerUpdateEvent};
            var ___result = RMExecute_Action_d_TimerState_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.IVisualElementScheduledItem>(___result);
        }


        public virtual UnityEngine.UIElements.IVisualElementScheduledItem Execute(System.Action @updateEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@updateEvent};
            var ___result = RMExecute_Action.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.IVisualElementScheduledItem>(___result);
        }


    }
}
