using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.CancellationToken
	/// </summary>
    public partial class RCancellationToken : RMember //
    {

		/// <summary>
		/// System.Threading.CancellationTokenSource _source
		/// </summary>
		protected RSystem.RThreading.RCancellationTokenSource r__source;
		public virtual RSystem.RThreading.RCancellationTokenSource R_source
		{
			get
			{
				if(r__source == null)
				{
					r__source = new(this, "_source");
					r__source.SetBelong(this.instance);
				}
				return r__source;
			}
		}

		/// <summary>
		/// System.Action`1[System.Object] s_actionToActionObjShunt
		/// </summary>
		protected static RSystem.RAction<RSystem.RObject> r_s_actionToActionObjShunt;
		public static RSystem.RAction<RSystem.RObject> Rs_actionToActionObjShunt
		{
			get
			{
				if(r_s_actionToActionObjShunt == null)
				{
					r_s_actionToActionObjShunt = new(typeof(System.Threading.CancellationToken), "s_actionToActionObjShunt");
					r_s_actionToActionObjShunt.SetBelong(null);
				}
				return r_s_actionToActionObjShunt;
			}
		}

		/// <summary>
		/// System.Threading.CancellationToken None
		/// </summary>
		protected static RSystem.RThreading.RCancellationToken r_None;
		public static RSystem.RThreading.RCancellationToken RNone
		{
			get
			{
				if(r_None == null)
				{
					r_None = new(typeof(System.Threading.CancellationToken), "None", -1);
					r_None.SetBelong(null);
				}
				return r_None;
			}
		}

		/// <summary>
		/// Boolean IsCancellationRequested
		/// </summary>
		protected RProperty r_IsCancellationRequested;
		public virtual RProperty RIsCancellationRequested
		{
			get
			{
				if(r_IsCancellationRequested == null)
				{
					r_IsCancellationRequested = new(this, "IsCancellationRequested", -1);
					r_IsCancellationRequested.SetBelong(this.instance);
				}
				return r_IsCancellationRequested;
			}
		}

		/// <summary>
		/// Boolean CanBeCanceled
		/// </summary>
		protected RProperty r_CanBeCanceled;
		public virtual RProperty RCanBeCanceled
		{
			get
			{
				if(r_CanBeCanceled == null)
				{
					r_CanBeCanceled = new(this, "CanBeCanceled", -1);
					r_CanBeCanceled.SetBelong(this.instance);
				}
				return r_CanBeCanceled;
			}
		}

		/// <summary>
		/// System.Threading.WaitHandle WaitHandle
		/// </summary>
		protected RSystem.RThreading.RWaitHandle r_WaitHandle;
		public virtual RSystem.RThreading.RWaitHandle RWaitHandle
		{
			get
			{
				if(r_WaitHandle == null)
				{
					r_WaitHandle = new(this, "WaitHandle", -1);
					r_WaitHandle.SetBelong(this.instance);
				}
				return r_WaitHandle;
			}
		}

		/// <summary>
		/// System.Threading.CancellationTokenRegistration Register(System.Action)
		/// </summary>
		protected RMethod r_RRegister_Action;
		public virtual RMethod RRegister_Action
		{
			get
			{
				if(r_RRegister_Action == null)
				{
					r_RRegister_Action = new(this, "Register", 0, typeof(System.Action));
					r_RRegister_Action.SetBelong(this.instance);
				}
				return r_RRegister_Action;
			}
		}

		/// <summary>
		/// System.Threading.CancellationTokenRegistration Register(System.Action, Boolean)
		/// </summary>
		protected RMethod r_RRegister_Action_Boolean;
		public virtual RMethod RRegister_Action_Boolean
		{
			get
			{
				if(r_RRegister_Action_Boolean == null)
				{
					r_RRegister_Action_Boolean = new(this, "Register", 0, typeof(System.Action), typeof(System.Boolean));
					r_RRegister_Action_Boolean.SetBelong(this.instance);
				}
				return r_RRegister_Action_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.CancellationTokenRegistration Register(System.Action`1[System.Object], System.Object)
		/// </summary>
		protected RMethod r_RRegister_Action_d_Object_p__Object;
		public virtual RMethod RRegister_Action_d_Object_p__Object
		{
			get
			{
				if(r_RRegister_Action_d_Object_p__Object == null)
				{
					r_RRegister_Action_d_Object_p__Object = new(this, "Register", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Object)), typeof(System.Object));
					r_RRegister_Action_d_Object_p__Object.SetBelong(this.instance);
				}
				return r_RRegister_Action_d_Object_p__Object;
			}
		}

		/// <summary>
		/// System.Threading.CancellationTokenRegistration Register(System.Action`1[System.Object], System.Object, Boolean)
		/// </summary>
		protected RMethod r_RRegister_Action_d_Object_p__Object_Boolean;
		public virtual RMethod RRegister_Action_d_Object_p__Object_Boolean
		{
			get
			{
				if(r_RRegister_Action_d_Object_p__Object_Boolean == null)
				{
					r_RRegister_Action_d_Object_p__Object_Boolean = new(this, "Register", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Object)), typeof(System.Object), typeof(System.Boolean));
					r_RRegister_Action_d_Object_p__Object_Boolean.SetBelong(this.instance);
				}
				return r_RRegister_Action_d_Object_p__Object_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.CancellationTokenRegistration InternalRegisterWithoutEC(System.Action`1[System.Object], System.Object)
		/// </summary>
		protected RMethod r_RInternalRegisterWithoutEC_Action_d_Object_p__Object;
		public virtual RMethod RInternalRegisterWithoutEC_Action_d_Object_p__Object
		{
			get
			{
				if(r_RInternalRegisterWithoutEC_Action_d_Object_p__Object == null)
				{
					r_RInternalRegisterWithoutEC_Action_d_Object_p__Object = new(this, "InternalRegisterWithoutEC", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Object)), typeof(System.Object));
					r_RInternalRegisterWithoutEC_Action_d_Object_p__Object.SetBelong(this.instance);
				}
				return r_RInternalRegisterWithoutEC_Action_d_Object_p__Object;
			}
		}

		/// <summary>
		/// System.Threading.CancellationTokenRegistration Register(System.Action`1[System.Object], System.Object, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RRegister_Action_d_Object_p__Object_Boolean_Boolean;
		public virtual RMethod RRegister_Action_d_Object_p__Object_Boolean_Boolean
		{
			get
			{
				if(r_RRegister_Action_d_Object_p__Object_Boolean_Boolean == null)
				{
					r_RRegister_Action_d_Object_p__Object_Boolean_Boolean = new(this, "Register", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Object)), typeof(System.Object), typeof(System.Boolean), typeof(System.Boolean));
					r_RRegister_Action_d_Object_p__Object_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RRegister_Action_d_Object_p__Object_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_REquals_CancellationToken;
		public virtual RMethod REquals_CancellationToken
		{
			get
			{
				if(r_REquals_CancellationToken == null)
				{
					r_REquals_CancellationToken = new(this, "Equals", 0, typeof(System.Threading.CancellationToken));
					r_REquals_CancellationToken.SetBelong(this.instance);
				}
				return r_REquals_CancellationToken;
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
		/// Boolean op_Equality(System.Threading.CancellationToken, System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_Rop_Equality_CancellationToken_CancellationToken;
		public static RMethod Rop_Equality_CancellationToken_CancellationToken
		{
			get
			{
				if(r_Rop_Equality_CancellationToken_CancellationToken == null)
				{
					r_Rop_Equality_CancellationToken_CancellationToken = new(typeof(System.Threading.CancellationToken), "op_Equality", 0, typeof(System.Threading.CancellationToken), typeof(System.Threading.CancellationToken));
					r_Rop_Equality_CancellationToken_CancellationToken.SetBelong(null);
				}
				return r_Rop_Equality_CancellationToken_CancellationToken;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Threading.CancellationToken, System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_Rop_Inequality_CancellationToken_CancellationToken;
		public static RMethod Rop_Inequality_CancellationToken_CancellationToken
		{
			get
			{
				if(r_Rop_Inequality_CancellationToken_CancellationToken == null)
				{
					r_Rop_Inequality_CancellationToken_CancellationToken = new(typeof(System.Threading.CancellationToken), "op_Inequality", 0, typeof(System.Threading.CancellationToken), typeof(System.Threading.CancellationToken));
					r_Rop_Inequality_CancellationToken_CancellationToken.SetBelong(null);
				}
				return r_Rop_Inequality_CancellationToken_CancellationToken;
			}
		}

		/// <summary>
		/// Void ThrowIfCancellationRequested()
		/// </summary>
		protected RMethod r_RThrowIfCancellationRequested;
		public virtual RMethod RThrowIfCancellationRequested
		{
			get
			{
				if(r_RThrowIfCancellationRequested == null)
				{
					r_RThrowIfCancellationRequested = new(this, "ThrowIfCancellationRequested", 0);
					r_RThrowIfCancellationRequested.SetBelong(this.instance);
				}
				return r_RThrowIfCancellationRequested;
			}
		}

		/// <summary>
		/// Void ThrowOperationCanceledException()
		/// </summary>
		protected RMethod r_RThrowOperationCanceledException;
		public virtual RMethod RThrowOperationCanceledException
		{
			get
			{
				if(r_RThrowOperationCanceledException == null)
				{
					r_RThrowOperationCanceledException = new(this, "ThrowOperationCanceledException", 0);
					r_RThrowOperationCanceledException.SetBelong(this.instance);
				}
				return r_RThrowOperationCanceledException;
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


        public RCancellationToken() : base("System.Threading.CancellationToken")
        {
        }

        public RCancellationToken(System.Object instance) : base("System.Threading.CancellationToken")
		{
            SetInstance(instance);
		}

        public RCancellationToken(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCancellationToken(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Threading.CancellationTokenRegistration Register(System.Action  @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback};
            var ___result = RRegister_Action.Invoke(___genericsType, ___parameters);

            return (System.Threading.CancellationTokenRegistration)___result;
        }


        public virtual System.Threading.CancellationTokenRegistration Register(System.Action  @callback, System.Boolean  @useSynchronizationContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @useSynchronizationContext};
            var ___result = RRegister_Action_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Threading.CancellationTokenRegistration)___result;
        }


        public virtual System.Threading.CancellationTokenRegistration Register(System.Action<System.Object>  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @state};
            var ___result = RRegister_Action_d_Object_p__Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.CancellationTokenRegistration)___result;
        }


        public virtual System.Threading.CancellationTokenRegistration Register(System.Action<System.Object>  @callback, System.Object  @state, System.Boolean  @useSynchronizationContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @state, @useSynchronizationContext};
            var ___result = RRegister_Action_d_Object_p__Object_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Threading.CancellationTokenRegistration)___result;
        }


        public virtual System.Threading.CancellationTokenRegistration InternalRegisterWithoutEC(System.Action<System.Object>  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @state};
            var ___result = RInternalRegisterWithoutEC_Action_d_Object_p__Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.CancellationTokenRegistration)___result;
        }


        public virtual System.Threading.CancellationTokenRegistration Register(System.Action<System.Object>  @callback, System.Object  @state, System.Boolean  @useSynchronizationContext, System.Boolean  @useExecutionContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @state, @useSynchronizationContext, @useExecutionContext};
            var ___result = RRegister_Action_d_Object_p__Object_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Threading.CancellationTokenRegistration)___result;
        }


        public virtual System.Boolean Equals(System.Threading.CancellationToken  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
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


        public static System.Boolean op_Equality(System.Threading.CancellationToken  @left, System.Threading.CancellationToken  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_CancellationToken_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Threading.CancellationToken  @left, System.Threading.CancellationToken  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_CancellationToken_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ThrowIfCancellationRequested()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RThrowIfCancellationRequested.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowOperationCanceledException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RThrowOperationCanceledException.Invoke(___genericsType, ___parameters);

            
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
