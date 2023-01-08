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
		protected RMethod r_Copy;
		public virtual RMethod RCopy
		{
			get
			{
				if(r_Copy == null)
				{
					r_Copy = new(this, "Copy", 0);
					r_Copy.SetBelong(this.instance);
				}
				return r_Copy;
			}
		}

		/// <summary>
		/// Void Demand()
		/// </summary>
		protected RMethod r_Demand;
		public virtual RMethod RDemand
		{
			get
			{
				if(r_Demand == null)
				{
					r_Demand = new(this, "Demand", 0);
					r_Demand.SetBelong(this.instance);
				}
				return r_Demand;
			}
		}

		/// <summary>
		/// System.Security.IPermission Intersect(System.Security.IPermission)
		/// </summary>
		protected RMethod r_Intersect_IPermission;
		public virtual RMethod RIntersect_IPermission
		{
			get
			{
				if(r_Intersect_IPermission == null)
				{
					r_Intersect_IPermission = new(this, "Intersect", 0, typeof(System.Security.IPermission));
					r_Intersect_IPermission.SetBelong(this.instance);
				}
				return r_Intersect_IPermission;
			}
		}

		/// <summary>
		/// Boolean IsSubsetOf(System.Security.IPermission)
		/// </summary>
		protected RMethod r_IsSubsetOf_IPermission;
		public virtual RMethod RIsSubsetOf_IPermission
		{
			get
			{
				if(r_IsSubsetOf_IPermission == null)
				{
					r_IsSubsetOf_IPermission = new(this, "IsSubsetOf", 0, typeof(System.Security.IPermission));
					r_IsSubsetOf_IPermission.SetBelong(this.instance);
				}
				return r_IsSubsetOf_IPermission;
			}
		}

		/// <summary>
		/// System.Security.IPermission Union(System.Security.IPermission)
		/// </summary>
		protected RMethod r_Union_IPermission;
		public virtual RMethod RUnion_IPermission
		{
			get
			{
				if(r_Union_IPermission == null)
				{
					r_Union_IPermission = new(this, "Union", 0, typeof(System.Security.IPermission));
					r_Union_IPermission.SetBelong(this.instance);
				}
				return r_Union_IPermission;
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


        public virtual System.Security.IPermission Intersect(System.Security.IPermission @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RIntersect_IPermission.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Boolean IsSubsetOf(System.Security.IPermission @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RIsSubsetOf_IPermission.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Security.IPermission Union(System.Security.IPermission @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RUnion_IPermission.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


    }
}
