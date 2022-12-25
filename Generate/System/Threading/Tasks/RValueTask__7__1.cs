using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks
{
	/// <summary>
	/// System.Threading.Tasks.ValueTask`1
	/// </summary>
    public partial class RValueTask<TResult> : RMember //
    {

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] s_canceledTask
		/// </summary>
		protected static RSystem.RThreading.RTasks.RTask<RField> r_s_canceledTask;
		public static RSystem.RThreading.RTasks.RTask<RField> Rs_canceledTask
		{
			get
			{
				if(r_s_canceledTask == null)
				{
					r_s_canceledTask = new(typeof(System.Threading.Tasks.ValueTask<>), "s_canceledTask");
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
		/// TResult _result
		/// </summary>
		protected RField r__result;
		public virtual RField R_result
		{
			get
			{
				if(r__result == null)
				{
					r__result = new(this, "_result");
					r__result.SetBelong(this.instance);
				}
				return r__result;
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
		/// TResult Result
		/// </summary>
		protected RProperty r_Result;
		public virtual RProperty Result
		{
			get
			{
				if(r_Result == null)
				{
					r_Result = new(this, "Result", -1);
					r_Result.SetBelong(this.instance);
				}
				return r_Result;
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
		/// Boolean Equals(System.Threading.Tasks.ValueTask`1[TResult])
		/// </summary>
		protected RMethod r_REquals_ValueTask_d_TResult_p_;
		public virtual RMethod REquals_ValueTask_d_TResult_p_
		{
			get
			{
				if(r_REquals_ValueTask_d_TResult_p_ == null)
				{
					r_REquals_ValueTask_d_TResult_p_ = new(this, "Equals", 0, typeof(System.Threading.Tasks.ValueTask<>));
					r_REquals_ValueTask_d_TResult_p_.SetBelong(this.instance);
				}
				return r_REquals_ValueTask_d_TResult_p_;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Threading.Tasks.ValueTask`1[TResult], System.Threading.Tasks.ValueTask`1[TResult])
		/// </summary>
		protected static RMethod r_Rop_Equality_ValueTask_d_TResult_p__ValueTask_d_TResult_p_;
		public static RMethod Rop_Equality_ValueTask_d_TResult_p__ValueTask_d_TResult_p_
		{
			get
			{
				if(r_Rop_Equality_ValueTask_d_TResult_p__ValueTask_d_TResult_p_ == null)
				{
					r_Rop_Equality_ValueTask_d_TResult_p__ValueTask_d_TResult_p_ = new(typeof(System.Threading.Tasks.ValueTask<>), "op_Equality", 0, typeof(System.Threading.Tasks.ValueTask<>), typeof(System.Threading.Tasks.ValueTask<>));
					r_Rop_Equality_ValueTask_d_TResult_p__ValueTask_d_TResult_p_.SetBelong(null);
				}
				return r_Rop_Equality_ValueTask_d_TResult_p__ValueTask_d_TResult_p_;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Threading.Tasks.ValueTask`1[TResult], System.Threading.Tasks.ValueTask`1[TResult])
		/// </summary>
		protected static RMethod r_Rop_Inequality_ValueTask_d_TResult_p__ValueTask_d_TResult_p_;
		public static RMethod Rop_Inequality_ValueTask_d_TResult_p__ValueTask_d_TResult_p_
		{
			get
			{
				if(r_Rop_Inequality_ValueTask_d_TResult_p__ValueTask_d_TResult_p_ == null)
				{
					r_Rop_Inequality_ValueTask_d_TResult_p__ValueTask_d_TResult_p_ = new(typeof(System.Threading.Tasks.ValueTask<>), "op_Inequality", 0, typeof(System.Threading.Tasks.ValueTask<>), typeof(System.Threading.Tasks.ValueTask<>));
					r_Rop_Inequality_ValueTask_d_TResult_p__ValueTask_d_TResult_p_.SetBelong(null);
				}
				return r_Rop_Inequality_ValueTask_d_TResult_p__ValueTask_d_TResult_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] AsTask()
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
		/// System.Threading.Tasks.ValueTask`1[TResult] Preserve()
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
		/// System.Threading.Tasks.Task`1[TResult] GetTaskForValueTaskSource(System.Threading.Tasks.Sources.IValueTaskSource`1[TResult])
		/// </summary>
		protected RMethod r_RGetTaskForValueTaskSource_IValueTaskSource_d_TResult_p_;
		public virtual RMethod RGetTaskForValueTaskSource_IValueTaskSource_d_TResult_p_
		{
			get
			{
				if(r_RGetTaskForValueTaskSource_IValueTaskSource_d_TResult_p_ == null)
				{
					r_RGetTaskForValueTaskSource_IValueTaskSource_d_TResult_p_ = new(this, "GetTaskForValueTaskSource", 0, typeof(System.Threading.Tasks.Sources.IValueTaskSource<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RGetTaskForValueTaskSource_IValueTaskSource_d_TResult_p_.SetBelong(this.instance);
				}
				return r_RGetTaskForValueTaskSource_IValueTaskSource_d_TResult_p_;
			}
		}

		/// <summary>
		/// System.Runtime.CompilerServices.ValueTaskAwaiter`1[TResult] GetAwaiter()
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
		/// System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable`1[TResult] ConfigureAwait(Boolean)
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


        public RValueTask() : base("System.Threading.Tasks.ValueTask`1")
        {
        }

        public RValueTask(System.Object instance) : base("System.Threading.Tasks.ValueTask`1")
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


        public virtual System.Boolean Equals(System.Threading.Tasks.ValueTask<TResult>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_ValueTask_d_TResult_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.Threading.Tasks.ValueTask<TResult>  @left, System.Threading.Tasks.ValueTask<TResult>  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_ValueTask_d_TResult_p__ValueTask_d_TResult_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Threading.Tasks.ValueTask<TResult>  @left, System.Threading.Tasks.ValueTask<TResult>  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_ValueTask_d_TResult_p__ValueTask_d_TResult_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> AsTask()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAsTask.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Threading.Tasks.ValueTask<TResult> Preserve()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPreserve.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask<TResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<TResult> GetTaskForValueTaskSource(System.Threading.Tasks.Sources.IValueTaskSource<TResult>  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RGetTaskForValueTaskSource_IValueTaskSource_d_TResult_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
        }


        public virtual System.Runtime.CompilerServices.ValueTaskAwaiter<TResult> GetAwaiter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAwaiter.Invoke(___genericsType, ___parameters);

            return (System.Runtime.CompilerServices.ValueTaskAwaiter<TResult>)___result;
        }


        public virtual System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable<TResult> ConfigureAwait(System.Boolean  @continueOnCapturedContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continueOnCapturedContext};
            var ___result = RConfigureAwait_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable<TResult>)___result;
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
