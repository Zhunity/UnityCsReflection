
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.TypeName
	/// </summary>
    public partial class RTypeName : RMember //
    {

		/// <summary>
		/// System.String DisplayName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PDisplayName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPDisplayName
		{
			get
			{
				if(r_PDisplayName == null)
				{
					r_PDisplayName = new(this, "DisplayName", -1);
					r_PDisplayName.SetBelong(this.GetValue());
				}
				return r_PDisplayName;
			}
		}

		/// <summary>
		/// System.TypeName NestedName(System.TypeIdentifier)
		/// </summary>
		protected RMethod r_MNestedName_TypeIdentifier;
		public virtual RMethod RMNestedName_TypeIdentifier
		{
			get
			{
				if(r_MNestedName_TypeIdentifier == null)
				{
					r_MNestedName_TypeIdentifier = new(this, "NestedName", 0,  ReflectionUtils.GetType("System.TypeIdentifier"));
					r_MNestedName_TypeIdentifier.SetBelong(this.GetValue());
				}
				return r_MNestedName_TypeIdentifier;
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

        public virtual Hvak.Editor.Refleaction.RSystem.RTypeName NestedName(Hvak.Editor.Refleaction.RSystem.RTypeIdentifier @innerName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@innerName.Value};
            var ___result = RMNestedName_TypeIdentifier.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RTypeName(___result);
        }


    }
}
