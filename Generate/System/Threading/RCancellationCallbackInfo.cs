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
		protected RSystem.RAction<RSystem.RObject> r_FCallback;
		public virtual RSystem.RAction<RSystem.RObject> RFCallback
		{
			get
			{
				if(r_FCallback == null)
				{
					r_FCallback = new(this, "Callback");
					r_FCallback.SetBelong(this.instance);
				}
				return r_FCallback;
			}
		}

		/// <summary>
		/// System.Object StateForCallback
		/// </summary>
		protected RSystem.RObject r_FStateForCallback;
		public virtual RSystem.RObject RFStateForCallback
		{
			get
			{
				if(r_FStateForCallback == null)
				{
					r_FStateForCallback = new(this, "StateForCallback");
					r_FStateForCallback.SetBelong(this.instance);
				}
				return r_FStateForCallback;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext TargetExecutionContext
		/// </summary>
		protected RSystem.RThreading.RExecutionContext r_FTargetExecutionContext;
		public virtual RSystem.RThreading.RExecutionContext RFTargetExecutionContext
		{
			get
			{
				if(r_FTargetExecutionContext == null)
				{
					r_FTargetExecutionContext = new(this, "TargetExecutionContext");
					r_FTargetExecutionContext.SetBelong(this.instance);
				}
				return r_FTargetExecutionContext;
			}
		}

		/// <summary>
		/// System.Threading.CancellationTokenSource CancellationTokenSource
		/// </summary>
		protected RSystem.RThreading.RCancellationTokenSource r_FCancellationTokenSource;
		public virtual RSystem.RThreading.RCancellationTokenSource RFCancellationTokenSource
		{
			get
			{
				if(r_FCancellationTokenSource == null)
				{
					r_FCancellationTokenSource = new(this, "CancellationTokenSource");
					r_FCancellationTokenSource.SetBelong(this.instance);
				}
				return r_FCancellationTokenSource;
			}
		}

		/// <summary>
		/// System.Threading.ContextCallback s_executionContextCallback
		/// </summary>
		protected static RSystem.RThreading.RContextCallback r_Fs_executionContextCallback;
		public static RSystem.RThreading.RContextCallback RFs_executionContextCallback
		{
			get
			{
				if(r_Fs_executionContextCallback == null)
				{
					r_Fs_executionContextCallback = new( ReflectionUtils.GetType("System.Threading.CancellationCallbackInfo"), "s_executionContextCallback");
					r_Fs_executionContextCallback.SetBelong(null);
				}
				return r_Fs_executionContextCallback;
			}
		}

		/// <summary>
		/// Void ExecuteCallback()
		/// </summary>
		protected RMethod r_MExecuteCallback;
		public virtual RMethod RMExecuteCallback
		{
			get
			{
				if(r_MExecuteCallback == null)
				{
					r_MExecuteCallback = new(this, "ExecuteCallback", 0);
					r_MExecuteCallback.SetBelong(this.instance);
				}
				return r_MExecuteCallback;
			}
		}

		/// <summary>
		/// Void ExecutionContextCallback(System.Object)
		/// </summary>
		protected static RMethod r_MExecutionContextCallback_Object;
		public static RMethod RMExecutionContextCallback_Object
		{
			get
			{
				if(r_MExecutionContextCallback_Object == null)
				{
					r_MExecutionContextCallback_Object = new( ReflectionUtils.GetType("System.Threading.CancellationCallbackInfo"), "ExecutionContextCallback", 0, typeof(System.Object));
					r_MExecutionContextCallback_Object.SetBelong(null);
				}
				return r_MExecutionContextCallback_Object;
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
            var ___result = RMExecuteCallback.Invoke(___genericsType, ___parameters);

            
        }


        public static void ExecutionContextCallback(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMExecutionContextCallback_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
