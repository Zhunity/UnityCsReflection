using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RCompilerServices
{public partial class RYieldAwaitable
{
	
	/// <summary>
	/// System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter
	/// </summary>
    public partial class RYieldAwaiter : RMember //
    {

		/// <summary>
		/// System.Threading.WaitCallback s_waitCallbackRunAction
		/// </summary>
		protected static RSystem.RThreading.RWaitCallback r_s_waitCallbackRunAction;
		public static RSystem.RThreading.RWaitCallback Rs_waitCallbackRunAction
		{
			get
			{
				if(r_s_waitCallbackRunAction == null)
				{
					r_s_waitCallbackRunAction = new( ReleactionUtils.GetType("System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter"), "s_waitCallbackRunAction");
					r_s_waitCallbackRunAction.SetBelong(null);
				}
				return r_s_waitCallbackRunAction;
			}
		}

		/// <summary>
		/// System.Threading.SendOrPostCallback s_sendOrPostCallbackRunAction
		/// </summary>
		protected static RSystem.RThreading.RSendOrPostCallback r_s_sendOrPostCallbackRunAction;
		public static RSystem.RThreading.RSendOrPostCallback Rs_sendOrPostCallbackRunAction
		{
			get
			{
				if(r_s_sendOrPostCallbackRunAction == null)
				{
					r_s_sendOrPostCallbackRunAction = new( ReleactionUtils.GetType("System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter"), "s_sendOrPostCallbackRunAction");
					r_s_sendOrPostCallbackRunAction.SetBelong(null);
				}
				return r_s_sendOrPostCallbackRunAction;
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
		/// Void QueueContinuation(System.Action, Boolean)
		/// </summary>
		protected static RMethod r_RQueueContinuation_Action_Boolean;
		public static RMethod RQueueContinuation_Action_Boolean
		{
			get
			{
				if(r_RQueueContinuation_Action_Boolean == null)
				{
					r_RQueueContinuation_Action_Boolean = new( ReleactionUtils.GetType("System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter"), "QueueContinuation", 0, typeof(System.Action), typeof(System.Boolean));
					r_RQueueContinuation_Action_Boolean.SetBelong(null);
				}
				return r_RQueueContinuation_Action_Boolean;
			}
		}

		/// <summary>
		/// Void RunAction(System.Object)
		/// </summary>
		protected static RMethod r_RRunAction_Object;
		public static RMethod RRunAction_Object
		{
			get
			{
				if(r_RRunAction_Object == null)
				{
					r_RRunAction_Object = new( ReleactionUtils.GetType("System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter"), "RunAction", 0, typeof(System.Object));
					r_RRunAction_Object.SetBelong(null);
				}
				return r_RRunAction_Object;
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


        public RYieldAwaiter() : base("System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter")
        {
        }

        public RYieldAwaiter(System.Object instance) : base("System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter")
		{
            SetInstance(instance);
		}

        public RYieldAwaiter(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RYieldAwaiter(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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


        public static void QueueContinuation(System.Action  @continuation, System.Boolean  @flowContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuation, @flowContext};
            var ___result = RQueueContinuation_Action_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void RunAction(System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RRunAction_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetResult()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetResult.Invoke(___genericsType, ___parameters);

            
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
}