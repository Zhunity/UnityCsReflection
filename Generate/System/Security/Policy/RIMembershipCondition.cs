using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RPolicy
{
	/// <summary>
	/// System.Security.Policy.IMembershipCondition
	/// </summary>
    public partial class RIMembershipCondition : RMember //
    {

		/// <summary>
		/// Boolean Check(System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_Check_Evidence;
		public virtual RMethod RCheck_Evidence
		{
			get
			{
				if(r_Check_Evidence == null)
				{
					r_Check_Evidence = new(this, "Check", 0, typeof(System.Security.Policy.Evidence));
					r_Check_Evidence.SetBelong(this.instance);
				}
				return r_Check_Evidence;
			}
		}

		/// <summary>
		/// System.Security.Policy.IMembershipCondition Copy()
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
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
			}
		}


        public RIMembershipCondition() : base("System.Security.Policy.IMembershipCondition")
        {
        }

        public RIMembershipCondition(System.Object instance) : base("System.Security.Policy.IMembershipCondition")
		{
            SetInstance(instance);
		}

        public RIMembershipCondition(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIMembershipCondition(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Check(System.Security.Policy.Evidence  @evidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evidence};
            var ___result = RCheck_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Security.Policy.IMembershipCondition Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCopy.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.IMembershipCondition)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
