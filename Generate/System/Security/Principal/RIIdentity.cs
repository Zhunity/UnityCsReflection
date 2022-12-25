using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RPrincipal
{
	/// <summary>
	/// System.Security.Principal.IIdentity
	/// </summary>
    public partial class RIIdentity : RMember //
    {

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RProperty r_Name;
		public virtual RProperty RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name", -1);
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
			}
		}

		/// <summary>
		/// System.String AuthenticationType
		/// </summary>
		protected RProperty r_AuthenticationType;
		public virtual RProperty RAuthenticationType
		{
			get
			{
				if(r_AuthenticationType == null)
				{
					r_AuthenticationType = new(this, "AuthenticationType", -1);
					r_AuthenticationType.SetBelong(this.instance);
				}
				return r_AuthenticationType;
			}
		}

		/// <summary>
		/// Boolean IsAuthenticated
		/// </summary>
		protected RProperty r_IsAuthenticated;
		public virtual RProperty RIsAuthenticated
		{
			get
			{
				if(r_IsAuthenticated == null)
				{
					r_IsAuthenticated = new(this, "IsAuthenticated", -1);
					r_IsAuthenticated.SetBelong(this.instance);
				}
				return r_IsAuthenticated;
			}
		}


        public RIIdentity() : base("System.Security.Principal.IIdentity")
        {
        }

        public RIIdentity(System.Object instance) : base("System.Security.Principal.IIdentity")
		{
            SetInstance(instance);
		}

        public RIIdentity(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIIdentity(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

    }
}
