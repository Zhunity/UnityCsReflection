
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RContexts
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Runtime.Remoting.Contexts.IDynamicProperty
	/// </summary>
    public partial class RIDynamicProperty : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Runtime.Remoting.Contexts.IDynamicProperty);
            }
        }

        public RIDynamicProperty() : base("System.Runtime.Remoting.Contexts.IDynamicProperty")
        {
        }

        public RIDynamicProperty(System.Object instance) : base("System.Runtime.Remoting.Contexts.IDynamicProperty")
		{
            SetInstance(instance);
		}

        public RIDynamicProperty(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIDynamicProperty(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String Name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
				}
				return r_PName;
			}
		}


    }
}
