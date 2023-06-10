
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal
{
	/// <summary>
	/// System.Security.Principal.IPrincipal
	/// </summary>
    public partial class RIPrincipal : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Security.Principal.IPrincipal);
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


		/// <summary>
		/// System.Security.Principal.IIdentity Identity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RIIdentity r_PIdentity;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RIIdentity RPIdentity
		{
			get
			{
				if(r_PIdentity == null)
				{
					r_PIdentity = new(this, "Identity", -1);
				}
				return r_PIdentity;
			}
		}

		/// <summary>
		/// Boolean IsInRole(System.String)
		/// </summary>
		protected RMethod r_MIsInRole_String;
		public virtual RMethod RMIsInRole_String
		{
			get
			{
				if(r_MIsInRole_String == null)
				{
					r_MIsInRole_String = new(this, "IsInRole", 0, typeof(System.String));
				}
				return r_MIsInRole_String;
			}
		}


        public virtual System.Boolean IsInRole(System.String @role)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@role};
            var ___result = RMIsInRole_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


    }
}
