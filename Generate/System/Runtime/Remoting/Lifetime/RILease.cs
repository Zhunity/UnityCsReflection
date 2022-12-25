using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RLifetime
{
	/// <summary>
	/// System.Runtime.Remoting.Lifetime.ILease
	/// </summary>
    public partial class RILease : RMember //
    {

		/// <summary>
		/// System.TimeSpan CurrentLeaseTime
		/// </summary>
		protected RSystem.RTimeSpan r_CurrentLeaseTime;
		public virtual RSystem.RTimeSpan RCurrentLeaseTime
		{
			get
			{
				if(r_CurrentLeaseTime == null)
				{
					r_CurrentLeaseTime = new(this, "CurrentLeaseTime", -1);
					r_CurrentLeaseTime.SetBelong(this.instance);
				}
				return r_CurrentLeaseTime;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Lifetime.LeaseState CurrentState
		/// </summary>
		protected RProperty r_CurrentState;
		public virtual RProperty RCurrentState
		{
			get
			{
				if(r_CurrentState == null)
				{
					r_CurrentState = new(this, "CurrentState", -1);
					r_CurrentState.SetBelong(this.instance);
				}
				return r_CurrentState;
			}
		}

		/// <summary>
		/// System.TimeSpan InitialLeaseTime
		/// </summary>
		protected RSystem.RTimeSpan r_InitialLeaseTime;
		public virtual RSystem.RTimeSpan RInitialLeaseTime
		{
			get
			{
				if(r_InitialLeaseTime == null)
				{
					r_InitialLeaseTime = new(this, "InitialLeaseTime", -1);
					r_InitialLeaseTime.SetBelong(this.instance);
				}
				return r_InitialLeaseTime;
			}
		}

		/// <summary>
		/// System.TimeSpan RenewOnCallTime
		/// </summary>
		protected RSystem.RTimeSpan r_RenewOnCallTime;
		public virtual RSystem.RTimeSpan RenewOnCallTime
		{
			get
			{
				if(r_RenewOnCallTime == null)
				{
					r_RenewOnCallTime = new(this, "RenewOnCallTime", -1);
					r_RenewOnCallTime.SetBelong(this.instance);
				}
				return r_RenewOnCallTime;
			}
		}

		/// <summary>
		/// System.TimeSpan SponsorshipTimeout
		/// </summary>
		protected RSystem.RTimeSpan r_SponsorshipTimeout;
		public virtual RSystem.RTimeSpan RSponsorshipTimeout
		{
			get
			{
				if(r_SponsorshipTimeout == null)
				{
					r_SponsorshipTimeout = new(this, "SponsorshipTimeout", -1);
					r_SponsorshipTimeout.SetBelong(this.instance);
				}
				return r_SponsorshipTimeout;
			}
		}

		/// <summary>
		/// Void Register(System.Runtime.Remoting.Lifetime.ISponsor)
		/// </summary>
		protected RMethod r_RRegister_ISponsor;
		public virtual RMethod RRegister_ISponsor
		{
			get
			{
				if(r_RRegister_ISponsor == null)
				{
					r_RRegister_ISponsor = new(this, "Register", 0, typeof(System.Runtime.Remoting.Lifetime.ISponsor));
					r_RRegister_ISponsor.SetBelong(this.instance);
				}
				return r_RRegister_ISponsor;
			}
		}

		/// <summary>
		/// Void Register(System.Runtime.Remoting.Lifetime.ISponsor, System.TimeSpan)
		/// </summary>
		protected RMethod r_RRegister_ISponsor_TimeSpan;
		public virtual RMethod RRegister_ISponsor_TimeSpan
		{
			get
			{
				if(r_RRegister_ISponsor_TimeSpan == null)
				{
					r_RRegister_ISponsor_TimeSpan = new(this, "Register", 0, typeof(System.Runtime.Remoting.Lifetime.ISponsor), typeof(System.TimeSpan));
					r_RRegister_ISponsor_TimeSpan.SetBelong(this.instance);
				}
				return r_RRegister_ISponsor_TimeSpan;
			}
		}

		/// <summary>
		/// System.TimeSpan Renew(System.TimeSpan)
		/// </summary>
		protected RMethod r_RRenew_TimeSpan;
		public virtual RMethod RRenew_TimeSpan
		{
			get
			{
				if(r_RRenew_TimeSpan == null)
				{
					r_RRenew_TimeSpan = new(this, "Renew", 0, typeof(System.TimeSpan));
					r_RRenew_TimeSpan.SetBelong(this.instance);
				}
				return r_RRenew_TimeSpan;
			}
		}

		/// <summary>
		/// Void Unregister(System.Runtime.Remoting.Lifetime.ISponsor)
		/// </summary>
		protected RMethod r_RUnregister_ISponsor;
		public virtual RMethod RUnregister_ISponsor
		{
			get
			{
				if(r_RUnregister_ISponsor == null)
				{
					r_RUnregister_ISponsor = new(this, "Unregister", 0, typeof(System.Runtime.Remoting.Lifetime.ISponsor));
					r_RUnregister_ISponsor.SetBelong(this.instance);
				}
				return r_RUnregister_ISponsor;
			}
		}


        public RILease() : base("System.Runtime.Remoting.Lifetime.ILease")
        {
        }

        public RILease(System.Object instance) : base("System.Runtime.Remoting.Lifetime.ILease")
		{
            SetInstance(instance);
		}

        public RILease(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RILease(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Register(System.Runtime.Remoting.Lifetime.ISponsor  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RRegister_ISponsor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Register(System.Runtime.Remoting.Lifetime.ISponsor  @obj, System.TimeSpan  @renewalTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @renewalTime};
            var ___result = RRegister_ISponsor_TimeSpan.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.TimeSpan Renew(System.TimeSpan  @renewalTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renewalTime};
            var ___result = RRenew_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public virtual void Unregister(System.Runtime.Remoting.Lifetime.ISponsor  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RUnregister_ISponsor.Invoke(___genericsType, ___parameters);

            
        }


    }
}
