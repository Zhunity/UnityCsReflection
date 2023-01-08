using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.CancellationTokenRegistration
	/// </summary>
    public partial class RCancellationTokenRegistration : RMember //
    {

		/// <summary>
		/// System.Threading.CancellationCallbackInfo m_callbackInfo
		/// </summary>
		protected RSystem.RThreading.RCancellationCallbackInfo r_m_callbackInfo;
		public virtual RSystem.RThreading.RCancellationCallbackInfo Rm_callbackInfo
		{
			get
			{
				if(r_m_callbackInfo == null)
				{
					r_m_callbackInfo = new(this, "m_callbackInfo");
					r_m_callbackInfo.SetBelong(this.instance);
				}
				return r_m_callbackInfo;
			}
		}

		/// <summary>
		/// System.Threading.SparselyPopulatedArrayAddInfo`1[System.Threading.CancellationCallbackInfo] m_registrationInfo
		/// </summary>
		protected RSystem.RThreading.RSparselyPopulatedArrayAddInfo<RSystem.RThreading.RCancellationCallbackInfo> r_m_registrationInfo;
		public virtual RSystem.RThreading.RSparselyPopulatedArrayAddInfo<RSystem.RThreading.RCancellationCallbackInfo> Rm_registrationInfo
		{
			get
			{
				if(r_m_registrationInfo == null)
				{
					r_m_registrationInfo = new(this, "m_registrationInfo");
					r_m_registrationInfo.SetBelong(this.instance);
				}
				return r_m_registrationInfo;
			}
		}

		/// <summary>
		/// System.Threading.CancellationToken Token
		/// </summary>
		protected RSystem.RThreading.RCancellationToken r_Token;
		public virtual RSystem.RThreading.RCancellationToken RToken
		{
			get
			{
				if(r_Token == null)
				{
					r_Token = new(this, "Token", -1);
					r_Token.SetBelong(this.instance);
				}
				return r_Token;
			}
		}

		/// <summary>
		/// Boolean Unregister()
		/// </summary>
		protected RMethod r_Unregister;
		public virtual RMethod RUnregister
		{
			get
			{
				if(r_Unregister == null)
				{
					r_Unregister = new(this, "Unregister", 0);
					r_Unregister.SetBelong(this.instance);
				}
				return r_Unregister;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_Dispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_Dispose == null)
				{
					r_Dispose = new(this, "Dispose", 0);
					r_Dispose.SetBelong(this.instance);
				}
				return r_Dispose;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Threading.CancellationTokenRegistration, System.Threading.CancellationTokenRegistration)
		/// </summary>
		protected static RMethod r_op_Equality_CancellationTokenRegistration_CancellationTokenRegistration;
		public static RMethod Rop_Equality_CancellationTokenRegistration_CancellationTokenRegistration
		{
			get
			{
				if(r_op_Equality_CancellationTokenRegistration_CancellationTokenRegistration == null)
				{
					r_op_Equality_CancellationTokenRegistration_CancellationTokenRegistration = new(typeof(System.Threading.CancellationTokenRegistration), "op_Equality", 0, typeof(System.Threading.CancellationTokenRegistration), typeof(System.Threading.CancellationTokenRegistration));
					r_op_Equality_CancellationTokenRegistration_CancellationTokenRegistration.SetBelong(null);
				}
				return r_op_Equality_CancellationTokenRegistration_CancellationTokenRegistration;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Threading.CancellationTokenRegistration, System.Threading.CancellationTokenRegistration)
		/// </summary>
		protected static RMethod r_op_Inequality_CancellationTokenRegistration_CancellationTokenRegistration;
		public static RMethod Rop_Inequality_CancellationTokenRegistration_CancellationTokenRegistration
		{
			get
			{
				if(r_op_Inequality_CancellationTokenRegistration_CancellationTokenRegistration == null)
				{
					r_op_Inequality_CancellationTokenRegistration_CancellationTokenRegistration = new(typeof(System.Threading.CancellationTokenRegistration), "op_Inequality", 0, typeof(System.Threading.CancellationTokenRegistration), typeof(System.Threading.CancellationTokenRegistration));
					r_op_Inequality_CancellationTokenRegistration_CancellationTokenRegistration.SetBelong(null);
				}
				return r_op_Inequality_CancellationTokenRegistration_CancellationTokenRegistration;
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
		/// Boolean Equals(System.Threading.CancellationTokenRegistration)
		/// </summary>
		protected RMethod r_Equals_CancellationTokenRegistration;
		public virtual RMethod REquals_CancellationTokenRegistration
		{
			get
			{
				if(r_Equals_CancellationTokenRegistration == null)
				{
					r_Equals_CancellationTokenRegistration = new(this, "Equals", 0, typeof(System.Threading.CancellationTokenRegistration));
					r_Equals_CancellationTokenRegistration.SetBelong(this.instance);
				}
				return r_Equals_CancellationTokenRegistration;
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
		/// System.Threading.Tasks.ValueTask DisposeAsync()
		/// </summary>
		protected RMethod r_DisposeAsync;
		public virtual RMethod RDisposeAsync
		{
			get
			{
				if(r_DisposeAsync == null)
				{
					r_DisposeAsync = new(this, "DisposeAsync", 0);
					r_DisposeAsync.SetBelong(this.instance);
				}
				return r_DisposeAsync;
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


        public RCancellationTokenRegistration() : base("System.Threading.CancellationTokenRegistration")
        {
        }

        public RCancellationTokenRegistration(System.Object instance) : base("System.Threading.CancellationTokenRegistration")
		{
            SetInstance(instance);
		}

        public RCancellationTokenRegistration(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCancellationTokenRegistration(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Unregister()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnregister.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean op_Equality(System.Threading.CancellationTokenRegistration  @left, System.Threading.CancellationTokenRegistration  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_CancellationTokenRegistration_CancellationTokenRegistration.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Threading.CancellationTokenRegistration  @left, System.Threading.CancellationTokenRegistration  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_CancellationTokenRegistration_CancellationTokenRegistration.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Threading.CancellationTokenRegistration  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_CancellationTokenRegistration.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Threading.Tasks.ValueTask DisposeAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDisposeAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask)___result;
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
