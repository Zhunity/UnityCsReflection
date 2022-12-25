using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.SynchronizationContext
	/// </summary>
    public partial class RSynchronizationContext : RMember //
    {

		/// <summary>
		/// System.Threading.SynchronizationContextProperties _props
		/// </summary>
		protected RField r__props;
		public virtual RField R_props
		{
			get
			{
				if(r__props == null)
				{
					r__props = new(this, "_props");
					r__props.SetBelong(this.instance);
				}
				return r__props;
			}
		}

		/// <summary>
		/// System.Type s_cachedPreparedType1
		/// </summary>
		protected static RSystem.RType r_s_cachedPreparedType1;
		public static RSystem.RType Rs_cachedPreparedType1
		{
			get
			{
				if(r_s_cachedPreparedType1 == null)
				{
					r_s_cachedPreparedType1 = new(typeof(System.Threading.SynchronizationContext), "s_cachedPreparedType1");
					r_s_cachedPreparedType1.SetBelong(null);
				}
				return r_s_cachedPreparedType1;
			}
		}

		/// <summary>
		/// System.Type s_cachedPreparedType2
		/// </summary>
		protected static RSystem.RType r_s_cachedPreparedType2;
		public static RSystem.RType Rs_cachedPreparedType2
		{
			get
			{
				if(r_s_cachedPreparedType2 == null)
				{
					r_s_cachedPreparedType2 = new(typeof(System.Threading.SynchronizationContext), "s_cachedPreparedType2");
					r_s_cachedPreparedType2.SetBelong(null);
				}
				return r_s_cachedPreparedType2;
			}
		}

		/// <summary>
		/// System.Type s_cachedPreparedType3
		/// </summary>
		protected static RSystem.RType r_s_cachedPreparedType3;
		public static RSystem.RType Rs_cachedPreparedType3
		{
			get
			{
				if(r_s_cachedPreparedType3 == null)
				{
					r_s_cachedPreparedType3 = new(typeof(System.Threading.SynchronizationContext), "s_cachedPreparedType3");
					r_s_cachedPreparedType3.SetBelong(null);
				}
				return r_s_cachedPreparedType3;
			}
		}

		/// <summary>
		/// System.Type s_cachedPreparedType4
		/// </summary>
		protected static RSystem.RType r_s_cachedPreparedType4;
		public static RSystem.RType Rs_cachedPreparedType4
		{
			get
			{
				if(r_s_cachedPreparedType4 == null)
				{
					r_s_cachedPreparedType4 = new(typeof(System.Threading.SynchronizationContext), "s_cachedPreparedType4");
					r_s_cachedPreparedType4.SetBelong(null);
				}
				return r_s_cachedPreparedType4;
			}
		}

		/// <summary>
		/// System.Type s_cachedPreparedType5
		/// </summary>
		protected static RSystem.RType r_s_cachedPreparedType5;
		public static RSystem.RType Rs_cachedPreparedType5
		{
			get
			{
				if(r_s_cachedPreparedType5 == null)
				{
					r_s_cachedPreparedType5 = new(typeof(System.Threading.SynchronizationContext), "s_cachedPreparedType5");
					r_s_cachedPreparedType5.SetBelong(null);
				}
				return r_s_cachedPreparedType5;
			}
		}

		/// <summary>
		/// System.Threading.SynchronizationContext Current
		/// </summary>
		protected static RSystem.RThreading.RSynchronizationContext r_Current;
		public static RSystem.RThreading.RSynchronizationContext RCurrent
		{
			get
			{
				if(r_Current == null)
				{
					r_Current = new(typeof(System.Threading.SynchronizationContext), "Current", -1);
					r_Current.SetBelong(null);
				}
				return r_Current;
			}
		}

		/// <summary>
		/// System.Threading.SynchronizationContext CurrentNoFlow
		/// </summary>
		protected static RSystem.RThreading.RSynchronizationContext r_CurrentNoFlow;
		public static RSystem.RThreading.RSynchronizationContext RCurrentNoFlow
		{
			get
			{
				if(r_CurrentNoFlow == null)
				{
					r_CurrentNoFlow = new(typeof(System.Threading.SynchronizationContext), "CurrentNoFlow", -1);
					r_CurrentNoFlow.SetBelong(null);
				}
				return r_CurrentNoFlow;
			}
		}

		/// <summary>
		/// System.Threading.SynchronizationContext CurrentExplicit
		/// </summary>
		protected static RSystem.RThreading.RSynchronizationContext r_CurrentExplicit;
		public static RSystem.RThreading.RSynchronizationContext RCurrentExplicit
		{
			get
			{
				if(r_CurrentExplicit == null)
				{
					r_CurrentExplicit = new(typeof(System.Threading.SynchronizationContext), "CurrentExplicit", -1);
					r_CurrentExplicit.SetBelong(null);
				}
				return r_CurrentExplicit;
			}
		}

		/// <summary>
		/// Void SetWaitNotificationRequired()
		/// </summary>
		protected RMethod r_RSetWaitNotificationRequired;
		public virtual RMethod RSetWaitNotificationRequired
		{
			get
			{
				if(r_RSetWaitNotificationRequired == null)
				{
					r_RSetWaitNotificationRequired = new(this, "SetWaitNotificationRequired", 0);
					r_RSetWaitNotificationRequired.SetBelong(this.instance);
				}
				return r_RSetWaitNotificationRequired;
			}
		}

		/// <summary>
		/// Boolean IsWaitNotificationRequired()
		/// </summary>
		protected RMethod r_RIsWaitNotificationRequired;
		public virtual RMethod RIsWaitNotificationRequired
		{
			get
			{
				if(r_RIsWaitNotificationRequired == null)
				{
					r_RIsWaitNotificationRequired = new(this, "IsWaitNotificationRequired", 0);
					r_RIsWaitNotificationRequired.SetBelong(this.instance);
				}
				return r_RIsWaitNotificationRequired;
			}
		}

		/// <summary>
		/// Void Send(System.Threading.SendOrPostCallback, System.Object)
		/// </summary>
		protected RMethod r_RSend_SendOrPostCallback_Object;
		public virtual RMethod RSend_SendOrPostCallback_Object
		{
			get
			{
				if(r_RSend_SendOrPostCallback_Object == null)
				{
					r_RSend_SendOrPostCallback_Object = new(this, "Send", 0, typeof(System.Threading.SendOrPostCallback), typeof(System.Object));
					r_RSend_SendOrPostCallback_Object.SetBelong(this.instance);
				}
				return r_RSend_SendOrPostCallback_Object;
			}
		}

		/// <summary>
		/// Void Post(System.Threading.SendOrPostCallback, System.Object)
		/// </summary>
		protected RMethod r_RPost_SendOrPostCallback_Object;
		public virtual RMethod RPost_SendOrPostCallback_Object
		{
			get
			{
				if(r_RPost_SendOrPostCallback_Object == null)
				{
					r_RPost_SendOrPostCallback_Object = new(this, "Post", 0, typeof(System.Threading.SendOrPostCallback), typeof(System.Object));
					r_RPost_SendOrPostCallback_Object.SetBelong(this.instance);
				}
				return r_RPost_SendOrPostCallback_Object;
			}
		}

		/// <summary>
		/// Void OperationStarted()
		/// </summary>
		protected RMethod r_ROperationStarted;
		public virtual RMethod ROperationStarted
		{
			get
			{
				if(r_ROperationStarted == null)
				{
					r_ROperationStarted = new(this, "OperationStarted", 0);
					r_ROperationStarted.SetBelong(this.instance);
				}
				return r_ROperationStarted;
			}
		}

		/// <summary>
		/// Void OperationCompleted()
		/// </summary>
		protected RMethod r_ROperationCompleted;
		public virtual RMethod ROperationCompleted
		{
			get
			{
				if(r_ROperationCompleted == null)
				{
					r_ROperationCompleted = new(this, "OperationCompleted", 0);
					r_ROperationCompleted.SetBelong(this.instance);
				}
				return r_ROperationCompleted;
			}
		}

		/// <summary>
		/// Int32 Wait(IntPtr[], Boolean, Int32)
		/// </summary>
		protected RMethod r_RWait_IntPtrArray_Boolean_Int32;
		public virtual RMethod RWait_IntPtrArray_Boolean_Int32
		{
			get
			{
				if(r_RWait_IntPtrArray_Boolean_Int32 == null)
				{
					r_RWait_IntPtrArray_Boolean_Int32 = new(this, "Wait", 0, typeof(System.IntPtr).MakeArrayType(), typeof(System.Boolean), typeof(System.Int32));
					r_RWait_IntPtrArray_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RWait_IntPtrArray_Boolean_Int32;
			}
		}

		/// <summary>
		/// Int32 WaitHelper(IntPtr[], Boolean, Int32)
		/// </summary>
		protected static RMethod r_RWaitHelper_IntPtrArray_Boolean_Int32;
		public static RMethod RWaitHelper_IntPtrArray_Boolean_Int32
		{
			get
			{
				if(r_RWaitHelper_IntPtrArray_Boolean_Int32 == null)
				{
					r_RWaitHelper_IntPtrArray_Boolean_Int32 = new(typeof(System.Threading.SynchronizationContext), "WaitHelper", 0, typeof(System.IntPtr).MakeArrayType(), typeof(System.Boolean), typeof(System.Int32));
					r_RWaitHelper_IntPtrArray_Boolean_Int32.SetBelong(null);
				}
				return r_RWaitHelper_IntPtrArray_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetSynchronizationContext(System.Threading.SynchronizationContext)
		/// </summary>
		protected static RMethod r_RSetSynchronizationContext_SynchronizationContext;
		public static RMethod RSetSynchronizationContext_SynchronizationContext
		{
			get
			{
				if(r_RSetSynchronizationContext_SynchronizationContext == null)
				{
					r_RSetSynchronizationContext_SynchronizationContext = new(typeof(System.Threading.SynchronizationContext), "SetSynchronizationContext", 0, typeof(System.Threading.SynchronizationContext));
					r_RSetSynchronizationContext_SynchronizationContext.SetBelong(null);
				}
				return r_RSetSynchronizationContext_SynchronizationContext;
			}
		}

		/// <summary>
		/// System.Threading.SynchronizationContext GetThreadLocalContext()
		/// </summary>
		protected static RMethod r_RGetThreadLocalContext;
		public static RMethod RGetThreadLocalContext
		{
			get
			{
				if(r_RGetThreadLocalContext == null)
				{
					r_RGetThreadLocalContext = new(typeof(System.Threading.SynchronizationContext), "GetThreadLocalContext", 0);
					r_RGetThreadLocalContext.SetBelong(null);
				}
				return r_RGetThreadLocalContext;
			}
		}

		/// <summary>
		/// System.Threading.SynchronizationContext CreateCopy()
		/// </summary>
		protected RMethod r_RCreateCopy;
		public virtual RMethod RCreateCopy
		{
			get
			{
				if(r_RCreateCopy == null)
				{
					r_RCreateCopy = new(this, "CreateCopy", 0);
					r_RCreateCopy.SetBelong(this.instance);
				}
				return r_RCreateCopy;
			}
		}

		/// <summary>
		/// Int32 InvokeWaitMethodHelper(System.Threading.SynchronizationContext, IntPtr[], Boolean, Int32)
		/// </summary>
		protected static RMethod r_RInvokeWaitMethodHelper_SynchronizationContext_IntPtrArray_Boolean_Int32;
		public static RMethod RInvokeWaitMethodHelper_SynchronizationContext_IntPtrArray_Boolean_Int32
		{
			get
			{
				if(r_RInvokeWaitMethodHelper_SynchronizationContext_IntPtrArray_Boolean_Int32 == null)
				{
					r_RInvokeWaitMethodHelper_SynchronizationContext_IntPtrArray_Boolean_Int32 = new(typeof(System.Threading.SynchronizationContext), "InvokeWaitMethodHelper", 0, typeof(System.Threading.SynchronizationContext), typeof(System.IntPtr).MakeArrayType(), typeof(System.Boolean), typeof(System.Int32));
					r_RInvokeWaitMethodHelper_SynchronizationContext_IntPtrArray_Boolean_Int32.SetBelong(null);
				}
				return r_RInvokeWaitMethodHelper_SynchronizationContext_IntPtrArray_Boolean_Int32;
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


        public RSynchronizationContext() : base("System.Threading.SynchronizationContext")
        {
        }

        public RSynchronizationContext(System.Object instance) : base("System.Threading.SynchronizationContext")
		{
            SetInstance(instance);
		}

        public RSynchronizationContext(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSynchronizationContext(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetWaitNotificationRequired()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetWaitNotificationRequired.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsWaitNotificationRequired()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsWaitNotificationRequired.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Send(System.Threading.SendOrPostCallback  @d, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d, @state};
            var ___result = RSend_SendOrPostCallback_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Post(System.Threading.SendOrPostCallback  @d, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d, @state};
            var ___result = RPost_SendOrPostCallback_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OperationStarted()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROperationStarted.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OperationCompleted()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROperationCompleted.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 Wait(System.IntPtr[]  @waitHandles, System.Boolean  @waitAll, System.Int32  @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles, @waitAll, @millisecondsTimeout};
            var ___result = RWait_IntPtrArray_Boolean_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 WaitHelper(System.IntPtr[]  @waitHandles, System.Boolean  @waitAll, System.Int32  @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles, @waitAll, @millisecondsTimeout};
            var ___result = RWaitHelper_IntPtrArray_Boolean_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void SetSynchronizationContext(System.Threading.SynchronizationContext  @syncContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@syncContext};
            var ___result = RSetSynchronizationContext_SynchronizationContext.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Threading.SynchronizationContext GetThreadLocalContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetThreadLocalContext.Invoke(___genericsType, ___parameters);

            return (System.Threading.SynchronizationContext)___result;
        }


        public virtual System.Threading.SynchronizationContext CreateCopy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateCopy.Invoke(___genericsType, ___parameters);

            return (System.Threading.SynchronizationContext)___result;
        }


        public static System.Int32 InvokeWaitMethodHelper(System.Threading.SynchronizationContext  @syncContext, System.IntPtr[]  @waitHandles, System.Boolean  @waitAll, System.Int32  @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@syncContext, @waitHandles, @waitAll, @millisecondsTimeout};
            var ___result = RInvokeWaitMethodHelper_SynchronizationContext_IntPtrArray_Boolean_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
