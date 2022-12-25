using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RLifetime
{
	/// <summary>
	/// System.Runtime.Remoting.Lifetime.ISponsor
	/// </summary>
    public partial class RISponsor : RMember //
    {

		/// <summary>
		/// System.TimeSpan Renewal(System.Runtime.Remoting.Lifetime.ILease)
		/// </summary>
		protected RMethod r_RRenewal_ILease;
		public virtual RMethod RRenewal_ILease
		{
			get
			{
				if(r_RRenewal_ILease == null)
				{
					r_RRenewal_ILease = new(this, "Renewal", 0, typeof(System.Runtime.Remoting.Lifetime.ILease));
					r_RRenewal_ILease.SetBelong(this.instance);
				}
				return r_RRenewal_ILease;
			}
		}


        public RISponsor() : base("System.Runtime.Remoting.Lifetime.ISponsor")
        {
        }

        public RISponsor(System.Object instance) : base("System.Runtime.Remoting.Lifetime.ISponsor")
		{
            SetInstance(instance);
		}

        public RISponsor(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RISponsor(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.TimeSpan Renewal(System.Runtime.Remoting.Lifetime.ILease  @lease)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lease};
            var ___result = RRenewal_ILease.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


    }
}
