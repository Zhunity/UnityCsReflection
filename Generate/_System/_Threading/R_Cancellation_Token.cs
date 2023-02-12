
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
		protected SMFrame.Editor.Refleaction.RSystem.RThreading.RCancellationTokenSource r_F_source;
		public virtual SMFrame.Editor.Refleaction.RSystem.RThreading.RCancellationTokenSource RF_source
		{
			get
			{
				if(r_F_source == null)
				{
					r_F_source = new(this, "_source");
					r_F_source.SetBelong(this.instance);
				}
				return r_F_source;
			}
		}

		/// <summary>
		/// System.Action`1[System.Object] s_actionToActionObjShunt
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RObject> r_Fs_actionToActionObjShunt;
		public static SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RObject> RFs_actionToActionObjShunt
		{
			get
			{
				if(r_Fs_actionToActionObjShunt == null)
				{
					r_Fs_actionToActionObjShunt = new(typeof(System.Threading.CancellationToken), "s_actionToActionObjShunt");
					r_Fs_actionToActionObjShunt.SetBelong(null);
				}
				return r_Fs_actionToActionObjShunt;
			}
		}

		/// <summary>
		/// System.Threading.CancellationToken None
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RCancellationToken r_PNone;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RCancellationToken RPNone
		{
			get
			{
				if(r_PNone == null)
				{
					r_PNone = new(typeof(System.Threading.CancellationToken), "None", -1);
					r_PNone.SetBelong(null);
				}
				return r_PNone;
			}
		}

		/// <summary>
		/// Boolean IsCancellationRequested
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsCancellationRequested;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsCancellationRequested
		{
			get
			{
				if(r_PIsCancellationRequested == null)
				{
					r_PIsCancellationRequested = new(this, "IsCancellationRequested", -1);
					r_PIsCancellationRequested.SetBelong(this.instance);
				}
				return r_PIsCancellationRequested;
			}
		}

		/// <summary>
		/// Boolean CanBeCanceled
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PCanBeCanceled;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPCanBeCanceled
		{
			get
			{
				if(r_PCanBeCanceled == null)
				{
					r_PCanBeCanceled = new(this, "CanBeCanceled", -1);
					r_PCanBeCanceled.SetBelong(this.instance);
				}
				return r_PCanBeCanceled;
			}
		}

		/// <summary>
		/// System.Threading.WaitHandle WaitHandle
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RThreading.RWaitHandle r_PWaitHandle;
		public virtual SMFrame.Editor.Refleaction.RSystem.RThreading.RWaitHandle RPWaitHandle
		{
			get
			{
				if(r_PWaitHandle == null)
				{
					r_PWaitHandle = new(this, "WaitHandle", -1);
					r_PWaitHandle.SetBelong(this.instance);
				}
				return r_PWaitHandle;
			}
		}

		/// <summary>
		/// System.Threading.CancellationTokenRegistration Register(System.Action)
		/// </summary>
		protected RMethod r_MRegister_Action;
		public virtual RMethod RMRegister_Action
		{
			get
			{
				if(r_MRegister_Action == null)
				{
					r_MRegister_Action = new(this, "Register", 0, typeof(System.Action));
					r_MRegister_Action.SetBelong(this.instance);
				}
				return r_MRegister_Action;
			}
		}

		/// <summary>
		/// System.Threading.CancellationTokenRegistration Register(System.Action, Boolean)
		/// </summary>
		protected RMethod r_MRegister_Action_Boolean;
		public virtual RMethod RMRegister_Action_Boolean
		{
			get
			{
				if(r_MRegister_Action_Boolean == null)
				{
					r_MRegister_Action_Boolean = new(this, "Register", 0, typeof(System.Action), typeof(System.Boolean));
					r_MRegister_Action_Boolean.SetBelong(this.instance);
				}
				return r_MRegister_Action_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.CancellationTokenRegistration Register(System.Action`1[System.Object], System.Object)
		/// </summary>
		protected RMethod r_MRegister_Action_d_Object_p__Object;
		public virtual RMethod RMRegister_Action_d_Object_p__Object
		{
			get
			{
				if(r_MRegister_Action_d_Object_p__Object == null)
				{
					r_MRegister_Action_d_Object_p__Object = new(this, "Register", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Object)), typeof(System.Object));
					r_MRegister_Action_d_Object_p__Object.SetBelong(this.instance);
				}
				return r_MRegister_Action_d_Object_p__Object;
			}
		}

		/// <summary>
		/// System.Threading.CancellationTokenRegistration Register(System.Action`1[System.Object], System.Object, Boolean)
		/// </summary>
		protected RMethod r_MRegister_Action_d_Object_p__Object_Boolean;
		public virtual RMethod RMRegister_Action_d_Object_p__Object_Boolean
		{
			get
			{
				if(r_MRegister_Action_d_Object_p__Object_Boolean == null)
				{
					r_MRegister_Action_d_Object_p__Object_Boolean = new(this, "Register", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Object)), typeof(System.Object), typeof(System.Boolean));
					r_MRegister_Action_d_Object_p__Object_Boolean.SetBelong(this.instance);
				}
				return r_MRegister_Action_d_Object_p__Object_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.CancellationTokenRegistration InternalRegisterWithoutEC(System.Action`1[System.Object], System.Object)
		/// </summary>
		protected RMethod r_MInternalRegisterWithoutEC_Action_d_Object_p__Object;
		public virtual RMethod RMInternalRegisterWithoutEC_Action_d_Object_p__Object
		{
			get
			{
				if(r_MInternalRegisterWithoutEC_Action_d_Object_p__Object == null)
				{
					r_MInternalRegisterWithoutEC_Action_d_Object_p__Object = new(this, "InternalRegisterWithoutEC", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Object)), typeof(System.Object));
					r_MInternalRegisterWithoutEC_Action_d_Object_p__Object.SetBelong(this.instance);
				}
				return r_MInternalRegisterWithoutEC_Action_d_Object_p__Object;
			}
		}

		/// <summary>
		/// System.Threading.CancellationTokenRegistration Register(System.Action`1[System.Object], System.Object, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MRegister_Action_d_Object_p__Object_Boolean_Boolean;
		public virtual RMethod RMRegister_Action_d_Object_p__Object_Boolean_Boolean
		{
			get
			{
				if(r_MRegister_Action_d_Object_p__Object_Boolean_Boolean == null)
				{
					r_MRegister_Action_d_Object_p__Object_Boolean_Boolean = new(this, "Register", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Object)), typeof(System.Object), typeof(System.Boolean), typeof(System.Boolean));
					r_MRegister_Action_d_Object_p__Object_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MRegister_Action_d_Object_p__Object_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MEquals_CancellationToken;
		public virtual RMethod RMEquals_CancellationToken
		{
			get
			{
				if(r_MEquals_CancellationToken == null)
				{
					r_MEquals_CancellationToken = new(this, "Equals", 0, typeof(System.Threading.CancellationToken));
					r_MEquals_CancellationToken.SetBelong(this.instance);
				}
				return r_MEquals_CancellationToken;
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
		/// Boolean op_Equality(System.Threading.CancellationToken, System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_Mop_Equality_CancellationToken_CancellationToken;
		public static RMethod RMop_Equality_CancellationToken_CancellationToken
		{
			get
			{
				if(r_Mop_Equality_CancellationToken_CancellationToken == null)
				{
					r_Mop_Equality_CancellationToken_CancellationToken = new(typeof(System.Threading.CancellationToken), "op_Equality", 0, typeof(System.Threading.CancellationToken), typeof(System.Threading.CancellationToken));
					r_Mop_Equality_CancellationToken_CancellationToken.SetBelong(null);
				}
				return r_Mop_Equality_CancellationToken_CancellationToken;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Threading.CancellationToken, System.Threading.CancellationToken)
		/// </summary>
		protected static RMethod r_Mop_Inequality_CancellationToken_CancellationToken;
		public static RMethod RMop_Inequality_CancellationToken_CancellationToken
		{
			get
			{
				if(r_Mop_Inequality_CancellationToken_CancellationToken == null)
				{
					r_Mop_Inequality_CancellationToken_CancellationToken = new(typeof(System.Threading.CancellationToken), "op_Inequality", 0, typeof(System.Threading.CancellationToken), typeof(System.Threading.CancellationToken));
					r_Mop_Inequality_CancellationToken_CancellationToken.SetBelong(null);
				}
				return r_Mop_Inequality_CancellationToken_CancellationToken;
			}
		}

		/// <summary>
		/// Void ThrowIfCancellationRequested()
		/// </summary>
		protected RMethod r_MThrowIfCancellationRequested;
		public virtual RMethod RMThrowIfCancellationRequested
		{
			get
			{
				if(r_MThrowIfCancellationRequested == null)
				{
					r_MThrowIfCancellationRequested = new(this, "ThrowIfCancellationRequested", 0);
					r_MThrowIfCancellationRequested.SetBelong(this.instance);
				}
				return r_MThrowIfCancellationRequested;
			}
		}

		/// <summary>
		/// Void ThrowOperationCanceledException()
		/// </summary>
		protected RMethod r_MThrowOperationCanceledException;
		public virtual RMethod RMThrowOperationCanceledException
		{
			get
			{
				if(r_MThrowOperationCanceledException == null)
				{
					r_MThrowOperationCanceledException = new(this, "ThrowOperationCanceledException", 0);
					r_MThrowOperationCanceledException.SetBelong(this.instance);
				}
				return r_MThrowOperationCanceledException;
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

        public virtual System.Threading.CancellationTokenRegistration Register(System.Action @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback};
            var ___result = RMRegister_Action.Invoke(___genericsType, ___parameters);

            return (System.Threading.CancellationTokenRegistration)___result;
        }


        public virtual System.Threading.CancellationTokenRegistration Register(System.Action @callback, System.Boolean @useSynchronizationContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @useSynchronizationContext};
            var ___result = RMRegister_Action_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Threading.CancellationTokenRegistration)___result;
        }


        public virtual System.Threading.CancellationTokenRegistration Register(System.Action<System.Object> @callback, System.Object @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @state};
            var ___result = RMRegister_Action_d_Object_p__Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.CancellationTokenRegistration)___result;
        }


        public virtual System.Threading.CancellationTokenRegistration Register(System.Action<System.Object> @callback, System.Object @state, System.Boolean @useSynchronizationContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @state, @useSynchronizationContext};
            var ___result = RMRegister_Action_d_Object_p__Object_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Threading.CancellationTokenRegistration)___result;
        }


        public virtual System.Threading.CancellationTokenRegistration InternalRegisterWithoutEC(System.Action<System.Object> @callback, System.Object @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @state};
            var ___result = RMInternalRegisterWithoutEC_Action_d_Object_p__Object.Invoke(___genericsType, ___parameters);

            return (System.Threading.CancellationTokenRegistration)___result;
        }


        public virtual System.Threading.CancellationTokenRegistration Register(System.Action<System.Object> @callback, System.Object @state, System.Boolean @useSynchronizationContext, System.Boolean @useExecutionContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @state, @useSynchronizationContext, @useExecutionContext};
            var ___result = RMRegister_Action_d_Object_p__Object_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Threading.CancellationTokenRegistration)___result;
        }


        public virtual System.Boolean Equals(System.Threading.CancellationToken @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
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


        public static System.Boolean op_Equality(System.Threading.CancellationToken @left, System.Threading.CancellationToken @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_CancellationToken_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Threading.CancellationToken @left, System.Threading.CancellationToken @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_CancellationToken_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ThrowIfCancellationRequested()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMThrowIfCancellationRequested.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowOperationCanceledException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMThrowOperationCanceledException.Invoke(___genericsType, ___parameters);

            
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