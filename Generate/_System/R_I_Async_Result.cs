
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.IAsyncResult
	/// </summary>
    public partial class RIAsyncResult : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.IAsyncResult);
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


		/// <summary>
		/// Boolean IsCompleted
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsCompleted;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsCompleted
		{
			get
			{
				if(r_PIsCompleted == null)
				{
					r_PIsCompleted = new(this, "IsCompleted", -1);
				}
				return r_PIsCompleted;
			}
		}

		/// <summary>
		/// System.Threading.WaitHandle AsyncWaitHandle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RWaitHandle r_PAsyncWaitHandle;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RWaitHandle RPAsyncWaitHandle
		{
			get
			{
				if(r_PAsyncWaitHandle == null)
				{
					r_PAsyncWaitHandle = new(this, "AsyncWaitHandle", -1);
				}
				return r_PAsyncWaitHandle;
			}
		}

		/// <summary>
		/// System.Object AsyncState
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PAsyncState;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPAsyncState
		{
			get
			{
				if(r_PAsyncState == null)
				{
					r_PAsyncState = new(this, "AsyncState", -1);
				}
				return r_PAsyncState;
			}
		}

		/// <summary>
		/// Boolean CompletedSynchronously
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PCompletedSynchronously;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPCompletedSynchronously
		{
			get
			{
				if(r_PCompletedSynchronously == null)
				{
					r_PCompletedSynchronously = new(this, "CompletedSynchronously", -1);
				}
				return r_PCompletedSynchronously;
			}
		}


    }
}
