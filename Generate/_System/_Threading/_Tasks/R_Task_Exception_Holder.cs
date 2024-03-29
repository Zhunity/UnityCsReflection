
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading.RTasks
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Threading.Tasks.TaskExceptionHolder
	/// </summary>
    public partial class RTaskExceptionHolder : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Threading.Tasks.TaskExceptionHolder");
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


		/// <summary>
		/// System.Boolean s_failFastOnUnobservedException
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_Fs_failFastOnUnobservedException;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RFs_failFastOnUnobservedException
		{
			get
			{
				if(r_Fs_failFastOnUnobservedException == null)
				{
					r_Fs_failFastOnUnobservedException = new(Type, "s_failFastOnUnobservedException");
				}
				return r_Fs_failFastOnUnobservedException;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task m_task
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask r_Fm_task;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask RFm_task
		{
			get
			{
				if(r_Fm_task == null)
				{
					r_Fm_task = new(this, "m_task");
				}
				return r_Fm_task;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LowLevelListWithIList`1[System.Runtime.ExceptionServices.ExceptionDispatchInfo] m_faultExceptions
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLowLevelListWithIList<Hvak.Editor.Refleaction.RSystem.RRuntime.RExceptionServices.RExceptionDispatchInfo> r_Fm_faultExceptions;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLowLevelListWithIList<Hvak.Editor.Refleaction.RSystem.RRuntime.RExceptionServices.RExceptionDispatchInfo> RFm_faultExceptions
		{
			get
			{
				if(r_Fm_faultExceptions == null)
				{
					r_Fm_faultExceptions = new(this, "m_faultExceptions");
				}
				return r_Fm_faultExceptions;
			}
		}

		/// <summary>
		/// System.Runtime.ExceptionServices.ExceptionDispatchInfo m_cancellationException
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RExceptionServices.RExceptionDispatchInfo r_Fm_cancellationException;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RExceptionServices.RExceptionDispatchInfo RFm_cancellationException
		{
			get
			{
				if(r_Fm_cancellationException == null)
				{
					r_Fm_cancellationException = new(this, "m_cancellationException");
				}
				return r_Fm_cancellationException;
			}
		}

		/// <summary>
		/// System.Boolean m_isHandled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_isHandled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_isHandled
		{
			get
			{
				if(r_Fm_isHandled == null)
				{
					r_Fm_isHandled = new(this, "m_isHandled");
				}
				return r_Fm_isHandled;
			}
		}

		/// <summary>
		/// Boolean ContainsFaultList
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PContainsFaultList;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPContainsFaultList
		{
			get
			{
				if(r_PContainsFaultList == null)
				{
					r_PContainsFaultList = new(this, "ContainsFaultList", -1);
				}
				return r_PContainsFaultList;
			}
		}

		/// <summary>
		/// Boolean ShouldFailFastOnUnobservedException()
		/// </summary>
		protected static RMethod r_MShouldFailFastOnUnobservedException;
		public static RMethod RMShouldFailFastOnUnobservedException
		{
			get
			{
				if(r_MShouldFailFastOnUnobservedException == null)
				{
					r_MShouldFailFastOnUnobservedException = new(Type, "ShouldFailFastOnUnobservedException", 0);
				}
				return r_MShouldFailFastOnUnobservedException;
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
		/// Void Add(System.Object)
		/// </summary>
		protected RMethod r_MAdd_Object;
		public virtual RMethod RMAdd_Object
		{
			get
			{
				if(r_MAdd_Object == null)
				{
					r_MAdd_Object = new(this, "Add", 0, typeof(System.Object));
				}
				return r_MAdd_Object;
			}
		}

		/// <summary>
		/// Void Add(System.Object, Boolean)
		/// </summary>
		protected RMethod r_MAdd_Object_Boolean;
		public virtual RMethod RMAdd_Object_Boolean
		{
			get
			{
				if(r_MAdd_Object_Boolean == null)
				{
					r_MAdd_Object_Boolean = new(this, "Add", 0, typeof(System.Object), typeof(System.Boolean));
				}
				return r_MAdd_Object_Boolean;
			}
		}

		/// <summary>
		/// Void SetCancellationException(System.Object)
		/// </summary>
		protected RMethod r_MSetCancellationException_Object;
		public virtual RMethod RMSetCancellationException_Object
		{
			get
			{
				if(r_MSetCancellationException_Object == null)
				{
					r_MSetCancellationException_Object = new(this, "SetCancellationException", 0, typeof(System.Object));
				}
				return r_MSetCancellationException_Object;
			}
		}

		/// <summary>
		/// Void AddFaultException(System.Object)
		/// </summary>
		protected RMethod r_MAddFaultException_Object;
		public virtual RMethod RMAddFaultException_Object
		{
			get
			{
				if(r_MAddFaultException_Object == null)
				{
					r_MAddFaultException_Object = new(this, "AddFaultException", 0, typeof(System.Object));
				}
				return r_MAddFaultException_Object;
			}
		}

		/// <summary>
		/// Void MarkAsUnhandled()
		/// </summary>
		protected RMethod r_MMarkAsUnhandled;
		public virtual RMethod RMMarkAsUnhandled
		{
			get
			{
				if(r_MMarkAsUnhandled == null)
				{
					r_MMarkAsUnhandled = new(this, "MarkAsUnhandled", 0);
				}
				return r_MMarkAsUnhandled;
			}
		}

		/// <summary>
		/// Void MarkAsHandled(Boolean)
		/// </summary>
		protected RMethod r_MMarkAsHandled_Boolean;
		public virtual RMethod RMMarkAsHandled_Boolean
		{
			get
			{
				if(r_MMarkAsHandled_Boolean == null)
				{
					r_MMarkAsHandled_Boolean = new(this, "MarkAsHandled", 0, typeof(System.Boolean));
				}
				return r_MMarkAsHandled_Boolean;
			}
		}

		/// <summary>
		/// System.AggregateException CreateExceptionObject(Boolean, System.Exception)
		/// </summary>
		protected RMethod r_MCreateExceptionObject_Boolean_Exception;
		public virtual RMethod RMCreateExceptionObject_Boolean_Exception
		{
			get
			{
				if(r_MCreateExceptionObject_Boolean_Exception == null)
				{
					r_MCreateExceptionObject_Boolean_Exception = new(this, "CreateExceptionObject", 0, typeof(System.Boolean), typeof(System.Exception));
				}
				return r_MCreateExceptionObject_Boolean_Exception;
			}
		}

		/// <summary>
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[System.Runtime.ExceptionServices.ExceptionDispatchInfo] GetExceptionDispatchInfos()
		/// </summary>
		protected RMethod r_MGetExceptionDispatchInfos;
		public virtual RMethod RMGetExceptionDispatchInfos
		{
			get
			{
				if(r_MGetExceptionDispatchInfos == null)
				{
					r_MGetExceptionDispatchInfos = new(this, "GetExceptionDispatchInfos", 0);
				}
				return r_MGetExceptionDispatchInfos;
			}
		}

		/// <summary>
		/// System.Runtime.ExceptionServices.ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
		/// </summary>
		protected RMethod r_MGetCancellationExceptionDispatchInfo;
		public virtual RMethod RMGetCancellationExceptionDispatchInfo
		{
			get
			{
				if(r_MGetCancellationExceptionDispatchInfo == null)
				{
					r_MGetCancellationExceptionDispatchInfo = new(this, "GetCancellationExceptionDispatchInfo", 0);
				}
				return r_MGetCancellationExceptionDispatchInfo;
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


        public static System.Boolean ShouldFailFastOnUnobservedException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShouldFailFastOnUnobservedException.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Add(System.Object @exceptionObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exceptionObject};
            var ___result = RMAdd_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Add(System.Object @exceptionObject, System.Boolean @representsCancellation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exceptionObject, @representsCancellation};
            var ___result = RMAdd_Object_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCancellationException(System.Object @exceptionObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exceptionObject};
            var ___result = RMSetCancellationException_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddFaultException(System.Object @exceptionObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exceptionObject};
            var ___result = RMAddFaultException_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkAsUnhandled()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMarkAsUnhandled.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkAsHandled(System.Boolean @calledFromFinalizer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calledFromFinalizer};
            var ___result = RMMarkAsHandled_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.AggregateException CreateExceptionObject(System.Boolean @calledFromFinalizer, System.Exception @includeThisException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calledFromFinalizer, @includeThisException};
            var ___result = RMCreateExceptionObject_Boolean_Exception.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.AggregateException>(___result);
        }


        public virtual System.Collections.ObjectModel.ReadOnlyCollection<System.Runtime.ExceptionServices.ExceptionDispatchInfo> GetExceptionDispatchInfos()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetExceptionDispatchInfos.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.ObjectModel.ReadOnlyCollection<System.Runtime.ExceptionServices.ExceptionDispatchInfo>>(___result);
        }


        public virtual System.Runtime.ExceptionServices.ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCancellationExceptionDispatchInfo.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.ExceptionServices.ExceptionDispatchInfo>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
