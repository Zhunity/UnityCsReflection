using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks
{public partial class RTask
{
	
	/// <summary>
	/// System.Threading.Tasks.Task+ContingentProperties
	/// </summary>
    public partial class RContingentProperties : RMember //
    {

		/// <summary>
		/// System.Threading.ExecutionContext m_capturedContext
		/// </summary>
		protected RSystem.RThreading.RExecutionContext r_m_capturedContext;
		public virtual RSystem.RThreading.RExecutionContext Rm_capturedContext
		{
			get
			{
				if(r_m_capturedContext == null)
				{
					r_m_capturedContext = new(this, "m_capturedContext");
					r_m_capturedContext.SetBelong(this.instance);
				}
				return r_m_capturedContext;
			}
		}

		/// <summary>
		/// System.Threading.ManualResetEventSlim m_completionEvent
		/// </summary>
		protected RSystem.RThreading.RManualResetEventSlim r_m_completionEvent;
		public virtual RSystem.RThreading.RManualResetEventSlim Rm_completionEvent
		{
			get
			{
				if(r_m_completionEvent == null)
				{
					r_m_completionEvent = new(this, "m_completionEvent");
					r_m_completionEvent.SetBelong(this.instance);
				}
				return r_m_completionEvent;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskExceptionHolder m_exceptionsHolder
		/// </summary>
		protected RSystem.RThreading.RTasks.RTaskExceptionHolder r_m_exceptionsHolder;
		public virtual RSystem.RThreading.RTasks.RTaskExceptionHolder Rm_exceptionsHolder
		{
			get
			{
				if(r_m_exceptionsHolder == null)
				{
					r_m_exceptionsHolder = new(this, "m_exceptionsHolder");
					r_m_exceptionsHolder.SetBelong(this.instance);
				}
				return r_m_exceptionsHolder;
			}
		}

		/// <summary>
		/// System.Threading.CancellationToken m_cancellationToken
		/// </summary>
		protected RSystem.RThreading.RCancellationToken r_m_cancellationToken;
		public virtual RSystem.RThreading.RCancellationToken Rm_cancellationToken
		{
			get
			{
				if(r_m_cancellationToken == null)
				{
					r_m_cancellationToken = new(this, "m_cancellationToken");
					r_m_cancellationToken.SetBelong(this.instance);
				}
				return r_m_cancellationToken;
			}
		}

		/// <summary>
		/// System.Object m_cancellationRegistration
		/// </summary>
		protected RSystem.RObject r_m_cancellationRegistration;
		public virtual RSystem.RObject Rm_cancellationRegistration
		{
			get
			{
				if(r_m_cancellationRegistration == null)
				{
					r_m_cancellationRegistration = new(this, "m_cancellationRegistration");
					r_m_cancellationRegistration.SetBelong(this.instance);
				}
				return r_m_cancellationRegistration;
			}
		}

		/// <summary>
		/// System.Int32 m_internalCancellationRequested
		/// </summary>
		protected RField r_m_internalCancellationRequested;
		public virtual RField Rm_internalCancellationRequested
		{
			get
			{
				if(r_m_internalCancellationRequested == null)
				{
					r_m_internalCancellationRequested = new(this, "m_internalCancellationRequested");
					r_m_internalCancellationRequested.SetBelong(this.instance);
				}
				return r_m_internalCancellationRequested;
			}
		}

		/// <summary>
		/// System.Int32 m_completionCountdown
		/// </summary>
		protected RField r_m_completionCountdown;
		public virtual RField Rm_completionCountdown
		{
			get
			{
				if(r_m_completionCountdown == null)
				{
					r_m_completionCountdown = new(this, "m_completionCountdown");
					r_m_completionCountdown.SetBelong(this.instance);
				}
				return r_m_completionCountdown;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LowLevelListWithIList`1[System.Threading.Tasks.Task] m_exceptionalChildren
		/// </summary>
		protected RSystem.RCollections.RGeneric.RLowLevelListWithIList<RSystem.RThreading.RTasks.RTask> r_m_exceptionalChildren;
		public virtual RSystem.RCollections.RGeneric.RLowLevelListWithIList<RSystem.RThreading.RTasks.RTask> Rm_exceptionalChildren
		{
			get
			{
				if(r_m_exceptionalChildren == null)
				{
					r_m_exceptionalChildren = new(this, "m_exceptionalChildren");
					r_m_exceptionalChildren.SetBelong(this.instance);
				}
				return r_m_exceptionalChildren;
			}
		}

		/// <summary>
		/// Void SetCompleted()
		/// </summary>
		protected RMethod r_RSetCompleted;
		public virtual RMethod RSetCompleted
		{
			get
			{
				if(r_RSetCompleted == null)
				{
					r_RSetCompleted = new(this, "SetCompleted", 0);
					r_RSetCompleted.SetBelong(this.instance);
				}
				return r_RSetCompleted;
			}
		}

		/// <summary>
		/// Void UnregisterCancellationCallback()
		/// </summary>
		protected RMethod r_RUnregisterCancellationCallback;
		public virtual RMethod RUnregisterCancellationCallback
		{
			get
			{
				if(r_RUnregisterCancellationCallback == null)
				{
					r_RUnregisterCancellationCallback = new(this, "UnregisterCancellationCallback", 0);
					r_RUnregisterCancellationCallback.SetBelong(this.instance);
				}
				return r_RUnregisterCancellationCallback;
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


        public RContingentProperties() : base("System.Threading.Tasks.Task+ContingentProperties")
        {
        }

        public RContingentProperties(System.Object instance) : base("System.Threading.Tasks.Task+ContingentProperties")
		{
            SetInstance(instance);
		}

        public RContingentProperties(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RContingentProperties(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetCompleted()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetCompleted.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterCancellationCallback()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnregisterCancellationCallback.Invoke(___genericsType, ___parameters);

            
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
}