using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks
{
	/// <summary>
	/// System.Threading.Tasks.TaskFactory
	/// </summary>
    public partial class RTaskFactory : RMember //
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
		/// Void CheckCreationOptions(System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected static RMethod r_RCheckCreationOptions_TaskCreationOptions;
		public static RMethod RCheckCreationOptions_TaskCreationOptions
		{
			get
			{
				if(r_RCheckCreationOptions_TaskCreationOptions == null)
				{
					r_RCheckCreationOptions_TaskCreationOptions = new(typeof(System.Threading.Tasks.TaskFactory), "CheckCreationOptions", 0, typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RCheckCreationOptions_TaskCreationOptions.SetBelong(null);
				}
				return r_RCheckCreationOptions_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task StartNew(System.Action)
		/// </summary>
		protected RMethod r_RStartNew_Action;
		public virtual RMethod RStartNew_Action
		{
			get
			{
				if(r_RStartNew_Action == null)
				{
					r_RStartNew_Action = new(this, "StartNew", 0, typeof(System.Action));
					r_RStartNew_Action.SetBelong(this.instance);
				}
				return r_RStartNew_Action;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task StartNew(System.Action, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RStartNew_Action_CancellationToken;
		public virtual RMethod RStartNew_Action_CancellationToken
		{
			get
			{
				if(r_RStartNew_Action_CancellationToken == null)
				{
					r_RStartNew_Action_CancellationToken = new(this, "StartNew", 0, typeof(System.Action), typeof(System.Threading.CancellationToken));
					r_RStartNew_Action_CancellationToken.SetBelong(this.instance);
				}
				return r_RStartNew_Action_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task StartNew(System.Action, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_RStartNew_Action_TaskCreationOptions;
		public virtual RMethod RStartNew_Action_TaskCreationOptions
		{
			get
			{
				if(r_RStartNew_Action_TaskCreationOptions == null)
				{
					r_RStartNew_Action_TaskCreationOptions = new(this, "StartNew", 0, typeof(System.Action), typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RStartNew_Action_TaskCreationOptions.SetBelong(this.instance);
				}
				return r_RStartNew_Action_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task StartNew(System.Action, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RStartNew_Action_CancellationToken_TaskCreationOptions_TaskScheduler;
		public virtual RMethod RStartNew_Action_CancellationToken_TaskCreationOptions_TaskScheduler
		{
			get
			{
				if(r_RStartNew_Action_CancellationToken_TaskCreationOptions_TaskScheduler == null)
				{
					r_RStartNew_Action_CancellationToken_TaskCreationOptions_TaskScheduler = new(this, "StartNew", 0, typeof(System.Action), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskCreationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RStartNew_Action_CancellationToken_TaskCreationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RStartNew_Action_CancellationToken_TaskCreationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task StartNew(System.Action, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RStartNew_Action_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler;
		public virtual RMethod RStartNew_Action_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler
		{
			get
			{
				if(r_RStartNew_Action_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler == null)
				{
					r_RStartNew_Action_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler = new(this, "StartNew", 0, typeof(System.Action), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskCreationOptions),  ReleactionUtils.GetType("System.Threading.Tasks.InternalTaskOptions"), typeof(System.Threading.Tasks.TaskScheduler));
					r_RStartNew_Action_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RStartNew_Action_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task StartNew(System.Action`1[System.Object], System.Object)
		/// </summary>
		protected RMethod r_RStartNew_Action_d_Object_p__Object;
		public virtual RMethod RStartNew_Action_d_Object_p__Object
		{
			get
			{
				if(r_RStartNew_Action_d_Object_p__Object == null)
				{
					r_RStartNew_Action_d_Object_p__Object = new(this, "StartNew", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Object)), typeof(System.Object));
					r_RStartNew_Action_d_Object_p__Object.SetBelong(this.instance);
				}
				return r_RStartNew_Action_d_Object_p__Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task StartNew(System.Action`1[System.Object], System.Object, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RStartNew_Action_d_Object_p__Object_CancellationToken;
		public virtual RMethod RStartNew_Action_d_Object_p__Object_CancellationToken
		{
			get
			{
				if(r_RStartNew_Action_d_Object_p__Object_CancellationToken == null)
				{
					r_RStartNew_Action_d_Object_p__Object_CancellationToken = new(this, "StartNew", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Object)), typeof(System.Object), typeof(System.Threading.CancellationToken));
					r_RStartNew_Action_d_Object_p__Object_CancellationToken.SetBelong(this.instance);
				}
				return r_RStartNew_Action_d_Object_p__Object_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task StartNew(System.Action`1[System.Object], System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_RStartNew_Action_d_Object_p__Object_TaskCreationOptions;
		public virtual RMethod RStartNew_Action_d_Object_p__Object_TaskCreationOptions
		{
			get
			{
				if(r_RStartNew_Action_d_Object_p__Object_TaskCreationOptions == null)
				{
					r_RStartNew_Action_d_Object_p__Object_TaskCreationOptions = new(this, "StartNew", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Object)), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RStartNew_Action_d_Object_p__Object_TaskCreationOptions.SetBelong(this.instance);
				}
				return r_RStartNew_Action_d_Object_p__Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task StartNew(System.Action`1[System.Object], System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RStartNew_Action_d_Object_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler;
		public virtual RMethod RStartNew_Action_d_Object_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler
		{
			get
			{
				if(r_RStartNew_Action_d_Object_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler == null)
				{
					r_RStartNew_Action_d_Object_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler = new(this, "StartNew", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Object)), typeof(System.Object), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskCreationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RStartNew_Action_d_Object_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RStartNew_Action_d_Object_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] StartNew[TResult](System.Func`1[TResult])
		/// </summary>
		protected RMethod r_RStartNew_GTResult_Func_d_TResult_p_;
		public virtual RMethod RStartNew_GTResult_Func_d_TResult_p_
		{
			get
			{
				if(r_RStartNew_GTResult_Func_d_TResult_p_ == null)
				{
					r_RStartNew_GTResult_Func_d_TResult_p_ = new(this, "StartNew", 1, typeof(System.Func<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RStartNew_GTResult_Func_d_TResult_p_.SetBelong(this.instance);
				}
				return r_RStartNew_GTResult_Func_d_TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] StartNew[TResult](System.Func`1[TResult], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RStartNew_GTResult_Func_d_TResult_p__CancellationToken;
		public virtual RMethod RStartNew_GTResult_Func_d_TResult_p__CancellationToken
		{
			get
			{
				if(r_RStartNew_GTResult_Func_d_TResult_p__CancellationToken == null)
				{
					r_RStartNew_GTResult_Func_d_TResult_p__CancellationToken = new(this, "StartNew", 1, typeof(System.Func<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken));
					r_RStartNew_GTResult_Func_d_TResult_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RStartNew_GTResult_Func_d_TResult_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] StartNew[TResult](System.Func`1[TResult], System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_RStartNew_GTResult_Func_d_TResult_p__TaskCreationOptions;
		public virtual RMethod RStartNew_GTResult_Func_d_TResult_p__TaskCreationOptions
		{
			get
			{
				if(r_RStartNew_GTResult_Func_d_TResult_p__TaskCreationOptions == null)
				{
					r_RStartNew_GTResult_Func_d_TResult_p__TaskCreationOptions = new(this, "StartNew", 1, typeof(System.Func<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RStartNew_GTResult_Func_d_TResult_p__TaskCreationOptions.SetBelong(this.instance);
				}
				return r_RStartNew_GTResult_Func_d_TResult_p__TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] StartNew[TResult](System.Func`1[TResult], System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RStartNew_GTResult_Func_d_TResult_p__CancellationToken_TaskCreationOptions_TaskScheduler;
		public virtual RMethod RStartNew_GTResult_Func_d_TResult_p__CancellationToken_TaskCreationOptions_TaskScheduler
		{
			get
			{
				if(r_RStartNew_GTResult_Func_d_TResult_p__CancellationToken_TaskCreationOptions_TaskScheduler == null)
				{
					r_RStartNew_GTResult_Func_d_TResult_p__CancellationToken_TaskCreationOptions_TaskScheduler = new(this, "StartNew", 1, typeof(System.Func<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskCreationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RStartNew_GTResult_Func_d_TResult_p__CancellationToken_TaskCreationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RStartNew_GTResult_Func_d_TResult_p__CancellationToken_TaskCreationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] StartNew[TResult](System.Func`2[System.Object,TResult], System.Object)
		/// </summary>
		protected RMethod r_RStartNew_GTResult_Func_d_Object_TResult_p__Object;
		public virtual RMethod RStartNew_GTResult_Func_d_Object_TResult_p__Object
		{
			get
			{
				if(r_RStartNew_GTResult_Func_d_Object_TResult_p__Object == null)
				{
					r_RStartNew_GTResult_Func_d_Object_TResult_p__Object = new(this, "StartNew", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object));
					r_RStartNew_GTResult_Func_d_Object_TResult_p__Object.SetBelong(this.instance);
				}
				return r_RStartNew_GTResult_Func_d_Object_TResult_p__Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] StartNew[TResult](System.Func`2[System.Object,TResult], System.Object, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RStartNew_GTResult_Func_d_Object_TResult_p__Object_CancellationToken;
		public virtual RMethod RStartNew_GTResult_Func_d_Object_TResult_p__Object_CancellationToken
		{
			get
			{
				if(r_RStartNew_GTResult_Func_d_Object_TResult_p__Object_CancellationToken == null)
				{
					r_RStartNew_GTResult_Func_d_Object_TResult_p__Object_CancellationToken = new(this, "StartNew", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.CancellationToken));
					r_RStartNew_GTResult_Func_d_Object_TResult_p__Object_CancellationToken.SetBelong(this.instance);
				}
				return r_RStartNew_GTResult_Func_d_Object_TResult_p__Object_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] StartNew[TResult](System.Func`2[System.Object,TResult], System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_RStartNew_GTResult_Func_d_Object_TResult_p__Object_TaskCreationOptions;
		public virtual RMethod RStartNew_GTResult_Func_d_Object_TResult_p__Object_TaskCreationOptions
		{
			get
			{
				if(r_RStartNew_GTResult_Func_d_Object_TResult_p__Object_TaskCreationOptions == null)
				{
					r_RStartNew_GTResult_Func_d_Object_TResult_p__Object_TaskCreationOptions = new(this, "StartNew", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RStartNew_GTResult_Func_d_Object_TResult_p__Object_TaskCreationOptions.SetBelong(this.instance);
				}
				return r_RStartNew_GTResult_Func_d_Object_TResult_p__Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] StartNew[TResult](System.Func`2[System.Object,TResult], System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RStartNew_GTResult_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler;
		public virtual RMethod RStartNew_GTResult_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler
		{
			get
			{
				if(r_RStartNew_GTResult_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler == null)
				{
					r_RStartNew_GTResult_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler = new(this, "StartNew", 1, typeof(System.Func<, >).MakeGenericType(typeof(System.Object), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskCreationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RStartNew_GTResult_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RStartNew_GTResult_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FromAsync(System.IAsyncResult, System.Action`1[System.IAsyncResult])
		/// </summary>
		protected RMethod r_RFromAsync_IAsyncResult_Action_d_IAsyncResult_p_;
		public virtual RMethod RFromAsync_IAsyncResult_Action_d_IAsyncResult_p_
		{
			get
			{
				if(r_RFromAsync_IAsyncResult_Action_d_IAsyncResult_p_ == null)
				{
					r_RFromAsync_IAsyncResult_Action_d_IAsyncResult_p_ = new(this, "FromAsync", 0, typeof(System.IAsyncResult), typeof(System.Action<>).MakeGenericType(typeof(System.IAsyncResult)));
					r_RFromAsync_IAsyncResult_Action_d_IAsyncResult_p_.SetBelong(this.instance);
				}
				return r_RFromAsync_IAsyncResult_Action_d_IAsyncResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FromAsync(System.IAsyncResult, System.Action`1[System.IAsyncResult], System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_RFromAsync_IAsyncResult_Action_d_IAsyncResult_p__TaskCreationOptions;
		public virtual RMethod RFromAsync_IAsyncResult_Action_d_IAsyncResult_p__TaskCreationOptions
		{
			get
			{
				if(r_RFromAsync_IAsyncResult_Action_d_IAsyncResult_p__TaskCreationOptions == null)
				{
					r_RFromAsync_IAsyncResult_Action_d_IAsyncResult_p__TaskCreationOptions = new(this, "FromAsync", 0, typeof(System.IAsyncResult), typeof(System.Action<>).MakeGenericType(typeof(System.IAsyncResult)), typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RFromAsync_IAsyncResult_Action_d_IAsyncResult_p__TaskCreationOptions.SetBelong(this.instance);
				}
				return r_RFromAsync_IAsyncResult_Action_d_IAsyncResult_p__TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FromAsync(System.IAsyncResult, System.Action`1[System.IAsyncResult], System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RFromAsync_IAsyncResult_Action_d_IAsyncResult_p__TaskCreationOptions_TaskScheduler;
		public virtual RMethod RFromAsync_IAsyncResult_Action_d_IAsyncResult_p__TaskCreationOptions_TaskScheduler
		{
			get
			{
				if(r_RFromAsync_IAsyncResult_Action_d_IAsyncResult_p__TaskCreationOptions_TaskScheduler == null)
				{
					r_RFromAsync_IAsyncResult_Action_d_IAsyncResult_p__TaskCreationOptions_TaskScheduler = new(this, "FromAsync", 0, typeof(System.IAsyncResult), typeof(System.Action<>).MakeGenericType(typeof(System.IAsyncResult)), typeof(System.Threading.Tasks.TaskCreationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RFromAsync_IAsyncResult_Action_d_IAsyncResult_p__TaskCreationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RFromAsync_IAsyncResult_Action_d_IAsyncResult_p__TaskCreationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FromAsync(System.Func`3[System.AsyncCallback,System.Object,System.IAsyncResult], System.Action`1[System.IAsyncResult], System.Object)
		/// </summary>
		protected RMethod r_RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__Object;
		public virtual RMethod RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__Object
		{
			get
			{
				if(r_RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__Object == null)
				{
					r_RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__Object = new(this, "FromAsync", 0, typeof(System.Func<, , >).MakeGenericType(typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Action<>).MakeGenericType(typeof(System.IAsyncResult)), typeof(System.Object));
					r_RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__Object.SetBelong(this.instance);
				}
				return r_RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FromAsync(System.Func`3[System.AsyncCallback,System.Object,System.IAsyncResult], System.Action`1[System.IAsyncResult], System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__Object_TaskCreationOptions;
		public virtual RMethod RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__Object_TaskCreationOptions
		{
			get
			{
				if(r_RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__Object_TaskCreationOptions == null)
				{
					r_RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__Object_TaskCreationOptions = new(this, "FromAsync", 0, typeof(System.Func<, , >).MakeGenericType(typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Action<>).MakeGenericType(typeof(System.IAsyncResult)), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__Object_TaskCreationOptions.SetBelong(this.instance);
				}
				return r_RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FromAsync[TArg1](System.Func`4[TArg1,System.AsyncCallback,System.Object,System.IAsyncResult], System.Action`1[System.IAsyncResult], TArg1, System.Object)
		/// </summary>
		protected RMethod r_RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_Object;
		public virtual RMethod RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_Object
		{
			get
			{
				if(r_RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_Object == null)
				{
					r_RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_Object = new(this, "FromAsync", 1, typeof(System.Func<, , , >).MakeGenericType(Type.MakeGenericMethodParameter(0), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Action<>).MakeGenericType(typeof(System.IAsyncResult)), Type.MakeGenericMethodParameter(0), typeof(System.Object));
					r_RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_Object.SetBelong(this.instance);
				}
				return r_RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FromAsync[TArg1](System.Func`4[TArg1,System.AsyncCallback,System.Object,System.IAsyncResult], System.Action`1[System.IAsyncResult], TArg1, System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_Object_TaskCreationOptions;
		public virtual RMethod RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_Object_TaskCreationOptions
		{
			get
			{
				if(r_RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_Object_TaskCreationOptions == null)
				{
					r_RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_Object_TaskCreationOptions = new(this, "FromAsync", 1, typeof(System.Func<, , , >).MakeGenericType(Type.MakeGenericMethodParameter(0), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Action<>).MakeGenericType(typeof(System.IAsyncResult)), Type.MakeGenericMethodParameter(0), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_Object_TaskCreationOptions.SetBelong(this.instance);
				}
				return r_RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FromAsync[TArg1,TArg2](System.Func`5[TArg1,TArg2,System.AsyncCallback,System.Object,System.IAsyncResult], System.Action`1[System.IAsyncResult], TArg1, TArg2, System.Object)
		/// </summary>
		protected RMethod r_RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object;
		public virtual RMethod RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object
		{
			get
			{
				if(r_RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object == null)
				{
					r_RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object = new(this, "FromAsync", 2, typeof(System.Func<, , , , >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Action<>).MakeGenericType(typeof(System.IAsyncResult)), Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), typeof(System.Object));
					r_RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object.SetBelong(this.instance);
				}
				return r_RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FromAsync[TArg1,TArg2](System.Func`5[TArg1,TArg2,System.AsyncCallback,System.Object,System.IAsyncResult], System.Action`1[System.IAsyncResult], TArg1, TArg2, System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object_TaskCreationOptions;
		public virtual RMethod RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object_TaskCreationOptions
		{
			get
			{
				if(r_RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object_TaskCreationOptions == null)
				{
					r_RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object_TaskCreationOptions = new(this, "FromAsync", 2, typeof(System.Func<, , , , >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Action<>).MakeGenericType(typeof(System.IAsyncResult)), Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object_TaskCreationOptions.SetBelong(this.instance);
				}
				return r_RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FromAsync[TArg1,TArg2,TArg3](System.Func`6[TArg1,TArg2,TArg3,System.AsyncCallback,System.Object,System.IAsyncResult], System.Action`1[System.IAsyncResult], TArg1, TArg2, TArg3, System.Object)
		/// </summary>
		protected RMethod r_RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object;
		public virtual RMethod RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object
		{
			get
			{
				if(r_RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object == null)
				{
					r_RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object = new(this, "FromAsync", 3, typeof(System.Func<, , , , , >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), Type.MakeGenericMethodParameter(2), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Action<>).MakeGenericType(typeof(System.IAsyncResult)), Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), Type.MakeGenericMethodParameter(2), typeof(System.Object));
					r_RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object.SetBelong(this.instance);
				}
				return r_RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FromAsync[TArg1,TArg2,TArg3](System.Func`6[TArg1,TArg2,TArg3,System.AsyncCallback,System.Object,System.IAsyncResult], System.Action`1[System.IAsyncResult], TArg1, TArg2, TArg3, System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions;
		public virtual RMethod RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions
		{
			get
			{
				if(r_RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions == null)
				{
					r_RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions = new(this, "FromAsync", 3, typeof(System.Func<, , , , , >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), Type.MakeGenericMethodParameter(2), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Action<>).MakeGenericType(typeof(System.IAsyncResult)), Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), Type.MakeGenericMethodParameter(2), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions.SetBelong(this.instance);
				}
				return r_RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync[TResult](System.IAsyncResult, System.Func`2[System.IAsyncResult,TResult])
		/// </summary>
		protected RMethod r_RFromAsync_GTResult_IAsyncResult_Func_d_IAsyncResult_TResult_p_;
		public virtual RMethod RFromAsync_GTResult_IAsyncResult_Func_d_IAsyncResult_TResult_p_
		{
			get
			{
				if(r_RFromAsync_GTResult_IAsyncResult_Func_d_IAsyncResult_TResult_p_ == null)
				{
					r_RFromAsync_GTResult_IAsyncResult_Func_d_IAsyncResult_TResult_p_ = new(this, "FromAsync", 1, typeof(System.IAsyncResult), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)));
					r_RFromAsync_GTResult_IAsyncResult_Func_d_IAsyncResult_TResult_p_.SetBelong(this.instance);
				}
				return r_RFromAsync_GTResult_IAsyncResult_Func_d_IAsyncResult_TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync[TResult](System.IAsyncResult, System.Func`2[System.IAsyncResult,TResult], System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_RFromAsync_GTResult_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions;
		public virtual RMethod RFromAsync_GTResult_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions
		{
			get
			{
				if(r_RFromAsync_GTResult_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions == null)
				{
					r_RFromAsync_GTResult_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions = new(this, "FromAsync", 1, typeof(System.IAsyncResult), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RFromAsync_GTResult_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions.SetBelong(this.instance);
				}
				return r_RFromAsync_GTResult_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync[TResult](System.IAsyncResult, System.Func`2[System.IAsyncResult,TResult], System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RFromAsync_GTResult_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions_TaskScheduler;
		public virtual RMethod RFromAsync_GTResult_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions_TaskScheduler
		{
			get
			{
				if(r_RFromAsync_GTResult_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions_TaskScheduler == null)
				{
					r_RFromAsync_GTResult_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions_TaskScheduler = new(this, "FromAsync", 1, typeof(System.IAsyncResult), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskCreationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RFromAsync_GTResult_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RFromAsync_GTResult_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync[TResult](System.Func`3[System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], System.Object)
		/// </summary>
		protected RMethod r_RFromAsync_GTResult_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object;
		public virtual RMethod RFromAsync_GTResult_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object
		{
			get
			{
				if(r_RFromAsync_GTResult_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object == null)
				{
					r_RFromAsync_GTResult_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object = new(this, "FromAsync", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), typeof(System.Object));
					r_RFromAsync_GTResult_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object.SetBelong(this.instance);
				}
				return r_RFromAsync_GTResult_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync[TResult](System.Func`3[System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_RFromAsync_GTResult_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object_TaskCreationOptions;
		public virtual RMethod RFromAsync_GTResult_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object_TaskCreationOptions
		{
			get
			{
				if(r_RFromAsync_GTResult_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object_TaskCreationOptions == null)
				{
					r_RFromAsync_GTResult_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object_TaskCreationOptions = new(this, "FromAsync", 1, typeof(System.Func<, , >).MakeGenericType(typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RFromAsync_GTResult_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object_TaskCreationOptions.SetBelong(this.instance);
				}
				return r_RFromAsync_GTResult_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync[TArg1,TResult](System.Func`4[TArg1,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], TArg1, System.Object)
		/// </summary>
		protected RMethod r_RFromAsync_GTArg1_GTResult_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object;
		public virtual RMethod RFromAsync_GTArg1_GTResult_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object
		{
			get
			{
				if(r_RFromAsync_GTArg1_GTResult_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object == null)
				{
					r_RFromAsync_GTArg1_GTResult_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object = new(this, "FromAsync", 2, typeof(System.Func<, , , >).MakeGenericType(Type.MakeGenericMethodParameter(0), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(1)), Type.MakeGenericMethodParameter(0), typeof(System.Object));
					r_RFromAsync_GTArg1_GTResult_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object.SetBelong(this.instance);
				}
				return r_RFromAsync_GTArg1_GTResult_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync[TArg1,TResult](System.Func`4[TArg1,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], TArg1, System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_RFromAsync_GTArg1_GTResult_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object_TaskCreationOptions;
		public virtual RMethod RFromAsync_GTArg1_GTResult_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object_TaskCreationOptions
		{
			get
			{
				if(r_RFromAsync_GTArg1_GTResult_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object_TaskCreationOptions == null)
				{
					r_RFromAsync_GTArg1_GTResult_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object_TaskCreationOptions = new(this, "FromAsync", 2, typeof(System.Func<, , , >).MakeGenericType(Type.MakeGenericMethodParameter(0), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(1)), Type.MakeGenericMethodParameter(0), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RFromAsync_GTArg1_GTResult_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object_TaskCreationOptions.SetBelong(this.instance);
				}
				return r_RFromAsync_GTArg1_GTResult_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync[TArg1,TArg2,TResult](System.Func`5[TArg1,TArg2,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], TArg1, TArg2, System.Object)
		/// </summary>
		protected RMethod r_RFromAsync_GTArg1_GTArg2_GTResult_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object;
		public virtual RMethod RFromAsync_GTArg1_GTArg2_GTResult_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object
		{
			get
			{
				if(r_RFromAsync_GTArg1_GTArg2_GTResult_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object == null)
				{
					r_RFromAsync_GTArg1_GTArg2_GTResult_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object = new(this, "FromAsync", 3, typeof(System.Func<, , , , >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(2)), Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), typeof(System.Object));
					r_RFromAsync_GTArg1_GTArg2_GTResult_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object.SetBelong(this.instance);
				}
				return r_RFromAsync_GTArg1_GTArg2_GTResult_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync[TArg1,TArg2,TResult](System.Func`5[TArg1,TArg2,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], TArg1, TArg2, System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_RFromAsync_GTArg1_GTArg2_GTResult_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object_TaskCreationOptions;
		public virtual RMethod RFromAsync_GTArg1_GTArg2_GTResult_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object_TaskCreationOptions
		{
			get
			{
				if(r_RFromAsync_GTArg1_GTArg2_GTResult_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object_TaskCreationOptions == null)
				{
					r_RFromAsync_GTArg1_GTArg2_GTResult_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object_TaskCreationOptions = new(this, "FromAsync", 3, typeof(System.Func<, , , , >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(2)), Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RFromAsync_GTArg1_GTArg2_GTResult_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object_TaskCreationOptions.SetBelong(this.instance);
				}
				return r_RFromAsync_GTArg1_GTArg2_GTResult_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync[TArg1,TArg2,TArg3,TResult](System.Func`6[TArg1,TArg2,TArg3,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], TArg1, TArg2, TArg3, System.Object)
		/// </summary>
		protected RMethod r_RFromAsync_GTArg1_GTArg2_GTArg3_GTResult_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object;
		public virtual RMethod RFromAsync_GTArg1_GTArg2_GTArg3_GTResult_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object
		{
			get
			{
				if(r_RFromAsync_GTArg1_GTArg2_GTArg3_GTResult_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object == null)
				{
					r_RFromAsync_GTArg1_GTArg2_GTArg3_GTResult_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object = new(this, "FromAsync", 4, typeof(System.Func<, , , , , >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), Type.MakeGenericMethodParameter(2), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(3)), Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), Type.MakeGenericMethodParameter(2), typeof(System.Object));
					r_RFromAsync_GTArg1_GTArg2_GTArg3_GTResult_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object.SetBelong(this.instance);
				}
				return r_RFromAsync_GTArg1_GTArg2_GTArg3_GTResult_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] FromAsync[TArg1,TArg2,TArg3,TResult](System.Func`6[TArg1,TArg2,TArg3,System.AsyncCallback,System.Object,System.IAsyncResult], System.Func`2[System.IAsyncResult,TResult], TArg1, TArg2, TArg3, System.Object, System.Threading.Tasks.TaskCreationOptions)
		/// </summary>
		protected RMethod r_RFromAsync_GTArg1_GTArg2_GTArg3_GTResult_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions;
		public virtual RMethod RFromAsync_GTArg1_GTArg2_GTArg3_GTResult_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions
		{
			get
			{
				if(r_RFromAsync_GTArg1_GTArg2_GTArg3_GTResult_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions == null)
				{
					r_RFromAsync_GTArg1_GTArg2_GTArg3_GTResult_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions = new(this, "FromAsync", 4, typeof(System.Func<, , , , , >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), Type.MakeGenericMethodParameter(2), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.IAsyncResult)), typeof(System.Func<, >).MakeGenericType(typeof(System.IAsyncResult), Type.MakeGenericMethodParameter(3)), Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1), Type.MakeGenericMethodParameter(2), typeof(System.Object), typeof(System.Threading.Tasks.TaskCreationOptions));
					r_RFromAsync_GTArg1_GTArg2_GTArg3_GTResult_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions.SetBelong(this.instance);
				}
				return r_RFromAsync_GTArg1_GTArg2_GTArg3_GTResult_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions;
			}
		}

		/// <summary>
		/// Void CheckFromAsyncOptions(System.Threading.Tasks.TaskCreationOptions, Boolean)
		/// </summary>
		protected static RMethod r_RCheckFromAsyncOptions_TaskCreationOptions_Boolean;
		public static RMethod RCheckFromAsyncOptions_TaskCreationOptions_Boolean
		{
			get
			{
				if(r_RCheckFromAsyncOptions_TaskCreationOptions_Boolean == null)
				{
					r_RCheckFromAsyncOptions_TaskCreationOptions_Boolean = new(typeof(System.Threading.Tasks.TaskFactory), "CheckFromAsyncOptions", 0, typeof(System.Threading.Tasks.TaskCreationOptions), typeof(System.Boolean));
					r_RCheckFromAsyncOptions_TaskCreationOptions_Boolean.SetBelong(null);
				}
				return r_RCheckFromAsyncOptions_TaskCreationOptions_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Threading.Tasks.Task[]] CommonCWAllLogic(System.Threading.Tasks.Task[])
		/// </summary>
		protected static RMethod r_RCommonCWAllLogic_TaskArray;
		public static RMethod RCommonCWAllLogic_TaskArray
		{
			get
			{
				if(r_RCommonCWAllLogic_TaskArray == null)
				{
					r_RCommonCWAllLogic_TaskArray = new(typeof(System.Threading.Tasks.TaskFactory), "CommonCWAllLogic", 0, typeof(System.Threading.Tasks.Task).MakeArrayType());
					r_RCommonCWAllLogic_TaskArray.SetBelong(null);
				}
				return r_RCommonCWAllLogic_TaskArray;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Threading.Tasks.Task`1[T][]] CommonCWAllLogic[T](System.Threading.Tasks.Task`1[T][])
		/// </summary>
		protected static RMethod r_RCommonCWAllLogic_GT_Task_d_T_p_Array;
		public static RMethod RCommonCWAllLogic_GT_Task_d_T_p_Array
		{
			get
			{
				if(r_RCommonCWAllLogic_GT_Task_d_T_p_Array == null)
				{
					r_RCommonCWAllLogic_GT_Task_d_T_p_Array = new(typeof(System.Threading.Tasks.TaskFactory), "CommonCWAllLogic", 1, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType());
					r_RCommonCWAllLogic_GT_Task_d_T_p_Array.SetBelong(null);
				}
				return r_RCommonCWAllLogic_GT_Task_d_T_p_Array;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWhenAll(System.Threading.Tasks.Task[], System.Action`1[System.Threading.Tasks.Task[]])
		/// </summary>
		protected RMethod r_RContinueWhenAll_TaskArray_Action_d_TaskArray_p_;
		public virtual RMethod RContinueWhenAll_TaskArray_Action_d_TaskArray_p_
		{
			get
			{
				if(r_RContinueWhenAll_TaskArray_Action_d_TaskArray_p_ == null)
				{
					r_RContinueWhenAll_TaskArray_Action_d_TaskArray_p_ = new(this, "ContinueWhenAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task).MakeArrayType()));
					r_RContinueWhenAll_TaskArray_Action_d_TaskArray_p_.SetBelong(this.instance);
				}
				return r_RContinueWhenAll_TaskArray_Action_d_TaskArray_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWhenAll(System.Threading.Tasks.Task[], System.Action`1[System.Threading.Tasks.Task[]], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RContinueWhenAll_TaskArray_Action_d_TaskArray_p__CancellationToken;
		public virtual RMethod RContinueWhenAll_TaskArray_Action_d_TaskArray_p__CancellationToken
		{
			get
			{
				if(r_RContinueWhenAll_TaskArray_Action_d_TaskArray_p__CancellationToken == null)
				{
					r_RContinueWhenAll_TaskArray_Action_d_TaskArray_p__CancellationToken = new(this, "ContinueWhenAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task).MakeArrayType()), typeof(System.Threading.CancellationToken));
					r_RContinueWhenAll_TaskArray_Action_d_TaskArray_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RContinueWhenAll_TaskArray_Action_d_TaskArray_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWhenAll(System.Threading.Tasks.Task[], System.Action`1[System.Threading.Tasks.Task[]], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWhenAll_TaskArray_Action_d_TaskArray_p__TaskContinuationOptions;
		public virtual RMethod RContinueWhenAll_TaskArray_Action_d_TaskArray_p__TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWhenAll_TaskArray_Action_d_TaskArray_p__TaskContinuationOptions == null)
				{
					r_RContinueWhenAll_TaskArray_Action_d_TaskArray_p__TaskContinuationOptions = new(this, "ContinueWhenAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task).MakeArrayType()), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWhenAll_TaskArray_Action_d_TaskArray_p__TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWhenAll_TaskArray_Action_d_TaskArray_p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWhenAll(System.Threading.Tasks.Task[], System.Action`1[System.Threading.Tasks.Task[]], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWhenAll_TaskArray_Action_d_TaskArray_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWhenAll_TaskArray_Action_d_TaskArray_p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_RContinueWhenAll_TaskArray_Action_d_TaskArray_p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_RContinueWhenAll_TaskArray_Action_d_TaskArray_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWhenAll", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task).MakeArrayType()), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWhenAll_TaskArray_Action_d_TaskArray_p__CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWhenAll_TaskArray_Action_d_TaskArray_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWhenAll[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Action`1[System.Threading.Tasks.Task`1[TAntecedentResult][]])
		/// </summary>
		protected RMethod r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p_;
		public virtual RMethod RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p_
		{
			get
			{
				if(r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p_ == null)
				{
					r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p_ = new(this, "ContinueWhenAll", 1, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType()));
					r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p_.SetBelong(this.instance);
				}
				return r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWhenAll[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Action`1[System.Threading.Tasks.Task`1[TAntecedentResult][]], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__CancellationToken;
		public virtual RMethod RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__CancellationToken
		{
			get
			{
				if(r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__CancellationToken == null)
				{
					r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__CancellationToken = new(this, "ContinueWhenAll", 1, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType()), typeof(System.Threading.CancellationToken));
					r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWhenAll[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Action`1[System.Threading.Tasks.Task`1[TAntecedentResult][]], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__TaskContinuationOptions;
		public virtual RMethod RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__TaskContinuationOptions == null)
				{
					r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__TaskContinuationOptions = new(this, "ContinueWhenAll", 1, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType()), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWhenAll[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Action`1[System.Threading.Tasks.Task`1[TAntecedentResult][]], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWhenAll", 1, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType()), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAll[TResult](System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task[],TResult])
		/// </summary>
		protected RMethod r_RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p_;
		public virtual RMethod RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p_
		{
			get
			{
				if(r_RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p_ == null)
				{
					r_RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p_ = new(this, "ContinueWhenAll", 1, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task).MakeArrayType(), Type.MakeGenericMethodParameter(0)));
					r_RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p_.SetBelong(this.instance);
				}
				return r_RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAll[TResult](System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task[],TResult], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken;
		public virtual RMethod RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken
		{
			get
			{
				if(r_RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken == null)
				{
					r_RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken = new(this, "ContinueWhenAll", 1, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task).MakeArrayType(), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken));
					r_RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAll[TResult](System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task[],TResult], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions;
		public virtual RMethod RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions == null)
				{
					r_RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions = new(this, "ContinueWhenAll", 1, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task).MakeArrayType(), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAll[TResult](System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task[],TResult], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWhenAll", 1, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task).MakeArrayType(), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAll[TAntecedentResult,TResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult][],TResult])
		/// </summary>
		protected RMethod r_RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p_;
		public virtual RMethod RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p_
		{
			get
			{
				if(r_RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p_ == null)
				{
					r_RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p_ = new(this, "ContinueWhenAll", 2, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), Type.MakeGenericMethodParameter(1)));
					r_RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p_.SetBelong(this.instance);
				}
				return r_RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAll[TAntecedentResult,TResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult][],TResult], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken;
		public virtual RMethod RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken
		{
			get
			{
				if(r_RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken == null)
				{
					r_RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken = new(this, "ContinueWhenAll", 2, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), Type.MakeGenericMethodParameter(1)), typeof(System.Threading.CancellationToken));
					r_RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAll[TAntecedentResult,TResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult][],TResult], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions;
		public virtual RMethod RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions == null)
				{
					r_RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions = new(this, "ContinueWhenAll", 2, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), Type.MakeGenericMethodParameter(1)), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAll[TAntecedentResult,TResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult][],TResult], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWhenAll", 2, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), Type.MakeGenericMethodParameter(1)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Threading.Tasks.Task] CommonCWAnyLogic(System.Collections.Generic.IList`1[System.Threading.Tasks.Task])
		/// </summary>
		protected static RMethod r_RCommonCWAnyLogic_IList_d_Task_p_;
		public static RMethod RCommonCWAnyLogic_IList_d_Task_p_
		{
			get
			{
				if(r_RCommonCWAnyLogic_IList_d_Task_p_ == null)
				{
					r_RCommonCWAnyLogic_IList_d_Task_p_ = new(typeof(System.Threading.Tasks.TaskFactory), "CommonCWAnyLogic", 0, typeof(System.Collections.Generic.IList<>).MakeGenericType(typeof(System.Threading.Tasks.Task)));
					r_RCommonCWAnyLogic_IList_d_Task_p_.SetBelong(null);
				}
				return r_RCommonCWAnyLogic_IList_d_Task_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWhenAny(System.Threading.Tasks.Task[], System.Action`1[System.Threading.Tasks.Task])
		/// </summary>
		protected RMethod r_RContinueWhenAny_TaskArray_Action_d_Task_p_;
		public virtual RMethod RContinueWhenAny_TaskArray_Action_d_Task_p_
		{
			get
			{
				if(r_RContinueWhenAny_TaskArray_Action_d_Task_p_ == null)
				{
					r_RContinueWhenAny_TaskArray_Action_d_Task_p_ = new(this, "ContinueWhenAny", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task)));
					r_RContinueWhenAny_TaskArray_Action_d_Task_p_.SetBelong(this.instance);
				}
				return r_RContinueWhenAny_TaskArray_Action_d_Task_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWhenAny(System.Threading.Tasks.Task[], System.Action`1[System.Threading.Tasks.Task], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RContinueWhenAny_TaskArray_Action_d_Task_p__CancellationToken;
		public virtual RMethod RContinueWhenAny_TaskArray_Action_d_Task_p__CancellationToken
		{
			get
			{
				if(r_RContinueWhenAny_TaskArray_Action_d_Task_p__CancellationToken == null)
				{
					r_RContinueWhenAny_TaskArray_Action_d_Task_p__CancellationToken = new(this, "ContinueWhenAny", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Threading.CancellationToken));
					r_RContinueWhenAny_TaskArray_Action_d_Task_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RContinueWhenAny_TaskArray_Action_d_Task_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWhenAny(System.Threading.Tasks.Task[], System.Action`1[System.Threading.Tasks.Task], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWhenAny_TaskArray_Action_d_Task_p__TaskContinuationOptions;
		public virtual RMethod RContinueWhenAny_TaskArray_Action_d_Task_p__TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWhenAny_TaskArray_Action_d_Task_p__TaskContinuationOptions == null)
				{
					r_RContinueWhenAny_TaskArray_Action_d_Task_p__TaskContinuationOptions = new(this, "ContinueWhenAny", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWhenAny_TaskArray_Action_d_Task_p__TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWhenAny_TaskArray_Action_d_Task_p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWhenAny(System.Threading.Tasks.Task[], System.Action`1[System.Threading.Tasks.Task], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWhenAny_TaskArray_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWhenAny_TaskArray_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_RContinueWhenAny_TaskArray_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_RContinueWhenAny_TaskArray_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWhenAny", 0, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWhenAny_TaskArray_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWhenAny_TaskArray_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAny[TResult](System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task,TResult])
		/// </summary>
		protected RMethod r_RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p_;
		public virtual RMethod RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p_
		{
			get
			{
				if(r_RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p_ == null)
				{
					r_RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p_ = new(this, "ContinueWhenAny", 1, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)));
					r_RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p_.SetBelong(this.instance);
				}
				return r_RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAny[TResult](System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task,TResult], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p__CancellationToken;
		public virtual RMethod RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p__CancellationToken
		{
			get
			{
				if(r_RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p__CancellationToken == null)
				{
					r_RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p__CancellationToken = new(this, "ContinueWhenAny", 1, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken));
					r_RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAny[TResult](System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task,TResult], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions;
		public virtual RMethod RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions == null)
				{
					r_RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions = new(this, "ContinueWhenAny", 1, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAny[TResult](System.Threading.Tasks.Task[], System.Func`2[System.Threading.Tasks.Task,TResult], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWhenAny", 1, typeof(System.Threading.Tasks.Task).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task), Type.MakeGenericMethodParameter(0)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAny[TAntecedentResult,TResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult],TResult])
		/// </summary>
		protected RMethod r_RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p_;
		public virtual RMethod RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p_
		{
			get
			{
				if(r_RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p_ == null)
				{
					r_RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p_ = new(this, "ContinueWhenAny", 2, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(1)));
					r_RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p_.SetBelong(this.instance);
				}
				return r_RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAny[TAntecedentResult,TResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult],TResult], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken;
		public virtual RMethod RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken
		{
			get
			{
				if(r_RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken == null)
				{
					r_RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken = new(this, "ContinueWhenAny", 2, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(1)), typeof(System.Threading.CancellationToken));
					r_RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAny[TAntecedentResult,TResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult],TResult], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions;
		public virtual RMethod RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions == null)
				{
					r_RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions = new(this, "ContinueWhenAny", 2, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(1)), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] ContinueWhenAny[TAntecedentResult,TResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Func`2[System.Threading.Tasks.Task`1[TAntecedentResult],TResult], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWhenAny", 2, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Func<, >).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(1)), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWhenAny[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Action`1[System.Threading.Tasks.Task`1[TAntecedentResult]])
		/// </summary>
		protected RMethod r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p_;
		public virtual RMethod RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p_
		{
			get
			{
				if(r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p_ == null)
				{
					r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p_ = new(this, "ContinueWhenAny", 1, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0))));
					r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p_.SetBelong(this.instance);
				}
				return r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWhenAny[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Action`1[System.Threading.Tasks.Task`1[TAntecedentResult]], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__CancellationToken;
		public virtual RMethod RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__CancellationToken
		{
			get
			{
				if(r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__CancellationToken == null)
				{
					r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__CancellationToken = new(this, "ContinueWhenAny", 1, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0))), typeof(System.Threading.CancellationToken));
					r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__CancellationToken.SetBelong(this.instance);
				}
				return r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWhenAny[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Action`1[System.Threading.Tasks.Task`1[TAntecedentResult]], System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected RMethod r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__TaskContinuationOptions;
		public virtual RMethod RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__TaskContinuationOptions
		{
			get
			{
				if(r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__TaskContinuationOptions == null)
				{
					r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__TaskContinuationOptions = new(this, "ContinueWhenAny", 1, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0))), typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__TaskContinuationOptions.SetBelong(this.instance);
				}
				return r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__TaskContinuationOptions;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ContinueWhenAny[TAntecedentResult](System.Threading.Tasks.Task`1[TAntecedentResult][], System.Action`1[System.Threading.Tasks.Task`1[TAntecedentResult]], System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)
		/// </summary>
		protected RMethod r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler;
		public virtual RMethod RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler
		{
			get
			{
				if(r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler == null)
				{
					r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler = new(this, "ContinueWhenAny", 1, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType(), typeof(System.Action<>).MakeGenericType(typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0))), typeof(System.Threading.CancellationToken), typeof(System.Threading.Tasks.TaskContinuationOptions), typeof(System.Threading.Tasks.TaskScheduler));
					r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler.SetBelong(this.instance);
				}
				return r_RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task[] CheckMultiContinuationTasksAndCopy(System.Threading.Tasks.Task[])
		/// </summary>
		protected static RMethod r_RCheckMultiContinuationTasksAndCopy_TaskArray;
		public static RMethod RCheckMultiContinuationTasksAndCopy_TaskArray
		{
			get
			{
				if(r_RCheckMultiContinuationTasksAndCopy_TaskArray == null)
				{
					r_RCheckMultiContinuationTasksAndCopy_TaskArray = new(typeof(System.Threading.Tasks.TaskFactory), "CheckMultiContinuationTasksAndCopy", 0, typeof(System.Threading.Tasks.Task).MakeArrayType());
					r_RCheckMultiContinuationTasksAndCopy_TaskArray.SetBelong(null);
				}
				return r_RCheckMultiContinuationTasksAndCopy_TaskArray;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult][] CheckMultiContinuationTasksAndCopy[TResult](System.Threading.Tasks.Task`1[TResult][])
		/// </summary>
		protected static RMethod r_RCheckMultiContinuationTasksAndCopy_GTResult_Task_d_TResult_p_Array;
		public static RMethod RCheckMultiContinuationTasksAndCopy_GTResult_Task_d_TResult_p_Array
		{
			get
			{
				if(r_RCheckMultiContinuationTasksAndCopy_GTResult_Task_d_TResult_p_Array == null)
				{
					r_RCheckMultiContinuationTasksAndCopy_GTResult_Task_d_TResult_p_Array = new(typeof(System.Threading.Tasks.TaskFactory), "CheckMultiContinuationTasksAndCopy", 1, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeArrayType());
					r_RCheckMultiContinuationTasksAndCopy_GTResult_Task_d_TResult_p_Array.SetBelong(null);
				}
				return r_RCheckMultiContinuationTasksAndCopy_GTResult_Task_d_TResult_p_Array;
			}
		}

		/// <summary>
		/// Void CheckMultiTaskContinuationOptions(System.Threading.Tasks.TaskContinuationOptions)
		/// </summary>
		protected static RMethod r_RCheckMultiTaskContinuationOptions_TaskContinuationOptions;
		public static RMethod RCheckMultiTaskContinuationOptions_TaskContinuationOptions
		{
			get
			{
				if(r_RCheckMultiTaskContinuationOptions_TaskContinuationOptions == null)
				{
					r_RCheckMultiTaskContinuationOptions_TaskContinuationOptions = new(typeof(System.Threading.Tasks.TaskFactory), "CheckMultiTaskContinuationOptions", 0, typeof(System.Threading.Tasks.TaskContinuationOptions));
					r_RCheckMultiTaskContinuationOptions_TaskContinuationOptions.SetBelong(null);
				}
				return r_RCheckMultiTaskContinuationOptions_TaskContinuationOptions;
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


        public RTaskFactory() : base("System.Threading.Tasks.TaskFactory")
        {
        }

        public RTaskFactory(System.Object instance) : base("System.Threading.Tasks.TaskFactory")
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


        public static void CheckCreationOptions(System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@creationOptions};
            var ___result = RCheckCreationOptions_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.Tasks.Task StartNew(System.Action  @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = RStartNew_Action.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task StartNew(System.Action  @action, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action, @cancellationToken};
            var ___result = RStartNew_Action_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task StartNew(System.Action  @action, System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action, @creationOptions};
            var ___result = RStartNew_Action_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task StartNew(System.Action  @action, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskCreationOptions  @creationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action, @cancellationToken, @creationOptions, @scheduler};
            var ___result = RStartNew_Action_CancellationToken_TaskCreationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }



        public virtual System.Threading.Tasks.Task StartNew(System.Action<System.Object>  @action, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action, @state};
            var ___result = RStartNew_Action_d_Object_p__Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task StartNew(System.Action<System.Object>  @action, System.Object  @state, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action, @state, @cancellationToken};
            var ___result = RStartNew_Action_d_Object_p__Object_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task StartNew(System.Action<System.Object>  @action, System.Object  @state, System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action, @state, @creationOptions};
            var ___result = RStartNew_Action_d_Object_p__Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task StartNew(System.Action<System.Object>  @action, System.Object  @state, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskCreationOptions  @creationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action, @state, @cancellationToken, @creationOptions, @scheduler};
            var ___result = RStartNew_Action_d_Object_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> StartNew<TResult>(System.Func<TResult>  @function)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@function};
            var ___result = RStartNew_GTResult_Func_d_TResult_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> StartNew<TResult>(System.Func<TResult>  @function, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@function, @cancellationToken};
            var ___result = RStartNew_GTResult_Func_d_TResult_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> StartNew<TResult>(System.Func<TResult>  @function, System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@function, @creationOptions};
            var ___result = RStartNew_GTResult_Func_d_TResult_p__TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> StartNew<TResult>(System.Func<TResult>  @function, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskCreationOptions  @creationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@function, @cancellationToken, @creationOptions, @scheduler};
            var ___result = RStartNew_GTResult_Func_d_TResult_p__CancellationToken_TaskCreationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> StartNew<TResult>(System.Func<System.Object, TResult>  @function, System.Object  @state)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@function, @state};
            var ___result = RStartNew_GTResult_Func_d_Object_TResult_p__Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> StartNew<TResult>(System.Func<System.Object, TResult>  @function, System.Object  @state, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@function, @state, @cancellationToken};
            var ___result = RStartNew_GTResult_Func_d_Object_TResult_p__Object_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> StartNew<TResult>(System.Func<System.Object, TResult>  @function, System.Object  @state, System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@function, @state, @creationOptions};
            var ___result = RStartNew_GTResult_Func_d_Object_TResult_p__Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> StartNew<TResult>(System.Func<System.Object, TResult>  @function, System.Object  @state, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskCreationOptions  @creationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@function, @state, @cancellationToken, @creationOptions, @scheduler};
            var ___result = RStartNew_GTResult_Func_d_Object_TResult_p__Object_CancellationToken_TaskCreationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task FromAsync(System.IAsyncResult  @asyncResult, System.Action<System.IAsyncResult>  @endMethod)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult, @endMethod};
            var ___result = RFromAsync_IAsyncResult_Action_d_IAsyncResult_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task FromAsync(System.IAsyncResult  @asyncResult, System.Action<System.IAsyncResult>  @endMethod, System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult, @endMethod, @creationOptions};
            var ___result = RFromAsync_IAsyncResult_Action_d_IAsyncResult_p__TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task FromAsync(System.IAsyncResult  @asyncResult, System.Action<System.IAsyncResult>  @endMethod, System.Threading.Tasks.TaskCreationOptions  @creationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult, @endMethod, @creationOptions, @scheduler};
            var ___result = RFromAsync_IAsyncResult_Action_d_IAsyncResult_p__TaskCreationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task FromAsync(System.Func<System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Action<System.IAsyncResult>  @endMethod, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@beginMethod, @endMethod, @state};
            var ___result = RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task FromAsync(System.Func<System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Action<System.IAsyncResult>  @endMethod, System.Object  @state, System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@beginMethod, @endMethod, @state, @creationOptions};
            var ___result = RFromAsync_Func_d_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task FromAsync<TArg1>(System.Func<TArg1, System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Action<System.IAsyncResult>  @endMethod, TArg1  @arg1, System.Object  @state)
        {

            var ___genericsType = new Type[] {typeof(TArg1)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @arg1, @state};
            var ___result = RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task FromAsync<TArg1>(System.Func<TArg1, System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Action<System.IAsyncResult>  @endMethod, TArg1  @arg1, System.Object  @state, System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {typeof(TArg1)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @arg1, @state, @creationOptions};
            var ___result = RFromAsync_GTArg1_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task FromAsync<TArg1, TArg2>(System.Func<TArg1, TArg2, System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Action<System.IAsyncResult>  @endMethod, TArg1  @arg1, TArg2  @arg2, System.Object  @state)
        {

            var ___genericsType = new Type[] {typeof(TArg1), typeof(TArg2)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @arg1, @arg2, @state};
            var ___result = RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task FromAsync<TArg1, TArg2>(System.Func<TArg1, TArg2, System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Action<System.IAsyncResult>  @endMethod, TArg1  @arg1, TArg2  @arg2, System.Object  @state, System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {typeof(TArg1), typeof(TArg2)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @arg1, @arg2, @state, @creationOptions};
            var ___result = RFromAsync_GTArg1_GTArg2_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task FromAsync<TArg1, TArg2, TArg3>(System.Func<TArg1, TArg2, TArg3, System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Action<System.IAsyncResult>  @endMethod, TArg1  @arg1, TArg2  @arg2, TArg3  @arg3, System.Object  @state)
        {

            var ___genericsType = new Type[] {typeof(TArg1), typeof(TArg2), typeof(TArg3)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @arg1, @arg2, @arg3, @state};
            var ___result = RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task FromAsync<TArg1, TArg2, TArg3>(System.Func<TArg1, TArg2, TArg3, System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Action<System.IAsyncResult>  @endMethod, TArg1  @arg1, TArg2  @arg2, TArg3  @arg3, System.Object  @state, System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {typeof(TArg1), typeof(TArg2), typeof(TArg3)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @arg1, @arg2, @arg3, @state, @creationOptions};
            var ___result = RFromAsync_GTArg1_GTArg2_GTArg3_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Action_d_IAsyncResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync<TResult>(System.IAsyncResult  @asyncResult, System.Func<System.IAsyncResult, TResult>  @endMethod)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@asyncResult, @endMethod};
            var ___result = RFromAsync_GTResult_IAsyncResult_Func_d_IAsyncResult_TResult_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync<TResult>(System.IAsyncResult  @asyncResult, System.Func<System.IAsyncResult, TResult>  @endMethod, System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@asyncResult, @endMethod, @creationOptions};
            var ___result = RFromAsync_GTResult_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync<TResult>(System.IAsyncResult  @asyncResult, System.Func<System.IAsyncResult, TResult>  @endMethod, System.Threading.Tasks.TaskCreationOptions  @creationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@asyncResult, @endMethod, @creationOptions, @scheduler};
            var ___result = RFromAsync_GTResult_IAsyncResult_Func_d_IAsyncResult_TResult_p__TaskCreationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync<TResult>(System.Func<System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Func<System.IAsyncResult, TResult>  @endMethod, System.Object  @state)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @state};
            var ___result = RFromAsync_GTResult_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync<TResult>(System.Func<System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Func<System.IAsyncResult, TResult>  @endMethod, System.Object  @state, System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @state, @creationOptions};
            var ___result = RFromAsync_GTResult_Func_d_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync<TArg1, TResult>(System.Func<TArg1, System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Func<System.IAsyncResult, TResult>  @endMethod, TArg1  @arg1, System.Object  @state)
        {

            var ___genericsType = new Type[] {typeof(TArg1), typeof(TResult)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @arg1, @state};
            var ___result = RFromAsync_GTArg1_GTResult_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync<TArg1, TResult>(System.Func<TArg1, System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Func<System.IAsyncResult, TResult>  @endMethod, TArg1  @arg1, System.Object  @state, System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {typeof(TArg1), typeof(TResult)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @arg1, @state, @creationOptions};
            var ___result = RFromAsync_GTArg1_GTResult_Func_d_TArg1_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync<TArg1, TArg2, TResult>(System.Func<TArg1, TArg2, System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Func<System.IAsyncResult, TResult>  @endMethod, TArg1  @arg1, TArg2  @arg2, System.Object  @state)
        {

            var ___genericsType = new Type[] {typeof(TArg1), typeof(TArg2), typeof(TResult)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @arg1, @arg2, @state};
            var ___result = RFromAsync_GTArg1_GTArg2_GTResult_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync<TArg1, TArg2, TResult>(System.Func<TArg1, TArg2, System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Func<System.IAsyncResult, TResult>  @endMethod, TArg1  @arg1, TArg2  @arg2, System.Object  @state, System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {typeof(TArg1), typeof(TArg2), typeof(TResult)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @arg1, @arg2, @state, @creationOptions};
            var ___result = RFromAsync_GTArg1_GTArg2_GTResult_Func_d_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync<TArg1, TArg2, TArg3, TResult>(System.Func<TArg1, TArg2, TArg3, System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Func<System.IAsyncResult, TResult>  @endMethod, TArg1  @arg1, TArg2  @arg2, TArg3  @arg3, System.Object  @state)
        {

            var ___genericsType = new Type[] {typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TResult)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @arg1, @arg2, @arg3, @state};
            var ___result = RFromAsync_GTArg1_GTArg2_GTArg3_GTResult_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> FromAsync<TArg1, TArg2, TArg3, TResult>(System.Func<TArg1, TArg2, TArg3, System.AsyncCallback, System.Object, System.IAsyncResult>  @beginMethod, System.Func<System.IAsyncResult, TResult>  @endMethod, TArg1  @arg1, TArg2  @arg2, TArg3  @arg3, System.Object  @state, System.Threading.Tasks.TaskCreationOptions  @creationOptions)
        {

            var ___genericsType = new Type[] {typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TResult)};
            var ___parameters = new object[]{@beginMethod, @endMethod, @arg1, @arg2, @arg3, @state, @creationOptions};
            var ___result = RFromAsync_GTArg1_GTArg2_GTArg3_GTResult_Func_d_TArg1_TArg2_TArg3_AsyncCallback_Object_IAsyncResult_p__Func_d_IAsyncResult_TResult_p__TArg1_TArg2_TArg3_Object_TaskCreationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static void CheckFromAsyncOptions(System.Threading.Tasks.TaskCreationOptions  @creationOptions, System.Boolean  @hasBeginMethod)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@creationOptions, @hasBeginMethod};
            var ___result = RCheckFromAsyncOptions_TaskCreationOptions_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Threading.Tasks.Task<System.Threading.Tasks.Task[]> CommonCWAllLogic(System.Threading.Tasks.Task[]  @tasksCopy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasksCopy};
            var ___result = RCommonCWAllLogic_TaskArray.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Threading.Tasks.Task[]>)___result;
        }


        public static System.Threading.Tasks.Task<System.Threading.Tasks.Task<T>[]> CommonCWAllLogic<T>(System.Threading.Tasks.Task<T>[]  @tasksCopy)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@tasksCopy};
            var ___result = RCommonCWAllLogic_GT_Task_d_T_p_Array.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Threading.Tasks.Task<T>[]>)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWhenAll(System.Threading.Tasks.Task[]  @tasks, System.Action<System.Threading.Tasks.Task[]>  @continuationAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationAction};
            var ___result = RContinueWhenAll_TaskArray_Action_d_TaskArray_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWhenAll(System.Threading.Tasks.Task[]  @tasks, System.Action<System.Threading.Tasks.Task[]>  @continuationAction, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationAction, @cancellationToken};
            var ___result = RContinueWhenAll_TaskArray_Action_d_TaskArray_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWhenAll(System.Threading.Tasks.Task[]  @tasks, System.Action<System.Threading.Tasks.Task[]>  @continuationAction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationAction, @continuationOptions};
            var ___result = RContinueWhenAll_TaskArray_Action_d_TaskArray_p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWhenAll(System.Threading.Tasks.Task[]  @tasks, System.Action<System.Threading.Tasks.Task[]>  @continuationAction, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationAction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RContinueWhenAll_TaskArray_Action_d_TaskArray_p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWhenAll<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Action<System.Threading.Tasks.Task<TAntecedentResult>[]>  @continuationAction)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationAction};
            var ___result = RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWhenAll<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Action<System.Threading.Tasks.Task<TAntecedentResult>[]>  @continuationAction, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationAction, @cancellationToken};
            var ___result = RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWhenAll<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Action<System.Threading.Tasks.Task<TAntecedentResult>[]>  @continuationAction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationAction, @continuationOptions};
            var ___result = RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWhenAll<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Action<System.Threading.Tasks.Task<TAntecedentResult>[]>  @continuationAction, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationAction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RContinueWhenAll_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p_Array_p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAll<TResult>(System.Threading.Tasks.Task[]  @tasks, System.Func<System.Threading.Tasks.Task[], TResult>  @continuationFunction)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction};
            var ___result = RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAll<TResult>(System.Threading.Tasks.Task[]  @tasks, System.Func<System.Threading.Tasks.Task[], TResult>  @continuationFunction, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @cancellationToken};
            var ___result = RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAll<TResult>(System.Threading.Tasks.Task[]  @tasks, System.Func<System.Threading.Tasks.Task[], TResult>  @continuationFunction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @continuationOptions};
            var ___result = RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAll<TResult>(System.Threading.Tasks.Task[]  @tasks, System.Func<System.Threading.Tasks.Task[], TResult>  @continuationFunction, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RContinueWhenAll_GTResult_TaskArray_Func_d_TaskArray_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>[], TResult>  @continuationFunction)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult), typeof(TResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction};
            var ___result = RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>[], TResult>  @continuationFunction, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult), typeof(TResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @cancellationToken};
            var ___result = RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>[], TResult>  @continuationFunction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult), typeof(TResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @continuationOptions};
            var ___result = RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>[], TResult>  @continuationFunction, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult), typeof(TResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RContinueWhenAll_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p_Array_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public static System.Threading.Tasks.Task<System.Threading.Tasks.Task> CommonCWAnyLogic(System.Collections.Generic.IList<System.Threading.Tasks.Task>  @tasks)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks};
            var ___result = RCommonCWAnyLogic_IList_d_Task_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Threading.Tasks.Task>)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWhenAny(System.Threading.Tasks.Task[]  @tasks, System.Action<System.Threading.Tasks.Task>  @continuationAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationAction};
            var ___result = RContinueWhenAny_TaskArray_Action_d_Task_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWhenAny(System.Threading.Tasks.Task[]  @tasks, System.Action<System.Threading.Tasks.Task>  @continuationAction, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationAction, @cancellationToken};
            var ___result = RContinueWhenAny_TaskArray_Action_d_Task_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWhenAny(System.Threading.Tasks.Task[]  @tasks, System.Action<System.Threading.Tasks.Task>  @continuationAction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationAction, @continuationOptions};
            var ___result = RContinueWhenAny_TaskArray_Action_d_Task_p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWhenAny(System.Threading.Tasks.Task[]  @tasks, System.Action<System.Threading.Tasks.Task>  @continuationAction, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks, @continuationAction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RContinueWhenAny_TaskArray_Action_d_Task_p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAny<TResult>(System.Threading.Tasks.Task[]  @tasks, System.Func<System.Threading.Tasks.Task, TResult>  @continuationFunction)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction};
            var ___result = RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAny<TResult>(System.Threading.Tasks.Task[]  @tasks, System.Func<System.Threading.Tasks.Task, TResult>  @continuationFunction, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @cancellationToken};
            var ___result = RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAny<TResult>(System.Threading.Tasks.Task[]  @tasks, System.Func<System.Threading.Tasks.Task, TResult>  @continuationFunction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @continuationOptions};
            var ___result = RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAny<TResult>(System.Threading.Tasks.Task[]  @tasks, System.Func<System.Threading.Tasks.Task, TResult>  @continuationFunction, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RContinueWhenAny_GTResult_TaskArray_Func_d_Task_TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>, TResult>  @continuationFunction)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult), typeof(TResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction};
            var ___result = RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>, TResult>  @continuationFunction, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult), typeof(TResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @cancellationToken};
            var ___result = RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>, TResult>  @continuationFunction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult), typeof(TResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @continuationOptions};
            var ___result = RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>, TResult>  @continuationFunction, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult), typeof(TResult)};
            var ___parameters = new object[]{@tasks, @continuationFunction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RContinueWhenAny_GTAntecedentResult_GTResult_Task_d_TAntecedentResult_p_Array_Func_d_Task_d_TAntecedentResult_p__TResult_p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWhenAny<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Action<System.Threading.Tasks.Task<TAntecedentResult>>  @continuationAction)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationAction};
            var ___result = RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWhenAny<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Action<System.Threading.Tasks.Task<TAntecedentResult>>  @continuationAction, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationAction, @cancellationToken};
            var ___result = RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWhenAny<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Action<System.Threading.Tasks.Task<TAntecedentResult>>  @continuationAction, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationAction, @continuationOptions};
            var ___result = RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ContinueWhenAny<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[]  @tasks, System.Action<System.Threading.Tasks.Task<TAntecedentResult>>  @continuationAction, System.Threading.CancellationToken  @cancellationToken, System.Threading.Tasks.TaskContinuationOptions  @continuationOptions, System.Threading.Tasks.TaskScheduler  @scheduler)
        {

            var ___genericsType = new Type[] {typeof(TAntecedentResult)};
            var ___parameters = new object[]{@tasks, @continuationAction, @cancellationToken, @continuationOptions, @scheduler};
            var ___result = RContinueWhenAny_GTAntecedentResult_Task_d_TAntecedentResult_p_Array_Action_d_Task_d_TAntecedentResult_p__p__CancellationToken_TaskContinuationOptions_TaskScheduler.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.Threading.Tasks.Task[] CheckMultiContinuationTasksAndCopy(System.Threading.Tasks.Task[]  @tasks)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tasks};
            var ___result = RCheckMultiContinuationTasksAndCopy_TaskArray.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task[])___result;
        }


        public static System.Threading.Tasks.Task<TResult>[] CheckMultiContinuationTasksAndCopy<TResult>(System.Threading.Tasks.Task<TResult>[]  @tasks)
        {

            var ___genericsType = new Type[] {typeof(TResult)};
            var ___parameters = new object[]{@tasks};
            var ___result = RCheckMultiContinuationTasksAndCopy_GTResult_Task_d_TResult_p_Array.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>[])___result;
        }


        public static void CheckMultiTaskContinuationOptions(System.Threading.Tasks.TaskContinuationOptions  @continuationOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuationOptions};
            var ___result = RCheckMultiTaskContinuationOptions_TaskContinuationOptions.Invoke(___genericsType, ___parameters);

            
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
