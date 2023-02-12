
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
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
					r_PName.SetBelong(this.instance);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// System.String AuthenticationType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PAuthenticationType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPAuthenticationType
		{
			get
			{
				if(r_PAuthenticationType == null)
				{
					r_PAuthenticationType = new(this, "AuthenticationType", -1);
					r_PAuthenticationType.SetBelong(this.instance);
				}
				return r_PAuthenticationType;
			}
		}

		/// <summary>
		/// Boolean IsAuthenticated
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsAuthenticated;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsAuthenticated
		{
			get
			{
				if(r_PIsAuthenticated == null)
				{
					r_PIsAuthenticated = new(this, "IsAuthenticated", -1);
					r_PIsAuthenticated.SetBelong(this.instance);
				}
				return r_PIsAuthenticated;
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