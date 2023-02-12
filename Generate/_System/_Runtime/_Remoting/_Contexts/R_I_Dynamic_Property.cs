
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RContexts
{
	/// <summary>
	/// System.Runtime.Remoting.Contexts.IDynamicProperty
	/// </summary>
    public partial class RIDynamicProperty : RMember //
    {

		/// <summary>
		/// System.String Name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
					r_PName.SetBelong(this.instance);
				}
				return r_PName;
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

    }
}