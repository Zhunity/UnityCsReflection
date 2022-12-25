using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.CancellationCallbackInfo
	/// </summary>
    public partial class RCancellationCallbackInfo : RMember //
    {

		/// <summary>
		/// System.Action`1[System.Object] Callback
		/// </summary>
		protected RSystem.RAction<RSystem.RObject> r_Callback;
		public virtual RSystem.RAction<RSystem.RObject> RCallback
		{
			get
			{
				if(r_Callback == null)
				{
					r_Callback = new(this, "Callback");
					r_Callback.SetBelong(this.instance);
				}
				return r_Callback;
			}
		}

		/// <summary>
		/// System.Object StateForCallback
		/// </summary>
		protected RSystem.RObject r_StateForCallback;
		public virtual RSystem.RObject RStateForCallback
		{
			get
			{
				if(r_StateForCallback == null)
				{
					r_StateForCallback = new(this, "StateForCallback");
					r_StateForCallback.SetBelong(this.instance);
				}
				return r_StateForCallback;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext TargetExecutionContext
		/// </summary>
		protected RSystem.RThreading.RExecutionContext r_TargetExecutionContext;
		public virtual RSystem.RThreading.RExecutionContext RTargetExecutionContext
		{
			get
			{
				if(r_TargetExecutionContext == null)
				{
					r_TargetExecutionContext = new(this, "TargetExecutionContext");
					r_TargetExecutionContext.SetBelong(this.instance);
				}
				return r_TargetExecutionContext;
			}
		}

		/// <summary>
		/// System.Threading.CancellationTokenSource CancellationTokenSource
		/// </summary>
		protected RSystem.RThreading.RCancellationTokenSource r_CancellationTokenSource;
		public virtual RSystem.RThreading.RCancellationTokenSource RCancellationTokenSource
		{
			get
			{
				if(r_CancellationTokenSource == null)
				{
					r_CancellationTokenSource = new(this, "CancellationTokenSource");
					r_CancellationTokenSource.SetBelong(this.instance);
				}
				return r_CancellationTokenSource;
			}
		}

		/// <summary>
		/// System.Threading.ContextCallback s_executionContextCallback
		/// </summary>
		protected static RSystem.RThreading.RContextCallback r_s_executionContextCallback;
		public static RSystem.RThreading.RContextCallback Rs_executionContextCallback
		{
			get
			{
				if(r_s_executionContextCallback == null)
				{
					r_s_executionContextCallback = new( ReleactionUtils.GetType("System.Threading.CancellationCallbackInfo"), "s_executionContextCallback");
					r_s_executionContextCallback.SetBelong(null);
				}
				return r_s_executionContextCallback;
			}
		}

		/// <summary>
		/// Void ExecuteCallback()
		/// </summary>
		protected RMethod r_RExecuteCallback;
		public virtual RMethod RExecuteCallback
		{
			get
			{
				if(r_RExecuteCallback == null)
				{
					r_RExecuteCallback = new(this, "ExecuteCallback", 0);
					r_RExecuteCallback.SetBelong(this.instance);
				}
				return r_RExecuteCallback;
			}
		}

		/// <summary>
		/// Void ExecutionContextCallback(System.Object)
		/// </summary>
		protected static RMethod r_RExecutionContextCallback_Object;
		public static RMethod RExecutionContextCallback_Object
		{
			get
			{
				if(r_RExecutionContextCallback_Object == null)
				{
					r_RExecutionContextCallback_Object = new( ReleactionUtils.GetType("System.Threading.CancellationCallbackInfo"), "ExecutionContextCallback", 0, typeof(System.Object));
					r_RExecutionContextCallback_Object.SetBelong(null);
				}
				return r_RExecutionContextCallback_Object;
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


        public RCancellationCallbackInfo() : base("System.Threading.CancellationCallbackInfo")
        {
        }

        public RCancellationCallbackInfo(System.Object instance) : base("System.Threading.CancellationCallbackInfo")
		{
            SetInstance(instance);
		}

        public RCancellationCallbackInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCancellationCallbackInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void ExecuteCallback()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RExecuteCallback.Invoke(___genericsType, ___parameters);

            
        }


        public static void ExecutionContextCallback(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RExecutionContextCallback_Object.Invoke(___genericsType, ___parameters);

            
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
