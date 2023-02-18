
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.SynchronizationContext
	/// </summary>
    public partial class RSynchronizationContext : RMember //
    {

		/// <summary>
		/// System.Threading.SynchronizationContextProperties _props
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RSynchronizationContextProperties r_F_props;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RSynchronizationContextProperties RF_props
		{
			get
			{
				if(r_F_props == null)
				{
					r_F_props = new(this, "_props");
					r_F_props.SetBelong(this.GetValue());
				}
				return r_F_props;
			}
		}

		/// <summary>
		/// System.Type s_cachedPreparedType1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RType r_Fs_cachedPreparedType1;
		public static Hvak.Editor.Refleaction.RSystem.RType RFs_cachedPreparedType1
		{
			get
			{
				if(r_Fs_cachedPreparedType1 == null)
				{
					r_Fs_cachedPreparedType1 = new(typeof(System.Threading.SynchronizationContext), "s_cachedPreparedType1");
					r_Fs_cachedPreparedType1.SetBelong(null);
				}
				return r_Fs_cachedPreparedType1;
			}
		}

		/// <summary>
		/// System.Type s_cachedPreparedType2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RType r_Fs_cachedPreparedType2;
		public static Hvak.Editor.Refleaction.RSystem.RType RFs_cachedPreparedType2
		{
			get
			{
				if(r_Fs_cachedPreparedType2 == null)
				{
					r_Fs_cachedPreparedType2 = new(typeof(System.Threading.SynchronizationContext), "s_cachedPreparedType2");
					r_Fs_cachedPreparedType2.SetBelong(null);
				}
				return r_Fs_cachedPreparedType2;
			}
		}

		/// <summary>
		/// System.Type s_cachedPreparedType3
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RType r_Fs_cachedPreparedType3;
		public static Hvak.Editor.Refleaction.RSystem.RType RFs_cachedPreparedType3
		{
			get
			{
				if(r_Fs_cachedPreparedType3 == null)
				{
					r_Fs_cachedPreparedType3 = new(typeof(System.Threading.SynchronizationContext), "s_cachedPreparedType3");
					r_Fs_cachedPreparedType3.SetBelong(null);
				}
				return r_Fs_cachedPreparedType3;
			}
		}

		/// <summary>
		/// System.Type s_cachedPreparedType4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RType r_Fs_cachedPreparedType4;
		public static Hvak.Editor.Refleaction.RSystem.RType RFs_cachedPreparedType4
		{
			get
			{
				if(r_Fs_cachedPreparedType4 == null)
				{
					r_Fs_cachedPreparedType4 = new(typeof(System.Threading.SynchronizationContext), "s_cachedPreparedType4");
					r_Fs_cachedPreparedType4.SetBelong(null);
				}
				return r_Fs_cachedPreparedType4;
			}
		}

		/// <summary>
		/// System.Type s_cachedPreparedType5
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RType r_Fs_cachedPreparedType5;
		public static Hvak.Editor.Refleaction.RSystem.RType RFs_cachedPreparedType5
		{
			get
			{
				if(r_Fs_cachedPreparedType5 == null)
				{
					r_Fs_cachedPreparedType5 = new(typeof(System.Threading.SynchronizationContext), "s_cachedPreparedType5");
					r_Fs_cachedPreparedType5.SetBelong(null);
				}
				return r_Fs_cachedPreparedType5;
			}
		}

		/// <summary>
		/// System.Threading.SynchronizationContext Current
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RSynchronizationContext r_PCurrent;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RSynchronizationContext RPCurrent
		{
			get
			{
				if(r_PCurrent == null)
				{
					r_PCurrent = new(typeof(System.Threading.SynchronizationContext), "Current", -1);
					r_PCurrent.SetBelong(null);
				}
				return r_PCurrent;
			}
		}

		/// <summary>
		/// System.Threading.SynchronizationContext CurrentNoFlow
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RSynchronizationContext r_PCurrentNoFlow;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RSynchronizationContext RPCurrentNoFlow
		{
			get
			{
				if(r_PCurrentNoFlow == null)
				{
					r_PCurrentNoFlow = new(typeof(System.Threading.SynchronizationContext), "CurrentNoFlow", -1);
					r_PCurrentNoFlow.SetBelong(null);
				}
				return r_PCurrentNoFlow;
			}
		}

		/// <summary>
		/// System.Threading.SynchronizationContext CurrentExplicit
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RSynchronizationContext r_PCurrentExplicit;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RSynchronizationContext RPCurrentExplicit
		{
			get
			{
				if(r_PCurrentExplicit == null)
				{
					r_PCurrentExplicit = new(typeof(System.Threading.SynchronizationContext), "CurrentExplicit", -1);
					r_PCurrentExplicit.SetBelong(null);
				}
				return r_PCurrentExplicit;
			}
		}

		/// <summary>
		/// Void SetWaitNotificationRequired()
		/// </summary>
		protected RMethod r_MSetWaitNotificationRequired;
		public virtual RMethod RMSetWaitNotificationRequired
		{
			get
			{
				if(r_MSetWaitNotificationRequired == null)
				{
					r_MSetWaitNotificationRequired = new(this, "SetWaitNotificationRequired", 0);
					r_MSetWaitNotificationRequired.SetBelong(this.GetValue());
				}
				return r_MSetWaitNotificationRequired;
			}
		}

		/// <summary>
		/// Boolean IsWaitNotificationRequired()
		/// </summary>
		protected RMethod r_MIsWaitNotificationRequired;
		public virtual RMethod RMIsWaitNotificationRequired
		{
			get
			{
				if(r_MIsWaitNotificationRequired == null)
				{
					r_MIsWaitNotificationRequired = new(this, "IsWaitNotificationRequired", 0);
					r_MIsWaitNotificationRequired.SetBelong(this.GetValue());
				}
				return r_MIsWaitNotificationRequired;
			}
		}

		/// <summary>
		/// Void Send(System.Threading.SendOrPostCallback, System.Object)
		/// </summary>
		protected RMethod r_MSend_SendOrPostCallback_Object;
		public virtual RMethod RMSend_SendOrPostCallback_Object
		{
			get
			{
				if(r_MSend_SendOrPostCallback_Object == null)
				{
					r_MSend_SendOrPostCallback_Object = new(this, "Send", 0, typeof(System.Threading.SendOrPostCallback), typeof(System.Object));
					r_MSend_SendOrPostCallback_Object.SetBelong(this.GetValue());
				}
				return r_MSend_SendOrPostCallback_Object;
			}
		}

		/// <summary>
		/// Void Post(System.Threading.SendOrPostCallback, System.Object)
		/// </summary>
		protected RMethod r_MPost_SendOrPostCallback_Object;
		public virtual RMethod RMPost_SendOrPostCallback_Object
		{
			get
			{
				if(r_MPost_SendOrPostCallback_Object == null)
				{
					r_MPost_SendOrPostCallback_Object = new(this, "Post", 0, typeof(System.Threading.SendOrPostCallback), typeof(System.Object));
					r_MPost_SendOrPostCallback_Object.SetBelong(this.GetValue());
				}
				return r_MPost_SendOrPostCallback_Object;
			}
		}

		/// <summary>
		/// Void OperationStarted()
		/// </summary>
		protected RMethod r_MOperationStarted;
		public virtual RMethod RMOperationStarted
		{
			get
			{
				if(r_MOperationStarted == null)
				{
					r_MOperationStarted = new(this, "OperationStarted", 0);
					r_MOperationStarted.SetBelong(this.GetValue());
				}
				return r_MOperationStarted;
			}
		}

		/// <summary>
		/// Void OperationCompleted()
		/// </summary>
		protected RMethod r_MOperationCompleted;
		public virtual RMethod RMOperationCompleted
		{
			get
			{
				if(r_MOperationCompleted == null)
				{
					r_MOperationCompleted = new(this, "OperationCompleted", 0);
					r_MOperationCompleted.SetBelong(this.GetValue());
				}
				return r_MOperationCompleted;
			}
		}

		/// <summary>
		/// Int32 Wait(IntPtr[], Boolean, Int32)
		/// </summary>
		protected RMethod r_MWait_IntPtrArray_Boolean_Int32;
		public virtual RMethod RMWait_IntPtrArray_Boolean_Int32
		{
			get
			{
				if(r_MWait_IntPtrArray_Boolean_Int32 == null)
				{
					r_MWait_IntPtrArray_Boolean_Int32 = new(this, "Wait", 0, typeof(System.IntPtr).MakeArrayType(), typeof(System.Boolean), typeof(System.Int32));
					r_MWait_IntPtrArray_Boolean_Int32.SetBelong(this.GetValue());
				}
				return r_MWait_IntPtrArray_Boolean_Int32;
			}
		}

		/// <summary>
		/// Int32 WaitHelper(IntPtr[], Boolean, Int32)
		/// </summary>
		protected static RMethod r_MWaitHelper_IntPtrArray_Boolean_Int32;
		public static RMethod RMWaitHelper_IntPtrArray_Boolean_Int32
		{
			get
			{
				if(r_MWaitHelper_IntPtrArray_Boolean_Int32 == null)
				{
					r_MWaitHelper_IntPtrArray_Boolean_Int32 = new(typeof(System.Threading.SynchronizationContext), "WaitHelper", 0, typeof(System.IntPtr).MakeArrayType(), typeof(System.Boolean), typeof(System.Int32));
					r_MWaitHelper_IntPtrArray_Boolean_Int32.SetBelong(null);
				}
				return r_MWaitHelper_IntPtrArray_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetSynchronizationContext(System.Threading.SynchronizationContext)
		/// </summary>
		protected static RMethod r_MSetSynchronizationContext_SynchronizationContext;
		public static RMethod RMSetSynchronizationContext_SynchronizationContext
		{
			get
			{
				if(r_MSetSynchronizationContext_SynchronizationContext == null)
				{
					r_MSetSynchronizationContext_SynchronizationContext = new(typeof(System.Threading.SynchronizationContext), "SetSynchronizationContext", 0, typeof(System.Threading.SynchronizationContext));
					r_MSetSynchronizationContext_SynchronizationContext.SetBelong(null);
				}
				return r_MSetSynchronizationContext_SynchronizationContext;
			}
		}

		/// <summary>
		/// System.Threading.SynchronizationContext GetThreadLocalContext()
		/// </summary>
		protected static RMethod r_MGetThreadLocalContext;
		public static RMethod RMGetThreadLocalContext
		{
			get
			{
				if(r_MGetThreadLocalContext == null)
				{
					r_MGetThreadLocalContext = new(typeof(System.Threading.SynchronizationContext), "GetThreadLocalContext", 0);
					r_MGetThreadLocalContext.SetBelong(null);
				}
				return r_MGetThreadLocalContext;
			}
		}

		/// <summary>
		/// System.Threading.SynchronizationContext CreateCopy()
		/// </summary>
		protected RMethod r_MCreateCopy;
		public virtual RMethod RMCreateCopy
		{
			get
			{
				if(r_MCreateCopy == null)
				{
					r_MCreateCopy = new(this, "CreateCopy", 0);
					r_MCreateCopy.SetBelong(this.GetValue());
				}
				return r_MCreateCopy;
			}
		}

		/// <summary>
		/// Int32 InvokeWaitMethodHelper(System.Threading.SynchronizationContext, IntPtr[], Boolean, Int32)
		/// </summary>
		protected static RMethod r_MInvokeWaitMethodHelper_SynchronizationContext_IntPtrArray_Boolean_Int32;
		public static RMethod RMInvokeWaitMethodHelper_SynchronizationContext_IntPtrArray_Boolean_Int32
		{
			get
			{
				if(r_MInvokeWaitMethodHelper_SynchronizationContext_IntPtrArray_Boolean_Int32 == null)
				{
					r_MInvokeWaitMethodHelper_SynchronizationContext_IntPtrArray_Boolean_Int32 = new(typeof(System.Threading.SynchronizationContext), "InvokeWaitMethodHelper", 0, typeof(System.Threading.SynchronizationContext), typeof(System.IntPtr).MakeArrayType(), typeof(System.Boolean), typeof(System.Int32));
					r_MInvokeWaitMethodHelper_SynchronizationContext_IntPtrArray_Boolean_Int32.SetBelong(null);
				}
				return r_MInvokeWaitMethodHelper_SynchronizationContext_IntPtrArray_Boolean_Int32;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
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
            var ___result = RMSetWaitNotificationRequired.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsWaitNotificationRequired()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsWaitNotificationRequired.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Send(System.Threading.SendOrPostCallback @d, System.Object @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d, @state};
            var ___result = RMSend_SendOrPostCallback_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Post(System.Threading.SendOrPostCallback @d, System.Object @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d, @state};
            var ___result = RMPost_SendOrPostCallback_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OperationStarted()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOperationStarted.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OperationCompleted()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOperationCompleted.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 Wait(System.IntPtr[] @waitHandles, System.Boolean @waitAll, System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles, @waitAll, @millisecondsTimeout};
            var ___result = RMWait_IntPtrArray_Boolean_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 WaitHelper(System.IntPtr[] @waitHandles, System.Boolean @waitAll, System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles, @waitAll, @millisecondsTimeout};
            var ___result = RMWaitHelper_IntPtrArray_Boolean_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void SetSynchronizationContext(System.Threading.SynchronizationContext @syncContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@syncContext};
            var ___result = RMSetSynchronizationContext_SynchronizationContext.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Threading.SynchronizationContext GetThreadLocalContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetThreadLocalContext.Invoke(___genericsType, ___parameters);

            return (System.Threading.SynchronizationContext)___result;
        }


        public virtual System.Threading.SynchronizationContext CreateCopy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateCopy.Invoke(___genericsType, ___parameters);

            return (System.Threading.SynchronizationContext)___result;
        }


        public static System.Int32 InvokeWaitMethodHelper(System.Threading.SynchronizationContext @syncContext, System.IntPtr[] @waitHandles, System.Boolean @waitAll, System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@syncContext, @waitHandles, @waitAll, @millisecondsTimeout};
            var ___result = RMInvokeWaitMethodHelper_SynchronizationContext_IntPtrArray_Boolean_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
