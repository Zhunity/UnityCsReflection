using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IVisualElementScheduler
	/// </summary>
    public partial class RIVisualElementScheduler : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduledItem Execute(System.Action`1[UnityEngine.UIElements.TimerState])
		/// </summary>
		protected RMethod r_RExecute_Action_d_TimerState_p_;
		public virtual RMethod RExecute_Action_d_TimerState_p_
		{
			get
			{
				if(r_RExecute_Action_d_TimerState_p_ == null)
				{
					r_RExecute_Action_d_TimerState_p_ = new(this, "Execute", 0, typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.UIElements.TimerState)));
					r_RExecute_Action_d_TimerState_p_.SetBelong(this.instance);
				}
				return r_RExecute_Action_d_TimerState_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduledItem Execute(System.Action)
		/// </summary>
		protected RMethod r_RExecute_Action;
		public virtual RMethod RExecute_Action
		{
			get
			{
				if(r_RExecute_Action == null)
				{
					r_RExecute_Action = new(this, "Execute", 0, typeof(System.Action));
					r_RExecute_Action.SetBelong(this.instance);
				}
				return r_RExecute_Action;
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

        public virtual UnityEngine.UIElements.IVisualElementScheduledItem Execute(System.Action<UnityEngine.UIElements.TimerState>  @timerUpdateEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timerUpdateEvent};
            var ___result = RExecute_Action_d_TimerState_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.IVisualElementScheduledItem)___result;
        }


        public virtual UnityEngine.UIElements.IVisualElementScheduledItem Execute(System.Action  @updateEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@updateEvent};
            var ___result = RExecute_Action.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.IVisualElementScheduledItem)___result;
        }


    }
}
