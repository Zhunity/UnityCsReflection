using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RCompilerServices
{
	/// <summary>
	/// System.Runtime.CompilerServices.TaskAwaiter
	/// </summary>
    public partial class RTaskAwaiter : RMember //
    {

		/// <summary>
		/// System.Threading.Tasks.Task m_task
		/// </summary>
		protected RSystem.RThreading.RTasks.RTask r_m_task;
		public virtual RSystem.RThreading.RTasks.RTask Rm_task
		{
			get
			{
				if(r_m_task == null)
				{
					r_m_task = new(this, "m_task");
					r_m_task.SetBelong(this.instance);
				}
				return r_m_task;
			}
		}

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
		/// Void OnCompleted(System.Action)
		/// </summary>
		protected RMethod r_ROnCompleted_Action;
		public virtual RMethod ROnCompleted_Action
		{
			get
			{
				if(r_ROnCompleted_Action == null)
				{
					r_ROnCompleted_Action = new(this, "OnCompleted", 0, typeof(System.Action));
					r_ROnCompleted_Action.SetBelong(this.instance);
				}
				return r_ROnCompleted_Action;
			}
		}

		/// <summary>
		/// Void UnsafeOnCompleted(System.Action)
		/// </summary>
		protected RMethod r_RUnsafeOnCompleted_Action;
		public virtual RMethod RUnsafeOnCompleted_Action
		{
			get
			{
				if(r_RUnsafeOnCompleted_Action == null)
				{
					r_RUnsafeOnCompleted_Action = new(this, "UnsafeOnCompleted", 0, typeof(System.Action));
					r_RUnsafeOnCompleted_Action.SetBelong(this.instance);
				}
				return r_RUnsafeOnCompleted_Action;
			}
		}

		/// <summary>
		/// Void GetResult()
		/// </summary>
		protected RMethod r_RGetResult;
		public virtual RMethod RGetResult
		{
			get
			{
				if(r_RGetResult == null)
				{
					r_RGetResult = new(this, "GetResult", 0);
					r_RGetResult.SetBelong(this.instance);
				}
				return r_RGetResult;
			}
		}

		/// <summary>
		/// Void ValidateEnd(System.Threading.Tasks.Task)
		/// </summary>
		protected static RMethod r_RValidateEnd_Task;
		public static RMethod RValidateEnd_Task
		{
			get
			{
				if(r_RValidateEnd_Task == null)
				{
					r_RValidateEnd_Task = new(typeof(System.Runtime.CompilerServices.TaskAwaiter), "ValidateEnd", 0, typeof(System.Threading.Tasks.Task));
					r_RValidateEnd_Task.SetBelong(null);
				}
				return r_RValidateEnd_Task;
			}
		}

		/// <summary>
		/// Void HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
		/// </summary>
		protected static RMethod r_RHandleNonSuccessAndDebuggerNotification_Task;
		public static RMethod RHandleNonSuccessAndDebuggerNotification_Task
		{
			get
			{
				if(r_RHandleNonSuccessAndDebuggerNotification_Task == null)
				{
					r_RHandleNonSuccessAndDebuggerNotification_Task = new(typeof(System.Runtime.CompilerServices.TaskAwaiter), "HandleNonSuccessAndDebuggerNotification", 0, typeof(System.Threading.Tasks.Task));
					r_RHandleNonSuccessAndDebuggerNotification_Task.SetBelong(null);
				}
				return r_RHandleNonSuccessAndDebuggerNotification_Task;
			}
		}

		/// <summary>
		/// Void ThrowForNonSuccess(System.Threading.Tasks.Task)
		/// </summary>
		protected static RMethod r_RThrowForNonSuccess_Task;
		public static RMethod RThrowForNonSuccess_Task
		{
			get
			{
				if(r_RThrowForNonSuccess_Task == null)
				{
					r_RThrowForNonSuccess_Task = new(typeof(System.Runtime.CompilerServices.TaskAwaiter), "ThrowForNonSuccess", 0, typeof(System.Threading.Tasks.Task));
					r_RThrowForNonSuccess_Task.SetBelong(null);
				}
				return r_RThrowForNonSuccess_Task;
			}
		}

		/// <summary>
		/// Void OnCompletedInternal(System.Threading.Tasks.Task, System.Action, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_ROnCompletedInternal_Task_Action_Boolean_Boolean;
		public static RMethod ROnCompletedInternal_Task_Action_Boolean_Boolean
		{
			get
			{
				if(r_ROnCompletedInternal_Task_Action_Boolean_Boolean == null)
				{
					r_ROnCompletedInternal_Task_Action_Boolean_Boolean = new(typeof(System.Runtime.CompilerServices.TaskAwaiter), "OnCompletedInternal", 0, typeof(System.Threading.Tasks.Task), typeof(System.Action), typeof(System.Boolean), typeof(System.Boolean));
					r_ROnCompletedInternal_Task_Action_Boolean_Boolean.SetBelong(null);
				}
				return r_ROnCompletedInternal_Task_Action_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Action OutputWaitEtwEvents(System.Threading.Tasks.Task, System.Action)
		/// </summary>
		protected static RMethod r_ROutputWaitEtwEvents_Task_Action;
		public static RMethod ROutputWaitEtwEvents_Task_Action
		{
			get
			{
				if(r_ROutputWaitEtwEvents_Task_Action == null)
				{
					r_ROutputWaitEtwEvents_Task_Action = new(typeof(System.Runtime.CompilerServices.TaskAwaiter), "OutputWaitEtwEvents", 0, typeof(System.Threading.Tasks.Task), typeof(System.Action));
					r_ROutputWaitEtwEvents_Task_Action.SetBelong(null);
				}
				return r_ROutputWaitEtwEvents_Task_Action;
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


        public RTaskAwaiter() : base("System.Runtime.CompilerServices.TaskAwaiter")
        {
        }

        public RTaskAwaiter(System.Object instance) : base("System.Runtime.CompilerServices.TaskAwaiter")
		{
            SetInstance(instance);
		}

        public RTaskAwaiter(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTaskAwaiter(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnCompleted(System.Action  @continuation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuation};
            var ___result = ROnCompleted_Action.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnsafeOnCompleted(System.Action  @continuation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuation};
            var ___result = RUnsafeOnCompleted_Action.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetResult()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetResult.Invoke(___genericsType, ___parameters);

            
        }


        public static void ValidateEnd(System.Threading.Tasks.Task  @task)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task};
            var ___result = RValidateEnd_Task.Invoke(___genericsType, ___parameters);

            
        }


        public static void HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task  @task)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task};
            var ___result = RHandleNonSuccessAndDebuggerNotification_Task.Invoke(___genericsType, ___parameters);

            
        }


        public static void ThrowForNonSuccess(System.Threading.Tasks.Task  @task)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task};
            var ___result = RThrowForNonSuccess_Task.Invoke(___genericsType, ___parameters);

            
        }


        public static void OnCompletedInternal(System.Threading.Tasks.Task  @task, System.Action  @continuation, System.Boolean  @continueOnCapturedContext, System.Boolean  @flowExecutionContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task, @continuation, @continueOnCapturedContext, @flowExecutionContext};
            var ___result = ROnCompletedInternal_Task_Action_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Action OutputWaitEtwEvents(System.Threading.Tasks.Task  @task, System.Action  @continuation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task, @continuation};
            var ___result = ROutputWaitEtwEvents_Task_Action.Invoke(___genericsType, ___parameters);

            return (System.Action)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
