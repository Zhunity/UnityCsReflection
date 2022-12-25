using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RPrincipal
{
	/// <summary>
	/// System.Security.Principal.IPrincipal
	/// </summary>
    public partial class RIPrincipal : RMember //
    {

		/// <summary>
		/// System.Security.Principal.IIdentity Identity
		/// </summary>
		protected RSystem.RSecurity.RPrincipal.RIIdentity r_Identity;
		public virtual RSystem.RSecurity.RPrincipal.RIIdentity RIdentity
		{
			get
			{
				if(r_Identity == null)
				{
					r_Identity = new(this, "Identity", -1);
					r_Identity.SetBelong(this.instance);
				}
				return r_Identity;
			}
		}

		/// <summary>
		/// Boolean IsInRole(System.String)
		/// </summary>
		protected RMethod r_RIsInRole_String;
		public virtual RMethod RIsInRole_String
		{
			get
			{
				if(r_RIsInRole_String == null)
				{
					r_RIsInRole_String = new(this, "IsInRole", 0, typeof(System.String));
					r_RIsInRole_String.SetBelong(this.instance);
				}
				return r_RIsInRole_String;
			}
		}


        public RIPrincipal() : base("System.Security.Principal.IPrincipal")
        {
        }

        public RIPrincipal(System.Object instance) : base("System.Security.Principal.IPrincipal")
		{
            SetInstance(instance);
		}

        public RIPrincipal(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIPrincipal(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean IsInRole(System.String  @role)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@role};
            var ___result = RIsInRole_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


    }
}
