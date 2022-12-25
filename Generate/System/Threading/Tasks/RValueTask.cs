using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks
{
	/// <summary>
	/// System.Threading.Tasks.ValueTask
	/// </summary>
    public partial class RValueTask : RMember //
    {

		/// <summary>
		/// System.Threading.Tasks.Task s_canceledTask
		/// </summary>
		protected static RSystem.RThreading.RTasks.RTask r_s_canceledTask;
		public static RSystem.RThreading.RTasks.RTask Rs_canceledTask
		{
			get
			{
				if(r_s_canceledTask == null)
				{
					r_s_canceledTask = new(typeof(System.Threading.Tasks.ValueTask), "s_canceledTask");
					r_s_canceledTask.SetBelong(null);
				}
				return r_s_canceledTask;
			}
		}

		/// <summary>
		/// System.Object _obj
		/// </summary>
		protected RSystem.RObject r__obj;
		public virtual RSystem.RObject R_obj
		{
			get
			{
				if(r__obj == null)
				{
					r__obj = new(this, "_obj");
					r__obj.SetBelong(this.instance);
				}
				return r__obj;
			}
		}

		/// <summary>
		/// System.Int16 _token
		/// </summary>
		protected RField r__token;
		public virtual RField R_token
		{
			get
			{
				if(r__token == null)
				{
					r__token = new(this, "_token");
					r__token.SetBelong(this.instance);
				}
				return r__token;
			}
		}

		/// <summary>
		/// System.Boolean _continueOnCapturedContext
		/// </summary>
		protected RField r__continueOnCapturedContext;
		public virtual RField R_continueOnCapturedContext
		{
			get
			{
				if(r__continueOnCapturedContext == null)
				{
					r__continueOnCapturedContext = new(this, "_continueOnCapturedContext");
					r__continueOnCapturedContext.SetBelong(this.instance);
				}
				return r__continueOnCapturedContext;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task CompletedTask
		/// </summary>
		protected static RSystem.RThreading.RTasks.RTask r_CompletedTask;
		public static RSystem.RThreading.RTasks.RTask RCompletedTask
		{
			get
			{
				if(r_CompletedTask == null)
				{
					r_CompletedTask = new(typeof(System.Threading.Tasks.ValueTask), "CompletedTask", -1);
					r_CompletedTask.SetBelong(null);
				}
				return r_CompletedTask;
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
		/// Boolean IsCompletedSuccessfully
		/// </summary>
		protected RProperty r_IsCompletedSuccessfully;
		public virtual RProperty RIsCompletedSuccessfully
		{
			get
			{
				if(r_IsCompletedSuccessfully == null)
				{
					r_IsCompletedSuccessfully = new(this, "IsCompletedSuccessfully", -1);
					r_IsCompletedSuccessfully.SetBelong(this.instance);
				}
				return r_IsCompletedSuccessfully;
			}
		}

		/// <summary>
		/// Boolean IsFaulted
		/// </summary>
		protected RProperty r_IsFaulted;
		public virtual RProperty RIsFaulted
		{
			get
			{
				if(r_IsFaulted == null)
				{
					r_IsFaulted = new(this, "IsFaulted", -1);
					r_IsFaulted.SetBelong(this.instance);
				}
				return r_IsFaulted;
			}
		}

		/// <summary>
		/// Boolean IsCanceled
		/// </summary>
		protected RProperty r_IsCanceled;
		public virtual RProperty RIsCanceled
		{
			get
			{
				if(r_IsCanceled == null)
				{
					r_IsCanceled = new(this, "IsCanceled", -1);
					r_IsCanceled.SetBelong(this.instance);
				}
				return r_IsCanceled;
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
		/// Boolean Equals(System.Threading.Tasks.ValueTask)
		/// </summary>
		protected RMethod r_REquals_ValueTask;
		public virtual RMethod REquals_ValueTask
		{
			get
			{
				if(r_REquals_ValueTask == null)
				{
					r_REquals_ValueTask = new(this, "Equals", 0, typeof(System.Threading.Tasks.ValueTask));
					r_REquals_ValueTask.SetBelong(this.instance);
				}
				return r_REquals_ValueTask;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Threading.Tasks.ValueTask, System.Threading.Tasks.ValueTask)
		/// </summary>
		protected static RMethod r_Rop_Equality_ValueTask_ValueTask;
		public static RMethod Rop_Equality_ValueTask_ValueTask
		{
			get
			{
				if(r_Rop_Equality_ValueTask_ValueTask == null)
				{
					r_Rop_Equality_ValueTask_ValueTask = new(typeof(System.Threading.Tasks.ValueTask), "op_Equality", 0, typeof(System.Threading.Tasks.ValueTask), typeof(System.Threading.Tasks.ValueTask));
					r_Rop_Equality_ValueTask_ValueTask.SetBelong(null);
				}
				return r_Rop_Equality_ValueTask_ValueTask;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Threading.Tasks.ValueTask, System.Threading.Tasks.ValueTask)
		/// </summary>
		protected static RMethod r_Rop_Inequality_ValueTask_ValueTask;
		public static RMethod Rop_Inequality_ValueTask_ValueTask
		{
			get
			{
				if(r_Rop_Inequality_ValueTask_ValueTask == null)
				{
					r_Rop_Inequality_ValueTask_ValueTask = new(typeof(System.Threading.Tasks.ValueTask), "op_Inequality", 0, typeof(System.Threading.Tasks.ValueTask), typeof(System.Threading.Tasks.ValueTask));
					r_Rop_Inequality_ValueTask_ValueTask.SetBelong(null);
				}
				return r_Rop_Inequality_ValueTask_ValueTask;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task AsTask()
		/// </summary>
		protected RMethod r_RAsTask;
		public virtual RMethod RAsTask
		{
			get
			{
				if(r_RAsTask == null)
				{
					r_RAsTask = new(this, "AsTask", 0);
					r_RAsTask.SetBelong(this.instance);
				}
				return r_RAsTask;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask Preserve()
		/// </summary>
		protected RMethod r_RPreserve;
		public virtual RMethod RPreserve
		{
			get
			{
				if(r_RPreserve == null)
				{
					r_RPreserve = new(this, "Preserve", 0);
					r_RPreserve.SetBelong(this.instance);
				}
				return r_RPreserve;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task GetTaskForValueTaskSource(System.Threading.Tasks.Sources.IValueTaskSource)
		/// </summary>
		protected RMethod r_RGetTaskForValueTaskSource_IValueTaskSource;
		public virtual RMethod RGetTaskForValueTaskSource_IValueTaskSource
		{
			get
			{
				if(r_RGetTaskForValueTaskSource_IValueTaskSource == null)
				{
					r_RGetTaskForValueTaskSource_IValueTaskSource = new(this, "GetTaskForValueTaskSource", 0, typeof(System.Threading.Tasks.Sources.IValueTaskSource));
					r_RGetTaskForValueTaskSource_IValueTaskSource.SetBelong(this.instance);
				}
				return r_RGetTaskForValueTaskSource_IValueTaskSource;
			}
		}

		/// <summary>
		/// Void ThrowIfCompletedUnsuccessfully()
		/// </summary>
		protected RMethod r_RThrowIfCompletedUnsuccessfully;
		public virtual RMethod RThrowIfCompletedUnsuccessfully
		{
			get
			{
				if(r_RThrowIfCompletedUnsuccessfully == null)
				{
					r_RThrowIfCompletedUnsuccessfully = new(this, "ThrowIfCompletedUnsuccessfully", 0);
					r_RThrowIfCompletedUnsuccessfully.SetBelong(this.instance);
				}
				return r_RThrowIfCompletedUnsuccessfully;
			}
		}

		/// <summary>
		/// System.Runtime.CompilerServices.ValueTaskAwaiter GetAwaiter()
		/// </summary>
		protected RMethod r_RGetAwaiter;
		public virtual RMethod RGetAwaiter
		{
			get
			{
				if(r_RGetAwaiter == null)
				{
					r_RGetAwaiter = new(this, "GetAwaiter", 0);
					r_RGetAwaiter.SetBelong(this.instance);
				}
				return r_RGetAwaiter;
			}
		}

		/// <summary>
		/// System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable ConfigureAwait(Boolean)
		/// </summary>
		protected RMethod r_RConfigureAwait_Boolean;
		public virtual RMethod RConfigureAwait_Boolean
		{
			get
			{
				if(r_RConfigureAwait_Boolean == null)
				{
					r_RConfigureAwait_Boolean = new(this, "ConfigureAwait", 0, typeof(System.Boolean));
					r_RConfigureAwait_Boolean.SetBelong(this.instance);
				}
				return r_RConfigureAwait_Boolean;
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


        public RValueTask() : base("System.Threading.Tasks.ValueTask")
        {
        }

        public RValueTask(System.Object instance) : base("System.Threading.Tasks.ValueTask")
		{
            SetInstance(instance);
		}

        public RValueTask(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RValueTask(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Threading.Tasks.ValueTask  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_ValueTask.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.Threading.Tasks.ValueTask  @left, System.Threading.Tasks.ValueTask  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_ValueTask_ValueTask.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Threading.Tasks.ValueTask  @left, System.Threading.Tasks.ValueTask  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_ValueTask_ValueTask.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Threading.Tasks.Task AsTask()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAsTask.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.ValueTask Preserve()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPreserve.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask)___result;
        }


        public virtual System.Threading.Tasks.Task GetTaskForValueTaskSource(System.Threading.Tasks.Sources.IValueTaskSource  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RGetTaskForValueTaskSource_IValueTaskSource.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual void ThrowIfCompletedUnsuccessfully()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RThrowIfCompletedUnsuccessfully.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Runtime.CompilerServices.ValueTaskAwaiter GetAwaiter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAwaiter.Invoke(___genericsType, ___parameters);

            return (System.Runtime.CompilerServices.ValueTaskAwaiter)___result;
        }


        public virtual System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable ConfigureAwait(System.Boolean  @continueOnCapturedContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continueOnCapturedContext};
            var ___result = RConfigureAwait_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable)___result;
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
