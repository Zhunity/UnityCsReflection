using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.SemaphoreSlim
	/// </summary>
    public partial class RSemaphoreSlim : RMember //
    {

		/// <summary>
		/// System.Int32 m_currentCount
		/// </summary>
		protected RField r_m_currentCount;
		public virtual RField Rm_currentCount
		{
			get
			{
				if(r_m_currentCount == null)
				{
					r_m_currentCount = new(this, "m_currentCount");
					r_m_currentCount.SetBelong(this.instance);
				}
				return r_m_currentCount;
			}
		}

		/// <summary>
		/// System.Int32 m_maxCount
		/// </summary>
		protected RField r_m_maxCount;
		public virtual RField Rm_maxCount
		{
			get
			{
				if(r_m_maxCount == null)
				{
					r_m_maxCount = new(this, "m_maxCount");
					r_m_maxCount.SetBelong(this.instance);
				}
				return r_m_maxCount;
			}
		}

		/// <summary>
		/// System.Int32 m_waitCount
		/// </summary>
		protected RField r_m_waitCount;
		public virtual RField Rm_waitCount
		{
			get
			{
				if(r_m_waitCount == null)
				{
					r_m_waitCount = new(this, "m_waitCount");
					r_m_waitCount.SetBelong(this.instance);
				}
				return r_m_waitCount;
			}
		}

		/// <summary>
		/// System.Object m_lockObj
		/// </summary>
		protected RSystem.RObject r_m_lockObj;
		public virtual RSystem.RObject Rm_lockObj
		{
			get
			{
				if(r_m_lockObj == null)
				{
					r_m_lockObj = new(this, "m_lockObj");
					r_m_lockObj.SetBelong(this.instance);
				}
				return r_m_lockObj;
			}
		}

		/// <summary>
		/// System.Threading.ManualResetEvent m_waitHandle
		/// </summary>
		protected RSystem.RThreading.RManualResetEvent r_m_waitHandle;
		public virtual RSystem.RThreading.RManualResetEvent Rm_waitHandle
		{
			get
			{
				if(r_m_waitHandle == null)
				{
					r_m_waitHandle = new(this, "m_waitHandle");
					r_m_waitHandle.SetBelong(this.instance);
				}
				return r_m_waitHandle;
			}
		}

		/// <summary>
		/// System.Threading.SemaphoreSlim+TaskNode m_asyncHead
		/// </summary>
		protected RSystem.RThreading.RSemaphoreSlim.RTaskNode r_m_asyncHead;
		public virtual RSystem.RThreading.RSemaphoreSlim.RTaskNode Rm_asyncHead
		{
			get
			{
				if(r_m_asyncHead == null)
				{
					r_m_asyncHead = new(this, "m_asyncHead");
					r_m_asyncHead.SetBelong(this.instance);
				}
				return r_m_asyncHead;
			}
		}

		/// <summary>
		/// System.Threading.SemaphoreSlim+TaskNode m_asyncTail
		/// </summary>
		protected RSystem.RThreading.RSemaphoreSlim.RTaskNode r_m_asyncTail;
		public virtual RSystem.RThreading.RSemaphoreSlim.RTaskNode Rm_asyncTail
		{
			get
			{
				if(r_m_asyncTail == null)
				{
					r_m_asyncTail = new(this, "m_asyncTail");
					r_m_asyncTail.SetBelong(this.instance);
				}
				return r_m_asyncTail;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] s_trueTask
		/// </summary>
		protected static RSystem.RThreading.RTasks.RTask<RField> r_s_trueTask;
		public static RSystem.RThreading.RTasks.RTask<RField> Rs_trueTask
		{
			get
			{
				if(r_s_trueTask == null)
				{
					r_s_trueTask = new(typeof(System.Threading.SemaphoreSlim), "s_trueTask");
					r_s_trueTask.SetBelong(null);
				}
				return r_s_trueTask;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] s_falseTask
		/// </summary>
		protected static RSystem.RThreading.RTasks.RTask<RField> r_s_falseTask;
		public static RSystem.RThreading.RTasks.RTask<RField> Rs_falseTask
		{
			get
			{
				if(r_s_falseTask == null)
				{
					r_s_falseTask = new(typeof(System.Threading.SemaphoreSlim), "s_falseTask");
					r_s_falseTask.SetBelong(null);
				}
				return r_s_falseTask;
			}
		}

		/// <summary>
		/// System.Int32 NO_MAXIMUM
		/// </summary>
		protected static RField r_NO_MAXIMUM;
		public static RField RNO_MAXIMUM
		{
			get
			{
				if(r_NO_MAXIMUM == null)
				{
					r_NO_MAXIMUM = new(typeof(System.Threading.SemaphoreSlim), "NO_MAXIMUM");
					r_NO_MAXIMUM.SetBelong(null);
				}
				return r_NO_MAXIMUM;
			}
		}

		/// <summary>
		/// System.Action`1[System.Object] s_cancellationTokenCanceledEventHandler
		/// </summary>
		protected static RSystem.RAction<RSystem.RObject> r_s_cancellationTokenCanceledEventHandler;
		public static RSystem.RAction<RSystem.RObject> Rs_cancellationTokenCanceledEventHandler
		{
			get
			{
				if(r_s_cancellationTokenCanceledEventHandler == null)
				{
					r_s_cancellationTokenCanceledEventHandler = new(typeof(System.Threading.SemaphoreSlim), "s_cancellationTokenCanceledEventHandler");
					r_s_cancellationTokenCanceledEventHandler.SetBelong(null);
				}
				return r_s_cancellationTokenCanceledEventHandler;
			}
		}

		/// <summary>
		/// Int32 CurrentCount
		/// </summary>
		protected RProperty r_CurrentCount;
		public virtual RProperty RCurrentCount
		{
			get
			{
				if(r_CurrentCount == null)
				{
					r_CurrentCount = new(this, "CurrentCount", -1);
					r_CurrentCount.SetBelong(this.instance);
				}
				return r_CurrentCount;
			}
		}

		/// <summary>
		/// System.Threading.WaitHandle AvailableWaitHandle
		/// </summary>
		protected RSystem.RThreading.RWaitHandle r_AvailableWaitHandle;
		public virtual RSystem.RThreading.RWaitHandle RAvailableWaitHandle
		{
			get
			{
				if(r_AvailableWaitHandle == null)
				{
					r_AvailableWaitHandle = new(this, "AvailableWaitHandle", -1);
					r_AvailableWaitHandle.SetBelong(this.instance);
				}
				return r_AvailableWaitHandle;
			}
		}

		/// <summary>
		/// Void Wait()
		/// </summary>
		protected RMethod r_RWait;
		public virtual RMethod RWait
		{
			get
			{
				if(r_RWait == null)
				{
					r_RWait = new(this, "Wait", 0);
					r_RWait.SetBelong(this.instance);
				}
				return r_RWait;
			}
		}

		/// <summary>
		/// Void Wait(System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RWait_CancellationToken;
		public virtual RMethod RWait_CancellationToken
		{
			get
			{
				if(r_RWait_CancellationToken == null)
				{
					r_RWait_CancellationToken = new(this, "Wait", 0, typeof(System.Threading.CancellationToken));
					r_RWait_CancellationToken.SetBelong(this.instance);
				}
				return r_RWait_CancellationToken;
			}
		}

		/// <summary>
		/// Boolean Wait(System.TimeSpan)
		/// </summary>
		protected RMethod r_RWait_TimeSpan;
		public virtual RMethod RWait_TimeSpan
		{
			get
			{
				if(r_RWait_TimeSpan == null)
				{
					r_RWait_TimeSpan = new(this, "Wait", 0, typeof(System.TimeSpan));
					r_RWait_TimeSpan.SetBelong(this.instance);
				}
				return r_RWait_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean Wait(System.TimeSpan, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RWait_TimeSpan_CancellationToken;
		public virtual RMethod RWait_TimeSpan_CancellationToken
		{
			get
			{
				if(r_RWait_TimeSpan_CancellationToken == null)
				{
					r_RWait_TimeSpan_CancellationToken = new(this, "Wait", 0, typeof(System.TimeSpan), typeof(System.Threading.CancellationToken));
					r_RWait_TimeSpan_CancellationToken.SetBelong(this.instance);
				}
				return r_RWait_TimeSpan_CancellationToken;
			}
		}

		/// <summary>
		/// Boolean Wait(Int32)
		/// </summary>
		protected RMethod r_RWait_Int32;
		public virtual RMethod RWait_Int32
		{
			get
			{
				if(r_RWait_Int32 == null)
				{
					r_RWait_Int32 = new(this, "Wait", 0, typeof(System.Int32));
					r_RWait_Int32.SetBelong(this.instance);
				}
				return r_RWait_Int32;
			}
		}

		/// <summary>
		/// Boolean Wait(Int32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RWait_Int32_CancellationToken;
		public virtual RMethod RWait_Int32_CancellationToken
		{
			get
			{
				if(r_RWait_Int32_CancellationToken == null)
				{
					r_RWait_Int32_CancellationToken = new(this, "Wait", 0, typeof(System.Int32), typeof(System.Threading.CancellationToken));
					r_RWait_Int32_CancellationToken.SetBelong(this.instance);
				}
				return r_RWait_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// Boolean WaitUntilCountOrTimeout(Int32, UInt32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RWaitUntilCountOrTimeout_Int32_UInt32_CancellationToken;
		public virtual RMethod RWaitUntilCountOrTimeout_Int32_UInt32_CancellationToken
		{
			get
			{
				if(r_RWaitUntilCountOrTimeout_Int32_UInt32_CancellationToken == null)
				{
					r_RWaitUntilCountOrTimeout_Int32_UInt32_CancellationToken = new(this, "WaitUntilCountOrTimeout", 0, typeof(System.Int32), typeof(System.UInt32), typeof(System.Threading.CancellationToken));
					r_RWaitUntilCountOrTimeout_Int32_UInt32_CancellationToken.SetBelong(this.instance);
				}
				return r_RWaitUntilCountOrTimeout_Int32_UInt32_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WaitAsync()
		/// </summary>
		protected RMethod r_RWaitAsync;
		public virtual RMethod RWaitAsync
		{
			get
			{
				if(r_RWaitAsync == null)
				{
					r_RWaitAsync = new(this, "WaitAsync", 0);
					r_RWaitAsync.SetBelong(this.instance);
				}
				return r_RWaitAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WaitAsync(System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RWaitAsync_CancellationToken;
		public virtual RMethod RWaitAsync_CancellationToken
		{
			get
			{
				if(r_RWaitAsync_CancellationToken == null)
				{
					r_RWaitAsync_CancellationToken = new(this, "WaitAsync", 0, typeof(System.Threading.CancellationToken));
					r_RWaitAsync_CancellationToken.SetBelong(this.instance);
				}
				return r_RWaitAsync_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] WaitAsync(Int32)
		/// </summary>
		protected RMethod r_RWaitAsync_Int32;
		public virtual RMethod RWaitAsync_Int32
		{
			get
			{
				if(r_RWaitAsync_Int32 == null)
				{
					r_RWaitAsync_Int32 = new(this, "WaitAsync", 0, typeof(System.Int32));
					r_RWaitAsync_Int32.SetBelong(this.instance);
				}
				return r_RWaitAsync_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] WaitAsync(System.TimeSpan)
		/// </summary>
		protected RMethod r_RWaitAsync_TimeSpan;
		public virtual RMethod RWaitAsync_TimeSpan
		{
			get
			{
				if(r_RWaitAsync_TimeSpan == null)
				{
					r_RWaitAsync_TimeSpan = new(this, "WaitAsync", 0, typeof(System.TimeSpan));
					r_RWaitAsync_TimeSpan.SetBelong(this.instance);
				}
				return r_RWaitAsync_TimeSpan;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] WaitAsync(System.TimeSpan, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RWaitAsync_TimeSpan_CancellationToken;
		public virtual RMethod RWaitAsync_TimeSpan_CancellationToken
		{
			get
			{
				if(r_RWaitAsync_TimeSpan_CancellationToken == null)
				{
					r_RWaitAsync_TimeSpan_CancellationToken = new(this, "WaitAsync", 0, typeof(System.TimeSpan), typeof(System.Threading.CancellationToken));
					r_RWaitAsync_TimeSpan_CancellationToken.SetBelong(this.instance);
				}
				return r_RWaitAsync_TimeSpan_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] WaitAsync(Int32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RWaitAsync_Int32_CancellationToken;
		public virtual RMethod RWaitAsync_Int32_CancellationToken
		{
			get
			{
				if(r_RWaitAsync_Int32_CancellationToken == null)
				{
					r_RWaitAsync_Int32_CancellationToken = new(this, "WaitAsync", 0, typeof(System.Int32), typeof(System.Threading.CancellationToken));
					r_RWaitAsync_Int32_CancellationToken.SetBelong(this.instance);
				}
				return r_RWaitAsync_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// TaskNode CreateAndAddAsyncWaiter()
		/// </summary>
		protected RMethod r_RCreateAndAddAsyncWaiter;
		public virtual RMethod RCreateAndAddAsyncWaiter
		{
			get
			{
				if(r_RCreateAndAddAsyncWaiter == null)
				{
					r_RCreateAndAddAsyncWaiter = new(this, "CreateAndAddAsyncWaiter", 0);
					r_RCreateAndAddAsyncWaiter.SetBelong(this.instance);
				}
				return r_RCreateAndAddAsyncWaiter;
			}
		}

		/// <summary>
		/// Boolean RemoveAsyncWaiter(TaskNode)
		/// </summary>
		protected RMethod r_RRemoveAsyncWaiter_TaskNode;
		public virtual RMethod RRemoveAsyncWaiter_TaskNode
		{
			get
			{
				if(r_RRemoveAsyncWaiter_TaskNode == null)
				{
					r_RRemoveAsyncWaiter_TaskNode = new(this, "RemoveAsyncWaiter", 0,  ReleactionUtils.GetType("System.Threading.SemaphoreSlim+TaskNode"));
					r_RRemoveAsyncWaiter_TaskNode.SetBelong(this.instance);
				}
				return r_RRemoveAsyncWaiter_TaskNode;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] WaitUntilCountOrTimeoutAsync(TaskNode, Int32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RWaitUntilCountOrTimeoutAsync_TaskNode_Int32_CancellationToken;
		public virtual RMethod RWaitUntilCountOrTimeoutAsync_TaskNode_Int32_CancellationToken
		{
			get
			{
				if(r_RWaitUntilCountOrTimeoutAsync_TaskNode_Int32_CancellationToken == null)
				{
					r_RWaitUntilCountOrTimeoutAsync_TaskNode_Int32_CancellationToken = new(this, "WaitUntilCountOrTimeoutAsync", 0,  ReleactionUtils.GetType("System.Threading.SemaphoreSlim+TaskNode"), typeof(System.Int32), typeof(System.Threading.CancellationToken));
					r_RWaitUntilCountOrTimeoutAsync_TaskNode_Int32_CancellationToken.SetBelong(this.instance);
				}
				return r_RWaitUntilCountOrTimeoutAsync_TaskNode_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// Int32 Release()
		/// </summary>
		protected RMethod r_RRelease;
		public virtual RMethod RRelease
		{
			get
			{
				if(r_RRelease == null)
				{
					r_RRelease = new(this, "Release", 0);
					r_RRelease.SetBelong(this.instance);
				}
				return r_RRelease;
			}
		}

		/// <summary>
		/// Int32 Release(Int32)
		/// </summary>
		protected RMethod r_RRelease_Int32;
		public virtual RMethod RRelease_Int32
		{
			get
			{
				if(r_RRelease_Int32 == null)
				{
					r_RRelease_Int32 = new(this, "Release", 0, typeof(System.Int32));
					r_RRelease_Int32.SetBelong(this.instance);
				}
				return r_RRelease_Int32;
			}
		}

		/// <summary>
		/// Void QueueWaiterTask(TaskNode)
		/// </summary>
		protected static RMethod r_RQueueWaiterTask_TaskNode;
		public static RMethod RQueueWaiterTask_TaskNode
		{
			get
			{
				if(r_RQueueWaiterTask_TaskNode == null)
				{
					r_RQueueWaiterTask_TaskNode = new(typeof(System.Threading.SemaphoreSlim), "QueueWaiterTask", 0,  ReleactionUtils.GetType("System.Threading.SemaphoreSlim+TaskNode"));
					r_RQueueWaiterTask_TaskNode.SetBelong(null);
				}
				return r_RQueueWaiterTask_TaskNode;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_RDispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_RDispose_Boolean == null)
				{
					r_RDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_RDispose_Boolean.SetBelong(this.instance);
				}
				return r_RDispose_Boolean;
			}
		}

		/// <summary>
		/// Void CancellationTokenCanceledEventHandler(System.Object)
		/// </summary>
		protected static RMethod r_RCancellationTokenCanceledEventHandler_Object;
		public static RMethod RCancellationTokenCanceledEventHandler_Object
		{
			get
			{
				if(r_RCancellationTokenCanceledEventHandler_Object == null)
				{
					r_RCancellationTokenCanceledEventHandler_Object = new(typeof(System.Threading.SemaphoreSlim), "CancellationTokenCanceledEventHandler", 0, typeof(System.Object));
					r_RCancellationTokenCanceledEventHandler_Object.SetBelong(null);
				}
				return r_RCancellationTokenCanceledEventHandler_Object;
			}
		}

		/// <summary>
		/// Void CheckDispose()
		/// </summary>
		protected RMethod r_RCheckDispose;
		public virtual RMethod RCheckDispose
		{
			get
			{
				if(r_RCheckDispose == null)
				{
					r_RCheckDispose = new(this, "CheckDispose", 0);
					r_RCheckDispose.SetBelong(this.instance);
				}
				return r_RCheckDispose;
			}
		}

		/// <summary>
		/// System.String GetResourceString(System.String)
		/// </summary>
		protected static RMethod r_RGetResourceString_String;
		public static RMethod RGetResourceString_String
		{
			get
			{
				if(r_RGetResourceString_String == null)
				{
					r_RGetResourceString_String = new(typeof(System.Threading.SemaphoreSlim), "GetResourceString", 0, typeof(System.String));
					r_RGetResourceString_String.SetBelong(null);
				}
				return r_RGetResourceString_String;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}


        public RSemaphoreSlim() : base("System.Threading.SemaphoreSlim")
        {
        }

        public RSemaphoreSlim(System.Object instance) : base("System.Threading.SemaphoreSlim")
		{
            SetInstance(instance);
		}

        public RSemaphoreSlim(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSemaphoreSlim(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Wait()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWait.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Wait(System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cancellationToken};
            var ___result = RWait_CancellationToken.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Wait(System.TimeSpan  @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout};
            var ___result = RWait_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Wait(System.TimeSpan  @timeout, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout, @cancellationToken};
            var ___result = RWait_TimeSpan_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Wait(System.Int32  @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout};
            var ___result = RWait_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Wait(System.Int32  @millisecondsTimeout, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout, @cancellationToken};
            var ___result = RWait_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean WaitUntilCountOrTimeout(System.Int32  @millisecondsTimeout, System.UInt32  @startTime, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout, @startTime, @cancellationToken};
            var ___result = RWaitUntilCountOrTimeout_Int32_UInt32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Threading.Tasks.Task WaitAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWaitAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WaitAsync(System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cancellationToken};
            var ___result = RWaitAsync_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> WaitAsync(System.Int32  @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout};
            var ___result = RWaitAsync_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> WaitAsync(System.TimeSpan  @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout};
            var ___result = RWaitAsync_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> WaitAsync(System.TimeSpan  @timeout, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout, @cancellationToken};
            var ___result = RWaitAsync_TimeSpan_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> WaitAsync(System.Int32  @millisecondsTimeout, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout, @cancellationToken};
            var ___result = RWaitAsync_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Object CreateAndAddAsyncWaiter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateAndAddAsyncWaiter.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }




        public virtual System.Int32 Release()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRelease.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Release(System.Int32  @releaseCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@releaseCount};
            var ___result = RRelease_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean  @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void CancellationTokenCanceledEventHandler(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RCancellationTokenCanceledEventHandler_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckDispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckDispose.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String GetResourceString(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RGetResourceString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
