using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity
{
	/// <summary>
	/// System.Security.IPermission
	/// </summary>
    public partial class RIPermission : RMember //
    {

		/// <summary>
		/// System.Security.IPermission Copy()
		/// </summary>
		protected RMethod r_RCopy;
		public virtual RMethod RCopy
		{
			get
			{
				if(r_RCopy == null)
				{
					r_RCopy = new(this, "Copy", 0);
					r_RCopy.SetBelong(this.instance);
				}
				return r_RCopy;
			}
		}

		/// <summary>
		/// Void Demand()
		/// </summary>
		protected RMethod r_RDemand;
		public virtual RMethod RDemand
		{
			get
			{
				if(r_RDemand == null)
				{
					r_RDemand = new(this, "Demand", 0);
					r_RDemand.SetBelong(this.instance);
				}
				return r_RDemand;
			}
		}

		/// <summary>
		/// System.Security.IPermission Intersect(System.Security.IPermission)
		/// </summary>
		protected RMethod r_RIntersect_IPermission;
		public virtual RMethod RIntersect_IPermission
		{
			get
			{
				if(r_RIntersect_IPermission == null)
				{
					r_RIntersect_IPermission = new(this, "Intersect", 0, typeof(System.Security.IPermission));
					r_RIntersect_IPermission.SetBelong(this.instance);
				}
				return r_RIntersect_IPermission;
			}
		}

		/// <summary>
		/// Boolean IsSubsetOf(System.Security.IPermission)
		/// </summary>
		protected RMethod r_RIsSubsetOf_IPermission;
		public virtual RMethod RIsSubsetOf_IPermission
		{
			get
			{
				if(r_RIsSubsetOf_IPermission == null)
				{
					r_RIsSubsetOf_IPermission = new(this, "IsSubsetOf", 0, typeof(System.Security.IPermission));
					r_RIsSubsetOf_IPermission.SetBelong(this.instance);
				}
				return r_RIsSubsetOf_IPermission;
			}
		}

		/// <summary>
		/// System.Security.IPermission Union(System.Security.IPermission)
		/// </summary>
		protected RMethod r_RUnion_IPermission;
		public virtual RMethod RUnion_IPermission
		{
			get
			{
				if(r_RUnion_IPermission == null)
				{
					r_RUnion_IPermission = new(this, "Union", 0, typeof(System.Security.IPermission));
					r_RUnion_IPermission.SetBelong(this.instance);
				}
				return r_RUnion_IPermission;
			}
		}


        public RIPermission() : base("System.Security.IPermission")
        {
        }

        public RIPermission(System.Object instance) : base("System.Security.IPermission")
		{
            SetInstance(instance);
		}

        public RIPermission(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIPermission(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Security.IPermission Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCopy.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual void Demand()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDemand.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.IPermission Intersect(System.Security.IPermission  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RIntersect_IPermission.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Boolean IsSubsetOf(System.Security.IPermission  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RIsSubsetOf_IPermission.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Security.IPermission Union(System.Security.IPermission  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RUnion_IPermission.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


    }
}
