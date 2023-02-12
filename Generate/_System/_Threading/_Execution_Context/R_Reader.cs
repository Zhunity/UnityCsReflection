
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{public partial class RExecutionContext
{
	
	/// <summary>
	/// System.Threading.ExecutionContext+Reader
	/// </summary>
    public partial class RReader : RMember //
    {

		/// <summary>
		/// System.Threading.ExecutionContext m_ec
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RThreading.RExecutionContext r_Fm_ec;
		public virtual SMFrame.Editor.Refleaction.RSystem.RThreading.RExecutionContext RFm_ec
		{
			get
			{
				if(r_Fm_ec == null)
				{
					r_Fm_ec = new(this, "m_ec");
					r_Fm_ec.SetBelong(this.instance);
				}
				return r_Fm_ec;
			}
		}

		/// <summary>
		/// Boolean IsNull
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsNull;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsNull
		{
			get
			{
				if(r_PIsNull == null)
				{
					r_PIsNull = new(this, "IsNull", -1);
					r_PIsNull.SetBelong(this.instance);
				}
				return r_PIsNull;
			}
		}

		/// <summary>
		/// Boolean IsFlowSuppressed
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsFlowSuppressed;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsFlowSuppressed
		{
			get
			{
				if(r_PIsFlowSuppressed == null)
				{
					r_PIsFlowSuppressed = new(this, "IsFlowSuppressed", -1);
					r_PIsFlowSuppressed.SetBelong(this.instance);
				}
				return r_PIsFlowSuppressed;
			}
		}

		/// <summary>
		/// System.Threading.SynchronizationContext SynchronizationContext
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RThreading.RSynchronizationContext r_PSynchronizationContext;
		public virtual SMFrame.Editor.Refleaction.RSystem.RThreading.RSynchronizationContext RPSynchronizationContext
		{
			get
			{
				if(r_PSynchronizationContext == null)
				{
					r_PSynchronizationContext = new(this, "SynchronizationContext", -1);
					r_PSynchronizationContext.SetBelong(this.instance);
				}
				return r_PSynchronizationContext;
			}
		}

		/// <summary>
		/// System.Threading.SynchronizationContext SynchronizationContextNoFlow
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RThreading.RSynchronizationContext r_PSynchronizationContextNoFlow;
		public virtual SMFrame.Editor.Refleaction.RSystem.RThreading.RSynchronizationContext RPSynchronizationContextNoFlow
		{
			get
			{
				if(r_PSynchronizationContextNoFlow == null)
				{
					r_PSynchronizationContextNoFlow = new(this, "SynchronizationContextNoFlow", -1);
					r_PSynchronizationContextNoFlow.SetBelong(this.instance);
				}
				return r_PSynchronizationContextNoFlow;
			}
		}

		/// <summary>
		/// Reader LogicalCallContext
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RLogicalCallContext.RReader r_PLogicalCallContext;
		public virtual SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RLogicalCallContext.RReader RPLogicalCallContext
		{
			get
			{
				if(r_PLogicalCallContext == null)
				{
					r_PLogicalCallContext = new(this, "LogicalCallContext", -1);
					r_PLogicalCallContext.SetBelong(this.instance);
				}
				return r_PLogicalCallContext;
			}
		}

		/// <summary>
		/// Reader IllogicalCallContext
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RIllogicalCallContext.RReader r_PIllogicalCallContext;
		public virtual SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RIllogicalCallContext.RReader RPIllogicalCallContext
		{
			get
			{
				if(r_PIllogicalCallContext == null)
				{
					r_PIllogicalCallContext = new(this, "IllogicalCallContext", -1);
					r_PIllogicalCallContext.SetBelong(this.instance);
				}
				return r_PIllogicalCallContext;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext DangerousGetRawExecutionContext()
		/// </summary>
		protected RMethod r_MDangerousGetRawExecutionContext;
		public virtual RMethod RMDangerousGetRawExecutionContext
		{
			get
			{
				if(r_MDangerousGetRawExecutionContext == null)
				{
					r_MDangerousGetRawExecutionContext = new(this, "DangerousGetRawExecutionContext", 0);
					r_MDangerousGetRawExecutionContext.SetBelong(this.instance);
				}
				return r_MDangerousGetRawExecutionContext;
			}
		}

		/// <summary>
		/// Boolean IsDefaultFTContext(Boolean)
		/// </summary>
		protected RMethod r_MIsDefaultFTContext_Boolean;
		public virtual RMethod RMIsDefaultFTContext_Boolean
		{
			get
			{
				if(r_MIsDefaultFTContext_Boolean == null)
				{
					r_MIsDefaultFTContext_Boolean = new(this, "IsDefaultFTContext", 0, typeof(System.Boolean));
					r_MIsDefaultFTContext_Boolean.SetBelong(this.instance);
				}
				return r_MIsDefaultFTContext_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsSame(Reader)
		/// </summary>
		protected RMethod r_MIsSame_Reader;
		public virtual RMethod RMIsSame_Reader
		{
			get
			{
				if(r_MIsSame_Reader == null)
				{
					r_MIsSame_Reader = new(this, "IsSame", 0,  ReflectionUtils.GetType("System.Threading.ExecutionContext+Reader"));
					r_MIsSame_Reader.SetBelong(this.instance);
				}
				return r_MIsSame_Reader;
			}
		}

		/// <summary>
		/// System.Object GetLocalValue(System.Threading.IAsyncLocal)
		/// </summary>
		protected RMethod r_MGetLocalValue_IAsyncLocal;
		public virtual RMethod RMGetLocalValue_IAsyncLocal
		{
			get
			{
				if(r_MGetLocalValue_IAsyncLocal == null)
				{
					r_MGetLocalValue_IAsyncLocal = new(this, "GetLocalValue", 0,  ReflectionUtils.GetType("System.Threading.IAsyncLocal"));
					r_MGetLocalValue_IAsyncLocal.SetBelong(this.instance);
				}
				return r_MGetLocalValue_IAsyncLocal;
			}
		}

		/// <summary>
		/// Boolean HasSameLocalValues(System.Threading.ExecutionContext)
		/// </summary>
		protected RMethod r_MHasSameLocalValues_ExecutionContext;
		public virtual RMethod RMHasSameLocalValues_ExecutionContext
		{
			get
			{
				if(r_MHasSameLocalValues_ExecutionContext == null)
				{
					r_MHasSameLocalValues_ExecutionContext = new(this, "HasSameLocalValues", 0, typeof(System.Threading.ExecutionContext));
					r_MHasSameLocalValues_ExecutionContext.SetBelong(this.instance);
				}
				return r_MHasSameLocalValues_ExecutionContext;
			}
		}

		/// <summary>
		/// Boolean HasLocalValues()
		/// </summary>
		protected RMethod r_MHasLocalValues;
		public virtual RMethod RMHasLocalValues
		{
			get
			{
				if(r_MHasLocalValues == null)
				{
					r_MHasLocalValues = new(this, "HasLocalValues", 0);
					r_MHasLocalValues.SetBelong(this.instance);
				}
				return r_MHasLocalValues;
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


        public RReader() : base("System.Threading.ExecutionContext+Reader")
        {
        }

        public RReader(System.Object instance) : base("System.Threading.ExecutionContext+Reader")
		{
            SetInstance(instance);
		}

        public RReader(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RReader(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Threading.ExecutionContext DangerousGetRawExecutionContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDangerousGetRawExecutionContext.Invoke(___genericsType, ___parameters);

            return (System.Threading.ExecutionContext)___result;
        }


        public virtual System.Boolean IsDefaultFTContext(System.Boolean @ignoreSyncCtx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ignoreSyncCtx};
            var ___result = RMIsDefaultFTContext_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsSame(SMFrame.Editor.Refleaction.RSystem.RThreading.RExecutionContext.RReader @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMIsSame_Reader.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object GetLocalValue(SMFrame.Editor.Refleaction.RSystem.RThreading.RIAsyncLocal @local)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@local.Value};
            var ___result = RMGetLocalValue_IAsyncLocal.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean HasSameLocalValues(System.Threading.ExecutionContext @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMHasSameLocalValues_ExecutionContext.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasLocalValues()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasLocalValues.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
}