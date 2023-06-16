
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Threading.SynchronizationContext
	/// </summary>
    public partial class RSynchronizationContext : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Threading.SynchronizationContext);
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
					r_Fs_cachedPreparedType1 = new(Type, "s_cachedPreparedType1");
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
					r_Fs_cachedPreparedType2 = new(Type, "s_cachedPreparedType2");
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
					r_Fs_cachedPreparedType3 = new(Type, "s_cachedPreparedType3");
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
					r_Fs_cachedPreparedType4 = new(Type, "s_cachedPreparedType4");
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
					r_Fs_cachedPreparedType5 = new(Type, "s_cachedPreparedType5");
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
					r_PCurrent = new(Type, "Current", -1);
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
					r_PCurrentNoFlow = new(Type, "CurrentNoFlow", -1);
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
					r_PCurrentExplicit = new(Type, "CurrentExplicit", -1);
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
					r_MWaitHelper_IntPtrArray_Boolean_Int32 = new(Type, "WaitHelper", 0, typeof(System.IntPtr).MakeArrayType(), typeof(System.Boolean), typeof(System.Int32));
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
					r_MSetSynchronizationContext_SynchronizationContext = new(Type, "SetSynchronizationContext", 0, typeof(System.Threading.SynchronizationContext));
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
					r_MGetThreadLocalContext = new(Type, "GetThreadLocalContext", 0);
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
					r_MInvokeWaitMethodHelper_SynchronizationContext_IntPtrArray_Boolean_Int32 = new(Type, "InvokeWaitMethodHelper", 0, typeof(System.Threading.SynchronizationContext), typeof(System.IntPtr).MakeArrayType(), typeof(System.Boolean), typeof(System.Int32));
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
				}
				return r_MToString;
			}
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

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Int32 WaitHelper(System.IntPtr[] @waitHandles, System.Boolean @waitAll, System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitHandles, @waitAll, @millisecondsTimeout};
            var ___result = RMWaitHelper_IntPtrArray_Boolean_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
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

            return ReflectionUtils.Convert<System.Threading.SynchronizationContext>(___result);
        }


        public virtual System.Threading.SynchronizationContext CreateCopy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateCopy.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.SynchronizationContext>(___result);
        }


        public static System.Int32 InvokeWaitMethodHelper(System.Threading.SynchronizationContext @syncContext, System.IntPtr[] @waitHandles, System.Boolean @waitAll, System.Int32 @millisecondsTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@syncContext, @waitHandles, @waitAll, @millisecondsTimeout};
            var ___result = RMInvokeWaitMethodHelper_SynchronizationContext_IntPtrArray_Boolean_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
