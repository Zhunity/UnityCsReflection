
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.InternalThread
	/// </summary>
    public partial class RInternalThread : RMember //
    {

		/// <summary>
		/// System.Int32 lock_thread_id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Flock_thread_id;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFlock_thread_id
		{
			get
			{
				if(r_Flock_thread_id == null)
				{
					r_Flock_thread_id = new(this, "lock_thread_id");
					r_Flock_thread_id.SetBelong(this.instance);
				}
				return r_Flock_thread_id;
			}
		}

		/// <summary>
		/// System.IntPtr handle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fhandle;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFhandle
		{
			get
			{
				if(r_Fhandle == null)
				{
					r_Fhandle = new(this, "handle");
					r_Fhandle.SetBelong(this.instance);
				}
				return r_Fhandle;
			}
		}

		/// <summary>
		/// System.IntPtr native_handle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fnative_handle;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFnative_handle
		{
			get
			{
				if(r_Fnative_handle == null)
				{
					r_Fnative_handle = new(this, "native_handle");
					r_Fnative_handle.SetBelong(this.instance);
				}
				return r_Fnative_handle;
			}
		}

		/// <summary>
		/// System.IntPtr name_chars
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fname_chars;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFname_chars
		{
			get
			{
				if(r_Fname_chars == null)
				{
					r_Fname_chars = new(this, "name_chars");
					r_Fname_chars.SetBelong(this.instance);
				}
				return r_Fname_chars;
			}
		}

		/// <summary>
		/// System.Int32 name_free
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fname_free;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFname_free
		{
			get
			{
				if(r_Fname_free == null)
				{
					r_Fname_free = new(this, "name_free");
					r_Fname_free.SetBelong(this.instance);
				}
				return r_Fname_free;
			}
		}

		/// <summary>
		/// System.Int32 name_length
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fname_length;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFname_length
		{
			get
			{
				if(r_Fname_length == null)
				{
					r_Fname_length = new(this, "name_length");
					r_Fname_length.SetBelong(this.instance);
				}
				return r_Fname_length;
			}
		}

		/// <summary>
		/// System.Threading.ThreadState state
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RThreadState r_Fstate;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RThreadState RFstate
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
		/// System.Object abort_exc
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_Fabort_exc;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RFabort_exc
		{
			get
			{
				if(r_Fabort_exc == null)
				{
					r_Fabort_exc = new(this, "abort_exc");
					r_Fabort_exc.SetBelong(this.instance);
				}
				return r_Fabort_exc;
			}
		}

		/// <summary>
		/// System.Int32 abort_state_handle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fabort_state_handle;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFabort_state_handle
		{
			get
			{
				if(r_Fabort_state_handle == null)
				{
					r_Fabort_state_handle = new(this, "abort_state_handle");
					r_Fabort_state_handle.SetBelong(this.instance);
				}
				return r_Fabort_state_handle;
			}
		}

		/// <summary>
		/// System.Int64 thread_id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Fthread_id;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFthread_id
		{
			get
			{
				if(r_Fthread_id == null)
				{
					r_Fthread_id = new(this, "thread_id");
					r_Fthread_id.SetBelong(this.instance);
				}
				return r_Fthread_id;
			}
		}

		/// <summary>
		/// System.IntPtr debugger_thread
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fdebugger_thread;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFdebugger_thread
		{
			get
			{
				if(r_Fdebugger_thread == null)
				{
					r_Fdebugger_thread = new(this, "debugger_thread");
					r_Fdebugger_thread.SetBelong(this.instance);
				}
				return r_Fdebugger_thread;
			}
		}

		/// <summary>
		/// System.UIntPtr static_data
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUIntPtr r_Fstatic_data;
		public virtual Hvak.Editor.Refleaction.RSystem.RUIntPtr RFstatic_data
		{
			get
			{
				if(r_Fstatic_data == null)
				{
					r_Fstatic_data = new(this, "static_data");
					r_Fstatic_data.SetBelong(this.instance);
				}
				return r_Fstatic_data;
			}
		}

		/// <summary>
		/// System.IntPtr runtime_thread_info
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fruntime_thread_info;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFruntime_thread_info
		{
			get
			{
				if(r_Fruntime_thread_info == null)
				{
					r_Fruntime_thread_info = new(this, "runtime_thread_info");
					r_Fruntime_thread_info.SetBelong(this.instance);
				}
				return r_Fruntime_thread_info;
			}
		}

		/// <summary>
		/// System.Object current_appcontext
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_Fcurrent_appcontext;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RFcurrent_appcontext
		{
			get
			{
				if(r_Fcurrent_appcontext == null)
				{
					r_Fcurrent_appcontext = new(this, "current_appcontext");
					r_Fcurrent_appcontext.SetBelong(this.instance);
				}
				return r_Fcurrent_appcontext;
			}
		}

		/// <summary>
		/// System.Object root_domain_thread
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_Froot_domain_thread;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RFroot_domain_thread
		{
			get
			{
				if(r_Froot_domain_thread == null)
				{
					r_Froot_domain_thread = new(this, "root_domain_thread");
					r_Froot_domain_thread.SetBelong(this.instance);
				}
				return r_Froot_domain_thread;
			}
		}

		/// <summary>
		/// System.Byte[] _serialized_principal
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_F_serialized_principal;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RF_serialized_principal
		{
			get
			{
				if(r_F_serialized_principal == null)
				{
					r_F_serialized_principal = new(this, "_serialized_principal");
					r_F_serialized_principal.SetBelong(this.instance);
				}
				return r_F_serialized_principal;
			}
		}

		/// <summary>
		/// System.Int32 _serialized_principal_version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_serialized_principal_version;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_serialized_principal_version
		{
			get
			{
				if(r_F_serialized_principal_version == null)
				{
					r_F_serialized_principal_version = new(this, "_serialized_principal_version");
					r_F_serialized_principal_version.SetBelong(this.instance);
				}
				return r_F_serialized_principal_version;
			}
		}

		/// <summary>
		/// System.IntPtr appdomain_refs
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fappdomain_refs;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFappdomain_refs
		{
			get
			{
				if(r_Fappdomain_refs == null)
				{
					r_Fappdomain_refs = new(this, "appdomain_refs");
					r_Fappdomain_refs.SetBelong(this.instance);
				}
				return r_Fappdomain_refs;
			}
		}

		/// <summary>
		/// System.Int32 interruption_requested
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Finterruption_requested;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFinterruption_requested
		{
			get
			{
				if(r_Finterruption_requested == null)
				{
					r_Finterruption_requested = new(this, "interruption_requested");
					r_Finterruption_requested.SetBelong(this.instance);
				}
				return r_Finterruption_requested;
			}
		}

		/// <summary>
		/// System.IntPtr longlived
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Flonglived;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFlonglived
		{
			get
			{
				if(r_Flonglived == null)
				{
					r_Flonglived = new(this, "longlived");
					r_Flonglived.SetBelong(this.instance);
				}
				return r_Flonglived;
			}
		}

		/// <summary>
		/// System.Boolean threadpool_thread
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fthreadpool_thread;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFthreadpool_thread
		{
			get
			{
				if(r_Fthreadpool_thread == null)
				{
					r_Fthreadpool_thread = new(this, "threadpool_thread");
					r_Fthreadpool_thread.SetBelong(this.instance);
				}
				return r_Fthreadpool_thread;
			}
		}

		/// <summary>
		/// System.Boolean thread_interrupt_requested
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fthread_interrupt_requested;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFthread_interrupt_requested
		{
			get
			{
				if(r_Fthread_interrupt_requested == null)
				{
					r_Fthread_interrupt_requested = new(this, "thread_interrupt_requested");
					r_Fthread_interrupt_requested.SetBelong(this.instance);
				}
				return r_Fthread_interrupt_requested;
			}
		}

		/// <summary>
		/// System.Int32 stack_size
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fstack_size;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFstack_size
		{
			get
			{
				if(r_Fstack_size == null)
				{
					r_Fstack_size = new(this, "stack_size");
					r_Fstack_size.SetBelong(this.instance);
				}
				return r_Fstack_size;
			}
		}

		/// <summary>
		/// System.Byte apartment_state
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_Fapartment_state;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RFapartment_state
		{
			get
			{
				if(r_Fapartment_state == null)
				{
					r_Fapartment_state = new(this, "apartment_state");
					r_Fapartment_state.SetBelong(this.instance);
				}
				return r_Fapartment_state;
			}
		}

		/// <summary>
		/// System.Int32 critical_region_level
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fcritical_region_level;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcritical_region_level
		{
			get
			{
				if(r_Fcritical_region_level == null)
				{
					r_Fcritical_region_level = new(this, "critical_region_level");
					r_Fcritical_region_level.SetBelong(this.instance);
				}
				return r_Fcritical_region_level;
			}
		}

		/// <summary>
		/// System.Int32 managed_id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fmanaged_id;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFmanaged_id
		{
			get
			{
				if(r_Fmanaged_id == null)
				{
					r_Fmanaged_id = new(this, "managed_id");
					r_Fmanaged_id.SetBelong(this.instance);
				}
				return r_Fmanaged_id;
			}
		}

		/// <summary>
		/// System.Int32 small_id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fsmall_id;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFsmall_id
		{
			get
			{
				if(r_Fsmall_id == null)
				{
					r_Fsmall_id = new(this, "small_id");
					r_Fsmall_id.SetBelong(this.instance);
				}
				return r_Fsmall_id;
			}
		}

		/// <summary>
		/// System.IntPtr manage_callback
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fmanage_callback;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFmanage_callback
		{
			get
			{
				if(r_Fmanage_callback == null)
				{
					r_Fmanage_callback = new(this, "manage_callback");
					r_Fmanage_callback.SetBelong(this.instance);
				}
				return r_Fmanage_callback;
			}
		}

		/// <summary>
		/// System.IntPtr flags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fflags;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFflags
		{
			get
			{
				if(r_Fflags == null)
				{
					r_Fflags = new(this, "flags");
					r_Fflags.SetBelong(this.instance);
				}
				return r_Fflags;
			}
		}

		/// <summary>
		/// System.IntPtr thread_pinning_ref
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fthread_pinning_ref;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFthread_pinning_ref
		{
			get
			{
				if(r_Fthread_pinning_ref == null)
				{
					r_Fthread_pinning_ref = new(this, "thread_pinning_ref");
					r_Fthread_pinning_ref.SetBelong(this.instance);
				}
				return r_Fthread_pinning_ref;
			}
		}

		/// <summary>
		/// System.IntPtr abort_protected_block_count
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fabort_protected_block_count;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFabort_protected_block_count
		{
			get
			{
				if(r_Fabort_protected_block_count == null)
				{
					r_Fabort_protected_block_count = new(this, "abort_protected_block_count");
					r_Fabort_protected_block_count.SetBelong(this.instance);
				}
				return r_Fabort_protected_block_count;
			}
		}

		/// <summary>
		/// System.Int32 priority
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fpriority;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFpriority
		{
			get
			{
				if(r_Fpriority == null)
				{
					r_Fpriority = new(this, "priority");
					r_Fpriority.SetBelong(this.instance);
				}
				return r_Fpriority;
			}
		}

		/// <summary>
		/// System.IntPtr owned_mutex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fowned_mutex;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFowned_mutex
		{
			get
			{
				if(r_Fowned_mutex == null)
				{
					r_Fowned_mutex = new(this, "owned_mutex");
					r_Fowned_mutex.SetBelong(this.instance);
				}
				return r_Fowned_mutex;
			}
		}

		/// <summary>
		/// System.IntPtr suspended_event
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fsuspended_event;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFsuspended_event
		{
			get
			{
				if(r_Fsuspended_event == null)
				{
					r_Fsuspended_event = new(this, "suspended_event");
					r_Fsuspended_event.SetBelong(this.instance);
				}
				return r_Fsuspended_event;
			}
		}

		/// <summary>
		/// System.Int32 self_suspended
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fself_suspended;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFself_suspended
		{
			get
			{
				if(r_Fself_suspended == null)
				{
					r_Fself_suspended = new(this, "self_suspended");
					r_Fself_suspended.SetBelong(this.instance);
				}
				return r_Fself_suspended;
			}
		}

		/// <summary>
		/// System.IntPtr thread_state
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fthread_state;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFthread_state
		{
			get
			{
				if(r_Fthread_state == null)
				{
					r_Fthread_state = new(this, "thread_state");
					r_Fthread_state.SetBelong(this.instance);
				}
				return r_Fthread_state;
			}
		}

		/// <summary>
		/// System.IntPtr netcore0
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fnetcore0;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFnetcore0
		{
			get
			{
				if(r_Fnetcore0 == null)
				{
					r_Fnetcore0 = new(this, "netcore0");
					r_Fnetcore0.SetBelong(this.instance);
				}
				return r_Fnetcore0;
			}
		}

		/// <summary>
		/// System.IntPtr netcore1
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fnetcore1;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFnetcore1
		{
			get
			{
				if(r_Fnetcore1 == null)
				{
					r_Fnetcore1 = new(this, "netcore1");
					r_Fnetcore1.SetBelong(this.instance);
				}
				return r_Fnetcore1;
			}
		}

		/// <summary>
		/// System.IntPtr netcore2
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fnetcore2;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFnetcore2
		{
			get
			{
				if(r_Fnetcore2 == null)
				{
					r_Fnetcore2 = new(this, "netcore2");
					r_Fnetcore2.SetBelong(this.instance);
				}
				return r_Fnetcore2;
			}
		}

		/// <summary>
		/// System.IntPtr last
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Flast;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFlast
		{
			get
			{
				if(r_Flast == null)
				{
					r_Flast = new(this, "last");
					r_Flast.SetBelong(this.instance);
				}
				return r_Flast;
			}
		}

		/// <summary>
		/// Void Thread_free_internal()
		/// </summary>
		protected RMethod r_MThread_free_internal;
		public virtual RMethod RMThread_free_internal
		{
			get
			{
				if(r_MThread_free_internal == null)
				{
					r_MThread_free_internal = new(this, "Thread_free_internal", 0);
					r_MThread_free_internal.SetBelong(this.instance);
				}
				return r_MThread_free_internal;
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


        public RInternalThread() : base("System.Threading.InternalThread")
        {
        }

        public RInternalThread(System.Object instance) : base("System.Threading.InternalThread")
		{
            SetInstance(instance);
		}

        public RInternalThread(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RInternalThread(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Thread_free_internal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMThread_free_internal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
