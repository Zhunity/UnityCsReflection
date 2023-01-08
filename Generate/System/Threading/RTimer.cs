using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.Timer
	/// </summary>
    public partial class RTimer : RMember //
    {

		/// <summary>
		/// System.Threading.TimerCallback callback
		/// </summary>
		protected RSystem.RThreading.RTimerCallback r_callback;
		public virtual RSystem.RThreading.RTimerCallback Rcallback
		{
			get
			{
				if(r_callback == null)
				{
					r_callback = new(this, "callback");
					r_callback.SetBelong(this.instance);
				}
				return r_callback;
			}
		}

		/// <summary>
		/// System.Object state
		/// </summary>
		protected RSystem.RObject r_state;
		public virtual RSystem.RObject Rstate
		{
			get
			{
				if(r_state == null)
				{
					r_state = new(this, "state");
					r_state.SetBelong(this.instance);
				}
				return r_state;
			}
		}

		/// <summary>
		/// System.Int64 due_time_ms
		/// </summary>
		protected RField r_due_time_ms;
		public virtual RField Rdue_time_ms
		{
			get
			{
				if(r_due_time_ms == null)
				{
					r_due_time_ms = new(this, "due_time_ms");
					r_due_time_ms.SetBelong(this.instance);
				}
				return r_due_time_ms;
			}
		}

		/// <summary>
		/// System.Int64 period_ms
		/// </summary>
		protected RField r_period_ms;
		public virtual RField Rperiod_ms
		{
			get
			{
				if(r_period_ms == null)
				{
					r_period_ms = new(this, "period_ms");
					r_period_ms.SetBelong(this.instance);
				}
				return r_period_ms;
			}
		}

		/// <summary>
		/// System.Int64 next_run
		/// </summary>
		protected RField r_next_run;
		public virtual RField Rnext_run
		{
			get
			{
				if(r_next_run == null)
				{
					r_next_run = new(this, "next_run");
					r_next_run.SetBelong(this.instance);
				}
				return r_next_run;
			}
		}

		/// <summary>
		/// System.Boolean disposed
		/// </summary>
		protected RField r_disposed;
		public virtual RField Rdisposed
		{
			get
			{
				if(r_disposed == null)
				{
					r_disposed = new(this, "disposed");
					r_disposed.SetBelong(this.instance);
				}
				return r_disposed;
			}
		}

		/// <summary>
		/// System.Boolean is_dead
		/// </summary>
		protected RField r_is_dead;
		public virtual RField Ris_dead
		{
			get
			{
				if(r_is_dead == null)
				{
					r_is_dead = new(this, "is_dead");
					r_is_dead.SetBelong(this.instance);
				}
				return r_is_dead;
			}
		}

		/// <summary>
		/// System.Boolean is_added
		/// </summary>
		protected RField r_is_added;
		public virtual RField Ris_added
		{
			get
			{
				if(r_is_added == null)
				{
					r_is_added = new(this, "is_added");
					r_is_added.SetBelong(this.instance);
				}
				return r_is_added;
			}
		}

		/// <summary>
		/// System.Int64 MaxValue
		/// </summary>
		protected static RField r_MaxValue;
		public static RField RMaxValue
		{
			get
			{
				if(r_MaxValue == null)
				{
					r_MaxValue = new(typeof(System.Threading.Timer), "MaxValue");
					r_MaxValue.SetBelong(null);
				}
				return r_MaxValue;
			}
		}

		/// <summary>
		/// Scheduler scheduler
		/// </summary>
		protected static RSystem.RThreading.RTimer.RScheduler r_scheduler;
		public static RSystem.RThreading.RTimer.RScheduler Rscheduler
		{
			get
			{
				if(r_scheduler == null)
				{
					r_scheduler = new(typeof(System.Threading.Timer), "scheduler", -1);
					r_scheduler.SetBelong(null);
				}
				return r_scheduler;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ServerIdentity ObjectIdentity
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RServerIdentity r_ObjectIdentity;
		public virtual RSystem.RRuntime.RRemoting.RServerIdentity RObjectIdentity
		{
			get
			{
				if(r_ObjectIdentity == null)
				{
					r_ObjectIdentity = new(this, "ObjectIdentity", -1);
					r_ObjectIdentity.SetBelong(this.instance);
				}
				return r_ObjectIdentity;
			}
		}

		/// <summary>
		/// Void Init(System.Threading.TimerCallback, System.Object, Int64, Int64)
		/// </summary>
		protected RMethod r_Init_TimerCallback_Object_Int64_Int64;
		public virtual RMethod RInit_TimerCallback_Object_Int64_Int64
		{
			get
			{
				if(r_Init_TimerCallback_Object_Int64_Int64 == null)
				{
					r_Init_TimerCallback_Object_Int64_Int64 = new(this, "Init", 0, typeof(System.Threading.TimerCallback), typeof(System.Object), typeof(System.Int64), typeof(System.Int64));
					r_Init_TimerCallback_Object_Int64_Int64.SetBelong(this.instance);
				}
				return r_Init_TimerCallback_Object_Int64_Int64;
			}
		}

		/// <summary>
		/// Boolean Change(Int32, Int32)
		/// </summary>
		protected RMethod r_Change_Int32_Int32;
		public virtual RMethod RChange_Int32_Int32
		{
			get
			{
				if(r_Change_Int32_Int32 == null)
				{
					r_Change_Int32_Int32 = new(this, "Change", 0, typeof(System.Int32), typeof(System.Int32));
					r_Change_Int32_Int32.SetBelong(this.instance);
				}
				return r_Change_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean Change(System.TimeSpan, System.TimeSpan)
		/// </summary>
		protected RMethod r_Change_TimeSpan_TimeSpan;
		public virtual RMethod RChange_TimeSpan_TimeSpan
		{
			get
			{
				if(r_Change_TimeSpan_TimeSpan == null)
				{
					r_Change_TimeSpan_TimeSpan = new(this, "Change", 0, typeof(System.TimeSpan), typeof(System.TimeSpan));
					r_Change_TimeSpan_TimeSpan.SetBelong(this.instance);
				}
				return r_Change_TimeSpan_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean Change(UInt32, UInt32)
		/// </summary>
		protected RMethod r_Change_UInt32_UInt32;
		public virtual RMethod RChange_UInt32_UInt32
		{
			get
			{
				if(r_Change_UInt32_UInt32 == null)
				{
					r_Change_UInt32_UInt32 = new(this, "Change", 0, typeof(System.UInt32), typeof(System.UInt32));
					r_Change_UInt32_UInt32.SetBelong(this.instance);
				}
				return r_Change_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_Dispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_Dispose == null)
				{
					r_Dispose = new(this, "Dispose", 0);
					r_Dispose.SetBelong(this.instance);
				}
				return r_Dispose;
			}
		}

		/// <summary>
		/// Boolean Change(Int64, Int64)
		/// </summary>
		protected RMethod r_Change_Int64_Int64;
		public virtual RMethod RChange_Int64_Int64
		{
			get
			{
				if(r_Change_Int64_Int64 == null)
				{
					r_Change_Int64_Int64 = new(this, "Change", 0, typeof(System.Int64), typeof(System.Int64));
					r_Change_Int64_Int64.SetBelong(this.instance);
				}
				return r_Change_Int64_Int64;
			}
		}

		/// <summary>
		/// Boolean Change(Int64, Int64, Boolean)
		/// </summary>
		protected RMethod r_Change_Int64_Int64_Boolean;
		public virtual RMethod RChange_Int64_Int64_Boolean
		{
			get
			{
				if(r_Change_Int64_Int64_Boolean == null)
				{
					r_Change_Int64_Int64_Boolean = new(this, "Change", 0, typeof(System.Int64), typeof(System.Int64), typeof(System.Boolean));
					r_Change_Int64_Int64_Boolean.SetBelong(this.instance);
				}
				return r_Change_Int64_Int64_Boolean;
			}
		}

		/// <summary>
		/// Boolean Dispose(System.Threading.WaitHandle)
		/// </summary>
		protected RMethod r_Dispose_WaitHandle;
		public virtual RMethod RDispose_WaitHandle
		{
			get
			{
				if(r_Dispose_WaitHandle == null)
				{
					r_Dispose_WaitHandle = new(this, "Dispose", 0, typeof(System.Threading.WaitHandle));
					r_Dispose_WaitHandle.SetBelong(this.instance);
				}
				return r_Dispose_WaitHandle;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask DisposeAsync()
		/// </summary>
		protected RMethod r_DisposeAsync;
		public virtual RMethod RDisposeAsync
		{
			get
			{
				if(r_DisposeAsync == null)
				{
					r_DisposeAsync = new(this, "DisposeAsync", 0);
					r_DisposeAsync.SetBelong(this.instance);
				}
				return r_DisposeAsync;
			}
		}

		/// <summary>
		/// Void KeepRootedWhileScheduled()
		/// </summary>
		protected RMethod r_KeepRootedWhileScheduled;
		public virtual RMethod RKeepRootedWhileScheduled
		{
			get
			{
				if(r_KeepRootedWhileScheduled == null)
				{
					r_KeepRootedWhileScheduled = new(this, "KeepRootedWhileScheduled", 0);
					r_KeepRootedWhileScheduled.SetBelong(this.instance);
				}
				return r_KeepRootedWhileScheduled;
			}
		}

		/// <summary>
		/// Int64 GetTimeMonotonic()
		/// </summary>
		protected static RMethod r_GetTimeMonotonic;
		public static RMethod RGetTimeMonotonic
		{
			get
			{
				if(r_GetTimeMonotonic == null)
				{
					r_GetTimeMonotonic = new(typeof(System.Threading.Timer), "GetTimeMonotonic", 0);
					r_GetTimeMonotonic.SetBelong(null);
				}
				return r_GetTimeMonotonic;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Identity GetObjectIdentity(System.MarshalByRefObject, Boolean ByRef)
		/// </summary>
		protected RMethod r_GetObjectIdentity_MarshalByRefObject_Out_Boolean;
		public virtual RMethod RGetObjectIdentity_MarshalByRefObject_Out_Boolean
		{
			get
			{
				if(r_GetObjectIdentity_MarshalByRefObject_Out_Boolean == null)
				{
					r_GetObjectIdentity_MarshalByRefObject_Out_Boolean = new(this, "GetObjectIdentity", 0, typeof(System.MarshalByRefObject), typeof(System.Boolean).MakeByRefType());
					r_GetObjectIdentity_MarshalByRefObject_Out_Boolean.SetBelong(this.instance);
				}
				return r_GetObjectIdentity_MarshalByRefObject_Out_Boolean;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjRef CreateObjRef(System.Type)
		/// </summary>
		protected RMethod r_CreateObjRef_Type;
		public virtual RMethod RCreateObjRef_Type
		{
			get
			{
				if(r_CreateObjRef_Type == null)
				{
					r_CreateObjRef_Type = new(this, "CreateObjRef", 0, typeof(System.Type));
					r_CreateObjRef_Type.SetBelong(this.instance);
				}
				return r_CreateObjRef_Type;
			}
		}

		/// <summary>
		/// System.Object GetLifetimeService()
		/// </summary>
		protected RMethod r_GetLifetimeService;
		public virtual RMethod RGetLifetimeService
		{
			get
			{
				if(r_GetLifetimeService == null)
				{
					r_GetLifetimeService = new(this, "GetLifetimeService", 0);
					r_GetLifetimeService.SetBelong(this.instance);
				}
				return r_GetLifetimeService;
			}
		}

		/// <summary>
		/// System.Object InitializeLifetimeService()
		/// </summary>
		protected RMethod r_InitializeLifetimeService;
		public virtual RMethod RInitializeLifetimeService
		{
			get
			{
				if(r_InitializeLifetimeService == null)
				{
					r_InitializeLifetimeService = new(this, "InitializeLifetimeService", 0);
					r_InitializeLifetimeService.SetBelong(this.instance);
				}
				return r_InitializeLifetimeService;
			}
		}

		/// <summary>
		/// System.MarshalByRefObject MemberwiseClone(Boolean)
		/// </summary>
		protected RMethod r_MemberwiseClone_Boolean;
		public virtual RMethod RMemberwiseClone_Boolean
		{
			get
			{
				if(r_MemberwiseClone_Boolean == null)
				{
					r_MemberwiseClone_Boolean = new(this, "MemberwiseClone", 0, typeof(System.Boolean));
					r_MemberwiseClone_Boolean.SetBelong(this.instance);
				}
				return r_MemberwiseClone_Boolean;
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


        public RTimer() : base("System.Threading.Timer")
        {
        }

        public RTimer(System.Object instance) : base("System.Threading.Timer")
		{
            SetInstance(instance);
		}

        public RTimer(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTimer(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Init(System.Threading.TimerCallback  @callback, System.Object  @state, System.Int64  @dueTime, System.Int64  @period)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @state, @dueTime, @period};
            var ___result = RInit_TimerCallback_Object_Int64_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Change(System.Int32  @dueTime, System.Int32  @period)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dueTime, @period};
            var ___result = RChange_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Change(System.TimeSpan  @dueTime, System.TimeSpan  @period)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dueTime, @period};
            var ___result = RChange_TimeSpan_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Change(System.UInt32  @dueTime, System.UInt32  @period)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dueTime, @period};
            var ___result = RChange_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Change(System.Int64  @dueTime, System.Int64  @period)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dueTime, @period};
            var ___result = RChange_Int64_Int64.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Change(System.Int64  @dueTime, System.Int64  @period, System.Boolean  @first)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dueTime, @period, @first};
            var ___result = RChange_Int64_Int64_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Dispose(System.Threading.WaitHandle  @notifyObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@notifyObject};
            var ___result = RDispose_WaitHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Threading.Tasks.ValueTask DisposeAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDisposeAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask)___result;
        }


        public virtual void KeepRootedWhileScheduled()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RKeepRootedWhileScheduled.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int64 GetTimeMonotonic()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTimeMonotonic.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Object GetObjectIdentity(System.MarshalByRefObject  @obj, out System.Boolean  @IsClient)
        {
			@IsClient = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @IsClient};
            var ___result = RGetObjectIdentity_MarshalByRefObject_Out_Boolean.Invoke(___genericsType, ___parameters);
			@IsClient = (System.Boolean)___parameters[1];

            return (System.Object)___result;
        }


        public virtual System.Runtime.Remoting.ObjRef CreateObjRef(System.Type  @requestedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requestedType};
            var ___result = RCreateObjRef_Type.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjRef)___result;
        }


        public virtual System.Object GetLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object InitializeLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitializeLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.MarshalByRefObject MemberwiseClone(System.Boolean  @cloneIdentity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cloneIdentity};
            var ___result = RMemberwiseClone_Boolean.Invoke(___genericsType, ___parameters);

            return (System.MarshalByRefObject)___result;
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
