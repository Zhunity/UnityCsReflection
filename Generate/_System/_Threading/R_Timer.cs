
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
		protected SMFrame.Editor.Refleaction.RSystem.RThreading.RTimerCallback r_Fcallback;
		public virtual SMFrame.Editor.Refleaction.RSystem.RThreading.RTimerCallback RFcallback
		{
			get
			{
				if(r_Fcallback == null)
				{
					r_Fcallback = new(this, "callback");
					r_Fcallback.SetBelong(this.instance);
				}
				return r_Fcallback;
			}
		}

		/// <summary>
		/// System.Object state
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RObject r_Fstate;
		public virtual SMFrame.Editor.Refleaction.RSystem.RObject RFstate
		{
			get
			{
				if(r_Fstate == null)
				{
					r_Fstate = new(this, "state");
					r_Fstate.SetBelong(this.instance);
				}
				return r_Fstate;
			}
		}

		/// <summary>
		/// System.Int64 due_time_ms
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt64 r_Fdue_time_ms;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt64 RFdue_time_ms
		{
			get
			{
				if(r_Fdue_time_ms == null)
				{
					r_Fdue_time_ms = new(this, "due_time_ms");
					r_Fdue_time_ms.SetBelong(this.instance);
				}
				return r_Fdue_time_ms;
			}
		}

		/// <summary>
		/// System.Int64 period_ms
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt64 r_Fperiod_ms;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt64 RFperiod_ms
		{
			get
			{
				if(r_Fperiod_ms == null)
				{
					r_Fperiod_ms = new(this, "period_ms");
					r_Fperiod_ms.SetBelong(this.instance);
				}
				return r_Fperiod_ms;
			}
		}

		/// <summary>
		/// System.Int64 next_run
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt64 r_Fnext_run;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt64 RFnext_run
		{
			get
			{
				if(r_Fnext_run == null)
				{
					r_Fnext_run = new(this, "next_run");
					r_Fnext_run.SetBelong(this.instance);
				}
				return r_Fnext_run;
			}
		}

		/// <summary>
		/// System.Boolean disposed
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fdisposed;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFdisposed
		{
			get
			{
				if(r_Fdisposed == null)
				{
					r_Fdisposed = new(this, "disposed");
					r_Fdisposed.SetBelong(this.instance);
				}
				return r_Fdisposed;
			}
		}

		/// <summary>
		/// System.Boolean is_dead
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fis_dead;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFis_dead
		{
			get
			{
				if(r_Fis_dead == null)
				{
					r_Fis_dead = new(this, "is_dead");
					r_Fis_dead.SetBelong(this.instance);
				}
				return r_Fis_dead;
			}
		}

		/// <summary>
		/// System.Boolean is_added
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fis_added;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFis_added
		{
			get
			{
				if(r_Fis_added == null)
				{
					r_Fis_added = new(this, "is_added");
					r_Fis_added.SetBelong(this.instance);
				}
				return r_Fis_added;
			}
		}

		/// <summary>
		/// System.Int64 MaxValue
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RInt64 r_FMaxValue;
		public static SMFrame.Editor.Refleaction.RSystem.RInt64 RFMaxValue
		{
			get
			{
				if(r_FMaxValue == null)
				{
					r_FMaxValue = new(typeof(System.Threading.Timer), "MaxValue");
					r_FMaxValue.SetBelong(null);
				}
				return r_FMaxValue;
			}
		}

		/// <summary>
		/// Scheduler scheduler
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RTimer.RScheduler r_Pscheduler;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RTimer.RScheduler RPscheduler
		{
			get
			{
				if(r_Pscheduler == null)
				{
					r_Pscheduler = new(typeof(System.Threading.Timer), "scheduler", -1);
					r_Pscheduler.SetBelong(null);
				}
				return r_Pscheduler;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ServerIdentity ObjectIdentity
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RServerIdentity r_PObjectIdentity;
		public virtual SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RServerIdentity RPObjectIdentity
		{
			get
			{
				if(r_PObjectIdentity == null)
				{
					r_PObjectIdentity = new(this, "ObjectIdentity", -1);
					r_PObjectIdentity.SetBelong(this.instance);
				}
				return r_PObjectIdentity;
			}
		}

		/// <summary>
		/// Void Init(System.Threading.TimerCallback, System.Object, Int64, Int64)
		/// </summary>
		protected RMethod r_MInit_TimerCallback_Object_Int64_Int64;
		public virtual RMethod RMInit_TimerCallback_Object_Int64_Int64
		{
			get
			{
				if(r_MInit_TimerCallback_Object_Int64_Int64 == null)
				{
					r_MInit_TimerCallback_Object_Int64_Int64 = new(this, "Init", 0, typeof(System.Threading.TimerCallback), typeof(System.Object), typeof(System.Int64), typeof(System.Int64));
					r_MInit_TimerCallback_Object_Int64_Int64.SetBelong(this.instance);
				}
				return r_MInit_TimerCallback_Object_Int64_Int64;
			}
		}

		/// <summary>
		/// Boolean Change(Int32, Int32)
		/// </summary>
		protected RMethod r_MChange_Int32_Int32;
		public virtual RMethod RMChange_Int32_Int32
		{
			get
			{
				if(r_MChange_Int32_Int32 == null)
				{
					r_MChange_Int32_Int32 = new(this, "Change", 0, typeof(System.Int32), typeof(System.Int32));
					r_MChange_Int32_Int32.SetBelong(this.instance);
				}
				return r_MChange_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean Change(System.TimeSpan, System.TimeSpan)
		/// </summary>
		protected RMethod r_MChange_TimeSpan_TimeSpan;
		public virtual RMethod RMChange_TimeSpan_TimeSpan
		{
			get
			{
				if(r_MChange_TimeSpan_TimeSpan == null)
				{
					r_MChange_TimeSpan_TimeSpan = new(this, "Change", 0, typeof(System.TimeSpan), typeof(System.TimeSpan));
					r_MChange_TimeSpan_TimeSpan.SetBelong(this.instance);
				}
				return r_MChange_TimeSpan_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean Change(UInt32, UInt32)
		/// </summary>
		protected RMethod r_MChange_UInt32_UInt32;
		public virtual RMethod RMChange_UInt32_UInt32
		{
			get
			{
				if(r_MChange_UInt32_UInt32 == null)
				{
					r_MChange_UInt32_UInt32 = new(this, "Change", 0, typeof(System.UInt32), typeof(System.UInt32));
					r_MChange_UInt32_UInt32.SetBelong(this.instance);
				}
				return r_MChange_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
					r_MDispose.SetBelong(this.instance);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Boolean Change(Int64, Int64)
		/// </summary>
		protected RMethod r_MChange_Int64_Int64;
		public virtual RMethod RMChange_Int64_Int64
		{
			get
			{
				if(r_MChange_Int64_Int64 == null)
				{
					r_MChange_Int64_Int64 = new(this, "Change", 0, typeof(System.Int64), typeof(System.Int64));
					r_MChange_Int64_Int64.SetBelong(this.instance);
				}
				return r_MChange_Int64_Int64;
			}
		}

		/// <summary>
		/// Boolean Change(Int64, Int64, Boolean)
		/// </summary>
		protected RMethod r_MChange_Int64_Int64_Boolean;
		public virtual RMethod RMChange_Int64_Int64_Boolean
		{
			get
			{
				if(r_MChange_Int64_Int64_Boolean == null)
				{
					r_MChange_Int64_Int64_Boolean = new(this, "Change", 0, typeof(System.Int64), typeof(System.Int64), typeof(System.Boolean));
					r_MChange_Int64_Int64_Boolean.SetBelong(this.instance);
				}
				return r_MChange_Int64_Int64_Boolean;
			}
		}

		/// <summary>
		/// Boolean Dispose(System.Threading.WaitHandle)
		/// </summary>
		protected RMethod r_MDispose_WaitHandle;
		public virtual RMethod RMDispose_WaitHandle
		{
			get
			{
				if(r_MDispose_WaitHandle == null)
				{
					r_MDispose_WaitHandle = new(this, "Dispose", 0, typeof(System.Threading.WaitHandle));
					r_MDispose_WaitHandle.SetBelong(this.instance);
				}
				return r_MDispose_WaitHandle;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask DisposeAsync()
		/// </summary>
		protected RMethod r_MDisposeAsync;
		public virtual RMethod RMDisposeAsync
		{
			get
			{
				if(r_MDisposeAsync == null)
				{
					r_MDisposeAsync = new(this, "DisposeAsync", 0);
					r_MDisposeAsync.SetBelong(this.instance);
				}
				return r_MDisposeAsync;
			}
		}

		/// <summary>
		/// Void KeepRootedWhileScheduled()
		/// </summary>
		protected RMethod r_MKeepRootedWhileScheduled;
		public virtual RMethod RMKeepRootedWhileScheduled
		{
			get
			{
				if(r_MKeepRootedWhileScheduled == null)
				{
					r_MKeepRootedWhileScheduled = new(this, "KeepRootedWhileScheduled", 0);
					r_MKeepRootedWhileScheduled.SetBelong(this.instance);
				}
				return r_MKeepRootedWhileScheduled;
			}
		}

		/// <summary>
		/// Int64 GetTimeMonotonic()
		/// </summary>
		protected static RMethod r_MGetTimeMonotonic;
		public static RMethod RMGetTimeMonotonic
		{
			get
			{
				if(r_MGetTimeMonotonic == null)
				{
					r_MGetTimeMonotonic = new(typeof(System.Threading.Timer), "GetTimeMonotonic", 0);
					r_MGetTimeMonotonic.SetBelong(null);
				}
				return r_MGetTimeMonotonic;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Identity GetObjectIdentity(System.MarshalByRefObject, Boolean ByRef)
		/// </summary>
		protected RMethod r_MGetObjectIdentity_MarshalByRefObject_Out_Boolean;
		public virtual RMethod RMGetObjectIdentity_MarshalByRefObject_Out_Boolean
		{
			get
			{
				if(r_MGetObjectIdentity_MarshalByRefObject_Out_Boolean == null)
				{
					r_MGetObjectIdentity_MarshalByRefObject_Out_Boolean = new(this, "GetObjectIdentity", 0, typeof(System.MarshalByRefObject), typeof(System.Boolean).MakeByRefType());
					r_MGetObjectIdentity_MarshalByRefObject_Out_Boolean.SetBelong(this.instance);
				}
				return r_MGetObjectIdentity_MarshalByRefObject_Out_Boolean;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjRef CreateObjRef(System.Type)
		/// </summary>
		protected RMethod r_MCreateObjRef_Type;
		public virtual RMethod RMCreateObjRef_Type
		{
			get
			{
				if(r_MCreateObjRef_Type == null)
				{
					r_MCreateObjRef_Type = new(this, "CreateObjRef", 0, typeof(System.Type));
					r_MCreateObjRef_Type.SetBelong(this.instance);
				}
				return r_MCreateObjRef_Type;
			}
		}

		/// <summary>
		/// System.Object GetLifetimeService()
		/// </summary>
		protected RMethod r_MGetLifetimeService;
		public virtual RMethod RMGetLifetimeService
		{
			get
			{
				if(r_MGetLifetimeService == null)
				{
					r_MGetLifetimeService = new(this, "GetLifetimeService", 0);
					r_MGetLifetimeService.SetBelong(this.instance);
				}
				return r_MGetLifetimeService;
			}
		}

		/// <summary>
		/// System.Object InitializeLifetimeService()
		/// </summary>
		protected RMethod r_MInitializeLifetimeService;
		public virtual RMethod RMInitializeLifetimeService
		{
			get
			{
				if(r_MInitializeLifetimeService == null)
				{
					r_MInitializeLifetimeService = new(this, "InitializeLifetimeService", 0);
					r_MInitializeLifetimeService.SetBelong(this.instance);
				}
				return r_MInitializeLifetimeService;
			}
		}

		/// <summary>
		/// System.MarshalByRefObject MemberwiseClone(Boolean)
		/// </summary>
		protected RMethod r_MMemberwiseClone_Boolean;
		public virtual RMethod RMMemberwiseClone_Boolean
		{
			get
			{
				if(r_MMemberwiseClone_Boolean == null)
				{
					r_MMemberwiseClone_Boolean = new(this, "MemberwiseClone", 0, typeof(System.Boolean));
					r_MMemberwiseClone_Boolean.SetBelong(this.instance);
				}
				return r_MMemberwiseClone_Boolean;
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

        public virtual void Init(System.Threading.TimerCallback @callback, System.Object @state, System.Int64 @dueTime, System.Int64 @period)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @state, @dueTime, @period};
            var ___result = RMInit_TimerCallback_Object_Int64_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Change(System.Int32 @dueTime, System.Int32 @period)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dueTime, @period};
            var ___result = RMChange_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Change(System.TimeSpan @dueTime, System.TimeSpan @period)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dueTime, @period};
            var ___result = RMChange_TimeSpan_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Change(System.UInt32 @dueTime, System.UInt32 @period)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dueTime, @period};
            var ___result = RMChange_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Change(System.Int64 @dueTime, System.Int64 @period)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dueTime, @period};
            var ___result = RMChange_Int64_Int64.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Change(System.Int64 @dueTime, System.Int64 @period, System.Boolean @first)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dueTime, @period, @first};
            var ___result = RMChange_Int64_Int64_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Dispose(System.Threading.WaitHandle @notifyObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@notifyObject};
            var ___result = RMDispose_WaitHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Threading.Tasks.ValueTask DisposeAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDisposeAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask)___result;
        }


        public virtual void KeepRootedWhileScheduled()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMKeepRootedWhileScheduled.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int64 GetTimeMonotonic()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTimeMonotonic.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RIdentity GetObjectIdentity(System.MarshalByRefObject @obj, out System.Boolean @IsClient)
        {
			@IsClient = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @IsClient};
            var ___result = RMGetObjectIdentity_MarshalByRefObject_Out_Boolean.Invoke(___genericsType, ___parameters);
			@IsClient = (System.Boolean)___parameters[1];

            return new SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RIdentity(___result);
        }


        public virtual System.Runtime.Remoting.ObjRef CreateObjRef(System.Type @requestedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requestedType};
            var ___result = RMCreateObjRef_Type.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjRef)___result;
        }


        public virtual System.Object GetLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object InitializeLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitializeLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.MarshalByRefObject MemberwiseClone(System.Boolean @cloneIdentity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cloneIdentity};
            var ___result = RMMemberwiseClone_Boolean.Invoke(___genericsType, ___parameters);

            return (System.MarshalByRefObject)___result;
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
