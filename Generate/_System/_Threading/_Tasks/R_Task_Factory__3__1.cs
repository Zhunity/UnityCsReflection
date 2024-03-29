
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading.RTasks
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Threading.Tasks.TaskFactory`1
	/// </summary>
    public partial class RTaskFactory<TResult> : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Threading.Tasks.TaskFactory`1").MakeGenericType(ReflectionUtils.GetType(typeof(TResult)));
            }
        }

        public RTaskFactory() : base("System.Threading.Tasks.TaskFactory`1")
        {
        }

        public RTaskFactory(System.Object instance) : base("System.Threading.Tasks.TaskFactory`1")
		{
            SetInstance(instance);
		}

        public RTaskFactory(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTaskFactory(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Threading.CancellationToken m_defaultCancellationToken
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationToken r_Fm_defaultCancellationToken;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationToken RFm_defaultCancellationToken
		{
			get
			{
				if(r_Fm_defaultCancellationToken == null)
				{
					r_Fm_defaultCancellationToken = new(this, "m_defaultCancellationToken");
				}
				return r_Fm_defaultCancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler m_defaultScheduler
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskScheduler r_Fm_defaultScheduler;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskScheduler RFm_defaultScheduler
		{
			get
			{
				if(r_Fm_defaultScheduler == null)
				{
					r_Fm_defaultScheduler = new(this, "m_defaultScheduler");
				}
				return r_Fm_defaultScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskCreationOptions m_defaultCreationOptions
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskCreationOptions r_Fm_defaultCreationOptions;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskCreationOptions RFm_defaultCreationOptions
		{
			get
			{
				if(r_Fm_defaultCreationOptions == null)
				{
					r_Fm_defaultCreationOptions = new(this, "m_defaultCreationOptions");
				}
				return r_Fm_defaultCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskContinuationOptions m_defaultContinuationOptions
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions r_Fm_defaultContinuationOptions;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions RFm_defaultContinuationOptions
		{
			get
			{
				if(r_Fm_defaultContinuationOptions == null)
				{
					r_Fm_defaultContinuationOptions = new(this, "m_defaultContinuationOptions");
				}
				return r_Fm_defaultContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler DefaultScheduler
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskScheduler r_PDefaultScheduler;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskScheduler RPDefaultScheduler
		{
			get
			{
				if(r_PDefaultScheduler == null)
				{
					r_PDefaultScheduler = new(this, "DefaultScheduler", -1);
				}
				return r_PDefaultScheduler;
			}
		}

		/// <summary>
		/// System.Threading.CancellationToken CancellationToken
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationToken r_PCancellationToken;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationToken RPCancellationToken
		{
			get
			{
				if(r_PCancellationToken == null)
				{
					r_PCancellationToken = new(this, "CancellationToken", -1);
				}
				return r_PCancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler Scheduler
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskScheduler r_PScheduler;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskScheduler RPScheduler
		{
			get
			{
				if(r_PScheduler == null)
				{
					r_PScheduler = new(this, "Scheduler", -1);
				}
				return r_PScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskCreationOptions CreationOptions
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskCreationOptions r_PCreationOptions;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskCreationOptions RPCreationOptions
		{
			get
			{
				if(r_PCreationOptions == null)
				{
					r_PCreationOptions = new(this, "CreationOptions", -1);
				}
				return r_PCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskContinuationOptions ContinuationOptions
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions r_PContinuationOptions;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions RPContinuationOptions
		{
			get
			{
				if(r_PContinuationOptions == null)
				{
					r_PContinuationOptions = new(this, "ContinuationOptions", -1);
				}
				return r_PContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler GetDefaultScheduler(System.Threading.Tasks.Task)
		/// </summary>
		protected RMethod r_MGetDefaultScheduler_Task;
		public virtual RMethod RMGetDefaultScheduler_Task
		{
			get
			{
				if(r_MGetDefaultScheduler_Task == null)
				{
					r_MGetDefaultScheduler_Task = new(this, "GetDefaultScheduler", 0, typeof(System.Threading.Tasks.Task));
				}
				return r_MGetDefaultScheduler_Task;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] StartNew(System.Func`1[TResult])
		/// </summary>
		protected RMethod r_MStartNew_Func_d_TResult_p_;
		public virtual RMethod RMStartNew_Func_d_TResult_p_
		{
			get
			{
				if(r_MStartNew_Func_d_TResult_p_ == null)
				{
					r_MStartNew_Func_d_TResult_p_ = new(this, "StartNew", 0,  ReflectionUtils.GetType("System.Func`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MStartNew_Func_d_TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] StartNew(System.Func`1[TResult], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MStartNew_Func_d_TResult_p__CancellationToken;
		public virtual RMethod RMStartNew_Func_d_TResult_p__CancellationToken
		{
			get
			{
				if(r_MStartNew_Func_d_TResult_p__CancellationToken == null)
				{
					r_MStartNew_Func_d_TResult_p__CancellationToken = new(this, "StartNew", 0,  ReflectionUtils.GetType("System.Func`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken));
				}
				return r_MStartNew_Func_d_TResult_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] StartNew(System.Func`1[TResult], System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_MStartNew_Func_d_TResult_p__TaskCreationOptions;
		public virtual RMethod RMStartNew_Func_d_TResult_p__TaskCreationOptions
		{
			get
			{
				if(r_MStartNew_Func_d_TResult_p__TaskCreationOptions == null)
				{
					r_MStartNew_Func_d_TResult_p__TaskCreationOptions = new(this, "StartNew", 0,  ReflectionUtils.GetType("System.Func`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskCreationOptions));
				}
				return r_MStartNew_Func_d_TResult_p__TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] StartNew(System.Func`1[TResult], System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MStartNew_Func_d_TResult_p__CancellationToken_TaskCreationOptions_TaskScheduler;
		public virtual RMethod RMStartNew_Func_d_TResult_p__CancellationToken_TaskCreationOptions_TaskScheduler
		{
			get
			{
				if(r_MStartNew_Func_d_TResult_p__CancellationToken_TaskCreationOptions_TaskScheduler == null)
				{
					r_MStartNew_Func_d_TResult_p__CancellationToken_TaskCreationOptions_TaskScheduler = new(this, "StartNew", 0,  ReflectionUtils.GetType("System.Func`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskCreationOptions), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MStartNew_Func_d_TResult_p__CancellationToken_TaskCreationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] StartNew(System.Func`2[System.Object,TResult], System.Object)
		/// </summary>
		protected RMethod r_MStartNew_Func_d_Object_TResult_p__Object;
		public virtual RMethod RMStartNew_Func_d_Object_TResult_p__Object
		{
			get
			{
				if(r_MStartNew_Func_d_Object_TResult_p__Object == null)
				{
					r_MStartNew_Func_d_Object_TResult_p__Object = new(this, "StartNew", 0,  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object));
				}
				return r_MStartNew_Func_d_Object_TResult_p__Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] StartNew(System.Func`2[System.Object,TResult], System.Object, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MStartNew_Func_d_Object_TResult_p__Object_CancellationToken;
		public virtual RMethod RMStartNew_Func_d_Object_TResult_p__Object_CancellationToken
		{
			get
			{
				if(r_MStartNew_Func_d_Object_TResult_p__Object_CancellationToken == null)
				{
					r_MStartNew_Func_d_Object_TResult_p__Object_CancellationToken = new(this, "StartNew", 0,  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.CancellationToken));
				}
				return r_MStartNew_Func_d_Object_TResult_p__Object_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] StartNew(System.Func`2[System.Object,TResult], System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_MStartNew_Func_d_Object_TResult_p__Object_TaskCreationOptions;
		public virtual RMethod RMStartNew_Func_d_Object_TResult_p__Object_TaskCreationOptions
		{
			get
			{
				if(r_MStartNew_Func_d_Object_TResult_p__Object_TaskCreationOptions == null)
				{
					r_MStartNew_Func_d_Object_TResult_p__Object_TaskCreationOptions = new(this, "StartNew", 0,  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
				}
				return r_MStartNew_Func_d_Object_TResult_p__Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] StartNew(System.Func`2[System.Object,TResult], System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MStartNew_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler;
		public virtual RMethod RMStartNew_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler
		{
			get
			{
				if(r_MStartNew_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler == null)
				{
					r_MStartNew_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler = new(this, "StartNew", 0,  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskCreationOptions), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MStartNew_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// Void FromAsyncCoreLogic(System.IAsyncResult, System.Func`2[System.IAsyncResult,TResult], System.Action`1[System.IAsyncResult], System.Threading.Tasks.Task`1[TResult], Boolean)
		/// </summary>
		protected static RMethod r_MFromAsyncCoreLogic_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Task_d_TResult_p__Boolean;
		public static RMethod RMFromAsyncCoreLogic_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Task_d_TResult_p__Boolean
		{
			get
			{
				if(r_MFromAsyncCoreLogic_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Task_d_TResult_p__Boolean == null)
				{
					r_MFromAsyncCoreLogic_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Task_d_TResult_p__Boolean = new(Type, "FromAsyncCoreLogic", 0, typeof(System.IAsyncResult),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(System.IAsyncResult)),  ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Boolean));
				}
				return r_MFromAsyncCoreLogic_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Task_d_TResult_p__Boolean;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync(System.IAsyncResult, System.Func`2[System.IAsyncResult,TResult])
		/// </summary>
		protected RMethod r_MFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p_;
		public virtual RMethod RMFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p_
		{
			get
			{
				if(r_MFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p_ == null)
				{
					r_MFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p_ = new(this, "FromAsync", 0, typeof(System.IAsyncResult),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)));
				}
				return r_MFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync(System.IAsyncResult, System.Func`2[System.IAsyncResult,TResult], System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_MFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions;
		public virtual RMethod RMFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions
		{
			get
			{
				if(r_MFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions == null)
				{
					r_MFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions = new(this, "FromAsync", 0, typeof(System.IAsyncResult),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskCreationOptions));
				}
				return r_MFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync(System.IAsyncResult, System.Func`2[System.IAsyncResult,TResult], System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions_TaskScheduler;
		public virtual RMethod RMFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions_TaskScheduler
		{
			get
			{
				if(r_MFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions_TaskScheduler == null)
				{
					r_MFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions_TaskScheduler = new(this, "FromAsync", 0, typeof(System.IAsyncResult),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskCreationOptions), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsyncImpl(System.IAsyncResult, System.Func`2[System.IAsyncResult,TResult], System.Action`1[System.IAsyncResult], System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected static RMethod r_MFromAsyncImpl_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TaskCreationOptions_TaskScheduler;
		public static RMethod RMFromAsyncImpl_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TaskCreationOptions_TaskScheduler
		{
			get
			{
				if(r_MFromAsyncImpl_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TaskCreationOptions_TaskScheduler == null)
				{
					r_MFromAsyncImpl_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TaskCreationOptions_TaskScheduler = new(Type, "FromAsyncImpl", 0, typeof(System.IAsyncResult),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(System.IAsyncResult)), typeof(System.Threading.Tasks.TaskCreationOptions), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MFromAsyncImpl_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TaskCreationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync(System.Func`3[System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], System.Object)
		/// </summary>
		protected RMethod r_MFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object;
		public virtual RMethod RMFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object
		{
			get
			{
				if(r_MFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object == null)
				{
					r_MFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object = new(this, "FromAsync", 0,  ReflectionUtils.GetType("System.Func`3").MakeGenericType(typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), typeof(System.Object));
				}
				return r_MFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync(System.Func`3[System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_MFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object_TaskCreationOptions;
		public virtual RMethod RMFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object_TaskCreationOptions
		{
			get
			{
				if(r_MFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object_TaskCreationOptions == null)
				{
					r_MFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object_TaskCreationOptions = new(this, "FromAsync", 0,  ReflectionUtils.GetType("System.Func`3").MakeGenericType(typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
				}
				return r_MFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsyncImpl(System.Func`3[System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], System.Action`1[System.IAsyncResult], System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected static RMethod r_MFromAsyncImpl_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Object_TaskCreationOptions;
		public static RMethod RMFromAsyncImpl_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Object_TaskCreationOptions
		{
			get
			{
				if(r_MFromAsyncImpl_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Object_TaskCreationOptions == null)
				{
					r_MFromAsyncImpl_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Object_TaskCreationOptions = new(Type, "FromAsyncImpl", 0,  ReflectionUtils.GetType("System.Func`3").MakeGenericType(typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(System.IAsyncResult)), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
				}
				return r_MFromAsyncImpl_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync[TArg1](System.Func`4[TArg1,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], TArg1, System.Object)
		/// </summary>
		protected RMethod r_MFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object;
		public virtual RMethod RMFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object
		{
			get
			{
				if(r_MFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object == null)
				{
					r_MFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object = new(this, "FromAsync", 1,  ReflectionUtils.GetType("System.Func`4").MakeGenericType(Type.MakeGenericMethodParameter(0), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0), typeof(System.Object));
				}
				return r_MFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync[TArg1](System.Func`4[TArg1,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], TArg1, System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_MFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object_TaskCreationOptions;
		public virtual RMethod RMFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object_TaskCreationOptions
		{
			get
			{
				if(r_MFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object_TaskCreationOptions == null)
				{
					r_MFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object_TaskCreationOptions = new(this, "FromAsync", 1,  ReflectionUtils.GetType("System.Func`4").MakeGenericType(Type.MakeGenericMethodParameter(0), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
				}
				return r_MFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsyncImpl[TArg1](System.Func`4[TArg1,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], System.Action`1[System.IAsyncResult], TArg1, System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected static RMethod r_MFromAsyncImpl_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_Object_TaskCreationOptions;
		public static RMethod RMFromAsyncImpl_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_Object_TaskCreationOptions
		{
			get
			{
				if(r_MFromAsyncImpl_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_Object_TaskCreationOptions == null)
				{
					r_MFromAsyncImpl_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_Object_TaskCreationOptions = new(Type, "FromAsyncImpl", 1,  ReflectionUtils.GetType("System.Func`4").MakeGenericType(Type.MakeGenericMethodParameter(0), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(System.IAsyncResult)), Type.MakeGenericMethodParameter(0), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
				}
				return r_MFromAsyncImpl_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync[TArg1,TArg2](System.Func`5[TArg1,TArg2,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], TArg1, TArg2, System.Object)
		/// </summary>
		protected RMethod r_MFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object;
		public virtual RMethod RMFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object
		{
			get
			{
				if(r_MFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object == null)
				{
					r_MFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object = new(this, "FromAsync", 2,  ReflectionUtils.GetType("System.Func`5").MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), typeof(System.Object));
				}
				return r_MFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync[TArg1,TArg2](System.Func`5[TArg1,TArg2,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], TArg1, TArg2, System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_MFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object_TaskCreationOptions;
		public virtual RMethod RMFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object_TaskCreationOptions
		{
			get
			{
				if(r_MFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object_TaskCreationOptions == null)
				{
					r_MFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object_TaskCreationOptions = new(this, "FromAsync", 2,  ReflectionUtils.GetType("System.Func`5").MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
				}
				return r_MFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsyncImpl[TArg1,TArg2](System.Func`5[TArg1,TArg2,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], System.Action`1[System.IAsyncResult], TArg1, TArg2, System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected static RMethod r_MFromAsyncImpl_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object_TaskCreationOptions;
		public static RMethod RMFromAsyncImpl_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object_TaskCreationOptions
		{
			get
			{
				if(r_MFromAsyncImpl_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object_TaskCreationOptions == null)
				{
					r_MFromAsyncImpl_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object_TaskCreationOptions = new(Type, "FromAsyncImpl", 2,  ReflectionUtils.GetType("System.Func`5").MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(System.IAsyncResult)), Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
				}
				return r_MFromAsyncImpl_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync[TArg1,TArg2,TArg3](System.Func`6[TArg1,TArg2,TArg3,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], TArg1, TArg2, TArg3, System.Object)
		/// </summary>
		protected RMethod r_MFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object;
		public virtual RMethod RMFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object
		{
			get
			{
				if(r_MFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object == null)
				{
					r_MFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object = new(this, "FromAsync", 3,  ReflectionUtils.GetType("System.Func`6").MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), Type.MakeGenericMethodParameter(2), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), Type.MakeGenericMethodParameter(2), typeof(System.Object));
				}
				return r_MFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync[TArg1,TArg2,TArg3](System.Func`6[TArg1,TArg2,TArg3,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], TArg1, TArg2, TArg3, System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_MFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions;
		public virtual RMethod RMFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions
		{
			get
			{
				if(r_MFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions == null)
				{
					r_MFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions = new(this, "FromAsync", 3,  ReflectionUtils.GetType("System.Func`6").MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), Type.MakeGenericMethodParameter(2), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), Type.MakeGenericMethodParameter(2), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
				}
				return r_MFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsyncImpl[TArg1,TArg2,TArg3](System.Func`6[TArg1,TArg2,TArg3,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], System.Action`1[System.IAsyncResult], TArg1, TArg2, TArg3, System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected static RMethod r_MFromAsyncImpl_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions;
		public static RMethod RMFromAsyncImpl_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions
		{
			get
			{
				if(r_MFromAsyncImpl_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions == null)
				{
					r_MFromAsyncImpl_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions = new(Type, "FromAsyncImpl", 3,  ReflectionUtils.GetType("System.Func`6").MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), Type.MakeGenericMethodParameter(2), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(System.IAsyncResult)), Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), Type.MakeGenericMethodParameter(2), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
				}
				return r_MFromAsyncImpl_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsyncTrim[TInstance,TArgs](TInstance, TArgs, System.Func`5[TInstance,TArgs,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`3[TInstance,System.IAsyncResult,TResult])
		/// </summary>
		protected static RMethod r_MFromAsyncTrim_GTInstance_GTArgs_TInstance_TArgs_Func_d_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_p__Func_d_TInstance_IAsyncResult_TResult_p_;
		public static RMethod RMFromAsyncTrim_GTInstance_GTArgs_TInstance_TArgs_Func_d_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_p__Func_d_TInstance_IAsyncResult_TResult_p_
		{
			get
			{
				if(r_MFromAsyncTrim_GTInstance_GTArgs_TInstance_TArgs_Func_d_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_p__Func_d_TInstance_IAsyncResult_TResult_p_ == null)
				{
					r_MFromAsyncTrim_GTInstance_GTArgs_TInstance_TArgs_Func_d_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_p__Func_d_TInstance_IAsyncResult_TResult_p_ = new(Type, "FromAsyncTrim", 2, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1),  ReflectionUtils.GetType("System.Func`5").MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)),  ReflectionUtils.GetType("System.Func`3").MakeGenericType(Type.MakeGenericMethodParameter(0), typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)));
				}
				return r_MFromAsyncTrim_GTInstance_GTArgs_TInstance_TArgs_Func_d_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_p__Func_d_TInstance_IAsyncResult_TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] CreateCanceledTask(System.Threading.Tasks.TaskContinuationOptions, System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_MCreateCanceledTask_TaskContinuationOptions_CancellationToken;
		public static RMethod RMCreateCanceledTask_TaskContinuationOptions_CancellationToken
		{
			get
			{
				if(r_MCreateCanceledTask_TaskContinuationOptions_CancellationToken == null)
				{
					r_MCreateCanceledTask_TaskContinuationOptions_CancellationToken = new(Type, "CreateCanceledTask", 0, typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.CancellationToken));
				}
				return r_MCreateCanceledTask_TaskContinuationOptions_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAll(System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task[],TResult])
		/// </summary>
		protected RMethod r_MContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p_;
		public virtual RMethod RMContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p_
		{
			get
			{
				if(r_MContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p_ == null)
				{
					r_MContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p_ = new(this, "ContinueWhenAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Threading.Tasks.Task).MakeArrayType(), Type.MakeGenericMethodParameter(0)));
				}
				return r_MContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAll(System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task[],TResult], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken;
		public virtual RMethod RMContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken
		{
			get
			{
				if(r_MContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken == null)
				{
					r_MContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken = new(this, "ContinueWhenAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Threading.Tasks.Task).MakeArrayType(), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken));
				}
				return r_MContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAll(System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task[],TResult], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_MContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions;
		public virtual RMethod RMContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions
		{
			get
			{
				if(r_MContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions == null)
				{
					r_MContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions = new(this, "ContinueWhenAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Threading.Tasks.Task).MakeArrayType(), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskContinuationOptions));
				}
				return r_MContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAll(System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task[],TResult], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RMContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_MContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_MContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWhenAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Threading.Tasks.Task).MakeArrayType(), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAll[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult][],TResult])
		/// </summary>
		protected RMethod r_MContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p_;
		public virtual RMethod RMContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p_
		{
			get
			{
				if(r_MContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p_ == null)
				{
					r_MContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p_ = new(this, "ContinueWhenAll", 1,  ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(),  ReflectionUtils.GetType("System.Func`2").MakeGenericType( ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), Type.MakeGenericMethodParameter(0)));
				}
				return r_MContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAll[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult][],TResult], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken;
		public virtual RMethod RMContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken
		{
			get
			{
				if(r_MContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken == null)
				{
					r_MContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken = new(this, "ContinueWhenAll", 1,  ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(),  ReflectionUtils.GetType("System.Func`2").MakeGenericType( ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken));
				}
				return r_MContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAll[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult][],TResult], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_MContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions;
		public virtual RMethod RMContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions
		{
			get
			{
				if(r_MContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions == null)
				{
					r_MContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions = new(this, "ContinueWhenAll", 1,  ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(),  ReflectionUtils.GetType("System.Func`2").MakeGenericType( ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskContinuationOptions));
				}
				return r_MContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAll[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult][],TResult], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RMContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_MContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_MContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWhenAll", 1,  ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(),  ReflectionUtils.GetType("System.Func`2").MakeGenericType( ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAllImpl[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult][],TResult], System.Threading.Tasks.TaskContinuationOptions, System.Threading.CancellationToken, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected static RMethod r_MContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
		public static RMethod RMContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler
		{
			get
			{
				if(r_MContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler == null)
				{
					r_MContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler = new(Type, "ContinueWhenAllImpl", 1,  ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(),  ReflectionUtils.GetType("System.Func`2").MakeGenericType( ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAllImpl[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Action`1[System.Threading.Tasks.Task`1[TAntecedentResult][]], System.Threading.Tasks.TaskContinuationOptions, System.Threading.CancellationToken, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected static RMethod r_MContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
		public static RMethod RMContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__TaskContinuationOptions_CancellationToken_TaskScheduler
		{
			get
			{
				if(r_MContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__TaskContinuationOptions_CancellationToken_TaskScheduler == null)
				{
					r_MContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__TaskContinuationOptions_CancellationToken_TaskScheduler = new(Type, "ContinueWhenAllImpl", 1,  ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(),  ReflectionUtils.GetType("System.Action`1").MakeGenericType( ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType()), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAllImpl(System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task[],TResult], System.Threading.Tasks.TaskContinuationOptions, System.Threading.CancellationToken, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected static RMethod r_MContinueWhenAllImpl_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
		public static RMethod RMContinueWhenAllImpl_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler
		{
			get
			{
				if(r_MContinueWhenAllImpl_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler == null)
				{
					r_MContinueWhenAllImpl_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler = new(Type, "ContinueWhenAllImpl", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Threading.Tasks.Task).MakeArrayType(), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWhenAllImpl_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAllImpl(System.Threading.Tasks.Task[], System.Action`1[System.Threading.Tasks.Task[]], System.Threading.Tasks.TaskContinuationOptions, System.Threading.CancellationToken, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected static RMethod r_MContinueWhenAllImpl_TaskArray_Action_d_TaskArray_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
		public static RMethod RMContinueWhenAllImpl_TaskArray_Action_d_TaskArray_p__TaskContinuationOptions_CancellationToken_TaskScheduler
		{
			get
			{
				if(r_MContinueWhenAllImpl_TaskArray_Action_d_TaskArray_p__TaskContinuationOptions_CancellationToken_TaskScheduler == null)
				{
					r_MContinueWhenAllImpl_TaskArray_Action_d_TaskArray_p__TaskContinuationOptions_CancellationToken_TaskScheduler = new(Type, "ContinueWhenAllImpl", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(System.Threading.Tasks.Task).MakeArrayType()), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWhenAllImpl_TaskArray_Action_d_TaskArray_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAny(System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task,TResult])
		/// </summary>
		protected RMethod r_MContinueWhenAny_TaskArray_Func_d_Task_TResult_p_;
		public virtual RMethod RMContinueWhenAny_TaskArray_Func_d_Task_TResult_p_
		{
			get
			{
				if(r_MContinueWhenAny_TaskArray_Func_d_Task_TResult_p_ == null)
				{
					r_MContinueWhenAny_TaskArray_Func_d_Task_TResult_p_ = new(this, "ContinueWhenAny", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)));
				}
				return r_MContinueWhenAny_TaskArray_Func_d_Task_TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAny(System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task,TResult], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken;
		public virtual RMethod RMContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken
		{
			get
			{
				if(r_MContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken == null)
				{
					r_MContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken = new(this, "ContinueWhenAny", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken));
				}
				return r_MContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAny(System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task,TResult], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_MContinueWhenAny_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions;
		public virtual RMethod RMContinueWhenAny_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions
		{
			get
			{
				if(r_MContinueWhenAny_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions == null)
				{
					r_MContinueWhenAny_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions = new(this, "ContinueWhenAny", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskContinuationOptions));
				}
				return r_MContinueWhenAny_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAny(System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task,TResult], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RMContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_MContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_MContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWhenAny", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAny[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult],TResult])
		/// </summary>
		protected RMethod r_MContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p_;
		public virtual RMethod RMContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p_
		{
			get
			{
				if(r_MContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p_ == null)
				{
					r_MContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p_ = new(this, "ContinueWhenAny", 1,  ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(),  ReflectionUtils.GetType("System.Func`2").MakeGenericType( ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0)));
				}
				return r_MContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAny[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult],TResult], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken;
		public virtual RMethod RMContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken
		{
			get
			{
				if(r_MContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken == null)
				{
					r_MContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken = new(this, "ContinueWhenAny", 1,  ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(),  ReflectionUtils.GetType("System.Func`2").MakeGenericType( ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken));
				}
				return r_MContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAny[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult],TResult], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_MContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions;
		public virtual RMethod RMContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions
		{
			get
			{
				if(r_MContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions == null)
				{
					r_MContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions = new(this, "ContinueWhenAny", 1,  ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(),  ReflectionUtils.GetType("System.Func`2").MakeGenericType( ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskContinuationOptions));
				}
				return r_MContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAny[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult],TResult], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_MContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RMContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_MContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_MContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWhenAny", 1,  ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(),  ReflectionUtils.GetType("System.Func`2").MakeGenericType( ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAnyImpl(System.Threading.Tasks.Task[], System.Action`1[System.Threading.Tasks.Task], System.Threading.Tasks.TaskContinuationOptions, System.Threading.CancellationToken, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected static RMethod r_MContinueWhenAnyImpl_TaskArray_Action_d_Task_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
		public static RMethod RMContinueWhenAnyImpl_TaskArray_Action_d_Task_p__TaskContinuationOptions_CancellationToken_TaskScheduler
		{
			get
			{
				if(r_MContinueWhenAnyImpl_TaskArray_Action_d_Task_p__TaskContinuationOptions_CancellationToken_TaskScheduler == null)
				{
					r_MContinueWhenAnyImpl_TaskArray_Action_d_Task_p__TaskContinuationOptions_CancellationToken_TaskScheduler = new(Type, "ContinueWhenAnyImpl", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWhenAnyImpl_TaskArray_Action_d_Task_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAnyImpl(System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task,TResult], System.Threading.Tasks.TaskContinuationOptions, System.Threading.CancellationToken, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected static RMethod r_MContinueWhenAnyImpl_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
		public static RMethod RMContinueWhenAnyImpl_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler
		{
			get
			{
				if(r_MContinueWhenAnyImpl_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler == null)
				{
					r_MContinueWhenAnyImpl_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler = new(Type, "ContinueWhenAnyImpl", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWhenAnyImpl_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAnyImpl[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult],TResult], System.Threading.Tasks.TaskContinuationOptions, System.Threading.CancellationToken, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected static RMethod r_MContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
		public static RMethod RMContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler
		{
			get
			{
				if(r_MContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler == null)
				{
					r_MContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler = new(Type, "ContinueWhenAnyImpl", 1,  ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(),  ReflectionUtils.GetType("System.Func`2").MakeGenericType( ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAnyImpl[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Action`1[System.Threading.Tasks.Task`1[TAntecedentResult]], System.Threading.Tasks.TaskContinuationOptions, System.Threading.CancellationToken, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected static RMethod r_MContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__TaskContinuationOptions_CancellationToken_TaskScheduler;
		public static RMethod RMContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__TaskContinuationOptions_CancellationToken_TaskScheduler
		{
			get
			{
				if(r_MContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__TaskContinuationOptions_CancellationToken_TaskScheduler == null)
				{
					r_MContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__TaskContinuationOptions_CancellationToken_TaskScheduler = new(Type, "ContinueWhenAnyImpl", 1,  ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(),  ReflectionUtils.GetType("System.Action`1").MakeGenericType( ReflectionUtils.GetType("System.Threading.Tasks.Task`1").MakeGenericType(Type.MakeGenericMethodParameter(0))), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskScheduler));
				}
				return r_MContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__TaskContinuationOptions_CancellationToken_TaskScheduler;
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
				}
				return r_MToString;
			}
		}


        public virtual System.Threading.Tasks.TaskScheduler GetDefaultScheduler(System.Threading.Tasks.Task @currTask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@currTask};
            var ___result = RMGetDefaultScheduler_Task.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.TaskScheduler>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> StartNew(System.Func<TResult> @function)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@function};
            var ___result = RMStartNew_Func_d_TResult_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> StartNew(System.Func<TResult> @function, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@function, @cancellationToken};
            var ___result = RMStartNew_Func_d_TResult_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> StartNew(System.Func<TResult> @function, System.Threading.Tasks.TaskCreationOptions @creationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@function, @creationOptions};
            var ___result = RMStartNew_Func_d_TResult_p__TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> StartNew(System.Func<TResult> @function, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskCreationOptions @creationOptions, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@function, @cancellationToken, @creationOptions, @scheduler};
            var ___result = RMStartNew_Func_d_TResult_p__CancellationToken_TaskCreationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> StartNew(System.Func<System.Object, TResult> @function, System.Object @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@function, @state};
            var ___result = RMStartNew_Func_d_Object_TResult_p__Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> StartNew(System.Func<System.Object, TResult> @function, System.Object @state, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@function, @state, @cancellationToken};
            var ___result = RMStartNew_Func_d_Object_TResult_p__Object_CancellationToken.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> StartNew(System.Func<System.Object, TResult> @function, System.Object @state, System.Threading.Tasks.TaskCreationOptions @creationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@function, @state, @creationOptions};
            var ___result = RMStartNew_Func_d_Object_TResult_p__Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> StartNew(System.Func<System.Object, TResult> @function, System.Object @state, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskCreationOptions @creationOptions, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@function, @state, @cancellationToken, @creationOptions, @scheduler};
            var ___result = RMStartNew_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public static void FromAsyncCoreLogic(System.IAsyncResult @iar, System.Func<System.IAsyncResult, TResult> @endFunction, System.Action<System.IAsyncResult> @endAction, System.Threading.Tasks.Task<TResult> @promise, System.Boolean @requiresSynchronization)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iar, @endFunction, @endAction, @promise, @requiresSynchronization};
            var ___result = RMFromAsyncCoreLogic_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Task_d_TResult_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync(System.IAsyncResult @asyncResult, System.Func<System.IAsyncResult, TResult> @endMethod)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult, @endMethod};
            var ___result = RMFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync(System.IAsyncResult @asyncResult, System.Func<System.IAsyncResult, TResult> @endMethod, System.Threading.Tasks.TaskCreationOptions @creationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult, @endMethod, @creationOptions};
            var ___result = RMFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync(System.IAsyncResult @asyncResult, System.Func<System.IAsyncResult, TResult> @endMethod, System.Threading.Tasks.TaskCreationOptions @creationOptions, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult, @endMethod, @creationOptions, @scheduler};
            var ___result = RMFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public static System.Threading.Tasks.Task<TResult> FromAsyncImpl(System.IAsyncResult @asyncResult, System.Func<System.IAsyncResult, TResult> @endFunction, System.Action<System.IAsyncResult> @endAction, System.Threading.Tasks.TaskCreationOptions @creationOptions, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult, @endFunction, @endAction, @creationOptions, @scheduler};
            var ___result = RMFromAsyncImpl_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TaskCreationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync(System.Func<System.AsyncCallback, System.Object, System.IAsyncResult> @beginMethod, System.Func<System.IAsyncResult, TResult> @endMethod, System.Object @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@beginMethod, @endMethod, @state};
            var ___result = RMFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync(System.Func<System.AsyncCallback, System.Object, System.IAsyncResult> @beginMethod, System.Func<System.IAsyncResult, TResult> @endMethod, System.Object @state, System.Threading.Tasks.TaskCreationOptions @creationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@beginMethod, @endMethod, @state, @creationOptions};
            var ___result = RMFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public static System.Threading.Tasks.Task<TResult> FromAsyncImpl(System.Func<System.AsyncCallback, System.Object, System.IAsyncResult> @beginMethod, System.Func<System.IAsyncResult, TResult> @endFunction, System.Action<System.IAsyncResult> @endAction, System.Object @state, System.Threading.Tasks.TaskCreationOptions @creationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@beginMethod, @endFunction, @endAction, @state, @creationOptions};
            var ___result = RMFromAsyncImpl_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync<TArg1>(System.Func<TArg1, System.AsyncCallback, System.Object, System.IAsyncResult> @beginMethod, System.Func<System.IAsyncResult, TResult> @endMethod, TArg1 @arg1, System.Object @state)
        {

            var ___genericsType = new Type[] {typeof(TArg1)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @arg1, @state};
            var ___result = RMFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync<TArg1>(System.Func<TArg1, System.AsyncCallback, System.Object, System.IAsyncResult> @beginMethod, System.Func<System.IAsyncResult, TResult> @endMethod, TArg1 @arg1, System.Object @state, System.Threading.Tasks.TaskCreationOptions @creationOptions)
        {

            var ___genericsType = new Type[] {typeof(TArg1)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @arg1, @state, @creationOptions};
            var ___result = RMFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public static System.Threading.Tasks.Task<TResult> FromAsyncImpl<TArg1>(System.Func<TArg1, System.AsyncCallback, System.Object, System.IAsyncResult> @beginMethod, System.Func<System.IAsyncResult, TResult> @endFunction, System.Action<System.IAsyncResult> @endAction, TArg1 @arg1, System.Object @state, System.Threading.Tasks.TaskCreationOptions @creationOptions)
        {

            var ___genericsType = new Type[] {typeof(TArg1)};
            var ___parameters = new object[]{@beginMethod, @endFunction, @endAction, @arg1, @state, @creationOptions};
            var ___result = RMFromAsyncImpl_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync<TArg1, TArg2>(System.Func<TArg1, TArg2, System.AsyncCallback, System.Object, System.IAsyncResult> @beginMethod, System.Func<System.IAsyncResult, TResult> @endMethod, TArg1 @arg1, TArg2 @arg2, System.Object @state)
        {

            var ___genericsType = new Type[] {typeof(TArg1), typeof(TArg2)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @arg1, @arg2, @state};
            var ___result = RMFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync<TArg1, TArg2>(System.Func<TArg1, TArg2, System.AsyncCallback, System.Object, System.IAsyncResult> @beginMethod, System.Func<System.IAsyncResult, TResult> @endMethod, TArg1 @arg1, TArg2 @arg2, System.Object @state, System.Threading.Tasks.TaskCreationOptions @creationOptions)
        {

            var ___genericsType = new Type[] {typeof(TArg1), typeof(TArg2)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @arg1, @arg2, @state, @creationOptions};
            var ___result = RMFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public static System.Threading.Tasks.Task<TResult> FromAsyncImpl<TArg1, TArg2>(System.Func<TArg1, TArg2, System.AsyncCallback, System.Object, System.IAsyncResult> @beginMethod, System.Func<System.IAsyncResult, TResult> @endFunction, System.Action<System.IAsyncResult> @endAction, TArg1 @arg1, TArg2 @arg2, System.Object @state, System.Threading.Tasks.TaskCreationOptions @creationOptions)
        {

            var ___genericsType = new Type[] {typeof(TArg1), typeof(TArg2)};
            var ___parameters = new object[]{@beginMethod, @endFunction, @endAction, @arg1, @arg2, @state, @creationOptions};
            var ___result = RMFromAsyncImpl_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync<TArg1, TArg2, TArg3>(System.Func<TArg1, TArg2, TArg3, System.AsyncCallback, System.Object, System.IAsyncResult> @beginMethod, System.Func<System.IAsyncResult, TResult> @endMethod, TArg1 @arg1, TArg2 @arg2, TArg3 @arg3, System.Object @state)
        {

            var ___genericsType = new Type[] {typeof(TArg1), typeof(TArg2), typeof(TArg3)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @arg1, @arg2, @arg3, @state};
            var ___result = RMFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync<TArg1, TArg2, TArg3>(System.Func<TArg1, TArg2, TArg3, System.AsyncCallback, System.Object, System.IAsyncResult> @beginMethod, System.Func<System.IAsyncResult, TResult> @endMethod, TArg1 @arg1, TArg2 @arg2, TArg3 @arg3, System.Object @state, System.Threading.Tasks.TaskCreationOptions @creationOptions)
        {

            var ___genericsType = new Type[] {typeof(TArg1), typeof(TArg2), typeof(TArg3)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @arg1, @arg2, @arg3, @state, @creationOptions};
            var ___result = RMFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public static System.Threading.Tasks.Task<TResult> FromAsyncImpl<TArg1, TArg2, TArg3>(System.Func<TArg1, TArg2, TArg3, System.AsyncCallback, System.Object, System.IAsyncResult> @beginMethod, System.Func<System.IAsyncResult, TResult> @endFunction, System.Action<System.IAsyncResult> @endAction, TArg1 @arg1, TArg2 @arg2, TArg3 @arg3, System.Object @state, System.Threading.Tasks.TaskCreationOptions @creationOptions)
        {

            var ___genericsType = new Type[] {typeof(TArg1), typeof(TArg2), typeof(TArg3)};
            var ___parameters = new object[]{@beginMethod, @endFunction, @endAction, @arg1, @arg2, @arg3, @state, @creationOptions};
            var ___result = RMFromAsyncImpl_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public static System.Threading.Tasks.Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance @thisRef, TArgs @args, System.Func<TInstance, TArgs, System.AsyncCallback, System.Object, System.IAsyncResult> @beginMethod, System.Func<TInstance, System.IAsyncResult, TResult> @endMethod) where TInstance : class
        {

            var ___genericsType = new Type[] {typeof(TInstance), typeof(TArgs)};
            var ___parameters = new object[]{@thisRef, @args, @beginMethod, @endMethod};
            var ___result = RMFromAsyncTrim_GTInstance_GTArgs_TInstance_TArgs_Func_d_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_p__Func_d_TInstance_IAsyncResult_TResult_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public static System.Threading.Tasks.Task<TResult> CreateCanceledTask(System.Threading.Tasks.TaskContinuationOptions @continuationOptions, System.Threading.CancellationToken @ct)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationOptions, @ct};
            var ___result = RMCreateCanceledTask_TaskContinuationOptions_CancellationToken.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAll(System.Threading.Tasks.Task[] @tasks, System.Func<System.Threading.Tasks.Task[], TResult> @continuationFunction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationFunction};
            var ___result = RMContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAll(System.Threading.Tasks.Task[] @tasks, System.Func<System.Threading.Tasks.Task[], TResult> @continuationFunction, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationFunction, @cancellationToken};
            var ___result = RMContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAll(System.Threading.Tasks.Task[] @tasks, System.Func<System.Threading.Tasks.Task[], TResult> @continuationFunction, System.Threading.Tasks.TaskContinuationOptions @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationFunction, @continuationOptions};
            var ___result = RMContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAll(System.Threading.Tasks.Task[] @tasks, System.Func<System.Threading.Tasks.Task[], TResult> @continuationFunction, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskContinuationOptions @continuationOptions, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationFunction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RMContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAll<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>[], TResult> @continuationFunction)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction};
            var ___result = RMContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAll<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>[], TResult> @continuationFunction, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @cancellationToken};
            var ___result = RMContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAll<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>[], TResult> @continuationFunction, System.Threading.Tasks.TaskContinuationOptions @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @continuationOptions};
            var ___result = RMContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAll<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>[], TResult> @continuationFunction, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskContinuationOptions @continuationOptions, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RMContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public static System.Threading.Tasks.Task<TResult> ContinueWhenAllImpl<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>[], TResult> @continuationFunction, System.Threading.Tasks.TaskContinuationOptions @continuationOptions, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @continuationOptions, @cancellationToken, @scheduler};
            var ___result = RMContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public static System.Threading.Tasks.Task<TResult> ContinueWhenAllImpl<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] @tasks, System.Action<System.Threading.Tasks.Task<TAntecedentResult>[]> @continuationAction, System.Threading.Tasks.TaskContinuationOptions @continuationOptions, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationAction, @continuationOptions, @cancellationToken, @scheduler};
            var ___result = RMContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__TaskContinuationOptions_CancellationToken_TaskScheduler.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public static System.Threading.Tasks.Task<TResult> ContinueWhenAllImpl(System.Threading.Tasks.Task[] @tasks, System.Func<System.Threading.Tasks.Task[], TResult> @continuationFunction, System.Threading.Tasks.TaskContinuationOptions @continuationOptions, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationFunction, @continuationOptions, @cancellationToken, @scheduler};
            var ___result = RMContinueWhenAllImpl_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public static System.Threading.Tasks.Task<TResult> ContinueWhenAllImpl(System.Threading.Tasks.Task[] @tasks, System.Action<System.Threading.Tasks.Task[]> @continuationAction, System.Threading.Tasks.TaskContinuationOptions @continuationOptions, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationAction, @continuationOptions, @cancellationToken, @scheduler};
            var ___result = RMContinueWhenAllImpl_TaskArray_Action_d_TaskArray_p__TaskContinuationOptions_CancellationToken_TaskScheduler.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAny(System.Threading.Tasks.Task[] @tasks, System.Func<System.Threading.Tasks.Task, TResult> @continuationFunction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationFunction};
            var ___result = RMContinueWhenAny_TaskArray_Func_d_Task_TResult_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAny(System.Threading.Tasks.Task[] @tasks, System.Func<System.Threading.Tasks.Task, TResult> @continuationFunction, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationFunction, @cancellationToken};
            var ___result = RMContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAny(System.Threading.Tasks.Task[] @tasks, System.Func<System.Threading.Tasks.Task, TResult> @continuationFunction, System.Threading.Tasks.TaskContinuationOptions @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationFunction, @continuationOptions};
            var ___result = RMContinueWhenAny_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAny(System.Threading.Tasks.Task[] @tasks, System.Func<System.Threading.Tasks.Task, TResult> @continuationFunction, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskContinuationOptions @continuationOptions, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationFunction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RMContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAny<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>, TResult> @continuationFunction)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction};
            var ___result = RMContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAny<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>, TResult> @continuationFunction, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @cancellationToken};
            var ___result = RMContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAny<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>, TResult> @continuationFunction, System.Threading.Tasks.TaskContinuationOptions @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @continuationOptions};
            var ___result = RMContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAny<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>, TResult> @continuationFunction, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskContinuationOptions @continuationOptions, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RMContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public static System.Threading.Tasks.Task<TResult> ContinueWhenAnyImpl(System.Threading.Tasks.Task[] @tasks, System.Action<System.Threading.Tasks.Task> @continuationAction, System.Threading.Tasks.TaskContinuationOptions @continuationOptions, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationAction, @continuationOptions, @cancellationToken, @scheduler};
            var ___result = RMContinueWhenAnyImpl_TaskArray_Action_d_Task_p__TaskContinuationOptions_CancellationToken_TaskScheduler.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public static System.Threading.Tasks.Task<TResult> ContinueWhenAnyImpl(System.Threading.Tasks.Task[] @tasks, System.Func<System.Threading.Tasks.Task, TResult> @continuationFunction, System.Threading.Tasks.TaskContinuationOptions @continuationOptions, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationFunction, @continuationOptions, @cancellationToken, @scheduler};
            var ___result = RMContinueWhenAnyImpl_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public static System.Threading.Tasks.Task<TResult> ContinueWhenAnyImpl<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>, TResult> @continuationFunction, System.Threading.Tasks.TaskContinuationOptions @continuationOptions, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @continuationOptions, @cancellationToken, @scheduler};
            var ___result = RMContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public static System.Threading.Tasks.Task<TResult> ContinueWhenAnyImpl<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] @tasks, System.Action<System.Threading.Tasks.Task<TAntecedentResult>> @continuationAction, System.Threading.Tasks.TaskContinuationOptions @continuationOptions, System.Threading.CancellationToken @cancellationToken, System.Threading.Tasks.TaskScheduler @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationAction, @continuationOptions, @cancellationToken, @scheduler};
            var ___result = RMContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__TaskContinuationOptions_CancellationToken_TaskScheduler.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.Task<TResult>>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
