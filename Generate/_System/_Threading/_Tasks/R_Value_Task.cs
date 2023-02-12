
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
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTask r_Fs_canceledTask;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTask RFs_canceledTask
		{
			get
			{
				if(r_Fs_canceledTask == null)
				{
					r_Fs_canceledTask = new(typeof(System.Threading.Tasks.ValueTask), "s_canceledTask");
					r_Fs_canceledTask.SetBelong(null);
				}
				return r_Fs_canceledTask;
			}
		}

		/// <summary>
		/// System.Object _obj
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RObject r_F_obj;
		public virtual SMFrame.Editor.Refleaction.RSystem.RObject RF_obj
		{
			get
			{
				if(r_F_obj == null)
				{
					r_F_obj = new(this, "_obj");
					r_F_obj.SetBelong(this.instance);
				}
				return r_F_obj;
			}
		}

		/// <summary>
		/// System.Int16 _token
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt16 r_F_token;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt16 RF_token
		{
			get
			{
				if(r_F_token == null)
				{
					r_F_token = new(this, "_token");
					r_F_token.SetBelong(this.instance);
				}
				return r_F_token;
			}
		}

		/// <summary>
		/// System.Boolean _continueOnCapturedContext
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_F_continueOnCapturedContext;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RF_continueOnCapturedContext
		{
			get
			{
				if(r_F_continueOnCapturedContext == null)
				{
					r_F_continueOnCapturedContext = new(this, "_continueOnCapturedContext");
					r_F_continueOnCapturedContext.SetBelong(this.instance);
				}
				return r_F_continueOnCapturedContext;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task CompletedTask
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTask r_PCompletedTask;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTask RPCompletedTask
		{
			get
			{
				if(r_PCompletedTask == null)
				{
					r_PCompletedTask = new(typeof(System.Threading.Tasks.ValueTask), "CompletedTask", -1);
					r_PCompletedTask.SetBelong(null);
				}
				return r_PCompletedTask;
			}
		}

		/// <summary>
		/// Boolean IsCompleted
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsCompleted;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsCompleted
		{
			get
			{
				if(r_PIsCompleted == null)
				{
					r_PIsCompleted = new(this, "IsCompleted", -1);
					r_PIsCompleted.SetBelong(this.instance);
				}
				return r_PIsCompleted;
			}
		}

		/// <summary>
		/// Boolean IsCompletedSuccessfully
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsCompletedSuccessfully;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsCompletedSuccessfully
		{
			get
			{
				if(r_PIsCompletedSuccessfully == null)
				{
					r_PIsCompletedSuccessfully = new(this, "IsCompletedSuccessfully", -1);
					r_PIsCompletedSuccessfully.SetBelong(this.instance);
				}
				return r_PIsCompletedSuccessfully;
			}
		}

		/// <summary>
		/// Boolean IsFaulted
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsFaulted;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsFaulted
		{
			get
			{
				if(r_PIsFaulted == null)
				{
					r_PIsFaulted = new(this, "IsFaulted", -1);
					r_PIsFaulted.SetBelong(this.instance);
				}
				return r_PIsFaulted;
			}
		}

		/// <summary>
		/// Boolean IsCanceled
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsCanceled;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsCanceled
		{
			get
			{
				if(r_PIsCanceled == null)
				{
					r_PIsCanceled = new(this, "IsCanceled", -1);
					r_PIsCanceled.SetBelong(this.instance);
				}
				return r_PIsCanceled;
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
		/// Boolean Equals(System.Threading.Tasks.ValueTask)
		/// </summary>
		protected RMethod r_MEquals_ValueTask;
		public virtual RMethod RMEquals_ValueTask
		{
			get
			{
				if(r_MEquals_ValueTask == null)
				{
					r_MEquals_ValueTask = new(this, "Equals", 0, typeof(System.Threading.Tasks.ValueTask));
					r_MEquals_ValueTask.SetBelong(this.instance);
				}
				return r_MEquals_ValueTask;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Threading.Tasks.ValueTask, System.Threading.Tasks.ValueTask)
		/// </summary>
		protected static RMethod r_Mop_Equality_ValueTask_ValueTask;
		public static RMethod RMop_Equality_ValueTask_ValueTask
		{
			get
			{
				if(r_Mop_Equality_ValueTask_ValueTask == null)
				{
					r_Mop_Equality_ValueTask_ValueTask = new(typeof(System.Threading.Tasks.ValueTask), "op_Equality", 0, typeof(System.Threading.Tasks.ValueTask), typeof(System.Threading.Tasks.ValueTask));
					r_Mop_Equality_ValueTask_ValueTask.SetBelong(null);
				}
				return r_Mop_Equality_ValueTask_ValueTask;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Threading.Tasks.ValueTask, System.Threading.Tasks.ValueTask)
		/// </summary>
		protected static RMethod r_Mop_Inequality_ValueTask_ValueTask;
		public static RMethod RMop_Inequality_ValueTask_ValueTask
		{
			get
			{
				if(r_Mop_Inequality_ValueTask_ValueTask == null)
				{
					r_Mop_Inequality_ValueTask_ValueTask = new(typeof(System.Threading.Tasks.ValueTask), "op_Inequality", 0, typeof(System.Threading.Tasks.ValueTask), typeof(System.Threading.Tasks.ValueTask));
					r_Mop_Inequality_ValueTask_ValueTask.SetBelong(null);
				}
				return r_Mop_Inequality_ValueTask_ValueTask;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task AsTask()
		/// </summary>
		protected RMethod r_MAsTask;
		public virtual RMethod RMAsTask
		{
			get
			{
				if(r_MAsTask == null)
				{
					r_MAsTask = new(this, "AsTask", 0);
					r_MAsTask.SetBelong(this.instance);
				}
				return r_MAsTask;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask Preserve()
		/// </summary>
		protected RMethod r_MPreserve;
		public virtual RMethod RMPreserve
		{
			get
			{
				if(r_MPreserve == null)
				{
					r_MPreserve = new(this, "Preserve", 0);
					r_MPreserve.SetBelong(this.instance);
				}
				return r_MPreserve;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task GetTaskForValueTaskSource(System.Threading.Tasks.Sources.IValueTaskSource)
		/// </summary>
		protected RMethod r_MGetTaskForValueTaskSource_IValueTaskSource;
		public virtual RMethod RMGetTaskForValueTaskSource_IValueTaskSource
		{
			get
			{
				if(r_MGetTaskForValueTaskSource_IValueTaskSource == null)
				{
					r_MGetTaskForValueTaskSource_IValueTaskSource = new(this, "GetTaskForValueTaskSource", 0, typeof(System.Threading.Tasks.Sources.IValueTaskSource));
					r_MGetTaskForValueTaskSource_IValueTaskSource.SetBelong(this.instance);
				}
				return r_MGetTaskForValueTaskSource_IValueTaskSource;
			}
		}

		/// <summary>
		/// Void ThrowIfCompletedUnsuccessfully()
		/// </summary>
		protected RMethod r_MThrowIfCompletedUnsuccessfully;
		public virtual RMethod RMThrowIfCompletedUnsuccessfully
		{
			get
			{
				if(r_MThrowIfCompletedUnsuccessfully == null)
				{
					r_MThrowIfCompletedUnsuccessfully = new(this, "ThrowIfCompletedUnsuccessfully", 0);
					r_MThrowIfCompletedUnsuccessfully.SetBelong(this.instance);
				}
				return r_MThrowIfCompletedUnsuccessfully;
			}
		}

		/// <summary>
		/// System.Runtime.CompilerServices.ValueTaskAwaiter GetAwaiter()
		/// </summary>
		protected RMethod r_MGetAwaiter;
		public virtual RMethod RMGetAwaiter
		{
			get
			{
				if(r_MGetAwaiter == null)
				{
					r_MGetAwaiter = new(this, "GetAwaiter", 0);
					r_MGetAwaiter.SetBelong(this.instance);
				}
				return r_MGetAwaiter;
			}
		}

		/// <summary>
		/// System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable ConfigureAwait(Boolean)
		/// </summary>
		protected RMethod r_MConfigureAwait_Boolean;
		public virtual RMethod RMConfigureAwait_Boolean
		{
			get
			{
				if(r_MConfigureAwait_Boolean == null)
				{
					r_MConfigureAwait_Boolean = new(this, "ConfigureAwait", 0, typeof(System.Boolean));
					r_MConfigureAwait_Boolean.SetBelong(this.instance);
				}
				return r_MConfigureAwait_Boolean;
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
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Threading.Tasks.ValueTask @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_ValueTask.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.Threading.Tasks.ValueTask @left, System.Threading.Tasks.ValueTask @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_ValueTask_ValueTask.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Threading.Tasks.ValueTask @left, System.Threading.Tasks.ValueTask @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_ValueTask_ValueTask.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Threading.Tasks.Task AsTask()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAsTask.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.ValueTask Preserve()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPreserve.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask)___result;
        }


        public virtual System.Threading.Tasks.Task GetTaskForValueTaskSource(System.Threading.Tasks.Sources.IValueTaskSource @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMGetTaskForValueTaskSource_IValueTaskSource.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual void ThrowIfCompletedUnsuccessfully()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMThrowIfCompletedUnsuccessfully.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Runtime.CompilerServices.ValueTaskAwaiter GetAwaiter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAwaiter.Invoke(___genericsType, ___parameters);

            return (System.Runtime.CompilerServices.ValueTaskAwaiter)___result;
        }


        public virtual System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable ConfigureAwait(System.Boolean @continueOnCapturedContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continueOnCapturedContext};
            var ___result = RMConfigureAwait_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
