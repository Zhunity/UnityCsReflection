using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.InternalThread
	/// </summary>
    public partial class RInternalThread : RMember //
    {

		/// <summary>
		/// System.Int32 lock_thread_id
		/// </summary>
		protected RField r_lock_thread_id;
		public virtual RField Rlock_thread_id
		{
			get
			{
				if(r_lock_thread_id == null)
				{
					r_lock_thread_id = new(this, "lock_thread_id");
					r_lock_thread_id.SetBelong(this.instance);
				}
				return r_lock_thread_id;
			}
		}

		/// <summary>
		/// System.IntPtr handle
		/// </summary>
		protected RField r_handle;
		public virtual RField Rhandle
		{
			get
			{
				if(r_handle == null)
				{
					r_handle = new(this, "handle");
					r_handle.SetBelong(this.instance);
				}
				return r_handle;
			}
		}

		/// <summary>
		/// System.IntPtr native_handle
		/// </summary>
		protected RField r_native_handle;
		public virtual RField Rnative_handle
		{
			get
			{
				if(r_native_handle == null)
				{
					r_native_handle = new(this, "native_handle");
					r_native_handle.SetBelong(this.instance);
				}
				return r_native_handle;
			}
		}

		/// <summary>
		/// System.IntPtr name_chars
		/// </summary>
		protected RField r_name_chars;
		public virtual RField Rname_chars
		{
			get
			{
				if(r_name_chars == null)
				{
					r_name_chars = new(this, "name_chars");
					r_name_chars.SetBelong(this.instance);
				}
				return r_name_chars;
			}
		}

		/// <summary>
		/// System.Int32 name_free
		/// </summary>
		protected RField r_name_free;
		public virtual RField Rname_free
		{
			get
			{
				if(r_name_free == null)
				{
					r_name_free = new(this, "name_free");
					r_name_free.SetBelong(this.instance);
				}
				return r_name_free;
			}
		}

		/// <summary>
		/// System.Int32 name_length
		/// </summary>
		protected RField r_name_length;
		public virtual RField Rname_length
		{
			get
			{
				if(r_name_length == null)
				{
					r_name_length = new(this, "name_length");
					r_name_length.SetBelong(this.instance);
				}
				return r_name_length;
			}
		}

		/// <summary>
		/// System.Threading.ThreadState state
		/// </summary>
		protected RField r_state;
		public virtual RField Rstate
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
		/// System.Object abort_exc
		/// </summary>
		protected RSystem.RObject r_abort_exc;
		public virtual RSystem.RObject Rabort_exc
		{
			get
			{
				if(r_abort_exc == null)
				{
					r_abort_exc = new(this, "abort_exc");
					r_abort_exc.SetBelong(this.instance);
				}
				return r_abort_exc;
			}
		}

		/// <summary>
		/// System.Int32 abort_state_handle
		/// </summary>
		protected RField r_abort_state_handle;
		public virtual RField Rabort_state_handle
		{
			get
			{
				if(r_abort_state_handle == null)
				{
					r_abort_state_handle = new(this, "abort_state_handle");
					r_abort_state_handle.SetBelong(this.instance);
				}
				return r_abort_state_handle;
			}
		}

		/// <summary>
		/// System.Int64 thread_id
		/// </summary>
		protected RField r_thread_id;
		public virtual RField Rthread_id
		{
			get
			{
				if(r_thread_id == null)
				{
					r_thread_id = new(this, "thread_id");
					r_thread_id.SetBelong(this.instance);
				}
				return r_thread_id;
			}
		}

		/// <summary>
		/// System.IntPtr debugger_thread
		/// </summary>
		protected RField r_debugger_thread;
		public virtual RField Rdebugger_thread
		{
			get
			{
				if(r_debugger_thread == null)
				{
					r_debugger_thread = new(this, "debugger_thread");
					r_debugger_thread.SetBelong(this.instance);
				}
				return r_debugger_thread;
			}
		}

		/// <summary>
		/// System.UIntPtr static_data
		/// </summary>
		protected RField r_static_data;
		public virtual RField Rstatic_data
		{
			get
			{
				if(r_static_data == null)
				{
					r_static_data = new(this, "static_data");
					r_static_data.SetBelong(this.instance);
				}
				return r_static_data;
			}
		}

		/// <summary>
		/// System.IntPtr runtime_thread_info
		/// </summary>
		protected RField r_runtime_thread_info;
		public virtual RField Rruntime_thread_info
		{
			get
			{
				if(r_runtime_thread_info == null)
				{
					r_runtime_thread_info = new(this, "runtime_thread_info");
					r_runtime_thread_info.SetBelong(this.instance);
				}
				return r_runtime_thread_info;
			}
		}

		/// <summary>
		/// System.Object current_appcontext
		/// </summary>
		protected RSystem.RObject r_current_appcontext;
		public virtual RSystem.RObject Rcurrent_appcontext
		{
			get
			{
				if(r_current_appcontext == null)
				{
					r_current_appcontext = new(this, "current_appcontext");
					r_current_appcontext.SetBelong(this.instance);
				}
				return r_current_appcontext;
			}
		}

		/// <summary>
		/// System.Object root_domain_thread
		/// </summary>
		protected RSystem.RObject r_root_domain_thread;
		public virtual RSystem.RObject Rroot_domain_thread
		{
			get
			{
				if(r_root_domain_thread == null)
				{
					r_root_domain_thread = new(this, "root_domain_thread");
					r_root_domain_thread.SetBelong(this.instance);
				}
				return r_root_domain_thread;
			}
		}

		/// <summary>
		/// System.Byte[] _serialized_principal
		/// </summary>
		protected RFieldArray<RField> r__serialized_principal;
		public virtual RFieldArray<RField> R_serialized_principal
		{
			get
			{
				if(r__serialized_principal == null)
				{
					r__serialized_principal = new(this, "_serialized_principal");
					r__serialized_principal.SetBelong(this.instance);
				}
				return r__serialized_principal;
			}
		}

		/// <summary>
		/// System.Int32 _serialized_principal_version
		/// </summary>
		protected RField r__serialized_principal_version;
		public virtual RField R_serialized_principal_version
		{
			get
			{
				if(r__serialized_principal_version == null)
				{
					r__serialized_principal_version = new(this, "_serialized_principal_version");
					r__serialized_principal_version.SetBelong(this.instance);
				}
				return r__serialized_principal_version;
			}
		}

		/// <summary>
		/// System.IntPtr appdomain_refs
		/// </summary>
		protected RField r_appdomain_refs;
		public virtual RField Rappdomain_refs
		{
			get
			{
				if(r_appdomain_refs == null)
				{
					r_appdomain_refs = new(this, "appdomain_refs");
					r_appdomain_refs.SetBelong(this.instance);
				}
				return r_appdomain_refs;
			}
		}

		/// <summary>
		/// System.Int32 interruption_requested
		/// </summary>
		protected RField r_interruption_requested;
		public virtual RField Rinterruption_requested
		{
			get
			{
				if(r_interruption_requested == null)
				{
					r_interruption_requested = new(this, "interruption_requested");
					r_interruption_requested.SetBelong(this.instance);
				}
				return r_interruption_requested;
			}
		}

		/// <summary>
		/// System.IntPtr longlived
		/// </summary>
		protected RField r_longlived;
		public virtual RField Rlonglived
		{
			get
			{
				if(r_longlived == null)
				{
					r_longlived = new(this, "longlived");
					r_longlived.SetBelong(this.instance);
				}
				return r_longlived;
			}
		}

		/// <summary>
		/// System.Boolean threadpool_thread
		/// </summary>
		protected RField r_threadpool_thread;
		public virtual RField Rthreadpool_thread
		{
			get
			{
				if(r_threadpool_thread == null)
				{
					r_threadpool_thread = new(this, "threadpool_thread");
					r_threadpool_thread.SetBelong(this.instance);
				}
				return r_threadpool_thread;
			}
		}

		/// <summary>
		/// System.Boolean thread_interrupt_requested
		/// </summary>
		protected RField r_thread_interrupt_requested;
		public virtual RField Rthread_interrupt_requested
		{
			get
			{
				if(r_thread_interrupt_requested == null)
				{
					r_thread_interrupt_requested = new(this, "thread_interrupt_requested");
					r_thread_interrupt_requested.SetBelong(this.instance);
				}
				return r_thread_interrupt_requested;
			}
		}

		/// <summary>
		/// System.Int32 stack_size
		/// </summary>
		protected RField r_stack_size;
		public virtual RField Rstack_size
		{
			get
			{
				if(r_stack_size == null)
				{
					r_stack_size = new(this, "stack_size");
					r_stack_size.SetBelong(this.instance);
				}
				return r_stack_size;
			}
		}

		/// <summary>
		/// System.Byte apartment_state
		/// </summary>
		protected RField r_apartment_state;
		public virtual RField Rapartment_state
		{
			get
			{
				if(r_apartment_state == null)
				{
					r_apartment_state = new(this, "apartment_state");
					r_apartment_state.SetBelong(this.instance);
				}
				return r_apartment_state;
			}
		}

		/// <summary>
		/// System.Int32 critical_region_level
		/// </summary>
		protected RField r_critical_region_level;
		public virtual RField Rcritical_region_level
		{
			get
			{
				if(r_critical_region_level == null)
				{
					r_critical_region_level = new(this, "critical_region_level");
					r_critical_region_level.SetBelong(this.instance);
				}
				return r_critical_region_level;
			}
		}

		/// <summary>
		/// System.Int32 managed_id
		/// </summary>
		protected RField r_managed_id;
		public virtual RField Rmanaged_id
		{
			get
			{
				if(r_managed_id == null)
				{
					r_managed_id = new(this, "managed_id");
					r_managed_id.SetBelong(this.instance);
				}
				return r_managed_id;
			}
		}

		/// <summary>
		/// System.Int32 small_id
		/// </summary>
		protected RField r_small_id;
		public virtual RField Rsmall_id
		{
			get
			{
				if(r_small_id == null)
				{
					r_small_id = new(this, "small_id");
					r_small_id.SetBelong(this.instance);
				}
				return r_small_id;
			}
		}

		/// <summary>
		/// System.IntPtr manage_callback
		/// </summary>
		protected RField r_manage_callback;
		public virtual RField Rmanage_callback
		{
			get
			{
				if(r_manage_callback == null)
				{
					r_manage_callback = new(this, "manage_callback");
					r_manage_callback.SetBelong(this.instance);
				}
				return r_manage_callback;
			}
		}

		/// <summary>
		/// System.IntPtr flags
		/// </summary>
		protected RField r_flags;
		public virtual RField Rflags
		{
			get
			{
				if(r_flags == null)
				{
					r_flags = new(this, "flags");
					r_flags.SetBelong(this.instance);
				}
				return r_flags;
			}
		}

		/// <summary>
		/// System.IntPtr thread_pinning_ref
		/// </summary>
		protected RField r_thread_pinning_ref;
		public virtual RField Rthread_pinning_ref
		{
			get
			{
				if(r_thread_pinning_ref == null)
				{
					r_thread_pinning_ref = new(this, "thread_pinning_ref");
					r_thread_pinning_ref.SetBelong(this.instance);
				}
				return r_thread_pinning_ref;
			}
		}

		/// <summary>
		/// System.IntPtr abort_protected_block_count
		/// </summary>
		protected RField r_abort_protected_block_count;
		public virtual RField Rabort_protected_block_count
		{
			get
			{
				if(r_abort_protected_block_count == null)
				{
					r_abort_protected_block_count = new(this, "abort_protected_block_count");
					r_abort_protected_block_count.SetBelong(this.instance);
				}
				return r_abort_protected_block_count;
			}
		}

		/// <summary>
		/// System.Int32 priority
		/// </summary>
		protected RField r_priority;
		public virtual RField Rpriority
		{
			get
			{
				if(r_priority == null)
				{
					r_priority = new(this, "priority");
					r_priority.SetBelong(this.instance);
				}
				return r_priority;
			}
		}

		/// <summary>
		/// System.IntPtr owned_mutex
		/// </summary>
		protected RField r_owned_mutex;
		public virtual RField Rowned_mutex
		{
			get
			{
				if(r_owned_mutex == null)
				{
					r_owned_mutex = new(this, "owned_mutex");
					r_owned_mutex.SetBelong(this.instance);
				}
				return r_owned_mutex;
			}
		}

		/// <summary>
		/// System.IntPtr suspended_event
		/// </summary>
		protected RField r_suspended_event;
		public virtual RField Rsuspended_event
		{
			get
			{
				if(r_suspended_event == null)
				{
					r_suspended_event = new(this, "suspended_event");
					r_suspended_event.SetBelong(this.instance);
				}
				return r_suspended_event;
			}
		}

		/// <summary>
		/// System.Int32 self_suspended
		/// </summary>
		protected RField r_self_suspended;
		public virtual RField Rself_suspended
		{
			get
			{
				if(r_self_suspended == null)
				{
					r_self_suspended = new(this, "self_suspended");
					r_self_suspended.SetBelong(this.instance);
				}
				return r_self_suspended;
			}
		}

		/// <summary>
		/// System.IntPtr thread_state
		/// </summary>
		protected RField r_thread_state;
		public virtual RField Rthread_state
		{
			get
			{
				if(r_thread_state == null)
				{
					r_thread_state = new(this, "thread_state");
					r_thread_state.SetBelong(this.instance);
				}
				return r_thread_state;
			}
		}

		/// <summary>
		/// System.IntPtr netcore0
		/// </summary>
		protected RField r_netcore0;
		public virtual RField Rnetcore0
		{
			get
			{
				if(r_netcore0 == null)
				{
					r_netcore0 = new(this, "netcore0");
					r_netcore0.SetBelong(this.instance);
				}
				return r_netcore0;
			}
		}

		/// <summary>
		/// System.IntPtr netcore1
		/// </summary>
		protected RField r_netcore1;
		public virtual RField Rnetcore1
		{
			get
			{
				if(r_netcore1 == null)
				{
					r_netcore1 = new(this, "netcore1");
					r_netcore1.SetBelong(this.instance);
				}
				return r_netcore1;
			}
		}

		/// <summary>
		/// System.IntPtr netcore2
		/// </summary>
		protected RField r_netcore2;
		public virtual RField Rnetcore2
		{
			get
			{
				if(r_netcore2 == null)
				{
					r_netcore2 = new(this, "netcore2");
					r_netcore2.SetBelong(this.instance);
				}
				return r_netcore2;
			}
		}

		/// <summary>
		/// System.IntPtr last
		/// </summary>
		protected RField r_last;
		public virtual RField Rlast
		{
			get
			{
				if(r_last == null)
				{
					r_last = new(this, "last");
					r_last.SetBelong(this.instance);
				}
				return r_last;
			}
		}

		/// <summary>
		/// Void Thread_free_internal()
		/// </summary>
		protected RMethod r_RThread_free_internal;
		public virtual RMethod RThread_free_internal
		{
			get
			{
				if(r_RThread_free_internal == null)
				{
					r_RThread_free_internal = new(this, "Thread_free_internal", 0);
					r_RThread_free_internal.SetBelong(this.instance);
				}
				return r_RThread_free_internal;
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
            var ___result = RThread_free_internal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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
