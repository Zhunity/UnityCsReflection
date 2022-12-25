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
		protected RProperty r_IsCompleted;
		public virtual RProperty RIsCompleted
		{
			get
			{
				if(r_IsCompleted == null)
				{
					r_IsCompleted = new(this, "IsCompleted", -1);
					r_IsCompleted.SetBelong(this.instance);
				}
				return r_IsCompleted;
			}
		}

		/// <summary>
		/// System.Threading.WaitHandle AsyncWaitHandle
		/// </summary>
		protected RSystem.RThreading.RWaitHandle r_AsyncWaitHandle;
		public virtual RSystem.RThreading.RWaitHandle RAsyncWaitHandle
		{
			get
			{
				if(r_AsyncWaitHandle == null)
				{
					r_AsyncWaitHandle = new(this, "AsyncWaitHandle", -1);
					r_AsyncWaitHandle.SetBelong(this.instance);
				}
				return r_AsyncWaitHandle;
			}
		}

		/// <summary>
		/// System.Object AsyncState
		/// </summary>
		protected RSystem.RObject r_AsyncState;
		public virtual RSystem.RObject RAsyncState
		{
			get
			{
				if(r_AsyncState == null)
				{
					r_AsyncState = new(this, "AsyncState", -1);
					r_AsyncState.SetBelong(this.instance);
				}
				return r_AsyncState;
			}
		}

		/// <summary>
		/// Boolean CompletedSynchronously
		/// </summary>
		protected RProperty r_CompletedSynchronously;
		public virtual RProperty RCompletedSynchronously
		{
			get
			{
				if(r_CompletedSynchronously == null)
				{
					r_CompletedSynchronously = new(this, "CompletedSynchronously", -1);
					r_CompletedSynchronously.SetBelong(this.instance);
				}
				return r_CompletedSynchronously;
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
