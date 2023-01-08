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
		protected RMethod r_SetWaitNotificationRequired;
		public virtual RMethod RSetWaitNotificationRequired
		{
			get
			{
				if(r_SetWaitNotificationRequired == null)
				{
					r_SetWaitNotificationRequired = new(this, "SetWaitNotificationRequired", 0);
					r_SetWaitNotificationRequired.SetBelong(this.instance);
				}
				return r_SetWaitNotificationRequired;
			}
		}

		/// <summary>
		/// Boolean IsWaitNotificationRequired()
		/// </summary>
		protected RMethod r_IsWaitNotificationRequired;
		public virtual RMethod RIsWaitNotificationRequired
		{
			get
			{
				if(r_IsWaitNotificationRequired == null)
				{
					r_IsWaitNotificationRequired = new(this, "IsWaitNotificationRequired", 0);
					r_IsWaitNotificationRequired.SetBelong(this.instance);
				}
				return r_IsWaitNotificationRequired;
			}
		}

		/// <summary>
		/// Void Send(System.Threading.SendOrPostCallback, System.Object)
		/// </summary>
		protected RMethod r_Send_SendOrPostCallback_Object;
		public virtual RMethod RSend_SendOrPostCallback_Object
		{
			get
			{
				if(r_Send_SendOrPostCallback_Object == null)
				{
					r_Send_SendOrPostCallback_Object = new(this, "Send", 0, typeof(System.Threading.SendOrPostCallback), typeof(System.Object));
					r_Send_SendOrPostCallback_Object.SetBelong(this.instance);
				}
				return r_Send_SendOrPostCallback_Object;
			}
		}

		/// <summary>
		/// Void Post(System.Threading.SendOrPostCallback, System.Object)
		/// </summary>
		protected RMethod r_Post_SendOrPostCallback_Object;
		public virtual RMethod RPost_SendOrPostCallback_Object
		{
			get
			{
				if(r_Post_SendOrPostCallback_Object == null)
				{
					r_Post_SendOrPostCallback_Object = new(this, "Post", 0, typeof(System.Threading.SendOrPostCallback), typeof(System.Object));
					r_Post_SendOrPostCallback_Object.SetBelong(this.instance);
				}
				return r_Post_SendOrPostCallback_Object;
			}
		}

		/// <summary>
		/// Void OperationStarted()
		/// </summary>
		protected RMethod r_OperationStarted;
		public virtual RMethod ROperationStarted
		{
			get
			{
				if(r_OperationStarted == null)
				{
					r_OperationStarted = new(this, "OperationStarted", 0);
					r_OperationStarted.SetBelong(this.instance);
				}
				return r_OperationStarted;
			}
		}

		/// <summary>
		/// Void OperationCompleted()
		/// </summary>
		protected RMethod r_OperationCompleted;
		public virtual RMethod ROperationCompleted
		{
			get
			{
				if(r_OperationCompleted == null)
				{
					r_OperationCompleted = new(this, "OperationCompleted", 0);
					r_OperationCompleted.SetBelong(this.instance);
				}
				return r_OperationCompleted;
			}
		}

		/// <summary>
		/// Int32 Wait(IntPtr[], Boolean, Int32)
		/// </summary>
		protected RMethod r_Wait_IntPtrArray_Boolean_Int32;
		public virtual RMethod RWait_IntPtrArray_Boolean_Int32
		{
			get
			{
				if(r_Wait_IntPtrArray_Boolean_Int32 == null)
				{
					r_Wait_IntPtrArray_Boolean_Int32 = new(this, "Wait", 0, typeof(System.IntPtr).MakeArrayType(), typeof(System.Boolean), typeof(System.Int32));
					r_Wait_IntPtrArray_Boolean_Int32.SetBelong(this.instance);
				}
				return r_Wait_IntPtrArray_Boolean_Int32;
			}
		}

		/// <summary>
		/// Int32 WaitHelper(IntPtr[], Boolean, Int32)
		/// </summary>
		protected static RMethod r_WaitHelper_IntPtrArray_Boolean_Int32;
		public static RMethod RWaitHelper_IntPtrArray_Boolean_Int32
		{
			get
			{
				if(r_WaitHelper_IntPtrArray_Boolean_Int32 == null)
				{
					r_WaitHelper_IntPtrArray_Boolean_Int32 = new(typeof(System.Threading.SynchronizationContext), "WaitHelper", 0, typeof(System.IntPtr).MakeArrayType(), typeof(System.Boolean), typeof(System.Int32));
					r_WaitHelper_IntPtrArray_Boolean_Int32.SetBelong(null);
				}
				return r_WaitHelper_IntPtrArray_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetSynchronizationContext(System.Threading.SynchronizationContext)
		/// </summary>
		protected static RMethod r_SetSynchronizationContext_SynchronizationContext;
		public static RMethod RSetSynchronizationContext_SynchronizationContext
		{
			get
			{
				if(r_SetSynchronizationContext_SynchronizationContext == null)
				{
					r_SetSynchronizationContext_SynchronizationContext = new(typeof(System.Threading.SynchronizationContext), "SetSynchronizationContext", 0, typeof(System.Threading.SynchronizationContext));
					r_SetSynchronizationContext_SynchronizationContext.SetBelong(null);
				}
				return r_SetSynchronizationContext_SynchronizationContext;
			}
		}

		/// <summary>
		/// System.Threading.SynchronizationContext GetThreadLocalContext()
		/// </summary>
		protected static RMethod r_GetThreadLocalContext;
		public static RMethod RGetThreadLocalContext
		{
			get
			{
				if(r_GetThreadLocalContext == null)
				{
					r_GetThreadLocalContext = new(typeof(System.Threading.SynchronizationContext), "GetThreadLocalContext", 0);
					r_GetThreadLocalContext.SetBelong(null);
				}
				return r_GetThreadLocalContext;
			}
		}

		/// <summary>
		/// System.Threading.SynchronizationContext CreateCopy()
		/// </summary>
		protected RMethod r_CreateCopy;
		public virtual RMethod RCreateCopy
		{
			get
			{
				if(r_CreateCopy == null)
				{
					r_CreateCopy = new(this, "CreateCopy", 0);
					r_CreateCopy.SetBelong(this.instance);
				}
				return r_CreateCopy;
			}
		}

		/// <summary>
		/// Int32 InvokeWaitMethodHelper(System.Threading.SynchronizationContext, IntPtr[], Boolean, Int32)
		/// </summary>
		protected static RMethod r_InvokeWaitMethodHelper_SynchronizationContext_IntPtrArray_Boolean_Int32;
		public static RMethod RInvokeWaitMethodHelper_SynchronizationContext_IntPtrArray_Boolean_Int32
		{
			get
			{
				if(r_InvokeWaitMethodHelper_SynchronizationContext_IntPtrArray_Boolean_Int32 == null)
				{
					r_InvokeWaitMethodHelper_SynchronizationContext_IntPtrArray_Boolean_Int32 = new(typeof(System.Threading.SynchronizationContext), "InvokeWaitMethodHelper", 0, typeof(System.Threading.SynchronizationContext), typeof(System.IntPtr).MakeArrayType(), typeof(System.Boolean), typeof(System.Int32));
					r_InvokeWaitMethodHelper_SynchronizationContext_IntPtrArray_Boolean_Int32.SetBelong(null);
				}
				return r_InvokeWaitMethodHelper_SynchronizationContext_IntPtrArray_Boolean_Int32;
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


        public virtual void Send(System.Threading.SendOrPostCallback @d, System.Object @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d, @state};
            var ___result = RSend_SendOrPostCallback_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Post(System.Threading.SendOrPostCallback @d, System.Object @state)
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


        public virtual System.Int32 Wait(System.IntPtr[] @waitHandles, System.Boolean @waitAll, System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles, @waitAll, @millisecondsTimeout};
            var ___result = RWait_IntPtrArray_Boolean_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 WaitHelper(System.IntPtr[] @waitHandles, System.Boolean @waitAll, System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles, @waitAll, @millisecondsTimeout};
            var ___result = RWaitHelper_IntPtrArray_Boolean_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void SetSynchronizationContext(System.Threading.SynchronizationContext @syncContext)
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


        public static System.Int32 InvokeWaitMethodHelper(System.Threading.SynchronizationContext @syncContext, System.IntPtr[] @waitHandles, System.Boolean @waitAll, System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@syncContext, @waitHandles, @waitAll, @millisecondsTimeout};
            var ___result = RInvokeWaitMethodHelper_SynchronizationContext_IntPtrArray_Boolean_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
