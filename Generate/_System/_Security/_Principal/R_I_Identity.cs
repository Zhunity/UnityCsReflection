
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal
{
	/// <summary>
	/// System.Security.Principal.IIdentity
	/// </summary>
    public partial class RIIdentity : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Security.Principal.IIdentity);
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


		/// <summary>
		/// System.String Name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// System.String AuthenticationType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PAuthenticationType;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPAuthenticationType
		{
			get
			{
				if(r_PAuthenticationType == null)
				{
					r_PAuthenticationType = new(this, "AuthenticationType", -1);
				}
				return r_PAuthenticationType;
			}
		}

		/// <summary>
		/// Boolean IsAuthenticated
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsAuthenticated;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsAuthenticated
		{
			get
			{
				if(r_PIsAuthenticated == null)
				{
					r_PIsAuthenticated = new(this, "IsAuthenticated", -1);
				}
				return r_PIsAuthenticated;
			}
		}


    }
}
