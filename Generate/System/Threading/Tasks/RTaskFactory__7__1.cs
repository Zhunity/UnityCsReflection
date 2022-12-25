using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks
{
	/// <summary>
	/// System.Threading.Tasks.TaskFactory`1
	/// </summary>
    public partial class RTaskFactory<TResult> : RMember //
    {

		/// <summary>
		/// System.Threading.CancellationToken m_defaultCancellationToken
		/// </summary>
		protected RSystem.RThreading.RCancellationToken r_m_defaultCancellationToken;
		public virtual RSystem.RThreading.RCancellationToken Rm_defaultCancellationToken
		{
			get
			{
				if(r_m_defaultCancellationToken == null)
				{
					r_m_defaultCancellationToken = new(this, "m_defaultCancellationToken");
					r_m_defaultCancellationToken.SetBelong(this.instance);
				}
				return r_m_defaultCancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler m_defaultScheduler
		/// </summary>
		protected RSystem.RThreading.RTasks.RTaskScheduler r_m_defaultScheduler;
		public virtual RSystem.RThreading.RTasks.RTaskScheduler Rm_defaultScheduler
		{
			get
			{
				if(r_m_defaultScheduler == null)
				{
					r_m_defaultScheduler = new(this, "m_defaultScheduler");
					r_m_defaultScheduler.SetBelong(this.instance);
				}
				return r_m_defaultScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskCreationOptions m_defaultCreationOptions
		/// </summary>
		protected RField r_m_defaultCreationOptions;
		public virtual RField Rm_defaultCreationOptions
		{
			get
			{
				if(r_m_defaultCreationOptions == null)
				{
					r_m_defaultCreationOptions = new(this, "m_defaultCreationOptions");
					r_m_defaultCreationOptions.SetBelong(this.instance);
				}
				return r_m_defaultCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskContinuationOptions m_defaultContinuationOptions
		/// </summary>
		protected RField r_m_defaultContinuationOptions;
		public virtual RField Rm_defaultContinuationOptions
		{
			get
			{
				if(r_m_defaultContinuationOptions == null)
				{
					r_m_defaultContinuationOptions = new(this, "m_defaultContinuationOptions");
					r_m_defaultContinuationOptions.SetBelong(this.instance);
				}
				return r_m_defaultContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler DefaultScheduler
		/// </summary>
		protected RSystem.RThreading.RTasks.RTaskScheduler r_DefaultScheduler;
		public virtual RSystem.RThreading.RTasks.RTaskScheduler RDefaultScheduler
		{
			get
			{
				if(r_DefaultScheduler == null)
				{
					r_DefaultScheduler = new(this, "DefaultScheduler", -1);
					r_DefaultScheduler.SetBelong(this.instance);
				}
				return r_DefaultScheduler;
			}
		}

		/// <summary>
		/// System.Threading.CancellationToken CancellationToken
		/// </summary>
		protected RSystem.RThreading.RCancellationToken r_CancellationToken;
		public virtual RSystem.RThreading.RCancellationToken RCancellationToken
		{
			get
			{
				if(r_CancellationToken == null)
				{
					r_CancellationToken = new(this, "CancellationToken", -1);
					r_CancellationToken.SetBelong(this.instance);
				}
				return r_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler Scheduler
		/// </summary>
		protected RSystem.RThreading.RTasks.RTaskScheduler r_Scheduler;
		public virtual RSystem.RThreading.RTasks.RTaskScheduler RScheduler
		{
			get
			{
				if(r_Scheduler == null)
				{
					r_Scheduler = new(this, "Scheduler", -1);
					r_Scheduler.SetBelong(this.instance);
				}
				return r_Scheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskCreationOptions CreationOptions
		/// </summary>
		protected RProperty r_CreationOptions;
		public virtual RProperty RCreationOptions
		{
			get
			{
				if(r_CreationOptions == null)
				{
					r_CreationOptions = new(this, "CreationOptions", -1);
					r_CreationOptions.SetBelong(this.instance);
				}
				return r_CreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskContinuationOptions ContinuationOptions
		/// </summary>
		protected RProperty r_ContinuationOptions;
		public virtual RProperty RContinuationOptions
		{
			get
			{
				if(r_ContinuationOptions == null)
				{
					r_ContinuationOptions = new(this, "ContinuationOptions", -1);
					r_ContinuationOptions.SetBelong(this.instance);
				}
				return r_ContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskScheduler GetDefaultScheduler(System.Threading.Tasks.Task)
		/// </summary>
		protected RMethod r_RGetDefaultScheduler_Task;
		public virtual RMethod RGetDefaultScheduler_Task
		{
			get
			{
				if(r_RGetDefaultScheduler_Task == null)
				{
					r_RGetDefaultScheduler_Task = new(this, "GetDefaultScheduler", 0, typeof(System.Threading.Tasks.Task));
					r_RGetDefaultScheduler_Task.SetBelong(this.instance);
				}
				return r_RGetDefaultScheduler_Task;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] StartNew(System.Func`1[TResult])
		/// </summary>
		protected RMethod r_RStartNew_Func_d_TResult_p_;
		public virtual RMethod RStartNew_Func_d_TResult_p_
		{
			get
			{
				if(r_RStartNew_Func_d_TResult_p_ == null)
				{
					r_RStartNew_Func_d_TResult_p_ = new(this, "StartNew", 0, typeof(System.Func<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RStartNew_Func_d_TResult_p_.SetBelong(this.instance);
				}
				return r_RStartNew_Func_d_TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] StartNew(System.Func`1[TResult], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RStartNew_Func_d_TResult_p__CancellationToken;
		public virtual RMethod RStartNew_Func_d_TResult_p__CancellationToken
		{
			get
			{
				if(r_RStartNew_Func_d_TResult_p__CancellationToken == null)
				{
					r_RStartNew_Func_d_TResult_p__CancellationToken = new(this, "StartNew", 0, typeof(System.Func<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken));
					r_RStartNew_Func_d_TResult_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RStartNew_Func_d_TResult_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] StartNew(System.Func`1[TResult], System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_RStartNew_Func_d_TResult_p__TaskCreationOptions;
		public virtual RMethod RStartNew_Func_d_TResult_p__TaskCreationOptions
		{
			get
			{
				if(r_RStartNew_Func_d_TResult_p__TaskCreationOptions == null)
				{
					r_RStartNew_Func_d_TResult_p__TaskCreationOptions = new(this, "StartNew", 0, typeof(System.Func<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RStartNew_Func_d_TResult_p__TaskCreationOptions.SetBelong(this.instance);
				}
				return r_RStartNew_Func_d_TResult_p__TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] StartNew(System.Func`1[TResult], System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RStartNew_Func_d_TResult_p__CancellationToken_TaskCreationOptions_TaskScheduler;
		public virtual RMethod RStartNew_Func_d_TResult_p__CancellationToken_TaskCreationOptions_TaskScheduler
		{
			get
			{
				if(r_RStartNew_Func_d_TResult_p__CancellationToken_TaskCreationOptions_TaskScheduler == null)
				{
					r_RStartNew_Func_d_TResult_p__CancellationToken_TaskCreationOptions_TaskScheduler = new(this, "StartNew", 0, typeof(System.Func<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskCreationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RStartNew_Func_d_TResult_p__CancellationToken_TaskCreationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RStartNew_Func_d_TResult_p__CancellationToken_TaskCreationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] StartNew(System.Func`2[System.Object,TResult], System.Object)
		/// </summary>
		protected RMethod r_RStartNew_Func_d_Object_TResult_p__Object;
		public virtual RMethod RStartNew_Func_d_Object_TResult_p__Object
		{
			get
			{
				if(r_RStartNew_Func_d_Object_TResult_p__Object == null)
				{
					r_RStartNew_Func_d_Object_TResult_p__Object = new(this, "StartNew", 0, typeof(System.Func<, >).MakeGenericType(typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object));
					r_RStartNew_Func_d_Object_TResult_p__Object.SetBelong(this.instance);
				}
				return r_RStartNew_Func_d_Object_TResult_p__Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] StartNew(System.Func`2[System.Object,TResult], System.Object, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RStartNew_Func_d_Object_TResult_p__Object_CancellationToken;
		public virtual RMethod RStartNew_Func_d_Object_TResult_p__Object_CancellationToken
		{
			get
			{
				if(r_RStartNew_Func_d_Object_TResult_p__Object_CancellationToken == null)
				{
					r_RStartNew_Func_d_Object_TResult_p__Object_CancellationToken = new(this, "StartNew", 0, typeof(System.Func<, >).MakeGenericType(typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.CancellationToken));
					r_RStartNew_Func_d_Object_TResult_p__Object_CancellationToken.SetBelong(this.instance);
				}
				return r_RStartNew_Func_d_Object_TResult_p__Object_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] StartNew(System.Func`2[System.Object,TResult], System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_RStartNew_Func_d_Object_TResult_p__Object_TaskCreationOptions;
		public virtual RMethod RStartNew_Func_d_Object_TResult_p__Object_TaskCreationOptions
		{
			get
			{
				if(r_RStartNew_Func_d_Object_TResult_p__Object_TaskCreationOptions == null)
				{
					r_RStartNew_Func_d_Object_TResult_p__Object_TaskCreationOptions = new(this, "StartNew", 0, typeof(System.Func<, >).MakeGenericType(typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RStartNew_Func_d_Object_TResult_p__Object_TaskCreationOptions.SetBelong(this.instance);
				}
				return r_RStartNew_Func_d_Object_TResult_p__Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] StartNew(System.Func`2[System.Object,TResult], System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RStartNew_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler;
		public virtual RMethod RStartNew_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler
		{
			get
			{
				if(r_RStartNew_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler == null)
				{
					r_RStartNew_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler = new(this, "StartNew", 0, typeof(System.Func<, >).MakeGenericType(typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskCreationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RStartNew_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RStartNew_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// Void FromAsyncCoreLogic(System.IAsyncResult, System.Func`2[System.IAsyncResult,TResult], System.Action`1[System.IAsyncResult], System.Threading.Tasks.Task`1[TResult], Boolean)
		/// </summary>
		protected static RMethod r_RFromAsyncCoreLogic_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Task_d_TResult_p__Boolean;
		public static RMethod RFromAsyncCoreLogic_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Task_d_TResult_p__Boolean
		{
			get
			{
				if(r_RFromAsyncCoreLogic_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Task_d_TResult_p__Boolean == null)
				{
					r_RFromAsyncCoreLogic_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Task_d_TResult_p__Boolean = new(typeof(System.Threading.Tasks.TaskFactory<>), "FromAsyncCoreLogic", 0, typeof(System.IAsyncResult), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), typeof(System.Action<>).MakeGenericType(typeof(System.IAsyncResult)), typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Boolean));
					r_RFromAsyncCoreLogic_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Task_d_TResult_p__Boolean.SetBelong(null);
				}
				return r_RFromAsyncCoreLogic_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Task_d_TResult_p__Boolean;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync(System.IAsyncResult, System.Func`2[System.IAsyncResult,TResult])
		/// </summary>
		protected RMethod r_RFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p_;
		public virtual RMethod RFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p_
		{
			get
			{
				if(r_RFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p_ == null)
				{
					r_RFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p_ = new(this, "FromAsync", 0, typeof(System.IAsyncResult), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)));
					r_RFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p_.SetBelong(this.instance);
				}
				return r_RFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync(System.IAsyncResult, System.Func`2[System.IAsyncResult,TResult], System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_RFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions;
		public virtual RMethod RFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions
		{
			get
			{
				if(r_RFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions == null)
				{
					r_RFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions = new(this, "FromAsync", 0, typeof(System.IAsyncResult), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions.SetBelong(this.instance);
				}
				return r_RFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync(System.IAsyncResult, System.Func`2[System.IAsyncResult,TResult], System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions_TaskScheduler;
		public virtual RMethod RFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions_TaskScheduler
		{
			get
			{
				if(r_RFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions_TaskScheduler == null)
				{
					r_RFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions_TaskScheduler = new(this, "FromAsync", 0, typeof(System.IAsyncResult), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskCreationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsyncImpl(System.IAsyncResult, System.Func`2[System.IAsyncResult,TResult], System.Action`1[System.IAsyncResult], System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected static RMethod r_RFromAsyncImpl_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TaskCreationOptions_TaskScheduler;
		public static RMethod RFromAsyncImpl_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TaskCreationOptions_TaskScheduler
		{
			get
			{
				if(r_RFromAsyncImpl_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TaskCreationOptions_TaskScheduler == null)
				{
					r_RFromAsyncImpl_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TaskCreationOptions_TaskScheduler = new(typeof(System.Threading.Tasks.TaskFactory<>), "FromAsyncImpl", 0, typeof(System.IAsyncResult), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), typeof(System.Action<>).MakeGenericType(typeof(System.IAsyncResult)), typeof(System.Threading.Tasks.TaskCreationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RFromAsyncImpl_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TaskCreationOptions_TaskScheduler.SetBelong(null);
				}
				return r_RFromAsyncImpl_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TaskCreationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync(System.Func`3[System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], System.Object)
		/// </summary>
		protected RMethod r_RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object;
		public virtual RMethod RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object
		{
			get
			{
				if(r_RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object == null)
				{
					r_RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object = new(this, "FromAsync", 0, typeof(System.Func<, , >).MakeGenericType(typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), typeof(System.Object));
					r_RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object.SetBelong(this.instance);
				}
				return r_RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync(System.Func`3[System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object_TaskCreationOptions;
		public virtual RMethod RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object_TaskCreationOptions
		{
			get
			{
				if(r_RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object_TaskCreationOptions == null)
				{
					r_RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object_TaskCreationOptions = new(this, "FromAsync", 0, typeof(System.Func<, , >).MakeGenericType(typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object_TaskCreationOptions.SetBelong(this.instance);
				}
				return r_RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsyncImpl(System.Func`3[System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], System.Action`1[System.IAsyncResult], System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected static RMethod r_RFromAsyncImpl_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Object_TaskCreationOptions;
		public static RMethod RFromAsyncImpl_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Object_TaskCreationOptions
		{
			get
			{
				if(r_RFromAsyncImpl_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Object_TaskCreationOptions == null)
				{
					r_RFromAsyncImpl_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Object_TaskCreationOptions = new(typeof(System.Threading.Tasks.TaskFactory<>), "FromAsyncImpl", 0, typeof(System.Func<, , >).MakeGenericType(typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), typeof(System.Action<>).MakeGenericType(typeof(System.IAsyncResult)), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RFromAsyncImpl_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Object_TaskCreationOptions.SetBelong(null);
				}
				return r_RFromAsyncImpl_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync[TArg1](System.Func`4[TArg1,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], TArg1, System.Object)
		/// </summary>
		protected RMethod r_RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object;
		public virtual RMethod RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object
		{
			get
			{
				if(r_RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object == null)
				{
					r_RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object = new(this, "FromAsync", 1, typeof(System.Func<, , , >).MakeGenericType(Type.MakeGenericMethodParameter(0), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0), typeof(System.Object));
					r_RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object.SetBelong(this.instance);
				}
				return r_RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync[TArg1](System.Func`4[TArg1,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], TArg1, System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object_TaskCreationOptions;
		public virtual RMethod RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object_TaskCreationOptions
		{
			get
			{
				if(r_RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object_TaskCreationOptions == null)
				{
					r_RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object_TaskCreationOptions = new(this, "FromAsync", 1, typeof(System.Func<, , , >).MakeGenericType(Type.MakeGenericMethodParameter(0), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object_TaskCreationOptions.SetBelong(this.instance);
				}
				return r_RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsyncImpl[TArg1](System.Func`4[TArg1,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], System.Action`1[System.IAsyncResult], TArg1, System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected static RMethod r_RFromAsyncImpl_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_Object_TaskCreationOptions;
		public static RMethod RFromAsyncImpl_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_Object_TaskCreationOptions
		{
			get
			{
				if(r_RFromAsyncImpl_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_Object_TaskCreationOptions == null)
				{
					r_RFromAsyncImpl_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_Object_TaskCreationOptions = new(typeof(System.Threading.Tasks.TaskFactory<>), "FromAsyncImpl", 1, typeof(System.Func<, , , >).MakeGenericType(Type.MakeGenericMethodParameter(0), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), typeof(System.Action<>).MakeGenericType(typeof(System.IAsyncResult)), Type.MakeGenericMethodParameter(0), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RFromAsyncImpl_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_Object_TaskCreationOptions.SetBelong(null);
				}
				return r_RFromAsyncImpl_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync[TArg1,TArg2](System.Func`5[TArg1,TArg2,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], TArg1, TArg2, System.Object)
		/// </summary>
		protected RMethod r_RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object;
		public virtual RMethod RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object
		{
			get
			{
				if(r_RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object == null)
				{
					r_RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object = new(this, "FromAsync", 2, typeof(System.Func<, , , , >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), typeof(System.Object));
					r_RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object.SetBelong(this.instance);
				}
				return r_RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync[TArg1,TArg2](System.Func`5[TArg1,TArg2,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], TArg1, TArg2, System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object_TaskCreationOptions;
		public virtual RMethod RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object_TaskCreationOptions
		{
			get
			{
				if(r_RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object_TaskCreationOptions == null)
				{
					r_RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object_TaskCreationOptions = new(this, "FromAsync", 2, typeof(System.Func<, , , , >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object_TaskCreationOptions.SetBelong(this.instance);
				}
				return r_RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsyncImpl[TArg1,TArg2](System.Func`5[TArg1,TArg2,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], System.Action`1[System.IAsyncResult], TArg1, TArg2, System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected static RMethod r_RFromAsyncImpl_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object_TaskCreationOptions;
		public static RMethod RFromAsyncImpl_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object_TaskCreationOptions
		{
			get
			{
				if(r_RFromAsyncImpl_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object_TaskCreationOptions == null)
				{
					r_RFromAsyncImpl_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object_TaskCreationOptions = new(typeof(System.Threading.Tasks.TaskFactory<>), "FromAsyncImpl", 2, typeof(System.Func<, , , , >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), typeof(System.Action<>).MakeGenericType(typeof(System.IAsyncResult)), Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RFromAsyncImpl_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object_TaskCreationOptions.SetBelong(null);
				}
				return r_RFromAsyncImpl_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync[TArg1,TArg2,TArg3](System.Func`6[TArg1,TArg2,TArg3,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], TArg1, TArg2, TArg3, System.Object)
		/// </summary>
		protected RMethod r_RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object;
		public virtual RMethod RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object
		{
			get
			{
				if(r_RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object == null)
				{
					r_RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object = new(this, "FromAsync", 3, typeof(System.Func<, , , , , >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), Type.MakeGenericMethodParameter(2), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), Type.MakeGenericMethodParameter(2), typeof(System.Object));
					r_RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object.SetBelong(this.instance);
				}
				return r_RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync[TArg1,TArg2,TArg3](System.Func`6[TArg1,TArg2,TArg3,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], TArg1, TArg2, TArg3, System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions;
		public virtual RMethod RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions
		{
			get
			{
				if(r_RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions == null)
				{
					r_RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions = new(this, "FromAsync", 3, typeof(System.Func<, , , , , >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), Type.MakeGenericMethodParameter(2), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), Type.MakeGenericMethodParameter(2), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions.SetBelong(this.instance);
				}
				return r_RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsyncImpl[TArg1,TArg2,TArg3](System.Func`6[TArg1,TArg2,TArg3,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], System.Action`1[System.IAsyncResult], TArg1, TArg2, TArg3, System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected static RMethod r_RFromAsyncImpl_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions;
		public static RMethod RFromAsyncImpl_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions
		{
			get
			{
				if(r_RFromAsyncImpl_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions == null)
				{
					r_RFromAsyncImpl_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions = new(typeof(System.Threading.Tasks.TaskFactory<>), "FromAsyncImpl", 3, typeof(System.Func<, , , , , >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), Type.MakeGenericMethodParameter(2), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), typeof(System.Action<>).MakeGenericType(typeof(System.IAsyncResult)), Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), Type.MakeGenericMethodParameter(2), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RFromAsyncImpl_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions.SetBelong(null);
				}
				return r_RFromAsyncImpl_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsyncTrim[TInstance,TArgs](TInstance, TArgs, System.Func`5[TInstance,TArgs,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`3[TInstance,System.IAsyncResult,TResult])
		/// </summary>
		protected static RMethod r_RFromAsyncTrim_GTInstance_GTArgs_TInstance_TArgs_Func_d_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_p__Func_d_TInstance_IAsyncResult_TResult_p_;
		public static RMethod RFromAsyncTrim_GTInstance_GTArgs_TInstance_TArgs_Func_d_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_p__Func_d_TInstance_IAsyncResult_TResult_p_
		{
			get
			{
				if(r_RFromAsyncTrim_GTInstance_GTArgs_TInstance_TArgs_Func_d_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_p__Func_d_TInstance_IAsyncResult_TResult_p_ == null)
				{
					r_RFromAsyncTrim_GTInstance_GTArgs_TInstance_TArgs_Func_d_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_p__Func_d_TInstance_IAsyncResult_TResult_p_ = new(typeof(System.Threading.Tasks.TaskFactory<>), "FromAsyncTrim", 2, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), typeof(System.Func<, , , , >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Func<, , >).MakeGenericType(Type.MakeGenericMethodParameter(0), typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)));
					r_RFromAsyncTrim_GTInstance_GTArgs_TInstance_TArgs_Func_d_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_p__Func_d_TInstance_IAsyncResult_TResult_p_.SetBelong(null);
				}
				return r_RFromAsyncTrim_GTInstance_GTArgs_TInstance_TArgs_Func_d_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_p__Func_d_TInstance_IAsyncResult_TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] CreateCanceledTask(System.Threading.Tasks.TaskContinuationOptions, System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_RCreateCanceledTask_TaskContinuationOptions_CancellationToken;
		public static RMethod RCreateCanceledTask_TaskContinuationOptions_CancellationToken
		{
			get
			{
				if(r_RCreateCanceledTask_TaskContinuationOptions_CancellationToken == null)
				{
					r_RCreateCanceledTask_TaskContinuationOptions_CancellationToken = new(typeof(System.Threading.Tasks.TaskFactory<>), "CreateCanceledTask", 0, typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.CancellationToken));
					r_RCreateCanceledTask_TaskContinuationOptions_CancellationToken.SetBelong(null);
				}
				return r_RCreateCanceledTask_TaskContinuationOptions_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAll(System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task[],TResult])
		/// </summary>
		protected RMethod r_RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p_;
		public virtual RMethod RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p_
		{
			get
			{
				if(r_RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p_ == null)
				{
					r_RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p_ = new(this, "ContinueWhenAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task).MakeArrayType(), Type.MakeGenericMethodParameter(0)));
					r_RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p_.SetBelong(this.instance);
				}
				return r_RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAll(System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task[],TResult], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken;
		public virtual RMethod RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken
		{
			get
			{
				if(r_RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken == null)
				{
					r_RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken = new(this, "ContinueWhenAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task).MakeArrayType(), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken));
					r_RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAll(System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task[],TResult], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions;
		public virtual RMethod RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions == null)
				{
					r_RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions = new(this, "ContinueWhenAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task).MakeArrayType(), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAll(System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task[],TResult], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWhenAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task).MakeArrayType(), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAll[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult][],TResult])
		/// </summary>
		protected RMethod r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p_;
		public virtual RMethod RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p_
		{
			get
			{
				if(r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p_ == null)
				{
					r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p_ = new(this, "ContinueWhenAll", 1, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), Type.MakeGenericMethodParameter(0)));
					r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p_.SetBelong(this.instance);
				}
				return r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAll[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult][],TResult], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken;
		public virtual RMethod RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken
		{
			get
			{
				if(r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken == null)
				{
					r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken = new(this, "ContinueWhenAll", 1, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken));
					r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAll[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult][],TResult], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions;
		public virtual RMethod RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions == null)
				{
					r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions = new(this, "ContinueWhenAll", 1, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAll[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult][],TResult], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWhenAll", 1, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAllImpl[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult][],TResult], System.Threading.Tasks.TaskContinuationOptions, System.Threading.CancellationToken, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected static RMethod r_RContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
		public static RMethod RContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler
		{
			get
			{
				if(r_RContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler == null)
				{
					r_RContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler = new(typeof(System.Threading.Tasks.TaskFactory<>), "ContinueWhenAllImpl", 1, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler.SetBelong(null);
				}
				return r_RContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAllImpl[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Action`1[System.Threading.Tasks.Task`1[TAntecedentResult][]], System.Threading.Tasks.TaskContinuationOptions, System.Threading.CancellationToken, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected static RMethod r_RContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
		public static RMethod RContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__TaskContinuationOptions_CancellationToken_TaskScheduler
		{
			get
			{
				if(r_RContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__TaskContinuationOptions_CancellationToken_TaskScheduler == null)
				{
					r_RContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__TaskContinuationOptions_CancellationToken_TaskScheduler = new(typeof(System.Threading.Tasks.TaskFactory<>), "ContinueWhenAllImpl", 1, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType()), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__TaskContinuationOptions_CancellationToken_TaskScheduler.SetBelong(null);
				}
				return r_RContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAllImpl(System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task[],TResult], System.Threading.Tasks.TaskContinuationOptions, System.Threading.CancellationToken, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected static RMethod r_RContinueWhenAllImpl_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
		public static RMethod RContinueWhenAllImpl_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler
		{
			get
			{
				if(r_RContinueWhenAllImpl_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler == null)
				{
					r_RContinueWhenAllImpl_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler = new(typeof(System.Threading.Tasks.TaskFactory<>), "ContinueWhenAllImpl", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task).MakeArrayType(), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWhenAllImpl_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler.SetBelong(null);
				}
				return r_RContinueWhenAllImpl_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAllImpl(System.Threading.Tasks.Task[], System.Action`1[System.Threading.Tasks.Task[]], System.Threading.Tasks.TaskContinuationOptions, System.Threading.CancellationToken, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected static RMethod r_RContinueWhenAllImpl_TaskArray_Action_d_TaskArray_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
		public static RMethod RContinueWhenAllImpl_TaskArray_Action_d_TaskArray_p__TaskContinuationOptions_CancellationToken_TaskScheduler
		{
			get
			{
				if(r_RContinueWhenAllImpl_TaskArray_Action_d_TaskArray_p__TaskContinuationOptions_CancellationToken_TaskScheduler == null)
				{
					r_RContinueWhenAllImpl_TaskArray_Action_d_TaskArray_p__TaskContinuationOptions_CancellationToken_TaskScheduler = new(typeof(System.Threading.Tasks.TaskFactory<>), "ContinueWhenAllImpl", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task).MakeArrayType()), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWhenAllImpl_TaskArray_Action_d_TaskArray_p__TaskContinuationOptions_CancellationToken_TaskScheduler.SetBelong(null);
				}
				return r_RContinueWhenAllImpl_TaskArray_Action_d_TaskArray_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAny(System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task,TResult])
		/// </summary>
		protected RMethod r_RContinueWhenAny_TaskArray_Func_d_Task_TResult_p_;
		public virtual RMethod RContinueWhenAny_TaskArray_Func_d_Task_TResult_p_
		{
			get
			{
				if(r_RContinueWhenAny_TaskArray_Func_d_Task_TResult_p_ == null)
				{
					r_RContinueWhenAny_TaskArray_Func_d_Task_TResult_p_ = new(this, "ContinueWhenAny", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)));
					r_RContinueWhenAny_TaskArray_Func_d_Task_TResult_p_.SetBelong(this.instance);
				}
				return r_RContinueWhenAny_TaskArray_Func_d_Task_TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAny(System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task,TResult], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken;
		public virtual RMethod RContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken
		{
			get
			{
				if(r_RContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken == null)
				{
					r_RContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken = new(this, "ContinueWhenAny", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken));
					r_RContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAny(System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task,TResult], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWhenAny_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions;
		public virtual RMethod RContinueWhenAny_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWhenAny_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions == null)
				{
					r_RContinueWhenAny_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions = new(this, "ContinueWhenAny", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWhenAny_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWhenAny_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAny(System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task,TResult], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_RContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_RContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWhenAny", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAny[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult],TResult])
		/// </summary>
		protected RMethod r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p_;
		public virtual RMethod RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p_
		{
			get
			{
				if(r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p_ == null)
				{
					r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p_ = new(this, "ContinueWhenAny", 1, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0)));
					r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p_.SetBelong(this.instance);
				}
				return r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAny[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult],TResult], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken;
		public virtual RMethod RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken
		{
			get
			{
				if(r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken == null)
				{
					r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken = new(this, "ContinueWhenAny", 1, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken));
					r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAny[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult],TResult], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions;
		public virtual RMethod RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions == null)
				{
					r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions = new(this, "ContinueWhenAny", 1, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAny[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult],TResult], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWhenAny", 1, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAnyImpl(System.Threading.Tasks.Task[], System.Action`1[System.Threading.Tasks.Task], System.Threading.Tasks.TaskContinuationOptions, System.Threading.CancellationToken, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected static RMethod r_RContinueWhenAnyImpl_TaskArray_Action_d_Task_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
		public static RMethod RContinueWhenAnyImpl_TaskArray_Action_d_Task_p__TaskContinuationOptions_CancellationToken_TaskScheduler
		{
			get
			{
				if(r_RContinueWhenAnyImpl_TaskArray_Action_d_Task_p__TaskContinuationOptions_CancellationToken_TaskScheduler == null)
				{
					r_RContinueWhenAnyImpl_TaskArray_Action_d_Task_p__TaskContinuationOptions_CancellationToken_TaskScheduler = new(typeof(System.Threading.Tasks.TaskFactory<>), "ContinueWhenAnyImpl", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWhenAnyImpl_TaskArray_Action_d_Task_p__TaskContinuationOptions_CancellationToken_TaskScheduler.SetBelong(null);
				}
				return r_RContinueWhenAnyImpl_TaskArray_Action_d_Task_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAnyImpl(System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task,TResult], System.Threading.Tasks.TaskContinuationOptions, System.Threading.CancellationToken, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected static RMethod r_RContinueWhenAnyImpl_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
		public static RMethod RContinueWhenAnyImpl_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler
		{
			get
			{
				if(r_RContinueWhenAnyImpl_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler == null)
				{
					r_RContinueWhenAnyImpl_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler = new(typeof(System.Threading.Tasks.TaskFactory<>), "ContinueWhenAnyImpl", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWhenAnyImpl_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler.SetBelong(null);
				}
				return r_RContinueWhenAnyImpl_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAnyImpl[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult],TResult], System.Threading.Tasks.TaskContinuationOptions, System.Threading.CancellationToken, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected static RMethod r_RContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
		public static RMethod RContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler
		{
			get
			{
				if(r_RContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler == null)
				{
					r_RContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler = new(typeof(System.Threading.Tasks.TaskFactory<>), "ContinueWhenAnyImpl", 1, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler.SetBelong(null);
				}
				return r_RContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAnyImpl[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Action`1[System.Threading.Tasks.Task`1[TAntecedentResult]], System.Threading.Tasks.TaskContinuationOptions, System.Threading.CancellationToken, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected static RMethod r_RContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__TaskContinuationOptions_CancellationToken_TaskScheduler;
		public static RMethod RContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__TaskContinuationOptions_CancellationToken_TaskScheduler
		{
			get
			{
				if(r_RContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__TaskContinuationOptions_CancellationToken_TaskScheduler == null)
				{
					r_RContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__TaskContinuationOptions_CancellationToken_TaskScheduler = new(typeof(System.Threading.Tasks.TaskFactory<>), "ContinueWhenAnyImpl", 1, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0))), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__TaskContinuationOptions_CancellationToken_TaskScheduler.SetBelong(null);
				}
				return r_RContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__TaskContinuationOptions_CancellationToken_TaskScheduler;
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

        public virtual System.Threading.Tasks.TaskScheduler GetDefaultScheduler(System.Threading.Tasks.Task  @currTask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@currTask};
            var ___result = RGetDefaultScheduler_Task.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.TaskScheduler)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> StartNew(System.Func<TResult>  @function)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@function};
            var ___result = RStartNew_Func_d_TResult_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> StartNew(System.Func<TResult>  @function, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@function, @cancellationToken};
            var ___result = RStartNew_Func_d_TResult_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> StartNew(System.Func<TResult>  @function, System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@function, @creationOptions};
            var ___result = RStartNew_Func_d_TResult_p__TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> StartNew(System.Func<TResult>  @function, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskCreationOptions  @creationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@function, @cancellationToken, @creationOptions, @scheduler};
            var ___result = RStartNew_Func_d_TResult_p__CancellationToken_TaskCreationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> StartNew(System.Func<System.Object, TResult>  @function, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@function, @state};
            var ___result = RStartNew_Func_d_Object_TResult_p__Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> StartNew(System.Func<System.Object, TResult>  @function, System.Object  @state, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@function, @state, @cancellationToken};
            var ___result = RStartNew_Func_d_Object_TResult_p__Object_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> StartNew(System.Func<System.Object, TResult>  @function, System.Object  @state, System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@function, @state, @creationOptions};
            var ___result = RStartNew_Func_d_Object_TResult_p__Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> StartNew(System.Func<System.Object, TResult>  @function, System.Object  @state, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskCreationOptions  @creationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@function, @state, @cancellationToken, @creationOptions, @scheduler};
            var ___result = RStartNew_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static void FromAsyncCoreLogic(System.IAsyncResult  @iar, System.Func<System.IAsyncResult, TResult>  @endFunction, System.Action<System.IAsyncResult>  @endAction, System.Threading.Tasks.Task<TResult>  @promise, System.Boolean  @requiresSynchronization)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iar, @endFunction, @endAction, @promise, @requiresSynchronization};
            var ___result = RFromAsyncCoreLogic_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Task_d_TResult_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync(System.IAsyncResult  @asyncResult, System.Func<System.IAsyncResult, TResult>  @endMethod)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult, @endMethod};
            var ___result = RFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync(System.IAsyncResult  @asyncResult, System.Func<System.IAsyncResult, TResult>  @endMethod, System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult, @endMethod, @creationOptions};
            var ___result = RFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync(System.IAsyncResult  @asyncResult, System.Func<System.IAsyncResult, TResult>  @endMethod, System.Threading.Tasks.TaskCreationOptions  @creationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult, @endMethod, @creationOptions, @scheduler};
            var ___result = RFromAsync_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task<TResult> FromAsyncImpl(System.IAsyncResult  @asyncResult, System.Func<System.IAsyncResult, TResult>  @endFunction, System.Action<System.IAsyncResult>  @endAction, System.Threading.Tasks.TaskCreationOptions  @creationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult, @endFunction, @endAction, @creationOptions, @scheduler};
            var ___result = RFromAsyncImpl_IAsyncResult_Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TaskCreationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync(System.Func<System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Func<System.IAsyncResult, TResult>  @endMethod, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@beginMethod, @endMethod, @state};
            var ___result = RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync(System.Func<System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Func<System.IAsyncResult, TResult>  @endMethod, System.Object  @state, System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@beginMethod, @endMethod, @state, @creationOptions};
            var ___result = RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task<TResult> FromAsyncImpl(System.Func<System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Func<System.IAsyncResult, TResult>  @endFunction, System.Action<System.IAsyncResult>  @endAction, System.Object  @state, System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@beginMethod, @endFunction, @endAction, @state, @creationOptions};
            var ___result = RFromAsyncImpl_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync<TArg1>(System.Func<TArg1, System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Func<System.IAsyncResult, TResult>  @endMethod, TArg1  @arg1, System.Object  @state)
        {

            var ___genericsType = new Type[] {typeof(TArg1)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @arg1, @state};
            var ___result = RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync<TArg1>(System.Func<TArg1, System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Func<System.IAsyncResult, TResult>  @endMethod, TArg1  @arg1, System.Object  @state, System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {typeof(TArg1)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @arg1, @state, @creationOptions};
            var ___result = RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task<TResult> FromAsyncImpl<TArg1>(System.Func<TArg1, System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Func<System.IAsyncResult, TResult>  @endFunction, System.Action<System.IAsyncResult>  @endAction, TArg1  @arg1, System.Object  @state, System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {typeof(TArg1)};
            var ___parameters = new object[]{@beginMethod, @endFunction, @endAction, @arg1, @state, @creationOptions};
            var ___result = RFromAsyncImpl_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync<TArg1, TArg2>(System.Func<TArg1, TArg2, System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Func<System.IAsyncResult, TResult>  @endMethod, TArg1  @arg1, TArg2  @arg2, System.Object  @state)
        {

            var ___genericsType = new Type[] {typeof(TArg1), typeof(TArg2)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @arg1, @arg2, @state};
            var ___result = RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync<TArg1, TArg2>(System.Func<TArg1, TArg2, System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Func<System.IAsyncResult, TResult>  @endMethod, TArg1  @arg1, TArg2  @arg2, System.Object  @state, System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {typeof(TArg1), typeof(TArg2)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @arg1, @arg2, @state, @creationOptions};
            var ___result = RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task<TResult> FromAsyncImpl<TArg1, TArg2>(System.Func<TArg1, TArg2, System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Func<System.IAsyncResult, TResult>  @endFunction, System.Action<System.IAsyncResult>  @endAction, TArg1  @arg1, TArg2  @arg2, System.Object  @state, System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {typeof(TArg1), typeof(TArg2)};
            var ___parameters = new object[]{@beginMethod, @endFunction, @endAction, @arg1, @arg2, @state, @creationOptions};
            var ___result = RFromAsyncImpl_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync<TArg1, TArg2, TArg3>(System.Func<TArg1, TArg2, TArg3, System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Func<System.IAsyncResult, TResult>  @endMethod, TArg1  @arg1, TArg2  @arg2, TArg3  @arg3, System.Object  @state)
        {

            var ___genericsType = new Type[] {typeof(TArg1), typeof(TArg2), typeof(TArg3)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @arg1, @arg2, @arg3, @state};
            var ___result = RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync<TArg1, TArg2, TArg3>(System.Func<TArg1, TArg2, TArg3, System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Func<System.IAsyncResult, TResult>  @endMethod, TArg1  @arg1, TArg2  @arg2, TArg3  @arg3, System.Object  @state, System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {typeof(TArg1), typeof(TArg2), typeof(TArg3)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @arg1, @arg2, @arg3, @state, @creationOptions};
            var ___result = RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task<TResult> FromAsyncImpl<TArg1, TArg2, TArg3>(System.Func<TArg1, TArg2, TArg3, System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Func<System.IAsyncResult, TResult>  @endFunction, System.Action<System.IAsyncResult>  @endAction, TArg1  @arg1, TArg2  @arg2, TArg3  @arg3, System.Object  @state, System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {typeof(TArg1), typeof(TArg2), typeof(TArg3)};
            var ___parameters = new object[]{@beginMethod, @endFunction, @endAction, @arg1, @arg2, @arg3, @state, @creationOptions};
            var ___result = RFromAsyncImpl_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance  @thisRef, TArgs  @args, System.Func<TInstance, TArgs, System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Func<TInstance, System.IAsyncResult, TResult>  @endMethod) where TInstance : class
        {

            var ___genericsType = new Type[] {typeof(TInstance), typeof(TArgs)};
            var ___parameters = new object[]{@thisRef, @args, @beginMethod, @endMethod};
            var ___result = RFromAsyncTrim_GTInstance_GTArgs_TInstance_TArgs_Func_d_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_p__Func_d_TInstance_IAsyncResult_TResult_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task<TResult> CreateCanceledTask(System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.CancellationToken  @ct)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationOptions, @ct};
            var ___result = RCreateCanceledTask_TaskContinuationOptions_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAll(System.Threading.Tasks.Task[]  @tasks, System.Func<System.Threading.Tasks.Task[], TResult>  @continuationFunction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationFunction};
            var ___result = RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAll(System.Threading.Tasks.Task[]  @tasks, System.Func<System.Threading.Tasks.Task[], TResult>  @continuationFunction, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationFunction, @cancellationToken};
            var ___result = RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAll(System.Threading.Tasks.Task[]  @tasks, System.Func<System.Threading.Tasks.Task[], TResult>  @continuationFunction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationFunction, @continuationOptions};
            var ___result = RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAll(System.Threading.Tasks.Task[]  @tasks, System.Func<System.Threading.Tasks.Task[], TResult>  @continuationFunction, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationFunction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RContinueWhenAll_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAll<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>[], TResult>  @continuationFunction)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction};
            var ___result = RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAll<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>[], TResult>  @continuationFunction, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @cancellationToken};
            var ___result = RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAll<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>[], TResult>  @continuationFunction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @continuationOptions};
            var ___result = RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAll<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>[], TResult>  @continuationFunction, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task<TResult> ContinueWhenAllImpl<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>[], TResult>  @continuationFunction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @continuationOptions, @cancellationToken, @scheduler};
            var ___result = RContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task<TResult> ContinueWhenAllImpl<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Action<System.Threading.Tasks.Task<TAntecedentResult>[]>  @continuationAction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationAction, @continuationOptions, @cancellationToken, @scheduler};
            var ___result = RContinueWhenAllImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__TaskContinuationOptions_CancellationToken_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task<TResult> ContinueWhenAllImpl(System.Threading.Tasks.Task[]  @tasks, System.Func<System.Threading.Tasks.Task[], TResult>  @continuationFunction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationFunction, @continuationOptions, @cancellationToken, @scheduler};
            var ___result = RContinueWhenAllImpl_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task<TResult> ContinueWhenAllImpl(System.Threading.Tasks.Task[]  @tasks, System.Action<System.Threading.Tasks.Task[]>  @continuationAction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationAction, @continuationOptions, @cancellationToken, @scheduler};
            var ___result = RContinueWhenAllImpl_TaskArray_Action_d_TaskArray_p__TaskContinuationOptions_CancellationToken_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAny(System.Threading.Tasks.Task[]  @tasks, System.Func<System.Threading.Tasks.Task, TResult>  @continuationFunction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationFunction};
            var ___result = RContinueWhenAny_TaskArray_Func_d_Task_TResult_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAny(System.Threading.Tasks.Task[]  @tasks, System.Func<System.Threading.Tasks.Task, TResult>  @continuationFunction, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationFunction, @cancellationToken};
            var ___result = RContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAny(System.Threading.Tasks.Task[]  @tasks, System.Func<System.Threading.Tasks.Task, TResult>  @continuationFunction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationFunction, @continuationOptions};
            var ___result = RContinueWhenAny_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAny(System.Threading.Tasks.Task[]  @tasks, System.Func<System.Threading.Tasks.Task, TResult>  @continuationFunction, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationFunction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RContinueWhenAny_TaskArray_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAny<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>, TResult>  @continuationFunction)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction};
            var ___result = RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAny<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>, TResult>  @continuationFunction, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @cancellationToken};
            var ___result = RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAny<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>, TResult>  @continuationFunction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @continuationOptions};
            var ___result = RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAny<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>, TResult>  @continuationFunction, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task<TResult> ContinueWhenAnyImpl(System.Threading.Tasks.Task[]  @tasks, System.Action<System.Threading.Tasks.Task>  @continuationAction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationAction, @continuationOptions, @cancellationToken, @scheduler};
            var ___result = RContinueWhenAnyImpl_TaskArray_Action_d_Task_p__TaskContinuationOptions_CancellationToken_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task<TResult> ContinueWhenAnyImpl(System.Threading.Tasks.Task[]  @tasks, System.Func<System.Threading.Tasks.Task, TResult>  @continuationFunction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationFunction, @continuationOptions, @cancellationToken, @scheduler};
            var ___result = RContinueWhenAnyImpl_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task<TResult> ContinueWhenAnyImpl<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>, TResult>  @continuationFunction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @continuationOptions, @cancellationToken, @scheduler};
            var ___result = RContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions_CancellationToken_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task<TResult> ContinueWhenAnyImpl<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Action<System.Threading.Tasks.Task<TAntecedentResult>>  @continuationAction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationAction, @continuationOptions, @cancellationToken, @scheduler};
            var ___result = RContinueWhenAnyImpl_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__TaskContinuationOptions_CancellationToken_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
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
