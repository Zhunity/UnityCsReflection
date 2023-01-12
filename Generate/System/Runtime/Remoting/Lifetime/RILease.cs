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
		protected RSystem.RTimeSpan r_PCurrentLeaseTime;
		public virtual RSystem.RTimeSpan RPCurrentLeaseTime
		{
			get
			{
				if(r_PCurrentLeaseTime == null)
				{
					r_PCurrentLeaseTime = new(this, "CurrentLeaseTime", -1);
					r_PCurrentLeaseTime.SetBelong(this.instance);
				}
				return r_PCurrentLeaseTime;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Lifetime.LeaseState CurrentState
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RLifetime.RLeaseState r_PCurrentState;
		public virtual RSystem.RRuntime.RRemoting.RLifetime.RLeaseState RPCurrentState
		{
			get
			{
				if(r_PCurrentState == null)
				{
					r_PCurrentState = new(this, "CurrentState", -1);
					r_PCurrentState.SetBelong(this.instance);
				}
				return r_PCurrentState;
			}
		}

		/// <summary>
		/// System.TimeSpan InitialLeaseTime
		/// </summary>
		protected RSystem.RTimeSpan r_PInitialLeaseTime;
		public virtual RSystem.RTimeSpan RPInitialLeaseTime
		{
			get
			{
				if(r_PInitialLeaseTime == null)
				{
					r_PInitialLeaseTime = new(this, "InitialLeaseTime", -1);
					r_PInitialLeaseTime.SetBelong(this.instance);
				}
				return r_PInitialLeaseTime;
			}
		}

		/// <summary>
		/// System.TimeSpan RenewOnCallTime
		/// </summary>
		protected RSystem.RTimeSpan r_PRenewOnCallTime;
		public virtual RSystem.RTimeSpan RPRenewOnCallTime
		{
			get
			{
				if(r_PRenewOnCallTime == null)
				{
					r_PRenewOnCallTime = new(this, "RenewOnCallTime", -1);
					r_PRenewOnCallTime.SetBelong(this.instance);
				}
				return r_PRenewOnCallTime;
			}
		}

		/// <summary>
		/// System.TimeSpan SponsorshipTimeout
		/// </summary>
		protected RSystem.RTimeSpan r_PSponsorshipTimeout;
		public virtual RSystem.RTimeSpan RPSponsorshipTimeout
		{
			get
			{
				if(r_PSponsorshipTimeout == null)
				{
					r_PSponsorshipTimeout = new(this, "SponsorshipTimeout", -1);
					r_PSponsorshipTimeout.SetBelong(this.instance);
				}
				return r_PSponsorshipTimeout;
			}
		}

		/// <summary>
		/// Void Register(System.Runtime.Remoting.Lifetime.ISponsor)
		/// </summary>
		protected RMethod r_MRegister_ISponsor;
		public virtual RMethod RMRegister_ISponsor
		{
			get
			{
				if(r_MRegister_ISponsor == null)
				{
					r_MRegister_ISponsor = new(this, "Register", 0, typeof(System.Runtime.Remoting.Lifetime.ISponsor));
					r_MRegister_ISponsor.SetBelong(this.instance);
				}
				return r_MRegister_ISponsor;
			}
		}

		/// <summary>
		/// Void Register(System.Runtime.Remoting.Lifetime.ISponsor, System.TimeSpan)
		/// </summary>
		protected RMethod r_MRegister_ISponsor_TimeSpan;
		public virtual RMethod RMRegister_ISponsor_TimeSpan
		{
			get
			{
				if(r_MRegister_ISponsor_TimeSpan == null)
				{
					r_MRegister_ISponsor_TimeSpan = new(this, "Register", 0, typeof(System.Runtime.Remoting.Lifetime.ISponsor), typeof(System.TimeSpan));
					r_MRegister_ISponsor_TimeSpan.SetBelong(this.instance);
				}
				return r_MRegister_ISponsor_TimeSpan;
			}
		}

		/// <summary>
		/// System.TimeSpan Renew(System.TimeSpan)
		/// </summary>
		protected RMethod r_MRenew_TimeSpan;
		public virtual RMethod RMRenew_TimeSpan
		{
			get
			{
				if(r_MRenew_TimeSpan == null)
				{
					r_MRenew_TimeSpan = new(this, "Renew", 0, typeof(System.TimeSpan));
					r_MRenew_TimeSpan.SetBelong(this.instance);
				}
				return r_MRenew_TimeSpan;
			}
		}

		/// <summary>
		/// Void Unregister(System.Runtime.Remoting.Lifetime.ISponsor)
		/// </summary>
		protected RMethod r_MUnregister_ISponsor;
		public virtual RMethod RMUnregister_ISponsor
		{
			get
			{
				if(r_MUnregister_ISponsor == null)
				{
					r_MUnregister_ISponsor = new(this, "Unregister", 0, typeof(System.Runtime.Remoting.Lifetime.ISponsor));
					r_MUnregister_ISponsor.SetBelong(this.instance);
				}
				return r_MUnregister_ISponsor;
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

        public virtual void Register(System.Runtime.Remoting.Lifetime.ISponsor @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMRegister_ISponsor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Register(System.Runtime.Remoting.Lifetime.ISponsor @obj, System.TimeSpan @renewalTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @renewalTime};
            var ___result = RMRegister_ISponsor_TimeSpan.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.TimeSpan Renew(System.TimeSpan @renewalTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renewalTime};
            var ___result = RMRenew_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public virtual void Unregister(System.Runtime.Remoting.Lifetime.ISponsor @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMUnregister_ISponsor.Invoke(___genericsType, ___parameters);

            
        }


    }
}
