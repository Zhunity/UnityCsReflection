using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks
{
	/// <summary>
	/// System.Threading.Tasks.TaskContinuation
	/// </summary>
    public partial class RTaskContinuation : RMember //
    {

		/// <summary>
		/// Void Run(System.Threading.Tasks.Task, Boolean)
		/// </summary>
		protected RMethod r_Run_Task_Boolean;
		public virtual RMethod RRun_Task_Boolean
		{
			get
			{
				if(r_Run_Task_Boolean == null)
				{
					r_Run_Task_Boolean = new(this, "Run", 0, typeof(System.Threading.Tasks.Task), typeof(System.Boolean));
					r_Run_Task_Boolean.SetBelong(this.instance);
				}
				return r_Run_Task_Boolean;
			}
		}

		/// <summary>
		/// Void InlineIfPossibleOrElseQueue(System.Threading.Tasks.Task, Boolean)
		/// </summary>
		protected static RMethod r_InlineIfPossibleOrElseQueue_Task_Boolean;
		public static RMethod RInlineIfPossibleOrElseQueue_Task_Boolean
		{
			get
			{
				if(r_InlineIfPossibleOrElseQueue_Task_Boolean == null)
				{
					r_InlineIfPossibleOrElseQueue_Task_Boolean = new( ReflectionUtils.GetType("System.Threading.Tasks.TaskContinuation"), "InlineIfPossibleOrElseQueue", 0, typeof(System.Threading.Tasks.Task), typeof(System.Boolean));
					r_InlineIfPossibleOrElseQueue_Task_Boolean.SetBelong(null);
				}
				return r_InlineIfPossibleOrElseQueue_Task_Boolean;
			}
		}

		/// <summary>
		/// System.Delegate[] GetDelegateContinuationsForDebugger()
		/// </summary>
		protected RMethod r_GetDelegateContinuationsForDebugger;
		public virtual RMethod RGetDelegateContinuationsForDebugger
		{
			get
			{
				if(r_GetDelegateContinuationsForDebugger == null)
				{
					r_GetDelegateContinuationsForDebugger = new(this, "GetDelegateContinuationsForDebugger", 0);
					r_GetDelegateContinuationsForDebugger.SetBelong(this.instance);
				}
				return r_GetDelegateContinuationsForDebugger;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
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

        public virtual void Run(System.Threading.Tasks.Task  @completedTask, System.Boolean  @bCanInlineContinuationTask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@completedTask, @bCanInlineContinuationTask};
            var ___result = RRun_Task_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void InlineIfPossibleOrElseQueue(System.Threading.Tasks.Task  @task, System.Boolean  @needsProtection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task, @needsProtection};
            var ___result = RInlineIfPossibleOrElseQueue_Task_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Delegate[] GetDelegateContinuationsForDebugger()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDelegateContinuationsForDebugger.Invoke(___genericsType, ___parameters);

            return (System.Delegate[])___result;
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
