using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.IAsyncResult
	/// </summary>
    public partial class RIAsyncResult : RMember //
    {

		/// <summary>
		/// Boolean IsCompleted
		/// </summary>
		protected RSystem.RBoolean r_PIsCompleted;
		public virtual RSystem.RBoolean RPIsCompleted
		{
			get
			{
				if(r_PIsCompleted == null)
				{
					r_PIsCompleted = new(this, "IsCompleted", -1);
					r_PIsCompleted.SetBelong(this.instance);
				}
				return r_PIsCompleted;
			}
		}

		/// <summary>
		/// System.Threading.WaitHandle AsyncWaitHandle
		/// </summary>
		protected RSystem.RThreading.RWaitHandle r_PAsyncWaitHandle;
		public virtual RSystem.RThreading.RWaitHandle RPAsyncWaitHandle
		{
			get
			{
				if(r_PAsyncWaitHandle == null)
				{
					r_PAsyncWaitHandle = new(this, "AsyncWaitHandle", -1);
					r_PAsyncWaitHandle.SetBelong(this.instance);
				}
				return r_PAsyncWaitHandle;
			}
		}

		/// <summary>
		/// System.Object AsyncState
		/// </summary>
		protected RSystem.RObject r_PAsyncState;
		public virtual RSystem.RObject RPAsyncState
		{
			get
			{
				if(r_PAsyncState == null)
				{
					r_PAsyncState = new(this, "AsyncState", -1);
					r_PAsyncState.SetBelong(this.instance);
				}
				return r_PAsyncState;
			}
		}

		/// <summary>
		/// Boolean CompletedSynchronously
		/// </summary>
		protected RSystem.RBoolean r_PCompletedSynchronously;
		public virtual RSystem.RBoolean RPCompletedSynchronously
		{
			get
			{
				if(r_PCompletedSynchronously == null)
				{
					r_PCompletedSynchronously = new(this, "CompletedSynchronously", -1);
					r_PCompletedSynchronously.SetBelong(this.instance);
				}
				return r_PCompletedSynchronously;
			}
		}


        public RIAsyncResult() : base("System.IAsyncResult")
        {
        }

        public RIAsyncResult(System.Object instance) : base("System.IAsyncResult")
		{
            SetInstance(instance);
		}

        public RIAsyncResult(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIAsyncResult(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

    }
}
