using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks
{
	/// <summary>
	/// System.Threading.Tasks.TaskExceptionHolder
	/// </summary>
    public partial class RTaskExceptionHolder : RMember //
    {

		/// <summary>
		/// System.Boolean s_failFastOnUnobservedException
		/// </summary>
		protected static RField r_s_failFastOnUnobservedException;
		public static RField Rs_failFastOnUnobservedException
		{
			get
			{
				if(r_s_failFastOnUnobservedException == null)
				{
					r_s_failFastOnUnobservedException = new( ReflectionUtils.GetType("System.Threading.Tasks.TaskExceptionHolder"), "s_failFastOnUnobservedException");
					r_s_failFastOnUnobservedException.SetBelong(null);
				}
				return r_s_failFastOnUnobservedException;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task m_task
		/// </summary>
		protected RSystem.RThreading.RTasks.RTask r_m_task;
		public virtual RSystem.RThreading.RTasks.RTask Rm_task
		{
			get
			{
				if(r_m_task == null)
				{
					r_m_task = new(this, "m_task");
					r_m_task.SetBelong(this.instance);
				}
				return r_m_task;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LowLevelListWithIList`1[System.Runtime.ExceptionServices.ExceptionDispatchInfo] m_faultExceptions
		/// </summary>
		protected RSystem.RCollections.RGeneric.RLowLevelListWithIList<RSystem.RRuntime.RExceptionServices.RExceptionDispatchInfo> r_m_faultExceptions;
		public virtual RSystem.RCollections.RGeneric.RLowLevelListWithIList<RSystem.RRuntime.RExceptionServices.RExceptionDispatchInfo> Rm_faultExceptions
		{
			get
			{
				if(r_m_faultExceptions == null)
				{
					r_m_faultExceptions = new(this, "m_faultExceptions");
					r_m_faultExceptions.SetBelong(this.instance);
				}
				return r_m_faultExceptions;
			}
		}

		/// <summary>
		/// System.Runtime.ExceptionServices.ExceptionDispatchInfo m_cancellationException
		/// </summary>
		protected RSystem.RRuntime.RExceptionServices.RExceptionDispatchInfo r_m_cancellationException;
		public virtual RSystem.RRuntime.RExceptionServices.RExceptionDispatchInfo Rm_cancellationException
		{
			get
			{
				if(r_m_cancellationException == null)
				{
					r_m_cancellationException = new(this, "m_cancellationException");
					r_m_cancellationException.SetBelong(this.instance);
				}
				return r_m_cancellationException;
			}
		}

		/// <summary>
		/// System.Boolean m_isHandled
		/// </summary>
		protected RField r_m_isHandled;
		public virtual RField Rm_isHandled
		{
			get
			{
				if(r_m_isHandled == null)
				{
					r_m_isHandled = new(this, "m_isHandled");
					r_m_isHandled.SetBelong(this.instance);
				}
				return r_m_isHandled;
			}
		}

		/// <summary>
		/// Boolean ContainsFaultList
		/// </summary>
		protected RProperty r_ContainsFaultList;
		public virtual RProperty RContainsFaultList
		{
			get
			{
				if(r_ContainsFaultList == null)
				{
					r_ContainsFaultList = new(this, "ContainsFaultList", -1);
					r_ContainsFaultList.SetBelong(this.instance);
				}
				return r_ContainsFaultList;
			}
		}

		/// <summary>
		/// Boolean ShouldFailFastOnUnobservedException()
		/// </summary>
		protected static RMethod r_ShouldFailFastOnUnobservedException;
		public static RMethod RShouldFailFastOnUnobservedException
		{
			get
			{
				if(r_ShouldFailFastOnUnobservedException == null)
				{
					r_ShouldFailFastOnUnobservedException = new( ReflectionUtils.GetType("System.Threading.Tasks.TaskExceptionHolder"), "ShouldFailFastOnUnobservedException", 0);
					r_ShouldFailFastOnUnobservedException.SetBelong(null);
				}
				return r_ShouldFailFastOnUnobservedException;
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
		/// Void Add(System.Object)
		/// </summary>
		protected RMethod r_Add_Object;
		public virtual RMethod RAdd_Object
		{
			get
			{
				if(r_Add_Object == null)
				{
					r_Add_Object = new(this, "Add", 0, typeof(System.Object));
					r_Add_Object.SetBelong(this.instance);
				}
				return r_Add_Object;
			}
		}

		/// <summary>
		/// Void Add(System.Object, Boolean)
		/// </summary>
		protected RMethod r_Add_Object_Boolean;
		public virtual RMethod RAdd_Object_Boolean
		{
			get
			{
				if(r_Add_Object_Boolean == null)
				{
					r_Add_Object_Boolean = new(this, "Add", 0, typeof(System.Object), typeof(System.Boolean));
					r_Add_Object_Boolean.SetBelong(this.instance);
				}
				return r_Add_Object_Boolean;
			}
		}

		/// <summary>
		/// Void SetCancellationException(System.Object)
		/// </summary>
		protected RMethod r_SetCancellationException_Object;
		public virtual RMethod RSetCancellationException_Object
		{
			get
			{
				if(r_SetCancellationException_Object == null)
				{
					r_SetCancellationException_Object = new(this, "SetCancellationException", 0, typeof(System.Object));
					r_SetCancellationException_Object.SetBelong(this.instance);
				}
				return r_SetCancellationException_Object;
			}
		}

		/// <summary>
		/// Void AddFaultException(System.Object)
		/// </summary>
		protected RMethod r_AddFaultException_Object;
		public virtual RMethod RAddFaultException_Object
		{
			get
			{
				if(r_AddFaultException_Object == null)
				{
					r_AddFaultException_Object = new(this, "AddFaultException", 0, typeof(System.Object));
					r_AddFaultException_Object.SetBelong(this.instance);
				}
				return r_AddFaultException_Object;
			}
		}

		/// <summary>
		/// Void MarkAsUnhandled()
		/// </summary>
		protected RMethod r_MarkAsUnhandled;
		public virtual RMethod RMarkAsUnhandled
		{
			get
			{
				if(r_MarkAsUnhandled == null)
				{
					r_MarkAsUnhandled = new(this, "MarkAsUnhandled", 0);
					r_MarkAsUnhandled.SetBelong(this.instance);
				}
				return r_MarkAsUnhandled;
			}
		}

		/// <summary>
		/// Void MarkAsHandled(Boolean)
		/// </summary>
		protected RMethod r_MarkAsHandled_Boolean;
		public virtual RMethod RMarkAsHandled_Boolean
		{
			get
			{
				if(r_MarkAsHandled_Boolean == null)
				{
					r_MarkAsHandled_Boolean = new(this, "MarkAsHandled", 0, typeof(System.Boolean));
					r_MarkAsHandled_Boolean.SetBelong(this.instance);
				}
				return r_MarkAsHandled_Boolean;
			}
		}

		/// <summary>
		/// System.AggregateException CreateExceptionObject(Boolean, System.Exception)
		/// </summary>
		protected RMethod r_CreateExceptionObject_Boolean_Exception;
		public virtual RMethod RCreateExceptionObject_Boolean_Exception
		{
			get
			{
				if(r_CreateExceptionObject_Boolean_Exception == null)
				{
					r_CreateExceptionObject_Boolean_Exception = new(this, "CreateExceptionObject", 0, typeof(System.Boolean), typeof(System.Exception));
					r_CreateExceptionObject_Boolean_Exception.SetBelong(this.instance);
				}
				return r_CreateExceptionObject_Boolean_Exception;
			}
		}

		/// <summary>
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[System.Runtime.ExceptionServices.ExceptionDispatchInfo] GetExceptionDispatchInfos()
		/// </summary>
		protected RMethod r_GetExceptionDispatchInfos;
		public virtual RMethod RGetExceptionDispatchInfos
		{
			get
			{
				if(r_GetExceptionDispatchInfos == null)
				{
					r_GetExceptionDispatchInfos = new(this, "GetExceptionDispatchInfos", 0);
					r_GetExceptionDispatchInfos.SetBelong(this.instance);
				}
				return r_GetExceptionDispatchInfos;
			}
		}

		/// <summary>
		/// System.Runtime.ExceptionServices.ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
		/// </summary>
		protected RMethod r_GetCancellationExceptionDispatchInfo;
		public virtual RMethod RGetCancellationExceptionDispatchInfo
		{
			get
			{
				if(r_GetCancellationExceptionDispatchInfo == null)
				{
					r_GetCancellationExceptionDispatchInfo = new(this, "GetCancellationExceptionDispatchInfo", 0);
					r_GetCancellationExceptionDispatchInfo.SetBelong(this.instance);
				}
				return r_GetCancellationExceptionDispatchInfo;
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


        public RTaskExceptionHolder() : base("System.Threading.Tasks.TaskExceptionHolder")
        {
        }

        public RTaskExceptionHolder(System.Object instance) : base("System.Threading.Tasks.TaskExceptionHolder")
		{
            SetInstance(instance);
		}

        public RTaskExceptionHolder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTaskExceptionHolder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean ShouldFailFastOnUnobservedException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShouldFailFastOnUnobservedException.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Add(System.Object  @exceptionObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exceptionObject};
            var ___result = RAdd_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Add(System.Object  @exceptionObject, System.Boolean  @representsCancellation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exceptionObject, @representsCancellation};
            var ___result = RAdd_Object_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCancellationException(System.Object  @exceptionObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exceptionObject};
            var ___result = RSetCancellationException_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddFaultException(System.Object  @exceptionObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exceptionObject};
            var ___result = RAddFaultException_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkAsUnhandled()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMarkAsUnhandled.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkAsHandled(System.Boolean  @calledFromFinalizer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calledFromFinalizer};
            var ___result = RMarkAsHandled_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.AggregateException CreateExceptionObject(System.Boolean  @calledFromFinalizer, System.Exception  @includeThisException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calledFromFinalizer, @includeThisException};
            var ___result = RCreateExceptionObject_Boolean_Exception.Invoke(___genericsType, ___parameters);

            return (System.AggregateException)___result;
        }


        public virtual System.Collections.ObjectModel.ReadOnlyCollection<System.Runtime.ExceptionServices.ExceptionDispatchInfo> GetExceptionDispatchInfos()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetExceptionDispatchInfos.Invoke(___genericsType, ___parameters);

            return (System.Collections.ObjectModel.ReadOnlyCollection<System.Runtime.ExceptionServices.ExceptionDispatchInfo>)___result;
        }


        public virtual System.Runtime.ExceptionServices.ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCancellationExceptionDispatchInfo.Invoke(___genericsType, ___parameters);

            return (System.Runtime.ExceptionServices.ExceptionDispatchInfo)___result;
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
