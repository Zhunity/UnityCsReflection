
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Security.IPermission
	/// </summary>
    public partial class RIPermission : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Security.IPermission);
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


		/// <summary>
		/// System.Security.IPermission Copy()
		/// </summary>
		protected RMethod r_MCopy;
		public virtual RMethod RMCopy
		{
			get
			{
				if(r_MCopy == null)
				{
					r_MCopy = new(this, "Copy", 0);
				}
				return r_MCopy;
			}
		}

		/// <summary>
		/// Void Demand()
		/// </summary>
		protected RMethod r_MDemand;
		public virtual RMethod RMDemand
		{
			get
			{
				if(r_MDemand == null)
				{
					r_MDemand = new(this, "Demand", 0);
				}
				return r_MDemand;
			}
		}

		/// <summary>
		/// System.Security.IPermission Intersect(System.Security.IPermission)
		/// </summary>
		protected RMethod r_MIntersect_IPermission;
		public virtual RMethod RMIntersect_IPermission
		{
			get
			{
				if(r_MIntersect_IPermission == null)
				{
					r_MIntersect_IPermission = new(this, "Intersect", 0, typeof(System.Security.IPermission));
				}
				return r_MIntersect_IPermission;
			}
		}

		/// <summary>
		/// Boolean IsSubsetOf(System.Security.IPermission)
		/// </summary>
		protected RMethod r_MIsSubsetOf_IPermission;
		public virtual RMethod RMIsSubsetOf_IPermission
		{
			get
			{
				if(r_MIsSubsetOf_IPermission == null)
				{
					r_MIsSubsetOf_IPermission = new(this, "IsSubsetOf", 0, typeof(System.Security.IPermission));
				}
				return r_MIsSubsetOf_IPermission;
			}
		}

		/// <summary>
		/// System.Security.IPermission Union(System.Security.IPermission)
		/// </summary>
		protected RMethod r_MUnion_IPermission;
		public virtual RMethod RMUnion_IPermission
		{
			get
			{
				if(r_MUnion_IPermission == null)
				{
					r_MUnion_IPermission = new(this, "Union", 0, typeof(System.Security.IPermission));
				}
				return r_MUnion_IPermission;
			}
		}


        public virtual System.Security.IPermission Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Security.IPermission>(___result);
        }


        public virtual void Demand()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDemand.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.IPermission Intersect(System.Security.IPermission @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMIntersect_IPermission.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Security.IPermission>(___result);
        }


        public virtual System.Boolean IsSubsetOf(System.Security.IPermission @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMIsSubsetOf_IPermission.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Security.IPermission Union(System.Security.IPermission @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMUnion_IPermission.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Security.IPermission>(___result);
        }


    }
}
