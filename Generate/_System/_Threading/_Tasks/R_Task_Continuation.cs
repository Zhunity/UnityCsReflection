
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading.RTasks
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Threading.Tasks.TaskContinuation
	/// </summary>
    public partial class RTaskContinuation : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Threading.Tasks.TaskContinuation");
            }
        }

        public RTaskContinuation() : base("System.Threading.Tasks.TaskContinuation")
        {
        }

        public RTaskContinuation(System.Object instance) : base("System.Threading.Tasks.TaskContinuation")
		{
            SetInstance(instance);
		}

        public RTaskContinuation(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTaskContinuation(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// Void Run(System.Threading.Tasks.Task, Boolean)
		/// </summary>
		protected RMethod r_MRun_Task_Boolean;
		public virtual RMethod RMRun_Task_Boolean
		{
			get
			{
				if(r_MRun_Task_Boolean == null)
				{
					r_MRun_Task_Boolean = new(this, "Run", 0, typeof(System.Threading.Tasks.Task), typeof(System.Boolean));
				}
				return r_MRun_Task_Boolean;
			}
		}

		/// <summary>
		/// Void InlineIfPossibleOrElseQueue(System.Threading.Tasks.Task, Boolean)
		/// </summary>
		protected static RMethod r_MInlineIfPossibleOrElseQueue_Task_Boolean;
		public static RMethod RMInlineIfPossibleOrElseQueue_Task_Boolean
		{
			get
			{
				if(r_MInlineIfPossibleOrElseQueue_Task_Boolean == null)
				{
					r_MInlineIfPossibleOrElseQueue_Task_Boolean = new(Type, "InlineIfPossibleOrElseQueue", 0, typeof(System.Threading.Tasks.Task), typeof(System.Boolean));
				}
				return r_MInlineIfPossibleOrElseQueue_Task_Boolean;
			}
		}

		/// <summary>
		/// System.Delegate[] GetDelegateContinuationsForDebugger()
		/// </summary>
		protected RMethod r_MGetDelegateContinuationsForDebugger;
		public virtual RMethod RMGetDelegateContinuationsForDebugger
		{
			get
			{
				if(r_MGetDelegateContinuationsForDebugger == null)
				{
					r_MGetDelegateContinuationsForDebugger = new(this, "GetDelegateContinuationsForDebugger", 0);
				}
				return r_MGetDelegateContinuationsForDebugger;
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


        public virtual void Run(System.Threading.Tasks.Task @completedTask, System.Boolean @bCanInlineContinuationTask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@completedTask, @bCanInlineContinuationTask};
            var ___result = RMRun_Task_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void InlineIfPossibleOrElseQueue(System.Threading.Tasks.Task @task, System.Boolean @needsProtection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task, @needsProtection};
            var ___result = RMInlineIfPossibleOrElseQueue_Task_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Delegate[] GetDelegateContinuationsForDebugger()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDelegateContinuationsForDebugger.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Delegate[]>(___result);
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
