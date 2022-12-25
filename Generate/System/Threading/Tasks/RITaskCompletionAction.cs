using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks
{
	/// <summary>
	/// System.Threading.Tasks.ITaskCompletionAction
	/// </summary>
    public partial class RITaskCompletionAction : RMember //
    {

		/// <summary>
		/// Boolean InvokeMayRunArbitraryCode
		/// </summary>
		protected RProperty r_InvokeMayRunArbitraryCode;
		public virtual RProperty RInvokeMayRunArbitraryCode
		{
			get
			{
				if(r_InvokeMayRunArbitraryCode == null)
				{
					r_InvokeMayRunArbitraryCode = new(this, "InvokeMayRunArbitraryCode", -1);
					r_InvokeMayRunArbitraryCode.SetBelong(this.instance);
				}
				return r_InvokeMayRunArbitraryCode;
			}
		}

		/// <summary>
		/// Void Invoke(System.Threading.Tasks.Task)
		/// </summary>
		protected RMethod r_RInvoke_Task;
		public virtual RMethod RInvoke_Task
		{
			get
			{
				if(r_RInvoke_Task == null)
				{
					r_RInvoke_Task = new(this, "Invoke", 0, typeof(System.Threading.Tasks.Task));
					r_RInvoke_Task.SetBelong(this.instance);
				}
				return r_RInvoke_Task;
			}
		}


        public RITaskCompletionAction() : base("System.Threading.Tasks.ITaskCompletionAction")
        {
        }

        public RITaskCompletionAction(System.Object instance) : base("System.Threading.Tasks.ITaskCompletionAction")
		{
            SetInstance(instance);
		}

        public RITaskCompletionAction(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RITaskCompletionAction(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Invoke(System.Threading.Tasks.Task  @completingTask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@completingTask};
            var ___result = RInvoke_Task.Invoke(___genericsType, ___parameters);

            
        }


    }
}
