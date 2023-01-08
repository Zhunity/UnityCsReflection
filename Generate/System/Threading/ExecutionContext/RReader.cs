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
		protected RSystem.RThreading.RExecutionContext r_m_ec;
		public virtual RSystem.RThreading.RExecutionContext Rm_ec
		{
			get
			{
				if(r_m_ec == null)
				{
					r_m_ec = new(this, "m_ec");
					r_m_ec.SetBelong(this.instance);
				}
				return r_m_ec;
			}
		}

		/// <summary>
		/// Boolean IsNull
		/// </summary>
		protected RProperty r_IsNull;
		public virtual RProperty RIsNull
		{
			get
			{
				if(r_IsNull == null)
				{
					r_IsNull = new(this, "IsNull", -1);
					r_IsNull.SetBelong(this.instance);
				}
				return r_IsNull;
			}
		}

		/// <summary>
		/// Boolean IsFlowSuppressed
		/// </summary>
		protected RProperty r_IsFlowSuppressed;
		public virtual RProperty RIsFlowSuppressed
		{
			get
			{
				if(r_IsFlowSuppressed == null)
				{
					r_IsFlowSuppressed = new(this, "IsFlowSuppressed", -1);
					r_IsFlowSuppressed.SetBelong(this.instance);
				}
				return r_IsFlowSuppressed;
			}
		}

		/// <summary>
		/// System.Threading.SynchronizationContext SynchronizationContext
		/// </summary>
		protected RSystem.RThreading.RSynchronizationContext r_SynchronizationContext;
		public virtual RSystem.RThreading.RSynchronizationContext RSynchronizationContext
		{
			get
			{
				if(r_SynchronizationContext == null)
				{
					r_SynchronizationContext = new(this, "SynchronizationContext", -1);
					r_SynchronizationContext.SetBelong(this.instance);
				}
				return r_SynchronizationContext;
			}
		}

		/// <summary>
		/// System.Threading.SynchronizationContext SynchronizationContextNoFlow
		/// </summary>
		protected RSystem.RThreading.RSynchronizationContext r_SynchronizationContextNoFlow;
		public virtual RSystem.RThreading.RSynchronizationContext RSynchronizationContextNoFlow
		{
			get
			{
				if(r_SynchronizationContextNoFlow == null)
				{
					r_SynchronizationContextNoFlow = new(this, "SynchronizationContextNoFlow", -1);
					r_SynchronizationContextNoFlow.SetBelong(this.instance);
				}
				return r_SynchronizationContextNoFlow;
			}
		}

		/// <summary>
		/// Reader LogicalCallContext
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RMessaging.RLogicalCallContext.RReader r_LogicalCallContext;
		public virtual RSystem.RRuntime.RRemoting.RMessaging.RLogicalCallContext.RReader RLogicalCallContext
		{
			get
			{
				if(r_LogicalCallContext == null)
				{
					r_LogicalCallContext = new(this, "LogicalCallContext", -1);
					r_LogicalCallContext.SetBelong(this.instance);
				}
				return r_LogicalCallContext;
			}
		}

		/// <summary>
		/// Reader IllogicalCallContext
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RMessaging.RIllogicalCallContext.RReader r_IllogicalCallContext;
		public virtual RSystem.RRuntime.RRemoting.RMessaging.RIllogicalCallContext.RReader RIllogicalCallContext
		{
			get
			{
				if(r_IllogicalCallContext == null)
				{
					r_IllogicalCallContext = new(this, "IllogicalCallContext", -1);
					r_IllogicalCallContext.SetBelong(this.instance);
				}
				return r_IllogicalCallContext;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext DangerousGetRawExecutionContext()
		/// </summary>
		protected RMethod r_DangerousGetRawExecutionContext;
		public virtual RMethod RDangerousGetRawExecutionContext
		{
			get
			{
				if(r_DangerousGetRawExecutionContext == null)
				{
					r_DangerousGetRawExecutionContext = new(this, "DangerousGetRawExecutionContext", 0);
					r_DangerousGetRawExecutionContext.SetBelong(this.instance);
				}
				return r_DangerousGetRawExecutionContext;
			}
		}

		/// <summary>
		/// Boolean IsDefaultFTContext(Boolean)
		/// </summary>
		protected RMethod r_IsDefaultFTContext_Boolean;
		public virtual RMethod RIsDefaultFTContext_Boolean
		{
			get
			{
				if(r_IsDefaultFTContext_Boolean == null)
				{
					r_IsDefaultFTContext_Boolean = new(this, "IsDefaultFTContext", 0, typeof(System.Boolean));
					r_IsDefaultFTContext_Boolean.SetBelong(this.instance);
				}
				return r_IsDefaultFTContext_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsSame(Reader)
		/// </summary>
		protected RMethod r_IsSame_Reader;
		public virtual RMethod RIsSame_Reader
		{
			get
			{
				if(r_IsSame_Reader == null)
				{
					r_IsSame_Reader = new(this, "IsSame", 0,  ReflectionUtils.GetType("System.Threading.ExecutionContext+Reader"));
					r_IsSame_Reader.SetBelong(this.instance);
				}
				return r_IsSame_Reader;
			}
		}

		/// <summary>
		/// System.Object GetLocalValue(System.Threading.IAsyncLocal)
		/// </summary>
		protected RMethod r_GetLocalValue_IAsyncLocal;
		public virtual RMethod RGetLocalValue_IAsyncLocal
		{
			get
			{
				if(r_GetLocalValue_IAsyncLocal == null)
				{
					r_GetLocalValue_IAsyncLocal = new(this, "GetLocalValue", 0,  ReflectionUtils.GetType("System.Threading.IAsyncLocal"));
					r_GetLocalValue_IAsyncLocal.SetBelong(this.instance);
				}
				return r_GetLocalValue_IAsyncLocal;
			}
		}

		/// <summary>
		/// Boolean HasSameLocalValues(System.Threading.ExecutionContext)
		/// </summary>
		protected RMethod r_HasSameLocalValues_ExecutionContext;
		public virtual RMethod RHasSameLocalValues_ExecutionContext
		{
			get
			{
				if(r_HasSameLocalValues_ExecutionContext == null)
				{
					r_HasSameLocalValues_ExecutionContext = new(this, "HasSameLocalValues", 0, typeof(System.Threading.ExecutionContext));
					r_HasSameLocalValues_ExecutionContext.SetBelong(this.instance);
				}
				return r_HasSameLocalValues_ExecutionContext;
			}
		}

		/// <summary>
		/// Boolean HasLocalValues()
		/// </summary>
		protected RMethod r_HasLocalValues;
		public virtual RMethod RHasLocalValues
		{
			get
			{
				if(r_HasLocalValues == null)
				{
					r_HasLocalValues = new(this, "HasLocalValues", 0);
					r_HasLocalValues.SetBelong(this.instance);
				}
				return r_HasLocalValues;
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
            var ___result = RDangerousGetRawExecutionContext.Invoke(___genericsType, ___parameters);

            return (System.Threading.ExecutionContext)___result;
        }


        public virtual System.Boolean IsDefaultFTContext(System.Boolean  @ignoreSyncCtx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ignoreSyncCtx};
            var ___result = RIsDefaultFTContext_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsSame(RSystem.RThreading.RExecutionContext.RReader  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RIsSame_Reader.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object GetLocalValue(RSystem.RThreading.RIAsyncLocal  @local)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@local.Value};
            var ___result = RGetLocalValue_IAsyncLocal.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean HasSameLocalValues(System.Threading.ExecutionContext  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RHasSameLocalValues_ExecutionContext.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasLocalValues()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasLocalValues.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
}