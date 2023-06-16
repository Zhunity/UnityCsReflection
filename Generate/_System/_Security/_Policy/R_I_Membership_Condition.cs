
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Security.Policy.IMembershipCondition
	/// </summary>
    public partial class RIMembershipCondition : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Security.Policy.IMembershipCondition);
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


		/// <summary>
		/// Boolean Check(System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_MCheck_Evidence;
		public virtual RMethod RMCheck_Evidence
		{
			get
			{
				if(r_MCheck_Evidence == null)
				{
					r_MCheck_Evidence = new(this, "Check", 0, typeof(System.Security.Policy.Evidence));
				}
				return r_MCheck_Evidence;
			}
		}

		/// <summary>
		/// System.Security.Policy.IMembershipCondition Copy()
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
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_MEquals_Object;
		public virtual RMethod RMEquals_Object
		{
			get
			{
				if(r_MEquals_Object == null)
				{
					r_MEquals_Object = new(this, "Equals", 0, typeof(System.Object));
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_MToString;
		public virtual RMethod RMToString
		{
			get
			{
				if(r_MToString == null)
				{
					r_MToString = new(this, "ToString", 0);
				}
				return r_MToString;
			}
		}


        public virtual System.Boolean Check(System.Security.Policy.Evidence @evidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evidence};
            var ___result = RMCheck_Evidence.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Security.Policy.IMembershipCondition Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Security.Policy.IMembershipCondition>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
