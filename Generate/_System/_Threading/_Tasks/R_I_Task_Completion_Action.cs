
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading.RTasks
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Threading.Tasks.ITaskCompletionAction
	/// </summary>
    public partial class RITaskCompletionAction : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Threading.Tasks.ITaskCompletionAction");
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


		/// <summary>
		/// Boolean InvokeMayRunArbitraryCode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PInvokeMayRunArbitraryCode;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPInvokeMayRunArbitraryCode
		{
			get
			{
				if(r_PInvokeMayRunArbitraryCode == null)
				{
					r_PInvokeMayRunArbitraryCode = new(this, "InvokeMayRunArbitraryCode", -1);
				}
				return r_PInvokeMayRunArbitraryCode;
			}
		}

		/// <summary>
		/// Void Invoke(System.Threading.Tasks.Task)
		/// </summary>
		protected RMethod r_MInvoke_Task;
		public virtual RMethod RMInvoke_Task
		{
			get
			{
				if(r_MInvoke_Task == null)
				{
					r_MInvoke_Task = new(this, "Invoke", 0, typeof(System.Threading.Tasks.Task));
				}
				return r_MInvoke_Task;
			}
		}


        public virtual void Invoke(System.Threading.Tasks.Task @completingTask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@completingTask};
            var ___result = RMInvoke_Task.Invoke(___genericsType, ___parameters);

            
        }


    }
}
