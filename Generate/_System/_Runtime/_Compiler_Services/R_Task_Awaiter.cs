
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RCompilerServices
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Runtime.CompilerServices.TaskAwaiter
	/// </summary>
    public partial class RTaskAwaiter : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Runtime.CompilerServices.TaskAwaiter);
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


		/// <summary>
		/// System.Threading.Tasks.Task m_task
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask r_Fm_task;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask RFm_task
		{
			get
			{
				if(r_Fm_task == null)
				{
					r_Fm_task = new(this, "m_task");
				}
				return r_Fm_task;
			}
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
		/// Void OnCompleted(System.Action)
		/// </summary>
		protected RMethod r_MOnCompleted_Action;
		public virtual RMethod RMOnCompleted_Action
		{
			get
			{
				if(r_MOnCompleted_Action == null)
				{
					r_MOnCompleted_Action = new(this, "OnCompleted", 0, typeof(System.Action));
				}
				return r_MOnCompleted_Action;
			}
		}

		/// <summary>
		/// Void UnsafeOnCompleted(System.Action)
		/// </summary>
		protected RMethod r_MUnsafeOnCompleted_Action;
		public virtual RMethod RMUnsafeOnCompleted_Action
		{
			get
			{
				if(r_MUnsafeOnCompleted_Action == null)
				{
					r_MUnsafeOnCompleted_Action = new(this, "UnsafeOnCompleted", 0, typeof(System.Action));
				}
				return r_MUnsafeOnCompleted_Action;
			}
		}

		/// <summary>
		/// Void GetResult()
		/// </summary>
		protected RMethod r_MGetResult;
		public virtual RMethod RMGetResult
		{
			get
			{
				if(r_MGetResult == null)
				{
					r_MGetResult = new(this, "GetResult", 0);
				}
				return r_MGetResult;
			}
		}

		/// <summary>
		/// Void ValidateEnd(System.Threading.Tasks.Task)
		/// </summary>
		protected static RMethod r_MValidateEnd_Task;
		public static RMethod RMValidateEnd_Task
		{
			get
			{
				if(r_MValidateEnd_Task == null)
				{
					r_MValidateEnd_Task = new(Type, "ValidateEnd", 0, typeof(System.Threading.Tasks.Task));
				}
				return r_MValidateEnd_Task;
			}
		}

		/// <summary>
		/// Void HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
		/// </summary>
		protected static RMethod r_MHandleNonSuccessAndDebuggerNotification_Task;
		public static RMethod RMHandleNonSuccessAndDebuggerNotification_Task
		{
			get
			{
				if(r_MHandleNonSuccessAndDebuggerNotification_Task == null)
				{
					r_MHandleNonSuccessAndDebuggerNotification_Task = new(Type, "HandleNonSuccessAndDebuggerNotification", 0, typeof(System.Threading.Tasks.Task));
				}
				return r_MHandleNonSuccessAndDebuggerNotification_Task;
			}
		}

		/// <summary>
		/// Void ThrowForNonSuccess(System.Threading.Tasks.Task)
		/// </summary>
		protected static RMethod r_MThrowForNonSuccess_Task;
		public static RMethod RMThrowForNonSuccess_Task
		{
			get
			{
				if(r_MThrowForNonSuccess_Task == null)
				{
					r_MThrowForNonSuccess_Task = new(Type, "ThrowForNonSuccess", 0, typeof(System.Threading.Tasks.Task));
				}
				return r_MThrowForNonSuccess_Task;
			}
		}

		/// <summary>
		/// Void OnCompletedInternal(System.Threading.Tasks.Task, System.Action, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_MOnCompletedInternal_Task_Action_Boolean_Boolean;
		public static RMethod RMOnCompletedInternal_Task_Action_Boolean_Boolean
		{
			get
			{
				if(r_MOnCompletedInternal_Task_Action_Boolean_Boolean == null)
				{
					r_MOnCompletedInternal_Task_Action_Boolean_Boolean = new(Type, "OnCompletedInternal", 0, typeof(System.Threading.Tasks.Task), typeof(System.Action), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MOnCompletedInternal_Task_Action_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Action OutputWaitEtwEvents(System.Threading.Tasks.Task, System.Action)
		/// </summary>
		protected static RMethod r_MOutputWaitEtwEvents_Task_Action;
		public static RMethod RMOutputWaitEtwEvents_Task_Action
		{
			get
			{
				if(r_MOutputWaitEtwEvents_Task_Action == null)
				{
					r_MOutputWaitEtwEvents_Task_Action = new(Type, "OutputWaitEtwEvents", 0, typeof(System.Threading.Tasks.Task), typeof(System.Action));
				}
				return r_MOutputWaitEtwEvents_Task_Action;
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


        public virtual void OnCompleted(System.Action @continuation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuation};
            var ___result = RMOnCompleted_Action.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnsafeOnCompleted(System.Action @continuation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuation};
            var ___result = RMUnsafeOnCompleted_Action.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetResult()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetResult.Invoke(___genericsType, ___parameters);

            
        }


        public static void ValidateEnd(System.Threading.Tasks.Task @task)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task};
            var ___result = RMValidateEnd_Task.Invoke(___genericsType, ___parameters);

            
        }


        public static void HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task @task)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task};
            var ___result = RMHandleNonSuccessAndDebuggerNotification_Task.Invoke(___genericsType, ___parameters);

            
        }


        public static void ThrowForNonSuccess(System.Threading.Tasks.Task @task)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task};
            var ___result = RMThrowForNonSuccess_Task.Invoke(___genericsType, ___parameters);

            
        }


        public static void OnCompletedInternal(System.Threading.Tasks.Task @task, System.Action @continuation, System.Boolean @continueOnCapturedContext, System.Boolean @flowExecutionContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task, @continuation, @continueOnCapturedContext, @flowExecutionContext};
            var ___result = RMOnCompletedInternal_Task_Action_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Action OutputWaitEtwEvents(System.Threading.Tasks.Task @task, System.Action @continuation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task, @continuation};
            var ___result = RMOutputWaitEtwEvents_Task_Action.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Action>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
