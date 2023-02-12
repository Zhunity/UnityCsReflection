
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
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_currentCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_currentCount
		{
			get
			{
				if(r_Fm_currentCount == null)
				{
					r_Fm_currentCount = new(this, "m_currentCount");
					r_Fm_currentCount.SetBelong(this.instance);
				}
				return r_Fm_currentCount;
			}
		}

		/// <summary>
		/// System.Int32 m_maxCount
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_maxCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_maxCount
		{
			get
			{
				if(r_Fm_maxCount == null)
				{
					r_Fm_maxCount = new(this, "m_maxCount");
					r_Fm_maxCount.SetBelong(this.instance);
				}
				return r_Fm_maxCount;
			}
		}

		/// <summary>
		/// System.Int32 m_waitCount
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_waitCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_waitCount
		{
			get
			{
				if(r_Fm_waitCount == null)
				{
					r_Fm_waitCount = new(this, "m_waitCount");
					r_Fm_waitCount.SetBelong(this.instance);
				}
				return r_Fm_waitCount;
			}
		}

		/// <summary>
		/// System.Object m_lockObj
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RObject r_Fm_lockObj;
		public virtual SMFrame.Editor.Refleaction.RSystem.RObject RFm_lockObj
		{
			get
			{
				if(r_Fm_lockObj == null)
				{
					r_Fm_lockObj = new(this, "m_lockObj");
					r_Fm_lockObj.SetBelong(this.instance);
				}
				return r_Fm_lockObj;
			}
		}

		/// <summary>
		/// System.Threading.ManualResetEvent m_waitHandle
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RThreading.RManualResetEvent r_Fm_waitHandle;
		public virtual SMFrame.Editor.Refleaction.RSystem.RThreading.RManualResetEvent RFm_waitHandle
		{
			get
			{
				if(r_Fm_waitHandle == null)
				{
					r_Fm_waitHandle = new(this, "m_waitHandle");
					r_Fm_waitHandle.SetBelong(this.instance);
				}
				return r_Fm_waitHandle;
			}
		}

		/// <summary>
		/// System.Threading.SemaphoreSlim+TaskNode m_asyncHead
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RThreading.RSemaphoreSlim.RTaskNode r_Fm_asyncHead;
		public virtual SMFrame.Editor.Refleaction.RSystem.RThreading.RSemaphoreSlim.RTaskNode RFm_asyncHead
		{
			get
			{
				if(r_Fm_asyncHead == null)
				{
					r_Fm_asyncHead = new(this, "m_asyncHead");
					r_Fm_asyncHead.SetBelong(this.instance);
				}
				return r_Fm_asyncHead;
			}
		}

		/// <summary>
		/// System.Threading.SemaphoreSlim+TaskNode m_asyncTail
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RThreading.RSemaphoreSlim.RTaskNode r_Fm_asyncTail;
		public virtual SMFrame.Editor.Refleaction.RSystem.RThreading.RSemaphoreSlim.RTaskNode RFm_asyncTail
		{
			get
			{
				if(r_Fm_asyncTail == null)
				{
					r_Fm_asyncTail = new(this, "m_asyncTail");
					r_Fm_asyncTail.SetBelong(this.instance);
				}
				return r_Fm_asyncTail;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] s_trueTask
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTask<SMFrame.Editor.Refleaction.RSystem.RBoolean> r_Fs_trueTask;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTask<SMFrame.Editor.Refleaction.RSystem.RBoolean> RFs_trueTask
		{
			get
			{
				if(r_Fs_trueTask == null)
				{
					r_Fs_trueTask = new(typeof(System.Threading.SemaphoreSlim), "s_trueTask");
					r_Fs_trueTask.SetBelong(null);
				}
				return r_Fs_trueTask;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] s_falseTask
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTask<SMFrame.Editor.Refleaction.RSystem.RBoolean> r_Fs_falseTask;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTask<SMFrame.Editor.Refleaction.RSystem.RBoolean> RFs_falseTask
		{
			get
			{
				if(r_Fs_falseTask == null)
				{
					r_Fs_falseTask = new(typeof(System.Threading.SemaphoreSlim), "s_falseTask");
					r_Fs_falseTask.SetBelong(null);
				}
				return r_Fs_falseTask;
			}
		}

		/// <summary>
		/// System.Int32 NO_MAXIMUM
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RInt32 r_FNO_MAXIMUM;
		public static SMFrame.Editor.Refleaction.RSystem.RInt32 RFNO_MAXIMUM
		{
			get
			{
				if(r_FNO_MAXIMUM == null)
				{
					r_FNO_MAXIMUM = new(typeof(System.Threading.SemaphoreSlim), "NO_MAXIMUM");
					r_FNO_MAXIMUM.SetBelong(null);
				}
				return r_FNO_MAXIMUM;
			}
		}

		/// <summary>
		/// System.Action`1[System.Object] s_cancellationTokenCanceledEventHandler
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RObject> r_Fs_cancellationTokenCanceledEventHandler;
		public static SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RObject> RFs_cancellationTokenCanceledEventHandler
		{
			get
			{
				if(r_Fs_cancellationTokenCanceledEventHandler == null)
				{
					r_Fs_cancellationTokenCanceledEventHandler = new(typeof(System.Threading.SemaphoreSlim), "s_cancellationTokenCanceledEventHandler");
					r_Fs_cancellationTokenCanceledEventHandler.SetBelong(null);
				}
				return r_Fs_cancellationTokenCanceledEventHandler;
			}
		}

		/// <summary>
		/// Int32 CurrentCount
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PCurrentCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPCurrentCount
		{
			get
			{
				if(r_PCurrentCount == null)
				{
					r_PCurrentCount = new(this, "CurrentCount", -1);
					r_PCurrentCount.SetBelong(this.instance);
				}
				return r_PCurrentCount;
			}
		}

		/// <summary>
		/// System.Threading.WaitHandle AvailableWaitHandle
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RThreading.RWaitHandle r_PAvailableWaitHandle;
		public virtual SMFrame.Editor.Refleaction.RSystem.RThreading.RWaitHandle RPAvailableWaitHandle
		{
			get
			{
				if(r_PAvailableWaitHandle == null)
				{
					r_PAvailableWaitHandle = new(this, "AvailableWaitHandle", -1);
					r_PAvailableWaitHandle.SetBelong(this.instance);
				}
				return r_PAvailableWaitHandle;
			}
		}

		/// <summary>
		/// Void Wait()
		/// </summary>
		protected RMethod r_MWait;
		public virtual RMethod RMWait
		{
			get
			{
				if(r_MWait == null)
				{
					r_MWait = new(this, "Wait", 0);
					r_MWait.SetBelong(this.instance);
				}
				return r_MWait;
			}
		}

		/// <summary>
		/// Void Wait(System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MWait_CancellationToken;
		public virtual RMethod RMWait_CancellationToken
		{
			get
			{
				if(r_MWait_CancellationToken == null)
				{
					r_MWait_CancellationToken = new(this, "Wait", 0, typeof(System.Threading.CancellationToken));
					r_MWait_CancellationToken.SetBelong(this.instance);
				}
				return r_MWait_CancellationToken;
			}
		}

		/// <summary>
		/// Boolean Wait(System.TimeSpan)
		/// </summary>
		protected RMethod r_MWait_TimeSpan;
		public virtual RMethod RMWait_TimeSpan
		{
			get
			{
				if(r_MWait_TimeSpan == null)
				{
					r_MWait_TimeSpan = new(this, "Wait", 0, typeof(System.TimeSpan));
					r_MWait_TimeSpan.SetBelong(this.instance);
				}
				return r_MWait_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean Wait(System.TimeSpan, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MWait_TimeSpan_CancellationToken;
		public virtual RMethod RMWait_TimeSpan_CancellationToken
		{
			get
			{
				if(r_MWait_TimeSpan_CancellationToken == null)
				{
					r_MWait_TimeSpan_CancellationToken = new(this, "Wait", 0, typeof(System.TimeSpan), typeof(System.Threading.CancellationToken));
					r_MWait_TimeSpan_CancellationToken.SetBelong(this.instance);
				}
				return r_MWait_TimeSpan_CancellationToken;
			}
		}

		/// <summary>
		/// Boolean Wait(Int32)
		/// </summary>
		protected RMethod r_MWait_Int32;
		public virtual RMethod RMWait_Int32
		{
			get
			{
				if(r_MWait_Int32 == null)
				{
					r_MWait_Int32 = new(this, "Wait", 0, typeof(System.Int32));
					r_MWait_Int32.SetBelong(this.instance);
				}
				return r_MWait_Int32;
			}
		}

		/// <summary>
		/// Boolean Wait(Int32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MWait_Int32_CancellationToken;
		public virtual RMethod RMWait_Int32_CancellationToken
		{
			get
			{
				if(r_MWait_Int32_CancellationToken == null)
				{
					r_MWait_Int32_CancellationToken = new(this, "Wait", 0, typeof(System.Int32), typeof(System.Threading.CancellationToken));
					r_MWait_Int32_CancellationToken.SetBelong(this.instance);
				}
				return r_MWait_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// Boolean WaitUntilCountOrTimeout(Int32, UInt32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MWaitUntilCountOrTimeout_Int32_UInt32_CancellationToken;
		public virtual RMethod RMWaitUntilCountOrTimeout_Int32_UInt32_CancellationToken
		{
			get
			{
				if(r_MWaitUntilCountOrTimeout_Int32_UInt32_CancellationToken == null)
				{
					r_MWaitUntilCountOrTimeout_Int32_UInt32_CancellationToken = new(this, "WaitUntilCountOrTimeout", 0, typeof(System.Int32), typeof(System.UInt32), typeof(System.Threading.CancellationToken));
					r_MWaitUntilCountOrTimeout_Int32_UInt32_CancellationToken.SetBelong(this.instance);
				}
				return r_MWaitUntilCountOrTimeout_Int32_UInt32_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WaitAsync()
		/// </summary>
		protected RMethod r_MWaitAsync;
		public virtual RMethod RMWaitAsync
		{
			get
			{
				if(r_MWaitAsync == null)
				{
					r_MWaitAsync = new(this, "WaitAsync", 0);
					r_MWaitAsync.SetBelong(this.instance);
				}
				return r_MWaitAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WaitAsync(System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MWaitAsync_CancellationToken;
		public virtual RMethod RMWaitAsync_CancellationToken
		{
			get
			{
				if(r_MWaitAsync_CancellationToken == null)
				{
					r_MWaitAsync_CancellationToken = new(this, "WaitAsync", 0, typeof(System.Threading.CancellationToken));
					r_MWaitAsync_CancellationToken.SetBelong(this.instance);
				}
				return r_MWaitAsync_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] WaitAsync(Int32)
		/// </summary>
		protected RMethod r_MWaitAsync_Int32;
		public virtual RMethod RMWaitAsync_Int32
		{
			get
			{
				if(r_MWaitAsync_Int32 == null)
				{
					r_MWaitAsync_Int32 = new(this, "WaitAsync", 0, typeof(System.Int32));
					r_MWaitAsync_Int32.SetBelong(this.instance);
				}
				return r_MWaitAsync_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] WaitAsync(System.TimeSpan)
		/// </summary>
		protected RMethod r_MWaitAsync_TimeSpan;
		public virtual RMethod RMWaitAsync_TimeSpan
		{
			get
			{
				if(r_MWaitAsync_TimeSpan == null)
				{
					r_MWaitAsync_TimeSpan = new(this, "WaitAsync", 0, typeof(System.TimeSpan));
					r_MWaitAsync_TimeSpan.SetBelong(this.instance);
				}
				return r_MWaitAsync_TimeSpan;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] WaitAsync(System.TimeSpan, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MWaitAsync_TimeSpan_CancellationToken;
		public virtual RMethod RMWaitAsync_TimeSpan_CancellationToken
		{
			get
			{
				if(r_MWaitAsync_TimeSpan_CancellationToken == null)
				{
					r_MWaitAsync_TimeSpan_CancellationToken = new(this, "WaitAsync", 0, typeof(System.TimeSpan), typeof(System.Threading.CancellationToken));
					r_MWaitAsync_TimeSpan_CancellationToken.SetBelong(this.instance);
				}
				return r_MWaitAsync_TimeSpan_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] WaitAsync(Int32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MWaitAsync_Int32_CancellationToken;
		public virtual RMethod RMWaitAsync_Int32_CancellationToken
		{
			get
			{
				if(r_MWaitAsync_Int32_CancellationToken == null)
				{
					r_MWaitAsync_Int32_CancellationToken = new(this, "WaitAsync", 0, typeof(System.Int32), typeof(System.Threading.CancellationToken));
					r_MWaitAsync_Int32_CancellationToken.SetBelong(this.instance);
				}
				return r_MWaitAsync_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// TaskNode CreateAndAddAsyncWaiter()
		/// </summary>
		protected RMethod r_MCreateAndAddAsyncWaiter;
		public virtual RMethod RMCreateAndAddAsyncWaiter
		{
			get
			{
				if(r_MCreateAndAddAsyncWaiter == null)
				{
					r_MCreateAndAddAsyncWaiter = new(this, "CreateAndAddAsyncWaiter", 0);
					r_MCreateAndAddAsyncWaiter.SetBelong(this.instance);
				}
				return r_MCreateAndAddAsyncWaiter;
			}
		}

		/// <summary>
		/// Boolean RemoveAsyncWaiter(TaskNode)
		/// </summary>
		protected RMethod r_MRemoveAsyncWaiter_TaskNode;
		public virtual RMethod RMRemoveAsyncWaiter_TaskNode
		{
			get
			{
				if(r_MRemoveAsyncWaiter_TaskNode == null)
				{
					r_MRemoveAsyncWaiter_TaskNode = new(this, "RemoveAsyncWaiter", 0,  ReflectionUtils.GetType("System.Threading.SemaphoreSlim+TaskNode"));
					r_MRemoveAsyncWaiter_TaskNode.SetBelong(this.instance);
				}
				return r_MRemoveAsyncWaiter_TaskNode;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] WaitUntilCountOrTimeoutAsync(TaskNode, Int32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MWaitUntilCountOrTimeoutAsync_TaskNode_Int32_CancellationToken;
		public virtual RMethod RMWaitUntilCountOrTimeoutAsync_TaskNode_Int32_CancellationToken
		{
			get
			{
				if(r_MWaitUntilCountOrTimeoutAsync_TaskNode_Int32_CancellationToken == null)
				{
					r_MWaitUntilCountOrTimeoutAsync_TaskNode_Int32_CancellationToken = new(this, "WaitUntilCountOrTimeoutAsync", 0,  ReflectionUtils.GetType("System.Threading.SemaphoreSlim+TaskNode"), typeof(System.Int32), typeof(System.Threading.CancellationToken));
					r_MWaitUntilCountOrTimeoutAsync_TaskNode_Int32_CancellationToken.SetBelong(this.instance);
				}
				return r_MWaitUntilCountOrTimeoutAsync_TaskNode_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// Int32 Release()
		/// </summary>
		protected RMethod r_MRelease;
		public virtual RMethod RMRelease
		{
			get
			{
				if(r_MRelease == null)
				{
					r_MRelease = new(this, "Release", 0);
					r_MRelease.SetBelong(this.instance);
				}
				return r_MRelease;
			}
		}

		/// <summary>
		/// Int32 Release(Int32)
		/// </summary>
		protected RMethod r_MRelease_Int32;
		public virtual RMethod RMRelease_Int32
		{
			get
			{
				if(r_MRelease_Int32 == null)
				{
					r_MRelease_Int32 = new(this, "Release", 0, typeof(System.Int32));
					r_MRelease_Int32.SetBelong(this.instance);
				}
				return r_MRelease_Int32;
			}
		}

		/// <summary>
		/// Void QueueWaiterTask(TaskNode)
		/// </summary>
		protected static RMethod r_MQueueWaiterTask_TaskNode;
		public static RMethod RMQueueWaiterTask_TaskNode
		{
			get
			{
				if(r_MQueueWaiterTask_TaskNode == null)
				{
					r_MQueueWaiterTask_TaskNode = new(typeof(System.Threading.SemaphoreSlim), "QueueWaiterTask", 0,  ReflectionUtils.GetType("System.Threading.SemaphoreSlim+TaskNode"));
					r_MQueueWaiterTask_TaskNode.SetBelong(null);
				}
				return r_MQueueWaiterTask_TaskNode;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
					r_MDispose.SetBelong(this.instance);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_MDispose_Boolean;
		public virtual RMethod RMDispose_Boolean
		{
			get
			{
				if(r_MDispose_Boolean == null)
				{
					r_MDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_MDispose_Boolean.SetBelong(this.instance);
				}
				return r_MDispose_Boolean;
			}
		}

		/// <summary>
		/// Void CancellationTokenCanceledEventHandler(System.Object)
		/// </summary>
		protected static RMethod r_MCancellationTokenCanceledEventHandler_Object;
		public static RMethod RMCancellationTokenCanceledEventHandler_Object
		{
			get
			{
				if(r_MCancellationTokenCanceledEventHandler_Object == null)
				{
					r_MCancellationTokenCanceledEventHandler_Object = new(typeof(System.Threading.SemaphoreSlim), "CancellationTokenCanceledEventHandler", 0, typeof(System.Object));
					r_MCancellationTokenCanceledEventHandler_Object.SetBelong(null);
				}
				return r_MCancellationTokenCanceledEventHandler_Object;
			}
		}

		/// <summary>
		/// Void CheckDispose()
		/// </summary>
		protected RMethod r_MCheckDispose;
		public virtual RMethod RMCheckDispose
		{
			get
			{
				if(r_MCheckDispose == null)
				{
					r_MCheckDispose = new(this, "CheckDispose", 0);
					r_MCheckDispose.SetBelong(this.instance);
				}
				return r_MCheckDispose;
			}
		}

		/// <summary>
		/// System.String GetResourceString(System.String)
		/// </summary>
		protected static RMethod r_MGetResourceString_String;
		public static RMethod RMGetResourceString_String
		{
			get
			{
				if(r_MGetResourceString_String == null)
				{
					r_MGetResourceString_String = new(typeof(System.Threading.SemaphoreSlim), "GetResourceString", 0, typeof(System.String));
					r_MGetResourceString_String.SetBelong(null);
				}
				return r_MGetResourceString_String;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_MEquals_Object;
		public virtual RMethod RMEquals_Object
		{
			get
			{
				if(r_MEquals_Object == null)
				{
					r_MEquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_MEquals_Object.SetBelong(this.instance);
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_MFinalize;
		public virtual RMethod RMFinalize
		{
			get
			{
				if(r_MFinalize == null)
				{
					r_MFinalize = new(this, "Finalize", 0);
					r_MFinalize.SetBelong(this.instance);
				}
				return r_MFinalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_MGetHashCode;
		public virtual RMethod RMGetHashCode
		{
			get
			{
				if(r_MGetHashCode == null)
				{
					r_MGetHashCode = new(this, "GetHashCode", 0);
					r_MGetHashCode.SetBelong(this.instance);
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_MGetType;
		public virtual RMethod RMGetType
		{
			get
			{
				if(r_MGetType == null)
				{
					r_MGetType = new(this, "GetType", 0);
					r_MGetType.SetBelong(this.instance);
				}
				return r_MGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MMemberwiseClone;
		public virtual RMethod RMMemberwiseClone
		{
			get
			{
				if(r_MMemberwiseClone == null)
				{
					r_MMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_MToString;
		public virtual RMethod RMToString
		{
			get
			{
				if(r_MToString == null)
				{
					r_MToString = new(this, "ToString", 0);
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
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
            var ___result = RMWait.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Wait(System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cancellationToken};
            var ___result = RMWait_CancellationToken.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Wait(System.TimeSpan @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout};
            var ___result = RMWait_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Wait(System.TimeSpan @timeout, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout, @cancellationToken};
            var ___result = RMWait_TimeSpan_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Wait(System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout};
            var ___result = RMWait_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Wait(System.Int32 @millisecondsTimeout, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout, @cancellationToken};
            var ___result = RMWait_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean WaitUntilCountOrTimeout(System.Int32 @millisecondsTimeout, System.UInt32 @startTime, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout, @startTime, @cancellationToken};
            var ___result = RMWaitUntilCountOrTimeout_Int32_UInt32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Threading.Tasks.Task WaitAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMWaitAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WaitAsync(System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cancellationToken};
            var ___result = RMWaitAsync_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> WaitAsync(System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout};
            var ___result = RMWaitAsync_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> WaitAsync(System.TimeSpan @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout};
            var ___result = RMWaitAsync_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> WaitAsync(System.TimeSpan @timeout, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout, @cancellationToken};
            var ___result = RMWaitAsync_TimeSpan_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> WaitAsync(System.Int32 @millisecondsTimeout, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@millisecondsTimeout, @cancellationToken};
            var ___result = RMWaitAsync_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual SMFrame.Editor.Refleaction.RSystem.RThreading.RSemaphoreSlim.RTaskNode CreateAndAddAsyncWaiter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateAndAddAsyncWaiter.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RSystem.RThreading.RSemaphoreSlim.RTaskNode(___result);
        }


        public virtual System.Boolean RemoveAsyncWaiter(SMFrame.Editor.Refleaction.RSystem.RThreading.RSemaphoreSlim.RTaskNode @task)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task.Value};
            var ___result = RMRemoveAsyncWaiter_TaskNode.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> WaitUntilCountOrTimeoutAsync(SMFrame.Editor.Refleaction.RSystem.RThreading.RSemaphoreSlim.RTaskNode @asyncWaiter, System.Int32 @millisecondsTimeout, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncWaiter.Value, @millisecondsTimeout, @cancellationToken};
            var ___result = RMWaitUntilCountOrTimeoutAsync_TaskNode_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Int32 Release()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRelease.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Release(System.Int32 @releaseCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@releaseCount};
            var ___result = RMRelease_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void QueueWaiterTask(SMFrame.Editor.Refleaction.RSystem.RThreading.RSemaphoreSlim.RTaskNode @waiterTask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waiterTask.Value};
            var ___result = RMQueueWaiterTask_TaskNode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RMDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void CancellationTokenCanceledEventHandler(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMCancellationTokenCanceledEventHandler_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckDispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCheckDispose.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String GetResourceString(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMGetResourceString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
