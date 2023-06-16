
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.TypeIdentifier
	/// </summary>
    public partial class RTypeIdentifier : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.TypeIdentifier");
            }
        }

        public RTypeIdentifier() : base("System.TypeIdentifier")
        {
        }

        public RTypeIdentifier(System.Object instance) : base("System.TypeIdentifier")
		{
            SetInstance(instance);
		}

        public RTypeIdentifier(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTypeIdentifier(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String InternalName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PInternalName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPInternalName
		{
			get
			{
				if(r_PInternalName == null)
				{
					r_PInternalName = new(this, "InternalName", -1);
				}
				return r_PInternalName;
			}
		}


    }
}
