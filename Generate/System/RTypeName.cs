using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.TypeName
	/// </summary>
    public partial class RTypeName : RMember //
    {

		/// <summary>
		/// System.String DisplayName
		/// </summary>
		protected RSystem.RString r_DisplayName;
		public virtual RSystem.RString RDisplayName
		{
			get
			{
				if(r_DisplayName == null)
				{
					r_DisplayName = new(this, "DisplayName", -1);
					r_DisplayName.SetBelong(this.instance);
				}
				return r_DisplayName;
			}
		}

		/// <summary>
		/// System.TypeName NestedName(System.TypeIdentifier)
		/// </summary>
		protected RMethod r_NestedName_TypeIdentifier;
		public virtual RMethod RNestedName_TypeIdentifier
		{
			get
			{
				if(r_NestedName_TypeIdentifier == null)
				{
					r_NestedName_TypeIdentifier = new(this, "NestedName", 0,  ReflectionUtils.GetType("System.TypeIdentifier"));
					r_NestedName_TypeIdentifier.SetBelong(this.instance);
				}
				return r_NestedName_TypeIdentifier;
			}
		}


        public RTypeName() : base("System.TypeName")
        {
        }

        public RTypeName(System.Object instance) : base("System.TypeName")
		{
            SetInstance(instance);
		}

        public RTypeName(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTypeName(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual RSystem.RTypeName NestedName(RSystem.RTypeIdentifier @innerName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@innerName.Value};
            var ___result = RNestedName_TypeIdentifier.Invoke(___genericsType, ___parameters);

            return new RSystem.RTypeName(___result);
        }


    }
}
