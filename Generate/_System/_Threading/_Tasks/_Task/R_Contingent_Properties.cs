
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading.RTasks
{public partial class RTask
{
	
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Threading.Tasks.Task+ContingentProperties
	/// </summary>
    public partial class RContingentProperties : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Threading.Tasks.Task+ContingentProperties");
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


		/// <summary>
		/// System.Threading.ExecutionContext m_capturedContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext r_Fm_capturedContext;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext RFm_capturedContext
		{
			get
			{
				if(r_Fm_capturedContext == null)
				{
					r_Fm_capturedContext = new(this, "m_capturedContext");
				}
				return r_Fm_capturedContext;
			}
		}

		/// <summary>
		/// System.Threading.ManualResetEventSlim m_completionEvent
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RManualResetEventSlim r_Fm_completionEvent;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RManualResetEventSlim RFm_completionEvent
		{
			get
			{
				if(r_Fm_completionEvent == null)
				{
					r_Fm_completionEvent = new(this, "m_completionEvent");
				}
				return r_Fm_completionEvent;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskExceptionHolder m_exceptionsHolder
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskExceptionHolder r_Fm_exceptionsHolder;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskExceptionHolder RFm_exceptionsHolder
		{
			get
			{
				if(r_Fm_exceptionsHolder == null)
				{
					r_Fm_exceptionsHolder = new(this, "m_exceptionsHolder");
				}
				return r_Fm_exceptionsHolder;
			}
		}

		/// <summary>
		/// System.Threading.CancellationToken m_cancellationToken
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationToken r_Fm_cancellationToken;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationToken RFm_cancellationToken
		{
			get
			{
				if(r_Fm_cancellationToken == null)
				{
					r_Fm_cancellationToken = new(this, "m_cancellationToken");
				}
				return r_Fm_cancellationToken;
			}
		}

		/// <summary>
		/// System.Object m_cancellationRegistration
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_Fm_cancellationRegistration;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RFm_cancellationRegistration
		{
			get
			{
				if(r_Fm_cancellationRegistration == null)
				{
					r_Fm_cancellationRegistration = new(this, "m_cancellationRegistration");
				}
				return r_Fm_cancellationRegistration;
			}
		}

		/// <summary>
		/// System.Int32 m_internalCancellationRequested
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_internalCancellationRequested;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_internalCancellationRequested
		{
			get
			{
				if(r_Fm_internalCancellationRequested == null)
				{
					r_Fm_internalCancellationRequested = new(this, "m_internalCancellationRequested");
				}
				return r_Fm_internalCancellationRequested;
			}
		}

		/// <summary>
		/// System.Int32 m_completionCountdown
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_completionCountdown;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_completionCountdown
		{
			get
			{
				if(r_Fm_completionCountdown == null)
				{
					r_Fm_completionCountdown = new(this, "m_completionCountdown");
				}
				return r_Fm_completionCountdown;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LowLevelListWithIList`1[System.Threading.Tasks.Task] m_exceptionalChildren
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLowLevelListWithIList<Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask> r_Fm_exceptionalChildren;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLowLevelListWithIList<Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask> RFm_exceptionalChildren
		{
			get
			{
				if(r_Fm_exceptionalChildren == null)
				{
					r_Fm_exceptionalChildren = new(this, "m_exceptionalChildren");
				}
				return r_Fm_exceptionalChildren;
			}
		}

		/// <summary>
		/// Void SetCompleted()
		/// </summary>
		protected RMethod r_MSetCompleted;
		public virtual RMethod RMSetCompleted
		{
			get
			{
				if(r_MSetCompleted == null)
				{
					r_MSetCompleted = new(this, "SetCompleted", 0);
				}
				return r_MSetCompleted;
			}
		}

		/// <summary>
		/// Void UnregisterCancellationCallback()
		/// </summary>
		protected RMethod r_MUnregisterCancellationCallback;
		public virtual RMethod RMUnregisterCancellationCallback
		{
			get
			{
				if(r_MUnregisterCancellationCallback == null)
				{
					r_MUnregisterCancellationCallback = new(this, "UnregisterCancellationCallback", 0);
				}
				return r_MUnregisterCancellationCallback;
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


        public virtual void SetCompleted()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetCompleted.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterCancellationCallback()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUnregisterCancellationCallback.Invoke(___genericsType, ___parameters);

            
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
}